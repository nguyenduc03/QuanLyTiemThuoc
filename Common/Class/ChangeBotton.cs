using FontAwesome.Sharp;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLTT.Common.Class
{
    public class ChangeBotton
    {

        private IconButton CurrentBTN = new IconButton();
        public void ShowCurrentBTN(object senderBTN, Color colorInput)
        {
            if (senderBTN != null)
            {
                ResetBTN();
                CurrentBTN = (IconButton)senderBTN;
                CurrentBTN.TextAlign = ContentAlignment.MiddleLeft;
                CurrentBTN.TextImageRelation = TextImageRelation.TextBeforeImage;
                CurrentBTN.BackColor = Color.FromArgb(70, 252, 252, 252);
                CurrentBTN.IconColor = colorInput;


                ///// icon current 
                //IconCurrent.IconChar = CurrentBTN.IconChar;
                //IconCurrent.IconColor = CurrentBTN.IconColor;
               
            }
        }
        public void ResetBTN()
        {
            if (CurrentBTN != null)
            {
                CurrentBTN.TextAlign = ContentAlignment.MiddleLeft;
                CurrentBTN.TextImageRelation = TextImageRelation.ImageBeforeText;
                CurrentBTN.BackColor = Color.FromArgb(47, 49, 49);
                CurrentBTN.IconColor = Color.Gainsboro;
            }
        }
    }
}
