using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MAI_PHADARN
{
    public partial class Allinfo : DevExpress.XtraEditors.XtraForm
    {
        public Allinfo()
        {
            InitializeComponent();
        }


        private connection cd = new connection();

        private SqlCommand cmd = new SqlCommand();
        private SqlDataAdapter da = new SqlDataAdapter();
        private DataSet ds = new DataSet();

        private void Allinfo_Load(object sender, EventArgs e)
        {
            cd.connect();
            showdata();
        }
        private void showdata()
        {
            try
            {
                da = new SqlDataAdapter("Select * from Tb_maiphadarn", cd.conn);
                da.Fill(ds);
                ds.Tables.Clear();
                da.Fill(ds);
                gridControl1.DataSource = ds.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}