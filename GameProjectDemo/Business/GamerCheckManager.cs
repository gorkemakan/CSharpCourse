using GameProjectDemo.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProjectDemo.Business
{
    public class GamerCheckManager : IPersonCheckService
    {
        public bool CheckIfRealPerson(Gamer gamer)
        {
            if (gamer.NationalId.Length == 11)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
