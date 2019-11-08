using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

using Engine;

namespace test_game {

  class Game1 : Game {
    GraphicsDeviceManager graphics;
    SpriteBatch spriteBatch;

    List<GameObject> objects = new List<GameObject>();

    //SpriteSheet sheet = new SpriteSheet("test_boy_sheet.png");

    public Game1() {
      graphics = new GraphicsDeviceManager(this);
      Content.RootDirectory = "Content";

      graphics.PreferredBackBufferWidth = 1280;
      graphics.PreferredBackBufferHeight = 720;
      graphics.IsFullScreen = false;
      graphics.ApplyChanges();
    }

    override protected void Initialize() {
      base.Initialize();
    }

    override protected void LoadContent() {

      spriteBatch = new SpriteBatch(GraphicsDevice);

      objects.Add(new Player());
      objects.Add(new Player2());
      objects.Add(new Player3());
      objects.Add(new Player4());
      loadObjects();
      base.LoadContent();
    }

    override protected void Update(GameTime gameTime) {
      Input.update();
      updateObjects();
      base.Update(gameTime);
    }

    override protected void Draw(GameTime gameTime) {
      GraphicsDevice.Clear(Color.CornflowerBlue);

      spriteBatch.Begin(SpriteSortMode.BackToFront, BlendState.AlphaBlend);
      drawObjects();
      spriteBatch.End();

      base.Draw(gameTime);
    }

    void loadObjects() {
      for (int i = 0; i < objects.Count; i++) {
        objects[i].init();
        objects[i].load(Content);
      }
    }

    void updateObjects() {
      for (int i = 0; i < objects.Count; i++) {
        objects[i].update();
      }
    }

    void drawObjects() {
      for (int i = 0; i < objects.Count; i++) {
        objects[i].draw(spriteBatch);
      }
    }
  }
}