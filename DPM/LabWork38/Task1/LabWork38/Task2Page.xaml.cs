namespace Task1;

public partial class Task2Page : ContentPage
{
    private IEnumerable<FileInfo> _files = (new DirectoryInfo(@"Y:\МДК.01.01")).GetFiles().AsEnumerable();
    private IEnumerable<FileInfo> _filteredFiles;

    public int PageSize { get; set; } = 10;
    public int CurrentPage { get; set; } = 1;
    public int PagesCount { get; set; }

    public Task2Page()
    {
        InitializeComponent();
        _files = _files.OrderBy(f => f.Name);
        FileListView.ItemsSource = _files.Take(PageSize);
        PagesCount = (int)Math.Ceiling((double)_files.Count() / PageSize);
        InfoLabel.Text = $"Показано {CurrentPage} из {PagesCount} страниц";
        PreviousPageButton.IsEnabled = false;
        _filteredFiles = _files;
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
        Filter();
        CheckPage();
        var loadedFiles = _filteredFiles.Skip(PageSize * (CurrentPage - 1)).Take(PageSize);
        FileListView.ItemsSource = loadedFiles;
        InfoLabel.Text = $"Показано {CurrentPage} из {PagesCount} страниц";
    }

    private void CheckPage()
    {
        PreviousPageButton.IsEnabled = true;
        NextPageButton.IsEnabled = true;
        if (CurrentPage == 1)
            PreviousPageButton.IsEnabled = false;
        if (CurrentPage == PagesCount)
            NextPageButton.IsEnabled = false;
    }

    private void FilterEntry_TextChanged(object sender, TextChangedEventArgs e)
    {
        CurrentPage = 1;
        FlipPage();
    }

    private void Filter()
    {
        if (FilterEntry.Text == null)
        {
            _filteredFiles = _files;
            return;
        }

        _filteredFiles = _filteredFiles.Where(f => f.Name.Contains(FilterEntry.Text));
        FileListView.ItemsSource = _filteredFiles;
        PagesCount = (int)Math.Ceiling((double)_filteredFiles.Count() / PageSize);
    }
}