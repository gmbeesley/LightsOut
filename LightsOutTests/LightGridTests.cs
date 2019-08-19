using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

namespace LightsOut.Tests
{
    [TestClass()]
    public class LightGridTests
    {
        [TestMethod()]
        public void LightGridConstructorTest()
        {
            LightGrid lightGrid = new LightGrid();

            Assert.AreEqual(5, lightGrid.Columns);
            Assert.AreEqual(5, lightGrid.Rows);
            Assert.AreEqual(0, lightGrid.LightsOnCount);
            Assert.AreEqual(lightGrid.LightsOnGrid.Cast<bool>().ToArray().Count(x => x.Equals(true)), 0);
        }

        [TestMethod()]
        public void LightGridInitialiseTest()
        {
            LightGrid lightGrid = new LightGrid();
            lightGrid.InitialiseLightGrid();

            Assert.AreNotEqual(0, lightGrid.LightsOnCount);
            Assert.AreNotEqual(0, lightGrid.LightsOnGrid.Cast<bool>().ToArray().Count(x => x.Equals(true)));
            Assert.AreEqual(lightGrid.LightsOnGrid.Cast<bool>().ToArray().Count(x => x.Equals(true)), lightGrid.LightsOnCount);
        }

        [TestMethod()]
        public void LightGridProcessLightSwitchTest_00()
        {
            LightGrid lightGrid = new LightGrid();

            lightGrid.ProcessLightSwitch(0, 0);
            Assert.AreEqual(true, lightGrid.LightsOnGrid[0, 0]);
            Assert.AreEqual(true, lightGrid.LightsOnGrid[1, 0]);
            Assert.AreEqual(false, lightGrid.LightsOnGrid[2, 0]);
            Assert.AreEqual(false, lightGrid.LightsOnGrid[3, 0]);
            Assert.AreEqual(false, lightGrid.LightsOnGrid[4, 0]);
            Assert.AreEqual(true, lightGrid.LightsOnGrid[0, 1]);
            Assert.AreEqual(false, lightGrid.LightsOnGrid[1, 1]);
            Assert.AreEqual(false, lightGrid.LightsOnGrid[2, 1]);
            Assert.AreEqual(false, lightGrid.LightsOnGrid[3, 1]);
            Assert.AreEqual(false, lightGrid.LightsOnGrid[4, 1]);
            Assert.AreEqual(false, lightGrid.LightsOnGrid[0, 2]);
            Assert.AreEqual(false, lightGrid.LightsOnGrid[1, 2]);
            Assert.AreEqual(false, lightGrid.LightsOnGrid[2, 2]);
            Assert.AreEqual(false, lightGrid.LightsOnGrid[3, 2]);
            Assert.AreEqual(false, lightGrid.LightsOnGrid[4, 2]);
            Assert.AreEqual(false, lightGrid.LightsOnGrid[0, 3]);
            Assert.AreEqual(false, lightGrid.LightsOnGrid[1, 3]);
            Assert.AreEqual(false, lightGrid.LightsOnGrid[2, 3]);
            Assert.AreEqual(false, lightGrid.LightsOnGrid[3, 3]);
            Assert.AreEqual(false, lightGrid.LightsOnGrid[4, 3]);
            Assert.AreEqual(false, lightGrid.LightsOnGrid[0, 4]);
            Assert.AreEqual(false, lightGrid.LightsOnGrid[1, 4]);
            Assert.AreEqual(false, lightGrid.LightsOnGrid[2, 4]);
            Assert.AreEqual(false, lightGrid.LightsOnGrid[3, 4]);
            Assert.AreEqual(false, lightGrid.LightsOnGrid[4, 4]);
            Assert.AreEqual(3, lightGrid.LightsOnCount);

            lightGrid.ProcessLightSwitch(0, 0);
            Assert.AreEqual(false, lightGrid.LightsOnGrid[0, 0]);
            Assert.AreEqual(false, lightGrid.LightsOnGrid[1, 0]);
            Assert.AreEqual(false, lightGrid.LightsOnGrid[2, 0]);
            Assert.AreEqual(false, lightGrid.LightsOnGrid[3, 0]);
            Assert.AreEqual(false, lightGrid.LightsOnGrid[4, 0]);
            Assert.AreEqual(false, lightGrid.LightsOnGrid[0, 1]);
            Assert.AreEqual(false, lightGrid.LightsOnGrid[1, 1]);
            Assert.AreEqual(false, lightGrid.LightsOnGrid[2, 1]);
            Assert.AreEqual(false, lightGrid.LightsOnGrid[3, 1]);
            Assert.AreEqual(false, lightGrid.LightsOnGrid[4, 1]);
            Assert.AreEqual(false, lightGrid.LightsOnGrid[0, 2]);
            Assert.AreEqual(false, lightGrid.LightsOnGrid[1, 2]);
            Assert.AreEqual(false, lightGrid.LightsOnGrid[2, 2]);
            Assert.AreEqual(false, lightGrid.LightsOnGrid[3, 2]);
            Assert.AreEqual(false, lightGrid.LightsOnGrid[4, 2]);
            Assert.AreEqual(false, lightGrid.LightsOnGrid[0, 3]);
            Assert.AreEqual(false, lightGrid.LightsOnGrid[1, 3]);
            Assert.AreEqual(false, lightGrid.LightsOnGrid[2, 3]);
            Assert.AreEqual(false, lightGrid.LightsOnGrid[3, 3]);
            Assert.AreEqual(false, lightGrid.LightsOnGrid[4, 3]);
            Assert.AreEqual(false, lightGrid.LightsOnGrid[0, 4]);
            Assert.AreEqual(false, lightGrid.LightsOnGrid[1, 4]);
            Assert.AreEqual(false, lightGrid.LightsOnGrid[2, 4]);
            Assert.AreEqual(false, lightGrid.LightsOnGrid[3, 4]);
            Assert.AreEqual(false, lightGrid.LightsOnGrid[4, 4]);
            Assert.AreEqual(0, lightGrid.LightsOnCount);
        }

