using MAUI_NovenyHatarozo.ViewModel;

namespace MAUI_NovenyHatarozo.Components;

public partial class Popup : ContentView
{
	public Popup(PopupVM popupVM)
	{
		InitializeComponent();
        BindingContext = popupVM;
    }
}