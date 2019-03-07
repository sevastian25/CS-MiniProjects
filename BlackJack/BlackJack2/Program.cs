﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleBlackjack
{
    public enum Suit
    {
        Heart,
        Diamond,
        Spade,
        Club
    }

    public enum Face
    {
        Ace,
        Two,
        Three,
        Four,
        Five,
        Six,
        Seven,
        Eight,
        Nine,
        Ten,
        Jack,
        Queen,
        King,
    }

    public class Card
    {
        public Suit Suit { get; set; }
        public Face Face { get; set; }
        public int Value { get; set; }
    }

    public class Deck
    {
        private List<Card> cards;

        public Deck()
        {
            this.Initialize();
        }

        public void Initialize()
        {
            cards = new List<Card>();

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 13; j++)
                {
                    cards.Add(new Card() { Suit = (Suit)i, Face = (Face)j });

                    if (j <= 8)
                        cards[cards.Count - 1].Value = j + 1;
                    else
                        cards[cards.Count - 1].Value = 10;
                }
            }
        }

        public void Shuffle()
        {
            Random rng = new Random();
            int n = cards.Count;
            while (n > 1)
            {
                n--;
                int k = rng.Next(n + 1);
                Card card = cards[k];
                cards[k] = cards[n];
                cards[n] = card;
            }
        }

        public Card DrawACard()
        {
            if (cards.Count <= 0)
            {
                this.Initialize();
                this.Shuffle();
            }

            Card cardToReturn = cards[cards.Count - 1];
            cards.RemoveAt(cards.Count - 1);
            return cardToReturn;
        }

        public int GetAmountOfRemainingCrads()
        {
            return cards.Count;
        }

        public void PrintDeck()
        {
            int i = 1;
            foreach (Card card in cards)
            {
                Console.WriteLine("Card {0}: {1} of {2}. Value: {3}", i, card.Face, card.Suit, card.Value);
                i++;
            }
        }



    }

    class Program
    {
        static int chips;
        static Deck deck;
        static List<Card> userHand;
        static List<Card> dealerHand;

        static void Main(string[] args)
        {
            Console.Title = "♠♥♣♦ Blackjack Game";
            Console.WriteLine("Welcome to blackjack 0.1a\n");

            chips = 1000;
            deck = new Deck();
            deck.Shuffle();

            while (chips > 0)
            {
                DealHand();
                Console.WriteLine("\nPress any key for the next hand...\n");
                ConsoleKeyInfo userInput = Console.ReadKey(true);
            }

            Console.ReadLine();
        }

        static void DealHand()
        {
            if (deck.GetAmountOfRemainingCrads() < 20)
            {
                deck.Initialize();
                deck.Shuffle();
            }

            Console.WriteLine("Remaining Cards: {0}", deck.GetAmountOfRemainingCrads());
            Console.WriteLine("Current Chips: {0}", chips);
            Console.WriteLine("How much would you like to bet? (1 - {0})", chips);
            string input = Console.ReadLine().Trim().Replace(" ", "");
            int betAmount;
            while (!Int32.TryParse(input, out betAmount) || betAmount < 1 || betAmount > chips)
            {
                Console.WriteLine("amount is illegal. How much would you like to bet? (1 - {0})", chips);
                input = Console.ReadLine().Trim().Replace(" ", "");
            }
            Console.WriteLine();

            userHand = new List<Card>();
            userHand.Add(deck.DrawACard());
            userHand.Add(deck.DrawACard());

            foreach (Card card in userHand)
            {
                if (card.Face == Face.Ace)
                {
                    card.Value += 10;
                    break;
                }
            }

            Console.WriteLine("[Player]");
            Console.WriteLine("Card 1: {0} of {1}", userHand[0].Face, userHand[0].Suit);
            Console.WriteLine("Card 2: {0} of {1}", userHand[1].Face, userHand[1].Suit);
            Console.WriteLine("Total: {0}\n", userHand[0].Value + userHand[1].Value);

            dealerHand = new List<Card>();
            dealerHand.Add(deck.DrawACard());
            dealerHand.Add(deck.DrawACard());

            foreach (Card card in dealerHand)
            {
                if (card.Face == Face.Ace)
                {
                    card.Value += 10;
                    break;
                }
            }

            Console.WriteLine("[Delaer]");
            Console.WriteLine("Card 1: {0} of {1}", dealerHand[0].Face, dealerHand[1].Suit);
            Console.WriteLine("Card 2: [Hole Card]");
            Console.WriteLine("Total: {0}\n", dealerHand[0].Value);

            bool insurance = false; ;

            if (dealerHand[0].Face == Face.Ace)
            {
                Console.WriteLine("Insurance? (y / n)");
                string userInput = Console.ReadLine();

                while (userInput != "y" && userInput != "n")
                {
                    Console.WriteLine("Could not understand. Insurance? (y / n)");
                    userInput = Console.ReadLine();
                }

                if (userInput == "y")
                {
                    insurance = true;
                    //chips -= betAmount / 2;
                    Console.WriteLine("\n[Insurance Accepted!]\n");
                }
                else
                {
                    insurance = false;
                    Console.WriteLine("\n[Insurance Rejected]\n");
                }
            }

            if (dealerHand[0].Face == Face.Ace || dealerHand[0].Value == 10)
            {
                Console.WriteLine("Delaer checks if he has blackjack...\n");
                Thread.Sleep(2000);
                if (dealerHand[0].Value + dealerHand[1].Value == 21)
                {
                    Console.WriteLine("[Delaer]");
                    Console.WriteLine("Card 1: {0} of {1}", dealerHand[0].Face, dealerHand[1].Suit);
                    Console.WriteLine("Card 2: {0} of {1}", dealerHand[1].Face, dealerHand[1].Suit);
                    Console.WriteLine("Total: {0}\n", dealerHand[0].Value + dealerHand[1].Value);

                    Thread.Sleep(2000);

                    int amountLost = 0;

                    if (userHand[0].Value + userHand[1].Value == 21 && insurance)
                    {
                        amountLost = betAmount / 2;
                        chips -= betAmount / 2;
                    }
                    else if (userHand[0].Value + userHand[1].Value != 21 && !insurance)
                    {
                        amountLost = betAmount + betAmount / 2;
                        chips -= betAmount + betAmount / 2;
                    }

                    Console.WriteLine("You lost {0} chips", amountLost);

                    Thread.Sleep(1000);

                    return;
                }
                else
                {
                    Console.WriteLine("Dealer does not have a blackjack, moving on...\n");
                }
            }

            if (userHand[0].Value + userHand[1].Value == 21)
            {
                Console.WriteLine("Blackjack, You Won! ({0} chips)\n", betAmount + betAmount / 2);
                chips += betAmount + betAmount / 2;
                return;
            }

            do
            {
                Console.WriteLine("Please choose a valid option: [(S)tand (H)it]");
                ConsoleKeyInfo userOption = Console.ReadKey(true);
                while (userOption.Key != ConsoleKey.H && userOption.Key != ConsoleKey.S)
                {
                    Console.WriteLine("illegal key. Please choose a valid option: [(S)tand (H)it]");
                    userOption = Console.ReadKey(true);
                }
                Console.WriteLine();

                switch (userOption.Key)
                {
                    case ConsoleKey.H:
                        userHand.Add(deck.DrawACard());
                        Console.WriteLine("Hitted {0} of {1}", userHand[userHand.Count - 1].Face, userHand[userHand.Count - 1].Suit);
                        int totalCardsValue = 0;
                        foreach (Card card in userHand)
                        {
                            totalCardsValue += card.Value;
                        }
                        Console.WriteLine("Total cards value now: {0}\n", totalCardsValue);
                        if (totalCardsValue > 21)
                        {
                            Console.Write("Busted!\n");
                            chips -= betAmount;
                            Thread.Sleep(2000);
                            if (chips <= 0)
                            {
                                buyChips();
                            }
                            else
                            {
                                return;
                            }
                            return;
                        }
                        else if (totalCardsValue == 21)
                        {
                            Console.WriteLine("Good job! I assume you want to stand from now on...\n");
                            Thread.Sleep(2000);
                            continue;
                        }
                        else
                        {
                            continue;
                        }
                        break;

                    case ConsoleKey.S:

                        Console.WriteLine("[Delaer]");
                        Console.WriteLine("Card 1: {0} of {1}", dealerHand[0].Face, dealerHand[1].Suit);
                        Console.WriteLine("Card 2: {0} of {1}", dealerHand[1].Face, dealerHand[1].Suit);

                        int dealerCardsValue = 0;
                        foreach (Card card in dealerHand)
                        {
                            dealerCardsValue += card.Value;
                        }

                        while (dealerCardsValue < 17)
                        {
                            Thread.Sleep(2000);
                            dealerHand.Add(deck.DrawACard());
                            dealerCardsValue = 0;
                            foreach (Card card in dealerHand)
                            {
                                dealerCardsValue += card.Value;
                            }
                            Console.WriteLine("Card {0}: {1} of {2}", dealerHand.Count, dealerHand[dealerHand.Count - 1].Face, dealerHand[dealerHand.Count - 1].Suit);
                        }
                        dealerCardsValue = 0;
                        foreach (Card card in dealerHand)
                        {
                            dealerCardsValue += card.Value;
                        }
                        Console.WriteLine("Total: {0}\n", dealerCardsValue);

                        if (dealerCardsValue > 21)
                        {
                            Console.WriteLine("Dealer bust! You win! ({0} chips)", betAmount);
                            chips += betAmount;
                            return;
                        }
                        else
                        {
                            int playerCardValue = 0;
                            foreach (Card card in userHand)
                            {
                                playerCardValue += card.Value;
                            }

                            if (dealerCardsValue > playerCardValue)
                            {
                                Console.WriteLine("Dealer has {0} and player has {1}, dealer wins!", dealerCardsValue, playerCardValue);
                                chips -= betAmount;
                            }
                            else if (dealerCardsValue < playerCardValue)
                            {
                                Console.WriteLine("Player has {0} and dealer has {1}, player wins!", playerCardValue, dealerCardsValue);
                                chips += betAmount;
                                return;
                            }
                            else if (dealerCardsValue == playerCardValue)
                            {
                                Console.WriteLine("Player has {0} and dealer has {1}, Its a Draw!", playerCardValue, dealerCardsValue);
                                return;
                            }
                            else
                            {
                                Console.WriteLine("Error! 404 Action not found.");
                                return;
                            }
                        }
                        break;

                    default:
                        break;
                }

                Console.ReadLine();
            }
            while (true);
        }


        public static void buyChips()
        {
            Console.WriteLine("Would you like to buy more chips ? (Y/N)");
            char ans = Convert.ToChar(Console.ReadLine().ToUpper());
            Console.Clear();
            switch (ans)
            {
                case 'Y':
                    Console.WriteLine("How many chips would you like to buy ?");
                    Console.WriteLine("10 , 100 , 1000, 10000 , 100000, 1000000");
                    int ans2 = Convert.ToInt32(Console.ReadLine());

                    switch (ans2)
                    {
                        case 10:
                            Console.WriteLine("You successfuly purchased {0} chips.", ans2);
                            chips += ans2;
                            break;
                        case 100:
                            Console.WriteLine("You successfuly purchased {0} chips.", ans2);
                            chips += ans2;
                            break;
                        case 1000:
                            Console.WriteLine("You successfuly purchased {0} chips.", ans2);
                            chips += ans2;
                            break;
                        case 10000:
                            Console.WriteLine("You successfuly purchased {0} chips.", ans2);
                            chips += ans2;
                            break;
                        case 100000:
                            Console.WriteLine("You successfuly purchased {0} chips.", ans2);
                            chips += ans2;
                            break;
                        case 1000000:
                            Thread.Sleep(2000);
                            Console.WriteLine("You successfuly sold your house !");
                            Thread.Sleep(1500);
                            Console.WriteLine("{0} Chips successfuly added to your account.", ans2);
                            chips += ans2;
                            break;
                        default:
                            Console.WriteLine("That is not an option !");
                            break;
                    }

                    break;
                case 'N':
                    Console.WriteLine("Good bye ! See you next time ...");
                    Console.ReadKey();
                    break;
                default:
                    Console.WriteLine("That is not an option !");
                    break;
            }
        }


    }
}