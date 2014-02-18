using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SocietyProfiler.Profiles;

namespace SocietyProfiler
{
    public partial class frm_browser : Form
    {
        public frm_browser()
        {
            InitializeComponent();

            btn_regen_Click(this, null);
        }

        public void LoadProfile(Profile profile)
        {
            lbl_profileName.Text = profile.Name;
            lbl_profileGender.Text = profile.Info.Gender.ToString();
            lbl_profileSexuality.Text = profile.Info.Sexuality.ToString();

            lbl_profileCourage.Text = profile.Info.Courage + "%";
            lbl_profileEmpathy.Text = profile.Info.Empathy + "%";
            lbl_profileGreed.Text = profile.Info.Greed + "%";
            lbl_profileMotivation.Text = profile.Info.Motivation + "%";
            lbl_profileCharisma.Text = profile.Info.Charisma + "%";

            lbl_profileCompassion.Text = profile.Info.Compassion + "%";
            lbl_profileHumor.Text = profile.Info.Humor + "%";
            lbl_profileEmotion.Text = profile.Info.Emotion + "%";

            lbl_profileOptimism.Text = profile.Info.Optimism + "%";
            lbl_profileAdaptibility.Text = profile.Info.Adaptibility + "%";
            lbl_profileIntelligence.Text = profile.Info.Intelligence + "%";

            lbl_profileConfidence.Text = profile.Info.Confidence + "%";
            lbl_profileIngenuity.Text = profile.Info.Ingenuity + "%";
        }

        private void trv_browserList_AfterSelect(object sender, TreeViewEventArgs e)
        {
            LoadProfile((Profile)e.Node.Tag);
        }

        private void btn_regen_Click(object sender, EventArgs e)
        {
            trv_browserList.Nodes.Clear();

            Profile mother = new Profile(Gender.Female);
            Profile father = new Profile(Gender.Male);
            mother.Marry(father);

            trv_browserList.AddProfile(mother);
            trv_browserList.AddProfile(father);
            TreeNode[] t = trv_browserList.Nodes.Find(father.Name, true);
            TreeNode fNode = t[0];

            fNode.AddProfile(mother.HaveChild());
            fNode.AddProfile(mother.HaveChild());
            fNode.AddProfile(mother.HaveChild());
            fNode.AddProfile(mother.HaveChild());
        }
    }

    public static class TreeViewExtender
    {
        public static void AddProfile(this TreeNode node, Profile profile)
        {
            TreeNode n = new TreeNode();
            n.Name = profile.Name;
            n.Text = profile.Name;
            n.Tag = profile;

            node.Nodes.Add(n);
        }

        public static void AddProfile(this TreeView treeView, Profile profile)
        {
            TreeNode n = new TreeNode();
            n.Name = profile.Name;
            n.Text = profile.Name;
            n.Tag = profile;

            treeView.Nodes.Add(n);
        }
    }
}
