namespace Ambev.DeveloperEvaluation.Domain.Common;

/// <summary>
/// Represents a paginated list of items
/// </summary>
/// <typeparam name="T">The type of items in the list</typeparam>
public class PagedList<T>
{
    /// <summary>
    /// Gets the items for the current page
    /// </summary>
    public IEnumerable<T> Items { get; }

    /// <summary>
    /// Gets the current page number
    /// </summary>
    public int CurrentPage { get; }

    /// <summary>
    /// Gets the total number of pages
    /// </summary>
    public int TotalPages { get; }

    /// <summary>
    /// Gets the page size (number of items per page)
    /// </summary>
    public int PageSize { get; }

    /// <summary>
    /// Gets the total number of items across all pages
    /// </summary>
    public int TotalCount { get; }

    /// <summary>
    /// Gets a value indicating whether there is a previous page
    /// </summary>
    public bool HasPrevious => CurrentPage > 1;

    /// <summary>
    /// Gets a value indicating whether there is a next page
    /// </summary>
    public bool HasNext => CurrentPage < TotalPages;

    /// <summary>
    /// Initializes a new instance of the PagedList class
    /// </summary>
    /// <param name="items">The items for the current page</param>
    /// <param name="count">The total number of items across all pages</param>
    /// <param name="pageNumber">The current page number</param>
    /// <param name="pageSize">The page size (number of items per page)</param>
    public PagedList(IEnumerable<T> items, int count, int pageNumber, int pageSize)
    {
        CurrentPage = pageNumber;
        TotalPages = (int)Math.Ceiling(count / (double)pageSize);
        PageSize = pageSize;
        TotalCount = count;
        Items = items;
    }

    /// <summary>
    /// Creates a new PagedList from a queryable source
    /// </summary>
    /// <param name="source">The queryable source</param>
    /// <param name="pageNumber">The page number</param>
    /// <param name="pageSize">The page size</param>
    /// <returns>A new PagedList instance</returns>
    public static PagedList<T> Create(IQueryable<T> source, int pageNumber, int pageSize)
    {
        var count = source.Count();
        var items = source.Skip((pageNumber - 1) * pageSize).Take(pageSize).ToList();
        return new PagedList<T>(items, count, pageNumber, pageSize);
    }
}
