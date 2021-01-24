namespace EscapeMines.IntegrationTests
{
    using System;
    using FluentAssertions;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class ProgramTests
    {
        [TestMethod]
        public void ExecuteProgram_SuccessSettings_NoErrorReturned()
        {
            // Act
            Action act = () => Program.Main(
                new string[] { ".\\Settings\\SuccessGameTestSettings.txt" });

            // Assert
            act.Should().NotThrow();
        }

        [TestMethod]
        public void ExecuteProgram_MineHitSettings_NoErrorReturned()
        {
            // Act
            Action act = () => Program.Main(
                new string[] { ".\\Settings\\MineHitGameTestSettings.txt" });

            // Assert
            act.Should().NotThrow();
        }

        [TestMethod]
        public void ExecuteProgram_DangerSettings_NoErrorReturned()
        {
            // Act
            Action act = () => Program.Main(
                new string[] { ".\\Settings\\DangerGameTestSettings.txt" });

            // Assert
            act.Should().NotThrow();
        }
    }
}
