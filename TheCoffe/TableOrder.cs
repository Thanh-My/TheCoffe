using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TheCoffe.Model;

namespace TheCoffe
{
    public partial class TableOrder : Form
    {
        TheCoffeeEntities coffe = new TheCoffeeEntities();

        public TableOrder()
        {
            InitializeComponent();
            Load();
        }
        private void Load()
        {

            LoadCategory();
            LoadNultable();
            LoadSize();
            //LoadProduct();
            loadData();
            DateTime now = DateTime.Now;
            lblTime.Text = now.ToString("dd'/'MM'/'yyyy");
            LoadEmp();

        }
        private void loadData()
        {

            var soBan = from n in coffe.Orders
                        select n;
            int num = soBan.Count();

            int basex = panel1.Location.X;
            int basey = panel1.Location.Y;

            int dem = 0;
            for (int i = 0; i < num; i++)
            {
                Button b = new Button();
                b.Left = basex;
                b.Top = basey;
                basex += 110;
                b.Width = 100;
                b.Height = 100;
                b.Name = String.Format("btnDriver{0}", i + 1);
                b.Text = String.Format("Bàn {0}", i + 1);
                dem++;
                b.Click += new EventHandler(b_Click);
                panel1.Controls.Add(b);
                if (dem % 3 == 0)
                {
                    basey += 110;
                    basex -= 110;
                    basex = panel1.Location.X;
                }
                int Id = i + 1;
                var ban = coffe.Orders.FirstOrDefault(x => x.IDOrder == Id);
                //var ban = coffe.orders.firstordefault(x => x.id.equals(id);
                if (ban.status==true)
                {
                    b.BackColor = Color.LightSkyBlue;
                }
                //else if (dgvOrder.Rows[0].Cells[0].Value.ToString())
                //{

                //}
                else
                {
                    b.BackColor = Color.LightGray;
                }

            }
        }

        private void b_Click(object sender, EventArgs e)
        {

            int id = Int32.Parse(sender.ToString().Substring(38,2), NumberStyles.AllowLeadingWhite);
            if (sender.ToString().Length >40)
            {
                id = Int32.Parse(sender.ToString().Substring(38, 3), NumberStyles.AllowLeadingWhite);
            }
            Load_Table(id);

        }

