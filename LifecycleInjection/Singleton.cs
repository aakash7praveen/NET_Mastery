namespace LifecycleInjection
{
    public class SingletonMessageService : IMessageService
    {
        private readonly Guid _id;

        public SingletonMessageService()
        {
            _id = Guid.NewGuid();
        }

        public string GetMessage()
        {
            return $"Singleton ID: {_id}";
        }
    }

}
