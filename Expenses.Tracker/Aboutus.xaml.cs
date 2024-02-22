using System.Windows.Input;

namespace Expenses.Tracker;

public partial class Aboutus : ContentPage
{
	public ICommand Tap => new Command<string>(async (url) => await Launcher.OpenAsync(url));
    public ICommand Open => new Command<string>(async (url) => await Email.Default.ComposeAsync());

    public Aboutus()
	{
		InitializeComponent();

		BindingContext = this;

	}

	
}