using Caliburn.Micro;


namespace LearningCenter.ViewModels
{
    public class MessageViewModel : Screen
    {
        #region fields
        private string _msgText;
        private double _viewHeight;
        private double _viewWidth;
        #endregion

        #region props
         public string MsgText
        {
            get { return _msgText; }
            set { _msgText = value; NotifyOfPropertyChange(nameof(MsgText)); }
        }

        public double ViewHeight
        {
            get { return _viewHeight; }
            set { _viewHeight = value;  NotifyOfPropertyChange(nameof(ViewHeight)); }
        }

        public double ViewWidth
        {
            get { return _viewWidth; }
            set { _viewWidth = value;  NotifyOfPropertyChange(nameof(ViewWidth)); }
        }
        #endregion

        #region ctor
        public MessageViewModel()
        {
            MsgText = string.Empty;
            ViewHeight = 240;
            ViewWidth = 320;
        }
        #endregion

    }
}
