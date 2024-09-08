using System;
using System.Collections.Generic;

namespace assignment6
{
    internal class TaskManager
    {
        private List<Task> taskList;

        #region Constructor
        /// <summary>
        /// Initializes a new instance of the TaskManager class.
        /// </summary>
        public TaskManager()
        {
            taskList = new List<Task>();
        }
        #endregion

        #region Methods

        /// <summary>
        /// Adds a new task to the list.
        /// </summary>
        /// <param name="newTask">The task to add.</param>
        /// <returns>True if the task was added successfully, false otherwise.</returns>
        public bool AddNewTask(Task newTask)
        {
            if (newTask == null)
            {
                return false;
            }

            taskList.Add(newTask);
            return true;
        }

        /// <summary>
        /// Creates a new task with the provided details and adds it to the list.
        /// </summary>
        /// <param name="newTime">The time of the task.</param>
        /// <param name="description">The description of the task.</param>
        /// <param name="priority">The priority of the task.</param>
        /// <returns>True if the task was added successfully, false otherwise.</returns>
        public bool AddNewTask(DateTime newTime, string description, PriorityType priority)
        {
            var newTask = new Task(newTime, description, priority);
            return AddNewTask(newTask);
        }

        /// <summary>
        /// Retrieves a list of task information strings.
        /// </summary>
        /// <returns>An array of task information strings.</returns>
        public string[] GetInfoStringsList()
        {
            var infoStrings = new string[taskList.Count];
            for (int i = 0; i < taskList.Count; i++)
            {
                infoStrings[i] = taskList[i].ToString();
            }
            return infoStrings;
        }

        /// <summary>
        /// Saves the task list to a file.
        /// </summary>
        /// <param name="fileName">The name of the file to save to.</param>
        /// <returns>True if the data was saved successfully, false otherwise.</returns>
        public bool WriteDataToFile(string fileName)
        {
            var fileManager = new FileManager();
            return fileManager.SaveTaskListToFile(taskList, fileName);
        }

        /// <summary>
        /// Reads the task list from a file.
        /// </summary>
        /// <param name="fileName">The name of the file to read from.</param>
        /// <returns>True if the data was read successfully, false otherwise.</returns>
        public bool ReadDataFromFile(string fileName)
        {
            var fileManager = new FileManager();
            return fileManager.ReadTaskListFromFile(taskList, fileName);
        }

        /// <summary>
        /// Checks if the provided index is within the bounds of the task list.
        /// </summary>
        /// <param name="index">The index to check.</param>
        /// <returns>True if the index is valid, false otherwise.</returns>
        private bool CheckIndex(int index)
        {
            return index >= 0 && index < taskList.Count;
        }

        #endregion
    }
}
