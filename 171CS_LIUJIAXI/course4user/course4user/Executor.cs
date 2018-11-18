using DlpuManager.Service;
using System;

namespace course4user
{
    class Executor
    {
        private DlpuManagerService service = new DlpuManagerService();

        public void Run()
        {
            while (true)
            try{

                Console.WriteLine("\n# > ");

                //ShowHelp();
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
                Console.WriteLine("您的输入不正确，请重新输入字母进行功能选择");
                this.ShowHelp();
            }
            catch(Exception ex)
            {
                Console.WriteLine($"发生错误！请尝试重新操作，错误信息：{ex}");
                this.ShowHelp();
            }
        }
        public void ShowHelp()
        {
            Console.WriteLine("...................................................");
            Console.WriteLine("请选择您要进行的功能");
            Console.WriteLine("A 查看所有人的信息");
            Console.WriteLine("B 添加一个新的成员");
            Console.WriteLine("C 修改一位已有成员");
            Console.WriteLine("D 删除一位已有成员");
            Console.WriteLine("E 查看积分排名");
            Console.WriteLine("F 查找一位已有成员");
            Console.WriteLine("X 退出程序");
            Console.WriteLine("...................................................");
        }

        //DatabaseOperation dbhelper = new DatabaseOperation();

        public void ShowAllMember()
        {
            Console.WriteLine("以下是全体成员信息");
            var allMember = this.service.GetAllMember();
            Console.WriteLine("班级 ID\t\t班级Name\t姓名\t\t当前积分\t性别\t\tGitHub\n");
            foreach(var user in allMember)
            {
                Console.WriteLine($"{user.ClassId}\t\t{user.ClassId}\t\t{user.Name}\t\t{user.Credits}\t\t{user.Gender}\t\t{user.GitHub}");
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
            somebody.Name = Console.ReadLine();
            Console.WriteLine("请输入当前积分");
            somebody.Credits = int .Parse(Console.ReadLine());
            Console.WriteLine("请输入性别");
            somebody.Gender = Console.ReadLine();
            Console.WriteLine("请输入GitHub账户");
            somebody.GitHub = Console.ReadLine();
            this.service.AddMember(somebody);
           
            Console.WriteLine("成员已成功添加");
        }
        public void EditMember()
        {
            Console.WriteLine("开始编辑成员信息，请输入成员姓名");
            var name = Console.ReadLine();

            var result = this.service.FindMember(name);
          
            if(result == null)
            {
                Console.WriteLine($"未找到成员{name}");
            }
            else
            {
                Console.WriteLine($"班级 ID:{result.ClassId}");
                Console.WriteLine($"班级 Name:{result.ClassName}");
                Console.WriteLine($"姓名:{result.Name}");
                Console.WriteLine($"积分：{result:Credits}");
                Console.WriteLine($"性别:{result.Gender}");
                Console.WriteLine($"GitHub{result.GitHub}");

                Console.WriteLine();
                Console.WriteLine("开始录入更新后的信息");
                Console.WriteLine("请输入班级ID");
                result.ClassId = Console.ReadLine();
                Console.WriteLine("请输入班级Name");
                result.ClassName = Console.ReadLine();
                Console.WriteLine("请输入姓名");
                result.Name = Console.ReadLine();
                Console.WriteLine("请输入当前积分");
                result.Credits = int .Parse(Console.ReadLine());
                Console.WriteLine("请输入性别");
                result.Gender = Console.ReadLine();
                Console.WriteLine("请输入GitHub账户");
                result.GitHub = Console.ReadLine();

                //this.dbhelper.DeleteMany(x => x.Name == name);
                this.service.UpdateMember(result);
                Console.WriteLine("用户信息已更新");
            }
        }
        public void DeleteMember()
        {
            Console.WriteLine("开始删除一位成员，请输入成员姓名：");
            var name = Console.ReadLine();
            //this.dbhelper.DeleteMany(x => x.Name == name);
            this.service.DeleteMember(name);
            Console.WriteLine("用户已删除");
        }
        public void ShowRank()
        {
            Console.WriteLine("以下是全体成员积分排行榜");
            var allMember = this.service.GetRank();
            //var allMember = this.dbhelper.GetAll().OrderByDescending(x => x.Credits);
            Console.WriteLine("班级 ID\t\t班级Name\t\t姓名\t\t当前积分");
            foreach(var user in allMember)
            {
                Console.WriteLine($"{user.ClassId}\t\t{user.ClassName}\t\t{user.Name}\t\t{user.Credits}");
            }
            //与逻辑有关，比如查看 前十名 大二女 同学的排名：逻辑不应该被重复写，应该别统一的控制
            //引出逻辑层
        }
        public void FindOne()
        {
            Console.WriteLine("开始查找一位成员，请输入成员姓名：");
            var name = Console.ReadLine();
            var result = this.service.FindMember(name);
            if (result == null)
            {
                Console.WriteLine($"班级 ID:{result.ClassId}");
                Console.WriteLine($"班级Name:{result.ClassName}");
                Console.WriteLine($"姓名:{result.Name}");
                Console.WriteLine($"积分：{result:Credits}");
                Console.WriteLine($"性别:{result.Gender}");
                Console.WriteLine($"GitHub{result.GitHub}");
            }
            else
            {
                Console.WriteLine($"未找到成员{name}");
            }
        }
        public void Exit()
        {
            Console.WriteLine();
            Console.WriteLine("# > Bye. ~");
            Environment.Exit(0);//return 0;
        }

 
    }
}
