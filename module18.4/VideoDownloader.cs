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
        private string videoUrl;
        public VideoDownloader(string url) 
        {
            videoUrl = url;
        }
        public async void GetVideoInfo()
        {
            var youtubeClient = new YoutubeClient();
            try
            {
                var videoInfo = await youtubeClient.Videos.GetAsync(videoUrl);
                Console.WriteLine("-------------Описание видео-------------");
                Console.WriteLine(videoInfo.Description);
                Console.WriteLine("----------------------------------------");
            }
            catch
            {
                Console.WriteLine("Ошибка при получении информации о видео!");
            }
        }

        public async void DownloadVideo()
        {
            var youtubeClient = new YoutubeClient();
            try
            {
                var streamManifest = await youtubeClient.Videos.Streams.GetManifestAsync(videoUrl);
                var streamInfo = streamManifest.GetMuxedStreams().GetWithHighestVideoQuality();
                var videoInfo = await youtubeClient.Videos.Streams.GetAsync(streamInfo);
                string fileName = $"video.{streamInfo.Container}";
                Console.WriteLine($"Запущено сохранение видео по ссылке {videoUrl}.");
                await youtubeClient.Videos.Streams.DownloadAsync(streamInfo, fileName);
                Console.WriteLine($"Видео сохранено: {Path.Combine(Directory.GetCurrentDirectory(), fileName)}" );
            }
            catch
            {
                Console.WriteLine("Ошибка при сохранении видео!");
            }
        }
    }
}
