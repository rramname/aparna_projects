using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjOri_4_AssetSup
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of User :");
            int n1 = Convert.ToInt32(Console.ReadLine());
            User[] user = new User[n1];
            Asset[] asset = null;
            
            List<AssetLog> lstassetLog = new List<AssetLog>();

            UserBO userBo = new UserBO();
            AssetBO assetBo = new AssetBO();
          
            for (int i = 0; i < n1; i++)
            {
                Console.WriteLine("Enter the user detail " + (i + 1));

                string _userName = Console.ReadLine();

                int _employeeNo = Convert.ToInt32(Console.ReadLine());

                User u = new User(_userName, _employeeNo);
                user[i] = u;
                Console.WriteLine("Enter the number of asset used :");
                int n2 = Convert.ToInt32(Console.ReadLine());
                asset = new Asset[n2];
                //fill your code;      
                for (int j = 0; j < n2; j++)
                {
                    string s = Console.ReadLine();
                    string[] s1 = s.Split(',');

                    Asset a = new Asset(int.Parse(s1[0]), s1[1]);
                    AssetLog l = new AssetLog(u, a);
                    lstassetLog.Add(l);
                }
                
            }
            AssetLog[] assetLog = lstassetLog.ToArray();
            UserBO ubo = new UserBO();
            ubo.DisplayUserDetails(user);

            //fill your code;      

            Console.WriteLine("Enter the user name to find asset details");
            string userName = Console.ReadLine();
            //fill your code;      

            AssetBO abo = new AssetBO();
            abo.FindAssetDetail(assetLog, userName);

            Console.WriteLine("Enter the asset id to find its user");
            int assetId = Convert.ToInt32(Console.ReadLine());
            abo.FindUsers(assetLog, assetId);
            //fill your code;      


        }
    }
}
