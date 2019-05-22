using System;
using AdaptorPattern.Adaptor;

namespace AdaptorPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var vlcmedia = new MediaPlayer(PlayerType.VLC);
            vlcmedia.Play(PlayerType.VLC, @"vlc\playlist");

            var mp4media = new MediaPlayer(PlayerType.MP4);
            mp4media.Play(PlayerType.MP4, @"mp4\playlist");
        }
    }
}
