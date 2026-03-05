namespace xAcademics
{
    public class Course
    {
       

        public string Code { get; }
        public string Title { get; }
        public string Dept { get; }

        public Course(string code, string title, string dept)
        {
            Code = code ?? "";
            Title = title ?? "";
            Dept = dept ?? "";
        }

        public override string ToString() => Code;
    }
}
