namespace Mobile_Module_1B
{
    class Cat : Pet, ITalkable
    {
        private int mousesKilled;
        public Cat(int mousesKilled, string name) : base(name) {
            this.mousesKilled = mousesKilled;
        }

        public string GetName() {
            return name;
        }

        public int GetMousesKilled() { return mousesKilled; }
        public void AddMouse() { mousesKilled++; }

        public string Talk() { return "Meow"; }
        override public string ToString() { return $"Cat: name={name} mousesKilled={mousesKilled}"; }
    }
}