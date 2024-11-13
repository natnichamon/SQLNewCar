using SQLNewCar.MVVM.ViewModels;
namespace SQLNewCar.View;

public partial class CarPage : ContentPage
{
	public CarPage()
	{
		InitializeComponent();
        this.BindingContext = new CarPageViewModel();
    }
}