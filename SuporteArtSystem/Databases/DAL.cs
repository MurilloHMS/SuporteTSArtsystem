namespace SuporteArtSystem.Databases
{
    internal class DAL<T> where T : class
    {
        protected readonly SuporteContext _context;

        public DAL(SuporteContext context)
        {
            this._context = context;
        }
        
        public IEnumerable<T> GetAll() 
        {
            return _context.Set<T>().ToList();
        }

        public void AddToDB(T objeto)
        {
            _context.Set<T>().Add(objeto);
            _context.SaveChanges();
        }

        public void UpdateDB(T objeto)
        {
            _context.Set<T>().Update(objeto);
            _context.SaveChanges();
        }
        public void DeleteDB(T objeto)
        {
            _context.Set<T>().Remove(objeto);
            _context.SaveChanges();
        }

        public T? GetFor(Func<T, bool> condicao)
        {
            return _context.Set<T>().FirstOrDefault(condicao);
        }

        public IEnumerable<T> listFor(Func<T, bool> condicao)
        {
            return _context.Set<T>().Where(condicao).ToList();
        }
    }
}
