namespace theCardGameDemo
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.btnDrawCard = new System.Windows.Forms.Button();
            this.lbDeck = new System.Windows.Forms.ListBox();
            this.lblExperience = new System.Windows.Forms.Label();
            this.lblRoundsPlayed = new System.Windows.Forms.Label();
            this.btnCalculateExperience = new System.Windows.Forms.Button();
            this.lblCardEffect = new System.Windows.Forms.Label();
            this.txtCardEffect = new System.Windows.Forms.TextBox();
            this.btnSaveEffect = new System.Windows.Forms.Button();
            this.lbBodyPartHead = new System.Windows.Forms.ListBox();
            this.lbBodyPartArms = new System.Windows.Forms.ListBox();
            this.lbBodyPartLegs = new System.Windows.Forms.ListBox();
            this.lbBodyPartBody = new System.Windows.Forms.ListBox();
            this.lbBodyPartOrgans = new System.Windows.Forms.ListBox();
            this.btnRemoveCardFromPart = new System.Windows.Forms.Button();
            this.SuspendLayout();

            // Draw Card Button
            this.btnDrawCard.Location = new System.Drawing.Point(12, 12);
            this.btnDrawCard.Name = "btnDrawCard";
            this.btnDrawCard.Size = new System.Drawing.Size(120, 40);
            this.btnDrawCard.TabIndex = 3;
            this.btnDrawCard.Text = "Draw Card";
            this.btnDrawCard.UseVisualStyleBackColor = true;
            this.btnDrawCard.Click += new System.EventHandler(this.btnDrawCard_Click);

            // Deck ListBox
            this.lbDeck.FormattingEnabled = true;
            this.lbDeck.Location = new System.Drawing.Point(12, 55);
            this.lbDeck.Name = "lbDeck";
            this.lbDeck.Size = new System.Drawing.Size(320, 200);
            this.lbDeck.TabIndex = 2;
            this.lbDeck.SelectedIndexChanged += new System.EventHandler(this.lbDeck_SelectedIndexChanged);

            // Add Card to Head Button
            this.btnAddCardToHead = new System.Windows.Forms.Button();
            this.btnAddCardToHead.Location = new System.Drawing.Point(364, 50);
            this.btnAddCardToHead.Name = "btnAddCardToHead";
            this.btnAddCardToHead.Size = new System.Drawing.Size(150, 40);
            this.btnAddCardToHead.TabIndex = 11;
            this.btnAddCardToHead.Text = "Add Card to Head";
            this.btnAddCardToHead.UseVisualStyleBackColor = true;
            this.btnAddCardToHead.Click += new System.EventHandler(this.btnAddCardToHead_Click);

            // Add Card to Arms Button
            this.btnAddCardToArms = new System.Windows.Forms.Button();
            this.btnAddCardToArms.Location = new System.Drawing.Point(364, 95);
            this.btnAddCardToArms.Name = "btnAddCardToArms";
            this.btnAddCardToArms.Size = new System.Drawing.Size(150, 40);
            this.btnAddCardToArms.TabIndex = 12;
            this.btnAddCardToArms.Text = "Add Card to Arms";
            this.btnAddCardToArms.UseVisualStyleBackColor = true;
            this.btnAddCardToArms.Click += new System.EventHandler(this.btnAddCardToArms_Click);

            // Add Card to Legs Button
            this.btnAddCardToLegs = new System.Windows.Forms.Button();
            this.btnAddCardToLegs.Location = new System.Drawing.Point(364, 140);
            this.btnAddCardToLegs.Name = "btnAddCardToLegs";
            this.btnAddCardToLegs.Size = new System.Drawing.Size(150, 40);
            this.btnAddCardToLegs.TabIndex = 13;
            this.btnAddCardToLegs.Text = "Add Card to Legs";
            this.btnAddCardToLegs.UseVisualStyleBackColor = true;
            this.btnAddCardToLegs.Click += new System.EventHandler(this.btnAddCardToLegs_Click);

            // Add Card to Body Button
            this.btnAddCardToBody = new System.Windows.Forms.Button();
            this.btnAddCardToBody.Location = new System.Drawing.Point(364, 185);
            this.btnAddCardToBody.Name = "btnAddCardToBody";
            this.btnAddCardToBody.Size = new System.Drawing.Size(150, 40);
            this.btnAddCardToBody.TabIndex = 14;
            this.btnAddCardToBody.Text = "Add Card to Body";
            this.btnAddCardToBody.UseVisualStyleBackColor = true;
            this.btnAddCardToBody.Click += new System.EventHandler(this.btnAddCardToBody_Click);

            // Add Card to Organs Button
            this.btnAddCardToOrgans = new System.Windows.Forms.Button();
            this.btnAddCardToOrgans.Location = new System.Drawing.Point(364, 230);
            this.btnAddCardToOrgans.Name = "btnAddCardToOrgans";
            this.btnAddCardToOrgans.Size = new System.Drawing.Size(150, 40);
            this.btnAddCardToOrgans.TabIndex = 15;
            this.btnAddCardToOrgans.Text = "Add Card to Organs";
            this.btnAddCardToOrgans.UseVisualStyleBackColor = true;
            this.btnAddCardToOrgans.Click += new System.EventHandler(this.btnAddCardToOrgans_Click);

            // Body Part Head ListBox
            this.lbBodyPartHead.FormattingEnabled = true;
            this.lbBodyPartHead.Location = new System.Drawing.Point(12, 470);
            this.lbBodyPartHead.Name = "lbBodyPartHead";
            this.lbBodyPartHead.Size = new System.Drawing.Size(120, 95);
            this.lbBodyPartHead.TabIndex = 16;
            this.lbBodyPartHead.Text = "Head";
            this.lbBodyPartHead.SelectedIndexChanged += new System.EventHandler(this.lbBodyPartHead_SelectedIndexChanged);

            // Body Part Arms ListBox
            this.lbBodyPartArms.FormattingEnabled = true;
            this.lbBodyPartArms.Location = new System.Drawing.Point(138, 470);
            this.lbBodyPartArms.Name = "lbBodyPartArms";
            this.lbBodyPartArms.Size = new System.Drawing.Size(120, 95);
            this.lbBodyPartArms.TabIndex = 17;
            this.lbBodyPartArms.Text = "Arms";
            this.lbBodyPartArms.SelectedIndexChanged += new System.EventHandler(this.lbBodyPartArms_SelectedIndexChanged);

            // Body Part Legs ListBox
            this.lbBodyPartLegs.FormattingEnabled = true;
            this.lbBodyPartLegs.Location = new System.Drawing.Point(264, 470);
            this.lbBodyPartLegs.Name = "lbBodyPartLegs";
            this.lbBodyPartLegs.Size = new System.Drawing.Size(120, 95);
            this.lbBodyPartLegs.TabIndex = 18;
            this.lbBodyPartLegs.Text = "Legs";
            this.lbBodyPartLegs.SelectedIndexChanged += new System.EventHandler(this.lbBodyPartLegs_SelectedIndexChanged);

            // Body Part Body ListBox
            this.lbBodyPartBody.FormattingEnabled = true;
            this.lbBodyPartBody.Location = new System.Drawing.Point(390, 470);
            this.lbBodyPartBody.Name = "lbBodyPartBody";
            this.lbBodyPartBody.Size = new System.Drawing.Size(120, 95);
            this.lbBodyPartBody.TabIndex = 19;
            this.lbBodyPartBody.Text = "Body";
            this.lbBodyPartBody.SelectedIndexChanged += new System.EventHandler(this.lbBodyPartBody_SelectedIndexChanged);

            // Body Part Organs ListBox
            this.lbBodyPartOrgans.FormattingEnabled = true;
            this.lbBodyPartOrgans.Location = new System.Drawing.Point(516, 470);
            this.lbBodyPartOrgans.Name = "lbBodyPartOrgans";
            this.lbBodyPartOrgans.Size = new System.Drawing.Size(120, 95);
            this.lbBodyPartOrgans.TabIndex = 20;
            this.lbBodyPartOrgans.Text = "Organs";
            this.lbBodyPartOrgans.SelectedIndexChanged += new System.EventHandler(this.lbBodyPartOrgans_SelectedIndexChanged);

            // Card Effect Label
            this.lblCardEffect.AutoSize = true;
            this.lblCardEffect.Location = new System.Drawing.Point(12, 250);
            this.lblCardEffect.Name = "lblCardEffect";
            this.lblCardEffect.Size = new System.Drawing.Size(67, 13);
            this.lblCardEffect.TabIndex = 21;
            this.lblCardEffect.Text = "Card Effect:";

            // Card Effect TextBox
            this.txtCardEffect.Location = new System.Drawing.Point(12, 270);
            this.txtCardEffect.Multiline = true;
            this.txtCardEffect.Name = "txtCardEffect";
            this.txtCardEffect.Size = new System.Drawing.Size(272, 100);
            this.txtCardEffect.TabIndex = 22;

            // Save Effect Button
            this.btnSaveEffect.Location = new System.Drawing.Point(12, 380);
            this.btnSaveEffect.Name = "btnSaveEffect";
            this.btnSaveEffect.Size = new System.Drawing.Size(150, 40);
            this.btnSaveEffect.TabIndex = 23;
            this.btnSaveEffect.Text = "Save Effect";
            this.btnSaveEffect.UseVisualStyleBackColor = true;
            this.btnSaveEffect.Click += new System.EventHandler(this.btnSaveEffect_Click);

            // Text labels for Card Effects for each body part
            this.lblHeadEffect = new System.Windows.Forms.Label();
            this.lblHeadEffect.Location = new System.Drawing.Point(12, 450);
            this.lblHeadEffect.Name = "lblHeadEffect";
            this.lblHeadEffect.Size = new System.Drawing.Size(120, 20);
            this.lblHeadEffect.Text = "Head:";

            this.lblArmsEffect = new System.Windows.Forms.Label();
            this.lblArmsEffect.Location = new System.Drawing.Point(138, 450);
            this.lblArmsEffect.Name = "lblArmsEffect";
            this.lblArmsEffect.Size = new System.Drawing.Size(120, 20);
            this.lblArmsEffect.Text = "Arms:";

            this.lblLegsEffect = new System.Windows.Forms.Label();
            this.lblLegsEffect.Location = new System.Drawing.Point(264, 450);
            this.lblLegsEffect.Name = "lblLegsEffect";
            this.lblLegsEffect.Size = new System.Drawing.Size(120, 20);
            this.lblLegsEffect.Text = "Legs:";

            this.lblBodyEffect = new System.Windows.Forms.Label();
            this.lblBodyEffect.Location = new System.Drawing.Point(390, 450);
            this.lblBodyEffect.Name = "lblBodyEffect";
            this.lblBodyEffect.Size = new System.Drawing.Size(120, 20);
            this.lblBodyEffect.Text = "Body:";

            this.lblOrgansEffect = new System.Windows.Forms.Label();
            this.lblOrgansEffect.Location = new System.Drawing.Point(516, 450);
            this.lblOrgansEffect.Name = "lblOrgansEffect";
            this.lblOrgansEffect.Size = new System.Drawing.Size(120, 20);
            this.lblOrgansEffect.Text = "Organs:";

            // Other controls (Experience, Rounds Played, etc.)
            // ...

            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.lbBodyPartHead);
            this.Controls.Add(this.lbBodyPartArms);
            this.Controls.Add(this.lbBodyPartLegs);
            this.Controls.Add(this.lbBodyPartBody);
            this.Controls.Add(this.lbBodyPartOrgans);
            this.Controls.Add(this.btnAddCardToHead);
            this.Controls.Add(this.btnAddCardToArms);
            this.Controls.Add(this.btnAddCardToLegs);
            this.Controls.Add(this.btnAddCardToBody);
            this.Controls.Add(this.btnAddCardToOrgans);
            this.Controls.Add(this.lbDeck);
            this.Controls.Add(this.btnDrawCard);
            this.Controls.Add(this.lblCardEffect);
            this.Controls.Add(this.txtCardEffect);
            this.Controls.Add(this.btnSaveEffect);
            this.Controls.Add(this.lblHeadEffect);
            this.Controls.Add(this.lblArmsEffect);
            this.Controls.Add(this.lblLegsEffect);
            this.Controls.Add(this.lblBodyEffect);
            this.Controls.Add(this.lblOrgansEffect);
            this.Name = "MainForm";
            this.Text = "Card Game Demo";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Button btnDrawCard;
        private System.Windows.Forms.ListBox lbDeck;
        private System.Windows.Forms.Label lblExperience;
        private System.Windows.Forms.Label lblRoundsPlayed;
        private System.Windows.Forms.Button btnCalculateExperience;
        private System.Windows.Forms.Label lblCardEffect;
        private System.Windows.Forms.Label lblHeadEffect;
        private System.Windows.Forms.Label lblArmsEffect;
        private System.Windows.Forms.Label lblLegsEffect;
        private System.Windows.Forms.Label lblBodyEffect;
        private System.Windows.Forms.Label lblOrgansEffect;
        private System.Windows.Forms.TextBox txtCardEffect;
        private System.Windows.Forms.Button btnSaveEffect;
        private System.Windows.Forms.ListBox lbBodyPartHead;
        private System.Windows.Forms.ListBox lbBodyPartArms;
        private System.Windows.Forms.ListBox lbBodyPartLegs;
        private System.Windows.Forms.ListBox lbBodyPartBody;
        private System.Windows.Forms.ListBox lbBodyPartOrgans;
        private System.Windows.Forms.Button btnRemoveCardFromPart;
        private System.Windows.Forms.Button btnAddCardToHead;
        private System.Windows.Forms.Button btnAddCardToArms;
        private System.Windows.Forms.Button btnAddCardToLegs;
        private System.Windows.Forms.Button btnAddCardToBody;
        private System.Windows.Forms.Button btnAddCardToOrgans;
    }
}
