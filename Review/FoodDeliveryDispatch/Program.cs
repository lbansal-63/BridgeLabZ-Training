using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;


namespace FoodDeliveryDispatch
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method, Inherited = false, AllowMultiple = false)]
    public sealed class RequiresColdStorageAttribute : Attribute
    {
        public string Description { get; }

        public RequiresColdStorageAttribute(string description = "Requires cold storage handling")
        {
            Description = description;
        }
    }

    public class DeliveryOrder
    {
        public string OrderId { get; }
        public string RestaurantId { get; }
        public double Weight { get; }
        public bool RequiresColdBag { get; }

        public DeliveryOrder(string orderId, string restaurantId, double weight, bool requiresColdBag)
        {
            if (weight <= 0)
            {
                throw new ArgumentException("Order weight must be greater than zero.", nameof(weight));
            }

            OrderId = orderId ?? throw new ArgumentNullException(nameof(orderId));
            RestaurantId = restaurantId ?? throw new ArgumentNullException(nameof(restaurantId));
            Weight = weight;
            RequiresColdBag = requiresColdBag;
        }
    }

    public class Rider
    {
        public string RiderId { get; }
        public int Capacity { get; }
        public bool HasColdBag { get; }
        public int CurrentLoad { get; set; }

        public Rider(string riderId, int capacity, bool hasColdBag)
        {
            RiderId = riderId ?? throw new ArgumentNullException(nameof(riderId));
            Capacity = capacity;
            HasColdBag = hasColdBag;
            CurrentLoad = 0;
        }
    }

    public class NoEligibleRiderException : Exception
    {
        public string OrderId { get; }

        public NoEligibleRiderException(string orderId) : base($"No eligible rider found for order ID: {orderId}")
        {
            OrderId = orderId;
        }
    }

    public class DispatchLogger : IDisposable
    {
        private StreamWriter _writer;
        private bool _disposed = false;

        public DispatchLogger(Stream stream)
        {
            if (stream == null) throw new ArgumentNullException(nameof(stream));
            _writer = new StreamWriter(stream) { AutoFlush = true };
        }

        public void Log(string message)
        {
            if (_disposed) throw new ObjectDisposedException(nameof(DispatchLogger));
            _writer.WriteLine($"[{DateTime.UtcNow:yyyy-MM-dd HH:mm:ss}] {message}");
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        
    }

  
    public class OrderDispatchedEvntArgs : EventArgs
    {
        public DeliveryOrder Order { get; }
        public Rider AssignedRider { get; }

        public OrderDispatchedEventArgs(DeliveryOrder order, Rider assignedRider)
        {
            Order = order;
            AssignedRider = assignedRider;
        }
    }

    public class DispatchEngine
    {
        public event EventHandler<OrderDispatchedEventArgs> OrderDispatched;
        private readonly Action<string> _loggerAction;

        public DispatchEngine(Action<string> loggerAction = null)
        {
            _loggerAction = loggerAction ?? (msg => Console.WriteLine(msg));
        }

        public Predicate<Rider> CreateMatchingRule(double maxWeight)
        {
            return rider => rider.CurrentLoad < rider.Capacity;

        }

        [RequiresColdStorageAttribute("Special handling check for cold bag items")]
        

        public Dictionary<string, double> GetAverageWeightPerRestaurant(IEnumerable<DeliveryOrder> orders)
        {
            return orders.GroupBy(o => o.RestaurantId).ToDictionary(g => g.Key, g => g.Average(o => o.Weight));
        }

        public List<Rider> GetUnassignedRiders(IEnumerable<Rider> riders)
        {
            return riders.Where(r => r.CurrentLoad == 0).ToList();
        }

        public static void Main()
        {

        }
    
    }
}