namespace assignment3
{
    public partial class MainForm : Form
    {
        private string inputName = string.Empty;
        private BMICalculator bmiCalculator = new BMICalculator();

        // Constructor for the MainForm class.
        public MainForm()
        {
            InitializeComponent();
            InitializeGUI();
        }

        private void InitializeGUI()
        {
            this.Text += " - Eldaras Zutautas";
            metricsButton.Checked = true; // on default metrics will be selected.
        }

        private void updateHeightText()
        {
            bmiResult.Text = string.Empty;
            weightCategory.Text = string.Empty;

            // Check if the metric unit option is selected, and update accordingly.
            if (metricsButton.Checked)
            {
                txtHeight.Text = "Height (cm)";
                txtWeight.Text = "Weight (kg)";
                weightInformation.Text = "Normal BMI is between 18.50 and 24.9";
                heightBoxInch.Visible = false;
            }
            else
            {
                txtHeight.Text = "Height (ft, inch)";
                txtWeight.Text = "Weight (lbs)";
                weightInformation.Text = "Normal BMI is between 111 and 150 lbs";
                heightBoxInch.Visible = true;
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            CenterToScreen();
        }

        // Buttons called when the metricsButton's checked state changes.
        private void metricsButton_CheckedChanged(object sender, EventArgs e)
        {
            updateHeightText();
        }

        private void imperialButton_CheckedChanged(object sender, EventArgs e)
        {
            updateHeightText();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            resultsGroupBox.Text = "Results for ";
            bool ok = readInputBMI();

            if (ok)
            {
                calculateAndDisplayResults();
            }
        }

        // Reads the input name, height, and weight, sets the unit, and returns whether the height and weight inputs are valid.
        private bool readInputBMI()
        {
            readName();
            bool heightOK = readHeight();
            bool weightOK = readWeight();
            readUnit();

            return heightOK && weightOK;
        }

        // Reads the input height, checks its validity, converts it to inches if necessary, and sets it in the bmiCalculator.
        private bool readHeight()
        {
            double height = 0.0;
            double inch = 0.0;

            bool ok = double.TryParse(heightCmFtBox.Text, out height);
            if (!ok)
            {
                // displays an error message in a MessageBox dialog if the height value is invalid
                MessageBox.Show("The height value is invalid.", "Error");
            }

            if (imperialButton.Checked)
            {
                ok = ok && double.TryParse(heightBoxInch.Text, out inch);
                if (!ok)
                {
                    // displays an error message in a MessageBox dialog if the inch value is invalid
                    MessageBox.Show("The inch value is invalid.", "Error");
                }
            }

            if (bmiCalculator.getUnit() == UnitTypes.Metric)
            {
                height = height / 100.0;
            }
            else
            {
                height = height * 12.0 + inch;
            }
            bmiCalculator.setHeight(height);

            return ok;
        }

        // Reads the input weight, checks its validity, and sets it in the bmiCalculator.
        private bool readWeight()
        {
            double weight = 0.0;

            bool ok = double.TryParse(weightBox.Text, out weight);
            if (!ok)
            {
                MessageBox.Show("The weight value is invalid.", "Error");
            }
            bmiCalculator.setWeight(weight);

            return ok;
        }

        // Reads the input name from the nameBox, trims whitespace, and appends it to the resultsGroupBox text.
        private void readName()
        {
            nameBox.Text.Trim();
            if (!string.IsNullOrEmpty(nameBox.Text))
            {
                resultsGroupBox.Text = resultsGroupBox.Text + nameBox.Text;
            }
            else
            {
                resultsGroupBox.Text = resultsGroupBox.Text + "Unknown";
            }
        }

        // Sets the unit of the bmiCalculator to Metric or Imperial based on the selected button.
        private void readUnit()
        {
            if (metricsButton.Checked)
            {
                bmiCalculator.setUnit(UnitTypes.Metric);
            }
            else
            {
                bmiCalculator.setUnit(UnitTypes.Imperial);
            }
        }

        // Calculates the BMI and displays the result and corresponding weight category in the respective text fields.
        private void calculateAndDisplayResults()
        {
            double bmi = bmiCalculator.calculateBmi();
            bmiResult.Text = bmi.ToString("f2");
            weightCategory.Text = bmiCalculator.weightCategory();
        }
    }
}
