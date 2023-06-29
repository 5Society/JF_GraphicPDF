
namespace JF.GraphicPDF.Definitions
{
    public class Margin : IMargin
    {
        public float TopMargin { get; set; }
        public float BottomMargin { get; set; }
        public float LeftMargin { get; set; }
        public float RightMargin { get; set; }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="topMargin">Margen superior</param>
        /// <param name="rightMargin">Margen derecha</param>
        /// <param name="bottomMargin">Margen inferior</param>
        /// <param name="leftMargin">Margen izquierda</param>
        public Margin(float topMargin, float rightMargin, float bottomMargin, float leftMargin ) 
        { 
            TopMargin = topMargin;
            RightMargin = rightMargin;
            BottomMargin = bottomMargin;
            LeftMargin = leftMargin;
        }
    }
}