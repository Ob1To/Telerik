/* Write a program that replaces in a HTML document 
 * given as string all the tags <a href="…">…</a> 
 * with corresponding tags [URL=…]…/URL]. 
 * Sample HTML fragment:
 * 
 * <p>Please visit <a href="http://academy.telerik. com">our site</a> 
 * to choose a training course. Also visit <a href="www.devbg.org">our forum</a> 
 * to discuss the courses.</p>
 * 
 * <p>Please visit [URL=http://academy.telerik. com]our site[/URL] to choose a 
 * training course. Also visit [URL=www.devbg.org]our forum[/URL] to discuss the courses.</p>
 * 
 */

namespace Task_15
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    class Program
    {
        static void Main()
        {
            string htmlText = @"<p>Please visit <a href=""http://academy.telerik. com"">our site</a> to choose a training course. Also visit <a href=""www.devbg.org"">our forum</a> to discuss the courses.</p>";
            string[] tagsToFind = { "<a href=\"", "\">", "</a>" };
            string[] tagsToReplace = { "[URL=", "]", "[/URL]" };

            for (int i = 0; i < tagsToFind.Length; i++)
            {
                htmlText = htmlText.Replace(tagsToFind[i], tagsToReplace[i]);
            }
            Console.WriteLine(htmlText);
        }
    }
}
