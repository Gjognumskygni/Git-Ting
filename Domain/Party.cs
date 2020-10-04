﻿using System;
using System.Collections.Generic;

namespace Domain
{
    public class Party
    {
        public int Id { get; set; }

        public string Letter { get; set; }

        public string Name { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public ICollection<MemberOfParliament> MemberOfParliaments { get; }
    }
}
