using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Web;

namespace viettechnews.Common
{
    public class Catkytu
    {
        public string Limit(string orgText, int maxLength, string append)
        {
            if (orgText == null) return null;
            if (orgText.Length <= maxLength) return orgText;
            orgText = HttpContext.Current.Server.HtmlDecode(orgText);
            var words = orgText.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            var sb = new StringBuilder();
            foreach (var word in words)
            {
                if ((sb + word).Length > maxLength)
                    return string.Format("{0}{1}", sb.ToString().TrimEnd(' '), append);
                sb.Append(word + " ");
            }
            return string.Format("{0}{1}", sb.ToString().TrimEnd(' '), append);
        }
        public string CvString(string text)
        {
            for (int i = 32; i < 48; i++)
            {
                text = text.Replace(((char)i).ToString(), " ");
            }
            text = text.Trim().Replace("''", "-");
            text = text.Trim().Replace("”", "");
            text = text.Trim().Replace("“", "");
            text = text.Trim().Replace(" ", "-");
            text = text.Trim().Replace(",", "-");
            text = text.Trim().Replace(";", "-");
            text = text.Trim().Replace(":", "-");
            text = text.Trim().Replace("-", "-");
            text = text.Trim().Replace('"', '-');

            Regex regex = new Regex(@"\p{IsCombiningDiacriticalMarks}+");

            string strFormD = text.Normalize(System.Text.NormalizationForm.FormD);
            return ((regex.Replace(strFormD, String.Empty).Trim().Replace('\u0111', 'd').Replace('\u0110', 'D')).ToLower()).Replace("--", "-");
        }       

    }
}