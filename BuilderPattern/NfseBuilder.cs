using BuilderPattern.Entities;

namespace BuilderPattern;

public class NfseBuilder
{
    private Nfse NfseInstance { get; } = new Nfse();

    public NfseBuilder WithClient(NfseClient client)
    {
        NfseInstance.Client = client;
        return this;
    }

    public NfseBuilder WithRps(NfseRps rps)
    {
        NfseInstance.Rps = rps;
        return this;
    }

    public NfseBuilder WithItems(List<NfseItem> items)
    {
        this.NfseInstance.Items = items;
        return this;
    }

    public NfseBuilder WithPaymentCondition(NfsePaymentCondition payment)
    {
        this.NfseInstance.PaymentCondition = payment;
        return this;
    }

    public NfseBuilder WithDocumentInfo(string cnae, string observations, DateTime generation)
    {
        this.NfseInstance.Cnae = cnae;
        this.NfseInstance.Observations = observations;
        this.NfseInstance.Generation = generation;
        return this;
    }

    public Nfse Build()
    {
        return this.NfseInstance;
    }
}