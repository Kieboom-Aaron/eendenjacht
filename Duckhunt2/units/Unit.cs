using Duckhunt2.containers;
using Duckhunt2.factories;
using Duckhunt2.objects;
using Duckhunt2.states;
using Duckhunt2.visitors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Imaging;

namespace Duckhunt2
{
    abstract class Unit: MoveableObject, DrawableObject, CollisionObject
    {
        public double _x, _y;
        public double _canvasH, _canvasW;
        public double _imageH, _imageW;
        public int _direction;
        public UnitState state;
        public Round _currentRound { get; private set; }
        public int _speed { get; private set; }
        public int _dioSpeed { get; private set; }
        public BitmapImage[,] _imageSets;
        public Image _currentImage;
        public int _imageStep, _maxCollisions;
        public double _imageTimer, _imageInterval;

        protected void generateStartPos(Canvas c)
        {
            SingletonRandom r = SingletonRandom.getInstance();
            int side = r.Next(0, 2);
            int dir = r.Next(0, 3);
            int x = r.Next(1, (int)(c.Width - _currentImage.Width));
            int y = r.Next(1, (int)(c.Height - _currentImage.Height));
            switch (side)
            {
                case 0:
                    {
                        _direction = Directions.RIGHT_DIRECTIONS[dir];
                        _x = 0;
                        _y = y;
                        break;
                    }
                case 1:
                    {
                        _direction = Directions.LEFT_DIRECTIONS[dir];
                        _x = (int)(c.Width - _currentImage.Width); ;
                        _y = y;
                        break;
                    }
            }
        }

        public Unit(Canvas c)
        {
            _imageStep = 0;
            _canvasH = c.Height;
            _canvasW = c.Width;
            _currentImage = new Image();
        }

        public void subscribe() { //Singleton anti-pattern :(
            state = UnitStateFactory.Instance.create("unit-alive");
            DrawContainer.getInstance().Add(this);
            MoveContainer.getInstance().Add(this);
            CollisionContainer.getInstance().Add(this);
            UnitContainer.getInstance().Add(this);
            _currentRound.registerUnit(this);
        }

        public void Accept(MoveVisitor mv, double delta)
        {
            mv.Visit(this, delta);
        }

        public void Accept(DrawVisitor dv, double delta)
        {
            dv.Visit(this, delta);
        }

        public void Accept(CollisionVisitor cv)
        {
            cv.Visit(this);
        }

        protected void setSpeed(int speed)
        {
            _speed = speed;
            _dioSpeed = (int)Math.Sqrt(speed * speed / 2);
        }

        public UIElement getDrawable()
        {
            return _currentImage;
        }

        protected void setImageDimentions(double height, double width)
        {
            _currentImage.Height = height;
            _currentImage.Width = width;
            _imageH = height;
            _imageW = width;
        }

        public Unit Clone(Round r) {
            Unit clone = (Unit)this.MemberwiseClone();
            clone._currentRound = r;
            return clone;
        }

        public void init() {
            this._currentImage = _currentImage = new Image();
        }
    }
}
