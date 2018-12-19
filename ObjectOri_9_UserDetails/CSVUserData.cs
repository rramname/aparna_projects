namespace ObjectOri_9_UserDetails
{
    internal class CSVUserData : UserInterface
    {
        public void CreateUser(string data)
        {
            string[] str = data.Split(',');
            System.Console.WriteLine("User Details");
            System.Console.WriteLine("User Name : "+str[0]);
            System.Console.WriteLine("Register Number : " + str[1]);
            System.Console.WriteLine("Email : " + str[2]);
        }
    }
}