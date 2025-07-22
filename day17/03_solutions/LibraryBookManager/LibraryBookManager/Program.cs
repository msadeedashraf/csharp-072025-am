namespace LibraryBookManager
{
    internal class Program
    {

        static void Main(string[] arg)
        {
            LibraryBook book1 = new LibraryBook("Clean Code" , "Robert C. Martin");
            book1.GetStatus();
            book1.BorrowBook();
            book1.GetStatus();
            book1.ReturnBook();
            book1.GetStatus();
            

            LibraryBook book2 = new LibraryBook("Atomic Habits", "James Clear");
            book2.BorrowBook();
            book2.GetStatus();

        }

    }


}