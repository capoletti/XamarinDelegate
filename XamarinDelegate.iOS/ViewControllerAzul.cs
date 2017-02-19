using Foundation;
using System;
using UIKit;

namespace XamarinDelegate.iOS
{
    public partial class ViewControllerAzul : UIViewController
    {
        public ViewControllerAzul (IntPtr handle) : base (handle)
        {
        }

		public override void ViewDidLoad()
		{
			base.ViewDidLoad();
			// Perform any additional setup after loading the view, typically from a nib

			//table = new UITableView(View.Bounds); // defaults to Plain style
			string[] tableItems = new string[] { "Item 1", "Item 2", "Item 3", "Item 4", "Item 5", "Item 6","Item 1", "Item 2", "Item 3", "Item 4", "Item 5", "Item 6"  };
			table.Source = new TableSource(tableItems);
			//Add(table);

				twLista.Text = string.Empty;

			seletor.ValueChanged += (sender, e) =>
			{
				switch (seletor.SelectedSegment)
				{
					case 0:
						twLista.Text = string.Empty;
						break;

					case 1:
						twLista.Text = "Listagem de exemplo.";
						break;
				}
			};


		}
	}
}