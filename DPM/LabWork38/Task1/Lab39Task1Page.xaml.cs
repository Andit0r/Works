namespace Task1;

public partial class Lab39Task1Page : ContentPage
{

    private IEnumerable<FileInfo> _files = (new DirectoryInfo(@"Y:\ÌÄÊ.01.01")).
        GetFiles("*", SearchOption.AllDirectories).
        AsEnumerable();

    public Lab39Task1Page()
    {
        InitializeComponent();
        GetFiles();
    }

    private void GetFiles()
    {
        FilesListView.ItemsSource = _files
            .GroupBy(f => f.Extension)
            .Select(g => new
                    {
                        g.Key,
                        TotalSize = g.Sum(f => f.Length),
                        Min = g.Min(f => f.Length),
                        Max = g.Max(f => f.Length),
                        FileCount = g.Count()
                    });
    }
}