using Avalonia.Controls;
using Microsoft.EntityFrameworkCore;
using RussiasRoads.Classes;
using System.Linq;

namespace RussiasRoads.Views;

public partial class MainView : UserControl
{
    public MainView()
    {
        InitializeComponent();
        Help.DB.Subdivisions.Load();
        OrgTv.ItemsSource = Help.DB.Subdivisions.Where(el => el.HeadId == null).ToList();
    }

    private void TreeView_SelectionChanged(object? sender, Avalonia.Controls.SelectionChangedEventArgs e)
    {

    }

    private void Button_Click(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
    {
    }

    private void Button_Click_1(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
    {
    }
}
