﻿using CommunityToolkit.Mvvm.ComponentModel;
using System;

namespace MauiEdit.ViewModels;

/// <summary>
///  Base class for all view models. Takes a service provider in addition, so we can 
///  use <see cref="IServiceProvider"/> as an easy way for doing dependency injection.
/// </summary>
public abstract class WinFormsViewController : ObservableObject
{
    /// <summary>
    ///  Creates an instance of this class and initializes the <see cref="ServiceProvider"/> property.
    /// </summary>
    public WinFormsViewController(IServiceProvider serviceProvider) : base()
    {
        ServiceProvider = serviceProvider;
    }

    /// <summary>
    ///  Gets the service provider used to resolve dependencies.
    /// </summary>
    public IServiceProvider ServiceProvider { get; }
}