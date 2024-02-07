using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;
using System;

namespace simpleGame
{
    public class Player {

        private Texture2D player;
        private Vector2 pos;
        private KeyboardState key;
        private const int walk = 1;
        private const int jump = 20;
        private const int gravity = 10;
        private Boolean isJumping = false;

        public Player(ContentManager content) {
            
            player = content.Load<Texture2D>("ball");
            pos = new Vector2(200, 200);
    }

        public void draw(SpriteBatch spriteBatch)
        
        {
            spriteBatch.Draw(player, pos, Color.White);
        }

        public void keyPress()
        {

            key = Keyboard.GetState();

            if (key.IsKeyDown(Keys.Up) || key.IsKeyDown(Keys.W)) {
                pos.Y -= jump;
                isJumping = true;

            }
            else if (key.IsKeyDown(Keys.Left) || key.IsKeyDown(Keys.A))
            {
                pos.X -= walk;
            } else if (key.IsKeyDown(Keys.Right) || key.IsKeyDown(Keys.D))
            {
                pos.X += walk;
            } else if (key.IsKeyDown(Keys.Down) || key.IsKeyDown(Keys.S))
            {
                pos.Y += walk;
            }

            if (isJumping)
            {
                pos.Y += gravity;

            }
        }
    }
}
