namespace DefaultNamespace;

public record UpsertBreakfastRequest(
    string Name,
    string Description,
    DateTime StartDateTime,
    DateTime EndDateTime,
    List<string> savory,
    List<string> sweet,
    );