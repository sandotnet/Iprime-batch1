using SMSAPI.Entities;

namespace SMSAPI.Repositories
{
    public class StudentRepository : IRepository<Student>
    {
        private readonly MyContext _context;

        public StudentRepository(MyContext context)
        {
            _context = context;
        }
        public void Add(Student entity)
        {
            _context.Students.Add(entity);
            _context.SaveChanges();
        }

        public void Delete(string id)
        {
            Student student= _context.Students.Find(id);
            _context.Students.Remove(student);
            _context.SaveChanges();
        }

        public Student Get(string id)
        {
            return _context.Students.Find(id);
        }

        public List<Student> GetAll()
        {
            return _context.Students.ToList();
        }

        public void Update(Student entity)
        {
            _context.Students.Update(entity);
            _context.SaveChanges();
        }
    }
}
