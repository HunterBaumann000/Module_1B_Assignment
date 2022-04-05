namespace Mobile_Module_1B
{
    class Student : Person, ITalkable
    {
        private int age;
        public Student(int age, string name) {
            this.age = age;
            SetName(name);
        }

        public int GetAge() { return age; }
        public void SetAge(int age) { this.age = age; }
        public string Talk() { return "I like doing homework"; }
    }
}