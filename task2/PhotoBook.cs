using System;

namespace task2;

public class PhotoBook
{
    private int _numPages;
    public PhotoBook()
    {
        _numPages = 16;
    }
    public PhotoBook(int numPages)
    {
        _numPages = numPages;
    }
    public int GetNumberPages()
    {
        return _numPages;
    }
}
