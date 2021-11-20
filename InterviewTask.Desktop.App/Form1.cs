using InterviewTask.BLL.Manager;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InterviewTask.Desktop.App
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            LoadRegionCombobox();
        }

        private void LoadMethodCombobox()
        {
            InvoiceSetup setup = new InvoiceSetup();
            var regionId=this.comboBox_Region.SelectedValue as int?;
            var invoiceSetupId = setup.GetInvoiceMethod(regionId);
            var MethodList=setup.GetInvoiceSetup();
            this.comboBox_InvoiceNoMethod.DisplayMember = "InvoiceNoCreationMethod";
            this.comboBox_InvoiceNoMethod.ValueMember = "InvoiceSetupID";
            this.comboBox_InvoiceNoMethod.DataSource = MethodList;
           // if (invoiceSetupId != -1)
            {
                this.comboBox_InvoiceNoMethod.SelectedValue = invoiceSetupId;
            }

            //throw new NotImplementedException();
        }

        private void LoadRegionCombobox()
        {
            InvoiceSetup setup = new InvoiceSetup();
            var RegionList = setup.GetRegion();
            this.comboBox_Region.DisplayMember = "RegionDescription";
            this.comboBox_Region.ValueMember = "RegionID";
            this.comboBox_Region.DataSource = RegionList;

            //throw new NotImplementedException();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var method = this.comboBox_InvoiceNoMethod.SelectedValue.ToString();
            var region = this.comboBox_Region.SelectedValue;
            InvoiceSetup setupObj = new InvoiceSetup();
            setupObj.SetInvoiceMothod(int.Parse(method), region as int?);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadMethodCombobox();
        }
    }
}
