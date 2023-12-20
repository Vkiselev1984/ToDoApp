using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoApp.Models
{
    internal class ToDoModel: INotifyPropertyChanged
    {
        private bool _IsDone;
        private string _text;

        public DateTime CretionDate { get; set; } = DateTime.Now;

        public bool IsDone
        {
            get { return _IsDone; }
            set
            {
                if (_IsDone == value)
                return;
                    _IsDone = value;
                    OnPropertyChanged("IsDone");
            }
        }
           
        
        public string Text { 
            get { return _text; } 
            set {
                if (_text == value)
                    return;
                _text = value;
                OnPropertyChanged("Text");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
           
        }
    }
}
