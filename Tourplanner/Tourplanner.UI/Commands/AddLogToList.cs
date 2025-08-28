using System;
using System.Diagnostics;
using System.Windows.Input;
using Tourplanner.UI.ViewModels;

namespace Tourplanner.UI.Commands
{
    internal class AddLogToList : ICommand
    {
        public event EventHandler? CanExecuteChanged;

        private TourLogsViewModel viewModel;

        public AddLogToList(TourLogsViewModel viewModel)
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
            return true;//viewModel.SelectedIndex != -1;
        }

        public void Execute(object? parameter)
        {
            viewModel.AddClicked();
            Trace.WriteLine("Button clicked - Add Log");
        }
    }
}
