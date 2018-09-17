using System;
using System.Linq;

namespace CaesarCipher
{
    public static class RotationalCipher
    {
        public static string Rotate(string text, int shiftKey)
        {
            throw new NotImplementedException("You need to implement this function.");
            string str="";
            foreach(char c in text)
            {
                int i=(int)c;
                int a=i+(shiftKey%26);
                //check if the letter is capital letter or not
                if(i>=97 && i<123)
                {
                    //it will take back to in 26 word loop
                if(a>122)
                {
                    a=a-122+96;
                }
                str+=(char)a;
                }
             else if(i>=65 && i<91)
                {
                if(a>90)
                {
                    a=a-90+64;
                }
                    str+=(char)a;
                }

                else{
                    str+=c;
                }
                
            }
            return str;
        }
        }
    }

