namespace CleanAir4You.Contracts
{
    public interface IHandle<T>
    {
        void Handle(T message);
    }

    public interface ISubscribe<T>
    {
        void Handle(T message);
    }
}