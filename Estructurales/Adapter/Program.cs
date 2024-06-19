using Adapter;

public class Program
{
    public static void Main(string[] args)
    {
        MediaPlayer mediaPlayer = new MediaPlayer();
        IAudioPlayer audioPlayer = new MediaAdapter(mediaPlayer);

        audioPlayer.PlayAudio("mp3", "song.mp3");
        audioPlayer.PlayAudio("mp4", "video.mp4");
        audioPlayer.PlayAudio("avi", "movie.avi");
    }
}
