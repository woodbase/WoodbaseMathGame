using System;
using System.Web.UI.WebControls;
using Woodbase.MatchGame.Core.Src;

namespace Woodbase.MathGame.Web
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack) return;
            var rnd = new Random();
            var a = rnd.Next(10);
            var b = rnd.Next(10);
            var question = new Addition(a, b);
            var suggestions = question.GetSuggestions(5, 20);
            litQuestion.Text = a + " + " + b;

            foreach (var suggestion in suggestions)
            {
                var btn = new Button { Text = suggestion.Value.ToString() };
                btn.Command += BtnAnswered;
                btn.CommandName = suggestion.Value.ToString();
                btn.CommandArgument = suggestion.Correct.ToString();

                pnlSuggestions.Controls.Add(btn);
            }
        }

        private void BtnAnswered(object sender, CommandEventArgs e)
        {
            lblResultMessage.Text = 
                Convert.ToBoolean(e.CommandArgument) ? 
                GetLocalResourceObject("RigtigtResultat").ToString() : 
                GetLocalResourceObject("ForkertResultat").ToString();
        }
    }
}