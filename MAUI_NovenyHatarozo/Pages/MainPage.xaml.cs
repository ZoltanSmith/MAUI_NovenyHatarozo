using MAUI_NovenyHatarozo.ViewModel;

namespace MAUI_NovenyHatarozo
{
    public partial class MainPage : ContentPage
    {
        public MainPage(MainVM vm)
        {
            InitializeComponent();
            BindingContext = vm;
        }
    }
}
