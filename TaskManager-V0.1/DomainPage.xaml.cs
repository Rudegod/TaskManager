namespace TaskManager_V0._1;

public partial class DomainPage : ContentPage
{
    Domain mainDomain = new Domain();
    public DomainPage()
	{
        InitializeComponent();
        SubDomainList.ItemsSource = mainDomain.subDomains;
        DomainData.domains.Add(mainDomain);
        mainDomain.subDomains.Add(new Domain());
    }

    private void addSubDomain(object sender, EventArgs e)
    {
        mainDomain.subDomains.Add(new Domain());
    }
}