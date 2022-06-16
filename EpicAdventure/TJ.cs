using System;
    public class TJ {
        Random rand = new Random();
        public string name = "Saiyan TJ";
        public int coins = 20000;
        public int health = 20;
        public int damage = 1;
        public int armorValue = 3;
        public int potion = 5;
        public int weaponValue = 7;
        public int dragonball = 1;
        public int mods = 20;

public int GetHealth(){
    int upper = (2 * mods + 5);
    int lower = (mods +2 );
    return rand.Next(lower,upper);
}

public int GetPower(){
    int upper = (2 * mods +2 );
    int lower = (mods +1 );
    return rand.Next(lower,upper);
}
        //Needs 7 Dragon Balls to end humanity
    }