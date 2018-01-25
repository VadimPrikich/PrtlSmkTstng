using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mPortal

{
    //payments data
    public class GroupData : IEquatable<GroupData>, IComparable<GroupData>
    {
        private string groupName;
        private string groupHeader = "";
        private string groupFooter = "";

        //costructor на один параметр groupName
        public GroupData(string groupName)
        {
            this.groupName = groupName;
        }

        public bool Equals(GroupData other)
        {
            if (Object.ReferenceEquals(other, null))
            {
                return false;
            }
            if (Object.ReferenceEquals(this, other))
            {
                return true;
            }
            return GroupName == other.GroupName;
        }

        public override int GetHashCode()
        {
            //return 0;
            return GroupName.GetHashCode();
        }

        public override string ToString()
        {
            return "name" + GroupName;
        }

        public int CompareTo(GroupData other)
        {
            if (Object.ReferenceEquals(other, null))
            {
                return 1;
            }
            return GroupName.CompareTo(other.GroupName);
        }

        //constructor на 3 параметра если надо
        //public GroupData(string groupName, string groupHeader, string groupFooter)
        //{
        //    this.groupName = groupName;
        //    this.groupHeader = groupHeader;
        //    this.groupFooter = groupFooter;
        //}

        //свойства groupName как GroupName
        public string GroupName
        {
            get
            {
                return groupName;
            }
            set
            {
                groupName = value;
            }

        }

        //поменять необязательное значение "" header на другое можно с помощью свойства GroupHeader.
        public string GroupHeader
        {
            get
            {
                return groupHeader;
            }
            set
            {
                groupHeader = value;
            }
        }

        public string GroupFooter
        {
            get
            {
                return groupFooter;
            }
            set
            {
                groupFooter = value;
            }
        }
    }
}
