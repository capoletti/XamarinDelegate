// WARNING
//
// This file has been generated automatically by Xamarin Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace XamarinDelegate.iOS
{
    [Register ("ViewControllerAzul")]
    partial class ViewControllerAzul
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton btVoltar { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UISegmentedControl seletor { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITableView table { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextView twLista { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (btVoltar != null) {
                btVoltar.Dispose ();
                btVoltar = null;
            }

            if (seletor != null) {
                seletor.Dispose ();
                seletor = null;
            }

            if (table != null) {
                table.Dispose ();
                table = null;
            }

            if (twLista != null) {
                twLista.Dispose ();
                twLista = null;
            }
        }
    }
}