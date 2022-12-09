using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPMMeter
{
    class RPMViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private void NotifyPropertyChange(string info)
        {
            if(PropertyChanged!= null) 
            {
                PropertyChanged(this, new PropertyChangedEventArgs(info));
            }
        }

      
        int _angle;
        public int Angle
        {
            get
            {
                return _angle;
            }
            set
            {
                _angle = value;
                NotifyPropertyChange("Angle");
            }
        }
        int _value;
        public int Value
        {
            get
            {
                return _value;
            }
            set
            {
                if(value >=0 && value <= 9000)
                {
                    _value = value;
                    Angle = value - 85;
                    NotifyPropertyChange("Angle");
                }
            }
        }
    }
}
