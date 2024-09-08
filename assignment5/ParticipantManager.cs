using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assingment5
{
    internal class ParticipantManager
    {
        private List<Participant> participants;

        /// <summary>
        /// Property to get the count of participants.
        /// </summary>
        public int Count => participants.Count;

        /// <summary>
        /// Constructor to initialize the participants list.
        /// </summary>
        public ParticipantManager()
        {
            participants = new List<Participant>();
        }

        /// <summary>
        /// Method to add a new participant using first name, last name, and address.
        /// </summary>
        /// <param name="fName"></param>
        /// <param name="lName"></param>
        /// <param name="addrss"></param>
        /// <returns></returns>
        public bool AddParticipant(string fName, string lName, Address addrss)
        {
            Participant tempParticipant = new Participant();
            if (!tempParticipant.Validate())
            {
                return false;
            }
            participants.Add(tempParticipant);

            return true;
        }

        /// <summary>
        /// Method to add a new participant object(s) directly.
        /// </summary>
        /// <param name="participant"></param>
        /// <returns></returns>
        public bool AddParticipant(Participant participant)
        {
            if (participant == null)
            {
                return false;
            }
            participants.Add(participant);

            return true;
        }

        /// <summary>
        /// Method to change a participant at a specific index.
        /// </summary>
        /// <param name="participant"></param>
        /// <param name="i"></param>
        /// <returns></returns>
        public bool ChangeParticipantAt(Participant participant, int i)
        {
            if (participant == null || !CheckIndex(i))
            {
                return false;
            }
            else
            {
                participants[i] = participant;
                return true;
            }
        }

        /// <summary>
        /// Method to check if the index is within the valid range.
        /// </summary>
        /// <param name="i"></param>
        /// <returns></returns>
        private bool CheckIndex(int i)
        {
            return i >= 0 && i < participants.Count;
        }

        /// <summary>
        /// Method to delete a participant at a specific index.
        /// </summary>
        /// <param name="i"></param>
        /// <returns></returns>
        public bool DeleteParticipantAt(int i)
        {
            if (!CheckIndex(i))
            {
                return false;
            }
            participants.RemoveAt(i);

            return true;
        }

        /// <summary>
        /// Method to get a participant at a specific index.
        /// </summary>
        /// <param name="i"></param>
        /// <returns></returns>
        public Participant? GetParticipantAt(int i)
        {
            if (!CheckIndex(i))
            {
                return null;
            }
            return participants[i];
        }

        /// <summary>
        /// Method to get information of all participants as an array of strings.
        /// </summary>
        /// <returns></returns>
        public string[] GetParticipantsInfo()
        {
            string[] temp = new string[participants.Count];
            int index = 0;

            foreach (var participant in participants)
            {
                temp[index++] = participant.ToString();
            }

            return temp;
        }

        public void TestValues()
        {

        }
    }
}