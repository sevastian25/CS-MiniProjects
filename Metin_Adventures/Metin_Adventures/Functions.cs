using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.IO;

namespace Metin_Adventures
{
    public class Functions
    {
        public static void checks()
        {
            //--------------------------------------------------------------------------Count EXP Start
            if (Program.Char_EXP_Current >= Program.Char_EXP_Full)
            {
                Program.Char_EXP_Current = Program.Char_EXP_Current - Program.Char_EXP_Full;
                Program.Char_Level++;
                Program.Char_EXP_Full = Math.Round(Program.Char_EXP_Full * 1.20);

                Program.Strength = Math.Round(Program.Strength * 1.20);
                Program.Health = Math.Round(Program.Health * 1.20);
                Program.Dexterity = Math.Round(Program.Dexterity * 1.20);
                Program.Inteligence = Math.Round(Program.Inteligence * 1.20);
                Program.Armour = Math.Round(Program.Armour * 1.20);

                //Set the character stats Start
                Program.Char_Melee_Damage = Math.Round(Program.Strength * 1.25);
                Program.Char_Dagger_Damage = Math.Round(Program.Dexterity * 1.25);
                Program.Char_Spell_Damage = Math.Round(Program.Inteligence * 1.25);

                Program.Char_Damage = Math.Round(Program.Char_Melee_Damage + Program.Char_Dagger_Damage + Program.Char_Spell_Damage);
                Program.Char_Defence = Math.Round(Program.Armour * 1.35);

                Program.Char_HP_Full = Math.Round((Program.Health * 0.25) + Program.Char_HP_Full);
                //Set the character stats End
            }
            //--------------------------------------------------------------------------Count EXP End

            //--------------------------------------------------------------------------HP Overload Check Start
            if (Program.Char_HP_Current > Program.Char_HP_Full)
            {
                Program.Char_HP_Current = Program.Char_HP_Full;
            }
            //--------------------------------------------------------------------------HP Overload Check End

            Enemys.enemy_dead = 0;

            //--------------------------------------------------------------------------Equipped Items Check Start
            Items.weaponsDamage();
            Items.armourDefence();
            //--------------------------------------------------------------------------Equipped Items Check End

        }



        public static void drawGUI()
        {
            Console.SetCursorPosition(0, 0);
            Console.WriteLine("_______________________________________________________________________________________________________________________");
            Console.SetCursorPosition(0, 1);
            Console.WriteLine(" Name: {0}", Program.Char_Name);
            Console.SetCursorPosition(24, 1);
            Console.WriteLine(" HP: {0}/{1}", Program.Char_HP_Current, Program.Char_HP_Full);
            Console.SetCursorPosition(46, 1);
            Console.WriteLine(" EXP: {0}/{1}", Program.Char_EXP_Current, Program.Char_EXP_Full);
            Console.SetCursorPosition(66, 1);
            Console.WriteLine(" Level: {0}", Program.Char_Level);
            Console.SetCursorPosition(86, 1);
            Console.WriteLine(" Current Location: {0}", Program.Char_Location);
            Console.WriteLine("_______________________________________________________________________________________________________________________");
            Items.weaponsDamage();
            Items.armourDefence();
        }


