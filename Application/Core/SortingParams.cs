using System;
using System.Linq;
using System.Linq.Dynamic.Core;
using System.Reflection;

namespace Application.Core
{
    public class SortingParams
    {
        public string SortField { get; set; } = null;
        public SortDirection SortDir { get; set; }

        public IQueryable<T> GetData<T>(IQueryable<T> query)
        {
            if (SortField == null) return query;
            
            //check if SortField is real field
            var propertyInfos = typeof(T).GetProperties(BindingFlags.Public | BindingFlags.Instance);
            var propertyFromQueryName = SortField.Split(" ")[0];
            var objectProperty = propertyInfos.FirstOrDefault(pi =>
                pi.Name.Equals(propertyFromQueryName, StringComparison.InvariantCultureIgnoreCase));

            if (objectProperty == null) return query;

            return query.OrderBy(objectProperty.Name + (SortDir == SortDirection.Asc ? " ascending" : " descending"));
        }
    }

    public enum SortDirection
    {
        Asc = 0,
        Desc
    }
}