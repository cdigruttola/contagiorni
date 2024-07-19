namespace ContaGiorni;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
	}

	private void OnCounterClicked(object sender, EventArgs e)
	{
		DateTime dateNow = dateFrom.Date;
		string days = daysToAdd.Text;
		dateTo.Date = dateNow.AddDays(Int32.Parse(days));
	}
}

