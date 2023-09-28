using App;
using System.Linq;

namespace Tests
{
    [TestClass]
    public class UnitTestRomanNumber
    {
        [TestMethod]
        public void TestToString()
        {
            Dictionary<int, String> testCases = new()
            {
                {0, "N" },
                {1, "I" },
                {2, "II" },
                {3, "III" },
                {4, "IV" },
                {5, "V" },
                {6, "VI" },
                {7, "VII" },
                {8, "VIII" },
                {9, "IX" },
                {10, "X" },
                {11, "XI" },
                {12, "XII" },
                {13, "XIII" },
                {14, "XIV" },
                {15, "XV" },
                {16, "XVI" },
                {17, "XVII" },
                {18, "XVIII" },
                {19, "XIX" },
                {20, "XX" },
                {21, "XXI" },
                {22, "XXII" },
                {23, "XXIII" },
                {29, "XXIX"},
                {30, "XXX" },
                {33, "XXXIII" },
                {39, "XXXIX"},
                {40, "XL" },
                {44, "XLIV" },
                {48, "XLVIII" },
                {50, "L" },
                {51, "LI" },
                {52, "LII" },
                {55, "LV" },
                {59, "LIX" },
                {62, "LXII" },
                {64, "LXIV" },
                {66, "LXVI" },
                {75, "LXXV" },
                {77, "LXXVII" },
                {81, "LXXXI" },
                {88, "LXXXVIII" },
                {90, "XC" },
                {92, "XCII" },
                {99, "XCIX" },
                {100, "C" },
                {105, "CV" },
                {107, "CVII" },
                {111, "CXI" },
                {115, "CXV" },
                {123, "CXXIII" },
                {222, "CCXXII" },
                {234, "CCXXXIV" },
                {246, "CCXLVI"},
                {321, "CCCXXI" },
                {333, "CCCXXXIII" },
                {345, "CCCXLV" },
                {378, "CCCLXXVIII"},
                {404, "CDIV" },
                {444, "CDXLIV" },
                {456, "CDLVI" },
                {500, "D" },
                {555, "DLV" },
                {567, "DLXVII" },
                {609, "DCIX" },
                {666, "DCLXVI" },
                {678, "DCLXXVIII" },
                {777, "DCCLXXVII" },
                {789, "DCCLXXXIX" },
                {888, "DCCCLXXXVIII" },
                {890, "DCCCXC" },
                {901, "CMI" },
                {999, "CMXCIX" },
                {1000, "M" },
                {1007, "MVII" },
                {1111, "MCXI" },
                {1199, "MCXCIX"},
                {1234, "MCCXXXIV" },
                {1317, "MCCCXVII" },
                {1350, "MCCCL"},
                {1432, "MCDXXXII" },
                {1500, "MD" },
                {1575, "MDLXXV" },
                {1632, "MDCXXXII" },
                {1667, "MDCLXVII" },
                {1734, "MDCCXXXIV" },
                {1872, "MDCCCLXXII" },
                {1969, "MCMLXIX" },
                {1985, "MCMLXXXV" },
                {2023, "MMXXIII" },
                {2048, "MMXLVIII" },
                {2107, "MMCVII" },
                {2184, "MMCLXXXIV" },
                {2222, "MMCCXXII" },
                {2247, "MMCCXLVII"},
                {2288, "MMCCLXXXVIII" },
                {2345, "MMCCCXLV" },
                {2392, "MMCCCXCII" },
                {2496, "MMCDXCVI" },
                {2499, "MMCDXCIX"},
                {2500, "MMD" },
                {2678, "MMDCLXXVIII" },
                {2700, "MMDCC"},
                {2781, "MMDCCLXXXI" },
                {2884, "MMDCCCLXXXIV" },
                {2958, "MMCMLVIII" },
                {2999, "MMCMXCIX"},
                {3000, "MMM" },
                {-1968, "-MCMLXVIII" },
                {-1272, "-MCCLXXII" },
                {-1456, "-MCDLVI" },
                {-1785, "-MDCCLXXXV" },
                {-2142, "-MMCXLII" },
                {-2266, "-MMCCLXVI" },
                {-2510, "-MMDX" },
                {-2727, "-MMDCCXXVII" },
                {-2814, "-MMDCCCXIV" },
                {-2987, "-MMCMLXXXVII" },
                { -23, "-XXIII" },
                { -169, "-CLXIX" },
                { -313, "-CCCXIII" },
                { -996, "-CMXCVI" },
                { -2998, "-MMCMXCVIII"},
                { -2947, "-MMCMXLVII" },
                { -2970, "-MMCMLXX" },
                { -2730, "-MMDCCXXX" },
                { -2756, "-MMDCCLVI" },
                { -2767, "-MMDCCLXVII" },
                { -2777, "-MMDCCLXXVII" },
                { -2799, "-MMDCCXCIX" },
                { -1603, "-MDCIII" },
                { -1674, "-MDCLXXIV" },
                { -1718, "-MDCCXVIII" },
                { -1742, "-MDCCXLII" },
                { -1747, "-MDCCXLVII" },
                { -1784, "-MDCCLXXXIV" },
                { -1796, "-MDCCXCVI" },
                { -1884, "-MDCCCLXXXIV" },
                { -1945, "-MCMXLV" },
                { -1951, "-MCMLI" },
                { -1972, "-MCMLXXII" },
                { -1980, "-MCMLXXX" },
                { -456, "-CDLVI" },
                { -500, "-D" },
                { -555, "-DLV" },
                { -567, "-DLXVII" },
                { -609, "-DCIX" },
                { -666, "-DCLXVI" },
                { -678, "-DCLXXVIII" },
                { -777, "-DCCLXXVII" },

            };
            foreach (var pair in testCases)
            {
                Assert.AreEqual(pair.Value, new RomanNumber(pair.Key).ToString(), $"{pair.Key}.ToString() == {pair.Value}");
            }
            Assert.AreEqual("N",
                new RomanNumber().ToString(),
                $"new RomanNumber() == 'N'");
        }

