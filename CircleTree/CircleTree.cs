using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.Windows.Forms;
using System.ComponentModel;
using System.Drawing.Drawing2D;

[assembly: CLSCompliant(true)]
namespace UI.CustomControl
{
    /// <summary>
    /// This custum control implement functionality 
    /// draw circles and draw lines between them
    /// </summary>
    [Serializable]
    public class CircleTree : Panel
    {
        #region Private fields
        private List<CircleEntity> _circles;
        private bool _update;
        // Cells
        private int _cellSize;
        private int _cellHalfSize;
        // Grid
        private int _gridWidth;
        private int _gridHeight;
        private int _gridCoordinateCorrection;
        private int _defaultGridSize;
        // Circle
        private int _circleSize;
        private Color _circleOutlineColor;
        private Color _circleFillColor;
        [NonSerializedAttribute]
        private SolidBrush _circleFillSolidBrush;
        [NonSerializedAttribute]
        private Pen _circlePen;
        private Font _circleFont;
        private Color _circleFontColor;
        [NonSerializedAttribute]
        private SolidBrush _circleFontColorSolidBrush;
        // Linked line
        [NonSerializedAttribute]
        private Pen _linkedLinePen;
        private Color _linkedLineColor;
        private int _linkedLineWidth;

        private bool _invertGridYPosition;

        // Support fields
        private Point _point;
        private Point _pointToFind;
        private Size _size;
        [NonSerializedAttribute]
        private CircleEntity _circleEntity;
        #endregion

        #region Protected fields
        protected CircleEntity this[int index]
        {
            get { return _circles[index]; }
        }
        #endregion

        #region Public Properties
        [Browsable(true)]
        [Category("Linked Line")]
        [Description("Circle linked line width")]
        [DefaultValue(3)]
        public int LinkedLineWidth
        {
            get { return _linkedLineWidth; }
            set
            {
                _linkedLineWidth = value;
                _linkedLinePen.Width = _linkedLineWidth;
            }
        }

        [Browsable(true)]
        [Category("Linked Line")]
        [Description("Circle linked line color")]
        [DefaultValue(typeof(Color), "Black")]
        public Color LinkedLineColor
        {
            get { return _linkedLineColor; }
            set
            {
                _linkedLineColor = value;
                _linkedLinePen.Color = _linkedLineColor;
            }
        }

        [Browsable(true)]
        [Category("Grid")]
        [Description("Invert grid Y position. Direction up or down")]
        [DefaultValue(false)]
        public bool InvertGridYPosition
        {
            get { return _invertGridYPosition; }
            set
            {
                if (_invertGridYPosition != value)
                {
                    _invertGridYPosition = value;
                    this.Refresh();
                }
            }
        }

        [Browsable(true)]
        [Category("Grid")]
        [Description("Set size max Width levels. Automaticaly grow with add circle.")]
        [DefaultValue(5)]
        public int GridWidth
        {
            get { return _gridWidth; }
            set { _gridWidth = value; }
        }

        [Browsable(true)]
        [Category("Grid")]
        [Description("Set size max Height levels. Automaticaly grow with add circle.")]
        [DefaultValue(5)]
        public int GridHeight
        {
            get { return _gridHeight; }
            set { _gridHeight = value; }
        }

        [Browsable(true)]
        [Category("Grid")]
        [Description("One Level size in pixels.")]
        [DefaultValue(50)]
        public int GridSize
        {
            get { return _cellSize; }
            set 
            { 
                _cellSize = value;
                _cellHalfSize = _cellSize / 2;
                _gridCoordinateCorrection = (_cellSize - _circleSize) / 2;
            }
        }

        [Browsable(true)]
        [Category("Circles")]
        [Description("Circle size in pixels.")]
        [DefaultValue(30)]
        public int CircleSize
        {
            get { return _circleSize; }
            set 
            {
                _circleSize = value;
                _gridCoordinateCorrection = (_cellSize - _circleSize) / 2;
            }
        }

        [Browsable(true)]
        [Category("Circles")]
        [Description("Circle outline color.")]
        [DefaultValue(typeof(Color), "Navy")]
        public Color CircleOutlineColor
        {
            get { return _circleOutlineColor; }
            set
            {
                _circleOutlineColor = value;
                _circlePen.Color = _circleOutlineColor;
            }
        }

