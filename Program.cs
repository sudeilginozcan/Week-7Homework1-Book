Console.OutputEncoding = System.Text.Encoding.UTF8;

Book[] books =
{
    new Book("Suç ve Ceza", "Dostoyevski", 687),
    new Book("Kürk Mantolu Madonna", "Sabahattin Ali", 160),
    new Book("İnce Memed", "Yaşar Kemal", 436)
};

Console.WriteLine("All books:");
foreach (Book b in books)
{
    Console.WriteLine("- " + b.Info());
}

// Find the book with the most pages
Book longest = books[0];
foreach (Book b in books)
{
    if (b.Pages > longest.Pages)
        longest = b;
}

Console.WriteLine();
Console.WriteLine("Book with the most pages:");
Console.WriteLine(longest.Info());

// Validation test: Pages must be > 0
Console.WriteLine();
Console.WriteLine("Validation test:");
longest.Pages = -5;                          // rejected by the set accessor
Console.WriteLine(longest.Info());           // value is unchanged