using Knapsack_Project.DTO;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;

namespace Knapsack_Project
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public ObservableCollection<Company> companies = new ObservableCollection<Company>();
        public ObservableCollection<answer> answers = new ObservableCollection<answer>();
        public BrushConverter converter = new BrushConverter();
        public int number = 1;
        private int N_Color = 0; //color
        private int N_Company = 0;
        public string[] color = new string[10]
        {
            "#1098AD", "#1E88E5", "#FF8F00", "#FF5252", "#0CA678", "#6741D9", "#FF6D00", "#FF5252", "#1E88E5", "#0CA678"
        };

        public MainWindow()
        {
            InitializeComponent();


            //members.Add(new Member { Number = "1", Character = "J", BgColor = (Brush)converter.ConvertFromString("#1098AD"), StockName = "John Doe", StockValue = "Coach", Dividened = "john.doe@gmail.com" });
            //members.Add(new Member { Number = "2", Character = "R", BgColor = (Brush)converter.ConvertFromString("#1E88E5"), StockName = "Reza Alavi", StockValue = "Administrator", Dividened = "reza110@hotmail.com" });
            //members.Add(new Member { Number = "3", Character = "D", BgColor = (Brush)converter.ConvertFromString("#FF8F00"), StockName = "Dennis Castillo", StockValue = "Coach", Dividened = "deny.cast@gmail.com" });
            //members.Add(new Member { Number = "4", Character = "G", BgColor = (Brush)converter.ConvertFromString("#FF5252"), StockName = "Gabriel Cox", StockValue = "Coach", Dividened = "coxcox@gmail.com" });
            //members.Add(new Member { Number = "5", Character = "L", BgColor = (Brush)converter.ConvertFromString("#0CA678"), StockName = "Lena Jones", StockValue = "Manager", Dividened = "lena.offi@hotmail.com" });
            //members.Add(new Member { Number = "6", Character = "B", BgColor = (Brush)converter.ConvertFromString("#6741D9"), StockName = "Benjamin Caliword", StockValue = "Administrator", Dividened = "beni12@hotmail.com" });
            //members.Add(new Member { Number = "7", Character = "S", BgColor = (Brush)converter.ConvertFromString("#FF6D00"), StockName = "Sophia Muris", StockValue = "Coach", Dividened = "sophi.muri@gmail.com" });
            //members.Add(new Member { Number = "8", Character = "A", BgColor = (Brush)converter.ConvertFromString("#FF5252"), StockName = "Ali Pormand", StockValue = "Manager", Dividened = "alipor@yahoo.com" });
            //members.Add(new Member { Number = "9", Character = "F", BgColor = (Brush)converter.ConvertFromString("#1E88E5"), StockName = "Frank Underwood", StockValue = "Manager", Dividened = "frank@yahoo.com" });
            //members.Add(new Member { Number = "10", Character = "S", BgColor = (Brush)converter.ConvertFromString("#0CA678"), StockName = "Saeed Dasman", StockValue = "Coach", Dividened = "saeed.dasi@hotmail.com" });

            //members.Add(new Member { Number = "11", Character = "J", BgColor = (Brush)converter.ConvertFromString("#1098AD"), StockName = "John Doe", StockValue = "Coach", Dividened = "john.doe@gmail.com", });
            //members.Add(new Member { Number = "12", Character = "R", BgColor = (Brush)converter.ConvertFromString("#1E88E5"), StockName = "Reza Alavi", StockValue = "Administrator", Dividened = "reza110@hotmail.com" });
            //members.Add(new Member { Number = "13", Character = "D", BgColor = (Brush)converter.ConvertFromString("#FF8F00"), StockName = "Dennis Castillo", StockValue = "Coach", Dividened = "deny.cast@gmail.com" });
            //members.Add(new Member { Number = "14", Character = "G", BgColor = (Brush)converter.ConvertFromString("#FF5252"), StockName = "Gabriel Cox", StockValue = "Coach", Dividened = "coxcox@gmail.com" });
            //members.Add(new Member { Number = "15", Character = "L", BgColor = (Brush)converter.ConvertFromString("#0CA678"), StockName = "Lena Jones", StockValue = "Manager", Dividened = "lena.offi@hotmail.com" });
            //members.Add(new Member { Number = "16", Character = "B", BgColor = (Brush)converter.ConvertFromString("#6741D9"), StockName = "Benjamin Caliword", StockValue = "Administrator", Dividened = "beni12@hotmail.com" });
            //members.Add(new Member { Number = "17", Character = "S", BgColor = (Brush)converter.ConvertFromString("#FF6D00"), StockName = "Sophia Muris", StockValue = "Coach", Dividened = "sophi.muri@gmail.com" });
            //members.Add(new Member { Number = "18", Character = "A", BgColor = (Brush)converter.ConvertFromString("#FF5252"), StockName = "Ali Pormand", StockValue = "Manager", Dividened = "alipor@yahoo.com" });
            //members.Add(new Member { Number = "19", Character = "F", BgColor = (Brush)converter.ConvertFromString("#1E88E5"), StockName = "Frank Underwood", StockValue = "Manager", Dividened = "frank@yahoo.com" });
            //members.Add(new Member { Number = "20", Character = "S", BgColor = (Brush)converter.ConvertFromString("#0CA678"), StockName = "Saeed Dasman", StockValue = "Coach", Dividened = "saeed.dasi@hotmail.com" });

            //members.Add(new Member { Number = "21", Character = "J", BgColor = (Brush)converter.ConvertFromString("#1098AD"), StockName = "John Doe", StockValue = "Coach", Dividened = "john.doe@gmail.com" });
            //members.Add(new Member { Number = "22", Character = "R", BgColor = (Brush)converter.ConvertFromString("#1E88E5"), StockName = "Reza Alavi", StockValue = "Administrator", Dividened = "reza110@hotmail.com" });
            //members.Add(new Member { Number = "23", Character = "D", BgColor = (Brush)converter.ConvertFromString("#FF8F00"), StockName = "Dennis Castillo", StockValue = "Coach", Dividened = "deny.cast@gmail.com" });
            //members.Add(new Member { Number = "24", Character = "G", BgColor = (Brush)converter.ConvertFromString("#FF5252"), StockName = "Gabriel Cox", StockValue = "Coach", Dividened = "coxcox@gmail.com" });
            //members.Add(new Member { Number = "25", Character = "L", BgColor = (Brush)converter.ConvertFromString("#0CA678"), StockName = "Lena Jones", StockValue = "Manager", Dividened = "lena.offi@hotmail.com" });
            //members.Add(new Member { Number = "26", Character = "B", BgColor = (Brush)converter.ConvertFromString("#6741D9"), StockName = "Benjamin Caliword", StockValue = "Administrator", Dividened = "beni12@hotmail.com" });
            //members.Add(new Member { Number = "27", Character = "S", BgColor = (Brush)converter.ConvertFromString("#FF6D00"), StockName = "Sophia Muris", StockValue = "Coach", Dividened = "sophi.muri@gmail.com" });
            //members.Add(new Member { Number = "28", Character = "A", BgColor = (Brush)converter.ConvertFromString("#FF5252"), StockName = "Ali Pormand", StockValue = "Manager", Dividened = "alipor@yahoo.com" });
            //members.Add(new Member { Number = "29", Character = "F", BgColor = (Brush)converter.ConvertFromString("#1E88E5"), StockName = "Frank Underwood", StockValue = "Manager", Dividened = "frank@yahoo.com" });
            //members.Add(new Member { Number = "30", Character = "S", BgColor = (Brush)converter.ConvertFromString("#0CA678"), StockName = "Saeed Dasman", StockValue = "Coach", Dividened = "saeed.dasi@hotmail.com" });

            companiesDataGrid.ItemsSource = companies;
        }

        private bool IsMaximize = false;
        private void Border_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ClickCount == 2)
            {
                if (IsMaximize)
                {
                    this.WindowState = WindowState.Normal;
                    this.Width = 1080;
                    this.Height = 720;

                    IsMaximize = false;
                }
                else
                {
                    this.WindowState = WindowState.Maximized;

                    IsMaximize = true;
                }
            }
        }

        private void Border_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
            {
                this.DragMove();
            }
        }


        private void Addnewcompany_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (stocknametextbox.Text == "")
            {
                stocknameicon.Kind = MahApps.Metro.IconPacks.PackIconMaterialKind.Alert;
                stocknameicon.Visibility = Visibility.Visible;
            }
            else
            {
                stocknameicon.Visibility = Visibility.Hidden;

            }
            if (stockvaluetextbox.Text == "")
            {

                stockvalueicon.Kind = MahApps.Metro.IconPacks.PackIconMaterialKind.Alert;
                stockvalueicon.Visibility = Visibility.Visible;

            }
            else
            {
                stockvalueicon.Visibility = Visibility.Hidden;
            }
            if (Dividendtextbox.Text == "")
            {

                Dividendicon.Kind = MahApps.Metro.IconPacks.PackIconMaterialKind.Alert;
                Dividendicon.Visibility = Visibility.Visible;
            }
            else
            {
                Dividendicon.Visibility = Visibility.Hidden;

            }

            if (stocknametextbox.Text != "" && stockvaluetextbox.Text != "" && Dividendtextbox.Text != "")
            {

                N_Company++;
                stocknameicon.Visibility = Visibility.Hidden;
                stockvalueicon.Visibility = Visibility.Hidden;
                Dividendicon.Visibility = Visibility.Hidden;
                numbercompany.Text = $"{N_Company} Company";
                companies.Add(new Company { Number = number.ToString(), Character = stocknametextbox.Text[0].ToString(), BgColor = (Brush)converter.ConvertFromString(color[N_Color]), StockName = stocknametextbox.Text, StockValue = stockvaluetextbox.Text, Dividened = Dividendtextbox.Text });
                N_Color = (N_Color + 1) % 9;
                number++;
                companiesDataGrid.ItemsSource = companies;
                stocknametextbox.Text = "";
                stockvaluetextbox.Text = "";
                Dividendtextbox.Text = "";
            }

        }








        private void check_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {


            if (capitaltextbox.Text == "")
            {
                capitalicon.Kind = MahApps.Metro.IconPacks.PackIconMaterialKind.Alert;
                capitalicon.Visibility = Visibility.Visible;
            }
            else
            {
                capitalicon.Visibility = Visibility.Hidden;
                var G_K = new Greedy_Algorithm();
                var D_k = new Dynamic_Algorithm();
                var B_k = new BackTracking_Algorithm();
                var capital = long.Parse(capitaltextbox.Text);
                item[] arr = new item[companies.Count];
                for (int i = 0; i < companies.Count; i++)
                {
                    arr[i] = new item(long.Parse(companies[i].Dividened), long.Parse(companies[i].StockValue),
                        long.Parse(companies[i].Number));
                }
                G_K.KnapSack_Greedy(arr, capital);
                D_k.knapSack_Dynamic(arr, capital);
                B_k.knapSack_BackTracking(arr, capital, arr.Length);
                answers.Clear();
                answers.Add(new answer { greedyalgorithm = G_K.totalVal.ToString(), dynamicalgorithm = D_k.totalVal.ToString(), backtrackingalgorithm = B_k.totalVal.ToString() });
                answersDataGrid.ItemsSource = answers;


                var ListCompanies = companies.ToList();
                ListCompanies.ForEach(c =>c.Greedy= "Hidden");
                ListCompanies.ForEach(c => c.Dynamic = "Hidden");
                ListCompanies.ForEach(c => c.BackTracking = "Hidden");
                ListCompanies.FindAll(c => G_K.company_list.Contains(long.Parse(c.Number))).ForEach(c => c.Greedy = "Visible");
                ListCompanies.FindAll(c => D_k.company_list.Contains(long.Parse(c.Number))).ForEach(c => c.Dynamic = "Visible");
                ListCompanies.FindAll(c => D_k.company_list.Contains(long.Parse(c.Number))).ForEach(c => c.BackTracking = "Visible");
                companies.Clear();
                foreach (var item in ListCompanies)
                    companies.Add(item);

                companiesDataGrid.ItemsSource = companies;



            }





        }

        private void deleterow_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            var id = ((Button)sender).Tag;
            var ListCompanies = companies.ToList();
            ListCompanies.RemoveAt(ListCompanies.IndexOf(ListCompanies.FirstOrDefault(c => c.Number == id.ToString())));
            companies.Clear();
            foreach (var item in ListCompanies)
                companies.Add(item);
            companiesDataGrid.ItemsSource = companies;
            N_Company--;
            numbercompany.Text = $"{N_Company} Company";

        }

        private void editrow_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            var id = ((Button)sender).Tag;
            var ListCompanies = companies.ToList();
            var c = ListCompanies.FirstOrDefault(c => c.Number == id.ToString());
            stocknametextbox.Text = c.StockName;
            stockvaluetextbox.Text = c.StockValue;
            Dividendtextbox.Text = c.Dividened;
            ListCompanies.RemoveAt(ListCompanies.IndexOf(c));
            companies.Clear();
            foreach (var item in ListCompanies)
                companies.Add(item);
            companiesDataGrid.ItemsSource = companies;
            N_Company--;
            numbercompany.Text = $"{N_Company} Company";
        }

        private void exit(object sender, MouseButtonEventArgs e)
        {
            System.Windows.Application.Current.Shutdown();
        }
    }
    public class Company
    {
        public string Character { get; set; }
        public Brush BgColor { get; set; }
        public string Number { get; set; }
        public string StockName { get; set; }
        public string StockValue { get; set; }
        public string Dividened { get; set; }
        public string Greedy { get; set; } = "Hidden";
        public string Dynamic { get; set; } = "Hidden";
        public string BackTracking { get; set; } = "Hidden";

    }
    public class answer
    {
        public string greedyalgorithm { get; set; }
        public string dynamicalgorithm { get; set; }
        public string backtrackingalgorithm { get; set; }
    }
}
