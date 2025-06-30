namespace Task1;

public partial class Lab39Task5Page : ContentPage
{

    private IEnumerable<FileInfo> _files = (new DirectoryInfo(@"Y:\ִּÊ.01.01"))
    .GetFiles("*", SearchOption.AllDirectories)
    .AsEnumerable();

    private IEnumerable<DirectoryInfo> _directories = (new DirectoryInfo(@"Y:\ִּÊ.01.01"))
     .GetDirectories("*", SearchOption.AllDirectories)
     .AsEnumerable();

    public Lab39Task5Page()
    {
        InitializeComponent();
        GetFiles();
    }

    private void GetFiles()
    {
        DirectoriesListView.ItemsSource =
            _directories.GroupJoin(_files, 
                d => d.FullName, 
                f => f.DirectoryName, 
                (d, f) => new
                {
                    d.FullName,
                    FilesCount = f.Count()
                });
    }
}