        public static void characterCreation()
        {
            //Character Creation
            Console.Clear();
            Console.SetCursorPosition(Console.WindowWidth / 2 - 16, Console.WindowHeight / 2 - 3);
            Console.Write("Welcome soldier, what is your name ?");
            Console.SetCursorPosition(Console.WindowWidth / 2 - 2, Console.WindowHeight / 2 - 2);
            Program.Char_Name = Console.ReadLine();

            do
            {
                Console.Clear();
                Console.SetCursorPosition(Console.WindowWidth / 2 - 25, Console.WindowHeight / 2 - 3);
                Console.Write("Good to see you {0}, now choose your class: ", Program.Char_Name);
                Console.SetCursorPosition(Console.WindowWidth / 2 - 8, Console.WindowHeight / 2 - 1);
                Console.Write("1. Ninja");
                Console.SetCursorPosition(Console.WindowWidth / 2 - 8, Console.WindowHeight / 2);
                Console.Write("2. Warrior");
                Console.SetCursorPosition(Console.WindowWidth / 2 - 8, Console.WindowHeight / 2 + 1);
                Console.Write("3. Guardian");
                Console.SetCursorPosition(Console.WindowWidth / 2 - 8, Console.WindowHeight / 2 + 2);
                Console.Write("4. Mage");
                Console.SetCursorPosition(Console.WindowWidth / 2 - 24, Console.WindowHeight / 2 + 4);
                Console.Write("Your Choice: "); Program.Char_Class = Console.ReadLine().ToUpper();

                switch (Program.Char_Class)
                {
                    case "1":
                    case "NINJA":
                        Console.Clear();
                        Program.Char_Class = "Ninja";
                        Program.Strength += 13;
                        Program.Health += 12;
                        Program.Dexterity += 20;
                        Program.Inteligence += 16;
                        Program.Armour += 14;

                        Program.Char_Damage += (Program.Strength + Program.Inteligence + Program.Dexterity);
                        Program.Char_Defence += Math.Round((Program.Armour * 1.75));
                        break;

                    case "2":
                    case "WARRIOR":
                        Console.Clear();
                        Program.Char_Class = "Warrior";
                        Program.Strength += 20;
                        Program.Health += 16;
                        Program.Dexterity += 11;
                        Program.Inteligence += 12;
                        Program.Armour += 16;

                        Program.Char_Damage += (Program.Strength + Program.Inteligence + Program.Dexterity);
                        Program.Char_Defence += Math.Round((Program.Armour * 1.75));
                        break;

                    case "3":
                    case "GUARDIAN":
                        Console.Clear();
                        Program.Char_Class = "Guardian";
                        Program.Strength += 14;
                        Program.Health += 19;
                        Program.Dexterity += 11;
                        Program.Inteligence += 11;
                        Program.Armour += 20;

                        Program.Char_Damage += (Program.Strength + Program.Inteligence + Program.Dexterity);
                        Program.Char_Defence += Math.Round((Program.Armour * 1.75));
                        break;

                    case "4":
                    case "MAGE":
                        Console.Clear();
                        Program.Char_Class = "Mage";
                        Program.Strength += 11;
                        Program.Health += 14;
                        Program.Dexterity += 17;
                        Program.Inteligence += 20;
                        Program.Armour += 13;

                        Program.Char_Damage += (Program.Strength + Program.Inteligence + Program.Dexterity);
                        Program.Char_Defence += Math.Round((Program.Armour * 1.75));
                        break;

                    case "SHADOW":
                        Console.Clear();
                        Program.Char_Class = "Shadow";
                        Program.Strength += 55;
                        Program.Health += 55;
                        Program.Dexterity += 55;
                        Program.Inteligence += 55;
                        Program.Armour += 55;

                        Program.Char_Damage += (Program.Strength + Program.Inteligence + Program.Dexterity);
                        Program.Char_Defence += Math.Round((Program.Armour * 1.75));
                        break;
                    default:
                        Console.SetCursorPosition(Console.WindowWidth / 2 - 24, Console.WindowHeight / 2 + 5);
                        Console.WriteLine("That is not an option !");
                        Program.Char_Class = null;
                        Console.ReadLine();
                        Console.Clear();
                        break;
                }
            } while (Program.Char_Class == null);
        }


