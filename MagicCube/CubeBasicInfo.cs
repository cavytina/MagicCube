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
        public static readonly string FrontUpPrismBorderCubeName = "FrontUpPrismBorderCube";
        public static readonly string FrontUpPrismBorderCubeRotateName = "FrontUpPrismBorderCubeRotate";
        public static readonly Point3D FrontUpPrismBorderCubeCenterPoint = new Point3D(-1, 1, 0);

        public static readonly string FrontCenterBorderCubeName = "FrontCenterBorderCube";
        public static readonly string FrontCenterBorderCubeRotateName = "FrontCenterBorderCubeRotate";
        public static readonly Point3D FrontCenterBorderCubeCenterPoint = new Point3D(-1, 0, 0);

        public static readonly string FrontDownPrismBorderCubeName = "FrontDownPrismBorderCube";
        public static readonly string FrontDownPrismBorderCubeRotateName = "FrontDownPrismBorderCubeRotate";
        public static readonly Point3D FrontDownPrismBorderCubeCenterPoint = new Point3D(-1, -1, 0);

        public static readonly string FrontRightUpCornerBorderCubeName = "FrontRightUpCornerBorderCube";
        public static readonly string FrontRightUpCornerBorderCubeRotateName = "FrontRightUpCornerBorderCubeRotate";
        public static readonly Point3D FrontRightUpCornerBorderCubeCenterPoint = new Point3D(-1, 1, 1);

        public static readonly string FrontRightPrismBorderCubeName = "FrontRightPrismBorderCube";
        public static readonly string FrontRightPrismBorderCubeRotateName = "FrontRightPrismBorderCubeRotate";
        public static readonly Point3D FrontRightPrismBorderCubeCenterPoint = new Point3D(-1, 0, 1);

        public static readonly string FrontRightDownCornerBorderCubeName = "FrontRightDownCornerBorderCube";
        public static readonly string FrontRightDownCornerBorderCubeRotateName = "FrontRightDownCornerBorderCubeRotate";
        public static readonly Point3D FrontRightDownCornerBorderCubeCenterPoint = new Point3D(-1, -1, 1);

        public static readonly string RightUpPrismBorderCubeName = "RightUpPrismBorderCube";
        public static readonly string RightUpPrismBorderCubeRotateName = "RightUpPrismBorderCubeRotate";
        public static readonly Point3D RightUpPrismBorderCubeCenterPoint = new Point3D(0, 1, 1);

        public static readonly string RightCenterBorderCubeName = "RightCenterBorderCube";
        public static readonly string RightCenterBorderCubeRotateName = "RightCenterBorderCubeRotate";
        public static readonly Point3D RightCenterBorderCubeCenterPoint = new Point3D(0, 0, 1);

        public static readonly string RightDownPrismBorderCubeName = "RightDownPrismBorderCube";
        public static readonly string RightDownPrismBorderCubeRotateName = "RightDownPrismBorderCubeRotate";
        public static readonly Point3D RightDownPrismBorderCubeCenterPoint = new Point3D(0, -1, 1);

        public static readonly string RightBackUpCornerBorderCubeName = "RightBackUpCornerBorderCube";
        public static readonly string RightBackUpCornerBorderCubeRotateName = "RightBackUpCornerBorderCubeRotate";
        public static readonly Point3D RightBackUpCornerBorderCubeCenterPoint = new Point3D(1, 1, 1);

        public static readonly string RightBackPrismBorderCubeName = "RightBackPrismBorderCube";
        public static readonly string RightBackPrismBorderCubeRotateName = "RightBackPrismBorderCubeRotate";
        public static readonly Point3D RightBackPrismBorderCubeCenterPoint = new Point3D(1, 0, 1);

        public static readonly string RightBackDownCornerBorderCubeName = "RightBackDownCornerBorderCube";
        public static readonly string RightBackDownCornerBorderCubeRotateName = "RightBackDownCornerBorderCubeRotate";
        public static readonly Point3D RightBackDownCornerBorderCubeCenterPoint = new Point3D(1, -1, 1);

        public static readonly string BackUpPrismBorderCubeName = "BackUpPrismBorderCube";
        public static readonly string BackUpPrismBorderCubeRotateName = "BackUpPrismBorderCubeRotate";
        public static readonly Point3D BackUpPrismBorderCubeCenterPoint = new Point3D(1, 1, 0);

        public static readonly string BackCenterBorderCubeName = "BackCenterBorderCube";
        public static readonly string BackCenterBorderCubeRotateName = "BackCenterBorderCubeRotate";
        public static readonly Point3D BackCenterBorderCubeCenterPoint = new Point3D(1, 0, 0);

        public static readonly string BackDownPrismBorderCubeCubeName = "BackDownPrismBorderCube";
        public static readonly string BackDownPrismBorderCubeRotateName = "BackDownPrismBorderCubeRotate";
        public static readonly Point3D BackDownPrismBorderCubeCenterPoint = new Point3D(1, -1, 0);

        public static readonly string BackLeftUpCornerBorderCubeName = "BackLeftUpCornerBorderCube";
        public static readonly string BackLeftUpCornerBorderCubeRotateName = "BackLeftUpCornerBorderCubeRotate";
        public static readonly Point3D BackLeftUpCornerBorderCubeCenterPoint = new Point3D(1, 1, -1);

        public static readonly string BackLeftPrismBorderCubeName = "BackLeftPrismBorderCube";
        public static readonly string BackLeftPrismBorderCubeRotateName = "BackLeftPrismBorderCube";
        public static readonly Point3D BackLeftPrismBorderCubeCenterPoint = new Point3D(1, 0, -1);

        public static readonly string BackLeftDownCornerBorderCubeName = "BackLeftDownCornerBorderCube";
        public static readonly string BackLeftDownCornerBorderCubeRotateName = "BackLeftDownCornerBorderCubeRotate";
        public static readonly Point3D BackLeftDownCornerBorderCubeCenterPoint = new Point3D(1, -1, -1);

        public static readonly string LeftUpPrismBorderCubeCubeName = "LeftUpPrismBorderCube";
        public static readonly string LeftUpPrismBorderCubeRotateName = "LeftUpPrismBorderCubeRotate";
        public static readonly Point3D LeftUpPrismBorderCubeCenterPoint = new Point3D(0, 1, -1);

        public static readonly string LeftCenterBorderCubeName = "LeftCenterBorderCube";
        public static readonly string LeftCenterBorderCubeRotateName = "LeftCenterBorderCubeRotate";
        public static readonly Point3D LeftCenterBorderCubeCenterPoint = new Point3D(0, 0, -1);

        public static readonly string LeftDownPrismBorderCubeName = "LeftDownPrismBorderCube";
        public static readonly string LeftDownPrismBorderCubeRotateName = "LeftDownPrismBorderCubeRotate";
        public static readonly Point3D LeftDownPrismBorderCubeCenterPoint = new Point3D(0, -1, -1);

        public static readonly string LeftFrontUpCornerBorderCubeName = "LeftFrontUpCornerBorderCube";
        public static readonly string LeftFrontUpCornerBorderCubeRotateName = "LeftFrontUpCornerBorderCubeRotate";
        public static readonly Point3D LeftFrontUpCornerBorderCubeCenterPoint = new Point3D(-1, 1, -1);

        public static readonly string LeftFrontPrismBorderCubeName = "LeftFrontPrismBorderCube";
        public static readonly string LeftFrontPrismBorderCubeRotateName = "LeftFrontPrismBorderCubeRotate";
        public static readonly Point3D LeftFrontPrismBorderCubeCenterPoint = new Point3D(-1, 0, -1);

        public static readonly string LeftFrontDownCornerBorderCubeCubeName = "LeftFrontDownCornerBorderCube";
        public static readonly string LeftFrontDownCornerBorderCubeRotateName = "LeftFrontDownCornerBorderCubeRotate";
        public static readonly Point3D LeftFrontDownCornerBorderCubeCenterPoint = new Point3D(-1, -1, -1);

        public static readonly string UpCenterBorderCubeName = "UpCenterBorderCube";
        public static readonly string UpCenterBorderCubeRotateName = "UpCenterBorderCubeRotate";
        public static readonly Point3D UpCenterBorderCubeCenterPoint = new Point3D(0, 1, 0);

        public static readonly string DownCenterBorderCubeName = "DownCenterBorderCube";
        public static readonly string DownCenterBorderCubeRotateName = "DownCenterBorderCubeRotate";
        public static readonly Point3D DownCenterBorderCubeCenterPoint = new Point3D(0, -1, 0);
    }
}
