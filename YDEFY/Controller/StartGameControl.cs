using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YDEFY.Controller
{
    public class StartGameControl
    {
        public LinkLabel Start { get; }
        public StartGameControl()
        {
            Start = new LinkLabel()
            {
                Text = "Начать игру",
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
        }
    }
}
