using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Windows.Forms;

namespace loginAndRegistration
{
    public partial class RegistrationForm : Form
    {
        private string defaultFirstNameText = "Введите имя";
        private string defaultEmailText = "Введите email";
        private string defaultLoginText = "Введите логин";
        public RegistrationForm()
        {
            InitializeComponent();
            firstNameField.Text = defaultFirstNameText;
            emailField.Text = defaultEmailText;
            loginField.Text = defaultLoginText;

            firstNameField.ForeColor = Color.Gray;
            emailField.ForeColor = Color.Gray;
            loginField.ForeColor = Color.Gray;
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

        private void registrationButton_Click(object sender, EventArgs e)
        {
            string firstName = firstNameField.Text;
            string email = emailField.Text;
            string login = loginField.Text;
            string password = passwordField.Text;

            try
            {
                if (String.IsNullOrEmpty(firstName)
                    || String.IsNullOrEmpty(email)
                    || String.IsNullOrEmpty(login)
                    || String.IsNullOrEmpty(password))
                {
                    throw new Exception("Поля не должны быть пустыми.");
                }

                if (!Validator.EmailIsValid(email))
                    throw new Exception("Введен не корректный email. Попробуйте еще раз");

                if (isUserExists(login, email))
                    throw new Exception("Такой пользователь уже существует");

                DBConnection connection = new DBConnection();

                /* создание записи о новом пользователе */
                MySqlCommand command = new MySqlCommand("INSERT INTO users (firstName, email, login, password) " +
                    "VALUES (@uFName, @uEmail, @uLogin, @uPassword)", connection.getConnection());
                command.Parameters.Add("@uFName", MySqlDbType.VarChar).Value = firstName;
                command.Parameters.Add("@uEmail", MySqlDbType.VarChar).Value = email;
                command.Parameters.Add("@uLogin", MySqlDbType.VarChar).Value = login;
                command.Parameters.Add("@uPassword", MySqlDbType.VarChar).Value = password;

                connection.openConnection1();
                if (command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Аккаунт был создан");
                    this.Hide();
                    LoginForm loginForm = new LoginForm();
                    loginForm.Show();
                }
                else
                {
                    MessageBox.Show("Аккаунт не был создан");
                }
                connection.closeConnection1();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /* Событие при вводе нового текста */
        private void enterText_Enter(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox;
            if (textBox.Text == defaultFirstNameText
                || textBox.Text == defaultEmailText
                || textBox.Text == defaultLoginText)
            {
                textBox.ForeColor = Color.Black;
                textBox.Text = "";
            }
        }

        /* Обработка событий при выходе из ввода в текстовое поле */
        private void enterText_Leave(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox;

            if (textBox.Name == "firstNameField" && String.IsNullOrEmpty(textBox.Text))
            {
                textBox.Text = defaultFirstNameText;
                textBox.ForeColor = Color.Red;
            }
            else if (textBox.Name == "emailField" && String.IsNullOrEmpty(textBox.Text))
            {
                textBox.Text = defaultEmailText;
                textBox.ForeColor = Color.Red;
            }
            else if (textBox.Name == "loginField" && String.IsNullOrEmpty(textBox.Text))
            {
                textBox.Text = defaultLoginText;
                textBox.ForeColor = Color.Red;
            }
        }

        /* Проверяем существует ли пользователь. Проверяем email и login */
        private bool isUserExists(string login, string email)
        {
            DBConnection connection = new DBConnection();
            DataTable dataTable = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT id FROM users WHERE email = @uEmail OR login = @uLogin", connection.getConnection());
            command.Parameters.Add("@uEmail", MySqlDbType.VarChar).Value = email;
            command.Parameters.Add("@uLogin", MySqlDbType.VarChar).Value = login;

            connection.openConnection1();
            adapter.SelectCommand = command;
            adapter.Fill(dataTable);
            connection.closeConnection1();

            if (dataTable.Rows.Count > 0)
            {
                return true;
            }
            return false;
        }

        private void goToLoginForm_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
        }
    }
}
