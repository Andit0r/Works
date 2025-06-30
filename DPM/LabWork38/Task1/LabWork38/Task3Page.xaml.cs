namespace Task1;

public partial class Task3Page : ContentPage
{
    private IEnumerable<FileInfo> _files = (new DirectoryInfo(@"Y:\МДК.01.01\images")).GetFiles().AsEnumerable();

    public int PageSize { get; set; } = 3;
    public int CurrentPage { get; set; } = 1;
    public int PagesCount { get; set; }

    public Task3Page()
	{
		InitializeComponent();

        _files = _files.OrderBy(f => f.Name);
        FileListView.ItemsSource = _files.Take(PageSize);
        PagesCount = (int)Math.Ceiling((double)_files.Count() / PageSize);
        InfoLabel.Text = $"Показано {CurrentPage} из {PagesCount} страниц";
        PreviousPageButton.IsEnabled = false;
        PageNumberEntry.Text = CurrentPage.ToString();
    }

    private void PreviousPageButton_Clicked(object sender, EventArgs e)
    {
        CurrentPage--;
        FlipPage();
    }

    private void NextPageButton_Clicked(object sender, EventArgs e)
    {
        CurrentPage++;
        FlipPage();
    }

    private void FlipPage()
    {
        CheckPage();
        var loadedFiles = _files.Skip(PageSize * (CurrentPage - 1)).Take(PageSize);
        FileListView.ItemsSource = loadedFiles;
        InfoLabel.Text = $"Показано {CurrentPage} из {PagesCount} страниц";
        PageNumberEntry.Text = CurrentPage.ToString();
    }

    private void CheckPage()
    {
        PreviousPageButton.IsEnabled = true;
        NextPageButton.IsEnabled = true;
        FirstPageButton.IsEnabled = true;
        LastPageButton.IsEnabled = true;
        if (CurrentPage == 1)
        {
            PreviousPageButton.IsEnabled = false;
            FirstPageButton.IsEnabled = false;
        }
        if (CurrentPage == PagesCount)
        {
            NextPageButton.IsEnabled = false;
            LastPageButton.IsEnabled = false;
        }
    }

    private void PageNumberEntry_TextChanged(object sender, TextChangedEventArgs e)
    {
        FlipSpecifiedPage();
    }

    private void FlipSpecifiedPage()
    {
        if (PageNumberEntry.Text == string.Empty)
            return;

        if (Convert.ToInt32(PageNumberEntry.Text) <= PagesCount && Convert.ToInt32(PageNumberEntry.Text) >= 1)
        {
            CurrentPage = Convert.ToInt32(PageNumberEntry.Text);
            FlipPage();
        }
    }

    private void FirstPageButton_Clicked(object sender, EventArgs e)
    {
        CurrentPage = 1;
        FlipPage();
    }

    private void LastPageButton_Clicked(object sender, EventArgs e)
    {
        CurrentPage = PagesCount;
        FlipPage();
    }
}