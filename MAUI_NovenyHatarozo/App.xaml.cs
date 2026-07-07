using MAUI_NovenyHatarozo.Services;

namespace MAUI_NovenyHatarozo
{
    public partial class App : Application
    {
        SoundService soundService;

        public App(SoundService soundService)
        {
            InitializeComponent();
            this.soundService = soundService;
        }

        protected override void OnStart()
        {
            base.OnStart();
            soundService.PlaySound();
        }
        
        
        protected override Window CreateWindow(IActivationState? activationState)
        {
            return new Window(new AppShell());
        }
    }
}