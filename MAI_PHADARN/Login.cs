using MaterialSkin.Controls;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace MAI_PHADARN
{
    public partial class Login : MaterialForm
    {
        public Login()
        {
            InitializeComponent();
        }

        private connection stringconn = new connection();

        private void Login_Load(object sender, EventArgs e)
        {
            stringconn.connect();
        }

        private void btnLogin_Click(object sender, System.EventArgs e)
        {
            try
            {
                string username = txtuser.Text;
                string password = txtpass.Text;

                SqlCommand command = new SqlCommand($"SELECT * FROM Tb_login WHERE Username='{username}' AND password='{password}'", stringconn.conn);

                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    new FrmMain().Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid username or password!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void resertext()
        {
            txtpass.Text = "";
            txtuser.Text = "";
            txtuser.Focus();
        }

        private void btnclrar_Click(object sender, EventArgs e)
        {
            resertext();
        }

        private void labelControl3_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Register().Show();
        }

        private void txtpass_Enter(object sender, EventArgs e)
        {
        }

        private void txtpass_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // ปิดเสียง "บิ๊" เมื่อกด Enter
                btnLogin.PerformClick(); // ชื่อปุ่มที่ต้องการให้ execute code แทน btnOther
            }
        }

        private void txtuser_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            { 
                e.Handled = true; // ปิดเสียง "บิ๊" เมื่อกด Enter
                if (!string.IsNullOrEmpty(txtuser.Text))
                {
                    txtpass.Focus(); // เลื่อน focus ไปยัง txtpass
                    txtpass.SelectAll(); // เลือกทั้งหมดใน txtpass เพื่อให้ผู้ใช้งานสามารถกรอกข้อมูลได้ง่ายๆ
                }
            }
        }
    }
}