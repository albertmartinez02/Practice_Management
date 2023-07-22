using Practice_Management.MAUI.ViewModels;

namespace Practice_Management.MAUI.Views;

public partial class EmployeeView : ContentPage
{
	public EmployeeView()
	{
		InitializeComponent();
        BindingContext = new EmployeeViewViewModel();
    }

    private void BackClicked(object sender, EventArgs e)
    {
		Shell.Current.GoToAsync("//MainPage");
    }

    private void OnArrival(object sender, NavigatedToEventArgs e)
    {
        (BindingContext as EmployeeViewViewModel).RefreshView();
    }

    private void DeleteClicked(object sender, EventArgs e)
    {
        (BindingContext as EmployeeViewViewModel).RefreshView();
    }
}