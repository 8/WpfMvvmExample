namespace WpfMvvmExample.ViewModel
{
  using System.Windows;
  using System.Windows.Input;

  class MainViewModel
  {
    public string Text { get; set; }

    #region ClickCommand
    private ICommand _ClickCommand;
    public ICommand ClickCommand
    {
      get
      {
        if (_ClickCommand == null)
          _ClickCommand = new RelayCommand(call => Click());
        return _ClickCommand;
      }
    }
    #endregion

    public MainViewModel()
    {
      this.Text = "This is a test!";
    }
    
    public void Click()
    {
      MessageBox.Show("You clicked the button!");
    }

  }
}
