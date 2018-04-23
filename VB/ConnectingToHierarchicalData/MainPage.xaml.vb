Imports Microsoft.VisualBasic
Imports System.Windows.Controls

Namespace ConnectingToHierarchicalData
	Partial Public Class MainPage
		Inherits UserControl
		Public Sub New()
			InitializeComponent()
			grid.ItemsSource = Stuff.GetStuff()
			treeListView1.ExpandAllNodes()
		End Sub
	End Class
End Namespace
