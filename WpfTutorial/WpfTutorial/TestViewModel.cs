using System.ComponentModel;

namespace WpfTutorial
{
    public class TestViewModel : INotifyPropertyChanged
    {
        private TestModel testModel;
        private ActionCommand changeTitleCommand;
        public ActionCommand ChangeTitleCommand => changeTitleCommand;

        public TestViewModel(TestModel testModel)
        {
            this.testModel = testModel;
            this.changeTitleCommand = new ActionCommand((obj) => this.Title = "Test Button");
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
