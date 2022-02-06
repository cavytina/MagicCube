using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
using System.Windows.Media.Media3D;

namespace MagicCube
{
    public class CubeConfiguration
    {
        public double squareWidth;
        public double SquareWidth
        {
            set { squareWidth = value; }
            get { return squareWidth; }
        }

        public double borderWidth;
        public double BorderWidth
        {
            set { borderWidth = value; }
            get { return borderWidth; }
        }

        public Point3DCollection FrontSidePoint
        {
            get
            {
                Point3DCollection ptList = new Point3DCollection();
                ptList.Add(new Point3D(-squareWidth, -squareWidth, squareWidth));
                ptList.Add(new Point3D(-squareWidth, squareWidth, squareWidth));
                ptList.Add(new Point3D(-squareWidth, squareWidth, -squareWidth));
                ptList.Add(new Point3D(-squareWidth, -squareWidth, -squareWidth));
                return ptList;
            }
        }

        public Point3DCollection BackSidePoint
        {
            get
            {
                Point3DCollection ptList = new Point3DCollection();
                ptList.Add(new Point3D(squareWidth, -squareWidth, squareWidth));
                ptList.Add(new Point3D(squareWidth, squareWidth, squareWidth));
                ptList.Add(new Point3D(squareWidth, squareWidth, -squareWidth));
                ptList.Add(new Point3D(squareWidth, -squareWidth, -squareWidth));
                return ptList;
            }
        }

        public Point3DCollection LeftSidePoint
        {
            get
            {
                Point3DCollection ptList = new Point3DCollection();
                ptList.Add(new Point3D(-squareWidth, -squareWidth, -squareWidth));
                ptList.Add(new Point3D(-squareWidth, squareWidth, -squareWidth));
                ptList.Add(new Point3D(squareWidth, squareWidth, -squareWidth));
                ptList.Add(new Point3D(squareWidth, -squareWidth, -squareWidth));
                return ptList;
            }
        }

        public Point3DCollection RightSidePoint
        {
            get
            {
                Point3DCollection ptList = new Point3DCollection();
                ptList.Add(new Point3D(-squareWidth, -squareWidth, squareWidth));
                ptList.Add(new Point3D(-squareWidth, squareWidth, squareWidth));
                ptList.Add(new Point3D(squareWidth, squareWidth, squareWidth));
                ptList.Add(new Point3D(squareWidth, -squareWidth, squareWidth));
                return ptList;
            }
        }

        public Point3DCollection UpSidePoint
        {
            get
            {
                Point3DCollection ptList = new Point3DCollection();
                ptList.Add(new Point3D(-squareWidth, squareWidth, squareWidth));
                ptList.Add(new Point3D(squareWidth, squareWidth, squareWidth));
                ptList.Add(new Point3D(squareWidth, squareWidth, -squareWidth));
                ptList.Add(new Point3D(-squareWidth, squareWidth, -squareWidth));
                return ptList;
            }
        }

        public Point3DCollection DownSidePoint
        {
            get
            {
                Point3DCollection ptList = new Point3DCollection();
                ptList.Add(new Point3D(-squareWidth, -squareWidth, squareWidth));
                ptList.Add(new Point3D(squareWidth, -squareWidth, squareWidth));
                ptList.Add(new Point3D(squareWidth, -squareWidth, -squareWidth));
                ptList.Add(new Point3D(-squareWidth, -squareWidth, -squareWidth));
                return ptList;
            }
        }

        public Point3DCollection FrontCenterSidePoint
        {
            get
            {
                Point3DCollection ptList = new Point3DCollection();
                ptList.Add(new Point3D(-squareWidth, -squareWidth + borderWidth, squareWidth - borderWidth));
                ptList.Add(new Point3D(-squareWidth, squareWidth - borderWidth, squareWidth - borderWidth));
                ptList.Add(new Point3D(-squareWidth, squareWidth - borderWidth, -squareWidth + borderWidth));
                ptList.Add(new Point3D(-squareWidth, -squareWidth + borderWidth, -squareWidth + borderWidth));
                return ptList;
            }
        }

