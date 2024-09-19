namespace TrainingCodes
{
    internal class OOP_Inheritance
    {
        //Example1
        static void Main(string[] args)
        {

            Parent p = new Parent("Jenney", "Female", 46);
            p.introduceSelf();

            Console.WriteLine();
            
            Toddler t = new Toddler("JC", "Male", 3, "Close/Open");
            t.introduceSelf();
            t.cry();


            /*

           Console.WriteLine();

           Child c = new Child("Ryan", "Male", 6, "Hide n Sick", "Biking");
           c.introduceSelf();
           c.cry();
           c.doHobby();
           */
        }
    }
    class Parent
    {
        public string name { get; set; }
        public int age { get; set; }
        public string sex { get; set; }

        public Parent(string name, string sex, int age)
        {
            this.name = name;
            this.sex = sex;
            this.age = age;
        }
        public void introduceSelf() //Overriding Methods
        {
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Sex : " + sex);
            Console.WriteLine("Age : " + age);
        }
    }
    class Toddler : Parent
    {
        public string favGame { get; set; }
                                                                           //base keyword
        public Toddler(string name, string sex, int age, string favGame) : base(name, sex, age)
        {
            this.favGame = favGame;
        }
        public void introduceSelf()
        {
            base.introduceSelf();
            Console.WriteLine("Favorite Game: " + favGame);
        }
        public void cry()
        {
            Console.WriteLine(name + " is  Crying");
        }

        /*
    class Child : Toddler
    {
        public string hobby { get; set; }

        public Child (string name, string sex, int age, string favGame,string hobby) 
            : base (name,sex,age,favGame)
        {
            this.hobby = hobby;
        }
        public void doHobby()
        {
            Console.WriteLine(name + "is" + hobby);
        }
    */
    }

}

