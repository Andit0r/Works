namespace Task1;

public partial class Lab39Task2Page : ContentPage
{
    private IEnumerable<FileInfo> _private = (new DirectoryInfo(@"Y:\ÌÄÊ.01.01")).
        GetFiles("*", SearchOption.AllDirectories).
        AsEnumerable();

    public Lab39Task2Page()
	{
		InitializeComponent();
        GetFiles();
	}

    private void GetFiles()
    {
        FilesListView.ItemsSource =
            _private.GroupBy(f => new { f.CreationTime.Year, f.CreationTime.Month })
            .Select(g => new
            {
                g.Key.Year,
                g.Key.Month,
                FilesCount = g.Count()
            });
    }
}