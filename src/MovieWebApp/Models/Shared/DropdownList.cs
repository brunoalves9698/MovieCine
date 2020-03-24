namespace MovieWebApp.Models.Shared
{
    public class DropdownList
    {
        public DropdownList() { }

        public DropdownList(string value, string name)
        {
            Value = value;
            Name = name;
        }

        public string Value { get; set; }
        public string Name { get; set; }
    }
}
