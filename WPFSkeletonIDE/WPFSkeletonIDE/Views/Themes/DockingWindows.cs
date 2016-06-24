using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xceed.Wpf.AvalonDock.Themes;

namespace WPFSkeletonIDE.Views.Themes
{
    public class DockingWindowsTheme : Theme
    {
        public override Uri GetResourceUri()
        {
            return new Uri(
                "/Views/Themes/DockingWindows.xaml",
                UriKind.Relative);
        }
    }

    /*
        LayoutGridResizerControl の Style から BackGround を除外した

        Dockin anch
            ItemContainerStyle
    */
}
