using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Media.Animation;
using System.Windows.Media.Media3D;
using Petzold.Media3D;

namespace MagicCube
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        CubeRotateHelper cubeRotateHelper;
        SelectionOperationHelper selectionOperationHelper;
        PlaneRotateHelper planeRotateHelper;
        Storyboard storyBoard;
        Rotation3DAnimation cubeAnimation;

        public MainWindow()
        {
            InitializeComponent();
            storyBoard = new Storyboard();
            cubeRotateHelper = new CubeRotateHelper();
            selectionOperationHelper = new SelectionOperationHelper();
            planeRotateHelper = new PlaneRotateHelper();
        }

        private void OnAiesMouseLeftButtonDown(object obj, MouseButtonEventArgs args)
        {
            Point pt = args.GetPosition(viewPortAixs);
            VisualTreeHelper.HitTest(viewPortAixs, null, AixsLeftHitTestDown, new PointHitTestParameters(pt));
        }

        private void OnAiesMouseRightButtonDown(object obj, MouseButtonEventArgs args)
        {
            Point pt = args.GetPosition(viewPortAixs);
            VisualTreeHelper.HitTest(viewPortAixs, null, AixsRightHitTestDown, new PointHitTestParameters(pt));
        }

        private void OnCubeMouseLeftButtonDown(object obj, MouseButtonEventArgs args)
        {
            Point pt = args.GetPosition(viewPortCube);
            VisualTreeHelper.HitTest(viewPortCube, null, CubeHitTestDown, new PointHitTestParameters(pt));
        }

        HitTestResultBehavior AixsLeftHitTestDown(HitTestResult result)
        {
            RayMeshGeometry3DHitTestResult resultMesh = result as RayMeshGeometry3DHitTestResult;

            if (resultMesh == null)
                return HitTestResultBehavior.Continue;

            Cylinder vis = resultMesh.VisualHit as Cylinder;

            if (vis == null)
                return HitTestResultBehavior.Continue;

            if (vis.Name == "YaxisTail" || vis.Name == "YaxisHead")
            {
                RotateCubePlane(selectionOperationHelper.SelectionCubePoint,CubeBasicInfo.YPositiveQuaternionRotation );
                return HitTestResultBehavior.Stop;
            }
            else if (vis.Name == "XaxisTail" || vis.Name == "XaxisHead")
            {
                RotateCubePlane(selectionOperationHelper.SelectionCubePoint, CubeBasicInfo.XPositiveQuaternionRotation);
                return HitTestResultBehavior.Stop;
            }
            else if (vis.Name == "ZaxisTail" || vis.Name == "ZaxisHead")
            {
                RotateCubePlane(selectionOperationHelper.SelectionCubePoint, CubeBasicInfo.ZPositiveQuaternionRotation);
                return HitTestResultBehavior.Stop;
            }

            return HitTestResultBehavior.Continue;
        }

        HitTestResultBehavior AixsRightHitTestDown(HitTestResult result)
        {
            RayMeshGeometry3DHitTestResult resultMesh = result as RayMeshGeometry3DHitTestResult;

            if (resultMesh == null)
                return HitTestResultBehavior.Continue;

            Cylinder vis = resultMesh.VisualHit as Cylinder;

            if (vis == null)
                return HitTestResultBehavior.Continue;

            if (vis.Name == "YaxisTail" || vis.Name == "YaxisHead")
            {
                RotateCubePlane(selectionOperationHelper.SelectionCubePoint, CubeBasicInfo.YNagativeQuaternionRotation);
                return HitTestResultBehavior.Stop;
            }
            else if (vis.Name == "XaxisTail" || vis.Name == "XaxisHead")
            {
                RotateCubePlane(selectionOperationHelper.SelectionCubePoint, CubeBasicInfo.XNagativeQuaternionRotation);
                return HitTestResultBehavior.Stop;
            }
            else if (vis.Name == "ZaxisTail" || vis.Name == "ZaxisHead")
            {
                RotateCubePlane(selectionOperationHelper.SelectionCubePoint, CubeBasicInfo.ZNagativeQuaternionRotation);
                return HitTestResultBehavior.Stop;
            }

            return HitTestResultBehavior.Continue;
        }

        HitTestResultBehavior CubeHitTestDown(HitTestResult result)
        {
            RayMeshGeometry3DHitTestResult resultMesh = result as RayMeshGeometry3DHitTestResult;

            if (resultMesh == null)
                return HitTestResultBehavior.Continue;

            ModelVisual3D vis = resultMesh.VisualHit as ModelVisual3D;

            if (vis == null)
                return HitTestResultBehavior.Continue;

            if (vis == (viewPortCube.FindName(CubeBasicInfo.FrontUpPrismBorderCubeName) as ModelVisual3D))
            {
                selectionOperationHelper.SelectionCubeName = CubeBasicInfo.FrontUpPrismBorderCubeName;
                selectionOperationHelper.SelectionCubePoint = cubeRotateHelper.CubeRotateInfo.Find(x => x.CubeName == CubeBasicInfo.FrontUpPrismBorderCubeName).CurrentCubePoint;
                return HitTestResultBehavior.Stop;
            }
            else if (vis == (viewPortCube.FindName(CubeBasicInfo.FrontCenterBorderCubeName) as ModelVisual3D))
            {
                selectionOperationHelper.SelectionCubeName = CubeBasicInfo.FrontCenterBorderCubeName;
                selectionOperationHelper.SelectionCubePoint = cubeRotateHelper.CubeRotateInfo.Find(x => x.CubeName == CubeBasicInfo.FrontCenterBorderCubeName).CurrentCubePoint;
                return HitTestResultBehavior.Stop;
            }
            else if (vis == (viewPortCube.FindName(CubeBasicInfo.FrontDownPrismBorderCubeName) as ModelVisual3D))
            {
                selectionOperationHelper.SelectionCubeName = CubeBasicInfo.FrontDownPrismBorderCubeName;
                selectionOperationHelper.SelectionCubePoint = cubeRotateHelper.CubeRotateInfo.Find(x => x.CubeName == CubeBasicInfo.FrontDownPrismBorderCubeName).CurrentCubePoint;
                return HitTestResultBehavior.Stop;
            }
            else if (vis == (viewPortCube.FindName(CubeBasicInfo.FrontRightUpCornerBorderCubeName) as ModelVisual3D))
            {
                selectionOperationHelper.SelectionCubeName = CubeBasicInfo.FrontRightUpCornerBorderCubeName;
                selectionOperationHelper.SelectionCubePoint = cubeRotateHelper.CubeRotateInfo.Find(x => x.CubeName == CubeBasicInfo.FrontRightUpCornerBorderCubeName).CurrentCubePoint;
                return HitTestResultBehavior.Stop;
            }
            else if (vis == (viewPortCube.FindName(CubeBasicInfo.FrontRightPrismBorderCubeName) as ModelVisual3D))
            {
                selectionOperationHelper.SelectionCubeName = CubeBasicInfo.FrontRightPrismBorderCubeName;
                selectionOperationHelper.SelectionCubePoint = cubeRotateHelper.CubeRotateInfo.Find(x => x.CubeName == CubeBasicInfo.FrontRightPrismBorderCubeName).CurrentCubePoint;
                return HitTestResultBehavior.Stop;
            }
            else if (vis == (viewPortCube.FindName(CubeBasicInfo.FrontRightDownCornerBorderCubeName) as ModelVisual3D))
            {
                selectionOperationHelper.SelectionCubeName = CubeBasicInfo.FrontRightDownCornerBorderCubeName;
                selectionOperationHelper.SelectionCubePoint = cubeRotateHelper.CubeRotateInfo.Find(x => x.CubeName == CubeBasicInfo.FrontRightDownCornerBorderCubeName).CurrentCubePoint;
                return HitTestResultBehavior.Stop;
            }
            else if (vis == (viewPortCube.FindName(CubeBasicInfo.RightUpPrismBorderCubeName) as ModelVisual3D))
            {
                selectionOperationHelper.SelectionCubeName = CubeBasicInfo.RightUpPrismBorderCubeName;
                selectionOperationHelper.SelectionCubePoint = cubeRotateHelper.CubeRotateInfo.Find(x => x.CubeName == CubeBasicInfo.RightUpPrismBorderCubeName).CurrentCubePoint;
                return HitTestResultBehavior.Stop;
            }
            else if (vis == (viewPortCube.FindName(CubeBasicInfo.RightCenterBorderCubeName) as ModelVisual3D))
            {
                selectionOperationHelper.SelectionCubeName = CubeBasicInfo.RightCenterBorderCubeName;
                selectionOperationHelper.SelectionCubePoint = cubeRotateHelper.CubeRotateInfo.Find(x => x.CubeName == CubeBasicInfo.RightCenterBorderCubeName).CurrentCubePoint;
                return HitTestResultBehavior.Stop;
            }
            else if (vis == (viewPortCube.FindName(CubeBasicInfo.RightDownPrismBorderCubeName) as ModelVisual3D))
            {
                selectionOperationHelper.SelectionCubeName = CubeBasicInfo.RightDownPrismBorderCubeName;
                selectionOperationHelper.SelectionCubePoint = cubeRotateHelper.CubeRotateInfo.Find(x => x.CubeName == CubeBasicInfo.RightDownPrismBorderCubeName).CurrentCubePoint;
                return HitTestResultBehavior.Stop;
            }
            else if (vis == (viewPortCube.FindName(CubeBasicInfo.RightBackUpCornerBorderCubeName) as ModelVisual3D))
            {
                selectionOperationHelper.SelectionCubeName = CubeBasicInfo.RightBackUpCornerBorderCubeName;
                selectionOperationHelper.SelectionCubePoint = cubeRotateHelper.CubeRotateInfo.Find(x => x.CubeName == CubeBasicInfo.RightBackUpCornerBorderCubeName).CurrentCubePoint;
                return HitTestResultBehavior.Stop;
            }
            else if (vis == (viewPortCube.FindName(CubeBasicInfo.RightBackPrismBorderCubeName) as ModelVisual3D))
            {
                selectionOperationHelper.SelectionCubeName = CubeBasicInfo.RightBackPrismBorderCubeName;
                selectionOperationHelper.SelectionCubePoint = cubeRotateHelper.CubeRotateInfo.Find(x => x.CubeName == CubeBasicInfo.RightBackPrismBorderCubeName).CurrentCubePoint;
                return HitTestResultBehavior.Stop;
            }
            else if (vis == (viewPortCube.FindName(CubeBasicInfo.RightBackDownCornerBorderCubeName) as ModelVisual3D))
            {
                selectionOperationHelper.SelectionCubeName = CubeBasicInfo.RightBackDownCornerBorderCubeName;
                selectionOperationHelper.SelectionCubePoint = cubeRotateHelper.CubeRotateInfo.Find(x => x.CubeName == CubeBasicInfo.RightBackDownCornerBorderCubeName).CurrentCubePoint;
                return HitTestResultBehavior.Stop;
            }
            else if (vis == (viewPortCube.FindName(CubeBasicInfo.BackUpPrismBorderCubeName) as ModelVisual3D))
            {
                selectionOperationHelper.SelectionCubeName = CubeBasicInfo.BackUpPrismBorderCubeName;
                selectionOperationHelper.SelectionCubePoint = cubeRotateHelper.CubeRotateInfo.Find(x => x.CubeName == CubeBasicInfo.BackUpPrismBorderCubeName).CurrentCubePoint;
                return HitTestResultBehavior.Stop;
            }
            else if (vis == (viewPortCube.FindName(CubeBasicInfo.BackCenterBorderCubeName) as ModelVisual3D))
            {
                selectionOperationHelper.SelectionCubeName = CubeBasicInfo.BackCenterBorderCubeName;
                selectionOperationHelper.SelectionCubePoint = cubeRotateHelper.CubeRotateInfo.Find(x => x.CubeName == CubeBasicInfo.BackCenterBorderCubeName).CurrentCubePoint;
                return HitTestResultBehavior.Stop;
            }
            else if (vis == (viewPortCube.FindName(CubeBasicInfo.BackDownPrismBorderCubeCubeName) as ModelVisual3D))
            {
                selectionOperationHelper.SelectionCubeName = CubeBasicInfo.BackDownPrismBorderCubeCubeName;
                selectionOperationHelper.SelectionCubePoint = cubeRotateHelper.CubeRotateInfo.Find(x => x.CubeName == CubeBasicInfo.BackDownPrismBorderCubeCubeName).CurrentCubePoint;
                return HitTestResultBehavior.Stop;
            }
            else if (vis == (viewPortCube.FindName(CubeBasicInfo.BackLeftUpCornerBorderCubeName) as ModelVisual3D))
            {
                selectionOperationHelper.SelectionCubeName = CubeBasicInfo.BackLeftUpCornerBorderCubeName;
                selectionOperationHelper.SelectionCubePoint = cubeRotateHelper.CubeRotateInfo.Find(x => x.CubeName == CubeBasicInfo.BackLeftUpCornerBorderCubeName).CurrentCubePoint;
                return HitTestResultBehavior.Stop;
            }
            else if (vis == (viewPortCube.FindName(CubeBasicInfo.BackLeftPrismBorderCubeName) as ModelVisual3D))
            {
                selectionOperationHelper.SelectionCubeName = CubeBasicInfo.BackLeftPrismBorderCubeName;
                selectionOperationHelper.SelectionCubePoint = cubeRotateHelper.CubeRotateInfo.Find(x => x.CubeName == CubeBasicInfo.BackLeftPrismBorderCubeName).CurrentCubePoint;
                return HitTestResultBehavior.Stop;
            }
            else if (vis == (viewPortCube.FindName(CubeBasicInfo.BackLeftDownCornerBorderCubeName) as ModelVisual3D))
            {
                selectionOperationHelper.SelectionCubeName = CubeBasicInfo.BackLeftDownCornerBorderCubeName;
                selectionOperationHelper.SelectionCubePoint = cubeRotateHelper.CubeRotateInfo.Find(x => x.CubeName == CubeBasicInfo.BackLeftDownCornerBorderCubeName).CurrentCubePoint;
                return HitTestResultBehavior.Stop;
            }
            else if (vis == (viewPortCube.FindName(CubeBasicInfo.LeftUpPrismBorderCubeCubeName) as ModelVisual3D))
            {
                selectionOperationHelper.SelectionCubeName = CubeBasicInfo.LeftUpPrismBorderCubeCubeName;
                selectionOperationHelper.SelectionCubePoint = cubeRotateHelper.CubeRotateInfo.Find(x => x.CubeName == CubeBasicInfo.LeftUpPrismBorderCubeCubeName).CurrentCubePoint;
                return HitTestResultBehavior.Stop;
            }
            else if (vis == (viewPortCube.FindName(CubeBasicInfo.LeftCenterBorderCubeName) as ModelVisual3D))
            {
                selectionOperationHelper.SelectionCubeName = CubeBasicInfo.LeftCenterBorderCubeName;
                selectionOperationHelper.SelectionCubePoint = cubeRotateHelper.CubeRotateInfo.Find(x => x.CubeName == CubeBasicInfo.LeftCenterBorderCubeName).CurrentCubePoint;
                return HitTestResultBehavior.Stop;
            }
            else if (vis == (viewPortCube.FindName(CubeBasicInfo.LeftDownPrismBorderCubeName) as ModelVisual3D))
            {
                selectionOperationHelper.SelectionCubeName = CubeBasicInfo.LeftDownPrismBorderCubeName;
                selectionOperationHelper.SelectionCubePoint = cubeRotateHelper.CubeRotateInfo.Find(x => x.CubeName == CubeBasicInfo.LeftDownPrismBorderCubeName).CurrentCubePoint;
                return HitTestResultBehavior.Stop;
            }
            else if (vis == (viewPortCube.FindName(CubeBasicInfo.LeftFrontUpCornerBorderCubeName) as ModelVisual3D))
            {
                selectionOperationHelper.SelectionCubeName = CubeBasicInfo.LeftFrontUpCornerBorderCubeName;
                selectionOperationHelper.SelectionCubePoint = cubeRotateHelper.CubeRotateInfo.Find(x => x.CubeName == CubeBasicInfo.LeftFrontUpCornerBorderCubeName).CurrentCubePoint;
                return HitTestResultBehavior.Stop;
            }
            else if (vis == (viewPortCube.FindName(CubeBasicInfo.LeftFrontPrismBorderCubeName) as ModelVisual3D))
            {
                selectionOperationHelper.SelectionCubeName = CubeBasicInfo.LeftFrontPrismBorderCubeName;
                selectionOperationHelper.SelectionCubePoint = cubeRotateHelper.CubeRotateInfo.Find(x => x.CubeName == CubeBasicInfo.LeftFrontPrismBorderCubeName).CurrentCubePoint;
                return HitTestResultBehavior.Stop;
            }
            else if (vis == (viewPortCube.FindName(CubeBasicInfo.LeftFrontDownCornerBorderCubeCubeName) as ModelVisual3D))
            {
                selectionOperationHelper.SelectionCubeName = CubeBasicInfo.LeftFrontDownCornerBorderCubeCubeName;
                selectionOperationHelper.SelectionCubePoint = cubeRotateHelper.CubeRotateInfo.Find(x => x.CubeName == CubeBasicInfo.LeftFrontDownCornerBorderCubeCubeName).CurrentCubePoint;
                return HitTestResultBehavior.Stop;
            }
            else if (vis == (viewPortCube.FindName(CubeBasicInfo.UpCenterBorderCubeName) as ModelVisual3D))
            {
                selectionOperationHelper.SelectionCubeName = CubeBasicInfo.UpCenterBorderCubeName;
                selectionOperationHelper.SelectionCubePoint = cubeRotateHelper.CubeRotateInfo.Find(x => x.CubeName == CubeBasicInfo.UpCenterBorderCubeName).CurrentCubePoint;
                return HitTestResultBehavior.Stop;
            }
            else if (vis == (viewPortCube.FindName(CubeBasicInfo.DownCenterBorderCubeName) as ModelVisual3D))
            {
                selectionOperationHelper.SelectionCubeName = CubeBasicInfo.DownCenterBorderCubeName;
                selectionOperationHelper.SelectionCubePoint = cubeRotateHelper.CubeRotateInfo.Find(x => x.CubeName == CubeBasicInfo.DownCenterBorderCubeName).CurrentCubePoint;
                return HitTestResultBehavior.Stop;
            }

            return HitTestResultBehavior.Continue;
        }

        private void RotateCubePlane(Point3D selectionPoint, Quaternion selectionAixs)
        {
            selectionOperationHelper.SelectionAixs = selectionAixs;
            storyBoard.Children.Clear();

            foreach (Point3D pt in planeRotateHelper.FindCubePlane(selectionPoint, selectionAixs))
            {
                string rotateCubePlaneName = cubeRotateHelper.CubeRotateInfo.Find(x => x.CurrentCubePoint == pt && x.IsRotated == false).CubeName;
                Quaternion usedQuaternion = cubeRotateHelper.CubeRotateInfo.Find(x => x.CubeName == rotateCubePlaneName).UsedQuaternion;
                Quaternion usedRotateQuaternion = Quaternion.Multiply(selectionAixs,usedQuaternion);
                cubeAnimation = new Rotation3DAnimation();
                cubeAnimation.From = new QuaternionRotation3D(usedQuaternion);
                cubeAnimation.To = new QuaternionRotation3D(usedRotateQuaternion);
                cubeAnimation.Duration = TimeSpan.FromSeconds(1);
                Storyboard.SetTargetName(cubeAnimation, rotateCubePlaneName + "Rotate");
                Storyboard.SetTargetProperty(cubeAnimation, new PropertyPath(RotateTransform3D.RotationProperty));
                storyBoard.Children.Add(cubeAnimation);

                cubeRotateHelper.CubeRotateInfo.Find(x => x.CubeName == rotateCubePlaneName).UsedQuaternion = usedRotateQuaternion;
                cubeRotateHelper.CubeRotateInfo.Find(x => x.CubeName == rotateCubePlaneName).IsRotated = true;
            }

            storyBoard.Begin(this);

            selectionOperationHelper.ClearAllPropertyValue();
            cubeRotateHelper.ClearRotatedPropertyValue();
        }
    }
}
