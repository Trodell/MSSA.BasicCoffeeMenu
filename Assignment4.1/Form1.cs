using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment4._1
{
    public partial class Form1 : Form
    {
        List<Coffee> CoffeeList;
        public Form1()
        {
            InitializeComponent();
        }
        void RefreshData()
        {
            txtCustName.Clear();
            txtNumEsp.Clear();
            cbToGo.Checked = false;
            checkIce.Checked = false;
            comboCoffeeType.SelectedIndex = 0;
            comboCupSize.SelectedIndex = 0;
            comboMilk.SelectedIndex = 0;
            CustGrid.DataSource = null;
            CustGrid.DataSource = CoffeeList;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox.Visible = false;
            CoffeeList = new List<Coffee>();
            CoffeeList.Add(new Coffee() { CustomerName="Tyler", CupSize=CupSize.Medium, MilkType=Milk.Oat, Type=CoffeeType.Latte, ToGo=false, EspressoShots=2, Iced=true});
            CoffeeList.Add(new Coffee() { CustomerName = "John", CupSize = CupSize.Large, MilkType = Milk.Almond,Type = CoffeeType.Americano, ToGo = false, EspressoShots = 4, Iced = false });
            CoffeeList.Add(new Coffee() { CustomerName = "Bob", CupSize = CupSize.Small, MilkType = Milk.None, Type = CoffeeType.Irish, ToGo = true, EspressoShots = 2, Iced = false });
            CustGrid.DataSource = CoffeeList;
  

            comboCoffeeType.DataSource = Enum.GetValues(typeof(CoffeeType));
            comboCupSize.DataSource = Enum.GetValues(typeof(CupSize));
            comboMilk.DataSource = Enum.GetValues(typeof(Milk));


            

        }

        private void comboCupSize_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtCustName.Text != String.Empty && comboCoffeeType.SelectedIndex != 0 && comboCupSize.SelectedIndex != 0 && comboMilk.SelectedIndex != 0 && txtNumEsp.Text != String.Empty)
            {


                Coffee newcust = new Coffee();
                newcust.CustomerName = txtCustName.Text;
                newcust.CupSize = (CupSize)comboCupSize.SelectedIndex;
                newcust.ToGo = cbToGo.Checked;
                newcust.Type = (CoffeeType)comboCoffeeType.SelectedIndex;
                newcust.EspressoShots = int.Parse(txtNumEsp.Text);
                newcust.Iced = checkIce.Checked;
                newcust.MilkType = (Milk)comboMilk.SelectedIndex;
                CoffeeList.Add(newcust);
                MessageBox.Show("Order Placed!");
                RefreshData();
                pictureBox.Visible = true;
            }
            else
            {
                MessageBox.Show("Please ensure all information is fill out","Review Data");
            }
            
           
        }

        private void txtNumEsp_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            CoffeeList.RemoveAt(CustGrid.CurrentRow.Index);
            RefreshData();
        }



        #region MyRegion
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void comboCoffeeType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkIce_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void cbToGo_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void lblMilk_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void CustGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void lblName_Click(object sender, EventArgs e)
        {

        }

        private void txtCustName_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblToGo_Click(object sender, EventArgs e)
        {

        }

        private void lblIced_Click(object sender, EventArgs e)
        {

        }

        private void lblSize_Click(object sender, EventArgs e)
        {

        } 
        #endregion

        private void txtCustName_Validating(object sender, CancelEventArgs e)
        {
            foreach (var customer in CoffeeList)
            {
                if (txtCustName.Text == customer.CustomerName.ToString())
                {
                    MessageBox.Show("Name on order has already been placed", "Enter different name!");
                    e.Cancel = true;
                    txtCustName.Clear();
                }
            }
        }

        private void txtNumEsp_Validating(object sender, CancelEventArgs e)
        {
            if (!int.TryParse(txtNumEsp.Text, out int num)) {
                MessageBox.Show("Please enter how many shots of espresso");
                e.Cancel = true;
                txtNumEsp.Clear();

            }
            if(int.Parse(txtNumEsp.Text) >5 || int.Parse(txtNumEsp.Text)<0)
            {
                MessageBox.Show("Then number of shots can only be between 0-5!");
                e.Cancel = true;
                txtNumEsp.Clear();
            }

        }
    }
}
