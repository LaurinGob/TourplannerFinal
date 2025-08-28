using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Input;
using Tourplanner.UI.Commands;
using Tourplanner.UI.Commands;

namespace Tourplanner.UI.ViewModels
{
    internal class TourLogsViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;
        public event EventHandler<int> OnAddClicked;
        public event EventHandler<int> OnRemoveClicked;

        public ICommand AddLogToList { get; }
        public ICommand RemoveLogFromList { get; }

        public int SelectedIndex
        {
            get => selectedIndex;
            set
            {
                selectedIndex = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(SelectedIndex)));
            }
        }

        private int selectedIndex;

        public TourLogsViewModel()
        {
            AddLogToList = new AddLogToList(this);
            RemoveLogFromList = new RemoveLogFromList(this);
            SelectedIndex = -1;
        }

        public void AddClicked()
        {
            OnAddClicked?.Invoke(this, SelectedIndex);
        }

        public void RemoveClicked()
        {
            OnRemoveClicked?.Invoke(this, SelectedIndex);
        }
    }
}
