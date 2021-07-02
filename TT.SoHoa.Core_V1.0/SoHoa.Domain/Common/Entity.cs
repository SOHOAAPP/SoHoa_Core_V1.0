using System;
using System.Collections.Generic;
using System.Text;

namespace SoHoa.Domain.Common
{
    public class Entity
    {
        public Entity()
        {

        }
        int? _requestedHashCode;
        Guid _id;
        public virtual Guid Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public string ClassName => this.GetType().Name;
        public virtual string DeletedBy { get; set; }
        public virtual DateTime? DeletedDate { get; set; }
        public virtual Boolean? IsDeleted { get; set; }
        public virtual string CreatedBy { get; set; }
        public virtual DateTime? CreatedDate { get; set; }
        public virtual string ModifiedBy { get; set; }
        public virtual DateTime? ModifiedDate { get; set; }


        /// <summary>
        ///   Determine if this is transient. <br />
        /// </summary>
        /// <returns>
        ///  - true: recently created without id, not existed yet. <br />
        ///  - false: maybe already existed.
        /// </returns>
        public bool IsTransient() => this.Id == default(Guid);

        public override bool Equals(object obj)
        {
            if (obj == null || !(obj is Entity))
                return false;

            if (Object.ReferenceEquals(this, obj))
                return true;

            if (this.GetType() != obj.GetType())
                return false;

            Entity item = (Entity)obj;

            if (item.IsTransient() || this.IsTransient())
                return false;
            else
                return item.Id.ToString() == this.Id.ToString();
        }

        public static bool operator ==(Entity left, Entity right)
        {
            if (Object.Equals(left, null))
                return (Object.Equals(right, null)) ? true : false;
            else
                return left.Equals(right);
        }

        public static bool operator !=(Entity left, Entity right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            if (!IsTransient())
            {
                if (!_requestedHashCode.HasValue)
                    _requestedHashCode = this.Id.GetHashCode() ^ 31;

                return _requestedHashCode.Value;
            }
            else
                return base.GetHashCode();
        }
    }
}
