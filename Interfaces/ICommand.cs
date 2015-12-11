using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Patterns.Interfaces
{
    public interface ICommand
    {
        bool CanExecute(Object parameter);
        void Execute(Object parameter);

        event EventHandler CanExecuteChanged;
    }
}
