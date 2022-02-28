namespace PeopleCharacter
{
    class Pragram
    {
        static void Main(string[] args)
        {
            People tom = new Student("Tom","CharacterPositiv");
            People kate = new Student("Tom", "CharacterNegativ");

            tom.PrintCharacter();
            kate.PrintCharacter();
         
           
        }
    }
    abstract class People
    {
        public string _name { get; }
        
        public People(string name)
        {
            _name = name;
        }
        public void PrintName()
        {
            Console.WriteLine($"Name: {_name}");
        }
        public abstract void PrintCharacter();
        

    }
    class Student : People
    {
        public string _character { get; }
        public Student(string name, string character) : base(name)
        {
            _character = character;
        }
        public override void PrintCharacter()
        {
            if(_character == "CharacterPositiv")
            {
                Console.WriteLine($"Name: {_name}\nCharacter: {_character}\nExamples of Positive Personality Traits: Being honest and taking responsibility for your actions are admirable qualities ");
            }
            else
            {
                Console.WriteLine($"Name: {_name}\nCharacter: {_character}\nExamples of Negative Personality Traits: A propensity for lying in order to avoid responsibility for one's actions is a deplorable quality.");
            }
        }
    }



}
