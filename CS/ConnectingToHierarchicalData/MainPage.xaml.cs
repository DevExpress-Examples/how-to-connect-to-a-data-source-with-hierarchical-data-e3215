using System.Windows.Controls;

namespace ConnectingToHierarchicalData {
    public partial class MainPage : UserControl {
        public MainPage() {
            InitializeComponent();
            grid.ItemsSource = Stuff.GetStuff();
            treeListView1.ExpandAllNodes();
        }
    }
}
