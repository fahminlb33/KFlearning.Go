using KFlearning.Go.Infrastructure;
using KFlearning.Go.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace KFlearning.Go.ViewModels
{
    public class BlogViewModel : ViewModelBase
    {
        public ObservableCollection<ArticleItemModel> Articles { get; set; }

        public BlogViewModel()
        {
            Articles = new ObservableCollection<ArticleItemModel>
            {
                new ArticleItemModel{Title="AAA", Description="FFFF"},
                new ArticleItemModel{Title="AasdAA", Description="FFasdFF"},
            };
        }
    }
}
