using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ex1004
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            string message = "輸入的字元少於5個字，請重新輸入";
            string account = "輸入帳密";
            string password = "輸入密碼";
            MessageBoxButtons BtnName = MessageBoxButtons.YesNo;
            MessageBoxButtons BtnPwd = MessageBoxButtons.OKCancel;
            MessageBoxIcon iconInfo = MessageBoxIcon.Information;
            MessageBoxIcon iconwarn = MessageBoxIcon.Warning;
            DialogResult result, confirm;
            if (txtAccount.Text.Length >= 5)
            {
                if (txtPwd.Text.Length >= 5)
                {
                    string verify = $"{txtAccount.Text}," + $"{(rabMale.Checked ? "帥哥" : "美女")},你好!" + $"\n密碼:{txtPwd.Text},資料正確"; 
                }
            }
        }
    }
}
