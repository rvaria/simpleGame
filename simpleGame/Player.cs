using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;
using System.Runtime.InteropServices;
using System;

namespace simpleGame
{
    public class Player {

        private Texture2D player;
        private Vector2 pos;
        private KeyboardState key;

        public Player(ContentManager content) {
            
            player = content.Load<Texture2D>("ball");
            pos = new Vector2(100, 100);
    }

        public void draw(SpriteBatch spriteBatch)
        
        {
            spriteBatch.Draw(player, pos, Color.White);
        }

        public void keyPress()
        {
            key = Keyboard.GetState();

            if (key.IsKeyDown(Keys.Up) || key.IsKeyDown(Keys.W)) {
                pos.Y -= 1;
            } else if (key.IsKeyDown(Keys.Left) || key.IsKeyDown(Keys.A))
            {
                pos.X -= 1;
            } else if (key.IsKeyDown(Keys.Right) || key.IsKeyDown(Keys.D))
            {
                pos.X += 1;
            } else if (key.IsKeyDown(Keys.Down) || key.IsKeyDown(Keys.S))
            {
                pos.Y += 1;
            }
        }
    }
}
