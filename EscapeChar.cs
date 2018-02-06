using System;

namespace EscapeChar {
   class Program {
      static void Main(string[] args) {

          /*
          \\	\ character
            \'	' character
            \"	" character
            \?	? character
            \a	Alert or bell
            \b	Backspace
            \f	Form feed
            \n	Newline
            \r	Carriage return
            \t	Horizontal tab
            \v	Vertical tab
            \xhh . . .	Hexadecimal number of one or more digits
           */
         Console.WriteLine("Hello\tWorld\n\n");
         Console.ReadLine();
      }
   }
}