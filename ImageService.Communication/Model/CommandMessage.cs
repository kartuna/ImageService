﻿using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageService.Communication.Model
{
    public class CommandMessage
    {
        public int Command { get; set; }
        public string[] Args { get; set; }

        public CommandMessage(int a_cmd, string[] a_args = null)
        {
            Command = a_cmd;
            Args = a_args;
        }
    }
}
