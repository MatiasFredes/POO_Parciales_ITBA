using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio_2
{
    public abstract class CellPhone
    {
        private string number;
        private bool isEnabled;

        protected CellPhone(string number)
        {
            this.number = number;
        }

        public void Enable()
        {
            isEnabled = true;
        }

        public void Disable()
        {
            isEnabled = false;
        }

        public void MakeCall(string number)
        {
            if (!isEnabled)
            {
                throw new DisableCellPhoneException();
            }

            OnCall(number);
        }

        public string GetNumber()
        {
            return number;
        }

        protected abstract void OnCall(string number);

        public override string ToString()
        {
            return number;
        }

        public override int GetHashCode()
        {
            return number.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            if(obj == null || !(obj is CellPhone))
            {
                return false;
            }
            return number.Equals(((CellPhone)obj).number);
        }
    }
}
