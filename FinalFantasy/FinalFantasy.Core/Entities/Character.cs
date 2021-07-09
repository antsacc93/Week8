using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalFantasy.Core.Entities
{
    public abstract class Character
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Classe { get; set; }
        public Weapon Weapon { get; set; }
        public int WeaponID { get; set; }
        public int Level { get; set; }

        //public int Fight(){
        //METODO CHE IMPLEMENTA L'AGGIORNAMENTO DEI PUNTI 
        //
        //}
    }
}
