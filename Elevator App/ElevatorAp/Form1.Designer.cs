namespace ElevatorAp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            pictureBoxFirstFloor = new PictureBox();
            pictureBoxGroundFloor = new PictureBox();
            timer1 = new System.Windows.Forms.Timer(components);
            timer2 = new System.Windows.Forms.Timer(components);
            timer3 = new System.Windows.Forms.Timer(components);
            pictureBoxFirstFloorPanel = new PictureBox();
            FFCallButton = new Button();
            GFCallButton = new Button();
            label1 = new Label();
            button_Exit = new Button();
            dataGridView1 = new DataGridView();
            MyDate = new DataGridViewTextBoxColumn();
            MyTime = new DataGridViewTextBoxColumn();
            MyActions = new DataGridViewTextBoxColumn();
            button_Clear = new Button();
            pictureBoxElevatorInside = new PictureBox();
            pictureBoxGFRightDoor = new PictureBox();
            pictureBoxGFLeftDoor = new PictureBox();
            FFButton = new Button();
            GFButton = new Button();
            pictureBoxRightDoor = new PictureBox();
            pictureBoxLeftDoor = new PictureBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            button_Save = new Button();
            button_Load = new Button();
            button_Delete = new Button();
            EmergencyButton = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBoxFirstFloor).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxGroundFloor).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxFirstFloorPanel).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxElevatorInside).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxGFRightDoor).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxGFLeftDoor).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxRightDoor).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLeftDoor).BeginInit();
            ((System.ComponentModel.ISupportInitialize)EmergencyButton).BeginInit();
            SuspendLayout();
            // 
            // pictureBoxFirstFloor
            // 
            pictureBoxFirstFloor.BackgroundImage = (Image)resources.GetObject("pictureBoxFirstFloor.BackgroundImage");
            pictureBoxFirstFloor.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBoxFirstFloor.Location = new Point(71, 57);
            pictureBoxFirstFloor.Name = "pictureBoxFirstFloor";
            pictureBoxFirstFloor.Size = new Size(691, 560);
            pictureBoxFirstFloor.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxFirstFloor.TabIndex = 1;
            pictureBoxFirstFloor.TabStop = false;
            // 
            // pictureBoxGroundFloor
            // 
            pictureBoxGroundFloor.BackgroundImage = (Image)resources.GetObject("pictureBoxGroundFloor.BackgroundImage");
            pictureBoxGroundFloor.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBoxGroundFloor.Location = new Point(71, 683);
            pictureBoxGroundFloor.Name = "pictureBoxGroundFloor";
            pictureBoxGroundFloor.Size = new Size(691, 560);
            pictureBoxGroundFloor.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxGroundFloor.TabIndex = 2;
            pictureBoxGroundFloor.TabStop = false;
            // 
            // timer1
            // 
            timer1.Interval = 1000;
            // 
            // timer2
            // 
            timer2.Interval = 1000;
            // 
            // timer3
            // 
            timer3.Interval = 1000;
            // 
            // pictureBoxFirstFloorPanel
            // 
            pictureBoxFirstFloorPanel.BackgroundImage = (Image)resources.GetObject("pictureBoxFirstFloorPanel.BackgroundImage");
            pictureBoxFirstFloorPanel.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBoxFirstFloorPanel.Location = new Point(871, 62);
            pictureBoxFirstFloorPanel.Name = "pictureBoxFirstFloorPanel";
            pictureBoxFirstFloorPanel.Size = new Size(325, 1064);
            pictureBoxFirstFloorPanel.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxFirstFloorPanel.TabIndex = 9;
            pictureBoxFirstFloorPanel.TabStop = false;
            // 
            // FFCallButton
            // 
            FFCallButton.BackColor = Color.FromArgb(64, 64, 64);
            FFCallButton.ForeColor = Color.Gold;
            FFCallButton.Location = new Point(617, 264);
            FFCallButton.Name = "FFCallButton";
            FFCallButton.Size = new Size(40, 142);
            FFCallButton.TabIndex = 11;
            FFCallButton.Text = "CALL";
            FFCallButton.UseVisualStyleBackColor = false;
            // 
            // GFCallButton
            // 
            GFCallButton.BackColor = Color.FromArgb(64, 64, 64);
            GFCallButton.ForeColor = Color.Gold;
            GFCallButton.Location = new Point(617, 890);
            GFCallButton.Name = "GFCallButton";
            GFCallButton.Size = new Size(40, 142);
            GFCallButton.TabIndex = 12;
            GFCallButton.Text = "CALL";
            GFCallButton.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 10.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(1307, 9);
            label1.Name = "label1";
            label1.Size = new Size(303, 40);
            label1.TabIndex = 19;
            label1.Text = "Elevator Record Log";
            // 
            // button_Exit
            // 
            button_Exit.Font = new Font("Segoe UI Black", 10.125F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            button_Exit.Location = new Point(1612, 1271);
            button_Exit.Name = "button_Exit";
            button_Exit.Size = new Size(150, 68);
            button_Exit.TabIndex = 20;
            button_Exit.Text = "EXIT";
            button_Exit.UseVisualStyleBackColor = true;
            button_Exit.Click += button_Exit_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.Window;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { MyDate, MyTime, MyActions });
            dataGridView1.Location = new Point(1307, 62);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 82;
            dataGridView1.Size = new Size(773, 1064);
            dataGridView1.TabIndex = 18;
            // 
            // MyDate
            // 
            MyDate.HeaderText = "MyDate";
            MyDate.MinimumWidth = 10;
            MyDate.Name = "MyDate";
            MyDate.Width = 200;
            // 
            // MyTime
            // 
            MyTime.HeaderText = "MyTime";
            MyTime.MinimumWidth = 10;
            MyTime.Name = "MyTime";
            MyTime.Width = 200;
            // 
            // MyActions
            // 
            MyActions.HeaderText = "MyActions";
            MyActions.MinimumWidth = 10;
            MyActions.Name = "MyActions";
            MyActions.Width = 200;
            // 
            // button_Clear
            // 
            button_Clear.Font = new Font("Segoe UI Black", 10.875F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            button_Clear.ForeColor = SystemColors.Highlight;
            button_Clear.Location = new Point(1713, 1162);
            button_Clear.Name = "button_Clear";
            button_Clear.Size = new Size(150, 68);
            button_Clear.TabIndex = 23;
            button_Clear.Text = "Clear";
            button_Clear.UseVisualStyleBackColor = true;
            button_Clear.Click += button_Clear_Click;
            // 
            // pictureBoxElevatorInside
            // 
            pictureBoxElevatorInside.BackgroundImage = (Image)resources.GetObject("pictureBoxElevatorInside.BackgroundImage");
            pictureBoxElevatorInside.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBoxElevatorInside.Location = new Point(251, 776);
            pictureBoxElevatorInside.Name = "pictureBoxElevatorInside";
            pictureBoxElevatorInside.Size = new Size(320, 400);
            pictureBoxElevatorInside.TabIndex = 24;
            pictureBoxElevatorInside.TabStop = false;
            // 
            // pictureBoxGFRightDoor
            // 
            pictureBoxGFRightDoor.BackgroundImage = (Image)resources.GetObject("pictureBoxGFRightDoor.BackgroundImage");
            pictureBoxGFRightDoor.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBoxGFRightDoor.Location = new Point(412, 776);
            pictureBoxGFRightDoor.Name = "pictureBoxGFRightDoor";
            pictureBoxGFRightDoor.Size = new Size(160, 402);
            pictureBoxGFRightDoor.TabIndex = 25;
            pictureBoxGFRightDoor.TabStop = false;
            // 
            // pictureBoxGFLeftDoor
            // 
            pictureBoxGFLeftDoor.BackgroundImage = (Image)resources.GetObject("pictureBoxGFLeftDoor.BackgroundImage");
            pictureBoxGFLeftDoor.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBoxGFLeftDoor.Location = new Point(251, 776);
            pictureBoxGFLeftDoor.Name = "pictureBoxGFLeftDoor";
            pictureBoxGFLeftDoor.Size = new Size(167, 402);
            pictureBoxGFLeftDoor.TabIndex = 26;
            pictureBoxGFLeftDoor.TabStop = false;
            // 
            // FFButton
            // 
            FFButton.BackColor = Color.Black;
            FFButton.Font = new Font("Segoe UI Black", 13.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            FFButton.ForeColor = Color.Gold;
            FFButton.Location = new Point(963, 471);
            FFButton.Name = "FFButton";
            FFButton.Size = new Size(133, 110);
            FFButton.TabIndex = 27;
            FFButton.Text = "1";
            FFButton.UseVisualStyleBackColor = false;
            // 
            // GFButton
            // 
            GFButton.BackColor = Color.Black;
            GFButton.Font = new Font("Segoe UI Black", 13.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            GFButton.ForeColor = Color.Gold;
            GFButton.Location = new Point(963, 639);
            GFButton.Name = "GFButton";
            GFButton.Size = new Size(133, 110);
            GFButton.TabIndex = 28;
            GFButton.Text = "G";
            GFButton.UseVisualStyleBackColor = false;
            // 
            // pictureBoxRightDoor
            // 
            pictureBoxRightDoor.BackgroundImage = (Image)resources.GetObject("pictureBoxRightDoor.BackgroundImage");
            pictureBoxRightDoor.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBoxRightDoor.Location = new Point(412, 150);
            pictureBoxRightDoor.Name = "pictureBoxRightDoor";
            pictureBoxRightDoor.Size = new Size(159, 402);
            pictureBoxRightDoor.TabIndex = 3;
            pictureBoxRightDoor.TabStop = false;
            // 
            // pictureBoxLeftDoor
            // 
            pictureBoxLeftDoor.BackgroundImage = (Image)resources.GetObject("pictureBoxLeftDoor.BackgroundImage");
            pictureBoxLeftDoor.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBoxLeftDoor.Location = new Point(251, 150);
            pictureBoxLeftDoor.Name = "pictureBoxLeftDoor";
            pictureBoxLeftDoor.Size = new Size(167, 402);
            pictureBoxLeftDoor.TabIndex = 4;
            pictureBoxLeftDoor.TabStop = false;
            // 
            // label2
            // 
            label2.BackColor = SystemColors.ActiveCaptionText;
            label2.Font = new Font("Segoe UI", 48F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Yellow;
            label2.Location = new Point(925, 120);
            label2.Name = "label2";
            label2.Size = new Size(222, 192);
            label2.TabIndex = 29;
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.BackColor = SystemColors.ActiveCaptionText;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Yellow;
            label3.Location = new Point(348, 62);
            label3.Name = "label3";
            label3.Size = new Size(129, 61);
            label3.TabIndex = 30;
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.BackColor = SystemColors.ActiveCaptionText;
            label4.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Yellow;
            label4.Location = new Point(348, 688);
            label4.Name = "label4";
            label4.Size = new Size(129, 61);
            label4.TabIndex = 31;
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // button_Save
            // 
            button_Save.Font = new Font("Segoe UI Black", 10.875F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            button_Save.ForeColor = Color.ForestGreen;
            button_Save.Location = new Point(1325, 1162);
            button_Save.Name = "button_Save";
            button_Save.Size = new Size(150, 68);
            button_Save.TabIndex = 32;
            button_Save.Text = "Save";
            button_Save.UseVisualStyleBackColor = true;
            button_Save.Click += button_Save_Click;
            // 
            // button_Load
            // 
            button_Load.Font = new Font("Segoe UI Black", 10.875F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            button_Load.ForeColor = Color.Gold;
            button_Load.Location = new Point(1512, 1162);
            button_Load.Name = "button_Load";
            button_Load.Size = new Size(150, 68);
            button_Load.TabIndex = 33;
            button_Load.Text = "Load";
            button_Load.UseVisualStyleBackColor = true;
            button_Load.Click += button_Load_Click;
            // 
            // button_Delete
            // 
            button_Delete.Font = new Font("Segoe UI Black", 10.875F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            button_Delete.ForeColor = Color.FromArgb(192, 0, 0);
            button_Delete.Location = new Point(1906, 1162);
            button_Delete.Name = "button_Delete";
            button_Delete.Size = new Size(150, 68);
            button_Delete.TabIndex = 34;
            button_Delete.Text = "Delete";
            button_Delete.UseVisualStyleBackColor = true;
            button_Delete.Click += button_Delete_Click;
            // 
            // EmergencyButton
            // 
            EmergencyButton.BackgroundImageLayout = ImageLayout.Stretch;
            EmergencyButton.Image = (Image)resources.GetObject("EmergencyButton.Image");
            EmergencyButton.Location = new Point(963, 834);
            EmergencyButton.Name = "EmergencyButton";
            EmergencyButton.Size = new Size(133, 110);
            EmergencyButton.SizeMode = PictureBoxSizeMode.StretchImage;
            EmergencyButton.TabIndex = 35;
            EmergencyButton.TabStop = false;
            EmergencyButton.Click += EmergencyButton_Click_1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2406, 1959);
            Controls.Add(EmergencyButton);
            Controls.Add(button_Delete);
            Controls.Add(button_Load);
            Controls.Add(button_Save);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(GFButton);
            Controls.Add(FFButton);
            Controls.Add(pictureBoxGFLeftDoor);
            Controls.Add(pictureBoxGFRightDoor);
            Controls.Add(pictureBoxElevatorInside);
            Controls.Add(button_Clear);
            Controls.Add(button_Exit);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Controls.Add(GFCallButton);
            Controls.Add(FFCallButton);
            Controls.Add(pictureBoxFirstFloorPanel);
            Controls.Add(pictureBoxLeftDoor);
            Controls.Add(pictureBoxRightDoor);
            Controls.Add(pictureBoxGroundFloor);
            Controls.Add(pictureBoxFirstFloor);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBoxFirstFloor).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxGroundFloor).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxFirstFloorPanel).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxElevatorInside).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxGFRightDoor).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxGFLeftDoor).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxRightDoor).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLeftDoor).EndInit();
            ((System.ComponentModel.ISupportInitialize)EmergencyButton).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion


        private PictureBox pictureBoxFirstFloor;
        private PictureBox pictureBoxGroundFloor;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Timer timer3;
        private PictureBox pictureBoxFirstFloorPanel;
        private Button FFCallButton;
        private Button GFCallButton;
 
        private Label label1;
        private Button button_Exit;
        private DataGridView dataGridView1;
        private Button button_Clear;
        private PictureBox pictureBoxElevatorInside;
        private PictureBox pictureBoxGFRightDoor;
        private PictureBox pictureBoxGFLeftDoor;
        private Button FFButton;
        private Button GFButton;
        private PictureBox pictureBoxRightDoor;
        private PictureBox pictureBoxLeftDoor;
        private PictureBox pictureBox5;
        private Label label2;
        private Label label3;
        private Label label4;
        private DataGridViewTextBoxColumn MyDate;
        private DataGridViewTextBoxColumn MyTime;
        private DataGridViewTextBoxColumn MyActions;
        private Button button_Save;
        private Button button_Load;
        private Button button_Delete;
        private PictureBox EmergencyButton;
    }
}
