namespace assignment6
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being usedd.
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            lblDateTime = new Label();
            dateTimePicker1 = new DateTimePicker();
            lblPriority = new Label();
            cmbPriority = new ComboBox();
            lblToDo = new Label();
            txtDescription = new TextBox();
            btnAdd = new Button();
            grpToDo = new GroupBox();
            lstToDo = new ListBox();
            lblDescription = new Label();
            lblGrpPriority = new Label();
            lblHour = new Label();
            lblDate = new Label();
            lblTime = new Label();
            menu = new MenuStrip();
            menuFile = new ToolStripMenuItem();
            menuFileNew = new ToolStripMenuItem();
            menuFileOpen = new ToolStripMenuItem();
            menuFileSave = new ToolStripMenuItem();
            menuFileExit = new ToolStripMenuItem();
            clockTimer = new System.Windows.Forms.Timer(components);
            printFileDialog = new SaveFileDialog();
            toolTip1 = new ToolTip(components);
            openFileDialog1 = new OpenFileDialog();
            grpToDo.SuspendLayout();
            menu.SuspendLayout();
            SuspendLayout();
            // 
            // lblDateTime
            // 
            lblDateTime.AutoSize = true;
            lblDateTime.Location = new Point(21, 35);
            lblDateTime.Name = "lblDateTime";
            lblDateTime.Size = new Size(81, 15);
            lblDateTime.TabIndex = 0;
            lblDateTime.Text = "Date and time";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(110, 29);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(237, 23);
            dateTimePicker1.TabIndex = 1;
            // 
            // lblPriority
            // 
            lblPriority.AutoSize = true;
            lblPriority.Location = new Point(383, 32);
            lblPriority.Name = "lblPriority";
            lblPriority.Size = new Size(45, 15);
            lblPriority.TabIndex = 2;
            lblPriority.Text = "Priority";
            // 
            // cmbPriority
            // 
            cmbPriority.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPriority.FormattingEnabled = true;
            cmbPriority.Location = new Point(434, 29);
            cmbPriority.Name = "cmbPriority";
            cmbPriority.Size = new Size(161, 23);
            cmbPriority.TabIndex = 3;
            // 
            // lblToDo
            // 
            lblToDo.AutoSize = true;
            lblToDo.Location = new Point(68, 77);
            lblToDo.Name = "lblToDo";
            lblToDo.Size = new Size(36, 15);
            lblToDo.TabIndex = 4;
            lblToDo.Text = "To do";
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(110, 74);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(554, 23);
            txtDescription.TabIndex = 5;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(293, 103);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(231, 23);
            btnAdd.TabIndex = 6;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // grpToDo
            // 
            grpToDo.Controls.Add(lstToDo);
            grpToDo.Controls.Add(lblDescription);
            grpToDo.Controls.Add(lblGrpPriority);
            grpToDo.Controls.Add(lblHour);
            grpToDo.Controls.Add(lblDate);
            grpToDo.ForeColor = Color.Green;
            grpToDo.Location = new Point(21, 148);
            grpToDo.Name = "grpToDo";
            grpToDo.Size = new Size(787, 313);
            grpToDo.TabIndex = 7;
            grpToDo.TabStop = false;
            grpToDo.Text = "To Do";
            // 
            // lstToDo
            // 
            lstToDo.FormattingEnabled = true;
            lstToDo.ItemHeight = 15;
            lstToDo.Location = new Point(6, 34);
            lstToDo.Name = "lstToDo";
            lstToDo.Size = new Size(775, 274);
            lstToDo.TabIndex = 11;
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.ForeColor = Color.Black;
            lblDescription.Location = new Point(375, 19);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(67, 15);
            lblDescription.TabIndex = 10;
            lblDescription.Text = "Description";
            // 
            // lblGrpPriority
            // 
            lblGrpPriority.AutoSize = true;
            lblGrpPriority.ForeColor = Color.Black;
            lblGrpPriority.Location = new Point(272, 19);
            lblGrpPriority.Name = "lblGrpPriority";
            lblGrpPriority.Size = new Size(45, 15);
            lblGrpPriority.TabIndex = 9;
            lblGrpPriority.Text = "Priority";
            // 
            // lblHour
            // 
            lblHour.AutoSize = true;
            lblHour.ForeColor = Color.Black;
            lblHour.Location = new Point(162, 19);
            lblHour.Name = "lblHour";
            lblHour.Size = new Size(34, 15);
            lblHour.TabIndex = 9;
            lblHour.Text = "Hour";
            // 
            // lblDate
            // 
            lblDate.AutoSize = true;
            lblDate.ForeColor = Color.Black;
            lblDate.Location = new Point(6, 19);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(31, 15);
            lblDate.TabIndex = 8;
            lblDate.Text = "Date";
            // 
            // lblTime
            // 
            lblTime.BorderStyle = BorderStyle.Fixed3D;
            lblTime.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTime.ForeColor = Color.Blue;
            lblTime.Location = new Point(743, 464);
            lblTime.Name = "lblTime";
            lblTime.Size = new Size(59, 23);
            lblTime.TabIndex = 8;
            lblTime.Text = "lblTime";
            // 
            // menu
            // 
            menu.Items.AddRange(new ToolStripItem[] { menuFile });
            menu.Location = new Point(0, 0);
            menu.Name = "menu";
            menu.Size = new Size(820, 24);
            menu.TabIndex = 9;
            menu.Text = "menuStrip";
            // 
            // menuFile
            // 
            menuFile.DropDownItems.AddRange(new ToolStripItem[] { menuFileNew, menuFileOpen, menuFileSave, menuFileExit });
            menuFile.Name = "menuFile";
            menuFile.Size = new Size(37, 20);
            menuFile.Text = "File";
            // 
            // menuFileNew
            // 
            menuFileNew.Name = "menuFileNew";
            menuFileNew.Size = new Size(155, 22);
            menuFileNew.Text = "New     Ctrl + N";
            menuFileNew.Click += menuFileNew_Click;
            // 
            // menuFileOpen
            // 
            menuFileOpen.Name = "menuFileOpen";
            menuFileOpen.Size = new Size(155, 22);
            menuFileOpen.Text = "Open datafile";
            menuFileOpen.Click += menuFileOpen_Click;
            // 
            // menuFileSave
            // 
            menuFileSave.Name = "menuFileSave";
            menuFileSave.Size = new Size(155, 22);
            menuFileSave.Text = "Save datafile";
            menuFileSave.Click += menuFileSave_Click;
            // 
            // menuFileExit
            // 
            menuFileExit.Name = "menuFileExit";
            menuFileExit.Size = new Size(155, 22);
            menuFileExit.Text = "Exit     Alt + F4";
            menuFileExit.Click += menuFileExit_Click;
            // 
            // clockTimer
            // 
            clockTimer.Tick += clockTimer_Tick;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(820, 492);
            Controls.Add(lblTime);
            Controls.Add(grpToDo);
            Controls.Add(btnAdd);
            Controls.Add(txtDescription);
            Controls.Add(lblToDo);
            Controls.Add(cmbPriority);
            Controls.Add(lblPriority);
            Controls.Add(dateTimePicker1);
            Controls.Add(lblDateTime);
            Controls.Add(menu);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menu;
            Name = "MainForm";
            Text = "MainForm";
            grpToDo.ResumeLayout(false);
            grpToDo.PerformLayout();
            menu.ResumeLayout(false);
            menu.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblDateTime;
        private DateTimePicker dateTimePicker1;
        private Label lblPriority;
        private ComboBox cmbPriority;
        private Label lblToDo;
        private TextBox txtDescription;
        private Button btnAdd;
        private GroupBox grpToDo;
        private Label lblDate;
        private ListBox lstToDo;
        private Label lblDescription;
        private Label lblGrpPriority;
        private Label lblHour;
        private Label lblTime;
        private MenuStrip menu;
        private ToolStripMenuItem menuFile;
        private ToolStripMenuItem menuFileNew;
        private ToolStripMenuItem menuFileOpen;
        private ToolStripMenuItem menuFileSave;
        private ToolStripMenuItem menuFileExit;
        private System.Windows.Forms.Timer clockTimer;
        private SaveFileDialog printFileDialog;
        private ToolTip toolTip1;
        private OpenFileDialog openFileDialog1;
    }
}