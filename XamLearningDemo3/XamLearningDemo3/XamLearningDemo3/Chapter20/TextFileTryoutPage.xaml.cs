using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamLearningDemo3.Chapter20
{
    public interface IFileHelper
    {
        bool Exists(string filename);
        void WriteText(string filename, string text);
        string ReadText(string filename);
        IEnumerable<string> GetFiles();
        void Delete(string filename);
    }
    public class FileHelper : IFileHelper
    {
        IFileHelper fileHelper = DependencyService.Get<IFileHelper>();
        public bool Exists(string filename)
        {
            return fileHelper.Exists(filename);
        }
        public void WriteText(string filename, string text)
        {
            fileHelper.WriteText(filename, text);
        }
        public string ReadText(string filename)
        {
            return fileHelper.ReadText(filename);
        }
        public IEnumerable<string> GetFiles()
        {
            IEnumerable<string> filepaths = fileHelper.GetFiles();
            List<string> filenames = new List<string>();
            foreach (string filepath in filepaths)
            {
                filenames.Add(Path.GetFileName(filepath));
            }
            return filenames;
        }
        public void Delete(string filename)
        {
            fileHelper.Delete(filename);
        }
    }
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TextFileTryoutPage : ContentPage
    {
        FileHelper fileHelper = new FileHelper();
        public TextFileTryoutPage()
        {
            InitializeComponent();
            RefreshListView();
        }
        async void OnSaveButtonClicked(object sender, EventArgs args)
        {
            string filename = filenameEntry.Text;
            if (fileHelper.Exists(filename))
            {
                bool okResponse = await DisplayAlert("TextFileTryout",
                "File " + filename +
                " already exists. Replace it?",
                "Yes", "No");
                if (!okResponse)
                    return;
            }
            string errorMessage = null;
            try
            {
                fileHelper.WriteText(filenameEntry.Text, fileEditor.Text);
            }
            catch (Exception exc)
            {
                errorMessage = exc.Message;
            }
            if (errorMessage == null)
            {
                filenameEntry.Text = "";
                fileEditor.Text = "";
                RefreshListView();
            }
            else
            {
                await DisplayAlert("TextFileTryout", errorMessage, "OK");
            }
        }
        async void OnFileListViewItemSelected(object sender, SelectedItemChangedEventArgs args)
        {
            if (args.SelectedItem == null)
                return;
            string filename = (string)args.SelectedItem;
            string errorMessage = null;
            try
            {
                fileEditor.Text = fileHelper.ReadText((string)args.SelectedItem);
                filenameEntry.Text = filename;
            }
            catch (Exception exc)
            {
                errorMessage = exc.Message;
            }
            if (errorMessage != null)
            {
                await DisplayAlert("TextFileTryout", errorMessage, "OK");
            }
        }
        void OnDeleteMenuItemClicked(object sender, EventArgs args)
        {
            string filename = (string)((MenuItem)sender).BindingContext;
            fileHelper.Delete(filename);
            RefreshListView();
        }
        void RefreshListView()
        {
            fileListView.ItemsSource = fileHelper.GetFiles();
            fileListView.SelectedItem = null;
        }
    }
}
