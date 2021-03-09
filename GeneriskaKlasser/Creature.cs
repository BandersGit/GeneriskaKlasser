using System;

namespace GeneriskaKlasser
{
    public class Creature<T, T2> //De man sätter "T" på kan man ändra datatypen på
    {
        public string name;
        public T category;
        public T2 hp;
    }
}
