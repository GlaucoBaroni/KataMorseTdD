using System;
using decodeMorse;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MorseDecoderUnitTest
{
    [TestClass]
    public class MorseUtilTests
    {
        [TestMethod]
        public void ExistMorseDictionary()
        {
            bool expected = true;
            MorseUtil morseUtil = new MorseUtil();
            bool actual = false;
            actual = morseUtil.isLoad();
            Assert.AreEqual(expected, actual, "Morse not loaded");
        }

        [TestMethod]
        public void DecodeMethod_PassEmptyString_ReturnEmptyString()
        {
            string inputstring = string.Empty;
            string expected = string.Empty;
            MorseUtil morseUtil = new MorseUtil();
            string actual = "notempty";
            try
            {
                actual = morseUtil.Decode(inputstring);
                Assert.AreEqual(expected, actual, "String returned not empty");
            }
            catch (Exception e)
            {
                Assert.AreEqual(expected, actual,e.Message);
            }            
        }
    }
}
