using System.ComponentModel;

namespace WpfTutorial
{
    public class TestViewModel : INotifyPropertyChanged
    {
        public TestModel? testModel { get; set; }

        public string Title
        {
            get { return testModel.Title; }
            set { testModel.Title = value; NotifyPropertyChanged("Title"); }
        }

        public event PropertyChangedEventHandler? PropertyChanged;

        protected void NotifyPropertyChanged(string info)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(info));
        }
    }
}
