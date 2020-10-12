using System;

namespace CompulsoryAssignment1Assignment1
{
    public class Book
    {
        private string _title;
        private int _pageNumber;
        private string _isbn13;

        /// <summary>
        /// Default constructor, takes no arguments and creates an empty book object.
        /// </summary>
        public Book(){}

        /// <summary>
        /// Book constructor that takes all the properties as arguments, so you can set the properties when creating the object.
        /// </summary>
        /// <param name="title">The title of the book (type string), must be 2 characters minimum</param>
        /// <param name="authour">The authour of the book (type string)</param>
        /// <param name="pageNumber">The total number of pages in the book (type int), must be 10 pages or more, up to and including 1000 pages</param>
        /// <param name="isbn13">The isbn13 corresponding to the book (type string), must be 13 characters in length</param>
        public Book(string title, string authour, int pageNumber, string isbn13)
        {
            Title = title;
            Authour = authour;
            PageNumber = pageNumber;
            ISBN13 = isbn13;
        }

        /// <summary>
        /// The property for getting and setting the title of a book, type string (minimum of 2 characters)
        /// </summary>
        public string Title
        {
            get { return _title; }
            set
            {
                if (value.Length < 2)
                {
                    throw new ArgumentException("length cannot be below 2 characters");
                }

                _title = value;
            }
        }

        /// <summary>
        /// The property for getting and setting the authour of a book, type string
        /// </summary>
        public string Authour
        {
            get;
            set;
        }

        /// <summary>
        /// The property for getting and setting the total page count of a book, type int (must be a value of 10 or higher, up to and including 1000)
        /// </summary>
        public int PageNumber
        {
            get { return _pageNumber; }
            set
            {
                if (value < 10 || value > 1000)
                {
                    throw new ArgumentException("page number cannot be below 10 or above 1000");
                }

                _pageNumber = value;
            }
        }

        /// <summary>
        /// The property for getting and setting the ISBN13 of the book, type string (must be 13 characters long)
        /// </summary>
        public string ISBN13
        {
            get { return _isbn13; }
            set
            {
                if (value.Length != 13)
                    throw new ArgumentException("length has to be 13 characters");
                _isbn13 = value;
            }
        }
    }
}
