﻿using XPloit.Core.Sockets.Enums;
using System.Runtime.Serialization;
using XPloit.Core.Sockets.Interfaces;

namespace XPloit.Core.Sockets.Messages
{
    public class XPloitMsgString : IXPloitSocketMsg
    {
        [DataMember(Name = "d")]
        public string Data { get; set; }

        public XPloitMsgString()
        {
        }
        public override EXPloitSocketMsg Type { get { return EXPloitSocketMsg.String; } }
    }
}