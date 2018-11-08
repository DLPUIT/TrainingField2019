using Member_management_system.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Member_management_system
{
    class Executor//用于执行的类

    {
        private Member_management_system_Service Service = new Member_management_system_Service();//版本号一定要一致！
        //private DatabaseOperation dbhelper = new DatabaseOperation();//var 只能用在局部变量
        public void Run()
        {
            while (true)
            {
                try
                {
                    ShowHelp();
                    Console.WriteLine("# > ");
                    var userInput = Console.ReadLine();
                    
                    if (!string.IsNullOrWhiteSpace(userInput))
                    {
                        switch (userInput.Trim().ToLowerInvariant())//Trim()删除字符串开始和末尾的空格
                        {
                            case "a":
                                this.ShowAllMember();
                                continue;//结束当前循环
                            case "b":
                                this.AddNewMember();
                                continue;
                            case "c":
                                this.EditMember();
                                continue;
                            case "d":
                                this.DeleteMember();
                                continue;
                            case "e":
                                this.ShowRank();
                                continue;
                            case "f":
                                this.FindOne();
                                continue;
                            case "x":
                                this.Exit();//this 当前类里的函数（高素质的体现）
                                
                                return;
                        }
                    }
                    Console.WriteLine("您的输入不正确，请通过输入字母进行功能选择");
                    this.ShowHelp();
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"发生错误！请尝试重新操作，错误信息：{ex}");
                    this.ShowHelp();
                }
            }
        }
        public void ShowHelp()
        {
            Console.WriteLine("--------------------------");
            Console.WriteLine("请选择您要进行的功能");
            Console.WriteLine("A 查看所有人员信息");
            Console.WriteLine("B 添加一个新的成员");
            Console.WriteLine("C 修改一位已有成员");
            Console.WriteLine("D 删除一位已有成员");
            Console.WriteLine("E 查看积分排名");
            Console.WriteLine("F 查找一位已有成员");
            Console.WriteLine("X 退出程序");
            Console.WriteLine("--------------------------");

        }
        public void Exit()
        {
            Console.WriteLine();
            Console.WriteLine("# > Bye. ~");
            Environment.Exit(0);//return 0;
        }
        public void ShowAllMember()
        {
            Console.WriteLine("以下是全体成员信息");
            //var AllMember = this.dbhelper.GetAll();
            var AllMember = this.Service.GetAllMember();
            Console.WriteLine("班级 ID\t\t班级 Name\t\t姓名\t\t当前积分\t\t负责人\t\tGitHub");
            foreach(var user in AllMember)
            {
                Console.WriteLine($"{user.ClassId}\t\t{user.ClassName}\t\t\t{user.Name}\t\t{user.Credits}\t\t\t{user.Reportto}\t\t{user.GitHub}");
            }
        }
        public void AddNewMember()
        {

            Console.WriteLine("开始增加一位新的成员");
            var somebody = new User();
            Console.WriteLine("请输入班级ID");
            somebody.ClassId = Console.ReadLine();
            Console.WriteLine("请输入班级Name");
            somebody.ClassName = Console.ReadLine();
            Console.WriteLine("请输入姓名");
            somebody.Name  = Console.ReadLine();
            Console.WriteLine("请输入当前积分");
            somebody.Credits = int.Parse(Console.ReadLine());
            Console.WriteLine("请输入你的负责人");
            somebody.Reportto = Console.ReadLine();
            Console.WriteLine("请输入GitHub 账户");
            somebody.GitHub = Console.ReadLine();
            this.Service.AddMember(somebody);
            //this.dbhelper.Add(somebody);
            Console.WriteLine("成员已成功添加！");

        }
        public void EditMember()
        {
            Console.WriteLine("开始编辑成员信息，请输入成员姓名：");
            var name = Console.ReadLine();
            //var result = this.Service.FindMember(name);
            var Result = this.Service.FindMember(name);
            //var result = this.Service.Update(name);
            if(Result == null)
            {
                Console.WriteLine($"未找到成员{name}");
            }
            else
            {
                Console.WriteLine($"班级ID：{Result.ClassId}");
                Console.WriteLine($"班级Name：{Result.ClassName}");
                Console.WriteLine($"姓名：{Result.Name}");
                Console.WriteLine($"积分：{Result.Credits}");
                Console.WriteLine($"负责人：{Result.Reportto}");
                Console.WriteLine($"GitHub：{Result.GitHub}");
                Console.WriteLine();
                Console.WriteLine("开始录入更新后的信息：");
                Console.WriteLine("请输入班级ID");
                Result.ClassId = Console.ReadLine();
                Console.WriteLine("请输入班级Name");
                Result.ClassName = Console.ReadLine();
                Console.WriteLine("请输入姓名");
                Result.Name = Console.ReadLine();
                Console.WriteLine("请输入积分");
                Result.Credits = int.Parse(Console.ReadLine());
                Console.WriteLine("请输入负责人");
                Result.Reportto = Console.ReadLine();
                Console.WriteLine("请输入GitHub");
                Result.GitHub = Console.ReadLine();
                //this.dbhelper.Update(result);
                this.Service.Update(Result);
                Console.WriteLine("That is OK!");

            }
            
        }
        public void DeleteMember()
        {
            Console.WriteLine("删人了，快跑啊！！！");
            var name = Console.ReadLine();
            this.Service.DeleteMember(name);
            Console.WriteLine("已被删除！");

        }
        public void ShowRank()
        {
            Console.WriteLine("以下是全体积分的排名：");
            var Member = this.Service.GetRank();
            Console.WriteLine("班级 ID\t\t班级 Name\t\t姓名\t\t当前积分\t\t负责人\t\tGitHub");
            foreach(var member in Member)
            {
                Console.WriteLine($"{member.ClassId}\t\t{member.ClassName}\t\t\t{member.Name}\t\t{member.Credits}\t\t\t{member.Reportto}\t\t{member.GitHub}");

            }
        }
        public void FindOne()
        {
            Console.WriteLine("开始查找一位成员，请输入成员姓名：");
            var name = Console.ReadLine();
            var result = this.Service.FindMember(name);
            if (result == null)
            {
                Console.WriteLine($"未找到成员{name}");
            }
            else
            {
                Console.WriteLine($"班级ID：{result.ClassId}");
                Console.WriteLine($"班级Name：{result.ClassName}");
                Console.WriteLine($"姓名：{result.Name}");
                Console.WriteLine($"积分：{result.Credits}");
                Console.WriteLine($"负责人：{result.Reportto}");
                Console.WriteLine($"GitHub：{result.GitHub}");
                Console.WriteLine();
            }

        }
    }
    
    
}
