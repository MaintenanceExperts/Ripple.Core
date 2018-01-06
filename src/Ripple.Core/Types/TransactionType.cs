using Ripple.Core.Enums;

namespace Ripple.Core.Types
{
    public class TransactionType : SerializedEnumItem<ushort>
    {
        public class Enumeration : SerializedEnumeration<TransactionType, ushort>{}
        public static Enumeration Values = new Enumeration();
        private TransactionType(string reference, int ordinal) : base(reference, ordinal){}

        private static TransactionType Add(string name, int ordinal)
        {
            return Values.AddEnum(new TransactionType(name, ordinal));
        }

        public static readonly TransactionType Invalid = Add(nameof(Invalid), -1);
        public static readonly TransactionType Payment = Add(nameof(Payment), 0);
        public static readonly TransactionType AccountSet = Add(nameof(AccountSet), 3);
        public static readonly TransactionType SetRegularKey = Add(nameof(SetRegularKey), 5);
        public static readonly TransactionType OfferCreate = Add(nameof(OfferCreate), 7);
        public static readonly TransactionType OfferCancel = Add(nameof(OfferCancel), 8);        
        public static readonly TransactionType SignerListSet = Add(nameof(SignerListSet), 12);

        public static readonly TransactionType EscrowCreate = Add(nameof(EscrowCreate), 13);
        public static readonly TransactionType EscrowFinish = Add(nameof(EscrowFinish), 14);
        public static readonly TransactionType EscrowCancel = Add(nameof(EscrowCancel), 15);

        public static readonly TransactionType PaymentChannelCreate = Add(nameof(PaymentChannelCreate), 16);
        public static readonly TransactionType PaymentChannelFund = Add(nameof(PaymentChannelFund), 17);
        public static readonly TransactionType PaymentChannelClaim = Add(nameof(PaymentChannelClaim), 18);

        public static readonly TransactionType TrustSet = Add(nameof(TrustSet), 20);
        public static readonly TransactionType EnableAmendment = Add(nameof(EnableAmendment), 100);
        public static readonly TransactionType SetFee = Add(nameof(SetFee), 101);
    }
}