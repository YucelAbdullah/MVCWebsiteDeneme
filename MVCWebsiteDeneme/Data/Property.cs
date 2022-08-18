namespace MVCWebsiteDeneme.Data
{
    public enum PropertyTypes :int
    {
        Forsale, ForRent, TimeShare
    }

    public class Property
    {

        //scalar property
        public Guid Id { get; set; }
        public DateTime Date { get; set; }

        public Guid CategoryId { get; set; }

        public string Headline { get; set; }

        public decimal Price { get; set; }

        public string Description { get; set; }

        public byte[]? Image { get; set; }

        public PropertyTypes Type { get; set; }


        //navigation property
        public Category? Category { get; set; }


    }
}
