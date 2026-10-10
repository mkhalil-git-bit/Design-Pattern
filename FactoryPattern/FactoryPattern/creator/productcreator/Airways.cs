class Airaways : ILogistics
{
    public ITransport CreateTransport()
    {
        return new Aeroplane();
    }
}