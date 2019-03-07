using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metin_Adventures
{
    class Items
    {
        public static int weapon_damage = 0;
        public static int armour_defence = 0;


        //Weapons
        //Sword
        public static string[] items = { "Sword + 0", "Sword + 1", "Sword + 2", "Sword + 3", "Sword + 4", "Sword + 5",
                                         "Long Sword + 0", "Long Sword + 1", "Long Sword + 2", "Long Sword + 3", "Long Sword + 4", "Long Sword + 5",
                                         "Silver Sword + 0", "Silver Sword + 1", "Silver Sword + 2", "Silver Sword + 3", "Silver Sword + 4", "Silver Sword + 5",
                                         "Battle Sword + 0", "Battle Sword + 1", "Battle Sword + 2", "Battle Sword + 3", "Battle Sword + 4", "Battle Sword + 5" ,
            //Daggers
                                         "Daggers + 0", "Daggers + 1", "Daggers + 2", "Daggers + 3", "Daggers + 4", "Daggers + 5",
                                         "Scrissor Daggers + 0", "Scrissor Daggers + 1", "Scrissor Daggers + 2", "Scrissor Daggers + 3", "Scrissor Daggers + 4", "Scrissor Daggers + 5",
                                         "Silver Daggers + 0", "Silver Daggers + 1", "Silver Daggers + 2", "Silver Daggers + 3", "Silver Daggers + 4", "Silver Daggers + 5",
                                         "Battle Daggers + 0", "Battle Daggers + 1", "Battle Daggers + 2", "Battle Daggers + 3", "Battle Daggers + 4", "Battle Daggers + 5",
             //Staff
                                         "Staff + 0", "Staff + 1", "Staff + 2", "Staff + 3", "Staff + 4", "Staff + 5",
                                         "Void Staff + 0", "Void Staff + 1", "Void Staff + 2", "Void Staff + 3", "Void Staff + 4", "Void Staff + 5",
                                         "Silver Staff + 0", "Silver Staff + 1", "Silver Staff + 2", "Silver Staff + 3", "Silver Staff + 4", "Silver Staff + 5",
                                         "Battle Staff + 0", "Battle Staff + 1", "Battle Staff + 2", "Battle Staff + 3", "Battle Staff + 4", "Battle Staff + 5",
            //Poleaxe
                                         "Poleaxe + 0", "Poleaxe + 1", "Poleaxe + 2", "Poleaxe + 3", "Poleaxe + 4", "Poleaxe + 5",
                                         "Long Poleaxe + 0", "Long Poleaxe + 1", "Long Poleaxe + 2", "Long Poleaxe + 3", "Long Poleaxe + 4", "Long Poleaxe + 5",
                                         "Silver Poleaxe + 0", "Silver Poleaxe + 1", "Silver Poleaxe + 2", "Silver Poleaxe + 3", "Silver Poleaxe + 4", "Silver Poleaxe + 5",
                                         "Battle Poleaxe + 0", "Battle Poleaxe + 1", "Battle Poleaxe + 2", "Battle Poleaxe + 3", "Battle Poleaxe + 4", "Battle Poleaxe + 5",

        //Armours
                                         "Cloth Armour + 0", "Cloth Armour + 1", "Cloth Armour + 2", "Cloth Armour + 3", "Cloth Armour + 4", "Cloth Armour + 5",
                                         "Leather Armour + 0", "Leather Armour + 1", "Leather Armour + 2", "Leather Armour + 3", "Leather Armour + 4", "Leather Armour + 5",
                                         "Chain Armour + 0", "Chain Armour + 1", "Chain Armour + 2", "Chain Armour + 3", "Chain Armour + 4", "Chain Armour + 5",
                                         "Battle Armour + 0", "Battle Armour + 1", "Battle Armour + 2", "Battle Armour + 3", "Battle Armour + 4", "Battle Armour + 5",
        //Upgrade Items
                                         "Small Rock", "Leather", "Cloth", "Red Rose", "Blue Rose", "Walnut",
                                         "Rock", "Chain Link", "Unknown Talisman", "Rusty Blade", "Empty Can", "Porcelain",
        //Potions
                                         "[S] Red Potion", "[M] Red Potion", "[L] Red Potion", //HP Potion
                                         "[S] Yellow Potion", "[M] Yellow Potion", "[L] Yellow Potion" }; //EXP Potion

        public static string[] uitems = { "Leather", "Rock", "Rock", "Cloth", "Rock", "Red Rose", "Rock", "Rock", "Blue Rose", "Rock", "Rock", "Walnut", "Rock",
                                          "Rock", "Rock", "Chain Link", "Rock", "Unknown Talisman", "Rusty Blade", "Rock", "Empty Can", "Rock", "Rock", "Porcelain" };


        public static string item_equipped_w = "a";
        public static string item_equipped_a = "a";


        public static List<string> Inventory = new List<string>();

        public static void dropItem()
        {
            Random item_drop_chance = new Random();
            string item_drop = items[item_drop_chance.Next(0, items.Length)];

            Random upgrade_item_drop_chance = new Random();
            string upgrade_drop = uitems[upgrade_item_drop_chance.Next(0, uitems.Length)];

            Random d = new Random();
            int[] drop_chance = { 1, 0, 0, 0, 1, 0, 1, 1, 0, 0, 0, 1, 1, 0, 0, 0, 1, 1, 1, 0, 0, 1, 0, 0, 1, 0, 0, 0, 0, 1, 1, 1, 0, 0, 0, 0, 1, 1, 0, 0, 1, 0, 1, 1, 1, 1, 0, 0, 1, 0, 0, 0, 1, 0, 1, 0, 1, 1, 1, 0, 0, 0, 0 };
            int drop_item = drop_chance[d.Next(0, drop_chance.Length)];


            //For testing
            //Console.WriteLine(drop_item);

            if (drop_item != 0)
            {
                for (int i = 0; i < Inventory.Count; i++)
                {
                    if (Inventory[i].Contains("Empty Slot"))
                    {
                        Inventory[i] = item_drop;
                        Console.SetCursorPosition(35, 14);
                        Console.WriteLine("You received {0}", item_drop);
                        break;
                    }
                }
                for (int i = 0; i < Inventory.Count; i++)
                {
                    if (Inventory[i].Contains("Empty Slot"))
                    {
                        Inventory[i] = upgrade_drop;
                        Console.SetCursorPosition(35, 15);
                        Console.WriteLine("You received {0}", upgrade_drop);
                        break;
                    }
                }

                if (!Inventory.Contains("Empty Slot"))
                {
                    Console.SetCursorPosition(35, 15);
                    Console.WriteLine("You could not carry {0} & {1}", item_drop, upgrade_drop);
                    Console.SetCursorPosition(35, 16);
                    Console.WriteLine("Free up some inventory space !");
                    Console.ReadLine();
                }
            }
        }


        public static void equipWeapon()
        {
            Console.SetCursorPosition(10, 24);
            Console.Write("Enter the weapon Name you want to equip: ");
            string equip = Console.ReadLine();

            //Continue this List and do the same to Armours
            if (Inventory.Contains(equip) && equip == "Fishing Rod" || equip == "Sword + 0" || equip == "Sword + 1" || equip == "Sword + 2" || equip == "Sword + 3" || equip == "Sword + 4" || equip == "Sword + 5" || equip == "Long Sword + 0" || equip == "Long Sword + 1" || equip == "Long Sword + 2" || equip == "Long Sword + 3" || equip == "Long Sword + 4" || equip == "Long Sword + 5" || equip == "Silver Sword + 0" || equip == "Silver Sword + 1" || equip == "Silver Sword + 2" || equip == "Silver Sword + 3" || equip == "Silver Sword + 4" || equip == "Silver Sword + 5" || equip == "Battle Sword + 0" || equip == "Battle Sword + 1" || equip == "Battle Sword + 2" || equip == "Battle Sword + 3" || equip == "Battle Sword + 4" || equip == "Battle Sword + 5"
                 || equip == "Daggers + 0" || equip == "Daggers + 1" || equip == "Daggers + 2" || equip == "Daggers + 3" || equip == "Daggers + 4" || equip == "Daggers + 5" || equip == "Scrissor Daggers + 0" || equip == "Scrissor Daggers + 1" || equip == "Scrissor Daggers + 2" || equip == "Scrissor Daggers + 3" || equip == "Scrissor Daggers + 4" || equip == "Scrissor Daggers + 5" || equip == "Silver Daggers + 0" || equip == "Silver Daggers + 1" || equip == "Silver Daggers + 2" || equip == "Silver Daggers + 3" || equip == "Silver Daggers + 4" || equip == "Silver Daggers + 5" || equip == "Battle Daggers + 0" || equip == "Battle Daggers + 1" || equip == "Battle Daggers + 2" || equip == "Battle Daggers + 3" || equip == "Battle Daggers + 4" || equip == "Battle Daggers + 5"
                 || equip == "Staff + 0" || equip == "Staff + 1" || equip == "Staff + 2" || equip == "Staff + 3" || equip == "Staff + 4" || equip == "Staff + 5" || equip == "Void Staff + 0" || equip == "Void Staff + 1" || equip == "Void Staff + 2" || equip == "Void Staff + 3" || equip == "Void Staff + 4" || equip == "Void Staff + 5" || equip == "Silver Staff + 0" || equip == "Silver Staff + 1" || equip == "Silver Staff + 2" || equip == "Silver Staff + 3" || equip == "Silver Staff + 4" || equip == "Silver Staff + 5" || equip == "Battle Staff + 0" || equip == "Battle Staff + 1" || equip == "Battle Staff + 2" || equip == "Battle Staff + 3" || equip == "Battle Staff + 4" || equip == "Battle Staff + 5"
                 || equip == "Poleaxe + 0" || equip == "Poleaxe + 1" || equip == "Poleaxe + 2" || equip == "Poleaxe + 3" || equip == "Poleaxe + 4" || equip == "Poleaxe + 5" || equip == "Long Poleaxe + 0" || equip == "Long Poleaxe + 1" || equip == "Long Poleaxe + 2" || equip == "Long Poleaxe + 3" || equip == "Long Poleaxe + 4" || equip == "Long Poleaxe + 5" || equip == "Silver Poleaxe + 0" || equip == "Silver Poleaxe + 1" || equip == "Silver Poleaxe + 2" || equip == "Silver Poleaxe + 3" || equip == "Silver Poleaxe + 4" || equip == "Silver Poleaxe + 5" || equip == "Battle Poleaxe + 0" || equip == "Battle Poleaxe + 1" || equip == "Battle Poleaxe + 2" || equip == "Battle Poleaxe + 3" || equip == "Battle Poleaxe + 4" || equip == "Battle Poleaxe + 5")
            {
                Inventory.Remove(equip);
                Inventory.Add(Program.Equipped_Weapon);
                Program.Equipped_Weapon = "Fists";
                Functions.drawGUI();
                Program.Equipped_Weapon = equip;
                Console.SetCursorPosition(10, 25);
                Console.WriteLine("You have successfully equipped {0}", equip);
                item_equipped_w = "a";
                Console.ReadLine();

                if (Inventory.Contains("Fists"))
                {
                    Inventory.Remove("Fists");
                }
            }
            else
            {
                Console.SetCursorPosition(10, 25);
                Console.WriteLine("You can't equip or You do not have {0} in your Inventory.", equip);
                Console.ReadLine();
            }
        }


        public static void equipArmour()
        {
            Console.SetCursorPosition(10, 24);
            Console.Write("Enter the armour Name you want to equip: ");
            string equip = Console.ReadLine();

            //Continue this list
            if (Inventory.Contains(equip) && equip == "Cloth Armour + 0" || equip == "Cloth Armour + 1" || equip == "Cloth Armour + 2" || equip == "Cloth Armour + 3" || equip == "Cloth Armour + 4" || equip == "Cloth Armour + 5" || equip == "Leather Armour + 0" || equip == "Leather Armour + 1" || equip == "Leather Armour + 2" || equip == "Leather Armour + 3" || equip == "Leather Armour + 4" || equip == "Leather Armour + 5" || equip == "Chain Armour + 0" || equip == "Chain Armour + 1" || equip == "Chain Armour + 2" || equip == "Chain Armour + 3" || equip == "Chain Armour + 4" || equip == "Chain Armour + 5" || equip == "Battle Armour + 0" || equip == "Battle Armour + 1" || equip == "Battle Armour + 2" || equip == "Battle Armour + 3" || equip == "Battle Armour + 4" || equip == "Battle Armour + 5")
            {
                Inventory.Remove(equip);
                Inventory.Add(Program.Equipped_Armour);
                Program.Equipped_Armour = "Cloth Robe";
                Functions.drawGUI();
                Program.Equipped_Armour = equip;
                Console.SetCursorPosition(10, 25);
                Console.WriteLine("You have successfully equipped {0}", equip);
                item_equipped_a = "a";
                Console.ReadLine();

                if (Inventory.Contains("Cloth Robe"))
                {
                    Inventory.Remove("Cloth Robe");
                }
            }
            else
            {
                Console.SetCursorPosition(10, 25);
                Console.WriteLine("You can't equip or You do not have {0} in your Inventory.", equip);
                Console.ReadLine();
            }
        }


        public static void unequipWeapon()
        {
            if (!Inventory.Contains("Empty Slot"))
            {
                Console.SetCursorPosition(10, 24);
                Console.WriteLine("{0} Your inventory is Full ! Please free some space.", Program.Char_Name);
                Console.SetCursorPosition(10, 25);
                Console.WriteLine("You can't unequip {0}", Program.Equipped_Weapon);

                Console.ReadLine();
            }
            else
            {
                if (Program.Equipped_Weapon == "Fists")
                {
                    Console.SetCursorPosition(10, 24);
                    Console.WriteLine("You can't unequipp Fists");

                    Console.ReadLine();
                }
                else
                {
                    Console.SetCursorPosition(10, 24);

                    for (int i = 0; i < Inventory.Count; i++)
                    {
                        if (Inventory[i].Contains("Empty Slot"))
                        {
                            Inventory[i] = Program.Equipped_Weapon;
                            break;
                        }
                    }

                    Console.WriteLine("You have successfuly unequipped {0}", Program.Equipped_Weapon);
                    Program.Equipped_Weapon = "Fists";
                    item_equipped_w = "a";

                    Console.ReadLine();
                }
            }
        }


        public static void unequipArmour()
        {
            if (!Inventory.Contains("Empty Slot"))
            {
                Console.SetCursorPosition(10, 24);
                Console.WriteLine("{0} Your inventory is Full ! Please free some space.", Program.Char_Name);
                Console.SetCursorPosition(10, 25);
                Console.WriteLine("You can't unequip {0}", Program.Equipped_Armour);

                Console.ReadLine();
            }
            else
            {
                if (Program.Equipped_Armour == "Cloth Robe")
                {
                    Console.SetCursorPosition(10, 24);
                    Console.WriteLine("You can't unequipp Cloth Robe");

                    Console.ReadLine();
                }
                else
                {
                    Console.SetCursorPosition(10, 24);

                    for (int i = 0; i < Inventory.Count; i++)
                    {
                        if (Inventory[i].Contains("Empty Slot"))
                        {
                            Inventory[i] = Program.Equipped_Armour;
                            break;
                        }
                    }

                    Console.WriteLine("You have successfuly unequipped {0}", Program.Equipped_Armour);
                    Program.Equipped_Armour = "Cloth Robe";
                    item_equipped_a = "a";

                    Console.ReadLine();
                }
            }
        }


        public static void discardItem()
        {
            Console.SetCursorPosition(10, 21);
            Console.WriteLine("Please enter the item you want to discard.");
            Console.SetCursorPosition(10, 22);
            Console.Write("Item: ");
            string discItem = Console.ReadLine();

            Console.SetCursorPosition(10, 24);
            Console.WriteLine("Are you sure you want to discard {0}", discItem);
            Console.SetCursorPosition(10, 25);
            Console.Write("Enter Yes/No: ");
            string confirm = Console.ReadLine().ToUpper();

            if(confirm == "YES")
            {
                if (!Inventory.Contains(discItem))
                {
                    Console.SetCursorPosition(10, 27);
                    Console.WriteLine("You do not have {0} in your Inventory.", discItem);
                    Console.ReadLine();
                }
                else if (discItem == "Empty Slot")
                {
                    Console.SetCursorPosition(10, 27);
                    Console.WriteLine("You can't discard an Empty Slot.");
                    Console.ReadLine();
                }
                else
                {

                    for (int i = 0; i < Inventory.Count; i++)
                    {
                        if (Inventory[i].Contains(discItem))
                        {
                            Inventory[i] = "Empty Slot";
                            Console.SetCursorPosition(10, 27);
                            Console.WriteLine("{0} Discarded.", discItem);
                            Console.ReadLine();
                            break;
                        }
                    }
                }
            }
            else if(confirm == "NO")
            { }
        }


        public static void usePotion()
        {
            Console.SetCursorPosition(10, 21);
            Console.WriteLine("Which potion would you like to use ?");
            Console.SetCursorPosition(10, 22);
            Console.Write("Potion: ");
            string potion = Console.ReadLine();

            if (potion == "[S] Red Potion" && Inventory.Contains(potion))
            {
                for (int i = 0; i < Inventory.Count; i++)
                {
                    if (Inventory[i].Contains(potion))
                    {
                        Inventory[i] = "Empty Slot";
                        Program.Char_HP_Current += 15;
                        Console.SetCursorPosition(10, 23);
                        Console.WriteLine("You healed 15 HP.");
                        Console.ReadLine();
                        break;
                    }
                }
            }
            else if (potion == "[M] Red Potion" && Inventory.Contains(potion))
            {
                for (int i = 0; i < Inventory.Count; i++)
                {
                    if (Inventory[i].Contains(potion))
                    {
                        Inventory[i] = "Empty Slot";
                        Program.Char_HP_Current += 45;
                        Console.SetCursorPosition(10, 23);
                        Console.WriteLine("You healed 45 HP.");
                        Console.ReadLine();
                        break;
                    }
                }
            }
            else if (potion == "[L] Red Potion" && Inventory.Contains(potion))
            {
                for (int i = 0; i < Inventory.Count; i++)
                {
                    if (Inventory[i].Contains(potion))
                    {
                        Inventory[i] = "Empty Slot";
                        Program.Char_HP_Current += 80;
                        Console.SetCursorPosition(10, 23);
                        Console.WriteLine("You healed 80 HP.");
                        Console.ReadLine();
                        break;
                    }
                }
            }
            else if (potion == "[S] Yellow Potion" && Inventory.Contains(potion))
            {
                for (int i = 0; i < Inventory.Count; i++)
                {
                    if (Inventory[i].Contains(potion))
                    {
                        Inventory[i] = "Empty Slot";
                        Program.Char_EXP_Current += 35;
                        Console.SetCursorPosition(10, 23);
                        Console.WriteLine("You received 35 EXP.");
                        Console.ReadLine();
                        break;
                    }
                }
            }
            else if (potion == "[M] Yellow Potion" && Inventory.Contains(potion))
            {
                for (int i = 0; i < Inventory.Count; i++)
                {
                    if (Inventory[i].Contains(potion))
                    {
                        Inventory[i] = "Empty Slot";
                        Program.Char_EXP_Current += 70;
                        Console.SetCursorPosition(10, 23);
                        Console.WriteLine("You received 70 EXP.");
                        Console.ReadLine();
                        break;
                    }
                }
            }
            else if (potion == "[L] Yellow Potion" && Inventory.Contains(potion))
            {
                for (int i = 0; i < Inventory.Count; i++)
                {
                    if (Inventory[i].Contains(potion))
                    {
                        Inventory[i] = "Empty Slot";
                        Program.Char_EXP_Current += 105;
                        Console.SetCursorPosition(10, 23);
                        Console.WriteLine("You received 105 EXP.");
                        Console.ReadLine();
                        break;
                    }
                }
            }
            else
            {
                Console.SetCursorPosition(10, 23);
                Console.WriteLine("Potion {0} not found in your Inventory !", potion);
            }

        }


        public static void weaponsDamage()
        {
            if (Program.Equipped_Weapon == "Fists" && item_equipped_w == "a")
            {
                Program.Char_Damage -= weapon_damage;
                item_equipped_w = "b";
            }
            //Swords Damage
            else if (Program.Equipped_Weapon == "Sword + 0" && item_equipped_w == "a")
            {
                weapon_damage = 7;
                Program.Char_Damage += weapon_damage;
                item_equipped_w = "b";
            }
            else if (Program.Equipped_Weapon == "Sword + 1" && item_equipped_w == "a")
            {
                weapon_damage = 8;
                Program.Char_Damage += weapon_damage;
                item_equipped_w = "b";
            }
            else if (Program.Equipped_Weapon == "Sword + 2" && item_equipped_w == "a")
            {
                weapon_damage = 9;
                Program.Char_Damage += weapon_damage;
                item_equipped_w = "b";
            }
            else if (Program.Equipped_Weapon == "Sword + 3" && item_equipped_w == "a")
            {
                weapon_damage = 10;
                Program.Char_Damage += weapon_damage;
                item_equipped_w = "b";
            }
            else if (Program.Equipped_Weapon == "Sword + 4" && item_equipped_w == "a")
            {
                weapon_damage = 11;
                Program.Char_Damage += weapon_damage;
                item_equipped_w = "b";
            }
            else if (Program.Equipped_Weapon == "Sword + 5" && item_equipped_w == "a")
            {
                weapon_damage = 12;
                Program.Char_Damage += weapon_damage;
                item_equipped_w = "b";
            }
            
            if (Program.Equipped_Weapon == "Long Sword + 0" && item_equipped_w == "a")
            {
                weapon_damage = 10;
                Program.Char_Damage += weapon_damage;
                item_equipped_w = "b";
            }
            else if (Program.Equipped_Weapon == "Long Sword + 1" && item_equipped_w == "a")
            {
                weapon_damage = 11;
                Program.Char_Damage += weapon_damage;
                item_equipped_w = "b";
            }
            else if (Program.Equipped_Weapon == "Long Sword + 2" && item_equipped_w == "a")
            {
                weapon_damage = 12;
                Program.Char_Damage += weapon_damage;
                item_equipped_w = "b";
            }
            else if (Program.Equipped_Weapon == "Long Sword + 3" && item_equipped_w == "a")
            {
                weapon_damage = 13;
                Program.Char_Damage += weapon_damage;
                item_equipped_w = "b";
            }
            else if (Program.Equipped_Weapon == "Long Sword + 4" && item_equipped_w == "a")
            {
                weapon_damage = 14;
                Program.Char_Damage += weapon_damage;
                item_equipped_w = "b";
            }
            else if (Program.Equipped_Weapon == "Long Sword + 5" && item_equipped_w == "a")
            {
                weapon_damage = 15;
                Program.Char_Damage += weapon_damage;
                item_equipped_w = "b";
            }
            else if (Program.Equipped_Weapon == "Silver Sword + 0" && item_equipped_w == "a")
            {
                weapon_damage = 13;
                Program.Char_Damage += weapon_damage;
                item_equipped_w = "b";
            }
            else if (Program.Equipped_Weapon == "Silver Sword + 1" && item_equipped_w == "a")
            {
                weapon_damage = 14;
                Program.Char_Damage += weapon_damage;
                item_equipped_w = "b";
            }
            else if (Program.Equipped_Weapon == "Silver Sword + 2" && item_equipped_w == "a")
            {
                weapon_damage = 15;
                Program.Char_Damage += weapon_damage;
                item_equipped_w = "b";
            }
            else if (Program.Equipped_Weapon == "Silver Sword + 3" && item_equipped_w == "a")
            {
                weapon_damage = 16;
                Program.Char_Damage += weapon_damage;
                item_equipped_w = "b";
            }
            else if (Program.Equipped_Weapon == "Silver Sword + 4" && item_equipped_w == "a")
            {
                weapon_damage = 17;
                Program.Char_Damage += weapon_damage;
                item_equipped_w = "b";
            }
            else if (Program.Equipped_Weapon == "Silver Sword + 5" && item_equipped_w == "a")
            {
                weapon_damage = 18;
                Program.Char_Damage += weapon_damage;
                item_equipped_w = "b";
            }
            else if (Program.Equipped_Weapon == "Battle Sword + 0" && item_equipped_w == "a")
            {
                weapon_damage = 16;
                Program.Char_Damage += weapon_damage;
                item_equipped_w = "b";
            }
            else if (Program.Equipped_Weapon == "Battle Sword + 1" && item_equipped_w == "a")
            {
                weapon_damage = 17;
                Program.Char_Damage += weapon_damage;
                item_equipped_w = "b";
            }
            else if (Program.Equipped_Weapon == "Battle Sword + 2" && item_equipped_w == "a")
            {
                weapon_damage = 18;
                Program.Char_Damage += weapon_damage;
                item_equipped_w = "b";
            }
            else if (Program.Equipped_Weapon == "Battle Sword + 3" && item_equipped_w == "a")
            {
                weapon_damage = 19;
                Program.Char_Damage += weapon_damage;
                item_equipped_w = "b";
            }
            else if (Program.Equipped_Weapon == "Battle Sword + 4" && item_equipped_w == "a")
            {
                weapon_damage = 20;
                Program.Char_Damage += weapon_damage;
                item_equipped_w = "b";
            }
            else if (Program.Equipped_Weapon == "Battle Sword + 5" && item_equipped_w == "a")
            {
                weapon_damage = 21;
                Program.Char_Damage += weapon_damage;
                item_equipped_w = "b";
            }
            //Daggers Damage
            else if (Program.Equipped_Weapon == "Daggers + 0" && item_equipped_w == "a")
            {
                weapon_damage = 7;
                Program.Char_Damage += weapon_damage;
                item_equipped_w = "b";
            }
            else if (Program.Equipped_Weapon == "Daggers + 1" && item_equipped_w == "a")
            {
                weapon_damage = 8;
                Program.Char_Damage += weapon_damage;
                item_equipped_w = "b";
            }
            else if (Program.Equipped_Weapon == "Daggers + 2" && item_equipped_w == "a")
            {
                weapon_damage = 9;
                Program.Char_Damage += weapon_damage;
                item_equipped_w = "b";
            }
            else if (Program.Equipped_Weapon == "Daggers + 3" && item_equipped_w == "a")
            {
                weapon_damage = 10;
                Program.Char_Damage += weapon_damage;
                item_equipped_w = "b";
            }
            else if (Program.Equipped_Weapon == "Daggers + 4" && item_equipped_w == "a")
            {
                weapon_damage = 11;
                Program.Char_Damage += weapon_damage;
                item_equipped_w = "b";
            }
            else if (Program.Equipped_Weapon == "Daggers + 5" && item_equipped_w == "a")
            {
                weapon_damage = 12;
                Program.Char_Damage += weapon_damage;
                item_equipped_w = "b";
            }
            else if (Program.Equipped_Weapon == "Scrissor Daggers + 0" && item_equipped_w == "a")
            {
                weapon_damage = 10;
                Program.Char_Damage += weapon_damage;
                item_equipped_w = "b";
            }
            else if (Program.Equipped_Weapon == "Scrissor Daggers + 1" && item_equipped_w == "a")
            {
                weapon_damage = 11;
                Program.Char_Damage += weapon_damage;
                item_equipped_w = "b";
            }
            else if (Program.Equipped_Weapon == "Scrissor Daggers + 2" && item_equipped_w == "a")
            {
                weapon_damage = 12;
                Program.Char_Damage += weapon_damage;
                item_equipped_w = "b";
            }
            else if (Program.Equipped_Weapon == "Scrissor Daggers + 3" && item_equipped_w == "a")
            {
                weapon_damage = 13;
                Program.Char_Damage += weapon_damage;
                item_equipped_w = "b";
            }
            else if (Program.Equipped_Weapon == "Scrissor Daggers + 4" && item_equipped_w == "a")
            {
                weapon_damage = 14;
                Program.Char_Damage += weapon_damage;
                item_equipped_w = "b";
            }
            else if (Program.Equipped_Weapon == "Scrissor Daggers + 5" && item_equipped_w == "a")
            {
                weapon_damage = 15;
                Program.Char_Damage += weapon_damage;
                item_equipped_w = "b";
            }
            else if (Program.Equipped_Weapon == "Silver Daggers + 0" && item_equipped_w == "a")
            {
                weapon_damage = 13;
                Program.Char_Damage += weapon_damage;
                item_equipped_w = "b";
            }
            else if (Program.Equipped_Weapon == "Silver Daggers + 1" && item_equipped_w == "a")
            {
                weapon_damage = 14;
                Program.Char_Damage += weapon_damage;
                item_equipped_w = "b";
            }
            else if (Program.Equipped_Weapon == "Silver Daggers + 2" && item_equipped_w == "a")
            {
                weapon_damage = 15;
                Program.Char_Damage += weapon_damage;
                item_equipped_w = "b";
            }
            else if (Program.Equipped_Weapon == "Silver Daggers + 3" && item_equipped_w == "a")
            {
                weapon_damage = 16;
                Program.Char_Damage += weapon_damage;
                item_equipped_w = "b";
            }
            else if (Program.Equipped_Weapon == "Silver Daggers + 4" && item_equipped_w == "a")
            {
                weapon_damage = 17;
                Program.Char_Damage += weapon_damage;
                item_equipped_w = "b";
            }
            else if (Program.Equipped_Weapon == "Silver Daggers + 5" && item_equipped_w == "a")
            {
                weapon_damage = 18;
                Program.Char_Damage += weapon_damage;
                item_equipped_w = "b";
            }
            else if (Program.Equipped_Weapon == "Battle Daggers + 0" && item_equipped_w == "a")
            {
                weapon_damage = 16;
                Program.Char_Damage += weapon_damage;
                item_equipped_w = "b";
            }
            else if (Program.Equipped_Weapon == "Battle Daggers + 1" && item_equipped_w == "a")
            {
                weapon_damage = 17;
                Program.Char_Damage += weapon_damage;
                item_equipped_w = "b";
            }
            else if (Program.Equipped_Weapon == "Battle Daggers + 2" && item_equipped_w == "a")
            {
                weapon_damage = 18;
                Program.Char_Damage += weapon_damage;
                item_equipped_w = "b";
            }
            else if (Program.Equipped_Weapon == "Battle Daggers + 3" && item_equipped_w == "a")
            {
                weapon_damage = 19;
                Program.Char_Damage += weapon_damage;
                item_equipped_w = "b";
            }
            else if (Program.Equipped_Weapon == "Battle Daggers + 4" && item_equipped_w == "a")
            {
                weapon_damage = 20;
                Program.Char_Damage += weapon_damage;
                item_equipped_w = "b";
            }
            else if (Program.Equipped_Weapon == "Battle Daggers + 5" && item_equipped_w == "a")
            {
                weapon_damage = 21;
                Program.Char_Damage += weapon_damage;
                item_equipped_w = "b";
            }
            // Staff Damage
            else if (Program.Equipped_Weapon == "Staff + 0" && item_equipped_w == "a")
            {
                weapon_damage = 7;
                Program.Char_Damage += weapon_damage;
                item_equipped_w = "b";
            }
            else if (Program.Equipped_Weapon == "Staff + 1" && item_equipped_w == "a")
            {
                weapon_damage = 8;
                Program.Char_Damage += weapon_damage;
                item_equipped_w = "b";
            }
            else if (Program.Equipped_Weapon == "Staff + 2" && item_equipped_w == "a")
            {
                weapon_damage = 9;
                Program.Char_Damage += weapon_damage;
                item_equipped_w = "b";
            }
            else if (Program.Equipped_Weapon == "Staff + 3" && item_equipped_w == "a")
            {
                weapon_damage = 10;
                Program.Char_Damage += weapon_damage;
                item_equipped_w = "b";
            }
            else if (Program.Equipped_Weapon == "Staff + 4" && item_equipped_w == "a")
            {
                weapon_damage = 11;
                Program.Char_Damage += weapon_damage;
                item_equipped_w = "b";
            }
            else if (Program.Equipped_Weapon == "Staff + 5" && item_equipped_w == "a")
            {
                weapon_damage = 12;
                Program.Char_Damage += weapon_damage;
                item_equipped_w = "b";
            }
            else if (Program.Equipped_Weapon == "Void Staff + 0" && item_equipped_w == "a")
            {
                weapon_damage = 10;
                Program.Char_Damage += weapon_damage;
                item_equipped_w = "b";
            }
            else if (Program.Equipped_Weapon == "Void Staff + 1" && item_equipped_w == "a")
            {
                weapon_damage = 11;
                Program.Char_Damage += weapon_damage;
                item_equipped_w = "b";
            }
            else if (Program.Equipped_Weapon == "Void Staff + 2" && item_equipped_w == "a")
            {
                weapon_damage = 12;
                Program.Char_Damage += weapon_damage;
                item_equipped_w = "b";
            }
            else if (Program.Equipped_Weapon == "Void Staff + 3" && item_equipped_w == "a")
            {
                weapon_damage = 13;
                Program.Char_Damage += weapon_damage;
                item_equipped_w = "b";
            }
            else if (Program.Equipped_Weapon == "Void Staff + 4" && item_equipped_w == "a")
            {
                weapon_damage = 14;
                Program.Char_Damage += weapon_damage;
                item_equipped_w = "b";
            }
            else if (Program.Equipped_Weapon == "Void Staff + 5" && item_equipped_w == "a")
            {
                weapon_damage = 15;
                Program.Char_Damage += weapon_damage;
                item_equipped_w = "b";
            }
            else if (Program.Equipped_Weapon == "Silver Staff + 0" && item_equipped_w == "a")
            {
                weapon_damage = 13;
                Program.Char_Damage += weapon_damage;
                item_equipped_w = "b";
            }
            else if (Program.Equipped_Weapon == "Silver Staff + 1" && item_equipped_w == "a")
            {
                weapon_damage = 14;
                Program.Char_Damage += weapon_damage;
                item_equipped_w = "b";
            }
            else if (Program.Equipped_Weapon == "Silver Staff + 2" && item_equipped_w == "a")
            {
                weapon_damage = 15;
                Program.Char_Damage += weapon_damage;
                item_equipped_w = "b";
            }
            else if (Program.Equipped_Weapon == "Silver Staff + 3" && item_equipped_w == "a")
            {
                weapon_damage = 16;
                Program.Char_Damage += weapon_damage;
                item_equipped_w = "b";
            }
            else if (Program.Equipped_Weapon == "Silver Staff + 4" && item_equipped_w == "a")
            {
                weapon_damage = 17;
                Program.Char_Damage += weapon_damage;
                item_equipped_w = "b";
            }
            else if (Program.Equipped_Weapon == "Silver Staff + 5" && item_equipped_w == "a")
            {
                weapon_damage = 18;
                Program.Char_Damage += weapon_damage;
                item_equipped_w = "b";
            }
            else if (Program.Equipped_Weapon == "Battle Staff + 0" && item_equipped_w == "a")
            {
                weapon_damage = 16;
                Program.Char_Damage += weapon_damage;
                item_equipped_w = "b";
            }
            else if (Program.Equipped_Weapon == "Battle Staff + 1" && item_equipped_w == "a")
            {
                weapon_damage = 17;
                Program.Char_Damage += weapon_damage;
                item_equipped_w = "b";
            }
            else if (Program.Equipped_Weapon == "Battle Staff + 2" && item_equipped_w == "a")
            {
                weapon_damage = 18;
                Program.Char_Damage += weapon_damage;
                item_equipped_w = "b";
            }
            else if (Program.Equipped_Weapon == "Battle Staff + 3" && item_equipped_w == "a")
            {
                weapon_damage = 19;
                Program.Char_Damage += weapon_damage;
                item_equipped_w = "b";
            }
            else if (Program.Equipped_Weapon == "Battle Staff + 4" && item_equipped_w == "a")
            {
                weapon_damage = 20;
                Program.Char_Damage += weapon_damage;
                item_equipped_w = "b";
            }
            else if (Program.Equipped_Weapon == "Battle Staff + 5" && item_equipped_w == "a")
            {
                weapon_damage = 21;
                Program.Char_Damage += weapon_damage;
                item_equipped_w = "b";
            }
            // Poleaxe Damage
            else if (Program.Equipped_Weapon == "Poleaxe + 0" && item_equipped_w == "a")
            {
                weapon_damage = 7;
                Program.Char_Damage += weapon_damage;
                item_equipped_w = "b";
            }
            else if (Program.Equipped_Weapon == "Poleaxe + 1" && item_equipped_w == "a")
            {
                weapon_damage = 8;
                Program.Char_Damage += weapon_damage;
                item_equipped_w = "b";
            }
            else if (Program.Equipped_Weapon == "Poleaxe + 2" && item_equipped_w == "a")
            {
                weapon_damage = 9;
                Program.Char_Damage += weapon_damage;
                item_equipped_w = "b";
            }
            else if (Program.Equipped_Weapon == "Poleaxe + 3" && item_equipped_w == "a")
            {
                weapon_damage = 10;
                Program.Char_Damage += weapon_damage;
                item_equipped_w = "b";
            }
            else if (Program.Equipped_Weapon == "Poleaxe + 4" && item_equipped_w == "a")
            {
                weapon_damage = 11;
                Program.Char_Damage += weapon_damage;
                item_equipped_w = "b";
            }
            else if (Program.Equipped_Weapon == "Poleaxe + 5" && item_equipped_w == "a")
            {
                weapon_damage = 12;
                Program.Char_Damage += weapon_damage;
                item_equipped_w = "b";
            }
            else if (Program.Equipped_Weapon == "Long Poleaxe + 0" && item_equipped_w == "a")
            {
                weapon_damage = 10;
                Program.Char_Damage += weapon_damage;
                item_equipped_w = "b";
            }
            else if (Program.Equipped_Weapon == "Long Poleaxe + 1" && item_equipped_w == "a")
            {
                weapon_damage = 11;
                Program.Char_Damage += weapon_damage;
                item_equipped_w = "b";
            }
            else if (Program.Equipped_Weapon == "Long Poleaxe + 2" && item_equipped_w == "a")
            {
                weapon_damage = 12;
                Program.Char_Damage += weapon_damage;
                item_equipped_w = "b";
            }
            else if (Program.Equipped_Weapon == "Long Poleaxe + 3" && item_equipped_w == "a")
            {
                weapon_damage = 13;
                Program.Char_Damage += weapon_damage;
                item_equipped_w = "b";
            }
            else if (Program.Equipped_Weapon == "Long Poleaxe + 4" && item_equipped_w == "a")
            {
                weapon_damage = 14;
                Program.Char_Damage += weapon_damage;
                item_equipped_w = "b";
            }
            else if (Program.Equipped_Weapon == "Long Poleaxe + 5" && item_equipped_w == "a")
            {
                weapon_damage = 15;
                Program.Char_Damage += weapon_damage;
                item_equipped_w = "b";
            }
            else if (Program.Equipped_Weapon == "Silver Poleaxe + 0" && item_equipped_w == "a")
            {
                weapon_damage = 13;
                Program.Char_Damage += weapon_damage;
                item_equipped_w = "b";
            }
            else if (Program.Equipped_Weapon == "Silver Poleaxe + 1" && item_equipped_w == "a")
            {
                weapon_damage = 14;
                Program.Char_Damage += weapon_damage;
                item_equipped_w = "b";
            }
            else if (Program.Equipped_Weapon == "Silver Poleaxe + 2" && item_equipped_w == "a")
            {
                weapon_damage = 15;
                Program.Char_Damage += weapon_damage;
                item_equipped_w = "b";
            }
            else if (Program.Equipped_Weapon == "Silver Poleaxe + 3" && item_equipped_w == "a")
            {
                weapon_damage = 16;
                Program.Char_Damage += weapon_damage;
                item_equipped_w = "b";
            }
            else if (Program.Equipped_Weapon == "Silver Poleaxe + 4" && item_equipped_w == "a")
            {
                weapon_damage = 17;
                Program.Char_Damage += weapon_damage;
                item_equipped_w = "b";
            }
            else if (Program.Equipped_Weapon == "Silver Poleaxe + 5" && item_equipped_w == "a")
            {
                weapon_damage = 18;
                Program.Char_Damage += weapon_damage;
                item_equipped_w = "b";
            }
            else if (Program.Equipped_Weapon == "Battle Poleaxe + 0" && item_equipped_w == "a")
            {
                weapon_damage = 16;
                Program.Char_Damage += weapon_damage;
                item_equipped_w = "b";
            }
            else if (Program.Equipped_Weapon == "Battle Poleaxe + 1" && item_equipped_w == "a")
            {
                weapon_damage = 17;
                Program.Char_Damage += weapon_damage;
                item_equipped_w = "b";
            }
            else if (Program.Equipped_Weapon == "Battle Poleaxe + 2" && item_equipped_w == "a")
            {
                weapon_damage = 18;
                Program.Char_Damage += weapon_damage;
                item_equipped_w = "b";
            }
            else if (Program.Equipped_Weapon == "Battle Poleaxe + 3" && item_equipped_w == "a")
            {
                weapon_damage = 19;
                Program.Char_Damage += weapon_damage;
                item_equipped_w = "b";
            }
            else if (Program.Equipped_Weapon == "Battle Poleaxe + 4" && item_equipped_w == "a")
            {
                weapon_damage = 20;
                Program.Char_Damage += weapon_damage;
                item_equipped_w = "b";
            }
            else if (Program.Equipped_Weapon == "Battle Poleaxe + 5" && item_equipped_w == "a")
            {
                weapon_damage = 21;
                Program.Char_Damage += weapon_damage;
                item_equipped_w = "b";
            }
        }

        public static void armourDefence()
        {
            if (Program.Equipped_Armour == "Cloth Robe" && item_equipped_a == "a")
            {
                Program.Char_Defence -= armour_defence;
                item_equipped_a = "b";
            }
            //Swords Damage
            else if (Program.Equipped_Armour == "Cloth Armour + 0" && item_equipped_a == "a")
            {
                armour_defence = 4;
                Program.Char_Defence += armour_defence;
                item_equipped_a = "b";
            }
            else if (Program.Equipped_Armour == "Cloth Armour + 1" && item_equipped_a == "a")
            {
                armour_defence = 5;
                Program.Char_Defence += armour_defence;
                item_equipped_a = "b";
            }
            else if (Program.Equipped_Armour == "Cloth Armour + 2" && item_equipped_a == "a")
            {
                armour_defence = 6;
                Program.Char_Defence += armour_defence;
                item_equipped_a = "b";
            }
            else if (Program.Equipped_Armour == "Cloth Armour + 3" && item_equipped_a == "a")
            {
                armour_defence = 7;
                Program.Char_Defence += armour_defence;
                item_equipped_a = "b";
            }
            else if (Program.Equipped_Armour == "Cloth Armour + 4" && item_equipped_a == "a")
            {
                armour_defence = 8;
                Program.Char_Defence += armour_defence;
                item_equipped_a = "b";
            }
            else if (Program.Equipped_Armour == "Cloth Armour + 5" && item_equipped_a == "a")
            {
                armour_defence = 9;
                Program.Char_Defence += armour_defence;
                item_equipped_a = "b";
            }
            else if (Program.Equipped_Armour == "Leather Armour + 0" && item_equipped_a == "a")
            {
                armour_defence = 7;
                Program.Char_Defence += armour_defence;
                item_equipped_a = "b";
            }
            else if (Program.Equipped_Armour == "Leather Armour + 1" && item_equipped_a == "a")
            {
                armour_defence = 8;
                Program.Char_Defence += armour_defence;
                item_equipped_a = "b";
            }
            else if (Program.Equipped_Armour == "Leather Armour + 2" && item_equipped_a == "a")
            {
                armour_defence = 9;
                Program.Char_Defence += armour_defence;
                item_equipped_a = "b";
            }
            else if (Program.Equipped_Armour == "Leather Armour + 3" && item_equipped_a == "a")
            {
                armour_defence = 10;
                Program.Char_Defence += armour_defence;
                item_equipped_a = "b";
            }
            else if (Program.Equipped_Armour == "Leather Armour + 4" && item_equipped_a == "a")
            {
                armour_defence = 11;
                Program.Char_Defence += armour_defence;
                item_equipped_a = "b";
            }
            else if (Program.Equipped_Armour == "Leather Armour + 5" && item_equipped_a == "a")
            {
                armour_defence = 12;
                Program.Char_Defence += armour_defence;
                item_equipped_a = "b";
            }
            else if (Program.Equipped_Armour == "Chain Armour + 0" && item_equipped_a == "a")
            {
                armour_defence = 10;
                Program.Char_Defence += armour_defence;
                item_equipped_a = "b";
            }
            else if (Program.Equipped_Armour == "Chain Armour + 1" && item_equipped_a == "a")
            {
                armour_defence = 11;
                Program.Char_Defence += armour_defence;
                item_equipped_a = "b";
            }
            else if (Program.Equipped_Armour == "Chain Armour + 2" && item_equipped_a == "a")
            {
                armour_defence = 12;
                Program.Char_Defence += armour_defence;
                item_equipped_a = "b";
            }
            else if (Program.Equipped_Armour == "Chain Armour + 3" && item_equipped_a == "a")
            {
                armour_defence = 13;
                Program.Char_Defence += armour_defence;
                item_equipped_a = "b";
            }
            else if (Program.Equipped_Armour == "Chain Armour + 4" && item_equipped_a == "a")
            {
                armour_defence = 14;
                Program.Char_Defence += armour_defence;
                item_equipped_a = "b";
            }
            else if (Program.Equipped_Armour == "Chain Armour + 5" && item_equipped_a == "a")
            {
                armour_defence = 15;
                Program.Char_Defence += armour_defence;
                item_equipped_a = "b";
            }
            else if (Program.Equipped_Armour == "Battle Armour + 0" && item_equipped_a == "a")
            {
                armour_defence = 13;
                Program.Char_Defence += armour_defence;
                item_equipped_a = "b";
            }
            else if (Program.Equipped_Armour == "Battle Armour + 1" && item_equipped_a == "a")
            {
                armour_defence = 14;
                Program.Char_Defence += armour_defence;
                item_equipped_a = "b";
            }
            else if (Program.Equipped_Armour == "Battle Armour + 2" && item_equipped_a == "a")
            {
                armour_defence = 15;
                Program.Char_Defence += armour_defence;
                item_equipped_a = "b";
            }
            else if (Program.Equipped_Armour == "Battle Armour + 3" && item_equipped_a == "a")
            {
                armour_defence = 16;
                Program.Char_Defence += armour_defence;
                item_equipped_a = "b";
            }
            else if (Program.Equipped_Armour == "Battle Armour + 4" && item_equipped_a == "a")
            {
                armour_defence = 17;
                Program.Char_Defence += armour_defence;
                item_equipped_a = "b";
            }
            else if (Program.Equipped_Armour == "Battle Armour + 5" && item_equipped_a == "a")
            {
                armour_defence = 18;
                Program.Char_Defence += armour_defence;
                item_equipped_a = "b";
            }
        }

    }
}
