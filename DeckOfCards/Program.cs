Console.WriteLine("Running...");
var deck = new Deck();
var card = deck.Cards.First();
Console.WriteLine($"{card.Value} of {card.Suit}");
deck.Shuffle();

card = deck.Cards.First();
Console.WriteLine($"{card.Value} of {card.Suit}");

public enum SuitValue
{
    Clubs,
    Diamonds,
    Hearts,
    Spades
}

public enum FaceValue
{
    Ace = 1,
    Two = 2,
    Three = 3,
    Four = 4,
    Five = 5,
    Six = 6,
    Seven = 7,
    Eight = 8,
    Nine = 9,
    Ten = 10,
    Jack = 11,
    Queen = 12,
    King = 13
}

public class Card
{
    public SuitValue Suit { get; set; }
    public FaceValue Value { get; set; }
}

public class Deck
{
    public List<Card> Cards { get; set; } = new();

    public Deck()
    {
        foreach (SuitValue suit in Enum.GetValues<SuitValue>())
        {

            foreach (FaceValue value in Enum.GetValues<FaceValue>())
            {
               Cards.Add(new Card{Suit = suit, Value = value});
            }
        }
    }

    public void Shuffle()
    {
        Random random = new();
        Cards = Cards.OrderBy(x => random.Next()).ToList();
    }
}