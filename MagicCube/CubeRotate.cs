using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Media3D;

namespace MagicCube
{
    public class CubeRotate
    {
        string cubeName;
        public string CubeName
        {
            get { return cubeName; }
            set { cubeName = value; }
        }

        Point3D basicCubePoint;
        public Point3D BasicCubePoint
        {
            get { return basicCubePoint; }
            set { basicCubePoint = value; }
        }

        Quaternion usedQuaternion;
        public Quaternion UsedQuaternion
        {
            get { return usedQuaternion; }
            set { usedQuaternion = value; }
        }

        public Point3D CurrentCubePoint
        {
            get 
            {
                Quaternion basicCubePointQuaternion = new Quaternion(basicCubePoint.X, basicCubePoint.Y, basicCubePoint.Z, 0);
                Quaternion usedQuaternionConjugate = usedQuaternion;
                usedQuaternionConjugate.Conjugate();
                Quaternion currentCubeRotatedQuaternion = usedQuaternion * basicCubePointQuaternion * usedQuaternionConjugate;
                return new Point3D(Convert.ToInt32(currentCubeRotatedQuaternion.X), Convert.ToInt32(currentCubeRotatedQuaternion.Y), Convert.ToInt32(currentCubeRotatedQuaternion.Z));
            }
        }

        bool isRotated;
        public bool IsRotated
        {
            get { return isRotated; }
            set { isRotated = value; }
        }

        public CubeRotate(string cubeNameArg, Point3D basicCubePointArg, Quaternion usedQuaternionArg,bool isRotatedArg)
        {
            this.cubeName = cubeNameArg;
            this.basicCubePoint = basicCubePointArg;
            this.usedQuaternion = usedQuaternionArg;
            this.isRotated = isRotatedArg;
        }
    }
}
