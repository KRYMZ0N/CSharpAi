using System;


namespace Utils 
{

    public class formatter 
    {

        public bool checkUp(string s) 
        {
    
            if (s != null && s.Equals("how are you") 
            || s.Equals("how are you feeling")
            || s.Equals("how are you today")) {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}