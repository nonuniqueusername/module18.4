using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CliWrap;
using module18._4.Interfaces;

namespace module18._4
{
    class Sender
    {
        private ICommand _command;


        public void SetCommand(ICommand command)
        {
            _command = command;
        }

        public void Run()
        {
            _command.Execute();
        }
    }
}
