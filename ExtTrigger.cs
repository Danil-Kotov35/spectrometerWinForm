using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.CheckBox;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace WindowsFormsApp1
{
    public partial class ExtTrigger : Form
    {

        public System.Windows.Forms.CheckBox onExtTriggerCheckBox => onExtTrigger;




        public ExtTrigger()
        {
            InitializeComponent();
            onExtTrigger.Checked = Properties.Settings.Default.onExtTriggerState;
        }

        private void onExtTrigger_CheckedChanged(object sender, EventArgs e)
        {
           bool ischecked = onExtTrigger.Checked;
           Properties.Settings.Default.onExtTriggerState = onExtTrigger.Checked;//присваиваем
           Properties.Settings.Default.Save(); // сохраняем состояние чекбокса чтобы при повторном открытии все было четко 
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            onExtTrigger.Checked = false;
            this.Close();
        }

        private void extTrigStopAutomaticButton_CheckedChanged(object sender, EventArgs e)
        {
            
            if (extTrigStopAutomaticButton.Checked == true) 
            {
                timeOffInput.Enabled = true;
            }
        }

        private void extTrigStopManualButton_CheckedChanged(object sender, EventArgs e)
        {
            if (extTrigStopManualButton.Checked == true)
            {
                timeOffInput.Enabled = false;
            }
        }
    }
}
