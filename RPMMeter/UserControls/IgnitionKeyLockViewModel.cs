using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace RPMMeter.UserControls
{
    class IgnitionKeyLockViewModel : INotifyPropertyChanged
    {

        private int angle; 

        public event PropertyChangedEventHandler? PropertyChanged;

        private void OnPropertyChange([CallerMemberName]string propertyName = null) =>
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));

        public IgnitionKeyLockViewModel()
        {
            Angle = angle;
            Task.Run(() =>
            {
                while (true)
                {
                    Debug.WriteLine($"Angle: {Angle}");
                    Thread.Sleep(1000);
                }
            });
        }


        public int Angle
        {
            get => angle;
            set
            {
                if (angle != value)
                {
                    value = angle;
                    OnPropertyChange(nameof(Angle));
                }
            }
        }

    }
}
