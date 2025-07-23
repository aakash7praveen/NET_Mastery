namespace LifecycleInjection
{
    public class ScopedMessageService : IMessageService
    {
        private readonly Guid _id;

        public ScopedMessageService()
        {
            _id = Guid.NewGuid();
        }

        public string GetMessage()
        {
            return $"Scoped ID: {_id}";
        }
    }

}
