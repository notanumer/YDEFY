using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YDEFY.Controller
{
    public class ExitGameControl
    {
        public LinkLabel Exit { get; }
        public ExitGameControl()
        {
            Exit = new LinkLabel()
            {
                Text = "Выйти из игры",
                ForeColor = Color.White,
                TextAlign = ContentAlignment.MiddleCenter,
                AutoSize = true,
                FlatStyle = FlatStyle.Flat,
                Dock = DockStyle.Fill,
                LinkColor = Color.White,
                ActiveLinkColor = Color.Green,
                LinkBehavior = LinkBehavior.NeverUnderline,
                Font = new Font("Custom Font ttf 12h 3.0 for Paint", 50, FontStyle.Regular)
            };

            Exit.MouseClick += (sender, e) =>
            {
                var result = MessageBox.Show("Вы правда хотите выйти?", "", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                    Application.Exit();
            };

        }
    }
}
