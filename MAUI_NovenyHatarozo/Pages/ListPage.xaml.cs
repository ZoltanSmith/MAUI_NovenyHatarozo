using MAUI_NovenyHatarozo.ViewModel;

namespace MAUI_NovenyHatarozo.Pages;

public partial class ListPage : ContentPage
{
	public ListPage(NovenyListVM vm)
	{
		InitializeComponent();
        BindingContext = vm;
    }
}