        public static void Commands()
        {
            Console.SetCursorPosition(2, 28);
            Console.Write("Command: ");
            Program.Current_Command = Console.ReadLine().ToUpper();

            if (Program.Current_Command == "COMMANDS" || Program.Current_Command == "ACTIONS")
            {
                Console.SetCursorPosition(43, 12);
                Console.WriteLine("SLEEP - To regenerate HP");
                Console.SetCursorPosition(43, 13);
                Console.WriteLine("STATUS - To view your status");
                Console.SetCursorPosition(43, 14);
                Console.WriteLine("QUEST - To receive your next quest");
                Console.SetCursorPosition(43, 15);
                Console.WriteLine("INV - To view your inventory");
                Console.SetCursorPosition(43, 16);
                Console.WriteLine("FIGHT - Look for an enemy to fight");
                Console.SetCursorPosition(43, 17);
                Console.WriteLine("TRAVEL - Travel to your desired location");
                Console.SetCursorPosition(43, 18);
                Console.WriteLine("NPC - To talk to the local NPCs");
                Console.SetCursorPosition(43, 19);
                Console.WriteLine("FISH - To Start Fishing (Fishing Valley Only)");
                Console.SetCursorPosition(43, 20);
                Console.WriteLine("SAVE - To save your progress");

                Console.ReadLine();
            }

            if (Program.Current_Command == "SAVE")
            {
                SaveGame.saveGame();
            }

            if (Program.Current_Command == "SLEEP" || Program.Current_Command == "NAP" || Program.Current_Command == "REST")
            {
                Console.Clear();
                drawGUI();
                Console.SetCursorPosition(Console.WindowWidth / 2 - 20, Console.WindowHeight / 2 - 3);
                Console.Write("For how many hours do you want to rest ?");
                Console.SetCursorPosition(Console.WindowWidth / 2 - 2, Console.WindowHeight / 2 - 2);
                Program.Resting_Time = Convert.ToInt32(Console.ReadLine());
                if (Program.Resting_Time > 12)
                {
                    Console.SetCursorPosition(Console.WindowWidth / 2 - 22, Console.WindowHeight / 2 - 2);
                    Console.Write("You can not rest for more than 12 hours ...");
                    Thread.Sleep(4500);
                    Console.Clear();
                }
                else
                {
                    Console.Clear();
                    drawGUI();
                    Console.SetCursorPosition(Console.WindowWidth / 2 - 14, Console.WindowHeight / 2 - 3);
                    Console.Write("{0} is Resting...", Program.Char_Name);
                    Program.Resting_Time = (Program.Resting_Time * 3) * 1000;
                    System.Threading.Thread.Sleep(Program.Resting_Time);
                    Console.Clear();

                    Program.Char_HP_Current = Program.Char_HP_Current + Program.Resting_Time / 1000;
                }
            }

            if (Program.Current_Command == "FIGHT")
            {
                Console.Clear();
                drawGUI();
                int loadingLength = 5;
                Console.SetCursorPosition(Console.WindowWidth / 2 - 16, Console.WindowHeight / 2 - 3);
                Console.Write("Looking for an Enemy to fight...");

                for (int i = 0; i < loadingLength; i++)
                {
                    Console.Write(".");
                    Thread.Sleep(400);
                }
                Thread.Sleep(1500);


                Console.Clear();
                drawGUI();
                getEnemy();
            }

            if (Program.Current_Command == "STATUS" || Program.Current_Command == "STATS")
            {
                if (Program.Char_HP_Current < Program.Char_HP_Full * 0.60)
                {
                    Program.Char_Status = "You feel weak, refill your HP.";
                }
                if (Program.Char_HP_Current == Program.Char_EXP_Full)
                {
                    Program.Char_Status = "You are healthy";
                }

                Console.Clear();
                drawGUI();
                Console.SetCursorPosition(Console.WindowWidth / 2 - 16, Console.WindowHeight / 2 - 3);
                Console.Write("{0}", Program.Char_Status);
                Console.SetCursorPosition(43, 14);
                Console.Write("...::: Your Status points :::...");
                Console.SetCursorPosition(38, 16);
                Console.Write("Strength: {0}    Health: {1}    Dexterity: {2}", Program.Strength, Program.Health, Program.Dexterity);
                Console.SetCursorPosition(38, 17);
                Console.WriteLine("      Inteligence: {0}     Armour: {1}", Program.Inteligence, Program.Armour);
                Console.SetCursorPosition(47, 19);
                Console.WriteLine("Damage: {0}     Defence: {1}", Program.Char_Damage, Program.Char_Defence);
                Console.SetCursorPosition(50, 21);
                Console.WriteLine("Your Class: {0}", Program.Char_Class);
                Console.ReadLine();
                Console.Clear();
            }

            if (Program.Current_Command == "NPC" || Program.Current_Command == "NPCS")
            {
                if (Program.Char_Location == "Jinsoo" || Program.Char_Location == "Bakara")
                {
                    Console.Clear();
                    drawGUI();
                    Console.SetCursorPosition(43, 9);
                    Console.WriteLine("To which NPC would you like to speak to ?");
                    Console.SetCursorPosition(43, 11);
                    Console.WriteLine("[1] BlackSmith");
                    Console.SetCursorPosition(43, 12);
                    Console.WriteLine("[2] Dr. Shan");
                    Console.SetCursorPosition(43, 13);
                    Console.WriteLine("[3] Fisherman");
                    Console.SetCursorPosition(43, 15);
                    Console.Write("Choice: ");
                    string choice = Console.ReadLine().ToUpper();

                    switch(choice)
                    {
                        case "1": case "BLACKSMITH":
                            Console.Clear();
                            drawGUI();
                            Console.SetCursorPosition(43, 14);
                            NPCs.blackSmith();
                            break;

                        case "2": case "DR. SHAN":
                            break;

                        case "3": case "FISHERMAN":
                            Console.Clear();
                            drawGUI();
                            Console.SetCursorPosition(43, 14);
                            NPCs.fisherman();
                            break;
                    }

                }
            }


            if (Program.Current_Command == "GIVEITEM" && Program.Char_Class == "Shadow")
            {
                Console.Write("Enter the name of the item: ");
                string name = Console.ReadLine();

                for (int i = 0; i < Items.Inventory.Count; i++)
                {
                    if (Items.Inventory[i].Contains("Empty Slot"))
                    {
                        Items.Inventory[i] = name;
                        Console.WriteLine("You received {0}", name);
                        break;
                    }
                }
            }


            if (Program.Current_Command == "INVENTORY" || Program.Current_Command == "INV")
            {
                Console.Clear();
                drawGUI();

                Console.SetCursorPosition(26, 4);
                Console.WriteLine("Equipped Weapond: {0}  |  Equipped Armour: {1}", Program.Equipped_Weapon, Program.Equipped_Armour);
                int g = 6, h = 6, id = 0, i = 0;

                for (i = 0; i <= 9; i++)
                {
                    Console.SetCursorPosition(10, g++);
                    Console.WriteLine("ID: {0} | Item Name: {1}", id++, Items.Inventory[i]);
                    if (id != 9)
                    {
                        for (int x = id; x <= 9; x++)
                        {
                            Items.Inventory.Add("Empty Slot");
                        }
                    }
                }
                for (int j = i; j <= 19; j++)
                {
                    Console.SetCursorPosition(68, h++);
                    Console.WriteLine("ID: {0} | Item Name: {1}", id++, Items.Inventory[j]);
                    if (id != 19)
                    {
                        for (int x = id; x <= 19; x++)
                        {
                            Items.Inventory.Add("Empty Slot");
                        }
                    }
                }

                Console.SetCursorPosition(10, g + 1);
                Console.Write("D - Discard an Item | P - Use a Potion | X - Close Inventory");
                Console.SetCursorPosition(10, g + 2);
                Console.Write("Q - Equip a Weapon | W - Unequip Your Weapon | E - Equip Armour | R - Unequip Armour");
                Console.SetCursorPosition(10, g + 3);
                Console.Write("Action: ");
                string action = Console.ReadLine().ToUpper();

                switch(action)
                {
                    case "D":
                        Items.discardItem();
                        break;
                    case "P":
                        Items.usePotion();
                        break;
                    case "Q":
                        Items.equipWeapon();
                        break;
                    case "W":
                        Items.unequipWeapon();
                        break;
                    case "E":
                        Items.equipArmour();
                        break;
                    case "R":
                        Items.unequipArmour();
                        break;



                    case "X":
                        Console.Clear();
                        drawGUI();
                        break;
                }
            }

            if (Program.Current_Command == "TRAVEL")
            {
                Console.Clear();
                drawGUI();
                Console.SetCursorPosition(35, 9);
                Console.WriteLine("Where would you like to travel ?");
                Console.SetCursorPosition(35, 11);
                Console.WriteLine("[1] Jinsoo");
                Console.SetCursorPosition(35, 12);
                Console.WriteLine("[2] Bakara");
                Console.SetCursorPosition(35, 13);
                Console.WriteLine("[3] Desert");
                Console.SetCursorPosition(35, 14);
                Console.WriteLine("[4] Frozen Hill");
                Console.SetCursorPosition(35, 15);
                Console.WriteLine("[5] Spider Dungeon");
                Console.SetCursorPosition(35, 16);
                Console.WriteLine("[6] Grand Volcano");
                Console.SetCursorPosition(35, 17);
                Console.WriteLine("[7] Ghost Forest");
                Console.SetCursorPosition(35, 18);
                Console.WriteLine("[8] Fishin Valley");

                Console.SetCursorPosition(35, 20);
                Console.Write("Choice: ");
                string mapChoice = Console.ReadLine().ToUpper();

                //Add travelling loading screen
                switch(mapChoice)
                {
                    case "1": case "JINSOO":
                        Program.Char_Location = "Jinsoo";
                        break;

                    case "2": case "BAKARA":
                        Program.Char_Location = "Bakara";
                        break;

                    case "3": case "DESERT":
                        Program.Char_Location = "Desert";
                        break;

                    case "4": case "FROZEN HILL":
                        Program.Char_Location = "Frozen Hill";
                        break;

                    case "5": case "SPIDER DUNGEON":
                        Program.Char_Location = "Spider Dungeon";
                        break;

                    case "6": case "GRAND VOLCANO":
                        Program.Char_Location = "Grand Volcano";
                        break;

                    case "7": case "GHOST FOREST":
                        Program.Char_Location = "Ghost Forest";
                        break;
                    case "8": case "FISHING VALLEY":
                        if(Program.Fishing_Valley_Access == 1)
                        {
                            Program.Char_Location = "Fishing Valley";
                        }
                        else
                        {
                            Console.SetCursorPosition(35, 21);
                            Console.WriteLine("You do not have access to Fishing Valley. Speak to the Fisherman.");
                            Console.ReadLine();
                        }
                        break;


                    default:
                        break;
                }

            }

            if(Program.Current_Command == "FISH" && Program.Fishing_Valley_Access == 1 && Program.Char_Location == "Fishing Valley")
            {
                fishingGame.fishGame();
            }
            else if(Program.Current_Command == "FISH" && Program.Char_Location != "Fishing Valley")
            {
                Thread.Sleep(300);
                Console.SetCursorPosition(35, 12);
                Console.WriteLine("You may only fish in 'Fishing Valley'");
                Console.ReadLine();
                Console.Clear();
                drawGUI();
            }
            else if(Program.Current_Command == "FISH" && Program.Fishing_Valley_Access != 1)
            {
                Thread.Sleep(300);
                Console.SetCursorPosition(35, 12);
                Console.WriteLine("You do not have Fishing Access.");
                Console.SetCursorPosition(35, 13);
                Console.WriteLine("Please speak to the Fisherman");
                Console.ReadLine();
                Console.Clear();
                drawGUI();
            }
            else if(Program.Current_Command == "FISH" && Program.Equipped_Weapon != "Fishing Rod")
            {
                Thread.Sleep(300);
                Console.SetCursorPosition(35, 12);
                Console.WriteLine("You do not have equipped a 'Fishing Rod'");
                Console.ReadLine();
                Console.Clear();
                drawGUI();
            }

            if (Program.Current_Command == "QUEST" || Program.Current_Command == "NEXT QUEST")
            {

                if (Program.questsCompleted >= 4)
                {
                    Console.SetCursorPosition(Console.WindowWidth / 2 - 16, Console.WindowHeight / 2 - 3);
                    Console.WriteLine("You have completed all the quests !");
                    Console.ReadLine();
                }
                else
                {
                    Program.questsCompleted++;
                }

            }

            Console.Clear();
        }


