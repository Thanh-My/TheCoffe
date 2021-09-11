using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TheCoffe.Model;

namespace TheCoffe
{
    public partial class Login : Form
    {
        TheCoffeeEntities coffe = new TheCoffeeEntities();
        public Login()
        {
            InitializeComponent();
        }

        private void User_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            var emp = coffe.Employees.FirstOrDefault(x=>x.UsernameEmp == txtUser.Text && x.pass == txtPass.Text);
            if (emp!=null)
            {
                if (emp.administrator == true)
                {
                    Form1 f1 = new Form1();
                    f1.ShowDialog();
                }
                else
                {
                    TableOrder tb = new TableOrder();
                    tb.ShowDialog();
                }
            }
            else
            {
                MessageBox.Show("Sai mật khẩu hoặc Tài khoản", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
