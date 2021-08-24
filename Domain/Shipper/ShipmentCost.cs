namespace Regresser.Domain.Shipper
{
    public class ShipmentCost
    {
        public string CostType { get; set; }

        public float Value { get; set; }

        public bool AllocateCost { get; set; }

        public string AccessorialCostXid { get; set; }

    }
}