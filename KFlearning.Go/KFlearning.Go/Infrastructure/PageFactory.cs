﻿using KFlearning.Go.Views;
using System.Collections.Generic;
using Xamarin.Forms;

namespace KFlearning.Go.Infrastructure
{
    public static class PageFactory
    {
        private static readonly Dictionary<PageId, Page> _pages = new Dictionary<PageId, Page>();

        public static Page GetBrowserPage(string url)
        {
            return new BrowserView(url);
        }

        public static Page GetPage(PageId page)
        {
            if (_pages.TryGetValue(page, out Page pageInstance))
            {
                return pageInstance;
            }

            switch (page)
            {
                case PageId.Login:
                    return new LoginView();

                case PageId.Profile:
                    _pages.Add(PageId.Profile, new ProfileView());
                    return _pages[PageId.Profile];

                case PageId.Dashboard:
                    _pages.Add(PageId.Dashboard, new DashboardView());
                    return _pages[PageId.Dashboard];

                case PageId.Tutorial:
                    _pages.Add(PageId.Tutorial, new TutorialView());
                    return _pages[PageId.Tutorial];

                case PageId.Blog:
                    _pages.Add(PageId.Blog, new BlogView());
                    return _pages[PageId.Blog];

                case PageId.About:
                    _pages.Add(PageId.About, new AboutView());
                    return _pages[PageId.About];

                default:
                    return null;
            }
        }
    }
}
