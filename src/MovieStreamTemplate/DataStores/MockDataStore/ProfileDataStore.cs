using System;
using System.Collections.Generic;
using MovieStreamTemplate.Models;

namespace MovieStreamTemplate.DataStores.MockDataStore
{
    public class ProfileDataStore: BaseDataStore<Profile>, IProfileDataStore
    {
        protected override IList<Profile> items { get; }

        public ProfileDataStore()
        {
            items = new List<Profile>
            {
                new Profile
                {
                    Id = "001",
                    PersonId = "032",
                    Image = "profile4",
                    Name = "Litora"
                },

                new Profile
                {
                    Id = "002",
                    PersonId = "032",
                    Image = "profile7",
                    Name = "Nisi"
                },

                new Profile
                {
                    Id = "003",
                    PersonId = "032",
                    Image = "profile6",
                    Name = "Kids"
                },

            };
        }

        
    }
}

