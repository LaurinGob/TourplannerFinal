using System;
using System.Diagnostics;
using System.Windows.Input;
using Tourplanner.UI.ViewModels;

namespace Tourplanner.UI.Commands
{
    internal class SearchButtonCommand : ICommand
    {
        public event EventHandler? CanExecuteChanged;
        private SearchBoxViewModel viewModel;

        public SearchButtonCommand(SearchBoxViewModel viewModel)
        {
            this.viewModel = viewModel;
            viewModel.PropertyChanged += (sender, e) =>
            {
                if (e.PropertyName == nameof(viewModel.Query))
                {
                    CanExecuteChanged?.Invoke(this, EventArgs.Empty);
                    Trace.WriteLine("Searchbox change detected");
                }
            };
        }

        public bool CanExecute(object? parameter)
        {
            return !string.IsNullOrWhiteSpace(viewModel.Query);
        }

        public void Execute(object? parameter)
        {
            viewModel.SearchClicked();
            Trace.WriteLine("Searchin..");
        }
    }
}
