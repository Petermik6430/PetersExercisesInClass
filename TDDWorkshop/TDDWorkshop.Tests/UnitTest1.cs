using TTDWorkshop.ClassLibrary;

namespace TDDWorkshop.Tests;

public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void PropertiesContainsValues_When_SetInConstructor()
    {

        //arrange
        string title = "Hitchhiker's Guide to the Galaxy";
        string description = "An awesome book about the math 6*9";
        string ISBN = "08709870987";
        Book book = new Book(ISBN, title, description);

        //act



        //assert
        Assert.That(title, Is.EqualTo(book.Title));
        Assert.That(title, Is.EqualTo(book.Title));
        Assert.That(description, Is.EqualTo(book.Description), "Description not as expected");
        Assert.That(ISBN, Is.EqualTo(book.ISBN), "ISBN not as expected");

    }

    [Test]
    public void CanFindBooksInContainer_When_AddedToContainer()
    {
        //arrange
        var book1Isbn = "978698";
        Book book1 = new(book1Isbn, "The restaurant at the end of the universe", "Description");
        Book book2 = new("978699", "So long and thanks for all the fish", "Description");
        Book book3 = new("978600", "The long dark teatime of the soul", "Description");
        BookCollection collection = new();

        //act
        collection.Add(book1);
        collection.Add(book2);
        collection.Add(book3);


        //assert
        Book refoundBook1 = collection.FindByIsbn(book1Isbn);
        Assert.That(refoundBook1, Is.EqualTo(book1));
    }

    [Test]
    public void CantInsertBook_When_NegativPriceOrStock()
    {
        //arrange
        Book book4 = new("978601", "The long dark teatime of the soul", "Description", 10, 10);
        Book book5 = new("978602", "The long dark teatime of the soul", "Description", -10, 1);
        Book book6 = new("978603", "The long dark teatime of the soul", "Description", -10, -1);
        Book book7 = new("978604", "The long dark teatime of the soul", "Description", 10, -1);

        //act


        //assert
        Assert.That(book4.Price, Is.EqualTo(book4.Price));
        Assert.That(book4.Stock, Is.EqualTo(book4.Stock));
        Assert.That(book5.Price, Is.EqualTo(book5.Price));
        Assert.That(book5.Stock, Is.EqualTo(book5.Stock));
        Assert.That(book6.Price, Is.EqualTo(book6.Price));
        Assert.That(book6.Stock, Is.EqualTo(book6.Stock));
        Assert.That(book7.Price, Is.EqualTo(book7.Price));
        Assert.That(book7.Stock, Is.EqualTo(book7.Stock));

        Console.WriteLine(book4);
        Console.WriteLine(book5);
        Console.WriteLine(book6);
        Console.WriteLine(book7);
    }


}