using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace MD5FolderVerifier
{
    public class LogGrid : INotifyPropertyChanged
    {
        private string MsgType;
        private string MsgText;
        private string MsgResult;

        public event PropertyChangedEventHandler PropertyChanged;

        public LogGrid(string msgType, string msgText, string msgResult)
        {
            MsgType = msgType;
            MsgText = msgText;
            MsgResult = msgResult;
        }

        public string MessageType
        {
            get { return MsgType; }
            set
            {
                MsgType = value;
                this.NotifyPropertyChanged("MessageType");
            }
        }

        public string MessageText
        {
            get { return MsgText; }
            set
            {
                MsgText = value;
                this.NotifyPropertyChanged("MessageText");
            }
        }

        public string MessageResult
        {
            get { return MsgResult; }
            set
            {
                MsgResult = value;
                this.NotifyPropertyChanged("MessageResult");
            }
        }

        private void NotifyPropertyChanged(string name)
        {
            if(PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(name));
        }
    }
}
