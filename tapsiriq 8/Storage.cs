using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tapsiriq_8
{
    abstract class Storage
    {
        protected Storage(string medianame, string model, int capasity, int nowcapasity, int velocity)
        {
            this.medianame = medianame;
            this.model = model;
            this.capasity = capasity;
            this.nowcapasity = nowcapasity;
            this.velocity = velocity;
        }

        public string medianame { get; set; }
        public string model { get; set; }
        public int capasity { get; set; }
        public int nowcapasity { get; set; }
        public int velocity { get; set; }
        public void Copy(ref Storage baza)
        {
            var count = 0;
            while (true)
            {
               
                baza.nowcapasity -= capasity;
                count++;
                if (baza.nowcapasity-capasity < 0 ) break;
            }
            for (int i = 0; i < velocity; i++)
            {
                Console.Clear();
       
                Console.WriteLine(velocity-i+"   saniyeye yuklenme tamamlanir....");
                Thread.Sleep(1000);

            }

            Console.WriteLine("Umumi say---" + count);

            nowcapasity += baza.nowcapasity;
            baza.nowcapasity-=baza.nowcapasity;

        }
        public void Capasity()
        {
            Console.WriteLine("Capasity-----" + capasity);
        }
        public void FreeMemory()
        {
            if (nowcapasity == 0)
            {
                Console.WriteLine("Bosdur");
            }
            else if(nowcapasity == capasity)
            {
                Console.WriteLine("Yer qalmayib");

            }
            else
            {
                Console.WriteLine("Icerde "+nowcapasity+" Mb var");
                Console.WriteLine(capasity-nowcapasity+" MB  yer qalib");
            }
        }

        public void Print()
        {
            Console.WriteLine("Media name-----"+medianame);
            Console.WriteLine("Model-----"+model);
 
        
        }
    }
}
