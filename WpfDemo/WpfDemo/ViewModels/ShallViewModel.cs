using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfDemo.Models;
using WpfDemo.ViewModels;
using WpfDemo;
using WpfDemo.Views;


namespace WpfDemo.ViewModels
{
   public class ShallViewModel : Screen
    {
        private PorsonalModel _selectdperson;

        public BindableCollection<PorsonalModel> People { get; set; }
        public PorsonalModel SelectedPerson
        {
            get { return _selectdperson; }
            set
            {
                _selectdperson = value;
                NotifyOfPropertyChange(() => SelectedPerson);
            }


        }
        public void AddPeople()
        {
            DataAccess dataAccess = new DataAccess();
            int MaxId = People.Max(x => x.PersonId);
            People.Add(dataAccess.GetPerson(MaxId + 1));
        }




        public ShallViewModel()
        {
             DataAccess da = new DataAccess();
            People = new BindableCollection<PorsonalModel>(da.GetPeople());

        }




    }
}
