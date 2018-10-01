using Microsoft.Extensions.Configuration;

namespace OdeToFood {
    public interface IGreeter {
        string GetMessageOftheDay ();
    }

    public class Greeter : IGreeter {

        private IConfiguration _configuration;
        public Greeter (IConfiguration configuration) {

            _configuration = configuration;

        }

        public string GetMessageOftheDay () {
            return _configuration["Greetings"];
        }
    }
}