namespace Mobile_Module_1B
{
    abstract class Person
    {
        protected string name;

        public string GetName() { return name; }
        public void SetName(string name) { this.name = name; }
    }
}