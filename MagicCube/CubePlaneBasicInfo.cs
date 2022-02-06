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
        public static readonly Point3D[] EmptyCubePlane = new Point3D[9] { new Point3D(0, 0, 0), new Point3D(0, 0, 0), new Point3D(0, 0, 0), new Point3D(0, 0, 0), new Point3D(0, 0, 0), new Point3D(0, 0, 0), new Point3D(0, 0, 0), new Point3D(0, 0, 0), new Point3D(0, 0, 0) };
        public static readonly Point3D[] UpCubePlane = new Point3D[9] { FrontUpPrismBorderCubeCenterPoint, FrontRightUpCornerBorderCubeCenterPoint, RightUpPrismBorderCubeCenterPoint, RightBackUpCornerBorderCubeCenterPoint, BackUpPrismBorderCubeCenterPoint, BackLeftUpCornerBorderCubeCenterPoint, LeftUpPrismBorderCubeCenterPoint, LeftFrontUpCornerBorderCubeCenterPoint, UpCenterBorderCubeCenterPoint };
        public static readonly Point3D[] DownCubePlane = new Point3D[9] { FrontDownPrismBorderCubeCenterPoint, FrontRightDownCornerBorderCubeCenterPoint, RightDownPrismBorderCubeCenterPoint, RightBackDownCornerBorderCubeCenterPoint, BackDownPrismBorderCubeCenterPoint, BackLeftDownCornerBorderCubeCenterPoint, LeftDownPrismBorderCubeCenterPoint, LeftFrontDownCornerBorderCubeCenterPoint, DownCenterBorderCubeCenterPoint };
        public static readonly Point3D[] BackCubePlane = new Point3D[9] { RightBackUpCornerBorderCubeCenterPoint, RightBackPrismBorderCubeCenterPoint, RightBackDownCornerBorderCubeCenterPoint,BackUpPrismBorderCubeCenterPoint, BackCenterBorderCubeCenterPoint, BackDownPrismBorderCubeCenterPoint, BackLeftUpCornerBorderCubeCenterPoint, BackLeftPrismBorderCubeCenterPoint, BackLeftDownCornerBorderCubeCenterPoint };
        public static readonly Point3D[] FrontCubePlane = new Point3D[9] { LeftFrontUpCornerBorderCubeCenterPoint, LeftFrontPrismBorderCubeCenterPoint, LeftFrontDownCornerBorderCubeCenterPoint, FrontUpPrismBorderCubeCenterPoint, FrontCenterBorderCubeCenterPoint, FrontDownPrismBorderCubeCenterPoint, FrontRightUpCornerBorderCubeCenterPoint, FrontRightPrismBorderCubeCenterPoint, FrontRightDownCornerBorderCubeCenterPoint };
        public static readonly Point3D[] LeftCubePlane = new Point3D[9] { BackLeftUpCornerBorderCubeCenterPoint, BackLeftPrismBorderCubeCenterPoint, BackLeftDownCornerBorderCubeCenterPoint, LeftUpPrismBorderCubeCenterPoint, LeftCenterBorderCubeCenterPoint, LeftDownPrismBorderCubeCenterPoint, LeftFrontUpCornerBorderCubeCenterPoint, LeftFrontPrismBorderCubeCenterPoint, LeftFrontDownCornerBorderCubeCenterPoint };
        public static readonly Point3D[] RightCubePlane = new Point3D[9] { FrontRightUpCornerBorderCubeCenterPoint, FrontRightPrismBorderCubeCenterPoint, FrontRightDownCornerBorderCubeCenterPoint, RightUpPrismBorderCubeCenterPoint, RightCenterBorderCubeCenterPoint, RightDownPrismBorderCubeCenterPoint,RightBackUpCornerBorderCubeCenterPoint , RightBackPrismBorderCubeCenterPoint, RightBackDownCornerBorderCubeCenterPoint };
        public static readonly Point3D[] YAxisMiddleCubePlane = new Point3D[8] { LeftFrontPrismBorderCubeCenterPoint, FrontCenterBorderCubeCenterPoint, FrontRightPrismBorderCubeCenterPoint, RightCenterBorderCubeCenterPoint, RightBackPrismBorderCubeCenterPoint, BackCenterBorderCubeCenterPoint, BackLeftPrismBorderCubeCenterPoint, LeftCenterBorderCubeCenterPoint };
        public static readonly Point3D[] ZAxisMiddleCubePlane = new Point3D[8] { FrontUpPrismBorderCubeCenterPoint, FrontCenterBorderCubeCenterPoint, FrontDownPrismBorderCubeCenterPoint, DownCenterBorderCubeCenterPoint, BackDownPrismBorderCubeCenterPoint, BackCenterBorderCubeCenterPoint, BackUpPrismBorderCubeCenterPoint, UpCenterBorderCubeCenterPoint };
        public static readonly Point3D[] XAxisMiddleCubePlane = new Point3D[8] { RightUpPrismBorderCubeCenterPoint, RightCenterBorderCubeCenterPoint, RightDownPrismBorderCubeCenterPoint, DownCenterBorderCubeCenterPoint, LeftDownPrismBorderCubeCenterPoint, LeftCenterBorderCubeCenterPoint, LeftUpPrismBorderCubeCenterPoint, UpCenterBorderCubeCenterPoint };
    }
}
