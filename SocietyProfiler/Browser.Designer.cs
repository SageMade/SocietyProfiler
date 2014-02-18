namespace SocietyProfiler
{
    partial class frm_browser
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.trv_browserList = new System.Windows.Forms.TreeView();
            this.lbl_name = new System.Windows.Forms.Label();
            this.lbl_profileName = new System.Windows.Forms.Label();
            this.lbl_gender = new System.Windows.Forms.Label();
            this.lbl_profileGender = new System.Windows.Forms.Label();
            this.lbl_sexuality = new System.Windows.Forms.Label();
            this.lbl_profileSexuality = new System.Windows.Forms.Label();
            this.lbl_courage = new System.Windows.Forms.Label();
            this.lbl_profileCourage = new System.Windows.Forms.Label();
            this.lbl_profileEmpathy = new System.Windows.Forms.Label();
            this.lbl_empathy = new System.Windows.Forms.Label();
            this.lbl_greed = new System.Windows.Forms.Label();
            this.lbl_profileGreed = new System.Windows.Forms.Label();
            this.lbl_motivation = new System.Windows.Forms.Label();
            this.lbl_profileMotivation = new System.Windows.Forms.Label();
            this.lbl_profileCharisma = new System.Windows.Forms.Label();
            this.lbl_charisma = new System.Windows.Forms.Label();
            this.lbl_profileEmotion = new System.Windows.Forms.Label();
            this.lbl_emotion = new System.Windows.Forms.Label();
            this.lbl_profileHumor = new System.Windows.Forms.Label();
            this.lbl_humor = new System.Windows.Forms.Label();
            this.lbl_profileCompassion = new System.Windows.Forms.Label();
            this.lbl_compassion = new System.Windows.Forms.Label();
            this.lbl_profileAdaptibility = new System.Windows.Forms.Label();
            this.lbl_adaptibility = new System.Windows.Forms.Label();
            this.lbl_profileOptimism = new System.Windows.Forms.Label();
            this.lbl_optimism = new System.Windows.Forms.Label();
            this.lbl_profileIngenuity = new System.Windows.Forms.Label();
            this.lbl_ingenuity = new System.Windows.Forms.Label();
            this.lbl_profileConfidence = new System.Windows.Forms.Label();
            this.lbl_confidence = new System.Windows.Forms.Label();
            this.lbl_profileIntelligence = new System.Windows.Forms.Label();
            this.lbl_intelligence = new System.Windows.Forms.Label();
            this.grp_info = new System.Windows.Forms.GroupBox();
            this.btn_regen = new System.Windows.Forms.Button();
            this.grp_info.SuspendLayout();
            this.SuspendLayout();
            // 
            // trv_browserList
            // 
            this.trv_browserList.Location = new System.Drawing.Point(12, 12);
            this.trv_browserList.Name = "trv_browserList";
            this.trv_browserList.Size = new System.Drawing.Size(145, 355);
            this.trv_browserList.TabIndex = 0;
            this.trv_browserList.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.trv_browserList_AfterSelect);
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Location = new System.Drawing.Point(6, 16);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(41, 13);
            this.lbl_name.TabIndex = 1;
            this.lbl_name.Text = "Name: ";
            // 
            // lbl_profileName
            // 
            this.lbl_profileName.AutoSize = true;
            this.lbl_profileName.Location = new System.Drawing.Point(64, 16);
            this.lbl_profileName.Name = "lbl_profileName";
            this.lbl_profileName.Size = new System.Drawing.Size(57, 13);
            this.lbl_profileName.TabIndex = 2;
            this.lbl_profileName.Text = "[unknown]";
            // 
            // lbl_gender
            // 
            this.lbl_gender.AutoSize = true;
            this.lbl_gender.Location = new System.Drawing.Point(6, 35);
            this.lbl_gender.Name = "lbl_gender";
            this.lbl_gender.Size = new System.Drawing.Size(45, 13);
            this.lbl_gender.TabIndex = 3;
            this.lbl_gender.Text = "Gender:";
            // 
            // lbl_profileGender
            // 
            this.lbl_profileGender.AutoSize = true;
            this.lbl_profileGender.Location = new System.Drawing.Point(64, 35);
            this.lbl_profileGender.Name = "lbl_profileGender";
            this.lbl_profileGender.Size = new System.Drawing.Size(57, 13);
            this.lbl_profileGender.TabIndex = 4;
            this.lbl_profileGender.Text = "[unknown]";
            // 
            // lbl_sexuality
            // 
            this.lbl_sexuality.AutoSize = true;
            this.lbl_sexuality.Location = new System.Drawing.Point(6, 54);
            this.lbl_sexuality.Name = "lbl_sexuality";
            this.lbl_sexuality.Size = new System.Drawing.Size(52, 13);
            this.lbl_sexuality.TabIndex = 5;
            this.lbl_sexuality.Text = "Sexuality:";
            // 
            // lbl_profileSexuality
            // 
            this.lbl_profileSexuality.AutoSize = true;
            this.lbl_profileSexuality.Location = new System.Drawing.Point(64, 54);
            this.lbl_profileSexuality.Name = "lbl_profileSexuality";
            this.lbl_profileSexuality.Size = new System.Drawing.Size(57, 13);
            this.lbl_profileSexuality.TabIndex = 6;
            this.lbl_profileSexuality.Text = "[unknown]";
            // 
            // lbl_courage
            // 
            this.lbl_courage.AutoSize = true;
            this.lbl_courage.Location = new System.Drawing.Point(9, 94);
            this.lbl_courage.Name = "lbl_courage";
            this.lbl_courage.Size = new System.Drawing.Size(50, 13);
            this.lbl_courage.TabIndex = 7;
            this.lbl_courage.Text = "Courage:";
            // 
            // lbl_profileCourage
            // 
            this.lbl_profileCourage.AutoSize = true;
            this.lbl_profileCourage.Location = new System.Drawing.Point(82, 94);
            this.lbl_profileCourage.Name = "lbl_profileCourage";
            this.lbl_profileCourage.Size = new System.Drawing.Size(57, 13);
            this.lbl_profileCourage.TabIndex = 8;
            this.lbl_profileCourage.Text = "[unknown]";
            // 
            // lbl_profileEmpathy
            // 
            this.lbl_profileEmpathy.AutoSize = true;
            this.lbl_profileEmpathy.Location = new System.Drawing.Point(82, 112);
            this.lbl_profileEmpathy.Name = "lbl_profileEmpathy";
            this.lbl_profileEmpathy.Size = new System.Drawing.Size(57, 13);
            this.lbl_profileEmpathy.TabIndex = 10;
            this.lbl_profileEmpathy.Text = "[unknown]";
            // 
            // lbl_empathy
            // 
            this.lbl_empathy.AutoSize = true;
            this.lbl_empathy.Location = new System.Drawing.Point(9, 112);
            this.lbl_empathy.Name = "lbl_empathy";
            this.lbl_empathy.Size = new System.Drawing.Size(51, 13);
            this.lbl_empathy.TabIndex = 9;
            this.lbl_empathy.Text = "Empathy:";
            // 
            // lbl_greed
            // 
            this.lbl_greed.AutoSize = true;
            this.lbl_greed.Location = new System.Drawing.Point(9, 130);
            this.lbl_greed.Name = "lbl_greed";
            this.lbl_greed.Size = new System.Drawing.Size(39, 13);
            this.lbl_greed.TabIndex = 11;
            this.lbl_greed.Text = "Greed:";
            // 
            // lbl_profileGreed
            // 
            this.lbl_profileGreed.AutoSize = true;
            this.lbl_profileGreed.Location = new System.Drawing.Point(82, 130);
            this.lbl_profileGreed.Name = "lbl_profileGreed";
            this.lbl_profileGreed.Size = new System.Drawing.Size(57, 13);
            this.lbl_profileGreed.TabIndex = 12;
            this.lbl_profileGreed.Text = "[unknown]";
            // 
            // lbl_motivation
            // 
            this.lbl_motivation.AutoSize = true;
            this.lbl_motivation.Location = new System.Drawing.Point(9, 148);
            this.lbl_motivation.Name = "lbl_motivation";
            this.lbl_motivation.Size = new System.Drawing.Size(59, 13);
            this.lbl_motivation.TabIndex = 13;
            this.lbl_motivation.Text = "Motivation:";
            // 
            // lbl_profileMotivation
            // 
            this.lbl_profileMotivation.AutoSize = true;
            this.lbl_profileMotivation.Location = new System.Drawing.Point(82, 148);
            this.lbl_profileMotivation.Name = "lbl_profileMotivation";
            this.lbl_profileMotivation.Size = new System.Drawing.Size(57, 13);
            this.lbl_profileMotivation.TabIndex = 14;
            this.lbl_profileMotivation.Text = "[unknown]";
            // 
            // lbl_profileCharisma
            // 
            this.lbl_profileCharisma.AutoSize = true;
            this.lbl_profileCharisma.Location = new System.Drawing.Point(82, 166);
            this.lbl_profileCharisma.Name = "lbl_profileCharisma";
            this.lbl_profileCharisma.Size = new System.Drawing.Size(57, 13);
            this.lbl_profileCharisma.TabIndex = 16;
            this.lbl_profileCharisma.Text = "[unknown]";
            // 
            // lbl_charisma
            // 
            this.lbl_charisma.AutoSize = true;
            this.lbl_charisma.Location = new System.Drawing.Point(9, 166);
            this.lbl_charisma.Name = "lbl_charisma";
            this.lbl_charisma.Size = new System.Drawing.Size(53, 13);
            this.lbl_charisma.TabIndex = 15;
            this.lbl_charisma.Text = "Charisma:";
            // 
            // lbl_profileEmotion
            // 
            this.lbl_profileEmotion.AutoSize = true;
            this.lbl_profileEmotion.Location = new System.Drawing.Point(82, 220);
            this.lbl_profileEmotion.Name = "lbl_profileEmotion";
            this.lbl_profileEmotion.Size = new System.Drawing.Size(57, 13);
            this.lbl_profileEmotion.TabIndex = 22;
            this.lbl_profileEmotion.Text = "[unknown]";
            // 
            // lbl_emotion
            // 
            this.lbl_emotion.AutoSize = true;
            this.lbl_emotion.Location = new System.Drawing.Point(9, 220);
            this.lbl_emotion.Name = "lbl_emotion";
            this.lbl_emotion.Size = new System.Drawing.Size(48, 13);
            this.lbl_emotion.TabIndex = 21;
            this.lbl_emotion.Text = "Emotion:";
            // 
            // lbl_profileHumor
            // 
            this.lbl_profileHumor.AutoSize = true;
            this.lbl_profileHumor.Location = new System.Drawing.Point(82, 202);
            this.lbl_profileHumor.Name = "lbl_profileHumor";
            this.lbl_profileHumor.Size = new System.Drawing.Size(57, 13);
            this.lbl_profileHumor.TabIndex = 20;
            this.lbl_profileHumor.Text = "[unknown]";
            // 
            // lbl_humor
            // 
            this.lbl_humor.AutoSize = true;
            this.lbl_humor.Location = new System.Drawing.Point(9, 202);
            this.lbl_humor.Name = "lbl_humor";
            this.lbl_humor.Size = new System.Drawing.Size(41, 13);
            this.lbl_humor.TabIndex = 19;
            this.lbl_humor.Text = "Humor:";
            // 
            // lbl_profileCompassion
            // 
            this.lbl_profileCompassion.AutoSize = true;
            this.lbl_profileCompassion.Location = new System.Drawing.Point(82, 184);
            this.lbl_profileCompassion.Name = "lbl_profileCompassion";
            this.lbl_profileCompassion.Size = new System.Drawing.Size(57, 13);
            this.lbl_profileCompassion.TabIndex = 18;
            this.lbl_profileCompassion.Text = "[unknown]";
            // 
            // lbl_compassion
            // 
            this.lbl_compassion.AutoSize = true;
            this.lbl_compassion.Location = new System.Drawing.Point(9, 184);
            this.lbl_compassion.Name = "lbl_compassion";
            this.lbl_compassion.Size = new System.Drawing.Size(67, 13);
            this.lbl_compassion.TabIndex = 17;
            this.lbl_compassion.Text = "Compassion:";
            // 
            // lbl_profileAdaptibility
            // 
            this.lbl_profileAdaptibility.AutoSize = true;
            this.lbl_profileAdaptibility.Location = new System.Drawing.Point(82, 256);
            this.lbl_profileAdaptibility.Name = "lbl_profileAdaptibility";
            this.lbl_profileAdaptibility.Size = new System.Drawing.Size(57, 13);
            this.lbl_profileAdaptibility.TabIndex = 26;
            this.lbl_profileAdaptibility.Text = "[unknown]";
            // 
            // lbl_adaptibility
            // 
            this.lbl_adaptibility.AutoSize = true;
            this.lbl_adaptibility.Location = new System.Drawing.Point(9, 256);
            this.lbl_adaptibility.Name = "lbl_adaptibility";
            this.lbl_adaptibility.Size = new System.Drawing.Size(60, 13);
            this.lbl_adaptibility.TabIndex = 25;
            this.lbl_adaptibility.Text = "Adaptibility:";
            // 
            // lbl_profileOptimism
            // 
            this.lbl_profileOptimism.AutoSize = true;
            this.lbl_profileOptimism.Location = new System.Drawing.Point(82, 238);
            this.lbl_profileOptimism.Name = "lbl_profileOptimism";
            this.lbl_profileOptimism.Size = new System.Drawing.Size(57, 13);
            this.lbl_profileOptimism.TabIndex = 24;
            this.lbl_profileOptimism.Text = "[unknown]";
            // 
            // lbl_optimism
            // 
            this.lbl_optimism.AutoSize = true;
            this.lbl_optimism.Location = new System.Drawing.Point(9, 238);
            this.lbl_optimism.Name = "lbl_optimism";
            this.lbl_optimism.Size = new System.Drawing.Size(52, 13);
            this.lbl_optimism.TabIndex = 23;
            this.lbl_optimism.Text = "Optimism:";
            // 
            // lbl_profileIngenuity
            // 
            this.lbl_profileIngenuity.AutoSize = true;
            this.lbl_profileIngenuity.Location = new System.Drawing.Point(82, 310);
            this.lbl_profileIngenuity.Name = "lbl_profileIngenuity";
            this.lbl_profileIngenuity.Size = new System.Drawing.Size(57, 13);
            this.lbl_profileIngenuity.TabIndex = 32;
            this.lbl_profileIngenuity.Text = "[unknown]";
            // 
            // lbl_ingenuity
            // 
            this.lbl_ingenuity.AutoSize = true;
            this.lbl_ingenuity.Location = new System.Drawing.Point(9, 310);
            this.lbl_ingenuity.Name = "lbl_ingenuity";
            this.lbl_ingenuity.Size = new System.Drawing.Size(53, 13);
            this.lbl_ingenuity.TabIndex = 31;
            this.lbl_ingenuity.Text = "Ingenuity:";
            // 
            // lbl_profileConfidence
            // 
            this.lbl_profileConfidence.AutoSize = true;
            this.lbl_profileConfidence.Location = new System.Drawing.Point(82, 292);
            this.lbl_profileConfidence.Name = "lbl_profileConfidence";
            this.lbl_profileConfidence.Size = new System.Drawing.Size(57, 13);
            this.lbl_profileConfidence.TabIndex = 30;
            this.lbl_profileConfidence.Text = "[unknown]";
            // 
            // lbl_confidence
            // 
            this.lbl_confidence.AutoSize = true;
            this.lbl_confidence.Location = new System.Drawing.Point(9, 292);
            this.lbl_confidence.Name = "lbl_confidence";
            this.lbl_confidence.Size = new System.Drawing.Size(64, 13);
            this.lbl_confidence.TabIndex = 29;
            this.lbl_confidence.Text = "Confidence:";
            // 
            // lbl_profileIntelligence
            // 
            this.lbl_profileIntelligence.AutoSize = true;
            this.lbl_profileIntelligence.Location = new System.Drawing.Point(82, 274);
            this.lbl_profileIntelligence.Name = "lbl_profileIntelligence";
            this.lbl_profileIntelligence.Size = new System.Drawing.Size(57, 13);
            this.lbl_profileIntelligence.TabIndex = 28;
            this.lbl_profileIntelligence.Text = "[unknown]";
            // 
            // lbl_intelligence
            // 
            this.lbl_intelligence.AutoSize = true;
            this.lbl_intelligence.Location = new System.Drawing.Point(9, 274);
            this.lbl_intelligence.Name = "lbl_intelligence";
            this.lbl_intelligence.Size = new System.Drawing.Size(64, 13);
            this.lbl_intelligence.TabIndex = 27;
            this.lbl_intelligence.Text = "Intelligence:";
            // 
            // grp_info
            // 
            this.grp_info.Controls.Add(this.lbl_name);
            this.grp_info.Controls.Add(this.lbl_profileIngenuity);
            this.grp_info.Controls.Add(this.lbl_profileName);
            this.grp_info.Controls.Add(this.lbl_ingenuity);
            this.grp_info.Controls.Add(this.lbl_gender);
            this.grp_info.Controls.Add(this.lbl_profileConfidence);
            this.grp_info.Controls.Add(this.lbl_profileGender);
            this.grp_info.Controls.Add(this.lbl_confidence);
            this.grp_info.Controls.Add(this.lbl_sexuality);
            this.grp_info.Controls.Add(this.lbl_profileIntelligence);
            this.grp_info.Controls.Add(this.lbl_profileSexuality);
            this.grp_info.Controls.Add(this.lbl_intelligence);
            this.grp_info.Controls.Add(this.lbl_courage);
            this.grp_info.Controls.Add(this.lbl_profileAdaptibility);
            this.grp_info.Controls.Add(this.lbl_profileCourage);
            this.grp_info.Controls.Add(this.lbl_adaptibility);
            this.grp_info.Controls.Add(this.lbl_empathy);
            this.grp_info.Controls.Add(this.lbl_profileOptimism);
            this.grp_info.Controls.Add(this.lbl_profileEmpathy);
            this.grp_info.Controls.Add(this.lbl_optimism);
            this.grp_info.Controls.Add(this.lbl_greed);
            this.grp_info.Controls.Add(this.lbl_profileEmotion);
            this.grp_info.Controls.Add(this.lbl_profileGreed);
            this.grp_info.Controls.Add(this.lbl_emotion);
            this.grp_info.Controls.Add(this.lbl_motivation);
            this.grp_info.Controls.Add(this.lbl_profileHumor);
            this.grp_info.Controls.Add(this.lbl_profileMotivation);
            this.grp_info.Controls.Add(this.lbl_humor);
            this.grp_info.Controls.Add(this.lbl_charisma);
            this.grp_info.Controls.Add(this.lbl_profileCompassion);
            this.grp_info.Controls.Add(this.lbl_profileCharisma);
            this.grp_info.Controls.Add(this.lbl_compassion);
            this.grp_info.Location = new System.Drawing.Point(163, 12);
            this.grp_info.Name = "grp_info";
            this.grp_info.Size = new System.Drawing.Size(210, 355);
            this.grp_info.TabIndex = 33;
            this.grp_info.TabStop = false;
            this.grp_info.Text = "Info:";
            // 
            // btn_regen
            // 
            this.btn_regen.Location = new System.Drawing.Point(380, 13);
            this.btn_regen.Name = "btn_regen";
            this.btn_regen.Size = new System.Drawing.Size(75, 23);
            this.btn_regen.TabIndex = 34;
            this.btn_regen.Text = "Boop";
            this.btn_regen.UseVisualStyleBackColor = true;
            this.btn_regen.Click += new System.EventHandler(this.btn_regen_Click);
            // 
            // frm_browser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 379);
            this.Controls.Add(this.btn_regen);
            this.Controls.Add(this.grp_info);
            this.Controls.Add(this.trv_browserList);
            this.Name = "frm_browser";
            this.Text = "Browser";
            this.grp_info.ResumeLayout(false);
            this.grp_info.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView trv_browserList;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.Label lbl_profileName;
        private System.Windows.Forms.Label lbl_gender;
        private System.Windows.Forms.Label lbl_profileGender;
        private System.Windows.Forms.Label lbl_sexuality;
        private System.Windows.Forms.Label lbl_profileSexuality;
        private System.Windows.Forms.Label lbl_courage;
        private System.Windows.Forms.Label lbl_profileCourage;
        private System.Windows.Forms.Label lbl_profileEmpathy;
        private System.Windows.Forms.Label lbl_empathy;
        private System.Windows.Forms.Label lbl_greed;
        private System.Windows.Forms.Label lbl_profileGreed;
        private System.Windows.Forms.Label lbl_motivation;
        private System.Windows.Forms.Label lbl_profileMotivation;
        private System.Windows.Forms.Label lbl_profileCharisma;
        private System.Windows.Forms.Label lbl_charisma;
        private System.Windows.Forms.Label lbl_profileEmotion;
        private System.Windows.Forms.Label lbl_emotion;
        private System.Windows.Forms.Label lbl_profileHumor;
        private System.Windows.Forms.Label lbl_humor;
        private System.Windows.Forms.Label lbl_profileCompassion;
        private System.Windows.Forms.Label lbl_compassion;
        private System.Windows.Forms.Label lbl_profileAdaptibility;
        private System.Windows.Forms.Label lbl_adaptibility;
        private System.Windows.Forms.Label lbl_profileOptimism;
        private System.Windows.Forms.Label lbl_optimism;
        private System.Windows.Forms.Label lbl_profileIngenuity;
        private System.Windows.Forms.Label lbl_ingenuity;
        private System.Windows.Forms.Label lbl_profileConfidence;
        private System.Windows.Forms.Label lbl_confidence;
        private System.Windows.Forms.Label lbl_profileIntelligence;
        private System.Windows.Forms.Label lbl_intelligence;
        private System.Windows.Forms.GroupBox grp_info;
        private System.Windows.Forms.Button btn_regen;
    }
}

