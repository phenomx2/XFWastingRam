using Xamarin.Forms;

namespace XFWastingRam.Util
{
    public static class PageExtensions
    {
        public static Page WithoutNavBar(this Page view)
        {
            NavigationPage.SetHasNavigationBar(view, false);
            return view;
        }

        public static Page SetIconPage(this Page view)
        {
            NavigationPage.SetTitleIcon(view, "logo.png");
            return view;
        }
    }
}