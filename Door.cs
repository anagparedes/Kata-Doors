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
            var someDoor = Door.OpenAndUncloked("someStrongKey");
            string result =Door.Close(someDoor);
            Assert.AreEqual("Closed", result);
        }

    }

    //[TestClass]
    //public class Locked : Door
    //{
    //    public bool IsLocked { get; }

    //    [TestMethod]
    //    public bool TestIsLocked()
    //    {

    //        if (IsLocked)
    //        {
    //            return true;
    //        }
    //        else
    //            return false;
    //    }

    //}
    


}
