namespace BuilderPattern.Entities;

public enum NfseRps
{
    Rps,
    Mixed,
    Coupon
}

public enum NfseStatus
{
    Normal,
    Cancelled
}

public enum NfsePaymentCondition
{
    AtSight,
    TimePayment,
    DebitCard,
    CreditCard
}

public class NfseClient
{
    public string Id { get; set; } = "";
    public string Name { get; set; } = "";
    public string Cpf { get; set; } = "";

    public override string ToString()
    {
        return $"{nameof(Id)}: {Id}, {nameof(Name)}: {Name}, {nameof(Cpf)}: {Cpf}";
    }
}

public class NfseItem
{
    public string Id { get; set; } = "";
    public string Description { get; set; } = "";
    public decimal Tax { get; set; }
    public decimal UnitaryValue { get; set; }
    public int Quantity { get; set; }

    public override string ToString()
    {
        return
            $"{nameof(Id)}: {Id}, {nameof(Description)}: {Description}, {nameof(Tax)}: {Tax}, {nameof(UnitaryValue)}: {UnitaryValue}, {nameof(Quantity)}: {Quantity}";
    }
}

public class Nfse
{
    public Guid Id { get; set; }
    public NfseStatus Status { get; set; }
    public NfseRps Rps { get; set; }
    public NfsePaymentCondition PaymentCondition { get; set; }
    public NfseClient Client { get; set; } = null!;
    public List<NfseItem> Items { get; set; } = null!;
    public DateTime Generation { get; set; }
    public string Cnae { get; set; } = "";
    public string Observations { get; set; } = "";

    public Nfse()
    {
        Id = Guid.NewGuid();
    }

    public Nfse(NfseStatus status, NfseRps rps, NfsePaymentCondition paymentCondition, NfseClient client,
        List<NfseItem> items, DateTime generation, string cnae, string observations)
    {
        Id = Guid.NewGuid();
        Status = status;
        Rps = rps;
        PaymentCondition = paymentCondition;
        Client = client;
        Items = items;
        Generation = generation;
        Cnae = cnae;
        Observations = observations;
    }

    public override string ToString()
    {
        return
            $"Id: {Id.ToString()}, Status: {Status}, Rps: {Rps}, PaymentCondition: {PaymentCondition}, Client: {Client}, Items: {string.Join(";;", Items)}, Generation: {Generation}, Cnae: {Cnae}, Observations: {Observations}";
    }
}