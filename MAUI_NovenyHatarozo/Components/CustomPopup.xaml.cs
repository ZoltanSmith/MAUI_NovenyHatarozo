using CommunityToolkit.Maui;
using MAUI_NovenyHatarozo.ViewModel;

namespace MAUI_NovenyHatarozo.Components;

public partial class CustomPopup : CommunityToolkit.Maui.Views.Popup
{
	public CustomPopup(IPopupService popupService, string msg)
	{
		InitializeComponent();
        var popupVM = new PopupVM(popupService, msg);
        BindingContext = popupVM;
    }
}