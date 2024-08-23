using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using MovieStreamTemplate.Resources;
using Xamarin.Forms;

namespace MovieStreamTemplate.ViewModels
{
    public class HelpViewModel: BaseViewModel
    {
        public ObservableCollection<HelpItemViewModel> HelpItems { get; }

        public Command SearchCommand { get; }
        public Command ClearCommand { get; }

        private string keyword;
        public string Keyword
        {
            get => keyword;
            set
            {
                SetProperty(ref keyword, value);
            }
        }

        List<HelpItemViewModel> helpItems;

        public HelpViewModel()
        {
            Keyword = string.Empty;

            SearchCommand = new Command(OnSearchTapped);
            ClearCommand = new Command(OnClearTapped);

            helpItems = new List<HelpItemViewModel>
            {
                new HelpItemViewModel(AppResources.Question1, AppResources.Answer1),
                new HelpItemViewModel(AppResources.Question2, AppResources.Answer2),
                new HelpItemViewModel(AppResources.Question3, AppResources.Answer3),
                new HelpItemViewModel(AppResources.Question4, AppResources.Answer4),
                new HelpItemViewModel(AppResources.Question5, AppResources.Answer5),
                new HelpItemViewModel(AppResources.Question6, AppResources.Answer6),
                new HelpItemViewModel(AppResources.Question7, AppResources.Answer7),
                new HelpItemViewModel(AppResources.Question8, AppResources.Answer8),
                new HelpItemViewModel(AppResources.Question9, AppResources.Answer9),
                new HelpItemViewModel(AppResources.Question10, AppResources.Answer10),
            };

            HelpItems = new ObservableCollection<HelpItemViewModel>(helpItems);
        }

        void OnSearchTapped()
        {
            HelpItems.Clear();

            foreach (var item in helpItems.Where(i => i.Question.ToLower().Contains(keyword.ToLower())))
                HelpItems.Add(item);
        }

        void OnClearTapped()
        {
            Keyword = string.Empty;

            HelpItems.Clear();

            foreach (var item in helpItems)
                HelpItems.Add(item);
        }
    }

}

