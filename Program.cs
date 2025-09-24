Card card = new Card {suit=Suit.Diamonds, value=3};

Console.WriteLine(card.value);

enum Suit {
  Diamonds,
  Hearts,
  Spades,
  Clubs
}

class Card {
  public int value;
  public Suit suit;
}