        static void getEnemy()
        {
            if (Program.Char_Location == "Jinsoo" || Program.Char_Location == "Bakara")
            {

                Random r_weak = new Random();
                string weak_enemy = Enemys.weak_enemy_type[r_weak.Next(0, Enemys.weak_enemy_type.Length)];

                int[] enemy_damage = { 26, 25, 30, 23, 38, 31, 29, 32, 29, 27 };
                int[] enemy_defence = { 20, 10, 0, 7, 14, 21, 17 };
                int[] enemy_exp = { 23, 6, 10, 11, 5, 18, 20, 21 };
                int[] enemy_health = { 100, 70, 150, 50, 110, 112, 101 };

                Random s = new Random();
                Enemys.E_Damage = enemy_damage[s.Next(0, enemy_damage.Length)];
                Enemys.E_Defence = enemy_defence[s.Next(0, enemy_defence.Length)];
                Enemys.E_Health = enemy_health[s.Next(0, enemy_health.Length)];
                Enemys.E_EXP = enemy_exp[s.Next(0, enemy_exp.Length)];

                Console.SetCursorPosition(35, 10);
                Console.WriteLine("You just encountered a {0}", weak_enemy);
                Console.SetCursorPosition(42, 12);
                Console.WriteLine("..:: Enemy Stats ::.. ");
                Console.SetCursorPosition(35, 13);
                Console.WriteLine("Health: {0}   Defence: {1}   Damage: {2}", Enemys.E_Health, Enemys.E_Defence, Enemys.E_Damage);

                do
                {
                    Console.SetCursorPosition(35, 15);
                    Console.WriteLine("What will you do ? [Attack / Run]");
                    Console.SetCursorPosition(35, 16);
                    Console.Write("Action: ");
                    string action = Console.ReadLine().ToUpper();

                    double damage_to_enemy = Program.Char_Damage - Enemys.E_Defence;


                    double damage_to_char = Enemys.E_Damage - Program.Char_Defence;
                    if (damage_to_char <= 0)
                    {
                        damage_to_char = 0;
                    }

                    switch (action)
                    {
                        case "ATTACK":
                        case "A":
                            if (Enemys.enemy_dead == 0)
                            {
                                Enemys.E_Health -= damage_to_enemy;
                                Program.Char_HP_Current -= damage_to_char;
                                Console.Clear();
                                Thread.Sleep(500);
                                drawGUI();
                                Console.SetCursorPosition(35, 10);
                                Console.WriteLine("You dealt {0} damage to {1}", damage_to_enemy, weak_enemy);
                                Console.SetCursorPosition(35, 11);
                                Console.WriteLine("{0} dealt {1} damamage to You", weak_enemy, damage_to_char);
                                Console.SetCursorPosition(42, 13);
                                Console.WriteLine("..:: Enemy Stats ::..");
                                Console.SetCursorPosition(35, 14);
                                Console.WriteLine("Health: {0}   Defence: {1}   Damage: {2}", Enemys.E_Health, Enemys.E_Defence, Enemys.E_Damage);

                                if (Enemys.E_Health <= 0)
                                {
                                    Enemys.enemy_dead = 1;

                                    Console.Clear();
                                    drawGUI();
                                    Console.SetCursorPosition(35, 10);
                                    Console.WriteLine("You killed the {0}", weak_enemy);
                                    Console.SetCursorPosition(35, 11);
                                    Console.WriteLine("EXP Gained: {0} ", Enemys.E_EXP);
                                    Console.SetCursorPosition(35, 13);
                                    Items.dropItem();
                                    Console.SetCursorPosition(35, 17);
                                    Console.WriteLine("Press any key to continue....");
                                    Program.Char_EXP_Current += Enemys.E_EXP;
                                    Console.ReadLine();
                                }
                                if (Program.Char_HP_Current <= 0)
                                {
                                    Console.Clear();
                                    drawGUI();
                                    Enemys.enemy_dead = 1;

                                    Console.SetCursorPosition(35, 10);
                                    Console.WriteLine("You have been defeated in battle.");
                                    Console.SetCursorPosition(35, 13);
                                    Console.WriteLine("Press any key to continue...");
                                    Console.ReadLine();
                                    playerDead();
                                }
                            }

                            break;

                        case "RUN":
                        case "R":
                            Enemys.enemy_dead = 1;
                            Console.Clear();
                            drawGUI();
                            Console.SetCursorPosition(35, 10);
                            Console.WriteLine("You have fled from the fight.");
                            Console.SetCursorPosition(35, 12);
                            Console.WriteLine("Press any key to continue...");
                            Console.ReadLine();
                            break;

                        default:
                            Console.SetCursorPosition(35, 18);
                            Console.WriteLine("Wrong action selected !");
                            break;
                    }
                } while (Enemys.enemy_dead == 0);

            }

            else if (Program.Char_Location == "Desert" || Program.Char_Location == "Frozen Hill")
            {
                Console.WriteLine(Enemys.medium_enemy);
            }
        }


