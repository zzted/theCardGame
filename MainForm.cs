using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace theCardGameDemo
{
    public partial class MainForm : Form
    {
        private List<int> cardPool;
        private List<Card> deck;
        private BodyPart[] bodyParts;  // Reference to BodyPart class
        private int selectedCardIndex = -1; // Keep track of the selected card in the deck

        public MainForm()
        {
            InitializeComponent();
            InitializeCardPoolAndDeck();
            InitializeBodyParts();
        }

        private void InitializeCardPoolAndDeck()
        {
            cardPool = new List<int>();
            deck = new List<Card>
            {
                new Card(171), new Card(171), new Card(172), new Card(172),
                new Card(173), new Card(173), new Card(174), new Card(174),
                new Card(175), new Card(176), new Card(177), new Card(177)
            };

            for (int i = 1; i <= 180; i++)
            {
                cardPool.Add(i);
            }

            for (int i = 201; i <= 230; i++)
            {
                cardPool.Add(i);
            }

            UpdateDeckDisplay();
        }

        private void InitializeBodyParts()
        {
            bodyParts = new BodyPart[]
            {
                new BodyPart("Head"),
                new BodyPart("Arms"),
                new BodyPart("Legs"),
                new BodyPart("Body"),
                new BodyPart("Internal Organs")
            };
        }

        private void UpdateDeckDisplay()
        {
            lbDeck.Items.Clear();
            foreach (var card in deck)
            {
                lbDeck.Items.Add(card.CardNumber); // Show only the card number in the deck list
            }
        }

        // This method will be called when a card in the deck is clicked
        private void lbDeck_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Ensure that the selected index is not -1 (nothing is selected)
            if (lbDeck.SelectedIndex != -1)
            {
                selectedCardIndex = lbDeck.SelectedIndex;
                var selectedCard = deck[selectedCardIndex];
                txtCardEffect.Text = selectedCard.Effect; // Display the effect of the selected card
            }
        }

        private void btnDrawCard_Click(object sender, EventArgs e)
        {
            if (cardPool.Count == 0)
            {
                MessageBox.Show("No cards left in the pool.");
                return;
            }

            Random random = new Random();
            int randomIndex = random.Next(cardPool.Count);

            int drawnCard = cardPool[randomIndex];
            cardPool.RemoveAt(randomIndex);
            deck.Add(new Card(drawnCard));

            UpdateDeckDisplay();
        }

        // Add selected card to Head
        private void btnAddCardToHead_Click(object sender, EventArgs e)
        {
            if (selectedCardIndex != -1)
            {
                var selectedCard = deck[selectedCardIndex];
                bodyParts[0].AddCard(selectedCard);  // Head is the first part
                deck.RemoveAt(selectedCardIndex);
                UpdateDeckDisplay();
                UpdateBodyPartsDisplay();
                MessageBox.Show($"Card {selectedCard.CardNumber} added to Head.");
            }
        }

        // Add selected card to Arms
        private void btnAddCardToArms_Click(object sender, EventArgs e)
        {
            if (selectedCardIndex != -1)
            {
                var selectedCard = deck[selectedCardIndex];
                bodyParts[1].AddCard(selectedCard);  // Arms is the second part
                deck.RemoveAt(selectedCardIndex);
                UpdateDeckDisplay();
                UpdateBodyPartsDisplay();
                MessageBox.Show($"Card {selectedCard} added to Arms.");
            }
        }

        // Add selected card to Legs
        private void btnAddCardToLegs_Click(object sender, EventArgs e)
        {
            if (selectedCardIndex != -1)
            {
                var selectedCard = deck[selectedCardIndex];
                bodyParts[2].AddCard(selectedCard);  // Legs is the third part
                deck.RemoveAt(selectedCardIndex);
                UpdateDeckDisplay();
                UpdateBodyPartsDisplay();
                MessageBox.Show($"Card {selectedCard} added to Legs.");
            }
        }

        // Add selected card to Body
        private void btnAddCardToBody_Click(object sender, EventArgs e)
        {
            if (selectedCardIndex != -1)
            {
                var selectedCard = deck[selectedCardIndex];
                bodyParts[3].AddCard(selectedCard);  // Body is the fourth part
                deck.RemoveAt(selectedCardIndex);
                UpdateDeckDisplay();
                UpdateBodyPartsDisplay();
                MessageBox.Show($"Card {selectedCard} added to Body.");
            }
        }

        // Add selected card to Internal Organs
        private void btnAddCardToOrgans_Click(object sender, EventArgs e)
        {
            if (selectedCardIndex != -1)
            {
                var selectedCard = deck[selectedCardIndex];
                bodyParts[4].AddCard(selectedCard);  // Internal Organs is the fifth part
                deck.RemoveAt(selectedCardIndex);
                UpdateDeckDisplay();
                UpdateBodyPartsDisplay();
                MessageBox.Show($"Card {selectedCard} added to Internal Organs.");
            }
        }

        private void UpdateBodyPartsDisplay()
        {
            lbBodyPartHead.Items.Clear();
            lbBodyPartArms.Items.Clear();
            lbBodyPartLegs.Items.Clear();
            lbBodyPartBody.Items.Clear();
            lbBodyPartOrgans.Items.Clear();

            foreach (var part in bodyParts)
            {
                foreach (var card in part.Cards)
                {
                    switch (part.Name)
                    {
                        case "Head":
                            lbBodyPartHead.Items.Add(card.CardNumber);
                            break;
                        case "Arms":
                            lbBodyPartArms.Items.Add(card.CardNumber);
                            break;
                        case "Legs":
                            lbBodyPartLegs.Items.Add(card.CardNumber);
                            break;
                        case "Body":
                            lbBodyPartBody.Items.Add(card.CardNumber);
                            break;
                        case "Internal Organs":
                            lbBodyPartOrgans.Items.Add(card.CardNumber);
                            break;
                    }
                }
            }
        }

        private void btnSaveEffect_Click(object sender, EventArgs e)
        {
            if (selectedCardIndex != -1)
            {
                var selectedCard = deck[selectedCardIndex];
                selectedCard.Effect = txtCardEffect.Text;
                MessageBox.Show("Card effect saved successfully!");
            }
        }

        // When a card in the Head body part is clicked
        private void lbBodyPartHead_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbBodyPartHead.SelectedIndex != -1)
            {
                selectedCardIndex = lbBodyPartHead.SelectedIndex;
                var selectedCard = bodyParts[0].Cards[selectedCardIndex];
                if (selectedCard != null)
                {
                    txtCardEffect.Text = selectedCard.Effect;
                }
            }
        }

        // Similar handlers for other body parts (Arms, Legs, Body, Internal Organs)
        private void lbBodyPartArms_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbBodyPartArms.SelectedIndex != -1)
            {
                selectedCardIndex = lbBodyPartArms.SelectedIndex;
                var selectedCard = bodyParts[1].Cards[selectedCardIndex];
                if (selectedCard != null)
                {
                    txtCardEffect.Text = selectedCard.Effect;
                }
            }
        }

      

        // When a card in the Legs body part is clicked
        private void lbBodyPartLegs_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbBodyPartLegs.SelectedIndex != -1)
            {
                selectedCardIndex = lbBodyPartLegs.SelectedIndex;
                var selectedCard = bodyParts[2].Cards[selectedCardIndex];
                if (selectedCard != null)
                {
                    txtCardEffect.Text = selectedCard.Effect;
                }
            }
        }

        // When a card in the Body part is clicked
        private void lbBodyPartBody_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbBodyPartBody.SelectedIndex != -1)
            {
                selectedCardIndex = lbBodyPartBody.SelectedIndex;
                var selectedCard = bodyParts[3].Cards[selectedCardIndex];
                if (selectedCard != null)
                {
                    txtCardEffect.Text = selectedCard.Effect;
                }
            }
        }

        // When a card in the Internal Organs body part is clicked
        private void lbBodyPartOrgans_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbBodyPartOrgans.SelectedIndex != -1)
            {
                selectedCardIndex = lbBodyPartOrgans.SelectedIndex;
                var selectedCard = bodyParts[4].Cards[selectedCardIndex];
                if (selectedCard != null)
                {
                    txtCardEffect.Text = selectedCard.Effect;
                }
            }
        }
    }
}
