using System;
public class Encounters
    {
        static Random rand = new Random(DateTime.Now.Millisecond);

        
        public static void RandomEncounter() {
            int db = 1;
            Console.Clear();
            Print("While exploring you hear some rustling and glance behind you to see a flick of movement.");
            Console.ReadKey();
            Print("\"Come on out so that we can be done with this! I have Dragon Balls to collect!\" you taunt in the direction of the noise.");
            Console.ReadKey();
            Print($"After a moment of deliberation, a figure emerges from the shadows and charges for you head on!");
            Console.ReadKey();
            Combat( true, "", 0, 0);
            ProgramUI.currentPlayer.dragonball += db;
            Console.ReadKey();
            Print($"The monster explodes into a bajillion pieces, splattering it viscera in all directions.\n"+
            $"Some lands on you and you begin violently dry heaving.");
            Console.ReadKey();
            Console.Clear();
            Print("You found a DRAGON BALL!!!");
System.Console.WriteLine("⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢀⣀⣤⣤⣤⣤⣀⡀⠀⠀⠀⠀⠀⠀⠀");
System.Console.WriteLine("⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣀⣴⠾⠛⠉⠉⠁⠈⠉⠉⠛⠷⣦⣀⠀⠀⠀⠀");
System.Console.WriteLine("⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢀⣼⠟⠁⠀⠀⠀⠀⢰⣿⣿⣿⣿⣶⣌⠻⣧⡀⠀⠀");
System.Console.WriteLine("⠀⠀⠀⠀⠀⠀⠀⠀⠀⢀⣾⠃⠀⠀⠀⠀⠀⠀⠀⠉⠙⢿⣿⣿⣿⣧⠘⣷⡀⠀");
System.Console.WriteLine("⠀⠀⠀⠀⠀⠀⠀⠀⠀⣸⡇⠀⠀⠀⠀⠀⠀⠀⣸⣆⠀⠀⢻⣿⣿⣿⡀⢸⣇⠀");
System.Console.WriteLine("⠀⣀⣀⣀⠀⠀⠀⠀⠀⣿⡇⠀⠀⠀⠀⠀⠈⣻⣿⣿⣟⠁⠈⣿⣿⣿⠃⢸⣿⠀");
System.Console.WriteLine("⠀⠉⠉⠙⠻⢶⣄⠀⠀⢸⡇⠀⠀⠀⠀⠀⠈⠉⢻⡟⠉⠀⠀⢿⣿⠟⠀⢸⡏⠀");
System.Console.WriteLine("⠀⢰⣿⣿⣦⡀⢻⣆⠀⠀⢿⡄⠀⠀⠀⠀⠀⠀⠈⠀⠀⠀⠀⠀⠀⠀⢠⡿⠁⠀");
System.Console.WriteLine("⠀⠀⠀⢹⣿⣷⠀⣿⡀⠀⠈⠻⣦⡀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢀⣴⠟⠁⠀⠀");
System.Console.WriteLine("⠀⠀⠀⠘⠿⠛⢀⣿⠀⠀⠀⠀⠈⠻⢶⣤⣀⣀⣀⣀⣀⣠⣤⡶⠟⠁⠀⠀⠀⠀");
System.Console.WriteLine("⠀⠀⠀⠀⠀⣠⡾⠃⠀⣠⣴⣶⣦⣄⠀⠀⠉⠉⠛⠛⠉⠉⠀⠀⠀⠀⠀⠀⠀⠀");
System.Console.WriteLine("⠀⣤⣴⡶⠟⠋⠀⢀⣾⠋⠀⢤⣄⠙⣷⡀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀");
System.Console.WriteLine("⠀⠀⠀⠀⠀⠀⠀⢸⣯⠀⠀⠀⢿⠀⣸⡇⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀");
System.Console.WriteLine("⠀⠀⠀⠀⠀⠀⠀⠀⠻⣦⣄⣀⣠⣴⠟⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀");
System.Console.WriteLine("⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠉⠉⠉⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀");
            Console.ReadKey();
            Console.Clear();
        }

    //Encounters
    public static void Boss1() {
        int db = 1;
            Print("As you approach you quickly realize you were right to come here.\n" +
            "The thing you saw is Android 13! The muscle bound, yet polite menace with a baseball cap made by the evil Dr.Gero!");
            Console.ReadKey();
            Print("You square your jaw and set your gaze directly at Android 13. Daring him to take you on!");
            Console.ReadKey();
            Combat(false,"Android 13", 4, 8);
            ProgramUI.currentPlayer.dragonball += db;
            Console.ReadKey();
            Print("\"AGGHH\" Android 13 exclaims as you deliver the final blow squarely on his polite visage!");
             Console.ReadKey();
             Print("As he sputters the last of his motor oil and begins to boot down he asks, \"How? *cough* How could this be?\"");
            Console.ReadKey();
            Print("\"Because don't you know, Jeeves, that politeness doesn't equal rightness...");
            Console.ReadKey();
            Print("After an awkward and uncomfortable pause Android 13 replies,\"Bah Dum CHSH...\"");
            Console.ReadKey();
            Print("\"Hey\" you shout back \"It sounded a lot better in my head, ok?!");
            Console.ReadKey();
            Console.Clear();
            Print("Ego slightly dampened you gather your things and continue on down the road to the next area.");
            Console.ReadKey();
            Console.Clear();
            Print("You found a DRAGON BALL!!!");
System.Console.WriteLine("⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢀⣀⣤⣤⣤⣤⣀⡀⠀⠀⠀⠀⠀⠀⠀");
System.Console.WriteLine("⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣀⣴⠾⠛⠉⠉⠁⠈⠉⠉⠛⠷⣦⣀⠀⠀⠀⠀");
System.Console.WriteLine("⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢀⣼⠟⠁⠀⠀⠀⠀⢰⣿⣿⣿⣿⣶⣌⠻⣧⡀⠀⠀");
System.Console.WriteLine("⠀⠀⠀⠀⠀⠀⠀⠀⠀⢀⣾⠃⠀⠀⠀⠀⠀⠀⠀⠉⠙⢿⣿⣿⣿⣧⠘⣷⡀⠀");
System.Console.WriteLine("⠀⠀⠀⠀⠀⠀⠀⠀⠀⣸⡇⠀⠀⠀⠀⠀⠀⠀⣸⣆⠀⠀⢻⣿⣿⣿⡀⢸⣇⠀");
System.Console.WriteLine("⠀⣀⣀⣀⠀⠀⠀⠀⠀⣿⡇⠀⠀⠀⠀⠀⠈⣻⣿⣿⣟⠁⠈⣿⣿⣿⠃⢸⣿⠀");
System.Console.WriteLine("⠀⠉⠉⠙⠻⢶⣄⠀⠀⢸⡇⠀⠀⠀⠀⠀⠈⠉⢻⡟⠉⠀⠀⢿⣿⠟⠀⢸⡏⠀");
System.Console.WriteLine("⠀⢰⣿⣿⣦⡀⢻⣆⠀⠀⢿⡄⠀⠀⠀⠀⠀⠀⠈⠀⠀⠀⠀⠀⠀⠀⢠⡿⠁⠀");
System.Console.WriteLine("⠀⠀⠀⢹⣿⣷⠀⣿⡀⠀⠈⠻⣦⡀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢀⣴⠟⠁⠀⠀");
System.Console.WriteLine("⠀⠀⠀⠘⠿⠛⢀⣿⠀⠀⠀⠀⠈⠻⢶⣤⣀⣀⣀⣀⣀⣠⣤⡶⠟⠁⠀⠀⠀⠀");
System.Console.WriteLine("⠀⠀⠀⠀⠀⣠⡾⠃⠀⣠⣴⣶⣦⣄⠀⠀⠉⠉⠛⠛⠉⠉⠀⠀⠀⠀⠀⠀⠀⠀");
System.Console.WriteLine("⠀⣤⣴⡶⠟⠋⠀⢀⣾⠋⠀⢤⣄⠙⣷⡀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀");
System.Console.WriteLine("⠀⠀⠀⠀⠀⠀⠀⢸⣯⠀⠀⠀⢿⠀⣸⡇⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀");
System.Console.WriteLine("⠀⠀⠀⠀⠀⠀⠀⠀⠻⣦⣄⣀⣠⣴⠟⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀");
System.Console.WriteLine("⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠉⠉⠉⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀");
            Console.ReadKey();
            Console.Clear();
        }

        // public static void Boss2() {
        //     Print("Looking into the distance, you see something coming towards you at great speed.");
        //     Print($"\"A bird?\" you think... \"Maybe a plane?\"");
        //     Print("You quickly realize its another Android heading your way");
        //     Console.ReadKey();
        //     Print($"You swoop to the left, dodging his attack. \"Are we really going to do this?\" you ask, obviously annoyed.");
        //     Print($"As he's gathering his balance he lets out a guttural scream \"Fight me and PERISH!\"");
        //     Console.ReadKey();
        //     Combat(false, "Android 15", 8, 16);
        //     Console.ReadKey();
        //     //boss defeat text
        //     Console.ReadKey();
        //     Console.Clear();
        // }
        // public static void Boss3() {
        //     Print("You round a bend to find a menacing figure standing in the road. Gaze firmly fixPrint.", 60);
        //     Console.ReadKey();
        //     Print("Almost as if it were expecting you...a shiver runs down your spine as you cautiously approach.", 60);
        //     Console.ReadKey();
        //     Print("\"My apologies, Nobel TJ, but I'm afraid that your quest ends here. With me.\" the figure says with a jaunty," + 
        //     "well-spoken voice laced with a nearly imperceptible hint of malice. Almost.", 60);
        //     Console.ReadKey();
        //     Print("After hearing his voice and walking more closely you recognize the figure to be none other than Android 17. The Gentleman Android." +
        //     "However, all that you've heard about Android 17 is that he is only a gentleman in name and quite deadly in a fight.", 60);
        //     Console.ReadKey();
        //     Print("Giving him no more time for pleasantries you charge head long! Screaming \"ERAHHHHHHHH\" as if to mock his propriety!", 60);
        //     Console.ReadKey();
        //     Print("The time for words has ended. Now we speak through our weapons!", 60);
        //     Combat(false, "Android 17", 9, 16); //name, attack value, health.
        //     Print("\"AGGHH\" Android 17 exclaims as you deliver the final blow squarely on his polite face!", 60);
        //     Console.ReadKey();
        //     Print("As he sputters the last of his motor oil and begins to boot down he asks, \"How? *cough How could this be?", 60);
        //     Console.ReadKey();
        //     Print("\"Because don't you know, Jeeves, that politeness doesn't equal rightness...", 60);
        //     Console.ReadKey();
        //     Print("After an awkward and uncomfortable pause Android 17 replies,\"Remarkable. I didn't think that I could have been more ashamed of being bested" +
        //     "by you yet I am proven a fool again.\"", 60);
        //     Console.ReadKey();
        //     Print("\"Hey\" you shout back \"It sounded a lot better in my head ok!", 60);
        //     Console.ReadKey();
        //     Print("Ego slightly dampened you gather your things and continue on down the road to the next area.", 60);
        //     Console.ReadKey();
        // }
        public static void Boss4() {
            int db = 1;
            Console.Clear();
            Print("While reflecting on the past adventures for the day you find a nice shaded tree and set down for a brief rest.");
            Console.ReadKey();
            Print("You close your eyes and slowly drift off. You think to yourself, \"I wonder how much longer it will be before I\n" +
            "find a lead on the next Dragon Ball.");
            Console.ReadKey();
            Print("Uncertain how much time has passed you awaken suddenly and open your eyes just in time to see a fist hurdling towards your face!");
            Console.ReadKey();
            Print("Like lightening you duck in roll as the impact from the fist hitting the ground sends you flying out \n" + 
            "20 feet from your camping spot.");
            Console.ReadKey();
            Print("After landing hard you spring to your feet and look to see a bald man with white mustache sprinting towards you.");
            Console.ReadKey();
            Print("There is no mistaking it. This is no man. This is Android 20, better known as the evil Dr.Gero in the flesh. So to speak.");
            Console.ReadKey();
            Print("\"You're a fast one aren't you?!\" he taunts as you dodge a second attack.");
            Console.ReadKey();
            Print("\"Fast enough to send all your other maniacal android minions to the scrapyard!\" you taunt back.");
            Console.ReadKey();
            Print("\"I can see now where their evil streak comes from. Must run in the family. HA!\"");
            Console.ReadKey();
            Print("You can tell your last comment ignited something in him as he raises both arms into the air and slams them down\n" + 
            "hard onto the ground!");
            Console.ReadKey();
            Print("The impact is like an earthquake and could be felt from miles around. \n" +
            "You, being quick, jumped into the air before the shockwave could reach.");
            Console.ReadKey();
            Print("As the dust settles you land in the crater made by this monster.");
            Console.ReadKey();
            Print("The battlefield is set.");
            Console.Clear();
            Console.ReadKey();
            Print("You roll up your sleeves.");
            Console.ReadKey();
            Print("Pump both fists.");
            Console.ReadKey();
            Print("And plant your feet.");
            Console.ReadKey();
            Print("Staring down Dr.Gero in the eye. You're ready. And he's about to regret waking you up.");
            Console.ReadKey();
            Combat(false, "Dr.Gero / Android 20", 27, 16);
            ProgramUI.currentPlayer.dragonball += db;
            Console.Clear();
            Print("At the center of the android-made crater lays Dr.Gero.");
            Console.ReadKey();
            Print("The force of your final blow laid him out flat to the ground and shut him down without any last words.");
            Console.ReadKey();
            Print("Battered and bruised, you stand now favoring one leg, leering over this construct of destruction.");
            Console.ReadKey();
            Print("Grabbing an injured arm you take a breath and say,\"And that is what happens to people who \n" +
            "wake me up from a nap!\"");
            Console.ReadKey();
            Print("\"Twice!\"");
            Console.ReadKey();
            Print("\"IN ONE DAY!\"");
            Console.ReadKey();
            Console.Clear();
            Print("You found a DRAGON BALL!!!");
System.Console.WriteLine("⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢀⣀⣤⣤⣤⣤⣀⡀⠀⠀⠀⠀⠀⠀⠀");
System.Console.WriteLine("⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣀⣴⠾⠛⠉⠉⠁⠈⠉⠉⠛⠷⣦⣀⠀⠀⠀⠀");
System.Console.WriteLine("⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢀⣼⠟⠁⠀⠀⠀⠀⢰⣿⣿⣿⣿⣶⣌⠻⣧⡀⠀⠀");
System.Console.WriteLine("⠀⠀⠀⠀⠀⠀⠀⠀⠀⢀⣾⠃⠀⠀⠀⠀⠀⠀⠀⠉⠙⢿⣿⣿⣿⣧⠘⣷⡀⠀");
System.Console.WriteLine("⠀⠀⠀⠀⠀⠀⠀⠀⠀⣸⡇⠀⠀⠀⠀⠀⠀⠀⣸⣆⠀⠀⢻⣿⣿⣿⡀⢸⣇⠀");
System.Console.WriteLine("⠀⣀⣀⣀⠀⠀⠀⠀⠀⣿⡇⠀⠀⠀⠀⠀⠈⣻⣿⣿⣟⠁⠈⣿⣿⣿⠃⢸⣿⠀");
System.Console.WriteLine("⠀⠉⠉⠙⠻⢶⣄⠀⠀⢸⡇⠀⠀⠀⠀⠀⠈⠉⢻⡟⠉⠀⠀⢿⣿⠟⠀⢸⡏⠀");
System.Console.WriteLine("⠀⢰⣿⣿⣦⡀⢻⣆⠀⠀⢿⡄⠀⠀⠀⠀⠀⠀⠈⠀⠀⠀⠀⠀⠀⠀⢠⡿⠁⠀");
System.Console.WriteLine("⠀⠀⠀⢹⣿⣷⠀⣿⡀⠀⠈⠻⣦⡀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢀⣴⠟⠁⠀⠀");
System.Console.WriteLine("⠀⠀⠀⠘⠿⠛⢀⣿⠀⠀⠀⠀⠈⠻⢶⣤⣀⣀⣀⣀⣀⣠⣤⡶⠟⠁⠀⠀⠀⠀");
System.Console.WriteLine("⠀⠀⠀⠀⠀⣠⡾⠃⠀⣠⣴⣶⣦⣄⠀⠀⠉⠉⠛⠛⠉⠉⠀⠀⠀⠀⠀⠀⠀⠀");
System.Console.WriteLine("⠀⣤⣴⡶⠟⠋⠀⢀⣾⠋⠀⢤⣄⠙⣷⡀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀");
System.Console.WriteLine("⠀⠀⠀⠀⠀⠀⠀⢸⣯⠀⠀⠀⢿⠀⣸⡇⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀");
System.Console.WriteLine("⠀⠀⠀⠀⠀⠀⠀⠀⠻⣦⣄⣀⣠⣴⠟⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀");
System.Console.WriteLine("⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠉⠉⠉⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀");
            Console.ReadKey();
            Console.Clear();
            Print("Wincing from the effort of yelling you limp up and out of the crater. Heading for your next target.");
            Console.ReadKey();
            Console.Clear();
}
        
        
        public static void FinalBoss() {
            int db = 2;
            Console.Clear();
            Print("You hear a sonic boom. Look up and see something moving like a fall star towards you.");
            Console.ReadKey();
            Print("It lands with a crash directly in front of you kicking up dust and debris from the impact.");
            Console.ReadKey();
            Print("After the haze settles a figure emerges and calls to you. \"So,\" he says in a cocky voice, \"you really think that you can \n" + 
            "take my ballz just like that, eh?!\"");
            Console.ReadKey();
            Console.Clear();
System.Console.WriteLine("⣿⣽⡁⠈⢻⣿⣯⢹⣿⣿⣿⣿⡏⣹⣿⠿⣿⣿⣿⡅⢻⣿⣿⣿⣿⣿⠉⣿⣿⣿⡏⠁⣽⣿⣿⣿⣿⠟⣡⣿⣿⣿⣿⢿⣿⣿⣿⣿⣿⠋");
System.Console.WriteLine("⠘⣿⡇⢠⠘⣿⣿⣿⣿⣿⣿⠿⠋⠁⠀⠀⠙⣿⣿⡇⢸⣿⣿⣿⣿⡏⣸⣿⣿⣿⠀⣸⣿⣿⣿⣿⠗⠚⠛⠻⢿⣿⣳⣿⣿⣿⣿⣿⠃⠀");
System.Console.WriteLine("⡆⠘⣿⢸⡄⢻⣿⣿⣿⡟⠁⠀⠀⠀⠀⠀⠀⠈⢿⣇⢸⣿⣿⢿⣿⣁⣿⣿⣿⠇⢀⣿⣿⡿⠋⠀⠀⠀⠀⠀⠀⠙⠻⣿⣿⣿⣿⠏⠀⣼");
System.Console.WriteLine("⣇⢸⡹⡞⣿⡀⣿⣽⠏⠀⠀⠀⠀⠀⠀⠀⠀⠀⠈⢿⣼⣿⣿⢸⣿⣿⣿⣿⡟⠀⣾⣿⠛⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠈⠻⣿⠏⠀⣼⣿");
System.Console.WriteLine("⢹⡆⢧⠁⣿⣧⠸⡏⢠⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠈⢿⣿⡏⢸⣿⣿⣿⣿⡇⣸⡿⠁⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢹⠀⣸⣿⣿");
System.Console.WriteLine("⣄⢷⠘⣆⣸⣿⣆⡇⡇⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠈⢿⡇⠸⣿⣿⣿⣿⡴⠋⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢸⣴⣿⣿⠟");
System.Console.WriteLine("⣯⣿⣇⣸⠉⢻⣿⣷⡇⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠘⣷⠀⣿⣿⣿⠟⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⡜⠀⠀⢸⣿⡿⢋⣾");
System.Console.WriteLine("⣝⢿⣿⡏⣾⣦⣻⠋⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠙⡤⣿⣿⠏⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢰⡇⠀⠀⣾⢟⣴⣿⣿");
System.Console.WriteLine("⣟⣧⡙⣷⠏⣠⣇⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢹⣿⠏⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢸⣄⣴⣶⣳⣿⣿⢟⣩");
System.Console.WriteLine("⠈⢿⣿⣿⢸⡋⠙⢦⣄⠀⠀⠀⠀⠀⠀⠀⠀⣀⠀⠀⠀⠀⠀⠀⠉⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠘⣿⣿⣿⡿⢋⡕⠻⣄");
System.Console.WriteLine("⠀⠀⠹⣿⡄⢳⠉⣽⢿⠙⢲⣄⡀⠀⠀⠀⠀⠈⠳⣦⡀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣀⠤⠀⠀⠀⠀⠀⠀⠀⠀⢀⣿⣿⠏⢠⠋⠉⡷⠀");
System.Console.WriteLine("⠀⠀⠀⠈⢻⣄⠙⢿⣿⡇⠀⣧⠉⠲⢄⡀⠀⠀⠀⠈⠻⣄⠀⠀⠀⠀⢀⣠⣶⠞⠋⠀⠀⠀⠀⠀⠀⢀⣀⣠⠤⠞⢠⠋⢀⣈⣉⣠⠃⢀");
System.Console.WriteLine("⠉⠛⠿⣿⣿⣿⣷⣄⠀⢻⠀⠘⣆⠀⠀⢿⠲⣄⡀⠀⠀⠈⠢⡀⣀⡴⠟⠋⠀⠀⠀⠀⢀⣀⣤⠖⠋⣹⠏⠀⠀⢠⠏⣀⣯⢤⣴⡃⢀⣾");
System.Console.WriteLine("⠀⠀⠀⡀⣉⣳⣯⡟⢷⣬⣧⠄⣈⣙⠲⠤⣱⣽⣛⣲⣄⠀⠀⣿⡇⠀⠀⠀⣀⣤⣴⣾⣯⣛⣁⠤⠞⠁⠀⠀⢠⡟⠛⠛⡷⠋⢀⣼⡋⠛");
System.Console.WriteLine("⠀⠀⠈⠉⠛⠛⠛⠿⢿⣟⣻⡄⠀⠈⠉⠛⠻⢾⣭⣛⠲⠛⠚⠛⠛⠒⠒⠛⠒⣋⣉⣭⣅⣤⠶⠶⠖⠒⠂⢀⡟⢀⣠⣴⣟⠚⢻⡻⠿⢷");
System.Console.WriteLine("⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣨⣷⠀⠀⠀⠀⠀⠀⠀⠉⠉⠛⢦⠀⠀⠀⠈⠉⠉⠉⠉⠀⠀⠀⠀⠀⠀⠀⠀⡜⠋⠉⢻⡿⣿⣷⣦⣽⣦⡀");
System.Console.WriteLine("⠀⠀⠀⠀⠀⢀⣠⣴⣶⡾⢫⡏⣇⠀⠀⠀⠀⠀⠀⠀⠀⢀⣾⠀⠀⠀⠀⠀⠀⠀⢀⡀⠀⠀⠀⠀⠀⠀⡜⡠⠀⠀⠀⢳⣀⠉⠛⠿⣟⡻");
System.Console.WriteLine("⠀⠀⢀⣤⣖⣫⣽⣿⢋⣠⣾⡇⠘⢦⣀⠀⠀⠀⠀⣀⠀⢮⣸⠀⣀⠀⠀⠀⠀⢘⣿⠃⠀⠀⠀⠀⢀⡞⡵⠁⠀⠀⣀⣴⣿⣷⣦⡀⢀⡽");
System.Console.WriteLine("⣠⣾⡿⠛⠉⣸⣿⣿⣿⣿⣿⡇⠀⠸⡿⣄⠀⠀⠀⠙⣦⣤⣽⣟⣥⢤⣤⣴⣶⡿⠁⠀⠀⠀⢀⡴⢋⡞⠁⣀⣴⣿⣿⣿⣿⣿⣿⡿⠋⠀");
System.Console.WriteLine("⠏⠁⠀⣀⣤⣏⣿⣿⣿⣿⣿⣷⣄⡀⠹⡌⠳⣄⠀⠀⠈⠙⠓⠒⠒⠚⠛⠋⠉⠀⢠⡀⢀⡴⠟⢠⣮⣴⣾⣿⣿⣿⣿⣿⣿⣿⣿⠤⣄⡀");
System.Console.WriteLine("⣴⠶⠟⠋⣹⢻⣿⣿⣿⣿⣿⣿⣿⣿⣦⣹⣄⠘⠳⣄⠀⠀⠀⠈⠉⠉⠁⠀⠀⠀⣸⠿⠋⣀⣴⠏⣵⣿⣿⣿⣿⣿⣿⣿⠟⠁⠈⠉⠒⠿");
System.Console.WriteLine("⠁⢀⣠⣤⣿⢸⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⡻⣶⣤⣬⣷⣄⡀⠀⠀⠀⠀⣠⡴⣞⣡⣴⣾⣿⠏⣼⣿⣿⣿⣿⣿⣿⡿⣷⣤⣄⣀⠀⠀⠀");
System.Console.WriteLine("⠿⠛⠉⢁⣧⠼⠿⢿⣿⣿⣿⣿⣿⣿⣿⣿⣷⣜⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣯⣾⣿⣿⣿⣿⣿⡿⠋⠀⠀⠈⠙⠛⠯⣖⡦");
System.Console.WriteLine("⠔⠒⢹⡁⠀⠀⠀⠈⠈⠻⣷⡀⠀⠀⠉⠙⠛⠿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⡿⠿⠿⠿⠿⠟⠛⣻⣿⠟⠛⠛⠓⠒⠦⠤⣤⣀⣀⠀⠀⡽");
System.Console.WriteLine("⣀⣤⡴⠚⠉⠉⢻⡆⠀⠀⢿⣿⣿⣿⣷⣶⣶⣤⣌⠻⣿⣿⣿⡿⠛⢋⣉⣀⣀⣤⣤⣤⣤⣤⡾⣏⣀⣠⠤⠤⠤⣄⣀⣀⠚⢋⠈⠉⠙⠳");

            Console.ReadKey();
            System.Console.WriteLine();
            Print("This is it. This is the last boss. This is serious stuff and you shouldn't... too late. You bust out laughing at Vegeta's Expense.");
            Console.ReadKey();
            Print("Face turing red after the realization hits him, Vegeta yells back, \"HEY! Stop it! I will be taken seriously!!");
            Console.ReadKey();
            Print("\"Mmmhmm. Sure I'm taking this very seriously.\" you reply in between fits of laughter.");
            Console.ReadKey();
            Print("\"Enough! Lets finish this so that you can be taught some proper respect!\"");
            Console.ReadKey();
            Print("Wiping the tears from your eyes and ignoring the stitch in your side you square up and turn to face your final challenge.");
            Combat(false, "Vegeta", 135, 128);
            ProgramUI.currentPlayer.dragonball += db;
            Print("\"NOOOOOOOO! Not my PRECIOUS DRAGON BAlLzZzZzz....\"");
            Console.ReadKey();
            Console.Clear();
            Print("You found a DRAGON BALL!!!");
System.Console.WriteLine("⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢀⣀⣤⣤⣤⣤⣀⡀⠀⠀⠀⠀⠀⠀⠀");
System.Console.WriteLine("⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣀⣴⠾⠛⠉⠉⠁⠈⠉⠉⠛⠷⣦⣀⠀⠀⠀⠀");
System.Console.WriteLine("⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢀⣼⠟⠁⠀⠀⠀⠀⢰⣿⣿⣿⣿⣶⣌⠻⣧⡀⠀⠀");
System.Console.WriteLine("⠀⠀⠀⠀⠀⠀⠀⠀⠀⢀⣾⠃⠀⠀⠀⠀⠀⠀⠀⠉⠙⢿⣿⣿⣿⣧⠘⣷⡀⠀");
System.Console.WriteLine("⠀⠀⠀⠀⠀⠀⠀⠀⠀⣸⡇⠀⠀⠀⠀⠀⠀⠀⣸⣆⠀⠀⢻⣿⣿⣿⡀⢸⣇⠀");
System.Console.WriteLine("⠀⣀⣀⣀⠀⠀⠀⠀⠀⣿⡇⠀⠀⠀⠀⠀⠈⣻⣿⣿⣟⠁⠈⣿⣿⣿⠃⢸⣿⠀");
System.Console.WriteLine("⠀⠉⠉⠙⠻⢶⣄⠀⠀⢸⡇⠀⠀⠀⠀⠀⠈⠉⢻⡟⠉⠀⠀⢿⣿⠟⠀⢸⡏⠀");
System.Console.WriteLine("⠀⢰⣿⣿⣦⡀⢻⣆⠀⠀⢿⡄⠀⠀⠀⠀⠀⠀⠈⠀⠀⠀⠀⠀⠀⠀⢠⡿⠁⠀");
System.Console.WriteLine("⠀⠀⠀⢹⣿⣷⠀⣿⡀⠀⠈⠻⣦⡀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢀⣴⠟⠁⠀⠀");
System.Console.WriteLine("⠀⠀⠀⠘⠿⠛⢀⣿⠀⠀⠀⠀⠈⠻⢶⣤⣀⣀⣀⣀⣀⣠⣤⡶⠟⠁⠀⠀⠀⠀");
System.Console.WriteLine("⠀⠀⠀⠀⠀⣠⡾⠃⠀⣠⣴⣶⣦⣄⠀⠀⠉⠉⠛⠛⠉⠉⠀⠀⠀⠀⠀⠀⠀⠀");
System.Console.WriteLine("⠀⣤⣴⡶⠟⠋⠀⢀⣾⠋⠀⢤⣄⠙⣷⡀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀");
System.Console.WriteLine("⠀⠀⠀⠀⠀⠀⠀⢸⣯⠀⠀⠀⢿⠀⣸⡇⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀");
System.Console.WriteLine("⠀⠀⠀⠀⠀⠀⠀⠀⠻⣦⣄⣀⣠⣴⠟⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀");
System.Console.WriteLine("⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠉⠉⠉⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀");
            Console.ReadKey();
            Print(" With Vegeta being defeated you glance to the sky and see a majestic dragon.");
            Console.ReadKey();
            Print("\"Greetings TJ! You have collected all of my ballz. As your reward for handling them with care and honor, \n" + 
            "I bestow but one wish. An all powerful wish that can grant you anything you desire.\"");
            Console.ReadKey();
            Print("\"Now then, what shall it be?!\"");
            System.Console.ReadLine();
            if (rand.Next() * 100 <= 33) {
            Print($"\"Hmmm. Rather odd request but I shall grant it none the less.\"");
            } else if (rand.Next() * 100 <= 66) {
            Print($"\"Well, thats not something I'd wish for, but so be it.\"");
            } else if (rand.Next() * 100 <= 99) {
            Print($"\"As you wish, weirdo!\"");
            }
            Console.ReadKey();
            Console.Clear();
            ProgramUI.Print("Thank you for playing");
            System.Console.WriteLine();
System.Console.WriteLine("     _                             _           _ _    _______  _______");
System.Console.WriteLine("    | |                           | |         | | |  |__   __||__   __|");
System.Console.WriteLine("  __| |_ __ __ _  __ _  ___  _ __ | |__   __ _| | |     | |      | |");
System.Console.WriteLine(" / _` | '__/ _` |/ _` |/ _ `| '_ `| '_ ` / _` | | |     | |      | |");
System.Console.WriteLine("| (_| | | | (_| | (_| | (_) | | | | |_) | (_| | | |     | |   ___/ /");
System.Console.WriteLine(" `_,__|_|  `__,_|`__` |`___/|_| |_|_.__/ `__,_|_|_|     |_|  `____/");
System.Console.WriteLine("                  __/ /");
System.Console.WriteLine("                 `___/");
            System.Console.WriteLine();
            ProgramUI.Print("Created by: Mary Beeson and Jalen Waggoner");
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
                    Console.Clear();
                    Print("You found a DRAGON BALL!!!");
System.Console.WriteLine("⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢀⣀⣤⣤⣤⣤⣀⡀⠀⠀⠀⠀⠀⠀⠀");
System.Console.WriteLine("⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣀⣴⠾⠛⠉⠉⠁⠈⠉⠉⠛⠷⣦⣀⠀⠀⠀⠀");
System.Console.WriteLine("⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢀⣼⠟⠁⠀⠀⠀⠀⢰⣿⣿⣿⣿⣶⣌⠻⣧⡀⠀⠀");
System.Console.WriteLine("⠀⠀⠀⠀⠀⠀⠀⠀⠀⢀⣾⠃⠀⠀⠀⠀⠀⠀⠀⠉⠙⢿⣿⣿⣿⣧⠘⣷⡀⠀");
System.Console.WriteLine("⠀⠀⠀⠀⠀⠀⠀⠀⠀⣸⡇⠀⠀⠀⠀⠀⠀⠀⣸⣆⠀⠀⢻⣿⣿⣿⡀⢸⣇⠀");
System.Console.WriteLine("⠀⣀⣀⣀⠀⠀⠀⠀⠀⣿⡇⠀⠀⠀⠀⠀⠈⣻⣿⣿⣟⠁⠈⣿⣿⣿⠃⢸⣿⠀");
System.Console.WriteLine("⠀⠉⠉⠙⠻⢶⣄⠀⠀⢸⡇⠀⠀⠀⠀⠀⠈⠉⢻⡟⠉⠀⠀⢿⣿⠟⠀⢸⡏⠀");
System.Console.WriteLine("⠀⢰⣿⣿⣦⡀⢻⣆⠀⠀⢿⡄⠀⠀⠀⠀⠀⠀⠈⠀⠀⠀⠀⠀⠀⠀⢠⡿⠁⠀");
System.Console.WriteLine("⠀⠀⠀⢹⣿⣷⠀⣿⡀⠀⠈⠻⣦⡀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢀⣴⠟⠁⠀⠀");
System.Console.WriteLine("⠀⠀⠀⠘⠿⠛⢀⣿⠀⠀⠀⠀⠈⠻⢶⣤⣀⣀⣀⣀⣀⣠⣤⡶⠟⠁⠀⠀⠀⠀");
System.Console.WriteLine("⠀⠀⠀⠀⠀⣠⡾⠃⠀⣠⣴⣶⣦⣄⠀⠀⠉⠉⠛⠛⠉⠉⠀⠀⠀⠀⠀⠀⠀⠀");
System.Console.WriteLine("⠀⣤⣴⡶⠟⠋⠀⢀⣾⠋⠀⢤⣄⠙⣷⡀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀");
System.Console.WriteLine("⠀⠀⠀⠀⠀⠀⠀⢸⣯⠀⠀⠀⢿⠀⣸⡇⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀");
System.Console.WriteLine("⠀⠀⠀⠀⠀⠀⠀⠀⠻⣦⣄⣀⣠⣴⠟⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀");
System.Console.WriteLine("⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠉⠉⠉⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀");
            Console.ReadKey();
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
                "You wonder again what is keeping you from peaceful rest, so you head to the east to investigate.\n" + 
                "You see a shop up ahead.");
                Print("Do you want to...\n" +
                "1. Enter the shop?\n" +
                "2. Keep searching for a quiet oasis to take your nap?");

                string selection = Console.ReadLine();

                if (selection == "1") {
                    Print("As you approach, the shouting gets louder.\n" +
                    "You see the sign above the door that reads \"Lao's Emporium\" and think \"This can't be so bad\"...");
                    Console.ReadKey();
                    Shop.LoadShop(ProgramUI.currentPlayer);
                    selectionNeeded = false;
                }
                else if (selection == "2") {
                    Print("You shake your head, \"No way I'm going there!\", and sulk as you make your way to a nearby lake\n" +
                    "\"Surely I should find it relaxing by the water.\"");
                    Console.ReadKey();
                    selectionNeeded = false;
                }
            }
        }

        /*public static void QuietLake() {
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
        }*/

        /*public static void Forest() {
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
        }*/

        /*public static void MountainBase() {
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
        }*/

        // public static void Temple() {
        //     bool selectionNeeded = true;
        //     int db = 1;

        //     while (selectionNeeded) {

        //     //Selections here

        //     string selection = Console.ReadLine();

        //     if (selection == "1") {
        //             Print("You found a flippin' Dragon Ball! Wow!");
        //             ProgramUI.currentPlayer.dragonball += db;
        //             selectionNeeded = false;
        //         } else if (selection == "2") {
        //             Print("You walk away,"); // leaving text
        //             selectionNeeded = false;
        //         }
        //     }
        // }

        // win encounter/ end credits?
        
        //Encounter Tools
        public static void Combat( bool random, string name, int power, int health) {

            string n = "";
            int p = 0;
            int h = 0;
            if (random){
                n = GetName();
                p = ProgramUI.currentPlayer.GetPower();
                h = ProgramUI.currentPlayer.GetHealth();
            }
            else{
            n = name;
            p = power;
            h = health;
            }
            while (h > 0 && ProgramUI.currentPlayer.health > 0) {
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
                    
                    Print($"You swipe horizontally with your Power Pole +{ProgramUI.currentPlayer.weaponValue}! Delivering a staggering blow that deals {attack} damage!", 15);
                    Print($"{n} follows up with their own attack!    You lose {damage} health!", 15);
                    ProgramUI.currentPlayer.health -= damage;
                    h -= attack;
                }
                else if(input.ToLower() == "d" || input.ToLower() == "defend"){
                    //Defend
                    int damage = (p/4) - ProgramUI.currentPlayer.armorValue;
                    if (damage < 0) {
                    damage = 0;}
                    int attack = rand.Next(0, ProgramUI.currentPlayer.weaponValue) + rand.Next(1,4);
                    
                    Print($"You puff up your chest while taunting with an outstretched hand. Ready and willing to accept the blow from {n}.", 15);
                    Print($"{n} lashes out in frustration! Dealing a glancing blow onto your Shield +{ProgramUI.currentPlayer.armorValue} while taking {attack} damage due to their sloppiness.    You lose {damage} health", 15);
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
                        Print("You desperately grab at your knapsack rummaging for a healing potion but you're all out!", 15);
                        Print($"Seizing the opportunity, {n} strikes hard and fast dealing {damage}!", 15);
                        if (damage < 0 ) {
                            damage = 0;}
                    } else {
                        Print("You reach into your knapsack and pop the cork off a healing potion. You chug it like a white claw and smash the glass on the ground.", 15);
                        int potionV = 50;
                        Print($"You gain {potionV} health", 15);
                        ProgramUI.currentPlayer.health += potionV;
                        Print($"{n} jabs forward!", 15);
                        int damage = (p / 2) - ProgramUI.currentPlayer.armorValue;
                        if (damage < 0 ) {
                            damage = 0;}
                        ProgramUI.currentPlayer.potion -= 1;
                        Print($"You loose {damage} health", 15);
                        }
                    }
                else if(input.ToLower() == "r" || input.ToLower() == "run"){

                    //Run
                    int damage = (p*10) - ProgramUI.currentPlayer.armorValue;
                    if (damage < 0){
                        damage = 0;}

                        Print("You try to run from combat, but are thwarted in your attempt!", 15);
                        Print("\"You can't run from me!\"", 15);
                        Print($"You've taken {damage} damage!", 15);
                        ProgramUI.currentPlayer.health -= damage;
                } else {
                    System.Console.WriteLine("Now is not the time to be indecisive! Hurry and choose!");
                    Console.ReadKey();
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
            