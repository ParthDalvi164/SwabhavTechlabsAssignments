namespace CommandPattern
{
    class Chef
    {
        public void CookPasta()
        {
            Console.WriteLine("Chef is cooking pasta.");
        }

        public void CookPizza()
        {
            Console.WriteLine("Chef is making pizza.");
        }
    }

    interface IFoodOrder
    {
        void Execute();
    }

    class PastaOrder : IFoodOrder
    {
        private Chef _chef;

        public PastaOrder(Chef chef)
        {
            _chef = chef;
        }

        public void Execute()
        {
            _chef.CookPasta();
        }
    }

    class PizzaOrder : IFoodOrder
    {
        private Chef _chef;

        public PizzaOrder(Chef chef)
        {
            _chef = chef;
        }

        public void Execute()
        {
            _chef.CookPizza();
        }
    }

    class Waiter
    {
        private List<IFoodOrder> _orders = new List<IFoodOrder>();

        public void TakeOrder(IFoodOrder order)
        {
            _orders.Add(order);  
        }

        public void PlaceOrders()
        {
            foreach (var order in _orders)
            {
                order.Execute(); 
            }
            _orders.Clear(); 
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Chef chef = new Chef();

            IFoodOrder order1 = new PastaOrder(chef);
            IFoodOrder order2 = new PizzaOrder(chef);

            Waiter waiter = new Waiter();
            waiter.TakeOrder(order1); 
            waiter.TakeOrder(order2);  

            waiter.PlaceOrders();      
        }
    }
}
