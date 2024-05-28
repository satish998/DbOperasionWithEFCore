namespace DbOperationsWithEFCoreApp.Data
{
    public class Language
    {
        public int ID { get; set; }
        public String Title { get; set; }
        public String Description { get; set; }

        public ICollection<Book> Books { get; set; }
    }
}
