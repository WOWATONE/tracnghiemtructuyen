using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Word = Microsoft.Office.Interop.Word;
using System.Reflection;
using System.Data;
using TNTT.Class;
using Microsoft.Office.Interop.Word;

namespace TNTT.Report
{
    class C_Export
    {
        Word._Application oWord;
        Word._Document oDoc;
        public void ExportToWord(DataTable dt)
        {
            try
            {

                //Init the file
                object oMissing = System.Reflection.Missing.Value;
                object oEndOfDoc = "\\endofdoc"; /* \endofdoc is a predefined bookmark */

                //Start Word and create a new document.
                oWord = new Word.Application();
                //Word.Document doc = oWord.Documents.Add(@"F:\De Tai Mon Hoc\TNTT\TNTT\template_cntt.dotm");
               // Word.Document doc = oWord.Documents.Add(@"F:\De Tai Mon Hoc\TNTT\TNTT\template_cntt.dotm");

                
                
                oDoc = oWord.Documents.Add(ref oMissing, ref oMissing,
                    ref oMissing, ref oMissing);
                Word.Range rng = oDoc.Content;
                rng.InsertFile(FileName: @"F:\De Tai Mon Hoc\TNTT\TNTT\template_cntt.dotm");
                oWord.Visible = true;

                Word.Paragraph oPara0;
                oPara0 = oDoc.Content.Paragraphs.Add(ref oMissing);
                oPara0.Range.Font.Size = 15;
               // oPara0.Range.Text = rng.Text;
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


                //set foooter
                //foreach (Microsoft.Office.Interop.Word.Section wordSection in this.oDoc.Sections)
                //{
                //    wordSection.Footers[Word.WdHeaderFooterIndex.wdHeaderFooterPrimary]
                //        .Range.Font.ColorIndex = Word.WdColorIndex.wdDarkRed;
                //    wordSection.Range.Font.Name = "Times New Roman";
                //    wordSection.Footers[Word.WdHeaderFooterIndex.wdHeaderFooterPrimary]
                //        .Range.Font.Size = 13;
                //    wordSection.Footers[Word.WdHeaderFooterIndex.wdHeaderFooterPrimary]
                //.Range.Text = "Đề thi trắc nghiệm";
                //}

                //foreach (Word.Section section in this.oDoc.Sections)
                //{
                //    object fieldEmpty = Word.WdFieldType.wdFieldEmpty;
                //    object autoText = "Đề thi trắc nghiệm";
                //    object preserveFormatting = true;

                //    section.Headers[Word.WdHeaderFooterIndex.wdHeaderFooterPrimary].Range.Fields.Add(
                //        section.Headers[Word.WdHeaderFooterIndex.wdHeaderFooterPrimary].Range,
                //        ref fieldEmpty, ref autoText, ref preserveFormatting);
                //    section.Headers[Word.WdHeaderFooterIndex.wdHeaderFooterPrimary].Range.Text = autoText.ToString();
                //}


            }
            catch { }
        }
      }
}
