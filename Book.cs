class Book
{
    private int pages;                       // hidden field

    public string Title { get; set; }
    public string Author { get; set; }

    public int Pages                         // property with validation
    {
        get { return pages; }
        set
        {
            if (value <= 0)
                Console.WriteLine($"Invalid page count: {value}");
            else
                pages = value;
        }
    }

    public Book(string title, string author, int pages)
    {
        Title = title;
        Author = author;
        Pages = pages;                       // goes through the set accessor
    }

    public string Info()
    {
        return $"{Title} by {Author}, {Pages} pages";
    }
}