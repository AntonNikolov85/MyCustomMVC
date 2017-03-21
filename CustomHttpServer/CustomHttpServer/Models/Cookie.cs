namespace CustomHttpServer.Models
{
    public class Cookie
    {
        private string name;
        private string value;

        public Cookie() : this(null, null)
        {
        }
        public Cookie(string name, string value)
        {
            this.name = name;
            this.value = value;
        }

        public string Name => this.name;
        public string Value => this.value;

        public override string ToString()
        {
            return $"{this.Name}={this.Value}";
        }
    }
}
