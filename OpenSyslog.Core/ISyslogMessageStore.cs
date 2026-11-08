using System;
using System.Collections.Generic;
using System.Text;

namespace OpenSyslog.Core
{
    public interface ISyslogMessageStore
    {
        Task SaveAsync(SyslogMessage[] message, CancellationToken cancellationToken);

        void OpenConnection();

        void CloseConnection();
    }
}
