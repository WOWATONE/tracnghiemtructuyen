using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Word = Microsoft.Office.Interop.Word;
using System.Reflection;
using System.Data;
namespace TNTT.Report
{
    class C_Export
    {
        Word._Application oWord;
        Word._Document oDoc;
        public void ExportToWord(DataTable dt)
        {
            //Init the file
            object oMissing = System.Reflection.Missing.Value;
            object oEndOfDoc = "\\endofdoc"; /* \endofdoc is a predefined bookmark */

            //Start Word and create a new document.
            oWord = new Word.Application();
            oWord.Visible = true;
            oDoc = oWord.Documents.Add(ref oMissing, ref oMissing,
                ref oMissing, ref oMissing);

            Word.Paragraph oPara1;
            oPara1 = oDoc.Content.Paragraphs.Add(ref oMissing);
            oPara1.Range.Font.Size = 15;
            //oPara1.Range.

            oPara1.Range.Text = "Trường Cao Đẳng CNTT Tp HCM\t\t\tĐề Thi Hết môn\n";
            oPara1.Range.Text += "Khoa CNTT \t\t\t\t Thời gia: 90 phút";
            oPara1.Format.Alignment = Word.WdParagraphAlignment.wdAlignParagraphLeft;

            oPara1.Range.Font.Bold = 1;
            oPara1.Format.SpaceAfter = 24;    //24 pt spacing after paragraph.
            oPara1.Range.InsertParagraphAfter();


            string[] result = { "A", "B", "C", "D", "E", "F" };
            int d = 0, stt = 1;

            string temp = "";
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                Word.Paragraph oPara2;
                object oRng = oDoc.Bookmarks.get_Item(ref oEndOfDoc).Range;
                oPara2 = oDoc.Content.Paragraphs.Add(ref oRng);
                oPara2.Range.Font.Name = "Times New Roman";
                if (temp != dt.Rows[i]["tieude"].ToString())
                {
                    d = 0;
                    oPara2.Range.Font.Bold = 1;
                    oPara2.Format.SpaceAfter = 5;
                    oPara2.Range.Text = "Câu " + stt++ + ". " + dt.Rows[i]["tieude"].ToString();
                    oPara2.Range.InsertParagraphAfter();
                    oPara2.Format.SpaceAfter = 5;
                    oPara2.Range.Font.Name = "Times New Roman";
                    oPara2.Range.Font.Bold = 0;
                    oPara2.Range.Text = result[d++] + ". " + dt.Rows[i]["cautraloi"].ToString();
                }
                else
                {
                    oPara2.Range.Font.Bold = 0;
                    oPara2.Range.Text = result[d++] + ". " + dt.Rows[i]["cautraloi"].ToString();
                }
                oPara2.Range.Select();
                oPara2.Range.InsertParagraphAfter();
                oPara2.Format.SpaceAfter = 5;
               
                temp = dt.Rows[i]["tieude"].ToString();


            }

            Word.Table oTable;
            Word.Range wrdRng = oDoc.Bookmarks.get_Item(ref oEndOfDoc).Range;
            wrdRng = oDoc.Bookmarks.get_Item(ref oEndOfDoc).Range;
            wrdRng.InsertParagraphAfter();
            wrdRng.InsertAfter("THE END.");

            oWord.ActiveWindow.Selection.TypeText("Plaintiff's Attorney's Initals");
            oWord.ActiveWindow.Selection.TypeText("\t");


            //set foooter
            foreach (Microsoft.Office.Interop.Word.Section wordSection in this.oDoc.Sections)
            {
                wordSection.Footers[Word.WdHeaderFooterIndex.wdHeaderFooterPrimary]
                    .Range.Font.ColorIndex = Word.WdColorIndex.wdDarkRed;

                wordSection.Footers[Word.WdHeaderFooterIndex.wdHeaderFooterPrimary]
                    .Range.Font.Size = 13;
                wordSection.Footers[Word.WdHeaderFooterIndex.wdHeaderFooterPrimary]
            .Range.Text = "Confidential";
            }

            foreach (Word.Section section in this.oDoc.Sections)
            {
                object fieldEmpty = Word.WdFieldType.wdFieldEmpty;
                object autoText = "AUTOTEXT  \"Page X of Y\" ";
                object preserveFormatting = true;

                section.Headers[Word.WdHeaderFooterIndex.wdHeaderFooterPrimary].Range.Fields.Add(
                    section.Headers[Word.WdHeaderFooterIndex.wdHeaderFooterPrimary].Range,
                    ref fieldEmpty, ref autoText, ref preserveFormatting);
                section.Headers[Word.WdHeaderFooterIndex.wdHeaderFooterPrimary].Range.Text = "Đề thi trắc nghiệm";
            }
            
        }
      }
}
