using System;
using MovieStreamTemplate.Models;
using Xamarin.Forms;

namespace MovieStreamTemplate.ViewModels
{
    public class ProfileViewModel: BaseViewModel
    {
        public string Id { get; }

        private string image;
        public string Image
        {
            get => image;
            set => SetProperty(ref image, value);
        }

        private string name;
        public string Name
        {
            get => name;
            set => SetProperty(ref name, value);
        }

        private bool isSelected;
        public bool IsSelected
        {
            get => isSelected;
            set
            {
                SetProperty(ref isSelected, value);
                OnPropertyChanged(nameof(BorderThickness));
            }
        }

        public int BorderThickness
        {
            get => isSelected ? 2 : 0;
        }

        public ProfileViewModel(Profile profile, bool isSelected)
        {
            Id = profile.Id;

            Image = profile.Image;

            Name = profile.Name;

            IsSelected = isSelected;
        }
    }
}

