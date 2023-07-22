using Practice_Management.MAUI.ViewModels;

namespace Practice_Management.MAUI.Views;

[QueryProperty(nameof(TimeID) , "timeID")]
public partial class TimerEdit : ContentPage
{

	public int TimeID { get; set; }
	public TimerEdit()
	{
		InitializeComponent();
	}

    private void OnArrival(object sender, NavigatedToEventArgs e)
    {
		BindingContext = new TimeViewModel(TimeID);
    }

    private void OkClicked(object sender, EventArgs e)
    {
        (BindingContext as TimeViewModel).AddOrUpdate();
        Shell.Current.GoToAsync("//TimeView");
    }

    private void CancelClicked(object sender, EventArgs e)
    {
        Shell.Current.GoToAsync("//TimeView");
    }
}