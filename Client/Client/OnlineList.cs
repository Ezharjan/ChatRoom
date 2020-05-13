using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client
{
    public partial class OnlineList : Form
    {
        public ListFrom fatherWind;

        public OnlineList()
        {
            InitializeComponent();
        }

        private void OnlineList_Load(object sender, EventArgs e)
        {
            Control.CheckForIllegalCrossThreadCalls = false;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            bool flag = true;
            string temp = listBoxName.SelectedItem.ToString();
            foreach (var str in fatherWind.listOnl.Items)
            {
                if (str.ToString() == temp)
                    flag = false;
            }
            if (flag == true && listBoxName.SelectedItem.ToString() != "")
            {
                fatherWind.listOnl.Items.Add(listBoxName.SelectedItem.ToString());
            }
            else
            {
                MessageBox.Show("用户已添加。", "错误", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
            }
        }

        private void buttonAddAll_Click(object sender, EventArgs e)
        {
            foreach (var str in listBoxName.Items)
            {
                bool flag = true;
                foreach (var temp in fatherWind.listOnl.Items)
                {
                    if (str.ToString() == temp.ToString())
                        flag = false;
                }
                if(flag == true && str.ToString() != "")
                    fatherWind.listOnl.Items.Add(str);
            }
            this.Close();

        }
    }
}
