// --------------------------------------------------------------------------------------------------------------------
// <copyright file="KeyboardViewModelTests.cs" company="MyCompanyName">
//   The MIT License (MIT)
//   Copyright(c) 2014 Viacheslav Avsenev
// </copyright>
// <summary>
//   The keyboard view model tests.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace TermControlsTests
{
    using NUnit.Framework;

    using TermControls.ViewModels;

    /// <summary>
    /// The keyboard view model tests.
    /// </summary>
    [TestFixture]
    public class KeyboardViewModelTests
    {
        /// <summary>
        /// The keyboard view model.
        /// </summary>
        private KeyboardViewModel keyboardviewmodel;

        /// <summary>
        /// The setup.
        /// </summary>
        [SetUp]
        public void Setup()
        {
            this.keyboardviewmodel = new KeyboardViewModel();
        }

        /// <summary>
        /// The change buttons test.
        /// </summary>
        [Test]
        public void ChangeButtonsTest()
        {
            Assert.DoesNotThrow(() => { this.keyboardviewmodel.ChangeLangClick(null); });
        }

        /// <summary>
        /// The shift click test.
        /// </summary>
        [Test]
        public void ShiftClickTest()
        {
            Assert.DoesNotThrow(() => { this.keyboardviewmodel.DeleteClick(null); });

            this.keyboardviewmodel.Model.Text = " ";
            this.keyboardviewmodel.DeleteClick(null);
            Assert.AreEqual(this.keyboardviewmodel.Model.Text, string.Empty);
        }

        /// <summary>
        /// The button click test.
        /// </summary>
        [Test]
        public void ButtonClickTest()
        {
            this.keyboardviewmodel.ButtonClick("test");
            Assert.AreEqual(this.keyboardviewmodel.Model.Text, "test");
        }

        /// <summary>
        /// The space click test.
        /// </summary>
        [Test]
        public void SpaceClickTest()
        {
            this.keyboardviewmodel.SpaceClick("test");
            Assert.AreEqual(this.keyboardviewmodel.Model.Text, " ");
        }
    }
}
