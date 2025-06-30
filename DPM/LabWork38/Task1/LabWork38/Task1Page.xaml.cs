namespace Task1;

public partial class Task1Page : ContentPage
{
    private IEnumerable<FileInfo> _files = (new DirectoryInfo(@"Y:\МДК.01.01")).GetFiles().AsEnumerable();

    public int PageSize { get; set; } = 4;
    public int CurrentPage { get; set; } = 1;
    public int PagesCount { get; set; }

    public Task1Page()
    {
        InitializeComponent();

        _files = _files.OrderBy(f => f.Name);
        FileListView.ItemsSource = _files.Take(PageSize);
        PagesCount = (int)Math.Ceiling((double)_files.Count() / PageSize);
        InfoLabel.Text = $"Показано {PageSize} из {_files.Count()} записей. Всего страниц {PagesCount}";
    }

    private void MoreFilesButton_Clicked(object sender, EventArgs e)
    {
        CurrentPage++;
        LoadFiles();
    }

    private void LoadFiles()
    {
        if (CurrentPage == PagesCount)
            MoreFilesButton.IsEnabled = false;
        var loadedFiles = _files.Take(PageSize * CurrentPage);
        FileListView.ItemsSource = loadedFiles;
        PagesCount = (int)Math.Ceiling((double)_files.Count() / PageSize);
        InfoLabel.Text = $"Показано {loadedFiles.Count()} из {_files.Count()} записей. Всего страниц {PagesCount}";
    }

    private void PageSizeEntry_TextChanged(object sender, TextChangedEventArgs e)
    {
        if (PageSizeEntry.Text.Trim() == "")
        {
            return;
        }
        SelectPageSize(Convert.ToInt32(PageSizeEntry.Text));
    }

    private void SelectPageSize(int value)
    {
        CurrentPage = 1;
        PageSize = value;
        MoreFilesButton.IsEnabled = true;
        LoadFiles();
    }

    private void PageSizePicker_SelectedIndexChanged(object sender, EventArgs e)
    {
        SelectPageSize(Convert.ToInt32(PageSizePicker.SelectedItem));
    }
}