using AnimalterV3.Entity.Abstract.Entites;
using System.ComponentModel.DataAnnotations;

namespace AnimalterV3.Entity.Concrete
{
    public class UserOperationClaim : IEntity
    {
        // Kullanıcılar arası rolü tutacak sınıf
        [Key]
        public int Id { get; set; }

        [StringLength(50)]
        public int UserId { get; set; }

        [StringLength(50)]
        public string OperationClaimId { get; set; }
    }
}
