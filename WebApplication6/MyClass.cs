namespace WebApplication6
{
    public class MyClass
    {
        private readonly IConfiguration _configuration;
        public MyClass(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        public void MyMethod()
        {
            var value = _configuration["MyConfigKey"];
            // Используйте значение конфигурации здесь
            Console.WriteLine($"Value from configuration: {value}");
        }
    }

}