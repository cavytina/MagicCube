using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Media3D;

namespace MagicCube
{
    public class SelectionOperationHelper
    {
        string selectionCubeName;
        public string SelectionCubeName
        {
            set { selectionCubeName = value; }
            get { return selectionCubeName; }
        }

        Point3D selectionCubePoint;
        public Point3D SelectionCubePoint
        {
            set { selectionCubePoint = value; }
            get { return selectionCubePoint; }
        }

        Quaternion selectionAixs;
        public Quaternion SelectionAixs
        {
            set { selectionAixs = value; }
            get { return selectionAixs; }
        }

        public void ClearAllPropertyValue()
        {
            selectionCubeName = string.Empty;
            selectionCubePoint = new Point3D();
            selectionAixs = new Quaternion();
        }
    }
}
