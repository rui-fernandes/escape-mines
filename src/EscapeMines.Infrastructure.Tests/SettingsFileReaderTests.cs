namespace EscapeMines.Infrastructure.Tests
{
    using System;
    using EscapeMines.Application;
    using FluentAssertions;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class SettingsFileReaderTests
    {
        [TestMethod]
        public void GetSettings_ValidFile_GameSettingsReturned()
        {
            // Arrange
            var reader = new SettingsFileReader(".\\Settings\\GameTestSettings.txt");

            // Act
            var result = reader.GetSettings();

            // Assert
            result.Should().NotBeNull();
        }

        [TestMethod]
        public void GetSettings_InvalidFile_ExceptionThrown()
        {
            // Arrange
            var reader = new SettingsFileReader(".\\Settings\\GameTestSettings2.txt");

            // Act
            Action act = () => reader.GetSettings();

            // Assert
            act.Should().Throw<Exception>();
        }
    }
}
