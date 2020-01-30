using System;
using System.Collections.Generic;
using System.Text;

namespace LaborkiProgramowanie8
{
    public class PaperJammedEventArgs : EventArgs
    {
        public int Page { get; set; }
        public PaperJammedEventArgs(int page)
        {
            Page = page;
        }
    }
}
