using System;
using System.Windows.Forms;

namespace myMovieMaker.Utilities
{
    // Although this says Rich Text Box it also works for Multiline Text Boxes.
    class RichTextBoxLineManipulation
    {
       public static void MoveLine(int direction, TextBox myRichTextBox)
        {
            // Get all lines from the RichTextBox
            var lines = myRichTextBox.Lines;

            // Get the current line index
            int currentLineIndex = myRichTextBox.GetLineFromCharIndex(myRichTextBox.SelectionStart);

            // Check if the move is valid
            if ((direction == -1 && currentLineIndex == 0) || // Can't move up if it's the first line
                (direction == 1 && currentLineIndex == lines.Length - 1)) // Can't move down if it's the last line
            {
                return;
            }

            // Swap the current line with the target line
            string temp = lines[currentLineIndex];
            lines[currentLineIndex] = lines[currentLineIndex + direction];
            lines[currentLineIndex + direction] = temp;

            // Update the RichTextBox with the modified lines
            myRichTextBox.Lines = lines;

            // Restore the selection to the moved line
            int newLineIndex = currentLineIndex + direction;
            myRichTextBox.SelectionStart = myRichTextBox.GetFirstCharIndexFromLine(newLineIndex);
            myRichTextBox.SelectionLength = lines[newLineIndex].Length;
        }

        public static void DeleteLine(TextBox myRichTextBox)
        {
            // Get all lines from the RichTextBox
            var lines = myRichTextBox.Lines;

            // Get the current line index
            int currentLineIndex = myRichTextBox.GetLineFromCharIndex(myRichTextBox.SelectionStart);

            // Check if there are lines to delete
            if (lines.Length == 0 || currentLineIndex < 0 || currentLineIndex >= lines.Length)
            {
                return;
            }

            // Remove the selected line
            var updatedLines = new string[lines.Length - 1];
            for (int i = 0, j = 0; i < lines.Length; i++)
            {
                if (i != currentLineIndex)
                {
                    updatedLines[j++] = lines[i];
                }
            }

            // Update the RichTextBox with the modified lines
            myRichTextBox.Lines = updatedLines;

            // Restore the selection to the next line (or the previous line if the last line was deleted)
            int newLineIndex = Math.Min(currentLineIndex, updatedLines.Length - 1);
            if (newLineIndex >= 0)
            {
                myRichTextBox.SelectionStart = myRichTextBox.GetFirstCharIndexFromLine(newLineIndex);
                myRichTextBox.SelectionLength = updatedLines[newLineIndex].Length;
            }
        }
    }
}
