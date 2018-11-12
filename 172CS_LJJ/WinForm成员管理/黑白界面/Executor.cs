using DBService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace 黑白界面
{
    public class Executor
    {
        
        private readonly MainService service = new MainService();

        public void Run()
        {
            while (true)
            {
                try
                {
                    Console.Write("C:/>");
                    var Input = Console.ReadLine();
                    if (!string.IsNullOrWhiteSpace(Input))
                    {
                        switch (Input.Trim().ToLowerInvariant())
                        {
                            case "a":
                                this.ShowAllMembers();
                                continue;
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
                                this.Exit();
                                return;
                        }
                    }
                    Console.WriteLine("您的输入不正确，请通过输入字母进行功能选择");
                    this.ShowHelp();
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"发生错误！请尝试重新操作。错误信息: {ex}");
                    this.ShowHelp();
                }
            }
        }

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

        public void ShowAllMembers()
        {
            Console.WriteLine("以下是全体成员信息");
            var allMembers = this.service.GetAllMembers();
            Console.WriteLine("班级ID\t班级名字\t性别\t姓名\t当前积分\tGitHub\t\tReportTo\t英文名字");
            foreach (var user in allMembers)
            {
                Console.WriteLine($"{user.ClassId}\t{user.ClassName}\t{user.Gender}\t{user.Name}\t{user.Credits}\t\t{user.GitHub}\t{user.ReportTo}\t\t{user.EnglishName}");
            }
            this.ShowHelp();
        }

        public void AddNewMember()
        {
            Console.WriteLine("开始增加一位新的成员");
            var somebody = new User();
            Console.WriteLine("请输入班级ID");
            somebody.ClassId = Console.ReadLine();
            Console.WriteLine("请输入班级名字");
            somebody.ClassName = Console.ReadLine();
            Console.WriteLine("请输入性别");
            somebody.Gender = Console.ReadLine();
            Console.WriteLine("请输入姓名");
            somebody.Name = Console.ReadLine();
            Console.WriteLine("请输入当前积分");
            somebody.Credits = int.Parse(Console.ReadLine());
            Console.WriteLine("请输入 GitHub 账户");
            somebody.GitHub = Console.ReadLine();
            Console.WriteLine("请输入ReportTo");
            somebody.ReportTo = Console.ReadLine();
            Console.WriteLine("请输入英文名字");
            somebody.EnglishName = Console.ReadLine();
            this.service.AddMember(somebody);
            Console.WriteLine("成员已成功添加");
            this.ShowHelp();
        }
        private readonly DatabaseOperation dbService = new DatabaseOperation();
        public void EditMember()
        {
            Console.WriteLine("开始编辑成员信息，请输入成员姓名: ");
            var name = Console.ReadLine();
            var result = this.service.FindMember(name);
            if (result == null)
            {
                Console.WriteLine($"未找到成员 {name}");
            }
            else
            {
                Console.WriteLine($"班级 ID: {result.ClassId}");
                Console.WriteLine($"班级名字: {result.ClassName}");
                Console.WriteLine($"性别: {result.Gender}");
                Console.WriteLine($"姓名: {result.Name}");
                Console.WriteLine($"积分: {result.Credits}");
                Console.WriteLine($"GitHub: {result.GitHub}");
                Console.WriteLine($"ReportTo: {result.ReportTo}");
                Console.WriteLine($"英文名字: {result.EnglishName}");
                Console.WriteLine();
                Console.WriteLine("开始录入更新后的信息:");
                Console.WriteLine("请输入班级ID");
                result.ClassId = Console.ReadLine();
                Console.WriteLine("请输入班级名字");
                result.ClassName = Console.ReadLine();
                Console.WriteLine("请输入性别");
                result.Gender = Console.ReadLine();
                Console.WriteLine("请输入姓名");
                result.Name = Console.ReadLine();
                Console.WriteLine("请输入当前积分");
                result.Credits = int.Parse(Console.ReadLine());
                Console.WriteLine("请输入 GitHub 账户");
                result.GitHub = Console.ReadLine();
                Console.WriteLine("请输入ReportTo");
                result.ReportTo = Console.ReadLine();              
                Console.WriteLine("请输入英文名字");
                result.EnglishName = Console.ReadLine();
                this.service.UpdateMember(result);
                Console.WriteLine("用户信息已更新");
            }
            this.ShowHelp();
        }

        public void DeleteMember()
        {
            Console.WriteLine("开始删除一位成员，请输入成员姓名: ");
            var name = Console.ReadLine();
            this.service.DeleteMember(name);
            Console.WriteLine("用户已删除");
            this.ShowHelp();
        }

        public void ShowRank()
        {
            Console.WriteLine("以下是全体成员积分排行榜");

            var allMembers = this.service.GetRank();
            Console.WriteLine("姓名\t\t当前积分");
            foreach (var user in allMembers)
            {
                Console.WriteLine($"{user.Name}\t\t{user.Credits}");
            }
            this.ShowHelp();
        }

        public void FindOne()
        {
            Console.WriteLine("开始查找一位成员，请输入成员姓名: ");
            var name = Console.ReadLine();

            var result = this.service.FindMember(name);
            if (result == null)
            {
                Console.WriteLine($"未找到成员 {name}");
            }
            else
            {
                Console.WriteLine($"姓名: {result.Name}");
                Console.WriteLine($"班级 ID: {result.ClassId}");
                Console.WriteLine($"班级名字: {result.ClassName}");
                Console.WriteLine($"性别: {result.Gender}");
                Console.WriteLine($"Credits: {result.Credits}");
                Console.WriteLine($"GitHub: {result.GitHub}");
                Console.WriteLine($"ReportTo: {result.ReportTo}");
                Console.WriteLine($"EnglishName: {result.EnglishName}");
            }
            this.ShowHelp();
        }

        public void Exit()
        {
            Console.WriteLine();
            Console.WriteLine("C:/> Bye.");
            Environment.Exit(0);
        }
    }
}
