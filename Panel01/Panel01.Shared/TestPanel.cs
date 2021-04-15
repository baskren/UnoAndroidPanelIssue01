using System;
using System.Collections.Generic;
using System.Text;
using Windows.Foundation;
using Windows.UI.Xaml.Controls;

namespace Panel01
{
    public partial class TestPanel : Panel
    {

        protected override Size MeasureOverride(Size availableSize)
        {
            if (availableSize.Width <= 0 && availableSize.Height <= 0)
                return availableSize;
            var size = new Size(availableSize.Width, 40);
            foreach (var child in Children)
                child.Measure(size);
            return size;
        }

        protected override Size ArrangeOverride(Size finalSize)
        {
            var childX = finalSize.Width;
            foreach (var child in Children)
            {
                childX -= child.DesiredSize.Width;
                child.Arrange(new Rect(new Point(childX, 0), child.DesiredSize));
            }
            return finalSize;
        }
    }
}
