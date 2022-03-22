using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace WpfTutorial
{
    public class ActionCommand : ICommand
    {
        public event EventHandler? CanExecuteChanged;

        private Func<object?,bool> _CanExecute;
        private Action<object?> _Execute;

        public ActionCommand(Func<object?, bool> canExecute, Action<object?> execute)
        {
            this._CanExecute = canExecute;
            this._Execute = execute;
        }

        public ActionCommand(Action<object?> execute)
        {
            this._CanExecute = (obj) => true;
            this._Execute = execute;
        }

        public bool CanExecute(object? parameter) => _CanExecute(parameter);

        public void Execute(object? parameter) => _Execute(parameter);
    }
}
