﻿using DevExpress.XtraEditors;
using DevExpress.XtraReports.UI;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace MAI_PHADARN
{
    public partial class FrmMain : DevExpress.XtraEditors.XtraForm
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private connection cd = new connection();
        private SqlCommand cmd = new SqlCommand();
        private SqlDataAdapter da = new SqlDataAdapter();
        private DataSet ds = new DataSet();

        // private int mi_id;
        private int moneykip = 0;

        private int summai = 0;
        private int moneybat = 0;
        private int moneydola = 0;

        private void FrmMain_Load(object sender, EventArgs e)
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
                gridView1.AddNewRow();
                gridView1.MovePrev();
                txtName.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private bool checkeddate()
        {
            if (txtName.Text == string.Empty)
            {
                MessageBox.Show("ກະລຸນາພີມ ຊື່ນາມສະກຸນກອນ", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }else if(txtdate.Text == string.Empty)
            {
                MessageBox.Show("ກະລຸນາພີມ ກວດເບີງວັນທີ່ເດືອນ-ປີ", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        //เมธอดตรวจสอบชื่อซ้ำในฐานข้อมูล

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (checkeddate())
                {
                    // กำหนดคำสั่ง SQL query สำหรับเช็ค username ใน database
                    SqlCommand command = new SqlCommand($"SELECT count(*) FROM Tb_maiphadarn WHERE mi_name=@mi_name", cd.conn);
                    // เพิ่ม parameter สำหรับ username
                    command.Parameters.AddWithValue("@mi_name", txtName.Text);
                    // ถ้ามี username นี้อยู่ใน database แล้วให้ยกเลิกการ insert
                    int count = (int)command.ExecuteScalar();
                    // ถ้ามี username นี้อยู่ใน database แล้วให้ยกเลิกการ insert
                    if (count > 0)
                    {
                        DialogResult title = MessageBox.Show("ຊື່ນີ່ມີໃນລະບົບແລ້ວ ທ່ານຕ້ອງການບັນທືກອີກບໍ?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (title == DialogResult.Yes)
                        {
                            insertdata();
                        }
                    }
                    else
                    {
                        insertdata();
                    }
                    showdata();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void insertdata()
        {
            // กำหนดคำสั่ง SQL query สำหรับเช็ค insert  ใน database
            cmd = new SqlCommand("INSERT INTO Tb_maiphadarn VALUES(@Date,@Name,@Moneykip,@Moneybat,@Moneydola,@money,@countmai)", cd.conn);
           // DateTime txtdate = dateEdit1.DateTime;

            SqlParameter parameterDate = new SqlParameter("@Date", SqlDbType.DateTime);
            parameterDate.Value = txtdate.Text;

            SqlParameter parameterName = new SqlParameter("@Name", SqlDbType.NVarChar);
            parameterName.Value = txtName.Text;

            SqlParameter parameterMoneykip = new SqlParameter("@Moneykip", SqlDbType.Int);
            parameterMoneykip.Value = moneykip;

            SqlParameter parameterMoneybat = new SqlParameter("@Moneybat", SqlDbType.Int);
            parameterMoneybat.Value = moneybat;

            SqlParameter parameterMoneydola = new SqlParameter("@Moneydola", SqlDbType.Int);
            parameterMoneydola.Value = moneydola;

            SqlParameter parameterCountmai = new SqlParameter("@countmai", SqlDbType.Int);
            parameterCountmai.Value = summai;

            SqlParameter parameterMoney = new SqlParameter("@money", SqlDbType.NVarChar);
            parameterMoney.Value = SwitchMoneyCash.Checked ? "ເງິນໂອນ" : "ເງິນສົດ";

            cmd.Parameters.Add(parameterDate);
            cmd.Parameters.Add(parameterName);
            cmd.Parameters.Add(parameterMoneykip);
            cmd.Parameters.Add(parameterMoneybat);
            cmd.Parameters.Add(parameterMoneydola);
            cmd.Parameters.Add(parameterCountmai);
            cmd.Parameters.Add(parameterMoney);

            if (cmd.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Save date successfully");
            }
            else
            {
                MessageBox.Show("Save date Error");
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                if (String.IsNullOrEmpty(txtName.Text))
                {
                    MessageBox.Show("ກະລຸນາເລືອກລາຍການທີ່ຕ້ອງການແກ້ໄຂ");
                    gridControl1.Focus();
                    return;
                }
                cmd = new SqlCommand("UPDATE Tb_maiphadarn SET mi_data=@Date,mi_name=@Name,mi_moneykip=@Moneykip,mi_moneybat=@Moneybat,mi_moneydola=@Moneydola,mi_money=@money,mi_countmai=@countmai where mi_id=@id", cd.conn);

                SqlParameter parameterId = new SqlParameter("@id", SqlDbType.Int);
                parameterId.Value = txtmi_id.Text;
               // cmd.Parameters.AddWithValue("@id", txtmi_id.Text);
                SqlParameter parameterDate = new SqlParameter("@Date", SqlDbType.DateTime);
                parameterDate.Value = txtdate.Text;

                SqlParameter parameterName = new SqlParameter("@Name", SqlDbType.NVarChar);
                parameterName.Value = txtName.Text;

                SqlParameter parameterMoneykip = new SqlParameter("@Moneykip", SqlDbType.Int);
                parameterMoneykip.Value = moneykip;

                SqlParameter parameterMoneybat = new SqlParameter("@Moneybat", SqlDbType.Int);
                parameterMoneybat.Value = moneybat;

                SqlParameter parameterMoneydola = new SqlParameter("@Moneydola", SqlDbType.Int);
                parameterMoneydola.Value = moneydola;

                SqlParameter parameterCountmai = new SqlParameter("@countmai", SqlDbType.Int);
                parameterCountmai.Value = summai;

                SqlParameter parameterMoney = new SqlParameter("@money", SqlDbType.NVarChar);
                parameterMoney.Value = SwitchMoneyCash.Checked ? "ເງິນໂອນ" : "ເງິນສົດ";
                cmd.Parameters.Add(parameterId);
                cmd.Parameters.Add(parameterDate);
                cmd.Parameters.Add(parameterName);
                cmd.Parameters.Add(parameterMoneykip);
                cmd.Parameters.Add(parameterMoneybat);
                cmd.Parameters.Add(parameterMoneydola);
                cmd.Parameters.Add(parameterCountmai);
                cmd.Parameters.Add(parameterMoney);

                if (cmd.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Save date successfully");
                }
                else
                {
                    MessageBox.Show("Save date Error");
                }

                showdata();
                txtMoneykip.Text = "";
                txtMoneybat.Text = "";
                txtMoneydola.Text = "";
                txtMoneybat.Text = "";
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void gridControl1_DoubleClick(object sender, EventArgs e)
        {
            var mi_id = gridView1.GetFocusedRowCellValue("mi_id").ToString();
            var mi_date = gridView1.GetFocusedRowCellValue("mi_data").ToString();
            var mi_name = gridView1.GetFocusedRowCellValue("mi_name").ToString();
            var mi_kip = gridView1.GetFocusedRowCellValue("mi_moneykip").ToString();
            var mi_bat = gridView1.GetFocusedRowCellValue("mi_moneybat").ToString();
            var mi_dola = gridView1.GetFocusedRowCellValue("mi_moneydola").ToString();
            var mi_money = gridView1.GetFocusedRowCellValue("mi_money").ToString();
            txtmi_id.Text = mi_id;
            txtdate.Text = mi_date;
            txtName.Text = mi_name;
            txtMoneykip.Text = mi_kip;
            txtMoneybat.Text = mi_bat;
            txtMoneydola.Text = mi_dola;

            if (mi_money == "ເງິນໂອນ")
            {
                SwitchMoneyCash.Checked = true;
            }
            else
            {
                SwitchMoneyCash.Checked = false;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtName.Text == string.Empty || txtMoneykip.Text == string.Empty)
                {
                    MessageBox.Show("please select your date", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    DialogResult title = MessageBox.Show("Do you want to delete?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (title == DialogResult.Yes)
                    {
                        cmd = new SqlCommand("DELETE FROM Tb_maiphadarn  where mi_id=@id", cd.conn);
                        cmd.Parameters.AddWithValue("@id", txtmi_id.Text);

                        if (cmd.ExecuteNonQuery() == 1)
                        {
                            MessageBox.Show("Delete date successfully");
                        }
                        else
                        {
                            MessageBox.Show("Delete date Error");
                        }
                    }

                    refrestdate();
                    showdata();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void refrestdate()
        {
            txtmi_id.Reset();
            txtdate.ResetText();
            txtName.ResetText();
            txtMoneykip.ResetText();
            txtMoneydola.ResetText();
            txtMoneybat.ResetText();
            txtShowinfo_mai.ResetText();
            moneykip = 0;
            moneybat = 0;
            moneydola = 0;
            SwitchMoneyCash.Checked = false;
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            try
            {
                ReportMai rpt = new ReportMai();
                da = new SqlDataAdapter("Select * from Tb_maiphadarn", cd.conn);
                da.Fill(ds);
                ds.Tables.Clear();
                da.Fill(ds);
                gridControl1.DataSource = ds.Tables[0];
                rpt.ShowPreviewDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtMoneybat_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (char.IsDigit(e.KeyChar))
                {
                    string currentText = txtMoneybat.Text.Replace(",", "");
                    if (currentText.Length >= 12)
                    {
                        e.Handled = true;
                        return;
                    }
                    double number = double.Parse(currentText + e.KeyChar);
                    moneybat = Convert.ToInt32(Math.Round(number, 0));
                    if (moneybat >= 1000000000)
                    {
                        txtMoneybat.Text = "###,###,###";
                    }
                    else
                    {
                        txtMoneybat.Text = moneybat.ToString("N0");
                    }
                    txtMoneybat.SelectionStart = txtMoneybat.Text.Length;
                    e.Handled = true;
                    // txtMoneybat.Text = Number.ToString();
                }
                else if (e.KeyChar == (char)Keys.Back)
                {
                    string currentText = txtMoneybat.Text.Replace(",", "");
                    if (currentText.Length > 0)
                    {
                        currentText = currentText.Remove(currentText.Length - 1);
                    }
                    if (currentText.Length > 0 && currentText.LastIndexOf(".") == currentText.Length - 1)
                    {
                        currentText = currentText.Remove(currentText.Length - 1);
                    }
                    if (currentText.Length == 0)
                    {
                        txtMoneybat.Text = "0";
                    }
                    else
                    {
                        double number = double.Parse(currentText);
                        moneybat = Convert.ToInt32(Math.Round(number, 0));
                        txtMoneybat.Text = moneybat.ToString("N0");
                    }
                    txtMoneybat.SelectionStart = txtMoneybat.Text.Length;
                    e.Handled = true;
                }

                if (txtMoneybat.Text == string.Empty)
                {
                    // txtMoneybat.Text = "";
                    txtShowinfo_mai.ResetText();
                }
                else
                {
                    countmai();
                }

                if (e.KeyChar == (char)Keys.Enter)
                {
                    e.Handled = true; // ปิดเสียง "บิ๊" เมื่อกด Enter
                    if (!string.IsNullOrEmpty(txtMoneybat.Text))
                    {
                        txtMoneydola.Focus(); // เลื่อน focus ไปยัง txtpass
                        txtMoneydola.SelectAll(); // เลือกทั้งหมดใน txtpass เพื่อให้ผู้ใช้งานสามารถกรอกข้อมูลได้ง่ายๆ
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtMoneydola_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (char.IsDigit(e.KeyChar))
                {
                    string currentText = txtMoneydola.Text.Replace(",", "");
                    if (currentText.Length >= 12)
                    {
                        e.Handled = true;
                        return;
                    }
                    double number = double.Parse(currentText + e.KeyChar);
                    moneydola = Convert.ToInt32(Math.Round(number, 0));
                    if (moneydola >= 1000000000)
                    {
                        txtMoneydola.Text = "###,###,###";
                    }
                    else
                    {
                        txtMoneydola.Text = moneydola.ToString("N0");
                    }
                    txtMoneydola.SelectionStart = txtMoneydola.Text.Length;
                    e.Handled = true;

                    // txtShowinfo_mai.Text = moneykip.ToString();
                }
                else if (e.KeyChar == (char)Keys.Back)
                {
                    string currentText = txtMoneydola.Text.Replace(",", "");
                    if (currentText.Length > 0)
                    {
                        currentText = currentText.Remove(currentText.Length - 1);
                    }
                    if (currentText.Length > 0 && currentText.LastIndexOf(".") == currentText.Length - 1)
                    {
                        currentText = currentText.Remove(currentText.Length - 1);
                    }
                    if (currentText.Length == 0)
                    {
                        txtMoneydola.Text = "0";
                    }
                    else
                    {
                        double number = double.Parse(currentText);
                        moneydola = Convert.ToInt32(Math.Round(number, 0));
                        txtMoneydola.Text = moneydola.ToString("N0");
                    }
                    txtMoneydola.SelectionStart = txtMoneydola.Text.Length;
                    e.Handled = true;
                }

                if (txtMoneydola.Text == string.Empty)
                {
                    txtShowinfo_mai.ResetText();
                }
                else
                {
                    countmai();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtShowinfo_mai_EditValueChanged(object sender, EventArgs e)
        {
        }

        private void countmai()
        {
            try
            {
                if (txtMoneykip.Text == string.Empty)
                {
                    moneykip = 0;
                }
                else if (txtMoneybat.Text == string.Empty)
                {
                    moneybat = 0;
                }
                else if (txtMoneydola.Text == string.Empty)
                {
                    moneydola = 0;
                }

                int Ratbat = int.Parse(ratbat.Text);
                int pricemai = int.Parse(txtpricemai.Text);
                int Ratdola = int.Parse(ratdola.Text);

                int numberbat = (moneybat * Ratbat);
                int numberdola = moneydola * Ratdola;
                summai = moneykip + numberbat + numberdola;
                summai /= pricemai;

                txtShowinfo_mai.Text = summai.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnReview_Click(object sender, EventArgs e)
        {
            Allinfo all = new Allinfo();
            all.Show();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            refrestdate();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult title = MessageBox.Show("Do you want to Exit?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (title == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void ratbat_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (ratbat.Text == string.Empty)
            {
                txtShowinfo_mai.ResetText();
            }
            else
            {
                countmai();
            }
        }

        private void ratdola_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (ratdola.Text == string.Empty)
            {
                txtShowinfo_mai.ResetText();
            }
            else
            {
                countmai();
            }
        }

        private void txtpricemai_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtpricemai.Text == string.Empty)
            {
                txtShowinfo_mai.ResetText();
            }
            else
            {
                countmai();
            }
        }

      

        private void txtMoneykip_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (char.IsDigit(e.KeyChar))
                {
                    string currentText = txtMoneykip.Text.Replace(",", "");
                    if (currentText.Length >= 12)
                    {
                        e.Handled = true;
                        return;
                    }
                    double number = double.Parse(currentText + e.KeyChar);
                    moneykip = Convert.ToInt32(Math.Round(number, 0));
                    if (moneykip >= 1000000000)
                    {
                        txtMoneykip.Text = "###,###,###";
                    }
                    else
                    {
                        txtMoneykip.Text = moneykip.ToString("N0");
                    }
                    txtMoneykip.SelectionStart = txtMoneykip.Text.Length;
                    e.Handled = true;

                    // txtShowinfo_mai.Text = moneykip.ToString();
                }
                else if (e.KeyChar == (char)Keys.Back)
                {
                    string currentText = txtMoneykip.Text.Replace(",", "");
                    if (currentText.Length > 0)
                    {
                        currentText = currentText.Remove(currentText.Length - 1);
                    }
                    if (currentText.Length > 0 && currentText.LastIndexOf(".") == currentText.Length - 1)
                    {
                        currentText = currentText.Remove(currentText.Length - 1);
                    }
                    if (currentText.Length == 0)
                    {
                        txtMoneykip.Text = "0";
                    }
                    else
                    {
                        double number = double.Parse(currentText);
                        moneykip = Convert.ToInt32(Math.Round(number, 0));
                        txtMoneykip.Text = moneykip.ToString("N0");
                    }
                    txtMoneykip.SelectionStart = txtMoneykip.Text.Length;
                    e.Handled = true;
                }

                if (txtMoneykip.Text == string.Empty)
                {
                    txtShowinfo_mai.ResetText();
                }
                else
                {
                    countmai();
                }

                if (e.KeyChar == (char)Keys.Enter)
                {
                    e.Handled = true; // ปิดเสียง "บิ๊" เมื่อกด Enter
                    if (!string.IsNullOrEmpty(txtMoneykip.Text))
                    {
                        txtMoneybat.Focus(); // เลื่อน focus ไปยัง txtpass
                        txtMoneybat.SelectAll(); // เลือกทั้งหมดใน txtpass เพื่อให้ผู้ใช้งานสามารถกรอกข้อมูลได้ง่ายๆ
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtdate_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true; // ปิดเสียง "บิ๊" เมื่อกด Enter
                if (!string.IsNullOrEmpty(txtdate.Text))
                {
                    txtName.Focus(); // เลื่อน focus ไปยัง txtpass
                    txtName.SelectAll(); // เลือกทั้งหมดใน txtpass เพื่อให้ผู้ใช้งานสามารถกรอกข้อมูลได้ง่ายๆ
                }
            }
        }

        private void txtName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true; // ปิดเสียง "บิ๊" เมื่อกด Enter
                if (!string.IsNullOrEmpty(txtName.Text))
                {
                    txtMoneykip.Focus(); // เลื่อน focus ไปยัง txtpass
                    txtMoneykip.SelectAll(); // เลือกทั้งหมดใน txtpass เพื่อให้ผู้ใช้งานสามารถกรอกข้อมูลได้ง่ายๆ
                }
            }
        }

       
    }
}