        private static Dictionary<String, int> parseTests = new()
        {
            {"I"          , 1 },
            {"II"         , 2 },
            {"III"        , 3 },
            {"IIII"       , 4 }, // Îńîáëčâł ňâĺđäćĺíí˙ - ç íčő ěč âčçíŕ÷ŕşěî ďđî
            {"IV"         , 4 }, // ďłäňđčěęó íĺîďňčěŕëüíčő çŕďčńłâ ÷čńĺë
            {"V"          , 5 },
            {"VI"         , 6 },
            {"VII"        , 7 },
            {"VIII"       , 8 },
            {"IX"         , 9 },
            { "X"         , 10 },
            { "VV"        , 10 }, // ůĺ îäíĺ íŕăîëîřĺíí˙ íĺîďňčěŕëüíîńňł
            { "IIIIIIIIII", 10 }, // ůĺ îäíĺ íŕăîëîřĺíí˙ íĺîďňčěŕëüíîńňł
            { "VX"        , 5 }, // ůĺ îäíĺ íŕăîëîřĺíí˙ íĺîďňčěŕëüíîńňł
            { "N"         , 0 }, // äîďîâíţşěî ěíîćčíó ÷čńĺë íóëĺě
            { "-L"        , -50 }, // âęŕçóşěî, ůî ěîćëčâł âłä'şěíł ÷čńëŕ
            { "-XL"       , -40 },
            { "-IL"       , -49 }, // íĺîďňčěŕëüíîńňłńňü
            { "C"         , 100 },
            { "D"         , 500 },
            { "M"         , 1000 },
            { "CCCC"      , 400 },
            { "XD"        , 490 },
            { "LM"        , 950 },
            { "CDX"       , 410 },
            { "DDD"       , 1500 },
            { "VM"        , 995 },
            { "MDCC"      , 1700 },
            { "DDDIV"     , 1504 },
            { "MMMM"      , 4000 },
            {"LX"         , 60 },
            {"LXII"       , 62 },
            {"CCL"        , 250 },
            {"-CCIII"     , -203 },
            {"-LIV"       , -54},
            {"MDII"       , 1502 },
            { "-D"        , -500 },
            { "-C"        , -100 },
            { "-M"        , -1000 },
            { "IM"        , 999 },
            { "-IM"       , -999 },
            { "IC"        , 99 },
            { "-IC"       , -99 },
            { "ID"        , 499 },
            { "-ID"       , -499 },
            { "-VM"       , -995 },
            { "VC"        , 95 },
            { "-VC"       , -95 },
            { "VD"        , 495 },
            { "-VD"       , -495 },
            { "XM"        , 990 },
            { "-XM"       , -990 },
            { "XC"        , 90 },
            { "-XC"       , -90 },
            { "-XD"       , -490 },
            { "MI"        , 1001 },
            { "-MI"       , -1001 },
            { "CI"        , 101 },
            { "-CI"       , -101 },
            { "DI"        , 501 },
            { "-DI"       , -501 },
            { "MV"        , 1005 },
            { "-MV"       , -1005 },
            { "CV"        , 105 },
            { "-CV"       , -105 },
            { "DV"        , 505 },
            { "-DV"       , -505 },
            { "MX"        , 1010 },
            { "-MX"       , -1010 },
            { "CX"        , 110 },
            { "-CX"       , -110 },
            { "DX"        , 510 },
            { "-DX"       , -510 },
            { "CMD"       , 1400 },
            { "CLI"       , 151},
            { "DIL"       , 549},
            { "DID"       , 999},
            { "DMC"       , 600},
            {"MMXXIII"    , 2023},
            {"CDIV"       , 404},
            {"CDXXXXIV"       , 444},
            {"DXXXXV"       , 545},
            {"DVVV"       , 515},
            {"CVIIIII"       , 110},
            {"DVD"       , 995},
            {"DDDD"       , 2000},
            {"XXXXXX"       , 60},
            {"IXIXIXIX"       , 36},
            {"ILIL"       , 98},
            {"XLX"       , 50},
            {"LC"       , 50},
            {"CCCCC"       , 500},
            {"ICI"       , 100},
            {"XCX"       , 100},
            {"XDX"       , 500},
            {"XMX"       , 1000},
            {"XXVV"       , 30},
            {"LLLLL"       , 250},
            {"XXXXXXXIIIIIII"       , 77},
            {"DXXXX"       , 540},
            {"DIIIII"       , 505},
            {"DIIIII "       , 505},
            {" DIIIII "       , 505},
            {" DIIIII"       , 505},
            {"\nDIIIII\t"       , 505},
        };

