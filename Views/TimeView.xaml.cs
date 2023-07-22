using Practice_Management.MAUI.ViewModels;

namespace Practice_Management.MAUI.Views;

public partial class TimeView : ContentPage
{
	public TimeView()
	{
		InitializeComponent();
	}

    private void BackClicked(object sender, EventArgs e)
    {
		Shell.Current.GoToAsync("//MainPage");
    }

    private void OnArriving(object sender, NavigatedToEventArgs e)
    {
        BindingContext = new TimeViewViewModel();
    }

    private void AddClicked(object sender, EventArgs e)
    {
        Shell.Current.GoToAsync("//TimeAddView");
    }

    private void DeleteClicked(object sender, EventArgs e)
    {
        (BindingContext as TimeViewViewModel).RefreshTimes();
    }

    private void EditClicked(object sender, EventArgs e)
    {
        (BindingContext as TimeViewViewModel).RefreshTimes();
    }

}