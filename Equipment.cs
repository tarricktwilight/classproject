using System;
using System.Collections.Generic;
using System.Text;

namespace BrandonClassProject
{
    class Equipment
    {
        public string EquipName { get; set; }
        public EquipmentType eType { get; set; }
        public int EquipLevel { get; set; }
    }


    class EquipmentType
    {
        public string Armour { get; set; }
        public string StrWeapon { get; set; }
        public string IntWeapon { get; set; }
        public string AgiWeapon { get; set; }
    }

}


