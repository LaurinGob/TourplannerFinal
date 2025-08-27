using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Tourplanner.UI.Commands;

namespace Tourplanner.UI.ViewModels
{
    internal class TourListViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;
        public ICommand AddTourToList { get; }
        public ICommand RemoveTourFromList { get; }

        private int selectedIndex;
        public event EventHandler<int> OnAddClicked;
        public event EventHandler<int> OnSelected;
        public event EventHandler<int> OnRemoveClicked;
        public int SelectedIndex
        {
            get => selectedIndex;
            set
            {
                selectedIndex = value; // SetSelectedIndex(value)
                // on change event
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(SelectedIndex)));
                OnSelected?.Invoke(this, selectedIndex);
            }
        }


        public TourListViewModel()
        {
            AddTourToList = new AddTourToList(this);
            RemoveTourFromList = new RemoveTourFromList(this);
            SelectedIndex = -1;
        }



        public void AddClicked()
        {
            OnAddClicked?.Invoke(this, selectedIndex); 
        }

        public void RemoveClicked()
        {
            OnRemoveClicked?.Invoke(this, selectedIndex);
        }
    }
}
