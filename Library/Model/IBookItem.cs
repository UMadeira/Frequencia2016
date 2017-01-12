namespace Library.Model
{
    public interface IBookItem
    {
        string Barcode { get; set; }

        IBook Book { get; set; }
    }
}
