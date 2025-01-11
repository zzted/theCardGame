using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace theCardGameDemo
{
    public partial class MainForm : Form
    {
        private List<Card> deck;
        private BodyPart[] bodyParts;  // Reference to BodyPart class
        private int selectedCardIndex = -1; // Keep track of the selected card in the deck
        private int roundNumber = 0;
        private bool _ignoreSelectionChanged = false;

        public MainForm()
        {
            InitializeComponent();
            InitializeDeck();
            InitializeBodyParts();
        }

        private void InitializeDeck()
        {
            deck = new List<Card>
            {
                new Card(171), new Card(171), new Card(172), new Card(172),
                new Card(173), new Card(173), new Card(174), new Card(174),
                new Card(175), new Card(176), new Card(177), new Card(177)
            };

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
            DeselectOtherListBoxes(lbDeck);
            // Ensure that the selected index is not -1 (nothing is selected)
            if (lbDeck.SelectedIndex != -1)
            {
                selectedCardIndex = lbDeck.SelectedIndex;
                var selectedCard = deck[selectedCardIndex];
                txtCardEffect.Text = selectedCard.Effect; // Display the effect of the selected card
            }
        }

        private int GetRandomCard()
        {
            Random random = new Random();
            int chance = random.Next(1, 101); // Generate a number between 1 and 100

            if (chance <= 90) // 90% chance for numbers 1 to 170
            {
                return random.Next(1, 171); // Get a number between 1 and 170
            }
            else // 10% chance for numbers 201 to 230
            {
                return random.Next(201, 231); // Get a number between 201 and 230
            }
        }

        private void btnDrawCard_Click(object sender, EventArgs e)
        {
            
            deck.Add(new Card(GetRandomCard()));

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
            }
        }

        // When a card in the Head body part is clicked
        private void lbBodyPartHead_SelectedIndexChanged(object sender, EventArgs e)
        {
            DeselectOtherListBoxes(lbBodyPartHead);
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

        // When a card in the Arms body part is clicked
        private void lbBodyPartArms_SelectedIndexChanged(object sender, EventArgs e)
        {
            DeselectOtherListBoxes(lbBodyPartArms);
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
            DeselectOtherListBoxes(lbBodyPartLegs);
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
            DeselectOtherListBoxes(lbBodyPartBody);
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

        // When a card in the Organs body part is clicked
        private void lbBodyPartOrgans_SelectedIndexChanged(object sender, EventArgs e)
        {
            DeselectOtherListBoxes(lbBodyPartOrgans);
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

        private void DeselectOtherListBoxes(ListBox selectedListBox)
        {
            if (_ignoreSelectionChanged)
                return;

            _ignoreSelectionChanged = true;

            // Iterate through all the controls in the form
            foreach (var control in this.Controls)
            {
                // Check if the control is a ListBox
                if (control is ListBox listBox && listBox != selectedListBox)
                {
                    // Deselect the items in the other list boxes
                    listBox.ClearSelected();
                }
            }

            _ignoreSelectionChanged = false;
        }

        private void btnEndRound_Click(object sender, EventArgs e)
        {
            // Calculate experience for each body part
            foreach (var bodyPart in bodyParts)
            {
                bodyPart.CalculateExperience();
                bodyPart.ClearCard();
            }

            // Update the experience display for each body part (assuming labels for each body part's experience)
            lblHeadExperience.Text = $"EXP: {bodyParts[0].ExperiencePoints}";
            lblArmsExperience.Text = $"EXP: {bodyParts[1].ExperiencePoints}";
            lblLegsExperience.Text = $"EXP: {bodyParts[2].ExperiencePoints}";
            lblBodyExperience.Text = $"EXP: {bodyParts[3].ExperiencePoints}";
            lblOrgansExperience.Text = $"EXP: {bodyParts[4].ExperiencePoints}";
            lblRoundNumber.Text = $"Round# {++this.roundNumber}";

            // Clear all cards from each body part
            lbBodyPartHead.Items.Clear();
            lbBodyPartArms.Items.Clear();
            lbBodyPartLegs.Items.Clear();
            lbBodyPartBody.Items.Clear();
            lbBodyPartOrgans.Items.Clear();

            // Optionally, reset the experience points or display a message
            MessageBox.Show("Round ended! Experience calculated and cards removed.");
        }

        private void btnResetGame_Click(object sender, EventArgs e)
        {
            // Clear the deck
            lbDeck.Items.Clear();

            // Clear all cards from each body part list box
            lbBodyPartHead.Items.Clear();
            lbBodyPartArms.Items.Clear();
            lbBodyPartLegs.Items.Clear();
            lbBodyPartBody.Items.Clear();
            lbBodyPartOrgans.Items.Clear();

            // Reset experience points for each body part
            this.InitializeBodyParts();
            this.InitializeDeck();
            this.roundNumber = 0;

            // Update the experience labels
            lblHeadExperience.Text = "EXP: 0";
            lblArmsExperience.Text = "EXP: 0";
            lblLegsExperience.Text = "EXP: 0";
            lblBodyExperience.Text = "EXP: 0";
            lblOrgansExperience.Text = "EXP: 0";
            lblRoundNumber.Text = "Round# 0";


            // Optionally, reset any other variables or UI elements

            // Show a message confirming the reset
            MessageBox.Show("The game has been reset!");
        }
    }
}
