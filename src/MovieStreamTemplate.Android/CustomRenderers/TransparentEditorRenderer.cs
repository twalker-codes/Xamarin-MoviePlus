using System;
using Android.Content;
using MovieStreamTemplate.CustomControls;
using MovieStreamTemplate.Droid.CustomRenderers;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(TransparentEditor), typeof(TransparentEditorRenderer))]
namespace MovieStreamTemplate.Droid.CustomRenderers
{
	public class TransparentEditorRenderer: EditorRenderer
	{
		public TransparentEditorRenderer(Context context): base(context)
		{
		}

        protected override void OnElementChanged(ElementChangedEventArgs<Editor> e)
        {
            base.OnElementChanged(e);

            if (Control != null)
            {
                Control.SetBackgroundColor(global::Android.Graphics.Color.Transparent);
            }
        }
    }
}

