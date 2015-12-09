namespace PongGame
{
    public class CollisionDetector
    {
        /// <summary>
        /// Calculates if rectangles describing two sprites
        /// are overlapping on screen.
        /// </summary>
        /// <param name="s1">First sprite</param>
        /// <param name="s2">Second sprite</param>
        /// <returns>Returns true if overlapping</returns>
        public static bool Overlaps(Sprite s1, Sprite s2)
        {
            if (s2.Position.Y == 0)
            {
                for (int i = (int)s1.Position.X; i <= (int)s1.Position.X + s1.Size.Right; i++)
                {
                    if(i >= (int)s2.Position.X && i <= (int)s2.Position.X + s2.Size.Right && (int)s1.Position.Y <= (int)s2.Position.Y + s2.Size.Bottom)
                    {
                        return true;
                    }
                }
            }
            else
            {
                for (int i = (int)s1.Position.X; i <= (int)s1.Position.X + s1.Size.Right; i++)
                {
                    if(i >= (int)s2.Position.X && i <= (int)s2.Position.X + s2.Size.Right && (int)s1.Position.Y + s1.Size.Bottom >= (int)s2.Position.Y)
                    {
                        return true;
                    }                   
                }
            }
            return false;
        }
    }
}
