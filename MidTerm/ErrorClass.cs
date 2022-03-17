namespace MidTerm
{
    public class ErrorClass
    {
        public string? Details { get; set; }
        public string? Message { get; set; }
        public List<ValidationErrors>? ValidationErrors { get; set; }
    }
    public class ValidationErrors
    {
        public bool IsValid { get; set; }
        public string? RestrictionType { get; set; }
        public string? RuleName { get; set; }
    }
}