        [Browsable(true)]
        [Category("Circles")]
        [Description("Circle fill color.")]
        [DefaultValue(typeof(Color), "White")]
        public Color CircleFillColor
        {
            get { return _circleFillColor; }
            set 
            { 
                _circleFillColor = value;
                _circleFillSolidBrush.Color = _circleFillColor;
            }
        }

        [Browsable(true)]
        [Category("Circles")]
        [Description("Circle outline width.")]
        [DefaultValue(3)]
        public int CircleOutlineWidth
        {
            get { return (int)_circlePen.Width; }
            set { _circlePen.Width = value; }
        }

        [Browsable(true)]
        [Category("Circles")]
        [Description("Circle Text font.")]
        [DefaultValue(typeof(Font), "Times New Roman, 10pt, style=Bold")]
        public Font CircleFont
        {
            get { return _circleFont; }
            set { _circleFont = value; }
        }

        [Browsable(true)]
        [Category("Circles")]
        [Description("Circle Font color.")]
        [DefaultValue(typeof(Color), "Black")]
        public Color CircleFontColor
        {
            get { return _circleFontColor; }
            set 
            { 
                _circleFontColor = value;
                _circleFontColorSolidBrush.Color = _circleFontColor;
            }
        }
        #endregion

        #region constructor & Dispose
        /// <summary>
        /// Initalize control fields.
        /// </summary>
        public CircleTree()
            : base()
        {
            this.BackColor = SystemColors.Window;
            this.BorderStyle = BorderStyle.Fixed3D;

            _circles = new List<CircleEntity>();
            _update = true;

            GridSize = 50;

            CircleSize = 30;

            _circleOutlineColor = Color.Navy;
            _circleFillColor = Color.White;
            _circleFillSolidBrush = new SolidBrush(_circleFillColor);

            _circlePen = new Pen(_circleOutlineColor, 3);
            _circleFont = new Font("Times New Roman", 10, FontStyle.Bold);
            _circleFontColor = Color.Black;
            _circleFontColorSolidBrush = new SolidBrush(_circleFontColor);

            _linkedLineColor = Color.Black;
            _linkedLineWidth = 3;
            _linkedLinePen = new Pen(_linkedLineColor, _linkedLineWidth);

            _point = new Point();
            _pointToFind = new Point();
            _size = new Size();

            _defaultGridSize = 5;

            ResetMaxLevel(_defaultGridSize);
        }

        /// <summary>
        /// Clear list of circles
        /// </summary>
        /// <param name="disposing">is disposing</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (_circles != null)
                {
                    _circleFillSolidBrush.Dispose();
                    _circleFont.Dispose();
                    _circleFontColorSolidBrush.Dispose();
                    _circlePen.Dispose();
                    _linkedLinePen.Dispose();

                    _circles.Clear();
                    _circles = null;
                }
            }

