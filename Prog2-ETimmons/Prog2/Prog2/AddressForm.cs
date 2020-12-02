

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UPVApp
{
    public partial class AddressForm : Form
    {
        public AddressForm()
        {
            InitializeComponent();
        }

        internal string NameInputValue // Can be accessed by other classes in same namespace
        {
            // Precondition:  None
            // Postcondition: Text in nameInputTxt is returned
            get { return nameTextBox.Text; }

            // Precondition:  None
            // Postcondition: Text in inputTxt is set to specified value
            set { nameTextBox.Text = value; }
        }

        private void AddressForm_Load(object sender, EventArgs e)
        {
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox1.SelectedIndex)
            {
                case 0: // case Circle is selected
                    
                    break;
                case 1: // case Rectangle is selected
                    
                    break;
                case 2: // case Ellipse is selected
                    
                    break;
                case 3: // case Pie is selected
                    
                    break;
                case 4: // case Filled Circle is selected
                    
                    break;
                case 5: // case Filled Rectangle is selected
                    
                    break;
                case 6: // case Filled Ellipse is selected
                    
                case 7: // case Filled Pie is selected
                    
                    break;
            }
        }

        private void cancelAddressButton_Click(object sender, EventArgs e)
        {
            
        }

        private void okAddressButton_Click(object sender, EventArgs e)
        {
          

        }
    }
}