        public Point3DCollection FrontSideRightUpCornerBorderPoint
        {
            get
            {
                Point3DCollection ptList = new Point3DCollection();
                ptList.Add(new Point3D(-squareWidth, squareWidth, squareWidth - borderWidth));
                ptList.Add(new Point3D(-squareWidth, -squareWidth + borderWidth, squareWidth - borderWidth));
                ptList.Add(new Point3D(-squareWidth, -squareWidth + borderWidth, squareWidth));
                ptList.Add(new Point3D(-squareWidth, squareWidth, squareWidth));
                return ptList;
            }
        }

        public Point3DCollection FrontSideUpLeftCornerBorderPoint
        {
            get
            {
                Point3DCollection ptList = new Point3DCollection();
                ptList.Add(new Point3D(-squareWidth, squareWidth, -squareWidth));
                ptList.Add(new Point3D(-squareWidth, squareWidth - borderWidth, -squareWidth));
                ptList.Add(new Point3D(-squareWidth, squareWidth - borderWidth, squareWidth - borderWidth));
                ptList.Add(new Point3D(-squareWidth, squareWidth, squareWidth - borderWidth));
                return ptList;
            }
        }

        public Point3DCollection FrontSideLeftDownCornerBorderPoint
        {
            get
            {
                Point3DCollection ptList = new Point3DCollection();
                ptList.Add(new Point3D(-squareWidth, squareWidth - borderWidth, -squareWidth));
                ptList.Add(new Point3D(-squareWidth, -squareWidth, -squareWidth));
                ptList.Add(new Point3D(-squareWidth, -squareWidth, -squareWidth + borderWidth));
                ptList.Add(new Point3D(-squareWidth, squareWidth - borderWidth, -squareWidth + borderWidth));
                return ptList;
            }
        }

        public Point3DCollection FrontSideDownRightCornerBorderPoint
        {
            get
            {
                Point3DCollection ptList = new Point3DCollection();
                ptList.Add(new Point3D(-squareWidth, -squareWidth + borderWidth, -squareWidth + borderWidth));
                ptList.Add(new Point3D(-squareWidth, -squareWidth, -squareWidth + borderWidth));
                ptList.Add(new Point3D(-squareWidth, -squareWidth, squareWidth));
                ptList.Add(new Point3D(-squareWidth, -squareWidth + borderWidth, squareWidth));
                return ptList;
            }
        }

        public Point3DCollection BackCenterSidePoint
        {
            get
            {
                Point3DCollection ptList = new Point3DCollection();
                ptList.Add(new Point3D(squareWidth, -squareWidth + borderWidth, squareWidth - borderWidth));
                ptList.Add(new Point3D(squareWidth, squareWidth - borderWidth, squareWidth - borderWidth));
                ptList.Add(new Point3D(squareWidth, squareWidth - borderWidth, -squareWidth + borderWidth));
                ptList.Add(new Point3D(squareWidth, -squareWidth + borderWidth, -squareWidth + borderWidth));
                return ptList;
            }
        }

        public Point3DCollection BackSideRightUpCornerBorderPoint
        {
            get
            {
                Point3DCollection ptList = new Point3DCollection();
                ptList.Add(new Point3D(squareWidth, squareWidth, squareWidth - borderWidth));
                ptList.Add(new Point3D(squareWidth, -squareWidth + borderWidth, squareWidth - borderWidth));
                ptList.Add(new Point3D(squareWidth, -squareWidth + borderWidth, squareWidth));
                ptList.Add(new Point3D(squareWidth, squareWidth, squareWidth));
                return ptList;
            }
        }

        public Point3DCollection BackSideUpLeftCornerBorderPoint
        {
            get
            {
                Point3DCollection ptList = new Point3DCollection();
                ptList.Add(new Point3D(squareWidth, squareWidth, -squareWidth));
                ptList.Add(new Point3D(squareWidth, squareWidth - borderWidth, -squareWidth));
                ptList.Add(new Point3D(squareWidth, squareWidth - borderWidth, squareWidth - borderWidth));
                ptList.Add(new Point3D(squareWidth, squareWidth, squareWidth - borderWidth));
                return ptList;
            }
        }

        public Point3DCollection BackSideLeftDownCornerBorderPoint
        {
            get
            {
                Point3DCollection ptList = new Point3DCollection();
                ptList.Add(new Point3D(squareWidth, squareWidth - borderWidth, -squareWidth));
                ptList.Add(new Point3D(squareWidth, -squareWidth, -squareWidth));
                ptList.Add(new Point3D(squareWidth, -squareWidth, -squareWidth + borderWidth));
                ptList.Add(new Point3D(squareWidth, squareWidth - borderWidth, -squareWidth + borderWidth));
                return ptList;
            }
        }

