# Side Quest - Binary and Hexadecimal literals

## ℹ️ Information
So far, the integer literals we have written have all been written using <i>base 10</i>, the normal 10-
digit system humans typically use. But in the programming world, it is occasionally easier to
write out the number using either <i>base 2</i> (binary digits) or <i>base 16</i> (hexadecimal digits, which
are 0 through 9, and then the letters A through F).

To write a binary literal, start your number with a <b>0b</b>. For example:<br>
<blockquote>
int thirteen = 0b00001101;<br>
</blockquote>
For a hexadecimal literal, you start your number with <b>0x</b>:<br>
<blockquote>
int theColorMagenta = 0xFF00FF;<br>
</blockquote>
This example shows one of the places where this might be useful. Colors are often represented
as either six or eight hexadecimal digits.<br>

## 📖 Answers
<table>
    <tr>
        <th>Decimal</th>
        <th>Binary</th>
        <th>Hexadecimal</th>
    </tr>
    <tr><td>0</td><td>0b0000</td><td>0x0</td></tr>
    <tr><td>1</td><td>0b0001</td><td>0x1</td></tr>
    <tr><td>2</td><td>0b0010</td><td>0x2</td></tr>
    <tr><td>3</td><td>0b0011</td><td>0x3</td></tr>
    <tr><td>4</td><td>0b0100</td><td>0x4</td></tr>
    <tr><td>5</td><td>0b0101</td><td>0x5</td></tr>
    <tr><td>6</td><td>0b0110</td><td>0x6</td></tr>
    <tr><td>7</td><td>0b0111</td><td>0x7</td></tr>
    <tr><td>8</td><td>0b1000</td><td>0x8</td></tr>
    <tr><td>9</td><td>0b1001</td><td>0x9</td></tr>
    <tr><td>10</td><td>0b1010</td><td>0xA</td></tr>
</table>

<hr>
📅 **Last Updated:** `2025-02-13`