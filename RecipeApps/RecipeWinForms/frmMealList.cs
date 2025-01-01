namespace RecipeWinForms
{
    public partial class frmMealList : Form
    {
        public frmMealList()
        {
            InitializeComponent();
            BindData();
        }

        // Bind Data
        private void BindData()
        {
            gMealList.DataSource = Meal.GetMealList();
            WindowsFormUtility.FormatGridForSearch(gMealList, "Meal");
        }
    }
}
