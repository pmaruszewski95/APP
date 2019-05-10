namespace Security
{
    public class Lock
    {
        private bool isLocked;

        public Lock(bool defaultLockState = true)
        {
            this.SetIsLocked(defaultLockState);
        }

        public bool GetIsLocked()
        {
            return isLocked;
        }

        public void SetIsLocked(bool value)
        {
            this.isLocked = value;
        }
    }
}
