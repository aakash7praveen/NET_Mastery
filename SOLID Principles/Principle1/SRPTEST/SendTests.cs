using System;
using System.IO;
using FluentAssertions;
using ManagementAPI._1;
using Xunit;

namespace SRPTEST
{
    public class SaverTests
    {
        [Fact]
        public void SaveToFile_WithValidContent_ShouldCreateFile()
        {
            var report = new Report("Test content");
            var saver = new Saver();
            var filePath = "test_report.txt";

            saver.SaveTofile(filePath, report);

            File.Exists(filePath).Should().BeTrue();
            File.ReadAllText(filePath).Should().Be("Test content");

            File.Delete(filePath);
        }

        [Fact]
        public void SaveToFile_WithWrongExpectedContent()
        {
            var report = new Report("Actual Content");
            var saver = new Saver();
            var filePath = "test_report.txt";

            saver.SaveTofile(filePath, report);

            string fileContent = File.ReadAllText(filePath);
            fileContent.Should().Be("Expected but wrong content", "Test Failure");

            File.Delete(filePath);
        }

        [Fact]
        public void SaveToFile_WithEmptyContent()
        {
            var report = new Report("");
            var saver = new Saver();
            var filePath = "test_report.txt";

            Action act = () => saver.SaveTofile(filePath, report);

            act.Should().Throw<InvalidOperationException>("Because the report content is empty and we expect a failure");

            if (File.Exists(filePath))
                File.Delete(filePath);
        }
    }
}
