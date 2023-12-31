﻿using module18._4.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YoutubeExplode.Videos;

namespace module18._4.Commands
{
    class GetVideoInfoCommand : ICommand
    {
        private VideoDownloader _youtubeDownloader;

        public GetVideoInfoCommand(VideoDownloader youtubeDownloader)
        {
            _youtubeDownloader = youtubeDownloader;
        }
        public void Execute()
        {
            _youtubeDownloader.GetVideoInfo();
        }
    }
}
