using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MD5FolderVerifier
{
    enum LogMsgType
    {
        Info,
        Error,
        Warning,
    }

    enum RunningMode
    {
        Console,
        GUI,
    }

    enum LogResultType
    {
        GenerateSuccess,
        NotFound,
        Passed,
        Mismatch,
        AlreadyExist,
    }
}
