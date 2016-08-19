// --------------------------------------------------------------------------------------------------------------------
// <copyright file="StubKeyboardModel.cs" company="MyCompanyName">
//   OpenSource
// </copyright>
// <author>Viacheslav Avsenev</author>
// <summary>
//   The stub keyboard model.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace TermControlsTests
{
    using TermControls.Models;

    /// <summary>
    /// The stub keyboard model.
    /// </summary>
    public class StubKeyboardModel : KeyboardModel
    {
        /// <summary>
        /// The initialize content.
        /// </summary>
        public override void InitContent()
        {
            this.Content1 =
                this.Content2 =
                this.Content1Shift =
                this.Content2Shift =
                new[] { new string('*', 11), new string('*', 12), new string('*', 11), new string('*', 12) };
        }
    }
}