        [TestMethod()]
        public void LightGridProcessLightSwitchTest__22()
        {
            LightGrid lightGrid = new LightGrid();

            lightGrid.ProcessLightSwitch(2, 2);
            Assert.AreEqual(false, lightGrid.LightsOnGrid[0, 0]);
            Assert.AreEqual(false, lightGrid.LightsOnGrid[1, 0]);
            Assert.AreEqual(false, lightGrid.LightsOnGrid[2, 0]);
            Assert.AreEqual(false, lightGrid.LightsOnGrid[3, 0]);
            Assert.AreEqual(false, lightGrid.LightsOnGrid[4, 0]);
            Assert.AreEqual(false, lightGrid.LightsOnGrid[0, 1]);
            Assert.AreEqual(false, lightGrid.LightsOnGrid[1, 1]);
            Assert.AreEqual(true, lightGrid.LightsOnGrid[2, 1]);
            Assert.AreEqual(false, lightGrid.LightsOnGrid[3, 1]);
            Assert.AreEqual(false, lightGrid.LightsOnGrid[4, 1]);
            Assert.AreEqual(false, lightGrid.LightsOnGrid[0, 2]);
            Assert.AreEqual(true, lightGrid.LightsOnGrid[1, 2]);
            Assert.AreEqual(true, lightGrid.LightsOnGrid[2, 2]);
            Assert.AreEqual(true, lightGrid.LightsOnGrid[3, 2]);
            Assert.AreEqual(false, lightGrid.LightsOnGrid[4, 2]);
            Assert.AreEqual(false, lightGrid.LightsOnGrid[0, 3]);
            Assert.AreEqual(false, lightGrid.LightsOnGrid[1, 3]);
            Assert.AreEqual(true, lightGrid.LightsOnGrid[2, 3]);
            Assert.AreEqual(false, lightGrid.LightsOnGrid[3, 3]);
            Assert.AreEqual(false, lightGrid.LightsOnGrid[4, 3]);
            Assert.AreEqual(false, lightGrid.LightsOnGrid[0, 4]);
            Assert.AreEqual(false, lightGrid.LightsOnGrid[1, 4]);
            Assert.AreEqual(false, lightGrid.LightsOnGrid[2, 4]);
            Assert.AreEqual(false, lightGrid.LightsOnGrid[3, 4]);
            Assert.AreEqual(false, lightGrid.LightsOnGrid[4, 4]);
            Assert.AreEqual(5, lightGrid.LightsOnCount);

            lightGrid.ProcessLightSwitch(2, 2);
            Assert.AreEqual(false, lightGrid.LightsOnGrid[0, 0]);
            Assert.AreEqual(false, lightGrid.LightsOnGrid[1, 0]);
            Assert.AreEqual(false, lightGrid.LightsOnGrid[2, 0]);
            Assert.AreEqual(false, lightGrid.LightsOnGrid[3, 0]);
            Assert.AreEqual(false, lightGrid.LightsOnGrid[4, 0]);
            Assert.AreEqual(false, lightGrid.LightsOnGrid[0, 1]);
            Assert.AreEqual(false, lightGrid.LightsOnGrid[1, 1]);
            Assert.AreEqual(false, lightGrid.LightsOnGrid[2, 1]);
            Assert.AreEqual(false, lightGrid.LightsOnGrid[3, 1]);
            Assert.AreEqual(false, lightGrid.LightsOnGrid[4, 1]);
            Assert.AreEqual(false, lightGrid.LightsOnGrid[0, 2]);
            Assert.AreEqual(false, lightGrid.LightsOnGrid[1, 2]);
            Assert.AreEqual(false, lightGrid.LightsOnGrid[2, 2]);
            Assert.AreEqual(false, lightGrid.LightsOnGrid[3, 2]);
            Assert.AreEqual(false, lightGrid.LightsOnGrid[4, 2]);
            Assert.AreEqual(false, lightGrid.LightsOnGrid[0, 3]);
            Assert.AreEqual(false, lightGrid.LightsOnGrid[1, 3]);
            Assert.AreEqual(false, lightGrid.LightsOnGrid[2, 3]);
            Assert.AreEqual(false, lightGrid.LightsOnGrid[3, 3]);
            Assert.AreEqual(false, lightGrid.LightsOnGrid[4, 3]);
            Assert.AreEqual(false, lightGrid.LightsOnGrid[0, 4]);
            Assert.AreEqual(false, lightGrid.LightsOnGrid[1, 4]);
            Assert.AreEqual(false, lightGrid.LightsOnGrid[2, 4]);
            Assert.AreEqual(false, lightGrid.LightsOnGrid[3, 4]);
            Assert.AreEqual(false, lightGrid.LightsOnGrid[4, 4]);
            Assert.AreEqual(0, lightGrid.LightsOnCount);
        }

