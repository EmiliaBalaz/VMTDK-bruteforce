using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace BruteForceApp.Common
{
    public class CustomCommand : ICommand
    {
		private Action<object> _execute;
		private Predicate<object> _canExecute;

		public CustomCommand(Action<object> execute,Predicate<object> canExecute)
		{
			if (execute == null)
				throw new NullReferenceException("execute parameter is null!");

			_execute = execute;

			_canExecute = canExecute;
		}

		public CustomCommand(Action<object> execute) : this(execute, null)
		{

		}

		public event EventHandler CanExecuteChanged
		{
			add { CommandManager.RequerySuggested += value; }
			remove { CommandManager.RequerySuggested -= value; }
		}

		public bool CanExecute(object parameter)
		{
			return _canExecute == null ? true : _canExecute(parameter);
		}

		public void Execute(object parameter)
		{
			_execute.Invoke(parameter);
		}

	}
}
