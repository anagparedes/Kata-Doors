using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace KataDoor
{

    [TestClass]
    public class Door
    {
        public static string OpenAndUncloked(string key) { return key; }
        public static string OpenAndLocked(string key) { return key; }
        public static string ClosedAndUnlocked(string key) { return key; }
        public static string ClosedAndLocked(string key) { return key; }
        public bool IsOpen { get; }
        public bool IsClosed { get; }
        public bool IsLocked { get; }
        public bool IsUnlocked { get; }

        public static string Open(string status) { return "Opened"; }
        public static string Close(string status) { return "Closed"; }
        public static string Lock(string status) { return "Locked"; }
        public static string Unlock(string status) { return "Unlocked"; }

        [TestMethod]
        public void TestClosedDoor()
        {
            var someDoor = Door.ClosedAndLocked("someStrongKey");
            string result =Door.Close(someDoor);
            Assert.AreEqual("Closed", result);
        }
        [TestMethod]
        public void TestClosedDoorFailed()
        {
            var someDoor = Door.ClosedAndLocked("someStrongKey");
            string result = Door.Close(someDoor);
            Assert.AreEqual("Opened", result);
        }
        [TestMethod]
        public void TestOpenedDoor()
        {
            var someDoor = Door.OpenAndUncloked("someStrongKey");
            string result = Door.Open(someDoor);
            Assert.AreEqual("Opened", result);
        }
        [TestMethod]
        public void TestOpenedDoorFailed()
        {
            var someDoor = Door.OpenAndUncloked("someStrongKey");
            string result = Door.Open(someDoor);
            Assert.AreEqual("Closed", result);
        }
        [TestMethod]
        public void TestLockedDoor()
        {
            var someDoor = Door.OpenAndLocked("someStrongKey");
            string result = Door.Lock(someDoor);
            Assert.AreEqual("Locked", result);
        }
        [TestMethod]
        public void TestLockedDoorFailed()
        {
            var someDoor = Door.OpenAndLocked("someStrongKey");
            string result = Door.Lock(someDoor);
            Assert.AreEqual("Unlocked", result);
        }
        [TestMethod]
        public void TestUnLockedDoor()
        {
            var someDoor = Door.OpenAndUncloked("someStrongKey");
            string result = Door.Unlock(someDoor);
            Assert.AreEqual("Unlocked", result);
        }
        [TestMethod]
        public void TestUnLockedDoorFailed()
        {
            var someDoor = Door.OpenAndUncloked("someStrongKey");
            string result = Door.Unlock(someDoor);
            Assert.AreEqual("Locked", result);
        }


    }

}
