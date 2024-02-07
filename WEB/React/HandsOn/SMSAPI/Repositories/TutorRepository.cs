using SMSAPI.Entities;

namespace SMSAPI.Repositories
{
    public class TutorRepository : IRepository<Tutor>
    {
        private readonly MyContext myContext;

        public TutorRepository(MyContext myContext)
        {
            this.myContext = myContext;
        }

        public void Add(Tutor item)
        {
            myContext.Tutors.Add(item);
            myContext.SaveChanges();
        }
        public void Delete(string id)
        {
            myContext.Tutors.Remove(myContext.Tutors.Find(id));
            myContext.SaveChanges();
        }
        public Tutor Get(string id)
        {
            return myContext.Tutors.Find(id);
        }

        public List<Tutor> GetAll()
        {
            return myContext.Tutors.ToList();
        }

        public void Update(Tutor item)
        {
            myContext.Tutors.Update(item);
            myContext.SaveChanges();
        }
    }
}
