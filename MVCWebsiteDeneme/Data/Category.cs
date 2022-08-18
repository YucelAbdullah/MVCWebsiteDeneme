namespace MVCWebsiteDeneme.Data
{
    public class Category
    {
        public Guid Id { get; set; }
        public string Name { get; set; }

        public ICollection<Property> Properties { get; set; } = new HashSet<Property>();    


    }
}
