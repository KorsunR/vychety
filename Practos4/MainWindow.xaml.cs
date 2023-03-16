using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Xml.Serialization;

namespace Practos4
{
    public class Record
    {
        public string name {get; set;}
        public string recordtype  { get; set; }
        public double amountofmoney { get; set; }
        public bool deduction { get; set; }
        public DateTime date { get; set; }

        public Record() { }
        public Record(string name, string recordtype, double amountofmoney, bool deduction, DateTime date) {
            this.name = name;
            this.recordtype = recordtype;
            this.amountofmoney = amountofmoney;
            this.deduction = deduction;
            this.date = date;
        }
    }

    public class AllData
    {
        public List<Record> records;
        public List<string> recordTypes;
        public List<DateTime> dates;
        
        public AllData()
        {
            records = new List<Record>();
            dates = new List<DateTime>();
            recordTypes = new List<string>();
        }
    }
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// 
    public partial class MainWindow : Window
    {
        public AllData appData;
        public MainWindow()
        {
            InitializeComponent();
           
        }

        private void Grid_Loaded(object sender, RoutedEventArgs e)
        {
            appData = new AllData();

            if (File.Exists("alldata.xml"))
            {
                TextReader reader = null;
                var readSerializer = new XmlSerializer(typeof(AllData));
                reader = new StreamReader("alldata.xml");
                appData = (AllData)readSerializer.Deserialize(reader);
            }
            else
            {
                appData.records.Add(new Record("Щелев Виктор Петрович", "Доход от вклада", 15000, false, new DateTime(2022, 12, 30)));
                appData.records.Add(new Record("Мелехов Антон Витальевич", "Доход от продажи стекловаты", 30000, false, new DateTime(2023, 04, 01)));
                appData.records.Add(new Record("Максимов Григорий Спасокукоцкий", "Доход от продажи ювелирных украшений", 40000, false, new DateTime(2022, 12, 05)));
                appData.records.Add(new Record("Устюжанин Артем Антонович", "Налоговый вычет", 15900, true, new DateTime(2023, 01, 01)));
                appData.records.Add(new Record("Узунов Степан Иванович", "Налоговый вычет", 17800, true, new DateTime(2022, 12, 05)));
                appData.records.Add(new Record("Арутюнян Артур Витальевич", "Доход от ставок", 18000, false, new DateTime(2022, 12, 05)));
                appData.records.Add(new Record("Арутюнян Артур Витальевич", "Доход от поставки лекарств", 23000, false, new DateTime(2022, 12, 05)));
                appData.records.Add(new Record("Мелехов Антон Витальевич", "Вычет из-за не состоявшейся сделки", 140000, true, new DateTime(2023, 04, 01)));
                appData.records.Add(new Record("Данилова Виктория Валерьевна", "Вычет из Гос. бюджета", 40500, true, new DateTime(2022, 12, 05)));
                appData.records.Add(new Record("Узунов Степан Иванович", "Доход от поставки сигарет", 49000, false, new DateTime(2022, 12, 05)));
                appData.records.Add(new Record("Узунов Степан Иванович", "Вычет из бухгалтерии", 34500, true, new DateTime(2022, 12, 05)));
                appData.records.Add(new Record("Устюжанин Артем Антонович", "Вычет из-за несостоявшейся сделки", 32000, true, new DateTime(2023, 01, 01)));
                appData.records.Add(new Record("Перевезенцев Матвей Григорьевич", "Доход от поставок новогодних игрушек", 23000, false, new DateTime(2022, 12, 05)));


                //---------------------------------      

                for (int i = 0; i < appData.records.Count; i++)
                {
                    if (!appData.dates.Contains(appData.records[i].date))
                        appData.dates.Add(appData.records[i].date);
                }

                //---------------------------------


                appData.recordTypes.Add("Налоговый вычет");
                appData.recordTypes.Add("Доход от вклада");
                appData.recordTypes.Add("Доход от продажи стекловаты");
                appData.recordTypes.Add("Доход от продажи ювелирных украшений");
                appData.recordTypes.Add("Доход от ставок");
                appData.recordTypes.Add("Доход от поставки лекарств");
                appData.recordTypes.Add("Вычет из-за не состоявшейся сделки");
                appData.recordTypes.Add("Вычет из Гос. бюджета");
                appData.recordTypes.Add("Доход от поставки сигарет");
                appData.recordTypes.Add("Вычет из бухгалтерии");
                appData.recordTypes.Add("Доход от поставок новогодних игрушек");
                appData.recordTypes.Add("Вычет из-за несостоявшейся сделки");



                TextWriter writer = null;
                var serializer = new XmlSerializer(typeof(AllData));
                writer = new StreamWriter("alldata.xml", false);
                serializer.Serialize(writer, appData);
            }


            Razer.Items.Clear();
            Razer.ItemsSource = appData.records;
            RecordDatePicker.ItemsSource = appData.dates;
            DGCbColumn.ItemsSource = appData.recordTypes;

        }

        private void Razer_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            RecordDatePicker.SelectedIndex = -1;
            Razer.ItemsSource = appData.records;
        }

        private void RecordDatePicker_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (RecordDatePicker.SelectedIndex != -1)
                Razer.ItemsSource = appData.records.Where(a => a.date == (DateTime)RecordDatePicker.SelectedValue).ToList();
        }
    }
}
