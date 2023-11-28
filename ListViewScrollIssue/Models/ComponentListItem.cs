namespace ListViewScrollIssue.Models;

public class ComponentListItem
{
    public string Name { get; set; }
    public string Page { get; set; }

    public ComponentListItem(string name, string page)
    {
        Name = name;
        Page = page;
    }
}
