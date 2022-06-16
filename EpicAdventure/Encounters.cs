using System;
public class Encounters
    {
        static Random rand = new Random(DateTime.Now.Millisecond);

        
        public static void RandomEncounter() {
            Print("While exploring you some rustling and glance behind you to see a flick of movement.");
            Console.ReadKey();
            Print("\"Come on out so that we can be done with this! I have Dragon Balls to collect!\" you taunt in the direction of the noise.");
            Console.ReadKey();
            Print($"After a moment of deliberation, figure emerges from the shadows and charges for you head on!");
            Console.ReadKey();
            Combat( true, "", 0, 0);
            Console.ReadKey();
            Print($"The monster explodes into a bajillion pieces, splattering it viscera in all directions.\n"+
            $"Some lands on you and");
            Console.ReadKey();
            Console.Clear();
        }

    //Encounters
    public static void Boss1() {
            Print("As you approach you quickly realize you were right to come here.\n" +
            "The thing you saw is Android 13! The muscle bound menace with a baseball cap made by the evil Dr.Gero!");
            Console.ReadKey();
            Print("You square your jaw and set your gaze directly at Android 13. Daring him to take you on!");
            Console.ReadKey();
            Combat(false,"Android 13", 4, 8);
            Console.ReadKey();
            //boss defeat text
            Console.ReadKey();
            Console.Clear();
        }

        public static void Boss2() {
            Print("Looking into the distance, you see something coming towards you at great speed.");
            Print($"\"A bird?\" you think... \"Maybe a plane?\"");
            Print("You quickly realize its another Android heading your way");
            Console.ReadKey();
            Print($"You swoop to the left, dodging his attack. \"Are we really going to do this?\" you ask, obviously annoyed.");
            Print($"As he's gathering his balance he lets out a guttural scream \"Fight me and PERISH!\"");
            Console.ReadKey();
            Combat(false, "Android 15", 8, 16);
            Console.ReadKey();
            //boss defeat text
            Console.ReadKey();
            Console.Clear();
        }
        public static void Boss3() {
            // Encounter description Print();
            // Console.ReadKey();
            // Print($"You square your jaw and set your gaze directly at Android 13. Daring him to take you on!");
            // Console.ReadKey();
            Combat(false, "Android 17", 16, 32); //bool name, attack value, health.
            Console.ReadKey();
            Print("\"AGHAHHHH! How could this be!? Thwarted by a grubby little peon like you!?\"\n" + 
            "Android 17 yells in defeat as you brush the dust off your sleeve.");
            Print("As you look down your nose at the crumpled mess of a monster below you,\n" +
            "you can't help but feel your ego swell to even greater heights.");
            Console.ReadKey();
            Console.Clear();
        }
        public static void Boss4() {
            // Encounter description Print();
            // Console.ReadKey();
            // Print($"You square your jaw and set your gaze directly at Android 13. Daring him to take you on!");
            // Console.ReadKey();
            Combat(false, "Android 21", 32, 64); //bool name, attack value, health.
            Console.ReadKey();
            Print("Android 15 sputters unintelligibly, reaching his hand out,\n" +
            "grasping the empty air around him as if it was his last chance of survival.");
            Print($"\"You should've known you'd be no match for me, Android.\" you snide, sauntering away zealously.");
            Console.ReadKey();
            Console.Clear();
        }
        
        
        public static void FinalBoss() {
            // add intro
            Combat(false, "Vegeta", 160, 320); //name, attack value, health.
            Console.ReadKey();
            //boss defeat text
            Print("With Vegeta being defeated you glance to the sky and see a majestic dragon.");
            Print("\"Greetings TJ! You have collected all of my ballz. As your reward for handling them with care and honor, I bestow but one wish. An all powerful wish that can grant you anything you desire.\"");
            Print("\"Now then, what shall it be?!\"");
            string wish = System.Console.ReadLine();
            if (rand.Next() * 100 <= 33) {
            Print($"\"Hmmm. Rather odd request but I shall grant it none the less.\"");
            } else if (rand.Next() * 100 <= 66) {
            Print($"\"Well, thats not something I'd wish for, but so be it.\"");
            } else if (rand.Next() * 100 <= 99) {
            Print($"\"As you wish, weirdo!\"");
            Console.ReadKey();
            Console.Clear();
            }
        }

        
        public static void Valley() {
             bool selectionNeeded = true;
             int db = 1;


            while (selectionNeeded) {
                Print("You step over your victims lifeless body and notice a bulbous orange sphere protruding from his left pocket.");
                Print("Do you think you should see what it is?\n" +
                "1. \"Well, curiousity hasnt killed this cat... yet...\"\n" +
                "2. \"Eww? Not going anywhere near any dead people... Gross!\"");

                string selection = Console.ReadLine();

                if (selection == "1") {
                    Print("You found a flippin' Dragon Ball! Wow!");
                    ProgramUI.currentPlayer.dragonball += db;
                    selectionNeeded = false;
                } else if (selection == "2") {
                    Print("You walk away from the scene, gagging... Come on, dude!");
                    selectionNeeded = false;
                }
            }
        }

        public static void Emporium() {
            bool selectionNeeded = true;

            while (selectionNeeded) {
                Print("You here shouting in the distance.\n" +
                "You wonder again what is keeping you from peacful rest, so you head to the east to investigate.\n" + 
                "You see a shop up ahead.");
                Print("Do you want to...\n" +
                "1. Enter the shop? Or...\n" +
                "2. Keep searching for a quiet oasis to take your nap?");

                string selection = Console.ReadLine();

                if (selection == "1") {
                    Print("As you approach, the shouting gets louder.\n" +
                    "You see the sign above the door that reads \"Lao's Emporium\" and think \"This can't be so bad\"...");
                    Shop.LoadShop(ProgramUI.currentPlayer);
                    selectionNeeded = false;
                }
                else if (selection == "2") {
                    Print("You shake your head, \"No way I'm going there!\", and sulk as you make your way to a nearby lake\n" +
                    "\"Surely I should find it relaxing by the water.\"");
                    selectionNeeded = false;
                }
            }
        }

        public static void QuietLake() {
            bool selectionNeeded = true;
            int db = 1;

            while (selectionNeeded) {

            //Selections here

            string selection = Console.ReadLine();

            if (selection == "1") {
                    Print("You found a flippin' Dragon Ball! Wow!");
                    ProgramUI.currentPlayer.dragonball += db;
                    selectionNeeded = false;
                } else if (selection == "2") {
                    Print("You walk away, unbothered and unaware that you may be missing out on a fantastic find.");
                    selectionNeeded = false;
                }
            }
        }

        public static void Forest() {
            bool selectionNeeded = true;
            int db = 1;

            while (selectionNeeded) {

            //Selections here

            string selection = Console.ReadLine();

            if (selection == "1") {
                    Print("You found a flippin' Dragon Ball! Wow!");
                    ProgramUI.currentPlayer.dragonball += db;
                    selectionNeeded = false;
                } else if (selection == "2") {
                    Print("You walk away,"); // leaving text
                    selectionNeeded = false;
                }
            }
        }

        public static void MountainBase() {
            bool selectionNeeded = true;
            int db = 1;

            while (selectionNeeded) {

            //Selections here

            string selection = Console.ReadLine();

            if (selection == "1") {
                    Print("You found a flippin' Dragon Ball! Wow!");
                    ProgramUI.currentPlayer.dragonball += db;
                    selectionNeeded = false;
                } else if (selection == "2") {
                    Print("You walk away,"); // leaving text
                    selectionNeeded = false;
                }
            }
        }

        public static void Temple() {
            bool selectionNeeded = true;
            int db = 1;

            while (selectionNeeded) {

            //Selections here

            string selection = Console.ReadLine();

            if (selection == "1") {
                    Print("You found a flippin' Dragon Ball! Wow!");
                    ProgramUI.currentPlayer.dragonball += db;
                    selectionNeeded = false;
                } else if (selection == "2") {
                    Print("You walk away,"); // leaving text
                    selectionNeeded = false;
                }
            }
        }

        // win encounter/ end credits?
        
        //Encounter Tools
        public static void Combat( bool random, string name, int power, int health) {

            string n = "";
            int p = 0;
            int h = 0;
            if (random){
                n = GetName();
                p = rand.Next(1, 10);
                h = rand.Next(1, 10);
            }
            else{
            n = name;
            p = power;
            h = health;
            }
            while (h > 0 ) {
                Console.Clear();
                Console.WriteLine(n);
                Console.WriteLine("ATK: " + p + "/" + " HP: " + h);
                Console.WriteLine("===================");
                Console.WriteLine("|(A)ttack (D)efend|");
                Console.WriteLine("| (H)eal   (R)un  |");
                Console.WriteLine("===================");
                Console.WriteLine($" Potions: {ProgramUI.currentPlayer.potion}  Health: {ProgramUI.currentPlayer.health}");
                System.Console.WriteLine("(E)xit");

                
                string input = Console.ReadLine();

                if(input.ToLower() == "a" || input.ToLower() == "attack"){
                    
                    //Attack
                    int damage = p - ProgramUI.currentPlayer.armorValue;
                    if (damage < 0) {
                    damage = 0;} 
                    int attack = rand.Next(0, ProgramUI.currentPlayer.weaponValue) + rand.Next(1,4);
                    
                    Print($"You swipe horizontally with your Power Pole! Delivering a staggering blow that deals {attack} damage!");
                    Print($"{n} follows up with their own attack!    You lose {damage} health!");
                    ProgramUI.currentPlayer.health -= damage;
                    h -= attack;
                }
                else if(input.ToLower() == "d" || input.ToLower() == "defend"){
                    //Defend
                    int damage = (p/4) - ProgramUI.currentPlayer.armorValue;
                    if (damage < 0) {
                    damage = 0;}
                    int attack = rand.Next(0, ProgramUI.currentPlayer.weaponValue) + rand.Next(1,4);
                    
                    Print($"You puff up your chest while taunting with an outstretched hand. Ready and willing to accept the blow from {n}.");
                    Print($"{n} lashes out in frustration! Dealing a glancing blow while taking {attack} damage due to their sloppiness.    You lose {damage} health");
                    ProgramUI.currentPlayer.health -= damage;
                    h -= attack;
                }
                else if(input.ToLower() == "e" || input.ToLower() == "exit"){
                    //Exit
                    h = 0;
                }
                
                else if(input.ToLower() == "h" || input.ToLower() == "heal"){
                    //Heal
                    if (ProgramUI.currentPlayer.potion == 0) {
                        int damage = p - ProgramUI.currentPlayer.armorValue;
                        Print("You desperately grab at your knapsack rummaging for a healing potion but you're all out!");
                        Print($"Seizing the opportunity, {n} strikes hard and fast dealing {damage}!");
                        if (damage < 0 ) {
                            damage = 0;}
                    } else {
                        Print("You reach into your knapsack and pop the cork off a healing potion. You chug it like a white claw and smash the glass on the ground.");
                        int potionV = 50;
                        Print($"You gain {potionV} health");
                        ProgramUI.currentPlayer.health += potionV;
                        Print($"{n} jabs forward!");
                        int damage = (p / 2) - ProgramUI.currentPlayer.armorValue;
                        if (damage < 0 ) {
                            damage = 0;}
                        ProgramUI.currentPlayer.potion -= 1;
                        Print($"You loose {damage} health");
                        }
                    }
                else if(input.ToLower() == "r" || input.ToLower() == "run"){

                    //Run
                    int damage = (p*10) - ProgramUI.currentPlayer.armorValue;
                    if (damage < 0){
                        damage = 0;}

                        Print("You try to run from combat, but are thwarted in your attempt!");
                        Print("\"You can't run from me!\"");
                        Print($"You've taken {damage} damage!");
                        ProgramUI.currentPlayer.health -= damage;
                }
                Console.ReadKey();


            // DEATH
            if (ProgramUI.currentPlayer.health <= 0){
                Console.Clear();
                Print("You slump to your knees, defeated, waiting for the final blow to strike.");
                Console.ReadKey();
                Print("You think to yourself,\"Maybe I should just think of this as one long, long nap.\" Everything fades to black.");
                Console.ReadKey();
                Environment.Exit(0);
            }
        
            }
        }
            //int c = rand.Next(10,50);
            public static string GetName(){
                switch(rand.Next(0,4)){
                    case 0:
                        return "Giant Bear";
                    case 1: 
                        return "Man-eating Venus Flytrap";
                    case 2:
                        return "Todd";
                    case 3: 
                        return "Hired Mercenary";
                    case 4: 
                        return "Yeti";
                }
            return "Ruffian";
            }
            public static void Print(string text, int  textdelay = 40){
    foreach (char c in text){
        Console.Write(c);
        System.Threading.Thread.Sleep(textdelay);
    }
    System.Console.WriteLine();
}
    }
            