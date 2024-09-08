using assignment6;
using System;
using System.Windows.Forms;

namespace assignment6
{
    public partial class MainForm : Form
    {
        private TaskManager taskManager;
        // File path for storing tasks, located in the same directory as the application's executable.
        private readonly string fileName = Application.StartupPath + "\\reminders.txt"; // readonly.

        public MainForm()
        {
            InitializeComponent();
            InitializeGUI();
        }

        /// <summary>
        /// Initializes the GUI components and settings.
        /// </summary>
        private void InitializeGUI()
        {
            this.Text = "ToDo Reminder by Eldaras Zutautas";

            // Initialize TaskManager instance.
            taskManager = new TaskManager();

            // Set up priority combo box.
            cmbPriority.Items.Clear();
            cmbPriority.Items.AddRange(Enum.GetNames(typeof(PriorityType)));
            cmbPriority.SelectedIndex = (int)PriorityType.Normal;

            // Clear and setup list box and other controls.
            lstToDo.Items.Clear();
            lblTime.Text = string.Empty;
            txtDescription.Text = string.Empty;

            // Set up tooltips.
            toolTip1.ShowAlways = true;
            toolTip1.SetToolTip(dateTimePicker1, "Click and select the time that you need.");

            // Configure date and time picker.
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "yyyy-MM-dd    HH:mm";

            // Enable file menu options.
            menuFileOpen.Enabled = true;
            menuFileSave.Enabled = true;

            clockTimer.Start();
        }

        /// <summary>
        /// Updates the GUI to reflect the current task list.
        /// </summary>
        private void UpdateGUI()
        {
            lstToDo.Items.Clear();
            string[] taskInfoStrings = taskManager.GetInfoStringsList();
            if (taskInfoStrings != null && taskInfoStrings.Length > 0)
            {
                lstToDo.Items.AddRange(taskInfoStrings);
            }
        }

        /// <summary>
        /// Reads input from the form and creates a new Task object.
        /// </summary>
        /// <returns>A Task object or null if the input is invalid.</returns>
        private Task ReadInput()
        {
            if (string.IsNullOrEmpty(txtDescription.Text))
            {
                MessageBox.Show("Error. You need to provide a description.");
                return null;
            }

            return new Task
            {
                Description = txtDescription.Text,
                Date = dateTimePicker1.Value,
                Priority = (PriorityType)cmbPriority.SelectedIndex
            };
        }

        /// <summary>
        /// Handles the Save menu item click event. Saves tasks to a file.
        /// </summary>
        private void menuFileSave_Click(object sender, EventArgs e)
        {
            bool success = taskManager.WriteDataToFile(fileName);
            MessageBox.Show(success ? "Data saved: " + Environment.NewLine + fileName : "Error. Something went wrong while saving data to file.");
        }

        /// <summary>
        /// Handles the Open menu item click event. Loads tasks from a file.
        /// </summary>
        private void menuFileOpen_Click(object sender, EventArgs e)
        {
            bool success = taskManager.ReadDataFromFile(fileName);
            if (success)
            {
                UpdateGUI();
            }
            else
            {
                MessageBox.Show("Error. Something went wrong when opening the file.");
            }
        }

        /// <summary>
        /// Handles the New menu item click event. Reinitializes the GUI.
        /// </summary>
        private void menuFileNew_Click(object sender, EventArgs e)
        {
            InitializeGUI();
        }

        /// <summary>
        /// Handles the Exit menu item click event. Confirms and exits the application.
        /// </summary>
        private void menuFileExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to exit the program?", "Confirm Exit", MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        /// <summary>
        /// Handles the Timer Tick event. Updates the current time label.
        /// </summary>
        private void clockTimer_Tick(object sender, EventArgs e)
        {
            lblTime.Text = GetFormattedCurrentTime();
        }

        /// <summary>
        /// Formats the current time as a string.
        /// </summary>
        /// <returns>A string representing the current time.</returns>
        private string GetFormattedCurrentTime()
        {
            return DateTime.Now.ToString("HH:mm:ss");
        }

        /// <summary>
        /// Handles the Add button click event. Reads input and adds a new task.
        /// </summary>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            Task task = ReadInput();
            if (task != null && taskManager.AddNewTask(task))
            {
                UpdateGUI();
            }
        }

        // change, delete buttons. NOT IMPLEMENTED.
    }
}
