namespace Client_Server_Code_Library;

[AttributeUsage(AttributeTargets.Field | AttributeTargets.Property)]
public class IgnoreInsertAttribute : Attribute;

[AttributeUsage(AttributeTargets.Field)]
public class DatabaseAutoIncrementIDAttribute : Attribute;