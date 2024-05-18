using ClosedXML.Excel;
using Microsoft.Office.Interop.Excel;
using QuanLyKhachSanATD.DAL;
using System.Data;
using System.Windows.Forms;
using DataTable = System.Data.DataTable;


namespace QuanLyKhachSanATD.GUI
{
    public partial class DoanhThu : Form
    {
        ConnectionDB sun = new ConnectionDB();
        string query = "";
        string fromDate;
        string toDate;
        public DoanhThu()
        {
            InitializeComponent();
        }

        private void DoanhThu_Load(object sender, EventArgs e)
        {
            dtgdt.RowHeadersVisible = false;
            query = "Select cname as 'Customer Name',maDN as 'Id',checkin as 'Check in',chekout as 'Check out',roomid as 'Room Number',allcost as 'Paid' from DatPhong where checkout = 'Yes'";
            DataSet ds = sun.getData(query);
            dtgdt.DataSource = ds.Tables[0];
        }

        private void ExportBTN_Click(object sender, EventArgs e)
        {
            // Create a DataTable from the DataGridView data
            DataTable dt = new DataTable();
            foreach (DataGridViewColumn column in dtgdt.Columns)
            {
                dt.Columns.Add(column.HeaderText);
            }
            foreach (DataGridViewRow row in dtgdt.Rows)
            {
                DataRow dr = dt.NewRow();
                for (int i = 0; i < dtgdt.Columns.Count; i++)
                {
                    dr[i] = row.Cells[i].Value;
                }
                dt.Rows.Add(dr);
            }

            // Export the DataTable to an Excel file using ClosedXml
            using (var workbook = new XLWorkbook())
            {
                var worksheet = workbook.Worksheets.Add("Sheet1");
                worksheet.Cell(1, 1).InsertTable(dt);
                workbook.SaveAs("DoanhThu.xlsx");
            }

            MessageBox.Show("Xuất thành công check tại Debug file!");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            fromDate = dtpfrom.Text;
            toDate = dtpto.Text;
            MessageBox.Show(fromDate);
            dtgdt.RowHeadersVisible = false;
            string query2 = @"Select cname as 'Customer Name',maDN as 'Id',CONVERT(Varchar,checkin,103) as 'Check in',CONVERT(Varchar,chekout,103) as 'Check out',roomid as 'Room Number',allcost as 'Paid' from DatPhong where checkout = 'Yes' and chekout between '" + fromDate + "' and '" + toDate + "'";
            DataSet ds = sun.getData(query2);
            dtgdt.DataSource = ds.Tables[0];
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

}
