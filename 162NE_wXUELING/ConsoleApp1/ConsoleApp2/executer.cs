using System;
using System.Linq;

namespace ConsoleApp2
{
    internal class executer
    {
        
            public  void showhelp()
        {//j静态方法调静态方法

            Console.WriteLine("-----------------------*****************");
            Console.WriteLine("choose one please");
            Console.WriteLine("A,look  for all members");
            Console.WriteLine("B,add a new member");
            Console.WriteLine("C,update a new menber");
            Console.WriteLine("D,delete an old member");
            Console.WriteLine("E,look for the order of grade");
            Console.WriteLine("F,find an old member");
            Console.WriteLine("X,exit all");
            Console.WriteLine("************************************");

        }
        public void ShowAllMember()
        {
            Console.WriteLine("all member infomation as follow");
            var dbhelper = new DatabaseOperation();
            var allMember = dbhelper.GetAll();
            Console.WriteLine("班级 ID\t\t姓名\t\t积分\t\t github");
            foreach( var user in allMember)
            {
                Console.WriteLine($"{user.ClassId}\t\t{user.Name}\t\t{user.Credits}\t\t{user.Github}");

            }
        }

        public  void run(){
             while (true)
            {
                

                showhelp();
               Console.WriteLine("your choice is :");
                var userinput = Console.ReadLine();
                if (!string.IsNullOrWhiteSpace(userinput))//判断输入是否为空，或者输入是否为空格
                {
                    switch (userinput.Trim().ToLowerInvariant())//除去空行，转换大小写
                    {
                        case "a":
                            this.ShowAllMember();
                            continue;
                        case "b":
                            this.AddNewMember();
                            continue ;
                        case "c":
                            this.DeleteMenber();
                            continue;
                        case "d":
                            this.ShowRank();
                            continue;
                        case "e":
                            this.Find();
                            continue;
                        
                        case "f":
                            this.Exit();
                            continue;


                    }
                     
                }
            }
         }

        private void Find()
        {
            throw new NotImplementedException();
        }

        private void DeleteMenber()
        {
            Console.WriteLine("delet a member now  ");
            var name = Console.ReadLine();
            var dbhelper = new DatabaseOperation();
            
          dbhelper.DeleteMany(x => x.Name == name);

        }

        private void ShowRank()
        {
            var dbhelper = new DatabaseOperation();
            Console.WriteLine();

            var all = dbhelper.GetAll();
        }

        private void AddNewMember()
        {
            Console.WriteLine("add a new member now");

            var somebody = new User();

            Console.WriteLine("classid:");

            somebody.ClassId = Console.ReadLine();
            Console.WriteLine("name:");

            somebody.Name = Console.ReadLine();
            Console.WriteLine("Credits:");
            somebody.Credits = int.Parse(Console.ReadLine());
            Console.WriteLine("github:");

            somebody.Github = Console.ReadLine();
            // this.service.AddMember(somebody);
            var dbhelper = new DatabaseOperation();
            dbhelper.Add(somebody);
            Console.WriteLine("have done");

        }

        void Exit()
        {
            Console.WriteLine("byebye");
            Console.WriteLine("**------**");
            Environment.Exit(0);
            //相当于return 0;
        }


    }
}