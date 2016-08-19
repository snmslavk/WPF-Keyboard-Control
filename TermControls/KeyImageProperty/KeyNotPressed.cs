// --------------------------------------------------------------------------------------------------------------------
// <copyright file="KeyNotPressed.cs" company="MyCompanyName">
//   The MIT License (MIT)
//   Copyright(c) 2014 Viacheslav Avsenev
// </copyright>
// <summary>
//   Defines the KeyNotPressed type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace TermControls.KeyImageProperty
{
    using System.Windows;
    using System.Windows.Media;

    /// <summary>
    /// The key not pressed.
    /// </summary>
    public class KeyNotPressed
    {
        /// <summary>
        /// The image property.
        /// </summary>
        public static readonly DependencyProperty ImageProperty;

        /// <summary>
        /// Initializes static members of the <see cref="KeyNotPressed"/> class.
        /// </summary>
        static KeyNotPressed()
        {
            var metadata = new FrameworkPropertyMetadata((ImageSource)null);
            ImageProperty = DependencyProperty.RegisterAttached(
                "Image",
                typeof(ImageSource),
                typeof(KeyNotPressed),
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
