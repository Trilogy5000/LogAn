using LogAn.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogAn.UnitTests
{
    [TestFixture]
    public class LogAnalyzerTests
    {
        private LogAnalyzer m_analyzer;

        [SetUp]
        public void Setup()
        {
            m_analyzer = new LogAnalyzer();
        }
        
        [Test]
        public void IsValidLogFileName_BadExtension_ReturnsFalse()
        {            
            bool result = m_analyzer.IsValidLogFileName("filewithbadextension.foo");
            
            Assert.IsFalse(result);            
        }
        
        [TestCase("filewithgoodextension.SLF", true)]
        [TestCase("filewithgoodextension.slf", true)]        
        public void IsValidLogFileName_GoodExtensionUppercase_ReturnsTrue(string file, bool expected)
        {            
            bool actual = m_analyzer.IsValidLogFileName(file);
         
            Assert.That(actual, Is.EqualTo(expected));
        }

        //[Test]
        //public void IsValidFileName_EmptyFileName_Throws()
        //{
        //    Exception? ex = Assert.Catch<Exception>(() => m_analyzer.IsValidLogFileName(""));

        //    StringAssert.Contains("filename has to be provided", ex.Message);
        //}
    }
}
