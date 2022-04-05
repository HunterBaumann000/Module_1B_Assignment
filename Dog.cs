namespace Mobile_Module_1B
{
    class Dog : Pet, ITalkable
    {
        private bool friendly;
        public Dog(bool friendly, string name) : base(name) {
            this.friendly = friendly;
        }

        public bool IsFriendly() { return friendly; }

        public string GetName() {
            return name;
        }

        public string Talk() { return "Bark"; }

        public override string ToString()
        {
            return $"Dog: name={name} friendly={friendly}";
        }
    }
}