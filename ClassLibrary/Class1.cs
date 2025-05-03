namespace ClassLibrary
{
    public class Student
    {
        private int grade = 2;

        public int GetGrade()
        {
            return grade;
        }
        public ref int GetGradeRef()
        {
            return ref grade;
        }

        public ref int GetArrayIndexRef(int[] arr,int index)
        {
            return ref arr[index];
        }

    }
}
