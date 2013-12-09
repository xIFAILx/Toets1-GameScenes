using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.GamerServices;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;
using PyramidPanic.HelperClass;

namespace PyramidPanic
{
    public class Menu
    {
      //Fields
      private Image start, load, help, scores, quit;
      private PyramidPanic game;
      //Maak een variabele (reference) van het typen PyramidPanic
      //Constructor
      public Menu(PyramidPanic game)
      {
          this.game = game;
          this.Initialize();
      }
      public void Initialize()
      {
          this.LoadContent();
      }

      public void LoadContent()
      {
          this.start = new Image(this.game, @"StartScene\Button_start", new Vector2(20f, 430f));
          this.start = new Image(this.game, @"StartScene\Button_load", new Vector2(40f, 430f));
          this.start = new Image(this.game, @"StartScene\Button_help", new Vector2(60f, 430f));
          this.start = new Image(this.game, @"StartScene\Button_scores", new Vector2(80f, 430f));
          this.start = new Image(this.game, @"StartScene\Button_quit", new Vector2(100f, 430f));
      }
      //Update
      public void Update(GameTime gameTime)
      {

      }
      //Draw
      public void Draw(GameTime gameTime)
      {
          this.start.Draw(gameTime);
          this.load.Draw(gameTime);
          this.help.Draw(gameTime);
          this.scores.Draw(gameTime);
          this.quit.Draw(gameTime);
      }

      
    }
}
