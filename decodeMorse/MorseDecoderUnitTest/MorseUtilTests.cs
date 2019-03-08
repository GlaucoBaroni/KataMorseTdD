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
    }
}
