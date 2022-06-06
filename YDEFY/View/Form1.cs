using YDEFY.Controller;

namespace YDEFY
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            var startGame = new StartGameControl().Start;
            var continueGame = new ContinueControl().Continue;
            var exitGameBtn = new ExitGameControl().Exit;

            var label = new Label()
            {
                Text = "Y.D.E.F.Y",
                Font = new Font("Custom Font ttf 12h 3.0 for Paint", 100, FontStyle.Regular),
                ForeColor = Color.White,
                TextAlign = ContentAlignment.MiddleCenter,
                Dock = DockStyle.Fill
            };

            var table = new TableLayoutPanel();
            table.RowStyles.Clear();
            table.RowStyles.Add(new RowStyle(SizeType.Percent, 5));
            table.RowStyles.Add(new RowStyle(SizeType.Absolute, 200));
            table.RowStyles.Add(new RowStyle(SizeType.Absolute, 150));
            table.RowStyles.Add(new RowStyle(SizeType.Absolute, 100));
            table.RowStyles.Add(new RowStyle(SizeType.Absolute, 100));
            table.RowStyles.Add(new RowStyle(SizeType.Percent, 5));
            table.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100));
            table.Controls.Add(new Panel(), 0, 0);
            table.Controls.Add(label, 0, 1);
            table.Controls.Add(startGame, 0, 2);
            table.Controls.Add(continueGame, 0, 3);
            table.Controls.Add(exitGameBtn, 0, 4);
            table.Controls.Add(new Panel(), 0, 5);
            table.Dock = DockStyle.Fill;
            Controls.Add(table);
        }
    }
}