        [TestMethod]
        public void TestParseValid()
        {
            Assert.AreEqual(                   // RomanNumber.Parse("I").Value == 1
                1,                             // Çíŕ÷ĺíí˙, ůî î÷łęóşňüń˙ (ůî ěŕş áóňč, ďđŕâčëüíčé âŕđłŕíň)
                 RomanNumber                   // Ŕęňóŕëüíĺ çíŕ÷ĺíí˙ (ňĺ, ůî âčđŕőóâŕíĺ)
                 .Parse("I")                   //
                 .Value                        //
                 , "1 == I");                  // Ďîâłäîěëĺíí˙, ůî ç'˙âčňüń˙ ďđč ďđîâŕëł ňĺńňó
            foreach (var pair in parseTests)
            {
                Assert.AreEqual(
                pair.Value,
                 RomanNumber
                 .Parse(pair.Key)
                 .Value
                 , $"{pair.Value} == {pair.Key}");
            }

        }

        [TestMethod]
        public void TestParseNonValid()
        {
            // Ňĺńňóâŕíí˙ ç íĺďđŕâčëüíčěč ôîđěŕěč ÷čńĺë
            Assert.ThrowsException<ArgumentException>(
            () => RomanNumber.Parse(null!), "null -> ArgumentException");
            Assert.ThrowsException<ArgumentException>(
            () => RomanNumber.Parse(""), "'' -> ArgumentException");
            // ńŕěĺ âčęëţ÷ĺíí˙, ůî âčíčęëî ó ë˙ěáäł, ďîâĺđňŕşňüń˙ ˙ę đĺç-ň
            var ex = Assert.ThrowsException<ArgumentException>(
            () => RomanNumber.Parse("XBC"), "XBC -> ArgumentException");
            // âčěŕăŕşěî, ůîá âłäîěîńňł ďđî íĺďđŕâčëüíó öčôđó ('B') áóëî
            // âęëţ÷ĺíî ó ďîâłäîěëĺíí˙ âčęëţ÷ĺíí˙
            Assert.IsTrue(ex.Message.Contains('B'), "ex.Message should Contain 'B'");
            Dictionary<String, Char> testCases = new()
            {
                { "Xx", 'x' },
                { "Xy", 'y' },
                { "AX", 'A' },
                { "X C", ' ' },
                { "X\tC", '\t' },
                { "X\nC", '\n' },
                { "X-C", '-' },
            };
            foreach (var pair in testCases)
            {
                Assert.IsTrue(
                    Assert.ThrowsException<ArgumentException>(
                    () => RomanNumber.Parse(pair.Key),
                    $"'{pair.Key}' -> ArgumentException")
                        .Message.Contains($"'{pair.Value}'"),
                    $"ex.Message should Contain '{pair.Value}'");
            }
            ex = Assert.ThrowsException<ArgumentException>(
                () => RomanNumber.Parse("ABC"), "'' -> ArgumentException");

            Assert.IsTrue(ex.Message.Contains('A') && ex.Message.Contains('B'),
                "'ABC' ex.Message should Contain 'A' and 'B'");
            // Äë˙ íĺďđŕâčëüíčő ÷čńĺë âčěŕăŕşěî ďĺđĺëłę
            // óńłő öčôđ (ńčěâîëłâ), ůî íĺ ş ďđčďóńňčěčěč

            // * ďĺđĺâłđčěî, ůî ďîâłäîěëĺíí˙(âčęëţ÷ĺíí˙) íĺ çŕíŕäňî ęîđîňęĺ
            // ěîâó ÷č łířł ńëîâŕ íĺ âńňŕíîâëţşěî, ŕëĺ ůîá íĺ îäíŕ ëłňĺđŕ -
            // íŕęëŕäĺěî óěîâó íŕ äîâćčíó ďîâłäîěëĺíí˙ (15 ëłňĺđ)
            Assert.IsFalse(ex.Message.Length < 15, "ex.Message.Length min 15");
        }

