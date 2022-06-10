// This is challenge work for the "C# Players Guide"
// Level 24 "The Card" Challenge
// Create a cards class that accomidates the following:
// - Each card has one of the following colors Red, Green, Blue, Yellow
// - Include a rank for each card (1 - 10, followed by $, %, and &)





public class Card
{
    public CardColor Color { get; }
    public CardRank Rank { get; }

    public Card(CardColor color, CardRank rank)
    {
        Color = color;
        Rank = rank;
    }

    public enum CardColor { Red, Green, Blue, Yellow }
    public enum CardRank { One, Two, Three, Four, Five, Six, Seven, Eight, Nine, Ten, Dollar, Precent, Caret, Ampersand }
}