using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace HangMan
{
    [TestFixture]
    class TestHang
    {
        Form1 test = new Form1();
        
        [Test]
        public void testGetPicMode()
        {
            int testGetP = test.getPicMode();
            Assert.AreEqual(0, testGetP);
        }
        //-----------------------------------------------------------------------------------//

        //-----------------------//
        //  test random number   //
        //-----------------------//
        [Test]
        public void testRandNumber1()
        {
            int ran = test.RandNumber(0, 3);
            Assert.AreEqual(0, ran);
        }
        [Test]
        public void testRandNumber2()
        {
            int ran = test.RandNumber(0, 3);
            Assert.AreEqual(1, ran);
        }
        [Test]
        public void testRandNumber3()
        {
            int ran = test.RandNumber(0, 3);
            Assert.AreEqual(2, ran);
        }

        //-----------------------------------------------------------------------------------//



        [Test]
        public void testCountData()
        {
            int count1 = test.CountData("Sports.txt");
            Assert.AreEqual(35, count1);
            int count2 = test.CountData("animals.txt");
            Assert.AreEqual(157, count2);
            int count3 = test.CountData("countries.txt");
            Assert.AreEqual(178, count3);
            int count4 = test.CountData("test.txt");
            Assert.AreEqual(8, count4);
        }

        //-----------------------------------------------------------------------------------//

        [Test]
        public void testDataWord()
        {
            string world = test.DataWord("test.txt", 7);
            Assert.AreEqual("testLongWord4", world);
        }

        //-----------------------------------------------------------------------------------//

        [Test]
        public void testVocabWord()
        {
            string underline;
            underline = test.VocabWord("cat");
            Assert.AreEqual("_ _ _ ", underline);
            underline = test.VocabWord("dog");
            Assert.AreEqual("_ _ _ ", underline);
            underline = test.VocabWord("");
            Assert.AreEqual("", underline);
            underline = test.VocabWord(" ");
            Assert.AreEqual("  ", underline);
        }

        //-----------------------------------------------------------------------------------//

        //------------------------------//
        //  test random underline word  //
        //------------------------------//
        [Test]
        public void testWord1()
        {
            // Easy //
            string word = test.Word("test","Easy");
            Assert.AreEqual("_ _ _ _ _ ", word);
        }
        [Test]
        public void testWord2()
        {
            // Normal //
            string word = test.Word("test", "Normal");
            Assert.AreEqual("_ _ _ _ _ _ _ _ _ _ _ _ _ ", word);
        }
        [Test]
        public void testWord3()
        {
            // Normal //
            string word = test.Word("test", "Normal");
            Assert.AreEqual("_ _ _ _ _ ", word);
        }
        [Test]
        public void testWord4()
        {
            // Hard //
            string word = test.Word("test", "Hard");
            Assert.AreEqual("_ _ _ _ _ _ _ _ _ _ _ _ _ ", word);
        }
        //-----------------------------------------------------------------------------------//

        [Test]
        public void testGetMode()
        {
            string testGetM = test.getMode();
            Assert.AreEqual("",testGetM);
        }

        //-----------------------------------------------------------------------------------//
        [Test]

        public void testFilePic()
        {
            string num = test.FilePic(1);
            Assert.AreEqual("teddybear", num);
            string num2 = test.FilePic(2);
            Assert.AreEqual("kitakita", num2);
            string num3 = test.FilePic(3);
            Assert.AreEqual("kitakita", num3);
        }

        //-----------------------------------------------------------------------------------//

        [Test]
        public void testCheck()
        {
            bool a = test.check();
            Assert.True(a);
            bool b = test.check();
            Assert.False(!b);
        }

        //-----------------------------------------------------------------------------------//

        [Test]
        public void testShowAnswer()
        {
            string word = test.ShowAnswer();
            Assert.AreEqual("",word);
        }
    }

}
