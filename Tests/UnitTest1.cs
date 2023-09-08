using App; 

namespace Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
         
        public void TestRomanNumberParse()
        {
            Assert.AreEqual(1, RomanNumber.Parse("I").Value);
            Assert.AreEqual(2, RomanNumber.Parse("II").Value);
            Assert.AreEqual(3, RomanNumber.Parse("III").Value);
            Assert.AreEqual(4, RomanNumber.Parse("IV").Value);
            Assert.AreEqual(5, RomanNumber.Parse("V").Value);
            Assert.AreEqual(6, RomanNumber.Parse("VI").Value);
            Assert.AreEqual(7, RomanNumber.Parse("VII").Value);
            Assert.AreEqual(8, RomanNumber.Parse("VIII").Value);
            Assert.AreEqual(9, RomanNumber.Parse("IX").Value);
            Assert.AreEqual(10, RomanNumber.Parse("X").Value);
            Assert.AreEqual(11, RomanNumber.Parse("XI").Value);
            Assert.AreEqual(12, RomanNumber.Parse("XII").Value);
            Assert.AreEqual(13, RomanNumber.Parse("XIII").Value);
            Assert.AreEqual(14, RomanNumber.Parse("XIV").Value);
            Assert.AreEqual(15, RomanNumber.Parse("XV").Value);
            Assert.AreEqual(16, RomanNumber.Parse("XVI").Value);
            Assert.AreEqual(17, RomanNumber.Parse("XVII").Value);
            Assert.AreEqual(18, RomanNumber.Parse("XVIII").Value);
            Assert.AreEqual(19, RomanNumber.Parse("XIX").Value);
            Assert.AreEqual(20, RomanNumber.Parse("XX").Value);
            Assert.AreEqual(21, RomanNumber.Parse("XXI").Value);
            Assert.AreEqual(22, RomanNumber.Parse("XXII").Value);
            Assert.AreEqual(23, RomanNumber.Parse("XXIII").Value);
            Assert.AreEqual(24, RomanNumber.Parse("XXIV").Value);
            Assert.AreEqual(25, RomanNumber.Parse("XXV").Value);
            Assert.AreEqual(26, RomanNumber.Parse("XXVI").Value);
            Assert.AreEqual(27, RomanNumber.Parse("XXVII").Value);
            Assert.AreEqual(28, RomanNumber.Parse("XXVIII").Value);
            Assert.AreEqual(29, RomanNumber.Parse("XXIX").Value);
            Assert.AreEqual(30, RomanNumber.Parse("XXX").Value);
            Assert.AreEqual(31, RomanNumber.Parse("XXXI").Value);
            Assert.AreEqual(32, RomanNumber.Parse("XXXII").Value);
            Assert.AreEqual(33, RomanNumber.Parse("XXXIII").Value);
            Assert.AreEqual(34, RomanNumber.Parse("XXXIV").Value);
            Assert.AreEqual(35, RomanNumber.Parse("XXXV").Value);
            Assert.AreEqual(36, RomanNumber.Parse("XXXVI").Value);
            Assert.AreEqual(37, RomanNumber.Parse("XXXVII").Value);
            Assert.AreEqual(38, RomanNumber.Parse("XXXVIII").Value);
            Assert.AreEqual(39, RomanNumber.Parse("XXXIX").Value);
            Assert.AreEqual(40, RomanNumber.Parse("XL").Value);
            Assert.AreEqual(41, RomanNumber.Parse("XLI").Value);
            Assert.AreEqual(42, RomanNumber.Parse("XLII").Value);
            Assert.AreEqual(43, RomanNumber.Parse("XLIII").Value);
            Assert.AreEqual(44, RomanNumber.Parse("XLIV").Value);
            Assert.AreEqual(45, RomanNumber.Parse("XLV").Value);
            Assert.AreEqual(46, RomanNumber.Parse("XLVI").Value);
            Assert.AreEqual(47, RomanNumber.Parse("XLVII").Value);
            Assert.AreEqual(48, RomanNumber.Parse("XLVIII").Value);
            Assert.AreEqual(49, RomanNumber.Parse("XLIX").Value);
            Assert.AreEqual(50, RomanNumber.Parse("L").Value);
            Assert.AreEqual(51, RomanNumber.Parse("LI").Value);
            Assert.AreEqual(52, RomanNumber.Parse("LII").Value);
            Assert.AreEqual(53, RomanNumber.Parse("LIII").Value);
            Assert.AreEqual(54, RomanNumber.Parse("LIV").Value);
            Assert.AreEqual(55, RomanNumber.Parse("LV").Value);
            Assert.AreEqual(56, RomanNumber.Parse("LVI").Value);
            Assert.AreEqual(57, RomanNumber.Parse("LVII").Value);
            Assert.AreEqual(58, RomanNumber.Parse("LVIII").Value);
            Assert.AreEqual(59, RomanNumber.Parse("LIX").Value);
            Assert.AreEqual(60, RomanNumber.Parse("LX").Value);
            Assert.AreEqual(61, RomanNumber.Parse("LXI").Value);
            Assert.AreEqual(62, RomanNumber.Parse("LXII").Value);
            Assert.AreEqual(63, RomanNumber.Parse("LXIII").Value);
            Assert.AreEqual(64, RomanNumber.Parse("LXIV").Value);
            Assert.AreEqual(65, RomanNumber.Parse("LXV").Value);
            Assert.AreEqual(66, RomanNumber.Parse("LXVI").Value);
            Assert.AreEqual(67, RomanNumber.Parse("LXVII").Value);
            Assert.AreEqual(68, RomanNumber.Parse("LXVIII").Value);
            Assert.AreEqual(69, RomanNumber.Parse("LXIX").Value);
            Assert.AreEqual(70, RomanNumber.Parse("LXX").Value);
            Assert.AreEqual(71, RomanNumber.Parse("LXXI").Value);
            Assert.AreEqual(72, RomanNumber.Parse("LXXII").Value);
            Assert.AreEqual(73, RomanNumber.Parse("LXXIII").Value);
            Assert.AreEqual(74, RomanNumber.Parse("LXXIV").Value);
            Assert.AreEqual(75, RomanNumber.Parse("LXXV").Value);
            Assert.AreEqual(76, RomanNumber.Parse("LXXVI").Value);
            Assert.AreEqual(77, RomanNumber.Parse("LXXVII").Value);
            Assert.AreEqual(78, RomanNumber.Parse("LXXVIII").Value);
            Assert.AreEqual(79, RomanNumber.Parse("LXXIX").Value);
            Assert.AreEqual(80, RomanNumber.Parse("LXXX").Value);
            Assert.AreEqual(81, RomanNumber.Parse("LXXXI").Value);
            Assert.AreEqual(82, RomanNumber.Parse("LXXXII").Value);
            Assert.AreEqual(83, RomanNumber.Parse("LXXXIII").Value);
            Assert.AreEqual(84, RomanNumber.Parse("LXXXIV").Value);
            Assert.AreEqual(85, RomanNumber.Parse("LXXXV").Value);
            Assert.AreEqual(86, RomanNumber.Parse("LXXXVI").Value);
            Assert.AreEqual(87, RomanNumber.Parse("LXXXVII").Value);
            Assert.AreEqual(88, RomanNumber.Parse("LXXXVIII").Value);
            Assert.AreEqual(89, RomanNumber.Parse("LXXXIX").Value);
            Assert.AreEqual(90, RomanNumber.Parse("XC").Value);
            Assert.AreEqual(91, RomanNumber.Parse("XCI").Value);
            Assert.AreEqual(92, RomanNumber.Parse("XCII").Value);
            Assert.AreEqual(93, RomanNumber.Parse("XCIII").Value);
            Assert.AreEqual(94, RomanNumber.Parse("XCIV").Value);
            Assert.AreEqual(95, RomanNumber.Parse("XCV").Value);
            Assert.AreEqual(96, RomanNumber.Parse("XCVI").Value);
            Assert.AreEqual(97, RomanNumber.Parse("XCVII").Value);
            Assert.AreEqual(98, RomanNumber.Parse("XCVIII").Value);
            Assert.AreEqual(99, RomanNumber.Parse("XCIX").Value);
            Assert.AreEqual(100, RomanNumber.Parse("C").Value);
        }

        [TestMethod]
        public void TestRomanNumberInvalid()
        {
            Assert.ThrowsException<ArgumentException>(() => RomanNumber.Parse(null!), "() => RomanNumber.Parse(null!)");
            var ex = Assert.ThrowsException<ArgumentException>(() => RomanNumber.Parse(""), "() => RomanNumber.Parse(\"\")");

            Assert.IsFalse(String.IsNullOrEmpty(ex.Message), "Exception message is null or empty");


            var testCases = new Dictionary<string, string>()
            {
                {"XA","A" },
                {"G","G" },
                {"#","#" },
                {"$","$" },
                {"F","F" },
                {"%","%" },
                {"T","T" },
                {"@","@" },
            };

            foreach (var testCase in testCases)
            {
                ex = Assert.ThrowsException<ArgumentException>(() => RomanNumber.Parse(testCase.Key), $"Roman number parse {testCase.Key} -> Exception");

                Assert.IsTrue(ex.Message.Contains($"'{testCase.Value}'"));
            }

        }

        [TestMethod]
        public void TestRomanNumberDubious()
        {
            string[] dubious = { " XC", "XC ", "\tXC", "\nXC" };

            foreach (var dub in dubious)
            {
                var parseResult = RomanNumber.Parse(dub);
                Assert.IsNotNull(parseResult, $"{dub} cause null");
                Assert.AreEqual(parseResult.Value, 90);
            }

        }
    }
}