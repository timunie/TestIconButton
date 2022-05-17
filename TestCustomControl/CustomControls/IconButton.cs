using Avalonia;
using Avalonia.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestCustomControl.CustomControls
{
    public class IconButton : Button
    {
        public static readonly StyledProperty<string> IconProperty =
            AvaloniaProperty.Register<IconButton, string>(nameof(Icon));

        public string Icon
        {
            get { return GetValue(IconProperty); }
            set { SetValue(IconProperty, value); }
        }
    }
}
