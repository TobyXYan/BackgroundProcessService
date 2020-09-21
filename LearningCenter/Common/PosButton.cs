

using System.Windows;
using System.Windows.Controls;

namespace LearningCenter.Common
{
    public class PosButton:Button
    {
        public Point Position
        {
            get => ((Point)GetValue(PositionProperty));
            set { SetValue(PositionProperty, value); }
        }

        public static readonly DependencyProperty PositionProperty = DependencyProperty.Register("Position", typeof(Point), typeof(PosButton),
            new FrameworkPropertyMetadata(new Point(), FrameworkPropertyMetadataOptions.BindsTwoWayByDefault));

        protected override void OnClick()
        {
            Position = PointToScreen(new Point(0, 0));
            base.OnClick();
        }
    }
}
