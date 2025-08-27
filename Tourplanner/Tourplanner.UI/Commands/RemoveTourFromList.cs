using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Tourplanner.UI.ViewModels;

namespace Tourplanner.UI.Commands
{
    internal class RemoveTourFromList : ICommand
    {
        public event EventHandler? CanExecuteChanged;
        private TourListViewModel viewModel;

        public RemoveTourFromList(TourListViewModel viewModel)
        {
            this.viewModel = viewModel;
            ChangeProperty(viewModel);
        }

        // Redraws list after Removing Element
        private void ChangeProperty(TourListViewModel viewModel)
        {
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
            return true;
        }

        public void Execute(object? parameter)
        {
            viewModel.RemoveClicked();
            Trace.WriteLine("Button clicked - Remove Tour");
        }
    }
}
