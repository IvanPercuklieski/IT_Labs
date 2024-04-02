using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Lab1
{
    public partial class Glasaj : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                List<string> Subjects = new List<string>() { "Internet Tehnologii", "Profesionalni Veshtini"};
                List<string> Profs = new List<string>() { "Dimitar Kitanovski", "Lasko Basnarkov" };
                List<string> Credits = new List<string>() { "6", "4" };

                for (int i = 0; i < Subjects.Count; i++)
                {
                    subject.Items.Add(new ListItem(Subjects[i], Profs[i]));
                    credits.Items.Add(new ListItem(Credits[i]));
                }
            }

        }

        protected void SameListItem()
        {

        }

        protected void subject_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(subject.SelectedIndex != -1) 
            {
                credits.SelectedIndex = subject.SelectedIndex;
                prof.Text = subject.SelectedItem.Value;
            }
        }

        protected void credits_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (credits.SelectedIndex != -1)
            {
                subject.SelectedIndex = credits.SelectedIndex;
                prof.Text = subject.SelectedItem.Value;
            }
        }

        protected void Button1_Click(object sender, EventArgs e) //Vote
        {
            if(subject.SelectedIndex != -1)
            {
                Response.Redirect("UspeshnoGlasanje.aspx");
            }
        }

        protected void Button3_Click(object sender, EventArgs e) //Delete
        {
            if(subject.SelectedIndex != -1)
            {
                subject.Items.Remove(subject.SelectedItem);
                credits.Items.Remove(credits.SelectedItem);
            }

        }

        protected void Button2_Click(object sender, EventArgs e) //Add
        {
            subject.Items.Add(TextBox1.Text);
            credits.Items.Add(TextBox2.Text);
        }
    }
}