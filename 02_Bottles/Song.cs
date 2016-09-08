namespace _02_Bottles
{
    public class Song
    {
        public string CountBottles(int b)
        {
            string s = "";
            if (b == 0)
            {
                return " No more bottles of beer on the wall.";
            }

            else if (b == 1)
            {
                s = b + " bottle of beer on the wall. "
                  + b + " bottle of beer."
                  + " Take one down and pass it around."
                  + " No more bottles of beer on the wall.";
                return s;
            }
            else if (b > 1)
            {
                s += b + " bottles of beer on the wall. "
                + b + " bottles of beer."
                + " Take one down and pass it around.";

                for (int i = b - 1; i > 1; i--)
                {
                    s = s + " " + i + " bottles of beer on the wall. "
                        + i + " bottles of beer on the wall. " +
                     + i + " bottles of beer."
                    + " Take one down and pass it around.";
                }
            }
            s += " 1 bottle of beer on the wall." 
                + " 1 bottle of beer on the wall."
                + " 1 bottle of beer."
                + " Take one down and pass it around. ";

            s += "No more bottles of beer on the wall.";
            return s;
        }
    }
}