        [TestMethod()]
        public void LightGridProcessLightSwitchTest__44()
        {
            LightGrid lightGrid = new LightGrid();

            lightGrid.ProcessLightSwitch(4, 4);
            Assert.AreEqual(false, lightGrid.LightsOnGrid[0, 0]);
            Assert.AreEqual(false, lightGrid.LightsOnGrid[1, 0]);
            Assert.AreEqual(false, lightGrid.LightsOnGrid[2, 0]);
            Assert.AreEqual(false, lightGrid.LightsOnGrid[3, 0]);
            Assert.AreEqual(false, lightGrid.LightsOnGrid[4, 0]);
            Assert.AreEqual(false, lightGrid.LightsOnGrid[0, 1]);
            Assert.AreEqual(false, lightGrid.LightsOnGrid[1, 1]);
            Assert.AreEqual(false, lightGrid.LightsOnGrid[2, 1]);
            Assert.AreEqual(false, lightGrid.LightsOnGrid[3, 1]);
            Assert.AreEqual(false, lightGrid.LightsOnGrid[4, 1]);
            Assert.AreEqual(false, lightGrid.LightsOnGrid[0, 2]);
            Assert.AreEqual(false, lightGrid.LightsOnGrid[1, 2]);
            Assert.AreEqual(false, lightGrid.LightsOnGrid[2, 2]);
            Assert.AreEqual(false, lightGrid.LightsOnGrid[3, 2]);
            Assert.AreEqual(false, lightGrid.LightsOnGrid[4, 2]);
            Assert.AreEqual(false, lightGrid.LightsOnGrid[0, 3]);
            Assert.AreEqual(false, lightGrid.LightsOnGrid[1, 3]);
            Assert.AreEqual(false, lightGrid.LightsOnGrid[2, 3]);
            Assert.AreEqual(false, lightGrid.LightsOnGrid[3, 3]);
            Assert.AreEqual(true, lightGrid.LightsOnGrid[4, 3]);
            Assert.AreEqual(false, lightGrid.LightsOnGrid[0, 4]);
            Assert.AreEqual(false, lightGrid.LightsOnGrid[1, 4]);
            Assert.AreEqual(false, lightGrid.LightsOnGrid[2, 4]);
            Assert.AreEqual(true, lightGrid.LightsOnGrid[3, 4]);
            Assert.AreEqual(true, lightGrid.LightsOnGrid[4, 4]);
            Assert.AreEqual(3, lightGrid.LightsOnCount);

            lightGrid.ProcessLightSwitch(4, 4);
            Assert.AreEqual(false, lightGrid.LightsOnGrid[0, 0]);
            Assert.AreEqual(false, lightGrid.LightsOnGrid[1, 0]);
            Assert.AreEqual(false, lightGrid.LightsOnGrid[2, 0]);
            Assert.AreEqual(false, lightGrid.LightsOnGrid[3, 0]);
            Assert.AreEqual(false, lightGrid.LightsOnGrid[4, 0]);
            Assert.AreEqual(false, lightGrid.LightsOnGrid[0, 1]);
            Assert.AreEqual(false, lightGrid.LightsOnGrid[1, 1]);
            Assert.AreEqual(false, lightGrid.LightsOnGrid[2, 1]);
            Assert.AreEqual(false, lightGrid.LightsOnGrid[3, 1]);
            Assert.AreEqual(false, lightGrid.LightsOnGrid[4, 1]);
            Assert.AreEqual(false, lightGrid.LightsOnGrid[0, 2]);
            Assert.AreEqual(false, lightGrid.LightsOnGrid[1, 2]);
            Assert.AreEqual(false, lightGrid.LightsOnGrid[2, 2]);
            Assert.AreEqual(false, lightGrid.LightsOnGrid[3, 2]);
            Assert.AreEqual(false, lightGrid.LightsOnGrid[4, 2]);
            Assert.AreEqual(false, lightGrid.LightsOnGrid[0, 3]);
            Assert.AreEqual(false, lightGrid.LightsOnGrid[1, 3]);
            Assert.AreEqual(false, lightGrid.LightsOnGrid[2, 3]);
            Assert.AreEqual(false, lightGrid.LightsOnGrid[3, 3]);
            Assert.AreEqual(false, lightGrid.LightsOnGrid[4, 3]);
            Assert.AreEqual(false, lightGrid.LightsOnGrid[0, 4]);
            Assert.AreEqual(false, lightGrid.LightsOnGrid[1, 4]);
            Assert.AreEqual(false, lightGrid.LightsOnGrid[2, 4]);
            Assert.AreEqual(false, lightGrid.LightsOnGrid[3, 4]);
            Assert.AreEqual(false, lightGrid.LightsOnGrid[4, 4]);
            Assert.AreEqual(0, lightGrid.LightsOnCount);
        }

