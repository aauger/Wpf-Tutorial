using System.ComponentModel;

namespace WpfTutorial
{
    public class TestViewModel : INotifyPropertyChanged
    {
        private TestModel testModel;

        public TestViewModel(TestModel testModel)
        {
            this.testModel = testModel;
        }

        public string Title
        {
            get => testModel.Title;
            set { testModel.Title = value; NotifyPropertyChanged("Title"); }
        }

        public event PropertyChangedEventHandler? PropertyChanged;

        protected void NotifyPropertyChanged(string info)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(info));
        }
    }
}
