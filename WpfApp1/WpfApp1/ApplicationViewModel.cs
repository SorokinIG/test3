using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Collections.ObjectModel;


namespace WpfApp1
{
    public class ApplicationViewModel : INotifyPropertyChanged
    {
       


        private Department selectedDepartment;
        private Personal selectedPersonal;


    
        public ObservableCollection<Department> Departments { get; set; }
        public ObservableCollection<Personal> Personals { get; set; }

        public Department SelectedDepartment
        {
            get { return selectedDepartment; }
            set
            {
                selectedDepartment = value;
                OnPropertyChanged("SelectedDepartment");
            }
        }
        
           public Personal SelectedPersonal
        {
               get { return selectedPersonal; }
               set
               {
                   selectedPersonal = value;
                   OnPropertyChanged("SelectedPersonal");
               }
           }
          
    
        public ApplicationViewModel()
        {

            Departments = new ObservableCollection<Department>( Department.GetDepartments());

            Personals = new ObservableCollection<Personal>(Personal.GetPersonals());

        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName]string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
    }
}