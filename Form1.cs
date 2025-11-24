using System.Reflection;

namespace MainApp
{
    public partial class Form1 : Form
    {
        private Button CallModuleA;
        private Button CallModuleB;
        public Form1()
        {
            InitializeComponent();
            BuildUI();
        }

        private void BuildUI()
        {
            this.Controls.Clear();
            this.Padding = new Padding(10);

            //=== 主 Layout (左右) ===
            var mainLayout = new TableLayoutPanel()
            {
                Dock = DockStyle.Fill,
                ColumnCount = 2
            };
            mainLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50));
            mainLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50));
            this.Controls.Add(mainLayout);

            CallModuleA = new Button()
            {
                Text = "Call ModuleA",
                Dock = DockStyle.Fill,
                Width = 180
            };
            CallModuleA.Click += CallModuleA_Click;

            mainLayout.Controls.Add(CallModuleA, 0, 0);

            CallModuleB = new Button()
            {
                Text = "Call ModuleB",
                Dock = DockStyle.Fill,
                Width = 180
            };
            CallModuleB.Click += CallModuleB_Click;

            mainLayout.Controls.Add(CallModuleB, 1, 0);
        }

        private void CallModuleA_Click(object sender, EventArgs e)
        {
            var moduleA = new ModuleA.ModuleAClass(); // 稍後會引用 ModuleA
            MessageBox.Show(moduleA.GetMessage());
        }

        private void CallModuleB_Click(object sender, EventArgs e)
        {
            var moduleB = new ModuleB.ModuleBClass(); // 稍後會引用 ModuleB
            MessageBox.Show(moduleB.GetMessage());
        }
    }
}
