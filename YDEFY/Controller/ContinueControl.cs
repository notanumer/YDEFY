using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YDEFY.Model;
using System.Windows.Forms;

namespace YDEFY.Controller
{
    public class ContinueControl
    {
        private Game game = new Game();
        public LinkLabel Continue { get; }
        public ContinueControl()
        {
            Continue = new LinkLabel()
            {
                Text = "Продолжить",
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

        private void StartButton_Click(object sender, EventArgs e)
        {

        }
    }
}
