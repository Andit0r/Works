namespace Task1
{
    public partial class RegistrationForm : Form
    {
        private string _filePath = "logins.csv";
        public RegistrationForm()
        {
            InitializeComponent();
        }

        private void RegistrationButton_Click(object sender, EventArgs e)
        {
            string login = loginTextBox.Text.Trim();
            string password = passwordTextBox.Text.Trim();
            if (string.IsNullOrEmpty(login) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Пустой логин или пароль", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var lines = File.ReadAllLines(_filePath);
            if (lines.Any(l => l.Split(';')[0] == login))
            {
                MessageBox.Show("Данный логин уже существует, введите логин повторно", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            File.AppendAllText(_filePath, $"{login};{password};{DateTime.Now:dd.MM.yyyy}\n");
            MessageBox.Show("Вы успешно зарегистрированы", "Успех!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
