using System;
using System.Collections.Generic;
using System.Text;

namespace BrandonClassProject
{
    class Equipment
    {
        public string Name { get; set; }
        public EquipmentType eType { get; set; }
    }


    class EquipmentType
    {
        public string Armour { get; set; }
        public string StrWeapon { get; set; }
        public string IntWeapon { get; set; }
        public string AgiWeapon { get; set; }
    }

}


