namespace WinFormsApp7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            AllCbox.CheckStateChanged += AllChanged;
            foreach (Control Box in ChildPan.Controls) 
                (Box as CheckBox).CheckedChanged += ItemChanged;
            
        }
        private void ItemChanged(object sender, EventArgs e)
        {
            List<Control> childList = ChildPan.Controls.OfType<Control>().ToList();
            bool isAll = childList.All(item => (item as CheckBox).Checked);
            bool isAny = childList.Any(item => (item as CheckBox).Checked);
            if (isAll)
            {
                AllCbox.CheckState = CheckState.Checked;
            }
            else
            {
                AllCbox.CheckState = isAny ? CheckState.Indeterminate : CheckState.Unchecked;
            }
        }
        private void AllChanged(object sender, EventArgs e) {
            bool isCheck = AllCbox.CheckState == CheckState.Checked ? true : false;

            if (AllCbox.CheckState != CheckState.Indeterminate)
            {
                foreach (Control Box in ChildPan.Controls)
                {
                    (Box as CheckBox).Checked = isCheck;

                }
            }
        }

    }
}

