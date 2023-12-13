using AppsCenter.Apps.ToDoApp.Models;
using System;
using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace AppsCenter.Apps.ToDoApp;

public partial class ToDoList : Window
{
    private ToDoListModel? _todoList;

    public ToDoList()
    {
        InitializeComponent();
        InitializeTasks();

        Closing += OnWindowClosing;
    }

    private void OnWindowClosing(object? sender, CancelEventArgs e)
    {
        _todoList?.SaveTasksToJson();
    }

    public void InitializeTasks()
    {
        _todoList = new ToDoListModel();

        listTasks.ItemsSource = _todoList.ToDoTasks;
    }

    private void OnTextBlockMouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
    {
        if (e.ClickCount == 2)
        {
            TextBlock? textBlock = sender as TextBlock;
            StackPanel? stack = textBlock!.Parent as StackPanel;
            TextBox? textBox = stack!.FindName("editTaskDescription") as TextBox;
            Button? Savebutton = stack.FindName("btnSave") as Button;
            Button? Deletebutton = stack.FindName("btnDelete") as Button;

            textBlock.Visibility = Visibility.Collapsed;
            textBox!.Visibility = Visibility.Visible;
            Savebutton!.Visibility = Visibility.Visible;
            Deletebutton!.Visibility = Visibility.Visible;

            textBox.Text = textBlock.Text;
        }
    }

    private void OnSaveEdit(object sender, RoutedEventArgs e)
    {
        Button? saveButton = sender as Button;
        StackPanel? stack = saveButton?.Parent as StackPanel;
        TextBox? descriptionTextBox = stack?.FindName("editTaskDescription") as TextBox;
        Button? deleteButton = stack?.FindName("btnDelete") as Button;
        TextBlock? description = stack?.FindName("txtTaskDescription") as TextBlock;
        ToDoTask? task = description?.DataContext as ToDoTask;

        saveButton!.Visibility = Visibility.Collapsed;
        descriptionTextBox!.Visibility = Visibility.Collapsed;
        deleteButton!.Visibility = Visibility.Collapsed;

        description!.Visibility = Visibility.Visible;

        if (!string.IsNullOrEmpty(descriptionTextBox.Text))
            description.Text = descriptionTextBox.Text;

        ListBox listBox = FindParent<ListBox>(saveButton);

        string listBoxname = listBox.Name;

        if (!string.IsNullOrWhiteSpace(listBoxname))
        {
            _todoList?.UpdateTask(task!.Id, description.Text);
        }
    }

    private static T FindParent<T>(DependencyObject child) where T : DependencyObject
    {
        DependencyObject parent = VisualTreeHelper.GetParent(child);

        while (parent != null && parent is not T)
        {
            parent = VisualTreeHelper.GetParent(parent);
        }

        return (T)parent;
    }

    private void OnAddTask(object sender, RoutedEventArgs e)
    {
        string text = txtNewTask.Text;

        if (!string.IsNullOrEmpty(text))
        {
            ToDoTask newTodo = new(DateTime.Now.Second, text);
            _todoList?.AddNewTask(newTodo);
        }

        txtNewTask.Clear();
    }

    private void OnToDoTaskDelete(object sender, RoutedEventArgs e)
    {
        Button? Deletebutton = sender as Button;
        StackPanel? stack = Deletebutton?.Parent as StackPanel;
        TextBlock? description = stack?.FindName("txtTaskDescription") as TextBlock;
        ToDoTask? task = description?.DataContext as ToDoTask;

        _todoList?.RemoveTodoTask(task);
    }
}
