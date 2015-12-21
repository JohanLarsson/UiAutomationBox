using System.Linq;
using System.Threading;
using System.Windows;
using System.Windows.Automation.Peers;
using System.Windows.Automation.Provider;
using NUnit.Framework;

namespace UiAutomationBox
{

    [Apartment(ApartmentState.STA)]
    public class TextBoxTests
    {
        private TextBoxAutomationPeer textBoxPeer;
        private Window window;

        [SetUp]
        public void SetUp()
        {
            window = new TextBoxWindow();
            window.Show();
            var windowPeer = new WindowAutomationPeer(window);
            textBoxPeer = windowPeer.GetChildren().OfType<TextBoxAutomationPeer>().Single();
        }

        [Test]
        public void GetText()
        {
            Assert.AreEqual("Initial", ((IValueProvider)textBoxPeer).Value);
        }

        [TearDown]
        public void TearDown()
        {
            window.Close();
        }
    }
}
