using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using module18._4.Interfaces;

namespace module18._4.Commands
{
    internal class DownloadVideoCommand : ICommand
    {
        private VideoDownloader _videoDownloader;

        public DownloadVideoCommand(VideoDownloader videoDownloader)
        {
            _videoDownloader = videoDownloader;
        }

        public void Execute()
        {
            _videoDownloader.DownloadVideo();
        }
    }
}
