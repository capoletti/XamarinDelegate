using System;
using Foundation;
using UIKit;

namespace XamarinDelegate.iOS
{

	public class TableSource : UITableViewSource
	{

		string[] TableItems;
		string CellIdentifier = "TableCell";

		public TableSource(string[] items)
		{
			TableItems = items;
		}

		public override nint RowsInSection(UITableView tableview, nint section)
		{
			return TableItems.Length;
		}

		public override UITableViewCell GetCell(UITableView tableView, NSIndexPath indexPath)
		{
			UITableViewCell cell = tableView.DequeueReusableCell(CellIdentifier);
			string item = TableItems[indexPath.Row];

			if (cell == null)
			{ cell = new UITableViewCell(UITableViewCellStyle.Default, CellIdentifier); }

			cell.TextLabel.Text = item;

			return cell;
		}
	}
}
