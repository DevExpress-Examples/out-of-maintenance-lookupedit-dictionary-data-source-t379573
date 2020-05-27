using DevExpress.XtraEditors.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LookUpEdit_Dictionary {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {

            gridControl1.DataSource = new List<Product> {
                new Product(){ ProductName="Chang", CategoryID =  0  },
                new Product(){ ProductName="Ipoh Coffee", CategoryID =  0  },
                new Product(){ ProductName="Ravioli Angelo", CategoryID = 1  },
                new Product(){ ProductName="Filo Mix", CategoryID = 1  },
                new Product(){ ProductName="Tunnbröd", CategoryID  = 1  },
                new Product(){ ProductName="Konbu", CategoryID  = 2  },
                new Product(){ ProductName="Boston Crab Meat", CategoryID  = 2  }
            };

            Dictionary<int, string> Categories = new Dictionary<int, string>();
            Categories.Add(0, "Beverages");
            Categories.Add(1, "Grains");
            Categories.Add(2, "Seafood");

            RepositoryItemLookUpEdit riLookUp = new RepositoryItemLookUpEdit();
            riLookUp.DataSource = Categories;
            // Change the column caption.
            riLookUp.PopulateColumns();
            riLookUp.Columns["Value"].Caption = "Name";

            gridControl1.RepositoryItems.Add(riLookUp);

            gridView1.Columns["CategoryID"].ColumnEdit = riLookUp;
        }
    }

    public class Product {
        public int CategoryID { get; set; }
        public string ProductName { get; set; }
    }

    
}
