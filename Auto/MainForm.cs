using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Auto
{
    public partial class MainForm : Form
    {
        private Button[] allButtons;

        public MainForm()
        {
            InitializeComponent();
            InitializeBase();
        }

        private void InitializeBase()
        {
            // Initialize the array with all your buttons
            allButtons = new Button[] { button_Equipment, button_Question, button_Issue };
            ComboBoxUpdater.CreateDictionaries();
        }

        private void button_Equipment_Click(object sender, EventArgs e)
        {
            ComboBoxUpdater.PopulateDropDown(comboBox_Subject, "equipment");

            // Update the appearance of the clicked button and reset others
            Functions.UpdateButtonAppearance(button_Equipment);
            Functions.ResetAllButtonsAppearance(button_Question, button_Issue);
        }

        private void button_Question_Click(object sender, EventArgs e)
        {
            ComboBoxUpdater.PopulateDropDown(comboBox_Subject, "question");

            // Update the appearance of the clicked button and reset others
            Functions.UpdateButtonAppearance(button_Question);
            Functions.ResetAllButtonsAppearance(button_Question, button_Issue);
        }

        private void button_Issue_Click(object sender, EventArgs e)
        {
            ComboBoxUpdater.PopulateDropDown(comboBox_Subject, "issue");

            // Update the appearance of the clicked button and reset others
            Functions.UpdateButtonAppearance(button_Issue);
            Functions.ResetAllButtonsAppearance(button_Question, button_Issue);
        }
    }
}
