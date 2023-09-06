using module18._4.Commands;

namespace module18._4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            VideoDownloader videoDownloader = new VideoDownloader();
            GetVideoInfoCommand getVideoInfoCommand = new GetVideoInfoCommand(videoDownloader);
            DownloadVideoCommand downloadVideoCommand = new DownloadVideoCommand(videoDownloader);

            Sender sender = new Sender(getVideoInfoCommand);
            //Sender sender = new Sender(downloadVideoCommand);
            sender.Run();

        }
    }
}