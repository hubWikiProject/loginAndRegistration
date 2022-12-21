using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace loginAndRegistration
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();

            this.passwordField.Size = new Size(loginField.Size.Width, loginField.Size.Height);
        }

        /* Авторизация пользователя */
        private void enterUserButton_Click(object sender, EventArgs e)
        {
            try
            {
                string loginUser = loginField.Text;
                string passwordUser = passwordField.Text;

                DBConnection dbConnection = new DBConnection();
                DataTable dataTable = new DataTable();
                MySqlDataAdapter adapter = new MySqlDataAdapter();

                MySqlCommand queryCommand = new MySqlCommand("SELECT * FROM users WHERE login = @uL AND password = @uP", dbConnection.getConnection());
                queryCommand.Parameters.Add("@uL", MySqlDbType.VarChar).Value = loginUser;
                queryCommand.Parameters.Add("@uP", MySqlDbType.VarChar).Value = passwordUser;

                dbConnection.openConnection1();
                adapter.SelectCommand = queryCommand;
                adapter.Fill(dataTable);
                dbConnection.closeConnection1();

                if (dataTable.Rows.Count > 0)
                {
                    this.Close();
                    UserForm userForm = new UserForm();
                    userForm.Show();
                }
                else
                {
                    MessageBox.Show("Error authorization");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /* Кнопка закрыть */
        private void closeButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        Point lastPoint;

        /* Необходимое действие перед перетаскиванием формы
         * Событие вешается на любые нужные элементы, по которым можно перетащить элементы */
        private void StartMoveWindow_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void MoveWindow_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Left += e.X - lastPoint.X;
                Top += e.Y - lastPoint.Y;
            }
        }

        private void closeButton_MouseEnter(object sender, EventArgs e)
        {
            closeButton.BackColor = Color.FromArgb(255, 128, 128);
        }

        private void closeButton_MouseLeave(object sender, EventArgs e)
        {
            closeButton.BackColor = Color.FromArgb(199, 212, 255);
        }

        private void newRegistrationBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegistrationForm registrationForm = new RegistrationForm();
            registrationForm.Show();
        }
    }
}
