using System;
using UIKit;

namespace XamarinDelegate.iOS
{
	public class UITextFieldCodeDelegate: UITextFieldDelegate
	{
		public override bool ShouldChangeCharacters(UITextField textField, Foundation.NSRange range, string replacementString)
		{
			return Validations.ValidateCode(replacementString);
		}
	}
}
