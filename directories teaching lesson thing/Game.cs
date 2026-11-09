// Include the namespaces (code libraries) you need below.
using System;
using System.Numerics;

// The namespace your code is in.
namespace MohawkGame2D
{
    /// <summary>
    ///     Your game code goes inside this class!
    /// </summary>
    public class Game
    {
        //put ../ as many times as your folder is deep i think
        Texture2D tempGrapic = Graphics.LoadTexture("../../../../assets/graphics/my temp test.png"); //("C:/Users/Night/source/repos/directories teaching lesson/1assets/graphics/my temp test"); //file location, replace all // with /
        
        Font font = Text.LoadFont("../../../../assets/fonts/SonicLogoBold-MVl6x"); //the last line is the name of the thing your grabbin //usually .ttf which means true text font
        
        //Sound sfx1 = Audio.LoadSound(""); //i didnt get any
        //Sound sfx2 = Audio.LoadSound("");
        //Music bgm = Aduio.LoadMusic("");

        /// <summary>
        ///     Setup runs once before the game loop begins.
        /// </summary>
        public void Setup()
        {
            Window.SetTitle("Cool game with assets");
            Window.SetSize(600, 600);

            string cwd = System.IO.Directory.GetCurrentDirectory(); //cwd = current working directory
            Console.WriteLine($"CWD:{cwd}");
        }

        /// <summary>
        ///     Update runs every frame.
        /// </summary>
        public void Update()
        {
            Window.ClearBackground(Color.OffWhite);

            //if (Audio.IsPlaying(bgm) == false) //will restart music when reaches end of file
            //{
            //    Audio.Play(bgm);
            //}

            if (Input.IsKeyboardKeyPressed(KeyboardKey.C) == true)
            {
                //audio.Play(sfx1); //would rename to name of what it is
            }
            
            if (Input.IsKeyboardKeyPressed(KeyboardKey.T) == true)
            {
                //audio.Play(sfx2); //would rename to name of what it is
            }

            Graphics.Rotation = -15;
            Graphics.Scale = 0.7f;
            //Graphics.DrawSubset
            Graphics.Draw(tempGrapic, Vector2.Zero); //graphic starts from top left of the file.. thing to draw, location

            Text.Size = 64;
            Text.Font = font; //doesnt need to be done every frame
            Text.Color = Color.Red;
            Text.Draw("GAME \n OVER!", Window.Size / 2); // the \n means next line
        }
    }

}
