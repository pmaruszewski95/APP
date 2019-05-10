using System;

namespace Security
{
    public class Safe
    {
        private readonly string safeProducent;
        private long MoneyStored { get; set; }
        private Lock lockManager = new Lock();
        private LicenceStructure licenceStructure;
         
        public Safe(string _safeProdcuent, LicenseWarrantyEnum licenseWarranty = LicenseWarrantyEnum.OneYearWarranty)
        {
            this.safeProducent = _safeProdcuent;
            this.licenceStructure = new LicenceStructure();
        } 

        public void DepositMoney(long money)
        {
            lockManager.SetIsLocked(false);
            this.MoneyStored += money;
            lockManager.SetIsLocked(true);
        }

        public void WithdrawMoney(long money)
        {
            lockManager.SetIsLocked(false);
            this.MoneyStored -= money;
            lockManager.SetIsLocked(true);
        }

        public void PrintMoneyStoredInformation()
        {
            View.Print($"Current money in safe : {MoneyStored} PLN");
        }

        public void PrintSafeInformation()
        {
            View.Print(
                $"Safe's producent : {safeProducent}. " +
                $"LicenseNumber {licenceStructure.LicenceNumber}. " +
                $"License has been actived {licenceStructure.LicenseDateIssued}. " +
                $"Warranty  - {licenceStructure.LicenseWarranty} year  ");
        }

        public void PrintLockState()
        {
            View.Print($"Current lock state is {(lockManager.GetIsLocked() ? "locked" : "unlock")}");
        }

        private struct LicenceStructure
        {
            public int LicenceNumber;
            public DateTime LicenseDateIssued;
            public LicenseWarrantyEnum LicenseWarranty;


            public LicenceStructure(int licenceNumber, LicenseWarrantyEnum licenseWarranty = LicenseWarrantyEnum.OneYearWarranty)
            {
                this.LicenceNumber = new Random().Next(0, 10000);
                this.LicenseDateIssued = DateTime.Now;
                this.LicenseWarranty = licenseWarranty;
            }
        }
        
    }
}
