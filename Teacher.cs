
namespace Mobile_Module_1B
{    
    class Teacher : Person, ITalkable
    {
        private int age;
        public Teacher(int age, string name) {
            this.age = age;
            SetName(name);
        }

        public int GetAge() { return age; }
        public void SetAge(int age) { this.age = age; }
        public string Talk() { return "Don't forget to do the assigned reading!"; }
    }
}