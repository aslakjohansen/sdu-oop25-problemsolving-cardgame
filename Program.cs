Card[] deck = new Card[20];

Random rand = new Random();

for (int i=0; i<deck.Length ; i++) {
  Suit suit = (Suit) rand.Next(0, (int) Suit.Count);
  int value = rand.Next(1, 13);
  deck[i] = new Card {suit=suit, value=value};
}

foreach (Card card in deck) {
  Console.WriteLine(card.value+" of "+card.suit);
}

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
