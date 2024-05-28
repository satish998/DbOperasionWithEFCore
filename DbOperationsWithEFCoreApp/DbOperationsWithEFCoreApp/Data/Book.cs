namespace DbOperationsWithEFCoreApp.Data
{
    public class Book
    {
        public int ID { get; set; }
        public String Title { get; set; }
        public String Description { get; set; }
        public int NoOfPages { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreatedOn { get; set; }

        public int LanguageId { get; set; }

        public Language Language { get; set; }

        public ICollection<Book> Books { get; set; }
    }


}
