using System;

class LibraryBook
{
    // Закрытые поля
    private string title;
    private string author;
    private bool isCheckedOut;

    // Конструктор класса
    public LibraryBook(string title, string author)
    {
        this.title = title;
        this.author = author;
        this.isCheckedOut = false; // По умолчанию книга доступна
    }

    // Публичные свойства для доступа к полям title и author
    public string Title
    {
        get { return title; }
    }

    public string Author
    {
        get { return author; }
    }

    // Метод для взятия книги
    public void CheckOutBook()
    {
        if (isCheckedOut)
        {
            Console.WriteLine($"Книга \"{title}\" уже взята.");
        }
        else
        {
            isCheckedOut = true;
            Console.WriteLine($"Вы взяли книгу \"{title}\".");
        }
    }

    // Метод для возврата книги
    public void ReturnBook()
    {
        if (!isCheckedOut)
        {
            Console.WriteLine($"Книга \"{title}\" уже возвращена.");
        }
        else
        {
            isCheckedOut = false;
            Console.WriteLine($"Вы вернули книгу \"{title}\".");
        }
    }

    // Метод для получения статуса книги
    public string GetStatus()
    {
        return isCheckedOut ? "взята" : "доступна";
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Создание экземпляров LibraryBook
        LibraryBook book1 = new LibraryBook("1984", "Джордж Оруэлл");
        LibraryBook book2 = new LibraryBook("Война и мир", "Лев Толстой");

        // Проверка статуса и взятие книги
        Console.WriteLine($"Книга: {book1.Title}, Автор: {book1.Author}, Статус: {book1.GetStatus()}");
        book1.CheckOutBook();
        Console.WriteLine($"Книга: {book1.Title}, Автор: {book1.Author}, Статус: {book1.GetStatus()}");

        // Попытка повторного взятия книги
        book1.CheckOutBook();

        // Возврат книги
        book1.ReturnBook();
        Console.WriteLine($"Книга: {book1.Title}, Автор: {book1.Author}, Статус: {book1.GetStatus()}");

        // Попытка возврата уже возвращенной книги
        book1.ReturnBook();

        // Проверка статуса второй книги
        Console.WriteLine($"Книга: {book2.Title}, Автор: {book2.Author}, Статус: {book2.GetStatus()}");
        book2.CheckOutBook();
        Console.WriteLine($"Книга: {book2.Title}, Автор: {book2.Author}, Статус: {book2.GetStatus()}");
    }
}