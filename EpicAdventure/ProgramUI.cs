using System.Dynamic;
using System.Runtime.ExceptionServices;
using System.Net.WebSockets;
using System;

public class ProgramUI {
    public static TJ currentPlayer = new TJ();
    
    bool continueToRun = true;
    
    public void Run(){
        while(currentPlayer.health > 0){
        RunMenu();
        Encounters.Boss1();
        Encounters.Valley();
        Encounters.RandomEncounter();
        Encounters.Emporium();
        Encounters.Boss4();
        Area.Area1();
        Encounters.RandomEncounter();
        Encounters.Emporium();
        Encounters.FinalBoss();
        }







    //     Encounters.RandomEncounter();
        
    //     while(continueToRun){
    //     Encounters.Boss1();
    //         if (ProgramUI.currentPlayer.health <= 0)
    //         continueToRun = false;

    //     Encounters.Valley(); // has dragonball
    //         if (ProgramUI.currentPlayer.health <= 0)
    //         continueToRun = false;
    //     RunMenu();

    //     Encounters.RandomEncounter();
    //         if (ProgramUI.currentPlayer.health <= 0)
    //         continueToRun = false;

    //     Encounters.Emporium();
    //         if (ProgramUI.currentPlayer.health <= 0)
    //         continueToRun = false;

    //     Encounters.QuietLake(); 
    //         if (ProgramUI.currentPlayer.health <= 0)
    //         continueToRun = false;

    //     Encounters.RandomEncounter();
    //         if (ProgramUI.currentPlayer.health <= 0)
    //         continueToRun = false;

    //     Encounters.Emporium();
    //         if (ProgramUI.currentPlayer.health <= 0)
    //         continueToRun = false;

    //     Encounters.Forest(); 
    //         if (ProgramUI.currentPlayer.health <= 0)
    //         continueToRun = false;

    //     Encounters.RandomEncounter();
    //         if (ProgramUI.currentPlayer.health <= 0)
    //         continueToRun = false;

    //     Encounters.Emporium();
    //         if (ProgramUI.currentPlayer.health <= 0)
    //         continueToRun = false;


    //     Encounters.MountainBase(); 
    //         if (ProgramUI.currentPlayer.health <= 0)
    //         continueToRun = false;
        
    //     Encounters.RandomEncounter();
    //         if (ProgramUI.currentPlayer.health <= 0)
    //         continueToRun = false;

    //     Encounters.Emporium();
    //         if (ProgramUI.currentPlayer.health <= 0)
    //         continueToRun = false;

    //     Encounters.Boss4();
    //         if (ProgramUI.currentPlayer.health <= 0)
    //         continueToRun = false;
        
    //     Encounters.Temple(); 
    //         if (ProgramUI.currentPlayer.health <= 0)
    //         continueToRun = false;

    //     Encounters.RandomEncounter();
    //         if (ProgramUI.currentPlayer.health <= 0)
    //         continueToRun = false;

    //     Encounters.Emporium();
    //         if (ProgramUI.currentPlayer.health <= 0)
    //         continueToRun = false;

    //     Encounters.FinalBoss();}
    //         if (ProgramUI.currentPlayer.health <= 0)
    //         continueToRun = false;

    //         //Win encounter
     }

    public void RunMenu() {
    bool selectionNeeded = true;

    Console.Clear();
System.Console.WriteLine("     _                             _           _ _    _______  _______");
System.Console.WriteLine("    | |                           | |         | | |  |__   __||__   __|");
System.Console.WriteLine("  __| |_ __ __ _  __ _  ___  _ __ | |__   __ _| | |     | |      | |");
System.Console.WriteLine(" / _` | '__/ _` |/ _` |/ _ `| '_ `| '_ ` / _` | | |     | |      | |");
System.Console.WriteLine("| (_| | | | (_| | (_| | (_) | | | | |_) | (_| | | |     | |   ___/ /");
System.Console.WriteLine(" `_,__|_|  `__,_|`__` |`___/|_| |_|_.__/ `__,_|_|_|     |_|  `____/");
System.Console.WriteLine("                  __/ /");
System.Console.WriteLine("                 `___/");
    Print("---------------Welcome to DragonBall TJ---------------\n" +
    "Press any key to embark on this tale for the ages!", 60);
    Console.ReadKey();
    Console.Clear();
    Print("You, TJ, the most powerful Sayain on the Dragon World,\n" +
    "have been sent by Master Marco to traverse these lands in search for the 7 Dragon Balls.\n" +
    "Youre not quite sure where to find them, or what they even do, but Master Marco made it seem urgent.\n" +
    "Before embarking on your quest, Master Marco gifted you his entire life savings to help you on your way!\n" +
    "You've had no luck this far, until one day...");
    Console.ReadKey();
    Console.Clear();
    Print("You wake up from an amazing nap atop a grassy knoll.");
    Print("\"Wow\" you think to yourself, \"That was great! I really need to do that more often!\"");
    Print("Wiping the sleep from your eyes you peer out across the valley below and something catches your eye...");
    Console.ReadKey();
    Print("\"Odd. Could that be? No surely it couldn't. Unless? ...\"");
    Console.ReadKey();

    while(selectionNeeded) {
    Print("Do you go to inspect the anomaly or lay back down for another nap?\n" + 
    "1. Charge!\n" +
    "2. Zzzzzz", 30);
    string selection = Console.ReadLine();
    if (selection == "1") {
    Console.Clear();
    Print("Uncertain yet determined, you tighten your gi, strap a Power Pole to your side along with your trusty Shield,\n" + 
    " and set your dreads in place before speeding down the hill towards your quarry.");
    selectionNeeded = false;
    } 
    else if (selection == "2") {
        Console.Clear();
        Print("You fall flat on your back, stretch out your arms and then weave your fingers behind your head.\n" +
        "Slowly drifting back to sleep wearing a grin from ear to ear.");
        Print("Whatever it was at the bottom of the hill couldn't have been THAT important...");
        Console.ReadKey();
        Print("All of a sudden, you hear a CRASH coming from the direction of the anomaly! ...");
        Console.ReadKey();
        Print("Frustrated, you exclaim \"I can't sleep with all that ruckus!\" and you reluctantly get up with a yawn to investigate further.");
        selectionNeeded = false;
    } 
    else {
        Print("Please input a valid option.");
        Console.ReadKey();
        Console.Clear();
    }
    }
    Console.ReadKey();
    Console.Clear();


}
    public static void Print(string text, int  textdelay = 40){
        foreach (char c in text){
            Console.Write(c);
            System.Threading.Thread.Sleep(textdelay);
        }
    System.Console.WriteLine();
    }  
}