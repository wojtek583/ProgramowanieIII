using System;
using System.Collections.Generic;
using System.Text;

namespace LaborkiProgramowanie8
{
    class OutOfInkEventArgs : EventArgs
    {
        public string EmptyInk { get; set; }
        public int Page { get; set; }
        public OutOfInkEventArgs(string emptyInk, int page)
        {
            EmptyInk = emptyInk;
            this.Page = page;
        }
    }
}
