namespace ListViewScrollIssue.Models;

public class ComponentListItemCollection : List<ComponentListItem>
{
    public string SectionHeader { get; set; }

    public ComponentListItemCollection(string sectionHeader, IEnumerable<ComponentListItem> items) : base(items)
    {
        SectionHeader = sectionHeader;
    }
}
