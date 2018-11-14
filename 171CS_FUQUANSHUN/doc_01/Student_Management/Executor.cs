﻿
// 命令解析器、执行器

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Management
{
    private DatabaseOperation dbhelper = new DatabaseOperation();
    // var 只能用在局部变量

    class Executor
    {
        public void ShowHelp()
        {
            Console.WriteLine("* * * * * * * * * * * * * * * * * * * * *");
            Console.WriteLine("请输入所要使用功能的选项后回车");
            Console.WriteLine("A 查看所有人员信息");
            Console.WriteLine("B 添加一位新成员");
            Console.WriteLine("C 修改一位成员信息");
            Console.WriteLine("D 删除一位成员");
            Console.WriteLine("E 查看积分排名");
            Console.WriteLine("F 查找一位成员");
            Console.WriteLine("G 退出程序");
            Console.WriteLine("* * * * * * * * * * * * * * * * * * * * *");
        }

        public void ShowAllMember()
        {
            Console.WriteLine("以下是全体成员信息：");           
            var allMember = this.dbhelper.GetAll();
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
            Console.WriteLine("开始添加新成员：");
            var somebody = new User();
            Console.WriteLine("请输入班级ID：");
            somebody.ClassId = Console.ReadLine();
            Console.WriteLine("请输入姓名：");
            somebody.Name = Console.ReadLine();
            Console.WriteLine("请输入当前积分：");
            somebody.Credit = int.Parse(Console.ReadLine());
            Console.WriteLine("请输入GitHub账号：");
            somebody.GitHub = Console.ReadLine();
            dbhelper.Add(somebody);
            Console.WriteLine("添加成功！！！");
        }

        public void EditMember()
        {
            Console.WriteLine("开始修改成员信息，请输入所要编辑成员姓名：");
            var name = Console.ReadLine();
            var result = this.dbhelper.Get(x => x.Name == name);
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
                Console.WriteLine("请输入班级ID：");
                result.ClassId = Console.ReadLine();
                Console.WriteLine("请输入姓名：");
                result.Name = Console.ReadLine();
                Console.WriteLine("请输入当前积分：");
                result.Credit = int.Parse(Console.ReadLine());
                Console.WriteLine("请输入GitHub账号：");
                result.GitHub = Console.ReadLine();
                this.dbhelper.UpdateMember(x => x.Name == name);
                // this.service.UpdateMember(result);
                Console.WriteLine("成员信息更新成功！！！");

            }

        }

        public void DeleteMember()
        {
            Console.WriteLine("请输入需要删除成员姓名：");
            var name = Console.ReadLine();
            this.dbhelper.DeleteMember(x => x.Name == name);
            // this.service.DeleteMember(name);
            Console.WriteLine("成员删除成功！！！");
        }

        public void ShowRank()
        {
            Console.WriteLine("以下是成员积分排行：");
            var allMember = this.dbhelper.GetAll().OrderBy(x => x.Credit);
            Console.WriteLine("班级ID\t\t姓名\t\t当前积分");
            foreach (var user in allMember)
            {
                Console.WriteLine($"{user.ClassId}\t\t{user.Name}\t\t{user.Credit}");
            }
        }

        public void FindOne()
        {

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
                            this.EditMember();
                            continue;
                        case "d":
                            this.ShowAllMember();
                            continue;
                        case "e":
                            this.ShowAllMember();
                            continue;
                        case "f":
                            this.ShowAllMember();
                            continue;
                    }
                }
            }
        }
    }
}
