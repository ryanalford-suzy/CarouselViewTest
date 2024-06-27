namespace CarouselTest;

public class MainPageDataTemplateSelector : DataTemplateSelector
{
    public DataTemplate FragmentOneItemTemplate { get; set; }
    public DataTemplate FragmentTwoItemTemplate { get; set; }
    
    protected override DataTemplate OnSelectTemplate(object item, BindableObject container)
    {
        if (item is DashboardItem fragmentInfo)
        {
            if (fragmentInfo.FragmentNumber == 1)
            {
                return FragmentOneItemTemplate;
            }
            
            return FragmentTwoItemTemplate;
        }

        return FragmentOneItemTemplate;
    }
}