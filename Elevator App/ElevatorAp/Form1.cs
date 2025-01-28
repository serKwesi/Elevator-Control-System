using System;
using System.Drawing;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Threading.Tasks;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.Common;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.OleDb;
using Microsoft.VisualBasic.ApplicationServices;
using System.DirectoryServices.ActiveDirectory;
using System.Windows.Input;


namespace ElevatorAp
{
    public partial class Form1 : Form
    {
        private bool isMovingDown = false;
        private bool isMovingUp = false;
        private bool isAtGroundFloor = true;
        private bool isAtFirstFloor = false;
        private int elevatorSpeed = 4;
        private bool doorsAreOpening = false;
        private bool doorsAreClosing = false;
        private int doorSpeed = 5;
        private bool isArrowVisible = true;
        private DataSet ds = new DataSet();
        private string dbconnection;
        private string dbcommand;
        private OleDbConnection conn;
        private OleDbCommand comm;
        private OleDbDataAdapter adapter;
        private OleDbCommandBuilder builder;

        private void Form1_Load(object sender, EventArgs e)
        {
            dbconnection = "Provider=Microsoft.ACE.OLEDB.12.0;" + @"data source = Elevator Database.accdb";
            dbcommand = "Select * from ElevatorLogs;";
            conn = new OleDbConnection(dbconnection);
            comm = new OleDbCommand(dbcommand, conn);
            adapter = new OleDbDataAdapter(comm);
            builder = new OleDbCommandBuilder(adapter);
            load_data_from_db_to_ds();
        }

        public void reload_data_from_db_to_ds()    //force reload the data into the dataset
        {
            //ds.Tables[0].Rows.Clear();
            load_data_from_db_to_ds();
            adapter.Fill(ds, "ElevatorLogs");
        }

