using System;
using System.Collections.Generic;

namespace Blackjack
{
    class Program
    {
        static void Main(string[] args)
        {
            // Blackjack House Rules: One player, blackjack is any Ace + any Face Card, dealer can hit only up to having 5 cards max, player wins if has 5 cards and not over 21, No splitting, Dealer hits on anything under 17
            // Extension: Code the hand split, Requires 5 new drawn cards for the player
            // Extension: Card randomization could be simplified by randomizing the decks (issue is how to randomize each list the same way)
            int aceOfHearts = 1;
            int aceOfDiamonds = 1;
            int aceOfClubs = 1;
            int aceOfSpades = 1;
            int twoOfHearts = 2;
            int twoOfDiamonds = 2;
            int twoOfClubs = 2;
            int twoOfSpades = 2;
            int threeOfHearts = 3;
            int threeOfDiamonds = 3;
            int threeOfClubs = 3;
            int threeOfSpades = 3;
            int fourOfHearts = 4;
            int fourOfDiamonds = 4;
            int fourOfClubs = 4;
            int fourOfSpades = 4;
            int fiveOfHearts = 5;
            int fiveOfDiamonds = 5;
            int fiveOfClubs = 5;
            int fiveOfSpades = 5;
            int sixOfHearts = 6;
            int sixOfDiamonds = 6;
            int sixOfClubs = 6;
            int sixOfSpades = 6;
            int sevenOfHearts = 7;
            int sevenOfDiamonds = 7;
            int sevenOfClubs = 7;
            int sevenOfSpades = 7;
            int eightOfHearts = 8;
            int eightOfDiamonds = 8;
            int eightOfClubs = 8;
            int eightOfSpades = 8;
            int nineOfHearts = 9;
            int nineOfDiamonds = 9;
            int nineOfClubs = 9;
            int nineOfSpades = 9;
            int tenOfHearts = 10;
            int tenOfDiamonds = 10;
            int tenOfClubs = 10;
            int tenOfSpades = 10;
            int jackOfHearts = 10;
            int jackOfDiamonds = 10;
            int jackOfClubs = 10;
            int jackOfSpades = 10;
            int queenOfHearts = 10;
            int queenOfDiamonds = 10;
            int queenOfClubs = 10;
            int queenOfSpades = 10;
            int kingOfHearts = 10;
            int kingOfDiamonds = 10;
            int kingOfClubs = 10;
            int kingOfSpades = 10;
            List<int> deckOfCards = new List<int> {aceOfHearts, aceOfDiamonds, aceOfClubs, aceOfSpades, twoOfHearts, twoOfDiamonds, twoOfClubs, twoOfSpades, threeOfHearts, threeOfDiamonds, threeOfClubs, threeOfSpades, fourOfHearts, fourOfDiamonds, fourOfClubs, fourOfSpades, fiveOfHearts, fiveOfDiamonds, fiveOfClubs, fiveOfSpades, sixOfHearts, sixOfDiamonds, sixOfClubs, sixOfSpades, sevenOfHearts, sevenOfDiamonds, sevenOfClubs, sevenOfSpades, eightOfHearts, eightOfDiamonds, eightOfClubs, eightOfSpades, nineOfHearts, nineOfDiamonds, nineOfClubs, nineOfSpades, tenOfHearts, tenOfDiamonds, tenOfClubs, tenOfSpades, jackOfHearts, jackOfDiamonds, jackOfClubs, jackOfSpades, queenOfHearts, queenOfDiamonds, queenOfClubs, queenOfSpades, kingOfHearts, kingOfDiamonds, kingOfClubs, kingOfSpades };
            List<string> deckOfCardsWords = new List<string> { "Ace Of Hearts", "Ace Of Diamonds", "Ace Of Clubs", "Ace Of Spades", "Two Of Hearts", "Two Of Diamonds", "Two of Clubs", "Two Of Spades", "Three Of Hearts", "Three Of Diamonds", "Three Of Clubs", "Three Of Spades", "Four Of Hearts", "Four Of Diamonds", "Four Of Clubs", "Four Of Spades", "Five Of Hearts", "Five Of Diamonds", "Five Of Clubs", "Five Of Spades", "Six Of Hearts", "Six Of Diamonds", "Six Of Clubs", "Six Of Spades", "Seven Of Hearts", "Seven Of Diamonds", "Seven Of Clubs", "Seven Of Spades", "Eight Of Hearts", "Eight Of Diamonds", "Eight Of Clubs", "Eight Of Spades", "Nine Of Hearts", "Nine Of Diamonds", "Nine Of Clubs", "Nine Of Spades", "Ten Of Hearts", "Ten Of Diamonds", "Ten Of Clubs", "Ten Of Spades", "Jack Of Hearts", "Jack Of Diamonds", "Jack Of Clubs", "Jack Of Spades", "Queen Of Hearts", "Queen Of Diamonds", "Queen Of Clubs", "Queen Of Spades", "King Of Hearts", "King Of Diamonds", "King Of Clubs", "King Of Spades" };
            List<int> faceCards = new List<int> { jackOfHearts, jackOfDiamonds, jackOfClubs, jackOfSpades, queenOfHearts, queenOfDiamonds, queenOfClubs, queenOfSpades, kingOfHearts, kingOfDiamonds, kingOfClubs, kingOfSpades };
            List<string> acceptableResponses = new List<string> { "YES", "NO" };
            List<int> playerHand = new List<int> ();
            List<int> dealerHand = new List<int> ();

            // Randomly select first card
            Random r = new Random();
            int firstIndex = r.Next(deckOfCards.Count); // a random index of the deck
            int firstCard = deckOfCards[firstIndex];
            string firstCardWords = deckOfCardsWords[firstIndex];

            // Remove the first card from the deck
            deckOfCards.Remove(deckOfCards[firstIndex]);
            deckOfCardsWords.Remove(deckOfCardsWords[firstIndex]);

            // Randomly select second card
            int secondIndex = r.Next(deckOfCards.Count); // a random index of the deck
            int secondCard = deckOfCards[secondIndex];
            string secondCardWords = deckOfCardsWords[secondIndex];

            // Remove the second card from the deck
            deckOfCards.Remove(deckOfCards[secondIndex]); 
            deckOfCardsWords.Remove(deckOfCardsWords[secondIndex]);

            // Randomly select third card
            int thirdIndex = r.Next(deckOfCards.Count); // a random index of the deck
            int thirdCard = deckOfCards[thirdIndex];
            string thirdCardWords = deckOfCardsWords[thirdIndex];

            // Remove the third card from the deck
            deckOfCards.Remove(deckOfCards[thirdIndex]);
            deckOfCardsWords.Remove(deckOfCardsWords[thirdIndex]);

            // Randomly select fourth card
            int fourthIndex = r.Next(deckOfCards.Count); // a random index of the deck
            int fourthCard = deckOfCards[fourthIndex];
            string fourthCardWords = deckOfCardsWords[fourthIndex];

            // Remove the fourth card from the deck
            deckOfCards.Remove(deckOfCards[fourthIndex]);
            deckOfCardsWords.Remove(deckOfCardsWords[fourthIndex]);

            // Randomly select fifth card
            int fifthIndex = r.Next(deckOfCards.Count); // a random index of the deck
            int fifthCard = deckOfCards[fifthIndex];
            string fifthCardWords = deckOfCardsWords[fifthIndex];

            // Remove the fifth card from the deck
            deckOfCards.Remove(deckOfCards[fifthIndex]);
            deckOfCardsWords.Remove(deckOfCardsWords[fifthIndex]);

            // Randomly select sixth card
            int sixthIndex = r.Next(deckOfCards.Count); // a random index of the deck
            int sixthCard = deckOfCards[sixthIndex];
            string sixthCardWords = deckOfCardsWords[sixthIndex];

            // Remove the sixth card from the deck
            deckOfCards.Remove(deckOfCards[sixthIndex]);
            deckOfCardsWords.Remove(deckOfCardsWords[sixthIndex]);

            // Randomly select seventh card
            int seventhIndex = r.Next(deckOfCards.Count); // a random index of the deck
            int seventhCard = deckOfCards[seventhIndex];
            string seventhCardWords = deckOfCardsWords[seventhIndex];

            // Remove the seventh card from the deck
            deckOfCards.Remove(deckOfCards[seventhIndex]);
            deckOfCardsWords.Remove(deckOfCardsWords[seventhIndex]);

            // Randomly select first dealer hit
            int eighthIndex = r.Next(deckOfCards.Count); // a random index of the deck
            int eighthCard = deckOfCards[eighthIndex];
            string eighthCardWords = deckOfCardsWords[eighthIndex];

            // Remove the 8th card from the deck
            deckOfCards.Remove(deckOfCards[eighthIndex]);
            deckOfCardsWords.Remove(deckOfCardsWords[eighthIndex]);

            // Randomly select second dealer hit
            int ninthIndex = r.Next(deckOfCards.Count); // a random index of the deck
            int ninthCard = deckOfCards[ninthIndex];
            string ninthCardWords = deckOfCardsWords[ninthIndex];

            // Remove the 9th card from the deck
            deckOfCards.Remove(deckOfCards[ninthIndex]);
            deckOfCardsWords.Remove(deckOfCardsWords[ninthIndex]);

            // Randomly select third dealer hit
            int tenthIndex = r.Next(deckOfCards.Count); // a random index of the deck
            int tenthCard = deckOfCards[tenthIndex];
            string tenthCardWords = deckOfCardsWords[tenthIndex];

            // Remove the 10th card from the deck
            deckOfCards.Remove(deckOfCards[tenthIndex]);
            deckOfCardsWords.Remove(deckOfCardsWords[tenthIndex]);

            // Welcome message
            Console.WriteLine("Welcome to Blackjack! Press Enter to start.");
            Console.ReadLine();

            // Declare player starting hand and dealer hand
            int playerHandTotal = firstCard + thirdCard;
            playerHand.Add(firstCard);
            playerHand.Add(thirdCard);
            int dealerHandTotal = secondCard + fourthCard;
            dealerHand.Add(secondCard);
            dealerHand.Add(fourthCard);
            Console.WriteLine($"Your first card is the {firstCardWords} and your second card is the {thirdCardWords} for a total of {TotalWithAceOption(playerHand, playerHandTotal)}. \nThe dealer is showing the {fourthCardWords}.");

            // Check for blackjack
            bool blackjackCheck = CheckForBlackjack(firstCard, thirdCard, faceCards);
            if (blackjackCheck == true)
            {
                Console.WriteLine("Blackjack! You Win!");
                goto End;
            }

            // Ask to hit or stand
            Console.WriteLine("Would you like another card? Reply Yes or No.");
            string firstChoice = Console.ReadLine();
            firstChoice = firstChoice.ToUpper();
            while (!acceptableResponses.Contains(firstChoice)) // Makes sure response is in acceptable range
            {
                Console.WriteLine("Please reply Yes or No.");
                firstChoice = Console.ReadLine();
                firstChoice = firstChoice.ToUpper();
            }

            // Player Choices
            if (firstChoice == "YES") // Third Card
            {
                playerHandTotal += fifthCard;
                playerHand.Add(fifthCard);
                Console.WriteLine($"The {fifthCardWords} is added to your hand. You now have the {firstCardWords}, the {thirdCardWords}, and the {fifthCardWords} for a total of {TotalWithAceOption(playerHand, playerHandTotal)}.");
                if (playerHandTotal > 21)
                {
                    Console.WriteLine("Your hand total exceeds 21. You Lose.");
                    goto End;
                }
                else
                {
                    Console.WriteLine("Would you like another card? Reply Yes or No.");
                    string secondChoice = Console.ReadLine();
                    secondChoice = secondChoice.ToUpper();
                    while (!acceptableResponses.Contains(secondChoice)) // Makes sure response is in acceptable range
                    {
                        Console.WriteLine("Please reply Yes or No.");
                        secondChoice = Console.ReadLine();
                        secondChoice = secondChoice.ToUpper();
                    }
                    if (secondChoice == "YES") // Fourth Card
                    {
                        playerHandTotal += sixthCard;
                        playerHand.Add(sixthCard);
                        Console.WriteLine($"The {sixthCardWords} is added to your hand. You now have the {firstCardWords}, the {thirdCardWords}, the {fifthCardWords}, and the {sixthCardWords} for a total of {TotalWithAceOption(playerHand, playerHandTotal)}.");
                        if (playerHandTotal > 21)
                        {
                            Console.WriteLine("Your hand total exceeds 21. You Lose.");
                            goto End;
                        }
                        else
                        {
                            Console.WriteLine("Would you like another card? Reply Yes or No.");
                            string thirdChoice = Console.ReadLine();
                            thirdChoice = thirdChoice.ToUpper();
                            while (!acceptableResponses.Contains(thirdChoice)) // Makes sure response is in acceptable range
                            {
                                Console.WriteLine("Please reply Yes or No.");
                                thirdChoice = Console.ReadLine();
                                thirdChoice = thirdChoice.ToUpper();
                            }
                            if (thirdChoice == "YES") // Fifth Card
                            {
                                playerHandTotal += seventhCard;
                                playerHand.Add(seventhCard);
                                Console.WriteLine($"The {seventhCardWords} is added to your hand. You now have the {firstCardWords}, the {thirdCardWords}, the {fifthCardWords}, the {sixthCardWords}, and the {seventhCardWords} for a total of {TotalWithAceOption(playerHand, playerHandTotal)}.");
                                if (playerHandTotal > 21)
                                {
                                    Console.WriteLine("Your hand total exceeds 21. You Lose.");
                                    goto End;
                                }
                                else // 5 cards winner
                                {
                                    Console.WriteLine("You managed to get 5 cards without busting! Congratulations, You Win!");
                                    goto End;
                                }
                            }
                            else {}// Third Choice No
                        }
                    }
                    else {} // Second Choice No
                }
            }
            else {} // First Choice No

            // Dealer Decisions
            Console.WriteLine($"The dealer reveals their hidden card. Its the {secondCardWords}.");
            if (dealerHandTotal < 17) // dealer first hit
            {
                dealerHandTotal += eighthCard;
                dealerHand.Add(eighthCard);
                Console.WriteLine($"The dealer hits. The dealer receives the {eighthCardWords}. The dealer now has the {secondCardWords}, the {fourthCardWords}, and the {eighthCardWords} for a total of {dealerHandTotal}.");
                if (dealerHandTotal > 21)
                {
                    Console.WriteLine($"The dealer busts. You Win!");
                }
                else if (dealerHandTotal >= 17)
                {
                    Console.WriteLine($"The dealer stands.");
                    if (dealerHandTotal >= playerHandTotal + AddTheAce(playerHand, playerHandTotal))
                    {
                        Console.WriteLine($"The dealer's {dealerHandTotal} beats your {playerHandTotal + AddTheAce(playerHand, playerHandTotal)}. You Lose.");
                    }
                    else
                    {
                        Console.WriteLine($"Your {playerHandTotal + AddTheAce(playerHand, playerHandTotal)} beats the dealer's {dealerHandTotal}. You Win!");
                    }
                }
                else // dealer second hit
                {
                    dealerHandTotal += ninthCard;
                    dealerHand.Add(ninthCard);
                    Console.WriteLine($"The dealer hits. The dealer receives the {ninthCardWords}. The dealer now has the {secondCardWords}, the {fourthCardWords}, the {eighthCardWords}, and the {ninthCardWords} for a total of {dealerHandTotal}.");
                    if (dealerHandTotal > 21)
                    {
                        Console.WriteLine($"The dealer busts. You Win!");
                    }
                    else if (dealerHandTotal >= 17)
                    {
                        Console.WriteLine($"The dealer stands.");
                        if (dealerHandTotal >= playerHandTotal + AddTheAce(playerHand, playerHandTotal))
                        {
                            Console.WriteLine($"The dealer's {dealerHandTotal} beats your {playerHandTotal + AddTheAce(playerHand, playerHandTotal)}. You Lose.");
                        }
                        else
                        {
                            Console.WriteLine($"Your {playerHandTotal + AddTheAce(playerHand, playerHandTotal)} beats the dealer's {dealerHandTotal}. You Win!");
                        }
                    }
                    else // dealer third hit
                    {
                        dealerHandTotal += tenthCard;
                        dealerHand.Add(tenthCard);
                        Console.WriteLine($"The dealer hits. The dealer receives the {tenthCardWords}. The dealer now has the {secondCardWords}, the {fourthCardWords}, the {eighthCardWords}, the {ninthCardWords}, and the {tenthCardWords} for a total of {dealerHandTotal}.");
                        if (dealerHandTotal > 21)
                        {
                            Console.WriteLine($"The dealer busts. You Win!");
                        }
                        else
                        {
                            Console.WriteLine($"The dealer stands.");
                            if (dealerHandTotal >= playerHandTotal + AddTheAce(playerHand, playerHandTotal))
                            {
                                Console.WriteLine($"The dealer's {dealerHandTotal} beats your {playerHandTotal + AddTheAce(playerHand, playerHandTotal)}. You Lose.");
                            }
                            else
                            {
                                Console.WriteLine($"Your {playerHandTotal + AddTheAce(playerHand, playerHandTotal)} beats the dealer's {dealerHandTotal}. You Win!");
                            }
                        }
                    }
                }
            }
            else // dealer stands
            {
                Console.WriteLine($"The dealer stands. The dealer has the {secondCardWords} and the {fourthCardWords}, for a total of {dealerHandTotal}.");
                if (dealerHandTotal >= playerHandTotal + AddTheAce(playerHand, playerHandTotal))
                {
                    Console.WriteLine($"The dealer's {dealerHandTotal} beats your {playerHandTotal + AddTheAce(playerHand, playerHandTotal)}. You Lose.");
                }
                else
                {
                    Console.WriteLine($"Your {playerHandTotal + AddTheAce(playerHand, playerHandTotal)} beats the dealer's {dealerHandTotal}. You Win!");
                }
            }
        End:;
        }
        static bool CheckForBlackjack(int cardOne, int cardTwo, List<int> listOfFaceCards)
        {
            if ((cardOne == 1 || cardTwo == 1) & (cardOne + cardTwo == 11) & (listOfFaceCards.Contains(cardOne) || listOfFaceCards.Contains(cardTwo))) // checks for blackjack
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        static int AddTheAce(List<int> playersCards, int currentHandTotal)
        {
            if (playersCards.Contains(1) & currentHandTotal <= 11)
            {
                return 10;
            }
            else
            {
                return 0;
            }
        }
        static string TotalWithAceOption(List<int> playersCards, int myHandTotal)
        {
            if (playersCards.Contains(1) & myHandTotal <= 11)
            {
                return $"{myHandTotal} or {myHandTotal + 10}";
            }
            else
            {
                return $"{myHandTotal}";
            }
        }
    }
}
