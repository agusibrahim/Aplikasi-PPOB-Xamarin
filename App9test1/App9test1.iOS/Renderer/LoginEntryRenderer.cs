using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using App9test1.Controls;
using App9test1.iOS.Renderer;
using CoreAnimation;
using CoreGraphics;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(LoginEntryRenderer), typeof(EntryLogin))]
namespace App9test1.iOS.Renderer {
    public class LoginEntryRenderer:EntryRenderer {
        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);
            var border = new CALayer();
            nfloat width = 2;
            border.BorderColor = UIColor.Black.CGColor;
            border.Frame = new CoreGraphics.CGRect(0, Control.Frame.Size.Height - width, Control.Frame.Size.Width, Control.Frame.Size.Height);
            border.BorderWidth = width;
            Control.Layer.AddSublayer(border);
            Control.Layer.MasksToBounds = true;

        }
        
    }
}