            base.Dispose(disposing);
        }
        #endregion

        #region Public voids
        #region Circles manipulate
        /// <summary>
        /// Add circle this coordinate
        /// </summary>
        /// <param name="posX">X coordinate</param>
        /// <param name="posY">Y coordinate</param>
        /// <param name="text">Internal text</param>
        /// <returns>Secussed - add if circle not exists</returns>
        public bool Add(int posX, int posY, string text)
        {
            return Add(new Point(posX, posY), text);
        }
        
        /// <summary>
        /// Add circle this point
        /// </summary>
        /// <param name="point">Circle coordinate</param>
        /// <param name="text">Text inside</param>
        /// <returns>true - success</returns>
        public bool Add(Point point, string text)
        {
            // if not exist Add circle;
            if (Exist(point))
                return false;

            CircleEntity circle = new CircleEntity(point.X, point.Y, text);
            _circles.Add(circle);

            // if must grow levels
            CheckMaxLevel(point.X, point.Y);

            this.Refresh();
            return true;
        }
        
        /// <summary>
        /// Change text circle
        /// </summary>
        /// <param name="posX">X coordinate</param>
        /// <param name="posY">Y coordinate</param>
        /// <param name="text">Text inside</param>
        public void ChangeText(int posX, int posY, string text)
        {
            ChangeText(new Point(posX, posY), text);
        }

        /// <summary>
        /// Change text circle
        /// </summary>
        /// <param name="point">Circle coordinate</param>
        /// <param name="text">Text inside</param>
        public void ChangeText(Point point, string text)
        {
            int i = FindIndex(point);

            if (i > -1)
            {
                _circles[i].Text = text;
                this.Refresh();
            }
        }

        /// <summary>
        /// Remove Circle this coordinates
        /// </summary>
        /// <param name="posX">X coordinate</param>
        /// <param name="posY">Y coordinate</param>
        /// <returns>true - success</returns>
        public bool RemovePos(int posX, int posY)
        {
            return Remove(Find(new Point(posX, posY)));
        }

        /// <summary>
        /// Remove Circle this point
        /// </summary>
        /// <param name="point">Circle coordinate</param>
        /// <returns>true - success</returns>
        public bool RemovePos(Point point)
        {
            return Remove(Find(point));
        }
        
        /// <summary>
        /// Remove Circle
        /// </summary>
        /// <param name="ce">Circle data</param>
        /// <returns>true - success</returns>
        public bool Remove(CircleEntity ce)
        {
            RemoveAllLink(ce);
            bool b = _circles.Remove(ce);
            if (b)
                this.Refresh();

            return b;
        }

        /// <summary>
        /// Clear all circles.
        /// </summary>
        public void Clear()
        {
            _circles.Clear();
            ResetMaxLevel(_defaultGridSize);
            this.Refresh();
        }
        
        /// <summary>
        /// Check exist circle this coordinates
        /// </summary>
        /// <param name="posX">X coordinate</param>
        /// <param name="posY">Y coordinate</param>
        /// <returns>true - exist</returns>
        public bool Exist(int posX, int posY)
        {
            return Exist(new Point(posX, posY));
        }

        /// <summary>
        /// Check exist circle this point
        /// </summary>
        /// <param name="point">Exist point</param>
        /// <returns>true - exist</returns>
        public bool Exist(Point point)
        {
            _pointToFind.X = point.X;
            _pointToFind.Y = point.Y;

            return _circles.Exists(FindCircle);
        }

        /// <summary>
        /// Find Circle data, this coordinates
        /// </summary>
        /// <param name="posX">X coordinate</param>
        /// <param name="posY">Y coordinate</param>
        /// <returns>Circle data</returns>
        public CircleEntity Find(int posX, int posY)
        {
            return Find(new Point(posX, posY));
        }

        /// <summary>
        /// Find Circle data, this point
        /// </summary>
        /// <param name="point">Point to find</param>
        /// <returns>Circle data</returns>
        public CircleEntity Find(Point point)
        {
            _pointToFind.X = point.X;
            _pointToFind.Y = point.Y;
            return _circles.Find(FindCircle);
        }

        /// <summary>
        /// Find in list circles, this coordinates
        /// </summary>
        /// <param name="posX">X coordinate</param>
        /// <param name="posY">Y coordinate</param>
        /// <returns>Index circle</returns>
        public int FindIndex(int posX, int posY)
        {
            return FindIndex(new Point(posX, posY));
        }

        /// <summary>
        /// Find in list circles, this point
        /// </summary>
        /// <param name="point">Point to find</param>
        /// <returns>Index circle</returns>
        public int FindIndex(Point point)
        {
            _pointToFind.X = point.X;
            _pointToFind.Y = point.Y;
            return _circles.FindIndex(FindCircle);
        }
        
        /// <summary>
        /// Override base void.
        /// Stop or start Refresh()
        /// </summary>
        public override void Refresh()
        {
            if (_update)
                base.Refresh();
        }

        /// <summary>
        /// Begin update and stop Refresh()
        /// This raise performace
        /// </summary>
        public void BeginUpdate()
        {
            _update = false;
        }

        /// <summary>
        /// End update and start Refresh()
        /// </summary>
        public void EndUpdate()
        {
            _update = true;
            Refresh();
        }
        #endregion

        #region Link manipulate
        /// <summary>
        /// Add link line between two circles
        /// </summary>
        /// <param name="from">First circle coordinate</param>
        /// <param name="to">Second circle coordinate</param>
        /// <param name="text">Text between two circles</param>
        /// <returns>true - success</returns>
        public bool AddLink(Point from, Point to, string text)
        {
            return AddLink(from.X, from.Y, to.X, to.Y, text);
        }

        /// <summary>
        /// Add link line between two circles
        /// </summary>
        /// <param name="fromX">First circle X coordinate</param>
        /// <param name="fromY">First circle Y coordinate</param>
        /// <param name="toX">Second circle X coordinate</param>
        /// <param name="toY">Second circle Y coordinate</param>
        /// <param name="text">Text between two circles</param>
        /// <returns>true - success</returns>
        public bool AddLink(int fromX, int fromY, int toX, int toY, string text)
        {
            CircleEntity fromCircle = Find(fromX, fromY);
            CircleEntity toCircle = Find(toX, toY);

            return AddLink(fromCircle, toCircle, text);
        }

        /// <summary>
        /// Add link line between two circles
        /// </summary>
        /// <param name="from">First circle</param>
        /// <param name="to">First circle</param>
        /// <param name="text">Text between two circles</param>
        /// <returns>true - success</returns>
        public bool AddLink(CircleEntity from, CircleEntity to, string text)
        {
            // Circle exists and source and destination not equal
            if (from != null && to != null && from != to)
            {
                // Check link exist
                if (!ExistLink(from, to))
                {
                    from.Links.Add(new CircleLinkEntity(to, text));
                    
                    this.Refresh();
                    return true;
                }
            }

            return false;
        }

        /// <summary>
        /// Check if link exist between two circles
        /// </summary>
        /// <param name="fromX">First circle X coordinate</param>
        /// <param name="fromY">First circle Y coordinate</param>
        /// <param name="toX">Second circle X coordinate</param>
        /// <param name="toY">Second circle Y coordinate</param>
        /// <returns>true - Exist</returns>
        public bool ExistLink(int fromX, int fromY, int toX, int toY)
        {
            CircleEntity fromCircle = Find(fromX, fromY);
            CircleEntity toCircle = Find(toX, toY);
            
            return ExistLink(fromCircle, toCircle);
        }

        /// <summary>
        /// Check if link exist between two circles
        /// </summary>
        /// <param name="from">First circle data</param>
        /// <param name="to">Second circle data</param>
        /// <returns>true - Exist</returns>
        public bool ExistLink(CircleEntity from, CircleEntity to)
        {
            // Circle exists and source and destination not equal
            if (from != null && to != null && from != to)
            {
                _circleEntity = from;

                if (to.Links.Exists(FindCircleLink))
                    return true;

                _circleEntity = to;

                if (from.Links.Exists(FindCircleLink))
                    return true;
            }
            return false;
        }

        /// <summary>
        /// Find link
        /// </summary>
        /// <param name="from">First circle data</param>
        /// <param name="to">Second circle data</param>
        /// <returns>Success return Circle data</returns>
        public CircleLinkEntity FindLink(CircleEntity from, CircleEntity to)
        {
            CircleLinkEntity result = null;
            
            _circleEntity = to;
            result = from.Links.Find(FindCircleLink);

            //if (result == null)
            //{
            //    _circleEntity = from;
            //    result = to.Links.Find(FindCircleLink);
            //}

            return result;
        }

        /// <summary>
        /// Find link and change text
        /// </summary>
        /// <param name="fromX">First circle X coordinate</param>
        /// <param name="fromY">First circle Y coordinate</param>
        /// <param name="toX">Second circle X coordinate</param>
        /// <param name="toY">Second circle Y coordinate</param>
        /// <param name="text">Text to change</param>
        public void ChangeTextLink(int fromX, int fromY, int toX, int toY, string text)
        {
            CircleEntity from = Find(fromX, fromY);
            CircleEntity to = Find(toX, toY);

            CircleLinkEntity cl = FindLink(from, to);
            if (cl != null)
                cl.Text = text;
            else
            {
                cl = FindLink(to, from);
                if (cl != null)
                    cl.Text = text;
            }

            if (cl != null)
                this.Refresh();
        }

        /// <summary>
        /// Remove link between two circles
        /// </summary>
        /// <param name="fromX">First circle X coordinate</param>
        /// <param name="fromY">First circle Y coordinate</param>
        /// <param name="toX">Second circle X coordinate</param>
        /// <param name="toY">Second circle Y coordinate</param>
        /// <returns>Success remove</returns>
        public bool RemoveLink(int fromX, int fromY, int toX, int toY)
        {
            bool result = false;

            CircleEntity from = Find(fromX, fromY);
            CircleEntity to = Find(toX, toY);

            CircleLinkEntity cl = FindLink(from, to);
            if (cl != null)
                result = from.Links.Remove(cl);
            else
            {
                cl = FindLink(to, from);
                if (cl != null)
                    result = to.Links.Remove(cl);
            }

            if (result)
                Refresh();

            return result;
        }

        /// <summary>
        /// Remove all link this circle.
        /// </summary>
        /// <param name="ce">Circle data</param>
        public void RemoveAllLink(CircleEntity ce)
        {
            if (ce == null)
		         return;

            // Check all circles. If connected this circle remoove link
            for (int i = 0; i < _circles.Count; i++)
            {
                if (_circles[i] == ce)
                    continue;

                List<CircleLinkEntity> cl = _circles[i].Links;

                for (int j = 0; j < cl.Count; j++)
                {
                    if (cl[j].Link == ce)
                    {
                        cl.RemoveAt(j);
                        break;
                    }
                }
            }
            ce.Links.Clear();
        }
        #endregion
        #endregion

        #region Protected voids
        /// <summary>
        /// Override OnPaint and implement custom draw functionality
        /// First draw linked lines. Next add text in link lines.
        /// Second draw Circles.
        /// </summary>
        /// <param name="e">Paint arguments</param>
        protected override void OnPaint(PaintEventArgs e)
        {
            int x;
            int y;
            string s;
            float textX;
            float textY;
            SizeF sizeText;
            Graphics g = e.Graphics;
            Point pStart;
            Point pEnd;

            // First draw linked lines and draw text if exist
            for (int i = 0; i < _circles.Count; i++)
            {
                List<CircleLinkEntity> cl = _circles[i].Links;
                for (int j = 0; j < cl.Count; j++)
                {
                    // Calculate center grid coordinates position
                    pStart = CalculateGrigPosCenter(_circles[i].PosX, _circles[i].PosY);
                    pEnd = CalculateGrigPosCenter(cl[j].Link.PosX, cl[j].Link.PosY);
					Pen linkPen = new Pen(cl[j].LinkColor, _linkedLineWidth);
					//_linkedLinePen = new Pen(_linkedLineColor, _linkedLineWidth);
					//g.DrawLine(_linkedLinePen, pStart, pEnd);
					g.DrawLine(linkPen, pStart, pEnd);

                    s = cl[j].Text;
                    // if text empty not draw
                    if (String.IsNullOrEmpty(s))
                        continue;

                    // Calculate text position
                    sizeText = g.MeasureString(s, _circleFont);
                    textX = Math.Min(pStart.X, pEnd.X) + (Math.Abs(pStart.X - pEnd.X) / 2) - (sizeText.Width / 2);
                    textY = Math.Min(pStart.Y, pEnd.Y) + (Math.Abs(pStart.Y - pEnd.Y) / 2) - (sizeText.Height / 2);

                    // Draw background rectangle
                    g.FillRectangle(_circleFillSolidBrush, textX, textY, sizeText.Width, sizeText.Height);
                    // Draw outside rectangle
                    g.DrawRectangle(new Pen(_circleOutlineColor, 1), textX, textY, sizeText.Width, sizeText.Height);
                    // Draw text
                    e.Graphics.DrawString(s, _circleFont, _circleFontColorSolidBrush, textX, textY);
                }
            }

            Point p;

            // Draw Circles and add inside text
            for (int i = 0; i < _circles.Count; i++)
            {
                p = CalculateGrigPos(_circles[i].PosX, _circles[i].PosY);

                // Centred to grid coordinates
                x = p.X + _gridCoordinateCorrection;
                y = p.Y + _gridCoordinateCorrection;

                // Gradient fill
                //LinearGradientBrush lBrush = new LinearGradientBrush(new Rectangle(x, y, _circleSize, _circleSize), Color.Red, Color.Yellow, LinearGradientMode.Vertical); 
                //g.FillEllipse(lBrush, x, y, _circleSize, _circleSize);

                // Draw first fill circle for background
                g.FillEllipse(_circleFillSolidBrush, x, y, _circleSize, _circleSize);
                // Draw outside circle
                g.DrawEllipse(_circlePen, x, y, _circleSize, _circleSize);

                s = _circles[i].Text;

                // Calculate text Height and Width
                sizeText = g.MeasureString(s, _circleFont);

                // Calculate text position. Justify
                textX = p.X + _cellHalfSize - (sizeText.Width / 2);
                textY = p.Y + _cellHalfSize - (sizeText.Height / 2);

                g.DrawString(s, _circleFont, _circleFontColorSolidBrush, textX, textY);
                // Rectangle over text
                //g.DrawRectangle(new Pen(Color.Red, 1.0F), textX, textY, sizeText.Width, sizeText.Height);
            }

            base.OnPaint(e);
        }
        
        /// <summary>
        /// Override OnScroll and implement custum draw functionality 
        /// Redraw all.
        /// </summary>
        /// <param name="se">Scroll arguments</param>
        protected override void OnScroll(ScrollEventArgs se)
        {
            this.Refresh();
            base.OnScroll(se);
        }

        /// <summary>
        /// Predicate Find circle coordinate
        /// </summary>
        /// <param name="ce">Circle data</param>
        /// <returns>true - equal</returns>
        protected bool FindCircle(CircleEntity ce)
        {
            return ce.PosX == _pointToFind.X && ce.PosY == _pointToFind.Y;
        }

        /// <summary>
        /// Predicate Find link
        /// </summary>
        /// <param name="cl">Link data</param>
        /// <returns>true - equal</returns>
        protected bool FindCircleLink(CircleLinkEntity cl)
        {
            return _circleEntity == cl.Link;
        }
        #endregion

        #region Private methods
        /// <summary>
        /// Calculate true position.
        /// </summary>
        /// <param name="x">X coordinate</param>
        /// <param name="y">Y coordinate</param>
        /// <returns>Calculated position</returns>
        private Point CalculateGrigPos(int x, int y)
        {
            _point.X = x * _cellSize + base.AutoScrollPosition.X;

            if (_invertGridYPosition)
                _point.Y = (_gridHeight - y) * _cellSize + base.AutoScrollPosition.Y;
            else
                _point.Y = y * _cellSize + base.AutoScrollPosition.Y;

            return _point;
        }

        /// <summary>
        /// Calculate true grid position and center coordinate
        /// </summary>
        /// <param name="x">X coordinate</param>
        /// <param name="y">Y coordinate</param>
        /// <returns>Calculated position</returns>
        private Point CalculateGrigPosCenter(int x, int y)
        {
            Point result = CalculateGrigPos(x, y);
            result.X += _cellHalfSize;
            result.Y += _cellHalfSize;

            return result;
        }

        /// <summary>
        /// Check coordinate. if neeg grow max coordinate and view scrollers.
        /// </summary>
        /// <param name="x">X coordinate</param>
        /// <param name="y">Y coordinate</param>
        private void CheckMaxLevel(int x, int y)
        {
            if (x > _gridWidth)
                _gridWidth = x;

            if (y > _gridHeight)
                _gridHeight = y;

            _size.Width = _cellSize * (_gridWidth + 1);
            _size.Height = _cellSize * (_gridHeight + 1);

            this.AutoScrollMinSize = _size;
        }
        
        /// <summary>
        /// Initailize Max grid coordinate
        /// </summary>
        /// <param name="maxSize">Max grid size</param>
        private void ResetMaxLevel(int maxSize)
        {
            _gridHeight = maxSize;
            _gridWidth = maxSize;

            CheckMaxLevel(maxSize, maxSize);
        }
        #endregion
    }
}
