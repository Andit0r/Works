namespace Task1;

public partial class Lab39Task4Page : ContentPage
{

    private IEnumerable<FileInfo> _files = (new DirectoryInfo(@"C:\Users\0109-08\Desktop"))
    .GetFiles("*", SearchOption.AllDirectories)
    .AsEnumerable();

    private IEnumerable<DirectoryInfo> _directories = (new DirectoryInfo(@"C:\Users\0109-08\Desktop"))
     .GetDirectories("*", SearchOption.AllDirectories)
     .AsEnumerable();

    public Lab39Task4Page()
    {
        InitializeComponent();
        GetFiles();
    }

    private void GetFiles()
    {
        FilesListView.ItemsSource = _directories
            .Where(d => d.CreationTime.Date == DateTime.Today)
            .Join(_files, 
                d => d.FullName, 
                f => f.DirectoryName, 
                (d, f) => new
                {
                    f.Name,
                    f.DirectoryName,
                });
    }
}