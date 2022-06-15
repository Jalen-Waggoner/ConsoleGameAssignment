using System;
public class Encounters
    {
        static Random rand = new Random(DateTime.Now.Millisecond);
        
        public static void RandomEncounter() {
            System.Console.WriteLine("While exploring you some rustling and glance behind you to see a flick of movement.");
            Console.ReadKey();
            System.Console.WriteLine("\"Come on out so that we can be done with this! I have Dragon Balls to collect!\" you taught in the direction of the noise.");
            Console.ReadKey();
            System.Console.WriteLine($"After a moment of deliberation, figure emerges from the shadows and charges for you head on!");
            Console.ReadKey();
            Combat( true, "", 0, 0);
        }
        
        //Encounters
        public static void Boss1() {
            Console.WriteLine("As you approach you quickly realize you were right to come here.\n" +
            "The thing you saw is Android 13! The muscle bound menace with a baseball cap made by the evil Dr.Gero!");
            Console.ReadKey();
            Console.WriteLine($"You square your jaw and set your gaze directly at Android 13. Daring him to take you on!");
            Console.ReadKey();
            Combat(false,"Android 13", 1, 4);
            Console.WriteLine($"\"AGHAHHHH! How could this be!? Thwarted by a grubby little peon like you!?\" Android 13 yells in defeat as you brush the dust off your sleeve.");
            Console.WriteLine("As you look down your nose at the crumpled mess of a monster below you, you can't help but feel your ego swell to even greater heights.");
            Console.Clear();
        }

        public static void Boss2() {
            Console.WriteLine("Looking into the distance, you see something coming towards you at great speed.");
            System.Console.WriteLine($"\"A bird?\" you think... \"Maybe a plane?\"");
            System.Console.WriteLine("You quickly realize its another Android heading your way");
            Console.ReadKey();
            System.Console.WriteLine($"You swoop to the left, dodging his attack. \"Are we really going to do this?\" you ask, obviously annoyed.");
            System.Console.WriteLine($"As he's gathering his balance he lets out a guttural scream \"Fight me and PERISH!\"");
            Console.ReadKey();
            Combat(false, "Android 15", 3, 8);
            System.Console.WriteLine("Android 15 sputters unintelligibly, reaching his hand out, grasping the empty air around him as if it was his last chance of survival.");
            System.Console.WriteLine($"\"You should've known you'd be no match for me, Android.\" you snide, sauntering away zealously.");
        }
        public static void Boss3() {
            // Encounter description Console.WriteLine();
            // Console.ReadKey();
            // Console.WriteLine($"You square your jaw and set your gaze directly at Android 13. Daring him to take you on!");
            // Console.ReadKey();
            Combat(false, "Android 17", 9, 16); //name, attack value, health.
        }
        public static void Boss4() {
            // Encounter description Console.WriteLine();
            // Console.ReadKey();
            // Console.WriteLine($"You square your jaw and set your gaze directly at Android 13. Daring him to take you on!");
            // Console.ReadKey();
            Combat(false, "Android 21", 27, 32); //name, attack value, health.
        }
        
        
        public static void FinalBoss() {
            // Encounter description Console.WriteLine();
            // Console.ReadKey();
            // Console.WriteLine($"You square your jaw and set your gaze directly at Android 13. Daring him to take you on!");
            // Console.ReadKey();
            Combat(false, "Vegeta", 135, 128); //name, attack value, health.
            System.Console.WriteLine("The boss being defeated you glance to the sky and see a majestic dragon.");
            System.Console.WriteLine("\"Greetings TJ! You have collected all of my ballz. As your reward for handling them with care and honor, I bestow but one wish. An all powerful wish that can grant you anything you desire.\"");
            System.Console.WriteLine("\"Now then, what shall it be?!\"");
            string wish = System.Console.ReadLine();
            if (rand.Next() * 100 <= 33) {
            System.Console.WriteLine($"\"Hmmm. Rather odd request but I shall grant it none the less.\"");
            } else if (rand.Next() * 100 <= 66) {
            System.Console.WriteLine($"\"Well, thats not something I'd wish for, but so be it.\"");
            } else if (rand.Next() * 100 <= 99) {
            System.Console.WriteLine($"\"As you wish, weirdo!\"");
            }
        }
        
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
                    
                    Console.WriteLine($"You swipe horizontally with your Power Pole! Delivering a staggering blow that deals {attack}");
                    Console.WriteLine($"{n} follows up with their own attack!    You lose {damage} health");
                    ProgramUI.currentPlayer.health -= damage;
                    h -= attack;
                }
                else if(input.ToLower() == "d" || input.ToLower() == "defend"){
                    //Defend
                    int damage = (p/4) - ProgramUI.currentPlayer.armorValue;
                    if (damage < 0) {
                    damage = 0;}
                    int attack = rand.Next(0, ProgramUI.currentPlayer.weaponValue) + rand.Next(1,4);
                    
                    Console.WriteLine($"You puff up your chest while taunting with an outstretched hand. Ready and willing to accept the blow from {n}.");
                    Console.WriteLine($"{n} lashes out in frustration! Dealing a glancing blow while taking {attack} damage due to their sloppiness.    You lose {damage} health");
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
                        Console.WriteLine("You desperately grab at your knapsack rummaging for a healing potion but you're all out!");
                        Console.WriteLine($"Seizing the opportunity, {n} strikes hard and fast dealing {damage}!");
                        if (damage < 0 ) {
                            damage = 0;}
                    } else {
                        Console.WriteLine("You reach into your knapsack and pop the cork off a healing potion. You chug it like a white claw and smash the glass on the ground.");
                        int potionV = 5;
                        Console.WriteLine($"You gain {potionV} health");
                        ProgramUI.currentPlayer.health += potionV;
                        Console.WriteLine($"Mid chug {n} jabs forward!");
                        int damage = (p / 2) - ProgramUI.currentPlayer.armorValue;
                        if (damage < 0 ) {
                            damage = 0;}
                        ProgramUI.currentPlayer.potion -= 1;
                        Console.WriteLine($"You loose {damage} health");
                        }
                    }
                else if(input.ToLower() == "r" || input.ToLower() == "run"){

                    //Run
                    int damage = (p*10) - ProgramUI.currentPlayer.armorValue;
                    if (damage < 0){
                        damage = 0;}

                        System.Console.WriteLine("You try to run from combat, but are thwarted in your attempt!");
                        System.Console.WriteLine("\"You can't run from me!\"");
                        System.Console.WriteLine($"You've taken {damage} damage!");
                        ProgramUI.currentPlayer.health -= damage;
                }
                Console.ReadKey();

            if (ProgramUI.currentPlayer.health <= 0){
                Console.Clear();
                System.Console.WriteLine("You slump to your knees, defeated, waiting for the final blow to strike.");
                Console.ReadKey();
                System.Console.WriteLine("You think to yourself,\"Maybe I should just think of this as one long, long nap.\" Everything fades to black.");
                Console.ReadKey();
                Environment.Exit(0);
            }
            }
        }
            int c = rand.Next(10,50);
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
            }