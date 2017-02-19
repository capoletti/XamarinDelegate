// WARNING
//
// This file has been generated automatically by Xamarin Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;

namespace XamarinDelegate.iOS
{
    [Register ("ViewController")]
    partial class ViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton btListar { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton btValidar { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField txCode { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField txUser { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (btListar != null) {
                btListar.Dispose ();
                btListar = null;
            }

            if (btValidar != null) {
                btValidar.Dispose ();
                btValidar = null;
            }

            if (txCode != null) {
                txCode.Dispose ();
                txCode = null;
            }

            if (txUser != null) {
                txUser.Dispose ();
                txUser = null;
            }
        }
    }
}