using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntegratingSystem
{
    class Executor
    {
        DatabaseOperation dbhelper = new DatabaseOperation();
        public void ShowHelp()
        {
            Console.WriteLine("------------------------------------");
            Console.WriteLine("请选择您要进行的功能");
            Console.WriteLine("A 查看所有人员信息");
            Console.WriteLine("B 添加一个新的成员");
            Console.WriteLine("C 修改一位已有成员");
            Console.WriteLine("D 删除一位已有成员");
            Console.WriteLine("E 查看积分排名");
            Console.WriteLine("F 查找一位已有成员");
            Console.WriteLine("X 退出程序");
            Console.WriteLine("------------------------------------");

        }
        public void Run()
        {
            while (true)
            {
                try
                {
                    Console.Write("# > ");

                    var userInput = Console.ReadLine();
                    if (!string.IsNullOrWhiteSpace(userInput))
                    {
                        switch (userInput.Trim().ToLowerInvariant())
                        {
                            case "a":
                                this.ShowAllMember();
                                continue;
                            case "b":
                                this.AddNewMember();
                                continue;
                         /*   case "c":
                                this.EditMember();
                                continue;
                            case "d":
                                this.DeleteMember();
                                continue;
                            case "e":
                                this.ShowRank();
                                continue;
                            case "f":s
                                this.FindOne();
                                continue;
                            case "x":
                                this.Exit();*/
                                return;
                        }
                    }
                }
                catch(Exception ex)
                {
                    Console.WriteLine($"发生错误！请尝试重新操作。错误信息: {ex}");
                    this.ShowHelp();
                }
                
            }
            
        }
        public void ShowAllMember()
        {
            Console.WriteLine("以下是全体成员的信息");
            var allMemter = dbhelper.GetAll();

            Console.WriteLine("班级 ID\t\t姓名\t\t当前积分\t\tGitHub");
            foreach(var user in allMemter)
            {
                Console.WriteLine($"{user.ClassId}\t\t{user.Name}\t\t{user.Credits}");
            }
        }
        public void AddNewMember()
        {
            Console.WriteLine("添加成员");
            var student = new User();
            dbhelper.Add(student);
            Console.WriteLine("请输入班级ID");
            student.ClassId = Console.ReadLine();
            Console.WriteLine("请输入姓名");
            student.Name = Console.ReadLine();
            Console.WriteLine("请输入当前积分");
            student.Credits = int.Parse(Console.ReadLine());
            Console.WriteLine("请输入 GitHub 账户");
            student.GitHub = Console.ReadLine();

            dbhelper.Add(student);
            Console.WriteLine("成员已成功添加");
        }
    }
}
