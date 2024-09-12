namespace ST10043352_PROG7312_PART_1
{
    public class Issue
    {
        public string Location { get; set; }
        public string Category { get; set; }
        public string Description { get; set; }
        public string MediaFilePath { get; set; }

        public Issue(string location, string category, string description, string mediaFilePath)
        {
            Location = location;
            Category = category;
            Description = description;
            MediaFilePath = mediaFilePath;
        }

        public override string ToString()
        {
            return $"Location: {Location}, Category: {Category}, Description: {Description}, Media: {MediaFilePath}";
        }
    }

}
