﻿namespace NameApp.Domain.Common
{
    public class BaseAuditableEntity
    {
        public Guid CreatedBy { get; set; }
        public DateTime? Created { get; set; }
        public Guid LastModifiedBy { get; set; }
        public DateTime? LastModified { get; set;}
    }
}
