using System;
using System.Collections.Generic;
using System.Text;
using System.Collections.ObjectModel;
using System.Drawing;

namespace UI.CustomControl
{
    /// <summary>
    /// Circle data structure
    /// </summary>
    public sealed class CircleEntity
    {
        private int _x;
        private int _y;
        private string _text;
        private List<CircleLinkEntity> _links;

        public int PosX
        {
            get { return _x; }
        }

        public int PosY
        {
            get { return _y; }
        }

        public string Text
        {
            get { return _text; }
            set { _text = value; }
        }

        public List<CircleLinkEntity> Links
        {
            get { return _links; }
        }

        /// <summary>
        /// Constructor Circle data
        /// </summary>
        /// <param name="posX">X coordinate</param>
        /// <param name="posY">Y coordinate</param>
        /// <param name="text">Text inside circle</param>
        public CircleEntity(int posX, int posY, string text)
        {
            _x = posX;
            _y = posY;
            _text = text;

            _links = new List<CircleLinkEntity>();
        }
    }

    /// <summary>
    /// CIrcle link structure
    /// </summary>
    public sealed class CircleLinkEntity
    {
        private string _text;
		private Color mColor;

        private CircleEntity _link;

        public CircleEntity Link
        {
            get { return _link; }
        }
        
        public string Text
        {
            get { return _text; }
            set { _text = value; }
        }

		public Color LinkColor
		{
			get { return mColor; }
			set { mColor = value; }
		}

        public CircleLinkEntity(CircleEntity linkCircle, string text)
        {
            _link = linkCircle;
            _text = text;
			mColor = Color.Black;
        }
    }
}