        private void Load_Table(int i)
        {
            var ban = from order in coffe.Orders
                      join emp in coffe.Employees on order.emp equals emp.UsernameEmp 
                      where order.IDOrder == i
                      select new
                      {
                          Ten_Ban = order.IDOrder,
                          Trang_thai = (bool)order.status ? "Có người":"Vắng",
                          Nhan_Vien = emp.NameEmp

                      };
            dgvOrder.DataSource = ban.ToList();
            LoadOrderDetail(i);
            int idOrder = int.Parse(dgvOrder.Rows[0].Cells[0].Value.ToString());
            var table = coffe.Orders.FirstOrDefault(x => x.IDOrder == idOrder);
            if (table.status == false)
            {
                btnChanceTable.Enabled = false;
            }
            else
            {
                btnChanceTable.Enabled = true;
            }
            btnBill.Enabled = false;
            var Stable = coffe.OrderDetails.FirstOrDefault(x => x.IDOrder == idOrder);
            if (Stable!=null)
            {
                btnBill.Enabled = true;
            }
            int total = 0;
            for (int j = 0; j < dgvOrderDetail.Rows.Count; j++)
            {
                total += int.Parse(dgvOrderDetail.Rows[j].Cells[6].Value.ToString());
            }
            txtTotal.Text = total + "VND";
            
            var OrdD = coffe.OrderDetails.FirstOrDefault(x=>x.IdOrderDetail== idOrder & x.status == false);
            if (OrdD==null)
            {
                btnChangeStatus.Enabled = false;
            }
            else
            {
                btnChangeStatus.Enabled = true;
            }

        }
        private void LoadOrderDetail(int i)
        {
            
            var orderDetail = from ordetail in coffe.OrderDetails
                              join product in coffe.Products on ordetail.IDProduct equals product.IDProduct
                              where ordetail.IDOrder == i && ordetail.status == false
                              select new
                              {                                 
                                  Ten_Ban = ordetail.IDOrder,
                                  ID = ordetail.IDProduct,
                                  Ten_San_Pham = product.ProductName,
                                  Size = product.Size,
                                  Gia = product.Price,
                                  So_Luong = ordetail.Quantity,
                                  tong_gia = ordetail.price,
                                  time = ordetail.TimeOrder,
                                  Hd = ordetail.IdOrderDetail

                              };
            dgvOrderDetail.DataSource = orderDetail.ToList();
        }
        private void LoadEmp()
        {
            var emp = from Emp in coffe.Employees
                      select new
                      {
                          id = Emp.UsernameEmp,
                          name = Emp.NameEmp
                      };
            cbEmp.DataSource = emp.ToList();
            cbEmp.ValueMember = "id";
            cbEmp.DisplayMember = "name";
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }
        private void LoadNultable()
        {
            var table = from t in coffe.Orders
                        where t.status == false
                        select new
                        {
                            id = t.IDOrder,
                            name = t.IDOrder
                        };
            cbNullTable.DataSource = table.ToList();
            cbNullTable.ValueMember = "id";
            cbNullTable.DisplayMember = "name";
        }
        private void LoadCategory()
        {
            var Cat = from cat in coffe.ProductTypes
                              select new
                              {
                                  IDType = cat.IDType,
                                  typeName = cat.TypeName,
                              };
            cbCat.DataSource = Cat.ToList();
            cbCat.DisplayMember = "typeName";
            cbCat.ValueMember = "IDType";
           

        }

        private void LoadSize()
        {
            if (cbSize.Items.Count == 0)
            {
                var Size = from pro in coffe.Products
                           where pro.IDType == cbCat.SelectedValue
                           select new
                           {
                               size = pro.Size
                           };

                cbSize.DataSource = Size.ToList();
                cbSize.ValueMember = "size";


            }
            var Pro = from pro in coffe.Products
                      where pro.IDType == cbCat.SelectedValue && pro.Size == cbSize.SelectedValue
                      select new
                      {
                          IDPro = pro.IDProduct,
                          ProductName = pro.ProductName

                      };
            cBProduct.DataSource = Pro.ToList();
            //cbPro.DisplayMember = "ProductName";
            cBProduct.ValueMember = "IDPro";
            cBProduct.DisplayMember = "ProductName";

        }
        //private void LoadProduct()
        //{
        //        var Pro = from pro in coffe.Products
        //                  where pro.IDType == cbCat.SelectedValue && pro.Size == cbSize.SelectedValue
        //                  select new
        //                  {
        //                      IDPro = pro.IDProduct,
        //                      ProductName = pro.ProductName

        //                  };
        //        cBProduct.DataSource = Pro.ToList();
        //        //cbPro.DisplayMember = "ProductName";
        //        cBProduct.ValueMember = "IDPro";
        //        cBProduct.DisplayMember = "ProductName";
            
 

        //}
        private void cbCat_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void btnChanceTable_Click(object sender, EventArgs e)
        {
            //try
            //{
                int idOrder = int.Parse(dgvOrder.Rows[0].Cells[0].Value.ToString());
                var table = coffe.Orders.FirstOrDefault(x => x.IDOrder == idOrder);

                table.status = false;
                coffe.SaveChanges();
                 int nTable = int.Parse(cbNullTable.Text);
                //if (cbNullTable.SelectedItem.ToString().Length < 20)
                //{
                //    nTable = int.Parse(cbNullTable.SelectedItem.ToString().Substring(7, 1));
                //}
                var tableC = coffe.Orders.FirstOrDefault(x => x.IDOrder == nTable);
                tableC.status = true;
                coffe.SaveChanges();
                //messagebox.show(dgvorderdetail.rows.count+ "", "thông báo",
                //       messageboxbuttons.ok, messageboxicon.information);
                for (int i = 0; i < dgvOrderDetail.Rows.Count; i++)
                {
                    int id = int.Parse(dgvOrderDetail.Rows[i].Cells[8].Value.ToString());
                    var a = coffe.OrderDetails.FirstOrDefault(x => x.IdOrderDetail == id);
                    a.IDOrder = nTable;
                    coffe.SaveChanges();
                }
                this.Controls.Clear();
                this.InitializeComponent();
               
            //}
            //catch (Exception ex)
            //{

            //    MessageBox.Show(ex +"", "thông báo",
            //       MessageBoxButtons.OK, MessageBoxIcon.Information);
            //}

            loadData();
        }

