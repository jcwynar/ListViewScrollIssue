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
            ),
            new ComponentListItemCollection
            (
                "Group 2",
                new List<ComponentListItem>()
                {
                    new ComponentListItem("Page 3", nameof(Page3)),
                    new ComponentListItem("Page 4", nameof(Page4))
                }
            )
        };
    }
}
