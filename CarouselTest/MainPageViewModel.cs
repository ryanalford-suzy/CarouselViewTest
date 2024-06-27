using System.Collections.ObjectModel;
using System.Windows.Input;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace CarouselTest;

public partial class MainPageViewModel : ObservableObject
{
    [ObservableProperty]
    private int _pagePosition;

    [ObservableProperty] 
    private ObservableCollection<DashboardItem> _dashboardItems;
    
    public MainPageViewModel()
    {
        List<DashboardItem> items = new();
        
        items.Add(new DashboardItem { FragmentNumber = 1, ViewModel = this });
        items.Add(new DashboardItem { FragmentNumber = 2, ViewModel = this });

        DashboardItems = new ObservableCollection<DashboardItem>(items);
    }
    
    [RelayCommand]
    private void FragmentOneButtonTapped()
    {
        PagePosition = 0;
    }
    
    [RelayCommand]
    private void FragmentTwoButtonTapped()
    {
        PagePosition = 1;
    }

    [RelayCommand]
    private async Task OpenPageAsync()
    {
        await Shell.Current.GoToAsync(nameof(SecondPage));
    }
}