        private void cbNullTable_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnAddPro_Click(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            int idOrder = int.Parse(dgvOrder.Rows[0].Cells[0].Value.ToString());
            var table = coffe.Orders.FirstOrDefault(x => x.IDOrder == idOrder);
            table.status = true;
            coffe.SaveChanges();
            var Pro = coffe.Products.FirstOrDefault(x => x.IDType == cbCat.SelectedValue && x.Size == cbSize.Text);
            var AddPro = new OrderDetail();
            AddPro.IDOrder = idOrder;
            AddPro.IDProduct = Pro.IDProduct;
            AddPro.Quantity = (int)nUDQuantity.Value;
            AddPro.price = (int)(nUDQuantity.Value * Pro.Price);
            AddPro.TimeOrder = now;
            AddPro.status = false;
            var OrderDetail = coffe.OrderDetails.FirstOrDefault(x => x.IDOrder == idOrder && x.IDProduct == AddPro.IDProduct && x.status == false);
            if (OrderDetail == null)
            {
                coffe.OrderDetails.Add(AddPro);
                coffe.SaveChanges();
            }
            else
            {
                OrderDetail.Quantity += AddPro.Quantity;
                OrderDetail.price += AddPro.price;
                OrderDetail.TimeOrder = now;
                OrderDetail.status = false;
                coffe.SaveChanges();
            }
            this.Controls.Clear();
            this.InitializeComponent();
            Load();
            //MessageBox.Show(Pro.IDProduct.ToString() + "", "thông báo",
            //MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void cbPro_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadCategory();
        }

