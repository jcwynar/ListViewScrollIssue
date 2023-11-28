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
                    new ComponentListItem("Page 2", nameof(Page2)),
                    new ComponentListItem("Page 3", nameof(Page3)),
                    new ComponentListItem("Page 4", nameof(Page4)),
                    new ComponentListItem("Page 5", nameof(Page5)),
                    new ComponentListItem("Page 6", nameof(Page6)),
                    new ComponentListItem("Page 7", nameof(Page7)),
                    new ComponentListItem("Page 8", nameof(Page8)),
                    new ComponentListItem("Page 9", nameof(Page9)),
                    new ComponentListItem("Page 10", nameof(Page10)),
                    new ComponentListItem("Page 11", nameof(Page11)),
                    new ComponentListItem("Page 12", nameof(Page12)),
                    new ComponentListItem("Page 13", nameof(Page13)),
                    new ComponentListItem("Page 14", nameof(Page14)),
                    new ComponentListItem("Page 15", nameof(Page15))
                }
            ),
            new ComponentListItemCollection
            (
                "Group 2",
                new List<ComponentListItem>()
                {
                    new ComponentListItem("Page 16", nameof(Page16)),
                    new ComponentListItem("Page 17", nameof(Page17)),
                    new ComponentListItem("Page 18", nameof(Page18)),
                    new ComponentListItem("Page 19", nameof(Page19)),
                    new ComponentListItem("Page 20", nameof(Page20)),
                    new ComponentListItem("Page 21", nameof(Page21)),
                    new ComponentListItem("Page 22", nameof(Page22)),
                    new ComponentListItem("Page 23", nameof(Page23)),
                    new ComponentListItem("Page 24", nameof(Page24)),
                    new ComponentListItem("Page 25", nameof(Page25)),
                    new ComponentListItem("Page 26", nameof(Page26)),
                    new ComponentListItem("Page 27", nameof(Page27)),
                    new ComponentListItem("Page 28", nameof(Page28)),
                    new ComponentListItem("Page 29", nameof(Page29)),
                    new ComponentListItem("Page 30", nameof(Page30))
                }
            )
        };
    }
}
