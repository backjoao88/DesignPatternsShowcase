using BuilderPattern.Entities;

namespace BuilderPattern;

public abstract class App
{
    public static void Main(string[] args)
    {
        {
            Console.WriteLine(">> Building with the traditional way");
            var nfse = new Nfse(NfseStatus.Normal, NfseRps.Coupon, NfsePaymentCondition.AtSight, new NfseClient(), new List<NfseItem>
            {
                new NfseItem(),
                new NfseItem()
            }, DateTime.Now, "123456", "OBSERVAÇÃO DE TESTE");
            Console.WriteLine(nfse.ToString());
        }

        {
            Console.WriteLine(">> Building with the Builder Pattern");
            var nfse = new NfseBuilder()
                .WithClient(new NfseClient())
                .WithRps(NfseRps.Mixed)
                .WithPaymentCondition(NfsePaymentCondition.AtSight)
                .WithDocumentInfo("1234", "1235", new DateTime().AddDays(1))
                .WithItems(new List<NfseItem>
                {
                    new NfseItem(),
                    new NfseItem(),
                    new NfseItem(),
                    new NfseItem(),
                    new NfseItem()
                })
                .Build();
            Console.WriteLine(nfse.ToString());
        }
    }
}