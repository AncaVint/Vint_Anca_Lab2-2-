namespace Vint_Anca_Lab2_2_.Models
{
    public class Author
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public ICollection<Author>? Authors { get; set; }
    }
}
