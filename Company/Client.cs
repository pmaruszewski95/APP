namespace Security
{
    public class Client : Person
    {
        private Safe safe;

        public Client(string firstName, string lastName, int idNumber) : base(firstName, lastName, idNumber)
        {
        }

        public void BuyOwnSafe(string producent, LicenseWarrantyEnum licenseWarranty = LicenseWarrantyEnum.OneYearWarranty)
        {
            this.safe = new Safe(producent, licenseWarranty);            
        }

        public void DepositMoney(long moneyToStore)
        {
            this.safe?.DepositMoney(moneyToStore);
        }

        public void WithdrawMoney(long moneyToWithdraw)
        {
            this.safe?.WithdrawMoney(moneyToWithdraw);
        }

        public void PrintSafeInformation()
        {
            this.safe?.PrintSafeInformation();
        }

        public void PrintCurrentMoneyState()
        {
            this.safe?.PrintMoneyStoredInformation();
        }

        public void PrintSafeLockState()
        {
            this.safe?.PrintLockState();
        }

    }
}
