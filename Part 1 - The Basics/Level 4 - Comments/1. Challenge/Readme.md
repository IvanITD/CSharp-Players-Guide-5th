# Challenge - The Thing Namer 3000 (100 XP)

## ✅ Objectives
- Rebuild the program above on your computer.
- Add comments near each of the four variables that describe what they store. You must use at leas one of each comment type (<b>//</b> and <b>/* */</b>).
- Find the bug in the text displayed and fix it
- <b>Answer this question:</b> Aside from comments, what else could you do to make this code more understandable?

## ℹ️ Information
As you walk through the city of Commenton, admiring its forward-slash-based architectural building, a
young man approaches you in panic. "I dropped my <i>Thing Namer 3000</i> and broke it. I think it's mostly
working, but all my variable names got reset! I don't understand what they do!" He shows you the
following program:

<blockquote>
Console.WriteLine("What kind of thing are we talking about?");<br>
string a = Console.ReadLine();<br>
Console.WriteLine("How would you describe it? Big? Azure? Tattered?");<br>
string b = Console.ReadLine();<br>
string c = "of Doom";<br>
string d = "3000";<br>
Console.WriteLine("The " + b + " " + a + " of " + c + " " + d + "!");<br>
</blockquote>

## 📖 Answers
- The program is rebuilt in a C# program inside the folder next to this readme file.
- I used comments near each of the four variables that described what they store. For this assignment I used each type of each comment variation.
- The bug was the second added "of" word.
- In order to make this code understandable we can change the printing style and instead of using the printing style "concatenation" we can use the more friendly approachable way called "interpolation"

<hr>
📅 **Last Updated:** `2025-02-13`