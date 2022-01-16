
using tapsiriq_8;


Storage workcomputer=new Computer("Computer Hard Disk", "NVM Express",100, 100, 5);
Storage flashdisk = new FlashDisk("Flash Disk", "NVM Express", 1000, 0, 6);
Storage hdddisk = new HddDisk("Hdd Disk", "NVM Express", 15, 0, 6);
hdddisk.Print();
hdddisk.FreeMemory();
hdddisk.Copy(ref workcomputer);
hdddisk.Print();
hdddisk.FreeMemory();
workcomputer.Print();
workcomputer.FreeMemory();

