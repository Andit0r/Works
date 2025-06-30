namespace Task1;

public partial class Lab39Task3Page : ContentPage
{
    private IEnumerable<FileInfo> _files = (new DirectoryInfo(@"Y:\ִּÊ.01.01"))
        .GetFiles("*", SearchOption.AllDirectories)
        .AsEnumerable();

    private IEnumerable<DirectoryInfo> _directories = (new DirectoryInfo(@"Y:\ִּÊ.01.01"))
     .GetDirectories("*", SearchOption.AllDirectories)
     .AsEnumerable();


    public Lab39Task3Page()
    {
        InitializeComponent();
        GetFiles();
    }

    private void GetFiles()
    {
        var selectedFiles = _files.Select(f => new
        {
            f.Name,
            f.DirectoryName,
            f.CreationTime
        });

        var selectedDirectories = _directories.Select(d => new
        {
            d.Name,
            DirectoryName = d.FullName,
            d.CreationTime
        });

        FilesListView.ItemsSource = selectedDirectories.Union(selectedFiles);
    }
}