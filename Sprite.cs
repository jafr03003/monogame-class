using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
 
namespace monogameSprite{
class Sprite{
 
    public Texture2D Texture {get; set;}
    public Vector2 Vector {get; set;}
    public Rectangle Rectangle {get; set;}
 
    public Sprite(Texture2D texture, Rectangle rectangle, Vector2 vector){Texture=texture; Rectangle=rectangle; Vector=vector;}
 
    
//public override string ToString(){
        /*
        string output="";
        output+=Texture2D+" "+Rectangle+" "+Vector2;
        return output;
    
    } */
 }
} 
