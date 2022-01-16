using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tapsiriq_8
{
    class FlashDisk : Storage
    {
        public FlashDisk(string medianame, string model, int capasity, int nowcapasity, int velocity) : base(medianame, model, capasity, nowcapasity, velocity)
        {
}
    }
}
