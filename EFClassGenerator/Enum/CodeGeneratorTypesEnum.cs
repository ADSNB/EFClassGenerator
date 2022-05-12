using System.ComponentModel;

namespace EFClassGenerator.Enum
{
    public enum CodeGeneratorTypesEnum
    {
        [Description("JSON => HubSpotCRM")]
        JsonToHubSpotCRM = 1,

        [Description("Lines to Entity")]
        ColumnNameToEntity = 2
    }
}