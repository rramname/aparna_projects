namespace ObjectOri_9_UserDetails
{
    internal class FixedLengthUserData : UserInterface
    {
        public void CreateUser(string data)
        {
            if (data.Length < 30)
                System.Console.WriteLine("Invalid format");
            else
            {
                System.Console.WriteLine("User Name : " + data.Substring(0, 10));
                System.Console.WriteLine("Register Number : " + data.Substring(10, 10));
                System.Console.WriteLine("Email : " + data.Substring(20, 10));
            }
        }
    }
}