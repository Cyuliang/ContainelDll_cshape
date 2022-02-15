using System;

namespace ContainelDll
{
    public class NewLpnEventArgs:EventArgs
    {
        public DateTime TriggerTime { get; set; }
        public int LaneNum { get; set; }
        public string Lpn { get; set; }
        public int Color { get; set; }
    }
}
