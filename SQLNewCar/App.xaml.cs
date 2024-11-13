using SQLNewCar.Repository;
using SQLNewCar.View;
using Microsoft.Maui.Controls;

namespace SQLNewCar
{
    public partial class App : Application
    {
        public static CarRepository _carRepo { get; private set; }

        public App()
        {
            InitializeComponent(); 
            _carRepo = new CarRepository(); 

            
            MainPage = new CarPage(); 
        }
    }
}