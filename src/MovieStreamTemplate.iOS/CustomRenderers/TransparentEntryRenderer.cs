using System;
using MovieStreamTemplate.CustomControls;
using MovieStreamTemplate.iOS.CustomRenderers;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(TransparentEntry), typeof(TransparentEntryRenderer))]
namespace MovieStreamTemplate.iOS.CustomRenderers
{
    public class TransparentEntryRenderer: EntryRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);

            if (Control != null)
            {
                // do whatever you want to the UITextField here!
                Control.BorderStyle = UITextBorderStyle.None;
            }
        }
    }
}

