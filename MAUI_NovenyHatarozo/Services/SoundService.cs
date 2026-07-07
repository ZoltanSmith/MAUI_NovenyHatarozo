using CommunityToolkit.Mvvm.Input;
using Plugin.Maui.Audio;

namespace MAUI_NovenyHatarozo.Services
{
    public partial class SoundService
    {
        internal async void PlaySound()
        {
            Stream stream = await FileSystem.OpenAppPackageFileAsync("Resources/Sounds/Ding-sound-three-times.mp3");
            AsyncAudioPlayer audioPlayer = AudioManager.Current.CreateAsyncPlayer(stream);
            audioPlayer.PlayAsync(new());
        }

    }
}
