using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Ejercicio_2
{
    public class FamilyCellPhoneGroup
    {
        private int credits;

        private IList<FamilyCellPhone> familyCellPhones; 
        public FamilyCellPhoneGroup(int credits)
        {
            this.credits = credits;
            this.familyCellPhones = new List<FamilyCellPhone>();
        }

        public void AddCallPhone(FamilyCellPhone familyCellPhone)
        {
            familyCellPhones.Add(familyCellPhone);
        }

        public void LoadCreadit(int credits)
        {
            this.credits += credits;
        }

        public void ShowPhones()
        {
            foreach (var phone in familyCellPhones)
            {
                Console.WriteLine(phone.GetNumber());
            }
        }

        public int GetCredits()
        {
            return credits;
        }

        public bool CellPhoneIsPartOfTheGroup(string number)
        {
            return familyCellPhones
                .Where(cellPhone => cellPhone.GetNumber() == number)
                .SingleOrDefault() != null;
        }

        public void DiscountCredit()
        {
            if(credits > 0)
            {
                credits -= 1;
            }
        }

        public int GetAviableCalls()
        {
            return credits;
        }
    }
}
