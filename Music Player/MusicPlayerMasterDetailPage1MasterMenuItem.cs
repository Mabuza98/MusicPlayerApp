using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Music_Player
{
    public class MusicPlayerMasterDetailPage1MasterMenuItem
    {
        public MusicPlayerMasterDetailPage1MasterMenuItem()
        {
            TargetType = typeof(MusicPlayerMasterDetailPage1MasterMenuItem);
        }
        public int Id { get; set; }
        public string Title { get; set; }

        public Type TargetType { get; set; }

        public string ImageName { get; set; }
    }
}