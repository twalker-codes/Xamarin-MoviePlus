using System;
using MovieStreamTemplate.MaterialDesign;
using Xamarin.Forms;

namespace MovieStreamTemplate.ViewModels
{
    public class HelpItemViewModel : BaseViewModel
    {
        public string Question { get; }
        public string Answer { get; }

        private bool isExpanded;
        public bool IsExpanded
        {
            get => isExpanded;
            set
            {
                SetProperty(ref isExpanded, value);
                OnPropertyChanged(nameof(Icon));
            }
        }

        public string Icon
        {
            get => isExpanded ? Icons.ExpandMore : Icons.ChevronRight;
        }

        public Command<HelpItemViewModel> ItemCommand { get; }

        public HelpItemViewModel(string question, string answer)
        {
            Question = question;
            Answer = answer;

            ItemCommand = new Command<HelpItemViewModel>(OnItemSelected);
        }

        void OnItemSelected(HelpItemViewModel item)
        {
            if (item == null) return;

            IsExpanded = !isExpanded;
        }

    }
}

