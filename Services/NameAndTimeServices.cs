namespace TwoToFour_Endpoints.Services
{
    public class NameAndTimeServices
    {
        public string NameAndTime(string name, int time)
        {
            return $"Your name is {name}, and the time you woke up is {time}.";
        }
    }
}