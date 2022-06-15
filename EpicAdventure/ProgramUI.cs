using System.Dynamic;
using System.Runtime.ExceptionServices;
using System.Net.WebSockets;
using System;

public class ProgramUI {
    public static TJ currentPlayer = new TJ();
    public void Run(){
        var location = new Location();
        bool continueToRun = true;
        RunMenu();
        
        Encounters.Boss1();
        if (ProgramUI.currentPlayer.health <= 0){
            continueToRun = false;
        }
        while(continueToRun){
            var result = location.Menu();

            Encounters.RandomEncounter();

            Encounters.Boss2();

            Encounters.Boss3();

            Encounters.Boss4();

            Encounters.FinalBoss();}
            // Other Encounters
    }

    public void RunMenu() {
    bool selectionNeeded = true;

    Console.Clear();
    Console.WriteLine("---------------Welcome to DragonBall TJ---------------\n" +
    "Press any key to embark on this tale for the ages!");
    Console.ReadKey();
    Console.Clear();
    Console.WriteLine("You wake up from an amazing nap atop a grassy knoll.");
    Console.ReadKey();
    Console.WriteLine("\"Wow\" you think to yourself, \"That was great! I really need to do that more often!\"");
    Console.ReadKey();
    Console.WriteLine("Wiping the sleep from your eyes you peer out across the valley below and something catches your eye.");
    Console.ReadKey();
    Console.WriteLine("\"Odd. Could that be? No surely it couldn't. Unless?\"");
    Console.ReadKey();

    while(selectionNeeded) {
    Console.WriteLine("Do you go to inspect the anomaly or lay back down for another nap?\n" +
    "1. Charge!\n" +
    "2. Zzzzzz");
    string selection = Console.ReadLine();
    if (selection == "1") {
    
    Console.WriteLine("Uncertain yet determined, you tighten your gi, strap a Power Pole to your side," + 
    "and set your dreads in place before speeding down the hill towards your quarry.");
    selectionNeeded = false;
    } 
    else if (selection == "2") {
        Console.WriteLine("You fall flat on your back, stretch out your arms and then weave your fingers behind your head. Slowly drifting back to sleep wearing a grin from ear to ear.");
        Console.ReadKey();
        Console.WriteLine("Whatever it was at the bottom of the hill couldn't have been THAT important...");
        Console.ReadKey();
        Console.WriteLine("All of a sudden, you hear a CRASH coming from the direction of the anomaly!");
        Console.ReadKey();
        Console.WriteLine("Frustrated, you exclaim \"I can't sleep with all that ruckus!\" and you reluctantly get up with a yawn to investigate further.");
        selectionNeeded = false;
    } 
    else {
        Console.WriteLine("Please input a valid option.");
        Console.ReadKey();
        Console.Clear();
    }
    }
    Console.ReadKey();
    Console.Clear();
}
    
        }
