// --------------------------------------------------------------------------------------------------------------------
// <copyright file="KeyPressed.cs" company="MyCompanyName">
//   The MIT License (MIT)
//   Copyright(c) 2014 Viacheslav Avsenev
// </copyright>
// <summary>
//   Defines the KeyPressed type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace TermControls.KeyImageProperty
{
    using System.Windows;
    using System.Windows.Media;

    /// <summary>
    /// The key pressed.
    /// </summary>
    public class KeyPressed
    {
        /// <summary>
        /// The image property.
        /// </summary>
        public static readonly DependencyProperty ImageProperty;

        /// <summary>
        /// Initializes static members of the <see cref="KeyPressed"/> class.
        /// </summary>
        static KeyPressed()
        {
            var metadata = new FrameworkPropertyMetadata((ImageSource)null);
            ImageProperty = DependencyProperty.RegisterAttached(
                "Image",
                typeof(ImageSource),
                typeof(KeyPressed),
                metadata);
        }

        /// <summary>
        /// The get image.
        /// </summary>
        /// <param name="obj">
        /// The object.
        /// </param>
        /// <returns>
        /// The <see cref="ImageSource"/>.
        /// </returns>
        public static ImageSource GetImage(DependencyObject obj)
        {
            return (ImageSource)obj.GetValue(ImageProperty);
        }

        /// <summary>
        /// The set image.
        /// </summary>
        /// <param name="obj">
        /// The object.
        /// </param>
        /// <param name="value">
        /// The value.
        /// </param>
        public static void SetImage(DependencyObject obj, ImageSource value)
        {
            obj.SetValue(ImageProperty, value);
        }
    }
}
