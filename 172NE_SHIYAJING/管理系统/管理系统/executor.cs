using System;
namespace 管理系统
{
    using DLPU.Service;
    
    internal class Executor
    {
        private readonly DLPUService Service = new DLPUService();
        public void Run()
        {
            while (true)
            {
                try
                {
                    Console.WriteLine("# >");
                    var userinput = Console.ReadLine();
                    //Console.WriteLine();
                    if (!string.IsNullOrWhiteSpace(userinput))
                    {
                        switch (userinput.Trim().ToLowerInvariant())
                        {
                             case "a": this.Showallnumber(); continue;
                             case "b": this.Addnewmember(); continue;
                             case "c": this.Delmember(); continue;
                             case "d": this.Editmember(); continue;
                             case "e": this.Showrank(); continue;
                             case "f": this.Findnumber(); continue;
                             case "g": this.Exit(); return;
                        }
                    }
                    Console.WriteLine("您输入的不正确，请重新以字母形式输入：");
                    this.Showhelp();
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"发生错误，请重新操作，错误信息：{ex}");
                    this.Showhelp();

                }
            }
        }
        public void Showhelp()
        {
            Console.WriteLine("\t\t\t\t\t-----------------------------");
            Console.WriteLine("\t\t\t\t\t\t请选择您要进行的选项");
            Console.WriteLine("\t\t\t\t\t\tA 查询信息");
            Console.WriteLine("\t\t\t\t\t\tB 添加信息");
            Console.WriteLine("\t\t\t\t\t\tC 删除信息");
            Console.WriteLine("\t\t\t\t\t\tD 修改信息");
            Console.WriteLine("\t\t\t\t\t\tE 积分信息");
            Console.WriteLine("\t\t\t\t\t\tF 个人查找");
            Console.WriteLine("\t\t\t\t\t\tG 退出系统");
            Console.WriteLine("\t\t\t\t\t-----------------------------");

        }
       
        public void Showallnumber()
        {
            Console.WriteLine("以下是全体成员的信息");
            
            //var allnumber = this.service.GetAll();


           var allmember = this.Service.GetAllmember();
             Console.WriteLine("班级 ID\t\t姓名\t\t当前积分\t\tReportTo\t\tGitHub");
             foreach (var User in allmember)
            {
                Console.WriteLine($"{User.ClassId}\t\t{User.ClassName}\t\t{User.Name}\t\t{User.Gredits }\t\t{ User.ReportTo}\t\t{User.Github }");
            }

        }
        public void Addnewmember()
        {
            Console.WriteLine("开始增加一位新的成员");
             var somebody = new User();
             Console.WriteLine("请输入班级ID:");
             somebody.ClassId = Console.ReadLine();
             Console.WriteLine("请输入姓名:");
             somebody.Name = Console.ReadLine();
             Console.WriteLine("请输入积分：");
             somebody.Gredits = int.Parse(Console.ReadLine());
             Console.WriteLine("请输入leader:");
             somebody.ReportTo = Console.ReadLine();
             Console.WriteLine("请输入Github账号:");
             somebody.Github = Console.ReadLine();
             this.Service.Addnewmember(somebody);
             Console.WriteLine("添加成功");
        }
        public void Delmember()

        {
            Console.WriteLine("开始删除");
            var name = Console.ReadLine();
            this.Service.Delmember(name);
            Console.WriteLine("用户已删除");
        }
        public void Showrank()
        {
            Console.WriteLine("成员排行：");
            var allMember = this.Service.Getrank();
            Console.WriteLine("班级 ID\t\t姓名\t\t当前积分\t\tReportTo\t\tGitHub");
            foreach (var User in allMember)
            {
                Console.WriteLine($"{User.ClassId}\t\t{User.ClassName}\t\t{User.Name}\t\t{User.Gredits }\t\t{User.Gender}\t\t{ User.ReportTo}\t\t{User.Github }");
            }
        }
        public void Editmember()
        {
            Console.WriteLine("开始编辑成员信息，请输入成员姓名：");
            var name = Console.ReadLine();
            var result = this.Service.Findmember(name);
        
            if (result == null)
            {
                Console.WriteLine($"未找到成员{name}");
            }
            else
            {
                Console.WriteLine($"姓名：{result.Name}");
                Console.WriteLine($"班级ID：{result.ClassId }");
                Console.WriteLine($"积分：{result.Gredits}");
                Console.WriteLine($"性别：{result.Gender}");
                Console.WriteLine($"leader：{result.ReportTo}");
                Console.WriteLine($"Github账号：{result.Github }");
                Console.WriteLine();
                Console.WriteLine("开始录入更新后的信息：");
                Console.WriteLine("请输入班级ID:");
                result.ClassId = Console.ReadLine();
                Console.WriteLine("请输入姓名:");
                result.Name = Console.ReadLine();
                Console.WriteLine("请输入积分：");
                result.Gredits = int.Parse(Console.ReadLine());
                Console.WriteLine("请输入性别:");
                result.Gender = bool.Parse(Console.ReadLine());
                Console.WriteLine("请输入leader:");
                result.ReportTo = Console.ReadLine();
                Console.WriteLine("请输入Github账号:");
                result.Github = Console.ReadLine();
                this.Service.Updatemember(result);
                Console.WriteLine("用户信息已更新");

            }
        }
        public void Findnumber()
        {
            Console.WriteLine("开始查找一位成员，请输入成员姓名: ");
            var name = Console.ReadLine();

            var result = this.Service.Findmember(name);
            if (result == null)
            {
                Console.WriteLine($"未找到成员 {name}");
            }
            else
            {
                Console.WriteLine($"姓名：{result.Name}");
                Console.WriteLine($"班级ID：{result.ClassId }");
                Console.WriteLine($"积分：{result.Gredits}");
                Console.WriteLine($"性别：{result.Gender}");
                Console.WriteLine($"leader：{result.ReportTo}");
                Console.WriteLine($"Github账号：{result.Github }");
            }
        }
        public void Exit()
        {
            Console.WriteLine();
            Console.WriteLine("# > 正在退出，请稍等，，，，");
            Environment.Exit(0);
        }

    }
  
}
