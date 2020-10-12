using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Mock1Assignment1;

namespace TestMock1Assignment1
{
    [TestClass]
    public class TestBookClass
    {
        [TestMethod]
        [DataRow("To Kill a Mockingbird")]
        [DataRow("Runaway Jury")]
        [DataRow("The Firm")]
        [DataRow("BK")]
        public void TestTitleLength(string title)
        {
            //Arrange
            Book b = new Book();
            string expected = title;

            //Act
            b.Title = title;
            string actual = b.Title;

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [DataRow("")]
        [DataRow("B")]
        [ExpectedException(typeof(ArgumentException))]
        public void TestTitleLengthException(string title)
        {
            //Arrange
            Book b = new Book();

            //Act
            b.Title = title;

            //Assert
            Assert.Fail();
        }

        [TestMethod]
        [DataRow("")]
        [DataRow("Some authour")]
        [DataRow("John Grisham")]
        [DataRow("dhjsk")]
        [DataRow("S")]
        public void TestAuthour(string authour)
        {
            //Arrange
            Book b = new Book();
            string expected = authour;

            //Act
            b.Authour = authour;
            string actual = b.Authour;

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [DataRow(10)]
        [DataRow(11)]
        [DataRow(999)]
        [DataRow(1000)]
        [DataRow(323)]
        public void TestPageNumber(int number)
        {
            //Arrange
            Book b = new Book();
            int expected = number;

            //Act
            b.PageNumber = number;
            int actual = b.PageNumber;

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [DataRow(9)]
        [DataRow(-1)]
        [DataRow(1001)]
        [ExpectedException(typeof(ArgumentException))]
        public void TestPageNumberException(int number)
        {
            //Arrange
            Book b = new Book();
            int expected = number;

            //Act
            b.PageNumber = number;
            int actual = b.PageNumber;

            //Assert
            Assert.Fail();
        }

        [TestMethod]
        [DataRow("1234567890abc")]
        [DataRow("abcdefghijklm")]
        [DataRow("nopqrstuvwxyz")]
        [DataRow("!#¤%&/()=?`~'")]
        [DataRow("ABCDEFGHIJKLM")]
        [DataRow("NOPQRSTUVWXYZ")]
        public void TestISBN13(string isbn)
        {
            //Arrange
            Book b = new Book();
            string expected = isbn;

            //Act
            b.ISBN13 = isbn;
            string actual = b.ISBN13;

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [DataRow("1234567890ab")]
        [DataRow("asbd")]
        [DataRow("D")]
        [DataRow("sdjhgjkhgblkrjksnbd")]
        [DataRow("23787dung9823jh3nd")]
        [DataRow("4987921398021380975")]
        [ExpectedException(typeof(ArgumentException))]
        public void TestISBN13Exception(string isbn)
        {
            //Arrange
            Book b = new Book();
            string expected = isbn;

            //Act
            b.ISBN13 = isbn;
            string actual = b.ISBN13;

            //Assert
            Assert.Fail();
        }

        //This test is to test if the values assigned via the constructor are the same as those given, similar to above
        //That is why there is 4 assert statements, so as to not have 4 more tests testing the constructor
        //This improves readability in my opinion, and makes the total length of the file smaller.
        [DataRow("Book 1", "Authour 1", 362, "123456789abcd")]
        [DataRow("Book 2", "Authour 2", 362, "123456789abcd")]
        [DataRow("Book 3", "Authour 3", 362, "123456789abcd")]
        [DataRow("Bd", "s", 362, "dnsoieldpsåds")]
        [TestMethod]
        public void TestBookConstructor(string title, string authour, int pageNumber, string isbn)
        {
            //Arrange
            Book b = new Book(title, authour, pageNumber, isbn);
            string expectedTitle = title;
            string expectedAuthour = authour;
            int expectedPageNumber = pageNumber;
            string expectedISBN = isbn;

            //Act
            string actualTitle = b.Title;
            string actualAuthour = b.Authour;
            int actualPageNumber = b.PageNumber;
            string actualISBN = b.ISBN13;

            //Assert
            Assert.AreEqual(expectedTitle, actualTitle);
            Assert.AreEqual(expectedAuthour, actualAuthour);
            Assert.AreEqual(expectedPageNumber, actualPageNumber);
            Assert.AreEqual(expectedISBN, actualISBN);
        }

        [TestMethod]
        [DataRow("B", "A", 392, "abcdefghijklm")]
        [DataRow("Bok", "A", 1001, "abcdefghijklm")]
        [DataRow("Book", "A", 9, "abcdefghijklm")]
        [DataRow("Bdha", "A", 392, "abcdefghi")]
        [DataRow("Basdh", "A", 392, "abcdefghijklmnopqer")]
        [DataRow("B", "A", 10003002, "abcdefghijklmasdkhjgajwfvd")]
        [DataRow("", "A", 2, "abcdefg")]
        [ExpectedException(typeof(ArgumentException))]
        public void TestBookConstructorException(string title, string authour, int pageNumber, string isbn)
        {
            //Arrange
            Book b = new Book(title, authour, pageNumber, isbn);

            //Act

            //Assert
            Assert.Fail();
        }
    }
}
