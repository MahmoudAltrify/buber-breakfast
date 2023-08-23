namespace DefaultNamespace;

public record BreakfastResponse(
    Guid Id,
    string Name,
    string Description,
    DateTime StartDateTime,
    DateTime EndDateTime,
    DateTime UpdatedAt,
    List<string> savory,
    List<string> sweet,

    );