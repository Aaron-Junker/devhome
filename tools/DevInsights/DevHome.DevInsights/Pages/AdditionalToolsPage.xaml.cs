// Copyright (c) Microsoft Corporation.
// Licensed under the MIT License.

using DevHome.Common.Extensions;
using DevHome.DevInsights.ViewModels;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;

namespace DevHome.DevInsights.Pages;

public sealed partial class AdditionalToolsPage : Page
{
    public AdditionalToolsViewModel ViewModel { get; }

    public AdditionalToolsPage()
    {
        ViewModel = Application.Current.GetService<AdditionalToolsViewModel>();
        InitializeComponent();
    }

    private void SettingsAddToolCard_Expanded(object sender, System.EventArgs e)
    {
        AddToolPanel.RefreshAppList();
    }
}
