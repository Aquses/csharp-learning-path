namespace assingment5
{
    partial class EventForm
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

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            newEventBox = new GroupBox();
            feeLbl = new Label();
            costLbl = new Label();
            eventNameLbl = new Label();
            createEventBtn = new Button();
            feePerGuest = new TextBox();
            costPerGuestIn = new TextBox();
            eventNameIn = new TextBox();
            addGuestBox = new GroupBox();
            countryLbl = new Label();
            zipCodeLbl = new Label();
            cityLbl = new Label();
            streetLbl = new Label();
            secondNameLbl = new Label();
            firstNameLbl = new Label();
            addGuestBtn = new Button();
            countryDropDown = new ComboBox();
            zipCodeIn = new TextBox();
            cityIn = new TextBox();
            streetIn = new TextBox();
            secondNameIn = new TextBox();
            firstNameIn = new TextBox();
            guestListBox = new ListBox();
            eventEconomyBox = new GroupBox();
            surplusDeficitLbl = new Label();
            totalFeesLbl = new Label();
            totalCostLbl = new Label();
            numberOfGuestLbl = new Label();
            incomeOut = new Label();
            totalFeesOut = new Label();
            totalCostOut = new Label();
            numbGuestOut = new Label();
            guestLbl = new Label();
            addressLbl = new Label();
            changeBtn = new Button();
            deleteBtn = new Button();
            newEventBox.SuspendLayout();
            addGuestBox.SuspendLayout();
            eventEconomyBox.SuspendLayout();
            SuspendLayout();
            // 
            // newEventBox.
            // 
            newEventBox.Controls.Add(feeLbl);
            newEventBox.Controls.Add(costLbl);
            newEventBox.Controls.Add(eventNameLbl);
            newEventBox.Controls.Add(createEventBtn);
            newEventBox.Controls.Add(feePerGuest);
            newEventBox.Controls.Add(costPerGuestIn);
            newEventBox.Controls.Add(eventNameIn);
            newEventBox.ForeColor = Color.Teal;
            newEventBox.Location = new Point(19, 25);
            newEventBox.Margin = new Padding(2, 1, 2, 1);
            newEventBox.Name = "newEventBox";
            newEventBox.Padding = new Padding(2, 1, 2, 1);
            newEventBox.Size = new Size(332, 167);
            newEventBox.TabIndex = 0;
            newEventBox.TabStop = false;
            newEventBox.Text = "New Event";
            // 
            // feeLbl
            // 
            feeLbl.AutoSize = true;
            feeLbl.ForeColor = Color.Black;
            feeLbl.Location = new Point(13, 100);
            feeLbl.Margin = new Padding(2, 0, 2, 0);
            feeLbl.Name = "feeLbl";
            feeLbl.Size = new Size(77, 15);
            feeLbl.TabIndex = 6;
            feeLbl.Text = "Fee per guest";
            // 
            // costLbl
            // 
            costLbl.AutoSize = true;
            costLbl.ForeColor = Color.Black;
            costLbl.Location = new Point(13, 63);
            costLbl.Margin = new Padding(2, 0, 2, 0);
            costLbl.Name = "costLbl";
            costLbl.Size = new Size(83, 15);
            costLbl.TabIndex = 5;
            costLbl.Text = "Cost per guest";
            // 
            // eventNameLbl
            // 
            eventNameLbl.AutoSize = true;
            eventNameLbl.ForeColor = Color.Black;
            eventNameLbl.Location = new Point(13, 27);
            eventNameLbl.Margin = new Padding(2, 0, 2, 0);
            eventNameLbl.Name = "eventNameLbl";
            eventNameLbl.Size = new Size(71, 15);
            eventNameLbl.TabIndex = 4;
            eventNameLbl.Text = "Event Name";
            // 
            // createEventBtn
            // 
            createEventBtn.ForeColor = Color.Teal;
            createEventBtn.Location = new Point(114, 131);
            createEventBtn.Margin = new Padding(2, 1, 2, 1);
            createEventBtn.Name = "createEventBtn";
            createEventBtn.Size = new Size(91, 22);
            createEventBtn.TabIndex = 3;
            createEventBtn.Text = "Create Event";
            createEventBtn.UseVisualStyleBackColor = true;
            createEventBtn.Click += clickCreateEvent;
            // 
            // feePerGuest
            // 
            feePerGuest.Location = new Point(240, 97);
            feePerGuest.Margin = new Padding(2, 1, 2, 1);
            feePerGuest.Name = "feePerGuest";
            feePerGuest.Size = new Size(74, 23);
            feePerGuest.TabIndex = 2;
            // 
            // costPerGuestIn
            // 
            costPerGuestIn.Location = new Point(240, 60);
            costPerGuestIn.Margin = new Padding(2, 1, 2, 1);
            costPerGuestIn.Name = "costPerGuestIn";
            costPerGuestIn.Size = new Size(74, 23);
            costPerGuestIn.TabIndex = 1;
            // 
            // eventNameIn
            // 
            eventNameIn.Location = new Point(114, 24);
            eventNameIn.Margin = new Padding(2, 1, 2, 1);
            eventNameIn.Name = "eventNameIn";
            eventNameIn.Size = new Size(200, 23);
            eventNameIn.TabIndex = 0;
            // 
            // addGuestBox
            // 
            addGuestBox.Controls.Add(countryLbl);
            addGuestBox.Controls.Add(zipCodeLbl);
            addGuestBox.Controls.Add(cityLbl);
            addGuestBox.Controls.Add(streetLbl);
            addGuestBox.Controls.Add(secondNameLbl);
            addGuestBox.Controls.Add(firstNameLbl);
            addGuestBox.Controls.Add(addGuestBtn);
            addGuestBox.Controls.Add(countryDropDown);
            addGuestBox.Controls.Add(zipCodeIn);
            addGuestBox.Controls.Add(cityIn);
            addGuestBox.Controls.Add(streetIn);
            addGuestBox.Controls.Add(secondNameIn);
            addGuestBox.Controls.Add(firstNameIn);
            addGuestBox.ForeColor = Color.Teal;
            addGuestBox.Location = new Point(19, 194);
            addGuestBox.Margin = new Padding(2, 1, 2, 1);
            addGuestBox.Name = "addGuestBox";
            addGuestBox.Padding = new Padding(2, 1, 2, 1);
            addGuestBox.Size = new Size(332, 257);
            addGuestBox.TabIndex = 1;
            addGuestBox.TabStop = false;
            addGuestBox.Text = "Add Participant";
            // 
            // countryLbl
            // 
            countryLbl.AutoSize = true;
            countryLbl.ForeColor = Color.Black;
            countryLbl.Location = new Point(8, 179);
            countryLbl.Margin = new Padding(2, 0, 2, 0);
            countryLbl.Name = "countryLbl";
            countryLbl.Size = new Size(50, 15);
            countryLbl.TabIndex = 12;
            countryLbl.Text = "Country";
            // 
            // zipCodeLbl
            // 
            zipCodeLbl.AutoSize = true;
            zipCodeLbl.ForeColor = Color.Black;
            zipCodeLbl.Location = new Point(8, 145);
            zipCodeLbl.Margin = new Padding(2, 0, 2, 0);
            zipCodeLbl.Name = "zipCodeLbl";
            zipCodeLbl.Size = new Size(55, 15);
            zipCodeLbl.TabIndex = 11;
            zipCodeLbl.Text = "Zip Code";
            // 
            // cityLbl
            // 
            cityLbl.AutoSize = true;
            cityLbl.ForeColor = Color.Black;
            cityLbl.Location = new Point(8, 112);
            cityLbl.Margin = new Padding(2, 0, 2, 0);
            cityLbl.Name = "cityLbl";
            cityLbl.Size = new Size(28, 15);
            cityLbl.TabIndex = 10;
            cityLbl.Text = "City";
            // 
            // streetLbl
            // 
            streetLbl.AutoSize = true;
            streetLbl.ForeColor = Color.Black;
            streetLbl.Location = new Point(8, 81);
            streetLbl.Margin = new Padding(2, 0, 2, 0);
            streetLbl.Name = "streetLbl";
            streetLbl.Size = new Size(37, 15);
            streetLbl.TabIndex = 9;
            streetLbl.Text = "Street";
            // 
            // secondNameLbl
            // 
            secondNameLbl.AutoSize = true;
            secondNameLbl.ForeColor = Color.Black;
            secondNameLbl.Location = new Point(8, 50);
            secondNameLbl.Margin = new Padding(2, 0, 2, 0);
            secondNameLbl.Name = "secondNameLbl";
            secondNameLbl.Size = new Size(81, 15);
            secondNameLbl.TabIndex = 8;
            secondNameLbl.Text = "Second Name";
            // 
            // firstNameLbl
            // 
            firstNameLbl.AutoSize = true;
            firstNameLbl.ForeColor = Color.Black;
            firstNameLbl.Location = new Point(8, 21);
            firstNameLbl.Margin = new Padding(2, 0, 2, 0);
            firstNameLbl.Name = "firstNameLbl";
            firstNameLbl.Size = new Size(64, 15);
            firstNameLbl.TabIndex = 7;
            firstNameLbl.Text = "First Name";
            // 
            // addGuestBtn
            // 
            addGuestBtn.ForeColor = Color.Teal;
            addGuestBtn.Location = new Point(114, 225);
            addGuestBtn.Margin = new Padding(2, 1, 2, 1);
            addGuestBtn.Name = "addGuestBtn";
            addGuestBtn.Size = new Size(91, 22);
            addGuestBtn.TabIndex = 6;
            addGuestBtn.Text = "Add";
            addGuestBtn.UseVisualStyleBackColor = true;
            addGuestBtn.Click += clickAddGuest;
            // 
            // countryDropDown
            // 
            countryDropDown.FormattingEnabled = true;
            countryDropDown.Location = new Point(114, 176);
            countryDropDown.Margin = new Padding(2, 1, 2, 1);
            countryDropDown.Name = "countryDropDown";
            countryDropDown.Size = new Size(204, 23);
            countryDropDown.TabIndex = 5;
            // 
            // zipCodeIn
            // 
            zipCodeIn.Location = new Point(114, 142);
            zipCodeIn.Margin = new Padding(2, 1, 2, 1);
            zipCodeIn.Name = "zipCodeIn";
            zipCodeIn.Size = new Size(204, 23);
            zipCodeIn.TabIndex = 4;
            // 
            // cityIn
            // 
            cityIn.Location = new Point(114, 109);
            cityIn.Margin = new Padding(2, 1, 2, 1);
            cityIn.Name = "cityIn";
            cityIn.Size = new Size(204, 23);
            cityIn.TabIndex = 3;
            // 
            // streetIn
            // 
            streetIn.Location = new Point(114, 78);
            streetIn.Margin = new Padding(2, 1, 2, 1);
            streetIn.Name = "streetIn";
            streetIn.Size = new Size(204, 23);
            streetIn.TabIndex = 2;
            // 
            // secondNameIn
            // 
            secondNameIn.Location = new Point(114, 47);
            secondNameIn.Margin = new Padding(2, 1, 2, 1);
            secondNameIn.Name = "secondNameIn";
            secondNameIn.Size = new Size(204, 23);
            secondNameIn.TabIndex = 1;
            // 
            // firstNameIn
            // 
            firstNameIn.Location = new Point(114, 18);
            firstNameIn.Margin = new Padding(2, 1, 2, 1);
            firstNameIn.Name = "firstNameIn";
            firstNameIn.Size = new Size(204, 23);
            firstNameIn.TabIndex = 0;
            // 
            // guestListBox
            // 
            guestListBox.FormattingEnabled = true;
            guestListBox.ItemHeight = 15;
            guestListBox.Location = new Point(431, 50);
            guestListBox.Margin = new Padding(2, 1, 2, 1);
            guestListBox.Name = "guestListBox";
            guestListBox.Size = new Size(442, 214);
            guestListBox.TabIndex = 2;
            guestListBox.SelectedIndexChanged += guestListBox_SelectedIndexChanged;
            // 
            // eventEconomyBox
            // 
            eventEconomyBox.Controls.Add(surplusDeficitLbl);
            eventEconomyBox.Controls.Add(totalFeesLbl);
            eventEconomyBox.Controls.Add(totalCostLbl);
            eventEconomyBox.Controls.Add(numberOfGuestLbl);
            eventEconomyBox.Controls.Add(incomeOut);
            eventEconomyBox.Controls.Add(totalFeesOut);
            eventEconomyBox.Controls.Add(totalCostOut);
            eventEconomyBox.Controls.Add(numbGuestOut);
            eventEconomyBox.Location = new Point(517, 306);
            eventEconomyBox.Margin = new Padding(2, 1, 2, 1);
            eventEconomyBox.Name = "eventEconomyBox";
            eventEconomyBox.Padding = new Padding(2, 1, 2, 1);
            eventEconomyBox.Size = new Size(298, 125);
            eventEconomyBox.TabIndex = 3;
            eventEconomyBox.TabStop = false;
            eventEconomyBox.Text = "Event Economy";
            // 
            // surplusDeficitLbl
            // 
            surplusDeficitLbl.AutoSize = true;
            surplusDeficitLbl.ForeColor = Color.LimeGreen;
            surplusDeficitLbl.Location = new Point(12, 90);
            surplusDeficitLbl.Margin = new Padding(2, 0, 2, 0);
            surplusDeficitLbl.Name = "surplusDeficitLbl";
            surplusDeficitLbl.Size = new Size(84, 15);
            surplusDeficitLbl.TabIndex = 7;
            surplusDeficitLbl.Text = "Surplus/deficit";
            // 
            // totalFeesLbl
            // 
            totalFeesLbl.AutoSize = true;
            totalFeesLbl.ForeColor = Color.LimeGreen;
            totalFeesLbl.Location = new Point(13, 66);
            totalFeesLbl.Margin = new Padding(2, 0, 2, 0);
            totalFeesLbl.Name = "totalFeesLbl";
            totalFeesLbl.Size = new Size(56, 15);
            totalFeesLbl.TabIndex = 6;
            totalFeesLbl.Text = "Total fees";
            // 
            // totalCostLbl
            // 
            totalCostLbl.AutoSize = true;
            totalCostLbl.ForeColor = Color.LimeGreen;
            totalCostLbl.Location = new Point(12, 42);
            totalCostLbl.Margin = new Padding(2, 0, 2, 0);
            totalCostLbl.Name = "totalCostLbl";
            totalCostLbl.Size = new Size(57, 15);
            totalCostLbl.TabIndex = 5;
            totalCostLbl.Text = "Total cost";
            // 
            // numberOfGuestLbl
            // 
            numberOfGuestLbl.AutoSize = true;
            numberOfGuestLbl.ForeColor = Color.LimeGreen;
            numberOfGuestLbl.Location = new Point(12, 18);
            numberOfGuestLbl.Margin = new Padding(2, 0, 2, 0);
            numberOfGuestLbl.Name = "numberOfGuestLbl";
            numberOfGuestLbl.Size = new Size(102, 15);
            numberOfGuestLbl.TabIndex = 4;
            numberOfGuestLbl.Text = "Number of guests";
            // 
            // incomeOut
            // 
            incomeOut.BorderStyle = BorderStyle.Fixed3D;
            incomeOut.Location = new Point(151, 89);
            incomeOut.Margin = new Padding(2, 0, 2, 0);
            incomeOut.Name = "incomeOut";
            incomeOut.Size = new Size(135, 24);
            incomeOut.TabIndex = 3;
            // 
            // totalFeesOut
            // 
            totalFeesOut.BorderStyle = BorderStyle.Fixed3D;
            totalFeesOut.Location = new Point(151, 65);
            totalFeesOut.Margin = new Padding(2, 0, 2, 0);
            totalFeesOut.Name = "totalFeesOut";
            totalFeesOut.Size = new Size(135, 24);
            totalFeesOut.TabIndex = 2;
            // 
            // totalCostOut
            // 
            totalCostOut.BorderStyle = BorderStyle.Fixed3D;
            totalCostOut.Location = new Point(151, 41);
            totalCostOut.Margin = new Padding(2, 0, 2, 0);
            totalCostOut.Name = "totalCostOut";
            totalCostOut.Size = new Size(135, 24);
            totalCostOut.TabIndex = 1;
            // 
            // numbGuestOut
            // 
            numbGuestOut.BorderStyle = BorderStyle.Fixed3D;
            numbGuestOut.Location = new Point(151, 17);
            numbGuestOut.Margin = new Padding(2, 0, 2, 0);
            numbGuestOut.Name = "numbGuestOut";
            numbGuestOut.Size = new Size(135, 24);
            numbGuestOut.TabIndex = 0;
            // 
            // guestLbl
            // 
            guestLbl.AutoSize = true;
            guestLbl.ForeColor = Color.Teal;
            guestLbl.Location = new Point(442, 25);
            guestLbl.Margin = new Padding(2, 0, 2, 0);
            guestLbl.Name = "guestLbl";
            guestLbl.Size = new Size(64, 15);
            guestLbl.TabIndex = 4;
            guestLbl.Text = "Participant";
            // 
            // addressLbl
            // 
            addressLbl.AutoSize = true;
            addressLbl.ForeColor = Color.Teal;
            addressLbl.Location = new Point(630, 25);
            addressLbl.Margin = new Padding(2, 0, 2, 0);
            addressLbl.Name = "addressLbl";
            addressLbl.Size = new Size(49, 15);
            addressLbl.TabIndex = 5;
            addressLbl.Text = "Address";
            // 
            // changeBtn
            // 
            changeBtn.ForeColor = Color.Teal;
            changeBtn.Location = new Point(472, 275);
            changeBtn.Margin = new Padding(2, 1, 2, 1);
            changeBtn.Name = "changeBtn";
            changeBtn.Size = new Size(125, 22);
            changeBtn.TabIndex = 6;
            changeBtn.Text = "Change";
            changeBtn.UseVisualStyleBackColor = true;
            changeBtn.Click += clickChange;
            // 
            // deleteBtn
            // 
            deleteBtn.ForeColor = Color.Teal;
            deleteBtn.Location = new Point(711, 275);
            deleteBtn.Margin = new Padding(2, 1, 2, 1);
            deleteBtn.Name = "deleteBtn";
            deleteBtn.Size = new Size(125, 22);
            deleteBtn.TabIndex = 7;
            deleteBtn.Text = "Delete";
            deleteBtn.UseVisualStyleBackColor = true;
            deleteBtn.Click += clickDelete;
            // 
            // EventForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(900, 487);
            Controls.Add(deleteBtn);
            Controls.Add(changeBtn);
            Controls.Add(addressLbl);
            Controls.Add(guestLbl);
            Controls.Add(eventEconomyBox);
            Controls.Add(guestListBox);
            Controls.Add(addGuestBox);
            Controls.Add(newEventBox);
            Margin = new Padding(2, 1, 2, 1);
            Name = "EventForm";
            Text = "Event Manager";
            newEventBox.ResumeLayout(false);
            newEventBox.PerformLayout();
            addGuestBox.ResumeLayout(false);
            addGuestBox.PerformLayout();
            eventEconomyBox.ResumeLayout(false);
            eventEconomyBox.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        private GroupBox newEventBox;
        private GroupBox addGuestBox;
        private ListBox guestListBox;
        private TextBox feePerGuest;
        private TextBox costPerGuestIn;
        private TextBox eventNameIn;
        private Button createEventBtn;
        private Label eventNameLbl;
        private Label costLbl;
        private Label feeLbl;
        private Button addGuestBtn;
        private ComboBox countryDropDown;
        private TextBox zipCodeIn;
        private TextBox cityIn;
        private TextBox streetIn;
        private TextBox secondNameIn;
        private TextBox firstNameIn;
        private Label secondNameLbl;
        private Label firstNameLbl;
        private Label streetLbl;
        private Label cityLbl;
        private Label zipCodeLbl;
        private Label countryLbl;
        private Label numberOfGuestLbl;
        private Label incomeOut;
        private Label totalFeesOut;
        private Label totalCostOut;
        private Label numbGuestOut;
        private Label totalCostLbl;
        private Label totalFeesLbl;
        private Label surplusDeficitLbl;
        private Label guestLbl;
        private Label addressLbl;
        private Button changeBtn;
        private Button deleteBtn;
        private GroupBox eventEconomyBox;
    }
}