        static void playerDead()
        {
            Console.SetCursorPosition(27, 20);
            Console.WriteLine("[A] - Respawn   [B] - End Game");
            Console.SetCursorPosition(27, 21);
            Console.Write("Choose an action: ");
            string choice = Console.ReadLine().ToUpper();

            if (choice == "A" || choice == "RESPAWN")
            {
                Console.Clear();
                Program.Char_HP_Current = 39;
                drawGUI();
                giveQuest();
            }
            else if (choice == "B" || choice == "END GAME")
            {
                Program.Game_Over = 1;
            }

        }


        public static void giveQuest()
        {
            Console.Clear();
            drawGUI();

            if (Program.questsCompleted == 0 && Program.quest1 != 0)
            {
                Console.SetCursorPosition(27, 10);
                Console.WriteLine("You just woke up washed up on the beach..... You wake up and look arround.");
                Thread.Sleep(600);
                Console.SetCursorPosition(27, 11);
                Console.WriteLine("On your right there is a fisherman who is fishing");
                Thread.Sleep(600);
                Console.SetCursorPosition(27, 12);
                Console.WriteLine("On your left there is a pathway leading to a very dense and dark forest.");
                Thread.Sleep(600);
                Console.SetCursorPosition(27, 14);
                Console.WriteLine("[A] Talk to the fisherman [B] Go on the pathway on the left");
                Thread.Sleep(600);
                Console.SetCursorPosition(27, 15);
                Console.Write("Choice: ");
                char choice = Convert.ToChar(Console.ReadLine().ToUpper());

                if (choice == 'A')
                {
                    Console.Clear();
                    drawGUI();
                    Console.SetCursorPosition(27, 10);
                    Console.WriteLine("Fisherman:");
                    Thread.Sleep(600);
                    Console.SetCursorPosition(27, 11);
                    Console.WriteLine("I was wondering when you would wake up. The kingdom is in desperate need for a hero.");
                    Thread.Sleep(600);
                    Console.SetCursorPosition(27, 12);
                    Console.WriteLine("The 'Flame King' has taken over the land and turned all plants to ashes.");
                    Thread.Sleep(600);
                    Console.SetCursorPosition(27, 13);
                    Console.WriteLine("Only a true hero can defeat the 'Flame King' and bring back peace into the kingdom.");
                    Thread.Sleep(600);
                    Console.SetCursorPosition(27, 14);
                    Console.WriteLine("This kingdom has been defeated for too long !");
                    Thread.Sleep(600);
                    Console.SetCursorPosition(27, 16);
                    Console.WriteLine("Are you that hero ?  [Y/N]");
                    Console.SetCursorPosition(27, 17);
                    Console.Write("Answer: ");
                    char choice2 = Convert.ToChar(Console.ReadLine().ToUpper());

                    if (choice2 == 'Y')
                    {
                        Console.Clear();
                        drawGUI();
                        Console.SetCursorPosition(15, 10);
                        Console.WriteLine("Fisherman:");
                        Thread.Sleep(600);
                        Console.SetCursorPosition(15, 11);
                        Console.WriteLine("I need you to go to the next village and give this steel ingot to the blacksmith.");
                        Thread.Sleep(600);
                        Console.SetCursorPosition(15, 12);
                        Console.WriteLine("He will craft you a weapon so that you may begin your journey to defeat the 'Flame King'");
                        Thread.Sleep(600);
                        Console.SetCursorPosition(15, 13);
                        Console.WriteLine("You may press ' SPACEBAR ' at any time to do an action. ");
                        Thread.Sleep(600);
                        Console.SetCursorPosition(15, 14);
                        Console.WriteLine("Type 'Commands' for a list of actions. ");
                        Thread.Sleep(600);
                        Console.SetCursorPosition(15, 16);
                        Console.WriteLine("You received: 'Iron Ingot'");
                        Items.Inventory.Add("Iron Ingot");
                        Thread.Sleep(600);
                        Console.SetCursorPosition(15, 17);
                        Console.WriteLine("Press any key to continue ....");
                        Console.ReadLine();
                    }
                    else if (choice2 == 'N')
                    {
                        Program.Game_Over = 1;
                    }
                }
                else if (choice == 'B')
                {
                    Console.Clear();
                    drawGUI();
                    Console.SetCursorPosition(27, 10);
                    Console.WriteLine("While walking through the dark forest you got ambushed by a group of bandits...");
                    Thread.Sleep(600);
                    Console.SetCursorPosition(27, 11);
                    Console.WriteLine("You had no weapon to defend yourself.");
                    Thread.Sleep(600);
                    Console.SetCursorPosition(27, 12);
                    Console.WriteLine("You have been killed in the fight with the bandits.");
                    Thread.Sleep(1500);
                    playerDead();
                }

                Console.Clear();

                Program.quest1 = 0;
                drawGUI();
            }

            if (Program.questsCompleted == 1 && Program.quest2 != 0)
            {

                Console.WriteLine("insert second quest here");
                getEnemy();
                Console.Clear();

                Program.quest2 = 0;
                drawGUI();
            }

            if (Program.questsCompleted == 2 && Program.quest3 != 0)
            {

                Console.WriteLine("insert third quest here");
                getEnemy();
                Console.Clear();

                Program.quest3 = 0;
                drawGUI();
            }

            if (Program.questsCompleted == 3 && Program.quest4 != 0)
            {

                Console.WriteLine("insert fourth quest here");
                getEnemy();
                Console.Clear();

                Program.quest4 = 0;
                drawGUI();
            }

            if (Program.questsCompleted == 4 && Program.quest5 != 0)
            {

                Console.WriteLine("insert fifth quest here");
                getEnemy();
                Console.Clear();

                Program.quest5 = 0;
                drawGUI();
            }
        }

