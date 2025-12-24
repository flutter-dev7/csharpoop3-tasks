using System;

namespace task2;

public class PhotoBookTest
{
    public void PhotoBookMain()
    {
        PhotoBook book1 = new PhotoBook();
        Console.WriteLine(book1.GetNumberPages());

        PhotoBook book2 = new PhotoBook(24);
        Console.WriteLine(book2.GetNumberPages());

        BigPhotoBook bigBook = new BigPhotoBook();
        Console.WriteLine(bigBook.GetNumberPages());
    }
}
