using Android.Content;
using Microsoft.Maui.Controls;
using Microsoft.Maui.Controls.Platform.Android;
using Microsoft.Maui.Controls.Compatibility;
using Microsoft.Maui.Controls.Platform;
using Android.Content.Res;
using Microsoft.Maui.Controls.Compatibility.Platform.Android;
using MauiApp1.Platforms.Android.CustomRenderers;

[assembly: ExportRenderer(typeof(Entry), typeof(CustomEntryRenderer))]
namespace MauiApp1.Platforms.Android.CustomRenderers
{
    public class CustomEntryRenderer : EntryRenderer
    {
        public CustomEntryRenderer(Context context) : base(context)
        {
        }

        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);

            if (Control != null)
            {
                Control.Background = Resources.GetDrawable(Resource.Drawable.EntryBottomLineDrawable);
            }
        }
    }
}
