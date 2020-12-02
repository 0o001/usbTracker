using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace usbTracker
{
    class DriveTypeInfo
    {
        public static string getName(DriveType type)
        {
            switch (type)
            {
                case DriveType.Unknown:
                        default:
                    return "Bilinmeyen";
                case DriveType.NoRootDirectory:
                    return "Kök Dizini Olmayan";
                case DriveType.Removable:
                    return "USB Bellek";
                case DriveType.Fixed:
                    return "Sabit Disk";
                case DriveType.Network:
                    return "Ağ";
                case DriveType.CDRom:
                    return "CDRom";
                case DriveType.Ram:
                    return "RAM Disk";
            }
        }
    }
}