        [TestMethod]
        public void CrossTest()
        {
            int random = 0;
            for (int i = 0; i < 256; i++)
            {
                random = Random.Shared.Next(6001) - 3000;
                Assert.AreEqual(random,
                    RomanNumber
                 .Parse(new RomanNumber(random).ToString())
                 .Value,
                    $"{random}.ToString() == {random}");
            }
        }

        [TestMethod]
        public void TestParseIllegal()
        {
            String[] illegals =
            {
                "IIV",
                "IIX",
                "VVX",
                "IVX-",
                "IIIX",
                "VIX",
                "INIILN",
                "IIID",
                "IIINM",
                "IIIC",
                "IIIVXN",
                "IIXIVN",
                "IXNIIXINV",
                "LLLC",
                "LLC",
                "XXXC-",
                "LLD",
                "LLNLM",
                "DDM",
                "XMXXM",
                "IIM",
                "IIL",
                "I-IC",
                "INID",
                "MDDM",
                "MCC-M",
                "M-CCC-M",
                "MVIM",
                "VIIM",
                "VIIC",
                "VIIX",
                "VIID",
                "VIIL",
                "IVID--",
                "IV-IM",
                "I-VIC",
                "IVIX-X",
                "-NX",
                "X-",
            };
            foreach (String illegal in illegals)
            {
                Assert.ThrowsException<ArgumentException>(
                () => RomanNumber.Parse(illegal),
                $"'{illegal}' -> Exception");
            }

        }

