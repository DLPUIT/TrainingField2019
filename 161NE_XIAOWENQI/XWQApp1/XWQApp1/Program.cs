namespace XWQApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var somebody = new User();
            Console.WriteLine("请输入班级ID");
            somebody.ClassId = Console.ReadLine();
            Console.WriteLine("请输入班级名称");
            somebody.ClassName = Console.ReadLine();
            Console.WriteLine("请输入姓名");

            somebody.name = Console.ReadLine();

            Console.WriteLine("请输入当前积分");
            somebody.Credits = int.Parse(Console.ReadLine());
            Console.WriteLine("请输入性别");
            somebody.Gender = bool.Parse(Console.ReadLine());
            Console.WriteLine("请输入领导");
            somebody.ReportTo = Console.ReadLine();
            Console.WriteLine("请输入GitHub账户");
            somebody.GitHub = Console.ReadLine();

            var dbService = new DatabaseOperation();
            dbService.Add(somebody);

            Console.ReadKey();
        }
    }

    public class DatabaseOperation : RepositoryBase<User>
    {
        internal new void Add(User somebody)
        {
            throw new NotImplementedException();
        }
    }

    
    
}
