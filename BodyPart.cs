namespace theCardGameDemo
{
    public class BodyPart
    {
        public string Name { get; set; }
        public List<Card> Cards { get; private set; }
        public int ExperiencePoints { get; set; }

        public BodyPart(string name)
        {
            Name = name;
            Cards = new List<Card>();
            ExperiencePoints = 0;
        }

        public void AddCard(Card card)
        {
            Cards.Add(card);
        }

        public void RemoveCard(Card card)
        {
            Cards.Remove(card);
        }

        public void ClearCard()
        {
            Cards.Clear();
        }

        public void CalculateExperience()
        {
            ExperiencePoints += Cards.Count * 2;
        }
    }
}
