using System;

namespace FinalFantasy.Core.Entities
{
    public class Hero : Character
    {
        public int LifePoints { get; set; }
        public int ExperiencePoint { get; set; }

        public User User { get; set; }
        public int UserId { get; set; }
        

        

        //public bool Escape()
        //{
        //    //METODO DA IMPLEMENTARE PER LA FUGA
              //SE LA FUGA RIESCE RESTITUISCO TRUE ALTRIMENTI FALSE
        //}

        

        public override string ToString()
        {
            return $"{Name} - {Classe} - Livello: {Level} Punti accumulati: {ExperiencePoint}";
        }
    }
}