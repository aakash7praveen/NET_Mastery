namespace LifecycleInjection
{
    public class TransientMessageService : IMessageService
    {
        private readonly Guid _id;

        public TransientMessageService()
        {
            _id = Guid.NewGuid();
        }

        public string GetMessage()
        {
            return $"Transient ID: {_id}";
        }
    }

}
