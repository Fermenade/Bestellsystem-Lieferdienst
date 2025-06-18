namespace Client_Server_Code_Library;

[AttributeUsage(AttributeTargets.Field)]
public class IgnoreInsertAttribute : Attribute;

[AttributeUsage(AttributeTargets.Field)]
public class DatabaseIDAttribute : Attribute;