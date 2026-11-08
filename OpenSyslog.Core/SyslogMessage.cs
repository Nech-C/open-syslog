using System;
using System.Collections.Generic;
using System.Text;

namespace OpenSyslog.Core
{
    public class SyslogMessage
    {
        public DateTimeOffset TimeReceived { get; set; }
        public string SenderIp { get; set; } = "";
        public int SenderPort { get; set; }
        public byte[] RawPayload { get; set; } = [];
    }
}