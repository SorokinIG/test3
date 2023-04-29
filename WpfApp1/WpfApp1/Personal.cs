using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace WpfApp1
{
  public  class Personal: INotifyPropertyChanged
    {
        private string namepeople;
        
        public int ID { get; set; }

        public string Namepeople
        {
            get { return namepeople; }
            set
            {
                namepeople = value;
                OnPropertyChanged("Namepeople");
            }
        }

       

        public static Personal[] GetPersonals()
        {
            var result = new[]
            {
                new Personal() {ID = 1,  Namepeople="Леха"  },
                new Personal() {ID = 2,  Namepeople="Саша"  },
                new Personal() {ID = 3,  Namepeople="Сергей"  },
               

            };
            return result;
        }


        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName]string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }



    }
}