        public void save_data_into_db()
        {
            int number_of_row_updated = 0;
            if (ds.Tables[0].Rows.Count != 0)
            {
                try
                {
                    // Get only modified row
                    DataSet dataSetChanges = ds.GetChanges();

                    // Check for changes to avoid null reference exceptions
                    if (dataSetChanges != null)
                    {
                        //number_of_row_updated = adapter.Update(dataSetChanges); // Update database with changes

                        adapter.Update(dataSetChanges, "ElevatorLogs");
                        ds.AcceptChanges(); // Commit changes in the dataset
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }

            // Reload data if database was not updated successfully
            if (number_of_row_updated < 1)
            {
                reload_data_from_db_to_ds();
            }
        }


        public void load_data_from_db_to_ds()  //load the data into the dataset
        {
            try
            {
                ds.Clear();
                adapter.Fill(ds, "ElevatorLogs");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void Insert_Record(string myDate, string myTime, string myActions)
        {
            // Define a new record and place it into a new DataRow
            DataRow newRow = ds.Tables[0].NewRow();
            newRow["MyDate"] = myDate;
            newRow["MyTime"] = myTime;
            newRow["MyActions"] = myActions;

            ds.Tables[0].Rows.Add(newRow);

            //save_data_into_db();    
            UpdateDataGridView();
        }

        private void UpdateDataGridView()
        {
            dataGridView1.Rows.Clear();

            // Add each row from the DataSet to the DataGridView
            foreach (DataRow row in ds.Tables[0].Rows)
            {
                dataGridView1.Rows.Add(row["MyDate"], row["MyTime"], row["MyActions"]);
                dataGridView1.Columns["MyDate"].DefaultCellStyle.Format = "d";
                dataGridView1.Columns["MyTime"].DefaultCellStyle.Format = "t";

            }
        }


        private void DeleteAllRecords()
        {
            try
            {
                // Check if there are records in the dataset
                if (ds.Tables[0].Rows.Count > 0)
                {
                    // Mark all rows as deleted in the dataset
                    foreach (DataRow row in ds.Tables[0].Rows)
                    {
                        row.Delete();
                    }

                    // Save changes to the database
                    save_data_into_db();

                    MessageBox.Show("All records have been deleted.");
                }
                else
                {
                    MessageBox.Show("No records to delete.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error deleting records: " + ex.Message);
            }
        }



        public Form1()

        {
            InitializeComponent();

            pictureBoxLeftDoor.BringToFront();
            pictureBoxRightDoor.BringToFront();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            //Event Handler
            GFButton.Click += GFButton_Click;
            FFButton.Click += FFButton_Click;
            FFCallButton.Click += FFButton_Click;
            GFCallButton.Click += GFButton_Click;
            button_Exit.Click += button_Exit_Click;

            // Timer to Set door and elevator movement
            timer1.Interval = 40;
            timer1.Tick += TimerElevator_Tick;

            timer2.Interval = 50;
            timer2.Tick += TimerOpenDoors_Tick;

            timer3.Interval = 50;
            timer3.Tick += TimerCloseDoors_Tick;

        }

        // Event handler for Ground Floor button
        private void GFButton_Click(object sender, EventArgs e)
        {
            if (!doorsAreOpening && !doorsAreClosing)
            {
                if (!isMovingDown)

                {
                    isMovingDown = true;
                    FFButton.Enabled = false;
                    FFCallButton.Enabled = false;
                    timer1.Start();
                    CloseDoorsBeforeMoving();
                    UpdateDisplayArea();

                    string MyDate = DateTime.Now.ToShortDateString();
                    string MyTime = DateTime.Now.ToShortTimeString();
                    string MyActions = "Elevator Moving Down";

                    Insert_Record(MyDate, MyTime, MyActions);

                }
                else if (isAtGroundFloor)
                {

                    OpenGroundFloorDoors();

                }
            }
        }

        // Event handler for First Floor button
        private void FFButton_Click(object sender, EventArgs e)
        {
            if (!doorsAreOpening && !doorsAreClosing)
            {
                if (!isMovingUp && !isMovingDown && !isAtFirstFloor)
                {

                    isMovingUp = true;
                    GFButton.Enabled = false;
                    GFCallButton.Enabled = false;
                    timer1.Start();
                    CloseDoorsBeforeMoving();
                    UpdateDisplayArea();

                    string MyDate = DateTime.Now.ToShortDateString();
                    string MyTime = DateTime.Now.ToShortTimeString();
                    string MyActions = "Elevator Moving Up";

                    Insert_Record(MyDate, MyTime, MyActions);
                }
                else if (isAtFirstFloor)
                {
                    OpenFirstFloorDoors();

                }
            }
        }

        private void EmergencyButton_Click_1(object sender, EventArgs e)
        {
            if (!doorsAreOpening && !doorsAreClosing)
            {
                doorsAreOpening = true;

                if (isAtGroundFloor)
                {
                    OpenDoors(pictureBoxGFLeftDoor, pictureBoxGFRightDoor, pictureBoxGroundFloor);

                }
                else if (isAtFirstFloor)
                {
                    OpenDoors(pictureBoxLeftDoor, pictureBoxRightDoor, pictureBoxFirstFloor);
                }

                label2.Text = "🔔";
                label3.Text = "🔔";
                label4.Text = "🔔";

                label2.ForeColor = Color.Yellow;
                label3.ForeColor = Color.Yellow;
                label4.ForeColor = Color.Yellow;

                // Start the timer for door opening animations
                timer2.Start();

                string MyDate = DateTime.Now.ToShortDateString();
                string MyTime = DateTime.Now.ToShortTimeString();
                string MyActions = "Emergency! Elevator Doors opening";

                Insert_Record(MyDate, MyTime, MyActions);

            }
        }

        private void button_Save_Click(object sender, EventArgs e)
        {
            try
            {
                save_data_into_db();

                MessageBox.Show("Data Saved Successfully.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Saving Data." + ex.Message);
            }
        }

        private void button_Load_Click(object sender, EventArgs e)
        {
            try
            {
                // Reload data from the database into the dataset
                reload_data_from_db_to_ds();

                save_data_into_db();

                // Update the DataGridView to display the reloaded data
                UpdateDataGridView();

                MessageBox.Show("Data loaded successfully.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading data: " + ex.Message);
            }
        }

        private void button_Clear_Click(object sender, EventArgs e)
        {
            try
            {

                dataGridView1.Rows.Clear();
                ds.Tables[0].Clear();

                MessageBox.Show("Data Cleared successfully.");
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error Clearing data: " + ex.Message);
            }
        }

        private void button_Delete_Click(object sender, EventArgs e)
        {
            DeleteAllRecords();
            dataGridView1.Rows.Clear();
        }

        private void button_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // Elevator movement logic
        private void TimerElevator_Tick(object sender, EventArgs e)
        {
            if (isMovingUp)
            {
                // Move the elevator up
                pictureBoxElevatorInside.Location = new Point(pictureBoxElevatorInside.Location.X, pictureBoxElevatorInside.Location.Y - elevatorSpeed);

                // top position of the first floor
                int firstFloorTop = pictureBoxFirstFloor.Location.Y + (pictureBoxFirstFloor.Height / 2) - (pictureBoxElevatorInside.Height / 2);

                // Check if the elevator has reached the first floor
                if (pictureBoxElevatorInside.Location.Y <= firstFloorTop)
                {
                    // Stop the elevator and stop the timer
                    pictureBoxElevatorInside.Location = new Point(pictureBoxElevatorInside.Location.X, firstFloorTop);
                    timer1.Stop();
                    isMovingUp = false;
                    isAtFirstFloor = true;
                    isAtGroundFloor = false;
                    GFButton.Enabled = false;

                    label2.Text = "1";
                    label3.Text = "1";
                    label4.Text = "1";

                    label2.ForeColor = Color.SkyBlue;
                    label3.ForeColor = Color.SkyBlue;
                    label4.ForeColor = Color.SkyBlue;

                    OpenFirstFloorDoors();

                    string MyDate = DateTime.Now.ToShortDateString(); // Get the current date
                    string MyTime = DateTime.Now.ToShortTimeString(); // Get the current time
                    string MyActions = "Elevator Doors opening"; // Log message

                    // Call the method to insert the record into the database
                    Insert_Record(MyDate, MyTime, MyActions);
                }
            }

            else if (isMovingDown)
            {
                pictureBoxElevatorInside.Location = new Point(pictureBoxElevatorInside.Location.X, pictureBoxElevatorInside.Location.Y + elevatorSpeed);

                int groundFloorTop = pictureBoxGroundFloor.Location.Y + (pictureBoxGroundFloor.Height / 2) - (pictureBoxElevatorInside.Height / 2);

                if (pictureBoxElevatorInside.Location.Y >= groundFloorTop)
                {

                    pictureBoxElevatorInside.Location = new Point(pictureBoxElevatorInside.Location.X, groundFloorTop);
                    timer1.Stop();
                    isMovingDown = false;
                    isAtGroundFloor = true;
                    isAtFirstFloor = false;
                    FFButton.Enabled = false;

                    label2.Text = "G";
                    label3.Text = "G";
                    label4.Text = "G";

                    label2.ForeColor = Color.Gold;
                    label3.ForeColor = Color.Gold;
                    label4.ForeColor = Color.Gold;

                    OpenGroundFloorDoors();

                    string MyDate = DateTime.Now.ToShortDateString(); // Get the current date
                    string MyTime = DateTime.Now.ToShortTimeString(); // Get the current time
                    string MyActions = "Elevator Doors opening";

                    Insert_Record(MyDate, MyTime, MyActions);

                }
            }

        }

        // Function to handle door opening animation
        private async void TimerOpenDoors_Tick(object sender, EventArgs e)
        {
            if (doorsAreOpening)
            {
                if (isAtGroundFloor)
                {
                    OpenDoors(pictureBoxGFLeftDoor, pictureBoxGFRightDoor, pictureBoxGroundFloor);

                }
                else if (isAtFirstFloor)
                {
                    OpenDoors(pictureBoxLeftDoor, pictureBoxRightDoor, pictureBoxFirstFloor);

                }

                if (!doorsAreOpening)
                {
                    // Delay for 3 seconds
                    await Task.Delay(3000); // Wait for 3 seconds
                    timer3.Start();



                    string MyDate = DateTime.Now.ToShortDateString();
                    string MyTime = DateTime.Now.ToShortTimeString();
                    string MyActions = "Elevator Doors closing";

                    Insert_Record(MyDate, MyTime, MyActions);

                }
            }
        }


        private void OpenDoors(PictureBox leftDoor, PictureBox rightDoor, PictureBox floor)
        {
            int leftDoorLimit = floor.Location.X + 20;
            int rightDoorLimit = floor.Location.X + floor.Width - rightDoor.Width - 35;

            bool doorsOpened = false;

            if (leftDoor.Location.X > leftDoorLimit)
            {
                leftDoor.Location = new Point(leftDoor.Location.X - doorSpeed, leftDoor.Location.Y);
                doorsOpened = true;
            }

            if (rightDoor.Location.X < rightDoorLimit)
            {
                rightDoor.Location = new Point(rightDoor.Location.X + doorSpeed, rightDoor.Location.Y);
                doorsOpened = true;
            }

            if (!doorsOpened)
            {

                timer2.Stop();
                doorsAreOpening = false;
                FFButton.Enabled = false;
                FFCallButton.Enabled = false;
                GFButton.Enabled = false;
                GFCallButton.Enabled = false;
                
            }
        }

        private void TimerCloseDoors_Tick(object sender, EventArgs e)
        {
            if (!doorsAreOpening)
            {
                doorsAreClosing = true;

                if (isAtGroundFloor)
                {
                    CloseDoors(pictureBoxGFLeftDoor, pictureBoxGFRightDoor, pictureBoxGroundFloor);
                }
                else if (isAtFirstFloor)
                {
                    CloseDoors(pictureBoxLeftDoor, pictureBoxRightDoor, pictureBoxFirstFloor);
                    GFButton.Enabled = true;
                    GFCallButton.Enabled = true;
                    

                }
            }
        }

        private void CloseDoors(PictureBox leftDoor, PictureBox rightDoor, PictureBox floor)
        {
            int leftDoorStartPosition = floor.Location.X + (floor.Width / 2) - leftDoor.Width;
            int rightDoorStartPosition = floor.Location.X + (floor.Width / 2);

            if (leftDoor.Location.X < leftDoorStartPosition)
            {
                leftDoor.Location = new Point(leftDoor.Location.X + doorSpeed, leftDoor.Location.Y);
            }

            if (rightDoor.Location.X > rightDoorStartPosition)
            {
                rightDoor.Location = new Point(rightDoor.Location.X - doorSpeed, rightDoor.Location.Y);
            }

            if (leftDoor.Location.X >= leftDoorStartPosition && rightDoor.Location.X <= rightDoorStartPosition)
            {
                timer3.Stop();
                doorsAreClosing = false;
                GFButton.Enabled = true;
                GFCallButton.Enabled = true;
                FFButton.Enabled = true;
                FFCallButton.Enabled = true;
                EmergencyButton.Enabled = true;

                if (isMovingDown)
                {
                    timer1.Start();
                    FFButton.Enabled = false;
                    FFCallButton.Enabled = false;
                    EmergencyButton.Enabled = false;
                }
                else if (isMovingUp)
                {
                    timer1.Start();
                    GFButton.Enabled = false;
                    GFCallButton.Enabled = false;
                    EmergencyButton.Enabled = true;
                }
            }
        }


        private void OpenGroundFloorDoors()
        {
            doorsAreOpening = true;
            timer2.Start();

        }

        private void OpenFirstFloorDoors()
        {
            doorsAreOpening = true;
            timer2.Start();
        }

        private void CloseDoorsBeforeMoving()
        {
            doorsAreClosing = true;
            timer3.Start();
        }

        private void UpdateDisplayArea()
        {
            if (isMovingDown)
            {

                label2.Text = "⮟";
                label3.Text = "⮟";
                label4.Text = "⮟";

                label2.ForeColor = Color.Red;
                label3.ForeColor = Color.Red;
                label4.ForeColor = Color.Red;

            }
            else if (isMovingUp)
            {

                label2.Text = "⮝";
                label3.Text = "⮝";
                label4.Text = "⮝";

                label2.ForeColor = Color.Green;
                label3.ForeColor = Color.Green;
                label4.ForeColor = Color.Green;


            }

        }
    }
}

  



      


        
    



        
    



