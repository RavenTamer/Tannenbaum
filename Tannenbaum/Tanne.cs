using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tannenbaum
{
    internal class Tanne
    {
        int width;
        int trunkheight;
        int crownheight;


        public Tanne(int constwidth, int consttrunkheight, int constcrownheight)
        {
            Width = constwidth;
            TrunkHeight = consttrunkheight;
            CrownHeight = constcrownheight;
        }
        public int Width { get { return width; } set { width = value; } }
        public int TrunkHeight { get { return trunkheight; } set { trunkheight = value; } }
        public int CrownHeight { get { return crownheight; } set { crownheight = value; } }
        public string DrawTree()
        {
            string drawing = DrawCrown(CrownHeight) + DrawTrunk(Width, TrunkHeight, CrownHeight);
            return drawing;
        }
        public string DrawCrown(int crownheight)
        {
            int l = crownheight;
            int m = 1;
            string crown = "";

            for (int k = crownheight; k > 0; k--)
            {


                for (int j = l; j > 1; j--)
                {
                    crown += (" ");
                }
                for (int i = m; i > 0; i--)
                {
                    crown += ("*");
                }

                crown += ("\r\n");

                l--;
                m += 2;
            }
            return crown;
        }
        public string DrawTrunk(int trunkwidth, int trunkheight, int crownheight)
        {
            string trunk = "";

            for (int i = trunkheight; i != 0; i--)
            {
                int j = 2 * crownheight - 1;
                for (int k = (j - trunkwidth) / 2; k != 0; k--)
                {
                    trunk += (" ");
                }
                for (int l = trunkwidth; l != 0; l--)
                {
                    trunk += ("*");
                }
                trunk += ("\r\n");
            }
            return trunk;
        }
    }
}
