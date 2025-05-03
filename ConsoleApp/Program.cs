using ClassLibrary;

namespace Main
{
    class Sample
    {
        public static void Main(string[] args)
        {
            //ref returns-useful in directly manipulating the variable rather than working with a copy

            Student bob = new Student();
            System.Console.WriteLine("before modification:" + bob.GetGrade());//2
            ref int g=ref bob.GetGradeRef();
            g = 10;
            System.Console.WriteLine("after modification:" + bob.GetGrade());//10


            int[] arr = { 10, 65, 65, 26, 87 };
            System.Console.WriteLine("before modification:"+arr[2]);//65
            ref int value = ref bob.GetArrayIndexRef(arr, 2);
            value = 76;
            System.Console.WriteLine("after modification:" + arr[2]);//76
        }
    }
}