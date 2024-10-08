﻿using System.Collections.Generic;

namespace ST10043352_PROG7312_PART_1
{
    public class Issue
    {
        public string Location { get; set; }
        public string Category { get; set; }
        public string Description { get; set; }
        public List<string> MediaFilePaths { get; set; }

        public Issue(string location, string category, string description, List<string> mediaFilePaths)
        {
            Location = location;
            Category = category;
            Description = description;
            MediaFilePaths = mediaFilePaths;
        }

        public override string ToString()
        {
            return $"Location: {Location}, Category: {Category}, Description: {Description}, Media: {string.Join(", ", MediaFilePaths)}";
        }
    }
}
