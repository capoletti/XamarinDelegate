using System;
using System.Linq;

namespace XamarinDelegate.iOS
{
	public class Validations
	{
		public static bool ValidateCode(string text)
		{
			return text.ToLower().All(c => "0123456789".Contains(c));
		}

		public static bool ValidateText(string text)
		{
			return text.ToLower().All(c => "abcdefghijklmnopqrstuvxzyw".Contains(c));
		}
	}
}
