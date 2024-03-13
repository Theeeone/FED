using Assignment2test.ViewModel;

namespace Assignment2test;

public partial class DetailPage : ContentPage
{
	public DetailPage(DetailViewModel vm)
	{
        InitializeComponent();
        BindingContext = vm;
	}
}