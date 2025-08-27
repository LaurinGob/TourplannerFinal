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
    internal class SearchBoxViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;
        public event EventHandler<int> OnSearchClicked;
        public ICommand SearchButtonCommand { get; }

        private string query;
        public string Query
        {
            get => query;
            set
            {
                //TODO: Sanitize for injections
                if (query != value)
                {
                    query = value;
                    OnPropertyChanged(nameof(Query));
                }
            }
        }

        public SearchBoxViewModel()
        {
            SearchButtonCommand = new SearchButtonCommand(this);
        }

        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public void SearchClicked()
        {
            OnSearchClicked?.Invoke(this, 1);
        }
    }
}
