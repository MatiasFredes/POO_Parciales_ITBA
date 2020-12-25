using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio_2
{
    public class FamilyCellPhone : CellPhone
    {
        private FamilyCellPhoneGroup familyCellPhoneGroup;

        public FamilyCellPhone(FamilyCellPhoneGroup familyCellPhoneGroup, string number) : base(number)
        {
            this.Enable();
            this.familyCellPhoneGroup = familyCellPhoneGroup;
            familyCellPhoneGroup.AddCallPhone(this);
        }

        protected override void OnCall(string number)
        {
            if (!familyCellPhoneGroup.CellPhoneIsPartOfTheGroup(number))
            {
                if (familyCellPhoneGroup.GetAviableCalls() <= 0)
                    throw new NoCreditException();

                familyCellPhoneGroup.DiscountCredit();
            }
        }
    }
}
