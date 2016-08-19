// --------------------------------------------------------------------------------------------------------------------
// <copyright file="GridAutoLayout.cs" company="MyCompanyName">
//   The MIT License (MIT)
//   Copyright(c) 2014 Viacheslav Avsenev
// </copyright>
// <summary>
//   The grid auto layout.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace TermControls.Helpers
{
    using System.Windows;
    using System.Windows.Controls;

    /// <summary>
    /// The grid auto layout.
    /// </summary>
    public class GridAutoLayout
    {
        /// <summary>
        /// The number of columns property.
        /// </summary>
        public static readonly DependencyProperty NumberOfColumnsProperty =
            DependencyProperty.RegisterAttached(
                "NumberOfColumns",
                typeof(int),
                typeof(GridAutoLayout),
                new PropertyMetadata(1, NumberOfColumnsUpdated));

        /// <summary>
        /// The number of rows property.
        /// </summary>
        public static readonly DependencyProperty NumberOfRowsProperty =
            DependencyProperty.RegisterAttached(
                "NumberOfRows",
                typeof(int),
                typeof(GridAutoLayout),
                new PropertyMetadata(1, NumberOfRowsUpdated));

        /// <summary>
        /// The get number of columns.
        /// </summary>
        /// <param name="obj">
        /// The object.
        /// </param>
        /// <returns>
        /// The <see cref="int"/>.
        /// </returns>
        public static int GetNumberOfColumns(DependencyObject obj)
        {
            return (int)obj.GetValue(NumberOfColumnsProperty);
        }

        /// <summary>
        /// The set number of columns.
        /// </summary>
        /// <param name="obj">
        /// The object.
        /// </param>
        /// <param name="value">
        /// The value.
        /// </param>
        public static void SetNumberOfColumns(DependencyObject obj, int value)
        {
            obj.SetValue(NumberOfColumnsProperty, value);
        }

        /// <summary>
        /// The get number of rows.
        /// </summary>
        /// <param name="obj">
        /// The object.
        /// </param>
        /// <returns>
        /// The <see cref="int"/>.
        /// </returns>
        public static int GetNumberOfRows(DependencyObject obj)
        {
            return (int)obj.GetValue(NumberOfRowsProperty);
        }

        /// <summary>
        /// The set number of rows.
        /// </summary>
        /// <param name="obj">
        /// The object.
        /// </param>
        /// <param name="value">
        /// The value.
        /// </param>
        public static void SetNumberOfRows(DependencyObject obj, int value)
        {
            obj.SetValue(NumberOfRowsProperty, value);
        }

        /// <summary>
        /// The number of rows updated.
        /// </summary>
        /// <param name="d">
        /// The d.
        /// </param>
        /// <param name="e">
        /// The e.
        /// </param>
        private static void NumberOfRowsUpdated(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var grid = (Grid)d;

            grid.RowDefinitions.Clear();
            for (var i = 0; i < (int)e.NewValue; i++)
            {
                grid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Star) });
            }
        }

        /// <summary>
        /// The number of columns updated.
        /// </summary>
        /// <param name="d">
        /// The d.
        /// </param>
        /// <param name="e">
        /// The e.
        /// </param>
        private static void NumberOfColumnsUpdated(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var grid = (Grid)d;

            grid.ColumnDefinitions.Clear();
            for (var i = 0; i < (int)e.NewValue; i++)
            {
                grid.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });
            }
        }
    }
}
