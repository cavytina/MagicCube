using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Media3D;

namespace MagicCube
{
    public static partial class CubeBasicInfo
    {
        public static readonly Quaternion YPositiveQuaternionRotation = new Quaternion(new Vector3D(0, 1, 0), 90);
        public static readonly Quaternion YNagativeQuaternionRotation = new Quaternion(new Vector3D(0, 1, 0), -90);
        public static readonly Quaternion XPositiveQuaternionRotation = new Quaternion(new Vector3D(1, 0, 0), 90);
        public static readonly Quaternion XNagativeQuaternionRotation = new Quaternion(new Vector3D(1, 0, 0), -90);
        public static readonly Quaternion ZPositiveQuaternionRotation = new Quaternion(new Vector3D(0, 0, 1), 90);
        public static readonly Quaternion ZNagativeQuaternionRotation = new Quaternion(new Vector3D(0, 0, 1), -90);
    }
}
