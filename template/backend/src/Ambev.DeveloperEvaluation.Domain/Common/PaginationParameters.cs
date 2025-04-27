namespace Ambev.DeveloperEvaluation.Domain.Common;

/// <summary>
/// Represents common pagination parameters for queries
/// </summary>
public class PaginationParameters
{
    private const int MaxPageSize = 50;
    private int _pageSize = 10;
    private int _pageNumber = 1;

    /// <summary>
    /// Gets or sets the page number (1-based)
    /// </summary>
    public int PageNumber
    {
        get => _pageNumber;
        set => _pageNumber = value < 1 ? 1 : value;
    }

    /// <summary>
    /// Gets or sets the page size (number of items per page)
    /// </summary>
    public int PageSize
    {
        get => _pageSize;
        set => _pageSize = value > MaxPageSize ? MaxPageSize : (value < 1 ? 1 : value);
    }

    /// <summary>
    /// Gets or sets the ordering expression (e.g., "username asc, email desc")
    /// </summary>
    public string OrderBy { get; set; } = string.Empty;
}
