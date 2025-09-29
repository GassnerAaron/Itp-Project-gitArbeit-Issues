using System.Windows;

namespace _2025_09_22_Pull_Request_und_Issues
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
<<<<<<< HEAD

        private void AddTodo(object sender, RoutedEventArgs e)
        {
            string newTodo = TodoInput.Text.Trim();
            if (!string.IsNullOrEmpty(newTodo))
            {
                TodoList.Items.Add(newTodo);
                TodoInput.Clear();
            }
            else
            {
                MessageBox.Show("Bitte geben Sie einen ToDo-Eintrag ein.", "Eingabe leer", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }
=======
        // Kommentar TEST
>>>>>>> Nikoll
    }
}