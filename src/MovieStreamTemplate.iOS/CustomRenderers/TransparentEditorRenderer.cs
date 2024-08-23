using System;
using MovieStreamTemplate.CustomControls;
using MovieStreamTemplate.iOS.CustomRenderers;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(TransparentEditor), typeof(TransparentEditorRenderer))]
namespace MovieStreamTemplate.iOS.CustomRenderers
{
	public class TransparentEditorRenderer: EditorRenderer
	{
        protected override void OnElementChanged(ElementChangedEventArgs<Editor> e)
        {
            base.OnElementChanged(e);

            if (Control != null)
            {
                // do whatever you want to the UITextField here!
                //Control.BorderStyle = UITextBorderStyle.None;
            }
        }
    }
}

