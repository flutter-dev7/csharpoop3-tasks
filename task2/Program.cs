using task2;

PhotoBook photoBook = new PhotoBook();
System.Console.WriteLine(photoBook.GetNumberPages());
PhotoBook photoBook2 = new PhotoBook(24);
System.Console.WriteLine(photoBook2.GetNumberPages());
BigPhotoBook bigPhotoBook = new BigPhotoBook();
System.Console.WriteLine(bigPhotoBook.GetNumberPages());