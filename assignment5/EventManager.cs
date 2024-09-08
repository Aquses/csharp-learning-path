using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace assingment5
{
    internal class EventManager
    {
        private string title;
        private double costPerPerson;
        private double feePerPerson;
        private ParticipantManager participantManager;

        /// <summary>
        /// Constructor to initialize the EventManager with a new ParticipantManager instance.
        /// </summary>
        public EventManager()
        {
            participantManager = new ParticipantManager();
        }

        /// <summary>
        /// Property to get or set the title of the event.
        /// </summary>
        public string Title
        {
            get { return title; }
            set { if (!string.IsNullOrEmpty(value)) title = value; }
        }

        /// <summary>
        /// Property to get or set the cost per person for the event.
        /// </summary>
        public double CostPerPerson
        {
            get { return costPerPerson; }
            set { costPerPerson = value; }
        }

        /// <summary>
        /// Property to get or set the fee per person for the event.
        /// </summary>
        public double FeePerPerson
        {
            get { return feePerPerson; }
            set { feePerPerson = value; }
        }

        /// <summary>
        /// Property to access the ParticipantManager instance associated with the event.
        /// </summary>
        public ParticipantManager ParticipantManager => participantManager;

        /// <summary>
        /// Method to calculate the total cost of the event based on cost per person and number of participants.
        /// </summary>
        /// <returns></returns>
        public double CalcTotalCost()
        {
            return costPerPerson * participantManager.Count;
        }

        /// <summary>
        /// Method to calculate the total fee generated from participants based on fee per person and number of participants.
        /// </summary>
        /// <returns></returns>
        public double CalcTotalFee()
        {
            return feePerPerson * participantManager.Count;
        }

        /// <summary>
        /// Method to calculate the total income (profit or los) generated from the event.
        /// </summary>
        /// <returns></returns>
        public double CalcTotalIncome()
        {
            return CalcTotalFee() - CalcTotalCost();
        }
    }
}