        [TestMethod]
        public void TestAdd()
        {
            RomanNumber r1 = new(10);
            RomanNumber r2 = new(20);
            Assert.AreEqual("XXX", r1.Add(r2).ToString());
            Assert.AreEqual(30, r1.Add(r2).Value);
            Assert.AreEqual("XXX", r2.Add(r1).ToString());
            Assert.AreEqual(30, r2.Add(r1).Value);
            Assert.AreEqual("L", r2.Add(r1, r1, r1).ToString());
            Assert.AreEqual(50, r2.Add(r1, r1, r1).Value);

            //var ex = Assert.ThrowsException<ArgumentNullException>(
            //() => r1.Add(null!),
            //$"r1.Add(null!) -> ArgumentNullException");

            //Assert.IsTrue(
            //    ex.Message.Contains("Cannot Add null object", StringComparison.OrdinalIgnoreCase),
            //    $"ex.Message{ex.Message} should Contain 'Cannot Add null object'"
            //    );
            //Assert.AreNotSame(r2,r2.Add(r1),"Add() should return new item");
            // "Cannot Add null object"
        }

        [TestMethod]
        public void TestSum()
        {
            RomanNumber r1 = new(10);
            RomanNumber r2 = new(20);
            var r3 = RomanNumber.Sum(r1, r2);
            Assert.IsInstanceOfType(r3, typeof(RomanNumber));
            Assert.AreNotSame(r3, r1);
            Assert.AreNotSame(r3, r2);
            Assert.AreEqual(60, RomanNumber.Sum(r1, r2, r3).Value);

            var ex = Assert.ThrowsException<ArgumentNullException>(
                () => RomanNumber.Sum(null!),
                "Sum(null!) ThrowsException: ArgumentNullException");
            String expectedFragment = "Invalid Sum() invocation with NULL argument";
            Assert.IsTrue(ex.Message.Contains(expectedFragment, StringComparison.OrdinalIgnoreCase), $"ex.Message should Contain {expectedFragment}");

            var emptyArr = Array.Empty<RomanNumber>();
            Assert.AreEqual(0, RomanNumber.Sum(emptyArr).Value, "Sum(empty) == 0");
            Assert.AreEqual(0, RomanNumber.Sum().Value, "Sum(empty) == 0");

            Assert.AreEqual(10, RomanNumber.Sum(r1).Value, "Sum(r1) == 10");

            Assert.AreEqual(0, RomanNumber.Sum(new(10), new(-10)).Value);
            Assert.AreEqual(-1, RomanNumber.Sum(new(10), new(-11)).Value);
            Assert.AreEqual(1, RomanNumber.Sum(new(10), new(-9)).Value);
            int random = 0;
            int random2 = 0;
            for (int i = 0; i < 256; i++)
            {
                random = Random.Shared.Next(3001) - 3000;
                random2 = Random.Shared.Next(3001) - 3000;
                Assert.AreEqual(random + random2, RomanNumber.Sum(new(random), new(random2)).Value, $"{random} + {random2} == {random + random2}");
            }
            Random r = new();
            for (int i = 0; i < 256; i++)
            {
                RomanNumber x = new(r.Next(-3000, 3000));
                RomanNumber y = new(r.Next(-3000, 3000));
                Assert.AreEqual(x.Add(y).Value, RomanNumber.Sum(x, y).Value, $"{x} + {y} == x + y");
            }
        }

