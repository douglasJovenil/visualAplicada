using System;
using System.Collections.Generic;
using System.Text;

namespace ProgramacaoOrientadaObjetos
{
    class Account : AbstractAccount
    {
        public int NumberAccount {get; set;}
        public string OwnerName { get; set; }
        public float AccountBalance { get; set; }

        public override void AddMoney(float value) => AccountBalance += value;

        public override bool GetMoney(float value)
        {
            if (AccountBalance > value)
            {
                AccountBalance -= value;
                return true;
            }
            return false;
        }
    }
}
