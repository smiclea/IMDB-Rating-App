using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Windows.Forms;

namespace IMDb_Rating_App.Model
{
    public class TitleGroup
    {
        public IMDbTitle Title { get; set; }
        public GroupBox Group { get; set; }
    }
}
