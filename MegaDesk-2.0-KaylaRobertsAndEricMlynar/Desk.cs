using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk_3_KaylaRoberts
{
    public class Desk
    {
        public enum SurfaceMaterial
        {
            Oak,
            Rosewood,
            Veneer,
            Pine,
            Laminate
        }

        public int DeskId { get; set; }
        public int Width { get; set; }
        public int Depth { get; set; }
        public int NumOfDrawers { get; set; }
        public SurfaceMaterial DeskMaterial { get; set; }
    }
}
