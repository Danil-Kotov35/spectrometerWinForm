using HP2000_wrapper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class aboutSprctrometer : Form
    {
        private HP2000Wrapper wrapper = new HP2000Wrapper();
        public aboutSprctrometer()
        {
            InitializeComponent();
        }

        private void aboutSprctrometer_Load(object sender, EventArgs e)
        {
            
            string serialNum = wrapper.getProductSN();
            float[] wavelength = wrapper.getWavelength();
            int wavelengthMin = (int)wavelength[0];
            int wavelengthMax = (int)wavelength[511];
            SerialNumberLabel.Text = "Cерийный номер: "+ serialNum;
            waveLengthLabel.Text = $"Длины волн: {wavelengthMin} - {wavelengthMax}н/м";

        }
    }
}
