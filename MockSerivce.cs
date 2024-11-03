namespace DevelopmentTest
{
    public interface Interface1
    {
        void Method1();
    }

    public class MockSerivce
    {
        public MockSerivce(Interface1 interface1)
        {

        }
    }

    public interface IMyService
    {
        void Method1();
    }

    public class MyService: IMyService
    {
        public void Method1()
        {
            Console.WriteLine("Method1 ...");
        }
    }

    public class LongTermSerive : BackgroundService
    {
        private readonly IMyService _mySerivce;

        public LongTermSerive(IMyService mySerivce)
        {
            _mySerivce = mySerivce;
        }

        protected override Task ExecuteAsync(CancellationToken stoppingToken)
        {
            _mySerivce.Method1();

            return Task.CompletedTask;
        }
    }
}
