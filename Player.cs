using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Engine;

namespace test_game {

  public class Player : GameObject {
    public Player() { }

    public override void init() {
      base.init();
    }

    public override void load(ContentManager content) {
      setImage(TextureLoader.Load("test_boy_sheet.png", content));
      base.load(content);

      spriteClip = new Rectangle(0, 0, 48, 32);
    }

    public override void update() {
      base.update();
    }
  }

  public class Player2 : GameObject {
    public Player2() { }

    public override void init() {
      position.Y = 100;
      base.init();
    }

    public override void load(ContentManager content) {
      setSpriteSheet(TextureLoader.Load("test_boy_sheet.png", content), 4, 4);
      base.load(content);

      Console.WriteLine(spriteWidth);
    }

    public override void update() {
      base.update();
    }
  }

  public class Player3 : GameObject {
    public Player3() { }

    public override void init() {
      position.Y = 200;
      int[] frames = { 0, 1, 0, 2 };
      spriteSheetAnimation = new Animation(frames, 0, 10);
      base.init();
    }

    public override void load(ContentManager content) {
      setSpriteSheet(TextureLoader.Load("test_boy_sheet.png", content), 4, 4);
      base.load(content);
    }

    public override void update() {
      base.update();
    }
  }

  public class Player4 : GameObject {
    int timer = 0;
    public Player4() { }

    public override void init() {
      position.Y = 300;
      base.init();
    }

    public override void load(ContentManager content) {
      setSpriteSheet(TextureLoader.Load("test_boy_sheet.png", content), 4, 4);
      base.load(content);
    }

    public override void update() {
      timer++;
      if (timer % 10 == 0) {
        currentFrame = (currentFrame == 1 ? 0 : 1);
      }
      base.update();
    }
  }
}