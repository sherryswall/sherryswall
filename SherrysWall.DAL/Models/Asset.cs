using System;
using System.Collections.Generic;
using System.Text;

namespace SherrysWall.DAL.Models
{
    public class Asset
    {
        public string Name { get; set; }
        public int Experience { get; set; }
        
        public int Rating { get; set; }
        public AssetType Type { get; set; }

        public class AssetType {
            public int Id { get; set; }
            public string Name { get; set; }
        }
    }

   
}
