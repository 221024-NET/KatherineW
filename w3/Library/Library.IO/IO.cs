namespace Library.InOut
{
    public class IO
    {
        // Fields

        // Constructor
        public IO() { }

        // Methods
        public void DisplayAvailableBooks(IEnumerable<string> titles)
        {
            Console.WriteLine("The Library has the following Titles available for loan:");
            foreach (string title in titles)
                Console.WriteLine(title);
        }
    }
}