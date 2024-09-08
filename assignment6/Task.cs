using System;

namespace assignment6
{
    internal class Task
    {
        #region Fields

        private DateTime date;
        private PriorityType priority;
        private string description;

        #endregion

        #region Constructors

        /// <summary>
        /// Constructor that initializes the task with specified values for date, description, and priority.
        /// </summary>
        /// <param name="taskDate">The date and time of the task.</param>
        /// <param name="description">The description of the task.</param>
        /// <param name="priority">The priority of the task.</param>
        public Task(DateTime taskDate, string description, PriorityType priority)
        {
            this.date = taskDate;
            this.description = description;
            this.priority = priority;
        }

        /// <summary>
        /// Default constructor, initializes the task with a normal priority.
        /// </summary>
        public Task() : this(DateTime.Now, string.Empty, PriorityType.Normal)
        {

        }
        #endregion

        #region Properties

        /// <summary>
        /// Gets or sets the description of the task. Empty or null values are ignored.
        /// </summary>
        public string Description
        {
            get => description;
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    description = value;
                }
            }
        }

        /// <summary>
        /// Gets or sets the priority level of the task.
        /// </summary>
        public PriorityType Priority
        {
            get => priority;
            set => priority = value;
        }

        /// <summary>
        /// Gets or sets the date and time of the task.
        /// </summary>
        public DateTime Date
        {
            get => date;
            set => date = value;
        }

        #endregion

        #region Methods

        /// <summary>
        /// Converts the priority level to a human-readable string.
        /// </summary>
        /// <returns>The priority level as a string with underscores replaced by spaces.</returns>
        public string GetPriorityString()
        {
            string? priorityStr = Enum.GetName(typeof(PriorityType), Priority); // "string?" indicates that priorityStr can be null.
            return priorityStr?.Replace("_", " ") ?? string.Empty;
        }

        /// <summary>
        /// Formats the time part of the task's date as a string in "HH:mm" format.
        /// </summary>
        /// <returns>A string representing the time of the task.</returns>
        private string GetTimeString()
        {
            return date.ToString("HH:mm");
        }

        /// <summary>
        /// Returns a formatted string that represents the task, including date, time, priority, and description.
        /// </summary>
        /// <returns>A string that provides a summary of the task.</returns>
        public override string ToString()
        {
            return string.Format("{0, -20} {1, 10} {2, 30} {3, 50}",
                                 date.ToLongDateString(),
                                 GetTimeString(),
                                 GetPriorityString(),
                                 Description);
        }

        #endregion
    }
}
