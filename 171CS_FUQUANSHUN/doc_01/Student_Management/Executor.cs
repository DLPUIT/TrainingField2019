
// 命令解析器、执行器

using DLPU_Manager;
using DLPU_Manager.service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Management
{
    internal class Executor
    {
        private readonly DLPU_ManageService service = new DLPU_ManageService();
        // var 只能用在局部变量
        public void ShowHelp()
        {
            Console.WriteLine("* * * * * * * * * * * * * * *");
            Console.WriteLine("系统功能列表：");
            Console.WriteLine("A 查看所有人员信息");
            Console.WriteLine("B 增加新成员");
            Console.WriteLine("C 删除成员");
            Console.WriteLine("D 修改成员信息");
            Console.WriteLine("E 查找成员");
            Console.WriteLine("F 查看积分排名");
            Console.WriteLine("G 退出程序");
            Console.WriteLine("* * * * * * * * * * * * * * *");
        }

        public void ShowAllMember()
        {
            Console.WriteLine("以下是全体成员信息：");
            var allMember = this.service.GetAllMember();
            Console.WriteLine("班级ID\t\t姓名\t\t当前积分\t\tGitHub账号");
            //   /t 制表符 tab 键
            foreach (var user in allMember)
            {
                Console.WriteLine($"{user.ClassId}\t\t{user.Name}\t\t{user.Credit}\t\t{user.GitHub}");
                // 输出变量值
            }
        }

        public void AddNewMember()
        {
            Console.WriteLine("开始增加新成员：");
            var somebody = new User();
            Console.Write("请输入班级ID：");
            somebody.ClassId = Console.ReadLine();
            Console.Write("请输入姓名：");
            somebody.Name = Console.ReadLine();
            Console.Write("请输入当前积分：");
            somebody.Credit = int.Parse(Console.ReadLine());
            Console.Write("请输入GitHub账号：");
            somebody.GitHub = Console.ReadLine();
            this.service.AddMember(somebody);
            Console.WriteLine("添加成功！！！");
        }

        public void DeleteMember()
        {
            Console.Write("请输入需要删除成员姓名：");
            var name = Console.ReadLine();
            this.service.DeleteMember(name);
            // this.service.DeleteMember(name);
            Console.WriteLine("成员删除成功！！！");
        }

        public void EditMember()
        {
            Console.Write("开始修改成员信息，请输入所要编辑成员姓名：");
            var name = Console.ReadLine();
            var result = this.service.FindMember(name);
            if (result == null)
            {
                Console.WriteLine($"未找到成员：{name}");
            }
            else
            {
                Console.WriteLine($"姓名：{result.Name}");
                Console.WriteLine($"班级ID：{result.ClassId}");
                Console.WriteLine($"当前积分：{result.Credit}");
                Console.WriteLine($"GitHub账号：{result.GitHub}");
                Console.WriteLine();
                Console.WriteLine("开始编辑···");
                Console.Write("请输入班级ID：");
                result.ClassId = Console.ReadLine();
                Console.Write("请输入姓名：");
                result.Name = Console.ReadLine();
                Console.Write("请输入当前积分：");
                result.Credit = int.Parse(Console.ReadLine());
                Console.Write("请输入GitHub账号：");
                result.GitHub = Console.ReadLine();
                this.service.UpdateMember(result);
                Console.WriteLine("成员信息更新成功！！！");

            }

        }

        public void FindOne()
        {
            Console.Write("开始查找成员信息···请输入成员姓名：");
            var name = Console.ReadLine();
            var result = this.service.FindMember(name);
            if (result == null)
            {
                Console.WriteLine($"未找到该成员：{name}");
            }
            else
            {
                Console.WriteLine($"姓名：{result.Name}");
                Console.WriteLine($"班级ID：{result.ClassId}");
                Console.WriteLine($"当前积分：{result.Credit}");
                Console.WriteLine($"GitHub账号：{result.GitHub}");
            }
        }

        public void ShowRank()
        {
            Console.WriteLine("以下是成员积分排行：");
            var allMember = this.service.GetAllMember().OrderByDescending(x => x.Credit);
            // OrderBy 从小到大排序   rderByDescending 从大到小排序
            Console.WriteLine("班级ID\t\t姓名\t\t当前积分");
            foreach (var user in allMember)
            {
                Console.WriteLine($"{user.ClassId}\t\t{user.Name}\t\t{user.Credit}");
            }
        }        

        public void Exit()
        {
            Console.WriteLine();
            Console.WriteLine("拜拜了您······");
            Environment.Exit(0);                    // 相当于 C 语言中 main 函数的 return0
            // 操作系统执行程序，最后把 0 返还给操作系统，表示运行正常，返回其他错误码表示其他问题，有一个错误码表
            // main 函数最后自己会自动执行 return 0 ，自己写也可以
        }

        public void Run ()
        {
            while (true)
            {
                Console.Write("请选择所需要的功能>>>");          // 输出不换行
                var userInput = Console.ReadLine();
                if (!string.IsNullOrWhiteSpace(userInput))
                {
                    switch (userInput.Trim().ToLowerInvariant())
                    // string 方法 trim() 作用去除输入内容前后的空格
                    // string 方法 TolowerInvariant() 作用把大写字母全变成小写？？？大小写结合会怎样
                    {
                        case "a":
                            this.ShowAllMember();                           
                            continue;       // 结束当前while循环，开始下次循环
                        case "b":
                            this.AddNewMember();
                            continue;
                        case "c":
                            this.DeleteMember();
                            continue;
                        case "d":
                            this.EditMember();
                            continue;
                        case "e":
                            this.FindOne(); 
                            continue;
                        case "f":
                            this.ShowRank();
                            continue;
                        case "g":
                            this.Exit();
                            continue;
                    }
                }
            }
        }
    }
}
