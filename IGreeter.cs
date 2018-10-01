namespace OdeToFood {
    public interface IGreeter {
        string GetMessageOftheDay ();
    }

    public class Greeter : IGreeter {
        public string GetMessageOftheDay () {
            return "Greetings";
        }
    }
}