namespace InterfaceSegregation
{
    public class Developer : IDevelopActivities,IDesingActivities
    {
        public Developer()
        {
        }

        

        public void Design() 
        {
            throw new ArgumentException();
        }

        public void Develop() 
        {
            Console.WriteLine("I'm developing the functionalities required");
        }

      
    }
}