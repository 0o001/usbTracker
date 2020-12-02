using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace usbTracker
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "USB Tracker";

            List<DriveInfo> tempDrives = null;
            while(true)
            {
                List<DriveInfo> drives = DriveInfo.GetDrives().Where(drive => drive.IsReady).ToList();

                if(tempDrives is null)
                {
                    tempDrives = drives;
                }

                if(drives.Count != tempDrives.Count)
                {
                    if(drives.Count > tempDrives.Count)
                    {
                        var drive = drives.Except(tempDrives, new DriveInfoEqualityComparer()).First();
                        Console.WriteLine($"[{ DateTime.Now }] [{ drive.Name }] Adlı { DriveTypeInfo.getName(drive.DriveType) } Cihaz Takıldı.");
                    }

                    if(drives.Count < tempDrives.Count)
                    {
                        var drive = tempDrives.Except(drives, new DriveInfoEqualityComparer()).First();
                        Console.WriteLine($"[{ DateTime.Now }] [{ drive.Name }] Adlı { DriveTypeInfo.getName(drive.DriveType) } Cihaz Çıkartıldı.");
                    }

                    tempDrives = drives;
                }
               
            }

        }
    }
}
