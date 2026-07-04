namespace Assignment6_4;

class Program
{
    static void Main(string[] args)
    {
        //Integer
        MyData<int> data1 = new MyData<int>(101);
        data1.DisplayData();

        //Float
        MyData<float> data2 = new MyData<float>(125.34f);
        data2.DisplayData();

        //String
        MyData<string> data3 = new MyData<string>("Ghanshyam Singh");
        data3.DisplayData();

        //Boolean
        MyData<bool> data4 = new MyData<bool>(true);
        data4.DisplayData();

        //Employee Object
        Employee emp1 = new Employee(101, "Ghanshyam");

        MyData<Employee> empData = new MyData<Employee>(emp1);

        empData.DisplayData();

        //Student Object
        Student stu1 = new Student(1, "Amit");

        MyData<Student> stuData = new MyData<Student>(stu1);

        stuData.DisplayData();

    }
}

