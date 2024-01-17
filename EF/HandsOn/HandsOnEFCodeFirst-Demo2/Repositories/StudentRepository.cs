using HandsOnEFCodeFirst_Demo2.Entities;

namespace HandsOnEFCodeFirst_Demo2.Repositories
{
    public class StudentRepository : IRepository<Student>
    {
        private readonly MyContext _context;

        public StudentRepository(MyContext context)
        {
            _context = context;
        }

        //public StudentRepository()
        //{
        //    _context = new MyContext();
        //}

        public void Add(Student entity)
        {
            _context.Students.Add(entity);
            _context.SaveChanges();
        }
        public void Delete(int id)
        {
            Student student = _context.Students.Find(id);
            _context.Students.Remove(student);
            _context.SaveChanges();
        }
        public Student Get(int id)
        {
            return _context.Students.Find(id);
        }

        public List<Student> GetAll()
        {
            return _context.Students.ToList();
        }

        public void Update(Student entity)
        {
           _context.Update(entity);
            _context.SaveChanges();
        }
        public List<StudentMarks> GetMarks(int id)
        {
            List<StudentMarks> studentMarks = (from s in _context.Students
                                              join m in _context.Marks
                                              on s.Id equals m.StudentId
                                              where s.Id==id
                                              select new StudentMarks()
                                              {
                                                  Id = s.Id,
                                                  Name = s.Name,
                                                  Std=s.Std,
                                                  Section=s.Section,
                                                  TotalMarks=m.TotalMarks,
                                                  Exam=m.Exam
                                              }).ToList();
            return studentMarks;
        }
    }
}
