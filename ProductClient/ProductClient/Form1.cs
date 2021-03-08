using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProductLibrary;
using System.Data.SqlClient;

namespace ProductClient
{
    public partial class frmClient : Form
    {
        
        public frmClient()
        {
            InitializeComponent();
        }
        string ConnectionString = "server=localhost,1433;database=SaleDB;uid=sa;pwd=01256230";
        SqlDataAdapter adapter;
        DataTable ProductTable;
        ProductDB DB = new ProductDB();

        public void LoadProduct()
        {
            SqlConnection connection = new SqlConnection(ConnectionString);
            string SQL = "SELECT id,name,quantity,price FROM Product";
            SqlCommand command = new SqlCommand(SQL, connection);
            adapter = new SqlDataAdapter(command);
            ProductTable = new DataTable();
            adapter.Fill(ProductTable);
            dgvProduct.DataSource = ProductTable;
            txtID.DataBindings.Clear();
            txtName.DataBindings.Clear();
            txtPrice.DataBindings.Clear();
            txtQuantity.DataBindings.Clear();
            txtID.DataBindings.Add("Text", ProductTable, "id");
            txtName.DataBindings.Add("Text", ProductTable, "name");
            txtPrice.DataBindings.Add("Text", ProductTable, "price");
            txtQuantity.DataBindings.Add("Text", ProductTable, "quantity");
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            LoadProduct();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

        }
    }
}
