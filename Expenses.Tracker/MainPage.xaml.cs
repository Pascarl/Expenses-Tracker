using System.Text;

namespace Expenses.Tracker
{
    public partial class MainPage : ContentPage
    {
        List<int> cost = new List<int>();
        StringBuilder expense = new StringBuilder();
        StringBuilder Cost = new StringBuilder();
        public string Expense;
        public string ex;
        public int cst;
        public int totalincome;
        public int totalexpense;
        public int totalbank;
        public int totalProfit;
        public int TotalSaving;


        
        public MainPage()
        {
            InitializeComponent();
        }

        private void AddBtn(object sender, EventArgs e)
        {
            if (ExpenseEntry.Text == null)
            {
                DisplayAlert("Alert", "please enter a Expense!", "OK");
            }
            else if (CostEntry.Text == null)
            {
                DisplayAlert("Alert", "please enter a Cost!", "OK");
            }
            else
            {
                ex = ExpenseEntry.Text;
                cst = (int)Convert.ToInt64(CostEntry.Text);
                cost.Add(cst);
                Expense = $"{ex} \n";
                Cost.Append(cst + "\n");
                expense.Append(ex + "\n");
                ExpenseEntry.Text = null;
                CostEntry.Text = null;
                expenselist.Text = expense.ToString();
                cstlist.Text = Cost.ToString();
               
            }
        }
        private void CancelBtn(object sender, EventArgs e)
        {
            
            ExpenseEntry.Text = "";
            CostEntry.Text = "";
            Income.Text = "";
            ExpensesTotal.Text = "";
            SavingsTotal.Text = "";
            Bank.Text = "";
            leftover.Text = "";
            expenselist.Text = "";
            cstlist.Text = "";
            Cost.Clear();
            expense.Clear();
            cost.Clear();
        }
        private void CalculateBtn(object sender, EventArgs e)
        {
            cst = 0;
            ExpenseEntry.Text = "";
            CostEntry.Text = "";
            foreach (int i in cost)
            {
                cst = cst + i;
                totalexpense = cst;
                totalincome = (int)Convert.ToInt32(Income.Text);
                TotalSaving = totalincome - totalexpense;
                totalbank = TotalSaving / 2;
                totalProfit = TotalSaving / 2;
                ExpensesTotal.Text = totalexpense.ToString();
                SavingsTotal.Text = TotalSaving.ToString();
                Bank.Text = totalbank.ToString();
                leftover.Text = totalProfit.ToString();
            }
        }
    }

}