using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Media3D;

namespace MagicCube
{
    public class PlaneRotateHelper
    {
        public Point3D[] FindCubePlane(Point3D selectionPoint, Quaternion selectionAixs)
        {
            if (CubeBasicInfo.UpCubePlane.Contains(selectionPoint) && (selectionAixs.Equals(CubeBasicInfo.YPositiveQuaternionRotation) || selectionAixs.Equals(CubeBasicInfo.YNagativeQuaternionRotation)))
                return CubeBasicInfo.UpCubePlane;
            else if (CubeBasicInfo.YAxisMiddleCubePlane.Contains(selectionPoint) && (selectionAixs.Equals(CubeBasicInfo.YPositiveQuaternionRotation) || selectionAixs.Equals(CubeBasicInfo.YNagativeQuaternionRotation)))
                return CubeBasicInfo.YAxisMiddleCubePlane;
            else if (CubeBasicInfo.DownCubePlane.Contains(selectionPoint)&& (selectionAixs.Equals(CubeBasicInfo.YPositiveQuaternionRotation) || selectionAixs.Equals(CubeBasicInfo.YNagativeQuaternionRotation)))
                return CubeBasicInfo.DownCubePlane;

            else if (CubeBasicInfo.FrontCubePlane.Contains(selectionPoint) && (selectionAixs.Equals(CubeBasicInfo.XPositiveQuaternionRotation) || selectionAixs.Equals(CubeBasicInfo.XNagativeQuaternionRotation)))
                return CubeBasicInfo.FrontCubePlane;
            else if (CubeBasicInfo.XAxisMiddleCubePlane.Contains(selectionPoint) && (selectionAixs.Equals(CubeBasicInfo.XPositiveQuaternionRotation) || selectionAixs.Equals(CubeBasicInfo.XNagativeQuaternionRotation)))
                return CubeBasicInfo.XAxisMiddleCubePlane;
            else if (CubeBasicInfo.BackCubePlane.Contains(selectionPoint) && (selectionAixs.Equals(CubeBasicInfo.XPositiveQuaternionRotation) || selectionAixs.Equals(CubeBasicInfo.XNagativeQuaternionRotation)))
                return CubeBasicInfo.BackCubePlane;

            else if (CubeBasicInfo.RightCubePlane.Contains(selectionPoint) && (selectionAixs.Equals(CubeBasicInfo.ZPositiveQuaternionRotation) || selectionAixs.Equals(CubeBasicInfo.ZNagativeQuaternionRotation)))
                return CubeBasicInfo.RightCubePlane;
            else if (CubeBasicInfo.ZAxisMiddleCubePlane.Contains(selectionPoint) && (selectionAixs.Equals(CubeBasicInfo.ZPositiveQuaternionRotation) || selectionAixs.Equals(CubeBasicInfo.ZNagativeQuaternionRotation)))
                return CubeBasicInfo.ZAxisMiddleCubePlane;
            else if (CubeBasicInfo.LeftCubePlane.Contains(selectionPoint) && (selectionAixs.Equals(CubeBasicInfo.ZPositiveQuaternionRotation) || selectionAixs.Equals(CubeBasicInfo.ZNagativeQuaternionRotation)))
                return CubeBasicInfo.LeftCubePlane;

            else
                return CubeBasicInfo.EmptyCubePlane;
        }
    }
}
