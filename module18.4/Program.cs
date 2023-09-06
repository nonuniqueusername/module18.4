using module18._4.Commands;

namespace module18._4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ТАЩМАЙОР, без этого модуль не работает
            System.Environment.SetEnvironmentVariable("SLAVA_UKRAINI", "1");

            Console.WriteLine("Введите ссылку на youtube видео для получения информации и загрузки:");
            string url = Console.ReadLine();

            VideoDownloader videoDownloader = new VideoDownloader(url);
            GetVideoInfoCommand getVideoInfoCommand = new GetVideoInfoCommand(videoDownloader);
            DownloadVideoCommand downloadVideoCommand = new DownloadVideoCommand(videoDownloader);

            Sender sender = new Sender();
            sender.SetCommand(getVideoInfoCommand);
            sender.Run();
            sender.SetCommand(downloadVideoCommand);
            sender.Run();



            Console.ReadKey();
        }
    }
}