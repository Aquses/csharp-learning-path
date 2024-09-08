using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment3
{
    class BMICalculator
    {
        private double height;
        private double weight;
        private UnitTypes unit;

        // constructor for BMICalculator.
        public BMICalculator()
        {
            unit = UnitTypes.Metric;
        }

        // Setters and getters for height and weight.

        public double getHeight()
        {
            return height;
        }

        public void setHeight(double height)
        {
            if (height >= 0.0)
            {
                this.height = height;
            }
        }

        public double getWeight()
        {
            return weight;
        }

        public void setWeight(double weight)
        {
            if (weight >= 0.0)
            {
                this.weight = weight;
            }
        }

        // Getter and setter method to retrieve the unit type or set it. 
        public UnitTypes getUnit()
        {
            return unit;
        }

        public void setUnit(UnitTypes unit)
        {
            this.unit = unit;
        }

        // method to calculate the bmi based on weight, height, and factor.
        public double calculateBmi()
        {
            double bmiValue = 0.0;
            double factor = 0.0;

            // BMI = (weight * factor) / (height * height).
            // In Metric: BMI = weight (kg) / (height (m) * height (m)).
            // In Imperial: BMI = (weight (lb) * 703) / (height (in) * height (in)).
            if (unit == UnitTypes.Imperial)
            {
                factor = 703.0; // imperial factor.
            }
            else
            {
                factor = 1.0; // metric factor.
            }
            bmiValue = factor * weight / (height * height);

            return bmiValue;
        }

        public string weightCategory()
        {
            double bmi = calculateBmi();
            string stringOut = string.Empty;

            // Determine the weight category based on BMI value.
            if (bmi <= 18.5)
            {
                stringOut = "Underweight";
            }
            else if (bmi <= 24.9)
            {
                stringOut = "Normal weight";
            }
            else if (bmi <= 29.9)
            {
                stringOut = "Overweight (Pre-obesity)";
            }
            else if (bmi < 34.9)
            {
                stringOut = "Overweight (Obesity class I)";
            }
            else if (bmi <= 39.9)
            {
                stringOut = "Overweight (Obesity class II)";
            }
            else if (bmi >= 40.0)
            {
                stringOut = "Overweight (Obesity class III)";
            }
            else {
                stringOut = "Unknown";
            }

            return stringOut;
        }
    }
}
