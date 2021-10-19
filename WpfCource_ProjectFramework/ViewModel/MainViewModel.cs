
using GalaSoft.MvvmLight.CommandWpf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Input;
using WpfCource_ProjectFramework.View;

namespace WpfCource_ProjectFramework.ViewModel
{
    class MainViewModel : ViewModelBase
    {
        private Page MainPage = new MainPage();
        private Page SearchPage = new SearchPage();
        private Page MyBooksPage = new MyBooksPage();
        private Page BasketPage = new BasketPage();
        private Page _CurPage = new MainPage();
        public Page CurPage
        {
            get => _CurPage;
            set => Set(ref _CurPage, value);
        }

        public ICommand OpenMainPage
        {
            get
            {
                return new RelayCommand(() => CurPage = MainPage);
            }
        }
        public ICommand OpenSearchPage
        {
            get
            {
                return new RelayCommand(() => CurPage = SearchPage);
            }
        }
        public ICommand OpenMyBooksPage
        {
            get
            {
                return new RelayCommand(() => CurPage = MyBooksPage);
            }
        }
        public ICommand OpenBasketPage
        {
            get
            {
                return new RelayCommand(() => CurPage = BasketPage);
            }
        }
    }
}