        private void btnChangeStatus_Click(object sender, EventArgs e)
        {
            try
            {
                int idOrder = int.Parse(dgvOrder.Rows[0].Cells[0].Value.ToString());
                
                var table = coffe.Orders.FirstOrDefault(x => x.IDOrder == idOrder);
                //string dataDetail = dgvOrderDetail.DataSource.ToString();
                var Stable = coffe.OrderDetails.FirstOrDefault(x => x.IDOrder == idOrder && x.status == true);
                
                //Stable.status = true;
                //coffe.SaveChanges();
                //if (Stable==null)
                //{
                    if (table.status==false)
                    {
                        table.status = true;
                    }
                    else
                    {
                        table.status = false;
                    }
                //}
                coffe.SaveChanges();
                this.Controls.Clear();
                this.InitializeComponent();
                loadData();
                Load();
                

            }
            catch (Exception)
            {

                MessageBox.Show("Bàn này có đơn chưa thanh toán", "thông báo",
           MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }

        private void cBProduct_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnBill_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime now = DateTime.Now; 
                int idOrder = int.Parse(dgvOrder.Rows[0].Cells[0].Value.ToString());
                string emp = dgvOrder.Rows[0].Cells[2].Value.ToString();
                int row = dgvOrderDetail.Rows.Count;
                int totalPrice = 0;
                int line = dgvOrderDetail.Rows.Count;
                for (int i = 0; i < row; i++)
                {
                    int Price = int.Parse(dgvOrderDetail.Rows[i].Cells[6].Value.ToString());
                    totalPrice += Price;
                }

                string table = idOrder + "-" + now.ToString("MMddyyyyHHmmss") + ".txt";
                string path = @"C:\Users\hdwhy\Desktop\New folder\TheCoffe\TheCoffe\FIle\";
                string Pfile = path +"HD"+ table;
                FileStream f = null;
                if (!File.Exists(Pfile))
                {
                    File.Create(Pfile).Dispose();


                    using (TextWriter bw = new StreamWriter(Pfile, true))
                    {
                        bw.Write("\t\t\tTHE COFFEE\r\n\r\n");
                        bw.Write("\t\tDD4 Thái Khê Cấn Hữu Quốc Oai Hà Nội\r\n");
                        bw.Write("\t\t\tSĐT: 0373384874\r\n\r\n");
                        bw.Write("\t\t\tHÓA ĐƠN BÁN HÀNG\r\n\r\n");
                        bw.Write("Mã hóa đơn: " + idOrder + "\r\n");
                        bw.Write("Nhân Viên: " + emp + "\r\n");
                        bw.Write("Thời gian: " + now + "\r\n");
                        bw.Write("------------------------------------------------------------\r\n");
                        //Ghi sản phẩm
                        int quantotal = 0;
                        bw.Write("----------------------------------------------------------------------\r\n");
                        bw.Write("Mã HĐ\t\t\tTên SP\t\t\tĐơn giá (VNĐ)\t\tLoại SP\tSố lượng (ly)\r\n");
                        bw.Write("---------------------------------------------------------------------------\r\n");

                        
                        for (int i = 0; i < line; i++)
                        {
                            String s1 = idOrder + "_" + now.ToString("MMddyyyyHHmmss");
                            String s2 = (String)dgvOrderDetail.Rows[i].Cells[2].Value.ToString();
                            String s3 = (String)dgvOrderDetail.Rows[i].Cells[4].Value.ToString();
                            String s4 = (String)dgvOrderDetail.Rows[i].Cells[3].Value.ToString();
                            String s5 = (String)dgvOrderDetail.Rows[i].Cells[5].Value.ToString();
                            bw.Write(s1 + "\t" + s2 + "\t" + s3 + "\t\t\t" + s4 + "\t" + s5 + "\r\n");
                        }
                        bw.Write("----------------------------------------------------------\r\n");
                        bw.Write("------------------------------------------------------------\r\n");
                        bw.Write("Thành tiền:\t\t\t" + totalPrice + " VNĐ\r\n");
                        bw.Write("--------------------------------------------\r\n");
                        bw.Write("Mật khẩu Wifi: motdentam\r\n");
                        bw.Write("---------------------CÁM ƠN QUÝ KHÁCH!----------------------");
                        bw.Close();
                    };
                }
                for (int i = 0; i < line; i++)
                {
                    string id = dgvOrderDetail.Rows[i].Cells[1].Value.ToString();
                    int idDetail = int.Parse(dgvOrderDetail.Rows[i].Cells[8].Value.ToString());
                    var Orderdetail = coffe.OrderDetails.FirstOrDefault(x => x.IdOrderDetail == idDetail);
                    Orderdetail.status = true;
                    coffe.SaveChanges();
                }
                var order = coffe.Orders.FirstOrDefault(x=>x.IDOrder == idOrder);
                order.status = false;
                
                coffe.SaveChanges();
                this.Controls.Clear();
                this.InitializeComponent();
                loadData();
                Load();
        }
            catch (Exception ex)
            {

                MessageBox.Show(ex +"", "thông báo",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

}

        private void btnchangeEmp_Click(object sender, EventArgs e)
        {
            int idOrder = int.Parse(dgvOrder.Rows[0].Cells[0].Value.ToString());
            var Order = coffe.Orders.FirstOrDefault(x => x.IDOrder == idOrder);
            Order.emp = cbEmp.SelectedValue.ToString();
            coffe.SaveChanges();
            this.Controls.Clear();
            this.InitializeComponent();
            loadData();
            Load();
        }
    }
}
