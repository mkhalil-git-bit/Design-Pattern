ILogistics logistics = new Roadways();
        ITransport transport = logistics.CreateTransport();
        transport.Deliver();

        logistics = new Waterways();
        transport = logistics.CreateTransport();
        transport.Deliver();

        logistics = new Airaways();
        transport = logistics.CreateTransport();
        transport.Deliver();
