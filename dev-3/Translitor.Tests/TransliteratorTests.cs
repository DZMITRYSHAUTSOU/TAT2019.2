using System;
using dev_3;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace dev_3Tests
{
    [TestClass]
    public class TransliteratorTests
    {
        #region Positive
        [TestMethod]
        public void TranslitPositive()
        {
            Assert.AreEqual(new Transliterator("абвгдежзийклмнопрстуфхцчшщъыьэюяё").Translit(), "abvgdezhziyklmnoprstufkhtschshschyeyuyayo");
        }

        [TestMethod]
        public void TranslitPositive2()
        {
            Assert.AreEqual(new Transliterator("a, b, c, d, e, f, g, h, i, j, k, l, m, n, o, p, q, r, s, t, u, v, w, x, y, z").Translit(),
                "а, б, c, д, е, ф, г, h, и, j, к, л, м, н, о, п, q, р, с, т, у, в, w, x, й, з");
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidFormatException))]
        public void TranslitPositive3()
        {
            new Transliterator(null).Translit();
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidFormatException))]
        public void TranslitPositive4()
        {
            new Transliterator("wklвгд").Translit();
        }
        #endregion

        #region Negative
        [TestMethod]
        public void TranslitNegative()
        {
            Assert.AreNotEqual(new Transliterator("shch").Translit(),"щ");
        }

        [TestMethod]
        public void TranslitNegative2()
        {
            Assert.AreNotEqual(new Transliterator("j").Translit(), "ж");
        }

        [TestMethod]
        public void TranslitNegative3()
        {
            Assert.AreNotEqual(new Transliterator("w").Translit(), "в");
        }
        #endregion
    }
}