        public Point3DCollection BackSideDownRightCornerBorderPoint
        {
            get
            {
                Point3DCollection ptList = new Point3DCollection();
                ptList.Add(new Point3D(squareWidth, -squareWidth + borderWidth, -squareWidth + borderWidth));
                ptList.Add(new Point3D(squareWidth, -squareWidth, -squareWidth + borderWidth));
                ptList.Add(new Point3D(squareWidth, -squareWidth, squareWidth));
                ptList.Add(new Point3D(squareWidth, -squareWidth + borderWidth, squareWidth));
                return ptList;
            }
        }

        public Point3DCollection LeftCenterSidePoint
        {
            get
            {
                Point3DCollection ptList = new Point3DCollection();
                ptList.Add(new Point3D(-squareWidth + borderWidth, squareWidth - borderWidth, -squareWidth));
                ptList.Add(new Point3D(squareWidth - borderWidth, squareWidth - borderWidth, -squareWidth));
                ptList.Add(new Point3D(squareWidth - borderWidth, -squareWidth + borderWidth, -squareWidth));
                ptList.Add(new Point3D(-squareWidth + borderWidth, -squareWidth + borderWidth, -squareWidth));
                return ptList;
            }
        }

        public Point3DCollection LeftSideRightUpCornerBorderPoint
        {
            get
            {
                Point3DCollection ptList = new Point3DCollection();
                ptList.Add(new Point3D(squareWidth, squareWidth - borderWidth, -squareWidth));
                ptList.Add(new Point3D(-squareWidth + borderWidth, squareWidth - borderWidth, -squareWidth));
                ptList.Add(new Point3D(-squareWidth + borderWidth, squareWidth, -squareWidth));
                ptList.Add(new Point3D(squareWidth, squareWidth, -squareWidth));
                return ptList;
            }
        }

        public Point3DCollection LeftSideUpLeftCornerBorderPoint
        {
            get
            {
                Point3DCollection ptList = new Point3DCollection();
                ptList.Add(new Point3D(squareWidth, -squareWidth, -squareWidth));
                ptList.Add(new Point3D(squareWidth - borderWidth, -squareWidth, -squareWidth));
                ptList.Add(new Point3D(squareWidth - borderWidth, squareWidth - borderWidth, -squareWidth));
                ptList.Add(new Point3D(squareWidth, squareWidth - borderWidth, -squareWidth));
                return ptList;
            }
        }

        public Point3DCollection LeftSideLeftDownCornerBorderPoint
        {
            get
            {
                Point3DCollection ptList = new Point3DCollection();
                ptList.Add(new Point3D(squareWidth - borderWidth, -squareWidth, -squareWidth));
                ptList.Add(new Point3D(-squareWidth, -squareWidth, -squareWidth));
                ptList.Add(new Point3D(-squareWidth, -squareWidth + borderWidth, -squareWidth));
                ptList.Add(new Point3D(squareWidth - borderWidth, -squareWidth + borderWidth, -squareWidth));
                return ptList;
            }
        }

        public Point3DCollection LeftSideDownRightCornerBorderPoint
        {
            get
            {
                Point3DCollection ptList = new Point3DCollection();
                ptList.Add(new Point3D(-squareWidth + borderWidth, -squareWidth + borderWidth, -squareWidth));
                ptList.Add(new Point3D(-squareWidth, -squareWidth + borderWidth, -squareWidth));
                ptList.Add(new Point3D(-squareWidth, squareWidth, -squareWidth));
                ptList.Add(new Point3D(-squareWidth + borderWidth, squareWidth, -squareWidth));
                return ptList;
            }
        }

        public Point3DCollection RightCenterSidePoint
        {
            get
            {
                Point3DCollection ptList = new Point3DCollection();
                ptList.Add(new Point3D(-squareWidth + borderWidth, squareWidth - borderWidth, squareWidth));
                ptList.Add(new Point3D(squareWidth - borderWidth, squareWidth - borderWidth, squareWidth));
                ptList.Add(new Point3D(squareWidth - borderWidth, -squareWidth + borderWidth, squareWidth));
                ptList.Add(new Point3D(-squareWidth + borderWidth, -squareWidth + borderWidth, squareWidth));
                return ptList;
            }
        }

