using DataService;
using System;
namespace Studentmanage
{
    internal class Executor
    {
        private readonly Dataservices dataservices = new Dataservices();

        public void Run()
        {
            while (true)
            {
                try
                {
                    Console.WriteLine("# >");

                    var userInput = Console.ReadLine();
                    //将输入字符变为小写形式
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
                            case "c":
                                this.UpdataMember();
                                continue;
                            case "d":
                                this.DelMember();
                                continue;
                            case "e":
                                this.ShowRank();
                                continue;
                            case "f":
                                this.FindMember();
                                continue;
                            case "g":
                                this.Exit();
                                continue;
                        }
                    }
                    Console.WriteLine("输入错误，请输入对应字母：");
                    this.Showhelp();
                }
                //错误处理
                catch (Exception ex)
                {
                    Console.WriteLine($"发生错误！请尝试重新操作。错误信息: {ex}");
                    this.Showhelp();
                }
            }
        }
        public void Showhelp()
        {
            Console.WriteLine("************************************");
            Console.WriteLine("请选择您要进行的功能");
            Console.WriteLine("A 查看所有人员信息");
            Console.WriteLine("B 添加一个新的成员");
            Console.WriteLine("C 修改一位已有成员");
            Console.WriteLine("D 删除一位已有成员");
            Console.WriteLine("E 查看积分排名");
            Console.WriteLine("F 查找一位已有成员");
            Console.WriteLine("G 退出程序");
            Console.WriteLine("************************************");
        }

        public void ShowAllMember()
        {
            Console.WriteLine("以下是全体人员信息：");

            var allmember = this.dataservices.GetAllmenber();
            Console.WriteLine("班级 ID\t姓名\t性别\t当前积分\tGitHub\t英文名\tCSDN\tEmail");
            foreach (var user in allmember)
            {
                Console.WriteLine($"{user.ClassId}\t{user.Name}\t{user.Gender}\t{user.Credits}\t\t{user.GitHub}\t{user.English_Name}\t{user.CSDN}\t{user.Email}");
            }
        }

        public void AddNewMember()
        {
            Console.WriteLine("又来一位新同学，快来填写资料吧：");

            var someone = new User();
            Console.WriteLine("请输入班级ID：");
            someone.ClassId = Console.ReadLine();
            Console.WriteLine("请输入姓名：");
            someone.Name = Console.ReadLine();
            Console.WriteLine("请输入性别：");
            someone.Gender = Console.ReadLine();
            Console.WriteLine("请输入当前积分：");
            someone.Credits = int.Parse(Console.ReadLine());
            Console.WriteLine("请输入Github账号：");
            someone.GitHub = Console.ReadLine();
            Console.WriteLine("请输入你的英文名：");
            someone.English_Name = Console.ReadLine();
            Console.WriteLine("请输入你的CSDN账号：");
            someone.CSDN = Console.ReadLine();
            Console.WriteLine("请输入你的Emai：");
            someone.Email = Console.ReadLine();

            this.dataservices.Addmember(someone);
            Console.WriteLine("成员已添加");

        }

        public void UpdataMember()
        {
            Console.WriteLine("成员有变动啦，快点更新数据吧");
            Console.WriteLine("请输入要更新者的姓名：");
            var name = Console.ReadLine();

            var result = this.dataservices.FindMember(name);
            if (result == null)
            {
                Console.WriteLine("无匹配信息");
            }
            else
            {
                Console.WriteLine("该成员信息如下：");
                Console.WriteLine();
                Console.WriteLine("班级 ID\t姓名\t性别\t当前积分\tGitHub\t英文名\tCSDN\tEmail");
                Console.WriteLine($"{result.ClassId}\t{result.Name}\t{result.Gender}\t{result.Credits}\t\t{result.GitHub}\t{result.English_Name}\t{result.CSDN}\t\t{result.Email}");

                Console.WriteLine();
                Console.WriteLine("开始录入更新后的信息:");
                Console.WriteLine("请输入班级ID：");
                result.ClassId = Console.ReadLine();
                Console.WriteLine("请输入姓名：");
                result.Name = Console.ReadLine();
                Console.WriteLine("请输入性别：");
                result.Gender = Console.ReadLine();
                Console.WriteLine("请输入当前积分：");
                result.Credits = int.Parse(Console.ReadLine());
                Console.WriteLine("请输入Github账号：");
                result.GitHub = Console.ReadLine();
                Console.WriteLine("请输入你的英文名：");
                result.English_Name = Console.ReadLine();
                Console.WriteLine("请输入你的CSDN账号：");
                result.CSDN = Console.ReadLine();
                Console.WriteLine("请输入你的Emai：");
                result.Email = Console.ReadLine();

                this.dataservices.Updatamember(result);
                Console.WriteLine("用户信息已更新");

            }
        }

        public void DelMember()
        {
            Console.WriteLine("请输入要删除者的姓名：");
            var name = Console.ReadLine();

            var result = this.dataservices.FindMember(name);
            if (result == null)
            {
                Console.WriteLine("无匹配信息");
            }
            else
            {
                this.dataservices.DeleteMember(name);
                Console.WriteLine("用户已删除");
            }
        }

        public void ShowRank()
        {
            Console.WriteLine("以下是全体成员积分排行榜");

            var allmembers = this.dataservices.GetRank();
            Console.WriteLine("班级 ID\t\t姓名\t\t当前积分");
            foreach (var user in allmembers)
            {
                Console.WriteLine($"{user.ClassId}\t\t{user.Name}\t\t{user.Credits}");
            }
        }

        public void FindMember()
        {
            Console.WriteLine("开始查找一位成员，请输入成员姓名: ");
            var name = Console.ReadLine();

            var result = this.dataservices.FindMember(name);
            if (result == null)
            {
                Console.WriteLine($"未找到成员 {name}");
            }
            else
            {
                Console.WriteLine("班级 ID\t姓名\t性别\t当前积分\tGitHub\t英文名\tCSDN\tEmail");
                Console.WriteLine($"{result.ClassId}\t{result.Name}\t{result.Gender}\t{result.Credits}\t\t{result.GitHub}\t{result.English_Name}\t{result.CSDN}\t{result.Email}");

            }
        }

        public void Exit()
        {
            Console.WriteLine();
            Console.WriteLine("# > Bye. ~");
            Environment.Exit(0);
        }
    }
}
