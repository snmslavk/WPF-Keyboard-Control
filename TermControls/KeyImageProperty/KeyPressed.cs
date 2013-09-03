using System.Windows;
using System.Windows.Media;

namespace TermControls
{
    /// <summary>
    /// 
    /// </summary>
    public class KeyPressed
    {
        public static readonly DependencyProperty ImageProperty;

        public static ImageSource GetImage(DependencyObject obj)
        {
            return (ImageSource)obj.GetValue(ImageProperty);
        }

        public static void SetImage(DependencyObject obj, ImageSource value)
        {
            obj.SetValue(ImageProperty, value);
        }

        static KeyPressed()
        {
            var metadata = new FrameworkPropertyMetadata((ImageSource)null);
            ImageProperty = DependencyProperty.RegisterAttached("Image",
                                                                typeof(ImageSource),
                                                                typeof(KeyPressed), metadata);
        }
    }
}
