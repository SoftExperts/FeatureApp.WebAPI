
namespace DTOs
{
    /// <summary>
    /// BaseDto contains common properties for each entity
    /// </summary>
    public abstract class BaseDto
    {
        /// <summary>
        /// Key for each entity's each record.
        /// </summary>
        public Guid Id { get; set; } = Guid.Empty;
        /// <summary>
        /// Date of the record created for each entity
        /// </summary>
        public DateTime CreatedDate { get; set; }

        /// <summary>
        /// Date of the record modified for each entity.
        /// </summary>
        public DateTime? ModifiedDate { get; set; }

        /// <summary>
        /// Id of the user that creates new records for each entity.
        /// </summary>
        public Guid CreatedBy { get; set; }

        /// <summary>
        /// Id of the user that modifies existing records for each entity.
        /// </summary>
        public Guid? ModifiedBy { get; set; }

        /// <summary>
        /// Determines that record is active or not.
        /// </summary>
        public bool IsActive { get; set; }
    }
}