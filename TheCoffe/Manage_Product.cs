using System;
using System.Collections.Generic;
using System.ComponentModel;
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
    public partial class Manage_Product : Form
    {
        int position;
        bool edit = true;
        TheCoffeeEntities Coffe = new TheCoffeeEntities();
        public Manage_Product()
        {
            InitializeComponent();
            DisplayProductType();
            DisplayProduct();
            btnUpdate.Enabled = false;
            btnPDelete.Enabled = false;
            btnPUpdate.Enabled = false;

        }
        private void DisplayProductType()
        {
            var productType = from ProductType in Coffe.ProductTypes
                              select new
                            {
                                IDType = ProductType.IDType,
                                typeName = ProductType.TypeName,
                            };
            cbPSpecies.DataSource = productType.ToList();
            cbPSpecies.DisplayMember = "typeName";
            cbPSpecies.ValueMember = "IDType";
            dgvProType.DataSource = productType.ToList();
            DisplayProductTypeDetail();
        }
        private void DisplayProductTypeDetail()
        {
            if (dgvProType.CurrentRow != null)
            {
                DataGridViewRow row = dgvProType.CurrentRow;
                txtId.Text = row.Cells[0].Value.ToString();
                TxtName.Text = row.Cells[1].Value.ToString();
                position = dgvProType.CurrentRow.Index;
                edit = true;
                txtId.ReadOnly = true;
                btnUpdate.Enabled = true;
            }
           
            
        }
        private void DisplayProduct()
        {
            var product = from Product in Coffe.Products
                          join Ptype in Coffe.ProductTypes on Product.IDType equals Ptype.IDType
                              select new
                              {
                                  ID = Product.IDProduct,
                                  Name = Product.ProductName,
                                  IdType = Ptype.TypeName,
                                  Price = Product.Price,
                                  size = Product.Size
                              };
            dgvProduct.DataSource = product.ToList();
            cbPsize.DataSource = product.ToList();
            cbPsize.DisplayMember = "size";
            cbPsize.ValueMember = "size";
            DisplayProducteDetail();
        }
        private void DisplayProducteDetail()
        {
            if (dgvProduct.CurrentRow != null)
            {
                DataGridViewRow row = dgvProduct.CurrentRow;
                txtPID.Text = row.Cells[0].Value.ToString();
                txtPname.Text = row.Cells[1].Value.ToString();
                cbPSpecies.SelectedValue = row.Cells[2].Value.ToString();
                txtPPrice.Text = row.Cells[3].Value.ToString();
                cbPsize.SelectedValue = row.Cells[4].Value.ToString();
                position = dgvProType.CurrentRow.Index;
                edit = true;
                txtPID.ReadOnly = true;
                btnPDelete.Enabled = true;
                btnPUpdate.Enabled = true;
                btnPInsert.Enabled = false;
            }

        }
        
        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtId_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void TxtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void CbSize_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {
        }

        private void dgvProduct_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvProType_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DisplayProductTypeDetail();
        }

        private void dgvProduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DisplayProducteDetail();
        }

        private void cbPSpecies_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnInsert_Click(object sender, EventArgs e)
        {

            try
            {
                if (txtId.Text == null || TxtName == null)
                {
                    var pro = new ProductType();
                    pro.IDType = txtId.Text;
                    pro.TypeName = TxtName.Text;
                    Coffe.ProductTypes.Add(pro);
                    Coffe.SaveChanges();
                    DisplayProductType();
                    edit = false;
                    txtId.Text = "";
                    TxtName.Text = "";
                }
                else
                {

                    MessageBox.Show("Có Trường Còn Trống Hoặc Sai Dữ Liệu", "Thông báo",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Có Trường Còn Trống Hoặc Sai Dữ Liệu", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (edit)
            {
                var productType = Coffe.ProductTypes.FirstOrDefault(x => x.IDType == txtId.Text);
                if (productType != null)
                {
                    productType.IDType = txtId.Text;
                    productType.TypeName = TxtName.Text;
                    Coffe.SaveChanges();
                    DisplayProductType();
                    dgvProduct.Rows[0].Selected = false;
                    dgvProduct.Rows[position].Selected = true;
                    MessageBox.Show("Nếu sai cú pháp hoặc có giá trị để trống mọi giá trị bạn sửa sẽ không được thay đổi", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Không tìm thấy dữ liệu", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                var pro = new ProductType();
                pro.IDType = txtId.Text;
                pro.TypeName = TxtName.Text;
                Coffe.ProductTypes.Add(pro);
                Coffe.SaveChanges();
                DisplayProductType();
            }
        }

        private void btnPUpdate_Click(object sender, EventArgs e)
        {
            if (edit)
            {
                var p = Coffe.Products.FirstOrDefault(x => x.IDProduct == txtPID.Text);
                if (p != null)
                {
                    try
                    {
                        p.IDProduct = txtPID.Text;
                        p.ProductName = txtPname.Text;
                        p.IDType = cbPSpecies.SelectedValue.ToString();
                        if (Regex.Match(txtPPrice.Text, @"^[1-9]+([0-9]{1,5})$").Success)
                        {
                            p.Price = Convert.ToInt32(txtPPrice.Text);
                            p.Size = cbPsize.SelectedValue.ToString();

                        }
                        Coffe.SaveChanges();
                        DisplayProduct();
                        dgvProduct.Rows[0].Selected = false;
                        dgvProduct.Rows[position].Selected = true;
                        MessageBox.Show("Nếu sai cú pháp hoặc có giá trị để trống mọi giá trị bạn sửa sẽ không được thay đổi", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    catch (Exception)
                    {
                        MessageBox.Show("Có Trường Còn Trống Hoặc Sai Dữ Liệu", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Không tìm thấy dữ liệu", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                try
                {
                    var pro = new Product();
                    pro.IDProduct = txtId.Text;
                    pro.ProductName = TxtName.Text;
                    pro.IDType = cbPSpecies.SelectedValue.ToString();
                    if (Regex.Match(txtPPrice.Text, @"^[1-9]+([0-9]{1,5})$").Success)
                    {
                        pro.Price = Convert.ToInt32(txtPPrice.Text);
                        pro.Size = cbPsize.SelectedValue.ToString();
                        Coffe.Products.Add(pro);
                        Coffe.SaveChanges();
                        DisplayProduct();
                    }
                    
                }
                catch (Exception)
                {

                    throw;
                }
            }
        
    }

        private void btnDelete_Click(object sender, EventArgs e)
        {
           
        }

        private void btnPDelete_Click(object sender, EventArgs e)
        {
            if (dgvProType.CurrentRow != null)
            {
                if ((MessageBox.Show("Bạn có muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
                {
                    var product = Coffe.Products.FirstOrDefault(x => x.IDProduct == txtPID.Text);
                    if (product != null)
                    {
                        try
                        {
                            Coffe.Products.Remove(product);
                            Coffe.SaveChanges();
                            DisplayProduct();
                        }
                        catch (Exception ex)
                        {

                            MessageBox.Show("Có Đơn Hàng Của Sản Phẩm Này", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        
                    }
                }
                else
                {
                    MessageBox.Show("Không tìm thấy dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnPInsert_Click(object sender, EventArgs e)
        {
            try
            {
                var Product = Coffe.Products.FirstOrDefault(x=>x.IDProduct == txtPID.Text);
                if (Product!=null)
                {
                    Product.IDProduct = txtPID.Text;
                    Product.ProductName = txtPname.Text;
                    Product.IDType = cbPSpecies.SelectedValue.ToString();
                    if (Regex.Match(txtPPrice.Text, @"^[1-9]+([0-9]{1,5})$").Success)
                    {
                        Product.Price = Convert.ToInt32(txtPPrice.Text);
                    }
                    Product.Size = cbPsize.SelectedValue.ToString();
                    Coffe.SaveChanges();
                    DisplayProduct();
                    MessageBox.Show("Nếu sai cú pháp hoặc có giá trị để trống mọi giá trị bạn sửa sẽ không được thay đổi", "Thông báo",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    var pro = new Product();
                    if (txtPID.Text == null&& txtPname.Text == null&&txtPPrice.Text ==null)
                    {
                        pro.IDProduct = txtPID.Text;
                        pro.ProductName = txtPname.Text;
                        pro.IDType = cbPSpecies.SelectedValue.ToString();
                        if (Regex.Match(txtPPrice.Text, @"^[1-9]+([0-9]{1,5})$").Success)
                        {
                            pro.Price = Convert.ToInt32(txtPPrice.Text);
                        }
                        pro.Size = cbPsize.SelectedValue.ToString();
                        Coffe.Products.Add(pro);
                        Coffe.SaveChanges();
                    }
                    
                    DisplayProduct();
                    MessageBox.Show("Nếu sai cú pháp hoặc có giá trị để trống mọi giá trị bạn sửa sẽ không được thay đổi", "Thông báo",
               MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Có Trường Còn Trống Hoặc Sai Dữ Liệu", "Thông báo",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void BtnPRepeat_Click(object sender, EventArgs e)
        {
            edit = true;
            txtPID.Text = "";
            txtPname.Text = "";
            txtPPrice.Text = "";
            btnPDelete.Enabled = false;
            btnPUpdate.Enabled = false;
            txtPID.ReadOnly = false;
            btnPInsert.Enabled = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            edit = true;
            txtId.Text = "";
            TxtName.Text = "";
            btnUpdate.Enabled = false;
            txtId.ReadOnly = false;
        }

        private void btnDelete_Click_1(object sender, EventArgs e)
        {
            if (dgvProType.CurrentRow != null)
            {
                if ((MessageBox.Show("Bạn có muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
                {
                    var productT = Coffe.ProductTypes.FirstOrDefault(x => x.IDType == txtId.Text);
                    if (productT != null)
                    {
                        try
                        {
                            Coffe.ProductTypes.Remove(productT);
                            Coffe.SaveChanges();
                            DisplayProductType();
                        }
                        catch (Exception ex)
                        {

                            MessageBox.Show("Có Đơn Hàng Của Loại Sản Phẩm Này", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
