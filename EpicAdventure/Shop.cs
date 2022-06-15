using System;


    public class Shop
    {
        static int armorMod;
        static int weaponMod;
        static int difficultyMod;
        public static void LoadShop(TJ tj){
            RunShop(tj);
        }

        public static void RunShop(TJ tj){
            
            int potionP;
            int armorP;
            int weaponP;
            int difP;
            
            
            System.Console.WriteLine("You dust your boots off at the door and pull out your coin purse as you walk to the front counter of the best adventurer's shop there is. \"Leo's Emporium\"");
            Console.ReadKey();
            System.Console.WriteLine("\"WELL HELLO THERE YOUNG TJ!\" Mr.Lao shouts as usual from behind the counter as his hearing isn't what it used to be. \"WHATCHA LOOKING FOR TODAY!?\"");
            
            while (true){

            potionP = 20 + 10*tj.mods;
            armorP = 100 * tj.armorValue;
            weaponP = 100 * (tj.weaponValue + 1);
            difP = 300 + 100 * tj.mods;
            
            Console.ReadKey();
            Console.Clear();
            System.Console.WriteLine("        Lao's Emporium       ");
            System.Console.WriteLine("=============================");
            System.Console.WriteLine($"(W)eapon:                ${weaponP}");
            System.Console.WriteLine($"(A)rmor:                 ${armorP}");
            System.Console.WriteLine($"(P)otion:                ${potionP}");
            System.Console.WriteLine($"(D)ifficulty Mod:        ${difP}");
            System.Console.WriteLine("=============================");
            System.Console.WriteLine("(E)xit");
            System.Console.WriteLine();
            System.Console.WriteLine();
            System.Console.WriteLine("           TJ Stats          ");
            System.Console.WriteLine("=============================");
            System.Console.WriteLine($"Current Health:  {tj.health}");
            System.Console.WriteLine($"Weapon:     {tj.weaponValue}");
            System.Console.WriteLine($"Armor:       {tj.armorValue}");
            System.Console.WriteLine($"Potions:         {tj.potion}");
            System.Console.WriteLine($"Gold:             {tj.coins}");
            System.Console.WriteLine($"Difficulty Mod:    {tj.mods}");
            System.Console.WriteLine("=============================");
            
            string input = Console.ReadLine().ToLower();
            
            if (input == "w" || input == "weapon"){
                TryBuy("weapon", weaponP, tj);
            }
            else if (input == "a" || input == "armor"){
                TryBuy("armor", armorP, tj);
            }
            else if (input == "p" || input == "potion"){
                TryBuy("potion", potionP, tj);
            }
            else if (input == "d" || input == "difficulty mod"){
                TryBuy("difficultyMod", difP, tj);
            }
            else if (input == "e" || input == "exit"){
                System.Console.WriteLine("\"THANKS FOR STOPPING BY! BE SURE TO COME BACK NOW YOU HEAR!?\"");
                Console.ReadLine();
                System.Console.WriteLine("You lightly chuckle to yourself at the irony of Mr.Lao's last statement, loudly thank him for his services, and exit the shop.");
                Console.ReadLine();
                break;
            }
            static void TryBuy(string item, int cost, TJ tj){
                if(tj.coins >= cost){
                    if (item == "weapon"){
                        tj.weaponValue++;
                    }
                    else if (item == "armor"){
                        tj.armorValue++;
                    }
                    else if (item == "potion"){
                        tj.potion++;
                    }
                    else if (item == "difficultyMod"){
                        tj.mods++;
                    }
                tj.coins -= cost;
                }
                else{
                    System.Console.WriteLine("\"YOU DON'T HAVE ENOUGH GOLD FOR THAT SONNY AND I'M NOT RUNNING A CHARITY HERE! COME BACK LATER WHEN YOU HAVE ENOUGH!\"");
                    Console.ReadLine();
                }
            }
            
            }
        }
    }
