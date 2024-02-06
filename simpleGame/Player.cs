using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;

namespace simpleGame
{
    public class Player {

        private Texture2D player;

        public Player(ContentManager content) {
            
            player = content.Load<Texture2D>("ball");
    }

        public void draw(SpriteBatch spriteBatch)
        
        {
            spriteBatch.Draw(player, new Vector2(0, 0), Color.White);
        }

    }
}
