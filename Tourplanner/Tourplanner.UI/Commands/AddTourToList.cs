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
    internal class AddTourToList : ICommand
    {
        public event EventHandler? CanExecuteChanged;

        private TourListViewModel viewModel;

        public AddTourToList(TourListViewModel viewModel)
        {
            this.viewModel = viewModel;
        }

        // required in interface, not used
        public bool CanExecute(object? parameter)
        {
            return true;
        }

        public void Execute(object? parameter)
        {
            viewModel.AddClicked();
            Trace.WriteLine("Button clicked - Add Tour");
        }
    }
}
