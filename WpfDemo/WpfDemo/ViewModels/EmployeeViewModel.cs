using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using WpfDemo.Views;

namespace WpfDemo.ViewModels
{
    public class EmployeeViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName]string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));


        }
        private EmployeeDetails _employeeDetail;

        public EmployeeDetails  EmployeeDetail
        {
            get { return _employeeDetail; }
            set {
                _employeeDetail = value;
                OnPropertyChanged(nameof(EmployeeDetail));
            }
        }
        private ObservableCollection <EmployeeDetails> _lstEmployeeDetails;

        public ObservableCollection<EmployeeDetails> LstEmployeeDetails
        {
            get { return _lstEmployeeDetails; }
            set
            {
                _lstEmployeeDetails = value;
                OnPropertyChanged(nameof(LstEmployeeDetails));

            }
        }
        

    }
}
