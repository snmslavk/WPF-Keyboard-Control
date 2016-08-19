// --------------------------------------------------------------------------------------------------------------------
// <copyright file="KeyboardModelTests.cs" company="MyCompanyName">
//   The MIT License (MIT)
//   Copyright(c) 2014 Viacheslav Avsenev
// </copyright>
// <summary>
//   The stub keyboard model.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace TermControlsTests
{
    using System;

    using NUnit.Framework;

    using TermControls.Models;

    /// <summary>
    /// The keyboard model tests.
    /// </summary>
    [TestFixture]
    public class KeyboardModelTests
    {
        /// <summary>
        /// The keyboard model.
        /// </summary>
        private KeyboardModel keyboardmodel;

        /// <summary>
        /// The setup.
        /// </summary>
        [SetUp]
        public void Setup()
        {
            this.keyboardmodel = new StubKeyboardModel();
        }

        /// <summary>
        /// The content test.
        /// </summary>
        [Test]
        public void ContentTest()
        {
            Assert.NotNull(this.keyboardmodel.Content);
            this.keyboardmodel.IsShift = !this.keyboardmodel.IsShift;
            Assert.NotNull(this.keyboardmodel.Content);
            this.keyboardmodel.IsEngRus = !this.keyboardmodel.IsShift;
            Assert.NotNull(this.keyboardmodel.Content);
            this.keyboardmodel.IsEngRus = !this.keyboardmodel.IsEngRus;
            Assert.NotNull(this.keyboardmodel.Content);

            Assert.AreEqual(this.keyboardmodel.Content[0].Length, 11);
        }

        /// <summary>
        /// The get button content test.
        /// </summary>
        [Test]
        public void GetButtonContentTest()
        {
            Assert.AreEqual(this.keyboardmodel.GetButtonContent("b11"), "*");
            Assert.Catch<IndexOutOfRangeException>(() => { this.keyboardmodel.GetButtonContent("b9999"); });
            Assert.Catch<FormatException>(() => { this.keyboardmodel.GetButtonContent("errorText"); });
        }

        /// <summary>
        /// The create buttons test.
        /// </summary>
        [Test]
        public void CreateButtonsTest()
        {
            this.keyboardmodel.CreateButtons();
            Assert.AreEqual(this.keyboardmodel.ButtonsRaw1[0].Column, 0);
            Assert.AreEqual(this.keyboardmodel.ButtonsRaw1[0].Name, "b11");
            Assert.AreEqual(this.keyboardmodel.ButtonsRaw1[0].Content, "*");
        }

        /// <summary>
        /// The change buttons test.
        /// </summary>
        [Test]
        public void ChangeButtonsTest()
        {
            Assert.DoesNotThrow(
                () =>
                    {
                        this.keyboardmodel.CreateButtons();
                        this.keyboardmodel.ChangeButtonsContent();
                    });
        }
    }
}
