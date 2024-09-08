namespace assignment3
{
    partial class MainForm
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

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtName = new Label();
            nameBox = new TextBox();
            txtHeight = new Label();
            heightCmFtBox = new TextBox();
            weightBox = new TextBox();
            txtWeight = new Label();
            heightBoxInch = new TextBox();
            btnOK = new Button();
            unitGroupBox = new GroupBox();
            imperialButton = new RadioButton();
            metricsButton = new RadioButton();
            resultsGroupBox = new GroupBox();
            weightInformation = new Label();
            weightCategory = new Label();
            bmiResult = new Label();
            txtWeightCat = new Label();
            txtBMI = new Label();
            unitGroupBox.SuspendLayout();
            resultsGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // txtName
            // 
            txtName.AutoSize = true;
            txtName.Location = new Point(34, 35);
            txtName.Name = "txtName";
            txtName.Size = new Size(66, 15);
            txtName.TabIndex = 0;
            txtName.Text = "Your Name";
            // 
            // nameBox
            // 
            nameBox.Location = new Point(127, 32);
            nameBox.Name = "nameBox";
            nameBox.Size = new Size(163, 23);
            nameBox.TabIndex = 1;
            // 
            // txtHeight
            // 
            txtHeight.AutoSize = true;
            txtHeight.Location = new Point(34, 73);
            txtHeight.Name = "txtHeight";
            txtHeight.Size = new Size(43, 15);
            txtHeight.TabIndex = 2;
            txtHeight.Text = "Height";
            // 
            // heightCmFtBox
            // 
            heightCmFtBox.Location = new Point(127, 70);
            heightCmFtBox.Name = "heightCmFtBox";
            heightCmFtBox.Size = new Size(78, 23);
            heightCmFtBox.TabIndex = 3;
            // 
            // weightBox
            // 
            weightBox.Location = new Point(127, 109);
            weightBox.Name = "weightBox";
            weightBox.Size = new Size(78, 23);
            weightBox.TabIndex = 4;
            // 
            // txtWeight
            // 
            txtWeight.AutoSize = true;
            txtWeight.Location = new Point(34, 112);
            txtWeight.Name = "txtWeight";
            txtWeight.Size = new Size(45, 15);
            txtWeight.TabIndex = 5;
            txtWeight.Text = "Weight";
            // 
            // heightBoxInch
            // 
            heightBoxInch.Location = new Point(211, 70);
            heightBoxInch.Name = "heightBoxInch";
            heightBoxInch.Size = new Size(79, 23);
            heightBoxInch.TabIndex = 6;
            // 
            // btnOK
            // 
            btnOK.Location = new Point(127, 155);
            btnOK.Name = "btnOK";
            btnOK.Size = new Size(163, 23);
            btnOK.TabIndex = 7;
            btnOK.Text = "Calculate";
            btnOK.UseVisualStyleBackColor = true;
            btnOK.Click += btnOK_Click;
            // 
            // unitGroupBox
            // 
            unitGroupBox.Controls.Add(imperialButton);
            unitGroupBox.Controls.Add(metricsButton);
            unitGroupBox.Location = new Point(313, 32);
            unitGroupBox.Name = "unitGroupBox";
            unitGroupBox.Size = new Size(200, 83);
            unitGroupBox.TabIndex = 8;
            unitGroupBox.TabStop = false;
            unitGroupBox.Text = "Unit";
            // 
            // imperialButton
            // 
            imperialButton.AutoSize = true;
            imperialButton.Location = new Point(20, 47);
            imperialButton.Name = "imperialButton";
            imperialButton.Size = new Size(122, 19);
            imperialButton.TabIndex = 1;
            imperialButton.TabStop = true;
            imperialButton.Text = "Imperial (foot, lbs)";
            imperialButton.UseVisualStyleBackColor = true;
            imperialButton.CheckedChanged += imperialButton_CheckedChanged;
            // 
            // metricsButton
            // 
            metricsButton.AutoSize = true;
            metricsButton.Location = new Point(20, 22);
            metricsButton.Name = "metricsButton";
            metricsButton.Size = new Size(106, 19);
            metricsButton.TabIndex = 0;
            metricsButton.TabStop = true;
            metricsButton.Text = "Metric (kg, cm)";
            metricsButton.UseVisualStyleBackColor = true;
            metricsButton.CheckedChanged += metricsButton_CheckedChanged;
            // 
            // resultsGroupBox
            // 
            resultsGroupBox.Controls.Add(weightInformation);
            resultsGroupBox.Controls.Add(weightCategory);
            resultsGroupBox.Controls.Add(bmiResult);
            resultsGroupBox.Controls.Add(txtWeightCat);
            resultsGroupBox.Controls.Add(txtBMI);
            resultsGroupBox.Location = new Point(34, 206);
            resultsGroupBox.Name = "resultsGroupBox";
            resultsGroupBox.Size = new Size(479, 133);
            resultsGroupBox.TabIndex = 9;
            resultsGroupBox.TabStop = false;
            resultsGroupBox.Text = "Results for ";
            // 
            // weightInformation
            // 
            weightInformation.ForeColor = Color.Green;
            weightInformation.Location = new Point(227, 96);
            weightInformation.Name = "weightInformation";
            weightInformation.Size = new Size(225, 23);
            weightInformation.TabIndex = 5;
            weightInformation.Text = "label1";
            weightInformation.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // weightCategory
            // 
            weightCategory.BorderStyle = BorderStyle.Fixed3D;
            weightCategory.ForeColor = Color.Black;
            weightCategory.Location = new Point(227, 61);
            weightCategory.Name = "weightCategory";
            weightCategory.Size = new Size(225, 24);
            weightCategory.TabIndex = 4;
            weightCategory.Text = "label1";
            weightCategory.TextAlign = ContentAlignment.MiddleRight;
            // 
            // bmiResult
            // 
            bmiResult.BorderStyle = BorderStyle.Fixed3D;
            bmiResult.Location = new Point(333, 19);
            bmiResult.Name = "bmiResult";
            bmiResult.Size = new Size(119, 25);
            bmiResult.TabIndex = 2;
            bmiResult.Text = "label1";
            bmiResult.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txtWeightCat
            // 
            txtWeightCat.AutoSize = true;
            txtWeightCat.Location = new Point(7, 66);
            txtWeightCat.Name = "txtWeightCat";
            txtWeightCat.Size = new Size(96, 15);
            txtWeightCat.TabIndex = 1;
            txtWeightCat.Text = "Weight Category";
            // 
            // txtBMI
            // 
            txtBMI.AutoSize = true;
            txtBMI.Location = new Point(7, 30);
            txtBMI.Name = "txtBMI";
            txtBMI.Size = new Size(55, 15);
            txtBMI.TabIndex = 0;
            txtBMI.Text = "Your BMI";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(542, 450);
            Controls.Add(resultsGroupBox);
            Controls.Add(unitGroupBox);
            Controls.Add(btnOK);
            Controls.Add(heightBoxInch);
            Controls.Add(txtWeight);
            Controls.Add(weightBox);
            Controls.Add(heightCmFtBox);
            Controls.Add(txtHeight);
            Controls.Add(nameBox);
            Controls.Add(txtName);
            MinimizeBox = false;
            Name = "MainForm";
            Text = "BMI Calculator";
            Load += MainForm_Load;
            unitGroupBox.ResumeLayout(false);
            unitGroupBox.PerformLayout();
            resultsGroupBox.ResumeLayout(false);
            resultsGroupBox.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label txtName;
        private TextBox nameBox;
        private Label txtHeight;
        private TextBox heightCmFtBox;
        private TextBox weightBox;
        private Label txtWeight;
        private TextBox heightBoxInch;
        private Button btnOK;
        private GroupBox unitGroupBox;
        private RadioButton imperialButton;
        private RadioButton metricsButton;
        private GroupBox resultsGroupBox;
        private Label txtBMI;
        private Label weightCategory;
        private Label bmiResult;
        private Label txtWeightCat;
        private Label weightInformation;
    }
}
