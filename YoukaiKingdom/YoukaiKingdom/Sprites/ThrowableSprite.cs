﻿using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using YoukaiKingdom.GameLogic;
using YoukaiKingdom.GameScreens;
using YoukaiKingdom.Helpers;

namespace YoukaiKingdom.Sprites
{
    class ThrowableSprite : AnimatedSprite
    {
        private AnimatedSprite sender; 
  
        public ThrowableSprite(AnimatedSprite sender, Texture2D sprite, Dictionary<AnimationKey, Animation> animation) : base(sprite, animation)
        {
            this.sender = sender;
            this.currentLookingPosition = sender.currentLookingPosition;
        }

        public bool IsDestroyed { get; private set; }

        public void Update(GameTime gameTime, GamePlayScreen mGame)
        {

        }
        protected override void CheckCollision(Vector2 prevPosition, GamePlayScreen mGame, int worldWidth, int worldHeight)
        {
            foreach (var r in mGame.CollisionRectangles)
            {
                if (this.collisionRectangle.Intersects(r))
                {
                    this.IsDestroyed = true;
                }
            }
        }
    }
}