        public static void newGame()
        {
            string directory = @"C:\Users\2640\source\repos\Metin_Adventures\Metin_save";
            string savePath = @"C:\Users\2640\source\repos\Metin_Adventures\Metin_save\save.txt";

            Directory.CreateDirectory(directory);

            if (!File.Exists(savePath))
            {
                using (StreamWriter sw = File.CreateText(savePath))
                {
                    sw.WriteLine("Made by SV. Cristian");
                }
            }

            Console.Clear();
            Thread.Sleep(350);
            int loadingLength = 5;
            Console.SetCursorPosition(Console.WindowWidth / 2 - 16, Console.WindowHeight / 2 - 3);
            Console.Write("Loading...");

            for (int i = 0; i < loadingLength; i++)
            {
                Console.Write(".");
                Thread.Sleep(400);
            }
            Thread.Sleep(1500);

            characterCreation();
        }


        public static void printMainMenu()
        {
            Console.SetCursorPosition(48, 7);
            Console.WriteLine("...::: Main Menu :::...");
            Console.SetCursorPosition(50, 9);
            Console.WriteLine("[1] - New Game");
            Console.SetCursorPosition(50, 10);
            Console.WriteLine("[2] - Load Game");
            Console.SetCursorPosition(50, 11);
            Console.WriteLine("[3] - Delete a Save File");
            Console.SetCursorPosition(50, 12);
            Console.WriteLine("[4] - Commands List");
            Console.SetCursorPosition(50, 13);
            Console.WriteLine("[5] - Credits");
            Console.SetCursorPosition(50, 14);
            Console.WriteLine("[6] - Exit");

            Console.SetCursorPosition(48, 16);
            Console.Write("Choice: ");
        }


    }
}
