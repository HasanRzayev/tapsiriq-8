using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tapsiriq_8
{
    class HddDisk : Storage
    {
        public HddDisk(string medianame, string model, int capasity, int nowcapasity, int velocity) : base(medianame, model, capasity, nowcapasity, velocity)
        {
        }
    }
}
