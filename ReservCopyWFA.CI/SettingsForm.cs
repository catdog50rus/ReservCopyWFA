using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReservCopyWFA.CI
{
    public partial class SettingsForm : Form
    {
        public bool DateName { get; set; } = true;
        public SettingsForm()
        {
            InitializeComponent();
        }

        private void SaveSettingButton_Click(object sender, EventArgs e)
        {
            if(!dateNameFolderCheckBox.Checked)
            {
                DateName = false;
            }

            
        }

        private void SettingsForm_Load(object sender, EventArgs e)
        {

        }
    }
}
