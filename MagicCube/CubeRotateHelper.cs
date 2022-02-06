using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Media3D;

namespace MagicCube
{
    public class CubeRotateHelper
    {
        List<CubeRotate> cubeRotateInfo;
        public List<CubeRotate> CubeRotateInfo
        {
            get { return cubeRotateInfo; }
            set { cubeRotateInfo = value; }
        }

        public CubeRotateHelper()
        {
            cubeRotateInfo = new List<CubeRotate>();
            cubeRotateInfo.Add(new CubeRotate(CubeBasicInfo.FrontUpPrismBorderCubeName, CubeBasicInfo.FrontUpPrismBorderCubeCenterPoint, new Quaternion(), false));
            cubeRotateInfo.Add(new CubeRotate(CubeBasicInfo.FrontCenterBorderCubeName, CubeBasicInfo.FrontCenterBorderCubeCenterPoint, new Quaternion(), false));
            cubeRotateInfo.Add(new CubeRotate(CubeBasicInfo.FrontDownPrismBorderCubeName, CubeBasicInfo.FrontDownPrismBorderCubeCenterPoint, new Quaternion(), false));
            cubeRotateInfo.Add(new CubeRotate(CubeBasicInfo.FrontRightUpCornerBorderCubeName, CubeBasicInfo.FrontRightUpCornerBorderCubeCenterPoint, new Quaternion(), false));
            cubeRotateInfo.Add(new CubeRotate(CubeBasicInfo.FrontRightPrismBorderCubeName, CubeBasicInfo.FrontRightPrismBorderCubeCenterPoint, new Quaternion(), false));
            cubeRotateInfo.Add(new CubeRotate(CubeBasicInfo.FrontRightDownCornerBorderCubeName, CubeBasicInfo.FrontRightDownCornerBorderCubeCenterPoint, new Quaternion(), false));
            cubeRotateInfo.Add(new CubeRotate(CubeBasicInfo.RightUpPrismBorderCubeName, CubeBasicInfo.RightUpPrismBorderCubeCenterPoint, new Quaternion(), false));
            cubeRotateInfo.Add(new CubeRotate(CubeBasicInfo.RightCenterBorderCubeName, CubeBasicInfo.RightCenterBorderCubeCenterPoint, new Quaternion(), false));
            cubeRotateInfo.Add(new CubeRotate(CubeBasicInfo.RightDownPrismBorderCubeName, CubeBasicInfo.RightDownPrismBorderCubeCenterPoint, new Quaternion(), false));
            cubeRotateInfo.Add(new CubeRotate(CubeBasicInfo.RightBackUpCornerBorderCubeName, CubeBasicInfo.RightBackUpCornerBorderCubeCenterPoint, new Quaternion(), false));
            cubeRotateInfo.Add(new CubeRotate(CubeBasicInfo.RightBackPrismBorderCubeName, CubeBasicInfo.RightBackPrismBorderCubeCenterPoint, new Quaternion(), false));
            cubeRotateInfo.Add(new CubeRotate(CubeBasicInfo.RightBackDownCornerBorderCubeName, CubeBasicInfo.RightBackDownCornerBorderCubeCenterPoint, new Quaternion(), false));
            cubeRotateInfo.Add(new CubeRotate(CubeBasicInfo.BackUpPrismBorderCubeName, CubeBasicInfo.BackUpPrismBorderCubeCenterPoint, new Quaternion(), false));
            cubeRotateInfo.Add(new CubeRotate(CubeBasicInfo.BackCenterBorderCubeName, CubeBasicInfo.BackCenterBorderCubeCenterPoint, new Quaternion(), false));
            cubeRotateInfo.Add(new CubeRotate(CubeBasicInfo.BackDownPrismBorderCubeCubeName, CubeBasicInfo.BackDownPrismBorderCubeCenterPoint, new Quaternion(), false));
            cubeRotateInfo.Add(new CubeRotate(CubeBasicInfo.BackLeftUpCornerBorderCubeName, CubeBasicInfo.BackLeftUpCornerBorderCubeCenterPoint, new Quaternion(), false));
            cubeRotateInfo.Add(new CubeRotate(CubeBasicInfo.BackLeftPrismBorderCubeName, CubeBasicInfo.BackLeftPrismBorderCubeCenterPoint, new Quaternion(), false));
            cubeRotateInfo.Add(new CubeRotate(CubeBasicInfo.BackLeftDownCornerBorderCubeName, CubeBasicInfo.BackLeftDownCornerBorderCubeCenterPoint, new Quaternion(), false));
            cubeRotateInfo.Add(new CubeRotate(CubeBasicInfo.LeftUpPrismBorderCubeCubeName, CubeBasicInfo.LeftUpPrismBorderCubeCenterPoint, new Quaternion(), false));
            cubeRotateInfo.Add(new CubeRotate(CubeBasicInfo.LeftCenterBorderCubeName, CubeBasicInfo.LeftCenterBorderCubeCenterPoint, new Quaternion(), false));
            cubeRotateInfo.Add(new CubeRotate(CubeBasicInfo.LeftDownPrismBorderCubeName, CubeBasicInfo.LeftDownPrismBorderCubeCenterPoint, new Quaternion(), false));
            cubeRotateInfo.Add(new CubeRotate(CubeBasicInfo.LeftFrontUpCornerBorderCubeName, CubeBasicInfo.LeftFrontUpCornerBorderCubeCenterPoint, new Quaternion(), false));
            cubeRotateInfo.Add(new CubeRotate(CubeBasicInfo.LeftFrontPrismBorderCubeName, CubeBasicInfo.LeftFrontPrismBorderCubeCenterPoint, new Quaternion(), false));
            cubeRotateInfo.Add(new CubeRotate(CubeBasicInfo.LeftFrontDownCornerBorderCubeCubeName, CubeBasicInfo.LeftFrontDownCornerBorderCubeCenterPoint, new Quaternion(), false));
            cubeRotateInfo.Add(new CubeRotate(CubeBasicInfo.UpCenterBorderCubeName, CubeBasicInfo.UpCenterBorderCubeCenterPoint, new Quaternion(), false));
            cubeRotateInfo.Add(new CubeRotate(CubeBasicInfo.DownCenterBorderCubeName, CubeBasicInfo.DownCenterBorderCubeCenterPoint, new Quaternion(), false));
        }

        public void ClearRotatedPropertyValue()
        {
            cubeRotateInfo.ForEach(x => x.IsRotated = false);
        }
    }
}
