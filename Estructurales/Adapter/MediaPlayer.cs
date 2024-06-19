
namespace Adapter
{
    public class MediaPlayer
    {
        public void PlayMp3(string fileName)
        {
            Console.WriteLine("Playing mp3 file: " + fileName);
        }

        public void PlayMp4(string fileName)
        {
            Console.WriteLine("Playing mp4 file: " + fileName);
        }
    }

}
