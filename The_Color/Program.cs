/* This is challenge work for the "C# Players Guide"
Level 24 "The Color" Challenge
Goals:
1) Create a Color class to represent a color
2) Colors have 3 channels: Red, Green, Blue (RGB)
3) Each Color/channel can be from 0 to 255
4) Provide color names and the channel settings for each color
5) This is tested using a constructor and a static property call
*/

Color Constructor_Color = new Color(255, 38, 233);
Color Static_Property_Color = Color.Yellow_Color;
Console.WriteLine($ {})

//Console.WriteLine($"The static property color for yellow is


public class Color
{
    //byte type used to ensure settings are between 0 and 255
    byte red { get; }
    byte green { get; }
    byte blue { get; }

    public Color(byte Red, byte Green, byte Blue)
    {
        red = Red;
        green = Green;
        blue = Blue;
    }

    // based on pg. 171 - Static Properties 
    //Sets Color type to name and passes RGB setting to constructor
    public static Color White_Color = new Color(255, 255, 255);
    public static Color Black_Color = new Color(0, 0, 0);
    public static Color Red_Color = new Color(255, 0, 0);
    public static Color Orange_Color = new Color(255,165,0);
    public static Color Yellow_Color = new Color(255,255,0);
    public static Color Green_Color = new Color(0,128,0);
    public static Color Blue_Color = new Color(0,0,255);
    public static Color Purple_Color  = new Color(128,0,128);
    

}