using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiApp1;

public partial class DetailPage : ContentPage
{
    public DetailPage()
    {
        InitializeComponent();
    }

    private async void NavigateBack(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("..");
    }

    private async void NavigateBackPop(object sender, EventArgs e)
    {
        await Shell.Current.Navigation.PopAsync();
    }
}