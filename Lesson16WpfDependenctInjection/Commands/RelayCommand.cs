﻿using System.Windows.Input;

namespace Lesson16WpfDependenctInjection.Commands;
/*
Salam A dostlar 
 
*/
public class RelayCommand : ICommand
{
    public event EventHandler? CanExecuteChanged
    {
        add { CommandManager.RequerySuggested += value; }
        remove { CommandManager.RequerySuggested -= value; }
    }

    private readonly Action<object?> _execute;
    private readonly Predicate<object?>? _canExecute;
    // Salam Ibrahim
    public RelayCommand(Action<object?> execute, Predicate<object?>? canExecute = null)
    {
        _execute = execute ?? throw new ArgumentNullException(nameof(execute));
        _canExecute = canExecute;
    }

    public bool CanExecute(object? parameter) => _canExecute is null || _canExecute.Invoke(parameter);  

    public void Execute(object? parameter) => _execute.Invoke(parameter);


    //Salam Men Mehemmed..
}

