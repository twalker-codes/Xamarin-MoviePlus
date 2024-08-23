using System;
using Android.Content;
using MovieStreamTemplate.CustomControls;
using MovieStreamTemplate.Droid.CustomRenderers;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(TransparentEntry), typeof(TransparentEntryRenderer))]
namespace MovieStreamTemplate.Droid.CustomRenderers
{
    public class TransparentEntryRenderer: EntryRenderer
    {
        public TransparentEntryRenderer(Context context) : base(context)
        {
        }

        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);

            if (Control != null)
            {
                Control.SetBackgroundColor(global::Android.Graphics.Color.Transparent);
            }
        }
    }
}

