namespace MAUI_NovenyHatarozo
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(Pages.ListPage), typeof(Pages.ListPage));
        }
    }
}
