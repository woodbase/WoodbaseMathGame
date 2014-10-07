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
            var rnd = new Random(10);
            var a = rnd.Next();
            var b = rnd.Next();
            var question = new Addition(a, b);
            var suggestions = question.GetSuggestions(5);
            litQuestion.Text = a + " + " + b;

            foreach (var suggestion in suggestions)
            {
                var btn = new Button { Text = suggestion.Value.ToString() };
                pnlSuggestions.Controls.Add(btn);
            }
        }
    }
}