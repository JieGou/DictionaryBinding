﻿using Prism.Mvvm;
using PrismDictionaryBinding.Models;
using System.Collections.Generic;

namespace PrismDictionaryBinding.ViewModels
{
    internal class ContentViewModel : BindableBase
    {
        public ContentViewModel()
        {
            this.PersonDictionaries = new Dictionary<string, Person>()
            {
                {"長男", new Person(){Name="Ichiro", Sex ="男", Age=10, } },
                {"次男", new Person(){Name="Jiro", Sex ="男", Age=9, } },
                {"三男", new Person(){Name="Saburo", Sex ="男", Age=8, } },
                {"四男", new Person(){Name="Shiro", Sex ="男", Age=7, } },
                {"長女", new Person(){Name="Goro", Sex ="男", Age=8, } },
            };

            this.Items = new Dictionary<string, Dictionary<string, string>>()
            {
                {"長男", new Dictionary<string, string>() {{"名前", "一郎"}, { "性別", "男" }, { "年齢", "20"}} },
                {"次男", new Dictionary<string, string>() {{"名前", "二郎"}, { "性別", "男" }, { "年齢", "19"}} },
                {"三男", new Dictionary<string, string>() {{"名前", "三郎"}, { "性別", "男" }, { "年齢", "18"}} },
                {"四男", new Dictionary<string, string>() {{"名前", "四郎"}, { "性別", "男" }, { "年齢", "17"}} },
                {"長女", new Dictionary<string, string>() {{"名前", "花子"}, { "性別", "女" }, { "年齢", "18"}} },
            };
        }

        private Dictionary<string, Person> _personDictionaries;

        public Dictionary<string, Person> PersonDictionaries
        {
            get { return _personDictionaries; }
            set { SetProperty(ref _personDictionaries, value); }
        }

        private Dictionary<string, Dictionary<string, string>> _Items;

        public Dictionary<string, Dictionary<string, string>> Items
        {
            get { return _Items; }
            set { SetProperty(ref _Items, value); }
        }
    }
}