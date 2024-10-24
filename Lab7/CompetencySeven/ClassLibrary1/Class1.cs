namespace ClassLibrary1
{
    public class Book
    {
        public string author = "";
        //private string isbn = "";
        public double price ;
        public string title = "";
        public Book()
    {
    }
    public Book(string title, string author){
        this.author = author;
        this.title = title;
    }
    public string getTitle()
    {
        return this.title;
    }
    public void setTitle(string title)
    {
        this.title = title;
    }

    }
}
