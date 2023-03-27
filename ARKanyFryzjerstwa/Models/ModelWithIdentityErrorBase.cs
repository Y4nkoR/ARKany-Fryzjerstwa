using Microsoft.AspNetCore.Identity;

namespace ARKanyFryzjerstwa.Models
{
    public class ModelWithIdentityErrorBase
    {
        public List<IdentityError>? IdentityErrors { get; set; } = new List<IdentityError>();
        public bool HasErrors => IdentityErrors != null && IdentityErrors.Count > 0;
    }
}
