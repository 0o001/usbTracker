using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace usbTracker
{
    public class DriveInfoEqualityComparer : IEqualityComparer<DriveInfo>
    {
        public bool Equals(DriveInfo x, DriveInfo y)
        {
            if (ReferenceEquals(x, y))
            {
                return true;
            }
            if (x == null || y == null)
            {
                return false;
            }

            return x.Name.Equals(y.Name);
        }

        public int GetHashCode(DriveInfo obj)
        {
            return obj.Name.GetHashCode();
        }
    }
}
