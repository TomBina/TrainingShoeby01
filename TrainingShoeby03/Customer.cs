﻿namespace TrainingShoeby03
{
    internal class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        
        protected bool Equals(Customer other)
        {
            return Id == other.Id;
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return Equals((Customer) obj);
        }

        public override int GetHashCode()
        {
            return Id;
        }
    }
}