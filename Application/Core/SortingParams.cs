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

        public IQueryable<T> GetData<T>(IQueryable<T> query, string defaultField = null,
            SortDirection defaultDir = SortDirection.Desc)
        {
            if (SortField == null)
                return defaultField != null
                    ? query.OrderBy(defaultField + (defaultDir == SortDirection.Asc ? " ascending" : " descending"))
                    : query;

            //check if SortField is real field
            var propertyInfos = typeof(T).GetProperties(BindingFlags.Public | BindingFlags.Instance);
            var propertyFromQueryName = SortField.Split(" ")[0];
            var objectProperty = propertyInfos.FirstOrDefault(pi =>
                pi.Name.Equals(propertyFromQueryName, StringComparison.InvariantCultureIgnoreCase));

            //handle fake SortField
            if (objectProperty == null)
                return defaultField != null
                    ? query.OrderBy(defaultField + (defaultDir == SortDirection.Asc ? " ascending" : " descending"))
                    : query;
            var ord = objectProperty.Name + (SortDir == SortDirection.Asc ? " ascending" : " descending");

            //handle correct SortField
            return query.OrderBy(defaultField != null
                ? $"{ord}, {defaultField + (defaultDir == SortDirection.Asc ? " ascending" : " descending")}"
                : ord);
        }
    }

    public enum SortDirection
    {
        Asc = 0,
        Desc
    }
}