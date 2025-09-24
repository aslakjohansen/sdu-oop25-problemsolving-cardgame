// -- init

Card[] deck = new Card[20];

Random rand = new Random();

for (int i=0; i<deck.Length ; i++) {
  Suit suit = (Suit) rand.Next(0, (int) Suit.Count);
  int value = rand.Next(1, 14);
  deck[i] = new Card {suit=suit, value=value};
}

// -- main

for (int i=0 ; i<(int)Suit.Count ; i++) {
  int largest = -1;
  
  foreach (Card card in deck) {
    // guard
    if ((int)card.suit != i) continue;
    
    if (card.value > largest) {
      largest = card.value;
    }
  }
  
  Console.WriteLine((Suit)i+": "+largest);
}

// -- data types

enum Suit {
  Diamonds,
  Hearts,
  Spades,
  Clubs,
  Count
}

class Card {
  public int value;
  public Suit suit;
}
