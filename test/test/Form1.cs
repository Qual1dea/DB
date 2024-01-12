using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection.Emit;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static test.Form1;


namespace test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            InitializeSuccessfulWork();  //через public
            //SuccessfulWork.ClientsList = Client.GetClientList(); //через static.
            //SuccessfulWork.OrdersList = Order.GetOrderList();   //через static.
        }
            //0.75
        public static class SuccessfulWork
        {
            //ArrayList
            //public static ArrayList ClientsList { get; set; }
            //public static ArrayList OrdersList { get; set; }

            public static List<Client> ClientsList { get; set; }
            public static List<Order> OrdersList { get; set; }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        // через public/List/ArrayList
        public static void InitializeSuccessfulWork()
        {
            SuccessfulWork.OrdersList = new List<Order>();
            SuccessfulWork.ClientsList = new List<Client>();

            // Пример добавления клиентов и заказов
            Client client1 = new Client { IdClient = "1", Name = "Руслан", Address = " Уродсвк", IsActive = true, DecimalList = new List<int> {100, 300, 200 }};
            Client client2 = new Client { IdClient = "2", Name = "Антон", Address = " Красивск", IsActive = false, DecimalList = new List<int> {200, 600, 400 }};
            Order order1 = new Order { IdOrder = "O1", IdClient = "1", IsDelivered = true, Price = 1000, Decimal = new decimal[] {200,300000,100}};
            Order order2 = new Order { IdOrder = "O2", IdClient = "2", IsDelivered = true, Price = 2000, Decimal = new decimal[] {400,600000,200}};

            //SuccessfulWork.ClientsList = new ArrayList();    //arraylist через public
            //SuccessfulWork.OrdersList = new ArrayList();     //arraylist через public

            SuccessfulWork.ClientsList.Add(client1);
            SuccessfulWork.ClientsList.Add(client2);
            SuccessfulWork.OrdersList.Add(order1);
            SuccessfulWork.OrdersList.Add(order2);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string userInput = textBox1.Text;

            //List -// Выбор главного объекта по ключу, введенному в TextBox
            var selectedClient = SuccessfulWork.ClientsList
                .FirstOrDefault(c => c.IdClient == userInput);

            //Arraylist -// Выбор главного объекта по ключу, введенному в TextBox
            // var selectedClient = SuccessfulWork.ClientsList
            //      .Cast<Client>().FirstOrDefault(c => c.IdClient == userInput);

            if (selectedClient != null)
            {
                // Получение связанных заказов для выбранного клиента
                //List через public
                var relatedOrders = SuccessfulWork.OrdersList
                    .Where(o => o.IdClient == selectedClient.IdClient && o.IsDelivered);

                //ArrayList через public
                //   var relatedOrders = SuccessfulWork.OrdersList.Cast<Order>()
                //      .Where(o => o.IdClient == selectedClient.IdClient && o.IsDelivered);

                if (relatedOrders.Any())
                {
                    // Вычисление среднего значения поля Price для связанных заказов
                    double averagePrice = relatedOrders.Average(o => o.Price);

                    // Проверка условия по ключу и вывод суммы средних значений в Label
                    if (userInput.Length == 1 || userInput.First() == userInput.Last())
                    {
                        int result = (int)averagePrice; // Явное приведение результата к типу int
                        label1.Text = $"Сумма средних значений поля Price: {result}";
                    }
                }
                else
                {
                    label1.Text = "Для выбранного клиента нет связанных заказов";
                }

                int sumOfLogicalValues = 0;
                //List через public,static
                foreach (var order in SuccessfulWork.OrdersList)
                //arraylist через public,static
                //foreach (var order in SuccessfulWork.OrdersList.Cast<Order>()) 
                {
                    sumOfLogicalValues += order.IsDelivered ? 1 : 0;
                }

                label2.Text = $"Сумма логических значений IsDelivered: {sumOfLogicalValues}";
            }
        }
    }
}
    
