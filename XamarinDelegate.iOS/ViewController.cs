using System;
using Foundation;
using UIKit;

namespace XamarinDelegate.iOS
{
	public partial class ViewController : UIViewController
	{
		protected ViewController(IntPtr handle) : base(handle)
		{
			// Note: this .ctor should not contain any initialization logic.
		}

		public override void ViewDidLoad()
		{
			base.ViewDidLoad();
			// Perform any additional setup after loading the view, typically from a nib.

			txCode.Delegate = new UITextFieldCodeDelegate();
			txUser.WeakDelegate = this;

			btListar.Enabled = false;

			btValidar.TouchUpInside += delegate {

				if (txUser.Text.Equals("abc") && txCode.Text.Equals("123"))
				{
					btListar.Enabled = true;
				}
				else {
					btListar.Enabled = false;
					UIAlertView alert = new UIAlertView()
					{
						Title = "Aviso",
						Message = "Informe os textos 'abc' e '123'!"
					};
					alert.AddButton("OK");
					alert.Show();
				}
			};

		}

		public override void DidReceiveMemoryWarning()
		{
			base.DidReceiveMemoryWarning();
			// Release any cached data, images, etc that aren't in use.
		}

		[Export("textField:shouldChangeCharactersInRange:replacementString:")]
		public bool ShouldChangeCharacters(UITextField textField, Foundation.NSRange range, string replacementString)
		{
			return Validations.ValidateText(replacementString);
		}
	}
}
