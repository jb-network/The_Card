// This is challenge work for the "C# Players Guide"
// Level 24 "The Card" Challenge
// Create a cards class that accomidates the following:
// - Each card has one of the following colors Red, Green, Blue, Yellow
// - Include a rank for each card (1 - 10, followed by $, %, and &)

//Type CardColor and CardRank set up by enum

CardColor[] card_color = new CardColor[] {CardColor.Red, CardColor.Green, CardColor.Blue, CardColor.Yellow};
CardRank[] card_rank = new CardRank[] { CardRank.One, CardRank.Two, CardRank.Three, CardRank.Four, CardRank.Five, CardRank.Six, 
    CardRank.Seven, CardRank.Seven, CardRank.Eight, CardRank.Nine, CardRank.Ten, 
    CardRank.Dollar, CardRank.Percent, CardRank.Caret, CardRank.Ampersand };

foreach (CardColor color in card_color)
{
    foreach (CardRank rank in card_rank)
    {
        Card NewCard = new Card(color, rank);
        String CardID = Card.CardIDCheck(rank);
        Console.WriteLine($"The {NewCard.Color} {NewCard.Rank}. \nThis is a {CardID}.\n");
    }
}
Console.WriteLine("Press any key to end the program");
Console.ReadKey();


public class Card
{
    public CardColor Color { get; } //Type CardColor based on enum
    public CardRank Rank { get; } //Type CardRank based on enum

    public Card(CardColor color, CardRank rank)
    {
        Color = color;
        Rank = rank;
    }

    // Method to determine if card is a symbol or a number
    internal static string CardIDCheck(CardRank rank)
    {
        string CardCheckTracker;
        if (rank == CardRank.Ampersand || rank == CardRank.Caret || rank == CardRank.Percent || rank == CardRank.Dollar) return CardCheckTracker = "Symbol Card";
        else return CardCheckTracker = "Number Card";
    }

}

//enum for Rank and Color
    public enum CardColor { Red, Green, Blue, Yellow }
    public enum CardRank { One, Two, Three, Four, Five, Six, Seven, Eight, Nine, Ten, Dollar, Percent, Caret, Ampersand }
