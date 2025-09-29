<<<<<<< HEAD
﻿using System.Windows;
=======
﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows;
>>>>>>> Edin_tafiloski

namespace TodoApp
{
    public partial class MainWindow : Window
    {
        private readonly string filePath = Path.Combine(
            AppDomain.CurrentDomain.BaseDirectory, "todos.txt");

        public MainWindow()
        {
            InitializeComponent();
            LoadTodos();
        }

        private void InitializeComponent()
        {
            throw new NotImplementedException();
        }

        private void AddTodo(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(.Text)) // <-- Zugriff auf TextBox
            {
                var todo = new TodoItem { Title = TodoInput.Text, IsDone = false };
                TodoList.Items.Add(todo);                   // <-- Zugriff auf ListBox
                TodoInput.Clear();
                SaveTodos();
            }
        }

        // ✅ Aufgabe erledigen/nicht erledigen (Doppelklick)
        private void TodoList_MouseDoubleClick(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            if (TodoList.SelectedItem is TodoItem item)
            {
                item.IsDone = !item.IsDone;
                RefreshList();
                SaveTodos();
            }
        }

        // ❌ Aufgabe löschen (Entf-Taste)
        private void TodoList_KeyDown(object sender, System.Windows.Input.KeyEventArgs e)
        {
            if (e.Key == System.Windows.Input.Key.Delete && TodoList.SelectedItem is TodoItem item)
            {
                TodoList.Items.Remove(item);
                SaveTodos();
            }
        }

        // 🔄 Anzeige aktualisieren
        private void RefreshList()
        {
            var items = TodoList.Items.Cast<TodoItem>().ToList();
            TodoList.Items.Clear();
            foreach (var t in items) TodoList.Items.Add(t);
        }

        // 💾 Speichern in Textdatei
        private void SaveTodos()
        {
            var lines = new List<string>();
            foreach (TodoItem item in TodoList.Items)
            {
                string prefix = item.IsDone ? "[x]" : "[ ]";
                lines.Add($"{prefix} {item.Title}");
            }
            File.WriteAllLines(filePath, lines);
        }

        // 📂 Laden aus Textdatei
        private void LoadTodos()
        {
            if (File.Exists(filePath))
            {
                var lines = File.ReadAllLines(filePath);
                foreach (var line in lines)
                {
                    bool isDone = line.StartsWith("[x]");
                    string title = line.Substring(3).Trim();
                    TodoList.Items.Add(new TodoItem { Title = title, IsDone = isDone });
                }
            }
        }

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
    }
<<<<<<< HEAD
}
=======
    public class TodoItem
    {
        public string Title { get; set; }
        public bool IsDone { get; set; }

        public override string ToString()
        {
            return IsDone ? $"✔ {Title}" : Title;
        }
    }

}



>>>>>>> Edin_tafiloski
