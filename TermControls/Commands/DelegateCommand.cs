// --------------------------------------------------------------------------------------------------------------------
// <copyright file="DelegateCommand.cs" company="MyCompanyName">
//   The MIT License (MIT)
//   Copyright(c) 2014 Viacheslav Avsenev
// </copyright>
// <summary>
//   The delegate command.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace TermControls.Commands
{
    using System;
    using System.Windows.Input;

    /// <summary>
    /// The delegate command.
    /// </summary>
    public class DelegateCommand : ICommand
    {
        /// <summary>
        /// The action.
        /// </summary>
        private readonly Action<object> action;

        /// <summary>
        /// Initializes a new instance of the <see cref="DelegateCommand"/> class.
        /// </summary>
        /// <param name="action">
        /// The action.
        /// </param>
        public DelegateCommand(Action<object> action)
        {
            this.action = action;
        }

        /// <summary>
        /// The can execute changed.
        /// </summary>
        public event EventHandler CanExecuteChanged
        {
            add
            {
            }

            remove
            {
            }
        }

        /// <summary>
        /// The execute.
        /// </summary>
        /// <param name="parameter">
        /// The parameter.
        /// </param>
        public void Execute(object parameter)
        {
            this.action(parameter);
        }

        /// <summary>
        /// The can execute.
        /// </summary>
        /// <param name="parameter">
        /// The parameter.
        /// </param>
        /// <returns>
        /// The <see cref="bool"/>.
        /// </returns>
        public bool CanExecute(object parameter)
        {
            return true;
        }
    }
}
