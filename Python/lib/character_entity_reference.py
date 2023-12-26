import re
from typing import List


class CharacterEntityReference:
    """
    入力される文字列内の文字実体参照を文字や記号に置きかえます。ベーシック版です。
    :param source: 置きかえられる文字列。
    :return: 置きかえられた文字列。
    """

    @staticmethod
    def convert_from_basic(source: str) -> str:
        txt = source

        # "U+00022", "QUOTATION MARK"
        txt = re.sub(r"&#x0*?22;", '"', txt)
        txt = re.sub(r"&#0*?34;", '"', txt)
        txt = re.sub(r"&quot;", '"', txt)
        txt = re.sub(r"&QUOT;", '"', txt)

        # "U+00026", "AMPERSAND"
        txt = re.sub(r"&#x0*?26;", "&", txt)
        txt = re.sub(r"&#0*?38;", "&", txt)
        txt = re.sub(r"&amp;", "&", txt)
        txt = re.sub(r"&AMP;", "&", txt)

        # "U+00027", "APOSTROPHE"
        txt = re.sub(r"&#x0*?27;", "'", txt)
        txt = re.sub(r"&#0*?39;", "'", txt)
        txt = re.sub(r"&apos;", "'", txt)

        # "U+0003C", "LESS-THAN SIGN"
        txt = re.sub(r"&#x0*?3C;", "<", txt)
        txt = re.sub(r"&#0*?60;", "<", txt)
        txt = re.sub(r"&lt;", "<", txt)
        txt = re.sub(r"&LT;", "<", txt)

        # "U+0003E", "GREATER-THAN SIGN"
        txt = re.sub(r"&#x0*?3E;", ">", txt)
        txt = re.sub(r"&#0*?62;", ">", txt)
        txt = re.sub(r"&gt;", ">", txt)
        txt = re.sub(r"&GT;", ">", txt)

        # "U+000A0", "NO-BREAK SPACE"
        txt = re.sub(r"&#x0*?A0;", " ", txt)
        txt = re.sub(r"&#0*?160;", " ", txt)
        txt = re.sub(r"&nbsp;", " ", txt)
        txt = re.sub(r"&NonBreakingSpace;", " ", txt)

        # "U+000A1", "INVERTED EXCLAMATION MARK"
        txt = re.sub(r"&#x0*?A1;", "¡", txt)
        txt = re.sub(r"&#0*?161;", "¡", txt)
        txt = re.sub(r"&iexcl;", "¡", txt)

        # "U+000A2", "CENT SIGN"
        txt = re.sub(r"&#x0*?A2;", "¢", txt)
        txt = re.sub(r"&#0*?162;", "¢", txt)
        txt = re.sub(r"&cent;", "¢", txt)

        # "U+000A3", "POUND SIGN"
        txt = re.sub(r"&#x0*?A3;", "£", txt)
        txt = re.sub(r"&#0*?163;", "£", txt)
        txt = re.sub(r"&pound;", "£", txt)

        # "U+000A4", "CURRENCY SIGN"
        txt = re.sub(r"&#x0*?A4;", "¤", txt)
        txt = re.sub(r"&#0*?164;", "¤", txt)
        txt = re.sub(r"&curren;", "¤", txt)

        # "U+000A5", "YEN SIGN"
        txt = re.sub(r"&#x0*?A5;", "¥", txt)
        txt = re.sub(r"&#0*?165;", "¥", txt)
        txt = re.sub(r"&yen;", "¥", txt)

        # "U+000A6", "BROKEN BAR"
        txt = re.sub(r"&#x0*?A6;", "¦", txt)
        txt = re.sub(r"&#0*?166;", "¦", txt)
        txt = re.sub(r"&brvbar;", "¦", txt)

        # "U+000A7", "SECTION SIGN"
        txt = re.sub(r"&#x0*?A7;", "§", txt)
        txt = re.sub(r"&#0*?167;", "§", txt)
        txt = re.sub(r"&sect;", "§", txt)

        # "U+000A8", "DIAERESIS"
        txt = re.sub(r"&#x0*?A8;", "¨", txt)
        txt = re.sub(r"&#0*?168;", "¨", txt)
        txt = re.sub(r"&Dot;", "¨", txt)
        txt = re.sub(r"&die;", "¨", txt)
        txt = re.sub(r"&DoubleDot;", "¨", txt)
        txt = re.sub(r"&uml;", "¨", txt)

        # "U+000A9", "COPYRIGHT SIGN"
        txt = re.sub(r"&#x0*?A9;", "©", txt)
        txt = re.sub(r"&#0*?169;", "©", txt)
        txt = re.sub(r"&copy;", "©", txt)
        txt = re.sub(r"&COPY;", "©", txt)

        # "U+000AA", "FEMININE ORDINAL INDICATOR"
        txt = re.sub(r"&#x0*?AA;", "ª", txt)
        txt = re.sub(r"&#0*?170;", "ª", txt)
        txt = re.sub(r"&ordf;", "ª", txt)

        # "U+000AB", "LEFT-POINTING DOUBLE ANGLE QUOTATION MARK"
        txt = re.sub(r"&#x0*?AB;", "«", txt)
        txt = re.sub(r"&#0*?171;", "«", txt)
        txt = re.sub(r"&laquo;", "«", txt)

        # "U+000AC", "NOT SIGN"
        txt = re.sub(r"&#x0*?AC;", "¬", txt)
        txt = re.sub(r"&#0*?172;", "¬", txt)
        txt = re.sub(r"&not;", "¬", txt)

        # "U+000AD", "SOFT HYPHEN"
        txt = re.sub(r"&#x0*?AD;", "­", txt)
        txt = re.sub(r"&#0*?173;", "­", txt)
        txt = re.sub(r"&shy;", "­", txt)

        # "U+000AE", "REGISTERED SIGN"
        txt = re.sub(r"&#x0*?AE;", "®", txt)
        txt = re.sub(r"&#0*?174;", "®", txt)
        txt = re.sub(r"&reg;", "®", txt)
        txt = re.sub(r"&circledR;", "®", txt)
        txt = re.sub(r"&REG;", "®", txt)

        # "U+000AF", "MACRON"
        txt = re.sub(r"&#x0*?AF;", "¯", txt)
        txt = re.sub(r"&#0*?175;", "¯", txt)
        txt = re.sub(r"&macr;", "¯", txt)
        txt = re.sub(r"&OverBar;", "¯", txt)
        txt = re.sub(r"&strns;", "¯", txt)

        # "U+000B0", "DEGREE SIGN"
        txt = re.sub(r"&#x0*?B0;", "°", txt)
        txt = re.sub(r"&#0*?176;", "°", txt)
        txt = re.sub(r"&deg;", "°", txt)

        # "U+000B1", "PLUS-MINUS SIGN"
        txt = re.sub(r"&#x0*?B1;", "±", txt)
        txt = re.sub(r"&#0*?177;", "±", txt)
        txt = re.sub(r"&plusmn;", "±", txt)
        txt = re.sub(r"&pm;", "±", txt)
        txt = re.sub(r"&PlusMinus;", "±", txt)

        # "U+000B2", "SUPERSCRIPT TWO"
        txt = re.sub(r"&#x0*?B2;", "²", txt)
        txt = re.sub(r"&#0*?178;", "²", txt)
        txt = re.sub(r"&sup2;", "²", txt)

        # "U+000B3", "SUPERSCRIPT THREE"
        txt = re.sub(r"&#x0*?B3;", "³", txt)
        txt = re.sub(r"&#0*?179;", "³", txt)
        txt = re.sub(r"&sup3;", "³", txt)

        # "U+000B4", "ACUTE ACCENT"
        txt = re.sub(r"&#x0*?B4;", "´", txt)
        txt = re.sub(r"&#0*?180;", "´", txt)
        txt = re.sub(r"&acute;", "´", txt)
        txt = re.sub(r"&DiacriticalAcute;", "´", txt)

        # "U+000B5", "MICRO SIGN"
        txt = re.sub(r"&#x0*?B5;", "µ", txt)
        txt = re.sub(r"&#0*?181;", "µ", txt)
        txt = re.sub(r"&micro;", "µ", txt)

        # "U+000B6", "PILCROW SIGN"
        txt = re.sub(r"&#x0*?B6;", "¶", txt)
        txt = re.sub(r"&#0*?182;", "¶", txt)
        txt = re.sub(r"&para;", "¶", txt)

        # "U+000B7", "MIDDLE DOT"
        txt = re.sub(r"&#x0*?B7;", "·", txt)
        txt = re.sub(r"&#0*?183;", "·", txt)
        txt = re.sub(r"&middot;", "·", txt)
        txt = re.sub(r"&centerdot;", "·", txt)
        txt = re.sub(r"&CenterDot;", "·", txt)

        # "U+000B8", "CEDILLA"
        txt = re.sub(r"&#x0*?B8;", "¸", txt)
        txt = re.sub(r"&#0*?184;", "¸", txt)
        txt = re.sub(r"&cedil;", "¸", txt)
        txt = re.sub(r"&Cedilla;", "¸", txt)

        # "U+000B9", "SUPERSCRIPT ONE"
        txt = re.sub(r"&#x0*?B9;", "¹", txt)
        txt = re.sub(r"&#0*?185;", "¹", txt)
        txt = re.sub(r"&sup1;", "¹", txt)

        # "U+000BA", "MASCULINE ORDINAL INDICATOR"
        txt = re.sub(r"&#x0*?BA;", "º", txt)
        txt = re.sub(r"&#0*?186;", "º", txt)
        txt = re.sub(r"&ordm;", "º", txt)

        # "U+000BB", "RIGHT-POINTING DOUBLE ANGLE QUOTATION MARK"
        txt = re.sub(r"&#x0*?BB;", "»", txt)
        txt = re.sub(r"&#0*?187;", "»", txt)
        txt = re.sub(r"&raquo;", "»", txt)

        # "U+000BC", "VULGAR FRACTION ONE QUARTER"
        txt = re.sub(r"&#x0*?BC;", "¼", txt)
        txt = re.sub(r"&#0*?188;", "¼", txt)
        txt = re.sub(r"&frac14;", "¼", txt)

        # "U+000BD", "VULGAR FRACTION ONE HALF"
        txt = re.sub(r"&#x0*?BD;", "½", txt)
        txt = re.sub(r"&#0*?189;", "½", txt)
        txt = re.sub(r"&frac12;", "½", txt)
        txt = re.sub(r"&half;", "½", txt)

        # "U+000BE", "VULGAR FRACTION THREE QUARTERS"
        txt = re.sub(r"&#x0*?BE;", "¾", txt)
        txt = re.sub(r"&#0*?190;", "¾", txt)
        txt = re.sub(r"&frac34;", "¾", txt)

        # "U+000BF", "INVERTED QUESTION MARK"
        txt = re.sub(r"&#x0*?BF;", "¿", txt)
        txt = re.sub(r"&#0*?191;", "¿", txt)
        txt = re.sub(r"&iquest;", "¿", txt)

        # "U+000C0", "LATIN CAPITAL LETTER A WITH GRAVE"
        txt = re.sub(r"&#x0*?C0;", "À", txt)
        txt = re.sub(r"&#0*?192;", "À", txt)
        txt = re.sub(r"&Agrave;", "À", txt)

        # "U+000C1", "LATIN CAPITAL LETTER A WITH ACUTE"
        txt = re.sub(r"&#x0*?C1;", "Á", txt)
        txt = re.sub(r"&#0*?193;", "Á", txt)
        txt = re.sub(r"&Aacute;", "Á", txt)

        # "U+000C2", "LATIN CAPITAL LETTER A WITH CIRCUMFLEX"
        txt = re.sub(r"&#x0*?C2;", "Â", txt)
        txt = re.sub(r"&#0*?194;", "Â", txt)
        txt = re.sub(r"&Acirc;", "Â", txt)

        # "U+000C3", "LATIN CAPITAL LETTER A WITH TILDE"
        txt = re.sub(r"&#x0*?C3;", "Ã", txt)
        txt = re.sub(r"&#0*?195;", "Ã", txt)
        txt = re.sub(r"&Atilde;", "Ã", txt)

        # "U+000C4", "LATIN CAPITAL LETTER A WITH DIAERESIS"
        txt = re.sub(r"&#x0*?C4;", "Ä", txt)
        txt = re.sub(r"&#0*?196;", "Ä", txt)
        txt = re.sub(r"&Auml;", "Ä", txt)

        # "U+000C5", "LATIN CAPITAL LETTER A WITH RING ABOVE"
        txt = re.sub(r"&#x0*?C5;", "Å", txt)
        txt = re.sub(r"&#0*?197;", "Å", txt)
        txt = re.sub(r"&Aring;", "Å", txt)

        # "U+000C6", "LATIN CAPITAL LETTER AE"
        txt = re.sub(r"&#x0*?C6;", "Æ", txt)
        txt = re.sub(r"&#0*?198;", "Æ", txt)
        txt = re.sub(r"&AElig;", "Æ", txt)

        # "U+000C7", "LATIN CAPITAL LETTER C WITH CEDILLA"
        txt = re.sub(r"&#x0*?C7;", "Ç", txt)
        txt = re.sub(r"&#0*?199;", "Ç", txt)
        txt = re.sub(r"&Ccedil;", "Ç", txt)

        # "U+000C8", "LATIN CAPITAL LETTER E WITH GRAVE"
        txt = re.sub(r"&#x0*?C8;", "È", txt)
        txt = re.sub(r"&#0*?200;", "È", txt)
        txt = re.sub(r"&Egrave;", "È", txt)

        # "U+000C9", "LATIN CAPITAL LETTER E WITH ACUTE"
        txt = re.sub(r"&#x0*?C9;", "É", txt)
        txt = re.sub(r"&#0*?201;", "É", txt)
        txt = re.sub(r"&Eacute;", "É", txt)

        # "U+000CA", "LATIN CAPITAL LETTER E WITH CIRCUMFLEX"
        txt = re.sub(r"&#x0*?CA;", "Ê", txt)
        txt = re.sub(r"&#0*?202;", "Ê", txt)
        txt = re.sub(r"&Ecirc;", "Ê", txt)

        # "U+000CB", "LATIN CAPITAL LETTER E WITH DIAERESIS"
        txt = re.sub(r"&#x0*?CB;", "Ë", txt)
        txt = re.sub(r"&#0*?203;", "Ë", txt)
        txt = re.sub(r"&Euml;", "Ë", txt)

        # "U+000CC", "LATIN CAPITAL LETTER I WITH GRAVE"
        txt = re.sub(r"&#x0*?CC;", "Ì", txt)
        txt = re.sub(r"&#0*?204;", "Ì", txt)
        txt = re.sub(r"&Igrave;", "Ì", txt)

        # "U+000CD", "LATIN CAPITAL LETTER I WITH ACUTE"
        txt = re.sub(r"&#x0*?CD;", "Í", txt)
        txt = re.sub(r"&#0*?205;", "Í", txt)
        txt = re.sub(r"&Iacute;", "Í", txt)

        # "U+000CE", "LATIN CAPITAL LETTER I WITH CIRCUMFLEX"
        txt = re.sub(r"&#x0*?CE;", "Î", txt)
        txt = re.sub(r"&#0*?206;", "Î", txt)
        txt = re.sub(r"&Icirc;", "Î", txt)

        # "U+000CF", "LATIN CAPITAL LETTER I WITH DIAERESIS"
        txt = re.sub(r"&#x0*?CF;", "Ï", txt)
        txt = re.sub(r"&#0*?207;", "Ï", txt)
        txt = re.sub(r"&Iuml;", "Ï", txt)

        # "U+000D0", "LATIN CAPITAL LETTER ETH"
        txt = re.sub(r"&#x0*?D0;", "Ð", txt)
        txt = re.sub(r"&#0*?208;", "Ð", txt)
        txt = re.sub(r"&ETH;", "Ð", txt)

        # "U+000D1", "LATIN CAPITAL LETTER N WITH TILDE"
        txt = re.sub(r"&#x0*?D1;", "Ñ", txt)
        txt = re.sub(r"&#0*?209;", "Ñ", txt)
        txt = re.sub(r"&Ntilde;", "Ñ", txt)

        # "U+000D2", "LATIN CAPITAL LETTER O WITH GRAVE"
        txt = re.sub(r"&#x0*?D2;", "Ò", txt)
        txt = re.sub(r"&#0*?210;", "Ò", txt)
        txt = re.sub(r"&Ograve;", "Ò", txt)

        # "U+000D3", "LATIN CAPITAL LETTER O WITH ACUTE"
        txt = re.sub(r"&#x0*?D3;", "Ó", txt)
        txt = re.sub(r"&#0*?211;", "Ó", txt)
        txt = re.sub(r"&Oacute;", "Ó", txt)

        # "U+000D4", "LATIN CAPITAL LETTER O WITH CIRCUMFLEX"
        txt = re.sub(r"&#x0*?D4;", "Ô", txt)
        txt = re.sub(r"&#0*?212;", "Ô", txt)
        txt = re.sub(r"&Ocirc;", "Ô", txt)

        # "U+000D5", "LATIN CAPITAL LETTER O WITH TILDE"
        txt = re.sub(r"&#x0*?D5;", "Õ", txt)
        txt = re.sub(r"&#0*?213;", "Õ", txt)
        txt = re.sub(r"&Otilde;", "Õ", txt)

        # "U+000D6", "LATIN CAPITAL LETTER O WITH DIAERESIS"
        txt = re.sub(r"&#x0*?D6;", "Ö", txt)
        txt = re.sub(r"&#0*?214;", "Ö", txt)
        txt = re.sub(r"&Ouml;", "Ö", txt)

        # "U+000D7", "MULTIPLICATION SIGN"
        txt = re.sub(r"&#x0*?D7;", "×", txt)
        txt = re.sub(r"&#0*?215;", "×", txt)
        txt = re.sub(r"&times;", "×", txt)

        # "U+000D8", "LATIN CAPITAL LETTER O WITH STROKE"
        txt = re.sub(r"&#x0*?D8;", "Ø", txt)
        txt = re.sub(r"&#0*?216;", "Ø", txt)
        txt = re.sub(r"&Oslash;", "Ø", txt)

        # "U+000D9", "LATIN CAPITAL LETTER U WITH GRAVE"
        txt = re.sub(r"&#x0*?D9;", "Ù", txt)
        txt = re.sub(r"&#0*?217;", "Ù", txt)
        txt = re.sub(r"&Ugrave;", "Ù", txt)

        # "U+000DA", "LATIN CAPITAL LETTER U WITH ACUTE"
        txt = re.sub(r"&#x0*?DA;", "Ú", txt)
        txt = re.sub(r"&#0*?218;", "Ú", txt)
        txt = re.sub(r"&Uacute;", "Ú", txt)

        # "U+000DB", "LATIN CAPITAL LETTER U WITH CIRCUMFLEX"
        txt = re.sub(r"&#x0*?DB;", "Û", txt)
        txt = re.sub(r"&#0*?219;", "Û", txt)
        txt = re.sub(r"&Ucirc;", "Û", txt)

        # "U+000DC", "LATIN CAPITAL LETTER U WITH DIAERESIS"
        txt = re.sub(r"&#x0*?DC;", "Ü", txt)
        txt = re.sub(r"&#0*?220;", "Ü", txt)
        txt = re.sub(r"&Uuml;", "Ü", txt)

        # "U+000DD", "LATIN CAPITAL LETTER Y WITH ACUTE"
        txt = re.sub(r"&#x0*?DD;", "Ý", txt)
        txt = re.sub(r"&#0*?221;", "Ý", txt)
        txt = re.sub(r"&Yacute;", "Ý", txt)

        # "U+000DE", "LATIN CAPITAL LETTER THORN"
        txt = re.sub(r"&#x0*?DE;", "Þ", txt)
        txt = re.sub(r"&#0*?222;", "Þ", txt)
        txt = re.sub(r"&THORN;", "Þ", txt)

        # "U+000DF", "LATIN SMALL LETTER SHARP S"
        txt = re.sub(r"&#x0*?DF;", "ß", txt)
        txt = re.sub(r"&#0*?223;", "ß", txt)
        txt = re.sub(r"&szlig;", "ß", txt)

        # "U+000E0", "LATIN SMALL LETTER A WITH GRAVE"
        txt = re.sub(r"&#x0*?E0;", "à", txt)
        txt = re.sub(r"&#0*?224;", "à", txt)
        txt = re.sub(r"&agrave;", "à", txt)

        # "U+000E1", "LATIN SMALL LETTER A WITH ACUTE"
        txt = re.sub(r"&#x0*?E1;", "á", txt)
        txt = re.sub(r"&#0*?225;", "á", txt)
        txt = re.sub(r"&aacute;", "á", txt)

        # "U+000E2", "LATIN SMALL LETTER A WITH CIRCUMFLEX"
        txt = re.sub(r"&#x0*?E2;", "â", txt)
        txt = re.sub(r"&#0*?226;", "â", txt)
        txt = re.sub(r"&acirc;", "â", txt)

        # "U+000E3", "LATIN SMALL LETTER A WITH TILDE"
        txt = re.sub(r"&#x0*?E3;", "ã", txt)
        txt = re.sub(r"&#0*?227;", "ã", txt)
        txt = re.sub(r"&atilde;", "ã", txt)

        # "U+000E4", "LATIN SMALL LETTER A WITH DIAERESIS"
        txt = re.sub(r"&#x0*?E4;", "ä", txt)
        txt = re.sub(r"&#0*?228;", "ä", txt)
        txt = re.sub(r"&auml;", "ä", txt)

        # "U+000E5", "LATIN SMALL LETTER A WITH RING ABOVE"
        txt = re.sub(r"&#x0*?E5;", "å", txt)
        txt = re.sub(r"&#0*?229;", "å", txt)
        txt = re.sub(r"&aring;", "å", txt)

        # "U+000E6", "LATIN SMALL LETTER AE"
        txt = re.sub(r"&#x0*?E6;", "æ", txt)
        txt = re.sub(r"&#0*?230;", "æ", txt)
        txt = re.sub(r"&aelig;", "æ", txt)

        # "U+000E7", "LATIN SMALL LETTER C WITH CEDILLA"
        txt = re.sub(r"&#x0*?E7;", "ç", txt)
        txt = re.sub(r"&#0*?231;", "ç", txt)
        txt = re.sub(r"&ccedil;", "ç", txt)

        # "U+000E8", "LATIN SMALL LETTER E WITH GRAVE"
        txt = re.sub(r"&#x0*?E8;", "è", txt)
        txt = re.sub(r"&#0*?232;", "è", txt)
        txt = re.sub(r"&egrave;", "è", txt)

        # "U+000E9", "LATIN SMALL LETTER E WITH ACUTE"
        txt = re.sub(r"&#x0*?E9;", "é", txt)
        txt = re.sub(r"&#0*?233;", "é", txt)
        txt = re.sub(r"&eacute;", "é", txt)

        # "U+000EA", "LATIN SMALL LETTER E WITH CIRCUMFLEX"
        txt = re.sub(r"&#x0*?EA;", "ê", txt)
        txt = re.sub(r"&#0*?234;", "ê", txt)
        txt = re.sub(r"&ecirc;", "ê", txt)

        # "U+000EB", "LATIN SMALL LETTER E WITH DIAERESIS"
        txt = re.sub(r"&#x0*?EB;", "ë", txt)
        txt = re.sub(r"&#0*?235;", "ë", txt)
        txt = re.sub(r"&euml;", "ë", txt)

        # "U+000EC", "LATIN SMALL LETTER I WITH GRAVE"
        txt = re.sub(r"&#x0*?EC;", "ì", txt)
        txt = re.sub(r"&#0*?236;", "ì", txt)
        txt = re.sub(r"&igrave;", "ì", txt)

        # "U+000ED", "LATIN SMALL LETTER I WITH ACUTE"
        txt = re.sub(r"&#x0*?ED;", "í", txt)
        txt = re.sub(r"&#0*?237;", "í", txt)
        txt = re.sub(r"&iacute;", "í", txt)

        # "U+000EE", "LATIN SMALL LETTER I WITH CIRCUMFLEX"
        txt = re.sub(r"&#x0*?EE;", "î", txt)
        txt = re.sub(r"&#0*?238;", "î", txt)
        txt = re.sub(r"&icirc;", "î", txt)

        # "U+000EF", "LATIN SMALL LETTER I WITH DIAERESIS"
        txt = re.sub(r"&#x0*?EF;", "ï", txt)
        txt = re.sub(r"&#0*?239;", "ï", txt)
        txt = re.sub(r"&iuml;", "ï", txt)

        # "U+000F0", "LATIN SMALL LETTER ETH"
        txt = re.sub(r"&#x0*?F0;", "ð", txt)
        txt = re.sub(r"&#0*?240;", "ð", txt)
        txt = re.sub(r"&eth;", "ð", txt)

        # "U+000F1", "LATIN SMALL LETTER N WITH TILDE"
        txt = re.sub(r"&#x0*?F1;", "ñ", txt)
        txt = re.sub(r"&#0*?241;", "ñ", txt)
        txt = re.sub(r"&ntilde;", "ñ", txt)

        # "U+000F2", "LATIN SMALL LETTER O WITH GRAVE"
        txt = re.sub(r"&#x0*?F2;", "ò", txt)
        txt = re.sub(r"&#0*?242;", "ò", txt)
        txt = re.sub(r"&ograve;", "ò", txt)

        # "U+000F3", "LATIN SMALL LETTER O WITH ACUTE"
        txt = re.sub(r"&#x0*?F3;", "ó", txt)
        txt = re.sub(r"&#0*?243;", "ó", txt)
        txt = re.sub(r"&oacute;", "ó", txt)

        # "U+000F4", "LATIN SMALL LETTER O WITH CIRCUMFLEX"
        txt = re.sub(r"&#x0*?F4;", "ô", txt)
        txt = re.sub(r"&#0*?244;", "ô", txt)
        txt = re.sub(r"&ocirc;", "ô", txt)

        # "U+000F5", "LATIN SMALL LETTER O WITH TILDE"
        txt = re.sub(r"&#x0*?F5;", "õ", txt)
        txt = re.sub(r"&#0*?245;", "õ", txt)
        txt = re.sub(r"&otilde;", "õ", txt)

        # "U+000F6", "LATIN SMALL LETTER O WITH DIAERESIS"
        txt = re.sub(r"&#x0*?F6;", "ö", txt)
        txt = re.sub(r"&#0*?246;", "ö", txt)
        txt = re.sub(r"&ouml;", "ö", txt)

        # "U+000F7", "DIVISION SIGN"
        txt = re.sub(r"&#x0*?F7;", "÷", txt)
        txt = re.sub(r"&#0*?247;", "÷", txt)
        txt = re.sub(r"&divide;", "÷", txt)
        txt = re.sub(r"&div;", "÷", txt)

        # "U+000F8", "LATIN SMALL LETTER O WITH STROKE"
        txt = re.sub(r"&#x0*?F8;", "ø", txt)
        txt = re.sub(r"&#0*?248;", "ø", txt)
        txt = re.sub(r"&oslash;", "ø", txt)

        # "U+000F9", "LATIN SMALL LETTER U WITH GRAVE"
        txt = re.sub(r"&#x0*?F9;", "ù", txt)
        txt = re.sub(r"&#0*?249;", "ù", txt)
        txt = re.sub(r"&ugrave;", "ù", txt)

        # "U+000FA", "LATIN SMALL LETTER U WITH ACUTE"
        txt = re.sub(r"&#x0*?FA;", "ú", txt)
        txt = re.sub(r"&#0*?250;", "ú", txt)
        txt = re.sub(r"&uacute;", "ú", txt)

        # "U+000FB", "LATIN SMALL LETTER U WITH CIRCUMFLEX"
        txt = re.sub(r"&#x0*?FB;", "û", txt)
        txt = re.sub(r"&#0*?251;", "û", txt)
        txt = re.sub(r"&ucirc;", "û", txt)

        # "U+000FC", "LATIN SMALL LETTER U WITH DIAERESIS"
        txt = re.sub(r"&#x0*?FC;", "ü", txt)
        txt = re.sub(r"&#0*?252;", "ü", txt)
        txt = re.sub(r"&uuml;", "ü", txt)

        # "U+000FD", "LATIN SMALL LETTER Y WITH ACUTE"
        txt = re.sub(r"&#x0*?FD;", "ý", txt)
        txt = re.sub(r"&#0*?253;", "ý", txt)
        txt = re.sub(r"&yacute;", "ý", txt)

        # "U+000FE", "LATIN SMALL LETTER THORN"
        txt = re.sub(r"&#x0*?FE;", "þ", txt)
        txt = re.sub(r"&#0*?254;", "þ", txt)
        txt = re.sub(r"&thorn;", "þ", txt)

        # "U+000FF", "LATIN SMALL LETTER Y WITH DIAERESIS"
        txt = re.sub(r"&#x0*?FF;", "ÿ", txt)
        txt = re.sub(r"&#0*?255;", "ÿ", txt)
        txt = re.sub(r"&yuml;", "ÿ", txt)

        # "U+00152", "LATIN CAPITAL LIGATURE OE"
        txt = re.sub(r"&#x0*?152;", "Œ", txt)
        txt = re.sub(r"&#0*?338;", "Œ", txt)
        txt = re.sub(r"&OElig;", "Œ", txt)

        # "U+00153", "LATIN SMALL LIGATURE OE"
        txt = re.sub(r"&#x0*?153;", "œ", txt)
        txt = re.sub(r"&#0*?339;", "œ", txt)
        txt = re.sub(r"&oelig;", "œ", txt)

        # "U+00160", "LATIN CAPITAL LETTER S WITH CARON"
        txt = re.sub(r"&#x0*?160;", "Š", txt)
        txt = re.sub(r"&#0*?352;", "Š", txt)
        txt = re.sub(r"&Scaron;", "Š", txt)

        # "U+00161", "LATIN SMALL LETTER S WITH CARON"
        txt = re.sub(r"&#x0*?161;", "š", txt)
        txt = re.sub(r"&#0*?353;", "š", txt)
        txt = re.sub(r"&scaron;", "š", txt)

        # "U+00178", "LATIN CAPITAL LETTER Y WITH DIAERESIS"
        txt = re.sub(r"&#x0*?178;", "Ÿ", txt)
        txt = re.sub(r"&#0*?376;", "Ÿ", txt)
        txt = re.sub(r"&Yuml;", "Ÿ", txt)

        # "U+00192", "LATIN SMALL LETTER F WITH HOOK"
        txt = re.sub(r"&#x0*?192;", "ƒ", txt)
        txt = re.sub(r"&#0*?402;", "ƒ", txt)
        txt = re.sub(r"&fnof;", "ƒ", txt)

        # "U+002C6", "MODIFIER LETTER CIRCUMFLEX ACCENT"
        txt = re.sub(r"&#x0*?2C6;", "ˆ", txt)
        txt = re.sub(r"&#0*?710;", "ˆ", txt)
        txt = re.sub(r"&circ;", "ˆ", txt)

        # "U+002DC", "SMALL TILDE"
        txt = re.sub(r"&#x0*?2DC;", "˜", txt)
        txt = re.sub(r"&#0*?732;", "˜", txt)
        txt = re.sub(r"&tilde;", "˜", txt)
        txt = re.sub(r"&DiacriticalTilde;", "˜", txt)

        # "U+00391", "GREEK CAPITAL LETTER ALPHA"
        txt = re.sub(r"&#x0*?391;", "Α", txt)
        txt = re.sub(r"&#0*?913;", "Α", txt)
        txt = re.sub(r"&Alpha;", "Α", txt)

        # "U+00392", "GREEK CAPITAL LETTER BETA"
        txt = re.sub(r"&#x0*?392;", "Β", txt)
        txt = re.sub(r"&#0*?914;", "Β", txt)
        txt = re.sub(r"&Beta;", "Β", txt)

        # "U+00393", "GREEK CAPITAL LETTER GAMMA"
        txt = re.sub(r"&#x0*?393;", "Γ", txt)
        txt = re.sub(r"&#0*?915;", "Γ", txt)
        txt = re.sub(r"&Gamma;", "Γ", txt)

        # "U+00394", "GREEK CAPITAL LETTER DELTA"
        txt = re.sub(r"&#x0*?394;", "Δ", txt)
        txt = re.sub(r"&#0*?916;", "Δ", txt)
        txt = re.sub(r"&Delta;", "Δ", txt)

        # "U+00395", "GREEK CAPITAL LETTER EPSILON"
        txt = re.sub(r"&#x0*?395;", "Ε", txt)
        txt = re.sub(r"&#0*?917;", "Ε", txt)
        txt = re.sub(r"&Epsilon;", "Ε", txt)

        # "U+00396", "GREEK CAPITAL LETTER ZETA"
        txt = re.sub(r"&#x0*?396;", "Ζ", txt)
        txt = re.sub(r"&#0*?918;", "Ζ", txt)
        txt = re.sub(r"&Zeta;", "Ζ", txt)

        # "U+00397", "GREEK CAPITAL LETTER ETA"
        txt = re.sub(r"&#x0*?397;", "Η", txt)
        txt = re.sub(r"&#0*?919;", "Η", txt)
        txt = re.sub(r"&Eta;", "Η", txt)

        # "U+00398", "GREEK CAPITAL LETTER THETA"
        txt = re.sub(r"&#x0*?398;", "Θ", txt)
        txt = re.sub(r"&#0*?920;", "Θ", txt)
        txt = re.sub(r"&Theta;", "Θ", txt)

        # "U+00399", "GREEK CAPITAL LETTER IOTA"
        txt = re.sub(r"&#x0*?399;", "Ι", txt)
        txt = re.sub(r"&#0*?921;", "Ι", txt)
        txt = re.sub(r"&Iota;", "Ι", txt)

        # "U+0039A", "GREEK CAPITAL LETTER KAPPA"
        txt = re.sub(r"&#x0*?39A;", "Κ", txt)
        txt = re.sub(r"&#0*?922;", "Κ", txt)
        txt = re.sub(r"&Kappa;", "Κ", txt)

        # "U+0039B", "GREEK CAPITAL LETTER LAMDA"
        txt = re.sub(r"&#x0*?39B;", "Λ", txt)
        txt = re.sub(r"&#0*?923;", "Λ", txt)
        txt = re.sub(r"&Lambda;", "Λ", txt)

        # "U+0039C", "GREEK CAPITAL LETTER MU"
        txt = re.sub(r"&#x0*?39C;", "Μ", txt)
        txt = re.sub(r"&#0*?924;", "Μ", txt)
        txt = re.sub(r"&Mu;", "Μ", txt)

        # "U+0039D", "GREEK CAPITAL LETTER NU"
        txt = re.sub(r"&#x0*?39D;", "Ν", txt)
        txt = re.sub(r"&#0*?925;", "Ν", txt)
        txt = re.sub(r"&Nu;", "Ν", txt)

        # "U+0039E", "GREEK CAPITAL LETTER XI"
        txt = re.sub(r"&#x0*?39E;", "Ξ", txt)
        txt = re.sub(r"&#0*?926;", "Ξ", txt)
        txt = re.sub(r"&Xi;", "Ξ", txt)

        # "U+0039F", "GREEK CAPITAL LETTER OMICRON"
        txt = re.sub(r"&#x0*?39F;", "Ο", txt)
        txt = re.sub(r"&#0*?927;", "Ο", txt)
        txt = re.sub(r"&Omicron;", "Ο", txt)

        # "U+003A0", "GREEK CAPITAL LETTER PI"
        txt = re.sub(r"&#x0*?3A0;", "Π", txt)
        txt = re.sub(r"&#0*?928;", "Π", txt)
        txt = re.sub(r"&Pi;", "Π", txt)

        # "U+003A1", "GREEK CAPITAL LETTER RHO"
        txt = re.sub(r"&#x0*?3A1;", "Ρ", txt)
        txt = re.sub(r"&#0*?929;", "Ρ", txt)
        txt = re.sub(r"&Rho;", "Ρ", txt)

        # "U+003A3", "GREEK CAPITAL LETTER SIGMA"
        txt = re.sub(r"&#x0*?3A3;", "Σ", txt)
        txt = re.sub(r"&#0*?931;", "Σ", txt)
        txt = re.sub(r"&Sigma;", "Σ", txt)

        # "U+003A4", "GREEK CAPITAL LETTER TAU"
        txt = re.sub(r"&#x0*?3A4;", "Τ", txt)
        txt = re.sub(r"&#0*?932;", "Τ", txt)
        txt = re.sub(r"&Tau;", "Τ", txt)

        # "U+003A5", "GREEK CAPITAL LETTER UPSILON"
        txt = re.sub(r"&#x0*?3A5;", "Υ", txt)
        txt = re.sub(r"&#0*?933;", "Υ", txt)
        txt = re.sub(r"&Upsilon;", "Υ", txt)

        # "U+003A6", "GREEK CAPITAL LETTER PHI"
        txt = re.sub(r"&#x0*?3A6;", "Φ", txt)
        txt = re.sub(r"&#0*?934;", "Φ", txt)
        txt = re.sub(r"&Phi;", "Φ", txt)

        # "U+003A7", "GREEK CAPITAL LETTER CHI"
        txt = re.sub(r"&#x0*?3A7;", "Χ", txt)
        txt = re.sub(r"&#0*?935;", "Χ", txt)
        txt = re.sub(r"&Chi;", "Χ", txt)

        # "U+003A8", "GREEK CAPITAL LETTER PSI"
        txt = re.sub(r"&#x0*?3A8;", "Ψ", txt)
        txt = re.sub(r"&#0*?936;", "Ψ", txt)
        txt = re.sub(r"&Psi;", "Ψ", txt)

        # "U+003A9", "GREEK CAPITAL LETTER OMEGA"
        txt = re.sub(r"&#x0*?3A9;", "Ω", txt)
        txt = re.sub(r"&#0*?937;", "Ω", txt)
        txt = re.sub(r"&Omega;", "Ω", txt)

        # "U+003B1", "GREEK SMALL LETTER ALPHA"
        txt = re.sub(r"&#x0*?3B1;", "α", txt)
        txt = re.sub(r"&#0*?945;", "α", txt)
        txt = re.sub(r"&alpha;", "α", txt)

        # "U+003B2", "GREEK SMALL LETTER BETA"
        txt = re.sub(r"&#x0*?3B2;", "β", txt)
        txt = re.sub(r"&#0*?946;", "β", txt)
        txt = re.sub(r"&beta;", "β", txt)

        # "U+003B3", "GREEK SMALL LETTER GAMMA"
        txt = re.sub(r"&#x0*?3B3;", "γ", txt)
        txt = re.sub(r"&#0*?947;", "γ", txt)
        txt = re.sub(r"&gamma;", "γ", txt)

        # "U+003B4", "GREEK SMALL LETTER DELTA"
        txt = re.sub(r"&#x0*?3B4;", "δ", txt)
        txt = re.sub(r"&#0*?948;", "δ", txt)
        txt = re.sub(r"&delta;", "δ", txt)

        # "U+003B5", "GREEK SMALL LETTER EPSILON"
        txt = re.sub(r"&#x0*?3B5;", "ε", txt)
        txt = re.sub(r"&#0*?949;", "ε", txt)
        txt = re.sub(r"&epsiv;", "ε", txt)
        txt = re.sub(r"&varepsilon;", "ε", txt)
        txt = re.sub(r"&epsilon;", "ε", txt)

        # "U+003B6", "GREEK SMALL LETTER ZETA"
        txt = re.sub(r"&#x0*?3B6;", "ζ", txt)
        txt = re.sub(r"&#0*?950;", "ζ", txt)
        txt = re.sub(r"&zeta;", "ζ", txt)

        # "U+003B7", "GREEK SMALL LETTER ETA"
        txt = re.sub(r"&#x0*?3B7;", "η", txt)
        txt = re.sub(r"&#0*?951;", "η", txt)
        txt = re.sub(r"&eta;", "η", txt)

        # "U+003B8", "GREEK SMALL LETTER THETA"
        txt = re.sub(r"&#x0*?3B8;", "θ", txt)
        txt = re.sub(r"&#0*?952;", "θ", txt)
        txt = re.sub(r"&theta;", "θ", txt)

        # "U+003B9", "GREEK SMALL LETTER IOTA"
        txt = re.sub(r"&#x0*?3B9;", "ι", txt)
        txt = re.sub(r"&#0*?953;", "ι", txt)
        txt = re.sub(r"&iota;", "ι", txt)

        # "U+003BA", "GREEK SMALL LETTER KAPPA"
        txt = re.sub(r"&#x0*?3BA;", "κ", txt)
        txt = re.sub(r"&#0*?954;", "κ", txt)
        txt = re.sub(r"&kappa;", "κ", txt)

        # "U+003BB", "GREEK SMALL LETTER LAMDA"
        txt = re.sub(r"&#x0*?3BB;", "λ", txt)
        txt = re.sub(r"&#0*?955;", "λ", txt)
        txt = re.sub(r"&lambda;", "λ", txt)

        # "U+003BC", "GREEK SMALL LETTER MU"
        txt = re.sub(r"&#x0*?3BC;", "μ", txt)
        txt = re.sub(r"&#0*?956;", "μ", txt)
        txt = re.sub(r"&mu;", "μ", txt)

        # "U+003BD", "GREEK SMALL LETTER NU"
        txt = re.sub(r"&#x0*?3BD;", "ν", txt)
        txt = re.sub(r"&#0*?957;", "ν", txt)
        txt = re.sub(r"&nu;", "ν", txt)

        # "U+003BE", "GREEK SMALL LETTER XI"
        txt = re.sub(r"&#x0*?3BE;", "ξ", txt)
        txt = re.sub(r"&#0*?958;", "ξ", txt)
        txt = re.sub(r"&xi;", "ξ", txt)

        # "U+003BF", "GREEK SMALL LETTER OMICRON"
        txt = re.sub(r"&#x0*?3BF;", "ο", txt)
        txt = re.sub(r"&#0*?959;", "ο", txt)
        txt = re.sub(r"&omicron;", "ο", txt)

        # "U+003C0", "GREEK SMALL LETTER PI"
        txt = re.sub(r"&#x0*?3C0;", "π", txt)
        txt = re.sub(r"&#0*?960;", "π", txt)
        txt = re.sub(r"&pi;", "π", txt)

        # "U+003C1", "GREEK SMALL LETTER RHO"
        txt = re.sub(r"&#x0*?3C1;", "ρ", txt)
        txt = re.sub(r"&#0*?961;", "ρ", txt)
        txt = re.sub(r"&rho;", "ρ", txt)

        # "U+003C2", "GREEK SMALL LETTER FINAL SIGMA"
        txt = re.sub(r"&#x0*?3C2;", "ς", txt)
        txt = re.sub(r"&#0*?962;", "ς", txt)
        txt = re.sub(r"&sigmav;", "ς", txt)
        txt = re.sub(r"&varsigma;", "ς", txt)
        txt = re.sub(r"&sigmaf;", "ς", txt)

        # "U+003C3", "GREEK SMALL LETTER SIGMA"
        txt = re.sub(r"&#x0*?3C3;", "σ", txt)
        txt = re.sub(r"&#0*?963;", "σ", txt)
        txt = re.sub(r"&sigma;", "σ", txt)

        # "U+003C4", "GREEK SMALL LETTER TAU"
        txt = re.sub(r"&#x0*?3C4;", "τ", txt)
        txt = re.sub(r"&#0*?964;", "τ", txt)
        txt = re.sub(r"&tau;", "τ", txt)

        # "U+003C5", "GREEK SMALL LETTER UPSILON"
        txt = re.sub(r"&#x0*?3C5;", "υ", txt)
        txt = re.sub(r"&#0*?965;", "υ", txt)
        txt = re.sub(r"&upsi;", "υ", txt)
        txt = re.sub(r"&upsilon;", "υ", txt)

        # "U+003C6", "GREEK SMALL LETTER PHI"
        txt = re.sub(r"&#x0*?3C6;", "φ", txt)
        txt = re.sub(r"&#0*?966;", "φ", txt)
        txt = re.sub(r"&phi;", "φ", txt)
        txt = re.sub(r"&phiv;", "φ", txt)
        txt = re.sub(r"&varphi;", "φ", txt)

        # "U+003C7", "GREEK SMALL LETTER CHI"
        txt = re.sub(r"&#x0*?3C7;", "χ", txt)
        txt = re.sub(r"&#0*?967;", "χ", txt)
        txt = re.sub(r"&chi;", "χ", txt)

        # "U+003C8", "GREEK SMALL LETTER PSI"
        txt = re.sub(r"&#x0*?3C8;", "ψ", txt)
        txt = re.sub(r"&#0*?968;", "ψ", txt)
        txt = re.sub(r"&psi;", "ψ", txt)

        # "U+003C9", "GREEK SMALL LETTER OMEGA"
        txt = re.sub(r"&#x0*?3C9;", "ω", txt)
        txt = re.sub(r"&#0*?969;", "ω", txt)
        txt = re.sub(r"&omega;", "ω", txt)

        # "U+003D1", "GREEK THETA SYMBOL"
        txt = re.sub(r"&#x0*?3D1;", "ϑ", txt)
        txt = re.sub(r"&#0*?977;", "ϑ", txt)
        txt = re.sub(r"&thetav;", "ϑ", txt)
        txt = re.sub(r"&vartheta;", "ϑ", txt)
        txt = re.sub(r"&thetasym;", "ϑ", txt)

        # "U+003D2", "GREEK UPSILON WITH HOOK SYMBOL"
        txt = re.sub(r"&#x0*?3D2;", "ϒ", txt)
        txt = re.sub(r"&#0*?978;", "ϒ", txt)
        txt = re.sub(r"&Upsi;", "ϒ", txt)
        txt = re.sub(r"&upsih;", "ϒ", txt)

        # "U+003D6", "GREEK PI SYMBOL"
        txt = re.sub(r"&#x0*?3D6;", "ϖ", txt)
        txt = re.sub(r"&#0*?982;", "ϖ", txt)
        txt = re.sub(r"&piv;", "ϖ", txt)
        txt = re.sub(r"&varpi;", "ϖ", txt)

        # "U+02002", "EN SPACE"
        txt = re.sub(r"&#x0*?2002;", " ", txt)
        txt = re.sub(r"&#0*?8194;", " ", txt)
        txt = re.sub(r"&ensp;", " ", txt)

        # "U+02003", "EM SPACE"
        txt = re.sub(r"&#x0*?2003;", " ", txt)
        txt = re.sub(r"&#0*?8195;", " ", txt)
        txt = re.sub(r"&emsp;", " ", txt)

        # "U+02009", "THIN SPACE"
        txt = re.sub(r"&#x0*?2009;", " ", txt)
        txt = re.sub(r"&#0*?8201;", " ", txt)
        txt = re.sub(r"&thinsp;", " ", txt)
        txt = re.sub(r"&ThinSpace;", " ", txt)

        # "U+0200C", "ZERO WIDTH NON-JOINER"
        txt = re.sub(r"&#x0*?200C;", "‌", txt)
        txt = re.sub(r"&#0*?8204;", "‌", txt)
        txt = re.sub(r"&zwnj;", "‌", txt)

        # "U+0200D", "ZERO WIDTH JOINER"
        txt = re.sub(r"&#x0*?200D;", "‍", txt)
        txt = re.sub(r"&#0*?8205;", "‍", txt)
        txt = re.sub(r"&zwj;", "‍", txt)

        # "U+0200E", "LEFT-TO-RIGHT MARK"
        txt = re.sub(r"&#x0*?200E;", "‎", txt)
        txt = re.sub(r"&#0*?8206;", "‎", txt)
        txt = re.sub(r"&lrm;", "‎", txt)

        # "U+0200F", "RIGHT-TO-LEFT MARK"
        txt = re.sub(r"&#x0*?200F;", "‏", txt)
        txt = re.sub(r"&#0*?8207;", "‏", txt)
        txt = re.sub(r"&rlm;", "‏", txt)

        # "U+02013", "EN DASH"
        txt = re.sub(r"&#x0*?2013;", "–", txt)
        txt = re.sub(r"&#0*?8211;", "–", txt)
        txt = re.sub(r"&ndash;", "–", txt)

        # "U+02014", "EM DASH"
        txt = re.sub(r"&#x0*?2014;", "—", txt)
        txt = re.sub(r"&#0*?8212;", "—", txt)
        txt = re.sub(r"&mdash;", "—", txt)

        # "U+02018", "LEFT SINGLE QUOTATION MARK"
        txt = re.sub(r"&#x0*?2018;", "‘", txt)
        txt = re.sub(r"&#0*?8216;", "‘", txt)
        txt = re.sub(r"&lsquo;", "‘", txt)
        txt = re.sub(r"&OpenCurlyQuote;", "‘", txt)

        # "U+02019", "RIGHT SINGLE QUOTATION MARK"
        txt = re.sub(r"&#x0*?2019;", "’", txt)
        txt = re.sub(r"&#0*?8217;", "’", txt)
        txt = re.sub(r"&rsquo;", "’", txt)
        txt = re.sub(r"&rsquor;", "’", txt)
        txt = re.sub(r"&CloseCurlyQuote;", "’", txt)

        # "U+0201A", "SINGLE LOW-9 QUOTATION MARK"
        txt = re.sub(r"&#x0*?201A;", "‚", txt)
        txt = re.sub(r"&#0*?8218;", "‚", txt)
        txt = re.sub(r"&lsquor;", "‚", txt)
        txt = re.sub(r"&sbquo;", "‚", txt)

        # "U+0201C", "LEFT DOUBLE QUOTATION MARK"
        txt = re.sub(r"&#x0*?201C;", "“", txt)
        txt = re.sub(r"&#0*?8220;", "“", txt)
        txt = re.sub(r"&ldquo;", "“", txt)
        txt = re.sub(r"&OpenCurlyDoubleQuote;", "“", txt)

        # "U+0201D", "RIGHT DOUBLE QUOTATION MARK"
        txt = re.sub(r"&#x0*?201D;", "”", txt)
        txt = re.sub(r"&#0*?8221;", "”", txt)
        txt = re.sub(r"&rdquo;", "”", txt)
        txt = re.sub(r"&rdquor;", "”", txt)
        txt = re.sub(r"&CloseCurlyDoubleQuote;", "”", txt)

        # "U+0201E", "DOUBLE LOW-9 QUOTATION MARK"
        txt = re.sub(r"&#x0*?201E;", "„", txt)
        txt = re.sub(r"&#0*?8222;", "„", txt)
        txt = re.sub(r"&ldquor;", "„", txt)
        txt = re.sub(r"&bdquo;", "„", txt)

        # "U+02020", "DAGGER"
        txt = re.sub(r"&#x0*?2020;", "†", txt)
        txt = re.sub(r"&#0*?8224;", "†", txt)
        txt = re.sub(r"&dagger;", "†", txt)

        # "U+02021", "DOUBLE DAGGER"
        txt = re.sub(r"&#x0*?2021;", "‡", txt)
        txt = re.sub(r"&#0*?8225;", "‡", txt)
        txt = re.sub(r"&Dagger;", "‡", txt)
        txt = re.sub(r"&ddagger;", "‡", txt)

        # "U+02022", "BULLET"
        txt = re.sub(r"&#x0*?2022;", "•", txt)
        txt = re.sub(r"&#0*?8226;", "•", txt)
        txt = re.sub(r"&bull;", "•", txt)
        txt = re.sub(r"&bullet;", "•", txt)

        # "U+02026", "HORIZONTAL ELLIPSIS"
        txt = re.sub(r"&#x0*?2026;", "…", txt)
        txt = re.sub(r"&#0*?8230;", "…", txt)
        txt = re.sub(r"&hellip;", "…", txt)
        txt = re.sub(r"&mldr;", "…", txt)

        # "U+02030", "PER MILLE SIGN"
        txt = re.sub(r"&#x0*?2030;", "‰", txt)
        txt = re.sub(r"&#0*?8240;", "‰", txt)
        txt = re.sub(r"&permil;", "‰", txt)

        # "U+02032", "PRIME"
        txt = re.sub(r"&#x0*?2032;", "′", txt)
        txt = re.sub(r"&#0*?8242;", "′", txt)
        txt = re.sub(r"&prime;", "′", txt)

        # "U+02033", "DOUBLE PRIME"
        txt = re.sub(r"&#x0*?2033;", "″", txt)
        txt = re.sub(r"&#0*?8243;", "″", txt)
        txt = re.sub(r"&Prime;", "″", txt)

        # "U+02039", "SINGLE LEFT-POINTING ANGLE QUOTATION MARK"
        txt = re.sub(r"&#x0*?2039;", "‹", txt)
        txt = re.sub(r"&#0*?8249;", "‹", txt)
        txt = re.sub(r"&lsaquo;", "‹", txt)

        # "U+0203A", "SINGLE RIGHT-POINTING ANGLE QUOTATION MARK"
        txt = re.sub(r"&#x0*?203A;", "›", txt)
        txt = re.sub(r"&#0*?8250;", "›", txt)
        txt = re.sub(r"&rsaquo;", "›", txt)

        # "U+0203E", "OVERLINE"
        txt = re.sub(r"&#x0*?203E;", "‾", txt)
        txt = re.sub(r"&#0*?8254;", "‾", txt)
        txt = re.sub(r"&oline;", "‾", txt)

        # "U+02044", "FRACTION SLASH"
        txt = re.sub(r"&#x0*?2044;", "⁄", txt)
        txt = re.sub(r"&#0*?8260;", "⁄", txt)
        txt = re.sub(r"&frasl;", "⁄", txt)

        # "U+020AC", "EURO SIGN"
        txt = re.sub(r"&#x0*?20AC;", "€", txt)
        txt = re.sub(r"&#0*?8364;", "€", txt)
        txt = re.sub(r"&euro;", "€", txt)

        # "U+02111", "BLACK-LETTER CAPITAL I"
        txt = re.sub(r"&#x0*?2111;", "ℑ", txt)
        txt = re.sub(r"&#0*?8465;", "ℑ", txt)
        txt = re.sub(r"&image;", "ℑ", txt)
        txt = re.sub(r"&Im;", "ℑ", txt)
        txt = re.sub(r"&imagpart;", "ℑ", txt)
        txt = re.sub(r"&Ifr;", "ℑ", txt)

        # "U+02118", "SCRIPT CAPITAL P"
        txt = re.sub(r"&#x0*?2118;", "℘", txt)
        txt = re.sub(r"&#0*?8472;", "℘", txt)
        txt = re.sub(r"&weierp;", "℘", txt)
        txt = re.sub(r"&wp;", "℘", txt)

        # "U+0211C", "BLACK-LETTER CAPITAL R"
        txt = re.sub(r"&#x0*?211C;", "ℜ", txt)
        txt = re.sub(r"&#0*?8476;", "ℜ", txt)
        txt = re.sub(r"&real;", "ℜ", txt)
        txt = re.sub(r"&Re;", "ℜ", txt)
        txt = re.sub(r"&realpart;", "ℜ", txt)
        txt = re.sub(r"&Rfr;", "ℜ", txt)

        # "U+02122", "TRADE MARK SIGN"
        txt = re.sub(r"&#x0*?2122;", "™", txt)
        txt = re.sub(r"&#0*?8482;", "™", txt)
        txt = re.sub(r"&trade;", "™", txt)
        txt = re.sub(r"&TRADE;", "™", txt)

        # "U+02135", "ALEF SYMBOL"
        txt = re.sub(r"&#x0*?2135;", "ℵ", txt)
        txt = re.sub(r"&#0*?8501;", "ℵ", txt)
        txt = re.sub(r"&alefsym;", "ℵ", txt)
        txt = re.sub(r"&aleph;", "ℵ", txt)

        # "U+02190", "LEFTWARDS ARROW"
        txt = re.sub(r"&#x0*?2190;", "←", txt)
        txt = re.sub(r"&#0*?8592;", "←", txt)
        txt = re.sub(r"&larr;", "←", txt)
        txt = re.sub(r"&leftarrow;", "←", txt)
        txt = re.sub(r"&LeftArrow;", "←", txt)
        txt = re.sub(r"&slarr;", "←", txt)
        txt = re.sub(r"&ShortLeftArrow;", "←", txt)

        # "U+02191", "UPWARDS ARROW"
        txt = re.sub(r"&#x0*?2191;", "↑", txt)
        txt = re.sub(r"&#0*?8593;", "↑", txt)
        txt = re.sub(r"&uarr;", "↑", txt)
        txt = re.sub(r"&uparrow;", "↑", txt)
        txt = re.sub(r"&UpArrow;", "↑", txt)
        txt = re.sub(r"&ShortUpArrow;", "↑", txt)

        # "U+02192", "RIGHTWARDS ARROW"
        txt = re.sub(r"&#x0*?2192;", "→", txt)
        txt = re.sub(r"&#0*?8594;", "→", txt)
        txt = re.sub(r"&rarr;", "→", txt)
        txt = re.sub(r"&rightarrow;", "→", txt)
        txt = re.sub(r"&RightArrow;", "→", txt)
        txt = re.sub(r"&srarr;", "→", txt)
        txt = re.sub(r"&ShortRightArrow;", "→", txt)

        # "U+02193", "DOWNWARDS ARROW"
        txt = re.sub(r"&#x0*?2193;", "↓", txt)
        txt = re.sub(r"&#0*?8595;", "↓", txt)
        txt = re.sub(r"&darr;", "↓", txt)
        txt = re.sub(r"&downarrow;", "↓", txt)
        txt = re.sub(r"&DownArrow;", "↓", txt)
        txt = re.sub(r"&ShortDownArrow;", "↓", txt)

        # "U+02194", "LEFT RIGHT ARROW"
        txt = re.sub(r"&#x0*?2194;", "↔", txt)
        txt = re.sub(r"&#0*?8596;", "↔", txt)
        txt = re.sub(r"&harr;", "↔", txt)
        txt = re.sub(r"&leftrightarrow;", "↔", txt)
        txt = re.sub(r"&LeftRightArrow;", "↔", txt)

        # "U+021B5", "DOWNWARDS ARROW WITH CORNER LEFTWARDS"
        txt = re.sub(r"&#x0*?21B5;", "↵", txt)
        txt = re.sub(r"&#0*?8629;", "↵", txt)
        txt = re.sub(r"&crarr;", "↵", txt)

        # "U+021D0", "LEFTWARDS DOUBLE ARROW"
        txt = re.sub(r"&#x0*?21D0;", "⇐", txt)
        txt = re.sub(r"&#0*?8656;", "⇐", txt)
        txt = re.sub(r"&lArr;", "⇐", txt)
        txt = re.sub(r"&Leftarrow;", "⇐", txt)
        txt = re.sub(r"&DoubleLeftArrow;", "⇐", txt)

        # "U+021D1", "UPWARDS DOUBLE ARROW"
        txt = re.sub(r"&#x0*?21D1;", "⇑", txt)
        txt = re.sub(r"&#0*?8657;", "⇑", txt)
        txt = re.sub(r"&uArr;", "⇑", txt)
        txt = re.sub(r"&Uparrow;", "⇑", txt)
        txt = re.sub(r"&DoubleUpArrow;", "⇑", txt)

        # "U+021D2", "RIGHTWARDS DOUBLE ARROW"
        txt = re.sub(r"&#x0*?21D2;", "⇒", txt)
        txt = re.sub(r"&#0*?8658;", "⇒", txt)
        txt = re.sub(r"&rArr;", "⇒", txt)
        txt = re.sub(r"&Rightarrow;", "⇒", txt)
        txt = re.sub(r"&Implies;", "⇒", txt)
        txt = re.sub(r"&DoubleRightArrow;", "⇒", txt)

        # "U+021D3", "DOWNWARDS DOUBLE ARROW"
        txt = re.sub(r"&#x0*?21D3;", "⇓", txt)
        txt = re.sub(r"&#0*?8659;", "⇓", txt)
        txt = re.sub(r"&dArr;", "⇓", txt)
        txt = re.sub(r"&Downarrow;", "⇓", txt)
        txt = re.sub(r"&DoubleDownArrow;", "⇓", txt)

        # "U+021D4", "LEFT RIGHT DOUBLE ARROW"
        txt = re.sub(r"&#x0*?21D4;", "⇔", txt)
        txt = re.sub(r"&#0*?8660;", "⇔", txt)
        txt = re.sub(r"&hArr;", "⇔", txt)
        txt = re.sub(r"&Leftrightarrow;", "⇔", txt)
        txt = re.sub(r"&DoubleLeftRightArrow;", "⇔", txt)
        txt = re.sub(r"&iff;", "⇔", txt)

        # "U+02200", "FOR ALL"
        txt = re.sub(r"&#x0*?2200;", "∀", txt)
        txt = re.sub(r"&#0*?8704;", "∀", txt)
        txt = re.sub(r"&forall;", "∀", txt)
        txt = re.sub(r"&ForAll;", "∀", txt)

        # "U+02202", "PARTIAL DIFFERENTIAL"
        txt = re.sub(r"&#x0*?2202;", "∂", txt)
        txt = re.sub(r"&#0*?8706;", "∂", txt)
        txt = re.sub(r"&part;", "∂", txt)
        txt = re.sub(r"&PartialD;", "∂", txt)

        # "U+02203", "THERE EXISTS"
        txt = re.sub(r"&#x0*?2203;", "∃", txt)
        txt = re.sub(r"&#0*?8707;", "∃", txt)
        txt = re.sub(r"&exist;", "∃", txt)
        txt = re.sub(r"&Exists;", "∃", txt)

        # "U+02205", "EMPTY SET"
        txt = re.sub(r"&#x0*?2205;", "∅", txt)
        txt = re.sub(r"&#0*?8709;", "∅", txt)
        txt = re.sub(r"&empty;", "∅", txt)
        txt = re.sub(r"&emptyset;", "∅", txt)
        txt = re.sub(r"&emptyv;", "∅", txt)
        txt = re.sub(r"&varnothing;", "∅", txt)

        # "U+02207", "NABLA"
        txt = re.sub(r"&#x0*?2207;", "∇", txt)
        txt = re.sub(r"&#0*?8711;", "∇", txt)
        txt = re.sub(r"&nabla;", "∇", txt)
        txt = re.sub(r"&Del;", "∇", txt)

        # "U+02208", "ELEMENT OF"
        txt = re.sub(r"&#x0*?2208;", "∈", txt)
        txt = re.sub(r"&#0*?8712;", "∈", txt)
        txt = re.sub(r"&isin;", "∈", txt)
        txt = re.sub(r"&isinv;", "∈", txt)
        txt = re.sub(r"&Element;", "∈", txt)
        txt = re.sub(r"&in;", "∈", txt)

        # "U+02209", "NOT AN ELEMENT OF"
        txt = re.sub(r"&#x0*?2209;", "∉", txt)
        txt = re.sub(r"&#0*?8713;", "∉", txt)
        txt = re.sub(r"&notin;", "∉", txt)
        txt = re.sub(r"&NotElement;", "∉", txt)
        txt = re.sub(r"&notinva;", "∉", txt)

        # "U+0220B", "CONTAINS AS MEMBER"
        txt = re.sub(r"&#x0*?220B;", "∋", txt)
        txt = re.sub(r"&#0*?8715;", "∋", txt)
        txt = re.sub(r"&niv;", "∋", txt)
        txt = re.sub(r"&ReverseElement;", "∋", txt)
        txt = re.sub(r"&ni;", "∋", txt)
        txt = re.sub(r"&SuchThat;", "∋", txt)

        # "U+0220F", "N-ARY PRODUCT"
        txt = re.sub(r"&#x0*?220F;", "∏", txt)
        txt = re.sub(r"&#0*?8719;", "∏", txt)
        txt = re.sub(r"&prod;", "∏", txt)
        txt = re.sub(r"&Product;", "∏", txt)

        # "U+02211", "N-ARY SUMMATION"
        txt = re.sub(r"&#x0*?2211;", "∑", txt)
        txt = re.sub(r"&#0*?8721;", "∑", txt)
        txt = re.sub(r"&sum;", "∑", txt)
        txt = re.sub(r"&Sum;", "∑", txt)

        # "U+02212", "MINUS SIGN"
        txt = re.sub(r"&#x0*?2212;", "−", txt)
        txt = re.sub(r"&#0*?8722;", "−", txt)
        txt = re.sub(r"&minus;", "−", txt)

        # "U+02217", "ASTERISK OPERATOR"
        txt = re.sub(r"&#x0*?2217;", "∗", txt)
        txt = re.sub(r"&#0*?8727;", "∗", txt)
        txt = re.sub(r"&lowast;", "∗", txt)

        # "U+0221A", "SQUARE ROOT"
        txt = re.sub(r"&#x0*?221A;", "√", txt)
        txt = re.sub(r"&#0*?8730;", "√", txt)
        txt = re.sub(r"&radic;", "√", txt)
        txt = re.sub(r"&Sqrt;", "√", txt)

        # "U+0221D", "PROPORTIONAL TO"
        txt = re.sub(r"&#x0*?221D;", "∝", txt)
        txt = re.sub(r"&#0*?8733;", "∝", txt)
        txt = re.sub(r"&prop;", "∝", txt)
        txt = re.sub(r"&propto;", "∝", txt)
        txt = re.sub(r"&Proportional;", "∝", txt)
        txt = re.sub(r"&vprop;", "∝", txt)
        txt = re.sub(r"&varpropto;", "∝", txt)

        # "U+0221E", "INFINITY"
        txt = re.sub(r"&#x0*?221E;", "∞", txt)
        txt = re.sub(r"&#0*?8734;", "∞", txt)
        txt = re.sub(r"&infin;", "∞", txt)

        # "U+02220", "ANGLE"
        txt = re.sub(r"&#x0*?2220;", "∠", txt)
        txt = re.sub(r"&#0*?8736;", "∠", txt)
        txt = re.sub(r"&ang;", "∠", txt)
        txt = re.sub(r"&angle;", "∠", txt)

        # "U+02227", "LOGICAL AND"
        txt = re.sub(r"&#x0*?2227;", "∧", txt)
        txt = re.sub(r"&#0*?8743;", "∧", txt)
        txt = re.sub(r"&and;", "∧", txt)
        txt = re.sub(r"&wedge;", "∧", txt)

        # "U+02228", "LOGICAL OR"
        txt = re.sub(r"&#x0*?2228;", "∨", txt)
        txt = re.sub(r"&#0*?8744;", "∨", txt)
        txt = re.sub(r"&or;", "∨", txt)
        txt = re.sub(r"&vee;", "∨", txt)

        # "U+02229", "INTERSECTION"
        txt = re.sub(r"&#x0*?2229;", "∩", txt)
        txt = re.sub(r"&#0*?8745;", "∩", txt)
        txt = re.sub(r"&cap;", "∩", txt)

        # "U+0222A", "UNION"
        txt = re.sub(r"&#x0*?222A;", "∪", txt)
        txt = re.sub(r"&#0*?8746;", "∪", txt)
        txt = re.sub(r"&cup;", "∪", txt)

        # "U+0222B", "INTEGRAL"
        txt = re.sub(r"&#x0*?222B;", "∫", txt)
        txt = re.sub(r"&#0*?8747;", "∫", txt)
        txt = re.sub(r"&int;", "∫", txt)
        txt = re.sub(r"&Integral;", "∫", txt)

        # "U+02234", "THEREFORE"
        txt = re.sub(r"&#x0*?2234;", "∴", txt)
        txt = re.sub(r"&#0*?8756;", "∴", txt)
        txt = re.sub(r"&there4;", "∴", txt)
        txt = re.sub(r"&therefore;", "∴", txt)
        txt = re.sub(r"&Therefore;", "∴", txt)

        # "U+0223C", "TILDE OPERATOR"
        txt = re.sub(r"&#x0*?223C;", "∼", txt)
        txt = re.sub(r"&#0*?8764;", "∼", txt)
        txt = re.sub(r"&sim;", "∼", txt)
        txt = re.sub(r"&Tilde;", "∼", txt)
        txt = re.sub(r"&thksim;", "∼", txt)
        txt = re.sub(r"&thicksim;", "∼", txt)

        # "U+02245", "APPROXIMATELY EQUAL TO"
        txt = re.sub(r"&#x0*?2245;", "≅", txt)
        txt = re.sub(r"&#0*?8773;", "≅", txt)
        txt = re.sub(r"&cong;", "≅", txt)
        txt = re.sub(r"&TildeFullEqual;", "≅", txt)

        # "U+02248", "ALMOST EQUAL TO"
        txt = re.sub(r"&#x0*?2248;", "≈", txt)
        txt = re.sub(r"&#0*?8776;", "≈", txt)
        txt = re.sub(r"&asymp;", "≈", txt)
        txt = re.sub(r"&ap;", "≈", txt)
        txt = re.sub(r"&TildeTilde;", "≈", txt)
        txt = re.sub(r"&approx;", "≈", txt)
        txt = re.sub(r"&thkap;", "≈", txt)
        txt = re.sub(r"&thickapprox;", "≈", txt)

        # "U+02260", "NOT EQUAL TO"
        txt = re.sub(r"&#x0*?2260;", "≠", txt)
        txt = re.sub(r"&#0*?8800;", "≠", txt)
        txt = re.sub(r"&ne;", "≠", txt)
        txt = re.sub(r"&NotEqual;", "≠", txt)

        # "U+02261", "IDENTICAL TO"
        txt = re.sub(r"&#x0*?2261;", "≡", txt)
        txt = re.sub(r"&#0*?8801;", "≡", txt)
        txt = re.sub(r"&equiv;", "≡", txt)
        txt = re.sub(r"&Congruent;", "≡", txt)

        # "U+02264", "LESS-THAN OR EQUAL TO"
        txt = re.sub(r"&#x0*?2264;", "≤", txt)
        txt = re.sub(r"&#0*?8804;", "≤", txt)
        txt = re.sub(r"&le;", "≤", txt)
        txt = re.sub(r"&leq;", "≤", txt)

        # "U+02265", "GREATER-THAN OR EQUAL TO"
        txt = re.sub(r"&#x0*?2265;", "≥", txt)
        txt = re.sub(r"&#0*?8805;", "≥", txt)
        txt = re.sub(r"&ge;", "≥", txt)
        txt = re.sub(r"&GreaterEqual;", "≥", txt)
        txt = re.sub(r"&geq;", "≥", txt)

        # "U+02282", "SUBSET OF"
        txt = re.sub(r"&#x0*?2282;", "⊂", txt)
        txt = re.sub(r"&#0*?8834;", "⊂", txt)
        txt = re.sub(r"&sub;", "⊂", txt)
        txt = re.sub(r"&subset;", "⊂", txt)

        # "U+02283", "SUPERSET OF"
        txt = re.sub(r"&#x0*?2283;", "⊃", txt)
        txt = re.sub(r"&#0*?8835;", "⊃", txt)
        txt = re.sub(r"&sup;", "⊃", txt)
        txt = re.sub(r"&supset;", "⊃", txt)
        txt = re.sub(r"&Superset;", "⊃", txt)

        # "U+02284", "NOT A SUBSET OF"
        txt = re.sub(r"&#x0*?2284;", "⊄", txt)
        txt = re.sub(r"&#0*?8836;", "⊄", txt)
        txt = re.sub(r"&nsub;", "⊄", txt)

        # "U+02286", "SUBSET OF OR EQUAL TO"
        txt = re.sub(r"&#x0*?2286;", "⊆", txt)
        txt = re.sub(r"&#0*?8838;", "⊆", txt)
        txt = re.sub(r"&sube;", "⊆", txt)
        txt = re.sub(r"&SubsetEqual;", "⊆", txt)
        txt = re.sub(r"&subseteq;", "⊆", txt)

        # "U+02287", "SUPERSET OF OR EQUAL TO"
        txt = re.sub(r"&#x0*?2287;", "⊇", txt)
        txt = re.sub(r"&#0*?8839;", "⊇", txt)
        txt = re.sub(r"&supe;", "⊇", txt)
        txt = re.sub(r"&supseteq;", "⊇", txt)
        txt = re.sub(r"&SupersetEqual;", "⊇", txt)

        # "U+02295", "CIRCLED PLUS"
        txt = re.sub(r"&#x0*?2295;", "⊕", txt)
        txt = re.sub(r"&#0*?8853;", "⊕", txt)
        txt = re.sub(r"&oplus;", "⊕", txt)
        txt = re.sub(r"&CirclePlus;", "⊕", txt)

        # "U+02297", "CIRCLED TIMES"
        txt = re.sub(r"&#x0*?2297;", "⊗", txt)
        txt = re.sub(r"&#0*?8855;", "⊗", txt)
        txt = re.sub(r"&otimes;", "⊗", txt)
        txt = re.sub(r"&CircleTimes;", "⊗", txt)

        # "U+022A5", "UP TACK"
        txt = re.sub(r"&#x0*?22A5;", "⊥", txt)
        txt = re.sub(r"&#0*?8869;", "⊥", txt)
        txt = re.sub(r"&bottom;", "⊥", txt)
        txt = re.sub(r"&bot;", "⊥", txt)
        txt = re.sub(r"&perp;", "⊥", txt)
        txt = re.sub(r"&UpTee;", "⊥", txt)

        # "U+022C5", "DOT OPERATOR"
        txt = re.sub(r"&#x0*?22C5;", "⋅", txt)
        txt = re.sub(r"&#0*?8901;", "⋅", txt)
        txt = re.sub(r"&sdot;", "⋅", txt)

        # "U+02308", "LEFT CEILING"
        txt = re.sub(r"&#x0*?2308;", "⌈", txt)
        txt = re.sub(r"&#0*?8968;", "⌈", txt)
        txt = re.sub(r"&lceil;", "⌈", txt)
        txt = re.sub(r"&LeftCeiling;", "⌈", txt)

        # "U+02309", "RIGHT CEILING"
        txt = re.sub(r"&#x0*?2309;", "⌉", txt)
        txt = re.sub(r"&#0*?8969;", "⌉", txt)
        txt = re.sub(r"&rceil;", "⌉", txt)
        txt = re.sub(r"&RightCeiling;", "⌉", txt)

        # "U+0230A", "LEFT FLOOR"
        txt = re.sub(r"&#x0*?230A;", "⌊", txt)
        txt = re.sub(r"&#0*?8970;", "⌊", txt)
        txt = re.sub(r"&lfloor;", "⌊", txt)
        txt = re.sub(r"&LeftFloor;", "⌊", txt)

        # "U+0230B", "RIGHT FLOOR"
        txt = re.sub(r"&#x0*?230B;", "⌋", txt)
        txt = re.sub(r"&#0*?8971;", "⌋", txt)
        txt = re.sub(r"&rfloor;", "⌋", txt)
        txt = re.sub(r"&RightFloor;", "⌋", txt)

        # "U+025CA", "LOZENGE"
        txt = re.sub(r"&#x0*?25CA;", "◊", txt)
        txt = re.sub(r"&#0*?9674;", "◊", txt)
        txt = re.sub(r"&loz;", "◊", txt)
        txt = re.sub(r"&lozenge;", "◊", txt)

        # "U+02660", "BLACK SPADE SUIT"
        txt = re.sub(r"&#x0*?2660;", "♠", txt)
        txt = re.sub(r"&#0*?9824;", "♠", txt)
        txt = re.sub(r"&spades;", "♠", txt)
        txt = re.sub(r"&spadesuit;", "♠", txt)

        # "U+02663", "BLACK CLUB SUIT"
        txt = re.sub(r"&#x0*?2663;", "♣", txt)
        txt = re.sub(r"&#0*?9827;", "♣", txt)
        txt = re.sub(r"&clubs;", "♣", txt)
        txt = re.sub(r"&clubsuit;", "♣", txt)

        # "U+02665", "BLACK HEART SUIT"
        txt = re.sub(r"&#x0*?2665;", "♥", txt)
        txt = re.sub(r"&#0*?9829;", "♥", txt)
        txt = re.sub(r"&hearts;", "♥", txt)
        txt = re.sub(r"&heartsuit;", "♥", txt)

        # "U+02666", "BLACK DIAMOND SUIT"
        txt = re.sub(r"&#x0*?2666;", "♦", txt)
        txt = re.sub(r"&#0*?9830;", "♦", txt)
        txt = re.sub(r"&diams;", "♦", txt)
        txt = re.sub(r"&diamondsuit;", "♦", txt)

        # "U+027E8", "MATHEMATICAL LEFT ANGLE BRACKET"
        txt = re.sub(r"&#x0*?27E8;", "⟨", txt)
        txt = re.sub(r"&#0*?10216;", "⟨", txt)
        txt = re.sub(r"&lang;", "⟨", txt)
        txt = re.sub(r"&LeftAngleBracket;", "⟨", txt)
        txt = re.sub(r"&langle;", "⟨", txt)

        # "U+027E9", "MATHEMATICAL RIGHT ANGLE BRACKET"
        txt = re.sub(r"&#x0*?27E9;", "⟩", txt)
        txt = re.sub(r"&#0*?10217;", "⟩", txt)
        txt = re.sub(r"&rang;", "⟩", txt)
        txt = re.sub(r"&RightAngleBracket;", "⟩", txt)
        txt = re.sub(r"&rangle;", "⟩", txt)

        return txt

    """
    入力される文字列内の文字実体参照を文字や記号に置きかえます。ベーシック版です。
    :param source: 置きかえられる文字列の配列。
    :return: 置きかえられた文字列の配列。
    """

    @staticmethod
    def convert_from_all_basic(sources: List[str]) -> List[str]:
        for i in range(len(sources)):
            sources[i] = CharacterEntityReference.convert_from_basic(sources[i])

        return sources

    """
    入力される文字列内の文字実体参照を文字や記号に置きかえます。
    :param source: 置きかえられる文字列。
    :return: 置きかえられた文字列。
    """

    @staticmethod
    def convert_from(source: str) -> str:
        txt = source

        # "U+00009", "CHARACTER TABULATION"
        txt = re.sub(r"&#x0*?9;", "\t", txt)
        txt = re.sub(r"&#0*?9;", "\t", txt)
        txt = re.sub(r"&Tab;", "\t", txt)

        # "U+0000A", "LINE FEED (LF)"
        txt = re.sub(r"&#x0*?A;", "\n", txt)
        txt = re.sub(r"&#0*?10;", "\n", txt)
        txt = re.sub(r"&NewLine;", "\n", txt)

        # "U+00021", "EXCLAMATION MARK"
        txt = re.sub(r"&#x0*?21;", "!", txt)
        txt = re.sub(r"&#0*?33;", "!", txt)
        txt = re.sub(r"&excl;", "!", txt)

        # "U+00022", "QUOTATION MARK"
        txt = re.sub(r"&#x0*?22;", '"', txt)
        txt = re.sub(r"&#0*?34;", '"', txt)
        txt = re.sub(r"&quot;", '"', txt)
        txt = re.sub(r"&QUOT;", '"', txt)

        # "U+00023", "NUMBER SIGN"
        txt = re.sub(r"&#x0*?23;", "#", txt)
        txt = re.sub(r"&#0*?35;", "#", txt)
        txt = re.sub(r"&num;", "#", txt)

        # "U+00024", "DOLLAR SIGN"
        txt = re.sub(r"&#x0*?24;", "$", txt)
        txt = re.sub(r"&#0*?36;", "$", txt)
        txt = re.sub(r"&dollar;", "$", txt)

        # "U+00025", "PERCENT SIGN"
        txt = re.sub(r"&#x0*?25;", "%", txt)
        txt = re.sub(r"&#0*?37;", "%", txt)
        txt = re.sub(r"&percnt;", "%", txt)

        # "U+00026", "AMPERSAND"
        txt = re.sub(r"&#x0*?26;", "&", txt)
        txt = re.sub(r"&#0*?38;", "&", txt)
        txt = re.sub(r"&amp;", "&", txt)
        txt = re.sub(r"&AMP;", "&", txt)

        # "U+00027", "APOSTROPHE"
        txt = re.sub(r"&#x0*?27;", "'", txt)
        txt = re.sub(r"&#0*?39;", "'", txt)
        txt = re.sub(r"&apos;", "'", txt)

        # "U+00028", "LEFT PARENTHESIS"
        txt = re.sub(r"&#x0*?28;", "(", txt)
        txt = re.sub(r"&#0*?40;", "(", txt)
        txt = re.sub(r"&lpar;", "(", txt)

        # "U+00029", "RIGHT PARENTHESIS"
        txt = re.sub(r"&#x0*?29;", ")", txt)
        txt = re.sub(r"&#0*?41;", ")", txt)
        txt = re.sub(r"&rpar;", ")", txt)

        # "U+0002A", "ASTERISK"
        txt = re.sub(r"&#x0*?2A;", "*", txt)
        txt = re.sub(r"&#0*?42;", "*", txt)
        txt = re.sub(r"&ast;", "*", txt)
        txt = re.sub(r"&midast;", "*", txt)

        # "U+0002B", "PLUS SIGN"
        txt = re.sub(r"&#x0*?2B;", "+", txt)
        txt = re.sub(r"&#0*?43;", "+", txt)
        txt = re.sub(r"&plus;", "+", txt)

        # "U+0002C", "COMMA"
        txt = re.sub(r"&#x0*?2C;", ",", txt)
        txt = re.sub(r"&#0*?44;", ",", txt)
        txt = re.sub(r"&comma;", ",", txt)

        # "U+0002E", "FULL STOP"
        txt = re.sub(r"&#x0*?2E;", ".", txt)
        txt = re.sub(r"&#0*?46;", ".", txt)
        txt = re.sub(r"&period;", ".", txt)

        # "U+0002F", "SOLIDUS"
        txt = re.sub(r"&#x0*?2F;", "/", txt)
        txt = re.sub(r"&#0*?47;", "/", txt)
        txt = re.sub(r"&sol;", "/", txt)

        # "U+0003A", "COLON"
        txt = re.sub(r"&#x0*?3A;", ":", txt)
        txt = re.sub(r"&#0*?58;", ":", txt)
        txt = re.sub(r"&colon;", ":", txt)

        # "U+0003B", "SEMICOLON"
        txt = re.sub(r"&#x0*?3B;", ";", txt)
        txt = re.sub(r"&#0*?59;", ";", txt)
        txt = re.sub(r"&semi;", ";", txt)

        # "U+0003C", "LESS-THAN SIGN"
        txt = re.sub(r"&#x0*?3C;", "<", txt)
        txt = re.sub(r"&#0*?60;", "<", txt)
        txt = re.sub(r"&lt;", "<", txt)
        txt = re.sub(r"&LT;", "<", txt)

        # "U+0003D", "EQUALS SIGN"
        txt = re.sub(r"&#x0*?3D;", "=", txt)
        txt = re.sub(r"&#0*?61;", "=", txt)
        txt = re.sub(r"&equals;", "=", txt)

        # "U+0003E", "GREATER-THAN SIGN"
        txt = re.sub(r"&#x0*?3E;", ">", txt)
        txt = re.sub(r"&#0*?62;", ">", txt)
        txt = re.sub(r"&gt;", ">", txt)
        txt = re.sub(r"&GT;", ">", txt)

        # "U+0003F", "QUESTION MARK"
        txt = re.sub(r"&#x0*?3F;", "?", txt)
        txt = re.sub(r"&#0*?63;", "?", txt)
        txt = re.sub(r"&quest;", "?", txt)

        # "U+00040", "COMMERCIAL AT"
        txt = re.sub(r"&#x0*?40;", "@", txt)
        txt = re.sub(r"&#0*?64;", "@", txt)
        txt = re.sub(r"&commat;", "@", txt)

        # "U+0005B", "LEFT SQUARE BRACKET"
        txt = re.sub(r"&#x0*?5B;", "[", txt)
        txt = re.sub(r"&#0*?91;", "[", txt)
        txt = re.sub(r"&lsqb;", "[", txt)
        txt = re.sub(r"&lbrack;", "[", txt)

        # "U+0005C", "REVERSE SOLIDUS"
        txt = re.sub(r"&#x0*?5C;", "\\", txt)
        txt = re.sub(r"&#0*?92;", "\\", txt)
        txt = re.sub(r"&bsol;", "\\", txt)

        # "U+0005D", "RIGHT SQUARE BRACKET"
        txt = re.sub(r"&#x0*?5D;", "]", txt)
        txt = re.sub(r"&#0*?93;", "]", txt)
        txt = re.sub(r"&rsqb;", "]", txt)
        txt = re.sub(r"&rbrack;", "]", txt)

        # "U+0005E", "CIRCUMFLEX ACCENT"
        txt = re.sub(r"&#x0*?5E;", "^", txt)
        txt = re.sub(r"&#0*?94;", "^", txt)
        txt = re.sub(r"&Hat;", "^", txt)

        # "U+0005F", "LOW LINE"
        txt = re.sub(r"&#x0*?5F;", "_", txt)
        txt = re.sub(r"&#0*?95;", "_", txt)
        txt = re.sub(r"&lowbar;", "_", txt)

        # "U+00060", "GRAVE ACCENT"
        txt = re.sub(r"&#x0*?60;", "`", txt)
        txt = re.sub(r"&#0*?96;", "`", txt)
        txt = re.sub(r"&grave;", "`", txt)
        txt = re.sub(r"&DiacriticalGrave;", "`", txt)

        # "U+0007B", "LEFT CURLY BRACKET"
        txt = re.sub(r"&#x0*?7B;", "", txt)
        txt = re.sub(r"&#0*?123;", "", txt)
        txt = re.sub(r"&lcub;", "", txt)
        txt = re.sub(r"&lbrace;", "", txt)

        # "U+0007C", "VERTICAL LINE"
        txt = re.sub(r"&#x0*?7C;", "|", txt)
        txt = re.sub(r"&#0*?124;", "|", txt)
        txt = re.sub(r"&verbar;", "|", txt)
        txt = re.sub(r"&vert;", "|", txt)
        txt = re.sub(r"&VerticalLine;", "|", txt)

        # "U+0007D", "RIGHT CURLY BRACKET"
        txt = re.sub(r"&#x0*?7D;", "", txt)
        txt = re.sub(r"&#0*?125;", "", txt)
        txt = re.sub(r"&rcub;", "", txt)
        txt = re.sub(r"&rbrace;", "", txt)

        # "U+000A0", "NO-BREAK SPACE"
        txt = re.sub(r"&#x0*?A0;", " ", txt)
        txt = re.sub(r"&#0*?160;", " ", txt)
        txt = re.sub(r"&nbsp;", " ", txt)
        txt = re.sub(r"&NonBreakingSpace;", " ", txt)

        # "U+000A1", "INVERTED EXCLAMATION MARK"
        txt = re.sub(r"&#x0*?A1;", "¡", txt)
        txt = re.sub(r"&#0*?161;", "¡", txt)
        txt = re.sub(r"&iexcl;", "¡", txt)

        # "U+000A2", "CENT SIGN"
        txt = re.sub(r"&#x0*?A2;", "¢", txt)
        txt = re.sub(r"&#0*?162;", "¢", txt)
        txt = re.sub(r"&cent;", "¢", txt)

        # "U+000A3", "POUND SIGN"
        txt = re.sub(r"&#x0*?A3;", "£", txt)
        txt = re.sub(r"&#0*?163;", "£", txt)
        txt = re.sub(r"&pound;", "£", txt)

        # "U+000A4", "CURRENCY SIGN"
        txt = re.sub(r"&#x0*?A4;", "¤", txt)
        txt = re.sub(r"&#0*?164;", "¤", txt)
        txt = re.sub(r"&curren;", "¤", txt)

        # "U+000A5", "YEN SIGN"
        txt = re.sub(r"&#x0*?A5;", "¥", txt)
        txt = re.sub(r"&#0*?165;", "¥", txt)
        txt = re.sub(r"&yen;", "¥", txt)

        # "U+000A6", "BROKEN BAR"
        txt = re.sub(r"&#x0*?A6;", "¦", txt)
        txt = re.sub(r"&#0*?166;", "¦", txt)
        txt = re.sub(r"&brvbar;", "¦", txt)

        # "U+000A7", "SECTION SIGN"
        txt = re.sub(r"&#x0*?A7;", "§", txt)
        txt = re.sub(r"&#0*?167;", "§", txt)
        txt = re.sub(r"&sect;", "§", txt)

        # "U+000A8", "DIAERESIS"
        txt = re.sub(r"&#x0*?A8;", "¨", txt)
        txt = re.sub(r"&#0*?168;", "¨", txt)
        txt = re.sub(r"&Dot;", "¨", txt)
        txt = re.sub(r"&die;", "¨", txt)
        txt = re.sub(r"&DoubleDot;", "¨", txt)
        txt = re.sub(r"&uml;", "¨", txt)

        # "U+000A9", "COPYRIGHT SIGN"
        txt = re.sub(r"&#x0*?A9;", "©", txt)
        txt = re.sub(r"&#0*?169;", "©", txt)
        txt = re.sub(r"&copy;", "©", txt)
        txt = re.sub(r"&COPY;", "©", txt)

        # "U+000AA", "FEMININE ORDINAL INDICATOR"
        txt = re.sub(r"&#x0*?AA;", "ª", txt)
        txt = re.sub(r"&#0*?170;", "ª", txt)
        txt = re.sub(r"&ordf;", "ª", txt)

        # "U+000AB", "LEFT-POINTING DOUBLE ANGLE QUOTATION MARK"
        txt = re.sub(r"&#x0*?AB;", "«", txt)
        txt = re.sub(r"&#0*?171;", "«", txt)
        txt = re.sub(r"&laquo;", "«", txt)

        # "U+000AC", "NOT SIGN"
        txt = re.sub(r"&#x0*?AC;", "¬", txt)
        txt = re.sub(r"&#0*?172;", "¬", txt)
        txt = re.sub(r"&not;", "¬", txt)

        # "U+000AD", "SOFT HYPHEN"
        txt = re.sub(r"&#x0*?AD;", "­", txt)
        txt = re.sub(r"&#0*?173;", "­", txt)
        txt = re.sub(r"&shy;", "­", txt)

        # "U+000AE", "REGISTERED SIGN"
        txt = re.sub(r"&#x0*?AE;", "®", txt)
        txt = re.sub(r"&#0*?174;", "®", txt)
        txt = re.sub(r"&reg;", "®", txt)
        txt = re.sub(r"&circledR;", "®", txt)
        txt = re.sub(r"&REG;", "®", txt)

        # "U+000AF", "MACRON"
        txt = re.sub(r"&#x0*?AF;", "¯", txt)
        txt = re.sub(r"&#0*?175;", "¯", txt)
        txt = re.sub(r"&macr;", "¯", txt)
        txt = re.sub(r"&OverBar;", "¯", txt)
        txt = re.sub(r"&strns;", "¯", txt)

        # "U+000B0", "DEGREE SIGN"
        txt = re.sub(r"&#x0*?B0;", "°", txt)
        txt = re.sub(r"&#0*?176;", "°", txt)
        txt = re.sub(r"&deg;", "°", txt)

        # "U+000B1", "PLUS-MINUS SIGN"
        txt = re.sub(r"&#x0*?B1;", "±", txt)
        txt = re.sub(r"&#0*?177;", "±", txt)
        txt = re.sub(r"&plusmn;", "±", txt)
        txt = re.sub(r"&pm;", "±", txt)
        txt = re.sub(r"&PlusMinus;", "±", txt)

        # "U+000B2", "SUPERSCRIPT TWO"
        txt = re.sub(r"&#x0*?B2;", "²", txt)
        txt = re.sub(r"&#0*?178;", "²", txt)
        txt = re.sub(r"&sup2;", "²", txt)

        # "U+000B3", "SUPERSCRIPT THREE"
        txt = re.sub(r"&#x0*?B3;", "³", txt)
        txt = re.sub(r"&#0*?179;", "³", txt)
        txt = re.sub(r"&sup3;", "³", txt)

        # "U+000B4", "ACUTE ACCENT"
        txt = re.sub(r"&#x0*?B4;", "´", txt)
        txt = re.sub(r"&#0*?180;", "´", txt)
        txt = re.sub(r"&acute;", "´", txt)
        txt = re.sub(r"&DiacriticalAcute;", "´", txt)

        # "U+000B5", "MICRO SIGN"
        txt = re.sub(r"&#x0*?B5;", "µ", txt)
        txt = re.sub(r"&#0*?181;", "µ", txt)
        txt = re.sub(r"&micro;", "µ", txt)

        # "U+000B6", "PILCROW SIGN"
        txt = re.sub(r"&#x0*?B6;", "¶", txt)
        txt = re.sub(r"&#0*?182;", "¶", txt)
        txt = re.sub(r"&para;", "¶", txt)

        # "U+000B7", "MIDDLE DOT"
        txt = re.sub(r"&#x0*?B7;", "·", txt)
        txt = re.sub(r"&#0*?183;", "·", txt)
        txt = re.sub(r"&middot;", "·", txt)
        txt = re.sub(r"&centerdot;", "·", txt)
        txt = re.sub(r"&CenterDot;", "·", txt)

        # "U+000B8", "CEDILLA"
        txt = re.sub(r"&#x0*?B8;", "¸", txt)
        txt = re.sub(r"&#0*?184;", "¸", txt)
        txt = re.sub(r"&cedil;", "¸", txt)
        txt = re.sub(r"&Cedilla;", "¸", txt)

        # "U+000B9", "SUPERSCRIPT ONE"
        txt = re.sub(r"&#x0*?B9;", "¹", txt)
        txt = re.sub(r"&#0*?185;", "¹", txt)
        txt = re.sub(r"&sup1;", "¹", txt)

        # "U+000BA", "MASCULINE ORDINAL INDICATOR"
        txt = re.sub(r"&#x0*?BA;", "º", txt)
        txt = re.sub(r"&#0*?186;", "º", txt)
        txt = re.sub(r"&ordm;", "º", txt)

        # "U+000BB", "RIGHT-POINTING DOUBLE ANGLE QUOTATION MARK"
        txt = re.sub(r"&#x0*?BB;", "»", txt)
        txt = re.sub(r"&#0*?187;", "»", txt)
        txt = re.sub(r"&raquo;", "»", txt)

        # "U+000BC", "VULGAR FRACTION ONE QUARTER"
        txt = re.sub(r"&#x0*?BC;", "¼", txt)
        txt = re.sub(r"&#0*?188;", "¼", txt)
        txt = re.sub(r"&frac14;", "¼", txt)

        # "U+000BD", "VULGAR FRACTION ONE HALF"
        txt = re.sub(r"&#x0*?BD;", "½", txt)
        txt = re.sub(r"&#0*?189;", "½", txt)
        txt = re.sub(r"&frac12;", "½", txt)
        txt = re.sub(r"&half;", "½", txt)

        # "U+000BE", "VULGAR FRACTION THREE QUARTERS"
        txt = re.sub(r"&#x0*?BE;", "¾", txt)
        txt = re.sub(r"&#0*?190;", "¾", txt)
        txt = re.sub(r"&frac34;", "¾", txt)

        # "U+000BF", "INVERTED QUESTION MARK"
        txt = re.sub(r"&#x0*?BF;", "¿", txt)
        txt = re.sub(r"&#0*?191;", "¿", txt)
        txt = re.sub(r"&iquest;", "¿", txt)

        # "U+000C0", "LATIN CAPITAL LETTER A WITH GRAVE"
        txt = re.sub(r"&#x0*?C0;", "À", txt)
        txt = re.sub(r"&#0*?192;", "À", txt)
        txt = re.sub(r"&Agrave;", "À", txt)

        # "U+000C1", "LATIN CAPITAL LETTER A WITH ACUTE"
        txt = re.sub(r"&#x0*?C1;", "Á", txt)
        txt = re.sub(r"&#0*?193;", "Á", txt)
        txt = re.sub(r"&Aacute;", "Á", txt)

        # "U+000C2", "LATIN CAPITAL LETTER A WITH CIRCUMFLEX"
        txt = re.sub(r"&#x0*?C2;", "Â", txt)
        txt = re.sub(r"&#0*?194;", "Â", txt)
        txt = re.sub(r"&Acirc;", "Â", txt)

        # "U+000C3", "LATIN CAPITAL LETTER A WITH TILDE"
        txt = re.sub(r"&#x0*?C3;", "Ã", txt)
        txt = re.sub(r"&#0*?195;", "Ã", txt)
        txt = re.sub(r"&Atilde;", "Ã", txt)

        # "U+000C4", "LATIN CAPITAL LETTER A WITH DIAERESIS"
        txt = re.sub(r"&#x0*?C4;", "Ä", txt)
        txt = re.sub(r"&#0*?196;", "Ä", txt)
        txt = re.sub(r"&Auml;", "Ä", txt)

        # "U+000C5", "LATIN CAPITAL LETTER A WITH RING ABOVE"
        txt = re.sub(r"&#x0*?C5;", "Å", txt)
        txt = re.sub(r"&#0*?197;", "Å", txt)
        txt = re.sub(r"&Aring;", "Å", txt)

        # "U+000C6", "LATIN CAPITAL LETTER AE"
        txt = re.sub(r"&#x0*?C6;", "Æ", txt)
        txt = re.sub(r"&#0*?198;", "Æ", txt)
        txt = re.sub(r"&AElig;", "Æ", txt)

        # "U+000C7", "LATIN CAPITAL LETTER C WITH CEDILLA"
        txt = re.sub(r"&#x0*?C7;", "Ç", txt)
        txt = re.sub(r"&#0*?199;", "Ç", txt)
        txt = re.sub(r"&Ccedil;", "Ç", txt)

        # "U+000C8", "LATIN CAPITAL LETTER E WITH GRAVE"
        txt = re.sub(r"&#x0*?C8;", "È", txt)
        txt = re.sub(r"&#0*?200;", "È", txt)
        txt = re.sub(r"&Egrave;", "È", txt)

        # "U+000C9", "LATIN CAPITAL LETTER E WITH ACUTE"
        txt = re.sub(r"&#x0*?C9;", "É", txt)
        txt = re.sub(r"&#0*?201;", "É", txt)
        txt = re.sub(r"&Eacute;", "É", txt)

        # "U+000CA", "LATIN CAPITAL LETTER E WITH CIRCUMFLEX"
        txt = re.sub(r"&#x0*?CA;", "Ê", txt)
        txt = re.sub(r"&#0*?202;", "Ê", txt)
        txt = re.sub(r"&Ecirc;", "Ê", txt)

        # "U+000CB", "LATIN CAPITAL LETTER E WITH DIAERESIS"
        txt = re.sub(r"&#x0*?CB;", "Ë", txt)
        txt = re.sub(r"&#0*?203;", "Ë", txt)
        txt = re.sub(r"&Euml;", "Ë", txt)

        # "U+000CC", "LATIN CAPITAL LETTER I WITH GRAVE"
        txt = re.sub(r"&#x0*?CC;", "Ì", txt)
        txt = re.sub(r"&#0*?204;", "Ì", txt)
        txt = re.sub(r"&Igrave;", "Ì", txt)

        # "U+000CD", "LATIN CAPITAL LETTER I WITH ACUTE"
        txt = re.sub(r"&#x0*?CD;", "Í", txt)
        txt = re.sub(r"&#0*?205;", "Í", txt)
        txt = re.sub(r"&Iacute;", "Í", txt)

        # "U+000CE", "LATIN CAPITAL LETTER I WITH CIRCUMFLEX"
        txt = re.sub(r"&#x0*?CE;", "Î", txt)
        txt = re.sub(r"&#0*?206;", "Î", txt)
        txt = re.sub(r"&Icirc;", "Î", txt)

        # "U+000CF", "LATIN CAPITAL LETTER I WITH DIAERESIS"
        txt = re.sub(r"&#x0*?CF;", "Ï", txt)
        txt = re.sub(r"&#0*?207;", "Ï", txt)
        txt = re.sub(r"&Iuml;", "Ï", txt)

        # "U+000D0", "LATIN CAPITAL LETTER ETH"
        txt = re.sub(r"&#x0*?D0;", "Ð", txt)
        txt = re.sub(r"&#0*?208;", "Ð", txt)
        txt = re.sub(r"&ETH;", "Ð", txt)

        # "U+000D1", "LATIN CAPITAL LETTER N WITH TILDE"
        txt = re.sub(r"&#x0*?D1;", "Ñ", txt)
        txt = re.sub(r"&#0*?209;", "Ñ", txt)
        txt = re.sub(r"&Ntilde;", "Ñ", txt)

        # "U+000D2", "LATIN CAPITAL LETTER O WITH GRAVE"
        txt = re.sub(r"&#x0*?D2;", "Ò", txt)
        txt = re.sub(r"&#0*?210;", "Ò", txt)
        txt = re.sub(r"&Ograve;", "Ò", txt)

        # "U+000D3", "LATIN CAPITAL LETTER O WITH ACUTE"
        txt = re.sub(r"&#x0*?D3;", "Ó", txt)
        txt = re.sub(r"&#0*?211;", "Ó", txt)
        txt = re.sub(r"&Oacute;", "Ó", txt)

        # "U+000D4", "LATIN CAPITAL LETTER O WITH CIRCUMFLEX"
        txt = re.sub(r"&#x0*?D4;", "Ô", txt)
        txt = re.sub(r"&#0*?212;", "Ô", txt)
        txt = re.sub(r"&Ocirc;", "Ô", txt)

        # "U+000D5", "LATIN CAPITAL LETTER O WITH TILDE"
        txt = re.sub(r"&#x0*?D5;", "Õ", txt)
        txt = re.sub(r"&#0*?213;", "Õ", txt)
        txt = re.sub(r"&Otilde;", "Õ", txt)

        # "U+000D6", "LATIN CAPITAL LETTER O WITH DIAERESIS"
        txt = re.sub(r"&#x0*?D6;", "Ö", txt)
        txt = re.sub(r"&#0*?214;", "Ö", txt)
        txt = re.sub(r"&Ouml;", "Ö", txt)

        # "U+000D7", "MULTIPLICATION SIGN"
        txt = re.sub(r"&#x0*?D7;", "×", txt)
        txt = re.sub(r"&#0*?215;", "×", txt)
        txt = re.sub(r"&times;", "×", txt)

        # "U+000D8", "LATIN CAPITAL LETTER O WITH STROKE"
        txt = re.sub(r"&#x0*?D8;", "Ø", txt)
        txt = re.sub(r"&#0*?216;", "Ø", txt)
        txt = re.sub(r"&Oslash;", "Ø", txt)

        # "U+000D9", "LATIN CAPITAL LETTER U WITH GRAVE"
        txt = re.sub(r"&#x0*?D9;", "Ù", txt)
        txt = re.sub(r"&#0*?217;", "Ù", txt)
        txt = re.sub(r"&Ugrave;", "Ù", txt)

        # "U+000DA", "LATIN CAPITAL LETTER U WITH ACUTE"
        txt = re.sub(r"&#x0*?DA;", "Ú", txt)
        txt = re.sub(r"&#0*?218;", "Ú", txt)
        txt = re.sub(r"&Uacute;", "Ú", txt)

        # "U+000DB", "LATIN CAPITAL LETTER U WITH CIRCUMFLEX"
        txt = re.sub(r"&#x0*?DB;", "Û", txt)
        txt = re.sub(r"&#0*?219;", "Û", txt)
        txt = re.sub(r"&Ucirc;", "Û", txt)

        # "U+000DC", "LATIN CAPITAL LETTER U WITH DIAERESIS"
        txt = re.sub(r"&#x0*?DC;", "Ü", txt)
        txt = re.sub(r"&#0*?220;", "Ü", txt)
        txt = re.sub(r"&Uuml;", "Ü", txt)

        # "U+000DD", "LATIN CAPITAL LETTER Y WITH ACUTE"
        txt = re.sub(r"&#x0*?DD;", "Ý", txt)
        txt = re.sub(r"&#0*?221;", "Ý", txt)
        txt = re.sub(r"&Yacute;", "Ý", txt)

        # "U+000DE", "LATIN CAPITAL LETTER THORN"
        txt = re.sub(r"&#x0*?DE;", "Þ", txt)
        txt = re.sub(r"&#0*?222;", "Þ", txt)
        txt = re.sub(r"&THORN;", "Þ", txt)

        # "U+000DF", "LATIN SMALL LETTER SHARP S"
        txt = re.sub(r"&#x0*?DF;", "ß", txt)
        txt = re.sub(r"&#0*?223;", "ß", txt)
        txt = re.sub(r"&szlig;", "ß", txt)

        # "U+000E0", "LATIN SMALL LETTER A WITH GRAVE"
        txt = re.sub(r"&#x0*?E0;", "à", txt)
        txt = re.sub(r"&#0*?224;", "à", txt)
        txt = re.sub(r"&agrave;", "à", txt)

        # "U+000E1", "LATIN SMALL LETTER A WITH ACUTE"
        txt = re.sub(r"&#x0*?E1;", "á", txt)
        txt = re.sub(r"&#0*?225;", "á", txt)
        txt = re.sub(r"&aacute;", "á", txt)

        # "U+000E2", "LATIN SMALL LETTER A WITH CIRCUMFLEX"
        txt = re.sub(r"&#x0*?E2;", "â", txt)
        txt = re.sub(r"&#0*?226;", "â", txt)
        txt = re.sub(r"&acirc;", "â", txt)

        # "U+000E3", "LATIN SMALL LETTER A WITH TILDE"
        txt = re.sub(r"&#x0*?E3;", "ã", txt)
        txt = re.sub(r"&#0*?227;", "ã", txt)
        txt = re.sub(r"&atilde;", "ã", txt)

        # "U+000E4", "LATIN SMALL LETTER A WITH DIAERESIS"
        txt = re.sub(r"&#x0*?E4;", "ä", txt)
        txt = re.sub(r"&#0*?228;", "ä", txt)
        txt = re.sub(r"&auml;", "ä", txt)

        # "U+000E5", "LATIN SMALL LETTER A WITH RING ABOVE"
        txt = re.sub(r"&#x0*?E5;", "å", txt)
        txt = re.sub(r"&#0*?229;", "å", txt)
        txt = re.sub(r"&aring;", "å", txt)

        # "U+000E6", "LATIN SMALL LETTER AE"
        txt = re.sub(r"&#x0*?E6;", "æ", txt)
        txt = re.sub(r"&#0*?230;", "æ", txt)
        txt = re.sub(r"&aelig;", "æ", txt)

        # "U+000E7", "LATIN SMALL LETTER C WITH CEDILLA"
        txt = re.sub(r"&#x0*?E7;", "ç", txt)
        txt = re.sub(r"&#0*?231;", "ç", txt)
        txt = re.sub(r"&ccedil;", "ç", txt)

        # "U+000E8", "LATIN SMALL LETTER E WITH GRAVE"
        txt = re.sub(r"&#x0*?E8;", "è", txt)
        txt = re.sub(r"&#0*?232;", "è", txt)
        txt = re.sub(r"&egrave;", "è", txt)

        # "U+000E9", "LATIN SMALL LETTER E WITH ACUTE"
        txt = re.sub(r"&#x0*?E9;", "é", txt)
        txt = re.sub(r"&#0*?233;", "é", txt)
        txt = re.sub(r"&eacute;", "é", txt)

        # "U+000EA", "LATIN SMALL LETTER E WITH CIRCUMFLEX"
        txt = re.sub(r"&#x0*?EA;", "ê", txt)
        txt = re.sub(r"&#0*?234;", "ê", txt)
        txt = re.sub(r"&ecirc;", "ê", txt)

        # "U+000EB", "LATIN SMALL LETTER E WITH DIAERESIS"
        txt = re.sub(r"&#x0*?EB;", "ë", txt)
        txt = re.sub(r"&#0*?235;", "ë", txt)
        txt = re.sub(r"&euml;", "ë", txt)

        # "U+000EC", "LATIN SMALL LETTER I WITH GRAVE"
        txt = re.sub(r"&#x0*?EC;", "ì", txt)
        txt = re.sub(r"&#0*?236;", "ì", txt)
        txt = re.sub(r"&igrave;", "ì", txt)

        # "U+000ED", "LATIN SMALL LETTER I WITH ACUTE"
        txt = re.sub(r"&#x0*?ED;", "í", txt)
        txt = re.sub(r"&#0*?237;", "í", txt)
        txt = re.sub(r"&iacute;", "í", txt)

        # "U+000EE", "LATIN SMALL LETTER I WITH CIRCUMFLEX"
        txt = re.sub(r"&#x0*?EE;", "î", txt)
        txt = re.sub(r"&#0*?238;", "î", txt)
        txt = re.sub(r"&icirc;", "î", txt)

        # "U+000EF", "LATIN SMALL LETTER I WITH DIAERESIS"
        txt = re.sub(r"&#x0*?EF;", "ï", txt)
        txt = re.sub(r"&#0*?239;", "ï", txt)
        txt = re.sub(r"&iuml;", "ï", txt)

        # "U+000F0", "LATIN SMALL LETTER ETH"
        txt = re.sub(r"&#x0*?F0;", "ð", txt)
        txt = re.sub(r"&#0*?240;", "ð", txt)
        txt = re.sub(r"&eth;", "ð", txt)

        # "U+000F1", "LATIN SMALL LETTER N WITH TILDE"
        txt = re.sub(r"&#x0*?F1;", "ñ", txt)
        txt = re.sub(r"&#0*?241;", "ñ", txt)
        txt = re.sub(r"&ntilde;", "ñ", txt)

        # "U+000F2", "LATIN SMALL LETTER O WITH GRAVE"
        txt = re.sub(r"&#x0*?F2;", "ò", txt)
        txt = re.sub(r"&#0*?242;", "ò", txt)
        txt = re.sub(r"&ograve;", "ò", txt)

        # "U+000F3", "LATIN SMALL LETTER O WITH ACUTE"
        txt = re.sub(r"&#x0*?F3;", "ó", txt)
        txt = re.sub(r"&#0*?243;", "ó", txt)
        txt = re.sub(r"&oacute;", "ó", txt)

        # "U+000F4", "LATIN SMALL LETTER O WITH CIRCUMFLEX"
        txt = re.sub(r"&#x0*?F4;", "ô", txt)
        txt = re.sub(r"&#0*?244;", "ô", txt)
        txt = re.sub(r"&ocirc;", "ô", txt)

        # "U+000F5", "LATIN SMALL LETTER O WITH TILDE"
        txt = re.sub(r"&#x0*?F5;", "õ", txt)
        txt = re.sub(r"&#0*?245;", "õ", txt)
        txt = re.sub(r"&otilde;", "õ", txt)

        # "U+000F6", "LATIN SMALL LETTER O WITH DIAERESIS"
        txt = re.sub(r"&#x0*?F6;", "ö", txt)
        txt = re.sub(r"&#0*?246;", "ö", txt)
        txt = re.sub(r"&ouml;", "ö", txt)

        # "U+000F7", "DIVISION SIGN"
        txt = re.sub(r"&#x0*?F7;", "÷", txt)
        txt = re.sub(r"&#0*?247;", "÷", txt)
        txt = re.sub(r"&divide;", "÷", txt)
        txt = re.sub(r"&div;", "÷", txt)

        # "U+000F8", "LATIN SMALL LETTER O WITH STROKE"
        txt = re.sub(r"&#x0*?F8;", "ø", txt)
        txt = re.sub(r"&#0*?248;", "ø", txt)
        txt = re.sub(r"&oslash;", "ø", txt)

        # "U+000F9", "LATIN SMALL LETTER U WITH GRAVE"
        txt = re.sub(r"&#x0*?F9;", "ù", txt)
        txt = re.sub(r"&#0*?249;", "ù", txt)
        txt = re.sub(r"&ugrave;", "ù", txt)

        # "U+000FA", "LATIN SMALL LETTER U WITH ACUTE"
        txt = re.sub(r"&#x0*?FA;", "ú", txt)
        txt = re.sub(r"&#0*?250;", "ú", txt)
        txt = re.sub(r"&uacute;", "ú", txt)

        # "U+000FB", "LATIN SMALL LETTER U WITH CIRCUMFLEX"
        txt = re.sub(r"&#x0*?FB;", "û", txt)
        txt = re.sub(r"&#0*?251;", "û", txt)
        txt = re.sub(r"&ucirc;", "û", txt)

        # "U+000FC", "LATIN SMALL LETTER U WITH DIAERESIS"
        txt = re.sub(r"&#x0*?FC;", "ü", txt)
        txt = re.sub(r"&#0*?252;", "ü", txt)
        txt = re.sub(r"&uuml;", "ü", txt)

        # "U+000FD", "LATIN SMALL LETTER Y WITH ACUTE"
        txt = re.sub(r"&#x0*?FD;", "ý", txt)
        txt = re.sub(r"&#0*?253;", "ý", txt)
        txt = re.sub(r"&yacute;", "ý", txt)

        # "U+000FE", "LATIN SMALL LETTER THORN"
        txt = re.sub(r"&#x0*?FE;", "þ", txt)
        txt = re.sub(r"&#0*?254;", "þ", txt)
        txt = re.sub(r"&thorn;", "þ", txt)

        # "U+000FF", "LATIN SMALL LETTER Y WITH DIAERESIS"
        txt = re.sub(r"&#x0*?FF;", "ÿ", txt)
        txt = re.sub(r"&#0*?255;", "ÿ", txt)
        txt = re.sub(r"&yuml;", "ÿ", txt)

        # "U+00100", "LATIN CAPITAL LETTER A WITH MACRON"
        txt = re.sub(r"&#x0*?100;", "Ā", txt)
        txt = re.sub(r"&#0*?256;", "Ā", txt)
        txt = re.sub(r"&Amacr;", "Ā", txt)

        # "U+00101", "LATIN SMALL LETTER A WITH MACRON"
        txt = re.sub(r"&#x0*?101;", "ā", txt)
        txt = re.sub(r"&#0*?257;", "ā", txt)
        txt = re.sub(r"&amacr;", "ā", txt)

        # "U+00102", "LATIN CAPITAL LETTER A WITH BREVE"
        txt = re.sub(r"&#x0*?102;", "Ă", txt)
        txt = re.sub(r"&#0*?258;", "Ă", txt)
        txt = re.sub(r"&Abreve;", "Ă", txt)

        # "U+00103", "LATIN SMALL LETTER A WITH BREVE"
        txt = re.sub(r"&#x0*?103;", "ă", txt)
        txt = re.sub(r"&#0*?259;", "ă", txt)
        txt = re.sub(r"&abreve;", "ă", txt)

        # "U+00104", "LATIN CAPITAL LETTER A WITH OGONEK"
        txt = re.sub(r"&#x0*?104;", "Ą", txt)
        txt = re.sub(r"&#0*?260;", "Ą", txt)
        txt = re.sub(r"&Aogon;", "Ą", txt)

        # "U+00105", "LATIN SMALL LETTER A WITH OGONEK"
        txt = re.sub(r"&#x0*?105;", "ą", txt)
        txt = re.sub(r"&#0*?261;", "ą", txt)
        txt = re.sub(r"&aogon;", "ą", txt)

        # "U+00106", "LATIN CAPITAL LETTER C WITH ACUTE"
        txt = re.sub(r"&#x0*?106;", "Ć", txt)
        txt = re.sub(r"&#0*?262;", "Ć", txt)
        txt = re.sub(r"&Cacute;", "Ć", txt)

        # "U+00107", "LATIN SMALL LETTER C WITH ACUTE"
        txt = re.sub(r"&#x0*?107;", "ć", txt)
        txt = re.sub(r"&#0*?263;", "ć", txt)
        txt = re.sub(r"&cacute;", "ć", txt)

        # "U+00108", "LATIN CAPITAL LETTER C WITH CIRCUMFLEX"
        txt = re.sub(r"&#x0*?108;", "Ĉ", txt)
        txt = re.sub(r"&#0*?264;", "Ĉ", txt)
        txt = re.sub(r"&Ccirc;", "Ĉ", txt)

        # "U+00109", "LATIN SMALL LETTER C WITH CIRCUMFLEX"
        txt = re.sub(r"&#x0*?109;", "ĉ", txt)
        txt = re.sub(r"&#0*?265;", "ĉ", txt)
        txt = re.sub(r"&ccirc;", "ĉ", txt)

        # "U+0010A", "LATIN CAPITAL LETTER C WITH DOT ABOVE"
        txt = re.sub(r"&#x0*?10A;", "Ċ", txt)
        txt = re.sub(r"&#0*?266;", "Ċ", txt)
        txt = re.sub(r"&Cdot;", "Ċ", txt)

        # "U+0010B", "LATIN SMALL LETTER C WITH DOT ABOVE"
        txt = re.sub(r"&#x0*?10B;", "ċ", txt)
        txt = re.sub(r"&#0*?267;", "ċ", txt)
        txt = re.sub(r"&cdot;", "ċ", txt)

        # "U+0010C", "LATIN CAPITAL LETTER C WITH CARON"
        txt = re.sub(r"&#x0*?10C;", "Č", txt)
        txt = re.sub(r"&#0*?268;", "Č", txt)
        txt = re.sub(r"&Ccaron;", "Č", txt)

        # "U+0010D", "LATIN SMALL LETTER C WITH CARON"
        txt = re.sub(r"&#x0*?10D;", "č", txt)
        txt = re.sub(r"&#0*?269;", "č", txt)
        txt = re.sub(r"&ccaron;", "č", txt)

        # "U+0010E", "LATIN CAPITAL LETTER D WITH CARON"
        txt = re.sub(r"&#x0*?10E;", "Ď", txt)
        txt = re.sub(r"&#0*?270;", "Ď", txt)
        txt = re.sub(r"&Dcaron;", "Ď", txt)

        # "U+0010F", "LATIN SMALL LETTER D WITH CARON"
        txt = re.sub(r"&#x0*?10F;", "ď", txt)
        txt = re.sub(r"&#0*?271;", "ď", txt)
        txt = re.sub(r"&dcaron;", "ď", txt)

        # "U+00110", "LATIN CAPITAL LETTER D WITH STROKE"
        txt = re.sub(r"&#x0*?110;", "Đ", txt)
        txt = re.sub(r"&#0*?272;", "Đ", txt)
        txt = re.sub(r"&Dstrok;", "Đ", txt)

        # "U+00111", "LATIN SMALL LETTER D WITH STROKE"
        txt = re.sub(r"&#x0*?111;", "đ", txt)
        txt = re.sub(r"&#0*?273;", "đ", txt)
        txt = re.sub(r"&dstrok;", "đ", txt)

        # "U+00112", "LATIN CAPITAL LETTER E WITH MACRON"
        txt = re.sub(r"&#x0*?112;", "Ē", txt)
        txt = re.sub(r"&#0*?274;", "Ē", txt)
        txt = re.sub(r"&Emacr;", "Ē", txt)

        # "U+00113", "LATIN SMALL LETTER E WITH MACRON"
        txt = re.sub(r"&#x0*?113;", "ē", txt)
        txt = re.sub(r"&#0*?275;", "ē", txt)
        txt = re.sub(r"&emacr;", "ē", txt)

        # "U+00116", "LATIN CAPITAL LETTER E WITH DOT ABOVE"
        txt = re.sub(r"&#x0*?116;", "Ė", txt)
        txt = re.sub(r"&#0*?278;", "Ė", txt)
        txt = re.sub(r"&Edot;", "Ė", txt)

        # "U+00117", "LATIN SMALL LETTER E WITH DOT ABOVE"
        txt = re.sub(r"&#x0*?117;", "ė", txt)
        txt = re.sub(r"&#0*?279;", "ė", txt)
        txt = re.sub(r"&edot;", "ė", txt)

        # "U+00118", "LATIN CAPITAL LETTER E WITH OGONEK"
        txt = re.sub(r"&#x0*?118;", "Ę", txt)
        txt = re.sub(r"&#0*?280;", "Ę", txt)
        txt = re.sub(r"&Eogon;", "Ę", txt)

        # "U+00119", "LATIN SMALL LETTER E WITH OGONEK"
        txt = re.sub(r"&#x0*?119;", "ę", txt)
        txt = re.sub(r"&#0*?281;", "ę", txt)
        txt = re.sub(r"&eogon;", "ę", txt)

        # "U+0011A", "LATIN CAPITAL LETTER E WITH CARON"
        txt = re.sub(r"&#x0*?11A;", "Ě", txt)
        txt = re.sub(r"&#0*?282;", "Ě", txt)
        txt = re.sub(r"&Ecaron;", "Ě", txt)

        # "U+0011B", "LATIN SMALL LETTER E WITH CARON"
        txt = re.sub(r"&#x0*?11B;", "ě", txt)
        txt = re.sub(r"&#0*?283;", "ě", txt)
        txt = re.sub(r"&ecaron;", "ě", txt)

        # "U+0011C", "LATIN CAPITAL LETTER G WITH CIRCUMFLEX"
        txt = re.sub(r"&#x0*?11C;", "Ĝ", txt)
        txt = re.sub(r"&#0*?284;", "Ĝ", txt)
        txt = re.sub(r"&Gcirc;", "Ĝ", txt)

        # "U+0011D", "LATIN SMALL LETTER G WITH CIRCUMFLEX"
        txt = re.sub(r"&#x0*?11D;", "ĝ", txt)
        txt = re.sub(r"&#0*?285;", "ĝ", txt)
        txt = re.sub(r"&gcirc;", "ĝ", txt)

        # "U+0011E", "LATIN CAPITAL LETTER G WITH BREVE"
        txt = re.sub(r"&#x0*?11E;", "Ğ", txt)
        txt = re.sub(r"&#0*?286;", "Ğ", txt)
        txt = re.sub(r"&Gbreve;", "Ğ", txt)

        # "U+0011F", "LATIN SMALL LETTER G WITH BREVE"
        txt = re.sub(r"&#x0*?11F;", "ğ", txt)
        txt = re.sub(r"&#0*?287;", "ğ", txt)
        txt = re.sub(r"&gbreve;", "ğ", txt)

        # "U+00120", "LATIN CAPITAL LETTER G WITH DOT ABOVE"
        txt = re.sub(r"&#x0*?120;", "Ġ", txt)
        txt = re.sub(r"&#0*?288;", "Ġ", txt)
        txt = re.sub(r"&Gdot;", "Ġ", txt)

        # "U+00121", "LATIN SMALL LETTER G WITH DOT ABOVE"
        txt = re.sub(r"&#x0*?121;", "ġ", txt)
        txt = re.sub(r"&#0*?289;", "ġ", txt)
        txt = re.sub(r"&gdot;", "ġ", txt)

        # "U+00122", "LATIN CAPITAL LETTER G WITH CEDILLA"
        txt = re.sub(r"&#x0*?122;", "Ģ", txt)
        txt = re.sub(r"&#0*?290;", "Ģ", txt)
        txt = re.sub(r"&Gcedil;", "Ģ", txt)

        # "U+00124", "LATIN CAPITAL LETTER H WITH CIRCUMFLEX"
        txt = re.sub(r"&#x0*?124;", "Ĥ", txt)
        txt = re.sub(r"&#0*?292;", "Ĥ", txt)
        txt = re.sub(r"&Hcirc;", "Ĥ", txt)

        # "U+00125", "LATIN SMALL LETTER H WITH CIRCUMFLEX"
        txt = re.sub(r"&#x0*?125;", "ĥ", txt)
        txt = re.sub(r"&#0*?293;", "ĥ", txt)
        txt = re.sub(r"&hcirc;", "ĥ", txt)

        # "U+00126", "LATIN CAPITAL LETTER H WITH STROKE"
        txt = re.sub(r"&#x0*?126;", "Ħ", txt)
        txt = re.sub(r"&#0*?294;", "Ħ", txt)
        txt = re.sub(r"&Hstrok;", "Ħ", txt)

        # "U+00127", "LATIN SMALL LETTER H WITH STROKE"
        txt = re.sub(r"&#x0*?127;", "ħ", txt)
        txt = re.sub(r"&#0*?295;", "ħ", txt)
        txt = re.sub(r"&hstrok;", "ħ", txt)

        # "U+00128", "LATIN CAPITAL LETTER I WITH TILDE"
        txt = re.sub(r"&#x0*?128;", "Ĩ", txt)
        txt = re.sub(r"&#0*?296;", "Ĩ", txt)
        txt = re.sub(r"&Itilde;", "Ĩ", txt)

        # "U+00129", "LATIN SMALL LETTER I WITH TILDE"
        txt = re.sub(r"&#x0*?129;", "ĩ", txt)
        txt = re.sub(r"&#0*?297;", "ĩ", txt)
        txt = re.sub(r"&itilde;", "ĩ", txt)

        # "U+0012A", "LATIN CAPITAL LETTER I WITH MACRON"
        txt = re.sub(r"&#x0*?12A;", "Ī", txt)
        txt = re.sub(r"&#0*?298;", "Ī", txt)
        txt = re.sub(r"&Imacr;", "Ī", txt)

        # "U+0012B", "LATIN SMALL LETTER I WITH MACRON"
        txt = re.sub(r"&#x0*?12B;", "ī", txt)
        txt = re.sub(r"&#0*?299;", "ī", txt)
        txt = re.sub(r"&imacr;", "ī", txt)

        # "U+0012E", "LATIN CAPITAL LETTER I WITH OGONEK"
        txt = re.sub(r"&#x0*?12E;", "Į", txt)
        txt = re.sub(r"&#0*?302;", "Į", txt)
        txt = re.sub(r"&Iogon;", "Į", txt)

        # "U+0012F", "LATIN SMALL LETTER I WITH OGONEK"
        txt = re.sub(r"&#x0*?12F;", "į", txt)
        txt = re.sub(r"&#0*?303;", "į", txt)
        txt = re.sub(r"&iogon;", "į", txt)

        # "U+00130", "LATIN CAPITAL LETTER I WITH DOT ABOVE"
        txt = re.sub(r"&#x0*?130;", "İ", txt)
        txt = re.sub(r"&#0*?304;", "İ", txt)
        txt = re.sub(r"&Idot;", "İ", txt)

        # "U+00131", "LATIN SMALL LETTER DOTLESS I"
        txt = re.sub(r"&#x0*?131;", "ı", txt)
        txt = re.sub(r"&#0*?305;", "ı", txt)
        txt = re.sub(r"&imath;", "ı", txt)
        txt = re.sub(r"&inodot;", "ı", txt)

        # "U+00132", "LATIN CAPITAL LIGATURE IJ"
        txt = re.sub(r"&#x0*?132;", "Ĳ", txt)
        txt = re.sub(r"&#0*?306;", "Ĳ", txt)
        txt = re.sub(r"&IJlig;", "Ĳ", txt)

        # "U+00133", "LATIN SMALL LIGATURE IJ"
        txt = re.sub(r"&#x0*?133;", "ĳ", txt)
        txt = re.sub(r"&#0*?307;", "ĳ", txt)
        txt = re.sub(r"&ijlig;", "ĳ", txt)

        # "U+00134", "LATIN CAPITAL LETTER J WITH CIRCUMFLEX"
        txt = re.sub(r"&#x0*?134;", "Ĵ", txt)
        txt = re.sub(r"&#0*?308;", "Ĵ", txt)
        txt = re.sub(r"&Jcirc;", "Ĵ", txt)

        # "U+00135", "LATIN SMALL LETTER J WITH CIRCUMFLEX"
        txt = re.sub(r"&#x0*?135;", "ĵ", txt)
        txt = re.sub(r"&#0*?309;", "ĵ", txt)
        txt = re.sub(r"&jcirc;", "ĵ", txt)

        # "U+00136", "LATIN CAPITAL LETTER K WITH CEDILLA"
        txt = re.sub(r"&#x0*?136;", "Ķ", txt)
        txt = re.sub(r"&#0*?310;", "Ķ", txt)
        txt = re.sub(r"&Kcedil;", "Ķ", txt)

        # "U+00137", "LATIN SMALL LETTER K WITH CEDILLA"
        txt = re.sub(r"&#x0*?137;", "ķ", txt)
        txt = re.sub(r"&#0*?311;", "ķ", txt)
        txt = re.sub(r"&kcedil;", "ķ", txt)

        # "U+00138", "LATIN SMALL LETTER KRA"
        txt = re.sub(r"&#x0*?138;", "ĸ", txt)
        txt = re.sub(r"&#0*?312;", "ĸ", txt)
        txt = re.sub(r"&kgreen;", "ĸ", txt)

        # "U+00139", "LATIN CAPITAL LETTER L WITH ACUTE"
        txt = re.sub(r"&#x0*?139;", "Ĺ", txt)
        txt = re.sub(r"&#0*?313;", "Ĺ", txt)
        txt = re.sub(r"&Lacute;", "Ĺ", txt)

        # "U+0013A", "LATIN SMALL LETTER L WITH ACUTE"
        txt = re.sub(r"&#x0*?13A;", "ĺ", txt)
        txt = re.sub(r"&#0*?314;", "ĺ", txt)
        txt = re.sub(r"&lacute;", "ĺ", txt)

        # "U+0013B", "LATIN CAPITAL LETTER L WITH CEDILLA"
        txt = re.sub(r"&#x0*?13B;", "Ļ", txt)
        txt = re.sub(r"&#0*?315;", "Ļ", txt)
        txt = re.sub(r"&Lcedil;", "Ļ", txt)

        # "U+0013C", "LATIN SMALL LETTER L WITH CEDILLA"
        txt = re.sub(r"&#x0*?13C;", "ļ", txt)
        txt = re.sub(r"&#0*?316;", "ļ", txt)
        txt = re.sub(r"&lcedil;", "ļ", txt)

        # "U+0013D", "LATIN CAPITAL LETTER L WITH CARON"
        txt = re.sub(r"&#x0*?13D;", "Ľ", txt)
        txt = re.sub(r"&#0*?317;", "Ľ", txt)
        txt = re.sub(r"&Lcaron;", "Ľ", txt)

        # "U+0013E", "LATIN SMALL LETTER L WITH CARON"
        txt = re.sub(r"&#x0*?13E;", "ľ", txt)
        txt = re.sub(r"&#0*?318;", "ľ", txt)
        txt = re.sub(r"&lcaron;", "ľ", txt)

        # "U+0013F", "LATIN CAPITAL LETTER L WITH MIDDLE DOT"
        txt = re.sub(r"&#x0*?13F;", "Ŀ", txt)
        txt = re.sub(r"&#0*?319;", "Ŀ", txt)
        txt = re.sub(r"&Lmidot;", "Ŀ", txt)

        # "U+00140", "LATIN SMALL LETTER L WITH MIDDLE DOT"
        txt = re.sub(r"&#x0*?140;", "ŀ", txt)
        txt = re.sub(r"&#0*?320;", "ŀ", txt)
        txt = re.sub(r"&lmidot;", "ŀ", txt)

        # "U+00141", "LATIN CAPITAL LETTER L WITH STROKE"
        txt = re.sub(r"&#x0*?141;", "Ł", txt)
        txt = re.sub(r"&#0*?321;", "Ł", txt)
        txt = re.sub(r"&Lstrok;", "Ł", txt)

        # "U+00142", "LATIN SMALL LETTER L WITH STROKE"
        txt = re.sub(r"&#x0*?142;", "ł", txt)
        txt = re.sub(r"&#0*?322;", "ł", txt)
        txt = re.sub(r"&lstrok;", "ł", txt)

        # "U+00143", "LATIN CAPITAL LETTER N WITH ACUTE"
        txt = re.sub(r"&#x0*?143;", "Ń", txt)
        txt = re.sub(r"&#0*?323;", "Ń", txt)
        txt = re.sub(r"&Nacute;", "Ń", txt)

        # "U+00144", "LATIN SMALL LETTER N WITH ACUTE"
        txt = re.sub(r"&#x0*?144;", "ń", txt)
        txt = re.sub(r"&#0*?324;", "ń", txt)
        txt = re.sub(r"&nacute;", "ń", txt)

        # "U+00145", "LATIN CAPITAL LETTER N WITH CEDILLA"
        txt = re.sub(r"&#x0*?145;", "Ņ", txt)
        txt = re.sub(r"&#0*?325;", "Ņ", txt)
        txt = re.sub(r"&Ncedil;", "Ņ", txt)

        # "U+00146", "LATIN SMALL LETTER N WITH CEDILLA"
        txt = re.sub(r"&#x0*?146;", "ņ", txt)
        txt = re.sub(r"&#0*?326;", "ņ", txt)
        txt = re.sub(r"&ncedil;", "ņ", txt)

        # "U+00147", "LATIN CAPITAL LETTER N WITH CARON"
        txt = re.sub(r"&#x0*?147;", "Ň", txt)
        txt = re.sub(r"&#0*?327;", "Ň", txt)
        txt = re.sub(r"&Ncaron;", "Ň", txt)

        # "U+00148", "LATIN SMALL LETTER N WITH CARON"
        txt = re.sub(r"&#x0*?148;", "ň", txt)
        txt = re.sub(r"&#0*?328;", "ň", txt)
        txt = re.sub(r"&ncaron;", "ň", txt)

        # "U+00149", "LATIN SMALL LETTER N PRECEDED BY APOSTROPHE"
        txt = re.sub(r"&#x0*?149;", "ŉ", txt)
        txt = re.sub(r"&#0*?329;", "ŉ", txt)
        txt = re.sub(r"&napos;", "ŉ", txt)

        # "U+0014A", "LATIN CAPITAL LETTER ENG"
        txt = re.sub(r"&#x0*?14A;", "Ŋ", txt)
        txt = re.sub(r"&#0*?330;", "Ŋ", txt)
        txt = re.sub(r"&ENG;", "Ŋ", txt)

        # "U+0014B", "LATIN SMALL LETTER ENG"
        txt = re.sub(r"&#x0*?14B;", "ŋ", txt)
        txt = re.sub(r"&#0*?331;", "ŋ", txt)
        txt = re.sub(r"&eng;", "ŋ", txt)

        # "U+0014C", "LATIN CAPITAL LETTER O WITH MACRON"
        txt = re.sub(r"&#x0*?14C;", "Ō", txt)
        txt = re.sub(r"&#0*?332;", "Ō", txt)
        txt = re.sub(r"&Omacr;", "Ō", txt)

        # "U+0014D", "LATIN SMALL LETTER O WITH MACRON"
        txt = re.sub(r"&#x0*?14D;", "ō", txt)
        txt = re.sub(r"&#0*?333;", "ō", txt)
        txt = re.sub(r"&omacr;", "ō", txt)

        # "U+00150", "LATIN CAPITAL LETTER O WITH DOUBLE ACUTE"
        txt = re.sub(r"&#x0*?150;", "Ő", txt)
        txt = re.sub(r"&#0*?336;", "Ő", txt)
        txt = re.sub(r"&Odblac;", "Ő", txt)

        # "U+00151", "LATIN SMALL LETTER O WITH DOUBLE ACUTE"
        txt = re.sub(r"&#x0*?151;", "ő", txt)
        txt = re.sub(r"&#0*?337;", "ő", txt)
        txt = re.sub(r"&odblac;", "ő", txt)

        # "U+00152", "LATIN CAPITAL LIGATURE OE"
        txt = re.sub(r"&#x0*?152;", "Œ", txt)
        txt = re.sub(r"&#0*?338;", "Œ", txt)
        txt = re.sub(r"&OElig;", "Œ", txt)

        # "U+00153", "LATIN SMALL LIGATURE OE"
        txt = re.sub(r"&#x0*?153;", "œ", txt)
        txt = re.sub(r"&#0*?339;", "œ", txt)
        txt = re.sub(r"&oelig;", "œ", txt)

        # "U+00154", "LATIN CAPITAL LETTER R WITH ACUTE"
        txt = re.sub(r"&#x0*?154;", "Ŕ", txt)
        txt = re.sub(r"&#0*?340;", "Ŕ", txt)
        txt = re.sub(r"&Racute;", "Ŕ", txt)

        # "U+00155", "LATIN SMALL LETTER R WITH ACUTE"
        txt = re.sub(r"&#x0*?155;", "ŕ", txt)
        txt = re.sub(r"&#0*?341;", "ŕ", txt)
        txt = re.sub(r"&racute;", "ŕ", txt)

        # "U+00156", "LATIN CAPITAL LETTER R WITH CEDILLA"
        txt = re.sub(r"&#x0*?156;", "Ŗ", txt)
        txt = re.sub(r"&#0*?342;", "Ŗ", txt)
        txt = re.sub(r"&Rcedil;", "Ŗ", txt)

        # "U+00157", "LATIN SMALL LETTER R WITH CEDILLA"
        txt = re.sub(r"&#x0*?157;", "ŗ", txt)
        txt = re.sub(r"&#0*?343;", "ŗ", txt)
        txt = re.sub(r"&rcedil;", "ŗ", txt)

        # "U+00158", "LATIN CAPITAL LETTER R WITH CARON"
        txt = re.sub(r"&#x0*?158;", "Ř", txt)
        txt = re.sub(r"&#0*?344;", "Ř", txt)
        txt = re.sub(r"&Rcaron;", "Ř", txt)

        # "U+00159", "LATIN SMALL LETTER R WITH CARON"
        txt = re.sub(r"&#x0*?159;", "ř", txt)
        txt = re.sub(r"&#0*?345;", "ř", txt)
        txt = re.sub(r"&rcaron;", "ř", txt)

        # "U+0015A", "LATIN CAPITAL LETTER S WITH ACUTE"
        txt = re.sub(r"&#x0*?15A;", "Ś", txt)
        txt = re.sub(r"&#0*?346;", "Ś", txt)
        txt = re.sub(r"&Sacute;", "Ś", txt)

        # "U+0015B", "LATIN SMALL LETTER S WITH ACUTE"
        txt = re.sub(r"&#x0*?15B;", "ś", txt)
        txt = re.sub(r"&#0*?347;", "ś", txt)
        txt = re.sub(r"&sacute;", "ś", txt)

        # "U+0015C", "LATIN CAPITAL LETTER S WITH CIRCUMFLEX"
        txt = re.sub(r"&#x0*?15C;", "Ŝ", txt)
        txt = re.sub(r"&#0*?348;", "Ŝ", txt)
        txt = re.sub(r"&Scirc;", "Ŝ", txt)

        # "U+0015D", "LATIN SMALL LETTER S WITH CIRCUMFLEX"
        txt = re.sub(r"&#x0*?15D;", "ŝ", txt)
        txt = re.sub(r"&#0*?349;", "ŝ", txt)
        txt = re.sub(r"&scirc;", "ŝ", txt)

        # "U+0015E", "LATIN CAPITAL LETTER S WITH CEDILLA"
        txt = re.sub(r"&#x0*?15E;", "Ş", txt)
        txt = re.sub(r"&#0*?350;", "Ş", txt)
        txt = re.sub(r"&Scedil;", "Ş", txt)

        # "U+0015F", "LATIN SMALL LETTER S WITH CEDILLA"
        txt = re.sub(r"&#x0*?15F;", "ş", txt)
        txt = re.sub(r"&#0*?351;", "ş", txt)
        txt = re.sub(r"&scedil;", "ş", txt)

        # "U+00160", "LATIN CAPITAL LETTER S WITH CARON"
        txt = re.sub(r"&#x0*?160;", "Š", txt)
        txt = re.sub(r"&#0*?352;", "Š", txt)
        txt = re.sub(r"&Scaron;", "Š", txt)

        # "U+00161", "LATIN SMALL LETTER S WITH CARON"
        txt = re.sub(r"&#x0*?161;", "š", txt)
        txt = re.sub(r"&#0*?353;", "š", txt)
        txt = re.sub(r"&scaron;", "š", txt)

        # "U+00162", "LATIN CAPITAL LETTER T WITH CEDILLA"
        txt = re.sub(r"&#x0*?162;", "Ţ", txt)
        txt = re.sub(r"&#0*?354;", "Ţ", txt)
        txt = re.sub(r"&Tcedil;", "Ţ", txt)

        # "U+00163", "LATIN SMALL LETTER T WITH CEDILLA"
        txt = re.sub(r"&#x0*?163;", "ţ", txt)
        txt = re.sub(r"&#0*?355;", "ţ", txt)
        txt = re.sub(r"&tcedil;", "ţ", txt)

        # "U+00164", "LATIN CAPITAL LETTER T WITH CARON"
        txt = re.sub(r"&#x0*?164;", "Ť", txt)
        txt = re.sub(r"&#0*?356;", "Ť", txt)
        txt = re.sub(r"&Tcaron;", "Ť", txt)

        # "U+00165", "LATIN SMALL LETTER T WITH CARON"
        txt = re.sub(r"&#x0*?165;", "ť", txt)
        txt = re.sub(r"&#0*?357;", "ť", txt)
        txt = re.sub(r"&tcaron;", "ť", txt)

        # "U+00166", "LATIN CAPITAL LETTER T WITH STROKE"
        txt = re.sub(r"&#x0*?166;", "Ŧ", txt)
        txt = re.sub(r"&#0*?358;", "Ŧ", txt)
        txt = re.sub(r"&Tstrok;", "Ŧ", txt)

        # "U+00167", "LATIN SMALL LETTER T WITH STROKE"
        txt = re.sub(r"&#x0*?167;", "ŧ", txt)
        txt = re.sub(r"&#0*?359;", "ŧ", txt)
        txt = re.sub(r"&tstrok;", "ŧ", txt)

        # "U+00168", "LATIN CAPITAL LETTER U WITH TILDE"
        txt = re.sub(r"&#x0*?168;", "Ũ", txt)
        txt = re.sub(r"&#0*?360;", "Ũ", txt)
        txt = re.sub(r"&Utilde;", "Ũ", txt)

        # "U+00169", "LATIN SMALL LETTER U WITH TILDE"
        txt = re.sub(r"&#x0*?169;", "ũ", txt)
        txt = re.sub(r"&#0*?361;", "ũ", txt)
        txt = re.sub(r"&utilde;", "ũ", txt)

        # "U+0016A", "LATIN CAPITAL LETTER U WITH MACRON"
        txt = re.sub(r"&#x0*?16A;", "Ū", txt)
        txt = re.sub(r"&#0*?362;", "Ū", txt)
        txt = re.sub(r"&Umacr;", "Ū", txt)

        # "U+0016B", "LATIN SMALL LETTER U WITH MACRON"
        txt = re.sub(r"&#x0*?16B;", "ū", txt)
        txt = re.sub(r"&#0*?363;", "ū", txt)
        txt = re.sub(r"&umacr;", "ū", txt)

        # "U+0016C", "LATIN CAPITAL LETTER U WITH BREVE"
        txt = re.sub(r"&#x0*?16C;", "Ŭ", txt)
        txt = re.sub(r"&#0*?364;", "Ŭ", txt)
        txt = re.sub(r"&Ubreve;", "Ŭ", txt)

        # "U+0016D", "LATIN SMALL LETTER U WITH BREVE"
        txt = re.sub(r"&#x0*?16D;", "ŭ", txt)
        txt = re.sub(r"&#0*?365;", "ŭ", txt)
        txt = re.sub(r"&ubreve;", "ŭ", txt)

        # "U+0016E", "LATIN CAPITAL LETTER U WITH RING ABOVE"
        txt = re.sub(r"&#x0*?16E;", "Ů", txt)
        txt = re.sub(r"&#0*?366;", "Ů", txt)
        txt = re.sub(r"&Uring;", "Ů", txt)

        # "U+0016F", "LATIN SMALL LETTER U WITH RING ABOVE"
        txt = re.sub(r"&#x0*?16F;", "ů", txt)
        txt = re.sub(r"&#0*?367;", "ů", txt)
        txt = re.sub(r"&uring;", "ů", txt)

        # "U+00170", "LATIN CAPITAL LETTER U WITH DOUBLE ACUTE"
        txt = re.sub(r"&#x0*?170;", "Ű", txt)
        txt = re.sub(r"&#0*?368;", "Ű", txt)
        txt = re.sub(r"&Udblac;", "Ű", txt)

        # "U+00171", "LATIN SMALL LETTER U WITH DOUBLE ACUTE"
        txt = re.sub(r"&#x0*?171;", "ű", txt)
        txt = re.sub(r"&#0*?369;", "ű", txt)
        txt = re.sub(r"&udblac;", "ű", txt)

        # "U+00172", "LATIN CAPITAL LETTER U WITH OGONEK"
        txt = re.sub(r"&#x0*?172;", "Ų", txt)
        txt = re.sub(r"&#0*?370;", "Ų", txt)
        txt = re.sub(r"&Uogon;", "Ų", txt)

        # "U+00173", "LATIN SMALL LETTER U WITH OGONEK"
        txt = re.sub(r"&#x0*?173;", "ų", txt)
        txt = re.sub(r"&#0*?371;", "ų", txt)
        txt = re.sub(r"&uogon;", "ų", txt)

        # "U+00174", "LATIN CAPITAL LETTER W WITH CIRCUMFLEX"
        txt = re.sub(r"&#x0*?174;", "Ŵ", txt)
        txt = re.sub(r"&#0*?372;", "Ŵ", txt)
        txt = re.sub(r"&Wcirc;", "Ŵ", txt)

        # "U+00175", "LATIN SMALL LETTER W WITH CIRCUMFLEX"
        txt = re.sub(r"&#x0*?175;", "ŵ", txt)
        txt = re.sub(r"&#0*?373;", "ŵ", txt)
        txt = re.sub(r"&wcirc;", "ŵ", txt)

        # "U+00176", "LATIN CAPITAL LETTER Y WITH CIRCUMFLEX"
        txt = re.sub(r"&#x0*?176;", "Ŷ", txt)
        txt = re.sub(r"&#0*?374;", "Ŷ", txt)
        txt = re.sub(r"&Ycirc;", "Ŷ", txt)

        # "U+00177", "LATIN SMALL LETTER Y WITH CIRCUMFLEX"
        txt = re.sub(r"&#x0*?177;", "ŷ", txt)
        txt = re.sub(r"&#0*?375;", "ŷ", txt)
        txt = re.sub(r"&ycirc;", "ŷ", txt)

        # "U+00178", "LATIN CAPITAL LETTER Y WITH DIAERESIS"
        txt = re.sub(r"&#x0*?178;", "Ÿ", txt)
        txt = re.sub(r"&#0*?376;", "Ÿ", txt)
        txt = re.sub(r"&Yuml;", "Ÿ", txt)

        # "U+00179", "LATIN CAPITAL LETTER Z WITH ACUTE"
        txt = re.sub(r"&#x0*?179;", "Ź", txt)
        txt = re.sub(r"&#0*?377;", "Ź", txt)
        txt = re.sub(r"&Zacute;", "Ź", txt)

        # "U+0017A", "LATIN SMALL LETTER Z WITH ACUTE"
        txt = re.sub(r"&#x0*?17A;", "ź", txt)
        txt = re.sub(r"&#0*?378;", "ź", txt)
        txt = re.sub(r"&zacute;", "ź", txt)

        # "U+0017B", "LATIN CAPITAL LETTER Z WITH DOT ABOVE"
        txt = re.sub(r"&#x0*?17B;", "Ż", txt)
        txt = re.sub(r"&#0*?379;", "Ż", txt)
        txt = re.sub(r"&Zdot;", "Ż", txt)

        # "U+0017C", "LATIN SMALL LETTER Z WITH DOT ABOVE"
        txt = re.sub(r"&#x0*?17C;", "ż", txt)
        txt = re.sub(r"&#0*?380;", "ż", txt)
        txt = re.sub(r"&zdot;", "ż", txt)

        # "U+0017D", "LATIN CAPITAL LETTER Z WITH CARON"
        txt = re.sub(r"&#x0*?17D;", "Ž", txt)
        txt = re.sub(r"&#0*?381;", "Ž", txt)
        txt = re.sub(r"&Zcaron;", "Ž", txt)

        # "U+0017E", "LATIN SMALL LETTER Z WITH CARON"
        txt = re.sub(r"&#x0*?17E;", "ž", txt)
        txt = re.sub(r"&#0*?382;", "ž", txt)
        txt = re.sub(r"&zcaron;", "ž", txt)

        # "U+00192", "LATIN SMALL LETTER F WITH HOOK"
        txt = re.sub(r"&#x0*?192;", "ƒ", txt)
        txt = re.sub(r"&#0*?402;", "ƒ", txt)
        txt = re.sub(r"&fnof;", "ƒ", txt)

        # "U+001B5", "LATIN CAPITAL LETTER Z WITH STROKE"
        txt = re.sub(r"&#x0*?1B5;", "Ƶ", txt)
        txt = re.sub(r"&#0*?437;", "Ƶ", txt)
        txt = re.sub(r"&imped;", "Ƶ", txt)

        # "U+001F5", "LATIN SMALL LETTER G WITH ACUTE"
        txt = re.sub(r"&#x0*?1F5;", "ǵ", txt)
        txt = re.sub(r"&#0*?501;", "ǵ", txt)
        txt = re.sub(r"&gacute;", "ǵ", txt)

        # "U+00237", "LATIN SMALL LETTER DOTLESS J"
        txt = re.sub(r"&#x0*?237;", "ȷ", txt)
        txt = re.sub(r"&#0*?567;", "ȷ", txt)
        txt = re.sub(r"&jmath;", "ȷ", txt)

        # "U+002C6", "MODIFIER LETTER CIRCUMFLEX ACCENT"
        txt = re.sub(r"&#x0*?2C6;", "ˆ", txt)
        txt = re.sub(r"&#0*?710;", "ˆ", txt)
        txt = re.sub(r"&circ;", "ˆ", txt)

        # "U+002C7", "CARON"
        txt = re.sub(r"&#x0*?2C7;", "ˇ", txt)
        txt = re.sub(r"&#0*?711;", "ˇ", txt)
        txt = re.sub(r"&caron;", "ˇ", txt)
        txt = re.sub(r"&Hacek;", "ˇ", txt)

        # "U+002D8", "BREVE"
        txt = re.sub(r"&#x0*?2D8;", "˘", txt)
        txt = re.sub(r"&#0*?728;", "˘", txt)
        txt = re.sub(r"&breve;", "˘", txt)
        txt = re.sub(r"&Breve;", "˘", txt)

        # "U+002D9", "DOT ABOVE"
        txt = re.sub(r"&#x0*?2D9;", "˙", txt)
        txt = re.sub(r"&#0*?729;", "˙", txt)
        txt = re.sub(r"&dot;", "˙", txt)
        txt = re.sub(r"&DiacriticalDot;", "˙", txt)

        # "U+002DA", "RING ABOVE"
        txt = re.sub(r"&#x0*?2DA;", "˚", txt)
        txt = re.sub(r"&#0*?730;", "˚", txt)
        txt = re.sub(r"&ring;", "˚", txt)

        # "U+002DB", "OGONEK"
        txt = re.sub(r"&#x0*?2DB;", "˛", txt)
        txt = re.sub(r"&#0*?731;", "˛", txt)
        txt = re.sub(r"&ogon;", "˛", txt)

        # "U+002DC", "SMALL TILDE"
        txt = re.sub(r"&#x0*?2DC;", "˜", txt)
        txt = re.sub(r"&#0*?732;", "˜", txt)
        txt = re.sub(r"&tilde;", "˜", txt)
        txt = re.sub(r"&DiacriticalTilde;", "˜", txt)

        # "U+002DD", "DOUBLE ACUTE ACCENT"
        txt = re.sub(r"&#x0*?2DD;", "˝", txt)
        txt = re.sub(r"&#0*?733;", "˝", txt)
        txt = re.sub(r"&dblac;", "˝", txt)
        txt = re.sub(r"&DiacriticalDoubleAcute;", "˝", txt)

        # "U+00311", "COMBINING INVERTED BREVE"
        txt = re.sub(r"&#x0*?311;", "̑", txt)
        txt = re.sub(r"&#0*?785;", "̑", txt)
        txt = re.sub(r"&DownBreve;", "̑", txt)

        # "U+00332", "COMBINING LOW LINE"
        txt = re.sub(r"&#x0*?332;", "̲", txt)
        txt = re.sub(r"&#0*?818;", "̲", txt)
        txt = re.sub(r"&UnderBar;", "̲", txt)

        # "U+00391", "GREEK CAPITAL LETTER ALPHA"
        txt = re.sub(r"&#x0*?391;", "Α", txt)
        txt = re.sub(r"&#0*?913;", "Α", txt)
        txt = re.sub(r"&Alpha;", "Α", txt)

        # "U+00392", "GREEK CAPITAL LETTER BETA"
        txt = re.sub(r"&#x0*?392;", "Β", txt)
        txt = re.sub(r"&#0*?914;", "Β", txt)
        txt = re.sub(r"&Beta;", "Β", txt)

        # "U+00393", "GREEK CAPITAL LETTER GAMMA"
        txt = re.sub(r"&#x0*?393;", "Γ", txt)
        txt = re.sub(r"&#0*?915;", "Γ", txt)
        txt = re.sub(r"&Gamma;", "Γ", txt)

        # "U+00394", "GREEK CAPITAL LETTER DELTA"
        txt = re.sub(r"&#x0*?394;", "Δ", txt)
        txt = re.sub(r"&#0*?916;", "Δ", txt)
        txt = re.sub(r"&Delta;", "Δ", txt)

        # "U+00395", "GREEK CAPITAL LETTER EPSILON"
        txt = re.sub(r"&#x0*?395;", "Ε", txt)
        txt = re.sub(r"&#0*?917;", "Ε", txt)
        txt = re.sub(r"&Epsilon;", "Ε", txt)

        # "U+00396", "GREEK CAPITAL LETTER ZETA"
        txt = re.sub(r"&#x0*?396;", "Ζ", txt)
        txt = re.sub(r"&#0*?918;", "Ζ", txt)
        txt = re.sub(r"&Zeta;", "Ζ", txt)

        # "U+00397", "GREEK CAPITAL LETTER ETA"
        txt = re.sub(r"&#x0*?397;", "Η", txt)
        txt = re.sub(r"&#0*?919;", "Η", txt)
        txt = re.sub(r"&Eta;", "Η", txt)

        # "U+00398", "GREEK CAPITAL LETTER THETA"
        txt = re.sub(r"&#x0*?398;", "Θ", txt)
        txt = re.sub(r"&#0*?920;", "Θ", txt)
        txt = re.sub(r"&Theta;", "Θ", txt)

        # "U+00399", "GREEK CAPITAL LETTER IOTA"
        txt = re.sub(r"&#x0*?399;", "Ι", txt)
        txt = re.sub(r"&#0*?921;", "Ι", txt)
        txt = re.sub(r"&Iota;", "Ι", txt)

        # "U+0039A", "GREEK CAPITAL LETTER KAPPA"
        txt = re.sub(r"&#x0*?39A;", "Κ", txt)
        txt = re.sub(r"&#0*?922;", "Κ", txt)
        txt = re.sub(r"&Kappa;", "Κ", txt)

        # "U+0039B", "GREEK CAPITAL LETTER LAMDA"
        txt = re.sub(r"&#x0*?39B;", "Λ", txt)
        txt = re.sub(r"&#0*?923;", "Λ", txt)
        txt = re.sub(r"&Lambda;", "Λ", txt)

        # "U+0039C", "GREEK CAPITAL LETTER MU"
        txt = re.sub(r"&#x0*?39C;", "Μ", txt)
        txt = re.sub(r"&#0*?924;", "Μ", txt)
        txt = re.sub(r"&Mu;", "Μ", txt)

        # "U+0039D", "GREEK CAPITAL LETTER NU"
        txt = re.sub(r"&#x0*?39D;", "Ν", txt)
        txt = re.sub(r"&#0*?925;", "Ν", txt)
        txt = re.sub(r"&Nu;", "Ν", txt)

        # "U+0039E", "GREEK CAPITAL LETTER XI"
        txt = re.sub(r"&#x0*?39E;", "Ξ", txt)
        txt = re.sub(r"&#0*?926;", "Ξ", txt)
        txt = re.sub(r"&Xi;", "Ξ", txt)

        # "U+0039F", "GREEK CAPITAL LETTER OMICRON"
        txt = re.sub(r"&#x0*?39F;", "Ο", txt)
        txt = re.sub(r"&#0*?927;", "Ο", txt)
        txt = re.sub(r"&Omicron;", "Ο", txt)

        # "U+003A0", "GREEK CAPITAL LETTER PI"
        txt = re.sub(r"&#x0*?3A0;", "Π", txt)
        txt = re.sub(r"&#0*?928;", "Π", txt)
        txt = re.sub(r"&Pi;", "Π", txt)

        # "U+003A1", "GREEK CAPITAL LETTER RHO"
        txt = re.sub(r"&#x0*?3A1;", "Ρ", txt)
        txt = re.sub(r"&#0*?929;", "Ρ", txt)
        txt = re.sub(r"&Rho;", "Ρ", txt)

        # "U+003A3", "GREEK CAPITAL LETTER SIGMA"
        txt = re.sub(r"&#x0*?3A3;", "Σ", txt)
        txt = re.sub(r"&#0*?931;", "Σ", txt)
        txt = re.sub(r"&Sigma;", "Σ", txt)

        # "U+003A4", "GREEK CAPITAL LETTER TAU"
        txt = re.sub(r"&#x0*?3A4;", "Τ", txt)
        txt = re.sub(r"&#0*?932;", "Τ", txt)
        txt = re.sub(r"&Tau;", "Τ", txt)

        # "U+003A5", "GREEK CAPITAL LETTER UPSILON"
        txt = re.sub(r"&#x0*?3A5;", "Υ", txt)
        txt = re.sub(r"&#0*?933;", "Υ", txt)
        txt = re.sub(r"&Upsilon;", "Υ", txt)

        # "U+003A6", "GREEK CAPITAL LETTER PHI"
        txt = re.sub(r"&#x0*?3A6;", "Φ", txt)
        txt = re.sub(r"&#0*?934;", "Φ", txt)
        txt = re.sub(r"&Phi;", "Φ", txt)

        # "U+003A7", "GREEK CAPITAL LETTER CHI"
        txt = re.sub(r"&#x0*?3A7;", "Χ", txt)
        txt = re.sub(r"&#0*?935;", "Χ", txt)
        txt = re.sub(r"&Chi;", "Χ", txt)

        # "U+003A8", "GREEK CAPITAL LETTER PSI"
        txt = re.sub(r"&#x0*?3A8;", "Ψ", txt)
        txt = re.sub(r"&#0*?936;", "Ψ", txt)
        txt = re.sub(r"&Psi;", "Ψ", txt)

        # "U+003A9", "GREEK CAPITAL LETTER OMEGA"
        txt = re.sub(r"&#x0*?3A9;", "Ω", txt)
        txt = re.sub(r"&#0*?937;", "Ω", txt)
        txt = re.sub(r"&Omega;", "Ω", txt)

        # "U+003B1", "GREEK SMALL LETTER ALPHA"
        txt = re.sub(r"&#x0*?3B1;", "α", txt)
        txt = re.sub(r"&#0*?945;", "α", txt)
        txt = re.sub(r"&alpha;", "α", txt)

        # "U+003B2", "GREEK SMALL LETTER BETA"
        txt = re.sub(r"&#x0*?3B2;", "β", txt)
        txt = re.sub(r"&#0*?946;", "β", txt)
        txt = re.sub(r"&beta;", "β", txt)

        # "U+003B3", "GREEK SMALL LETTER GAMMA"
        txt = re.sub(r"&#x0*?3B3;", "γ", txt)
        txt = re.sub(r"&#0*?947;", "γ", txt)
        txt = re.sub(r"&gamma;", "γ", txt)

        # "U+003B4", "GREEK SMALL LETTER DELTA"
        txt = re.sub(r"&#x0*?3B4;", "δ", txt)
        txt = re.sub(r"&#0*?948;", "δ", txt)
        txt = re.sub(r"&delta;", "δ", txt)

        # "U+003B5", "GREEK SMALL LETTER EPSILON"
        txt = re.sub(r"&#x0*?3B5;", "ε", txt)
        txt = re.sub(r"&#0*?949;", "ε", txt)
        txt = re.sub(r"&epsiv;", "ε", txt)
        txt = re.sub(r"&varepsilon;", "ε", txt)
        txt = re.sub(r"&epsilon;", "ε", txt)

        # "U+003B6", "GREEK SMALL LETTER ZETA"
        txt = re.sub(r"&#x0*?3B6;", "ζ", txt)
        txt = re.sub(r"&#0*?950;", "ζ", txt)
        txt = re.sub(r"&zeta;", "ζ", txt)

        # "U+003B7", "GREEK SMALL LETTER ETA"
        txt = re.sub(r"&#x0*?3B7;", "η", txt)
        txt = re.sub(r"&#0*?951;", "η", txt)
        txt = re.sub(r"&eta;", "η", txt)

        # "U+003B8", "GREEK SMALL LETTER THETA"
        txt = re.sub(r"&#x0*?3B8;", "θ", txt)
        txt = re.sub(r"&#0*?952;", "θ", txt)
        txt = re.sub(r"&theta;", "θ", txt)

        # "U+003B9", "GREEK SMALL LETTER IOTA"
        txt = re.sub(r"&#x0*?3B9;", "ι", txt)
        txt = re.sub(r"&#0*?953;", "ι", txt)
        txt = re.sub(r"&iota;", "ι", txt)

        # "U+003BA", "GREEK SMALL LETTER KAPPA"
        txt = re.sub(r"&#x0*?3BA;", "κ", txt)
        txt = re.sub(r"&#0*?954;", "κ", txt)
        txt = re.sub(r"&kappa;", "κ", txt)

        # "U+003BB", "GREEK SMALL LETTER LAMDA"
        txt = re.sub(r"&#x0*?3BB;", "λ", txt)
        txt = re.sub(r"&#0*?955;", "λ", txt)
        txt = re.sub(r"&lambda;", "λ", txt)

        # "U+003BC", "GREEK SMALL LETTER MU"
        txt = re.sub(r"&#x0*?3BC;", "μ", txt)
        txt = re.sub(r"&#0*?956;", "μ", txt)
        txt = re.sub(r"&mu;", "μ", txt)

        # "U+003BD", "GREEK SMALL LETTER NU"
        txt = re.sub(r"&#x0*?3BD;", "ν", txt)
        txt = re.sub(r"&#0*?957;", "ν", txt)
        txt = re.sub(r"&nu;", "ν", txt)

        # "U+003BE", "GREEK SMALL LETTER XI"
        txt = re.sub(r"&#x0*?3BE;", "ξ", txt)
        txt = re.sub(r"&#0*?958;", "ξ", txt)
        txt = re.sub(r"&xi;", "ξ", txt)

        # "U+003BF", "GREEK SMALL LETTER OMICRON"
        txt = re.sub(r"&#x0*?3BF;", "ο", txt)
        txt = re.sub(r"&#0*?959;", "ο", txt)
        txt = re.sub(r"&omicron;", "ο", txt)

        # "U+003C0", "GREEK SMALL LETTER PI"
        txt = re.sub(r"&#x0*?3C0;", "π", txt)
        txt = re.sub(r"&#0*?960;", "π", txt)
        txt = re.sub(r"&pi;", "π", txt)

        # "U+003C1", "GREEK SMALL LETTER RHO"
        txt = re.sub(r"&#x0*?3C1;", "ρ", txt)
        txt = re.sub(r"&#0*?961;", "ρ", txt)
        txt = re.sub(r"&rho;", "ρ", txt)

        # "U+003C2", "GREEK SMALL LETTER FINAL SIGMA"
        txt = re.sub(r"&#x0*?3C2;", "ς", txt)
        txt = re.sub(r"&#0*?962;", "ς", txt)
        txt = re.sub(r"&sigmav;", "ς", txt)
        txt = re.sub(r"&varsigma;", "ς", txt)
        txt = re.sub(r"&sigmaf;", "ς", txt)

        # "U+003C3", "GREEK SMALL LETTER SIGMA"
        txt = re.sub(r"&#x0*?3C3;", "σ", txt)
        txt = re.sub(r"&#0*?963;", "σ", txt)
        txt = re.sub(r"&sigma;", "σ", txt)

        # "U+003C4", "GREEK SMALL LETTER TAU"
        txt = re.sub(r"&#x0*?3C4;", "τ", txt)
        txt = re.sub(r"&#0*?964;", "τ", txt)
        txt = re.sub(r"&tau;", "τ", txt)

        # "U+003C5", "GREEK SMALL LETTER UPSILON"
        txt = re.sub(r"&#x0*?3C5;", "υ", txt)
        txt = re.sub(r"&#0*?965;", "υ", txt)
        txt = re.sub(r"&upsi;", "υ", txt)
        txt = re.sub(r"&upsilon;", "υ", txt)

        # "U+003C6", "GREEK SMALL LETTER PHI"
        txt = re.sub(r"&#x0*?3C6;", "φ", txt)
        txt = re.sub(r"&#0*?966;", "φ", txt)
        txt = re.sub(r"&phi;", "φ", txt)
        txt = re.sub(r"&phiv;", "φ", txt)
        txt = re.sub(r"&varphi;", "φ", txt)

        # "U+003C7", "GREEK SMALL LETTER CHI"
        txt = re.sub(r"&#x0*?3C7;", "χ", txt)
        txt = re.sub(r"&#0*?967;", "χ", txt)
        txt = re.sub(r"&chi;", "χ", txt)

        # "U+003C8", "GREEK SMALL LETTER PSI"
        txt = re.sub(r"&#x0*?3C8;", "ψ", txt)
        txt = re.sub(r"&#0*?968;", "ψ", txt)
        txt = re.sub(r"&psi;", "ψ", txt)

        # "U+003C9", "GREEK SMALL LETTER OMEGA"
        txt = re.sub(r"&#x0*?3C9;", "ω", txt)
        txt = re.sub(r"&#0*?969;", "ω", txt)
        txt = re.sub(r"&omega;", "ω", txt)

        # "U+003D1", "GREEK THETA SYMBOL"
        txt = re.sub(r"&#x0*?3D1;", "ϑ", txt)
        txt = re.sub(r"&#0*?977;", "ϑ", txt)
        txt = re.sub(r"&thetav;", "ϑ", txt)
        txt = re.sub(r"&vartheta;", "ϑ", txt)
        txt = re.sub(r"&thetasym;", "ϑ", txt)

        # "U+003D2", "GREEK UPSILON WITH HOOK SYMBOL"
        txt = re.sub(r"&#x0*?3D2;", "ϒ", txt)
        txt = re.sub(r"&#0*?978;", "ϒ", txt)
        txt = re.sub(r"&Upsi;", "ϒ", txt)
        txt = re.sub(r"&upsih;", "ϒ", txt)

        # "U+003D5", "GREEK PHI SYMBOL"
        txt = re.sub(r"&#x0*?3D5;", "ϕ", txt)
        txt = re.sub(r"&#0*?981;", "ϕ", txt)
        txt = re.sub(r"&straightphi;", "ϕ", txt)

        # "U+003D6", "GREEK PI SYMBOL"
        txt = re.sub(r"&#x0*?3D6;", "ϖ", txt)
        txt = re.sub(r"&#0*?982;", "ϖ", txt)
        txt = re.sub(r"&piv;", "ϖ", txt)
        txt = re.sub(r"&varpi;", "ϖ", txt)

        # "U+003DC", "GREEK LETTER DIGAMMA"
        txt = re.sub(r"&#x0*?3DC;", "Ϝ", txt)
        txt = re.sub(r"&#0*?988;", "Ϝ", txt)
        txt = re.sub(r"&Gammad;", "Ϝ", txt)

        # "U+003DD", "GREEK SMALL LETTER DIGAMMA"
        txt = re.sub(r"&#x0*?3DD;", "ϝ", txt)
        txt = re.sub(r"&#0*?989;", "ϝ", txt)
        txt = re.sub(r"&gammad;", "ϝ", txt)
        txt = re.sub(r"&digamma;", "ϝ", txt)

        # "U+003F0", "GREEK KAPPA SYMBOL"
        txt = re.sub(r"&#x0*?3F0;", "ϰ", txt)
        txt = re.sub(r"&#0*?1008;", "ϰ", txt)
        txt = re.sub(r"&kappav;", "ϰ", txt)
        txt = re.sub(r"&varkappa;", "ϰ", txt)

        # "U+003F1", "GREEK RHO SYMBOL"
        txt = re.sub(r"&#x0*?3F1;", "ϱ", txt)
        txt = re.sub(r"&#0*?1009;", "ϱ", txt)
        txt = re.sub(r"&rhov;", "ϱ", txt)
        txt = re.sub(r"&varrho;", "ϱ", txt)

        # "U+003F5", "GREEK LUNATE EPSILON SYMBOL"
        txt = re.sub(r"&#x0*?3F5;", "ϵ", txt)
        txt = re.sub(r"&#0*?1013;", "ϵ", txt)
        txt = re.sub(r"&epsi;", "ϵ", txt)
        txt = re.sub(r"&straightepsilon;", "ϵ", txt)

        # "U+003F6", "GREEK REVERSED LUNATE EPSILON SYMBOL"
        txt = re.sub(r"&#x0*?3F6;", "϶", txt)
        txt = re.sub(r"&#0*?1014;", "϶", txt)
        txt = re.sub(r"&bepsi;", "϶", txt)
        txt = re.sub(r"&backepsilon;", "϶", txt)

        # "U+00401", "CYRILLIC CAPITAL LETTER IO"
        txt = re.sub(r"&#x0*?401;", "Ё", txt)
        txt = re.sub(r"&#0*?1025;", "Ё", txt)
        txt = re.sub(r"&IOcy;", "Ё", txt)

        # "U+00402", "CYRILLIC CAPITAL LETTER DJE"
        txt = re.sub(r"&#x0*?402;", "Ђ", txt)
        txt = re.sub(r"&#0*?1026;", "Ђ", txt)
        txt = re.sub(r"&DJcy;", "Ђ", txt)

        # "U+00403", "CYRILLIC CAPITAL LETTER GJE"
        txt = re.sub(r"&#x0*?403;", "Ѓ", txt)
        txt = re.sub(r"&#0*?1027;", "Ѓ", txt)
        txt = re.sub(r"&GJcy;", "Ѓ", txt)

        # "U+00404", "CYRILLIC CAPITAL LETTER UKRAINIAN IE"
        txt = re.sub(r"&#x0*?404;", "Є", txt)
        txt = re.sub(r"&#0*?1028;", "Є", txt)
        txt = re.sub(r"&Jukcy;", "Є", txt)

        # "U+00405", "CYRILLIC CAPITAL LETTER DZE"
        txt = re.sub(r"&#x0*?405;", "Ѕ", txt)
        txt = re.sub(r"&#0*?1029;", "Ѕ", txt)
        txt = re.sub(r"&DScy;", "Ѕ", txt)

        # "U+00406", "CYRILLIC CAPITAL LETTER BYELORUSSIAN-UKRAINIAN I"
        txt = re.sub(r"&#x0*?406;", "І", txt)
        txt = re.sub(r"&#0*?1030;", "І", txt)
        txt = re.sub(r"&Iukcy;", "І", txt)

        # "U+00407", "CYRILLIC CAPITAL LETTER YI"
        txt = re.sub(r"&#x0*?407;", "Ї", txt)
        txt = re.sub(r"&#0*?1031;", "Ї", txt)
        txt = re.sub(r"&YIcy;", "Ї", txt)

        # "U+00408", "CYRILLIC CAPITAL LETTER JE"
        txt = re.sub(r"&#x0*?408;", "Ј", txt)
        txt = re.sub(r"&#0*?1032;", "Ј", txt)
        txt = re.sub(r"&Jsercy;", "Ј", txt)

        # "U+00409", "CYRILLIC CAPITAL LETTER LJE"
        txt = re.sub(r"&#x0*?409;", "Љ", txt)
        txt = re.sub(r"&#0*?1033;", "Љ", txt)
        txt = re.sub(r"&LJcy;", "Љ", txt)

        # "U+0040A", "CYRILLIC CAPITAL LETTER NJE"
        txt = re.sub(r"&#x0*?40A;", "Њ", txt)
        txt = re.sub(r"&#0*?1034;", "Њ", txt)
        txt = re.sub(r"&NJcy;", "Њ", txt)

        # "U+0040B", "CYRILLIC CAPITAL LETTER TSHE"
        txt = re.sub(r"&#x0*?40B;", "Ћ", txt)
        txt = re.sub(r"&#0*?1035;", "Ћ", txt)
        txt = re.sub(r"&TSHcy;", "Ћ", txt)

        # "U+0040C", "CYRILLIC CAPITAL LETTER KJE"
        txt = re.sub(r"&#x0*?40C;", "Ќ", txt)
        txt = re.sub(r"&#0*?1036;", "Ќ", txt)
        txt = re.sub(r"&KJcy;", "Ќ", txt)

        # "U+0040E", "CYRILLIC CAPITAL LETTER SHORT U"
        txt = re.sub(r"&#x0*?40E;", "Ў", txt)
        txt = re.sub(r"&#0*?1038;", "Ў", txt)
        txt = re.sub(r"&Ubrcy;", "Ў", txt)

        # "U+0040F", "CYRILLIC CAPITAL LETTER DZHE"
        txt = re.sub(r"&#x0*?40F;", "Џ", txt)
        txt = re.sub(r"&#0*?1039;", "Џ", txt)
        txt = re.sub(r"&DZcy;", "Џ", txt)

        # "U+00410", "CYRILLIC CAPITAL LETTER A"
        txt = re.sub(r"&#x0*?410;", "А", txt)
        txt = re.sub(r"&#0*?1040;", "А", txt)
        txt = re.sub(r"&Acy;", "А", txt)

        # "U+00411", "CYRILLIC CAPITAL LETTER BE"
        txt = re.sub(r"&#x0*?411;", "Б", txt)
        txt = re.sub(r"&#0*?1041;", "Б", txt)
        txt = re.sub(r"&Bcy;", "Б", txt)

        # "U+00412", "CYRILLIC CAPITAL LETTER VE"
        txt = re.sub(r"&#x0*?412;", "В", txt)
        txt = re.sub(r"&#0*?1042;", "В", txt)
        txt = re.sub(r"&Vcy;", "В", txt)

        # "U+00413", "CYRILLIC CAPITAL LETTER GHE"
        txt = re.sub(r"&#x0*?413;", "Г", txt)
        txt = re.sub(r"&#0*?1043;", "Г", txt)
        txt = re.sub(r"&Gcy;", "Г", txt)

        # "U+00414", "CYRILLIC CAPITAL LETTER DE"
        txt = re.sub(r"&#x0*?414;", "Д", txt)
        txt = re.sub(r"&#0*?1044;", "Д", txt)
        txt = re.sub(r"&Dcy;", "Д", txt)

        # "U+00415", "CYRILLIC CAPITAL LETTER IE"
        txt = re.sub(r"&#x0*?415;", "Е", txt)
        txt = re.sub(r"&#0*?1045;", "Е", txt)
        txt = re.sub(r"&IEcy;", "Е", txt)

        # "U+00416", "CYRILLIC CAPITAL LETTER ZHE"
        txt = re.sub(r"&#x0*?416;", "Ж", txt)
        txt = re.sub(r"&#0*?1046;", "Ж", txt)
        txt = re.sub(r"&ZHcy;", "Ж", txt)

        # "U+00417", "CYRILLIC CAPITAL LETTER ZE"
        txt = re.sub(r"&#x0*?417;", "З", txt)
        txt = re.sub(r"&#0*?1047;", "З", txt)
        txt = re.sub(r"&Zcy;", "З", txt)

        # "U+00418", "CYRILLIC CAPITAL LETTER I"
        txt = re.sub(r"&#x0*?418;", "И", txt)
        txt = re.sub(r"&#0*?1048;", "И", txt)
        txt = re.sub(r"&Icy;", "И", txt)

        # "U+00419", "CYRILLIC CAPITAL LETTER SHORT I"
        txt = re.sub(r"&#x0*?419;", "Й", txt)
        txt = re.sub(r"&#0*?1049;", "Й", txt)
        txt = re.sub(r"&Jcy;", "Й", txt)

        # "U+0041A", "CYRILLIC CAPITAL LETTER KA"
        txt = re.sub(r"&#x0*?41A;", "К", txt)
        txt = re.sub(r"&#0*?1050;", "К", txt)
        txt = re.sub(r"&Kcy;", "К", txt)

        # "U+0041B", "CYRILLIC CAPITAL LETTER EL"
        txt = re.sub(r"&#x0*?41B;", "Л", txt)
        txt = re.sub(r"&#0*?1051;", "Л", txt)
        txt = re.sub(r"&Lcy;", "Л", txt)

        # "U+0041C", "CYRILLIC CAPITAL LETTER EM"
        txt = re.sub(r"&#x0*?41C;", "М", txt)
        txt = re.sub(r"&#0*?1052;", "М", txt)
        txt = re.sub(r"&Mcy;", "М", txt)

        # "U+0041D", "CYRILLIC CAPITAL LETTER EN"
        txt = re.sub(r"&#x0*?41D;", "Н", txt)
        txt = re.sub(r"&#0*?1053;", "Н", txt)
        txt = re.sub(r"&Ncy;", "Н", txt)

        # "U+0041E", "CYRILLIC CAPITAL LETTER O"
        txt = re.sub(r"&#x0*?41E;", "О", txt)
        txt = re.sub(r"&#0*?1054;", "О", txt)
        txt = re.sub(r"&Ocy;", "О", txt)

        # "U+0041F", "CYRILLIC CAPITAL LETTER PE"
        txt = re.sub(r"&#x0*?41F;", "П", txt)
        txt = re.sub(r"&#0*?1055;", "П", txt)
        txt = re.sub(r"&Pcy;", "П", txt)

        # "U+00420", "CYRILLIC CAPITAL LETTER ER"
        txt = re.sub(r"&#x0*?420;", "Р", txt)
        txt = re.sub(r"&#0*?1056;", "Р", txt)
        txt = re.sub(r"&Rcy;", "Р", txt)

        # "U+00421", "CYRILLIC CAPITAL LETTER ES"
        txt = re.sub(r"&#x0*?421;", "С", txt)
        txt = re.sub(r"&#0*?1057;", "С", txt)
        txt = re.sub(r"&Scy;", "С", txt)

        # "U+00422", "CYRILLIC CAPITAL LETTER TE"
        txt = re.sub(r"&#x0*?422;", "Т", txt)
        txt = re.sub(r"&#0*?1058;", "Т", txt)
        txt = re.sub(r"&Tcy;", "Т", txt)

        # "U+00423", "CYRILLIC CAPITAL LETTER U"
        txt = re.sub(r"&#x0*?423;", "У", txt)
        txt = re.sub(r"&#0*?1059;", "У", txt)
        txt = re.sub(r"&Ucy;", "У", txt)

        # "U+00424", "CYRILLIC CAPITAL LETTER EF"
        txt = re.sub(r"&#x0*?424;", "Ф", txt)
        txt = re.sub(r"&#0*?1060;", "Ф", txt)
        txt = re.sub(r"&Fcy;", "Ф", txt)

        # "U+00425", "CYRILLIC CAPITAL LETTER HA"
        txt = re.sub(r"&#x0*?425;", "Х", txt)
        txt = re.sub(r"&#0*?1061;", "Х", txt)
        txt = re.sub(r"&KHcy;", "Х", txt)

        # "U+00426", "CYRILLIC CAPITAL LETTER TSE"
        txt = re.sub(r"&#x0*?426;", "Ц", txt)
        txt = re.sub(r"&#0*?1062;", "Ц", txt)
        txt = re.sub(r"&TScy;", "Ц", txt)

        # "U+00427", "CYRILLIC CAPITAL LETTER CHE"
        txt = re.sub(r"&#x0*?427;", "Ч", txt)
        txt = re.sub(r"&#0*?1063;", "Ч", txt)
        txt = re.sub(r"&CHcy;", "Ч", txt)

        # "U+00428", "CYRILLIC CAPITAL LETTER SHA"
        txt = re.sub(r"&#x0*?428;", "Ш", txt)
        txt = re.sub(r"&#0*?1064;", "Ш", txt)
        txt = re.sub(r"&SHcy;", "Ш", txt)

        # "U+00429", "CYRILLIC CAPITAL LETTER SHCHA"
        txt = re.sub(r"&#x0*?429;", "Щ", txt)
        txt = re.sub(r"&#0*?1065;", "Щ", txt)
        txt = re.sub(r"&SHCHcy;", "Щ", txt)

        # "U+0042A", "CYRILLIC CAPITAL LETTER HARD SIGN"
        txt = re.sub(r"&#x0*?42A;", "Ъ", txt)
        txt = re.sub(r"&#0*?1066;", "Ъ", txt)
        txt = re.sub(r"&HARDcy;", "Ъ", txt)

        # "U+0042B", "CYRILLIC CAPITAL LETTER YERU"
        txt = re.sub(r"&#x0*?42B;", "Ы", txt)
        txt = re.sub(r"&#0*?1067;", "Ы", txt)
        txt = re.sub(r"&Ycy;", "Ы", txt)

        # "U+0042C", "CYRILLIC CAPITAL LETTER SOFT SIGN"
        txt = re.sub(r"&#x0*?42C;", "Ь", txt)
        txt = re.sub(r"&#0*?1068;", "Ь", txt)
        txt = re.sub(r"&SOFTcy;", "Ь", txt)

        # "U+0042D", "CYRILLIC CAPITAL LETTER E"
        txt = re.sub(r"&#x0*?42D;", "Э", txt)
        txt = re.sub(r"&#0*?1069;", "Э", txt)
        txt = re.sub(r"&Ecy;", "Э", txt)

        # "U+0042E", "CYRILLIC CAPITAL LETTER YU"
        txt = re.sub(r"&#x0*?42E;", "Ю", txt)
        txt = re.sub(r"&#0*?1070;", "Ю", txt)
        txt = re.sub(r"&YUcy;", "Ю", txt)

        # "U+0042F", "CYRILLIC CAPITAL LETTER YA"
        txt = re.sub(r"&#x0*?42F;", "Я", txt)
        txt = re.sub(r"&#0*?1071;", "Я", txt)
        txt = re.sub(r"&YAcy;", "Я", txt)

        # "U+00430", "CYRILLIC SMALL LETTER A"
        txt = re.sub(r"&#x0*?430;", "а", txt)
        txt = re.sub(r"&#0*?1072;", "а", txt)
        txt = re.sub(r"&acy;", "а", txt)

        # "U+00431", "CYRILLIC SMALL LETTER BE"
        txt = re.sub(r"&#x0*?431;", "б", txt)
        txt = re.sub(r"&#0*?1073;", "б", txt)
        txt = re.sub(r"&bcy;", "б", txt)

        # "U+00432", "CYRILLIC SMALL LETTER VE"
        txt = re.sub(r"&#x0*?432;", "в", txt)
        txt = re.sub(r"&#0*?1074;", "в", txt)
        txt = re.sub(r"&vcy;", "в", txt)

        # "U+00433", "CYRILLIC SMALL LETTER GHE"
        txt = re.sub(r"&#x0*?433;", "г", txt)
        txt = re.sub(r"&#0*?1075;", "г", txt)
        txt = re.sub(r"&gcy;", "г", txt)

        # "U+00434", "CYRILLIC SMALL LETTER DE"
        txt = re.sub(r"&#x0*?434;", "д", txt)
        txt = re.sub(r"&#0*?1076;", "д", txt)
        txt = re.sub(r"&dcy;", "д", txt)

        # "U+00435", "CYRILLIC SMALL LETTER IE"
        txt = re.sub(r"&#x0*?435;", "е", txt)
        txt = re.sub(r"&#0*?1077;", "е", txt)
        txt = re.sub(r"&iecy;", "е", txt)

        # "U+00436", "CYRILLIC SMALL LETTER ZHE"
        txt = re.sub(r"&#x0*?436;", "ж", txt)
        txt = re.sub(r"&#0*?1078;", "ж", txt)
        txt = re.sub(r"&zhcy;", "ж", txt)

        # "U+00437", "CYRILLIC SMALL LETTER ZE"
        txt = re.sub(r"&#x0*?437;", "з", txt)
        txt = re.sub(r"&#0*?1079;", "з", txt)
        txt = re.sub(r"&zcy;", "з", txt)

        # "U+00438", "CYRILLIC SMALL LETTER I"
        txt = re.sub(r"&#x0*?438;", "и", txt)
        txt = re.sub(r"&#0*?1080;", "и", txt)
        txt = re.sub(r"&icy;", "и", txt)

        # "U+00439", "CYRILLIC SMALL LETTER SHORT I"
        txt = re.sub(r"&#x0*?439;", "й", txt)
        txt = re.sub(r"&#0*?1081;", "й", txt)
        txt = re.sub(r"&jcy;", "й", txt)

        # "U+0043A", "CYRILLIC SMALL LETTER KA"
        txt = re.sub(r"&#x0*?43A;", "к", txt)
        txt = re.sub(r"&#0*?1082;", "к", txt)
        txt = re.sub(r"&kcy;", "к", txt)

        # "U+0043B", "CYRILLIC SMALL LETTER EL"
        txt = re.sub(r"&#x0*?43B;", "л", txt)
        txt = re.sub(r"&#0*?1083;", "л", txt)
        txt = re.sub(r"&lcy;", "л", txt)

        # "U+0043C", "CYRILLIC SMALL LETTER EM"
        txt = re.sub(r"&#x0*?43C;", "м", txt)
        txt = re.sub(r"&#0*?1084;", "м", txt)
        txt = re.sub(r"&mcy;", "м", txt)

        # "U+0043D", "CYRILLIC SMALL LETTER EN"
        txt = re.sub(r"&#x0*?43D;", "н", txt)
        txt = re.sub(r"&#0*?1085;", "н", txt)
        txt = re.sub(r"&ncy;", "н", txt)

        # "U+0043E", "CYRILLIC SMALL LETTER O"
        txt = re.sub(r"&#x0*?43E;", "о", txt)
        txt = re.sub(r"&#0*?1086;", "о", txt)
        txt = re.sub(r"&ocy;", "о", txt)

        # "U+0043F", "CYRILLIC SMALL LETTER PE"
        txt = re.sub(r"&#x0*?43F;", "п", txt)
        txt = re.sub(r"&#0*?1087;", "п", txt)
        txt = re.sub(r"&pcy;", "п", txt)

        # "U+00440", "CYRILLIC SMALL LETTER ER"
        txt = re.sub(r"&#x0*?440;", "р", txt)
        txt = re.sub(r"&#0*?1088;", "р", txt)
        txt = re.sub(r"&rcy;", "р", txt)

        # "U+00441", "CYRILLIC SMALL LETTER ES"
        txt = re.sub(r"&#x0*?441;", "с", txt)
        txt = re.sub(r"&#0*?1089;", "с", txt)
        txt = re.sub(r"&scy;", "с", txt)

        # "U+00442", "CYRILLIC SMALL LETTER TE"
        txt = re.sub(r"&#x0*?442;", "т", txt)
        txt = re.sub(r"&#0*?1090;", "т", txt)
        txt = re.sub(r"&tcy;", "т", txt)

        # "U+00443", "CYRILLIC SMALL LETTER U"
        txt = re.sub(r"&#x0*?443;", "у", txt)
        txt = re.sub(r"&#0*?1091;", "у", txt)
        txt = re.sub(r"&ucy;", "у", txt)

        # "U+00444", "CYRILLIC SMALL LETTER EF"
        txt = re.sub(r"&#x0*?444;", "ф", txt)
        txt = re.sub(r"&#0*?1092;", "ф", txt)
        txt = re.sub(r"&fcy;", "ф", txt)

        # "U+00445", "CYRILLIC SMALL LETTER HA"
        txt = re.sub(r"&#x0*?445;", "х", txt)
        txt = re.sub(r"&#0*?1093;", "х", txt)
        txt = re.sub(r"&khcy;", "х", txt)

        # "U+00446", "CYRILLIC SMALL LETTER TSE"
        txt = re.sub(r"&#x0*?446;", "ц", txt)
        txt = re.sub(r"&#0*?1094;", "ц", txt)
        txt = re.sub(r"&tscy;", "ц", txt)

        # "U+00447", "CYRILLIC SMALL LETTER CHE"
        txt = re.sub(r"&#x0*?447;", "ч", txt)
        txt = re.sub(r"&#0*?1095;", "ч", txt)
        txt = re.sub(r"&chcy;", "ч", txt)

        # "U+00448", "CYRILLIC SMALL LETTER SHA"
        txt = re.sub(r"&#x0*?448;", "ш", txt)
        txt = re.sub(r"&#0*?1096;", "ш", txt)
        txt = re.sub(r"&shcy;", "ш", txt)

        # "U+00449", "CYRILLIC SMALL LETTER SHCHA"
        txt = re.sub(r"&#x0*?449;", "щ", txt)
        txt = re.sub(r"&#0*?1097;", "щ", txt)
        txt = re.sub(r"&shchcy;", "щ", txt)

        # "U+0044A", "CYRILLIC SMALL LETTER HARD SIGN"
        txt = re.sub(r"&#x0*?44A;", "ъ", txt)
        txt = re.sub(r"&#0*?1098;", "ъ", txt)
        txt = re.sub(r"&hardcy;", "ъ", txt)

        # "U+0044B", "CYRILLIC SMALL LETTER YERU"
        txt = re.sub(r"&#x0*?44B;", "ы", txt)
        txt = re.sub(r"&#0*?1099;", "ы", txt)
        txt = re.sub(r"&ycy;", "ы", txt)

        # "U+0044C", "CYRILLIC SMALL LETTER SOFT SIGN"
        txt = re.sub(r"&#x0*?44C;", "ь", txt)
        txt = re.sub(r"&#0*?1100;", "ь", txt)
        txt = re.sub(r"&softcy;", "ь", txt)

        # "U+0044D", "CYRILLIC SMALL LETTER E"
        txt = re.sub(r"&#x0*?44D;", "э", txt)
        txt = re.sub(r"&#0*?1101;", "э", txt)
        txt = re.sub(r"&ecy;", "э", txt)

        # "U+0044E", "CYRILLIC SMALL LETTER YU"
        txt = re.sub(r"&#x0*?44E;", "ю", txt)
        txt = re.sub(r"&#0*?1102;", "ю", txt)
        txt = re.sub(r"&yucy;", "ю", txt)

        # "U+0044F", "CYRILLIC SMALL LETTER YA"
        txt = re.sub(r"&#x0*?44F;", "я", txt)
        txt = re.sub(r"&#0*?1103;", "я", txt)
        txt = re.sub(r"&yacy;", "я", txt)

        # "U+00451", "CYRILLIC SMALL LETTER IO"
        txt = re.sub(r"&#x0*?451;", "ё", txt)
        txt = re.sub(r"&#0*?1105;", "ё", txt)
        txt = re.sub(r"&iocy;", "ё", txt)

        # "U+00452", "CYRILLIC SMALL LETTER DJE"
        txt = re.sub(r"&#x0*?452;", "ђ", txt)
        txt = re.sub(r"&#0*?1106;", "ђ", txt)
        txt = re.sub(r"&djcy;", "ђ", txt)

        # "U+00453", "CYRILLIC SMALL LETTER GJE"
        txt = re.sub(r"&#x0*?453;", "ѓ", txt)
        txt = re.sub(r"&#0*?1107;", "ѓ", txt)
        txt = re.sub(r"&gjcy;", "ѓ", txt)

        # "U+00454", "CYRILLIC SMALL LETTER UKRAINIAN IE"
        txt = re.sub(r"&#x0*?454;", "є", txt)
        txt = re.sub(r"&#0*?1108;", "є", txt)
        txt = re.sub(r"&jukcy;", "є", txt)

        # "U+00455", "CYRILLIC SMALL LETTER DZE"
        txt = re.sub(r"&#x0*?455;", "ѕ", txt)
        txt = re.sub(r"&#0*?1109;", "ѕ", txt)
        txt = re.sub(r"&dscy;", "ѕ", txt)

        # "U+00456", "CYRILLIC SMALL LETTER BYELORUSSIAN-UKRAINIAN I"
        txt = re.sub(r"&#x0*?456;", "і", txt)
        txt = re.sub(r"&#0*?1110;", "і", txt)
        txt = re.sub(r"&iukcy;", "і", txt)

        # "U+00457", "CYRILLIC SMALL LETTER YI"
        txt = re.sub(r"&#x0*?457;", "ї", txt)
        txt = re.sub(r"&#0*?1111;", "ї", txt)
        txt = re.sub(r"&yicy;", "ї", txt)

        # "U+00458", "CYRILLIC SMALL LETTER JE"
        txt = re.sub(r"&#x0*?458;", "ј", txt)
        txt = re.sub(r"&#0*?1112;", "ј", txt)
        txt = re.sub(r"&jsercy;", "ј", txt)

        # "U+00459", "CYRILLIC SMALL LETTER LJE"
        txt = re.sub(r"&#x0*?459;", "љ", txt)
        txt = re.sub(r"&#0*?1113;", "љ", txt)
        txt = re.sub(r"&ljcy;", "љ", txt)

        # "U+0045A", "CYRILLIC SMALL LETTER NJE"
        txt = re.sub(r"&#x0*?45A;", "њ", txt)
        txt = re.sub(r"&#0*?1114;", "њ", txt)
        txt = re.sub(r"&njcy;", "њ", txt)

        # "U+0045B", "CYRILLIC SMALL LETTER TSHE"
        txt = re.sub(r"&#x0*?45B;", "ћ", txt)
        txt = re.sub(r"&#0*?1115;", "ћ", txt)
        txt = re.sub(r"&tshcy;", "ћ", txt)

        # "U+0045C", "CYRILLIC SMALL LETTER KJE"
        txt = re.sub(r"&#x0*?45C;", "ќ", txt)
        txt = re.sub(r"&#0*?1116;", "ќ", txt)
        txt = re.sub(r"&kjcy;", "ќ", txt)

        # "U+0045E", "CYRILLIC SMALL LETTER SHORT U"
        txt = re.sub(r"&#x0*?45E;", "ў", txt)
        txt = re.sub(r"&#0*?1118;", "ў", txt)
        txt = re.sub(r"&ubrcy;", "ў", txt)

        # "U+0045F", "CYRILLIC SMALL LETTER DZHE"
        txt = re.sub(r"&#x0*?45F;", "џ", txt)
        txt = re.sub(r"&#0*?1119;", "џ", txt)
        txt = re.sub(r"&dzcy;", "џ", txt)

        # "U+02002", "EN SPACE"
        txt = re.sub(r"&#x0*?2002;", " ", txt)
        txt = re.sub(r"&#0*?8194;", " ", txt)
        txt = re.sub(r"&ensp;", " ", txt)

        # "U+02003", "EM SPACE"
        txt = re.sub(r"&#x0*?2003;", " ", txt)
        txt = re.sub(r"&#0*?8195;", " ", txt)
        txt = re.sub(r"&emsp;", " ", txt)

        # "U+02004", "THREE-PER-EM SPACE"
        txt = re.sub(r"&#x0*?2004;", " ", txt)
        txt = re.sub(r"&#0*?8196;", " ", txt)
        txt = re.sub(r"&emsp13;", " ", txt)

        # "U+02005", "FOUR-PER-EM SPACE"
        txt = re.sub(r"&#x0*?2005;", " ", txt)
        txt = re.sub(r"&#0*?8197;", " ", txt)
        txt = re.sub(r"&emsp14;", " ", txt)

        # "U+02007", "FIGURE SPACE"
        txt = re.sub(r"&#x0*?2007;", " ", txt)
        txt = re.sub(r"&#0*?8199;", " ", txt)
        txt = re.sub(r"&numsp;", " ", txt)

        # "U+02008", "PUNCTUATION SPACE"
        txt = re.sub(r"&#x0*?2008;", " ", txt)
        txt = re.sub(r"&#0*?8200;", " ", txt)
        txt = re.sub(r"&puncsp;", " ", txt)

        # "U+02009", "THIN SPACE"
        txt = re.sub(r"&#x0*?2009;", " ", txt)
        txt = re.sub(r"&#0*?8201;", " ", txt)
        txt = re.sub(r"&thinsp;", " ", txt)
        txt = re.sub(r"&ThinSpace;", " ", txt)

        # "U+0200A", "HAIR SPACE"
        txt = re.sub(r"&#x0*?200A;", " ", txt)
        txt = re.sub(r"&#0*?8202;", " ", txt)
        txt = re.sub(r"&hairsp;", " ", txt)
        txt = re.sub(r"&VeryThinSpace;", " ", txt)

        # "U+0200B", "ZERO WIDTH SPACE"
        txt = re.sub(r"&#x0*?200B;", "​", txt)
        txt = re.sub(r"&#0*?8203;", "​", txt)
        txt = re.sub(r"&ZeroWidthSpace;", "​", txt)
        txt = re.sub(r"&NegativeVeryThinSpace;", "​", txt)
        txt = re.sub(r"&NegativeThinSpace;", "​", txt)
        txt = re.sub(r"&NegativeMediumSpace;", "​", txt)
        txt = re.sub(r"&NegativeThickSpace;", "​", txt)

        # "U+0200C", "ZERO WIDTH NON-JOINER"
        txt = re.sub(r"&#x0*?200C;", "‌", txt)
        txt = re.sub(r"&#0*?8204;", "‌", txt)
        txt = re.sub(r"&zwnj;", "‌", txt)

        # "U+0200D", "ZERO WIDTH JOINER"
        txt = re.sub(r"&#x0*?200D;", "‍", txt)
        txt = re.sub(r"&#0*?8205;", "‍", txt)
        txt = re.sub(r"&zwj;", "‍", txt)

        # "U+0200E", "LEFT-TO-RIGHT MARK"
        txt = re.sub(r"&#x0*?200E;", "‎", txt)
        txt = re.sub(r"&#0*?8206;", "‎", txt)
        txt = re.sub(r"&lrm;", "‎", txt)

        # "U+0200F", "RIGHT-TO-LEFT MARK"
        txt = re.sub(r"&#x0*?200F;", "‏", txt)
        txt = re.sub(r"&#0*?8207;", "‏", txt)
        txt = re.sub(r"&rlm;", "‏", txt)

        # "U+02010", "HYPHEN"
        txt = re.sub(r"&#x0*?2010;", "‐", txt)
        txt = re.sub(r"&#0*?8208;", "‐", txt)
        txt = re.sub(r"&hyphen;", "‐", txt)
        txt = re.sub(r"&dash;", "‐", txt)

        # "U+02013", "EN DASH"
        txt = re.sub(r"&#x0*?2013;", "–", txt)
        txt = re.sub(r"&#0*?8211;", "–", txt)
        txt = re.sub(r"&ndash;", "–", txt)

        # "U+02014", "EM DASH"
        txt = re.sub(r"&#x0*?2014;", "—", txt)
        txt = re.sub(r"&#0*?8212;", "—", txt)
        txt = re.sub(r"&mdash;", "—", txt)

        # "U+02015", "HORIZONTAL BAR"
        txt = re.sub(r"&#x0*?2015;", "―", txt)
        txt = re.sub(r"&#0*?8213;", "―", txt)
        txt = re.sub(r"&horbar;", "―", txt)

        # "U+02016", "DOUBLE VERTICAL LINE"
        txt = re.sub(r"&#x0*?2016;", "‖", txt)
        txt = re.sub(r"&#0*?8214;", "‖", txt)
        txt = re.sub(r"&Verbar;", "‖", txt)
        txt = re.sub(r"&Vert;", "‖", txt)

        # "U+02018", "LEFT SINGLE QUOTATION MARK"
        txt = re.sub(r"&#x0*?2018;", "‘", txt)
        txt = re.sub(r"&#0*?8216;", "‘", txt)
        txt = re.sub(r"&lsquo;", "‘", txt)
        txt = re.sub(r"&OpenCurlyQuote;", "‘", txt)

        # "U+02019", "RIGHT SINGLE QUOTATION MARK"
        txt = re.sub(r"&#x0*?2019;", "’", txt)
        txt = re.sub(r"&#0*?8217;", "’", txt)
        txt = re.sub(r"&rsquo;", "’", txt)
        txt = re.sub(r"&rsquor;", "’", txt)
        txt = re.sub(r"&CloseCurlyQuote;", "’", txt)

        # "U+0201A", "SINGLE LOW-9 QUOTATION MARK"
        txt = re.sub(r"&#x0*?201A;", "‚", txt)
        txt = re.sub(r"&#0*?8218;", "‚", txt)
        txt = re.sub(r"&lsquor;", "‚", txt)
        txt = re.sub(r"&sbquo;", "‚", txt)

        # "U+0201C", "LEFT DOUBLE QUOTATION MARK"
        txt = re.sub(r"&#x0*?201C;", "“", txt)
        txt = re.sub(r"&#0*?8220;", "“", txt)
        txt = re.sub(r"&ldquo;", "“", txt)
        txt = re.sub(r"&OpenCurlyDoubleQuote;", "“", txt)

        # "U+0201D", "RIGHT DOUBLE QUOTATION MARK"
        txt = re.sub(r"&#x0*?201D;", "”", txt)
        txt = re.sub(r"&#0*?8221;", "”", txt)
        txt = re.sub(r"&rdquo;", "”", txt)
        txt = re.sub(r"&rdquor;", "”", txt)
        txt = re.sub(r"&CloseCurlyDoubleQuote;", "”", txt)

        # "U+0201E", "DOUBLE LOW-9 QUOTATION MARK"
        txt = re.sub(r"&#x0*?201E;", "„", txt)
        txt = re.sub(r"&#0*?8222;", "„", txt)
        txt = re.sub(r"&ldquor;", "„", txt)
        txt = re.sub(r"&bdquo;", "„", txt)

        # "U+02020", "DAGGER"
        txt = re.sub(r"&#x0*?2020;", "†", txt)
        txt = re.sub(r"&#0*?8224;", "†", txt)
        txt = re.sub(r"&dagger;", "†", txt)

        # "U+02021", "DOUBLE DAGGER"
        txt = re.sub(r"&#x0*?2021;", "‡", txt)
        txt = re.sub(r"&#0*?8225;", "‡", txt)
        txt = re.sub(r"&Dagger;", "‡", txt)
        txt = re.sub(r"&ddagger;", "‡", txt)

        # "U+02022", "BULLET"
        txt = re.sub(r"&#x0*?2022;", "•", txt)
        txt = re.sub(r"&#0*?8226;", "•", txt)
        txt = re.sub(r"&bull;", "•", txt)
        txt = re.sub(r"&bullet;", "•", txt)

        # "U+02025", "TWO DOT LEADER"
        txt = re.sub(r"&#x0*?2025;", "‥", txt)
        txt = re.sub(r"&#0*?8229;", "‥", txt)
        txt = re.sub(r"&nldr;", "‥", txt)

        # "U+02026", "HORIZONTAL ELLIPSIS"
        txt = re.sub(r"&#x0*?2026;", "…", txt)
        txt = re.sub(r"&#0*?8230;", "…", txt)
        txt = re.sub(r"&hellip;", "…", txt)
        txt = re.sub(r"&mldr;", "…", txt)

        # "U+02030", "PER MILLE SIGN"
        txt = re.sub(r"&#x0*?2030;", "‰", txt)
        txt = re.sub(r"&#0*?8240;", "‰", txt)
        txt = re.sub(r"&permil;", "‰", txt)

        # "U+02031", "PER TEN THOUSAND SIGN"
        txt = re.sub(r"&#x0*?2031;", "‱", txt)
        txt = re.sub(r"&#0*?8241;", "‱", txt)
        txt = re.sub(r"&pertenk;", "‱", txt)

        # "U+02032", "PRIME"
        txt = re.sub(r"&#x0*?2032;", "′", txt)
        txt = re.sub(r"&#0*?8242;", "′", txt)
        txt = re.sub(r"&prime;", "′", txt)

        # "U+02033", "DOUBLE PRIME"
        txt = re.sub(r"&#x0*?2033;", "″", txt)
        txt = re.sub(r"&#0*?8243;", "″", txt)
        txt = re.sub(r"&Prime;", "″", txt)

        # "U+02034", "TRIPLE PRIME"
        txt = re.sub(r"&#x0*?2034;", "‴", txt)
        txt = re.sub(r"&#0*?8244;", "‴", txt)
        txt = re.sub(r"&tprime;", "‴", txt)

        # "U+02035", "REVERSED PRIME"
        txt = re.sub(r"&#x0*?2035;", "‵", txt)
        txt = re.sub(r"&#0*?8245;", "‵", txt)
        txt = re.sub(r"&bprime;", "‵", txt)
        txt = re.sub(r"&backprime;", "‵", txt)

        # "U+02039", "SINGLE LEFT-POINTING ANGLE QUOTATION MARK"
        txt = re.sub(r"&#x0*?2039;", "‹", txt)
        txt = re.sub(r"&#0*?8249;", "‹", txt)
        txt = re.sub(r"&lsaquo;", "‹", txt)

        # "U+0203A", "SINGLE RIGHT-POINTING ANGLE QUOTATION MARK"
        txt = re.sub(r"&#x0*?203A;", "›", txt)
        txt = re.sub(r"&#0*?8250;", "›", txt)
        txt = re.sub(r"&rsaquo;", "›", txt)

        # "U+0203E", "OVERLINE"
        txt = re.sub(r"&#x0*?203E;", "‾", txt)
        txt = re.sub(r"&#0*?8254;", "‾", txt)
        txt = re.sub(r"&oline;", "‾", txt)

        # "U+02041", "CARET INSERTION POINT"
        txt = re.sub(r"&#x0*?2041;", "⁁", txt)
        txt = re.sub(r"&#0*?8257;", "⁁", txt)
        txt = re.sub(r"&caret;", "⁁", txt)

        # "U+02043", "HYPHEN BULLET"
        txt = re.sub(r"&#x0*?2043;", "⁃", txt)
        txt = re.sub(r"&#0*?8259;", "⁃", txt)
        txt = re.sub(r"&hybull;", "⁃", txt)

        # "U+02044", "FRACTION SLASH"
        txt = re.sub(r"&#x0*?2044;", "⁄", txt)
        txt = re.sub(r"&#0*?8260;", "⁄", txt)
        txt = re.sub(r"&frasl;", "⁄", txt)

        # "U+0204F", "REVERSED SEMICOLON"
        txt = re.sub(r"&#x0*?204F;", "⁏", txt)
        txt = re.sub(r"&#0*?8271;", "⁏", txt)
        txt = re.sub(r"&bsemi;", "⁏", txt)

        # "U+02057", "QUADRUPLE PRIME"
        txt = re.sub(r"&#x0*?2057;", "⁗", txt)
        txt = re.sub(r"&#0*?8279;", "⁗", txt)
        txt = re.sub(r"&qprime;", "⁗", txt)

        # "U+0205F", "MEDIUM MATHEMATICAL SPACE"
        txt = re.sub(r"&#x0*?205F;", " ", txt)
        txt = re.sub(r"&#0*?8287;", " ", txt)
        txt = re.sub(r"&MediumSpace;", " ", txt)

        # "U+02060", "WORD JOINER"
        txt = re.sub(r"&#x0*?2060;", "⁠", txt)
        txt = re.sub(r"&#0*?8288;", "⁠", txt)
        txt = re.sub(r"&NoBreak;", "⁠", txt)

        # "U+02061", "FUNCTION APPLICATION"
        txt = re.sub(r"&#x0*?2061;", "⁡", txt)
        txt = re.sub(r"&#0*?8289;", "⁡", txt)
        txt = re.sub(r"&ApplyFunction;", "⁡", txt)
        txt = re.sub(r"&af;", "⁡", txt)

        # "U+02062", "INVISIBLE TIMES"
        txt = re.sub(r"&#x0*?2062;", "⁢", txt)
        txt = re.sub(r"&#0*?8290;", "⁢", txt)
        txt = re.sub(r"&InvisibleTimes;", "⁢", txt)
        txt = re.sub(r"&it;", "⁢", txt)

        # "U+02063", "INVISIBLE SEPARATOR"
        txt = re.sub(r"&#x0*?2063;", "⁣", txt)
        txt = re.sub(r"&#0*?8291;", "⁣", txt)
        txt = re.sub(r"&InvisibleComma;", "⁣", txt)
        txt = re.sub(r"&ic;", "⁣", txt)

        # "U+020AC", "EURO SIGN"
        txt = re.sub(r"&#x0*?20AC;", "€", txt)
        txt = re.sub(r"&#0*?8364;", "€", txt)
        txt = re.sub(r"&euro;", "€", txt)

        # "U+020DB", "COMBINING THREE DOTS ABOVE"
        txt = re.sub(r"&#x0*?20DB;", "⃛", txt)
        txt = re.sub(r"&#0*?8411;", "⃛", txt)
        txt = re.sub(r"&tdot;", "⃛", txt)
        txt = re.sub(r"&TripleDot;", "⃛", txt)

        # "U+020DC", "COMBINING FOUR DOTS ABOVE"
        txt = re.sub(r"&#x0*?20DC;", "⃜", txt)
        txt = re.sub(r"&#0*?8412;", "⃜", txt)
        txt = re.sub(r"&DotDot;", "⃜", txt)

        # "U+02102", "DOUBLE-STRUCK CAPITAL C"
        txt = re.sub(r"&#x0*?2102;", "ℂ", txt)
        txt = re.sub(r"&#0*?8450;", "ℂ", txt)
        txt = re.sub(r"&Copf;", "ℂ", txt)
        txt = re.sub(r"&complexes;", "ℂ", txt)

        # "U+02105", "CARE OF"
        txt = re.sub(r"&#x0*?2105;", "℅", txt)
        txt = re.sub(r"&#0*?8453;", "℅", txt)
        txt = re.sub(r"&incare;", "℅", txt)

        # "U+0210A", "SCRIPT SMALL G"
        txt = re.sub(r"&#x0*?210A;", "ℊ", txt)
        txt = re.sub(r"&#0*?8458;", "ℊ", txt)
        txt = re.sub(r"&gscr;", "ℊ", txt)

        # "U+0210B", "SCRIPT CAPITAL H"
        txt = re.sub(r"&#x0*?210B;", "ℋ", txt)
        txt = re.sub(r"&#0*?8459;", "ℋ", txt)
        txt = re.sub(r"&hamilt;", "ℋ", txt)
        txt = re.sub(r"&HilbertSpace;", "ℋ", txt)
        txt = re.sub(r"&Hscr;", "ℋ", txt)

        # "U+0210C", "BLACK-LETTER CAPITAL H"
        txt = re.sub(r"&#x0*?210C;", "ℌ", txt)
        txt = re.sub(r"&#0*?8460;", "ℌ", txt)
        txt = re.sub(r"&Hfr;", "ℌ", txt)
        txt = re.sub(r"&Poincareplane;", "ℌ", txt)

        # "U+0210D", "DOUBLE-STRUCK CAPITAL H"
        txt = re.sub(r"&#x0*?210D;", "ℍ", txt)
        txt = re.sub(r"&#0*?8461;", "ℍ", txt)
        txt = re.sub(r"&quaternions;", "ℍ", txt)
        txt = re.sub(r"&Hopf;", "ℍ", txt)

        # "U+0210E", "PLANCK CONSTANT"
        txt = re.sub(r"&#x0*?210E;", "ℎ", txt)
        txt = re.sub(r"&#0*?8462;", "ℎ", txt)
        txt = re.sub(r"&planckh;", "ℎ", txt)

        # "U+0210F", "PLANCK CONSTANT OVER TWO PI"
        txt = re.sub(r"&#x0*?210F;", "ℏ", txt)
        txt = re.sub(r"&#0*?8463;", "ℏ", txt)
        txt = re.sub(r"&planck;", "ℏ", txt)
        txt = re.sub(r"&hbar;", "ℏ", txt)
        txt = re.sub(r"&plankv;", "ℏ", txt)
        txt = re.sub(r"&hslash;", "ℏ", txt)

        # "U+02110", "SCRIPT CAPITAL I"
        txt = re.sub(r"&#x0*?2110;", "ℐ", txt)
        txt = re.sub(r"&#0*?8464;", "ℐ", txt)
        txt = re.sub(r"&Iscr;", "ℐ", txt)
        txt = re.sub(r"&imagline;", "ℐ", txt)

        # "U+02111", "BLACK-LETTER CAPITAL I"
        txt = re.sub(r"&#x0*?2111;", "ℑ", txt)
        txt = re.sub(r"&#0*?8465;", "ℑ", txt)
        txt = re.sub(r"&image;", "ℑ", txt)
        txt = re.sub(r"&Im;", "ℑ", txt)
        txt = re.sub(r"&imagpart;", "ℑ", txt)
        txt = re.sub(r"&Ifr;", "ℑ", txt)

        # "U+02112", "SCRIPT CAPITAL L"
        txt = re.sub(r"&#x0*?2112;", "ℒ", txt)
        txt = re.sub(r"&#0*?8466;", "ℒ", txt)
        txt = re.sub(r"&Lscr;", "ℒ", txt)
        txt = re.sub(r"&lagran;", "ℒ", txt)
        txt = re.sub(r"&Laplacetrf;", "ℒ", txt)

        # "U+02113", "SCRIPT SMALL L"
        txt = re.sub(r"&#x0*?2113;", "ℓ", txt)
        txt = re.sub(r"&#0*?8467;", "ℓ", txt)
        txt = re.sub(r"&ell;", "ℓ", txt)

        # "U+02115", "DOUBLE-STRUCK CAPITAL N"
        txt = re.sub(r"&#x0*?2115;", "ℕ", txt)
        txt = re.sub(r"&#0*?8469;", "ℕ", txt)
        txt = re.sub(r"&Nopf;", "ℕ", txt)
        txt = re.sub(r"&naturals;", "ℕ", txt)

        # "U+02116", "NUMERO SIGN"
        txt = re.sub(r"&#x0*?2116;", "№", txt)
        txt = re.sub(r"&#0*?8470;", "№", txt)
        txt = re.sub(r"&numero;", "№", txt)

        # "U+02117", "SOUND RECORDING COPYRIGHT"
        txt = re.sub(r"&#x0*?2117;", "℗", txt)
        txt = re.sub(r"&#0*?8471;", "℗", txt)
        txt = re.sub(r"&copysr;", "℗", txt)

        # "U+02118", "SCRIPT CAPITAL P"
        txt = re.sub(r"&#x0*?2118;", "℘", txt)
        txt = re.sub(r"&#0*?8472;", "℘", txt)
        txt = re.sub(r"&weierp;", "℘", txt)
        txt = re.sub(r"&wp;", "℘", txt)

        # "U+02119", "DOUBLE-STRUCK CAPITAL P"
        txt = re.sub(r"&#x0*?2119;", "ℙ", txt)
        txt = re.sub(r"&#0*?8473;", "ℙ", txt)
        txt = re.sub(r"&Popf;", "ℙ", txt)
        txt = re.sub(r"&primes;", "ℙ", txt)

        # "U+0211A", "DOUBLE-STRUCK CAPITAL Q"
        txt = re.sub(r"&#x0*?211A;", "ℚ", txt)
        txt = re.sub(r"&#0*?8474;", "ℚ", txt)
        txt = re.sub(r"&rationals;", "ℚ", txt)
        txt = re.sub(r"&Qopf;", "ℚ", txt)

        # "U+0211B", "SCRIPT CAPITAL R"
        txt = re.sub(r"&#x0*?211B;", "ℛ", txt)
        txt = re.sub(r"&#0*?8475;", "ℛ", txt)
        txt = re.sub(r"&Rscr;", "ℛ", txt)
        txt = re.sub(r"&realine;", "ℛ", txt)

        # "U+0211C", "BLACK-LETTER CAPITAL R"
        txt = re.sub(r"&#x0*?211C;", "ℜ", txt)
        txt = re.sub(r"&#0*?8476;", "ℜ", txt)
        txt = re.sub(r"&real;", "ℜ", txt)
        txt = re.sub(r"&Re;", "ℜ", txt)
        txt = re.sub(r"&realpart;", "ℜ", txt)
        txt = re.sub(r"&Rfr;", "ℜ", txt)

        # "U+0211D", "DOUBLE-STRUCK CAPITAL R"
        txt = re.sub(r"&#x0*?211D;", "ℝ", txt)
        txt = re.sub(r"&#0*?8477;", "ℝ", txt)
        txt = re.sub(r"&reals;", "ℝ", txt)
        txt = re.sub(r"&Ropf;", "ℝ", txt)

        # "U+0211E", "PRESCRIPTION TAKE"
        txt = re.sub(r"&#x0*?211E;", "℞", txt)
        txt = re.sub(r"&#0*?8478;", "℞", txt)
        txt = re.sub(r"&rx;", "℞", txt)

        # "U+02122", "TRADE MARK SIGN"
        txt = re.sub(r"&#x0*?2122;", "™", txt)
        txt = re.sub(r"&#0*?8482;", "™", txt)
        txt = re.sub(r"&trade;", "™", txt)
        txt = re.sub(r"&TRADE;", "™", txt)

        # "U+02124", "DOUBLE-STRUCK CAPITAL Z"
        txt = re.sub(r"&#x0*?2124;", "ℤ", txt)
        txt = re.sub(r"&#0*?8484;", "ℤ", txt)
        txt = re.sub(r"&integers;", "ℤ", txt)
        txt = re.sub(r"&Zopf;", "ℤ", txt)

        # "U+02126", "OHM SIGN"
        txt = re.sub(r"&#x0*?2126;", "Ω", txt)
        txt = re.sub(r"&#0*?8486;", "Ω", txt)
        txt = re.sub(r"&ohm;", "Ω", txt)

        # "U+02127", "INVERTED OHM SIGN"
        txt = re.sub(r"&#x0*?2127;", "℧", txt)
        txt = re.sub(r"&#0*?8487;", "℧", txt)
        txt = re.sub(r"&mho;", "℧", txt)

        # "U+02128", "BLACK-LETTER CAPITAL Z"
        txt = re.sub(r"&#x0*?2128;", "ℨ", txt)
        txt = re.sub(r"&#0*?8488;", "ℨ", txt)
        txt = re.sub(r"&Zfr;", "ℨ", txt)
        txt = re.sub(r"&zeetrf;", "ℨ", txt)

        # "U+02129", "TURNED GREEK SMALL LETTER IOTA"
        txt = re.sub(r"&#x0*?2129;", "℩", txt)
        txt = re.sub(r"&#0*?8489;", "℩", txt)
        txt = re.sub(r"&iiota;", "℩", txt)

        # "U+0212B", "ANGSTROM SIGN"
        txt = re.sub(r"&#x0*?212B;", "Å", txt)
        txt = re.sub(r"&#0*?8491;", "Å", txt)
        txt = re.sub(r"&angst;", "Å", txt)

        # "U+0212C", "SCRIPT CAPITAL B"
        txt = re.sub(r"&#x0*?212C;", "ℬ", txt)
        txt = re.sub(r"&#0*?8492;", "ℬ", txt)
        txt = re.sub(r"&bernou;", "ℬ", txt)
        txt = re.sub(r"&Bernoullis;", "ℬ", txt)
        txt = re.sub(r"&Bscr;", "ℬ", txt)

        # "U+0212D", "BLACK-LETTER CAPITAL C"
        txt = re.sub(r"&#x0*?212D;", "ℭ", txt)
        txt = re.sub(r"&#0*?8493;", "ℭ", txt)
        txt = re.sub(r"&Cfr;", "ℭ", txt)
        txt = re.sub(r"&Cayleys;", "ℭ", txt)

        # "U+0212F", "SCRIPT SMALL E"
        txt = re.sub(r"&#x0*?212F;", "ℯ", txt)
        txt = re.sub(r"&#0*?8495;", "ℯ", txt)
        txt = re.sub(r"&escr;", "ℯ", txt)

        # "U+02130", "SCRIPT CAPITAL E"
        txt = re.sub(r"&#x0*?2130;", "ℰ", txt)
        txt = re.sub(r"&#0*?8496;", "ℰ", txt)
        txt = re.sub(r"&Escr;", "ℰ", txt)
        txt = re.sub(r"&expectation;", "ℰ", txt)

        # "U+02131", "SCRIPT CAPITAL F"
        txt = re.sub(r"&#x0*?2131;", "ℱ", txt)
        txt = re.sub(r"&#0*?8497;", "ℱ", txt)
        txt = re.sub(r"&Fscr;", "ℱ", txt)
        txt = re.sub(r"&Fouriertrf;", "ℱ", txt)

        # "U+02133", "SCRIPT CAPITAL M"
        txt = re.sub(r"&#x0*?2133;", "ℳ", txt)
        txt = re.sub(r"&#0*?8499;", "ℳ", txt)
        txt = re.sub(r"&phmmat;", "ℳ", txt)
        txt = re.sub(r"&Mellintrf;", "ℳ", txt)
        txt = re.sub(r"&Mscr;", "ℳ", txt)

        # "U+02134", "SCRIPT SMALL O"
        txt = re.sub(r"&#x0*?2134;", "ℴ", txt)
        txt = re.sub(r"&#0*?8500;", "ℴ", txt)
        txt = re.sub(r"&order;", "ℴ", txt)
        txt = re.sub(r"&orderof;", "ℴ", txt)
        txt = re.sub(r"&oscr;", "ℴ", txt)

        # "U+02135", "ALEF SYMBOL"
        txt = re.sub(r"&#x0*?2135;", "ℵ", txt)
        txt = re.sub(r"&#0*?8501;", "ℵ", txt)
        txt = re.sub(r"&alefsym;", "ℵ", txt)
        txt = re.sub(r"&aleph;", "ℵ", txt)

        # "U+02136", "BET SYMBOL"
        txt = re.sub(r"&#x0*?2136;", "ℶ", txt)
        txt = re.sub(r"&#0*?8502;", "ℶ", txt)
        txt = re.sub(r"&beth;", "ℶ", txt)

        # "U+02137", "GIMEL SYMBOL"
        txt = re.sub(r"&#x0*?2137;", "ℷ", txt)
        txt = re.sub(r"&#0*?8503;", "ℷ", txt)
        txt = re.sub(r"&gimel;", "ℷ", txt)

        # "U+02138", "DALET SYMBOL"
        txt = re.sub(r"&#x0*?2138;", "ℸ", txt)
        txt = re.sub(r"&#0*?8504;", "ℸ", txt)
        txt = re.sub(r"&daleth;", "ℸ", txt)

        # "U+02145", "DOUBLE-STRUCK ITALIC CAPITAL D"
        txt = re.sub(r"&#x0*?2145;", "ⅅ", txt)
        txt = re.sub(r"&#0*?8517;", "ⅅ", txt)
        txt = re.sub(r"&CapitalDifferentialD;", "ⅅ", txt)
        txt = re.sub(r"&DD;", "ⅅ", txt)

        # "U+02146", "DOUBLE-STRUCK ITALIC SMALL D"
        txt = re.sub(r"&#x0*?2146;", "ⅆ", txt)
        txt = re.sub(r"&#0*?8518;", "ⅆ", txt)
        txt = re.sub(r"&DifferentialD;", "ⅆ", txt)
        txt = re.sub(r"&dd;", "ⅆ", txt)

        # "U+02147", "DOUBLE-STRUCK ITALIC SMALL E"
        txt = re.sub(r"&#x0*?2147;", "ⅇ", txt)
        txt = re.sub(r"&#0*?8519;", "ⅇ", txt)
        txt = re.sub(r"&ExponentialE;", "ⅇ", txt)
        txt = re.sub(r"&exponentiale;", "ⅇ", txt)
        txt = re.sub(r"&ee;", "ⅇ", txt)

        # "U+02148", "DOUBLE-STRUCK ITALIC SMALL I"
        txt = re.sub(r"&#x0*?2148;", "ⅈ", txt)
        txt = re.sub(r"&#0*?8520;", "ⅈ", txt)
        txt = re.sub(r"&ImaginaryI;", "ⅈ", txt)
        txt = re.sub(r"&ii;", "ⅈ", txt)

        # "U+02153", "VULGAR FRACTION ONE THIRD"
        txt = re.sub(r"&#x0*?2153;", "⅓", txt)
        txt = re.sub(r"&#0*?8531;", "⅓", txt)
        txt = re.sub(r"&frac13;", "⅓", txt)

        # "U+02154", "VULGAR FRACTION TWO THIRDS"
        txt = re.sub(r"&#x0*?2154;", "⅔", txt)
        txt = re.sub(r"&#0*?8532;", "⅔", txt)
        txt = re.sub(r"&frac23;", "⅔", txt)

        # "U+02155", "VULGAR FRACTION ONE FIFTH"
        txt = re.sub(r"&#x0*?2155;", "⅕", txt)
        txt = re.sub(r"&#0*?8533;", "⅕", txt)
        txt = re.sub(r"&frac15;", "⅕", txt)

        # "U+02156", "VULGAR FRACTION TWO FIFTHS"
        txt = re.sub(r"&#x0*?2156;", "⅖", txt)
        txt = re.sub(r"&#0*?8534;", "⅖", txt)
        txt = re.sub(r"&frac25;", "⅖", txt)

        # "U+02157", "VULGAR FRACTION THREE FIFTHS"
        txt = re.sub(r"&#x0*?2157;", "⅗", txt)
        txt = re.sub(r"&#0*?8535;", "⅗", txt)
        txt = re.sub(r"&frac35;", "⅗", txt)

        # "U+02158", "VULGAR FRACTION FOUR FIFTHS"
        txt = re.sub(r"&#x0*?2158;", "⅘", txt)
        txt = re.sub(r"&#0*?8536;", "⅘", txt)
        txt = re.sub(r"&frac45;", "⅘", txt)

        # "U+02159", "VULGAR FRACTION ONE SIXTH"
        txt = re.sub(r"&#x0*?2159;", "⅙", txt)
        txt = re.sub(r"&#0*?8537;", "⅙", txt)
        txt = re.sub(r"&frac16;", "⅙", txt)

        # "U+0215A", "VULGAR FRACTION FIVE SIXTHS"
        txt = re.sub(r"&#x0*?215A;", "⅚", txt)
        txt = re.sub(r"&#0*?8538;", "⅚", txt)
        txt = re.sub(r"&frac56;", "⅚", txt)

        # "U+0215B", "VULGAR FRACTION ONE EIGHTH"
        txt = re.sub(r"&#x0*?215B;", "⅛", txt)
        txt = re.sub(r"&#0*?8539;", "⅛", txt)
        txt = re.sub(r"&frac18;", "⅛", txt)

        # "U+0215C", "VULGAR FRACTION THREE EIGHTHS"
        txt = re.sub(r"&#x0*?215C;", "⅜", txt)
        txt = re.sub(r"&#0*?8540;", "⅜", txt)
        txt = re.sub(r"&frac38;", "⅜", txt)

        # "U+0215D", "VULGAR FRACTION FIVE EIGHTHS"
        txt = re.sub(r"&#x0*?215D;", "⅝", txt)
        txt = re.sub(r"&#0*?8541;", "⅝", txt)
        txt = re.sub(r"&frac58;", "⅝", txt)

        # "U+0215E", "VULGAR FRACTION SEVEN EIGHTHS"
        txt = re.sub(r"&#x0*?215E;", "⅞", txt)
        txt = re.sub(r"&#0*?8542;", "⅞", txt)
        txt = re.sub(r"&frac78;", "⅞", txt)

        # "U+02190", "LEFTWARDS ARROW"
        txt = re.sub(r"&#x0*?2190;", "←", txt)
        txt = re.sub(r"&#0*?8592;", "←", txt)
        txt = re.sub(r"&larr;", "←", txt)
        txt = re.sub(r"&leftarrow;", "←", txt)
        txt = re.sub(r"&LeftArrow;", "←", txt)
        txt = re.sub(r"&slarr;", "←", txt)
        txt = re.sub(r"&ShortLeftArrow;", "←", txt)

        # "U+02191", "UPWARDS ARROW"
        txt = re.sub(r"&#x0*?2191;", "↑", txt)
        txt = re.sub(r"&#0*?8593;", "↑", txt)
        txt = re.sub(r"&uarr;", "↑", txt)
        txt = re.sub(r"&uparrow;", "↑", txt)
        txt = re.sub(r"&UpArrow;", "↑", txt)
        txt = re.sub(r"&ShortUpArrow;", "↑", txt)

        # "U+02192", "RIGHTWARDS ARROW"
        txt = re.sub(r"&#x0*?2192;", "→", txt)
        txt = re.sub(r"&#0*?8594;", "→", txt)
        txt = re.sub(r"&rarr;", "→", txt)
        txt = re.sub(r"&rightarrow;", "→", txt)
        txt = re.sub(r"&RightArrow;", "→", txt)
        txt = re.sub(r"&srarr;", "→", txt)
        txt = re.sub(r"&ShortRightArrow;", "→", txt)

        # "U+02193", "DOWNWARDS ARROW"
        txt = re.sub(r"&#x0*?2193;", "↓", txt)
        txt = re.sub(r"&#0*?8595;", "↓", txt)
        txt = re.sub(r"&darr;", "↓", txt)
        txt = re.sub(r"&downarrow;", "↓", txt)
        txt = re.sub(r"&DownArrow;", "↓", txt)
        txt = re.sub(r"&ShortDownArrow;", "↓", txt)

        # "U+02194", "LEFT RIGHT ARROW"
        txt = re.sub(r"&#x0*?2194;", "↔", txt)
        txt = re.sub(r"&#0*?8596;", "↔", txt)
        txt = re.sub(r"&harr;", "↔", txt)
        txt = re.sub(r"&leftrightarrow;", "↔", txt)
        txt = re.sub(r"&LeftRightArrow;", "↔", txt)

        # "U+02195", "UP DOWN ARROW"
        txt = re.sub(r"&#x0*?2195;", "↕", txt)
        txt = re.sub(r"&#0*?8597;", "↕", txt)
        txt = re.sub(r"&varr;", "↕", txt)
        txt = re.sub(r"&updownarrow;", "↕", txt)
        txt = re.sub(r"&UpDownArrow;", "↕", txt)

        # "U+02196", "NORTH WEST ARROW"
        txt = re.sub(r"&#x0*?2196;", "↖", txt)
        txt = re.sub(r"&#0*?8598;", "↖", txt)
        txt = re.sub(r"&nwarr;", "↖", txt)
        txt = re.sub(r"&UpperLeftArrow;", "↖", txt)
        txt = re.sub(r"&nwarrow;", "↖", txt)

        # "U+02197", "NORTH EAST ARROW"
        txt = re.sub(r"&#x0*?2197;", "↗", txt)
        txt = re.sub(r"&#0*?8599;", "↗", txt)
        txt = re.sub(r"&nearr;", "↗", txt)
        txt = re.sub(r"&UpperRightArrow;", "↗", txt)
        txt = re.sub(r"&nearrow;", "↗", txt)

        # "U+02198", "SOUTH EAST ARROW"
        txt = re.sub(r"&#x0*?2198;", "↘", txt)
        txt = re.sub(r"&#0*?8600;", "↘", txt)
        txt = re.sub(r"&searr;", "↘", txt)
        txt = re.sub(r"&searrow;", "↘", txt)
        txt = re.sub(r"&LowerRightArrow;", "↘", txt)

        # "U+02199", "SOUTH WEST ARROW"
        txt = re.sub(r"&#x0*?2199;", "↙", txt)
        txt = re.sub(r"&#0*?8601;", "↙", txt)
        txt = re.sub(r"&swarr;", "↙", txt)
        txt = re.sub(r"&swarrow;", "↙", txt)
        txt = re.sub(r"&LowerLeftArrow;", "↙", txt)

        # "U+0219A", "LEFTWARDS ARROW WITH STROKE"
        txt = re.sub(r"&#x0*?219A;", "↚", txt)
        txt = re.sub(r"&#0*?8602;", "↚", txt)
        txt = re.sub(r"&nlarr;", "↚", txt)
        txt = re.sub(r"&nleftarrow;", "↚", txt)

        # "U+0219B", "RIGHTWARDS ARROW WITH STROKE"
        txt = re.sub(r"&#x0*?219B;", "↛", txt)
        txt = re.sub(r"&#0*?8603;", "↛", txt)
        txt = re.sub(r"&nrarr;", "↛", txt)
        txt = re.sub(r"&nrightarrow;", "↛", txt)

        # "U+0219D", "RIGHTWARDS WAVE ARROW"
        txt = re.sub(r"&#x0*?219D;", "↝", txt)
        txt = re.sub(r"&#0*?8605;", "↝", txt)
        txt = re.sub(r"&rarrw;", "↝", txt)
        txt = re.sub(r"&rightsquigarrow;", "↝", txt)

        # "U+0219E", "LEFTWARDS TWO HEADED ARROW"
        txt = re.sub(r"&#x0*?219E;", "↞", txt)
        txt = re.sub(r"&#0*?8606;", "↞", txt)
        txt = re.sub(r"&Larr;", "↞", txt)
        txt = re.sub(r"&twoheadleftarrow;", "↞", txt)

        # "U+0219F", "UPWARDS TWO HEADED ARROW"
        txt = re.sub(r"&#x0*?219F;", "↟", txt)
        txt = re.sub(r"&#0*?8607;", "↟", txt)
        txt = re.sub(r"&Uarr;", "↟", txt)

        # "U+021A0", "RIGHTWARDS TWO HEADED ARROW"
        txt = re.sub(r"&#x0*?21A0;", "↠", txt)
        txt = re.sub(r"&#0*?8608;", "↠", txt)
        txt = re.sub(r"&Rarr;", "↠", txt)
        txt = re.sub(r"&twoheadrightarrow;", "↠", txt)

        # "U+021A1", "DOWNWARDS TWO HEADED ARROW"
        txt = re.sub(r"&#x0*?21A1;", "↡", txt)
        txt = re.sub(r"&#0*?8609;", "↡", txt)
        txt = re.sub(r"&Darr;", "↡", txt)

        # "U+021A2", "LEFTWARDS ARROW WITH TAIL"
        txt = re.sub(r"&#x0*?21A2;", "↢", txt)
        txt = re.sub(r"&#0*?8610;", "↢", txt)
        txt = re.sub(r"&larrtl;", "↢", txt)
        txt = re.sub(r"&leftarrowtail;", "↢", txt)

        # "U+021A3", "RIGHTWARDS ARROW WITH TAIL"
        txt = re.sub(r"&#x0*?21A3;", "↣", txt)
        txt = re.sub(r"&#0*?8611;", "↣", txt)
        txt = re.sub(r"&rarrtl;", "↣", txt)
        txt = re.sub(r"&rightarrowtail;", "↣", txt)

        # "U+021A4", "LEFTWARDS ARROW FROM BAR"
        txt = re.sub(r"&#x0*?21A4;", "↤", txt)
        txt = re.sub(r"&#0*?8612;", "↤", txt)
        txt = re.sub(r"&LeftTeeArrow;", "↤", txt)
        txt = re.sub(r"&mapstoleft;", "↤", txt)

        # "U+021A5", "UPWARDS ARROW FROM BAR"
        txt = re.sub(r"&#x0*?21A5;", "↥", txt)
        txt = re.sub(r"&#0*?8613;", "↥", txt)
        txt = re.sub(r"&UpTeeArrow;", "↥", txt)
        txt = re.sub(r"&mapstoup;", "↥", txt)

        # "U+021A6", "RIGHTWARDS ARROW FROM BAR"
        txt = re.sub(r"&#x0*?21A6;", "↦", txt)
        txt = re.sub(r"&#0*?8614;", "↦", txt)
        txt = re.sub(r"&map;", "↦", txt)
        txt = re.sub(r"&RightTeeArrow;", "↦", txt)
        txt = re.sub(r"&mapsto;", "↦", txt)

        # "U+021A7", "DOWNWARDS ARROW FROM BAR"
        txt = re.sub(r"&#x0*?21A7;", "↧", txt)
        txt = re.sub(r"&#0*?8615;", "↧", txt)
        txt = re.sub(r"&DownTeeArrow;", "↧", txt)
        txt = re.sub(r"&mapstodown;", "↧", txt)

        # "U+021A9", "LEFTWARDS ARROW WITH HOOK"
        txt = re.sub(r"&#x0*?21A9;", "↩", txt)
        txt = re.sub(r"&#0*?8617;", "↩", txt)
        txt = re.sub(r"&larrhk;", "↩", txt)
        txt = re.sub(r"&hookleftarrow;", "↩", txt)

        # "U+021AA", "RIGHTWARDS ARROW WITH HOOK"
        txt = re.sub(r"&#x0*?21AA;", "↪", txt)
        txt = re.sub(r"&#0*?8618;", "↪", txt)
        txt = re.sub(r"&rarrhk;", "↪", txt)
        txt = re.sub(r"&hookrightarrow;", "↪", txt)

        # "U+021AB", "LEFTWARDS ARROW WITH LOOP"
        txt = re.sub(r"&#x0*?21AB;", "↫", txt)
        txt = re.sub(r"&#0*?8619;", "↫", txt)
        txt = re.sub(r"&larrlp;", "↫", txt)
        txt = re.sub(r"&looparrowleft;", "↫", txt)

        # "U+021AC", "RIGHTWARDS ARROW WITH LOOP"
        txt = re.sub(r"&#x0*?21AC;", "↬", txt)
        txt = re.sub(r"&#0*?8620;", "↬", txt)
        txt = re.sub(r"&rarrlp;", "↬", txt)
        txt = re.sub(r"&looparrowright;", "↬", txt)

        # "U+021AD", "LEFT RIGHT WAVE ARROW"
        txt = re.sub(r"&#x0*?21AD;", "↭", txt)
        txt = re.sub(r"&#0*?8621;", "↭", txt)
        txt = re.sub(r"&harrw;", "↭", txt)
        txt = re.sub(r"&leftrightsquigarrow;", "↭", txt)

        # "U+021AE", "LEFT RIGHT ARROW WITH STROKE"
        txt = re.sub(r"&#x0*?21AE;", "↮", txt)
        txt = re.sub(r"&#0*?8622;", "↮", txt)
        txt = re.sub(r"&nharr;", "↮", txt)
        txt = re.sub(r"&nleftrightarrow;", "↮", txt)

        # "U+021B0", "UPWARDS ARROW WITH TIP LEFTWARDS"
        txt = re.sub(r"&#x0*?21B0;", "↰", txt)
        txt = re.sub(r"&#0*?8624;", "↰", txt)
        txt = re.sub(r"&lsh;", "↰", txt)
        txt = re.sub(r"&Lsh;", "↰", txt)

        # "U+021B1", "UPWARDS ARROW WITH TIP RIGHTWARDS"
        txt = re.sub(r"&#x0*?21B1;", "↱", txt)
        txt = re.sub(r"&#0*?8625;", "↱", txt)
        txt = re.sub(r"&rsh;", "↱", txt)
        txt = re.sub(r"&Rsh;", "↱", txt)

        # "U+021B2", "DOWNWARDS ARROW WITH TIP LEFTWARDS"
        txt = re.sub(r"&#x0*?21B2;", "↲", txt)
        txt = re.sub(r"&#0*?8626;", "↲", txt)
        txt = re.sub(r"&ldsh;", "↲", txt)

        # "U+021B3", "DOWNWARDS ARROW WITH TIP RIGHTWARDS"
        txt = re.sub(r"&#x0*?21B3;", "↳", txt)
        txt = re.sub(r"&#0*?8627;", "↳", txt)
        txt = re.sub(r"&rdsh;", "↳", txt)

        # "U+021B5", "DOWNWARDS ARROW WITH CORNER LEFTWARDS"
        txt = re.sub(r"&#x0*?21B5;", "↵", txt)
        txt = re.sub(r"&#0*?8629;", "↵", txt)
        txt = re.sub(r"&crarr;", "↵", txt)

        # "U+021B6", "ANTICLOCKWISE TOP SEMICIRCLE ARROW"
        txt = re.sub(r"&#x0*?21B6;", "↶", txt)
        txt = re.sub(r"&#0*?8630;", "↶", txt)
        txt = re.sub(r"&cularr;", "↶", txt)
        txt = re.sub(r"&curvearrowleft;", "↶", txt)

        # "U+021B7", "CLOCKWISE TOP SEMICIRCLE ARROW"
        txt = re.sub(r"&#x0*?21B7;", "↷", txt)
        txt = re.sub(r"&#0*?8631;", "↷", txt)
        txt = re.sub(r"&curarr;", "↷", txt)
        txt = re.sub(r"&curvearrowright;", "↷", txt)

        # "U+021BA", "ANTICLOCKWISE OPEN CIRCLE ARROW"
        txt = re.sub(r"&#x0*?21BA;", "↺", txt)
        txt = re.sub(r"&#0*?8634;", "↺", txt)
        txt = re.sub(r"&olarr;", "↺", txt)
        txt = re.sub(r"&circlearrowleft;", "↺", txt)

        # "U+021BB", "CLOCKWISE OPEN CIRCLE ARROW"
        txt = re.sub(r"&#x0*?21BB;", "↻", txt)
        txt = re.sub(r"&#0*?8635;", "↻", txt)
        txt = re.sub(r"&orarr;", "↻", txt)
        txt = re.sub(r"&circlearrowright;", "↻", txt)

        # "U+021BC", "LEFTWARDS HARPOON WITH BARB UPWARDS"
        txt = re.sub(r"&#x0*?21BC;", "↼", txt)
        txt = re.sub(r"&#0*?8636;", "↼", txt)
        txt = re.sub(r"&lharu;", "↼", txt)
        txt = re.sub(r"&LeftVector;", "↼", txt)
        txt = re.sub(r"&leftharpoonup;", "↼", txt)

        # "U+021BD", "LEFTWARDS HARPOON WITH BARB DOWNWARDS"
        txt = re.sub(r"&#x0*?21BD;", "↽", txt)
        txt = re.sub(r"&#0*?8637;", "↽", txt)
        txt = re.sub(r"&lhard;", "↽", txt)
        txt = re.sub(r"&leftharpoondown;", "↽", txt)
        txt = re.sub(r"&DownLeftVector;", "↽", txt)

        # "U+021BE", "UPWARDS HARPOON WITH BARB RIGHTWARDS"
        txt = re.sub(r"&#x0*?21BE;", "↾", txt)
        txt = re.sub(r"&#0*?8638;", "↾", txt)
        txt = re.sub(r"&uharr;", "↾", txt)
        txt = re.sub(r"&upharpoonright;", "↾", txt)
        txt = re.sub(r"&RightUpVector;", "↾", txt)

        # "U+021BF", "UPWARDS HARPOON WITH BARB LEFTWARDS"
        txt = re.sub(r"&#x0*?21BF;", "↿", txt)
        txt = re.sub(r"&#0*?8639;", "↿", txt)
        txt = re.sub(r"&uharl;", "↿", txt)
        txt = re.sub(r"&upharpoonleft;", "↿", txt)
        txt = re.sub(r"&LeftUpVector;", "↿", txt)

        # "U+021C0", "RIGHTWARDS HARPOON WITH BARB UPWARDS"
        txt = re.sub(r"&#x0*?21C0;", "⇀", txt)
        txt = re.sub(r"&#0*?8640;", "⇀", txt)
        txt = re.sub(r"&rharu;", "⇀", txt)
        txt = re.sub(r"&RightVector;", "⇀", txt)
        txt = re.sub(r"&rightharpoonup;", "⇀", txt)

        # "U+021C1", "RIGHTWARDS HARPOON WITH BARB DOWNWARDS"
        txt = re.sub(r"&#x0*?21C1;", "⇁", txt)
        txt = re.sub(r"&#0*?8641;", "⇁", txt)
        txt = re.sub(r"&rhard;", "⇁", txt)
        txt = re.sub(r"&rightharpoondown;", "⇁", txt)
        txt = re.sub(r"&DownRightVector;", "⇁", txt)

        # "U+021C2", "DOWNWARDS HARPOON WITH BARB RIGHTWARDS"
        txt = re.sub(r"&#x0*?21C2;", "⇂", txt)
        txt = re.sub(r"&#0*?8642;", "⇂", txt)
        txt = re.sub(r"&dharr;", "⇂", txt)
        txt = re.sub(r"&RightDownVector;", "⇂", txt)
        txt = re.sub(r"&downharpoonright;", "⇂", txt)

        # "U+021C3", "DOWNWARDS HARPOON WITH BARB LEFTWARDS"
        txt = re.sub(r"&#x0*?21C3;", "⇃", txt)
        txt = re.sub(r"&#0*?8643;", "⇃", txt)
        txt = re.sub(r"&dharl;", "⇃", txt)
        txt = re.sub(r"&LeftDownVector;", "⇃", txt)
        txt = re.sub(r"&downharpoonleft;", "⇃", txt)

        # "U+021C4", "RIGHTWARDS ARROW OVER LEFTWARDS ARROW"
        txt = re.sub(r"&#x0*?21C4;", "⇄", txt)
        txt = re.sub(r"&#0*?8644;", "⇄", txt)
        txt = re.sub(r"&rlarr;", "⇄", txt)
        txt = re.sub(r"&rightleftarrows;", "⇄", txt)
        txt = re.sub(r"&RightArrowLeftArrow;", "⇄", txt)

        # "U+021C5", "UPWARDS ARROW LEFTWARDS OF DOWNWARDS ARROW"
        txt = re.sub(r"&#x0*?21C5;", "⇅", txt)
        txt = re.sub(r"&#0*?8645;", "⇅", txt)
        txt = re.sub(r"&udarr;", "⇅", txt)
        txt = re.sub(r"&UpArrowDownArrow;", "⇅", txt)

        # "U+021C6", "LEFTWARDS ARROW OVER RIGHTWARDS ARROW"
        txt = re.sub(r"&#x0*?21C6;", "⇆", txt)
        txt = re.sub(r"&#0*?8646;", "⇆", txt)
        txt = re.sub(r"&lrarr;", "⇆", txt)
        txt = re.sub(r"&leftrightarrows;", "⇆", txt)
        txt = re.sub(r"&LeftArrowRightArrow;", "⇆", txt)

        # "U+021C7", "LEFTWARDS PAIRED ARROWS"
        txt = re.sub(r"&#x0*?21C7;", "⇇", txt)
        txt = re.sub(r"&#0*?8647;", "⇇", txt)
        txt = re.sub(r"&llarr;", "⇇", txt)
        txt = re.sub(r"&leftleftarrows;", "⇇", txt)

        # "U+021C8", "UPWARDS PAIRED ARROWS"
        txt = re.sub(r"&#x0*?21C8;", "⇈", txt)
        txt = re.sub(r"&#0*?8648;", "⇈", txt)
        txt = re.sub(r"&uuarr;", "⇈", txt)
        txt = re.sub(r"&upuparrows;", "⇈", txt)

        # "U+021C9", "RIGHTWARDS PAIRED ARROWS"
        txt = re.sub(r"&#x0*?21C9;", "⇉", txt)
        txt = re.sub(r"&#0*?8649;", "⇉", txt)
        txt = re.sub(r"&rrarr;", "⇉", txt)
        txt = re.sub(r"&rightrightarrows;", "⇉", txt)

        # "U+021CA", "DOWNWARDS PAIRED ARROWS"
        txt = re.sub(r"&#x0*?21CA;", "⇊", txt)
        txt = re.sub(r"&#0*?8650;", "⇊", txt)
        txt = re.sub(r"&ddarr;", "⇊", txt)
        txt = re.sub(r"&downdownarrows;", "⇊", txt)

        # "U+021CB", "LEFTWARDS HARPOON OVER RIGHTWARDS HARPOON"
        txt = re.sub(r"&#x0*?21CB;", "⇋", txt)
        txt = re.sub(r"&#0*?8651;", "⇋", txt)
        txt = re.sub(r"&lrhar;", "⇋", txt)
        txt = re.sub(r"&ReverseEquilibrium;", "⇋", txt)
        txt = re.sub(r"&leftrightharpoons;", "⇋", txt)

        # "U+021CC", "RIGHTWARDS HARPOON OVER LEFTWARDS HARPOON"
        txt = re.sub(r"&#x0*?21CC;", "⇌", txt)
        txt = re.sub(r"&#0*?8652;", "⇌", txt)
        txt = re.sub(r"&rlhar;", "⇌", txt)
        txt = re.sub(r"&rightleftharpoons;", "⇌", txt)
        txt = re.sub(r"&Equilibrium;", "⇌", txt)

        # "U+021CD", "LEFTWARDS DOUBLE ARROW WITH STROKE"
        txt = re.sub(r"&#x0*?21CD;", "⇍", txt)
        txt = re.sub(r"&#0*?8653;", "⇍", txt)
        txt = re.sub(r"&nlArr;", "⇍", txt)
        txt = re.sub(r"&nLeftarrow;", "⇍", txt)

        # "U+021CE", "LEFT RIGHT DOUBLE ARROW WITH STROKE"
        txt = re.sub(r"&#x0*?21CE;", "⇎", txt)
        txt = re.sub(r"&#0*?8654;", "⇎", txt)
        txt = re.sub(r"&nhArr;", "⇎", txt)
        txt = re.sub(r"&nLeftrightarrow;", "⇎", txt)

        # "U+021CF", "RIGHTWARDS DOUBLE ARROW WITH STROKE"
        txt = re.sub(r"&#x0*?21CF;", "⇏", txt)
        txt = re.sub(r"&#0*?8655;", "⇏", txt)
        txt = re.sub(r"&nrArr;", "⇏", txt)
        txt = re.sub(r"&nRightarrow;", "⇏", txt)

        # "U+021D0", "LEFTWARDS DOUBLE ARROW"
        txt = re.sub(r"&#x0*?21D0;", "⇐", txt)
        txt = re.sub(r"&#0*?8656;", "⇐", txt)
        txt = re.sub(r"&lArr;", "⇐", txt)
        txt = re.sub(r"&Leftarrow;", "⇐", txt)
        txt = re.sub(r"&DoubleLeftArrow;", "⇐", txt)

        # "U+021D1", "UPWARDS DOUBLE ARROW"
        txt = re.sub(r"&#x0*?21D1;", "⇑", txt)
        txt = re.sub(r"&#0*?8657;", "⇑", txt)
        txt = re.sub(r"&uArr;", "⇑", txt)
        txt = re.sub(r"&Uparrow;", "⇑", txt)
        txt = re.sub(r"&DoubleUpArrow;", "⇑", txt)

        # "U+021D2", "RIGHTWARDS DOUBLE ARROW"
        txt = re.sub(r"&#x0*?21D2;", "⇒", txt)
        txt = re.sub(r"&#0*?8658;", "⇒", txt)
        txt = re.sub(r"&rArr;", "⇒", txt)
        txt = re.sub(r"&Rightarrow;", "⇒", txt)
        txt = re.sub(r"&Implies;", "⇒", txt)
        txt = re.sub(r"&DoubleRightArrow;", "⇒", txt)

        # "U+021D3", "DOWNWARDS DOUBLE ARROW"
        txt = re.sub(r"&#x0*?21D3;", "⇓", txt)
        txt = re.sub(r"&#0*?8659;", "⇓", txt)
        txt = re.sub(r"&dArr;", "⇓", txt)
        txt = re.sub(r"&Downarrow;", "⇓", txt)
        txt = re.sub(r"&DoubleDownArrow;", "⇓", txt)

        # "U+021D4", "LEFT RIGHT DOUBLE ARROW"
        txt = re.sub(r"&#x0*?21D4;", "⇔", txt)
        txt = re.sub(r"&#0*?8660;", "⇔", txt)
        txt = re.sub(r"&hArr;", "⇔", txt)
        txt = re.sub(r"&Leftrightarrow;", "⇔", txt)
        txt = re.sub(r"&DoubleLeftRightArrow;", "⇔", txt)
        txt = re.sub(r"&iff;", "⇔", txt)

        # "U+021D5", "UP DOWN DOUBLE ARROW"
        txt = re.sub(r"&#x0*?21D5;", "⇕", txt)
        txt = re.sub(r"&#0*?8661;", "⇕", txt)
        txt = re.sub(r"&vArr;", "⇕", txt)
        txt = re.sub(r"&Updownarrow;", "⇕", txt)
        txt = re.sub(r"&DoubleUpDownArrow;", "⇕", txt)

        # "U+021D6", "NORTH WEST DOUBLE ARROW"
        txt = re.sub(r"&#x0*?21D6;", "⇖", txt)
        txt = re.sub(r"&#0*?8662;", "⇖", txt)
        txt = re.sub(r"&nwArr;", "⇖", txt)

        # "U+021D7", "NORTH EAST DOUBLE ARROW"
        txt = re.sub(r"&#x0*?21D7;", "⇗", txt)
        txt = re.sub(r"&#0*?8663;", "⇗", txt)
        txt = re.sub(r"&neArr;", "⇗", txt)

        # "U+021D8", "SOUTH EAST DOUBLE ARROW"
        txt = re.sub(r"&#x0*?21D8;", "⇘", txt)
        txt = re.sub(r"&#0*?8664;", "⇘", txt)
        txt = re.sub(r"&seArr;", "⇘", txt)

        # "U+021D9", "SOUTH WEST DOUBLE ARROW"
        txt = re.sub(r"&#x0*?21D9;", "⇙", txt)
        txt = re.sub(r"&#0*?8665;", "⇙", txt)
        txt = re.sub(r"&swArr;", "⇙", txt)

        # "U+021DA", "LEFTWARDS TRIPLE ARROW"
        txt = re.sub(r"&#x0*?21DA;", "⇚", txt)
        txt = re.sub(r"&#0*?8666;", "⇚", txt)
        txt = re.sub(r"&lAarr;", "⇚", txt)
        txt = re.sub(r"&Lleftarrow;", "⇚", txt)

        # "U+021DB", "RIGHTWARDS TRIPLE ARROW"
        txt = re.sub(r"&#x0*?21DB;", "⇛", txt)
        txt = re.sub(r"&#0*?8667;", "⇛", txt)
        txt = re.sub(r"&rAarr;", "⇛", txt)
        txt = re.sub(r"&Rrightarrow;", "⇛", txt)

        # "U+021DD", "RIGHTWARDS SQUIGGLE ARROW"
        txt = re.sub(r"&#x0*?21DD;", "⇝", txt)
        txt = re.sub(r"&#0*?8669;", "⇝", txt)
        txt = re.sub(r"&zigrarr;", "⇝", txt)

        # "U+021E4", "LEFTWARDS ARROW TO BAR"
        txt = re.sub(r"&#x0*?21E4;", "⇤", txt)
        txt = re.sub(r"&#0*?8676;", "⇤", txt)
        txt = re.sub(r"&larrb;", "⇤", txt)
        txt = re.sub(r"&LeftArrowBar;", "⇤", txt)

        # "U+021E5", "RIGHTWARDS ARROW TO BAR"
        txt = re.sub(r"&#x0*?21E5;", "⇥", txt)
        txt = re.sub(r"&#0*?8677;", "⇥", txt)
        txt = re.sub(r"&rarrb;", "⇥", txt)
        txt = re.sub(r"&RightArrowBar;", "⇥", txt)

        # "U+021F5", "DOWNWARDS ARROW LEFTWARDS OF UPWARDS ARROW"
        txt = re.sub(r"&#x0*?21F5;", "⇵", txt)
        txt = re.sub(r"&#0*?8693;", "⇵", txt)
        txt = re.sub(r"&duarr;", "⇵", txt)
        txt = re.sub(r"&DownArrowUpArrow;", "⇵", txt)

        # "U+021FD", "LEFTWARDS OPEN-HEADED ARROW"
        txt = re.sub(r"&#x0*?21FD;", "⇽", txt)
        txt = re.sub(r"&#0*?8701;", "⇽", txt)
        txt = re.sub(r"&loarr;", "⇽", txt)

        # "U+021FE", "RIGHTWARDS OPEN-HEADED ARROW"
        txt = re.sub(r"&#x0*?21FE;", "⇾", txt)
        txt = re.sub(r"&#0*?8702;", "⇾", txt)
        txt = re.sub(r"&roarr;", "⇾", txt)

        # "U+021FF", "LEFT RIGHT OPEN-HEADED ARROW"
        txt = re.sub(r"&#x0*?21FF;", "⇿", txt)
        txt = re.sub(r"&#0*?8703;", "⇿", txt)
        txt = re.sub(r"&hoarr;", "⇿", txt)

        # "U+02200", "FOR ALL"
        txt = re.sub(r"&#x0*?2200;", "∀", txt)
        txt = re.sub(r"&#0*?8704;", "∀", txt)
        txt = re.sub(r"&forall;", "∀", txt)
        txt = re.sub(r"&ForAll;", "∀", txt)

        # "U+02201", "COMPLEMENT"
        txt = re.sub(r"&#x0*?2201;", "∁", txt)
        txt = re.sub(r"&#0*?8705;", "∁", txt)
        txt = re.sub(r"&comp;", "∁", txt)
        txt = re.sub(r"&complement;", "∁", txt)

        # "U+02202", "PARTIAL DIFFERENTIAL"
        txt = re.sub(r"&#x0*?2202;", "∂", txt)
        txt = re.sub(r"&#0*?8706;", "∂", txt)
        txt = re.sub(r"&part;", "∂", txt)
        txt = re.sub(r"&PartialD;", "∂", txt)

        # "U+02203", "THERE EXISTS"
        txt = re.sub(r"&#x0*?2203;", "∃", txt)
        txt = re.sub(r"&#0*?8707;", "∃", txt)
        txt = re.sub(r"&exist;", "∃", txt)
        txt = re.sub(r"&Exists;", "∃", txt)

        # "U+02204", "THERE DOES NOT EXIST"
        txt = re.sub(r"&#x0*?2204;", "∄", txt)
        txt = re.sub(r"&#0*?8708;", "∄", txt)
        txt = re.sub(r"&nexist;", "∄", txt)
        txt = re.sub(r"&NotExists;", "∄", txt)
        txt = re.sub(r"&nexists;", "∄", txt)

        # "U+02205", "EMPTY SET"
        txt = re.sub(r"&#x0*?2205;", "∅", txt)
        txt = re.sub(r"&#0*?8709;", "∅", txt)
        txt = re.sub(r"&empty;", "∅", txt)
        txt = re.sub(r"&emptyset;", "∅", txt)
        txt = re.sub(r"&emptyv;", "∅", txt)
        txt = re.sub(r"&varnothing;", "∅", txt)

        # "U+02207", "NABLA"
        txt = re.sub(r"&#x0*?2207;", "∇", txt)
        txt = re.sub(r"&#0*?8711;", "∇", txt)
        txt = re.sub(r"&nabla;", "∇", txt)
        txt = re.sub(r"&Del;", "∇", txt)

        # "U+02208", "ELEMENT OF"
        txt = re.sub(r"&#x0*?2208;", "∈", txt)
        txt = re.sub(r"&#0*?8712;", "∈", txt)
        txt = re.sub(r"&isin;", "∈", txt)
        txt = re.sub(r"&isinv;", "∈", txt)
        txt = re.sub(r"&Element;", "∈", txt)
        txt = re.sub(r"&in;", "∈", txt)

        # "U+02209", "NOT AN ELEMENT OF"
        txt = re.sub(r"&#x0*?2209;", "∉", txt)
        txt = re.sub(r"&#0*?8713;", "∉", txt)
        txt = re.sub(r"&notin;", "∉", txt)
        txt = re.sub(r"&NotElement;", "∉", txt)
        txt = re.sub(r"&notinva;", "∉", txt)

        # "U+0220B", "CONTAINS AS MEMBER"
        txt = re.sub(r"&#x0*?220B;", "∋", txt)
        txt = re.sub(r"&#0*?8715;", "∋", txt)
        txt = re.sub(r"&niv;", "∋", txt)
        txt = re.sub(r"&ReverseElement;", "∋", txt)
        txt = re.sub(r"&ni;", "∋", txt)
        txt = re.sub(r"&SuchThat;", "∋", txt)

        # "U+0220C", "DOES NOT CONTAIN AS MEMBER"
        txt = re.sub(r"&#x0*?220C;", "∌", txt)
        txt = re.sub(r"&#0*?8716;", "∌", txt)
        txt = re.sub(r"&notni;", "∌", txt)
        txt = re.sub(r"&notniva;", "∌", txt)
        txt = re.sub(r"&NotReverseElement;", "∌", txt)

        # "U+0220F", "N-ARY PRODUCT"
        txt = re.sub(r"&#x0*?220F;", "∏", txt)
        txt = re.sub(r"&#0*?8719;", "∏", txt)
        txt = re.sub(r"&prod;", "∏", txt)
        txt = re.sub(r"&Product;", "∏", txt)

        # "U+02210", "N-ARY COPRODUCT"
        txt = re.sub(r"&#x0*?2210;", "∐", txt)
        txt = re.sub(r"&#0*?8720;", "∐", txt)
        txt = re.sub(r"&coprod;", "∐", txt)
        txt = re.sub(r"&Coproduct;", "∐", txt)

        # "U+02211", "N-ARY SUMMATION"
        txt = re.sub(r"&#x0*?2211;", "∑", txt)
        txt = re.sub(r"&#0*?8721;", "∑", txt)
        txt = re.sub(r"&sum;", "∑", txt)
        txt = re.sub(r"&Sum;", "∑", txt)

        # "U+02212", "MINUS SIGN"
        txt = re.sub(r"&#x0*?2212;", "−", txt)
        txt = re.sub(r"&#0*?8722;", "−", txt)
        txt = re.sub(r"&minus;", "−", txt)

        # "U+02213", "MINUS-OR-PLUS SIGN"
        txt = re.sub(r"&#x0*?2213;", "∓", txt)
        txt = re.sub(r"&#0*?8723;", "∓", txt)
        txt = re.sub(r"&mnplus;", "∓", txt)
        txt = re.sub(r"&mp;", "∓", txt)
        txt = re.sub(r"&MinusPlus;", "∓", txt)

        # "U+02214", "DOT PLUS"
        txt = re.sub(r"&#x0*?2214;", "∔", txt)
        txt = re.sub(r"&#0*?8724;", "∔", txt)
        txt = re.sub(r"&plusdo;", "∔", txt)
        txt = re.sub(r"&dotplus;", "∔", txt)

        # "U+02216", "SET MINUS"
        txt = re.sub(r"&#x0*?2216;", "∖", txt)
        txt = re.sub(r"&#0*?8726;", "∖", txt)
        txt = re.sub(r"&setmn;", "∖", txt)
        txt = re.sub(r"&setminus;", "∖", txt)
        txt = re.sub(r"&Backslash;", "∖", txt)
        txt = re.sub(r"&ssetmn;", "∖", txt)
        txt = re.sub(r"&smallsetminus;", "∖", txt)

        # "U+02217", "ASTERISK OPERATOR"
        txt = re.sub(r"&#x0*?2217;", "∗", txt)
        txt = re.sub(r"&#0*?8727;", "∗", txt)
        txt = re.sub(r"&lowast;", "∗", txt)

        # "U+02218", "RING OPERATOR"
        txt = re.sub(r"&#x0*?2218;", "∘", txt)
        txt = re.sub(r"&#0*?8728;", "∘", txt)
        txt = re.sub(r"&compfn;", "∘", txt)
        txt = re.sub(r"&SmallCircle;", "∘", txt)

        # "U+0221A", "SQUARE ROOT"
        txt = re.sub(r"&#x0*?221A;", "√", txt)
        txt = re.sub(r"&#0*?8730;", "√", txt)
        txt = re.sub(r"&radic;", "√", txt)
        txt = re.sub(r"&Sqrt;", "√", txt)

        # "U+0221D", "PROPORTIONAL TO"
        txt = re.sub(r"&#x0*?221D;", "∝", txt)
        txt = re.sub(r"&#0*?8733;", "∝", txt)
        txt = re.sub(r"&prop;", "∝", txt)
        txt = re.sub(r"&propto;", "∝", txt)
        txt = re.sub(r"&Proportional;", "∝", txt)
        txt = re.sub(r"&vprop;", "∝", txt)
        txt = re.sub(r"&varpropto;", "∝", txt)

        # "U+0221E", "INFINITY"
        txt = re.sub(r"&#x0*?221E;", "∞", txt)
        txt = re.sub(r"&#0*?8734;", "∞", txt)
        txt = re.sub(r"&infin;", "∞", txt)

        # "U+0221F", "RIGHT ANGLE"
        txt = re.sub(r"&#x0*?221F;", "∟", txt)
        txt = re.sub(r"&#0*?8735;", "∟", txt)
        txt = re.sub(r"&angrt;", "∟", txt)

        # "U+02220", "ANGLE"
        txt = re.sub(r"&#x0*?2220;", "∠", txt)
        txt = re.sub(r"&#0*?8736;", "∠", txt)
        txt = re.sub(r"&ang;", "∠", txt)
        txt = re.sub(r"&angle;", "∠", txt)

        # "U+02221", "MEASURED ANGLE"
        txt = re.sub(r"&#x0*?2221;", "∡", txt)
        txt = re.sub(r"&#0*?8737;", "∡", txt)
        txt = re.sub(r"&angmsd;", "∡", txt)
        txt = re.sub(r"&measuredangle;", "∡", txt)

        # "U+02222", "SPHERICAL ANGLE"
        txt = re.sub(r"&#x0*?2222;", "∢", txt)
        txt = re.sub(r"&#0*?8738;", "∢", txt)
        txt = re.sub(r"&angsph;", "∢", txt)

        # "U+02223", "DIVIDES"
        txt = re.sub(r"&#x0*?2223;", "∣", txt)
        txt = re.sub(r"&#0*?8739;", "∣", txt)
        txt = re.sub(r"&mid;", "∣", txt)
        txt = re.sub(r"&VerticalBar;", "∣", txt)
        txt = re.sub(r"&smid;", "∣", txt)
        txt = re.sub(r"&shortmid;", "∣", txt)

        # "U+02224", "DOES NOT DIVIDE"
        txt = re.sub(r"&#x0*?2224;", "∤", txt)
        txt = re.sub(r"&#0*?8740;", "∤", txt)
        txt = re.sub(r"&nmid;", "∤", txt)
        txt = re.sub(r"&NotVerticalBar;", "∤", txt)
        txt = re.sub(r"&nsmid;", "∤", txt)
        txt = re.sub(r"&nshortmid;", "∤", txt)

        # "U+02225", "PARALLEL TO"
        txt = re.sub(r"&#x0*?2225;", "∥", txt)
        txt = re.sub(r"&#0*?8741;", "∥", txt)
        txt = re.sub(r"&par;", "∥", txt)
        txt = re.sub(r"&parallel;", "∥", txt)
        txt = re.sub(r"&DoubleVerticalBar;", "∥", txt)
        txt = re.sub(r"&spar;", "∥", txt)
        txt = re.sub(r"&shortparallel;", "∥", txt)

        # "U+02226", "NOT PARALLEL TO"
        txt = re.sub(r"&#x0*?2226;", "∦", txt)
        txt = re.sub(r"&#0*?8742;", "∦", txt)
        txt = re.sub(r"&npar;", "∦", txt)
        txt = re.sub(r"&nparallel;", "∦", txt)
        txt = re.sub(r"&NotDoubleVerticalBar;", "∦", txt)
        txt = re.sub(r"&nspar;", "∦", txt)
        txt = re.sub(r"&nshortparallel;", "∦", txt)

        # "U+02227", "LOGICAL AND"
        txt = re.sub(r"&#x0*?2227;", "∧", txt)
        txt = re.sub(r"&#0*?8743;", "∧", txt)
        txt = re.sub(r"&and;", "∧", txt)
        txt = re.sub(r"&wedge;", "∧", txt)

        # "U+02228", "LOGICAL OR"
        txt = re.sub(r"&#x0*?2228;", "∨", txt)
        txt = re.sub(r"&#0*?8744;", "∨", txt)
        txt = re.sub(r"&or;", "∨", txt)
        txt = re.sub(r"&vee;", "∨", txt)

        # "U+02229", "INTERSECTION"
        txt = re.sub(r"&#x0*?2229;", "∩", txt)
        txt = re.sub(r"&#0*?8745;", "∩", txt)
        txt = re.sub(r"&cap;", "∩", txt)

        # "U+0222A", "UNION"
        txt = re.sub(r"&#x0*?222A;", "∪", txt)
        txt = re.sub(r"&#0*?8746;", "∪", txt)
        txt = re.sub(r"&cup;", "∪", txt)

        # "U+0222B", "INTEGRAL"
        txt = re.sub(r"&#x0*?222B;", "∫", txt)
        txt = re.sub(r"&#0*?8747;", "∫", txt)
        txt = re.sub(r"&int;", "∫", txt)
        txt = re.sub(r"&Integral;", "∫", txt)

        # "U+0222C", "DOUBLE INTEGRAL"
        txt = re.sub(r"&#x0*?222C;", "∬", txt)
        txt = re.sub(r"&#0*?8748;", "∬", txt)
        txt = re.sub(r"&Int;", "∬", txt)

        # "U+0222D", "TRIPLE INTEGRAL"
        txt = re.sub(r"&#x0*?222D;", "∭", txt)
        txt = re.sub(r"&#0*?8749;", "∭", txt)
        txt = re.sub(r"&tint;", "∭", txt)
        txt = re.sub(r"&iiint;", "∭", txt)

        # "U+0222E", "CONTOUR INTEGRAL"
        txt = re.sub(r"&#x0*?222E;", "∮", txt)
        txt = re.sub(r"&#0*?8750;", "∮", txt)
        txt = re.sub(r"&conint;", "∮", txt)
        txt = re.sub(r"&oint;", "∮", txt)
        txt = re.sub(r"&ContourIntegral;", "∮", txt)

        # "U+0222F", "SURFACE INTEGRAL"
        txt = re.sub(r"&#x0*?222F;", "∯", txt)
        txt = re.sub(r"&#0*?8751;", "∯", txt)
        txt = re.sub(r"&Conint;", "∯", txt)
        txt = re.sub(r"&DoubleContourIntegral;", "∯", txt)

        # "U+02230", "VOLUME INTEGRAL"
        txt = re.sub(r"&#x0*?2230;", "∰", txt)
        txt = re.sub(r"&#0*?8752;", "∰", txt)
        txt = re.sub(r"&Cconint;", "∰", txt)

        # "U+02231", "CLOCKWISE INTEGRAL"
        txt = re.sub(r"&#x0*?2231;", "∱", txt)
        txt = re.sub(r"&#0*?8753;", "∱", txt)
        txt = re.sub(r"&cwint;", "∱", txt)

        # "U+02232", "CLOCKWISE CONTOUR INTEGRAL"
        txt = re.sub(r"&#x0*?2232;", "∲", txt)
        txt = re.sub(r"&#0*?8754;", "∲", txt)
        txt = re.sub(r"&cwconint;", "∲", txt)
        txt = re.sub(r"&ClockwiseContourIntegral;", "∲", txt)

        # "U+02233", "ANTICLOCKWISE CONTOUR INTEGRAL"
        txt = re.sub(r"&#x0*?2233;", "∳", txt)
        txt = re.sub(r"&#0*?8755;", "∳", txt)
        txt = re.sub(r"&awconint;", "∳", txt)
        txt = re.sub(r"&CounterClockwiseContourIntegral;", "∳", txt)

        # "U+02234", "THEREFORE"
        txt = re.sub(r"&#x0*?2234;", "∴", txt)
        txt = re.sub(r"&#0*?8756;", "∴", txt)
        txt = re.sub(r"&there4;", "∴", txt)
        txt = re.sub(r"&therefore;", "∴", txt)
        txt = re.sub(r"&Therefore;", "∴", txt)

        # "U+02235", "BECAUSE"
        txt = re.sub(r"&#x0*?2235;", "∵", txt)
        txt = re.sub(r"&#0*?8757;", "∵", txt)
        txt = re.sub(r"&becaus;", "∵", txt)
        txt = re.sub(r"&because;", "∵", txt)
        txt = re.sub(r"&Because;", "∵", txt)

        # "U+02236", "RATIO"
        txt = re.sub(r"&#x0*?2236;", "∶", txt)
        txt = re.sub(r"&#0*?8758;", "∶", txt)
        txt = re.sub(r"&ratio;", "∶", txt)

        # "U+02237", "PROPORTION"
        txt = re.sub(r"&#x0*?2237;", "∷", txt)
        txt = re.sub(r"&#0*?8759;", "∷", txt)
        txt = re.sub(r"&Colon;", "∷", txt)
        txt = re.sub(r"&Proportion;", "∷", txt)

        # "U+02238", "DOT MINUS"
        txt = re.sub(r"&#x0*?2238;", "∸", txt)
        txt = re.sub(r"&#0*?8760;", "∸", txt)
        txt = re.sub(r"&minusd;", "∸", txt)
        txt = re.sub(r"&dotminus;", "∸", txt)

        # "U+0223A", "GEOMETRIC PROPORTION"
        txt = re.sub(r"&#x0*?223A;", "∺", txt)
        txt = re.sub(r"&#0*?8762;", "∺", txt)
        txt = re.sub(r"&mDDot;", "∺", txt)

        # "U+0223B", "HOMOTHETIC"
        txt = re.sub(r"&#x0*?223B;", "∻", txt)
        txt = re.sub(r"&#0*?8763;", "∻", txt)
        txt = re.sub(r"&homtht;", "∻", txt)

        # "U+0223C", "TILDE OPERATOR"
        txt = re.sub(r"&#x0*?223C;", "∼", txt)
        txt = re.sub(r"&#0*?8764;", "∼", txt)
        txt = re.sub(r"&sim;", "∼", txt)
        txt = re.sub(r"&Tilde;", "∼", txt)
        txt = re.sub(r"&thksim;", "∼", txt)
        txt = re.sub(r"&thicksim;", "∼", txt)

        # "U+0223D", "REVERSED TILDE"
        txt = re.sub(r"&#x0*?223D;", "∽", txt)
        txt = re.sub(r"&#0*?8765;", "∽", txt)
        txt = re.sub(r"&bsim;", "∽", txt)
        txt = re.sub(r"&backsim;", "∽", txt)

        # "U+0223E", "INVERTED LAZY S"
        txt = re.sub(r"&#x0*?223E;", "∾", txt)
        txt = re.sub(r"&#0*?8766;", "∾", txt)
        txt = re.sub(r"&ac;", "∾", txt)
        txt = re.sub(r"&mstpos;", "∾", txt)

        # "U+0223F", "SINE WAVE"
        txt = re.sub(r"&#x0*?223F;", "∿", txt)
        txt = re.sub(r"&#0*?8767;", "∿", txt)
        txt = re.sub(r"&acd;", "∿", txt)

        # "U+02240", "WREATH PRODUCT"
        txt = re.sub(r"&#x0*?2240;", "≀", txt)
        txt = re.sub(r"&#0*?8768;", "≀", txt)
        txt = re.sub(r"&wreath;", "≀", txt)
        txt = re.sub(r"&VerticalTilde;", "≀", txt)
        txt = re.sub(r"&wr;", "≀", txt)

        # "U+02241", "NOT TILDE"
        txt = re.sub(r"&#x0*?2241;", "≁", txt)
        txt = re.sub(r"&#0*?8769;", "≁", txt)
        txt = re.sub(r"&nsim;", "≁", txt)
        txt = re.sub(r"&NotTilde;", "≁", txt)

        # "U+02242", "MINUS TILDE"
        txt = re.sub(r"&#x0*?2242;", "≂", txt)
        txt = re.sub(r"&#0*?8770;", "≂", txt)
        txt = re.sub(r"&esim;", "≂", txt)
        txt = re.sub(r"&EqualTilde;", "≂", txt)
        txt = re.sub(r"&eqsim;", "≂", txt)

        # "U+02243", "ASYMPTOTICALLY EQUAL TO"
        txt = re.sub(r"&#x0*?2243;", "≃", txt)
        txt = re.sub(r"&#0*?8771;", "≃", txt)
        txt = re.sub(r"&sime;", "≃", txt)
        txt = re.sub(r"&TildeEqual;", "≃", txt)
        txt = re.sub(r"&simeq;", "≃", txt)

        # "U+02244", "NOT ASYMPTOTICALLY EQUAL TO"
        txt = re.sub(r"&#x0*?2244;", "≄", txt)
        txt = re.sub(r"&#0*?8772;", "≄", txt)
        txt = re.sub(r"&nsime;", "≄", txt)
        txt = re.sub(r"&nsimeq;", "≄", txt)
        txt = re.sub(r"&NotTildeEqual;", "≄", txt)

        # "U+02245", "APPROXIMATELY EQUAL TO"
        txt = re.sub(r"&#x0*?2245;", "≅", txt)
        txt = re.sub(r"&#0*?8773;", "≅", txt)
        txt = re.sub(r"&cong;", "≅", txt)
        txt = re.sub(r"&TildeFullEqual;", "≅", txt)

        # "U+02246", "APPROXIMATELY BUT NOT ACTUALLY EQUAL TO"
        txt = re.sub(r"&#x0*?2246;", "≆", txt)
        txt = re.sub(r"&#0*?8774;", "≆", txt)
        txt = re.sub(r"&simne;", "≆", txt)

        # "U+02247", "NEITHER APPROXIMATELY NOR ACTUALLY EQUAL TO"
        txt = re.sub(r"&#x0*?2247;", "≇", txt)
        txt = re.sub(r"&#0*?8775;", "≇", txt)
        txt = re.sub(r"&ncong;", "≇", txt)
        txt = re.sub(r"&NotTildeFullEqual;", "≇", txt)

        # "U+02248", "ALMOST EQUAL TO"
        txt = re.sub(r"&#x0*?2248;", "≈", txt)
        txt = re.sub(r"&#0*?8776;", "≈", txt)
        txt = re.sub(r"&asymp;", "≈", txt)
        txt = re.sub(r"&ap;", "≈", txt)
        txt = re.sub(r"&TildeTilde;", "≈", txt)
        txt = re.sub(r"&approx;", "≈", txt)
        txt = re.sub(r"&thkap;", "≈", txt)
        txt = re.sub(r"&thickapprox;", "≈", txt)

        # "U+02249", "NOT ALMOST EQUAL TO"
        txt = re.sub(r"&#x0*?2249;", "≉", txt)
        txt = re.sub(r"&#0*?8777;", "≉", txt)
        txt = re.sub(r"&nap;", "≉", txt)
        txt = re.sub(r"&NotTildeTilde;", "≉", txt)
        txt = re.sub(r"&napprox;", "≉", txt)

        # "U+0224A", "ALMOST EQUAL OR EQUAL TO"
        txt = re.sub(r"&#x0*?224A;", "≊", txt)
        txt = re.sub(r"&#0*?8778;", "≊", txt)
        txt = re.sub(r"&ape;", "≊", txt)
        txt = re.sub(r"&approxeq;", "≊", txt)

        # "U+0224B", "TRIPLE TILDE"
        txt = re.sub(r"&#x0*?224B;", "≋", txt)
        txt = re.sub(r"&#0*?8779;", "≋", txt)
        txt = re.sub(r"&apid;", "≋", txt)

        # "U+0224C", "ALL EQUAL TO"
        txt = re.sub(r"&#x0*?224C;", "≌", txt)
        txt = re.sub(r"&#0*?8780;", "≌", txt)
        txt = re.sub(r"&bcong;", "≌", txt)
        txt = re.sub(r"&backcong;", "≌", txt)

        # "U+0224D", "EQUIVALENT TO"
        txt = re.sub(r"&#x0*?224D;", "≍", txt)
        txt = re.sub(r"&#0*?8781;", "≍", txt)
        txt = re.sub(r"&asympeq;", "≍", txt)
        txt = re.sub(r"&CupCap;", "≍", txt)

        # "U+0224E", "GEOMETRICALLY EQUIVALENT TO"
        txt = re.sub(r"&#x0*?224E;", "≎", txt)
        txt = re.sub(r"&#0*?8782;", "≎", txt)
        txt = re.sub(r"&bump;", "≎", txt)
        txt = re.sub(r"&HumpDownHump;", "≎", txt)
        txt = re.sub(r"&Bumpeq;", "≎", txt)

        # "U+0224F", "DIFFERENCE BETWEEN"
        txt = re.sub(r"&#x0*?224F;", "≏", txt)
        txt = re.sub(r"&#0*?8783;", "≏", txt)
        txt = re.sub(r"&bumpe;", "≏", txt)
        txt = re.sub(r"&HumpEqual;", "≏", txt)
        txt = re.sub(r"&bumpeq;", "≏", txt)

        # "U+02250", "APPROACHES THE LIMIT"
        txt = re.sub(r"&#x0*?2250;", "≐", txt)
        txt = re.sub(r"&#0*?8784;", "≐", txt)
        txt = re.sub(r"&esdot;", "≐", txt)
        txt = re.sub(r"&DotEqual;", "≐", txt)
        txt = re.sub(r"&doteq;", "≐", txt)

        # "U+02251", "GEOMETRICALLY EQUAL TO"
        txt = re.sub(r"&#x0*?2251;", "≑", txt)
        txt = re.sub(r"&#0*?8785;", "≑", txt)
        txt = re.sub(r"&eDot;", "≑", txt)
        txt = re.sub(r"&doteqdot;", "≑", txt)

        # "U+02252", "APPROXIMATELY EQUAL TO OR THE IMAGE OF"
        txt = re.sub(r"&#x0*?2252;", "≒", txt)
        txt = re.sub(r"&#0*?8786;", "≒", txt)
        txt = re.sub(r"&efDot;", "≒", txt)
        txt = re.sub(r"&fallingdotseq;", "≒", txt)

        # "U+02253", "IMAGE OF OR APPROXIMATELY EQUAL TO"
        txt = re.sub(r"&#x0*?2253;", "≓", txt)
        txt = re.sub(r"&#0*?8787;", "≓", txt)
        txt = re.sub(r"&erDot;", "≓", txt)
        txt = re.sub(r"&risingdotseq;", "≓", txt)

        # "U+02254", "COLON EQUALS"
        txt = re.sub(r"&#x0*?2254;", "≔", txt)
        txt = re.sub(r"&#0*?8788;", "≔", txt)
        txt = re.sub(r"&colone;", "≔", txt)
        txt = re.sub(r"&coloneq;", "≔", txt)
        txt = re.sub(r"&Assign;", "≔", txt)

        # "U+02255", "EQUALS COLON"
        txt = re.sub(r"&#x0*?2255;", "≕", txt)
        txt = re.sub(r"&#0*?8789;", "≕", txt)
        txt = re.sub(r"&ecolon;", "≕", txt)
        txt = re.sub(r"&eqcolon;", "≕", txt)

        # "U+02256", "RING IN EQUAL TO"
        txt = re.sub(r"&#x0*?2256;", "≖", txt)
        txt = re.sub(r"&#0*?8790;", "≖", txt)
        txt = re.sub(r"&ecir;", "≖", txt)
        txt = re.sub(r"&eqcirc;", "≖", txt)

        # "U+02257", "RING EQUAL TO"
        txt = re.sub(r"&#x0*?2257;", "≗", txt)
        txt = re.sub(r"&#0*?8791;", "≗", txt)
        txt = re.sub(r"&cire;", "≗", txt)
        txt = re.sub(r"&circeq;", "≗", txt)

        # "U+02259", "ESTIMATES"
        txt = re.sub(r"&#x0*?2259;", "≙", txt)
        txt = re.sub(r"&#0*?8793;", "≙", txt)
        txt = re.sub(r"&wedgeq;", "≙", txt)

        # "U+0225A", "EQUIANGULAR TO"
        txt = re.sub(r"&#x0*?225A;", "≚", txt)
        txt = re.sub(r"&#0*?8794;", "≚", txt)
        txt = re.sub(r"&veeeq;", "≚", txt)

        # "U+0225C", "DELTA EQUAL TO"
        txt = re.sub(r"&#x0*?225C;", "≜", txt)
        txt = re.sub(r"&#0*?8796;", "≜", txt)
        txt = re.sub(r"&trie;", "≜", txt)
        txt = re.sub(r"&triangleq;", "≜", txt)

        # "U+0225F", "QUESTIONED EQUAL TO"
        txt = re.sub(r"&#x0*?225F;", "≟", txt)
        txt = re.sub(r"&#0*?8799;", "≟", txt)
        txt = re.sub(r"&equest;", "≟", txt)
        txt = re.sub(r"&questeq;", "≟", txt)

        # "U+02260", "NOT EQUAL TO"
        txt = re.sub(r"&#x0*?2260;", "≠", txt)
        txt = re.sub(r"&#0*?8800;", "≠", txt)
        txt = re.sub(r"&ne;", "≠", txt)
        txt = re.sub(r"&NotEqual;", "≠", txt)

        # "U+02261", "IDENTICAL TO"
        txt = re.sub(r"&#x0*?2261;", "≡", txt)
        txt = re.sub(r"&#0*?8801;", "≡", txt)
        txt = re.sub(r"&equiv;", "≡", txt)
        txt = re.sub(r"&Congruent;", "≡", txt)

        # "U+02262", "NOT IDENTICAL TO"
        txt = re.sub(r"&#x0*?2262;", "≢", txt)
        txt = re.sub(r"&#0*?8802;", "≢", txt)
        txt = re.sub(r"&nequiv;", "≢", txt)
        txt = re.sub(r"&NotCongruent;", "≢", txt)

        # "U+02264", "LESS-THAN OR EQUAL TO"
        txt = re.sub(r"&#x0*?2264;", "≤", txt)
        txt = re.sub(r"&#0*?8804;", "≤", txt)
        txt = re.sub(r"&le;", "≤", txt)
        txt = re.sub(r"&leq;", "≤", txt)

        # "U+02265", "GREATER-THAN OR EQUAL TO"
        txt = re.sub(r"&#x0*?2265;", "≥", txt)
        txt = re.sub(r"&#0*?8805;", "≥", txt)
        txt = re.sub(r"&ge;", "≥", txt)
        txt = re.sub(r"&GreaterEqual;", "≥", txt)
        txt = re.sub(r"&geq;", "≥", txt)

        # "U+02266", "LESS-THAN OVER EQUAL TO"
        txt = re.sub(r"&#x0*?2266;", "≦", txt)
        txt = re.sub(r"&#0*?8806;", "≦", txt)
        txt = re.sub(r"&lE;", "≦", txt)
        txt = re.sub(r"&LessFullEqual;", "≦", txt)
        txt = re.sub(r"&leqq;", "≦", txt)

        # "U+02267", "GREATER-THAN OVER EQUAL TO"
        txt = re.sub(r"&#x0*?2267;", "≧", txt)
        txt = re.sub(r"&#0*?8807;", "≧", txt)
        txt = re.sub(r"&gE;", "≧", txt)
        txt = re.sub(r"&GreaterFullEqual;", "≧", txt)
        txt = re.sub(r"&geqq;", "≧", txt)

        # "U+02268", "LESS-THAN BUT NOT EQUAL TO"
        txt = re.sub(r"&#x0*?2268;", "≨", txt)
        txt = re.sub(r"&#0*?8808;", "≨", txt)
        txt = re.sub(r"&lnE;", "≨", txt)
        txt = re.sub(r"&lneqq;", "≨", txt)

        # "U+02269", "GREATER-THAN BUT NOT EQUAL TO"
        txt = re.sub(r"&#x0*?2269;", "≩", txt)
        txt = re.sub(r"&#0*?8809;", "≩", txt)
        txt = re.sub(r"&gnE;", "≩", txt)
        txt = re.sub(r"&gneqq;", "≩", txt)

        # "U+0226A", "MUCH LESS-THAN"
        txt = re.sub(r"&#x0*?226A;", "≪", txt)
        txt = re.sub(r"&#0*?8810;", "≪", txt)
        txt = re.sub(r"&Lt;", "≪", txt)
        txt = re.sub(r"&NestedLessLess;", "≪", txt)
        txt = re.sub(r"&ll;", "≪", txt)

        # "U+0226B", "MUCH GREATER-THAN"
        txt = re.sub(r"&#x0*?226B;", "≫", txt)
        txt = re.sub(r"&#0*?8811;", "≫", txt)
        txt = re.sub(r"&Gt;", "≫", txt)
        txt = re.sub(r"&NestedGreaterGreater;", "≫", txt)
        txt = re.sub(r"&gg;", "≫", txt)

        # "U+0226C", "BETWEEN"
        txt = re.sub(r"&#x0*?226C;", "≬", txt)
        txt = re.sub(r"&#0*?8812;", "≬", txt)
        txt = re.sub(r"&twixt;", "≬", txt)
        txt = re.sub(r"&between;", "≬", txt)

        # "U+0226D", "NOT EQUIVALENT TO"
        txt = re.sub(r"&#x0*?226D;", "≭", txt)
        txt = re.sub(r"&#0*?8813;", "≭", txt)
        txt = re.sub(r"&NotCupCap;", "≭", txt)

        # "U+0226E", "NOT LESS-THAN"
        txt = re.sub(r"&#x0*?226E;", "≮", txt)
        txt = re.sub(r"&#0*?8814;", "≮", txt)
        txt = re.sub(r"&nlt;", "≮", txt)
        txt = re.sub(r"&NotLess;", "≮", txt)
        txt = re.sub(r"&nless;", "≮", txt)

        # "U+0226F", "NOT GREATER-THAN"
        txt = re.sub(r"&#x0*?226F;", "≯", txt)
        txt = re.sub(r"&#0*?8815;", "≯", txt)
        txt = re.sub(r"&ngt;", "≯", txt)
        txt = re.sub(r"&NotGreater;", "≯", txt)
        txt = re.sub(r"&ngtr;", "≯", txt)

        # "U+02270", "NEITHER LESS-THAN NOR EQUAL TO"
        txt = re.sub(r"&#x0*?2270;", "≰", txt)
        txt = re.sub(r"&#0*?8816;", "≰", txt)
        txt = re.sub(r"&nle;", "≰", txt)
        txt = re.sub(r"&NotLessEqual;", "≰", txt)
        txt = re.sub(r"&nleq;", "≰", txt)

        # "U+02271", "NEITHER GREATER-THAN NOR EQUAL TO"
        txt = re.sub(r"&#x0*?2271;", "≱", txt)
        txt = re.sub(r"&#0*?8817;", "≱", txt)
        txt = re.sub(r"&nge;", "≱", txt)
        txt = re.sub(r"&NotGreaterEqual;", "≱", txt)
        txt = re.sub(r"&ngeq;", "≱", txt)

        # "U+02272", "LESS-THAN OR EQUIVALENT TO"
        txt = re.sub(r"&#x0*?2272;", "≲", txt)
        txt = re.sub(r"&#0*?8818;", "≲", txt)
        txt = re.sub(r"&lsim;", "≲", txt)
        txt = re.sub(r"&LessTilde;", "≲", txt)
        txt = re.sub(r"&lesssim;", "≲", txt)

        # "U+02273", "GREATER-THAN OR EQUIVALENT TO"
        txt = re.sub(r"&#x0*?2273;", "≳", txt)
        txt = re.sub(r"&#0*?8819;", "≳", txt)
        txt = re.sub(r"&gsim;", "≳", txt)
        txt = re.sub(r"&gtrsim;", "≳", txt)
        txt = re.sub(r"&GreaterTilde;", "≳", txt)

        # "U+02274", "NEITHER LESS-THAN NOR EQUIVALENT TO"
        txt = re.sub(r"&#x0*?2274;", "≴", txt)
        txt = re.sub(r"&#0*?8820;", "≴", txt)
        txt = re.sub(r"&nlsim;", "≴", txt)
        txt = re.sub(r"&NotLessTilde;", "≴", txt)

        # "U+02275", "NEITHER GREATER-THAN NOR EQUIVALENT TO"
        txt = re.sub(r"&#x0*?2275;", "≵", txt)
        txt = re.sub(r"&#0*?8821;", "≵", txt)
        txt = re.sub(r"&ngsim;", "≵", txt)
        txt = re.sub(r"&NotGreaterTilde;", "≵", txt)

        # "U+02276", "LESS-THAN OR GREATER-THAN"
        txt = re.sub(r"&#x0*?2276;", "≶", txt)
        txt = re.sub(r"&#0*?8822;", "≶", txt)
        txt = re.sub(r"&lg;", "≶", txt)
        txt = re.sub(r"&lessgtr;", "≶", txt)
        txt = re.sub(r"&LessGreater;", "≶", txt)

        # "U+02277", "GREATER-THAN OR LESS-THAN"
        txt = re.sub(r"&#x0*?2277;", "≷", txt)
        txt = re.sub(r"&#0*?8823;", "≷", txt)
        txt = re.sub(r"&gl;", "≷", txt)
        txt = re.sub(r"&gtrless;", "≷", txt)
        txt = re.sub(r"&GreaterLess;", "≷", txt)

        # "U+02278", "NEITHER LESS-THAN NOR GREATER-THAN"
        txt = re.sub(r"&#x0*?2278;", "≸", txt)
        txt = re.sub(r"&#0*?8824;", "≸", txt)
        txt = re.sub(r"&ntlg;", "≸", txt)
        txt = re.sub(r"&NotLessGreater;", "≸", txt)

        # "U+02279", "NEITHER GREATER-THAN NOR LESS-THAN"
        txt = re.sub(r"&#x0*?2279;", "≹", txt)
        txt = re.sub(r"&#0*?8825;", "≹", txt)
        txt = re.sub(r"&ntgl;", "≹", txt)
        txt = re.sub(r"&NotGreaterLess;", "≹", txt)

        # "U+0227A", "PRECEDES"
        txt = re.sub(r"&#x0*?227A;", "≺", txt)
        txt = re.sub(r"&#0*?8826;", "≺", txt)
        txt = re.sub(r"&pr;", "≺", txt)
        txt = re.sub(r"&Precedes;", "≺", txt)
        txt = re.sub(r"&prec;", "≺", txt)

        # "U+0227B", "SUCCEEDS"
        txt = re.sub(r"&#x0*?227B;", "≻", txt)
        txt = re.sub(r"&#0*?8827;", "≻", txt)
        txt = re.sub(r"&sc;", "≻", txt)
        txt = re.sub(r"&Succeeds;", "≻", txt)
        txt = re.sub(r"&succ;", "≻", txt)

        # "U+0227C", "PRECEDES OR EQUAL TO"
        txt = re.sub(r"&#x0*?227C;", "≼", txt)
        txt = re.sub(r"&#0*?8828;", "≼", txt)
        txt = re.sub(r"&prcue;", "≼", txt)
        txt = re.sub(r"&PrecedesSlantEqual;", "≼", txt)
        txt = re.sub(r"&preccurlyeq;", "≼", txt)

        # "U+0227D", "SUCCEEDS OR EQUAL TO"
        txt = re.sub(r"&#x0*?227D;", "≽", txt)
        txt = re.sub(r"&#0*?8829;", "≽", txt)
        txt = re.sub(r"&sccue;", "≽", txt)
        txt = re.sub(r"&SucceedsSlantEqual;", "≽", txt)
        txt = re.sub(r"&succcurlyeq;", "≽", txt)

        # "U+0227E", "PRECEDES OR EQUIVALENT TO"
        txt = re.sub(r"&#x0*?227E;", "≾", txt)
        txt = re.sub(r"&#0*?8830;", "≾", txt)
        txt = re.sub(r"&prsim;", "≾", txt)
        txt = re.sub(r"&precsim;", "≾", txt)
        txt = re.sub(r"&PrecedesTilde;", "≾", txt)

        # "U+0227F", "SUCCEEDS OR EQUIVALENT TO"
        txt = re.sub(r"&#x0*?227F;", "≿", txt)
        txt = re.sub(r"&#0*?8831;", "≿", txt)
        txt = re.sub(r"&scsim;", "≿", txt)
        txt = re.sub(r"&succsim;", "≿", txt)
        txt = re.sub(r"&SucceedsTilde;", "≿", txt)

        # "U+02280", "DOES NOT PRECEDE"
        txt = re.sub(r"&#x0*?2280;", "⊀", txt)
        txt = re.sub(r"&#0*?8832;", "⊀", txt)
        txt = re.sub(r"&npr;", "⊀", txt)
        txt = re.sub(r"&nprec;", "⊀", txt)
        txt = re.sub(r"&NotPrecedes;", "⊀", txt)

        # "U+02281", "DOES NOT SUCCEED"
        txt = re.sub(r"&#x0*?2281;", "⊁", txt)
        txt = re.sub(r"&#0*?8833;", "⊁", txt)
        txt = re.sub(r"&nsc;", "⊁", txt)
        txt = re.sub(r"&nsucc;", "⊁", txt)
        txt = re.sub(r"&NotSucceeds;", "⊁", txt)

        # "U+02282", "SUBSET OF"
        txt = re.sub(r"&#x0*?2282;", "⊂", txt)
        txt = re.sub(r"&#0*?8834;", "⊂", txt)
        txt = re.sub(r"&sub;", "⊂", txt)
        txt = re.sub(r"&subset;", "⊂", txt)

        # "U+02283", "SUPERSET OF"
        txt = re.sub(r"&#x0*?2283;", "⊃", txt)
        txt = re.sub(r"&#0*?8835;", "⊃", txt)
        txt = re.sub(r"&sup;", "⊃", txt)
        txt = re.sub(r"&supset;", "⊃", txt)
        txt = re.sub(r"&Superset;", "⊃", txt)

        # "U+02284", "NOT A SUBSET OF"
        txt = re.sub(r"&#x0*?2284;", "⊄", txt)
        txt = re.sub(r"&#0*?8836;", "⊄", txt)
        txt = re.sub(r"&nsub;", "⊄", txt)

        # "U+02285", "NOT A SUPERSET OF"
        txt = re.sub(r"&#x0*?2285;", "⊅", txt)
        txt = re.sub(r"&#0*?8837;", "⊅", txt)
        txt = re.sub(r"&nsup;", "⊅", txt)

        # "U+02286", "SUBSET OF OR EQUAL TO"
        txt = re.sub(r"&#x0*?2286;", "⊆", txt)
        txt = re.sub(r"&#0*?8838;", "⊆", txt)
        txt = re.sub(r"&sube;", "⊆", txt)
        txt = re.sub(r"&SubsetEqual;", "⊆", txt)
        txt = re.sub(r"&subseteq;", "⊆", txt)

        # "U+02287", "SUPERSET OF OR EQUAL TO"
        txt = re.sub(r"&#x0*?2287;", "⊇", txt)
        txt = re.sub(r"&#0*?8839;", "⊇", txt)
        txt = re.sub(r"&supe;", "⊇", txt)
        txt = re.sub(r"&supseteq;", "⊇", txt)
        txt = re.sub(r"&SupersetEqual;", "⊇", txt)

        # "U+02288", "NEITHER A SUBSET OF NOR EQUAL TO"
        txt = re.sub(r"&#x0*?2288;", "⊈", txt)
        txt = re.sub(r"&#0*?8840;", "⊈", txt)
        txt = re.sub(r"&nsube;", "⊈", txt)
        txt = re.sub(r"&nsubseteq;", "⊈", txt)
        txt = re.sub(r"&NotSubsetEqual;", "⊈", txt)

        # "U+02289", "NEITHER A SUPERSET OF NOR EQUAL TO"
        txt = re.sub(r"&#x0*?2289;", "⊉", txt)
        txt = re.sub(r"&#0*?8841;", "⊉", txt)
        txt = re.sub(r"&nsupe;", "⊉", txt)
        txt = re.sub(r"&nsupseteq;", "⊉", txt)
        txt = re.sub(r"&NotSupersetEqual;", "⊉", txt)

        # "U+0228A", "SUBSET OF WITH NOT EQUAL TO"
        txt = re.sub(r"&#x0*?228A;", "⊊", txt)
        txt = re.sub(r"&#0*?8842;", "⊊", txt)
        txt = re.sub(r"&subne;", "⊊", txt)
        txt = re.sub(r"&subsetneq;", "⊊", txt)

        # "U+0228B", "SUPERSET OF WITH NOT EQUAL TO"
        txt = re.sub(r"&#x0*?228B;", "⊋", txt)
        txt = re.sub(r"&#0*?8843;", "⊋", txt)
        txt = re.sub(r"&supne;", "⊋", txt)
        txt = re.sub(r"&supsetneq;", "⊋", txt)

        # "U+0228D", "MULTISET MULTIPLICATION"
        txt = re.sub(r"&#x0*?228D;", "⊍", txt)
        txt = re.sub(r"&#0*?8845;", "⊍", txt)
        txt = re.sub(r"&cupdot;", "⊍", txt)

        # "U+0228E", "MULTISET UNION"
        txt = re.sub(r"&#x0*?228E;", "⊎", txt)
        txt = re.sub(r"&#0*?8846;", "⊎", txt)
        txt = re.sub(r"&uplus;", "⊎", txt)
        txt = re.sub(r"&UnionPlus;", "⊎", txt)

        # "U+0228F", "SQUARE IMAGE OF"
        txt = re.sub(r"&#x0*?228F;", "⊏", txt)
        txt = re.sub(r"&#0*?8847;", "⊏", txt)
        txt = re.sub(r"&sqsub;", "⊏", txt)
        txt = re.sub(r"&SquareSubset;", "⊏", txt)
        txt = re.sub(r"&sqsubset;", "⊏", txt)

        # "U+02290", "SQUARE ORIGINAL OF"
        txt = re.sub(r"&#x0*?2290;", "⊐", txt)
        txt = re.sub(r"&#0*?8848;", "⊐", txt)
        txt = re.sub(r"&sqsup;", "⊐", txt)
        txt = re.sub(r"&SquareSuperset;", "⊐", txt)
        txt = re.sub(r"&sqsupset;", "⊐", txt)

        # "U+02291", "SQUARE IMAGE OF OR EQUAL TO"
        txt = re.sub(r"&#x0*?2291;", "⊑", txt)
        txt = re.sub(r"&#0*?8849;", "⊑", txt)
        txt = re.sub(r"&sqsube;", "⊑", txt)
        txt = re.sub(r"&SquareSubsetEqual;", "⊑", txt)
        txt = re.sub(r"&sqsubseteq;", "⊑", txt)

        # "U+02292", "SQUARE ORIGINAL OF OR EQUAL TO"
        txt = re.sub(r"&#x0*?2292;", "⊒", txt)
        txt = re.sub(r"&#0*?8850;", "⊒", txt)
        txt = re.sub(r"&sqsupe;", "⊒", txt)
        txt = re.sub(r"&SquareSupersetEqual;", "⊒", txt)
        txt = re.sub(r"&sqsupseteq;", "⊒", txt)

        # "U+02293", "SQUARE CAP"
        txt = re.sub(r"&#x0*?2293;", "⊓", txt)
        txt = re.sub(r"&#0*?8851;", "⊓", txt)
        txt = re.sub(r"&sqcap;", "⊓", txt)
        txt = re.sub(r"&SquareIntersection;", "⊓", txt)

        # "U+02294", "SQUARE CUP"
        txt = re.sub(r"&#x0*?2294;", "⊔", txt)
        txt = re.sub(r"&#0*?8852;", "⊔", txt)
        txt = re.sub(r"&sqcup;", "⊔", txt)
        txt = re.sub(r"&SquareUnion;", "⊔", txt)

        # "U+02295", "CIRCLED PLUS"
        txt = re.sub(r"&#x0*?2295;", "⊕", txt)
        txt = re.sub(r"&#0*?8853;", "⊕", txt)
        txt = re.sub(r"&oplus;", "⊕", txt)
        txt = re.sub(r"&CirclePlus;", "⊕", txt)

        # "U+02296", "CIRCLED MINUS"
        txt = re.sub(r"&#x0*?2296;", "⊖", txt)
        txt = re.sub(r"&#0*?8854;", "⊖", txt)
        txt = re.sub(r"&ominus;", "⊖", txt)
        txt = re.sub(r"&CircleMinus;", "⊖", txt)

        # "U+02297", "CIRCLED TIMES"
        txt = re.sub(r"&#x0*?2297;", "⊗", txt)
        txt = re.sub(r"&#0*?8855;", "⊗", txt)
        txt = re.sub(r"&otimes;", "⊗", txt)
        txt = re.sub(r"&CircleTimes;", "⊗", txt)

        # "U+02298", "CIRCLED DIVISION SLASH"
        txt = re.sub(r"&#x0*?2298;", "⊘", txt)
        txt = re.sub(r"&#0*?8856;", "⊘", txt)
        txt = re.sub(r"&osol;", "⊘", txt)

        # "U+02299", "CIRCLED DOT OPERATOR"
        txt = re.sub(r"&#x0*?2299;", "⊙", txt)
        txt = re.sub(r"&#0*?8857;", "⊙", txt)
        txt = re.sub(r"&odot;", "⊙", txt)
        txt = re.sub(r"&CircleDot;", "⊙", txt)

        # "U+0229A", "CIRCLED RING OPERATOR"
        txt = re.sub(r"&#x0*?229A;", "⊚", txt)
        txt = re.sub(r"&#0*?8858;", "⊚", txt)
        txt = re.sub(r"&ocir;", "⊚", txt)
        txt = re.sub(r"&circledcirc;", "⊚", txt)

        # "U+0229B", "CIRCLED ASTERISK OPERATOR"
        txt = re.sub(r"&#x0*?229B;", "⊛", txt)
        txt = re.sub(r"&#0*?8859;", "⊛", txt)
        txt = re.sub(r"&oast;", "⊛", txt)
        txt = re.sub(r"&circledast;", "⊛", txt)

        # "U+0229D", "CIRCLED DASH"
        txt = re.sub(r"&#x0*?229D;", "⊝", txt)
        txt = re.sub(r"&#0*?8861;", "⊝", txt)
        txt = re.sub(r"&odash;", "⊝", txt)
        txt = re.sub(r"&circleddash;", "⊝", txt)

        # "U+0229E", "SQUARED PLUS"
        txt = re.sub(r"&#x0*?229E;", "⊞", txt)
        txt = re.sub(r"&#0*?8862;", "⊞", txt)
        txt = re.sub(r"&plusb;", "⊞", txt)
        txt = re.sub(r"&boxplus;", "⊞", txt)

        # "U+0229F", "SQUARED MINUS"
        txt = re.sub(r"&#x0*?229F;", "⊟", txt)
        txt = re.sub(r"&#0*?8863;", "⊟", txt)
        txt = re.sub(r"&minusb;", "⊟", txt)
        txt = re.sub(r"&boxminus;", "⊟", txt)

        # "U+022A0", "SQUARED TIMES"
        txt = re.sub(r"&#x0*?22A0;", "⊠", txt)
        txt = re.sub(r"&#0*?8864;", "⊠", txt)
        txt = re.sub(r"&timesb;", "⊠", txt)
        txt = re.sub(r"&boxtimes;", "⊠", txt)

        # "U+022A1", "SQUARED DOT OPERATOR"
        txt = re.sub(r"&#x0*?22A1;", "⊡", txt)
        txt = re.sub(r"&#0*?8865;", "⊡", txt)
        txt = re.sub(r"&sdotb;", "⊡", txt)
        txt = re.sub(r"&dotsquare;", "⊡", txt)

        # "U+022A2", "RIGHT TACK"
        txt = re.sub(r"&#x0*?22A2;", "⊢", txt)
        txt = re.sub(r"&#0*?8866;", "⊢", txt)
        txt = re.sub(r"&vdash;", "⊢", txt)
        txt = re.sub(r"&RightTee;", "⊢", txt)

        # "U+022A3", "LEFT TACK"
        txt = re.sub(r"&#x0*?22A3;", "⊣", txt)
        txt = re.sub(r"&#0*?8867;", "⊣", txt)
        txt = re.sub(r"&dashv;", "⊣", txt)
        txt = re.sub(r"&LeftTee;", "⊣", txt)

        # "U+022A4", "DOWN TACK"
        txt = re.sub(r"&#x0*?22A4;", "⊤", txt)
        txt = re.sub(r"&#0*?8868;", "⊤", txt)
        txt = re.sub(r"&top;", "⊤", txt)
        txt = re.sub(r"&DownTee;", "⊤", txt)

        # "U+022A5", "UP TACK"
        txt = re.sub(r"&#x0*?22A5;", "⊥", txt)
        txt = re.sub(r"&#0*?8869;", "⊥", txt)
        txt = re.sub(r"&bottom;", "⊥", txt)
        txt = re.sub(r"&bot;", "⊥", txt)
        txt = re.sub(r"&perp;", "⊥", txt)
        txt = re.sub(r"&UpTee;", "⊥", txt)

        # "U+022A7", "MODELS"
        txt = re.sub(r"&#x0*?22A7;", "⊧", txt)
        txt = re.sub(r"&#0*?8871;", "⊧", txt)
        txt = re.sub(r"&models;", "⊧", txt)

        # "U+022A8", "TRUE"
        txt = re.sub(r"&#x0*?22A8;", "⊨", txt)
        txt = re.sub(r"&#0*?8872;", "⊨", txt)
        txt = re.sub(r"&vDash;", "⊨", txt)
        txt = re.sub(r"&DoubleRightTee;", "⊨", txt)

        # "U+022A9", "FORCES"
        txt = re.sub(r"&#x0*?22A9;", "⊩", txt)
        txt = re.sub(r"&#0*?8873;", "⊩", txt)
        txt = re.sub(r"&Vdash;", "⊩", txt)

        # "U+022AA", "TRIPLE VERTICAL BAR RIGHT TURNSTILE"
        txt = re.sub(r"&#x0*?22AA;", "⊪", txt)
        txt = re.sub(r"&#0*?8874;", "⊪", txt)
        txt = re.sub(r"&Vvdash;", "⊪", txt)

        # "U+022AB", "DOUBLE VERTICAL BAR DOUBLE RIGHT TURNSTILE"
        txt = re.sub(r"&#x0*?22AB;", "⊫", txt)
        txt = re.sub(r"&#0*?8875;", "⊫", txt)
        txt = re.sub(r"&VDash;", "⊫", txt)

        # "U+022AC", "DOES NOT PROVE"
        txt = re.sub(r"&#x0*?22AC;", "⊬", txt)
        txt = re.sub(r"&#0*?8876;", "⊬", txt)
        txt = re.sub(r"&nvdash;", "⊬", txt)

        # "U+022AD", "NOT TRUE"
        txt = re.sub(r"&#x0*?22AD;", "⊭", txt)
        txt = re.sub(r"&#0*?8877;", "⊭", txt)
        txt = re.sub(r"&nvDash;", "⊭", txt)

        # "U+022AE", "DOES NOT FORCE"
        txt = re.sub(r"&#x0*?22AE;", "⊮", txt)
        txt = re.sub(r"&#0*?8878;", "⊮", txt)
        txt = re.sub(r"&nVdash;", "⊮", txt)

        # "U+022AF", "NEGATED DOUBLE VERTICAL BAR DOUBLE RIGHT TURNSTILE"
        txt = re.sub(r"&#x0*?22AF;", "⊯", txt)
        txt = re.sub(r"&#0*?8879;", "⊯", txt)
        txt = re.sub(r"&nVDash;", "⊯", txt)

        # "U+022B0", "PRECEDES UNDER RELATION"
        txt = re.sub(r"&#x0*?22B0;", "⊰", txt)
        txt = re.sub(r"&#0*?8880;", "⊰", txt)
        txt = re.sub(r"&prurel;", "⊰", txt)

        # "U+022B2", "NORMAL SUBGROUP OF"
        txt = re.sub(r"&#x0*?22B2;", "⊲", txt)
        txt = re.sub(r"&#0*?8882;", "⊲", txt)
        txt = re.sub(r"&vltri;", "⊲", txt)
        txt = re.sub(r"&vartriangleleft;", "⊲", txt)
        txt = re.sub(r"&LeftTriangle;", "⊲", txt)

        # "U+022B3", "CONTAINS AS NORMAL SUBGROUP"
        txt = re.sub(r"&#x0*?22B3;", "⊳", txt)
        txt = re.sub(r"&#0*?8883;", "⊳", txt)
        txt = re.sub(r"&vrtri;", "⊳", txt)
        txt = re.sub(r"&vartriangleright;", "⊳", txt)
        txt = re.sub(r"&RightTriangle;", "⊳", txt)

        # "U+022B4", "NORMAL SUBGROUP OF OR EQUAL TO"
        txt = re.sub(r"&#x0*?22B4;", "⊴", txt)
        txt = re.sub(r"&#0*?8884;", "⊴", txt)
        txt = re.sub(r"&ltrie;", "⊴", txt)
        txt = re.sub(r"&trianglelefteq;", "⊴", txt)
        txt = re.sub(r"&LeftTriangleEqual;", "⊴", txt)

        # "U+022B5", "CONTAINS AS NORMAL SUBGROUP OR EQUAL TO"
        txt = re.sub(r"&#x0*?22B5;", "⊵", txt)
        txt = re.sub(r"&#0*?8885;", "⊵", txt)
        txt = re.sub(r"&rtrie;", "⊵", txt)
        txt = re.sub(r"&trianglerighteq;", "⊵", txt)
        txt = re.sub(r"&RightTriangleEqual;", "⊵", txt)

        # "U+022B6", "ORIGINAL OF"
        txt = re.sub(r"&#x0*?22B6;", "⊶", txt)
        txt = re.sub(r"&#0*?8886;", "⊶", txt)
        txt = re.sub(r"&origof;", "⊶", txt)

        # "U+022B7", "IMAGE OF"
        txt = re.sub(r"&#x0*?22B7;", "⊷", txt)
        txt = re.sub(r"&#0*?8887;", "⊷", txt)
        txt = re.sub(r"&imof;", "⊷", txt)

        # "U+022B8", "MULTIMAP"
        txt = re.sub(r"&#x0*?22B8;", "⊸", txt)
        txt = re.sub(r"&#0*?8888;", "⊸", txt)
        txt = re.sub(r"&mumap;", "⊸", txt)
        txt = re.sub(r"&multimap;", "⊸", txt)

        # "U+022B9", "HERMITIAN CONJUGATE MATRIX"
        txt = re.sub(r"&#x0*?22B9;", "⊹", txt)
        txt = re.sub(r"&#0*?8889;", "⊹", txt)
        txt = re.sub(r"&hercon;", "⊹", txt)

        # "U+022BA", "INTERCALATE"
        txt = re.sub(r"&#x0*?22BA;", "⊺", txt)
        txt = re.sub(r"&#0*?8890;", "⊺", txt)
        txt = re.sub(r"&intcal;", "⊺", txt)
        txt = re.sub(r"&intercal;", "⊺", txt)

        # "U+022BB", "XOR"
        txt = re.sub(r"&#x0*?22BB;", "⊻", txt)
        txt = re.sub(r"&#0*?8891;", "⊻", txt)
        txt = re.sub(r"&veebar;", "⊻", txt)

        # "U+022BD", "NOR"
        txt = re.sub(r"&#x0*?22BD;", "⊽", txt)
        txt = re.sub(r"&#0*?8893;", "⊽", txt)
        txt = re.sub(r"&barvee;", "⊽", txt)

        # "U+022BE", "RIGHT ANGLE WITH ARC"
        txt = re.sub(r"&#x0*?22BE;", "⊾", txt)
        txt = re.sub(r"&#0*?8894;", "⊾", txt)
        txt = re.sub(r"&angrtvb;", "⊾", txt)

        # "U+022BF", "RIGHT TRIANGLE"
        txt = re.sub(r"&#x0*?22BF;", "⊿", txt)
        txt = re.sub(r"&#0*?8895;", "⊿", txt)
        txt = re.sub(r"&lrtri;", "⊿", txt)

        # "U+022C0", "N-ARY LOGICAL AND"
        txt = re.sub(r"&#x0*?22C0;", "⋀", txt)
        txt = re.sub(r"&#0*?8896;", "⋀", txt)
        txt = re.sub(r"&xwedge;", "⋀", txt)
        txt = re.sub(r"&Wedge;", "⋀", txt)
        txt = re.sub(r"&bigwedge;", "⋀", txt)

        # "U+022C1", "N-ARY LOGICAL OR"
        txt = re.sub(r"&#x0*?22C1;", "⋁", txt)
        txt = re.sub(r"&#0*?8897;", "⋁", txt)
        txt = re.sub(r"&xvee;", "⋁", txt)
        txt = re.sub(r"&Vee;", "⋁", txt)
        txt = re.sub(r"&bigvee;", "⋁", txt)

        # "U+022C2", "N-ARY INTERSECTION"
        txt = re.sub(r"&#x0*?22C2;", "⋂", txt)
        txt = re.sub(r"&#0*?8898;", "⋂", txt)
        txt = re.sub(r"&xcap;", "⋂", txt)
        txt = re.sub(r"&Intersection;", "⋂", txt)
        txt = re.sub(r"&bigcap;", "⋂", txt)

        # "U+022C3", "N-ARY UNION"
        txt = re.sub(r"&#x0*?22C3;", "⋃", txt)
        txt = re.sub(r"&#0*?8899;", "⋃", txt)
        txt = re.sub(r"&xcup;", "⋃", txt)
        txt = re.sub(r"&Union;", "⋃", txt)
        txt = re.sub(r"&bigcup;", "⋃", txt)

        # "U+022C4", "DIAMOND OPERATOR"
        txt = re.sub(r"&#x0*?22C4;", "⋄", txt)
        txt = re.sub(r"&#0*?8900;", "⋄", txt)
        txt = re.sub(r"&diam;", "⋄", txt)
        txt = re.sub(r"&diamond;", "⋄", txt)
        txt = re.sub(r"&Diamond;", "⋄", txt)

        # "U+022C5", "DOT OPERATOR"
        txt = re.sub(r"&#x0*?22C5;", "⋅", txt)
        txt = re.sub(r"&#0*?8901;", "⋅", txt)
        txt = re.sub(r"&sdot;", "⋅", txt)

        # "U+022C6", "STAR OPERATOR"
        txt = re.sub(r"&#x0*?22C6;", "⋆", txt)
        txt = re.sub(r"&#0*?8902;", "⋆", txt)
        txt = re.sub(r"&sstarf;", "⋆", txt)
        txt = re.sub(r"&Star;", "⋆", txt)

        # "U+022C7", "DIVISION TIMES"
        txt = re.sub(r"&#x0*?22C7;", "⋇", txt)
        txt = re.sub(r"&#0*?8903;", "⋇", txt)
        txt = re.sub(r"&divonx;", "⋇", txt)
        txt = re.sub(r"&divideontimes;", "⋇", txt)

        # "U+022C8", "BOWTIE"
        txt = re.sub(r"&#x0*?22C8;", "⋈", txt)
        txt = re.sub(r"&#0*?8904;", "⋈", txt)
        txt = re.sub(r"&bowtie;", "⋈", txt)

        # "U+022C9", "LEFT NORMAL FACTOR SEMIDIRECT PRODUCT"
        txt = re.sub(r"&#x0*?22C9;", "⋉", txt)
        txt = re.sub(r"&#0*?8905;", "⋉", txt)
        txt = re.sub(r"&ltimes;", "⋉", txt)

        # "U+022CA", "RIGHT NORMAL FACTOR SEMIDIRECT PRODUCT"
        txt = re.sub(r"&#x0*?22CA;", "⋊", txt)
        txt = re.sub(r"&#0*?8906;", "⋊", txt)
        txt = re.sub(r"&rtimes;", "⋊", txt)

        # "U+022CB", "LEFT SEMIDIRECT PRODUCT"
        txt = re.sub(r"&#x0*?22CB;", "⋋", txt)
        txt = re.sub(r"&#0*?8907;", "⋋", txt)
        txt = re.sub(r"&lthree;", "⋋", txt)
        txt = re.sub(r"&leftthreetimes;", "⋋", txt)

        # "U+022CC", "RIGHT SEMIDIRECT PRODUCT"
        txt = re.sub(r"&#x0*?22CC;", "⋌", txt)
        txt = re.sub(r"&#0*?8908;", "⋌", txt)
        txt = re.sub(r"&rthree;", "⋌", txt)
        txt = re.sub(r"&rightthreetimes;", "⋌", txt)

        # "U+022CD", "REVERSED TILDE EQUALS"
        txt = re.sub(r"&#x0*?22CD;", "⋍", txt)
        txt = re.sub(r"&#0*?8909;", "⋍", txt)
        txt = re.sub(r"&bsime;", "⋍", txt)
        txt = re.sub(r"&backsimeq;", "⋍", txt)

        # "U+022CE", "CURLY LOGICAL OR"
        txt = re.sub(r"&#x0*?22CE;", "⋎", txt)
        txt = re.sub(r"&#0*?8910;", "⋎", txt)
        txt = re.sub(r"&cuvee;", "⋎", txt)
        txt = re.sub(r"&curlyvee;", "⋎", txt)

        # "U+022CF", "CURLY LOGICAL AND"
        txt = re.sub(r"&#x0*?22CF;", "⋏", txt)
        txt = re.sub(r"&#0*?8911;", "⋏", txt)
        txt = re.sub(r"&cuwed;", "⋏", txt)
        txt = re.sub(r"&curlywedge;", "⋏", txt)

        # "U+022D0", "DOUBLE SUBSET"
        txt = re.sub(r"&#x0*?22D0;", "⋐", txt)
        txt = re.sub(r"&#0*?8912;", "⋐", txt)
        txt = re.sub(r"&Sub;", "⋐", txt)
        txt = re.sub(r"&Subset;", "⋐", txt)

        # "U+022D1", "DOUBLE SUPERSET"
        txt = re.sub(r"&#x0*?22D1;", "⋑", txt)
        txt = re.sub(r"&#0*?8913;", "⋑", txt)
        txt = re.sub(r"&Sup;", "⋑", txt)
        txt = re.sub(r"&Supset;", "⋑", txt)

        # "U+022D2", "DOUBLE INTERSECTION"
        txt = re.sub(r"&#x0*?22D2;", "⋒", txt)
        txt = re.sub(r"&#0*?8914;", "⋒", txt)
        txt = re.sub(r"&Cap;", "⋒", txt)

        # "U+022D3", "DOUBLE UNION"
        txt = re.sub(r"&#x0*?22D3;", "⋓", txt)
        txt = re.sub(r"&#0*?8915;", "⋓", txt)
        txt = re.sub(r"&Cup;", "⋓", txt)

        # "U+022D4", "PITCHFORK"
        txt = re.sub(r"&#x0*?22D4;", "⋔", txt)
        txt = re.sub(r"&#0*?8916;", "⋔", txt)
        txt = re.sub(r"&fork;", "⋔", txt)
        txt = re.sub(r"&pitchfork;", "⋔", txt)

        # "U+022D5", "EQUAL AND PARALLEL TO"
        txt = re.sub(r"&#x0*?22D5;", "⋕", txt)
        txt = re.sub(r"&#0*?8917;", "⋕", txt)
        txt = re.sub(r"&epar;", "⋕", txt)

        # "U+022D6", "LESS-THAN WITH DOT"
        txt = re.sub(r"&#x0*?22D6;", "⋖", txt)
        txt = re.sub(r"&#0*?8918;", "⋖", txt)
        txt = re.sub(r"&ltdot;", "⋖", txt)
        txt = re.sub(r"&lessdot;", "⋖", txt)

        # "U+022D7", "GREATER-THAN WITH DOT"
        txt = re.sub(r"&#x0*?22D7;", "⋗", txt)
        txt = re.sub(r"&#0*?8919;", "⋗", txt)
        txt = re.sub(r"&gtdot;", "⋗", txt)
        txt = re.sub(r"&gtrdot;", "⋗", txt)

        # "U+022D8", "VERY MUCH LESS-THAN"
        txt = re.sub(r"&#x0*?22D8;", "⋘", txt)
        txt = re.sub(r"&#0*?8920;", "⋘", txt)
        txt = re.sub(r"&Ll;", "⋘", txt)

        # "U+022D9", "VERY MUCH GREATER-THAN"
        txt = re.sub(r"&#x0*?22D9;", "⋙", txt)
        txt = re.sub(r"&#0*?8921;", "⋙", txt)
        txt = re.sub(r"&Gg;", "⋙", txt)
        txt = re.sub(r"&ggg;", "⋙", txt)

        # "U+022DA", "LESS-THAN EQUAL TO OR GREATER-THAN"
        txt = re.sub(r"&#x0*?22DA;", "⋚", txt)
        txt = re.sub(r"&#0*?8922;", "⋚", txt)
        txt = re.sub(r"&leg;", "⋚", txt)
        txt = re.sub(r"&LessEqualGreater;", "⋚", txt)
        txt = re.sub(r"&lesseqgtr;", "⋚", txt)

        # "U+022DB", "GREATER-THAN EQUAL TO OR LESS-THAN"
        txt = re.sub(r"&#x0*?22DB;", "⋛", txt)
        txt = re.sub(r"&#0*?8923;", "⋛", txt)
        txt = re.sub(r"&gel;", "⋛", txt)
        txt = re.sub(r"&gtreqless;", "⋛", txt)
        txt = re.sub(r"&GreaterEqualLess;", "⋛", txt)

        # "U+022DE", "EQUAL TO OR PRECEDES"
        txt = re.sub(r"&#x0*?22DE;", "⋞", txt)
        txt = re.sub(r"&#0*?8926;", "⋞", txt)
        txt = re.sub(r"&cuepr;", "⋞", txt)
        txt = re.sub(r"&curlyeqprec;", "⋞", txt)

        # "U+022DF", "EQUAL TO OR SUCCEEDS"
        txt = re.sub(r"&#x0*?22DF;", "⋟", txt)
        txt = re.sub(r"&#0*?8927;", "⋟", txt)
        txt = re.sub(r"&cuesc;", "⋟", txt)
        txt = re.sub(r"&curlyeqsucc;", "⋟", txt)

        # "U+022E0", "DOES NOT PRECEDE OR EQUAL"
        txt = re.sub(r"&#x0*?22E0;", "⋠", txt)
        txt = re.sub(r"&#0*?8928;", "⋠", txt)
        txt = re.sub(r"&nprcue;", "⋠", txt)
        txt = re.sub(r"&NotPrecedesSlantEqual;", "⋠", txt)

        # "U+022E1", "DOES NOT SUCCEED OR EQUAL"
        txt = re.sub(r"&#x0*?22E1;", "⋡", txt)
        txt = re.sub(r"&#0*?8929;", "⋡", txt)
        txt = re.sub(r"&nsccue;", "⋡", txt)
        txt = re.sub(r"&NotSucceedsSlantEqual;", "⋡", txt)

        # "U+022E2", "NOT SQUARE IMAGE OF OR EQUAL TO"
        txt = re.sub(r"&#x0*?22E2;", "⋢", txt)
        txt = re.sub(r"&#0*?8930;", "⋢", txt)
        txt = re.sub(r"&nsqsube;", "⋢", txt)
        txt = re.sub(r"&NotSquareSubsetEqual;", "⋢", txt)

        # "U+022E3", "NOT SQUARE ORIGINAL OF OR EQUAL TO"
        txt = re.sub(r"&#x0*?22E3;", "⋣", txt)
        txt = re.sub(r"&#0*?8931;", "⋣", txt)
        txt = re.sub(r"&nsqsupe;", "⋣", txt)
        txt = re.sub(r"&NotSquareSupersetEqual;", "⋣", txt)

        # "U+022E6", "LESS-THAN BUT NOT EQUIVALENT TO"
        txt = re.sub(r"&#x0*?22E6;", "⋦", txt)
        txt = re.sub(r"&#0*?8934;", "⋦", txt)
        txt = re.sub(r"&lnsim;", "⋦", txt)

        # "U+022E7", "GREATER-THAN BUT NOT EQUIVALENT TO"
        txt = re.sub(r"&#x0*?22E7;", "⋧", txt)
        txt = re.sub(r"&#0*?8935;", "⋧", txt)
        txt = re.sub(r"&gnsim;", "⋧", txt)

        # "U+022E8", "PRECEDES BUT NOT EQUIVALENT TO"
        txt = re.sub(r"&#x0*?22E8;", "⋨", txt)
        txt = re.sub(r"&#0*?8936;", "⋨", txt)
        txt = re.sub(r"&prnsim;", "⋨", txt)
        txt = re.sub(r"&precnsim;", "⋨", txt)

        # "U+022E9", "SUCCEEDS BUT NOT EQUIVALENT TO"
        txt = re.sub(r"&#x0*?22E9;", "⋩", txt)
        txt = re.sub(r"&#0*?8937;", "⋩", txt)
        txt = re.sub(r"&scnsim;", "⋩", txt)
        txt = re.sub(r"&succnsim;", "⋩", txt)

        # "U+022EA", "NOT NORMAL SUBGROUP OF"
        txt = re.sub(r"&#x0*?22EA;", "⋪", txt)
        txt = re.sub(r"&#0*?8938;", "⋪", txt)
        txt = re.sub(r"&nltri;", "⋪", txt)
        txt = re.sub(r"&ntriangleleft;", "⋪", txt)
        txt = re.sub(r"&NotLeftTriangle;", "⋪", txt)

        # "U+022EB", "DOES NOT CONTAIN AS NORMAL SUBGROUP"
        txt = re.sub(r"&#x0*?22EB;", "⋫", txt)
        txt = re.sub(r"&#0*?8939;", "⋫", txt)
        txt = re.sub(r"&nrtri;", "⋫", txt)
        txt = re.sub(r"&ntriangleright;", "⋫", txt)
        txt = re.sub(r"&NotRightTriangle;", "⋫", txt)

        # "U+022EC", "NOT NORMAL SUBGROUP OF OR EQUAL TO"
        txt = re.sub(r"&#x0*?22EC;", "⋬", txt)
        txt = re.sub(r"&#0*?8940;", "⋬", txt)
        txt = re.sub(r"&nltrie;", "⋬", txt)
        txt = re.sub(r"&ntrianglelefteq;", "⋬", txt)
        txt = re.sub(r"&NotLeftTriangleEqual;", "⋬", txt)

        # "U+022ED", "DOES NOT CONTAIN AS NORMAL SUBGROUP OR EQUAL"
        txt = re.sub(r"&#x0*?22ED;", "⋭", txt)
        txt = re.sub(r"&#0*?8941;", "⋭", txt)
        txt = re.sub(r"&nrtrie;", "⋭", txt)
        txt = re.sub(r"&ntrianglerighteq;", "⋭", txt)
        txt = re.sub(r"&NotRightTriangleEqual;", "⋭", txt)

        # "U+022EE", "VERTICAL ELLIPSIS"
        txt = re.sub(r"&#x0*?22EE;", "⋮", txt)
        txt = re.sub(r"&#0*?8942;", "⋮", txt)
        txt = re.sub(r"&vellip;", "⋮", txt)

        # "U+022EF", "MIDLINE HORIZONTAL ELLIPSIS"
        txt = re.sub(r"&#x0*?22EF;", "⋯", txt)
        txt = re.sub(r"&#0*?8943;", "⋯", txt)
        txt = re.sub(r"&ctdot;", "⋯", txt)

        # "U+022F0", "UP RIGHT DIAGONAL ELLIPSIS"
        txt = re.sub(r"&#x0*?22F0;", "⋰", txt)
        txt = re.sub(r"&#0*?8944;", "⋰", txt)
        txt = re.sub(r"&utdot;", "⋰", txt)

        # "U+022F1", "DOWN RIGHT DIAGONAL ELLIPSIS"
        txt = re.sub(r"&#x0*?22F1;", "⋱", txt)
        txt = re.sub(r"&#0*?8945;", "⋱", txt)
        txt = re.sub(r"&dtdot;", "⋱", txt)

        # "U+022F2", "ELEMENT OF WITH LONG HORIZONTAL STROKE"
        txt = re.sub(r"&#x0*?22F2;", "⋲", txt)
        txt = re.sub(r"&#0*?8946;", "⋲", txt)
        txt = re.sub(r"&disin;", "⋲", txt)

        # "U+022F3", "ELEMENT OF WITH VERTICAL BAR AT END OF HORIZONTAL STROKE"
        txt = re.sub(r"&#x0*?22F3;", "⋳", txt)
        txt = re.sub(r"&#0*?8947;", "⋳", txt)
        txt = re.sub(r"&isinsv;", "⋳", txt)

        # "U+022F4", "SMALL ELEMENT OF WITH VERTICAL BAR AT END OF HORIZONTAL STROKE"
        txt = re.sub(r"&#x0*?22F4;", "⋴", txt)
        txt = re.sub(r"&#0*?8948;", "⋴", txt)
        txt = re.sub(r"&isins;", "⋴", txt)

        # "U+022F5", "ELEMENT OF WITH DOT ABOVE"
        txt = re.sub(r"&#x0*?22F5;", "⋵", txt)
        txt = re.sub(r"&#0*?8949;", "⋵", txt)
        txt = re.sub(r"&isindot;", "⋵", txt)

        # "U+022F6", "ELEMENT OF WITH OVERBAR"
        txt = re.sub(r"&#x0*?22F6;", "⋶", txt)
        txt = re.sub(r"&#0*?8950;", "⋶", txt)
        txt = re.sub(r"&notinvc;", "⋶", txt)

        # "U+022F7", "SMALL ELEMENT OF WITH OVERBAR"
        txt = re.sub(r"&#x0*?22F7;", "⋷", txt)
        txt = re.sub(r"&#0*?8951;", "⋷", txt)
        txt = re.sub(r"&notinvb;", "⋷", txt)

        # "U+022F9", "ELEMENT OF WITH TWO HORIZONTAL STROKES"
        txt = re.sub(r"&#x0*?22F9;", "⋹", txt)
        txt = re.sub(r"&#0*?8953;", "⋹", txt)
        txt = re.sub(r"&isinE;", "⋹", txt)

        # "U+022FA", "CONTAINS WITH LONG HORIZONTAL STROKE"
        txt = re.sub(r"&#x0*?22FA;", "⋺", txt)
        txt = re.sub(r"&#0*?8954;", "⋺", txt)
        txt = re.sub(r"&nisd;", "⋺", txt)

        # "U+022FB", "CONTAINS WITH VERTICAL BAR AT END OF HORIZONTAL STROKE"
        txt = re.sub(r"&#x0*?22FB;", "⋻", txt)
        txt = re.sub(r"&#0*?8955;", "⋻", txt)
        txt = re.sub(r"&xnis;", "⋻", txt)

        # "U+022FC", "SMALL CONTAINS WITH VERTICAL BAR AT END OF HORIZONTAL STROKE"
        txt = re.sub(r"&#x0*?22FC;", "⋼", txt)
        txt = re.sub(r"&#0*?8956;", "⋼", txt)
        txt = re.sub(r"&nis;", "⋼", txt)

        # "U+022FD", "CONTAINS WITH OVERBAR"
        txt = re.sub(r"&#x0*?22FD;", "⋽", txt)
        txt = re.sub(r"&#0*?8957;", "⋽", txt)
        txt = re.sub(r"&notnivc;", "⋽", txt)

        # "U+022FE", "SMALL CONTAINS WITH OVERBAR"
        txt = re.sub(r"&#x0*?22FE;", "⋾", txt)
        txt = re.sub(r"&#0*?8958;", "⋾", txt)
        txt = re.sub(r"&notnivb;", "⋾", txt)

        # "U+02305", "PROJECTIVE"
        txt = re.sub(r"&#x0*?2305;", "⌅", txt)
        txt = re.sub(r"&#0*?8965;", "⌅", txt)
        txt = re.sub(r"&barwed;", "⌅", txt)
        txt = re.sub(r"&barwedge;", "⌅", txt)

        # "U+02306", "PERSPECTIVE"
        txt = re.sub(r"&#x0*?2306;", "⌆", txt)
        txt = re.sub(r"&#0*?8966;", "⌆", txt)
        txt = re.sub(r"&Barwed;", "⌆", txt)
        txt = re.sub(r"&doublebarwedge;", "⌆", txt)

        # "U+02308", "LEFT CEILING"
        txt = re.sub(r"&#x0*?2308;", "⌈", txt)
        txt = re.sub(r"&#0*?8968;", "⌈", txt)
        txt = re.sub(r"&lceil;", "⌈", txt)
        txt = re.sub(r"&LeftCeiling;", "⌈", txt)

        # "U+02309", "RIGHT CEILING"
        txt = re.sub(r"&#x0*?2309;", "⌉", txt)
        txt = re.sub(r"&#0*?8969;", "⌉", txt)
        txt = re.sub(r"&rceil;", "⌉", txt)
        txt = re.sub(r"&RightCeiling;", "⌉", txt)

        # "U+0230A", "LEFT FLOOR"
        txt = re.sub(r"&#x0*?230A;", "⌊", txt)
        txt = re.sub(r"&#0*?8970;", "⌊", txt)
        txt = re.sub(r"&lfloor;", "⌊", txt)
        txt = re.sub(r"&LeftFloor;", "⌊", txt)

        # "U+0230B", "RIGHT FLOOR"
        txt = re.sub(r"&#x0*?230B;", "⌋", txt)
        txt = re.sub(r"&#0*?8971;", "⌋", txt)
        txt = re.sub(r"&rfloor;", "⌋", txt)
        txt = re.sub(r"&RightFloor;", "⌋", txt)

        # "U+0230C", "BOTTOM RIGHT CROP"
        txt = re.sub(r"&#x0*?230C;", "⌌", txt)
        txt = re.sub(r"&#0*?8972;", "⌌", txt)
        txt = re.sub(r"&drcrop;", "⌌", txt)

        # "U+0230D", "BOTTOM LEFT CROP"
        txt = re.sub(r"&#x0*?230D;", "⌍", txt)
        txt = re.sub(r"&#0*?8973;", "⌍", txt)
        txt = re.sub(r"&dlcrop;", "⌍", txt)

        # "U+0230E", "TOP RIGHT CROP"
        txt = re.sub(r"&#x0*?230E;", "⌎", txt)
        txt = re.sub(r"&#0*?8974;", "⌎", txt)
        txt = re.sub(r"&urcrop;", "⌎", txt)

        # "U+0230F", "TOP LEFT CROP"
        txt = re.sub(r"&#x0*?230F;", "⌏", txt)
        txt = re.sub(r"&#0*?8975;", "⌏", txt)
        txt = re.sub(r"&ulcrop;", "⌏", txt)

        # "U+02310", "REVERSED NOT SIGN"
        txt = re.sub(r"&#x0*?2310;", "⌐", txt)
        txt = re.sub(r"&#0*?8976;", "⌐", txt)
        txt = re.sub(r"&bnot;", "⌐", txt)

        # "U+02312", "ARC"
        txt = re.sub(r"&#x0*?2312;", "⌒", txt)
        txt = re.sub(r"&#0*?8978;", "⌒", txt)
        txt = re.sub(r"&profline;", "⌒", txt)

        # "U+02313", "SEGMENT"
        txt = re.sub(r"&#x0*?2313;", "⌓", txt)
        txt = re.sub(r"&#0*?8979;", "⌓", txt)
        txt = re.sub(r"&profsurf;", "⌓", txt)

        # "U+02315", "TELEPHONE RECORDER"
        txt = re.sub(r"&#x0*?2315;", "⌕", txt)
        txt = re.sub(r"&#0*?8981;", "⌕", txt)
        txt = re.sub(r"&telrec;", "⌕", txt)

        # "U+02316", "POSITION INDICATOR"
        txt = re.sub(r"&#x0*?2316;", "⌖", txt)
        txt = re.sub(r"&#0*?8982;", "⌖", txt)
        txt = re.sub(r"&target;", "⌖", txt)

        # "U+0231C", "TOP LEFT CORNER"
        txt = re.sub(r"&#x0*?231C;", "⌜", txt)
        txt = re.sub(r"&#0*?8988;", "⌜", txt)
        txt = re.sub(r"&ulcorn;", "⌜", txt)
        txt = re.sub(r"&ulcorner;", "⌜", txt)

        # "U+0231D", "TOP RIGHT CORNER"
        txt = re.sub(r"&#x0*?231D;", "⌝", txt)
        txt = re.sub(r"&#0*?8989;", "⌝", txt)
        txt = re.sub(r"&urcorn;", "⌝", txt)
        txt = re.sub(r"&urcorner;", "⌝", txt)

        # "U+0231E", "BOTTOM LEFT CORNER"
        txt = re.sub(r"&#x0*?231E;", "⌞", txt)
        txt = re.sub(r"&#0*?8990;", "⌞", txt)
        txt = re.sub(r"&dlcorn;", "⌞", txt)
        txt = re.sub(r"&llcorner;", "⌞", txt)

        # "U+0231F", "BOTTOM RIGHT CORNER"
        txt = re.sub(r"&#x0*?231F;", "⌟", txt)
        txt = re.sub(r"&#0*?8991;", "⌟", txt)
        txt = re.sub(r"&drcorn;", "⌟", txt)
        txt = re.sub(r"&lrcorner;", "⌟", txt)

        # "U+02322", "FROWN"
        txt = re.sub(r"&#x0*?2322;", "⌢", txt)
        txt = re.sub(r"&#0*?8994;", "⌢", txt)
        txt = re.sub(r"&frown;", "⌢", txt)
        txt = re.sub(r"&sfrown;", "⌢", txt)

        # "U+02323", "SMILE"
        txt = re.sub(r"&#x0*?2323;", "⌣", txt)
        txt = re.sub(r"&#0*?8995;", "⌣", txt)
        txt = re.sub(r"&smile;", "⌣", txt)
        txt = re.sub(r"&ssmile;", "⌣", txt)

        # "U+0232D", "CYLINDRICITY"
        txt = re.sub(r"&#x0*?232D;", "⌭", txt)
        txt = re.sub(r"&#0*?9005;", "⌭", txt)
        txt = re.sub(r"&cylcty;", "⌭", txt)

        # "U+0232E", "ALL AROUND-PROFILE"
        txt = re.sub(r"&#x0*?232E;", "⌮", txt)
        txt = re.sub(r"&#0*?9006;", "⌮", txt)
        txt = re.sub(r"&profalar;", "⌮", txt)

        # "U+02336", "APL FUNCTIONAL SYMBOL I-BEAM"
        txt = re.sub(r"&#x0*?2336;", "⌶", txt)
        txt = re.sub(r"&#0*?9014;", "⌶", txt)
        txt = re.sub(r"&topbot;", "⌶", txt)

        # "U+0233D", "APL FUNCTIONAL SYMBOL CIRCLE STILE"
        txt = re.sub(r"&#x0*?233D;", "⌽", txt)
        txt = re.sub(r"&#0*?9021;", "⌽", txt)
        txt = re.sub(r"&ovbar;", "⌽", txt)

        # "U+0233F", "APL FUNCTIONAL SYMBOL SLASH BAR"
        txt = re.sub(r"&#x0*?233F;", "⌿", txt)
        txt = re.sub(r"&#0*?9023;", "⌿", txt)
        txt = re.sub(r"&solbar;", "⌿", txt)

        # "U+0237C", "RIGHT ANGLE WITH DOWNWARDS ZIGZAG ARROW"
        txt = re.sub(r"&#x0*?237C;", "⍼", txt)
        txt = re.sub(r"&#0*?9084;", "⍼", txt)
        txt = re.sub(r"&angzarr;", "⍼", txt)

        # "U+023B0", "UPPER LEFT OR LOWER RIGHT CURLY BRACKET SECTION"
        txt = re.sub(r"&#x0*?23B0;", "⎰", txt)
        txt = re.sub(r"&#0*?9136;", "⎰", txt)
        txt = re.sub(r"&lmoust;", "⎰", txt)
        txt = re.sub(r"&lmoustache;", "⎰", txt)

        # "U+023B1", "UPPER RIGHT OR LOWER LEFT CURLY BRACKET SECTION"
        txt = re.sub(r"&#x0*?23B1;", "⎱", txt)
        txt = re.sub(r"&#0*?9137;", "⎱", txt)
        txt = re.sub(r"&rmoust;", "⎱", txt)
        txt = re.sub(r"&rmoustache;", "⎱", txt)

        # "U+023B4", "TOP SQUARE BRACKET"
        txt = re.sub(r"&#x0*?23B4;", "⎴", txt)
        txt = re.sub(r"&#0*?9140;", "⎴", txt)
        txt = re.sub(r"&tbrk;", "⎴", txt)
        txt = re.sub(r"&OverBracket;", "⎴", txt)

        # "U+023B5", "BOTTOM SQUARE BRACKET"
        txt = re.sub(r"&#x0*?23B5;", "⎵", txt)
        txt = re.sub(r"&#0*?9141;", "⎵", txt)
        txt = re.sub(r"&bbrk;", "⎵", txt)
        txt = re.sub(r"&UnderBracket;", "⎵", txt)

        # "U+023B6", "BOTTOM SQUARE BRACKET OVER TOP SQUARE BRACKET"
        txt = re.sub(r"&#x0*?23B6;", "⎶", txt)
        txt = re.sub(r"&#0*?9142;", "⎶", txt)
        txt = re.sub(r"&bbrktbrk;", "⎶", txt)

        # "U+023DC", "TOP PARENTHESIS"
        txt = re.sub(r"&#x0*?23DC;", "⏜", txt)
        txt = re.sub(r"&#0*?9180;", "⏜", txt)
        txt = re.sub(r"&OverParenthesis;", "⏜", txt)

        # "U+023DD", "BOTTOM PARENTHESIS"
        txt = re.sub(r"&#x0*?23DD;", "⏝", txt)
        txt = re.sub(r"&#0*?9181;", "⏝", txt)
        txt = re.sub(r"&UnderParenthesis;", "⏝", txt)

        # "U+023DE", "TOP CURLY BRACKET"
        txt = re.sub(r"&#x0*?23DE;", "⏞", txt)
        txt = re.sub(r"&#0*?9182;", "⏞", txt)
        txt = re.sub(r"&OverBrace;", "⏞", txt)

        # "U+023DF", "BOTTOM CURLY BRACKET"
        txt = re.sub(r"&#x0*?23DF;", "⏟", txt)
        txt = re.sub(r"&#0*?9183;", "⏟", txt)
        txt = re.sub(r"&UnderBrace;", "⏟", txt)

        # "U+023E2", "WHITE TRAPEZIUM"
        txt = re.sub(r"&#x0*?23E2;", "⏢", txt)
        txt = re.sub(r"&#0*?9186;", "⏢", txt)
        txt = re.sub(r"&trpezium;", "⏢", txt)

        # "U+023E7", "ELECTRICAL INTERSECTION"
        txt = re.sub(r"&#x0*?23E7;", "⏧", txt)
        txt = re.sub(r"&#0*?9191;", "⏧", txt)
        txt = re.sub(r"&elinters;", "⏧", txt)

        # "U+02423", "OPEN BOX"
        txt = re.sub(r"&#x0*?2423;", "␣", txt)
        txt = re.sub(r"&#0*?9251;", "␣", txt)
        txt = re.sub(r"&blank;", "␣", txt)

        # "U+024C8", "CIRCLED LATIN CAPITAL LETTER S"
        txt = re.sub(r"&#x0*?24C8;", "Ⓢ", txt)
        txt = re.sub(r"&#0*?9416;", "Ⓢ", txt)
        txt = re.sub(r"&oS;", "Ⓢ", txt)
        txt = re.sub(r"&circledS;", "Ⓢ", txt)

        # "U+02500", "BOX DRAWINGS LIGHT HORIZONTAL"
        txt = re.sub(r"&#x0*?2500;", "─", txt)
        txt = re.sub(r"&#0*?9472;", "─", txt)
        txt = re.sub(r"&boxh;", "─", txt)
        txt = re.sub(r"&HorizontalLine;", "─", txt)

        # "U+02502", "BOX DRAWINGS LIGHT VERTICAL"
        txt = re.sub(r"&#x0*?2502;", "│", txt)
        txt = re.sub(r"&#0*?9474;", "│", txt)
        txt = re.sub(r"&boxv;", "│", txt)

        # "U+0250C", "BOX DRAWINGS LIGHT DOWN AND RIGHT"
        txt = re.sub(r"&#x0*?250C;", "┌", txt)
        txt = re.sub(r"&#0*?9484;", "┌", txt)
        txt = re.sub(r"&boxdr;", "┌", txt)

        # "U+02510", "BOX DRAWINGS LIGHT DOWN AND LEFT"
        txt = re.sub(r"&#x0*?2510;", "┐", txt)
        txt = re.sub(r"&#0*?9488;", "┐", txt)
        txt = re.sub(r"&boxdl;", "┐", txt)

        # "U+02514", "BOX DRAWINGS LIGHT UP AND RIGHT"
        txt = re.sub(r"&#x0*?2514;", "└", txt)
        txt = re.sub(r"&#0*?9492;", "└", txt)
        txt = re.sub(r"&boxur;", "└", txt)

        # "U+02518", "BOX DRAWINGS LIGHT UP AND LEFT"
        txt = re.sub(r"&#x0*?2518;", "┘", txt)
        txt = re.sub(r"&#0*?9496;", "┘", txt)
        txt = re.sub(r"&boxul;", "┘", txt)

        # "U+0251C", "BOX DRAWINGS LIGHT VERTICAL AND RIGHT"
        txt = re.sub(r"&#x0*?251C;", "├", txt)
        txt = re.sub(r"&#0*?9500;", "├", txt)
        txt = re.sub(r"&boxvr;", "├", txt)

        # "U+02524", "BOX DRAWINGS LIGHT VERTICAL AND LEFT"
        txt = re.sub(r"&#x0*?2524;", "┤", txt)
        txt = re.sub(r"&#0*?9508;", "┤", txt)
        txt = re.sub(r"&boxvl;", "┤", txt)

        # "U+0252C", "BOX DRAWINGS LIGHT DOWN AND HORIZONTAL"
        txt = re.sub(r"&#x0*?252C;", "┬", txt)
        txt = re.sub(r"&#0*?9516;", "┬", txt)
        txt = re.sub(r"&boxhd;", "┬", txt)

        # "U+02534", "BOX DRAWINGS LIGHT UP AND HORIZONTAL"
        txt = re.sub(r"&#x0*?2534;", "┴", txt)
        txt = re.sub(r"&#0*?9524;", "┴", txt)
        txt = re.sub(r"&boxhu;", "┴", txt)

        # "U+0253C", "BOX DRAWINGS LIGHT VERTICAL AND HORIZONTAL"
        txt = re.sub(r"&#x0*?253C;", "┼", txt)
        txt = re.sub(r"&#0*?9532;", "┼", txt)
        txt = re.sub(r"&boxvh;", "┼", txt)

        # "U+02550", "BOX DRAWINGS DOUBLE HORIZONTAL"
        txt = re.sub(r"&#x0*?2550;", "═", txt)
        txt = re.sub(r"&#0*?9552;", "═", txt)
        txt = re.sub(r"&boxH;", "═", txt)

        # "U+02551", "BOX DRAWINGS DOUBLE VERTICAL"
        txt = re.sub(r"&#x0*?2551;", "║", txt)
        txt = re.sub(r"&#0*?9553;", "║", txt)
        txt = re.sub(r"&boxV;", "║", txt)

        # "U+02552", "BOX DRAWINGS DOWN SINGLE AND RIGHT DOUBLE"
        txt = re.sub(r"&#x0*?2552;", "╒", txt)
        txt = re.sub(r"&#0*?9554;", "╒", txt)
        txt = re.sub(r"&boxdR;", "╒", txt)

        # "U+02553", "BOX DRAWINGS DOWN DOUBLE AND RIGHT SINGLE"
        txt = re.sub(r"&#x0*?2553;", "╓", txt)
        txt = re.sub(r"&#0*?9555;", "╓", txt)
        txt = re.sub(r"&boxDr;", "╓", txt)

        # "U+02554", "BOX DRAWINGS DOUBLE DOWN AND RIGHT"
        txt = re.sub(r"&#x0*?2554;", "╔", txt)
        txt = re.sub(r"&#0*?9556;", "╔", txt)
        txt = re.sub(r"&boxDR;", "╔", txt)

        # "U+02555", "BOX DRAWINGS DOWN SINGLE AND LEFT DOUBLE"
        txt = re.sub(r"&#x0*?2555;", "╕", txt)
        txt = re.sub(r"&#0*?9557;", "╕", txt)
        txt = re.sub(r"&boxdL;", "╕", txt)

        # "U+02556", "BOX DRAWINGS DOWN DOUBLE AND LEFT SINGLE"
        txt = re.sub(r"&#x0*?2556;", "╖", txt)
        txt = re.sub(r"&#0*?9558;", "╖", txt)
        txt = re.sub(r"&boxDl;", "╖", txt)

        # "U+02557", "BOX DRAWINGS DOUBLE DOWN AND LEFT"
        txt = re.sub(r"&#x0*?2557;", "╗", txt)
        txt = re.sub(r"&#0*?9559;", "╗", txt)
        txt = re.sub(r"&boxDL;", "╗", txt)

        # "U+02558", "BOX DRAWINGS UP SINGLE AND RIGHT DOUBLE"
        txt = re.sub(r"&#x0*?2558;", "╘", txt)
        txt = re.sub(r"&#0*?9560;", "╘", txt)
        txt = re.sub(r"&boxuR;", "╘", txt)

        # "U+02559", "BOX DRAWINGS UP DOUBLE AND RIGHT SINGLE"
        txt = re.sub(r"&#x0*?2559;", "╙", txt)
        txt = re.sub(r"&#0*?9561;", "╙", txt)
        txt = re.sub(r"&boxUr;", "╙", txt)

        # "U+0255A", "BOX DRAWINGS DOUBLE UP AND RIGHT"
        txt = re.sub(r"&#x0*?255A;", "╚", txt)
        txt = re.sub(r"&#0*?9562;", "╚", txt)
        txt = re.sub(r"&boxUR;", "╚", txt)

        # "U+0255B", "BOX DRAWINGS UP SINGLE AND LEFT DOUBLE"
        txt = re.sub(r"&#x0*?255B;", "╛", txt)
        txt = re.sub(r"&#0*?9563;", "╛", txt)
        txt = re.sub(r"&boxuL;", "╛", txt)

        # "U+0255C", "BOX DRAWINGS UP DOUBLE AND LEFT SINGLE"
        txt = re.sub(r"&#x0*?255C;", "╜", txt)
        txt = re.sub(r"&#0*?9564;", "╜", txt)
        txt = re.sub(r"&boxUl;", "╜", txt)

        # "U+0255D", "BOX DRAWINGS DOUBLE UP AND LEFT"
        txt = re.sub(r"&#x0*?255D;", "╝", txt)
        txt = re.sub(r"&#0*?9565;", "╝", txt)
        txt = re.sub(r"&boxUL;", "╝", txt)

        # "U+0255E", "BOX DRAWINGS VERTICAL SINGLE AND RIGHT DOUBLE"
        txt = re.sub(r"&#x0*?255E;", "╞", txt)
        txt = re.sub(r"&#0*?9566;", "╞", txt)
        txt = re.sub(r"&boxvR;", "╞", txt)

        # "U+0255F", "BOX DRAWINGS VERTICAL DOUBLE AND RIGHT SINGLE"
        txt = re.sub(r"&#x0*?255F;", "╟", txt)
        txt = re.sub(r"&#0*?9567;", "╟", txt)
        txt = re.sub(r"&boxVr;", "╟", txt)

        # "U+02560", "BOX DRAWINGS DOUBLE VERTICAL AND RIGHT"
        txt = re.sub(r"&#x0*?2560;", "╠", txt)
        txt = re.sub(r"&#0*?9568;", "╠", txt)
        txt = re.sub(r"&boxVR;", "╠", txt)

        # "U+02561", "BOX DRAWINGS VERTICAL SINGLE AND LEFT DOUBLE"
        txt = re.sub(r"&#x0*?2561;", "╡", txt)
        txt = re.sub(r"&#0*?9569;", "╡", txt)
        txt = re.sub(r"&boxvL;", "╡", txt)

        # "U+02562", "BOX DRAWINGS VERTICAL DOUBLE AND LEFT SINGLE"
        txt = re.sub(r"&#x0*?2562;", "╢", txt)
        txt = re.sub(r"&#0*?9570;", "╢", txt)
        txt = re.sub(r"&boxVl;", "╢", txt)

        # "U+02563", "BOX DRAWINGS DOUBLE VERTICAL AND LEFT"
        txt = re.sub(r"&#x0*?2563;", "╣", txt)
        txt = re.sub(r"&#0*?9571;", "╣", txt)
        txt = re.sub(r"&boxVL;", "╣", txt)

        # "U+02564", "BOX DRAWINGS DOWN SINGLE AND HORIZONTAL DOUBLE"
        txt = re.sub(r"&#x0*?2564;", "╤", txt)
        txt = re.sub(r"&#0*?9572;", "╤", txt)
        txt = re.sub(r"&boxHd;", "╤", txt)

        # "U+02565", "BOX DRAWINGS DOWN DOUBLE AND HORIZONTAL SINGLE"
        txt = re.sub(r"&#x0*?2565;", "╥", txt)
        txt = re.sub(r"&#0*?9573;", "╥", txt)
        txt = re.sub(r"&boxhD;", "╥", txt)

        # "U+02566", "BOX DRAWINGS DOUBLE DOWN AND HORIZONTAL"
        txt = re.sub(r"&#x0*?2566;", "╦", txt)
        txt = re.sub(r"&#0*?9574;", "╦", txt)
        txt = re.sub(r"&boxHD;", "╦", txt)

        # "U+02567", "BOX DRAWINGS UP SINGLE AND HORIZONTAL DOUBLE"
        txt = re.sub(r"&#x0*?2567;", "╧", txt)
        txt = re.sub(r"&#0*?9575;", "╧", txt)
        txt = re.sub(r"&boxHu;", "╧", txt)

        # "U+02568", "BOX DRAWINGS UP DOUBLE AND HORIZONTAL SINGLE"
        txt = re.sub(r"&#x0*?2568;", "╨", txt)
        txt = re.sub(r"&#0*?9576;", "╨", txt)
        txt = re.sub(r"&boxhU;", "╨", txt)

        # "U+02569", "BOX DRAWINGS DOUBLE UP AND HORIZONTAL"
        txt = re.sub(r"&#x0*?2569;", "╩", txt)
        txt = re.sub(r"&#0*?9577;", "╩", txt)
        txt = re.sub(r"&boxHU;", "╩", txt)

        # "U+0256A", "BOX DRAWINGS VERTICAL SINGLE AND HORIZONTAL DOUBLE"
        txt = re.sub(r"&#x0*?256A;", "╪", txt)
        txt = re.sub(r"&#0*?9578;", "╪", txt)
        txt = re.sub(r"&boxvH;", "╪", txt)

        # "U+0256B", "BOX DRAWINGS VERTICAL DOUBLE AND HORIZONTAL SINGLE"
        txt = re.sub(r"&#x0*?256B;", "╫", txt)
        txt = re.sub(r"&#0*?9579;", "╫", txt)
        txt = re.sub(r"&boxVh;", "╫", txt)

        # "U+0256C", "BOX DRAWINGS DOUBLE VERTICAL AND HORIZONTAL"
        txt = re.sub(r"&#x0*?256C;", "╬", txt)
        txt = re.sub(r"&#0*?9580;", "╬", txt)
        txt = re.sub(r"&boxVH;", "╬", txt)

        # "U+02580", "UPPER HALF BLOCK"
        txt = re.sub(r"&#x0*?2580;", "▀", txt)
        txt = re.sub(r"&#0*?9600;", "▀", txt)
        txt = re.sub(r"&uhblk;", "▀", txt)

        # "U+02584", "LOWER HALF BLOCK"
        txt = re.sub(r"&#x0*?2584;", "▄", txt)
        txt = re.sub(r"&#0*?9604;", "▄", txt)
        txt = re.sub(r"&lhblk;", "▄", txt)

        # "U+02588", "FULL BLOCK"
        txt = re.sub(r"&#x0*?2588;", "█", txt)
        txt = re.sub(r"&#0*?9608;", "█", txt)
        txt = re.sub(r"&block;", "█", txt)

        # "U+02591", "LIGHT SHADE"
        txt = re.sub(r"&#x0*?2591;", "░", txt)
        txt = re.sub(r"&#0*?9617;", "░", txt)
        txt = re.sub(r"&blk14;", "░", txt)

        # "U+02592", "MEDIUM SHADE"
        txt = re.sub(r"&#x0*?2592;", "▒", txt)
        txt = re.sub(r"&#0*?9618;", "▒", txt)
        txt = re.sub(r"&blk12;", "▒", txt)

        # "U+02593", "DARK SHADE"
        txt = re.sub(r"&#x0*?2593;", "▓", txt)
        txt = re.sub(r"&#0*?9619;", "▓", txt)
        txt = re.sub(r"&blk34;", "▓", txt)

        # "U+025A1", "WHITE SQUARE"
        txt = re.sub(r"&#x0*?25A1;", "□", txt)
        txt = re.sub(r"&#0*?9633;", "□", txt)
        txt = re.sub(r"&squ;", "□", txt)
        txt = re.sub(r"&square;", "□", txt)
        txt = re.sub(r"&Square;", "□", txt)

        # "U+025AA", "BLACK SMALL SQUARE"
        txt = re.sub(r"&#x0*?25AA;", "▪", txt)
        txt = re.sub(r"&#0*?9642;", "▪", txt)
        txt = re.sub(r"&squf;", "▪", txt)
        txt = re.sub(r"&squarf;", "▪", txt)
        txt = re.sub(r"&blacksquare;", "▪", txt)
        txt = re.sub(r"&FilledVerySmallSquare;", "▪", txt)

        # "U+025AB", "WHITE SMALL SQUARE"
        txt = re.sub(r"&#x0*?25AB;", "▫", txt)
        txt = re.sub(r"&#0*?9643;", "▫", txt)
        txt = re.sub(r"&EmptyVerySmallSquare;", "▫", txt)

        # "U+025AD", "WHITE RECTANGLE"
        txt = re.sub(r"&#x0*?25AD;", "▭", txt)
        txt = re.sub(r"&#0*?9645;", "▭", txt)
        txt = re.sub(r"&rect;", "▭", txt)

        # "U+025AE", "BLACK VERTICAL RECTANGLE"
        txt = re.sub(r"&#x0*?25AE;", "▮", txt)
        txt = re.sub(r"&#0*?9646;", "▮", txt)
        txt = re.sub(r"&marker;", "▮", txt)

        # "U+025B1", "WHITE PARALLELOGRAM"
        txt = re.sub(r"&#x0*?25B1;", "▱", txt)
        txt = re.sub(r"&#0*?9649;", "▱", txt)
        txt = re.sub(r"&fltns;", "▱", txt)

        # "U+025B3", "WHITE UP-POINTING TRIANGLE"
        txt = re.sub(r"&#x0*?25B3;", "△", txt)
        txt = re.sub(r"&#0*?9651;", "△", txt)
        txt = re.sub(r"&xutri;", "△", txt)
        txt = re.sub(r"&bigtriangleup;", "△", txt)

        # "U+025B4", "BLACK UP-POINTING SMALL TRIANGLE"
        txt = re.sub(r"&#x0*?25B4;", "▴", txt)
        txt = re.sub(r"&#0*?9652;", "▴", txt)
        txt = re.sub(r"&utrif;", "▴", txt)
        txt = re.sub(r"&blacktriangle;", "▴", txt)

        # "U+025B5", "WHITE UP-POINTING SMALL TRIANGLE"
        txt = re.sub(r"&#x0*?25B5;", "▵", txt)
        txt = re.sub(r"&#0*?9653;", "▵", txt)
        txt = re.sub(r"&utri;", "▵", txt)
        txt = re.sub(r"&triangle;", "▵", txt)

        # "U+025B8", "BLACK RIGHT-POINTING SMALL TRIANGLE"
        txt = re.sub(r"&#x0*?25B8;", "▸", txt)
        txt = re.sub(r"&#0*?9656;", "▸", txt)
        txt = re.sub(r"&rtrif;", "▸", txt)
        txt = re.sub(r"&blacktriangleright;", "▸", txt)

        # "U+025B9", "WHITE RIGHT-POINTING SMALL TRIANGLE"
        txt = re.sub(r"&#x0*?25B9;", "▹", txt)
        txt = re.sub(r"&#0*?9657;", "▹", txt)
        txt = re.sub(r"&rtri;", "▹", txt)
        txt = re.sub(r"&triangleright;", "▹", txt)

        # "U+025BD", "WHITE DOWN-POINTING TRIANGLE"
        txt = re.sub(r"&#x0*?25BD;", "▽", txt)
        txt = re.sub(r"&#0*?9661;", "▽", txt)
        txt = re.sub(r"&xdtri;", "▽", txt)
        txt = re.sub(r"&bigtriangledown;", "▽", txt)

        # "U+025BE", "BLACK DOWN-POINTING SMALL TRIANGLE"
        txt = re.sub(r"&#x0*?25BE;", "▾", txt)
        txt = re.sub(r"&#0*?9662;", "▾", txt)
        txt = re.sub(r"&dtrif;", "▾", txt)
        txt = re.sub(r"&blacktriangledown;", "▾", txt)

        # "U+025BF", "WHITE DOWN-POINTING SMALL TRIANGLE"
        txt = re.sub(r"&#x0*?25BF;", "▿", txt)
        txt = re.sub(r"&#0*?9663;", "▿", txt)
        txt = re.sub(r"&dtri;", "▿", txt)
        txt = re.sub(r"&triangledown;", "▿", txt)

        # "U+025C2", "BLACK LEFT-POINTING SMALL TRIANGLE"
        txt = re.sub(r"&#x0*?25C2;", "◂", txt)
        txt = re.sub(r"&#0*?9666;", "◂", txt)
        txt = re.sub(r"&ltrif;", "◂", txt)
        txt = re.sub(r"&blacktriangleleft;", "◂", txt)

        # "U+025C3", "WHITE LEFT-POINTING SMALL TRIANGLE"
        txt = re.sub(r"&#x0*?25C3;", "◃", txt)
        txt = re.sub(r"&#0*?9667;", "◃", txt)
        txt = re.sub(r"&ltri;", "◃", txt)
        txt = re.sub(r"&triangleleft;", "◃", txt)

        # "U+025CA", "LOZENGE"
        txt = re.sub(r"&#x0*?25CA;", "◊", txt)
        txt = re.sub(r"&#0*?9674;", "◊", txt)
        txt = re.sub(r"&loz;", "◊", txt)
        txt = re.sub(r"&lozenge;", "◊", txt)

        # "U+025CB", "WHITE CIRCLE"
        txt = re.sub(r"&#x0*?25CB;", "○", txt)
        txt = re.sub(r"&#0*?9675;", "○", txt)
        txt = re.sub(r"&cir;", "○", txt)

        # "U+025EC", "WHITE UP-POINTING TRIANGLE WITH DOT"
        txt = re.sub(r"&#x0*?25EC;", "◬", txt)
        txt = re.sub(r"&#0*?9708;", "◬", txt)
        txt = re.sub(r"&tridot;", "◬", txt)

        # "U+025EF", "LARGE CIRCLE"
        txt = re.sub(r"&#x0*?25EF;", "◯", txt)
        txt = re.sub(r"&#0*?9711;", "◯", txt)
        txt = re.sub(r"&xcirc;", "◯", txt)
        txt = re.sub(r"&bigcirc;", "◯", txt)

        # "U+025F8", "UPPER LEFT TRIANGLE"
        txt = re.sub(r"&#x0*?25F8;", "◸", txt)
        txt = re.sub(r"&#0*?9720;", "◸", txt)
        txt = re.sub(r"&ultri;", "◸", txt)

        # "U+025F9", "UPPER RIGHT TRIANGLE"
        txt = re.sub(r"&#x0*?25F9;", "◹", txt)
        txt = re.sub(r"&#0*?9721;", "◹", txt)
        txt = re.sub(r"&urtri;", "◹", txt)

        # "U+025FA", "LOWER LEFT TRIANGLE"
        txt = re.sub(r"&#x0*?25FA;", "◺", txt)
        txt = re.sub(r"&#0*?9722;", "◺", txt)
        txt = re.sub(r"&lltri;", "◺", txt)

        # "U+025FB", "WHITE MEDIUM SQUARE"
        txt = re.sub(r"&#x0*?25FB;", "◻", txt)
        txt = re.sub(r"&#0*?9723;", "◻", txt)
        txt = re.sub(r"&EmptySmallSquare;", "◻", txt)

        # "U+025FC", "BLACK MEDIUM SQUARE"
        txt = re.sub(r"&#x0*?25FC;", "◼", txt)
        txt = re.sub(r"&#0*?9724;", "◼", txt)
        txt = re.sub(r"&FilledSmallSquare;", "◼", txt)

        # "U+02605", "BLACK STAR"
        txt = re.sub(r"&#x0*?2605;", "★", txt)
        txt = re.sub(r"&#0*?9733;", "★", txt)
        txt = re.sub(r"&starf;", "★", txt)
        txt = re.sub(r"&bigstar;", "★", txt)

        # "U+02606", "WHITE STAR"
        txt = re.sub(r"&#x0*?2606;", "☆", txt)
        txt = re.sub(r"&#0*?9734;", "☆", txt)
        txt = re.sub(r"&star;", "☆", txt)

        # "U+0260E", "BLACK TELEPHONE"
        txt = re.sub(r"&#x0*?260E;", "☎", txt)
        txt = re.sub(r"&#0*?9742;", "☎", txt)
        txt = re.sub(r"&phone;", "☎", txt)

        # "U+02640", "FEMALE SIGN"
        txt = re.sub(r"&#x0*?2640;", "♀", txt)
        txt = re.sub(r"&#0*?9792;", "♀", txt)
        txt = re.sub(r"&female;", "♀", txt)

        # "U+02642", "MALE SIGN"
        txt = re.sub(r"&#x0*?2642;", "♂", txt)
        txt = re.sub(r"&#0*?9794;", "♂", txt)
        txt = re.sub(r"&male;", "♂", txt)

        # "U+02660", "BLACK SPADE SUIT"
        txt = re.sub(r"&#x0*?2660;", "♠", txt)
        txt = re.sub(r"&#0*?9824;", "♠", txt)
        txt = re.sub(r"&spades;", "♠", txt)
        txt = re.sub(r"&spadesuit;", "♠", txt)

        # "U+02663", "BLACK CLUB SUIT"
        txt = re.sub(r"&#x0*?2663;", "♣", txt)
        txt = re.sub(r"&#0*?9827;", "♣", txt)
        txt = re.sub(r"&clubs;", "♣", txt)
        txt = re.sub(r"&clubsuit;", "♣", txt)

        # "U+02665", "BLACK HEART SUIT"
        txt = re.sub(r"&#x0*?2665;", "♥", txt)
        txt = re.sub(r"&#0*?9829;", "♥", txt)
        txt = re.sub(r"&hearts;", "♥", txt)
        txt = re.sub(r"&heartsuit;", "♥", txt)

        # "U+02666", "BLACK DIAMOND SUIT"
        txt = re.sub(r"&#x0*?2666;", "♦", txt)
        txt = re.sub(r"&#0*?9830;", "♦", txt)
        txt = re.sub(r"&diams;", "♦", txt)
        txt = re.sub(r"&diamondsuit;", "♦", txt)

        # "U+0266A", "EIGHTH NOTE"
        txt = re.sub(r"&#x0*?266A;", "♪", txt)
        txt = re.sub(r"&#0*?9834;", "♪", txt)
        txt = re.sub(r"&sung;", "♪", txt)

        # "U+0266D", "MUSIC FLAT SIGN"
        txt = re.sub(r"&#x0*?266D;", "♭", txt)
        txt = re.sub(r"&#0*?9837;", "♭", txt)
        txt = re.sub(r"&flat;", "♭", txt)

        # "U+0266E", "MUSIC NATURAL SIGN"
        txt = re.sub(r"&#x0*?266E;", "♮", txt)
        txt = re.sub(r"&#0*?9838;", "♮", txt)
        txt = re.sub(r"&natur;", "♮", txt)
        txt = re.sub(r"&natural;", "♮", txt)

        # "U+0266F", "MUSIC SHARP SIGN"
        txt = re.sub(r"&#x0*?266F;", "♯", txt)
        txt = re.sub(r"&#0*?9839;", "♯", txt)
        txt = re.sub(r"&sharp;", "♯", txt)

        # "U+02713", "CHECK MARK"
        txt = re.sub(r"&#x0*?2713;", "✓", txt)
        txt = re.sub(r"&#0*?10003;", "✓", txt)
        txt = re.sub(r"&check;", "✓", txt)
        txt = re.sub(r"&checkmark;", "✓", txt)

        # "U+02717", "BALLOT X"
        txt = re.sub(r"&#x0*?2717;", "✗", txt)
        txt = re.sub(r"&#0*?10007;", "✗", txt)
        txt = re.sub(r"&cross;", "✗", txt)

        # "U+02720", "MALTESE CROSS"
        txt = re.sub(r"&#x0*?2720;", "✠", txt)
        txt = re.sub(r"&#0*?10016;", "✠", txt)
        txt = re.sub(r"&malt;", "✠", txt)
        txt = re.sub(r"&maltese;", "✠", txt)

        # "U+02736", "SIX POINTED BLACK STAR"
        txt = re.sub(r"&#x0*?2736;", "✶", txt)
        txt = re.sub(r"&#0*?10038;", "✶", txt)
        txt = re.sub(r"&sext;", "✶", txt)

        # "U+02758", "LIGHT VERTICAL BAR"
        txt = re.sub(r"&#x0*?2758;", "❘", txt)
        txt = re.sub(r"&#0*?10072;", "❘", txt)
        txt = re.sub(r"&VerticalSeparator;", "❘", txt)

        # "U+02772", "LIGHT LEFT TORTOISE SHELL BRACKET ORNAMENT"
        txt = re.sub(r"&#x0*?2772;", "❲", txt)
        txt = re.sub(r"&#0*?10098;", "❲", txt)
        txt = re.sub(r"&lbbrk;", "❲", txt)

        # "U+02773", "LIGHT RIGHT TORTOISE SHELL BRACKET ORNAMENT"
        txt = re.sub(r"&#x0*?2773;", "❳", txt)
        txt = re.sub(r"&#0*?10099;", "❳", txt)
        txt = re.sub(r"&rbbrk;", "❳", txt)

        # "U+027E6", "MATHEMATICAL LEFT WHITE SQUARE BRACKET"
        txt = re.sub(r"&#x0*?27E6;", "⟦", txt)
        txt = re.sub(r"&#0*?10214;", "⟦", txt)
        txt = re.sub(r"&lobrk;", "⟦", txt)
        txt = re.sub(r"&LeftDoubleBracket;", "⟦", txt)

        # "U+027E7", "MATHEMATICAL RIGHT WHITE SQUARE BRACKET"
        txt = re.sub(r"&#x0*?27E7;", "⟧", txt)
        txt = re.sub(r"&#0*?10215;", "⟧", txt)
        txt = re.sub(r"&robrk;", "⟧", txt)
        txt = re.sub(r"&RightDoubleBracket;", "⟧", txt)

        # "U+027E8", "MATHEMATICAL LEFT ANGLE BRACKET"
        txt = re.sub(r"&#x0*?27E8;", "⟨", txt)
        txt = re.sub(r"&#0*?10216;", "⟨", txt)
        txt = re.sub(r"&lang;", "⟨", txt)
        txt = re.sub(r"&LeftAngleBracket;", "⟨", txt)
        txt = re.sub(r"&langle;", "⟨", txt)

        # "U+027E9", "MATHEMATICAL RIGHT ANGLE BRACKET"
        txt = re.sub(r"&#x0*?27E9;", "⟩", txt)
        txt = re.sub(r"&#0*?10217;", "⟩", txt)
        txt = re.sub(r"&rang;", "⟩", txt)
        txt = re.sub(r"&RightAngleBracket;", "⟩", txt)
        txt = re.sub(r"&rangle;", "⟩", txt)

        # "U+027EA", "MATHEMATICAL LEFT DOUBLE ANGLE BRACKET"
        txt = re.sub(r"&#x0*?27EA;", "⟪", txt)
        txt = re.sub(r"&#0*?10218;", "⟪", txt)
        txt = re.sub(r"&Lang;", "⟪", txt)

        # "U+027EB", "MATHEMATICAL RIGHT DOUBLE ANGLE BRACKET"
        txt = re.sub(r"&#x0*?27EB;", "⟫", txt)
        txt = re.sub(r"&#0*?10219;", "⟫", txt)
        txt = re.sub(r"&Rang;", "⟫", txt)

        # "U+027EC", "MATHEMATICAL LEFT WHITE TORTOISE SHELL BRACKET"
        txt = re.sub(r"&#x0*?27EC;", "⟬", txt)
        txt = re.sub(r"&#0*?10220;", "⟬", txt)
        txt = re.sub(r"&loang;", "⟬", txt)

        # "U+027ED", "MATHEMATICAL RIGHT WHITE TORTOISE SHELL BRACKET"
        txt = re.sub(r"&#x0*?27ED;", "⟭", txt)
        txt = re.sub(r"&#0*?10221;", "⟭", txt)
        txt = re.sub(r"&roang;", "⟭", txt)

        # "U+027F5", "LONG LEFTWARDS ARROW"
        txt = re.sub(r"&#x0*?27F5;", "⟵", txt)
        txt = re.sub(r"&#0*?10229;", "⟵", txt)
        txt = re.sub(r"&xlarr;", "⟵", txt)
        txt = re.sub(r"&longleftarrow;", "⟵", txt)
        txt = re.sub(r"&LongLeftArrow;", "⟵", txt)

        # "U+027F6", "LONG RIGHTWARDS ARROW"
        txt = re.sub(r"&#x0*?27F6;", "⟶", txt)
        txt = re.sub(r"&#0*?10230;", "⟶", txt)
        txt = re.sub(r"&xrarr;", "⟶", txt)
        txt = re.sub(r"&longrightarrow;", "⟶", txt)
        txt = re.sub(r"&LongRightArrow;", "⟶", txt)

        # "U+027F7", "LONG LEFT RIGHT ARROW"
        txt = re.sub(r"&#x0*?27F7;", "⟷", txt)
        txt = re.sub(r"&#0*?10231;", "⟷", txt)
        txt = re.sub(r"&xharr;", "⟷", txt)
        txt = re.sub(r"&longleftrightarrow;", "⟷", txt)
        txt = re.sub(r"&LongLeftRightArrow;", "⟷", txt)

        # "U+027F8", "LONG LEFTWARDS DOUBLE ARROW"
        txt = re.sub(r"&#x0*?27F8;", "⟸", txt)
        txt = re.sub(r"&#0*?10232;", "⟸", txt)
        txt = re.sub(r"&xlArr;", "⟸", txt)
        txt = re.sub(r"&Longleftarrow;", "⟸", txt)
        txt = re.sub(r"&DoubleLongLeftArrow;", "⟸", txt)

        # "U+027F9", "LONG RIGHTWARDS DOUBLE ARROW"
        txt = re.sub(r"&#x0*?27F9;", "⟹", txt)
        txt = re.sub(r"&#0*?10233;", "⟹", txt)
        txt = re.sub(r"&xrArr;", "⟹", txt)
        txt = re.sub(r"&Longrightarrow;", "⟹", txt)
        txt = re.sub(r"&DoubleLongRightArrow;", "⟹", txt)

        # "U+027FA", "LONG LEFT RIGHT DOUBLE ARROW"
        txt = re.sub(r"&#x0*?27FA;", "⟺", txt)
        txt = re.sub(r"&#0*?10234;", "⟺", txt)
        txt = re.sub(r"&xhArr;", "⟺", txt)
        txt = re.sub(r"&Longleftrightarrow;", "⟺", txt)
        txt = re.sub(r"&DoubleLongLeftRightArrow;", "⟺", txt)

        # "U+027FC", "LONG RIGHTWARDS ARROW FROM BAR"
        txt = re.sub(r"&#x0*?27FC;", "⟼", txt)
        txt = re.sub(r"&#0*?10236;", "⟼", txt)
        txt = re.sub(r"&xmap;", "⟼", txt)
        txt = re.sub(r"&longmapsto;", "⟼", txt)

        # "U+027FF", "LONG RIGHTWARDS SQUIGGLE ARROW"
        txt = re.sub(r"&#x0*?27FF;", "⟿", txt)
        txt = re.sub(r"&#0*?10239;", "⟿", txt)
        txt = re.sub(r"&dzigrarr;", "⟿", txt)

        # "U+02902", "LEFTWARDS DOUBLE ARROW WITH VERTICAL STROKE"
        txt = re.sub(r"&#x0*?2902;", "⤂", txt)
        txt = re.sub(r"&#0*?10498;", "⤂", txt)
        txt = re.sub(r"&nvlArr;", "⤂", txt)

        # "U+02903", "RIGHTWARDS DOUBLE ARROW WITH VERTICAL STROKE"
        txt = re.sub(r"&#x0*?2903;", "⤃", txt)
        txt = re.sub(r"&#0*?10499;", "⤃", txt)
        txt = re.sub(r"&nvrArr;", "⤃", txt)

        # "U+02904", "LEFT RIGHT DOUBLE ARROW WITH VERTICAL STROKE"
        txt = re.sub(r"&#x0*?2904;", "⤄", txt)
        txt = re.sub(r"&#0*?10500;", "⤄", txt)
        txt = re.sub(r"&nvHarr;", "⤄", txt)

        # "U+02905", "RIGHTWARDS TWO-HEADED ARROW FROM BAR"
        txt = re.sub(r"&#x0*?2905;", "⤅", txt)
        txt = re.sub(r"&#0*?10501;", "⤅", txt)
        txt = re.sub(r"&Map;", "⤅", txt)

        # "U+0290C", "LEFTWARDS DOUBLE DASH ARROW"
        txt = re.sub(r"&#x0*?290C;", "⤌", txt)
        txt = re.sub(r"&#0*?10508;", "⤌", txt)
        txt = re.sub(r"&lbarr;", "⤌", txt)

        # "U+0290D", "RIGHTWARDS DOUBLE DASH ARROW"
        txt = re.sub(r"&#x0*?290D;", "⤍", txt)
        txt = re.sub(r"&#0*?10509;", "⤍", txt)
        txt = re.sub(r"&rbarr;", "⤍", txt)
        txt = re.sub(r"&bkarow;", "⤍", txt)

        # "U+0290E", "LEFTWARDS TRIPLE DASH ARROW"
        txt = re.sub(r"&#x0*?290E;", "⤎", txt)
        txt = re.sub(r"&#0*?10510;", "⤎", txt)
        txt = re.sub(r"&lBarr;", "⤎", txt)

        # "U+0290F", "RIGHTWARDS TRIPLE DASH ARROW"
        txt = re.sub(r"&#x0*?290F;", "⤏", txt)
        txt = re.sub(r"&#0*?10511;", "⤏", txt)
        txt = re.sub(r"&rBarr;", "⤏", txt)
        txt = re.sub(r"&dbkarow;", "⤏", txt)

        # "U+02910", "RIGHTWARDS TWO-HEADED TRIPLE DASH ARROW"
        txt = re.sub(r"&#x0*?2910;", "⤐", txt)
        txt = re.sub(r"&#0*?10512;", "⤐", txt)
        txt = re.sub(r"&RBarr;", "⤐", txt)
        txt = re.sub(r"&drbkarow;", "⤐", txt)

        # "U+02911", "RIGHTWARDS ARROW WITH DOTTED STEM"
        txt = re.sub(r"&#x0*?2911;", "⤑", txt)
        txt = re.sub(r"&#0*?10513;", "⤑", txt)
        txt = re.sub(r"&DDotrahd;", "⤑", txt)

        # "U+02912", "UPWARDS ARROW TO BAR"
        txt = re.sub(r"&#x0*?2912;", "⤒", txt)
        txt = re.sub(r"&#0*?10514;", "⤒", txt)
        txt = re.sub(r"&UpArrowBar;", "⤒", txt)

        # "U+02913", "DOWNWARDS ARROW TO BAR"
        txt = re.sub(r"&#x0*?2913;", "⤓", txt)
        txt = re.sub(r"&#0*?10515;", "⤓", txt)
        txt = re.sub(r"&DownArrowBar;", "⤓", txt)

        # "U+02916", "RIGHTWARDS TWO-HEADED ARROW WITH TAIL"
        txt = re.sub(r"&#x0*?2916;", "⤖", txt)
        txt = re.sub(r"&#0*?10518;", "⤖", txt)
        txt = re.sub(r"&Rarrtl;", "⤖", txt)

        # "U+02919", "LEFTWARDS ARROW-TAIL"
        txt = re.sub(r"&#x0*?2919;", "⤙", txt)
        txt = re.sub(r"&#0*?10521;", "⤙", txt)
        txt = re.sub(r"&latail;", "⤙", txt)

        # "U+0291A", "RIGHTWARDS ARROW-TAIL"
        txt = re.sub(r"&#x0*?291A;", "⤚", txt)
        txt = re.sub(r"&#0*?10522;", "⤚", txt)
        txt = re.sub(r"&ratail;", "⤚", txt)

        # "U+0291B", "LEFTWARDS DOUBLE ARROW-TAIL"
        txt = re.sub(r"&#x0*?291B;", "⤛", txt)
        txt = re.sub(r"&#0*?10523;", "⤛", txt)
        txt = re.sub(r"&lAtail;", "⤛", txt)

        # "U+0291C", "RIGHTWARDS DOUBLE ARROW-TAIL"
        txt = re.sub(r"&#x0*?291C;", "⤜", txt)
        txt = re.sub(r"&#0*?10524;", "⤜", txt)
        txt = re.sub(r"&rAtail;", "⤜", txt)

        # "U+0291D", "LEFTWARDS ARROW TO BLACK DIAMOND"
        txt = re.sub(r"&#x0*?291D;", "⤝", txt)
        txt = re.sub(r"&#0*?10525;", "⤝", txt)
        txt = re.sub(r"&larrfs;", "⤝", txt)

        # "U+0291E", "RIGHTWARDS ARROW TO BLACK DIAMOND"
        txt = re.sub(r"&#x0*?291E;", "⤞", txt)
        txt = re.sub(r"&#0*?10526;", "⤞", txt)
        txt = re.sub(r"&rarrfs;", "⤞", txt)

        # "U+0291F", "LEFTWARDS ARROW FROM BAR TO BLACK DIAMOND"
        txt = re.sub(r"&#x0*?291F;", "⤟", txt)
        txt = re.sub(r"&#0*?10527;", "⤟", txt)
        txt = re.sub(r"&larrbfs;", "⤟", txt)

        # "U+02920", "RIGHTWARDS ARROW FROM BAR TO BLACK DIAMOND"
        txt = re.sub(r"&#x0*?2920;", "⤠", txt)
        txt = re.sub(r"&#0*?10528;", "⤠", txt)
        txt = re.sub(r"&rarrbfs;", "⤠", txt)

        # "U+02923", "NORTH WEST ARROW WITH HOOK"
        txt = re.sub(r"&#x0*?2923;", "⤣", txt)
        txt = re.sub(r"&#0*?10531;", "⤣", txt)
        txt = re.sub(r"&nwarhk;", "⤣", txt)

        # "U+02924", "NORTH EAST ARROW WITH HOOK"
        txt = re.sub(r"&#x0*?2924;", "⤤", txt)
        txt = re.sub(r"&#0*?10532;", "⤤", txt)
        txt = re.sub(r"&nearhk;", "⤤", txt)

        # "U+02925", "SOUTH EAST ARROW WITH HOOK"
        txt = re.sub(r"&#x0*?2925;", "⤥", txt)
        txt = re.sub(r"&#0*?10533;", "⤥", txt)
        txt = re.sub(r"&searhk;", "⤥", txt)
        txt = re.sub(r"&hksearow;", "⤥", txt)

        # "U+02926", "SOUTH WEST ARROW WITH HOOK"
        txt = re.sub(r"&#x0*?2926;", "⤦", txt)
        txt = re.sub(r"&#0*?10534;", "⤦", txt)
        txt = re.sub(r"&swarhk;", "⤦", txt)
        txt = re.sub(r"&hkswarow;", "⤦", txt)

        # "U+02927", "NORTH WEST ARROW AND NORTH EAST ARROW"
        txt = re.sub(r"&#x0*?2927;", "⤧", txt)
        txt = re.sub(r"&#0*?10535;", "⤧", txt)
        txt = re.sub(r"&nwnear;", "⤧", txt)

        # "U+02928", "NORTH EAST ARROW AND SOUTH EAST ARROW"
        txt = re.sub(r"&#x0*?2928;", "⤨", txt)
        txt = re.sub(r"&#0*?10536;", "⤨", txt)
        txt = re.sub(r"&nesear;", "⤨", txt)
        txt = re.sub(r"&toea;", "⤨", txt)

        # "U+02929", "SOUTH EAST ARROW AND SOUTH WEST ARROW"
        txt = re.sub(r"&#x0*?2929;", "⤩", txt)
        txt = re.sub(r"&#0*?10537;", "⤩", txt)
        txt = re.sub(r"&seswar;", "⤩", txt)
        txt = re.sub(r"&tosa;", "⤩", txt)

        # "U+0292A", "SOUTH WEST ARROW AND NORTH WEST ARROW"
        txt = re.sub(r"&#x0*?292A;", "⤪", txt)
        txt = re.sub(r"&#0*?10538;", "⤪", txt)
        txt = re.sub(r"&swnwar;", "⤪", txt)

        # "U+02933", "WAVE ARROW POINTING DIRECTLY RIGHT"
        txt = re.sub(r"&#x0*?2933;", "⤳", txt)
        txt = re.sub(r"&#0*?10547;", "⤳", txt)
        txt = re.sub(r"&rarrc;", "⤳", txt)

        # "U+02935", "ARROW POINTING RIGHTWARDS THEN CURVING DOWNWARDS"
        txt = re.sub(r"&#x0*?2935;", "⤵", txt)
        txt = re.sub(r"&#0*?10549;", "⤵", txt)
        txt = re.sub(r"&cudarrr;", "⤵", txt)

        # "U+02936", "ARROW POINTING DOWNWARDS THEN CURVING LEFTWARDS"
        txt = re.sub(r"&#x0*?2936;", "⤶", txt)
        txt = re.sub(r"&#0*?10550;", "⤶", txt)
        txt = re.sub(r"&ldca;", "⤶", txt)

        # "U+02937", "ARROW POINTING DOWNWARDS THEN CURVING RIGHTWARDS"
        txt = re.sub(r"&#x0*?2937;", "⤷", txt)
        txt = re.sub(r"&#0*?10551;", "⤷", txt)
        txt = re.sub(r"&rdca;", "⤷", txt)

        # "U+02938", "RIGHT-SIDE ARC CLOCKWISE ARROW"
        txt = re.sub(r"&#x0*?2938;", "⤸", txt)
        txt = re.sub(r"&#0*?10552;", "⤸", txt)
        txt = re.sub(r"&cudarrl;", "⤸", txt)

        # "U+02939", "LEFT-SIDE ARC ANTICLOCKWISE ARROW"
        txt = re.sub(r"&#x0*?2939;", "⤹", txt)
        txt = re.sub(r"&#0*?10553;", "⤹", txt)
        txt = re.sub(r"&larrpl;", "⤹", txt)

        # "U+0293C", "TOP ARC CLOCKWISE ARROW WITH MINUS"
        txt = re.sub(r"&#x0*?293C;", "⤼", txt)
        txt = re.sub(r"&#0*?10556;", "⤼", txt)
        txt = re.sub(r"&curarrm;", "⤼", txt)

        # "U+0293D", "TOP ARC ANTICLOCKWISE ARROW WITH PLUS"
        txt = re.sub(r"&#x0*?293D;", "⤽", txt)
        txt = re.sub(r"&#0*?10557;", "⤽", txt)
        txt = re.sub(r"&cularrp;", "⤽", txt)

        # "U+02945", "RIGHTWARDS ARROW WITH PLUS BELOW"
        txt = re.sub(r"&#x0*?2945;", "⥅", txt)
        txt = re.sub(r"&#0*?10565;", "⥅", txt)
        txt = re.sub(r"&rarrpl;", "⥅", txt)

        # "U+02948", "LEFT RIGHT ARROW THROUGH SMALL CIRCLE"
        txt = re.sub(r"&#x0*?2948;", "⥈", txt)
        txt = re.sub(r"&#0*?10568;", "⥈", txt)
        txt = re.sub(r"&harrcir;", "⥈", txt)

        # "U+02949", "UPWARDS TWO-HEADED ARROW FROM SMALL CIRCLE"
        txt = re.sub(r"&#x0*?2949;", "⥉", txt)
        txt = re.sub(r"&#0*?10569;", "⥉", txt)
        txt = re.sub(r"&Uarrocir;", "⥉", txt)

        # "U+0294A", "LEFT BARB UP RIGHT BARB DOWN HARPOON"
        txt = re.sub(r"&#x0*?294A;", "⥊", txt)
        txt = re.sub(r"&#0*?10570;", "⥊", txt)
        txt = re.sub(r"&lurdshar;", "⥊", txt)

        # "U+0294B", "LEFT BARB DOWN RIGHT BARB UP HARPOON"
        txt = re.sub(r"&#x0*?294B;", "⥋", txt)
        txt = re.sub(r"&#0*?10571;", "⥋", txt)
        txt = re.sub(r"&ldrushar;", "⥋", txt)

        # "U+0294E", "LEFT BARB UP RIGHT BARB UP HARPOON"
        txt = re.sub(r"&#x0*?294E;", "⥎", txt)
        txt = re.sub(r"&#0*?10574;", "⥎", txt)
        txt = re.sub(r"&LeftRightVector;", "⥎", txt)

        # "U+0294F", "UP BARB RIGHT DOWN BARB RIGHT HARPOON"
        txt = re.sub(r"&#x0*?294F;", "⥏", txt)
        txt = re.sub(r"&#0*?10575;", "⥏", txt)
        txt = re.sub(r"&RightUpDownVector;", "⥏", txt)

        # "U+02950", "LEFT BARB DOWN RIGHT BARB DOWN HARPOON"
        txt = re.sub(r"&#x0*?2950;", "⥐", txt)
        txt = re.sub(r"&#0*?10576;", "⥐", txt)
        txt = re.sub(r"&DownLeftRightVector;", "⥐", txt)

        # "U+02951", "UP BARB LEFT DOWN BARB LEFT HARPOON"
        txt = re.sub(r"&#x0*?2951;", "⥑", txt)
        txt = re.sub(r"&#0*?10577;", "⥑", txt)
        txt = re.sub(r"&LeftUpDownVector;", "⥑", txt)

        # "U+02952", "LEFTWARDS HARPOON WITH BARB UP TO BAR"
        txt = re.sub(r"&#x0*?2952;", "⥒", txt)
        txt = re.sub(r"&#0*?10578;", "⥒", txt)
        txt = re.sub(r"&LeftVectorBar;", "⥒", txt)

        # "U+02953", "RIGHTWARDS HARPOON WITH BARB UP TO BAR"
        txt = re.sub(r"&#x0*?2953;", "⥓", txt)
        txt = re.sub(r"&#0*?10579;", "⥓", txt)
        txt = re.sub(r"&RightVectorBar;", "⥓", txt)

        # "U+02954", "UPWARDS HARPOON WITH BARB RIGHT TO BAR"
        txt = re.sub(r"&#x0*?2954;", "⥔", txt)
        txt = re.sub(r"&#0*?10580;", "⥔", txt)
        txt = re.sub(r"&RightUpVectorBar;", "⥔", txt)

        # "U+02955", "DOWNWARDS HARPOON WITH BARB RIGHT TO BAR"
        txt = re.sub(r"&#x0*?2955;", "⥕", txt)
        txt = re.sub(r"&#0*?10581;", "⥕", txt)
        txt = re.sub(r"&RightDownVectorBar;", "⥕", txt)

        # "U+02956", "LEFTWARDS HARPOON WITH BARB DOWN TO BAR"
        txt = re.sub(r"&#x0*?2956;", "⥖", txt)
        txt = re.sub(r"&#0*?10582;", "⥖", txt)
        txt = re.sub(r"&DownLeftVectorBar;", "⥖", txt)

        # "U+02957", "RIGHTWARDS HARPOON WITH BARB DOWN TO BAR"
        txt = re.sub(r"&#x0*?2957;", "⥗", txt)
        txt = re.sub(r"&#0*?10583;", "⥗", txt)
        txt = re.sub(r"&DownRightVectorBar;", "⥗", txt)

        # "U+02958", "UPWARDS HARPOON WITH BARB LEFT TO BAR"
        txt = re.sub(r"&#x0*?2958;", "⥘", txt)
        txt = re.sub(r"&#0*?10584;", "⥘", txt)
        txt = re.sub(r"&LeftUpVectorBar;", "⥘", txt)

        # "U+02959", "DOWNWARDS HARPOON WITH BARB LEFT TO BAR"
        txt = re.sub(r"&#x0*?2959;", "⥙", txt)
        txt = re.sub(r"&#0*?10585;", "⥙", txt)
        txt = re.sub(r"&LeftDownVectorBar;", "⥙", txt)

        # "U+0295A", "LEFTWARDS HARPOON WITH BARB UP FROM BAR"
        txt = re.sub(r"&#x0*?295A;", "⥚", txt)
        txt = re.sub(r"&#0*?10586;", "⥚", txt)
        txt = re.sub(r"&LeftTeeVector;", "⥚", txt)

        # "U+0295B", "RIGHTWARDS HARPOON WITH BARB UP FROM BAR"
        txt = re.sub(r"&#x0*?295B;", "⥛", txt)
        txt = re.sub(r"&#0*?10587;", "⥛", txt)
        txt = re.sub(r"&RightTeeVector;", "⥛", txt)

        # "U+0295C", "UPWARDS HARPOON WITH BARB RIGHT FROM BAR"
        txt = re.sub(r"&#x0*?295C;", "⥜", txt)
        txt = re.sub(r"&#0*?10588;", "⥜", txt)
        txt = re.sub(r"&RightUpTeeVector;", "⥜", txt)

        # "U+0295D", "DOWNWARDS HARPOON WITH BARB RIGHT FROM BAR"
        txt = re.sub(r"&#x0*?295D;", "⥝", txt)
        txt = re.sub(r"&#0*?10589;", "⥝", txt)
        txt = re.sub(r"&RightDownTeeVector;", "⥝", txt)

        # "U+0295E", "LEFTWARDS HARPOON WITH BARB DOWN FROM BAR"
        txt = re.sub(r"&#x0*?295E;", "⥞", txt)
        txt = re.sub(r"&#0*?10590;", "⥞", txt)
        txt = re.sub(r"&DownLeftTeeVector;", "⥞", txt)

        # "U+0295F", "RIGHTWARDS HARPOON WITH BARB DOWN FROM BAR"
        txt = re.sub(r"&#x0*?295F;", "⥟", txt)
        txt = re.sub(r"&#0*?10591;", "⥟", txt)
        txt = re.sub(r"&DownRightTeeVector;", "⥟", txt)

        # "U+02960", "UPWARDS HARPOON WITH BARB LEFT FROM BAR"
        txt = re.sub(r"&#x0*?2960;", "⥠", txt)
        txt = re.sub(r"&#0*?10592;", "⥠", txt)
        txt = re.sub(r"&LeftUpTeeVector;", "⥠", txt)

        # "U+02961", "DOWNWARDS HARPOON WITH BARB LEFT FROM BAR"
        txt = re.sub(r"&#x0*?2961;", "⥡", txt)
        txt = re.sub(r"&#0*?10593;", "⥡", txt)
        txt = re.sub(r"&LeftDownTeeVector;", "⥡", txt)

        # "U+02962", "LEFTWARDS HARPOON WITH BARB UP ABOVE LEFTWARDS HARPOON WITH BARB DOWN"
        txt = re.sub(r"&#x0*?2962;", "⥢", txt)
        txt = re.sub(r"&#0*?10594;", "⥢", txt)
        txt = re.sub(r"&lHar;", "⥢", txt)

        # "U+02963", "UPWARDS HARPOON WITH BARB LEFT BESIDE UPWARDS HARPOON WITH BARB RIGHT"
        txt = re.sub(r"&#x0*?2963;", "⥣", txt)
        txt = re.sub(r"&#0*?10595;", "⥣", txt)
        txt = re.sub(r"&uHar;", "⥣", txt)

        # "U+02964", "RIGHTWARDS HARPOON WITH BARB UP ABOVE RIGHTWARDS HARPOON WITH BARB DOWN"
        txt = re.sub(r"&#x0*?2964;", "⥤", txt)
        txt = re.sub(r"&#0*?10596;", "⥤", txt)
        txt = re.sub(r"&rHar;", "⥤", txt)

        # "U+02965", "DOWNWARDS HARPOON WITH BARB LEFT BESIDE DOWNWARDS HARPOON WITH BARB RIGHT"
        txt = re.sub(r"&#x0*?2965;", "⥥", txt)
        txt = re.sub(r"&#0*?10597;", "⥥", txt)
        txt = re.sub(r"&dHar;", "⥥", txt)

        # "U+02966", "LEFTWARDS HARPOON WITH BARB UP ABOVE RIGHTWARDS HARPOON WITH BARB UP"
        txt = re.sub(r"&#x0*?2966;", "⥦", txt)
        txt = re.sub(r"&#0*?10598;", "⥦", txt)
        txt = re.sub(r"&luruhar;", "⥦", txt)

        # "U+02967", "LEFTWARDS HARPOON WITH BARB DOWN ABOVE RIGHTWARDS HARPOON WITH BARB DOWN"
        txt = re.sub(r"&#x0*?2967;", "⥧", txt)
        txt = re.sub(r"&#0*?10599;", "⥧", txt)
        txt = re.sub(r"&ldrdhar;", "⥧", txt)

        # "U+02968", "RIGHTWARDS HARPOON WITH BARB UP ABOVE LEFTWARDS HARPOON WITH BARB UP"
        txt = re.sub(r"&#x0*?2968;", "⥨", txt)
        txt = re.sub(r"&#0*?10600;", "⥨", txt)
        txt = re.sub(r"&ruluhar;", "⥨", txt)

        # "U+02969", "RIGHTWARDS HARPOON WITH BARB DOWN ABOVE LEFTWARDS HARPOON WITH BARB DOWN"
        txt = re.sub(r"&#x0*?2969;", "⥩", txt)
        txt = re.sub(r"&#0*?10601;", "⥩", txt)
        txt = re.sub(r"&rdldhar;", "⥩", txt)

        # "U+0296A", "LEFTWARDS HARPOON WITH BARB UP ABOVE LONG DASH"
        txt = re.sub(r"&#x0*?296A;", "⥪", txt)
        txt = re.sub(r"&#0*?10602;", "⥪", txt)
        txt = re.sub(r"&lharul;", "⥪", txt)

        # "U+0296B", "LEFTWARDS HARPOON WITH BARB DOWN BELOW LONG DASH"
        txt = re.sub(r"&#x0*?296B;", "⥫", txt)
        txt = re.sub(r"&#0*?10603;", "⥫", txt)
        txt = re.sub(r"&llhard;", "⥫", txt)

        # "U+0296C", "RIGHTWARDS HARPOON WITH BARB UP ABOVE LONG DASH"
        txt = re.sub(r"&#x0*?296C;", "⥬", txt)
        txt = re.sub(r"&#0*?10604;", "⥬", txt)
        txt = re.sub(r"&rharul;", "⥬", txt)

        # "U+0296D", "RIGHTWARDS HARPOON WITH BARB DOWN BELOW LONG DASH"
        txt = re.sub(r"&#x0*?296D;", "⥭", txt)
        txt = re.sub(r"&#0*?10605;", "⥭", txt)
        txt = re.sub(r"&lrhard;", "⥭", txt)

        # "U+0296E", "UPWARDS HARPOON WITH BARB LEFT BESIDE DOWNWARDS HARPOON WITH BARB RIGHT"
        txt = re.sub(r"&#x0*?296E;", "⥮", txt)
        txt = re.sub(r"&#0*?10606;", "⥮", txt)
        txt = re.sub(r"&udhar;", "⥮", txt)
        txt = re.sub(r"&UpEquilibrium;", "⥮", txt)

        # "U+0296F", "DOWNWARDS HARPOON WITH BARB LEFT BESIDE UPWARDS HARPOON WITH BARB RIGHT"
        txt = re.sub(r"&#x0*?296F;", "⥯", txt)
        txt = re.sub(r"&#0*?10607;", "⥯", txt)
        txt = re.sub(r"&duhar;", "⥯", txt)
        txt = re.sub(r"&ReverseUpEquilibrium;", "⥯", txt)

        # "U+02970", "RIGHT DOUBLE ARROW WITH ROUNDED HEAD"
        txt = re.sub(r"&#x0*?2970;", "⥰", txt)
        txt = re.sub(r"&#0*?10608;", "⥰", txt)
        txt = re.sub(r"&RoundImplies;", "⥰", txt)

        # "U+02971", "EQUALS SIGN ABOVE RIGHTWARDS ARROW"
        txt = re.sub(r"&#x0*?2971;", "⥱", txt)
        txt = re.sub(r"&#0*?10609;", "⥱", txt)
        txt = re.sub(r"&erarr;", "⥱", txt)

        # "U+02972", "TILDE OPERATOR ABOVE RIGHTWARDS ARROW"
        txt = re.sub(r"&#x0*?2972;", "⥲", txt)
        txt = re.sub(r"&#0*?10610;", "⥲", txt)
        txt = re.sub(r"&simrarr;", "⥲", txt)

        # "U+02973", "LEFTWARDS ARROW ABOVE TILDE OPERATOR"
        txt = re.sub(r"&#x0*?2973;", "⥳", txt)
        txt = re.sub(r"&#0*?10611;", "⥳", txt)
        txt = re.sub(r"&larrsim;", "⥳", txt)

        # "U+02974", "RIGHTWARDS ARROW ABOVE TILDE OPERATOR"
        txt = re.sub(r"&#x0*?2974;", "⥴", txt)
        txt = re.sub(r"&#0*?10612;", "⥴", txt)
        txt = re.sub(r"&rarrsim;", "⥴", txt)

        # "U+02975", "RIGHTWARDS ARROW ABOVE ALMOST EQUAL TO"
        txt = re.sub(r"&#x0*?2975;", "⥵", txt)
        txt = re.sub(r"&#0*?10613;", "⥵", txt)
        txt = re.sub(r"&rarrap;", "⥵", txt)

        # "U+02976", "LESS-THAN ABOVE LEFTWARDS ARROW"
        txt = re.sub(r"&#x0*?2976;", "⥶", txt)
        txt = re.sub(r"&#0*?10614;", "⥶", txt)
        txt = re.sub(r"&ltlarr;", "⥶", txt)

        # "U+02978", "GREATER-THAN ABOVE RIGHTWARDS ARROW"
        txt = re.sub(r"&#x0*?2978;", "⥸", txt)
        txt = re.sub(r"&#0*?10616;", "⥸", txt)
        txt = re.sub(r"&gtrarr;", "⥸", txt)

        # "U+02979", "SUBSET ABOVE RIGHTWARDS ARROW"
        txt = re.sub(r"&#x0*?2979;", "⥹", txt)
        txt = re.sub(r"&#0*?10617;", "⥹", txt)
        txt = re.sub(r"&subrarr;", "⥹", txt)

        # "U+0297B", "SUPERSET ABOVE LEFTWARDS ARROW"
        txt = re.sub(r"&#x0*?297B;", "⥻", txt)
        txt = re.sub(r"&#0*?10619;", "⥻", txt)
        txt = re.sub(r"&suplarr;", "⥻", txt)

        # "U+0297C", "LEFT FISH TAIL"
        txt = re.sub(r"&#x0*?297C;", "⥼", txt)
        txt = re.sub(r"&#0*?10620;", "⥼", txt)
        txt = re.sub(r"&lfisht;", "⥼", txt)

        # "U+0297D", "RIGHT FISH TAIL"
        txt = re.sub(r"&#x0*?297D;", "⥽", txt)
        txt = re.sub(r"&#0*?10621;", "⥽", txt)
        txt = re.sub(r"&rfisht;", "⥽", txt)

        # "U+0297E", "UP FISH TAIL"
        txt = re.sub(r"&#x0*?297E;", "⥾", txt)
        txt = re.sub(r"&#0*?10622;", "⥾", txt)
        txt = re.sub(r"&ufisht;", "⥾", txt)

        # "U+0297F", "DOWN FISH TAIL"
        txt = re.sub(r"&#x0*?297F;", "⥿", txt)
        txt = re.sub(r"&#0*?10623;", "⥿", txt)
        txt = re.sub(r"&dfisht;", "⥿", txt)

        # "U+02985", "LEFT WHITE PARENTHESIS"
        txt = re.sub(r"&#x0*?2985;", "⦅", txt)
        txt = re.sub(r"&#0*?10629;", "⦅", txt)
        txt = re.sub(r"&lopar;", "⦅", txt)

        # "U+02986", "RIGHT WHITE PARENTHESIS"
        txt = re.sub(r"&#x0*?2986;", "⦆", txt)
        txt = re.sub(r"&#0*?10630;", "⦆", txt)
        txt = re.sub(r"&ropar;", "⦆", txt)

        # "U+0298B", "LEFT SQUARE BRACKET WITH UNDERBAR"
        txt = re.sub(r"&#x0*?298B;", "⦋", txt)
        txt = re.sub(r"&#0*?10635;", "⦋", txt)
        txt = re.sub(r"&lbrke;", "⦋", txt)

        # "U+0298C", "RIGHT SQUARE BRACKET WITH UNDERBAR"
        txt = re.sub(r"&#x0*?298C;", "⦌", txt)
        txt = re.sub(r"&#0*?10636;", "⦌", txt)
        txt = re.sub(r"&rbrke;", "⦌", txt)

        # "U+0298D", "LEFT SQUARE BRACKET WITH TICK IN TOP CORNER"
        txt = re.sub(r"&#x0*?298D;", "⦍", txt)
        txt = re.sub(r"&#0*?10637;", "⦍", txt)
        txt = re.sub(r"&lbrkslu;", "⦍", txt)

        # "U+0298E", "RIGHT SQUARE BRACKET WITH TICK IN BOTTOM CORNER"
        txt = re.sub(r"&#x0*?298E;", "⦎", txt)
        txt = re.sub(r"&#0*?10638;", "⦎", txt)
        txt = re.sub(r"&rbrksld;", "⦎", txt)

        # "U+0298F", "LEFT SQUARE BRACKET WITH TICK IN BOTTOM CORNER"
        txt = re.sub(r"&#x0*?298F;", "⦏", txt)
        txt = re.sub(r"&#0*?10639;", "⦏", txt)
        txt = re.sub(r"&lbrksld;", "⦏", txt)

        # "U+02990", "RIGHT SQUARE BRACKET WITH TICK IN TOP CORNER"
        txt = re.sub(r"&#x0*?2990;", "⦐", txt)
        txt = re.sub(r"&#0*?10640;", "⦐", txt)
        txt = re.sub(r"&rbrkslu;", "⦐", txt)

        # "U+02991", "LEFT ANGLE BRACKET WITH DOT"
        txt = re.sub(r"&#x0*?2991;", "⦑", txt)
        txt = re.sub(r"&#0*?10641;", "⦑", txt)
        txt = re.sub(r"&langd;", "⦑", txt)

        # "U+02992", "RIGHT ANGLE BRACKET WITH DOT"
        txt = re.sub(r"&#x0*?2992;", "⦒", txt)
        txt = re.sub(r"&#0*?10642;", "⦒", txt)
        txt = re.sub(r"&rangd;", "⦒", txt)

        # "U+02993", "LEFT ARC LESS-THAN BRACKET"
        txt = re.sub(r"&#x0*?2993;", "⦓", txt)
        txt = re.sub(r"&#0*?10643;", "⦓", txt)
        txt = re.sub(r"&lparlt;", "⦓", txt)

        # "U+02994", "RIGHT ARC GREATER-THAN BRACKET"
        txt = re.sub(r"&#x0*?2994;", "⦔", txt)
        txt = re.sub(r"&#0*?10644;", "⦔", txt)
        txt = re.sub(r"&rpargt;", "⦔", txt)

        # "U+02995", "DOUBLE LEFT ARC GREATER-THAN BRACKET"
        txt = re.sub(r"&#x0*?2995;", "⦕", txt)
        txt = re.sub(r"&#0*?10645;", "⦕", txt)
        txt = re.sub(r"&gtlPar;", "⦕", txt)

        # "U+02996", "DOUBLE RIGHT ARC LESS-THAN BRACKET"
        txt = re.sub(r"&#x0*?2996;", "⦖", txt)
        txt = re.sub(r"&#0*?10646;", "⦖", txt)
        txt = re.sub(r"&ltrPar;", "⦖", txt)

        # "U+0299A", "VERTICAL ZIGZAG LINE"
        txt = re.sub(r"&#x0*?299A;", "⦚", txt)
        txt = re.sub(r"&#0*?10650;", "⦚", txt)
        txt = re.sub(r"&vzigzag;", "⦚", txt)

        # "U+0299C", "RIGHT ANGLE VARIANT WITH SQUARE"
        txt = re.sub(r"&#x0*?299C;", "⦜", txt)
        txt = re.sub(r"&#0*?10652;", "⦜", txt)
        txt = re.sub(r"&vangrt;", "⦜", txt)

        # "U+0299D", "MEASURED RIGHT ANGLE WITH DOT"
        txt = re.sub(r"&#x0*?299D;", "⦝", txt)
        txt = re.sub(r"&#0*?10653;", "⦝", txt)
        txt = re.sub(r"&angrtvbd;", "⦝", txt)

        # "U+029A4", "ANGLE WITH UNDERBAR"
        txt = re.sub(r"&#x0*?29A4;", "⦤", txt)
        txt = re.sub(r"&#0*?10660;", "⦤", txt)
        txt = re.sub(r"&ange;", "⦤", txt)

        # "U+029A5", "REVERSED ANGLE WITH UNDERBAR"
        txt = re.sub(r"&#x0*?29A5;", "⦥", txt)
        txt = re.sub(r"&#0*?10661;", "⦥", txt)
        txt = re.sub(r"&range;", "⦥", txt)

        # "U+029A6", "OBLIQUE ANGLE OPENING UP"
        txt = re.sub(r"&#x0*?29A6;", "⦦", txt)
        txt = re.sub(r"&#0*?10662;", "⦦", txt)
        txt = re.sub(r"&dwangle;", "⦦", txt)

        # "U+029A7", "OBLIQUE ANGLE OPENING DOWN"
        txt = re.sub(r"&#x0*?29A7;", "⦧", txt)
        txt = re.sub(r"&#0*?10663;", "⦧", txt)
        txt = re.sub(r"&uwangle;", "⦧", txt)

        # "U+029A8", "MEASURED ANGLE WITH OPEN ARM ENDING IN ARROW POINTING UP AND RIGHT"
        txt = re.sub(r"&#x0*?29A8;", "⦨", txt)
        txt = re.sub(r"&#0*?10664;", "⦨", txt)
        txt = re.sub(r"&angmsdaa;", "⦨", txt)

        # "U+029A9", "MEASURED ANGLE WITH OPEN ARM ENDING IN ARROW POINTING UP AND LEFT"
        txt = re.sub(r"&#x0*?29A9;", "⦩", txt)
        txt = re.sub(r"&#0*?10665;", "⦩", txt)
        txt = re.sub(r"&angmsdab;", "⦩", txt)

        # "U+029AA", "MEASURED ANGLE WITH OPEN ARM ENDING IN ARROW POINTING DOWN AND RIGHT"
        txt = re.sub(r"&#x0*?29AA;", "⦪", txt)
        txt = re.sub(r"&#0*?10666;", "⦪", txt)
        txt = re.sub(r"&angmsdac;", "⦪", txt)

        # "U+029AB", "MEASURED ANGLE WITH OPEN ARM ENDING IN ARROW POINTING DOWN AND LEFT"
        txt = re.sub(r"&#x0*?29AB;", "⦫", txt)
        txt = re.sub(r"&#0*?10667;", "⦫", txt)
        txt = re.sub(r"&angmsdad;", "⦫", txt)

        # "U+029AC", "MEASURED ANGLE WITH OPEN ARM ENDING IN ARROW POINTING RIGHT AND UP"
        txt = re.sub(r"&#x0*?29AC;", "⦬", txt)
        txt = re.sub(r"&#0*?10668;", "⦬", txt)
        txt = re.sub(r"&angmsdae;", "⦬", txt)

        # "U+029AD", "MEASURED ANGLE WITH OPEN ARM ENDING IN ARROW POINTING LEFT AND UP"
        txt = re.sub(r"&#x0*?29AD;", "⦭", txt)
        txt = re.sub(r"&#0*?10669;", "⦭", txt)
        txt = re.sub(r"&angmsdaf;", "⦭", txt)

        # "U+029AE", "MEASURED ANGLE WITH OPEN ARM ENDING IN ARROW POINTING RIGHT AND DOWN"
        txt = re.sub(r"&#x0*?29AE;", "⦮", txt)
        txt = re.sub(r"&#0*?10670;", "⦮", txt)
        txt = re.sub(r"&angmsdag;", "⦮", txt)

        # "U+029AF", "MEASURED ANGLE WITH OPEN ARM ENDING IN ARROW POINTING LEFT AND DOWN"
        txt = re.sub(r"&#x0*?29AF;", "⦯", txt)
        txt = re.sub(r"&#0*?10671;", "⦯", txt)
        txt = re.sub(r"&angmsdah;", "⦯", txt)

        # "U+029B0", "REVERSED EMPTY SET"
        txt = re.sub(r"&#x0*?29B0;", "⦰", txt)
        txt = re.sub(r"&#0*?10672;", "⦰", txt)
        txt = re.sub(r"&bemptyv;", "⦰", txt)

        # "U+029B1", "EMPTY SET WITH OVERBAR"
        txt = re.sub(r"&#x0*?29B1;", "⦱", txt)
        txt = re.sub(r"&#0*?10673;", "⦱", txt)
        txt = re.sub(r"&demptyv;", "⦱", txt)

        # "U+029B2", "EMPTY SET WITH SMALL CIRCLE ABOVE"
        txt = re.sub(r"&#x0*?29B2;", "⦲", txt)
        txt = re.sub(r"&#0*?10674;", "⦲", txt)
        txt = re.sub(r"&cemptyv;", "⦲", txt)

        # "U+029B3", "EMPTY SET WITH RIGHT ARROW ABOVE"
        txt = re.sub(r"&#x0*?29B3;", "⦳", txt)
        txt = re.sub(r"&#0*?10675;", "⦳", txt)
        txt = re.sub(r"&raemptyv;", "⦳", txt)

        # "U+029B4", "EMPTY SET WITH LEFT ARROW ABOVE"
        txt = re.sub(r"&#x0*?29B4;", "⦴", txt)
        txt = re.sub(r"&#0*?10676;", "⦴", txt)
        txt = re.sub(r"&laemptyv;", "⦴", txt)

        # "U+029B5", "CIRCLE WITH HORIZONTAL BAR"
        txt = re.sub(r"&#x0*?29B5;", "⦵", txt)
        txt = re.sub(r"&#0*?10677;", "⦵", txt)
        txt = re.sub(r"&ohbar;", "⦵", txt)

        # "U+029B6", "CIRCLED VERTICAL BAR"
        txt = re.sub(r"&#x0*?29B6;", "⦶", txt)
        txt = re.sub(r"&#0*?10678;", "⦶", txt)
        txt = re.sub(r"&omid;", "⦶", txt)

        # "U+029B7", "CIRCLED PARALLEL"
        txt = re.sub(r"&#x0*?29B7;", "⦷", txt)
        txt = re.sub(r"&#0*?10679;", "⦷", txt)
        txt = re.sub(r"&opar;", "⦷", txt)

        # "U+029B9", "CIRCLED PERPENDICULAR"
        txt = re.sub(r"&#x0*?29B9;", "⦹", txt)
        txt = re.sub(r"&#0*?10681;", "⦹", txt)
        txt = re.sub(r"&operp;", "⦹", txt)

        # "U+029BB", "CIRCLE WITH SUPERIMPOSED X"
        txt = re.sub(r"&#x0*?29BB;", "⦻", txt)
        txt = re.sub(r"&#0*?10683;", "⦻", txt)
        txt = re.sub(r"&olcross;", "⦻", txt)

        # "U+029BC", "CIRCLED ANTICLOCKWISE-ROTATED DIVISION SIGN"
        txt = re.sub(r"&#x0*?29BC;", "⦼", txt)
        txt = re.sub(r"&#0*?10684;", "⦼", txt)
        txt = re.sub(r"&odsold;", "⦼", txt)

        # "U+029BE", "CIRCLED WHITE BULLET"
        txt = re.sub(r"&#x0*?29BE;", "⦾", txt)
        txt = re.sub(r"&#0*?10686;", "⦾", txt)
        txt = re.sub(r"&olcir;", "⦾", txt)

        # "U+029BF", "CIRCLED BULLET"
        txt = re.sub(r"&#x0*?29BF;", "⦿", txt)
        txt = re.sub(r"&#0*?10687;", "⦿", txt)
        txt = re.sub(r"&ofcir;", "⦿", txt)

        # "U+029C0", "CIRCLED LESS-THAN"
        txt = re.sub(r"&#x0*?29C0;", "⧀", txt)
        txt = re.sub(r"&#0*?10688;", "⧀", txt)
        txt = re.sub(r"&olt;", "⧀", txt)

        # "U+029C1", "CIRCLED GREATER-THAN"
        txt = re.sub(r"&#x0*?29C1;", "⧁", txt)
        txt = re.sub(r"&#0*?10689;", "⧁", txt)
        txt = re.sub(r"&ogt;", "⧁", txt)

        # "U+029C2", "CIRCLE WITH SMALL CIRCLE TO THE RIGHT"
        txt = re.sub(r"&#x0*?29C2;", "⧂", txt)
        txt = re.sub(r"&#0*?10690;", "⧂", txt)
        txt = re.sub(r"&cirscir;", "⧂", txt)

        # "U+029C3", "CIRCLE WITH TWO HORIZONTAL STROKES TO THE RIGHT"
        txt = re.sub(r"&#x0*?29C3;", "⧃", txt)
        txt = re.sub(r"&#0*?10691;", "⧃", txt)
        txt = re.sub(r"&cirE;", "⧃", txt)

        # "U+029C4", "SQUARED RISING DIAGONAL SLASH"
        txt = re.sub(r"&#x0*?29C4;", "⧄", txt)
        txt = re.sub(r"&#0*?10692;", "⧄", txt)
        txt = re.sub(r"&solb;", "⧄", txt)

        # "U+029C5", "SQUARED FALLING DIAGONAL SLASH"
        txt = re.sub(r"&#x0*?29C5;", "⧅", txt)
        txt = re.sub(r"&#0*?10693;", "⧅", txt)
        txt = re.sub(r"&bsolb;", "⧅", txt)

        # "U+029C9", "TWO JOINED SQUARES"
        txt = re.sub(r"&#x0*?29C9;", "⧉", txt)
        txt = re.sub(r"&#0*?10697;", "⧉", txt)
        txt = re.sub(r"&boxbox;", "⧉", txt)

        # "U+029CD", "TRIANGLE WITH SERIFS AT BOTTOM"
        txt = re.sub(r"&#x0*?29CD;", "⧍", txt)
        txt = re.sub(r"&#0*?10701;", "⧍", txt)
        txt = re.sub(r"&trisb;", "⧍", txt)

        # "U+029CE", "RIGHT TRIANGLE ABOVE LEFT TRIANGLE"
        txt = re.sub(r"&#x0*?29CE;", "⧎", txt)
        txt = re.sub(r"&#0*?10702;", "⧎", txt)
        txt = re.sub(r"&rtriltri;", "⧎", txt)

        # "U+029CF", "LEFT TRIANGLE BESIDE VERTICAL BAR"
        txt = re.sub(r"&#x0*?29CF;", "⧏", txt)
        txt = re.sub(r"&#0*?10703;", "⧏", txt)
        txt = re.sub(r"&LeftTriangleBar;", "⧏", txt)

        # "U+029D0", "VERTICAL BAR BESIDE RIGHT TRIANGLE"
        txt = re.sub(r"&#x0*?29D0;", "⧐", txt)
        txt = re.sub(r"&#0*?10704;", "⧐", txt)
        txt = re.sub(r"&RightTriangleBar;", "⧐", txt)

        # "U+029DA", "LEFT DOUBLE WIGGLY FENCE"
        txt = re.sub(r"&#x0*?29DA;", "⧚", txt)
        txt = re.sub(r"&#0*?10714;", "⧚", txt)
        txt = re.sub(r"&race;", "⧚", txt)

        # "U+029DC", "INCOMPLETE INFINITY"
        txt = re.sub(r"&#x0*?29DC;", "⧜", txt)
        txt = re.sub(r"&#0*?10716;", "⧜", txt)
        txt = re.sub(r"&iinfin;", "⧜", txt)

        # "U+029DD", "TIE OVER INFINITY"
        txt = re.sub(r"&#x0*?29DD;", "⧝", txt)
        txt = re.sub(r"&#0*?10717;", "⧝", txt)
        txt = re.sub(r"&infintie;", "⧝", txt)

        # "U+029DE", "INFINITY NEGATED WITH VERTICAL BAR"
        txt = re.sub(r"&#x0*?29DE;", "⧞", txt)
        txt = re.sub(r"&#0*?10718;", "⧞", txt)
        txt = re.sub(r"&nvinfin;", "⧞", txt)

        # "U+029E3", "EQUALS SIGN AND SLANTED PARALLEL"
        txt = re.sub(r"&#x0*?29E3;", "⧣", txt)
        txt = re.sub(r"&#0*?10723;", "⧣", txt)
        txt = re.sub(r"&eparsl;", "⧣", txt)

        # "U+029E4", "EQUALS SIGN AND SLANTED PARALLEL WITH TILDE ABOVE"
        txt = re.sub(r"&#x0*?29E4;", "⧤", txt)
        txt = re.sub(r"&#0*?10724;", "⧤", txt)
        txt = re.sub(r"&smeparsl;", "⧤", txt)

        # "U+029E5", "IDENTICAL TO AND SLANTED PARALLEL"
        txt = re.sub(r"&#x0*?29E5;", "⧥", txt)
        txt = re.sub(r"&#0*?10725;", "⧥", txt)
        txt = re.sub(r"&eqvparsl;", "⧥", txt)

        # "U+029EB", "BLACK LOZENGE"
        txt = re.sub(r"&#x0*?29EB;", "⧫", txt)
        txt = re.sub(r"&#0*?10731;", "⧫", txt)
        txt = re.sub(r"&lozf;", "⧫", txt)
        txt = re.sub(r"&blacklozenge;", "⧫", txt)

        # "U+029F4", "RULE-DELAYED"
        txt = re.sub(r"&#x0*?29F4;", "⧴", txt)
        txt = re.sub(r"&#0*?10740;", "⧴", txt)
        txt = re.sub(r"&RuleDelayed;", "⧴", txt)

        # "U+029F6", "SOLIDUS WITH OVERBAR"
        txt = re.sub(r"&#x0*?29F6;", "⧶", txt)
        txt = re.sub(r"&#0*?10742;", "⧶", txt)
        txt = re.sub(r"&dsol;", "⧶", txt)

        # "U+02A00", "N-ARY CIRCLED DOT OPERATOR"
        txt = re.sub(r"&#x0*?2A00;", "⨀", txt)
        txt = re.sub(r"&#0*?10752;", "⨀", txt)
        txt = re.sub(r"&xodot;", "⨀", txt)
        txt = re.sub(r"&bigodot;", "⨀", txt)

        # "U+02A01", "N-ARY CIRCLED PLUS OPERATOR"
        txt = re.sub(r"&#x0*?2A01;", "⨁", txt)
        txt = re.sub(r"&#0*?10753;", "⨁", txt)
        txt = re.sub(r"&xoplus;", "⨁", txt)
        txt = re.sub(r"&bigoplus;", "⨁", txt)

        # "U+02A02", "N-ARY CIRCLED TIMES OPERATOR"
        txt = re.sub(r"&#x0*?2A02;", "⨂", txt)
        txt = re.sub(r"&#0*?10754;", "⨂", txt)
        txt = re.sub(r"&xotime;", "⨂", txt)
        txt = re.sub(r"&bigotimes;", "⨂", txt)

        # "U+02A04", "N-ARY UNION OPERATOR WITH PLUS"
        txt = re.sub(r"&#x0*?2A04;", "⨄", txt)
        txt = re.sub(r"&#0*?10756;", "⨄", txt)
        txt = re.sub(r"&xuplus;", "⨄", txt)
        txt = re.sub(r"&biguplus;", "⨄", txt)

        # "U+02A06", "N-ARY SQUARE UNION OPERATOR"
        txt = re.sub(r"&#x0*?2A06;", "⨆", txt)
        txt = re.sub(r"&#0*?10758;", "⨆", txt)
        txt = re.sub(r"&xsqcup;", "⨆", txt)
        txt = re.sub(r"&bigsqcup;", "⨆", txt)

        # "U+02A0C", "QUADRUPLE INTEGRAL OPERATOR"
        txt = re.sub(r"&#x0*?2A0C;", "⨌", txt)
        txt = re.sub(r"&#0*?10764;", "⨌", txt)
        txt = re.sub(r"&qint;", "⨌", txt)
        txt = re.sub(r"&iiiint;", "⨌", txt)

        # "U+02A0D", "FINITE PART INTEGRAL"
        txt = re.sub(r"&#x0*?2A0D;", "⨍", txt)
        txt = re.sub(r"&#0*?10765;", "⨍", txt)
        txt = re.sub(r"&fpartint;", "⨍", txt)

        # "U+02A10", "CIRCULATION FUNCTION"
        txt = re.sub(r"&#x0*?2A10;", "⨐", txt)
        txt = re.sub(r"&#0*?10768;", "⨐", txt)
        txt = re.sub(r"&cirfnint;", "⨐", txt)

        # "U+02A11", "ANTICLOCKWISE INTEGRATION"
        txt = re.sub(r"&#x0*?2A11;", "⨑", txt)
        txt = re.sub(r"&#0*?10769;", "⨑", txt)
        txt = re.sub(r"&awint;", "⨑", txt)

        # "U+02A12", "LINE INTEGRATION WITH RECTANGULAR PATH AROUND POLE"
        txt = re.sub(r"&#x0*?2A12;", "⨒", txt)
        txt = re.sub(r"&#0*?10770;", "⨒", txt)
        txt = re.sub(r"&rppolint;", "⨒", txt)

        # "U+02A13", "LINE INTEGRATION WITH SEMICIRCULAR PATH AROUND POLE"
        txt = re.sub(r"&#x0*?2A13;", "⨓", txt)
        txt = re.sub(r"&#0*?10771;", "⨓", txt)
        txt = re.sub(r"&scpolint;", "⨓", txt)

        # "U+02A14", "LINE INTEGRATION NOT INCLUDING THE POLE"
        txt = re.sub(r"&#x0*?2A14;", "⨔", txt)
        txt = re.sub(r"&#0*?10772;", "⨔", txt)
        txt = re.sub(r"&npolint;", "⨔", txt)

        # "U+02A15", "INTEGRAL AROUND A POINT OPERATOR"
        txt = re.sub(r"&#x0*?2A15;", "⨕", txt)
        txt = re.sub(r"&#0*?10773;", "⨕", txt)
        txt = re.sub(r"&pointint;", "⨕", txt)

        # "U+02A16", "QUATERNION INTEGRAL OPERATOR"
        txt = re.sub(r"&#x0*?2A16;", "⨖", txt)
        txt = re.sub(r"&#0*?10774;", "⨖", txt)
        txt = re.sub(r"&quatint;", "⨖", txt)

        # "U+02A17", "INTEGRAL WITH LEFTWARDS ARROW WITH HOOK"
        txt = re.sub(r"&#x0*?2A17;", "⨗", txt)
        txt = re.sub(r"&#0*?10775;", "⨗", txt)
        txt = re.sub(r"&intlarhk;", "⨗", txt)

        # "U+02A22", "PLUS SIGN WITH SMALL CIRCLE ABOVE"
        txt = re.sub(r"&#x0*?2A22;", "⨢", txt)
        txt = re.sub(r"&#0*?10786;", "⨢", txt)
        txt = re.sub(r"&pluscir;", "⨢", txt)

        # "U+02A23", "PLUS SIGN WITH CIRCUMFLEX ACCENT ABOVE"
        txt = re.sub(r"&#x0*?2A23;", "⨣", txt)
        txt = re.sub(r"&#0*?10787;", "⨣", txt)
        txt = re.sub(r"&plusacir;", "⨣", txt)

        # "U+02A24", "PLUS SIGN WITH TILDE ABOVE"
        txt = re.sub(r"&#x0*?2A24;", "⨤", txt)
        txt = re.sub(r"&#0*?10788;", "⨤", txt)
        txt = re.sub(r"&simplus;", "⨤", txt)

        # "U+02A25", "PLUS SIGN WITH DOT BELOW"
        txt = re.sub(r"&#x0*?2A25;", "⨥", txt)
        txt = re.sub(r"&#0*?10789;", "⨥", txt)
        txt = re.sub(r"&plusdu;", "⨥", txt)

        # "U+02A26", "PLUS SIGN WITH TILDE BELOW"
        txt = re.sub(r"&#x0*?2A26;", "⨦", txt)
        txt = re.sub(r"&#0*?10790;", "⨦", txt)
        txt = re.sub(r"&plussim;", "⨦", txt)

        # "U+02A27", "PLUS SIGN WITH SUBSCRIPT TWO"
        txt = re.sub(r"&#x0*?2A27;", "⨧", txt)
        txt = re.sub(r"&#0*?10791;", "⨧", txt)
        txt = re.sub(r"&plustwo;", "⨧", txt)

        # "U+02A29", "MINUS SIGN WITH COMMA ABOVE"
        txt = re.sub(r"&#x0*?2A29;", "⨩", txt)
        txt = re.sub(r"&#0*?10793;", "⨩", txt)
        txt = re.sub(r"&mcomma;", "⨩", txt)

        # "U+02A2A", "MINUS SIGN WITH DOT BELOW"
        txt = re.sub(r"&#x0*?2A2A;", "⨪", txt)
        txt = re.sub(r"&#0*?10794;", "⨪", txt)
        txt = re.sub(r"&minusdu;", "⨪", txt)

        # "U+02A2D", "PLUS SIGN IN LEFT HALF CIRCLE"
        txt = re.sub(r"&#x0*?2A2D;", "⨭", txt)
        txt = re.sub(r"&#0*?10797;", "⨭", txt)
        txt = re.sub(r"&loplus;", "⨭", txt)

        # "U+02A2E", "PLUS SIGN IN RIGHT HALF CIRCLE"
        txt = re.sub(r"&#x0*?2A2E;", "⨮", txt)
        txt = re.sub(r"&#0*?10798;", "⨮", txt)
        txt = re.sub(r"&roplus;", "⨮", txt)

        # "U+02A2F", "VECTOR OR CROSS PRODUCT"
        txt = re.sub(r"&#x0*?2A2F;", "⨯", txt)
        txt = re.sub(r"&#0*?10799;", "⨯", txt)
        txt = re.sub(r"&Cross;", "⨯", txt)

        # "U+02A30", "MULTIPLICATION SIGN WITH DOT ABOVE"
        txt = re.sub(r"&#x0*?2A30;", "⨰", txt)
        txt = re.sub(r"&#0*?10800;", "⨰", txt)
        txt = re.sub(r"&timesd;", "⨰", txt)

        # "U+02A31", "MULTIPLICATION SIGN WITH UNDERBAR"
        txt = re.sub(r"&#x0*?2A31;", "⨱", txt)
        txt = re.sub(r"&#0*?10801;", "⨱", txt)
        txt = re.sub(r"&timesbar;", "⨱", txt)

        # "U+02A33", "SMASH PRODUCT"
        txt = re.sub(r"&#x0*?2A33;", "⨳", txt)
        txt = re.sub(r"&#0*?10803;", "⨳", txt)
        txt = re.sub(r"&smashp;", "⨳", txt)

        # "U+02A34", "MULTIPLICATION SIGN IN LEFT HALF CIRCLE"
        txt = re.sub(r"&#x0*?2A34;", "⨴", txt)
        txt = re.sub(r"&#0*?10804;", "⨴", txt)
        txt = re.sub(r"&lotimes;", "⨴", txt)

        # "U+02A35", "MULTIPLICATION SIGN IN RIGHT HALF CIRCLE"
        txt = re.sub(r"&#x0*?2A35;", "⨵", txt)
        txt = re.sub(r"&#0*?10805;", "⨵", txt)
        txt = re.sub(r"&rotimes;", "⨵", txt)

        # "U+02A36", "CIRCLED MULTIPLICATION SIGN WITH CIRCUMFLEX ACCENT"
        txt = re.sub(r"&#x0*?2A36;", "⨶", txt)
        txt = re.sub(r"&#0*?10806;", "⨶", txt)
        txt = re.sub(r"&otimesas;", "⨶", txt)

        # "U+02A37", "MULTIPLICATION SIGN IN DOUBLE CIRCLE"
        txt = re.sub(r"&#x0*?2A37;", "⨷", txt)
        txt = re.sub(r"&#0*?10807;", "⨷", txt)
        txt = re.sub(r"&Otimes;", "⨷", txt)

        # "U+02A38", "CIRCLED DIVISION SIGN"
        txt = re.sub(r"&#x0*?2A38;", "⨸", txt)
        txt = re.sub(r"&#0*?10808;", "⨸", txt)
        txt = re.sub(r"&odiv;", "⨸", txt)

        # "U+02A39", "PLUS SIGN IN TRIANGLE"
        txt = re.sub(r"&#x0*?2A39;", "⨹", txt)
        txt = re.sub(r"&#0*?10809;", "⨹", txt)
        txt = re.sub(r"&triplus;", "⨹", txt)

        # "U+02A3A", "MINUS SIGN IN TRIANGLE"
        txt = re.sub(r"&#x0*?2A3A;", "⨺", txt)
        txt = re.sub(r"&#0*?10810;", "⨺", txt)
        txt = re.sub(r"&triminus;", "⨺", txt)

        # "U+02A3B", "MULTIPLICATION SIGN IN TRIANGLE"
        txt = re.sub(r"&#x0*?2A3B;", "⨻", txt)
        txt = re.sub(r"&#0*?10811;", "⨻", txt)
        txt = re.sub(r"&tritime;", "⨻", txt)

        # "U+02A3C", "INTERIOR PRODUCT"
        txt = re.sub(r"&#x0*?2A3C;", "⨼", txt)
        txt = re.sub(r"&#0*?10812;", "⨼", txt)
        txt = re.sub(r"&iprod;", "⨼", txt)
        txt = re.sub(r"&intprod;", "⨼", txt)

        # "U+02A3F", "AMALGAMATION OR COPRODUCT"
        txt = re.sub(r"&#x0*?2A3F;", "⨿", txt)
        txt = re.sub(r"&#0*?10815;", "⨿", txt)
        txt = re.sub(r"&amalg;", "⨿", txt)

        # "U+02A40", "INTERSECTION WITH DOT"
        txt = re.sub(r"&#x0*?2A40;", "⩀", txt)
        txt = re.sub(r"&#0*?10816;", "⩀", txt)
        txt = re.sub(r"&capdot;", "⩀", txt)

        # "U+02A42", "UNION WITH OVERBAR"
        txt = re.sub(r"&#x0*?2A42;", "⩂", txt)
        txt = re.sub(r"&#0*?10818;", "⩂", txt)
        txt = re.sub(r"&ncup;", "⩂", txt)

        # "U+02A43", "INTERSECTION WITH OVERBAR"
        txt = re.sub(r"&#x0*?2A43;", "⩃", txt)
        txt = re.sub(r"&#0*?10819;", "⩃", txt)
        txt = re.sub(r"&ncap;", "⩃", txt)

        # "U+02A44", "INTERSECTION WITH LOGICAL AND"
        txt = re.sub(r"&#x0*?2A44;", "⩄", txt)
        txt = re.sub(r"&#0*?10820;", "⩄", txt)
        txt = re.sub(r"&capand;", "⩄", txt)

        # "U+02A45", "UNION WITH LOGICAL OR"
        txt = re.sub(r"&#x0*?2A45;", "⩅", txt)
        txt = re.sub(r"&#0*?10821;", "⩅", txt)
        txt = re.sub(r"&cupor;", "⩅", txt)

        # "U+02A46", "UNION ABOVE INTERSECTION"
        txt = re.sub(r"&#x0*?2A46;", "⩆", txt)
        txt = re.sub(r"&#0*?10822;", "⩆", txt)
        txt = re.sub(r"&cupcap;", "⩆", txt)

        # "U+02A47", "INTERSECTION ABOVE UNION"
        txt = re.sub(r"&#x0*?2A47;", "⩇", txt)
        txt = re.sub(r"&#0*?10823;", "⩇", txt)
        txt = re.sub(r"&capcup;", "⩇", txt)

        # "U+02A48", "UNION ABOVE BAR ABOVE INTERSECTION"
        txt = re.sub(r"&#x0*?2A48;", "⩈", txt)
        txt = re.sub(r"&#0*?10824;", "⩈", txt)
        txt = re.sub(r"&cupbrcap;", "⩈", txt)

        # "U+02A49", "INTERSECTION ABOVE BAR ABOVE UNION"
        txt = re.sub(r"&#x0*?2A49;", "⩉", txt)
        txt = re.sub(r"&#0*?10825;", "⩉", txt)
        txt = re.sub(r"&capbrcup;", "⩉", txt)

        # "U+02A4A", "UNION BESIDE AND JOINED WITH UNION"
        txt = re.sub(r"&#x0*?2A4A;", "⩊", txt)
        txt = re.sub(r"&#0*?10826;", "⩊", txt)
        txt = re.sub(r"&cupcup;", "⩊", txt)

        # "U+02A4B", "INTERSECTION BESIDE AND JOINED WITH INTERSECTION"
        txt = re.sub(r"&#x0*?2A4B;", "⩋", txt)
        txt = re.sub(r"&#0*?10827;", "⩋", txt)
        txt = re.sub(r"&capcap;", "⩋", txt)

        # "U+02A4C", "CLOSED UNION WITH SERIFS"
        txt = re.sub(r"&#x0*?2A4C;", "⩌", txt)
        txt = re.sub(r"&#0*?10828;", "⩌", txt)
        txt = re.sub(r"&ccups;", "⩌", txt)

        # "U+02A4D", "CLOSED INTERSECTION WITH SERIFS"
        txt = re.sub(r"&#x0*?2A4D;", "⩍", txt)
        txt = re.sub(r"&#0*?10829;", "⩍", txt)
        txt = re.sub(r"&ccaps;", "⩍", txt)

        # "U+02A50", "CLOSED UNION WITH SERIFS AND SMASH PRODUCT"
        txt = re.sub(r"&#x0*?2A50;", "⩐", txt)
        txt = re.sub(r"&#0*?10832;", "⩐", txt)
        txt = re.sub(r"&ccupssm;", "⩐", txt)

        # "U+02A53", "DOUBLE LOGICAL AND"
        txt = re.sub(r"&#x0*?2A53;", "⩓", txt)
        txt = re.sub(r"&#0*?10835;", "⩓", txt)
        txt = re.sub(r"&And;", "⩓", txt)

        # "U+02A54", "DOUBLE LOGICAL OR"
        txt = re.sub(r"&#x0*?2A54;", "⩔", txt)
        txt = re.sub(r"&#0*?10836;", "⩔", txt)
        txt = re.sub(r"&Or;", "⩔", txt)

        # "U+02A55", "TWO INTERSECTING LOGICAL AND"
        txt = re.sub(r"&#x0*?2A55;", "⩕", txt)
        txt = re.sub(r"&#0*?10837;", "⩕", txt)
        txt = re.sub(r"&andand;", "⩕", txt)

        # "U+02A56", "TWO INTERSECTING LOGICAL OR"
        txt = re.sub(r"&#x0*?2A56;", "⩖", txt)
        txt = re.sub(r"&#0*?10838;", "⩖", txt)
        txt = re.sub(r"&oror;", "⩖", txt)

        # "U+02A57", "SLOPING LARGE OR"
        txt = re.sub(r"&#x0*?2A57;", "⩗", txt)
        txt = re.sub(r"&#0*?10839;", "⩗", txt)
        txt = re.sub(r"&orslope;", "⩗", txt)

        # "U+02A58", "SLOPING LARGE AND"
        txt = re.sub(r"&#x0*?2A58;", "⩘", txt)
        txt = re.sub(r"&#0*?10840;", "⩘", txt)
        txt = re.sub(r"&andslope;", "⩘", txt)

        # "U+02A5A", "LOGICAL AND WITH MIDDLE STEM"
        txt = re.sub(r"&#x0*?2A5A;", "⩚", txt)
        txt = re.sub(r"&#0*?10842;", "⩚", txt)
        txt = re.sub(r"&andv;", "⩚", txt)

        # "U+02A5B", "LOGICAL OR WITH MIDDLE STEM"
        txt = re.sub(r"&#x0*?2A5B;", "⩛", txt)
        txt = re.sub(r"&#0*?10843;", "⩛", txt)
        txt = re.sub(r"&orv;", "⩛", txt)

        # "U+02A5C", "LOGICAL AND WITH HORIZONTAL DASH"
        txt = re.sub(r"&#x0*?2A5C;", "⩜", txt)
        txt = re.sub(r"&#0*?10844;", "⩜", txt)
        txt = re.sub(r"&andd;", "⩜", txt)

        # "U+02A5D", "LOGICAL OR WITH HORIZONTAL DASH"
        txt = re.sub(r"&#x0*?2A5D;", "⩝", txt)
        txt = re.sub(r"&#0*?10845;", "⩝", txt)
        txt = re.sub(r"&ord;", "⩝", txt)

        # "U+02A5F", "LOGICAL AND WITH UNDERBAR"
        txt = re.sub(r"&#x0*?2A5F;", "⩟", txt)
        txt = re.sub(r"&#0*?10847;", "⩟", txt)
        txt = re.sub(r"&wedbar;", "⩟", txt)

        # "U+02A66", "EQUALS SIGN WITH DOT BELOW"
        txt = re.sub(r"&#x0*?2A66;", "⩦", txt)
        txt = re.sub(r"&#0*?10854;", "⩦", txt)
        txt = re.sub(r"&sdote;", "⩦", txt)

        # "U+02A6A", "TILDE OPERATOR WITH DOT ABOVE"
        txt = re.sub(r"&#x0*?2A6A;", "⩪", txt)
        txt = re.sub(r"&#0*?10858;", "⩪", txt)
        txt = re.sub(r"&simdot;", "⩪", txt)

        # "U+02A6D", "CONGRUENT WITH DOT ABOVE"
        txt = re.sub(r"&#x0*?2A6D;", "⩭", txt)
        txt = re.sub(r"&#0*?10861;", "⩭", txt)
        txt = re.sub(r"&congdot;", "⩭", txt)

        # "U+02A6E", "EQUALS WITH ASTERISK"
        txt = re.sub(r"&#x0*?2A6E;", "⩮", txt)
        txt = re.sub(r"&#0*?10862;", "⩮", txt)
        txt = re.sub(r"&easter;", "⩮", txt)

        # "U+02A6F", "ALMOST EQUAL TO WITH CIRCUMFLEX ACCENT"
        txt = re.sub(r"&#x0*?2A6F;", "⩯", txt)
        txt = re.sub(r"&#0*?10863;", "⩯", txt)
        txt = re.sub(r"&apacir;", "⩯", txt)

        # "U+02A70", "APPROXIMATELY EQUAL OR EQUAL TO"
        txt = re.sub(r"&#x0*?2A70;", "⩰", txt)
        txt = re.sub(r"&#0*?10864;", "⩰", txt)
        txt = re.sub(r"&apE;", "⩰", txt)

        # "U+02A71", "EQUALS SIGN ABOVE PLUS SIGN"
        txt = re.sub(r"&#x0*?2A71;", "⩱", txt)
        txt = re.sub(r"&#0*?10865;", "⩱", txt)
        txt = re.sub(r"&eplus;", "⩱", txt)

        # "U+02A72", "PLUS SIGN ABOVE EQUALS SIGN"
        txt = re.sub(r"&#x0*?2A72;", "⩲", txt)
        txt = re.sub(r"&#0*?10866;", "⩲", txt)
        txt = re.sub(r"&pluse;", "⩲", txt)

        # "U+02A73", "EQUALS SIGN ABOVE TILDE OPERATOR"
        txt = re.sub(r"&#x0*?2A73;", "⩳", txt)
        txt = re.sub(r"&#0*?10867;", "⩳", txt)
        txt = re.sub(r"&Esim;", "⩳", txt)

        # "U+02A74", "DOUBLE COLON EQUAL"
        txt = re.sub(r"&#x0*?2A74;", "⩴", txt)
        txt = re.sub(r"&#0*?10868;", "⩴", txt)
        txt = re.sub(r"&Colone;", "⩴", txt)

        # "U+02A75", "TWO CONSECUTIVE EQUALS SIGNS"
        txt = re.sub(r"&#x0*?2A75;", "⩵", txt)
        txt = re.sub(r"&#0*?10869;", "⩵", txt)
        txt = re.sub(r"&Equal;", "⩵", txt)

        # "U+02A77", "EQUALS SIGN WITH TWO DOTS ABOVE AND TWO DOTS BELOW"
        txt = re.sub(r"&#x0*?2A77;", "⩷", txt)
        txt = re.sub(r"&#0*?10871;", "⩷", txt)
        txt = re.sub(r"&eDDot;", "⩷", txt)
        txt = re.sub(r"&ddotseq;", "⩷", txt)

        # "U+02A78", "EQUIVALENT WITH FOUR DOTS ABOVE"
        txt = re.sub(r"&#x0*?2A78;", "⩸", txt)
        txt = re.sub(r"&#0*?10872;", "⩸", txt)
        txt = re.sub(r"&equivDD;", "⩸", txt)

        # "U+02A79", "LESS-THAN WITH CIRCLE INSIDE"
        txt = re.sub(r"&#x0*?2A79;", "⩹", txt)
        txt = re.sub(r"&#0*?10873;", "⩹", txt)
        txt = re.sub(r"&ltcir;", "⩹", txt)

        # "U+02A7A", "GREATER-THAN WITH CIRCLE INSIDE"
        txt = re.sub(r"&#x0*?2A7A;", "⩺", txt)
        txt = re.sub(r"&#0*?10874;", "⩺", txt)
        txt = re.sub(r"&gtcir;", "⩺", txt)

        # "U+02A7B", "LESS-THAN WITH QUESTION MARK ABOVE"
        txt = re.sub(r"&#x0*?2A7B;", "⩻", txt)
        txt = re.sub(r"&#0*?10875;", "⩻", txt)
        txt = re.sub(r"&ltquest;", "⩻", txt)

        # "U+02A7C", "GREATER-THAN WITH QUESTION MARK ABOVE"
        txt = re.sub(r"&#x0*?2A7C;", "⩼", txt)
        txt = re.sub(r"&#0*?10876;", "⩼", txt)
        txt = re.sub(r"&gtquest;", "⩼", txt)

        # "U+02A7D", "LESS-THAN OR SLANTED EQUAL TO"
        txt = re.sub(r"&#x0*?2A7D;", "⩽", txt)
        txt = re.sub(r"&#0*?10877;", "⩽", txt)
        txt = re.sub(r"&les;", "⩽", txt)
        txt = re.sub(r"&LessSlantEqual;", "⩽", txt)
        txt = re.sub(r"&leqslant;", "⩽", txt)

        # "U+02A7E", "GREATER-THAN OR SLANTED EQUAL TO"
        txt = re.sub(r"&#x0*?2A7E;", "⩾", txt)
        txt = re.sub(r"&#0*?10878;", "⩾", txt)
        txt = re.sub(r"&ges;", "⩾", txt)
        txt = re.sub(r"&GreaterSlantEqual;", "⩾", txt)
        txt = re.sub(r"&geqslant;", "⩾", txt)

        # "U+02A7F", "LESS-THAN OR SLANTED EQUAL TO WITH DOT INSIDE"
        txt = re.sub(r"&#x0*?2A7F;", "⩿", txt)
        txt = re.sub(r"&#0*?10879;", "⩿", txt)
        txt = re.sub(r"&lesdot;", "⩿", txt)

        # "U+02A80", "GREATER-THAN OR SLANTED EQUAL TO WITH DOT INSIDE"
        txt = re.sub(r"&#x0*?2A80;", "⪀", txt)
        txt = re.sub(r"&#0*?10880;", "⪀", txt)
        txt = re.sub(r"&gesdot;", "⪀", txt)

        # "U+02A81", "LESS-THAN OR SLANTED EQUAL TO WITH DOT ABOVE"
        txt = re.sub(r"&#x0*?2A81;", "⪁", txt)
        txt = re.sub(r"&#0*?10881;", "⪁", txt)
        txt = re.sub(r"&lesdoto;", "⪁", txt)

        # "U+02A82", "GREATER-THAN OR SLANTED EQUAL TO WITH DOT ABOVE"
        txt = re.sub(r"&#x0*?2A82;", "⪂", txt)
        txt = re.sub(r"&#0*?10882;", "⪂", txt)
        txt = re.sub(r"&gesdoto;", "⪂", txt)

        # "U+02A83", "LESS-THAN OR SLANTED EQUAL TO WITH DOT ABOVE RIGHT"
        txt = re.sub(r"&#x0*?2A83;", "⪃", txt)
        txt = re.sub(r"&#0*?10883;", "⪃", txt)
        txt = re.sub(r"&lesdotor;", "⪃", txt)

        # "U+02A84", "GREATER-THAN OR SLANTED EQUAL TO WITH DOT ABOVE LEFT"
        txt = re.sub(r"&#x0*?2A84;", "⪄", txt)
        txt = re.sub(r"&#0*?10884;", "⪄", txt)
        txt = re.sub(r"&gesdotol;", "⪄", txt)

        # "U+02A85", "LESS-THAN OR APPROXIMATE"
        txt = re.sub(r"&#x0*?2A85;", "⪅", txt)
        txt = re.sub(r"&#0*?10885;", "⪅", txt)
        txt = re.sub(r"&lap;", "⪅", txt)
        txt = re.sub(r"&lessapprox;", "⪅", txt)

        # "U+02A86", "GREATER-THAN OR APPROXIMATE"
        txt = re.sub(r"&#x0*?2A86;", "⪆", txt)
        txt = re.sub(r"&#0*?10886;", "⪆", txt)
        txt = re.sub(r"&gap;", "⪆", txt)
        txt = re.sub(r"&gtrapprox;", "⪆", txt)

        # "U+02A87", "LESS-THAN AND SINGLE-LINE NOT EQUAL TO"
        txt = re.sub(r"&#x0*?2A87;", "⪇", txt)
        txt = re.sub(r"&#0*?10887;", "⪇", txt)
        txt = re.sub(r"&lne;", "⪇", txt)
        txt = re.sub(r"&lneq;", "⪇", txt)

        # "U+02A88", "GREATER-THAN AND SINGLE-LINE NOT EQUAL TO"
        txt = re.sub(r"&#x0*?2A88;", "⪈", txt)
        txt = re.sub(r"&#0*?10888;", "⪈", txt)
        txt = re.sub(r"&gne;", "⪈", txt)
        txt = re.sub(r"&gneq;", "⪈", txt)

        # "U+02A89", "LESS-THAN AND NOT APPROXIMATE"
        txt = re.sub(r"&#x0*?2A89;", "⪉", txt)
        txt = re.sub(r"&#0*?10889;", "⪉", txt)
        txt = re.sub(r"&lnap;", "⪉", txt)
        txt = re.sub(r"&lnapprox;", "⪉", txt)

        # "U+02A8A", "GREATER-THAN AND NOT APPROXIMATE"
        txt = re.sub(r"&#x0*?2A8A;", "⪊", txt)
        txt = re.sub(r"&#0*?10890;", "⪊", txt)
        txt = re.sub(r"&gnap;", "⪊", txt)
        txt = re.sub(r"&gnapprox;", "⪊", txt)

        # "U+02A8B", "LESS-THAN ABOVE DOUBLE-LINE EQUAL ABOVE GREATER-THAN"
        txt = re.sub(r"&#x0*?2A8B;", "⪋", txt)
        txt = re.sub(r"&#0*?10891;", "⪋", txt)
        txt = re.sub(r"&lEg;", "⪋", txt)
        txt = re.sub(r"&lesseqqgtr;", "⪋", txt)

        # "U+02A8C", "GREATER-THAN ABOVE DOUBLE-LINE EQUAL ABOVE LESS-THAN"
        txt = re.sub(r"&#x0*?2A8C;", "⪌", txt)
        txt = re.sub(r"&#0*?10892;", "⪌", txt)
        txt = re.sub(r"&gEl;", "⪌", txt)
        txt = re.sub(r"&gtreqqless;", "⪌", txt)

        # "U+02A8D", "LESS-THAN ABOVE SIMILAR OR EQUAL"
        txt = re.sub(r"&#x0*?2A8D;", "⪍", txt)
        txt = re.sub(r"&#0*?10893;", "⪍", txt)
        txt = re.sub(r"&lsime;", "⪍", txt)

        # "U+02A8E", "GREATER-THAN ABOVE SIMILAR OR EQUAL"
        txt = re.sub(r"&#x0*?2A8E;", "⪎", txt)
        txt = re.sub(r"&#0*?10894;", "⪎", txt)
        txt = re.sub(r"&gsime;", "⪎", txt)

        # "U+02A8F", "LESS-THAN ABOVE SIMILAR ABOVE GREATER-THAN"
        txt = re.sub(r"&#x0*?2A8F;", "⪏", txt)
        txt = re.sub(r"&#0*?10895;", "⪏", txt)
        txt = re.sub(r"&lsimg;", "⪏", txt)

        # "U+02A90", "GREATER-THAN ABOVE SIMILAR ABOVE LESS-THAN"
        txt = re.sub(r"&#x0*?2A90;", "⪐", txt)
        txt = re.sub(r"&#0*?10896;", "⪐", txt)
        txt = re.sub(r"&gsiml;", "⪐", txt)

        # "U+02A91", "LESS-THAN ABOVE GREATER-THAN ABOVE DOUBLE-LINE EQUAL"
        txt = re.sub(r"&#x0*?2A91;", "⪑", txt)
        txt = re.sub(r"&#0*?10897;", "⪑", txt)
        txt = re.sub(r"&lgE;", "⪑", txt)

        # "U+02A92", "GREATER-THAN ABOVE LESS-THAN ABOVE DOUBLE-LINE EQUAL"
        txt = re.sub(r"&#x0*?2A92;", "⪒", txt)
        txt = re.sub(r"&#0*?10898;", "⪒", txt)
        txt = re.sub(r"&glE;", "⪒", txt)

        # "U+02A93", "LESS-THAN ABOVE SLANTED EQUAL ABOVE GREATER-THAN ABOVE SLANTED EQUAL"
        txt = re.sub(r"&#x0*?2A93;", "⪓", txt)
        txt = re.sub(r"&#0*?10899;", "⪓", txt)
        txt = re.sub(r"&lesges;", "⪓", txt)

        # "U+02A94", "GREATER-THAN ABOVE SLANTED EQUAL ABOVE LESS-THAN ABOVE SLANTED EQUAL"
        txt = re.sub(r"&#x0*?2A94;", "⪔", txt)
        txt = re.sub(r"&#0*?10900;", "⪔", txt)
        txt = re.sub(r"&gesles;", "⪔", txt)

        # "U+02A95", "SLANTED EQUAL TO OR LESS-THAN"
        txt = re.sub(r"&#x0*?2A95;", "⪕", txt)
        txt = re.sub(r"&#0*?10901;", "⪕", txt)
        txt = re.sub(r"&els;", "⪕", txt)
        txt = re.sub(r"&eqslantless;", "⪕", txt)

        # "U+02A96", "SLANTED EQUAL TO OR GREATER-THAN"
        txt = re.sub(r"&#x0*?2A96;", "⪖", txt)
        txt = re.sub(r"&#0*?10902;", "⪖", txt)
        txt = re.sub(r"&egs;", "⪖", txt)
        txt = re.sub(r"&eqslantgtr;", "⪖", txt)

        # "U+02A97", "SLANTED EQUAL TO OR LESS-THAN WITH DOT INSIDE"
        txt = re.sub(r"&#x0*?2A97;", "⪗", txt)
        txt = re.sub(r"&#0*?10903;", "⪗", txt)
        txt = re.sub(r"&elsdot;", "⪗", txt)

        # "U+02A98", "SLANTED EQUAL TO OR GREATER-THAN WITH DOT INSIDE"
        txt = re.sub(r"&#x0*?2A98;", "⪘", txt)
        txt = re.sub(r"&#0*?10904;", "⪘", txt)
        txt = re.sub(r"&egsdot;", "⪘", txt)

        # "U+02A99", "DOUBLE-LINE EQUAL TO OR LESS-THAN"
        txt = re.sub(r"&#x0*?2A99;", "⪙", txt)
        txt = re.sub(r"&#0*?10905;", "⪙", txt)
        txt = re.sub(r"&el;", "⪙", txt)

        # "U+02A9A", "DOUBLE-LINE EQUAL TO OR GREATER-THAN"
        txt = re.sub(r"&#x0*?2A9A;", "⪚", txt)
        txt = re.sub(r"&#0*?10906;", "⪚", txt)
        txt = re.sub(r"&eg;", "⪚", txt)

        # "U+02A9D", "SIMILAR OR LESS-THAN"
        txt = re.sub(r"&#x0*?2A9D;", "⪝", txt)
        txt = re.sub(r"&#0*?10909;", "⪝", txt)
        txt = re.sub(r"&siml;", "⪝", txt)

        # "U+02A9E", "SIMILAR OR GREATER-THAN"
        txt = re.sub(r"&#x0*?2A9E;", "⪞", txt)
        txt = re.sub(r"&#0*?10910;", "⪞", txt)
        txt = re.sub(r"&simg;", "⪞", txt)

        # "U+02A9F", "SIMILAR ABOVE LESS-THAN ABOVE EQUALS SIGN"
        txt = re.sub(r"&#x0*?2A9F;", "⪟", txt)
        txt = re.sub(r"&#0*?10911;", "⪟", txt)
        txt = re.sub(r"&simlE;", "⪟", txt)

        # "U+02AA0", "SIMILAR ABOVE GREATER-THAN ABOVE EQUALS SIGN"
        txt = re.sub(r"&#x0*?2AA0;", "⪠", txt)
        txt = re.sub(r"&#0*?10912;", "⪠", txt)
        txt = re.sub(r"&simgE;", "⪠", txt)

        # "U+02AA1", "DOUBLE NESTED LESS-THAN"
        txt = re.sub(r"&#x0*?2AA1;", "⪡", txt)
        txt = re.sub(r"&#0*?10913;", "⪡", txt)
        txt = re.sub(r"&LessLess;", "⪡", txt)

        # "U+02AA2", "DOUBLE NESTED GREATER-THAN"
        txt = re.sub(r"&#x0*?2AA2;", "⪢", txt)
        txt = re.sub(r"&#0*?10914;", "⪢", txt)
        txt = re.sub(r"&GreaterGreater;", "⪢", txt)

        # "U+02AA4", "GREATER-THAN OVERLAPPING LESS-THAN"
        txt = re.sub(r"&#x0*?2AA4;", "⪤", txt)
        txt = re.sub(r"&#0*?10916;", "⪤", txt)
        txt = re.sub(r"&glj;", "⪤", txt)

        # "U+02AA5", "GREATER-THAN BESIDE LESS-THAN"
        txt = re.sub(r"&#x0*?2AA5;", "⪥", txt)
        txt = re.sub(r"&#0*?10917;", "⪥", txt)
        txt = re.sub(r"&gla;", "⪥", txt)

        # "U+02AA6", "LESS-THAN CLOSED BY CURVE"
        txt = re.sub(r"&#x0*?2AA6;", "⪦", txt)
        txt = re.sub(r"&#0*?10918;", "⪦", txt)
        txt = re.sub(r"&ltcc;", "⪦", txt)

        # "U+02AA7", "GREATER-THAN CLOSED BY CURVE"
        txt = re.sub(r"&#x0*?2AA7;", "⪧", txt)
        txt = re.sub(r"&#0*?10919;", "⪧", txt)
        txt = re.sub(r"&gtcc;", "⪧", txt)

        # "U+02AA8", "LESS-THAN CLOSED BY CURVE ABOVE SLANTED EQUAL"
        txt = re.sub(r"&#x0*?2AA8;", "⪨", txt)
        txt = re.sub(r"&#0*?10920;", "⪨", txt)
        txt = re.sub(r"&lescc;", "⪨", txt)

        # "U+02AA9", "GREATER-THAN CLOSED BY CURVE ABOVE SLANTED EQUAL"
        txt = re.sub(r"&#x0*?2AA9;", "⪩", txt)
        txt = re.sub(r"&#0*?10921;", "⪩", txt)
        txt = re.sub(r"&gescc;", "⪩", txt)

        # "U+02AAA", "SMALLER THAN"
        txt = re.sub(r"&#x0*?2AAA;", "⪪", txt)
        txt = re.sub(r"&#0*?10922;", "⪪", txt)
        txt = re.sub(r"&smt;", "⪪", txt)

        # "U+02AAB", "LARGER THAN"
        txt = re.sub(r"&#x0*?2AAB;", "⪫", txt)
        txt = re.sub(r"&#0*?10923;", "⪫", txt)
        txt = re.sub(r"&lat;", "⪫", txt)

        # "U+02AAC", "SMALLER THAN OR EQUAL TO"
        txt = re.sub(r"&#x0*?2AAC;", "⪬", txt)
        txt = re.sub(r"&#0*?10924;", "⪬", txt)
        txt = re.sub(r"&smte;", "⪬", txt)

        # "U+02AAD", "LARGER THAN OR EQUAL TO"
        txt = re.sub(r"&#x0*?2AAD;", "⪭", txt)
        txt = re.sub(r"&#0*?10925;", "⪭", txt)
        txt = re.sub(r"&late;", "⪭", txt)

        # "U+02AAE", "EQUALS SIGN WITH BUMPY ABOVE"
        txt = re.sub(r"&#x0*?2AAE;", "⪮", txt)
        txt = re.sub(r"&#0*?10926;", "⪮", txt)
        txt = re.sub(r"&bumpE;", "⪮", txt)

        # "U+02AAF", "PRECEDES ABOVE SINGLE-LINE EQUALS SIGN"
        txt = re.sub(r"&#x0*?2AAF;", "⪯", txt)
        txt = re.sub(r"&#0*?10927;", "⪯", txt)
        txt = re.sub(r"&pre;", "⪯", txt)
        txt = re.sub(r"&preceq;", "⪯", txt)
        txt = re.sub(r"&PrecedesEqual;", "⪯", txt)

        # "U+02AB0", "SUCCEEDS ABOVE SINGLE-LINE EQUALS SIGN"
        txt = re.sub(r"&#x0*?2AB0;", "⪰", txt)
        txt = re.sub(r"&#0*?10928;", "⪰", txt)
        txt = re.sub(r"&sce;", "⪰", txt)
        txt = re.sub(r"&succeq;", "⪰", txt)
        txt = re.sub(r"&SucceedsEqual;", "⪰", txt)

        # "U+02AB3", "PRECEDES ABOVE EQUALS SIGN"
        txt = re.sub(r"&#x0*?2AB3;", "⪳", txt)
        txt = re.sub(r"&#0*?10931;", "⪳", txt)
        txt = re.sub(r"&prE;", "⪳", txt)

        # "U+02AB4", "SUCCEEDS ABOVE EQUALS SIGN"
        txt = re.sub(r"&#x0*?2AB4;", "⪴", txt)
        txt = re.sub(r"&#0*?10932;", "⪴", txt)
        txt = re.sub(r"&scE;", "⪴", txt)

        # "U+02AB5", "PRECEDES ABOVE NOT EQUAL TO"
        txt = re.sub(r"&#x0*?2AB5;", "⪵", txt)
        txt = re.sub(r"&#0*?10933;", "⪵", txt)
        txt = re.sub(r"&prnE;", "⪵", txt)
        txt = re.sub(r"&precneqq;", "⪵", txt)

        # "U+02AB6", "SUCCEEDS ABOVE NOT EQUAL TO"
        txt = re.sub(r"&#x0*?2AB6;", "⪶", txt)
        txt = re.sub(r"&#0*?10934;", "⪶", txt)
        txt = re.sub(r"&scnE;", "⪶", txt)
        txt = re.sub(r"&succneqq;", "⪶", txt)

        # "U+02AB7", "PRECEDES ABOVE ALMOST EQUAL TO"
        txt = re.sub(r"&#x0*?2AB7;", "⪷", txt)
        txt = re.sub(r"&#0*?10935;", "⪷", txt)
        txt = re.sub(r"&prap;", "⪷", txt)
        txt = re.sub(r"&precapprox;", "⪷", txt)

        # "U+02AB8", "SUCCEEDS ABOVE ALMOST EQUAL TO"
        txt = re.sub(r"&#x0*?2AB8;", "⪸", txt)
        txt = re.sub(r"&#0*?10936;", "⪸", txt)
        txt = re.sub(r"&scap;", "⪸", txt)
        txt = re.sub(r"&succapprox;", "⪸", txt)

        # "U+02AB9", "PRECEDES ABOVE NOT ALMOST EQUAL TO"
        txt = re.sub(r"&#x0*?2AB9;", "⪹", txt)
        txt = re.sub(r"&#0*?10937;", "⪹", txt)
        txt = re.sub(r"&prnap;", "⪹", txt)
        txt = re.sub(r"&precnapprox;", "⪹", txt)

        # "U+02ABA", "SUCCEEDS ABOVE NOT ALMOST EQUAL TO"
        txt = re.sub(r"&#x0*?2ABA;", "⪺", txt)
        txt = re.sub(r"&#0*?10938;", "⪺", txt)
        txt = re.sub(r"&scnap;", "⪺", txt)
        txt = re.sub(r"&succnapprox;", "⪺", txt)

        # "U+02ABB", "DOUBLE PRECEDES"
        txt = re.sub(r"&#x0*?2ABB;", "⪻", txt)
        txt = re.sub(r"&#0*?10939;", "⪻", txt)
        txt = re.sub(r"&Pr;", "⪻", txt)

        # "U+02ABC", "DOUBLE SUCCEEDS"
        txt = re.sub(r"&#x0*?2ABC;", "⪼", txt)
        txt = re.sub(r"&#0*?10940;", "⪼", txt)
        txt = re.sub(r"&Sc;", "⪼", txt)

        # "U+02ABD", "SUBSET WITH DOT"
        txt = re.sub(r"&#x0*?2ABD;", "⪽", txt)
        txt = re.sub(r"&#0*?10941;", "⪽", txt)
        txt = re.sub(r"&subdot;", "⪽", txt)

        # "U+02ABE", "SUPERSET WITH DOT"
        txt = re.sub(r"&#x0*?2ABE;", "⪾", txt)
        txt = re.sub(r"&#0*?10942;", "⪾", txt)
        txt = re.sub(r"&supdot;", "⪾", txt)

        # "U+02ABF", "SUBSET WITH PLUS SIGN BELOW"
        txt = re.sub(r"&#x0*?2ABF;", "⪿", txt)
        txt = re.sub(r"&#0*?10943;", "⪿", txt)
        txt = re.sub(r"&subplus;", "⪿", txt)

        # "U+02AC0", "SUPERSET WITH PLUS SIGN BELOW"
        txt = re.sub(r"&#x0*?2AC0;", "⫀", txt)
        txt = re.sub(r"&#0*?10944;", "⫀", txt)
        txt = re.sub(r"&supplus;", "⫀", txt)

        # "U+02AC1", "SUBSET WITH MULTIPLICATION SIGN BELOW"
        txt = re.sub(r"&#x0*?2AC1;", "⫁", txt)
        txt = re.sub(r"&#0*?10945;", "⫁", txt)
        txt = re.sub(r"&submult;", "⫁", txt)

        # "U+02AC2", "SUPERSET WITH MULTIPLICATION SIGN BELOW"
        txt = re.sub(r"&#x0*?2AC2;", "⫂", txt)
        txt = re.sub(r"&#0*?10946;", "⫂", txt)
        txt = re.sub(r"&supmult;", "⫂", txt)

        # "U+02AC3", "SUBSET OF OR EQUAL TO WITH DOT ABOVE"
        txt = re.sub(r"&#x0*?2AC3;", "⫃", txt)
        txt = re.sub(r"&#0*?10947;", "⫃", txt)
        txt = re.sub(r"&subedot;", "⫃", txt)

        # "U+02AC4", "SUPERSET OF OR EQUAL TO WITH DOT ABOVE"
        txt = re.sub(r"&#x0*?2AC4;", "⫄", txt)
        txt = re.sub(r"&#0*?10948;", "⫄", txt)
        txt = re.sub(r"&supedot;", "⫄", txt)

        # "U+02AC5", "SUBSET OF ABOVE EQUALS SIGN"
        txt = re.sub(r"&#x0*?2AC5;", "⫅", txt)
        txt = re.sub(r"&#0*?10949;", "⫅", txt)
        txt = re.sub(r"&subE;", "⫅", txt)
        txt = re.sub(r"&subseteqq;", "⫅", txt)

        # "U+02AC6", "SUPERSET OF ABOVE EQUALS SIGN"
        txt = re.sub(r"&#x0*?2AC6;", "⫆", txt)
        txt = re.sub(r"&#0*?10950;", "⫆", txt)
        txt = re.sub(r"&supE;", "⫆", txt)
        txt = re.sub(r"&supseteqq;", "⫆", txt)

        # "U+02AC7", "SUBSET OF ABOVE TILDE OPERATOR"
        txt = re.sub(r"&#x0*?2AC7;", "⫇", txt)
        txt = re.sub(r"&#0*?10951;", "⫇", txt)
        txt = re.sub(r"&subsim;", "⫇", txt)

        # "U+02AC8", "SUPERSET OF ABOVE TILDE OPERATOR"
        txt = re.sub(r"&#x0*?2AC8;", "⫈", txt)
        txt = re.sub(r"&#0*?10952;", "⫈", txt)
        txt = re.sub(r"&supsim;", "⫈", txt)

        # "U+02ACB", "SUBSET OF ABOVE NOT EQUAL TO"
        txt = re.sub(r"&#x0*?2ACB;", "⫋", txt)
        txt = re.sub(r"&#0*?10955;", "⫋", txt)
        txt = re.sub(r"&subnE;", "⫋", txt)
        txt = re.sub(r"&subsetneqq;", "⫋", txt)

        # "U+02ACC", "SUPERSET OF ABOVE NOT EQUAL TO"
        txt = re.sub(r"&#x0*?2ACC;", "⫌", txt)
        txt = re.sub(r"&#0*?10956;", "⫌", txt)
        txt = re.sub(r"&supnE;", "⫌", txt)
        txt = re.sub(r"&supsetneqq;", "⫌", txt)

        # "U+02ACF", "CLOSED SUBSET"
        txt = re.sub(r"&#x0*?2ACF;", "⫏", txt)
        txt = re.sub(r"&#0*?10959;", "⫏", txt)
        txt = re.sub(r"&csub;", "⫏", txt)

        # "U+02AD0", "CLOSED SUPERSET"
        txt = re.sub(r"&#x0*?2AD0;", "⫐", txt)
        txt = re.sub(r"&#0*?10960;", "⫐", txt)
        txt = re.sub(r"&csup;", "⫐", txt)

        # "U+02AD1", "CLOSED SUBSET OR EQUAL TO"
        txt = re.sub(r"&#x0*?2AD1;", "⫑", txt)
        txt = re.sub(r"&#0*?10961;", "⫑", txt)
        txt = re.sub(r"&csube;", "⫑", txt)

        # "U+02AD2", "CLOSED SUPERSET OR EQUAL TO"
        txt = re.sub(r"&#x0*?2AD2;", "⫒", txt)
        txt = re.sub(r"&#0*?10962;", "⫒", txt)
        txt = re.sub(r"&csupe;", "⫒", txt)

        # "U+02AD3", "SUBSET ABOVE SUPERSET"
        txt = re.sub(r"&#x0*?2AD3;", "⫓", txt)
        txt = re.sub(r"&#0*?10963;", "⫓", txt)
        txt = re.sub(r"&subsup;", "⫓", txt)

        # "U+02AD4", "SUPERSET ABOVE SUBSET"
        txt = re.sub(r"&#x0*?2AD4;", "⫔", txt)
        txt = re.sub(r"&#0*?10964;", "⫔", txt)
        txt = re.sub(r"&supsub;", "⫔", txt)

        # "U+02AD5", "SUBSET ABOVE SUBSET"
        txt = re.sub(r"&#x0*?2AD5;", "⫕", txt)
        txt = re.sub(r"&#0*?10965;", "⫕", txt)
        txt = re.sub(r"&subsub;", "⫕", txt)

        # "U+02AD6", "SUPERSET ABOVE SUPERSET"
        txt = re.sub(r"&#x0*?2AD6;", "⫖", txt)
        txt = re.sub(r"&#0*?10966;", "⫖", txt)
        txt = re.sub(r"&supsup;", "⫖", txt)

        # "U+02AD7", "SUPERSET BESIDE SUBSET"
        txt = re.sub(r"&#x0*?2AD7;", "⫗", txt)
        txt = re.sub(r"&#0*?10967;", "⫗", txt)
        txt = re.sub(r"&suphsub;", "⫗", txt)

        # "U+02AD8", "SUPERSET BESIDE AND JOINED BY DASH WITH SUBSET"
        txt = re.sub(r"&#x0*?2AD8;", "⫘", txt)
        txt = re.sub(r"&#0*?10968;", "⫘", txt)
        txt = re.sub(r"&supdsub;", "⫘", txt)

        # "U+02AD9", "ELEMENT OF OPENING DOWNWARDS"
        txt = re.sub(r"&#x0*?2AD9;", "⫙", txt)
        txt = re.sub(r"&#0*?10969;", "⫙", txt)
        txt = re.sub(r"&forkv;", "⫙", txt)

        # "U+02ADA", "PITCHFORK WITH TEE TOP"
        txt = re.sub(r"&#x0*?2ADA;", "⫚", txt)
        txt = re.sub(r"&#0*?10970;", "⫚", txt)
        txt = re.sub(r"&topfork;", "⫚", txt)

        # "U+02ADB", "TRANSVERSAL INTERSECTION"
        txt = re.sub(r"&#x0*?2ADB;", "⫛", txt)
        txt = re.sub(r"&#0*?10971;", "⫛", txt)
        txt = re.sub(r"&mlcp;", "⫛", txt)

        # "U+02AE4", "VERTICAL BAR DOUBLE LEFT TURNSTILE"
        txt = re.sub(r"&#x0*?2AE4;", "⫤", txt)
        txt = re.sub(r"&#0*?10980;", "⫤", txt)
        txt = re.sub(r"&Dashv;", "⫤", txt)
        txt = re.sub(r"&DoubleLeftTee;", "⫤", txt)

        # "U+02AE6", "LONG DASH FROM LEFT MEMBER OF DOUBLE VERTICAL"
        txt = re.sub(r"&#x0*?2AE6;", "⫦", txt)
        txt = re.sub(r"&#0*?10982;", "⫦", txt)
        txt = re.sub(r"&Vdashl;", "⫦", txt)

        # "U+02AE7", "SHORT DOWN TACK WITH OVERBAR"
        txt = re.sub(r"&#x0*?2AE7;", "⫧", txt)
        txt = re.sub(r"&#0*?10983;", "⫧", txt)
        txt = re.sub(r"&Barv;", "⫧", txt)

        # "U+02AE8", "SHORT UP TACK WITH UNDERBAR"
        txt = re.sub(r"&#x0*?2AE8;", "⫨", txt)
        txt = re.sub(r"&#0*?10984;", "⫨", txt)
        txt = re.sub(r"&vBar;", "⫨", txt)

        # "U+02AE9", "SHORT UP TACK ABOVE SHORT DOWN TACK"
        txt = re.sub(r"&#x0*?2AE9;", "⫩", txt)
        txt = re.sub(r"&#0*?10985;", "⫩", txt)
        txt = re.sub(r"&vBarv;", "⫩", txt)

        # "U+02AEB", "DOUBLE UP TACK"
        txt = re.sub(r"&#x0*?2AEB;", "⫫", txt)
        txt = re.sub(r"&#0*?10987;", "⫫", txt)
        txt = re.sub(r"&Vbar;", "⫫", txt)

        # "U+02AEC", "DOUBLE STROKE NOT SIGN"
        txt = re.sub(r"&#x0*?2AEC;", "⫬", txt)
        txt = re.sub(r"&#0*?10988;", "⫬", txt)
        txt = re.sub(r"&Not;", "⫬", txt)

        # "U+02AED", "REVERSED DOUBLE STROKE NOT SIGN"
        txt = re.sub(r"&#x0*?2AED;", "⫭", txt)
        txt = re.sub(r"&#0*?10989;", "⫭", txt)
        txt = re.sub(r"&bNot;", "⫭", txt)

        # "U+02AEE", "DOES NOT DIVIDE WITH REVERSED NEGATION SLASH"
        txt = re.sub(r"&#x0*?2AEE;", "⫮", txt)
        txt = re.sub(r"&#0*?10990;", "⫮", txt)
        txt = re.sub(r"&rnmid;", "⫮", txt)

        # "U+02AEF", "VERTICAL LINE WITH CIRCLE ABOVE"
        txt = re.sub(r"&#x0*?2AEF;", "⫯", txt)
        txt = re.sub(r"&#0*?10991;", "⫯", txt)
        txt = re.sub(r"&cirmid;", "⫯", txt)

        # "U+02AF0", "VERTICAL LINE WITH CIRCLE BELOW"
        txt = re.sub(r"&#x0*?2AF0;", "⫰", txt)
        txt = re.sub(r"&#0*?10992;", "⫰", txt)
        txt = re.sub(r"&midcir;", "⫰", txt)

        # "U+02AF1", "DOWN TACK WITH CIRCLE BELOW"
        txt = re.sub(r"&#x0*?2AF1;", "⫱", txt)
        txt = re.sub(r"&#0*?10993;", "⫱", txt)
        txt = re.sub(r"&topcir;", "⫱", txt)

        # "U+02AF2", "PARALLEL WITH HORIZONTAL STROKE"
        txt = re.sub(r"&#x0*?2AF2;", "⫲", txt)
        txt = re.sub(r"&#0*?10994;", "⫲", txt)
        txt = re.sub(r"&nhpar;", "⫲", txt)

        # "U+02AF3", "PARALLEL WITH TILDE OPERATOR"
        txt = re.sub(r"&#x0*?2AF3;", "⫳", txt)
        txt = re.sub(r"&#0*?10995;", "⫳", txt)
        txt = re.sub(r"&parsim;", "⫳", txt)

        # "U+02AFD", "DOUBLE SOLIDUS OPERATOR"
        txt = re.sub(r"&#x0*?2AFD;", "⫽", txt)
        txt = re.sub(r"&#0*?11005;", "⫽", txt)
        txt = re.sub(r"&parsl;", "⫽", txt)

        # "U+0FB00", "LATIN SMALL LIGATURE FF"
        txt = re.sub(r"&#x0*?FB00;", "ﬀ", txt)
        txt = re.sub(r"&#0*?64256;", "ﬀ", txt)
        txt = re.sub(r"&fflig;", "ﬀ", txt)

        # "U+0FB01", "LATIN SMALL LIGATURE FI"
        txt = re.sub(r"&#x0*?FB01;", "ﬁ", txt)
        txt = re.sub(r"&#0*?64257;", "ﬁ", txt)
        txt = re.sub(r"&filig;", "ﬁ", txt)

        # "U+0FB02", "LATIN SMALL LIGATURE FL"
        txt = re.sub(r"&#x0*?FB02;", "ﬂ", txt)
        txt = re.sub(r"&#0*?64258;", "ﬂ", txt)
        txt = re.sub(r"&fllig;", "ﬂ", txt)

        # "U+0FB03", "LATIN SMALL LIGATURE FFI"
        txt = re.sub(r"&#x0*?FB03;", "ﬃ", txt)
        txt = re.sub(r"&#0*?64259;", "ﬃ", txt)
        txt = re.sub(r"&ffilig;", "ﬃ", txt)

        # "U+0FB04", "LATIN SMALL LIGATURE FFL"
        txt = re.sub(r"&#x0*?FB04;", "ﬄ", txt)
        txt = re.sub(r"&#0*?64260;", "ﬄ", txt)
        txt = re.sub(r"&ffllig;", "ﬄ", txt)

        # "U+1D49C", "MATHEMATICAL SCRIPT CAPITAL A"
        txt = re.sub(r"&#x0*?1D49C;", "𝒜", txt)
        txt = re.sub(r"&#0*?119964;", "𝒜", txt)
        txt = re.sub(r"&Ascr;", "𝒜", txt)

        # "U+1D49E", "MATHEMATICAL SCRIPT CAPITAL C"
        txt = re.sub(r"&#x0*?1D49E;", "𝒞", txt)
        txt = re.sub(r"&#0*?119966;", "𝒞", txt)
        txt = re.sub(r"&Cscr;", "𝒞", txt)

        # "U+1D49F", "MATHEMATICAL SCRIPT CAPITAL D"
        txt = re.sub(r"&#x0*?1D49F;", "𝒟", txt)
        txt = re.sub(r"&#0*?119967;", "𝒟", txt)
        txt = re.sub(r"&Dscr;", "𝒟", txt)

        # "U+1D4A2", "MATHEMATICAL SCRIPT CAPITAL G"
        txt = re.sub(r"&#x0*?1D4A2;", "𝒢", txt)
        txt = re.sub(r"&#0*?119970;", "𝒢", txt)
        txt = re.sub(r"&Gscr;", "𝒢", txt)

        # "U+1D4A5", "MATHEMATICAL SCRIPT CAPITAL J"
        txt = re.sub(r"&#x0*?1D4A5;", "𝒥", txt)
        txt = re.sub(r"&#0*?119973;", "𝒥", txt)
        txt = re.sub(r"&Jscr;", "𝒥", txt)

        # "U+1D4A6", "MATHEMATICAL SCRIPT CAPITAL K"
        txt = re.sub(r"&#x0*?1D4A6;", "𝒦", txt)
        txt = re.sub(r"&#0*?119974;", "𝒦", txt)
        txt = re.sub(r"&Kscr;", "𝒦", txt)

        # "U+1D4A9", "MATHEMATICAL SCRIPT CAPITAL N"
        txt = re.sub(r"&#x0*?1D4A9;", "𝒩", txt)
        txt = re.sub(r"&#0*?119977;", "𝒩", txt)
        txt = re.sub(r"&Nscr;", "𝒩", txt)

        # "U+1D4AA", "MATHEMATICAL SCRIPT CAPITAL O"
        txt = re.sub(r"&#x0*?1D4AA;", "𝒪", txt)
        txt = re.sub(r"&#0*?119978;", "𝒪", txt)
        txt = re.sub(r"&Oscr;", "𝒪", txt)

        # "U+1D4AB", "MATHEMATICAL SCRIPT CAPITAL P"
        txt = re.sub(r"&#x0*?1D4AB;", "𝒫", txt)
        txt = re.sub(r"&#0*?119979;", "𝒫", txt)
        txt = re.sub(r"&Pscr;", "𝒫", txt)

        # "U+1D4AC", "MATHEMATICAL SCRIPT CAPITAL Q"
        txt = re.sub(r"&#x0*?1D4AC;", "𝒬", txt)
        txt = re.sub(r"&#0*?119980;", "𝒬", txt)
        txt = re.sub(r"&Qscr;", "𝒬", txt)

        # "U+1D4AE", "MATHEMATICAL SCRIPT CAPITAL S"
        txt = re.sub(r"&#x0*?1D4AE;", "𝒮", txt)
        txt = re.sub(r"&#0*?119982;", "𝒮", txt)
        txt = re.sub(r"&Sscr;", "𝒮", txt)

        # "U+1D4AF", "MATHEMATICAL SCRIPT CAPITAL T"
        txt = re.sub(r"&#x0*?1D4AF;", "𝒯", txt)
        txt = re.sub(r"&#0*?119983;", "𝒯", txt)
        txt = re.sub(r"&Tscr;", "𝒯", txt)

        # "U+1D4B0", "MATHEMATICAL SCRIPT CAPITAL U"
        txt = re.sub(r"&#x0*?1D4B0;", "𝒰", txt)
        txt = re.sub(r"&#0*?119984;", "𝒰", txt)
        txt = re.sub(r"&Uscr;", "𝒰", txt)

        # "U+1D4B1", "MATHEMATICAL SCRIPT CAPITAL V"
        txt = re.sub(r"&#x0*?1D4B1;", "𝒱", txt)
        txt = re.sub(r"&#0*?119985;", "𝒱", txt)
        txt = re.sub(r"&Vscr;", "𝒱", txt)

        # "U+1D4B2", "MATHEMATICAL SCRIPT CAPITAL W"
        txt = re.sub(r"&#x0*?1D4B2;", "𝒲", txt)
        txt = re.sub(r"&#0*?119986;", "𝒲", txt)
        txt = re.sub(r"&Wscr;", "𝒲", txt)

        # "U+1D4B3", "MATHEMATICAL SCRIPT CAPITAL X"
        txt = re.sub(r"&#x0*?1D4B3;", "𝒳", txt)
        txt = re.sub(r"&#0*?119987;", "𝒳", txt)
        txt = re.sub(r"&Xscr;", "𝒳", txt)

        # "U+1D4B4", "MATHEMATICAL SCRIPT CAPITAL Y"
        txt = re.sub(r"&#x0*?1D4B4;", "𝒴", txt)
        txt = re.sub(r"&#0*?119988;", "𝒴", txt)
        txt = re.sub(r"&Yscr;", "𝒴", txt)

        # "U+1D4B5", "MATHEMATICAL SCRIPT CAPITAL Z"
        txt = re.sub(r"&#x0*?1D4B5;", "𝒵", txt)
        txt = re.sub(r"&#0*?119989;", "𝒵", txt)
        txt = re.sub(r"&Zscr;", "𝒵", txt)

        # "U+1D4B6", "MATHEMATICAL SCRIPT SMALL A"
        txt = re.sub(r"&#x0*?1D4B6;", "𝒶", txt)
        txt = re.sub(r"&#0*?119990;", "𝒶", txt)
        txt = re.sub(r"&ascr;", "𝒶", txt)

        # "U+1D4B7", "MATHEMATICAL SCRIPT SMALL B"
        txt = re.sub(r"&#x0*?1D4B7;", "𝒷", txt)
        txt = re.sub(r"&#0*?119991;", "𝒷", txt)
        txt = re.sub(r"&bscr;", "𝒷", txt)

        # "U+1D4B8", "MATHEMATICAL SCRIPT SMALL C"
        txt = re.sub(r"&#x0*?1D4B8;", "𝒸", txt)
        txt = re.sub(r"&#0*?119992;", "𝒸", txt)
        txt = re.sub(r"&cscr;", "𝒸", txt)

        # "U+1D4B9", "MATHEMATICAL SCRIPT SMALL D"
        txt = re.sub(r"&#x0*?1D4B9;", "𝒹", txt)
        txt = re.sub(r"&#0*?119993;", "𝒹", txt)
        txt = re.sub(r"&dscr;", "𝒹", txt)

        # "U+1D4BB", "MATHEMATICAL SCRIPT SMALL F"
        txt = re.sub(r"&#x0*?1D4BB;", "𝒻", txt)
        txt = re.sub(r"&#0*?119995;", "𝒻", txt)
        txt = re.sub(r"&fscr;", "𝒻", txt)

        # "U+1D4BD", "MATHEMATICAL SCRIPT SMALL H"
        txt = re.sub(r"&#x0*?1D4BD;", "𝒽", txt)
        txt = re.sub(r"&#0*?119997;", "𝒽", txt)
        txt = re.sub(r"&hscr;", "𝒽", txt)

        # "U+1D4BE", "MATHEMATICAL SCRIPT SMALL I"
        txt = re.sub(r"&#x0*?1D4BE;", "𝒾", txt)
        txt = re.sub(r"&#0*?119998;", "𝒾", txt)
        txt = re.sub(r"&iscr;", "𝒾", txt)

        # "U+1D4BF", "MATHEMATICAL SCRIPT SMALL J"
        txt = re.sub(r"&#x0*?1D4BF;", "𝒿", txt)
        txt = re.sub(r"&#0*?119999;", "𝒿", txt)
        txt = re.sub(r"&jscr;", "𝒿", txt)

        # "U+1D4C0", "MATHEMATICAL SCRIPT SMALL K"
        txt = re.sub(r"&#x0*?1D4C0;", "𝓀", txt)
        txt = re.sub(r"&#0*?120000;", "𝓀", txt)
        txt = re.sub(r"&kscr;", "𝓀", txt)

        # "U+1D4C1", "MATHEMATICAL SCRIPT SMALL L"
        txt = re.sub(r"&#x0*?1D4C1;", "𝓁", txt)
        txt = re.sub(r"&#0*?120001;", "𝓁", txt)
        txt = re.sub(r"&lscr;", "𝓁", txt)

        # "U+1D4C2", "MATHEMATICAL SCRIPT SMALL M"
        txt = re.sub(r"&#x0*?1D4C2;", "𝓂", txt)
        txt = re.sub(r"&#0*?120002;", "𝓂", txt)
        txt = re.sub(r"&mscr;", "𝓂", txt)

        # "U+1D4C3", "MATHEMATICAL SCRIPT SMALL N"
        txt = re.sub(r"&#x0*?1D4C3;", "𝓃", txt)
        txt = re.sub(r"&#0*?120003;", "𝓃", txt)
        txt = re.sub(r"&nscr;", "𝓃", txt)

        # "U+1D4C5", "MATHEMATICAL SCRIPT SMALL P"
        txt = re.sub(r"&#x0*?1D4C5;", "𝓅", txt)
        txt = re.sub(r"&#0*?120005;", "𝓅", txt)
        txt = re.sub(r"&pscr;", "𝓅", txt)

        # "U+1D4C6", "MATHEMATICAL SCRIPT SMALL Q"
        txt = re.sub(r"&#x0*?1D4C6;", "𝓆", txt)
        txt = re.sub(r"&#0*?120006;", "𝓆", txt)
        txt = re.sub(r"&qscr;", "𝓆", txt)

        # "U+1D4C7", "MATHEMATICAL SCRIPT SMALL R"
        txt = re.sub(r"&#x0*?1D4C7;", "𝓇", txt)
        txt = re.sub(r"&#0*?120007;", "𝓇", txt)
        txt = re.sub(r"&rscr;", "𝓇", txt)

        # "U+1D4C8", "MATHEMATICAL SCRIPT SMALL S"
        txt = re.sub(r"&#x0*?1D4C8;", "𝓈", txt)
        txt = re.sub(r"&#0*?120008;", "𝓈", txt)
        txt = re.sub(r"&sscr;", "𝓈", txt)

        # "U+1D4C9", "MATHEMATICAL SCRIPT SMALL T"
        txt = re.sub(r"&#x0*?1D4C9;", "𝓉", txt)
        txt = re.sub(r"&#0*?120009;", "𝓉", txt)
        txt = re.sub(r"&tscr;", "𝓉", txt)

        # "U+1D4CA", "MATHEMATICAL SCRIPT SMALL U"
        txt = re.sub(r"&#x0*?1D4CA;", "𝓊", txt)
        txt = re.sub(r"&#0*?120010;", "𝓊", txt)
        txt = re.sub(r"&uscr;", "𝓊", txt)

        # "U+1D4CB", "MATHEMATICAL SCRIPT SMALL V"
        txt = re.sub(r"&#x0*?1D4CB;", "𝓋", txt)
        txt = re.sub(r"&#0*?120011;", "𝓋", txt)
        txt = re.sub(r"&vscr;", "𝓋", txt)

        # "U+1D4CC", "MATHEMATICAL SCRIPT SMALL W"
        txt = re.sub(r"&#x0*?1D4CC;", "𝓌", txt)
        txt = re.sub(r"&#0*?120012;", "𝓌", txt)
        txt = re.sub(r"&wscr;", "𝓌", txt)

        # "U+1D4CD", "MATHEMATICAL SCRIPT SMALL X"
        txt = re.sub(r"&#x0*?1D4CD;", "𝓍", txt)
        txt = re.sub(r"&#0*?120013;", "𝓍", txt)
        txt = re.sub(r"&xscr;", "𝓍", txt)

        # "U+1D4CE", "MATHEMATICAL SCRIPT SMALL Y"
        txt = re.sub(r"&#x0*?1D4CE;", "𝓎", txt)
        txt = re.sub(r"&#0*?120014;", "𝓎", txt)
        txt = re.sub(r"&yscr;", "𝓎", txt)

        # "U+1D4CF", "MATHEMATICAL SCRIPT SMALL Z"
        txt = re.sub(r"&#x0*?1D4CF;", "𝓏", txt)
        txt = re.sub(r"&#0*?120015;", "𝓏", txt)
        txt = re.sub(r"&zscr;", "𝓏", txt)

        # "U+1D504", "MATHEMATICAL FRAKTUR CAPITAL A"
        txt = re.sub(r"&#x0*?1D504;", "𝔄", txt)
        txt = re.sub(r"&#0*?120068;", "𝔄", txt)
        txt = re.sub(r"&Afr;", "𝔄", txt)

        # "U+1D505", "MATHEMATICAL FRAKTUR CAPITAL B"
        txt = re.sub(r"&#x0*?1D505;", "𝔅", txt)
        txt = re.sub(r"&#0*?120069;", "𝔅", txt)
        txt = re.sub(r"&Bfr;", "𝔅", txt)

        # "U+1D507", "MATHEMATICAL FRAKTUR CAPITAL D"
        txt = re.sub(r"&#x0*?1D507;", "𝔇", txt)
        txt = re.sub(r"&#0*?120071;", "𝔇", txt)
        txt = re.sub(r"&Dfr;", "𝔇", txt)

        # "U+1D508", "MATHEMATICAL FRAKTUR CAPITAL E"
        txt = re.sub(r"&#x0*?1D508;", "𝔈", txt)
        txt = re.sub(r"&#0*?120072;", "𝔈", txt)
        txt = re.sub(r"&Efr;", "𝔈", txt)

        # "U+1D509", "MATHEMATICAL FRAKTUR CAPITAL F"
        txt = re.sub(r"&#x0*?1D509;", "𝔉", txt)
        txt = re.sub(r"&#0*?120073;", "𝔉", txt)
        txt = re.sub(r"&Ffr;", "𝔉", txt)

        # "U+1D50A", "MATHEMATICAL FRAKTUR CAPITAL G"
        txt = re.sub(r"&#x0*?1D50A;", "𝔊", txt)
        txt = re.sub(r"&#0*?120074;", "𝔊", txt)
        txt = re.sub(r"&Gfr;", "𝔊", txt)

        # "U+1D50D", "MATHEMATICAL FRAKTUR CAPITAL J"
        txt = re.sub(r"&#x0*?1D50D;", "𝔍", txt)
        txt = re.sub(r"&#0*?120077;", "𝔍", txt)
        txt = re.sub(r"&Jfr;", "𝔍", txt)

        # "U+1D50E", "MATHEMATICAL FRAKTUR CAPITAL K"
        txt = re.sub(r"&#x0*?1D50E;", "𝔎", txt)
        txt = re.sub(r"&#0*?120078;", "𝔎", txt)
        txt = re.sub(r"&Kfr;", "𝔎", txt)

        # "U+1D50F", "MATHEMATICAL FRAKTUR CAPITAL L"
        txt = re.sub(r"&#x0*?1D50F;", "𝔏", txt)
        txt = re.sub(r"&#0*?120079;", "𝔏", txt)
        txt = re.sub(r"&Lfr;", "𝔏", txt)

        # "U+1D510", "MATHEMATICAL FRAKTUR CAPITAL M"
        txt = re.sub(r"&#x0*?1D510;", "𝔐", txt)
        txt = re.sub(r"&#0*?120080;", "𝔐", txt)
        txt = re.sub(r"&Mfr;", "𝔐", txt)

        # "U+1D511", "MATHEMATICAL FRAKTUR CAPITAL N"
        txt = re.sub(r"&#x0*?1D511;", "𝔑", txt)
        txt = re.sub(r"&#0*?120081;", "𝔑", txt)
        txt = re.sub(r"&Nfr;", "𝔑", txt)

        # "U+1D512", "MATHEMATICAL FRAKTUR CAPITAL O"
        txt = re.sub(r"&#x0*?1D512;", "𝔒", txt)
        txt = re.sub(r"&#0*?120082;", "𝔒", txt)
        txt = re.sub(r"&Ofr;", "𝔒", txt)

        # "U+1D513", "MATHEMATICAL FRAKTUR CAPITAL P"
        txt = re.sub(r"&#x0*?1D513;", "𝔓", txt)
        txt = re.sub(r"&#0*?120083;", "𝔓", txt)
        txt = re.sub(r"&Pfr;", "𝔓", txt)

        # "U+1D514", "MATHEMATICAL FRAKTUR CAPITAL Q"
        txt = re.sub(r"&#x0*?1D514;", "𝔔", txt)
        txt = re.sub(r"&#0*?120084;", "𝔔", txt)
        txt = re.sub(r"&Qfr;", "𝔔", txt)

        # "U+1D516", "MATHEMATICAL FRAKTUR CAPITAL S"
        txt = re.sub(r"&#x0*?1D516;", "𝔖", txt)
        txt = re.sub(r"&#0*?120086;", "𝔖", txt)
        txt = re.sub(r"&Sfr;", "𝔖", txt)

        # "U+1D517", "MATHEMATICAL FRAKTUR CAPITAL T"
        txt = re.sub(r"&#x0*?1D517;", "𝔗", txt)
        txt = re.sub(r"&#0*?120087;", "𝔗", txt)
        txt = re.sub(r"&Tfr;", "𝔗", txt)

        # "U+1D518", "MATHEMATICAL FRAKTUR CAPITAL U"
        txt = re.sub(r"&#x0*?1D518;", "𝔘", txt)
        txt = re.sub(r"&#0*?120088;", "𝔘", txt)
        txt = re.sub(r"&Ufr;", "𝔘", txt)

        # "U+1D519", "MATHEMATICAL FRAKTUR CAPITAL V"
        txt = re.sub(r"&#x0*?1D519;", "𝔙", txt)
        txt = re.sub(r"&#0*?120089;", "𝔙", txt)
        txt = re.sub(r"&Vfr;", "𝔙", txt)

        # "U+1D51A", "MATHEMATICAL FRAKTUR CAPITAL W"
        txt = re.sub(r"&#x0*?1D51A;", "𝔚", txt)
        txt = re.sub(r"&#0*?120090;", "𝔚", txt)
        txt = re.sub(r"&Wfr;", "𝔚", txt)

        # "U+1D51B", "MATHEMATICAL FRAKTUR CAPITAL X"
        txt = re.sub(r"&#x0*?1D51B;", "𝔛", txt)
        txt = re.sub(r"&#0*?120091;", "𝔛", txt)
        txt = re.sub(r"&Xfr;", "𝔛", txt)

        # "U+1D51C", "MATHEMATICAL FRAKTUR CAPITAL Y"
        txt = re.sub(r"&#x0*?1D51C;", "𝔜", txt)
        txt = re.sub(r"&#0*?120092;", "𝔜", txt)
        txt = re.sub(r"&Yfr;", "𝔜", txt)

        # "U+1D51E", "MATHEMATICAL FRAKTUR SMALL A"
        txt = re.sub(r"&#x0*?1D51E;", "𝔞", txt)
        txt = re.sub(r"&#0*?120094;", "𝔞", txt)
        txt = re.sub(r"&afr;", "𝔞", txt)

        # "U+1D51F", "MATHEMATICAL FRAKTUR SMALL B"
        txt = re.sub(r"&#x0*?1D51F;", "𝔟", txt)
        txt = re.sub(r"&#0*?120095;", "𝔟", txt)
        txt = re.sub(r"&bfr;", "𝔟", txt)

        # "U+1D520", "MATHEMATICAL FRAKTUR SMALL C"
        txt = re.sub(r"&#x0*?1D520;", "𝔠", txt)
        txt = re.sub(r"&#0*?120096;", "𝔠", txt)
        txt = re.sub(r"&cfr;", "𝔠", txt)

        # "U+1D521", "MATHEMATICAL FRAKTUR SMALL D"
        txt = re.sub(r"&#x0*?1D521;", "𝔡", txt)
        txt = re.sub(r"&#0*?120097;", "𝔡", txt)
        txt = re.sub(r"&dfr;", "𝔡", txt)

        # "U+1D522", "MATHEMATICAL FRAKTUR SMALL E"
        txt = re.sub(r"&#x0*?1D522;", "𝔢", txt)
        txt = re.sub(r"&#0*?120098;", "𝔢", txt)
        txt = re.sub(r"&efr;", "𝔢", txt)

        # "U+1D523", "MATHEMATICAL FRAKTUR SMALL F"
        txt = re.sub(r"&#x0*?1D523;", "𝔣", txt)
        txt = re.sub(r"&#0*?120099;", "𝔣", txt)
        txt = re.sub(r"&ffr;", "𝔣", txt)

        # "U+1D524", "MATHEMATICAL FRAKTUR SMALL G"
        txt = re.sub(r"&#x0*?1D524;", "𝔤", txt)
        txt = re.sub(r"&#0*?120100;", "𝔤", txt)
        txt = re.sub(r"&gfr;", "𝔤", txt)

        # "U+1D525", "MATHEMATICAL FRAKTUR SMALL H"
        txt = re.sub(r"&#x0*?1D525;", "𝔥", txt)
        txt = re.sub(r"&#0*?120101;", "𝔥", txt)
        txt = re.sub(r"&hfr;", "𝔥", txt)

        # "U+1D526", "MATHEMATICAL FRAKTUR SMALL I"
        txt = re.sub(r"&#x0*?1D526;", "𝔦", txt)
        txt = re.sub(r"&#0*?120102;", "𝔦", txt)
        txt = re.sub(r"&ifr;", "𝔦", txt)

        # "U+1D527", "MATHEMATICAL FRAKTUR SMALL J"
        txt = re.sub(r"&#x0*?1D527;", "𝔧", txt)
        txt = re.sub(r"&#0*?120103;", "𝔧", txt)
        txt = re.sub(r"&jfr;", "𝔧", txt)

        # "U+1D528", "MATHEMATICAL FRAKTUR SMALL K"
        txt = re.sub(r"&#x0*?1D528;", "𝔨", txt)
        txt = re.sub(r"&#0*?120104;", "𝔨", txt)
        txt = re.sub(r"&kfr;", "𝔨", txt)

        # "U+1D529", "MATHEMATICAL FRAKTUR SMALL L"
        txt = re.sub(r"&#x0*?1D529;", "𝔩", txt)
        txt = re.sub(r"&#0*?120105;", "𝔩", txt)
        txt = re.sub(r"&lfr;", "𝔩", txt)

        # "U+1D52A", "MATHEMATICAL FRAKTUR SMALL M"
        txt = re.sub(r"&#x0*?1D52A;", "𝔪", txt)
        txt = re.sub(r"&#0*?120106;", "𝔪", txt)
        txt = re.sub(r"&mfr;", "𝔪", txt)

        # "U+1D52B", "MATHEMATICAL FRAKTUR SMALL N"
        txt = re.sub(r"&#x0*?1D52B;", "𝔫", txt)
        txt = re.sub(r"&#0*?120107;", "𝔫", txt)
        txt = re.sub(r"&nfr;", "𝔫", txt)

        # "U+1D52C", "MATHEMATICAL FRAKTUR SMALL O"
        txt = re.sub(r"&#x0*?1D52C;", "𝔬", txt)
        txt = re.sub(r"&#0*?120108;", "𝔬", txt)
        txt = re.sub(r"&ofr;", "𝔬", txt)

        # "U+1D52D", "MATHEMATICAL FRAKTUR SMALL P"
        txt = re.sub(r"&#x0*?1D52D;", "𝔭", txt)
        txt = re.sub(r"&#0*?120109;", "𝔭", txt)
        txt = re.sub(r"&pfr;", "𝔭", txt)

        # "U+1D52E", "MATHEMATICAL FRAKTUR SMALL Q"
        txt = re.sub(r"&#x0*?1D52E;", "𝔮", txt)
        txt = re.sub(r"&#0*?120110;", "𝔮", txt)
        txt = re.sub(r"&qfr;", "𝔮", txt)

        # "U+1D52F", "MATHEMATICAL FRAKTUR SMALL R"
        txt = re.sub(r"&#x0*?1D52F;", "𝔯", txt)
        txt = re.sub(r"&#0*?120111;", "𝔯", txt)
        txt = re.sub(r"&rfr;", "𝔯", txt)

        # "U+1D530", "MATHEMATICAL FRAKTUR SMALL S"
        txt = re.sub(r"&#x0*?1D530;", "𝔰", txt)
        txt = re.sub(r"&#0*?120112;", "𝔰", txt)
        txt = re.sub(r"&sfr;", "𝔰", txt)

        # "U+1D531", "MATHEMATICAL FRAKTUR SMALL T"
        txt = re.sub(r"&#x0*?1D531;", "𝔱", txt)
        txt = re.sub(r"&#0*?120113;", "𝔱", txt)
        txt = re.sub(r"&tfr;", "𝔱", txt)

        # "U+1D532", "MATHEMATICAL FRAKTUR SMALL U"
        txt = re.sub(r"&#x0*?1D532;", "𝔲", txt)
        txt = re.sub(r"&#0*?120114;", "𝔲", txt)
        txt = re.sub(r"&ufr;", "𝔲", txt)

        # "U+1D533", "MATHEMATICAL FRAKTUR SMALL V"
        txt = re.sub(r"&#x0*?1D533;", "𝔳", txt)
        txt = re.sub(r"&#0*?120115;", "𝔳", txt)
        txt = re.sub(r"&vfr;", "𝔳", txt)

        # "U+1D534", "MATHEMATICAL FRAKTUR SMALL W"
        txt = re.sub(r"&#x0*?1D534;", "𝔴", txt)
        txt = re.sub(r"&#0*?120116;", "𝔴", txt)
        txt = re.sub(r"&wfr;", "𝔴", txt)

        # "U+1D535", "MATHEMATICAL FRAKTUR SMALL X"
        txt = re.sub(r"&#x0*?1D535;", "𝔵", txt)
        txt = re.sub(r"&#0*?120117;", "𝔵", txt)
        txt = re.sub(r"&xfr;", "𝔵", txt)

        # "U+1D536", "MATHEMATICAL FRAKTUR SMALL Y"
        txt = re.sub(r"&#x0*?1D536;", "𝔶", txt)
        txt = re.sub(r"&#0*?120118;", "𝔶", txt)
        txt = re.sub(r"&yfr;", "𝔶", txt)

        # "U+1D537", "MATHEMATICAL FRAKTUR SMALL Z"
        txt = re.sub(r"&#x0*?1D537;", "𝔷", txt)
        txt = re.sub(r"&#0*?120119;", "𝔷", txt)
        txt = re.sub(r"&zfr;", "𝔷", txt)

        # "U+1D538", "MATHEMATICAL DOUBLE-STRUCK CAPITAL A"
        txt = re.sub(r"&#x0*?1D538;", "𝔸", txt)
        txt = re.sub(r"&#0*?120120;", "𝔸", txt)
        txt = re.sub(r"&Aopf;", "𝔸", txt)

        # "U+1D539", "MATHEMATICAL DOUBLE-STRUCK CAPITAL B"
        txt = re.sub(r"&#x0*?1D539;", "𝔹", txt)
        txt = re.sub(r"&#0*?120121;", "𝔹", txt)
        txt = re.sub(r"&Bopf;", "𝔹", txt)

        # "U+1D53B", "MATHEMATICAL DOUBLE-STRUCK CAPITAL D"
        txt = re.sub(r"&#x0*?1D53B;", "𝔻", txt)
        txt = re.sub(r"&#0*?120123;", "𝔻", txt)
        txt = re.sub(r"&Dopf;", "𝔻", txt)

        # "U+1D53C", "MATHEMATICAL DOUBLE-STRUCK CAPITAL E"
        txt = re.sub(r"&#x0*?1D53C;", "𝔼", txt)
        txt = re.sub(r"&#0*?120124;", "𝔼", txt)
        txt = re.sub(r"&Eopf;", "𝔼", txt)

        # "U+1D53D", "MATHEMATICAL DOUBLE-STRUCK CAPITAL F"
        txt = re.sub(r"&#x0*?1D53D;", "𝔽", txt)
        txt = re.sub(r"&#0*?120125;", "𝔽", txt)
        txt = re.sub(r"&Fopf;", "𝔽", txt)

        # "U+1D53E", "MATHEMATICAL DOUBLE-STRUCK CAPITAL G"
        txt = re.sub(r"&#x0*?1D53E;", "𝔾", txt)
        txt = re.sub(r"&#0*?120126;", "𝔾", txt)
        txt = re.sub(r"&Gopf;", "𝔾", txt)

        # "U+1D540", "MATHEMATICAL DOUBLE-STRUCK CAPITAL I"
        txt = re.sub(r"&#x0*?1D540;", "𝕀", txt)
        txt = re.sub(r"&#0*?120128;", "𝕀", txt)
        txt = re.sub(r"&Iopf;", "𝕀", txt)

        # "U+1D541", "MATHEMATICAL DOUBLE-STRUCK CAPITAL J"
        txt = re.sub(r"&#x0*?1D541;", "𝕁", txt)
        txt = re.sub(r"&#0*?120129;", "𝕁", txt)
        txt = re.sub(r"&Jopf;", "𝕁", txt)

        # "U+1D542", "MATHEMATICAL DOUBLE-STRUCK CAPITAL K"
        txt = re.sub(r"&#x0*?1D542;", "𝕂", txt)
        txt = re.sub(r"&#0*?120130;", "𝕂", txt)
        txt = re.sub(r"&Kopf;", "𝕂", txt)

        # "U+1D543", "MATHEMATICAL DOUBLE-STRUCK CAPITAL L"
        txt = re.sub(r"&#x0*?1D543;", "𝕃", txt)
        txt = re.sub(r"&#0*?120131;", "𝕃", txt)
        txt = re.sub(r"&Lopf;", "𝕃", txt)

        # "U+1D544", "MATHEMATICAL DOUBLE-STRUCK CAPITAL M"
        txt = re.sub(r"&#x0*?1D544;", "𝕄", txt)
        txt = re.sub(r"&#0*?120132;", "𝕄", txt)
        txt = re.sub(r"&Mopf;", "𝕄", txt)

        # "U+1D546", "MATHEMATICAL DOUBLE-STRUCK CAPITAL O"
        txt = re.sub(r"&#x0*?1D546;", "𝕆", txt)
        txt = re.sub(r"&#0*?120134;", "𝕆", txt)
        txt = re.sub(r"&Oopf;", "𝕆", txt)

        # "U+1D54A", "MATHEMATICAL DOUBLE-STRUCK CAPITAL S"
        txt = re.sub(r"&#x0*?1D54A;", "𝕊", txt)
        txt = re.sub(r"&#0*?120138;", "𝕊", txt)
        txt = re.sub(r"&Sopf;", "𝕊", txt)

        # "U+1D54B", "MATHEMATICAL DOUBLE-STRUCK CAPITAL T"
        txt = re.sub(r"&#x0*?1D54B;", "𝕋", txt)
        txt = re.sub(r"&#0*?120139;", "𝕋", txt)
        txt = re.sub(r"&Topf;", "𝕋", txt)

        # "U+1D54C", "MATHEMATICAL DOUBLE-STRUCK CAPITAL U"
        txt = re.sub(r"&#x0*?1D54C;", "𝕌", txt)
        txt = re.sub(r"&#0*?120140;", "𝕌", txt)
        txt = re.sub(r"&Uopf;", "𝕌", txt)

        # "U+1D54D", "MATHEMATICAL DOUBLE-STRUCK CAPITAL V"
        txt = re.sub(r"&#x0*?1D54D;", "𝕍", txt)
        txt = re.sub(r"&#0*?120141;", "𝕍", txt)
        txt = re.sub(r"&Vopf;", "𝕍", txt)

        # "U+1D54E", "MATHEMATICAL DOUBLE-STRUCK CAPITAL W"
        txt = re.sub(r"&#x0*?1D54E;", "𝕎", txt)
        txt = re.sub(r"&#0*?120142;", "𝕎", txt)
        txt = re.sub(r"&Wopf;", "𝕎", txt)

        # "U+1D54F", "MATHEMATICAL DOUBLE-STRUCK CAPITAL X"
        txt = re.sub(r"&#x0*?1D54F;", "𝕏", txt)
        txt = re.sub(r"&#0*?120143;", "𝕏", txt)
        txt = re.sub(r"&Xopf;", "𝕏", txt)

        # "U+1D550", "MATHEMATICAL DOUBLE-STRUCK CAPITAL Y"
        txt = re.sub(r"&#x0*?1D550;", "𝕐", txt)
        txt = re.sub(r"&#0*?120144;", "𝕐", txt)
        txt = re.sub(r"&Yopf;", "𝕐", txt)

        # "U+1D552", "MATHEMATICAL DOUBLE-STRUCK SMALL A"
        txt = re.sub(r"&#x0*?1D552;", "𝕒", txt)
        txt = re.sub(r"&#0*?120146;", "𝕒", txt)
        txt = re.sub(r"&aopf;", "𝕒", txt)

        # "U+1D553", "MATHEMATICAL DOUBLE-STRUCK SMALL B"
        txt = re.sub(r"&#x0*?1D553;", "𝕓", txt)
        txt = re.sub(r"&#0*?120147;", "𝕓", txt)
        txt = re.sub(r"&bopf;", "𝕓", txt)

        # "U+1D554", "MATHEMATICAL DOUBLE-STRUCK SMALL C"
        txt = re.sub(r"&#x0*?1D554;", "𝕔", txt)
        txt = re.sub(r"&#0*?120148;", "𝕔", txt)
        txt = re.sub(r"&copf;", "𝕔", txt)

        # "U+1D555", "MATHEMATICAL DOUBLE-STRUCK SMALL D"
        txt = re.sub(r"&#x0*?1D555;", "𝕕", txt)
        txt = re.sub(r"&#0*?120149;", "𝕕", txt)
        txt = re.sub(r"&dopf;", "𝕕", txt)

        # "U+1D556", "MATHEMATICAL DOUBLE-STRUCK SMALL E"
        txt = re.sub(r"&#x0*?1D556;", "𝕖", txt)
        txt = re.sub(r"&#0*?120150;", "𝕖", txt)
        txt = re.sub(r"&eopf;", "𝕖", txt)

        # "U+1D557", "MATHEMATICAL DOUBLE-STRUCK SMALL F"
        txt = re.sub(r"&#x0*?1D557;", "𝕗", txt)
        txt = re.sub(r"&#0*?120151;", "𝕗", txt)
        txt = re.sub(r"&fopf;", "𝕗", txt)

        # "U+1D558", "MATHEMATICAL DOUBLE-STRUCK SMALL G"
        txt = re.sub(r"&#x0*?1D558;", "𝕘", txt)
        txt = re.sub(r"&#0*?120152;", "𝕘", txt)
        txt = re.sub(r"&gopf;", "𝕘", txt)

        # "U+1D559", "MATHEMATICAL DOUBLE-STRUCK SMALL H"
        txt = re.sub(r"&#x0*?1D559;", "𝕙", txt)
        txt = re.sub(r"&#0*?120153;", "𝕙", txt)
        txt = re.sub(r"&hopf;", "𝕙", txt)

        # "U+1D55A", "MATHEMATICAL DOUBLE-STRUCK SMALL I"
        txt = re.sub(r"&#x0*?1D55A;", "𝕚", txt)
        txt = re.sub(r"&#0*?120154;", "𝕚", txt)
        txt = re.sub(r"&iopf;", "𝕚", txt)

        # "U+1D55B", "MATHEMATICAL DOUBLE-STRUCK SMALL J"
        txt = re.sub(r"&#x0*?1D55B;", "𝕛", txt)
        txt = re.sub(r"&#0*?120155;", "𝕛", txt)
        txt = re.sub(r"&jopf;", "𝕛", txt)

        # "U+1D55C", "MATHEMATICAL DOUBLE-STRUCK SMALL K"
        txt = re.sub(r"&#x0*?1D55C;", "𝕜", txt)
        txt = re.sub(r"&#0*?120156;", "𝕜", txt)
        txt = re.sub(r"&kopf;", "𝕜", txt)

        # "U+1D55D", "MATHEMATICAL DOUBLE-STRUCK SMALL L"
        txt = re.sub(r"&#x0*?1D55D;", "𝕝", txt)
        txt = re.sub(r"&#0*?120157;", "𝕝", txt)
        txt = re.sub(r"&lopf;", "𝕝", txt)

        # "U+1D55E", "MATHEMATICAL DOUBLE-STRUCK SMALL M"
        txt = re.sub(r"&#x0*?1D55E;", "𝕞", txt)
        txt = re.sub(r"&#0*?120158;", "𝕞", txt)
        txt = re.sub(r"&mopf;", "𝕞", txt)

        # "U+1D55F", "MATHEMATICAL DOUBLE-STRUCK SMALL N"
        txt = re.sub(r"&#x0*?1D55F;", "𝕟", txt)
        txt = re.sub(r"&#0*?120159;", "𝕟", txt)
        txt = re.sub(r"&nopf;", "𝕟", txt)

        # "U+1D560", "MATHEMATICAL DOUBLE-STRUCK SMALL O"
        txt = re.sub(r"&#x0*?1D560;", "𝕠", txt)
        txt = re.sub(r"&#0*?120160;", "𝕠", txt)
        txt = re.sub(r"&oopf;", "𝕠", txt)

        # "U+1D561", "MATHEMATICAL DOUBLE-STRUCK SMALL P"
        txt = re.sub(r"&#x0*?1D561;", "𝕡", txt)
        txt = re.sub(r"&#0*?120161;", "𝕡", txt)
        txt = re.sub(r"&popf;", "𝕡", txt)

        # "U+1D562", "MATHEMATICAL DOUBLE-STRUCK SMALL Q"
        txt = re.sub(r"&#x0*?1D562;", "𝕢", txt)
        txt = re.sub(r"&#0*?120162;", "𝕢", txt)
        txt = re.sub(r"&qopf;", "𝕢", txt)

        # "U+1D563", "MATHEMATICAL DOUBLE-STRUCK SMALL R"
        txt = re.sub(r"&#x0*?1D563;", "𝕣", txt)
        txt = re.sub(r"&#0*?120163;", "𝕣", txt)
        txt = re.sub(r"&ropf;", "𝕣", txt)

        # "U+1D564", "MATHEMATICAL DOUBLE-STRUCK SMALL S"
        txt = re.sub(r"&#x0*?1D564;", "𝕤", txt)
        txt = re.sub(r"&#0*?120164;", "𝕤", txt)
        txt = re.sub(r"&sopf;", "𝕤", txt)

        # "U+1D565", "MATHEMATICAL DOUBLE-STRUCK SMALL T"
        txt = re.sub(r"&#x0*?1D565;", "𝕥", txt)
        txt = re.sub(r"&#0*?120165;", "𝕥", txt)
        txt = re.sub(r"&topf;", "𝕥", txt)

        # "U+1D566", "MATHEMATICAL DOUBLE-STRUCK SMALL U"
        txt = re.sub(r"&#x0*?1D566;", "𝕦", txt)
        txt = re.sub(r"&#0*?120166;", "𝕦", txt)
        txt = re.sub(r"&uopf;", "𝕦", txt)

        # "U+1D567", "MATHEMATICAL DOUBLE-STRUCK SMALL V"
        txt = re.sub(r"&#x0*?1D567;", "𝕧", txt)
        txt = re.sub(r"&#0*?120167;", "𝕧", txt)
        txt = re.sub(r"&vopf;", "𝕧", txt)

        # "U+1D568", "MATHEMATICAL DOUBLE-STRUCK SMALL W"
        txt = re.sub(r"&#x0*?1D568;", "𝕨", txt)
        txt = re.sub(r"&#0*?120168;", "𝕨", txt)
        txt = re.sub(r"&wopf;", "𝕨", txt)

        # "U+1D569", "MATHEMATICAL DOUBLE-STRUCK SMALL X"
        txt = re.sub(r"&#x0*?1D569;", "𝕩", txt)
        txt = re.sub(r"&#0*?120169;", "𝕩", txt)
        txt = re.sub(r"&xopf;", "𝕩", txt)

        # "U+1D56A", "MATHEMATICAL DOUBLE-STRUCK SMALL Y"
        txt = re.sub(r"&#x0*?1D56A;", "𝕪", txt)
        txt = re.sub(r"&#0*?120170;", "𝕪", txt)
        txt = re.sub(r"&yopf;", "𝕪", txt)

        # "U+1D56B", "MATHEMATICAL DOUBLE-STRUCK SMALL Z"
        txt = re.sub(r"&#x0*?1D56B;", "𝕫", txt)
        txt = re.sub(r"&#0*?120171;", "𝕫", txt)
        txt = re.sub(r"&zopf;", "𝕫", txt)

        return txt

    """
    入力される文字列内の文字実体参照を文字や記号に置きかえます。
    :param source: 置きかえられる文字列の配列。
    :return: 置きかえられた文字列の配列。
    """

    @staticmethod
    def convert_from_all(sources: List[str]) -> List[str]:
        for i in range(len(sources)):
            sources[i] = CharacterEntityReference.convert_from(sources[i])

        return sources

    """
    入力される文字列内の文字や記号を文字実体参照に置きかえます。ベーシック版です。
    :param source: 置きかえられる文字列。
    :return: 置きかえられた文字列。
    """

    @staticmethod
    def convert_to_basic(source: str) -> str:
        txt = source

        # "U+00026", "AMPERSAND"
        txt = txt.replace("&", "&amp;")

        # "U+00022", "QUOTATION MARK"
        txt = txt.replace('"', "&quot;")

        # "U+00027", "APOSTROPHE"
        txt = txt.replace("'", "&apos;")

        # "U+0003C", "LESS-THAN SIGN"
        txt = txt.replace("<", "&lt;")

        # "U+0003E", "GREATER-THAN SIGN"
        txt = txt.replace(">", "&gt;")

        # "U+000A0", "NO-BREAK SPACE"
        txt = txt.replace(" ", "&nbsp;")

        # "U+000A1", "INVERTED EXCLAMATION MARK"
        txt = txt.replace("¡", "&iexcl;")

        # "U+000A2", "CENT SIGN"
        txt = txt.replace("¢", "&cent;")

        # "U+000A3", "POUND SIGN"
        txt = txt.replace("£", "&pound;")

        # "U+000A4", "CURRENCY SIGN"
        txt = txt.replace("¤", "&curren;")

        # "U+000A5", "YEN SIGN"
        txt = txt.replace("¥", "&yen;")

        # "U+000A6", "BROKEN BAR"
        txt = txt.replace("¦", "&brvbar;")

        # "U+000A7", "SECTION SIGN"
        txt = txt.replace("§", "&sect;")

        # "U+000A8", "DIAERESIS"
        txt = txt.replace("¨", "&Dot;")

        # "U+000A9", "COPYRIGHT SIGN"
        txt = txt.replace("©", "&copy;")

        # "U+000AA", "FEMININE ORDINAL INDICATOR"
        txt = txt.replace("ª", "&ordf;")

        # "U+000AB", "LEFT-POINTING DOUBLE ANGLE QUOTATION MARK"
        txt = txt.replace("«", "&laquo;")

        # "U+000AC", "NOT SIGN"
        txt = txt.replace("¬", "&not;")

        # "U+000AD", "SOFT HYPHEN"
        txt = txt.replace("­", "&shy;")

        # "U+000AE", "REGISTERED SIGN"
        txt = txt.replace("®", "&reg;")

        # "U+000AF", "MACRON"
        txt = txt.replace("¯", "&macr;")

        # "U+000B0", "DEGREE SIGN"
        txt = txt.replace("°", "&deg;")

        # "U+000B1", "PLUS-MINUS SIGN"
        txt = txt.replace("±", "&plusmn;")

        # "U+000B2", "SUPERSCRIPT TWO"
        txt = txt.replace("²", "&sup2;")

        # "U+000B3", "SUPERSCRIPT THREE"
        txt = txt.replace("³", "&sup3;")

        # "U+000B4", "ACUTE ACCENT"
        txt = txt.replace("´", "&acute;")

        # "U+000B5", "MICRO SIGN"
        txt = txt.replace("µ", "&micro;")

        # "U+000B6", "PILCROW SIGN"
        txt = txt.replace("¶", "&para;")

        # "U+000B7", "MIDDLE DOT"
        txt = txt.replace("·", "&middot;")

        # "U+000B8", "CEDILLA"
        txt = txt.replace("¸", "&cedil;")

        # "U+000B9", "SUPERSCRIPT ONE"
        txt = txt.replace("¹", "&sup1;")

        # "U+000BA", "MASCULINE ORDINAL INDICATOR"
        txt = txt.replace("º", "&ordm;")

        # "U+000BB", "RIGHT-POINTING DOUBLE ANGLE QUOTATION MARK"
        txt = txt.replace("»", "&raquo;")

        # "U+000BC", "VULGAR FRACTION ONE QUARTER"
        txt = txt.replace("¼", "&frac14;")

        # "U+000BD", "VULGAR FRACTION ONE HALF"
        txt = txt.replace("½", "&frac12;")

        # "U+000BE", "VULGAR FRACTION THREE QUARTERS"
        txt = txt.replace("¾", "&frac34;")

        # "U+000BF", "INVERTED QUESTION MARK"
        txt = txt.replace("¿", "&iquest;")

        # "U+000C0", "LATIN CAPITAL LETTER A WITH GRAVE"
        txt = txt.replace("À", "&Agrave;")

        # "U+000C1", "LATIN CAPITAL LETTER A WITH ACUTE"
        txt = txt.replace("Á", "&Aacute;")

        # "U+000C2", "LATIN CAPITAL LETTER A WITH CIRCUMFLEX"
        txt = txt.replace("Â", "&Acirc;")

        # "U+000C3", "LATIN CAPITAL LETTER A WITH TILDE"
        txt = txt.replace("Ã", "&Atilde;")

        # "U+000C4", "LATIN CAPITAL LETTER A WITH DIAERESIS"
        txt = txt.replace("Ä", "&Auml;")

        # "U+000C5", "LATIN CAPITAL LETTER A WITH RING ABOVE"
        txt = txt.replace("Å", "&Aring;")

        # "U+000C6", "LATIN CAPITAL LETTER AE"
        txt = txt.replace("Æ", "&AElig;")

        # "U+000C7", "LATIN CAPITAL LETTER C WITH CEDILLA"
        txt = txt.replace("Ç", "&Ccedil;")

        # "U+000C8", "LATIN CAPITAL LETTER E WITH GRAVE"
        txt = txt.replace("È", "&Egrave;")

        # "U+000C9", "LATIN CAPITAL LETTER E WITH ACUTE"
        txt = txt.replace("É", "&Eacute;")

        # "U+000CA", "LATIN CAPITAL LETTER E WITH CIRCUMFLEX"
        txt = txt.replace("Ê", "&Ecirc;")

        # "U+000CB", "LATIN CAPITAL LETTER E WITH DIAERESIS"
        txt = txt.replace("Ë", "&Euml;")

        # "U+000CC", "LATIN CAPITAL LETTER I WITH GRAVE"
        txt = txt.replace("Ì", "&Igrave;")

        # "U+000CD", "LATIN CAPITAL LETTER I WITH ACUTE"
        txt = txt.replace("Í", "&Iacute;")

        # "U+000CE", "LATIN CAPITAL LETTER I WITH CIRCUMFLEX"
        txt = txt.replace("Î", "&Icirc;")

        # "U+000CF", "LATIN CAPITAL LETTER I WITH DIAERESIS"
        txt = txt.replace("Ï", "&Iuml;")

        # "U+000D0", "LATIN CAPITAL LETTER ETH"
        txt = txt.replace("Ð", "&ETH;")

        # "U+000D1", "LATIN CAPITAL LETTER N WITH TILDE"
        txt = txt.replace("Ñ", "&Ntilde;")

        # "U+000D2", "LATIN CAPITAL LETTER O WITH GRAVE"
        txt = txt.replace("Ò", "&Ograve;")

        # "U+000D3", "LATIN CAPITAL LETTER O WITH ACUTE"
        txt = txt.replace("Ó", "&Oacute;")

        # "U+000D4", "LATIN CAPITAL LETTER O WITH CIRCUMFLEX"
        txt = txt.replace("Ô", "&Ocirc;")

        # "U+000D5", "LATIN CAPITAL LETTER O WITH TILDE"
        txt = txt.replace("Õ", "&Otilde;")

        # "U+000D6", "LATIN CAPITAL LETTER O WITH DIAERESIS"
        txt = txt.replace("Ö", "&Ouml;")

        # "U+000D7", "MULTIPLICATION SIGN"
        txt = txt.replace("×", "&times;")

        # "U+000D8", "LATIN CAPITAL LETTER O WITH STROKE"
        txt = txt.replace("Ø", "&Oslash;")

        # "U+000D9", "LATIN CAPITAL LETTER U WITH GRAVE"
        txt = txt.replace("Ù", "&Ugrave;")

        # "U+000DA", "LATIN CAPITAL LETTER U WITH ACUTE"
        txt = txt.replace("Ú", "&Uacute;")

        # "U+000DB", "LATIN CAPITAL LETTER U WITH CIRCUMFLEX"
        txt = txt.replace("Û", "&Ucirc;")

        # "U+000DC", "LATIN CAPITAL LETTER U WITH DIAERESIS"
        txt = txt.replace("Ü", "&Uuml;")

        # "U+000DD", "LATIN CAPITAL LETTER Y WITH ACUTE"
        txt = txt.replace("Ý", "&Yacute;")

        # "U+000DE", "LATIN CAPITAL LETTER THORN"
        txt = txt.replace("Þ", "&THORN;")

        # "U+000DF", "LATIN SMALL LETTER SHARP S"
        txt = txt.replace("ß", "&szlig;")

        # "U+000E0", "LATIN SMALL LETTER A WITH GRAVE"
        txt = txt.replace("à", "&agrave;")

        # "U+000E1", "LATIN SMALL LETTER A WITH ACUTE"
        txt = txt.replace("á", "&aacute;")

        # "U+000E2", "LATIN SMALL LETTER A WITH CIRCUMFLEX"
        txt = txt.replace("â", "&acirc;")

        # "U+000E3", "LATIN SMALL LETTER A WITH TILDE"
        txt = txt.replace("ã", "&atilde;")

        # "U+000E4", "LATIN SMALL LETTER A WITH DIAERESIS"
        txt = txt.replace("ä", "&auml;")

        # "U+000E5", "LATIN SMALL LETTER A WITH RING ABOVE"
        txt = txt.replace("å", "&aring;")

        # "U+000E6", "LATIN SMALL LETTER AE"
        txt = txt.replace("æ", "&aelig;")

        # "U+000E7", "LATIN SMALL LETTER C WITH CEDILLA"
        txt = txt.replace("ç", "&ccedil;")

        # "U+000E8", "LATIN SMALL LETTER E WITH GRAVE"
        txt = txt.replace("è", "&egrave;")

        # "U+000E9", "LATIN SMALL LETTER E WITH ACUTE"
        txt = txt.replace("é", "&eacute;")

        # "U+000EA", "LATIN SMALL LETTER E WITH CIRCUMFLEX"
        txt = txt.replace("ê", "&ecirc;")

        # "U+000EB", "LATIN SMALL LETTER E WITH DIAERESIS"
        txt = txt.replace("ë", "&euml;")

        # "U+000EC", "LATIN SMALL LETTER I WITH GRAVE"
        txt = txt.replace("ì", "&igrave;")

        # "U+000ED", "LATIN SMALL LETTER I WITH ACUTE"
        txt = txt.replace("í", "&iacute;")

        # "U+000EE", "LATIN SMALL LETTER I WITH CIRCUMFLEX"
        txt = txt.replace("î", "&icirc;")

        # "U+000EF", "LATIN SMALL LETTER I WITH DIAERESIS"
        txt = txt.replace("ï", "&iuml;")

        # "U+000F0", "LATIN SMALL LETTER ETH"
        txt = txt.replace("ð", "&eth;")

        # "U+000F1", "LATIN SMALL LETTER N WITH TILDE"
        txt = txt.replace("ñ", "&ntilde;")

        # "U+000F2", "LATIN SMALL LETTER O WITH GRAVE"
        txt = txt.replace("ò", "&ograve;")

        # "U+000F3", "LATIN SMALL LETTER O WITH ACUTE"
        txt = txt.replace("ó", "&oacute;")

        # "U+000F4", "LATIN SMALL LETTER O WITH CIRCUMFLEX"
        txt = txt.replace("ô", "&ocirc;")

        # "U+000F5", "LATIN SMALL LETTER O WITH TILDE"
        txt = txt.replace("õ", "&otilde;")

        # "U+000F6", "LATIN SMALL LETTER O WITH DIAERESIS"
        txt = txt.replace("ö", "&ouml;")

        # "U+000F7", "DIVISION SIGN"
        txt = txt.replace("÷", "&divide;")

        # "U+000F8", "LATIN SMALL LETTER O WITH STROKE"
        txt = txt.replace("ø", "&oslash;")

        # "U+000F9", "LATIN SMALL LETTER U WITH GRAVE"
        txt = txt.replace("ù", "&ugrave;")

        # "U+000FA", "LATIN SMALL LETTER U WITH ACUTE"
        txt = txt.replace("ú", "&uacute;")

        # "U+000FB", "LATIN SMALL LETTER U WITH CIRCUMFLEX"
        txt = txt.replace("û", "&ucirc;")

        # "U+000FC", "LATIN SMALL LETTER U WITH DIAERESIS"
        txt = txt.replace("ü", "&uuml;")

        # "U+000FD", "LATIN SMALL LETTER Y WITH ACUTE"
        txt = txt.replace("ý", "&yacute;")

        # "U+000FE", "LATIN SMALL LETTER THORN"
        txt = txt.replace("þ", "&thorn;")

        # "U+000FF", "LATIN SMALL LETTER Y WITH DIAERESIS"
        txt = txt.replace("ÿ", "&yuml;")

        # "U+00152", "LATIN CAPITAL LIGATURE OE"
        txt = txt.replace("Œ", "&OElig;")

        # "U+00153", "LATIN SMALL LIGATURE OE"
        txt = txt.replace("œ", "&oelig;")

        # "U+00160", "LATIN CAPITAL LETTER S WITH CARON"
        txt = txt.replace("Š", "&Scaron;")

        # "U+00161", "LATIN SMALL LETTER S WITH CARON"
        txt = txt.replace("š", "&scaron;")

        # "U+00178", "LATIN CAPITAL LETTER Y WITH DIAERESIS"
        txt = txt.replace("Ÿ", "&Yuml;")

        # "U+00192", "LATIN SMALL LETTER F WITH HOOK"
        txt = txt.replace("ƒ", "&fnof;")

        # "U+002C6", "MODIFIER LETTER CIRCUMFLEX ACCENT"
        txt = txt.replace("ˆ", "&circ;")

        # "U+002DC", "SMALL TILDE"
        txt = txt.replace("˜", "&tilde;")

        # "U+00391", "GREEK CAPITAL LETTER ALPHA"
        txt = txt.replace("Α", "&Alpha;")

        # "U+00392", "GREEK CAPITAL LETTER BETA"
        txt = txt.replace("Β", "&Beta;")

        # "U+00393", "GREEK CAPITAL LETTER GAMMA"
        txt = txt.replace("Γ", "&Gamma;")

        # "U+00394", "GREEK CAPITAL LETTER DELTA"
        txt = txt.replace("Δ", "&Delta;")

        # "U+00395", "GREEK CAPITAL LETTER EPSILON"
        txt = txt.replace("Ε", "&Epsilon;")

        # "U+00396", "GREEK CAPITAL LETTER ZETA"
        txt = txt.replace("Ζ", "&Zeta;")

        # "U+00397", "GREEK CAPITAL LETTER ETA"
        txt = txt.replace("Η", "&Eta;")

        # "U+00398", "GREEK CAPITAL LETTER THETA"
        txt = txt.replace("Θ", "&Theta;")

        # "U+00399", "GREEK CAPITAL LETTER IOTA"
        txt = txt.replace("Ι", "&Iota;")

        # "U+0039A", "GREEK CAPITAL LETTER KAPPA"
        txt = txt.replace("Κ", "&Kappa;")

        # "U+0039B", "GREEK CAPITAL LETTER LAMDA"
        txt = txt.replace("Λ", "&Lambda;")

        # "U+0039C", "GREEK CAPITAL LETTER MU"
        txt = txt.replace("Μ", "&Mu;")

        # "U+0039D", "GREEK CAPITAL LETTER NU"
        txt = txt.replace("Ν", "&Nu;")

        # "U+0039E", "GREEK CAPITAL LETTER XI"
        txt = txt.replace("Ξ", "&Xi;")

        # "U+0039F", "GREEK CAPITAL LETTER OMICRON"
        txt = txt.replace("Ο", "&Omicron;")

        # "U+003A0", "GREEK CAPITAL LETTER PI"
        txt = txt.replace("Π", "&Pi;")

        # "U+003A1", "GREEK CAPITAL LETTER RHO"
        txt = txt.replace("Ρ", "&Rho;")

        # "U+003A3", "GREEK CAPITAL LETTER SIGMA"
        txt = txt.replace("Σ", "&Sigma;")

        # "U+003A4", "GREEK CAPITAL LETTER TAU"
        txt = txt.replace("Τ", "&Tau;")

        # "U+003A5", "GREEK CAPITAL LETTER UPSILON"
        txt = txt.replace("Υ", "&Upsilon;")

        # "U+003A6", "GREEK CAPITAL LETTER PHI"
        txt = txt.replace("Φ", "&Phi;")

        # "U+003A7", "GREEK CAPITAL LETTER CHI"
        txt = txt.replace("Χ", "&Chi;")

        # "U+003A8", "GREEK CAPITAL LETTER PSI"
        txt = txt.replace("Ψ", "&Psi;")

        # "U+003A9", "GREEK CAPITAL LETTER OMEGA"
        txt = txt.replace("Ω", "&Omega;")

        # "U+003B1", "GREEK SMALL LETTER ALPHA"
        txt = txt.replace("α", "&alpha;")

        # "U+003B2", "GREEK SMALL LETTER BETA"
        txt = txt.replace("β", "&beta;")

        # "U+003B3", "GREEK SMALL LETTER GAMMA"
        txt = txt.replace("γ", "&gamma;")

        # "U+003B4", "GREEK SMALL LETTER DELTA"
        txt = txt.replace("δ", "&delta;")

        # "U+003B5", "GREEK SMALL LETTER EPSILON"
        txt = txt.replace("ε", "&epsiv;")

        # "U+003B6", "GREEK SMALL LETTER ZETA"
        txt = txt.replace("ζ", "&zeta;")

        # "U+003B7", "GREEK SMALL LETTER ETA"
        txt = txt.replace("η", "&eta;")

        # "U+003B8", "GREEK SMALL LETTER THETA"
        txt = txt.replace("θ", "&theta;")

        # "U+003B9", "GREEK SMALL LETTER IOTA"
        txt = txt.replace("ι", "&iota;")

        # "U+003BA", "GREEK SMALL LETTER KAPPA"
        txt = txt.replace("κ", "&kappa;")

        # "U+003BB", "GREEK SMALL LETTER LAMDA"
        txt = txt.replace("λ", "&lambda;")

        # "U+003BC", "GREEK SMALL LETTER MU"
        txt = txt.replace("μ", "&mu;")

        # "U+003BD", "GREEK SMALL LETTER NU"
        txt = txt.replace("ν", "&nu;")

        # "U+003BE", "GREEK SMALL LETTER XI"
        txt = txt.replace("ξ", "&xi;")

        # "U+003BF", "GREEK SMALL LETTER OMICRON"
        txt = txt.replace("ο", "&omicron;")

        # "U+003C0", "GREEK SMALL LETTER PI"
        txt = txt.replace("π", "&pi;")

        # "U+003C1", "GREEK SMALL LETTER RHO"
        txt = txt.replace("ρ", "&rho;")

        # "U+003C2", "GREEK SMALL LETTER FINAL SIGMA"
        txt = txt.replace("ς", "&sigmav;")

        # "U+003C3", "GREEK SMALL LETTER SIGMA"
        txt = txt.replace("σ", "&sigma;")

        # "U+003C4", "GREEK SMALL LETTER TAU"
        txt = txt.replace("τ", "&tau;")

        # "U+003C5", "GREEK SMALL LETTER UPSILON"
        txt = txt.replace("υ", "&upsi;")

        # "U+003C6", "GREEK SMALL LETTER PHI"
        txt = txt.replace("φ", "&phi;")

        # "U+003C7", "GREEK SMALL LETTER CHI"
        txt = txt.replace("χ", "&chi;")

        # "U+003C8", "GREEK SMALL LETTER PSI"
        txt = txt.replace("ψ", "&psi;")

        # "U+003C9", "GREEK SMALL LETTER OMEGA"
        txt = txt.replace("ω", "&omega;")

        # "U+003D1", "GREEK THETA SYMBOL"
        txt = txt.replace("ϑ", "&thetav;")

        # "U+003D2", "GREEK UPSILON WITH HOOK SYMBOL"
        txt = txt.replace("ϒ", "&Upsi;")

        # "U+003D6", "GREEK PI SYMBOL"
        txt = txt.replace("ϖ", "&piv;")

        # "U+02002", "EN SPACE"
        txt = txt.replace(" ", "&ensp;")

        # "U+02003", "EM SPACE"
        txt = txt.replace(" ", "&emsp;")

        # "U+02009", "THIN SPACE"
        txt = txt.replace(" ", "&thinsp;")

        # "U+0200C", "ZERO WIDTH NON-JOINER"
        txt = txt.replace("‌", "&zwnj;")

        # "U+0200D", "ZERO WIDTH JOINER"
        txt = txt.replace("‍", "&zwj;")

        # "U+0200E", "LEFT-TO-RIGHT MARK"
        txt = txt.replace("‎", "&lrm;")

        # "U+0200F", "RIGHT-TO-LEFT MARK"
        txt = txt.replace("‏", "&rlm;")

        # "U+02013", "EN DASH"
        txt = txt.replace("–", "&ndash;")

        # "U+02014", "EM DASH"
        txt = txt.replace("—", "&mdash;")

        # "U+02018", "LEFT SINGLE QUOTATION MARK"
        txt = txt.replace("‘", "&lsquo;")

        # "U+02019", "RIGHT SINGLE QUOTATION MARK"
        txt = txt.replace("’", "&rsquo;")

        # "U+0201A", "SINGLE LOW-9 QUOTATION MARK"
        txt = txt.replace("‚", "&lsquor;")

        # "U+0201C", "LEFT DOUBLE QUOTATION MARK"
        txt = txt.replace("“", "&ldquo;")

        # "U+0201D", "RIGHT DOUBLE QUOTATION MARK"
        txt = txt.replace("”", "&rdquo;")

        # "U+0201E", "DOUBLE LOW-9 QUOTATION MARK"
        txt = txt.replace("„", "&ldquor;")

        # "U+02020", "DAGGER"
        txt = txt.replace("†", "&dagger;")

        # "U+02021", "DOUBLE DAGGER"
        txt = txt.replace("‡", "&Dagger;")

        # "U+02022", "BULLET"
        txt = txt.replace("•", "&bull;")

        # "U+02026", "HORIZONTAL ELLIPSIS"
        txt = txt.replace("…", "&hellip;")

        # "U+02030", "PER MILLE SIGN"
        txt = txt.replace("‰", "&permil;")

        # "U+02032", "PRIME"
        txt = txt.replace("′", "&prime;")

        # "U+02033", "DOUBLE PRIME"
        txt = txt.replace("″", "&Prime;")

        # "U+02039", "SINGLE LEFT-POINTING ANGLE QUOTATION MARK"
        txt = txt.replace("‹", "&lsaquo;")

        # "U+0203A", "SINGLE RIGHT-POINTING ANGLE QUOTATION MARK"
        txt = txt.replace("›", "&rsaquo;")

        # "U+0203E", "OVERLINE"
        txt = txt.replace("‾", "&oline;")

        # "U+02044", "FRACTION SLASH"
        txt = txt.replace("⁄", "&frasl;")

        # "U+020AC", "EURO SIGN"
        txt = txt.replace("€", "&euro;")

        # "U+02111", "BLACK-LETTER CAPITAL I"
        txt = txt.replace("ℑ", "&image;")

        # "U+02118", "SCRIPT CAPITAL P"
        txt = txt.replace("℘", "&weierp;")

        # "U+0211C", "BLACK-LETTER CAPITAL R"
        txt = txt.replace("ℜ", "&real;")

        # "U+02122", "TRADE MARK SIGN"
        txt = txt.replace("™", "&trade;")

        # "U+02135", "ALEF SYMBOL"
        txt = txt.replace("ℵ", "&alefsym;")

        # "U+02190", "LEFTWARDS ARROW"
        txt = txt.replace("←", "&larr;")

        # "U+02191", "UPWARDS ARROW"
        txt = txt.replace("↑", "&uarr;")

        # "U+02192", "RIGHTWARDS ARROW"
        txt = txt.replace("→", "&rarr;")

        # "U+02193", "DOWNWARDS ARROW"
        txt = txt.replace("↓", "&darr;")

        # "U+02194", "LEFT RIGHT ARROW"
        txt = txt.replace("↔", "&harr;")

        # "U+021B5", "DOWNWARDS ARROW WITH CORNER LEFTWARDS"
        txt = txt.replace("↵", "&crarr;")

        # "U+021D0", "LEFTWARDS DOUBLE ARROW"
        txt = txt.replace("⇐", "&lArr;")

        # "U+021D1", "UPWARDS DOUBLE ARROW"
        txt = txt.replace("⇑", "&uArr;")

        # "U+021D2", "RIGHTWARDS DOUBLE ARROW"
        txt = txt.replace("⇒", "&rArr;")

        # "U+021D3", "DOWNWARDS DOUBLE ARROW"
        txt = txt.replace("⇓", "&dArr;")

        # "U+021D4", "LEFT RIGHT DOUBLE ARROW"
        txt = txt.replace("⇔", "&hArr;")

        # "U+02200", "FOR ALL"
        txt = txt.replace("∀", "&forall;")

        # "U+02202", "PARTIAL DIFFERENTIAL"
        txt = txt.replace("∂", "&part;")

        # "U+02203", "THERE EXISTS"
        txt = txt.replace("∃", "&exist;")

        # "U+02205", "EMPTY SET"
        txt = txt.replace("∅", "&empty;")

        # "U+02207", "NABLA"
        txt = txt.replace("∇", "&nabla;")

        # "U+02208", "ELEMENT OF"
        txt = txt.replace("∈", "&isin;")

        # "U+02209", "NOT AN ELEMENT OF"
        txt = txt.replace("∉", "&notin;")

        # "U+0220B", "CONTAINS AS MEMBER"
        txt = txt.replace("∋", "&niv;")

        # "U+0220F", "N-ARY PRODUCT"
        txt = txt.replace("∏", "&prod;")

        # "U+02211", "N-ARY SUMMATION"
        txt = txt.replace("∑", "&sum;")

        # "U+02212", "MINUS SIGN"
        txt = txt.replace("−", "&minus;")

        # "U+02217", "ASTERISK OPERATOR"
        txt = txt.replace("∗", "&lowast;")

        # "U+0221A", "SQUARE ROOT"
        txt = txt.replace("√", "&radic;")

        # "U+0221D", "PROPORTIONAL TO"
        txt = txt.replace("∝", "&prop;")

        # "U+0221E", "INFINITY"
        txt = txt.replace("∞", "&infin;")

        # "U+02220", "ANGLE"
        txt = txt.replace("∠", "&ang;")

        # "U+02227", "LOGICAL AND"
        txt = txt.replace("∧", "&and;")

        # "U+02228", "LOGICAL OR"
        txt = txt.replace("∨", "&or;")

        # "U+02229", "INTERSECTION"
        txt = txt.replace("∩", "&cap;")

        # "U+0222A", "UNION"
        txt = txt.replace("∪", "&cup;")

        # "U+0222B", "INTEGRAL"
        txt = txt.replace("∫", "&int;")

        # "U+02234", "THEREFORE"
        txt = txt.replace("∴", "&there4;")

        # "U+0223C", "TILDE OPERATOR"
        txt = txt.replace("∼", "&sim;")

        # "U+02245", "APPROXIMATELY EQUAL TO"
        txt = txt.replace("≅", "&cong;")

        # "U+02248", "ALMOST EQUAL TO"
        txt = txt.replace("≈", "&asymp;")

        # "U+02260", "NOT EQUAL TO"
        txt = txt.replace("≠", "&ne;")

        # "U+02261", "IDENTICAL TO"
        txt = txt.replace("≡", "&equiv;")

        # "U+02264", "LESS-THAN OR EQUAL TO"
        txt = txt.replace("≤", "&le;")

        # "U+02265", "GREATER-THAN OR EQUAL TO"
        txt = txt.replace("≥", "&ge;")

        # "U+02282", "SUBSET OF"
        txt = txt.replace("⊂", "&sub;")

        # "U+02283", "SUPERSET OF"
        txt = txt.replace("⊃", "&sup;")

        # "U+02284", "NOT A SUBSET OF"
        txt = txt.replace("⊄", "&nsub;")

        # "U+02286", "SUBSET OF OR EQUAL TO"
        txt = txt.replace("⊆", "&sube;")

        # "U+02287", "SUPERSET OF OR EQUAL TO"
        txt = txt.replace("⊇", "&supe;")

        # "U+02295", "CIRCLED PLUS"
        txt = txt.replace("⊕", "&oplus;")

        # "U+02297", "CIRCLED TIMES"
        txt = txt.replace("⊗", "&otimes;")

        # "U+022A5", "UP TACK"
        txt = txt.replace("⊥", "&bottom;")

        # "U+022C5", "DOT OPERATOR"
        txt = txt.replace("⋅", "&sdot;")

        # "U+02308", "LEFT CEILING"
        txt = txt.replace("⌈", "&lceil;")

        # "U+02309", "RIGHT CEILING"
        txt = txt.replace("⌉", "&rceil;")

        # "U+0230A", "LEFT FLOOR"
        txt = txt.replace("⌊", "&lfloor;")

        # "U+0230B", "RIGHT FLOOR"
        txt = txt.replace("⌋", "&rfloor;")

        # "U+025CA", "LOZENGE"
        txt = txt.replace("◊", "&loz;")

        # "U+02660", "BLACK SPADE SUIT"
        txt = txt.replace("♠", "&spades;")

        # "U+02663", "BLACK CLUB SUIT"
        txt = txt.replace("♣", "&clubs;")

        # "U+02665", "BLACK HEART SUIT"
        txt = txt.replace("♥", "&hearts;")

        # "U+02666", "BLACK DIAMOND SUIT"
        txt = txt.replace("♦", "&diams;")

        # "U+027E8", "MATHEMATICAL LEFT ANGLE BRACKET"
        txt = txt.replace("⟨", "&lang;")

        # "U+027E9", "MATHEMATICAL RIGHT ANGLE BRACKET"
        txt = txt.replace("⟩", "&rang;")

        return txt

    """
    入力される文字列内の文字や記号を文字実体参照に置きかえます。ベーシック版です。
    :param source: 置きかえられる文字列の配列。
    :return: 置きかえられた文字列の配列。
    """

    @staticmethod
    def convert_to_all_basic(sources: List[str]) -> List[str]:
        for i in range(len(sources)):
            sources[i] = CharacterEntityReference.convert_to_basic(sources[i])

        return sources

    """
    入力される文字列内の文字や記号を文字実体参照に置きかえます。
    :param source: 置きかえられる文字列。
    :param escape_sequence_flag: エスケープシーケンスを置きかえるフラグ。
    :return: 置きかえられた文字列。
    """

    @staticmethod
    def convert_to(source: str, escape_sequence_flag: bool) -> str:
        txt = source

        # "U+00026", "AMPERSAND"
        # "U+0003B", "SEMICOLON"
        txt = txt.replace("&", "&amp")
        txt = txt.replace(";", "&semi;")
        txt = txt.replace("&amp", "&amp;")

        if escape_sequence_flag:
            # "U+00009", "CHARACTER TABULATION"
            txt = txt.replace("\t", "&Tab;")

            # "U+0000A", "LINE FEED (LF)"
            txt = txt.replace("\n", "&NewLine;")

        # "U+00021", "EXCLAMATION MARK"
        txt = txt.replace("!", "&excl;")

        # "U+00022", "QUOTATION MARK"
        txt = txt.replace('"', "&quot;")

        # "U+00023", "NUMBER SIGN"
        txt = txt.replace("#", "&num;")

        # "U+00024", "DOLLAR SIGN"
        txt = txt.replace("$", "&dollar;")

        # "U+00025", "PERCENT SIGN"
        txt = txt.replace("%", "&percnt;")

        # "U+00027", "APOSTROPHE"
        txt = txt.replace("'", "&apos;")

        # "U+00028", "LEFT PARENTHESIS"
        txt = txt.replace("(", "&lpar;")

        # "U+00029", "RIGHT PARENTHESIS"
        txt = txt.replace(")", "&rpar;")

        # "U+0002A", "ASTERISK"
        txt = txt.replace("*", "&ast;")

        # "U+0002B", "PLUS SIGN"
        txt = txt.replace("+", "&plus;")

        # "U+0002C", "COMMA"
        txt = txt.replace(",", "&comma;")

        # "U+0002E", "FULL STOP"
        txt = txt.replace(".", "&period;")

        # "U+0002F", "SOLIDUS"
        txt = txt.replace("/", "&sol;")

        # "U+0003A", "COLON"
        txt = txt.replace(":", "&colon;")

        # "U+0003C", "LESS-THAN SIGN"
        txt = txt.replace("<", "&lt;")

        # "U+0003D", "EQUALS SIGN"
        txt = txt.replace("=", "&equals;")

        # "U+0003E", "GREATER-THAN SIGN"
        txt = txt.replace(">", "&gt;")

        # "U+0003F", "QUESTION MARK"
        txt = txt.replace("?", "&quest;")

        # "U+00040", "COMMERCIAL AT"
        txt = txt.replace("@", "&commat;")

        # "U+0005B", "LEFT SQUARE BRACKET"
        txt = txt.replace("[", "&lsqb;")

        # "U+0005C", "REVERSE SOLIDUS"
        txt = txt.replace("\\", "&bsol;")

        # "U+0005D", "RIGHT SQUARE BRACKET"
        txt = txt.replace("]", "&rsqb;")

        # "U+0005E", "CIRCUMFLEX ACCENT"
        txt = txt.replace("^", "&Hat;")

        # "U+0005F", "LOW LINE"
        txt = txt.replace("_", "&lowbar;")

        # "U+00060", "GRAVE ACCENT"
        txt = txt.replace("`", "&grave;")

        # "U+0007B", "LEFT CURLY BRACKET"
        txt = txt.replace("\u007B", "&lcub;")

        # "U+0007C", "VERTICAL LINE"
        txt = txt.replace("|", "&verbar;")

        # "U+0007D", "RIGHT CURLY BRACKET"
        txt = txt.replace("\u007D", "&rcub;")

        # "U+000A0", "NO-BREAK SPACE"
        txt = txt.replace(" ", "&nbsp;")

        # "U+000A1", "INVERTED EXCLAMATION MARK"
        txt = txt.replace("¡", "&iexcl;")

        # "U+000A2", "CENT SIGN"
        txt = txt.replace("¢", "&cent;")

        # "U+000A3", "POUND SIGN"
        txt = txt.replace("£", "&pound;")

        # "U+000A4", "CURRENCY SIGN"
        txt = txt.replace("¤", "&curren;")

        # "U+000A5", "YEN SIGN"
        txt = txt.replace("¥", "&yen;")

        # "U+000A6", "BROKEN BAR"
        txt = txt.replace("¦", "&brvbar;")

        # "U+000A7", "SECTION SIGN"
        txt = txt.replace("§", "&sect;")

        # "U+000A8", "DIAERESIS"
        txt = txt.replace("¨", "&Dot;")

        # "U+000A9", "COPYRIGHT SIGN"
        txt = txt.replace("©", "&copy;")

        # "U+000AA", "FEMININE ORDINAL INDICATOR"
        txt = txt.replace("ª", "&ordf;")

        # "U+000AB", "LEFT-POINTING DOUBLE ANGLE QUOTATION MARK"
        txt = txt.replace("«", "&laquo;")

        # "U+000AC", "NOT SIGN"
        txt = txt.replace("¬", "&not;")

        # "U+000AD", "SOFT HYPHEN"
        txt = txt.replace("­", "&shy;")

        # "U+000AE", "REGISTERED SIGN"
        txt = txt.replace("®", "&reg;")

        # "U+000AF", "MACRON"
        txt = txt.replace("¯", "&macr;")

        # "U+000B0", "DEGREE SIGN"
        txt = txt.replace("°", "&deg;")

        # "U+000B1", "PLUS-MINUS SIGN"
        txt = txt.replace("±", "&plusmn;")

        # "U+000B2", "SUPERSCRIPT TWO"
        txt = txt.replace("²", "&sup2;")

        # "U+000B3", "SUPERSCRIPT THREE"
        txt = txt.replace("³", "&sup3;")

        # "U+000B4", "ACUTE ACCENT"
        txt = txt.replace("´", "&acute;")

        # "U+000B5", "MICRO SIGN"
        txt = txt.replace("µ", "&micro;")

        # "U+000B6", "PILCROW SIGN"
        txt = txt.replace("¶", "&para;")

        # "U+000B7", "MIDDLE DOT"
        txt = txt.replace("·", "&middot;")

        # "U+000B8", "CEDILLA"
        txt = txt.replace("¸", "&cedil;")

        # "U+000B9", "SUPERSCRIPT ONE"
        txt = txt.replace("¹", "&sup1;")

        # "U+000BA", "MASCULINE ORDINAL INDICATOR"
        txt = txt.replace("º", "&ordm;")

        # "U+000BB", "RIGHT-POINTING DOUBLE ANGLE QUOTATION MARK"
        txt = txt.replace("»", "&raquo;")

        # "U+000BC", "VULGAR FRACTION ONE QUARTER"
        txt = txt.replace("¼", "&frac14;")

        # "U+000BD", "VULGAR FRACTION ONE HALF"
        txt = txt.replace("½", "&frac12;")

        # "U+000BE", "VULGAR FRACTION THREE QUARTERS"
        txt = txt.replace("¾", "&frac34;")

        # "U+000BF", "INVERTED QUESTION MARK"
        txt = txt.replace("¿", "&iquest;")

        # "U+000C0", "LATIN CAPITAL LETTER A WITH GRAVE"
        txt = txt.replace("À", "&Agrave;")

        # "U+000C1", "LATIN CAPITAL LETTER A WITH ACUTE"
        txt = txt.replace("Á", "&Aacute;")

        # "U+000C2", "LATIN CAPITAL LETTER A WITH CIRCUMFLEX"
        txt = txt.replace("Â", "&Acirc;")

        # "U+000C3", "LATIN CAPITAL LETTER A WITH TILDE"
        txt = txt.replace("Ã", "&Atilde;")

        # "U+000C4", "LATIN CAPITAL LETTER A WITH DIAERESIS"
        txt = txt.replace("Ä", "&Auml;")

        # "U+000C5", "LATIN CAPITAL LETTER A WITH RING ABOVE"
        txt = txt.replace("Å", "&Aring;")

        # "U+000C6", "LATIN CAPITAL LETTER AE"
        txt = txt.replace("Æ", "&AElig;")

        # "U+000C7", "LATIN CAPITAL LETTER C WITH CEDILLA"
        txt = txt.replace("Ç", "&Ccedil;")

        # "U+000C8", "LATIN CAPITAL LETTER E WITH GRAVE"
        txt = txt.replace("È", "&Egrave;")

        # "U+000C9", "LATIN CAPITAL LETTER E WITH ACUTE"
        txt = txt.replace("É", "&Eacute;")

        # "U+000CA", "LATIN CAPITAL LETTER E WITH CIRCUMFLEX"
        txt = txt.replace("Ê", "&Ecirc;")

        # "U+000CB", "LATIN CAPITAL LETTER E WITH DIAERESIS"
        txt = txt.replace("Ë", "&Euml;")

        # "U+000CC", "LATIN CAPITAL LETTER I WITH GRAVE"
        txt = txt.replace("Ì", "&Igrave;")

        # "U+000CD", "LATIN CAPITAL LETTER I WITH ACUTE"
        txt = txt.replace("Í", "&Iacute;")

        # "U+000CE", "LATIN CAPITAL LETTER I WITH CIRCUMFLEX"
        txt = txt.replace("Î", "&Icirc;")

        # "U+000CF", "LATIN CAPITAL LETTER I WITH DIAERESIS"
        txt = txt.replace("Ï", "&Iuml;")

        # "U+000D0", "LATIN CAPITAL LETTER ETH"
        txt = txt.replace("Ð", "&ETH;")

        # "U+000D1", "LATIN CAPITAL LETTER N WITH TILDE"
        txt = txt.replace("Ñ", "&Ntilde;")

        # "U+000D2", "LATIN CAPITAL LETTER O WITH GRAVE"
        txt = txt.replace("Ò", "&Ograve;")

        # "U+000D3", "LATIN CAPITAL LETTER O WITH ACUTE"
        txt = txt.replace("Ó", "&Oacute;")

        # "U+000D4", "LATIN CAPITAL LETTER O WITH CIRCUMFLEX"
        txt = txt.replace("Ô", "&Ocirc;")

        # "U+000D5", "LATIN CAPITAL LETTER O WITH TILDE"
        txt = txt.replace("Õ", "&Otilde;")

        # "U+000D6", "LATIN CAPITAL LETTER O WITH DIAERESIS"
        txt = txt.replace("Ö", "&Ouml;")

        # "U+000D7", "MULTIPLICATION SIGN"
        txt = txt.replace("×", "&times;")

        # "U+000D8", "LATIN CAPITAL LETTER O WITH STROKE"
        txt = txt.replace("Ø", "&Oslash;")

        # "U+000D9", "LATIN CAPITAL LETTER U WITH GRAVE"
        txt = txt.replace("Ù", "&Ugrave;")

        # "U+000DA", "LATIN CAPITAL LETTER U WITH ACUTE"
        txt = txt.replace("Ú", "&Uacute;")

        # "U+000DB", "LATIN CAPITAL LETTER U WITH CIRCUMFLEX"
        txt = txt.replace("Û", "&Ucirc;")

        # "U+000DC", "LATIN CAPITAL LETTER U WITH DIAERESIS"
        txt = txt.replace("Ü", "&Uuml;")

        # "U+000DD", "LATIN CAPITAL LETTER Y WITH ACUTE"
        txt = txt.replace("Ý", "&Yacute;")

        # "U+000DE", "LATIN CAPITAL LETTER THORN"
        txt = txt.replace("Þ", "&THORN;")

        # "U+000DF", "LATIN SMALL LETTER SHARP S"
        txt = txt.replace("ß", "&szlig;")

        # "U+000E0", "LATIN SMALL LETTER A WITH GRAVE"
        txt = txt.replace("à", "&agrave;")

        # "U+000E1", "LATIN SMALL LETTER A WITH ACUTE"
        txt = txt.replace("á", "&aacute;")

        # "U+000E2", "LATIN SMALL LETTER A WITH CIRCUMFLEX"
        txt = txt.replace("â", "&acirc;")

        # "U+000E3", "LATIN SMALL LETTER A WITH TILDE"
        txt = txt.replace("ã", "&atilde;")

        # "U+000E4", "LATIN SMALL LETTER A WITH DIAERESIS"
        txt = txt.replace("ä", "&auml;")

        # "U+000E5", "LATIN SMALL LETTER A WITH RING ABOVE"
        txt = txt.replace("å", "&aring;")

        # "U+000E6", "LATIN SMALL LETTER AE"
        txt = txt.replace("æ", "&aelig;")

        # "U+000E7", "LATIN SMALL LETTER C WITH CEDILLA"
        txt = txt.replace("ç", "&ccedil;")

        # "U+000E8", "LATIN SMALL LETTER E WITH GRAVE"
        txt = txt.replace("è", "&egrave;")

        # "U+000E9", "LATIN SMALL LETTER E WITH ACUTE"
        txt = txt.replace("é", "&eacute;")

        # "U+000EA", "LATIN SMALL LETTER E WITH CIRCUMFLEX"
        txt = txt.replace("ê", "&ecirc;")

        # "U+000EB", "LATIN SMALL LETTER E WITH DIAERESIS"
        txt = txt.replace("ë", "&euml;")

        # "U+000EC", "LATIN SMALL LETTER I WITH GRAVE"
        txt = txt.replace("ì", "&igrave;")

        # "U+000ED", "LATIN SMALL LETTER I WITH ACUTE"
        txt = txt.replace("í", "&iacute;")

        # "U+000EE", "LATIN SMALL LETTER I WITH CIRCUMFLEX"
        txt = txt.replace("î", "&icirc;")

        # "U+000EF", "LATIN SMALL LETTER I WITH DIAERESIS"
        txt = txt.replace("ï", "&iuml;")

        # "U+000F0", "LATIN SMALL LETTER ETH"
        txt = txt.replace("ð", "&eth;")

        # "U+000F1", "LATIN SMALL LETTER N WITH TILDE"
        txt = txt.replace("ñ", "&ntilde;")

        # "U+000F2", "LATIN SMALL LETTER O WITH GRAVE"
        txt = txt.replace("ò", "&ograve;")

        # "U+000F3", "LATIN SMALL LETTER O WITH ACUTE"
        txt = txt.replace("ó", "&oacute;")

        # "U+000F4", "LATIN SMALL LETTER O WITH CIRCUMFLEX"
        txt = txt.replace("ô", "&ocirc;")

        # "U+000F5", "LATIN SMALL LETTER O WITH TILDE"
        txt = txt.replace("õ", "&otilde;")

        # "U+000F6", "LATIN SMALL LETTER O WITH DIAERESIS"
        txt = txt.replace("ö", "&ouml;")

        # "U+000F7", "DIVISION SIGN"
        txt = txt.replace("÷", "&divide;")

        # "U+000F8", "LATIN SMALL LETTER O WITH STROKE"
        txt = txt.replace("ø", "&oslash;")

        # "U+000F9", "LATIN SMALL LETTER U WITH GRAVE"
        txt = txt.replace("ù", "&ugrave;")

        # "U+000FA", "LATIN SMALL LETTER U WITH ACUTE"
        txt = txt.replace("ú", "&uacute;")

        # "U+000FB", "LATIN SMALL LETTER U WITH CIRCUMFLEX"
        txt = txt.replace("û", "&ucirc;")

        # "U+000FC", "LATIN SMALL LETTER U WITH DIAERESIS"
        txt = txt.replace("ü", "&uuml;")

        # "U+000FD", "LATIN SMALL LETTER Y WITH ACUTE"
        txt = txt.replace("ý", "&yacute;")

        # "U+000FE", "LATIN SMALL LETTER THORN"
        txt = txt.replace("þ", "&thorn;")

        # "U+000FF", "LATIN SMALL LETTER Y WITH DIAERESIS"
        txt = txt.replace("ÿ", "&yuml;")

        # "U+00100", "LATIN CAPITAL LETTER A WITH MACRON"
        txt = txt.replace("Ā", "&Amacr;")

        # "U+00101", "LATIN SMALL LETTER A WITH MACRON"
        txt = txt.replace("ā", "&amacr;")

        # "U+00102", "LATIN CAPITAL LETTER A WITH BREVE"
        txt = txt.replace("Ă", "&Abreve;")

        # "U+00103", "LATIN SMALL LETTER A WITH BREVE"
        txt = txt.replace("ă", "&abreve;")

        # "U+00104", "LATIN CAPITAL LETTER A WITH OGONEK"
        txt = txt.replace("Ą", "&Aogon;")

        # "U+00105", "LATIN SMALL LETTER A WITH OGONEK"
        txt = txt.replace("ą", "&aogon;")

        # "U+00106", "LATIN CAPITAL LETTER C WITH ACUTE"
        txt = txt.replace("Ć", "&Cacute;")

        # "U+00107", "LATIN SMALL LETTER C WITH ACUTE"
        txt = txt.replace("ć", "&cacute;")

        # "U+00108", "LATIN CAPITAL LETTER C WITH CIRCUMFLEX"
        txt = txt.replace("Ĉ", "&Ccirc;")

        # "U+00109", "LATIN SMALL LETTER C WITH CIRCUMFLEX"
        txt = txt.replace("ĉ", "&ccirc;")

        # "U+0010A", "LATIN CAPITAL LETTER C WITH DOT ABOVE"
        txt = txt.replace("Ċ", "&Cdot;")

        # "U+0010B", "LATIN SMALL LETTER C WITH DOT ABOVE"
        txt = txt.replace("ċ", "&cdot;")

        # "U+0010C", "LATIN CAPITAL LETTER C WITH CARON"
        txt = txt.replace("Č", "&Ccaron;")

        # "U+0010D", "LATIN SMALL LETTER C WITH CARON"
        txt = txt.replace("č", "&ccaron;")

        # "U+0010E", "LATIN CAPITAL LETTER D WITH CARON"
        txt = txt.replace("Ď", "&Dcaron;")

        # "U+0010F", "LATIN SMALL LETTER D WITH CARON"
        txt = txt.replace("ď", "&dcaron;")

        # "U+00110", "LATIN CAPITAL LETTER D WITH STROKE"
        txt = txt.replace("Đ", "&Dstrok;")

        # "U+00111", "LATIN SMALL LETTER D WITH STROKE"
        txt = txt.replace("đ", "&dstrok;")

        # "U+00112", "LATIN CAPITAL LETTER E WITH MACRON"
        txt = txt.replace("Ē", "&Emacr;")

        # "U+00113", "LATIN SMALL LETTER E WITH MACRON"
        txt = txt.replace("ē", "&emacr;")

        # "U+00116", "LATIN CAPITAL LETTER E WITH DOT ABOVE"
        txt = txt.replace("Ė", "&Edot;")

        # "U+00117", "LATIN SMALL LETTER E WITH DOT ABOVE"
        txt = txt.replace("ė", "&edot;")

        # "U+00118", "LATIN CAPITAL LETTER E WITH OGONEK"
        txt = txt.replace("Ę", "&Eogon;")

        # "U+00119", "LATIN SMALL LETTER E WITH OGONEK"
        txt = txt.replace("ę", "&eogon;")

        # "U+0011A", "LATIN CAPITAL LETTER E WITH CARON"
        txt = txt.replace("Ě", "&Ecaron;")

        # "U+0011B", "LATIN SMALL LETTER E WITH CARON"
        txt = txt.replace("ě", "&ecaron;")

        # "U+0011C", "LATIN CAPITAL LETTER G WITH CIRCUMFLEX"
        txt = txt.replace("Ĝ", "&Gcirc;")

        # "U+0011D", "LATIN SMALL LETTER G WITH CIRCUMFLEX"
        txt = txt.replace("ĝ", "&gcirc;")

        # "U+0011E", "LATIN CAPITAL LETTER G WITH BREVE"
        txt = txt.replace("Ğ", "&Gbreve;")

        # "U+0011F", "LATIN SMALL LETTER G WITH BREVE"
        txt = txt.replace("ğ", "&gbreve;")

        # "U+00120", "LATIN CAPITAL LETTER G WITH DOT ABOVE"
        txt = txt.replace("Ġ", "&Gdot;")

        # "U+00121", "LATIN SMALL LETTER G WITH DOT ABOVE"
        txt = txt.replace("ġ", "&gdot;")

        # "U+00122", "LATIN CAPITAL LETTER G WITH CEDILLA"
        txt = txt.replace("Ģ", "&Gcedil;")

        # "U+00124", "LATIN CAPITAL LETTER H WITH CIRCUMFLEX"
        txt = txt.replace("Ĥ", "&Hcirc;")

        # "U+00125", "LATIN SMALL LETTER H WITH CIRCUMFLEX"
        txt = txt.replace("ĥ", "&hcirc;")

        # "U+00126", "LATIN CAPITAL LETTER H WITH STROKE"
        txt = txt.replace("Ħ", "&Hstrok;")

        # "U+00127", "LATIN SMALL LETTER H WITH STROKE"
        txt = txt.replace("ħ", "&hstrok;")

        # "U+00128", "LATIN CAPITAL LETTER I WITH TILDE"
        txt = txt.replace("Ĩ", "&Itilde;")

        # "U+00129", "LATIN SMALL LETTER I WITH TILDE"
        txt = txt.replace("ĩ", "&itilde;")

        # "U+0012A", "LATIN CAPITAL LETTER I WITH MACRON"
        txt = txt.replace("Ī", "&Imacr;")

        # "U+0012B", "LATIN SMALL LETTER I WITH MACRON"
        txt = txt.replace("ī", "&imacr;")

        # "U+0012E", "LATIN CAPITAL LETTER I WITH OGONEK"
        txt = txt.replace("Į", "&Iogon;")

        # "U+0012F", "LATIN SMALL LETTER I WITH OGONEK"
        txt = txt.replace("į", "&iogon;")

        # "U+00130", "LATIN CAPITAL LETTER I WITH DOT ABOVE"
        txt = txt.replace("İ", "&Idot;")

        # "U+00131", "LATIN SMALL LETTER DOTLESS I"
        txt = txt.replace("ı", "&imath;")

        # "U+00132", "LATIN CAPITAL LIGATURE IJ"
        txt = txt.replace("Ĳ", "&IJlig;")

        # "U+00133", "LATIN SMALL LIGATURE IJ"
        txt = txt.replace("ĳ", "&ijlig;")

        # "U+00134", "LATIN CAPITAL LETTER J WITH CIRCUMFLEX"
        txt = txt.replace("Ĵ", "&Jcirc;")

        # "U+00135", "LATIN SMALL LETTER J WITH CIRCUMFLEX"
        txt = txt.replace("ĵ", "&jcirc;")

        # "U+00136", "LATIN CAPITAL LETTER K WITH CEDILLA"
        txt = txt.replace("Ķ", "&Kcedil;")

        # "U+00137", "LATIN SMALL LETTER K WITH CEDILLA"
        txt = txt.replace("ķ", "&kcedil;")

        # "U+00138", "LATIN SMALL LETTER KRA"
        txt = txt.replace("ĸ", "&kgreen;")

        # "U+00139", "LATIN CAPITAL LETTER L WITH ACUTE"
        txt = txt.replace("Ĺ", "&Lacute;")

        # "U+0013A", "LATIN SMALL LETTER L WITH ACUTE"
        txt = txt.replace("ĺ", "&lacute;")

        # "U+0013B", "LATIN CAPITAL LETTER L WITH CEDILLA"
        txt = txt.replace("Ļ", "&Lcedil;")

        # "U+0013C", "LATIN SMALL LETTER L WITH CEDILLA"
        txt = txt.replace("ļ", "&lcedil;")

        # "U+0013D", "LATIN CAPITAL LETTER L WITH CARON"
        txt = txt.replace("Ľ", "&Lcaron;")

        # "U+0013E", "LATIN SMALL LETTER L WITH CARON"
        txt = txt.replace("ľ", "&lcaron;")

        # "U+0013F", "LATIN CAPITAL LETTER L WITH MIDDLE DOT"
        txt = txt.replace("Ŀ", "&Lmidot;")

        # "U+00140", "LATIN SMALL LETTER L WITH MIDDLE DOT"
        txt = txt.replace("ŀ", "&lmidot;")

        # "U+00141", "LATIN CAPITAL LETTER L WITH STROKE"
        txt = txt.replace("Ł", "&Lstrok;")

        # "U+00142", "LATIN SMALL LETTER L WITH STROKE"
        txt = txt.replace("ł", "&lstrok;")

        # "U+00143", "LATIN CAPITAL LETTER N WITH ACUTE"
        txt = txt.replace("Ń", "&Nacute;")

        # "U+00144", "LATIN SMALL LETTER N WITH ACUTE"
        txt = txt.replace("ń", "&nacute;")

        # "U+00145", "LATIN CAPITAL LETTER N WITH CEDILLA"
        txt = txt.replace("Ņ", "&Ncedil;")

        # "U+00146", "LATIN SMALL LETTER N WITH CEDILLA"
        txt = txt.replace("ņ", "&ncedil;")

        # "U+00147", "LATIN CAPITAL LETTER N WITH CARON"
        txt = txt.replace("Ň", "&Ncaron;")

        # "U+00148", "LATIN SMALL LETTER N WITH CARON"
        txt = txt.replace("ň", "&ncaron;")

        # "U+00149", "LATIN SMALL LETTER N PRECEDED BY APOSTROPHE"
        txt = txt.replace("ŉ", "&napos;")

        # "U+0014A", "LATIN CAPITAL LETTER ENG"
        txt = txt.replace("Ŋ", "&ENG;")

        # "U+0014B", "LATIN SMALL LETTER ENG"
        txt = txt.replace("ŋ", "&eng;")

        # "U+0014C", "LATIN CAPITAL LETTER O WITH MACRON"
        txt = txt.replace("Ō", "&Omacr;")

        # "U+0014D", "LATIN SMALL LETTER O WITH MACRON"
        txt = txt.replace("ō", "&omacr;")

        # "U+00150", "LATIN CAPITAL LETTER O WITH DOUBLE ACUTE"
        txt = txt.replace("Ő", "&Odblac;")

        # "U+00151", "LATIN SMALL LETTER O WITH DOUBLE ACUTE"
        txt = txt.replace("ő", "&odblac;")

        # "U+00152", "LATIN CAPITAL LIGATURE OE"
        txt = txt.replace("Œ", "&OElig;")

        # "U+00153", "LATIN SMALL LIGATURE OE"
        txt = txt.replace("œ", "&oelig;")

        # "U+00154", "LATIN CAPITAL LETTER R WITH ACUTE"
        txt = txt.replace("Ŕ", "&Racute;")

        # "U+00155", "LATIN SMALL LETTER R WITH ACUTE"
        txt = txt.replace("ŕ", "&racute;")

        # "U+00156", "LATIN CAPITAL LETTER R WITH CEDILLA"
        txt = txt.replace("Ŗ", "&Rcedil;")

        # "U+00157", "LATIN SMALL LETTER R WITH CEDILLA"
        txt = txt.replace("ŗ", "&rcedil;")

        # "U+00158", "LATIN CAPITAL LETTER R WITH CARON"
        txt = txt.replace("Ř", "&Rcaron;")

        # "U+00159", "LATIN SMALL LETTER R WITH CARON"
        txt = txt.replace("ř", "&rcaron;")

        # "U+0015A", "LATIN CAPITAL LETTER S WITH ACUTE"
        txt = txt.replace("Ś", "&Sacute;")

        # "U+0015B", "LATIN SMALL LETTER S WITH ACUTE"
        txt = txt.replace("ś", "&sacute;")

        # "U+0015C", "LATIN CAPITAL LETTER S WITH CIRCUMFLEX"
        txt = txt.replace("Ŝ", "&Scirc;")

        # "U+0015D", "LATIN SMALL LETTER S WITH CIRCUMFLEX"
        txt = txt.replace("ŝ", "&scirc;")

        # "U+0015E", "LATIN CAPITAL LETTER S WITH CEDILLA"
        txt = txt.replace("Ş", "&Scedil;")

        # "U+0015F", "LATIN SMALL LETTER S WITH CEDILLA"
        txt = txt.replace("ş", "&scedil;")

        # "U+00160", "LATIN CAPITAL LETTER S WITH CARON"
        txt = txt.replace("Š", "&Scaron;")

        # "U+00161", "LATIN SMALL LETTER S WITH CARON"
        txt = txt.replace("š", "&scaron;")

        # "U+00162", "LATIN CAPITAL LETTER T WITH CEDILLA"
        txt = txt.replace("Ţ", "&Tcedil;")

        # "U+00163", "LATIN SMALL LETTER T WITH CEDILLA"
        txt = txt.replace("ţ", "&tcedil;")

        # "U+00164", "LATIN CAPITAL LETTER T WITH CARON"
        txt = txt.replace("Ť", "&Tcaron;")

        # "U+00165", "LATIN SMALL LETTER T WITH CARON"
        txt = txt.replace("ť", "&tcaron;")

        # "U+00166", "LATIN CAPITAL LETTER T WITH STROKE"
        txt = txt.replace("Ŧ", "&Tstrok;")

        # "U+00167", "LATIN SMALL LETTER T WITH STROKE"
        txt = txt.replace("ŧ", "&tstrok;")

        # "U+00168", "LATIN CAPITAL LETTER U WITH TILDE"
        txt = txt.replace("Ũ", "&Utilde;")

        # "U+00169", "LATIN SMALL LETTER U WITH TILDE"
        txt = txt.replace("ũ", "&utilde;")

        # "U+0016A", "LATIN CAPITAL LETTER U WITH MACRON"
        txt = txt.replace("Ū", "&Umacr;")

        # "U+0016B", "LATIN SMALL LETTER U WITH MACRON"
        txt = txt.replace("ū", "&umacr;")

        # "U+0016C", "LATIN CAPITAL LETTER U WITH BREVE"
        txt = txt.replace("Ŭ", "&Ubreve;")

        # "U+0016D", "LATIN SMALL LETTER U WITH BREVE"
        txt = txt.replace("ŭ", "&ubreve;")

        # "U+0016E", "LATIN CAPITAL LETTER U WITH RING ABOVE"
        txt = txt.replace("Ů", "&Uring;")

        # "U+0016F", "LATIN SMALL LETTER U WITH RING ABOVE"
        txt = txt.replace("ů", "&uring;")

        # "U+00170", "LATIN CAPITAL LETTER U WITH DOUBLE ACUTE"
        txt = txt.replace("Ű", "&Udblac;")

        # "U+00171", "LATIN SMALL LETTER U WITH DOUBLE ACUTE"
        txt = txt.replace("ű", "&udblac;")

        # "U+00172", "LATIN CAPITAL LETTER U WITH OGONEK"
        txt = txt.replace("Ų", "&Uogon;")

        # "U+00173", "LATIN SMALL LETTER U WITH OGONEK"
        txt = txt.replace("ų", "&uogon;")

        # "U+00174", "LATIN CAPITAL LETTER W WITH CIRCUMFLEX"
        txt = txt.replace("Ŵ", "&Wcirc;")

        # "U+00175", "LATIN SMALL LETTER W WITH CIRCUMFLEX"
        txt = txt.replace("ŵ", "&wcirc;")

        # "U+00176", "LATIN CAPITAL LETTER Y WITH CIRCUMFLEX"
        txt = txt.replace("Ŷ", "&Ycirc;")

        # "U+00177", "LATIN SMALL LETTER Y WITH CIRCUMFLEX"
        txt = txt.replace("ŷ", "&ycirc;")

        # "U+00178", "LATIN CAPITAL LETTER Y WITH DIAERESIS"
        txt = txt.replace("Ÿ", "&Yuml;")

        # "U+00179", "LATIN CAPITAL LETTER Z WITH ACUTE"
        txt = txt.replace("Ź", "&Zacute;")

        # "U+0017A", "LATIN SMALL LETTER Z WITH ACUTE"
        txt = txt.replace("ź", "&zacute;")

        # "U+0017B", "LATIN CAPITAL LETTER Z WITH DOT ABOVE"
        txt = txt.replace("Ż", "&Zdot;")

        # "U+0017C", "LATIN SMALL LETTER Z WITH DOT ABOVE"
        txt = txt.replace("ż", "&zdot;")

        # "U+0017D", "LATIN CAPITAL LETTER Z WITH CARON"
        txt = txt.replace("Ž", "&Zcaron;")

        # "U+0017E", "LATIN SMALL LETTER Z WITH CARON"
        txt = txt.replace("ž", "&zcaron;")

        # "U+00192", "LATIN SMALL LETTER F WITH HOOK"
        txt = txt.replace("ƒ", "&fnof;")

        # "U+001B5", "LATIN CAPITAL LETTER Z WITH STROKE"
        txt = txt.replace("Ƶ", "&imped;")

        # "U+001F5", "LATIN SMALL LETTER G WITH ACUTE"
        txt = txt.replace("ǵ", "&gacute;")

        # "U+00237", "LATIN SMALL LETTER DOTLESS J"
        txt = txt.replace("ȷ", "&jmath;")

        # "U+002C6", "MODIFIER LETTER CIRCUMFLEX ACCENT"
        txt = txt.replace("ˆ", "&circ;")

        # "U+002C7", "CARON"
        txt = txt.replace("ˇ", "&caron;")

        # "U+002D8", "BREVE"
        txt = txt.replace("˘", "&breve;")

        # "U+002D9", "DOT ABOVE"
        txt = txt.replace("˙", "&dot;")

        # "U+002DA", "RING ABOVE"
        txt = txt.replace("˚", "&ring;")

        # "U+002DB", "OGONEK"
        txt = txt.replace("˛", "&ogon;")

        # "U+002DC", "SMALL TILDE"
        txt = txt.replace("˜", "&tilde;")

        # "U+002DD", "DOUBLE ACUTE ACCENT"
        txt = txt.replace("˝", "&dblac;")

        # "U+00311", "COMBINING INVERTED BREVE"
        txt = txt.replace("̑", "&DownBreve;")

        # "U+00332", "COMBINING LOW LINE"
        txt = txt.replace("̲", "&UnderBar;")

        # "U+00391", "GREEK CAPITAL LETTER ALPHA"
        txt = txt.replace("Α", "&Alpha;")

        # "U+00392", "GREEK CAPITAL LETTER BETA"
        txt = txt.replace("Β", "&Beta;")

        # "U+00393", "GREEK CAPITAL LETTER GAMMA"
        txt = txt.replace("Γ", "&Gamma;")

        # "U+00394", "GREEK CAPITAL LETTER DELTA"
        txt = txt.replace("Δ", "&Delta;")

        # "U+00395", "GREEK CAPITAL LETTER EPSILON"
        txt = txt.replace("Ε", "&Epsilon;")

        # "U+00396", "GREEK CAPITAL LETTER ZETA"
        txt = txt.replace("Ζ", "&Zeta;")

        # "U+00397", "GREEK CAPITAL LETTER ETA"
        txt = txt.replace("Η", "&Eta;")

        # "U+00398", "GREEK CAPITAL LETTER THETA"
        txt = txt.replace("Θ", "&Theta;")

        # "U+00399", "GREEK CAPITAL LETTER IOTA"
        txt = txt.replace("Ι", "&Iota;")

        # "U+0039A", "GREEK CAPITAL LETTER KAPPA"
        txt = txt.replace("Κ", "&Kappa;")

        # "U+0039B", "GREEK CAPITAL LETTER LAMDA"
        txt = txt.replace("Λ", "&Lambda;")

        # "U+0039C", "GREEK CAPITAL LETTER MU"
        txt = txt.replace("Μ", "&Mu;")

        # "U+0039D", "GREEK CAPITAL LETTER NU"
        txt = txt.replace("Ν", "&Nu;")

        # "U+0039E", "GREEK CAPITAL LETTER XI"
        txt = txt.replace("Ξ", "&Xi;")

        # "U+0039F", "GREEK CAPITAL LETTER OMICRON"
        txt = txt.replace("Ο", "&Omicron;")

        # "U+003A0", "GREEK CAPITAL LETTER PI"
        txt = txt.replace("Π", "&Pi;")

        # "U+003A1", "GREEK CAPITAL LETTER RHO"
        txt = txt.replace("Ρ", "&Rho;")

        # "U+003A3", "GREEK CAPITAL LETTER SIGMA"
        txt = txt.replace("Σ", "&Sigma;")

        # "U+003A4", "GREEK CAPITAL LETTER TAU"
        txt = txt.replace("Τ", "&Tau;")

        # "U+003A5", "GREEK CAPITAL LETTER UPSILON"
        txt = txt.replace("Υ", "&Upsilon;")

        # "U+003A6", "GREEK CAPITAL LETTER PHI"
        txt = txt.replace("Φ", "&Phi;")

        # "U+003A7", "GREEK CAPITAL LETTER CHI"
        txt = txt.replace("Χ", "&Chi;")

        # "U+003A8", "GREEK CAPITAL LETTER PSI"
        txt = txt.replace("Ψ", "&Psi;")

        # "U+003A9", "GREEK CAPITAL LETTER OMEGA"
        txt = txt.replace("Ω", "&Omega;")

        # "U+003B1", "GREEK SMALL LETTER ALPHA"
        txt = txt.replace("α", "&alpha;")

        # "U+003B2", "GREEK SMALL LETTER BETA"
        txt = txt.replace("β", "&beta;")

        # "U+003B3", "GREEK SMALL LETTER GAMMA"
        txt = txt.replace("γ", "&gamma;")

        # "U+003B4", "GREEK SMALL LETTER DELTA"
        txt = txt.replace("δ", "&delta;")

        # "U+003B5", "GREEK SMALL LETTER EPSILON"
        txt = txt.replace("ε", "&epsiv;")

        # "U+003B6", "GREEK SMALL LETTER ZETA"
        txt = txt.replace("ζ", "&zeta;")

        # "U+003B7", "GREEK SMALL LETTER ETA"
        txt = txt.replace("η", "&eta;")

        # "U+003B8", "GREEK SMALL LETTER THETA"
        txt = txt.replace("θ", "&theta;")

        # "U+003B9", "GREEK SMALL LETTER IOTA"
        txt = txt.replace("ι", "&iota;")

        # "U+003BA", "GREEK SMALL LETTER KAPPA"
        txt = txt.replace("κ", "&kappa;")

        # "U+003BB", "GREEK SMALL LETTER LAMDA"
        txt = txt.replace("λ", "&lambda;")

        # "U+003BC", "GREEK SMALL LETTER MU"
        txt = txt.replace("μ", "&mu;")

        # "U+003BD", "GREEK SMALL LETTER NU"
        txt = txt.replace("ν", "&nu;")

        # "U+003BE", "GREEK SMALL LETTER XI"
        txt = txt.replace("ξ", "&xi;")

        # "U+003BF", "GREEK SMALL LETTER OMICRON"
        txt = txt.replace("ο", "&omicron;")

        # "U+003C0", "GREEK SMALL LETTER PI"
        txt = txt.replace("π", "&pi;")

        # "U+003C1", "GREEK SMALL LETTER RHO"
        txt = txt.replace("ρ", "&rho;")

        # "U+003C2", "GREEK SMALL LETTER FINAL SIGMA"
        txt = txt.replace("ς", "&sigmav;")

        # "U+003C3", "GREEK SMALL LETTER SIGMA"
        txt = txt.replace("σ", "&sigma;")

        # "U+003C4", "GREEK SMALL LETTER TAU"
        txt = txt.replace("τ", "&tau;")

        # "U+003C5", "GREEK SMALL LETTER UPSILON"
        txt = txt.replace("υ", "&upsi;")

        # "U+003C6", "GREEK SMALL LETTER PHI"
        txt = txt.replace("φ", "&phi;")

        # "U+003C7", "GREEK SMALL LETTER CHI"
        txt = txt.replace("χ", "&chi;")

        # "U+003C8", "GREEK SMALL LETTER PSI"
        txt = txt.replace("ψ", "&psi;")

        # "U+003C9", "GREEK SMALL LETTER OMEGA"
        txt = txt.replace("ω", "&omega;")

        # "U+003D1", "GREEK THETA SYMBOL"
        txt = txt.replace("ϑ", "&thetav;")

        # "U+003D2", "GREEK UPSILON WITH HOOK SYMBOL"
        txt = txt.replace("ϒ", "&Upsi;")

        # "U+003D5", "GREEK PHI SYMBOL"
        txt = txt.replace("ϕ", "&straightphi;")

        # "U+003D6", "GREEK PI SYMBOL"
        txt = txt.replace("ϖ", "&piv;")

        # "U+003DC", "GREEK LETTER DIGAMMA"
        txt = txt.replace("Ϝ", "&Gammad;")

        # "U+003DD", "GREEK SMALL LETTER DIGAMMA"
        txt = txt.replace("ϝ", "&gammad;")

        # "U+003F0", "GREEK KAPPA SYMBOL"
        txt = txt.replace("ϰ", "&kappav;")

        # "U+003F1", "GREEK RHO SYMBOL"
        txt = txt.replace("ϱ", "&rhov;")

        # "U+003F5", "GREEK LUNATE EPSILON SYMBOL"
        txt = txt.replace("ϵ", "&epsi;")

        # "U+003F6", "GREEK REVERSED LUNATE EPSILON SYMBOL"
        txt = txt.replace("϶", "&bepsi;")

        # "U+00401", "CYRILLIC CAPITAL LETTER IO"
        txt = txt.replace("Ё", "&IOcy;")

        # "U+00402", "CYRILLIC CAPITAL LETTER DJE"
        txt = txt.replace("Ђ", "&DJcy;")

        # "U+00403", "CYRILLIC CAPITAL LETTER GJE"
        txt = txt.replace("Ѓ", "&GJcy;")

        # "U+00404", "CYRILLIC CAPITAL LETTER UKRAINIAN IE"
        txt = txt.replace("Є", "&Jukcy;")

        # "U+00405", "CYRILLIC CAPITAL LETTER DZE"
        txt = txt.replace("Ѕ", "&DScy;")

        # "U+00406", "CYRILLIC CAPITAL LETTER BYELORUSSIAN-UKRAINIAN I"
        txt = txt.replace("І", "&Iukcy;")

        # "U+00407", "CYRILLIC CAPITAL LETTER YI"
        txt = txt.replace("Ї", "&YIcy;")

        # "U+00408", "CYRILLIC CAPITAL LETTER JE"
        txt = txt.replace("Ј", "&Jsercy;")

        # "U+00409", "CYRILLIC CAPITAL LETTER LJE"
        txt = txt.replace("Љ", "&LJcy;")

        # "U+0040A", "CYRILLIC CAPITAL LETTER NJE"
        txt = txt.replace("Њ", "&NJcy;")

        # "U+0040B", "CYRILLIC CAPITAL LETTER TSHE"
        txt = txt.replace("Ћ", "&TSHcy;")

        # "U+0040C", "CYRILLIC CAPITAL LETTER KJE"
        txt = txt.replace("Ќ", "&KJcy;")

        # "U+0040E", "CYRILLIC CAPITAL LETTER SHORT U"
        txt = txt.replace("Ў", "&Ubrcy;")

        # "U+0040F", "CYRILLIC CAPITAL LETTER DZHE"
        txt = txt.replace("Џ", "&DZcy;")

        # "U+00410", "CYRILLIC CAPITAL LETTER A"
        txt = txt.replace("А", "&Acy;")

        # "U+00411", "CYRILLIC CAPITAL LETTER BE"
        txt = txt.replace("Б", "&Bcy;")

        # "U+00412", "CYRILLIC CAPITAL LETTER VE"
        txt = txt.replace("В", "&Vcy;")

        # "U+00413", "CYRILLIC CAPITAL LETTER GHE"
        txt = txt.replace("Г", "&Gcy;")

        # "U+00414", "CYRILLIC CAPITAL LETTER DE"
        txt = txt.replace("Д", "&Dcy;")

        # "U+00415", "CYRILLIC CAPITAL LETTER IE"
        txt = txt.replace("Е", "&IEcy;")

        # "U+00416", "CYRILLIC CAPITAL LETTER ZHE"
        txt = txt.replace("Ж", "&ZHcy;")

        # "U+00417", "CYRILLIC CAPITAL LETTER ZE"
        txt = txt.replace("З", "&Zcy;")

        # "U+00418", "CYRILLIC CAPITAL LETTER I"
        txt = txt.replace("И", "&Icy;")

        # "U+00419", "CYRILLIC CAPITAL LETTER SHORT I"
        txt = txt.replace("Й", "&Jcy;")

        # "U+0041A", "CYRILLIC CAPITAL LETTER KA"
        txt = txt.replace("К", "&Kcy;")

        # "U+0041B", "CYRILLIC CAPITAL LETTER EL"
        txt = txt.replace("Л", "&Lcy;")

        # "U+0041C", "CYRILLIC CAPITAL LETTER EM"
        txt = txt.replace("М", "&Mcy;")

        # "U+0041D", "CYRILLIC CAPITAL LETTER EN"
        txt = txt.replace("Н", "&Ncy;")

        # "U+0041E", "CYRILLIC CAPITAL LETTER O"
        txt = txt.replace("О", "&Ocy;")

        # "U+0041F", "CYRILLIC CAPITAL LETTER PE"
        txt = txt.replace("П", "&Pcy;")

        # "U+00420", "CYRILLIC CAPITAL LETTER ER"
        txt = txt.replace("Р", "&Rcy;")

        # "U+00421", "CYRILLIC CAPITAL LETTER ES"
        txt = txt.replace("С", "&Scy;")

        # "U+00422", "CYRILLIC CAPITAL LETTER TE"
        txt = txt.replace("Т", "&Tcy;")

        # "U+00423", "CYRILLIC CAPITAL LETTER U"
        txt = txt.replace("У", "&Ucy;")

        # "U+00424", "CYRILLIC CAPITAL LETTER EF"
        txt = txt.replace("Ф", "&Fcy;")

        # "U+00425", "CYRILLIC CAPITAL LETTER HA"
        txt = txt.replace("Х", "&KHcy;")

        # "U+00426", "CYRILLIC CAPITAL LETTER TSE"
        txt = txt.replace("Ц", "&TScy;")

        # "U+00427", "CYRILLIC CAPITAL LETTER CHE"
        txt = txt.replace("Ч", "&CHcy;")

        # "U+00428", "CYRILLIC CAPITAL LETTER SHA"
        txt = txt.replace("Ш", "&SHcy;")

        # "U+00429", "CYRILLIC CAPITAL LETTER SHCHA"
        txt = txt.replace("Щ", "&SHCHcy;")

        # "U+0042A", "CYRILLIC CAPITAL LETTER HARD SIGN"
        txt = txt.replace("Ъ", "&HARDcy;")

        # "U+0042B", "CYRILLIC CAPITAL LETTER YERU"
        txt = txt.replace("Ы", "&Ycy;")

        # "U+0042C", "CYRILLIC CAPITAL LETTER SOFT SIGN"
        txt = txt.replace("Ь", "&SOFTcy;")

        # "U+0042D", "CYRILLIC CAPITAL LETTER E"
        txt = txt.replace("Э", "&Ecy;")

        # "U+0042E", "CYRILLIC CAPITAL LETTER YU"
        txt = txt.replace("Ю", "&YUcy;")

        # "U+0042F", "CYRILLIC CAPITAL LETTER YA"
        txt = txt.replace("Я", "&YAcy;")

        # "U+00430", "CYRILLIC SMALL LETTER A"
        txt = txt.replace("а", "&acy;")

        # "U+00431", "CYRILLIC SMALL LETTER BE"
        txt = txt.replace("б", "&bcy;")

        # "U+00432", "CYRILLIC SMALL LETTER VE"
        txt = txt.replace("в", "&vcy;")

        # "U+00433", "CYRILLIC SMALL LETTER GHE"
        txt = txt.replace("г", "&gcy;")

        # "U+00434", "CYRILLIC SMALL LETTER DE"
        txt = txt.replace("д", "&dcy;")

        # "U+00435", "CYRILLIC SMALL LETTER IE"
        txt = txt.replace("е", "&iecy;")

        # "U+00436", "CYRILLIC SMALL LETTER ZHE"
        txt = txt.replace("ж", "&zhcy;")

        # "U+00437", "CYRILLIC SMALL LETTER ZE"
        txt = txt.replace("з", "&zcy;")

        # "U+00438", "CYRILLIC SMALL LETTER I"
        txt = txt.replace("и", "&icy;")

        # "U+00439", "CYRILLIC SMALL LETTER SHORT I"
        txt = txt.replace("й", "&jcy;")

        # "U+0043A", "CYRILLIC SMALL LETTER KA"
        txt = txt.replace("к", "&kcy;")

        # "U+0043B", "CYRILLIC SMALL LETTER EL"
        txt = txt.replace("л", "&lcy;")

        # "U+0043C", "CYRILLIC SMALL LETTER EM"
        txt = txt.replace("м", "&mcy;")

        # "U+0043D", "CYRILLIC SMALL LETTER EN"
        txt = txt.replace("н", "&ncy;")

        # "U+0043E", "CYRILLIC SMALL LETTER O"
        txt = txt.replace("о", "&ocy;")

        # "U+0043F", "CYRILLIC SMALL LETTER PE"
        txt = txt.replace("п", "&pcy;")

        # "U+00440", "CYRILLIC SMALL LETTER ER"
        txt = txt.replace("р", "&rcy;")

        # "U+00441", "CYRILLIC SMALL LETTER ES"
        txt = txt.replace("с", "&scy;")

        # "U+00442", "CYRILLIC SMALL LETTER TE"
        txt = txt.replace("т", "&tcy;")

        # "U+00443", "CYRILLIC SMALL LETTER U"
        txt = txt.replace("у", "&ucy;")

        # "U+00444", "CYRILLIC SMALL LETTER EF"
        txt = txt.replace("ф", "&fcy;")

        # "U+00445", "CYRILLIC SMALL LETTER HA"
        txt = txt.replace("х", "&khcy;")

        # "U+00446", "CYRILLIC SMALL LETTER TSE"
        txt = txt.replace("ц", "&tscy;")

        # "U+00447", "CYRILLIC SMALL LETTER CHE"
        txt = txt.replace("ч", "&chcy;")

        # "U+00448", "CYRILLIC SMALL LETTER SHA"
        txt = txt.replace("ш", "&shcy;")

        # "U+00449", "CYRILLIC SMALL LETTER SHCHA"
        txt = txt.replace("щ", "&shchcy;")

        # "U+0044A", "CYRILLIC SMALL LETTER HARD SIGN"
        txt = txt.replace("ъ", "&hardcy;")

        # "U+0044B", "CYRILLIC SMALL LETTER YERU"
        txt = txt.replace("ы", "&ycy;")

        # "U+0044C", "CYRILLIC SMALL LETTER SOFT SIGN"
        txt = txt.replace("ь", "&softcy;")

        # "U+0044D", "CYRILLIC SMALL LETTER E"
        txt = txt.replace("э", "&ecy;")

        # "U+0044E", "CYRILLIC SMALL LETTER YU"
        txt = txt.replace("ю", "&yucy;")

        # "U+0044F", "CYRILLIC SMALL LETTER YA"
        txt = txt.replace("я", "&yacy;")

        # "U+00451", "CYRILLIC SMALL LETTER IO"
        txt = txt.replace("ё", "&iocy;")

        # "U+00452", "CYRILLIC SMALL LETTER DJE"
        txt = txt.replace("ђ", "&djcy;")

        # "U+00453", "CYRILLIC SMALL LETTER GJE"
        txt = txt.replace("ѓ", "&gjcy;")

        # "U+00454", "CYRILLIC SMALL LETTER UKRAINIAN IE"
        txt = txt.replace("є", "&jukcy;")

        # "U+00455", "CYRILLIC SMALL LETTER DZE"
        txt = txt.replace("ѕ", "&dscy;")

        # "U+00456", "CYRILLIC SMALL LETTER BYELORUSSIAN-UKRAINIAN I"
        txt = txt.replace("і", "&iukcy;")

        # "U+00457", "CYRILLIC SMALL LETTER YI"
        txt = txt.replace("ї", "&yicy;")

        # "U+00458", "CYRILLIC SMALL LETTER JE"
        txt = txt.replace("ј", "&jsercy;")

        # "U+00459", "CYRILLIC SMALL LETTER LJE"
        txt = txt.replace("љ", "&ljcy;")

        # "U+0045A", "CYRILLIC SMALL LETTER NJE"
        txt = txt.replace("њ", "&njcy;")

        # "U+0045B", "CYRILLIC SMALL LETTER TSHE"
        txt = txt.replace("ћ", "&tshcy;")

        # "U+0045C", "CYRILLIC SMALL LETTER KJE"
        txt = txt.replace("ќ", "&kjcy;")

        # "U+0045E", "CYRILLIC SMALL LETTER SHORT U"
        txt = txt.replace("ў", "&ubrcy;")

        # "U+0045F", "CYRILLIC SMALL LETTER DZHE"
        txt = txt.replace("џ", "&dzcy;")

        # "U+02002", "EN SPACE"
        txt = txt.replace(" ", "&ensp;")

        # "U+02003", "EM SPACE"
        txt = txt.replace(" ", "&emsp;")

        # "U+02004", "THREE-PER-EM SPACE"
        txt = txt.replace(" ", "&emsp13;")

        # "U+02005", "FOUR-PER-EM SPACE"
        txt = txt.replace(" ", "&emsp14;")

        # "U+02007", "FIGURE SPACE"
        txt = txt.replace(" ", "&numsp;")

        # "U+02008", "PUNCTUATION SPACE"
        txt = txt.replace(" ", "&puncsp;")

        # "U+02009", "THIN SPACE"
        txt = txt.replace(" ", "&thinsp;")

        # "U+0200A", "HAIR SPACE"
        txt = txt.replace(" ", "&hairsp;")

        # "U+0200B", "ZERO WIDTH SPACE"
        txt = txt.replace("​", "&ZeroWidthSpace;")

        # "U+0200C", "ZERO WIDTH NON-JOINER"
        txt = txt.replace("‌", "&zwnj;")

        # "U+0200D", "ZERO WIDTH JOINER"
        txt = txt.replace("‍", "&zwj;")

        # "U+0200E", "LEFT-TO-RIGHT MARK"
        txt = txt.replace("‎", "&lrm;")

        # "U+0200F", "RIGHT-TO-LEFT MARK"
        txt = txt.replace("‏", "&rlm;")

        # "U+02010", "HYPHEN"
        txt = txt.replace("‐", "&hyphen;")

        # "U+02013", "EN DASH"
        txt = txt.replace("–", "&ndash;")

        # "U+02014", "EM DASH"
        txt = txt.replace("—", "&mdash;")

        # "U+02015", "HORIZONTAL BAR"
        txt = txt.replace("―", "&horbar;")

        # "U+02016", "DOUBLE VERTICAL LINE"
        txt = txt.replace("‖", "&Verbar;")

        # "U+02018", "LEFT SINGLE QUOTATION MARK"
        txt = txt.replace("‘", "&lsquo;")

        # "U+02019", "RIGHT SINGLE QUOTATION MARK"
        txt = txt.replace("’", "&rsquo;")

        # "U+0201A", "SINGLE LOW-9 QUOTATION MARK"
        txt = txt.replace("‚", "&lsquor;")

        # "U+0201C", "LEFT DOUBLE QUOTATION MARK"
        txt = txt.replace("“", "&ldquo;")

        # "U+0201D", "RIGHT DOUBLE QUOTATION MARK"
        txt = txt.replace("”", "&rdquo;")

        # "U+0201E", "DOUBLE LOW-9 QUOTATION MARK"
        txt = txt.replace("„", "&ldquor;")

        # "U+02020", "DAGGER"
        txt = txt.replace("†", "&dagger;")

        # "U+02021", "DOUBLE DAGGER"
        txt = txt.replace("‡", "&Dagger;")

        # "U+02022", "BULLET"
        txt = txt.replace("•", "&bull;")

        # "U+02025", "TWO DOT LEADER"
        txt = txt.replace("‥", "&nldr;")

        # "U+02026", "HORIZONTAL ELLIPSIS"
        txt = txt.replace("…", "&hellip;")

        # "U+02030", "PER MILLE SIGN"
        txt = txt.replace("‰", "&permil;")

        # "U+02031", "PER TEN THOUSAND SIGN"
        txt = txt.replace("‱", "&pertenk;")

        # "U+02032", "PRIME"
        txt = txt.replace("′", "&prime;")

        # "U+02033", "DOUBLE PRIME"
        txt = txt.replace("″", "&Prime;")

        # "U+02034", "TRIPLE PRIME"
        txt = txt.replace("‴", "&tprime;")

        # "U+02035", "REVERSED PRIME"
        txt = txt.replace("‵", "&bprime;")

        # "U+02039", "SINGLE LEFT-POINTING ANGLE QUOTATION MARK"
        txt = txt.replace("‹", "&lsaquo;")

        # "U+0203A", "SINGLE RIGHT-POINTING ANGLE QUOTATION MARK"
        txt = txt.replace("›", "&rsaquo;")

        # "U+0203E", "OVERLINE"
        txt = txt.replace("‾", "&oline;")

        # "U+02041", "CARET INSERTION POINT"
        txt = txt.replace("⁁", "&caret;")

        # "U+02043", "HYPHEN BULLET"
        txt = txt.replace("⁃", "&hybull;")

        # "U+02044", "FRACTION SLASH"
        txt = txt.replace("⁄", "&frasl;")

        # "U+0204F", "REVERSED SEMICOLON"
        txt = txt.replace("⁏", "&bsemi;")

        # "U+02057", "QUADRUPLE PRIME"
        txt = txt.replace("⁗", "&qprime;")

        # "U+0205F", "MEDIUM MATHEMATICAL SPACE"
        txt = txt.replace(" ", "&MediumSpace;")

        # "U+02060", "WORD JOINER"
        txt = txt.replace("⁠", "&NoBreak;")

        # "U+02061", "FUNCTION APPLICATION"
        txt = txt.replace("⁡", "&ApplyFunction;")

        # "U+02062", "INVISIBLE TIMES"
        txt = txt.replace("⁢", "&InvisibleTimes;")

        # "U+02063", "INVISIBLE SEPARATOR"
        txt = txt.replace("⁣", "&InvisibleComma;")

        # "U+020AC", "EURO SIGN"
        txt = txt.replace("€", "&euro;")

        # "U+020DB", "COMBINING THREE DOTS ABOVE"
        txt = txt.replace("⃛", "&tdot;")

        # "U+020DC", "COMBINING FOUR DOTS ABOVE"
        txt = txt.replace("⃜", "&DotDot;")

        # "U+02102", "DOUBLE-STRUCK CAPITAL C"
        txt = txt.replace("ℂ", "&Copf;")

        # "U+02105", "CARE OF"
        txt = txt.replace("℅", "&incare;")

        # "U+0210A", "SCRIPT SMALL G"
        txt = txt.replace("ℊ", "&gscr;")

        # "U+0210B", "SCRIPT CAPITAL H"
        txt = txt.replace("ℋ", "&hamilt;")

        # "U+0210C", "BLACK-LETTER CAPITAL H"
        txt = txt.replace("ℌ", "&Hfr;")

        # "U+0210D", "DOUBLE-STRUCK CAPITAL H"
        txt = txt.replace("ℍ", "&quaternions;")

        # "U+0210E", "PLANCK CONSTANT"
        txt = txt.replace("ℎ", "&planckh;")

        # "U+0210F", "PLANCK CONSTANT OVER TWO PI"
        txt = txt.replace("ℏ", "&planck;")

        # "U+02110", "SCRIPT CAPITAL I"
        txt = txt.replace("ℐ", "&Iscr;")

        # "U+02111", "BLACK-LETTER CAPITAL I"
        txt = txt.replace("ℑ", "&image;")

        # "U+02112", "SCRIPT CAPITAL L"
        txt = txt.replace("ℒ", "&Lscr;")

        # "U+02113", "SCRIPT SMALL L"
        txt = txt.replace("ℓ", "&ell;")

        # "U+02115", "DOUBLE-STRUCK CAPITAL N"
        txt = txt.replace("ℕ", "&Nopf;")

        # "U+02116", "NUMERO SIGN"
        txt = txt.replace("№", "&numero;")

        # "U+02117", "SOUND RECORDING COPYRIGHT"
        txt = txt.replace("℗", "&copysr;")

        # "U+02118", "SCRIPT CAPITAL P"
        txt = txt.replace("℘", "&weierp;")

        # "U+02119", "DOUBLE-STRUCK CAPITAL P"
        txt = txt.replace("ℙ", "&Popf;")

        # "U+0211A", "DOUBLE-STRUCK CAPITAL Q"
        txt = txt.replace("ℚ", "&rationals;")

        # "U+0211B", "SCRIPT CAPITAL R"
        txt = txt.replace("ℛ", "&Rscr;")

        # "U+0211C", "BLACK-LETTER CAPITAL R"
        txt = txt.replace("ℜ", "&real;")

        # "U+0211D", "DOUBLE-STRUCK CAPITAL R"
        txt = txt.replace("ℝ", "&reals;")

        # "U+0211E", "PRESCRIPTION TAKE"
        txt = txt.replace("℞", "&rx;")

        # "U+02122", "TRADE MARK SIGN"
        txt = txt.replace("™", "&trade;")

        # "U+02124", "DOUBLE-STRUCK CAPITAL Z"
        txt = txt.replace("ℤ", "&integers;")

        # "U+02126", "OHM SIGN"
        txt = txt.replace("Ω", "&ohm;")

        # "U+02127", "INVERTED OHM SIGN"
        txt = txt.replace("℧", "&mho;")

        # "U+02128", "BLACK-LETTER CAPITAL Z"
        txt = txt.replace("ℨ", "&Zfr;")

        # "U+02129", "TURNED GREEK SMALL LETTER IOTA"
        txt = txt.replace("℩", "&iiota;")

        # "U+0212B", "ANGSTROM SIGN"
        txt = txt.replace("Å", "&angst;")

        # "U+0212C", "SCRIPT CAPITAL B"
        txt = txt.replace("ℬ", "&bernou;")

        # "U+0212D", "BLACK-LETTER CAPITAL C"
        txt = txt.replace("ℭ", "&Cfr;")

        # "U+0212F", "SCRIPT SMALL E"
        txt = txt.replace("ℯ", "&escr;")

        # "U+02130", "SCRIPT CAPITAL E"
        txt = txt.replace("ℰ", "&Escr;")

        # "U+02131", "SCRIPT CAPITAL F"
        txt = txt.replace("ℱ", "&Fscr;")

        # "U+02133", "SCRIPT CAPITAL M"
        txt = txt.replace("ℳ", "&phmmat;")

        # "U+02134", "SCRIPT SMALL O"
        txt = txt.replace("ℴ", "&order;")

        # "U+02135", "ALEF SYMBOL"
        txt = txt.replace("ℵ", "&alefsym;")

        # "U+02136", "BET SYMBOL"
        txt = txt.replace("ℶ", "&beth;")

        # "U+02137", "GIMEL SYMBOL"
        txt = txt.replace("ℷ", "&gimel;")

        # "U+02138", "DALET SYMBOL"
        txt = txt.replace("ℸ", "&daleth;")

        # "U+02145", "DOUBLE-STRUCK ITALIC CAPITAL D"
        txt = txt.replace("ⅅ", "&CapitalDifferentialD;")

        # "U+02146", "DOUBLE-STRUCK ITALIC SMALL D"
        txt = txt.replace("ⅆ", "&DifferentialD;")

        # "U+02147", "DOUBLE-STRUCK ITALIC SMALL E"
        txt = txt.replace("ⅇ", "&ExponentialE;")

        # "U+02148", "DOUBLE-STRUCK ITALIC SMALL I"
        txt = txt.replace("ⅈ", "&ImaginaryI;")

        # "U+02153", "VULGAR FRACTION ONE THIRD"
        txt = txt.replace("⅓", "&frac13;")

        # "U+02154", "VULGAR FRACTION TWO THIRDS"
        txt = txt.replace("⅔", "&frac23;")

        # "U+02155", "VULGAR FRACTION ONE FIFTH"
        txt = txt.replace("⅕", "&frac15;")

        # "U+02156", "VULGAR FRACTION TWO FIFTHS"
        txt = txt.replace("⅖", "&frac25;")

        # "U+02157", "VULGAR FRACTION THREE FIFTHS"
        txt = txt.replace("⅗", "&frac35;")

        # "U+02158", "VULGAR FRACTION FOUR FIFTHS"
        txt = txt.replace("⅘", "&frac45;")

        # "U+02159", "VULGAR FRACTION ONE SIXTH"
        txt = txt.replace("⅙", "&frac16;")

        # "U+0215A", "VULGAR FRACTION FIVE SIXTHS"
        txt = txt.replace("⅚", "&frac56;")

        # "U+0215B", "VULGAR FRACTION ONE EIGHTH"
        txt = txt.replace("⅛", "&frac18;")

        # "U+0215C", "VULGAR FRACTION THREE EIGHTHS"
        txt = txt.replace("⅜", "&frac38;")

        # "U+0215D", "VULGAR FRACTION FIVE EIGHTHS"
        txt = txt.replace("⅝", "&frac58;")

        # "U+0215E", "VULGAR FRACTION SEVEN EIGHTHS"
        txt = txt.replace("⅞", "&frac78;")

        # "U+02190", "LEFTWARDS ARROW"
        txt = txt.replace("←", "&larr;")

        # "U+02191", "UPWARDS ARROW"
        txt = txt.replace("↑", "&uarr;")

        # "U+02192", "RIGHTWARDS ARROW"
        txt = txt.replace("→", "&rarr;")

        # "U+02193", "DOWNWARDS ARROW"
        txt = txt.replace("↓", "&darr;")

        # "U+02194", "LEFT RIGHT ARROW"
        txt = txt.replace("↔", "&harr;")

        # "U+02195", "UP DOWN ARROW"
        txt = txt.replace("↕", "&varr;")

        # "U+02196", "NORTH WEST ARROW"
        txt = txt.replace("↖", "&nwarr;")

        # "U+02197", "NORTH EAST ARROW"
        txt = txt.replace("↗", "&nearr;")

        # "U+02198", "SOUTH EAST ARROW"
        txt = txt.replace("↘", "&searr;")

        # "U+02199", "SOUTH WEST ARROW"
        txt = txt.replace("↙", "&swarr;")

        # "U+0219A", "LEFTWARDS ARROW WITH STROKE"
        txt = txt.replace("↚", "&nlarr;")

        # "U+0219B", "RIGHTWARDS ARROW WITH STROKE"
        txt = txt.replace("↛", "&nrarr;")

        # "U+0219D", "RIGHTWARDS WAVE ARROW"
        txt = txt.replace("↝", "&rarrw;")

        # "U+0219E", "LEFTWARDS TWO HEADED ARROW"
        txt = txt.replace("↞", "&Larr;")

        # "U+0219F", "UPWARDS TWO HEADED ARROW"
        txt = txt.replace("↟", "&Uarr;")

        # "U+021A0", "RIGHTWARDS TWO HEADED ARROW"
        txt = txt.replace("↠", "&Rarr;")

        # "U+021A1", "DOWNWARDS TWO HEADED ARROW"
        txt = txt.replace("↡", "&Darr;")

        # "U+021A2", "LEFTWARDS ARROW WITH TAIL"
        txt = txt.replace("↢", "&larrtl;")

        # "U+021A3", "RIGHTWARDS ARROW WITH TAIL"
        txt = txt.replace("↣", "&rarrtl;")

        # "U+021A4", "LEFTWARDS ARROW FROM BAR"
        txt = txt.replace("↤", "&LeftTeeArrow;")

        # "U+021A5", "UPWARDS ARROW FROM BAR"
        txt = txt.replace("↥", "&UpTeeArrow;")

        # "U+021A6", "RIGHTWARDS ARROW FROM BAR"
        txt = txt.replace("↦", "&map;")

        # "U+021A7", "DOWNWARDS ARROW FROM BAR"
        txt = txt.replace("↧", "&DownTeeArrow;")

        # "U+021A9", "LEFTWARDS ARROW WITH HOOK"
        txt = txt.replace("↩", "&larrhk;")

        # "U+021AA", "RIGHTWARDS ARROW WITH HOOK"
        txt = txt.replace("↪", "&rarrhk;")

        # "U+021AB", "LEFTWARDS ARROW WITH LOOP"
        txt = txt.replace("↫", "&larrlp;")

        # "U+021AC", "RIGHTWARDS ARROW WITH LOOP"
        txt = txt.replace("↬", "&rarrlp;")

        # "U+021AD", "LEFT RIGHT WAVE ARROW"
        txt = txt.replace("↭", "&harrw;")

        # "U+021AE", "LEFT RIGHT ARROW WITH STROKE"
        txt = txt.replace("↮", "&nharr;")

        # "U+021B0", "UPWARDS ARROW WITH TIP LEFTWARDS"
        txt = txt.replace("↰", "&lsh;")

        # "U+021B1", "UPWARDS ARROW WITH TIP RIGHTWARDS"
        txt = txt.replace("↱", "&rsh;")

        # "U+021B2", "DOWNWARDS ARROW WITH TIP LEFTWARDS"
        txt = txt.replace("↲", "&ldsh;")

        # "U+021B3", "DOWNWARDS ARROW WITH TIP RIGHTWARDS"
        txt = txt.replace("↳", "&rdsh;")

        # "U+021B5", "DOWNWARDS ARROW WITH CORNER LEFTWARDS"
        txt = txt.replace("↵", "&crarr;")

        # "U+021B6", "ANTICLOCKWISE TOP SEMICIRCLE ARROW"
        txt = txt.replace("↶", "&cularr;")

        # "U+021B7", "CLOCKWISE TOP SEMICIRCLE ARROW"
        txt = txt.replace("↷", "&curarr;")

        # "U+021BA", "ANTICLOCKWISE OPEN CIRCLE ARROW"
        txt = txt.replace("↺", "&olarr;")

        # "U+021BB", "CLOCKWISE OPEN CIRCLE ARROW"
        txt = txt.replace("↻", "&orarr;")

        # "U+021BC", "LEFTWARDS HARPOON WITH BARB UPWARDS"
        txt = txt.replace("↼", "&lharu;")

        # "U+021BD", "LEFTWARDS HARPOON WITH BARB DOWNWARDS"
        txt = txt.replace("↽", "&lhard;")

        # "U+021BE", "UPWARDS HARPOON WITH BARB RIGHTWARDS"
        txt = txt.replace("↾", "&uharr;")

        # "U+021BF", "UPWARDS HARPOON WITH BARB LEFTWARDS"
        txt = txt.replace("↿", "&uharl;")

        # "U+021C0", "RIGHTWARDS HARPOON WITH BARB UPWARDS"
        txt = txt.replace("⇀", "&rharu;")

        # "U+021C1", "RIGHTWARDS HARPOON WITH BARB DOWNWARDS"
        txt = txt.replace("⇁", "&rhard;")

        # "U+021C2", "DOWNWARDS HARPOON WITH BARB RIGHTWARDS"
        txt = txt.replace("⇂", "&dharr;")

        # "U+021C3", "DOWNWARDS HARPOON WITH BARB LEFTWARDS"
        txt = txt.replace("⇃", "&dharl;")

        # "U+021C4", "RIGHTWARDS ARROW OVER LEFTWARDS ARROW"
        txt = txt.replace("⇄", "&rlarr;")

        # "U+021C5", "UPWARDS ARROW LEFTWARDS OF DOWNWARDS ARROW"
        txt = txt.replace("⇅", "&udarr;")

        # "U+021C6", "LEFTWARDS ARROW OVER RIGHTWARDS ARROW"
        txt = txt.replace("⇆", "&lrarr;")

        # "U+021C7", "LEFTWARDS PAIRED ARROWS"
        txt = txt.replace("⇇", "&llarr;")

        # "U+021C8", "UPWARDS PAIRED ARROWS"
        txt = txt.replace("⇈", "&uuarr;")

        # "U+021C9", "RIGHTWARDS PAIRED ARROWS"
        txt = txt.replace("⇉", "&rrarr;")

        # "U+021CA", "DOWNWARDS PAIRED ARROWS"
        txt = txt.replace("⇊", "&ddarr;")

        # "U+021CB", "LEFTWARDS HARPOON OVER RIGHTWARDS HARPOON"
        txt = txt.replace("⇋", "&lrhar;")

        # "U+021CC", "RIGHTWARDS HARPOON OVER LEFTWARDS HARPOON"
        txt = txt.replace("⇌", "&rlhar;")

        # "U+021CD", "LEFTWARDS DOUBLE ARROW WITH STROKE"
        txt = txt.replace("⇍", "&nlArr;")

        # "U+021CE", "LEFT RIGHT DOUBLE ARROW WITH STROKE"
        txt = txt.replace("⇎", "&nhArr;")

        # "U+021CF", "RIGHTWARDS DOUBLE ARROW WITH STROKE"
        txt = txt.replace("⇏", "&nrArr;")

        # "U+021D0", "LEFTWARDS DOUBLE ARROW"
        txt = txt.replace("⇐", "&lArr;")

        # "U+021D1", "UPWARDS DOUBLE ARROW"
        txt = txt.replace("⇑", "&uArr;")

        # "U+021D2", "RIGHTWARDS DOUBLE ARROW"
        txt = txt.replace("⇒", "&rArr;")

        # "U+021D3", "DOWNWARDS DOUBLE ARROW"
        txt = txt.replace("⇓", "&dArr;")

        # "U+021D4", "LEFT RIGHT DOUBLE ARROW"
        txt = txt.replace("⇔", "&hArr;")

        # "U+021D5", "UP DOWN DOUBLE ARROW"
        txt = txt.replace("⇕", "&vArr;")

        # "U+021D6", "NORTH WEST DOUBLE ARROW"
        txt = txt.replace("⇖", "&nwArr;")

        # "U+021D7", "NORTH EAST DOUBLE ARROW"
        txt = txt.replace("⇗", "&neArr;")

        # "U+021D8", "SOUTH EAST DOUBLE ARROW"
        txt = txt.replace("⇘", "&seArr;")

        # "U+021D9", "SOUTH WEST DOUBLE ARROW"
        txt = txt.replace("⇙", "&swArr;")

        # "U+021DA", "LEFTWARDS TRIPLE ARROW"
        txt = txt.replace("⇚", "&lAarr;")

        # "U+021DB", "RIGHTWARDS TRIPLE ARROW"
        txt = txt.replace("⇛", "&rAarr;")

        # "U+021DD", "RIGHTWARDS SQUIGGLE ARROW"
        txt = txt.replace("⇝", "&zigrarr;")

        # "U+021E4", "LEFTWARDS ARROW TO BAR"
        txt = txt.replace("⇤", "&larrb;")

        # "U+021E5", "RIGHTWARDS ARROW TO BAR"
        txt = txt.replace("⇥", "&rarrb;")

        # "U+021F5", "DOWNWARDS ARROW LEFTWARDS OF UPWARDS ARROW"
        txt = txt.replace("⇵", "&duarr;")

        # "U+021FD", "LEFTWARDS OPEN-HEADED ARROW"
        txt = txt.replace("⇽", "&loarr;")

        # "U+021FE", "RIGHTWARDS OPEN-HEADED ARROW"
        txt = txt.replace("⇾", "&roarr;")

        # "U+021FF", "LEFT RIGHT OPEN-HEADED ARROW"
        txt = txt.replace("⇿", "&hoarr;")

        # "U+02200", "FOR ALL"
        txt = txt.replace("∀", "&forall;")

        # "U+02201", "COMPLEMENT"
        txt = txt.replace("∁", "&comp;")

        # "U+02202", "PARTIAL DIFFERENTIAL"
        txt = txt.replace("∂", "&part;")

        # "U+02203", "THERE EXISTS"
        txt = txt.replace("∃", "&exist;")

        # "U+02204", "THERE DOES NOT EXIST"
        txt = txt.replace("∄", "&nexist;")

        # "U+02205", "EMPTY SET"
        txt = txt.replace("∅", "&empty;")

        # "U+02207", "NABLA"
        txt = txt.replace("∇", "&nabla;")

        # "U+02208", "ELEMENT OF"
        txt = txt.replace("∈", "&isin;")

        # "U+02209", "NOT AN ELEMENT OF"
        txt = txt.replace("∉", "&notin;")

        # "U+0220B", "CONTAINS AS MEMBER"
        txt = txt.replace("∋", "&niv;")

        # "U+0220C", "DOES NOT CONTAIN AS MEMBER"
        txt = txt.replace("∌", "&notni;")

        # "U+0220F", "N-ARY PRODUCT"
        txt = txt.replace("∏", "&prod;")

        # "U+02210", "N-ARY COPRODUCT"
        txt = txt.replace("∐", "&coprod;")

        # "U+02211", "N-ARY SUMMATION"
        txt = txt.replace("∑", "&sum;")

        # "U+02212", "MINUS SIGN"
        txt = txt.replace("−", "&minus;")

        # "U+02213", "MINUS-OR-PLUS SIGN"
        txt = txt.replace("∓", "&mnplus;")

        # "U+02214", "DOT PLUS"
        txt = txt.replace("∔", "&plusdo;")

        # "U+02216", "SET MINUS"
        txt = txt.replace("∖", "&setmn;")

        # "U+02217", "ASTERISK OPERATOR"
        txt = txt.replace("∗", "&lowast;")

        # "U+02218", "RING OPERATOR"
        txt = txt.replace("∘", "&compfn;")

        # "U+0221A", "SQUARE ROOT"
        txt = txt.replace("√", "&radic;")

        # "U+0221D", "PROPORTIONAL TO"
        txt = txt.replace("∝", "&prop;")

        # "U+0221E", "INFINITY"
        txt = txt.replace("∞", "&infin;")

        # "U+0221F", "RIGHT ANGLE"
        txt = txt.replace("∟", "&angrt;")

        # "U+02220", "ANGLE"
        txt = txt.replace("∠", "&ang;")

        # "U+02221", "MEASURED ANGLE"
        txt = txt.replace("∡", "&angmsd;")

        # "U+02222", "SPHERICAL ANGLE"
        txt = txt.replace("∢", "&angsph;")

        # "U+02223", "DIVIDES"
        txt = txt.replace("∣", "&mid;")

        # "U+02224", "DOES NOT DIVIDE"
        txt = txt.replace("∤", "&nmid;")

        # "U+02225", "PARALLEL TO"
        txt = txt.replace("∥", "&par;")

        # "U+02226", "NOT PARALLEL TO"
        txt = txt.replace("∦", "&npar;")

        # "U+02227", "LOGICAL AND"
        txt = txt.replace("∧", "&and;")

        # "U+02228", "LOGICAL OR"
        txt = txt.replace("∨", "&or;")

        # "U+02229", "INTERSECTION"
        txt = txt.replace("∩", "&cap;")

        # "U+0222A", "UNION"
        txt = txt.replace("∪", "&cup;")

        # "U+0222B", "INTEGRAL"
        txt = txt.replace("∫", "&int;")

        # "U+0222C", "DOUBLE INTEGRAL"
        txt = txt.replace("∬", "&Int;")

        # "U+0222D", "TRIPLE INTEGRAL"
        txt = txt.replace("∭", "&tint;")

        # "U+0222E", "CONTOUR INTEGRAL"
        txt = txt.replace("∮", "&conint;")

        # "U+0222F", "SURFACE INTEGRAL"
        txt = txt.replace("∯", "&Conint;")

        # "U+02230", "VOLUME INTEGRAL"
        txt = txt.replace("∰", "&Cconint;")

        # "U+02231", "CLOCKWISE INTEGRAL"
        txt = txt.replace("∱", "&cwint;")

        # "U+02232", "CLOCKWISE CONTOUR INTEGRAL"
        txt = txt.replace("∲", "&cwconint;")

        # "U+02233", "ANTICLOCKWISE CONTOUR INTEGRAL"
        txt = txt.replace("∳", "&awconint;")

        # "U+02234", "THEREFORE"
        txt = txt.replace("∴", "&there4;")

        # "U+02235", "BECAUSE"
        txt = txt.replace("∵", "&becaus;")

        # "U+02236", "RATIO"
        txt = txt.replace("∶", "&ratio;")

        # "U+02237", "PROPORTION"
        txt = txt.replace("∷", "&Colon;")

        # "U+02238", "DOT MINUS"
        txt = txt.replace("∸", "&minusd;")

        # "U+0223A", "GEOMETRIC PROPORTION"
        txt = txt.replace("∺", "&mDDot;")

        # "U+0223B", "HOMOTHETIC"
        txt = txt.replace("∻", "&homtht;")

        # "U+0223C", "TILDE OPERATOR"
        txt = txt.replace("∼", "&sim;")

        # "U+0223D", "REVERSED TILDE"
        txt = txt.replace("∽", "&bsim;")

        # "U+0223E", "INVERTED LAZY S"
        txt = txt.replace("∾", "&ac;")

        # "U+0223F", "SINE WAVE"
        txt = txt.replace("∿", "&acd;")

        # "U+02240", "WREATH PRODUCT"
        txt = txt.replace("≀", "&wreath;")

        # "U+02241", "NOT TILDE"
        txt = txt.replace("≁", "&nsim;")

        # "U+02242", "MINUS TILDE"
        txt = txt.replace("≂", "&esim;")

        # "U+02243", "ASYMPTOTICALLY EQUAL TO"
        txt = txt.replace("≃", "&sime;")

        # "U+02244", "NOT ASYMPTOTICALLY EQUAL TO"
        txt = txt.replace("≄", "&nsime;")

        # "U+02245", "APPROXIMATELY EQUAL TO"
        txt = txt.replace("≅", "&cong;")

        # "U+02246", "APPROXIMATELY BUT NOT ACTUALLY EQUAL TO"
        txt = txt.replace("≆", "&simne;")

        # "U+02247", "NEITHER APPROXIMATELY NOR ACTUALLY EQUAL TO"
        txt = txt.replace("≇", "&ncong;")

        # "U+02248", "ALMOST EQUAL TO"
        txt = txt.replace("≈", "&asymp;")

        # "U+02249", "NOT ALMOST EQUAL TO"
        txt = txt.replace("≉", "&nap;")

        # "U+0224A", "ALMOST EQUAL OR EQUAL TO"
        txt = txt.replace("≊", "&ape;")

        # "U+0224B", "TRIPLE TILDE"
        txt = txt.replace("≋", "&apid;")

        # "U+0224C", "ALL EQUAL TO"
        txt = txt.replace("≌", "&bcong;")

        # "U+0224D", "EQUIVALENT TO"
        txt = txt.replace("≍", "&asympeq;")

        # "U+0224E", "GEOMETRICALLY EQUIVALENT TO"
        txt = txt.replace("≎", "&bump;")

        # "U+0224F", "DIFFERENCE BETWEEN"
        txt = txt.replace("≏", "&bumpe;")

        # "U+02250", "APPROACHES THE LIMIT"
        txt = txt.replace("≐", "&esdot;")

        # "U+02251", "GEOMETRICALLY EQUAL TO"
        txt = txt.replace("≑", "&eDot;")

        # "U+02252", "APPROXIMATELY EQUAL TO OR THE IMAGE OF"
        txt = txt.replace("≒", "&efDot;")

        # "U+02253", "IMAGE OF OR APPROXIMATELY EQUAL TO"
        txt = txt.replace("≓", "&erDot;")

        # "U+02254", "COLON EQUALS"
        txt = txt.replace("≔", "&colone;")

        # "U+02255", "EQUALS COLON"
        txt = txt.replace("≕", "&ecolon;")

        # "U+02256", "RING IN EQUAL TO"
        txt = txt.replace("≖", "&ecir;")

        # "U+02257", "RING EQUAL TO"
        txt = txt.replace("≗", "&cire;")

        # "U+02259", "ESTIMATES"
        txt = txt.replace("≙", "&wedgeq;")

        # "U+0225A", "EQUIANGULAR TO"
        txt = txt.replace("≚", "&veeeq;")

        # "U+0225C", "DELTA EQUAL TO"
        txt = txt.replace("≜", "&trie;")

        # "U+0225F", "QUESTIONED EQUAL TO"
        txt = txt.replace("≟", "&equest;")

        # "U+02260", "NOT EQUAL TO"
        txt = txt.replace("≠", "&ne;")

        # "U+02261", "IDENTICAL TO"
        txt = txt.replace("≡", "&equiv;")

        # "U+02262", "NOT IDENTICAL TO"
        txt = txt.replace("≢", "&nequiv;")

        # "U+02264", "LESS-THAN OR EQUAL TO"
        txt = txt.replace("≤", "&le;")

        # "U+02265", "GREATER-THAN OR EQUAL TO"
        txt = txt.replace("≥", "&ge;")

        # "U+02266", "LESS-THAN OVER EQUAL TO"
        txt = txt.replace("≦", "&lE;")

        # "U+02267", "GREATER-THAN OVER EQUAL TO"
        txt = txt.replace("≧", "&gE;")

        # "U+02268", "LESS-THAN BUT NOT EQUAL TO"
        txt = txt.replace("≨", "&lnE;")

        # "U+02269", "GREATER-THAN BUT NOT EQUAL TO"
        txt = txt.replace("≩", "&gnE;")

        # "U+0226A", "MUCH LESS-THAN"
        txt = txt.replace("≪", "&Lt;")

        # "U+0226B", "MUCH GREATER-THAN"
        txt = txt.replace("≫", "&Gt;")

        # "U+0226C", "BETWEEN"
        txt = txt.replace("≬", "&twixt;")

        # "U+0226D", "NOT EQUIVALENT TO"
        txt = txt.replace("≭", "&NotCupCap;")

        # "U+0226E", "NOT LESS-THAN"
        txt = txt.replace("≮", "&nlt;")

        # "U+0226F", "NOT GREATER-THAN"
        txt = txt.replace("≯", "&ngt;")

        # "U+02270", "NEITHER LESS-THAN NOR EQUAL TO"
        txt = txt.replace("≰", "&nle;")

        # "U+02271", "NEITHER GREATER-THAN NOR EQUAL TO"
        txt = txt.replace("≱", "&nge;")

        # "U+02272", "LESS-THAN OR EQUIVALENT TO"
        txt = txt.replace("≲", "&lsim;")

        # "U+02273", "GREATER-THAN OR EQUIVALENT TO"
        txt = txt.replace("≳", "&gsim;")

        # "U+02274", "NEITHER LESS-THAN NOR EQUIVALENT TO"
        txt = txt.replace("≴", "&nlsim;")

        # "U+02275", "NEITHER GREATER-THAN NOR EQUIVALENT TO"
        txt = txt.replace("≵", "&ngsim;")

        # "U+02276", "LESS-THAN OR GREATER-THAN"
        txt = txt.replace("≶", "&lg;")

        # "U+02277", "GREATER-THAN OR LESS-THAN"
        txt = txt.replace("≷", "&gl;")

        # "U+02278", "NEITHER LESS-THAN NOR GREATER-THAN"
        txt = txt.replace("≸", "&ntlg;")

        # "U+02279", "NEITHER GREATER-THAN NOR LESS-THAN"
        txt = txt.replace("≹", "&ntgl;")

        # "U+0227A", "PRECEDES"
        txt = txt.replace("≺", "&pr;")

        # "U+0227B", "SUCCEEDS"
        txt = txt.replace("≻", "&sc;")

        # "U+0227C", "PRECEDES OR EQUAL TO"
        txt = txt.replace("≼", "&prcue;")

        # "U+0227D", "SUCCEEDS OR EQUAL TO"
        txt = txt.replace("≽", "&sccue;")

        # "U+0227E", "PRECEDES OR EQUIVALENT TO"
        txt = txt.replace("≾", "&prsim;")

        # "U+0227F", "SUCCEEDS OR EQUIVALENT TO"
        txt = txt.replace("≿", "&scsim;")

        # "U+02280", "DOES NOT PRECEDE"
        txt = txt.replace("⊀", "&npr;")

        # "U+02281", "DOES NOT SUCCEED"
        txt = txt.replace("⊁", "&nsc;")

        # "U+02282", "SUBSET OF"
        txt = txt.replace("⊂", "&sub;")

        # "U+02283", "SUPERSET OF"
        txt = txt.replace("⊃", "&sup;")

        # "U+02284", "NOT A SUBSET OF"
        txt = txt.replace("⊄", "&nsub;")

        # "U+02285", "NOT A SUPERSET OF"
        txt = txt.replace("⊅", "&nsup;")

        # "U+02286", "SUBSET OF OR EQUAL TO"
        txt = txt.replace("⊆", "&sube;")

        # "U+02287", "SUPERSET OF OR EQUAL TO"
        txt = txt.replace("⊇", "&supe;")

        # "U+02288", "NEITHER A SUBSET OF NOR EQUAL TO"
        txt = txt.replace("⊈", "&nsube;")

        # "U+02289", "NEITHER A SUPERSET OF NOR EQUAL TO"
        txt = txt.replace("⊉", "&nsupe;")

        # "U+0228A", "SUBSET OF WITH NOT EQUAL TO"
        txt = txt.replace("⊊", "&subne;")

        # "U+0228B", "SUPERSET OF WITH NOT EQUAL TO"
        txt = txt.replace("⊋", "&supne;")

        # "U+0228D", "MULTISET MULTIPLICATION"
        txt = txt.replace("⊍", "&cupdot;")

        # "U+0228E", "MULTISET UNION"
        txt = txt.replace("⊎", "&uplus;")

        # "U+0228F", "SQUARE IMAGE OF"
        txt = txt.replace("⊏", "&sqsub;")

        # "U+02290", "SQUARE ORIGINAL OF"
        txt = txt.replace("⊐", "&sqsup;")

        # "U+02291", "SQUARE IMAGE OF OR EQUAL TO"
        txt = txt.replace("⊑", "&sqsube;")

        # "U+02292", "SQUARE ORIGINAL OF OR EQUAL TO"
        txt = txt.replace("⊒", "&sqsupe;")

        # "U+02293", "SQUARE CAP"
        txt = txt.replace("⊓", "&sqcap;")

        # "U+02294", "SQUARE CUP"
        txt = txt.replace("⊔", "&sqcup;")

        # "U+02295", "CIRCLED PLUS"
        txt = txt.replace("⊕", "&oplus;")

        # "U+02296", "CIRCLED MINUS"
        txt = txt.replace("⊖", "&ominus;")

        # "U+02297", "CIRCLED TIMES"
        txt = txt.replace("⊗", "&otimes;")

        # "U+02298", "CIRCLED DIVISION SLASH"
        txt = txt.replace("⊘", "&osol;")

        # "U+02299", "CIRCLED DOT OPERATOR"
        txt = txt.replace("⊙", "&odot;")

        # "U+0229A", "CIRCLED RING OPERATOR"
        txt = txt.replace("⊚", "&ocir;")

        # "U+0229B", "CIRCLED ASTERISK OPERATOR"
        txt = txt.replace("⊛", "&oast;")

        # "U+0229D", "CIRCLED DASH"
        txt = txt.replace("⊝", "&odash;")

        # "U+0229E", "SQUARED PLUS"
        txt = txt.replace("⊞", "&plusb;")

        # "U+0229F", "SQUARED MINUS"
        txt = txt.replace("⊟", "&minusb;")

        # "U+022A0", "SQUARED TIMES"
        txt = txt.replace("⊠", "&timesb;")

        # "U+022A1", "SQUARED DOT OPERATOR"
        txt = txt.replace("⊡", "&sdotb;")

        # "U+022A2", "RIGHT TACK"
        txt = txt.replace("⊢", "&vdash;")

        # "U+022A3", "LEFT TACK"
        txt = txt.replace("⊣", "&dashv;")

        # "U+022A4", "DOWN TACK"
        txt = txt.replace("⊤", "&top;")

        # "U+022A5", "UP TACK"
        txt = txt.replace("⊥", "&bottom;")

        # "U+022A7", "MODELS"
        txt = txt.replace("⊧", "&models;")

        # "U+022A8", "TRUE"
        txt = txt.replace("⊨", "&vDash;")

        # "U+022A9", "FORCES"
        txt = txt.replace("⊩", "&Vdash;")

        # "U+022AA", "TRIPLE VERTICAL BAR RIGHT TURNSTILE"
        txt = txt.replace("⊪", "&Vvdash;")

        # "U+022AB", "DOUBLE VERTICAL BAR DOUBLE RIGHT TURNSTILE"
        txt = txt.replace("⊫", "&VDash;")

        # "U+022AC", "DOES NOT PROVE"
        txt = txt.replace("⊬", "&nvdash;")

        # "U+022AD", "NOT TRUE"
        txt = txt.replace("⊭", "&nvDash;")

        # "U+022AE", "DOES NOT FORCE"
        txt = txt.replace("⊮", "&nVdash;")

        # "U+022AF", "NEGATED DOUBLE VERTICAL BAR DOUBLE RIGHT TURNSTILE"
        txt = txt.replace("⊯", "&nVDash;")

        # "U+022B0", "PRECEDES UNDER RELATION"
        txt = txt.replace("⊰", "&prurel;")

        # "U+022B2", "NORMAL SUBGROUP OF"
        txt = txt.replace("⊲", "&vltri;")

        # "U+022B3", "CONTAINS AS NORMAL SUBGROUP"
        txt = txt.replace("⊳", "&vrtri;")

        # "U+022B4", "NORMAL SUBGROUP OF OR EQUAL TO"
        txt = txt.replace("⊴", "&ltrie;")

        # "U+022B5", "CONTAINS AS NORMAL SUBGROUP OR EQUAL TO"
        txt = txt.replace("⊵", "&rtrie;")

        # "U+022B6", "ORIGINAL OF"
        txt = txt.replace("⊶", "&origof;")

        # "U+022B7", "IMAGE OF"
        txt = txt.replace("⊷", "&imof;")

        # "U+022B8", "MULTIMAP"
        txt = txt.replace("⊸", "&mumap;")

        # "U+022B9", "HERMITIAN CONJUGATE MATRIX"
        txt = txt.replace("⊹", "&hercon;")

        # "U+022BA", "INTERCALATE"
        txt = txt.replace("⊺", "&intcal;")

        # "U+022BB", "XOR"
        txt = txt.replace("⊻", "&veebar;")

        # "U+022BD", "NOR"
        txt = txt.replace("⊽", "&barvee;")

        # "U+022BE", "RIGHT ANGLE WITH ARC"
        txt = txt.replace("⊾", "&angrtvb;")

        # "U+022BF", "RIGHT TRIANGLE"
        txt = txt.replace("⊿", "&lrtri;")

        # "U+022C0", "N-ARY LOGICAL AND"
        txt = txt.replace("⋀", "&xwedge;")

        # "U+022C1", "N-ARY LOGICAL OR"
        txt = txt.replace("⋁", "&xvee;")

        # "U+022C2", "N-ARY INTERSECTION"
        txt = txt.replace("⋂", "&xcap;")

        # "U+022C3", "N-ARY UNION"
        txt = txt.replace("⋃", "&xcup;")

        # "U+022C4", "DIAMOND OPERATOR"
        txt = txt.replace("⋄", "&diam;")

        # "U+022C5", "DOT OPERATOR"
        txt = txt.replace("⋅", "&sdot;")

        # "U+022C6", "STAR OPERATOR"
        txt = txt.replace("⋆", "&sstarf;")

        # "U+022C7", "DIVISION TIMES"
        txt = txt.replace("⋇", "&divonx;")

        # "U+022C8", "BOWTIE"
        txt = txt.replace("⋈", "&bowtie;")

        # "U+022C9", "LEFT NORMAL FACTOR SEMIDIRECT PRODUCT"
        txt = txt.replace("⋉", "&ltimes;")

        # "U+022CA", "RIGHT NORMAL FACTOR SEMIDIRECT PRODUCT"
        txt = txt.replace("⋊", "&rtimes;")

        # "U+022CB", "LEFT SEMIDIRECT PRODUCT"
        txt = txt.replace("⋋", "&lthree;")

        # "U+022CC", "RIGHT SEMIDIRECT PRODUCT"
        txt = txt.replace("⋌", "&rthree;")

        # "U+022CD", "REVERSED TILDE EQUALS"
        txt = txt.replace("⋍", "&bsime;")

        # "U+022CE", "CURLY LOGICAL OR"
        txt = txt.replace("⋎", "&cuvee;")

        # "U+022CF", "CURLY LOGICAL AND"
        txt = txt.replace("⋏", "&cuwed;")

        # "U+022D0", "DOUBLE SUBSET"
        txt = txt.replace("⋐", "&Sub;")

        # "U+022D1", "DOUBLE SUPERSET"
        txt = txt.replace("⋑", "&Sup;")

        # "U+022D2", "DOUBLE INTERSECTION"
        txt = txt.replace("⋒", "&Cap;")

        # "U+022D3", "DOUBLE UNION"
        txt = txt.replace("⋓", "&Cup;")

        # "U+022D4", "PITCHFORK"
        txt = txt.replace("⋔", "&fork;")

        # "U+022D5", "EQUAL AND PARALLEL TO"
        txt = txt.replace("⋕", "&epar;")

        # "U+022D6", "LESS-THAN WITH DOT"
        txt = txt.replace("⋖", "&ltdot;")

        # "U+022D7", "GREATER-THAN WITH DOT"
        txt = txt.replace("⋗", "&gtdot;")

        # "U+022D8", "VERY MUCH LESS-THAN"
        txt = txt.replace("⋘", "&Ll;")

        # "U+022D9", "VERY MUCH GREATER-THAN"
        txt = txt.replace("⋙", "&Gg;")

        # "U+022DA", "LESS-THAN EQUAL TO OR GREATER-THAN"
        txt = txt.replace("⋚", "&leg;")

        # "U+022DB", "GREATER-THAN EQUAL TO OR LESS-THAN"
        txt = txt.replace("⋛", "&gel;")

        # "U+022DE", "EQUAL TO OR PRECEDES"
        txt = txt.replace("⋞", "&cuepr;")

        # "U+022DF", "EQUAL TO OR SUCCEEDS"
        txt = txt.replace("⋟", "&cuesc;")

        # "U+022E0", "DOES NOT PRECEDE OR EQUAL"
        txt = txt.replace("⋠", "&nprcue;")

        # "U+022E1", "DOES NOT SUCCEED OR EQUAL"
        txt = txt.replace("⋡", "&nsccue;")

        # "U+022E2", "NOT SQUARE IMAGE OF OR EQUAL TO"
        txt = txt.replace("⋢", "&nsqsube;")

        # "U+022E3", "NOT SQUARE ORIGINAL OF OR EQUAL TO"
        txt = txt.replace("⋣", "&nsqsupe;")

        # "U+022E6", "LESS-THAN BUT NOT EQUIVALENT TO"
        txt = txt.replace("⋦", "&lnsim;")

        # "U+022E7", "GREATER-THAN BUT NOT EQUIVALENT TO"
        txt = txt.replace("⋧", "&gnsim;")

        # "U+022E8", "PRECEDES BUT NOT EQUIVALENT TO"
        txt = txt.replace("⋨", "&prnsim;")

        # "U+022E9", "SUCCEEDS BUT NOT EQUIVALENT TO"
        txt = txt.replace("⋩", "&scnsim;")

        # "U+022EA", "NOT NORMAL SUBGROUP OF"
        txt = txt.replace("⋪", "&nltri;")

        # "U+022EB", "DOES NOT CONTAIN AS NORMAL SUBGROUP"
        txt = txt.replace("⋫", "&nrtri;")

        # "U+022EC", "NOT NORMAL SUBGROUP OF OR EQUAL TO"
        txt = txt.replace("⋬", "&nltrie;")

        # "U+022ED", "DOES NOT CONTAIN AS NORMAL SUBGROUP OR EQUAL"
        txt = txt.replace("⋭", "&nrtrie;")

        # "U+022EE", "VERTICAL ELLIPSIS"
        txt = txt.replace("⋮", "&vellip;")

        # "U+022EF", "MIDLINE HORIZONTAL ELLIPSIS"
        txt = txt.replace("⋯", "&ctdot;")

        # "U+022F0", "UP RIGHT DIAGONAL ELLIPSIS"
        txt = txt.replace("⋰", "&utdot;")

        # "U+022F1", "DOWN RIGHT DIAGONAL ELLIPSIS"
        txt = txt.replace("⋱", "&dtdot;")

        # "U+022F2", "ELEMENT OF WITH LONG HORIZONTAL STROKE"
        txt = txt.replace("⋲", "&disin;")

        # "U+022F3", "ELEMENT OF WITH VERTICAL BAR AT END OF HORIZONTAL STROKE"
        txt = txt.replace("⋳", "&isinsv;")

        # "U+022F4", "SMALL ELEMENT OF WITH VERTICAL BAR AT END OF HORIZONTAL STROKE"
        txt = txt.replace("⋴", "&isins;")

        # "U+022F5", "ELEMENT OF WITH DOT ABOVE"
        txt = txt.replace("⋵", "&isindot;")

        # "U+022F6", "ELEMENT OF WITH OVERBAR"
        txt = txt.replace("⋶", "&notinvc;")

        # "U+022F7", "SMALL ELEMENT OF WITH OVERBAR"
        txt = txt.replace("⋷", "&notinvb;")

        # "U+022F9", "ELEMENT OF WITH TWO HORIZONTAL STROKES"
        txt = txt.replace("⋹", "&isinE;")

        # "U+022FA", "CONTAINS WITH LONG HORIZONTAL STROKE"
        txt = txt.replace("⋺", "&nisd;")

        # "U+022FB", "CONTAINS WITH VERTICAL BAR AT END OF HORIZONTAL STROKE"
        txt = txt.replace("⋻", "&xnis;")

        # "U+022FC", "SMALL CONTAINS WITH VERTICAL BAR AT END OF HORIZONTAL STROKE"
        txt = txt.replace("⋼", "&nis;")

        # "U+022FD", "CONTAINS WITH OVERBAR"
        txt = txt.replace("⋽", "&notnivc;")

        # "U+022FE", "SMALL CONTAINS WITH OVERBAR"
        txt = txt.replace("⋾", "&notnivb;")

        # "U+02305", "PROJECTIVE"
        txt = txt.replace("⌅", "&barwed;")

        # "U+02306", "PERSPECTIVE"
        txt = txt.replace("⌆", "&Barwed;")

        # "U+02308", "LEFT CEILING"
        txt = txt.replace("⌈", "&lceil;")

        # "U+02309", "RIGHT CEILING"
        txt = txt.replace("⌉", "&rceil;")

        # "U+0230A", "LEFT FLOOR"
        txt = txt.replace("⌊", "&lfloor;")

        # "U+0230B", "RIGHT FLOOR"
        txt = txt.replace("⌋", "&rfloor;")

        # "U+0230C", "BOTTOM RIGHT CROP"
        txt = txt.replace("⌌", "&drcrop;")

        # "U+0230D", "BOTTOM LEFT CROP"
        txt = txt.replace("⌍", "&dlcrop;")

        # "U+0230E", "TOP RIGHT CROP"
        txt = txt.replace("⌎", "&urcrop;")

        # "U+0230F", "TOP LEFT CROP"
        txt = txt.replace("⌏", "&ulcrop;")

        # "U+02310", "REVERSED NOT SIGN"
        txt = txt.replace("⌐", "&bnot;")

        # "U+02312", "ARC"
        txt = txt.replace("⌒", "&profline;")

        # "U+02313", "SEGMENT"
        txt = txt.replace("⌓", "&profsurf;")

        # "U+02315", "TELEPHONE RECORDER"
        txt = txt.replace("⌕", "&telrec;")

        # "U+02316", "POSITION INDICATOR"
        txt = txt.replace("⌖", "&target;")

        # "U+0231C", "TOP LEFT CORNER"
        txt = txt.replace("⌜", "&ulcorn;")

        # "U+0231D", "TOP RIGHT CORNER"
        txt = txt.replace("⌝", "&urcorn;")

        # "U+0231E", "BOTTOM LEFT CORNER"
        txt = txt.replace("⌞", "&dlcorn;")

        # "U+0231F", "BOTTOM RIGHT CORNER"
        txt = txt.replace("⌟", "&drcorn;")

        # "U+02322", "FROWN"
        txt = txt.replace("⌢", "&frown;")

        # "U+02323", "SMILE"
        txt = txt.replace("⌣", "&smile;")

        # "U+0232D", "CYLINDRICITY"
        txt = txt.replace("⌭", "&cylcty;")

        # "U+0232E", "ALL AROUND-PROFILE"
        txt = txt.replace("⌮", "&profalar;")

        # "U+02336", "APL FUNCTIONAL SYMBOL I-BEAM"
        txt = txt.replace("⌶", "&topbot;")

        # "U+0233D", "APL FUNCTIONAL SYMBOL CIRCLE STILE"
        txt = txt.replace("⌽", "&ovbar;")

        # "U+0233F", "APL FUNCTIONAL SYMBOL SLASH BAR"
        txt = txt.replace("⌿", "&solbar;")

        # "U+0237C", "RIGHT ANGLE WITH DOWNWARDS ZIGZAG ARROW"
        txt = txt.replace("⍼", "&angzarr;")

        # "U+023B0", "UPPER LEFT OR LOWER RIGHT CURLY BRACKET SECTION"
        txt = txt.replace("⎰", "&lmoust;")

        # "U+023B1", "UPPER RIGHT OR LOWER LEFT CURLY BRACKET SECTION"
        txt = txt.replace("⎱", "&rmoust;")

        # "U+023B4", "TOP SQUARE BRACKET"
        txt = txt.replace("⎴", "&tbrk;")

        # "U+023B5", "BOTTOM SQUARE BRACKET"
        txt = txt.replace("⎵", "&bbrk;")

        # "U+023B6", "BOTTOM SQUARE BRACKET OVER TOP SQUARE BRACKET"
        txt = txt.replace("⎶", "&bbrktbrk;")

        # "U+023DC", "TOP PARENTHESIS"
        txt = txt.replace("⏜", "&OverParenthesis;")

        # "U+023DD", "BOTTOM PARENTHESIS"
        txt = txt.replace("⏝", "&UnderParenthesis;")

        # "U+023DE", "TOP CURLY BRACKET"
        txt = txt.replace("⏞", "&OverBrace;")

        # "U+023DF", "BOTTOM CURLY BRACKET"
        txt = txt.replace("⏟", "&UnderBrace;")

        # "U+023E2", "WHITE TRAPEZIUM"
        txt = txt.replace("⏢", "&trpezium;")

        # "U+023E7", "ELECTRICAL INTERSECTION"
        txt = txt.replace("⏧", "&elinters;")

        # "U+02423", "OPEN BOX"
        txt = txt.replace("␣", "&blank;")

        # "U+024C8", "CIRCLED LATIN CAPITAL LETTER S"
        txt = txt.replace("Ⓢ", "&oS;")

        # "U+02500", "BOX DRAWINGS LIGHT HORIZONTAL"
        txt = txt.replace("─", "&boxh;")

        # "U+02502", "BOX DRAWINGS LIGHT VERTICAL"
        txt = txt.replace("│", "&boxv;")

        # "U+0250C", "BOX DRAWINGS LIGHT DOWN AND RIGHT"
        txt = txt.replace("┌", "&boxdr;")

        # "U+02510", "BOX DRAWINGS LIGHT DOWN AND LEFT"
        txt = txt.replace("┐", "&boxdl;")

        # "U+02514", "BOX DRAWINGS LIGHT UP AND RIGHT"
        txt = txt.replace("└", "&boxur;")

        # "U+02518", "BOX DRAWINGS LIGHT UP AND LEFT"
        txt = txt.replace("┘", "&boxul;")

        # "U+0251C", "BOX DRAWINGS LIGHT VERTICAL AND RIGHT"
        txt = txt.replace("├", "&boxvr;")

        # "U+02524", "BOX DRAWINGS LIGHT VERTICAL AND LEFT"
        txt = txt.replace("┤", "&boxvl;")

        # "U+0252C", "BOX DRAWINGS LIGHT DOWN AND HORIZONTAL"
        txt = txt.replace("┬", "&boxhd;")

        # "U+02534", "BOX DRAWINGS LIGHT UP AND HORIZONTAL"
        txt = txt.replace("┴", "&boxhu;")

        # "U+0253C", "BOX DRAWINGS LIGHT VERTICAL AND HORIZONTAL"
        txt = txt.replace("┼", "&boxvh;")

        # "U+02550", "BOX DRAWINGS DOUBLE HORIZONTAL"
        txt = txt.replace("═", "&boxH;")

        # "U+02551", "BOX DRAWINGS DOUBLE VERTICAL"
        txt = txt.replace("║", "&boxV;")

        # "U+02552", "BOX DRAWINGS DOWN SINGLE AND RIGHT DOUBLE"
        txt = txt.replace("╒", "&boxdR;")

        # "U+02553", "BOX DRAWINGS DOWN DOUBLE AND RIGHT SINGLE"
        txt = txt.replace("╓", "&boxDr;")

        # "U+02554", "BOX DRAWINGS DOUBLE DOWN AND RIGHT"
        txt = txt.replace("╔", "&boxDR;")

        # "U+02555", "BOX DRAWINGS DOWN SINGLE AND LEFT DOUBLE"
        txt = txt.replace("╕", "&boxdL;")

        # "U+02556", "BOX DRAWINGS DOWN DOUBLE AND LEFT SINGLE"
        txt = txt.replace("╖", "&boxDl;")

        # "U+02557", "BOX DRAWINGS DOUBLE DOWN AND LEFT"
        txt = txt.replace("╗", "&boxDL;")

        # "U+02558", "BOX DRAWINGS UP SINGLE AND RIGHT DOUBLE"
        txt = txt.replace("╘", "&boxuR;")

        # "U+02559", "BOX DRAWINGS UP DOUBLE AND RIGHT SINGLE"
        txt = txt.replace("╙", "&boxUr;")

        # "U+0255A", "BOX DRAWINGS DOUBLE UP AND RIGHT"
        txt = txt.replace("╚", "&boxUR;")

        # "U+0255B", "BOX DRAWINGS UP SINGLE AND LEFT DOUBLE"
        txt = txt.replace("╛", "&boxuL;")

        # "U+0255C", "BOX DRAWINGS UP DOUBLE AND LEFT SINGLE"
        txt = txt.replace("╜", "&boxUl;")

        # "U+0255D", "BOX DRAWINGS DOUBLE UP AND LEFT"
        txt = txt.replace("╝", "&boxUL;")

        # "U+0255E", "BOX DRAWINGS VERTICAL SINGLE AND RIGHT DOUBLE"
        txt = txt.replace("╞", "&boxvR;")

        # "U+0255F", "BOX DRAWINGS VERTICAL DOUBLE AND RIGHT SINGLE"
        txt = txt.replace("╟", "&boxVr;")

        # "U+02560", "BOX DRAWINGS DOUBLE VERTICAL AND RIGHT"
        txt = txt.replace("╠", "&boxVR;")

        # "U+02561", "BOX DRAWINGS VERTICAL SINGLE AND LEFT DOUBLE"
        txt = txt.replace("╡", "&boxvL;")

        # "U+02562", "BOX DRAWINGS VERTICAL DOUBLE AND LEFT SINGLE"
        txt = txt.replace("╢", "&boxVl;")

        # "U+02563", "BOX DRAWINGS DOUBLE VERTICAL AND LEFT"
        txt = txt.replace("╣", "&boxVL;")

        # "U+02564", "BOX DRAWINGS DOWN SINGLE AND HORIZONTAL DOUBLE"
        txt = txt.replace("╤", "&boxHd;")

        # "U+02565", "BOX DRAWINGS DOWN DOUBLE AND HORIZONTAL SINGLE"
        txt = txt.replace("╥", "&boxhD;")

        # "U+02566", "BOX DRAWINGS DOUBLE DOWN AND HORIZONTAL"
        txt = txt.replace("╦", "&boxHD;")

        # "U+02567", "BOX DRAWINGS UP SINGLE AND HORIZONTAL DOUBLE"
        txt = txt.replace("╧", "&boxHu;")

        # "U+02568", "BOX DRAWINGS UP DOUBLE AND HORIZONTAL SINGLE"
        txt = txt.replace("╨", "&boxhU;")

        # "U+02569", "BOX DRAWINGS DOUBLE UP AND HORIZONTAL"
        txt = txt.replace("╩", "&boxHU;")

        # "U+0256A", "BOX DRAWINGS VERTICAL SINGLE AND HORIZONTAL DOUBLE"
        txt = txt.replace("╪", "&boxvH;")

        # "U+0256B", "BOX DRAWINGS VERTICAL DOUBLE AND HORIZONTAL SINGLE"
        txt = txt.replace("╫", "&boxVh;")

        # "U+0256C", "BOX DRAWINGS DOUBLE VERTICAL AND HORIZONTAL"
        txt = txt.replace("╬", "&boxVH;")

        # "U+02580", "UPPER HALF BLOCK"
        txt = txt.replace("▀", "&uhblk;")

        # "U+02584", "LOWER HALF BLOCK"
        txt = txt.replace("▄", "&lhblk;")

        # "U+02588", "FULL BLOCK"
        txt = txt.replace("█", "&block;")

        # "U+02591", "LIGHT SHADE"
        txt = txt.replace("░", "&blk14;")

        # "U+02592", "MEDIUM SHADE"
        txt = txt.replace("▒", "&blk12;")

        # "U+02593", "DARK SHADE"
        txt = txt.replace("▓", "&blk34;")

        # "U+025A1", "WHITE SQUARE"
        txt = txt.replace("□", "&squ;")

        # "U+025AA", "BLACK SMALL SQUARE"
        txt = txt.replace("▪", "&squf;")

        # "U+025AB", "WHITE SMALL SQUARE"
        txt = txt.replace("▫", "&EmptyVerySmallSquare;")

        # "U+025AD", "WHITE RECTANGLE"
        txt = txt.replace("▭", "&rect;")

        # "U+025AE", "BLACK VERTICAL RECTANGLE"
        txt = txt.replace("▮", "&marker;")

        # "U+025B1", "WHITE PARALLELOGRAM"
        txt = txt.replace("▱", "&fltns;")

        # "U+025B3", "WHITE UP-POINTING TRIANGLE"
        txt = txt.replace("△", "&xutri;")

        # "U+025B4", "BLACK UP-POINTING SMALL TRIANGLE"
        txt = txt.replace("▴", "&utrif;")

        # "U+025B5", "WHITE UP-POINTING SMALL TRIANGLE"
        txt = txt.replace("▵", "&utri;")

        # "U+025B8", "BLACK RIGHT-POINTING SMALL TRIANGLE"
        txt = txt.replace("▸", "&rtrif;")

        # "U+025B9", "WHITE RIGHT-POINTING SMALL TRIANGLE"
        txt = txt.replace("▹", "&rtri;")

        # "U+025BD", "WHITE DOWN-POINTING TRIANGLE"
        txt = txt.replace("▽", "&xdtri;")

        # "U+025BE", "BLACK DOWN-POINTING SMALL TRIANGLE"
        txt = txt.replace("▾", "&dtrif;")

        # "U+025BF", "WHITE DOWN-POINTING SMALL TRIANGLE"
        txt = txt.replace("▿", "&dtri;")

        # "U+025C2", "BLACK LEFT-POINTING SMALL TRIANGLE"
        txt = txt.replace("◂", "&ltrif;")

        # "U+025C3", "WHITE LEFT-POINTING SMALL TRIANGLE"
        txt = txt.replace("◃", "&ltri;")

        # "U+025CA", "LOZENGE"
        txt = txt.replace("◊", "&loz;")

        # "U+025CB", "WHITE CIRCLE"
        txt = txt.replace("○", "&cir;")

        # "U+025EC", "WHITE UP-POINTING TRIANGLE WITH DOT"
        txt = txt.replace("◬", "&tridot;")

        # "U+025EF", "LARGE CIRCLE"
        txt = txt.replace("◯", "&xcirc;")

        # "U+025F8", "UPPER LEFT TRIANGLE"
        txt = txt.replace("◸", "&ultri;")

        # "U+025F9", "UPPER RIGHT TRIANGLE"
        txt = txt.replace("◹", "&urtri;")

        # "U+025FA", "LOWER LEFT TRIANGLE"
        txt = txt.replace("◺", "&lltri;")

        # "U+025FB", "WHITE MEDIUM SQUARE"
        txt = txt.replace("◻", "&EmptySmallSquare;")

        # "U+025FC", "BLACK MEDIUM SQUARE"
        txt = txt.replace("◼", "&FilledSmallSquare;")

        # "U+02605", "BLACK STAR"
        txt = txt.replace("★", "&starf;")

        # "U+02606", "WHITE STAR"
        txt = txt.replace("☆", "&star;")

        # "U+0260E", "BLACK TELEPHONE"
        txt = txt.replace("☎", "&phone;")

        # "U+02640", "FEMALE SIGN"
        txt = txt.replace("♀", "&female;")

        # "U+02642", "MALE SIGN"
        txt = txt.replace("♂", "&male;")

        # "U+02660", "BLACK SPADE SUIT"
        txt = txt.replace("♠", "&spades;")

        # "U+02663", "BLACK CLUB SUIT"
        txt = txt.replace("♣", "&clubs;")

        # "U+02665", "BLACK HEART SUIT"
        txt = txt.replace("♥", "&hearts;")

        # "U+02666", "BLACK DIAMOND SUIT"
        txt = txt.replace("♦", "&diams;")

        # "U+0266A", "EIGHTH NOTE"
        txt = txt.replace("♪", "&sung;")

        # "U+0266D", "MUSIC FLAT SIGN"
        txt = txt.replace("♭", "&flat;")

        # "U+0266E", "MUSIC NATURAL SIGN"
        txt = txt.replace("♮", "&natur;")

        # "U+0266F", "MUSIC SHARP SIGN"
        txt = txt.replace("♯", "&sharp;")

        # "U+02713", "CHECK MARK"
        txt = txt.replace("✓", "&check;")

        # "U+02717", "BALLOT X"
        txt = txt.replace("✗", "&cross;")

        # "U+02720", "MALTESE CROSS"
        txt = txt.replace("✠", "&malt;")

        # "U+02736", "SIX POINTED BLACK STAR"
        txt = txt.replace("✶", "&sext;")

        # "U+02758", "LIGHT VERTICAL BAR"
        txt = txt.replace("❘", "&VerticalSeparator;")

        # "U+02772", "LIGHT LEFT TORTOISE SHELL BRACKET ORNAMENT"
        txt = txt.replace("❲", "&lbbrk;")

        # "U+02773", "LIGHT RIGHT TORTOISE SHELL BRACKET ORNAMENT"
        txt = txt.replace("❳", "&rbbrk;")

        # "U+027E6", "MATHEMATICAL LEFT WHITE SQUARE BRACKET"
        txt = txt.replace("⟦", "&lobrk;")

        # "U+027E7", "MATHEMATICAL RIGHT WHITE SQUARE BRACKET"
        txt = txt.replace("⟧", "&robrk;")

        # "U+027E8", "MATHEMATICAL LEFT ANGLE BRACKET"
        txt = txt.replace("⟨", "&lang;")

        # "U+027E9", "MATHEMATICAL RIGHT ANGLE BRACKET"
        txt = txt.replace("⟩", "&rang;")

        # "U+027EA", "MATHEMATICAL LEFT DOUBLE ANGLE BRACKET"
        txt = txt.replace("⟪", "&Lang;")

        # "U+027EB", "MATHEMATICAL RIGHT DOUBLE ANGLE BRACKET"
        txt = txt.replace("⟫", "&Rang;")

        # "U+027EC", "MATHEMATICAL LEFT WHITE TORTOISE SHELL BRACKET"
        txt = txt.replace("⟬", "&loang;")

        # "U+027ED", "MATHEMATICAL RIGHT WHITE TORTOISE SHELL BRACKET"
        txt = txt.replace("⟭", "&roang;")

        # "U+027F5", "LONG LEFTWARDS ARROW"
        txt = txt.replace("⟵", "&xlarr;")

        # "U+027F6", "LONG RIGHTWARDS ARROW"
        txt = txt.replace("⟶", "&xrarr;")

        # "U+027F7", "LONG LEFT RIGHT ARROW"
        txt = txt.replace("⟷", "&xharr;")

        # "U+027F8", "LONG LEFTWARDS DOUBLE ARROW"
        txt = txt.replace("⟸", "&xlArr;")

        # "U+027F9", "LONG RIGHTWARDS DOUBLE ARROW"
        txt = txt.replace("⟹", "&xrArr;")

        # "U+027FA", "LONG LEFT RIGHT DOUBLE ARROW"
        txt = txt.replace("⟺", "&xhArr;")

        # "U+027FC", "LONG RIGHTWARDS ARROW FROM BAR"
        txt = txt.replace("⟼", "&xmap;")

        # "U+027FF", "LONG RIGHTWARDS SQUIGGLE ARROW"
        txt = txt.replace("⟿", "&dzigrarr;")

        # "U+02902", "LEFTWARDS DOUBLE ARROW WITH VERTICAL STROKE"
        txt = txt.replace("⤂", "&nvlArr;")

        # "U+02903", "RIGHTWARDS DOUBLE ARROW WITH VERTICAL STROKE"
        txt = txt.replace("⤃", "&nvrArr;")

        # "U+02904", "LEFT RIGHT DOUBLE ARROW WITH VERTICAL STROKE"
        txt = txt.replace("⤄", "&nvHarr;")

        # "U+02905", "RIGHTWARDS TWO-HEADED ARROW FROM BAR"
        txt = txt.replace("⤅", "&Map;")

        # "U+0290C", "LEFTWARDS DOUBLE DASH ARROW"
        txt = txt.replace("⤌", "&lbarr;")

        # "U+0290D", "RIGHTWARDS DOUBLE DASH ARROW"
        txt = txt.replace("⤍", "&rbarr;")

        # "U+0290E", "LEFTWARDS TRIPLE DASH ARROW"
        txt = txt.replace("⤎", "&lBarr;")

        # "U+0290F", "RIGHTWARDS TRIPLE DASH ARROW"
        txt = txt.replace("⤏", "&rBarr;")

        # "U+02910", "RIGHTWARDS TWO-HEADED TRIPLE DASH ARROW"
        txt = txt.replace("⤐", "&RBarr;")

        # "U+02911", "RIGHTWARDS ARROW WITH DOTTED STEM"
        txt = txt.replace("⤑", "&DDotrahd;")

        # "U+02912", "UPWARDS ARROW TO BAR"
        txt = txt.replace("⤒", "&UpArrowBar;")

        # "U+02913", "DOWNWARDS ARROW TO BAR"
        txt = txt.replace("⤓", "&DownArrowBar;")

        # "U+02916", "RIGHTWARDS TWO-HEADED ARROW WITH TAIL"
        txt = txt.replace("⤖", "&Rarrtl;")

        # "U+02919", "LEFTWARDS ARROW-TAIL"
        txt = txt.replace("⤙", "&latail;")

        # "U+0291A", "RIGHTWARDS ARROW-TAIL"
        txt = txt.replace("⤚", "&ratail;")

        # "U+0291B", "LEFTWARDS DOUBLE ARROW-TAIL"
        txt = txt.replace("⤛", "&lAtail;")

        # "U+0291C", "RIGHTWARDS DOUBLE ARROW-TAIL"
        txt = txt.replace("⤜", "&rAtail;")

        # "U+0291D", "LEFTWARDS ARROW TO BLACK DIAMOND"
        txt = txt.replace("⤝", "&larrfs;")

        # "U+0291E", "RIGHTWARDS ARROW TO BLACK DIAMOND"
        txt = txt.replace("⤞", "&rarrfs;")

        # "U+0291F", "LEFTWARDS ARROW FROM BAR TO BLACK DIAMOND"
        txt = txt.replace("⤟", "&larrbfs;")

        # "U+02920", "RIGHTWARDS ARROW FROM BAR TO BLACK DIAMOND"
        txt = txt.replace("⤠", "&rarrbfs;")

        # "U+02923", "NORTH WEST ARROW WITH HOOK"
        txt = txt.replace("⤣", "&nwarhk;")

        # "U+02924", "NORTH EAST ARROW WITH HOOK"
        txt = txt.replace("⤤", "&nearhk;")

        # "U+02925", "SOUTH EAST ARROW WITH HOOK"
        txt = txt.replace("⤥", "&searhk;")

        # "U+02926", "SOUTH WEST ARROW WITH HOOK"
        txt = txt.replace("⤦", "&swarhk;")

        # "U+02927", "NORTH WEST ARROW AND NORTH EAST ARROW"
        txt = txt.replace("⤧", "&nwnear;")

        # "U+02928", "NORTH EAST ARROW AND SOUTH EAST ARROW"
        txt = txt.replace("⤨", "&nesear;")

        # "U+02929", "SOUTH EAST ARROW AND SOUTH WEST ARROW"
        txt = txt.replace("⤩", "&seswar;")

        # "U+0292A", "SOUTH WEST ARROW AND NORTH WEST ARROW"
        txt = txt.replace("⤪", "&swnwar;")

        # "U+02933", "WAVE ARROW POINTING DIRECTLY RIGHT"
        txt = txt.replace("⤳", "&rarrc;")

        # "U+02935", "ARROW POINTING RIGHTWARDS THEN CURVING DOWNWARDS"
        txt = txt.replace("⤵", "&cudarrr;")

        # "U+02936", "ARROW POINTING DOWNWARDS THEN CURVING LEFTWARDS"
        txt = txt.replace("⤶", "&ldca;")

        # "U+02937", "ARROW POINTING DOWNWARDS THEN CURVING RIGHTWARDS"
        txt = txt.replace("⤷", "&rdca;")

        # "U+02938", "RIGHT-SIDE ARC CLOCKWISE ARROW"
        txt = txt.replace("⤸", "&cudarrl;")

        # "U+02939", "LEFT-SIDE ARC ANTICLOCKWISE ARROW"
        txt = txt.replace("⤹", "&larrpl;")

        # "U+0293C", "TOP ARC CLOCKWISE ARROW WITH MINUS"
        txt = txt.replace("⤼", "&curarrm;")

        # "U+0293D", "TOP ARC ANTICLOCKWISE ARROW WITH PLUS"
        txt = txt.replace("⤽", "&cularrp;")

        # "U+02945", "RIGHTWARDS ARROW WITH PLUS BELOW"
        txt = txt.replace("⥅", "&rarrpl;")

        # "U+02948", "LEFT RIGHT ARROW THROUGH SMALL CIRCLE"
        txt = txt.replace("⥈", "&harrcir;")

        # "U+02949", "UPWARDS TWO-HEADED ARROW FROM SMALL CIRCLE"
        txt = txt.replace("⥉", "&Uarrocir;")

        # "U+0294A", "LEFT BARB UP RIGHT BARB DOWN HARPOON"
        txt = txt.replace("⥊", "&lurdshar;")

        # "U+0294B", "LEFT BARB DOWN RIGHT BARB UP HARPOON"
        txt = txt.replace("⥋", "&ldrushar;")

        # "U+0294E", "LEFT BARB UP RIGHT BARB UP HARPOON"
        txt = txt.replace("⥎", "&LeftRightVector;")

        # "U+0294F", "UP BARB RIGHT DOWN BARB RIGHT HARPOON"
        txt = txt.replace("⥏", "&RightUpDownVector;")

        # "U+02950", "LEFT BARB DOWN RIGHT BARB DOWN HARPOON"
        txt = txt.replace("⥐", "&DownLeftRightVector;")

        # "U+02951", "UP BARB LEFT DOWN BARB LEFT HARPOON"
        txt = txt.replace("⥑", "&LeftUpDownVector;")

        # "U+02952", "LEFTWARDS HARPOON WITH BARB UP TO BAR"
        txt = txt.replace("⥒", "&LeftVectorBar;")

        # "U+02953", "RIGHTWARDS HARPOON WITH BARB UP TO BAR"
        txt = txt.replace("⥓", "&RightVectorBar;")

        # "U+02954", "UPWARDS HARPOON WITH BARB RIGHT TO BAR"
        txt = txt.replace("⥔", "&RightUpVectorBar;")

        # "U+02955", "DOWNWARDS HARPOON WITH BARB RIGHT TO BAR"
        txt = txt.replace("⥕", "&RightDownVectorBar;")

        # "U+02956", "LEFTWARDS HARPOON WITH BARB DOWN TO BAR"
        txt = txt.replace("⥖", "&DownLeftVectorBar;")

        # "U+02957", "RIGHTWARDS HARPOON WITH BARB DOWN TO BAR"
        txt = txt.replace("⥗", "&DownRightVectorBar;")

        # "U+02958", "UPWARDS HARPOON WITH BARB LEFT TO BAR"
        txt = txt.replace("⥘", "&LeftUpVectorBar;")

        # "U+02959", "DOWNWARDS HARPOON WITH BARB LEFT TO BAR"
        txt = txt.replace("⥙", "&LeftDownVectorBar;")

        # "U+0295A", "LEFTWARDS HARPOON WITH BARB UP FROM BAR"
        txt = txt.replace("⥚", "&LeftTeeVector;")

        # "U+0295B", "RIGHTWARDS HARPOON WITH BARB UP FROM BAR"
        txt = txt.replace("⥛", "&RightTeeVector;")

        # "U+0295C", "UPWARDS HARPOON WITH BARB RIGHT FROM BAR"
        txt = txt.replace("⥜", "&RightUpTeeVector;")

        # "U+0295D", "DOWNWARDS HARPOON WITH BARB RIGHT FROM BAR"
        txt = txt.replace("⥝", "&RightDownTeeVector;")

        # "U+0295E", "LEFTWARDS HARPOON WITH BARB DOWN FROM BAR"
        txt = txt.replace("⥞", "&DownLeftTeeVector;")

        # "U+0295F", "RIGHTWARDS HARPOON WITH BARB DOWN FROM BAR"
        txt = txt.replace("⥟", "&DownRightTeeVector;")

        # "U+02960", "UPWARDS HARPOON WITH BARB LEFT FROM BAR"
        txt = txt.replace("⥠", "&LeftUpTeeVector;")

        # "U+02961", "DOWNWARDS HARPOON WITH BARB LEFT FROM BAR"
        txt = txt.replace("⥡", "&LeftDownTeeVector;")

        # "U+02962", "LEFTWARDS HARPOON WITH BARB UP ABOVE LEFTWARDS HARPOON WITH BARB DOWN"
        txt = txt.replace("⥢", "&lHar;")

        # "U+02963", "UPWARDS HARPOON WITH BARB LEFT BESIDE UPWARDS HARPOON WITH BARB RIGHT"
        txt = txt.replace("⥣", "&uHar;")

        # "U+02964", "RIGHTWARDS HARPOON WITH BARB UP ABOVE RIGHTWARDS HARPOON WITH BARB DOWN"
        txt = txt.replace("⥤", "&rHar;")

        # "U+02965", "DOWNWARDS HARPOON WITH BARB LEFT BESIDE DOWNWARDS HARPOON WITH BARB RIGHT"
        txt = txt.replace("⥥", "&dHar;")

        # "U+02966", "LEFTWARDS HARPOON WITH BARB UP ABOVE RIGHTWARDS HARPOON WITH BARB UP"
        txt = txt.replace("⥦", "&luruhar;")

        # "U+02967", "LEFTWARDS HARPOON WITH BARB DOWN ABOVE RIGHTWARDS HARPOON WITH BARB DOWN"
        txt = txt.replace("⥧", "&ldrdhar;")

        # "U+02968", "RIGHTWARDS HARPOON WITH BARB UP ABOVE LEFTWARDS HARPOON WITH BARB UP"
        txt = txt.replace("⥨", "&ruluhar;")

        # "U+02969", "RIGHTWARDS HARPOON WITH BARB DOWN ABOVE LEFTWARDS HARPOON WITH BARB DOWN"
        txt = txt.replace("⥩", "&rdldhar;")

        # "U+0296A", "LEFTWARDS HARPOON WITH BARB UP ABOVE LONG DASH"
        txt = txt.replace("⥪", "&lharul;")

        # "U+0296B", "LEFTWARDS HARPOON WITH BARB DOWN BELOW LONG DASH"
        txt = txt.replace("⥫", "&llhard;")

        # "U+0296C", "RIGHTWARDS HARPOON WITH BARB UP ABOVE LONG DASH"
        txt = txt.replace("⥬", "&rharul;")

        # "U+0296D", "RIGHTWARDS HARPOON WITH BARB DOWN BELOW LONG DASH"
        txt = txt.replace("⥭", "&lrhard;")

        # "U+0296E", "UPWARDS HARPOON WITH BARB LEFT BESIDE DOWNWARDS HARPOON WITH BARB RIGHT"
        txt = txt.replace("⥮", "&udhar;")

        # "U+0296F", "DOWNWARDS HARPOON WITH BARB LEFT BESIDE UPWARDS HARPOON WITH BARB RIGHT"
        txt = txt.replace("⥯", "&duhar;")

        # "U+02970", "RIGHT DOUBLE ARROW WITH ROUNDED HEAD"
        txt = txt.replace("⥰", "&RoundImplies;")

        # "U+02971", "EQUALS SIGN ABOVE RIGHTWARDS ARROW"
        txt = txt.replace("⥱", "&erarr;")

        # "U+02972", "TILDE OPERATOR ABOVE RIGHTWARDS ARROW"
        txt = txt.replace("⥲", "&simrarr;")

        # "U+02973", "LEFTWARDS ARROW ABOVE TILDE OPERATOR"
        txt = txt.replace("⥳", "&larrsim;")

        # "U+02974", "RIGHTWARDS ARROW ABOVE TILDE OPERATOR"
        txt = txt.replace("⥴", "&rarrsim;")

        # "U+02975", "RIGHTWARDS ARROW ABOVE ALMOST EQUAL TO"
        txt = txt.replace("⥵", "&rarrap;")

        # "U+02976", "LESS-THAN ABOVE LEFTWARDS ARROW"
        txt = txt.replace("⥶", "&ltlarr;")

        # "U+02978", "GREATER-THAN ABOVE RIGHTWARDS ARROW"
        txt = txt.replace("⥸", "&gtrarr;")

        # "U+02979", "SUBSET ABOVE RIGHTWARDS ARROW"
        txt = txt.replace("⥹", "&subrarr;")

        # "U+0297B", "SUPERSET ABOVE LEFTWARDS ARROW"
        txt = txt.replace("⥻", "&suplarr;")

        # "U+0297C", "LEFT FISH TAIL"
        txt = txt.replace("⥼", "&lfisht;")

        # "U+0297D", "RIGHT FISH TAIL"
        txt = txt.replace("⥽", "&rfisht;")

        # "U+0297E", "UP FISH TAIL"
        txt = txt.replace("⥾", "&ufisht;")

        # "U+0297F", "DOWN FISH TAIL"
        txt = txt.replace("⥿", "&dfisht;")

        # "U+02985", "LEFT WHITE PARENTHESIS"
        txt = txt.replace("⦅", "&lopar;")

        # "U+02986", "RIGHT WHITE PARENTHESIS"
        txt = txt.replace("⦆", "&ropar;")

        # "U+0298B", "LEFT SQUARE BRACKET WITH UNDERBAR"
        txt = txt.replace("⦋", "&lbrke;")

        # "U+0298C", "RIGHT SQUARE BRACKET WITH UNDERBAR"
        txt = txt.replace("⦌", "&rbrke;")

        # "U+0298D", "LEFT SQUARE BRACKET WITH TICK IN TOP CORNER"
        txt = txt.replace("⦍", "&lbrkslu;")

        # "U+0298E", "RIGHT SQUARE BRACKET WITH TICK IN BOTTOM CORNER"
        txt = txt.replace("⦎", "&rbrksld;")

        # "U+0298F", "LEFT SQUARE BRACKET WITH TICK IN BOTTOM CORNER"
        txt = txt.replace("⦏", "&lbrksld;")

        # "U+02990", "RIGHT SQUARE BRACKET WITH TICK IN TOP CORNER"
        txt = txt.replace("⦐", "&rbrkslu;")

        # "U+02991", "LEFT ANGLE BRACKET WITH DOT"
        txt = txt.replace("⦑", "&langd;")

        # "U+02992", "RIGHT ANGLE BRACKET WITH DOT"
        txt = txt.replace("⦒", "&rangd;")

        # "U+02993", "LEFT ARC LESS-THAN BRACKET"
        txt = txt.replace("⦓", "&lparlt;")

        # "U+02994", "RIGHT ARC GREATER-THAN BRACKET"
        txt = txt.replace("⦔", "&rpargt;")

        # "U+02995", "DOUBLE LEFT ARC GREATER-THAN BRACKET"
        txt = txt.replace("⦕", "&gtlPar;")

        # "U+02996", "DOUBLE RIGHT ARC LESS-THAN BRACKET"
        txt = txt.replace("⦖", "&ltrPar;")

        # "U+0299A", "VERTICAL ZIGZAG LINE"
        txt = txt.replace("⦚", "&vzigzag;")

        # "U+0299C", "RIGHT ANGLE VARIANT WITH SQUARE"
        txt = txt.replace("⦜", "&vangrt;")

        # "U+0299D", "MEASURED RIGHT ANGLE WITH DOT"
        txt = txt.replace("⦝", "&angrtvbd;")

        # "U+029A4", "ANGLE WITH UNDERBAR"
        txt = txt.replace("⦤", "&ange;")

        # "U+029A5", "REVERSED ANGLE WITH UNDERBAR"
        txt = txt.replace("⦥", "&range;")

        # "U+029A6", "OBLIQUE ANGLE OPENING UP"
        txt = txt.replace("⦦", "&dwangle;")

        # "U+029A7", "OBLIQUE ANGLE OPENING DOWN"
        txt = txt.replace("⦧", "&uwangle;")

        # "U+029A8", "MEASURED ANGLE WITH OPEN ARM ENDING IN ARROW POINTING UP AND RIGHT"
        txt = txt.replace("⦨", "&angmsdaa;")

        # "U+029A9", "MEASURED ANGLE WITH OPEN ARM ENDING IN ARROW POINTING UP AND LEFT"
        txt = txt.replace("⦩", "&angmsdab;")

        # "U+029AA", "MEASURED ANGLE WITH OPEN ARM ENDING IN ARROW POINTING DOWN AND RIGHT"
        txt = txt.replace("⦪", "&angmsdac;")

        # "U+029AB", "MEASURED ANGLE WITH OPEN ARM ENDING IN ARROW POINTING DOWN AND LEFT"
        txt = txt.replace("⦫", "&angmsdad;")

        # "U+029AC", "MEASURED ANGLE WITH OPEN ARM ENDING IN ARROW POINTING RIGHT AND UP"
        txt = txt.replace("⦬", "&angmsdae;")

        # "U+029AD", "MEASURED ANGLE WITH OPEN ARM ENDING IN ARROW POINTING LEFT AND UP"
        txt = txt.replace("⦭", "&angmsdaf;")

        # "U+029AE", "MEASURED ANGLE WITH OPEN ARM ENDING IN ARROW POINTING RIGHT AND DOWN"
        txt = txt.replace("⦮", "&angmsdag;")

        # "U+029AF", "MEASURED ANGLE WITH OPEN ARM ENDING IN ARROW POINTING LEFT AND DOWN"
        txt = txt.replace("⦯", "&angmsdah;")

        # "U+029B0", "REVERSED EMPTY SET"
        txt = txt.replace("⦰", "&bemptyv;")

        # "U+029B1", "EMPTY SET WITH OVERBAR"
        txt = txt.replace("⦱", "&demptyv;")

        # "U+029B2", "EMPTY SET WITH SMALL CIRCLE ABOVE"
        txt = txt.replace("⦲", "&cemptyv;")

        # "U+029B3", "EMPTY SET WITH RIGHT ARROW ABOVE"
        txt = txt.replace("⦳", "&raemptyv;")

        # "U+029B4", "EMPTY SET WITH LEFT ARROW ABOVE"
        txt = txt.replace("⦴", "&laemptyv;")

        # "U+029B5", "CIRCLE WITH HORIZONTAL BAR"
        txt = txt.replace("⦵", "&ohbar;")

        # "U+029B6", "CIRCLED VERTICAL BAR"
        txt = txt.replace("⦶", "&omid;")

        # "U+029B7", "CIRCLED PARALLEL"
        txt = txt.replace("⦷", "&opar;")

        # "U+029B9", "CIRCLED PERPENDICULAR"
        txt = txt.replace("⦹", "&operp;")

        # "U+029BB", "CIRCLE WITH SUPERIMPOSED X"
        txt = txt.replace("⦻", "&olcross;")

        # "U+029BC", "CIRCLED ANTICLOCKWISE-ROTATED DIVISION SIGN"
        txt = txt.replace("⦼", "&odsold;")

        # "U+029BE", "CIRCLED WHITE BULLET"
        txt = txt.replace("⦾", "&olcir;")

        # "U+029BF", "CIRCLED BULLET"
        txt = txt.replace("⦿", "&ofcir;")

        # "U+029C0", "CIRCLED LESS-THAN"
        txt = txt.replace("⧀", "&olt;")

        # "U+029C1", "CIRCLED GREATER-THAN"
        txt = txt.replace("⧁", "&ogt;")

        # "U+029C2", "CIRCLE WITH SMALL CIRCLE TO THE RIGHT"
        txt = txt.replace("⧂", "&cirscir;")

        # "U+029C3", "CIRCLE WITH TWO HORIZONTAL STROKES TO THE RIGHT"
        txt = txt.replace("⧃", "&cirE;")

        # "U+029C4", "SQUARED RISING DIAGONAL SLASH"
        txt = txt.replace("⧄", "&solb;")

        # "U+029C5", "SQUARED FALLING DIAGONAL SLASH"
        txt = txt.replace("⧅", "&bsolb;")

        # "U+029C9", "TWO JOINED SQUARES"
        txt = txt.replace("⧉", "&boxbox;")

        # "U+029CD", "TRIANGLE WITH SERIFS AT BOTTOM"
        txt = txt.replace("⧍", "&trisb;")

        # "U+029CE", "RIGHT TRIANGLE ABOVE LEFT TRIANGLE"
        txt = txt.replace("⧎", "&rtriltri;")

        # "U+029CF", "LEFT TRIANGLE BESIDE VERTICAL BAR"
        txt = txt.replace("⧏", "&LeftTriangleBar;")

        # "U+029D0", "VERTICAL BAR BESIDE RIGHT TRIANGLE"
        txt = txt.replace("⧐", "&RightTriangleBar;")

        # "U+029DA", "LEFT DOUBLE WIGGLY FENCE"
        txt = txt.replace("⧚", "&race;")

        # "U+029DC", "INCOMPLETE INFINITY"
        txt = txt.replace("⧜", "&iinfin;")

        # "U+029DD", "TIE OVER INFINITY"
        txt = txt.replace("⧝", "&infintie;")

        # "U+029DE", "INFINITY NEGATED WITH VERTICAL BAR"
        txt = txt.replace("⧞", "&nvinfin;")

        # "U+029E3", "EQUALS SIGN AND SLANTED PARALLEL"
        txt = txt.replace("⧣", "&eparsl;")

        # "U+029E4", "EQUALS SIGN AND SLANTED PARALLEL WITH TILDE ABOVE"
        txt = txt.replace("⧤", "&smeparsl;")

        # "U+029E5", "IDENTICAL TO AND SLANTED PARALLEL"
        txt = txt.replace("⧥", "&eqvparsl;")

        # "U+029EB", "BLACK LOZENGE"
        txt = txt.replace("⧫", "&lozf;")

        # "U+029F4", "RULE-DELAYED"
        txt = txt.replace("⧴", "&RuleDelayed;")

        # "U+029F6", "SOLIDUS WITH OVERBAR"
        txt = txt.replace("⧶", "&dsol;")

        # "U+02A00", "N-ARY CIRCLED DOT OPERATOR"
        txt = txt.replace("⨀", "&xodot;")

        # "U+02A01", "N-ARY CIRCLED PLUS OPERATOR"
        txt = txt.replace("⨁", "&xoplus;")

        # "U+02A02", "N-ARY CIRCLED TIMES OPERATOR"
        txt = txt.replace("⨂", "&xotime;")

        # "U+02A04", "N-ARY UNION OPERATOR WITH PLUS"
        txt = txt.replace("⨄", "&xuplus;")

        # "U+02A06", "N-ARY SQUARE UNION OPERATOR"
        txt = txt.replace("⨆", "&xsqcup;")

        # "U+02A0C", "QUADRUPLE INTEGRAL OPERATOR"
        txt = txt.replace("⨌", "&qint;")

        # "U+02A0D", "FINITE PART INTEGRAL"
        txt = txt.replace("⨍", "&fpartint;")

        # "U+02A10", "CIRCULATION FUNCTION"
        txt = txt.replace("⨐", "&cirfnint;")

        # "U+02A11", "ANTICLOCKWISE INTEGRATION"
        txt = txt.replace("⨑", "&awint;")

        # "U+02A12", "LINE INTEGRATION WITH RECTANGULAR PATH AROUND POLE"
        txt = txt.replace("⨒", "&rppolint;")

        # "U+02A13", "LINE INTEGRATION WITH SEMICIRCULAR PATH AROUND POLE"
        txt = txt.replace("⨓", "&scpolint;")

        # "U+02A14", "LINE INTEGRATION NOT INCLUDING THE POLE"
        txt = txt.replace("⨔", "&npolint;")

        # "U+02A15", "INTEGRAL AROUND A POINT OPERATOR"
        txt = txt.replace("⨕", "&pointint;")

        # "U+02A16", "QUATERNION INTEGRAL OPERATOR"
        txt = txt.replace("⨖", "&quatint;")

        # "U+02A17", "INTEGRAL WITH LEFTWARDS ARROW WITH HOOK"
        txt = txt.replace("⨗", "&intlarhk;")

        # "U+02A22", "PLUS SIGN WITH SMALL CIRCLE ABOVE"
        txt = txt.replace("⨢", "&pluscir;")

        # "U+02A23", "PLUS SIGN WITH CIRCUMFLEX ACCENT ABOVE"
        txt = txt.replace("⨣", "&plusacir;")

        # "U+02A24", "PLUS SIGN WITH TILDE ABOVE"
        txt = txt.replace("⨤", "&simplus;")

        # "U+02A25", "PLUS SIGN WITH DOT BELOW"
        txt = txt.replace("⨥", "&plusdu;")

        # "U+02A26", "PLUS SIGN WITH TILDE BELOW"
        txt = txt.replace("⨦", "&plussim;")

        # "U+02A27", "PLUS SIGN WITH SUBSCRIPT TWO"
        txt = txt.replace("⨧", "&plustwo;")

        # "U+02A29", "MINUS SIGN WITH COMMA ABOVE"
        txt = txt.replace("⨩", "&mcomma;")

        # "U+02A2A", "MINUS SIGN WITH DOT BELOW"
        txt = txt.replace("⨪", "&minusdu;")

        # "U+02A2D", "PLUS SIGN IN LEFT HALF CIRCLE"
        txt = txt.replace("⨭", "&loplus;")

        # "U+02A2E", "PLUS SIGN IN RIGHT HALF CIRCLE"
        txt = txt.replace("⨮", "&roplus;")

        # "U+02A2F", "VECTOR OR CROSS PRODUCT"
        txt = txt.replace("⨯", "&Cross;")

        # "U+02A30", "MULTIPLICATION SIGN WITH DOT ABOVE"
        txt = txt.replace("⨰", "&timesd;")

        # "U+02A31", "MULTIPLICATION SIGN WITH UNDERBAR"
        txt = txt.replace("⨱", "&timesbar;")

        # "U+02A33", "SMASH PRODUCT"
        txt = txt.replace("⨳", "&smashp;")

        # "U+02A34", "MULTIPLICATION SIGN IN LEFT HALF CIRCLE"
        txt = txt.replace("⨴", "&lotimes;")

        # "U+02A35", "MULTIPLICATION SIGN IN RIGHT HALF CIRCLE"
        txt = txt.replace("⨵", "&rotimes;")

        # "U+02A36", "CIRCLED MULTIPLICATION SIGN WITH CIRCUMFLEX ACCENT"
        txt = txt.replace("⨶", "&otimesas;")

        # "U+02A37", "MULTIPLICATION SIGN IN DOUBLE CIRCLE"
        txt = txt.replace("⨷", "&Otimes;")

        # "U+02A38", "CIRCLED DIVISION SIGN"
        txt = txt.replace("⨸", "&odiv;")

        # "U+02A39", "PLUS SIGN IN TRIANGLE"
        txt = txt.replace("⨹", "&triplus;")

        # "U+02A3A", "MINUS SIGN IN TRIANGLE"
        txt = txt.replace("⨺", "&triminus;")

        # "U+02A3B", "MULTIPLICATION SIGN IN TRIANGLE"
        txt = txt.replace("⨻", "&tritime;")

        # "U+02A3C", "INTERIOR PRODUCT"
        txt = txt.replace("⨼", "&iprod;")

        # "U+02A3F", "AMALGAMATION OR COPRODUCT"
        txt = txt.replace("⨿", "&amalg;")

        # "U+02A40", "INTERSECTION WITH DOT"
        txt = txt.replace("⩀", "&capdot;")

        # "U+02A42", "UNION WITH OVERBAR"
        txt = txt.replace("⩂", "&ncup;")

        # "U+02A43", "INTERSECTION WITH OVERBAR"
        txt = txt.replace("⩃", "&ncap;")

        # "U+02A44", "INTERSECTION WITH LOGICAL AND"
        txt = txt.replace("⩄", "&capand;")

        # "U+02A45", "UNION WITH LOGICAL OR"
        txt = txt.replace("⩅", "&cupor;")

        # "U+02A46", "UNION ABOVE INTERSECTION"
        txt = txt.replace("⩆", "&cupcap;")

        # "U+02A47", "INTERSECTION ABOVE UNION"
        txt = txt.replace("⩇", "&capcup;")

        # "U+02A48", "UNION ABOVE BAR ABOVE INTERSECTION"
        txt = txt.replace("⩈", "&cupbrcap;")

        # "U+02A49", "INTERSECTION ABOVE BAR ABOVE UNION"
        txt = txt.replace("⩉", "&capbrcup;")

        # "U+02A4A", "UNION BESIDE AND JOINED WITH UNION"
        txt = txt.replace("⩊", "&cupcup;")

        # "U+02A4B", "INTERSECTION BESIDE AND JOINED WITH INTERSECTION"
        txt = txt.replace("⩋", "&capcap;")

        # "U+02A4C", "CLOSED UNION WITH SERIFS"
        txt = txt.replace("⩌", "&ccups;")

        # "U+02A4D", "CLOSED INTERSECTION WITH SERIFS"
        txt = txt.replace("⩍", "&ccaps;")

        # "U+02A50", "CLOSED UNION WITH SERIFS AND SMASH PRODUCT"
        txt = txt.replace("⩐", "&ccupssm;")

        # "U+02A53", "DOUBLE LOGICAL AND"
        txt = txt.replace("⩓", "&And;")

        # "U+02A54", "DOUBLE LOGICAL OR"
        txt = txt.replace("⩔", "&Or;")

        # "U+02A55", "TWO INTERSECTING LOGICAL AND"
        txt = txt.replace("⩕", "&andand;")

        # "U+02A56", "TWO INTERSECTING LOGICAL OR"
        txt = txt.replace("⩖", "&oror;")

        # "U+02A57", "SLOPING LARGE OR"
        txt = txt.replace("⩗", "&orslope;")

        # "U+02A58", "SLOPING LARGE AND"
        txt = txt.replace("⩘", "&andslope;")

        # "U+02A5A", "LOGICAL AND WITH MIDDLE STEM"
        txt = txt.replace("⩚", "&andv;")

        # "U+02A5B", "LOGICAL OR WITH MIDDLE STEM"
        txt = txt.replace("⩛", "&orv;")

        # "U+02A5C", "LOGICAL AND WITH HORIZONTAL DASH"
        txt = txt.replace("⩜", "&andd;")

        # "U+02A5D", "LOGICAL OR WITH HORIZONTAL DASH"
        txt = txt.replace("⩝", "&ord;")

        # "U+02A5F", "LOGICAL AND WITH UNDERBAR"
        txt = txt.replace("⩟", "&wedbar;")

        # "U+02A66", "EQUALS SIGN WITH DOT BELOW"
        txt = txt.replace("⩦", "&sdote;")

        # "U+02A6A", "TILDE OPERATOR WITH DOT ABOVE"
        txt = txt.replace("⩪", "&simdot;")

        # "U+02A6D", "CONGRUENT WITH DOT ABOVE"
        txt = txt.replace("⩭", "&congdot;")

        # "U+02A6E", "EQUALS WITH ASTERISK"
        txt = txt.replace("⩮", "&easter;")

        # "U+02A6F", "ALMOST EQUAL TO WITH CIRCUMFLEX ACCENT"
        txt = txt.replace("⩯", "&apacir;")

        # "U+02A70", "APPROXIMATELY EQUAL OR EQUAL TO"
        txt = txt.replace("⩰", "&apE;")

        # "U+02A71", "EQUALS SIGN ABOVE PLUS SIGN"
        txt = txt.replace("⩱", "&eplus;")

        # "U+02A72", "PLUS SIGN ABOVE EQUALS SIGN"
        txt = txt.replace("⩲", "&pluse;")

        # "U+02A73", "EQUALS SIGN ABOVE TILDE OPERATOR"
        txt = txt.replace("⩳", "&Esim;")

        # "U+02A74", "DOUBLE COLON EQUAL"
        txt = txt.replace("⩴", "&Colone;")

        # "U+02A75", "TWO CONSECUTIVE EQUALS SIGNS"
        txt = txt.replace("⩵", "&Equal;")

        # "U+02A77", "EQUALS SIGN WITH TWO DOTS ABOVE AND TWO DOTS BELOW"
        txt = txt.replace("⩷", "&eDDot;")

        # "U+02A78", "EQUIVALENT WITH FOUR DOTS ABOVE"
        txt = txt.replace("⩸", "&equivDD;")

        # "U+02A79", "LESS-THAN WITH CIRCLE INSIDE"
        txt = txt.replace("⩹", "&ltcir;")

        # "U+02A7A", "GREATER-THAN WITH CIRCLE INSIDE"
        txt = txt.replace("⩺", "&gtcir;")

        # "U+02A7B", "LESS-THAN WITH QUESTION MARK ABOVE"
        txt = txt.replace("⩻", "&ltquest;")

        # "U+02A7C", "GREATER-THAN WITH QUESTION MARK ABOVE"
        txt = txt.replace("⩼", "&gtquest;")

        # "U+02A7D", "LESS-THAN OR SLANTED EQUAL TO"
        txt = txt.replace("⩽", "&les;")

        # "U+02A7E", "GREATER-THAN OR SLANTED EQUAL TO"
        txt = txt.replace("⩾", "&ges;")

        # "U+02A7F", "LESS-THAN OR SLANTED EQUAL TO WITH DOT INSIDE"
        txt = txt.replace("⩿", "&lesdot;")

        # "U+02A80", "GREATER-THAN OR SLANTED EQUAL TO WITH DOT INSIDE"
        txt = txt.replace("⪀", "&gesdot;")

        # "U+02A81", "LESS-THAN OR SLANTED EQUAL TO WITH DOT ABOVE"
        txt = txt.replace("⪁", "&lesdoto;")

        # "U+02A82", "GREATER-THAN OR SLANTED EQUAL TO WITH DOT ABOVE"
        txt = txt.replace("⪂", "&gesdoto;")

        # "U+02A83", "LESS-THAN OR SLANTED EQUAL TO WITH DOT ABOVE RIGHT"
        txt = txt.replace("⪃", "&lesdotor;")

        # "U+02A84", "GREATER-THAN OR SLANTED EQUAL TO WITH DOT ABOVE LEFT"
        txt = txt.replace("⪄", "&gesdotol;")

        # "U+02A85", "LESS-THAN OR APPROXIMATE"
        txt = txt.replace("⪅", "&lap;")

        # "U+02A86", "GREATER-THAN OR APPROXIMATE"
        txt = txt.replace("⪆", "&gap;")

        # "U+02A87", "LESS-THAN AND SINGLE-LINE NOT EQUAL TO"
        txt = txt.replace("⪇", "&lne;")

        # "U+02A88", "GREATER-THAN AND SINGLE-LINE NOT EQUAL TO"
        txt = txt.replace("⪈", "&gne;")

        # "U+02A89", "LESS-THAN AND NOT APPROXIMATE"
        txt = txt.replace("⪉", "&lnap;")

        # "U+02A8A", "GREATER-THAN AND NOT APPROXIMATE"
        txt = txt.replace("⪊", "&gnap;")

        # "U+02A8B", "LESS-THAN ABOVE DOUBLE-LINE EQUAL ABOVE GREATER-THAN"
        txt = txt.replace("⪋", "&lEg;")

        # "U+02A8C", "GREATER-THAN ABOVE DOUBLE-LINE EQUAL ABOVE LESS-THAN"
        txt = txt.replace("⪌", "&gEl;")

        # "U+02A8D", "LESS-THAN ABOVE SIMILAR OR EQUAL"
        txt = txt.replace("⪍", "&lsime;")

        # "U+02A8E", "GREATER-THAN ABOVE SIMILAR OR EQUAL"
        txt = txt.replace("⪎", "&gsime;")

        # "U+02A8F", "LESS-THAN ABOVE SIMILAR ABOVE GREATER-THAN"
        txt = txt.replace("⪏", "&lsimg;")

        # "U+02A90", "GREATER-THAN ABOVE SIMILAR ABOVE LESS-THAN"
        txt = txt.replace("⪐", "&gsiml;")

        # "U+02A91", "LESS-THAN ABOVE GREATER-THAN ABOVE DOUBLE-LINE EQUAL"
        txt = txt.replace("⪑", "&lgE;")

        # "U+02A92", "GREATER-THAN ABOVE LESS-THAN ABOVE DOUBLE-LINE EQUAL"
        txt = txt.replace("⪒", "&glE;")

        # "U+02A93", "LESS-THAN ABOVE SLANTED EQUAL ABOVE GREATER-THAN ABOVE SLANTED EQUAL"
        txt = txt.replace("⪓", "&lesges;")

        # "U+02A94", "GREATER-THAN ABOVE SLANTED EQUAL ABOVE LESS-THAN ABOVE SLANTED EQUAL"
        txt = txt.replace("⪔", "&gesles;")

        # "U+02A95", "SLANTED EQUAL TO OR LESS-THAN"
        txt = txt.replace("⪕", "&els;")

        # "U+02A96", "SLANTED EQUAL TO OR GREATER-THAN"
        txt = txt.replace("⪖", "&egs;")

        # "U+02A97", "SLANTED EQUAL TO OR LESS-THAN WITH DOT INSIDE"
        txt = txt.replace("⪗", "&elsdot;")

        # "U+02A98", "SLANTED EQUAL TO OR GREATER-THAN WITH DOT INSIDE"
        txt = txt.replace("⪘", "&egsdot;")

        # "U+02A99", "DOUBLE-LINE EQUAL TO OR LESS-THAN"
        txt = txt.replace("⪙", "&el;")

        # "U+02A9A", "DOUBLE-LINE EQUAL TO OR GREATER-THAN"
        txt = txt.replace("⪚", "&eg;")

        # "U+02A9D", "SIMILAR OR LESS-THAN"
        txt = txt.replace("⪝", "&siml;")

        # "U+02A9E", "SIMILAR OR GREATER-THAN"
        txt = txt.replace("⪞", "&simg;")

        # "U+02A9F", "SIMILAR ABOVE LESS-THAN ABOVE EQUALS SIGN"
        txt = txt.replace("⪟", "&simlE;")

        # "U+02AA0", "SIMILAR ABOVE GREATER-THAN ABOVE EQUALS SIGN"
        txt = txt.replace("⪠", "&simgE;")

        # "U+02AA1", "DOUBLE NESTED LESS-THAN"
        txt = txt.replace("⪡", "&LessLess;")

        # "U+02AA2", "DOUBLE NESTED GREATER-THAN"
        txt = txt.replace("⪢", "&GreaterGreater;")

        # "U+02AA4", "GREATER-THAN OVERLAPPING LESS-THAN"
        txt = txt.replace("⪤", "&glj;")

        # "U+02AA5", "GREATER-THAN BESIDE LESS-THAN"
        txt = txt.replace("⪥", "&gla;")

        # "U+02AA6", "LESS-THAN CLOSED BY CURVE"
        txt = txt.replace("⪦", "&ltcc;")

        # "U+02AA7", "GREATER-THAN CLOSED BY CURVE"
        txt = txt.replace("⪧", "&gtcc;")

        # "U+02AA8", "LESS-THAN CLOSED BY CURVE ABOVE SLANTED EQUAL"
        txt = txt.replace("⪨", "&lescc;")

        # "U+02AA9", "GREATER-THAN CLOSED BY CURVE ABOVE SLANTED EQUAL"
        txt = txt.replace("⪩", "&gescc;")

        # "U+02AAA", "SMALLER THAN"
        txt = txt.replace("⪪", "&smt;")

        # "U+02AAB", "LARGER THAN"
        txt = txt.replace("⪫", "&lat;")

        # "U+02AAC", "SMALLER THAN OR EQUAL TO"
        txt = txt.replace("⪬", "&smte;")

        # "U+02AAD", "LARGER THAN OR EQUAL TO"
        txt = txt.replace("⪭", "&late;")

        # "U+02AAE", "EQUALS SIGN WITH BUMPY ABOVE"
        txt = txt.replace("⪮", "&bumpE;")

        # "U+02AAF", "PRECEDES ABOVE SINGLE-LINE EQUALS SIGN"
        txt = txt.replace("⪯", "&pre;")

        # "U+02AB0", "SUCCEEDS ABOVE SINGLE-LINE EQUALS SIGN"
        txt = txt.replace("⪰", "&sce;")

        # "U+02AB3", "PRECEDES ABOVE EQUALS SIGN"
        txt = txt.replace("⪳", "&prE;")

        # "U+02AB4", "SUCCEEDS ABOVE EQUALS SIGN"
        txt = txt.replace("⪴", "&scE;")

        # "U+02AB5", "PRECEDES ABOVE NOT EQUAL TO"
        txt = txt.replace("⪵", "&prnE;")

        # "U+02AB6", "SUCCEEDS ABOVE NOT EQUAL TO"
        txt = txt.replace("⪶", "&scnE;")

        # "U+02AB7", "PRECEDES ABOVE ALMOST EQUAL TO"
        txt = txt.replace("⪷", "&prap;")

        # "U+02AB8", "SUCCEEDS ABOVE ALMOST EQUAL TO"
        txt = txt.replace("⪸", "&scap;")

        # "U+02AB9", "PRECEDES ABOVE NOT ALMOST EQUAL TO"
        txt = txt.replace("⪹", "&prnap;")

        # "U+02ABA", "SUCCEEDS ABOVE NOT ALMOST EQUAL TO"
        txt = txt.replace("⪺", "&scnap;")

        # "U+02ABB", "DOUBLE PRECEDES"
        txt = txt.replace("⪻", "&Pr;")

        # "U+02ABC", "DOUBLE SUCCEEDS"
        txt = txt.replace("⪼", "&Sc;")

        # "U+02ABD", "SUBSET WITH DOT"
        txt = txt.replace("⪽", "&subdot;")

        # "U+02ABE", "SUPERSET WITH DOT"
        txt = txt.replace("⪾", "&supdot;")

        # "U+02ABF", "SUBSET WITH PLUS SIGN BELOW"
        txt = txt.replace("⪿", "&subplus;")

        # "U+02AC0", "SUPERSET WITH PLUS SIGN BELOW"
        txt = txt.replace("⫀", "&supplus;")

        # "U+02AC1", "SUBSET WITH MULTIPLICATION SIGN BELOW"
        txt = txt.replace("⫁", "&submult;")

        # "U+02AC2", "SUPERSET WITH MULTIPLICATION SIGN BELOW"
        txt = txt.replace("⫂", "&supmult;")

        # "U+02AC3", "SUBSET OF OR EQUAL TO WITH DOT ABOVE"
        txt = txt.replace("⫃", "&subedot;")

        # "U+02AC4", "SUPERSET OF OR EQUAL TO WITH DOT ABOVE"
        txt = txt.replace("⫄", "&supedot;")

        # "U+02AC5", "SUBSET OF ABOVE EQUALS SIGN"
        txt = txt.replace("⫅", "&subE;")

        # "U+02AC6", "SUPERSET OF ABOVE EQUALS SIGN"
        txt = txt.replace("⫆", "&supE;")

        # "U+02AC7", "SUBSET OF ABOVE TILDE OPERATOR"
        txt = txt.replace("⫇", "&subsim;")

        # "U+02AC8", "SUPERSET OF ABOVE TILDE OPERATOR"
        txt = txt.replace("⫈", "&supsim;")

        # "U+02ACB", "SUBSET OF ABOVE NOT EQUAL TO"
        txt = txt.replace("⫋", "&subnE;")

        # "U+02ACC", "SUPERSET OF ABOVE NOT EQUAL TO"
        txt = txt.replace("⫌", "&supnE;")

        # "U+02ACF", "CLOSED SUBSET"
        txt = txt.replace("⫏", "&csub;")

        # "U+02AD0", "CLOSED SUPERSET"
        txt = txt.replace("⫐", "&csup;")

        # "U+02AD1", "CLOSED SUBSET OR EQUAL TO"
        txt = txt.replace("⫑", "&csube;")

        # "U+02AD2", "CLOSED SUPERSET OR EQUAL TO"
        txt = txt.replace("⫒", "&csupe;")

        # "U+02AD3", "SUBSET ABOVE SUPERSET"
        txt = txt.replace("⫓", "&subsup;")

        # "U+02AD4", "SUPERSET ABOVE SUBSET"
        txt = txt.replace("⫔", "&supsub;")

        # "U+02AD5", "SUBSET ABOVE SUBSET"
        txt = txt.replace("⫕", "&subsub;")

        # "U+02AD6", "SUPERSET ABOVE SUPERSET"
        txt = txt.replace("⫖", "&supsup;")

        # "U+02AD7", "SUPERSET BESIDE SUBSET"
        txt = txt.replace("⫗", "&suphsub;")

        # "U+02AD8", "SUPERSET BESIDE AND JOINED BY DASH WITH SUBSET"
        txt = txt.replace("⫘", "&supdsub;")

        # "U+02AD9", "ELEMENT OF OPENING DOWNWARDS"
        txt = txt.replace("⫙", "&forkv;")

        # "U+02ADA", "PITCHFORK WITH TEE TOP"
        txt = txt.replace("⫚", "&topfork;")

        # "U+02ADB", "TRANSVERSAL INTERSECTION"
        txt = txt.replace("⫛", "&mlcp;")

        # "U+02AE4", "VERTICAL BAR DOUBLE LEFT TURNSTILE"
        txt = txt.replace("⫤", "&Dashv;")

        # "U+02AE6", "LONG DASH FROM LEFT MEMBER OF DOUBLE VERTICAL"
        txt = txt.replace("⫦", "&Vdashl;")

        # "U+02AE7", "SHORT DOWN TACK WITH OVERBAR"
        txt = txt.replace("⫧", "&Barv;")

        # "U+02AE8", "SHORT UP TACK WITH UNDERBAR"
        txt = txt.replace("⫨", "&vBar;")

        # "U+02AE9", "SHORT UP TACK ABOVE SHORT DOWN TACK"
        txt = txt.replace("⫩", "&vBarv;")

        # "U+02AEB", "DOUBLE UP TACK"
        txt = txt.replace("⫫", "&Vbar;")

        # "U+02AEC", "DOUBLE STROKE NOT SIGN"
        txt = txt.replace("⫬", "&Not;")

        # "U+02AED", "REVERSED DOUBLE STROKE NOT SIGN"
        txt = txt.replace("⫭", "&bNot;")

        # "U+02AEE", "DOES NOT DIVIDE WITH REVERSED NEGATION SLASH"
        txt = txt.replace("⫮", "&rnmid;")

        # "U+02AEF", "VERTICAL LINE WITH CIRCLE ABOVE"
        txt = txt.replace("⫯", "&cirmid;")

        # "U+02AF0", "VERTICAL LINE WITH CIRCLE BELOW"
        txt = txt.replace("⫰", "&midcir;")

        # "U+02AF1", "DOWN TACK WITH CIRCLE BELOW"
        txt = txt.replace("⫱", "&topcir;")

        # "U+02AF2", "PARALLEL WITH HORIZONTAL STROKE"
        txt = txt.replace("⫲", "&nhpar;")

        # "U+02AF3", "PARALLEL WITH TILDE OPERATOR"
        txt = txt.replace("⫳", "&parsim;")

        # "U+02AFD", "DOUBLE SOLIDUS OPERATOR"
        txt = txt.replace("⫽", "&parsl;")

        # "U+0FB00", "LATIN SMALL LIGATURE FF"
        txt = txt.replace("ﬀ", "&fflig;")

        # "U+0FB01", "LATIN SMALL LIGATURE FI"
        txt = txt.replace("ﬁ", "&filig;")

        # "U+0FB02", "LATIN SMALL LIGATURE FL"
        txt = txt.replace("ﬂ", "&fllig;")

        # "U+0FB03", "LATIN SMALL LIGATURE FFI"
        txt = txt.replace("ﬃ", "&ffilig;")

        # "U+0FB04", "LATIN SMALL LIGATURE FFL"
        txt = txt.replace("ﬄ", "&ffllig;")

        # "U+1D49C", "MATHEMATICAL SCRIPT CAPITAL A"
        txt = txt.replace("𝒜", "&Ascr;")

        # "U+1D49E", "MATHEMATICAL SCRIPT CAPITAL C"
        txt = txt.replace("𝒞", "&Cscr;")

        # "U+1D49F", "MATHEMATICAL SCRIPT CAPITAL D"
        txt = txt.replace("𝒟", "&Dscr;")

        # "U+1D4A2", "MATHEMATICAL SCRIPT CAPITAL G"
        txt = txt.replace("𝒢", "&Gscr;")

        # "U+1D4A5", "MATHEMATICAL SCRIPT CAPITAL J"
        txt = txt.replace("𝒥", "&Jscr;")

        # "U+1D4A6", "MATHEMATICAL SCRIPT CAPITAL K"
        txt = txt.replace("𝒦", "&Kscr;")

        # "U+1D4A9", "MATHEMATICAL SCRIPT CAPITAL N"
        txt = txt.replace("𝒩", "&Nscr;")

        # "U+1D4AA", "MATHEMATICAL SCRIPT CAPITAL O"
        txt = txt.replace("𝒪", "&Oscr;")

        # "U+1D4AB", "MATHEMATICAL SCRIPT CAPITAL P"
        txt = txt.replace("𝒫", "&Pscr;")

        # "U+1D4AC", "MATHEMATICAL SCRIPT CAPITAL Q"
        txt = txt.replace("𝒬", "&Qscr;")

        # "U+1D4AE", "MATHEMATICAL SCRIPT CAPITAL S"
        txt = txt.replace("𝒮", "&Sscr;")

        # "U+1D4AF", "MATHEMATICAL SCRIPT CAPITAL T"
        txt = txt.replace("𝒯", "&Tscr;")

        # "U+1D4B0", "MATHEMATICAL SCRIPT CAPITAL U"
        txt = txt.replace("𝒰", "&Uscr;")

        # "U+1D4B1", "MATHEMATICAL SCRIPT CAPITAL V"
        txt = txt.replace("𝒱", "&Vscr;")

        # "U+1D4B2", "MATHEMATICAL SCRIPT CAPITAL W"
        txt = txt.replace("𝒲", "&Wscr;")

        # "U+1D4B3", "MATHEMATICAL SCRIPT CAPITAL X"
        txt = txt.replace("𝒳", "&Xscr;")

        # "U+1D4B4", "MATHEMATICAL SCRIPT CAPITAL Y"
        txt = txt.replace("𝒴", "&Yscr;")

        # "U+1D4B5", "MATHEMATICAL SCRIPT CAPITAL Z"
        txt = txt.replace("𝒵", "&Zscr;")

        # "U+1D4B6", "MATHEMATICAL SCRIPT SMALL A"
        txt = txt.replace("𝒶", "&ascr;")

        # "U+1D4B7", "MATHEMATICAL SCRIPT SMALL B"
        txt = txt.replace("𝒷", "&bscr;")

        # "U+1D4B8", "MATHEMATICAL SCRIPT SMALL C"
        txt = txt.replace("𝒸", "&cscr;")

        # "U+1D4B9", "MATHEMATICAL SCRIPT SMALL D"
        txt = txt.replace("𝒹", "&dscr;")

        # "U+1D4BB", "MATHEMATICAL SCRIPT SMALL F"
        txt = txt.replace("𝒻", "&fscr;")

        # "U+1D4BD", "MATHEMATICAL SCRIPT SMALL H"
        txt = txt.replace("𝒽", "&hscr;")

        # "U+1D4BE", "MATHEMATICAL SCRIPT SMALL I"
        txt = txt.replace("𝒾", "&iscr;")

        # "U+1D4BF", "MATHEMATICAL SCRIPT SMALL J"
        txt = txt.replace("𝒿", "&jscr;")

        # "U+1D4C0", "MATHEMATICAL SCRIPT SMALL K"
        txt = txt.replace("𝓀", "&kscr;")

        # "U+1D4C1", "MATHEMATICAL SCRIPT SMALL L"
        txt = txt.replace("𝓁", "&lscr;")

        # "U+1D4C2", "MATHEMATICAL SCRIPT SMALL M"
        txt = txt.replace("𝓂", "&mscr;")

        # "U+1D4C3", "MATHEMATICAL SCRIPT SMALL N"
        txt = txt.replace("𝓃", "&nscr;")

        # "U+1D4C5", "MATHEMATICAL SCRIPT SMALL P"
        txt = txt.replace("𝓅", "&pscr;")

        # "U+1D4C6", "MATHEMATICAL SCRIPT SMALL Q"
        txt = txt.replace("𝓆", "&qscr;")

        # "U+1D4C7", "MATHEMATICAL SCRIPT SMALL R"
        txt = txt.replace("𝓇", "&rscr;")

        # "U+1D4C8", "MATHEMATICAL SCRIPT SMALL S"
        txt = txt.replace("𝓈", "&sscr;")

        # "U+1D4C9", "MATHEMATICAL SCRIPT SMALL T"
        txt = txt.replace("𝓉", "&tscr;")

        # "U+1D4CA", "MATHEMATICAL SCRIPT SMALL U"
        txt = txt.replace("𝓊", "&uscr;")

        # "U+1D4CB", "MATHEMATICAL SCRIPT SMALL V"
        txt = txt.replace("𝓋", "&vscr;")

        # "U+1D4CC", "MATHEMATICAL SCRIPT SMALL W"
        txt = txt.replace("𝓌", "&wscr;")

        # "U+1D4CD", "MATHEMATICAL SCRIPT SMALL X"
        txt = txt.replace("𝓍", "&xscr;")

        # "U+1D4CE", "MATHEMATICAL SCRIPT SMALL Y"
        txt = txt.replace("𝓎", "&yscr;")

        # "U+1D4CF", "MATHEMATICAL SCRIPT SMALL Z"
        txt = txt.replace("𝓏", "&zscr;")

        # "U+1D504", "MATHEMATICAL FRAKTUR CAPITAL A"
        txt = txt.replace("𝔄", "&Afr;")

        # "U+1D505", "MATHEMATICAL FRAKTUR CAPITAL B"
        txt = txt.replace("𝔅", "&Bfr;")

        # "U+1D507", "MATHEMATICAL FRAKTUR CAPITAL D"
        txt = txt.replace("𝔇", "&Dfr;")

        # "U+1D508", "MATHEMATICAL FRAKTUR CAPITAL E"
        txt = txt.replace("𝔈", "&Efr;")

        # "U+1D509", "MATHEMATICAL FRAKTUR CAPITAL F"
        txt = txt.replace("𝔉", "&Ffr;")

        # "U+1D50A", "MATHEMATICAL FRAKTUR CAPITAL G"
        txt = txt.replace("𝔊", "&Gfr;")

        # "U+1D50D", "MATHEMATICAL FRAKTUR CAPITAL J"
        txt = txt.replace("𝔍", "&Jfr;")

        # "U+1D50E", "MATHEMATICAL FRAKTUR CAPITAL K"
        txt = txt.replace("𝔎", "&Kfr;")

        # "U+1D50F", "MATHEMATICAL FRAKTUR CAPITAL L"
        txt = txt.replace("𝔏", "&Lfr;")

        # "U+1D510", "MATHEMATICAL FRAKTUR CAPITAL M"
        txt = txt.replace("𝔐", "&Mfr;")

        # "U+1D511", "MATHEMATICAL FRAKTUR CAPITAL N"
        txt = txt.replace("𝔑", "&Nfr;")

        # "U+1D512", "MATHEMATICAL FRAKTUR CAPITAL O"
        txt = txt.replace("𝔒", "&Ofr;")

        # "U+1D513", "MATHEMATICAL FRAKTUR CAPITAL P"
        txt = txt.replace("𝔓", "&Pfr;")

        # "U+1D514", "MATHEMATICAL FRAKTUR CAPITAL Q"
        txt = txt.replace("𝔔", "&Qfr;")

        # "U+1D516", "MATHEMATICAL FRAKTUR CAPITAL S"
        txt = txt.replace("𝔖", "&Sfr;")

        # "U+1D517", "MATHEMATICAL FRAKTUR CAPITAL T"
        txt = txt.replace("𝔗", "&Tfr;")

        # "U+1D518", "MATHEMATICAL FRAKTUR CAPITAL U"
        txt = txt.replace("𝔘", "&Ufr;")

        # "U+1D519", "MATHEMATICAL FRAKTUR CAPITAL V"
        txt = txt.replace("𝔙", "&Vfr;")

        # "U+1D51A", "MATHEMATICAL FRAKTUR CAPITAL W"
        txt = txt.replace("𝔚", "&Wfr;")

        # "U+1D51B", "MATHEMATICAL FRAKTUR CAPITAL X"
        txt = txt.replace("𝔛", "&Xfr;")

        # "U+1D51C", "MATHEMATICAL FRAKTUR CAPITAL Y"
        txt = txt.replace("𝔜", "&Yfr;")

        # "U+1D51E", "MATHEMATICAL FRAKTUR SMALL A"
        txt = txt.replace("𝔞", "&afr;")

        # "U+1D51F", "MATHEMATICAL FRAKTUR SMALL B"
        txt = txt.replace("𝔟", "&bfr;")

        # "U+1D520", "MATHEMATICAL FRAKTUR SMALL C"
        txt = txt.replace("𝔠", "&cfr;")

        # "U+1D521", "MATHEMATICAL FRAKTUR SMALL D"
        txt = txt.replace("𝔡", "&dfr;")

        # "U+1D522", "MATHEMATICAL FRAKTUR SMALL E"
        txt = txt.replace("𝔢", "&efr;")

        # "U+1D523", "MATHEMATICAL FRAKTUR SMALL F"
        txt = txt.replace("𝔣", "&ffr;")

        # "U+1D524", "MATHEMATICAL FRAKTUR SMALL G"
        txt = txt.replace("𝔤", "&gfr;")

        # "U+1D525", "MATHEMATICAL FRAKTUR SMALL H"
        txt = txt.replace("𝔥", "&hfr;")

        # "U+1D526", "MATHEMATICAL FRAKTUR SMALL I"
        txt = txt.replace("𝔦", "&ifr;")

        # "U+1D527", "MATHEMATICAL FRAKTUR SMALL J"
        txt = txt.replace("𝔧", "&jfr;")

        # "U+1D528", "MATHEMATICAL FRAKTUR SMALL K"
        txt = txt.replace("𝔨", "&kfr;")

        # "U+1D529", "MATHEMATICAL FRAKTUR SMALL L"
        txt = txt.replace("𝔩", "&lfr;")

        # "U+1D52A", "MATHEMATICAL FRAKTUR SMALL M"
        txt = txt.replace("𝔪", "&mfr;")

        # "U+1D52B", "MATHEMATICAL FRAKTUR SMALL N"
        txt = txt.replace("𝔫", "&nfr;")

        # "U+1D52C", "MATHEMATICAL FRAKTUR SMALL O"
        txt = txt.replace("𝔬", "&ofr;")

        # "U+1D52D", "MATHEMATICAL FRAKTUR SMALL P"
        txt = txt.replace("𝔭", "&pfr;")

        # "U+1D52E", "MATHEMATICAL FRAKTUR SMALL Q"
        txt = txt.replace("𝔮", "&qfr;")

        # "U+1D52F", "MATHEMATICAL FRAKTUR SMALL R"
        txt = txt.replace("𝔯", "&rfr;")

        # "U+1D530", "MATHEMATICAL FRAKTUR SMALL S"
        txt = txt.replace("𝔰", "&sfr;")

        # "U+1D531", "MATHEMATICAL FRAKTUR SMALL T"
        txt = txt.replace("𝔱", "&tfr;")

        # "U+1D532", "MATHEMATICAL FRAKTUR SMALL U"
        txt = txt.replace("𝔲", "&ufr;")

        # "U+1D533", "MATHEMATICAL FRAKTUR SMALL V"
        txt = txt.replace("𝔳", "&vfr;")

        # "U+1D534", "MATHEMATICAL FRAKTUR SMALL W"
        txt = txt.replace("𝔴", "&wfr;")

        # "U+1D535", "MATHEMATICAL FRAKTUR SMALL X"
        txt = txt.replace("𝔵", "&xfr;")

        # "U+1D536", "MATHEMATICAL FRAKTUR SMALL Y"
        txt = txt.replace("𝔶", "&yfr;")

        # "U+1D537", "MATHEMATICAL FRAKTUR SMALL Z"
        txt = txt.replace("𝔷", "&zfr;")

        # "U+1D538", "MATHEMATICAL DOUBLE-STRUCK CAPITAL A"
        txt = txt.replace("𝔸", "&Aopf;")

        # "U+1D539", "MATHEMATICAL DOUBLE-STRUCK CAPITAL B"
        txt = txt.replace("𝔹", "&Bopf;")

        # "U+1D53B", "MATHEMATICAL DOUBLE-STRUCK CAPITAL D"
        txt = txt.replace("𝔻", "&Dopf;")

        # "U+1D53C", "MATHEMATICAL DOUBLE-STRUCK CAPITAL E"
        txt = txt.replace("𝔼", "&Eopf;")

        # "U+1D53D", "MATHEMATICAL DOUBLE-STRUCK CAPITAL F"
        txt = txt.replace("𝔽", "&Fopf;")

        # "U+1D53E", "MATHEMATICAL DOUBLE-STRUCK CAPITAL G"
        txt = txt.replace("𝔾", "&Gopf;")

        # "U+1D540", "MATHEMATICAL DOUBLE-STRUCK CAPITAL I"
        txt = txt.replace("𝕀", "&Iopf;")

        # "U+1D541", "MATHEMATICAL DOUBLE-STRUCK CAPITAL J"
        txt = txt.replace("𝕁", "&Jopf;")

        # "U+1D542", "MATHEMATICAL DOUBLE-STRUCK CAPITAL K"
        txt = txt.replace("𝕂", "&Kopf;")

        # "U+1D543", "MATHEMATICAL DOUBLE-STRUCK CAPITAL L"
        txt = txt.replace("𝕃", "&Lopf;")

        # "U+1D544", "MATHEMATICAL DOUBLE-STRUCK CAPITAL M"
        txt = txt.replace("𝕄", "&Mopf;")

        # "U+1D546", "MATHEMATICAL DOUBLE-STRUCK CAPITAL O"
        txt = txt.replace("𝕆", "&Oopf;")

        # "U+1D54A", "MATHEMATICAL DOUBLE-STRUCK CAPITAL S"
        txt = txt.replace("𝕊", "&Sopf;")

        # "U+1D54B", "MATHEMATICAL DOUBLE-STRUCK CAPITAL T"
        txt = txt.replace("𝕋", "&Topf;")

        # "U+1D54C", "MATHEMATICAL DOUBLE-STRUCK CAPITAL U"
        txt = txt.replace("𝕌", "&Uopf;")

        # "U+1D54D", "MATHEMATICAL DOUBLE-STRUCK CAPITAL V"
        txt = txt.replace("𝕍", "&Vopf;")

        # "U+1D54E", "MATHEMATICAL DOUBLE-STRUCK CAPITAL W"
        txt = txt.replace("𝕎", "&Wopf;")

        # "U+1D54F", "MATHEMATICAL DOUBLE-STRUCK CAPITAL X"
        txt = txt.replace("𝕏", "&Xopf;")

        # "U+1D550", "MATHEMATICAL DOUBLE-STRUCK CAPITAL Y"
        txt = txt.replace("𝕐", "&Yopf;")

        # "U+1D552", "MATHEMATICAL DOUBLE-STRUCK SMALL A"
        txt = txt.replace("𝕒", "&aopf;")

        # "U+1D553", "MATHEMATICAL DOUBLE-STRUCK SMALL B"
        txt = txt.replace("𝕓", "&bopf;")

        # "U+1D554", "MATHEMATICAL DOUBLE-STRUCK SMALL C"
        txt = txt.replace("𝕔", "&copf;")

        # "U+1D555", "MATHEMATICAL DOUBLE-STRUCK SMALL D"
        txt = txt.replace("𝕕", "&dopf;")

        # "U+1D556", "MATHEMATICAL DOUBLE-STRUCK SMALL E"
        txt = txt.replace("𝕖", "&eopf;")

        # "U+1D557", "MATHEMATICAL DOUBLE-STRUCK SMALL F"
        txt = txt.replace("𝕗", "&fopf;")

        # "U+1D558", "MATHEMATICAL DOUBLE-STRUCK SMALL G"
        txt = txt.replace("𝕘", "&gopf;")

        # "U+1D559", "MATHEMATICAL DOUBLE-STRUCK SMALL H"
        txt = txt.replace("𝕙", "&hopf;")

        # "U+1D55A", "MATHEMATICAL DOUBLE-STRUCK SMALL I"
        txt = txt.replace("𝕚", "&iopf;")

        # "U+1D55B", "MATHEMATICAL DOUBLE-STRUCK SMALL J"
        txt = txt.replace("𝕛", "&jopf;")

        # "U+1D55C", "MATHEMATICAL DOUBLE-STRUCK SMALL K"
        txt = txt.replace("𝕜", "&kopf;")

        # "U+1D55D", "MATHEMATICAL DOUBLE-STRUCK SMALL L"
        txt = txt.replace("𝕝", "&lopf;")

        # "U+1D55E", "MATHEMATICAL DOUBLE-STRUCK SMALL M"
        txt = txt.replace("𝕞", "&mopf;")

        # "U+1D55F", "MATHEMATICAL DOUBLE-STRUCK SMALL N"
        txt = txt.replace("𝕟", "&nopf;")

        # "U+1D560", "MATHEMATICAL DOUBLE-STRUCK SMALL O"
        txt = txt.replace("𝕠", "&oopf;")

        # "U+1D561", "MATHEMATICAL DOUBLE-STRUCK SMALL P"
        txt = txt.replace("𝕡", "&popf;")

        # "U+1D562", "MATHEMATICAL DOUBLE-STRUCK SMALL Q"
        txt = txt.replace("𝕢", "&qopf;")

        # "U+1D563", "MATHEMATICAL DOUBLE-STRUCK SMALL R"
        txt = txt.replace("𝕣", "&ropf;")

        # "U+1D564", "MATHEMATICAL DOUBLE-STRUCK SMALL S"
        txt = txt.replace("𝕤", "&sopf;")

        # "U+1D565", "MATHEMATICAL DOUBLE-STRUCK SMALL T"
        txt = txt.replace("𝕥", "&topf;")

        # "U+1D566", "MATHEMATICAL DOUBLE-STRUCK SMALL U"
        txt = txt.replace("𝕦", "&uopf;")

        # "U+1D567", "MATHEMATICAL DOUBLE-STRUCK SMALL V"
        txt = txt.replace("𝕧", "&vopf;")

        # "U+1D568", "MATHEMATICAL DOUBLE-STRUCK SMALL W"
        txt = txt.replace("𝕨", "&wopf;")

        # "U+1D569", "MATHEMATICAL DOUBLE-STRUCK SMALL X"
        txt = txt.replace("𝕩", "&xopf;")

        # "U+1D56A", "MATHEMATICAL DOUBLE-STRUCK SMALL Y"
        txt = txt.replace("𝕪", "&yopf;")

        # "U+1D56B", "MATHEMATICAL DOUBLE-STRUCK SMALL Z"
        txt = txt.replace("𝕫", "&zopf;")

        return txt

    """
    入力される文字列内の文字や記号を文字実体参照に置きかえます。
    :param source: 置きかえられる文字列の配列。
    :param escape_sequence_flag: エスケープシーケンスを置きかえるフラグ。
    :return: 置きかえられた文字列の配列。
    """

    @staticmethod
    def convert_to_all(sources: List[str], escape_sequence_flag: bool) -> List[str]:
        for i in range(len(sources)):
            sources[i] = CharacterEntityReference.convert_to(
                sources[i], escape_sequence_flag
            )

        return sources
