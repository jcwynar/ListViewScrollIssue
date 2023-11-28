using ListViewScrollIssue.Models;
using ListViewScrollIssue.Views;

namespace ListViewScrollIssue.ViewModels;

public class MainViewModel
{
    public List<ComponentListItemCollection> TestModel { get; }

    public MainViewModel()
    {
        TestModel = new List<ComponentListItemCollection>()
        {
            new ComponentListItemCollection
            (
                "Group 1",
                new List<ComponentListItem>()
                {
                    new ComponentListItem("Page 1", nameof(Page1)),
                    new ComponentListItem("Page 2", nameof(Page2))
                }
            )
        };
    }
}
