namespace _02_Bottles
{
    public class Song
    {
        public string CountBottles(int bottles)
        {
            string s = "";
            if (bottles == 0)
            {
                return " No more bottles of beer on the wall.";
            }

            else if (bottles == 1)
            {
                s = bottles + " bottle of beer on the wall. "
                  + bottles + " bottle of beer."
                  + " Take one down and pass it around."
                  + " No more bottles of beer on the wall.";
                return s;
            }
            else if (bottles > 1)
            {
                s += bottles + " bottles of beer on the wall. "
                + bottles + " bottles of beer."
                + " Take one down and pass it around.";

                for (int i = bottles - 1; i > 1; i--)
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