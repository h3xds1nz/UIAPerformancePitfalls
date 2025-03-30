using System.Windows.Automation.Peers;
using System.Windows.Controls;

namespace UIAPerformancePitfalls;

public class GridView : System.Windows.Controls.GridView
{
    protected override IViewAutomationPeer? GetAutomationPeer(ListView parent)
    {
        return null;
    }
}
