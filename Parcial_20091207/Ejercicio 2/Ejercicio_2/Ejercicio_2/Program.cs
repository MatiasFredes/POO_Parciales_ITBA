using System;

namespace Ejercicio_2
{
    class Program
    {
        static void Main(string[] args)
        {
            FamilyCellPhoneGroup group = new FamilyCellPhoneGroup(2);

            CellPhone phone1 = new FamilyCellPhone(group, "111-111");
            CellPhone phone2 = new FamilyCellPhone(group, "222-222");
            CellPhone phone3 = new FamilyCellPhone(group, "333-333");

            phone1.MakeCall("222-222");
            phone2.MakeCall("111-111");
            phone3.MakeCall("555-555");

            FamilyCellPhoneGroup group2 = new FamilyCellPhoneGroup(2);

            Console.WriteLine(group.GetAviableCalls());
            Console.WriteLine(group2.GetAviableCalls());

            group.LoadCreadit(2);

            phone1.MakeCall("444-444");
            phone2.MakeCall("555-555");
            phone3.MakeCall("666-666");

            group.ShowPhones();

            phone1.MakeCall("777-777");

        }
    }
}
