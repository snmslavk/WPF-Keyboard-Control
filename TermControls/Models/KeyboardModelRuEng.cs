// --------------------------------------------------------------------------------------------------------------------
// <copyright file="KeyboardModelRuEng.cs" company="MyCompanyName">
//   The MIT License (MIT)
//   Copyright(c) 2014 Viacheslav Avsenev
// </copyright>
// <summary>
//   Defines the KeyboardModelRuEng type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace TermControls.Models
{
    /// <summary>
    /// The keyboard model russian english.
    /// </summary>
    public class KeyboardModelRuEng : KeyboardModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="KeyboardModelRuEng"/> class.
        /// </summary>
        public KeyboardModelRuEng()
            : base()
        {
        }

        /// <summary>
        /// The initialize content.
        /// </summary>
        public override void InitContent()
        {
            this.Content1 = new[] { "1234567890-", "йцукенгшщзхъ", "фывапролджэ", "ячсмитьбю,.?" };
            this.Content1Shift = new[] { "!\"№;%:?*()-", "ЙЦУКЕНГШЩЗХЪ", "ФЫВАПРОЛДЖЭ", "ЯЧСМИТЬБЮ,.?" };
            this.Content2 = new[] { "1234567890-", "qwertyuiop[]", "asdfghjkl;'", "zxcvbnm<>,.?" };
            this.Content2Shift = new[] { "!@#$%^&*()-", "QWERTYUIOP{}", "ASDFGHJKL:\"", "ZXCVBNM<>,.?" };
        }
    }
}
