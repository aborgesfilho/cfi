using CFI.Interfaces;

namespace CFI.Models
{
    public class Type : IType
    {
        public Type(string typeCode)
        {
            TypeCode = typeCode;
        }
        public int TypeId { get; set; }
        public string TypeCode { get; set; }
    }
}
