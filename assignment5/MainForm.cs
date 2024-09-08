using System.DirectoryServices.ActiveDirectory;

namespace assingment5
{
    public partial class EventForm : Form
    {
        private EventManager _eventManager;

        public EventForm()
        {
            InitializeComponent();
            InitializeGui();
        }

        private void InitializeGui()
        {
            InitializeEventBox();
            InitializeGuestBox();
        }

        private void InitializeEventBox()
        {
            newEventBox.Enabled = true;
            eventNameIn.Text = "";
            costPerGuestIn.Text = "";
            feePerGuest.Text = "";
        }

        /// <summary>
        /// Initialize guest related GUI components with different fields.
        /// </summary>
        private void InitializeGuestBox()
        {
            addGuestBox.Enabled = false;
            eventEconomyBox.Enabled = false;
            firstNameIn.Text = "";
            secondNameIn.Text = "";
            streetIn.Text = "";
            cityIn.Text = "";
            zipCodeIn.Text = "";
            guestListBox.Items.Clear();
            InitializeCountryBox();
        }

        /// <summary>
        /// Initialize country drop-down list.
        /// </summary>
        private void InitializeCountryBox()
        {
            countryDropDown.Items.Clear(); // Clear existing items.
            foreach (var item in Enum.GetValues(typeof(Countries)))
            {
                countryDropDown.Items.Add(item);
            }
            countryDropDown.SelectedIndex = Convert.ToInt16(Countries.Sweden);
        }

        /// <summary>
        /// Event handler for creating a new event.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void clickCreateEvent(object sender, EventArgs e)
        {
            _eventManager = new EventManager();
            ReadEventTitle();

            if (ReadEventInputOk())
            {
                addGuestBox.Enabled = true;
                eventEconomyBox.Enabled = true;
                UpdateEventWindow();
                MessageBox.Show("Event created successfully.", "Success");
            } 
            else
            {
                MessageBox.Show("Event creation failed.", "Error");
            }
                
        }

        /// <summary>
        /// Read and set event title.
        /// </summary>
        private void ReadEventTitle()
        {
            bool empty = string.IsNullOrEmpty(eventNameIn.Text.Trim());

            if (empty) { 
                eventNameIn.Text = "Event without a name";
            }
            _eventManager.Title = eventNameIn.Text.Trim() + " - Event Manager by Eldaras Zutautas";
        }

        /// <summary>
        /// Read and validate cost per guest input.
        /// </summary>
        /// <returns></returns>
        private bool ReadCostPerGuest()
        {
            bool ok = double.TryParse(costPerGuestIn.Text.Trim(), out double input);

            if (ok && input >= 0)
            {
                _eventManager.CostPerPerson = input;
                return true;
            }
            MessageBox.Show("Invalid cost value. Try again.", "Error");

            return false;
        }

        /// <summary>
        /// Read and validate fee per guest input.
        /// </summary>
        /// <returns></returns>
        private bool ReadFeePerGuest()
        {
            bool ok = double.TryParse(feePerGuest.Text.Trim(), out double input);

            if (ok && input >= 0)
            {
                _eventManager.FeePerPerson = input;
                return true;
            }
            MessageBox.Show("Invalid fee value. Try again.", "Error");

            return false;
        }

        /// <summary>
        /// Check if event input (cost and fee per guest) is valid.
        /// </summary>
        /// <returns></returns>
        private bool ReadEventInputOk()
        {
            return ReadCostPerGuest() && ReadFeePerGuest();
        }

        /// <summary>
        /// Update form title with event title.
        /// </summary>
        private void UpdateEventWindow()
        {
            Text = _eventManager.Title;
            guestListBox.Items.Clear();
        }

        /// <summary>
        /// Event handler for adding a guest.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void clickAddGuest(object sender, EventArgs e)
        {
            Participant guest = new Participant();

            if (ReadGuestDataOk(ref guest))
            {
                _eventManager.ParticipantManager.AddParticipant(guest);
                UpdateGuestList();
            }
        }

        /// <summary>
        /// Read and validate guest data input.
        /// </summary>
        /// <param name="participant"></param>
        /// <returns></returns>
        private bool ReadGuestDataOk(ref Participant participant)
        {
            participant.FirstName = firstNameIn.Text.Trim();
            participant.SecondName = secondNameIn.Text.Trim();
            Address address = ReadGuestAddress();
            participant.Address = address;

            if (participant.Validate())
            {
                return true;
            }
            else
            {
                MessageBox.Show("Please make sure all fields are filled in correctly.\n" +
                    "Requires:\nFirst Name\nSecond Name\nStreet\nCity\nZip Code", "Error");
                return false;
            }
        }

        /// <summary>
        /// Read and set guest address details.
        /// </summary>
        /// <returns></returns>
        private Address ReadGuestAddress()
        {
            Address address = new Address();

            address.Street = streetIn.Text.Trim();
            address.ZipCode = zipCodeIn.Text.Trim();
            address.City = cityIn.Text.Trim();
            address.Country = (Countries)countryDropDown.SelectedIndex;

            return address;
        }

        /// <summary>
        /// Update guest list on form.
        /// </summary>
        private void UpdateGuestList()
        {
            if (_eventManager.ParticipantManager.GetParticipantsInfo() != null)
            {
                guestListBox.Items.Clear();
                guestListBox.Items.AddRange(_eventManager.ParticipantManager.GetParticipantsInfo());
            }
            UpdateEventEconomy();
        }

        /// <summary>
        /// Update event economy details on form.
        /// </summary>
        private void UpdateEventEconomy()
        {
            numbGuestOut.Text = _eventManager.ParticipantManager.Count.ToString();
            totalCostOut.Text = _eventManager.CalcTotalCost().ToString();
            totalFeesOut.Text = _eventManager.CalcTotalFee().ToString();
            incomeOut.Text = _eventManager.CalcTotalIncome().ToString();
        }

        /// <summary>
        /// Event handler for changing guest details.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void clickChange(object sender, EventArgs e)
        {
            int i = guestListBox.SelectedIndex;

            if (i < 0) { 
                return; 
            }
            Participant participant = _eventManager.ParticipantManager.GetParticipantAt(i);

            if (ReadGuestDataOk(ref participant))
            {
                _eventManager.ParticipantManager.ChangeParticipantAt(participant, i);
                UpdateGuestList();
            }

        }

        /// <summary>
        /// Event handler for deleting a guest.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void clickDelete(object sender, EventArgs e)
        {
            int i = guestListBox.SelectedIndex;

            if (i < 0) { 
                return; 
            }

            _eventManager.ParticipantManager.DeleteParticipantAt(i);
            UpdateGuestList();
        }

        /// <summary>
        /// Event handler for selecting a guest from the list.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void guestListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int i = guestListBox.SelectedIndex; // select participant.

            if (i >= 0)
            {
                Participant participant = _eventManager.ParticipantManager.GetParticipantAt(i);

                if (participant != null)
                {
                    firstNameIn.Text = participant.FirstName;
                    secondNameIn.Text = participant.SecondName;
                    streetIn.Text = participant.Address.Street;
                    cityIn.Text = participant.Address.City;
                    zipCodeIn.Text = participant.Address.ZipCode;
                    countryDropDown.SelectedIndex = Convert.ToInt16(participant.Address.Country);
                }
            } 
            else
            {
                MessageBox.Show("Select a guest from the list.", "Error");
            }
        }
    }
}