using Guide.BL.Base;

namespace Guide.BL
{
    public class Contact : BaseBLModel
    {
        public int ContactType { get; set; }
        public string ContactContent { get; set; }
        public int PersonId { get; set; }
    }
}
