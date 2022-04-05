namespace Mobile_Module_1B
{
    public class UserInput
    {
        public Object GetUserInput() {
            //input
            String userInput = "";
            Object obj;

            //console prompts begin
            while(userInput != ".") {
                Console.WriteLine("Do you want to add a Person or Pet? ( '.' to quit)");
                userInput = Console.ReadLine();

                if(userInput == "pet") 
                {
                    Console.WriteLine("Do you want to add a Cat or Dog?");
                    userInput = Console.ReadLine();
                
                    if(userInput == "cat"){
                        Console.WriteLine("What is the cat's name?");
                        string tempName = Console.ReadLine();
                    
                        Console.WriteLine("How many mice has the cat killed");
                        int tempKilled = Int32.Parse(Console.ReadLine());

                        Cat cat = new Cat(tempKilled, tempName);

                        return cat;

                    } else {
                        Console.WriteLine("What is the dog's name?");
                        string tempName = Console.ReadLine();
                
                        Console.WriteLine("Is the dog friendly? (true or false)");
                        string tempFriendly = Console.ReadLine();
                        bool friendly = (tempFriendly == "true" ? true : false);
                    
                        Dog dog = new Dog(friendly, tempName);

                        return dog;
                    }
                } 
                else
                {
                    Console.WriteLine("Do you want to add a Teacher or Student?");
                    userInput = Console.ReadLine();

                    if(userInput == "teacher"){
                        Console.WriteLine("What is the teacher's name?");
                        string tempName = Console.ReadLine();
                    

                        Console.WriteLine("How old is the teacher");
                        int tempAge = Int32.Parse(Console.ReadLine());

                        Teacher teacher = new Teacher(tempAge, tempName);

                        return teacher;

                    } else {
                        Console.WriteLine("What is the student's name?");
                        string tempName = Console.ReadLine();

                        Console.WriteLine("What is the student's age?");
                        int tempAge = Int32.Parse(Console.ReadLine());

                        Student student = new Student(tempAge, tempName);

                        return student;
                    }

                }
            }

            return null;
            
            Console.WriteLine( userInput + " has been added");

        }  
    }
}