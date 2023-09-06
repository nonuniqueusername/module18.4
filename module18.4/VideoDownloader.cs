using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YoutubeExplode;
using YoutubeExplode.Videos.Streams;

namespace module18._4
{
    internal class VideoDownloader
    {
        public async void GetVideoInfo(string videoUrl)
        {
            var youtubeClient = new YoutubeClient();
            try
            {
                var videoInfo = await youtubeClient.Videos.GetAsync(videoUrl);
                Console.WriteLine(videoInfo.Description);
            }
            catch
            {
                Console.WriteLine("pizdik");
            }
        }

        public async void DownloadVideo(string videoUrl)
        {
            var youtubeClient = new YoutubeClient();
            var streamManifest = await youtubeClient.Videos.Streams.GetManifestAsync(videoUrl);
            var streamInfo = streamManifest.GetMuxedStreams().GetWithHighestVideoQuality();
            try
            {
                var videoInfo = await youtubeClient.Videos.Streams.GetAsync(streamInfo);
                youtubeClient.Videos.Streams.DownloadAsync(streamInfo, $"video.{streamInfo.Container}");
            }
            catch
            {
                Console.WriteLine("pizdik");
            }
        }
    }
}
