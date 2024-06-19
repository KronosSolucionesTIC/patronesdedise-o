
namespace Adapter
{
    public class MediaAdapter : IAudioPlayer
    {
        private readonly MediaPlayer _mediaPlayer;

        public MediaAdapter(MediaPlayer mediaPlayer)
        {
            _mediaPlayer = mediaPlayer;
        }

        public void PlayAudio(string audioType, string fileName)
        {
            if (audioType.Equals("mp3", StringComparison.OrdinalIgnoreCase))
            {
                _mediaPlayer.PlayMp3(fileName);
            }
            else if (audioType.Equals("mp4", StringComparison.OrdinalIgnoreCase))
            {
                _mediaPlayer.PlayMp4(fileName);
            }
            else
            {
                Console.WriteLine("Invalid media type: " + audioType);
            }
        }
    }

}
