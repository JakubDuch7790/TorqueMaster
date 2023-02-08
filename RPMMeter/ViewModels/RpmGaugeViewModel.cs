using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPMMeter
{
    class RPMViewModel : Screen
    {
        private int _angle;
        private int _value;

        public event PropertyChangedEventHandler PropertyChanged;
        private void NotifyPropertyChange(string info)
        {
            if(PropertyChanged!= null) 
            {
                PropertyChanged(this, new PropertyChangedEventArgs(info));
            }
        }
        public RPMViewModel()
        {
            Value = 0;
            Angle = _angle;
        }

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
        public int Value
        {
            get
            {
                return _value;
            }
            set
            {
                if(value >=0 && value <= 180)
                {
                    _value = value;
                    Angle = value - 90;
                    NotifyPropertyChange("Value");
                }
            }
        }
    }
}
