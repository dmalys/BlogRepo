namespace DomainLayer
{
    public class PostContent
    {
        public int Id { get; set; }
        public string? Content { get; set; }
        public MyAttachment? MyAttachment { get; set; }
        public string? AuthorName { get; set; }
        public IEnumerable<string>? Tags { get; set; }
        public IEnumerable<string>? Bibliography { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime? UpdateDate { get; set; }

    }
}
