using System;
using NUnit.Framework;
using TermControls.Models;

namespace TermControlsTests
{
    [TestFixture]
    public class KeyboardModelTests
    {
        private KeyboardModel _keyboardmodel;

        [SetUp]
        public void Setup()
        {
            _keyboardmodel = new StubKeyboardModel();
        }

        [Test]
        public void ContentTest()
        {
            Assert.NotNull(_keyboardmodel.Content);
            _keyboardmodel.isShift = !_keyboardmodel.isShift;
            Assert.NotNull(_keyboardmodel.Content);
            _keyboardmodel.isEngRus = !_keyboardmodel.isShift;
            Assert.NotNull(_keyboardmodel.Content);
            _keyboardmodel.isEngRus = !_keyboardmodel.isEngRus;
            Assert.NotNull(_keyboardmodel.Content);
            
            Assert.AreEqual(_keyboardmodel.Content[0].Length, 11);
        }

        [Test]
        public void GetButtonContentTest()
        {

            Assert.AreEqual(_keyboardmodel.GetButtonContent("b11"),"*");
            Assert.Catch<IndexOutOfRangeException>(() => { _keyboardmodel.GetButtonContent("b9999"); });
            Assert.Catch<FormatException>(() => { _keyboardmodel.GetButtonContent("errorText"); });
        }

        [Test]
        public void CreateButtonsTest()
        {
            _keyboardmodel.CreateButtons();
            Assert.AreEqual(_keyboardmodel.ButtonsRaw1[0].Column, 0);
            Assert.AreEqual(_keyboardmodel.ButtonsRaw1[0].Name, "b11");
            Assert.AreEqual(_keyboardmodel.ButtonsRaw1[0].Content, "*");
        }

        [Test]
        public void ChangeButtonsTest()
        {
            Assert.DoesNotThrow(() => {
                _keyboardmodel.CreateButtons();
                _keyboardmodel.ChangeButtonsContent(); });

        }

    }

    public class StubKeyboardModel : KeyboardModel
    {
        public override void InitContent()
        {
            Content1 = Content2 = Content1Shift = Content2Shift = new string[4] { new string('*', 11), new string('*', 12), new string('*', 11), new string('*', 12) };
        }
    }
}
