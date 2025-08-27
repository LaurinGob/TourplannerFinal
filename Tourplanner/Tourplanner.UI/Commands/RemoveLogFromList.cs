using System;
using System.Windows.Input;
using Tourplanner.UI.ViewModels;

namespace TourPlanner.UI.Commands
{
    internal class RemoveLogFromList : ICommand
    {
        public event EventHandler? CanExecuteChanged;

        private TourLogsViewModel viewModel;

        public RemoveLogFromList(TourLogsViewModel viewModel)
        {
            this.viewModel = viewModel;

            viewModel.PropertyChanged += (sender, e) =>
            {
                if (e.PropertyName == nameof(viewModel.SelectedIndex))
                {
                    CanExecuteChanged?.Invoke(this, EventArgs.Empty);
                }
            };
        }

        public bool CanExecute(object? parameter)
        {
            return viewModel.SelectedIndex != -1;
        }

        public void Execute(object? parameter)
        {
            viewModel.RemoveClicked();
        }
    }
}
