using NUnit.Framework;
using TermControls.ViewModels;

namespace TermControlsTests
{
    [TestFixture]
    class KeyboardViewModelTests
    {
        KeyboardViewModel _keyboardviewmodel;

        [SetUp]
        public void Setup()
        {
            _keyboardviewmodel = new KeyboardViewModel();
        }

        [Test]
        public void ChangeButtonsTest()
        {
            Assert.DoesNotThrow(() =>
            {
                _keyboardviewmodel.ChangeLangClick(null);
            });
        }

        [Test]
        public void ShiftClickTest()
        {
            Assert.DoesNotThrow(() =>
            {
            _keyboardviewmodel.DeleteClick(null);
            });

            _keyboardviewmodel.Model.Text = " ";
            _keyboardviewmodel.DeleteClick(null);
            Assert.AreEqual(_keyboardviewmodel.Model.Text, "");
        }

        [Test]
        public void ButtonClickTest()
        {
            _keyboardviewmodel.ButtonClick("test");
            Assert.AreEqual(_keyboardviewmodel.Model.Text, "test");
        }

        [Test]
        public void SpaceClickTest()
        {
            _keyboardviewmodel.SpaceClick("test");
            Assert.AreEqual(_keyboardviewmodel.Model.Text, " ");
        }
    }
}