        [TestMethod]
        public void TestEval()
        {
            // Оцінюємо вираз "V + СМ" та перевіряємо, чи результат є об'єктом RomanNumber.
            RomanNumber res = RomanNumber.Eval("IV + XL");
            Assert.IsInstanceOfType(RomanNumber.Eval("IV + XV"), typeof(RomanNumber));
            Assert.IsNotNull(RomanNumber.Eval("IV + XL"));

            // Перевіряємо, чи результат рівний "XLIV".
            Assert.AreEqual("XLIV", res.ToString(), "Sum(res.ToString()) == XLIV");

            // Перевіряємо, чи викидається виняток ArgumentNullException при спробі оцінити null вираз.
            var ex = Assert.ThrowsException<ArgumentNullException>(
                () => RomanNumber.Eval(null!),
                "Eval(null!) викидає виняток: ArgumentNullException");

            // Генеруємо випадкові числа та перевіряємо результати додавання.
            Random rndNum = new();
            for (int i = 0; i < 256; i++)
            {
                RomanNumber x = new(rndNum.Next(-1000, 1000));
                RomanNumber y = new(rndNum.Next(-1000, 1000));
                RomanNumber ans = RomanNumber.Eval($"{x.ToString()} + {y.ToString()}");
                Assert.AreEqual(x.Add(y), ans);
                Assert.AreEqual(RomanNumber.Sum(x, y), ans);
            } 
        }
        [TestMethod]
        public void TestEvalIllegal()
        {
            // Словник з недопустимими виразами та їхніми очікуваними результатами.
            Dictionary<String, int> illegal = new()
            {
        {"   LXX    +    IV   ", 74 },
        {"LXX+IV", 74 },
        {"LXX--IV", 74 },
        {"-XX - V", -25 },
        {"-XX + V", -15 },
        {"-XX - -V" , -15 },
        {"-XX + -V", -25 },
            };

            // Перевіряємо результати обчислення для недопустимих виразів.
            foreach (var item in illegal)
            {
                Assert.AreEqual(item.Value,
                    RomanNumber.Eval(item.Key).Value,
                    $"{item.Key} -> {item.Value}");
            }
        }
        [TestMethod]
        public void TestEvalNonValid()
        { // Перевіряємо викидання винятків для неправильних (недійсних) чисел.
            var ex = Assert.ThrowsException<ArgumentException>(
                () => RomanNumber.Eval("IIC + II"),
                "Eval(IIC + II) ThrowsException: Invalid number");
            ex = Assert.ThrowsException<ArgumentException>(
                () => RomanNumber.Eval("AX + II"),
                "Eval(AX + II) ThrowsException: Invalid number");
            ex = Assert.ThrowsException<ArgumentException>(
                () => RomanNumber.Eval("X + II + X"),
                "Eval(X + II + X) ThrowsException: Invalid number");
            ex = Assert.ThrowsException<ArgumentException>(
                () => RomanNumber.Eval("+X + X"),
                "Eval(+X + X) ThrowsException: Invalid number");
            ex = Assert.ThrowsException<ArgumentException>(
                () => RomanNumber.Eval("X + +X"),
                "Eval(X + +X) ThrowsException: Invalid number");
            ex = Assert.ThrowsException<ArgumentException>(
                () => RomanNumber.Eval("-X +- II"),
                "Eval(-X +- II) ThrowsException: Invalid number");
            ex = Assert.ThrowsException<ArgumentException>(
                () => RomanNumber.Eval("+X"),
                "Eval(+X) ThrowsException: Invalid number");
        }
        [TestMethod]
        public void TestEvalSubstraction()
        {
            // Перевіряємо віднімання випадкових чисел та правильність результатів.
            Random r = new();
            for (int i = 0; i < 256; i++)
            {
                RomanNumber x = new(r.Next(-1000, 1000));
                RomanNumber y = new(r.Next(-1000, 1000));
                RomanNumber NegativeNumerals = RomanNumber.Eval($"{x.ToString()} - {y.ToString()}");
                y.Value = -y.Value;
                Assert.AreEqual(x.Add(y), NegativeNumerals);
                Assert.AreEqual(RomanNumber.Sum(x, y), NegativeNumerals);
            }
        }
    }
}

