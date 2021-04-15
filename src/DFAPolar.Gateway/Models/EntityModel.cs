using System;
using System.ComponentModel.DataAnnotations;

namespace DFAPolar.Gateway.Models
{
    public abstract class EntityModel
    {
        [Required]
        [Key]
        public int Id { get; protected set; }

        [Required]
        public DateTimeOffset CreatedDate { get; protected set; }

        public DateTimeOffset UpdatedDate { get; protected set; }

        protected EntityModel()
        {
            CreatedDate = DateTimeOffset.Now;
            UpdatedDate = DateTimeOffset.Now;
        }
    }
}
