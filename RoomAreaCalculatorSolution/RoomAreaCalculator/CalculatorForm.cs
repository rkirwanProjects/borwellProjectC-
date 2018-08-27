using System;
using System.Linq;
using System.Windows.Forms;
using RoomAreaCalculatorLibrary;

namespace RoomAreaCalculator
{
    public partial class CalculatorForm : Form
    {
        public CalculatorForm()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            //If a text box is empty
            if (this.Controls.OfType<TextBox>().Any(t => string.IsNullOrEmpty(t.Text)))
            {
                MessageBox.Show("Please enter a value into all the text boxes");
            }
            else  //Do Calculations
            {
                double width = Convert.ToDouble(txtWidth.Text);
                double length = Convert.ToDouble(txtLength.Text);
                double height = Convert.ToDouble(txtHeight.Text);

                double floorArea = Calculator.CalculateFloorArea(width, length);
                double roomVolume = Calculator.CalculateRoomVolume(width, length, height);
                double paintRequired = Calculator.CalculatePaintRequired(width, length, height);

                //Show Outputs
                grpOutputs.Visible = true;

                lblFloorAreaOutput.Text = floorArea + " m²";
                lblRoomVolumeOutput.Text = roomVolume + " m³";
                lblPaintRequiredOutput.Text = paintRequired + " m²";
            }
        }
        
        private void txtWidth_KeyPress(object sender, KeyPressEventArgs e)
        {
            keyPressed(sender, e);
        }

        private void txtLength_KeyPress(object sender, KeyPressEventArgs e)
        {
            keyPressed(sender, e);
        }

        private void txtHeight_KeyPress(object sender, KeyPressEventArgs e)
        {
            keyPressed(sender, e);
        }

        //Single validation function used by all three textboxes 
        private void keyPressed(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            TextBox tb = (TextBox)sender;

            //Only alows one decimal place
            if (ch == 46 && tb.Text.IndexOf('.') != -1)
            {
                e.Handled = true;
            }

            //Only allows digits
            if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }

        private void myAssumptionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("The room is either a square or rectangle shape.\nThe room does not have a sloping roof or floor.\nOpposite walls are the same width or length.\nThe room does not have any windows or doors.", "My Assumptions");
        }
    }
}