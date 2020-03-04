using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReservCopyWFA.CI.AdditionalForms
{
    public partial class CopyErrorForm : Form
    {
        private List<string> copyErroList { get; }
        MainForm mainform { get; }
        
        public CopyErrorForm(List<string> copyErrorList)
        {
            InitializeComponent();
            this.copyErroList = copyErrorList;
            UpdateList();
        }

        private void UpdateList()
        {
            foreach (var item in copyErroList)
            {
                listView1.Items.Add(item);
            }
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            
        }
    }
}
