using Microsoft.Extensions.DependencyInjection;
using Plugin.Maui.Audio;

namespace MAUI_NovenyHatarozo
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
        }

        protected override void OnStart()
        {
            base.OnStart();
            PlaySound();
        }

        private async void PlaySound()
        {
            Stream stream = await FileSystem.OpenAppPackageFileAsync("Resources/Sounds/Ding-sound-three-times.mp3");
            AsyncAudioPlayer audioPlayer = AudioManager.Current.CreateAsyncPlayer(stream);
            audioPlayer.PlayAsync(new());
        }

        protected override Window CreateWindow(IActivationState? activationState)
        {
            return new Window(new AppShell());
        }
    }
}