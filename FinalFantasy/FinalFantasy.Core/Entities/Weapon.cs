namespace FinalFantasy.Core.Entities
{
    public class Weapon
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public int Damage { get; set; }

        public string Class { get; set; }


        public override string ToString()
        {
            return $"{ID} - {Name} - Punti danno {Damage}";
        }
    }
}