using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using TheCoffe.Model;

namespace TheCoffe
{
    public partial class Employye : Form

    {
        TheCoffeeEntities Coffe = new TheCoffeeEntities();
        bool edit;
        int position;
        public Employye()
        {
            InitializeComponent();
            DisplayEmployee();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            edit = false;
            txtNickName.ReadOnly = false;
            txtNickName.Text = "";
            txtName.Text = "";
            cbFemale.Checked = false;
            CbMale.Checked = false;
            rTxtAdrress.Text = "";
            txtEmail.Text = "";
            txtPhone.Text = "";
            txtFile.Text = "";
            txtSalary.Text = "";
            picBoxEmployye.Image = null;
            btnSave.Enabled = false;
            btnAdd.Enabled = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (edit)
            {
                var emp = Coffe.Employees.FirstOrDefault(x => x.UsernameEmp == txtNickName.Text);
                if (emp != null)
                {
                    try
                    {
                        emp.UsernameEmp = txtNickName.Text;
                        emp.NameEmp = txtName.Text;
                        if (CbMale.Checked)
                        {
                            emp.Gender = "Nam";
                        }
                        else if (cbFemale.Checked)
                        {
                            emp.Gender = "Nữ";
                        }
                        else
                        {
                            emp.Gender = "Chưa Xác Định";
                        }
                        emp.Birthday = dpBirthday.Value;
                        if (Regex.Match(txtPhone.Text, @"^0+([0-9]{9})$").Success)
                        {
                            emp.Phone = txtPhone.Text;
                        }
                        var emailV = new EmailAddressAttribute();
                        if (emailV.IsValid(txtEmail.Text))
                        {
                            emp.Email = txtEmail.Text;
                        }
                        emp.Address = rTxtAdrress.Text;
                        emp.Hinh = txtFile.Text;
                        if (Regex.Match(txtSalary.Text, @"^[1-9]+([0-9]{1,5})$").Success)
                        {
                            emp.salary = txtSalary.Text;
                        }
                        emp.pass = txtPass.Text;
                        if (cbAdmin.Checked)
                        {
                            emp.administrator = true;
                        }
                        else
                        {
                            emp.administrator = false;
                        }
                        Coffe.SaveChanges();
                        DisplayEmployee();
                        dgvEmployee.Rows[0].Selected = false;
                        dgvEmployee.Rows[position].Selected = true;
                        MessageBox.Show("Nếu sai cú pháp mọi giá trị bạn sửa sẽ không được thay đổi", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Vui Lòng không bỏ trống thông tin và nhập đúng cú pháp", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Không tìm thấy dữ liệu", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            
        }
        private void DisplayEmployee()
        {
            //truy vấn lấy các thông tin cần thiết trong bảng Employee
            var employess = from emp in Coffe.Employees
                            select new
                            {
                                Nick_Name = emp.UsernameEmp,
                                Ho_Ten = emp.NameEmp,
                                Gioi_Tinh = emp.Gender,
                                Birthday = emp.Birthday,
                                Dia_chi = emp.Address,
                                Email = emp.Email,
                                Dien_thoai = emp.Phone,
                                Hinh = emp.Hinh,
                                Luong = emp.salary,
                                Pass = emp.pass,
                                admin = emp.administrator ? "Quản Lý" : "Nhân Viên"
                            };
            //hiển thị lên lưới
            dgvEmployee.DataSource = employess.ToList();
            DisplayEmployeeDetail();
        }

        private void DisplayEmployeeDetail()
        {
            if (dgvEmployee.CurrentRow != null)
            {
                DataGridViewRow row = dgvEmployee.CurrentRow;
                txtNickName.Text = row.Cells[0].Value.ToString();
                txtName.Text = row.Cells[1].Value.ToString();
                if (row.Cells[2].Value.ToString().Equals("Nam"))
                {
                    cbFemale.Checked = false;
                    CbMale.Checked = true;
                }
                else
                {
                    cbFemale.Checked = true;
                    CbMale.Checked = false;
                }
                dpBirthday.Value = (DateTime)row.Cells[3].Value;
                rTxtAdrress.Text = row.Cells[4].Value.ToString();
                txtEmail.Text = row.Cells[5].Value.ToString();
                txtPhone.Text = row.Cells[6].Value.ToString();
                txtFile.Text = row.Cells[7].Value.ToString();
                txtSalary.Text = row.Cells[8].Value.ToString();
                txtPass.Text = row.Cells[9].Value.ToString();
                if (row.Cells[10].Value.ToString().Equals("Quản Lý"))
                {
                    cbAdmin.Checked = true;
                }
                else
                {
                    cbAdmin.Checked = false;
                }
                position = dgvEmployee.CurrentRow.Index;
                edit = true;
                txtNickName.ReadOnly = true;
                string paths = Application.StartupPath.Substring(0, (Application.StartupPath.Length - 10));
                string imgPaths = paths + "\\Images\\" + txtFile.Text;
                picBoxEmployye.Image = new Bitmap(imgPaths);
            }
        }

        private void dgvEmployee_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnSave.Enabled = true;
            btnAdd.Enabled = false;
            DisplayEmployeeDetail();
        }

        private void dgvEmployee_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                Employee emp = new Employee();
                emp.UsernameEmp = txtNickName.Text;
                emp.NameEmp = txtName.Text;
                if (CbMale.Checked)
                {
                    emp.Gender = "Nam";
                }
                else if (cbFemale.Checked)
                {
                    emp.Gender = "Nữ";
                }
                else
                {
                    emp.Gender = "Chưa Xác Định";
                }
                emp.Birthday = dpBirthday.Value;
                if (Regex.Match(txtPhone.Text, @"^0+([0-9]{9})$").Success)
                {
                    emp.Phone = txtPhone.Text;
                }
                var emailV = new EmailAddressAttribute();
                if (emailV.IsValid(txtEmail.Text))
                {
                    emp.Email = txtEmail.Text;
                }
                emp.Address = rTxtAdrress.Text;
                emp.Hinh = txtFile.Text;
                if (Regex.Match(txtSalary.Text, @"^[1-9]+([0-9]{1,5})$").Success)
                {
                    emp.salary = txtSalary.Text;
                }
                emp.pass = txtPass.Text;
                if (cbAdmin.Checked)
                {
                    emp.administrator = true;
                }
                else
                {
                    emp.administrator = false;
                }
                Coffe.Employees.Add(emp);
                Coffe.SaveChanges();
                DisplayEmployee();
                dgvEmployee.Rows[0].Selected = false;
                dgvEmployee.Rows[position].Selected = true;
            }
            catch (Exception)
            {

                MessageBox.Show("Vui Lòng không bỏ trống thông tin và nhập đúng cú pháp", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
                
            
        }

        private void btnAddFile_Click(object sender, EventArgs e)
        {
            //OpenFileDialog ofd = new OpenFileDialog();
            //ofd.InitialDirectory = "C:\\";
            //ofd.Filter = "Image Files (*.jpg)|*.jpg|All Files(*.*)|*.*";
            //ofd.FilterIndex = 1;   
            //if (ofd.ShowDialog()== System.Windows.Forms.DialogResult.OK)
            //{
            //    if (ofd.CheckFileExists)
            //    {
            //        string paths = Application.StartupPath.Substring(0, (Application.StartupPath.Length - 10));
            //        string correctFileName = System.IO.Path.GetFileName(ofd.FileName);
            //        System.IO.File.Copy(ofd.FileName, paths + "\\Images\\" + correctFileName);
            //        MessageBox.Show("Thêm Thành Công");
            //        txtFile.Text = correctFileName;
            //    }
            //}
        }

        private void picBoxEmployye_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.InitialDirectory = "C:\\";
            ofd.Filter = "Image Files (*.jpg)|*.jpg|All Files(*.*)|*.*";
            ofd.FilterIndex = 1;
            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                if (ofd.CheckFileExists)
                {
                    string paths = Application.StartupPath.Substring(0, (Application.StartupPath.Length - 10));
                    string correctFileName = System.IO.Path.GetFileName(ofd.FileName);
                    if (System.IO.File.Exists(paths + "\\Images\\" + correctFileName))
                    {
                        picBoxEmployye.Image = new Bitmap(paths + "\\Images\\" + correctFileName);

                        txtFile.Text = correctFileName;
                    }
                    else
                    {
                        System.IO.File.Copy(ofd.FileName, paths + "\\Images\\" + correctFileName);
                        MessageBox.Show("Thêm Thành Công");
                        picBoxEmployye.Image = new Bitmap(paths + "\\Images\\" + correctFileName);
                        txtFile.Text = correctFileName;
                    }
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvEmployee.CurrentRow != null)
            {
                if ((MessageBox.Show("Bạn có muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
                {
                    var emp = Coffe.Employees.FirstOrDefault(x => x.UsernameEmp == txtNickName.Text);
                    if (emp != null)
                    {
                        try
                        {
                            Coffe.Employees.Remove(emp);
                            Coffe.SaveChanges();
                            DisplayEmployee();
                        }
                        catch (Exception ex)
                        {

                            MessageBox.Show("Có Đơn Hàng Của Nhân viên Này", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }

                    }
                }
                else
                {
                    MessageBox.Show("Không tìm thấy dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}
