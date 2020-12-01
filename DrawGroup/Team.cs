using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawGroup
{
    class Team
    {
        string name;
        string region;

        public Team()
        {

        }

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }

        public string Region
        {
            get
            {
                return region;
            }

            set
            {
                region = value;
            }
        }

        public Team(string name, string region)
        {

            this.Name = name;
            this.Region = region;
        }
    }
}
