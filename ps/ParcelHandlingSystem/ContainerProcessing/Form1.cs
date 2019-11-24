using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ParcelHandlingSystem;

namespace ContainerProcessing
{
    public partial class Form1 : Form
    {
        ParcelProcessor pp;
        DataRow transfer;
        public Form1()
        {
            InitializeComponent();
        }

        private void ProcessContainer_Click(object sender, EventArgs e)
        {
            try
            {
                FillGrids();
                ParcelSystem.SelectedTab = Insurance;
            }
            catch (Exception ex)
            {
                MessageBox.Show("There is some problem please fix it {}", ex.Message);
            }
        }

        private void InsuranceGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        public void FillGrids()
        {
            pp = new ParcelProcessor();
            pp.ReadXML();
            FillInsuranceGrid();
            FillMailGrid();
            FillRegularGrid();
            FillHeavyGrid();
        }
        public void FillInsuranceGrid()
        {
            InsuranceGridView.DataSource = ParcelProcessor.tblInsurance;
        }
        public void FillMailGrid()
        {
            MailGridView.DataSource = ParcelProcessor.tblMail;
        }
        public void FillRegularGrid()
        {
            RegularGridView.DataSource = ParcelProcessor.tblRegular;
        }
        public void FillHeavyGrid()
        {
            HeavyGridView.DataSource = ParcelProcessor.tblHeavy;
        }

        public void SignedOff_Click(object sender, EventArgs e)
        {
            //DataTable selectedRows = new DataTable();
            if (InsuranceGridView.Columns.Contains("SignOff"))
            {
                //foreach (DataRow dr in ParcelProcessor.tblInsurance.Rows)
                for (int i = 0; i < ParcelProcessor.tblInsurance.Rows.Count; i++)
                {
                    DataRow dr = ParcelProcessor.tblInsurance.Rows[i];
                    if (dr["SignOff"] != DBNull.Value)
                    {
                        if (Convert.ToBoolean(dr["SignOff"].ToString()) == true)
                        {
                            if (Convert.ToDouble(dr["Weight"]) <= 1)
                            {
                                transfer = ParcelProcessor.tblMail.NewRow();
                                transfer["Sender Name"] = dr["Sender Name"];
                                transfer["Sender Address"] = dr["Sender Address"];
                                transfer["Receipint Name"] = dr["Receipint Name"];
                                transfer["Receipint Address"] = dr["Receipint Address"];
                                transfer["Weight"] = dr["Weight"];
                                transfer["Value"] = dr["Value"];
                                ParcelProcessor.tblMail.Rows.Add(transfer);
                                dr.Delete();
                                ParcelSystem.SelectedTab = Mail;
                            }
                            else if (Convert.ToDouble(dr["Weight"]) > 1 && Convert.ToDouble(dr["Weight"]) <= 10)
                            {
                                transfer = ParcelProcessor.tblRegular.NewRow();
                                transfer["Sender Name"] = dr["Sender Name"];
                                transfer["Sender Address"] = dr["Sender Address"];
                                transfer["Receipint Name"] = dr["Receipint Name"];
                                transfer["Receipint Address"] = dr["Receipint Address"];
                                transfer["Weight"] = dr["Weight"];
                                transfer["Value"] = dr["Value"];
                                ParcelProcessor.tblRegular.Rows.Add(transfer);
                                dr.Delete();
                                ParcelSystem.SelectedTab = Regular;
                            }
                            else
                            {
                                transfer = ParcelProcessor.tblHeavy.NewRow();
                                transfer["Sender Name"] = dr["Sender Name"];
                                transfer["Sender Address"] = dr["Sender Address"];
                                transfer["Receipint Name"] = dr["Receipint Name"];
                                transfer["Receipint Address"] = dr["Receipint Address"];
                                transfer["Weight"] = dr["Weight"];
                                transfer["Value"] = dr["Value"];
                                ParcelProcessor.tblHeavy.Rows.Add(transfer);
                                dr.Delete();
                                ParcelSystem.SelectedTab = Heavy;
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please select rows to SignOff");
                    }
                    //ParcelProcessor.tblInsurance.Rows.dele
                    //dr.Delete();
                }
            }
        }
    }
}
