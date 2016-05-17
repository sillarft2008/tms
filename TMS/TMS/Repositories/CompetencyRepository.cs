using System;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using TMS.Models;

namespace TMS.Repositories
{
    public interface ICompetencyRepository
    {
        IQueryable<Competency> All { get; }

        IQueryable<Competency> AllIncluding(
            params Expression<Func<Competency, object>>[] includeProperties);

        Competency Find(int? id);
        void InsertOrUpdate(Competency dude);
        void Delete(int id);

    }
    public class CompetencyRepository : ICompetencyRepository
    {
        ApplicationDbContext context = new ApplicationDbContext();

        public IQueryable<Competency> All
        {
            get { return context.Competencies; }
        }

        public IQueryable<Competency> AllIncluding(params Expression<Func<Competency, object>>[] includeProperties)
        {
            IQueryable<Competency> query = context.Competencies;
            foreach (var includeProperty in includeProperties)
            {
                query = query.Include(includeProperty);
            }
            return query;
        }

        public Competency Find(int? id)
        {
            return context.Competencies.Find(id);
        }

        public void InsertOrUpdate(Competency dude)
        {
            if (dude.Id == default(int)) //if it is default int(0) than it is a new movie
            {
                context.Competencies.Add(dude);
            }
            else
            {
                context.Entry(dude).State = EntityState.Modified;
            }
            context.SaveChanges();
        }

        public void Delete(int id)
        {
            Competency dude = context.Competencies.Find(id);
            context.Competencies.Remove(dude);
            context.SaveChanges();
        }
    }
}