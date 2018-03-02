using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
namespace ALessonInGraphics
{
    /// <summary>
    /// A class that describes things that move
    /// </summary>
    public class Entity
    {
        public Point Position { get; private set; }
        public Point Velocity { get; private set; }

        public Entity(Point position, Point velocity)
        {
            Position = position;
            Velocity = velocity;
        }

        public void Update()
        {
            Position = new Point(Position.X + Velocity.X, Position.Y + Position.Y);
        }
    }
}
