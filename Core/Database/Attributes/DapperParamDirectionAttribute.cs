using System.Data;

namespace SearchAndRescue.Core.Database.Attributes
{
    [AttributeUsage(AttributeTargets.Property)]
    public class DapperParamDirectionAttribute : Attribute
    {
        public ParameterDirection Value { get; }

        public DapperParamDirectionAttribute(ParameterDirection value)
        {
            Value = value;
        }
    }
}
