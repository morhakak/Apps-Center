using AppsCenter.Apps.UserManagement.Models;
using AppsCenter.Apps.UserManagement.Utils;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace AppsCenter.Apps.UserManagement;

public partial class UserManagementView : Window
{
    User? _user;
    List<User> _users;

    public UserManagementView()
    {
        InitializeComponent();

        _users = DataHandler.GetUsers();

        if (_users == null || _users.Count == 0)
        {
            var initialList = DataHandler.GetDefaultUsers();

            _users = DataHandler.UpdateList(initialList);
        }

        UpdateDataGrid();
    }

    private void UpdateJsonData()
    {
        List<User> tempList = _users;
        _users = DataHandler.UpdateList(tempList);
    }

    private void Btn_Add_Click(object sender, RoutedEventArgs e)
    {
        if (Validate.UserName(Input_UserName) && Validate.Email(Input_Email))
        {
            _users.Add(new User(Input_UserName.Text, Input_Email.Text));
            ClearInputs();
            UpdateDataGrid();
            UpdateJsonData();
        }
    }

    private void UpdateDataGrid()
    {
        DataGrid1.ItemsSource = _users.ToList();
    }

    private void DataGrid1_SelectionChanged(object sender, SelectionChangedEventArgs e)
    {
        DataGridCellInfo idCell = DataGrid1.SelectedCells[0];
        DataGridCellInfo nameCell = DataGrid1.SelectedCells[1];
        DataGridCellInfo emailCell = DataGrid1.SelectedCells[2];

        try
        {
            string id = ((TextBlock)idCell.Column.GetCellContent(idCell.Item)).Text;
            Input_UserName.Text = ((TextBlock)nameCell.Column.GetCellContent(nameCell.Item)).Text;
            Input_Email.Text = ((TextBlock)emailCell.Column.GetCellContent(emailCell.Item)).Text;
            _user = _users.Single(item => item.Id.ToString() == id);
        }
        catch { }
    }

    private void Btn_Remove_Click(object sender, RoutedEventArgs e)
    {
        if (_user is null) return;

        _users.Remove(_user);
        ClearInputs();
        UpdateDataGrid();
        UpdateJsonData();
    }

    private void Btn_Update_Click(object sender, RoutedEventArgs e)
    {
        var isValidUserName = Validate.UserName(Input_UserName);
        var isValidEmail = Validate.Email(Input_Email);

        if ((isValidUserName && isValidEmail) is false) return;

        _user!.Name = Input_UserName.Text;
        _user.Email = Input_Email.Text;
        UpdateDataGrid();
        UpdateJsonData();

        ClearInputs();
    }
    private void ClearInputs()
    {
        Input_UserName.Text = string.Empty;
        Input_Email.Text = string.Empty;
    }
}
