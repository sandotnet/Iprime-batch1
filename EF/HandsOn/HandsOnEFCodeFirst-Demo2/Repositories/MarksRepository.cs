using HandsOnEFCodeFirst_Demo2.Entities;

namespace HandsOnEFCodeFirst_Demo2.Repositories
{
    public class MarksRepository : IRepository<Marks>

    {
        private readonly MyContext _context;

        public MarksRepository(MyContext context)
        {
            _context = context;
        }

        //public MarksRepository()
        //{
        //    _context = new MyContext();
        //}
        public void Add(Marks entity)
        {
            _context.Marks.Add(entity);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Marks Get(int id)
        {
            throw new NotImplementedException();
        }

        public List<Marks> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Update(Marks entity)
        {
            throw new NotImplementedException();
        }
    }
}