        [TestMethod()]
        public void LightGridProcessLightSwitchTest__22_Alt()
        {
            LightGrid lightGrid = new LightGrid();
            lightGrid.LightsOnGrid[2, 2] = true;

            lightGrid.ProcessLightSwitch(2, 2);
            Assert.AreEqual(false, lightGrid.LightsOnGrid[0, 0]);
            Assert.AreEqual(false, lightGrid.LightsOnGrid[1, 0]);
            Assert.AreEqual(false, lightGrid.LightsOnGrid[2, 0]);
            Assert.AreEqual(false, lightGrid.LightsOnGrid[3, 0]);
            Assert.AreEqual(false, lightGrid.LightsOnGrid[4, 0]);
            Assert.AreEqual(false, lightGrid.LightsOnGrid[0, 1]);
            Assert.AreEqual(false, lightGrid.LightsOnGrid[1, 1]);
            Assert.AreEqual(true, lightGrid.LightsOnGrid[2, 1]);
            Assert.AreEqual(false, lightGrid.LightsOnGrid[3, 1]);
            Assert.AreEqual(false, lightGrid.LightsOnGrid[4, 1]);
            Assert.AreEqual(false, lightGrid.LightsOnGrid[0, 2]);
            Assert.AreEqual(true, lightGrid.LightsOnGrid[1, 2]);
            Assert.AreEqual(false, lightGrid.LightsOnGrid[2, 2]);
            Assert.AreEqual(true, lightGrid.LightsOnGrid[3, 2]);
            Assert.AreEqual(false, lightGrid.LightsOnGrid[4, 2]);
            Assert.AreEqual(false, lightGrid.LightsOnGrid[0, 3]);
            Assert.AreEqual(false, lightGrid.LightsOnGrid[1, 3]);
            Assert.AreEqual(true, lightGrid.LightsOnGrid[2, 3]);
            Assert.AreEqual(false, lightGrid.LightsOnGrid[3, 3]);
            Assert.AreEqual(false, lightGrid.LightsOnGrid[4, 3]);
            Assert.AreEqual(false, lightGrid.LightsOnGrid[0, 4]);
            Assert.AreEqual(false, lightGrid.LightsOnGrid[1, 4]);
            Assert.AreEqual(false, lightGrid.LightsOnGrid[2, 4]);
            Assert.AreEqual(false, lightGrid.LightsOnGrid[3, 4]);
            Assert.AreEqual(false, lightGrid.LightsOnGrid[4, 4]);
            Assert.AreEqual(4, lightGrid.LightsOnCount);

            lightGrid.ProcessLightSwitch(2, 2);
            Assert.AreEqual(false, lightGrid.LightsOnGrid[0, 0]);
            Assert.AreEqual(false, lightGrid.LightsOnGrid[1, 0]);
            Assert.AreEqual(false, lightGrid.LightsOnGrid[2, 0]);
            Assert.AreEqual(false, lightGrid.LightsOnGrid[3, 0]);
            Assert.AreEqual(false, lightGrid.LightsOnGrid[4, 0]);
            Assert.AreEqual(false, lightGrid.LightsOnGrid[0, 1]);
            Assert.AreEqual(false, lightGrid.LightsOnGrid[1, 1]);
            Assert.AreEqual(false, lightGrid.LightsOnGrid[2, 1]);
            Assert.AreEqual(false, lightGrid.LightsOnGrid[3, 1]);
            Assert.AreEqual(false, lightGrid.LightsOnGrid[4, 1]);
            Assert.AreEqual(false, lightGrid.LightsOnGrid[0, 2]);
            Assert.AreEqual(false, lightGrid.LightsOnGrid[1, 2]);
            Assert.AreEqual(true, lightGrid.LightsOnGrid[2, 2]);
            Assert.AreEqual(false, lightGrid.LightsOnGrid[3, 2]);
            Assert.AreEqual(false, lightGrid.LightsOnGrid[4, 2]);
            Assert.AreEqual(false, lightGrid.LightsOnGrid[0, 3]);
            Assert.AreEqual(false, lightGrid.LightsOnGrid[1, 3]);
            Assert.AreEqual(false, lightGrid.LightsOnGrid[2, 3]);
            Assert.AreEqual(false, lightGrid.LightsOnGrid[3, 3]);
            Assert.AreEqual(false, lightGrid.LightsOnGrid[4, 3]);
            Assert.AreEqual(false, lightGrid.LightsOnGrid[0, 4]);
            Assert.AreEqual(false, lightGrid.LightsOnGrid[1, 4]);
            Assert.AreEqual(false, lightGrid.LightsOnGrid[2, 4]);
            Assert.AreEqual(false, lightGrid.LightsOnGrid[3, 4]);
            Assert.AreEqual(false, lightGrid.LightsOnGrid[4, 4]);
            Assert.AreEqual(1, lightGrid.LightsOnCount);
        }
    }
}