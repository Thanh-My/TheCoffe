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

namespace TheCoffe.RP
{
    public partial class RPForm : Form
    {
        TheCoffeeEntities coffe = new TheCoffeeEntities();
        public RPForm()
        {
            InitializeComponent();
        }

        private void ReportViewer_Load(object sender, EventArgs e)
        {
            var orderDetail = from ordetail in coffe.OrderDetails
                              join product in coffe.Products on ordetail.IDProduct equals product.IDProduct
                              where ordetail.status == true
                              select new Bill
                              {
                                  Table = (int)ordetail.IDOrder,
                                  Product = product.ProductName,
                                  ProductType = product.Size,
                                  Quantity = ordetail.Quantity,
                                  Price = (int)product.Price,
                                  Total = ordetail.Quantity,
                                  TimeOrder = (DateTime)ordetail.TimeOrder

                              };
            BillReport1 r = new BillReport1();
            r.SetDataSource(orderDetail.ToList());
            ReportViewer.ReportSource = r;
            ReportViewer.Show();
        }
    }
}