        public Point3DCollection RightSideRightUpCornerBorderPoint
        {
            get
            {
                Point3DCollection ptList = new Point3DCollection();
                ptList.Add(new Point3D(squareWidth, squareWidth - borderWidth, squareWidth));
                ptList.Add(new Point3D(-squareWidth + borderWidth, squareWidth - borderWidth, squareWidth));
                ptList.Add(new Point3D(-squareWidth + borderWidth, squareWidth, squareWidth));
                ptList.Add(new Point3D(squareWidth, squareWidth, squareWidth));
                return ptList;
            }
        }

        public Point3DCollection RightSideUpLeftCornerBorderPoint
        {
            get
            {
                Point3DCollection ptList = new Point3DCollection();
                ptList.Add(new Point3D(squareWidth, -squareWidth, squareWidth));
                ptList.Add(new Point3D(squareWidth - borderWidth, -squareWidth, squareWidth));
                ptList.Add(new Point3D(squareWidth - borderWidth, squareWidth - borderWidth, squareWidth));
                ptList.Add(new Point3D(squareWidth, squareWidth - borderWidth, squareWidth));
                return ptList;
            }
        }

        public Point3DCollection RightSideLeftDownCornerBorderPoint
        {
            get
            {
                Point3DCollection ptList = new Point3DCollection();
                ptList.Add(new Point3D(squareWidth - borderWidth, -squareWidth, squareWidth));
                ptList.Add(new Point3D(-squareWidth, -squareWidth, squareWidth));
                ptList.Add(new Point3D(-squareWidth, -squareWidth + borderWidth, squareWidth));
                ptList.Add(new Point3D(squareWidth - borderWidth, -squareWidth + borderWidth, squareWidth));
                return ptList;
            }
        }

        public Point3DCollection RightSideDownRightCornerBorderPoint
        {
            get
            {
                Point3DCollection ptList = new Point3DCollection();
                ptList.Add(new Point3D(-squareWidth + borderWidth, -squareWidth + borderWidth, squareWidth));
                ptList.Add(new Point3D(-squareWidth, -squareWidth + borderWidth, squareWidth));
                ptList.Add(new Point3D(-squareWidth, squareWidth, squareWidth));
                ptList.Add(new Point3D(-squareWidth + borderWidth, squareWidth, squareWidth));
                return ptList;
            }
        }

        public Point3DCollection UpCenterSidePoint
        {
            get
            {
                Point3DCollection ptList = new Point3DCollection();
                ptList.Add(new Point3D(-squareWidth + borderWidth, squareWidth, squareWidth - borderWidth));
                ptList.Add(new Point3D(squareWidth - borderWidth, squareWidth, squareWidth - borderWidth));
                ptList.Add(new Point3D(squareWidth - borderWidth, squareWidth, -squareWidth + borderWidth));
                ptList.Add(new Point3D(-squareWidth + borderWidth, squareWidth, -squareWidth + borderWidth));
                return ptList;
            }
        }

        public Point3DCollection UpSideRightUpCornerBorderPoint
        {
            get
            {
                Point3DCollection ptList = new Point3DCollection();
                ptList.Add(new Point3D(squareWidth, squareWidth, squareWidth - borderWidth));
                ptList.Add(new Point3D(-squareWidth + borderWidth, squareWidth, squareWidth - borderWidth));
                ptList.Add(new Point3D(-squareWidth + borderWidth, squareWidth, squareWidth));
                ptList.Add(new Point3D(squareWidth, squareWidth, squareWidth));
                return ptList;
            }
        }

        public Point3DCollection UpSideUpLeftCornerBorderPoint
        {
            get
            {
                Point3DCollection ptList = new Point3DCollection();
                ptList.Add(new Point3D(squareWidth, squareWidth, -squareWidth));
                ptList.Add(new Point3D(squareWidth - borderWidth, squareWidth, -squareWidth));
                ptList.Add(new Point3D(squareWidth - borderWidth, squareWidth, squareWidth - borderWidth));
                ptList.Add(new Point3D(squareWidth, squareWidth, squareWidth - borderWidth));
                return ptList;
            }
        }

