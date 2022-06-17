using System.Net.Http.Headers;
using System;
public class Area {
        static Random rand = new Random();
    public static void Area1(){
        
        bool continueToRun = true;
        bool case1Visited = false;
        bool case2Visited = false;
        bool healUsed = false;
        
        while(continueToRun){

            Console.Clear();
            ProgramUI.Print("You come to a 3 way fork in the road. Which way do you go?\n" +
            "(N)orth\n" +
            "(E)ast\n" +
            "(W)est\n");
            string input = Console.ReadLine();

                if (input.ToLower() == "n" || input.ToLower() == "north"){
                    
                    bool case1ContinueToRun = true;
                    
                    while(case1ContinueToRun){
                        int jumpFail = rand.Next(1, 100);
                        Console.Clear();
                        ProgramUI.Print("You travel for about an hour until you come to a river with a dilapidated bridge.\n" +
                        "Do you try and cross it?\n" +
                        "1. Hell Yeah!\n" +
                        "2. Hell Nah!\n");
                        string caseInput1 = Console.ReadLine();
                        
                        if(caseInput1 == "1"){
                            if (jumpFail <= 75){
                                Console.Clear();
                                ProgramUI.Print("You only make it half way across when one of the wooden planks falls out from under you... \n" +
                                "You plummet to your doom and never found again!");
                                Console.ReadKey();
                                ProgramUI.Print("Just Kidding! You climb back to the top and try again, after taking 100 Damage, of course.");
                                Console.ReadKey();
                                ProgramUI.currentPlayer.health -= 100;
                            }
                            else {
                                Console.Clear();
                                ProgramUI.Print("After what felt like an eternity and with many close calls you finally manage to cross. \n" +
                                "Looking back now you're certain that this was a big shortcut and may very well be worth the risk.");
                                Console.ReadKey();
                                continueToRun = false;
                                break;
                            }
                        }
                        else if(caseInput1 == "2") {
                            ProgramUI.Print("You turn back the way you came. Kicking yourself all the while trying to decide " + 
                            "if you really could have made it across.");
                            case1Visited = true;
                            case1ContinueToRun = false;
                            Console.ReadKey();
                        }
                        else{
                            ProgramUI.Print("Come on now. You gotta pick.");
                            Console.ReadKey();
                        }
                    }
                }
                

                else if (input.ToLower() == "e" || input.ToLower() == "east"){
                
                bool case2ContinueToRun = true;
                
                    while(case2ContinueToRun){
                        
                        Console.Clear();
                        ProgramUI.Print("You travel down the road for about an hour before it sharply turns to the right. Do you continue?\n" +
                        "1. Sure why not.\n" +
                        "2. Eh. Think I'll turn back.\n");
                        string caseInput2 = Console.ReadLine();
                        Console.Clear();
                        switch(caseInput2){
                            case "1":
                            
                                if(!healUsed) {
                                int foodHeal = (2 * ProgramUI.currentPlayer.mods) + 1;
                                ProgramUI.Print("You travel for another hour until you come across a basket on the ground.");
                                Console.ReadKey();
                                ProgramUI.Print("You pop the lid open to find a full lunch inside!");
                                Console.ReadKey();
                                ProgramUI.Print("Also inside is a note that reads, \"This is a small gift from Granny Giro who lives up on the mountain side.\"\n" +
                                "\"Welcome to any and all travelers that need a good meal to fill their bellies. Please eat and enjoy to your heart's content.\"\n" +
                                "\"P.S. Please leave the plates, silverware, and toiletries when you are finished.\"\n" +
                                "\"Your Guardian,\"\n" +
                                "\"Granny Giro\"");
                                Console.ReadKey();
                                ProgramUI.Print("After polishing the last of Granny Giro's picnic basket you feel full and rejuvenated.");
                                ProgramUI.Print($"You gain {foodHeal} health");
                                healUsed = true;
                                Console.ReadKey();
                                ProgramUI.Print("You pick up your belongings and continue on the road north.");
                                Console.ReadKey();
                                Console.Clear();
                                ProgramUI.Print("After the meal you must have been in a food haze, or the route you took was a circle because you end up back where you started.");
                                Console.ReadKey();
                                case2Visited = true;
                                case2ContinueToRun = false;
                            } else{
                                ProgramUI.Print("You travel for another hour until you come across Granny Giro's picnic basket again.");
                                Console.ReadKey();
                                ProgramUI.Print("Making a small whish to yourself you slowly pry the lid off the basket but " + 
                                "find only the remains from your previous meal");
                                Console.ReadKey();
                                ProgramUI.Print("\"Too bad.\" You think to yourself. \"That would have been a great exploit if I could just heal myself over and over again.\"");
                                Console.ReadKey();
                                ProgramUI.Print("\"Maybe next time.\" is your final thought before continuing on the road north.");
                                Console.ReadKey();
                                ProgramUI.Print("Aaaaaand find yourself back at the beginning like last time. You're not great with directions are you?");
                                Console.ReadKey();
                                case2Visited = true;
                                case2ContinueToRun = false;
                            }
                            break;
                            
                            case "2":
                            ProgramUI.Print("You head back down the road you came. Wondering what there could have been down that way.");
                            case2ContinueToRun = false;
                            break;
                            default:
                            ProgramUI.Print("Come on now You gotta pick");
                            Console.ReadKey();
                            break;
                        };
                    }
                }
                else if (input.ToLower() == "w" || input.ToLower() == "west"){
                    bool case3ContinueToRun = true;

                    while(case3ContinueToRun){
                        if(case1Visited == true && case2Visited == true){
                            Console.Clear();
                            ProgramUI.Print("You travel down the road and you realize that this had to be the easiest way to get where you were going by far.");
                            Console.ReadKey();
                            ProgramUI.Print("That is ok though because somehow you know that there wasn't anything else to explore in this area.");
                            Console.ReadKey();
                            ProgramUI.Print("You hum a gentle tune as you saunter down the road towards a new place.");
                            continueToRun = false;
                            break;
                        } else {
                            Console.Clear();
                            ProgramUI.Print("You travel down the road and you realize that this had to be the easiest way to get where you were going by far.");
                            Console.ReadKey();
                            ProgramUI.Print("It almost feels like the developers started running short on time couldn't fully build out each area.");
                            Console.ReadKey();
                            ProgramUI.Print("What do you want to do? Continue on down the road or turn back to see what gems you may have missed?");
                            ProgramUI.Print("1. Turn back and respect the dev's hard work.");
                            ProgramUI.Print("2. Nah. Keep going. It probably wasn't anything to special anyway.");

                            string case3Input = Console.ReadLine();

                            if (case3Input == "1"){
                                Console.Clear();
                                ProgramUI.Print("Good choice! It may not feel like it now but you've made the right decision.");
                                case3ContinueToRun = false;
                                break;
                            }
                            else if (case3Input == "2"){
                                Console.Clear();
                                ProgramUI.Print("Really?? Really wanna go that route, ay?");
                                Console.ReadKey();
                                ProgramUI.Print("Ok. Fine. You can certainly do that but you've just increased the difficulty by 5x!!!");
                                Console.ReadKey();
                                ProgramUI.Print("You fool! You thought you could skip through content unnoticed! THINK AGAIN SIR!");
                                Console.ReadKey();
                                ProgramUI.Print("MWHAHAHAHAHAHAHA!!!");
                                Console.ReadKey();
                                ProgramUI.currentPlayer.mods *= 5;
                                case3ContinueToRun = false;
                                break;
                            }
                            else {
                                ProgramUI.Print("Come on now. You gotta pick.");
                                Console.ReadKey();
                                break;
                            }
                        }    
                    }
                }
                else {
                    ProgramUI.Print("Come on now. You gotta pick.");
                    break;
                }
            }
        }
    }
