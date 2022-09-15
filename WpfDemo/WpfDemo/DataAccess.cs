using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfDemo.Models;

namespace WpfDemo
{
    public class DataAccess
    {
        Random rnd = new Random();
        string[] streetAddress = new string[] { "345 Sana'a street", "564 Rada'a street", "7 wellcan away", "768 Oak Avenu", "5476 Hada'a Road" };
        string[] cities = new string[] { "Francklin", "NewYourk", "Sna'a", "Qodos", "Cayro" };
        string[] states = new string[] { "TX", "AZ", "PA", "NY", "YE" };
        string[] FirstName = new string[] { "Jamal", "Ali", "Salah", "Tamam", "Qasam" };
        string[] LastName = new string[] { "Jameel", "Mosaa", "Shagdary", "Twofiq", "Alsaydy" };
        bool[] aliveStatuses = new bool[] { false, true };
        DateTime endDataTime = new DateTime(1983 , 1, 1);
        int daysFromLowDate;
         
        public DataAccess()
        {
            daysFromLowDate = (DateTime.Today - endDataTime).Days;
        }
        public List<PorsonalModel> GetPeople(int total = 10)
        {
            List<PorsonalModel> Person = new List<PorsonalModel>();
            for(int i = 0; i < total; i++)
            {
                Person.Add(GetPerson(i + 1));
            }
            return Person; 
        }
        public PorsonalModel GetPerson(int id)
        {
            PorsonalModel output = new PorsonalModel();
            output.PersonId = id;
            output.FirstName = GetRandomItem(FirstName);
            output.LastName = GetRandomItem(FirstName);
            output.IsActive  = GetRandomItem(aliveStatuses);
            output.DataOfBerth = GetRandomData();
            output.Age = GetAgeInYears(output.DataOfBerth);
            output.AccountBalance = ((decimal)rnd.Next(1, 100000) / 100);
            int addressAcount = rnd.Next(1 , 5);
            for(int i=0;i < addressAcount; i++)
            {
                output.Addresses.Add(GetAddress(((id - 1) * 5) + i + 1));
                
            }
            return output;
        }
        private AddressModel GetAddress(int id) 
        {
            AddressModel output = new AddressModel();
            output.AddressId = id;
            output.StreetAddress = GetRandomItem(streetAddress);
            output.City = GetRandomItem(cities);
            output.State = GetRandomItem(states);


            return output;


        }
        private T GetRandomItem<T>(T[] data)
        {
            return data[rnd.Next(0, data.Length)];
        }
        private DateTime GetRandomData()
        {
            return endDataTime.AddDays(rnd.Next(daysFromLowDate));
        }
        private int GetAgeInYears(DateTime BarthDay)
        {
            DateTime now = DateTime.Today;
            int age = now.Year - BarthDay.Year;
            if(now < BarthDay.AddYears(age))
            {
                age--;
            }
            return age;
        }
    }
}
