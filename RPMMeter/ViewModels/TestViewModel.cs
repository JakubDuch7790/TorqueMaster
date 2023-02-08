using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RpmMeter.ViewModels
{
    public class TestViewModel : Screen
    {
		private int _testingRpm = 1300;
        private int _testingSpeed;
		private int _testingForce;


        public int TestingRpm
		{
			get 
			{
				return _testingRpm;
			}
			set 
			{
				_testingRpm = value;
				NotifyOfPropertyChange(() => TestingRpm);
			}
		}

		public int TestingSpeed
		{
			get 
			{
				return _testingSpeed;
			}
			set
			{
				_testingSpeed = value;
				NotifyOfPropertyChange(() => TestingSpeed);
			}
		}


		public int TestingForce
		{
			get
			{
				return _testingForce;
			}

			set 
			{
				_testingForce = value; 
			}
		}





	}
}
