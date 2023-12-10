using UnityEngine.Purchasing;

public class PurchaseIAP
{
    public PurchaseIAP()
    {
        var builder = ConfigurationBuilder.Instance(StandardPurchasingModule.Instance());
        builder.AddProduct("500_tickets", ProductType.Consumable);
        builder.AddProduct("1200_tickets", ProductType.Consumable);
    }
}
