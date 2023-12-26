using System.Text;
using System.Text.RegularExpressions;

namespace My.Text
{
    /// <summary>
    /// XMLなどで使用される文字実体参照を扱います。
    /// </summary>
    public static class CharacterEntityReference
    {
        /// <summary>
        /// 入力される文字列内の文字実体参照を文字や記号に置きかえます。ベーシック版です。
        /// </summary>
        /// <param name="source">置きかえられる文字列。</param>
        /// <returns>置きかえられた文字列。</returns>
        static public string ConvertFromBasic(string source)
        {
            string txt = source;

            // "U+00022", "QUOTATION MARK"
            txt = Regex.Replace(txt, "&#x0*?22;", @"""");
            txt = Regex.Replace(txt, "&#0*?34;", @"""");
            txt = Regex.Replace(txt, "&quot;", @"""");
            txt = Regex.Replace(txt, "&QUOT;", @"""");

            // "U+00026", "AMPERSAND"
            txt = Regex.Replace(txt, "&#x0*?26;", "&");
            txt = Regex.Replace(txt, "&#0*?38;", "&");
            txt = Regex.Replace(txt, "&amp;", "&");
            txt = Regex.Replace(txt, "&AMP;", "&");

            // "U+00027", "APOSTROPHE"
            txt = Regex.Replace(txt, "&#x0*?27;", "'");
            txt = Regex.Replace(txt, "&#0*?39;", "'");
            txt = Regex.Replace(txt, "&apos;", "'");

            // "U+0003C", "LESS-THAN SIGN"
            txt = Regex.Replace(txt, "&#x0*?3C;", "<");
            txt = Regex.Replace(txt, "&#0*?60;", "<");
            txt = Regex.Replace(txt, "&lt;", "<");
            txt = Regex.Replace(txt, "&LT;", "<");

            // "U+0003E", "GREATER-THAN SIGN"
            txt = Regex.Replace(txt, "&#x0*?3E;", ">");
            txt = Regex.Replace(txt, "&#0*?62;", ">");
            txt = Regex.Replace(txt, "&gt;", ">");
            txt = Regex.Replace(txt, "&GT;", ">");

            // "U+000A0", "NO-BREAK SPACE"
            txt = Regex.Replace(txt, "&#x0*?A0;", " ");
            txt = Regex.Replace(txt, "&#0*?160;", " ");
            txt = Regex.Replace(txt, "&nbsp;", " ");
            txt = Regex.Replace(txt, "&NonBreakingSpace;", " ");

            // "U+000A1", "INVERTED EXCLAMATION MARK"
            txt = Regex.Replace(txt, "&#x0*?A1;", "¡");
            txt = Regex.Replace(txt, "&#0*?161;", "¡");
            txt = Regex.Replace(txt, "&iexcl;", "¡");

            // "U+000A2", "CENT SIGN"
            txt = Regex.Replace(txt, "&#x0*?A2;", "¢");
            txt = Regex.Replace(txt, "&#0*?162;", "¢");
            txt = Regex.Replace(txt, "&cent;", "¢");

            // "U+000A3", "POUND SIGN"
            txt = Regex.Replace(txt, "&#x0*?A3;", "£");
            txt = Regex.Replace(txt, "&#0*?163;", "£");
            txt = Regex.Replace(txt, "&pound;", "£");

            // "U+000A4", "CURRENCY SIGN"
            txt = Regex.Replace(txt, "&#x0*?A4;", "¤");
            txt = Regex.Replace(txt, "&#0*?164;", "¤");
            txt = Regex.Replace(txt, "&curren;", "¤");

            // "U+000A5", "YEN SIGN"
            txt = Regex.Replace(txt, "&#x0*?A5;", "¥");
            txt = Regex.Replace(txt, "&#0*?165;", "¥");
            txt = Regex.Replace(txt, "&yen;", "¥");

            // "U+000A6", "BROKEN BAR"
            txt = Regex.Replace(txt, "&#x0*?A6;", "¦");
            txt = Regex.Replace(txt, "&#0*?166;", "¦");
            txt = Regex.Replace(txt, "&brvbar;", "¦");

            // "U+000A7", "SECTION SIGN"
            txt = Regex.Replace(txt, "&#x0*?A7;", "§");
            txt = Regex.Replace(txt, "&#0*?167;", "§");
            txt = Regex.Replace(txt, "&sect;", "§");

            // "U+000A8", "DIAERESIS"
            txt = Regex.Replace(txt, "&#x0*?A8;", "¨");
            txt = Regex.Replace(txt, "&#0*?168;", "¨");
            txt = Regex.Replace(txt, "&Dot;", "¨");
            txt = Regex.Replace(txt, "&die;", "¨");
            txt = Regex.Replace(txt, "&DoubleDot;", "¨");
            txt = Regex.Replace(txt, "&uml;", "¨");

            // "U+000A9", "COPYRIGHT SIGN"
            txt = Regex.Replace(txt, "&#x0*?A9;", "©");
            txt = Regex.Replace(txt, "&#0*?169;", "©");
            txt = Regex.Replace(txt, "&copy;", "©");
            txt = Regex.Replace(txt, "&COPY;", "©");

            // "U+000AA", "FEMININE ORDINAL INDICATOR"
            txt = Regex.Replace(txt, "&#x0*?AA;", "ª");
            txt = Regex.Replace(txt, "&#0*?170;", "ª");
            txt = Regex.Replace(txt, "&ordf;", "ª");

            // "U+000AB", "LEFT-POINTING DOUBLE ANGLE QUOTATION MARK"
            txt = Regex.Replace(txt, "&#x0*?AB;", "«");
            txt = Regex.Replace(txt, "&#0*?171;", "«");
            txt = Regex.Replace(txt, "&laquo;", "«");

            // "U+000AC", "NOT SIGN"
            txt = Regex.Replace(txt, "&#x0*?AC;", "¬");
            txt = Regex.Replace(txt, "&#0*?172;", "¬");
            txt = Regex.Replace(txt, "&not;", "¬");

            // "U+000AD", "SOFT HYPHEN"
            txt = Regex.Replace(txt, "&#x0*?AD;", "­");
            txt = Regex.Replace(txt, "&#0*?173;", "­");
            txt = Regex.Replace(txt, "&shy;", "­");

            // "U+000AE", "REGISTERED SIGN"
            txt = Regex.Replace(txt, "&#x0*?AE;", "®");
            txt = Regex.Replace(txt, "&#0*?174;", "®");
            txt = Regex.Replace(txt, "&reg;", "®");
            txt = Regex.Replace(txt, "&circledR;", "®");
            txt = Regex.Replace(txt, "&REG;", "®");

            // "U+000AF", "MACRON"
            txt = Regex.Replace(txt, "&#x0*?AF;", "¯");
            txt = Regex.Replace(txt, "&#0*?175;", "¯");
            txt = Regex.Replace(txt, "&macr;", "¯");
            txt = Regex.Replace(txt, "&OverBar;", "¯");
            txt = Regex.Replace(txt, "&strns;", "¯");

            // "U+000B0", "DEGREE SIGN"
            txt = Regex.Replace(txt, "&#x0*?B0;", "°");
            txt = Regex.Replace(txt, "&#0*?176;", "°");
            txt = Regex.Replace(txt, "&deg;", "°");

            // "U+000B1", "PLUS-MINUS SIGN"
            txt = Regex.Replace(txt, "&#x0*?B1;", "±");
            txt = Regex.Replace(txt, "&#0*?177;", "±");
            txt = Regex.Replace(txt, "&plusmn;", "±");
            txt = Regex.Replace(txt, "&pm;", "±");
            txt = Regex.Replace(txt, "&PlusMinus;", "±");

            // "U+000B2", "SUPERSCRIPT TWO"
            txt = Regex.Replace(txt, "&#x0*?B2;", "²");
            txt = Regex.Replace(txt, "&#0*?178;", "²");
            txt = Regex.Replace(txt, "&sup2;", "²");

            // "U+000B3", "SUPERSCRIPT THREE"
            txt = Regex.Replace(txt, "&#x0*?B3;", "³");
            txt = Regex.Replace(txt, "&#0*?179;", "³");
            txt = Regex.Replace(txt, "&sup3;", "³");

            // "U+000B4", "ACUTE ACCENT"
            txt = Regex.Replace(txt, "&#x0*?B4;", "´");
            txt = Regex.Replace(txt, "&#0*?180;", "´");
            txt = Regex.Replace(txt, "&acute;", "´");
            txt = Regex.Replace(txt, "&DiacriticalAcute;", "´");

            // "U+000B5", "MICRO SIGN"
            txt = Regex.Replace(txt, "&#x0*?B5;", "µ");
            txt = Regex.Replace(txt, "&#0*?181;", "µ");
            txt = Regex.Replace(txt, "&micro;", "µ");

            // "U+000B6", "PILCROW SIGN"
            txt = Regex.Replace(txt, "&#x0*?B6;", "¶");
            txt = Regex.Replace(txt, "&#0*?182;", "¶");
            txt = Regex.Replace(txt, "&para;", "¶");

            // "U+000B7", "MIDDLE DOT"
            txt = Regex.Replace(txt, "&#x0*?B7;", "·");
            txt = Regex.Replace(txt, "&#0*?183;", "·");
            txt = Regex.Replace(txt, "&middot;", "·");
            txt = Regex.Replace(txt, "&centerdot;", "·");
            txt = Regex.Replace(txt, "&CenterDot;", "·");

            // "U+000B8", "CEDILLA"
            txt = Regex.Replace(txt, "&#x0*?B8;", "¸");
            txt = Regex.Replace(txt, "&#0*?184;", "¸");
            txt = Regex.Replace(txt, "&cedil;", "¸");
            txt = Regex.Replace(txt, "&Cedilla;", "¸");

            // "U+000B9", "SUPERSCRIPT ONE"
            txt = Regex.Replace(txt, "&#x0*?B9;", "¹");
            txt = Regex.Replace(txt, "&#0*?185;", "¹");
            txt = Regex.Replace(txt, "&sup1;", "¹");

            // "U+000BA", "MASCULINE ORDINAL INDICATOR"
            txt = Regex.Replace(txt, "&#x0*?BA;", "º");
            txt = Regex.Replace(txt, "&#0*?186;", "º");
            txt = Regex.Replace(txt, "&ordm;", "º");

            // "U+000BB", "RIGHT-POINTING DOUBLE ANGLE QUOTATION MARK"
            txt = Regex.Replace(txt, "&#x0*?BB;", "»");
            txt = Regex.Replace(txt, "&#0*?187;", "»");
            txt = Regex.Replace(txt, "&raquo;", "»");

            // "U+000BC", "VULGAR FRACTION ONE QUARTER"
            txt = Regex.Replace(txt, "&#x0*?BC;", "¼");
            txt = Regex.Replace(txt, "&#0*?188;", "¼");
            txt = Regex.Replace(txt, "&frac14;", "¼");

            // "U+000BD", "VULGAR FRACTION ONE HALF"
            txt = Regex.Replace(txt, "&#x0*?BD;", "½");
            txt = Regex.Replace(txt, "&#0*?189;", "½");
            txt = Regex.Replace(txt, "&frac12;", "½");
            txt = Regex.Replace(txt, "&half;", "½");

            // "U+000BE", "VULGAR FRACTION THREE QUARTERS"
            txt = Regex.Replace(txt, "&#x0*?BE;", "¾");
            txt = Regex.Replace(txt, "&#0*?190;", "¾");
            txt = Regex.Replace(txt, "&frac34;", "¾");

            // "U+000BF", "INVERTED QUESTION MARK"
            txt = Regex.Replace(txt, "&#x0*?BF;", "¿");
            txt = Regex.Replace(txt, "&#0*?191;", "¿");
            txt = Regex.Replace(txt, "&iquest;", "¿");

            // "U+000C0", "LATIN CAPITAL LETTER A WITH GRAVE"
            txt = Regex.Replace(txt, "&#x0*?C0;", "À");
            txt = Regex.Replace(txt, "&#0*?192;", "À");
            txt = Regex.Replace(txt, "&Agrave;", "À");

            // "U+000C1", "LATIN CAPITAL LETTER A WITH ACUTE"
            txt = Regex.Replace(txt, "&#x0*?C1;", "Á");
            txt = Regex.Replace(txt, "&#0*?193;", "Á");
            txt = Regex.Replace(txt, "&Aacute;", "Á");

            // "U+000C2", "LATIN CAPITAL LETTER A WITH CIRCUMFLEX"
            txt = Regex.Replace(txt, "&#x0*?C2;", "Â");
            txt = Regex.Replace(txt, "&#0*?194;", "Â");
            txt = Regex.Replace(txt, "&Acirc;", "Â");

            // "U+000C3", "LATIN CAPITAL LETTER A WITH TILDE"
            txt = Regex.Replace(txt, "&#x0*?C3;", "Ã");
            txt = Regex.Replace(txt, "&#0*?195;", "Ã");
            txt = Regex.Replace(txt, "&Atilde;", "Ã");

            // "U+000C4", "LATIN CAPITAL LETTER A WITH DIAERESIS"
            txt = Regex.Replace(txt, "&#x0*?C4;", "Ä");
            txt = Regex.Replace(txt, "&#0*?196;", "Ä");
            txt = Regex.Replace(txt, "&Auml;", "Ä");

            // "U+000C5", "LATIN CAPITAL LETTER A WITH RING ABOVE"
            txt = Regex.Replace(txt, "&#x0*?C5;", "Å");
            txt = Regex.Replace(txt, "&#0*?197;", "Å");
            txt = Regex.Replace(txt, "&Aring;", "Å");

            // "U+000C6", "LATIN CAPITAL LETTER AE"
            txt = Regex.Replace(txt, "&#x0*?C6;", "Æ");
            txt = Regex.Replace(txt, "&#0*?198;", "Æ");
            txt = Regex.Replace(txt, "&AElig;", "Æ");

            // "U+000C7", "LATIN CAPITAL LETTER C WITH CEDILLA"
            txt = Regex.Replace(txt, "&#x0*?C7;", "Ç");
            txt = Regex.Replace(txt, "&#0*?199;", "Ç");
            txt = Regex.Replace(txt, "&Ccedil;", "Ç");

            // "U+000C8", "LATIN CAPITAL LETTER E WITH GRAVE"
            txt = Regex.Replace(txt, "&#x0*?C8;", "È");
            txt = Regex.Replace(txt, "&#0*?200;", "È");
            txt = Regex.Replace(txt, "&Egrave;", "È");

            // "U+000C9", "LATIN CAPITAL LETTER E WITH ACUTE"
            txt = Regex.Replace(txt, "&#x0*?C9;", "É");
            txt = Regex.Replace(txt, "&#0*?201;", "É");
            txt = Regex.Replace(txt, "&Eacute;", "É");

            // "U+000CA", "LATIN CAPITAL LETTER E WITH CIRCUMFLEX"
            txt = Regex.Replace(txt, "&#x0*?CA;", "Ê");
            txt = Regex.Replace(txt, "&#0*?202;", "Ê");
            txt = Regex.Replace(txt, "&Ecirc;", "Ê");

            // "U+000CB", "LATIN CAPITAL LETTER E WITH DIAERESIS"
            txt = Regex.Replace(txt, "&#x0*?CB;", "Ë");
            txt = Regex.Replace(txt, "&#0*?203;", "Ë");
            txt = Regex.Replace(txt, "&Euml;", "Ë");

            // "U+000CC", "LATIN CAPITAL LETTER I WITH GRAVE"
            txt = Regex.Replace(txt, "&#x0*?CC;", "Ì");
            txt = Regex.Replace(txt, "&#0*?204;", "Ì");
            txt = Regex.Replace(txt, "&Igrave;", "Ì");

            // "U+000CD", "LATIN CAPITAL LETTER I WITH ACUTE"
            txt = Regex.Replace(txt, "&#x0*?CD;", "Í");
            txt = Regex.Replace(txt, "&#0*?205;", "Í");
            txt = Regex.Replace(txt, "&Iacute;", "Í");

            // "U+000CE", "LATIN CAPITAL LETTER I WITH CIRCUMFLEX"
            txt = Regex.Replace(txt, "&#x0*?CE;", "Î");
            txt = Regex.Replace(txt, "&#0*?206;", "Î");
            txt = Regex.Replace(txt, "&Icirc;", "Î");

            // "U+000CF", "LATIN CAPITAL LETTER I WITH DIAERESIS"
            txt = Regex.Replace(txt, "&#x0*?CF;", "Ï");
            txt = Regex.Replace(txt, "&#0*?207;", "Ï");
            txt = Regex.Replace(txt, "&Iuml;", "Ï");

            // "U+000D0", "LATIN CAPITAL LETTER ETH"
            txt = Regex.Replace(txt, "&#x0*?D0;", "Ð");
            txt = Regex.Replace(txt, "&#0*?208;", "Ð");
            txt = Regex.Replace(txt, "&ETH;", "Ð");

            // "U+000D1", "LATIN CAPITAL LETTER N WITH TILDE"
            txt = Regex.Replace(txt, "&#x0*?D1;", "Ñ");
            txt = Regex.Replace(txt, "&#0*?209;", "Ñ");
            txt = Regex.Replace(txt, "&Ntilde;", "Ñ");

            // "U+000D2", "LATIN CAPITAL LETTER O WITH GRAVE"
            txt = Regex.Replace(txt, "&#x0*?D2;", "Ò");
            txt = Regex.Replace(txt, "&#0*?210;", "Ò");
            txt = Regex.Replace(txt, "&Ograve;", "Ò");

            // "U+000D3", "LATIN CAPITAL LETTER O WITH ACUTE"
            txt = Regex.Replace(txt, "&#x0*?D3;", "Ó");
            txt = Regex.Replace(txt, "&#0*?211;", "Ó");
            txt = Regex.Replace(txt, "&Oacute;", "Ó");

            // "U+000D4", "LATIN CAPITAL LETTER O WITH CIRCUMFLEX"
            txt = Regex.Replace(txt, "&#x0*?D4;", "Ô");
            txt = Regex.Replace(txt, "&#0*?212;", "Ô");
            txt = Regex.Replace(txt, "&Ocirc;", "Ô");

            // "U+000D5", "LATIN CAPITAL LETTER O WITH TILDE"
            txt = Regex.Replace(txt, "&#x0*?D5;", "Õ");
            txt = Regex.Replace(txt, "&#0*?213;", "Õ");
            txt = Regex.Replace(txt, "&Otilde;", "Õ");

            // "U+000D6", "LATIN CAPITAL LETTER O WITH DIAERESIS"
            txt = Regex.Replace(txt, "&#x0*?D6;", "Ö");
            txt = Regex.Replace(txt, "&#0*?214;", "Ö");
            txt = Regex.Replace(txt, "&Ouml;", "Ö");

            // "U+000D7", "MULTIPLICATION SIGN"
            txt = Regex.Replace(txt, "&#x0*?D7;", "×");
            txt = Regex.Replace(txt, "&#0*?215;", "×");
            txt = Regex.Replace(txt, "&times;", "×");

            // "U+000D8", "LATIN CAPITAL LETTER O WITH STROKE"
            txt = Regex.Replace(txt, "&#x0*?D8;", "Ø");
            txt = Regex.Replace(txt, "&#0*?216;", "Ø");
            txt = Regex.Replace(txt, "&Oslash;", "Ø");

            // "U+000D9", "LATIN CAPITAL LETTER U WITH GRAVE"
            txt = Regex.Replace(txt, "&#x0*?D9;", "Ù");
            txt = Regex.Replace(txt, "&#0*?217;", "Ù");
            txt = Regex.Replace(txt, "&Ugrave;", "Ù");

            // "U+000DA", "LATIN CAPITAL LETTER U WITH ACUTE"
            txt = Regex.Replace(txt, "&#x0*?DA;", "Ú");
            txt = Regex.Replace(txt, "&#0*?218;", "Ú");
            txt = Regex.Replace(txt, "&Uacute;", "Ú");

            // "U+000DB", "LATIN CAPITAL LETTER U WITH CIRCUMFLEX"
            txt = Regex.Replace(txt, "&#x0*?DB;", "Û");
            txt = Regex.Replace(txt, "&#0*?219;", "Û");
            txt = Regex.Replace(txt, "&Ucirc;", "Û");

            // "U+000DC", "LATIN CAPITAL LETTER U WITH DIAERESIS"
            txt = Regex.Replace(txt, "&#x0*?DC;", "Ü");
            txt = Regex.Replace(txt, "&#0*?220;", "Ü");
            txt = Regex.Replace(txt, "&Uuml;", "Ü");

            // "U+000DD", "LATIN CAPITAL LETTER Y WITH ACUTE"
            txt = Regex.Replace(txt, "&#x0*?DD;", "Ý");
            txt = Regex.Replace(txt, "&#0*?221;", "Ý");
            txt = Regex.Replace(txt, "&Yacute;", "Ý");

            // "U+000DE", "LATIN CAPITAL LETTER THORN"
            txt = Regex.Replace(txt, "&#x0*?DE;", "Þ");
            txt = Regex.Replace(txt, "&#0*?222;", "Þ");
            txt = Regex.Replace(txt, "&THORN;", "Þ");

            // "U+000DF", "LATIN SMALL LETTER SHARP S"
            txt = Regex.Replace(txt, "&#x0*?DF;", "ß");
            txt = Regex.Replace(txt, "&#0*?223;", "ß");
            txt = Regex.Replace(txt, "&szlig;", "ß");

            // "U+000E0", "LATIN SMALL LETTER A WITH GRAVE"
            txt = Regex.Replace(txt, "&#x0*?E0;", "à");
            txt = Regex.Replace(txt, "&#0*?224;", "à");
            txt = Regex.Replace(txt, "&agrave;", "à");

            // "U+000E1", "LATIN SMALL LETTER A WITH ACUTE"
            txt = Regex.Replace(txt, "&#x0*?E1;", "á");
            txt = Regex.Replace(txt, "&#0*?225;", "á");
            txt = Regex.Replace(txt, "&aacute;", "á");

            // "U+000E2", "LATIN SMALL LETTER A WITH CIRCUMFLEX"
            txt = Regex.Replace(txt, "&#x0*?E2;", "â");
            txt = Regex.Replace(txt, "&#0*?226;", "â");
            txt = Regex.Replace(txt, "&acirc;", "â");

            // "U+000E3", "LATIN SMALL LETTER A WITH TILDE"
            txt = Regex.Replace(txt, "&#x0*?E3;", "ã");
            txt = Regex.Replace(txt, "&#0*?227;", "ã");
            txt = Regex.Replace(txt, "&atilde;", "ã");

            // "U+000E4", "LATIN SMALL LETTER A WITH DIAERESIS"
            txt = Regex.Replace(txt, "&#x0*?E4;", "ä");
            txt = Regex.Replace(txt, "&#0*?228;", "ä");
            txt = Regex.Replace(txt, "&auml;", "ä");

            // "U+000E5", "LATIN SMALL LETTER A WITH RING ABOVE"
            txt = Regex.Replace(txt, "&#x0*?E5;", "å");
            txt = Regex.Replace(txt, "&#0*?229;", "å");
            txt = Regex.Replace(txt, "&aring;", "å");

            // "U+000E6", "LATIN SMALL LETTER AE"
            txt = Regex.Replace(txt, "&#x0*?E6;", "æ");
            txt = Regex.Replace(txt, "&#0*?230;", "æ");
            txt = Regex.Replace(txt, "&aelig;", "æ");

            // "U+000E7", "LATIN SMALL LETTER C WITH CEDILLA"
            txt = Regex.Replace(txt, "&#x0*?E7;", "ç");
            txt = Regex.Replace(txt, "&#0*?231;", "ç");
            txt = Regex.Replace(txt, "&ccedil;", "ç");

            // "U+000E8", "LATIN SMALL LETTER E WITH GRAVE"
            txt = Regex.Replace(txt, "&#x0*?E8;", "è");
            txt = Regex.Replace(txt, "&#0*?232;", "è");
            txt = Regex.Replace(txt, "&egrave;", "è");

            // "U+000E9", "LATIN SMALL LETTER E WITH ACUTE"
            txt = Regex.Replace(txt, "&#x0*?E9;", "é");
            txt = Regex.Replace(txt, "&#0*?233;", "é");
            txt = Regex.Replace(txt, "&eacute;", "é");

            // "U+000EA", "LATIN SMALL LETTER E WITH CIRCUMFLEX"
            txt = Regex.Replace(txt, "&#x0*?EA;", "ê");
            txt = Regex.Replace(txt, "&#0*?234;", "ê");
            txt = Regex.Replace(txt, "&ecirc;", "ê");

            // "U+000EB", "LATIN SMALL LETTER E WITH DIAERESIS"
            txt = Regex.Replace(txt, "&#x0*?EB;", "ë");
            txt = Regex.Replace(txt, "&#0*?235;", "ë");
            txt = Regex.Replace(txt, "&euml;", "ë");

            // "U+000EC", "LATIN SMALL LETTER I WITH GRAVE"
            txt = Regex.Replace(txt, "&#x0*?EC;", "ì");
            txt = Regex.Replace(txt, "&#0*?236;", "ì");
            txt = Regex.Replace(txt, "&igrave;", "ì");

            // "U+000ED", "LATIN SMALL LETTER I WITH ACUTE"
            txt = Regex.Replace(txt, "&#x0*?ED;", "í");
            txt = Regex.Replace(txt, "&#0*?237;", "í");
            txt = Regex.Replace(txt, "&iacute;", "í");

            // "U+000EE", "LATIN SMALL LETTER I WITH CIRCUMFLEX"
            txt = Regex.Replace(txt, "&#x0*?EE;", "î");
            txt = Regex.Replace(txt, "&#0*?238;", "î");
            txt = Regex.Replace(txt, "&icirc;", "î");

            // "U+000EF", "LATIN SMALL LETTER I WITH DIAERESIS"
            txt = Regex.Replace(txt, "&#x0*?EF;", "ï");
            txt = Regex.Replace(txt, "&#0*?239;", "ï");
            txt = Regex.Replace(txt, "&iuml;", "ï");

            // "U+000F0", "LATIN SMALL LETTER ETH"
            txt = Regex.Replace(txt, "&#x0*?F0;", "ð");
            txt = Regex.Replace(txt, "&#0*?240;", "ð");
            txt = Regex.Replace(txt, "&eth;", "ð");

            // "U+000F1", "LATIN SMALL LETTER N WITH TILDE"
            txt = Regex.Replace(txt, "&#x0*?F1;", "ñ");
            txt = Regex.Replace(txt, "&#0*?241;", "ñ");
            txt = Regex.Replace(txt, "&ntilde;", "ñ");

            // "U+000F2", "LATIN SMALL LETTER O WITH GRAVE"
            txt = Regex.Replace(txt, "&#x0*?F2;", "ò");
            txt = Regex.Replace(txt, "&#0*?242;", "ò");
            txt = Regex.Replace(txt, "&ograve;", "ò");

            // "U+000F3", "LATIN SMALL LETTER O WITH ACUTE"
            txt = Regex.Replace(txt, "&#x0*?F3;", "ó");
            txt = Regex.Replace(txt, "&#0*?243;", "ó");
            txt = Regex.Replace(txt, "&oacute;", "ó");

            // "U+000F4", "LATIN SMALL LETTER O WITH CIRCUMFLEX"
            txt = Regex.Replace(txt, "&#x0*?F4;", "ô");
            txt = Regex.Replace(txt, "&#0*?244;", "ô");
            txt = Regex.Replace(txt, "&ocirc;", "ô");

            // "U+000F5", "LATIN SMALL LETTER O WITH TILDE"
            txt = Regex.Replace(txt, "&#x0*?F5;", "õ");
            txt = Regex.Replace(txt, "&#0*?245;", "õ");
            txt = Regex.Replace(txt, "&otilde;", "õ");

            // "U+000F6", "LATIN SMALL LETTER O WITH DIAERESIS"
            txt = Regex.Replace(txt, "&#x0*?F6;", "ö");
            txt = Regex.Replace(txt, "&#0*?246;", "ö");
            txt = Regex.Replace(txt, "&ouml;", "ö");

            // "U+000F7", "DIVISION SIGN"
            txt = Regex.Replace(txt, "&#x0*?F7;", "÷");
            txt = Regex.Replace(txt, "&#0*?247;", "÷");
            txt = Regex.Replace(txt, "&divide;", "÷");
            txt = Regex.Replace(txt, "&div;", "÷");

            // "U+000F8", "LATIN SMALL LETTER O WITH STROKE"
            txt = Regex.Replace(txt, "&#x0*?F8;", "ø");
            txt = Regex.Replace(txt, "&#0*?248;", "ø");
            txt = Regex.Replace(txt, "&oslash;", "ø");

            // "U+000F9", "LATIN SMALL LETTER U WITH GRAVE"
            txt = Regex.Replace(txt, "&#x0*?F9;", "ù");
            txt = Regex.Replace(txt, "&#0*?249;", "ù");
            txt = Regex.Replace(txt, "&ugrave;", "ù");

            // "U+000FA", "LATIN SMALL LETTER U WITH ACUTE"
            txt = Regex.Replace(txt, "&#x0*?FA;", "ú");
            txt = Regex.Replace(txt, "&#0*?250;", "ú");
            txt = Regex.Replace(txt, "&uacute;", "ú");

            // "U+000FB", "LATIN SMALL LETTER U WITH CIRCUMFLEX"
            txt = Regex.Replace(txt, "&#x0*?FB;", "û");
            txt = Regex.Replace(txt, "&#0*?251;", "û");
            txt = Regex.Replace(txt, "&ucirc;", "û");

            // "U+000FC", "LATIN SMALL LETTER U WITH DIAERESIS"
            txt = Regex.Replace(txt, "&#x0*?FC;", "ü");
            txt = Regex.Replace(txt, "&#0*?252;", "ü");
            txt = Regex.Replace(txt, "&uuml;", "ü");

            // "U+000FD", "LATIN SMALL LETTER Y WITH ACUTE"
            txt = Regex.Replace(txt, "&#x0*?FD;", "ý");
            txt = Regex.Replace(txt, "&#0*?253;", "ý");
            txt = Regex.Replace(txt, "&yacute;", "ý");

            // "U+000FE", "LATIN SMALL LETTER THORN"
            txt = Regex.Replace(txt, "&#x0*?FE;", "þ");
            txt = Regex.Replace(txt, "&#0*?254;", "þ");
            txt = Regex.Replace(txt, "&thorn;", "þ");

            // "U+000FF", "LATIN SMALL LETTER Y WITH DIAERESIS"
            txt = Regex.Replace(txt, "&#x0*?FF;", "ÿ");
            txt = Regex.Replace(txt, "&#0*?255;", "ÿ");
            txt = Regex.Replace(txt, "&yuml;", "ÿ");

            // "U+00152", "LATIN CAPITAL LIGATURE OE"
            txt = Regex.Replace(txt, "&#x0*?152;", "Œ");
            txt = Regex.Replace(txt, "&#0*?338;", "Œ");
            txt = Regex.Replace(txt, "&OElig;", "Œ");

            // "U+00153", "LATIN SMALL LIGATURE OE"
            txt = Regex.Replace(txt, "&#x0*?153;", "œ");
            txt = Regex.Replace(txt, "&#0*?339;", "œ");
            txt = Regex.Replace(txt, "&oelig;", "œ");

            // "U+00160", "LATIN CAPITAL LETTER S WITH CARON"
            txt = Regex.Replace(txt, "&#x0*?160;", "Š");
            txt = Regex.Replace(txt, "&#0*?352;", "Š");
            txt = Regex.Replace(txt, "&Scaron;", "Š");

            // "U+00161", "LATIN SMALL LETTER S WITH CARON"
            txt = Regex.Replace(txt, "&#x0*?161;", "š");
            txt = Regex.Replace(txt, "&#0*?353;", "š");
            txt = Regex.Replace(txt, "&scaron;", "š");

            // "U+00178", "LATIN CAPITAL LETTER Y WITH DIAERESIS"
            txt = Regex.Replace(txt, "&#x0*?178;", "Ÿ");
            txt = Regex.Replace(txt, "&#0*?376;", "Ÿ");
            txt = Regex.Replace(txt, "&Yuml;", "Ÿ");

            // "U+00192", "LATIN SMALL LETTER F WITH HOOK"
            txt = Regex.Replace(txt, "&#x0*?192;", "ƒ");
            txt = Regex.Replace(txt, "&#0*?402;", "ƒ");
            txt = Regex.Replace(txt, "&fnof;", "ƒ");

            // "U+002C6", "MODIFIER LETTER CIRCUMFLEX ACCENT"
            txt = Regex.Replace(txt, "&#x0*?2C6;", "ˆ");
            txt = Regex.Replace(txt, "&#0*?710;", "ˆ");
            txt = Regex.Replace(txt, "&circ;", "ˆ");

            // "U+002DC", "SMALL TILDE"
            txt = Regex.Replace(txt, "&#x0*?2DC;", "˜");
            txt = Regex.Replace(txt, "&#0*?732;", "˜");
            txt = Regex.Replace(txt, "&tilde;", "˜");
            txt = Regex.Replace(txt, "&DiacriticalTilde;", "˜");

            // "U+00391", "GREEK CAPITAL LETTER ALPHA"
            txt = Regex.Replace(txt, "&#x0*?391;", "Α");
            txt = Regex.Replace(txt, "&#0*?913;", "Α");
            txt = Regex.Replace(txt, "&Alpha;", "Α");

            // "U+00392", "GREEK CAPITAL LETTER BETA"
            txt = Regex.Replace(txt, "&#x0*?392;", "Β");
            txt = Regex.Replace(txt, "&#0*?914;", "Β");
            txt = Regex.Replace(txt, "&Beta;", "Β");

            // "U+00393", "GREEK CAPITAL LETTER GAMMA"
            txt = Regex.Replace(txt, "&#x0*?393;", "Γ");
            txt = Regex.Replace(txt, "&#0*?915;", "Γ");
            txt = Regex.Replace(txt, "&Gamma;", "Γ");

            // "U+00394", "GREEK CAPITAL LETTER DELTA"
            txt = Regex.Replace(txt, "&#x0*?394;", "Δ");
            txt = Regex.Replace(txt, "&#0*?916;", "Δ");
            txt = Regex.Replace(txt, "&Delta;", "Δ");

            // "U+00395", "GREEK CAPITAL LETTER EPSILON"
            txt = Regex.Replace(txt, "&#x0*?395;", "Ε");
            txt = Regex.Replace(txt, "&#0*?917;", "Ε");
            txt = Regex.Replace(txt, "&Epsilon;", "Ε");

            // "U+00396", "GREEK CAPITAL LETTER ZETA"
            txt = Regex.Replace(txt, "&#x0*?396;", "Ζ");
            txt = Regex.Replace(txt, "&#0*?918;", "Ζ");
            txt = Regex.Replace(txt, "&Zeta;", "Ζ");

            // "U+00397", "GREEK CAPITAL LETTER ETA"
            txt = Regex.Replace(txt, "&#x0*?397;", "Η");
            txt = Regex.Replace(txt, "&#0*?919;", "Η");
            txt = Regex.Replace(txt, "&Eta;", "Η");

            // "U+00398", "GREEK CAPITAL LETTER THETA"
            txt = Regex.Replace(txt, "&#x0*?398;", "Θ");
            txt = Regex.Replace(txt, "&#0*?920;", "Θ");
            txt = Regex.Replace(txt, "&Theta;", "Θ");

            // "U+00399", "GREEK CAPITAL LETTER IOTA"
            txt = Regex.Replace(txt, "&#x0*?399;", "Ι");
            txt = Regex.Replace(txt, "&#0*?921;", "Ι");
            txt = Regex.Replace(txt, "&Iota;", "Ι");

            // "U+0039A", "GREEK CAPITAL LETTER KAPPA"
            txt = Regex.Replace(txt, "&#x0*?39A;", "Κ");
            txt = Regex.Replace(txt, "&#0*?922;", "Κ");
            txt = Regex.Replace(txt, "&Kappa;", "Κ");

            // "U+0039B", "GREEK CAPITAL LETTER LAMDA"
            txt = Regex.Replace(txt, "&#x0*?39B;", "Λ");
            txt = Regex.Replace(txt, "&#0*?923;", "Λ");
            txt = Regex.Replace(txt, "&Lambda;", "Λ");

            // "U+0039C", "GREEK CAPITAL LETTER MU"
            txt = Regex.Replace(txt, "&#x0*?39C;", "Μ");
            txt = Regex.Replace(txt, "&#0*?924;", "Μ");
            txt = Regex.Replace(txt, "&Mu;", "Μ");

            // "U+0039D", "GREEK CAPITAL LETTER NU"
            txt = Regex.Replace(txt, "&#x0*?39D;", "Ν");
            txt = Regex.Replace(txt, "&#0*?925;", "Ν");
            txt = Regex.Replace(txt, "&Nu;", "Ν");

            // "U+0039E", "GREEK CAPITAL LETTER XI"
            txt = Regex.Replace(txt, "&#x0*?39E;", "Ξ");
            txt = Regex.Replace(txt, "&#0*?926;", "Ξ");
            txt = Regex.Replace(txt, "&Xi;", "Ξ");

            // "U+0039F", "GREEK CAPITAL LETTER OMICRON"
            txt = Regex.Replace(txt, "&#x0*?39F;", "Ο");
            txt = Regex.Replace(txt, "&#0*?927;", "Ο");
            txt = Regex.Replace(txt, "&Omicron;", "Ο");

            // "U+003A0", "GREEK CAPITAL LETTER PI"
            txt = Regex.Replace(txt, "&#x0*?3A0;", "Π");
            txt = Regex.Replace(txt, "&#0*?928;", "Π");
            txt = Regex.Replace(txt, "&Pi;", "Π");

            // "U+003A1", "GREEK CAPITAL LETTER RHO"
            txt = Regex.Replace(txt, "&#x0*?3A1;", "Ρ");
            txt = Regex.Replace(txt, "&#0*?929;", "Ρ");
            txt = Regex.Replace(txt, "&Rho;", "Ρ");

            // "U+003A3", "GREEK CAPITAL LETTER SIGMA"
            txt = Regex.Replace(txt, "&#x0*?3A3;", "Σ");
            txt = Regex.Replace(txt, "&#0*?931;", "Σ");
            txt = Regex.Replace(txt, "&Sigma;", "Σ");

            // "U+003A4", "GREEK CAPITAL LETTER TAU"
            txt = Regex.Replace(txt, "&#x0*?3A4;", "Τ");
            txt = Regex.Replace(txt, "&#0*?932;", "Τ");
            txt = Regex.Replace(txt, "&Tau;", "Τ");

            // "U+003A5", "GREEK CAPITAL LETTER UPSILON"
            txt = Regex.Replace(txt, "&#x0*?3A5;", "Υ");
            txt = Regex.Replace(txt, "&#0*?933;", "Υ");
            txt = Regex.Replace(txt, "&Upsilon;", "Υ");

            // "U+003A6", "GREEK CAPITAL LETTER PHI"
            txt = Regex.Replace(txt, "&#x0*?3A6;", "Φ");
            txt = Regex.Replace(txt, "&#0*?934;", "Φ");
            txt = Regex.Replace(txt, "&Phi;", "Φ");

            // "U+003A7", "GREEK CAPITAL LETTER CHI"
            txt = Regex.Replace(txt, "&#x0*?3A7;", "Χ");
            txt = Regex.Replace(txt, "&#0*?935;", "Χ");
            txt = Regex.Replace(txt, "&Chi;", "Χ");

            // "U+003A8", "GREEK CAPITAL LETTER PSI"
            txt = Regex.Replace(txt, "&#x0*?3A8;", "Ψ");
            txt = Regex.Replace(txt, "&#0*?936;", "Ψ");
            txt = Regex.Replace(txt, "&Psi;", "Ψ");

            // "U+003A9", "GREEK CAPITAL LETTER OMEGA"
            txt = Regex.Replace(txt, "&#x0*?3A9;", "Ω");
            txt = Regex.Replace(txt, "&#0*?937;", "Ω");
            txt = Regex.Replace(txt, "&Omega;", "Ω");

            // "U+003B1", "GREEK SMALL LETTER ALPHA"
            txt = Regex.Replace(txt, "&#x0*?3B1;", "α");
            txt = Regex.Replace(txt, "&#0*?945;", "α");
            txt = Regex.Replace(txt, "&alpha;", "α");

            // "U+003B2", "GREEK SMALL LETTER BETA"
            txt = Regex.Replace(txt, "&#x0*?3B2;", "β");
            txt = Regex.Replace(txt, "&#0*?946;", "β");
            txt = Regex.Replace(txt, "&beta;", "β");

            // "U+003B3", "GREEK SMALL LETTER GAMMA"
            txt = Regex.Replace(txt, "&#x0*?3B3;", "γ");
            txt = Regex.Replace(txt, "&#0*?947;", "γ");
            txt = Regex.Replace(txt, "&gamma;", "γ");

            // "U+003B4", "GREEK SMALL LETTER DELTA"
            txt = Regex.Replace(txt, "&#x0*?3B4;", "δ");
            txt = Regex.Replace(txt, "&#0*?948;", "δ");
            txt = Regex.Replace(txt, "&delta;", "δ");

            // "U+003B5", "GREEK SMALL LETTER EPSILON"
            txt = Regex.Replace(txt, "&#x0*?3B5;", "ε");
            txt = Regex.Replace(txt, "&#0*?949;", "ε");
            txt = Regex.Replace(txt, "&epsiv;", "ε");
            txt = Regex.Replace(txt, "&varepsilon;", "ε");
            txt = Regex.Replace(txt, "&epsilon;", "ε");

            // "U+003B6", "GREEK SMALL LETTER ZETA"
            txt = Regex.Replace(txt, "&#x0*?3B6;", "ζ");
            txt = Regex.Replace(txt, "&#0*?950;", "ζ");
            txt = Regex.Replace(txt, "&zeta;", "ζ");

            // "U+003B7", "GREEK SMALL LETTER ETA"
            txt = Regex.Replace(txt, "&#x0*?3B7;", "η");
            txt = Regex.Replace(txt, "&#0*?951;", "η");
            txt = Regex.Replace(txt, "&eta;", "η");

            // "U+003B8", "GREEK SMALL LETTER THETA"
            txt = Regex.Replace(txt, "&#x0*?3B8;", "θ");
            txt = Regex.Replace(txt, "&#0*?952;", "θ");
            txt = Regex.Replace(txt, "&theta;", "θ");

            // "U+003B9", "GREEK SMALL LETTER IOTA"
            txt = Regex.Replace(txt, "&#x0*?3B9;", "ι");
            txt = Regex.Replace(txt, "&#0*?953;", "ι");
            txt = Regex.Replace(txt, "&iota;", "ι");

            // "U+003BA", "GREEK SMALL LETTER KAPPA"
            txt = Regex.Replace(txt, "&#x0*?3BA;", "κ");
            txt = Regex.Replace(txt, "&#0*?954;", "κ");
            txt = Regex.Replace(txt, "&kappa;", "κ");

            // "U+003BB", "GREEK SMALL LETTER LAMDA"
            txt = Regex.Replace(txt, "&#x0*?3BB;", "λ");
            txt = Regex.Replace(txt, "&#0*?955;", "λ");
            txt = Regex.Replace(txt, "&lambda;", "λ");

            // "U+003BC", "GREEK SMALL LETTER MU"
            txt = Regex.Replace(txt, "&#x0*?3BC;", "μ");
            txt = Regex.Replace(txt, "&#0*?956;", "μ");
            txt = Regex.Replace(txt, "&mu;", "μ");

            // "U+003BD", "GREEK SMALL LETTER NU"
            txt = Regex.Replace(txt, "&#x0*?3BD;", "ν");
            txt = Regex.Replace(txt, "&#0*?957;", "ν");
            txt = Regex.Replace(txt, "&nu;", "ν");

            // "U+003BE", "GREEK SMALL LETTER XI"
            txt = Regex.Replace(txt, "&#x0*?3BE;", "ξ");
            txt = Regex.Replace(txt, "&#0*?958;", "ξ");
            txt = Regex.Replace(txt, "&xi;", "ξ");

            // "U+003BF", "GREEK SMALL LETTER OMICRON"
            txt = Regex.Replace(txt, "&#x0*?3BF;", "ο");
            txt = Regex.Replace(txt, "&#0*?959;", "ο");
            txt = Regex.Replace(txt, "&omicron;", "ο");

            // "U+003C0", "GREEK SMALL LETTER PI"
            txt = Regex.Replace(txt, "&#x0*?3C0;", "π");
            txt = Regex.Replace(txt, "&#0*?960;", "π");
            txt = Regex.Replace(txt, "&pi;", "π");

            // "U+003C1", "GREEK SMALL LETTER RHO"
            txt = Regex.Replace(txt, "&#x0*?3C1;", "ρ");
            txt = Regex.Replace(txt, "&#0*?961;", "ρ");
            txt = Regex.Replace(txt, "&rho;", "ρ");

            // "U+003C2", "GREEK SMALL LETTER FINAL SIGMA"
            txt = Regex.Replace(txt, "&#x0*?3C2;", "ς");
            txt = Regex.Replace(txt, "&#0*?962;", "ς");
            txt = Regex.Replace(txt, "&sigmav;", "ς");
            txt = Regex.Replace(txt, "&varsigma;", "ς");
            txt = Regex.Replace(txt, "&sigmaf;", "ς");

            // "U+003C3", "GREEK SMALL LETTER SIGMA"
            txt = Regex.Replace(txt, "&#x0*?3C3;", "σ");
            txt = Regex.Replace(txt, "&#0*?963;", "σ");
            txt = Regex.Replace(txt, "&sigma;", "σ");

            // "U+003C4", "GREEK SMALL LETTER TAU"
            txt = Regex.Replace(txt, "&#x0*?3C4;", "τ");
            txt = Regex.Replace(txt, "&#0*?964;", "τ");
            txt = Regex.Replace(txt, "&tau;", "τ");

            // "U+003C5", "GREEK SMALL LETTER UPSILON"
            txt = Regex.Replace(txt, "&#x0*?3C5;", "υ");
            txt = Regex.Replace(txt, "&#0*?965;", "υ");
            txt = Regex.Replace(txt, "&upsi;", "υ");
            txt = Regex.Replace(txt, "&upsilon;", "υ");

            // "U+003C6", "GREEK SMALL LETTER PHI"
            txt = Regex.Replace(txt, "&#x0*?3C6;", "φ");
            txt = Regex.Replace(txt, "&#0*?966;", "φ");
            txt = Regex.Replace(txt, "&phi;", "φ");
            txt = Regex.Replace(txt, "&phiv;", "φ");
            txt = Regex.Replace(txt, "&varphi;", "φ");

            // "U+003C7", "GREEK SMALL LETTER CHI"
            txt = Regex.Replace(txt, "&#x0*?3C7;", "χ");
            txt = Regex.Replace(txt, "&#0*?967;", "χ");
            txt = Regex.Replace(txt, "&chi;", "χ");

            // "U+003C8", "GREEK SMALL LETTER PSI"
            txt = Regex.Replace(txt, "&#x0*?3C8;", "ψ");
            txt = Regex.Replace(txt, "&#0*?968;", "ψ");
            txt = Regex.Replace(txt, "&psi;", "ψ");

            // "U+003C9", "GREEK SMALL LETTER OMEGA"
            txt = Regex.Replace(txt, "&#x0*?3C9;", "ω");
            txt = Regex.Replace(txt, "&#0*?969;", "ω");
            txt = Regex.Replace(txt, "&omega;", "ω");

            // "U+003D1", "GREEK THETA SYMBOL"
            txt = Regex.Replace(txt, "&#x0*?3D1;", "ϑ");
            txt = Regex.Replace(txt, "&#0*?977;", "ϑ");
            txt = Regex.Replace(txt, "&thetav;", "ϑ");
            txt = Regex.Replace(txt, "&vartheta;", "ϑ");
            txt = Regex.Replace(txt, "&thetasym;", "ϑ");

            // "U+003D2", "GREEK UPSILON WITH HOOK SYMBOL"
            txt = Regex.Replace(txt, "&#x0*?3D2;", "ϒ");
            txt = Regex.Replace(txt, "&#0*?978;", "ϒ");
            txt = Regex.Replace(txt, "&Upsi;", "ϒ");
            txt = Regex.Replace(txt, "&upsih;", "ϒ");

            // "U+003D6", "GREEK PI SYMBOL"
            txt = Regex.Replace(txt, "&#x0*?3D6;", "ϖ");
            txt = Regex.Replace(txt, "&#0*?982;", "ϖ");
            txt = Regex.Replace(txt, "&piv;", "ϖ");
            txt = Regex.Replace(txt, "&varpi;", "ϖ");

            // "U+02002", "EN SPACE"
            txt = Regex.Replace(txt, "&#x0*?2002;", " ");
            txt = Regex.Replace(txt, "&#0*?8194;", " ");
            txt = Regex.Replace(txt, "&ensp;", " ");

            // "U+02003", "EM SPACE"
            txt = Regex.Replace(txt, "&#x0*?2003;", " ");
            txt = Regex.Replace(txt, "&#0*?8195;", " ");
            txt = Regex.Replace(txt, "&emsp;", " ");

            // "U+02009", "THIN SPACE"
            txt = Regex.Replace(txt, "&#x0*?2009;", " ");
            txt = Regex.Replace(txt, "&#0*?8201;", " ");
            txt = Regex.Replace(txt, "&thinsp;", " ");
            txt = Regex.Replace(txt, "&ThinSpace;", " ");

            // "U+0200C", "ZERO WIDTH NON-JOINER"
            txt = Regex.Replace(txt, "&#x0*?200C;", "‌");
            txt = Regex.Replace(txt, "&#0*?8204;", "‌");
            txt = Regex.Replace(txt, "&zwnj;", "‌");

            // "U+0200D", "ZERO WIDTH JOINER"
            txt = Regex.Replace(txt, "&#x0*?200D;", "‍");
            txt = Regex.Replace(txt, "&#0*?8205;", "‍");
            txt = Regex.Replace(txt, "&zwj;", "‍");

            // "U+0200E", "LEFT-TO-RIGHT MARK"
            txt = Regex.Replace(txt, "&#x0*?200E;", "‎");
            txt = Regex.Replace(txt, "&#0*?8206;", "‎");
            txt = Regex.Replace(txt, "&lrm;", "‎");

            // "U+0200F", "RIGHT-TO-LEFT MARK"
            txt = Regex.Replace(txt, "&#x0*?200F;", "‏");
            txt = Regex.Replace(txt, "&#0*?8207;", "‏");
            txt = Regex.Replace(txt, "&rlm;", "‏");

            // "U+02013", "EN DASH"
            txt = Regex.Replace(txt, "&#x0*?2013;", "–");
            txt = Regex.Replace(txt, "&#0*?8211;", "–");
            txt = Regex.Replace(txt, "&ndash;", "–");

            // "U+02014", "EM DASH"
            txt = Regex.Replace(txt, "&#x0*?2014;", "—");
            txt = Regex.Replace(txt, "&#0*?8212;", "—");
            txt = Regex.Replace(txt, "&mdash;", "—");

            // "U+02018", "LEFT SINGLE QUOTATION MARK"
            txt = Regex.Replace(txt, "&#x0*?2018;", "‘");
            txt = Regex.Replace(txt, "&#0*?8216;", "‘");
            txt = Regex.Replace(txt, "&lsquo;", "‘");
            txt = Regex.Replace(txt, "&OpenCurlyQuote;", "‘");

            // "U+02019", "RIGHT SINGLE QUOTATION MARK"
            txt = Regex.Replace(txt, "&#x0*?2019;", "’");
            txt = Regex.Replace(txt, "&#0*?8217;", "’");
            txt = Regex.Replace(txt, "&rsquo;", "’");
            txt = Regex.Replace(txt, "&rsquor;", "’");
            txt = Regex.Replace(txt, "&CloseCurlyQuote;", "’");

            // "U+0201A", "SINGLE LOW-9 QUOTATION MARK"
            txt = Regex.Replace(txt, "&#x0*?201A;", "‚");
            txt = Regex.Replace(txt, "&#0*?8218;", "‚");
            txt = Regex.Replace(txt, "&lsquor;", "‚");
            txt = Regex.Replace(txt, "&sbquo;", "‚");

            // "U+0201C", "LEFT DOUBLE QUOTATION MARK"
            txt = Regex.Replace(txt, "&#x0*?201C;", "“");
            txt = Regex.Replace(txt, "&#0*?8220;", "“");
            txt = Regex.Replace(txt, "&ldquo;", "“");
            txt = Regex.Replace(txt, "&OpenCurlyDoubleQuote;", "“");

            // "U+0201D", "RIGHT DOUBLE QUOTATION MARK"
            txt = Regex.Replace(txt, "&#x0*?201D;", "”");
            txt = Regex.Replace(txt, "&#0*?8221;", "”");
            txt = Regex.Replace(txt, "&rdquo;", "”");
            txt = Regex.Replace(txt, "&rdquor;", "”");
            txt = Regex.Replace(txt, "&CloseCurlyDoubleQuote;", "”");

            // "U+0201E", "DOUBLE LOW-9 QUOTATION MARK"
            txt = Regex.Replace(txt, "&#x0*?201E;", "„");
            txt = Regex.Replace(txt, "&#0*?8222;", "„");
            txt = Regex.Replace(txt, "&ldquor;", "„");
            txt = Regex.Replace(txt, "&bdquo;", "„");

            // "U+02020", "DAGGER"
            txt = Regex.Replace(txt, "&#x0*?2020;", "†");
            txt = Regex.Replace(txt, "&#0*?8224;", "†");
            txt = Regex.Replace(txt, "&dagger;", "†");

            // "U+02021", "DOUBLE DAGGER"
            txt = Regex.Replace(txt, "&#x0*?2021;", "‡");
            txt = Regex.Replace(txt, "&#0*?8225;", "‡");
            txt = Regex.Replace(txt, "&Dagger;", "‡");
            txt = Regex.Replace(txt, "&ddagger;", "‡");

            // "U+02022", "BULLET"
            txt = Regex.Replace(txt, "&#x0*?2022;", "•");
            txt = Regex.Replace(txt, "&#0*?8226;", "•");
            txt = Regex.Replace(txt, "&bull;", "•");
            txt = Regex.Replace(txt, "&bullet;", "•");

            // "U+02026", "HORIZONTAL ELLIPSIS"
            txt = Regex.Replace(txt, "&#x0*?2026;", "…");
            txt = Regex.Replace(txt, "&#0*?8230;", "…");
            txt = Regex.Replace(txt, "&hellip;", "…");
            txt = Regex.Replace(txt, "&mldr;", "…");

            // "U+02030", "PER MILLE SIGN"
            txt = Regex.Replace(txt, "&#x0*?2030;", "‰");
            txt = Regex.Replace(txt, "&#0*?8240;", "‰");
            txt = Regex.Replace(txt, "&permil;", "‰");

            // "U+02032", "PRIME"
            txt = Regex.Replace(txt, "&#x0*?2032;", "′");
            txt = Regex.Replace(txt, "&#0*?8242;", "′");
            txt = Regex.Replace(txt, "&prime;", "′");

            // "U+02033", "DOUBLE PRIME"
            txt = Regex.Replace(txt, "&#x0*?2033;", "″");
            txt = Regex.Replace(txt, "&#0*?8243;", "″");
            txt = Regex.Replace(txt, "&Prime;", "″");

            // "U+02039", "SINGLE LEFT-POINTING ANGLE QUOTATION MARK"
            txt = Regex.Replace(txt, "&#x0*?2039;", "‹");
            txt = Regex.Replace(txt, "&#0*?8249;", "‹");
            txt = Regex.Replace(txt, "&lsaquo;", "‹");

            // "U+0203A", "SINGLE RIGHT-POINTING ANGLE QUOTATION MARK"
            txt = Regex.Replace(txt, "&#x0*?203A;", "›");
            txt = Regex.Replace(txt, "&#0*?8250;", "›");
            txt = Regex.Replace(txt, "&rsaquo;", "›");

            // "U+0203E", "OVERLINE"
            txt = Regex.Replace(txt, "&#x0*?203E;", "‾");
            txt = Regex.Replace(txt, "&#0*?8254;", "‾");
            txt = Regex.Replace(txt, "&oline;", "‾");

            // "U+02044", "FRACTION SLASH"
            txt = Regex.Replace(txt, "&#x0*?2044;", "⁄");
            txt = Regex.Replace(txt, "&#0*?8260;", "⁄");
            txt = Regex.Replace(txt, "&frasl;", "⁄");

            // "U+020AC", "EURO SIGN"
            txt = Regex.Replace(txt, "&#x0*?20AC;", "€");
            txt = Regex.Replace(txt, "&#0*?8364;", "€");
            txt = Regex.Replace(txt, "&euro;", "€");

            // "U+02111", "BLACK-LETTER CAPITAL I"
            txt = Regex.Replace(txt, "&#x0*?2111;", "ℑ");
            txt = Regex.Replace(txt, "&#0*?8465;", "ℑ");
            txt = Regex.Replace(txt, "&image;", "ℑ");
            txt = Regex.Replace(txt, "&Im;", "ℑ");
            txt = Regex.Replace(txt, "&imagpart;", "ℑ");
            txt = Regex.Replace(txt, "&Ifr;", "ℑ");

            // "U+02118", "SCRIPT CAPITAL P"
            txt = Regex.Replace(txt, "&#x0*?2118;", "℘");
            txt = Regex.Replace(txt, "&#0*?8472;", "℘");
            txt = Regex.Replace(txt, "&weierp;", "℘");
            txt = Regex.Replace(txt, "&wp;", "℘");

            // "U+0211C", "BLACK-LETTER CAPITAL R"
            txt = Regex.Replace(txt, "&#x0*?211C;", "ℜ");
            txt = Regex.Replace(txt, "&#0*?8476;", "ℜ");
            txt = Regex.Replace(txt, "&real;", "ℜ");
            txt = Regex.Replace(txt, "&Re;", "ℜ");
            txt = Regex.Replace(txt, "&realpart;", "ℜ");
            txt = Regex.Replace(txt, "&Rfr;", "ℜ");

            // "U+02122", "TRADE MARK SIGN"
            txt = Regex.Replace(txt, "&#x0*?2122;", "™");
            txt = Regex.Replace(txt, "&#0*?8482;", "™");
            txt = Regex.Replace(txt, "&trade;", "™");
            txt = Regex.Replace(txt, "&TRADE;", "™");

            // "U+02135", "ALEF SYMBOL"
            txt = Regex.Replace(txt, "&#x0*?2135;", "ℵ");
            txt = Regex.Replace(txt, "&#0*?8501;", "ℵ");
            txt = Regex.Replace(txt, "&alefsym;", "ℵ");
            txt = Regex.Replace(txt, "&aleph;", "ℵ");

            // "U+02190", "LEFTWARDS ARROW"
            txt = Regex.Replace(txt, "&#x0*?2190;", "←");
            txt = Regex.Replace(txt, "&#0*?8592;", "←");
            txt = Regex.Replace(txt, "&larr;", "←");
            txt = Regex.Replace(txt, "&leftarrow;", "←");
            txt = Regex.Replace(txt, "&LeftArrow;", "←");
            txt = Regex.Replace(txt, "&slarr;", "←");
            txt = Regex.Replace(txt, "&ShortLeftArrow;", "←");

            // "U+02191", "UPWARDS ARROW"
            txt = Regex.Replace(txt, "&#x0*?2191;", "↑");
            txt = Regex.Replace(txt, "&#0*?8593;", "↑");
            txt = Regex.Replace(txt, "&uarr;", "↑");
            txt = Regex.Replace(txt, "&uparrow;", "↑");
            txt = Regex.Replace(txt, "&UpArrow;", "↑");
            txt = Regex.Replace(txt, "&ShortUpArrow;", "↑");

            // "U+02192", "RIGHTWARDS ARROW"
            txt = Regex.Replace(txt, "&#x0*?2192;", "→");
            txt = Regex.Replace(txt, "&#0*?8594;", "→");
            txt = Regex.Replace(txt, "&rarr;", "→");
            txt = Regex.Replace(txt, "&rightarrow;", "→");
            txt = Regex.Replace(txt, "&RightArrow;", "→");
            txt = Regex.Replace(txt, "&srarr;", "→");
            txt = Regex.Replace(txt, "&ShortRightArrow;", "→");

            // "U+02193", "DOWNWARDS ARROW"
            txt = Regex.Replace(txt, "&#x0*?2193;", "↓");
            txt = Regex.Replace(txt, "&#0*?8595;", "↓");
            txt = Regex.Replace(txt, "&darr;", "↓");
            txt = Regex.Replace(txt, "&downarrow;", "↓");
            txt = Regex.Replace(txt, "&DownArrow;", "↓");
            txt = Regex.Replace(txt, "&ShortDownArrow;", "↓");

            // "U+02194", "LEFT RIGHT ARROW"
            txt = Regex.Replace(txt, "&#x0*?2194;", "↔");
            txt = Regex.Replace(txt, "&#0*?8596;", "↔");
            txt = Regex.Replace(txt, "&harr;", "↔");
            txt = Regex.Replace(txt, "&leftrightarrow;", "↔");
            txt = Regex.Replace(txt, "&LeftRightArrow;", "↔");

            // "U+021B5", "DOWNWARDS ARROW WITH CORNER LEFTWARDS"
            txt = Regex.Replace(txt, "&#x0*?21B5;", "↵");
            txt = Regex.Replace(txt, "&#0*?8629;", "↵");
            txt = Regex.Replace(txt, "&crarr;", "↵");

            // "U+021D0", "LEFTWARDS DOUBLE ARROW"
            txt = Regex.Replace(txt, "&#x0*?21D0;", "⇐");
            txt = Regex.Replace(txt, "&#0*?8656;", "⇐");
            txt = Regex.Replace(txt, "&lArr;", "⇐");
            txt = Regex.Replace(txt, "&Leftarrow;", "⇐");
            txt = Regex.Replace(txt, "&DoubleLeftArrow;", "⇐");

            // "U+021D1", "UPWARDS DOUBLE ARROW"
            txt = Regex.Replace(txt, "&#x0*?21D1;", "⇑");
            txt = Regex.Replace(txt, "&#0*?8657;", "⇑");
            txt = Regex.Replace(txt, "&uArr;", "⇑");
            txt = Regex.Replace(txt, "&Uparrow;", "⇑");
            txt = Regex.Replace(txt, "&DoubleUpArrow;", "⇑");

            // "U+021D2", "RIGHTWARDS DOUBLE ARROW"
            txt = Regex.Replace(txt, "&#x0*?21D2;", "⇒");
            txt = Regex.Replace(txt, "&#0*?8658;", "⇒");
            txt = Regex.Replace(txt, "&rArr;", "⇒");
            txt = Regex.Replace(txt, "&Rightarrow;", "⇒");
            txt = Regex.Replace(txt, "&Implies;", "⇒");
            txt = Regex.Replace(txt, "&DoubleRightArrow;", "⇒");

            // "U+021D3", "DOWNWARDS DOUBLE ARROW"
            txt = Regex.Replace(txt, "&#x0*?21D3;", "⇓");
            txt = Regex.Replace(txt, "&#0*?8659;", "⇓");
            txt = Regex.Replace(txt, "&dArr;", "⇓");
            txt = Regex.Replace(txt, "&Downarrow;", "⇓");
            txt = Regex.Replace(txt, "&DoubleDownArrow;", "⇓");

            // "U+021D4", "LEFT RIGHT DOUBLE ARROW"
            txt = Regex.Replace(txt, "&#x0*?21D4;", "⇔");
            txt = Regex.Replace(txt, "&#0*?8660;", "⇔");
            txt = Regex.Replace(txt, "&hArr;", "⇔");
            txt = Regex.Replace(txt, "&Leftrightarrow;", "⇔");
            txt = Regex.Replace(txt, "&DoubleLeftRightArrow;", "⇔");
            txt = Regex.Replace(txt, "&iff;", "⇔");

            // "U+02200", "FOR ALL"
            txt = Regex.Replace(txt, "&#x0*?2200;", "∀");
            txt = Regex.Replace(txt, "&#0*?8704;", "∀");
            txt = Regex.Replace(txt, "&forall;", "∀");
            txt = Regex.Replace(txt, "&ForAll;", "∀");

            // "U+02202", "PARTIAL DIFFERENTIAL"
            txt = Regex.Replace(txt, "&#x0*?2202;", "∂");
            txt = Regex.Replace(txt, "&#0*?8706;", "∂");
            txt = Regex.Replace(txt, "&part;", "∂");
            txt = Regex.Replace(txt, "&PartialD;", "∂");

            // "U+02203", "THERE EXISTS"
            txt = Regex.Replace(txt, "&#x0*?2203;", "∃");
            txt = Regex.Replace(txt, "&#0*?8707;", "∃");
            txt = Regex.Replace(txt, "&exist;", "∃");
            txt = Regex.Replace(txt, "&Exists;", "∃");

            // "U+02205", "EMPTY SET"
            txt = Regex.Replace(txt, "&#x0*?2205;", "∅");
            txt = Regex.Replace(txt, "&#0*?8709;", "∅");
            txt = Regex.Replace(txt, "&empty;", "∅");
            txt = Regex.Replace(txt, "&emptyset;", "∅");
            txt = Regex.Replace(txt, "&emptyv;", "∅");
            txt = Regex.Replace(txt, "&varnothing;", "∅");

            // "U+02207", "NABLA"
            txt = Regex.Replace(txt, "&#x0*?2207;", "∇");
            txt = Regex.Replace(txt, "&#0*?8711;", "∇");
            txt = Regex.Replace(txt, "&nabla;", "∇");
            txt = Regex.Replace(txt, "&Del;", "∇");

            // "U+02208", "ELEMENT OF"
            txt = Regex.Replace(txt, "&#x0*?2208;", "∈");
            txt = Regex.Replace(txt, "&#0*?8712;", "∈");
            txt = Regex.Replace(txt, "&isin;", "∈");
            txt = Regex.Replace(txt, "&isinv;", "∈");
            txt = Regex.Replace(txt, "&Element;", "∈");
            txt = Regex.Replace(txt, "&in;", "∈");

            // "U+02209", "NOT AN ELEMENT OF"
            txt = Regex.Replace(txt, "&#x0*?2209;", "∉");
            txt = Regex.Replace(txt, "&#0*?8713;", "∉");
            txt = Regex.Replace(txt, "&notin;", "∉");
            txt = Regex.Replace(txt, "&NotElement;", "∉");
            txt = Regex.Replace(txt, "&notinva;", "∉");

            // "U+0220B", "CONTAINS AS MEMBER"
            txt = Regex.Replace(txt, "&#x0*?220B;", "∋");
            txt = Regex.Replace(txt, "&#0*?8715;", "∋");
            txt = Regex.Replace(txt, "&niv;", "∋");
            txt = Regex.Replace(txt, "&ReverseElement;", "∋");
            txt = Regex.Replace(txt, "&ni;", "∋");
            txt = Regex.Replace(txt, "&SuchThat;", "∋");

            // "U+0220F", "N-ARY PRODUCT"
            txt = Regex.Replace(txt, "&#x0*?220F;", "∏");
            txt = Regex.Replace(txt, "&#0*?8719;", "∏");
            txt = Regex.Replace(txt, "&prod;", "∏");
            txt = Regex.Replace(txt, "&Product;", "∏");

            // "U+02211", "N-ARY SUMMATION"
            txt = Regex.Replace(txt, "&#x0*?2211;", "∑");
            txt = Regex.Replace(txt, "&#0*?8721;", "∑");
            txt = Regex.Replace(txt, "&sum;", "∑");
            txt = Regex.Replace(txt, "&Sum;", "∑");

            // "U+02212", "MINUS SIGN"
            txt = Regex.Replace(txt, "&#x0*?2212;", "−");
            txt = Regex.Replace(txt, "&#0*?8722;", "−");
            txt = Regex.Replace(txt, "&minus;", "−");

            // "U+02217", "ASTERISK OPERATOR"
            txt = Regex.Replace(txt, "&#x0*?2217;", "∗");
            txt = Regex.Replace(txt, "&#0*?8727;", "∗");
            txt = Regex.Replace(txt, "&lowast;", "∗");

            // "U+0221A", "SQUARE ROOT"
            txt = Regex.Replace(txt, "&#x0*?221A;", "√");
            txt = Regex.Replace(txt, "&#0*?8730;", "√");
            txt = Regex.Replace(txt, "&radic;", "√");
            txt = Regex.Replace(txt, "&Sqrt;", "√");

            // "U+0221D", "PROPORTIONAL TO"
            txt = Regex.Replace(txt, "&#x0*?221D;", "∝");
            txt = Regex.Replace(txt, "&#0*?8733;", "∝");
            txt = Regex.Replace(txt, "&prop;", "∝");
            txt = Regex.Replace(txt, "&propto;", "∝");
            txt = Regex.Replace(txt, "&Proportional;", "∝");
            txt = Regex.Replace(txt, "&vprop;", "∝");
            txt = Regex.Replace(txt, "&varpropto;", "∝");

            // "U+0221E", "INFINITY"
            txt = Regex.Replace(txt, "&#x0*?221E;", "∞");
            txt = Regex.Replace(txt, "&#0*?8734;", "∞");
            txt = Regex.Replace(txt, "&infin;", "∞");

            // "U+02220", "ANGLE"
            txt = Regex.Replace(txt, "&#x0*?2220;", "∠");
            txt = Regex.Replace(txt, "&#0*?8736;", "∠");
            txt = Regex.Replace(txt, "&ang;", "∠");
            txt = Regex.Replace(txt, "&angle;", "∠");

            // "U+02227", "LOGICAL AND"
            txt = Regex.Replace(txt, "&#x0*?2227;", "∧");
            txt = Regex.Replace(txt, "&#0*?8743;", "∧");
            txt = Regex.Replace(txt, "&and;", "∧");
            txt = Regex.Replace(txt, "&wedge;", "∧");

            // "U+02228", "LOGICAL OR"
            txt = Regex.Replace(txt, "&#x0*?2228;", "∨");
            txt = Regex.Replace(txt, "&#0*?8744;", "∨");
            txt = Regex.Replace(txt, "&or;", "∨");
            txt = Regex.Replace(txt, "&vee;", "∨");

            // "U+02229", "INTERSECTION"
            txt = Regex.Replace(txt, "&#x0*?2229;", "∩");
            txt = Regex.Replace(txt, "&#0*?8745;", "∩");
            txt = Regex.Replace(txt, "&cap;", "∩");

            // "U+0222A", "UNION"
            txt = Regex.Replace(txt, "&#x0*?222A;", "∪");
            txt = Regex.Replace(txt, "&#0*?8746;", "∪");
            txt = Regex.Replace(txt, "&cup;", "∪");

            // "U+0222B", "INTEGRAL"
            txt = Regex.Replace(txt, "&#x0*?222B;", "∫");
            txt = Regex.Replace(txt, "&#0*?8747;", "∫");
            txt = Regex.Replace(txt, "&int;", "∫");
            txt = Regex.Replace(txt, "&Integral;", "∫");

            // "U+02234", "THEREFORE"
            txt = Regex.Replace(txt, "&#x0*?2234;", "∴");
            txt = Regex.Replace(txt, "&#0*?8756;", "∴");
            txt = Regex.Replace(txt, "&there4;", "∴");
            txt = Regex.Replace(txt, "&therefore;", "∴");
            txt = Regex.Replace(txt, "&Therefore;", "∴");

            // "U+0223C", "TILDE OPERATOR"
            txt = Regex.Replace(txt, "&#x0*?223C;", "∼");
            txt = Regex.Replace(txt, "&#0*?8764;", "∼");
            txt = Regex.Replace(txt, "&sim;", "∼");
            txt = Regex.Replace(txt, "&Tilde;", "∼");
            txt = Regex.Replace(txt, "&thksim;", "∼");
            txt = Regex.Replace(txt, "&thicksim;", "∼");

            // "U+02245", "APPROXIMATELY EQUAL TO"
            txt = Regex.Replace(txt, "&#x0*?2245;", "≅");
            txt = Regex.Replace(txt, "&#0*?8773;", "≅");
            txt = Regex.Replace(txt, "&cong;", "≅");
            txt = Regex.Replace(txt, "&TildeFullEqual;", "≅");

            // "U+02248", "ALMOST EQUAL TO"
            txt = Regex.Replace(txt, "&#x0*?2248;", "≈");
            txt = Regex.Replace(txt, "&#0*?8776;", "≈");
            txt = Regex.Replace(txt, "&asymp;", "≈");
            txt = Regex.Replace(txt, "&ap;", "≈");
            txt = Regex.Replace(txt, "&TildeTilde;", "≈");
            txt = Regex.Replace(txt, "&approx;", "≈");
            txt = Regex.Replace(txt, "&thkap;", "≈");
            txt = Regex.Replace(txt, "&thickapprox;", "≈");

            // "U+02260", "NOT EQUAL TO"
            txt = Regex.Replace(txt, "&#x0*?2260;", "≠");
            txt = Regex.Replace(txt, "&#0*?8800;", "≠");
            txt = Regex.Replace(txt, "&ne;", "≠");
            txt = Regex.Replace(txt, "&NotEqual;", "≠");

            // "U+02261", "IDENTICAL TO"
            txt = Regex.Replace(txt, "&#x0*?2261;", "≡");
            txt = Regex.Replace(txt, "&#0*?8801;", "≡");
            txt = Regex.Replace(txt, "&equiv;", "≡");
            txt = Regex.Replace(txt, "&Congruent;", "≡");

            // "U+02264", "LESS-THAN OR EQUAL TO"
            txt = Regex.Replace(txt, "&#x0*?2264;", "≤");
            txt = Regex.Replace(txt, "&#0*?8804;", "≤");
            txt = Regex.Replace(txt, "&le;", "≤");
            txt = Regex.Replace(txt, "&leq;", "≤");

            // "U+02265", "GREATER-THAN OR EQUAL TO"
            txt = Regex.Replace(txt, "&#x0*?2265;", "≥");
            txt = Regex.Replace(txt, "&#0*?8805;", "≥");
            txt = Regex.Replace(txt, "&ge;", "≥");
            txt = Regex.Replace(txt, "&GreaterEqual;", "≥");
            txt = Regex.Replace(txt, "&geq;", "≥");

            // "U+02282", "SUBSET OF"
            txt = Regex.Replace(txt, "&#x0*?2282;", "⊂");
            txt = Regex.Replace(txt, "&#0*?8834;", "⊂");
            txt = Regex.Replace(txt, "&sub;", "⊂");
            txt = Regex.Replace(txt, "&subset;", "⊂");

            // "U+02283", "SUPERSET OF"
            txt = Regex.Replace(txt, "&#x0*?2283;", "⊃");
            txt = Regex.Replace(txt, "&#0*?8835;", "⊃");
            txt = Regex.Replace(txt, "&sup;", "⊃");
            txt = Regex.Replace(txt, "&supset;", "⊃");
            txt = Regex.Replace(txt, "&Superset;", "⊃");

            // "U+02284", "NOT A SUBSET OF"
            txt = Regex.Replace(txt, "&#x0*?2284;", "⊄");
            txt = Regex.Replace(txt, "&#0*?8836;", "⊄");
            txt = Regex.Replace(txt, "&nsub;", "⊄");

            // "U+02286", "SUBSET OF OR EQUAL TO"
            txt = Regex.Replace(txt, "&#x0*?2286;", "⊆");
            txt = Regex.Replace(txt, "&#0*?8838;", "⊆");
            txt = Regex.Replace(txt, "&sube;", "⊆");
            txt = Regex.Replace(txt, "&SubsetEqual;", "⊆");
            txt = Regex.Replace(txt, "&subseteq;", "⊆");

            // "U+02287", "SUPERSET OF OR EQUAL TO"
            txt = Regex.Replace(txt, "&#x0*?2287;", "⊇");
            txt = Regex.Replace(txt, "&#0*?8839;", "⊇");
            txt = Regex.Replace(txt, "&supe;", "⊇");
            txt = Regex.Replace(txt, "&supseteq;", "⊇");
            txt = Regex.Replace(txt, "&SupersetEqual;", "⊇");

            // "U+02295", "CIRCLED PLUS"
            txt = Regex.Replace(txt, "&#x0*?2295;", "⊕");
            txt = Regex.Replace(txt, "&#0*?8853;", "⊕");
            txt = Regex.Replace(txt, "&oplus;", "⊕");
            txt = Regex.Replace(txt, "&CirclePlus;", "⊕");

            // "U+02297", "CIRCLED TIMES"
            txt = Regex.Replace(txt, "&#x0*?2297;", "⊗");
            txt = Regex.Replace(txt, "&#0*?8855;", "⊗");
            txt = Regex.Replace(txt, "&otimes;", "⊗");
            txt = Regex.Replace(txt, "&CircleTimes;", "⊗");

            // "U+022A5", "UP TACK"
            txt = Regex.Replace(txt, "&#x0*?22A5;", "⊥");
            txt = Regex.Replace(txt, "&#0*?8869;", "⊥");
            txt = Regex.Replace(txt, "&bottom;", "⊥");
            txt = Regex.Replace(txt, "&bot;", "⊥");
            txt = Regex.Replace(txt, "&perp;", "⊥");
            txt = Regex.Replace(txt, "&UpTee;", "⊥");

            // "U+022C5", "DOT OPERATOR"
            txt = Regex.Replace(txt, "&#x0*?22C5;", "⋅");
            txt = Regex.Replace(txt, "&#0*?8901;", "⋅");
            txt = Regex.Replace(txt, "&sdot;", "⋅");

            // "U+02308", "LEFT CEILING"
            txt = Regex.Replace(txt, "&#x0*?2308;", "⌈");
            txt = Regex.Replace(txt, "&#0*?8968;", "⌈");
            txt = Regex.Replace(txt, "&lceil;", "⌈");
            txt = Regex.Replace(txt, "&LeftCeiling;", "⌈");

            // "U+02309", "RIGHT CEILING"
            txt = Regex.Replace(txt, "&#x0*?2309;", "⌉");
            txt = Regex.Replace(txt, "&#0*?8969;", "⌉");
            txt = Regex.Replace(txt, "&rceil;", "⌉");
            txt = Regex.Replace(txt, "&RightCeiling;", "⌉");

            // "U+0230A", "LEFT FLOOR"
            txt = Regex.Replace(txt, "&#x0*?230A;", "⌊");
            txt = Regex.Replace(txt, "&#0*?8970;", "⌊");
            txt = Regex.Replace(txt, "&lfloor;", "⌊");
            txt = Regex.Replace(txt, "&LeftFloor;", "⌊");

            // "U+0230B", "RIGHT FLOOR"
            txt = Regex.Replace(txt, "&#x0*?230B;", "⌋");
            txt = Regex.Replace(txt, "&#0*?8971;", "⌋");
            txt = Regex.Replace(txt, "&rfloor;", "⌋");
            txt = Regex.Replace(txt, "&RightFloor;", "⌋");

            // "U+025CA", "LOZENGE"
            txt = Regex.Replace(txt, "&#x0*?25CA;", "◊");
            txt = Regex.Replace(txt, "&#0*?9674;", "◊");
            txt = Regex.Replace(txt, "&loz;", "◊");
            txt = Regex.Replace(txt, "&lozenge;", "◊");

            // "U+02660", "BLACK SPADE SUIT"
            txt = Regex.Replace(txt, "&#x0*?2660;", "♠");
            txt = Regex.Replace(txt, "&#0*?9824;", "♠");
            txt = Regex.Replace(txt, "&spades;", "♠");
            txt = Regex.Replace(txt, "&spadesuit;", "♠");

            // "U+02663", "BLACK CLUB SUIT"
            txt = Regex.Replace(txt, "&#x0*?2663;", "♣");
            txt = Regex.Replace(txt, "&#0*?9827;", "♣");
            txt = Regex.Replace(txt, "&clubs;", "♣");
            txt = Regex.Replace(txt, "&clubsuit;", "♣");

            // "U+02665", "BLACK HEART SUIT"
            txt = Regex.Replace(txt, "&#x0*?2665;", "♥");
            txt = Regex.Replace(txt, "&#0*?9829;", "♥");
            txt = Regex.Replace(txt, "&hearts;", "♥");
            txt = Regex.Replace(txt, "&heartsuit;", "♥");

            // "U+02666", "BLACK DIAMOND SUIT"
            txt = Regex.Replace(txt, "&#x0*?2666;", "♦");
            txt = Regex.Replace(txt, "&#0*?9830;", "♦");
            txt = Regex.Replace(txt, "&diams;", "♦");
            txt = Regex.Replace(txt, "&diamondsuit;", "♦");

            // "U+027E8", "MATHEMATICAL LEFT ANGLE BRACKET"
            txt = Regex.Replace(txt, "&#x0*?27E8;", "⟨");
            txt = Regex.Replace(txt, "&#0*?10216;", "⟨");
            txt = Regex.Replace(txt, "&lang;", "⟨");
            txt = Regex.Replace(txt, "&LeftAngleBracket;", "⟨");
            txt = Regex.Replace(txt, "&langle;", "⟨");

            // "U+027E9", "MATHEMATICAL RIGHT ANGLE BRACKET"
            txt = Regex.Replace(txt, "&#x0*?27E9;", "⟩");
            txt = Regex.Replace(txt, "&#0*?10217;", "⟩");
            txt = Regex.Replace(txt, "&rang;", "⟩");
            txt = Regex.Replace(txt, "&RightAngleBracket;", "⟩");
            txt = Regex.Replace(txt, "&rangle;", "⟩");

            return txt;
        }

        /// <summary>
        /// 入力される文字列内の文字実体参照を文字や記号に置きかえます。ベーシック版です。
        /// </summary>
        /// <param name="sources">置きかえられる文字列の配列。</param>
        /// <returns>置きかえられた文字列の配列。</returns>
        static public string[] ConvertFromBasic(string[] sources)
        {
            for (int i = 0; i < sources.Length; i++)
            {
                sources[i] = ConvertFromBasic(sources[i]);
            }

            return sources;
        }

        /// <summary>
        /// 入力される文字列内の文字実体参照を文字や記号に置きかえます。
        /// </summary>
        /// <param name="source">置きかえられる文字列。</param>
        /// <returns>置きかえられた文字列。</returns>
        static public string ConvertFrom(string source)
        {
            string txt = source;

            // "U+00009", "CHARACTER TABULATION"
            txt = Regex.Replace(txt, "&#x0*?9;", "\t");
            txt = Regex.Replace(txt, "&#0*?9;", "\t");
            txt = Regex.Replace(txt, "&Tab;", "\t");

            // "U+0000A", "LINE FEED (LF)"
            txt = Regex.Replace(txt, "&#x0*?A;", "\n");
            txt = Regex.Replace(txt, "&#0*?10;", "\n");
            txt = Regex.Replace(txt, "&NewLine;", "\n");

            // "U+00021", "EXCLAMATION MARK"
            txt = Regex.Replace(txt, "&#x0*?21;", "!");
            txt = Regex.Replace(txt, "&#0*?33;", "!");
            txt = Regex.Replace(txt, "&excl;", "!");

            // "U+00022", "QUOTATION MARK"
            txt = Regex.Replace(txt, "&#x0*?22;", @"""");
            txt = Regex.Replace(txt, "&#0*?34;", @"""");
            txt = Regex.Replace(txt, "&quot;", @"""");
            txt = Regex.Replace(txt, "&QUOT;", @"""");

            // "U+00023", "NUMBER SIGN"
            txt = Regex.Replace(txt, "&#x0*?23;", "#");
            txt = Regex.Replace(txt, "&#0*?35;", "#");
            txt = Regex.Replace(txt, "&num;", "#");

            // "U+00024", "DOLLAR SIGN"
            txt = Regex.Replace(txt, "&#x0*?24;", "$");
            txt = Regex.Replace(txt, "&#0*?36;", "$");
            txt = Regex.Replace(txt, "&dollar;", "$");

            // "U+00025", "PERCENT SIGN"
            txt = Regex.Replace(txt, "&#x0*?25;", "%");
            txt = Regex.Replace(txt, "&#0*?37;", "%");
            txt = Regex.Replace(txt, "&percnt;", "%");

            // "U+00026", "AMPERSAND"
            txt = Regex.Replace(txt, "&#x0*?26;", "&");
            txt = Regex.Replace(txt, "&#0*?38;", "&");
            txt = Regex.Replace(txt, "&amp;", "&");
            txt = Regex.Replace(txt, "&AMP;", "&");

            // "U+00027", "APOSTROPHE"
            txt = Regex.Replace(txt, "&#x0*?27;", "'");
            txt = Regex.Replace(txt, "&#0*?39;", "'");
            txt = Regex.Replace(txt, "&apos;", "'");

            // "U+00028", "LEFT PARENTHESIS"
            txt = Regex.Replace(txt, "&#x0*?28;", "(");
            txt = Regex.Replace(txt, "&#0*?40;", "(");
            txt = Regex.Replace(txt, "&lpar;", "(");

            // "U+00029", "RIGHT PARENTHESIS"
            txt = Regex.Replace(txt, "&#x0*?29;", ")");
            txt = Regex.Replace(txt, "&#0*?41;", ")");
            txt = Regex.Replace(txt, "&rpar;", ")");

            // "U+0002A", "ASTERISK"
            txt = Regex.Replace(txt, "&#x0*?2A;", "*");
            txt = Regex.Replace(txt, "&#0*?42;", "*");
            txt = Regex.Replace(txt, "&ast;", "*");
            txt = Regex.Replace(txt, "&midast;", "*");

            // "U+0002B", "PLUS SIGN"
            txt = Regex.Replace(txt, "&#x0*?2B;", "+");
            txt = Regex.Replace(txt, "&#0*?43;", "+");
            txt = Regex.Replace(txt, "&plus;", "+");

            // "U+0002C", "COMMA"
            txt = Regex.Replace(txt, "&#x0*?2C;", ",");
            txt = Regex.Replace(txt, "&#0*?44;", ",");
            txt = Regex.Replace(txt, "&comma;", ",");

            // "U+0002E", "FULL STOP"
            txt = Regex.Replace(txt, "&#x0*?2E;", ".");
            txt = Regex.Replace(txt, "&#0*?46;", ".");
            txt = Regex.Replace(txt, "&period;", ".");

            // "U+0002F", "SOLIDUS"
            txt = Regex.Replace(txt, "&#x0*?2F;", "/");
            txt = Regex.Replace(txt, "&#0*?47;", "/");
            txt = Regex.Replace(txt, "&sol;", "/");

            // "U+0003A", "COLON"
            txt = Regex.Replace(txt, "&#x0*?3A;", ":");
            txt = Regex.Replace(txt, "&#0*?58;", ":");
            txt = Regex.Replace(txt, "&colon;", ":");

            // "U+0003B", "SEMICOLON"
            txt = Regex.Replace(txt, "&#x0*?3B;", ";");
            txt = Regex.Replace(txt, "&#0*?59;", ";");
            txt = Regex.Replace(txt, "&semi;", ";");

            // "U+0003C", "LESS-THAN SIGN"
            txt = Regex.Replace(txt, "&#x0*?3C;", "<");
            txt = Regex.Replace(txt, "&#0*?60;", "<");
            txt = Regex.Replace(txt, "&lt;", "<");
            txt = Regex.Replace(txt, "&LT;", "<");

            // "U+0003D", "EQUALS SIGN"
            txt = Regex.Replace(txt, "&#x0*?3D;", "=");
            txt = Regex.Replace(txt, "&#0*?61;", "=");
            txt = Regex.Replace(txt, "&equals;", "=");

            // "U+0003E", "GREATER-THAN SIGN"
            txt = Regex.Replace(txt, "&#x0*?3E;", ">");
            txt = Regex.Replace(txt, "&#0*?62;", ">");
            txt = Regex.Replace(txt, "&gt;", ">");
            txt = Regex.Replace(txt, "&GT;", ">");

            // "U+0003F", "QUESTION MARK"
            txt = Regex.Replace(txt, "&#x0*?3F;", "?");
            txt = Regex.Replace(txt, "&#0*?63;", "?");
            txt = Regex.Replace(txt, "&quest;", "?");

            // "U+00040", "COMMERCIAL AT"
            txt = Regex.Replace(txt, "&#x0*?40;", "@");
            txt = Regex.Replace(txt, "&#0*?64;", "@");
            txt = Regex.Replace(txt, "&commat;", "@");

            // "U+0005B", "LEFT SQUARE BRACKET"
            txt = Regex.Replace(txt, "&#x0*?5B;", "[");
            txt = Regex.Replace(txt, "&#0*?91;", "[");
            txt = Regex.Replace(txt, "&lsqb;", "[");
            txt = Regex.Replace(txt, "&lbrack;", "[");

            // "U+0005C", "REVERSE SOLIDUS"
            txt = Regex.Replace(txt, "&#x0*?5C;", @"\");
            txt = Regex.Replace(txt, "&#0*?92;", @"\");
            txt = Regex.Replace(txt, "&bsol;", @"\");

            // "U+0005D", "RIGHT SQUARE BRACKET"
            txt = Regex.Replace(txt, "&#x0*?5D;", "]");
            txt = Regex.Replace(txt, "&#0*?93;", "]");
            txt = Regex.Replace(txt, "&rsqb;", "]");
            txt = Regex.Replace(txt, "&rbrack;", "]");

            // "U+0005E", "CIRCUMFLEX ACCENT"
            txt = Regex.Replace(txt, "&#x0*?5E;", "^");
            txt = Regex.Replace(txt, "&#0*?94;", "^");
            txt = Regex.Replace(txt, "&Hat;", "^");

            // "U+0005F", "LOW LINE"
            txt = Regex.Replace(txt, "&#x0*?5F;", "_");
            txt = Regex.Replace(txt, "&#0*?95;", "_");
            txt = Regex.Replace(txt, "&lowbar;", "_");

            // "U+00060", "GRAVE ACCENT"
            txt = Regex.Replace(txt, "&#x0*?60;", "`");
            txt = Regex.Replace(txt, "&#0*?96;", "`");
            txt = Regex.Replace(txt, "&grave;", "`");
            txt = Regex.Replace(txt, "&DiacriticalGrave;", "`");

            // "U+0007B", "LEFT CURLY BRACKET"
            txt = Regex.Replace(txt, "&#x0*?7B;", "{");
            txt = Regex.Replace(txt, "&#0*?123;", "{");
            txt = Regex.Replace(txt, "&lcub;", "{");
            txt = Regex.Replace(txt, "&lbrace;", "{");

            // "U+0007C", "VERTICAL LINE"
            txt = Regex.Replace(txt, "&#x0*?7C;", "|");
            txt = Regex.Replace(txt, "&#0*?124;", "|");
            txt = Regex.Replace(txt, "&verbar;", "|");
            txt = Regex.Replace(txt, "&vert;", "|");
            txt = Regex.Replace(txt, "&VerticalLine;", "|");

            // "U+0007D", "RIGHT CURLY BRACKET"
            txt = Regex.Replace(txt, "&#x0*?7D;", "}");
            txt = Regex.Replace(txt, "&#0*?125;", "}");
            txt = Regex.Replace(txt, "&rcub;", "}");
            txt = Regex.Replace(txt, "&rbrace;", "}");

            // "U+000A0", "NO-BREAK SPACE"
            txt = Regex.Replace(txt, "&#x0*?A0;", " ");
            txt = Regex.Replace(txt, "&#0*?160;", " ");
            txt = Regex.Replace(txt, "&nbsp;", " ");
            txt = Regex.Replace(txt, "&NonBreakingSpace;", " ");

            // "U+000A1", "INVERTED EXCLAMATION MARK"
            txt = Regex.Replace(txt, "&#x0*?A1;", "¡");
            txt = Regex.Replace(txt, "&#0*?161;", "¡");
            txt = Regex.Replace(txt, "&iexcl;", "¡");

            // "U+000A2", "CENT SIGN"
            txt = Regex.Replace(txt, "&#x0*?A2;", "¢");
            txt = Regex.Replace(txt, "&#0*?162;", "¢");
            txt = Regex.Replace(txt, "&cent;", "¢");

            // "U+000A3", "POUND SIGN"
            txt = Regex.Replace(txt, "&#x0*?A3;", "£");
            txt = Regex.Replace(txt, "&#0*?163;", "£");
            txt = Regex.Replace(txt, "&pound;", "£");

            // "U+000A4", "CURRENCY SIGN"
            txt = Regex.Replace(txt, "&#x0*?A4;", "¤");
            txt = Regex.Replace(txt, "&#0*?164;", "¤");
            txt = Regex.Replace(txt, "&curren;", "¤");

            // "U+000A5", "YEN SIGN"
            txt = Regex.Replace(txt, "&#x0*?A5;", "¥");
            txt = Regex.Replace(txt, "&#0*?165;", "¥");
            txt = Regex.Replace(txt, "&yen;", "¥");

            // "U+000A6", "BROKEN BAR"
            txt = Regex.Replace(txt, "&#x0*?A6;", "¦");
            txt = Regex.Replace(txt, "&#0*?166;", "¦");
            txt = Regex.Replace(txt, "&brvbar;", "¦");

            // "U+000A7", "SECTION SIGN"
            txt = Regex.Replace(txt, "&#x0*?A7;", "§");
            txt = Regex.Replace(txt, "&#0*?167;", "§");
            txt = Regex.Replace(txt, "&sect;", "§");

            // "U+000A8", "DIAERESIS"
            txt = Regex.Replace(txt, "&#x0*?A8;", "¨");
            txt = Regex.Replace(txt, "&#0*?168;", "¨");
            txt = Regex.Replace(txt, "&Dot;", "¨");
            txt = Regex.Replace(txt, "&die;", "¨");
            txt = Regex.Replace(txt, "&DoubleDot;", "¨");
            txt = Regex.Replace(txt, "&uml;", "¨");

            // "U+000A9", "COPYRIGHT SIGN"
            txt = Regex.Replace(txt, "&#x0*?A9;", "©");
            txt = Regex.Replace(txt, "&#0*?169;", "©");
            txt = Regex.Replace(txt, "&copy;", "©");
            txt = Regex.Replace(txt, "&COPY;", "©");

            // "U+000AA", "FEMININE ORDINAL INDICATOR"
            txt = Regex.Replace(txt, "&#x0*?AA;", "ª");
            txt = Regex.Replace(txt, "&#0*?170;", "ª");
            txt = Regex.Replace(txt, "&ordf;", "ª");

            // "U+000AB", "LEFT-POINTING DOUBLE ANGLE QUOTATION MARK"
            txt = Regex.Replace(txt, "&#x0*?AB;", "«");
            txt = Regex.Replace(txt, "&#0*?171;", "«");
            txt = Regex.Replace(txt, "&laquo;", "«");

            // "U+000AC", "NOT SIGN"
            txt = Regex.Replace(txt, "&#x0*?AC;", "¬");
            txt = Regex.Replace(txt, "&#0*?172;", "¬");
            txt = Regex.Replace(txt, "&not;", "¬");

            // "U+000AD", "SOFT HYPHEN"
            txt = Regex.Replace(txt, "&#x0*?AD;", "­");
            txt = Regex.Replace(txt, "&#0*?173;", "­");
            txt = Regex.Replace(txt, "&shy;", "­");

            // "U+000AE", "REGISTERED SIGN"
            txt = Regex.Replace(txt, "&#x0*?AE;", "®");
            txt = Regex.Replace(txt, "&#0*?174;", "®");
            txt = Regex.Replace(txt, "&reg;", "®");
            txt = Regex.Replace(txt, "&circledR;", "®");
            txt = Regex.Replace(txt, "&REG;", "®");

            // "U+000AF", "MACRON"
            txt = Regex.Replace(txt, "&#x0*?AF;", "¯");
            txt = Regex.Replace(txt, "&#0*?175;", "¯");
            txt = Regex.Replace(txt, "&macr;", "¯");
            txt = Regex.Replace(txt, "&OverBar;", "¯");
            txt = Regex.Replace(txt, "&strns;", "¯");

            // "U+000B0", "DEGREE SIGN"
            txt = Regex.Replace(txt, "&#x0*?B0;", "°");
            txt = Regex.Replace(txt, "&#0*?176;", "°");
            txt = Regex.Replace(txt, "&deg;", "°");

            // "U+000B1", "PLUS-MINUS SIGN"
            txt = Regex.Replace(txt, "&#x0*?B1;", "±");
            txt = Regex.Replace(txt, "&#0*?177;", "±");
            txt = Regex.Replace(txt, "&plusmn;", "±");
            txt = Regex.Replace(txt, "&pm;", "±");
            txt = Regex.Replace(txt, "&PlusMinus;", "±");

            // "U+000B2", "SUPERSCRIPT TWO"
            txt = Regex.Replace(txt, "&#x0*?B2;", "²");
            txt = Regex.Replace(txt, "&#0*?178;", "²");
            txt = Regex.Replace(txt, "&sup2;", "²");

            // "U+000B3", "SUPERSCRIPT THREE"
            txt = Regex.Replace(txt, "&#x0*?B3;", "³");
            txt = Regex.Replace(txt, "&#0*?179;", "³");
            txt = Regex.Replace(txt, "&sup3;", "³");

            // "U+000B4", "ACUTE ACCENT"
            txt = Regex.Replace(txt, "&#x0*?B4;", "´");
            txt = Regex.Replace(txt, "&#0*?180;", "´");
            txt = Regex.Replace(txt, "&acute;", "´");
            txt = Regex.Replace(txt, "&DiacriticalAcute;", "´");

            // "U+000B5", "MICRO SIGN"
            txt = Regex.Replace(txt, "&#x0*?B5;", "µ");
            txt = Regex.Replace(txt, "&#0*?181;", "µ");
            txt = Regex.Replace(txt, "&micro;", "µ");

            // "U+000B6", "PILCROW SIGN"
            txt = Regex.Replace(txt, "&#x0*?B6;", "¶");
            txt = Regex.Replace(txt, "&#0*?182;", "¶");
            txt = Regex.Replace(txt, "&para;", "¶");

            // "U+000B7", "MIDDLE DOT"
            txt = Regex.Replace(txt, "&#x0*?B7;", "·");
            txt = Regex.Replace(txt, "&#0*?183;", "·");
            txt = Regex.Replace(txt, "&middot;", "·");
            txt = Regex.Replace(txt, "&centerdot;", "·");
            txt = Regex.Replace(txt, "&CenterDot;", "·");

            // "U+000B8", "CEDILLA"
            txt = Regex.Replace(txt, "&#x0*?B8;", "¸");
            txt = Regex.Replace(txt, "&#0*?184;", "¸");
            txt = Regex.Replace(txt, "&cedil;", "¸");
            txt = Regex.Replace(txt, "&Cedilla;", "¸");

            // "U+000B9", "SUPERSCRIPT ONE"
            txt = Regex.Replace(txt, "&#x0*?B9;", "¹");
            txt = Regex.Replace(txt, "&#0*?185;", "¹");
            txt = Regex.Replace(txt, "&sup1;", "¹");

            // "U+000BA", "MASCULINE ORDINAL INDICATOR"
            txt = Regex.Replace(txt, "&#x0*?BA;", "º");
            txt = Regex.Replace(txt, "&#0*?186;", "º");
            txt = Regex.Replace(txt, "&ordm;", "º");

            // "U+000BB", "RIGHT-POINTING DOUBLE ANGLE QUOTATION MARK"
            txt = Regex.Replace(txt, "&#x0*?BB;", "»");
            txt = Regex.Replace(txt, "&#0*?187;", "»");
            txt = Regex.Replace(txt, "&raquo;", "»");

            // "U+000BC", "VULGAR FRACTION ONE QUARTER"
            txt = Regex.Replace(txt, "&#x0*?BC;", "¼");
            txt = Regex.Replace(txt, "&#0*?188;", "¼");
            txt = Regex.Replace(txt, "&frac14;", "¼");

            // "U+000BD", "VULGAR FRACTION ONE HALF"
            txt = Regex.Replace(txt, "&#x0*?BD;", "½");
            txt = Regex.Replace(txt, "&#0*?189;", "½");
            txt = Regex.Replace(txt, "&frac12;", "½");
            txt = Regex.Replace(txt, "&half;", "½");

            // "U+000BE", "VULGAR FRACTION THREE QUARTERS"
            txt = Regex.Replace(txt, "&#x0*?BE;", "¾");
            txt = Regex.Replace(txt, "&#0*?190;", "¾");
            txt = Regex.Replace(txt, "&frac34;", "¾");

            // "U+000BF", "INVERTED QUESTION MARK"
            txt = Regex.Replace(txt, "&#x0*?BF;", "¿");
            txt = Regex.Replace(txt, "&#0*?191;", "¿");
            txt = Regex.Replace(txt, "&iquest;", "¿");

            // "U+000C0", "LATIN CAPITAL LETTER A WITH GRAVE"
            txt = Regex.Replace(txt, "&#x0*?C0;", "À");
            txt = Regex.Replace(txt, "&#0*?192;", "À");
            txt = Regex.Replace(txt, "&Agrave;", "À");

            // "U+000C1", "LATIN CAPITAL LETTER A WITH ACUTE"
            txt = Regex.Replace(txt, "&#x0*?C1;", "Á");
            txt = Regex.Replace(txt, "&#0*?193;", "Á");
            txt = Regex.Replace(txt, "&Aacute;", "Á");

            // "U+000C2", "LATIN CAPITAL LETTER A WITH CIRCUMFLEX"
            txt = Regex.Replace(txt, "&#x0*?C2;", "Â");
            txt = Regex.Replace(txt, "&#0*?194;", "Â");
            txt = Regex.Replace(txt, "&Acirc;", "Â");

            // "U+000C3", "LATIN CAPITAL LETTER A WITH TILDE"
            txt = Regex.Replace(txt, "&#x0*?C3;", "Ã");
            txt = Regex.Replace(txt, "&#0*?195;", "Ã");
            txt = Regex.Replace(txt, "&Atilde;", "Ã");

            // "U+000C4", "LATIN CAPITAL LETTER A WITH DIAERESIS"
            txt = Regex.Replace(txt, "&#x0*?C4;", "Ä");
            txt = Regex.Replace(txt, "&#0*?196;", "Ä");
            txt = Regex.Replace(txt, "&Auml;", "Ä");

            // "U+000C5", "LATIN CAPITAL LETTER A WITH RING ABOVE"
            txt = Regex.Replace(txt, "&#x0*?C5;", "Å");
            txt = Regex.Replace(txt, "&#0*?197;", "Å");
            txt = Regex.Replace(txt, "&Aring;", "Å");

            // "U+000C6", "LATIN CAPITAL LETTER AE"
            txt = Regex.Replace(txt, "&#x0*?C6;", "Æ");
            txt = Regex.Replace(txt, "&#0*?198;", "Æ");
            txt = Regex.Replace(txt, "&AElig;", "Æ");

            // "U+000C7", "LATIN CAPITAL LETTER C WITH CEDILLA"
            txt = Regex.Replace(txt, "&#x0*?C7;", "Ç");
            txt = Regex.Replace(txt, "&#0*?199;", "Ç");
            txt = Regex.Replace(txt, "&Ccedil;", "Ç");

            // "U+000C8", "LATIN CAPITAL LETTER E WITH GRAVE"
            txt = Regex.Replace(txt, "&#x0*?C8;", "È");
            txt = Regex.Replace(txt, "&#0*?200;", "È");
            txt = Regex.Replace(txt, "&Egrave;", "È");

            // "U+000C9", "LATIN CAPITAL LETTER E WITH ACUTE"
            txt = Regex.Replace(txt, "&#x0*?C9;", "É");
            txt = Regex.Replace(txt, "&#0*?201;", "É");
            txt = Regex.Replace(txt, "&Eacute;", "É");

            // "U+000CA", "LATIN CAPITAL LETTER E WITH CIRCUMFLEX"
            txt = Regex.Replace(txt, "&#x0*?CA;", "Ê");
            txt = Regex.Replace(txt, "&#0*?202;", "Ê");
            txt = Regex.Replace(txt, "&Ecirc;", "Ê");

            // "U+000CB", "LATIN CAPITAL LETTER E WITH DIAERESIS"
            txt = Regex.Replace(txt, "&#x0*?CB;", "Ë");
            txt = Regex.Replace(txt, "&#0*?203;", "Ë");
            txt = Regex.Replace(txt, "&Euml;", "Ë");

            // "U+000CC", "LATIN CAPITAL LETTER I WITH GRAVE"
            txt = Regex.Replace(txt, "&#x0*?CC;", "Ì");
            txt = Regex.Replace(txt, "&#0*?204;", "Ì");
            txt = Regex.Replace(txt, "&Igrave;", "Ì");

            // "U+000CD", "LATIN CAPITAL LETTER I WITH ACUTE"
            txt = Regex.Replace(txt, "&#x0*?CD;", "Í");
            txt = Regex.Replace(txt, "&#0*?205;", "Í");
            txt = Regex.Replace(txt, "&Iacute;", "Í");

            // "U+000CE", "LATIN CAPITAL LETTER I WITH CIRCUMFLEX"
            txt = Regex.Replace(txt, "&#x0*?CE;", "Î");
            txt = Regex.Replace(txt, "&#0*?206;", "Î");
            txt = Regex.Replace(txt, "&Icirc;", "Î");

            // "U+000CF", "LATIN CAPITAL LETTER I WITH DIAERESIS"
            txt = Regex.Replace(txt, "&#x0*?CF;", "Ï");
            txt = Regex.Replace(txt, "&#0*?207;", "Ï");
            txt = Regex.Replace(txt, "&Iuml;", "Ï");

            // "U+000D0", "LATIN CAPITAL LETTER ETH"
            txt = Regex.Replace(txt, "&#x0*?D0;", "Ð");
            txt = Regex.Replace(txt, "&#0*?208;", "Ð");
            txt = Regex.Replace(txt, "&ETH;", "Ð");

            // "U+000D1", "LATIN CAPITAL LETTER N WITH TILDE"
            txt = Regex.Replace(txt, "&#x0*?D1;", "Ñ");
            txt = Regex.Replace(txt, "&#0*?209;", "Ñ");
            txt = Regex.Replace(txt, "&Ntilde;", "Ñ");

            // "U+000D2", "LATIN CAPITAL LETTER O WITH GRAVE"
            txt = Regex.Replace(txt, "&#x0*?D2;", "Ò");
            txt = Regex.Replace(txt, "&#0*?210;", "Ò");
            txt = Regex.Replace(txt, "&Ograve;", "Ò");

            // "U+000D3", "LATIN CAPITAL LETTER O WITH ACUTE"
            txt = Regex.Replace(txt, "&#x0*?D3;", "Ó");
            txt = Regex.Replace(txt, "&#0*?211;", "Ó");
            txt = Regex.Replace(txt, "&Oacute;", "Ó");

            // "U+000D4", "LATIN CAPITAL LETTER O WITH CIRCUMFLEX"
            txt = Regex.Replace(txt, "&#x0*?D4;", "Ô");
            txt = Regex.Replace(txt, "&#0*?212;", "Ô");
            txt = Regex.Replace(txt, "&Ocirc;", "Ô");

            // "U+000D5", "LATIN CAPITAL LETTER O WITH TILDE"
            txt = Regex.Replace(txt, "&#x0*?D5;", "Õ");
            txt = Regex.Replace(txt, "&#0*?213;", "Õ");
            txt = Regex.Replace(txt, "&Otilde;", "Õ");

            // "U+000D6", "LATIN CAPITAL LETTER O WITH DIAERESIS"
            txt = Regex.Replace(txt, "&#x0*?D6;", "Ö");
            txt = Regex.Replace(txt, "&#0*?214;", "Ö");
            txt = Regex.Replace(txt, "&Ouml;", "Ö");

            // "U+000D7", "MULTIPLICATION SIGN"
            txt = Regex.Replace(txt, "&#x0*?D7;", "×");
            txt = Regex.Replace(txt, "&#0*?215;", "×");
            txt = Regex.Replace(txt, "&times;", "×");

            // "U+000D8", "LATIN CAPITAL LETTER O WITH STROKE"
            txt = Regex.Replace(txt, "&#x0*?D8;", "Ø");
            txt = Regex.Replace(txt, "&#0*?216;", "Ø");
            txt = Regex.Replace(txt, "&Oslash;", "Ø");

            // "U+000D9", "LATIN CAPITAL LETTER U WITH GRAVE"
            txt = Regex.Replace(txt, "&#x0*?D9;", "Ù");
            txt = Regex.Replace(txt, "&#0*?217;", "Ù");
            txt = Regex.Replace(txt, "&Ugrave;", "Ù");

            // "U+000DA", "LATIN CAPITAL LETTER U WITH ACUTE"
            txt = Regex.Replace(txt, "&#x0*?DA;", "Ú");
            txt = Regex.Replace(txt, "&#0*?218;", "Ú");
            txt = Regex.Replace(txt, "&Uacute;", "Ú");

            // "U+000DB", "LATIN CAPITAL LETTER U WITH CIRCUMFLEX"
            txt = Regex.Replace(txt, "&#x0*?DB;", "Û");
            txt = Regex.Replace(txt, "&#0*?219;", "Û");
            txt = Regex.Replace(txt, "&Ucirc;", "Û");

            // "U+000DC", "LATIN CAPITAL LETTER U WITH DIAERESIS"
            txt = Regex.Replace(txt, "&#x0*?DC;", "Ü");
            txt = Regex.Replace(txt, "&#0*?220;", "Ü");
            txt = Regex.Replace(txt, "&Uuml;", "Ü");

            // "U+000DD", "LATIN CAPITAL LETTER Y WITH ACUTE"
            txt = Regex.Replace(txt, "&#x0*?DD;", "Ý");
            txt = Regex.Replace(txt, "&#0*?221;", "Ý");
            txt = Regex.Replace(txt, "&Yacute;", "Ý");

            // "U+000DE", "LATIN CAPITAL LETTER THORN"
            txt = Regex.Replace(txt, "&#x0*?DE;", "Þ");
            txt = Regex.Replace(txt, "&#0*?222;", "Þ");
            txt = Regex.Replace(txt, "&THORN;", "Þ");

            // "U+000DF", "LATIN SMALL LETTER SHARP S"
            txt = Regex.Replace(txt, "&#x0*?DF;", "ß");
            txt = Regex.Replace(txt, "&#0*?223;", "ß");
            txt = Regex.Replace(txt, "&szlig;", "ß");

            // "U+000E0", "LATIN SMALL LETTER A WITH GRAVE"
            txt = Regex.Replace(txt, "&#x0*?E0;", "à");
            txt = Regex.Replace(txt, "&#0*?224;", "à");
            txt = Regex.Replace(txt, "&agrave;", "à");

            // "U+000E1", "LATIN SMALL LETTER A WITH ACUTE"
            txt = Regex.Replace(txt, "&#x0*?E1;", "á");
            txt = Regex.Replace(txt, "&#0*?225;", "á");
            txt = Regex.Replace(txt, "&aacute;", "á");

            // "U+000E2", "LATIN SMALL LETTER A WITH CIRCUMFLEX"
            txt = Regex.Replace(txt, "&#x0*?E2;", "â");
            txt = Regex.Replace(txt, "&#0*?226;", "â");
            txt = Regex.Replace(txt, "&acirc;", "â");

            // "U+000E3", "LATIN SMALL LETTER A WITH TILDE"
            txt = Regex.Replace(txt, "&#x0*?E3;", "ã");
            txt = Regex.Replace(txt, "&#0*?227;", "ã");
            txt = Regex.Replace(txt, "&atilde;", "ã");

            // "U+000E4", "LATIN SMALL LETTER A WITH DIAERESIS"
            txt = Regex.Replace(txt, "&#x0*?E4;", "ä");
            txt = Regex.Replace(txt, "&#0*?228;", "ä");
            txt = Regex.Replace(txt, "&auml;", "ä");

            // "U+000E5", "LATIN SMALL LETTER A WITH RING ABOVE"
            txt = Regex.Replace(txt, "&#x0*?E5;", "å");
            txt = Regex.Replace(txt, "&#0*?229;", "å");
            txt = Regex.Replace(txt, "&aring;", "å");

            // "U+000E6", "LATIN SMALL LETTER AE"
            txt = Regex.Replace(txt, "&#x0*?E6;", "æ");
            txt = Regex.Replace(txt, "&#0*?230;", "æ");
            txt = Regex.Replace(txt, "&aelig;", "æ");

            // "U+000E7", "LATIN SMALL LETTER C WITH CEDILLA"
            txt = Regex.Replace(txt, "&#x0*?E7;", "ç");
            txt = Regex.Replace(txt, "&#0*?231;", "ç");
            txt = Regex.Replace(txt, "&ccedil;", "ç");

            // "U+000E8", "LATIN SMALL LETTER E WITH GRAVE"
            txt = Regex.Replace(txt, "&#x0*?E8;", "è");
            txt = Regex.Replace(txt, "&#0*?232;", "è");
            txt = Regex.Replace(txt, "&egrave;", "è");

            // "U+000E9", "LATIN SMALL LETTER E WITH ACUTE"
            txt = Regex.Replace(txt, "&#x0*?E9;", "é");
            txt = Regex.Replace(txt, "&#0*?233;", "é");
            txt = Regex.Replace(txt, "&eacute;", "é");

            // "U+000EA", "LATIN SMALL LETTER E WITH CIRCUMFLEX"
            txt = Regex.Replace(txt, "&#x0*?EA;", "ê");
            txt = Regex.Replace(txt, "&#0*?234;", "ê");
            txt = Regex.Replace(txt, "&ecirc;", "ê");

            // "U+000EB", "LATIN SMALL LETTER E WITH DIAERESIS"
            txt = Regex.Replace(txt, "&#x0*?EB;", "ë");
            txt = Regex.Replace(txt, "&#0*?235;", "ë");
            txt = Regex.Replace(txt, "&euml;", "ë");

            // "U+000EC", "LATIN SMALL LETTER I WITH GRAVE"
            txt = Regex.Replace(txt, "&#x0*?EC;", "ì");
            txt = Regex.Replace(txt, "&#0*?236;", "ì");
            txt = Regex.Replace(txt, "&igrave;", "ì");

            // "U+000ED", "LATIN SMALL LETTER I WITH ACUTE"
            txt = Regex.Replace(txt, "&#x0*?ED;", "í");
            txt = Regex.Replace(txt, "&#0*?237;", "í");
            txt = Regex.Replace(txt, "&iacute;", "í");

            // "U+000EE", "LATIN SMALL LETTER I WITH CIRCUMFLEX"
            txt = Regex.Replace(txt, "&#x0*?EE;", "î");
            txt = Regex.Replace(txt, "&#0*?238;", "î");
            txt = Regex.Replace(txt, "&icirc;", "î");

            // "U+000EF", "LATIN SMALL LETTER I WITH DIAERESIS"
            txt = Regex.Replace(txt, "&#x0*?EF;", "ï");
            txt = Regex.Replace(txt, "&#0*?239;", "ï");
            txt = Regex.Replace(txt, "&iuml;", "ï");

            // "U+000F0", "LATIN SMALL LETTER ETH"
            txt = Regex.Replace(txt, "&#x0*?F0;", "ð");
            txt = Regex.Replace(txt, "&#0*?240;", "ð");
            txt = Regex.Replace(txt, "&eth;", "ð");

            // "U+000F1", "LATIN SMALL LETTER N WITH TILDE"
            txt = Regex.Replace(txt, "&#x0*?F1;", "ñ");
            txt = Regex.Replace(txt, "&#0*?241;", "ñ");
            txt = Regex.Replace(txt, "&ntilde;", "ñ");

            // "U+000F2", "LATIN SMALL LETTER O WITH GRAVE"
            txt = Regex.Replace(txt, "&#x0*?F2;", "ò");
            txt = Regex.Replace(txt, "&#0*?242;", "ò");
            txt = Regex.Replace(txt, "&ograve;", "ò");

            // "U+000F3", "LATIN SMALL LETTER O WITH ACUTE"
            txt = Regex.Replace(txt, "&#x0*?F3;", "ó");
            txt = Regex.Replace(txt, "&#0*?243;", "ó");
            txt = Regex.Replace(txt, "&oacute;", "ó");

            // "U+000F4", "LATIN SMALL LETTER O WITH CIRCUMFLEX"
            txt = Regex.Replace(txt, "&#x0*?F4;", "ô");
            txt = Regex.Replace(txt, "&#0*?244;", "ô");
            txt = Regex.Replace(txt, "&ocirc;", "ô");

            // "U+000F5", "LATIN SMALL LETTER O WITH TILDE"
            txt = Regex.Replace(txt, "&#x0*?F5;", "õ");
            txt = Regex.Replace(txt, "&#0*?245;", "õ");
            txt = Regex.Replace(txt, "&otilde;", "õ");

            // "U+000F6", "LATIN SMALL LETTER O WITH DIAERESIS"
            txt = Regex.Replace(txt, "&#x0*?F6;", "ö");
            txt = Regex.Replace(txt, "&#0*?246;", "ö");
            txt = Regex.Replace(txt, "&ouml;", "ö");

            // "U+000F7", "DIVISION SIGN"
            txt = Regex.Replace(txt, "&#x0*?F7;", "÷");
            txt = Regex.Replace(txt, "&#0*?247;", "÷");
            txt = Regex.Replace(txt, "&divide;", "÷");
            txt = Regex.Replace(txt, "&div;", "÷");

            // "U+000F8", "LATIN SMALL LETTER O WITH STROKE"
            txt = Regex.Replace(txt, "&#x0*?F8;", "ø");
            txt = Regex.Replace(txt, "&#0*?248;", "ø");
            txt = Regex.Replace(txt, "&oslash;", "ø");

            // "U+000F9", "LATIN SMALL LETTER U WITH GRAVE"
            txt = Regex.Replace(txt, "&#x0*?F9;", "ù");
            txt = Regex.Replace(txt, "&#0*?249;", "ù");
            txt = Regex.Replace(txt, "&ugrave;", "ù");

            // "U+000FA", "LATIN SMALL LETTER U WITH ACUTE"
            txt = Regex.Replace(txt, "&#x0*?FA;", "ú");
            txt = Regex.Replace(txt, "&#0*?250;", "ú");
            txt = Regex.Replace(txt, "&uacute;", "ú");

            // "U+000FB", "LATIN SMALL LETTER U WITH CIRCUMFLEX"
            txt = Regex.Replace(txt, "&#x0*?FB;", "û");
            txt = Regex.Replace(txt, "&#0*?251;", "û");
            txt = Regex.Replace(txt, "&ucirc;", "û");

            // "U+000FC", "LATIN SMALL LETTER U WITH DIAERESIS"
            txt = Regex.Replace(txt, "&#x0*?FC;", "ü");
            txt = Regex.Replace(txt, "&#0*?252;", "ü");
            txt = Regex.Replace(txt, "&uuml;", "ü");

            // "U+000FD", "LATIN SMALL LETTER Y WITH ACUTE"
            txt = Regex.Replace(txt, "&#x0*?FD;", "ý");
            txt = Regex.Replace(txt, "&#0*?253;", "ý");
            txt = Regex.Replace(txt, "&yacute;", "ý");

            // "U+000FE", "LATIN SMALL LETTER THORN"
            txt = Regex.Replace(txt, "&#x0*?FE;", "þ");
            txt = Regex.Replace(txt, "&#0*?254;", "þ");
            txt = Regex.Replace(txt, "&thorn;", "þ");

            // "U+000FF", "LATIN SMALL LETTER Y WITH DIAERESIS"
            txt = Regex.Replace(txt, "&#x0*?FF;", "ÿ");
            txt = Regex.Replace(txt, "&#0*?255;", "ÿ");
            txt = Regex.Replace(txt, "&yuml;", "ÿ");

            // "U+00100", "LATIN CAPITAL LETTER A WITH MACRON"
            txt = Regex.Replace(txt, "&#x0*?100;", "Ā");
            txt = Regex.Replace(txt, "&#0*?256;", "Ā");
            txt = Regex.Replace(txt, "&Amacr;", "Ā");

            // "U+00101", "LATIN SMALL LETTER A WITH MACRON"
            txt = Regex.Replace(txt, "&#x0*?101;", "ā");
            txt = Regex.Replace(txt, "&#0*?257;", "ā");
            txt = Regex.Replace(txt, "&amacr;", "ā");

            // "U+00102", "LATIN CAPITAL LETTER A WITH BREVE"
            txt = Regex.Replace(txt, "&#x0*?102;", "Ă");
            txt = Regex.Replace(txt, "&#0*?258;", "Ă");
            txt = Regex.Replace(txt, "&Abreve;", "Ă");

            // "U+00103", "LATIN SMALL LETTER A WITH BREVE"
            txt = Regex.Replace(txt, "&#x0*?103;", "ă");
            txt = Regex.Replace(txt, "&#0*?259;", "ă");
            txt = Regex.Replace(txt, "&abreve;", "ă");

            // "U+00104", "LATIN CAPITAL LETTER A WITH OGONEK"
            txt = Regex.Replace(txt, "&#x0*?104;", "Ą");
            txt = Regex.Replace(txt, "&#0*?260;", "Ą");
            txt = Regex.Replace(txt, "&Aogon;", "Ą");

            // "U+00105", "LATIN SMALL LETTER A WITH OGONEK"
            txt = Regex.Replace(txt, "&#x0*?105;", "ą");
            txt = Regex.Replace(txt, "&#0*?261;", "ą");
            txt = Regex.Replace(txt, "&aogon;", "ą");

            // "U+00106", "LATIN CAPITAL LETTER C WITH ACUTE"
            txt = Regex.Replace(txt, "&#x0*?106;", "Ć");
            txt = Regex.Replace(txt, "&#0*?262;", "Ć");
            txt = Regex.Replace(txt, "&Cacute;", "Ć");

            // "U+00107", "LATIN SMALL LETTER C WITH ACUTE"
            txt = Regex.Replace(txt, "&#x0*?107;", "ć");
            txt = Regex.Replace(txt, "&#0*?263;", "ć");
            txt = Regex.Replace(txt, "&cacute;", "ć");

            // "U+00108", "LATIN CAPITAL LETTER C WITH CIRCUMFLEX"
            txt = Regex.Replace(txt, "&#x0*?108;", "Ĉ");
            txt = Regex.Replace(txt, "&#0*?264;", "Ĉ");
            txt = Regex.Replace(txt, "&Ccirc;", "Ĉ");

            // "U+00109", "LATIN SMALL LETTER C WITH CIRCUMFLEX"
            txt = Regex.Replace(txt, "&#x0*?109;", "ĉ");
            txt = Regex.Replace(txt, "&#0*?265;", "ĉ");
            txt = Regex.Replace(txt, "&ccirc;", "ĉ");

            // "U+0010A", "LATIN CAPITAL LETTER C WITH DOT ABOVE"
            txt = Regex.Replace(txt, "&#x0*?10A;", "Ċ");
            txt = Regex.Replace(txt, "&#0*?266;", "Ċ");
            txt = Regex.Replace(txt, "&Cdot;", "Ċ");

            // "U+0010B", "LATIN SMALL LETTER C WITH DOT ABOVE"
            txt = Regex.Replace(txt, "&#x0*?10B;", "ċ");
            txt = Regex.Replace(txt, "&#0*?267;", "ċ");
            txt = Regex.Replace(txt, "&cdot;", "ċ");

            // "U+0010C", "LATIN CAPITAL LETTER C WITH CARON"
            txt = Regex.Replace(txt, "&#x0*?10C;", "Č");
            txt = Regex.Replace(txt, "&#0*?268;", "Č");
            txt = Regex.Replace(txt, "&Ccaron;", "Č");

            // "U+0010D", "LATIN SMALL LETTER C WITH CARON"
            txt = Regex.Replace(txt, "&#x0*?10D;", "č");
            txt = Regex.Replace(txt, "&#0*?269;", "č");
            txt = Regex.Replace(txt, "&ccaron;", "č");

            // "U+0010E", "LATIN CAPITAL LETTER D WITH CARON"
            txt = Regex.Replace(txt, "&#x0*?10E;", "Ď");
            txt = Regex.Replace(txt, "&#0*?270;", "Ď");
            txt = Regex.Replace(txt, "&Dcaron;", "Ď");

            // "U+0010F", "LATIN SMALL LETTER D WITH CARON"
            txt = Regex.Replace(txt, "&#x0*?10F;", "ď");
            txt = Regex.Replace(txt, "&#0*?271;", "ď");
            txt = Regex.Replace(txt, "&dcaron;", "ď");

            // "U+00110", "LATIN CAPITAL LETTER D WITH STROKE"
            txt = Regex.Replace(txt, "&#x0*?110;", "Đ");
            txt = Regex.Replace(txt, "&#0*?272;", "Đ");
            txt = Regex.Replace(txt, "&Dstrok;", "Đ");

            // "U+00111", "LATIN SMALL LETTER D WITH STROKE"
            txt = Regex.Replace(txt, "&#x0*?111;", "đ");
            txt = Regex.Replace(txt, "&#0*?273;", "đ");
            txt = Regex.Replace(txt, "&dstrok;", "đ");

            // "U+00112", "LATIN CAPITAL LETTER E WITH MACRON"
            txt = Regex.Replace(txt, "&#x0*?112;", "Ē");
            txt = Regex.Replace(txt, "&#0*?274;", "Ē");
            txt = Regex.Replace(txt, "&Emacr;", "Ē");

            // "U+00113", "LATIN SMALL LETTER E WITH MACRON"
            txt = Regex.Replace(txt, "&#x0*?113;", "ē");
            txt = Regex.Replace(txt, "&#0*?275;", "ē");
            txt = Regex.Replace(txt, "&emacr;", "ē");

            // "U+00116", "LATIN CAPITAL LETTER E WITH DOT ABOVE"
            txt = Regex.Replace(txt, "&#x0*?116;", "Ė");
            txt = Regex.Replace(txt, "&#0*?278;", "Ė");
            txt = Regex.Replace(txt, "&Edot;", "Ė");

            // "U+00117", "LATIN SMALL LETTER E WITH DOT ABOVE"
            txt = Regex.Replace(txt, "&#x0*?117;", "ė");
            txt = Regex.Replace(txt, "&#0*?279;", "ė");
            txt = Regex.Replace(txt, "&edot;", "ė");

            // "U+00118", "LATIN CAPITAL LETTER E WITH OGONEK"
            txt = Regex.Replace(txt, "&#x0*?118;", "Ę");
            txt = Regex.Replace(txt, "&#0*?280;", "Ę");
            txt = Regex.Replace(txt, "&Eogon;", "Ę");

            // "U+00119", "LATIN SMALL LETTER E WITH OGONEK"
            txt = Regex.Replace(txt, "&#x0*?119;", "ę");
            txt = Regex.Replace(txt, "&#0*?281;", "ę");
            txt = Regex.Replace(txt, "&eogon;", "ę");

            // "U+0011A", "LATIN CAPITAL LETTER E WITH CARON"
            txt = Regex.Replace(txt, "&#x0*?11A;", "Ě");
            txt = Regex.Replace(txt, "&#0*?282;", "Ě");
            txt = Regex.Replace(txt, "&Ecaron;", "Ě");

            // "U+0011B", "LATIN SMALL LETTER E WITH CARON"
            txt = Regex.Replace(txt, "&#x0*?11B;", "ě");
            txt = Regex.Replace(txt, "&#0*?283;", "ě");
            txt = Regex.Replace(txt, "&ecaron;", "ě");

            // "U+0011C", "LATIN CAPITAL LETTER G WITH CIRCUMFLEX"
            txt = Regex.Replace(txt, "&#x0*?11C;", "Ĝ");
            txt = Regex.Replace(txt, "&#0*?284;", "Ĝ");
            txt = Regex.Replace(txt, "&Gcirc;", "Ĝ");

            // "U+0011D", "LATIN SMALL LETTER G WITH CIRCUMFLEX"
            txt = Regex.Replace(txt, "&#x0*?11D;", "ĝ");
            txt = Regex.Replace(txt, "&#0*?285;", "ĝ");
            txt = Regex.Replace(txt, "&gcirc;", "ĝ");

            // "U+0011E", "LATIN CAPITAL LETTER G WITH BREVE"
            txt = Regex.Replace(txt, "&#x0*?11E;", "Ğ");
            txt = Regex.Replace(txt, "&#0*?286;", "Ğ");
            txt = Regex.Replace(txt, "&Gbreve;", "Ğ");

            // "U+0011F", "LATIN SMALL LETTER G WITH BREVE"
            txt = Regex.Replace(txt, "&#x0*?11F;", "ğ");
            txt = Regex.Replace(txt, "&#0*?287;", "ğ");
            txt = Regex.Replace(txt, "&gbreve;", "ğ");

            // "U+00120", "LATIN CAPITAL LETTER G WITH DOT ABOVE"
            txt = Regex.Replace(txt, "&#x0*?120;", "Ġ");
            txt = Regex.Replace(txt, "&#0*?288;", "Ġ");
            txt = Regex.Replace(txt, "&Gdot;", "Ġ");

            // "U+00121", "LATIN SMALL LETTER G WITH DOT ABOVE"
            txt = Regex.Replace(txt, "&#x0*?121;", "ġ");
            txt = Regex.Replace(txt, "&#0*?289;", "ġ");
            txt = Regex.Replace(txt, "&gdot;", "ġ");

            // "U+00122", "LATIN CAPITAL LETTER G WITH CEDILLA"
            txt = Regex.Replace(txt, "&#x0*?122;", "Ģ");
            txt = Regex.Replace(txt, "&#0*?290;", "Ģ");
            txt = Regex.Replace(txt, "&Gcedil;", "Ģ");

            // "U+00124", "LATIN CAPITAL LETTER H WITH CIRCUMFLEX"
            txt = Regex.Replace(txt, "&#x0*?124;", "Ĥ");
            txt = Regex.Replace(txt, "&#0*?292;", "Ĥ");
            txt = Regex.Replace(txt, "&Hcirc;", "Ĥ");

            // "U+00125", "LATIN SMALL LETTER H WITH CIRCUMFLEX"
            txt = Regex.Replace(txt, "&#x0*?125;", "ĥ");
            txt = Regex.Replace(txt, "&#0*?293;", "ĥ");
            txt = Regex.Replace(txt, "&hcirc;", "ĥ");

            // "U+00126", "LATIN CAPITAL LETTER H WITH STROKE"
            txt = Regex.Replace(txt, "&#x0*?126;", "Ħ");
            txt = Regex.Replace(txt, "&#0*?294;", "Ħ");
            txt = Regex.Replace(txt, "&Hstrok;", "Ħ");

            // "U+00127", "LATIN SMALL LETTER H WITH STROKE"
            txt = Regex.Replace(txt, "&#x0*?127;", "ħ");
            txt = Regex.Replace(txt, "&#0*?295;", "ħ");
            txt = Regex.Replace(txt, "&hstrok;", "ħ");

            // "U+00128", "LATIN CAPITAL LETTER I WITH TILDE"
            txt = Regex.Replace(txt, "&#x0*?128;", "Ĩ");
            txt = Regex.Replace(txt, "&#0*?296;", "Ĩ");
            txt = Regex.Replace(txt, "&Itilde;", "Ĩ");

            // "U+00129", "LATIN SMALL LETTER I WITH TILDE"
            txt = Regex.Replace(txt, "&#x0*?129;", "ĩ");
            txt = Regex.Replace(txt, "&#0*?297;", "ĩ");
            txt = Regex.Replace(txt, "&itilde;", "ĩ");

            // "U+0012A", "LATIN CAPITAL LETTER I WITH MACRON"
            txt = Regex.Replace(txt, "&#x0*?12A;", "Ī");
            txt = Regex.Replace(txt, "&#0*?298;", "Ī");
            txt = Regex.Replace(txt, "&Imacr;", "Ī");

            // "U+0012B", "LATIN SMALL LETTER I WITH MACRON"
            txt = Regex.Replace(txt, "&#x0*?12B;", "ī");
            txt = Regex.Replace(txt, "&#0*?299;", "ī");
            txt = Regex.Replace(txt, "&imacr;", "ī");

            // "U+0012E", "LATIN CAPITAL LETTER I WITH OGONEK"
            txt = Regex.Replace(txt, "&#x0*?12E;", "Į");
            txt = Regex.Replace(txt, "&#0*?302;", "Į");
            txt = Regex.Replace(txt, "&Iogon;", "Į");

            // "U+0012F", "LATIN SMALL LETTER I WITH OGONEK"
            txt = Regex.Replace(txt, "&#x0*?12F;", "į");
            txt = Regex.Replace(txt, "&#0*?303;", "į");
            txt = Regex.Replace(txt, "&iogon;", "į");

            // "U+00130", "LATIN CAPITAL LETTER I WITH DOT ABOVE"
            txt = Regex.Replace(txt, "&#x0*?130;", "İ");
            txt = Regex.Replace(txt, "&#0*?304;", "İ");
            txt = Regex.Replace(txt, "&Idot;", "İ");

            // "U+00131", "LATIN SMALL LETTER DOTLESS I"
            txt = Regex.Replace(txt, "&#x0*?131;", "ı");
            txt = Regex.Replace(txt, "&#0*?305;", "ı");
            txt = Regex.Replace(txt, "&imath;", "ı");
            txt = Regex.Replace(txt, "&inodot;", "ı");

            // "U+00132", "LATIN CAPITAL LIGATURE IJ"
            txt = Regex.Replace(txt, "&#x0*?132;", "Ĳ");
            txt = Regex.Replace(txt, "&#0*?306;", "Ĳ");
            txt = Regex.Replace(txt, "&IJlig;", "Ĳ");

            // "U+00133", "LATIN SMALL LIGATURE IJ"
            txt = Regex.Replace(txt, "&#x0*?133;", "ĳ");
            txt = Regex.Replace(txt, "&#0*?307;", "ĳ");
            txt = Regex.Replace(txt, "&ijlig;", "ĳ");

            // "U+00134", "LATIN CAPITAL LETTER J WITH CIRCUMFLEX"
            txt = Regex.Replace(txt, "&#x0*?134;", "Ĵ");
            txt = Regex.Replace(txt, "&#0*?308;", "Ĵ");
            txt = Regex.Replace(txt, "&Jcirc;", "Ĵ");

            // "U+00135", "LATIN SMALL LETTER J WITH CIRCUMFLEX"
            txt = Regex.Replace(txt, "&#x0*?135;", "ĵ");
            txt = Regex.Replace(txt, "&#0*?309;", "ĵ");
            txt = Regex.Replace(txt, "&jcirc;", "ĵ");

            // "U+00136", "LATIN CAPITAL LETTER K WITH CEDILLA"
            txt = Regex.Replace(txt, "&#x0*?136;", "Ķ");
            txt = Regex.Replace(txt, "&#0*?310;", "Ķ");
            txt = Regex.Replace(txt, "&Kcedil;", "Ķ");

            // "U+00137", "LATIN SMALL LETTER K WITH CEDILLA"
            txt = Regex.Replace(txt, "&#x0*?137;", "ķ");
            txt = Regex.Replace(txt, "&#0*?311;", "ķ");
            txt = Regex.Replace(txt, "&kcedil;", "ķ");

            // "U+00138", "LATIN SMALL LETTER KRA"
            txt = Regex.Replace(txt, "&#x0*?138;", "ĸ");
            txt = Regex.Replace(txt, "&#0*?312;", "ĸ");
            txt = Regex.Replace(txt, "&kgreen;", "ĸ");

            // "U+00139", "LATIN CAPITAL LETTER L WITH ACUTE"
            txt = Regex.Replace(txt, "&#x0*?139;", "Ĺ");
            txt = Regex.Replace(txt, "&#0*?313;", "Ĺ");
            txt = Regex.Replace(txt, "&Lacute;", "Ĺ");

            // "U+0013A", "LATIN SMALL LETTER L WITH ACUTE"
            txt = Regex.Replace(txt, "&#x0*?13A;", "ĺ");
            txt = Regex.Replace(txt, "&#0*?314;", "ĺ");
            txt = Regex.Replace(txt, "&lacute;", "ĺ");

            // "U+0013B", "LATIN CAPITAL LETTER L WITH CEDILLA"
            txt = Regex.Replace(txt, "&#x0*?13B;", "Ļ");
            txt = Regex.Replace(txt, "&#0*?315;", "Ļ");
            txt = Regex.Replace(txt, "&Lcedil;", "Ļ");

            // "U+0013C", "LATIN SMALL LETTER L WITH CEDILLA"
            txt = Regex.Replace(txt, "&#x0*?13C;", "ļ");
            txt = Regex.Replace(txt, "&#0*?316;", "ļ");
            txt = Regex.Replace(txt, "&lcedil;", "ļ");

            // "U+0013D", "LATIN CAPITAL LETTER L WITH CARON"
            txt = Regex.Replace(txt, "&#x0*?13D;", "Ľ");
            txt = Regex.Replace(txt, "&#0*?317;", "Ľ");
            txt = Regex.Replace(txt, "&Lcaron;", "Ľ");

            // "U+0013E", "LATIN SMALL LETTER L WITH CARON"
            txt = Regex.Replace(txt, "&#x0*?13E;", "ľ");
            txt = Regex.Replace(txt, "&#0*?318;", "ľ");
            txt = Regex.Replace(txt, "&lcaron;", "ľ");

            // "U+0013F", "LATIN CAPITAL LETTER L WITH MIDDLE DOT"
            txt = Regex.Replace(txt, "&#x0*?13F;", "Ŀ");
            txt = Regex.Replace(txt, "&#0*?319;", "Ŀ");
            txt = Regex.Replace(txt, "&Lmidot;", "Ŀ");

            // "U+00140", "LATIN SMALL LETTER L WITH MIDDLE DOT"
            txt = Regex.Replace(txt, "&#x0*?140;", "ŀ");
            txt = Regex.Replace(txt, "&#0*?320;", "ŀ");
            txt = Regex.Replace(txt, "&lmidot;", "ŀ");

            // "U+00141", "LATIN CAPITAL LETTER L WITH STROKE"
            txt = Regex.Replace(txt, "&#x0*?141;", "Ł");
            txt = Regex.Replace(txt, "&#0*?321;", "Ł");
            txt = Regex.Replace(txt, "&Lstrok;", "Ł");

            // "U+00142", "LATIN SMALL LETTER L WITH STROKE"
            txt = Regex.Replace(txt, "&#x0*?142;", "ł");
            txt = Regex.Replace(txt, "&#0*?322;", "ł");
            txt = Regex.Replace(txt, "&lstrok;", "ł");

            // "U+00143", "LATIN CAPITAL LETTER N WITH ACUTE"
            txt = Regex.Replace(txt, "&#x0*?143;", "Ń");
            txt = Regex.Replace(txt, "&#0*?323;", "Ń");
            txt = Regex.Replace(txt, "&Nacute;", "Ń");

            // "U+00144", "LATIN SMALL LETTER N WITH ACUTE"
            txt = Regex.Replace(txt, "&#x0*?144;", "ń");
            txt = Regex.Replace(txt, "&#0*?324;", "ń");
            txt = Regex.Replace(txt, "&nacute;", "ń");

            // "U+00145", "LATIN CAPITAL LETTER N WITH CEDILLA"
            txt = Regex.Replace(txt, "&#x0*?145;", "Ņ");
            txt = Regex.Replace(txt, "&#0*?325;", "Ņ");
            txt = Regex.Replace(txt, "&Ncedil;", "Ņ");

            // "U+00146", "LATIN SMALL LETTER N WITH CEDILLA"
            txt = Regex.Replace(txt, "&#x0*?146;", "ņ");
            txt = Regex.Replace(txt, "&#0*?326;", "ņ");
            txt = Regex.Replace(txt, "&ncedil;", "ņ");

            // "U+00147", "LATIN CAPITAL LETTER N WITH CARON"
            txt = Regex.Replace(txt, "&#x0*?147;", "Ň");
            txt = Regex.Replace(txt, "&#0*?327;", "Ň");
            txt = Regex.Replace(txt, "&Ncaron;", "Ň");

            // "U+00148", "LATIN SMALL LETTER N WITH CARON"
            txt = Regex.Replace(txt, "&#x0*?148;", "ň");
            txt = Regex.Replace(txt, "&#0*?328;", "ň");
            txt = Regex.Replace(txt, "&ncaron;", "ň");

            // "U+00149", "LATIN SMALL LETTER N PRECEDED BY APOSTROPHE"
            txt = Regex.Replace(txt, "&#x0*?149;", "ŉ");
            txt = Regex.Replace(txt, "&#0*?329;", "ŉ");
            txt = Regex.Replace(txt, "&napos;", "ŉ");

            // "U+0014A", "LATIN CAPITAL LETTER ENG"
            txt = Regex.Replace(txt, "&#x0*?14A;", "Ŋ");
            txt = Regex.Replace(txt, "&#0*?330;", "Ŋ");
            txt = Regex.Replace(txt, "&ENG;", "Ŋ");

            // "U+0014B", "LATIN SMALL LETTER ENG"
            txt = Regex.Replace(txt, "&#x0*?14B;", "ŋ");
            txt = Regex.Replace(txt, "&#0*?331;", "ŋ");
            txt = Regex.Replace(txt, "&eng;", "ŋ");

            // "U+0014C", "LATIN CAPITAL LETTER O WITH MACRON"
            txt = Regex.Replace(txt, "&#x0*?14C;", "Ō");
            txt = Regex.Replace(txt, "&#0*?332;", "Ō");
            txt = Regex.Replace(txt, "&Omacr;", "Ō");

            // "U+0014D", "LATIN SMALL LETTER O WITH MACRON"
            txt = Regex.Replace(txt, "&#x0*?14D;", "ō");
            txt = Regex.Replace(txt, "&#0*?333;", "ō");
            txt = Regex.Replace(txt, "&omacr;", "ō");

            // "U+00150", "LATIN CAPITAL LETTER O WITH DOUBLE ACUTE"
            txt = Regex.Replace(txt, "&#x0*?150;", "Ő");
            txt = Regex.Replace(txt, "&#0*?336;", "Ő");
            txt = Regex.Replace(txt, "&Odblac;", "Ő");

            // "U+00151", "LATIN SMALL LETTER O WITH DOUBLE ACUTE"
            txt = Regex.Replace(txt, "&#x0*?151;", "ő");
            txt = Regex.Replace(txt, "&#0*?337;", "ő");
            txt = Regex.Replace(txt, "&odblac;", "ő");

            // "U+00152", "LATIN CAPITAL LIGATURE OE"
            txt = Regex.Replace(txt, "&#x0*?152;", "Œ");
            txt = Regex.Replace(txt, "&#0*?338;", "Œ");
            txt = Regex.Replace(txt, "&OElig;", "Œ");

            // "U+00153", "LATIN SMALL LIGATURE OE"
            txt = Regex.Replace(txt, "&#x0*?153;", "œ");
            txt = Regex.Replace(txt, "&#0*?339;", "œ");
            txt = Regex.Replace(txt, "&oelig;", "œ");

            // "U+00154", "LATIN CAPITAL LETTER R WITH ACUTE"
            txt = Regex.Replace(txt, "&#x0*?154;", "Ŕ");
            txt = Regex.Replace(txt, "&#0*?340;", "Ŕ");
            txt = Regex.Replace(txt, "&Racute;", "Ŕ");

            // "U+00155", "LATIN SMALL LETTER R WITH ACUTE"
            txt = Regex.Replace(txt, "&#x0*?155;", "ŕ");
            txt = Regex.Replace(txt, "&#0*?341;", "ŕ");
            txt = Regex.Replace(txt, "&racute;", "ŕ");

            // "U+00156", "LATIN CAPITAL LETTER R WITH CEDILLA"
            txt = Regex.Replace(txt, "&#x0*?156;", "Ŗ");
            txt = Regex.Replace(txt, "&#0*?342;", "Ŗ");
            txt = Regex.Replace(txt, "&Rcedil;", "Ŗ");

            // "U+00157", "LATIN SMALL LETTER R WITH CEDILLA"
            txt = Regex.Replace(txt, "&#x0*?157;", "ŗ");
            txt = Regex.Replace(txt, "&#0*?343;", "ŗ");
            txt = Regex.Replace(txt, "&rcedil;", "ŗ");

            // "U+00158", "LATIN CAPITAL LETTER R WITH CARON"
            txt = Regex.Replace(txt, "&#x0*?158;", "Ř");
            txt = Regex.Replace(txt, "&#0*?344;", "Ř");
            txt = Regex.Replace(txt, "&Rcaron;", "Ř");

            // "U+00159", "LATIN SMALL LETTER R WITH CARON"
            txt = Regex.Replace(txt, "&#x0*?159;", "ř");
            txt = Regex.Replace(txt, "&#0*?345;", "ř");
            txt = Regex.Replace(txt, "&rcaron;", "ř");

            // "U+0015A", "LATIN CAPITAL LETTER S WITH ACUTE"
            txt = Regex.Replace(txt, "&#x0*?15A;", "Ś");
            txt = Regex.Replace(txt, "&#0*?346;", "Ś");
            txt = Regex.Replace(txt, "&Sacute;", "Ś");

            // "U+0015B", "LATIN SMALL LETTER S WITH ACUTE"
            txt = Regex.Replace(txt, "&#x0*?15B;", "ś");
            txt = Regex.Replace(txt, "&#0*?347;", "ś");
            txt = Regex.Replace(txt, "&sacute;", "ś");

            // "U+0015C", "LATIN CAPITAL LETTER S WITH CIRCUMFLEX"
            txt = Regex.Replace(txt, "&#x0*?15C;", "Ŝ");
            txt = Regex.Replace(txt, "&#0*?348;", "Ŝ");
            txt = Regex.Replace(txt, "&Scirc;", "Ŝ");

            // "U+0015D", "LATIN SMALL LETTER S WITH CIRCUMFLEX"
            txt = Regex.Replace(txt, "&#x0*?15D;", "ŝ");
            txt = Regex.Replace(txt, "&#0*?349;", "ŝ");
            txt = Regex.Replace(txt, "&scirc;", "ŝ");

            // "U+0015E", "LATIN CAPITAL LETTER S WITH CEDILLA"
            txt = Regex.Replace(txt, "&#x0*?15E;", "Ş");
            txt = Regex.Replace(txt, "&#0*?350;", "Ş");
            txt = Regex.Replace(txt, "&Scedil;", "Ş");

            // "U+0015F", "LATIN SMALL LETTER S WITH CEDILLA"
            txt = Regex.Replace(txt, "&#x0*?15F;", "ş");
            txt = Regex.Replace(txt, "&#0*?351;", "ş");
            txt = Regex.Replace(txt, "&scedil;", "ş");

            // "U+00160", "LATIN CAPITAL LETTER S WITH CARON"
            txt = Regex.Replace(txt, "&#x0*?160;", "Š");
            txt = Regex.Replace(txt, "&#0*?352;", "Š");
            txt = Regex.Replace(txt, "&Scaron;", "Š");

            // "U+00161", "LATIN SMALL LETTER S WITH CARON"
            txt = Regex.Replace(txt, "&#x0*?161;", "š");
            txt = Regex.Replace(txt, "&#0*?353;", "š");
            txt = Regex.Replace(txt, "&scaron;", "š");

            // "U+00162", "LATIN CAPITAL LETTER T WITH CEDILLA"
            txt = Regex.Replace(txt, "&#x0*?162;", "Ţ");
            txt = Regex.Replace(txt, "&#0*?354;", "Ţ");
            txt = Regex.Replace(txt, "&Tcedil;", "Ţ");

            // "U+00163", "LATIN SMALL LETTER T WITH CEDILLA"
            txt = Regex.Replace(txt, "&#x0*?163;", "ţ");
            txt = Regex.Replace(txt, "&#0*?355;", "ţ");
            txt = Regex.Replace(txt, "&tcedil;", "ţ");

            // "U+00164", "LATIN CAPITAL LETTER T WITH CARON"
            txt = Regex.Replace(txt, "&#x0*?164;", "Ť");
            txt = Regex.Replace(txt, "&#0*?356;", "Ť");
            txt = Regex.Replace(txt, "&Tcaron;", "Ť");

            // "U+00165", "LATIN SMALL LETTER T WITH CARON"
            txt = Regex.Replace(txt, "&#x0*?165;", "ť");
            txt = Regex.Replace(txt, "&#0*?357;", "ť");
            txt = Regex.Replace(txt, "&tcaron;", "ť");

            // "U+00166", "LATIN CAPITAL LETTER T WITH STROKE"
            txt = Regex.Replace(txt, "&#x0*?166;", "Ŧ");
            txt = Regex.Replace(txt, "&#0*?358;", "Ŧ");
            txt = Regex.Replace(txt, "&Tstrok;", "Ŧ");

            // "U+00167", "LATIN SMALL LETTER T WITH STROKE"
            txt = Regex.Replace(txt, "&#x0*?167;", "ŧ");
            txt = Regex.Replace(txt, "&#0*?359;", "ŧ");
            txt = Regex.Replace(txt, "&tstrok;", "ŧ");

            // "U+00168", "LATIN CAPITAL LETTER U WITH TILDE"
            txt = Regex.Replace(txt, "&#x0*?168;", "Ũ");
            txt = Regex.Replace(txt, "&#0*?360;", "Ũ");
            txt = Regex.Replace(txt, "&Utilde;", "Ũ");

            // "U+00169", "LATIN SMALL LETTER U WITH TILDE"
            txt = Regex.Replace(txt, "&#x0*?169;", "ũ");
            txt = Regex.Replace(txt, "&#0*?361;", "ũ");
            txt = Regex.Replace(txt, "&utilde;", "ũ");

            // "U+0016A", "LATIN CAPITAL LETTER U WITH MACRON"
            txt = Regex.Replace(txt, "&#x0*?16A;", "Ū");
            txt = Regex.Replace(txt, "&#0*?362;", "Ū");
            txt = Regex.Replace(txt, "&Umacr;", "Ū");

            // "U+0016B", "LATIN SMALL LETTER U WITH MACRON"
            txt = Regex.Replace(txt, "&#x0*?16B;", "ū");
            txt = Regex.Replace(txt, "&#0*?363;", "ū");
            txt = Regex.Replace(txt, "&umacr;", "ū");

            // "U+0016C", "LATIN CAPITAL LETTER U WITH BREVE"
            txt = Regex.Replace(txt, "&#x0*?16C;", "Ŭ");
            txt = Regex.Replace(txt, "&#0*?364;", "Ŭ");
            txt = Regex.Replace(txt, "&Ubreve;", "Ŭ");

            // "U+0016D", "LATIN SMALL LETTER U WITH BREVE"
            txt = Regex.Replace(txt, "&#x0*?16D;", "ŭ");
            txt = Regex.Replace(txt, "&#0*?365;", "ŭ");
            txt = Regex.Replace(txt, "&ubreve;", "ŭ");

            // "U+0016E", "LATIN CAPITAL LETTER U WITH RING ABOVE"
            txt = Regex.Replace(txt, "&#x0*?16E;", "Ů");
            txt = Regex.Replace(txt, "&#0*?366;", "Ů");
            txt = Regex.Replace(txt, "&Uring;", "Ů");

            // "U+0016F", "LATIN SMALL LETTER U WITH RING ABOVE"
            txt = Regex.Replace(txt, "&#x0*?16F;", "ů");
            txt = Regex.Replace(txt, "&#0*?367;", "ů");
            txt = Regex.Replace(txt, "&uring;", "ů");

            // "U+00170", "LATIN CAPITAL LETTER U WITH DOUBLE ACUTE"
            txt = Regex.Replace(txt, "&#x0*?170;", "Ű");
            txt = Regex.Replace(txt, "&#0*?368;", "Ű");
            txt = Regex.Replace(txt, "&Udblac;", "Ű");

            // "U+00171", "LATIN SMALL LETTER U WITH DOUBLE ACUTE"
            txt = Regex.Replace(txt, "&#x0*?171;", "ű");
            txt = Regex.Replace(txt, "&#0*?369;", "ű");
            txt = Regex.Replace(txt, "&udblac;", "ű");

            // "U+00172", "LATIN CAPITAL LETTER U WITH OGONEK"
            txt = Regex.Replace(txt, "&#x0*?172;", "Ų");
            txt = Regex.Replace(txt, "&#0*?370;", "Ų");
            txt = Regex.Replace(txt, "&Uogon;", "Ų");

            // "U+00173", "LATIN SMALL LETTER U WITH OGONEK"
            txt = Regex.Replace(txt, "&#x0*?173;", "ų");
            txt = Regex.Replace(txt, "&#0*?371;", "ų");
            txt = Regex.Replace(txt, "&uogon;", "ų");

            // "U+00174", "LATIN CAPITAL LETTER W WITH CIRCUMFLEX"
            txt = Regex.Replace(txt, "&#x0*?174;", "Ŵ");
            txt = Regex.Replace(txt, "&#0*?372;", "Ŵ");
            txt = Regex.Replace(txt, "&Wcirc;", "Ŵ");

            // "U+00175", "LATIN SMALL LETTER W WITH CIRCUMFLEX"
            txt = Regex.Replace(txt, "&#x0*?175;", "ŵ");
            txt = Regex.Replace(txt, "&#0*?373;", "ŵ");
            txt = Regex.Replace(txt, "&wcirc;", "ŵ");

            // "U+00176", "LATIN CAPITAL LETTER Y WITH CIRCUMFLEX"
            txt = Regex.Replace(txt, "&#x0*?176;", "Ŷ");
            txt = Regex.Replace(txt, "&#0*?374;", "Ŷ");
            txt = Regex.Replace(txt, "&Ycirc;", "Ŷ");

            // "U+00177", "LATIN SMALL LETTER Y WITH CIRCUMFLEX"
            txt = Regex.Replace(txt, "&#x0*?177;", "ŷ");
            txt = Regex.Replace(txt, "&#0*?375;", "ŷ");
            txt = Regex.Replace(txt, "&ycirc;", "ŷ");

            // "U+00178", "LATIN CAPITAL LETTER Y WITH DIAERESIS"
            txt = Regex.Replace(txt, "&#x0*?178;", "Ÿ");
            txt = Regex.Replace(txt, "&#0*?376;", "Ÿ");
            txt = Regex.Replace(txt, "&Yuml;", "Ÿ");

            // "U+00179", "LATIN CAPITAL LETTER Z WITH ACUTE"
            txt = Regex.Replace(txt, "&#x0*?179;", "Ź");
            txt = Regex.Replace(txt, "&#0*?377;", "Ź");
            txt = Regex.Replace(txt, "&Zacute;", "Ź");

            // "U+0017A", "LATIN SMALL LETTER Z WITH ACUTE"
            txt = Regex.Replace(txt, "&#x0*?17A;", "ź");
            txt = Regex.Replace(txt, "&#0*?378;", "ź");
            txt = Regex.Replace(txt, "&zacute;", "ź");

            // "U+0017B", "LATIN CAPITAL LETTER Z WITH DOT ABOVE"
            txt = Regex.Replace(txt, "&#x0*?17B;", "Ż");
            txt = Regex.Replace(txt, "&#0*?379;", "Ż");
            txt = Regex.Replace(txt, "&Zdot;", "Ż");

            // "U+0017C", "LATIN SMALL LETTER Z WITH DOT ABOVE"
            txt = Regex.Replace(txt, "&#x0*?17C;", "ż");
            txt = Regex.Replace(txt, "&#0*?380;", "ż");
            txt = Regex.Replace(txt, "&zdot;", "ż");

            // "U+0017D", "LATIN CAPITAL LETTER Z WITH CARON"
            txt = Regex.Replace(txt, "&#x0*?17D;", "Ž");
            txt = Regex.Replace(txt, "&#0*?381;", "Ž");
            txt = Regex.Replace(txt, "&Zcaron;", "Ž");

            // "U+0017E", "LATIN SMALL LETTER Z WITH CARON"
            txt = Regex.Replace(txt, "&#x0*?17E;", "ž");
            txt = Regex.Replace(txt, "&#0*?382;", "ž");
            txt = Regex.Replace(txt, "&zcaron;", "ž");

            // "U+00192", "LATIN SMALL LETTER F WITH HOOK"
            txt = Regex.Replace(txt, "&#x0*?192;", "ƒ");
            txt = Regex.Replace(txt, "&#0*?402;", "ƒ");
            txt = Regex.Replace(txt, "&fnof;", "ƒ");

            // "U+001B5", "LATIN CAPITAL LETTER Z WITH STROKE"
            txt = Regex.Replace(txt, "&#x0*?1B5;", "Ƶ");
            txt = Regex.Replace(txt, "&#0*?437;", "Ƶ");
            txt = Regex.Replace(txt, "&imped;", "Ƶ");

            // "U+001F5", "LATIN SMALL LETTER G WITH ACUTE"
            txt = Regex.Replace(txt, "&#x0*?1F5;", "ǵ");
            txt = Regex.Replace(txt, "&#0*?501;", "ǵ");
            txt = Regex.Replace(txt, "&gacute;", "ǵ");

            // "U+00237", "LATIN SMALL LETTER DOTLESS J"
            txt = Regex.Replace(txt, "&#x0*?237;", "ȷ");
            txt = Regex.Replace(txt, "&#0*?567;", "ȷ");
            txt = Regex.Replace(txt, "&jmath;", "ȷ");

            // "U+002C6", "MODIFIER LETTER CIRCUMFLEX ACCENT"
            txt = Regex.Replace(txt, "&#x0*?2C6;", "ˆ");
            txt = Regex.Replace(txt, "&#0*?710;", "ˆ");
            txt = Regex.Replace(txt, "&circ;", "ˆ");

            // "U+002C7", "CARON"
            txt = Regex.Replace(txt, "&#x0*?2C7;", "ˇ");
            txt = Regex.Replace(txt, "&#0*?711;", "ˇ");
            txt = Regex.Replace(txt, "&caron;", "ˇ");
            txt = Regex.Replace(txt, "&Hacek;", "ˇ");

            // "U+002D8", "BREVE"
            txt = Regex.Replace(txt, "&#x0*?2D8;", "˘");
            txt = Regex.Replace(txt, "&#0*?728;", "˘");
            txt = Regex.Replace(txt, "&breve;", "˘");
            txt = Regex.Replace(txt, "&Breve;", "˘");

            // "U+002D9", "DOT ABOVE"
            txt = Regex.Replace(txt, "&#x0*?2D9;", "˙");
            txt = Regex.Replace(txt, "&#0*?729;", "˙");
            txt = Regex.Replace(txt, "&dot;", "˙");
            txt = Regex.Replace(txt, "&DiacriticalDot;", "˙");

            // "U+002DA", "RING ABOVE"
            txt = Regex.Replace(txt, "&#x0*?2DA;", "˚");
            txt = Regex.Replace(txt, "&#0*?730;", "˚");
            txt = Regex.Replace(txt, "&ring;", "˚");

            // "U+002DB", "OGONEK"
            txt = Regex.Replace(txt, "&#x0*?2DB;", "˛");
            txt = Regex.Replace(txt, "&#0*?731;", "˛");
            txt = Regex.Replace(txt, "&ogon;", "˛");

            // "U+002DC", "SMALL TILDE"
            txt = Regex.Replace(txt, "&#x0*?2DC;", "˜");
            txt = Regex.Replace(txt, "&#0*?732;", "˜");
            txt = Regex.Replace(txt, "&tilde;", "˜");
            txt = Regex.Replace(txt, "&DiacriticalTilde;", "˜");

            // "U+002DD", "DOUBLE ACUTE ACCENT"
            txt = Regex.Replace(txt, "&#x0*?2DD;", "˝");
            txt = Regex.Replace(txt, "&#0*?733;", "˝");
            txt = Regex.Replace(txt, "&dblac;", "˝");
            txt = Regex.Replace(txt, "&DiacriticalDoubleAcute;", "˝");

            // "U+00311", "COMBINING INVERTED BREVE"
            txt = Regex.Replace(txt, "&#x0*?311;", "̑");
            txt = Regex.Replace(txt, "&#0*?785;", "̑");
            txt = Regex.Replace(txt, "&DownBreve;", "̑");

            // "U+00332", "COMBINING LOW LINE"
            txt = Regex.Replace(txt, "&#x0*?332;", "̲");
            txt = Regex.Replace(txt, "&#0*?818;", "̲");
            txt = Regex.Replace(txt, "&UnderBar;", "̲");

            // "U+00391", "GREEK CAPITAL LETTER ALPHA"
            txt = Regex.Replace(txt, "&#x0*?391;", "Α");
            txt = Regex.Replace(txt, "&#0*?913;", "Α");
            txt = Regex.Replace(txt, "&Alpha;", "Α");

            // "U+00392", "GREEK CAPITAL LETTER BETA"
            txt = Regex.Replace(txt, "&#x0*?392;", "Β");
            txt = Regex.Replace(txt, "&#0*?914;", "Β");
            txt = Regex.Replace(txt, "&Beta;", "Β");

            // "U+00393", "GREEK CAPITAL LETTER GAMMA"
            txt = Regex.Replace(txt, "&#x0*?393;", "Γ");
            txt = Regex.Replace(txt, "&#0*?915;", "Γ");
            txt = Regex.Replace(txt, "&Gamma;", "Γ");

            // "U+00394", "GREEK CAPITAL LETTER DELTA"
            txt = Regex.Replace(txt, "&#x0*?394;", "Δ");
            txt = Regex.Replace(txt, "&#0*?916;", "Δ");
            txt = Regex.Replace(txt, "&Delta;", "Δ");

            // "U+00395", "GREEK CAPITAL LETTER EPSILON"
            txt = Regex.Replace(txt, "&#x0*?395;", "Ε");
            txt = Regex.Replace(txt, "&#0*?917;", "Ε");
            txt = Regex.Replace(txt, "&Epsilon;", "Ε");

            // "U+00396", "GREEK CAPITAL LETTER ZETA"
            txt = Regex.Replace(txt, "&#x0*?396;", "Ζ");
            txt = Regex.Replace(txt, "&#0*?918;", "Ζ");
            txt = Regex.Replace(txt, "&Zeta;", "Ζ");

            // "U+00397", "GREEK CAPITAL LETTER ETA"
            txt = Regex.Replace(txt, "&#x0*?397;", "Η");
            txt = Regex.Replace(txt, "&#0*?919;", "Η");
            txt = Regex.Replace(txt, "&Eta;", "Η");

            // "U+00398", "GREEK CAPITAL LETTER THETA"
            txt = Regex.Replace(txt, "&#x0*?398;", "Θ");
            txt = Regex.Replace(txt, "&#0*?920;", "Θ");
            txt = Regex.Replace(txt, "&Theta;", "Θ");

            // "U+00399", "GREEK CAPITAL LETTER IOTA"
            txt = Regex.Replace(txt, "&#x0*?399;", "Ι");
            txt = Regex.Replace(txt, "&#0*?921;", "Ι");
            txt = Regex.Replace(txt, "&Iota;", "Ι");

            // "U+0039A", "GREEK CAPITAL LETTER KAPPA"
            txt = Regex.Replace(txt, "&#x0*?39A;", "Κ");
            txt = Regex.Replace(txt, "&#0*?922;", "Κ");
            txt = Regex.Replace(txt, "&Kappa;", "Κ");

            // "U+0039B", "GREEK CAPITAL LETTER LAMDA"
            txt = Regex.Replace(txt, "&#x0*?39B;", "Λ");
            txt = Regex.Replace(txt, "&#0*?923;", "Λ");
            txt = Regex.Replace(txt, "&Lambda;", "Λ");

            // "U+0039C", "GREEK CAPITAL LETTER MU"
            txt = Regex.Replace(txt, "&#x0*?39C;", "Μ");
            txt = Regex.Replace(txt, "&#0*?924;", "Μ");
            txt = Regex.Replace(txt, "&Mu;", "Μ");

            // "U+0039D", "GREEK CAPITAL LETTER NU"
            txt = Regex.Replace(txt, "&#x0*?39D;", "Ν");
            txt = Regex.Replace(txt, "&#0*?925;", "Ν");
            txt = Regex.Replace(txt, "&Nu;", "Ν");

            // "U+0039E", "GREEK CAPITAL LETTER XI"
            txt = Regex.Replace(txt, "&#x0*?39E;", "Ξ");
            txt = Regex.Replace(txt, "&#0*?926;", "Ξ");
            txt = Regex.Replace(txt, "&Xi;", "Ξ");

            // "U+0039F", "GREEK CAPITAL LETTER OMICRON"
            txt = Regex.Replace(txt, "&#x0*?39F;", "Ο");
            txt = Regex.Replace(txt, "&#0*?927;", "Ο");
            txt = Regex.Replace(txt, "&Omicron;", "Ο");

            // "U+003A0", "GREEK CAPITAL LETTER PI"
            txt = Regex.Replace(txt, "&#x0*?3A0;", "Π");
            txt = Regex.Replace(txt, "&#0*?928;", "Π");
            txt = Regex.Replace(txt, "&Pi;", "Π");

            // "U+003A1", "GREEK CAPITAL LETTER RHO"
            txt = Regex.Replace(txt, "&#x0*?3A1;", "Ρ");
            txt = Regex.Replace(txt, "&#0*?929;", "Ρ");
            txt = Regex.Replace(txt, "&Rho;", "Ρ");

            // "U+003A3", "GREEK CAPITAL LETTER SIGMA"
            txt = Regex.Replace(txt, "&#x0*?3A3;", "Σ");
            txt = Regex.Replace(txt, "&#0*?931;", "Σ");
            txt = Regex.Replace(txt, "&Sigma;", "Σ");

            // "U+003A4", "GREEK CAPITAL LETTER TAU"
            txt = Regex.Replace(txt, "&#x0*?3A4;", "Τ");
            txt = Regex.Replace(txt, "&#0*?932;", "Τ");
            txt = Regex.Replace(txt, "&Tau;", "Τ");

            // "U+003A5", "GREEK CAPITAL LETTER UPSILON"
            txt = Regex.Replace(txt, "&#x0*?3A5;", "Υ");
            txt = Regex.Replace(txt, "&#0*?933;", "Υ");
            txt = Regex.Replace(txt, "&Upsilon;", "Υ");

            // "U+003A6", "GREEK CAPITAL LETTER PHI"
            txt = Regex.Replace(txt, "&#x0*?3A6;", "Φ");
            txt = Regex.Replace(txt, "&#0*?934;", "Φ");
            txt = Regex.Replace(txt, "&Phi;", "Φ");

            // "U+003A7", "GREEK CAPITAL LETTER CHI"
            txt = Regex.Replace(txt, "&#x0*?3A7;", "Χ");
            txt = Regex.Replace(txt, "&#0*?935;", "Χ");
            txt = Regex.Replace(txt, "&Chi;", "Χ");

            // "U+003A8", "GREEK CAPITAL LETTER PSI"
            txt = Regex.Replace(txt, "&#x0*?3A8;", "Ψ");
            txt = Regex.Replace(txt, "&#0*?936;", "Ψ");
            txt = Regex.Replace(txt, "&Psi;", "Ψ");

            // "U+003A9", "GREEK CAPITAL LETTER OMEGA"
            txt = Regex.Replace(txt, "&#x0*?3A9;", "Ω");
            txt = Regex.Replace(txt, "&#0*?937;", "Ω");
            txt = Regex.Replace(txt, "&Omega;", "Ω");

            // "U+003B1", "GREEK SMALL LETTER ALPHA"
            txt = Regex.Replace(txt, "&#x0*?3B1;", "α");
            txt = Regex.Replace(txt, "&#0*?945;", "α");
            txt = Regex.Replace(txt, "&alpha;", "α");

            // "U+003B2", "GREEK SMALL LETTER BETA"
            txt = Regex.Replace(txt, "&#x0*?3B2;", "β");
            txt = Regex.Replace(txt, "&#0*?946;", "β");
            txt = Regex.Replace(txt, "&beta;", "β");

            // "U+003B3", "GREEK SMALL LETTER GAMMA"
            txt = Regex.Replace(txt, "&#x0*?3B3;", "γ");
            txt = Regex.Replace(txt, "&#0*?947;", "γ");
            txt = Regex.Replace(txt, "&gamma;", "γ");

            // "U+003B4", "GREEK SMALL LETTER DELTA"
            txt = Regex.Replace(txt, "&#x0*?3B4;", "δ");
            txt = Regex.Replace(txt, "&#0*?948;", "δ");
            txt = Regex.Replace(txt, "&delta;", "δ");

            // "U+003B5", "GREEK SMALL LETTER EPSILON"
            txt = Regex.Replace(txt, "&#x0*?3B5;", "ε");
            txt = Regex.Replace(txt, "&#0*?949;", "ε");
            txt = Regex.Replace(txt, "&epsiv;", "ε");
            txt = Regex.Replace(txt, "&varepsilon;", "ε");
            txt = Regex.Replace(txt, "&epsilon;", "ε");

            // "U+003B6", "GREEK SMALL LETTER ZETA"
            txt = Regex.Replace(txt, "&#x0*?3B6;", "ζ");
            txt = Regex.Replace(txt, "&#0*?950;", "ζ");
            txt = Regex.Replace(txt, "&zeta;", "ζ");

            // "U+003B7", "GREEK SMALL LETTER ETA"
            txt = Regex.Replace(txt, "&#x0*?3B7;", "η");
            txt = Regex.Replace(txt, "&#0*?951;", "η");
            txt = Regex.Replace(txt, "&eta;", "η");

            // "U+003B8", "GREEK SMALL LETTER THETA"
            txt = Regex.Replace(txt, "&#x0*?3B8;", "θ");
            txt = Regex.Replace(txt, "&#0*?952;", "θ");
            txt = Regex.Replace(txt, "&theta;", "θ");

            // "U+003B9", "GREEK SMALL LETTER IOTA"
            txt = Regex.Replace(txt, "&#x0*?3B9;", "ι");
            txt = Regex.Replace(txt, "&#0*?953;", "ι");
            txt = Regex.Replace(txt, "&iota;", "ι");

            // "U+003BA", "GREEK SMALL LETTER KAPPA"
            txt = Regex.Replace(txt, "&#x0*?3BA;", "κ");
            txt = Regex.Replace(txt, "&#0*?954;", "κ");
            txt = Regex.Replace(txt, "&kappa;", "κ");

            // "U+003BB", "GREEK SMALL LETTER LAMDA"
            txt = Regex.Replace(txt, "&#x0*?3BB;", "λ");
            txt = Regex.Replace(txt, "&#0*?955;", "λ");
            txt = Regex.Replace(txt, "&lambda;", "λ");

            // "U+003BC", "GREEK SMALL LETTER MU"
            txt = Regex.Replace(txt, "&#x0*?3BC;", "μ");
            txt = Regex.Replace(txt, "&#0*?956;", "μ");
            txt = Regex.Replace(txt, "&mu;", "μ");

            // "U+003BD", "GREEK SMALL LETTER NU"
            txt = Regex.Replace(txt, "&#x0*?3BD;", "ν");
            txt = Regex.Replace(txt, "&#0*?957;", "ν");
            txt = Regex.Replace(txt, "&nu;", "ν");

            // "U+003BE", "GREEK SMALL LETTER XI"
            txt = Regex.Replace(txt, "&#x0*?3BE;", "ξ");
            txt = Regex.Replace(txt, "&#0*?958;", "ξ");
            txt = Regex.Replace(txt, "&xi;", "ξ");

            // "U+003BF", "GREEK SMALL LETTER OMICRON"
            txt = Regex.Replace(txt, "&#x0*?3BF;", "ο");
            txt = Regex.Replace(txt, "&#0*?959;", "ο");
            txt = Regex.Replace(txt, "&omicron;", "ο");

            // "U+003C0", "GREEK SMALL LETTER PI"
            txt = Regex.Replace(txt, "&#x0*?3C0;", "π");
            txt = Regex.Replace(txt, "&#0*?960;", "π");
            txt = Regex.Replace(txt, "&pi;", "π");

            // "U+003C1", "GREEK SMALL LETTER RHO"
            txt = Regex.Replace(txt, "&#x0*?3C1;", "ρ");
            txt = Regex.Replace(txt, "&#0*?961;", "ρ");
            txt = Regex.Replace(txt, "&rho;", "ρ");

            // "U+003C2", "GREEK SMALL LETTER FINAL SIGMA"
            txt = Regex.Replace(txt, "&#x0*?3C2;", "ς");
            txt = Regex.Replace(txt, "&#0*?962;", "ς");
            txt = Regex.Replace(txt, "&sigmav;", "ς");
            txt = Regex.Replace(txt, "&varsigma;", "ς");
            txt = Regex.Replace(txt, "&sigmaf;", "ς");

            // "U+003C3", "GREEK SMALL LETTER SIGMA"
            txt = Regex.Replace(txt, "&#x0*?3C3;", "σ");
            txt = Regex.Replace(txt, "&#0*?963;", "σ");
            txt = Regex.Replace(txt, "&sigma;", "σ");

            // "U+003C4", "GREEK SMALL LETTER TAU"
            txt = Regex.Replace(txt, "&#x0*?3C4;", "τ");
            txt = Regex.Replace(txt, "&#0*?964;", "τ");
            txt = Regex.Replace(txt, "&tau;", "τ");

            // "U+003C5", "GREEK SMALL LETTER UPSILON"
            txt = Regex.Replace(txt, "&#x0*?3C5;", "υ");
            txt = Regex.Replace(txt, "&#0*?965;", "υ");
            txt = Regex.Replace(txt, "&upsi;", "υ");
            txt = Regex.Replace(txt, "&upsilon;", "υ");

            // "U+003C6", "GREEK SMALL LETTER PHI"
            txt = Regex.Replace(txt, "&#x0*?3C6;", "φ");
            txt = Regex.Replace(txt, "&#0*?966;", "φ");
            txt = Regex.Replace(txt, "&phi;", "φ");
            txt = Regex.Replace(txt, "&phiv;", "φ");
            txt = Regex.Replace(txt, "&varphi;", "φ");

            // "U+003C7", "GREEK SMALL LETTER CHI"
            txt = Regex.Replace(txt, "&#x0*?3C7;", "χ");
            txt = Regex.Replace(txt, "&#0*?967;", "χ");
            txt = Regex.Replace(txt, "&chi;", "χ");

            // "U+003C8", "GREEK SMALL LETTER PSI"
            txt = Regex.Replace(txt, "&#x0*?3C8;", "ψ");
            txt = Regex.Replace(txt, "&#0*?968;", "ψ");
            txt = Regex.Replace(txt, "&psi;", "ψ");

            // "U+003C9", "GREEK SMALL LETTER OMEGA"
            txt = Regex.Replace(txt, "&#x0*?3C9;", "ω");
            txt = Regex.Replace(txt, "&#0*?969;", "ω");
            txt = Regex.Replace(txt, "&omega;", "ω");

            // "U+003D1", "GREEK THETA SYMBOL"
            txt = Regex.Replace(txt, "&#x0*?3D1;", "ϑ");
            txt = Regex.Replace(txt, "&#0*?977;", "ϑ");
            txt = Regex.Replace(txt, "&thetav;", "ϑ");
            txt = Regex.Replace(txt, "&vartheta;", "ϑ");
            txt = Regex.Replace(txt, "&thetasym;", "ϑ");

            // "U+003D2", "GREEK UPSILON WITH HOOK SYMBOL"
            txt = Regex.Replace(txt, "&#x0*?3D2;", "ϒ");
            txt = Regex.Replace(txt, "&#0*?978;", "ϒ");
            txt = Regex.Replace(txt, "&Upsi;", "ϒ");
            txt = Regex.Replace(txt, "&upsih;", "ϒ");

            // "U+003D5", "GREEK PHI SYMBOL"
            txt = Regex.Replace(txt, "&#x0*?3D5;", "ϕ");
            txt = Regex.Replace(txt, "&#0*?981;", "ϕ");
            txt = Regex.Replace(txt, "&straightphi;", "ϕ");

            // "U+003D6", "GREEK PI SYMBOL"
            txt = Regex.Replace(txt, "&#x0*?3D6;", "ϖ");
            txt = Regex.Replace(txt, "&#0*?982;", "ϖ");
            txt = Regex.Replace(txt, "&piv;", "ϖ");
            txt = Regex.Replace(txt, "&varpi;", "ϖ");

            // "U+003DC", "GREEK LETTER DIGAMMA"
            txt = Regex.Replace(txt, "&#x0*?3DC;", "Ϝ");
            txt = Regex.Replace(txt, "&#0*?988;", "Ϝ");
            txt = Regex.Replace(txt, "&Gammad;", "Ϝ");

            // "U+003DD", "GREEK SMALL LETTER DIGAMMA"
            txt = Regex.Replace(txt, "&#x0*?3DD;", "ϝ");
            txt = Regex.Replace(txt, "&#0*?989;", "ϝ");
            txt = Regex.Replace(txt, "&gammad;", "ϝ");
            txt = Regex.Replace(txt, "&digamma;", "ϝ");

            // "U+003F0", "GREEK KAPPA SYMBOL"
            txt = Regex.Replace(txt, "&#x0*?3F0;", "ϰ");
            txt = Regex.Replace(txt, "&#0*?1008;", "ϰ");
            txt = Regex.Replace(txt, "&kappav;", "ϰ");
            txt = Regex.Replace(txt, "&varkappa;", "ϰ");

            // "U+003F1", "GREEK RHO SYMBOL"
            txt = Regex.Replace(txt, "&#x0*?3F1;", "ϱ");
            txt = Regex.Replace(txt, "&#0*?1009;", "ϱ");
            txt = Regex.Replace(txt, "&rhov;", "ϱ");
            txt = Regex.Replace(txt, "&varrho;", "ϱ");

            // "U+003F5", "GREEK LUNATE EPSILON SYMBOL"
            txt = Regex.Replace(txt, "&#x0*?3F5;", "ϵ");
            txt = Regex.Replace(txt, "&#0*?1013;", "ϵ");
            txt = Regex.Replace(txt, "&epsi;", "ϵ");
            txt = Regex.Replace(txt, "&straightepsilon;", "ϵ");

            // "U+003F6", "GREEK REVERSED LUNATE EPSILON SYMBOL"
            txt = Regex.Replace(txt, "&#x0*?3F6;", "϶");
            txt = Regex.Replace(txt, "&#0*?1014;", "϶");
            txt = Regex.Replace(txt, "&bepsi;", "϶");
            txt = Regex.Replace(txt, "&backepsilon;", "϶");

            // "U+00401", "CYRILLIC CAPITAL LETTER IO"
            txt = Regex.Replace(txt, "&#x0*?401;", "Ё");
            txt = Regex.Replace(txt, "&#0*?1025;", "Ё");
            txt = Regex.Replace(txt, "&IOcy;", "Ё");

            // "U+00402", "CYRILLIC CAPITAL LETTER DJE"
            txt = Regex.Replace(txt, "&#x0*?402;", "Ђ");
            txt = Regex.Replace(txt, "&#0*?1026;", "Ђ");
            txt = Regex.Replace(txt, "&DJcy;", "Ђ");

            // "U+00403", "CYRILLIC CAPITAL LETTER GJE"
            txt = Regex.Replace(txt, "&#x0*?403;", "Ѓ");
            txt = Regex.Replace(txt, "&#0*?1027;", "Ѓ");
            txt = Regex.Replace(txt, "&GJcy;", "Ѓ");

            // "U+00404", "CYRILLIC CAPITAL LETTER UKRAINIAN IE"
            txt = Regex.Replace(txt, "&#x0*?404;", "Є");
            txt = Regex.Replace(txt, "&#0*?1028;", "Є");
            txt = Regex.Replace(txt, "&Jukcy;", "Є");

            // "U+00405", "CYRILLIC CAPITAL LETTER DZE"
            txt = Regex.Replace(txt, "&#x0*?405;", "Ѕ");
            txt = Regex.Replace(txt, "&#0*?1029;", "Ѕ");
            txt = Regex.Replace(txt, "&DScy;", "Ѕ");

            // "U+00406", "CYRILLIC CAPITAL LETTER BYELORUSSIAN-UKRAINIAN I"
            txt = Regex.Replace(txt, "&#x0*?406;", "І");
            txt = Regex.Replace(txt, "&#0*?1030;", "І");
            txt = Regex.Replace(txt, "&Iukcy;", "І");

            // "U+00407", "CYRILLIC CAPITAL LETTER YI"
            txt = Regex.Replace(txt, "&#x0*?407;", "Ї");
            txt = Regex.Replace(txt, "&#0*?1031;", "Ї");
            txt = Regex.Replace(txt, "&YIcy;", "Ї");

            // "U+00408", "CYRILLIC CAPITAL LETTER JE"
            txt = Regex.Replace(txt, "&#x0*?408;", "Ј");
            txt = Regex.Replace(txt, "&#0*?1032;", "Ј");
            txt = Regex.Replace(txt, "&Jsercy;", "Ј");

            // "U+00409", "CYRILLIC CAPITAL LETTER LJE"
            txt = Regex.Replace(txt, "&#x0*?409;", "Љ");
            txt = Regex.Replace(txt, "&#0*?1033;", "Љ");
            txt = Regex.Replace(txt, "&LJcy;", "Љ");

            // "U+0040A", "CYRILLIC CAPITAL LETTER NJE"
            txt = Regex.Replace(txt, "&#x0*?40A;", "Њ");
            txt = Regex.Replace(txt, "&#0*?1034;", "Њ");
            txt = Regex.Replace(txt, "&NJcy;", "Њ");

            // "U+0040B", "CYRILLIC CAPITAL LETTER TSHE"
            txt = Regex.Replace(txt, "&#x0*?40B;", "Ћ");
            txt = Regex.Replace(txt, "&#0*?1035;", "Ћ");
            txt = Regex.Replace(txt, "&TSHcy;", "Ћ");

            // "U+0040C", "CYRILLIC CAPITAL LETTER KJE"
            txt = Regex.Replace(txt, "&#x0*?40C;", "Ќ");
            txt = Regex.Replace(txt, "&#0*?1036;", "Ќ");
            txt = Regex.Replace(txt, "&KJcy;", "Ќ");

            // "U+0040E", "CYRILLIC CAPITAL LETTER SHORT U"
            txt = Regex.Replace(txt, "&#x0*?40E;", "Ў");
            txt = Regex.Replace(txt, "&#0*?1038;", "Ў");
            txt = Regex.Replace(txt, "&Ubrcy;", "Ў");

            // "U+0040F", "CYRILLIC CAPITAL LETTER DZHE"
            txt = Regex.Replace(txt, "&#x0*?40F;", "Џ");
            txt = Regex.Replace(txt, "&#0*?1039;", "Џ");
            txt = Regex.Replace(txt, "&DZcy;", "Џ");

            // "U+00410", "CYRILLIC CAPITAL LETTER A"
            txt = Regex.Replace(txt, "&#x0*?410;", "А");
            txt = Regex.Replace(txt, "&#0*?1040;", "А");
            txt = Regex.Replace(txt, "&Acy;", "А");

            // "U+00411", "CYRILLIC CAPITAL LETTER BE"
            txt = Regex.Replace(txt, "&#x0*?411;", "Б");
            txt = Regex.Replace(txt, "&#0*?1041;", "Б");
            txt = Regex.Replace(txt, "&Bcy;", "Б");

            // "U+00412", "CYRILLIC CAPITAL LETTER VE"
            txt = Regex.Replace(txt, "&#x0*?412;", "В");
            txt = Regex.Replace(txt, "&#0*?1042;", "В");
            txt = Regex.Replace(txt, "&Vcy;", "В");

            // "U+00413", "CYRILLIC CAPITAL LETTER GHE"
            txt = Regex.Replace(txt, "&#x0*?413;", "Г");
            txt = Regex.Replace(txt, "&#0*?1043;", "Г");
            txt = Regex.Replace(txt, "&Gcy;", "Г");

            // "U+00414", "CYRILLIC CAPITAL LETTER DE"
            txt = Regex.Replace(txt, "&#x0*?414;", "Д");
            txt = Regex.Replace(txt, "&#0*?1044;", "Д");
            txt = Regex.Replace(txt, "&Dcy;", "Д");

            // "U+00415", "CYRILLIC CAPITAL LETTER IE"
            txt = Regex.Replace(txt, "&#x0*?415;", "Е");
            txt = Regex.Replace(txt, "&#0*?1045;", "Е");
            txt = Regex.Replace(txt, "&IEcy;", "Е");

            // "U+00416", "CYRILLIC CAPITAL LETTER ZHE"
            txt = Regex.Replace(txt, "&#x0*?416;", "Ж");
            txt = Regex.Replace(txt, "&#0*?1046;", "Ж");
            txt = Regex.Replace(txt, "&ZHcy;", "Ж");

            // "U+00417", "CYRILLIC CAPITAL LETTER ZE"
            txt = Regex.Replace(txt, "&#x0*?417;", "З");
            txt = Regex.Replace(txt, "&#0*?1047;", "З");
            txt = Regex.Replace(txt, "&Zcy;", "З");

            // "U+00418", "CYRILLIC CAPITAL LETTER I"
            txt = Regex.Replace(txt, "&#x0*?418;", "И");
            txt = Regex.Replace(txt, "&#0*?1048;", "И");
            txt = Regex.Replace(txt, "&Icy;", "И");

            // "U+00419", "CYRILLIC CAPITAL LETTER SHORT I"
            txt = Regex.Replace(txt, "&#x0*?419;", "Й");
            txt = Regex.Replace(txt, "&#0*?1049;", "Й");
            txt = Regex.Replace(txt, "&Jcy;", "Й");

            // "U+0041A", "CYRILLIC CAPITAL LETTER KA"
            txt = Regex.Replace(txt, "&#x0*?41A;", "К");
            txt = Regex.Replace(txt, "&#0*?1050;", "К");
            txt = Regex.Replace(txt, "&Kcy;", "К");

            // "U+0041B", "CYRILLIC CAPITAL LETTER EL"
            txt = Regex.Replace(txt, "&#x0*?41B;", "Л");
            txt = Regex.Replace(txt, "&#0*?1051;", "Л");
            txt = Regex.Replace(txt, "&Lcy;", "Л");

            // "U+0041C", "CYRILLIC CAPITAL LETTER EM"
            txt = Regex.Replace(txt, "&#x0*?41C;", "М");
            txt = Regex.Replace(txt, "&#0*?1052;", "М");
            txt = Regex.Replace(txt, "&Mcy;", "М");

            // "U+0041D", "CYRILLIC CAPITAL LETTER EN"
            txt = Regex.Replace(txt, "&#x0*?41D;", "Н");
            txt = Regex.Replace(txt, "&#0*?1053;", "Н");
            txt = Regex.Replace(txt, "&Ncy;", "Н");

            // "U+0041E", "CYRILLIC CAPITAL LETTER O"
            txt = Regex.Replace(txt, "&#x0*?41E;", "О");
            txt = Regex.Replace(txt, "&#0*?1054;", "О");
            txt = Regex.Replace(txt, "&Ocy;", "О");

            // "U+0041F", "CYRILLIC CAPITAL LETTER PE"
            txt = Regex.Replace(txt, "&#x0*?41F;", "П");
            txt = Regex.Replace(txt, "&#0*?1055;", "П");
            txt = Regex.Replace(txt, "&Pcy;", "П");

            // "U+00420", "CYRILLIC CAPITAL LETTER ER"
            txt = Regex.Replace(txt, "&#x0*?420;", "Р");
            txt = Regex.Replace(txt, "&#0*?1056;", "Р");
            txt = Regex.Replace(txt, "&Rcy;", "Р");

            // "U+00421", "CYRILLIC CAPITAL LETTER ES"
            txt = Regex.Replace(txt, "&#x0*?421;", "С");
            txt = Regex.Replace(txt, "&#0*?1057;", "С");
            txt = Regex.Replace(txt, "&Scy;", "С");

            // "U+00422", "CYRILLIC CAPITAL LETTER TE"
            txt = Regex.Replace(txt, "&#x0*?422;", "Т");
            txt = Regex.Replace(txt, "&#0*?1058;", "Т");
            txt = Regex.Replace(txt, "&Tcy;", "Т");

            // "U+00423", "CYRILLIC CAPITAL LETTER U"
            txt = Regex.Replace(txt, "&#x0*?423;", "У");
            txt = Regex.Replace(txt, "&#0*?1059;", "У");
            txt = Regex.Replace(txt, "&Ucy;", "У");

            // "U+00424", "CYRILLIC CAPITAL LETTER EF"
            txt = Regex.Replace(txt, "&#x0*?424;", "Ф");
            txt = Regex.Replace(txt, "&#0*?1060;", "Ф");
            txt = Regex.Replace(txt, "&Fcy;", "Ф");

            // "U+00425", "CYRILLIC CAPITAL LETTER HA"
            txt = Regex.Replace(txt, "&#x0*?425;", "Х");
            txt = Regex.Replace(txt, "&#0*?1061;", "Х");
            txt = Regex.Replace(txt, "&KHcy;", "Х");

            // "U+00426", "CYRILLIC CAPITAL LETTER TSE"
            txt = Regex.Replace(txt, "&#x0*?426;", "Ц");
            txt = Regex.Replace(txt, "&#0*?1062;", "Ц");
            txt = Regex.Replace(txt, "&TScy;", "Ц");

            // "U+00427", "CYRILLIC CAPITAL LETTER CHE"
            txt = Regex.Replace(txt, "&#x0*?427;", "Ч");
            txt = Regex.Replace(txt, "&#0*?1063;", "Ч");
            txt = Regex.Replace(txt, "&CHcy;", "Ч");

            // "U+00428", "CYRILLIC CAPITAL LETTER SHA"
            txt = Regex.Replace(txt, "&#x0*?428;", "Ш");
            txt = Regex.Replace(txt, "&#0*?1064;", "Ш");
            txt = Regex.Replace(txt, "&SHcy;", "Ш");

            // "U+00429", "CYRILLIC CAPITAL LETTER SHCHA"
            txt = Regex.Replace(txt, "&#x0*?429;", "Щ");
            txt = Regex.Replace(txt, "&#0*?1065;", "Щ");
            txt = Regex.Replace(txt, "&SHCHcy;", "Щ");

            // "U+0042A", "CYRILLIC CAPITAL LETTER HARD SIGN"
            txt = Regex.Replace(txt, "&#x0*?42A;", "Ъ");
            txt = Regex.Replace(txt, "&#0*?1066;", "Ъ");
            txt = Regex.Replace(txt, "&HARDcy;", "Ъ");

            // "U+0042B", "CYRILLIC CAPITAL LETTER YERU"
            txt = Regex.Replace(txt, "&#x0*?42B;", "Ы");
            txt = Regex.Replace(txt, "&#0*?1067;", "Ы");
            txt = Regex.Replace(txt, "&Ycy;", "Ы");

            // "U+0042C", "CYRILLIC CAPITAL LETTER SOFT SIGN"
            txt = Regex.Replace(txt, "&#x0*?42C;", "Ь");
            txt = Regex.Replace(txt, "&#0*?1068;", "Ь");
            txt = Regex.Replace(txt, "&SOFTcy;", "Ь");

            // "U+0042D", "CYRILLIC CAPITAL LETTER E"
            txt = Regex.Replace(txt, "&#x0*?42D;", "Э");
            txt = Regex.Replace(txt, "&#0*?1069;", "Э");
            txt = Regex.Replace(txt, "&Ecy;", "Э");

            // "U+0042E", "CYRILLIC CAPITAL LETTER YU"
            txt = Regex.Replace(txt, "&#x0*?42E;", "Ю");
            txt = Regex.Replace(txt, "&#0*?1070;", "Ю");
            txt = Regex.Replace(txt, "&YUcy;", "Ю");

            // "U+0042F", "CYRILLIC CAPITAL LETTER YA"
            txt = Regex.Replace(txt, "&#x0*?42F;", "Я");
            txt = Regex.Replace(txt, "&#0*?1071;", "Я");
            txt = Regex.Replace(txt, "&YAcy;", "Я");

            // "U+00430", "CYRILLIC SMALL LETTER A"
            txt = Regex.Replace(txt, "&#x0*?430;", "а");
            txt = Regex.Replace(txt, "&#0*?1072;", "а");
            txt = Regex.Replace(txt, "&acy;", "а");

            // "U+00431", "CYRILLIC SMALL LETTER BE"
            txt = Regex.Replace(txt, "&#x0*?431;", "б");
            txt = Regex.Replace(txt, "&#0*?1073;", "б");
            txt = Regex.Replace(txt, "&bcy;", "б");

            // "U+00432", "CYRILLIC SMALL LETTER VE"
            txt = Regex.Replace(txt, "&#x0*?432;", "в");
            txt = Regex.Replace(txt, "&#0*?1074;", "в");
            txt = Regex.Replace(txt, "&vcy;", "в");

            // "U+00433", "CYRILLIC SMALL LETTER GHE"
            txt = Regex.Replace(txt, "&#x0*?433;", "г");
            txt = Regex.Replace(txt, "&#0*?1075;", "г");
            txt = Regex.Replace(txt, "&gcy;", "г");

            // "U+00434", "CYRILLIC SMALL LETTER DE"
            txt = Regex.Replace(txt, "&#x0*?434;", "д");
            txt = Regex.Replace(txt, "&#0*?1076;", "д");
            txt = Regex.Replace(txt, "&dcy;", "д");

            // "U+00435", "CYRILLIC SMALL LETTER IE"
            txt = Regex.Replace(txt, "&#x0*?435;", "е");
            txt = Regex.Replace(txt, "&#0*?1077;", "е");
            txt = Regex.Replace(txt, "&iecy;", "е");

            // "U+00436", "CYRILLIC SMALL LETTER ZHE"
            txt = Regex.Replace(txt, "&#x0*?436;", "ж");
            txt = Regex.Replace(txt, "&#0*?1078;", "ж");
            txt = Regex.Replace(txt, "&zhcy;", "ж");

            // "U+00437", "CYRILLIC SMALL LETTER ZE"
            txt = Regex.Replace(txt, "&#x0*?437;", "з");
            txt = Regex.Replace(txt, "&#0*?1079;", "з");
            txt = Regex.Replace(txt, "&zcy;", "з");

            // "U+00438", "CYRILLIC SMALL LETTER I"
            txt = Regex.Replace(txt, "&#x0*?438;", "и");
            txt = Regex.Replace(txt, "&#0*?1080;", "и");
            txt = Regex.Replace(txt, "&icy;", "и");

            // "U+00439", "CYRILLIC SMALL LETTER SHORT I"
            txt = Regex.Replace(txt, "&#x0*?439;", "й");
            txt = Regex.Replace(txt, "&#0*?1081;", "й");
            txt = Regex.Replace(txt, "&jcy;", "й");

            // "U+0043A", "CYRILLIC SMALL LETTER KA"
            txt = Regex.Replace(txt, "&#x0*?43A;", "к");
            txt = Regex.Replace(txt, "&#0*?1082;", "к");
            txt = Regex.Replace(txt, "&kcy;", "к");

            // "U+0043B", "CYRILLIC SMALL LETTER EL"
            txt = Regex.Replace(txt, "&#x0*?43B;", "л");
            txt = Regex.Replace(txt, "&#0*?1083;", "л");
            txt = Regex.Replace(txt, "&lcy;", "л");

            // "U+0043C", "CYRILLIC SMALL LETTER EM"
            txt = Regex.Replace(txt, "&#x0*?43C;", "м");
            txt = Regex.Replace(txt, "&#0*?1084;", "м");
            txt = Regex.Replace(txt, "&mcy;", "м");

            // "U+0043D", "CYRILLIC SMALL LETTER EN"
            txt = Regex.Replace(txt, "&#x0*?43D;", "н");
            txt = Regex.Replace(txt, "&#0*?1085;", "н");
            txt = Regex.Replace(txt, "&ncy;", "н");

            // "U+0043E", "CYRILLIC SMALL LETTER O"
            txt = Regex.Replace(txt, "&#x0*?43E;", "о");
            txt = Regex.Replace(txt, "&#0*?1086;", "о");
            txt = Regex.Replace(txt, "&ocy;", "о");

            // "U+0043F", "CYRILLIC SMALL LETTER PE"
            txt = Regex.Replace(txt, "&#x0*?43F;", "п");
            txt = Regex.Replace(txt, "&#0*?1087;", "п");
            txt = Regex.Replace(txt, "&pcy;", "п");

            // "U+00440", "CYRILLIC SMALL LETTER ER"
            txt = Regex.Replace(txt, "&#x0*?440;", "р");
            txt = Regex.Replace(txt, "&#0*?1088;", "р");
            txt = Regex.Replace(txt, "&rcy;", "р");

            // "U+00441", "CYRILLIC SMALL LETTER ES"
            txt = Regex.Replace(txt, "&#x0*?441;", "с");
            txt = Regex.Replace(txt, "&#0*?1089;", "с");
            txt = Regex.Replace(txt, "&scy;", "с");

            // "U+00442", "CYRILLIC SMALL LETTER TE"
            txt = Regex.Replace(txt, "&#x0*?442;", "т");
            txt = Regex.Replace(txt, "&#0*?1090;", "т");
            txt = Regex.Replace(txt, "&tcy;", "т");

            // "U+00443", "CYRILLIC SMALL LETTER U"
            txt = Regex.Replace(txt, "&#x0*?443;", "у");
            txt = Regex.Replace(txt, "&#0*?1091;", "у");
            txt = Regex.Replace(txt, "&ucy;", "у");

            // "U+00444", "CYRILLIC SMALL LETTER EF"
            txt = Regex.Replace(txt, "&#x0*?444;", "ф");
            txt = Regex.Replace(txt, "&#0*?1092;", "ф");
            txt = Regex.Replace(txt, "&fcy;", "ф");

            // "U+00445", "CYRILLIC SMALL LETTER HA"
            txt = Regex.Replace(txt, "&#x0*?445;", "х");
            txt = Regex.Replace(txt, "&#0*?1093;", "х");
            txt = Regex.Replace(txt, "&khcy;", "х");

            // "U+00446", "CYRILLIC SMALL LETTER TSE"
            txt = Regex.Replace(txt, "&#x0*?446;", "ц");
            txt = Regex.Replace(txt, "&#0*?1094;", "ц");
            txt = Regex.Replace(txt, "&tscy;", "ц");

            // "U+00447", "CYRILLIC SMALL LETTER CHE"
            txt = Regex.Replace(txt, "&#x0*?447;", "ч");
            txt = Regex.Replace(txt, "&#0*?1095;", "ч");
            txt = Regex.Replace(txt, "&chcy;", "ч");

            // "U+00448", "CYRILLIC SMALL LETTER SHA"
            txt = Regex.Replace(txt, "&#x0*?448;", "ш");
            txt = Regex.Replace(txt, "&#0*?1096;", "ш");
            txt = Regex.Replace(txt, "&shcy;", "ш");

            // "U+00449", "CYRILLIC SMALL LETTER SHCHA"
            txt = Regex.Replace(txt, "&#x0*?449;", "щ");
            txt = Regex.Replace(txt, "&#0*?1097;", "щ");
            txt = Regex.Replace(txt, "&shchcy;", "щ");

            // "U+0044A", "CYRILLIC SMALL LETTER HARD SIGN"
            txt = Regex.Replace(txt, "&#x0*?44A;", "ъ");
            txt = Regex.Replace(txt, "&#0*?1098;", "ъ");
            txt = Regex.Replace(txt, "&hardcy;", "ъ");

            // "U+0044B", "CYRILLIC SMALL LETTER YERU"
            txt = Regex.Replace(txt, "&#x0*?44B;", "ы");
            txt = Regex.Replace(txt, "&#0*?1099;", "ы");
            txt = Regex.Replace(txt, "&ycy;", "ы");

            // "U+0044C", "CYRILLIC SMALL LETTER SOFT SIGN"
            txt = Regex.Replace(txt, "&#x0*?44C;", "ь");
            txt = Regex.Replace(txt, "&#0*?1100;", "ь");
            txt = Regex.Replace(txt, "&softcy;", "ь");

            // "U+0044D", "CYRILLIC SMALL LETTER E"
            txt = Regex.Replace(txt, "&#x0*?44D;", "э");
            txt = Regex.Replace(txt, "&#0*?1101;", "э");
            txt = Regex.Replace(txt, "&ecy;", "э");

            // "U+0044E", "CYRILLIC SMALL LETTER YU"
            txt = Regex.Replace(txt, "&#x0*?44E;", "ю");
            txt = Regex.Replace(txt, "&#0*?1102;", "ю");
            txt = Regex.Replace(txt, "&yucy;", "ю");

            // "U+0044F", "CYRILLIC SMALL LETTER YA"
            txt = Regex.Replace(txt, "&#x0*?44F;", "я");
            txt = Regex.Replace(txt, "&#0*?1103;", "я");
            txt = Regex.Replace(txt, "&yacy;", "я");

            // "U+00451", "CYRILLIC SMALL LETTER IO"
            txt = Regex.Replace(txt, "&#x0*?451;", "ё");
            txt = Regex.Replace(txt, "&#0*?1105;", "ё");
            txt = Regex.Replace(txt, "&iocy;", "ё");

            // "U+00452", "CYRILLIC SMALL LETTER DJE"
            txt = Regex.Replace(txt, "&#x0*?452;", "ђ");
            txt = Regex.Replace(txt, "&#0*?1106;", "ђ");
            txt = Regex.Replace(txt, "&djcy;", "ђ");

            // "U+00453", "CYRILLIC SMALL LETTER GJE"
            txt = Regex.Replace(txt, "&#x0*?453;", "ѓ");
            txt = Regex.Replace(txt, "&#0*?1107;", "ѓ");
            txt = Regex.Replace(txt, "&gjcy;", "ѓ");

            // "U+00454", "CYRILLIC SMALL LETTER UKRAINIAN IE"
            txt = Regex.Replace(txt, "&#x0*?454;", "є");
            txt = Regex.Replace(txt, "&#0*?1108;", "є");
            txt = Regex.Replace(txt, "&jukcy;", "є");

            // "U+00455", "CYRILLIC SMALL LETTER DZE"
            txt = Regex.Replace(txt, "&#x0*?455;", "ѕ");
            txt = Regex.Replace(txt, "&#0*?1109;", "ѕ");
            txt = Regex.Replace(txt, "&dscy;", "ѕ");

            // "U+00456", "CYRILLIC SMALL LETTER BYELORUSSIAN-UKRAINIAN I"
            txt = Regex.Replace(txt, "&#x0*?456;", "і");
            txt = Regex.Replace(txt, "&#0*?1110;", "і");
            txt = Regex.Replace(txt, "&iukcy;", "і");

            // "U+00457", "CYRILLIC SMALL LETTER YI"
            txt = Regex.Replace(txt, "&#x0*?457;", "ї");
            txt = Regex.Replace(txt, "&#0*?1111;", "ї");
            txt = Regex.Replace(txt, "&yicy;", "ї");

            // "U+00458", "CYRILLIC SMALL LETTER JE"
            txt = Regex.Replace(txt, "&#x0*?458;", "ј");
            txt = Regex.Replace(txt, "&#0*?1112;", "ј");
            txt = Regex.Replace(txt, "&jsercy;", "ј");

            // "U+00459", "CYRILLIC SMALL LETTER LJE"
            txt = Regex.Replace(txt, "&#x0*?459;", "љ");
            txt = Regex.Replace(txt, "&#0*?1113;", "љ");
            txt = Regex.Replace(txt, "&ljcy;", "љ");

            // "U+0045A", "CYRILLIC SMALL LETTER NJE"
            txt = Regex.Replace(txt, "&#x0*?45A;", "њ");
            txt = Regex.Replace(txt, "&#0*?1114;", "њ");
            txt = Regex.Replace(txt, "&njcy;", "њ");

            // "U+0045B", "CYRILLIC SMALL LETTER TSHE"
            txt = Regex.Replace(txt, "&#x0*?45B;", "ћ");
            txt = Regex.Replace(txt, "&#0*?1115;", "ћ");
            txt = Regex.Replace(txt, "&tshcy;", "ћ");

            // "U+0045C", "CYRILLIC SMALL LETTER KJE"
            txt = Regex.Replace(txt, "&#x0*?45C;", "ќ");
            txt = Regex.Replace(txt, "&#0*?1116;", "ќ");
            txt = Regex.Replace(txt, "&kjcy;", "ќ");

            // "U+0045E", "CYRILLIC SMALL LETTER SHORT U"
            txt = Regex.Replace(txt, "&#x0*?45E;", "ў");
            txt = Regex.Replace(txt, "&#0*?1118;", "ў");
            txt = Regex.Replace(txt, "&ubrcy;", "ў");

            // "U+0045F", "CYRILLIC SMALL LETTER DZHE"
            txt = Regex.Replace(txt, "&#x0*?45F;", "џ");
            txt = Regex.Replace(txt, "&#0*?1119;", "џ");
            txt = Regex.Replace(txt, "&dzcy;", "џ");

            // "U+02002", "EN SPACE"
            txt = Regex.Replace(txt, "&#x0*?2002;", " ");
            txt = Regex.Replace(txt, "&#0*?8194;", " ");
            txt = Regex.Replace(txt, "&ensp;", " ");

            // "U+02003", "EM SPACE"
            txt = Regex.Replace(txt, "&#x0*?2003;", " ");
            txt = Regex.Replace(txt, "&#0*?8195;", " ");
            txt = Regex.Replace(txt, "&emsp;", " ");

            // "U+02004", "THREE-PER-EM SPACE"
            txt = Regex.Replace(txt, "&#x0*?2004;", " ");
            txt = Regex.Replace(txt, "&#0*?8196;", " ");
            txt = Regex.Replace(txt, "&emsp13;", " ");

            // "U+02005", "FOUR-PER-EM SPACE"
            txt = Regex.Replace(txt, "&#x0*?2005;", " ");
            txt = Regex.Replace(txt, "&#0*?8197;", " ");
            txt = Regex.Replace(txt, "&emsp14;", " ");

            // "U+02007", "FIGURE SPACE"
            txt = Regex.Replace(txt, "&#x0*?2007;", " ");
            txt = Regex.Replace(txt, "&#0*?8199;", " ");
            txt = Regex.Replace(txt, "&numsp;", " ");

            // "U+02008", "PUNCTUATION SPACE"
            txt = Regex.Replace(txt, "&#x0*?2008;", " ");
            txt = Regex.Replace(txt, "&#0*?8200;", " ");
            txt = Regex.Replace(txt, "&puncsp;", " ");

            // "U+02009", "THIN SPACE"
            txt = Regex.Replace(txt, "&#x0*?2009;", " ");
            txt = Regex.Replace(txt, "&#0*?8201;", " ");
            txt = Regex.Replace(txt, "&thinsp;", " ");
            txt = Regex.Replace(txt, "&ThinSpace;", " ");

            // "U+0200A", "HAIR SPACE"
            txt = Regex.Replace(txt, "&#x0*?200A;", " ");
            txt = Regex.Replace(txt, "&#0*?8202;", " ");
            txt = Regex.Replace(txt, "&hairsp;", " ");
            txt = Regex.Replace(txt, "&VeryThinSpace;", " ");

            // "U+0200B", "ZERO WIDTH SPACE"
            txt = Regex.Replace(txt, "&#x0*?200B;", "​");
            txt = Regex.Replace(txt, "&#0*?8203;", "​");
            txt = Regex.Replace(txt, "&ZeroWidthSpace;", "​");
            txt = Regex.Replace(txt, "&NegativeVeryThinSpace;", "​");
            txt = Regex.Replace(txt, "&NegativeThinSpace;", "​");
            txt = Regex.Replace(txt, "&NegativeMediumSpace;", "​");
            txt = Regex.Replace(txt, "&NegativeThickSpace;", "​");

            // "U+0200C", "ZERO WIDTH NON-JOINER"
            txt = Regex.Replace(txt, "&#x0*?200C;", "‌");
            txt = Regex.Replace(txt, "&#0*?8204;", "‌");
            txt = Regex.Replace(txt, "&zwnj;", "‌");

            // "U+0200D", "ZERO WIDTH JOINER"
            txt = Regex.Replace(txt, "&#x0*?200D;", "‍");
            txt = Regex.Replace(txt, "&#0*?8205;", "‍");
            txt = Regex.Replace(txt, "&zwj;", "‍");

            // "U+0200E", "LEFT-TO-RIGHT MARK"
            txt = Regex.Replace(txt, "&#x0*?200E;", "‎");
            txt = Regex.Replace(txt, "&#0*?8206;", "‎");
            txt = Regex.Replace(txt, "&lrm;", "‎");

            // "U+0200F", "RIGHT-TO-LEFT MARK"
            txt = Regex.Replace(txt, "&#x0*?200F;", "‏");
            txt = Regex.Replace(txt, "&#0*?8207;", "‏");
            txt = Regex.Replace(txt, "&rlm;", "‏");

            // "U+02010", "HYPHEN"
            txt = Regex.Replace(txt, "&#x0*?2010;", "‐");
            txt = Regex.Replace(txt, "&#0*?8208;", "‐");
            txt = Regex.Replace(txt, "&hyphen;", "‐");
            txt = Regex.Replace(txt, "&dash;", "‐");

            // "U+02013", "EN DASH"
            txt = Regex.Replace(txt, "&#x0*?2013;", "–");
            txt = Regex.Replace(txt, "&#0*?8211;", "–");
            txt = Regex.Replace(txt, "&ndash;", "–");

            // "U+02014", "EM DASH"
            txt = Regex.Replace(txt, "&#x0*?2014;", "—");
            txt = Regex.Replace(txt, "&#0*?8212;", "—");
            txt = Regex.Replace(txt, "&mdash;", "—");

            // "U+02015", "HORIZONTAL BAR"
            txt = Regex.Replace(txt, "&#x0*?2015;", "―");
            txt = Regex.Replace(txt, "&#0*?8213;", "―");
            txt = Regex.Replace(txt, "&horbar;", "―");

            // "U+02016", "DOUBLE VERTICAL LINE"
            txt = Regex.Replace(txt, "&#x0*?2016;", "‖");
            txt = Regex.Replace(txt, "&#0*?8214;", "‖");
            txt = Regex.Replace(txt, "&Verbar;", "‖");
            txt = Regex.Replace(txt, "&Vert;", "‖");

            // "U+02018", "LEFT SINGLE QUOTATION MARK"
            txt = Regex.Replace(txt, "&#x0*?2018;", "‘");
            txt = Regex.Replace(txt, "&#0*?8216;", "‘");
            txt = Regex.Replace(txt, "&lsquo;", "‘");
            txt = Regex.Replace(txt, "&OpenCurlyQuote;", "‘");

            // "U+02019", "RIGHT SINGLE QUOTATION MARK"
            txt = Regex.Replace(txt, "&#x0*?2019;", "’");
            txt = Regex.Replace(txt, "&#0*?8217;", "’");
            txt = Regex.Replace(txt, "&rsquo;", "’");
            txt = Regex.Replace(txt, "&rsquor;", "’");
            txt = Regex.Replace(txt, "&CloseCurlyQuote;", "’");

            // "U+0201A", "SINGLE LOW-9 QUOTATION MARK"
            txt = Regex.Replace(txt, "&#x0*?201A;", "‚");
            txt = Regex.Replace(txt, "&#0*?8218;", "‚");
            txt = Regex.Replace(txt, "&lsquor;", "‚");
            txt = Regex.Replace(txt, "&sbquo;", "‚");

            // "U+0201C", "LEFT DOUBLE QUOTATION MARK"
            txt = Regex.Replace(txt, "&#x0*?201C;", "“");
            txt = Regex.Replace(txt, "&#0*?8220;", "“");
            txt = Regex.Replace(txt, "&ldquo;", "“");
            txt = Regex.Replace(txt, "&OpenCurlyDoubleQuote;", "“");

            // "U+0201D", "RIGHT DOUBLE QUOTATION MARK"
            txt = Regex.Replace(txt, "&#x0*?201D;", "”");
            txt = Regex.Replace(txt, "&#0*?8221;", "”");
            txt = Regex.Replace(txt, "&rdquo;", "”");
            txt = Regex.Replace(txt, "&rdquor;", "”");
            txt = Regex.Replace(txt, "&CloseCurlyDoubleQuote;", "”");

            // "U+0201E", "DOUBLE LOW-9 QUOTATION MARK"
            txt = Regex.Replace(txt, "&#x0*?201E;", "„");
            txt = Regex.Replace(txt, "&#0*?8222;", "„");
            txt = Regex.Replace(txt, "&ldquor;", "„");
            txt = Regex.Replace(txt, "&bdquo;", "„");

            // "U+02020", "DAGGER"
            txt = Regex.Replace(txt, "&#x0*?2020;", "†");
            txt = Regex.Replace(txt, "&#0*?8224;", "†");
            txt = Regex.Replace(txt, "&dagger;", "†");

            // "U+02021", "DOUBLE DAGGER"
            txt = Regex.Replace(txt, "&#x0*?2021;", "‡");
            txt = Regex.Replace(txt, "&#0*?8225;", "‡");
            txt = Regex.Replace(txt, "&Dagger;", "‡");
            txt = Regex.Replace(txt, "&ddagger;", "‡");

            // "U+02022", "BULLET"
            txt = Regex.Replace(txt, "&#x0*?2022;", "•");
            txt = Regex.Replace(txt, "&#0*?8226;", "•");
            txt = Regex.Replace(txt, "&bull;", "•");
            txt = Regex.Replace(txt, "&bullet;", "•");

            // "U+02025", "TWO DOT LEADER"
            txt = Regex.Replace(txt, "&#x0*?2025;", "‥");
            txt = Regex.Replace(txt, "&#0*?8229;", "‥");
            txt = Regex.Replace(txt, "&nldr;", "‥");

            // "U+02026", "HORIZONTAL ELLIPSIS"
            txt = Regex.Replace(txt, "&#x0*?2026;", "…");
            txt = Regex.Replace(txt, "&#0*?8230;", "…");
            txt = Regex.Replace(txt, "&hellip;", "…");
            txt = Regex.Replace(txt, "&mldr;", "…");

            // "U+02030", "PER MILLE SIGN"
            txt = Regex.Replace(txt, "&#x0*?2030;", "‰");
            txt = Regex.Replace(txt, "&#0*?8240;", "‰");
            txt = Regex.Replace(txt, "&permil;", "‰");

            // "U+02031", "PER TEN THOUSAND SIGN"
            txt = Regex.Replace(txt, "&#x0*?2031;", "‱");
            txt = Regex.Replace(txt, "&#0*?8241;", "‱");
            txt = Regex.Replace(txt, "&pertenk;", "‱");

            // "U+02032", "PRIME"
            txt = Regex.Replace(txt, "&#x0*?2032;", "′");
            txt = Regex.Replace(txt, "&#0*?8242;", "′");
            txt = Regex.Replace(txt, "&prime;", "′");

            // "U+02033", "DOUBLE PRIME"
            txt = Regex.Replace(txt, "&#x0*?2033;", "″");
            txt = Regex.Replace(txt, "&#0*?8243;", "″");
            txt = Regex.Replace(txt, "&Prime;", "″");

            // "U+02034", "TRIPLE PRIME"
            txt = Regex.Replace(txt, "&#x0*?2034;", "‴");
            txt = Regex.Replace(txt, "&#0*?8244;", "‴");
            txt = Regex.Replace(txt, "&tprime;", "‴");

            // "U+02035", "REVERSED PRIME"
            txt = Regex.Replace(txt, "&#x0*?2035;", "‵");
            txt = Regex.Replace(txt, "&#0*?8245;", "‵");
            txt = Regex.Replace(txt, "&bprime;", "‵");
            txt = Regex.Replace(txt, "&backprime;", "‵");

            // "U+02039", "SINGLE LEFT-POINTING ANGLE QUOTATION MARK"
            txt = Regex.Replace(txt, "&#x0*?2039;", "‹");
            txt = Regex.Replace(txt, "&#0*?8249;", "‹");
            txt = Regex.Replace(txt, "&lsaquo;", "‹");

            // "U+0203A", "SINGLE RIGHT-POINTING ANGLE QUOTATION MARK"
            txt = Regex.Replace(txt, "&#x0*?203A;", "›");
            txt = Regex.Replace(txt, "&#0*?8250;", "›");
            txt = Regex.Replace(txt, "&rsaquo;", "›");

            // "U+0203E", "OVERLINE"
            txt = Regex.Replace(txt, "&#x0*?203E;", "‾");
            txt = Regex.Replace(txt, "&#0*?8254;", "‾");
            txt = Regex.Replace(txt, "&oline;", "‾");

            // "U+02041", "CARET INSERTION POINT"
            txt = Regex.Replace(txt, "&#x0*?2041;", "⁁");
            txt = Regex.Replace(txt, "&#0*?8257;", "⁁");
            txt = Regex.Replace(txt, "&caret;", "⁁");

            // "U+02043", "HYPHEN BULLET"
            txt = Regex.Replace(txt, "&#x0*?2043;", "⁃");
            txt = Regex.Replace(txt, "&#0*?8259;", "⁃");
            txt = Regex.Replace(txt, "&hybull;", "⁃");

            // "U+02044", "FRACTION SLASH"
            txt = Regex.Replace(txt, "&#x0*?2044;", "⁄");
            txt = Regex.Replace(txt, "&#0*?8260;", "⁄");
            txt = Regex.Replace(txt, "&frasl;", "⁄");

            // "U+0204F", "REVERSED SEMICOLON"
            txt = Regex.Replace(txt, "&#x0*?204F;", "⁏");
            txt = Regex.Replace(txt, "&#0*?8271;", "⁏");
            txt = Regex.Replace(txt, "&bsemi;", "⁏");

            // "U+02057", "QUADRUPLE PRIME"
            txt = Regex.Replace(txt, "&#x0*?2057;", "⁗");
            txt = Regex.Replace(txt, "&#0*?8279;", "⁗");
            txt = Regex.Replace(txt, "&qprime;", "⁗");

            // "U+0205F", "MEDIUM MATHEMATICAL SPACE"
            txt = Regex.Replace(txt, "&#x0*?205F;", " ");
            txt = Regex.Replace(txt, "&#0*?8287;", " ");
            txt = Regex.Replace(txt, "&MediumSpace;", " ");

            // "U+02060", "WORD JOINER"
            txt = Regex.Replace(txt, "&#x0*?2060;", "⁠");
            txt = Regex.Replace(txt, "&#0*?8288;", "⁠");
            txt = Regex.Replace(txt, "&NoBreak;", "⁠");

            // "U+02061", "FUNCTION APPLICATION"
            txt = Regex.Replace(txt, "&#x0*?2061;", "⁡");
            txt = Regex.Replace(txt, "&#0*?8289;", "⁡");
            txt = Regex.Replace(txt, "&ApplyFunction;", "⁡");
            txt = Regex.Replace(txt, "&af;", "⁡");

            // "U+02062", "INVISIBLE TIMES"
            txt = Regex.Replace(txt, "&#x0*?2062;", "⁢");
            txt = Regex.Replace(txt, "&#0*?8290;", "⁢");
            txt = Regex.Replace(txt, "&InvisibleTimes;", "⁢");
            txt = Regex.Replace(txt, "&it;", "⁢");

            // "U+02063", "INVISIBLE SEPARATOR"
            txt = Regex.Replace(txt, "&#x0*?2063;", "⁣");
            txt = Regex.Replace(txt, "&#0*?8291;", "⁣");
            txt = Regex.Replace(txt, "&InvisibleComma;", "⁣");
            txt = Regex.Replace(txt, "&ic;", "⁣");

            // "U+020AC", "EURO SIGN"
            txt = Regex.Replace(txt, "&#x0*?20AC;", "€");
            txt = Regex.Replace(txt, "&#0*?8364;", "€");
            txt = Regex.Replace(txt, "&euro;", "€");

            // "U+020DB", "COMBINING THREE DOTS ABOVE"
            txt = Regex.Replace(txt, "&#x0*?20DB;", "⃛");
            txt = Regex.Replace(txt, "&#0*?8411;", "⃛");
            txt = Regex.Replace(txt, "&tdot;", "⃛");
            txt = Regex.Replace(txt, "&TripleDot;", "⃛");

            // "U+020DC", "COMBINING FOUR DOTS ABOVE"
            txt = Regex.Replace(txt, "&#x0*?20DC;", "⃜");
            txt = Regex.Replace(txt, "&#0*?8412;", "⃜");
            txt = Regex.Replace(txt, "&DotDot;", "⃜");

            // "U+02102", "DOUBLE-STRUCK CAPITAL C"
            txt = Regex.Replace(txt, "&#x0*?2102;", "ℂ");
            txt = Regex.Replace(txt, "&#0*?8450;", "ℂ");
            txt = Regex.Replace(txt, "&Copf;", "ℂ");
            txt = Regex.Replace(txt, "&complexes;", "ℂ");

            // "U+02105", "CARE OF"
            txt = Regex.Replace(txt, "&#x0*?2105;", "℅");
            txt = Regex.Replace(txt, "&#0*?8453;", "℅");
            txt = Regex.Replace(txt, "&incare;", "℅");

            // "U+0210A", "SCRIPT SMALL G"
            txt = Regex.Replace(txt, "&#x0*?210A;", "ℊ");
            txt = Regex.Replace(txt, "&#0*?8458;", "ℊ");
            txt = Regex.Replace(txt, "&gscr;", "ℊ");

            // "U+0210B", "SCRIPT CAPITAL H"
            txt = Regex.Replace(txt, "&#x0*?210B;", "ℋ");
            txt = Regex.Replace(txt, "&#0*?8459;", "ℋ");
            txt = Regex.Replace(txt, "&hamilt;", "ℋ");
            txt = Regex.Replace(txt, "&HilbertSpace;", "ℋ");
            txt = Regex.Replace(txt, "&Hscr;", "ℋ");

            // "U+0210C", "BLACK-LETTER CAPITAL H"
            txt = Regex.Replace(txt, "&#x0*?210C;", "ℌ");
            txt = Regex.Replace(txt, "&#0*?8460;", "ℌ");
            txt = Regex.Replace(txt, "&Hfr;", "ℌ");
            txt = Regex.Replace(txt, "&Poincareplane;", "ℌ");

            // "U+0210D", "DOUBLE-STRUCK CAPITAL H"
            txt = Regex.Replace(txt, "&#x0*?210D;", "ℍ");
            txt = Regex.Replace(txt, "&#0*?8461;", "ℍ");
            txt = Regex.Replace(txt, "&quaternions;", "ℍ");
            txt = Regex.Replace(txt, "&Hopf;", "ℍ");

            // "U+0210E", "PLANCK CONSTANT"
            txt = Regex.Replace(txt, "&#x0*?210E;", "ℎ");
            txt = Regex.Replace(txt, "&#0*?8462;", "ℎ");
            txt = Regex.Replace(txt, "&planckh;", "ℎ");

            // "U+0210F", "PLANCK CONSTANT OVER TWO PI"
            txt = Regex.Replace(txt, "&#x0*?210F;", "ℏ");
            txt = Regex.Replace(txt, "&#0*?8463;", "ℏ");
            txt = Regex.Replace(txt, "&planck;", "ℏ");
            txt = Regex.Replace(txt, "&hbar;", "ℏ");
            txt = Regex.Replace(txt, "&plankv;", "ℏ");
            txt = Regex.Replace(txt, "&hslash;", "ℏ");

            // "U+02110", "SCRIPT CAPITAL I"
            txt = Regex.Replace(txt, "&#x0*?2110;", "ℐ");
            txt = Regex.Replace(txt, "&#0*?8464;", "ℐ");
            txt = Regex.Replace(txt, "&Iscr;", "ℐ");
            txt = Regex.Replace(txt, "&imagline;", "ℐ");

            // "U+02111", "BLACK-LETTER CAPITAL I"
            txt = Regex.Replace(txt, "&#x0*?2111;", "ℑ");
            txt = Regex.Replace(txt, "&#0*?8465;", "ℑ");
            txt = Regex.Replace(txt, "&image;", "ℑ");
            txt = Regex.Replace(txt, "&Im;", "ℑ");
            txt = Regex.Replace(txt, "&imagpart;", "ℑ");
            txt = Regex.Replace(txt, "&Ifr;", "ℑ");

            // "U+02112", "SCRIPT CAPITAL L"
            txt = Regex.Replace(txt, "&#x0*?2112;", "ℒ");
            txt = Regex.Replace(txt, "&#0*?8466;", "ℒ");
            txt = Regex.Replace(txt, "&Lscr;", "ℒ");
            txt = Regex.Replace(txt, "&lagran;", "ℒ");
            txt = Regex.Replace(txt, "&Laplacetrf;", "ℒ");

            // "U+02113", "SCRIPT SMALL L"
            txt = Regex.Replace(txt, "&#x0*?2113;", "ℓ");
            txt = Regex.Replace(txt, "&#0*?8467;", "ℓ");
            txt = Regex.Replace(txt, "&ell;", "ℓ");

            // "U+02115", "DOUBLE-STRUCK CAPITAL N"
            txt = Regex.Replace(txt, "&#x0*?2115;", "ℕ");
            txt = Regex.Replace(txt, "&#0*?8469;", "ℕ");
            txt = Regex.Replace(txt, "&Nopf;", "ℕ");
            txt = Regex.Replace(txt, "&naturals;", "ℕ");

            // "U+02116", "NUMERO SIGN"
            txt = Regex.Replace(txt, "&#x0*?2116;", "№");
            txt = Regex.Replace(txt, "&#0*?8470;", "№");
            txt = Regex.Replace(txt, "&numero;", "№");

            // "U+02117", "SOUND RECORDING COPYRIGHT"
            txt = Regex.Replace(txt, "&#x0*?2117;", "℗");
            txt = Regex.Replace(txt, "&#0*?8471;", "℗");
            txt = Regex.Replace(txt, "&copysr;", "℗");

            // "U+02118", "SCRIPT CAPITAL P"
            txt = Regex.Replace(txt, "&#x0*?2118;", "℘");
            txt = Regex.Replace(txt, "&#0*?8472;", "℘");
            txt = Regex.Replace(txt, "&weierp;", "℘");
            txt = Regex.Replace(txt, "&wp;", "℘");

            // "U+02119", "DOUBLE-STRUCK CAPITAL P"
            txt = Regex.Replace(txt, "&#x0*?2119;", "ℙ");
            txt = Regex.Replace(txt, "&#0*?8473;", "ℙ");
            txt = Regex.Replace(txt, "&Popf;", "ℙ");
            txt = Regex.Replace(txt, "&primes;", "ℙ");

            // "U+0211A", "DOUBLE-STRUCK CAPITAL Q"
            txt = Regex.Replace(txt, "&#x0*?211A;", "ℚ");
            txt = Regex.Replace(txt, "&#0*?8474;", "ℚ");
            txt = Regex.Replace(txt, "&rationals;", "ℚ");
            txt = Regex.Replace(txt, "&Qopf;", "ℚ");

            // "U+0211B", "SCRIPT CAPITAL R"
            txt = Regex.Replace(txt, "&#x0*?211B;", "ℛ");
            txt = Regex.Replace(txt, "&#0*?8475;", "ℛ");
            txt = Regex.Replace(txt, "&Rscr;", "ℛ");
            txt = Regex.Replace(txt, "&realine;", "ℛ");

            // "U+0211C", "BLACK-LETTER CAPITAL R"
            txt = Regex.Replace(txt, "&#x0*?211C;", "ℜ");
            txt = Regex.Replace(txt, "&#0*?8476;", "ℜ");
            txt = Regex.Replace(txt, "&real;", "ℜ");
            txt = Regex.Replace(txt, "&Re;", "ℜ");
            txt = Regex.Replace(txt, "&realpart;", "ℜ");
            txt = Regex.Replace(txt, "&Rfr;", "ℜ");

            // "U+0211D", "DOUBLE-STRUCK CAPITAL R"
            txt = Regex.Replace(txt, "&#x0*?211D;", "ℝ");
            txt = Regex.Replace(txt, "&#0*?8477;", "ℝ");
            txt = Regex.Replace(txt, "&reals;", "ℝ");
            txt = Regex.Replace(txt, "&Ropf;", "ℝ");

            // "U+0211E", "PRESCRIPTION TAKE"
            txt = Regex.Replace(txt, "&#x0*?211E;", "℞");
            txt = Regex.Replace(txt, "&#0*?8478;", "℞");
            txt = Regex.Replace(txt, "&rx;", "℞");

            // "U+02122", "TRADE MARK SIGN"
            txt = Regex.Replace(txt, "&#x0*?2122;", "™");
            txt = Regex.Replace(txt, "&#0*?8482;", "™");
            txt = Regex.Replace(txt, "&trade;", "™");
            txt = Regex.Replace(txt, "&TRADE;", "™");

            // "U+02124", "DOUBLE-STRUCK CAPITAL Z"
            txt = Regex.Replace(txt, "&#x0*?2124;", "ℤ");
            txt = Regex.Replace(txt, "&#0*?8484;", "ℤ");
            txt = Regex.Replace(txt, "&integers;", "ℤ");
            txt = Regex.Replace(txt, "&Zopf;", "ℤ");

            // "U+02126", "OHM SIGN"
            txt = Regex.Replace(txt, "&#x0*?2126;", "Ω");
            txt = Regex.Replace(txt, "&#0*?8486;", "Ω");
            txt = Regex.Replace(txt, "&ohm;", "Ω");

            // "U+02127", "INVERTED OHM SIGN"
            txt = Regex.Replace(txt, "&#x0*?2127;", "℧");
            txt = Regex.Replace(txt, "&#0*?8487;", "℧");
            txt = Regex.Replace(txt, "&mho;", "℧");

            // "U+02128", "BLACK-LETTER CAPITAL Z"
            txt = Regex.Replace(txt, "&#x0*?2128;", "ℨ");
            txt = Regex.Replace(txt, "&#0*?8488;", "ℨ");
            txt = Regex.Replace(txt, "&Zfr;", "ℨ");
            txt = Regex.Replace(txt, "&zeetrf;", "ℨ");

            // "U+02129", "TURNED GREEK SMALL LETTER IOTA"
            txt = Regex.Replace(txt, "&#x0*?2129;", "℩");
            txt = Regex.Replace(txt, "&#0*?8489;", "℩");
            txt = Regex.Replace(txt, "&iiota;", "℩");

            // "U+0212B", "ANGSTROM SIGN"
            txt = Regex.Replace(txt, "&#x0*?212B;", "Å");
            txt = Regex.Replace(txt, "&#0*?8491;", "Å");
            txt = Regex.Replace(txt, "&angst;", "Å");

            // "U+0212C", "SCRIPT CAPITAL B"
            txt = Regex.Replace(txt, "&#x0*?212C;", "ℬ");
            txt = Regex.Replace(txt, "&#0*?8492;", "ℬ");
            txt = Regex.Replace(txt, "&bernou;", "ℬ");
            txt = Regex.Replace(txt, "&Bernoullis;", "ℬ");
            txt = Regex.Replace(txt, "&Bscr;", "ℬ");

            // "U+0212D", "BLACK-LETTER CAPITAL C"
            txt = Regex.Replace(txt, "&#x0*?212D;", "ℭ");
            txt = Regex.Replace(txt, "&#0*?8493;", "ℭ");
            txt = Regex.Replace(txt, "&Cfr;", "ℭ");
            txt = Regex.Replace(txt, "&Cayleys;", "ℭ");

            // "U+0212F", "SCRIPT SMALL E"
            txt = Regex.Replace(txt, "&#x0*?212F;", "ℯ");
            txt = Regex.Replace(txt, "&#0*?8495;", "ℯ");
            txt = Regex.Replace(txt, "&escr;", "ℯ");

            // "U+02130", "SCRIPT CAPITAL E"
            txt = Regex.Replace(txt, "&#x0*?2130;", "ℰ");
            txt = Regex.Replace(txt, "&#0*?8496;", "ℰ");
            txt = Regex.Replace(txt, "&Escr;", "ℰ");
            txt = Regex.Replace(txt, "&expectation;", "ℰ");

            // "U+02131", "SCRIPT CAPITAL F"
            txt = Regex.Replace(txt, "&#x0*?2131;", "ℱ");
            txt = Regex.Replace(txt, "&#0*?8497;", "ℱ");
            txt = Regex.Replace(txt, "&Fscr;", "ℱ");
            txt = Regex.Replace(txt, "&Fouriertrf;", "ℱ");

            // "U+02133", "SCRIPT CAPITAL M"
            txt = Regex.Replace(txt, "&#x0*?2133;", "ℳ");
            txt = Regex.Replace(txt, "&#0*?8499;", "ℳ");
            txt = Regex.Replace(txt, "&phmmat;", "ℳ");
            txt = Regex.Replace(txt, "&Mellintrf;", "ℳ");
            txt = Regex.Replace(txt, "&Mscr;", "ℳ");

            // "U+02134", "SCRIPT SMALL O"
            txt = Regex.Replace(txt, "&#x0*?2134;", "ℴ");
            txt = Regex.Replace(txt, "&#0*?8500;", "ℴ");
            txt = Regex.Replace(txt, "&order;", "ℴ");
            txt = Regex.Replace(txt, "&orderof;", "ℴ");
            txt = Regex.Replace(txt, "&oscr;", "ℴ");

            // "U+02135", "ALEF SYMBOL"
            txt = Regex.Replace(txt, "&#x0*?2135;", "ℵ");
            txt = Regex.Replace(txt, "&#0*?8501;", "ℵ");
            txt = Regex.Replace(txt, "&alefsym;", "ℵ");
            txt = Regex.Replace(txt, "&aleph;", "ℵ");

            // "U+02136", "BET SYMBOL"
            txt = Regex.Replace(txt, "&#x0*?2136;", "ℶ");
            txt = Regex.Replace(txt, "&#0*?8502;", "ℶ");
            txt = Regex.Replace(txt, "&beth;", "ℶ");

            // "U+02137", "GIMEL SYMBOL"
            txt = Regex.Replace(txt, "&#x0*?2137;", "ℷ");
            txt = Regex.Replace(txt, "&#0*?8503;", "ℷ");
            txt = Regex.Replace(txt, "&gimel;", "ℷ");

            // "U+02138", "DALET SYMBOL"
            txt = Regex.Replace(txt, "&#x0*?2138;", "ℸ");
            txt = Regex.Replace(txt, "&#0*?8504;", "ℸ");
            txt = Regex.Replace(txt, "&daleth;", "ℸ");

            // "U+02145", "DOUBLE-STRUCK ITALIC CAPITAL D"
            txt = Regex.Replace(txt, "&#x0*?2145;", "ⅅ");
            txt = Regex.Replace(txt, "&#0*?8517;", "ⅅ");
            txt = Regex.Replace(txt, "&CapitalDifferentialD;", "ⅅ");
            txt = Regex.Replace(txt, "&DD;", "ⅅ");

            // "U+02146", "DOUBLE-STRUCK ITALIC SMALL D"
            txt = Regex.Replace(txt, "&#x0*?2146;", "ⅆ");
            txt = Regex.Replace(txt, "&#0*?8518;", "ⅆ");
            txt = Regex.Replace(txt, "&DifferentialD;", "ⅆ");
            txt = Regex.Replace(txt, "&dd;", "ⅆ");

            // "U+02147", "DOUBLE-STRUCK ITALIC SMALL E"
            txt = Regex.Replace(txt, "&#x0*?2147;", "ⅇ");
            txt = Regex.Replace(txt, "&#0*?8519;", "ⅇ");
            txt = Regex.Replace(txt, "&ExponentialE;", "ⅇ");
            txt = Regex.Replace(txt, "&exponentiale;", "ⅇ");
            txt = Regex.Replace(txt, "&ee;", "ⅇ");

            // "U+02148", "DOUBLE-STRUCK ITALIC SMALL I"
            txt = Regex.Replace(txt, "&#x0*?2148;", "ⅈ");
            txt = Regex.Replace(txt, "&#0*?8520;", "ⅈ");
            txt = Regex.Replace(txt, "&ImaginaryI;", "ⅈ");
            txt = Regex.Replace(txt, "&ii;", "ⅈ");

            // "U+02153", "VULGAR FRACTION ONE THIRD"
            txt = Regex.Replace(txt, "&#x0*?2153;", "⅓");
            txt = Regex.Replace(txt, "&#0*?8531;", "⅓");
            txt = Regex.Replace(txt, "&frac13;", "⅓");

            // "U+02154", "VULGAR FRACTION TWO THIRDS"
            txt = Regex.Replace(txt, "&#x0*?2154;", "⅔");
            txt = Regex.Replace(txt, "&#0*?8532;", "⅔");
            txt = Regex.Replace(txt, "&frac23;", "⅔");

            // "U+02155", "VULGAR FRACTION ONE FIFTH"
            txt = Regex.Replace(txt, "&#x0*?2155;", "⅕");
            txt = Regex.Replace(txt, "&#0*?8533;", "⅕");
            txt = Regex.Replace(txt, "&frac15;", "⅕");

            // "U+02156", "VULGAR FRACTION TWO FIFTHS"
            txt = Regex.Replace(txt, "&#x0*?2156;", "⅖");
            txt = Regex.Replace(txt, "&#0*?8534;", "⅖");
            txt = Regex.Replace(txt, "&frac25;", "⅖");

            // "U+02157", "VULGAR FRACTION THREE FIFTHS"
            txt = Regex.Replace(txt, "&#x0*?2157;", "⅗");
            txt = Regex.Replace(txt, "&#0*?8535;", "⅗");
            txt = Regex.Replace(txt, "&frac35;", "⅗");

            // "U+02158", "VULGAR FRACTION FOUR FIFTHS"
            txt = Regex.Replace(txt, "&#x0*?2158;", "⅘");
            txt = Regex.Replace(txt, "&#0*?8536;", "⅘");
            txt = Regex.Replace(txt, "&frac45;", "⅘");

            // "U+02159", "VULGAR FRACTION ONE SIXTH"
            txt = Regex.Replace(txt, "&#x0*?2159;", "⅙");
            txt = Regex.Replace(txt, "&#0*?8537;", "⅙");
            txt = Regex.Replace(txt, "&frac16;", "⅙");

            // "U+0215A", "VULGAR FRACTION FIVE SIXTHS"
            txt = Regex.Replace(txt, "&#x0*?215A;", "⅚");
            txt = Regex.Replace(txt, "&#0*?8538;", "⅚");
            txt = Regex.Replace(txt, "&frac56;", "⅚");

            // "U+0215B", "VULGAR FRACTION ONE EIGHTH"
            txt = Regex.Replace(txt, "&#x0*?215B;", "⅛");
            txt = Regex.Replace(txt, "&#0*?8539;", "⅛");
            txt = Regex.Replace(txt, "&frac18;", "⅛");

            // "U+0215C", "VULGAR FRACTION THREE EIGHTHS"
            txt = Regex.Replace(txt, "&#x0*?215C;", "⅜");
            txt = Regex.Replace(txt, "&#0*?8540;", "⅜");
            txt = Regex.Replace(txt, "&frac38;", "⅜");

            // "U+0215D", "VULGAR FRACTION FIVE EIGHTHS"
            txt = Regex.Replace(txt, "&#x0*?215D;", "⅝");
            txt = Regex.Replace(txt, "&#0*?8541;", "⅝");
            txt = Regex.Replace(txt, "&frac58;", "⅝");

            // "U+0215E", "VULGAR FRACTION SEVEN EIGHTHS"
            txt = Regex.Replace(txt, "&#x0*?215E;", "⅞");
            txt = Regex.Replace(txt, "&#0*?8542;", "⅞");
            txt = Regex.Replace(txt, "&frac78;", "⅞");

            // "U+02190", "LEFTWARDS ARROW"
            txt = Regex.Replace(txt, "&#x0*?2190;", "←");
            txt = Regex.Replace(txt, "&#0*?8592;", "←");
            txt = Regex.Replace(txt, "&larr;", "←");
            txt = Regex.Replace(txt, "&leftarrow;", "←");
            txt = Regex.Replace(txt, "&LeftArrow;", "←");
            txt = Regex.Replace(txt, "&slarr;", "←");
            txt = Regex.Replace(txt, "&ShortLeftArrow;", "←");

            // "U+02191", "UPWARDS ARROW"
            txt = Regex.Replace(txt, "&#x0*?2191;", "↑");
            txt = Regex.Replace(txt, "&#0*?8593;", "↑");
            txt = Regex.Replace(txt, "&uarr;", "↑");
            txt = Regex.Replace(txt, "&uparrow;", "↑");
            txt = Regex.Replace(txt, "&UpArrow;", "↑");
            txt = Regex.Replace(txt, "&ShortUpArrow;", "↑");

            // "U+02192", "RIGHTWARDS ARROW"
            txt = Regex.Replace(txt, "&#x0*?2192;", "→");
            txt = Regex.Replace(txt, "&#0*?8594;", "→");
            txt = Regex.Replace(txt, "&rarr;", "→");
            txt = Regex.Replace(txt, "&rightarrow;", "→");
            txt = Regex.Replace(txt, "&RightArrow;", "→");
            txt = Regex.Replace(txt, "&srarr;", "→");
            txt = Regex.Replace(txt, "&ShortRightArrow;", "→");

            // "U+02193", "DOWNWARDS ARROW"
            txt = Regex.Replace(txt, "&#x0*?2193;", "↓");
            txt = Regex.Replace(txt, "&#0*?8595;", "↓");
            txt = Regex.Replace(txt, "&darr;", "↓");
            txt = Regex.Replace(txt, "&downarrow;", "↓");
            txt = Regex.Replace(txt, "&DownArrow;", "↓");
            txt = Regex.Replace(txt, "&ShortDownArrow;", "↓");

            // "U+02194", "LEFT RIGHT ARROW"
            txt = Regex.Replace(txt, "&#x0*?2194;", "↔");
            txt = Regex.Replace(txt, "&#0*?8596;", "↔");
            txt = Regex.Replace(txt, "&harr;", "↔");
            txt = Regex.Replace(txt, "&leftrightarrow;", "↔");
            txt = Regex.Replace(txt, "&LeftRightArrow;", "↔");

            // "U+02195", "UP DOWN ARROW"
            txt = Regex.Replace(txt, "&#x0*?2195;", "↕");
            txt = Regex.Replace(txt, "&#0*?8597;", "↕");
            txt = Regex.Replace(txt, "&varr;", "↕");
            txt = Regex.Replace(txt, "&updownarrow;", "↕");
            txt = Regex.Replace(txt, "&UpDownArrow;", "↕");

            // "U+02196", "NORTH WEST ARROW"
            txt = Regex.Replace(txt, "&#x0*?2196;", "↖");
            txt = Regex.Replace(txt, "&#0*?8598;", "↖");
            txt = Regex.Replace(txt, "&nwarr;", "↖");
            txt = Regex.Replace(txt, "&UpperLeftArrow;", "↖");
            txt = Regex.Replace(txt, "&nwarrow;", "↖");

            // "U+02197", "NORTH EAST ARROW"
            txt = Regex.Replace(txt, "&#x0*?2197;", "↗");
            txt = Regex.Replace(txt, "&#0*?8599;", "↗");
            txt = Regex.Replace(txt, "&nearr;", "↗");
            txt = Regex.Replace(txt, "&UpperRightArrow;", "↗");
            txt = Regex.Replace(txt, "&nearrow;", "↗");

            // "U+02198", "SOUTH EAST ARROW"
            txt = Regex.Replace(txt, "&#x0*?2198;", "↘");
            txt = Regex.Replace(txt, "&#0*?8600;", "↘");
            txt = Regex.Replace(txt, "&searr;", "↘");
            txt = Regex.Replace(txt, "&searrow;", "↘");
            txt = Regex.Replace(txt, "&LowerRightArrow;", "↘");

            // "U+02199", "SOUTH WEST ARROW"
            txt = Regex.Replace(txt, "&#x0*?2199;", "↙");
            txt = Regex.Replace(txt, "&#0*?8601;", "↙");
            txt = Regex.Replace(txt, "&swarr;", "↙");
            txt = Regex.Replace(txt, "&swarrow;", "↙");
            txt = Regex.Replace(txt, "&LowerLeftArrow;", "↙");

            // "U+0219A", "LEFTWARDS ARROW WITH STROKE"
            txt = Regex.Replace(txt, "&#x0*?219A;", "↚");
            txt = Regex.Replace(txt, "&#0*?8602;", "↚");
            txt = Regex.Replace(txt, "&nlarr;", "↚");
            txt = Regex.Replace(txt, "&nleftarrow;", "↚");

            // "U+0219B", "RIGHTWARDS ARROW WITH STROKE"
            txt = Regex.Replace(txt, "&#x0*?219B;", "↛");
            txt = Regex.Replace(txt, "&#0*?8603;", "↛");
            txt = Regex.Replace(txt, "&nrarr;", "↛");
            txt = Regex.Replace(txt, "&nrightarrow;", "↛");

            // "U+0219D", "RIGHTWARDS WAVE ARROW"
            txt = Regex.Replace(txt, "&#x0*?219D;", "↝");
            txt = Regex.Replace(txt, "&#0*?8605;", "↝");
            txt = Regex.Replace(txt, "&rarrw;", "↝");
            txt = Regex.Replace(txt, "&rightsquigarrow;", "↝");

            // "U+0219E", "LEFTWARDS TWO HEADED ARROW"
            txt = Regex.Replace(txt, "&#x0*?219E;", "↞");
            txt = Regex.Replace(txt, "&#0*?8606;", "↞");
            txt = Regex.Replace(txt, "&Larr;", "↞");
            txt = Regex.Replace(txt, "&twoheadleftarrow;", "↞");

            // "U+0219F", "UPWARDS TWO HEADED ARROW"
            txt = Regex.Replace(txt, "&#x0*?219F;", "↟");
            txt = Regex.Replace(txt, "&#0*?8607;", "↟");
            txt = Regex.Replace(txt, "&Uarr;", "↟");

            // "U+021A0", "RIGHTWARDS TWO HEADED ARROW"
            txt = Regex.Replace(txt, "&#x0*?21A0;", "↠");
            txt = Regex.Replace(txt, "&#0*?8608;", "↠");
            txt = Regex.Replace(txt, "&Rarr;", "↠");
            txt = Regex.Replace(txt, "&twoheadrightarrow;", "↠");

            // "U+021A1", "DOWNWARDS TWO HEADED ARROW"
            txt = Regex.Replace(txt, "&#x0*?21A1;", "↡");
            txt = Regex.Replace(txt, "&#0*?8609;", "↡");
            txt = Regex.Replace(txt, "&Darr;", "↡");

            // "U+021A2", "LEFTWARDS ARROW WITH TAIL"
            txt = Regex.Replace(txt, "&#x0*?21A2;", "↢");
            txt = Regex.Replace(txt, "&#0*?8610;", "↢");
            txt = Regex.Replace(txt, "&larrtl;", "↢");
            txt = Regex.Replace(txt, "&leftarrowtail;", "↢");

            // "U+021A3", "RIGHTWARDS ARROW WITH TAIL"
            txt = Regex.Replace(txt, "&#x0*?21A3;", "↣");
            txt = Regex.Replace(txt, "&#0*?8611;", "↣");
            txt = Regex.Replace(txt, "&rarrtl;", "↣");
            txt = Regex.Replace(txt, "&rightarrowtail;", "↣");

            // "U+021A4", "LEFTWARDS ARROW FROM BAR"
            txt = Regex.Replace(txt, "&#x0*?21A4;", "↤");
            txt = Regex.Replace(txt, "&#0*?8612;", "↤");
            txt = Regex.Replace(txt, "&LeftTeeArrow;", "↤");
            txt = Regex.Replace(txt, "&mapstoleft;", "↤");

            // "U+021A5", "UPWARDS ARROW FROM BAR"
            txt = Regex.Replace(txt, "&#x0*?21A5;", "↥");
            txt = Regex.Replace(txt, "&#0*?8613;", "↥");
            txt = Regex.Replace(txt, "&UpTeeArrow;", "↥");
            txt = Regex.Replace(txt, "&mapstoup;", "↥");

            // "U+021A6", "RIGHTWARDS ARROW FROM BAR"
            txt = Regex.Replace(txt, "&#x0*?21A6;", "↦");
            txt = Regex.Replace(txt, "&#0*?8614;", "↦");
            txt = Regex.Replace(txt, "&map;", "↦");
            txt = Regex.Replace(txt, "&RightTeeArrow;", "↦");
            txt = Regex.Replace(txt, "&mapsto;", "↦");

            // "U+021A7", "DOWNWARDS ARROW FROM BAR"
            txt = Regex.Replace(txt, "&#x0*?21A7;", "↧");
            txt = Regex.Replace(txt, "&#0*?8615;", "↧");
            txt = Regex.Replace(txt, "&DownTeeArrow;", "↧");
            txt = Regex.Replace(txt, "&mapstodown;", "↧");

            // "U+021A9", "LEFTWARDS ARROW WITH HOOK"
            txt = Regex.Replace(txt, "&#x0*?21A9;", "↩");
            txt = Regex.Replace(txt, "&#0*?8617;", "↩");
            txt = Regex.Replace(txt, "&larrhk;", "↩");
            txt = Regex.Replace(txt, "&hookleftarrow;", "↩");

            // "U+021AA", "RIGHTWARDS ARROW WITH HOOK"
            txt = Regex.Replace(txt, "&#x0*?21AA;", "↪");
            txt = Regex.Replace(txt, "&#0*?8618;", "↪");
            txt = Regex.Replace(txt, "&rarrhk;", "↪");
            txt = Regex.Replace(txt, "&hookrightarrow;", "↪");

            // "U+021AB", "LEFTWARDS ARROW WITH LOOP"
            txt = Regex.Replace(txt, "&#x0*?21AB;", "↫");
            txt = Regex.Replace(txt, "&#0*?8619;", "↫");
            txt = Regex.Replace(txt, "&larrlp;", "↫");
            txt = Regex.Replace(txt, "&looparrowleft;", "↫");

            // "U+021AC", "RIGHTWARDS ARROW WITH LOOP"
            txt = Regex.Replace(txt, "&#x0*?21AC;", "↬");
            txt = Regex.Replace(txt, "&#0*?8620;", "↬");
            txt = Regex.Replace(txt, "&rarrlp;", "↬");
            txt = Regex.Replace(txt, "&looparrowright;", "↬");

            // "U+021AD", "LEFT RIGHT WAVE ARROW"
            txt = Regex.Replace(txt, "&#x0*?21AD;", "↭");
            txt = Regex.Replace(txt, "&#0*?8621;", "↭");
            txt = Regex.Replace(txt, "&harrw;", "↭");
            txt = Regex.Replace(txt, "&leftrightsquigarrow;", "↭");

            // "U+021AE", "LEFT RIGHT ARROW WITH STROKE"
            txt = Regex.Replace(txt, "&#x0*?21AE;", "↮");
            txt = Regex.Replace(txt, "&#0*?8622;", "↮");
            txt = Regex.Replace(txt, "&nharr;", "↮");
            txt = Regex.Replace(txt, "&nleftrightarrow;", "↮");

            // "U+021B0", "UPWARDS ARROW WITH TIP LEFTWARDS"
            txt = Regex.Replace(txt, "&#x0*?21B0;", "↰");
            txt = Regex.Replace(txt, "&#0*?8624;", "↰");
            txt = Regex.Replace(txt, "&lsh;", "↰");
            txt = Regex.Replace(txt, "&Lsh;", "↰");

            // "U+021B1", "UPWARDS ARROW WITH TIP RIGHTWARDS"
            txt = Regex.Replace(txt, "&#x0*?21B1;", "↱");
            txt = Regex.Replace(txt, "&#0*?8625;", "↱");
            txt = Regex.Replace(txt, "&rsh;", "↱");
            txt = Regex.Replace(txt, "&Rsh;", "↱");

            // "U+021B2", "DOWNWARDS ARROW WITH TIP LEFTWARDS"
            txt = Regex.Replace(txt, "&#x0*?21B2;", "↲");
            txt = Regex.Replace(txt, "&#0*?8626;", "↲");
            txt = Regex.Replace(txt, "&ldsh;", "↲");

            // "U+021B3", "DOWNWARDS ARROW WITH TIP RIGHTWARDS"
            txt = Regex.Replace(txt, "&#x0*?21B3;", "↳");
            txt = Regex.Replace(txt, "&#0*?8627;", "↳");
            txt = Regex.Replace(txt, "&rdsh;", "↳");

            // "U+021B5", "DOWNWARDS ARROW WITH CORNER LEFTWARDS"
            txt = Regex.Replace(txt, "&#x0*?21B5;", "↵");
            txt = Regex.Replace(txt, "&#0*?8629;", "↵");
            txt = Regex.Replace(txt, "&crarr;", "↵");

            // "U+021B6", "ANTICLOCKWISE TOP SEMICIRCLE ARROW"
            txt = Regex.Replace(txt, "&#x0*?21B6;", "↶");
            txt = Regex.Replace(txt, "&#0*?8630;", "↶");
            txt = Regex.Replace(txt, "&cularr;", "↶");
            txt = Regex.Replace(txt, "&curvearrowleft;", "↶");

            // "U+021B7", "CLOCKWISE TOP SEMICIRCLE ARROW"
            txt = Regex.Replace(txt, "&#x0*?21B7;", "↷");
            txt = Regex.Replace(txt, "&#0*?8631;", "↷");
            txt = Regex.Replace(txt, "&curarr;", "↷");
            txt = Regex.Replace(txt, "&curvearrowright;", "↷");

            // "U+021BA", "ANTICLOCKWISE OPEN CIRCLE ARROW"
            txt = Regex.Replace(txt, "&#x0*?21BA;", "↺");
            txt = Regex.Replace(txt, "&#0*?8634;", "↺");
            txt = Regex.Replace(txt, "&olarr;", "↺");
            txt = Regex.Replace(txt, "&circlearrowleft;", "↺");

            // "U+021BB", "CLOCKWISE OPEN CIRCLE ARROW"
            txt = Regex.Replace(txt, "&#x0*?21BB;", "↻");
            txt = Regex.Replace(txt, "&#0*?8635;", "↻");
            txt = Regex.Replace(txt, "&orarr;", "↻");
            txt = Regex.Replace(txt, "&circlearrowright;", "↻");

            // "U+021BC", "LEFTWARDS HARPOON WITH BARB UPWARDS"
            txt = Regex.Replace(txt, "&#x0*?21BC;", "↼");
            txt = Regex.Replace(txt, "&#0*?8636;", "↼");
            txt = Regex.Replace(txt, "&lharu;", "↼");
            txt = Regex.Replace(txt, "&LeftVector;", "↼");
            txt = Regex.Replace(txt, "&leftharpoonup;", "↼");

            // "U+021BD", "LEFTWARDS HARPOON WITH BARB DOWNWARDS"
            txt = Regex.Replace(txt, "&#x0*?21BD;", "↽");
            txt = Regex.Replace(txt, "&#0*?8637;", "↽");
            txt = Regex.Replace(txt, "&lhard;", "↽");
            txt = Regex.Replace(txt, "&leftharpoondown;", "↽");
            txt = Regex.Replace(txt, "&DownLeftVector;", "↽");

            // "U+021BE", "UPWARDS HARPOON WITH BARB RIGHTWARDS"
            txt = Regex.Replace(txt, "&#x0*?21BE;", "↾");
            txt = Regex.Replace(txt, "&#0*?8638;", "↾");
            txt = Regex.Replace(txt, "&uharr;", "↾");
            txt = Regex.Replace(txt, "&upharpoonright;", "↾");
            txt = Regex.Replace(txt, "&RightUpVector;", "↾");

            // "U+021BF", "UPWARDS HARPOON WITH BARB LEFTWARDS"
            txt = Regex.Replace(txt, "&#x0*?21BF;", "↿");
            txt = Regex.Replace(txt, "&#0*?8639;", "↿");
            txt = Regex.Replace(txt, "&uharl;", "↿");
            txt = Regex.Replace(txt, "&upharpoonleft;", "↿");
            txt = Regex.Replace(txt, "&LeftUpVector;", "↿");

            // "U+021C0", "RIGHTWARDS HARPOON WITH BARB UPWARDS"
            txt = Regex.Replace(txt, "&#x0*?21C0;", "⇀");
            txt = Regex.Replace(txt, "&#0*?8640;", "⇀");
            txt = Regex.Replace(txt, "&rharu;", "⇀");
            txt = Regex.Replace(txt, "&RightVector;", "⇀");
            txt = Regex.Replace(txt, "&rightharpoonup;", "⇀");

            // "U+021C1", "RIGHTWARDS HARPOON WITH BARB DOWNWARDS"
            txt = Regex.Replace(txt, "&#x0*?21C1;", "⇁");
            txt = Regex.Replace(txt, "&#0*?8641;", "⇁");
            txt = Regex.Replace(txt, "&rhard;", "⇁");
            txt = Regex.Replace(txt, "&rightharpoondown;", "⇁");
            txt = Regex.Replace(txt, "&DownRightVector;", "⇁");

            // "U+021C2", "DOWNWARDS HARPOON WITH BARB RIGHTWARDS"
            txt = Regex.Replace(txt, "&#x0*?21C2;", "⇂");
            txt = Regex.Replace(txt, "&#0*?8642;", "⇂");
            txt = Regex.Replace(txt, "&dharr;", "⇂");
            txt = Regex.Replace(txt, "&RightDownVector;", "⇂");
            txt = Regex.Replace(txt, "&downharpoonright;", "⇂");

            // "U+021C3", "DOWNWARDS HARPOON WITH BARB LEFTWARDS"
            txt = Regex.Replace(txt, "&#x0*?21C3;", "⇃");
            txt = Regex.Replace(txt, "&#0*?8643;", "⇃");
            txt = Regex.Replace(txt, "&dharl;", "⇃");
            txt = Regex.Replace(txt, "&LeftDownVector;", "⇃");
            txt = Regex.Replace(txt, "&downharpoonleft;", "⇃");

            // "U+021C4", "RIGHTWARDS ARROW OVER LEFTWARDS ARROW"
            txt = Regex.Replace(txt, "&#x0*?21C4;", "⇄");
            txt = Regex.Replace(txt, "&#0*?8644;", "⇄");
            txt = Regex.Replace(txt, "&rlarr;", "⇄");
            txt = Regex.Replace(txt, "&rightleftarrows;", "⇄");
            txt = Regex.Replace(txt, "&RightArrowLeftArrow;", "⇄");

            // "U+021C5", "UPWARDS ARROW LEFTWARDS OF DOWNWARDS ARROW"
            txt = Regex.Replace(txt, "&#x0*?21C5;", "⇅");
            txt = Regex.Replace(txt, "&#0*?8645;", "⇅");
            txt = Regex.Replace(txt, "&udarr;", "⇅");
            txt = Regex.Replace(txt, "&UpArrowDownArrow;", "⇅");

            // "U+021C6", "LEFTWARDS ARROW OVER RIGHTWARDS ARROW"
            txt = Regex.Replace(txt, "&#x0*?21C6;", "⇆");
            txt = Regex.Replace(txt, "&#0*?8646;", "⇆");
            txt = Regex.Replace(txt, "&lrarr;", "⇆");
            txt = Regex.Replace(txt, "&leftrightarrows;", "⇆");
            txt = Regex.Replace(txt, "&LeftArrowRightArrow;", "⇆");

            // "U+021C7", "LEFTWARDS PAIRED ARROWS"
            txt = Regex.Replace(txt, "&#x0*?21C7;", "⇇");
            txt = Regex.Replace(txt, "&#0*?8647;", "⇇");
            txt = Regex.Replace(txt, "&llarr;", "⇇");
            txt = Regex.Replace(txt, "&leftleftarrows;", "⇇");

            // "U+021C8", "UPWARDS PAIRED ARROWS"
            txt = Regex.Replace(txt, "&#x0*?21C8;", "⇈");
            txt = Regex.Replace(txt, "&#0*?8648;", "⇈");
            txt = Regex.Replace(txt, "&uuarr;", "⇈");
            txt = Regex.Replace(txt, "&upuparrows;", "⇈");

            // "U+021C9", "RIGHTWARDS PAIRED ARROWS"
            txt = Regex.Replace(txt, "&#x0*?21C9;", "⇉");
            txt = Regex.Replace(txt, "&#0*?8649;", "⇉");
            txt = Regex.Replace(txt, "&rrarr;", "⇉");
            txt = Regex.Replace(txt, "&rightrightarrows;", "⇉");

            // "U+021CA", "DOWNWARDS PAIRED ARROWS"
            txt = Regex.Replace(txt, "&#x0*?21CA;", "⇊");
            txt = Regex.Replace(txt, "&#0*?8650;", "⇊");
            txt = Regex.Replace(txt, "&ddarr;", "⇊");
            txt = Regex.Replace(txt, "&downdownarrows;", "⇊");

            // "U+021CB", "LEFTWARDS HARPOON OVER RIGHTWARDS HARPOON"
            txt = Regex.Replace(txt, "&#x0*?21CB;", "⇋");
            txt = Regex.Replace(txt, "&#0*?8651;", "⇋");
            txt = Regex.Replace(txt, "&lrhar;", "⇋");
            txt = Regex.Replace(txt, "&ReverseEquilibrium;", "⇋");
            txt = Regex.Replace(txt, "&leftrightharpoons;", "⇋");

            // "U+021CC", "RIGHTWARDS HARPOON OVER LEFTWARDS HARPOON"
            txt = Regex.Replace(txt, "&#x0*?21CC;", "⇌");
            txt = Regex.Replace(txt, "&#0*?8652;", "⇌");
            txt = Regex.Replace(txt, "&rlhar;", "⇌");
            txt = Regex.Replace(txt, "&rightleftharpoons;", "⇌");
            txt = Regex.Replace(txt, "&Equilibrium;", "⇌");

            // "U+021CD", "LEFTWARDS DOUBLE ARROW WITH STROKE"
            txt = Regex.Replace(txt, "&#x0*?21CD;", "⇍");
            txt = Regex.Replace(txt, "&#0*?8653;", "⇍");
            txt = Regex.Replace(txt, "&nlArr;", "⇍");
            txt = Regex.Replace(txt, "&nLeftarrow;", "⇍");

            // "U+021CE", "LEFT RIGHT DOUBLE ARROW WITH STROKE"
            txt = Regex.Replace(txt, "&#x0*?21CE;", "⇎");
            txt = Regex.Replace(txt, "&#0*?8654;", "⇎");
            txt = Regex.Replace(txt, "&nhArr;", "⇎");
            txt = Regex.Replace(txt, "&nLeftrightarrow;", "⇎");

            // "U+021CF", "RIGHTWARDS DOUBLE ARROW WITH STROKE"
            txt = Regex.Replace(txt, "&#x0*?21CF;", "⇏");
            txt = Regex.Replace(txt, "&#0*?8655;", "⇏");
            txt = Regex.Replace(txt, "&nrArr;", "⇏");
            txt = Regex.Replace(txt, "&nRightarrow;", "⇏");

            // "U+021D0", "LEFTWARDS DOUBLE ARROW"
            txt = Regex.Replace(txt, "&#x0*?21D0;", "⇐");
            txt = Regex.Replace(txt, "&#0*?8656;", "⇐");
            txt = Regex.Replace(txt, "&lArr;", "⇐");
            txt = Regex.Replace(txt, "&Leftarrow;", "⇐");
            txt = Regex.Replace(txt, "&DoubleLeftArrow;", "⇐");

            // "U+021D1", "UPWARDS DOUBLE ARROW"
            txt = Regex.Replace(txt, "&#x0*?21D1;", "⇑");
            txt = Regex.Replace(txt, "&#0*?8657;", "⇑");
            txt = Regex.Replace(txt, "&uArr;", "⇑");
            txt = Regex.Replace(txt, "&Uparrow;", "⇑");
            txt = Regex.Replace(txt, "&DoubleUpArrow;", "⇑");

            // "U+021D2", "RIGHTWARDS DOUBLE ARROW"
            txt = Regex.Replace(txt, "&#x0*?21D2;", "⇒");
            txt = Regex.Replace(txt, "&#0*?8658;", "⇒");
            txt = Regex.Replace(txt, "&rArr;", "⇒");
            txt = Regex.Replace(txt, "&Rightarrow;", "⇒");
            txt = Regex.Replace(txt, "&Implies;", "⇒");
            txt = Regex.Replace(txt, "&DoubleRightArrow;", "⇒");

            // "U+021D3", "DOWNWARDS DOUBLE ARROW"
            txt = Regex.Replace(txt, "&#x0*?21D3;", "⇓");
            txt = Regex.Replace(txt, "&#0*?8659;", "⇓");
            txt = Regex.Replace(txt, "&dArr;", "⇓");
            txt = Regex.Replace(txt, "&Downarrow;", "⇓");
            txt = Regex.Replace(txt, "&DoubleDownArrow;", "⇓");

            // "U+021D4", "LEFT RIGHT DOUBLE ARROW"
            txt = Regex.Replace(txt, "&#x0*?21D4;", "⇔");
            txt = Regex.Replace(txt, "&#0*?8660;", "⇔");
            txt = Regex.Replace(txt, "&hArr;", "⇔");
            txt = Regex.Replace(txt, "&Leftrightarrow;", "⇔");
            txt = Regex.Replace(txt, "&DoubleLeftRightArrow;", "⇔");
            txt = Regex.Replace(txt, "&iff;", "⇔");

            // "U+021D5", "UP DOWN DOUBLE ARROW"
            txt = Regex.Replace(txt, "&#x0*?21D5;", "⇕");
            txt = Regex.Replace(txt, "&#0*?8661;", "⇕");
            txt = Regex.Replace(txt, "&vArr;", "⇕");
            txt = Regex.Replace(txt, "&Updownarrow;", "⇕");
            txt = Regex.Replace(txt, "&DoubleUpDownArrow;", "⇕");

            // "U+021D6", "NORTH WEST DOUBLE ARROW"
            txt = Regex.Replace(txt, "&#x0*?21D6;", "⇖");
            txt = Regex.Replace(txt, "&#0*?8662;", "⇖");
            txt = Regex.Replace(txt, "&nwArr;", "⇖");

            // "U+021D7", "NORTH EAST DOUBLE ARROW"
            txt = Regex.Replace(txt, "&#x0*?21D7;", "⇗");
            txt = Regex.Replace(txt, "&#0*?8663;", "⇗");
            txt = Regex.Replace(txt, "&neArr;", "⇗");

            // "U+021D8", "SOUTH EAST DOUBLE ARROW"
            txt = Regex.Replace(txt, "&#x0*?21D8;", "⇘");
            txt = Regex.Replace(txt, "&#0*?8664;", "⇘");
            txt = Regex.Replace(txt, "&seArr;", "⇘");

            // "U+021D9", "SOUTH WEST DOUBLE ARROW"
            txt = Regex.Replace(txt, "&#x0*?21D9;", "⇙");
            txt = Regex.Replace(txt, "&#0*?8665;", "⇙");
            txt = Regex.Replace(txt, "&swArr;", "⇙");

            // "U+021DA", "LEFTWARDS TRIPLE ARROW"
            txt = Regex.Replace(txt, "&#x0*?21DA;", "⇚");
            txt = Regex.Replace(txt, "&#0*?8666;", "⇚");
            txt = Regex.Replace(txt, "&lAarr;", "⇚");
            txt = Regex.Replace(txt, "&Lleftarrow;", "⇚");

            // "U+021DB", "RIGHTWARDS TRIPLE ARROW"
            txt = Regex.Replace(txt, "&#x0*?21DB;", "⇛");
            txt = Regex.Replace(txt, "&#0*?8667;", "⇛");
            txt = Regex.Replace(txt, "&rAarr;", "⇛");
            txt = Regex.Replace(txt, "&Rrightarrow;", "⇛");

            // "U+021DD", "RIGHTWARDS SQUIGGLE ARROW"
            txt = Regex.Replace(txt, "&#x0*?21DD;", "⇝");
            txt = Regex.Replace(txt, "&#0*?8669;", "⇝");
            txt = Regex.Replace(txt, "&zigrarr;", "⇝");

            // "U+021E4", "LEFTWARDS ARROW TO BAR"
            txt = Regex.Replace(txt, "&#x0*?21E4;", "⇤");
            txt = Regex.Replace(txt, "&#0*?8676;", "⇤");
            txt = Regex.Replace(txt, "&larrb;", "⇤");
            txt = Regex.Replace(txt, "&LeftArrowBar;", "⇤");

            // "U+021E5", "RIGHTWARDS ARROW TO BAR"
            txt = Regex.Replace(txt, "&#x0*?21E5;", "⇥");
            txt = Regex.Replace(txt, "&#0*?8677;", "⇥");
            txt = Regex.Replace(txt, "&rarrb;", "⇥");
            txt = Regex.Replace(txt, "&RightArrowBar;", "⇥");

            // "U+021F5", "DOWNWARDS ARROW LEFTWARDS OF UPWARDS ARROW"
            txt = Regex.Replace(txt, "&#x0*?21F5;", "⇵");
            txt = Regex.Replace(txt, "&#0*?8693;", "⇵");
            txt = Regex.Replace(txt, "&duarr;", "⇵");
            txt = Regex.Replace(txt, "&DownArrowUpArrow;", "⇵");

            // "U+021FD", "LEFTWARDS OPEN-HEADED ARROW"
            txt = Regex.Replace(txt, "&#x0*?21FD;", "⇽");
            txt = Regex.Replace(txt, "&#0*?8701;", "⇽");
            txt = Regex.Replace(txt, "&loarr;", "⇽");

            // "U+021FE", "RIGHTWARDS OPEN-HEADED ARROW"
            txt = Regex.Replace(txt, "&#x0*?21FE;", "⇾");
            txt = Regex.Replace(txt, "&#0*?8702;", "⇾");
            txt = Regex.Replace(txt, "&roarr;", "⇾");

            // "U+021FF", "LEFT RIGHT OPEN-HEADED ARROW"
            txt = Regex.Replace(txt, "&#x0*?21FF;", "⇿");
            txt = Regex.Replace(txt, "&#0*?8703;", "⇿");
            txt = Regex.Replace(txt, "&hoarr;", "⇿");

            // "U+02200", "FOR ALL"
            txt = Regex.Replace(txt, "&#x0*?2200;", "∀");
            txt = Regex.Replace(txt, "&#0*?8704;", "∀");
            txt = Regex.Replace(txt, "&forall;", "∀");
            txt = Regex.Replace(txt, "&ForAll;", "∀");

            // "U+02201", "COMPLEMENT"
            txt = Regex.Replace(txt, "&#x0*?2201;", "∁");
            txt = Regex.Replace(txt, "&#0*?8705;", "∁");
            txt = Regex.Replace(txt, "&comp;", "∁");
            txt = Regex.Replace(txt, "&complement;", "∁");

            // "U+02202", "PARTIAL DIFFERENTIAL"
            txt = Regex.Replace(txt, "&#x0*?2202;", "∂");
            txt = Regex.Replace(txt, "&#0*?8706;", "∂");
            txt = Regex.Replace(txt, "&part;", "∂");
            txt = Regex.Replace(txt, "&PartialD;", "∂");

            // "U+02203", "THERE EXISTS"
            txt = Regex.Replace(txt, "&#x0*?2203;", "∃");
            txt = Regex.Replace(txt, "&#0*?8707;", "∃");
            txt = Regex.Replace(txt, "&exist;", "∃");
            txt = Regex.Replace(txt, "&Exists;", "∃");

            // "U+02204", "THERE DOES NOT EXIST"
            txt = Regex.Replace(txt, "&#x0*?2204;", "∄");
            txt = Regex.Replace(txt, "&#0*?8708;", "∄");
            txt = Regex.Replace(txt, "&nexist;", "∄");
            txt = Regex.Replace(txt, "&NotExists;", "∄");
            txt = Regex.Replace(txt, "&nexists;", "∄");

            // "U+02205", "EMPTY SET"
            txt = Regex.Replace(txt, "&#x0*?2205;", "∅");
            txt = Regex.Replace(txt, "&#0*?8709;", "∅");
            txt = Regex.Replace(txt, "&empty;", "∅");
            txt = Regex.Replace(txt, "&emptyset;", "∅");
            txt = Regex.Replace(txt, "&emptyv;", "∅");
            txt = Regex.Replace(txt, "&varnothing;", "∅");

            // "U+02207", "NABLA"
            txt = Regex.Replace(txt, "&#x0*?2207;", "∇");
            txt = Regex.Replace(txt, "&#0*?8711;", "∇");
            txt = Regex.Replace(txt, "&nabla;", "∇");
            txt = Regex.Replace(txt, "&Del;", "∇");

            // "U+02208", "ELEMENT OF"
            txt = Regex.Replace(txt, "&#x0*?2208;", "∈");
            txt = Regex.Replace(txt, "&#0*?8712;", "∈");
            txt = Regex.Replace(txt, "&isin;", "∈");
            txt = Regex.Replace(txt, "&isinv;", "∈");
            txt = Regex.Replace(txt, "&Element;", "∈");
            txt = Regex.Replace(txt, "&in;", "∈");

            // "U+02209", "NOT AN ELEMENT OF"
            txt = Regex.Replace(txt, "&#x0*?2209;", "∉");
            txt = Regex.Replace(txt, "&#0*?8713;", "∉");
            txt = Regex.Replace(txt, "&notin;", "∉");
            txt = Regex.Replace(txt, "&NotElement;", "∉");
            txt = Regex.Replace(txt, "&notinva;", "∉");

            // "U+0220B", "CONTAINS AS MEMBER"
            txt = Regex.Replace(txt, "&#x0*?220B;", "∋");
            txt = Regex.Replace(txt, "&#0*?8715;", "∋");
            txt = Regex.Replace(txt, "&niv;", "∋");
            txt = Regex.Replace(txt, "&ReverseElement;", "∋");
            txt = Regex.Replace(txt, "&ni;", "∋");
            txt = Regex.Replace(txt, "&SuchThat;", "∋");

            // "U+0220C", "DOES NOT CONTAIN AS MEMBER"
            txt = Regex.Replace(txt, "&#x0*?220C;", "∌");
            txt = Regex.Replace(txt, "&#0*?8716;", "∌");
            txt = Regex.Replace(txt, "&notni;", "∌");
            txt = Regex.Replace(txt, "&notniva;", "∌");
            txt = Regex.Replace(txt, "&NotReverseElement;", "∌");

            // "U+0220F", "N-ARY PRODUCT"
            txt = Regex.Replace(txt, "&#x0*?220F;", "∏");
            txt = Regex.Replace(txt, "&#0*?8719;", "∏");
            txt = Regex.Replace(txt, "&prod;", "∏");
            txt = Regex.Replace(txt, "&Product;", "∏");

            // "U+02210", "N-ARY COPRODUCT"
            txt = Regex.Replace(txt, "&#x0*?2210;", "∐");
            txt = Regex.Replace(txt, "&#0*?8720;", "∐");
            txt = Regex.Replace(txt, "&coprod;", "∐");
            txt = Regex.Replace(txt, "&Coproduct;", "∐");

            // "U+02211", "N-ARY SUMMATION"
            txt = Regex.Replace(txt, "&#x0*?2211;", "∑");
            txt = Regex.Replace(txt, "&#0*?8721;", "∑");
            txt = Regex.Replace(txt, "&sum;", "∑");
            txt = Regex.Replace(txt, "&Sum;", "∑");

            // "U+02212", "MINUS SIGN"
            txt = Regex.Replace(txt, "&#x0*?2212;", "−");
            txt = Regex.Replace(txt, "&#0*?8722;", "−");
            txt = Regex.Replace(txt, "&minus;", "−");

            // "U+02213", "MINUS-OR-PLUS SIGN"
            txt = Regex.Replace(txt, "&#x0*?2213;", "∓");
            txt = Regex.Replace(txt, "&#0*?8723;", "∓");
            txt = Regex.Replace(txt, "&mnplus;", "∓");
            txt = Regex.Replace(txt, "&mp;", "∓");
            txt = Regex.Replace(txt, "&MinusPlus;", "∓");

            // "U+02214", "DOT PLUS"
            txt = Regex.Replace(txt, "&#x0*?2214;", "∔");
            txt = Regex.Replace(txt, "&#0*?8724;", "∔");
            txt = Regex.Replace(txt, "&plusdo;", "∔");
            txt = Regex.Replace(txt, "&dotplus;", "∔");

            // "U+02216", "SET MINUS"
            txt = Regex.Replace(txt, "&#x0*?2216;", "∖");
            txt = Regex.Replace(txt, "&#0*?8726;", "∖");
            txt = Regex.Replace(txt, "&setmn;", "∖");
            txt = Regex.Replace(txt, "&setminus;", "∖");
            txt = Regex.Replace(txt, "&Backslash;", "∖");
            txt = Regex.Replace(txt, "&ssetmn;", "∖");
            txt = Regex.Replace(txt, "&smallsetminus;", "∖");

            // "U+02217", "ASTERISK OPERATOR"
            txt = Regex.Replace(txt, "&#x0*?2217;", "∗");
            txt = Regex.Replace(txt, "&#0*?8727;", "∗");
            txt = Regex.Replace(txt, "&lowast;", "∗");

            // "U+02218", "RING OPERATOR"
            txt = Regex.Replace(txt, "&#x0*?2218;", "∘");
            txt = Regex.Replace(txt, "&#0*?8728;", "∘");
            txt = Regex.Replace(txt, "&compfn;", "∘");
            txt = Regex.Replace(txt, "&SmallCircle;", "∘");

            // "U+0221A", "SQUARE ROOT"
            txt = Regex.Replace(txt, "&#x0*?221A;", "√");
            txt = Regex.Replace(txt, "&#0*?8730;", "√");
            txt = Regex.Replace(txt, "&radic;", "√");
            txt = Regex.Replace(txt, "&Sqrt;", "√");

            // "U+0221D", "PROPORTIONAL TO"
            txt = Regex.Replace(txt, "&#x0*?221D;", "∝");
            txt = Regex.Replace(txt, "&#0*?8733;", "∝");
            txt = Regex.Replace(txt, "&prop;", "∝");
            txt = Regex.Replace(txt, "&propto;", "∝");
            txt = Regex.Replace(txt, "&Proportional;", "∝");
            txt = Regex.Replace(txt, "&vprop;", "∝");
            txt = Regex.Replace(txt, "&varpropto;", "∝");

            // "U+0221E", "INFINITY"
            txt = Regex.Replace(txt, "&#x0*?221E;", "∞");
            txt = Regex.Replace(txt, "&#0*?8734;", "∞");
            txt = Regex.Replace(txt, "&infin;", "∞");

            // "U+0221F", "RIGHT ANGLE"
            txt = Regex.Replace(txt, "&#x0*?221F;", "∟");
            txt = Regex.Replace(txt, "&#0*?8735;", "∟");
            txt = Regex.Replace(txt, "&angrt;", "∟");

            // "U+02220", "ANGLE"
            txt = Regex.Replace(txt, "&#x0*?2220;", "∠");
            txt = Regex.Replace(txt, "&#0*?8736;", "∠");
            txt = Regex.Replace(txt, "&ang;", "∠");
            txt = Regex.Replace(txt, "&angle;", "∠");

            // "U+02221", "MEASURED ANGLE"
            txt = Regex.Replace(txt, "&#x0*?2221;", "∡");
            txt = Regex.Replace(txt, "&#0*?8737;", "∡");
            txt = Regex.Replace(txt, "&angmsd;", "∡");
            txt = Regex.Replace(txt, "&measuredangle;", "∡");

            // "U+02222", "SPHERICAL ANGLE"
            txt = Regex.Replace(txt, "&#x0*?2222;", "∢");
            txt = Regex.Replace(txt, "&#0*?8738;", "∢");
            txt = Regex.Replace(txt, "&angsph;", "∢");

            // "U+02223", "DIVIDES"
            txt = Regex.Replace(txt, "&#x0*?2223;", "∣");
            txt = Regex.Replace(txt, "&#0*?8739;", "∣");
            txt = Regex.Replace(txt, "&mid;", "∣");
            txt = Regex.Replace(txt, "&VerticalBar;", "∣");
            txt = Regex.Replace(txt, "&smid;", "∣");
            txt = Regex.Replace(txt, "&shortmid;", "∣");

            // "U+02224", "DOES NOT DIVIDE"
            txt = Regex.Replace(txt, "&#x0*?2224;", "∤");
            txt = Regex.Replace(txt, "&#0*?8740;", "∤");
            txt = Regex.Replace(txt, "&nmid;", "∤");
            txt = Regex.Replace(txt, "&NotVerticalBar;", "∤");
            txt = Regex.Replace(txt, "&nsmid;", "∤");
            txt = Regex.Replace(txt, "&nshortmid;", "∤");

            // "U+02225", "PARALLEL TO"
            txt = Regex.Replace(txt, "&#x0*?2225;", "∥");
            txt = Regex.Replace(txt, "&#0*?8741;", "∥");
            txt = Regex.Replace(txt, "&par;", "∥");
            txt = Regex.Replace(txt, "&parallel;", "∥");
            txt = Regex.Replace(txt, "&DoubleVerticalBar;", "∥");
            txt = Regex.Replace(txt, "&spar;", "∥");
            txt = Regex.Replace(txt, "&shortparallel;", "∥");

            // "U+02226", "NOT PARALLEL TO"
            txt = Regex.Replace(txt, "&#x0*?2226;", "∦");
            txt = Regex.Replace(txt, "&#0*?8742;", "∦");
            txt = Regex.Replace(txt, "&npar;", "∦");
            txt = Regex.Replace(txt, "&nparallel;", "∦");
            txt = Regex.Replace(txt, "&NotDoubleVerticalBar;", "∦");
            txt = Regex.Replace(txt, "&nspar;", "∦");
            txt = Regex.Replace(txt, "&nshortparallel;", "∦");

            // "U+02227", "LOGICAL AND"
            txt = Regex.Replace(txt, "&#x0*?2227;", "∧");
            txt = Regex.Replace(txt, "&#0*?8743;", "∧");
            txt = Regex.Replace(txt, "&and;", "∧");
            txt = Regex.Replace(txt, "&wedge;", "∧");

            // "U+02228", "LOGICAL OR"
            txt = Regex.Replace(txt, "&#x0*?2228;", "∨");
            txt = Regex.Replace(txt, "&#0*?8744;", "∨");
            txt = Regex.Replace(txt, "&or;", "∨");
            txt = Regex.Replace(txt, "&vee;", "∨");

            // "U+02229", "INTERSECTION"
            txt = Regex.Replace(txt, "&#x0*?2229;", "∩");
            txt = Regex.Replace(txt, "&#0*?8745;", "∩");
            txt = Regex.Replace(txt, "&cap;", "∩");

            // "U+0222A", "UNION"
            txt = Regex.Replace(txt, "&#x0*?222A;", "∪");
            txt = Regex.Replace(txt, "&#0*?8746;", "∪");
            txt = Regex.Replace(txt, "&cup;", "∪");

            // "U+0222B", "INTEGRAL"
            txt = Regex.Replace(txt, "&#x0*?222B;", "∫");
            txt = Regex.Replace(txt, "&#0*?8747;", "∫");
            txt = Regex.Replace(txt, "&int;", "∫");
            txt = Regex.Replace(txt, "&Integral;", "∫");

            // "U+0222C", "DOUBLE INTEGRAL"
            txt = Regex.Replace(txt, "&#x0*?222C;", "∬");
            txt = Regex.Replace(txt, "&#0*?8748;", "∬");
            txt = Regex.Replace(txt, "&Int;", "∬");

            // "U+0222D", "TRIPLE INTEGRAL"
            txt = Regex.Replace(txt, "&#x0*?222D;", "∭");
            txt = Regex.Replace(txt, "&#0*?8749;", "∭");
            txt = Regex.Replace(txt, "&tint;", "∭");
            txt = Regex.Replace(txt, "&iiint;", "∭");

            // "U+0222E", "CONTOUR INTEGRAL"
            txt = Regex.Replace(txt, "&#x0*?222E;", "∮");
            txt = Regex.Replace(txt, "&#0*?8750;", "∮");
            txt = Regex.Replace(txt, "&conint;", "∮");
            txt = Regex.Replace(txt, "&oint;", "∮");
            txt = Regex.Replace(txt, "&ContourIntegral;", "∮");

            // "U+0222F", "SURFACE INTEGRAL"
            txt = Regex.Replace(txt, "&#x0*?222F;", "∯");
            txt = Regex.Replace(txt, "&#0*?8751;", "∯");
            txt = Regex.Replace(txt, "&Conint;", "∯");
            txt = Regex.Replace(txt, "&DoubleContourIntegral;", "∯");

            // "U+02230", "VOLUME INTEGRAL"
            txt = Regex.Replace(txt, "&#x0*?2230;", "∰");
            txt = Regex.Replace(txt, "&#0*?8752;", "∰");
            txt = Regex.Replace(txt, "&Cconint;", "∰");

            // "U+02231", "CLOCKWISE INTEGRAL"
            txt = Regex.Replace(txt, "&#x0*?2231;", "∱");
            txt = Regex.Replace(txt, "&#0*?8753;", "∱");
            txt = Regex.Replace(txt, "&cwint;", "∱");

            // "U+02232", "CLOCKWISE CONTOUR INTEGRAL"
            txt = Regex.Replace(txt, "&#x0*?2232;", "∲");
            txt = Regex.Replace(txt, "&#0*?8754;", "∲");
            txt = Regex.Replace(txt, "&cwconint;", "∲");
            txt = Regex.Replace(txt, "&ClockwiseContourIntegral;", "∲");

            // "U+02233", "ANTICLOCKWISE CONTOUR INTEGRAL"
            txt = Regex.Replace(txt, "&#x0*?2233;", "∳");
            txt = Regex.Replace(txt, "&#0*?8755;", "∳");
            txt = Regex.Replace(txt, "&awconint;", "∳");
            txt = Regex.Replace(txt, "&CounterClockwiseContourIntegral;", "∳");

            // "U+02234", "THEREFORE"
            txt = Regex.Replace(txt, "&#x0*?2234;", "∴");
            txt = Regex.Replace(txt, "&#0*?8756;", "∴");
            txt = Regex.Replace(txt, "&there4;", "∴");
            txt = Regex.Replace(txt, "&therefore;", "∴");
            txt = Regex.Replace(txt, "&Therefore;", "∴");

            // "U+02235", "BECAUSE"
            txt = Regex.Replace(txt, "&#x0*?2235;", "∵");
            txt = Regex.Replace(txt, "&#0*?8757;", "∵");
            txt = Regex.Replace(txt, "&becaus;", "∵");
            txt = Regex.Replace(txt, "&because;", "∵");
            txt = Regex.Replace(txt, "&Because;", "∵");

            // "U+02236", "RATIO"
            txt = Regex.Replace(txt, "&#x0*?2236;", "∶");
            txt = Regex.Replace(txt, "&#0*?8758;", "∶");
            txt = Regex.Replace(txt, "&ratio;", "∶");

            // "U+02237", "PROPORTION"
            txt = Regex.Replace(txt, "&#x0*?2237;", "∷");
            txt = Regex.Replace(txt, "&#0*?8759;", "∷");
            txt = Regex.Replace(txt, "&Colon;", "∷");
            txt = Regex.Replace(txt, "&Proportion;", "∷");

            // "U+02238", "DOT MINUS"
            txt = Regex.Replace(txt, "&#x0*?2238;", "∸");
            txt = Regex.Replace(txt, "&#0*?8760;", "∸");
            txt = Regex.Replace(txt, "&minusd;", "∸");
            txt = Regex.Replace(txt, "&dotminus;", "∸");

            // "U+0223A", "GEOMETRIC PROPORTION"
            txt = Regex.Replace(txt, "&#x0*?223A;", "∺");
            txt = Regex.Replace(txt, "&#0*?8762;", "∺");
            txt = Regex.Replace(txt, "&mDDot;", "∺");

            // "U+0223B", "HOMOTHETIC"
            txt = Regex.Replace(txt, "&#x0*?223B;", "∻");
            txt = Regex.Replace(txt, "&#0*?8763;", "∻");
            txt = Regex.Replace(txt, "&homtht;", "∻");

            // "U+0223C", "TILDE OPERATOR"
            txt = Regex.Replace(txt, "&#x0*?223C;", "∼");
            txt = Regex.Replace(txt, "&#0*?8764;", "∼");
            txt = Regex.Replace(txt, "&sim;", "∼");
            txt = Regex.Replace(txt, "&Tilde;", "∼");
            txt = Regex.Replace(txt, "&thksim;", "∼");
            txt = Regex.Replace(txt, "&thicksim;", "∼");

            // "U+0223D", "REVERSED TILDE"
            txt = Regex.Replace(txt, "&#x0*?223D;", "∽");
            txt = Regex.Replace(txt, "&#0*?8765;", "∽");
            txt = Regex.Replace(txt, "&bsim;", "∽");
            txt = Regex.Replace(txt, "&backsim;", "∽");

            // "U+0223E", "INVERTED LAZY S"
            txt = Regex.Replace(txt, "&#x0*?223E;", "∾");
            txt = Regex.Replace(txt, "&#0*?8766;", "∾");
            txt = Regex.Replace(txt, "&ac;", "∾");
            txt = Regex.Replace(txt, "&mstpos;", "∾");

            // "U+0223F", "SINE WAVE"
            txt = Regex.Replace(txt, "&#x0*?223F;", "∿");
            txt = Regex.Replace(txt, "&#0*?8767;", "∿");
            txt = Regex.Replace(txt, "&acd;", "∿");

            // "U+02240", "WREATH PRODUCT"
            txt = Regex.Replace(txt, "&#x0*?2240;", "≀");
            txt = Regex.Replace(txt, "&#0*?8768;", "≀");
            txt = Regex.Replace(txt, "&wreath;", "≀");
            txt = Regex.Replace(txt, "&VerticalTilde;", "≀");
            txt = Regex.Replace(txt, "&wr;", "≀");

            // "U+02241", "NOT TILDE"
            txt = Regex.Replace(txt, "&#x0*?2241;", "≁");
            txt = Regex.Replace(txt, "&#0*?8769;", "≁");
            txt = Regex.Replace(txt, "&nsim;", "≁");
            txt = Regex.Replace(txt, "&NotTilde;", "≁");

            // "U+02242", "MINUS TILDE"
            txt = Regex.Replace(txt, "&#x0*?2242;", "≂");
            txt = Regex.Replace(txt, "&#0*?8770;", "≂");
            txt = Regex.Replace(txt, "&esim;", "≂");
            txt = Regex.Replace(txt, "&EqualTilde;", "≂");
            txt = Regex.Replace(txt, "&eqsim;", "≂");

            // "U+02243", "ASYMPTOTICALLY EQUAL TO"
            txt = Regex.Replace(txt, "&#x0*?2243;", "≃");
            txt = Regex.Replace(txt, "&#0*?8771;", "≃");
            txt = Regex.Replace(txt, "&sime;", "≃");
            txt = Regex.Replace(txt, "&TildeEqual;", "≃");
            txt = Regex.Replace(txt, "&simeq;", "≃");

            // "U+02244", "NOT ASYMPTOTICALLY EQUAL TO"
            txt = Regex.Replace(txt, "&#x0*?2244;", "≄");
            txt = Regex.Replace(txt, "&#0*?8772;", "≄");
            txt = Regex.Replace(txt, "&nsime;", "≄");
            txt = Regex.Replace(txt, "&nsimeq;", "≄");
            txt = Regex.Replace(txt, "&NotTildeEqual;", "≄");

            // "U+02245", "APPROXIMATELY EQUAL TO"
            txt = Regex.Replace(txt, "&#x0*?2245;", "≅");
            txt = Regex.Replace(txt, "&#0*?8773;", "≅");
            txt = Regex.Replace(txt, "&cong;", "≅");
            txt = Regex.Replace(txt, "&TildeFullEqual;", "≅");

            // "U+02246", "APPROXIMATELY BUT NOT ACTUALLY EQUAL TO"
            txt = Regex.Replace(txt, "&#x0*?2246;", "≆");
            txt = Regex.Replace(txt, "&#0*?8774;", "≆");
            txt = Regex.Replace(txt, "&simne;", "≆");

            // "U+02247", "NEITHER APPROXIMATELY NOR ACTUALLY EQUAL TO"
            txt = Regex.Replace(txt, "&#x0*?2247;", "≇");
            txt = Regex.Replace(txt, "&#0*?8775;", "≇");
            txt = Regex.Replace(txt, "&ncong;", "≇");
            txt = Regex.Replace(txt, "&NotTildeFullEqual;", "≇");

            // "U+02248", "ALMOST EQUAL TO"
            txt = Regex.Replace(txt, "&#x0*?2248;", "≈");
            txt = Regex.Replace(txt, "&#0*?8776;", "≈");
            txt = Regex.Replace(txt, "&asymp;", "≈");
            txt = Regex.Replace(txt, "&ap;", "≈");
            txt = Regex.Replace(txt, "&TildeTilde;", "≈");
            txt = Regex.Replace(txt, "&approx;", "≈");
            txt = Regex.Replace(txt, "&thkap;", "≈");
            txt = Regex.Replace(txt, "&thickapprox;", "≈");

            // "U+02249", "NOT ALMOST EQUAL TO"
            txt = Regex.Replace(txt, "&#x0*?2249;", "≉");
            txt = Regex.Replace(txt, "&#0*?8777;", "≉");
            txt = Regex.Replace(txt, "&nap;", "≉");
            txt = Regex.Replace(txt, "&NotTildeTilde;", "≉");
            txt = Regex.Replace(txt, "&napprox;", "≉");

            // "U+0224A", "ALMOST EQUAL OR EQUAL TO"
            txt = Regex.Replace(txt, "&#x0*?224A;", "≊");
            txt = Regex.Replace(txt, "&#0*?8778;", "≊");
            txt = Regex.Replace(txt, "&ape;", "≊");
            txt = Regex.Replace(txt, "&approxeq;", "≊");

            // "U+0224B", "TRIPLE TILDE"
            txt = Regex.Replace(txt, "&#x0*?224B;", "≋");
            txt = Regex.Replace(txt, "&#0*?8779;", "≋");
            txt = Regex.Replace(txt, "&apid;", "≋");

            // "U+0224C", "ALL EQUAL TO"
            txt = Regex.Replace(txt, "&#x0*?224C;", "≌");
            txt = Regex.Replace(txt, "&#0*?8780;", "≌");
            txt = Regex.Replace(txt, "&bcong;", "≌");
            txt = Regex.Replace(txt, "&backcong;", "≌");

            // "U+0224D", "EQUIVALENT TO"
            txt = Regex.Replace(txt, "&#x0*?224D;", "≍");
            txt = Regex.Replace(txt, "&#0*?8781;", "≍");
            txt = Regex.Replace(txt, "&asympeq;", "≍");
            txt = Regex.Replace(txt, "&CupCap;", "≍");

            // "U+0224E", "GEOMETRICALLY EQUIVALENT TO"
            txt = Regex.Replace(txt, "&#x0*?224E;", "≎");
            txt = Regex.Replace(txt, "&#0*?8782;", "≎");
            txt = Regex.Replace(txt, "&bump;", "≎");
            txt = Regex.Replace(txt, "&HumpDownHump;", "≎");
            txt = Regex.Replace(txt, "&Bumpeq;", "≎");

            // "U+0224F", "DIFFERENCE BETWEEN"
            txt = Regex.Replace(txt, "&#x0*?224F;", "≏");
            txt = Regex.Replace(txt, "&#0*?8783;", "≏");
            txt = Regex.Replace(txt, "&bumpe;", "≏");
            txt = Regex.Replace(txt, "&HumpEqual;", "≏");
            txt = Regex.Replace(txt, "&bumpeq;", "≏");

            // "U+02250", "APPROACHES THE LIMIT"
            txt = Regex.Replace(txt, "&#x0*?2250;", "≐");
            txt = Regex.Replace(txt, "&#0*?8784;", "≐");
            txt = Regex.Replace(txt, "&esdot;", "≐");
            txt = Regex.Replace(txt, "&DotEqual;", "≐");
            txt = Regex.Replace(txt, "&doteq;", "≐");

            // "U+02251", "GEOMETRICALLY EQUAL TO"
            txt = Regex.Replace(txt, "&#x0*?2251;", "≑");
            txt = Regex.Replace(txt, "&#0*?8785;", "≑");
            txt = Regex.Replace(txt, "&eDot;", "≑");
            txt = Regex.Replace(txt, "&doteqdot;", "≑");

            // "U+02252", "APPROXIMATELY EQUAL TO OR THE IMAGE OF"
            txt = Regex.Replace(txt, "&#x0*?2252;", "≒");
            txt = Regex.Replace(txt, "&#0*?8786;", "≒");
            txt = Regex.Replace(txt, "&efDot;", "≒");
            txt = Regex.Replace(txt, "&fallingdotseq;", "≒");

            // "U+02253", "IMAGE OF OR APPROXIMATELY EQUAL TO"
            txt = Regex.Replace(txt, "&#x0*?2253;", "≓");
            txt = Regex.Replace(txt, "&#0*?8787;", "≓");
            txt = Regex.Replace(txt, "&erDot;", "≓");
            txt = Regex.Replace(txt, "&risingdotseq;", "≓");

            // "U+02254", "COLON EQUALS"
            txt = Regex.Replace(txt, "&#x0*?2254;", "≔");
            txt = Regex.Replace(txt, "&#0*?8788;", "≔");
            txt = Regex.Replace(txt, "&colone;", "≔");
            txt = Regex.Replace(txt, "&coloneq;", "≔");
            txt = Regex.Replace(txt, "&Assign;", "≔");

            // "U+02255", "EQUALS COLON"
            txt = Regex.Replace(txt, "&#x0*?2255;", "≕");
            txt = Regex.Replace(txt, "&#0*?8789;", "≕");
            txt = Regex.Replace(txt, "&ecolon;", "≕");
            txt = Regex.Replace(txt, "&eqcolon;", "≕");

            // "U+02256", "RING IN EQUAL TO"
            txt = Regex.Replace(txt, "&#x0*?2256;", "≖");
            txt = Regex.Replace(txt, "&#0*?8790;", "≖");
            txt = Regex.Replace(txt, "&ecir;", "≖");
            txt = Regex.Replace(txt, "&eqcirc;", "≖");

            // "U+02257", "RING EQUAL TO"
            txt = Regex.Replace(txt, "&#x0*?2257;", "≗");
            txt = Regex.Replace(txt, "&#0*?8791;", "≗");
            txt = Regex.Replace(txt, "&cire;", "≗");
            txt = Regex.Replace(txt, "&circeq;", "≗");

            // "U+02259", "ESTIMATES"
            txt = Regex.Replace(txt, "&#x0*?2259;", "≙");
            txt = Regex.Replace(txt, "&#0*?8793;", "≙");
            txt = Regex.Replace(txt, "&wedgeq;", "≙");

            // "U+0225A", "EQUIANGULAR TO"
            txt = Regex.Replace(txt, "&#x0*?225A;", "≚");
            txt = Regex.Replace(txt, "&#0*?8794;", "≚");
            txt = Regex.Replace(txt, "&veeeq;", "≚");

            // "U+0225C", "DELTA EQUAL TO"
            txt = Regex.Replace(txt, "&#x0*?225C;", "≜");
            txt = Regex.Replace(txt, "&#0*?8796;", "≜");
            txt = Regex.Replace(txt, "&trie;", "≜");
            txt = Regex.Replace(txt, "&triangleq;", "≜");

            // "U+0225F", "QUESTIONED EQUAL TO"
            txt = Regex.Replace(txt, "&#x0*?225F;", "≟");
            txt = Regex.Replace(txt, "&#0*?8799;", "≟");
            txt = Regex.Replace(txt, "&equest;", "≟");
            txt = Regex.Replace(txt, "&questeq;", "≟");

            // "U+02260", "NOT EQUAL TO"
            txt = Regex.Replace(txt, "&#x0*?2260;", "≠");
            txt = Regex.Replace(txt, "&#0*?8800;", "≠");
            txt = Regex.Replace(txt, "&ne;", "≠");
            txt = Regex.Replace(txt, "&NotEqual;", "≠");

            // "U+02261", "IDENTICAL TO"
            txt = Regex.Replace(txt, "&#x0*?2261;", "≡");
            txt = Regex.Replace(txt, "&#0*?8801;", "≡");
            txt = Regex.Replace(txt, "&equiv;", "≡");
            txt = Regex.Replace(txt, "&Congruent;", "≡");

            // "U+02262", "NOT IDENTICAL TO"
            txt = Regex.Replace(txt, "&#x0*?2262;", "≢");
            txt = Regex.Replace(txt, "&#0*?8802;", "≢");
            txt = Regex.Replace(txt, "&nequiv;", "≢");
            txt = Regex.Replace(txt, "&NotCongruent;", "≢");

            // "U+02264", "LESS-THAN OR EQUAL TO"
            txt = Regex.Replace(txt, "&#x0*?2264;", "≤");
            txt = Regex.Replace(txt, "&#0*?8804;", "≤");
            txt = Regex.Replace(txt, "&le;", "≤");
            txt = Regex.Replace(txt, "&leq;", "≤");

            // "U+02265", "GREATER-THAN OR EQUAL TO"
            txt = Regex.Replace(txt, "&#x0*?2265;", "≥");
            txt = Regex.Replace(txt, "&#0*?8805;", "≥");
            txt = Regex.Replace(txt, "&ge;", "≥");
            txt = Regex.Replace(txt, "&GreaterEqual;", "≥");
            txt = Regex.Replace(txt, "&geq;", "≥");

            // "U+02266", "LESS-THAN OVER EQUAL TO"
            txt = Regex.Replace(txt, "&#x0*?2266;", "≦");
            txt = Regex.Replace(txt, "&#0*?8806;", "≦");
            txt = Regex.Replace(txt, "&lE;", "≦");
            txt = Regex.Replace(txt, "&LessFullEqual;", "≦");
            txt = Regex.Replace(txt, "&leqq;", "≦");

            // "U+02267", "GREATER-THAN OVER EQUAL TO"
            txt = Regex.Replace(txt, "&#x0*?2267;", "≧");
            txt = Regex.Replace(txt, "&#0*?8807;", "≧");
            txt = Regex.Replace(txt, "&gE;", "≧");
            txt = Regex.Replace(txt, "&GreaterFullEqual;", "≧");
            txt = Regex.Replace(txt, "&geqq;", "≧");

            // "U+02268", "LESS-THAN BUT NOT EQUAL TO"
            txt = Regex.Replace(txt, "&#x0*?2268;", "≨");
            txt = Regex.Replace(txt, "&#0*?8808;", "≨");
            txt = Regex.Replace(txt, "&lnE;", "≨");
            txt = Regex.Replace(txt, "&lneqq;", "≨");

            // "U+02269", "GREATER-THAN BUT NOT EQUAL TO"
            txt = Regex.Replace(txt, "&#x0*?2269;", "≩");
            txt = Regex.Replace(txt, "&#0*?8809;", "≩");
            txt = Regex.Replace(txt, "&gnE;", "≩");
            txt = Regex.Replace(txt, "&gneqq;", "≩");

            // "U+0226A", "MUCH LESS-THAN"
            txt = Regex.Replace(txt, "&#x0*?226A;", "≪");
            txt = Regex.Replace(txt, "&#0*?8810;", "≪");
            txt = Regex.Replace(txt, "&Lt;", "≪");
            txt = Regex.Replace(txt, "&NestedLessLess;", "≪");
            txt = Regex.Replace(txt, "&ll;", "≪");

            // "U+0226B", "MUCH GREATER-THAN"
            txt = Regex.Replace(txt, "&#x0*?226B;", "≫");
            txt = Regex.Replace(txt, "&#0*?8811;", "≫");
            txt = Regex.Replace(txt, "&Gt;", "≫");
            txt = Regex.Replace(txt, "&NestedGreaterGreater;", "≫");
            txt = Regex.Replace(txt, "&gg;", "≫");

            // "U+0226C", "BETWEEN"
            txt = Regex.Replace(txt, "&#x0*?226C;", "≬");
            txt = Regex.Replace(txt, "&#0*?8812;", "≬");
            txt = Regex.Replace(txt, "&twixt;", "≬");
            txt = Regex.Replace(txt, "&between;", "≬");

            // "U+0226D", "NOT EQUIVALENT TO"
            txt = Regex.Replace(txt, "&#x0*?226D;", "≭");
            txt = Regex.Replace(txt, "&#0*?8813;", "≭");
            txt = Regex.Replace(txt, "&NotCupCap;", "≭");

            // "U+0226E", "NOT LESS-THAN"
            txt = Regex.Replace(txt, "&#x0*?226E;", "≮");
            txt = Regex.Replace(txt, "&#0*?8814;", "≮");
            txt = Regex.Replace(txt, "&nlt;", "≮");
            txt = Regex.Replace(txt, "&NotLess;", "≮");
            txt = Regex.Replace(txt, "&nless;", "≮");

            // "U+0226F", "NOT GREATER-THAN"
            txt = Regex.Replace(txt, "&#x0*?226F;", "≯");
            txt = Regex.Replace(txt, "&#0*?8815;", "≯");
            txt = Regex.Replace(txt, "&ngt;", "≯");
            txt = Regex.Replace(txt, "&NotGreater;", "≯");
            txt = Regex.Replace(txt, "&ngtr;", "≯");

            // "U+02270", "NEITHER LESS-THAN NOR EQUAL TO"
            txt = Regex.Replace(txt, "&#x0*?2270;", "≰");
            txt = Regex.Replace(txt, "&#0*?8816;", "≰");
            txt = Regex.Replace(txt, "&nle;", "≰");
            txt = Regex.Replace(txt, "&NotLessEqual;", "≰");
            txt = Regex.Replace(txt, "&nleq;", "≰");

            // "U+02271", "NEITHER GREATER-THAN NOR EQUAL TO"
            txt = Regex.Replace(txt, "&#x0*?2271;", "≱");
            txt = Regex.Replace(txt, "&#0*?8817;", "≱");
            txt = Regex.Replace(txt, "&nge;", "≱");
            txt = Regex.Replace(txt, "&NotGreaterEqual;", "≱");
            txt = Regex.Replace(txt, "&ngeq;", "≱");

            // "U+02272", "LESS-THAN OR EQUIVALENT TO"
            txt = Regex.Replace(txt, "&#x0*?2272;", "≲");
            txt = Regex.Replace(txt, "&#0*?8818;", "≲");
            txt = Regex.Replace(txt, "&lsim;", "≲");
            txt = Regex.Replace(txt, "&LessTilde;", "≲");
            txt = Regex.Replace(txt, "&lesssim;", "≲");

            // "U+02273", "GREATER-THAN OR EQUIVALENT TO"
            txt = Regex.Replace(txt, "&#x0*?2273;", "≳");
            txt = Regex.Replace(txt, "&#0*?8819;", "≳");
            txt = Regex.Replace(txt, "&gsim;", "≳");
            txt = Regex.Replace(txt, "&gtrsim;", "≳");
            txt = Regex.Replace(txt, "&GreaterTilde;", "≳");

            // "U+02274", "NEITHER LESS-THAN NOR EQUIVALENT TO"
            txt = Regex.Replace(txt, "&#x0*?2274;", "≴");
            txt = Regex.Replace(txt, "&#0*?8820;", "≴");
            txt = Regex.Replace(txt, "&nlsim;", "≴");
            txt = Regex.Replace(txt, "&NotLessTilde;", "≴");

            // "U+02275", "NEITHER GREATER-THAN NOR EQUIVALENT TO"
            txt = Regex.Replace(txt, "&#x0*?2275;", "≵");
            txt = Regex.Replace(txt, "&#0*?8821;", "≵");
            txt = Regex.Replace(txt, "&ngsim;", "≵");
            txt = Regex.Replace(txt, "&NotGreaterTilde;", "≵");

            // "U+02276", "LESS-THAN OR GREATER-THAN"
            txt = Regex.Replace(txt, "&#x0*?2276;", "≶");
            txt = Regex.Replace(txt, "&#0*?8822;", "≶");
            txt = Regex.Replace(txt, "&lg;", "≶");
            txt = Regex.Replace(txt, "&lessgtr;", "≶");
            txt = Regex.Replace(txt, "&LessGreater;", "≶");

            // "U+02277", "GREATER-THAN OR LESS-THAN"
            txt = Regex.Replace(txt, "&#x0*?2277;", "≷");
            txt = Regex.Replace(txt, "&#0*?8823;", "≷");
            txt = Regex.Replace(txt, "&gl;", "≷");
            txt = Regex.Replace(txt, "&gtrless;", "≷");
            txt = Regex.Replace(txt, "&GreaterLess;", "≷");

            // "U+02278", "NEITHER LESS-THAN NOR GREATER-THAN"
            txt = Regex.Replace(txt, "&#x0*?2278;", "≸");
            txt = Regex.Replace(txt, "&#0*?8824;", "≸");
            txt = Regex.Replace(txt, "&ntlg;", "≸");
            txt = Regex.Replace(txt, "&NotLessGreater;", "≸");

            // "U+02279", "NEITHER GREATER-THAN NOR LESS-THAN"
            txt = Regex.Replace(txt, "&#x0*?2279;", "≹");
            txt = Regex.Replace(txt, "&#0*?8825;", "≹");
            txt = Regex.Replace(txt, "&ntgl;", "≹");
            txt = Regex.Replace(txt, "&NotGreaterLess;", "≹");

            // "U+0227A", "PRECEDES"
            txt = Regex.Replace(txt, "&#x0*?227A;", "≺");
            txt = Regex.Replace(txt, "&#0*?8826;", "≺");
            txt = Regex.Replace(txt, "&pr;", "≺");
            txt = Regex.Replace(txt, "&Precedes;", "≺");
            txt = Regex.Replace(txt, "&prec;", "≺");

            // "U+0227B", "SUCCEEDS"
            txt = Regex.Replace(txt, "&#x0*?227B;", "≻");
            txt = Regex.Replace(txt, "&#0*?8827;", "≻");
            txt = Regex.Replace(txt, "&sc;", "≻");
            txt = Regex.Replace(txt, "&Succeeds;", "≻");
            txt = Regex.Replace(txt, "&succ;", "≻");

            // "U+0227C", "PRECEDES OR EQUAL TO"
            txt = Regex.Replace(txt, "&#x0*?227C;", "≼");
            txt = Regex.Replace(txt, "&#0*?8828;", "≼");
            txt = Regex.Replace(txt, "&prcue;", "≼");
            txt = Regex.Replace(txt, "&PrecedesSlantEqual;", "≼");
            txt = Regex.Replace(txt, "&preccurlyeq;", "≼");

            // "U+0227D", "SUCCEEDS OR EQUAL TO"
            txt = Regex.Replace(txt, "&#x0*?227D;", "≽");
            txt = Regex.Replace(txt, "&#0*?8829;", "≽");
            txt = Regex.Replace(txt, "&sccue;", "≽");
            txt = Regex.Replace(txt, "&SucceedsSlantEqual;", "≽");
            txt = Regex.Replace(txt, "&succcurlyeq;", "≽");

            // "U+0227E", "PRECEDES OR EQUIVALENT TO"
            txt = Regex.Replace(txt, "&#x0*?227E;", "≾");
            txt = Regex.Replace(txt, "&#0*?8830;", "≾");
            txt = Regex.Replace(txt, "&prsim;", "≾");
            txt = Regex.Replace(txt, "&precsim;", "≾");
            txt = Regex.Replace(txt, "&PrecedesTilde;", "≾");

            // "U+0227F", "SUCCEEDS OR EQUIVALENT TO"
            txt = Regex.Replace(txt, "&#x0*?227F;", "≿");
            txt = Regex.Replace(txt, "&#0*?8831;", "≿");
            txt = Regex.Replace(txt, "&scsim;", "≿");
            txt = Regex.Replace(txt, "&succsim;", "≿");
            txt = Regex.Replace(txt, "&SucceedsTilde;", "≿");

            // "U+02280", "DOES NOT PRECEDE"
            txt = Regex.Replace(txt, "&#x0*?2280;", "⊀");
            txt = Regex.Replace(txt, "&#0*?8832;", "⊀");
            txt = Regex.Replace(txt, "&npr;", "⊀");
            txt = Regex.Replace(txt, "&nprec;", "⊀");
            txt = Regex.Replace(txt, "&NotPrecedes;", "⊀");

            // "U+02281", "DOES NOT SUCCEED"
            txt = Regex.Replace(txt, "&#x0*?2281;", "⊁");
            txt = Regex.Replace(txt, "&#0*?8833;", "⊁");
            txt = Regex.Replace(txt, "&nsc;", "⊁");
            txt = Regex.Replace(txt, "&nsucc;", "⊁");
            txt = Regex.Replace(txt, "&NotSucceeds;", "⊁");

            // "U+02282", "SUBSET OF"
            txt = Regex.Replace(txt, "&#x0*?2282;", "⊂");
            txt = Regex.Replace(txt, "&#0*?8834;", "⊂");
            txt = Regex.Replace(txt, "&sub;", "⊂");
            txt = Regex.Replace(txt, "&subset;", "⊂");

            // "U+02283", "SUPERSET OF"
            txt = Regex.Replace(txt, "&#x0*?2283;", "⊃");
            txt = Regex.Replace(txt, "&#0*?8835;", "⊃");
            txt = Regex.Replace(txt, "&sup;", "⊃");
            txt = Regex.Replace(txt, "&supset;", "⊃");
            txt = Regex.Replace(txt, "&Superset;", "⊃");

            // "U+02284", "NOT A SUBSET OF"
            txt = Regex.Replace(txt, "&#x0*?2284;", "⊄");
            txt = Regex.Replace(txt, "&#0*?8836;", "⊄");
            txt = Regex.Replace(txt, "&nsub;", "⊄");

            // "U+02285", "NOT A SUPERSET OF"
            txt = Regex.Replace(txt, "&#x0*?2285;", "⊅");
            txt = Regex.Replace(txt, "&#0*?8837;", "⊅");
            txt = Regex.Replace(txt, "&nsup;", "⊅");

            // "U+02286", "SUBSET OF OR EQUAL TO"
            txt = Regex.Replace(txt, "&#x0*?2286;", "⊆");
            txt = Regex.Replace(txt, "&#0*?8838;", "⊆");
            txt = Regex.Replace(txt, "&sube;", "⊆");
            txt = Regex.Replace(txt, "&SubsetEqual;", "⊆");
            txt = Regex.Replace(txt, "&subseteq;", "⊆");

            // "U+02287", "SUPERSET OF OR EQUAL TO"
            txt = Regex.Replace(txt, "&#x0*?2287;", "⊇");
            txt = Regex.Replace(txt, "&#0*?8839;", "⊇");
            txt = Regex.Replace(txt, "&supe;", "⊇");
            txt = Regex.Replace(txt, "&supseteq;", "⊇");
            txt = Regex.Replace(txt, "&SupersetEqual;", "⊇");

            // "U+02288", "NEITHER A SUBSET OF NOR EQUAL TO"
            txt = Regex.Replace(txt, "&#x0*?2288;", "⊈");
            txt = Regex.Replace(txt, "&#0*?8840;", "⊈");
            txt = Regex.Replace(txt, "&nsube;", "⊈");
            txt = Regex.Replace(txt, "&nsubseteq;", "⊈");
            txt = Regex.Replace(txt, "&NotSubsetEqual;", "⊈");

            // "U+02289", "NEITHER A SUPERSET OF NOR EQUAL TO"
            txt = Regex.Replace(txt, "&#x0*?2289;", "⊉");
            txt = Regex.Replace(txt, "&#0*?8841;", "⊉");
            txt = Regex.Replace(txt, "&nsupe;", "⊉");
            txt = Regex.Replace(txt, "&nsupseteq;", "⊉");
            txt = Regex.Replace(txt, "&NotSupersetEqual;", "⊉");

            // "U+0228A", "SUBSET OF WITH NOT EQUAL TO"
            txt = Regex.Replace(txt, "&#x0*?228A;", "⊊");
            txt = Regex.Replace(txt, "&#0*?8842;", "⊊");
            txt = Regex.Replace(txt, "&subne;", "⊊");
            txt = Regex.Replace(txt, "&subsetneq;", "⊊");

            // "U+0228B", "SUPERSET OF WITH NOT EQUAL TO"
            txt = Regex.Replace(txt, "&#x0*?228B;", "⊋");
            txt = Regex.Replace(txt, "&#0*?8843;", "⊋");
            txt = Regex.Replace(txt, "&supne;", "⊋");
            txt = Regex.Replace(txt, "&supsetneq;", "⊋");

            // "U+0228D", "MULTISET MULTIPLICATION"
            txt = Regex.Replace(txt, "&#x0*?228D;", "⊍");
            txt = Regex.Replace(txt, "&#0*?8845;", "⊍");
            txt = Regex.Replace(txt, "&cupdot;", "⊍");

            // "U+0228E", "MULTISET UNION"
            txt = Regex.Replace(txt, "&#x0*?228E;", "⊎");
            txt = Regex.Replace(txt, "&#0*?8846;", "⊎");
            txt = Regex.Replace(txt, "&uplus;", "⊎");
            txt = Regex.Replace(txt, "&UnionPlus;", "⊎");

            // "U+0228F", "SQUARE IMAGE OF"
            txt = Regex.Replace(txt, "&#x0*?228F;", "⊏");
            txt = Regex.Replace(txt, "&#0*?8847;", "⊏");
            txt = Regex.Replace(txt, "&sqsub;", "⊏");
            txt = Regex.Replace(txt, "&SquareSubset;", "⊏");
            txt = Regex.Replace(txt, "&sqsubset;", "⊏");

            // "U+02290", "SQUARE ORIGINAL OF"
            txt = Regex.Replace(txt, "&#x0*?2290;", "⊐");
            txt = Regex.Replace(txt, "&#0*?8848;", "⊐");
            txt = Regex.Replace(txt, "&sqsup;", "⊐");
            txt = Regex.Replace(txt, "&SquareSuperset;", "⊐");
            txt = Regex.Replace(txt, "&sqsupset;", "⊐");

            // "U+02291", "SQUARE IMAGE OF OR EQUAL TO"
            txt = Regex.Replace(txt, "&#x0*?2291;", "⊑");
            txt = Regex.Replace(txt, "&#0*?8849;", "⊑");
            txt = Regex.Replace(txt, "&sqsube;", "⊑");
            txt = Regex.Replace(txt, "&SquareSubsetEqual;", "⊑");
            txt = Regex.Replace(txt, "&sqsubseteq;", "⊑");

            // "U+02292", "SQUARE ORIGINAL OF OR EQUAL TO"
            txt = Regex.Replace(txt, "&#x0*?2292;", "⊒");
            txt = Regex.Replace(txt, "&#0*?8850;", "⊒");
            txt = Regex.Replace(txt, "&sqsupe;", "⊒");
            txt = Regex.Replace(txt, "&SquareSupersetEqual;", "⊒");
            txt = Regex.Replace(txt, "&sqsupseteq;", "⊒");

            // "U+02293", "SQUARE CAP"
            txt = Regex.Replace(txt, "&#x0*?2293;", "⊓");
            txt = Regex.Replace(txt, "&#0*?8851;", "⊓");
            txt = Regex.Replace(txt, "&sqcap;", "⊓");
            txt = Regex.Replace(txt, "&SquareIntersection;", "⊓");

            // "U+02294", "SQUARE CUP"
            txt = Regex.Replace(txt, "&#x0*?2294;", "⊔");
            txt = Regex.Replace(txt, "&#0*?8852;", "⊔");
            txt = Regex.Replace(txt, "&sqcup;", "⊔");
            txt = Regex.Replace(txt, "&SquareUnion;", "⊔");

            // "U+02295", "CIRCLED PLUS"
            txt = Regex.Replace(txt, "&#x0*?2295;", "⊕");
            txt = Regex.Replace(txt, "&#0*?8853;", "⊕");
            txt = Regex.Replace(txt, "&oplus;", "⊕");
            txt = Regex.Replace(txt, "&CirclePlus;", "⊕");

            // "U+02296", "CIRCLED MINUS"
            txt = Regex.Replace(txt, "&#x0*?2296;", "⊖");
            txt = Regex.Replace(txt, "&#0*?8854;", "⊖");
            txt = Regex.Replace(txt, "&ominus;", "⊖");
            txt = Regex.Replace(txt, "&CircleMinus;", "⊖");

            // "U+02297", "CIRCLED TIMES"
            txt = Regex.Replace(txt, "&#x0*?2297;", "⊗");
            txt = Regex.Replace(txt, "&#0*?8855;", "⊗");
            txt = Regex.Replace(txt, "&otimes;", "⊗");
            txt = Regex.Replace(txt, "&CircleTimes;", "⊗");

            // "U+02298", "CIRCLED DIVISION SLASH"
            txt = Regex.Replace(txt, "&#x0*?2298;", "⊘");
            txt = Regex.Replace(txt, "&#0*?8856;", "⊘");
            txt = Regex.Replace(txt, "&osol;", "⊘");

            // "U+02299", "CIRCLED DOT OPERATOR"
            txt = Regex.Replace(txt, "&#x0*?2299;", "⊙");
            txt = Regex.Replace(txt, "&#0*?8857;", "⊙");
            txt = Regex.Replace(txt, "&odot;", "⊙");
            txt = Regex.Replace(txt, "&CircleDot;", "⊙");

            // "U+0229A", "CIRCLED RING OPERATOR"
            txt = Regex.Replace(txt, "&#x0*?229A;", "⊚");
            txt = Regex.Replace(txt, "&#0*?8858;", "⊚");
            txt = Regex.Replace(txt, "&ocir;", "⊚");
            txt = Regex.Replace(txt, "&circledcirc;", "⊚");

            // "U+0229B", "CIRCLED ASTERISK OPERATOR"
            txt = Regex.Replace(txt, "&#x0*?229B;", "⊛");
            txt = Regex.Replace(txt, "&#0*?8859;", "⊛");
            txt = Regex.Replace(txt, "&oast;", "⊛");
            txt = Regex.Replace(txt, "&circledast;", "⊛");

            // "U+0229D", "CIRCLED DASH"
            txt = Regex.Replace(txt, "&#x0*?229D;", "⊝");
            txt = Regex.Replace(txt, "&#0*?8861;", "⊝");
            txt = Regex.Replace(txt, "&odash;", "⊝");
            txt = Regex.Replace(txt, "&circleddash;", "⊝");

            // "U+0229E", "SQUARED PLUS"
            txt = Regex.Replace(txt, "&#x0*?229E;", "⊞");
            txt = Regex.Replace(txt, "&#0*?8862;", "⊞");
            txt = Regex.Replace(txt, "&plusb;", "⊞");
            txt = Regex.Replace(txt, "&boxplus;", "⊞");

            // "U+0229F", "SQUARED MINUS"
            txt = Regex.Replace(txt, "&#x0*?229F;", "⊟");
            txt = Regex.Replace(txt, "&#0*?8863;", "⊟");
            txt = Regex.Replace(txt, "&minusb;", "⊟");
            txt = Regex.Replace(txt, "&boxminus;", "⊟");

            // "U+022A0", "SQUARED TIMES"
            txt = Regex.Replace(txt, "&#x0*?22A0;", "⊠");
            txt = Regex.Replace(txt, "&#0*?8864;", "⊠");
            txt = Regex.Replace(txt, "&timesb;", "⊠");
            txt = Regex.Replace(txt, "&boxtimes;", "⊠");

            // "U+022A1", "SQUARED DOT OPERATOR"
            txt = Regex.Replace(txt, "&#x0*?22A1;", "⊡");
            txt = Regex.Replace(txt, "&#0*?8865;", "⊡");
            txt = Regex.Replace(txt, "&sdotb;", "⊡");
            txt = Regex.Replace(txt, "&dotsquare;", "⊡");

            // "U+022A2", "RIGHT TACK"
            txt = Regex.Replace(txt, "&#x0*?22A2;", "⊢");
            txt = Regex.Replace(txt, "&#0*?8866;", "⊢");
            txt = Regex.Replace(txt, "&vdash;", "⊢");
            txt = Regex.Replace(txt, "&RightTee;", "⊢");

            // "U+022A3", "LEFT TACK"
            txt = Regex.Replace(txt, "&#x0*?22A3;", "⊣");
            txt = Regex.Replace(txt, "&#0*?8867;", "⊣");
            txt = Regex.Replace(txt, "&dashv;", "⊣");
            txt = Regex.Replace(txt, "&LeftTee;", "⊣");

            // "U+022A4", "DOWN TACK"
            txt = Regex.Replace(txt, "&#x0*?22A4;", "⊤");
            txt = Regex.Replace(txt, "&#0*?8868;", "⊤");
            txt = Regex.Replace(txt, "&top;", "⊤");
            txt = Regex.Replace(txt, "&DownTee;", "⊤");

            // "U+022A5", "UP TACK"
            txt = Regex.Replace(txt, "&#x0*?22A5;", "⊥");
            txt = Regex.Replace(txt, "&#0*?8869;", "⊥");
            txt = Regex.Replace(txt, "&bottom;", "⊥");
            txt = Regex.Replace(txt, "&bot;", "⊥");
            txt = Regex.Replace(txt, "&perp;", "⊥");
            txt = Regex.Replace(txt, "&UpTee;", "⊥");

            // "U+022A7", "MODELS"
            txt = Regex.Replace(txt, "&#x0*?22A7;", "⊧");
            txt = Regex.Replace(txt, "&#0*?8871;", "⊧");
            txt = Regex.Replace(txt, "&models;", "⊧");

            // "U+022A8", "TRUE"
            txt = Regex.Replace(txt, "&#x0*?22A8;", "⊨");
            txt = Regex.Replace(txt, "&#0*?8872;", "⊨");
            txt = Regex.Replace(txt, "&vDash;", "⊨");
            txt = Regex.Replace(txt, "&DoubleRightTee;", "⊨");

            // "U+022A9", "FORCES"
            txt = Regex.Replace(txt, "&#x0*?22A9;", "⊩");
            txt = Regex.Replace(txt, "&#0*?8873;", "⊩");
            txt = Regex.Replace(txt, "&Vdash;", "⊩");

            // "U+022AA", "TRIPLE VERTICAL BAR RIGHT TURNSTILE"
            txt = Regex.Replace(txt, "&#x0*?22AA;", "⊪");
            txt = Regex.Replace(txt, "&#0*?8874;", "⊪");
            txt = Regex.Replace(txt, "&Vvdash;", "⊪");

            // "U+022AB", "DOUBLE VERTICAL BAR DOUBLE RIGHT TURNSTILE"
            txt = Regex.Replace(txt, "&#x0*?22AB;", "⊫");
            txt = Regex.Replace(txt, "&#0*?8875;", "⊫");
            txt = Regex.Replace(txt, "&VDash;", "⊫");

            // "U+022AC", "DOES NOT PROVE"
            txt = Regex.Replace(txt, "&#x0*?22AC;", "⊬");
            txt = Regex.Replace(txt, "&#0*?8876;", "⊬");
            txt = Regex.Replace(txt, "&nvdash;", "⊬");

            // "U+022AD", "NOT TRUE"
            txt = Regex.Replace(txt, "&#x0*?22AD;", "⊭");
            txt = Regex.Replace(txt, "&#0*?8877;", "⊭");
            txt = Regex.Replace(txt, "&nvDash;", "⊭");

            // "U+022AE", "DOES NOT FORCE"
            txt = Regex.Replace(txt, "&#x0*?22AE;", "⊮");
            txt = Regex.Replace(txt, "&#0*?8878;", "⊮");
            txt = Regex.Replace(txt, "&nVdash;", "⊮");

            // "U+022AF", "NEGATED DOUBLE VERTICAL BAR DOUBLE RIGHT TURNSTILE"
            txt = Regex.Replace(txt, "&#x0*?22AF;", "⊯");
            txt = Regex.Replace(txt, "&#0*?8879;", "⊯");
            txt = Regex.Replace(txt, "&nVDash;", "⊯");

            // "U+022B0", "PRECEDES UNDER RELATION"
            txt = Regex.Replace(txt, "&#x0*?22B0;", "⊰");
            txt = Regex.Replace(txt, "&#0*?8880;", "⊰");
            txt = Regex.Replace(txt, "&prurel;", "⊰");

            // "U+022B2", "NORMAL SUBGROUP OF"
            txt = Regex.Replace(txt, "&#x0*?22B2;", "⊲");
            txt = Regex.Replace(txt, "&#0*?8882;", "⊲");
            txt = Regex.Replace(txt, "&vltri;", "⊲");
            txt = Regex.Replace(txt, "&vartriangleleft;", "⊲");
            txt = Regex.Replace(txt, "&LeftTriangle;", "⊲");

            // "U+022B3", "CONTAINS AS NORMAL SUBGROUP"
            txt = Regex.Replace(txt, "&#x0*?22B3;", "⊳");
            txt = Regex.Replace(txt, "&#0*?8883;", "⊳");
            txt = Regex.Replace(txt, "&vrtri;", "⊳");
            txt = Regex.Replace(txt, "&vartriangleright;", "⊳");
            txt = Regex.Replace(txt, "&RightTriangle;", "⊳");

            // "U+022B4", "NORMAL SUBGROUP OF OR EQUAL TO"
            txt = Regex.Replace(txt, "&#x0*?22B4;", "⊴");
            txt = Regex.Replace(txt, "&#0*?8884;", "⊴");
            txt = Regex.Replace(txt, "&ltrie;", "⊴");
            txt = Regex.Replace(txt, "&trianglelefteq;", "⊴");
            txt = Regex.Replace(txt, "&LeftTriangleEqual;", "⊴");

            // "U+022B5", "CONTAINS AS NORMAL SUBGROUP OR EQUAL TO"
            txt = Regex.Replace(txt, "&#x0*?22B5;", "⊵");
            txt = Regex.Replace(txt, "&#0*?8885;", "⊵");
            txt = Regex.Replace(txt, "&rtrie;", "⊵");
            txt = Regex.Replace(txt, "&trianglerighteq;", "⊵");
            txt = Regex.Replace(txt, "&RightTriangleEqual;", "⊵");

            // "U+022B6", "ORIGINAL OF"
            txt = Regex.Replace(txt, "&#x0*?22B6;", "⊶");
            txt = Regex.Replace(txt, "&#0*?8886;", "⊶");
            txt = Regex.Replace(txt, "&origof;", "⊶");

            // "U+022B7", "IMAGE OF"
            txt = Regex.Replace(txt, "&#x0*?22B7;", "⊷");
            txt = Regex.Replace(txt, "&#0*?8887;", "⊷");
            txt = Regex.Replace(txt, "&imof;", "⊷");

            // "U+022B8", "MULTIMAP"
            txt = Regex.Replace(txt, "&#x0*?22B8;", "⊸");
            txt = Regex.Replace(txt, "&#0*?8888;", "⊸");
            txt = Regex.Replace(txt, "&mumap;", "⊸");
            txt = Regex.Replace(txt, "&multimap;", "⊸");

            // "U+022B9", "HERMITIAN CONJUGATE MATRIX"
            txt = Regex.Replace(txt, "&#x0*?22B9;", "⊹");
            txt = Regex.Replace(txt, "&#0*?8889;", "⊹");
            txt = Regex.Replace(txt, "&hercon;", "⊹");

            // "U+022BA", "INTERCALATE"
            txt = Regex.Replace(txt, "&#x0*?22BA;", "⊺");
            txt = Regex.Replace(txt, "&#0*?8890;", "⊺");
            txt = Regex.Replace(txt, "&intcal;", "⊺");
            txt = Regex.Replace(txt, "&intercal;", "⊺");

            // "U+022BB", "XOR"
            txt = Regex.Replace(txt, "&#x0*?22BB;", "⊻");
            txt = Regex.Replace(txt, "&#0*?8891;", "⊻");
            txt = Regex.Replace(txt, "&veebar;", "⊻");

            // "U+022BD", "NOR"
            txt = Regex.Replace(txt, "&#x0*?22BD;", "⊽");
            txt = Regex.Replace(txt, "&#0*?8893;", "⊽");
            txt = Regex.Replace(txt, "&barvee;", "⊽");

            // "U+022BE", "RIGHT ANGLE WITH ARC"
            txt = Regex.Replace(txt, "&#x0*?22BE;", "⊾");
            txt = Regex.Replace(txt, "&#0*?8894;", "⊾");
            txt = Regex.Replace(txt, "&angrtvb;", "⊾");

            // "U+022BF", "RIGHT TRIANGLE"
            txt = Regex.Replace(txt, "&#x0*?22BF;", "⊿");
            txt = Regex.Replace(txt, "&#0*?8895;", "⊿");
            txt = Regex.Replace(txt, "&lrtri;", "⊿");

            // "U+022C0", "N-ARY LOGICAL AND"
            txt = Regex.Replace(txt, "&#x0*?22C0;", "⋀");
            txt = Regex.Replace(txt, "&#0*?8896;", "⋀");
            txt = Regex.Replace(txt, "&xwedge;", "⋀");
            txt = Regex.Replace(txt, "&Wedge;", "⋀");
            txt = Regex.Replace(txt, "&bigwedge;", "⋀");

            // "U+022C1", "N-ARY LOGICAL OR"
            txt = Regex.Replace(txt, "&#x0*?22C1;", "⋁");
            txt = Regex.Replace(txt, "&#0*?8897;", "⋁");
            txt = Regex.Replace(txt, "&xvee;", "⋁");
            txt = Regex.Replace(txt, "&Vee;", "⋁");
            txt = Regex.Replace(txt, "&bigvee;", "⋁");

            // "U+022C2", "N-ARY INTERSECTION"
            txt = Regex.Replace(txt, "&#x0*?22C2;", "⋂");
            txt = Regex.Replace(txt, "&#0*?8898;", "⋂");
            txt = Regex.Replace(txt, "&xcap;", "⋂");
            txt = Regex.Replace(txt, "&Intersection;", "⋂");
            txt = Regex.Replace(txt, "&bigcap;", "⋂");

            // "U+022C3", "N-ARY UNION"
            txt = Regex.Replace(txt, "&#x0*?22C3;", "⋃");
            txt = Regex.Replace(txt, "&#0*?8899;", "⋃");
            txt = Regex.Replace(txt, "&xcup;", "⋃");
            txt = Regex.Replace(txt, "&Union;", "⋃");
            txt = Regex.Replace(txt, "&bigcup;", "⋃");

            // "U+022C4", "DIAMOND OPERATOR"
            txt = Regex.Replace(txt, "&#x0*?22C4;", "⋄");
            txt = Regex.Replace(txt, "&#0*?8900;", "⋄");
            txt = Regex.Replace(txt, "&diam;", "⋄");
            txt = Regex.Replace(txt, "&diamond;", "⋄");
            txt = Regex.Replace(txt, "&Diamond;", "⋄");

            // "U+022C5", "DOT OPERATOR"
            txt = Regex.Replace(txt, "&#x0*?22C5;", "⋅");
            txt = Regex.Replace(txt, "&#0*?8901;", "⋅");
            txt = Regex.Replace(txt, "&sdot;", "⋅");

            // "U+022C6", "STAR OPERATOR"
            txt = Regex.Replace(txt, "&#x0*?22C6;", "⋆");
            txt = Regex.Replace(txt, "&#0*?8902;", "⋆");
            txt = Regex.Replace(txt, "&sstarf;", "⋆");
            txt = Regex.Replace(txt, "&Star;", "⋆");

            // "U+022C7", "DIVISION TIMES"
            txt = Regex.Replace(txt, "&#x0*?22C7;", "⋇");
            txt = Regex.Replace(txt, "&#0*?8903;", "⋇");
            txt = Regex.Replace(txt, "&divonx;", "⋇");
            txt = Regex.Replace(txt, "&divideontimes;", "⋇");

            // "U+022C8", "BOWTIE"
            txt = Regex.Replace(txt, "&#x0*?22C8;", "⋈");
            txt = Regex.Replace(txt, "&#0*?8904;", "⋈");
            txt = Regex.Replace(txt, "&bowtie;", "⋈");

            // "U+022C9", "LEFT NORMAL FACTOR SEMIDIRECT PRODUCT"
            txt = Regex.Replace(txt, "&#x0*?22C9;", "⋉");
            txt = Regex.Replace(txt, "&#0*?8905;", "⋉");
            txt = Regex.Replace(txt, "&ltimes;", "⋉");

            // "U+022CA", "RIGHT NORMAL FACTOR SEMIDIRECT PRODUCT"
            txt = Regex.Replace(txt, "&#x0*?22CA;", "⋊");
            txt = Regex.Replace(txt, "&#0*?8906;", "⋊");
            txt = Regex.Replace(txt, "&rtimes;", "⋊");

            // "U+022CB", "LEFT SEMIDIRECT PRODUCT"
            txt = Regex.Replace(txt, "&#x0*?22CB;", "⋋");
            txt = Regex.Replace(txt, "&#0*?8907;", "⋋");
            txt = Regex.Replace(txt, "&lthree;", "⋋");
            txt = Regex.Replace(txt, "&leftthreetimes;", "⋋");

            // "U+022CC", "RIGHT SEMIDIRECT PRODUCT"
            txt = Regex.Replace(txt, "&#x0*?22CC;", "⋌");
            txt = Regex.Replace(txt, "&#0*?8908;", "⋌");
            txt = Regex.Replace(txt, "&rthree;", "⋌");
            txt = Regex.Replace(txt, "&rightthreetimes;", "⋌");

            // "U+022CD", "REVERSED TILDE EQUALS"
            txt = Regex.Replace(txt, "&#x0*?22CD;", "⋍");
            txt = Regex.Replace(txt, "&#0*?8909;", "⋍");
            txt = Regex.Replace(txt, "&bsime;", "⋍");
            txt = Regex.Replace(txt, "&backsimeq;", "⋍");

            // "U+022CE", "CURLY LOGICAL OR"
            txt = Regex.Replace(txt, "&#x0*?22CE;", "⋎");
            txt = Regex.Replace(txt, "&#0*?8910;", "⋎");
            txt = Regex.Replace(txt, "&cuvee;", "⋎");
            txt = Regex.Replace(txt, "&curlyvee;", "⋎");

            // "U+022CF", "CURLY LOGICAL AND"
            txt = Regex.Replace(txt, "&#x0*?22CF;", "⋏");
            txt = Regex.Replace(txt, "&#0*?8911;", "⋏");
            txt = Regex.Replace(txt, "&cuwed;", "⋏");
            txt = Regex.Replace(txt, "&curlywedge;", "⋏");

            // "U+022D0", "DOUBLE SUBSET"
            txt = Regex.Replace(txt, "&#x0*?22D0;", "⋐");
            txt = Regex.Replace(txt, "&#0*?8912;", "⋐");
            txt = Regex.Replace(txt, "&Sub;", "⋐");
            txt = Regex.Replace(txt, "&Subset;", "⋐");

            // "U+022D1", "DOUBLE SUPERSET"
            txt = Regex.Replace(txt, "&#x0*?22D1;", "⋑");
            txt = Regex.Replace(txt, "&#0*?8913;", "⋑");
            txt = Regex.Replace(txt, "&Sup;", "⋑");
            txt = Regex.Replace(txt, "&Supset;", "⋑");

            // "U+022D2", "DOUBLE INTERSECTION"
            txt = Regex.Replace(txt, "&#x0*?22D2;", "⋒");
            txt = Regex.Replace(txt, "&#0*?8914;", "⋒");
            txt = Regex.Replace(txt, "&Cap;", "⋒");

            // "U+022D3", "DOUBLE UNION"
            txt = Regex.Replace(txt, "&#x0*?22D3;", "⋓");
            txt = Regex.Replace(txt, "&#0*?8915;", "⋓");
            txt = Regex.Replace(txt, "&Cup;", "⋓");

            // "U+022D4", "PITCHFORK"
            txt = Regex.Replace(txt, "&#x0*?22D4;", "⋔");
            txt = Regex.Replace(txt, "&#0*?8916;", "⋔");
            txt = Regex.Replace(txt, "&fork;", "⋔");
            txt = Regex.Replace(txt, "&pitchfork;", "⋔");

            // "U+022D5", "EQUAL AND PARALLEL TO"
            txt = Regex.Replace(txt, "&#x0*?22D5;", "⋕");
            txt = Regex.Replace(txt, "&#0*?8917;", "⋕");
            txt = Regex.Replace(txt, "&epar;", "⋕");

            // "U+022D6", "LESS-THAN WITH DOT"
            txt = Regex.Replace(txt, "&#x0*?22D6;", "⋖");
            txt = Regex.Replace(txt, "&#0*?8918;", "⋖");
            txt = Regex.Replace(txt, "&ltdot;", "⋖");
            txt = Regex.Replace(txt, "&lessdot;", "⋖");

            // "U+022D7", "GREATER-THAN WITH DOT"
            txt = Regex.Replace(txt, "&#x0*?22D7;", "⋗");
            txt = Regex.Replace(txt, "&#0*?8919;", "⋗");
            txt = Regex.Replace(txt, "&gtdot;", "⋗");
            txt = Regex.Replace(txt, "&gtrdot;", "⋗");

            // "U+022D8", "VERY MUCH LESS-THAN"
            txt = Regex.Replace(txt, "&#x0*?22D8;", "⋘");
            txt = Regex.Replace(txt, "&#0*?8920;", "⋘");
            txt = Regex.Replace(txt, "&Ll;", "⋘");

            // "U+022D9", "VERY MUCH GREATER-THAN"
            txt = Regex.Replace(txt, "&#x0*?22D9;", "⋙");
            txt = Regex.Replace(txt, "&#0*?8921;", "⋙");
            txt = Regex.Replace(txt, "&Gg;", "⋙");
            txt = Regex.Replace(txt, "&ggg;", "⋙");

            // "U+022DA", "LESS-THAN EQUAL TO OR GREATER-THAN"
            txt = Regex.Replace(txt, "&#x0*?22DA;", "⋚");
            txt = Regex.Replace(txt, "&#0*?8922;", "⋚");
            txt = Regex.Replace(txt, "&leg;", "⋚");
            txt = Regex.Replace(txt, "&LessEqualGreater;", "⋚");
            txt = Regex.Replace(txt, "&lesseqgtr;", "⋚");

            // "U+022DB", "GREATER-THAN EQUAL TO OR LESS-THAN"
            txt = Regex.Replace(txt, "&#x0*?22DB;", "⋛");
            txt = Regex.Replace(txt, "&#0*?8923;", "⋛");
            txt = Regex.Replace(txt, "&gel;", "⋛");
            txt = Regex.Replace(txt, "&gtreqless;", "⋛");
            txt = Regex.Replace(txt, "&GreaterEqualLess;", "⋛");

            // "U+022DE", "EQUAL TO OR PRECEDES"
            txt = Regex.Replace(txt, "&#x0*?22DE;", "⋞");
            txt = Regex.Replace(txt, "&#0*?8926;", "⋞");
            txt = Regex.Replace(txt, "&cuepr;", "⋞");
            txt = Regex.Replace(txt, "&curlyeqprec;", "⋞");

            // "U+022DF", "EQUAL TO OR SUCCEEDS"
            txt = Regex.Replace(txt, "&#x0*?22DF;", "⋟");
            txt = Regex.Replace(txt, "&#0*?8927;", "⋟");
            txt = Regex.Replace(txt, "&cuesc;", "⋟");
            txt = Regex.Replace(txt, "&curlyeqsucc;", "⋟");

            // "U+022E0", "DOES NOT PRECEDE OR EQUAL"
            txt = Regex.Replace(txt, "&#x0*?22E0;", "⋠");
            txt = Regex.Replace(txt, "&#0*?8928;", "⋠");
            txt = Regex.Replace(txt, "&nprcue;", "⋠");
            txt = Regex.Replace(txt, "&NotPrecedesSlantEqual;", "⋠");

            // "U+022E1", "DOES NOT SUCCEED OR EQUAL"
            txt = Regex.Replace(txt, "&#x0*?22E1;", "⋡");
            txt = Regex.Replace(txt, "&#0*?8929;", "⋡");
            txt = Regex.Replace(txt, "&nsccue;", "⋡");
            txt = Regex.Replace(txt, "&NotSucceedsSlantEqual;", "⋡");

            // "U+022E2", "NOT SQUARE IMAGE OF OR EQUAL TO"
            txt = Regex.Replace(txt, "&#x0*?22E2;", "⋢");
            txt = Regex.Replace(txt, "&#0*?8930;", "⋢");
            txt = Regex.Replace(txt, "&nsqsube;", "⋢");
            txt = Regex.Replace(txt, "&NotSquareSubsetEqual;", "⋢");

            // "U+022E3", "NOT SQUARE ORIGINAL OF OR EQUAL TO"
            txt = Regex.Replace(txt, "&#x0*?22E3;", "⋣");
            txt = Regex.Replace(txt, "&#0*?8931;", "⋣");
            txt = Regex.Replace(txt, "&nsqsupe;", "⋣");
            txt = Regex.Replace(txt, "&NotSquareSupersetEqual;", "⋣");

            // "U+022E6", "LESS-THAN BUT NOT EQUIVALENT TO"
            txt = Regex.Replace(txt, "&#x0*?22E6;", "⋦");
            txt = Regex.Replace(txt, "&#0*?8934;", "⋦");
            txt = Regex.Replace(txt, "&lnsim;", "⋦");

            // "U+022E7", "GREATER-THAN BUT NOT EQUIVALENT TO"
            txt = Regex.Replace(txt, "&#x0*?22E7;", "⋧");
            txt = Regex.Replace(txt, "&#0*?8935;", "⋧");
            txt = Regex.Replace(txt, "&gnsim;", "⋧");

            // "U+022E8", "PRECEDES BUT NOT EQUIVALENT TO"
            txt = Regex.Replace(txt, "&#x0*?22E8;", "⋨");
            txt = Regex.Replace(txt, "&#0*?8936;", "⋨");
            txt = Regex.Replace(txt, "&prnsim;", "⋨");
            txt = Regex.Replace(txt, "&precnsim;", "⋨");

            // "U+022E9", "SUCCEEDS BUT NOT EQUIVALENT TO"
            txt = Regex.Replace(txt, "&#x0*?22E9;", "⋩");
            txt = Regex.Replace(txt, "&#0*?8937;", "⋩");
            txt = Regex.Replace(txt, "&scnsim;", "⋩");
            txt = Regex.Replace(txt, "&succnsim;", "⋩");

            // "U+022EA", "NOT NORMAL SUBGROUP OF"
            txt = Regex.Replace(txt, "&#x0*?22EA;", "⋪");
            txt = Regex.Replace(txt, "&#0*?8938;", "⋪");
            txt = Regex.Replace(txt, "&nltri;", "⋪");
            txt = Regex.Replace(txt, "&ntriangleleft;", "⋪");
            txt = Regex.Replace(txt, "&NotLeftTriangle;", "⋪");

            // "U+022EB", "DOES NOT CONTAIN AS NORMAL SUBGROUP"
            txt = Regex.Replace(txt, "&#x0*?22EB;", "⋫");
            txt = Regex.Replace(txt, "&#0*?8939;", "⋫");
            txt = Regex.Replace(txt, "&nrtri;", "⋫");
            txt = Regex.Replace(txt, "&ntriangleright;", "⋫");
            txt = Regex.Replace(txt, "&NotRightTriangle;", "⋫");

            // "U+022EC", "NOT NORMAL SUBGROUP OF OR EQUAL TO"
            txt = Regex.Replace(txt, "&#x0*?22EC;", "⋬");
            txt = Regex.Replace(txt, "&#0*?8940;", "⋬");
            txt = Regex.Replace(txt, "&nltrie;", "⋬");
            txt = Regex.Replace(txt, "&ntrianglelefteq;", "⋬");
            txt = Regex.Replace(txt, "&NotLeftTriangleEqual;", "⋬");

            // "U+022ED", "DOES NOT CONTAIN AS NORMAL SUBGROUP OR EQUAL"
            txt = Regex.Replace(txt, "&#x0*?22ED;", "⋭");
            txt = Regex.Replace(txt, "&#0*?8941;", "⋭");
            txt = Regex.Replace(txt, "&nrtrie;", "⋭");
            txt = Regex.Replace(txt, "&ntrianglerighteq;", "⋭");
            txt = Regex.Replace(txt, "&NotRightTriangleEqual;", "⋭");

            // "U+022EE", "VERTICAL ELLIPSIS"
            txt = Regex.Replace(txt, "&#x0*?22EE;", "⋮");
            txt = Regex.Replace(txt, "&#0*?8942;", "⋮");
            txt = Regex.Replace(txt, "&vellip;", "⋮");

            // "U+022EF", "MIDLINE HORIZONTAL ELLIPSIS"
            txt = Regex.Replace(txt, "&#x0*?22EF;", "⋯");
            txt = Regex.Replace(txt, "&#0*?8943;", "⋯");
            txt = Regex.Replace(txt, "&ctdot;", "⋯");

            // "U+022F0", "UP RIGHT DIAGONAL ELLIPSIS"
            txt = Regex.Replace(txt, "&#x0*?22F0;", "⋰");
            txt = Regex.Replace(txt, "&#0*?8944;", "⋰");
            txt = Regex.Replace(txt, "&utdot;", "⋰");

            // "U+022F1", "DOWN RIGHT DIAGONAL ELLIPSIS"
            txt = Regex.Replace(txt, "&#x0*?22F1;", "⋱");
            txt = Regex.Replace(txt, "&#0*?8945;", "⋱");
            txt = Regex.Replace(txt, "&dtdot;", "⋱");

            // "U+022F2", "ELEMENT OF WITH LONG HORIZONTAL STROKE"
            txt = Regex.Replace(txt, "&#x0*?22F2;", "⋲");
            txt = Regex.Replace(txt, "&#0*?8946;", "⋲");
            txt = Regex.Replace(txt, "&disin;", "⋲");

            // "U+022F3", "ELEMENT OF WITH VERTICAL BAR AT END OF HORIZONTAL STROKE"
            txt = Regex.Replace(txt, "&#x0*?22F3;", "⋳");
            txt = Regex.Replace(txt, "&#0*?8947;", "⋳");
            txt = Regex.Replace(txt, "&isinsv;", "⋳");

            // "U+022F4", "SMALL ELEMENT OF WITH VERTICAL BAR AT END OF HORIZONTAL STROKE"
            txt = Regex.Replace(txt, "&#x0*?22F4;", "⋴");
            txt = Regex.Replace(txt, "&#0*?8948;", "⋴");
            txt = Regex.Replace(txt, "&isins;", "⋴");

            // "U+022F5", "ELEMENT OF WITH DOT ABOVE"
            txt = Regex.Replace(txt, "&#x0*?22F5;", "⋵");
            txt = Regex.Replace(txt, "&#0*?8949;", "⋵");
            txt = Regex.Replace(txt, "&isindot;", "⋵");

            // "U+022F6", "ELEMENT OF WITH OVERBAR"
            txt = Regex.Replace(txt, "&#x0*?22F6;", "⋶");
            txt = Regex.Replace(txt, "&#0*?8950;", "⋶");
            txt = Regex.Replace(txt, "&notinvc;", "⋶");

            // "U+022F7", "SMALL ELEMENT OF WITH OVERBAR"
            txt = Regex.Replace(txt, "&#x0*?22F7;", "⋷");
            txt = Regex.Replace(txt, "&#0*?8951;", "⋷");
            txt = Regex.Replace(txt, "&notinvb;", "⋷");

            // "U+022F9", "ELEMENT OF WITH TWO HORIZONTAL STROKES"
            txt = Regex.Replace(txt, "&#x0*?22F9;", "⋹");
            txt = Regex.Replace(txt, "&#0*?8953;", "⋹");
            txt = Regex.Replace(txt, "&isinE;", "⋹");

            // "U+022FA", "CONTAINS WITH LONG HORIZONTAL STROKE"
            txt = Regex.Replace(txt, "&#x0*?22FA;", "⋺");
            txt = Regex.Replace(txt, "&#0*?8954;", "⋺");
            txt = Regex.Replace(txt, "&nisd;", "⋺");

            // "U+022FB", "CONTAINS WITH VERTICAL BAR AT END OF HORIZONTAL STROKE"
            txt = Regex.Replace(txt, "&#x0*?22FB;", "⋻");
            txt = Regex.Replace(txt, "&#0*?8955;", "⋻");
            txt = Regex.Replace(txt, "&xnis;", "⋻");

            // "U+022FC", "SMALL CONTAINS WITH VERTICAL BAR AT END OF HORIZONTAL STROKE"
            txt = Regex.Replace(txt, "&#x0*?22FC;", "⋼");
            txt = Regex.Replace(txt, "&#0*?8956;", "⋼");
            txt = Regex.Replace(txt, "&nis;", "⋼");

            // "U+022FD", "CONTAINS WITH OVERBAR"
            txt = Regex.Replace(txt, "&#x0*?22FD;", "⋽");
            txt = Regex.Replace(txt, "&#0*?8957;", "⋽");
            txt = Regex.Replace(txt, "&notnivc;", "⋽");

            // "U+022FE", "SMALL CONTAINS WITH OVERBAR"
            txt = Regex.Replace(txt, "&#x0*?22FE;", "⋾");
            txt = Regex.Replace(txt, "&#0*?8958;", "⋾");
            txt = Regex.Replace(txt, "&notnivb;", "⋾");

            // "U+02305", "PROJECTIVE"
            txt = Regex.Replace(txt, "&#x0*?2305;", "⌅");
            txt = Regex.Replace(txt, "&#0*?8965;", "⌅");
            txt = Regex.Replace(txt, "&barwed;", "⌅");
            txt = Regex.Replace(txt, "&barwedge;", "⌅");

            // "U+02306", "PERSPECTIVE"
            txt = Regex.Replace(txt, "&#x0*?2306;", "⌆");
            txt = Regex.Replace(txt, "&#0*?8966;", "⌆");
            txt = Regex.Replace(txt, "&Barwed;", "⌆");
            txt = Regex.Replace(txt, "&doublebarwedge;", "⌆");

            // "U+02308", "LEFT CEILING"
            txt = Regex.Replace(txt, "&#x0*?2308;", "⌈");
            txt = Regex.Replace(txt, "&#0*?8968;", "⌈");
            txt = Regex.Replace(txt, "&lceil;", "⌈");
            txt = Regex.Replace(txt, "&LeftCeiling;", "⌈");

            // "U+02309", "RIGHT CEILING"
            txt = Regex.Replace(txt, "&#x0*?2309;", "⌉");
            txt = Regex.Replace(txt, "&#0*?8969;", "⌉");
            txt = Regex.Replace(txt, "&rceil;", "⌉");
            txt = Regex.Replace(txt, "&RightCeiling;", "⌉");

            // "U+0230A", "LEFT FLOOR"
            txt = Regex.Replace(txt, "&#x0*?230A;", "⌊");
            txt = Regex.Replace(txt, "&#0*?8970;", "⌊");
            txt = Regex.Replace(txt, "&lfloor;", "⌊");
            txt = Regex.Replace(txt, "&LeftFloor;", "⌊");

            // "U+0230B", "RIGHT FLOOR"
            txt = Regex.Replace(txt, "&#x0*?230B;", "⌋");
            txt = Regex.Replace(txt, "&#0*?8971;", "⌋");
            txt = Regex.Replace(txt, "&rfloor;", "⌋");
            txt = Regex.Replace(txt, "&RightFloor;", "⌋");

            // "U+0230C", "BOTTOM RIGHT CROP"
            txt = Regex.Replace(txt, "&#x0*?230C;", "⌌");
            txt = Regex.Replace(txt, "&#0*?8972;", "⌌");
            txt = Regex.Replace(txt, "&drcrop;", "⌌");

            // "U+0230D", "BOTTOM LEFT CROP"
            txt = Regex.Replace(txt, "&#x0*?230D;", "⌍");
            txt = Regex.Replace(txt, "&#0*?8973;", "⌍");
            txt = Regex.Replace(txt, "&dlcrop;", "⌍");

            // "U+0230E", "TOP RIGHT CROP"
            txt = Regex.Replace(txt, "&#x0*?230E;", "⌎");
            txt = Regex.Replace(txt, "&#0*?8974;", "⌎");
            txt = Regex.Replace(txt, "&urcrop;", "⌎");

            // "U+0230F", "TOP LEFT CROP"
            txt = Regex.Replace(txt, "&#x0*?230F;", "⌏");
            txt = Regex.Replace(txt, "&#0*?8975;", "⌏");
            txt = Regex.Replace(txt, "&ulcrop;", "⌏");

            // "U+02310", "REVERSED NOT SIGN"
            txt = Regex.Replace(txt, "&#x0*?2310;", "⌐");
            txt = Regex.Replace(txt, "&#0*?8976;", "⌐");
            txt = Regex.Replace(txt, "&bnot;", "⌐");

            // "U+02312", "ARC"
            txt = Regex.Replace(txt, "&#x0*?2312;", "⌒");
            txt = Regex.Replace(txt, "&#0*?8978;", "⌒");
            txt = Regex.Replace(txt, "&profline;", "⌒");

            // "U+02313", "SEGMENT"
            txt = Regex.Replace(txt, "&#x0*?2313;", "⌓");
            txt = Regex.Replace(txt, "&#0*?8979;", "⌓");
            txt = Regex.Replace(txt, "&profsurf;", "⌓");

            // "U+02315", "TELEPHONE RECORDER"
            txt = Regex.Replace(txt, "&#x0*?2315;", "⌕");
            txt = Regex.Replace(txt, "&#0*?8981;", "⌕");
            txt = Regex.Replace(txt, "&telrec;", "⌕");

            // "U+02316", "POSITION INDICATOR"
            txt = Regex.Replace(txt, "&#x0*?2316;", "⌖");
            txt = Regex.Replace(txt, "&#0*?8982;", "⌖");
            txt = Regex.Replace(txt, "&target;", "⌖");

            // "U+0231C", "TOP LEFT CORNER"
            txt = Regex.Replace(txt, "&#x0*?231C;", "⌜");
            txt = Regex.Replace(txt, "&#0*?8988;", "⌜");
            txt = Regex.Replace(txt, "&ulcorn;", "⌜");
            txt = Regex.Replace(txt, "&ulcorner;", "⌜");

            // "U+0231D", "TOP RIGHT CORNER"
            txt = Regex.Replace(txt, "&#x0*?231D;", "⌝");
            txt = Regex.Replace(txt, "&#0*?8989;", "⌝");
            txt = Regex.Replace(txt, "&urcorn;", "⌝");
            txt = Regex.Replace(txt, "&urcorner;", "⌝");

            // "U+0231E", "BOTTOM LEFT CORNER"
            txt = Regex.Replace(txt, "&#x0*?231E;", "⌞");
            txt = Regex.Replace(txt, "&#0*?8990;", "⌞");
            txt = Regex.Replace(txt, "&dlcorn;", "⌞");
            txt = Regex.Replace(txt, "&llcorner;", "⌞");

            // "U+0231F", "BOTTOM RIGHT CORNER"
            txt = Regex.Replace(txt, "&#x0*?231F;", "⌟");
            txt = Regex.Replace(txt, "&#0*?8991;", "⌟");
            txt = Regex.Replace(txt, "&drcorn;", "⌟");
            txt = Regex.Replace(txt, "&lrcorner;", "⌟");

            // "U+02322", "FROWN"
            txt = Regex.Replace(txt, "&#x0*?2322;", "⌢");
            txt = Regex.Replace(txt, "&#0*?8994;", "⌢");
            txt = Regex.Replace(txt, "&frown;", "⌢");
            txt = Regex.Replace(txt, "&sfrown;", "⌢");

            // "U+02323", "SMILE"
            txt = Regex.Replace(txt, "&#x0*?2323;", "⌣");
            txt = Regex.Replace(txt, "&#0*?8995;", "⌣");
            txt = Regex.Replace(txt, "&smile;", "⌣");
            txt = Regex.Replace(txt, "&ssmile;", "⌣");

            // "U+0232D", "CYLINDRICITY"
            txt = Regex.Replace(txt, "&#x0*?232D;", "⌭");
            txt = Regex.Replace(txt, "&#0*?9005;", "⌭");
            txt = Regex.Replace(txt, "&cylcty;", "⌭");

            // "U+0232E", "ALL AROUND-PROFILE"
            txt = Regex.Replace(txt, "&#x0*?232E;", "⌮");
            txt = Regex.Replace(txt, "&#0*?9006;", "⌮");
            txt = Regex.Replace(txt, "&profalar;", "⌮");

            // "U+02336", "APL FUNCTIONAL SYMBOL I-BEAM"
            txt = Regex.Replace(txt, "&#x0*?2336;", "⌶");
            txt = Regex.Replace(txt, "&#0*?9014;", "⌶");
            txt = Regex.Replace(txt, "&topbot;", "⌶");

            // "U+0233D", "APL FUNCTIONAL SYMBOL CIRCLE STILE"
            txt = Regex.Replace(txt, "&#x0*?233D;", "⌽");
            txt = Regex.Replace(txt, "&#0*?9021;", "⌽");
            txt = Regex.Replace(txt, "&ovbar;", "⌽");

            // "U+0233F", "APL FUNCTIONAL SYMBOL SLASH BAR"
            txt = Regex.Replace(txt, "&#x0*?233F;", "⌿");
            txt = Regex.Replace(txt, "&#0*?9023;", "⌿");
            txt = Regex.Replace(txt, "&solbar;", "⌿");

            // "U+0237C", "RIGHT ANGLE WITH DOWNWARDS ZIGZAG ARROW"
            txt = Regex.Replace(txt, "&#x0*?237C;", "⍼");
            txt = Regex.Replace(txt, "&#0*?9084;", "⍼");
            txt = Regex.Replace(txt, "&angzarr;", "⍼");

            // "U+023B0", "UPPER LEFT OR LOWER RIGHT CURLY BRACKET SECTION"
            txt = Regex.Replace(txt, "&#x0*?23B0;", "⎰");
            txt = Regex.Replace(txt, "&#0*?9136;", "⎰");
            txt = Regex.Replace(txt, "&lmoust;", "⎰");
            txt = Regex.Replace(txt, "&lmoustache;", "⎰");

            // "U+023B1", "UPPER RIGHT OR LOWER LEFT CURLY BRACKET SECTION"
            txt = Regex.Replace(txt, "&#x0*?23B1;", "⎱");
            txt = Regex.Replace(txt, "&#0*?9137;", "⎱");
            txt = Regex.Replace(txt, "&rmoust;", "⎱");
            txt = Regex.Replace(txt, "&rmoustache;", "⎱");

            // "U+023B4", "TOP SQUARE BRACKET"
            txt = Regex.Replace(txt, "&#x0*?23B4;", "⎴");
            txt = Regex.Replace(txt, "&#0*?9140;", "⎴");
            txt = Regex.Replace(txt, "&tbrk;", "⎴");
            txt = Regex.Replace(txt, "&OverBracket;", "⎴");

            // "U+023B5", "BOTTOM SQUARE BRACKET"
            txt = Regex.Replace(txt, "&#x0*?23B5;", "⎵");
            txt = Regex.Replace(txt, "&#0*?9141;", "⎵");
            txt = Regex.Replace(txt, "&bbrk;", "⎵");
            txt = Regex.Replace(txt, "&UnderBracket;", "⎵");

            // "U+023B6", "BOTTOM SQUARE BRACKET OVER TOP SQUARE BRACKET"
            txt = Regex.Replace(txt, "&#x0*?23B6;", "⎶");
            txt = Regex.Replace(txt, "&#0*?9142;", "⎶");
            txt = Regex.Replace(txt, "&bbrktbrk;", "⎶");

            // "U+023DC", "TOP PARENTHESIS"
            txt = Regex.Replace(txt, "&#x0*?23DC;", "⏜");
            txt = Regex.Replace(txt, "&#0*?9180;", "⏜");
            txt = Regex.Replace(txt, "&OverParenthesis;", "⏜");

            // "U+023DD", "BOTTOM PARENTHESIS"
            txt = Regex.Replace(txt, "&#x0*?23DD;", "⏝");
            txt = Regex.Replace(txt, "&#0*?9181;", "⏝");
            txt = Regex.Replace(txt, "&UnderParenthesis;", "⏝");

            // "U+023DE", "TOP CURLY BRACKET"
            txt = Regex.Replace(txt, "&#x0*?23DE;", "⏞");
            txt = Regex.Replace(txt, "&#0*?9182;", "⏞");
            txt = Regex.Replace(txt, "&OverBrace;", "⏞");

            // "U+023DF", "BOTTOM CURLY BRACKET"
            txt = Regex.Replace(txt, "&#x0*?23DF;", "⏟");
            txt = Regex.Replace(txt, "&#0*?9183;", "⏟");
            txt = Regex.Replace(txt, "&UnderBrace;", "⏟");

            // "U+023E2", "WHITE TRAPEZIUM"
            txt = Regex.Replace(txt, "&#x0*?23E2;", "⏢");
            txt = Regex.Replace(txt, "&#0*?9186;", "⏢");
            txt = Regex.Replace(txt, "&trpezium;", "⏢");

            // "U+023E7", "ELECTRICAL INTERSECTION"
            txt = Regex.Replace(txt, "&#x0*?23E7;", "⏧");
            txt = Regex.Replace(txt, "&#0*?9191;", "⏧");
            txt = Regex.Replace(txt, "&elinters;", "⏧");

            // "U+02423", "OPEN BOX"
            txt = Regex.Replace(txt, "&#x0*?2423;", "␣");
            txt = Regex.Replace(txt, "&#0*?9251;", "␣");
            txt = Regex.Replace(txt, "&blank;", "␣");

            // "U+024C8", "CIRCLED LATIN CAPITAL LETTER S"
            txt = Regex.Replace(txt, "&#x0*?24C8;", "Ⓢ");
            txt = Regex.Replace(txt, "&#0*?9416;", "Ⓢ");
            txt = Regex.Replace(txt, "&oS;", "Ⓢ");
            txt = Regex.Replace(txt, "&circledS;", "Ⓢ");

            // "U+02500", "BOX DRAWINGS LIGHT HORIZONTAL"
            txt = Regex.Replace(txt, "&#x0*?2500;", "─");
            txt = Regex.Replace(txt, "&#0*?9472;", "─");
            txt = Regex.Replace(txt, "&boxh;", "─");
            txt = Regex.Replace(txt, "&HorizontalLine;", "─");

            // "U+02502", "BOX DRAWINGS LIGHT VERTICAL"
            txt = Regex.Replace(txt, "&#x0*?2502;", "│");
            txt = Regex.Replace(txt, "&#0*?9474;", "│");
            txt = Regex.Replace(txt, "&boxv;", "│");

            // "U+0250C", "BOX DRAWINGS LIGHT DOWN AND RIGHT"
            txt = Regex.Replace(txt, "&#x0*?250C;", "┌");
            txt = Regex.Replace(txt, "&#0*?9484;", "┌");
            txt = Regex.Replace(txt, "&boxdr;", "┌");

            // "U+02510", "BOX DRAWINGS LIGHT DOWN AND LEFT"
            txt = Regex.Replace(txt, "&#x0*?2510;", "┐");
            txt = Regex.Replace(txt, "&#0*?9488;", "┐");
            txt = Regex.Replace(txt, "&boxdl;", "┐");

            // "U+02514", "BOX DRAWINGS LIGHT UP AND RIGHT"
            txt = Regex.Replace(txt, "&#x0*?2514;", "└");
            txt = Regex.Replace(txt, "&#0*?9492;", "└");
            txt = Regex.Replace(txt, "&boxur;", "└");

            // "U+02518", "BOX DRAWINGS LIGHT UP AND LEFT"
            txt = Regex.Replace(txt, "&#x0*?2518;", "┘");
            txt = Regex.Replace(txt, "&#0*?9496;", "┘");
            txt = Regex.Replace(txt, "&boxul;", "┘");

            // "U+0251C", "BOX DRAWINGS LIGHT VERTICAL AND RIGHT"
            txt = Regex.Replace(txt, "&#x0*?251C;", "├");
            txt = Regex.Replace(txt, "&#0*?9500;", "├");
            txt = Regex.Replace(txt, "&boxvr;", "├");

            // "U+02524", "BOX DRAWINGS LIGHT VERTICAL AND LEFT"
            txt = Regex.Replace(txt, "&#x0*?2524;", "┤");
            txt = Regex.Replace(txt, "&#0*?9508;", "┤");
            txt = Regex.Replace(txt, "&boxvl;", "┤");

            // "U+0252C", "BOX DRAWINGS LIGHT DOWN AND HORIZONTAL"
            txt = Regex.Replace(txt, "&#x0*?252C;", "┬");
            txt = Regex.Replace(txt, "&#0*?9516;", "┬");
            txt = Regex.Replace(txt, "&boxhd;", "┬");

            // "U+02534", "BOX DRAWINGS LIGHT UP AND HORIZONTAL"
            txt = Regex.Replace(txt, "&#x0*?2534;", "┴");
            txt = Regex.Replace(txt, "&#0*?9524;", "┴");
            txt = Regex.Replace(txt, "&boxhu;", "┴");

            // "U+0253C", "BOX DRAWINGS LIGHT VERTICAL AND HORIZONTAL"
            txt = Regex.Replace(txt, "&#x0*?253C;", "┼");
            txt = Regex.Replace(txt, "&#0*?9532;", "┼");
            txt = Regex.Replace(txt, "&boxvh;", "┼");

            // "U+02550", "BOX DRAWINGS DOUBLE HORIZONTAL"
            txt = Regex.Replace(txt, "&#x0*?2550;", "═");
            txt = Regex.Replace(txt, "&#0*?9552;", "═");
            txt = Regex.Replace(txt, "&boxH;", "═");

            // "U+02551", "BOX DRAWINGS DOUBLE VERTICAL"
            txt = Regex.Replace(txt, "&#x0*?2551;", "║");
            txt = Regex.Replace(txt, "&#0*?9553;", "║");
            txt = Regex.Replace(txt, "&boxV;", "║");

            // "U+02552", "BOX DRAWINGS DOWN SINGLE AND RIGHT DOUBLE"
            txt = Regex.Replace(txt, "&#x0*?2552;", "╒");
            txt = Regex.Replace(txt, "&#0*?9554;", "╒");
            txt = Regex.Replace(txt, "&boxdR;", "╒");

            // "U+02553", "BOX DRAWINGS DOWN DOUBLE AND RIGHT SINGLE"
            txt = Regex.Replace(txt, "&#x0*?2553;", "╓");
            txt = Regex.Replace(txt, "&#0*?9555;", "╓");
            txt = Regex.Replace(txt, "&boxDr;", "╓");

            // "U+02554", "BOX DRAWINGS DOUBLE DOWN AND RIGHT"
            txt = Regex.Replace(txt, "&#x0*?2554;", "╔");
            txt = Regex.Replace(txt, "&#0*?9556;", "╔");
            txt = Regex.Replace(txt, "&boxDR;", "╔");

            // "U+02555", "BOX DRAWINGS DOWN SINGLE AND LEFT DOUBLE"
            txt = Regex.Replace(txt, "&#x0*?2555;", "╕");
            txt = Regex.Replace(txt, "&#0*?9557;", "╕");
            txt = Regex.Replace(txt, "&boxdL;", "╕");

            // "U+02556", "BOX DRAWINGS DOWN DOUBLE AND LEFT SINGLE"
            txt = Regex.Replace(txt, "&#x0*?2556;", "╖");
            txt = Regex.Replace(txt, "&#0*?9558;", "╖");
            txt = Regex.Replace(txt, "&boxDl;", "╖");

            // "U+02557", "BOX DRAWINGS DOUBLE DOWN AND LEFT"
            txt = Regex.Replace(txt, "&#x0*?2557;", "╗");
            txt = Regex.Replace(txt, "&#0*?9559;", "╗");
            txt = Regex.Replace(txt, "&boxDL;", "╗");

            // "U+02558", "BOX DRAWINGS UP SINGLE AND RIGHT DOUBLE"
            txt = Regex.Replace(txt, "&#x0*?2558;", "╘");
            txt = Regex.Replace(txt, "&#0*?9560;", "╘");
            txt = Regex.Replace(txt, "&boxuR;", "╘");

            // "U+02559", "BOX DRAWINGS UP DOUBLE AND RIGHT SINGLE"
            txt = Regex.Replace(txt, "&#x0*?2559;", "╙");
            txt = Regex.Replace(txt, "&#0*?9561;", "╙");
            txt = Regex.Replace(txt, "&boxUr;", "╙");

            // "U+0255A", "BOX DRAWINGS DOUBLE UP AND RIGHT"
            txt = Regex.Replace(txt, "&#x0*?255A;", "╚");
            txt = Regex.Replace(txt, "&#0*?9562;", "╚");
            txt = Regex.Replace(txt, "&boxUR;", "╚");

            // "U+0255B", "BOX DRAWINGS UP SINGLE AND LEFT DOUBLE"
            txt = Regex.Replace(txt, "&#x0*?255B;", "╛");
            txt = Regex.Replace(txt, "&#0*?9563;", "╛");
            txt = Regex.Replace(txt, "&boxuL;", "╛");

            // "U+0255C", "BOX DRAWINGS UP DOUBLE AND LEFT SINGLE"
            txt = Regex.Replace(txt, "&#x0*?255C;", "╜");
            txt = Regex.Replace(txt, "&#0*?9564;", "╜");
            txt = Regex.Replace(txt, "&boxUl;", "╜");

            // "U+0255D", "BOX DRAWINGS DOUBLE UP AND LEFT"
            txt = Regex.Replace(txt, "&#x0*?255D;", "╝");
            txt = Regex.Replace(txt, "&#0*?9565;", "╝");
            txt = Regex.Replace(txt, "&boxUL;", "╝");

            // "U+0255E", "BOX DRAWINGS VERTICAL SINGLE AND RIGHT DOUBLE"
            txt = Regex.Replace(txt, "&#x0*?255E;", "╞");
            txt = Regex.Replace(txt, "&#0*?9566;", "╞");
            txt = Regex.Replace(txt, "&boxvR;", "╞");

            // "U+0255F", "BOX DRAWINGS VERTICAL DOUBLE AND RIGHT SINGLE"
            txt = Regex.Replace(txt, "&#x0*?255F;", "╟");
            txt = Regex.Replace(txt, "&#0*?9567;", "╟");
            txt = Regex.Replace(txt, "&boxVr;", "╟");

            // "U+02560", "BOX DRAWINGS DOUBLE VERTICAL AND RIGHT"
            txt = Regex.Replace(txt, "&#x0*?2560;", "╠");
            txt = Regex.Replace(txt, "&#0*?9568;", "╠");
            txt = Regex.Replace(txt, "&boxVR;", "╠");

            // "U+02561", "BOX DRAWINGS VERTICAL SINGLE AND LEFT DOUBLE"
            txt = Regex.Replace(txt, "&#x0*?2561;", "╡");
            txt = Regex.Replace(txt, "&#0*?9569;", "╡");
            txt = Regex.Replace(txt, "&boxvL;", "╡");

            // "U+02562", "BOX DRAWINGS VERTICAL DOUBLE AND LEFT SINGLE"
            txt = Regex.Replace(txt, "&#x0*?2562;", "╢");
            txt = Regex.Replace(txt, "&#0*?9570;", "╢");
            txt = Regex.Replace(txt, "&boxVl;", "╢");

            // "U+02563", "BOX DRAWINGS DOUBLE VERTICAL AND LEFT"
            txt = Regex.Replace(txt, "&#x0*?2563;", "╣");
            txt = Regex.Replace(txt, "&#0*?9571;", "╣");
            txt = Regex.Replace(txt, "&boxVL;", "╣");

            // "U+02564", "BOX DRAWINGS DOWN SINGLE AND HORIZONTAL DOUBLE"
            txt = Regex.Replace(txt, "&#x0*?2564;", "╤");
            txt = Regex.Replace(txt, "&#0*?9572;", "╤");
            txt = Regex.Replace(txt, "&boxHd;", "╤");

            // "U+02565", "BOX DRAWINGS DOWN DOUBLE AND HORIZONTAL SINGLE"
            txt = Regex.Replace(txt, "&#x0*?2565;", "╥");
            txt = Regex.Replace(txt, "&#0*?9573;", "╥");
            txt = Regex.Replace(txt, "&boxhD;", "╥");

            // "U+02566", "BOX DRAWINGS DOUBLE DOWN AND HORIZONTAL"
            txt = Regex.Replace(txt, "&#x0*?2566;", "╦");
            txt = Regex.Replace(txt, "&#0*?9574;", "╦");
            txt = Regex.Replace(txt, "&boxHD;", "╦");

            // "U+02567", "BOX DRAWINGS UP SINGLE AND HORIZONTAL DOUBLE"
            txt = Regex.Replace(txt, "&#x0*?2567;", "╧");
            txt = Regex.Replace(txt, "&#0*?9575;", "╧");
            txt = Regex.Replace(txt, "&boxHu;", "╧");

            // "U+02568", "BOX DRAWINGS UP DOUBLE AND HORIZONTAL SINGLE"
            txt = Regex.Replace(txt, "&#x0*?2568;", "╨");
            txt = Regex.Replace(txt, "&#0*?9576;", "╨");
            txt = Regex.Replace(txt, "&boxhU;", "╨");

            // "U+02569", "BOX DRAWINGS DOUBLE UP AND HORIZONTAL"
            txt = Regex.Replace(txt, "&#x0*?2569;", "╩");
            txt = Regex.Replace(txt, "&#0*?9577;", "╩");
            txt = Regex.Replace(txt, "&boxHU;", "╩");

            // "U+0256A", "BOX DRAWINGS VERTICAL SINGLE AND HORIZONTAL DOUBLE"
            txt = Regex.Replace(txt, "&#x0*?256A;", "╪");
            txt = Regex.Replace(txt, "&#0*?9578;", "╪");
            txt = Regex.Replace(txt, "&boxvH;", "╪");

            // "U+0256B", "BOX DRAWINGS VERTICAL DOUBLE AND HORIZONTAL SINGLE"
            txt = Regex.Replace(txt, "&#x0*?256B;", "╫");
            txt = Regex.Replace(txt, "&#0*?9579;", "╫");
            txt = Regex.Replace(txt, "&boxVh;", "╫");

            // "U+0256C", "BOX DRAWINGS DOUBLE VERTICAL AND HORIZONTAL"
            txt = Regex.Replace(txt, "&#x0*?256C;", "╬");
            txt = Regex.Replace(txt, "&#0*?9580;", "╬");
            txt = Regex.Replace(txt, "&boxVH;", "╬");

            // "U+02580", "UPPER HALF BLOCK"
            txt = Regex.Replace(txt, "&#x0*?2580;", "▀");
            txt = Regex.Replace(txt, "&#0*?9600;", "▀");
            txt = Regex.Replace(txt, "&uhblk;", "▀");

            // "U+02584", "LOWER HALF BLOCK"
            txt = Regex.Replace(txt, "&#x0*?2584;", "▄");
            txt = Regex.Replace(txt, "&#0*?9604;", "▄");
            txt = Regex.Replace(txt, "&lhblk;", "▄");

            // "U+02588", "FULL BLOCK"
            txt = Regex.Replace(txt, "&#x0*?2588;", "█");
            txt = Regex.Replace(txt, "&#0*?9608;", "█");
            txt = Regex.Replace(txt, "&block;", "█");

            // "U+02591", "LIGHT SHADE"
            txt = Regex.Replace(txt, "&#x0*?2591;", "░");
            txt = Regex.Replace(txt, "&#0*?9617;", "░");
            txt = Regex.Replace(txt, "&blk14;", "░");

            // "U+02592", "MEDIUM SHADE"
            txt = Regex.Replace(txt, "&#x0*?2592;", "▒");
            txt = Regex.Replace(txt, "&#0*?9618;", "▒");
            txt = Regex.Replace(txt, "&blk12;", "▒");

            // "U+02593", "DARK SHADE"
            txt = Regex.Replace(txt, "&#x0*?2593;", "▓");
            txt = Regex.Replace(txt, "&#0*?9619;", "▓");
            txt = Regex.Replace(txt, "&blk34;", "▓");

            // "U+025A1", "WHITE SQUARE"
            txt = Regex.Replace(txt, "&#x0*?25A1;", "□");
            txt = Regex.Replace(txt, "&#0*?9633;", "□");
            txt = Regex.Replace(txt, "&squ;", "□");
            txt = Regex.Replace(txt, "&square;", "□");
            txt = Regex.Replace(txt, "&Square;", "□");

            // "U+025AA", "BLACK SMALL SQUARE"
            txt = Regex.Replace(txt, "&#x0*?25AA;", "▪");
            txt = Regex.Replace(txt, "&#0*?9642;", "▪");
            txt = Regex.Replace(txt, "&squf;", "▪");
            txt = Regex.Replace(txt, "&squarf;", "▪");
            txt = Regex.Replace(txt, "&blacksquare;", "▪");
            txt = Regex.Replace(txt, "&FilledVerySmallSquare;", "▪");

            // "U+025AB", "WHITE SMALL SQUARE"
            txt = Regex.Replace(txt, "&#x0*?25AB;", "▫");
            txt = Regex.Replace(txt, "&#0*?9643;", "▫");
            txt = Regex.Replace(txt, "&EmptyVerySmallSquare;", "▫");

            // "U+025AD", "WHITE RECTANGLE"
            txt = Regex.Replace(txt, "&#x0*?25AD;", "▭");
            txt = Regex.Replace(txt, "&#0*?9645;", "▭");
            txt = Regex.Replace(txt, "&rect;", "▭");

            // "U+025AE", "BLACK VERTICAL RECTANGLE"
            txt = Regex.Replace(txt, "&#x0*?25AE;", "▮");
            txt = Regex.Replace(txt, "&#0*?9646;", "▮");
            txt = Regex.Replace(txt, "&marker;", "▮");

            // "U+025B1", "WHITE PARALLELOGRAM"
            txt = Regex.Replace(txt, "&#x0*?25B1;", "▱");
            txt = Regex.Replace(txt, "&#0*?9649;", "▱");
            txt = Regex.Replace(txt, "&fltns;", "▱");

            // "U+025B3", "WHITE UP-POINTING TRIANGLE"
            txt = Regex.Replace(txt, "&#x0*?25B3;", "△");
            txt = Regex.Replace(txt, "&#0*?9651;", "△");
            txt = Regex.Replace(txt, "&xutri;", "△");
            txt = Regex.Replace(txt, "&bigtriangleup;", "△");

            // "U+025B4", "BLACK UP-POINTING SMALL TRIANGLE"
            txt = Regex.Replace(txt, "&#x0*?25B4;", "▴");
            txt = Regex.Replace(txt, "&#0*?9652;", "▴");
            txt = Regex.Replace(txt, "&utrif;", "▴");
            txt = Regex.Replace(txt, "&blacktriangle;", "▴");

            // "U+025B5", "WHITE UP-POINTING SMALL TRIANGLE"
            txt = Regex.Replace(txt, "&#x0*?25B5;", "▵");
            txt = Regex.Replace(txt, "&#0*?9653;", "▵");
            txt = Regex.Replace(txt, "&utri;", "▵");
            txt = Regex.Replace(txt, "&triangle;", "▵");

            // "U+025B8", "BLACK RIGHT-POINTING SMALL TRIANGLE"
            txt = Regex.Replace(txt, "&#x0*?25B8;", "▸");
            txt = Regex.Replace(txt, "&#0*?9656;", "▸");
            txt = Regex.Replace(txt, "&rtrif;", "▸");
            txt = Regex.Replace(txt, "&blacktriangleright;", "▸");

            // "U+025B9", "WHITE RIGHT-POINTING SMALL TRIANGLE"
            txt = Regex.Replace(txt, "&#x0*?25B9;", "▹");
            txt = Regex.Replace(txt, "&#0*?9657;", "▹");
            txt = Regex.Replace(txt, "&rtri;", "▹");
            txt = Regex.Replace(txt, "&triangleright;", "▹");

            // "U+025BD", "WHITE DOWN-POINTING TRIANGLE"
            txt = Regex.Replace(txt, "&#x0*?25BD;", "▽");
            txt = Regex.Replace(txt, "&#0*?9661;", "▽");
            txt = Regex.Replace(txt, "&xdtri;", "▽");
            txt = Regex.Replace(txt, "&bigtriangledown;", "▽");

            // "U+025BE", "BLACK DOWN-POINTING SMALL TRIANGLE"
            txt = Regex.Replace(txt, "&#x0*?25BE;", "▾");
            txt = Regex.Replace(txt, "&#0*?9662;", "▾");
            txt = Regex.Replace(txt, "&dtrif;", "▾");
            txt = Regex.Replace(txt, "&blacktriangledown;", "▾");

            // "U+025BF", "WHITE DOWN-POINTING SMALL TRIANGLE"
            txt = Regex.Replace(txt, "&#x0*?25BF;", "▿");
            txt = Regex.Replace(txt, "&#0*?9663;", "▿");
            txt = Regex.Replace(txt, "&dtri;", "▿");
            txt = Regex.Replace(txt, "&triangledown;", "▿");

            // "U+025C2", "BLACK LEFT-POINTING SMALL TRIANGLE"
            txt = Regex.Replace(txt, "&#x0*?25C2;", "◂");
            txt = Regex.Replace(txt, "&#0*?9666;", "◂");
            txt = Regex.Replace(txt, "&ltrif;", "◂");
            txt = Regex.Replace(txt, "&blacktriangleleft;", "◂");

            // "U+025C3", "WHITE LEFT-POINTING SMALL TRIANGLE"
            txt = Regex.Replace(txt, "&#x0*?25C3;", "◃");
            txt = Regex.Replace(txt, "&#0*?9667;", "◃");
            txt = Regex.Replace(txt, "&ltri;", "◃");
            txt = Regex.Replace(txt, "&triangleleft;", "◃");

            // "U+025CA", "LOZENGE"
            txt = Regex.Replace(txt, "&#x0*?25CA;", "◊");
            txt = Regex.Replace(txt, "&#0*?9674;", "◊");
            txt = Regex.Replace(txt, "&loz;", "◊");
            txt = Regex.Replace(txt, "&lozenge;", "◊");

            // "U+025CB", "WHITE CIRCLE"
            txt = Regex.Replace(txt, "&#x0*?25CB;", "○");
            txt = Regex.Replace(txt, "&#0*?9675;", "○");
            txt = Regex.Replace(txt, "&cir;", "○");

            // "U+025EC", "WHITE UP-POINTING TRIANGLE WITH DOT"
            txt = Regex.Replace(txt, "&#x0*?25EC;", "◬");
            txt = Regex.Replace(txt, "&#0*?9708;", "◬");
            txt = Regex.Replace(txt, "&tridot;", "◬");

            // "U+025EF", "LARGE CIRCLE"
            txt = Regex.Replace(txt, "&#x0*?25EF;", "◯");
            txt = Regex.Replace(txt, "&#0*?9711;", "◯");
            txt = Regex.Replace(txt, "&xcirc;", "◯");
            txt = Regex.Replace(txt, "&bigcirc;", "◯");

            // "U+025F8", "UPPER LEFT TRIANGLE"
            txt = Regex.Replace(txt, "&#x0*?25F8;", "◸");
            txt = Regex.Replace(txt, "&#0*?9720;", "◸");
            txt = Regex.Replace(txt, "&ultri;", "◸");

            // "U+025F9", "UPPER RIGHT TRIANGLE"
            txt = Regex.Replace(txt, "&#x0*?25F9;", "◹");
            txt = Regex.Replace(txt, "&#0*?9721;", "◹");
            txt = Regex.Replace(txt, "&urtri;", "◹");

            // "U+025FA", "LOWER LEFT TRIANGLE"
            txt = Regex.Replace(txt, "&#x0*?25FA;", "◺");
            txt = Regex.Replace(txt, "&#0*?9722;", "◺");
            txt = Regex.Replace(txt, "&lltri;", "◺");

            // "U+025FB", "WHITE MEDIUM SQUARE"
            txt = Regex.Replace(txt, "&#x0*?25FB;", "◻");
            txt = Regex.Replace(txt, "&#0*?9723;", "◻");
            txt = Regex.Replace(txt, "&EmptySmallSquare;", "◻");

            // "U+025FC", "BLACK MEDIUM SQUARE"
            txt = Regex.Replace(txt, "&#x0*?25FC;", "◼");
            txt = Regex.Replace(txt, "&#0*?9724;", "◼");
            txt = Regex.Replace(txt, "&FilledSmallSquare;", "◼");

            // "U+02605", "BLACK STAR"
            txt = Regex.Replace(txt, "&#x0*?2605;", "★");
            txt = Regex.Replace(txt, "&#0*?9733;", "★");
            txt = Regex.Replace(txt, "&starf;", "★");
            txt = Regex.Replace(txt, "&bigstar;", "★");

            // "U+02606", "WHITE STAR"
            txt = Regex.Replace(txt, "&#x0*?2606;", "☆");
            txt = Regex.Replace(txt, "&#0*?9734;", "☆");
            txt = Regex.Replace(txt, "&star;", "☆");

            // "U+0260E", "BLACK TELEPHONE"
            txt = Regex.Replace(txt, "&#x0*?260E;", "☎");
            txt = Regex.Replace(txt, "&#0*?9742;", "☎");
            txt = Regex.Replace(txt, "&phone;", "☎");

            // "U+02640", "FEMALE SIGN"
            txt = Regex.Replace(txt, "&#x0*?2640;", "♀");
            txt = Regex.Replace(txt, "&#0*?9792;", "♀");
            txt = Regex.Replace(txt, "&female;", "♀");

            // "U+02642", "MALE SIGN"
            txt = Regex.Replace(txt, "&#x0*?2642;", "♂");
            txt = Regex.Replace(txt, "&#0*?9794;", "♂");
            txt = Regex.Replace(txt, "&male;", "♂");

            // "U+02660", "BLACK SPADE SUIT"
            txt = Regex.Replace(txt, "&#x0*?2660;", "♠");
            txt = Regex.Replace(txt, "&#0*?9824;", "♠");
            txt = Regex.Replace(txt, "&spades;", "♠");
            txt = Regex.Replace(txt, "&spadesuit;", "♠");

            // "U+02663", "BLACK CLUB SUIT"
            txt = Regex.Replace(txt, "&#x0*?2663;", "♣");
            txt = Regex.Replace(txt, "&#0*?9827;", "♣");
            txt = Regex.Replace(txt, "&clubs;", "♣");
            txt = Regex.Replace(txt, "&clubsuit;", "♣");

            // "U+02665", "BLACK HEART SUIT"
            txt = Regex.Replace(txt, "&#x0*?2665;", "♥");
            txt = Regex.Replace(txt, "&#0*?9829;", "♥");
            txt = Regex.Replace(txt, "&hearts;", "♥");
            txt = Regex.Replace(txt, "&heartsuit;", "♥");

            // "U+02666", "BLACK DIAMOND SUIT"
            txt = Regex.Replace(txt, "&#x0*?2666;", "♦");
            txt = Regex.Replace(txt, "&#0*?9830;", "♦");
            txt = Regex.Replace(txt, "&diams;", "♦");
            txt = Regex.Replace(txt, "&diamondsuit;", "♦");

            // "U+0266A", "EIGHTH NOTE"
            txt = Regex.Replace(txt, "&#x0*?266A;", "♪");
            txt = Regex.Replace(txt, "&#0*?9834;", "♪");
            txt = Regex.Replace(txt, "&sung;", "♪");

            // "U+0266D", "MUSIC FLAT SIGN"
            txt = Regex.Replace(txt, "&#x0*?266D;", "♭");
            txt = Regex.Replace(txt, "&#0*?9837;", "♭");
            txt = Regex.Replace(txt, "&flat;", "♭");

            // "U+0266E", "MUSIC NATURAL SIGN"
            txt = Regex.Replace(txt, "&#x0*?266E;", "♮");
            txt = Regex.Replace(txt, "&#0*?9838;", "♮");
            txt = Regex.Replace(txt, "&natur;", "♮");
            txt = Regex.Replace(txt, "&natural;", "♮");

            // "U+0266F", "MUSIC SHARP SIGN"
            txt = Regex.Replace(txt, "&#x0*?266F;", "♯");
            txt = Regex.Replace(txt, "&#0*?9839;", "♯");
            txt = Regex.Replace(txt, "&sharp;", "♯");

            // "U+02713", "CHECK MARK"
            txt = Regex.Replace(txt, "&#x0*?2713;", "✓");
            txt = Regex.Replace(txt, "&#0*?10003;", "✓");
            txt = Regex.Replace(txt, "&check;", "✓");
            txt = Regex.Replace(txt, "&checkmark;", "✓");

            // "U+02717", "BALLOT X"
            txt = Regex.Replace(txt, "&#x0*?2717;", "✗");
            txt = Regex.Replace(txt, "&#0*?10007;", "✗");
            txt = Regex.Replace(txt, "&cross;", "✗");

            // "U+02720", "MALTESE CROSS"
            txt = Regex.Replace(txt, "&#x0*?2720;", "✠");
            txt = Regex.Replace(txt, "&#0*?10016;", "✠");
            txt = Regex.Replace(txt, "&malt;", "✠");
            txt = Regex.Replace(txt, "&maltese;", "✠");

            // "U+02736", "SIX POINTED BLACK STAR"
            txt = Regex.Replace(txt, "&#x0*?2736;", "✶");
            txt = Regex.Replace(txt, "&#0*?10038;", "✶");
            txt = Regex.Replace(txt, "&sext;", "✶");

            // "U+02758", "LIGHT VERTICAL BAR"
            txt = Regex.Replace(txt, "&#x0*?2758;", "❘");
            txt = Regex.Replace(txt, "&#0*?10072;", "❘");
            txt = Regex.Replace(txt, "&VerticalSeparator;", "❘");

            // "U+02772", "LIGHT LEFT TORTOISE SHELL BRACKET ORNAMENT"
            txt = Regex.Replace(txt, "&#x0*?2772;", "❲");
            txt = Regex.Replace(txt, "&#0*?10098;", "❲");
            txt = Regex.Replace(txt, "&lbbrk;", "❲");

            // "U+02773", "LIGHT RIGHT TORTOISE SHELL BRACKET ORNAMENT"
            txt = Regex.Replace(txt, "&#x0*?2773;", "❳");
            txt = Regex.Replace(txt, "&#0*?10099;", "❳");
            txt = Regex.Replace(txt, "&rbbrk;", "❳");

            // "U+027E6", "MATHEMATICAL LEFT WHITE SQUARE BRACKET"
            txt = Regex.Replace(txt, "&#x0*?27E6;", "⟦");
            txt = Regex.Replace(txt, "&#0*?10214;", "⟦");
            txt = Regex.Replace(txt, "&lobrk;", "⟦");
            txt = Regex.Replace(txt, "&LeftDoubleBracket;", "⟦");

            // "U+027E7", "MATHEMATICAL RIGHT WHITE SQUARE BRACKET"
            txt = Regex.Replace(txt, "&#x0*?27E7;", "⟧");
            txt = Regex.Replace(txt, "&#0*?10215;", "⟧");
            txt = Regex.Replace(txt, "&robrk;", "⟧");
            txt = Regex.Replace(txt, "&RightDoubleBracket;", "⟧");

            // "U+027E8", "MATHEMATICAL LEFT ANGLE BRACKET"
            txt = Regex.Replace(txt, "&#x0*?27E8;", "⟨");
            txt = Regex.Replace(txt, "&#0*?10216;", "⟨");
            txt = Regex.Replace(txt, "&lang;", "⟨");
            txt = Regex.Replace(txt, "&LeftAngleBracket;", "⟨");
            txt = Regex.Replace(txt, "&langle;", "⟨");

            // "U+027E9", "MATHEMATICAL RIGHT ANGLE BRACKET"
            txt = Regex.Replace(txt, "&#x0*?27E9;", "⟩");
            txt = Regex.Replace(txt, "&#0*?10217;", "⟩");
            txt = Regex.Replace(txt, "&rang;", "⟩");
            txt = Regex.Replace(txt, "&RightAngleBracket;", "⟩");
            txt = Regex.Replace(txt, "&rangle;", "⟩");

            // "U+027EA", "MATHEMATICAL LEFT DOUBLE ANGLE BRACKET"
            txt = Regex.Replace(txt, "&#x0*?27EA;", "⟪");
            txt = Regex.Replace(txt, "&#0*?10218;", "⟪");
            txt = Regex.Replace(txt, "&Lang;", "⟪");

            // "U+027EB", "MATHEMATICAL RIGHT DOUBLE ANGLE BRACKET"
            txt = Regex.Replace(txt, "&#x0*?27EB;", "⟫");
            txt = Regex.Replace(txt, "&#0*?10219;", "⟫");
            txt = Regex.Replace(txt, "&Rang;", "⟫");

            // "U+027EC", "MATHEMATICAL LEFT WHITE TORTOISE SHELL BRACKET"
            txt = Regex.Replace(txt, "&#x0*?27EC;", "⟬");
            txt = Regex.Replace(txt, "&#0*?10220;", "⟬");
            txt = Regex.Replace(txt, "&loang;", "⟬");

            // "U+027ED", "MATHEMATICAL RIGHT WHITE TORTOISE SHELL BRACKET"
            txt = Regex.Replace(txt, "&#x0*?27ED;", "⟭");
            txt = Regex.Replace(txt, "&#0*?10221;", "⟭");
            txt = Regex.Replace(txt, "&roang;", "⟭");

            // "U+027F5", "LONG LEFTWARDS ARROW"
            txt = Regex.Replace(txt, "&#x0*?27F5;", "⟵");
            txt = Regex.Replace(txt, "&#0*?10229;", "⟵");
            txt = Regex.Replace(txt, "&xlarr;", "⟵");
            txt = Regex.Replace(txt, "&longleftarrow;", "⟵");
            txt = Regex.Replace(txt, "&LongLeftArrow;", "⟵");

            // "U+027F6", "LONG RIGHTWARDS ARROW"
            txt = Regex.Replace(txt, "&#x0*?27F6;", "⟶");
            txt = Regex.Replace(txt, "&#0*?10230;", "⟶");
            txt = Regex.Replace(txt, "&xrarr;", "⟶");
            txt = Regex.Replace(txt, "&longrightarrow;", "⟶");
            txt = Regex.Replace(txt, "&LongRightArrow;", "⟶");

            // "U+027F7", "LONG LEFT RIGHT ARROW"
            txt = Regex.Replace(txt, "&#x0*?27F7;", "⟷");
            txt = Regex.Replace(txt, "&#0*?10231;", "⟷");
            txt = Regex.Replace(txt, "&xharr;", "⟷");
            txt = Regex.Replace(txt, "&longleftrightarrow;", "⟷");
            txt = Regex.Replace(txt, "&LongLeftRightArrow;", "⟷");

            // "U+027F8", "LONG LEFTWARDS DOUBLE ARROW"
            txt = Regex.Replace(txt, "&#x0*?27F8;", "⟸");
            txt = Regex.Replace(txt, "&#0*?10232;", "⟸");
            txt = Regex.Replace(txt, "&xlArr;", "⟸");
            txt = Regex.Replace(txt, "&Longleftarrow;", "⟸");
            txt = Regex.Replace(txt, "&DoubleLongLeftArrow;", "⟸");

            // "U+027F9", "LONG RIGHTWARDS DOUBLE ARROW"
            txt = Regex.Replace(txt, "&#x0*?27F9;", "⟹");
            txt = Regex.Replace(txt, "&#0*?10233;", "⟹");
            txt = Regex.Replace(txt, "&xrArr;", "⟹");
            txt = Regex.Replace(txt, "&Longrightarrow;", "⟹");
            txt = Regex.Replace(txt, "&DoubleLongRightArrow;", "⟹");

            // "U+027FA", "LONG LEFT RIGHT DOUBLE ARROW"
            txt = Regex.Replace(txt, "&#x0*?27FA;", "⟺");
            txt = Regex.Replace(txt, "&#0*?10234;", "⟺");
            txt = Regex.Replace(txt, "&xhArr;", "⟺");
            txt = Regex.Replace(txt, "&Longleftrightarrow;", "⟺");
            txt = Regex.Replace(txt, "&DoubleLongLeftRightArrow;", "⟺");

            // "U+027FC", "LONG RIGHTWARDS ARROW FROM BAR"
            txt = Regex.Replace(txt, "&#x0*?27FC;", "⟼");
            txt = Regex.Replace(txt, "&#0*?10236;", "⟼");
            txt = Regex.Replace(txt, "&xmap;", "⟼");
            txt = Regex.Replace(txt, "&longmapsto;", "⟼");

            // "U+027FF", "LONG RIGHTWARDS SQUIGGLE ARROW"
            txt = Regex.Replace(txt, "&#x0*?27FF;", "⟿");
            txt = Regex.Replace(txt, "&#0*?10239;", "⟿");
            txt = Regex.Replace(txt, "&dzigrarr;", "⟿");

            // "U+02902", "LEFTWARDS DOUBLE ARROW WITH VERTICAL STROKE"
            txt = Regex.Replace(txt, "&#x0*?2902;", "⤂");
            txt = Regex.Replace(txt, "&#0*?10498;", "⤂");
            txt = Regex.Replace(txt, "&nvlArr;", "⤂");

            // "U+02903", "RIGHTWARDS DOUBLE ARROW WITH VERTICAL STROKE"
            txt = Regex.Replace(txt, "&#x0*?2903;", "⤃");
            txt = Regex.Replace(txt, "&#0*?10499;", "⤃");
            txt = Regex.Replace(txt, "&nvrArr;", "⤃");

            // "U+02904", "LEFT RIGHT DOUBLE ARROW WITH VERTICAL STROKE"
            txt = Regex.Replace(txt, "&#x0*?2904;", "⤄");
            txt = Regex.Replace(txt, "&#0*?10500;", "⤄");
            txt = Regex.Replace(txt, "&nvHarr;", "⤄");

            // "U+02905", "RIGHTWARDS TWO-HEADED ARROW FROM BAR"
            txt = Regex.Replace(txt, "&#x0*?2905;", "⤅");
            txt = Regex.Replace(txt, "&#0*?10501;", "⤅");
            txt = Regex.Replace(txt, "&Map;", "⤅");

            // "U+0290C", "LEFTWARDS DOUBLE DASH ARROW"
            txt = Regex.Replace(txt, "&#x0*?290C;", "⤌");
            txt = Regex.Replace(txt, "&#0*?10508;", "⤌");
            txt = Regex.Replace(txt, "&lbarr;", "⤌");

            // "U+0290D", "RIGHTWARDS DOUBLE DASH ARROW"
            txt = Regex.Replace(txt, "&#x0*?290D;", "⤍");
            txt = Regex.Replace(txt, "&#0*?10509;", "⤍");
            txt = Regex.Replace(txt, "&rbarr;", "⤍");
            txt = Regex.Replace(txt, "&bkarow;", "⤍");

            // "U+0290E", "LEFTWARDS TRIPLE DASH ARROW"
            txt = Regex.Replace(txt, "&#x0*?290E;", "⤎");
            txt = Regex.Replace(txt, "&#0*?10510;", "⤎");
            txt = Regex.Replace(txt, "&lBarr;", "⤎");

            // "U+0290F", "RIGHTWARDS TRIPLE DASH ARROW"
            txt = Regex.Replace(txt, "&#x0*?290F;", "⤏");
            txt = Regex.Replace(txt, "&#0*?10511;", "⤏");
            txt = Regex.Replace(txt, "&rBarr;", "⤏");
            txt = Regex.Replace(txt, "&dbkarow;", "⤏");

            // "U+02910", "RIGHTWARDS TWO-HEADED TRIPLE DASH ARROW"
            txt = Regex.Replace(txt, "&#x0*?2910;", "⤐");
            txt = Regex.Replace(txt, "&#0*?10512;", "⤐");
            txt = Regex.Replace(txt, "&RBarr;", "⤐");
            txt = Regex.Replace(txt, "&drbkarow;", "⤐");

            // "U+02911", "RIGHTWARDS ARROW WITH DOTTED STEM"
            txt = Regex.Replace(txt, "&#x0*?2911;", "⤑");
            txt = Regex.Replace(txt, "&#0*?10513;", "⤑");
            txt = Regex.Replace(txt, "&DDotrahd;", "⤑");

            // "U+02912", "UPWARDS ARROW TO BAR"
            txt = Regex.Replace(txt, "&#x0*?2912;", "⤒");
            txt = Regex.Replace(txt, "&#0*?10514;", "⤒");
            txt = Regex.Replace(txt, "&UpArrowBar;", "⤒");

            // "U+02913", "DOWNWARDS ARROW TO BAR"
            txt = Regex.Replace(txt, "&#x0*?2913;", "⤓");
            txt = Regex.Replace(txt, "&#0*?10515;", "⤓");
            txt = Regex.Replace(txt, "&DownArrowBar;", "⤓");

            // "U+02916", "RIGHTWARDS TWO-HEADED ARROW WITH TAIL"
            txt = Regex.Replace(txt, "&#x0*?2916;", "⤖");
            txt = Regex.Replace(txt, "&#0*?10518;", "⤖");
            txt = Regex.Replace(txt, "&Rarrtl;", "⤖");

            // "U+02919", "LEFTWARDS ARROW-TAIL"
            txt = Regex.Replace(txt, "&#x0*?2919;", "⤙");
            txt = Regex.Replace(txt, "&#0*?10521;", "⤙");
            txt = Regex.Replace(txt, "&latail;", "⤙");

            // "U+0291A", "RIGHTWARDS ARROW-TAIL"
            txt = Regex.Replace(txt, "&#x0*?291A;", "⤚");
            txt = Regex.Replace(txt, "&#0*?10522;", "⤚");
            txt = Regex.Replace(txt, "&ratail;", "⤚");

            // "U+0291B", "LEFTWARDS DOUBLE ARROW-TAIL"
            txt = Regex.Replace(txt, "&#x0*?291B;", "⤛");
            txt = Regex.Replace(txt, "&#0*?10523;", "⤛");
            txt = Regex.Replace(txt, "&lAtail;", "⤛");

            // "U+0291C", "RIGHTWARDS DOUBLE ARROW-TAIL"
            txt = Regex.Replace(txt, "&#x0*?291C;", "⤜");
            txt = Regex.Replace(txt, "&#0*?10524;", "⤜");
            txt = Regex.Replace(txt, "&rAtail;", "⤜");

            // "U+0291D", "LEFTWARDS ARROW TO BLACK DIAMOND"
            txt = Regex.Replace(txt, "&#x0*?291D;", "⤝");
            txt = Regex.Replace(txt, "&#0*?10525;", "⤝");
            txt = Regex.Replace(txt, "&larrfs;", "⤝");

            // "U+0291E", "RIGHTWARDS ARROW TO BLACK DIAMOND"
            txt = Regex.Replace(txt, "&#x0*?291E;", "⤞");
            txt = Regex.Replace(txt, "&#0*?10526;", "⤞");
            txt = Regex.Replace(txt, "&rarrfs;", "⤞");

            // "U+0291F", "LEFTWARDS ARROW FROM BAR TO BLACK DIAMOND"
            txt = Regex.Replace(txt, "&#x0*?291F;", "⤟");
            txt = Regex.Replace(txt, "&#0*?10527;", "⤟");
            txt = Regex.Replace(txt, "&larrbfs;", "⤟");

            // "U+02920", "RIGHTWARDS ARROW FROM BAR TO BLACK DIAMOND"
            txt = Regex.Replace(txt, "&#x0*?2920;", "⤠");
            txt = Regex.Replace(txt, "&#0*?10528;", "⤠");
            txt = Regex.Replace(txt, "&rarrbfs;", "⤠");

            // "U+02923", "NORTH WEST ARROW WITH HOOK"
            txt = Regex.Replace(txt, "&#x0*?2923;", "⤣");
            txt = Regex.Replace(txt, "&#0*?10531;", "⤣");
            txt = Regex.Replace(txt, "&nwarhk;", "⤣");

            // "U+02924", "NORTH EAST ARROW WITH HOOK"
            txt = Regex.Replace(txt, "&#x0*?2924;", "⤤");
            txt = Regex.Replace(txt, "&#0*?10532;", "⤤");
            txt = Regex.Replace(txt, "&nearhk;", "⤤");

            // "U+02925", "SOUTH EAST ARROW WITH HOOK"
            txt = Regex.Replace(txt, "&#x0*?2925;", "⤥");
            txt = Regex.Replace(txt, "&#0*?10533;", "⤥");
            txt = Regex.Replace(txt, "&searhk;", "⤥");
            txt = Regex.Replace(txt, "&hksearow;", "⤥");

            // "U+02926", "SOUTH WEST ARROW WITH HOOK"
            txt = Regex.Replace(txt, "&#x0*?2926;", "⤦");
            txt = Regex.Replace(txt, "&#0*?10534;", "⤦");
            txt = Regex.Replace(txt, "&swarhk;", "⤦");
            txt = Regex.Replace(txt, "&hkswarow;", "⤦");

            // "U+02927", "NORTH WEST ARROW AND NORTH EAST ARROW"
            txt = Regex.Replace(txt, "&#x0*?2927;", "⤧");
            txt = Regex.Replace(txt, "&#0*?10535;", "⤧");
            txt = Regex.Replace(txt, "&nwnear;", "⤧");

            // "U+02928", "NORTH EAST ARROW AND SOUTH EAST ARROW"
            txt = Regex.Replace(txt, "&#x0*?2928;", "⤨");
            txt = Regex.Replace(txt, "&#0*?10536;", "⤨");
            txt = Regex.Replace(txt, "&nesear;", "⤨");
            txt = Regex.Replace(txt, "&toea;", "⤨");

            // "U+02929", "SOUTH EAST ARROW AND SOUTH WEST ARROW"
            txt = Regex.Replace(txt, "&#x0*?2929;", "⤩");
            txt = Regex.Replace(txt, "&#0*?10537;", "⤩");
            txt = Regex.Replace(txt, "&seswar;", "⤩");
            txt = Regex.Replace(txt, "&tosa;", "⤩");

            // "U+0292A", "SOUTH WEST ARROW AND NORTH WEST ARROW"
            txt = Regex.Replace(txt, "&#x0*?292A;", "⤪");
            txt = Regex.Replace(txt, "&#0*?10538;", "⤪");
            txt = Regex.Replace(txt, "&swnwar;", "⤪");

            // "U+02933", "WAVE ARROW POINTING DIRECTLY RIGHT"
            txt = Regex.Replace(txt, "&#x0*?2933;", "⤳");
            txt = Regex.Replace(txt, "&#0*?10547;", "⤳");
            txt = Regex.Replace(txt, "&rarrc;", "⤳");

            // "U+02935", "ARROW POINTING RIGHTWARDS THEN CURVING DOWNWARDS"
            txt = Regex.Replace(txt, "&#x0*?2935;", "⤵");
            txt = Regex.Replace(txt, "&#0*?10549;", "⤵");
            txt = Regex.Replace(txt, "&cudarrr;", "⤵");

            // "U+02936", "ARROW POINTING DOWNWARDS THEN CURVING LEFTWARDS"
            txt = Regex.Replace(txt, "&#x0*?2936;", "⤶");
            txt = Regex.Replace(txt, "&#0*?10550;", "⤶");
            txt = Regex.Replace(txt, "&ldca;", "⤶");

            // "U+02937", "ARROW POINTING DOWNWARDS THEN CURVING RIGHTWARDS"
            txt = Regex.Replace(txt, "&#x0*?2937;", "⤷");
            txt = Regex.Replace(txt, "&#0*?10551;", "⤷");
            txt = Regex.Replace(txt, "&rdca;", "⤷");

            // "U+02938", "RIGHT-SIDE ARC CLOCKWISE ARROW"
            txt = Regex.Replace(txt, "&#x0*?2938;", "⤸");
            txt = Regex.Replace(txt, "&#0*?10552;", "⤸");
            txt = Regex.Replace(txt, "&cudarrl;", "⤸");

            // "U+02939", "LEFT-SIDE ARC ANTICLOCKWISE ARROW"
            txt = Regex.Replace(txt, "&#x0*?2939;", "⤹");
            txt = Regex.Replace(txt, "&#0*?10553;", "⤹");
            txt = Regex.Replace(txt, "&larrpl;", "⤹");

            // "U+0293C", "TOP ARC CLOCKWISE ARROW WITH MINUS"
            txt = Regex.Replace(txt, "&#x0*?293C;", "⤼");
            txt = Regex.Replace(txt, "&#0*?10556;", "⤼");
            txt = Regex.Replace(txt, "&curarrm;", "⤼");

            // "U+0293D", "TOP ARC ANTICLOCKWISE ARROW WITH PLUS"
            txt = Regex.Replace(txt, "&#x0*?293D;", "⤽");
            txt = Regex.Replace(txt, "&#0*?10557;", "⤽");
            txt = Regex.Replace(txt, "&cularrp;", "⤽");

            // "U+02945", "RIGHTWARDS ARROW WITH PLUS BELOW"
            txt = Regex.Replace(txt, "&#x0*?2945;", "⥅");
            txt = Regex.Replace(txt, "&#0*?10565;", "⥅");
            txt = Regex.Replace(txt, "&rarrpl;", "⥅");

            // "U+02948", "LEFT RIGHT ARROW THROUGH SMALL CIRCLE"
            txt = Regex.Replace(txt, "&#x0*?2948;", "⥈");
            txt = Regex.Replace(txt, "&#0*?10568;", "⥈");
            txt = Regex.Replace(txt, "&harrcir;", "⥈");

            // "U+02949", "UPWARDS TWO-HEADED ARROW FROM SMALL CIRCLE"
            txt = Regex.Replace(txt, "&#x0*?2949;", "⥉");
            txt = Regex.Replace(txt, "&#0*?10569;", "⥉");
            txt = Regex.Replace(txt, "&Uarrocir;", "⥉");

            // "U+0294A", "LEFT BARB UP RIGHT BARB DOWN HARPOON"
            txt = Regex.Replace(txt, "&#x0*?294A;", "⥊");
            txt = Regex.Replace(txt, "&#0*?10570;", "⥊");
            txt = Regex.Replace(txt, "&lurdshar;", "⥊");

            // "U+0294B", "LEFT BARB DOWN RIGHT BARB UP HARPOON"
            txt = Regex.Replace(txt, "&#x0*?294B;", "⥋");
            txt = Regex.Replace(txt, "&#0*?10571;", "⥋");
            txt = Regex.Replace(txt, "&ldrushar;", "⥋");

            // "U+0294E", "LEFT BARB UP RIGHT BARB UP HARPOON"
            txt = Regex.Replace(txt, "&#x0*?294E;", "⥎");
            txt = Regex.Replace(txt, "&#0*?10574;", "⥎");
            txt = Regex.Replace(txt, "&LeftRightVector;", "⥎");

            // "U+0294F", "UP BARB RIGHT DOWN BARB RIGHT HARPOON"
            txt = Regex.Replace(txt, "&#x0*?294F;", "⥏");
            txt = Regex.Replace(txt, "&#0*?10575;", "⥏");
            txt = Regex.Replace(txt, "&RightUpDownVector;", "⥏");

            // "U+02950", "LEFT BARB DOWN RIGHT BARB DOWN HARPOON"
            txt = Regex.Replace(txt, "&#x0*?2950;", "⥐");
            txt = Regex.Replace(txt, "&#0*?10576;", "⥐");
            txt = Regex.Replace(txt, "&DownLeftRightVector;", "⥐");

            // "U+02951", "UP BARB LEFT DOWN BARB LEFT HARPOON"
            txt = Regex.Replace(txt, "&#x0*?2951;", "⥑");
            txt = Regex.Replace(txt, "&#0*?10577;", "⥑");
            txt = Regex.Replace(txt, "&LeftUpDownVector;", "⥑");

            // "U+02952", "LEFTWARDS HARPOON WITH BARB UP TO BAR"
            txt = Regex.Replace(txt, "&#x0*?2952;", "⥒");
            txt = Regex.Replace(txt, "&#0*?10578;", "⥒");
            txt = Regex.Replace(txt, "&LeftVectorBar;", "⥒");

            // "U+02953", "RIGHTWARDS HARPOON WITH BARB UP TO BAR"
            txt = Regex.Replace(txt, "&#x0*?2953;", "⥓");
            txt = Regex.Replace(txt, "&#0*?10579;", "⥓");
            txt = Regex.Replace(txt, "&RightVectorBar;", "⥓");

            // "U+02954", "UPWARDS HARPOON WITH BARB RIGHT TO BAR"
            txt = Regex.Replace(txt, "&#x0*?2954;", "⥔");
            txt = Regex.Replace(txt, "&#0*?10580;", "⥔");
            txt = Regex.Replace(txt, "&RightUpVectorBar;", "⥔");

            // "U+02955", "DOWNWARDS HARPOON WITH BARB RIGHT TO BAR"
            txt = Regex.Replace(txt, "&#x0*?2955;", "⥕");
            txt = Regex.Replace(txt, "&#0*?10581;", "⥕");
            txt = Regex.Replace(txt, "&RightDownVectorBar;", "⥕");

            // "U+02956", "LEFTWARDS HARPOON WITH BARB DOWN TO BAR"
            txt = Regex.Replace(txt, "&#x0*?2956;", "⥖");
            txt = Regex.Replace(txt, "&#0*?10582;", "⥖");
            txt = Regex.Replace(txt, "&DownLeftVectorBar;", "⥖");

            // "U+02957", "RIGHTWARDS HARPOON WITH BARB DOWN TO BAR"
            txt = Regex.Replace(txt, "&#x0*?2957;", "⥗");
            txt = Regex.Replace(txt, "&#0*?10583;", "⥗");
            txt = Regex.Replace(txt, "&DownRightVectorBar;", "⥗");

            // "U+02958", "UPWARDS HARPOON WITH BARB LEFT TO BAR"
            txt = Regex.Replace(txt, "&#x0*?2958;", "⥘");
            txt = Regex.Replace(txt, "&#0*?10584;", "⥘");
            txt = Regex.Replace(txt, "&LeftUpVectorBar;", "⥘");

            // "U+02959", "DOWNWARDS HARPOON WITH BARB LEFT TO BAR"
            txt = Regex.Replace(txt, "&#x0*?2959;", "⥙");
            txt = Regex.Replace(txt, "&#0*?10585;", "⥙");
            txt = Regex.Replace(txt, "&LeftDownVectorBar;", "⥙");

            // "U+0295A", "LEFTWARDS HARPOON WITH BARB UP FROM BAR"
            txt = Regex.Replace(txt, "&#x0*?295A;", "⥚");
            txt = Regex.Replace(txt, "&#0*?10586;", "⥚");
            txt = Regex.Replace(txt, "&LeftTeeVector;", "⥚");

            // "U+0295B", "RIGHTWARDS HARPOON WITH BARB UP FROM BAR"
            txt = Regex.Replace(txt, "&#x0*?295B;", "⥛");
            txt = Regex.Replace(txt, "&#0*?10587;", "⥛");
            txt = Regex.Replace(txt, "&RightTeeVector;", "⥛");

            // "U+0295C", "UPWARDS HARPOON WITH BARB RIGHT FROM BAR"
            txt = Regex.Replace(txt, "&#x0*?295C;", "⥜");
            txt = Regex.Replace(txt, "&#0*?10588;", "⥜");
            txt = Regex.Replace(txt, "&RightUpTeeVector;", "⥜");

            // "U+0295D", "DOWNWARDS HARPOON WITH BARB RIGHT FROM BAR"
            txt = Regex.Replace(txt, "&#x0*?295D;", "⥝");
            txt = Regex.Replace(txt, "&#0*?10589;", "⥝");
            txt = Regex.Replace(txt, "&RightDownTeeVector;", "⥝");

            // "U+0295E", "LEFTWARDS HARPOON WITH BARB DOWN FROM BAR"
            txt = Regex.Replace(txt, "&#x0*?295E;", "⥞");
            txt = Regex.Replace(txt, "&#0*?10590;", "⥞");
            txt = Regex.Replace(txt, "&DownLeftTeeVector;", "⥞");

            // "U+0295F", "RIGHTWARDS HARPOON WITH BARB DOWN FROM BAR"
            txt = Regex.Replace(txt, "&#x0*?295F;", "⥟");
            txt = Regex.Replace(txt, "&#0*?10591;", "⥟");
            txt = Regex.Replace(txt, "&DownRightTeeVector;", "⥟");

            // "U+02960", "UPWARDS HARPOON WITH BARB LEFT FROM BAR"
            txt = Regex.Replace(txt, "&#x0*?2960;", "⥠");
            txt = Regex.Replace(txt, "&#0*?10592;", "⥠");
            txt = Regex.Replace(txt, "&LeftUpTeeVector;", "⥠");

            // "U+02961", "DOWNWARDS HARPOON WITH BARB LEFT FROM BAR"
            txt = Regex.Replace(txt, "&#x0*?2961;", "⥡");
            txt = Regex.Replace(txt, "&#0*?10593;", "⥡");
            txt = Regex.Replace(txt, "&LeftDownTeeVector;", "⥡");

            // "U+02962", "LEFTWARDS HARPOON WITH BARB UP ABOVE LEFTWARDS HARPOON WITH BARB DOWN"
            txt = Regex.Replace(txt, "&#x0*?2962;", "⥢");
            txt = Regex.Replace(txt, "&#0*?10594;", "⥢");
            txt = Regex.Replace(txt, "&lHar;", "⥢");

            // "U+02963", "UPWARDS HARPOON WITH BARB LEFT BESIDE UPWARDS HARPOON WITH BARB RIGHT"
            txt = Regex.Replace(txt, "&#x0*?2963;", "⥣");
            txt = Regex.Replace(txt, "&#0*?10595;", "⥣");
            txt = Regex.Replace(txt, "&uHar;", "⥣");

            // "U+02964", "RIGHTWARDS HARPOON WITH BARB UP ABOVE RIGHTWARDS HARPOON WITH BARB DOWN"
            txt = Regex.Replace(txt, "&#x0*?2964;", "⥤");
            txt = Regex.Replace(txt, "&#0*?10596;", "⥤");
            txt = Regex.Replace(txt, "&rHar;", "⥤");

            // "U+02965", "DOWNWARDS HARPOON WITH BARB LEFT BESIDE DOWNWARDS HARPOON WITH BARB RIGHT"
            txt = Regex.Replace(txt, "&#x0*?2965;", "⥥");
            txt = Regex.Replace(txt, "&#0*?10597;", "⥥");
            txt = Regex.Replace(txt, "&dHar;", "⥥");

            // "U+02966", "LEFTWARDS HARPOON WITH BARB UP ABOVE RIGHTWARDS HARPOON WITH BARB UP"
            txt = Regex.Replace(txt, "&#x0*?2966;", "⥦");
            txt = Regex.Replace(txt, "&#0*?10598;", "⥦");
            txt = Regex.Replace(txt, "&luruhar;", "⥦");

            // "U+02967", "LEFTWARDS HARPOON WITH BARB DOWN ABOVE RIGHTWARDS HARPOON WITH BARB DOWN"
            txt = Regex.Replace(txt, "&#x0*?2967;", "⥧");
            txt = Regex.Replace(txt, "&#0*?10599;", "⥧");
            txt = Regex.Replace(txt, "&ldrdhar;", "⥧");

            // "U+02968", "RIGHTWARDS HARPOON WITH BARB UP ABOVE LEFTWARDS HARPOON WITH BARB UP"
            txt = Regex.Replace(txt, "&#x0*?2968;", "⥨");
            txt = Regex.Replace(txt, "&#0*?10600;", "⥨");
            txt = Regex.Replace(txt, "&ruluhar;", "⥨");

            // "U+02969", "RIGHTWARDS HARPOON WITH BARB DOWN ABOVE LEFTWARDS HARPOON WITH BARB DOWN"
            txt = Regex.Replace(txt, "&#x0*?2969;", "⥩");
            txt = Regex.Replace(txt, "&#0*?10601;", "⥩");
            txt = Regex.Replace(txt, "&rdldhar;", "⥩");

            // "U+0296A", "LEFTWARDS HARPOON WITH BARB UP ABOVE LONG DASH"
            txt = Regex.Replace(txt, "&#x0*?296A;", "⥪");
            txt = Regex.Replace(txt, "&#0*?10602;", "⥪");
            txt = Regex.Replace(txt, "&lharul;", "⥪");

            // "U+0296B", "LEFTWARDS HARPOON WITH BARB DOWN BELOW LONG DASH"
            txt = Regex.Replace(txt, "&#x0*?296B;", "⥫");
            txt = Regex.Replace(txt, "&#0*?10603;", "⥫");
            txt = Regex.Replace(txt, "&llhard;", "⥫");

            // "U+0296C", "RIGHTWARDS HARPOON WITH BARB UP ABOVE LONG DASH"
            txt = Regex.Replace(txt, "&#x0*?296C;", "⥬");
            txt = Regex.Replace(txt, "&#0*?10604;", "⥬");
            txt = Regex.Replace(txt, "&rharul;", "⥬");

            // "U+0296D", "RIGHTWARDS HARPOON WITH BARB DOWN BELOW LONG DASH"
            txt = Regex.Replace(txt, "&#x0*?296D;", "⥭");
            txt = Regex.Replace(txt, "&#0*?10605;", "⥭");
            txt = Regex.Replace(txt, "&lrhard;", "⥭");

            // "U+0296E", "UPWARDS HARPOON WITH BARB LEFT BESIDE DOWNWARDS HARPOON WITH BARB RIGHT"
            txt = Regex.Replace(txt, "&#x0*?296E;", "⥮");
            txt = Regex.Replace(txt, "&#0*?10606;", "⥮");
            txt = Regex.Replace(txt, "&udhar;", "⥮");
            txt = Regex.Replace(txt, "&UpEquilibrium;", "⥮");

            // "U+0296F", "DOWNWARDS HARPOON WITH BARB LEFT BESIDE UPWARDS HARPOON WITH BARB RIGHT"
            txt = Regex.Replace(txt, "&#x0*?296F;", "⥯");
            txt = Regex.Replace(txt, "&#0*?10607;", "⥯");
            txt = Regex.Replace(txt, "&duhar;", "⥯");
            txt = Regex.Replace(txt, "&ReverseUpEquilibrium;", "⥯");

            // "U+02970", "RIGHT DOUBLE ARROW WITH ROUNDED HEAD"
            txt = Regex.Replace(txt, "&#x0*?2970;", "⥰");
            txt = Regex.Replace(txt, "&#0*?10608;", "⥰");
            txt = Regex.Replace(txt, "&RoundImplies;", "⥰");

            // "U+02971", "EQUALS SIGN ABOVE RIGHTWARDS ARROW"
            txt = Regex.Replace(txt, "&#x0*?2971;", "⥱");
            txt = Regex.Replace(txt, "&#0*?10609;", "⥱");
            txt = Regex.Replace(txt, "&erarr;", "⥱");

            // "U+02972", "TILDE OPERATOR ABOVE RIGHTWARDS ARROW"
            txt = Regex.Replace(txt, "&#x0*?2972;", "⥲");
            txt = Regex.Replace(txt, "&#0*?10610;", "⥲");
            txt = Regex.Replace(txt, "&simrarr;", "⥲");

            // "U+02973", "LEFTWARDS ARROW ABOVE TILDE OPERATOR"
            txt = Regex.Replace(txt, "&#x0*?2973;", "⥳");
            txt = Regex.Replace(txt, "&#0*?10611;", "⥳");
            txt = Regex.Replace(txt, "&larrsim;", "⥳");

            // "U+02974", "RIGHTWARDS ARROW ABOVE TILDE OPERATOR"
            txt = Regex.Replace(txt, "&#x0*?2974;", "⥴");
            txt = Regex.Replace(txt, "&#0*?10612;", "⥴");
            txt = Regex.Replace(txt, "&rarrsim;", "⥴");

            // "U+02975", "RIGHTWARDS ARROW ABOVE ALMOST EQUAL TO"
            txt = Regex.Replace(txt, "&#x0*?2975;", "⥵");
            txt = Regex.Replace(txt, "&#0*?10613;", "⥵");
            txt = Regex.Replace(txt, "&rarrap;", "⥵");

            // "U+02976", "LESS-THAN ABOVE LEFTWARDS ARROW"
            txt = Regex.Replace(txt, "&#x0*?2976;", "⥶");
            txt = Regex.Replace(txt, "&#0*?10614;", "⥶");
            txt = Regex.Replace(txt, "&ltlarr;", "⥶");

            // "U+02978", "GREATER-THAN ABOVE RIGHTWARDS ARROW"
            txt = Regex.Replace(txt, "&#x0*?2978;", "⥸");
            txt = Regex.Replace(txt, "&#0*?10616;", "⥸");
            txt = Regex.Replace(txt, "&gtrarr;", "⥸");

            // "U+02979", "SUBSET ABOVE RIGHTWARDS ARROW"
            txt = Regex.Replace(txt, "&#x0*?2979;", "⥹");
            txt = Regex.Replace(txt, "&#0*?10617;", "⥹");
            txt = Regex.Replace(txt, "&subrarr;", "⥹");

            // "U+0297B", "SUPERSET ABOVE LEFTWARDS ARROW"
            txt = Regex.Replace(txt, "&#x0*?297B;", "⥻");
            txt = Regex.Replace(txt, "&#0*?10619;", "⥻");
            txt = Regex.Replace(txt, "&suplarr;", "⥻");

            // "U+0297C", "LEFT FISH TAIL"
            txt = Regex.Replace(txt, "&#x0*?297C;", "⥼");
            txt = Regex.Replace(txt, "&#0*?10620;", "⥼");
            txt = Regex.Replace(txt, "&lfisht;", "⥼");

            // "U+0297D", "RIGHT FISH TAIL"
            txt = Regex.Replace(txt, "&#x0*?297D;", "⥽");
            txt = Regex.Replace(txt, "&#0*?10621;", "⥽");
            txt = Regex.Replace(txt, "&rfisht;", "⥽");

            // "U+0297E", "UP FISH TAIL"
            txt = Regex.Replace(txt, "&#x0*?297E;", "⥾");
            txt = Regex.Replace(txt, "&#0*?10622;", "⥾");
            txt = Regex.Replace(txt, "&ufisht;", "⥾");

            // "U+0297F", "DOWN FISH TAIL"
            txt = Regex.Replace(txt, "&#x0*?297F;", "⥿");
            txt = Regex.Replace(txt, "&#0*?10623;", "⥿");
            txt = Regex.Replace(txt, "&dfisht;", "⥿");

            // "U+02985", "LEFT WHITE PARENTHESIS"
            txt = Regex.Replace(txt, "&#x0*?2985;", "⦅");
            txt = Regex.Replace(txt, "&#0*?10629;", "⦅");
            txt = Regex.Replace(txt, "&lopar;", "⦅");

            // "U+02986", "RIGHT WHITE PARENTHESIS"
            txt = Regex.Replace(txt, "&#x0*?2986;", "⦆");
            txt = Regex.Replace(txt, "&#0*?10630;", "⦆");
            txt = Regex.Replace(txt, "&ropar;", "⦆");

            // "U+0298B", "LEFT SQUARE BRACKET WITH UNDERBAR"
            txt = Regex.Replace(txt, "&#x0*?298B;", "⦋");
            txt = Regex.Replace(txt, "&#0*?10635;", "⦋");
            txt = Regex.Replace(txt, "&lbrke;", "⦋");

            // "U+0298C", "RIGHT SQUARE BRACKET WITH UNDERBAR"
            txt = Regex.Replace(txt, "&#x0*?298C;", "⦌");
            txt = Regex.Replace(txt, "&#0*?10636;", "⦌");
            txt = Regex.Replace(txt, "&rbrke;", "⦌");

            // "U+0298D", "LEFT SQUARE BRACKET WITH TICK IN TOP CORNER"
            txt = Regex.Replace(txt, "&#x0*?298D;", "⦍");
            txt = Regex.Replace(txt, "&#0*?10637;", "⦍");
            txt = Regex.Replace(txt, "&lbrkslu;", "⦍");

            // "U+0298E", "RIGHT SQUARE BRACKET WITH TICK IN BOTTOM CORNER"
            txt = Regex.Replace(txt, "&#x0*?298E;", "⦎");
            txt = Regex.Replace(txt, "&#0*?10638;", "⦎");
            txt = Regex.Replace(txt, "&rbrksld;", "⦎");

            // "U+0298F", "LEFT SQUARE BRACKET WITH TICK IN BOTTOM CORNER"
            txt = Regex.Replace(txt, "&#x0*?298F;", "⦏");
            txt = Regex.Replace(txt, "&#0*?10639;", "⦏");
            txt = Regex.Replace(txt, "&lbrksld;", "⦏");

            // "U+02990", "RIGHT SQUARE BRACKET WITH TICK IN TOP CORNER"
            txt = Regex.Replace(txt, "&#x0*?2990;", "⦐");
            txt = Regex.Replace(txt, "&#0*?10640;", "⦐");
            txt = Regex.Replace(txt, "&rbrkslu;", "⦐");

            // "U+02991", "LEFT ANGLE BRACKET WITH DOT"
            txt = Regex.Replace(txt, "&#x0*?2991;", "⦑");
            txt = Regex.Replace(txt, "&#0*?10641;", "⦑");
            txt = Regex.Replace(txt, "&langd;", "⦑");

            // "U+02992", "RIGHT ANGLE BRACKET WITH DOT"
            txt = Regex.Replace(txt, "&#x0*?2992;", "⦒");
            txt = Regex.Replace(txt, "&#0*?10642;", "⦒");
            txt = Regex.Replace(txt, "&rangd;", "⦒");

            // "U+02993", "LEFT ARC LESS-THAN BRACKET"
            txt = Regex.Replace(txt, "&#x0*?2993;", "⦓");
            txt = Regex.Replace(txt, "&#0*?10643;", "⦓");
            txt = Regex.Replace(txt, "&lparlt;", "⦓");

            // "U+02994", "RIGHT ARC GREATER-THAN BRACKET"
            txt = Regex.Replace(txt, "&#x0*?2994;", "⦔");
            txt = Regex.Replace(txt, "&#0*?10644;", "⦔");
            txt = Regex.Replace(txt, "&rpargt;", "⦔");

            // "U+02995", "DOUBLE LEFT ARC GREATER-THAN BRACKET"
            txt = Regex.Replace(txt, "&#x0*?2995;", "⦕");
            txt = Regex.Replace(txt, "&#0*?10645;", "⦕");
            txt = Regex.Replace(txt, "&gtlPar;", "⦕");

            // "U+02996", "DOUBLE RIGHT ARC LESS-THAN BRACKET"
            txt = Regex.Replace(txt, "&#x0*?2996;", "⦖");
            txt = Regex.Replace(txt, "&#0*?10646;", "⦖");
            txt = Regex.Replace(txt, "&ltrPar;", "⦖");

            // "U+0299A", "VERTICAL ZIGZAG LINE"
            txt = Regex.Replace(txt, "&#x0*?299A;", "⦚");
            txt = Regex.Replace(txt, "&#0*?10650;", "⦚");
            txt = Regex.Replace(txt, "&vzigzag;", "⦚");

            // "U+0299C", "RIGHT ANGLE VARIANT WITH SQUARE"
            txt = Regex.Replace(txt, "&#x0*?299C;", "⦜");
            txt = Regex.Replace(txt, "&#0*?10652;", "⦜");
            txt = Regex.Replace(txt, "&vangrt;", "⦜");

            // "U+0299D", "MEASURED RIGHT ANGLE WITH DOT"
            txt = Regex.Replace(txt, "&#x0*?299D;", "⦝");
            txt = Regex.Replace(txt, "&#0*?10653;", "⦝");
            txt = Regex.Replace(txt, "&angrtvbd;", "⦝");

            // "U+029A4", "ANGLE WITH UNDERBAR"
            txt = Regex.Replace(txt, "&#x0*?29A4;", "⦤");
            txt = Regex.Replace(txt, "&#0*?10660;", "⦤");
            txt = Regex.Replace(txt, "&ange;", "⦤");

            // "U+029A5", "REVERSED ANGLE WITH UNDERBAR"
            txt = Regex.Replace(txt, "&#x0*?29A5;", "⦥");
            txt = Regex.Replace(txt, "&#0*?10661;", "⦥");
            txt = Regex.Replace(txt, "&range;", "⦥");

            // "U+029A6", "OBLIQUE ANGLE OPENING UP"
            txt = Regex.Replace(txt, "&#x0*?29A6;", "⦦");
            txt = Regex.Replace(txt, "&#0*?10662;", "⦦");
            txt = Regex.Replace(txt, "&dwangle;", "⦦");

            // "U+029A7", "OBLIQUE ANGLE OPENING DOWN"
            txt = Regex.Replace(txt, "&#x0*?29A7;", "⦧");
            txt = Regex.Replace(txt, "&#0*?10663;", "⦧");
            txt = Regex.Replace(txt, "&uwangle;", "⦧");

            // "U+029A8", "MEASURED ANGLE WITH OPEN ARM ENDING IN ARROW POINTING UP AND RIGHT"
            txt = Regex.Replace(txt, "&#x0*?29A8;", "⦨");
            txt = Regex.Replace(txt, "&#0*?10664;", "⦨");
            txt = Regex.Replace(txt, "&angmsdaa;", "⦨");

            // "U+029A9", "MEASURED ANGLE WITH OPEN ARM ENDING IN ARROW POINTING UP AND LEFT"
            txt = Regex.Replace(txt, "&#x0*?29A9;", "⦩");
            txt = Regex.Replace(txt, "&#0*?10665;", "⦩");
            txt = Regex.Replace(txt, "&angmsdab;", "⦩");

            // "U+029AA", "MEASURED ANGLE WITH OPEN ARM ENDING IN ARROW POINTING DOWN AND RIGHT"
            txt = Regex.Replace(txt, "&#x0*?29AA;", "⦪");
            txt = Regex.Replace(txt, "&#0*?10666;", "⦪");
            txt = Regex.Replace(txt, "&angmsdac;", "⦪");

            // "U+029AB", "MEASURED ANGLE WITH OPEN ARM ENDING IN ARROW POINTING DOWN AND LEFT"
            txt = Regex.Replace(txt, "&#x0*?29AB;", "⦫");
            txt = Regex.Replace(txt, "&#0*?10667;", "⦫");
            txt = Regex.Replace(txt, "&angmsdad;", "⦫");

            // "U+029AC", "MEASURED ANGLE WITH OPEN ARM ENDING IN ARROW POINTING RIGHT AND UP"
            txt = Regex.Replace(txt, "&#x0*?29AC;", "⦬");
            txt = Regex.Replace(txt, "&#0*?10668;", "⦬");
            txt = Regex.Replace(txt, "&angmsdae;", "⦬");

            // "U+029AD", "MEASURED ANGLE WITH OPEN ARM ENDING IN ARROW POINTING LEFT AND UP"
            txt = Regex.Replace(txt, "&#x0*?29AD;", "⦭");
            txt = Regex.Replace(txt, "&#0*?10669;", "⦭");
            txt = Regex.Replace(txt, "&angmsdaf;", "⦭");

            // "U+029AE", "MEASURED ANGLE WITH OPEN ARM ENDING IN ARROW POINTING RIGHT AND DOWN"
            txt = Regex.Replace(txt, "&#x0*?29AE;", "⦮");
            txt = Regex.Replace(txt, "&#0*?10670;", "⦮");
            txt = Regex.Replace(txt, "&angmsdag;", "⦮");

            // "U+029AF", "MEASURED ANGLE WITH OPEN ARM ENDING IN ARROW POINTING LEFT AND DOWN"
            txt = Regex.Replace(txt, "&#x0*?29AF;", "⦯");
            txt = Regex.Replace(txt, "&#0*?10671;", "⦯");
            txt = Regex.Replace(txt, "&angmsdah;", "⦯");

            // "U+029B0", "REVERSED EMPTY SET"
            txt = Regex.Replace(txt, "&#x0*?29B0;", "⦰");
            txt = Regex.Replace(txt, "&#0*?10672;", "⦰");
            txt = Regex.Replace(txt, "&bemptyv;", "⦰");

            // "U+029B1", "EMPTY SET WITH OVERBAR"
            txt = Regex.Replace(txt, "&#x0*?29B1;", "⦱");
            txt = Regex.Replace(txt, "&#0*?10673;", "⦱");
            txt = Regex.Replace(txt, "&demptyv;", "⦱");

            // "U+029B2", "EMPTY SET WITH SMALL CIRCLE ABOVE"
            txt = Regex.Replace(txt, "&#x0*?29B2;", "⦲");
            txt = Regex.Replace(txt, "&#0*?10674;", "⦲");
            txt = Regex.Replace(txt, "&cemptyv;", "⦲");

            // "U+029B3", "EMPTY SET WITH RIGHT ARROW ABOVE"
            txt = Regex.Replace(txt, "&#x0*?29B3;", "⦳");
            txt = Regex.Replace(txt, "&#0*?10675;", "⦳");
            txt = Regex.Replace(txt, "&raemptyv;", "⦳");

            // "U+029B4", "EMPTY SET WITH LEFT ARROW ABOVE"
            txt = Regex.Replace(txt, "&#x0*?29B4;", "⦴");
            txt = Regex.Replace(txt, "&#0*?10676;", "⦴");
            txt = Regex.Replace(txt, "&laemptyv;", "⦴");

            // "U+029B5", "CIRCLE WITH HORIZONTAL BAR"
            txt = Regex.Replace(txt, "&#x0*?29B5;", "⦵");
            txt = Regex.Replace(txt, "&#0*?10677;", "⦵");
            txt = Regex.Replace(txt, "&ohbar;", "⦵");

            // "U+029B6", "CIRCLED VERTICAL BAR"
            txt = Regex.Replace(txt, "&#x0*?29B6;", "⦶");
            txt = Regex.Replace(txt, "&#0*?10678;", "⦶");
            txt = Regex.Replace(txt, "&omid;", "⦶");

            // "U+029B7", "CIRCLED PARALLEL"
            txt = Regex.Replace(txt, "&#x0*?29B7;", "⦷");
            txt = Regex.Replace(txt, "&#0*?10679;", "⦷");
            txt = Regex.Replace(txt, "&opar;", "⦷");

            // "U+029B9", "CIRCLED PERPENDICULAR"
            txt = Regex.Replace(txt, "&#x0*?29B9;", "⦹");
            txt = Regex.Replace(txt, "&#0*?10681;", "⦹");
            txt = Regex.Replace(txt, "&operp;", "⦹");

            // "U+029BB", "CIRCLE WITH SUPERIMPOSED X"
            txt = Regex.Replace(txt, "&#x0*?29BB;", "⦻");
            txt = Regex.Replace(txt, "&#0*?10683;", "⦻");
            txt = Regex.Replace(txt, "&olcross;", "⦻");

            // "U+029BC", "CIRCLED ANTICLOCKWISE-ROTATED DIVISION SIGN"
            txt = Regex.Replace(txt, "&#x0*?29BC;", "⦼");
            txt = Regex.Replace(txt, "&#0*?10684;", "⦼");
            txt = Regex.Replace(txt, "&odsold;", "⦼");

            // "U+029BE", "CIRCLED WHITE BULLET"
            txt = Regex.Replace(txt, "&#x0*?29BE;", "⦾");
            txt = Regex.Replace(txt, "&#0*?10686;", "⦾");
            txt = Regex.Replace(txt, "&olcir;", "⦾");

            // "U+029BF", "CIRCLED BULLET"
            txt = Regex.Replace(txt, "&#x0*?29BF;", "⦿");
            txt = Regex.Replace(txt, "&#0*?10687;", "⦿");
            txt = Regex.Replace(txt, "&ofcir;", "⦿");

            // "U+029C0", "CIRCLED LESS-THAN"
            txt = Regex.Replace(txt, "&#x0*?29C0;", "⧀");
            txt = Regex.Replace(txt, "&#0*?10688;", "⧀");
            txt = Regex.Replace(txt, "&olt;", "⧀");

            // "U+029C1", "CIRCLED GREATER-THAN"
            txt = Regex.Replace(txt, "&#x0*?29C1;", "⧁");
            txt = Regex.Replace(txt, "&#0*?10689;", "⧁");
            txt = Regex.Replace(txt, "&ogt;", "⧁");

            // "U+029C2", "CIRCLE WITH SMALL CIRCLE TO THE RIGHT"
            txt = Regex.Replace(txt, "&#x0*?29C2;", "⧂");
            txt = Regex.Replace(txt, "&#0*?10690;", "⧂");
            txt = Regex.Replace(txt, "&cirscir;", "⧂");

            // "U+029C3", "CIRCLE WITH TWO HORIZONTAL STROKES TO THE RIGHT"
            txt = Regex.Replace(txt, "&#x0*?29C3;", "⧃");
            txt = Regex.Replace(txt, "&#0*?10691;", "⧃");
            txt = Regex.Replace(txt, "&cirE;", "⧃");

            // "U+029C4", "SQUARED RISING DIAGONAL SLASH"
            txt = Regex.Replace(txt, "&#x0*?29C4;", "⧄");
            txt = Regex.Replace(txt, "&#0*?10692;", "⧄");
            txt = Regex.Replace(txt, "&solb;", "⧄");

            // "U+029C5", "SQUARED FALLING DIAGONAL SLASH"
            txt = Regex.Replace(txt, "&#x0*?29C5;", "⧅");
            txt = Regex.Replace(txt, "&#0*?10693;", "⧅");
            txt = Regex.Replace(txt, "&bsolb;", "⧅");

            // "U+029C9", "TWO JOINED SQUARES"
            txt = Regex.Replace(txt, "&#x0*?29C9;", "⧉");
            txt = Regex.Replace(txt, "&#0*?10697;", "⧉");
            txt = Regex.Replace(txt, "&boxbox;", "⧉");

            // "U+029CD", "TRIANGLE WITH SERIFS AT BOTTOM"
            txt = Regex.Replace(txt, "&#x0*?29CD;", "⧍");
            txt = Regex.Replace(txt, "&#0*?10701;", "⧍");
            txt = Regex.Replace(txt, "&trisb;", "⧍");

            // "U+029CE", "RIGHT TRIANGLE ABOVE LEFT TRIANGLE"
            txt = Regex.Replace(txt, "&#x0*?29CE;", "⧎");
            txt = Regex.Replace(txt, "&#0*?10702;", "⧎");
            txt = Regex.Replace(txt, "&rtriltri;", "⧎");

            // "U+029CF", "LEFT TRIANGLE BESIDE VERTICAL BAR"
            txt = Regex.Replace(txt, "&#x0*?29CF;", "⧏");
            txt = Regex.Replace(txt, "&#0*?10703;", "⧏");
            txt = Regex.Replace(txt, "&LeftTriangleBar;", "⧏");

            // "U+029D0", "VERTICAL BAR BESIDE RIGHT TRIANGLE"
            txt = Regex.Replace(txt, "&#x0*?29D0;", "⧐");
            txt = Regex.Replace(txt, "&#0*?10704;", "⧐");
            txt = Regex.Replace(txt, "&RightTriangleBar;", "⧐");

            // "U+029DA", "LEFT DOUBLE WIGGLY FENCE"
            txt = Regex.Replace(txt, "&#x0*?29DA;", "⧚");
            txt = Regex.Replace(txt, "&#0*?10714;", "⧚");
            txt = Regex.Replace(txt, "&race;", "⧚");

            // "U+029DC", "INCOMPLETE INFINITY"
            txt = Regex.Replace(txt, "&#x0*?29DC;", "⧜");
            txt = Regex.Replace(txt, "&#0*?10716;", "⧜");
            txt = Regex.Replace(txt, "&iinfin;", "⧜");

            // "U+029DD", "TIE OVER INFINITY"
            txt = Regex.Replace(txt, "&#x0*?29DD;", "⧝");
            txt = Regex.Replace(txt, "&#0*?10717;", "⧝");
            txt = Regex.Replace(txt, "&infintie;", "⧝");

            // "U+029DE", "INFINITY NEGATED WITH VERTICAL BAR"
            txt = Regex.Replace(txt, "&#x0*?29DE;", "⧞");
            txt = Regex.Replace(txt, "&#0*?10718;", "⧞");
            txt = Regex.Replace(txt, "&nvinfin;", "⧞");

            // "U+029E3", "EQUALS SIGN AND SLANTED PARALLEL"
            txt = Regex.Replace(txt, "&#x0*?29E3;", "⧣");
            txt = Regex.Replace(txt, "&#0*?10723;", "⧣");
            txt = Regex.Replace(txt, "&eparsl;", "⧣");

            // "U+029E4", "EQUALS SIGN AND SLANTED PARALLEL WITH TILDE ABOVE"
            txt = Regex.Replace(txt, "&#x0*?29E4;", "⧤");
            txt = Regex.Replace(txt, "&#0*?10724;", "⧤");
            txt = Regex.Replace(txt, "&smeparsl;", "⧤");

            // "U+029E5", "IDENTICAL TO AND SLANTED PARALLEL"
            txt = Regex.Replace(txt, "&#x0*?29E5;", "⧥");
            txt = Regex.Replace(txt, "&#0*?10725;", "⧥");
            txt = Regex.Replace(txt, "&eqvparsl;", "⧥");

            // "U+029EB", "BLACK LOZENGE"
            txt = Regex.Replace(txt, "&#x0*?29EB;", "⧫");
            txt = Regex.Replace(txt, "&#0*?10731;", "⧫");
            txt = Regex.Replace(txt, "&lozf;", "⧫");
            txt = Regex.Replace(txt, "&blacklozenge;", "⧫");

            // "U+029F4", "RULE-DELAYED"
            txt = Regex.Replace(txt, "&#x0*?29F4;", "⧴");
            txt = Regex.Replace(txt, "&#0*?10740;", "⧴");
            txt = Regex.Replace(txt, "&RuleDelayed;", "⧴");

            // "U+029F6", "SOLIDUS WITH OVERBAR"
            txt = Regex.Replace(txt, "&#x0*?29F6;", "⧶");
            txt = Regex.Replace(txt, "&#0*?10742;", "⧶");
            txt = Regex.Replace(txt, "&dsol;", "⧶");

            // "U+02A00", "N-ARY CIRCLED DOT OPERATOR"
            txt = Regex.Replace(txt, "&#x0*?2A00;", "⨀");
            txt = Regex.Replace(txt, "&#0*?10752;", "⨀");
            txt = Regex.Replace(txt, "&xodot;", "⨀");
            txt = Regex.Replace(txt, "&bigodot;", "⨀");

            // "U+02A01", "N-ARY CIRCLED PLUS OPERATOR"
            txt = Regex.Replace(txt, "&#x0*?2A01;", "⨁");
            txt = Regex.Replace(txt, "&#0*?10753;", "⨁");
            txt = Regex.Replace(txt, "&xoplus;", "⨁");
            txt = Regex.Replace(txt, "&bigoplus;", "⨁");

            // "U+02A02", "N-ARY CIRCLED TIMES OPERATOR"
            txt = Regex.Replace(txt, "&#x0*?2A02;", "⨂");
            txt = Regex.Replace(txt, "&#0*?10754;", "⨂");
            txt = Regex.Replace(txt, "&xotime;", "⨂");
            txt = Regex.Replace(txt, "&bigotimes;", "⨂");

            // "U+02A04", "N-ARY UNION OPERATOR WITH PLUS"
            txt = Regex.Replace(txt, "&#x0*?2A04;", "⨄");
            txt = Regex.Replace(txt, "&#0*?10756;", "⨄");
            txt = Regex.Replace(txt, "&xuplus;", "⨄");
            txt = Regex.Replace(txt, "&biguplus;", "⨄");

            // "U+02A06", "N-ARY SQUARE UNION OPERATOR"
            txt = Regex.Replace(txt, "&#x0*?2A06;", "⨆");
            txt = Regex.Replace(txt, "&#0*?10758;", "⨆");
            txt = Regex.Replace(txt, "&xsqcup;", "⨆");
            txt = Regex.Replace(txt, "&bigsqcup;", "⨆");

            // "U+02A0C", "QUADRUPLE INTEGRAL OPERATOR"
            txt = Regex.Replace(txt, "&#x0*?2A0C;", "⨌");
            txt = Regex.Replace(txt, "&#0*?10764;", "⨌");
            txt = Regex.Replace(txt, "&qint;", "⨌");
            txt = Regex.Replace(txt, "&iiiint;", "⨌");

            // "U+02A0D", "FINITE PART INTEGRAL"
            txt = Regex.Replace(txt, "&#x0*?2A0D;", "⨍");
            txt = Regex.Replace(txt, "&#0*?10765;", "⨍");
            txt = Regex.Replace(txt, "&fpartint;", "⨍");

            // "U+02A10", "CIRCULATION FUNCTION"
            txt = Regex.Replace(txt, "&#x0*?2A10;", "⨐");
            txt = Regex.Replace(txt, "&#0*?10768;", "⨐");
            txt = Regex.Replace(txt, "&cirfnint;", "⨐");

            // "U+02A11", "ANTICLOCKWISE INTEGRATION"
            txt = Regex.Replace(txt, "&#x0*?2A11;", "⨑");
            txt = Regex.Replace(txt, "&#0*?10769;", "⨑");
            txt = Regex.Replace(txt, "&awint;", "⨑");

            // "U+02A12", "LINE INTEGRATION WITH RECTANGULAR PATH AROUND POLE"
            txt = Regex.Replace(txt, "&#x0*?2A12;", "⨒");
            txt = Regex.Replace(txt, "&#0*?10770;", "⨒");
            txt = Regex.Replace(txt, "&rppolint;", "⨒");

            // "U+02A13", "LINE INTEGRATION WITH SEMICIRCULAR PATH AROUND POLE"
            txt = Regex.Replace(txt, "&#x0*?2A13;", "⨓");
            txt = Regex.Replace(txt, "&#0*?10771;", "⨓");
            txt = Regex.Replace(txt, "&scpolint;", "⨓");

            // "U+02A14", "LINE INTEGRATION NOT INCLUDING THE POLE"
            txt = Regex.Replace(txt, "&#x0*?2A14;", "⨔");
            txt = Regex.Replace(txt, "&#0*?10772;", "⨔");
            txt = Regex.Replace(txt, "&npolint;", "⨔");

            // "U+02A15", "INTEGRAL AROUND A POINT OPERATOR"
            txt = Regex.Replace(txt, "&#x0*?2A15;", "⨕");
            txt = Regex.Replace(txt, "&#0*?10773;", "⨕");
            txt = Regex.Replace(txt, "&pointint;", "⨕");

            // "U+02A16", "QUATERNION INTEGRAL OPERATOR"
            txt = Regex.Replace(txt, "&#x0*?2A16;", "⨖");
            txt = Regex.Replace(txt, "&#0*?10774;", "⨖");
            txt = Regex.Replace(txt, "&quatint;", "⨖");

            // "U+02A17", "INTEGRAL WITH LEFTWARDS ARROW WITH HOOK"
            txt = Regex.Replace(txt, "&#x0*?2A17;", "⨗");
            txt = Regex.Replace(txt, "&#0*?10775;", "⨗");
            txt = Regex.Replace(txt, "&intlarhk;", "⨗");

            // "U+02A22", "PLUS SIGN WITH SMALL CIRCLE ABOVE"
            txt = Regex.Replace(txt, "&#x0*?2A22;", "⨢");
            txt = Regex.Replace(txt, "&#0*?10786;", "⨢");
            txt = Regex.Replace(txt, "&pluscir;", "⨢");

            // "U+02A23", "PLUS SIGN WITH CIRCUMFLEX ACCENT ABOVE"
            txt = Regex.Replace(txt, "&#x0*?2A23;", "⨣");
            txt = Regex.Replace(txt, "&#0*?10787;", "⨣");
            txt = Regex.Replace(txt, "&plusacir;", "⨣");

            // "U+02A24", "PLUS SIGN WITH TILDE ABOVE"
            txt = Regex.Replace(txt, "&#x0*?2A24;", "⨤");
            txt = Regex.Replace(txt, "&#0*?10788;", "⨤");
            txt = Regex.Replace(txt, "&simplus;", "⨤");

            // "U+02A25", "PLUS SIGN WITH DOT BELOW"
            txt = Regex.Replace(txt, "&#x0*?2A25;", "⨥");
            txt = Regex.Replace(txt, "&#0*?10789;", "⨥");
            txt = Regex.Replace(txt, "&plusdu;", "⨥");

            // "U+02A26", "PLUS SIGN WITH TILDE BELOW"
            txt = Regex.Replace(txt, "&#x0*?2A26;", "⨦");
            txt = Regex.Replace(txt, "&#0*?10790;", "⨦");
            txt = Regex.Replace(txt, "&plussim;", "⨦");

            // "U+02A27", "PLUS SIGN WITH SUBSCRIPT TWO"
            txt = Regex.Replace(txt, "&#x0*?2A27;", "⨧");
            txt = Regex.Replace(txt, "&#0*?10791;", "⨧");
            txt = Regex.Replace(txt, "&plustwo;", "⨧");

            // "U+02A29", "MINUS SIGN WITH COMMA ABOVE"
            txt = Regex.Replace(txt, "&#x0*?2A29;", "⨩");
            txt = Regex.Replace(txt, "&#0*?10793;", "⨩");
            txt = Regex.Replace(txt, "&mcomma;", "⨩");

            // "U+02A2A", "MINUS SIGN WITH DOT BELOW"
            txt = Regex.Replace(txt, "&#x0*?2A2A;", "⨪");
            txt = Regex.Replace(txt, "&#0*?10794;", "⨪");
            txt = Regex.Replace(txt, "&minusdu;", "⨪");

            // "U+02A2D", "PLUS SIGN IN LEFT HALF CIRCLE"
            txt = Regex.Replace(txt, "&#x0*?2A2D;", "⨭");
            txt = Regex.Replace(txt, "&#0*?10797;", "⨭");
            txt = Regex.Replace(txt, "&loplus;", "⨭");

            // "U+02A2E", "PLUS SIGN IN RIGHT HALF CIRCLE"
            txt = Regex.Replace(txt, "&#x0*?2A2E;", "⨮");
            txt = Regex.Replace(txt, "&#0*?10798;", "⨮");
            txt = Regex.Replace(txt, "&roplus;", "⨮");

            // "U+02A2F", "VECTOR OR CROSS PRODUCT"
            txt = Regex.Replace(txt, "&#x0*?2A2F;", "⨯");
            txt = Regex.Replace(txt, "&#0*?10799;", "⨯");
            txt = Regex.Replace(txt, "&Cross;", "⨯");

            // "U+02A30", "MULTIPLICATION SIGN WITH DOT ABOVE"
            txt = Regex.Replace(txt, "&#x0*?2A30;", "⨰");
            txt = Regex.Replace(txt, "&#0*?10800;", "⨰");
            txt = Regex.Replace(txt, "&timesd;", "⨰");

            // "U+02A31", "MULTIPLICATION SIGN WITH UNDERBAR"
            txt = Regex.Replace(txt, "&#x0*?2A31;", "⨱");
            txt = Regex.Replace(txt, "&#0*?10801;", "⨱");
            txt = Regex.Replace(txt, "&timesbar;", "⨱");

            // "U+02A33", "SMASH PRODUCT"
            txt = Regex.Replace(txt, "&#x0*?2A33;", "⨳");
            txt = Regex.Replace(txt, "&#0*?10803;", "⨳");
            txt = Regex.Replace(txt, "&smashp;", "⨳");

            // "U+02A34", "MULTIPLICATION SIGN IN LEFT HALF CIRCLE"
            txt = Regex.Replace(txt, "&#x0*?2A34;", "⨴");
            txt = Regex.Replace(txt, "&#0*?10804;", "⨴");
            txt = Regex.Replace(txt, "&lotimes;", "⨴");

            // "U+02A35", "MULTIPLICATION SIGN IN RIGHT HALF CIRCLE"
            txt = Regex.Replace(txt, "&#x0*?2A35;", "⨵");
            txt = Regex.Replace(txt, "&#0*?10805;", "⨵");
            txt = Regex.Replace(txt, "&rotimes;", "⨵");

            // "U+02A36", "CIRCLED MULTIPLICATION SIGN WITH CIRCUMFLEX ACCENT"
            txt = Regex.Replace(txt, "&#x0*?2A36;", "⨶");
            txt = Regex.Replace(txt, "&#0*?10806;", "⨶");
            txt = Regex.Replace(txt, "&otimesas;", "⨶");

            // "U+02A37", "MULTIPLICATION SIGN IN DOUBLE CIRCLE"
            txt = Regex.Replace(txt, "&#x0*?2A37;", "⨷");
            txt = Regex.Replace(txt, "&#0*?10807;", "⨷");
            txt = Regex.Replace(txt, "&Otimes;", "⨷");

            // "U+02A38", "CIRCLED DIVISION SIGN"
            txt = Regex.Replace(txt, "&#x0*?2A38;", "⨸");
            txt = Regex.Replace(txt, "&#0*?10808;", "⨸");
            txt = Regex.Replace(txt, "&odiv;", "⨸");

            // "U+02A39", "PLUS SIGN IN TRIANGLE"
            txt = Regex.Replace(txt, "&#x0*?2A39;", "⨹");
            txt = Regex.Replace(txt, "&#0*?10809;", "⨹");
            txt = Regex.Replace(txt, "&triplus;", "⨹");

            // "U+02A3A", "MINUS SIGN IN TRIANGLE"
            txt = Regex.Replace(txt, "&#x0*?2A3A;", "⨺");
            txt = Regex.Replace(txt, "&#0*?10810;", "⨺");
            txt = Regex.Replace(txt, "&triminus;", "⨺");

            // "U+02A3B", "MULTIPLICATION SIGN IN TRIANGLE"
            txt = Regex.Replace(txt, "&#x0*?2A3B;", "⨻");
            txt = Regex.Replace(txt, "&#0*?10811;", "⨻");
            txt = Regex.Replace(txt, "&tritime;", "⨻");

            // "U+02A3C", "INTERIOR PRODUCT"
            txt = Regex.Replace(txt, "&#x0*?2A3C;", "⨼");
            txt = Regex.Replace(txt, "&#0*?10812;", "⨼");
            txt = Regex.Replace(txt, "&iprod;", "⨼");
            txt = Regex.Replace(txt, "&intprod;", "⨼");

            // "U+02A3F", "AMALGAMATION OR COPRODUCT"
            txt = Regex.Replace(txt, "&#x0*?2A3F;", "⨿");
            txt = Regex.Replace(txt, "&#0*?10815;", "⨿");
            txt = Regex.Replace(txt, "&amalg;", "⨿");

            // "U+02A40", "INTERSECTION WITH DOT"
            txt = Regex.Replace(txt, "&#x0*?2A40;", "⩀");
            txt = Regex.Replace(txt, "&#0*?10816;", "⩀");
            txt = Regex.Replace(txt, "&capdot;", "⩀");

            // "U+02A42", "UNION WITH OVERBAR"
            txt = Regex.Replace(txt, "&#x0*?2A42;", "⩂");
            txt = Regex.Replace(txt, "&#0*?10818;", "⩂");
            txt = Regex.Replace(txt, "&ncup;", "⩂");

            // "U+02A43", "INTERSECTION WITH OVERBAR"
            txt = Regex.Replace(txt, "&#x0*?2A43;", "⩃");
            txt = Regex.Replace(txt, "&#0*?10819;", "⩃");
            txt = Regex.Replace(txt, "&ncap;", "⩃");

            // "U+02A44", "INTERSECTION WITH LOGICAL AND"
            txt = Regex.Replace(txt, "&#x0*?2A44;", "⩄");
            txt = Regex.Replace(txt, "&#0*?10820;", "⩄");
            txt = Regex.Replace(txt, "&capand;", "⩄");

            // "U+02A45", "UNION WITH LOGICAL OR"
            txt = Regex.Replace(txt, "&#x0*?2A45;", "⩅");
            txt = Regex.Replace(txt, "&#0*?10821;", "⩅");
            txt = Regex.Replace(txt, "&cupor;", "⩅");

            // "U+02A46", "UNION ABOVE INTERSECTION"
            txt = Regex.Replace(txt, "&#x0*?2A46;", "⩆");
            txt = Regex.Replace(txt, "&#0*?10822;", "⩆");
            txt = Regex.Replace(txt, "&cupcap;", "⩆");

            // "U+02A47", "INTERSECTION ABOVE UNION"
            txt = Regex.Replace(txt, "&#x0*?2A47;", "⩇");
            txt = Regex.Replace(txt, "&#0*?10823;", "⩇");
            txt = Regex.Replace(txt, "&capcup;", "⩇");

            // "U+02A48", "UNION ABOVE BAR ABOVE INTERSECTION"
            txt = Regex.Replace(txt, "&#x0*?2A48;", "⩈");
            txt = Regex.Replace(txt, "&#0*?10824;", "⩈");
            txt = Regex.Replace(txt, "&cupbrcap;", "⩈");

            // "U+02A49", "INTERSECTION ABOVE BAR ABOVE UNION"
            txt = Regex.Replace(txt, "&#x0*?2A49;", "⩉");
            txt = Regex.Replace(txt, "&#0*?10825;", "⩉");
            txt = Regex.Replace(txt, "&capbrcup;", "⩉");

            // "U+02A4A", "UNION BESIDE AND JOINED WITH UNION"
            txt = Regex.Replace(txt, "&#x0*?2A4A;", "⩊");
            txt = Regex.Replace(txt, "&#0*?10826;", "⩊");
            txt = Regex.Replace(txt, "&cupcup;", "⩊");

            // "U+02A4B", "INTERSECTION BESIDE AND JOINED WITH INTERSECTION"
            txt = Regex.Replace(txt, "&#x0*?2A4B;", "⩋");
            txt = Regex.Replace(txt, "&#0*?10827;", "⩋");
            txt = Regex.Replace(txt, "&capcap;", "⩋");

            // "U+02A4C", "CLOSED UNION WITH SERIFS"
            txt = Regex.Replace(txt, "&#x0*?2A4C;", "⩌");
            txt = Regex.Replace(txt, "&#0*?10828;", "⩌");
            txt = Regex.Replace(txt, "&ccups;", "⩌");

            // "U+02A4D", "CLOSED INTERSECTION WITH SERIFS"
            txt = Regex.Replace(txt, "&#x0*?2A4D;", "⩍");
            txt = Regex.Replace(txt, "&#0*?10829;", "⩍");
            txt = Regex.Replace(txt, "&ccaps;", "⩍");

            // "U+02A50", "CLOSED UNION WITH SERIFS AND SMASH PRODUCT"
            txt = Regex.Replace(txt, "&#x0*?2A50;", "⩐");
            txt = Regex.Replace(txt, "&#0*?10832;", "⩐");
            txt = Regex.Replace(txt, "&ccupssm;", "⩐");

            // "U+02A53", "DOUBLE LOGICAL AND"
            txt = Regex.Replace(txt, "&#x0*?2A53;", "⩓");
            txt = Regex.Replace(txt, "&#0*?10835;", "⩓");
            txt = Regex.Replace(txt, "&And;", "⩓");

            // "U+02A54", "DOUBLE LOGICAL OR"
            txt = Regex.Replace(txt, "&#x0*?2A54;", "⩔");
            txt = Regex.Replace(txt, "&#0*?10836;", "⩔");
            txt = Regex.Replace(txt, "&Or;", "⩔");

            // "U+02A55", "TWO INTERSECTING LOGICAL AND"
            txt = Regex.Replace(txt, "&#x0*?2A55;", "⩕");
            txt = Regex.Replace(txt, "&#0*?10837;", "⩕");
            txt = Regex.Replace(txt, "&andand;", "⩕");

            // "U+02A56", "TWO INTERSECTING LOGICAL OR"
            txt = Regex.Replace(txt, "&#x0*?2A56;", "⩖");
            txt = Regex.Replace(txt, "&#0*?10838;", "⩖");
            txt = Regex.Replace(txt, "&oror;", "⩖");

            // "U+02A57", "SLOPING LARGE OR"
            txt = Regex.Replace(txt, "&#x0*?2A57;", "⩗");
            txt = Regex.Replace(txt, "&#0*?10839;", "⩗");
            txt = Regex.Replace(txt, "&orslope;", "⩗");

            // "U+02A58", "SLOPING LARGE AND"
            txt = Regex.Replace(txt, "&#x0*?2A58;", "⩘");
            txt = Regex.Replace(txt, "&#0*?10840;", "⩘");
            txt = Regex.Replace(txt, "&andslope;", "⩘");

            // "U+02A5A", "LOGICAL AND WITH MIDDLE STEM"
            txt = Regex.Replace(txt, "&#x0*?2A5A;", "⩚");
            txt = Regex.Replace(txt, "&#0*?10842;", "⩚");
            txt = Regex.Replace(txt, "&andv;", "⩚");

            // "U+02A5B", "LOGICAL OR WITH MIDDLE STEM"
            txt = Regex.Replace(txt, "&#x0*?2A5B;", "⩛");
            txt = Regex.Replace(txt, "&#0*?10843;", "⩛");
            txt = Regex.Replace(txt, "&orv;", "⩛");

            // "U+02A5C", "LOGICAL AND WITH HORIZONTAL DASH"
            txt = Regex.Replace(txt, "&#x0*?2A5C;", "⩜");
            txt = Regex.Replace(txt, "&#0*?10844;", "⩜");
            txt = Regex.Replace(txt, "&andd;", "⩜");

            // "U+02A5D", "LOGICAL OR WITH HORIZONTAL DASH"
            txt = Regex.Replace(txt, "&#x0*?2A5D;", "⩝");
            txt = Regex.Replace(txt, "&#0*?10845;", "⩝");
            txt = Regex.Replace(txt, "&ord;", "⩝");

            // "U+02A5F", "LOGICAL AND WITH UNDERBAR"
            txt = Regex.Replace(txt, "&#x0*?2A5F;", "⩟");
            txt = Regex.Replace(txt, "&#0*?10847;", "⩟");
            txt = Regex.Replace(txt, "&wedbar;", "⩟");

            // "U+02A66", "EQUALS SIGN WITH DOT BELOW"
            txt = Regex.Replace(txt, "&#x0*?2A66;", "⩦");
            txt = Regex.Replace(txt, "&#0*?10854;", "⩦");
            txt = Regex.Replace(txt, "&sdote;", "⩦");

            // "U+02A6A", "TILDE OPERATOR WITH DOT ABOVE"
            txt = Regex.Replace(txt, "&#x0*?2A6A;", "⩪");
            txt = Regex.Replace(txt, "&#0*?10858;", "⩪");
            txt = Regex.Replace(txt, "&simdot;", "⩪");

            // "U+02A6D", "CONGRUENT WITH DOT ABOVE"
            txt = Regex.Replace(txt, "&#x0*?2A6D;", "⩭");
            txt = Regex.Replace(txt, "&#0*?10861;", "⩭");
            txt = Regex.Replace(txt, "&congdot;", "⩭");

            // "U+02A6E", "EQUALS WITH ASTERISK"
            txt = Regex.Replace(txt, "&#x0*?2A6E;", "⩮");
            txt = Regex.Replace(txt, "&#0*?10862;", "⩮");
            txt = Regex.Replace(txt, "&easter;", "⩮");

            // "U+02A6F", "ALMOST EQUAL TO WITH CIRCUMFLEX ACCENT"
            txt = Regex.Replace(txt, "&#x0*?2A6F;", "⩯");
            txt = Regex.Replace(txt, "&#0*?10863;", "⩯");
            txt = Regex.Replace(txt, "&apacir;", "⩯");

            // "U+02A70", "APPROXIMATELY EQUAL OR EQUAL TO"
            txt = Regex.Replace(txt, "&#x0*?2A70;", "⩰");
            txt = Regex.Replace(txt, "&#0*?10864;", "⩰");
            txt = Regex.Replace(txt, "&apE;", "⩰");

            // "U+02A71", "EQUALS SIGN ABOVE PLUS SIGN"
            txt = Regex.Replace(txt, "&#x0*?2A71;", "⩱");
            txt = Regex.Replace(txt, "&#0*?10865;", "⩱");
            txt = Regex.Replace(txt, "&eplus;", "⩱");

            // "U+02A72", "PLUS SIGN ABOVE EQUALS SIGN"
            txt = Regex.Replace(txt, "&#x0*?2A72;", "⩲");
            txt = Regex.Replace(txt, "&#0*?10866;", "⩲");
            txt = Regex.Replace(txt, "&pluse;", "⩲");

            // "U+02A73", "EQUALS SIGN ABOVE TILDE OPERATOR"
            txt = Regex.Replace(txt, "&#x0*?2A73;", "⩳");
            txt = Regex.Replace(txt, "&#0*?10867;", "⩳");
            txt = Regex.Replace(txt, "&Esim;", "⩳");

            // "U+02A74", "DOUBLE COLON EQUAL"
            txt = Regex.Replace(txt, "&#x0*?2A74;", "⩴");
            txt = Regex.Replace(txt, "&#0*?10868;", "⩴");
            txt = Regex.Replace(txt, "&Colone;", "⩴");

            // "U+02A75", "TWO CONSECUTIVE EQUALS SIGNS"
            txt = Regex.Replace(txt, "&#x0*?2A75;", "⩵");
            txt = Regex.Replace(txt, "&#0*?10869;", "⩵");
            txt = Regex.Replace(txt, "&Equal;", "⩵");

            // "U+02A77", "EQUALS SIGN WITH TWO DOTS ABOVE AND TWO DOTS BELOW"
            txt = Regex.Replace(txt, "&#x0*?2A77;", "⩷");
            txt = Regex.Replace(txt, "&#0*?10871;", "⩷");
            txt = Regex.Replace(txt, "&eDDot;", "⩷");
            txt = Regex.Replace(txt, "&ddotseq;", "⩷");

            // "U+02A78", "EQUIVALENT WITH FOUR DOTS ABOVE"
            txt = Regex.Replace(txt, "&#x0*?2A78;", "⩸");
            txt = Regex.Replace(txt, "&#0*?10872;", "⩸");
            txt = Regex.Replace(txt, "&equivDD;", "⩸");

            // "U+02A79", "LESS-THAN WITH CIRCLE INSIDE"
            txt = Regex.Replace(txt, "&#x0*?2A79;", "⩹");
            txt = Regex.Replace(txt, "&#0*?10873;", "⩹");
            txt = Regex.Replace(txt, "&ltcir;", "⩹");

            // "U+02A7A", "GREATER-THAN WITH CIRCLE INSIDE"
            txt = Regex.Replace(txt, "&#x0*?2A7A;", "⩺");
            txt = Regex.Replace(txt, "&#0*?10874;", "⩺");
            txt = Regex.Replace(txt, "&gtcir;", "⩺");

            // "U+02A7B", "LESS-THAN WITH QUESTION MARK ABOVE"
            txt = Regex.Replace(txt, "&#x0*?2A7B;", "⩻");
            txt = Regex.Replace(txt, "&#0*?10875;", "⩻");
            txt = Regex.Replace(txt, "&ltquest;", "⩻");

            // "U+02A7C", "GREATER-THAN WITH QUESTION MARK ABOVE"
            txt = Regex.Replace(txt, "&#x0*?2A7C;", "⩼");
            txt = Regex.Replace(txt, "&#0*?10876;", "⩼");
            txt = Regex.Replace(txt, "&gtquest;", "⩼");

            // "U+02A7D", "LESS-THAN OR SLANTED EQUAL TO"
            txt = Regex.Replace(txt, "&#x0*?2A7D;", "⩽");
            txt = Regex.Replace(txt, "&#0*?10877;", "⩽");
            txt = Regex.Replace(txt, "&les;", "⩽");
            txt = Regex.Replace(txt, "&LessSlantEqual;", "⩽");
            txt = Regex.Replace(txt, "&leqslant;", "⩽");

            // "U+02A7E", "GREATER-THAN OR SLANTED EQUAL TO"
            txt = Regex.Replace(txt, "&#x0*?2A7E;", "⩾");
            txt = Regex.Replace(txt, "&#0*?10878;", "⩾");
            txt = Regex.Replace(txt, "&ges;", "⩾");
            txt = Regex.Replace(txt, "&GreaterSlantEqual;", "⩾");
            txt = Regex.Replace(txt, "&geqslant;", "⩾");

            // "U+02A7F", "LESS-THAN OR SLANTED EQUAL TO WITH DOT INSIDE"
            txt = Regex.Replace(txt, "&#x0*?2A7F;", "⩿");
            txt = Regex.Replace(txt, "&#0*?10879;", "⩿");
            txt = Regex.Replace(txt, "&lesdot;", "⩿");

            // "U+02A80", "GREATER-THAN OR SLANTED EQUAL TO WITH DOT INSIDE"
            txt = Regex.Replace(txt, "&#x0*?2A80;", "⪀");
            txt = Regex.Replace(txt, "&#0*?10880;", "⪀");
            txt = Regex.Replace(txt, "&gesdot;", "⪀");

            // "U+02A81", "LESS-THAN OR SLANTED EQUAL TO WITH DOT ABOVE"
            txt = Regex.Replace(txt, "&#x0*?2A81;", "⪁");
            txt = Regex.Replace(txt, "&#0*?10881;", "⪁");
            txt = Regex.Replace(txt, "&lesdoto;", "⪁");

            // "U+02A82", "GREATER-THAN OR SLANTED EQUAL TO WITH DOT ABOVE"
            txt = Regex.Replace(txt, "&#x0*?2A82;", "⪂");
            txt = Regex.Replace(txt, "&#0*?10882;", "⪂");
            txt = Regex.Replace(txt, "&gesdoto;", "⪂");

            // "U+02A83", "LESS-THAN OR SLANTED EQUAL TO WITH DOT ABOVE RIGHT"
            txt = Regex.Replace(txt, "&#x0*?2A83;", "⪃");
            txt = Regex.Replace(txt, "&#0*?10883;", "⪃");
            txt = Regex.Replace(txt, "&lesdotor;", "⪃");

            // "U+02A84", "GREATER-THAN OR SLANTED EQUAL TO WITH DOT ABOVE LEFT"
            txt = Regex.Replace(txt, "&#x0*?2A84;", "⪄");
            txt = Regex.Replace(txt, "&#0*?10884;", "⪄");
            txt = Regex.Replace(txt, "&gesdotol;", "⪄");

            // "U+02A85", "LESS-THAN OR APPROXIMATE"
            txt = Regex.Replace(txt, "&#x0*?2A85;", "⪅");
            txt = Regex.Replace(txt, "&#0*?10885;", "⪅");
            txt = Regex.Replace(txt, "&lap;", "⪅");
            txt = Regex.Replace(txt, "&lessapprox;", "⪅");

            // "U+02A86", "GREATER-THAN OR APPROXIMATE"
            txt = Regex.Replace(txt, "&#x0*?2A86;", "⪆");
            txt = Regex.Replace(txt, "&#0*?10886;", "⪆");
            txt = Regex.Replace(txt, "&gap;", "⪆");
            txt = Regex.Replace(txt, "&gtrapprox;", "⪆");

            // "U+02A87", "LESS-THAN AND SINGLE-LINE NOT EQUAL TO"
            txt = Regex.Replace(txt, "&#x0*?2A87;", "⪇");
            txt = Regex.Replace(txt, "&#0*?10887;", "⪇");
            txt = Regex.Replace(txt, "&lne;", "⪇");
            txt = Regex.Replace(txt, "&lneq;", "⪇");

            // "U+02A88", "GREATER-THAN AND SINGLE-LINE NOT EQUAL TO"
            txt = Regex.Replace(txt, "&#x0*?2A88;", "⪈");
            txt = Regex.Replace(txt, "&#0*?10888;", "⪈");
            txt = Regex.Replace(txt, "&gne;", "⪈");
            txt = Regex.Replace(txt, "&gneq;", "⪈");

            // "U+02A89", "LESS-THAN AND NOT APPROXIMATE"
            txt = Regex.Replace(txt, "&#x0*?2A89;", "⪉");
            txt = Regex.Replace(txt, "&#0*?10889;", "⪉");
            txt = Regex.Replace(txt, "&lnap;", "⪉");
            txt = Regex.Replace(txt, "&lnapprox;", "⪉");

            // "U+02A8A", "GREATER-THAN AND NOT APPROXIMATE"
            txt = Regex.Replace(txt, "&#x0*?2A8A;", "⪊");
            txt = Regex.Replace(txt, "&#0*?10890;", "⪊");
            txt = Regex.Replace(txt, "&gnap;", "⪊");
            txt = Regex.Replace(txt, "&gnapprox;", "⪊");

            // "U+02A8B", "LESS-THAN ABOVE DOUBLE-LINE EQUAL ABOVE GREATER-THAN"
            txt = Regex.Replace(txt, "&#x0*?2A8B;", "⪋");
            txt = Regex.Replace(txt, "&#0*?10891;", "⪋");
            txt = Regex.Replace(txt, "&lEg;", "⪋");
            txt = Regex.Replace(txt, "&lesseqqgtr;", "⪋");

            // "U+02A8C", "GREATER-THAN ABOVE DOUBLE-LINE EQUAL ABOVE LESS-THAN"
            txt = Regex.Replace(txt, "&#x0*?2A8C;", "⪌");
            txt = Regex.Replace(txt, "&#0*?10892;", "⪌");
            txt = Regex.Replace(txt, "&gEl;", "⪌");
            txt = Regex.Replace(txt, "&gtreqqless;", "⪌");

            // "U+02A8D", "LESS-THAN ABOVE SIMILAR OR EQUAL"
            txt = Regex.Replace(txt, "&#x0*?2A8D;", "⪍");
            txt = Regex.Replace(txt, "&#0*?10893;", "⪍");
            txt = Regex.Replace(txt, "&lsime;", "⪍");

            // "U+02A8E", "GREATER-THAN ABOVE SIMILAR OR EQUAL"
            txt = Regex.Replace(txt, "&#x0*?2A8E;", "⪎");
            txt = Regex.Replace(txt, "&#0*?10894;", "⪎");
            txt = Regex.Replace(txt, "&gsime;", "⪎");

            // "U+02A8F", "LESS-THAN ABOVE SIMILAR ABOVE GREATER-THAN"
            txt = Regex.Replace(txt, "&#x0*?2A8F;", "⪏");
            txt = Regex.Replace(txt, "&#0*?10895;", "⪏");
            txt = Regex.Replace(txt, "&lsimg;", "⪏");

            // "U+02A90", "GREATER-THAN ABOVE SIMILAR ABOVE LESS-THAN"
            txt = Regex.Replace(txt, "&#x0*?2A90;", "⪐");
            txt = Regex.Replace(txt, "&#0*?10896;", "⪐");
            txt = Regex.Replace(txt, "&gsiml;", "⪐");

            // "U+02A91", "LESS-THAN ABOVE GREATER-THAN ABOVE DOUBLE-LINE EQUAL"
            txt = Regex.Replace(txt, "&#x0*?2A91;", "⪑");
            txt = Regex.Replace(txt, "&#0*?10897;", "⪑");
            txt = Regex.Replace(txt, "&lgE;", "⪑");

            // "U+02A92", "GREATER-THAN ABOVE LESS-THAN ABOVE DOUBLE-LINE EQUAL"
            txt = Regex.Replace(txt, "&#x0*?2A92;", "⪒");
            txt = Regex.Replace(txt, "&#0*?10898;", "⪒");
            txt = Regex.Replace(txt, "&glE;", "⪒");

            // "U+02A93", "LESS-THAN ABOVE SLANTED EQUAL ABOVE GREATER-THAN ABOVE SLANTED EQUAL"
            txt = Regex.Replace(txt, "&#x0*?2A93;", "⪓");
            txt = Regex.Replace(txt, "&#0*?10899;", "⪓");
            txt = Regex.Replace(txt, "&lesges;", "⪓");

            // "U+02A94", "GREATER-THAN ABOVE SLANTED EQUAL ABOVE LESS-THAN ABOVE SLANTED EQUAL"
            txt = Regex.Replace(txt, "&#x0*?2A94;", "⪔");
            txt = Regex.Replace(txt, "&#0*?10900;", "⪔");
            txt = Regex.Replace(txt, "&gesles;", "⪔");

            // "U+02A95", "SLANTED EQUAL TO OR LESS-THAN"
            txt = Regex.Replace(txt, "&#x0*?2A95;", "⪕");
            txt = Regex.Replace(txt, "&#0*?10901;", "⪕");
            txt = Regex.Replace(txt, "&els;", "⪕");
            txt = Regex.Replace(txt, "&eqslantless;", "⪕");

            // "U+02A96", "SLANTED EQUAL TO OR GREATER-THAN"
            txt = Regex.Replace(txt, "&#x0*?2A96;", "⪖");
            txt = Regex.Replace(txt, "&#0*?10902;", "⪖");
            txt = Regex.Replace(txt, "&egs;", "⪖");
            txt = Regex.Replace(txt, "&eqslantgtr;", "⪖");

            // "U+02A97", "SLANTED EQUAL TO OR LESS-THAN WITH DOT INSIDE"
            txt = Regex.Replace(txt, "&#x0*?2A97;", "⪗");
            txt = Regex.Replace(txt, "&#0*?10903;", "⪗");
            txt = Regex.Replace(txt, "&elsdot;", "⪗");

            // "U+02A98", "SLANTED EQUAL TO OR GREATER-THAN WITH DOT INSIDE"
            txt = Regex.Replace(txt, "&#x0*?2A98;", "⪘");
            txt = Regex.Replace(txt, "&#0*?10904;", "⪘");
            txt = Regex.Replace(txt, "&egsdot;", "⪘");

            // "U+02A99", "DOUBLE-LINE EQUAL TO OR LESS-THAN"
            txt = Regex.Replace(txt, "&#x0*?2A99;", "⪙");
            txt = Regex.Replace(txt, "&#0*?10905;", "⪙");
            txt = Regex.Replace(txt, "&el;", "⪙");

            // "U+02A9A", "DOUBLE-LINE EQUAL TO OR GREATER-THAN"
            txt = Regex.Replace(txt, "&#x0*?2A9A;", "⪚");
            txt = Regex.Replace(txt, "&#0*?10906;", "⪚");
            txt = Regex.Replace(txt, "&eg;", "⪚");

            // "U+02A9D", "SIMILAR OR LESS-THAN"
            txt = Regex.Replace(txt, "&#x0*?2A9D;", "⪝");
            txt = Regex.Replace(txt, "&#0*?10909;", "⪝");
            txt = Regex.Replace(txt, "&siml;", "⪝");

            // "U+02A9E", "SIMILAR OR GREATER-THAN"
            txt = Regex.Replace(txt, "&#x0*?2A9E;", "⪞");
            txt = Regex.Replace(txt, "&#0*?10910;", "⪞");
            txt = Regex.Replace(txt, "&simg;", "⪞");

            // "U+02A9F", "SIMILAR ABOVE LESS-THAN ABOVE EQUALS SIGN"
            txt = Regex.Replace(txt, "&#x0*?2A9F;", "⪟");
            txt = Regex.Replace(txt, "&#0*?10911;", "⪟");
            txt = Regex.Replace(txt, "&simlE;", "⪟");

            // "U+02AA0", "SIMILAR ABOVE GREATER-THAN ABOVE EQUALS SIGN"
            txt = Regex.Replace(txt, "&#x0*?2AA0;", "⪠");
            txt = Regex.Replace(txt, "&#0*?10912;", "⪠");
            txt = Regex.Replace(txt, "&simgE;", "⪠");

            // "U+02AA1", "DOUBLE NESTED LESS-THAN"
            txt = Regex.Replace(txt, "&#x0*?2AA1;", "⪡");
            txt = Regex.Replace(txt, "&#0*?10913;", "⪡");
            txt = Regex.Replace(txt, "&LessLess;", "⪡");

            // "U+02AA2", "DOUBLE NESTED GREATER-THAN"
            txt = Regex.Replace(txt, "&#x0*?2AA2;", "⪢");
            txt = Regex.Replace(txt, "&#0*?10914;", "⪢");
            txt = Regex.Replace(txt, "&GreaterGreater;", "⪢");

            // "U+02AA4", "GREATER-THAN OVERLAPPING LESS-THAN"
            txt = Regex.Replace(txt, "&#x0*?2AA4;", "⪤");
            txt = Regex.Replace(txt, "&#0*?10916;", "⪤");
            txt = Regex.Replace(txt, "&glj;", "⪤");

            // "U+02AA5", "GREATER-THAN BESIDE LESS-THAN"
            txt = Regex.Replace(txt, "&#x0*?2AA5;", "⪥");
            txt = Regex.Replace(txt, "&#0*?10917;", "⪥");
            txt = Regex.Replace(txt, "&gla;", "⪥");

            // "U+02AA6", "LESS-THAN CLOSED BY CURVE"
            txt = Regex.Replace(txt, "&#x0*?2AA6;", "⪦");
            txt = Regex.Replace(txt, "&#0*?10918;", "⪦");
            txt = Regex.Replace(txt, "&ltcc;", "⪦");

            // "U+02AA7", "GREATER-THAN CLOSED BY CURVE"
            txt = Regex.Replace(txt, "&#x0*?2AA7;", "⪧");
            txt = Regex.Replace(txt, "&#0*?10919;", "⪧");
            txt = Regex.Replace(txt, "&gtcc;", "⪧");

            // "U+02AA8", "LESS-THAN CLOSED BY CURVE ABOVE SLANTED EQUAL"
            txt = Regex.Replace(txt, "&#x0*?2AA8;", "⪨");
            txt = Regex.Replace(txt, "&#0*?10920;", "⪨");
            txt = Regex.Replace(txt, "&lescc;", "⪨");

            // "U+02AA9", "GREATER-THAN CLOSED BY CURVE ABOVE SLANTED EQUAL"
            txt = Regex.Replace(txt, "&#x0*?2AA9;", "⪩");
            txt = Regex.Replace(txt, "&#0*?10921;", "⪩");
            txt = Regex.Replace(txt, "&gescc;", "⪩");

            // "U+02AAA", "SMALLER THAN"
            txt = Regex.Replace(txt, "&#x0*?2AAA;", "⪪");
            txt = Regex.Replace(txt, "&#0*?10922;", "⪪");
            txt = Regex.Replace(txt, "&smt;", "⪪");

            // "U+02AAB", "LARGER THAN"
            txt = Regex.Replace(txt, "&#x0*?2AAB;", "⪫");
            txt = Regex.Replace(txt, "&#0*?10923;", "⪫");
            txt = Regex.Replace(txt, "&lat;", "⪫");

            // "U+02AAC", "SMALLER THAN OR EQUAL TO"
            txt = Regex.Replace(txt, "&#x0*?2AAC;", "⪬");
            txt = Regex.Replace(txt, "&#0*?10924;", "⪬");
            txt = Regex.Replace(txt, "&smte;", "⪬");

            // "U+02AAD", "LARGER THAN OR EQUAL TO"
            txt = Regex.Replace(txt, "&#x0*?2AAD;", "⪭");
            txt = Regex.Replace(txt, "&#0*?10925;", "⪭");
            txt = Regex.Replace(txt, "&late;", "⪭");

            // "U+02AAE", "EQUALS SIGN WITH BUMPY ABOVE"
            txt = Regex.Replace(txt, "&#x0*?2AAE;", "⪮");
            txt = Regex.Replace(txt, "&#0*?10926;", "⪮");
            txt = Regex.Replace(txt, "&bumpE;", "⪮");

            // "U+02AAF", "PRECEDES ABOVE SINGLE-LINE EQUALS SIGN"
            txt = Regex.Replace(txt, "&#x0*?2AAF;", "⪯");
            txt = Regex.Replace(txt, "&#0*?10927;", "⪯");
            txt = Regex.Replace(txt, "&pre;", "⪯");
            txt = Regex.Replace(txt, "&preceq;", "⪯");
            txt = Regex.Replace(txt, "&PrecedesEqual;", "⪯");

            // "U+02AB0", "SUCCEEDS ABOVE SINGLE-LINE EQUALS SIGN"
            txt = Regex.Replace(txt, "&#x0*?2AB0;", "⪰");
            txt = Regex.Replace(txt, "&#0*?10928;", "⪰");
            txt = Regex.Replace(txt, "&sce;", "⪰");
            txt = Regex.Replace(txt, "&succeq;", "⪰");
            txt = Regex.Replace(txt, "&SucceedsEqual;", "⪰");

            // "U+02AB3", "PRECEDES ABOVE EQUALS SIGN"
            txt = Regex.Replace(txt, "&#x0*?2AB3;", "⪳");
            txt = Regex.Replace(txt, "&#0*?10931;", "⪳");
            txt = Regex.Replace(txt, "&prE;", "⪳");

            // "U+02AB4", "SUCCEEDS ABOVE EQUALS SIGN"
            txt = Regex.Replace(txt, "&#x0*?2AB4;", "⪴");
            txt = Regex.Replace(txt, "&#0*?10932;", "⪴");
            txt = Regex.Replace(txt, "&scE;", "⪴");

            // "U+02AB5", "PRECEDES ABOVE NOT EQUAL TO"
            txt = Regex.Replace(txt, "&#x0*?2AB5;", "⪵");
            txt = Regex.Replace(txt, "&#0*?10933;", "⪵");
            txt = Regex.Replace(txt, "&prnE;", "⪵");
            txt = Regex.Replace(txt, "&precneqq;", "⪵");

            // "U+02AB6", "SUCCEEDS ABOVE NOT EQUAL TO"
            txt = Regex.Replace(txt, "&#x0*?2AB6;", "⪶");
            txt = Regex.Replace(txt, "&#0*?10934;", "⪶");
            txt = Regex.Replace(txt, "&scnE;", "⪶");
            txt = Regex.Replace(txt, "&succneqq;", "⪶");

            // "U+02AB7", "PRECEDES ABOVE ALMOST EQUAL TO"
            txt = Regex.Replace(txt, "&#x0*?2AB7;", "⪷");
            txt = Regex.Replace(txt, "&#0*?10935;", "⪷");
            txt = Regex.Replace(txt, "&prap;", "⪷");
            txt = Regex.Replace(txt, "&precapprox;", "⪷");

            // "U+02AB8", "SUCCEEDS ABOVE ALMOST EQUAL TO"
            txt = Regex.Replace(txt, "&#x0*?2AB8;", "⪸");
            txt = Regex.Replace(txt, "&#0*?10936;", "⪸");
            txt = Regex.Replace(txt, "&scap;", "⪸");
            txt = Regex.Replace(txt, "&succapprox;", "⪸");

            // "U+02AB9", "PRECEDES ABOVE NOT ALMOST EQUAL TO"
            txt = Regex.Replace(txt, "&#x0*?2AB9;", "⪹");
            txt = Regex.Replace(txt, "&#0*?10937;", "⪹");
            txt = Regex.Replace(txt, "&prnap;", "⪹");
            txt = Regex.Replace(txt, "&precnapprox;", "⪹");

            // "U+02ABA", "SUCCEEDS ABOVE NOT ALMOST EQUAL TO"
            txt = Regex.Replace(txt, "&#x0*?2ABA;", "⪺");
            txt = Regex.Replace(txt, "&#0*?10938;", "⪺");
            txt = Regex.Replace(txt, "&scnap;", "⪺");
            txt = Regex.Replace(txt, "&succnapprox;", "⪺");

            // "U+02ABB", "DOUBLE PRECEDES"
            txt = Regex.Replace(txt, "&#x0*?2ABB;", "⪻");
            txt = Regex.Replace(txt, "&#0*?10939;", "⪻");
            txt = Regex.Replace(txt, "&Pr;", "⪻");

            // "U+02ABC", "DOUBLE SUCCEEDS"
            txt = Regex.Replace(txt, "&#x0*?2ABC;", "⪼");
            txt = Regex.Replace(txt, "&#0*?10940;", "⪼");
            txt = Regex.Replace(txt, "&Sc;", "⪼");

            // "U+02ABD", "SUBSET WITH DOT"
            txt = Regex.Replace(txt, "&#x0*?2ABD;", "⪽");
            txt = Regex.Replace(txt, "&#0*?10941;", "⪽");
            txt = Regex.Replace(txt, "&subdot;", "⪽");

            // "U+02ABE", "SUPERSET WITH DOT"
            txt = Regex.Replace(txt, "&#x0*?2ABE;", "⪾");
            txt = Regex.Replace(txt, "&#0*?10942;", "⪾");
            txt = Regex.Replace(txt, "&supdot;", "⪾");

            // "U+02ABF", "SUBSET WITH PLUS SIGN BELOW"
            txt = Regex.Replace(txt, "&#x0*?2ABF;", "⪿");
            txt = Regex.Replace(txt, "&#0*?10943;", "⪿");
            txt = Regex.Replace(txt, "&subplus;", "⪿");

            // "U+02AC0", "SUPERSET WITH PLUS SIGN BELOW"
            txt = Regex.Replace(txt, "&#x0*?2AC0;", "⫀");
            txt = Regex.Replace(txt, "&#0*?10944;", "⫀");
            txt = Regex.Replace(txt, "&supplus;", "⫀");

            // "U+02AC1", "SUBSET WITH MULTIPLICATION SIGN BELOW"
            txt = Regex.Replace(txt, "&#x0*?2AC1;", "⫁");
            txt = Regex.Replace(txt, "&#0*?10945;", "⫁");
            txt = Regex.Replace(txt, "&submult;", "⫁");

            // "U+02AC2", "SUPERSET WITH MULTIPLICATION SIGN BELOW"
            txt = Regex.Replace(txt, "&#x0*?2AC2;", "⫂");
            txt = Regex.Replace(txt, "&#0*?10946;", "⫂");
            txt = Regex.Replace(txt, "&supmult;", "⫂");

            // "U+02AC3", "SUBSET OF OR EQUAL TO WITH DOT ABOVE"
            txt = Regex.Replace(txt, "&#x0*?2AC3;", "⫃");
            txt = Regex.Replace(txt, "&#0*?10947;", "⫃");
            txt = Regex.Replace(txt, "&subedot;", "⫃");

            // "U+02AC4", "SUPERSET OF OR EQUAL TO WITH DOT ABOVE"
            txt = Regex.Replace(txt, "&#x0*?2AC4;", "⫄");
            txt = Regex.Replace(txt, "&#0*?10948;", "⫄");
            txt = Regex.Replace(txt, "&supedot;", "⫄");

            // "U+02AC5", "SUBSET OF ABOVE EQUALS SIGN"
            txt = Regex.Replace(txt, "&#x0*?2AC5;", "⫅");
            txt = Regex.Replace(txt, "&#0*?10949;", "⫅");
            txt = Regex.Replace(txt, "&subE;", "⫅");
            txt = Regex.Replace(txt, "&subseteqq;", "⫅");

            // "U+02AC6", "SUPERSET OF ABOVE EQUALS SIGN"
            txt = Regex.Replace(txt, "&#x0*?2AC6;", "⫆");
            txt = Regex.Replace(txt, "&#0*?10950;", "⫆");
            txt = Regex.Replace(txt, "&supE;", "⫆");
            txt = Regex.Replace(txt, "&supseteqq;", "⫆");

            // "U+02AC7", "SUBSET OF ABOVE TILDE OPERATOR"
            txt = Regex.Replace(txt, "&#x0*?2AC7;", "⫇");
            txt = Regex.Replace(txt, "&#0*?10951;", "⫇");
            txt = Regex.Replace(txt, "&subsim;", "⫇");

            // "U+02AC8", "SUPERSET OF ABOVE TILDE OPERATOR"
            txt = Regex.Replace(txt, "&#x0*?2AC8;", "⫈");
            txt = Regex.Replace(txt, "&#0*?10952;", "⫈");
            txt = Regex.Replace(txt, "&supsim;", "⫈");

            // "U+02ACB", "SUBSET OF ABOVE NOT EQUAL TO"
            txt = Regex.Replace(txt, "&#x0*?2ACB;", "⫋");
            txt = Regex.Replace(txt, "&#0*?10955;", "⫋");
            txt = Regex.Replace(txt, "&subnE;", "⫋");
            txt = Regex.Replace(txt, "&subsetneqq;", "⫋");

            // "U+02ACC", "SUPERSET OF ABOVE NOT EQUAL TO"
            txt = Regex.Replace(txt, "&#x0*?2ACC;", "⫌");
            txt = Regex.Replace(txt, "&#0*?10956;", "⫌");
            txt = Regex.Replace(txt, "&supnE;", "⫌");
            txt = Regex.Replace(txt, "&supsetneqq;", "⫌");

            // "U+02ACF", "CLOSED SUBSET"
            txt = Regex.Replace(txt, "&#x0*?2ACF;", "⫏");
            txt = Regex.Replace(txt, "&#0*?10959;", "⫏");
            txt = Regex.Replace(txt, "&csub;", "⫏");

            // "U+02AD0", "CLOSED SUPERSET"
            txt = Regex.Replace(txt, "&#x0*?2AD0;", "⫐");
            txt = Regex.Replace(txt, "&#0*?10960;", "⫐");
            txt = Regex.Replace(txt, "&csup;", "⫐");

            // "U+02AD1", "CLOSED SUBSET OR EQUAL TO"
            txt = Regex.Replace(txt, "&#x0*?2AD1;", "⫑");
            txt = Regex.Replace(txt, "&#0*?10961;", "⫑");
            txt = Regex.Replace(txt, "&csube;", "⫑");

            // "U+02AD2", "CLOSED SUPERSET OR EQUAL TO"
            txt = Regex.Replace(txt, "&#x0*?2AD2;", "⫒");
            txt = Regex.Replace(txt, "&#0*?10962;", "⫒");
            txt = Regex.Replace(txt, "&csupe;", "⫒");

            // "U+02AD3", "SUBSET ABOVE SUPERSET"
            txt = Regex.Replace(txt, "&#x0*?2AD3;", "⫓");
            txt = Regex.Replace(txt, "&#0*?10963;", "⫓");
            txt = Regex.Replace(txt, "&subsup;", "⫓");

            // "U+02AD4", "SUPERSET ABOVE SUBSET"
            txt = Regex.Replace(txt, "&#x0*?2AD4;", "⫔");
            txt = Regex.Replace(txt, "&#0*?10964;", "⫔");
            txt = Regex.Replace(txt, "&supsub;", "⫔");

            // "U+02AD5", "SUBSET ABOVE SUBSET"
            txt = Regex.Replace(txt, "&#x0*?2AD5;", "⫕");
            txt = Regex.Replace(txt, "&#0*?10965;", "⫕");
            txt = Regex.Replace(txt, "&subsub;", "⫕");

            // "U+02AD6", "SUPERSET ABOVE SUPERSET"
            txt = Regex.Replace(txt, "&#x0*?2AD6;", "⫖");
            txt = Regex.Replace(txt, "&#0*?10966;", "⫖");
            txt = Regex.Replace(txt, "&supsup;", "⫖");

            // "U+02AD7", "SUPERSET BESIDE SUBSET"
            txt = Regex.Replace(txt, "&#x0*?2AD7;", "⫗");
            txt = Regex.Replace(txt, "&#0*?10967;", "⫗");
            txt = Regex.Replace(txt, "&suphsub;", "⫗");

            // "U+02AD8", "SUPERSET BESIDE AND JOINED BY DASH WITH SUBSET"
            txt = Regex.Replace(txt, "&#x0*?2AD8;", "⫘");
            txt = Regex.Replace(txt, "&#0*?10968;", "⫘");
            txt = Regex.Replace(txt, "&supdsub;", "⫘");

            // "U+02AD9", "ELEMENT OF OPENING DOWNWARDS"
            txt = Regex.Replace(txt, "&#x0*?2AD9;", "⫙");
            txt = Regex.Replace(txt, "&#0*?10969;", "⫙");
            txt = Regex.Replace(txt, "&forkv;", "⫙");

            // "U+02ADA", "PITCHFORK WITH TEE TOP"
            txt = Regex.Replace(txt, "&#x0*?2ADA;", "⫚");
            txt = Regex.Replace(txt, "&#0*?10970;", "⫚");
            txt = Regex.Replace(txt, "&topfork;", "⫚");

            // "U+02ADB", "TRANSVERSAL INTERSECTION"
            txt = Regex.Replace(txt, "&#x0*?2ADB;", "⫛");
            txt = Regex.Replace(txt, "&#0*?10971;", "⫛");
            txt = Regex.Replace(txt, "&mlcp;", "⫛");

            // "U+02AE4", "VERTICAL BAR DOUBLE LEFT TURNSTILE"
            txt = Regex.Replace(txt, "&#x0*?2AE4;", "⫤");
            txt = Regex.Replace(txt, "&#0*?10980;", "⫤");
            txt = Regex.Replace(txt, "&Dashv;", "⫤");
            txt = Regex.Replace(txt, "&DoubleLeftTee;", "⫤");

            // "U+02AE6", "LONG DASH FROM LEFT MEMBER OF DOUBLE VERTICAL"
            txt = Regex.Replace(txt, "&#x0*?2AE6;", "⫦");
            txt = Regex.Replace(txt, "&#0*?10982;", "⫦");
            txt = Regex.Replace(txt, "&Vdashl;", "⫦");

            // "U+02AE7", "SHORT DOWN TACK WITH OVERBAR"
            txt = Regex.Replace(txt, "&#x0*?2AE7;", "⫧");
            txt = Regex.Replace(txt, "&#0*?10983;", "⫧");
            txt = Regex.Replace(txt, "&Barv;", "⫧");

            // "U+02AE8", "SHORT UP TACK WITH UNDERBAR"
            txt = Regex.Replace(txt, "&#x0*?2AE8;", "⫨");
            txt = Regex.Replace(txt, "&#0*?10984;", "⫨");
            txt = Regex.Replace(txt, "&vBar;", "⫨");

            // "U+02AE9", "SHORT UP TACK ABOVE SHORT DOWN TACK"
            txt = Regex.Replace(txt, "&#x0*?2AE9;", "⫩");
            txt = Regex.Replace(txt, "&#0*?10985;", "⫩");
            txt = Regex.Replace(txt, "&vBarv;", "⫩");

            // "U+02AEB", "DOUBLE UP TACK"
            txt = Regex.Replace(txt, "&#x0*?2AEB;", "⫫");
            txt = Regex.Replace(txt, "&#0*?10987;", "⫫");
            txt = Regex.Replace(txt, "&Vbar;", "⫫");

            // "U+02AEC", "DOUBLE STROKE NOT SIGN"
            txt = Regex.Replace(txt, "&#x0*?2AEC;", "⫬");
            txt = Regex.Replace(txt, "&#0*?10988;", "⫬");
            txt = Regex.Replace(txt, "&Not;", "⫬");

            // "U+02AED", "REVERSED DOUBLE STROKE NOT SIGN"
            txt = Regex.Replace(txt, "&#x0*?2AED;", "⫭");
            txt = Regex.Replace(txt, "&#0*?10989;", "⫭");
            txt = Regex.Replace(txt, "&bNot;", "⫭");

            // "U+02AEE", "DOES NOT DIVIDE WITH REVERSED NEGATION SLASH"
            txt = Regex.Replace(txt, "&#x0*?2AEE;", "⫮");
            txt = Regex.Replace(txt, "&#0*?10990;", "⫮");
            txt = Regex.Replace(txt, "&rnmid;", "⫮");

            // "U+02AEF", "VERTICAL LINE WITH CIRCLE ABOVE"
            txt = Regex.Replace(txt, "&#x0*?2AEF;", "⫯");
            txt = Regex.Replace(txt, "&#0*?10991;", "⫯");
            txt = Regex.Replace(txt, "&cirmid;", "⫯");

            // "U+02AF0", "VERTICAL LINE WITH CIRCLE BELOW"
            txt = Regex.Replace(txt, "&#x0*?2AF0;", "⫰");
            txt = Regex.Replace(txt, "&#0*?10992;", "⫰");
            txt = Regex.Replace(txt, "&midcir;", "⫰");

            // "U+02AF1", "DOWN TACK WITH CIRCLE BELOW"
            txt = Regex.Replace(txt, "&#x0*?2AF1;", "⫱");
            txt = Regex.Replace(txt, "&#0*?10993;", "⫱");
            txt = Regex.Replace(txt, "&topcir;", "⫱");

            // "U+02AF2", "PARALLEL WITH HORIZONTAL STROKE"
            txt = Regex.Replace(txt, "&#x0*?2AF2;", "⫲");
            txt = Regex.Replace(txt, "&#0*?10994;", "⫲");
            txt = Regex.Replace(txt, "&nhpar;", "⫲");

            // "U+02AF3", "PARALLEL WITH TILDE OPERATOR"
            txt = Regex.Replace(txt, "&#x0*?2AF3;", "⫳");
            txt = Regex.Replace(txt, "&#0*?10995;", "⫳");
            txt = Regex.Replace(txt, "&parsim;", "⫳");

            // "U+02AFD", "DOUBLE SOLIDUS OPERATOR"
            txt = Regex.Replace(txt, "&#x0*?2AFD;", "⫽");
            txt = Regex.Replace(txt, "&#0*?11005;", "⫽");
            txt = Regex.Replace(txt, "&parsl;", "⫽");

            // "U+0FB00", "LATIN SMALL LIGATURE FF"
            txt = Regex.Replace(txt, "&#x0*?FB00;", "ﬀ");
            txt = Regex.Replace(txt, "&#0*?64256;", "ﬀ");
            txt = Regex.Replace(txt, "&fflig;", "ﬀ");

            // "U+0FB01", "LATIN SMALL LIGATURE FI"
            txt = Regex.Replace(txt, "&#x0*?FB01;", "ﬁ");
            txt = Regex.Replace(txt, "&#0*?64257;", "ﬁ");
            txt = Regex.Replace(txt, "&filig;", "ﬁ");

            // "U+0FB02", "LATIN SMALL LIGATURE FL"
            txt = Regex.Replace(txt, "&#x0*?FB02;", "ﬂ");
            txt = Regex.Replace(txt, "&#0*?64258;", "ﬂ");
            txt = Regex.Replace(txt, "&fllig;", "ﬂ");

            // "U+0FB03", "LATIN SMALL LIGATURE FFI"
            txt = Regex.Replace(txt, "&#x0*?FB03;", "ﬃ");
            txt = Regex.Replace(txt, "&#0*?64259;", "ﬃ");
            txt = Regex.Replace(txt, "&ffilig;", "ﬃ");

            // "U+0FB04", "LATIN SMALL LIGATURE FFL"
            txt = Regex.Replace(txt, "&#x0*?FB04;", "ﬄ");
            txt = Regex.Replace(txt, "&#0*?64260;", "ﬄ");
            txt = Regex.Replace(txt, "&ffllig;", "ﬄ");

            // "U+1D49C", "MATHEMATICAL SCRIPT CAPITAL A"
            txt = Regex.Replace(txt, "&#x0*?1D49C;", "𝒜");
            txt = Regex.Replace(txt, "&#0*?119964;", "𝒜");
            txt = Regex.Replace(txt, "&Ascr;", "𝒜");

            // "U+1D49E", "MATHEMATICAL SCRIPT CAPITAL C"
            txt = Regex.Replace(txt, "&#x0*?1D49E;", "𝒞");
            txt = Regex.Replace(txt, "&#0*?119966;", "𝒞");
            txt = Regex.Replace(txt, "&Cscr;", "𝒞");

            // "U+1D49F", "MATHEMATICAL SCRIPT CAPITAL D"
            txt = Regex.Replace(txt, "&#x0*?1D49F;", "𝒟");
            txt = Regex.Replace(txt, "&#0*?119967;", "𝒟");
            txt = Regex.Replace(txt, "&Dscr;", "𝒟");

            // "U+1D4A2", "MATHEMATICAL SCRIPT CAPITAL G"
            txt = Regex.Replace(txt, "&#x0*?1D4A2;", "𝒢");
            txt = Regex.Replace(txt, "&#0*?119970;", "𝒢");
            txt = Regex.Replace(txt, "&Gscr;", "𝒢");

            // "U+1D4A5", "MATHEMATICAL SCRIPT CAPITAL J"
            txt = Regex.Replace(txt, "&#x0*?1D4A5;", "𝒥");
            txt = Regex.Replace(txt, "&#0*?119973;", "𝒥");
            txt = Regex.Replace(txt, "&Jscr;", "𝒥");

            // "U+1D4A6", "MATHEMATICAL SCRIPT CAPITAL K"
            txt = Regex.Replace(txt, "&#x0*?1D4A6;", "𝒦");
            txt = Regex.Replace(txt, "&#0*?119974;", "𝒦");
            txt = Regex.Replace(txt, "&Kscr;", "𝒦");

            // "U+1D4A9", "MATHEMATICAL SCRIPT CAPITAL N"
            txt = Regex.Replace(txt, "&#x0*?1D4A9;", "𝒩");
            txt = Regex.Replace(txt, "&#0*?119977;", "𝒩");
            txt = Regex.Replace(txt, "&Nscr;", "𝒩");

            // "U+1D4AA", "MATHEMATICAL SCRIPT CAPITAL O"
            txt = Regex.Replace(txt, "&#x0*?1D4AA;", "𝒪");
            txt = Regex.Replace(txt, "&#0*?119978;", "𝒪");
            txt = Regex.Replace(txt, "&Oscr;", "𝒪");

            // "U+1D4AB", "MATHEMATICAL SCRIPT CAPITAL P"
            txt = Regex.Replace(txt, "&#x0*?1D4AB;", "𝒫");
            txt = Regex.Replace(txt, "&#0*?119979;", "𝒫");
            txt = Regex.Replace(txt, "&Pscr;", "𝒫");

            // "U+1D4AC", "MATHEMATICAL SCRIPT CAPITAL Q"
            txt = Regex.Replace(txt, "&#x0*?1D4AC;", "𝒬");
            txt = Regex.Replace(txt, "&#0*?119980;", "𝒬");
            txt = Regex.Replace(txt, "&Qscr;", "𝒬");

            // "U+1D4AE", "MATHEMATICAL SCRIPT CAPITAL S"
            txt = Regex.Replace(txt, "&#x0*?1D4AE;", "𝒮");
            txt = Regex.Replace(txt, "&#0*?119982;", "𝒮");
            txt = Regex.Replace(txt, "&Sscr;", "𝒮");

            // "U+1D4AF", "MATHEMATICAL SCRIPT CAPITAL T"
            txt = Regex.Replace(txt, "&#x0*?1D4AF;", "𝒯");
            txt = Regex.Replace(txt, "&#0*?119983;", "𝒯");
            txt = Regex.Replace(txt, "&Tscr;", "𝒯");

            // "U+1D4B0", "MATHEMATICAL SCRIPT CAPITAL U"
            txt = Regex.Replace(txt, "&#x0*?1D4B0;", "𝒰");
            txt = Regex.Replace(txt, "&#0*?119984;", "𝒰");
            txt = Regex.Replace(txt, "&Uscr;", "𝒰");

            // "U+1D4B1", "MATHEMATICAL SCRIPT CAPITAL V"
            txt = Regex.Replace(txt, "&#x0*?1D4B1;", "𝒱");
            txt = Regex.Replace(txt, "&#0*?119985;", "𝒱");
            txt = Regex.Replace(txt, "&Vscr;", "𝒱");

            // "U+1D4B2", "MATHEMATICAL SCRIPT CAPITAL W"
            txt = Regex.Replace(txt, "&#x0*?1D4B2;", "𝒲");
            txt = Regex.Replace(txt, "&#0*?119986;", "𝒲");
            txt = Regex.Replace(txt, "&Wscr;", "𝒲");

            // "U+1D4B3", "MATHEMATICAL SCRIPT CAPITAL X"
            txt = Regex.Replace(txt, "&#x0*?1D4B3;", "𝒳");
            txt = Regex.Replace(txt, "&#0*?119987;", "𝒳");
            txt = Regex.Replace(txt, "&Xscr;", "𝒳");

            // "U+1D4B4", "MATHEMATICAL SCRIPT CAPITAL Y"
            txt = Regex.Replace(txt, "&#x0*?1D4B4;", "𝒴");
            txt = Regex.Replace(txt, "&#0*?119988;", "𝒴");
            txt = Regex.Replace(txt, "&Yscr;", "𝒴");

            // "U+1D4B5", "MATHEMATICAL SCRIPT CAPITAL Z"
            txt = Regex.Replace(txt, "&#x0*?1D4B5;", "𝒵");
            txt = Regex.Replace(txt, "&#0*?119989;", "𝒵");
            txt = Regex.Replace(txt, "&Zscr;", "𝒵");

            // "U+1D4B6", "MATHEMATICAL SCRIPT SMALL A"
            txt = Regex.Replace(txt, "&#x0*?1D4B6;", "𝒶");
            txt = Regex.Replace(txt, "&#0*?119990;", "𝒶");
            txt = Regex.Replace(txt, "&ascr;", "𝒶");

            // "U+1D4B7", "MATHEMATICAL SCRIPT SMALL B"
            txt = Regex.Replace(txt, "&#x0*?1D4B7;", "𝒷");
            txt = Regex.Replace(txt, "&#0*?119991;", "𝒷");
            txt = Regex.Replace(txt, "&bscr;", "𝒷");

            // "U+1D4B8", "MATHEMATICAL SCRIPT SMALL C"
            txt = Regex.Replace(txt, "&#x0*?1D4B8;", "𝒸");
            txt = Regex.Replace(txt, "&#0*?119992;", "𝒸");
            txt = Regex.Replace(txt, "&cscr;", "𝒸");

            // "U+1D4B9", "MATHEMATICAL SCRIPT SMALL D"
            txt = Regex.Replace(txt, "&#x0*?1D4B9;", "𝒹");
            txt = Regex.Replace(txt, "&#0*?119993;", "𝒹");
            txt = Regex.Replace(txt, "&dscr;", "𝒹");

            // "U+1D4BB", "MATHEMATICAL SCRIPT SMALL F"
            txt = Regex.Replace(txt, "&#x0*?1D4BB;", "𝒻");
            txt = Regex.Replace(txt, "&#0*?119995;", "𝒻");
            txt = Regex.Replace(txt, "&fscr;", "𝒻");

            // "U+1D4BD", "MATHEMATICAL SCRIPT SMALL H"
            txt = Regex.Replace(txt, "&#x0*?1D4BD;", "𝒽");
            txt = Regex.Replace(txt, "&#0*?119997;", "𝒽");
            txt = Regex.Replace(txt, "&hscr;", "𝒽");

            // "U+1D4BE", "MATHEMATICAL SCRIPT SMALL I"
            txt = Regex.Replace(txt, "&#x0*?1D4BE;", "𝒾");
            txt = Regex.Replace(txt, "&#0*?119998;", "𝒾");
            txt = Regex.Replace(txt, "&iscr;", "𝒾");

            // "U+1D4BF", "MATHEMATICAL SCRIPT SMALL J"
            txt = Regex.Replace(txt, "&#x0*?1D4BF;", "𝒿");
            txt = Regex.Replace(txt, "&#0*?119999;", "𝒿");
            txt = Regex.Replace(txt, "&jscr;", "𝒿");

            // "U+1D4C0", "MATHEMATICAL SCRIPT SMALL K"
            txt = Regex.Replace(txt, "&#x0*?1D4C0;", "𝓀");
            txt = Regex.Replace(txt, "&#0*?120000;", "𝓀");
            txt = Regex.Replace(txt, "&kscr;", "𝓀");

            // "U+1D4C1", "MATHEMATICAL SCRIPT SMALL L"
            txt = Regex.Replace(txt, "&#x0*?1D4C1;", "𝓁");
            txt = Regex.Replace(txt, "&#0*?120001;", "𝓁");
            txt = Regex.Replace(txt, "&lscr;", "𝓁");

            // "U+1D4C2", "MATHEMATICAL SCRIPT SMALL M"
            txt = Regex.Replace(txt, "&#x0*?1D4C2;", "𝓂");
            txt = Regex.Replace(txt, "&#0*?120002;", "𝓂");
            txt = Regex.Replace(txt, "&mscr;", "𝓂");

            // "U+1D4C3", "MATHEMATICAL SCRIPT SMALL N"
            txt = Regex.Replace(txt, "&#x0*?1D4C3;", "𝓃");
            txt = Regex.Replace(txt, "&#0*?120003;", "𝓃");
            txt = Regex.Replace(txt, "&nscr;", "𝓃");

            // "U+1D4C5", "MATHEMATICAL SCRIPT SMALL P"
            txt = Regex.Replace(txt, "&#x0*?1D4C5;", "𝓅");
            txt = Regex.Replace(txt, "&#0*?120005;", "𝓅");
            txt = Regex.Replace(txt, "&pscr;", "𝓅");

            // "U+1D4C6", "MATHEMATICAL SCRIPT SMALL Q"
            txt = Regex.Replace(txt, "&#x0*?1D4C6;", "𝓆");
            txt = Regex.Replace(txt, "&#0*?120006;", "𝓆");
            txt = Regex.Replace(txt, "&qscr;", "𝓆");

            // "U+1D4C7", "MATHEMATICAL SCRIPT SMALL R"
            txt = Regex.Replace(txt, "&#x0*?1D4C7;", "𝓇");
            txt = Regex.Replace(txt, "&#0*?120007;", "𝓇");
            txt = Regex.Replace(txt, "&rscr;", "𝓇");

            // "U+1D4C8", "MATHEMATICAL SCRIPT SMALL S"
            txt = Regex.Replace(txt, "&#x0*?1D4C8;", "𝓈");
            txt = Regex.Replace(txt, "&#0*?120008;", "𝓈");
            txt = Regex.Replace(txt, "&sscr;", "𝓈");

            // "U+1D4C9", "MATHEMATICAL SCRIPT SMALL T"
            txt = Regex.Replace(txt, "&#x0*?1D4C9;", "𝓉");
            txt = Regex.Replace(txt, "&#0*?120009;", "𝓉");
            txt = Regex.Replace(txt, "&tscr;", "𝓉");

            // "U+1D4CA", "MATHEMATICAL SCRIPT SMALL U"
            txt = Regex.Replace(txt, "&#x0*?1D4CA;", "𝓊");
            txt = Regex.Replace(txt, "&#0*?120010;", "𝓊");
            txt = Regex.Replace(txt, "&uscr;", "𝓊");

            // "U+1D4CB", "MATHEMATICAL SCRIPT SMALL V"
            txt = Regex.Replace(txt, "&#x0*?1D4CB;", "𝓋");
            txt = Regex.Replace(txt, "&#0*?120011;", "𝓋");
            txt = Regex.Replace(txt, "&vscr;", "𝓋");

            // "U+1D4CC", "MATHEMATICAL SCRIPT SMALL W"
            txt = Regex.Replace(txt, "&#x0*?1D4CC;", "𝓌");
            txt = Regex.Replace(txt, "&#0*?120012;", "𝓌");
            txt = Regex.Replace(txt, "&wscr;", "𝓌");

            // "U+1D4CD", "MATHEMATICAL SCRIPT SMALL X"
            txt = Regex.Replace(txt, "&#x0*?1D4CD;", "𝓍");
            txt = Regex.Replace(txt, "&#0*?120013;", "𝓍");
            txt = Regex.Replace(txt, "&xscr;", "𝓍");

            // "U+1D4CE", "MATHEMATICAL SCRIPT SMALL Y"
            txt = Regex.Replace(txt, "&#x0*?1D4CE;", "𝓎");
            txt = Regex.Replace(txt, "&#0*?120014;", "𝓎");
            txt = Regex.Replace(txt, "&yscr;", "𝓎");

            // "U+1D4CF", "MATHEMATICAL SCRIPT SMALL Z"
            txt = Regex.Replace(txt, "&#x0*?1D4CF;", "𝓏");
            txt = Regex.Replace(txt, "&#0*?120015;", "𝓏");
            txt = Regex.Replace(txt, "&zscr;", "𝓏");

            // "U+1D504", "MATHEMATICAL FRAKTUR CAPITAL A"
            txt = Regex.Replace(txt, "&#x0*?1D504;", "𝔄");
            txt = Regex.Replace(txt, "&#0*?120068;", "𝔄");
            txt = Regex.Replace(txt, "&Afr;", "𝔄");

            // "U+1D505", "MATHEMATICAL FRAKTUR CAPITAL B"
            txt = Regex.Replace(txt, "&#x0*?1D505;", "𝔅");
            txt = Regex.Replace(txt, "&#0*?120069;", "𝔅");
            txt = Regex.Replace(txt, "&Bfr;", "𝔅");

            // "U+1D507", "MATHEMATICAL FRAKTUR CAPITAL D"
            txt = Regex.Replace(txt, "&#x0*?1D507;", "𝔇");
            txt = Regex.Replace(txt, "&#0*?120071;", "𝔇");
            txt = Regex.Replace(txt, "&Dfr;", "𝔇");

            // "U+1D508", "MATHEMATICAL FRAKTUR CAPITAL E"
            txt = Regex.Replace(txt, "&#x0*?1D508;", "𝔈");
            txt = Regex.Replace(txt, "&#0*?120072;", "𝔈");
            txt = Regex.Replace(txt, "&Efr;", "𝔈");

            // "U+1D509", "MATHEMATICAL FRAKTUR CAPITAL F"
            txt = Regex.Replace(txt, "&#x0*?1D509;", "𝔉");
            txt = Regex.Replace(txt, "&#0*?120073;", "𝔉");
            txt = Regex.Replace(txt, "&Ffr;", "𝔉");

            // "U+1D50A", "MATHEMATICAL FRAKTUR CAPITAL G"
            txt = Regex.Replace(txt, "&#x0*?1D50A;", "𝔊");
            txt = Regex.Replace(txt, "&#0*?120074;", "𝔊");
            txt = Regex.Replace(txt, "&Gfr;", "𝔊");

            // "U+1D50D", "MATHEMATICAL FRAKTUR CAPITAL J"
            txt = Regex.Replace(txt, "&#x0*?1D50D;", "𝔍");
            txt = Regex.Replace(txt, "&#0*?120077;", "𝔍");
            txt = Regex.Replace(txt, "&Jfr;", "𝔍");

            // "U+1D50E", "MATHEMATICAL FRAKTUR CAPITAL K"
            txt = Regex.Replace(txt, "&#x0*?1D50E;", "𝔎");
            txt = Regex.Replace(txt, "&#0*?120078;", "𝔎");
            txt = Regex.Replace(txt, "&Kfr;", "𝔎");

            // "U+1D50F", "MATHEMATICAL FRAKTUR CAPITAL L"
            txt = Regex.Replace(txt, "&#x0*?1D50F;", "𝔏");
            txt = Regex.Replace(txt, "&#0*?120079;", "𝔏");
            txt = Regex.Replace(txt, "&Lfr;", "𝔏");

            // "U+1D510", "MATHEMATICAL FRAKTUR CAPITAL M"
            txt = Regex.Replace(txt, "&#x0*?1D510;", "𝔐");
            txt = Regex.Replace(txt, "&#0*?120080;", "𝔐");
            txt = Regex.Replace(txt, "&Mfr;", "𝔐");

            // "U+1D511", "MATHEMATICAL FRAKTUR CAPITAL N"
            txt = Regex.Replace(txt, "&#x0*?1D511;", "𝔑");
            txt = Regex.Replace(txt, "&#0*?120081;", "𝔑");
            txt = Regex.Replace(txt, "&Nfr;", "𝔑");

            // "U+1D512", "MATHEMATICAL FRAKTUR CAPITAL O"
            txt = Regex.Replace(txt, "&#x0*?1D512;", "𝔒");
            txt = Regex.Replace(txt, "&#0*?120082;", "𝔒");
            txt = Regex.Replace(txt, "&Ofr;", "𝔒");

            // "U+1D513", "MATHEMATICAL FRAKTUR CAPITAL P"
            txt = Regex.Replace(txt, "&#x0*?1D513;", "𝔓");
            txt = Regex.Replace(txt, "&#0*?120083;", "𝔓");
            txt = Regex.Replace(txt, "&Pfr;", "𝔓");

            // "U+1D514", "MATHEMATICAL FRAKTUR CAPITAL Q"
            txt = Regex.Replace(txt, "&#x0*?1D514;", "𝔔");
            txt = Regex.Replace(txt, "&#0*?120084;", "𝔔");
            txt = Regex.Replace(txt, "&Qfr;", "𝔔");

            // "U+1D516", "MATHEMATICAL FRAKTUR CAPITAL S"
            txt = Regex.Replace(txt, "&#x0*?1D516;", "𝔖");
            txt = Regex.Replace(txt, "&#0*?120086;", "𝔖");
            txt = Regex.Replace(txt, "&Sfr;", "𝔖");

            // "U+1D517", "MATHEMATICAL FRAKTUR CAPITAL T"
            txt = Regex.Replace(txt, "&#x0*?1D517;", "𝔗");
            txt = Regex.Replace(txt, "&#0*?120087;", "𝔗");
            txt = Regex.Replace(txt, "&Tfr;", "𝔗");

            // "U+1D518", "MATHEMATICAL FRAKTUR CAPITAL U"
            txt = Regex.Replace(txt, "&#x0*?1D518;", "𝔘");
            txt = Regex.Replace(txt, "&#0*?120088;", "𝔘");
            txt = Regex.Replace(txt, "&Ufr;", "𝔘");

            // "U+1D519", "MATHEMATICAL FRAKTUR CAPITAL V"
            txt = Regex.Replace(txt, "&#x0*?1D519;", "𝔙");
            txt = Regex.Replace(txt, "&#0*?120089;", "𝔙");
            txt = Regex.Replace(txt, "&Vfr;", "𝔙");

            // "U+1D51A", "MATHEMATICAL FRAKTUR CAPITAL W"
            txt = Regex.Replace(txt, "&#x0*?1D51A;", "𝔚");
            txt = Regex.Replace(txt, "&#0*?120090;", "𝔚");
            txt = Regex.Replace(txt, "&Wfr;", "𝔚");

            // "U+1D51B", "MATHEMATICAL FRAKTUR CAPITAL X"
            txt = Regex.Replace(txt, "&#x0*?1D51B;", "𝔛");
            txt = Regex.Replace(txt, "&#0*?120091;", "𝔛");
            txt = Regex.Replace(txt, "&Xfr;", "𝔛");

            // "U+1D51C", "MATHEMATICAL FRAKTUR CAPITAL Y"
            txt = Regex.Replace(txt, "&#x0*?1D51C;", "𝔜");
            txt = Regex.Replace(txt, "&#0*?120092;", "𝔜");
            txt = Regex.Replace(txt, "&Yfr;", "𝔜");

            // "U+1D51E", "MATHEMATICAL FRAKTUR SMALL A"
            txt = Regex.Replace(txt, "&#x0*?1D51E;", "𝔞");
            txt = Regex.Replace(txt, "&#0*?120094;", "𝔞");
            txt = Regex.Replace(txt, "&afr;", "𝔞");

            // "U+1D51F", "MATHEMATICAL FRAKTUR SMALL B"
            txt = Regex.Replace(txt, "&#x0*?1D51F;", "𝔟");
            txt = Regex.Replace(txt, "&#0*?120095;", "𝔟");
            txt = Regex.Replace(txt, "&bfr;", "𝔟");

            // "U+1D520", "MATHEMATICAL FRAKTUR SMALL C"
            txt = Regex.Replace(txt, "&#x0*?1D520;", "𝔠");
            txt = Regex.Replace(txt, "&#0*?120096;", "𝔠");
            txt = Regex.Replace(txt, "&cfr;", "𝔠");

            // "U+1D521", "MATHEMATICAL FRAKTUR SMALL D"
            txt = Regex.Replace(txt, "&#x0*?1D521;", "𝔡");
            txt = Regex.Replace(txt, "&#0*?120097;", "𝔡");
            txt = Regex.Replace(txt, "&dfr;", "𝔡");

            // "U+1D522", "MATHEMATICAL FRAKTUR SMALL E"
            txt = Regex.Replace(txt, "&#x0*?1D522;", "𝔢");
            txt = Regex.Replace(txt, "&#0*?120098;", "𝔢");
            txt = Regex.Replace(txt, "&efr;", "𝔢");

            // "U+1D523", "MATHEMATICAL FRAKTUR SMALL F"
            txt = Regex.Replace(txt, "&#x0*?1D523;", "𝔣");
            txt = Regex.Replace(txt, "&#0*?120099;", "𝔣");
            txt = Regex.Replace(txt, "&ffr;", "𝔣");

            // "U+1D524", "MATHEMATICAL FRAKTUR SMALL G"
            txt = Regex.Replace(txt, "&#x0*?1D524;", "𝔤");
            txt = Regex.Replace(txt, "&#0*?120100;", "𝔤");
            txt = Regex.Replace(txt, "&gfr;", "𝔤");

            // "U+1D525", "MATHEMATICAL FRAKTUR SMALL H"
            txt = Regex.Replace(txt, "&#x0*?1D525;", "𝔥");
            txt = Regex.Replace(txt, "&#0*?120101;", "𝔥");
            txt = Regex.Replace(txt, "&hfr;", "𝔥");

            // "U+1D526", "MATHEMATICAL FRAKTUR SMALL I"
            txt = Regex.Replace(txt, "&#x0*?1D526;", "𝔦");
            txt = Regex.Replace(txt, "&#0*?120102;", "𝔦");
            txt = Regex.Replace(txt, "&ifr;", "𝔦");

            // "U+1D527", "MATHEMATICAL FRAKTUR SMALL J"
            txt = Regex.Replace(txt, "&#x0*?1D527;", "𝔧");
            txt = Regex.Replace(txt, "&#0*?120103;", "𝔧");
            txt = Regex.Replace(txt, "&jfr;", "𝔧");

            // "U+1D528", "MATHEMATICAL FRAKTUR SMALL K"
            txt = Regex.Replace(txt, "&#x0*?1D528;", "𝔨");
            txt = Regex.Replace(txt, "&#0*?120104;", "𝔨");
            txt = Regex.Replace(txt, "&kfr;", "𝔨");

            // "U+1D529", "MATHEMATICAL FRAKTUR SMALL L"
            txt = Regex.Replace(txt, "&#x0*?1D529;", "𝔩");
            txt = Regex.Replace(txt, "&#0*?120105;", "𝔩");
            txt = Regex.Replace(txt, "&lfr;", "𝔩");

            // "U+1D52A", "MATHEMATICAL FRAKTUR SMALL M"
            txt = Regex.Replace(txt, "&#x0*?1D52A;", "𝔪");
            txt = Regex.Replace(txt, "&#0*?120106;", "𝔪");
            txt = Regex.Replace(txt, "&mfr;", "𝔪");

            // "U+1D52B", "MATHEMATICAL FRAKTUR SMALL N"
            txt = Regex.Replace(txt, "&#x0*?1D52B;", "𝔫");
            txt = Regex.Replace(txt, "&#0*?120107;", "𝔫");
            txt = Regex.Replace(txt, "&nfr;", "𝔫");

            // "U+1D52C", "MATHEMATICAL FRAKTUR SMALL O"
            txt = Regex.Replace(txt, "&#x0*?1D52C;", "𝔬");
            txt = Regex.Replace(txt, "&#0*?120108;", "𝔬");
            txt = Regex.Replace(txt, "&ofr;", "𝔬");

            // "U+1D52D", "MATHEMATICAL FRAKTUR SMALL P"
            txt = Regex.Replace(txt, "&#x0*?1D52D;", "𝔭");
            txt = Regex.Replace(txt, "&#0*?120109;", "𝔭");
            txt = Regex.Replace(txt, "&pfr;", "𝔭");

            // "U+1D52E", "MATHEMATICAL FRAKTUR SMALL Q"
            txt = Regex.Replace(txt, "&#x0*?1D52E;", "𝔮");
            txt = Regex.Replace(txt, "&#0*?120110;", "𝔮");
            txt = Regex.Replace(txt, "&qfr;", "𝔮");

            // "U+1D52F", "MATHEMATICAL FRAKTUR SMALL R"
            txt = Regex.Replace(txt, "&#x0*?1D52F;", "𝔯");
            txt = Regex.Replace(txt, "&#0*?120111;", "𝔯");
            txt = Regex.Replace(txt, "&rfr;", "𝔯");

            // "U+1D530", "MATHEMATICAL FRAKTUR SMALL S"
            txt = Regex.Replace(txt, "&#x0*?1D530;", "𝔰");
            txt = Regex.Replace(txt, "&#0*?120112;", "𝔰");
            txt = Regex.Replace(txt, "&sfr;", "𝔰");

            // "U+1D531", "MATHEMATICAL FRAKTUR SMALL T"
            txt = Regex.Replace(txt, "&#x0*?1D531;", "𝔱");
            txt = Regex.Replace(txt, "&#0*?120113;", "𝔱");
            txt = Regex.Replace(txt, "&tfr;", "𝔱");

            // "U+1D532", "MATHEMATICAL FRAKTUR SMALL U"
            txt = Regex.Replace(txt, "&#x0*?1D532;", "𝔲");
            txt = Regex.Replace(txt, "&#0*?120114;", "𝔲");
            txt = Regex.Replace(txt, "&ufr;", "𝔲");

            // "U+1D533", "MATHEMATICAL FRAKTUR SMALL V"
            txt = Regex.Replace(txt, "&#x0*?1D533;", "𝔳");
            txt = Regex.Replace(txt, "&#0*?120115;", "𝔳");
            txt = Regex.Replace(txt, "&vfr;", "𝔳");

            // "U+1D534", "MATHEMATICAL FRAKTUR SMALL W"
            txt = Regex.Replace(txt, "&#x0*?1D534;", "𝔴");
            txt = Regex.Replace(txt, "&#0*?120116;", "𝔴");
            txt = Regex.Replace(txt, "&wfr;", "𝔴");

            // "U+1D535", "MATHEMATICAL FRAKTUR SMALL X"
            txt = Regex.Replace(txt, "&#x0*?1D535;", "𝔵");
            txt = Regex.Replace(txt, "&#0*?120117;", "𝔵");
            txt = Regex.Replace(txt, "&xfr;", "𝔵");

            // "U+1D536", "MATHEMATICAL FRAKTUR SMALL Y"
            txt = Regex.Replace(txt, "&#x0*?1D536;", "𝔶");
            txt = Regex.Replace(txt, "&#0*?120118;", "𝔶");
            txt = Regex.Replace(txt, "&yfr;", "𝔶");

            // "U+1D537", "MATHEMATICAL FRAKTUR SMALL Z"
            txt = Regex.Replace(txt, "&#x0*?1D537;", "𝔷");
            txt = Regex.Replace(txt, "&#0*?120119;", "𝔷");
            txt = Regex.Replace(txt, "&zfr;", "𝔷");

            // "U+1D538", "MATHEMATICAL DOUBLE-STRUCK CAPITAL A"
            txt = Regex.Replace(txt, "&#x0*?1D538;", "𝔸");
            txt = Regex.Replace(txt, "&#0*?120120;", "𝔸");
            txt = Regex.Replace(txt, "&Aopf;", "𝔸");

            // "U+1D539", "MATHEMATICAL DOUBLE-STRUCK CAPITAL B"
            txt = Regex.Replace(txt, "&#x0*?1D539;", "𝔹");
            txt = Regex.Replace(txt, "&#0*?120121;", "𝔹");
            txt = Regex.Replace(txt, "&Bopf;", "𝔹");

            // "U+1D53B", "MATHEMATICAL DOUBLE-STRUCK CAPITAL D"
            txt = Regex.Replace(txt, "&#x0*?1D53B;", "𝔻");
            txt = Regex.Replace(txt, "&#0*?120123;", "𝔻");
            txt = Regex.Replace(txt, "&Dopf;", "𝔻");

            // "U+1D53C", "MATHEMATICAL DOUBLE-STRUCK CAPITAL E"
            txt = Regex.Replace(txt, "&#x0*?1D53C;", "𝔼");
            txt = Regex.Replace(txt, "&#0*?120124;", "𝔼");
            txt = Regex.Replace(txt, "&Eopf;", "𝔼");

            // "U+1D53D", "MATHEMATICAL DOUBLE-STRUCK CAPITAL F"
            txt = Regex.Replace(txt, "&#x0*?1D53D;", "𝔽");
            txt = Regex.Replace(txt, "&#0*?120125;", "𝔽");
            txt = Regex.Replace(txt, "&Fopf;", "𝔽");

            // "U+1D53E", "MATHEMATICAL DOUBLE-STRUCK CAPITAL G"
            txt = Regex.Replace(txt, "&#x0*?1D53E;", "𝔾");
            txt = Regex.Replace(txt, "&#0*?120126;", "𝔾");
            txt = Regex.Replace(txt, "&Gopf;", "𝔾");

            // "U+1D540", "MATHEMATICAL DOUBLE-STRUCK CAPITAL I"
            txt = Regex.Replace(txt, "&#x0*?1D540;", "𝕀");
            txt = Regex.Replace(txt, "&#0*?120128;", "𝕀");
            txt = Regex.Replace(txt, "&Iopf;", "𝕀");

            // "U+1D541", "MATHEMATICAL DOUBLE-STRUCK CAPITAL J"
            txt = Regex.Replace(txt, "&#x0*?1D541;", "𝕁");
            txt = Regex.Replace(txt, "&#0*?120129;", "𝕁");
            txt = Regex.Replace(txt, "&Jopf;", "𝕁");

            // "U+1D542", "MATHEMATICAL DOUBLE-STRUCK CAPITAL K"
            txt = Regex.Replace(txt, "&#x0*?1D542;", "𝕂");
            txt = Regex.Replace(txt, "&#0*?120130;", "𝕂");
            txt = Regex.Replace(txt, "&Kopf;", "𝕂");

            // "U+1D543", "MATHEMATICAL DOUBLE-STRUCK CAPITAL L"
            txt = Regex.Replace(txt, "&#x0*?1D543;", "𝕃");
            txt = Regex.Replace(txt, "&#0*?120131;", "𝕃");
            txt = Regex.Replace(txt, "&Lopf;", "𝕃");

            // "U+1D544", "MATHEMATICAL DOUBLE-STRUCK CAPITAL M"
            txt = Regex.Replace(txt, "&#x0*?1D544;", "𝕄");
            txt = Regex.Replace(txt, "&#0*?120132;", "𝕄");
            txt = Regex.Replace(txt, "&Mopf;", "𝕄");

            // "U+1D546", "MATHEMATICAL DOUBLE-STRUCK CAPITAL O"
            txt = Regex.Replace(txt, "&#x0*?1D546;", "𝕆");
            txt = Regex.Replace(txt, "&#0*?120134;", "𝕆");
            txt = Regex.Replace(txt, "&Oopf;", "𝕆");

            // "U+1D54A", "MATHEMATICAL DOUBLE-STRUCK CAPITAL S"
            txt = Regex.Replace(txt, "&#x0*?1D54A;", "𝕊");
            txt = Regex.Replace(txt, "&#0*?120138;", "𝕊");
            txt = Regex.Replace(txt, "&Sopf;", "𝕊");

            // "U+1D54B", "MATHEMATICAL DOUBLE-STRUCK CAPITAL T"
            txt = Regex.Replace(txt, "&#x0*?1D54B;", "𝕋");
            txt = Regex.Replace(txt, "&#0*?120139;", "𝕋");
            txt = Regex.Replace(txt, "&Topf;", "𝕋");

            // "U+1D54C", "MATHEMATICAL DOUBLE-STRUCK CAPITAL U"
            txt = Regex.Replace(txt, "&#x0*?1D54C;", "𝕌");
            txt = Regex.Replace(txt, "&#0*?120140;", "𝕌");
            txt = Regex.Replace(txt, "&Uopf;", "𝕌");

            // "U+1D54D", "MATHEMATICAL DOUBLE-STRUCK CAPITAL V"
            txt = Regex.Replace(txt, "&#x0*?1D54D;", "𝕍");
            txt = Regex.Replace(txt, "&#0*?120141;", "𝕍");
            txt = Regex.Replace(txt, "&Vopf;", "𝕍");

            // "U+1D54E", "MATHEMATICAL DOUBLE-STRUCK CAPITAL W"
            txt = Regex.Replace(txt, "&#x0*?1D54E;", "𝕎");
            txt = Regex.Replace(txt, "&#0*?120142;", "𝕎");
            txt = Regex.Replace(txt, "&Wopf;", "𝕎");

            // "U+1D54F", "MATHEMATICAL DOUBLE-STRUCK CAPITAL X"
            txt = Regex.Replace(txt, "&#x0*?1D54F;", "𝕏");
            txt = Regex.Replace(txt, "&#0*?120143;", "𝕏");
            txt = Regex.Replace(txt, "&Xopf;", "𝕏");

            // "U+1D550", "MATHEMATICAL DOUBLE-STRUCK CAPITAL Y"
            txt = Regex.Replace(txt, "&#x0*?1D550;", "𝕐");
            txt = Regex.Replace(txt, "&#0*?120144;", "𝕐");
            txt = Regex.Replace(txt, "&Yopf;", "𝕐");

            // "U+1D552", "MATHEMATICAL DOUBLE-STRUCK SMALL A"
            txt = Regex.Replace(txt, "&#x0*?1D552;", "𝕒");
            txt = Regex.Replace(txt, "&#0*?120146;", "𝕒");
            txt = Regex.Replace(txt, "&aopf;", "𝕒");

            // "U+1D553", "MATHEMATICAL DOUBLE-STRUCK SMALL B"
            txt = Regex.Replace(txt, "&#x0*?1D553;", "𝕓");
            txt = Regex.Replace(txt, "&#0*?120147;", "𝕓");
            txt = Regex.Replace(txt, "&bopf;", "𝕓");

            // "U+1D554", "MATHEMATICAL DOUBLE-STRUCK SMALL C"
            txt = Regex.Replace(txt, "&#x0*?1D554;", "𝕔");
            txt = Regex.Replace(txt, "&#0*?120148;", "𝕔");
            txt = Regex.Replace(txt, "&copf;", "𝕔");

            // "U+1D555", "MATHEMATICAL DOUBLE-STRUCK SMALL D"
            txt = Regex.Replace(txt, "&#x0*?1D555;", "𝕕");
            txt = Regex.Replace(txt, "&#0*?120149;", "𝕕");
            txt = Regex.Replace(txt, "&dopf;", "𝕕");

            // "U+1D556", "MATHEMATICAL DOUBLE-STRUCK SMALL E"
            txt = Regex.Replace(txt, "&#x0*?1D556;", "𝕖");
            txt = Regex.Replace(txt, "&#0*?120150;", "𝕖");
            txt = Regex.Replace(txt, "&eopf;", "𝕖");

            // "U+1D557", "MATHEMATICAL DOUBLE-STRUCK SMALL F"
            txt = Regex.Replace(txt, "&#x0*?1D557;", "𝕗");
            txt = Regex.Replace(txt, "&#0*?120151;", "𝕗");
            txt = Regex.Replace(txt, "&fopf;", "𝕗");

            // "U+1D558", "MATHEMATICAL DOUBLE-STRUCK SMALL G"
            txt = Regex.Replace(txt, "&#x0*?1D558;", "𝕘");
            txt = Regex.Replace(txt, "&#0*?120152;", "𝕘");
            txt = Regex.Replace(txt, "&gopf;", "𝕘");

            // "U+1D559", "MATHEMATICAL DOUBLE-STRUCK SMALL H"
            txt = Regex.Replace(txt, "&#x0*?1D559;", "𝕙");
            txt = Regex.Replace(txt, "&#0*?120153;", "𝕙");
            txt = Regex.Replace(txt, "&hopf;", "𝕙");

            // "U+1D55A", "MATHEMATICAL DOUBLE-STRUCK SMALL I"
            txt = Regex.Replace(txt, "&#x0*?1D55A;", "𝕚");
            txt = Regex.Replace(txt, "&#0*?120154;", "𝕚");
            txt = Regex.Replace(txt, "&iopf;", "𝕚");

            // "U+1D55B", "MATHEMATICAL DOUBLE-STRUCK SMALL J"
            txt = Regex.Replace(txt, "&#x0*?1D55B;", "𝕛");
            txt = Regex.Replace(txt, "&#0*?120155;", "𝕛");
            txt = Regex.Replace(txt, "&jopf;", "𝕛");

            // "U+1D55C", "MATHEMATICAL DOUBLE-STRUCK SMALL K"
            txt = Regex.Replace(txt, "&#x0*?1D55C;", "𝕜");
            txt = Regex.Replace(txt, "&#0*?120156;", "𝕜");
            txt = Regex.Replace(txt, "&kopf;", "𝕜");

            // "U+1D55D", "MATHEMATICAL DOUBLE-STRUCK SMALL L"
            txt = Regex.Replace(txt, "&#x0*?1D55D;", "𝕝");
            txt = Regex.Replace(txt, "&#0*?120157;", "𝕝");
            txt = Regex.Replace(txt, "&lopf;", "𝕝");

            // "U+1D55E", "MATHEMATICAL DOUBLE-STRUCK SMALL M"
            txt = Regex.Replace(txt, "&#x0*?1D55E;", "𝕞");
            txt = Regex.Replace(txt, "&#0*?120158;", "𝕞");
            txt = Regex.Replace(txt, "&mopf;", "𝕞");

            // "U+1D55F", "MATHEMATICAL DOUBLE-STRUCK SMALL N"
            txt = Regex.Replace(txt, "&#x0*?1D55F;", "𝕟");
            txt = Regex.Replace(txt, "&#0*?120159;", "𝕟");
            txt = Regex.Replace(txt, "&nopf;", "𝕟");

            // "U+1D560", "MATHEMATICAL DOUBLE-STRUCK SMALL O"
            txt = Regex.Replace(txt, "&#x0*?1D560;", "𝕠");
            txt = Regex.Replace(txt, "&#0*?120160;", "𝕠");
            txt = Regex.Replace(txt, "&oopf;", "𝕠");

            // "U+1D561", "MATHEMATICAL DOUBLE-STRUCK SMALL P"
            txt = Regex.Replace(txt, "&#x0*?1D561;", "𝕡");
            txt = Regex.Replace(txt, "&#0*?120161;", "𝕡");
            txt = Regex.Replace(txt, "&popf;", "𝕡");

            // "U+1D562", "MATHEMATICAL DOUBLE-STRUCK SMALL Q"
            txt = Regex.Replace(txt, "&#x0*?1D562;", "𝕢");
            txt = Regex.Replace(txt, "&#0*?120162;", "𝕢");
            txt = Regex.Replace(txt, "&qopf;", "𝕢");

            // "U+1D563", "MATHEMATICAL DOUBLE-STRUCK SMALL R"
            txt = Regex.Replace(txt, "&#x0*?1D563;", "𝕣");
            txt = Regex.Replace(txt, "&#0*?120163;", "𝕣");
            txt = Regex.Replace(txt, "&ropf;", "𝕣");

            // "U+1D564", "MATHEMATICAL DOUBLE-STRUCK SMALL S"
            txt = Regex.Replace(txt, "&#x0*?1D564;", "𝕤");
            txt = Regex.Replace(txt, "&#0*?120164;", "𝕤");
            txt = Regex.Replace(txt, "&sopf;", "𝕤");

            // "U+1D565", "MATHEMATICAL DOUBLE-STRUCK SMALL T"
            txt = Regex.Replace(txt, "&#x0*?1D565;", "𝕥");
            txt = Regex.Replace(txt, "&#0*?120165;", "𝕥");
            txt = Regex.Replace(txt, "&topf;", "𝕥");

            // "U+1D566", "MATHEMATICAL DOUBLE-STRUCK SMALL U"
            txt = Regex.Replace(txt, "&#x0*?1D566;", "𝕦");
            txt = Regex.Replace(txt, "&#0*?120166;", "𝕦");
            txt = Regex.Replace(txt, "&uopf;", "𝕦");

            // "U+1D567", "MATHEMATICAL DOUBLE-STRUCK SMALL V"
            txt = Regex.Replace(txt, "&#x0*?1D567;", "𝕧");
            txt = Regex.Replace(txt, "&#0*?120167;", "𝕧");
            txt = Regex.Replace(txt, "&vopf;", "𝕧");

            // "U+1D568", "MATHEMATICAL DOUBLE-STRUCK SMALL W"
            txt = Regex.Replace(txt, "&#x0*?1D568;", "𝕨");
            txt = Regex.Replace(txt, "&#0*?120168;", "𝕨");
            txt = Regex.Replace(txt, "&wopf;", "𝕨");

            // "U+1D569", "MATHEMATICAL DOUBLE-STRUCK SMALL X"
            txt = Regex.Replace(txt, "&#x0*?1D569;", "𝕩");
            txt = Regex.Replace(txt, "&#0*?120169;", "𝕩");
            txt = Regex.Replace(txt, "&xopf;", "𝕩");

            // "U+1D56A", "MATHEMATICAL DOUBLE-STRUCK SMALL Y"
            txt = Regex.Replace(txt, "&#x0*?1D56A;", "𝕪");
            txt = Regex.Replace(txt, "&#0*?120170;", "𝕪");
            txt = Regex.Replace(txt, "&yopf;", "𝕪");

            // "U+1D56B", "MATHEMATICAL DOUBLE-STRUCK SMALL Z"
            txt = Regex.Replace(txt, "&#x0*?1D56B;", "𝕫");
            txt = Regex.Replace(txt, "&#0*?120171;", "𝕫");
            txt = Regex.Replace(txt, "&zopf;", "𝕫");

            return txt;
        }

        /// <summary>
        /// 入力される文字列内の文字実体参照を文字や記号に置きかえます。
        /// </summary>
        /// <param name="sources">置きかえられる文字列の配列。</param>
        /// <returns>置きかえられた文字列の配列。</returns>
        static public string[] ConvertFrom(string[] sources)
        {
            for (int i = 0; i < sources.Length; i++)
            {
                sources[i] = ConvertFrom(sources[i]);
            }

            return sources;
        }

        /// <summary>
        /// 入力される文字列内の文字や記号を文字実体参照に置きかえます。ベーシック版です。
        /// </summary>
        /// <param name="source">置きかえられる文字列。</param>
        /// <returns>置きかえられた文字列。</returns>
        static public string ConvertToBasic(string source)
        {
            StringBuilder txt = new StringBuilder(source);

            // "U+00026", "AMPERSAND"
            txt = txt.Replace("&", "&amp;");

            // "U+00022", "QUOTATION MARK"
            txt = txt.Replace(@"""", "&quot;");

            // "U+00027", "APOSTROPHE"
            txt = txt.Replace("'", "&apos;");

            // "U+0003C", "LESS-THAN SIGN"
            txt = txt.Replace("<", "&lt;");

            // "U+0003E", "GREATER-THAN SIGN"
            txt = txt.Replace(">", "&gt;");

            // "U+000A0", "NO-BREAK SPACE"
            txt = txt.Replace(" ", "&nbsp;");

            // "U+000A1", "INVERTED EXCLAMATION MARK"
            txt = txt.Replace("¡", "&iexcl;");

            // "U+000A2", "CENT SIGN"
            txt = txt.Replace("¢", "&cent;");

            // "U+000A3", "POUND SIGN"
            txt = txt.Replace("£", "&pound;");

            // "U+000A4", "CURRENCY SIGN"
            txt = txt.Replace("¤", "&curren;");

            // "U+000A5", "YEN SIGN"
            txt = txt.Replace("¥", "&yen;");

            // "U+000A6", "BROKEN BAR"
            txt = txt.Replace("¦", "&brvbar;");

            // "U+000A7", "SECTION SIGN"
            txt = txt.Replace("§", "&sect;");

            // "U+000A8", "DIAERESIS"
            txt = txt.Replace("¨", "&Dot;");

            // "U+000A9", "COPYRIGHT SIGN"
            txt = txt.Replace("©", "&copy;");

            // "U+000AA", "FEMININE ORDINAL INDICATOR"
            txt = txt.Replace("ª", "&ordf;");

            // "U+000AB", "LEFT-POINTING DOUBLE ANGLE QUOTATION MARK"
            txt = txt.Replace("«", "&laquo;");

            // "U+000AC", "NOT SIGN"
            txt = txt.Replace("¬", "&not;");

            // "U+000AD", "SOFT HYPHEN"
            txt = txt.Replace("­", "&shy;");

            // "U+000AE", "REGISTERED SIGN"
            txt = txt.Replace("®", "&reg;");

            // "U+000AF", "MACRON"
            txt = txt.Replace("¯", "&macr;");

            // "U+000B0", "DEGREE SIGN"
            txt = txt.Replace("°", "&deg;");

            // "U+000B1", "PLUS-MINUS SIGN"
            txt = txt.Replace("±", "&plusmn;");

            // "U+000B2", "SUPERSCRIPT TWO"
            txt = txt.Replace("²", "&sup2;");

            // "U+000B3", "SUPERSCRIPT THREE"
            txt = txt.Replace("³", "&sup3;");

            // "U+000B4", "ACUTE ACCENT"
            txt = txt.Replace("´", "&acute;");

            // "U+000B5", "MICRO SIGN"
            txt = txt.Replace("µ", "&micro;");

            // "U+000B6", "PILCROW SIGN"
            txt = txt.Replace("¶", "&para;");

            // "U+000B7", "MIDDLE DOT"
            txt = txt.Replace("·", "&middot;");

            // "U+000B8", "CEDILLA"
            txt = txt.Replace("¸", "&cedil;");

            // "U+000B9", "SUPERSCRIPT ONE"
            txt = txt.Replace("¹", "&sup1;");

            // "U+000BA", "MASCULINE ORDINAL INDICATOR"
            txt = txt.Replace("º", "&ordm;");

            // "U+000BB", "RIGHT-POINTING DOUBLE ANGLE QUOTATION MARK"
            txt = txt.Replace("»", "&raquo;");

            // "U+000BC", "VULGAR FRACTION ONE QUARTER"
            txt = txt.Replace("¼", "&frac14;");

            // "U+000BD", "VULGAR FRACTION ONE HALF"
            txt = txt.Replace("½", "&frac12;");

            // "U+000BE", "VULGAR FRACTION THREE QUARTERS"
            txt = txt.Replace("¾", "&frac34;");

            // "U+000BF", "INVERTED QUESTION MARK"
            txt = txt.Replace("¿", "&iquest;");

            // "U+000C0", "LATIN CAPITAL LETTER A WITH GRAVE"
            txt = txt.Replace("À", "&Agrave;");

            // "U+000C1", "LATIN CAPITAL LETTER A WITH ACUTE"
            txt = txt.Replace("Á", "&Aacute;");

            // "U+000C2", "LATIN CAPITAL LETTER A WITH CIRCUMFLEX"
            txt = txt.Replace("Â", "&Acirc;");

            // "U+000C3", "LATIN CAPITAL LETTER A WITH TILDE"
            txt = txt.Replace("Ã", "&Atilde;");

            // "U+000C4", "LATIN CAPITAL LETTER A WITH DIAERESIS"
            txt = txt.Replace("Ä", "&Auml;");

            // "U+000C5", "LATIN CAPITAL LETTER A WITH RING ABOVE"
            txt = txt.Replace("Å", "&Aring;");

            // "U+000C6", "LATIN CAPITAL LETTER AE"
            txt = txt.Replace("Æ", "&AElig;");

            // "U+000C7", "LATIN CAPITAL LETTER C WITH CEDILLA"
            txt = txt.Replace("Ç", "&Ccedil;");

            // "U+000C8", "LATIN CAPITAL LETTER E WITH GRAVE"
            txt = txt.Replace("È", "&Egrave;");

            // "U+000C9", "LATIN CAPITAL LETTER E WITH ACUTE"
            txt = txt.Replace("É", "&Eacute;");

            // "U+000CA", "LATIN CAPITAL LETTER E WITH CIRCUMFLEX"
            txt = txt.Replace("Ê", "&Ecirc;");

            // "U+000CB", "LATIN CAPITAL LETTER E WITH DIAERESIS"
            txt = txt.Replace("Ë", "&Euml;");

            // "U+000CC", "LATIN CAPITAL LETTER I WITH GRAVE"
            txt = txt.Replace("Ì", "&Igrave;");

            // "U+000CD", "LATIN CAPITAL LETTER I WITH ACUTE"
            txt = txt.Replace("Í", "&Iacute;");

            // "U+000CE", "LATIN CAPITAL LETTER I WITH CIRCUMFLEX"
            txt = txt.Replace("Î", "&Icirc;");

            // "U+000CF", "LATIN CAPITAL LETTER I WITH DIAERESIS"
            txt = txt.Replace("Ï", "&Iuml;");

            // "U+000D0", "LATIN CAPITAL LETTER ETH"
            txt = txt.Replace("Ð", "&ETH;");

            // "U+000D1", "LATIN CAPITAL LETTER N WITH TILDE"
            txt = txt.Replace("Ñ", "&Ntilde;");

            // "U+000D2", "LATIN CAPITAL LETTER O WITH GRAVE"
            txt = txt.Replace("Ò", "&Ograve;");

            // "U+000D3", "LATIN CAPITAL LETTER O WITH ACUTE"
            txt = txt.Replace("Ó", "&Oacute;");

            // "U+000D4", "LATIN CAPITAL LETTER O WITH CIRCUMFLEX"
            txt = txt.Replace("Ô", "&Ocirc;");

            // "U+000D5", "LATIN CAPITAL LETTER O WITH TILDE"
            txt = txt.Replace("Õ", "&Otilde;");

            // "U+000D6", "LATIN CAPITAL LETTER O WITH DIAERESIS"
            txt = txt.Replace("Ö", "&Ouml;");

            // "U+000D7", "MULTIPLICATION SIGN"
            txt = txt.Replace("×", "&times;");

            // "U+000D8", "LATIN CAPITAL LETTER O WITH STROKE"
            txt = txt.Replace("Ø", "&Oslash;");

            // "U+000D9", "LATIN CAPITAL LETTER U WITH GRAVE"
            txt = txt.Replace("Ù", "&Ugrave;");

            // "U+000DA", "LATIN CAPITAL LETTER U WITH ACUTE"
            txt = txt.Replace("Ú", "&Uacute;");

            // "U+000DB", "LATIN CAPITAL LETTER U WITH CIRCUMFLEX"
            txt = txt.Replace("Û", "&Ucirc;");

            // "U+000DC", "LATIN CAPITAL LETTER U WITH DIAERESIS"
            txt = txt.Replace("Ü", "&Uuml;");

            // "U+000DD", "LATIN CAPITAL LETTER Y WITH ACUTE"
            txt = txt.Replace("Ý", "&Yacute;");

            // "U+000DE", "LATIN CAPITAL LETTER THORN"
            txt = txt.Replace("Þ", "&THORN;");

            // "U+000DF", "LATIN SMALL LETTER SHARP S"
            txt = txt.Replace("ß", "&szlig;");

            // "U+000E0", "LATIN SMALL LETTER A WITH GRAVE"
            txt = txt.Replace("à", "&agrave;");

            // "U+000E1", "LATIN SMALL LETTER A WITH ACUTE"
            txt = txt.Replace("á", "&aacute;");

            // "U+000E2", "LATIN SMALL LETTER A WITH CIRCUMFLEX"
            txt = txt.Replace("â", "&acirc;");

            // "U+000E3", "LATIN SMALL LETTER A WITH TILDE"
            txt = txt.Replace("ã", "&atilde;");

            // "U+000E4", "LATIN SMALL LETTER A WITH DIAERESIS"
            txt = txt.Replace("ä", "&auml;");

            // "U+000E5", "LATIN SMALL LETTER A WITH RING ABOVE"
            txt = txt.Replace("å", "&aring;");

            // "U+000E6", "LATIN SMALL LETTER AE"
            txt = txt.Replace("æ", "&aelig;");

            // "U+000E7", "LATIN SMALL LETTER C WITH CEDILLA"
            txt = txt.Replace("ç", "&ccedil;");

            // "U+000E8", "LATIN SMALL LETTER E WITH GRAVE"
            txt = txt.Replace("è", "&egrave;");

            // "U+000E9", "LATIN SMALL LETTER E WITH ACUTE"
            txt = txt.Replace("é", "&eacute;");

            // "U+000EA", "LATIN SMALL LETTER E WITH CIRCUMFLEX"
            txt = txt.Replace("ê", "&ecirc;");

            // "U+000EB", "LATIN SMALL LETTER E WITH DIAERESIS"
            txt = txt.Replace("ë", "&euml;");

            // "U+000EC", "LATIN SMALL LETTER I WITH GRAVE"
            txt = txt.Replace("ì", "&igrave;");

            // "U+000ED", "LATIN SMALL LETTER I WITH ACUTE"
            txt = txt.Replace("í", "&iacute;");

            // "U+000EE", "LATIN SMALL LETTER I WITH CIRCUMFLEX"
            txt = txt.Replace("î", "&icirc;");

            // "U+000EF", "LATIN SMALL LETTER I WITH DIAERESIS"
            txt = txt.Replace("ï", "&iuml;");

            // "U+000F0", "LATIN SMALL LETTER ETH"
            txt = txt.Replace("ð", "&eth;");

            // "U+000F1", "LATIN SMALL LETTER N WITH TILDE"
            txt = txt.Replace("ñ", "&ntilde;");

            // "U+000F2", "LATIN SMALL LETTER O WITH GRAVE"
            txt = txt.Replace("ò", "&ograve;");

            // "U+000F3", "LATIN SMALL LETTER O WITH ACUTE"
            txt = txt.Replace("ó", "&oacute;");

            // "U+000F4", "LATIN SMALL LETTER O WITH CIRCUMFLEX"
            txt = txt.Replace("ô", "&ocirc;");

            // "U+000F5", "LATIN SMALL LETTER O WITH TILDE"
            txt = txt.Replace("õ", "&otilde;");

            // "U+000F6", "LATIN SMALL LETTER O WITH DIAERESIS"
            txt = txt.Replace("ö", "&ouml;");

            // "U+000F7", "DIVISION SIGN"
            txt = txt.Replace("÷", "&divide;");

            // "U+000F8", "LATIN SMALL LETTER O WITH STROKE"
            txt = txt.Replace("ø", "&oslash;");

            // "U+000F9", "LATIN SMALL LETTER U WITH GRAVE"
            txt = txt.Replace("ù", "&ugrave;");

            // "U+000FA", "LATIN SMALL LETTER U WITH ACUTE"
            txt = txt.Replace("ú", "&uacute;");

            // "U+000FB", "LATIN SMALL LETTER U WITH CIRCUMFLEX"
            txt = txt.Replace("û", "&ucirc;");

            // "U+000FC", "LATIN SMALL LETTER U WITH DIAERESIS"
            txt = txt.Replace("ü", "&uuml;");

            // "U+000FD", "LATIN SMALL LETTER Y WITH ACUTE"
            txt = txt.Replace("ý", "&yacute;");

            // "U+000FE", "LATIN SMALL LETTER THORN"
            txt = txt.Replace("þ", "&thorn;");

            // "U+000FF", "LATIN SMALL LETTER Y WITH DIAERESIS"
            txt = txt.Replace("ÿ", "&yuml;");

            // "U+00152", "LATIN CAPITAL LIGATURE OE"
            txt = txt.Replace("Œ", "&OElig;");

            // "U+00153", "LATIN SMALL LIGATURE OE"
            txt = txt.Replace("œ", "&oelig;");

            // "U+00160", "LATIN CAPITAL LETTER S WITH CARON"
            txt = txt.Replace("Š", "&Scaron;");

            // "U+00161", "LATIN SMALL LETTER S WITH CARON"
            txt = txt.Replace("š", "&scaron;");

            // "U+00178", "LATIN CAPITAL LETTER Y WITH DIAERESIS"
            txt = txt.Replace("Ÿ", "&Yuml;");

            // "U+00192", "LATIN SMALL LETTER F WITH HOOK"
            txt = txt.Replace("ƒ", "&fnof;");

            // "U+002C6", "MODIFIER LETTER CIRCUMFLEX ACCENT"
            txt = txt.Replace("ˆ", "&circ;");

            // "U+002DC", "SMALL TILDE"
            txt = txt.Replace("˜", "&tilde;");

            // "U+00391", "GREEK CAPITAL LETTER ALPHA"
            txt = txt.Replace("Α", "&Alpha;");

            // "U+00392", "GREEK CAPITAL LETTER BETA"
            txt = txt.Replace("Β", "&Beta;");

            // "U+00393", "GREEK CAPITAL LETTER GAMMA"
            txt = txt.Replace("Γ", "&Gamma;");

            // "U+00394", "GREEK CAPITAL LETTER DELTA"
            txt = txt.Replace("Δ", "&Delta;");

            // "U+00395", "GREEK CAPITAL LETTER EPSILON"
            txt = txt.Replace("Ε", "&Epsilon;");

            // "U+00396", "GREEK CAPITAL LETTER ZETA"
            txt = txt.Replace("Ζ", "&Zeta;");

            // "U+00397", "GREEK CAPITAL LETTER ETA"
            txt = txt.Replace("Η", "&Eta;");

            // "U+00398", "GREEK CAPITAL LETTER THETA"
            txt = txt.Replace("Θ", "&Theta;");

            // "U+00399", "GREEK CAPITAL LETTER IOTA"
            txt = txt.Replace("Ι", "&Iota;");

            // "U+0039A", "GREEK CAPITAL LETTER KAPPA"
            txt = txt.Replace("Κ", "&Kappa;");

            // "U+0039B", "GREEK CAPITAL LETTER LAMDA"
            txt = txt.Replace("Λ", "&Lambda;");

            // "U+0039C", "GREEK CAPITAL LETTER MU"
            txt = txt.Replace("Μ", "&Mu;");

            // "U+0039D", "GREEK CAPITAL LETTER NU"
            txt = txt.Replace("Ν", "&Nu;");

            // "U+0039E", "GREEK CAPITAL LETTER XI"
            txt = txt.Replace("Ξ", "&Xi;");

            // "U+0039F", "GREEK CAPITAL LETTER OMICRON"
            txt = txt.Replace("Ο", "&Omicron;");

            // "U+003A0", "GREEK CAPITAL LETTER PI"
            txt = txt.Replace("Π", "&Pi;");

            // "U+003A1", "GREEK CAPITAL LETTER RHO"
            txt = txt.Replace("Ρ", "&Rho;");

            // "U+003A3", "GREEK CAPITAL LETTER SIGMA"
            txt = txt.Replace("Σ", "&Sigma;");

            // "U+003A4", "GREEK CAPITAL LETTER TAU"
            txt = txt.Replace("Τ", "&Tau;");

            // "U+003A5", "GREEK CAPITAL LETTER UPSILON"
            txt = txt.Replace("Υ", "&Upsilon;");

            // "U+003A6", "GREEK CAPITAL LETTER PHI"
            txt = txt.Replace("Φ", "&Phi;");

            // "U+003A7", "GREEK CAPITAL LETTER CHI"
            txt = txt.Replace("Χ", "&Chi;");

            // "U+003A8", "GREEK CAPITAL LETTER PSI"
            txt = txt.Replace("Ψ", "&Psi;");

            // "U+003A9", "GREEK CAPITAL LETTER OMEGA"
            txt = txt.Replace("Ω", "&Omega;");

            // "U+003B1", "GREEK SMALL LETTER ALPHA"
            txt = txt.Replace("α", "&alpha;");

            // "U+003B2", "GREEK SMALL LETTER BETA"
            txt = txt.Replace("β", "&beta;");

            // "U+003B3", "GREEK SMALL LETTER GAMMA"
            txt = txt.Replace("γ", "&gamma;");

            // "U+003B4", "GREEK SMALL LETTER DELTA"
            txt = txt.Replace("δ", "&delta;");

            // "U+003B5", "GREEK SMALL LETTER EPSILON"
            txt = txt.Replace("ε", "&epsiv;");

            // "U+003B6", "GREEK SMALL LETTER ZETA"
            txt = txt.Replace("ζ", "&zeta;");

            // "U+003B7", "GREEK SMALL LETTER ETA"
            txt = txt.Replace("η", "&eta;");

            // "U+003B8", "GREEK SMALL LETTER THETA"
            txt = txt.Replace("θ", "&theta;");

            // "U+003B9", "GREEK SMALL LETTER IOTA"
            txt = txt.Replace("ι", "&iota;");

            // "U+003BA", "GREEK SMALL LETTER KAPPA"
            txt = txt.Replace("κ", "&kappa;");

            // "U+003BB", "GREEK SMALL LETTER LAMDA"
            txt = txt.Replace("λ", "&lambda;");

            // "U+003BC", "GREEK SMALL LETTER MU"
            txt = txt.Replace("μ", "&mu;");

            // "U+003BD", "GREEK SMALL LETTER NU"
            txt = txt.Replace("ν", "&nu;");

            // "U+003BE", "GREEK SMALL LETTER XI"
            txt = txt.Replace("ξ", "&xi;");

            // "U+003BF", "GREEK SMALL LETTER OMICRON"
            txt = txt.Replace("ο", "&omicron;");

            // "U+003C0", "GREEK SMALL LETTER PI"
            txt = txt.Replace("π", "&pi;");

            // "U+003C1", "GREEK SMALL LETTER RHO"
            txt = txt.Replace("ρ", "&rho;");

            // "U+003C2", "GREEK SMALL LETTER FINAL SIGMA"
            txt = txt.Replace("ς", "&sigmav;");

            // "U+003C3", "GREEK SMALL LETTER SIGMA"
            txt = txt.Replace("σ", "&sigma;");

            // "U+003C4", "GREEK SMALL LETTER TAU"
            txt = txt.Replace("τ", "&tau;");

            // "U+003C5", "GREEK SMALL LETTER UPSILON"
            txt = txt.Replace("υ", "&upsi;");

            // "U+003C6", "GREEK SMALL LETTER PHI"
            txt = txt.Replace("φ", "&phi;");

            // "U+003C7", "GREEK SMALL LETTER CHI"
            txt = txt.Replace("χ", "&chi;");

            // "U+003C8", "GREEK SMALL LETTER PSI"
            txt = txt.Replace("ψ", "&psi;");

            // "U+003C9", "GREEK SMALL LETTER OMEGA"
            txt = txt.Replace("ω", "&omega;");

            // "U+003D1", "GREEK THETA SYMBOL"
            txt = txt.Replace("ϑ", "&thetav;");

            // "U+003D2", "GREEK UPSILON WITH HOOK SYMBOL"
            txt = txt.Replace("ϒ", "&Upsi;");

            // "U+003D6", "GREEK PI SYMBOL"
            txt = txt.Replace("ϖ", "&piv;");

            // "U+02002", "EN SPACE"
            txt = txt.Replace(" ", "&ensp;");

            // "U+02003", "EM SPACE"
            txt = txt.Replace(" ", "&emsp;");

            // "U+02009", "THIN SPACE"
            txt = txt.Replace(" ", "&thinsp;");

            // "U+0200C", "ZERO WIDTH NON-JOINER"
            txt = txt.Replace("‌", "&zwnj;");

            // "U+0200D", "ZERO WIDTH JOINER"
            txt = txt.Replace("‍", "&zwj;");

            // "U+0200E", "LEFT-TO-RIGHT MARK"
            txt = txt.Replace("‎", "&lrm;");

            // "U+0200F", "RIGHT-TO-LEFT MARK"
            txt = txt.Replace("‏", "&rlm;");

            // "U+02013", "EN DASH"
            txt = txt.Replace("–", "&ndash;");

            // "U+02014", "EM DASH"
            txt = txt.Replace("—", "&mdash;");

            // "U+02018", "LEFT SINGLE QUOTATION MARK"
            txt = txt.Replace("‘", "&lsquo;");

            // "U+02019", "RIGHT SINGLE QUOTATION MARK"
            txt = txt.Replace("’", "&rsquo;");

            // "U+0201A", "SINGLE LOW-9 QUOTATION MARK"
            txt = txt.Replace("‚", "&lsquor;");

            // "U+0201C", "LEFT DOUBLE QUOTATION MARK"
            txt = txt.Replace("“", "&ldquo;");

            // "U+0201D", "RIGHT DOUBLE QUOTATION MARK"
            txt = txt.Replace("”", "&rdquo;");

            // "U+0201E", "DOUBLE LOW-9 QUOTATION MARK"
            txt = txt.Replace("„", "&ldquor;");

            // "U+02020", "DAGGER"
            txt = txt.Replace("†", "&dagger;");

            // "U+02021", "DOUBLE DAGGER"
            txt = txt.Replace("‡", "&Dagger;");

            // "U+02022", "BULLET"
            txt = txt.Replace("•", "&bull;");

            // "U+02026", "HORIZONTAL ELLIPSIS"
            txt = txt.Replace("…", "&hellip;");

            // "U+02030", "PER MILLE SIGN"
            txt = txt.Replace("‰", "&permil;");

            // "U+02032", "PRIME"
            txt = txt.Replace("′", "&prime;");

            // "U+02033", "DOUBLE PRIME"
            txt = txt.Replace("″", "&Prime;");

            // "U+02039", "SINGLE LEFT-POINTING ANGLE QUOTATION MARK"
            txt = txt.Replace("‹", "&lsaquo;");

            // "U+0203A", "SINGLE RIGHT-POINTING ANGLE QUOTATION MARK"
            txt = txt.Replace("›", "&rsaquo;");

            // "U+0203E", "OVERLINE"
            txt = txt.Replace("‾", "&oline;");

            // "U+02044", "FRACTION SLASH"
            txt = txt.Replace("⁄", "&frasl;");

            // "U+020AC", "EURO SIGN"
            txt = txt.Replace("€", "&euro;");

            // "U+02111", "BLACK-LETTER CAPITAL I"
            txt = txt.Replace("ℑ", "&image;");

            // "U+02118", "SCRIPT CAPITAL P"
            txt = txt.Replace("℘", "&weierp;");

            // "U+0211C", "BLACK-LETTER CAPITAL R"
            txt = txt.Replace("ℜ", "&real;");

            // "U+02122", "TRADE MARK SIGN"
            txt = txt.Replace("™", "&trade;");

            // "U+02135", "ALEF SYMBOL"
            txt = txt.Replace("ℵ", "&alefsym;");

            // "U+02190", "LEFTWARDS ARROW"
            txt = txt.Replace("←", "&larr;");

            // "U+02191", "UPWARDS ARROW"
            txt = txt.Replace("↑", "&uarr;");

            // "U+02192", "RIGHTWARDS ARROW"
            txt = txt.Replace("→", "&rarr;");

            // "U+02193", "DOWNWARDS ARROW"
            txt = txt.Replace("↓", "&darr;");

            // "U+02194", "LEFT RIGHT ARROW"
            txt = txt.Replace("↔", "&harr;");

            // "U+021B5", "DOWNWARDS ARROW WITH CORNER LEFTWARDS"
            txt = txt.Replace("↵", "&crarr;");

            // "U+021D0", "LEFTWARDS DOUBLE ARROW"
            txt = txt.Replace("⇐", "&lArr;");

            // "U+021D1", "UPWARDS DOUBLE ARROW"
            txt = txt.Replace("⇑", "&uArr;");

            // "U+021D2", "RIGHTWARDS DOUBLE ARROW"
            txt = txt.Replace("⇒", "&rArr;");

            // "U+021D3", "DOWNWARDS DOUBLE ARROW"
            txt = txt.Replace("⇓", "&dArr;");

            // "U+021D4", "LEFT RIGHT DOUBLE ARROW"
            txt = txt.Replace("⇔", "&hArr;");

            // "U+02200", "FOR ALL"
            txt = txt.Replace("∀", "&forall;");

            // "U+02202", "PARTIAL DIFFERENTIAL"
            txt = txt.Replace("∂", "&part;");

            // "U+02203", "THERE EXISTS"
            txt = txt.Replace("∃", "&exist;");

            // "U+02205", "EMPTY SET"
            txt = txt.Replace("∅", "&empty;");

            // "U+02207", "NABLA"
            txt = txt.Replace("∇", "&nabla;");

            // "U+02208", "ELEMENT OF"
            txt = txt.Replace("∈", "&isin;");

            // "U+02209", "NOT AN ELEMENT OF"
            txt = txt.Replace("∉", "&notin;");

            // "U+0220B", "CONTAINS AS MEMBER"
            txt = txt.Replace("∋", "&niv;");

            // "U+0220F", "N-ARY PRODUCT"
            txt = txt.Replace("∏", "&prod;");

            // "U+02211", "N-ARY SUMMATION"
            txt = txt.Replace("∑", "&sum;");

            // "U+02212", "MINUS SIGN"
            txt = txt.Replace("−", "&minus;");

            // "U+02217", "ASTERISK OPERATOR"
            txt = txt.Replace("∗", "&lowast;");

            // "U+0221A", "SQUARE ROOT"
            txt = txt.Replace("√", "&radic;");

            // "U+0221D", "PROPORTIONAL TO"
            txt = txt.Replace("∝", "&prop;");

            // "U+0221E", "INFINITY"
            txt = txt.Replace("∞", "&infin;");

            // "U+02220", "ANGLE"
            txt = txt.Replace("∠", "&ang;");

            // "U+02227", "LOGICAL AND"
            txt = txt.Replace("∧", "&and;");

            // "U+02228", "LOGICAL OR"
            txt = txt.Replace("∨", "&or;");

            // "U+02229", "INTERSECTION"
            txt = txt.Replace("∩", "&cap;");

            // "U+0222A", "UNION"
            txt = txt.Replace("∪", "&cup;");

            // "U+0222B", "INTEGRAL"
            txt = txt.Replace("∫", "&int;");

            // "U+02234", "THEREFORE"
            txt = txt.Replace("∴", "&there4;");

            // "U+0223C", "TILDE OPERATOR"
            txt = txt.Replace("∼", "&sim;");

            // "U+02245", "APPROXIMATELY EQUAL TO"
            txt = txt.Replace("≅", "&cong;");

            // "U+02248", "ALMOST EQUAL TO"
            txt = txt.Replace("≈", "&asymp;");

            // "U+02260", "NOT EQUAL TO"
            txt = txt.Replace("≠", "&ne;");

            // "U+02261", "IDENTICAL TO"
            txt = txt.Replace("≡", "&equiv;");

            // "U+02264", "LESS-THAN OR EQUAL TO"
            txt = txt.Replace("≤", "&le;");

            // "U+02265", "GREATER-THAN OR EQUAL TO"
            txt = txt.Replace("≥", "&ge;");

            // "U+02282", "SUBSET OF"
            txt = txt.Replace("⊂", "&sub;");

            // "U+02283", "SUPERSET OF"
            txt = txt.Replace("⊃", "&sup;");

            // "U+02284", "NOT A SUBSET OF"
            txt = txt.Replace("⊄", "&nsub;");

            // "U+02286", "SUBSET OF OR EQUAL TO"
            txt = txt.Replace("⊆", "&sube;");

            // "U+02287", "SUPERSET OF OR EQUAL TO"
            txt = txt.Replace("⊇", "&supe;");

            // "U+02295", "CIRCLED PLUS"
            txt = txt.Replace("⊕", "&oplus;");

            // "U+02297", "CIRCLED TIMES"
            txt = txt.Replace("⊗", "&otimes;");

            // "U+022A5", "UP TACK"
            txt = txt.Replace("⊥", "&bottom;");

            // "U+022C5", "DOT OPERATOR"
            txt = txt.Replace("⋅", "&sdot;");

            // "U+02308", "LEFT CEILING"
            txt = txt.Replace("⌈", "&lceil;");

            // "U+02309", "RIGHT CEILING"
            txt = txt.Replace("⌉", "&rceil;");

            // "U+0230A", "LEFT FLOOR"
            txt = txt.Replace("⌊", "&lfloor;");

            // "U+0230B", "RIGHT FLOOR"
            txt = txt.Replace("⌋", "&rfloor;");

            // "U+025CA", "LOZENGE"
            txt = txt.Replace("◊", "&loz;");

            // "U+02660", "BLACK SPADE SUIT"
            txt = txt.Replace("♠", "&spades;");

            // "U+02663", "BLACK CLUB SUIT"
            txt = txt.Replace("♣", "&clubs;");

            // "U+02665", "BLACK HEART SUIT"
            txt = txt.Replace("♥", "&hearts;");

            // "U+02666", "BLACK DIAMOND SUIT"
            txt = txt.Replace("♦", "&diams;");

            // "U+027E8", "MATHEMATICAL LEFT ANGLE BRACKET"
            txt = txt.Replace("⟨", "&lang;");

            // "U+027E9", "MATHEMATICAL RIGHT ANGLE BRACKET"
            txt = txt.Replace("⟩", "&rang;");

            return txt.ToString();
        }

        /// <summary>
        /// 入力される文字列内の文字や記号を文字実体参照に置きかえます。ベーシック版です。
        /// </summary>
        /// <param name="sources">置きかえられる文字列の配列。</param>
        /// <returns>置きかえられた文字列の配列。</returns>
        static public string[] ConvertToBasic(string[] sources)
        {
            for (int i = 0; i < sources.Length; i++)
            {
                sources[i] = ConvertToBasic(sources[i]);
            }

            return sources;
        }

        /// <summary>
        /// 入力される文字列内の文字や記号を文字実体参照に置きかえます。
        /// </summary>
        /// <param name="source">置きかえられる文字列。</param>
        /// <param name="escapeSequenceFlag">エスケープシーケンスを置きかえるフラグ。</param>
        /// <returns>置きかえられた文字列。</returns>
        static public string ConvertTo(string source, bool escapeSequenceFlag)
        {
            StringBuilder txt = new StringBuilder(source);

            // "U+00026", "AMPERSAND"
            // "U+0003B", "SEMICOLON"
            txt = txt.Replace("&", "&amp");
            txt = txt.Replace(";", "&semi;");
            txt = txt.Replace("&amp", "&amp;");

            if (escapeSequenceFlag)
            {
                // "U+00009", "CHARACTER TABULATION"
                txt = txt.Replace("\t", "&Tab;");

                // "U+0000A", "LINE FEED (LF)"
                txt = txt.Replace("\n", "&NewLine;");
            }

            // "U+00021", "EXCLAMATION MARK"
            txt = txt.Replace("!", "&excl;");

            // "U+00022", "QUOTATION MARK"
            txt = txt.Replace(@"""", "&quot;");

            // "U+00023", "NUMBER SIGN"
            txt = txt.Replace("#", "&num;");

            // "U+00024", "DOLLAR SIGN"
            txt = txt.Replace("$", "&dollar;");

            // "U+00025", "PERCENT SIGN"
            txt = txt.Replace("%", "&percnt;");

            // "U+00027", "APOSTROPHE"
            txt = txt.Replace("'", "&apos;");

            // "U+00028", "LEFT PARENTHESIS"
            txt = txt.Replace("(", "&lpar;");

            // "U+00029", "RIGHT PARENTHESIS"
            txt = txt.Replace(")", "&rpar;");

            // "U+0002A", "ASTERISK"
            txt = txt.Replace("*", "&ast;");

            // "U+0002B", "PLUS SIGN"
            txt = txt.Replace("+", "&plus;");

            // "U+0002C", "COMMA"
            txt = txt.Replace(",", "&comma;");

            // "U+0002E", "FULL STOP"
            txt = txt.Replace(".", "&period;");

            // "U+0002F", "SOLIDUS"
            txt = txt.Replace("/", "&sol;");

            // "U+0003A", "COLON"
            txt = txt.Replace(":", "&colon;");

            // "U+0003C", "LESS-THAN SIGN"
            txt = txt.Replace("<", "&lt;");

            // "U+0003D", "EQUALS SIGN"
            txt = txt.Replace("=", "&equals;");

            // "U+0003E", "GREATER-THAN SIGN"
            txt = txt.Replace(">", "&gt;");

            // "U+0003F", "QUESTION MARK"
            txt = txt.Replace("?", "&quest;");

            // "U+00040", "COMMERCIAL AT"
            txt = txt.Replace("@", "&commat;");

            // "U+0005B", "LEFT SQUARE BRACKET"
            txt = txt.Replace("[", "&lsqb;");

            // "U+0005C", "REVERSE SOLIDUS"
            txt = txt.Replace(@"\", "&bsol;");

            // "U+0005D", "RIGHT SQUARE BRACKET"
            txt = txt.Replace("]", "&rsqb;");

            // "U+0005E", "CIRCUMFLEX ACCENT"
            txt = txt.Replace("^", "&Hat;");

            // "U+0005F", "LOW LINE"
            txt = txt.Replace("_", "&lowbar;");

            // "U+00060", "GRAVE ACCENT"
            txt = txt.Replace("`", "&grave;");

            // "U+0007B", "LEFT CURLY BRACKET"
            txt = txt.Replace("{", "&lcub;");

            // "U+0007C", "VERTICAL LINE"
            txt = txt.Replace("|", "&verbar;");

            // "U+0007D", "RIGHT CURLY BRACKET"
            txt = txt.Replace("}", "&rcub;");

            // "U+000A0", "NO-BREAK SPACE"
            txt = txt.Replace(" ", "&nbsp;");

            // "U+000A1", "INVERTED EXCLAMATION MARK"
            txt = txt.Replace("¡", "&iexcl;");

            // "U+000A2", "CENT SIGN"
            txt = txt.Replace("¢", "&cent;");

            // "U+000A3", "POUND SIGN"
            txt = txt.Replace("£", "&pound;");

            // "U+000A4", "CURRENCY SIGN"
            txt = txt.Replace("¤", "&curren;");

            // "U+000A5", "YEN SIGN"
            txt = txt.Replace("¥", "&yen;");

            // "U+000A6", "BROKEN BAR"
            txt = txt.Replace("¦", "&brvbar;");

            // "U+000A7", "SECTION SIGN"
            txt = txt.Replace("§", "&sect;");

            // "U+000A8", "DIAERESIS"
            txt = txt.Replace("¨", "&Dot;");

            // "U+000A9", "COPYRIGHT SIGN"
            txt = txt.Replace("©", "&copy;");

            // "U+000AA", "FEMININE ORDINAL INDICATOR"
            txt = txt.Replace("ª", "&ordf;");

            // "U+000AB", "LEFT-POINTING DOUBLE ANGLE QUOTATION MARK"
            txt = txt.Replace("«", "&laquo;");

            // "U+000AC", "NOT SIGN"
            txt = txt.Replace("¬", "&not;");

            // "U+000AD", "SOFT HYPHEN"
            txt = txt.Replace("­", "&shy;");

            // "U+000AE", "REGISTERED SIGN"
            txt = txt.Replace("®", "&reg;");

            // "U+000AF", "MACRON"
            txt = txt.Replace("¯", "&macr;");

            // "U+000B0", "DEGREE SIGN"
            txt = txt.Replace("°", "&deg;");

            // "U+000B1", "PLUS-MINUS SIGN"
            txt = txt.Replace("±", "&plusmn;");

            // "U+000B2", "SUPERSCRIPT TWO"
            txt = txt.Replace("²", "&sup2;");

            // "U+000B3", "SUPERSCRIPT THREE"
            txt = txt.Replace("³", "&sup3;");

            // "U+000B4", "ACUTE ACCENT"
            txt = txt.Replace("´", "&acute;");

            // "U+000B5", "MICRO SIGN"
            txt = txt.Replace("µ", "&micro;");

            // "U+000B6", "PILCROW SIGN"
            txt = txt.Replace("¶", "&para;");

            // "U+000B7", "MIDDLE DOT"
            txt = txt.Replace("·", "&middot;");

            // "U+000B8", "CEDILLA"
            txt = txt.Replace("¸", "&cedil;");

            // "U+000B9", "SUPERSCRIPT ONE"
            txt = txt.Replace("¹", "&sup1;");

            // "U+000BA", "MASCULINE ORDINAL INDICATOR"
            txt = txt.Replace("º", "&ordm;");

            // "U+000BB", "RIGHT-POINTING DOUBLE ANGLE QUOTATION MARK"
            txt = txt.Replace("»", "&raquo;");

            // "U+000BC", "VULGAR FRACTION ONE QUARTER"
            txt = txt.Replace("¼", "&frac14;");

            // "U+000BD", "VULGAR FRACTION ONE HALF"
            txt = txt.Replace("½", "&frac12;");

            // "U+000BE", "VULGAR FRACTION THREE QUARTERS"
            txt = txt.Replace("¾", "&frac34;");

            // "U+000BF", "INVERTED QUESTION MARK"
            txt = txt.Replace("¿", "&iquest;");

            // "U+000C0", "LATIN CAPITAL LETTER A WITH GRAVE"
            txt = txt.Replace("À", "&Agrave;");

            // "U+000C1", "LATIN CAPITAL LETTER A WITH ACUTE"
            txt = txt.Replace("Á", "&Aacute;");

            // "U+000C2", "LATIN CAPITAL LETTER A WITH CIRCUMFLEX"
            txt = txt.Replace("Â", "&Acirc;");

            // "U+000C3", "LATIN CAPITAL LETTER A WITH TILDE"
            txt = txt.Replace("Ã", "&Atilde;");

            // "U+000C4", "LATIN CAPITAL LETTER A WITH DIAERESIS"
            txt = txt.Replace("Ä", "&Auml;");

            // "U+000C5", "LATIN CAPITAL LETTER A WITH RING ABOVE"
            txt = txt.Replace("Å", "&Aring;");

            // "U+000C6", "LATIN CAPITAL LETTER AE"
            txt = txt.Replace("Æ", "&AElig;");

            // "U+000C7", "LATIN CAPITAL LETTER C WITH CEDILLA"
            txt = txt.Replace("Ç", "&Ccedil;");

            // "U+000C8", "LATIN CAPITAL LETTER E WITH GRAVE"
            txt = txt.Replace("È", "&Egrave;");

            // "U+000C9", "LATIN CAPITAL LETTER E WITH ACUTE"
            txt = txt.Replace("É", "&Eacute;");

            // "U+000CA", "LATIN CAPITAL LETTER E WITH CIRCUMFLEX"
            txt = txt.Replace("Ê", "&Ecirc;");

            // "U+000CB", "LATIN CAPITAL LETTER E WITH DIAERESIS"
            txt = txt.Replace("Ë", "&Euml;");

            // "U+000CC", "LATIN CAPITAL LETTER I WITH GRAVE"
            txt = txt.Replace("Ì", "&Igrave;");

            // "U+000CD", "LATIN CAPITAL LETTER I WITH ACUTE"
            txt = txt.Replace("Í", "&Iacute;");

            // "U+000CE", "LATIN CAPITAL LETTER I WITH CIRCUMFLEX"
            txt = txt.Replace("Î", "&Icirc;");

            // "U+000CF", "LATIN CAPITAL LETTER I WITH DIAERESIS"
            txt = txt.Replace("Ï", "&Iuml;");

            // "U+000D0", "LATIN CAPITAL LETTER ETH"
            txt = txt.Replace("Ð", "&ETH;");

            // "U+000D1", "LATIN CAPITAL LETTER N WITH TILDE"
            txt = txt.Replace("Ñ", "&Ntilde;");

            // "U+000D2", "LATIN CAPITAL LETTER O WITH GRAVE"
            txt = txt.Replace("Ò", "&Ograve;");

            // "U+000D3", "LATIN CAPITAL LETTER O WITH ACUTE"
            txt = txt.Replace("Ó", "&Oacute;");

            // "U+000D4", "LATIN CAPITAL LETTER O WITH CIRCUMFLEX"
            txt = txt.Replace("Ô", "&Ocirc;");

            // "U+000D5", "LATIN CAPITAL LETTER O WITH TILDE"
            txt = txt.Replace("Õ", "&Otilde;");

            // "U+000D6", "LATIN CAPITAL LETTER O WITH DIAERESIS"
            txt = txt.Replace("Ö", "&Ouml;");

            // "U+000D7", "MULTIPLICATION SIGN"
            txt = txt.Replace("×", "&times;");

            // "U+000D8", "LATIN CAPITAL LETTER O WITH STROKE"
            txt = txt.Replace("Ø", "&Oslash;");

            // "U+000D9", "LATIN CAPITAL LETTER U WITH GRAVE"
            txt = txt.Replace("Ù", "&Ugrave;");

            // "U+000DA", "LATIN CAPITAL LETTER U WITH ACUTE"
            txt = txt.Replace("Ú", "&Uacute;");

            // "U+000DB", "LATIN CAPITAL LETTER U WITH CIRCUMFLEX"
            txt = txt.Replace("Û", "&Ucirc;");

            // "U+000DC", "LATIN CAPITAL LETTER U WITH DIAERESIS"
            txt = txt.Replace("Ü", "&Uuml;");

            // "U+000DD", "LATIN CAPITAL LETTER Y WITH ACUTE"
            txt = txt.Replace("Ý", "&Yacute;");

            // "U+000DE", "LATIN CAPITAL LETTER THORN"
            txt = txt.Replace("Þ", "&THORN;");

            // "U+000DF", "LATIN SMALL LETTER SHARP S"
            txt = txt.Replace("ß", "&szlig;");

            // "U+000E0", "LATIN SMALL LETTER A WITH GRAVE"
            txt = txt.Replace("à", "&agrave;");

            // "U+000E1", "LATIN SMALL LETTER A WITH ACUTE"
            txt = txt.Replace("á", "&aacute;");

            // "U+000E2", "LATIN SMALL LETTER A WITH CIRCUMFLEX"
            txt = txt.Replace("â", "&acirc;");

            // "U+000E3", "LATIN SMALL LETTER A WITH TILDE"
            txt = txt.Replace("ã", "&atilde;");

            // "U+000E4", "LATIN SMALL LETTER A WITH DIAERESIS"
            txt = txt.Replace("ä", "&auml;");

            // "U+000E5", "LATIN SMALL LETTER A WITH RING ABOVE"
            txt = txt.Replace("å", "&aring;");

            // "U+000E6", "LATIN SMALL LETTER AE"
            txt = txt.Replace("æ", "&aelig;");

            // "U+000E7", "LATIN SMALL LETTER C WITH CEDILLA"
            txt = txt.Replace("ç", "&ccedil;");

            // "U+000E8", "LATIN SMALL LETTER E WITH GRAVE"
            txt = txt.Replace("è", "&egrave;");

            // "U+000E9", "LATIN SMALL LETTER E WITH ACUTE"
            txt = txt.Replace("é", "&eacute;");

            // "U+000EA", "LATIN SMALL LETTER E WITH CIRCUMFLEX"
            txt = txt.Replace("ê", "&ecirc;");

            // "U+000EB", "LATIN SMALL LETTER E WITH DIAERESIS"
            txt = txt.Replace("ë", "&euml;");

            // "U+000EC", "LATIN SMALL LETTER I WITH GRAVE"
            txt = txt.Replace("ì", "&igrave;");

            // "U+000ED", "LATIN SMALL LETTER I WITH ACUTE"
            txt = txt.Replace("í", "&iacute;");

            // "U+000EE", "LATIN SMALL LETTER I WITH CIRCUMFLEX"
            txt = txt.Replace("î", "&icirc;");

            // "U+000EF", "LATIN SMALL LETTER I WITH DIAERESIS"
            txt = txt.Replace("ï", "&iuml;");

            // "U+000F0", "LATIN SMALL LETTER ETH"
            txt = txt.Replace("ð", "&eth;");

            // "U+000F1", "LATIN SMALL LETTER N WITH TILDE"
            txt = txt.Replace("ñ", "&ntilde;");

            // "U+000F2", "LATIN SMALL LETTER O WITH GRAVE"
            txt = txt.Replace("ò", "&ograve;");

            // "U+000F3", "LATIN SMALL LETTER O WITH ACUTE"
            txt = txt.Replace("ó", "&oacute;");

            // "U+000F4", "LATIN SMALL LETTER O WITH CIRCUMFLEX"
            txt = txt.Replace("ô", "&ocirc;");

            // "U+000F5", "LATIN SMALL LETTER O WITH TILDE"
            txt = txt.Replace("õ", "&otilde;");

            // "U+000F6", "LATIN SMALL LETTER O WITH DIAERESIS"
            txt = txt.Replace("ö", "&ouml;");

            // "U+000F7", "DIVISION SIGN"
            txt = txt.Replace("÷", "&divide;");

            // "U+000F8", "LATIN SMALL LETTER O WITH STROKE"
            txt = txt.Replace("ø", "&oslash;");

            // "U+000F9", "LATIN SMALL LETTER U WITH GRAVE"
            txt = txt.Replace("ù", "&ugrave;");

            // "U+000FA", "LATIN SMALL LETTER U WITH ACUTE"
            txt = txt.Replace("ú", "&uacute;");

            // "U+000FB", "LATIN SMALL LETTER U WITH CIRCUMFLEX"
            txt = txt.Replace("û", "&ucirc;");

            // "U+000FC", "LATIN SMALL LETTER U WITH DIAERESIS"
            txt = txt.Replace("ü", "&uuml;");

            // "U+000FD", "LATIN SMALL LETTER Y WITH ACUTE"
            txt = txt.Replace("ý", "&yacute;");

            // "U+000FE", "LATIN SMALL LETTER THORN"
            txt = txt.Replace("þ", "&thorn;");

            // "U+000FF", "LATIN SMALL LETTER Y WITH DIAERESIS"
            txt = txt.Replace("ÿ", "&yuml;");

            // "U+00100", "LATIN CAPITAL LETTER A WITH MACRON"
            txt = txt.Replace("Ā", "&Amacr;");

            // "U+00101", "LATIN SMALL LETTER A WITH MACRON"
            txt = txt.Replace("ā", "&amacr;");

            // "U+00102", "LATIN CAPITAL LETTER A WITH BREVE"
            txt = txt.Replace("Ă", "&Abreve;");

            // "U+00103", "LATIN SMALL LETTER A WITH BREVE"
            txt = txt.Replace("ă", "&abreve;");

            // "U+00104", "LATIN CAPITAL LETTER A WITH OGONEK"
            txt = txt.Replace("Ą", "&Aogon;");

            // "U+00105", "LATIN SMALL LETTER A WITH OGONEK"
            txt = txt.Replace("ą", "&aogon;");

            // "U+00106", "LATIN CAPITAL LETTER C WITH ACUTE"
            txt = txt.Replace("Ć", "&Cacute;");

            // "U+00107", "LATIN SMALL LETTER C WITH ACUTE"
            txt = txt.Replace("ć", "&cacute;");

            // "U+00108", "LATIN CAPITAL LETTER C WITH CIRCUMFLEX"
            txt = txt.Replace("Ĉ", "&Ccirc;");

            // "U+00109", "LATIN SMALL LETTER C WITH CIRCUMFLEX"
            txt = txt.Replace("ĉ", "&ccirc;");

            // "U+0010A", "LATIN CAPITAL LETTER C WITH DOT ABOVE"
            txt = txt.Replace("Ċ", "&Cdot;");

            // "U+0010B", "LATIN SMALL LETTER C WITH DOT ABOVE"
            txt = txt.Replace("ċ", "&cdot;");

            // "U+0010C", "LATIN CAPITAL LETTER C WITH CARON"
            txt = txt.Replace("Č", "&Ccaron;");

            // "U+0010D", "LATIN SMALL LETTER C WITH CARON"
            txt = txt.Replace("č", "&ccaron;");

            // "U+0010E", "LATIN CAPITAL LETTER D WITH CARON"
            txt = txt.Replace("Ď", "&Dcaron;");

            // "U+0010F", "LATIN SMALL LETTER D WITH CARON"
            txt = txt.Replace("ď", "&dcaron;");

            // "U+00110", "LATIN CAPITAL LETTER D WITH STROKE"
            txt = txt.Replace("Đ", "&Dstrok;");

            // "U+00111", "LATIN SMALL LETTER D WITH STROKE"
            txt = txt.Replace("đ", "&dstrok;");

            // "U+00112", "LATIN CAPITAL LETTER E WITH MACRON"
            txt = txt.Replace("Ē", "&Emacr;");

            // "U+00113", "LATIN SMALL LETTER E WITH MACRON"
            txt = txt.Replace("ē", "&emacr;");

            // "U+00116", "LATIN CAPITAL LETTER E WITH DOT ABOVE"
            txt = txt.Replace("Ė", "&Edot;");

            // "U+00117", "LATIN SMALL LETTER E WITH DOT ABOVE"
            txt = txt.Replace("ė", "&edot;");

            // "U+00118", "LATIN CAPITAL LETTER E WITH OGONEK"
            txt = txt.Replace("Ę", "&Eogon;");

            // "U+00119", "LATIN SMALL LETTER E WITH OGONEK"
            txt = txt.Replace("ę", "&eogon;");

            // "U+0011A", "LATIN CAPITAL LETTER E WITH CARON"
            txt = txt.Replace("Ě", "&Ecaron;");

            // "U+0011B", "LATIN SMALL LETTER E WITH CARON"
            txt = txt.Replace("ě", "&ecaron;");

            // "U+0011C", "LATIN CAPITAL LETTER G WITH CIRCUMFLEX"
            txt = txt.Replace("Ĝ", "&Gcirc;");

            // "U+0011D", "LATIN SMALL LETTER G WITH CIRCUMFLEX"
            txt = txt.Replace("ĝ", "&gcirc;");

            // "U+0011E", "LATIN CAPITAL LETTER G WITH BREVE"
            txt = txt.Replace("Ğ", "&Gbreve;");

            // "U+0011F", "LATIN SMALL LETTER G WITH BREVE"
            txt = txt.Replace("ğ", "&gbreve;");

            // "U+00120", "LATIN CAPITAL LETTER G WITH DOT ABOVE"
            txt = txt.Replace("Ġ", "&Gdot;");

            // "U+00121", "LATIN SMALL LETTER G WITH DOT ABOVE"
            txt = txt.Replace("ġ", "&gdot;");

            // "U+00122", "LATIN CAPITAL LETTER G WITH CEDILLA"
            txt = txt.Replace("Ģ", "&Gcedil;");

            // "U+00124", "LATIN CAPITAL LETTER H WITH CIRCUMFLEX"
            txt = txt.Replace("Ĥ", "&Hcirc;");

            // "U+00125", "LATIN SMALL LETTER H WITH CIRCUMFLEX"
            txt = txt.Replace("ĥ", "&hcirc;");

            // "U+00126", "LATIN CAPITAL LETTER H WITH STROKE"
            txt = txt.Replace("Ħ", "&Hstrok;");

            // "U+00127", "LATIN SMALL LETTER H WITH STROKE"
            txt = txt.Replace("ħ", "&hstrok;");

            // "U+00128", "LATIN CAPITAL LETTER I WITH TILDE"
            txt = txt.Replace("Ĩ", "&Itilde;");

            // "U+00129", "LATIN SMALL LETTER I WITH TILDE"
            txt = txt.Replace("ĩ", "&itilde;");

            // "U+0012A", "LATIN CAPITAL LETTER I WITH MACRON"
            txt = txt.Replace("Ī", "&Imacr;");

            // "U+0012B", "LATIN SMALL LETTER I WITH MACRON"
            txt = txt.Replace("ī", "&imacr;");

            // "U+0012E", "LATIN CAPITAL LETTER I WITH OGONEK"
            txt = txt.Replace("Į", "&Iogon;");

            // "U+0012F", "LATIN SMALL LETTER I WITH OGONEK"
            txt = txt.Replace("į", "&iogon;");

            // "U+00130", "LATIN CAPITAL LETTER I WITH DOT ABOVE"
            txt = txt.Replace("İ", "&Idot;");

            // "U+00131", "LATIN SMALL LETTER DOTLESS I"
            txt = txt.Replace("ı", "&imath;");

            // "U+00132", "LATIN CAPITAL LIGATURE IJ"
            txt = txt.Replace("Ĳ", "&IJlig;");

            // "U+00133", "LATIN SMALL LIGATURE IJ"
            txt = txt.Replace("ĳ", "&ijlig;");

            // "U+00134", "LATIN CAPITAL LETTER J WITH CIRCUMFLEX"
            txt = txt.Replace("Ĵ", "&Jcirc;");

            // "U+00135", "LATIN SMALL LETTER J WITH CIRCUMFLEX"
            txt = txt.Replace("ĵ", "&jcirc;");

            // "U+00136", "LATIN CAPITAL LETTER K WITH CEDILLA"
            txt = txt.Replace("Ķ", "&Kcedil;");

            // "U+00137", "LATIN SMALL LETTER K WITH CEDILLA"
            txt = txt.Replace("ķ", "&kcedil;");

            // "U+00138", "LATIN SMALL LETTER KRA"
            txt = txt.Replace("ĸ", "&kgreen;");

            // "U+00139", "LATIN CAPITAL LETTER L WITH ACUTE"
            txt = txt.Replace("Ĺ", "&Lacute;");

            // "U+0013A", "LATIN SMALL LETTER L WITH ACUTE"
            txt = txt.Replace("ĺ", "&lacute;");

            // "U+0013B", "LATIN CAPITAL LETTER L WITH CEDILLA"
            txt = txt.Replace("Ļ", "&Lcedil;");

            // "U+0013C", "LATIN SMALL LETTER L WITH CEDILLA"
            txt = txt.Replace("ļ", "&lcedil;");

            // "U+0013D", "LATIN CAPITAL LETTER L WITH CARON"
            txt = txt.Replace("Ľ", "&Lcaron;");

            // "U+0013E", "LATIN SMALL LETTER L WITH CARON"
            txt = txt.Replace("ľ", "&lcaron;");

            // "U+0013F", "LATIN CAPITAL LETTER L WITH MIDDLE DOT"
            txt = txt.Replace("Ŀ", "&Lmidot;");

            // "U+00140", "LATIN SMALL LETTER L WITH MIDDLE DOT"
            txt = txt.Replace("ŀ", "&lmidot;");

            // "U+00141", "LATIN CAPITAL LETTER L WITH STROKE"
            txt = txt.Replace("Ł", "&Lstrok;");

            // "U+00142", "LATIN SMALL LETTER L WITH STROKE"
            txt = txt.Replace("ł", "&lstrok;");

            // "U+00143", "LATIN CAPITAL LETTER N WITH ACUTE"
            txt = txt.Replace("Ń", "&Nacute;");

            // "U+00144", "LATIN SMALL LETTER N WITH ACUTE"
            txt = txt.Replace("ń", "&nacute;");

            // "U+00145", "LATIN CAPITAL LETTER N WITH CEDILLA"
            txt = txt.Replace("Ņ", "&Ncedil;");

            // "U+00146", "LATIN SMALL LETTER N WITH CEDILLA"
            txt = txt.Replace("ņ", "&ncedil;");

            // "U+00147", "LATIN CAPITAL LETTER N WITH CARON"
            txt = txt.Replace("Ň", "&Ncaron;");

            // "U+00148", "LATIN SMALL LETTER N WITH CARON"
            txt = txt.Replace("ň", "&ncaron;");

            // "U+00149", "LATIN SMALL LETTER N PRECEDED BY APOSTROPHE"
            txt = txt.Replace("ŉ", "&napos;");

            // "U+0014A", "LATIN CAPITAL LETTER ENG"
            txt = txt.Replace("Ŋ", "&ENG;");

            // "U+0014B", "LATIN SMALL LETTER ENG"
            txt = txt.Replace("ŋ", "&eng;");

            // "U+0014C", "LATIN CAPITAL LETTER O WITH MACRON"
            txt = txt.Replace("Ō", "&Omacr;");

            // "U+0014D", "LATIN SMALL LETTER O WITH MACRON"
            txt = txt.Replace("ō", "&omacr;");

            // "U+00150", "LATIN CAPITAL LETTER O WITH DOUBLE ACUTE"
            txt = txt.Replace("Ő", "&Odblac;");

            // "U+00151", "LATIN SMALL LETTER O WITH DOUBLE ACUTE"
            txt = txt.Replace("ő", "&odblac;");

            // "U+00152", "LATIN CAPITAL LIGATURE OE"
            txt = txt.Replace("Œ", "&OElig;");

            // "U+00153", "LATIN SMALL LIGATURE OE"
            txt = txt.Replace("œ", "&oelig;");

            // "U+00154", "LATIN CAPITAL LETTER R WITH ACUTE"
            txt = txt.Replace("Ŕ", "&Racute;");

            // "U+00155", "LATIN SMALL LETTER R WITH ACUTE"
            txt = txt.Replace("ŕ", "&racute;");

            // "U+00156", "LATIN CAPITAL LETTER R WITH CEDILLA"
            txt = txt.Replace("Ŗ", "&Rcedil;");

            // "U+00157", "LATIN SMALL LETTER R WITH CEDILLA"
            txt = txt.Replace("ŗ", "&rcedil;");

            // "U+00158", "LATIN CAPITAL LETTER R WITH CARON"
            txt = txt.Replace("Ř", "&Rcaron;");

            // "U+00159", "LATIN SMALL LETTER R WITH CARON"
            txt = txt.Replace("ř", "&rcaron;");

            // "U+0015A", "LATIN CAPITAL LETTER S WITH ACUTE"
            txt = txt.Replace("Ś", "&Sacute;");

            // "U+0015B", "LATIN SMALL LETTER S WITH ACUTE"
            txt = txt.Replace("ś", "&sacute;");

            // "U+0015C", "LATIN CAPITAL LETTER S WITH CIRCUMFLEX"
            txt = txt.Replace("Ŝ", "&Scirc;");

            // "U+0015D", "LATIN SMALL LETTER S WITH CIRCUMFLEX"
            txt = txt.Replace("ŝ", "&scirc;");

            // "U+0015E", "LATIN CAPITAL LETTER S WITH CEDILLA"
            txt = txt.Replace("Ş", "&Scedil;");

            // "U+0015F", "LATIN SMALL LETTER S WITH CEDILLA"
            txt = txt.Replace("ş", "&scedil;");

            // "U+00160", "LATIN CAPITAL LETTER S WITH CARON"
            txt = txt.Replace("Š", "&Scaron;");

            // "U+00161", "LATIN SMALL LETTER S WITH CARON"
            txt = txt.Replace("š", "&scaron;");

            // "U+00162", "LATIN CAPITAL LETTER T WITH CEDILLA"
            txt = txt.Replace("Ţ", "&Tcedil;");

            // "U+00163", "LATIN SMALL LETTER T WITH CEDILLA"
            txt = txt.Replace("ţ", "&tcedil;");

            // "U+00164", "LATIN CAPITAL LETTER T WITH CARON"
            txt = txt.Replace("Ť", "&Tcaron;");

            // "U+00165", "LATIN SMALL LETTER T WITH CARON"
            txt = txt.Replace("ť", "&tcaron;");

            // "U+00166", "LATIN CAPITAL LETTER T WITH STROKE"
            txt = txt.Replace("Ŧ", "&Tstrok;");

            // "U+00167", "LATIN SMALL LETTER T WITH STROKE"
            txt = txt.Replace("ŧ", "&tstrok;");

            // "U+00168", "LATIN CAPITAL LETTER U WITH TILDE"
            txt = txt.Replace("Ũ", "&Utilde;");

            // "U+00169", "LATIN SMALL LETTER U WITH TILDE"
            txt = txt.Replace("ũ", "&utilde;");

            // "U+0016A", "LATIN CAPITAL LETTER U WITH MACRON"
            txt = txt.Replace("Ū", "&Umacr;");

            // "U+0016B", "LATIN SMALL LETTER U WITH MACRON"
            txt = txt.Replace("ū", "&umacr;");

            // "U+0016C", "LATIN CAPITAL LETTER U WITH BREVE"
            txt = txt.Replace("Ŭ", "&Ubreve;");

            // "U+0016D", "LATIN SMALL LETTER U WITH BREVE"
            txt = txt.Replace("ŭ", "&ubreve;");

            // "U+0016E", "LATIN CAPITAL LETTER U WITH RING ABOVE"
            txt = txt.Replace("Ů", "&Uring;");

            // "U+0016F", "LATIN SMALL LETTER U WITH RING ABOVE"
            txt = txt.Replace("ů", "&uring;");

            // "U+00170", "LATIN CAPITAL LETTER U WITH DOUBLE ACUTE"
            txt = txt.Replace("Ű", "&Udblac;");

            // "U+00171", "LATIN SMALL LETTER U WITH DOUBLE ACUTE"
            txt = txt.Replace("ű", "&udblac;");

            // "U+00172", "LATIN CAPITAL LETTER U WITH OGONEK"
            txt = txt.Replace("Ų", "&Uogon;");

            // "U+00173", "LATIN SMALL LETTER U WITH OGONEK"
            txt = txt.Replace("ų", "&uogon;");

            // "U+00174", "LATIN CAPITAL LETTER W WITH CIRCUMFLEX"
            txt = txt.Replace("Ŵ", "&Wcirc;");

            // "U+00175", "LATIN SMALL LETTER W WITH CIRCUMFLEX"
            txt = txt.Replace("ŵ", "&wcirc;");

            // "U+00176", "LATIN CAPITAL LETTER Y WITH CIRCUMFLEX"
            txt = txt.Replace("Ŷ", "&Ycirc;");

            // "U+00177", "LATIN SMALL LETTER Y WITH CIRCUMFLEX"
            txt = txt.Replace("ŷ", "&ycirc;");

            // "U+00178", "LATIN CAPITAL LETTER Y WITH DIAERESIS"
            txt = txt.Replace("Ÿ", "&Yuml;");

            // "U+00179", "LATIN CAPITAL LETTER Z WITH ACUTE"
            txt = txt.Replace("Ź", "&Zacute;");

            // "U+0017A", "LATIN SMALL LETTER Z WITH ACUTE"
            txt = txt.Replace("ź", "&zacute;");

            // "U+0017B", "LATIN CAPITAL LETTER Z WITH DOT ABOVE"
            txt = txt.Replace("Ż", "&Zdot;");

            // "U+0017C", "LATIN SMALL LETTER Z WITH DOT ABOVE"
            txt = txt.Replace("ż", "&zdot;");

            // "U+0017D", "LATIN CAPITAL LETTER Z WITH CARON"
            txt = txt.Replace("Ž", "&Zcaron;");

            // "U+0017E", "LATIN SMALL LETTER Z WITH CARON"
            txt = txt.Replace("ž", "&zcaron;");

            // "U+00192", "LATIN SMALL LETTER F WITH HOOK"
            txt = txt.Replace("ƒ", "&fnof;");

            // "U+001B5", "LATIN CAPITAL LETTER Z WITH STROKE"
            txt = txt.Replace("Ƶ", "&imped;");

            // "U+001F5", "LATIN SMALL LETTER G WITH ACUTE"
            txt = txt.Replace("ǵ", "&gacute;");

            // "U+00237", "LATIN SMALL LETTER DOTLESS J"
            txt = txt.Replace("ȷ", "&jmath;");

            // "U+002C6", "MODIFIER LETTER CIRCUMFLEX ACCENT"
            txt = txt.Replace("ˆ", "&circ;");

            // "U+002C7", "CARON"
            txt = txt.Replace("ˇ", "&caron;");

            // "U+002D8", "BREVE"
            txt = txt.Replace("˘", "&breve;");

            // "U+002D9", "DOT ABOVE"
            txt = txt.Replace("˙", "&dot;");

            // "U+002DA", "RING ABOVE"
            txt = txt.Replace("˚", "&ring;");

            // "U+002DB", "OGONEK"
            txt = txt.Replace("˛", "&ogon;");

            // "U+002DC", "SMALL TILDE"
            txt = txt.Replace("˜", "&tilde;");

            // "U+002DD", "DOUBLE ACUTE ACCENT"
            txt = txt.Replace("˝", "&dblac;");

            // "U+00311", "COMBINING INVERTED BREVE"
            txt = txt.Replace("̑", "&DownBreve;");

            // "U+00332", "COMBINING LOW LINE"
            txt = txt.Replace("̲", "&UnderBar;");

            // "U+00391", "GREEK CAPITAL LETTER ALPHA"
            txt = txt.Replace("Α", "&Alpha;");

            // "U+00392", "GREEK CAPITAL LETTER BETA"
            txt = txt.Replace("Β", "&Beta;");

            // "U+00393", "GREEK CAPITAL LETTER GAMMA"
            txt = txt.Replace("Γ", "&Gamma;");

            // "U+00394", "GREEK CAPITAL LETTER DELTA"
            txt = txt.Replace("Δ", "&Delta;");

            // "U+00395", "GREEK CAPITAL LETTER EPSILON"
            txt = txt.Replace("Ε", "&Epsilon;");

            // "U+00396", "GREEK CAPITAL LETTER ZETA"
            txt = txt.Replace("Ζ", "&Zeta;");

            // "U+00397", "GREEK CAPITAL LETTER ETA"
            txt = txt.Replace("Η", "&Eta;");

            // "U+00398", "GREEK CAPITAL LETTER THETA"
            txt = txt.Replace("Θ", "&Theta;");

            // "U+00399", "GREEK CAPITAL LETTER IOTA"
            txt = txt.Replace("Ι", "&Iota;");

            // "U+0039A", "GREEK CAPITAL LETTER KAPPA"
            txt = txt.Replace("Κ", "&Kappa;");

            // "U+0039B", "GREEK CAPITAL LETTER LAMDA"
            txt = txt.Replace("Λ", "&Lambda;");

            // "U+0039C", "GREEK CAPITAL LETTER MU"
            txt = txt.Replace("Μ", "&Mu;");

            // "U+0039D", "GREEK CAPITAL LETTER NU"
            txt = txt.Replace("Ν", "&Nu;");

            // "U+0039E", "GREEK CAPITAL LETTER XI"
            txt = txt.Replace("Ξ", "&Xi;");

            // "U+0039F", "GREEK CAPITAL LETTER OMICRON"
            txt = txt.Replace("Ο", "&Omicron;");

            // "U+003A0", "GREEK CAPITAL LETTER PI"
            txt = txt.Replace("Π", "&Pi;");

            // "U+003A1", "GREEK CAPITAL LETTER RHO"
            txt = txt.Replace("Ρ", "&Rho;");

            // "U+003A3", "GREEK CAPITAL LETTER SIGMA"
            txt = txt.Replace("Σ", "&Sigma;");

            // "U+003A4", "GREEK CAPITAL LETTER TAU"
            txt = txt.Replace("Τ", "&Tau;");

            // "U+003A5", "GREEK CAPITAL LETTER UPSILON"
            txt = txt.Replace("Υ", "&Upsilon;");

            // "U+003A6", "GREEK CAPITAL LETTER PHI"
            txt = txt.Replace("Φ", "&Phi;");

            // "U+003A7", "GREEK CAPITAL LETTER CHI"
            txt = txt.Replace("Χ", "&Chi;");

            // "U+003A8", "GREEK CAPITAL LETTER PSI"
            txt = txt.Replace("Ψ", "&Psi;");

            // "U+003A9", "GREEK CAPITAL LETTER OMEGA"
            txt = txt.Replace("Ω", "&Omega;");

            // "U+003B1", "GREEK SMALL LETTER ALPHA"
            txt = txt.Replace("α", "&alpha;");

            // "U+003B2", "GREEK SMALL LETTER BETA"
            txt = txt.Replace("β", "&beta;");

            // "U+003B3", "GREEK SMALL LETTER GAMMA"
            txt = txt.Replace("γ", "&gamma;");

            // "U+003B4", "GREEK SMALL LETTER DELTA"
            txt = txt.Replace("δ", "&delta;");

            // "U+003B5", "GREEK SMALL LETTER EPSILON"
            txt = txt.Replace("ε", "&epsiv;");

            // "U+003B6", "GREEK SMALL LETTER ZETA"
            txt = txt.Replace("ζ", "&zeta;");

            // "U+003B7", "GREEK SMALL LETTER ETA"
            txt = txt.Replace("η", "&eta;");

            // "U+003B8", "GREEK SMALL LETTER THETA"
            txt = txt.Replace("θ", "&theta;");

            // "U+003B9", "GREEK SMALL LETTER IOTA"
            txt = txt.Replace("ι", "&iota;");

            // "U+003BA", "GREEK SMALL LETTER KAPPA"
            txt = txt.Replace("κ", "&kappa;");

            // "U+003BB", "GREEK SMALL LETTER LAMDA"
            txt = txt.Replace("λ", "&lambda;");

            // "U+003BC", "GREEK SMALL LETTER MU"
            txt = txt.Replace("μ", "&mu;");

            // "U+003BD", "GREEK SMALL LETTER NU"
            txt = txt.Replace("ν", "&nu;");

            // "U+003BE", "GREEK SMALL LETTER XI"
            txt = txt.Replace("ξ", "&xi;");

            // "U+003BF", "GREEK SMALL LETTER OMICRON"
            txt = txt.Replace("ο", "&omicron;");

            // "U+003C0", "GREEK SMALL LETTER PI"
            txt = txt.Replace("π", "&pi;");

            // "U+003C1", "GREEK SMALL LETTER RHO"
            txt = txt.Replace("ρ", "&rho;");

            // "U+003C2", "GREEK SMALL LETTER FINAL SIGMA"
            txt = txt.Replace("ς", "&sigmav;");

            // "U+003C3", "GREEK SMALL LETTER SIGMA"
            txt = txt.Replace("σ", "&sigma;");

            // "U+003C4", "GREEK SMALL LETTER TAU"
            txt = txt.Replace("τ", "&tau;");

            // "U+003C5", "GREEK SMALL LETTER UPSILON"
            txt = txt.Replace("υ", "&upsi;");

            // "U+003C6", "GREEK SMALL LETTER PHI"
            txt = txt.Replace("φ", "&phi;");

            // "U+003C7", "GREEK SMALL LETTER CHI"
            txt = txt.Replace("χ", "&chi;");

            // "U+003C8", "GREEK SMALL LETTER PSI"
            txt = txt.Replace("ψ", "&psi;");

            // "U+003C9", "GREEK SMALL LETTER OMEGA"
            txt = txt.Replace("ω", "&omega;");

            // "U+003D1", "GREEK THETA SYMBOL"
            txt = txt.Replace("ϑ", "&thetav;");

            // "U+003D2", "GREEK UPSILON WITH HOOK SYMBOL"
            txt = txt.Replace("ϒ", "&Upsi;");

            // "U+003D5", "GREEK PHI SYMBOL"
            txt = txt.Replace("ϕ", "&straightphi;");

            // "U+003D6", "GREEK PI SYMBOL"
            txt = txt.Replace("ϖ", "&piv;");

            // "U+003DC", "GREEK LETTER DIGAMMA"
            txt = txt.Replace("Ϝ", "&Gammad;");

            // "U+003DD", "GREEK SMALL LETTER DIGAMMA"
            txt = txt.Replace("ϝ", "&gammad;");

            // "U+003F0", "GREEK KAPPA SYMBOL"
            txt = txt.Replace("ϰ", "&kappav;");

            // "U+003F1", "GREEK RHO SYMBOL"
            txt = txt.Replace("ϱ", "&rhov;");

            // "U+003F5", "GREEK LUNATE EPSILON SYMBOL"
            txt = txt.Replace("ϵ", "&epsi;");

            // "U+003F6", "GREEK REVERSED LUNATE EPSILON SYMBOL"
            txt = txt.Replace("϶", "&bepsi;");

            // "U+00401", "CYRILLIC CAPITAL LETTER IO"
            txt = txt.Replace("Ё", "&IOcy;");

            // "U+00402", "CYRILLIC CAPITAL LETTER DJE"
            txt = txt.Replace("Ђ", "&DJcy;");

            // "U+00403", "CYRILLIC CAPITAL LETTER GJE"
            txt = txt.Replace("Ѓ", "&GJcy;");

            // "U+00404", "CYRILLIC CAPITAL LETTER UKRAINIAN IE"
            txt = txt.Replace("Є", "&Jukcy;");

            // "U+00405", "CYRILLIC CAPITAL LETTER DZE"
            txt = txt.Replace("Ѕ", "&DScy;");

            // "U+00406", "CYRILLIC CAPITAL LETTER BYELORUSSIAN-UKRAINIAN I"
            txt = txt.Replace("І", "&Iukcy;");

            // "U+00407", "CYRILLIC CAPITAL LETTER YI"
            txt = txt.Replace("Ї", "&YIcy;");

            // "U+00408", "CYRILLIC CAPITAL LETTER JE"
            txt = txt.Replace("Ј", "&Jsercy;");

            // "U+00409", "CYRILLIC CAPITAL LETTER LJE"
            txt = txt.Replace("Љ", "&LJcy;");

            // "U+0040A", "CYRILLIC CAPITAL LETTER NJE"
            txt = txt.Replace("Њ", "&NJcy;");

            // "U+0040B", "CYRILLIC CAPITAL LETTER TSHE"
            txt = txt.Replace("Ћ", "&TSHcy;");

            // "U+0040C", "CYRILLIC CAPITAL LETTER KJE"
            txt = txt.Replace("Ќ", "&KJcy;");

            // "U+0040E", "CYRILLIC CAPITAL LETTER SHORT U"
            txt = txt.Replace("Ў", "&Ubrcy;");

            // "U+0040F", "CYRILLIC CAPITAL LETTER DZHE"
            txt = txt.Replace("Џ", "&DZcy;");

            // "U+00410", "CYRILLIC CAPITAL LETTER A"
            txt = txt.Replace("А", "&Acy;");

            // "U+00411", "CYRILLIC CAPITAL LETTER BE"
            txt = txt.Replace("Б", "&Bcy;");

            // "U+00412", "CYRILLIC CAPITAL LETTER VE"
            txt = txt.Replace("В", "&Vcy;");

            // "U+00413", "CYRILLIC CAPITAL LETTER GHE"
            txt = txt.Replace("Г", "&Gcy;");

            // "U+00414", "CYRILLIC CAPITAL LETTER DE"
            txt = txt.Replace("Д", "&Dcy;");

            // "U+00415", "CYRILLIC CAPITAL LETTER IE"
            txt = txt.Replace("Е", "&IEcy;");

            // "U+00416", "CYRILLIC CAPITAL LETTER ZHE"
            txt = txt.Replace("Ж", "&ZHcy;");

            // "U+00417", "CYRILLIC CAPITAL LETTER ZE"
            txt = txt.Replace("З", "&Zcy;");

            // "U+00418", "CYRILLIC CAPITAL LETTER I"
            txt = txt.Replace("И", "&Icy;");

            // "U+00419", "CYRILLIC CAPITAL LETTER SHORT I"
            txt = txt.Replace("Й", "&Jcy;");

            // "U+0041A", "CYRILLIC CAPITAL LETTER KA"
            txt = txt.Replace("К", "&Kcy;");

            // "U+0041B", "CYRILLIC CAPITAL LETTER EL"
            txt = txt.Replace("Л", "&Lcy;");

            // "U+0041C", "CYRILLIC CAPITAL LETTER EM"
            txt = txt.Replace("М", "&Mcy;");

            // "U+0041D", "CYRILLIC CAPITAL LETTER EN"
            txt = txt.Replace("Н", "&Ncy;");

            // "U+0041E", "CYRILLIC CAPITAL LETTER O"
            txt = txt.Replace("О", "&Ocy;");

            // "U+0041F", "CYRILLIC CAPITAL LETTER PE"
            txt = txt.Replace("П", "&Pcy;");

            // "U+00420", "CYRILLIC CAPITAL LETTER ER"
            txt = txt.Replace("Р", "&Rcy;");

            // "U+00421", "CYRILLIC CAPITAL LETTER ES"
            txt = txt.Replace("С", "&Scy;");

            // "U+00422", "CYRILLIC CAPITAL LETTER TE"
            txt = txt.Replace("Т", "&Tcy;");

            // "U+00423", "CYRILLIC CAPITAL LETTER U"
            txt = txt.Replace("У", "&Ucy;");

            // "U+00424", "CYRILLIC CAPITAL LETTER EF"
            txt = txt.Replace("Ф", "&Fcy;");

            // "U+00425", "CYRILLIC CAPITAL LETTER HA"
            txt = txt.Replace("Х", "&KHcy;");

            // "U+00426", "CYRILLIC CAPITAL LETTER TSE"
            txt = txt.Replace("Ц", "&TScy;");

            // "U+00427", "CYRILLIC CAPITAL LETTER CHE"
            txt = txt.Replace("Ч", "&CHcy;");

            // "U+00428", "CYRILLIC CAPITAL LETTER SHA"
            txt = txt.Replace("Ш", "&SHcy;");

            // "U+00429", "CYRILLIC CAPITAL LETTER SHCHA"
            txt = txt.Replace("Щ", "&SHCHcy;");

            // "U+0042A", "CYRILLIC CAPITAL LETTER HARD SIGN"
            txt = txt.Replace("Ъ", "&HARDcy;");

            // "U+0042B", "CYRILLIC CAPITAL LETTER YERU"
            txt = txt.Replace("Ы", "&Ycy;");

            // "U+0042C", "CYRILLIC CAPITAL LETTER SOFT SIGN"
            txt = txt.Replace("Ь", "&SOFTcy;");

            // "U+0042D", "CYRILLIC CAPITAL LETTER E"
            txt = txt.Replace("Э", "&Ecy;");

            // "U+0042E", "CYRILLIC CAPITAL LETTER YU"
            txt = txt.Replace("Ю", "&YUcy;");

            // "U+0042F", "CYRILLIC CAPITAL LETTER YA"
            txt = txt.Replace("Я", "&YAcy;");

            // "U+00430", "CYRILLIC SMALL LETTER A"
            txt = txt.Replace("а", "&acy;");

            // "U+00431", "CYRILLIC SMALL LETTER BE"
            txt = txt.Replace("б", "&bcy;");

            // "U+00432", "CYRILLIC SMALL LETTER VE"
            txt = txt.Replace("в", "&vcy;");

            // "U+00433", "CYRILLIC SMALL LETTER GHE"
            txt = txt.Replace("г", "&gcy;");

            // "U+00434", "CYRILLIC SMALL LETTER DE"
            txt = txt.Replace("д", "&dcy;");

            // "U+00435", "CYRILLIC SMALL LETTER IE"
            txt = txt.Replace("е", "&iecy;");

            // "U+00436", "CYRILLIC SMALL LETTER ZHE"
            txt = txt.Replace("ж", "&zhcy;");

            // "U+00437", "CYRILLIC SMALL LETTER ZE"
            txt = txt.Replace("з", "&zcy;");

            // "U+00438", "CYRILLIC SMALL LETTER I"
            txt = txt.Replace("и", "&icy;");

            // "U+00439", "CYRILLIC SMALL LETTER SHORT I"
            txt = txt.Replace("й", "&jcy;");

            // "U+0043A", "CYRILLIC SMALL LETTER KA"
            txt = txt.Replace("к", "&kcy;");

            // "U+0043B", "CYRILLIC SMALL LETTER EL"
            txt = txt.Replace("л", "&lcy;");

            // "U+0043C", "CYRILLIC SMALL LETTER EM"
            txt = txt.Replace("м", "&mcy;");

            // "U+0043D", "CYRILLIC SMALL LETTER EN"
            txt = txt.Replace("н", "&ncy;");

            // "U+0043E", "CYRILLIC SMALL LETTER O"
            txt = txt.Replace("о", "&ocy;");

            // "U+0043F", "CYRILLIC SMALL LETTER PE"
            txt = txt.Replace("п", "&pcy;");

            // "U+00440", "CYRILLIC SMALL LETTER ER"
            txt = txt.Replace("р", "&rcy;");

            // "U+00441", "CYRILLIC SMALL LETTER ES"
            txt = txt.Replace("с", "&scy;");

            // "U+00442", "CYRILLIC SMALL LETTER TE"
            txt = txt.Replace("т", "&tcy;");

            // "U+00443", "CYRILLIC SMALL LETTER U"
            txt = txt.Replace("у", "&ucy;");

            // "U+00444", "CYRILLIC SMALL LETTER EF"
            txt = txt.Replace("ф", "&fcy;");

            // "U+00445", "CYRILLIC SMALL LETTER HA"
            txt = txt.Replace("х", "&khcy;");

            // "U+00446", "CYRILLIC SMALL LETTER TSE"
            txt = txt.Replace("ц", "&tscy;");

            // "U+00447", "CYRILLIC SMALL LETTER CHE"
            txt = txt.Replace("ч", "&chcy;");

            // "U+00448", "CYRILLIC SMALL LETTER SHA"
            txt = txt.Replace("ш", "&shcy;");

            // "U+00449", "CYRILLIC SMALL LETTER SHCHA"
            txt = txt.Replace("щ", "&shchcy;");

            // "U+0044A", "CYRILLIC SMALL LETTER HARD SIGN"
            txt = txt.Replace("ъ", "&hardcy;");

            // "U+0044B", "CYRILLIC SMALL LETTER YERU"
            txt = txt.Replace("ы", "&ycy;");

            // "U+0044C", "CYRILLIC SMALL LETTER SOFT SIGN"
            txt = txt.Replace("ь", "&softcy;");

            // "U+0044D", "CYRILLIC SMALL LETTER E"
            txt = txt.Replace("э", "&ecy;");

            // "U+0044E", "CYRILLIC SMALL LETTER YU"
            txt = txt.Replace("ю", "&yucy;");

            // "U+0044F", "CYRILLIC SMALL LETTER YA"
            txt = txt.Replace("я", "&yacy;");

            // "U+00451", "CYRILLIC SMALL LETTER IO"
            txt = txt.Replace("ё", "&iocy;");

            // "U+00452", "CYRILLIC SMALL LETTER DJE"
            txt = txt.Replace("ђ", "&djcy;");

            // "U+00453", "CYRILLIC SMALL LETTER GJE"
            txt = txt.Replace("ѓ", "&gjcy;");

            // "U+00454", "CYRILLIC SMALL LETTER UKRAINIAN IE"
            txt = txt.Replace("є", "&jukcy;");

            // "U+00455", "CYRILLIC SMALL LETTER DZE"
            txt = txt.Replace("ѕ", "&dscy;");

            // "U+00456", "CYRILLIC SMALL LETTER BYELORUSSIAN-UKRAINIAN I"
            txt = txt.Replace("і", "&iukcy;");

            // "U+00457", "CYRILLIC SMALL LETTER YI"
            txt = txt.Replace("ї", "&yicy;");

            // "U+00458", "CYRILLIC SMALL LETTER JE"
            txt = txt.Replace("ј", "&jsercy;");

            // "U+00459", "CYRILLIC SMALL LETTER LJE"
            txt = txt.Replace("љ", "&ljcy;");

            // "U+0045A", "CYRILLIC SMALL LETTER NJE"
            txt = txt.Replace("њ", "&njcy;");

            // "U+0045B", "CYRILLIC SMALL LETTER TSHE"
            txt = txt.Replace("ћ", "&tshcy;");

            // "U+0045C", "CYRILLIC SMALL LETTER KJE"
            txt = txt.Replace("ќ", "&kjcy;");

            // "U+0045E", "CYRILLIC SMALL LETTER SHORT U"
            txt = txt.Replace("ў", "&ubrcy;");

            // "U+0045F", "CYRILLIC SMALL LETTER DZHE"
            txt = txt.Replace("џ", "&dzcy;");

            // "U+02002", "EN SPACE"
            txt = txt.Replace(" ", "&ensp;");

            // "U+02003", "EM SPACE"
            txt = txt.Replace(" ", "&emsp;");

            // "U+02004", "THREE-PER-EM SPACE"
            txt = txt.Replace(" ", "&emsp13;");

            // "U+02005", "FOUR-PER-EM SPACE"
            txt = txt.Replace(" ", "&emsp14;");

            // "U+02007", "FIGURE SPACE"
            txt = txt.Replace(" ", "&numsp;");

            // "U+02008", "PUNCTUATION SPACE"
            txt = txt.Replace(" ", "&puncsp;");

            // "U+02009", "THIN SPACE"
            txt = txt.Replace(" ", "&thinsp;");

            // "U+0200A", "HAIR SPACE"
            txt = txt.Replace(" ", "&hairsp;");

            // "U+0200B", "ZERO WIDTH SPACE"
            txt = txt.Replace("​", "&ZeroWidthSpace;");

            // "U+0200C", "ZERO WIDTH NON-JOINER"
            txt = txt.Replace("‌", "&zwnj;");

            // "U+0200D", "ZERO WIDTH JOINER"
            txt = txt.Replace("‍", "&zwj;");

            // "U+0200E", "LEFT-TO-RIGHT MARK"
            txt = txt.Replace("‎", "&lrm;");

            // "U+0200F", "RIGHT-TO-LEFT MARK"
            txt = txt.Replace("‏", "&rlm;");

            // "U+02010", "HYPHEN"
            txt = txt.Replace("‐", "&hyphen;");

            // "U+02013", "EN DASH"
            txt = txt.Replace("–", "&ndash;");

            // "U+02014", "EM DASH"
            txt = txt.Replace("—", "&mdash;");

            // "U+02015", "HORIZONTAL BAR"
            txt = txt.Replace("―", "&horbar;");

            // "U+02016", "DOUBLE VERTICAL LINE"
            txt = txt.Replace("‖", "&Verbar;");

            // "U+02018", "LEFT SINGLE QUOTATION MARK"
            txt = txt.Replace("‘", "&lsquo;");

            // "U+02019", "RIGHT SINGLE QUOTATION MARK"
            txt = txt.Replace("’", "&rsquo;");

            // "U+0201A", "SINGLE LOW-9 QUOTATION MARK"
            txt = txt.Replace("‚", "&lsquor;");

            // "U+0201C", "LEFT DOUBLE QUOTATION MARK"
            txt = txt.Replace("“", "&ldquo;");

            // "U+0201D", "RIGHT DOUBLE QUOTATION MARK"
            txt = txt.Replace("”", "&rdquo;");

            // "U+0201E", "DOUBLE LOW-9 QUOTATION MARK"
            txt = txt.Replace("„", "&ldquor;");

            // "U+02020", "DAGGER"
            txt = txt.Replace("†", "&dagger;");

            // "U+02021", "DOUBLE DAGGER"
            txt = txt.Replace("‡", "&Dagger;");

            // "U+02022", "BULLET"
            txt = txt.Replace("•", "&bull;");

            // "U+02025", "TWO DOT LEADER"
            txt = txt.Replace("‥", "&nldr;");

            // "U+02026", "HORIZONTAL ELLIPSIS"
            txt = txt.Replace("…", "&hellip;");

            // "U+02030", "PER MILLE SIGN"
            txt = txt.Replace("‰", "&permil;");

            // "U+02031", "PER TEN THOUSAND SIGN"
            txt = txt.Replace("‱", "&pertenk;");

            // "U+02032", "PRIME"
            txt = txt.Replace("′", "&prime;");

            // "U+02033", "DOUBLE PRIME"
            txt = txt.Replace("″", "&Prime;");

            // "U+02034", "TRIPLE PRIME"
            txt = txt.Replace("‴", "&tprime;");

            // "U+02035", "REVERSED PRIME"
            txt = txt.Replace("‵", "&bprime;");

            // "U+02039", "SINGLE LEFT-POINTING ANGLE QUOTATION MARK"
            txt = txt.Replace("‹", "&lsaquo;");

            // "U+0203A", "SINGLE RIGHT-POINTING ANGLE QUOTATION MARK"
            txt = txt.Replace("›", "&rsaquo;");

            // "U+0203E", "OVERLINE"
            txt = txt.Replace("‾", "&oline;");

            // "U+02041", "CARET INSERTION POINT"
            txt = txt.Replace("⁁", "&caret;");

            // "U+02043", "HYPHEN BULLET"
            txt = txt.Replace("⁃", "&hybull;");

            // "U+02044", "FRACTION SLASH"
            txt = txt.Replace("⁄", "&frasl;");

            // "U+0204F", "REVERSED SEMICOLON"
            txt = txt.Replace("⁏", "&bsemi;");

            // "U+02057", "QUADRUPLE PRIME"
            txt = txt.Replace("⁗", "&qprime;");

            // "U+0205F", "MEDIUM MATHEMATICAL SPACE"
            txt = txt.Replace(" ", "&MediumSpace;");

            // "U+02060", "WORD JOINER"
            txt = txt.Replace("⁠", "&NoBreak;");

            // "U+02061", "FUNCTION APPLICATION"
            txt = txt.Replace("⁡", "&ApplyFunction;");

            // "U+02062", "INVISIBLE TIMES"
            txt = txt.Replace("⁢", "&InvisibleTimes;");

            // "U+02063", "INVISIBLE SEPARATOR"
            txt = txt.Replace("⁣", "&InvisibleComma;");

            // "U+020AC", "EURO SIGN"
            txt = txt.Replace("€", "&euro;");

            // "U+020DB", "COMBINING THREE DOTS ABOVE"
            txt = txt.Replace("⃛", "&tdot;");

            // "U+020DC", "COMBINING FOUR DOTS ABOVE"
            txt = txt.Replace("⃜", "&DotDot;");

            // "U+02102", "DOUBLE-STRUCK CAPITAL C"
            txt = txt.Replace("ℂ", "&Copf;");

            // "U+02105", "CARE OF"
            txt = txt.Replace("℅", "&incare;");

            // "U+0210A", "SCRIPT SMALL G"
            txt = txt.Replace("ℊ", "&gscr;");

            // "U+0210B", "SCRIPT CAPITAL H"
            txt = txt.Replace("ℋ", "&hamilt;");

            // "U+0210C", "BLACK-LETTER CAPITAL H"
            txt = txt.Replace("ℌ", "&Hfr;");

            // "U+0210D", "DOUBLE-STRUCK CAPITAL H"
            txt = txt.Replace("ℍ", "&quaternions;");

            // "U+0210E", "PLANCK CONSTANT"
            txt = txt.Replace("ℎ", "&planckh;");

            // "U+0210F", "PLANCK CONSTANT OVER TWO PI"
            txt = txt.Replace("ℏ", "&planck;");

            // "U+02110", "SCRIPT CAPITAL I"
            txt = txt.Replace("ℐ", "&Iscr;");

            // "U+02111", "BLACK-LETTER CAPITAL I"
            txt = txt.Replace("ℑ", "&image;");

            // "U+02112", "SCRIPT CAPITAL L"
            txt = txt.Replace("ℒ", "&Lscr;");

            // "U+02113", "SCRIPT SMALL L"
            txt = txt.Replace("ℓ", "&ell;");

            // "U+02115", "DOUBLE-STRUCK CAPITAL N"
            txt = txt.Replace("ℕ", "&Nopf;");

            // "U+02116", "NUMERO SIGN"
            txt = txt.Replace("№", "&numero;");

            // "U+02117", "SOUND RECORDING COPYRIGHT"
            txt = txt.Replace("℗", "&copysr;");

            // "U+02118", "SCRIPT CAPITAL P"
            txt = txt.Replace("℘", "&weierp;");

            // "U+02119", "DOUBLE-STRUCK CAPITAL P"
            txt = txt.Replace("ℙ", "&Popf;");

            // "U+0211A", "DOUBLE-STRUCK CAPITAL Q"
            txt = txt.Replace("ℚ", "&rationals;");

            // "U+0211B", "SCRIPT CAPITAL R"
            txt = txt.Replace("ℛ", "&Rscr;");

            // "U+0211C", "BLACK-LETTER CAPITAL R"
            txt = txt.Replace("ℜ", "&real;");

            // "U+0211D", "DOUBLE-STRUCK CAPITAL R"
            txt = txt.Replace("ℝ", "&reals;");

            // "U+0211E", "PRESCRIPTION TAKE"
            txt = txt.Replace("℞", "&rx;");

            // "U+02122", "TRADE MARK SIGN"
            txt = txt.Replace("™", "&trade;");

            // "U+02124", "DOUBLE-STRUCK CAPITAL Z"
            txt = txt.Replace("ℤ", "&integers;");

            // "U+02126", "OHM SIGN"
            txt = txt.Replace("Ω", "&ohm;");

            // "U+02127", "INVERTED OHM SIGN"
            txt = txt.Replace("℧", "&mho;");

            // "U+02128", "BLACK-LETTER CAPITAL Z"
            txt = txt.Replace("ℨ", "&Zfr;");

            // "U+02129", "TURNED GREEK SMALL LETTER IOTA"
            txt = txt.Replace("℩", "&iiota;");

            // "U+0212B", "ANGSTROM SIGN"
            txt = txt.Replace("Å", "&angst;");

            // "U+0212C", "SCRIPT CAPITAL B"
            txt = txt.Replace("ℬ", "&bernou;");

            // "U+0212D", "BLACK-LETTER CAPITAL C"
            txt = txt.Replace("ℭ", "&Cfr;");

            // "U+0212F", "SCRIPT SMALL E"
            txt = txt.Replace("ℯ", "&escr;");

            // "U+02130", "SCRIPT CAPITAL E"
            txt = txt.Replace("ℰ", "&Escr;");

            // "U+02131", "SCRIPT CAPITAL F"
            txt = txt.Replace("ℱ", "&Fscr;");

            // "U+02133", "SCRIPT CAPITAL M"
            txt = txt.Replace("ℳ", "&phmmat;");

            // "U+02134", "SCRIPT SMALL O"
            txt = txt.Replace("ℴ", "&order;");

            // "U+02135", "ALEF SYMBOL"
            txt = txt.Replace("ℵ", "&alefsym;");

            // "U+02136", "BET SYMBOL"
            txt = txt.Replace("ℶ", "&beth;");

            // "U+02137", "GIMEL SYMBOL"
            txt = txt.Replace("ℷ", "&gimel;");

            // "U+02138", "DALET SYMBOL"
            txt = txt.Replace("ℸ", "&daleth;");

            // "U+02145", "DOUBLE-STRUCK ITALIC CAPITAL D"
            txt = txt.Replace("ⅅ", "&CapitalDifferentialD;");

            // "U+02146", "DOUBLE-STRUCK ITALIC SMALL D"
            txt = txt.Replace("ⅆ", "&DifferentialD;");

            // "U+02147", "DOUBLE-STRUCK ITALIC SMALL E"
            txt = txt.Replace("ⅇ", "&ExponentialE;");

            // "U+02148", "DOUBLE-STRUCK ITALIC SMALL I"
            txt = txt.Replace("ⅈ", "&ImaginaryI;");

            // "U+02153", "VULGAR FRACTION ONE THIRD"
            txt = txt.Replace("⅓", "&frac13;");

            // "U+02154", "VULGAR FRACTION TWO THIRDS"
            txt = txt.Replace("⅔", "&frac23;");

            // "U+02155", "VULGAR FRACTION ONE FIFTH"
            txt = txt.Replace("⅕", "&frac15;");

            // "U+02156", "VULGAR FRACTION TWO FIFTHS"
            txt = txt.Replace("⅖", "&frac25;");

            // "U+02157", "VULGAR FRACTION THREE FIFTHS"
            txt = txt.Replace("⅗", "&frac35;");

            // "U+02158", "VULGAR FRACTION FOUR FIFTHS"
            txt = txt.Replace("⅘", "&frac45;");

            // "U+02159", "VULGAR FRACTION ONE SIXTH"
            txt = txt.Replace("⅙", "&frac16;");

            // "U+0215A", "VULGAR FRACTION FIVE SIXTHS"
            txt = txt.Replace("⅚", "&frac56;");

            // "U+0215B", "VULGAR FRACTION ONE EIGHTH"
            txt = txt.Replace("⅛", "&frac18;");

            // "U+0215C", "VULGAR FRACTION THREE EIGHTHS"
            txt = txt.Replace("⅜", "&frac38;");

            // "U+0215D", "VULGAR FRACTION FIVE EIGHTHS"
            txt = txt.Replace("⅝", "&frac58;");

            // "U+0215E", "VULGAR FRACTION SEVEN EIGHTHS"
            txt = txt.Replace("⅞", "&frac78;");

            // "U+02190", "LEFTWARDS ARROW"
            txt = txt.Replace("←", "&larr;");

            // "U+02191", "UPWARDS ARROW"
            txt = txt.Replace("↑", "&uarr;");

            // "U+02192", "RIGHTWARDS ARROW"
            txt = txt.Replace("→", "&rarr;");

            // "U+02193", "DOWNWARDS ARROW"
            txt = txt.Replace("↓", "&darr;");

            // "U+02194", "LEFT RIGHT ARROW"
            txt = txt.Replace("↔", "&harr;");

            // "U+02195", "UP DOWN ARROW"
            txt = txt.Replace("↕", "&varr;");

            // "U+02196", "NORTH WEST ARROW"
            txt = txt.Replace("↖", "&nwarr;");

            // "U+02197", "NORTH EAST ARROW"
            txt = txt.Replace("↗", "&nearr;");

            // "U+02198", "SOUTH EAST ARROW"
            txt = txt.Replace("↘", "&searr;");

            // "U+02199", "SOUTH WEST ARROW"
            txt = txt.Replace("↙", "&swarr;");

            // "U+0219A", "LEFTWARDS ARROW WITH STROKE"
            txt = txt.Replace("↚", "&nlarr;");

            // "U+0219B", "RIGHTWARDS ARROW WITH STROKE"
            txt = txt.Replace("↛", "&nrarr;");

            // "U+0219D", "RIGHTWARDS WAVE ARROW"
            txt = txt.Replace("↝", "&rarrw;");

            // "U+0219E", "LEFTWARDS TWO HEADED ARROW"
            txt = txt.Replace("↞", "&Larr;");

            // "U+0219F", "UPWARDS TWO HEADED ARROW"
            txt = txt.Replace("↟", "&Uarr;");

            // "U+021A0", "RIGHTWARDS TWO HEADED ARROW"
            txt = txt.Replace("↠", "&Rarr;");

            // "U+021A1", "DOWNWARDS TWO HEADED ARROW"
            txt = txt.Replace("↡", "&Darr;");

            // "U+021A2", "LEFTWARDS ARROW WITH TAIL"
            txt = txt.Replace("↢", "&larrtl;");

            // "U+021A3", "RIGHTWARDS ARROW WITH TAIL"
            txt = txt.Replace("↣", "&rarrtl;");

            // "U+021A4", "LEFTWARDS ARROW FROM BAR"
            txt = txt.Replace("↤", "&LeftTeeArrow;");

            // "U+021A5", "UPWARDS ARROW FROM BAR"
            txt = txt.Replace("↥", "&UpTeeArrow;");

            // "U+021A6", "RIGHTWARDS ARROW FROM BAR"
            txt = txt.Replace("↦", "&map;");

            // "U+021A7", "DOWNWARDS ARROW FROM BAR"
            txt = txt.Replace("↧", "&DownTeeArrow;");

            // "U+021A9", "LEFTWARDS ARROW WITH HOOK"
            txt = txt.Replace("↩", "&larrhk;");

            // "U+021AA", "RIGHTWARDS ARROW WITH HOOK"
            txt = txt.Replace("↪", "&rarrhk;");

            // "U+021AB", "LEFTWARDS ARROW WITH LOOP"
            txt = txt.Replace("↫", "&larrlp;");

            // "U+021AC", "RIGHTWARDS ARROW WITH LOOP"
            txt = txt.Replace("↬", "&rarrlp;");

            // "U+021AD", "LEFT RIGHT WAVE ARROW"
            txt = txt.Replace("↭", "&harrw;");

            // "U+021AE", "LEFT RIGHT ARROW WITH STROKE"
            txt = txt.Replace("↮", "&nharr;");

            // "U+021B0", "UPWARDS ARROW WITH TIP LEFTWARDS"
            txt = txt.Replace("↰", "&lsh;");

            // "U+021B1", "UPWARDS ARROW WITH TIP RIGHTWARDS"
            txt = txt.Replace("↱", "&rsh;");

            // "U+021B2", "DOWNWARDS ARROW WITH TIP LEFTWARDS"
            txt = txt.Replace("↲", "&ldsh;");

            // "U+021B3", "DOWNWARDS ARROW WITH TIP RIGHTWARDS"
            txt = txt.Replace("↳", "&rdsh;");

            // "U+021B5", "DOWNWARDS ARROW WITH CORNER LEFTWARDS"
            txt = txt.Replace("↵", "&crarr;");

            // "U+021B6", "ANTICLOCKWISE TOP SEMICIRCLE ARROW"
            txt = txt.Replace("↶", "&cularr;");

            // "U+021B7", "CLOCKWISE TOP SEMICIRCLE ARROW"
            txt = txt.Replace("↷", "&curarr;");

            // "U+021BA", "ANTICLOCKWISE OPEN CIRCLE ARROW"
            txt = txt.Replace("↺", "&olarr;");

            // "U+021BB", "CLOCKWISE OPEN CIRCLE ARROW"
            txt = txt.Replace("↻", "&orarr;");

            // "U+021BC", "LEFTWARDS HARPOON WITH BARB UPWARDS"
            txt = txt.Replace("↼", "&lharu;");

            // "U+021BD", "LEFTWARDS HARPOON WITH BARB DOWNWARDS"
            txt = txt.Replace("↽", "&lhard;");

            // "U+021BE", "UPWARDS HARPOON WITH BARB RIGHTWARDS"
            txt = txt.Replace("↾", "&uharr;");

            // "U+021BF", "UPWARDS HARPOON WITH BARB LEFTWARDS"
            txt = txt.Replace("↿", "&uharl;");

            // "U+021C0", "RIGHTWARDS HARPOON WITH BARB UPWARDS"
            txt = txt.Replace("⇀", "&rharu;");

            // "U+021C1", "RIGHTWARDS HARPOON WITH BARB DOWNWARDS"
            txt = txt.Replace("⇁", "&rhard;");

            // "U+021C2", "DOWNWARDS HARPOON WITH BARB RIGHTWARDS"
            txt = txt.Replace("⇂", "&dharr;");

            // "U+021C3", "DOWNWARDS HARPOON WITH BARB LEFTWARDS"
            txt = txt.Replace("⇃", "&dharl;");

            // "U+021C4", "RIGHTWARDS ARROW OVER LEFTWARDS ARROW"
            txt = txt.Replace("⇄", "&rlarr;");

            // "U+021C5", "UPWARDS ARROW LEFTWARDS OF DOWNWARDS ARROW"
            txt = txt.Replace("⇅", "&udarr;");

            // "U+021C6", "LEFTWARDS ARROW OVER RIGHTWARDS ARROW"
            txt = txt.Replace("⇆", "&lrarr;");

            // "U+021C7", "LEFTWARDS PAIRED ARROWS"
            txt = txt.Replace("⇇", "&llarr;");

            // "U+021C8", "UPWARDS PAIRED ARROWS"
            txt = txt.Replace("⇈", "&uuarr;");

            // "U+021C9", "RIGHTWARDS PAIRED ARROWS"
            txt = txt.Replace("⇉", "&rrarr;");

            // "U+021CA", "DOWNWARDS PAIRED ARROWS"
            txt = txt.Replace("⇊", "&ddarr;");

            // "U+021CB", "LEFTWARDS HARPOON OVER RIGHTWARDS HARPOON"
            txt = txt.Replace("⇋", "&lrhar;");

            // "U+021CC", "RIGHTWARDS HARPOON OVER LEFTWARDS HARPOON"
            txt = txt.Replace("⇌", "&rlhar;");

            // "U+021CD", "LEFTWARDS DOUBLE ARROW WITH STROKE"
            txt = txt.Replace("⇍", "&nlArr;");

            // "U+021CE", "LEFT RIGHT DOUBLE ARROW WITH STROKE"
            txt = txt.Replace("⇎", "&nhArr;");

            // "U+021CF", "RIGHTWARDS DOUBLE ARROW WITH STROKE"
            txt = txt.Replace("⇏", "&nrArr;");

            // "U+021D0", "LEFTWARDS DOUBLE ARROW"
            txt = txt.Replace("⇐", "&lArr;");

            // "U+021D1", "UPWARDS DOUBLE ARROW"
            txt = txt.Replace("⇑", "&uArr;");

            // "U+021D2", "RIGHTWARDS DOUBLE ARROW"
            txt = txt.Replace("⇒", "&rArr;");

            // "U+021D3", "DOWNWARDS DOUBLE ARROW"
            txt = txt.Replace("⇓", "&dArr;");

            // "U+021D4", "LEFT RIGHT DOUBLE ARROW"
            txt = txt.Replace("⇔", "&hArr;");

            // "U+021D5", "UP DOWN DOUBLE ARROW"
            txt = txt.Replace("⇕", "&vArr;");

            // "U+021D6", "NORTH WEST DOUBLE ARROW"
            txt = txt.Replace("⇖", "&nwArr;");

            // "U+021D7", "NORTH EAST DOUBLE ARROW"
            txt = txt.Replace("⇗", "&neArr;");

            // "U+021D8", "SOUTH EAST DOUBLE ARROW"
            txt = txt.Replace("⇘", "&seArr;");

            // "U+021D9", "SOUTH WEST DOUBLE ARROW"
            txt = txt.Replace("⇙", "&swArr;");

            // "U+021DA", "LEFTWARDS TRIPLE ARROW"
            txt = txt.Replace("⇚", "&lAarr;");

            // "U+021DB", "RIGHTWARDS TRIPLE ARROW"
            txt = txt.Replace("⇛", "&rAarr;");

            // "U+021DD", "RIGHTWARDS SQUIGGLE ARROW"
            txt = txt.Replace("⇝", "&zigrarr;");

            // "U+021E4", "LEFTWARDS ARROW TO BAR"
            txt = txt.Replace("⇤", "&larrb;");

            // "U+021E5", "RIGHTWARDS ARROW TO BAR"
            txt = txt.Replace("⇥", "&rarrb;");

            // "U+021F5", "DOWNWARDS ARROW LEFTWARDS OF UPWARDS ARROW"
            txt = txt.Replace("⇵", "&duarr;");

            // "U+021FD", "LEFTWARDS OPEN-HEADED ARROW"
            txt = txt.Replace("⇽", "&loarr;");

            // "U+021FE", "RIGHTWARDS OPEN-HEADED ARROW"
            txt = txt.Replace("⇾", "&roarr;");

            // "U+021FF", "LEFT RIGHT OPEN-HEADED ARROW"
            txt = txt.Replace("⇿", "&hoarr;");

            // "U+02200", "FOR ALL"
            txt = txt.Replace("∀", "&forall;");

            // "U+02201", "COMPLEMENT"
            txt = txt.Replace("∁", "&comp;");

            // "U+02202", "PARTIAL DIFFERENTIAL"
            txt = txt.Replace("∂", "&part;");

            // "U+02203", "THERE EXISTS"
            txt = txt.Replace("∃", "&exist;");

            // "U+02204", "THERE DOES NOT EXIST"
            txt = txt.Replace("∄", "&nexist;");

            // "U+02205", "EMPTY SET"
            txt = txt.Replace("∅", "&empty;");

            // "U+02207", "NABLA"
            txt = txt.Replace("∇", "&nabla;");

            // "U+02208", "ELEMENT OF"
            txt = txt.Replace("∈", "&isin;");

            // "U+02209", "NOT AN ELEMENT OF"
            txt = txt.Replace("∉", "&notin;");

            // "U+0220B", "CONTAINS AS MEMBER"
            txt = txt.Replace("∋", "&niv;");

            // "U+0220C", "DOES NOT CONTAIN AS MEMBER"
            txt = txt.Replace("∌", "&notni;");

            // "U+0220F", "N-ARY PRODUCT"
            txt = txt.Replace("∏", "&prod;");

            // "U+02210", "N-ARY COPRODUCT"
            txt = txt.Replace("∐", "&coprod;");

            // "U+02211", "N-ARY SUMMATION"
            txt = txt.Replace("∑", "&sum;");

            // "U+02212", "MINUS SIGN"
            txt = txt.Replace("−", "&minus;");

            // "U+02213", "MINUS-OR-PLUS SIGN"
            txt = txt.Replace("∓", "&mnplus;");

            // "U+02214", "DOT PLUS"
            txt = txt.Replace("∔", "&plusdo;");

            // "U+02216", "SET MINUS"
            txt = txt.Replace("∖", "&setmn;");

            // "U+02217", "ASTERISK OPERATOR"
            txt = txt.Replace("∗", "&lowast;");

            // "U+02218", "RING OPERATOR"
            txt = txt.Replace("∘", "&compfn;");

            // "U+0221A", "SQUARE ROOT"
            txt = txt.Replace("√", "&radic;");

            // "U+0221D", "PROPORTIONAL TO"
            txt = txt.Replace("∝", "&prop;");

            // "U+0221E", "INFINITY"
            txt = txt.Replace("∞", "&infin;");

            // "U+0221F", "RIGHT ANGLE"
            txt = txt.Replace("∟", "&angrt;");

            // "U+02220", "ANGLE"
            txt = txt.Replace("∠", "&ang;");

            // "U+02221", "MEASURED ANGLE"
            txt = txt.Replace("∡", "&angmsd;");

            // "U+02222", "SPHERICAL ANGLE"
            txt = txt.Replace("∢", "&angsph;");

            // "U+02223", "DIVIDES"
            txt = txt.Replace("∣", "&mid;");

            // "U+02224", "DOES NOT DIVIDE"
            txt = txt.Replace("∤", "&nmid;");

            // "U+02225", "PARALLEL TO"
            txt = txt.Replace("∥", "&par;");

            // "U+02226", "NOT PARALLEL TO"
            txt = txt.Replace("∦", "&npar;");

            // "U+02227", "LOGICAL AND"
            txt = txt.Replace("∧", "&and;");

            // "U+02228", "LOGICAL OR"
            txt = txt.Replace("∨", "&or;");

            // "U+02229", "INTERSECTION"
            txt = txt.Replace("∩", "&cap;");

            // "U+0222A", "UNION"
            txt = txt.Replace("∪", "&cup;");

            // "U+0222B", "INTEGRAL"
            txt = txt.Replace("∫", "&int;");

            // "U+0222C", "DOUBLE INTEGRAL"
            txt = txt.Replace("∬", "&Int;");

            // "U+0222D", "TRIPLE INTEGRAL"
            txt = txt.Replace("∭", "&tint;");

            // "U+0222E", "CONTOUR INTEGRAL"
            txt = txt.Replace("∮", "&conint;");

            // "U+0222F", "SURFACE INTEGRAL"
            txt = txt.Replace("∯", "&Conint;");

            // "U+02230", "VOLUME INTEGRAL"
            txt = txt.Replace("∰", "&Cconint;");

            // "U+02231", "CLOCKWISE INTEGRAL"
            txt = txt.Replace("∱", "&cwint;");

            // "U+02232", "CLOCKWISE CONTOUR INTEGRAL"
            txt = txt.Replace("∲", "&cwconint;");

            // "U+02233", "ANTICLOCKWISE CONTOUR INTEGRAL"
            txt = txt.Replace("∳", "&awconint;");

            // "U+02234", "THEREFORE"
            txt = txt.Replace("∴", "&there4;");

            // "U+02235", "BECAUSE"
            txt = txt.Replace("∵", "&becaus;");

            // "U+02236", "RATIO"
            txt = txt.Replace("∶", "&ratio;");

            // "U+02237", "PROPORTION"
            txt = txt.Replace("∷", "&Colon;");

            // "U+02238", "DOT MINUS"
            txt = txt.Replace("∸", "&minusd;");

            // "U+0223A", "GEOMETRIC PROPORTION"
            txt = txt.Replace("∺", "&mDDot;");

            // "U+0223B", "HOMOTHETIC"
            txt = txt.Replace("∻", "&homtht;");

            // "U+0223C", "TILDE OPERATOR"
            txt = txt.Replace("∼", "&sim;");

            // "U+0223D", "REVERSED TILDE"
            txt = txt.Replace("∽", "&bsim;");

            // "U+0223E", "INVERTED LAZY S"
            txt = txt.Replace("∾", "&ac;");

            // "U+0223F", "SINE WAVE"
            txt = txt.Replace("∿", "&acd;");

            // "U+02240", "WREATH PRODUCT"
            txt = txt.Replace("≀", "&wreath;");

            // "U+02241", "NOT TILDE"
            txt = txt.Replace("≁", "&nsim;");

            // "U+02242", "MINUS TILDE"
            txt = txt.Replace("≂", "&esim;");

            // "U+02243", "ASYMPTOTICALLY EQUAL TO"
            txt = txt.Replace("≃", "&sime;");

            // "U+02244", "NOT ASYMPTOTICALLY EQUAL TO"
            txt = txt.Replace("≄", "&nsime;");

            // "U+02245", "APPROXIMATELY EQUAL TO"
            txt = txt.Replace("≅", "&cong;");

            // "U+02246", "APPROXIMATELY BUT NOT ACTUALLY EQUAL TO"
            txt = txt.Replace("≆", "&simne;");

            // "U+02247", "NEITHER APPROXIMATELY NOR ACTUALLY EQUAL TO"
            txt = txt.Replace("≇", "&ncong;");

            // "U+02248", "ALMOST EQUAL TO"
            txt = txt.Replace("≈", "&asymp;");

            // "U+02249", "NOT ALMOST EQUAL TO"
            txt = txt.Replace("≉", "&nap;");

            // "U+0224A", "ALMOST EQUAL OR EQUAL TO"
            txt = txt.Replace("≊", "&ape;");

            // "U+0224B", "TRIPLE TILDE"
            txt = txt.Replace("≋", "&apid;");

            // "U+0224C", "ALL EQUAL TO"
            txt = txt.Replace("≌", "&bcong;");

            // "U+0224D", "EQUIVALENT TO"
            txt = txt.Replace("≍", "&asympeq;");

            // "U+0224E", "GEOMETRICALLY EQUIVALENT TO"
            txt = txt.Replace("≎", "&bump;");

            // "U+0224F", "DIFFERENCE BETWEEN"
            txt = txt.Replace("≏", "&bumpe;");

            // "U+02250", "APPROACHES THE LIMIT"
            txt = txt.Replace("≐", "&esdot;");

            // "U+02251", "GEOMETRICALLY EQUAL TO"
            txt = txt.Replace("≑", "&eDot;");

            // "U+02252", "APPROXIMATELY EQUAL TO OR THE IMAGE OF"
            txt = txt.Replace("≒", "&efDot;");

            // "U+02253", "IMAGE OF OR APPROXIMATELY EQUAL TO"
            txt = txt.Replace("≓", "&erDot;");

            // "U+02254", "COLON EQUALS"
            txt = txt.Replace("≔", "&colone;");

            // "U+02255", "EQUALS COLON"
            txt = txt.Replace("≕", "&ecolon;");

            // "U+02256", "RING IN EQUAL TO"
            txt = txt.Replace("≖", "&ecir;");

            // "U+02257", "RING EQUAL TO"
            txt = txt.Replace("≗", "&cire;");

            // "U+02259", "ESTIMATES"
            txt = txt.Replace("≙", "&wedgeq;");

            // "U+0225A", "EQUIANGULAR TO"
            txt = txt.Replace("≚", "&veeeq;");

            // "U+0225C", "DELTA EQUAL TO"
            txt = txt.Replace("≜", "&trie;");

            // "U+0225F", "QUESTIONED EQUAL TO"
            txt = txt.Replace("≟", "&equest;");

            // "U+02260", "NOT EQUAL TO"
            txt = txt.Replace("≠", "&ne;");

            // "U+02261", "IDENTICAL TO"
            txt = txt.Replace("≡", "&equiv;");

            // "U+02262", "NOT IDENTICAL TO"
            txt = txt.Replace("≢", "&nequiv;");

            // "U+02264", "LESS-THAN OR EQUAL TO"
            txt = txt.Replace("≤", "&le;");

            // "U+02265", "GREATER-THAN OR EQUAL TO"
            txt = txt.Replace("≥", "&ge;");

            // "U+02266", "LESS-THAN OVER EQUAL TO"
            txt = txt.Replace("≦", "&lE;");

            // "U+02267", "GREATER-THAN OVER EQUAL TO"
            txt = txt.Replace("≧", "&gE;");

            // "U+02268", "LESS-THAN BUT NOT EQUAL TO"
            txt = txt.Replace("≨", "&lnE;");

            // "U+02269", "GREATER-THAN BUT NOT EQUAL TO"
            txt = txt.Replace("≩", "&gnE;");

            // "U+0226A", "MUCH LESS-THAN"
            txt = txt.Replace("≪", "&Lt;");

            // "U+0226B", "MUCH GREATER-THAN"
            txt = txt.Replace("≫", "&Gt;");

            // "U+0226C", "BETWEEN"
            txt = txt.Replace("≬", "&twixt;");

            // "U+0226D", "NOT EQUIVALENT TO"
            txt = txt.Replace("≭", "&NotCupCap;");

            // "U+0226E", "NOT LESS-THAN"
            txt = txt.Replace("≮", "&nlt;");

            // "U+0226F", "NOT GREATER-THAN"
            txt = txt.Replace("≯", "&ngt;");

            // "U+02270", "NEITHER LESS-THAN NOR EQUAL TO"
            txt = txt.Replace("≰", "&nle;");

            // "U+02271", "NEITHER GREATER-THAN NOR EQUAL TO"
            txt = txt.Replace("≱", "&nge;");

            // "U+02272", "LESS-THAN OR EQUIVALENT TO"
            txt = txt.Replace("≲", "&lsim;");

            // "U+02273", "GREATER-THAN OR EQUIVALENT TO"
            txt = txt.Replace("≳", "&gsim;");

            // "U+02274", "NEITHER LESS-THAN NOR EQUIVALENT TO"
            txt = txt.Replace("≴", "&nlsim;");

            // "U+02275", "NEITHER GREATER-THAN NOR EQUIVALENT TO"
            txt = txt.Replace("≵", "&ngsim;");

            // "U+02276", "LESS-THAN OR GREATER-THAN"
            txt = txt.Replace("≶", "&lg;");

            // "U+02277", "GREATER-THAN OR LESS-THAN"
            txt = txt.Replace("≷", "&gl;");

            // "U+02278", "NEITHER LESS-THAN NOR GREATER-THAN"
            txt = txt.Replace("≸", "&ntlg;");

            // "U+02279", "NEITHER GREATER-THAN NOR LESS-THAN"
            txt = txt.Replace("≹", "&ntgl;");

            // "U+0227A", "PRECEDES"
            txt = txt.Replace("≺", "&pr;");

            // "U+0227B", "SUCCEEDS"
            txt = txt.Replace("≻", "&sc;");

            // "U+0227C", "PRECEDES OR EQUAL TO"
            txt = txt.Replace("≼", "&prcue;");

            // "U+0227D", "SUCCEEDS OR EQUAL TO"
            txt = txt.Replace("≽", "&sccue;");

            // "U+0227E", "PRECEDES OR EQUIVALENT TO"
            txt = txt.Replace("≾", "&prsim;");

            // "U+0227F", "SUCCEEDS OR EQUIVALENT TO"
            txt = txt.Replace("≿", "&scsim;");

            // "U+02280", "DOES NOT PRECEDE"
            txt = txt.Replace("⊀", "&npr;");

            // "U+02281", "DOES NOT SUCCEED"
            txt = txt.Replace("⊁", "&nsc;");

            // "U+02282", "SUBSET OF"
            txt = txt.Replace("⊂", "&sub;");

            // "U+02283", "SUPERSET OF"
            txt = txt.Replace("⊃", "&sup;");

            // "U+02284", "NOT A SUBSET OF"
            txt = txt.Replace("⊄", "&nsub;");

            // "U+02285", "NOT A SUPERSET OF"
            txt = txt.Replace("⊅", "&nsup;");

            // "U+02286", "SUBSET OF OR EQUAL TO"
            txt = txt.Replace("⊆", "&sube;");

            // "U+02287", "SUPERSET OF OR EQUAL TO"
            txt = txt.Replace("⊇", "&supe;");

            // "U+02288", "NEITHER A SUBSET OF NOR EQUAL TO"
            txt = txt.Replace("⊈", "&nsube;");

            // "U+02289", "NEITHER A SUPERSET OF NOR EQUAL TO"
            txt = txt.Replace("⊉", "&nsupe;");

            // "U+0228A", "SUBSET OF WITH NOT EQUAL TO"
            txt = txt.Replace("⊊", "&subne;");

            // "U+0228B", "SUPERSET OF WITH NOT EQUAL TO"
            txt = txt.Replace("⊋", "&supne;");

            // "U+0228D", "MULTISET MULTIPLICATION"
            txt = txt.Replace("⊍", "&cupdot;");

            // "U+0228E", "MULTISET UNION"
            txt = txt.Replace("⊎", "&uplus;");

            // "U+0228F", "SQUARE IMAGE OF"
            txt = txt.Replace("⊏", "&sqsub;");

            // "U+02290", "SQUARE ORIGINAL OF"
            txt = txt.Replace("⊐", "&sqsup;");

            // "U+02291", "SQUARE IMAGE OF OR EQUAL TO"
            txt = txt.Replace("⊑", "&sqsube;");

            // "U+02292", "SQUARE ORIGINAL OF OR EQUAL TO"
            txt = txt.Replace("⊒", "&sqsupe;");

            // "U+02293", "SQUARE CAP"
            txt = txt.Replace("⊓", "&sqcap;");

            // "U+02294", "SQUARE CUP"
            txt = txt.Replace("⊔", "&sqcup;");

            // "U+02295", "CIRCLED PLUS"
            txt = txt.Replace("⊕", "&oplus;");

            // "U+02296", "CIRCLED MINUS"
            txt = txt.Replace("⊖", "&ominus;");

            // "U+02297", "CIRCLED TIMES"
            txt = txt.Replace("⊗", "&otimes;");

            // "U+02298", "CIRCLED DIVISION SLASH"
            txt = txt.Replace("⊘", "&osol;");

            // "U+02299", "CIRCLED DOT OPERATOR"
            txt = txt.Replace("⊙", "&odot;");

            // "U+0229A", "CIRCLED RING OPERATOR"
            txt = txt.Replace("⊚", "&ocir;");

            // "U+0229B", "CIRCLED ASTERISK OPERATOR"
            txt = txt.Replace("⊛", "&oast;");

            // "U+0229D", "CIRCLED DASH"
            txt = txt.Replace("⊝", "&odash;");

            // "U+0229E", "SQUARED PLUS"
            txt = txt.Replace("⊞", "&plusb;");

            // "U+0229F", "SQUARED MINUS"
            txt = txt.Replace("⊟", "&minusb;");

            // "U+022A0", "SQUARED TIMES"
            txt = txt.Replace("⊠", "&timesb;");

            // "U+022A1", "SQUARED DOT OPERATOR"
            txt = txt.Replace("⊡", "&sdotb;");

            // "U+022A2", "RIGHT TACK"
            txt = txt.Replace("⊢", "&vdash;");

            // "U+022A3", "LEFT TACK"
            txt = txt.Replace("⊣", "&dashv;");

            // "U+022A4", "DOWN TACK"
            txt = txt.Replace("⊤", "&top;");

            // "U+022A5", "UP TACK"
            txt = txt.Replace("⊥", "&bottom;");

            // "U+022A7", "MODELS"
            txt = txt.Replace("⊧", "&models;");

            // "U+022A8", "TRUE"
            txt = txt.Replace("⊨", "&vDash;");

            // "U+022A9", "FORCES"
            txt = txt.Replace("⊩", "&Vdash;");

            // "U+022AA", "TRIPLE VERTICAL BAR RIGHT TURNSTILE"
            txt = txt.Replace("⊪", "&Vvdash;");

            // "U+022AB", "DOUBLE VERTICAL BAR DOUBLE RIGHT TURNSTILE"
            txt = txt.Replace("⊫", "&VDash;");

            // "U+022AC", "DOES NOT PROVE"
            txt = txt.Replace("⊬", "&nvdash;");

            // "U+022AD", "NOT TRUE"
            txt = txt.Replace("⊭", "&nvDash;");

            // "U+022AE", "DOES NOT FORCE"
            txt = txt.Replace("⊮", "&nVdash;");

            // "U+022AF", "NEGATED DOUBLE VERTICAL BAR DOUBLE RIGHT TURNSTILE"
            txt = txt.Replace("⊯", "&nVDash;");

            // "U+022B0", "PRECEDES UNDER RELATION"
            txt = txt.Replace("⊰", "&prurel;");

            // "U+022B2", "NORMAL SUBGROUP OF"
            txt = txt.Replace("⊲", "&vltri;");

            // "U+022B3", "CONTAINS AS NORMAL SUBGROUP"
            txt = txt.Replace("⊳", "&vrtri;");

            // "U+022B4", "NORMAL SUBGROUP OF OR EQUAL TO"
            txt = txt.Replace("⊴", "&ltrie;");

            // "U+022B5", "CONTAINS AS NORMAL SUBGROUP OR EQUAL TO"
            txt = txt.Replace("⊵", "&rtrie;");

            // "U+022B6", "ORIGINAL OF"
            txt = txt.Replace("⊶", "&origof;");

            // "U+022B7", "IMAGE OF"
            txt = txt.Replace("⊷", "&imof;");

            // "U+022B8", "MULTIMAP"
            txt = txt.Replace("⊸", "&mumap;");

            // "U+022B9", "HERMITIAN CONJUGATE MATRIX"
            txt = txt.Replace("⊹", "&hercon;");

            // "U+022BA", "INTERCALATE"
            txt = txt.Replace("⊺", "&intcal;");

            // "U+022BB", "XOR"
            txt = txt.Replace("⊻", "&veebar;");

            // "U+022BD", "NOR"
            txt = txt.Replace("⊽", "&barvee;");

            // "U+022BE", "RIGHT ANGLE WITH ARC"
            txt = txt.Replace("⊾", "&angrtvb;");

            // "U+022BF", "RIGHT TRIANGLE"
            txt = txt.Replace("⊿", "&lrtri;");

            // "U+022C0", "N-ARY LOGICAL AND"
            txt = txt.Replace("⋀", "&xwedge;");

            // "U+022C1", "N-ARY LOGICAL OR"
            txt = txt.Replace("⋁", "&xvee;");

            // "U+022C2", "N-ARY INTERSECTION"
            txt = txt.Replace("⋂", "&xcap;");

            // "U+022C3", "N-ARY UNION"
            txt = txt.Replace("⋃", "&xcup;");

            // "U+022C4", "DIAMOND OPERATOR"
            txt = txt.Replace("⋄", "&diam;");

            // "U+022C5", "DOT OPERATOR"
            txt = txt.Replace("⋅", "&sdot;");

            // "U+022C6", "STAR OPERATOR"
            txt = txt.Replace("⋆", "&sstarf;");

            // "U+022C7", "DIVISION TIMES"
            txt = txt.Replace("⋇", "&divonx;");

            // "U+022C8", "BOWTIE"
            txt = txt.Replace("⋈", "&bowtie;");

            // "U+022C9", "LEFT NORMAL FACTOR SEMIDIRECT PRODUCT"
            txt = txt.Replace("⋉", "&ltimes;");

            // "U+022CA", "RIGHT NORMAL FACTOR SEMIDIRECT PRODUCT"
            txt = txt.Replace("⋊", "&rtimes;");

            // "U+022CB", "LEFT SEMIDIRECT PRODUCT"
            txt = txt.Replace("⋋", "&lthree;");

            // "U+022CC", "RIGHT SEMIDIRECT PRODUCT"
            txt = txt.Replace("⋌", "&rthree;");

            // "U+022CD", "REVERSED TILDE EQUALS"
            txt = txt.Replace("⋍", "&bsime;");

            // "U+022CE", "CURLY LOGICAL OR"
            txt = txt.Replace("⋎", "&cuvee;");

            // "U+022CF", "CURLY LOGICAL AND"
            txt = txt.Replace("⋏", "&cuwed;");

            // "U+022D0", "DOUBLE SUBSET"
            txt = txt.Replace("⋐", "&Sub;");

            // "U+022D1", "DOUBLE SUPERSET"
            txt = txt.Replace("⋑", "&Sup;");

            // "U+022D2", "DOUBLE INTERSECTION"
            txt = txt.Replace("⋒", "&Cap;");

            // "U+022D3", "DOUBLE UNION"
            txt = txt.Replace("⋓", "&Cup;");

            // "U+022D4", "PITCHFORK"
            txt = txt.Replace("⋔", "&fork;");

            // "U+022D5", "EQUAL AND PARALLEL TO"
            txt = txt.Replace("⋕", "&epar;");

            // "U+022D6", "LESS-THAN WITH DOT"
            txt = txt.Replace("⋖", "&ltdot;");

            // "U+022D7", "GREATER-THAN WITH DOT"
            txt = txt.Replace("⋗", "&gtdot;");

            // "U+022D8", "VERY MUCH LESS-THAN"
            txt = txt.Replace("⋘", "&Ll;");

            // "U+022D9", "VERY MUCH GREATER-THAN"
            txt = txt.Replace("⋙", "&Gg;");

            // "U+022DA", "LESS-THAN EQUAL TO OR GREATER-THAN"
            txt = txt.Replace("⋚", "&leg;");

            // "U+022DB", "GREATER-THAN EQUAL TO OR LESS-THAN"
            txt = txt.Replace("⋛", "&gel;");

            // "U+022DE", "EQUAL TO OR PRECEDES"
            txt = txt.Replace("⋞", "&cuepr;");

            // "U+022DF", "EQUAL TO OR SUCCEEDS"
            txt = txt.Replace("⋟", "&cuesc;");

            // "U+022E0", "DOES NOT PRECEDE OR EQUAL"
            txt = txt.Replace("⋠", "&nprcue;");

            // "U+022E1", "DOES NOT SUCCEED OR EQUAL"
            txt = txt.Replace("⋡", "&nsccue;");

            // "U+022E2", "NOT SQUARE IMAGE OF OR EQUAL TO"
            txt = txt.Replace("⋢", "&nsqsube;");

            // "U+022E3", "NOT SQUARE ORIGINAL OF OR EQUAL TO"
            txt = txt.Replace("⋣", "&nsqsupe;");

            // "U+022E6", "LESS-THAN BUT NOT EQUIVALENT TO"
            txt = txt.Replace("⋦", "&lnsim;");

            // "U+022E7", "GREATER-THAN BUT NOT EQUIVALENT TO"
            txt = txt.Replace("⋧", "&gnsim;");

            // "U+022E8", "PRECEDES BUT NOT EQUIVALENT TO"
            txt = txt.Replace("⋨", "&prnsim;");

            // "U+022E9", "SUCCEEDS BUT NOT EQUIVALENT TO"
            txt = txt.Replace("⋩", "&scnsim;");

            // "U+022EA", "NOT NORMAL SUBGROUP OF"
            txt = txt.Replace("⋪", "&nltri;");

            // "U+022EB", "DOES NOT CONTAIN AS NORMAL SUBGROUP"
            txt = txt.Replace("⋫", "&nrtri;");

            // "U+022EC", "NOT NORMAL SUBGROUP OF OR EQUAL TO"
            txt = txt.Replace("⋬", "&nltrie;");

            // "U+022ED", "DOES NOT CONTAIN AS NORMAL SUBGROUP OR EQUAL"
            txt = txt.Replace("⋭", "&nrtrie;");

            // "U+022EE", "VERTICAL ELLIPSIS"
            txt = txt.Replace("⋮", "&vellip;");

            // "U+022EF", "MIDLINE HORIZONTAL ELLIPSIS"
            txt = txt.Replace("⋯", "&ctdot;");

            // "U+022F0", "UP RIGHT DIAGONAL ELLIPSIS"
            txt = txt.Replace("⋰", "&utdot;");

            // "U+022F1", "DOWN RIGHT DIAGONAL ELLIPSIS"
            txt = txt.Replace("⋱", "&dtdot;");

            // "U+022F2", "ELEMENT OF WITH LONG HORIZONTAL STROKE"
            txt = txt.Replace("⋲", "&disin;");

            // "U+022F3", "ELEMENT OF WITH VERTICAL BAR AT END OF HORIZONTAL STROKE"
            txt = txt.Replace("⋳", "&isinsv;");

            // "U+022F4", "SMALL ELEMENT OF WITH VERTICAL BAR AT END OF HORIZONTAL STROKE"
            txt = txt.Replace("⋴", "&isins;");

            // "U+022F5", "ELEMENT OF WITH DOT ABOVE"
            txt = txt.Replace("⋵", "&isindot;");

            // "U+022F6", "ELEMENT OF WITH OVERBAR"
            txt = txt.Replace("⋶", "&notinvc;");

            // "U+022F7", "SMALL ELEMENT OF WITH OVERBAR"
            txt = txt.Replace("⋷", "&notinvb;");

            // "U+022F9", "ELEMENT OF WITH TWO HORIZONTAL STROKES"
            txt = txt.Replace("⋹", "&isinE;");

            // "U+022FA", "CONTAINS WITH LONG HORIZONTAL STROKE"
            txt = txt.Replace("⋺", "&nisd;");

            // "U+022FB", "CONTAINS WITH VERTICAL BAR AT END OF HORIZONTAL STROKE"
            txt = txt.Replace("⋻", "&xnis;");

            // "U+022FC", "SMALL CONTAINS WITH VERTICAL BAR AT END OF HORIZONTAL STROKE"
            txt = txt.Replace("⋼", "&nis;");

            // "U+022FD", "CONTAINS WITH OVERBAR"
            txt = txt.Replace("⋽", "&notnivc;");

            // "U+022FE", "SMALL CONTAINS WITH OVERBAR"
            txt = txt.Replace("⋾", "&notnivb;");

            // "U+02305", "PROJECTIVE"
            txt = txt.Replace("⌅", "&barwed;");

            // "U+02306", "PERSPECTIVE"
            txt = txt.Replace("⌆", "&Barwed;");

            // "U+02308", "LEFT CEILING"
            txt = txt.Replace("⌈", "&lceil;");

            // "U+02309", "RIGHT CEILING"
            txt = txt.Replace("⌉", "&rceil;");

            // "U+0230A", "LEFT FLOOR"
            txt = txt.Replace("⌊", "&lfloor;");

            // "U+0230B", "RIGHT FLOOR"
            txt = txt.Replace("⌋", "&rfloor;");

            // "U+0230C", "BOTTOM RIGHT CROP"
            txt = txt.Replace("⌌", "&drcrop;");

            // "U+0230D", "BOTTOM LEFT CROP"
            txt = txt.Replace("⌍", "&dlcrop;");

            // "U+0230E", "TOP RIGHT CROP"
            txt = txt.Replace("⌎", "&urcrop;");

            // "U+0230F", "TOP LEFT CROP"
            txt = txt.Replace("⌏", "&ulcrop;");

            // "U+02310", "REVERSED NOT SIGN"
            txt = txt.Replace("⌐", "&bnot;");

            // "U+02312", "ARC"
            txt = txt.Replace("⌒", "&profline;");

            // "U+02313", "SEGMENT"
            txt = txt.Replace("⌓", "&profsurf;");

            // "U+02315", "TELEPHONE RECORDER"
            txt = txt.Replace("⌕", "&telrec;");

            // "U+02316", "POSITION INDICATOR"
            txt = txt.Replace("⌖", "&target;");

            // "U+0231C", "TOP LEFT CORNER"
            txt = txt.Replace("⌜", "&ulcorn;");

            // "U+0231D", "TOP RIGHT CORNER"
            txt = txt.Replace("⌝", "&urcorn;");

            // "U+0231E", "BOTTOM LEFT CORNER"
            txt = txt.Replace("⌞", "&dlcorn;");

            // "U+0231F", "BOTTOM RIGHT CORNER"
            txt = txt.Replace("⌟", "&drcorn;");

            // "U+02322", "FROWN"
            txt = txt.Replace("⌢", "&frown;");

            // "U+02323", "SMILE"
            txt = txt.Replace("⌣", "&smile;");

            // "U+0232D", "CYLINDRICITY"
            txt = txt.Replace("⌭", "&cylcty;");

            // "U+0232E", "ALL AROUND-PROFILE"
            txt = txt.Replace("⌮", "&profalar;");

            // "U+02336", "APL FUNCTIONAL SYMBOL I-BEAM"
            txt = txt.Replace("⌶", "&topbot;");

            // "U+0233D", "APL FUNCTIONAL SYMBOL CIRCLE STILE"
            txt = txt.Replace("⌽", "&ovbar;");

            // "U+0233F", "APL FUNCTIONAL SYMBOL SLASH BAR"
            txt = txt.Replace("⌿", "&solbar;");

            // "U+0237C", "RIGHT ANGLE WITH DOWNWARDS ZIGZAG ARROW"
            txt = txt.Replace("⍼", "&angzarr;");

            // "U+023B0", "UPPER LEFT OR LOWER RIGHT CURLY BRACKET SECTION"
            txt = txt.Replace("⎰", "&lmoust;");

            // "U+023B1", "UPPER RIGHT OR LOWER LEFT CURLY BRACKET SECTION"
            txt = txt.Replace("⎱", "&rmoust;");

            // "U+023B4", "TOP SQUARE BRACKET"
            txt = txt.Replace("⎴", "&tbrk;");

            // "U+023B5", "BOTTOM SQUARE BRACKET"
            txt = txt.Replace("⎵", "&bbrk;");

            // "U+023B6", "BOTTOM SQUARE BRACKET OVER TOP SQUARE BRACKET"
            txt = txt.Replace("⎶", "&bbrktbrk;");

            // "U+023DC", "TOP PARENTHESIS"
            txt = txt.Replace("⏜", "&OverParenthesis;");

            // "U+023DD", "BOTTOM PARENTHESIS"
            txt = txt.Replace("⏝", "&UnderParenthesis;");

            // "U+023DE", "TOP CURLY BRACKET"
            txt = txt.Replace("⏞", "&OverBrace;");

            // "U+023DF", "BOTTOM CURLY BRACKET"
            txt = txt.Replace("⏟", "&UnderBrace;");

            // "U+023E2", "WHITE TRAPEZIUM"
            txt = txt.Replace("⏢", "&trpezium;");

            // "U+023E7", "ELECTRICAL INTERSECTION"
            txt = txt.Replace("⏧", "&elinters;");

            // "U+02423", "OPEN BOX"
            txt = txt.Replace("␣", "&blank;");

            // "U+024C8", "CIRCLED LATIN CAPITAL LETTER S"
            txt = txt.Replace("Ⓢ", "&oS;");

            // "U+02500", "BOX DRAWINGS LIGHT HORIZONTAL"
            txt = txt.Replace("─", "&boxh;");

            // "U+02502", "BOX DRAWINGS LIGHT VERTICAL"
            txt = txt.Replace("│", "&boxv;");

            // "U+0250C", "BOX DRAWINGS LIGHT DOWN AND RIGHT"
            txt = txt.Replace("┌", "&boxdr;");

            // "U+02510", "BOX DRAWINGS LIGHT DOWN AND LEFT"
            txt = txt.Replace("┐", "&boxdl;");

            // "U+02514", "BOX DRAWINGS LIGHT UP AND RIGHT"
            txt = txt.Replace("└", "&boxur;");

            // "U+02518", "BOX DRAWINGS LIGHT UP AND LEFT"
            txt = txt.Replace("┘", "&boxul;");

            // "U+0251C", "BOX DRAWINGS LIGHT VERTICAL AND RIGHT"
            txt = txt.Replace("├", "&boxvr;");

            // "U+02524", "BOX DRAWINGS LIGHT VERTICAL AND LEFT"
            txt = txt.Replace("┤", "&boxvl;");

            // "U+0252C", "BOX DRAWINGS LIGHT DOWN AND HORIZONTAL"
            txt = txt.Replace("┬", "&boxhd;");

            // "U+02534", "BOX DRAWINGS LIGHT UP AND HORIZONTAL"
            txt = txt.Replace("┴", "&boxhu;");

            // "U+0253C", "BOX DRAWINGS LIGHT VERTICAL AND HORIZONTAL"
            txt = txt.Replace("┼", "&boxvh;");

            // "U+02550", "BOX DRAWINGS DOUBLE HORIZONTAL"
            txt = txt.Replace("═", "&boxH;");

            // "U+02551", "BOX DRAWINGS DOUBLE VERTICAL"
            txt = txt.Replace("║", "&boxV;");

            // "U+02552", "BOX DRAWINGS DOWN SINGLE AND RIGHT DOUBLE"
            txt = txt.Replace("╒", "&boxdR;");

            // "U+02553", "BOX DRAWINGS DOWN DOUBLE AND RIGHT SINGLE"
            txt = txt.Replace("╓", "&boxDr;");

            // "U+02554", "BOX DRAWINGS DOUBLE DOWN AND RIGHT"
            txt = txt.Replace("╔", "&boxDR;");

            // "U+02555", "BOX DRAWINGS DOWN SINGLE AND LEFT DOUBLE"
            txt = txt.Replace("╕", "&boxdL;");

            // "U+02556", "BOX DRAWINGS DOWN DOUBLE AND LEFT SINGLE"
            txt = txt.Replace("╖", "&boxDl;");

            // "U+02557", "BOX DRAWINGS DOUBLE DOWN AND LEFT"
            txt = txt.Replace("╗", "&boxDL;");

            // "U+02558", "BOX DRAWINGS UP SINGLE AND RIGHT DOUBLE"
            txt = txt.Replace("╘", "&boxuR;");

            // "U+02559", "BOX DRAWINGS UP DOUBLE AND RIGHT SINGLE"
            txt = txt.Replace("╙", "&boxUr;");

            // "U+0255A", "BOX DRAWINGS DOUBLE UP AND RIGHT"
            txt = txt.Replace("╚", "&boxUR;");

            // "U+0255B", "BOX DRAWINGS UP SINGLE AND LEFT DOUBLE"
            txt = txt.Replace("╛", "&boxuL;");

            // "U+0255C", "BOX DRAWINGS UP DOUBLE AND LEFT SINGLE"
            txt = txt.Replace("╜", "&boxUl;");

            // "U+0255D", "BOX DRAWINGS DOUBLE UP AND LEFT"
            txt = txt.Replace("╝", "&boxUL;");

            // "U+0255E", "BOX DRAWINGS VERTICAL SINGLE AND RIGHT DOUBLE"
            txt = txt.Replace("╞", "&boxvR;");

            // "U+0255F", "BOX DRAWINGS VERTICAL DOUBLE AND RIGHT SINGLE"
            txt = txt.Replace("╟", "&boxVr;");

            // "U+02560", "BOX DRAWINGS DOUBLE VERTICAL AND RIGHT"
            txt = txt.Replace("╠", "&boxVR;");

            // "U+02561", "BOX DRAWINGS VERTICAL SINGLE AND LEFT DOUBLE"
            txt = txt.Replace("╡", "&boxvL;");

            // "U+02562", "BOX DRAWINGS VERTICAL DOUBLE AND LEFT SINGLE"
            txt = txt.Replace("╢", "&boxVl;");

            // "U+02563", "BOX DRAWINGS DOUBLE VERTICAL AND LEFT"
            txt = txt.Replace("╣", "&boxVL;");

            // "U+02564", "BOX DRAWINGS DOWN SINGLE AND HORIZONTAL DOUBLE"
            txt = txt.Replace("╤", "&boxHd;");

            // "U+02565", "BOX DRAWINGS DOWN DOUBLE AND HORIZONTAL SINGLE"
            txt = txt.Replace("╥", "&boxhD;");

            // "U+02566", "BOX DRAWINGS DOUBLE DOWN AND HORIZONTAL"
            txt = txt.Replace("╦", "&boxHD;");

            // "U+02567", "BOX DRAWINGS UP SINGLE AND HORIZONTAL DOUBLE"
            txt = txt.Replace("╧", "&boxHu;");

            // "U+02568", "BOX DRAWINGS UP DOUBLE AND HORIZONTAL SINGLE"
            txt = txt.Replace("╨", "&boxhU;");

            // "U+02569", "BOX DRAWINGS DOUBLE UP AND HORIZONTAL"
            txt = txt.Replace("╩", "&boxHU;");

            // "U+0256A", "BOX DRAWINGS VERTICAL SINGLE AND HORIZONTAL DOUBLE"
            txt = txt.Replace("╪", "&boxvH;");

            // "U+0256B", "BOX DRAWINGS VERTICAL DOUBLE AND HORIZONTAL SINGLE"
            txt = txt.Replace("╫", "&boxVh;");

            // "U+0256C", "BOX DRAWINGS DOUBLE VERTICAL AND HORIZONTAL"
            txt = txt.Replace("╬", "&boxVH;");

            // "U+02580", "UPPER HALF BLOCK"
            txt = txt.Replace("▀", "&uhblk;");

            // "U+02584", "LOWER HALF BLOCK"
            txt = txt.Replace("▄", "&lhblk;");

            // "U+02588", "FULL BLOCK"
            txt = txt.Replace("█", "&block;");

            // "U+02591", "LIGHT SHADE"
            txt = txt.Replace("░", "&blk14;");

            // "U+02592", "MEDIUM SHADE"
            txt = txt.Replace("▒", "&blk12;");

            // "U+02593", "DARK SHADE"
            txt = txt.Replace("▓", "&blk34;");

            // "U+025A1", "WHITE SQUARE"
            txt = txt.Replace("□", "&squ;");

            // "U+025AA", "BLACK SMALL SQUARE"
            txt = txt.Replace("▪", "&squf;");

            // "U+025AB", "WHITE SMALL SQUARE"
            txt = txt.Replace("▫", "&EmptyVerySmallSquare;");

            // "U+025AD", "WHITE RECTANGLE"
            txt = txt.Replace("▭", "&rect;");

            // "U+025AE", "BLACK VERTICAL RECTANGLE"
            txt = txt.Replace("▮", "&marker;");

            // "U+025B1", "WHITE PARALLELOGRAM"
            txt = txt.Replace("▱", "&fltns;");

            // "U+025B3", "WHITE UP-POINTING TRIANGLE"
            txt = txt.Replace("△", "&xutri;");

            // "U+025B4", "BLACK UP-POINTING SMALL TRIANGLE"
            txt = txt.Replace("▴", "&utrif;");

            // "U+025B5", "WHITE UP-POINTING SMALL TRIANGLE"
            txt = txt.Replace("▵", "&utri;");

            // "U+025B8", "BLACK RIGHT-POINTING SMALL TRIANGLE"
            txt = txt.Replace("▸", "&rtrif;");

            // "U+025B9", "WHITE RIGHT-POINTING SMALL TRIANGLE"
            txt = txt.Replace("▹", "&rtri;");

            // "U+025BD", "WHITE DOWN-POINTING TRIANGLE"
            txt = txt.Replace("▽", "&xdtri;");

            // "U+025BE", "BLACK DOWN-POINTING SMALL TRIANGLE"
            txt = txt.Replace("▾", "&dtrif;");

            // "U+025BF", "WHITE DOWN-POINTING SMALL TRIANGLE"
            txt = txt.Replace("▿", "&dtri;");

            // "U+025C2", "BLACK LEFT-POINTING SMALL TRIANGLE"
            txt = txt.Replace("◂", "&ltrif;");

            // "U+025C3", "WHITE LEFT-POINTING SMALL TRIANGLE"
            txt = txt.Replace("◃", "&ltri;");

            // "U+025CA", "LOZENGE"
            txt = txt.Replace("◊", "&loz;");

            // "U+025CB", "WHITE CIRCLE"
            txt = txt.Replace("○", "&cir;");

            // "U+025EC", "WHITE UP-POINTING TRIANGLE WITH DOT"
            txt = txt.Replace("◬", "&tridot;");

            // "U+025EF", "LARGE CIRCLE"
            txt = txt.Replace("◯", "&xcirc;");

            // "U+025F8", "UPPER LEFT TRIANGLE"
            txt = txt.Replace("◸", "&ultri;");

            // "U+025F9", "UPPER RIGHT TRIANGLE"
            txt = txt.Replace("◹", "&urtri;");

            // "U+025FA", "LOWER LEFT TRIANGLE"
            txt = txt.Replace("◺", "&lltri;");

            // "U+025FB", "WHITE MEDIUM SQUARE"
            txt = txt.Replace("◻", "&EmptySmallSquare;");

            // "U+025FC", "BLACK MEDIUM SQUARE"
            txt = txt.Replace("◼", "&FilledSmallSquare;");

            // "U+02605", "BLACK STAR"
            txt = txt.Replace("★", "&starf;");

            // "U+02606", "WHITE STAR"
            txt = txt.Replace("☆", "&star;");

            // "U+0260E", "BLACK TELEPHONE"
            txt = txt.Replace("☎", "&phone;");

            // "U+02640", "FEMALE SIGN"
            txt = txt.Replace("♀", "&female;");

            // "U+02642", "MALE SIGN"
            txt = txt.Replace("♂", "&male;");

            // "U+02660", "BLACK SPADE SUIT"
            txt = txt.Replace("♠", "&spades;");

            // "U+02663", "BLACK CLUB SUIT"
            txt = txt.Replace("♣", "&clubs;");

            // "U+02665", "BLACK HEART SUIT"
            txt = txt.Replace("♥", "&hearts;");

            // "U+02666", "BLACK DIAMOND SUIT"
            txt = txt.Replace("♦", "&diams;");

            // "U+0266A", "EIGHTH NOTE"
            txt = txt.Replace("♪", "&sung;");

            // "U+0266D", "MUSIC FLAT SIGN"
            txt = txt.Replace("♭", "&flat;");

            // "U+0266E", "MUSIC NATURAL SIGN"
            txt = txt.Replace("♮", "&natur;");

            // "U+0266F", "MUSIC SHARP SIGN"
            txt = txt.Replace("♯", "&sharp;");

            // "U+02713", "CHECK MARK"
            txt = txt.Replace("✓", "&check;");

            // "U+02717", "BALLOT X"
            txt = txt.Replace("✗", "&cross;");

            // "U+02720", "MALTESE CROSS"
            txt = txt.Replace("✠", "&malt;");

            // "U+02736", "SIX POINTED BLACK STAR"
            txt = txt.Replace("✶", "&sext;");

            // "U+02758", "LIGHT VERTICAL BAR"
            txt = txt.Replace("❘", "&VerticalSeparator;");

            // "U+02772", "LIGHT LEFT TORTOISE SHELL BRACKET ORNAMENT"
            txt = txt.Replace("❲", "&lbbrk;");

            // "U+02773", "LIGHT RIGHT TORTOISE SHELL BRACKET ORNAMENT"
            txt = txt.Replace("❳", "&rbbrk;");

            // "U+027E6", "MATHEMATICAL LEFT WHITE SQUARE BRACKET"
            txt = txt.Replace("⟦", "&lobrk;");

            // "U+027E7", "MATHEMATICAL RIGHT WHITE SQUARE BRACKET"
            txt = txt.Replace("⟧", "&robrk;");

            // "U+027E8", "MATHEMATICAL LEFT ANGLE BRACKET"
            txt = txt.Replace("⟨", "&lang;");

            // "U+027E9", "MATHEMATICAL RIGHT ANGLE BRACKET"
            txt = txt.Replace("⟩", "&rang;");

            // "U+027EA", "MATHEMATICAL LEFT DOUBLE ANGLE BRACKET"
            txt = txt.Replace("⟪", "&Lang;");

            // "U+027EB", "MATHEMATICAL RIGHT DOUBLE ANGLE BRACKET"
            txt = txt.Replace("⟫", "&Rang;");

            // "U+027EC", "MATHEMATICAL LEFT WHITE TORTOISE SHELL BRACKET"
            txt = txt.Replace("⟬", "&loang;");

            // "U+027ED", "MATHEMATICAL RIGHT WHITE TORTOISE SHELL BRACKET"
            txt = txt.Replace("⟭", "&roang;");

            // "U+027F5", "LONG LEFTWARDS ARROW"
            txt = txt.Replace("⟵", "&xlarr;");

            // "U+027F6", "LONG RIGHTWARDS ARROW"
            txt = txt.Replace("⟶", "&xrarr;");

            // "U+027F7", "LONG LEFT RIGHT ARROW"
            txt = txt.Replace("⟷", "&xharr;");

            // "U+027F8", "LONG LEFTWARDS DOUBLE ARROW"
            txt = txt.Replace("⟸", "&xlArr;");

            // "U+027F9", "LONG RIGHTWARDS DOUBLE ARROW"
            txt = txt.Replace("⟹", "&xrArr;");

            // "U+027FA", "LONG LEFT RIGHT DOUBLE ARROW"
            txt = txt.Replace("⟺", "&xhArr;");

            // "U+027FC", "LONG RIGHTWARDS ARROW FROM BAR"
            txt = txt.Replace("⟼", "&xmap;");

            // "U+027FF", "LONG RIGHTWARDS SQUIGGLE ARROW"
            txt = txt.Replace("⟿", "&dzigrarr;");

            // "U+02902", "LEFTWARDS DOUBLE ARROW WITH VERTICAL STROKE"
            txt = txt.Replace("⤂", "&nvlArr;");

            // "U+02903", "RIGHTWARDS DOUBLE ARROW WITH VERTICAL STROKE"
            txt = txt.Replace("⤃", "&nvrArr;");

            // "U+02904", "LEFT RIGHT DOUBLE ARROW WITH VERTICAL STROKE"
            txt = txt.Replace("⤄", "&nvHarr;");

            // "U+02905", "RIGHTWARDS TWO-HEADED ARROW FROM BAR"
            txt = txt.Replace("⤅", "&Map;");

            // "U+0290C", "LEFTWARDS DOUBLE DASH ARROW"
            txt = txt.Replace("⤌", "&lbarr;");

            // "U+0290D", "RIGHTWARDS DOUBLE DASH ARROW"
            txt = txt.Replace("⤍", "&rbarr;");

            // "U+0290E", "LEFTWARDS TRIPLE DASH ARROW"
            txt = txt.Replace("⤎", "&lBarr;");

            // "U+0290F", "RIGHTWARDS TRIPLE DASH ARROW"
            txt = txt.Replace("⤏", "&rBarr;");

            // "U+02910", "RIGHTWARDS TWO-HEADED TRIPLE DASH ARROW"
            txt = txt.Replace("⤐", "&RBarr;");

            // "U+02911", "RIGHTWARDS ARROW WITH DOTTED STEM"
            txt = txt.Replace("⤑", "&DDotrahd;");

            // "U+02912", "UPWARDS ARROW TO BAR"
            txt = txt.Replace("⤒", "&UpArrowBar;");

            // "U+02913", "DOWNWARDS ARROW TO BAR"
            txt = txt.Replace("⤓", "&DownArrowBar;");

            // "U+02916", "RIGHTWARDS TWO-HEADED ARROW WITH TAIL"
            txt = txt.Replace("⤖", "&Rarrtl;");

            // "U+02919", "LEFTWARDS ARROW-TAIL"
            txt = txt.Replace("⤙", "&latail;");

            // "U+0291A", "RIGHTWARDS ARROW-TAIL"
            txt = txt.Replace("⤚", "&ratail;");

            // "U+0291B", "LEFTWARDS DOUBLE ARROW-TAIL"
            txt = txt.Replace("⤛", "&lAtail;");

            // "U+0291C", "RIGHTWARDS DOUBLE ARROW-TAIL"
            txt = txt.Replace("⤜", "&rAtail;");

            // "U+0291D", "LEFTWARDS ARROW TO BLACK DIAMOND"
            txt = txt.Replace("⤝", "&larrfs;");

            // "U+0291E", "RIGHTWARDS ARROW TO BLACK DIAMOND"
            txt = txt.Replace("⤞", "&rarrfs;");

            // "U+0291F", "LEFTWARDS ARROW FROM BAR TO BLACK DIAMOND"
            txt = txt.Replace("⤟", "&larrbfs;");

            // "U+02920", "RIGHTWARDS ARROW FROM BAR TO BLACK DIAMOND"
            txt = txt.Replace("⤠", "&rarrbfs;");

            // "U+02923", "NORTH WEST ARROW WITH HOOK"
            txt = txt.Replace("⤣", "&nwarhk;");

            // "U+02924", "NORTH EAST ARROW WITH HOOK"
            txt = txt.Replace("⤤", "&nearhk;");

            // "U+02925", "SOUTH EAST ARROW WITH HOOK"
            txt = txt.Replace("⤥", "&searhk;");

            // "U+02926", "SOUTH WEST ARROW WITH HOOK"
            txt = txt.Replace("⤦", "&swarhk;");

            // "U+02927", "NORTH WEST ARROW AND NORTH EAST ARROW"
            txt = txt.Replace("⤧", "&nwnear;");

            // "U+02928", "NORTH EAST ARROW AND SOUTH EAST ARROW"
            txt = txt.Replace("⤨", "&nesear;");

            // "U+02929", "SOUTH EAST ARROW AND SOUTH WEST ARROW"
            txt = txt.Replace("⤩", "&seswar;");

            // "U+0292A", "SOUTH WEST ARROW AND NORTH WEST ARROW"
            txt = txt.Replace("⤪", "&swnwar;");

            // "U+02933", "WAVE ARROW POINTING DIRECTLY RIGHT"
            txt = txt.Replace("⤳", "&rarrc;");

            // "U+02935", "ARROW POINTING RIGHTWARDS THEN CURVING DOWNWARDS"
            txt = txt.Replace("⤵", "&cudarrr;");

            // "U+02936", "ARROW POINTING DOWNWARDS THEN CURVING LEFTWARDS"
            txt = txt.Replace("⤶", "&ldca;");

            // "U+02937", "ARROW POINTING DOWNWARDS THEN CURVING RIGHTWARDS"
            txt = txt.Replace("⤷", "&rdca;");

            // "U+02938", "RIGHT-SIDE ARC CLOCKWISE ARROW"
            txt = txt.Replace("⤸", "&cudarrl;");

            // "U+02939", "LEFT-SIDE ARC ANTICLOCKWISE ARROW"
            txt = txt.Replace("⤹", "&larrpl;");

            // "U+0293C", "TOP ARC CLOCKWISE ARROW WITH MINUS"
            txt = txt.Replace("⤼", "&curarrm;");

            // "U+0293D", "TOP ARC ANTICLOCKWISE ARROW WITH PLUS"
            txt = txt.Replace("⤽", "&cularrp;");

            // "U+02945", "RIGHTWARDS ARROW WITH PLUS BELOW"
            txt = txt.Replace("⥅", "&rarrpl;");

            // "U+02948", "LEFT RIGHT ARROW THROUGH SMALL CIRCLE"
            txt = txt.Replace("⥈", "&harrcir;");

            // "U+02949", "UPWARDS TWO-HEADED ARROW FROM SMALL CIRCLE"
            txt = txt.Replace("⥉", "&Uarrocir;");

            // "U+0294A", "LEFT BARB UP RIGHT BARB DOWN HARPOON"
            txt = txt.Replace("⥊", "&lurdshar;");

            // "U+0294B", "LEFT BARB DOWN RIGHT BARB UP HARPOON"
            txt = txt.Replace("⥋", "&ldrushar;");

            // "U+0294E", "LEFT BARB UP RIGHT BARB UP HARPOON"
            txt = txt.Replace("⥎", "&LeftRightVector;");

            // "U+0294F", "UP BARB RIGHT DOWN BARB RIGHT HARPOON"
            txt = txt.Replace("⥏", "&RightUpDownVector;");

            // "U+02950", "LEFT BARB DOWN RIGHT BARB DOWN HARPOON"
            txt = txt.Replace("⥐", "&DownLeftRightVector;");

            // "U+02951", "UP BARB LEFT DOWN BARB LEFT HARPOON"
            txt = txt.Replace("⥑", "&LeftUpDownVector;");

            // "U+02952", "LEFTWARDS HARPOON WITH BARB UP TO BAR"
            txt = txt.Replace("⥒", "&LeftVectorBar;");

            // "U+02953", "RIGHTWARDS HARPOON WITH BARB UP TO BAR"
            txt = txt.Replace("⥓", "&RightVectorBar;");

            // "U+02954", "UPWARDS HARPOON WITH BARB RIGHT TO BAR"
            txt = txt.Replace("⥔", "&RightUpVectorBar;");

            // "U+02955", "DOWNWARDS HARPOON WITH BARB RIGHT TO BAR"
            txt = txt.Replace("⥕", "&RightDownVectorBar;");

            // "U+02956", "LEFTWARDS HARPOON WITH BARB DOWN TO BAR"
            txt = txt.Replace("⥖", "&DownLeftVectorBar;");

            // "U+02957", "RIGHTWARDS HARPOON WITH BARB DOWN TO BAR"
            txt = txt.Replace("⥗", "&DownRightVectorBar;");

            // "U+02958", "UPWARDS HARPOON WITH BARB LEFT TO BAR"
            txt = txt.Replace("⥘", "&LeftUpVectorBar;");

            // "U+02959", "DOWNWARDS HARPOON WITH BARB LEFT TO BAR"
            txt = txt.Replace("⥙", "&LeftDownVectorBar;");

            // "U+0295A", "LEFTWARDS HARPOON WITH BARB UP FROM BAR"
            txt = txt.Replace("⥚", "&LeftTeeVector;");

            // "U+0295B", "RIGHTWARDS HARPOON WITH BARB UP FROM BAR"
            txt = txt.Replace("⥛", "&RightTeeVector;");

            // "U+0295C", "UPWARDS HARPOON WITH BARB RIGHT FROM BAR"
            txt = txt.Replace("⥜", "&RightUpTeeVector;");

            // "U+0295D", "DOWNWARDS HARPOON WITH BARB RIGHT FROM BAR"
            txt = txt.Replace("⥝", "&RightDownTeeVector;");

            // "U+0295E", "LEFTWARDS HARPOON WITH BARB DOWN FROM BAR"
            txt = txt.Replace("⥞", "&DownLeftTeeVector;");

            // "U+0295F", "RIGHTWARDS HARPOON WITH BARB DOWN FROM BAR"
            txt = txt.Replace("⥟", "&DownRightTeeVector;");

            // "U+02960", "UPWARDS HARPOON WITH BARB LEFT FROM BAR"
            txt = txt.Replace("⥠", "&LeftUpTeeVector;");

            // "U+02961", "DOWNWARDS HARPOON WITH BARB LEFT FROM BAR"
            txt = txt.Replace("⥡", "&LeftDownTeeVector;");

            // "U+02962", "LEFTWARDS HARPOON WITH BARB UP ABOVE LEFTWARDS HARPOON WITH BARB DOWN"
            txt = txt.Replace("⥢", "&lHar;");

            // "U+02963", "UPWARDS HARPOON WITH BARB LEFT BESIDE UPWARDS HARPOON WITH BARB RIGHT"
            txt = txt.Replace("⥣", "&uHar;");

            // "U+02964", "RIGHTWARDS HARPOON WITH BARB UP ABOVE RIGHTWARDS HARPOON WITH BARB DOWN"
            txt = txt.Replace("⥤", "&rHar;");

            // "U+02965", "DOWNWARDS HARPOON WITH BARB LEFT BESIDE DOWNWARDS HARPOON WITH BARB RIGHT"
            txt = txt.Replace("⥥", "&dHar;");

            // "U+02966", "LEFTWARDS HARPOON WITH BARB UP ABOVE RIGHTWARDS HARPOON WITH BARB UP"
            txt = txt.Replace("⥦", "&luruhar;");

            // "U+02967", "LEFTWARDS HARPOON WITH BARB DOWN ABOVE RIGHTWARDS HARPOON WITH BARB DOWN"
            txt = txt.Replace("⥧", "&ldrdhar;");

            // "U+02968", "RIGHTWARDS HARPOON WITH BARB UP ABOVE LEFTWARDS HARPOON WITH BARB UP"
            txt = txt.Replace("⥨", "&ruluhar;");

            // "U+02969", "RIGHTWARDS HARPOON WITH BARB DOWN ABOVE LEFTWARDS HARPOON WITH BARB DOWN"
            txt = txt.Replace("⥩", "&rdldhar;");

            // "U+0296A", "LEFTWARDS HARPOON WITH BARB UP ABOVE LONG DASH"
            txt = txt.Replace("⥪", "&lharul;");

            // "U+0296B", "LEFTWARDS HARPOON WITH BARB DOWN BELOW LONG DASH"
            txt = txt.Replace("⥫", "&llhard;");

            // "U+0296C", "RIGHTWARDS HARPOON WITH BARB UP ABOVE LONG DASH"
            txt = txt.Replace("⥬", "&rharul;");

            // "U+0296D", "RIGHTWARDS HARPOON WITH BARB DOWN BELOW LONG DASH"
            txt = txt.Replace("⥭", "&lrhard;");

            // "U+0296E", "UPWARDS HARPOON WITH BARB LEFT BESIDE DOWNWARDS HARPOON WITH BARB RIGHT"
            txt = txt.Replace("⥮", "&udhar;");

            // "U+0296F", "DOWNWARDS HARPOON WITH BARB LEFT BESIDE UPWARDS HARPOON WITH BARB RIGHT"
            txt = txt.Replace("⥯", "&duhar;");

            // "U+02970", "RIGHT DOUBLE ARROW WITH ROUNDED HEAD"
            txt = txt.Replace("⥰", "&RoundImplies;");

            // "U+02971", "EQUALS SIGN ABOVE RIGHTWARDS ARROW"
            txt = txt.Replace("⥱", "&erarr;");

            // "U+02972", "TILDE OPERATOR ABOVE RIGHTWARDS ARROW"
            txt = txt.Replace("⥲", "&simrarr;");

            // "U+02973", "LEFTWARDS ARROW ABOVE TILDE OPERATOR"
            txt = txt.Replace("⥳", "&larrsim;");

            // "U+02974", "RIGHTWARDS ARROW ABOVE TILDE OPERATOR"
            txt = txt.Replace("⥴", "&rarrsim;");

            // "U+02975", "RIGHTWARDS ARROW ABOVE ALMOST EQUAL TO"
            txt = txt.Replace("⥵", "&rarrap;");

            // "U+02976", "LESS-THAN ABOVE LEFTWARDS ARROW"
            txt = txt.Replace("⥶", "&ltlarr;");

            // "U+02978", "GREATER-THAN ABOVE RIGHTWARDS ARROW"
            txt = txt.Replace("⥸", "&gtrarr;");

            // "U+02979", "SUBSET ABOVE RIGHTWARDS ARROW"
            txt = txt.Replace("⥹", "&subrarr;");

            // "U+0297B", "SUPERSET ABOVE LEFTWARDS ARROW"
            txt = txt.Replace("⥻", "&suplarr;");

            // "U+0297C", "LEFT FISH TAIL"
            txt = txt.Replace("⥼", "&lfisht;");

            // "U+0297D", "RIGHT FISH TAIL"
            txt = txt.Replace("⥽", "&rfisht;");

            // "U+0297E", "UP FISH TAIL"
            txt = txt.Replace("⥾", "&ufisht;");

            // "U+0297F", "DOWN FISH TAIL"
            txt = txt.Replace("⥿", "&dfisht;");

            // "U+02985", "LEFT WHITE PARENTHESIS"
            txt = txt.Replace("⦅", "&lopar;");

            // "U+02986", "RIGHT WHITE PARENTHESIS"
            txt = txt.Replace("⦆", "&ropar;");

            // "U+0298B", "LEFT SQUARE BRACKET WITH UNDERBAR"
            txt = txt.Replace("⦋", "&lbrke;");

            // "U+0298C", "RIGHT SQUARE BRACKET WITH UNDERBAR"
            txt = txt.Replace("⦌", "&rbrke;");

            // "U+0298D", "LEFT SQUARE BRACKET WITH TICK IN TOP CORNER"
            txt = txt.Replace("⦍", "&lbrkslu;");

            // "U+0298E", "RIGHT SQUARE BRACKET WITH TICK IN BOTTOM CORNER"
            txt = txt.Replace("⦎", "&rbrksld;");

            // "U+0298F", "LEFT SQUARE BRACKET WITH TICK IN BOTTOM CORNER"
            txt = txt.Replace("⦏", "&lbrksld;");

            // "U+02990", "RIGHT SQUARE BRACKET WITH TICK IN TOP CORNER"
            txt = txt.Replace("⦐", "&rbrkslu;");

            // "U+02991", "LEFT ANGLE BRACKET WITH DOT"
            txt = txt.Replace("⦑", "&langd;");

            // "U+02992", "RIGHT ANGLE BRACKET WITH DOT"
            txt = txt.Replace("⦒", "&rangd;");

            // "U+02993", "LEFT ARC LESS-THAN BRACKET"
            txt = txt.Replace("⦓", "&lparlt;");

            // "U+02994", "RIGHT ARC GREATER-THAN BRACKET"
            txt = txt.Replace("⦔", "&rpargt;");

            // "U+02995", "DOUBLE LEFT ARC GREATER-THAN BRACKET"
            txt = txt.Replace("⦕", "&gtlPar;");

            // "U+02996", "DOUBLE RIGHT ARC LESS-THAN BRACKET"
            txt = txt.Replace("⦖", "&ltrPar;");

            // "U+0299A", "VERTICAL ZIGZAG LINE"
            txt = txt.Replace("⦚", "&vzigzag;");

            // "U+0299C", "RIGHT ANGLE VARIANT WITH SQUARE"
            txt = txt.Replace("⦜", "&vangrt;");

            // "U+0299D", "MEASURED RIGHT ANGLE WITH DOT"
            txt = txt.Replace("⦝", "&angrtvbd;");

            // "U+029A4", "ANGLE WITH UNDERBAR"
            txt = txt.Replace("⦤", "&ange;");

            // "U+029A5", "REVERSED ANGLE WITH UNDERBAR"
            txt = txt.Replace("⦥", "&range;");

            // "U+029A6", "OBLIQUE ANGLE OPENING UP"
            txt = txt.Replace("⦦", "&dwangle;");

            // "U+029A7", "OBLIQUE ANGLE OPENING DOWN"
            txt = txt.Replace("⦧", "&uwangle;");

            // "U+029A8", "MEASURED ANGLE WITH OPEN ARM ENDING IN ARROW POINTING UP AND RIGHT"
            txt = txt.Replace("⦨", "&angmsdaa;");

            // "U+029A9", "MEASURED ANGLE WITH OPEN ARM ENDING IN ARROW POINTING UP AND LEFT"
            txt = txt.Replace("⦩", "&angmsdab;");

            // "U+029AA", "MEASURED ANGLE WITH OPEN ARM ENDING IN ARROW POINTING DOWN AND RIGHT"
            txt = txt.Replace("⦪", "&angmsdac;");

            // "U+029AB", "MEASURED ANGLE WITH OPEN ARM ENDING IN ARROW POINTING DOWN AND LEFT"
            txt = txt.Replace("⦫", "&angmsdad;");

            // "U+029AC", "MEASURED ANGLE WITH OPEN ARM ENDING IN ARROW POINTING RIGHT AND UP"
            txt = txt.Replace("⦬", "&angmsdae;");

            // "U+029AD", "MEASURED ANGLE WITH OPEN ARM ENDING IN ARROW POINTING LEFT AND UP"
            txt = txt.Replace("⦭", "&angmsdaf;");

            // "U+029AE", "MEASURED ANGLE WITH OPEN ARM ENDING IN ARROW POINTING RIGHT AND DOWN"
            txt = txt.Replace("⦮", "&angmsdag;");

            // "U+029AF", "MEASURED ANGLE WITH OPEN ARM ENDING IN ARROW POINTING LEFT AND DOWN"
            txt = txt.Replace("⦯", "&angmsdah;");

            // "U+029B0", "REVERSED EMPTY SET"
            txt = txt.Replace("⦰", "&bemptyv;");

            // "U+029B1", "EMPTY SET WITH OVERBAR"
            txt = txt.Replace("⦱", "&demptyv;");

            // "U+029B2", "EMPTY SET WITH SMALL CIRCLE ABOVE"
            txt = txt.Replace("⦲", "&cemptyv;");

            // "U+029B3", "EMPTY SET WITH RIGHT ARROW ABOVE"
            txt = txt.Replace("⦳", "&raemptyv;");

            // "U+029B4", "EMPTY SET WITH LEFT ARROW ABOVE"
            txt = txt.Replace("⦴", "&laemptyv;");

            // "U+029B5", "CIRCLE WITH HORIZONTAL BAR"
            txt = txt.Replace("⦵", "&ohbar;");

            // "U+029B6", "CIRCLED VERTICAL BAR"
            txt = txt.Replace("⦶", "&omid;");

            // "U+029B7", "CIRCLED PARALLEL"
            txt = txt.Replace("⦷", "&opar;");

            // "U+029B9", "CIRCLED PERPENDICULAR"
            txt = txt.Replace("⦹", "&operp;");

            // "U+029BB", "CIRCLE WITH SUPERIMPOSED X"
            txt = txt.Replace("⦻", "&olcross;");

            // "U+029BC", "CIRCLED ANTICLOCKWISE-ROTATED DIVISION SIGN"
            txt = txt.Replace("⦼", "&odsold;");

            // "U+029BE", "CIRCLED WHITE BULLET"
            txt = txt.Replace("⦾", "&olcir;");

            // "U+029BF", "CIRCLED BULLET"
            txt = txt.Replace("⦿", "&ofcir;");

            // "U+029C0", "CIRCLED LESS-THAN"
            txt = txt.Replace("⧀", "&olt;");

            // "U+029C1", "CIRCLED GREATER-THAN"
            txt = txt.Replace("⧁", "&ogt;");

            // "U+029C2", "CIRCLE WITH SMALL CIRCLE TO THE RIGHT"
            txt = txt.Replace("⧂", "&cirscir;");

            // "U+029C3", "CIRCLE WITH TWO HORIZONTAL STROKES TO THE RIGHT"
            txt = txt.Replace("⧃", "&cirE;");

            // "U+029C4", "SQUARED RISING DIAGONAL SLASH"
            txt = txt.Replace("⧄", "&solb;");

            // "U+029C5", "SQUARED FALLING DIAGONAL SLASH"
            txt = txt.Replace("⧅", "&bsolb;");

            // "U+029C9", "TWO JOINED SQUARES"
            txt = txt.Replace("⧉", "&boxbox;");

            // "U+029CD", "TRIANGLE WITH SERIFS AT BOTTOM"
            txt = txt.Replace("⧍", "&trisb;");

            // "U+029CE", "RIGHT TRIANGLE ABOVE LEFT TRIANGLE"
            txt = txt.Replace("⧎", "&rtriltri;");

            // "U+029CF", "LEFT TRIANGLE BESIDE VERTICAL BAR"
            txt = txt.Replace("⧏", "&LeftTriangleBar;");

            // "U+029D0", "VERTICAL BAR BESIDE RIGHT TRIANGLE"
            txt = txt.Replace("⧐", "&RightTriangleBar;");

            // "U+029DA", "LEFT DOUBLE WIGGLY FENCE"
            txt = txt.Replace("⧚", "&race;");

            // "U+029DC", "INCOMPLETE INFINITY"
            txt = txt.Replace("⧜", "&iinfin;");

            // "U+029DD", "TIE OVER INFINITY"
            txt = txt.Replace("⧝", "&infintie;");

            // "U+029DE", "INFINITY NEGATED WITH VERTICAL BAR"
            txt = txt.Replace("⧞", "&nvinfin;");

            // "U+029E3", "EQUALS SIGN AND SLANTED PARALLEL"
            txt = txt.Replace("⧣", "&eparsl;");

            // "U+029E4", "EQUALS SIGN AND SLANTED PARALLEL WITH TILDE ABOVE"
            txt = txt.Replace("⧤", "&smeparsl;");

            // "U+029E5", "IDENTICAL TO AND SLANTED PARALLEL"
            txt = txt.Replace("⧥", "&eqvparsl;");

            // "U+029EB", "BLACK LOZENGE"
            txt = txt.Replace("⧫", "&lozf;");

            // "U+029F4", "RULE-DELAYED"
            txt = txt.Replace("⧴", "&RuleDelayed;");

            // "U+029F6", "SOLIDUS WITH OVERBAR"
            txt = txt.Replace("⧶", "&dsol;");

            // "U+02A00", "N-ARY CIRCLED DOT OPERATOR"
            txt = txt.Replace("⨀", "&xodot;");

            // "U+02A01", "N-ARY CIRCLED PLUS OPERATOR"
            txt = txt.Replace("⨁", "&xoplus;");

            // "U+02A02", "N-ARY CIRCLED TIMES OPERATOR"
            txt = txt.Replace("⨂", "&xotime;");

            // "U+02A04", "N-ARY UNION OPERATOR WITH PLUS"
            txt = txt.Replace("⨄", "&xuplus;");

            // "U+02A06", "N-ARY SQUARE UNION OPERATOR"
            txt = txt.Replace("⨆", "&xsqcup;");

            // "U+02A0C", "QUADRUPLE INTEGRAL OPERATOR"
            txt = txt.Replace("⨌", "&qint;");

            // "U+02A0D", "FINITE PART INTEGRAL"
            txt = txt.Replace("⨍", "&fpartint;");

            // "U+02A10", "CIRCULATION FUNCTION"
            txt = txt.Replace("⨐", "&cirfnint;");

            // "U+02A11", "ANTICLOCKWISE INTEGRATION"
            txt = txt.Replace("⨑", "&awint;");

            // "U+02A12", "LINE INTEGRATION WITH RECTANGULAR PATH AROUND POLE"
            txt = txt.Replace("⨒", "&rppolint;");

            // "U+02A13", "LINE INTEGRATION WITH SEMICIRCULAR PATH AROUND POLE"
            txt = txt.Replace("⨓", "&scpolint;");

            // "U+02A14", "LINE INTEGRATION NOT INCLUDING THE POLE"
            txt = txt.Replace("⨔", "&npolint;");

            // "U+02A15", "INTEGRAL AROUND A POINT OPERATOR"
            txt = txt.Replace("⨕", "&pointint;");

            // "U+02A16", "QUATERNION INTEGRAL OPERATOR"
            txt = txt.Replace("⨖", "&quatint;");

            // "U+02A17", "INTEGRAL WITH LEFTWARDS ARROW WITH HOOK"
            txt = txt.Replace("⨗", "&intlarhk;");

            // "U+02A22", "PLUS SIGN WITH SMALL CIRCLE ABOVE"
            txt = txt.Replace("⨢", "&pluscir;");

            // "U+02A23", "PLUS SIGN WITH CIRCUMFLEX ACCENT ABOVE"
            txt = txt.Replace("⨣", "&plusacir;");

            // "U+02A24", "PLUS SIGN WITH TILDE ABOVE"
            txt = txt.Replace("⨤", "&simplus;");

            // "U+02A25", "PLUS SIGN WITH DOT BELOW"
            txt = txt.Replace("⨥", "&plusdu;");

            // "U+02A26", "PLUS SIGN WITH TILDE BELOW"
            txt = txt.Replace("⨦", "&plussim;");

            // "U+02A27", "PLUS SIGN WITH SUBSCRIPT TWO"
            txt = txt.Replace("⨧", "&plustwo;");

            // "U+02A29", "MINUS SIGN WITH COMMA ABOVE"
            txt = txt.Replace("⨩", "&mcomma;");

            // "U+02A2A", "MINUS SIGN WITH DOT BELOW"
            txt = txt.Replace("⨪", "&minusdu;");

            // "U+02A2D", "PLUS SIGN IN LEFT HALF CIRCLE"
            txt = txt.Replace("⨭", "&loplus;");

            // "U+02A2E", "PLUS SIGN IN RIGHT HALF CIRCLE"
            txt = txt.Replace("⨮", "&roplus;");

            // "U+02A2F", "VECTOR OR CROSS PRODUCT"
            txt = txt.Replace("⨯", "&Cross;");

            // "U+02A30", "MULTIPLICATION SIGN WITH DOT ABOVE"
            txt = txt.Replace("⨰", "&timesd;");

            // "U+02A31", "MULTIPLICATION SIGN WITH UNDERBAR"
            txt = txt.Replace("⨱", "&timesbar;");

            // "U+02A33", "SMASH PRODUCT"
            txt = txt.Replace("⨳", "&smashp;");

            // "U+02A34", "MULTIPLICATION SIGN IN LEFT HALF CIRCLE"
            txt = txt.Replace("⨴", "&lotimes;");

            // "U+02A35", "MULTIPLICATION SIGN IN RIGHT HALF CIRCLE"
            txt = txt.Replace("⨵", "&rotimes;");

            // "U+02A36", "CIRCLED MULTIPLICATION SIGN WITH CIRCUMFLEX ACCENT"
            txt = txt.Replace("⨶", "&otimesas;");

            // "U+02A37", "MULTIPLICATION SIGN IN DOUBLE CIRCLE"
            txt = txt.Replace("⨷", "&Otimes;");

            // "U+02A38", "CIRCLED DIVISION SIGN"
            txt = txt.Replace("⨸", "&odiv;");

            // "U+02A39", "PLUS SIGN IN TRIANGLE"
            txt = txt.Replace("⨹", "&triplus;");

            // "U+02A3A", "MINUS SIGN IN TRIANGLE"
            txt = txt.Replace("⨺", "&triminus;");

            // "U+02A3B", "MULTIPLICATION SIGN IN TRIANGLE"
            txt = txt.Replace("⨻", "&tritime;");

            // "U+02A3C", "INTERIOR PRODUCT"
            txt = txt.Replace("⨼", "&iprod;");

            // "U+02A3F", "AMALGAMATION OR COPRODUCT"
            txt = txt.Replace("⨿", "&amalg;");

            // "U+02A40", "INTERSECTION WITH DOT"
            txt = txt.Replace("⩀", "&capdot;");

            // "U+02A42", "UNION WITH OVERBAR"
            txt = txt.Replace("⩂", "&ncup;");

            // "U+02A43", "INTERSECTION WITH OVERBAR"
            txt = txt.Replace("⩃", "&ncap;");

            // "U+02A44", "INTERSECTION WITH LOGICAL AND"
            txt = txt.Replace("⩄", "&capand;");

            // "U+02A45", "UNION WITH LOGICAL OR"
            txt = txt.Replace("⩅", "&cupor;");

            // "U+02A46", "UNION ABOVE INTERSECTION"
            txt = txt.Replace("⩆", "&cupcap;");

            // "U+02A47", "INTERSECTION ABOVE UNION"
            txt = txt.Replace("⩇", "&capcup;");

            // "U+02A48", "UNION ABOVE BAR ABOVE INTERSECTION"
            txt = txt.Replace("⩈", "&cupbrcap;");

            // "U+02A49", "INTERSECTION ABOVE BAR ABOVE UNION"
            txt = txt.Replace("⩉", "&capbrcup;");

            // "U+02A4A", "UNION BESIDE AND JOINED WITH UNION"
            txt = txt.Replace("⩊", "&cupcup;");

            // "U+02A4B", "INTERSECTION BESIDE AND JOINED WITH INTERSECTION"
            txt = txt.Replace("⩋", "&capcap;");

            // "U+02A4C", "CLOSED UNION WITH SERIFS"
            txt = txt.Replace("⩌", "&ccups;");

            // "U+02A4D", "CLOSED INTERSECTION WITH SERIFS"
            txt = txt.Replace("⩍", "&ccaps;");

            // "U+02A50", "CLOSED UNION WITH SERIFS AND SMASH PRODUCT"
            txt = txt.Replace("⩐", "&ccupssm;");

            // "U+02A53", "DOUBLE LOGICAL AND"
            txt = txt.Replace("⩓", "&And;");

            // "U+02A54", "DOUBLE LOGICAL OR"
            txt = txt.Replace("⩔", "&Or;");

            // "U+02A55", "TWO INTERSECTING LOGICAL AND"
            txt = txt.Replace("⩕", "&andand;");

            // "U+02A56", "TWO INTERSECTING LOGICAL OR"
            txt = txt.Replace("⩖", "&oror;");

            // "U+02A57", "SLOPING LARGE OR"
            txt = txt.Replace("⩗", "&orslope;");

            // "U+02A58", "SLOPING LARGE AND"
            txt = txt.Replace("⩘", "&andslope;");

            // "U+02A5A", "LOGICAL AND WITH MIDDLE STEM"
            txt = txt.Replace("⩚", "&andv;");

            // "U+02A5B", "LOGICAL OR WITH MIDDLE STEM"
            txt = txt.Replace("⩛", "&orv;");

            // "U+02A5C", "LOGICAL AND WITH HORIZONTAL DASH"
            txt = txt.Replace("⩜", "&andd;");

            // "U+02A5D", "LOGICAL OR WITH HORIZONTAL DASH"
            txt = txt.Replace("⩝", "&ord;");

            // "U+02A5F", "LOGICAL AND WITH UNDERBAR"
            txt = txt.Replace("⩟", "&wedbar;");

            // "U+02A66", "EQUALS SIGN WITH DOT BELOW"
            txt = txt.Replace("⩦", "&sdote;");

            // "U+02A6A", "TILDE OPERATOR WITH DOT ABOVE"
            txt = txt.Replace("⩪", "&simdot;");

            // "U+02A6D", "CONGRUENT WITH DOT ABOVE"
            txt = txt.Replace("⩭", "&congdot;");

            // "U+02A6E", "EQUALS WITH ASTERISK"
            txt = txt.Replace("⩮", "&easter;");

            // "U+02A6F", "ALMOST EQUAL TO WITH CIRCUMFLEX ACCENT"
            txt = txt.Replace("⩯", "&apacir;");

            // "U+02A70", "APPROXIMATELY EQUAL OR EQUAL TO"
            txt = txt.Replace("⩰", "&apE;");

            // "U+02A71", "EQUALS SIGN ABOVE PLUS SIGN"
            txt = txt.Replace("⩱", "&eplus;");

            // "U+02A72", "PLUS SIGN ABOVE EQUALS SIGN"
            txt = txt.Replace("⩲", "&pluse;");

            // "U+02A73", "EQUALS SIGN ABOVE TILDE OPERATOR"
            txt = txt.Replace("⩳", "&Esim;");

            // "U+02A74", "DOUBLE COLON EQUAL"
            txt = txt.Replace("⩴", "&Colone;");

            // "U+02A75", "TWO CONSECUTIVE EQUALS SIGNS"
            txt = txt.Replace("⩵", "&Equal;");

            // "U+02A77", "EQUALS SIGN WITH TWO DOTS ABOVE AND TWO DOTS BELOW"
            txt = txt.Replace("⩷", "&eDDot;");

            // "U+02A78", "EQUIVALENT WITH FOUR DOTS ABOVE"
            txt = txt.Replace("⩸", "&equivDD;");

            // "U+02A79", "LESS-THAN WITH CIRCLE INSIDE"
            txt = txt.Replace("⩹", "&ltcir;");

            // "U+02A7A", "GREATER-THAN WITH CIRCLE INSIDE"
            txt = txt.Replace("⩺", "&gtcir;");

            // "U+02A7B", "LESS-THAN WITH QUESTION MARK ABOVE"
            txt = txt.Replace("⩻", "&ltquest;");

            // "U+02A7C", "GREATER-THAN WITH QUESTION MARK ABOVE"
            txt = txt.Replace("⩼", "&gtquest;");

            // "U+02A7D", "LESS-THAN OR SLANTED EQUAL TO"
            txt = txt.Replace("⩽", "&les;");

            // "U+02A7E", "GREATER-THAN OR SLANTED EQUAL TO"
            txt = txt.Replace("⩾", "&ges;");

            // "U+02A7F", "LESS-THAN OR SLANTED EQUAL TO WITH DOT INSIDE"
            txt = txt.Replace("⩿", "&lesdot;");

            // "U+02A80", "GREATER-THAN OR SLANTED EQUAL TO WITH DOT INSIDE"
            txt = txt.Replace("⪀", "&gesdot;");

            // "U+02A81", "LESS-THAN OR SLANTED EQUAL TO WITH DOT ABOVE"
            txt = txt.Replace("⪁", "&lesdoto;");

            // "U+02A82", "GREATER-THAN OR SLANTED EQUAL TO WITH DOT ABOVE"
            txt = txt.Replace("⪂", "&gesdoto;");

            // "U+02A83", "LESS-THAN OR SLANTED EQUAL TO WITH DOT ABOVE RIGHT"
            txt = txt.Replace("⪃", "&lesdotor;");

            // "U+02A84", "GREATER-THAN OR SLANTED EQUAL TO WITH DOT ABOVE LEFT"
            txt = txt.Replace("⪄", "&gesdotol;");

            // "U+02A85", "LESS-THAN OR APPROXIMATE"
            txt = txt.Replace("⪅", "&lap;");

            // "U+02A86", "GREATER-THAN OR APPROXIMATE"
            txt = txt.Replace("⪆", "&gap;");

            // "U+02A87", "LESS-THAN AND SINGLE-LINE NOT EQUAL TO"
            txt = txt.Replace("⪇", "&lne;");

            // "U+02A88", "GREATER-THAN AND SINGLE-LINE NOT EQUAL TO"
            txt = txt.Replace("⪈", "&gne;");

            // "U+02A89", "LESS-THAN AND NOT APPROXIMATE"
            txt = txt.Replace("⪉", "&lnap;");

            // "U+02A8A", "GREATER-THAN AND NOT APPROXIMATE"
            txt = txt.Replace("⪊", "&gnap;");

            // "U+02A8B", "LESS-THAN ABOVE DOUBLE-LINE EQUAL ABOVE GREATER-THAN"
            txt = txt.Replace("⪋", "&lEg;");

            // "U+02A8C", "GREATER-THAN ABOVE DOUBLE-LINE EQUAL ABOVE LESS-THAN"
            txt = txt.Replace("⪌", "&gEl;");

            // "U+02A8D", "LESS-THAN ABOVE SIMILAR OR EQUAL"
            txt = txt.Replace("⪍", "&lsime;");

            // "U+02A8E", "GREATER-THAN ABOVE SIMILAR OR EQUAL"
            txt = txt.Replace("⪎", "&gsime;");

            // "U+02A8F", "LESS-THAN ABOVE SIMILAR ABOVE GREATER-THAN"
            txt = txt.Replace("⪏", "&lsimg;");

            // "U+02A90", "GREATER-THAN ABOVE SIMILAR ABOVE LESS-THAN"
            txt = txt.Replace("⪐", "&gsiml;");

            // "U+02A91", "LESS-THAN ABOVE GREATER-THAN ABOVE DOUBLE-LINE EQUAL"
            txt = txt.Replace("⪑", "&lgE;");

            // "U+02A92", "GREATER-THAN ABOVE LESS-THAN ABOVE DOUBLE-LINE EQUAL"
            txt = txt.Replace("⪒", "&glE;");

            // "U+02A93", "LESS-THAN ABOVE SLANTED EQUAL ABOVE GREATER-THAN ABOVE SLANTED EQUAL"
            txt = txt.Replace("⪓", "&lesges;");

            // "U+02A94", "GREATER-THAN ABOVE SLANTED EQUAL ABOVE LESS-THAN ABOVE SLANTED EQUAL"
            txt = txt.Replace("⪔", "&gesles;");

            // "U+02A95", "SLANTED EQUAL TO OR LESS-THAN"
            txt = txt.Replace("⪕", "&els;");

            // "U+02A96", "SLANTED EQUAL TO OR GREATER-THAN"
            txt = txt.Replace("⪖", "&egs;");

            // "U+02A97", "SLANTED EQUAL TO OR LESS-THAN WITH DOT INSIDE"
            txt = txt.Replace("⪗", "&elsdot;");

            // "U+02A98", "SLANTED EQUAL TO OR GREATER-THAN WITH DOT INSIDE"
            txt = txt.Replace("⪘", "&egsdot;");

            // "U+02A99", "DOUBLE-LINE EQUAL TO OR LESS-THAN"
            txt = txt.Replace("⪙", "&el;");

            // "U+02A9A", "DOUBLE-LINE EQUAL TO OR GREATER-THAN"
            txt = txt.Replace("⪚", "&eg;");

            // "U+02A9D", "SIMILAR OR LESS-THAN"
            txt = txt.Replace("⪝", "&siml;");

            // "U+02A9E", "SIMILAR OR GREATER-THAN"
            txt = txt.Replace("⪞", "&simg;");

            // "U+02A9F", "SIMILAR ABOVE LESS-THAN ABOVE EQUALS SIGN"
            txt = txt.Replace("⪟", "&simlE;");

            // "U+02AA0", "SIMILAR ABOVE GREATER-THAN ABOVE EQUALS SIGN"
            txt = txt.Replace("⪠", "&simgE;");

            // "U+02AA1", "DOUBLE NESTED LESS-THAN"
            txt = txt.Replace("⪡", "&LessLess;");

            // "U+02AA2", "DOUBLE NESTED GREATER-THAN"
            txt = txt.Replace("⪢", "&GreaterGreater;");

            // "U+02AA4", "GREATER-THAN OVERLAPPING LESS-THAN"
            txt = txt.Replace("⪤", "&glj;");

            // "U+02AA5", "GREATER-THAN BESIDE LESS-THAN"
            txt = txt.Replace("⪥", "&gla;");

            // "U+02AA6", "LESS-THAN CLOSED BY CURVE"
            txt = txt.Replace("⪦", "&ltcc;");

            // "U+02AA7", "GREATER-THAN CLOSED BY CURVE"
            txt = txt.Replace("⪧", "&gtcc;");

            // "U+02AA8", "LESS-THAN CLOSED BY CURVE ABOVE SLANTED EQUAL"
            txt = txt.Replace("⪨", "&lescc;");

            // "U+02AA9", "GREATER-THAN CLOSED BY CURVE ABOVE SLANTED EQUAL"
            txt = txt.Replace("⪩", "&gescc;");

            // "U+02AAA", "SMALLER THAN"
            txt = txt.Replace("⪪", "&smt;");

            // "U+02AAB", "LARGER THAN"
            txt = txt.Replace("⪫", "&lat;");

            // "U+02AAC", "SMALLER THAN OR EQUAL TO"
            txt = txt.Replace("⪬", "&smte;");

            // "U+02AAD", "LARGER THAN OR EQUAL TO"
            txt = txt.Replace("⪭", "&late;");

            // "U+02AAE", "EQUALS SIGN WITH BUMPY ABOVE"
            txt = txt.Replace("⪮", "&bumpE;");

            // "U+02AAF", "PRECEDES ABOVE SINGLE-LINE EQUALS SIGN"
            txt = txt.Replace("⪯", "&pre;");

            // "U+02AB0", "SUCCEEDS ABOVE SINGLE-LINE EQUALS SIGN"
            txt = txt.Replace("⪰", "&sce;");

            // "U+02AB3", "PRECEDES ABOVE EQUALS SIGN"
            txt = txt.Replace("⪳", "&prE;");

            // "U+02AB4", "SUCCEEDS ABOVE EQUALS SIGN"
            txt = txt.Replace("⪴", "&scE;");

            // "U+02AB5", "PRECEDES ABOVE NOT EQUAL TO"
            txt = txt.Replace("⪵", "&prnE;");

            // "U+02AB6", "SUCCEEDS ABOVE NOT EQUAL TO"
            txt = txt.Replace("⪶", "&scnE;");

            // "U+02AB7", "PRECEDES ABOVE ALMOST EQUAL TO"
            txt = txt.Replace("⪷", "&prap;");

            // "U+02AB8", "SUCCEEDS ABOVE ALMOST EQUAL TO"
            txt = txt.Replace("⪸", "&scap;");

            // "U+02AB9", "PRECEDES ABOVE NOT ALMOST EQUAL TO"
            txt = txt.Replace("⪹", "&prnap;");

            // "U+02ABA", "SUCCEEDS ABOVE NOT ALMOST EQUAL TO"
            txt = txt.Replace("⪺", "&scnap;");

            // "U+02ABB", "DOUBLE PRECEDES"
            txt = txt.Replace("⪻", "&Pr;");

            // "U+02ABC", "DOUBLE SUCCEEDS"
            txt = txt.Replace("⪼", "&Sc;");

            // "U+02ABD", "SUBSET WITH DOT"
            txt = txt.Replace("⪽", "&subdot;");

            // "U+02ABE", "SUPERSET WITH DOT"
            txt = txt.Replace("⪾", "&supdot;");

            // "U+02ABF", "SUBSET WITH PLUS SIGN BELOW"
            txt = txt.Replace("⪿", "&subplus;");

            // "U+02AC0", "SUPERSET WITH PLUS SIGN BELOW"
            txt = txt.Replace("⫀", "&supplus;");

            // "U+02AC1", "SUBSET WITH MULTIPLICATION SIGN BELOW"
            txt = txt.Replace("⫁", "&submult;");

            // "U+02AC2", "SUPERSET WITH MULTIPLICATION SIGN BELOW"
            txt = txt.Replace("⫂", "&supmult;");

            // "U+02AC3", "SUBSET OF OR EQUAL TO WITH DOT ABOVE"
            txt = txt.Replace("⫃", "&subedot;");

            // "U+02AC4", "SUPERSET OF OR EQUAL TO WITH DOT ABOVE"
            txt = txt.Replace("⫄", "&supedot;");

            // "U+02AC5", "SUBSET OF ABOVE EQUALS SIGN"
            txt = txt.Replace("⫅", "&subE;");

            // "U+02AC6", "SUPERSET OF ABOVE EQUALS SIGN"
            txt = txt.Replace("⫆", "&supE;");

            // "U+02AC7", "SUBSET OF ABOVE TILDE OPERATOR"
            txt = txt.Replace("⫇", "&subsim;");

            // "U+02AC8", "SUPERSET OF ABOVE TILDE OPERATOR"
            txt = txt.Replace("⫈", "&supsim;");

            // "U+02ACB", "SUBSET OF ABOVE NOT EQUAL TO"
            txt = txt.Replace("⫋", "&subnE;");

            // "U+02ACC", "SUPERSET OF ABOVE NOT EQUAL TO"
            txt = txt.Replace("⫌", "&supnE;");

            // "U+02ACF", "CLOSED SUBSET"
            txt = txt.Replace("⫏", "&csub;");

            // "U+02AD0", "CLOSED SUPERSET"
            txt = txt.Replace("⫐", "&csup;");

            // "U+02AD1", "CLOSED SUBSET OR EQUAL TO"
            txt = txt.Replace("⫑", "&csube;");

            // "U+02AD2", "CLOSED SUPERSET OR EQUAL TO"
            txt = txt.Replace("⫒", "&csupe;");

            // "U+02AD3", "SUBSET ABOVE SUPERSET"
            txt = txt.Replace("⫓", "&subsup;");

            // "U+02AD4", "SUPERSET ABOVE SUBSET"
            txt = txt.Replace("⫔", "&supsub;");

            // "U+02AD5", "SUBSET ABOVE SUBSET"
            txt = txt.Replace("⫕", "&subsub;");

            // "U+02AD6", "SUPERSET ABOVE SUPERSET"
            txt = txt.Replace("⫖", "&supsup;");

            // "U+02AD7", "SUPERSET BESIDE SUBSET"
            txt = txt.Replace("⫗", "&suphsub;");

            // "U+02AD8", "SUPERSET BESIDE AND JOINED BY DASH WITH SUBSET"
            txt = txt.Replace("⫘", "&supdsub;");

            // "U+02AD9", "ELEMENT OF OPENING DOWNWARDS"
            txt = txt.Replace("⫙", "&forkv;");

            // "U+02ADA", "PITCHFORK WITH TEE TOP"
            txt = txt.Replace("⫚", "&topfork;");

            // "U+02ADB", "TRANSVERSAL INTERSECTION"
            txt = txt.Replace("⫛", "&mlcp;");

            // "U+02AE4", "VERTICAL BAR DOUBLE LEFT TURNSTILE"
            txt = txt.Replace("⫤", "&Dashv;");

            // "U+02AE6", "LONG DASH FROM LEFT MEMBER OF DOUBLE VERTICAL"
            txt = txt.Replace("⫦", "&Vdashl;");

            // "U+02AE7", "SHORT DOWN TACK WITH OVERBAR"
            txt = txt.Replace("⫧", "&Barv;");

            // "U+02AE8", "SHORT UP TACK WITH UNDERBAR"
            txt = txt.Replace("⫨", "&vBar;");

            // "U+02AE9", "SHORT UP TACK ABOVE SHORT DOWN TACK"
            txt = txt.Replace("⫩", "&vBarv;");

            // "U+02AEB", "DOUBLE UP TACK"
            txt = txt.Replace("⫫", "&Vbar;");

            // "U+02AEC", "DOUBLE STROKE NOT SIGN"
            txt = txt.Replace("⫬", "&Not;");

            // "U+02AED", "REVERSED DOUBLE STROKE NOT SIGN"
            txt = txt.Replace("⫭", "&bNot;");

            // "U+02AEE", "DOES NOT DIVIDE WITH REVERSED NEGATION SLASH"
            txt = txt.Replace("⫮", "&rnmid;");

            // "U+02AEF", "VERTICAL LINE WITH CIRCLE ABOVE"
            txt = txt.Replace("⫯", "&cirmid;");

            // "U+02AF0", "VERTICAL LINE WITH CIRCLE BELOW"
            txt = txt.Replace("⫰", "&midcir;");

            // "U+02AF1", "DOWN TACK WITH CIRCLE BELOW"
            txt = txt.Replace("⫱", "&topcir;");

            // "U+02AF2", "PARALLEL WITH HORIZONTAL STROKE"
            txt = txt.Replace("⫲", "&nhpar;");

            // "U+02AF3", "PARALLEL WITH TILDE OPERATOR"
            txt = txt.Replace("⫳", "&parsim;");

            // "U+02AFD", "DOUBLE SOLIDUS OPERATOR"
            txt = txt.Replace("⫽", "&parsl;");

            // "U+0FB00", "LATIN SMALL LIGATURE FF"
            txt = txt.Replace("ﬀ", "&fflig;");

            // "U+0FB01", "LATIN SMALL LIGATURE FI"
            txt = txt.Replace("ﬁ", "&filig;");

            // "U+0FB02", "LATIN SMALL LIGATURE FL"
            txt = txt.Replace("ﬂ", "&fllig;");

            // "U+0FB03", "LATIN SMALL LIGATURE FFI"
            txt = txt.Replace("ﬃ", "&ffilig;");

            // "U+0FB04", "LATIN SMALL LIGATURE FFL"
            txt = txt.Replace("ﬄ", "&ffllig;");

            // "U+1D49C", "MATHEMATICAL SCRIPT CAPITAL A"
            txt = txt.Replace("𝒜", "&Ascr;");

            // "U+1D49E", "MATHEMATICAL SCRIPT CAPITAL C"
            txt = txt.Replace("𝒞", "&Cscr;");

            // "U+1D49F", "MATHEMATICAL SCRIPT CAPITAL D"
            txt = txt.Replace("𝒟", "&Dscr;");

            // "U+1D4A2", "MATHEMATICAL SCRIPT CAPITAL G"
            txt = txt.Replace("𝒢", "&Gscr;");

            // "U+1D4A5", "MATHEMATICAL SCRIPT CAPITAL J"
            txt = txt.Replace("𝒥", "&Jscr;");

            // "U+1D4A6", "MATHEMATICAL SCRIPT CAPITAL K"
            txt = txt.Replace("𝒦", "&Kscr;");

            // "U+1D4A9", "MATHEMATICAL SCRIPT CAPITAL N"
            txt = txt.Replace("𝒩", "&Nscr;");

            // "U+1D4AA", "MATHEMATICAL SCRIPT CAPITAL O"
            txt = txt.Replace("𝒪", "&Oscr;");

            // "U+1D4AB", "MATHEMATICAL SCRIPT CAPITAL P"
            txt = txt.Replace("𝒫", "&Pscr;");

            // "U+1D4AC", "MATHEMATICAL SCRIPT CAPITAL Q"
            txt = txt.Replace("𝒬", "&Qscr;");

            // "U+1D4AE", "MATHEMATICAL SCRIPT CAPITAL S"
            txt = txt.Replace("𝒮", "&Sscr;");

            // "U+1D4AF", "MATHEMATICAL SCRIPT CAPITAL T"
            txt = txt.Replace("𝒯", "&Tscr;");

            // "U+1D4B0", "MATHEMATICAL SCRIPT CAPITAL U"
            txt = txt.Replace("𝒰", "&Uscr;");

            // "U+1D4B1", "MATHEMATICAL SCRIPT CAPITAL V"
            txt = txt.Replace("𝒱", "&Vscr;");

            // "U+1D4B2", "MATHEMATICAL SCRIPT CAPITAL W"
            txt = txt.Replace("𝒲", "&Wscr;");

            // "U+1D4B3", "MATHEMATICAL SCRIPT CAPITAL X"
            txt = txt.Replace("𝒳", "&Xscr;");

            // "U+1D4B4", "MATHEMATICAL SCRIPT CAPITAL Y"
            txt = txt.Replace("𝒴", "&Yscr;");

            // "U+1D4B5", "MATHEMATICAL SCRIPT CAPITAL Z"
            txt = txt.Replace("𝒵", "&Zscr;");

            // "U+1D4B6", "MATHEMATICAL SCRIPT SMALL A"
            txt = txt.Replace("𝒶", "&ascr;");

            // "U+1D4B7", "MATHEMATICAL SCRIPT SMALL B"
            txt = txt.Replace("𝒷", "&bscr;");

            // "U+1D4B8", "MATHEMATICAL SCRIPT SMALL C"
            txt = txt.Replace("𝒸", "&cscr;");

            // "U+1D4B9", "MATHEMATICAL SCRIPT SMALL D"
            txt = txt.Replace("𝒹", "&dscr;");

            // "U+1D4BB", "MATHEMATICAL SCRIPT SMALL F"
            txt = txt.Replace("𝒻", "&fscr;");

            // "U+1D4BD", "MATHEMATICAL SCRIPT SMALL H"
            txt = txt.Replace("𝒽", "&hscr;");

            // "U+1D4BE", "MATHEMATICAL SCRIPT SMALL I"
            txt = txt.Replace("𝒾", "&iscr;");

            // "U+1D4BF", "MATHEMATICAL SCRIPT SMALL J"
            txt = txt.Replace("𝒿", "&jscr;");

            // "U+1D4C0", "MATHEMATICAL SCRIPT SMALL K"
            txt = txt.Replace("𝓀", "&kscr;");

            // "U+1D4C1", "MATHEMATICAL SCRIPT SMALL L"
            txt = txt.Replace("𝓁", "&lscr;");

            // "U+1D4C2", "MATHEMATICAL SCRIPT SMALL M"
            txt = txt.Replace("𝓂", "&mscr;");

            // "U+1D4C3", "MATHEMATICAL SCRIPT SMALL N"
            txt = txt.Replace("𝓃", "&nscr;");

            // "U+1D4C5", "MATHEMATICAL SCRIPT SMALL P"
            txt = txt.Replace("𝓅", "&pscr;");

            // "U+1D4C6", "MATHEMATICAL SCRIPT SMALL Q"
            txt = txt.Replace("𝓆", "&qscr;");

            // "U+1D4C7", "MATHEMATICAL SCRIPT SMALL R"
            txt = txt.Replace("𝓇", "&rscr;");

            // "U+1D4C8", "MATHEMATICAL SCRIPT SMALL S"
            txt = txt.Replace("𝓈", "&sscr;");

            // "U+1D4C9", "MATHEMATICAL SCRIPT SMALL T"
            txt = txt.Replace("𝓉", "&tscr;");

            // "U+1D4CA", "MATHEMATICAL SCRIPT SMALL U"
            txt = txt.Replace("𝓊", "&uscr;");

            // "U+1D4CB", "MATHEMATICAL SCRIPT SMALL V"
            txt = txt.Replace("𝓋", "&vscr;");

            // "U+1D4CC", "MATHEMATICAL SCRIPT SMALL W"
            txt = txt.Replace("𝓌", "&wscr;");

            // "U+1D4CD", "MATHEMATICAL SCRIPT SMALL X"
            txt = txt.Replace("𝓍", "&xscr;");

            // "U+1D4CE", "MATHEMATICAL SCRIPT SMALL Y"
            txt = txt.Replace("𝓎", "&yscr;");

            // "U+1D4CF", "MATHEMATICAL SCRIPT SMALL Z"
            txt = txt.Replace("𝓏", "&zscr;");

            // "U+1D504", "MATHEMATICAL FRAKTUR CAPITAL A"
            txt = txt.Replace("𝔄", "&Afr;");

            // "U+1D505", "MATHEMATICAL FRAKTUR CAPITAL B"
            txt = txt.Replace("𝔅", "&Bfr;");

            // "U+1D507", "MATHEMATICAL FRAKTUR CAPITAL D"
            txt = txt.Replace("𝔇", "&Dfr;");

            // "U+1D508", "MATHEMATICAL FRAKTUR CAPITAL E"
            txt = txt.Replace("𝔈", "&Efr;");

            // "U+1D509", "MATHEMATICAL FRAKTUR CAPITAL F"
            txt = txt.Replace("𝔉", "&Ffr;");

            // "U+1D50A", "MATHEMATICAL FRAKTUR CAPITAL G"
            txt = txt.Replace("𝔊", "&Gfr;");

            // "U+1D50D", "MATHEMATICAL FRAKTUR CAPITAL J"
            txt = txt.Replace("𝔍", "&Jfr;");

            // "U+1D50E", "MATHEMATICAL FRAKTUR CAPITAL K"
            txt = txt.Replace("𝔎", "&Kfr;");

            // "U+1D50F", "MATHEMATICAL FRAKTUR CAPITAL L"
            txt = txt.Replace("𝔏", "&Lfr;");

            // "U+1D510", "MATHEMATICAL FRAKTUR CAPITAL M"
            txt = txt.Replace("𝔐", "&Mfr;");

            // "U+1D511", "MATHEMATICAL FRAKTUR CAPITAL N"
            txt = txt.Replace("𝔑", "&Nfr;");

            // "U+1D512", "MATHEMATICAL FRAKTUR CAPITAL O"
            txt = txt.Replace("𝔒", "&Ofr;");

            // "U+1D513", "MATHEMATICAL FRAKTUR CAPITAL P"
            txt = txt.Replace("𝔓", "&Pfr;");

            // "U+1D514", "MATHEMATICAL FRAKTUR CAPITAL Q"
            txt = txt.Replace("𝔔", "&Qfr;");

            // "U+1D516", "MATHEMATICAL FRAKTUR CAPITAL S"
            txt = txt.Replace("𝔖", "&Sfr;");

            // "U+1D517", "MATHEMATICAL FRAKTUR CAPITAL T"
            txt = txt.Replace("𝔗", "&Tfr;");

            // "U+1D518", "MATHEMATICAL FRAKTUR CAPITAL U"
            txt = txt.Replace("𝔘", "&Ufr;");

            // "U+1D519", "MATHEMATICAL FRAKTUR CAPITAL V"
            txt = txt.Replace("𝔙", "&Vfr;");

            // "U+1D51A", "MATHEMATICAL FRAKTUR CAPITAL W"
            txt = txt.Replace("𝔚", "&Wfr;");

            // "U+1D51B", "MATHEMATICAL FRAKTUR CAPITAL X"
            txt = txt.Replace("𝔛", "&Xfr;");

            // "U+1D51C", "MATHEMATICAL FRAKTUR CAPITAL Y"
            txt = txt.Replace("𝔜", "&Yfr;");

            // "U+1D51E", "MATHEMATICAL FRAKTUR SMALL A"
            txt = txt.Replace("𝔞", "&afr;");

            // "U+1D51F", "MATHEMATICAL FRAKTUR SMALL B"
            txt = txt.Replace("𝔟", "&bfr;");

            // "U+1D520", "MATHEMATICAL FRAKTUR SMALL C"
            txt = txt.Replace("𝔠", "&cfr;");

            // "U+1D521", "MATHEMATICAL FRAKTUR SMALL D"
            txt = txt.Replace("𝔡", "&dfr;");

            // "U+1D522", "MATHEMATICAL FRAKTUR SMALL E"
            txt = txt.Replace("𝔢", "&efr;");

            // "U+1D523", "MATHEMATICAL FRAKTUR SMALL F"
            txt = txt.Replace("𝔣", "&ffr;");

            // "U+1D524", "MATHEMATICAL FRAKTUR SMALL G"
            txt = txt.Replace("𝔤", "&gfr;");

            // "U+1D525", "MATHEMATICAL FRAKTUR SMALL H"
            txt = txt.Replace("𝔥", "&hfr;");

            // "U+1D526", "MATHEMATICAL FRAKTUR SMALL I"
            txt = txt.Replace("𝔦", "&ifr;");

            // "U+1D527", "MATHEMATICAL FRAKTUR SMALL J"
            txt = txt.Replace("𝔧", "&jfr;");

            // "U+1D528", "MATHEMATICAL FRAKTUR SMALL K"
            txt = txt.Replace("𝔨", "&kfr;");

            // "U+1D529", "MATHEMATICAL FRAKTUR SMALL L"
            txt = txt.Replace("𝔩", "&lfr;");

            // "U+1D52A", "MATHEMATICAL FRAKTUR SMALL M"
            txt = txt.Replace("𝔪", "&mfr;");

            // "U+1D52B", "MATHEMATICAL FRAKTUR SMALL N"
            txt = txt.Replace("𝔫", "&nfr;");

            // "U+1D52C", "MATHEMATICAL FRAKTUR SMALL O"
            txt = txt.Replace("𝔬", "&ofr;");

            // "U+1D52D", "MATHEMATICAL FRAKTUR SMALL P"
            txt = txt.Replace("𝔭", "&pfr;");

            // "U+1D52E", "MATHEMATICAL FRAKTUR SMALL Q"
            txt = txt.Replace("𝔮", "&qfr;");

            // "U+1D52F", "MATHEMATICAL FRAKTUR SMALL R"
            txt = txt.Replace("𝔯", "&rfr;");

            // "U+1D530", "MATHEMATICAL FRAKTUR SMALL S"
            txt = txt.Replace("𝔰", "&sfr;");

            // "U+1D531", "MATHEMATICAL FRAKTUR SMALL T"
            txt = txt.Replace("𝔱", "&tfr;");

            // "U+1D532", "MATHEMATICAL FRAKTUR SMALL U"
            txt = txt.Replace("𝔲", "&ufr;");

            // "U+1D533", "MATHEMATICAL FRAKTUR SMALL V"
            txt = txt.Replace("𝔳", "&vfr;");

            // "U+1D534", "MATHEMATICAL FRAKTUR SMALL W"
            txt = txt.Replace("𝔴", "&wfr;");

            // "U+1D535", "MATHEMATICAL FRAKTUR SMALL X"
            txt = txt.Replace("𝔵", "&xfr;");

            // "U+1D536", "MATHEMATICAL FRAKTUR SMALL Y"
            txt = txt.Replace("𝔶", "&yfr;");

            // "U+1D537", "MATHEMATICAL FRAKTUR SMALL Z"
            txt = txt.Replace("𝔷", "&zfr;");

            // "U+1D538", "MATHEMATICAL DOUBLE-STRUCK CAPITAL A"
            txt = txt.Replace("𝔸", "&Aopf;");

            // "U+1D539", "MATHEMATICAL DOUBLE-STRUCK CAPITAL B"
            txt = txt.Replace("𝔹", "&Bopf;");

            // "U+1D53B", "MATHEMATICAL DOUBLE-STRUCK CAPITAL D"
            txt = txt.Replace("𝔻", "&Dopf;");

            // "U+1D53C", "MATHEMATICAL DOUBLE-STRUCK CAPITAL E"
            txt = txt.Replace("𝔼", "&Eopf;");

            // "U+1D53D", "MATHEMATICAL DOUBLE-STRUCK CAPITAL F"
            txt = txt.Replace("𝔽", "&Fopf;");

            // "U+1D53E", "MATHEMATICAL DOUBLE-STRUCK CAPITAL G"
            txt = txt.Replace("𝔾", "&Gopf;");

            // "U+1D540", "MATHEMATICAL DOUBLE-STRUCK CAPITAL I"
            txt = txt.Replace("𝕀", "&Iopf;");

            // "U+1D541", "MATHEMATICAL DOUBLE-STRUCK CAPITAL J"
            txt = txt.Replace("𝕁", "&Jopf;");

            // "U+1D542", "MATHEMATICAL DOUBLE-STRUCK CAPITAL K"
            txt = txt.Replace("𝕂", "&Kopf;");

            // "U+1D543", "MATHEMATICAL DOUBLE-STRUCK CAPITAL L"
            txt = txt.Replace("𝕃", "&Lopf;");

            // "U+1D544", "MATHEMATICAL DOUBLE-STRUCK CAPITAL M"
            txt = txt.Replace("𝕄", "&Mopf;");

            // "U+1D546", "MATHEMATICAL DOUBLE-STRUCK CAPITAL O"
            txt = txt.Replace("𝕆", "&Oopf;");

            // "U+1D54A", "MATHEMATICAL DOUBLE-STRUCK CAPITAL S"
            txt = txt.Replace("𝕊", "&Sopf;");

            // "U+1D54B", "MATHEMATICAL DOUBLE-STRUCK CAPITAL T"
            txt = txt.Replace("𝕋", "&Topf;");

            // "U+1D54C", "MATHEMATICAL DOUBLE-STRUCK CAPITAL U"
            txt = txt.Replace("𝕌", "&Uopf;");

            // "U+1D54D", "MATHEMATICAL DOUBLE-STRUCK CAPITAL V"
            txt = txt.Replace("𝕍", "&Vopf;");

            // "U+1D54E", "MATHEMATICAL DOUBLE-STRUCK CAPITAL W"
            txt = txt.Replace("𝕎", "&Wopf;");

            // "U+1D54F", "MATHEMATICAL DOUBLE-STRUCK CAPITAL X"
            txt = txt.Replace("𝕏", "&Xopf;");

            // "U+1D550", "MATHEMATICAL DOUBLE-STRUCK CAPITAL Y"
            txt = txt.Replace("𝕐", "&Yopf;");

            // "U+1D552", "MATHEMATICAL DOUBLE-STRUCK SMALL A"
            txt = txt.Replace("𝕒", "&aopf;");

            // "U+1D553", "MATHEMATICAL DOUBLE-STRUCK SMALL B"
            txt = txt.Replace("𝕓", "&bopf;");

            // "U+1D554", "MATHEMATICAL DOUBLE-STRUCK SMALL C"
            txt = txt.Replace("𝕔", "&copf;");

            // "U+1D555", "MATHEMATICAL DOUBLE-STRUCK SMALL D"
            txt = txt.Replace("𝕕", "&dopf;");

            // "U+1D556", "MATHEMATICAL DOUBLE-STRUCK SMALL E"
            txt = txt.Replace("𝕖", "&eopf;");

            // "U+1D557", "MATHEMATICAL DOUBLE-STRUCK SMALL F"
            txt = txt.Replace("𝕗", "&fopf;");

            // "U+1D558", "MATHEMATICAL DOUBLE-STRUCK SMALL G"
            txt = txt.Replace("𝕘", "&gopf;");

            // "U+1D559", "MATHEMATICAL DOUBLE-STRUCK SMALL H"
            txt = txt.Replace("𝕙", "&hopf;");

            // "U+1D55A", "MATHEMATICAL DOUBLE-STRUCK SMALL I"
            txt = txt.Replace("𝕚", "&iopf;");

            // "U+1D55B", "MATHEMATICAL DOUBLE-STRUCK SMALL J"
            txt = txt.Replace("𝕛", "&jopf;");

            // "U+1D55C", "MATHEMATICAL DOUBLE-STRUCK SMALL K"
            txt = txt.Replace("𝕜", "&kopf;");

            // "U+1D55D", "MATHEMATICAL DOUBLE-STRUCK SMALL L"
            txt = txt.Replace("𝕝", "&lopf;");

            // "U+1D55E", "MATHEMATICAL DOUBLE-STRUCK SMALL M"
            txt = txt.Replace("𝕞", "&mopf;");

            // "U+1D55F", "MATHEMATICAL DOUBLE-STRUCK SMALL N"
            txt = txt.Replace("𝕟", "&nopf;");

            // "U+1D560", "MATHEMATICAL DOUBLE-STRUCK SMALL O"
            txt = txt.Replace("𝕠", "&oopf;");

            // "U+1D561", "MATHEMATICAL DOUBLE-STRUCK SMALL P"
            txt = txt.Replace("𝕡", "&popf;");

            // "U+1D562", "MATHEMATICAL DOUBLE-STRUCK SMALL Q"
            txt = txt.Replace("𝕢", "&qopf;");

            // "U+1D563", "MATHEMATICAL DOUBLE-STRUCK SMALL R"
            txt = txt.Replace("𝕣", "&ropf;");

            // "U+1D564", "MATHEMATICAL DOUBLE-STRUCK SMALL S"
            txt = txt.Replace("𝕤", "&sopf;");

            // "U+1D565", "MATHEMATICAL DOUBLE-STRUCK SMALL T"
            txt = txt.Replace("𝕥", "&topf;");

            // "U+1D566", "MATHEMATICAL DOUBLE-STRUCK SMALL U"
            txt = txt.Replace("𝕦", "&uopf;");

            // "U+1D567", "MATHEMATICAL DOUBLE-STRUCK SMALL V"
            txt = txt.Replace("𝕧", "&vopf;");

            // "U+1D568", "MATHEMATICAL DOUBLE-STRUCK SMALL W"
            txt = txt.Replace("𝕨", "&wopf;");

            // "U+1D569", "MATHEMATICAL DOUBLE-STRUCK SMALL X"
            txt = txt.Replace("𝕩", "&xopf;");

            // "U+1D56A", "MATHEMATICAL DOUBLE-STRUCK SMALL Y"
            txt = txt.Replace("𝕪", "&yopf;");

            // "U+1D56B", "MATHEMATICAL DOUBLE-STRUCK SMALL Z"
            txt = txt.Replace("𝕫", "&zopf;");

            return txt.ToString();
        }

        /// <summary>
        /// 入力される文字列内の文字や記号を文字実体参照に置きかえます。
        /// </summary>
        /// <param name="sources">置きかえられる文字列の配列。</param>
        /// <param name="escapeSequenceFlag">エスケープシーケンスを置きかえるフラグ。</param>
        /// <returns>置きかえられた文字列の配列。</returns>
        static public string[] ConvertTo(string[] sources, bool escapeSequenceFlag)
        {
            for (int i = 0; i < sources.Length; i++)
            {
                sources[i] = ConvertTo(sources[i], escapeSequenceFlag);
            }

            return sources;
        }
    }
}