        public Point3DCollection UpSideLeftDownCornerBorderPoint
        {
            get
            {
                Point3DCollection ptList = new Point3DCollection();
                ptList.Add(new Point3D(squareWidth - borderWidth, squareWidth, -squareWidth));
                ptList.Add(new Point3D(-squareWidth, squareWidth, -squareWidth));
                ptList.Add(new Point3D(-squareWidth, squareWidth, -squareWidth + borderWidth));
                ptList.Add(new Point3D(squareWidth - borderWidth, squareWidth, -squareWidth + borderWidth));
                return ptList;
            }
        }

        public Point3DCollection UpSideDownRightCornerBorderPoint
        {
            get
            {
                Point3DCollection ptList = new Point3DCollection();
                ptList.Add(new Point3D(-squareWidth + borderWidth, squareWidth, -squareWidth + borderWidth));
                ptList.Add(new Point3D(-squareWidth, squareWidth, -squareWidth + borderWidth));
                ptList.Add(new Point3D(-squareWidth, squareWidth, squareWidth));
                ptList.Add(new Point3D(-squareWidth + borderWidth, squareWidth, squareWidth));
                return ptList;
            }
        }

        public Point3DCollection DownCenterSidePoint
        {
            get
            {
                Point3DCollection ptList = new Point3DCollection();
                ptList.Add(new Point3D(-squareWidth + borderWidth, -squareWidth, squareWidth - borderWidth));
                ptList.Add(new Point3D(squareWidth - borderWidth, -squareWidth, squareWidth - borderWidth));
                ptList.Add(new Point3D(squareWidth - borderWidth, -squareWidth, -squareWidth + borderWidth));
                ptList.Add(new Point3D(-squareWidth + borderWidth, -squareWidth, -squareWidth + borderWidth));
                return ptList;
            }
        }

        public Point3DCollection DownSideRightUpCornerBorderPoint
        {
            get
            {
                Point3DCollection ptList = new Point3DCollection();
                ptList.Add(new Point3D(squareWidth, -squareWidth, squareWidth - borderWidth));
                ptList.Add(new Point3D(-squareWidth + borderWidth, -squareWidth, squareWidth - borderWidth));
                ptList.Add(new Point3D(-squareWidth + borderWidth, -squareWidth, squareWidth));
                ptList.Add(new Point3D(squareWidth, -squareWidth, squareWidth));
                return ptList;
            }
        }

        public Point3DCollection DownSideUpLeftCornerBorderPoint
        {
            get
            {
                Point3DCollection ptList = new Point3DCollection();
                ptList.Add(new Point3D(squareWidth, -squareWidth, -squareWidth));
                ptList.Add(new Point3D(squareWidth - borderWidth, -squareWidth, -squareWidth));
                ptList.Add(new Point3D(squareWidth - borderWidth, -squareWidth, squareWidth - borderWidth));
                ptList.Add(new Point3D(squareWidth, -squareWidth, squareWidth - borderWidth));
                return ptList;
            }
        }

        public Point3DCollection DownSideLeftDownCornerBorderPoint
        {
            get
            {
                Point3DCollection ptList = new Point3DCollection();
                ptList.Add(new Point3D(squareWidth - borderWidth, -squareWidth, -squareWidth));
                ptList.Add(new Point3D(-squareWidth, -squareWidth, -squareWidth));
                ptList.Add(new Point3D(-squareWidth, -squareWidth, -squareWidth + borderWidth));
                ptList.Add(new Point3D(squareWidth - borderWidth, -squareWidth, -squareWidth + borderWidth));
                return ptList;
            }
        }

        public Point3DCollection DownSideDownRightCornerBorderPoint
        {
            get
            {
                Point3DCollection ptList = new Point3DCollection();
                ptList.Add(new Point3D(-squareWidth + borderWidth, -squareWidth, -squareWidth + borderWidth));
                ptList.Add(new Point3D(-squareWidth, -squareWidth, -squareWidth + borderWidth));
                ptList.Add(new Point3D(-squareWidth, -squareWidth, squareWidth));
                ptList.Add(new Point3D(-squareWidth + borderWidth, -squareWidth, squareWidth));
                return ptList;
            }
        }
    }
}
