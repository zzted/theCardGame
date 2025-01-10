namespace theCardGameDemo
{
    public class Card
    {
        public int CardNumber { get; set; }
        public string Effect { get; set; }

        public Card(int cardNumber)
        {
            CardNumber = cardNumber;
            Effect = ""; // Default effect is an empty string
        }
    }
}