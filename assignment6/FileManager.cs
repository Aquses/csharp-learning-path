using System;
using System.Collections.Generic;
using System.IO;

namespace assignment6
{
    internal class FileManager
    {
        #region Fields
        // This token marks the file as created by this application.
        private const string FileVersionToken = "kukicius";
        private const double FileVersionNumber = 1.0;
        #endregion

        #region Methods

        /// <summary>
        /// Saves the task list to a file.
        /// </summary>
        /// <param name="taskList">The list of tasks to save.</param>
        /// <param name="fileName">The name of the file to save to.</param>
        /// <returns>True if the save was successful, false otherwise.</returns>
        public bool SaveTaskListToFile(List<Task> taskList, string fileName)
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(fileName))
                {
                    writer.WriteLine(FileVersionToken);
                    writer.WriteLine(FileVersionNumber);
                    writer.WriteLine(taskList.Count);

                    // Write each task to the file.
                    foreach (var task in taskList)
                    {
                        WriteTask(writer, task);
                    }
                }
                return true;
            }
            catch (IOException ex)
            {
                // Catching I/O-specific exceptions here.
                Console.WriteLine($"Error while saving file: {ex.Message}");
                return false;
            }
            catch (Exception ex)
            {
                // Just catch exceptions.
                Console.WriteLine($"Unexpected error: {ex.Message}");
                return false;
            }
        }

        /// <summary>
        /// Reads the task list from a file.
        /// </summary>
        /// <param name="taskList">The list to populate with tasks.</param>
        /// <param name="fileName">The name of the file to read from.</param>
        /// <returns>True if the read was successful, false otherwise.</returns>
        public bool ReadTaskListFromFile(List<Task> taskList, string fileName)
        {
            try
            {
                if (taskList != null)
                {
                    // Clear the existing task list, if it is not null.
                    taskList.Clear();
                }
                else
                {
                    // If the task list is null, initialize it with a new List<Task>.
                    taskList = new List<Task>();
                }

                using (StreamReader reader = new StreamReader(fileName))
                {
                    if (!ValidateFileVersion(reader))
                    {
                        return false;
                    }

                    // Read the number of tasks.
                    int taskCount = int.Parse(reader.ReadLine());

                    // Read each task from the file.
                    for (int i = 0; i < taskCount; i++)
                    {
                        var task = ReadTask(reader);
                        taskList.Add(task);
                    }
                }
                return true;
            }
            catch (IOException ex)
            {
                // Catching I/O-specific exceptions here.
                Console.WriteLine($"Error while reading file: {ex.Message}");
                return false;
            }
            catch (Exception ex)
            {
                // Just catch exceptions.
                Console.WriteLine($"Unexpected error: {ex.Message}");
                return false;
            }
        }
        #endregion

        #region Helper Methods

        /// <summary>
        /// Reads a single task from the StreamReader.
        /// </summary>
        private Task ReadTask(StreamReader reader)
        {
            Task task = new Task
            {
                Description = reader.ReadLine(),
                Priority = (PriorityType)Enum.Parse(typeof(PriorityType), reader.ReadLine()),
                Date = new DateTime(
                    int.Parse(reader.ReadLine()),
                    int.Parse(reader.ReadLine()),
                    int.Parse(reader.ReadLine()),
                    int.Parse(reader.ReadLine()),
                    int.Parse(reader.ReadLine()),
                    int.Parse(reader.ReadLine())
                )
            };
            return task;
        }

        /// <summary>
        /// Writes a single task to the StreamWriter.
        /// </summary>
        private void WriteTask(StreamWriter writer, Task task)
        {
            writer.WriteLine(task.Description);
            writer.WriteLine(task.Priority.ToString());
            writer.WriteLine(task.Date.Year);
            writer.WriteLine(task.Date.Month);
            writer.WriteLine(task.Date.Day);
            writer.WriteLine(task.Date.Hour);
            writer.WriteLine(task.Date.Minute);
            writer.WriteLine(task.Date.Second);
        }

        /// <summary>
        /// Validates the file version token and number.
        /// </summary>
        private bool ValidateFileVersion(StreamReader reader)
        {
            string versionToken = reader.ReadLine();
            double versionNumber = double.Parse(reader.ReadLine());

            return versionToken == FileVersionToken && versionNumber == FileVersionNumber;
        }
        #endregion
    }
}
