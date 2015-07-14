﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace msos
{
    interface IPrinter : IDisposable
    {
        uint RowsPerPage { get; set; }
        void WriteInfo(string format, params object[] args);
        void WriteInfo(string value);
        void WriteCommandOutput(string format, params object[] args);
        void WriteCommandOutput(string value);
        void WriteError(string format, params object[] args);
        void WriteError(string value);
        void WriteWarning(string format, object[] args);
        void WriteWarning(string value);
        void WriteLink(string value);
        void ClearScreen();
        void CommandEnded();
    }
}
