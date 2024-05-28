using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace MAI_PHADARN
{
    public partial class Register : DevExpress.XtraBars.FluentDesignSystem.FluentDesignForm
    {
        public Register()
        {
            InitializeComponent();
        }

        private connection cd = new connection();
        private SqlCommand cmd = new SqlCommand();
        private SqlDataAdapter da = new SqlDataAdapter();
        private DataSet ds = new DataSet();

        private void Register_Load(object sender, System.EventArgs e)
        {
            cd.connect();
        }

        private void btnRegister_Click(object sender, System.EventArgs e)
        {
            try
            {
                string username = txtuser.Text;
                string password = txtpass.Text;
                string compassword = txtComfimePassword.Text;

                if (username == "" && password == "" && compassword == "")
                {
                    MessageBox.Show("Username and password failed are empty", "Registration failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (txtpass.Text == txtComfimePassword.Text)
                {
                    cmd = new SqlCommand("SELECT COUNT(*) FROM Tb_login", cd.conn);
                    int userCount = (int)cmd.ExecuteScalar();

                    if (userCount >= 3)
                    {
                        MessageBox.Show("ບໍ່ສາມາດ user ໄດ້ເນື່ອງຈາກ user ເຕີມແລ້ວ", "ผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        reserttext();
                    }
                    else
                    {
                        // ทำการ insert ข้อมูลลงใน database
                        cmd = new SqlCommand($"INSERT INTO Tb_login (Username, password) VALUES ('{username}', '{password}')", cd.conn);

                        int result = cmd.ExecuteNonQuery();
                        if (result > 0)
                        {
                            MessageBox.Show("Your account has been successful created", "Registration Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Registration failed!");
                        }
                        reserttext();
                    }
                }
                else
                {
                    MessageBox.Show("Passwords does not match, please Re-enter", "Registration failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtComfimePassword.ResetText();
                    txtpass.ResetText();
                    txtpass.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void reserttext()
        {
            txtComfimePassword.ResetText();
            txtpass.ResetText();
            txtuser.ResetText();
            txtuser.Focus();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            reserttext();
            txtuser.Focus();
        }

        private void backlogin_Click(object sender, EventArgs e)
        {
            new Login().Show();
            this.Hide();
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

        private void txtpass_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true; // ปิดเสียง "บิ๊" เมื่อกด Enter
                if (!string.IsNullOrEmpty(txtpass.Text))
                {
                    txtComfimePassword.Focus(); // เลื่อน focus ไปยัง txtpass
                    txtComfimePassword.SelectAll(); // เลือกทั้งหมดใน txtpass เพื่อให้ผู้ใช้งานสามารถกรอกข้อมูลได้ง่ายๆ
                }
            }
        }
    }
}