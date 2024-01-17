using HandsOnEFCodeFirst_Demo2.Entities;

namespace HandsOnEFCodeFirst_Demo2.Repositories
{
    public class StudentRepository : IRepository<Student>
    {
        private readonly MyContext _context;
        public StudentRepository()
        {
            _context = new MyContext();
        }
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
    }
}
