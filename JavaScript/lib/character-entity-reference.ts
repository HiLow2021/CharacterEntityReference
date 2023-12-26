class CharacterEntityReference {
    /**
     * 入力される文字列内の文字実体参照を文字や記号に置きかえます。ベーシック版です。
     * @param source 置きかえられる文字列。
     * @returns 置きかえられた文字列。
     */
    public static convertFromCharacterEntityReferenceBasic(source: string): string {
        let txt = source;

        // "U+00022", "QUOTATION MARK"
        txt = txt.replace(/&#x0*?22;/g, '"');
        txt = txt.replace(/&#0*?34;/g, '"');
        txt = txt.replace(/&quot;/g, '"');
        txt = txt.replace(/&QUOT;/g, '"');

        // "U+00026", "AMPERSAND"
        txt = txt.replace(/&#x0*?26;/g, '&');
        txt = txt.replace(/&#0*?38;/g, '&');
        txt = txt.replace(/&amp;/g, '&');
        txt = txt.replace(/&AMP;/g, '&');

        // "U+00027", "APOSTROPHE"
        txt = txt.replace(/&#x0*?27;/g, "'");
        txt = txt.replace(/&#0*?39;/g, "'");
        txt = txt.replace(/&apos;/g, "'");

        // "U+0003C", "LESS-THAN SIGN"
        txt = txt.replace(/&#x0*?3C;/g, '<');
        txt = txt.replace(/&#0*?60;/g, '<');
        txt = txt.replace(/&lt;/g, '<');
        txt = txt.replace(/&LT;/g, '<');

        // "U+0003E", "GREATER-THAN SIGN"
        txt = txt.replace(/&#x0*?3E;/g, '>');
        txt = txt.replace(/&#0*?62;/g, '>');
        txt = txt.replace(/&gt;/g, '>');
        txt = txt.replace(/&GT;/g, '>');

        // "U+000A0", "NO-BREAK SPACE"
        txt = txt.replace(/&#x0*?A0;/g, ' ');
        txt = txt.replace(/&#0*?160;/g, ' ');
        txt = txt.replace(/&nbsp;/g, ' ');
        txt = txt.replace(/&NonBreakingSpace;/g, ' ');

        // "U+000A1", "INVERTED EXCLAMATION MARK"
        txt = txt.replace(/&#x0*?A1;/g, '¡');
        txt = txt.replace(/&#0*?161;/g, '¡');
        txt = txt.replace(/&iexcl;/g, '¡');

        // "U+000A2", "CENT SIGN"
        txt = txt.replace(/&#x0*?A2;/g, '¢');
        txt = txt.replace(/&#0*?162;/g, '¢');
        txt = txt.replace(/&cent;/g, '¢');

        // "U+000A3", "POUND SIGN"
        txt = txt.replace(/&#x0*?A3;/g, '£');
        txt = txt.replace(/&#0*?163;/g, '£');
        txt = txt.replace(/&pound;/g, '£');

        // "U+000A4", "CURRENCY SIGN"
        txt = txt.replace(/&#x0*?A4;/g, '¤');
        txt = txt.replace(/&#0*?164;/g, '¤');
        txt = txt.replace(/&curren;/g, '¤');

        // "U+000A5", "YEN SIGN"
        txt = txt.replace(/&#x0*?A5;/g, '¥');
        txt = txt.replace(/&#0*?165;/g, '¥');
        txt = txt.replace(/&yen;/g, '¥');

        // "U+000A6", "BROKEN BAR"
        txt = txt.replace(/&#x0*?A6;/g, '¦');
        txt = txt.replace(/&#0*?166;/g, '¦');
        txt = txt.replace(/&brvbar;/g, '¦');

        // "U+000A7", "SECTION SIGN"
        txt = txt.replace(/&#x0*?A7;/g, '§');
        txt = txt.replace(/&#0*?167;/g, '§');
        txt = txt.replace(/&sect;/g, '§');

        // "U+000A8", "DIAERESIS"
        txt = txt.replace(/&#x0*?A8;/g, '¨');
        txt = txt.replace(/&#0*?168;/g, '¨');
        txt = txt.replace(/&Dot;/g, '¨');
        txt = txt.replace(/&die;/g, '¨');
        txt = txt.replace(/&DoubleDot;/g, '¨');
        txt = txt.replace(/&uml;/g, '¨');

        // "U+000A9", "COPYRIGHT SIGN"
        txt = txt.replace(/&#x0*?A9;/g, '©');
        txt = txt.replace(/&#0*?169;/g, '©');
        txt = txt.replace(/&copy;/g, '©');
        txt = txt.replace(/&COPY;/g, '©');

        // "U+000AA", "FEMININE ORDINAL INDICATOR"
        txt = txt.replace(/&#x0*?AA;/g, 'ª');
        txt = txt.replace(/&#0*?170;/g, 'ª');
        txt = txt.replace(/&ordf;/g, 'ª');

        // "U+000AB", "LEFT-POINTING DOUBLE ANGLE QUOTATION MARK"
        txt = txt.replace(/&#x0*?AB;/g, '«');
        txt = txt.replace(/&#0*?171;/g, '«');
        txt = txt.replace(/&laquo;/g, '«');

        // "U+000AC", "NOT SIGN"
        txt = txt.replace(/&#x0*?AC;/g, '¬');
        txt = txt.replace(/&#0*?172;/g, '¬');
        txt = txt.replace(/&not;/g, '¬');

        // "U+000AD", "SOFT HYPHEN"
        txt = txt.replace(/&#x0*?AD;/g, '­');
        txt = txt.replace(/&#0*?173;/g, '­');
        txt = txt.replace(/&shy;/g, '­');

        // "U+000AE", "REGISTERED SIGN"
        txt = txt.replace(/&#x0*?AE;/g, '®');
        txt = txt.replace(/&#0*?174;/g, '®');
        txt = txt.replace(/&reg;/g, '®');
        txt = txt.replace(/&circledR;/g, '®');
        txt = txt.replace(/&REG;/g, '®');

        // "U+000AF", "MACRON"
        txt = txt.replace(/&#x0*?AF;/g, '¯');
        txt = txt.replace(/&#0*?175;/g, '¯');
        txt = txt.replace(/&macr;/g, '¯');
        txt = txt.replace(/&OverBar;/g, '¯');
        txt = txt.replace(/&strns;/g, '¯');

        // "U+000B0", "DEGREE SIGN"
        txt = txt.replace(/&#x0*?B0;/g, '°');
        txt = txt.replace(/&#0*?176;/g, '°');
        txt = txt.replace(/&deg;/g, '°');

        // "U+000B1", "PLUS-MINUS SIGN"
        txt = txt.replace(/&#x0*?B1;/g, '±');
        txt = txt.replace(/&#0*?177;/g, '±');
        txt = txt.replace(/&plusmn;/g, '±');
        txt = txt.replace(/&pm;/g, '±');
        txt = txt.replace(/&PlusMinus;/g, '±');

        // "U+000B2", "SUPERSCRIPT TWO"
        txt = txt.replace(/&#x0*?B2;/g, '²');
        txt = txt.replace(/&#0*?178;/g, '²');
        txt = txt.replace(/&sup2;/g, '²');

        // "U+000B3", "SUPERSCRIPT THREE"
        txt = txt.replace(/&#x0*?B3;/g, '³');
        txt = txt.replace(/&#0*?179;/g, '³');
        txt = txt.replace(/&sup3;/g, '³');

        // "U+000B4", "ACUTE ACCENT"
        txt = txt.replace(/&#x0*?B4;/g, '´');
        txt = txt.replace(/&#0*?180;/g, '´');
        txt = txt.replace(/&acute;/g, '´');
        txt = txt.replace(/&DiacriticalAcute;/g, '´');

        // "U+000B5", "MICRO SIGN"
        txt = txt.replace(/&#x0*?B5;/g, 'µ');
        txt = txt.replace(/&#0*?181;/g, 'µ');
        txt = txt.replace(/&micro;/g, 'µ');

        // "U+000B6", "PILCROW SIGN"
        txt = txt.replace(/&#x0*?B6;/g, '¶');
        txt = txt.replace(/&#0*?182;/g, '¶');
        txt = txt.replace(/&para;/g, '¶');

        // "U+000B7", "MIDDLE DOT"
        txt = txt.replace(/&#x0*?B7;/g, '·');
        txt = txt.replace(/&#0*?183;/g, '·');
        txt = txt.replace(/&middot;/g, '·');
        txt = txt.replace(/&centerdot;/g, '·');
        txt = txt.replace(/&CenterDot;/g, '·');

        // "U+000B8", "CEDILLA"
        txt = txt.replace(/&#x0*?B8;/g, '¸');
        txt = txt.replace(/&#0*?184;/g, '¸');
        txt = txt.replace(/&cedil;/g, '¸');
        txt = txt.replace(/&Cedilla;/g, '¸');

        // "U+000B9", "SUPERSCRIPT ONE"
        txt = txt.replace(/&#x0*?B9;/g, '¹');
        txt = txt.replace(/&#0*?185;/g, '¹');
        txt = txt.replace(/&sup1;/g, '¹');

        // "U+000BA", "MASCULINE ORDINAL INDICATOR"
        txt = txt.replace(/&#x0*?BA;/g, 'º');
        txt = txt.replace(/&#0*?186;/g, 'º');
        txt = txt.replace(/&ordm;/g, 'º');

        // "U+000BB", "RIGHT-POINTING DOUBLE ANGLE QUOTATION MARK"
        txt = txt.replace(/&#x0*?BB;/g, '»');
        txt = txt.replace(/&#0*?187;/g, '»');
        txt = txt.replace(/&raquo;/g, '»');

        // "U+000BC", "VULGAR FRACTION ONE QUARTER"
        txt = txt.replace(/&#x0*?BC;/g, '¼');
        txt = txt.replace(/&#0*?188;/g, '¼');
        txt = txt.replace(/&frac14;/g, '¼');

        // "U+000BD", "VULGAR FRACTION ONE HALF"
        txt = txt.replace(/&#x0*?BD;/g, '½');
        txt = txt.replace(/&#0*?189;/g, '½');
        txt = txt.replace(/&frac12;/g, '½');
        txt = txt.replace(/&half;/g, '½');

        // "U+000BE", "VULGAR FRACTION THREE QUARTERS"
        txt = txt.replace(/&#x0*?BE;/g, '¾');
        txt = txt.replace(/&#0*?190;/g, '¾');
        txt = txt.replace(/&frac34;/g, '¾');

        // "U+000BF", "INVERTED QUESTION MARK"
        txt = txt.replace(/&#x0*?BF;/g, '¿');
        txt = txt.replace(/&#0*?191;/g, '¿');
        txt = txt.replace(/&iquest;/g, '¿');

        // "U+000C0", "LATIN CAPITAL LETTER A WITH GRAVE"
        txt = txt.replace(/&#x0*?C0;/g, 'À');
        txt = txt.replace(/&#0*?192;/g, 'À');
        txt = txt.replace(/&Agrave;/g, 'À');

        // "U+000C1", "LATIN CAPITAL LETTER A WITH ACUTE"
        txt = txt.replace(/&#x0*?C1;/g, 'Á');
        txt = txt.replace(/&#0*?193;/g, 'Á');
        txt = txt.replace(/&Aacute;/g, 'Á');

        // "U+000C2", "LATIN CAPITAL LETTER A WITH CIRCUMFLEX"
        txt = txt.replace(/&#x0*?C2;/g, 'Â');
        txt = txt.replace(/&#0*?194;/g, 'Â');
        txt = txt.replace(/&Acirc;/g, 'Â');

        // "U+000C3", "LATIN CAPITAL LETTER A WITH TILDE"
        txt = txt.replace(/&#x0*?C3;/g, 'Ã');
        txt = txt.replace(/&#0*?195;/g, 'Ã');
        txt = txt.replace(/&Atilde;/g, 'Ã');

        // "U+000C4", "LATIN CAPITAL LETTER A WITH DIAERESIS"
        txt = txt.replace(/&#x0*?C4;/g, 'Ä');
        txt = txt.replace(/&#0*?196;/g, 'Ä');
        txt = txt.replace(/&Auml;/g, 'Ä');

        // "U+000C5", "LATIN CAPITAL LETTER A WITH RING ABOVE"
        txt = txt.replace(/&#x0*?C5;/g, 'Å');
        txt = txt.replace(/&#0*?197;/g, 'Å');
        txt = txt.replace(/&Aring;/g, 'Å');

        // "U+000C6", "LATIN CAPITAL LETTER AE"
        txt = txt.replace(/&#x0*?C6;/g, 'Æ');
        txt = txt.replace(/&#0*?198;/g, 'Æ');
        txt = txt.replace(/&AElig;/g, 'Æ');

        // "U+000C7", "LATIN CAPITAL LETTER C WITH CEDILLA"
        txt = txt.replace(/&#x0*?C7;/g, 'Ç');
        txt = txt.replace(/&#0*?199;/g, 'Ç');
        txt = txt.replace(/&Ccedil;/g, 'Ç');

        // "U+000C8", "LATIN CAPITAL LETTER E WITH GRAVE"
        txt = txt.replace(/&#x0*?C8;/g, 'È');
        txt = txt.replace(/&#0*?200;/g, 'È');
        txt = txt.replace(/&Egrave;/g, 'È');

        // "U+000C9", "LATIN CAPITAL LETTER E WITH ACUTE"
        txt = txt.replace(/&#x0*?C9;/g, 'É');
        txt = txt.replace(/&#0*?201;/g, 'É');
        txt = txt.replace(/&Eacute;/g, 'É');

        // "U+000CA", "LATIN CAPITAL LETTER E WITH CIRCUMFLEX"
        txt = txt.replace(/&#x0*?CA;/g, 'Ê');
        txt = txt.replace(/&#0*?202;/g, 'Ê');
        txt = txt.replace(/&Ecirc;/g, 'Ê');

        // "U+000CB", "LATIN CAPITAL LETTER E WITH DIAERESIS"
        txt = txt.replace(/&#x0*?CB;/g, 'Ë');
        txt = txt.replace(/&#0*?203;/g, 'Ë');
        txt = txt.replace(/&Euml;/g, 'Ë');

        // "U+000CC", "LATIN CAPITAL LETTER I WITH GRAVE"
        txt = txt.replace(/&#x0*?CC;/g, 'Ì');
        txt = txt.replace(/&#0*?204;/g, 'Ì');
        txt = txt.replace(/&Igrave;/g, 'Ì');

        // "U+000CD", "LATIN CAPITAL LETTER I WITH ACUTE"
        txt = txt.replace(/&#x0*?CD;/g, 'Í');
        txt = txt.replace(/&#0*?205;/g, 'Í');
        txt = txt.replace(/&Iacute;/g, 'Í');

        // "U+000CE", "LATIN CAPITAL LETTER I WITH CIRCUMFLEX"
        txt = txt.replace(/&#x0*?CE;/g, 'Î');
        txt = txt.replace(/&#0*?206;/g, 'Î');
        txt = txt.replace(/&Icirc;/g, 'Î');

        // "U+000CF", "LATIN CAPITAL LETTER I WITH DIAERESIS"
        txt = txt.replace(/&#x0*?CF;/g, 'Ï');
        txt = txt.replace(/&#0*?207;/g, 'Ï');
        txt = txt.replace(/&Iuml;/g, 'Ï');

        // "U+000D0", "LATIN CAPITAL LETTER ETH"
        txt = txt.replace(/&#x0*?D0;/g, 'Ð');
        txt = txt.replace(/&#0*?208;/g, 'Ð');
        txt = txt.replace(/&ETH;/g, 'Ð');

        // "U+000D1", "LATIN CAPITAL LETTER N WITH TILDE"
        txt = txt.replace(/&#x0*?D1;/g, 'Ñ');
        txt = txt.replace(/&#0*?209;/g, 'Ñ');
        txt = txt.replace(/&Ntilde;/g, 'Ñ');

        // "U+000D2", "LATIN CAPITAL LETTER O WITH GRAVE"
        txt = txt.replace(/&#x0*?D2;/g, 'Ò');
        txt = txt.replace(/&#0*?210;/g, 'Ò');
        txt = txt.replace(/&Ograve;/g, 'Ò');

        // "U+000D3", "LATIN CAPITAL LETTER O WITH ACUTE"
        txt = txt.replace(/&#x0*?D3;/g, 'Ó');
        txt = txt.replace(/&#0*?211;/g, 'Ó');
        txt = txt.replace(/&Oacute;/g, 'Ó');

        // "U+000D4", "LATIN CAPITAL LETTER O WITH CIRCUMFLEX"
        txt = txt.replace(/&#x0*?D4;/g, 'Ô');
        txt = txt.replace(/&#0*?212;/g, 'Ô');
        txt = txt.replace(/&Ocirc;/g, 'Ô');

        // "U+000D5", "LATIN CAPITAL LETTER O WITH TILDE"
        txt = txt.replace(/&#x0*?D5;/g, 'Õ');
        txt = txt.replace(/&#0*?213;/g, 'Õ');
        txt = txt.replace(/&Otilde;/g, 'Õ');

        // "U+000D6", "LATIN CAPITAL LETTER O WITH DIAERESIS"
        txt = txt.replace(/&#x0*?D6;/g, 'Ö');
        txt = txt.replace(/&#0*?214;/g, 'Ö');
        txt = txt.replace(/&Ouml;/g, 'Ö');

        // "U+000D7", "MULTIPLICATION SIGN"
        txt = txt.replace(/&#x0*?D7;/g, '×');
        txt = txt.replace(/&#0*?215;/g, '×');
        txt = txt.replace(/&times;/g, '×');

        // "U+000D8", "LATIN CAPITAL LETTER O WITH STROKE"
        txt = txt.replace(/&#x0*?D8;/g, 'Ø');
        txt = txt.replace(/&#0*?216;/g, 'Ø');
        txt = txt.replace(/&Oslash;/g, 'Ø');

        // "U+000D9", "LATIN CAPITAL LETTER U WITH GRAVE"
        txt = txt.replace(/&#x0*?D9;/g, 'Ù');
        txt = txt.replace(/&#0*?217;/g, 'Ù');
        txt = txt.replace(/&Ugrave;/g, 'Ù');

        // "U+000DA", "LATIN CAPITAL LETTER U WITH ACUTE"
        txt = txt.replace(/&#x0*?DA;/g, 'Ú');
        txt = txt.replace(/&#0*?218;/g, 'Ú');
        txt = txt.replace(/&Uacute;/g, 'Ú');

        // "U+000DB", "LATIN CAPITAL LETTER U WITH CIRCUMFLEX"
        txt = txt.replace(/&#x0*?DB;/g, 'Û');
        txt = txt.replace(/&#0*?219;/g, 'Û');
        txt = txt.replace(/&Ucirc;/g, 'Û');

        // "U+000DC", "LATIN CAPITAL LETTER U WITH DIAERESIS"
        txt = txt.replace(/&#x0*?DC;/g, 'Ü');
        txt = txt.replace(/&#0*?220;/g, 'Ü');
        txt = txt.replace(/&Uuml;/g, 'Ü');

        // "U+000DD", "LATIN CAPITAL LETTER Y WITH ACUTE"
        txt = txt.replace(/&#x0*?DD;/g, 'Ý');
        txt = txt.replace(/&#0*?221;/g, 'Ý');
        txt = txt.replace(/&Yacute;/g, 'Ý');

        // "U+000DE", "LATIN CAPITAL LETTER THORN"
        txt = txt.replace(/&#x0*?DE;/g, 'Þ');
        txt = txt.replace(/&#0*?222;/g, 'Þ');
        txt = txt.replace(/&THORN;/g, 'Þ');

        // "U+000DF", "LATIN SMALL LETTER SHARP S"
        txt = txt.replace(/&#x0*?DF;/g, 'ß');
        txt = txt.replace(/&#0*?223;/g, 'ß');
        txt = txt.replace(/&szlig;/g, 'ß');

        // "U+000E0", "LATIN SMALL LETTER A WITH GRAVE"
        txt = txt.replace(/&#x0*?E0;/g, 'à');
        txt = txt.replace(/&#0*?224;/g, 'à');
        txt = txt.replace(/&agrave;/g, 'à');

        // "U+000E1", "LATIN SMALL LETTER A WITH ACUTE"
        txt = txt.replace(/&#x0*?E1;/g, 'á');
        txt = txt.replace(/&#0*?225;/g, 'á');
        txt = txt.replace(/&aacute;/g, 'á');

        // "U+000E2", "LATIN SMALL LETTER A WITH CIRCUMFLEX"
        txt = txt.replace(/&#x0*?E2;/g, 'â');
        txt = txt.replace(/&#0*?226;/g, 'â');
        txt = txt.replace(/&acirc;/g, 'â');

        // "U+000E3", "LATIN SMALL LETTER A WITH TILDE"
        txt = txt.replace(/&#x0*?E3;/g, 'ã');
        txt = txt.replace(/&#0*?227;/g, 'ã');
        txt = txt.replace(/&atilde;/g, 'ã');

        // "U+000E4", "LATIN SMALL LETTER A WITH DIAERESIS"
        txt = txt.replace(/&#x0*?E4;/g, 'ä');
        txt = txt.replace(/&#0*?228;/g, 'ä');
        txt = txt.replace(/&auml;/g, 'ä');

        // "U+000E5", "LATIN SMALL LETTER A WITH RING ABOVE"
        txt = txt.replace(/&#x0*?E5;/g, 'å');
        txt = txt.replace(/&#0*?229;/g, 'å');
        txt = txt.replace(/&aring;/g, 'å');

        // "U+000E6", "LATIN SMALL LETTER AE"
        txt = txt.replace(/&#x0*?E6;/g, 'æ');
        txt = txt.replace(/&#0*?230;/g, 'æ');
        txt = txt.replace(/&aelig;/g, 'æ');

        // "U+000E7", "LATIN SMALL LETTER C WITH CEDILLA"
        txt = txt.replace(/&#x0*?E7;/g, 'ç');
        txt = txt.replace(/&#0*?231;/g, 'ç');
        txt = txt.replace(/&ccedil;/g, 'ç');

        // "U+000E8", "LATIN SMALL LETTER E WITH GRAVE"
        txt = txt.replace(/&#x0*?E8;/g, 'è');
        txt = txt.replace(/&#0*?232;/g, 'è');
        txt = txt.replace(/&egrave;/g, 'è');

        // "U+000E9", "LATIN SMALL LETTER E WITH ACUTE"
        txt = txt.replace(/&#x0*?E9;/g, 'é');
        txt = txt.replace(/&#0*?233;/g, 'é');
        txt = txt.replace(/&eacute;/g, 'é');

        // "U+000EA", "LATIN SMALL LETTER E WITH CIRCUMFLEX"
        txt = txt.replace(/&#x0*?EA;/g, 'ê');
        txt = txt.replace(/&#0*?234;/g, 'ê');
        txt = txt.replace(/&ecirc;/g, 'ê');

        // "U+000EB", "LATIN SMALL LETTER E WITH DIAERESIS"
        txt = txt.replace(/&#x0*?EB;/g, 'ë');
        txt = txt.replace(/&#0*?235;/g, 'ë');
        txt = txt.replace(/&euml;/g, 'ë');

        // "U+000EC", "LATIN SMALL LETTER I WITH GRAVE"
        txt = txt.replace(/&#x0*?EC;/g, 'ì');
        txt = txt.replace(/&#0*?236;/g, 'ì');
        txt = txt.replace(/&igrave;/g, 'ì');

        // "U+000ED", "LATIN SMALL LETTER I WITH ACUTE"
        txt = txt.replace(/&#x0*?ED;/g, 'í');
        txt = txt.replace(/&#0*?237;/g, 'í');
        txt = txt.replace(/&iacute;/g, 'í');

        // "U+000EE", "LATIN SMALL LETTER I WITH CIRCUMFLEX"
        txt = txt.replace(/&#x0*?EE;/g, 'î');
        txt = txt.replace(/&#0*?238;/g, 'î');
        txt = txt.replace(/&icirc;/g, 'î');

        // "U+000EF", "LATIN SMALL LETTER I WITH DIAERESIS"
        txt = txt.replace(/&#x0*?EF;/g, 'ï');
        txt = txt.replace(/&#0*?239;/g, 'ï');
        txt = txt.replace(/&iuml;/g, 'ï');

        // "U+000F0", "LATIN SMALL LETTER ETH"
        txt = txt.replace(/&#x0*?F0;/g, 'ð');
        txt = txt.replace(/&#0*?240;/g, 'ð');
        txt = txt.replace(/&eth;/g, 'ð');

        // "U+000F1", "LATIN SMALL LETTER N WITH TILDE"
        txt = txt.replace(/&#x0*?F1;/g, 'ñ');
        txt = txt.replace(/&#0*?241;/g, 'ñ');
        txt = txt.replace(/&ntilde;/g, 'ñ');

        // "U+000F2", "LATIN SMALL LETTER O WITH GRAVE"
        txt = txt.replace(/&#x0*?F2;/g, 'ò');
        txt = txt.replace(/&#0*?242;/g, 'ò');
        txt = txt.replace(/&ograve;/g, 'ò');

        // "U+000F3", "LATIN SMALL LETTER O WITH ACUTE"
        txt = txt.replace(/&#x0*?F3;/g, 'ó');
        txt = txt.replace(/&#0*?243;/g, 'ó');
        txt = txt.replace(/&oacute;/g, 'ó');

        // "U+000F4", "LATIN SMALL LETTER O WITH CIRCUMFLEX"
        txt = txt.replace(/&#x0*?F4;/g, 'ô');
        txt = txt.replace(/&#0*?244;/g, 'ô');
        txt = txt.replace(/&ocirc;/g, 'ô');

        // "U+000F5", "LATIN SMALL LETTER O WITH TILDE"
        txt = txt.replace(/&#x0*?F5;/g, 'õ');
        txt = txt.replace(/&#0*?245;/g, 'õ');
        txt = txt.replace(/&otilde;/g, 'õ');

        // "U+000F6", "LATIN SMALL LETTER O WITH DIAERESIS"
        txt = txt.replace(/&#x0*?F6;/g, 'ö');
        txt = txt.replace(/&#0*?246;/g, 'ö');
        txt = txt.replace(/&ouml;/g, 'ö');

        // "U+000F7", "DIVISION SIGN"
        txt = txt.replace(/&#x0*?F7;/g, '÷');
        txt = txt.replace(/&#0*?247;/g, '÷');
        txt = txt.replace(/&divide;/g, '÷');
        txt = txt.replace(/&div;/g, '÷');

        // "U+000F8", "LATIN SMALL LETTER O WITH STROKE"
        txt = txt.replace(/&#x0*?F8;/g, 'ø');
        txt = txt.replace(/&#0*?248;/g, 'ø');
        txt = txt.replace(/&oslash;/g, 'ø');

        // "U+000F9", "LATIN SMALL LETTER U WITH GRAVE"
        txt = txt.replace(/&#x0*?F9;/g, 'ù');
        txt = txt.replace(/&#0*?249;/g, 'ù');
        txt = txt.replace(/&ugrave;/g, 'ù');

        // "U+000FA", "LATIN SMALL LETTER U WITH ACUTE"
        txt = txt.replace(/&#x0*?FA;/g, 'ú');
        txt = txt.replace(/&#0*?250;/g, 'ú');
        txt = txt.replace(/&uacute;/g, 'ú');

        // "U+000FB", "LATIN SMALL LETTER U WITH CIRCUMFLEX"
        txt = txt.replace(/&#x0*?FB;/g, 'û');
        txt = txt.replace(/&#0*?251;/g, 'û');
        txt = txt.replace(/&ucirc;/g, 'û');

        // "U+000FC", "LATIN SMALL LETTER U WITH DIAERESIS"
        txt = txt.replace(/&#x0*?FC;/g, 'ü');
        txt = txt.replace(/&#0*?252;/g, 'ü');
        txt = txt.replace(/&uuml;/g, 'ü');

        // "U+000FD", "LATIN SMALL LETTER Y WITH ACUTE"
        txt = txt.replace(/&#x0*?FD;/g, 'ý');
        txt = txt.replace(/&#0*?253;/g, 'ý');
        txt = txt.replace(/&yacute;/g, 'ý');

        // "U+000FE", "LATIN SMALL LETTER THORN"
        txt = txt.replace(/&#x0*?FE;/g, 'þ');
        txt = txt.replace(/&#0*?254;/g, 'þ');
        txt = txt.replace(/&thorn;/g, 'þ');

        // "U+000FF", "LATIN SMALL LETTER Y WITH DIAERESIS"
        txt = txt.replace(/&#x0*?FF;/g, 'ÿ');
        txt = txt.replace(/&#0*?255;/g, 'ÿ');
        txt = txt.replace(/&yuml;/g, 'ÿ');

        // "U+00152", "LATIN CAPITAL LIGATURE OE"
        txt = txt.replace(/&#x0*?152;/g, 'Œ');
        txt = txt.replace(/&#0*?338;/g, 'Œ');
        txt = txt.replace(/&OElig;/g, 'Œ');

        // "U+00153", "LATIN SMALL LIGATURE OE"
        txt = txt.replace(/&#x0*?153;/g, 'œ');
        txt = txt.replace(/&#0*?339;/g, 'œ');
        txt = txt.replace(/&oelig;/g, 'œ');

        // "U+00160", "LATIN CAPITAL LETTER S WITH CARON"
        txt = txt.replace(/&#x0*?160;/g, 'Š');
        txt = txt.replace(/&#0*?352;/g, 'Š');
        txt = txt.replace(/&Scaron;/g, 'Š');

        // "U+00161", "LATIN SMALL LETTER S WITH CARON"
        txt = txt.replace(/&#x0*?161;/g, 'š');
        txt = txt.replace(/&#0*?353;/g, 'š');
        txt = txt.replace(/&scaron;/g, 'š');

        // "U+00178", "LATIN CAPITAL LETTER Y WITH DIAERESIS"
        txt = txt.replace(/&#x0*?178;/g, 'Ÿ');
        txt = txt.replace(/&#0*?376;/g, 'Ÿ');
        txt = txt.replace(/&Yuml;/g, 'Ÿ');

        // "U+00192", "LATIN SMALL LETTER F WITH HOOK"
        txt = txt.replace(/&#x0*?192;/g, 'ƒ');
        txt = txt.replace(/&#0*?402;/g, 'ƒ');
        txt = txt.replace(/&fnof;/g, 'ƒ');

        // "U+002C6", "MODIFIER LETTER CIRCUMFLEX ACCENT"
        txt = txt.replace(/&#x0*?2C6;/g, 'ˆ');
        txt = txt.replace(/&#0*?710;/g, 'ˆ');
        txt = txt.replace(/&circ;/g, 'ˆ');

        // "U+002DC", "SMALL TILDE"
        txt = txt.replace(/&#x0*?2DC;/g, '˜');
        txt = txt.replace(/&#0*?732;/g, '˜');
        txt = txt.replace(/&tilde;/g, '˜');
        txt = txt.replace(/&DiacriticalTilde;/g, '˜');

        // "U+00391", "GREEK CAPITAL LETTER ALPHA"
        txt = txt.replace(/&#x0*?391;/g, 'Α');
        txt = txt.replace(/&#0*?913;/g, 'Α');
        txt = txt.replace(/&Alpha;/g, 'Α');

        // "U+00392", "GREEK CAPITAL LETTER BETA"
        txt = txt.replace(/&#x0*?392;/g, 'Β');
        txt = txt.replace(/&#0*?914;/g, 'Β');
        txt = txt.replace(/&Beta;/g, 'Β');

        // "U+00393", "GREEK CAPITAL LETTER GAMMA"
        txt = txt.replace(/&#x0*?393;/g, 'Γ');
        txt = txt.replace(/&#0*?915;/g, 'Γ');
        txt = txt.replace(/&Gamma;/g, 'Γ');

        // "U+00394", "GREEK CAPITAL LETTER DELTA"
        txt = txt.replace(/&#x0*?394;/g, 'Δ');
        txt = txt.replace(/&#0*?916;/g, 'Δ');
        txt = txt.replace(/&Delta;/g, 'Δ');

        // "U+00395", "GREEK CAPITAL LETTER EPSILON"
        txt = txt.replace(/&#x0*?395;/g, 'Ε');
        txt = txt.replace(/&#0*?917;/g, 'Ε');
        txt = txt.replace(/&Epsilon;/g, 'Ε');

        // "U+00396", "GREEK CAPITAL LETTER ZETA"
        txt = txt.replace(/&#x0*?396;/g, 'Ζ');
        txt = txt.replace(/&#0*?918;/g, 'Ζ');
        txt = txt.replace(/&Zeta;/g, 'Ζ');

        // "U+00397", "GREEK CAPITAL LETTER ETA"
        txt = txt.replace(/&#x0*?397;/g, 'Η');
        txt = txt.replace(/&#0*?919;/g, 'Η');
        txt = txt.replace(/&Eta;/g, 'Η');

        // "U+00398", "GREEK CAPITAL LETTER THETA"
        txt = txt.replace(/&#x0*?398;/g, 'Θ');
        txt = txt.replace(/&#0*?920;/g, 'Θ');
        txt = txt.replace(/&Theta;/g, 'Θ');

        // "U+00399", "GREEK CAPITAL LETTER IOTA"
        txt = txt.replace(/&#x0*?399;/g, 'Ι');
        txt = txt.replace(/&#0*?921;/g, 'Ι');
        txt = txt.replace(/&Iota;/g, 'Ι');

        // "U+0039A", "GREEK CAPITAL LETTER KAPPA"
        txt = txt.replace(/&#x0*?39A;/g, 'Κ');
        txt = txt.replace(/&#0*?922;/g, 'Κ');
        txt = txt.replace(/&Kappa;/g, 'Κ');

        // "U+0039B", "GREEK CAPITAL LETTER LAMDA"
        txt = txt.replace(/&#x0*?39B;/g, 'Λ');
        txt = txt.replace(/&#0*?923;/g, 'Λ');
        txt = txt.replace(/&Lambda;/g, 'Λ');

        // "U+0039C", "GREEK CAPITAL LETTER MU"
        txt = txt.replace(/&#x0*?39C;/g, 'Μ');
        txt = txt.replace(/&#0*?924;/g, 'Μ');
        txt = txt.replace(/&Mu;/g, 'Μ');

        // "U+0039D", "GREEK CAPITAL LETTER NU"
        txt = txt.replace(/&#x0*?39D;/g, 'Ν');
        txt = txt.replace(/&#0*?925;/g, 'Ν');
        txt = txt.replace(/&Nu;/g, 'Ν');

        // "U+0039E", "GREEK CAPITAL LETTER XI"
        txt = txt.replace(/&#x0*?39E;/g, 'Ξ');
        txt = txt.replace(/&#0*?926;/g, 'Ξ');
        txt = txt.replace(/&Xi;/g, 'Ξ');

        // "U+0039F", "GREEK CAPITAL LETTER OMICRON"
        txt = txt.replace(/&#x0*?39F;/g, 'Ο');
        txt = txt.replace(/&#0*?927;/g, 'Ο');
        txt = txt.replace(/&Omicron;/g, 'Ο');

        // "U+003A0", "GREEK CAPITAL LETTER PI"
        txt = txt.replace(/&#x0*?3A0;/g, 'Π');
        txt = txt.replace(/&#0*?928;/g, 'Π');
        txt = txt.replace(/&Pi;/g, 'Π');

        // "U+003A1", "GREEK CAPITAL LETTER RHO"
        txt = txt.replace(/&#x0*?3A1;/g, 'Ρ');
        txt = txt.replace(/&#0*?929;/g, 'Ρ');
        txt = txt.replace(/&Rho;/g, 'Ρ');

        // "U+003A3", "GREEK CAPITAL LETTER SIGMA"
        txt = txt.replace(/&#x0*?3A3;/g, 'Σ');
        txt = txt.replace(/&#0*?931;/g, 'Σ');
        txt = txt.replace(/&Sigma;/g, 'Σ');

        // "U+003A4", "GREEK CAPITAL LETTER TAU"
        txt = txt.replace(/&#x0*?3A4;/g, 'Τ');
        txt = txt.replace(/&#0*?932;/g, 'Τ');
        txt = txt.replace(/&Tau;/g, 'Τ');

        // "U+003A5", "GREEK CAPITAL LETTER UPSILON"
        txt = txt.replace(/&#x0*?3A5;/g, 'Υ');
        txt = txt.replace(/&#0*?933;/g, 'Υ');
        txt = txt.replace(/&Upsilon;/g, 'Υ');

        // "U+003A6", "GREEK CAPITAL LETTER PHI"
        txt = txt.replace(/&#x0*?3A6;/g, 'Φ');
        txt = txt.replace(/&#0*?934;/g, 'Φ');
        txt = txt.replace(/&Phi;/g, 'Φ');

        // "U+003A7", "GREEK CAPITAL LETTER CHI"
        txt = txt.replace(/&#x0*?3A7;/g, 'Χ');
        txt = txt.replace(/&#0*?935;/g, 'Χ');
        txt = txt.replace(/&Chi;/g, 'Χ');

        // "U+003A8", "GREEK CAPITAL LETTER PSI"
        txt = txt.replace(/&#x0*?3A8;/g, 'Ψ');
        txt = txt.replace(/&#0*?936;/g, 'Ψ');
        txt = txt.replace(/&Psi;/g, 'Ψ');

        // "U+003A9", "GREEK CAPITAL LETTER OMEGA"
        txt = txt.replace(/&#x0*?3A9;/g, 'Ω');
        txt = txt.replace(/&#0*?937;/g, 'Ω');
        txt = txt.replace(/&Omega;/g, 'Ω');

        // "U+003B1", "GREEK SMALL LETTER ALPHA"
        txt = txt.replace(/&#x0*?3B1;/g, 'α');
        txt = txt.replace(/&#0*?945;/g, 'α');
        txt = txt.replace(/&alpha;/g, 'α');

        // "U+003B2", "GREEK SMALL LETTER BETA"
        txt = txt.replace(/&#x0*?3B2;/g, 'β');
        txt = txt.replace(/&#0*?946;/g, 'β');
        txt = txt.replace(/&beta;/g, 'β');

        // "U+003B3", "GREEK SMALL LETTER GAMMA"
        txt = txt.replace(/&#x0*?3B3;/g, 'γ');
        txt = txt.replace(/&#0*?947;/g, 'γ');
        txt = txt.replace(/&gamma;/g, 'γ');

        // "U+003B4", "GREEK SMALL LETTER DELTA"
        txt = txt.replace(/&#x0*?3B4;/g, 'δ');
        txt = txt.replace(/&#0*?948;/g, 'δ');
        txt = txt.replace(/&delta;/g, 'δ');

        // "U+003B5", "GREEK SMALL LETTER EPSILON"
        txt = txt.replace(/&#x0*?3B5;/g, 'ε');
        txt = txt.replace(/&#0*?949;/g, 'ε');
        txt = txt.replace(/&epsiv;/g, 'ε');
        txt = txt.replace(/&varepsilon;/g, 'ε');
        txt = txt.replace(/&epsilon;/g, 'ε');

        // "U+003B6", "GREEK SMALL LETTER ZETA"
        txt = txt.replace(/&#x0*?3B6;/g, 'ζ');
        txt = txt.replace(/&#0*?950;/g, 'ζ');
        txt = txt.replace(/&zeta;/g, 'ζ');

        // "U+003B7", "GREEK SMALL LETTER ETA"
        txt = txt.replace(/&#x0*?3B7;/g, 'η');
        txt = txt.replace(/&#0*?951;/g, 'η');
        txt = txt.replace(/&eta;/g, 'η');

        // "U+003B8", "GREEK SMALL LETTER THETA"
        txt = txt.replace(/&#x0*?3B8;/g, 'θ');
        txt = txt.replace(/&#0*?952;/g, 'θ');
        txt = txt.replace(/&theta;/g, 'θ');

        // "U+003B9", "GREEK SMALL LETTER IOTA"
        txt = txt.replace(/&#x0*?3B9;/g, 'ι');
        txt = txt.replace(/&#0*?953;/g, 'ι');
        txt = txt.replace(/&iota;/g, 'ι');

        // "U+003BA", "GREEK SMALL LETTER KAPPA"
        txt = txt.replace(/&#x0*?3BA;/g, 'κ');
        txt = txt.replace(/&#0*?954;/g, 'κ');
        txt = txt.replace(/&kappa;/g, 'κ');

        // "U+003BB", "GREEK SMALL LETTER LAMDA"
        txt = txt.replace(/&#x0*?3BB;/g, 'λ');
        txt = txt.replace(/&#0*?955;/g, 'λ');
        txt = txt.replace(/&lambda;/g, 'λ');

        // "U+003BC", "GREEK SMALL LETTER MU"
        txt = txt.replace(/&#x0*?3BC;/g, 'μ');
        txt = txt.replace(/&#0*?956;/g, 'μ');
        txt = txt.replace(/&mu;/g, 'μ');

        // "U+003BD", "GREEK SMALL LETTER NU"
        txt = txt.replace(/&#x0*?3BD;/g, 'ν');
        txt = txt.replace(/&#0*?957;/g, 'ν');
        txt = txt.replace(/&nu;/g, 'ν');

        // "U+003BE", "GREEK SMALL LETTER XI"
        txt = txt.replace(/&#x0*?3BE;/g, 'ξ');
        txt = txt.replace(/&#0*?958;/g, 'ξ');
        txt = txt.replace(/&xi;/g, 'ξ');

        // "U+003BF", "GREEK SMALL LETTER OMICRON"
        txt = txt.replace(/&#x0*?3BF;/g, 'ο');
        txt = txt.replace(/&#0*?959;/g, 'ο');
        txt = txt.replace(/&omicron;/g, 'ο');

        // "U+003C0", "GREEK SMALL LETTER PI"
        txt = txt.replace(/&#x0*?3C0;/g, 'π');
        txt = txt.replace(/&#0*?960;/g, 'π');
        txt = txt.replace(/&pi;/g, 'π');

        // "U+003C1", "GREEK SMALL LETTER RHO"
        txt = txt.replace(/&#x0*?3C1;/g, 'ρ');
        txt = txt.replace(/&#0*?961;/g, 'ρ');
        txt = txt.replace(/&rho;/g, 'ρ');

        // "U+003C2", "GREEK SMALL LETTER FINAL SIGMA"
        txt = txt.replace(/&#x0*?3C2;/g, 'ς');
        txt = txt.replace(/&#0*?962;/g, 'ς');
        txt = txt.replace(/&sigmav;/g, 'ς');
        txt = txt.replace(/&varsigma;/g, 'ς');
        txt = txt.replace(/&sigmaf;/g, 'ς');

        // "U+003C3", "GREEK SMALL LETTER SIGMA"
        txt = txt.replace(/&#x0*?3C3;/g, 'σ');
        txt = txt.replace(/&#0*?963;/g, 'σ');
        txt = txt.replace(/&sigma;/g, 'σ');

        // "U+003C4", "GREEK SMALL LETTER TAU"
        txt = txt.replace(/&#x0*?3C4;/g, 'τ');
        txt = txt.replace(/&#0*?964;/g, 'τ');
        txt = txt.replace(/&tau;/g, 'τ');

        // "U+003C5", "GREEK SMALL LETTER UPSILON"
        txt = txt.replace(/&#x0*?3C5;/g, 'υ');
        txt = txt.replace(/&#0*?965;/g, 'υ');
        txt = txt.replace(/&upsi;/g, 'υ');
        txt = txt.replace(/&upsilon;/g, 'υ');

        // "U+003C6", "GREEK SMALL LETTER PHI"
        txt = txt.replace(/&#x0*?3C6;/g, 'φ');
        txt = txt.replace(/&#0*?966;/g, 'φ');
        txt = txt.replace(/&phi;/g, 'φ');
        txt = txt.replace(/&phiv;/g, 'φ');
        txt = txt.replace(/&varphi;/g, 'φ');

        // "U+003C7", "GREEK SMALL LETTER CHI"
        txt = txt.replace(/&#x0*?3C7;/g, 'χ');
        txt = txt.replace(/&#0*?967;/g, 'χ');
        txt = txt.replace(/&chi;/g, 'χ');

        // "U+003C8", "GREEK SMALL LETTER PSI"
        txt = txt.replace(/&#x0*?3C8;/g, 'ψ');
        txt = txt.replace(/&#0*?968;/g, 'ψ');
        txt = txt.replace(/&psi;/g, 'ψ');

        // "U+003C9", "GREEK SMALL LETTER OMEGA"
        txt = txt.replace(/&#x0*?3C9;/g, 'ω');
        txt = txt.replace(/&#0*?969;/g, 'ω');
        txt = txt.replace(/&omega;/g, 'ω');

        // "U+003D1", "GREEK THETA SYMBOL"
        txt = txt.replace(/&#x0*?3D1;/g, 'ϑ');
        txt = txt.replace(/&#0*?977;/g, 'ϑ');
        txt = txt.replace(/&thetav;/g, 'ϑ');
        txt = txt.replace(/&vartheta;/g, 'ϑ');
        txt = txt.replace(/&thetasym;/g, 'ϑ');

        // "U+003D2", "GREEK UPSILON WITH HOOK SYMBOL"
        txt = txt.replace(/&#x0*?3D2;/g, 'ϒ');
        txt = txt.replace(/&#0*?978;/g, 'ϒ');
        txt = txt.replace(/&Upsi;/g, 'ϒ');
        txt = txt.replace(/&upsih;/g, 'ϒ');

        // "U+003D6", "GREEK PI SYMBOL"
        txt = txt.replace(/&#x0*?3D6;/g, 'ϖ');
        txt = txt.replace(/&#0*?982;/g, 'ϖ');
        txt = txt.replace(/&piv;/g, 'ϖ');
        txt = txt.replace(/&varpi;/g, 'ϖ');

        // "U+02002", "EN SPACE"
        txt = txt.replace(/&#x0*?2002;/g, ' ');
        txt = txt.replace(/&#0*?8194;/g, ' ');
        txt = txt.replace(/&ensp;/g, ' ');

        // "U+02003", "EM SPACE"
        txt = txt.replace(/&#x0*?2003;/g, ' ');
        txt = txt.replace(/&#0*?8195;/g, ' ');
        txt = txt.replace(/&emsp;/g, ' ');

        // "U+02009", "THIN SPACE"
        txt = txt.replace(/&#x0*?2009;/g, ' ');
        txt = txt.replace(/&#0*?8201;/g, ' ');
        txt = txt.replace(/&thinsp;/g, ' ');
        txt = txt.replace(/&ThinSpace;/g, ' ');

        // "U+0200C", "ZERO WIDTH NON-JOINER"
        txt = txt.replace(/&#x0*?200C;/g, '‌');
        txt = txt.replace(/&#0*?8204;/g, '‌');
        txt = txt.replace(/&zwnj;/g, '‌');

        // "U+0200D", "ZERO WIDTH JOINER"
        txt = txt.replace(/&#x0*?200D;/g, '‍');
        txt = txt.replace(/&#0*?8205;/g, '‍');
        txt = txt.replace(/&zwj;/g, '‍');

        // "U+0200E", "LEFT-TO-RIGHT MARK"
        txt = txt.replace(/&#x0*?200E;/g, '‎');
        txt = txt.replace(/&#0*?8206;/g, '‎');
        txt = txt.replace(/&lrm;/g, '‎');

        // "U+0200F", "RIGHT-TO-LEFT MARK"
        txt = txt.replace(/&#x0*?200F;/g, '‏');
        txt = txt.replace(/&#0*?8207;/g, '‏');
        txt = txt.replace(/&rlm;/g, '‏');

        // "U+02013", "EN DASH"
        txt = txt.replace(/&#x0*?2013;/g, '–');
        txt = txt.replace(/&#0*?8211;/g, '–');
        txt = txt.replace(/&ndash;/g, '–');

        // "U+02014", "EM DASH"
        txt = txt.replace(/&#x0*?2014;/g, '—');
        txt = txt.replace(/&#0*?8212;/g, '—');
        txt = txt.replace(/&mdash;/g, '—');

        // "U+02018", "LEFT SINGLE QUOTATION MARK"
        txt = txt.replace(/&#x0*?2018;/g, '‘');
        txt = txt.replace(/&#0*?8216;/g, '‘');
        txt = txt.replace(/&lsquo;/g, '‘');
        txt = txt.replace(/&OpenCurlyQuote;/g, '‘');

        // "U+02019", "RIGHT SINGLE QUOTATION MARK"
        txt = txt.replace(/&#x0*?2019;/g, '’');
        txt = txt.replace(/&#0*?8217;/g, '’');
        txt = txt.replace(/&rsquo;/g, '’');
        txt = txt.replace(/&rsquor;/g, '’');
        txt = txt.replace(/&CloseCurlyQuote;/g, '’');

        // "U+0201A", "SINGLE LOW-9 QUOTATION MARK"
        txt = txt.replace(/&#x0*?201A;/g, '‚');
        txt = txt.replace(/&#0*?8218;/g, '‚');
        txt = txt.replace(/&lsquor;/g, '‚');
        txt = txt.replace(/&sbquo;/g, '‚');

        // "U+0201C", "LEFT DOUBLE QUOTATION MARK"
        txt = txt.replace(/&#x0*?201C;/g, '“');
        txt = txt.replace(/&#0*?8220;/g, '“');
        txt = txt.replace(/&ldquo;/g, '“');
        txt = txt.replace(/&OpenCurlyDoubleQuote;/g, '“');

        // "U+0201D", "RIGHT DOUBLE QUOTATION MARK"
        txt = txt.replace(/&#x0*?201D;/g, '”');
        txt = txt.replace(/&#0*?8221;/g, '”');
        txt = txt.replace(/&rdquo;/g, '”');
        txt = txt.replace(/&rdquor;/g, '”');
        txt = txt.replace(/&CloseCurlyDoubleQuote;/g, '”');

        // "U+0201E", "DOUBLE LOW-9 QUOTATION MARK"
        txt = txt.replace(/&#x0*?201E;/g, '„');
        txt = txt.replace(/&#0*?8222;/g, '„');
        txt = txt.replace(/&ldquor;/g, '„');
        txt = txt.replace(/&bdquo;/g, '„');

        // "U+02020", "DAGGER"
        txt = txt.replace(/&#x0*?2020;/g, '†');
        txt = txt.replace(/&#0*?8224;/g, '†');
        txt = txt.replace(/&dagger;/g, '†');

        // "U+02021", "DOUBLE DAGGER"
        txt = txt.replace(/&#x0*?2021;/g, '‡');
        txt = txt.replace(/&#0*?8225;/g, '‡');
        txt = txt.replace(/&Dagger;/g, '‡');
        txt = txt.replace(/&ddagger;/g, '‡');

        // "U+02022", "BULLET"
        txt = txt.replace(/&#x0*?2022;/g, '•');
        txt = txt.replace(/&#0*?8226;/g, '•');
        txt = txt.replace(/&bull;/g, '•');
        txt = txt.replace(/&bullet;/g, '•');

        // "U+02026", "HORIZONTAL ELLIPSIS"
        txt = txt.replace(/&#x0*?2026;/g, '…');
        txt = txt.replace(/&#0*?8230;/g, '…');
        txt = txt.replace(/&hellip;/g, '…');
        txt = txt.replace(/&mldr;/g, '…');

        // "U+02030", "PER MILLE SIGN"
        txt = txt.replace(/&#x0*?2030;/g, '‰');
        txt = txt.replace(/&#0*?8240;/g, '‰');
        txt = txt.replace(/&permil;/g, '‰');

        // "U+02032", "PRIME"
        txt = txt.replace(/&#x0*?2032;/g, '′');
        txt = txt.replace(/&#0*?8242;/g, '′');
        txt = txt.replace(/&prime;/g, '′');

        // "U+02033", "DOUBLE PRIME"
        txt = txt.replace(/&#x0*?2033;/g, '″');
        txt = txt.replace(/&#0*?8243;/g, '″');
        txt = txt.replace(/&Prime;/g, '″');

        // "U+02039", "SINGLE LEFT-POINTING ANGLE QUOTATION MARK"
        txt = txt.replace(/&#x0*?2039;/g, '‹');
        txt = txt.replace(/&#0*?8249;/g, '‹');
        txt = txt.replace(/&lsaquo;/g, '‹');

        // "U+0203A", "SINGLE RIGHT-POINTING ANGLE QUOTATION MARK"
        txt = txt.replace(/&#x0*?203A;/g, '›');
        txt = txt.replace(/&#0*?8250;/g, '›');
        txt = txt.replace(/&rsaquo;/g, '›');

        // "U+0203E", "OVERLINE"
        txt = txt.replace(/&#x0*?203E;/g, '‾');
        txt = txt.replace(/&#0*?8254;/g, '‾');
        txt = txt.replace(/&oline;/g, '‾');

        // "U+02044", "FRACTION SLASH"
        txt = txt.replace(/&#x0*?2044;/g, '⁄');
        txt = txt.replace(/&#0*?8260;/g, '⁄');
        txt = txt.replace(/&frasl;/g, '⁄');

        // "U+020AC", "EURO SIGN"
        txt = txt.replace(/&#x0*?20AC;/g, '€');
        txt = txt.replace(/&#0*?8364;/g, '€');
        txt = txt.replace(/&euro;/g, '€');

        // "U+02111", "BLACK-LETTER CAPITAL I"
        txt = txt.replace(/&#x0*?2111;/g, 'ℑ');
        txt = txt.replace(/&#0*?8465;/g, 'ℑ');
        txt = txt.replace(/&image;/g, 'ℑ');
        txt = txt.replace(/&Im;/g, 'ℑ');
        txt = txt.replace(/&imagpart;/g, 'ℑ');
        txt = txt.replace(/&Ifr;/g, 'ℑ');

        // "U+02118", "SCRIPT CAPITAL P"
        txt = txt.replace(/&#x0*?2118;/g, '℘');
        txt = txt.replace(/&#0*?8472;/g, '℘');
        txt = txt.replace(/&weierp;/g, '℘');
        txt = txt.replace(/&wp;/g, '℘');

        // "U+0211C", "BLACK-LETTER CAPITAL R"
        txt = txt.replace(/&#x0*?211C;/g, 'ℜ');
        txt = txt.replace(/&#0*?8476;/g, 'ℜ');
        txt = txt.replace(/&real;/g, 'ℜ');
        txt = txt.replace(/&Re;/g, 'ℜ');
        txt = txt.replace(/&realpart;/g, 'ℜ');
        txt = txt.replace(/&Rfr;/g, 'ℜ');

        // "U+02122", "TRADE MARK SIGN"
        txt = txt.replace(/&#x0*?2122;/g, '™');
        txt = txt.replace(/&#0*?8482;/g, '™');
        txt = txt.replace(/&trade;/g, '™');
        txt = txt.replace(/&TRADE;/g, '™');

        // "U+02135", "ALEF SYMBOL"
        txt = txt.replace(/&#x0*?2135;/g, 'ℵ');
        txt = txt.replace(/&#0*?8501;/g, 'ℵ');
        txt = txt.replace(/&alefsym;/g, 'ℵ');
        txt = txt.replace(/&aleph;/g, 'ℵ');

        // "U+02190", "LEFTWARDS ARROW"
        txt = txt.replace(/&#x0*?2190;/g, '←');
        txt = txt.replace(/&#0*?8592;/g, '←');
        txt = txt.replace(/&larr;/g, '←');
        txt = txt.replace(/&leftarrow;/g, '←');
        txt = txt.replace(/&LeftArrow;/g, '←');
        txt = txt.replace(/&slarr;/g, '←');
        txt = txt.replace(/&ShortLeftArrow;/g, '←');

        // "U+02191", "UPWARDS ARROW"
        txt = txt.replace(/&#x0*?2191;/g, '↑');
        txt = txt.replace(/&#0*?8593;/g, '↑');
        txt = txt.replace(/&uarr;/g, '↑');
        txt = txt.replace(/&uparrow;/g, '↑');
        txt = txt.replace(/&UpArrow;/g, '↑');
        txt = txt.replace(/&ShortUpArrow;/g, '↑');

        // "U+02192", "RIGHTWARDS ARROW"
        txt = txt.replace(/&#x0*?2192;/g, '→');
        txt = txt.replace(/&#0*?8594;/g, '→');
        txt = txt.replace(/&rarr;/g, '→');
        txt = txt.replace(/&rightarrow;/g, '→');
        txt = txt.replace(/&RightArrow;/g, '→');
        txt = txt.replace(/&srarr;/g, '→');
        txt = txt.replace(/&ShortRightArrow;/g, '→');

        // "U+02193", "DOWNWARDS ARROW"
        txt = txt.replace(/&#x0*?2193;/g, '↓');
        txt = txt.replace(/&#0*?8595;/g, '↓');
        txt = txt.replace(/&darr;/g, '↓');
        txt = txt.replace(/&downarrow;/g, '↓');
        txt = txt.replace(/&DownArrow;/g, '↓');
        txt = txt.replace(/&ShortDownArrow;/g, '↓');

        // "U+02194", "LEFT RIGHT ARROW"
        txt = txt.replace(/&#x0*?2194;/g, '↔');
        txt = txt.replace(/&#0*?8596;/g, '↔');
        txt = txt.replace(/&harr;/g, '↔');
        txt = txt.replace(/&leftrightarrow;/g, '↔');
        txt = txt.replace(/&LeftRightArrow;/g, '↔');

        // "U+021B5", "DOWNWARDS ARROW WITH CORNER LEFTWARDS"
        txt = txt.replace(/&#x0*?21B5;/g, '↵');
        txt = txt.replace(/&#0*?8629;/g, '↵');
        txt = txt.replace(/&crarr;/g, '↵');

        // "U+021D0", "LEFTWARDS DOUBLE ARROW"
        txt = txt.replace(/&#x0*?21D0;/g, '⇐');
        txt = txt.replace(/&#0*?8656;/g, '⇐');
        txt = txt.replace(/&lArr;/g, '⇐');
        txt = txt.replace(/&Leftarrow;/g, '⇐');
        txt = txt.replace(/&DoubleLeftArrow;/g, '⇐');

        // "U+021D1", "UPWARDS DOUBLE ARROW"
        txt = txt.replace(/&#x0*?21D1;/g, '⇑');
        txt = txt.replace(/&#0*?8657;/g, '⇑');
        txt = txt.replace(/&uArr;/g, '⇑');
        txt = txt.replace(/&Uparrow;/g, '⇑');
        txt = txt.replace(/&DoubleUpArrow;/g, '⇑');

        // "U+021D2", "RIGHTWARDS DOUBLE ARROW"
        txt = txt.replace(/&#x0*?21D2;/g, '⇒');
        txt = txt.replace(/&#0*?8658;/g, '⇒');
        txt = txt.replace(/&rArr;/g, '⇒');
        txt = txt.replace(/&Rightarrow;/g, '⇒');
        txt = txt.replace(/&Implies;/g, '⇒');
        txt = txt.replace(/&DoubleRightArrow;/g, '⇒');

        // "U+021D3", "DOWNWARDS DOUBLE ARROW"
        txt = txt.replace(/&#x0*?21D3;/g, '⇓');
        txt = txt.replace(/&#0*?8659;/g, '⇓');
        txt = txt.replace(/&dArr;/g, '⇓');
        txt = txt.replace(/&Downarrow;/g, '⇓');
        txt = txt.replace(/&DoubleDownArrow;/g, '⇓');

        // "U+021D4", "LEFT RIGHT DOUBLE ARROW"
        txt = txt.replace(/&#x0*?21D4;/g, '⇔');
        txt = txt.replace(/&#0*?8660;/g, '⇔');
        txt = txt.replace(/&hArr;/g, '⇔');
        txt = txt.replace(/&Leftrightarrow;/g, '⇔');
        txt = txt.replace(/&DoubleLeftRightArrow;/g, '⇔');
        txt = txt.replace(/&iff;/g, '⇔');

        // "U+02200", "FOR ALL"
        txt = txt.replace(/&#x0*?2200;/g, '∀');
        txt = txt.replace(/&#0*?8704;/g, '∀');
        txt = txt.replace(/&forall;/g, '∀');
        txt = txt.replace(/&ForAll;/g, '∀');

        // "U+02202", "PARTIAL DIFFERENTIAL"
        txt = txt.replace(/&#x0*?2202;/g, '∂');
        txt = txt.replace(/&#0*?8706;/g, '∂');
        txt = txt.replace(/&part;/g, '∂');
        txt = txt.replace(/&PartialD;/g, '∂');

        // "U+02203", "THERE EXISTS"
        txt = txt.replace(/&#x0*?2203;/g, '∃');
        txt = txt.replace(/&#0*?8707;/g, '∃');
        txt = txt.replace(/&exist;/g, '∃');
        txt = txt.replace(/&Exists;/g, '∃');

        // "U+02205", "EMPTY SET"
        txt = txt.replace(/&#x0*?2205;/g, '∅');
        txt = txt.replace(/&#0*?8709;/g, '∅');
        txt = txt.replace(/&empty;/g, '∅');
        txt = txt.replace(/&emptyset;/g, '∅');
        txt = txt.replace(/&emptyv;/g, '∅');
        txt = txt.replace(/&varnothing;/g, '∅');

        // "U+02207", "NABLA"
        txt = txt.replace(/&#x0*?2207;/g, '∇');
        txt = txt.replace(/&#0*?8711;/g, '∇');
        txt = txt.replace(/&nabla;/g, '∇');
        txt = txt.replace(/&Del;/g, '∇');

        // "U+02208", "ELEMENT OF"
        txt = txt.replace(/&#x0*?2208;/g, '∈');
        txt = txt.replace(/&#0*?8712;/g, '∈');
        txt = txt.replace(/&isin;/g, '∈');
        txt = txt.replace(/&isinv;/g, '∈');
        txt = txt.replace(/&Element;/g, '∈');
        txt = txt.replace(/&in;/g, '∈');

        // "U+02209", "NOT AN ELEMENT OF"
        txt = txt.replace(/&#x0*?2209;/g, '∉');
        txt = txt.replace(/&#0*?8713;/g, '∉');
        txt = txt.replace(/&notin;/g, '∉');
        txt = txt.replace(/&NotElement;/g, '∉');
        txt = txt.replace(/&notinva;/g, '∉');

        // "U+0220B", "CONTAINS AS MEMBER"
        txt = txt.replace(/&#x0*?220B;/g, '∋');
        txt = txt.replace(/&#0*?8715;/g, '∋');
        txt = txt.replace(/&niv;/g, '∋');
        txt = txt.replace(/&ReverseElement;/g, '∋');
        txt = txt.replace(/&ni;/g, '∋');
        txt = txt.replace(/&SuchThat;/g, '∋');

        // "U+0220F", "N-ARY PRODUCT"
        txt = txt.replace(/&#x0*?220F;/g, '∏');
        txt = txt.replace(/&#0*?8719;/g, '∏');
        txt = txt.replace(/&prod;/g, '∏');
        txt = txt.replace(/&Product;/g, '∏');

        // "U+02211", "N-ARY SUMMATION"
        txt = txt.replace(/&#x0*?2211;/g, '∑');
        txt = txt.replace(/&#0*?8721;/g, '∑');
        txt = txt.replace(/&sum;/g, '∑');
        txt = txt.replace(/&Sum;/g, '∑');

        // "U+02212", "MINUS SIGN"
        txt = txt.replace(/&#x0*?2212;/g, '−');
        txt = txt.replace(/&#0*?8722;/g, '−');
        txt = txt.replace(/&minus;/g, '−');

        // "U+02217", "ASTERISK OPERATOR"
        txt = txt.replace(/&#x0*?2217;/g, '∗');
        txt = txt.replace(/&#0*?8727;/g, '∗');
        txt = txt.replace(/&lowast;/g, '∗');

        // "U+0221A", "SQUARE ROOT"
        txt = txt.replace(/&#x0*?221A;/g, '√');
        txt = txt.replace(/&#0*?8730;/g, '√');
        txt = txt.replace(/&radic;/g, '√');
        txt = txt.replace(/&Sqrt;/g, '√');

        // "U+0221D", "PROPORTIONAL TO"
        txt = txt.replace(/&#x0*?221D;/g, '∝');
        txt = txt.replace(/&#0*?8733;/g, '∝');
        txt = txt.replace(/&prop;/g, '∝');
        txt = txt.replace(/&propto;/g, '∝');
        txt = txt.replace(/&Proportional;/g, '∝');
        txt = txt.replace(/&vprop;/g, '∝');
        txt = txt.replace(/&varpropto;/g, '∝');

        // "U+0221E", "INFINITY"
        txt = txt.replace(/&#x0*?221E;/g, '∞');
        txt = txt.replace(/&#0*?8734;/g, '∞');
        txt = txt.replace(/&infin;/g, '∞');

        // "U+02220", "ANGLE"
        txt = txt.replace(/&#x0*?2220;/g, '∠');
        txt = txt.replace(/&#0*?8736;/g, '∠');
        txt = txt.replace(/&ang;/g, '∠');
        txt = txt.replace(/&angle;/g, '∠');

        // "U+02227", "LOGICAL AND"
        txt = txt.replace(/&#x0*?2227;/g, '∧');
        txt = txt.replace(/&#0*?8743;/g, '∧');
        txt = txt.replace(/&and;/g, '∧');
        txt = txt.replace(/&wedge;/g, '∧');

        // "U+02228", "LOGICAL OR"
        txt = txt.replace(/&#x0*?2228;/g, '∨');
        txt = txt.replace(/&#0*?8744;/g, '∨');
        txt = txt.replace(/&or;/g, '∨');
        txt = txt.replace(/&vee;/g, '∨');

        // "U+02229", "INTERSECTION"
        txt = txt.replace(/&#x0*?2229;/g, '∩');
        txt = txt.replace(/&#0*?8745;/g, '∩');
        txt = txt.replace(/&cap;/g, '∩');

        // "U+0222A", "UNION"
        txt = txt.replace(/&#x0*?222A;/g, '∪');
        txt = txt.replace(/&#0*?8746;/g, '∪');
        txt = txt.replace(/&cup;/g, '∪');

        // "U+0222B", "INTEGRAL"
        txt = txt.replace(/&#x0*?222B;/g, '∫');
        txt = txt.replace(/&#0*?8747;/g, '∫');
        txt = txt.replace(/&int;/g, '∫');
        txt = txt.replace(/&Integral;/g, '∫');

        // "U+02234", "THEREFORE"
        txt = txt.replace(/&#x0*?2234;/g, '∴');
        txt = txt.replace(/&#0*?8756;/g, '∴');
        txt = txt.replace(/&there4;/g, '∴');
        txt = txt.replace(/&therefore;/g, '∴');
        txt = txt.replace(/&Therefore;/g, '∴');

        // "U+0223C", "TILDE OPERATOR"
        txt = txt.replace(/&#x0*?223C;/g, '∼');
        txt = txt.replace(/&#0*?8764;/g, '∼');
        txt = txt.replace(/&sim;/g, '∼');
        txt = txt.replace(/&Tilde;/g, '∼');
        txt = txt.replace(/&thksim;/g, '∼');
        txt = txt.replace(/&thicksim;/g, '∼');

        // "U+02245", "APPROXIMATELY EQUAL TO"
        txt = txt.replace(/&#x0*?2245;/g, '≅');
        txt = txt.replace(/&#0*?8773;/g, '≅');
        txt = txt.replace(/&cong;/g, '≅');
        txt = txt.replace(/&TildeFullEqual;/g, '≅');

        // "U+02248", "ALMOST EQUAL TO"
        txt = txt.replace(/&#x0*?2248;/g, '≈');
        txt = txt.replace(/&#0*?8776;/g, '≈');
        txt = txt.replace(/&asymp;/g, '≈');
        txt = txt.replace(/&ap;/g, '≈');
        txt = txt.replace(/&TildeTilde;/g, '≈');
        txt = txt.replace(/&approx;/g, '≈');
        txt = txt.replace(/&thkap;/g, '≈');
        txt = txt.replace(/&thickapprox;/g, '≈');

        // "U+02260", "NOT EQUAL TO"
        txt = txt.replace(/&#x0*?2260;/g, '≠');
        txt = txt.replace(/&#0*?8800;/g, '≠');
        txt = txt.replace(/&ne;/g, '≠');
        txt = txt.replace(/&NotEqual;/g, '≠');

        // "U+02261", "IDENTICAL TO"
        txt = txt.replace(/&#x0*?2261;/g, '≡');
        txt = txt.replace(/&#0*?8801;/g, '≡');
        txt = txt.replace(/&equiv;/g, '≡');
        txt = txt.replace(/&Congruent;/g, '≡');

        // "U+02264", "LESS-THAN OR EQUAL TO"
        txt = txt.replace(/&#x0*?2264;/g, '≤');
        txt = txt.replace(/&#0*?8804;/g, '≤');
        txt = txt.replace(/&le;/g, '≤');
        txt = txt.replace(/&leq;/g, '≤');

        // "U+02265", "GREATER-THAN OR EQUAL TO"
        txt = txt.replace(/&#x0*?2265;/g, '≥');
        txt = txt.replace(/&#0*?8805;/g, '≥');
        txt = txt.replace(/&ge;/g, '≥');
        txt = txt.replace(/&GreaterEqual;/g, '≥');
        txt = txt.replace(/&geq;/g, '≥');

        // "U+02282", "SUBSET OF"
        txt = txt.replace(/&#x0*?2282;/g, '⊂');
        txt = txt.replace(/&#0*?8834;/g, '⊂');
        txt = txt.replace(/&sub;/g, '⊂');
        txt = txt.replace(/&subset;/g, '⊂');

        // "U+02283", "SUPERSET OF"
        txt = txt.replace(/&#x0*?2283;/g, '⊃');
        txt = txt.replace(/&#0*?8835;/g, '⊃');
        txt = txt.replace(/&sup;/g, '⊃');
        txt = txt.replace(/&supset;/g, '⊃');
        txt = txt.replace(/&Superset;/g, '⊃');

        // "U+02284", "NOT A SUBSET OF"
        txt = txt.replace(/&#x0*?2284;/g, '⊄');
        txt = txt.replace(/&#0*?8836;/g, '⊄');
        txt = txt.replace(/&nsub;/g, '⊄');

        // "U+02286", "SUBSET OF OR EQUAL TO"
        txt = txt.replace(/&#x0*?2286;/g, '⊆');
        txt = txt.replace(/&#0*?8838;/g, '⊆');
        txt = txt.replace(/&sube;/g, '⊆');
        txt = txt.replace(/&SubsetEqual;/g, '⊆');
        txt = txt.replace(/&subseteq;/g, '⊆');

        // "U+02287", "SUPERSET OF OR EQUAL TO"
        txt = txt.replace(/&#x0*?2287;/g, '⊇');
        txt = txt.replace(/&#0*?8839;/g, '⊇');
        txt = txt.replace(/&supe;/g, '⊇');
        txt = txt.replace(/&supseteq;/g, '⊇');
        txt = txt.replace(/&SupersetEqual;/g, '⊇');

        // "U+02295", "CIRCLED PLUS"
        txt = txt.replace(/&#x0*?2295;/g, '⊕');
        txt = txt.replace(/&#0*?8853;/g, '⊕');
        txt = txt.replace(/&oplus;/g, '⊕');
        txt = txt.replace(/&CirclePlus;/g, '⊕');

        // "U+02297", "CIRCLED TIMES"
        txt = txt.replace(/&#x0*?2297;/g, '⊗');
        txt = txt.replace(/&#0*?8855;/g, '⊗');
        txt = txt.replace(/&otimes;/g, '⊗');
        txt = txt.replace(/&CircleTimes;/g, '⊗');

        // "U+022A5", "UP TACK"
        txt = txt.replace(/&#x0*?22A5;/g, '⊥');
        txt = txt.replace(/&#0*?8869;/g, '⊥');
        txt = txt.replace(/&bottom;/g, '⊥');
        txt = txt.replace(/&bot;/g, '⊥');
        txt = txt.replace(/&perp;/g, '⊥');
        txt = txt.replace(/&UpTee;/g, '⊥');

        // "U+022C5", "DOT OPERATOR"
        txt = txt.replace(/&#x0*?22C5;/g, '⋅');
        txt = txt.replace(/&#0*?8901;/g, '⋅');
        txt = txt.replace(/&sdot;/g, '⋅');

        // "U+02308", "LEFT CEILING"
        txt = txt.replace(/&#x0*?2308;/g, '⌈');
        txt = txt.replace(/&#0*?8968;/g, '⌈');
        txt = txt.replace(/&lceil;/g, '⌈');
        txt = txt.replace(/&LeftCeiling;/g, '⌈');

        // "U+02309", "RIGHT CEILING"
        txt = txt.replace(/&#x0*?2309;/g, '⌉');
        txt = txt.replace(/&#0*?8969;/g, '⌉');
        txt = txt.replace(/&rceil;/g, '⌉');
        txt = txt.replace(/&RightCeiling;/g, '⌉');

        // "U+0230A", "LEFT FLOOR"
        txt = txt.replace(/&#x0*?230A;/g, '⌊');
        txt = txt.replace(/&#0*?8970;/g, '⌊');
        txt = txt.replace(/&lfloor;/g, '⌊');
        txt = txt.replace(/&LeftFloor;/g, '⌊');

        // "U+0230B", "RIGHT FLOOR"
        txt = txt.replace(/&#x0*?230B;/g, '⌋');
        txt = txt.replace(/&#0*?8971;/g, '⌋');
        txt = txt.replace(/&rfloor;/g, '⌋');
        txt = txt.replace(/&RightFloor;/g, '⌋');

        // "U+025CA", "LOZENGE"
        txt = txt.replace(/&#x0*?25CA;/g, '◊');
        txt = txt.replace(/&#0*?9674;/g, '◊');
        txt = txt.replace(/&loz;/g, '◊');
        txt = txt.replace(/&lozenge;/g, '◊');

        // "U+02660", "BLACK SPADE SUIT"
        txt = txt.replace(/&#x0*?2660;/g, '♠');
        txt = txt.replace(/&#0*?9824;/g, '♠');
        txt = txt.replace(/&spades;/g, '♠');
        txt = txt.replace(/&spadesuit;/g, '♠');

        // "U+02663", "BLACK CLUB SUIT"
        txt = txt.replace(/&#x0*?2663;/g, '♣');
        txt = txt.replace(/&#0*?9827;/g, '♣');
        txt = txt.replace(/&clubs;/g, '♣');
        txt = txt.replace(/&clubsuit;/g, '♣');

        // "U+02665", "BLACK HEART SUIT"
        txt = txt.replace(/&#x0*?2665;/g, '♥');
        txt = txt.replace(/&#0*?9829;/g, '♥');
        txt = txt.replace(/&hearts;/g, '♥');
        txt = txt.replace(/&heartsuit;/g, '♥');

        // "U+02666", "BLACK DIAMOND SUIT"
        txt = txt.replace(/&#x0*?2666;/g, '♦');
        txt = txt.replace(/&#0*?9830;/g, '♦');
        txt = txt.replace(/&diams;/g, '♦');
        txt = txt.replace(/&diamondsuit;/g, '♦');

        // "U+027E8", "MATHEMATICAL LEFT ANGLE BRACKET"
        txt = txt.replace(/&#x0*?27E8;/g, '⟨');
        txt = txt.replace(/&#0*?10216;/g, '⟨');
        txt = txt.replace(/&lang;/g, '⟨');
        txt = txt.replace(/&LeftAngleBracket;/g, '⟨');
        txt = txt.replace(/&langle;/g, '⟨');

        // "U+027E9", "MATHEMATICAL RIGHT ANGLE BRACKET"
        txt = txt.replace(/&#x0*?27E9;/g, '⟩');
        txt = txt.replace(/&#0*?10217;/g, '⟩');
        txt = txt.replace(/&rang;/g, '⟩');
        txt = txt.replace(/&RightAngleBracket;/g, '⟩');
        txt = txt.replace(/&rangle;/g, '⟩');

        return txt;
    }

    /**
     * 入力される文字列内の文字実体参照を文字や記号に置きかえます。ベーシック版です。
     * @param sources 置きかえられる文字列の配列。
     * @returns 置きかえられた文字列の配列。
     */
    public static convertFromCharacterEntityReferenceAllBasic(sources: string[]): string[] {
        for (let i = 0; i < sources.length; i++) {
            sources[i] = this.convertFromCharacterEntityReferenceBasic(sources[i]);
        }

        return sources;
    }

    /**
     * 入力される文字列内の文字実体参照を文字や記号に置きかえます。
     * @param source 置きかえられる文字列。
     * @returns 置きかえられた文字列。
     */
    public static convertFromCharacterEntityReference(source: string): string {
        let txt = source;

        // "U+00009", "CHARACTER TABULATION"
        txt = txt.replace(/&#x0*?9;/g, '\t');
        txt = txt.replace(/&#0*?9;/g, '\t');
        txt = txt.replace(/&Tab;/g, '\t');

        // "U+0000A", "LINE FEED (LF)"
        txt = txt.replace(/&#x0*?A;/g, '\n');
        txt = txt.replace(/&#0*?10;/g, '\n');
        txt = txt.replace(/&NewLine;/g, '\n');

        // "U+00021", "EXCLAMATION MARK"
        txt = txt.replace(/&#x0*?21;/g, '!');
        txt = txt.replace(/&#0*?33;/g, '!');
        txt = txt.replace(/&excl;/g, '!');

        // "U+00022", "QUOTATION MARK"
        txt = txt.replace(/&#x0*?22;/g, '"');
        txt = txt.replace(/&#0*?34;/g, '"');
        txt = txt.replace(/&quot;/g, '"');
        txt = txt.replace(/&QUOT;/g, '"');

        // "U+00023", "NUMBER SIGN"
        txt = txt.replace(/&#x0*?23;/g, '#');
        txt = txt.replace(/&#0*?35;/g, '#');
        txt = txt.replace(/&num;/g, '#');

        // "U+00024", "DOLLAR SIGN"
        txt = txt.replace(/&#x0*?24;/g, '$');
        txt = txt.replace(/&#0*?36;/g, '$');
        txt = txt.replace(/&dollar;/g, '$');

        // "U+00025", "PERCENT SIGN"
        txt = txt.replace(/&#x0*?25;/g, '%');
        txt = txt.replace(/&#0*?37;/g, '%');
        txt = txt.replace(/&percnt;/g, '%');

        // "U+00026", "AMPERSAND"
        txt = txt.replace(/&#x0*?26;/g, '&');
        txt = txt.replace(/&#0*?38;/g, '&');
        txt = txt.replace(/&amp;/g, '&');
        txt = txt.replace(/&AMP;/g, '&');

        // "U+00027", "APOSTROPHE"
        txt = txt.replace(/&#x0*?27;/g, "'");
        txt = txt.replace(/&#0*?39;/g, "'");
        txt = txt.replace(/&apos;/g, "'");

        // "U+00028", "LEFT PARENTHESIS"
        txt = txt.replace(/&#x0*?28;/g, '(');
        txt = txt.replace(/&#0*?40;/g, '(');
        txt = txt.replace(/&lpar;/g, '(');

        // "U+00029", "RIGHT PARENTHESIS"
        txt = txt.replace(/&#x0*?29;/g, ')');
        txt = txt.replace(/&#0*?41;/g, ')');
        txt = txt.replace(/&rpar;/g, ')');

        // "U+0002A", "ASTERISK"
        txt = txt.replace(/&#x0*?2A;/g, '*');
        txt = txt.replace(/&#0*?42;/g, '*');
        txt = txt.replace(/&ast;/g, '*');
        txt = txt.replace(/&midast;/g, '*');

        // "U+0002B", "PLUS SIGN"
        txt = txt.replace(/&#x0*?2B;/g, '+');
        txt = txt.replace(/&#0*?43;/g, '+');
        txt = txt.replace(/&plus;/g, '+');

        // "U+0002C", "COMMA"
        txt = txt.replace(/&#x0*?2C;/g, ',');
        txt = txt.replace(/&#0*?44;/g, ',');
        txt = txt.replace(/&comma;/g, ',');

        // "U+0002E", "FULL STOP"
        txt = txt.replace(/&#x0*?2E;/g, '.');
        txt = txt.replace(/&#0*?46;/g, '.');
        txt = txt.replace(/&period;/g, '.');

        // "U+0002F", "SOLIDUS"
        txt = txt.replace(/&#x0*?2F;/g, '/');
        txt = txt.replace(/&#0*?47;/g, '/');
        txt = txt.replace(/&sol;/g, '/');

        // "U+0003A", "COLON"
        txt = txt.replace(/&#x0*?3A;/g, ':');
        txt = txt.replace(/&#0*?58;/g, ':');
        txt = txt.replace(/&colon;/g, ':');

        // "U+0003B", "SEMICOLON"
        txt = txt.replace(/&#x0*?3B;/g, ';');
        txt = txt.replace(/&#0*?59;/g, ';');
        txt = txt.replace(/&semi;/g, ';');

        // "U+0003C", "LESS-THAN SIGN"
        txt = txt.replace(/&#x0*?3C;/g, '<');
        txt = txt.replace(/&#0*?60;/g, '<');
        txt = txt.replace(/&lt;/g, '<');
        txt = txt.replace(/&LT;/g, '<');

        // "U+0003D", "EQUALS SIGN"
        txt = txt.replace(/&#x0*?3D;/g, '=');
        txt = txt.replace(/&#0*?61;/g, '=');
        txt = txt.replace(/&equals;/g, '=');

        // "U+0003E", "GREATER-THAN SIGN"
        txt = txt.replace(/&#x0*?3E;/g, '>');
        txt = txt.replace(/&#0*?62;/g, '>');
        txt = txt.replace(/&gt;/g, '>');
        txt = txt.replace(/&GT;/g, '>');

        // "U+0003F", "QUESTION MARK"
        txt = txt.replace(/&#x0*?3F;/g, '?');
        txt = txt.replace(/&#0*?63;/g, '?');
        txt = txt.replace(/&quest;/g, '?');

        // "U+00040", "COMMERCIAL AT"
        txt = txt.replace(/&#x0*?40;/g, '@');
        txt = txt.replace(/&#0*?64;/g, '@');
        txt = txt.replace(/&commat;/g, '@');

        // "U+0005B", "LEFT SQUARE BRACKET"
        txt = txt.replace(/&#x0*?5B;/g, '[');
        txt = txt.replace(/&#0*?91;/g, '[');
        txt = txt.replace(/&lsqb;/g, '[');
        txt = txt.replace(/&lbrack;/g, '[');

        // "U+0005C", "REVERSE SOLIDUS"
        txt = txt.replace(/&#x0*?5C;/g, '\\');
        txt = txt.replace(/&#0*?92;/g, '\\');
        txt = txt.replace(/&bsol;/g, '\\');

        // "U+0005D", "RIGHT SQUARE BRACKET"
        txt = txt.replace(/&#x0*?5D;/g, ']');
        txt = txt.replace(/&#0*?93;/g, ']');
        txt = txt.replace(/&rsqb;/g, ']');
        txt = txt.replace(/&rbrack;/g, ']');

        // "U+0005E", "CIRCUMFLEX ACCENT"
        txt = txt.replace(/&#x0*?5E;/g, '^');
        txt = txt.replace(/&#0*?94;/g, '^');
        txt = txt.replace(/&Hat;/g, '^');

        // "U+0005F", "LOW LINE"
        txt = txt.replace(/&#x0*?5F;/g, '_');
        txt = txt.replace(/&#0*?95;/g, '_');
        txt = txt.replace(/&lowbar;/g, '_');

        // "U+00060", "GRAVE ACCENT"
        txt = txt.replace(/&#x0*?60;/g, '`');
        txt = txt.replace(/&#0*?96;/g, '`');
        txt = txt.replace(/&grave;/g, '`');
        txt = txt.replace(/&DiacriticalGrave;/g, '`');

        // "U+0007B", "LEFT CURLY BRACKET"
        txt = txt.replace(/&#x0*?7B;/g, '{');
        txt = txt.replace(/&#0*?123;/g, '{');
        txt = txt.replace(/&lcub;/g, '{');
        txt = txt.replace(/&lbrace;/g, '{');

        // "U+0007C", "VERTICAL LINE"
        txt = txt.replace(/&#x0*?7C;/g, '|');
        txt = txt.replace(/&#0*?124;/g, '|');
        txt = txt.replace(/&verbar;/g, '|');
        txt = txt.replace(/&vert;/g, '|');
        txt = txt.replace(/&VerticalLine;/g, '|');

        // "U+0007D", "RIGHT CURLY BRACKET"
        txt = txt.replace(/&#x0*?7D;/g, '}');
        txt = txt.replace(/&#0*?125;/g, '}');
        txt = txt.replace(/&rcub;/g, '}');
        txt = txt.replace(/&rbrace;/g, '}');

        // "U+000A0", "NO-BREAK SPACE"
        txt = txt.replace(/&#x0*?A0;/g, ' ');
        txt = txt.replace(/&#0*?160;/g, ' ');
        txt = txt.replace(/&nbsp;/g, ' ');
        txt = txt.replace(/&NonBreakingSpace;/g, ' ');

        // "U+000A1", "INVERTED EXCLAMATION MARK"
        txt = txt.replace(/&#x0*?A1;/g, '¡');
        txt = txt.replace(/&#0*?161;/g, '¡');
        txt = txt.replace(/&iexcl;/g, '¡');

        // "U+000A2", "CENT SIGN"
        txt = txt.replace(/&#x0*?A2;/g, '¢');
        txt = txt.replace(/&#0*?162;/g, '¢');
        txt = txt.replace(/&cent;/g, '¢');

        // "U+000A3", "POUND SIGN"
        txt = txt.replace(/&#x0*?A3;/g, '£');
        txt = txt.replace(/&#0*?163;/g, '£');
        txt = txt.replace(/&pound;/g, '£');

        // "U+000A4", "CURRENCY SIGN"
        txt = txt.replace(/&#x0*?A4;/g, '¤');
        txt = txt.replace(/&#0*?164;/g, '¤');
        txt = txt.replace(/&curren;/g, '¤');

        // "U+000A5", "YEN SIGN"
        txt = txt.replace(/&#x0*?A5;/g, '¥');
        txt = txt.replace(/&#0*?165;/g, '¥');
        txt = txt.replace(/&yen;/g, '¥');

        // "U+000A6", "BROKEN BAR"
        txt = txt.replace(/&#x0*?A6;/g, '¦');
        txt = txt.replace(/&#0*?166;/g, '¦');
        txt = txt.replace(/&brvbar;/g, '¦');

        // "U+000A7", "SECTION SIGN"
        txt = txt.replace(/&#x0*?A7;/g, '§');
        txt = txt.replace(/&#0*?167;/g, '§');
        txt = txt.replace(/&sect;/g, '§');

        // "U+000A8", "DIAERESIS"
        txt = txt.replace(/&#x0*?A8;/g, '¨');
        txt = txt.replace(/&#0*?168;/g, '¨');
        txt = txt.replace(/&Dot;/g, '¨');
        txt = txt.replace(/&die;/g, '¨');
        txt = txt.replace(/&DoubleDot;/g, '¨');
        txt = txt.replace(/&uml;/g, '¨');

        // "U+000A9", "COPYRIGHT SIGN"
        txt = txt.replace(/&#x0*?A9;/g, '©');
        txt = txt.replace(/&#0*?169;/g, '©');
        txt = txt.replace(/&copy;/g, '©');
        txt = txt.replace(/&COPY;/g, '©');

        // "U+000AA", "FEMININE ORDINAL INDICATOR"
        txt = txt.replace(/&#x0*?AA;/g, 'ª');
        txt = txt.replace(/&#0*?170;/g, 'ª');
        txt = txt.replace(/&ordf;/g, 'ª');

        // "U+000AB", "LEFT-POINTING DOUBLE ANGLE QUOTATION MARK"
        txt = txt.replace(/&#x0*?AB;/g, '«');
        txt = txt.replace(/&#0*?171;/g, '«');
        txt = txt.replace(/&laquo;/g, '«');

        // "U+000AC", "NOT SIGN"
        txt = txt.replace(/&#x0*?AC;/g, '¬');
        txt = txt.replace(/&#0*?172;/g, '¬');
        txt = txt.replace(/&not;/g, '¬');

        // "U+000AD", "SOFT HYPHEN"
        txt = txt.replace(/&#x0*?AD;/g, '­');
        txt = txt.replace(/&#0*?173;/g, '­');
        txt = txt.replace(/&shy;/g, '­');

        // "U+000AE", "REGISTERED SIGN"
        txt = txt.replace(/&#x0*?AE;/g, '®');
        txt = txt.replace(/&#0*?174;/g, '®');
        txt = txt.replace(/&reg;/g, '®');
        txt = txt.replace(/&circledR;/g, '®');
        txt = txt.replace(/&REG;/g, '®');

        // "U+000AF", "MACRON"
        txt = txt.replace(/&#x0*?AF;/g, '¯');
        txt = txt.replace(/&#0*?175;/g, '¯');
        txt = txt.replace(/&macr;/g, '¯');
        txt = txt.replace(/&OverBar;/g, '¯');
        txt = txt.replace(/&strns;/g, '¯');

        // "U+000B0", "DEGREE SIGN"
        txt = txt.replace(/&#x0*?B0;/g, '°');
        txt = txt.replace(/&#0*?176;/g, '°');
        txt = txt.replace(/&deg;/g, '°');

        // "U+000B1", "PLUS-MINUS SIGN"
        txt = txt.replace(/&#x0*?B1;/g, '±');
        txt = txt.replace(/&#0*?177;/g, '±');
        txt = txt.replace(/&plusmn;/g, '±');
        txt = txt.replace(/&pm;/g, '±');
        txt = txt.replace(/&PlusMinus;/g, '±');

        // "U+000B2", "SUPERSCRIPT TWO"
        txt = txt.replace(/&#x0*?B2;/g, '²');
        txt = txt.replace(/&#0*?178;/g, '²');
        txt = txt.replace(/&sup2;/g, '²');

        // "U+000B3", "SUPERSCRIPT THREE"
        txt = txt.replace(/&#x0*?B3;/g, '³');
        txt = txt.replace(/&#0*?179;/g, '³');
        txt = txt.replace(/&sup3;/g, '³');

        // "U+000B4", "ACUTE ACCENT"
        txt = txt.replace(/&#x0*?B4;/g, '´');
        txt = txt.replace(/&#0*?180;/g, '´');
        txt = txt.replace(/&acute;/g, '´');
        txt = txt.replace(/&DiacriticalAcute;/g, '´');

        // "U+000B5", "MICRO SIGN"
        txt = txt.replace(/&#x0*?B5;/g, 'µ');
        txt = txt.replace(/&#0*?181;/g, 'µ');
        txt = txt.replace(/&micro;/g, 'µ');

        // "U+000B6", "PILCROW SIGN"
        txt = txt.replace(/&#x0*?B6;/g, '¶');
        txt = txt.replace(/&#0*?182;/g, '¶');
        txt = txt.replace(/&para;/g, '¶');

        // "U+000B7", "MIDDLE DOT"
        txt = txt.replace(/&#x0*?B7;/g, '·');
        txt = txt.replace(/&#0*?183;/g, '·');
        txt = txt.replace(/&middot;/g, '·');
        txt = txt.replace(/&centerdot;/g, '·');
        txt = txt.replace(/&CenterDot;/g, '·');

        // "U+000B8", "CEDILLA"
        txt = txt.replace(/&#x0*?B8;/g, '¸');
        txt = txt.replace(/&#0*?184;/g, '¸');
        txt = txt.replace(/&cedil;/g, '¸');
        txt = txt.replace(/&Cedilla;/g, '¸');

        // "U+000B9", "SUPERSCRIPT ONE"
        txt = txt.replace(/&#x0*?B9;/g, '¹');
        txt = txt.replace(/&#0*?185;/g, '¹');
        txt = txt.replace(/&sup1;/g, '¹');

        // "U+000BA", "MASCULINE ORDINAL INDICATOR"
        txt = txt.replace(/&#x0*?BA;/g, 'º');
        txt = txt.replace(/&#0*?186;/g, 'º');
        txt = txt.replace(/&ordm;/g, 'º');

        // "U+000BB", "RIGHT-POINTING DOUBLE ANGLE QUOTATION MARK"
        txt = txt.replace(/&#x0*?BB;/g, '»');
        txt = txt.replace(/&#0*?187;/g, '»');
        txt = txt.replace(/&raquo;/g, '»');

        // "U+000BC", "VULGAR FRACTION ONE QUARTER"
        txt = txt.replace(/&#x0*?BC;/g, '¼');
        txt = txt.replace(/&#0*?188;/g, '¼');
        txt = txt.replace(/&frac14;/g, '¼');

        // "U+000BD", "VULGAR FRACTION ONE HALF"
        txt = txt.replace(/&#x0*?BD;/g, '½');
        txt = txt.replace(/&#0*?189;/g, '½');
        txt = txt.replace(/&frac12;/g, '½');
        txt = txt.replace(/&half;/g, '½');

        // "U+000BE", "VULGAR FRACTION THREE QUARTERS"
        txt = txt.replace(/&#x0*?BE;/g, '¾');
        txt = txt.replace(/&#0*?190;/g, '¾');
        txt = txt.replace(/&frac34;/g, '¾');

        // "U+000BF", "INVERTED QUESTION MARK"
        txt = txt.replace(/&#x0*?BF;/g, '¿');
        txt = txt.replace(/&#0*?191;/g, '¿');
        txt = txt.replace(/&iquest;/g, '¿');

        // "U+000C0", "LATIN CAPITAL LETTER A WITH GRAVE"
        txt = txt.replace(/&#x0*?C0;/g, 'À');
        txt = txt.replace(/&#0*?192;/g, 'À');
        txt = txt.replace(/&Agrave;/g, 'À');

        // "U+000C1", "LATIN CAPITAL LETTER A WITH ACUTE"
        txt = txt.replace(/&#x0*?C1;/g, 'Á');
        txt = txt.replace(/&#0*?193;/g, 'Á');
        txt = txt.replace(/&Aacute;/g, 'Á');

        // "U+000C2", "LATIN CAPITAL LETTER A WITH CIRCUMFLEX"
        txt = txt.replace(/&#x0*?C2;/g, 'Â');
        txt = txt.replace(/&#0*?194;/g, 'Â');
        txt = txt.replace(/&Acirc;/g, 'Â');

        // "U+000C3", "LATIN CAPITAL LETTER A WITH TILDE"
        txt = txt.replace(/&#x0*?C3;/g, 'Ã');
        txt = txt.replace(/&#0*?195;/g, 'Ã');
        txt = txt.replace(/&Atilde;/g, 'Ã');

        // "U+000C4", "LATIN CAPITAL LETTER A WITH DIAERESIS"
        txt = txt.replace(/&#x0*?C4;/g, 'Ä');
        txt = txt.replace(/&#0*?196;/g, 'Ä');
        txt = txt.replace(/&Auml;/g, 'Ä');

        // "U+000C5", "LATIN CAPITAL LETTER A WITH RING ABOVE"
        txt = txt.replace(/&#x0*?C5;/g, 'Å');
        txt = txt.replace(/&#0*?197;/g, 'Å');
        txt = txt.replace(/&Aring;/g, 'Å');

        // "U+000C6", "LATIN CAPITAL LETTER AE"
        txt = txt.replace(/&#x0*?C6;/g, 'Æ');
        txt = txt.replace(/&#0*?198;/g, 'Æ');
        txt = txt.replace(/&AElig;/g, 'Æ');

        // "U+000C7", "LATIN CAPITAL LETTER C WITH CEDILLA"
        txt = txt.replace(/&#x0*?C7;/g, 'Ç');
        txt = txt.replace(/&#0*?199;/g, 'Ç');
        txt = txt.replace(/&Ccedil;/g, 'Ç');

        // "U+000C8", "LATIN CAPITAL LETTER E WITH GRAVE"
        txt = txt.replace(/&#x0*?C8;/g, 'È');
        txt = txt.replace(/&#0*?200;/g, 'È');
        txt = txt.replace(/&Egrave;/g, 'È');

        // "U+000C9", "LATIN CAPITAL LETTER E WITH ACUTE"
        txt = txt.replace(/&#x0*?C9;/g, 'É');
        txt = txt.replace(/&#0*?201;/g, 'É');
        txt = txt.replace(/&Eacute;/g, 'É');

        // "U+000CA", "LATIN CAPITAL LETTER E WITH CIRCUMFLEX"
        txt = txt.replace(/&#x0*?CA;/g, 'Ê');
        txt = txt.replace(/&#0*?202;/g, 'Ê');
        txt = txt.replace(/&Ecirc;/g, 'Ê');

        // "U+000CB", "LATIN CAPITAL LETTER E WITH DIAERESIS"
        txt = txt.replace(/&#x0*?CB;/g, 'Ë');
        txt = txt.replace(/&#0*?203;/g, 'Ë');
        txt = txt.replace(/&Euml;/g, 'Ë');

        // "U+000CC", "LATIN CAPITAL LETTER I WITH GRAVE"
        txt = txt.replace(/&#x0*?CC;/g, 'Ì');
        txt = txt.replace(/&#0*?204;/g, 'Ì');
        txt = txt.replace(/&Igrave;/g, 'Ì');

        // "U+000CD", "LATIN CAPITAL LETTER I WITH ACUTE"
        txt = txt.replace(/&#x0*?CD;/g, 'Í');
        txt = txt.replace(/&#0*?205;/g, 'Í');
        txt = txt.replace(/&Iacute;/g, 'Í');

        // "U+000CE", "LATIN CAPITAL LETTER I WITH CIRCUMFLEX"
        txt = txt.replace(/&#x0*?CE;/g, 'Î');
        txt = txt.replace(/&#0*?206;/g, 'Î');
        txt = txt.replace(/&Icirc;/g, 'Î');

        // "U+000CF", "LATIN CAPITAL LETTER I WITH DIAERESIS"
        txt = txt.replace(/&#x0*?CF;/g, 'Ï');
        txt = txt.replace(/&#0*?207;/g, 'Ï');
        txt = txt.replace(/&Iuml;/g, 'Ï');

        // "U+000D0", "LATIN CAPITAL LETTER ETH"
        txt = txt.replace(/&#x0*?D0;/g, 'Ð');
        txt = txt.replace(/&#0*?208;/g, 'Ð');
        txt = txt.replace(/&ETH;/g, 'Ð');

        // "U+000D1", "LATIN CAPITAL LETTER N WITH TILDE"
        txt = txt.replace(/&#x0*?D1;/g, 'Ñ');
        txt = txt.replace(/&#0*?209;/g, 'Ñ');
        txt = txt.replace(/&Ntilde;/g, 'Ñ');

        // "U+000D2", "LATIN CAPITAL LETTER O WITH GRAVE"
        txt = txt.replace(/&#x0*?D2;/g, 'Ò');
        txt = txt.replace(/&#0*?210;/g, 'Ò');
        txt = txt.replace(/&Ograve;/g, 'Ò');

        // "U+000D3", "LATIN CAPITAL LETTER O WITH ACUTE"
        txt = txt.replace(/&#x0*?D3;/g, 'Ó');
        txt = txt.replace(/&#0*?211;/g, 'Ó');
        txt = txt.replace(/&Oacute;/g, 'Ó');

        // "U+000D4", "LATIN CAPITAL LETTER O WITH CIRCUMFLEX"
        txt = txt.replace(/&#x0*?D4;/g, 'Ô');
        txt = txt.replace(/&#0*?212;/g, 'Ô');
        txt = txt.replace(/&Ocirc;/g, 'Ô');

        // "U+000D5", "LATIN CAPITAL LETTER O WITH TILDE"
        txt = txt.replace(/&#x0*?D5;/g, 'Õ');
        txt = txt.replace(/&#0*?213;/g, 'Õ');
        txt = txt.replace(/&Otilde;/g, 'Õ');

        // "U+000D6", "LATIN CAPITAL LETTER O WITH DIAERESIS"
        txt = txt.replace(/&#x0*?D6;/g, 'Ö');
        txt = txt.replace(/&#0*?214;/g, 'Ö');
        txt = txt.replace(/&Ouml;/g, 'Ö');

        // "U+000D7", "MULTIPLICATION SIGN"
        txt = txt.replace(/&#x0*?D7;/g, '×');
        txt = txt.replace(/&#0*?215;/g, '×');
        txt = txt.replace(/&times;/g, '×');

        // "U+000D8", "LATIN CAPITAL LETTER O WITH STROKE"
        txt = txt.replace(/&#x0*?D8;/g, 'Ø');
        txt = txt.replace(/&#0*?216;/g, 'Ø');
        txt = txt.replace(/&Oslash;/g, 'Ø');

        // "U+000D9", "LATIN CAPITAL LETTER U WITH GRAVE"
        txt = txt.replace(/&#x0*?D9;/g, 'Ù');
        txt = txt.replace(/&#0*?217;/g, 'Ù');
        txt = txt.replace(/&Ugrave;/g, 'Ù');

        // "U+000DA", "LATIN CAPITAL LETTER U WITH ACUTE"
        txt = txt.replace(/&#x0*?DA;/g, 'Ú');
        txt = txt.replace(/&#0*?218;/g, 'Ú');
        txt = txt.replace(/&Uacute;/g, 'Ú');

        // "U+000DB", "LATIN CAPITAL LETTER U WITH CIRCUMFLEX"
        txt = txt.replace(/&#x0*?DB;/g, 'Û');
        txt = txt.replace(/&#0*?219;/g, 'Û');
        txt = txt.replace(/&Ucirc;/g, 'Û');

        // "U+000DC", "LATIN CAPITAL LETTER U WITH DIAERESIS"
        txt = txt.replace(/&#x0*?DC;/g, 'Ü');
        txt = txt.replace(/&#0*?220;/g, 'Ü');
        txt = txt.replace(/&Uuml;/g, 'Ü');

        // "U+000DD", "LATIN CAPITAL LETTER Y WITH ACUTE"
        txt = txt.replace(/&#x0*?DD;/g, 'Ý');
        txt = txt.replace(/&#0*?221;/g, 'Ý');
        txt = txt.replace(/&Yacute;/g, 'Ý');

        // "U+000DE", "LATIN CAPITAL LETTER THORN"
        txt = txt.replace(/&#x0*?DE;/g, 'Þ');
        txt = txt.replace(/&#0*?222;/g, 'Þ');
        txt = txt.replace(/&THORN;/g, 'Þ');

        // "U+000DF", "LATIN SMALL LETTER SHARP S"
        txt = txt.replace(/&#x0*?DF;/g, 'ß');
        txt = txt.replace(/&#0*?223;/g, 'ß');
        txt = txt.replace(/&szlig;/g, 'ß');

        // "U+000E0", "LATIN SMALL LETTER A WITH GRAVE"
        txt = txt.replace(/&#x0*?E0;/g, 'à');
        txt = txt.replace(/&#0*?224;/g, 'à');
        txt = txt.replace(/&agrave;/g, 'à');

        // "U+000E1", "LATIN SMALL LETTER A WITH ACUTE"
        txt = txt.replace(/&#x0*?E1;/g, 'á');
        txt = txt.replace(/&#0*?225;/g, 'á');
        txt = txt.replace(/&aacute;/g, 'á');

        // "U+000E2", "LATIN SMALL LETTER A WITH CIRCUMFLEX"
        txt = txt.replace(/&#x0*?E2;/g, 'â');
        txt = txt.replace(/&#0*?226;/g, 'â');
        txt = txt.replace(/&acirc;/g, 'â');

        // "U+000E3", "LATIN SMALL LETTER A WITH TILDE"
        txt = txt.replace(/&#x0*?E3;/g, 'ã');
        txt = txt.replace(/&#0*?227;/g, 'ã');
        txt = txt.replace(/&atilde;/g, 'ã');

        // "U+000E4", "LATIN SMALL LETTER A WITH DIAERESIS"
        txt = txt.replace(/&#x0*?E4;/g, 'ä');
        txt = txt.replace(/&#0*?228;/g, 'ä');
        txt = txt.replace(/&auml;/g, 'ä');

        // "U+000E5", "LATIN SMALL LETTER A WITH RING ABOVE"
        txt = txt.replace(/&#x0*?E5;/g, 'å');
        txt = txt.replace(/&#0*?229;/g, 'å');
        txt = txt.replace(/&aring;/g, 'å');

        // "U+000E6", "LATIN SMALL LETTER AE"
        txt = txt.replace(/&#x0*?E6;/g, 'æ');
        txt = txt.replace(/&#0*?230;/g, 'æ');
        txt = txt.replace(/&aelig;/g, 'æ');

        // "U+000E7", "LATIN SMALL LETTER C WITH CEDILLA"
        txt = txt.replace(/&#x0*?E7;/g, 'ç');
        txt = txt.replace(/&#0*?231;/g, 'ç');
        txt = txt.replace(/&ccedil;/g, 'ç');

        // "U+000E8", "LATIN SMALL LETTER E WITH GRAVE"
        txt = txt.replace(/&#x0*?E8;/g, 'è');
        txt = txt.replace(/&#0*?232;/g, 'è');
        txt = txt.replace(/&egrave;/g, 'è');

        // "U+000E9", "LATIN SMALL LETTER E WITH ACUTE"
        txt = txt.replace(/&#x0*?E9;/g, 'é');
        txt = txt.replace(/&#0*?233;/g, 'é');
        txt = txt.replace(/&eacute;/g, 'é');

        // "U+000EA", "LATIN SMALL LETTER E WITH CIRCUMFLEX"
        txt = txt.replace(/&#x0*?EA;/g, 'ê');
        txt = txt.replace(/&#0*?234;/g, 'ê');
        txt = txt.replace(/&ecirc;/g, 'ê');

        // "U+000EB", "LATIN SMALL LETTER E WITH DIAERESIS"
        txt = txt.replace(/&#x0*?EB;/g, 'ë');
        txt = txt.replace(/&#0*?235;/g, 'ë');
        txt = txt.replace(/&euml;/g, 'ë');

        // "U+000EC", "LATIN SMALL LETTER I WITH GRAVE"
        txt = txt.replace(/&#x0*?EC;/g, 'ì');
        txt = txt.replace(/&#0*?236;/g, 'ì');
        txt = txt.replace(/&igrave;/g, 'ì');

        // "U+000ED", "LATIN SMALL LETTER I WITH ACUTE"
        txt = txt.replace(/&#x0*?ED;/g, 'í');
        txt = txt.replace(/&#0*?237;/g, 'í');
        txt = txt.replace(/&iacute;/g, 'í');

        // "U+000EE", "LATIN SMALL LETTER I WITH CIRCUMFLEX"
        txt = txt.replace(/&#x0*?EE;/g, 'î');
        txt = txt.replace(/&#0*?238;/g, 'î');
        txt = txt.replace(/&icirc;/g, 'î');

        // "U+000EF", "LATIN SMALL LETTER I WITH DIAERESIS"
        txt = txt.replace(/&#x0*?EF;/g, 'ï');
        txt = txt.replace(/&#0*?239;/g, 'ï');
        txt = txt.replace(/&iuml;/g, 'ï');

        // "U+000F0", "LATIN SMALL LETTER ETH"
        txt = txt.replace(/&#x0*?F0;/g, 'ð');
        txt = txt.replace(/&#0*?240;/g, 'ð');
        txt = txt.replace(/&eth;/g, 'ð');

        // "U+000F1", "LATIN SMALL LETTER N WITH TILDE"
        txt = txt.replace(/&#x0*?F1;/g, 'ñ');
        txt = txt.replace(/&#0*?241;/g, 'ñ');
        txt = txt.replace(/&ntilde;/g, 'ñ');

        // "U+000F2", "LATIN SMALL LETTER O WITH GRAVE"
        txt = txt.replace(/&#x0*?F2;/g, 'ò');
        txt = txt.replace(/&#0*?242;/g, 'ò');
        txt = txt.replace(/&ograve;/g, 'ò');

        // "U+000F3", "LATIN SMALL LETTER O WITH ACUTE"
        txt = txt.replace(/&#x0*?F3;/g, 'ó');
        txt = txt.replace(/&#0*?243;/g, 'ó');
        txt = txt.replace(/&oacute;/g, 'ó');

        // "U+000F4", "LATIN SMALL LETTER O WITH CIRCUMFLEX"
        txt = txt.replace(/&#x0*?F4;/g, 'ô');
        txt = txt.replace(/&#0*?244;/g, 'ô');
        txt = txt.replace(/&ocirc;/g, 'ô');

        // "U+000F5", "LATIN SMALL LETTER O WITH TILDE"
        txt = txt.replace(/&#x0*?F5;/g, 'õ');
        txt = txt.replace(/&#0*?245;/g, 'õ');
        txt = txt.replace(/&otilde;/g, 'õ');

        // "U+000F6", "LATIN SMALL LETTER O WITH DIAERESIS"
        txt = txt.replace(/&#x0*?F6;/g, 'ö');
        txt = txt.replace(/&#0*?246;/g, 'ö');
        txt = txt.replace(/&ouml;/g, 'ö');

        // "U+000F7", "DIVISION SIGN"
        txt = txt.replace(/&#x0*?F7;/g, '÷');
        txt = txt.replace(/&#0*?247;/g, '÷');
        txt = txt.replace(/&divide;/g, '÷');
        txt = txt.replace(/&div;/g, '÷');

        // "U+000F8", "LATIN SMALL LETTER O WITH STROKE"
        txt = txt.replace(/&#x0*?F8;/g, 'ø');
        txt = txt.replace(/&#0*?248;/g, 'ø');
        txt = txt.replace(/&oslash;/g, 'ø');

        // "U+000F9", "LATIN SMALL LETTER U WITH GRAVE"
        txt = txt.replace(/&#x0*?F9;/g, 'ù');
        txt = txt.replace(/&#0*?249;/g, 'ù');
        txt = txt.replace(/&ugrave;/g, 'ù');

        // "U+000FA", "LATIN SMALL LETTER U WITH ACUTE"
        txt = txt.replace(/&#x0*?FA;/g, 'ú');
        txt = txt.replace(/&#0*?250;/g, 'ú');
        txt = txt.replace(/&uacute;/g, 'ú');

        // "U+000FB", "LATIN SMALL LETTER U WITH CIRCUMFLEX"
        txt = txt.replace(/&#x0*?FB;/g, 'û');
        txt = txt.replace(/&#0*?251;/g, 'û');
        txt = txt.replace(/&ucirc;/g, 'û');

        // "U+000FC", "LATIN SMALL LETTER U WITH DIAERESIS"
        txt = txt.replace(/&#x0*?FC;/g, 'ü');
        txt = txt.replace(/&#0*?252;/g, 'ü');
        txt = txt.replace(/&uuml;/g, 'ü');

        // "U+000FD", "LATIN SMALL LETTER Y WITH ACUTE"
        txt = txt.replace(/&#x0*?FD;/g, 'ý');
        txt = txt.replace(/&#0*?253;/g, 'ý');
        txt = txt.replace(/&yacute;/g, 'ý');

        // "U+000FE", "LATIN SMALL LETTER THORN"
        txt = txt.replace(/&#x0*?FE;/g, 'þ');
        txt = txt.replace(/&#0*?254;/g, 'þ');
        txt = txt.replace(/&thorn;/g, 'þ');

        // "U+000FF", "LATIN SMALL LETTER Y WITH DIAERESIS"
        txt = txt.replace(/&#x0*?FF;/g, 'ÿ');
        txt = txt.replace(/&#0*?255;/g, 'ÿ');
        txt = txt.replace(/&yuml;/g, 'ÿ');

        // "U+00100", "LATIN CAPITAL LETTER A WITH MACRON"
        txt = txt.replace(/&#x0*?100;/g, 'Ā');
        txt = txt.replace(/&#0*?256;/g, 'Ā');
        txt = txt.replace(/&Amacr;/g, 'Ā');

        // "U+00101", "LATIN SMALL LETTER A WITH MACRON"
        txt = txt.replace(/&#x0*?101;/g, 'ā');
        txt = txt.replace(/&#0*?257;/g, 'ā');
        txt = txt.replace(/&amacr;/g, 'ā');

        // "U+00102", "LATIN CAPITAL LETTER A WITH BREVE"
        txt = txt.replace(/&#x0*?102;/g, 'Ă');
        txt = txt.replace(/&#0*?258;/g, 'Ă');
        txt = txt.replace(/&Abreve;/g, 'Ă');

        // "U+00103", "LATIN SMALL LETTER A WITH BREVE"
        txt = txt.replace(/&#x0*?103;/g, 'ă');
        txt = txt.replace(/&#0*?259;/g, 'ă');
        txt = txt.replace(/&abreve;/g, 'ă');

        // "U+00104", "LATIN CAPITAL LETTER A WITH OGONEK"
        txt = txt.replace(/&#x0*?104;/g, 'Ą');
        txt = txt.replace(/&#0*?260;/g, 'Ą');
        txt = txt.replace(/&Aogon;/g, 'Ą');

        // "U+00105", "LATIN SMALL LETTER A WITH OGONEK"
        txt = txt.replace(/&#x0*?105;/g, 'ą');
        txt = txt.replace(/&#0*?261;/g, 'ą');
        txt = txt.replace(/&aogon;/g, 'ą');

        // "U+00106", "LATIN CAPITAL LETTER C WITH ACUTE"
        txt = txt.replace(/&#x0*?106;/g, 'Ć');
        txt = txt.replace(/&#0*?262;/g, 'Ć');
        txt = txt.replace(/&Cacute;/g, 'Ć');

        // "U+00107", "LATIN SMALL LETTER C WITH ACUTE"
        txt = txt.replace(/&#x0*?107;/g, 'ć');
        txt = txt.replace(/&#0*?263;/g, 'ć');
        txt = txt.replace(/&cacute;/g, 'ć');

        // "U+00108", "LATIN CAPITAL LETTER C WITH CIRCUMFLEX"
        txt = txt.replace(/&#x0*?108;/g, 'Ĉ');
        txt = txt.replace(/&#0*?264;/g, 'Ĉ');
        txt = txt.replace(/&Ccirc;/g, 'Ĉ');

        // "U+00109", "LATIN SMALL LETTER C WITH CIRCUMFLEX"
        txt = txt.replace(/&#x0*?109;/g, 'ĉ');
        txt = txt.replace(/&#0*?265;/g, 'ĉ');
        txt = txt.replace(/&ccirc;/g, 'ĉ');

        // "U+0010A", "LATIN CAPITAL LETTER C WITH DOT ABOVE"
        txt = txt.replace(/&#x0*?10A;/g, 'Ċ');
        txt = txt.replace(/&#0*?266;/g, 'Ċ');
        txt = txt.replace(/&Cdot;/g, 'Ċ');

        // "U+0010B", "LATIN SMALL LETTER C WITH DOT ABOVE"
        txt = txt.replace(/&#x0*?10B;/g, 'ċ');
        txt = txt.replace(/&#0*?267;/g, 'ċ');
        txt = txt.replace(/&cdot;/g, 'ċ');

        // "U+0010C", "LATIN CAPITAL LETTER C WITH CARON"
        txt = txt.replace(/&#x0*?10C;/g, 'Č');
        txt = txt.replace(/&#0*?268;/g, 'Č');
        txt = txt.replace(/&Ccaron;/g, 'Č');

        // "U+0010D", "LATIN SMALL LETTER C WITH CARON"
        txt = txt.replace(/&#x0*?10D;/g, 'č');
        txt = txt.replace(/&#0*?269;/g, 'č');
        txt = txt.replace(/&ccaron;/g, 'č');

        // "U+0010E", "LATIN CAPITAL LETTER D WITH CARON"
        txt = txt.replace(/&#x0*?10E;/g, 'Ď');
        txt = txt.replace(/&#0*?270;/g, 'Ď');
        txt = txt.replace(/&Dcaron;/g, 'Ď');

        // "U+0010F", "LATIN SMALL LETTER D WITH CARON"
        txt = txt.replace(/&#x0*?10F;/g, 'ď');
        txt = txt.replace(/&#0*?271;/g, 'ď');
        txt = txt.replace(/&dcaron;/g, 'ď');

        // "U+00110", "LATIN CAPITAL LETTER D WITH STROKE"
        txt = txt.replace(/&#x0*?110;/g, 'Đ');
        txt = txt.replace(/&#0*?272;/g, 'Đ');
        txt = txt.replace(/&Dstrok;/g, 'Đ');

        // "U+00111", "LATIN SMALL LETTER D WITH STROKE"
        txt = txt.replace(/&#x0*?111;/g, 'đ');
        txt = txt.replace(/&#0*?273;/g, 'đ');
        txt = txt.replace(/&dstrok;/g, 'đ');

        // "U+00112", "LATIN CAPITAL LETTER E WITH MACRON"
        txt = txt.replace(/&#x0*?112;/g, 'Ē');
        txt = txt.replace(/&#0*?274;/g, 'Ē');
        txt = txt.replace(/&Emacr;/g, 'Ē');

        // "U+00113", "LATIN SMALL LETTER E WITH MACRON"
        txt = txt.replace(/&#x0*?113;/g, 'ē');
        txt = txt.replace(/&#0*?275;/g, 'ē');
        txt = txt.replace(/&emacr;/g, 'ē');

        // "U+00116", "LATIN CAPITAL LETTER E WITH DOT ABOVE"
        txt = txt.replace(/&#x0*?116;/g, 'Ė');
        txt = txt.replace(/&#0*?278;/g, 'Ė');
        txt = txt.replace(/&Edot;/g, 'Ė');

        // "U+00117", "LATIN SMALL LETTER E WITH DOT ABOVE"
        txt = txt.replace(/&#x0*?117;/g, 'ė');
        txt = txt.replace(/&#0*?279;/g, 'ė');
        txt = txt.replace(/&edot;/g, 'ė');

        // "U+00118", "LATIN CAPITAL LETTER E WITH OGONEK"
        txt = txt.replace(/&#x0*?118;/g, 'Ę');
        txt = txt.replace(/&#0*?280;/g, 'Ę');
        txt = txt.replace(/&Eogon;/g, 'Ę');

        // "U+00119", "LATIN SMALL LETTER E WITH OGONEK"
        txt = txt.replace(/&#x0*?119;/g, 'ę');
        txt = txt.replace(/&#0*?281;/g, 'ę');
        txt = txt.replace(/&eogon;/g, 'ę');

        // "U+0011A", "LATIN CAPITAL LETTER E WITH CARON"
        txt = txt.replace(/&#x0*?11A;/g, 'Ě');
        txt = txt.replace(/&#0*?282;/g, 'Ě');
        txt = txt.replace(/&Ecaron;/g, 'Ě');

        // "U+0011B", "LATIN SMALL LETTER E WITH CARON"
        txt = txt.replace(/&#x0*?11B;/g, 'ě');
        txt = txt.replace(/&#0*?283;/g, 'ě');
        txt = txt.replace(/&ecaron;/g, 'ě');

        // "U+0011C", "LATIN CAPITAL LETTER G WITH CIRCUMFLEX"
        txt = txt.replace(/&#x0*?11C;/g, 'Ĝ');
        txt = txt.replace(/&#0*?284;/g, 'Ĝ');
        txt = txt.replace(/&Gcirc;/g, 'Ĝ');

        // "U+0011D", "LATIN SMALL LETTER G WITH CIRCUMFLEX"
        txt = txt.replace(/&#x0*?11D;/g, 'ĝ');
        txt = txt.replace(/&#0*?285;/g, 'ĝ');
        txt = txt.replace(/&gcirc;/g, 'ĝ');

        // "U+0011E", "LATIN CAPITAL LETTER G WITH BREVE"
        txt = txt.replace(/&#x0*?11E;/g, 'Ğ');
        txt = txt.replace(/&#0*?286;/g, 'Ğ');
        txt = txt.replace(/&Gbreve;/g, 'Ğ');

        // "U+0011F", "LATIN SMALL LETTER G WITH BREVE"
        txt = txt.replace(/&#x0*?11F;/g, 'ğ');
        txt = txt.replace(/&#0*?287;/g, 'ğ');
        txt = txt.replace(/&gbreve;/g, 'ğ');

        // "U+00120", "LATIN CAPITAL LETTER G WITH DOT ABOVE"
        txt = txt.replace(/&#x0*?120;/g, 'Ġ');
        txt = txt.replace(/&#0*?288;/g, 'Ġ');
        txt = txt.replace(/&Gdot;/g, 'Ġ');

        // "U+00121", "LATIN SMALL LETTER G WITH DOT ABOVE"
        txt = txt.replace(/&#x0*?121;/g, 'ġ');
        txt = txt.replace(/&#0*?289;/g, 'ġ');
        txt = txt.replace(/&gdot;/g, 'ġ');

        // "U+00122", "LATIN CAPITAL LETTER G WITH CEDILLA"
        txt = txt.replace(/&#x0*?122;/g, 'Ģ');
        txt = txt.replace(/&#0*?290;/g, 'Ģ');
        txt = txt.replace(/&Gcedil;/g, 'Ģ');

        // "U+00124", "LATIN CAPITAL LETTER H WITH CIRCUMFLEX"
        txt = txt.replace(/&#x0*?124;/g, 'Ĥ');
        txt = txt.replace(/&#0*?292;/g, 'Ĥ');
        txt = txt.replace(/&Hcirc;/g, 'Ĥ');

        // "U+00125", "LATIN SMALL LETTER H WITH CIRCUMFLEX"
        txt = txt.replace(/&#x0*?125;/g, 'ĥ');
        txt = txt.replace(/&#0*?293;/g, 'ĥ');
        txt = txt.replace(/&hcirc;/g, 'ĥ');

        // "U+00126", "LATIN CAPITAL LETTER H WITH STROKE"
        txt = txt.replace(/&#x0*?126;/g, 'Ħ');
        txt = txt.replace(/&#0*?294;/g, 'Ħ');
        txt = txt.replace(/&Hstrok;/g, 'Ħ');

        // "U+00127", "LATIN SMALL LETTER H WITH STROKE"
        txt = txt.replace(/&#x0*?127;/g, 'ħ');
        txt = txt.replace(/&#0*?295;/g, 'ħ');
        txt = txt.replace(/&hstrok;/g, 'ħ');

        // "U+00128", "LATIN CAPITAL LETTER I WITH TILDE"
        txt = txt.replace(/&#x0*?128;/g, 'Ĩ');
        txt = txt.replace(/&#0*?296;/g, 'Ĩ');
        txt = txt.replace(/&Itilde;/g, 'Ĩ');

        // "U+00129", "LATIN SMALL LETTER I WITH TILDE"
        txt = txt.replace(/&#x0*?129;/g, 'ĩ');
        txt = txt.replace(/&#0*?297;/g, 'ĩ');
        txt = txt.replace(/&itilde;/g, 'ĩ');

        // "U+0012A", "LATIN CAPITAL LETTER I WITH MACRON"
        txt = txt.replace(/&#x0*?12A;/g, 'Ī');
        txt = txt.replace(/&#0*?298;/g, 'Ī');
        txt = txt.replace(/&Imacr;/g, 'Ī');

        // "U+0012B", "LATIN SMALL LETTER I WITH MACRON"
        txt = txt.replace(/&#x0*?12B;/g, 'ī');
        txt = txt.replace(/&#0*?299;/g, 'ī');
        txt = txt.replace(/&imacr;/g, 'ī');

        // "U+0012E", "LATIN CAPITAL LETTER I WITH OGONEK"
        txt = txt.replace(/&#x0*?12E;/g, 'Į');
        txt = txt.replace(/&#0*?302;/g, 'Į');
        txt = txt.replace(/&Iogon;/g, 'Į');

        // "U+0012F", "LATIN SMALL LETTER I WITH OGONEK"
        txt = txt.replace(/&#x0*?12F;/g, 'į');
        txt = txt.replace(/&#0*?303;/g, 'į');
        txt = txt.replace(/&iogon;/g, 'į');

        // "U+00130", "LATIN CAPITAL LETTER I WITH DOT ABOVE"
        txt = txt.replace(/&#x0*?130;/g, 'İ');
        txt = txt.replace(/&#0*?304;/g, 'İ');
        txt = txt.replace(/&Idot;/g, 'İ');

        // "U+00131", "LATIN SMALL LETTER DOTLESS I"
        txt = txt.replace(/&#x0*?131;/g, 'ı');
        txt = txt.replace(/&#0*?305;/g, 'ı');
        txt = txt.replace(/&imath;/g, 'ı');
        txt = txt.replace(/&inodot;/g, 'ı');

        // "U+00132", "LATIN CAPITAL LIGATURE IJ"
        txt = txt.replace(/&#x0*?132;/g, 'Ĳ');
        txt = txt.replace(/&#0*?306;/g, 'Ĳ');
        txt = txt.replace(/&IJlig;/g, 'Ĳ');

        // "U+00133", "LATIN SMALL LIGATURE IJ"
        txt = txt.replace(/&#x0*?133;/g, 'ĳ');
        txt = txt.replace(/&#0*?307;/g, 'ĳ');
        txt = txt.replace(/&ijlig;/g, 'ĳ');

        // "U+00134", "LATIN CAPITAL LETTER J WITH CIRCUMFLEX"
        txt = txt.replace(/&#x0*?134;/g, 'Ĵ');
        txt = txt.replace(/&#0*?308;/g, 'Ĵ');
        txt = txt.replace(/&Jcirc;/g, 'Ĵ');

        // "U+00135", "LATIN SMALL LETTER J WITH CIRCUMFLEX"
        txt = txt.replace(/&#x0*?135;/g, 'ĵ');
        txt = txt.replace(/&#0*?309;/g, 'ĵ');
        txt = txt.replace(/&jcirc;/g, 'ĵ');

        // "U+00136", "LATIN CAPITAL LETTER K WITH CEDILLA"
        txt = txt.replace(/&#x0*?136;/g, 'Ķ');
        txt = txt.replace(/&#0*?310;/g, 'Ķ');
        txt = txt.replace(/&Kcedil;/g, 'Ķ');

        // "U+00137", "LATIN SMALL LETTER K WITH CEDILLA"
        txt = txt.replace(/&#x0*?137;/g, 'ķ');
        txt = txt.replace(/&#0*?311;/g, 'ķ');
        txt = txt.replace(/&kcedil;/g, 'ķ');

        // "U+00138", "LATIN SMALL LETTER KRA"
        txt = txt.replace(/&#x0*?138;/g, 'ĸ');
        txt = txt.replace(/&#0*?312;/g, 'ĸ');
        txt = txt.replace(/&kgreen;/g, 'ĸ');

        // "U+00139", "LATIN CAPITAL LETTER L WITH ACUTE"
        txt = txt.replace(/&#x0*?139;/g, 'Ĺ');
        txt = txt.replace(/&#0*?313;/g, 'Ĺ');
        txt = txt.replace(/&Lacute;/g, 'Ĺ');

        // "U+0013A", "LATIN SMALL LETTER L WITH ACUTE"
        txt = txt.replace(/&#x0*?13A;/g, 'ĺ');
        txt = txt.replace(/&#0*?314;/g, 'ĺ');
        txt = txt.replace(/&lacute;/g, 'ĺ');

        // "U+0013B", "LATIN CAPITAL LETTER L WITH CEDILLA"
        txt = txt.replace(/&#x0*?13B;/g, 'Ļ');
        txt = txt.replace(/&#0*?315;/g, 'Ļ');
        txt = txt.replace(/&Lcedil;/g, 'Ļ');

        // "U+0013C", "LATIN SMALL LETTER L WITH CEDILLA"
        txt = txt.replace(/&#x0*?13C;/g, 'ļ');
        txt = txt.replace(/&#0*?316;/g, 'ļ');
        txt = txt.replace(/&lcedil;/g, 'ļ');

        // "U+0013D", "LATIN CAPITAL LETTER L WITH CARON"
        txt = txt.replace(/&#x0*?13D;/g, 'Ľ');
        txt = txt.replace(/&#0*?317;/g, 'Ľ');
        txt = txt.replace(/&Lcaron;/g, 'Ľ');

        // "U+0013E", "LATIN SMALL LETTER L WITH CARON"
        txt = txt.replace(/&#x0*?13E;/g, 'ľ');
        txt = txt.replace(/&#0*?318;/g, 'ľ');
        txt = txt.replace(/&lcaron;/g, 'ľ');

        // "U+0013F", "LATIN CAPITAL LETTER L WITH MIDDLE DOT"
        txt = txt.replace(/&#x0*?13F;/g, 'Ŀ');
        txt = txt.replace(/&#0*?319;/g, 'Ŀ');
        txt = txt.replace(/&Lmidot;/g, 'Ŀ');

        // "U+00140", "LATIN SMALL LETTER L WITH MIDDLE DOT"
        txt = txt.replace(/&#x0*?140;/g, 'ŀ');
        txt = txt.replace(/&#0*?320;/g, 'ŀ');
        txt = txt.replace(/&lmidot;/g, 'ŀ');

        // "U+00141", "LATIN CAPITAL LETTER L WITH STROKE"
        txt = txt.replace(/&#x0*?141;/g, 'Ł');
        txt = txt.replace(/&#0*?321;/g, 'Ł');
        txt = txt.replace(/&Lstrok;/g, 'Ł');

        // "U+00142", "LATIN SMALL LETTER L WITH STROKE"
        txt = txt.replace(/&#x0*?142;/g, 'ł');
        txt = txt.replace(/&#0*?322;/g, 'ł');
        txt = txt.replace(/&lstrok;/g, 'ł');

        // "U+00143", "LATIN CAPITAL LETTER N WITH ACUTE"
        txt = txt.replace(/&#x0*?143;/g, 'Ń');
        txt = txt.replace(/&#0*?323;/g, 'Ń');
        txt = txt.replace(/&Nacute;/g, 'Ń');

        // "U+00144", "LATIN SMALL LETTER N WITH ACUTE"
        txt = txt.replace(/&#x0*?144;/g, 'ń');
        txt = txt.replace(/&#0*?324;/g, 'ń');
        txt = txt.replace(/&nacute;/g, 'ń');

        // "U+00145", "LATIN CAPITAL LETTER N WITH CEDILLA"
        txt = txt.replace(/&#x0*?145;/g, 'Ņ');
        txt = txt.replace(/&#0*?325;/g, 'Ņ');
        txt = txt.replace(/&Ncedil;/g, 'Ņ');

        // "U+00146", "LATIN SMALL LETTER N WITH CEDILLA"
        txt = txt.replace(/&#x0*?146;/g, 'ņ');
        txt = txt.replace(/&#0*?326;/g, 'ņ');
        txt = txt.replace(/&ncedil;/g, 'ņ');

        // "U+00147", "LATIN CAPITAL LETTER N WITH CARON"
        txt = txt.replace(/&#x0*?147;/g, 'Ň');
        txt = txt.replace(/&#0*?327;/g, 'Ň');
        txt = txt.replace(/&Ncaron;/g, 'Ň');

        // "U+00148", "LATIN SMALL LETTER N WITH CARON"
        txt = txt.replace(/&#x0*?148;/g, 'ň');
        txt = txt.replace(/&#0*?328;/g, 'ň');
        txt = txt.replace(/&ncaron;/g, 'ň');

        // "U+00149", "LATIN SMALL LETTER N PRECEDED BY APOSTROPHE"
        txt = txt.replace(/&#x0*?149;/g, 'ŉ');
        txt = txt.replace(/&#0*?329;/g, 'ŉ');
        txt = txt.replace(/&napos;/g, 'ŉ');

        // "U+0014A", "LATIN CAPITAL LETTER ENG"
        txt = txt.replace(/&#x0*?14A;/g, 'Ŋ');
        txt = txt.replace(/&#0*?330;/g, 'Ŋ');
        txt = txt.replace(/&ENG;/g, 'Ŋ');

        // "U+0014B", "LATIN SMALL LETTER ENG"
        txt = txt.replace(/&#x0*?14B;/g, 'ŋ');
        txt = txt.replace(/&#0*?331;/g, 'ŋ');
        txt = txt.replace(/&eng;/g, 'ŋ');

        // "U+0014C", "LATIN CAPITAL LETTER O WITH MACRON"
        txt = txt.replace(/&#x0*?14C;/g, 'Ō');
        txt = txt.replace(/&#0*?332;/g, 'Ō');
        txt = txt.replace(/&Omacr;/g, 'Ō');

        // "U+0014D", "LATIN SMALL LETTER O WITH MACRON"
        txt = txt.replace(/&#x0*?14D;/g, 'ō');
        txt = txt.replace(/&#0*?333;/g, 'ō');
        txt = txt.replace(/&omacr;/g, 'ō');

        // "U+00150", "LATIN CAPITAL LETTER O WITH DOUBLE ACUTE"
        txt = txt.replace(/&#x0*?150;/g, 'Ő');
        txt = txt.replace(/&#0*?336;/g, 'Ő');
        txt = txt.replace(/&Odblac;/g, 'Ő');

        // "U+00151", "LATIN SMALL LETTER O WITH DOUBLE ACUTE"
        txt = txt.replace(/&#x0*?151;/g, 'ő');
        txt = txt.replace(/&#0*?337;/g, 'ő');
        txt = txt.replace(/&odblac;/g, 'ő');

        // "U+00152", "LATIN CAPITAL LIGATURE OE"
        txt = txt.replace(/&#x0*?152;/g, 'Œ');
        txt = txt.replace(/&#0*?338;/g, 'Œ');
        txt = txt.replace(/&OElig;/g, 'Œ');

        // "U+00153", "LATIN SMALL LIGATURE OE"
        txt = txt.replace(/&#x0*?153;/g, 'œ');
        txt = txt.replace(/&#0*?339;/g, 'œ');
        txt = txt.replace(/&oelig;/g, 'œ');

        // "U+00154", "LATIN CAPITAL LETTER R WITH ACUTE"
        txt = txt.replace(/&#x0*?154;/g, 'Ŕ');
        txt = txt.replace(/&#0*?340;/g, 'Ŕ');
        txt = txt.replace(/&Racute;/g, 'Ŕ');

        // "U+00155", "LATIN SMALL LETTER R WITH ACUTE"
        txt = txt.replace(/&#x0*?155;/g, 'ŕ');
        txt = txt.replace(/&#0*?341;/g, 'ŕ');
        txt = txt.replace(/&racute;/g, 'ŕ');

        // "U+00156", "LATIN CAPITAL LETTER R WITH CEDILLA"
        txt = txt.replace(/&#x0*?156;/g, 'Ŗ');
        txt = txt.replace(/&#0*?342;/g, 'Ŗ');
        txt = txt.replace(/&Rcedil;/g, 'Ŗ');

        // "U+00157", "LATIN SMALL LETTER R WITH CEDILLA"
        txt = txt.replace(/&#x0*?157;/g, 'ŗ');
        txt = txt.replace(/&#0*?343;/g, 'ŗ');
        txt = txt.replace(/&rcedil;/g, 'ŗ');

        // "U+00158", "LATIN CAPITAL LETTER R WITH CARON"
        txt = txt.replace(/&#x0*?158;/g, 'Ř');
        txt = txt.replace(/&#0*?344;/g, 'Ř');
        txt = txt.replace(/&Rcaron;/g, 'Ř');

        // "U+00159", "LATIN SMALL LETTER R WITH CARON"
        txt = txt.replace(/&#x0*?159;/g, 'ř');
        txt = txt.replace(/&#0*?345;/g, 'ř');
        txt = txt.replace(/&rcaron;/g, 'ř');

        // "U+0015A", "LATIN CAPITAL LETTER S WITH ACUTE"
        txt = txt.replace(/&#x0*?15A;/g, 'Ś');
        txt = txt.replace(/&#0*?346;/g, 'Ś');
        txt = txt.replace(/&Sacute;/g, 'Ś');

        // "U+0015B", "LATIN SMALL LETTER S WITH ACUTE"
        txt = txt.replace(/&#x0*?15B;/g, 'ś');
        txt = txt.replace(/&#0*?347;/g, 'ś');
        txt = txt.replace(/&sacute;/g, 'ś');

        // "U+0015C", "LATIN CAPITAL LETTER S WITH CIRCUMFLEX"
        txt = txt.replace(/&#x0*?15C;/g, 'Ŝ');
        txt = txt.replace(/&#0*?348;/g, 'Ŝ');
        txt = txt.replace(/&Scirc;/g, 'Ŝ');

        // "U+0015D", "LATIN SMALL LETTER S WITH CIRCUMFLEX"
        txt = txt.replace(/&#x0*?15D;/g, 'ŝ');
        txt = txt.replace(/&#0*?349;/g, 'ŝ');
        txt = txt.replace(/&scirc;/g, 'ŝ');

        // "U+0015E", "LATIN CAPITAL LETTER S WITH CEDILLA"
        txt = txt.replace(/&#x0*?15E;/g, 'Ş');
        txt = txt.replace(/&#0*?350;/g, 'Ş');
        txt = txt.replace(/&Scedil;/g, 'Ş');

        // "U+0015F", "LATIN SMALL LETTER S WITH CEDILLA"
        txt = txt.replace(/&#x0*?15F;/g, 'ş');
        txt = txt.replace(/&#0*?351;/g, 'ş');
        txt = txt.replace(/&scedil;/g, 'ş');

        // "U+00160", "LATIN CAPITAL LETTER S WITH CARON"
        txt = txt.replace(/&#x0*?160;/g, 'Š');
        txt = txt.replace(/&#0*?352;/g, 'Š');
        txt = txt.replace(/&Scaron;/g, 'Š');

        // "U+00161", "LATIN SMALL LETTER S WITH CARON"
        txt = txt.replace(/&#x0*?161;/g, 'š');
        txt = txt.replace(/&#0*?353;/g, 'š');
        txt = txt.replace(/&scaron;/g, 'š');

        // "U+00162", "LATIN CAPITAL LETTER T WITH CEDILLA"
        txt = txt.replace(/&#x0*?162;/g, 'Ţ');
        txt = txt.replace(/&#0*?354;/g, 'Ţ');
        txt = txt.replace(/&Tcedil;/g, 'Ţ');

        // "U+00163", "LATIN SMALL LETTER T WITH CEDILLA"
        txt = txt.replace(/&#x0*?163;/g, 'ţ');
        txt = txt.replace(/&#0*?355;/g, 'ţ');
        txt = txt.replace(/&tcedil;/g, 'ţ');

        // "U+00164", "LATIN CAPITAL LETTER T WITH CARON"
        txt = txt.replace(/&#x0*?164;/g, 'Ť');
        txt = txt.replace(/&#0*?356;/g, 'Ť');
        txt = txt.replace(/&Tcaron;/g, 'Ť');

        // "U+00165", "LATIN SMALL LETTER T WITH CARON"
        txt = txt.replace(/&#x0*?165;/g, 'ť');
        txt = txt.replace(/&#0*?357;/g, 'ť');
        txt = txt.replace(/&tcaron;/g, 'ť');

        // "U+00166", "LATIN CAPITAL LETTER T WITH STROKE"
        txt = txt.replace(/&#x0*?166;/g, 'Ŧ');
        txt = txt.replace(/&#0*?358;/g, 'Ŧ');
        txt = txt.replace(/&Tstrok;/g, 'Ŧ');

        // "U+00167", "LATIN SMALL LETTER T WITH STROKE"
        txt = txt.replace(/&#x0*?167;/g, 'ŧ');
        txt = txt.replace(/&#0*?359;/g, 'ŧ');
        txt = txt.replace(/&tstrok;/g, 'ŧ');

        // "U+00168", "LATIN CAPITAL LETTER U WITH TILDE"
        txt = txt.replace(/&#x0*?168;/g, 'Ũ');
        txt = txt.replace(/&#0*?360;/g, 'Ũ');
        txt = txt.replace(/&Utilde;/g, 'Ũ');

        // "U+00169", "LATIN SMALL LETTER U WITH TILDE"
        txt = txt.replace(/&#x0*?169;/g, 'ũ');
        txt = txt.replace(/&#0*?361;/g, 'ũ');
        txt = txt.replace(/&utilde;/g, 'ũ');

        // "U+0016A", "LATIN CAPITAL LETTER U WITH MACRON"
        txt = txt.replace(/&#x0*?16A;/g, 'Ū');
        txt = txt.replace(/&#0*?362;/g, 'Ū');
        txt = txt.replace(/&Umacr;/g, 'Ū');

        // "U+0016B", "LATIN SMALL LETTER U WITH MACRON"
        txt = txt.replace(/&#x0*?16B;/g, 'ū');
        txt = txt.replace(/&#0*?363;/g, 'ū');
        txt = txt.replace(/&umacr;/g, 'ū');

        // "U+0016C", "LATIN CAPITAL LETTER U WITH BREVE"
        txt = txt.replace(/&#x0*?16C;/g, 'Ŭ');
        txt = txt.replace(/&#0*?364;/g, 'Ŭ');
        txt = txt.replace(/&Ubreve;/g, 'Ŭ');

        // "U+0016D", "LATIN SMALL LETTER U WITH BREVE"
        txt = txt.replace(/&#x0*?16D;/g, 'ŭ');
        txt = txt.replace(/&#0*?365;/g, 'ŭ');
        txt = txt.replace(/&ubreve;/g, 'ŭ');

        // "U+0016E", "LATIN CAPITAL LETTER U WITH RING ABOVE"
        txt = txt.replace(/&#x0*?16E;/g, 'Ů');
        txt = txt.replace(/&#0*?366;/g, 'Ů');
        txt = txt.replace(/&Uring;/g, 'Ů');

        // "U+0016F", "LATIN SMALL LETTER U WITH RING ABOVE"
        txt = txt.replace(/&#x0*?16F;/g, 'ů');
        txt = txt.replace(/&#0*?367;/g, 'ů');
        txt = txt.replace(/&uring;/g, 'ů');

        // "U+00170", "LATIN CAPITAL LETTER U WITH DOUBLE ACUTE"
        txt = txt.replace(/&#x0*?170;/g, 'Ű');
        txt = txt.replace(/&#0*?368;/g, 'Ű');
        txt = txt.replace(/&Udblac;/g, 'Ű');

        // "U+00171", "LATIN SMALL LETTER U WITH DOUBLE ACUTE"
        txt = txt.replace(/&#x0*?171;/g, 'ű');
        txt = txt.replace(/&#0*?369;/g, 'ű');
        txt = txt.replace(/&udblac;/g, 'ű');

        // "U+00172", "LATIN CAPITAL LETTER U WITH OGONEK"
        txt = txt.replace(/&#x0*?172;/g, 'Ų');
        txt = txt.replace(/&#0*?370;/g, 'Ų');
        txt = txt.replace(/&Uogon;/g, 'Ų');

        // "U+00173", "LATIN SMALL LETTER U WITH OGONEK"
        txt = txt.replace(/&#x0*?173;/g, 'ų');
        txt = txt.replace(/&#0*?371;/g, 'ų');
        txt = txt.replace(/&uogon;/g, 'ų');

        // "U+00174", "LATIN CAPITAL LETTER W WITH CIRCUMFLEX"
        txt = txt.replace(/&#x0*?174;/g, 'Ŵ');
        txt = txt.replace(/&#0*?372;/g, 'Ŵ');
        txt = txt.replace(/&Wcirc;/g, 'Ŵ');

        // "U+00175", "LATIN SMALL LETTER W WITH CIRCUMFLEX"
        txt = txt.replace(/&#x0*?175;/g, 'ŵ');
        txt = txt.replace(/&#0*?373;/g, 'ŵ');
        txt = txt.replace(/&wcirc;/g, 'ŵ');

        // "U+00176", "LATIN CAPITAL LETTER Y WITH CIRCUMFLEX"
        txt = txt.replace(/&#x0*?176;/g, 'Ŷ');
        txt = txt.replace(/&#0*?374;/g, 'Ŷ');
        txt = txt.replace(/&Ycirc;/g, 'Ŷ');

        // "U+00177", "LATIN SMALL LETTER Y WITH CIRCUMFLEX"
        txt = txt.replace(/&#x0*?177;/g, 'ŷ');
        txt = txt.replace(/&#0*?375;/g, 'ŷ');
        txt = txt.replace(/&ycirc;/g, 'ŷ');

        // "U+00178", "LATIN CAPITAL LETTER Y WITH DIAERESIS"
        txt = txt.replace(/&#x0*?178;/g, 'Ÿ');
        txt = txt.replace(/&#0*?376;/g, 'Ÿ');
        txt = txt.replace(/&Yuml;/g, 'Ÿ');

        // "U+00179", "LATIN CAPITAL LETTER Z WITH ACUTE"
        txt = txt.replace(/&#x0*?179;/g, 'Ź');
        txt = txt.replace(/&#0*?377;/g, 'Ź');
        txt = txt.replace(/&Zacute;/g, 'Ź');

        // "U+0017A", "LATIN SMALL LETTER Z WITH ACUTE"
        txt = txt.replace(/&#x0*?17A;/g, 'ź');
        txt = txt.replace(/&#0*?378;/g, 'ź');
        txt = txt.replace(/&zacute;/g, 'ź');

        // "U+0017B", "LATIN CAPITAL LETTER Z WITH DOT ABOVE"
        txt = txt.replace(/&#x0*?17B;/g, 'Ż');
        txt = txt.replace(/&#0*?379;/g, 'Ż');
        txt = txt.replace(/&Zdot;/g, 'Ż');

        // "U+0017C", "LATIN SMALL LETTER Z WITH DOT ABOVE"
        txt = txt.replace(/&#x0*?17C;/g, 'ż');
        txt = txt.replace(/&#0*?380;/g, 'ż');
        txt = txt.replace(/&zdot;/g, 'ż');

        // "U+0017D", "LATIN CAPITAL LETTER Z WITH CARON"
        txt = txt.replace(/&#x0*?17D;/g, 'Ž');
        txt = txt.replace(/&#0*?381;/g, 'Ž');
        txt = txt.replace(/&Zcaron;/g, 'Ž');

        // "U+0017E", "LATIN SMALL LETTER Z WITH CARON"
        txt = txt.replace(/&#x0*?17E;/g, 'ž');
        txt = txt.replace(/&#0*?382;/g, 'ž');
        txt = txt.replace(/&zcaron;/g, 'ž');

        // "U+00192", "LATIN SMALL LETTER F WITH HOOK"
        txt = txt.replace(/&#x0*?192;/g, 'ƒ');
        txt = txt.replace(/&#0*?402;/g, 'ƒ');
        txt = txt.replace(/&fnof;/g, 'ƒ');

        // "U+001B5", "LATIN CAPITAL LETTER Z WITH STROKE"
        txt = txt.replace(/&#x0*?1B5;/g, 'Ƶ');
        txt = txt.replace(/&#0*?437;/g, 'Ƶ');
        txt = txt.replace(/&imped;/g, 'Ƶ');

        // "U+001F5", "LATIN SMALL LETTER G WITH ACUTE"
        txt = txt.replace(/&#x0*?1F5;/g, 'ǵ');
        txt = txt.replace(/&#0*?501;/g, 'ǵ');
        txt = txt.replace(/&gacute;/g, 'ǵ');

        // "U+00237", "LATIN SMALL LETTER DOTLESS J"
        txt = txt.replace(/&#x0*?237;/g, 'ȷ');
        txt = txt.replace(/&#0*?567;/g, 'ȷ');
        txt = txt.replace(/&jmath;/g, 'ȷ');

        // "U+002C6", "MODIFIER LETTER CIRCUMFLEX ACCENT"
        txt = txt.replace(/&#x0*?2C6;/g, 'ˆ');
        txt = txt.replace(/&#0*?710;/g, 'ˆ');
        txt = txt.replace(/&circ;/g, 'ˆ');

        // "U+002C7", "CARON"
        txt = txt.replace(/&#x0*?2C7;/g, 'ˇ');
        txt = txt.replace(/&#0*?711;/g, 'ˇ');
        txt = txt.replace(/&caron;/g, 'ˇ');
        txt = txt.replace(/&Hacek;/g, 'ˇ');

        // "U+002D8", "BREVE"
        txt = txt.replace(/&#x0*?2D8;/g, '˘');
        txt = txt.replace(/&#0*?728;/g, '˘');
        txt = txt.replace(/&breve;/g, '˘');
        txt = txt.replace(/&Breve;/g, '˘');

        // "U+002D9", "DOT ABOVE"
        txt = txt.replace(/&#x0*?2D9;/g, '˙');
        txt = txt.replace(/&#0*?729;/g, '˙');
        txt = txt.replace(/&dot;/g, '˙');
        txt = txt.replace(/&DiacriticalDot;/g, '˙');

        // "U+002DA", "RING ABOVE"
        txt = txt.replace(/&#x0*?2DA;/g, '˚');
        txt = txt.replace(/&#0*?730;/g, '˚');
        txt = txt.replace(/&ring;/g, '˚');

        // "U+002DB", "OGONEK"
        txt = txt.replace(/&#x0*?2DB;/g, '˛');
        txt = txt.replace(/&#0*?731;/g, '˛');
        txt = txt.replace(/&ogon;/g, '˛');

        // "U+002DC", "SMALL TILDE"
        txt = txt.replace(/&#x0*?2DC;/g, '˜');
        txt = txt.replace(/&#0*?732;/g, '˜');
        txt = txt.replace(/&tilde;/g, '˜');
        txt = txt.replace(/&DiacriticalTilde;/g, '˜');

        // "U+002DD", "DOUBLE ACUTE ACCENT"
        txt = txt.replace(/&#x0*?2DD;/g, '˝');
        txt = txt.replace(/&#0*?733;/g, '˝');
        txt = txt.replace(/&dblac;/g, '˝');
        txt = txt.replace(/&DiacriticalDoubleAcute;/g, '˝');

        // "U+00311", "COMBINING INVERTED BREVE"
        txt = txt.replace(/&#x0*?311;/g, '̑');
        txt = txt.replace(/&#0*?785;/g, '̑');
        txt = txt.replace(/&DownBreve;/g, '̑');

        // "U+00332", "COMBINING LOW LINE"
        txt = txt.replace(/&#x0*?332;/g, '̲');
        txt = txt.replace(/&#0*?818;/g, '̲');
        txt = txt.replace(/&UnderBar;/g, '̲');

        // "U+00391", "GREEK CAPITAL LETTER ALPHA"
        txt = txt.replace(/&#x0*?391;/g, 'Α');
        txt = txt.replace(/&#0*?913;/g, 'Α');
        txt = txt.replace(/&Alpha;/g, 'Α');

        // "U+00392", "GREEK CAPITAL LETTER BETA"
        txt = txt.replace(/&#x0*?392;/g, 'Β');
        txt = txt.replace(/&#0*?914;/g, 'Β');
        txt = txt.replace(/&Beta;/g, 'Β');

        // "U+00393", "GREEK CAPITAL LETTER GAMMA"
        txt = txt.replace(/&#x0*?393;/g, 'Γ');
        txt = txt.replace(/&#0*?915;/g, 'Γ');
        txt = txt.replace(/&Gamma;/g, 'Γ');

        // "U+00394", "GREEK CAPITAL LETTER DELTA"
        txt = txt.replace(/&#x0*?394;/g, 'Δ');
        txt = txt.replace(/&#0*?916;/g, 'Δ');
        txt = txt.replace(/&Delta;/g, 'Δ');

        // "U+00395", "GREEK CAPITAL LETTER EPSILON"
        txt = txt.replace(/&#x0*?395;/g, 'Ε');
        txt = txt.replace(/&#0*?917;/g, 'Ε');
        txt = txt.replace(/&Epsilon;/g, 'Ε');

        // "U+00396", "GREEK CAPITAL LETTER ZETA"
        txt = txt.replace(/&#x0*?396;/g, 'Ζ');
        txt = txt.replace(/&#0*?918;/g, 'Ζ');
        txt = txt.replace(/&Zeta;/g, 'Ζ');

        // "U+00397", "GREEK CAPITAL LETTER ETA"
        txt = txt.replace(/&#x0*?397;/g, 'Η');
        txt = txt.replace(/&#0*?919;/g, 'Η');
        txt = txt.replace(/&Eta;/g, 'Η');

        // "U+00398", "GREEK CAPITAL LETTER THETA"
        txt = txt.replace(/&#x0*?398;/g, 'Θ');
        txt = txt.replace(/&#0*?920;/g, 'Θ');
        txt = txt.replace(/&Theta;/g, 'Θ');

        // "U+00399", "GREEK CAPITAL LETTER IOTA"
        txt = txt.replace(/&#x0*?399;/g, 'Ι');
        txt = txt.replace(/&#0*?921;/g, 'Ι');
        txt = txt.replace(/&Iota;/g, 'Ι');

        // "U+0039A", "GREEK CAPITAL LETTER KAPPA"
        txt = txt.replace(/&#x0*?39A;/g, 'Κ');
        txt = txt.replace(/&#0*?922;/g, 'Κ');
        txt = txt.replace(/&Kappa;/g, 'Κ');

        // "U+0039B", "GREEK CAPITAL LETTER LAMDA"
        txt = txt.replace(/&#x0*?39B;/g, 'Λ');
        txt = txt.replace(/&#0*?923;/g, 'Λ');
        txt = txt.replace(/&Lambda;/g, 'Λ');

        // "U+0039C", "GREEK CAPITAL LETTER MU"
        txt = txt.replace(/&#x0*?39C;/g, 'Μ');
        txt = txt.replace(/&#0*?924;/g, 'Μ');
        txt = txt.replace(/&Mu;/g, 'Μ');

        // "U+0039D", "GREEK CAPITAL LETTER NU"
        txt = txt.replace(/&#x0*?39D;/g, 'Ν');
        txt = txt.replace(/&#0*?925;/g, 'Ν');
        txt = txt.replace(/&Nu;/g, 'Ν');

        // "U+0039E", "GREEK CAPITAL LETTER XI"
        txt = txt.replace(/&#x0*?39E;/g, 'Ξ');
        txt = txt.replace(/&#0*?926;/g, 'Ξ');
        txt = txt.replace(/&Xi;/g, 'Ξ');

        // "U+0039F", "GREEK CAPITAL LETTER OMICRON"
        txt = txt.replace(/&#x0*?39F;/g, 'Ο');
        txt = txt.replace(/&#0*?927;/g, 'Ο');
        txt = txt.replace(/&Omicron;/g, 'Ο');

        // "U+003A0", "GREEK CAPITAL LETTER PI"
        txt = txt.replace(/&#x0*?3A0;/g, 'Π');
        txt = txt.replace(/&#0*?928;/g, 'Π');
        txt = txt.replace(/&Pi;/g, 'Π');

        // "U+003A1", "GREEK CAPITAL LETTER RHO"
        txt = txt.replace(/&#x0*?3A1;/g, 'Ρ');
        txt = txt.replace(/&#0*?929;/g, 'Ρ');
        txt = txt.replace(/&Rho;/g, 'Ρ');

        // "U+003A3", "GREEK CAPITAL LETTER SIGMA"
        txt = txt.replace(/&#x0*?3A3;/g, 'Σ');
        txt = txt.replace(/&#0*?931;/g, 'Σ');
        txt = txt.replace(/&Sigma;/g, 'Σ');

        // "U+003A4", "GREEK CAPITAL LETTER TAU"
        txt = txt.replace(/&#x0*?3A4;/g, 'Τ');
        txt = txt.replace(/&#0*?932;/g, 'Τ');
        txt = txt.replace(/&Tau;/g, 'Τ');

        // "U+003A5", "GREEK CAPITAL LETTER UPSILON"
        txt = txt.replace(/&#x0*?3A5;/g, 'Υ');
        txt = txt.replace(/&#0*?933;/g, 'Υ');
        txt = txt.replace(/&Upsilon;/g, 'Υ');

        // "U+003A6", "GREEK CAPITAL LETTER PHI"
        txt = txt.replace(/&#x0*?3A6;/g, 'Φ');
        txt = txt.replace(/&#0*?934;/g, 'Φ');
        txt = txt.replace(/&Phi;/g, 'Φ');

        // "U+003A7", "GREEK CAPITAL LETTER CHI"
        txt = txt.replace(/&#x0*?3A7;/g, 'Χ');
        txt = txt.replace(/&#0*?935;/g, 'Χ');
        txt = txt.replace(/&Chi;/g, 'Χ');

        // "U+003A8", "GREEK CAPITAL LETTER PSI"
        txt = txt.replace(/&#x0*?3A8;/g, 'Ψ');
        txt = txt.replace(/&#0*?936;/g, 'Ψ');
        txt = txt.replace(/&Psi;/g, 'Ψ');

        // "U+003A9", "GREEK CAPITAL LETTER OMEGA"
        txt = txt.replace(/&#x0*?3A9;/g, 'Ω');
        txt = txt.replace(/&#0*?937;/g, 'Ω');
        txt = txt.replace(/&Omega;/g, 'Ω');

        // "U+003B1", "GREEK SMALL LETTER ALPHA"
        txt = txt.replace(/&#x0*?3B1;/g, 'α');
        txt = txt.replace(/&#0*?945;/g, 'α');
        txt = txt.replace(/&alpha;/g, 'α');

        // "U+003B2", "GREEK SMALL LETTER BETA"
        txt = txt.replace(/&#x0*?3B2;/g, 'β');
        txt = txt.replace(/&#0*?946;/g, 'β');
        txt = txt.replace(/&beta;/g, 'β');

        // "U+003B3", "GREEK SMALL LETTER GAMMA"
        txt = txt.replace(/&#x0*?3B3;/g, 'γ');
        txt = txt.replace(/&#0*?947;/g, 'γ');
        txt = txt.replace(/&gamma;/g, 'γ');

        // "U+003B4", "GREEK SMALL LETTER DELTA"
        txt = txt.replace(/&#x0*?3B4;/g, 'δ');
        txt = txt.replace(/&#0*?948;/g, 'δ');
        txt = txt.replace(/&delta;/g, 'δ');

        // "U+003B5", "GREEK SMALL LETTER EPSILON"
        txt = txt.replace(/&#x0*?3B5;/g, 'ε');
        txt = txt.replace(/&#0*?949;/g, 'ε');
        txt = txt.replace(/&epsiv;/g, 'ε');
        txt = txt.replace(/&varepsilon;/g, 'ε');
        txt = txt.replace(/&epsilon;/g, 'ε');

        // "U+003B6", "GREEK SMALL LETTER ZETA"
        txt = txt.replace(/&#x0*?3B6;/g, 'ζ');
        txt = txt.replace(/&#0*?950;/g, 'ζ');
        txt = txt.replace(/&zeta;/g, 'ζ');

        // "U+003B7", "GREEK SMALL LETTER ETA"
        txt = txt.replace(/&#x0*?3B7;/g, 'η');
        txt = txt.replace(/&#0*?951;/g, 'η');
        txt = txt.replace(/&eta;/g, 'η');

        // "U+003B8", "GREEK SMALL LETTER THETA"
        txt = txt.replace(/&#x0*?3B8;/g, 'θ');
        txt = txt.replace(/&#0*?952;/g, 'θ');
        txt = txt.replace(/&theta;/g, 'θ');

        // "U+003B9", "GREEK SMALL LETTER IOTA"
        txt = txt.replace(/&#x0*?3B9;/g, 'ι');
        txt = txt.replace(/&#0*?953;/g, 'ι');
        txt = txt.replace(/&iota;/g, 'ι');

        // "U+003BA", "GREEK SMALL LETTER KAPPA"
        txt = txt.replace(/&#x0*?3BA;/g, 'κ');
        txt = txt.replace(/&#0*?954;/g, 'κ');
        txt = txt.replace(/&kappa;/g, 'κ');

        // "U+003BB", "GREEK SMALL LETTER LAMDA"
        txt = txt.replace(/&#x0*?3BB;/g, 'λ');
        txt = txt.replace(/&#0*?955;/g, 'λ');
        txt = txt.replace(/&lambda;/g, 'λ');

        // "U+003BC", "GREEK SMALL LETTER MU"
        txt = txt.replace(/&#x0*?3BC;/g, 'μ');
        txt = txt.replace(/&#0*?956;/g, 'μ');
        txt = txt.replace(/&mu;/g, 'μ');

        // "U+003BD", "GREEK SMALL LETTER NU"
        txt = txt.replace(/&#x0*?3BD;/g, 'ν');
        txt = txt.replace(/&#0*?957;/g, 'ν');
        txt = txt.replace(/&nu;/g, 'ν');

        // "U+003BE", "GREEK SMALL LETTER XI"
        txt = txt.replace(/&#x0*?3BE;/g, 'ξ');
        txt = txt.replace(/&#0*?958;/g, 'ξ');
        txt = txt.replace(/&xi;/g, 'ξ');

        // "U+003BF", "GREEK SMALL LETTER OMICRON"
        txt = txt.replace(/&#x0*?3BF;/g, 'ο');
        txt = txt.replace(/&#0*?959;/g, 'ο');
        txt = txt.replace(/&omicron;/g, 'ο');

        // "U+003C0", "GREEK SMALL LETTER PI"
        txt = txt.replace(/&#x0*?3C0;/g, 'π');
        txt = txt.replace(/&#0*?960;/g, 'π');
        txt = txt.replace(/&pi;/g, 'π');

        // "U+003C1", "GREEK SMALL LETTER RHO"
        txt = txt.replace(/&#x0*?3C1;/g, 'ρ');
        txt = txt.replace(/&#0*?961;/g, 'ρ');
        txt = txt.replace(/&rho;/g, 'ρ');

        // "U+003C2", "GREEK SMALL LETTER FINAL SIGMA"
        txt = txt.replace(/&#x0*?3C2;/g, 'ς');
        txt = txt.replace(/&#0*?962;/g, 'ς');
        txt = txt.replace(/&sigmav;/g, 'ς');
        txt = txt.replace(/&varsigma;/g, 'ς');
        txt = txt.replace(/&sigmaf;/g, 'ς');

        // "U+003C3", "GREEK SMALL LETTER SIGMA"
        txt = txt.replace(/&#x0*?3C3;/g, 'σ');
        txt = txt.replace(/&#0*?963;/g, 'σ');
        txt = txt.replace(/&sigma;/g, 'σ');

        // "U+003C4", "GREEK SMALL LETTER TAU"
        txt = txt.replace(/&#x0*?3C4;/g, 'τ');
        txt = txt.replace(/&#0*?964;/g, 'τ');
        txt = txt.replace(/&tau;/g, 'τ');

        // "U+003C5", "GREEK SMALL LETTER UPSILON"
        txt = txt.replace(/&#x0*?3C5;/g, 'υ');
        txt = txt.replace(/&#0*?965;/g, 'υ');
        txt = txt.replace(/&upsi;/g, 'υ');
        txt = txt.replace(/&upsilon;/g, 'υ');

        // "U+003C6", "GREEK SMALL LETTER PHI"
        txt = txt.replace(/&#x0*?3C6;/g, 'φ');
        txt = txt.replace(/&#0*?966;/g, 'φ');
        txt = txt.replace(/&phi;/g, 'φ');
        txt = txt.replace(/&phiv;/g, 'φ');
        txt = txt.replace(/&varphi;/g, 'φ');

        // "U+003C7", "GREEK SMALL LETTER CHI"
        txt = txt.replace(/&#x0*?3C7;/g, 'χ');
        txt = txt.replace(/&#0*?967;/g, 'χ');
        txt = txt.replace(/&chi;/g, 'χ');

        // "U+003C8", "GREEK SMALL LETTER PSI"
        txt = txt.replace(/&#x0*?3C8;/g, 'ψ');
        txt = txt.replace(/&#0*?968;/g, 'ψ');
        txt = txt.replace(/&psi;/g, 'ψ');

        // "U+003C9", "GREEK SMALL LETTER OMEGA"
        txt = txt.replace(/&#x0*?3C9;/g, 'ω');
        txt = txt.replace(/&#0*?969;/g, 'ω');
        txt = txt.replace(/&omega;/g, 'ω');

        // "U+003D1", "GREEK THETA SYMBOL"
        txt = txt.replace(/&#x0*?3D1;/g, 'ϑ');
        txt = txt.replace(/&#0*?977;/g, 'ϑ');
        txt = txt.replace(/&thetav;/g, 'ϑ');
        txt = txt.replace(/&vartheta;/g, 'ϑ');
        txt = txt.replace(/&thetasym;/g, 'ϑ');

        // "U+003D2", "GREEK UPSILON WITH HOOK SYMBOL"
        txt = txt.replace(/&#x0*?3D2;/g, 'ϒ');
        txt = txt.replace(/&#0*?978;/g, 'ϒ');
        txt = txt.replace(/&Upsi;/g, 'ϒ');
        txt = txt.replace(/&upsih;/g, 'ϒ');

        // "U+003D5", "GREEK PHI SYMBOL"
        txt = txt.replace(/&#x0*?3D5;/g, 'ϕ');
        txt = txt.replace(/&#0*?981;/g, 'ϕ');
        txt = txt.replace(/&straightphi;/g, 'ϕ');

        // "U+003D6", "GREEK PI SYMBOL"
        txt = txt.replace(/&#x0*?3D6;/g, 'ϖ');
        txt = txt.replace(/&#0*?982;/g, 'ϖ');
        txt = txt.replace(/&piv;/g, 'ϖ');
        txt = txt.replace(/&varpi;/g, 'ϖ');

        // "U+003DC", "GREEK LETTER DIGAMMA"
        txt = txt.replace(/&#x0*?3DC;/g, 'Ϝ');
        txt = txt.replace(/&#0*?988;/g, 'Ϝ');
        txt = txt.replace(/&Gammad;/g, 'Ϝ');

        // "U+003DD", "GREEK SMALL LETTER DIGAMMA"
        txt = txt.replace(/&#x0*?3DD;/g, 'ϝ');
        txt = txt.replace(/&#0*?989;/g, 'ϝ');
        txt = txt.replace(/&gammad;/g, 'ϝ');
        txt = txt.replace(/&digamma;/g, 'ϝ');

        // "U+003F0", "GREEK KAPPA SYMBOL"
        txt = txt.replace(/&#x0*?3F0;/g, 'ϰ');
        txt = txt.replace(/&#0*?1008;/g, 'ϰ');
        txt = txt.replace(/&kappav;/g, 'ϰ');
        txt = txt.replace(/&varkappa;/g, 'ϰ');

        // "U+003F1", "GREEK RHO SYMBOL"
        txt = txt.replace(/&#x0*?3F1;/g, 'ϱ');
        txt = txt.replace(/&#0*?1009;/g, 'ϱ');
        txt = txt.replace(/&rhov;/g, 'ϱ');
        txt = txt.replace(/&varrho;/g, 'ϱ');

        // "U+003F5", "GREEK LUNATE EPSILON SYMBOL"
        txt = txt.replace(/&#x0*?3F5;/g, 'ϵ');
        txt = txt.replace(/&#0*?1013;/g, 'ϵ');
        txt = txt.replace(/&epsi;/g, 'ϵ');
        txt = txt.replace(/&straightepsilon;/g, 'ϵ');

        // "U+003F6", "GREEK REVERSED LUNATE EPSILON SYMBOL"
        txt = txt.replace(/&#x0*?3F6;/g, '϶');
        txt = txt.replace(/&#0*?1014;/g, '϶');
        txt = txt.replace(/&bepsi;/g, '϶');
        txt = txt.replace(/&backepsilon;/g, '϶');

        // "U+00401", "CYRILLIC CAPITAL LETTER IO"
        txt = txt.replace(/&#x0*?401;/g, 'Ё');
        txt = txt.replace(/&#0*?1025;/g, 'Ё');
        txt = txt.replace(/&IOcy;/g, 'Ё');

        // "U+00402", "CYRILLIC CAPITAL LETTER DJE"
        txt = txt.replace(/&#x0*?402;/g, 'Ђ');
        txt = txt.replace(/&#0*?1026;/g, 'Ђ');
        txt = txt.replace(/&DJcy;/g, 'Ђ');

        // "U+00403", "CYRILLIC CAPITAL LETTER GJE"
        txt = txt.replace(/&#x0*?403;/g, 'Ѓ');
        txt = txt.replace(/&#0*?1027;/g, 'Ѓ');
        txt = txt.replace(/&GJcy;/g, 'Ѓ');

        // "U+00404", "CYRILLIC CAPITAL LETTER UKRAINIAN IE"
        txt = txt.replace(/&#x0*?404;/g, 'Є');
        txt = txt.replace(/&#0*?1028;/g, 'Є');
        txt = txt.replace(/&Jukcy;/g, 'Є');

        // "U+00405", "CYRILLIC CAPITAL LETTER DZE"
        txt = txt.replace(/&#x0*?405;/g, 'Ѕ');
        txt = txt.replace(/&#0*?1029;/g, 'Ѕ');
        txt = txt.replace(/&DScy;/g, 'Ѕ');

        // "U+00406", "CYRILLIC CAPITAL LETTER BYELORUSSIAN-UKRAINIAN I"
        txt = txt.replace(/&#x0*?406;/g, 'І');
        txt = txt.replace(/&#0*?1030;/g, 'І');
        txt = txt.replace(/&Iukcy;/g, 'І');

        // "U+00407", "CYRILLIC CAPITAL LETTER YI"
        txt = txt.replace(/&#x0*?407;/g, 'Ї');
        txt = txt.replace(/&#0*?1031;/g, 'Ї');
        txt = txt.replace(/&YIcy;/g, 'Ї');

        // "U+00408", "CYRILLIC CAPITAL LETTER JE"
        txt = txt.replace(/&#x0*?408;/g, 'Ј');
        txt = txt.replace(/&#0*?1032;/g, 'Ј');
        txt = txt.replace(/&Jsercy;/g, 'Ј');

        // "U+00409", "CYRILLIC CAPITAL LETTER LJE"
        txt = txt.replace(/&#x0*?409;/g, 'Љ');
        txt = txt.replace(/&#0*?1033;/g, 'Љ');
        txt = txt.replace(/&LJcy;/g, 'Љ');

        // "U+0040A", "CYRILLIC CAPITAL LETTER NJE"
        txt = txt.replace(/&#x0*?40A;/g, 'Њ');
        txt = txt.replace(/&#0*?1034;/g, 'Њ');
        txt = txt.replace(/&NJcy;/g, 'Њ');

        // "U+0040B", "CYRILLIC CAPITAL LETTER TSHE"
        txt = txt.replace(/&#x0*?40B;/g, 'Ћ');
        txt = txt.replace(/&#0*?1035;/g, 'Ћ');
        txt = txt.replace(/&TSHcy;/g, 'Ћ');

        // "U+0040C", "CYRILLIC CAPITAL LETTER KJE"
        txt = txt.replace(/&#x0*?40C;/g, 'Ќ');
        txt = txt.replace(/&#0*?1036;/g, 'Ќ');
        txt = txt.replace(/&KJcy;/g, 'Ќ');

        // "U+0040E", "CYRILLIC CAPITAL LETTER SHORT U"
        txt = txt.replace(/&#x0*?40E;/g, 'Ў');
        txt = txt.replace(/&#0*?1038;/g, 'Ў');
        txt = txt.replace(/&Ubrcy;/g, 'Ў');

        // "U+0040F", "CYRILLIC CAPITAL LETTER DZHE"
        txt = txt.replace(/&#x0*?40F;/g, 'Џ');
        txt = txt.replace(/&#0*?1039;/g, 'Џ');
        txt = txt.replace(/&DZcy;/g, 'Џ');

        // "U+00410", "CYRILLIC CAPITAL LETTER A"
        txt = txt.replace(/&#x0*?410;/g, 'А');
        txt = txt.replace(/&#0*?1040;/g, 'А');
        txt = txt.replace(/&Acy;/g, 'А');

        // "U+00411", "CYRILLIC CAPITAL LETTER BE"
        txt = txt.replace(/&#x0*?411;/g, 'Б');
        txt = txt.replace(/&#0*?1041;/g, 'Б');
        txt = txt.replace(/&Bcy;/g, 'Б');

        // "U+00412", "CYRILLIC CAPITAL LETTER VE"
        txt = txt.replace(/&#x0*?412;/g, 'В');
        txt = txt.replace(/&#0*?1042;/g, 'В');
        txt = txt.replace(/&Vcy;/g, 'В');

        // "U+00413", "CYRILLIC CAPITAL LETTER GHE"
        txt = txt.replace(/&#x0*?413;/g, 'Г');
        txt = txt.replace(/&#0*?1043;/g, 'Г');
        txt = txt.replace(/&Gcy;/g, 'Г');

        // "U+00414", "CYRILLIC CAPITAL LETTER DE"
        txt = txt.replace(/&#x0*?414;/g, 'Д');
        txt = txt.replace(/&#0*?1044;/g, 'Д');
        txt = txt.replace(/&Dcy;/g, 'Д');

        // "U+00415", "CYRILLIC CAPITAL LETTER IE"
        txt = txt.replace(/&#x0*?415;/g, 'Е');
        txt = txt.replace(/&#0*?1045;/g, 'Е');
        txt = txt.replace(/&IEcy;/g, 'Е');

        // "U+00416", "CYRILLIC CAPITAL LETTER ZHE"
        txt = txt.replace(/&#x0*?416;/g, 'Ж');
        txt = txt.replace(/&#0*?1046;/g, 'Ж');
        txt = txt.replace(/&ZHcy;/g, 'Ж');

        // "U+00417", "CYRILLIC CAPITAL LETTER ZE"
        txt = txt.replace(/&#x0*?417;/g, 'З');
        txt = txt.replace(/&#0*?1047;/g, 'З');
        txt = txt.replace(/&Zcy;/g, 'З');

        // "U+00418", "CYRILLIC CAPITAL LETTER I"
        txt = txt.replace(/&#x0*?418;/g, 'И');
        txt = txt.replace(/&#0*?1048;/g, 'И');
        txt = txt.replace(/&Icy;/g, 'И');

        // "U+00419", "CYRILLIC CAPITAL LETTER SHORT I"
        txt = txt.replace(/&#x0*?419;/g, 'Й');
        txt = txt.replace(/&#0*?1049;/g, 'Й');
        txt = txt.replace(/&Jcy;/g, 'Й');

        // "U+0041A", "CYRILLIC CAPITAL LETTER KA"
        txt = txt.replace(/&#x0*?41A;/g, 'К');
        txt = txt.replace(/&#0*?1050;/g, 'К');
        txt = txt.replace(/&Kcy;/g, 'К');

        // "U+0041B", "CYRILLIC CAPITAL LETTER EL"
        txt = txt.replace(/&#x0*?41B;/g, 'Л');
        txt = txt.replace(/&#0*?1051;/g, 'Л');
        txt = txt.replace(/&Lcy;/g, 'Л');

        // "U+0041C", "CYRILLIC CAPITAL LETTER EM"
        txt = txt.replace(/&#x0*?41C;/g, 'М');
        txt = txt.replace(/&#0*?1052;/g, 'М');
        txt = txt.replace(/&Mcy;/g, 'М');

        // "U+0041D", "CYRILLIC CAPITAL LETTER EN"
        txt = txt.replace(/&#x0*?41D;/g, 'Н');
        txt = txt.replace(/&#0*?1053;/g, 'Н');
        txt = txt.replace(/&Ncy;/g, 'Н');

        // "U+0041E", "CYRILLIC CAPITAL LETTER O"
        txt = txt.replace(/&#x0*?41E;/g, 'О');
        txt = txt.replace(/&#0*?1054;/g, 'О');
        txt = txt.replace(/&Ocy;/g, 'О');

        // "U+0041F", "CYRILLIC CAPITAL LETTER PE"
        txt = txt.replace(/&#x0*?41F;/g, 'П');
        txt = txt.replace(/&#0*?1055;/g, 'П');
        txt = txt.replace(/&Pcy;/g, 'П');

        // "U+00420", "CYRILLIC CAPITAL LETTER ER"
        txt = txt.replace(/&#x0*?420;/g, 'Р');
        txt = txt.replace(/&#0*?1056;/g, 'Р');
        txt = txt.replace(/&Rcy;/g, 'Р');

        // "U+00421", "CYRILLIC CAPITAL LETTER ES"
        txt = txt.replace(/&#x0*?421;/g, 'С');
        txt = txt.replace(/&#0*?1057;/g, 'С');
        txt = txt.replace(/&Scy;/g, 'С');

        // "U+00422", "CYRILLIC CAPITAL LETTER TE"
        txt = txt.replace(/&#x0*?422;/g, 'Т');
        txt = txt.replace(/&#0*?1058;/g, 'Т');
        txt = txt.replace(/&Tcy;/g, 'Т');

        // "U+00423", "CYRILLIC CAPITAL LETTER U"
        txt = txt.replace(/&#x0*?423;/g, 'У');
        txt = txt.replace(/&#0*?1059;/g, 'У');
        txt = txt.replace(/&Ucy;/g, 'У');

        // "U+00424", "CYRILLIC CAPITAL LETTER EF"
        txt = txt.replace(/&#x0*?424;/g, 'Ф');
        txt = txt.replace(/&#0*?1060;/g, 'Ф');
        txt = txt.replace(/&Fcy;/g, 'Ф');

        // "U+00425", "CYRILLIC CAPITAL LETTER HA"
        txt = txt.replace(/&#x0*?425;/g, 'Х');
        txt = txt.replace(/&#0*?1061;/g, 'Х');
        txt = txt.replace(/&KHcy;/g, 'Х');

        // "U+00426", "CYRILLIC CAPITAL LETTER TSE"
        txt = txt.replace(/&#x0*?426;/g, 'Ц');
        txt = txt.replace(/&#0*?1062;/g, 'Ц');
        txt = txt.replace(/&TScy;/g, 'Ц');

        // "U+00427", "CYRILLIC CAPITAL LETTER CHE"
        txt = txt.replace(/&#x0*?427;/g, 'Ч');
        txt = txt.replace(/&#0*?1063;/g, 'Ч');
        txt = txt.replace(/&CHcy;/g, 'Ч');

        // "U+00428", "CYRILLIC CAPITAL LETTER SHA"
        txt = txt.replace(/&#x0*?428;/g, 'Ш');
        txt = txt.replace(/&#0*?1064;/g, 'Ш');
        txt = txt.replace(/&SHcy;/g, 'Ш');

        // "U+00429", "CYRILLIC CAPITAL LETTER SHCHA"
        txt = txt.replace(/&#x0*?429;/g, 'Щ');
        txt = txt.replace(/&#0*?1065;/g, 'Щ');
        txt = txt.replace(/&SHCHcy;/g, 'Щ');

        // "U+0042A", "CYRILLIC CAPITAL LETTER HARD SIGN"
        txt = txt.replace(/&#x0*?42A;/g, 'Ъ');
        txt = txt.replace(/&#0*?1066;/g, 'Ъ');
        txt = txt.replace(/&HARDcy;/g, 'Ъ');

        // "U+0042B", "CYRILLIC CAPITAL LETTER YERU"
        txt = txt.replace(/&#x0*?42B;/g, 'Ы');
        txt = txt.replace(/&#0*?1067;/g, 'Ы');
        txt = txt.replace(/&Ycy;/g, 'Ы');

        // "U+0042C", "CYRILLIC CAPITAL LETTER SOFT SIGN"
        txt = txt.replace(/&#x0*?42C;/g, 'Ь');
        txt = txt.replace(/&#0*?1068;/g, 'Ь');
        txt = txt.replace(/&SOFTcy;/g, 'Ь');

        // "U+0042D", "CYRILLIC CAPITAL LETTER E"
        txt = txt.replace(/&#x0*?42D;/g, 'Э');
        txt = txt.replace(/&#0*?1069;/g, 'Э');
        txt = txt.replace(/&Ecy;/g, 'Э');

        // "U+0042E", "CYRILLIC CAPITAL LETTER YU"
        txt = txt.replace(/&#x0*?42E;/g, 'Ю');
        txt = txt.replace(/&#0*?1070;/g, 'Ю');
        txt = txt.replace(/&YUcy;/g, 'Ю');

        // "U+0042F", "CYRILLIC CAPITAL LETTER YA"
        txt = txt.replace(/&#x0*?42F;/g, 'Я');
        txt = txt.replace(/&#0*?1071;/g, 'Я');
        txt = txt.replace(/&YAcy;/g, 'Я');

        // "U+00430", "CYRILLIC SMALL LETTER A"
        txt = txt.replace(/&#x0*?430;/g, 'а');
        txt = txt.replace(/&#0*?1072;/g, 'а');
        txt = txt.replace(/&acy;/g, 'а');

        // "U+00431", "CYRILLIC SMALL LETTER BE"
        txt = txt.replace(/&#x0*?431;/g, 'б');
        txt = txt.replace(/&#0*?1073;/g, 'б');
        txt = txt.replace(/&bcy;/g, 'б');

        // "U+00432", "CYRILLIC SMALL LETTER VE"
        txt = txt.replace(/&#x0*?432;/g, 'в');
        txt = txt.replace(/&#0*?1074;/g, 'в');
        txt = txt.replace(/&vcy;/g, 'в');

        // "U+00433", "CYRILLIC SMALL LETTER GHE"
        txt = txt.replace(/&#x0*?433;/g, 'г');
        txt = txt.replace(/&#0*?1075;/g, 'г');
        txt = txt.replace(/&gcy;/g, 'г');

        // "U+00434", "CYRILLIC SMALL LETTER DE"
        txt = txt.replace(/&#x0*?434;/g, 'д');
        txt = txt.replace(/&#0*?1076;/g, 'д');
        txt = txt.replace(/&dcy;/g, 'д');

        // "U+00435", "CYRILLIC SMALL LETTER IE"
        txt = txt.replace(/&#x0*?435;/g, 'е');
        txt = txt.replace(/&#0*?1077;/g, 'е');
        txt = txt.replace(/&iecy;/g, 'е');

        // "U+00436", "CYRILLIC SMALL LETTER ZHE"
        txt = txt.replace(/&#x0*?436;/g, 'ж');
        txt = txt.replace(/&#0*?1078;/g, 'ж');
        txt = txt.replace(/&zhcy;/g, 'ж');

        // "U+00437", "CYRILLIC SMALL LETTER ZE"
        txt = txt.replace(/&#x0*?437;/g, 'з');
        txt = txt.replace(/&#0*?1079;/g, 'з');
        txt = txt.replace(/&zcy;/g, 'з');

        // "U+00438", "CYRILLIC SMALL LETTER I"
        txt = txt.replace(/&#x0*?438;/g, 'и');
        txt = txt.replace(/&#0*?1080;/g, 'и');
        txt = txt.replace(/&icy;/g, 'и');

        // "U+00439", "CYRILLIC SMALL LETTER SHORT I"
        txt = txt.replace(/&#x0*?439;/g, 'й');
        txt = txt.replace(/&#0*?1081;/g, 'й');
        txt = txt.replace(/&jcy;/g, 'й');

        // "U+0043A", "CYRILLIC SMALL LETTER KA"
        txt = txt.replace(/&#x0*?43A;/g, 'к');
        txt = txt.replace(/&#0*?1082;/g, 'к');
        txt = txt.replace(/&kcy;/g, 'к');

        // "U+0043B", "CYRILLIC SMALL LETTER EL"
        txt = txt.replace(/&#x0*?43B;/g, 'л');
        txt = txt.replace(/&#0*?1083;/g, 'л');
        txt = txt.replace(/&lcy;/g, 'л');

        // "U+0043C", "CYRILLIC SMALL LETTER EM"
        txt = txt.replace(/&#x0*?43C;/g, 'м');
        txt = txt.replace(/&#0*?1084;/g, 'м');
        txt = txt.replace(/&mcy;/g, 'м');

        // "U+0043D", "CYRILLIC SMALL LETTER EN"
        txt = txt.replace(/&#x0*?43D;/g, 'н');
        txt = txt.replace(/&#0*?1085;/g, 'н');
        txt = txt.replace(/&ncy;/g, 'н');

        // "U+0043E", "CYRILLIC SMALL LETTER O"
        txt = txt.replace(/&#x0*?43E;/g, 'о');
        txt = txt.replace(/&#0*?1086;/g, 'о');
        txt = txt.replace(/&ocy;/g, 'о');

        // "U+0043F", "CYRILLIC SMALL LETTER PE"
        txt = txt.replace(/&#x0*?43F;/g, 'п');
        txt = txt.replace(/&#0*?1087;/g, 'п');
        txt = txt.replace(/&pcy;/g, 'п');

        // "U+00440", "CYRILLIC SMALL LETTER ER"
        txt = txt.replace(/&#x0*?440;/g, 'р');
        txt = txt.replace(/&#0*?1088;/g, 'р');
        txt = txt.replace(/&rcy;/g, 'р');

        // "U+00441", "CYRILLIC SMALL LETTER ES"
        txt = txt.replace(/&#x0*?441;/g, 'с');
        txt = txt.replace(/&#0*?1089;/g, 'с');
        txt = txt.replace(/&scy;/g, 'с');

        // "U+00442", "CYRILLIC SMALL LETTER TE"
        txt = txt.replace(/&#x0*?442;/g, 'т');
        txt = txt.replace(/&#0*?1090;/g, 'т');
        txt = txt.replace(/&tcy;/g, 'т');

        // "U+00443", "CYRILLIC SMALL LETTER U"
        txt = txt.replace(/&#x0*?443;/g, 'у');
        txt = txt.replace(/&#0*?1091;/g, 'у');
        txt = txt.replace(/&ucy;/g, 'у');

        // "U+00444", "CYRILLIC SMALL LETTER EF"
        txt = txt.replace(/&#x0*?444;/g, 'ф');
        txt = txt.replace(/&#0*?1092;/g, 'ф');
        txt = txt.replace(/&fcy;/g, 'ф');

        // "U+00445", "CYRILLIC SMALL LETTER HA"
        txt = txt.replace(/&#x0*?445;/g, 'х');
        txt = txt.replace(/&#0*?1093;/g, 'х');
        txt = txt.replace(/&khcy;/g, 'х');

        // "U+00446", "CYRILLIC SMALL LETTER TSE"
        txt = txt.replace(/&#x0*?446;/g, 'ц');
        txt = txt.replace(/&#0*?1094;/g, 'ц');
        txt = txt.replace(/&tscy;/g, 'ц');

        // "U+00447", "CYRILLIC SMALL LETTER CHE"
        txt = txt.replace(/&#x0*?447;/g, 'ч');
        txt = txt.replace(/&#0*?1095;/g, 'ч');
        txt = txt.replace(/&chcy;/g, 'ч');

        // "U+00448", "CYRILLIC SMALL LETTER SHA"
        txt = txt.replace(/&#x0*?448;/g, 'ш');
        txt = txt.replace(/&#0*?1096;/g, 'ш');
        txt = txt.replace(/&shcy;/g, 'ш');

        // "U+00449", "CYRILLIC SMALL LETTER SHCHA"
        txt = txt.replace(/&#x0*?449;/g, 'щ');
        txt = txt.replace(/&#0*?1097;/g, 'щ');
        txt = txt.replace(/&shchcy;/g, 'щ');

        // "U+0044A", "CYRILLIC SMALL LETTER HARD SIGN"
        txt = txt.replace(/&#x0*?44A;/g, 'ъ');
        txt = txt.replace(/&#0*?1098;/g, 'ъ');
        txt = txt.replace(/&hardcy;/g, 'ъ');

        // "U+0044B", "CYRILLIC SMALL LETTER YERU"
        txt = txt.replace(/&#x0*?44B;/g, 'ы');
        txt = txt.replace(/&#0*?1099;/g, 'ы');
        txt = txt.replace(/&ycy;/g, 'ы');

        // "U+0044C", "CYRILLIC SMALL LETTER SOFT SIGN"
        txt = txt.replace(/&#x0*?44C;/g, 'ь');
        txt = txt.replace(/&#0*?1100;/g, 'ь');
        txt = txt.replace(/&softcy;/g, 'ь');

        // "U+0044D", "CYRILLIC SMALL LETTER E"
        txt = txt.replace(/&#x0*?44D;/g, 'э');
        txt = txt.replace(/&#0*?1101;/g, 'э');
        txt = txt.replace(/&ecy;/g, 'э');

        // "U+0044E", "CYRILLIC SMALL LETTER YU"
        txt = txt.replace(/&#x0*?44E;/g, 'ю');
        txt = txt.replace(/&#0*?1102;/g, 'ю');
        txt = txt.replace(/&yucy;/g, 'ю');

        // "U+0044F", "CYRILLIC SMALL LETTER YA"
        txt = txt.replace(/&#x0*?44F;/g, 'я');
        txt = txt.replace(/&#0*?1103;/g, 'я');
        txt = txt.replace(/&yacy;/g, 'я');

        // "U+00451", "CYRILLIC SMALL LETTER IO"
        txt = txt.replace(/&#x0*?451;/g, 'ё');
        txt = txt.replace(/&#0*?1105;/g, 'ё');
        txt = txt.replace(/&iocy;/g, 'ё');

        // "U+00452", "CYRILLIC SMALL LETTER DJE"
        txt = txt.replace(/&#x0*?452;/g, 'ђ');
        txt = txt.replace(/&#0*?1106;/g, 'ђ');
        txt = txt.replace(/&djcy;/g, 'ђ');

        // "U+00453", "CYRILLIC SMALL LETTER GJE"
        txt = txt.replace(/&#x0*?453;/g, 'ѓ');
        txt = txt.replace(/&#0*?1107;/g, 'ѓ');
        txt = txt.replace(/&gjcy;/g, 'ѓ');

        // "U+00454", "CYRILLIC SMALL LETTER UKRAINIAN IE"
        txt = txt.replace(/&#x0*?454;/g, 'є');
        txt = txt.replace(/&#0*?1108;/g, 'є');
        txt = txt.replace(/&jukcy;/g, 'є');

        // "U+00455", "CYRILLIC SMALL LETTER DZE"
        txt = txt.replace(/&#x0*?455;/g, 'ѕ');
        txt = txt.replace(/&#0*?1109;/g, 'ѕ');
        txt = txt.replace(/&dscy;/g, 'ѕ');

        // "U+00456", "CYRILLIC SMALL LETTER BYELORUSSIAN-UKRAINIAN I"
        txt = txt.replace(/&#x0*?456;/g, 'і');
        txt = txt.replace(/&#0*?1110;/g, 'і');
        txt = txt.replace(/&iukcy;/g, 'і');

        // "U+00457", "CYRILLIC SMALL LETTER YI"
        txt = txt.replace(/&#x0*?457;/g, 'ї');
        txt = txt.replace(/&#0*?1111;/g, 'ї');
        txt = txt.replace(/&yicy;/g, 'ї');

        // "U+00458", "CYRILLIC SMALL LETTER JE"
        txt = txt.replace(/&#x0*?458;/g, 'ј');
        txt = txt.replace(/&#0*?1112;/g, 'ј');
        txt = txt.replace(/&jsercy;/g, 'ј');

        // "U+00459", "CYRILLIC SMALL LETTER LJE"
        txt = txt.replace(/&#x0*?459;/g, 'љ');
        txt = txt.replace(/&#0*?1113;/g, 'љ');
        txt = txt.replace(/&ljcy;/g, 'љ');

        // "U+0045A", "CYRILLIC SMALL LETTER NJE"
        txt = txt.replace(/&#x0*?45A;/g, 'њ');
        txt = txt.replace(/&#0*?1114;/g, 'њ');
        txt = txt.replace(/&njcy;/g, 'њ');

        // "U+0045B", "CYRILLIC SMALL LETTER TSHE"
        txt = txt.replace(/&#x0*?45B;/g, 'ћ');
        txt = txt.replace(/&#0*?1115;/g, 'ћ');
        txt = txt.replace(/&tshcy;/g, 'ћ');

        // "U+0045C", "CYRILLIC SMALL LETTER KJE"
        txt = txt.replace(/&#x0*?45C;/g, 'ќ');
        txt = txt.replace(/&#0*?1116;/g, 'ќ');
        txt = txt.replace(/&kjcy;/g, 'ќ');

        // "U+0045E", "CYRILLIC SMALL LETTER SHORT U"
        txt = txt.replace(/&#x0*?45E;/g, 'ў');
        txt = txt.replace(/&#0*?1118;/g, 'ў');
        txt = txt.replace(/&ubrcy;/g, 'ў');

        // "U+0045F", "CYRILLIC SMALL LETTER DZHE"
        txt = txt.replace(/&#x0*?45F;/g, 'џ');
        txt = txt.replace(/&#0*?1119;/g, 'џ');
        txt = txt.replace(/&dzcy;/g, 'џ');

        // "U+02002", "EN SPACE"
        txt = txt.replace(/&#x0*?2002;/g, ' ');
        txt = txt.replace(/&#0*?8194;/g, ' ');
        txt = txt.replace(/&ensp;/g, ' ');

        // "U+02003", "EM SPACE"
        txt = txt.replace(/&#x0*?2003;/g, ' ');
        txt = txt.replace(/&#0*?8195;/g, ' ');
        txt = txt.replace(/&emsp;/g, ' ');

        // "U+02004", "THREE-PER-EM SPACE"
        txt = txt.replace(/&#x0*?2004;/g, ' ');
        txt = txt.replace(/&#0*?8196;/g, ' ');
        txt = txt.replace(/&emsp13;/g, ' ');

        // "U+02005", "FOUR-PER-EM SPACE"
        txt = txt.replace(/&#x0*?2005;/g, ' ');
        txt = txt.replace(/&#0*?8197;/g, ' ');
        txt = txt.replace(/&emsp14;/g, ' ');

        // "U+02007", "FIGURE SPACE"
        txt = txt.replace(/&#x0*?2007;/g, ' ');
        txt = txt.replace(/&#0*?8199;/g, ' ');
        txt = txt.replace(/&numsp;/g, ' ');

        // "U+02008", "PUNCTUATION SPACE"
        txt = txt.replace(/&#x0*?2008;/g, ' ');
        txt = txt.replace(/&#0*?8200;/g, ' ');
        txt = txt.replace(/&puncsp;/g, ' ');

        // "U+02009", "THIN SPACE"
        txt = txt.replace(/&#x0*?2009;/g, ' ');
        txt = txt.replace(/&#0*?8201;/g, ' ');
        txt = txt.replace(/&thinsp;/g, ' ');
        txt = txt.replace(/&ThinSpace;/g, ' ');

        // "U+0200A", "HAIR SPACE"
        txt = txt.replace(/&#x0*?200A;/g, ' ');
        txt = txt.replace(/&#0*?8202;/g, ' ');
        txt = txt.replace(/&hairsp;/g, ' ');
        txt = txt.replace(/&VeryThinSpace;/g, ' ');

        // "U+0200B", "ZERO WIDTH SPACE"
        txt = txt.replace(/&#x0*?200B;/g, '​');
        txt = txt.replace(/&#0*?8203;/g, '​');
        txt = txt.replace(/&ZeroWidthSpace;/g, '​');
        txt = txt.replace(/&NegativeVeryThinSpace;/g, '​');
        txt = txt.replace(/&NegativeThinSpace;/g, '​');
        txt = txt.replace(/&NegativeMediumSpace;/g, '​');
        txt = txt.replace(/&NegativeThickSpace;/g, '​');

        // "U+0200C", "ZERO WIDTH NON-JOINER"
        txt = txt.replace(/&#x0*?200C;/g, '‌');
        txt = txt.replace(/&#0*?8204;/g, '‌');
        txt = txt.replace(/&zwnj;/g, '‌');

        // "U+0200D", "ZERO WIDTH JOINER"
        txt = txt.replace(/&#x0*?200D;/g, '‍');
        txt = txt.replace(/&#0*?8205;/g, '‍');
        txt = txt.replace(/&zwj;/g, '‍');

        // "U+0200E", "LEFT-TO-RIGHT MARK"
        txt = txt.replace(/&#x0*?200E;/g, '‎');
        txt = txt.replace(/&#0*?8206;/g, '‎');
        txt = txt.replace(/&lrm;/g, '‎');

        // "U+0200F", "RIGHT-TO-LEFT MARK"
        txt = txt.replace(/&#x0*?200F;/g, '‏');
        txt = txt.replace(/&#0*?8207;/g, '‏');
        txt = txt.replace(/&rlm;/g, '‏');

        // "U+02010", "HYPHEN"
        txt = txt.replace(/&#x0*?2010;/g, '‐');
        txt = txt.replace(/&#0*?8208;/g, '‐');
        txt = txt.replace(/&hyphen;/g, '‐');
        txt = txt.replace(/&dash;/g, '‐');

        // "U+02013", "EN DASH"
        txt = txt.replace(/&#x0*?2013;/g, '–');
        txt = txt.replace(/&#0*?8211;/g, '–');
        txt = txt.replace(/&ndash;/g, '–');

        // "U+02014", "EM DASH"
        txt = txt.replace(/&#x0*?2014;/g, '—');
        txt = txt.replace(/&#0*?8212;/g, '—');
        txt = txt.replace(/&mdash;/g, '—');

        // "U+02015", "HORIZONTAL BAR"
        txt = txt.replace(/&#x0*?2015;/g, '―');
        txt = txt.replace(/&#0*?8213;/g, '―');
        txt = txt.replace(/&horbar;/g, '―');

        // "U+02016", "DOUBLE VERTICAL LINE"
        txt = txt.replace(/&#x0*?2016;/g, '‖');
        txt = txt.replace(/&#0*?8214;/g, '‖');
        txt = txt.replace(/&Verbar;/g, '‖');
        txt = txt.replace(/&Vert;/g, '‖');

        // "U+02018", "LEFT SINGLE QUOTATION MARK"
        txt = txt.replace(/&#x0*?2018;/g, '‘');
        txt = txt.replace(/&#0*?8216;/g, '‘');
        txt = txt.replace(/&lsquo;/g, '‘');
        txt = txt.replace(/&OpenCurlyQuote;/g, '‘');

        // "U+02019", "RIGHT SINGLE QUOTATION MARK"
        txt = txt.replace(/&#x0*?2019;/g, '’');
        txt = txt.replace(/&#0*?8217;/g, '’');
        txt = txt.replace(/&rsquo;/g, '’');
        txt = txt.replace(/&rsquor;/g, '’');
        txt = txt.replace(/&CloseCurlyQuote;/g, '’');

        // "U+0201A", "SINGLE LOW-9 QUOTATION MARK"
        txt = txt.replace(/&#x0*?201A;/g, '‚');
        txt = txt.replace(/&#0*?8218;/g, '‚');
        txt = txt.replace(/&lsquor;/g, '‚');
        txt = txt.replace(/&sbquo;/g, '‚');

        // "U+0201C", "LEFT DOUBLE QUOTATION MARK"
        txt = txt.replace(/&#x0*?201C;/g, '“');
        txt = txt.replace(/&#0*?8220;/g, '“');
        txt = txt.replace(/&ldquo;/g, '“');
        txt = txt.replace(/&OpenCurlyDoubleQuote;/g, '“');

        // "U+0201D", "RIGHT DOUBLE QUOTATION MARK"
        txt = txt.replace(/&#x0*?201D;/g, '”');
        txt = txt.replace(/&#0*?8221;/g, '”');
        txt = txt.replace(/&rdquo;/g, '”');
        txt = txt.replace(/&rdquor;/g, '”');
        txt = txt.replace(/&CloseCurlyDoubleQuote;/g, '”');

        // "U+0201E", "DOUBLE LOW-9 QUOTATION MARK"
        txt = txt.replace(/&#x0*?201E;/g, '„');
        txt = txt.replace(/&#0*?8222;/g, '„');
        txt = txt.replace(/&ldquor;/g, '„');
        txt = txt.replace(/&bdquo;/g, '„');

        // "U+02020", "DAGGER"
        txt = txt.replace(/&#x0*?2020;/g, '†');
        txt = txt.replace(/&#0*?8224;/g, '†');
        txt = txt.replace(/&dagger;/g, '†');

        // "U+02021", "DOUBLE DAGGER"
        txt = txt.replace(/&#x0*?2021;/g, '‡');
        txt = txt.replace(/&#0*?8225;/g, '‡');
        txt = txt.replace(/&Dagger;/g, '‡');
        txt = txt.replace(/&ddagger;/g, '‡');

        // "U+02022", "BULLET"
        txt = txt.replace(/&#x0*?2022;/g, '•');
        txt = txt.replace(/&#0*?8226;/g, '•');
        txt = txt.replace(/&bull;/g, '•');
        txt = txt.replace(/&bullet;/g, '•');

        // "U+02025", "TWO DOT LEADER"
        txt = txt.replace(/&#x0*?2025;/g, '‥');
        txt = txt.replace(/&#0*?8229;/g, '‥');
        txt = txt.replace(/&nldr;/g, '‥');

        // "U+02026", "HORIZONTAL ELLIPSIS"
        txt = txt.replace(/&#x0*?2026;/g, '…');
        txt = txt.replace(/&#0*?8230;/g, '…');
        txt = txt.replace(/&hellip;/g, '…');
        txt = txt.replace(/&mldr;/g, '…');

        // "U+02030", "PER MILLE SIGN"
        txt = txt.replace(/&#x0*?2030;/g, '‰');
        txt = txt.replace(/&#0*?8240;/g, '‰');
        txt = txt.replace(/&permil;/g, '‰');

        // "U+02031", "PER TEN THOUSAND SIGN"
        txt = txt.replace(/&#x0*?2031;/g, '‱');
        txt = txt.replace(/&#0*?8241;/g, '‱');
        txt = txt.replace(/&pertenk;/g, '‱');

        // "U+02032", "PRIME"
        txt = txt.replace(/&#x0*?2032;/g, '′');
        txt = txt.replace(/&#0*?8242;/g, '′');
        txt = txt.replace(/&prime;/g, '′');

        // "U+02033", "DOUBLE PRIME"
        txt = txt.replace(/&#x0*?2033;/g, '″');
        txt = txt.replace(/&#0*?8243;/g, '″');
        txt = txt.replace(/&Prime;/g, '″');

        // "U+02034", "TRIPLE PRIME"
        txt = txt.replace(/&#x0*?2034;/g, '‴');
        txt = txt.replace(/&#0*?8244;/g, '‴');
        txt = txt.replace(/&tprime;/g, '‴');

        // "U+02035", "REVERSED PRIME"
        txt = txt.replace(/&#x0*?2035;/g, '‵');
        txt = txt.replace(/&#0*?8245;/g, '‵');
        txt = txt.replace(/&bprime;/g, '‵');
        txt = txt.replace(/&backprime;/g, '‵');

        // "U+02039", "SINGLE LEFT-POINTING ANGLE QUOTATION MARK"
        txt = txt.replace(/&#x0*?2039;/g, '‹');
        txt = txt.replace(/&#0*?8249;/g, '‹');
        txt = txt.replace(/&lsaquo;/g, '‹');

        // "U+0203A", "SINGLE RIGHT-POINTING ANGLE QUOTATION MARK"
        txt = txt.replace(/&#x0*?203A;/g, '›');
        txt = txt.replace(/&#0*?8250;/g, '›');
        txt = txt.replace(/&rsaquo;/g, '›');

        // "U+0203E", "OVERLINE"
        txt = txt.replace(/&#x0*?203E;/g, '‾');
        txt = txt.replace(/&#0*?8254;/g, '‾');
        txt = txt.replace(/&oline;/g, '‾');

        // "U+02041", "CARET INSERTION POINT"
        txt = txt.replace(/&#x0*?2041;/g, '⁁');
        txt = txt.replace(/&#0*?8257;/g, '⁁');
        txt = txt.replace(/&caret;/g, '⁁');

        // "U+02043", "HYPHEN BULLET"
        txt = txt.replace(/&#x0*?2043;/g, '⁃');
        txt = txt.replace(/&#0*?8259;/g, '⁃');
        txt = txt.replace(/&hybull;/g, '⁃');

        // "U+02044", "FRACTION SLASH"
        txt = txt.replace(/&#x0*?2044;/g, '⁄');
        txt = txt.replace(/&#0*?8260;/g, '⁄');
        txt = txt.replace(/&frasl;/g, '⁄');

        // "U+0204F", "REVERSED SEMICOLON"
        txt = txt.replace(/&#x0*?204F;/g, '⁏');
        txt = txt.replace(/&#0*?8271;/g, '⁏');
        txt = txt.replace(/&bsemi;/g, '⁏');

        // "U+02057", "QUADRUPLE PRIME"
        txt = txt.replace(/&#x0*?2057;/g, '⁗');
        txt = txt.replace(/&#0*?8279;/g, '⁗');
        txt = txt.replace(/&qprime;/g, '⁗');

        // "U+0205F", "MEDIUM MATHEMATICAL SPACE"
        txt = txt.replace(/&#x0*?205F;/g, ' ');
        txt = txt.replace(/&#0*?8287;/g, ' ');
        txt = txt.replace(/&MediumSpace;/g, ' ');

        // "U+02060", "WORD JOINER"
        txt = txt.replace(/&#x0*?2060;/g, '⁠');
        txt = txt.replace(/&#0*?8288;/g, '⁠');
        txt = txt.replace(/&NoBreak;/g, '⁠');

        // "U+02061", "FUNCTION APPLICATION"
        txt = txt.replace(/&#x0*?2061;/g, '⁡');
        txt = txt.replace(/&#0*?8289;/g, '⁡');
        txt = txt.replace(/&ApplyFunction;/g, '⁡');
        txt = txt.replace(/&af;/g, '⁡');

        // "U+02062", "INVISIBLE TIMES"
        txt = txt.replace(/&#x0*?2062;/g, '⁢');
        txt = txt.replace(/&#0*?8290;/g, '⁢');
        txt = txt.replace(/&InvisibleTimes;/g, '⁢');
        txt = txt.replace(/&it;/g, '⁢');

        // "U+02063", "INVISIBLE SEPARATOR"
        txt = txt.replace(/&#x0*?2063;/g, '⁣');
        txt = txt.replace(/&#0*?8291;/g, '⁣');
        txt = txt.replace(/&InvisibleComma;/g, '⁣');
        txt = txt.replace(/&ic;/g, '⁣');

        // "U+020AC", "EURO SIGN"
        txt = txt.replace(/&#x0*?20AC;/g, '€');
        txt = txt.replace(/&#0*?8364;/g, '€');
        txt = txt.replace(/&euro;/g, '€');

        // "U+020DB", "COMBINING THREE DOTS ABOVE"
        txt = txt.replace(/&#x0*?20DB;/g, '⃛');
        txt = txt.replace(/&#0*?8411;/g, '⃛');
        txt = txt.replace(/&tdot;/g, '⃛');
        txt = txt.replace(/&TripleDot;/g, '⃛');

        // "U+020DC", "COMBINING FOUR DOTS ABOVE"
        txt = txt.replace(/&#x0*?20DC;/g, '⃜');
        txt = txt.replace(/&#0*?8412;/g, '⃜');
        txt = txt.replace(/&DotDot;/g, '⃜');

        // "U+02102", "DOUBLE-STRUCK CAPITAL C"
        txt = txt.replace(/&#x0*?2102;/g, 'ℂ');
        txt = txt.replace(/&#0*?8450;/g, 'ℂ');
        txt = txt.replace(/&Copf;/g, 'ℂ');
        txt = txt.replace(/&complexes;/g, 'ℂ');

        // "U+02105", "CARE OF"
        txt = txt.replace(/&#x0*?2105;/g, '℅');
        txt = txt.replace(/&#0*?8453;/g, '℅');
        txt = txt.replace(/&incare;/g, '℅');

        // "U+0210A", "SCRIPT SMALL G"
        txt = txt.replace(/&#x0*?210A;/g, 'ℊ');
        txt = txt.replace(/&#0*?8458;/g, 'ℊ');
        txt = txt.replace(/&gscr;/g, 'ℊ');

        // "U+0210B", "SCRIPT CAPITAL H"
        txt = txt.replace(/&#x0*?210B;/g, 'ℋ');
        txt = txt.replace(/&#0*?8459;/g, 'ℋ');
        txt = txt.replace(/&hamilt;/g, 'ℋ');
        txt = txt.replace(/&HilbertSpace;/g, 'ℋ');
        txt = txt.replace(/&Hscr;/g, 'ℋ');

        // "U+0210C", "BLACK-LETTER CAPITAL H"
        txt = txt.replace(/&#x0*?210C;/g, 'ℌ');
        txt = txt.replace(/&#0*?8460;/g, 'ℌ');
        txt = txt.replace(/&Hfr;/g, 'ℌ');
        txt = txt.replace(/&Poincareplane;/g, 'ℌ');

        // "U+0210D", "DOUBLE-STRUCK CAPITAL H"
        txt = txt.replace(/&#x0*?210D;/g, 'ℍ');
        txt = txt.replace(/&#0*?8461;/g, 'ℍ');
        txt = txt.replace(/&quaternions;/g, 'ℍ');
        txt = txt.replace(/&Hopf;/g, 'ℍ');

        // "U+0210E", "PLANCK CONSTANT"
        txt = txt.replace(/&#x0*?210E;/g, 'ℎ');
        txt = txt.replace(/&#0*?8462;/g, 'ℎ');
        txt = txt.replace(/&planckh;/g, 'ℎ');

        // "U+0210F", "PLANCK CONSTANT OVER TWO PI"
        txt = txt.replace(/&#x0*?210F;/g, 'ℏ');
        txt = txt.replace(/&#0*?8463;/g, 'ℏ');
        txt = txt.replace(/&planck;/g, 'ℏ');
        txt = txt.replace(/&hbar;/g, 'ℏ');
        txt = txt.replace(/&plankv;/g, 'ℏ');
        txt = txt.replace(/&hslash;/g, 'ℏ');

        // "U+02110", "SCRIPT CAPITAL I"
        txt = txt.replace(/&#x0*?2110;/g, 'ℐ');
        txt = txt.replace(/&#0*?8464;/g, 'ℐ');
        txt = txt.replace(/&Iscr;/g, 'ℐ');
        txt = txt.replace(/&imagline;/g, 'ℐ');

        // "U+02111", "BLACK-LETTER CAPITAL I"
        txt = txt.replace(/&#x0*?2111;/g, 'ℑ');
        txt = txt.replace(/&#0*?8465;/g, 'ℑ');
        txt = txt.replace(/&image;/g, 'ℑ');
        txt = txt.replace(/&Im;/g, 'ℑ');
        txt = txt.replace(/&imagpart;/g, 'ℑ');
        txt = txt.replace(/&Ifr;/g, 'ℑ');

        // "U+02112", "SCRIPT CAPITAL L"
        txt = txt.replace(/&#x0*?2112;/g, 'ℒ');
        txt = txt.replace(/&#0*?8466;/g, 'ℒ');
        txt = txt.replace(/&Lscr;/g, 'ℒ');
        txt = txt.replace(/&lagran;/g, 'ℒ');
        txt = txt.replace(/&Laplacetrf;/g, 'ℒ');

        // "U+02113", "SCRIPT SMALL L"
        txt = txt.replace(/&#x0*?2113;/g, 'ℓ');
        txt = txt.replace(/&#0*?8467;/g, 'ℓ');
        txt = txt.replace(/&ell;/g, 'ℓ');

        // "U+02115", "DOUBLE-STRUCK CAPITAL N"
        txt = txt.replace(/&#x0*?2115;/g, 'ℕ');
        txt = txt.replace(/&#0*?8469;/g, 'ℕ');
        txt = txt.replace(/&Nopf;/g, 'ℕ');
        txt = txt.replace(/&naturals;/g, 'ℕ');

        // "U+02116", "NUMERO SIGN"
        txt = txt.replace(/&#x0*?2116;/g, '№');
        txt = txt.replace(/&#0*?8470;/g, '№');
        txt = txt.replace(/&numero;/g, '№');

        // "U+02117", "SOUND RECORDING COPYRIGHT"
        txt = txt.replace(/&#x0*?2117;/g, '℗');
        txt = txt.replace(/&#0*?8471;/g, '℗');
        txt = txt.replace(/&copysr;/g, '℗');

        // "U+02118", "SCRIPT CAPITAL P"
        txt = txt.replace(/&#x0*?2118;/g, '℘');
        txt = txt.replace(/&#0*?8472;/g, '℘');
        txt = txt.replace(/&weierp;/g, '℘');
        txt = txt.replace(/&wp;/g, '℘');

        // "U+02119", "DOUBLE-STRUCK CAPITAL P"
        txt = txt.replace(/&#x0*?2119;/g, 'ℙ');
        txt = txt.replace(/&#0*?8473;/g, 'ℙ');
        txt = txt.replace(/&Popf;/g, 'ℙ');
        txt = txt.replace(/&primes;/g, 'ℙ');

        // "U+0211A", "DOUBLE-STRUCK CAPITAL Q"
        txt = txt.replace(/&#x0*?211A;/g, 'ℚ');
        txt = txt.replace(/&#0*?8474;/g, 'ℚ');
        txt = txt.replace(/&rationals;/g, 'ℚ');
        txt = txt.replace(/&Qopf;/g, 'ℚ');

        // "U+0211B", "SCRIPT CAPITAL R"
        txt = txt.replace(/&#x0*?211B;/g, 'ℛ');
        txt = txt.replace(/&#0*?8475;/g, 'ℛ');
        txt = txt.replace(/&Rscr;/g, 'ℛ');
        txt = txt.replace(/&realine;/g, 'ℛ');

        // "U+0211C", "BLACK-LETTER CAPITAL R"
        txt = txt.replace(/&#x0*?211C;/g, 'ℜ');
        txt = txt.replace(/&#0*?8476;/g, 'ℜ');
        txt = txt.replace(/&real;/g, 'ℜ');
        txt = txt.replace(/&Re;/g, 'ℜ');
        txt = txt.replace(/&realpart;/g, 'ℜ');
        txt = txt.replace(/&Rfr;/g, 'ℜ');

        // "U+0211D", "DOUBLE-STRUCK CAPITAL R"
        txt = txt.replace(/&#x0*?211D;/g, 'ℝ');
        txt = txt.replace(/&#0*?8477;/g, 'ℝ');
        txt = txt.replace(/&reals;/g, 'ℝ');
        txt = txt.replace(/&Ropf;/g, 'ℝ');

        // "U+0211E", "PRESCRIPTION TAKE"
        txt = txt.replace(/&#x0*?211E;/g, '℞');
        txt = txt.replace(/&#0*?8478;/g, '℞');
        txt = txt.replace(/&rx;/g, '℞');

        // "U+02122", "TRADE MARK SIGN"
        txt = txt.replace(/&#x0*?2122;/g, '™');
        txt = txt.replace(/&#0*?8482;/g, '™');
        txt = txt.replace(/&trade;/g, '™');
        txt = txt.replace(/&TRADE;/g, '™');

        // "U+02124", "DOUBLE-STRUCK CAPITAL Z"
        txt = txt.replace(/&#x0*?2124;/g, 'ℤ');
        txt = txt.replace(/&#0*?8484;/g, 'ℤ');
        txt = txt.replace(/&integers;/g, 'ℤ');
        txt = txt.replace(/&Zopf;/g, 'ℤ');

        // "U+02126", "OHM SIGN"
        txt = txt.replace(/&#x0*?2126;/g, 'Ω');
        txt = txt.replace(/&#0*?8486;/g, 'Ω');
        txt = txt.replace(/&ohm;/g, 'Ω');

        // "U+02127", "INVERTED OHM SIGN"
        txt = txt.replace(/&#x0*?2127;/g, '℧');
        txt = txt.replace(/&#0*?8487;/g, '℧');
        txt = txt.replace(/&mho;/g, '℧');

        // "U+02128", "BLACK-LETTER CAPITAL Z"
        txt = txt.replace(/&#x0*?2128;/g, 'ℨ');
        txt = txt.replace(/&#0*?8488;/g, 'ℨ');
        txt = txt.replace(/&Zfr;/g, 'ℨ');
        txt = txt.replace(/&zeetrf;/g, 'ℨ');

        // "U+02129", "TURNED GREEK SMALL LETTER IOTA"
        txt = txt.replace(/&#x0*?2129;/g, '℩');
        txt = txt.replace(/&#0*?8489;/g, '℩');
        txt = txt.replace(/&iiota;/g, '℩');

        // "U+0212B", "ANGSTROM SIGN"
        txt = txt.replace(/&#x0*?212B;/g, 'Å');
        txt = txt.replace(/&#0*?8491;/g, 'Å');
        txt = txt.replace(/&angst;/g, 'Å');

        // "U+0212C", "SCRIPT CAPITAL B"
        txt = txt.replace(/&#x0*?212C;/g, 'ℬ');
        txt = txt.replace(/&#0*?8492;/g, 'ℬ');
        txt = txt.replace(/&bernou;/g, 'ℬ');
        txt = txt.replace(/&Bernoullis;/g, 'ℬ');
        txt = txt.replace(/&Bscr;/g, 'ℬ');

        // "U+0212D", "BLACK-LETTER CAPITAL C"
        txt = txt.replace(/&#x0*?212D;/g, 'ℭ');
        txt = txt.replace(/&#0*?8493;/g, 'ℭ');
        txt = txt.replace(/&Cfr;/g, 'ℭ');
        txt = txt.replace(/&Cayleys;/g, 'ℭ');

        // "U+0212F", "SCRIPT SMALL E"
        txt = txt.replace(/&#x0*?212F;/g, 'ℯ');
        txt = txt.replace(/&#0*?8495;/g, 'ℯ');
        txt = txt.replace(/&escr;/g, 'ℯ');

        // "U+02130", "SCRIPT CAPITAL E"
        txt = txt.replace(/&#x0*?2130;/g, 'ℰ');
        txt = txt.replace(/&#0*?8496;/g, 'ℰ');
        txt = txt.replace(/&Escr;/g, 'ℰ');
        txt = txt.replace(/&expectation;/g, 'ℰ');

        // "U+02131", "SCRIPT CAPITAL F"
        txt = txt.replace(/&#x0*?2131;/g, 'ℱ');
        txt = txt.replace(/&#0*?8497;/g, 'ℱ');
        txt = txt.replace(/&Fscr;/g, 'ℱ');
        txt = txt.replace(/&Fouriertrf;/g, 'ℱ');

        // "U+02133", "SCRIPT CAPITAL M"
        txt = txt.replace(/&#x0*?2133;/g, 'ℳ');
        txt = txt.replace(/&#0*?8499;/g, 'ℳ');
        txt = txt.replace(/&phmmat;/g, 'ℳ');
        txt = txt.replace(/&Mellintrf;/g, 'ℳ');
        txt = txt.replace(/&Mscr;/g, 'ℳ');

        // "U+02134", "SCRIPT SMALL O"
        txt = txt.replace(/&#x0*?2134;/g, 'ℴ');
        txt = txt.replace(/&#0*?8500;/g, 'ℴ');
        txt = txt.replace(/&order;/g, 'ℴ');
        txt = txt.replace(/&orderof;/g, 'ℴ');
        txt = txt.replace(/&oscr;/g, 'ℴ');

        // "U+02135", "ALEF SYMBOL"
        txt = txt.replace(/&#x0*?2135;/g, 'ℵ');
        txt = txt.replace(/&#0*?8501;/g, 'ℵ');
        txt = txt.replace(/&alefsym;/g, 'ℵ');
        txt = txt.replace(/&aleph;/g, 'ℵ');

        // "U+02136", "BET SYMBOL"
        txt = txt.replace(/&#x0*?2136;/g, 'ℶ');
        txt = txt.replace(/&#0*?8502;/g, 'ℶ');
        txt = txt.replace(/&beth;/g, 'ℶ');

        // "U+02137", "GIMEL SYMBOL"
        txt = txt.replace(/&#x0*?2137;/g, 'ℷ');
        txt = txt.replace(/&#0*?8503;/g, 'ℷ');
        txt = txt.replace(/&gimel;/g, 'ℷ');

        // "U+02138", "DALET SYMBOL"
        txt = txt.replace(/&#x0*?2138;/g, 'ℸ');
        txt = txt.replace(/&#0*?8504;/g, 'ℸ');
        txt = txt.replace(/&daleth;/g, 'ℸ');

        // "U+02145", "DOUBLE-STRUCK ITALIC CAPITAL D"
        txt = txt.replace(/&#x0*?2145;/g, 'ⅅ');
        txt = txt.replace(/&#0*?8517;/g, 'ⅅ');
        txt = txt.replace(/&CapitalDifferentialD;/g, 'ⅅ');
        txt = txt.replace(/&DD;/g, 'ⅅ');

        // "U+02146", "DOUBLE-STRUCK ITALIC SMALL D"
        txt = txt.replace(/&#x0*?2146;/g, 'ⅆ');
        txt = txt.replace(/&#0*?8518;/g, 'ⅆ');
        txt = txt.replace(/&DifferentialD;/g, 'ⅆ');
        txt = txt.replace(/&dd;/g, 'ⅆ');

        // "U+02147", "DOUBLE-STRUCK ITALIC SMALL E"
        txt = txt.replace(/&#x0*?2147;/g, 'ⅇ');
        txt = txt.replace(/&#0*?8519;/g, 'ⅇ');
        txt = txt.replace(/&ExponentialE;/g, 'ⅇ');
        txt = txt.replace(/&exponentiale;/g, 'ⅇ');
        txt = txt.replace(/&ee;/g, 'ⅇ');

        // "U+02148", "DOUBLE-STRUCK ITALIC SMALL I"
        txt = txt.replace(/&#x0*?2148;/g, 'ⅈ');
        txt = txt.replace(/&#0*?8520;/g, 'ⅈ');
        txt = txt.replace(/&ImaginaryI;/g, 'ⅈ');
        txt = txt.replace(/&ii;/g, 'ⅈ');

        // "U+02153", "VULGAR FRACTION ONE THIRD"
        txt = txt.replace(/&#x0*?2153;/g, '⅓');
        txt = txt.replace(/&#0*?8531;/g, '⅓');
        txt = txt.replace(/&frac13;/g, '⅓');

        // "U+02154", "VULGAR FRACTION TWO THIRDS"
        txt = txt.replace(/&#x0*?2154;/g, '⅔');
        txt = txt.replace(/&#0*?8532;/g, '⅔');
        txt = txt.replace(/&frac23;/g, '⅔');

        // "U+02155", "VULGAR FRACTION ONE FIFTH"
        txt = txt.replace(/&#x0*?2155;/g, '⅕');
        txt = txt.replace(/&#0*?8533;/g, '⅕');
        txt = txt.replace(/&frac15;/g, '⅕');

        // "U+02156", "VULGAR FRACTION TWO FIFTHS"
        txt = txt.replace(/&#x0*?2156;/g, '⅖');
        txt = txt.replace(/&#0*?8534;/g, '⅖');
        txt = txt.replace(/&frac25;/g, '⅖');

        // "U+02157", "VULGAR FRACTION THREE FIFTHS"
        txt = txt.replace(/&#x0*?2157;/g, '⅗');
        txt = txt.replace(/&#0*?8535;/g, '⅗');
        txt = txt.replace(/&frac35;/g, '⅗');

        // "U+02158", "VULGAR FRACTION FOUR FIFTHS"
        txt = txt.replace(/&#x0*?2158;/g, '⅘');
        txt = txt.replace(/&#0*?8536;/g, '⅘');
        txt = txt.replace(/&frac45;/g, '⅘');

        // "U+02159", "VULGAR FRACTION ONE SIXTH"
        txt = txt.replace(/&#x0*?2159;/g, '⅙');
        txt = txt.replace(/&#0*?8537;/g, '⅙');
        txt = txt.replace(/&frac16;/g, '⅙');

        // "U+0215A", "VULGAR FRACTION FIVE SIXTHS"
        txt = txt.replace(/&#x0*?215A;/g, '⅚');
        txt = txt.replace(/&#0*?8538;/g, '⅚');
        txt = txt.replace(/&frac56;/g, '⅚');

        // "U+0215B", "VULGAR FRACTION ONE EIGHTH"
        txt = txt.replace(/&#x0*?215B;/g, '⅛');
        txt = txt.replace(/&#0*?8539;/g, '⅛');
        txt = txt.replace(/&frac18;/g, '⅛');

        // "U+0215C", "VULGAR FRACTION THREE EIGHTHS"
        txt = txt.replace(/&#x0*?215C;/g, '⅜');
        txt = txt.replace(/&#0*?8540;/g, '⅜');
        txt = txt.replace(/&frac38;/g, '⅜');

        // "U+0215D", "VULGAR FRACTION FIVE EIGHTHS"
        txt = txt.replace(/&#x0*?215D;/g, '⅝');
        txt = txt.replace(/&#0*?8541;/g, '⅝');
        txt = txt.replace(/&frac58;/g, '⅝');

        // "U+0215E", "VULGAR FRACTION SEVEN EIGHTHS"
        txt = txt.replace(/&#x0*?215E;/g, '⅞');
        txt = txt.replace(/&#0*?8542;/g, '⅞');
        txt = txt.replace(/&frac78;/g, '⅞');

        // "U+02190", "LEFTWARDS ARROW"
        txt = txt.replace(/&#x0*?2190;/g, '←');
        txt = txt.replace(/&#0*?8592;/g, '←');
        txt = txt.replace(/&larr;/g, '←');
        txt = txt.replace(/&leftarrow;/g, '←');
        txt = txt.replace(/&LeftArrow;/g, '←');
        txt = txt.replace(/&slarr;/g, '←');
        txt = txt.replace(/&ShortLeftArrow;/g, '←');

        // "U+02191", "UPWARDS ARROW"
        txt = txt.replace(/&#x0*?2191;/g, '↑');
        txt = txt.replace(/&#0*?8593;/g, '↑');
        txt = txt.replace(/&uarr;/g, '↑');
        txt = txt.replace(/&uparrow;/g, '↑');
        txt = txt.replace(/&UpArrow;/g, '↑');
        txt = txt.replace(/&ShortUpArrow;/g, '↑');

        // "U+02192", "RIGHTWARDS ARROW"
        txt = txt.replace(/&#x0*?2192;/g, '→');
        txt = txt.replace(/&#0*?8594;/g, '→');
        txt = txt.replace(/&rarr;/g, '→');
        txt = txt.replace(/&rightarrow;/g, '→');
        txt = txt.replace(/&RightArrow;/g, '→');
        txt = txt.replace(/&srarr;/g, '→');
        txt = txt.replace(/&ShortRightArrow;/g, '→');

        // "U+02193", "DOWNWARDS ARROW"
        txt = txt.replace(/&#x0*?2193;/g, '↓');
        txt = txt.replace(/&#0*?8595;/g, '↓');
        txt = txt.replace(/&darr;/g, '↓');
        txt = txt.replace(/&downarrow;/g, '↓');
        txt = txt.replace(/&DownArrow;/g, '↓');
        txt = txt.replace(/&ShortDownArrow;/g, '↓');

        // "U+02194", "LEFT RIGHT ARROW"
        txt = txt.replace(/&#x0*?2194;/g, '↔');
        txt = txt.replace(/&#0*?8596;/g, '↔');
        txt = txt.replace(/&harr;/g, '↔');
        txt = txt.replace(/&leftrightarrow;/g, '↔');
        txt = txt.replace(/&LeftRightArrow;/g, '↔');

        // "U+02195", "UP DOWN ARROW"
        txt = txt.replace(/&#x0*?2195;/g, '↕');
        txt = txt.replace(/&#0*?8597;/g, '↕');
        txt = txt.replace(/&varr;/g, '↕');
        txt = txt.replace(/&updownarrow;/g, '↕');
        txt = txt.replace(/&UpDownArrow;/g, '↕');

        // "U+02196", "NORTH WEST ARROW"
        txt = txt.replace(/&#x0*?2196;/g, '↖');
        txt = txt.replace(/&#0*?8598;/g, '↖');
        txt = txt.replace(/&nwarr;/g, '↖');
        txt = txt.replace(/&UpperLeftArrow;/g, '↖');
        txt = txt.replace(/&nwarrow;/g, '↖');

        // "U+02197", "NORTH EAST ARROW"
        txt = txt.replace(/&#x0*?2197;/g, '↗');
        txt = txt.replace(/&#0*?8599;/g, '↗');
        txt = txt.replace(/&nearr;/g, '↗');
        txt = txt.replace(/&UpperRightArrow;/g, '↗');
        txt = txt.replace(/&nearrow;/g, '↗');

        // "U+02198", "SOUTH EAST ARROW"
        txt = txt.replace(/&#x0*?2198;/g, '↘');
        txt = txt.replace(/&#0*?8600;/g, '↘');
        txt = txt.replace(/&searr;/g, '↘');
        txt = txt.replace(/&searrow;/g, '↘');
        txt = txt.replace(/&LowerRightArrow;/g, '↘');

        // "U+02199", "SOUTH WEST ARROW"
        txt = txt.replace(/&#x0*?2199;/g, '↙');
        txt = txt.replace(/&#0*?8601;/g, '↙');
        txt = txt.replace(/&swarr;/g, '↙');
        txt = txt.replace(/&swarrow;/g, '↙');
        txt = txt.replace(/&LowerLeftArrow;/g, '↙');

        // "U+0219A", "LEFTWARDS ARROW WITH STROKE"
        txt = txt.replace(/&#x0*?219A;/g, '↚');
        txt = txt.replace(/&#0*?8602;/g, '↚');
        txt = txt.replace(/&nlarr;/g, '↚');
        txt = txt.replace(/&nleftarrow;/g, '↚');

        // "U+0219B", "RIGHTWARDS ARROW WITH STROKE"
        txt = txt.replace(/&#x0*?219B;/g, '↛');
        txt = txt.replace(/&#0*?8603;/g, '↛');
        txt = txt.replace(/&nrarr;/g, '↛');
        txt = txt.replace(/&nrightarrow;/g, '↛');

        // "U+0219D", "RIGHTWARDS WAVE ARROW"
        txt = txt.replace(/&#x0*?219D;/g, '↝');
        txt = txt.replace(/&#0*?8605;/g, '↝');
        txt = txt.replace(/&rarrw;/g, '↝');
        txt = txt.replace(/&rightsquigarrow;/g, '↝');

        // "U+0219E", "LEFTWARDS TWO HEADED ARROW"
        txt = txt.replace(/&#x0*?219E;/g, '↞');
        txt = txt.replace(/&#0*?8606;/g, '↞');
        txt = txt.replace(/&Larr;/g, '↞');
        txt = txt.replace(/&twoheadleftarrow;/g, '↞');

        // "U+0219F", "UPWARDS TWO HEADED ARROW"
        txt = txt.replace(/&#x0*?219F;/g, '↟');
        txt = txt.replace(/&#0*?8607;/g, '↟');
        txt = txt.replace(/&Uarr;/g, '↟');

        // "U+021A0", "RIGHTWARDS TWO HEADED ARROW"
        txt = txt.replace(/&#x0*?21A0;/g, '↠');
        txt = txt.replace(/&#0*?8608;/g, '↠');
        txt = txt.replace(/&Rarr;/g, '↠');
        txt = txt.replace(/&twoheadrightarrow;/g, '↠');

        // "U+021A1", "DOWNWARDS TWO HEADED ARROW"
        txt = txt.replace(/&#x0*?21A1;/g, '↡');
        txt = txt.replace(/&#0*?8609;/g, '↡');
        txt = txt.replace(/&Darr;/g, '↡');

        // "U+021A2", "LEFTWARDS ARROW WITH TAIL"
        txt = txt.replace(/&#x0*?21A2;/g, '↢');
        txt = txt.replace(/&#0*?8610;/g, '↢');
        txt = txt.replace(/&larrtl;/g, '↢');
        txt = txt.replace(/&leftarrowtail;/g, '↢');

        // "U+021A3", "RIGHTWARDS ARROW WITH TAIL"
        txt = txt.replace(/&#x0*?21A3;/g, '↣');
        txt = txt.replace(/&#0*?8611;/g, '↣');
        txt = txt.replace(/&rarrtl;/g, '↣');
        txt = txt.replace(/&rightarrowtail;/g, '↣');

        // "U+021A4", "LEFTWARDS ARROW FROM BAR"
        txt = txt.replace(/&#x0*?21A4;/g, '↤');
        txt = txt.replace(/&#0*?8612;/g, '↤');
        txt = txt.replace(/&LeftTeeArrow;/g, '↤');
        txt = txt.replace(/&mapstoleft;/g, '↤');

        // "U+021A5", "UPWARDS ARROW FROM BAR"
        txt = txt.replace(/&#x0*?21A5;/g, '↥');
        txt = txt.replace(/&#0*?8613;/g, '↥');
        txt = txt.replace(/&UpTeeArrow;/g, '↥');
        txt = txt.replace(/&mapstoup;/g, '↥');

        // "U+021A6", "RIGHTWARDS ARROW FROM BAR"
        txt = txt.replace(/&#x0*?21A6;/g, '↦');
        txt = txt.replace(/&#0*?8614;/g, '↦');
        txt = txt.replace(/&map;/g, '↦');
        txt = txt.replace(/&RightTeeArrow;/g, '↦');
        txt = txt.replace(/&mapsto;/g, '↦');

        // "U+021A7", "DOWNWARDS ARROW FROM BAR"
        txt = txt.replace(/&#x0*?21A7;/g, '↧');
        txt = txt.replace(/&#0*?8615;/g, '↧');
        txt = txt.replace(/&DownTeeArrow;/g, '↧');
        txt = txt.replace(/&mapstodown;/g, '↧');

        // "U+021A9", "LEFTWARDS ARROW WITH HOOK"
        txt = txt.replace(/&#x0*?21A9;/g, '↩');
        txt = txt.replace(/&#0*?8617;/g, '↩');
        txt = txt.replace(/&larrhk;/g, '↩');
        txt = txt.replace(/&hookleftarrow;/g, '↩');

        // "U+021AA", "RIGHTWARDS ARROW WITH HOOK"
        txt = txt.replace(/&#x0*?21AA;/g, '↪');
        txt = txt.replace(/&#0*?8618;/g, '↪');
        txt = txt.replace(/&rarrhk;/g, '↪');
        txt = txt.replace(/&hookrightarrow;/g, '↪');

        // "U+021AB", "LEFTWARDS ARROW WITH LOOP"
        txt = txt.replace(/&#x0*?21AB;/g, '↫');
        txt = txt.replace(/&#0*?8619;/g, '↫');
        txt = txt.replace(/&larrlp;/g, '↫');
        txt = txt.replace(/&looparrowleft;/g, '↫');

        // "U+021AC", "RIGHTWARDS ARROW WITH LOOP"
        txt = txt.replace(/&#x0*?21AC;/g, '↬');
        txt = txt.replace(/&#0*?8620;/g, '↬');
        txt = txt.replace(/&rarrlp;/g, '↬');
        txt = txt.replace(/&looparrowright;/g, '↬');

        // "U+021AD", "LEFT RIGHT WAVE ARROW"
        txt = txt.replace(/&#x0*?21AD;/g, '↭');
        txt = txt.replace(/&#0*?8621;/g, '↭');
        txt = txt.replace(/&harrw;/g, '↭');
        txt = txt.replace(/&leftrightsquigarrow;/g, '↭');

        // "U+021AE", "LEFT RIGHT ARROW WITH STROKE"
        txt = txt.replace(/&#x0*?21AE;/g, '↮');
        txt = txt.replace(/&#0*?8622;/g, '↮');
        txt = txt.replace(/&nharr;/g, '↮');
        txt = txt.replace(/&nleftrightarrow;/g, '↮');

        // "U+021B0", "UPWARDS ARROW WITH TIP LEFTWARDS"
        txt = txt.replace(/&#x0*?21B0;/g, '↰');
        txt = txt.replace(/&#0*?8624;/g, '↰');
        txt = txt.replace(/&lsh;/g, '↰');
        txt = txt.replace(/&Lsh;/g, '↰');

        // "U+021B1", "UPWARDS ARROW WITH TIP RIGHTWARDS"
        txt = txt.replace(/&#x0*?21B1;/g, '↱');
        txt = txt.replace(/&#0*?8625;/g, '↱');
        txt = txt.replace(/&rsh;/g, '↱');
        txt = txt.replace(/&Rsh;/g, '↱');

        // "U+021B2", "DOWNWARDS ARROW WITH TIP LEFTWARDS"
        txt = txt.replace(/&#x0*?21B2;/g, '↲');
        txt = txt.replace(/&#0*?8626;/g, '↲');
        txt = txt.replace(/&ldsh;/g, '↲');

        // "U+021B3", "DOWNWARDS ARROW WITH TIP RIGHTWARDS"
        txt = txt.replace(/&#x0*?21B3;/g, '↳');
        txt = txt.replace(/&#0*?8627;/g, '↳');
        txt = txt.replace(/&rdsh;/g, '↳');

        // "U+021B5", "DOWNWARDS ARROW WITH CORNER LEFTWARDS"
        txt = txt.replace(/&#x0*?21B5;/g, '↵');
        txt = txt.replace(/&#0*?8629;/g, '↵');
        txt = txt.replace(/&crarr;/g, '↵');

        // "U+021B6", "ANTICLOCKWISE TOP SEMICIRCLE ARROW"
        txt = txt.replace(/&#x0*?21B6;/g, '↶');
        txt = txt.replace(/&#0*?8630;/g, '↶');
        txt = txt.replace(/&cularr;/g, '↶');
        txt = txt.replace(/&curvearrowleft;/g, '↶');

        // "U+021B7", "CLOCKWISE TOP SEMICIRCLE ARROW"
        txt = txt.replace(/&#x0*?21B7;/g, '↷');
        txt = txt.replace(/&#0*?8631;/g, '↷');
        txt = txt.replace(/&curarr;/g, '↷');
        txt = txt.replace(/&curvearrowright;/g, '↷');

        // "U+021BA", "ANTICLOCKWISE OPEN CIRCLE ARROW"
        txt = txt.replace(/&#x0*?21BA;/g, '↺');
        txt = txt.replace(/&#0*?8634;/g, '↺');
        txt = txt.replace(/&olarr;/g, '↺');
        txt = txt.replace(/&circlearrowleft;/g, '↺');

        // "U+021BB", "CLOCKWISE OPEN CIRCLE ARROW"
        txt = txt.replace(/&#x0*?21BB;/g, '↻');
        txt = txt.replace(/&#0*?8635;/g, '↻');
        txt = txt.replace(/&orarr;/g, '↻');
        txt = txt.replace(/&circlearrowright;/g, '↻');

        // "U+021BC", "LEFTWARDS HARPOON WITH BARB UPWARDS"
        txt = txt.replace(/&#x0*?21BC;/g, '↼');
        txt = txt.replace(/&#0*?8636;/g, '↼');
        txt = txt.replace(/&lharu;/g, '↼');
        txt = txt.replace(/&LeftVector;/g, '↼');
        txt = txt.replace(/&leftharpoonup;/g, '↼');

        // "U+021BD", "LEFTWARDS HARPOON WITH BARB DOWNWARDS"
        txt = txt.replace(/&#x0*?21BD;/g, '↽');
        txt = txt.replace(/&#0*?8637;/g, '↽');
        txt = txt.replace(/&lhard;/g, '↽');
        txt = txt.replace(/&leftharpoondown;/g, '↽');
        txt = txt.replace(/&DownLeftVector;/g, '↽');

        // "U+021BE", "UPWARDS HARPOON WITH BARB RIGHTWARDS"
        txt = txt.replace(/&#x0*?21BE;/g, '↾');
        txt = txt.replace(/&#0*?8638;/g, '↾');
        txt = txt.replace(/&uharr;/g, '↾');
        txt = txt.replace(/&upharpoonright;/g, '↾');
        txt = txt.replace(/&RightUpVector;/g, '↾');

        // "U+021BF", "UPWARDS HARPOON WITH BARB LEFTWARDS"
        txt = txt.replace(/&#x0*?21BF;/g, '↿');
        txt = txt.replace(/&#0*?8639;/g, '↿');
        txt = txt.replace(/&uharl;/g, '↿');
        txt = txt.replace(/&upharpoonleft;/g, '↿');
        txt = txt.replace(/&LeftUpVector;/g, '↿');

        // "U+021C0", "RIGHTWARDS HARPOON WITH BARB UPWARDS"
        txt = txt.replace(/&#x0*?21C0;/g, '⇀');
        txt = txt.replace(/&#0*?8640;/g, '⇀');
        txt = txt.replace(/&rharu;/g, '⇀');
        txt = txt.replace(/&RightVector;/g, '⇀');
        txt = txt.replace(/&rightharpoonup;/g, '⇀');

        // "U+021C1", "RIGHTWARDS HARPOON WITH BARB DOWNWARDS"
        txt = txt.replace(/&#x0*?21C1;/g, '⇁');
        txt = txt.replace(/&#0*?8641;/g, '⇁');
        txt = txt.replace(/&rhard;/g, '⇁');
        txt = txt.replace(/&rightharpoondown;/g, '⇁');
        txt = txt.replace(/&DownRightVector;/g, '⇁');

        // "U+021C2", "DOWNWARDS HARPOON WITH BARB RIGHTWARDS"
        txt = txt.replace(/&#x0*?21C2;/g, '⇂');
        txt = txt.replace(/&#0*?8642;/g, '⇂');
        txt = txt.replace(/&dharr;/g, '⇂');
        txt = txt.replace(/&RightDownVector;/g, '⇂');
        txt = txt.replace(/&downharpoonright;/g, '⇂');

        // "U+021C3", "DOWNWARDS HARPOON WITH BARB LEFTWARDS"
        txt = txt.replace(/&#x0*?21C3;/g, '⇃');
        txt = txt.replace(/&#0*?8643;/g, '⇃');
        txt = txt.replace(/&dharl;/g, '⇃');
        txt = txt.replace(/&LeftDownVector;/g, '⇃');
        txt = txt.replace(/&downharpoonleft;/g, '⇃');

        // "U+021C4", "RIGHTWARDS ARROW OVER LEFTWARDS ARROW"
        txt = txt.replace(/&#x0*?21C4;/g, '⇄');
        txt = txt.replace(/&#0*?8644;/g, '⇄');
        txt = txt.replace(/&rlarr;/g, '⇄');
        txt = txt.replace(/&rightleftarrows;/g, '⇄');
        txt = txt.replace(/&RightArrowLeftArrow;/g, '⇄');

        // "U+021C5", "UPWARDS ARROW LEFTWARDS OF DOWNWARDS ARROW"
        txt = txt.replace(/&#x0*?21C5;/g, '⇅');
        txt = txt.replace(/&#0*?8645;/g, '⇅');
        txt = txt.replace(/&udarr;/g, '⇅');
        txt = txt.replace(/&UpArrowDownArrow;/g, '⇅');

        // "U+021C6", "LEFTWARDS ARROW OVER RIGHTWARDS ARROW"
        txt = txt.replace(/&#x0*?21C6;/g, '⇆');
        txt = txt.replace(/&#0*?8646;/g, '⇆');
        txt = txt.replace(/&lrarr;/g, '⇆');
        txt = txt.replace(/&leftrightarrows;/g, '⇆');
        txt = txt.replace(/&LeftArrowRightArrow;/g, '⇆');

        // "U+021C7", "LEFTWARDS PAIRED ARROWS"
        txt = txt.replace(/&#x0*?21C7;/g, '⇇');
        txt = txt.replace(/&#0*?8647;/g, '⇇');
        txt = txt.replace(/&llarr;/g, '⇇');
        txt = txt.replace(/&leftleftarrows;/g, '⇇');

        // "U+021C8", "UPWARDS PAIRED ARROWS"
        txt = txt.replace(/&#x0*?21C8;/g, '⇈');
        txt = txt.replace(/&#0*?8648;/g, '⇈');
        txt = txt.replace(/&uuarr;/g, '⇈');
        txt = txt.replace(/&upuparrows;/g, '⇈');

        // "U+021C9", "RIGHTWARDS PAIRED ARROWS"
        txt = txt.replace(/&#x0*?21C9;/g, '⇉');
        txt = txt.replace(/&#0*?8649;/g, '⇉');
        txt = txt.replace(/&rrarr;/g, '⇉');
        txt = txt.replace(/&rightrightarrows;/g, '⇉');

        // "U+021CA", "DOWNWARDS PAIRED ARROWS"
        txt = txt.replace(/&#x0*?21CA;/g, '⇊');
        txt = txt.replace(/&#0*?8650;/g, '⇊');
        txt = txt.replace(/&ddarr;/g, '⇊');
        txt = txt.replace(/&downdownarrows;/g, '⇊');

        // "U+021CB", "LEFTWARDS HARPOON OVER RIGHTWARDS HARPOON"
        txt = txt.replace(/&#x0*?21CB;/g, '⇋');
        txt = txt.replace(/&#0*?8651;/g, '⇋');
        txt = txt.replace(/&lrhar;/g, '⇋');
        txt = txt.replace(/&ReverseEquilibrium;/g, '⇋');
        txt = txt.replace(/&leftrightharpoons;/g, '⇋');

        // "U+021CC", "RIGHTWARDS HARPOON OVER LEFTWARDS HARPOON"
        txt = txt.replace(/&#x0*?21CC;/g, '⇌');
        txt = txt.replace(/&#0*?8652;/g, '⇌');
        txt = txt.replace(/&rlhar;/g, '⇌');
        txt = txt.replace(/&rightleftharpoons;/g, '⇌');
        txt = txt.replace(/&Equilibrium;/g, '⇌');

        // "U+021CD", "LEFTWARDS DOUBLE ARROW WITH STROKE"
        txt = txt.replace(/&#x0*?21CD;/g, '⇍');
        txt = txt.replace(/&#0*?8653;/g, '⇍');
        txt = txt.replace(/&nlArr;/g, '⇍');
        txt = txt.replace(/&nLeftarrow;/g, '⇍');

        // "U+021CE", "LEFT RIGHT DOUBLE ARROW WITH STROKE"
        txt = txt.replace(/&#x0*?21CE;/g, '⇎');
        txt = txt.replace(/&#0*?8654;/g, '⇎');
        txt = txt.replace(/&nhArr;/g, '⇎');
        txt = txt.replace(/&nLeftrightarrow;/g, '⇎');

        // "U+021CF", "RIGHTWARDS DOUBLE ARROW WITH STROKE"
        txt = txt.replace(/&#x0*?21CF;/g, '⇏');
        txt = txt.replace(/&#0*?8655;/g, '⇏');
        txt = txt.replace(/&nrArr;/g, '⇏');
        txt = txt.replace(/&nRightarrow;/g, '⇏');

        // "U+021D0", "LEFTWARDS DOUBLE ARROW"
        txt = txt.replace(/&#x0*?21D0;/g, '⇐');
        txt = txt.replace(/&#0*?8656;/g, '⇐');
        txt = txt.replace(/&lArr;/g, '⇐');
        txt = txt.replace(/&Leftarrow;/g, '⇐');
        txt = txt.replace(/&DoubleLeftArrow;/g, '⇐');

        // "U+021D1", "UPWARDS DOUBLE ARROW"
        txt = txt.replace(/&#x0*?21D1;/g, '⇑');
        txt = txt.replace(/&#0*?8657;/g, '⇑');
        txt = txt.replace(/&uArr;/g, '⇑');
        txt = txt.replace(/&Uparrow;/g, '⇑');
        txt = txt.replace(/&DoubleUpArrow;/g, '⇑');

        // "U+021D2", "RIGHTWARDS DOUBLE ARROW"
        txt = txt.replace(/&#x0*?21D2;/g, '⇒');
        txt = txt.replace(/&#0*?8658;/g, '⇒');
        txt = txt.replace(/&rArr;/g, '⇒');
        txt = txt.replace(/&Rightarrow;/g, '⇒');
        txt = txt.replace(/&Implies;/g, '⇒');
        txt = txt.replace(/&DoubleRightArrow;/g, '⇒');

        // "U+021D3", "DOWNWARDS DOUBLE ARROW"
        txt = txt.replace(/&#x0*?21D3;/g, '⇓');
        txt = txt.replace(/&#0*?8659;/g, '⇓');
        txt = txt.replace(/&dArr;/g, '⇓');
        txt = txt.replace(/&Downarrow;/g, '⇓');
        txt = txt.replace(/&DoubleDownArrow;/g, '⇓');

        // "U+021D4", "LEFT RIGHT DOUBLE ARROW"
        txt = txt.replace(/&#x0*?21D4;/g, '⇔');
        txt = txt.replace(/&#0*?8660;/g, '⇔');
        txt = txt.replace(/&hArr;/g, '⇔');
        txt = txt.replace(/&Leftrightarrow;/g, '⇔');
        txt = txt.replace(/&DoubleLeftRightArrow;/g, '⇔');
        txt = txt.replace(/&iff;/g, '⇔');

        // "U+021D5", "UP DOWN DOUBLE ARROW"
        txt = txt.replace(/&#x0*?21D5;/g, '⇕');
        txt = txt.replace(/&#0*?8661;/g, '⇕');
        txt = txt.replace(/&vArr;/g, '⇕');
        txt = txt.replace(/&Updownarrow;/g, '⇕');
        txt = txt.replace(/&DoubleUpDownArrow;/g, '⇕');

        // "U+021D6", "NORTH WEST DOUBLE ARROW"
        txt = txt.replace(/&#x0*?21D6;/g, '⇖');
        txt = txt.replace(/&#0*?8662;/g, '⇖');
        txt = txt.replace(/&nwArr;/g, '⇖');

        // "U+021D7", "NORTH EAST DOUBLE ARROW"
        txt = txt.replace(/&#x0*?21D7;/g, '⇗');
        txt = txt.replace(/&#0*?8663;/g, '⇗');
        txt = txt.replace(/&neArr;/g, '⇗');

        // "U+021D8", "SOUTH EAST DOUBLE ARROW"
        txt = txt.replace(/&#x0*?21D8;/g, '⇘');
        txt = txt.replace(/&#0*?8664;/g, '⇘');
        txt = txt.replace(/&seArr;/g, '⇘');

        // "U+021D9", "SOUTH WEST DOUBLE ARROW"
        txt = txt.replace(/&#x0*?21D9;/g, '⇙');
        txt = txt.replace(/&#0*?8665;/g, '⇙');
        txt = txt.replace(/&swArr;/g, '⇙');

        // "U+021DA", "LEFTWARDS TRIPLE ARROW"
        txt = txt.replace(/&#x0*?21DA;/g, '⇚');
        txt = txt.replace(/&#0*?8666;/g, '⇚');
        txt = txt.replace(/&lAarr;/g, '⇚');
        txt = txt.replace(/&Lleftarrow;/g, '⇚');

        // "U+021DB", "RIGHTWARDS TRIPLE ARROW"
        txt = txt.replace(/&#x0*?21DB;/g, '⇛');
        txt = txt.replace(/&#0*?8667;/g, '⇛');
        txt = txt.replace(/&rAarr;/g, '⇛');
        txt = txt.replace(/&Rrightarrow;/g, '⇛');

        // "U+021DD", "RIGHTWARDS SQUIGGLE ARROW"
        txt = txt.replace(/&#x0*?21DD;/g, '⇝');
        txt = txt.replace(/&#0*?8669;/g, '⇝');
        txt = txt.replace(/&zigrarr;/g, '⇝');

        // "U+021E4", "LEFTWARDS ARROW TO BAR"
        txt = txt.replace(/&#x0*?21E4;/g, '⇤');
        txt = txt.replace(/&#0*?8676;/g, '⇤');
        txt = txt.replace(/&larrb;/g, '⇤');
        txt = txt.replace(/&LeftArrowBar;/g, '⇤');

        // "U+021E5", "RIGHTWARDS ARROW TO BAR"
        txt = txt.replace(/&#x0*?21E5;/g, '⇥');
        txt = txt.replace(/&#0*?8677;/g, '⇥');
        txt = txt.replace(/&rarrb;/g, '⇥');
        txt = txt.replace(/&RightArrowBar;/g, '⇥');

        // "U+021F5", "DOWNWARDS ARROW LEFTWARDS OF UPWARDS ARROW"
        txt = txt.replace(/&#x0*?21F5;/g, '⇵');
        txt = txt.replace(/&#0*?8693;/g, '⇵');
        txt = txt.replace(/&duarr;/g, '⇵');
        txt = txt.replace(/&DownArrowUpArrow;/g, '⇵');

        // "U+021FD", "LEFTWARDS OPEN-HEADED ARROW"
        txt = txt.replace(/&#x0*?21FD;/g, '⇽');
        txt = txt.replace(/&#0*?8701;/g, '⇽');
        txt = txt.replace(/&loarr;/g, '⇽');

        // "U+021FE", "RIGHTWARDS OPEN-HEADED ARROW"
        txt = txt.replace(/&#x0*?21FE;/g, '⇾');
        txt = txt.replace(/&#0*?8702;/g, '⇾');
        txt = txt.replace(/&roarr;/g, '⇾');

        // "U+021FF", "LEFT RIGHT OPEN-HEADED ARROW"
        txt = txt.replace(/&#x0*?21FF;/g, '⇿');
        txt = txt.replace(/&#0*?8703;/g, '⇿');
        txt = txt.replace(/&hoarr;/g, '⇿');

        // "U+02200", "FOR ALL"
        txt = txt.replace(/&#x0*?2200;/g, '∀');
        txt = txt.replace(/&#0*?8704;/g, '∀');
        txt = txt.replace(/&forall;/g, '∀');
        txt = txt.replace(/&ForAll;/g, '∀');

        // "U+02201", "COMPLEMENT"
        txt = txt.replace(/&#x0*?2201;/g, '∁');
        txt = txt.replace(/&#0*?8705;/g, '∁');
        txt = txt.replace(/&comp;/g, '∁');
        txt = txt.replace(/&complement;/g, '∁');

        // "U+02202", "PARTIAL DIFFERENTIAL"
        txt = txt.replace(/&#x0*?2202;/g, '∂');
        txt = txt.replace(/&#0*?8706;/g, '∂');
        txt = txt.replace(/&part;/g, '∂');
        txt = txt.replace(/&PartialD;/g, '∂');

        // "U+02203", "THERE EXISTS"
        txt = txt.replace(/&#x0*?2203;/g, '∃');
        txt = txt.replace(/&#0*?8707;/g, '∃');
        txt = txt.replace(/&exist;/g, '∃');
        txt = txt.replace(/&Exists;/g, '∃');

        // "U+02204", "THERE DOES NOT EXIST"
        txt = txt.replace(/&#x0*?2204;/g, '∄');
        txt = txt.replace(/&#0*?8708;/g, '∄');
        txt = txt.replace(/&nexist;/g, '∄');
        txt = txt.replace(/&NotExists;/g, '∄');
        txt = txt.replace(/&nexists;/g, '∄');

        // "U+02205", "EMPTY SET"
        txt = txt.replace(/&#x0*?2205;/g, '∅');
        txt = txt.replace(/&#0*?8709;/g, '∅');
        txt = txt.replace(/&empty;/g, '∅');
        txt = txt.replace(/&emptyset;/g, '∅');
        txt = txt.replace(/&emptyv;/g, '∅');
        txt = txt.replace(/&varnothing;/g, '∅');

        // "U+02207", "NABLA"
        txt = txt.replace(/&#x0*?2207;/g, '∇');
        txt = txt.replace(/&#0*?8711;/g, '∇');
        txt = txt.replace(/&nabla;/g, '∇');
        txt = txt.replace(/&Del;/g, '∇');

        // "U+02208", "ELEMENT OF"
        txt = txt.replace(/&#x0*?2208;/g, '∈');
        txt = txt.replace(/&#0*?8712;/g, '∈');
        txt = txt.replace(/&isin;/g, '∈');
        txt = txt.replace(/&isinv;/g, '∈');
        txt = txt.replace(/&Element;/g, '∈');
        txt = txt.replace(/&in;/g, '∈');

        // "U+02209", "NOT AN ELEMENT OF"
        txt = txt.replace(/&#x0*?2209;/g, '∉');
        txt = txt.replace(/&#0*?8713;/g, '∉');
        txt = txt.replace(/&notin;/g, '∉');
        txt = txt.replace(/&NotElement;/g, '∉');
        txt = txt.replace(/&notinva;/g, '∉');

        // "U+0220B", "CONTAINS AS MEMBER"
        txt = txt.replace(/&#x0*?220B;/g, '∋');
        txt = txt.replace(/&#0*?8715;/g, '∋');
        txt = txt.replace(/&niv;/g, '∋');
        txt = txt.replace(/&ReverseElement;/g, '∋');
        txt = txt.replace(/&ni;/g, '∋');
        txt = txt.replace(/&SuchThat;/g, '∋');

        // "U+0220C", "DOES NOT CONTAIN AS MEMBER"
        txt = txt.replace(/&#x0*?220C;/g, '∌');
        txt = txt.replace(/&#0*?8716;/g, '∌');
        txt = txt.replace(/&notni;/g, '∌');
        txt = txt.replace(/&notniva;/g, '∌');
        txt = txt.replace(/&NotReverseElement;/g, '∌');

        // "U+0220F", "N-ARY PRODUCT"
        txt = txt.replace(/&#x0*?220F;/g, '∏');
        txt = txt.replace(/&#0*?8719;/g, '∏');
        txt = txt.replace(/&prod;/g, '∏');
        txt = txt.replace(/&Product;/g, '∏');

        // "U+02210", "N-ARY COPRODUCT"
        txt = txt.replace(/&#x0*?2210;/g, '∐');
        txt = txt.replace(/&#0*?8720;/g, '∐');
        txt = txt.replace(/&coprod;/g, '∐');
        txt = txt.replace(/&Coproduct;/g, '∐');

        // "U+02211", "N-ARY SUMMATION"
        txt = txt.replace(/&#x0*?2211;/g, '∑');
        txt = txt.replace(/&#0*?8721;/g, '∑');
        txt = txt.replace(/&sum;/g, '∑');
        txt = txt.replace(/&Sum;/g, '∑');

        // "U+02212", "MINUS SIGN"
        txt = txt.replace(/&#x0*?2212;/g, '−');
        txt = txt.replace(/&#0*?8722;/g, '−');
        txt = txt.replace(/&minus;/g, '−');

        // "U+02213", "MINUS-OR-PLUS SIGN"
        txt = txt.replace(/&#x0*?2213;/g, '∓');
        txt = txt.replace(/&#0*?8723;/g, '∓');
        txt = txt.replace(/&mnplus;/g, '∓');
        txt = txt.replace(/&mp;/g, '∓');
        txt = txt.replace(/&MinusPlus;/g, '∓');

        // "U+02214", "DOT PLUS"
        txt = txt.replace(/&#x0*?2214;/g, '∔');
        txt = txt.replace(/&#0*?8724;/g, '∔');
        txt = txt.replace(/&plusdo;/g, '∔');
        txt = txt.replace(/&dotplus;/g, '∔');

        // "U+02216", "SET MINUS"
        txt = txt.replace(/&#x0*?2216;/g, '∖');
        txt = txt.replace(/&#0*?8726;/g, '∖');
        txt = txt.replace(/&setmn;/g, '∖');
        txt = txt.replace(/&setminus;/g, '∖');
        txt = txt.replace(/&Backslash;/g, '∖');
        txt = txt.replace(/&ssetmn;/g, '∖');
        txt = txt.replace(/&smallsetminus;/g, '∖');

        // "U+02217", "ASTERISK OPERATOR"
        txt = txt.replace(/&#x0*?2217;/g, '∗');
        txt = txt.replace(/&#0*?8727;/g, '∗');
        txt = txt.replace(/&lowast;/g, '∗');

        // "U+02218", "RING OPERATOR"
        txt = txt.replace(/&#x0*?2218;/g, '∘');
        txt = txt.replace(/&#0*?8728;/g, '∘');
        txt = txt.replace(/&compfn;/g, '∘');
        txt = txt.replace(/&SmallCircle;/g, '∘');

        // "U+0221A", "SQUARE ROOT"
        txt = txt.replace(/&#x0*?221A;/g, '√');
        txt = txt.replace(/&#0*?8730;/g, '√');
        txt = txt.replace(/&radic;/g, '√');
        txt = txt.replace(/&Sqrt;/g, '√');

        // "U+0221D", "PROPORTIONAL TO"
        txt = txt.replace(/&#x0*?221D;/g, '∝');
        txt = txt.replace(/&#0*?8733;/g, '∝');
        txt = txt.replace(/&prop;/g, '∝');
        txt = txt.replace(/&propto;/g, '∝');
        txt = txt.replace(/&Proportional;/g, '∝');
        txt = txt.replace(/&vprop;/g, '∝');
        txt = txt.replace(/&varpropto;/g, '∝');

        // "U+0221E", "INFINITY"
        txt = txt.replace(/&#x0*?221E;/g, '∞');
        txt = txt.replace(/&#0*?8734;/g, '∞');
        txt = txt.replace(/&infin;/g, '∞');

        // "U+0221F", "RIGHT ANGLE"
        txt = txt.replace(/&#x0*?221F;/g, '∟');
        txt = txt.replace(/&#0*?8735;/g, '∟');
        txt = txt.replace(/&angrt;/g, '∟');

        // "U+02220", "ANGLE"
        txt = txt.replace(/&#x0*?2220;/g, '∠');
        txt = txt.replace(/&#0*?8736;/g, '∠');
        txt = txt.replace(/&ang;/g, '∠');
        txt = txt.replace(/&angle;/g, '∠');

        // "U+02221", "MEASURED ANGLE"
        txt = txt.replace(/&#x0*?2221;/g, '∡');
        txt = txt.replace(/&#0*?8737;/g, '∡');
        txt = txt.replace(/&angmsd;/g, '∡');
        txt = txt.replace(/&measuredangle;/g, '∡');

        // "U+02222", "SPHERICAL ANGLE"
        txt = txt.replace(/&#x0*?2222;/g, '∢');
        txt = txt.replace(/&#0*?8738;/g, '∢');
        txt = txt.replace(/&angsph;/g, '∢');

        // "U+02223", "DIVIDES"
        txt = txt.replace(/&#x0*?2223;/g, '∣');
        txt = txt.replace(/&#0*?8739;/g, '∣');
        txt = txt.replace(/&mid;/g, '∣');
        txt = txt.replace(/&VerticalBar;/g, '∣');
        txt = txt.replace(/&smid;/g, '∣');
        txt = txt.replace(/&shortmid;/g, '∣');

        // "U+02224", "DOES NOT DIVIDE"
        txt = txt.replace(/&#x0*?2224;/g, '∤');
        txt = txt.replace(/&#0*?8740;/g, '∤');
        txt = txt.replace(/&nmid;/g, '∤');
        txt = txt.replace(/&NotVerticalBar;/g, '∤');
        txt = txt.replace(/&nsmid;/g, '∤');
        txt = txt.replace(/&nshortmid;/g, '∤');

        // "U+02225", "PARALLEL TO"
        txt = txt.replace(/&#x0*?2225;/g, '∥');
        txt = txt.replace(/&#0*?8741;/g, '∥');
        txt = txt.replace(/&par;/g, '∥');
        txt = txt.replace(/&parallel;/g, '∥');
        txt = txt.replace(/&DoubleVerticalBar;/g, '∥');
        txt = txt.replace(/&spar;/g, '∥');
        txt = txt.replace(/&shortparallel;/g, '∥');

        // "U+02226", "NOT PARALLEL TO"
        txt = txt.replace(/&#x0*?2226;/g, '∦');
        txt = txt.replace(/&#0*?8742;/g, '∦');
        txt = txt.replace(/&npar;/g, '∦');
        txt = txt.replace(/&nparallel;/g, '∦');
        txt = txt.replace(/&NotDoubleVerticalBar;/g, '∦');
        txt = txt.replace(/&nspar;/g, '∦');
        txt = txt.replace(/&nshortparallel;/g, '∦');

        // "U+02227", "LOGICAL AND"
        txt = txt.replace(/&#x0*?2227;/g, '∧');
        txt = txt.replace(/&#0*?8743;/g, '∧');
        txt = txt.replace(/&and;/g, '∧');
        txt = txt.replace(/&wedge;/g, '∧');

        // "U+02228", "LOGICAL OR"
        txt = txt.replace(/&#x0*?2228;/g, '∨');
        txt = txt.replace(/&#0*?8744;/g, '∨');
        txt = txt.replace(/&or;/g, '∨');
        txt = txt.replace(/&vee;/g, '∨');

        // "U+02229", "INTERSECTION"
        txt = txt.replace(/&#x0*?2229;/g, '∩');
        txt = txt.replace(/&#0*?8745;/g, '∩');
        txt = txt.replace(/&cap;/g, '∩');

        // "U+0222A", "UNION"
        txt = txt.replace(/&#x0*?222A;/g, '∪');
        txt = txt.replace(/&#0*?8746;/g, '∪');
        txt = txt.replace(/&cup;/g, '∪');

        // "U+0222B", "INTEGRAL"
        txt = txt.replace(/&#x0*?222B;/g, '∫');
        txt = txt.replace(/&#0*?8747;/g, '∫');
        txt = txt.replace(/&int;/g, '∫');
        txt = txt.replace(/&Integral;/g, '∫');

        // "U+0222C", "DOUBLE INTEGRAL"
        txt = txt.replace(/&#x0*?222C;/g, '∬');
        txt = txt.replace(/&#0*?8748;/g, '∬');
        txt = txt.replace(/&Int;/g, '∬');

        // "U+0222D", "TRIPLE INTEGRAL"
        txt = txt.replace(/&#x0*?222D;/g, '∭');
        txt = txt.replace(/&#0*?8749;/g, '∭');
        txt = txt.replace(/&tint;/g, '∭');
        txt = txt.replace(/&iiint;/g, '∭');

        // "U+0222E", "CONTOUR INTEGRAL"
        txt = txt.replace(/&#x0*?222E;/g, '∮');
        txt = txt.replace(/&#0*?8750;/g, '∮');
        txt = txt.replace(/&conint;/g, '∮');
        txt = txt.replace(/&oint;/g, '∮');
        txt = txt.replace(/&ContourIntegral;/g, '∮');

        // "U+0222F", "SURFACE INTEGRAL"
        txt = txt.replace(/&#x0*?222F;/g, '∯');
        txt = txt.replace(/&#0*?8751;/g, '∯');
        txt = txt.replace(/&Conint;/g, '∯');
        txt = txt.replace(/&DoubleContourIntegral;/g, '∯');

        // "U+02230", "VOLUME INTEGRAL"
        txt = txt.replace(/&#x0*?2230;/g, '∰');
        txt = txt.replace(/&#0*?8752;/g, '∰');
        txt = txt.replace(/&Cconint;/g, '∰');

        // "U+02231", "CLOCKWISE INTEGRAL"
        txt = txt.replace(/&#x0*?2231;/g, '∱');
        txt = txt.replace(/&#0*?8753;/g, '∱');
        txt = txt.replace(/&cwint;/g, '∱');

        // "U+02232", "CLOCKWISE CONTOUR INTEGRAL"
        txt = txt.replace(/&#x0*?2232;/g, '∲');
        txt = txt.replace(/&#0*?8754;/g, '∲');
        txt = txt.replace(/&cwconint;/g, '∲');
        txt = txt.replace(/&ClockwiseContourIntegral;/g, '∲');

        // "U+02233", "ANTICLOCKWISE CONTOUR INTEGRAL"
        txt = txt.replace(/&#x0*?2233;/g, '∳');
        txt = txt.replace(/&#0*?8755;/g, '∳');
        txt = txt.replace(/&awconint;/g, '∳');
        txt = txt.replace(/&CounterClockwiseContourIntegral;/g, '∳');

        // "U+02234", "THEREFORE"
        txt = txt.replace(/&#x0*?2234;/g, '∴');
        txt = txt.replace(/&#0*?8756;/g, '∴');
        txt = txt.replace(/&there4;/g, '∴');
        txt = txt.replace(/&therefore;/g, '∴');
        txt = txt.replace(/&Therefore;/g, '∴');

        // "U+02235", "BECAUSE"
        txt = txt.replace(/&#x0*?2235;/g, '∵');
        txt = txt.replace(/&#0*?8757;/g, '∵');
        txt = txt.replace(/&becaus;/g, '∵');
        txt = txt.replace(/&because;/g, '∵');
        txt = txt.replace(/&Because;/g, '∵');

        // "U+02236", "RATIO"
        txt = txt.replace(/&#x0*?2236;/g, '∶');
        txt = txt.replace(/&#0*?8758;/g, '∶');
        txt = txt.replace(/&ratio;/g, '∶');

        // "U+02237", "PROPORTION"
        txt = txt.replace(/&#x0*?2237;/g, '∷');
        txt = txt.replace(/&#0*?8759;/g, '∷');
        txt = txt.replace(/&Colon;/g, '∷');
        txt = txt.replace(/&Proportion;/g, '∷');

        // "U+02238", "DOT MINUS"
        txt = txt.replace(/&#x0*?2238;/g, '∸');
        txt = txt.replace(/&#0*?8760;/g, '∸');
        txt = txt.replace(/&minusd;/g, '∸');
        txt = txt.replace(/&dotminus;/g, '∸');

        // "U+0223A", "GEOMETRIC PROPORTION"
        txt = txt.replace(/&#x0*?223A;/g, '∺');
        txt = txt.replace(/&#0*?8762;/g, '∺');
        txt = txt.replace(/&mDDot;/g, '∺');

        // "U+0223B", "HOMOTHETIC"
        txt = txt.replace(/&#x0*?223B;/g, '∻');
        txt = txt.replace(/&#0*?8763;/g, '∻');
        txt = txt.replace(/&homtht;/g, '∻');

        // "U+0223C", "TILDE OPERATOR"
        txt = txt.replace(/&#x0*?223C;/g, '∼');
        txt = txt.replace(/&#0*?8764;/g, '∼');
        txt = txt.replace(/&sim;/g, '∼');
        txt = txt.replace(/&Tilde;/g, '∼');
        txt = txt.replace(/&thksim;/g, '∼');
        txt = txt.replace(/&thicksim;/g, '∼');

        // "U+0223D", "REVERSED TILDE"
        txt = txt.replace(/&#x0*?223D;/g, '∽');
        txt = txt.replace(/&#0*?8765;/g, '∽');
        txt = txt.replace(/&bsim;/g, '∽');
        txt = txt.replace(/&backsim;/g, '∽');

        // "U+0223E", "INVERTED LAZY S"
        txt = txt.replace(/&#x0*?223E;/g, '∾');
        txt = txt.replace(/&#0*?8766;/g, '∾');
        txt = txt.replace(/&ac;/g, '∾');
        txt = txt.replace(/&mstpos;/g, '∾');

        // "U+0223F", "SINE WAVE"
        txt = txt.replace(/&#x0*?223F;/g, '∿');
        txt = txt.replace(/&#0*?8767;/g, '∿');
        txt = txt.replace(/&acd;/g, '∿');

        // "U+02240", "WREATH PRODUCT"
        txt = txt.replace(/&#x0*?2240;/g, '≀');
        txt = txt.replace(/&#0*?8768;/g, '≀');
        txt = txt.replace(/&wreath;/g, '≀');
        txt = txt.replace(/&VerticalTilde;/g, '≀');
        txt = txt.replace(/&wr;/g, '≀');

        // "U+02241", "NOT TILDE"
        txt = txt.replace(/&#x0*?2241;/g, '≁');
        txt = txt.replace(/&#0*?8769;/g, '≁');
        txt = txt.replace(/&nsim;/g, '≁');
        txt = txt.replace(/&NotTilde;/g, '≁');

        // "U+02242", "MINUS TILDE"
        txt = txt.replace(/&#x0*?2242;/g, '≂');
        txt = txt.replace(/&#0*?8770;/g, '≂');
        txt = txt.replace(/&esim;/g, '≂');
        txt = txt.replace(/&EqualTilde;/g, '≂');
        txt = txt.replace(/&eqsim;/g, '≂');

        // "U+02243", "ASYMPTOTICALLY EQUAL TO"
        txt = txt.replace(/&#x0*?2243;/g, '≃');
        txt = txt.replace(/&#0*?8771;/g, '≃');
        txt = txt.replace(/&sime;/g, '≃');
        txt = txt.replace(/&TildeEqual;/g, '≃');
        txt = txt.replace(/&simeq;/g, '≃');

        // "U+02244", "NOT ASYMPTOTICALLY EQUAL TO"
        txt = txt.replace(/&#x0*?2244;/g, '≄');
        txt = txt.replace(/&#0*?8772;/g, '≄');
        txt = txt.replace(/&nsime;/g, '≄');
        txt = txt.replace(/&nsimeq;/g, '≄');
        txt = txt.replace(/&NotTildeEqual;/g, '≄');

        // "U+02245", "APPROXIMATELY EQUAL TO"
        txt = txt.replace(/&#x0*?2245;/g, '≅');
        txt = txt.replace(/&#0*?8773;/g, '≅');
        txt = txt.replace(/&cong;/g, '≅');
        txt = txt.replace(/&TildeFullEqual;/g, '≅');

        // "U+02246", "APPROXIMATELY BUT NOT ACTUALLY EQUAL TO"
        txt = txt.replace(/&#x0*?2246;/g, '≆');
        txt = txt.replace(/&#0*?8774;/g, '≆');
        txt = txt.replace(/&simne;/g, '≆');

        // "U+02247", "NEITHER APPROXIMATELY NOR ACTUALLY EQUAL TO"
        txt = txt.replace(/&#x0*?2247;/g, '≇');
        txt = txt.replace(/&#0*?8775;/g, '≇');
        txt = txt.replace(/&ncong;/g, '≇');
        txt = txt.replace(/&NotTildeFullEqual;/g, '≇');

        // "U+02248", "ALMOST EQUAL TO"
        txt = txt.replace(/&#x0*?2248;/g, '≈');
        txt = txt.replace(/&#0*?8776;/g, '≈');
        txt = txt.replace(/&asymp;/g, '≈');
        txt = txt.replace(/&ap;/g, '≈');
        txt = txt.replace(/&TildeTilde;/g, '≈');
        txt = txt.replace(/&approx;/g, '≈');
        txt = txt.replace(/&thkap;/g, '≈');
        txt = txt.replace(/&thickapprox;/g, '≈');

        // "U+02249", "NOT ALMOST EQUAL TO"
        txt = txt.replace(/&#x0*?2249;/g, '≉');
        txt = txt.replace(/&#0*?8777;/g, '≉');
        txt = txt.replace(/&nap;/g, '≉');
        txt = txt.replace(/&NotTildeTilde;/g, '≉');
        txt = txt.replace(/&napprox;/g, '≉');

        // "U+0224A", "ALMOST EQUAL OR EQUAL TO"
        txt = txt.replace(/&#x0*?224A;/g, '≊');
        txt = txt.replace(/&#0*?8778;/g, '≊');
        txt = txt.replace(/&ape;/g, '≊');
        txt = txt.replace(/&approxeq;/g, '≊');

        // "U+0224B", "TRIPLE TILDE"
        txt = txt.replace(/&#x0*?224B;/g, '≋');
        txt = txt.replace(/&#0*?8779;/g, '≋');
        txt = txt.replace(/&apid;/g, '≋');

        // "U+0224C", "ALL EQUAL TO"
        txt = txt.replace(/&#x0*?224C;/g, '≌');
        txt = txt.replace(/&#0*?8780;/g, '≌');
        txt = txt.replace(/&bcong;/g, '≌');
        txt = txt.replace(/&backcong;/g, '≌');

        // "U+0224D", "EQUIVALENT TO"
        txt = txt.replace(/&#x0*?224D;/g, '≍');
        txt = txt.replace(/&#0*?8781;/g, '≍');
        txt = txt.replace(/&asympeq;/g, '≍');
        txt = txt.replace(/&CupCap;/g, '≍');

        // "U+0224E", "GEOMETRICALLY EQUIVALENT TO"
        txt = txt.replace(/&#x0*?224E;/g, '≎');
        txt = txt.replace(/&#0*?8782;/g, '≎');
        txt = txt.replace(/&bump;/g, '≎');
        txt = txt.replace(/&HumpDownHump;/g, '≎');
        txt = txt.replace(/&Bumpeq;/g, '≎');

        // "U+0224F", "DIFFERENCE BETWEEN"
        txt = txt.replace(/&#x0*?224F;/g, '≏');
        txt = txt.replace(/&#0*?8783;/g, '≏');
        txt = txt.replace(/&bumpe;/g, '≏');
        txt = txt.replace(/&HumpEqual;/g, '≏');
        txt = txt.replace(/&bumpeq;/g, '≏');

        // "U+02250", "APPROACHES THE LIMIT"
        txt = txt.replace(/&#x0*?2250;/g, '≐');
        txt = txt.replace(/&#0*?8784;/g, '≐');
        txt = txt.replace(/&esdot;/g, '≐');
        txt = txt.replace(/&DotEqual;/g, '≐');
        txt = txt.replace(/&doteq;/g, '≐');

        // "U+02251", "GEOMETRICALLY EQUAL TO"
        txt = txt.replace(/&#x0*?2251;/g, '≑');
        txt = txt.replace(/&#0*?8785;/g, '≑');
        txt = txt.replace(/&eDot;/g, '≑');
        txt = txt.replace(/&doteqdot;/g, '≑');

        // "U+02252", "APPROXIMATELY EQUAL TO OR THE IMAGE OF"
        txt = txt.replace(/&#x0*?2252;/g, '≒');
        txt = txt.replace(/&#0*?8786;/g, '≒');
        txt = txt.replace(/&efDot;/g, '≒');
        txt = txt.replace(/&fallingdotseq;/g, '≒');

        // "U+02253", "IMAGE OF OR APPROXIMATELY EQUAL TO"
        txt = txt.replace(/&#x0*?2253;/g, '≓');
        txt = txt.replace(/&#0*?8787;/g, '≓');
        txt = txt.replace(/&erDot;/g, '≓');
        txt = txt.replace(/&risingdotseq;/g, '≓');

        // "U+02254", "COLON EQUALS"
        txt = txt.replace(/&#x0*?2254;/g, '≔');
        txt = txt.replace(/&#0*?8788;/g, '≔');
        txt = txt.replace(/&colone;/g, '≔');
        txt = txt.replace(/&coloneq;/g, '≔');
        txt = txt.replace(/&Assign;/g, '≔');

        // "U+02255", "EQUALS COLON"
        txt = txt.replace(/&#x0*?2255;/g, '≕');
        txt = txt.replace(/&#0*?8789;/g, '≕');
        txt = txt.replace(/&ecolon;/g, '≕');
        txt = txt.replace(/&eqcolon;/g, '≕');

        // "U+02256", "RING IN EQUAL TO"
        txt = txt.replace(/&#x0*?2256;/g, '≖');
        txt = txt.replace(/&#0*?8790;/g, '≖');
        txt = txt.replace(/&ecir;/g, '≖');
        txt = txt.replace(/&eqcirc;/g, '≖');

        // "U+02257", "RING EQUAL TO"
        txt = txt.replace(/&#x0*?2257;/g, '≗');
        txt = txt.replace(/&#0*?8791;/g, '≗');
        txt = txt.replace(/&cire;/g, '≗');
        txt = txt.replace(/&circeq;/g, '≗');

        // "U+02259", "ESTIMATES"
        txt = txt.replace(/&#x0*?2259;/g, '≙');
        txt = txt.replace(/&#0*?8793;/g, '≙');
        txt = txt.replace(/&wedgeq;/g, '≙');

        // "U+0225A", "EQUIANGULAR TO"
        txt = txt.replace(/&#x0*?225A;/g, '≚');
        txt = txt.replace(/&#0*?8794;/g, '≚');
        txt = txt.replace(/&veeeq;/g, '≚');

        // "U+0225C", "DELTA EQUAL TO"
        txt = txt.replace(/&#x0*?225C;/g, '≜');
        txt = txt.replace(/&#0*?8796;/g, '≜');
        txt = txt.replace(/&trie;/g, '≜');
        txt = txt.replace(/&triangleq;/g, '≜');

        // "U+0225F", "QUESTIONED EQUAL TO"
        txt = txt.replace(/&#x0*?225F;/g, '≟');
        txt = txt.replace(/&#0*?8799;/g, '≟');
        txt = txt.replace(/&equest;/g, '≟');
        txt = txt.replace(/&questeq;/g, '≟');

        // "U+02260", "NOT EQUAL TO"
        txt = txt.replace(/&#x0*?2260;/g, '≠');
        txt = txt.replace(/&#0*?8800;/g, '≠');
        txt = txt.replace(/&ne;/g, '≠');
        txt = txt.replace(/&NotEqual;/g, '≠');

        // "U+02261", "IDENTICAL TO"
        txt = txt.replace(/&#x0*?2261;/g, '≡');
        txt = txt.replace(/&#0*?8801;/g, '≡');
        txt = txt.replace(/&equiv;/g, '≡');
        txt = txt.replace(/&Congruent;/g, '≡');

        // "U+02262", "NOT IDENTICAL TO"
        txt = txt.replace(/&#x0*?2262;/g, '≢');
        txt = txt.replace(/&#0*?8802;/g, '≢');
        txt = txt.replace(/&nequiv;/g, '≢');
        txt = txt.replace(/&NotCongruent;/g, '≢');

        // "U+02264", "LESS-THAN OR EQUAL TO"
        txt = txt.replace(/&#x0*?2264;/g, '≤');
        txt = txt.replace(/&#0*?8804;/g, '≤');
        txt = txt.replace(/&le;/g, '≤');
        txt = txt.replace(/&leq;/g, '≤');

        // "U+02265", "GREATER-THAN OR EQUAL TO"
        txt = txt.replace(/&#x0*?2265;/g, '≥');
        txt = txt.replace(/&#0*?8805;/g, '≥');
        txt = txt.replace(/&ge;/g, '≥');
        txt = txt.replace(/&GreaterEqual;/g, '≥');
        txt = txt.replace(/&geq;/g, '≥');

        // "U+02266", "LESS-THAN OVER EQUAL TO"
        txt = txt.replace(/&#x0*?2266;/g, '≦');
        txt = txt.replace(/&#0*?8806;/g, '≦');
        txt = txt.replace(/&lE;/g, '≦');
        txt = txt.replace(/&LessFullEqual;/g, '≦');
        txt = txt.replace(/&leqq;/g, '≦');

        // "U+02267", "GREATER-THAN OVER EQUAL TO"
        txt = txt.replace(/&#x0*?2267;/g, '≧');
        txt = txt.replace(/&#0*?8807;/g, '≧');
        txt = txt.replace(/&gE;/g, '≧');
        txt = txt.replace(/&GreaterFullEqual;/g, '≧');
        txt = txt.replace(/&geqq;/g, '≧');

        // "U+02268", "LESS-THAN BUT NOT EQUAL TO"
        txt = txt.replace(/&#x0*?2268;/g, '≨');
        txt = txt.replace(/&#0*?8808;/g, '≨');
        txt = txt.replace(/&lnE;/g, '≨');
        txt = txt.replace(/&lneqq;/g, '≨');

        // "U+02269", "GREATER-THAN BUT NOT EQUAL TO"
        txt = txt.replace(/&#x0*?2269;/g, '≩');
        txt = txt.replace(/&#0*?8809;/g, '≩');
        txt = txt.replace(/&gnE;/g, '≩');
        txt = txt.replace(/&gneqq;/g, '≩');

        // "U+0226A", "MUCH LESS-THAN"
        txt = txt.replace(/&#x0*?226A;/g, '≪');
        txt = txt.replace(/&#0*?8810;/g, '≪');
        txt = txt.replace(/&Lt;/g, '≪');
        txt = txt.replace(/&NestedLessLess;/g, '≪');
        txt = txt.replace(/&ll;/g, '≪');

        // "U+0226B", "MUCH GREATER-THAN"
        txt = txt.replace(/&#x0*?226B;/g, '≫');
        txt = txt.replace(/&#0*?8811;/g, '≫');
        txt = txt.replace(/&Gt;/g, '≫');
        txt = txt.replace(/&NestedGreaterGreater;/g, '≫');
        txt = txt.replace(/&gg;/g, '≫');

        // "U+0226C", "BETWEEN"
        txt = txt.replace(/&#x0*?226C;/g, '≬');
        txt = txt.replace(/&#0*?8812;/g, '≬');
        txt = txt.replace(/&twixt;/g, '≬');
        txt = txt.replace(/&between;/g, '≬');

        // "U+0226D", "NOT EQUIVALENT TO"
        txt = txt.replace(/&#x0*?226D;/g, '≭');
        txt = txt.replace(/&#0*?8813;/g, '≭');
        txt = txt.replace(/&NotCupCap;/g, '≭');

        // "U+0226E", "NOT LESS-THAN"
        txt = txt.replace(/&#x0*?226E;/g, '≮');
        txt = txt.replace(/&#0*?8814;/g, '≮');
        txt = txt.replace(/&nlt;/g, '≮');
        txt = txt.replace(/&NotLess;/g, '≮');
        txt = txt.replace(/&nless;/g, '≮');

        // "U+0226F", "NOT GREATER-THAN"
        txt = txt.replace(/&#x0*?226F;/g, '≯');
        txt = txt.replace(/&#0*?8815;/g, '≯');
        txt = txt.replace(/&ngt;/g, '≯');
        txt = txt.replace(/&NotGreater;/g, '≯');
        txt = txt.replace(/&ngtr;/g, '≯');

        // "U+02270", "NEITHER LESS-THAN NOR EQUAL TO"
        txt = txt.replace(/&#x0*?2270;/g, '≰');
        txt = txt.replace(/&#0*?8816;/g, '≰');
        txt = txt.replace(/&nle;/g, '≰');
        txt = txt.replace(/&NotLessEqual;/g, '≰');
        txt = txt.replace(/&nleq;/g, '≰');

        // "U+02271", "NEITHER GREATER-THAN NOR EQUAL TO"
        txt = txt.replace(/&#x0*?2271;/g, '≱');
        txt = txt.replace(/&#0*?8817;/g, '≱');
        txt = txt.replace(/&nge;/g, '≱');
        txt = txt.replace(/&NotGreaterEqual;/g, '≱');
        txt = txt.replace(/&ngeq;/g, '≱');

        // "U+02272", "LESS-THAN OR EQUIVALENT TO"
        txt = txt.replace(/&#x0*?2272;/g, '≲');
        txt = txt.replace(/&#0*?8818;/g, '≲');
        txt = txt.replace(/&lsim;/g, '≲');
        txt = txt.replace(/&LessTilde;/g, '≲');
        txt = txt.replace(/&lesssim;/g, '≲');

        // "U+02273", "GREATER-THAN OR EQUIVALENT TO"
        txt = txt.replace(/&#x0*?2273;/g, '≳');
        txt = txt.replace(/&#0*?8819;/g, '≳');
        txt = txt.replace(/&gsim;/g, '≳');
        txt = txt.replace(/&gtrsim;/g, '≳');
        txt = txt.replace(/&GreaterTilde;/g, '≳');

        // "U+02274", "NEITHER LESS-THAN NOR EQUIVALENT TO"
        txt = txt.replace(/&#x0*?2274;/g, '≴');
        txt = txt.replace(/&#0*?8820;/g, '≴');
        txt = txt.replace(/&nlsim;/g, '≴');
        txt = txt.replace(/&NotLessTilde;/g, '≴');

        // "U+02275", "NEITHER GREATER-THAN NOR EQUIVALENT TO"
        txt = txt.replace(/&#x0*?2275;/g, '≵');
        txt = txt.replace(/&#0*?8821;/g, '≵');
        txt = txt.replace(/&ngsim;/g, '≵');
        txt = txt.replace(/&NotGreaterTilde;/g, '≵');

        // "U+02276", "LESS-THAN OR GREATER-THAN"
        txt = txt.replace(/&#x0*?2276;/g, '≶');
        txt = txt.replace(/&#0*?8822;/g, '≶');
        txt = txt.replace(/&lg;/g, '≶');
        txt = txt.replace(/&lessgtr;/g, '≶');
        txt = txt.replace(/&LessGreater;/g, '≶');

        // "U+02277", "GREATER-THAN OR LESS-THAN"
        txt = txt.replace(/&#x0*?2277;/g, '≷');
        txt = txt.replace(/&#0*?8823;/g, '≷');
        txt = txt.replace(/&gl;/g, '≷');
        txt = txt.replace(/&gtrless;/g, '≷');
        txt = txt.replace(/&GreaterLess;/g, '≷');

        // "U+02278", "NEITHER LESS-THAN NOR GREATER-THAN"
        txt = txt.replace(/&#x0*?2278;/g, '≸');
        txt = txt.replace(/&#0*?8824;/g, '≸');
        txt = txt.replace(/&ntlg;/g, '≸');
        txt = txt.replace(/&NotLessGreater;/g, '≸');

        // "U+02279", "NEITHER GREATER-THAN NOR LESS-THAN"
        txt = txt.replace(/&#x0*?2279;/g, '≹');
        txt = txt.replace(/&#0*?8825;/g, '≹');
        txt = txt.replace(/&ntgl;/g, '≹');
        txt = txt.replace(/&NotGreaterLess;/g, '≹');

        // "U+0227A", "PRECEDES"
        txt = txt.replace(/&#x0*?227A;/g, '≺');
        txt = txt.replace(/&#0*?8826;/g, '≺');
        txt = txt.replace(/&pr;/g, '≺');
        txt = txt.replace(/&Precedes;/g, '≺');
        txt = txt.replace(/&prec;/g, '≺');

        // "U+0227B", "SUCCEEDS"
        txt = txt.replace(/&#x0*?227B;/g, '≻');
        txt = txt.replace(/&#0*?8827;/g, '≻');
        txt = txt.replace(/&sc;/g, '≻');
        txt = txt.replace(/&Succeeds;/g, '≻');
        txt = txt.replace(/&succ;/g, '≻');

        // "U+0227C", "PRECEDES OR EQUAL TO"
        txt = txt.replace(/&#x0*?227C;/g, '≼');
        txt = txt.replace(/&#0*?8828;/g, '≼');
        txt = txt.replace(/&prcue;/g, '≼');
        txt = txt.replace(/&PrecedesSlantEqual;/g, '≼');
        txt = txt.replace(/&preccurlyeq;/g, '≼');

        // "U+0227D", "SUCCEEDS OR EQUAL TO"
        txt = txt.replace(/&#x0*?227D;/g, '≽');
        txt = txt.replace(/&#0*?8829;/g, '≽');
        txt = txt.replace(/&sccue;/g, '≽');
        txt = txt.replace(/&SucceedsSlantEqual;/g, '≽');
        txt = txt.replace(/&succcurlyeq;/g, '≽');

        // "U+0227E", "PRECEDES OR EQUIVALENT TO"
        txt = txt.replace(/&#x0*?227E;/g, '≾');
        txt = txt.replace(/&#0*?8830;/g, '≾');
        txt = txt.replace(/&prsim;/g, '≾');
        txt = txt.replace(/&precsim;/g, '≾');
        txt = txt.replace(/&PrecedesTilde;/g, '≾');

        // "U+0227F", "SUCCEEDS OR EQUIVALENT TO"
        txt = txt.replace(/&#x0*?227F;/g, '≿');
        txt = txt.replace(/&#0*?8831;/g, '≿');
        txt = txt.replace(/&scsim;/g, '≿');
        txt = txt.replace(/&succsim;/g, '≿');
        txt = txt.replace(/&SucceedsTilde;/g, '≿');

        // "U+02280", "DOES NOT PRECEDE"
        txt = txt.replace(/&#x0*?2280;/g, '⊀');
        txt = txt.replace(/&#0*?8832;/g, '⊀');
        txt = txt.replace(/&npr;/g, '⊀');
        txt = txt.replace(/&nprec;/g, '⊀');
        txt = txt.replace(/&NotPrecedes;/g, '⊀');

        // "U+02281", "DOES NOT SUCCEED"
        txt = txt.replace(/&#x0*?2281;/g, '⊁');
        txt = txt.replace(/&#0*?8833;/g, '⊁');
        txt = txt.replace(/&nsc;/g, '⊁');
        txt = txt.replace(/&nsucc;/g, '⊁');
        txt = txt.replace(/&NotSucceeds;/g, '⊁');

        // "U+02282", "SUBSET OF"
        txt = txt.replace(/&#x0*?2282;/g, '⊂');
        txt = txt.replace(/&#0*?8834;/g, '⊂');
        txt = txt.replace(/&sub;/g, '⊂');
        txt = txt.replace(/&subset;/g, '⊂');

        // "U+02283", "SUPERSET OF"
        txt = txt.replace(/&#x0*?2283;/g, '⊃');
        txt = txt.replace(/&#0*?8835;/g, '⊃');
        txt = txt.replace(/&sup;/g, '⊃');
        txt = txt.replace(/&supset;/g, '⊃');
        txt = txt.replace(/&Superset;/g, '⊃');

        // "U+02284", "NOT A SUBSET OF"
        txt = txt.replace(/&#x0*?2284;/g, '⊄');
        txt = txt.replace(/&#0*?8836;/g, '⊄');
        txt = txt.replace(/&nsub;/g, '⊄');

        // "U+02285", "NOT A SUPERSET OF"
        txt = txt.replace(/&#x0*?2285;/g, '⊅');
        txt = txt.replace(/&#0*?8837;/g, '⊅');
        txt = txt.replace(/&nsup;/g, '⊅');

        // "U+02286", "SUBSET OF OR EQUAL TO"
        txt = txt.replace(/&#x0*?2286;/g, '⊆');
        txt = txt.replace(/&#0*?8838;/g, '⊆');
        txt = txt.replace(/&sube;/g, '⊆');
        txt = txt.replace(/&SubsetEqual;/g, '⊆');
        txt = txt.replace(/&subseteq;/g, '⊆');

        // "U+02287", "SUPERSET OF OR EQUAL TO"
        txt = txt.replace(/&#x0*?2287;/g, '⊇');
        txt = txt.replace(/&#0*?8839;/g, '⊇');
        txt = txt.replace(/&supe;/g, '⊇');
        txt = txt.replace(/&supseteq;/g, '⊇');
        txt = txt.replace(/&SupersetEqual;/g, '⊇');

        // "U+02288", "NEITHER A SUBSET OF NOR EQUAL TO"
        txt = txt.replace(/&#x0*?2288;/g, '⊈');
        txt = txt.replace(/&#0*?8840;/g, '⊈');
        txt = txt.replace(/&nsube;/g, '⊈');
        txt = txt.replace(/&nsubseteq;/g, '⊈');
        txt = txt.replace(/&NotSubsetEqual;/g, '⊈');

        // "U+02289", "NEITHER A SUPERSET OF NOR EQUAL TO"
        txt = txt.replace(/&#x0*?2289;/g, '⊉');
        txt = txt.replace(/&#0*?8841;/g, '⊉');
        txt = txt.replace(/&nsupe;/g, '⊉');
        txt = txt.replace(/&nsupseteq;/g, '⊉');
        txt = txt.replace(/&NotSupersetEqual;/g, '⊉');

        // "U+0228A", "SUBSET OF WITH NOT EQUAL TO"
        txt = txt.replace(/&#x0*?228A;/g, '⊊');
        txt = txt.replace(/&#0*?8842;/g, '⊊');
        txt = txt.replace(/&subne;/g, '⊊');
        txt = txt.replace(/&subsetneq;/g, '⊊');

        // "U+0228B", "SUPERSET OF WITH NOT EQUAL TO"
        txt = txt.replace(/&#x0*?228B;/g, '⊋');
        txt = txt.replace(/&#0*?8843;/g, '⊋');
        txt = txt.replace(/&supne;/g, '⊋');
        txt = txt.replace(/&supsetneq;/g, '⊋');

        // "U+0228D", "MULTISET MULTIPLICATION"
        txt = txt.replace(/&#x0*?228D;/g, '⊍');
        txt = txt.replace(/&#0*?8845;/g, '⊍');
        txt = txt.replace(/&cupdot;/g, '⊍');

        // "U+0228E", "MULTISET UNION"
        txt = txt.replace(/&#x0*?228E;/g, '⊎');
        txt = txt.replace(/&#0*?8846;/g, '⊎');
        txt = txt.replace(/&uplus;/g, '⊎');
        txt = txt.replace(/&UnionPlus;/g, '⊎');

        // "U+0228F", "SQUARE IMAGE OF"
        txt = txt.replace(/&#x0*?228F;/g, '⊏');
        txt = txt.replace(/&#0*?8847;/g, '⊏');
        txt = txt.replace(/&sqsub;/g, '⊏');
        txt = txt.replace(/&SquareSubset;/g, '⊏');
        txt = txt.replace(/&sqsubset;/g, '⊏');

        // "U+02290", "SQUARE ORIGINAL OF"
        txt = txt.replace(/&#x0*?2290;/g, '⊐');
        txt = txt.replace(/&#0*?8848;/g, '⊐');
        txt = txt.replace(/&sqsup;/g, '⊐');
        txt = txt.replace(/&SquareSuperset;/g, '⊐');
        txt = txt.replace(/&sqsupset;/g, '⊐');

        // "U+02291", "SQUARE IMAGE OF OR EQUAL TO"
        txt = txt.replace(/&#x0*?2291;/g, '⊑');
        txt = txt.replace(/&#0*?8849;/g, '⊑');
        txt = txt.replace(/&sqsube;/g, '⊑');
        txt = txt.replace(/&SquareSubsetEqual;/g, '⊑');
        txt = txt.replace(/&sqsubseteq;/g, '⊑');

        // "U+02292", "SQUARE ORIGINAL OF OR EQUAL TO"
        txt = txt.replace(/&#x0*?2292;/g, '⊒');
        txt = txt.replace(/&#0*?8850;/g, '⊒');
        txt = txt.replace(/&sqsupe;/g, '⊒');
        txt = txt.replace(/&SquareSupersetEqual;/g, '⊒');
        txt = txt.replace(/&sqsupseteq;/g, '⊒');

        // "U+02293", "SQUARE CAP"
        txt = txt.replace(/&#x0*?2293;/g, '⊓');
        txt = txt.replace(/&#0*?8851;/g, '⊓');
        txt = txt.replace(/&sqcap;/g, '⊓');
        txt = txt.replace(/&SquareIntersection;/g, '⊓');

        // "U+02294", "SQUARE CUP"
        txt = txt.replace(/&#x0*?2294;/g, '⊔');
        txt = txt.replace(/&#0*?8852;/g, '⊔');
        txt = txt.replace(/&sqcup;/g, '⊔');
        txt = txt.replace(/&SquareUnion;/g, '⊔');

        // "U+02295", "CIRCLED PLUS"
        txt = txt.replace(/&#x0*?2295;/g, '⊕');
        txt = txt.replace(/&#0*?8853;/g, '⊕');
        txt = txt.replace(/&oplus;/g, '⊕');
        txt = txt.replace(/&CirclePlus;/g, '⊕');

        // "U+02296", "CIRCLED MINUS"
        txt = txt.replace(/&#x0*?2296;/g, '⊖');
        txt = txt.replace(/&#0*?8854;/g, '⊖');
        txt = txt.replace(/&ominus;/g, '⊖');
        txt = txt.replace(/&CircleMinus;/g, '⊖');

        // "U+02297", "CIRCLED TIMES"
        txt = txt.replace(/&#x0*?2297;/g, '⊗');
        txt = txt.replace(/&#0*?8855;/g, '⊗');
        txt = txt.replace(/&otimes;/g, '⊗');
        txt = txt.replace(/&CircleTimes;/g, '⊗');

        // "U+02298", "CIRCLED DIVISION SLASH"
        txt = txt.replace(/&#x0*?2298;/g, '⊘');
        txt = txt.replace(/&#0*?8856;/g, '⊘');
        txt = txt.replace(/&osol;/g, '⊘');

        // "U+02299", "CIRCLED DOT OPERATOR"
        txt = txt.replace(/&#x0*?2299;/g, '⊙');
        txt = txt.replace(/&#0*?8857;/g, '⊙');
        txt = txt.replace(/&odot;/g, '⊙');
        txt = txt.replace(/&CircleDot;/g, '⊙');

        // "U+0229A", "CIRCLED RING OPERATOR"
        txt = txt.replace(/&#x0*?229A;/g, '⊚');
        txt = txt.replace(/&#0*?8858;/g, '⊚');
        txt = txt.replace(/&ocir;/g, '⊚');
        txt = txt.replace(/&circledcirc;/g, '⊚');

        // "U+0229B", "CIRCLED ASTERISK OPERATOR"
        txt = txt.replace(/&#x0*?229B;/g, '⊛');
        txt = txt.replace(/&#0*?8859;/g, '⊛');
        txt = txt.replace(/&oast;/g, '⊛');
        txt = txt.replace(/&circledast;/g, '⊛');

        // "U+0229D", "CIRCLED DASH"
        txt = txt.replace(/&#x0*?229D;/g, '⊝');
        txt = txt.replace(/&#0*?8861;/g, '⊝');
        txt = txt.replace(/&odash;/g, '⊝');
        txt = txt.replace(/&circleddash;/g, '⊝');

        // "U+0229E", "SQUARED PLUS"
        txt = txt.replace(/&#x0*?229E;/g, '⊞');
        txt = txt.replace(/&#0*?8862;/g, '⊞');
        txt = txt.replace(/&plusb;/g, '⊞');
        txt = txt.replace(/&boxplus;/g, '⊞');

        // "U+0229F", "SQUARED MINUS"
        txt = txt.replace(/&#x0*?229F;/g, '⊟');
        txt = txt.replace(/&#0*?8863;/g, '⊟');
        txt = txt.replace(/&minusb;/g, '⊟');
        txt = txt.replace(/&boxminus;/g, '⊟');

        // "U+022A0", "SQUARED TIMES"
        txt = txt.replace(/&#x0*?22A0;/g, '⊠');
        txt = txt.replace(/&#0*?8864;/g, '⊠');
        txt = txt.replace(/&timesb;/g, '⊠');
        txt = txt.replace(/&boxtimes;/g, '⊠');

        // "U+022A1", "SQUARED DOT OPERATOR"
        txt = txt.replace(/&#x0*?22A1;/g, '⊡');
        txt = txt.replace(/&#0*?8865;/g, '⊡');
        txt = txt.replace(/&sdotb;/g, '⊡');
        txt = txt.replace(/&dotsquare;/g, '⊡');

        // "U+022A2", "RIGHT TACK"
        txt = txt.replace(/&#x0*?22A2;/g, '⊢');
        txt = txt.replace(/&#0*?8866;/g, '⊢');
        txt = txt.replace(/&vdash;/g, '⊢');
        txt = txt.replace(/&RightTee;/g, '⊢');

        // "U+022A3", "LEFT TACK"
        txt = txt.replace(/&#x0*?22A3;/g, '⊣');
        txt = txt.replace(/&#0*?8867;/g, '⊣');
        txt = txt.replace(/&dashv;/g, '⊣');
        txt = txt.replace(/&LeftTee;/g, '⊣');

        // "U+022A4", "DOWN TACK"
        txt = txt.replace(/&#x0*?22A4;/g, '⊤');
        txt = txt.replace(/&#0*?8868;/g, '⊤');
        txt = txt.replace(/&top;/g, '⊤');
        txt = txt.replace(/&DownTee;/g, '⊤');

        // "U+022A5", "UP TACK"
        txt = txt.replace(/&#x0*?22A5;/g, '⊥');
        txt = txt.replace(/&#0*?8869;/g, '⊥');
        txt = txt.replace(/&bottom;/g, '⊥');
        txt = txt.replace(/&bot;/g, '⊥');
        txt = txt.replace(/&perp;/g, '⊥');
        txt = txt.replace(/&UpTee;/g, '⊥');

        // "U+022A7", "MODELS"
        txt = txt.replace(/&#x0*?22A7;/g, '⊧');
        txt = txt.replace(/&#0*?8871;/g, '⊧');
        txt = txt.replace(/&models;/g, '⊧');

        // "U+022A8", "TRUE"
        txt = txt.replace(/&#x0*?22A8;/g, '⊨');
        txt = txt.replace(/&#0*?8872;/g, '⊨');
        txt = txt.replace(/&vDash;/g, '⊨');
        txt = txt.replace(/&DoubleRightTee;/g, '⊨');

        // "U+022A9", "FORCES"
        txt = txt.replace(/&#x0*?22A9;/g, '⊩');
        txt = txt.replace(/&#0*?8873;/g, '⊩');
        txt = txt.replace(/&Vdash;/g, '⊩');

        // "U+022AA", "TRIPLE VERTICAL BAR RIGHT TURNSTILE"
        txt = txt.replace(/&#x0*?22AA;/g, '⊪');
        txt = txt.replace(/&#0*?8874;/g, '⊪');
        txt = txt.replace(/&Vvdash;/g, '⊪');

        // "U+022AB", "DOUBLE VERTICAL BAR DOUBLE RIGHT TURNSTILE"
        txt = txt.replace(/&#x0*?22AB;/g, '⊫');
        txt = txt.replace(/&#0*?8875;/g, '⊫');
        txt = txt.replace(/&VDash;/g, '⊫');

        // "U+022AC", "DOES NOT PROVE"
        txt = txt.replace(/&#x0*?22AC;/g, '⊬');
        txt = txt.replace(/&#0*?8876;/g, '⊬');
        txt = txt.replace(/&nvdash;/g, '⊬');

        // "U+022AD", "NOT TRUE"
        txt = txt.replace(/&#x0*?22AD;/g, '⊭');
        txt = txt.replace(/&#0*?8877;/g, '⊭');
        txt = txt.replace(/&nvDash;/g, '⊭');

        // "U+022AE", "DOES NOT FORCE"
        txt = txt.replace(/&#x0*?22AE;/g, '⊮');
        txt = txt.replace(/&#0*?8878;/g, '⊮');
        txt = txt.replace(/&nVdash;/g, '⊮');

        // "U+022AF", "NEGATED DOUBLE VERTICAL BAR DOUBLE RIGHT TURNSTILE"
        txt = txt.replace(/&#x0*?22AF;/g, '⊯');
        txt = txt.replace(/&#0*?8879;/g, '⊯');
        txt = txt.replace(/&nVDash;/g, '⊯');

        // "U+022B0", "PRECEDES UNDER RELATION"
        txt = txt.replace(/&#x0*?22B0;/g, '⊰');
        txt = txt.replace(/&#0*?8880;/g, '⊰');
        txt = txt.replace(/&prurel;/g, '⊰');

        // "U+022B2", "NORMAL SUBGROUP OF"
        txt = txt.replace(/&#x0*?22B2;/g, '⊲');
        txt = txt.replace(/&#0*?8882;/g, '⊲');
        txt = txt.replace(/&vltri;/g, '⊲');
        txt = txt.replace(/&vartriangleleft;/g, '⊲');
        txt = txt.replace(/&LeftTriangle;/g, '⊲');

        // "U+022B3", "CONTAINS AS NORMAL SUBGROUP"
        txt = txt.replace(/&#x0*?22B3;/g, '⊳');
        txt = txt.replace(/&#0*?8883;/g, '⊳');
        txt = txt.replace(/&vrtri;/g, '⊳');
        txt = txt.replace(/&vartriangleright;/g, '⊳');
        txt = txt.replace(/&RightTriangle;/g, '⊳');

        // "U+022B4", "NORMAL SUBGROUP OF OR EQUAL TO"
        txt = txt.replace(/&#x0*?22B4;/g, '⊴');
        txt = txt.replace(/&#0*?8884;/g, '⊴');
        txt = txt.replace(/&ltrie;/g, '⊴');
        txt = txt.replace(/&trianglelefteq;/g, '⊴');
        txt = txt.replace(/&LeftTriangleEqual;/g, '⊴');

        // "U+022B5", "CONTAINS AS NORMAL SUBGROUP OR EQUAL TO"
        txt = txt.replace(/&#x0*?22B5;/g, '⊵');
        txt = txt.replace(/&#0*?8885;/g, '⊵');
        txt = txt.replace(/&rtrie;/g, '⊵');
        txt = txt.replace(/&trianglerighteq;/g, '⊵');
        txt = txt.replace(/&RightTriangleEqual;/g, '⊵');

        // "U+022B6", "ORIGINAL OF"
        txt = txt.replace(/&#x0*?22B6;/g, '⊶');
        txt = txt.replace(/&#0*?8886;/g, '⊶');
        txt = txt.replace(/&origof;/g, '⊶');

        // "U+022B7", "IMAGE OF"
        txt = txt.replace(/&#x0*?22B7;/g, '⊷');
        txt = txt.replace(/&#0*?8887;/g, '⊷');
        txt = txt.replace(/&imof;/g, '⊷');

        // "U+022B8", "MULTIMAP"
        txt = txt.replace(/&#x0*?22B8;/g, '⊸');
        txt = txt.replace(/&#0*?8888;/g, '⊸');
        txt = txt.replace(/&mumap;/g, '⊸');
        txt = txt.replace(/&multimap;/g, '⊸');

        // "U+022B9", "HERMITIAN CONJUGATE MATRIX"
        txt = txt.replace(/&#x0*?22B9;/g, '⊹');
        txt = txt.replace(/&#0*?8889;/g, '⊹');
        txt = txt.replace(/&hercon;/g, '⊹');

        // "U+022BA", "INTERCALATE"
        txt = txt.replace(/&#x0*?22BA;/g, '⊺');
        txt = txt.replace(/&#0*?8890;/g, '⊺');
        txt = txt.replace(/&intcal;/g, '⊺');
        txt = txt.replace(/&intercal;/g, '⊺');

        // "U+022BB", "XOR"
        txt = txt.replace(/&#x0*?22BB;/g, '⊻');
        txt = txt.replace(/&#0*?8891;/g, '⊻');
        txt = txt.replace(/&veebar;/g, '⊻');

        // "U+022BD", "NOR"
        txt = txt.replace(/&#x0*?22BD;/g, '⊽');
        txt = txt.replace(/&#0*?8893;/g, '⊽');
        txt = txt.replace(/&barvee;/g, '⊽');

        // "U+022BE", "RIGHT ANGLE WITH ARC"
        txt = txt.replace(/&#x0*?22BE;/g, '⊾');
        txt = txt.replace(/&#0*?8894;/g, '⊾');
        txt = txt.replace(/&angrtvb;/g, '⊾');

        // "U+022BF", "RIGHT TRIANGLE"
        txt = txt.replace(/&#x0*?22BF;/g, '⊿');
        txt = txt.replace(/&#0*?8895;/g, '⊿');
        txt = txt.replace(/&lrtri;/g, '⊿');

        // "U+022C0", "N-ARY LOGICAL AND"
        txt = txt.replace(/&#x0*?22C0;/g, '⋀');
        txt = txt.replace(/&#0*?8896;/g, '⋀');
        txt = txt.replace(/&xwedge;/g, '⋀');
        txt = txt.replace(/&Wedge;/g, '⋀');
        txt = txt.replace(/&bigwedge;/g, '⋀');

        // "U+022C1", "N-ARY LOGICAL OR"
        txt = txt.replace(/&#x0*?22C1;/g, '⋁');
        txt = txt.replace(/&#0*?8897;/g, '⋁');
        txt = txt.replace(/&xvee;/g, '⋁');
        txt = txt.replace(/&Vee;/g, '⋁');
        txt = txt.replace(/&bigvee;/g, '⋁');

        // "U+022C2", "N-ARY INTERSECTION"
        txt = txt.replace(/&#x0*?22C2;/g, '⋂');
        txt = txt.replace(/&#0*?8898;/g, '⋂');
        txt = txt.replace(/&xcap;/g, '⋂');
        txt = txt.replace(/&Intersection;/g, '⋂');
        txt = txt.replace(/&bigcap;/g, '⋂');

        // "U+022C3", "N-ARY UNION"
        txt = txt.replace(/&#x0*?22C3;/g, '⋃');
        txt = txt.replace(/&#0*?8899;/g, '⋃');
        txt = txt.replace(/&xcup;/g, '⋃');
        txt = txt.replace(/&Union;/g, '⋃');
        txt = txt.replace(/&bigcup;/g, '⋃');

        // "U+022C4", "DIAMOND OPERATOR"
        txt = txt.replace(/&#x0*?22C4;/g, '⋄');
        txt = txt.replace(/&#0*?8900;/g, '⋄');
        txt = txt.replace(/&diam;/g, '⋄');
        txt = txt.replace(/&diamond;/g, '⋄');
        txt = txt.replace(/&Diamond;/g, '⋄');

        // "U+022C5", "DOT OPERATOR"
        txt = txt.replace(/&#x0*?22C5;/g, '⋅');
        txt = txt.replace(/&#0*?8901;/g, '⋅');
        txt = txt.replace(/&sdot;/g, '⋅');

        // "U+022C6", "STAR OPERATOR"
        txt = txt.replace(/&#x0*?22C6;/g, '⋆');
        txt = txt.replace(/&#0*?8902;/g, '⋆');
        txt = txt.replace(/&sstarf;/g, '⋆');
        txt = txt.replace(/&Star;/g, '⋆');

        // "U+022C7", "DIVISION TIMES"
        txt = txt.replace(/&#x0*?22C7;/g, '⋇');
        txt = txt.replace(/&#0*?8903;/g, '⋇');
        txt = txt.replace(/&divonx;/g, '⋇');
        txt = txt.replace(/&divideontimes;/g, '⋇');

        // "U+022C8", "BOWTIE"
        txt = txt.replace(/&#x0*?22C8;/g, '⋈');
        txt = txt.replace(/&#0*?8904;/g, '⋈');
        txt = txt.replace(/&bowtie;/g, '⋈');

        // "U+022C9", "LEFT NORMAL FACTOR SEMIDIRECT PRODUCT"
        txt = txt.replace(/&#x0*?22C9;/g, '⋉');
        txt = txt.replace(/&#0*?8905;/g, '⋉');
        txt = txt.replace(/&ltimes;/g, '⋉');

        // "U+022CA", "RIGHT NORMAL FACTOR SEMIDIRECT PRODUCT"
        txt = txt.replace(/&#x0*?22CA;/g, '⋊');
        txt = txt.replace(/&#0*?8906;/g, '⋊');
        txt = txt.replace(/&rtimes;/g, '⋊');

        // "U+022CB", "LEFT SEMIDIRECT PRODUCT"
        txt = txt.replace(/&#x0*?22CB;/g, '⋋');
        txt = txt.replace(/&#0*?8907;/g, '⋋');
        txt = txt.replace(/&lthree;/g, '⋋');
        txt = txt.replace(/&leftthreetimes;/g, '⋋');

        // "U+022CC", "RIGHT SEMIDIRECT PRODUCT"
        txt = txt.replace(/&#x0*?22CC;/g, '⋌');
        txt = txt.replace(/&#0*?8908;/g, '⋌');
        txt = txt.replace(/&rthree;/g, '⋌');
        txt = txt.replace(/&rightthreetimes;/g, '⋌');

        // "U+022CD", "REVERSED TILDE EQUALS"
        txt = txt.replace(/&#x0*?22CD;/g, '⋍');
        txt = txt.replace(/&#0*?8909;/g, '⋍');
        txt = txt.replace(/&bsime;/g, '⋍');
        txt = txt.replace(/&backsimeq;/g, '⋍');

        // "U+022CE", "CURLY LOGICAL OR"
        txt = txt.replace(/&#x0*?22CE;/g, '⋎');
        txt = txt.replace(/&#0*?8910;/g, '⋎');
        txt = txt.replace(/&cuvee;/g, '⋎');
        txt = txt.replace(/&curlyvee;/g, '⋎');

        // "U+022CF", "CURLY LOGICAL AND"
        txt = txt.replace(/&#x0*?22CF;/g, '⋏');
        txt = txt.replace(/&#0*?8911;/g, '⋏');
        txt = txt.replace(/&cuwed;/g, '⋏');
        txt = txt.replace(/&curlywedge;/g, '⋏');

        // "U+022D0", "DOUBLE SUBSET"
        txt = txt.replace(/&#x0*?22D0;/g, '⋐');
        txt = txt.replace(/&#0*?8912;/g, '⋐');
        txt = txt.replace(/&Sub;/g, '⋐');
        txt = txt.replace(/&Subset;/g, '⋐');

        // "U+022D1", "DOUBLE SUPERSET"
        txt = txt.replace(/&#x0*?22D1;/g, '⋑');
        txt = txt.replace(/&#0*?8913;/g, '⋑');
        txt = txt.replace(/&Sup;/g, '⋑');
        txt = txt.replace(/&Supset;/g, '⋑');

        // "U+022D2", "DOUBLE INTERSECTION"
        txt = txt.replace(/&#x0*?22D2;/g, '⋒');
        txt = txt.replace(/&#0*?8914;/g, '⋒');
        txt = txt.replace(/&Cap;/g, '⋒');

        // "U+022D3", "DOUBLE UNION"
        txt = txt.replace(/&#x0*?22D3;/g, '⋓');
        txt = txt.replace(/&#0*?8915;/g, '⋓');
        txt = txt.replace(/&Cup;/g, '⋓');

        // "U+022D4", "PITCHFORK"
        txt = txt.replace(/&#x0*?22D4;/g, '⋔');
        txt = txt.replace(/&#0*?8916;/g, '⋔');
        txt = txt.replace(/&fork;/g, '⋔');
        txt = txt.replace(/&pitchfork;/g, '⋔');

        // "U+022D5", "EQUAL AND PARALLEL TO"
        txt = txt.replace(/&#x0*?22D5;/g, '⋕');
        txt = txt.replace(/&#0*?8917;/g, '⋕');
        txt = txt.replace(/&epar;/g, '⋕');

        // "U+022D6", "LESS-THAN WITH DOT"
        txt = txt.replace(/&#x0*?22D6;/g, '⋖');
        txt = txt.replace(/&#0*?8918;/g, '⋖');
        txt = txt.replace(/&ltdot;/g, '⋖');
        txt = txt.replace(/&lessdot;/g, '⋖');

        // "U+022D7", "GREATER-THAN WITH DOT"
        txt = txt.replace(/&#x0*?22D7;/g, '⋗');
        txt = txt.replace(/&#0*?8919;/g, '⋗');
        txt = txt.replace(/&gtdot;/g, '⋗');
        txt = txt.replace(/&gtrdot;/g, '⋗');

        // "U+022D8", "VERY MUCH LESS-THAN"
        txt = txt.replace(/&#x0*?22D8;/g, '⋘');
        txt = txt.replace(/&#0*?8920;/g, '⋘');
        txt = txt.replace(/&Ll;/g, '⋘');

        // "U+022D9", "VERY MUCH GREATER-THAN"
        txt = txt.replace(/&#x0*?22D9;/g, '⋙');
        txt = txt.replace(/&#0*?8921;/g, '⋙');
        txt = txt.replace(/&Gg;/g, '⋙');
        txt = txt.replace(/&ggg;/g, '⋙');

        // "U+022DA", "LESS-THAN EQUAL TO OR GREATER-THAN"
        txt = txt.replace(/&#x0*?22DA;/g, '⋚');
        txt = txt.replace(/&#0*?8922;/g, '⋚');
        txt = txt.replace(/&leg;/g, '⋚');
        txt = txt.replace(/&LessEqualGreater;/g, '⋚');
        txt = txt.replace(/&lesseqgtr;/g, '⋚');

        // "U+022DB", "GREATER-THAN EQUAL TO OR LESS-THAN"
        txt = txt.replace(/&#x0*?22DB;/g, '⋛');
        txt = txt.replace(/&#0*?8923;/g, '⋛');
        txt = txt.replace(/&gel;/g, '⋛');
        txt = txt.replace(/&gtreqless;/g, '⋛');
        txt = txt.replace(/&GreaterEqualLess;/g, '⋛');

        // "U+022DE", "EQUAL TO OR PRECEDES"
        txt = txt.replace(/&#x0*?22DE;/g, '⋞');
        txt = txt.replace(/&#0*?8926;/g, '⋞');
        txt = txt.replace(/&cuepr;/g, '⋞');
        txt = txt.replace(/&curlyeqprec;/g, '⋞');

        // "U+022DF", "EQUAL TO OR SUCCEEDS"
        txt = txt.replace(/&#x0*?22DF;/g, '⋟');
        txt = txt.replace(/&#0*?8927;/g, '⋟');
        txt = txt.replace(/&cuesc;/g, '⋟');
        txt = txt.replace(/&curlyeqsucc;/g, '⋟');

        // "U+022E0", "DOES NOT PRECEDE OR EQUAL"
        txt = txt.replace(/&#x0*?22E0;/g, '⋠');
        txt = txt.replace(/&#0*?8928;/g, '⋠');
        txt = txt.replace(/&nprcue;/g, '⋠');
        txt = txt.replace(/&NotPrecedesSlantEqual;/g, '⋠');

        // "U+022E1", "DOES NOT SUCCEED OR EQUAL"
        txt = txt.replace(/&#x0*?22E1;/g, '⋡');
        txt = txt.replace(/&#0*?8929;/g, '⋡');
        txt = txt.replace(/&nsccue;/g, '⋡');
        txt = txt.replace(/&NotSucceedsSlantEqual;/g, '⋡');

        // "U+022E2", "NOT SQUARE IMAGE OF OR EQUAL TO"
        txt = txt.replace(/&#x0*?22E2;/g, '⋢');
        txt = txt.replace(/&#0*?8930;/g, '⋢');
        txt = txt.replace(/&nsqsube;/g, '⋢');
        txt = txt.replace(/&NotSquareSubsetEqual;/g, '⋢');

        // "U+022E3", "NOT SQUARE ORIGINAL OF OR EQUAL TO"
        txt = txt.replace(/&#x0*?22E3;/g, '⋣');
        txt = txt.replace(/&#0*?8931;/g, '⋣');
        txt = txt.replace(/&nsqsupe;/g, '⋣');
        txt = txt.replace(/&NotSquareSupersetEqual;/g, '⋣');

        // "U+022E6", "LESS-THAN BUT NOT EQUIVALENT TO"
        txt = txt.replace(/&#x0*?22E6;/g, '⋦');
        txt = txt.replace(/&#0*?8934;/g, '⋦');
        txt = txt.replace(/&lnsim;/g, '⋦');

        // "U+022E7", "GREATER-THAN BUT NOT EQUIVALENT TO"
        txt = txt.replace(/&#x0*?22E7;/g, '⋧');
        txt = txt.replace(/&#0*?8935;/g, '⋧');
        txt = txt.replace(/&gnsim;/g, '⋧');

        // "U+022E8", "PRECEDES BUT NOT EQUIVALENT TO"
        txt = txt.replace(/&#x0*?22E8;/g, '⋨');
        txt = txt.replace(/&#0*?8936;/g, '⋨');
        txt = txt.replace(/&prnsim;/g, '⋨');
        txt = txt.replace(/&precnsim;/g, '⋨');

        // "U+022E9", "SUCCEEDS BUT NOT EQUIVALENT TO"
        txt = txt.replace(/&#x0*?22E9;/g, '⋩');
        txt = txt.replace(/&#0*?8937;/g, '⋩');
        txt = txt.replace(/&scnsim;/g, '⋩');
        txt = txt.replace(/&succnsim;/g, '⋩');

        // "U+022EA", "NOT NORMAL SUBGROUP OF"
        txt = txt.replace(/&#x0*?22EA;/g, '⋪');
        txt = txt.replace(/&#0*?8938;/g, '⋪');
        txt = txt.replace(/&nltri;/g, '⋪');
        txt = txt.replace(/&ntriangleleft;/g, '⋪');
        txt = txt.replace(/&NotLeftTriangle;/g, '⋪');

        // "U+022EB", "DOES NOT CONTAIN AS NORMAL SUBGROUP"
        txt = txt.replace(/&#x0*?22EB;/g, '⋫');
        txt = txt.replace(/&#0*?8939;/g, '⋫');
        txt = txt.replace(/&nrtri;/g, '⋫');
        txt = txt.replace(/&ntriangleright;/g, '⋫');
        txt = txt.replace(/&NotRightTriangle;/g, '⋫');

        // "U+022EC", "NOT NORMAL SUBGROUP OF OR EQUAL TO"
        txt = txt.replace(/&#x0*?22EC;/g, '⋬');
        txt = txt.replace(/&#0*?8940;/g, '⋬');
        txt = txt.replace(/&nltrie;/g, '⋬');
        txt = txt.replace(/&ntrianglelefteq;/g, '⋬');
        txt = txt.replace(/&NotLeftTriangleEqual;/g, '⋬');

        // "U+022ED", "DOES NOT CONTAIN AS NORMAL SUBGROUP OR EQUAL"
        txt = txt.replace(/&#x0*?22ED;/g, '⋭');
        txt = txt.replace(/&#0*?8941;/g, '⋭');
        txt = txt.replace(/&nrtrie;/g, '⋭');
        txt = txt.replace(/&ntrianglerighteq;/g, '⋭');
        txt = txt.replace(/&NotRightTriangleEqual;/g, '⋭');

        // "U+022EE", "VERTICAL ELLIPSIS"
        txt = txt.replace(/&#x0*?22EE;/g, '⋮');
        txt = txt.replace(/&#0*?8942;/g, '⋮');
        txt = txt.replace(/&vellip;/g, '⋮');

        // "U+022EF", "MIDLINE HORIZONTAL ELLIPSIS"
        txt = txt.replace(/&#x0*?22EF;/g, '⋯');
        txt = txt.replace(/&#0*?8943;/g, '⋯');
        txt = txt.replace(/&ctdot;/g, '⋯');

        // "U+022F0", "UP RIGHT DIAGONAL ELLIPSIS"
        txt = txt.replace(/&#x0*?22F0;/g, '⋰');
        txt = txt.replace(/&#0*?8944;/g, '⋰');
        txt = txt.replace(/&utdot;/g, '⋰');

        // "U+022F1", "DOWN RIGHT DIAGONAL ELLIPSIS"
        txt = txt.replace(/&#x0*?22F1;/g, '⋱');
        txt = txt.replace(/&#0*?8945;/g, '⋱');
        txt = txt.replace(/&dtdot;/g, '⋱');

        // "U+022F2", "ELEMENT OF WITH LONG HORIZONTAL STROKE"
        txt = txt.replace(/&#x0*?22F2;/g, '⋲');
        txt = txt.replace(/&#0*?8946;/g, '⋲');
        txt = txt.replace(/&disin;/g, '⋲');

        // "U+022F3", "ELEMENT OF WITH VERTICAL BAR AT END OF HORIZONTAL STROKE"
        txt = txt.replace(/&#x0*?22F3;/g, '⋳');
        txt = txt.replace(/&#0*?8947;/g, '⋳');
        txt = txt.replace(/&isinsv;/g, '⋳');

        // "U+022F4", "SMALL ELEMENT OF WITH VERTICAL BAR AT END OF HORIZONTAL STROKE"
        txt = txt.replace(/&#x0*?22F4;/g, '⋴');
        txt = txt.replace(/&#0*?8948;/g, '⋴');
        txt = txt.replace(/&isins;/g, '⋴');

        // "U+022F5", "ELEMENT OF WITH DOT ABOVE"
        txt = txt.replace(/&#x0*?22F5;/g, '⋵');
        txt = txt.replace(/&#0*?8949;/g, '⋵');
        txt = txt.replace(/&isindot;/g, '⋵');

        // "U+022F6", "ELEMENT OF WITH OVERBAR"
        txt = txt.replace(/&#x0*?22F6;/g, '⋶');
        txt = txt.replace(/&#0*?8950;/g, '⋶');
        txt = txt.replace(/&notinvc;/g, '⋶');

        // "U+022F7", "SMALL ELEMENT OF WITH OVERBAR"
        txt = txt.replace(/&#x0*?22F7;/g, '⋷');
        txt = txt.replace(/&#0*?8951;/g, '⋷');
        txt = txt.replace(/&notinvb;/g, '⋷');

        // "U+022F9", "ELEMENT OF WITH TWO HORIZONTAL STROKES"
        txt = txt.replace(/&#x0*?22F9;/g, '⋹');
        txt = txt.replace(/&#0*?8953;/g, '⋹');
        txt = txt.replace(/&isinE;/g, '⋹');

        // "U+022FA", "CONTAINS WITH LONG HORIZONTAL STROKE"
        txt = txt.replace(/&#x0*?22FA;/g, '⋺');
        txt = txt.replace(/&#0*?8954;/g, '⋺');
        txt = txt.replace(/&nisd;/g, '⋺');

        // "U+022FB", "CONTAINS WITH VERTICAL BAR AT END OF HORIZONTAL STROKE"
        txt = txt.replace(/&#x0*?22FB;/g, '⋻');
        txt = txt.replace(/&#0*?8955;/g, '⋻');
        txt = txt.replace(/&xnis;/g, '⋻');

        // "U+022FC", "SMALL CONTAINS WITH VERTICAL BAR AT END OF HORIZONTAL STROKE"
        txt = txt.replace(/&#x0*?22FC;/g, '⋼');
        txt = txt.replace(/&#0*?8956;/g, '⋼');
        txt = txt.replace(/&nis;/g, '⋼');

        // "U+022FD", "CONTAINS WITH OVERBAR"
        txt = txt.replace(/&#x0*?22FD;/g, '⋽');
        txt = txt.replace(/&#0*?8957;/g, '⋽');
        txt = txt.replace(/&notnivc;/g, '⋽');

        // "U+022FE", "SMALL CONTAINS WITH OVERBAR"
        txt = txt.replace(/&#x0*?22FE;/g, '⋾');
        txt = txt.replace(/&#0*?8958;/g, '⋾');
        txt = txt.replace(/&notnivb;/g, '⋾');

        // "U+02305", "PROJECTIVE"
        txt = txt.replace(/&#x0*?2305;/g, '⌅');
        txt = txt.replace(/&#0*?8965;/g, '⌅');
        txt = txt.replace(/&barwed;/g, '⌅');
        txt = txt.replace(/&barwedge;/g, '⌅');

        // "U+02306", "PERSPECTIVE"
        txt = txt.replace(/&#x0*?2306;/g, '⌆');
        txt = txt.replace(/&#0*?8966;/g, '⌆');
        txt = txt.replace(/&Barwed;/g, '⌆');
        txt = txt.replace(/&doublebarwedge;/g, '⌆');

        // "U+02308", "LEFT CEILING"
        txt = txt.replace(/&#x0*?2308;/g, '⌈');
        txt = txt.replace(/&#0*?8968;/g, '⌈');
        txt = txt.replace(/&lceil;/g, '⌈');
        txt = txt.replace(/&LeftCeiling;/g, '⌈');

        // "U+02309", "RIGHT CEILING"
        txt = txt.replace(/&#x0*?2309;/g, '⌉');
        txt = txt.replace(/&#0*?8969;/g, '⌉');
        txt = txt.replace(/&rceil;/g, '⌉');
        txt = txt.replace(/&RightCeiling;/g, '⌉');

        // "U+0230A", "LEFT FLOOR"
        txt = txt.replace(/&#x0*?230A;/g, '⌊');
        txt = txt.replace(/&#0*?8970;/g, '⌊');
        txt = txt.replace(/&lfloor;/g, '⌊');
        txt = txt.replace(/&LeftFloor;/g, '⌊');

        // "U+0230B", "RIGHT FLOOR"
        txt = txt.replace(/&#x0*?230B;/g, '⌋');
        txt = txt.replace(/&#0*?8971;/g, '⌋');
        txt = txt.replace(/&rfloor;/g, '⌋');
        txt = txt.replace(/&RightFloor;/g, '⌋');

        // "U+0230C", "BOTTOM RIGHT CROP"
        txt = txt.replace(/&#x0*?230C;/g, '⌌');
        txt = txt.replace(/&#0*?8972;/g, '⌌');
        txt = txt.replace(/&drcrop;/g, '⌌');

        // "U+0230D", "BOTTOM LEFT CROP"
        txt = txt.replace(/&#x0*?230D;/g, '⌍');
        txt = txt.replace(/&#0*?8973;/g, '⌍');
        txt = txt.replace(/&dlcrop;/g, '⌍');

        // "U+0230E", "TOP RIGHT CROP"
        txt = txt.replace(/&#x0*?230E;/g, '⌎');
        txt = txt.replace(/&#0*?8974;/g, '⌎');
        txt = txt.replace(/&urcrop;/g, '⌎');

        // "U+0230F", "TOP LEFT CROP"
        txt = txt.replace(/&#x0*?230F;/g, '⌏');
        txt = txt.replace(/&#0*?8975;/g, '⌏');
        txt = txt.replace(/&ulcrop;/g, '⌏');

        // "U+02310", "REVERSED NOT SIGN"
        txt = txt.replace(/&#x0*?2310;/g, '⌐');
        txt = txt.replace(/&#0*?8976;/g, '⌐');
        txt = txt.replace(/&bnot;/g, '⌐');

        // "U+02312", "ARC"
        txt = txt.replace(/&#x0*?2312;/g, '⌒');
        txt = txt.replace(/&#0*?8978;/g, '⌒');
        txt = txt.replace(/&profline;/g, '⌒');

        // "U+02313", "SEGMENT"
        txt = txt.replace(/&#x0*?2313;/g, '⌓');
        txt = txt.replace(/&#0*?8979;/g, '⌓');
        txt = txt.replace(/&profsurf;/g, '⌓');

        // "U+02315", "TELEPHONE RECORDER"
        txt = txt.replace(/&#x0*?2315;/g, '⌕');
        txt = txt.replace(/&#0*?8981;/g, '⌕');
        txt = txt.replace(/&telrec;/g, '⌕');

        // "U+02316", "POSITION INDICATOR"
        txt = txt.replace(/&#x0*?2316;/g, '⌖');
        txt = txt.replace(/&#0*?8982;/g, '⌖');
        txt = txt.replace(/&target;/g, '⌖');

        // "U+0231C", "TOP LEFT CORNER"
        txt = txt.replace(/&#x0*?231C;/g, '⌜');
        txt = txt.replace(/&#0*?8988;/g, '⌜');
        txt = txt.replace(/&ulcorn;/g, '⌜');
        txt = txt.replace(/&ulcorner;/g, '⌜');

        // "U+0231D", "TOP RIGHT CORNER"
        txt = txt.replace(/&#x0*?231D;/g, '⌝');
        txt = txt.replace(/&#0*?8989;/g, '⌝');
        txt = txt.replace(/&urcorn;/g, '⌝');
        txt = txt.replace(/&urcorner;/g, '⌝');

        // "U+0231E", "BOTTOM LEFT CORNER"
        txt = txt.replace(/&#x0*?231E;/g, '⌞');
        txt = txt.replace(/&#0*?8990;/g, '⌞');
        txt = txt.replace(/&dlcorn;/g, '⌞');
        txt = txt.replace(/&llcorner;/g, '⌞');

        // "U+0231F", "BOTTOM RIGHT CORNER"
        txt = txt.replace(/&#x0*?231F;/g, '⌟');
        txt = txt.replace(/&#0*?8991;/g, '⌟');
        txt = txt.replace(/&drcorn;/g, '⌟');
        txt = txt.replace(/&lrcorner;/g, '⌟');

        // "U+02322", "FROWN"
        txt = txt.replace(/&#x0*?2322;/g, '⌢');
        txt = txt.replace(/&#0*?8994;/g, '⌢');
        txt = txt.replace(/&frown;/g, '⌢');
        txt = txt.replace(/&sfrown;/g, '⌢');

        // "U+02323", "SMILE"
        txt = txt.replace(/&#x0*?2323;/g, '⌣');
        txt = txt.replace(/&#0*?8995;/g, '⌣');
        txt = txt.replace(/&smile;/g, '⌣');
        txt = txt.replace(/&ssmile;/g, '⌣');

        // "U+0232D", "CYLINDRICITY"
        txt = txt.replace(/&#x0*?232D;/g, '⌭');
        txt = txt.replace(/&#0*?9005;/g, '⌭');
        txt = txt.replace(/&cylcty;/g, '⌭');

        // "U+0232E", "ALL AROUND-PROFILE"
        txt = txt.replace(/&#x0*?232E;/g, '⌮');
        txt = txt.replace(/&#0*?9006;/g, '⌮');
        txt = txt.replace(/&profalar;/g, '⌮');

        // "U+02336", "APL FUNCTIONAL SYMBOL I-BEAM"
        txt = txt.replace(/&#x0*?2336;/g, '⌶');
        txt = txt.replace(/&#0*?9014;/g, '⌶');
        txt = txt.replace(/&topbot;/g, '⌶');

        // "U+0233D", "APL FUNCTIONAL SYMBOL CIRCLE STILE"
        txt = txt.replace(/&#x0*?233D;/g, '⌽');
        txt = txt.replace(/&#0*?9021;/g, '⌽');
        txt = txt.replace(/&ovbar;/g, '⌽');

        // "U+0233F", "APL FUNCTIONAL SYMBOL SLASH BAR"
        txt = txt.replace(/&#x0*?233F;/g, '⌿');
        txt = txt.replace(/&#0*?9023;/g, '⌿');
        txt = txt.replace(/&solbar;/g, '⌿');

        // "U+0237C", "RIGHT ANGLE WITH DOWNWARDS ZIGZAG ARROW"
        txt = txt.replace(/&#x0*?237C;/g, '⍼');
        txt = txt.replace(/&#0*?9084;/g, '⍼');
        txt = txt.replace(/&angzarr;/g, '⍼');

        // "U+023B0", "UPPER LEFT OR LOWER RIGHT CURLY BRACKET SECTION"
        txt = txt.replace(/&#x0*?23B0;/g, '⎰');
        txt = txt.replace(/&#0*?9136;/g, '⎰');
        txt = txt.replace(/&lmoust;/g, '⎰');
        txt = txt.replace(/&lmoustache;/g, '⎰');

        // "U+023B1", "UPPER RIGHT OR LOWER LEFT CURLY BRACKET SECTION"
        txt = txt.replace(/&#x0*?23B1;/g, '⎱');
        txt = txt.replace(/&#0*?9137;/g, '⎱');
        txt = txt.replace(/&rmoust;/g, '⎱');
        txt = txt.replace(/&rmoustache;/g, '⎱');

        // "U+023B4", "TOP SQUARE BRACKET"
        txt = txt.replace(/&#x0*?23B4;/g, '⎴');
        txt = txt.replace(/&#0*?9140;/g, '⎴');
        txt = txt.replace(/&tbrk;/g, '⎴');
        txt = txt.replace(/&OverBracket;/g, '⎴');

        // "U+023B5", "BOTTOM SQUARE BRACKET"
        txt = txt.replace(/&#x0*?23B5;/g, '⎵');
        txt = txt.replace(/&#0*?9141;/g, '⎵');
        txt = txt.replace(/&bbrk;/g, '⎵');
        txt = txt.replace(/&UnderBracket;/g, '⎵');

        // "U+023B6", "BOTTOM SQUARE BRACKET OVER TOP SQUARE BRACKET"
        txt = txt.replace(/&#x0*?23B6;/g, '⎶');
        txt = txt.replace(/&#0*?9142;/g, '⎶');
        txt = txt.replace(/&bbrktbrk;/g, '⎶');

        // "U+023DC", "TOP PARENTHESIS"
        txt = txt.replace(/&#x0*?23DC;/g, '⏜');
        txt = txt.replace(/&#0*?9180;/g, '⏜');
        txt = txt.replace(/&OverParenthesis;/g, '⏜');

        // "U+023DD", "BOTTOM PARENTHESIS"
        txt = txt.replace(/&#x0*?23DD;/g, '⏝');
        txt = txt.replace(/&#0*?9181;/g, '⏝');
        txt = txt.replace(/&UnderParenthesis;/g, '⏝');

        // "U+023DE", "TOP CURLY BRACKET"
        txt = txt.replace(/&#x0*?23DE;/g, '⏞');
        txt = txt.replace(/&#0*?9182;/g, '⏞');
        txt = txt.replace(/&OverBrace;/g, '⏞');

        // "U+023DF", "BOTTOM CURLY BRACKET"
        txt = txt.replace(/&#x0*?23DF;/g, '⏟');
        txt = txt.replace(/&#0*?9183;/g, '⏟');
        txt = txt.replace(/&UnderBrace;/g, '⏟');

        // "U+023E2", "WHITE TRAPEZIUM"
        txt = txt.replace(/&#x0*?23E2;/g, '⏢');
        txt = txt.replace(/&#0*?9186;/g, '⏢');
        txt = txt.replace(/&trpezium;/g, '⏢');

        // "U+023E7", "ELECTRICAL INTERSECTION"
        txt = txt.replace(/&#x0*?23E7;/g, '⏧');
        txt = txt.replace(/&#0*?9191;/g, '⏧');
        txt = txt.replace(/&elinters;/g, '⏧');

        // "U+02423", "OPEN BOX"
        txt = txt.replace(/&#x0*?2423;/g, '␣');
        txt = txt.replace(/&#0*?9251;/g, '␣');
        txt = txt.replace(/&blank;/g, '␣');

        // "U+024C8", "CIRCLED LATIN CAPITAL LETTER S"
        txt = txt.replace(/&#x0*?24C8;/g, 'Ⓢ');
        txt = txt.replace(/&#0*?9416;/g, 'Ⓢ');
        txt = txt.replace(/&oS;/g, 'Ⓢ');
        txt = txt.replace(/&circledS;/g, 'Ⓢ');

        // "U+02500", "BOX DRAWINGS LIGHT HORIZONTAL"
        txt = txt.replace(/&#x0*?2500;/g, '─');
        txt = txt.replace(/&#0*?9472;/g, '─');
        txt = txt.replace(/&boxh;/g, '─');
        txt = txt.replace(/&HorizontalLine;/g, '─');

        // "U+02502", "BOX DRAWINGS LIGHT VERTICAL"
        txt = txt.replace(/&#x0*?2502;/g, '│');
        txt = txt.replace(/&#0*?9474;/g, '│');
        txt = txt.replace(/&boxv;/g, '│');

        // "U+0250C", "BOX DRAWINGS LIGHT DOWN AND RIGHT"
        txt = txt.replace(/&#x0*?250C;/g, '┌');
        txt = txt.replace(/&#0*?9484;/g, '┌');
        txt = txt.replace(/&boxdr;/g, '┌');

        // "U+02510", "BOX DRAWINGS LIGHT DOWN AND LEFT"
        txt = txt.replace(/&#x0*?2510;/g, '┐');
        txt = txt.replace(/&#0*?9488;/g, '┐');
        txt = txt.replace(/&boxdl;/g, '┐');

        // "U+02514", "BOX DRAWINGS LIGHT UP AND RIGHT"
        txt = txt.replace(/&#x0*?2514;/g, '└');
        txt = txt.replace(/&#0*?9492;/g, '└');
        txt = txt.replace(/&boxur;/g, '└');

        // "U+02518", "BOX DRAWINGS LIGHT UP AND LEFT"
        txt = txt.replace(/&#x0*?2518;/g, '┘');
        txt = txt.replace(/&#0*?9496;/g, '┘');
        txt = txt.replace(/&boxul;/g, '┘');

        // "U+0251C", "BOX DRAWINGS LIGHT VERTICAL AND RIGHT"
        txt = txt.replace(/&#x0*?251C;/g, '├');
        txt = txt.replace(/&#0*?9500;/g, '├');
        txt = txt.replace(/&boxvr;/g, '├');

        // "U+02524", "BOX DRAWINGS LIGHT VERTICAL AND LEFT"
        txt = txt.replace(/&#x0*?2524;/g, '┤');
        txt = txt.replace(/&#0*?9508;/g, '┤');
        txt = txt.replace(/&boxvl;/g, '┤');

        // "U+0252C", "BOX DRAWINGS LIGHT DOWN AND HORIZONTAL"
        txt = txt.replace(/&#x0*?252C;/g, '┬');
        txt = txt.replace(/&#0*?9516;/g, '┬');
        txt = txt.replace(/&boxhd;/g, '┬');

        // "U+02534", "BOX DRAWINGS LIGHT UP AND HORIZONTAL"
        txt = txt.replace(/&#x0*?2534;/g, '┴');
        txt = txt.replace(/&#0*?9524;/g, '┴');
        txt = txt.replace(/&boxhu;/g, '┴');

        // "U+0253C", "BOX DRAWINGS LIGHT VERTICAL AND HORIZONTAL"
        txt = txt.replace(/&#x0*?253C;/g, '┼');
        txt = txt.replace(/&#0*?9532;/g, '┼');
        txt = txt.replace(/&boxvh;/g, '┼');

        // "U+02550", "BOX DRAWINGS DOUBLE HORIZONTAL"
        txt = txt.replace(/&#x0*?2550;/g, '═');
        txt = txt.replace(/&#0*?9552;/g, '═');
        txt = txt.replace(/&boxH;/g, '═');

        // "U+02551", "BOX DRAWINGS DOUBLE VERTICAL"
        txt = txt.replace(/&#x0*?2551;/g, '║');
        txt = txt.replace(/&#0*?9553;/g, '║');
        txt = txt.replace(/&boxV;/g, '║');

        // "U+02552", "BOX DRAWINGS DOWN SINGLE AND RIGHT DOUBLE"
        txt = txt.replace(/&#x0*?2552;/g, '╒');
        txt = txt.replace(/&#0*?9554;/g, '╒');
        txt = txt.replace(/&boxdR;/g, '╒');

        // "U+02553", "BOX DRAWINGS DOWN DOUBLE AND RIGHT SINGLE"
        txt = txt.replace(/&#x0*?2553;/g, '╓');
        txt = txt.replace(/&#0*?9555;/g, '╓');
        txt = txt.replace(/&boxDr;/g, '╓');

        // "U+02554", "BOX DRAWINGS DOUBLE DOWN AND RIGHT"
        txt = txt.replace(/&#x0*?2554;/g, '╔');
        txt = txt.replace(/&#0*?9556;/g, '╔');
        txt = txt.replace(/&boxDR;/g, '╔');

        // "U+02555", "BOX DRAWINGS DOWN SINGLE AND LEFT DOUBLE"
        txt = txt.replace(/&#x0*?2555;/g, '╕');
        txt = txt.replace(/&#0*?9557;/g, '╕');
        txt = txt.replace(/&boxdL;/g, '╕');

        // "U+02556", "BOX DRAWINGS DOWN DOUBLE AND LEFT SINGLE"
        txt = txt.replace(/&#x0*?2556;/g, '╖');
        txt = txt.replace(/&#0*?9558;/g, '╖');
        txt = txt.replace(/&boxDl;/g, '╖');

        // "U+02557", "BOX DRAWINGS DOUBLE DOWN AND LEFT"
        txt = txt.replace(/&#x0*?2557;/g, '╗');
        txt = txt.replace(/&#0*?9559;/g, '╗');
        txt = txt.replace(/&boxDL;/g, '╗');

        // "U+02558", "BOX DRAWINGS UP SINGLE AND RIGHT DOUBLE"
        txt = txt.replace(/&#x0*?2558;/g, '╘');
        txt = txt.replace(/&#0*?9560;/g, '╘');
        txt = txt.replace(/&boxuR;/g, '╘');

        // "U+02559", "BOX DRAWINGS UP DOUBLE AND RIGHT SINGLE"
        txt = txt.replace(/&#x0*?2559;/g, '╙');
        txt = txt.replace(/&#0*?9561;/g, '╙');
        txt = txt.replace(/&boxUr;/g, '╙');

        // "U+0255A", "BOX DRAWINGS DOUBLE UP AND RIGHT"
        txt = txt.replace(/&#x0*?255A;/g, '╚');
        txt = txt.replace(/&#0*?9562;/g, '╚');
        txt = txt.replace(/&boxUR;/g, '╚');

        // "U+0255B", "BOX DRAWINGS UP SINGLE AND LEFT DOUBLE"
        txt = txt.replace(/&#x0*?255B;/g, '╛');
        txt = txt.replace(/&#0*?9563;/g, '╛');
        txt = txt.replace(/&boxuL;/g, '╛');

        // "U+0255C", "BOX DRAWINGS UP DOUBLE AND LEFT SINGLE"
        txt = txt.replace(/&#x0*?255C;/g, '╜');
        txt = txt.replace(/&#0*?9564;/g, '╜');
        txt = txt.replace(/&boxUl;/g, '╜');

        // "U+0255D", "BOX DRAWINGS DOUBLE UP AND LEFT"
        txt = txt.replace(/&#x0*?255D;/g, '╝');
        txt = txt.replace(/&#0*?9565;/g, '╝');
        txt = txt.replace(/&boxUL;/g, '╝');

        // "U+0255E", "BOX DRAWINGS VERTICAL SINGLE AND RIGHT DOUBLE"
        txt = txt.replace(/&#x0*?255E;/g, '╞');
        txt = txt.replace(/&#0*?9566;/g, '╞');
        txt = txt.replace(/&boxvR;/g, '╞');

        // "U+0255F", "BOX DRAWINGS VERTICAL DOUBLE AND RIGHT SINGLE"
        txt = txt.replace(/&#x0*?255F;/g, '╟');
        txt = txt.replace(/&#0*?9567;/g, '╟');
        txt = txt.replace(/&boxVr;/g, '╟');

        // "U+02560", "BOX DRAWINGS DOUBLE VERTICAL AND RIGHT"
        txt = txt.replace(/&#x0*?2560;/g, '╠');
        txt = txt.replace(/&#0*?9568;/g, '╠');
        txt = txt.replace(/&boxVR;/g, '╠');

        // "U+02561", "BOX DRAWINGS VERTICAL SINGLE AND LEFT DOUBLE"
        txt = txt.replace(/&#x0*?2561;/g, '╡');
        txt = txt.replace(/&#0*?9569;/g, '╡');
        txt = txt.replace(/&boxvL;/g, '╡');

        // "U+02562", "BOX DRAWINGS VERTICAL DOUBLE AND LEFT SINGLE"
        txt = txt.replace(/&#x0*?2562;/g, '╢');
        txt = txt.replace(/&#0*?9570;/g, '╢');
        txt = txt.replace(/&boxVl;/g, '╢');

        // "U+02563", "BOX DRAWINGS DOUBLE VERTICAL AND LEFT"
        txt = txt.replace(/&#x0*?2563;/g, '╣');
        txt = txt.replace(/&#0*?9571;/g, '╣');
        txt = txt.replace(/&boxVL;/g, '╣');

        // "U+02564", "BOX DRAWINGS DOWN SINGLE AND HORIZONTAL DOUBLE"
        txt = txt.replace(/&#x0*?2564;/g, '╤');
        txt = txt.replace(/&#0*?9572;/g, '╤');
        txt = txt.replace(/&boxHd;/g, '╤');

        // "U+02565", "BOX DRAWINGS DOWN DOUBLE AND HORIZONTAL SINGLE"
        txt = txt.replace(/&#x0*?2565;/g, '╥');
        txt = txt.replace(/&#0*?9573;/g, '╥');
        txt = txt.replace(/&boxhD;/g, '╥');

        // "U+02566", "BOX DRAWINGS DOUBLE DOWN AND HORIZONTAL"
        txt = txt.replace(/&#x0*?2566;/g, '╦');
        txt = txt.replace(/&#0*?9574;/g, '╦');
        txt = txt.replace(/&boxHD;/g, '╦');

        // "U+02567", "BOX DRAWINGS UP SINGLE AND HORIZONTAL DOUBLE"
        txt = txt.replace(/&#x0*?2567;/g, '╧');
        txt = txt.replace(/&#0*?9575;/g, '╧');
        txt = txt.replace(/&boxHu;/g, '╧');

        // "U+02568", "BOX DRAWINGS UP DOUBLE AND HORIZONTAL SINGLE"
        txt = txt.replace(/&#x0*?2568;/g, '╨');
        txt = txt.replace(/&#0*?9576;/g, '╨');
        txt = txt.replace(/&boxhU;/g, '╨');

        // "U+02569", "BOX DRAWINGS DOUBLE UP AND HORIZONTAL"
        txt = txt.replace(/&#x0*?2569;/g, '╩');
        txt = txt.replace(/&#0*?9577;/g, '╩');
        txt = txt.replace(/&boxHU;/g, '╩');

        // "U+0256A", "BOX DRAWINGS VERTICAL SINGLE AND HORIZONTAL DOUBLE"
        txt = txt.replace(/&#x0*?256A;/g, '╪');
        txt = txt.replace(/&#0*?9578;/g, '╪');
        txt = txt.replace(/&boxvH;/g, '╪');

        // "U+0256B", "BOX DRAWINGS VERTICAL DOUBLE AND HORIZONTAL SINGLE"
        txt = txt.replace(/&#x0*?256B;/g, '╫');
        txt = txt.replace(/&#0*?9579;/g, '╫');
        txt = txt.replace(/&boxVh;/g, '╫');

        // "U+0256C", "BOX DRAWINGS DOUBLE VERTICAL AND HORIZONTAL"
        txt = txt.replace(/&#x0*?256C;/g, '╬');
        txt = txt.replace(/&#0*?9580;/g, '╬');
        txt = txt.replace(/&boxVH;/g, '╬');

        // "U+02580", "UPPER HALF BLOCK"
        txt = txt.replace(/&#x0*?2580;/g, '▀');
        txt = txt.replace(/&#0*?9600;/g, '▀');
        txt = txt.replace(/&uhblk;/g, '▀');

        // "U+02584", "LOWER HALF BLOCK"
        txt = txt.replace(/&#x0*?2584;/g, '▄');
        txt = txt.replace(/&#0*?9604;/g, '▄');
        txt = txt.replace(/&lhblk;/g, '▄');

        // "U+02588", "FULL BLOCK"
        txt = txt.replace(/&#x0*?2588;/g, '█');
        txt = txt.replace(/&#0*?9608;/g, '█');
        txt = txt.replace(/&block;/g, '█');

        // "U+02591", "LIGHT SHADE"
        txt = txt.replace(/&#x0*?2591;/g, '░');
        txt = txt.replace(/&#0*?9617;/g, '░');
        txt = txt.replace(/&blk14;/g, '░');

        // "U+02592", "MEDIUM SHADE"
        txt = txt.replace(/&#x0*?2592;/g, '▒');
        txt = txt.replace(/&#0*?9618;/g, '▒');
        txt = txt.replace(/&blk12;/g, '▒');

        // "U+02593", "DARK SHADE"
        txt = txt.replace(/&#x0*?2593;/g, '▓');
        txt = txt.replace(/&#0*?9619;/g, '▓');
        txt = txt.replace(/&blk34;/g, '▓');

        // "U+025A1", "WHITE SQUARE"
        txt = txt.replace(/&#x0*?25A1;/g, '□');
        txt = txt.replace(/&#0*?9633;/g, '□');
        txt = txt.replace(/&squ;/g, '□');
        txt = txt.replace(/&square;/g, '□');
        txt = txt.replace(/&Square;/g, '□');

        // "U+025AA", "BLACK SMALL SQUARE"
        txt = txt.replace(/&#x0*?25AA;/g, '▪');
        txt = txt.replace(/&#0*?9642;/g, '▪');
        txt = txt.replace(/&squf;/g, '▪');
        txt = txt.replace(/&squarf;/g, '▪');
        txt = txt.replace(/&blacksquare;/g, '▪');
        txt = txt.replace(/&FilledVerySmallSquare;/g, '▪');

        // "U+025AB", "WHITE SMALL SQUARE"
        txt = txt.replace(/&#x0*?25AB;/g, '▫');
        txt = txt.replace(/&#0*?9643;/g, '▫');
        txt = txt.replace(/&EmptyVerySmallSquare;/g, '▫');

        // "U+025AD", "WHITE RECTANGLE"
        txt = txt.replace(/&#x0*?25AD;/g, '▭');
        txt = txt.replace(/&#0*?9645;/g, '▭');
        txt = txt.replace(/&rect;/g, '▭');

        // "U+025AE", "BLACK VERTICAL RECTANGLE"
        txt = txt.replace(/&#x0*?25AE;/g, '▮');
        txt = txt.replace(/&#0*?9646;/g, '▮');
        txt = txt.replace(/&marker;/g, '▮');

        // "U+025B1", "WHITE PARALLELOGRAM"
        txt = txt.replace(/&#x0*?25B1;/g, '▱');
        txt = txt.replace(/&#0*?9649;/g, '▱');
        txt = txt.replace(/&fltns;/g, '▱');

        // "U+025B3", "WHITE UP-POINTING TRIANGLE"
        txt = txt.replace(/&#x0*?25B3;/g, '△');
        txt = txt.replace(/&#0*?9651;/g, '△');
        txt = txt.replace(/&xutri;/g, '△');
        txt = txt.replace(/&bigtriangleup;/g, '△');

        // "U+025B4", "BLACK UP-POINTING SMALL TRIANGLE"
        txt = txt.replace(/&#x0*?25B4;/g, '▴');
        txt = txt.replace(/&#0*?9652;/g, '▴');
        txt = txt.replace(/&utrif;/g, '▴');
        txt = txt.replace(/&blacktriangle;/g, '▴');

        // "U+025B5", "WHITE UP-POINTING SMALL TRIANGLE"
        txt = txt.replace(/&#x0*?25B5;/g, '▵');
        txt = txt.replace(/&#0*?9653;/g, '▵');
        txt = txt.replace(/&utri;/g, '▵');
        txt = txt.replace(/&triangle;/g, '▵');

        // "U+025B8", "BLACK RIGHT-POINTING SMALL TRIANGLE"
        txt = txt.replace(/&#x0*?25B8;/g, '▸');
        txt = txt.replace(/&#0*?9656;/g, '▸');
        txt = txt.replace(/&rtrif;/g, '▸');
        txt = txt.replace(/&blacktriangleright;/g, '▸');

        // "U+025B9", "WHITE RIGHT-POINTING SMALL TRIANGLE"
        txt = txt.replace(/&#x0*?25B9;/g, '▹');
        txt = txt.replace(/&#0*?9657;/g, '▹');
        txt = txt.replace(/&rtri;/g, '▹');
        txt = txt.replace(/&triangleright;/g, '▹');

        // "U+025BD", "WHITE DOWN-POINTING TRIANGLE"
        txt = txt.replace(/&#x0*?25BD;/g, '▽');
        txt = txt.replace(/&#0*?9661;/g, '▽');
        txt = txt.replace(/&xdtri;/g, '▽');
        txt = txt.replace(/&bigtriangledown;/g, '▽');

        // "U+025BE", "BLACK DOWN-POINTING SMALL TRIANGLE"
        txt = txt.replace(/&#x0*?25BE;/g, '▾');
        txt = txt.replace(/&#0*?9662;/g, '▾');
        txt = txt.replace(/&dtrif;/g, '▾');
        txt = txt.replace(/&blacktriangledown;/g, '▾');

        // "U+025BF", "WHITE DOWN-POINTING SMALL TRIANGLE"
        txt = txt.replace(/&#x0*?25BF;/g, '▿');
        txt = txt.replace(/&#0*?9663;/g, '▿');
        txt = txt.replace(/&dtri;/g, '▿');
        txt = txt.replace(/&triangledown;/g, '▿');

        // "U+025C2", "BLACK LEFT-POINTING SMALL TRIANGLE"
        txt = txt.replace(/&#x0*?25C2;/g, '◂');
        txt = txt.replace(/&#0*?9666;/g, '◂');
        txt = txt.replace(/&ltrif;/g, '◂');
        txt = txt.replace(/&blacktriangleleft;/g, '◂');

        // "U+025C3", "WHITE LEFT-POINTING SMALL TRIANGLE"
        txt = txt.replace(/&#x0*?25C3;/g, '◃');
        txt = txt.replace(/&#0*?9667;/g, '◃');
        txt = txt.replace(/&ltri;/g, '◃');
        txt = txt.replace(/&triangleleft;/g, '◃');

        // "U+025CA", "LOZENGE"
        txt = txt.replace(/&#x0*?25CA;/g, '◊');
        txt = txt.replace(/&#0*?9674;/g, '◊');
        txt = txt.replace(/&loz;/g, '◊');
        txt = txt.replace(/&lozenge;/g, '◊');

        // "U+025CB", "WHITE CIRCLE"
        txt = txt.replace(/&#x0*?25CB;/g, '○');
        txt = txt.replace(/&#0*?9675;/g, '○');
        txt = txt.replace(/&cir;/g, '○');

        // "U+025EC", "WHITE UP-POINTING TRIANGLE WITH DOT"
        txt = txt.replace(/&#x0*?25EC;/g, '◬');
        txt = txt.replace(/&#0*?9708;/g, '◬');
        txt = txt.replace(/&tridot;/g, '◬');

        // "U+025EF", "LARGE CIRCLE"
        txt = txt.replace(/&#x0*?25EF;/g, '◯');
        txt = txt.replace(/&#0*?9711;/g, '◯');
        txt = txt.replace(/&xcirc;/g, '◯');
        txt = txt.replace(/&bigcirc;/g, '◯');

        // "U+025F8", "UPPER LEFT TRIANGLE"
        txt = txt.replace(/&#x0*?25F8;/g, '◸');
        txt = txt.replace(/&#0*?9720;/g, '◸');
        txt = txt.replace(/&ultri;/g, '◸');

        // "U+025F9", "UPPER RIGHT TRIANGLE"
        txt = txt.replace(/&#x0*?25F9;/g, '◹');
        txt = txt.replace(/&#0*?9721;/g, '◹');
        txt = txt.replace(/&urtri;/g, '◹');

        // "U+025FA", "LOWER LEFT TRIANGLE"
        txt = txt.replace(/&#x0*?25FA;/g, '◺');
        txt = txt.replace(/&#0*?9722;/g, '◺');
        txt = txt.replace(/&lltri;/g, '◺');

        // "U+025FB", "WHITE MEDIUM SQUARE"
        txt = txt.replace(/&#x0*?25FB;/g, '◻');
        txt = txt.replace(/&#0*?9723;/g, '◻');
        txt = txt.replace(/&EmptySmallSquare;/g, '◻');

        // "U+025FC", "BLACK MEDIUM SQUARE"
        txt = txt.replace(/&#x0*?25FC;/g, '◼');
        txt = txt.replace(/&#0*?9724;/g, '◼');
        txt = txt.replace(/&FilledSmallSquare;/g, '◼');

        // "U+02605", "BLACK STAR"
        txt = txt.replace(/&#x0*?2605;/g, '★');
        txt = txt.replace(/&#0*?9733;/g, '★');
        txt = txt.replace(/&starf;/g, '★');
        txt = txt.replace(/&bigstar;/g, '★');

        // "U+02606", "WHITE STAR"
        txt = txt.replace(/&#x0*?2606;/g, '☆');
        txt = txt.replace(/&#0*?9734;/g, '☆');
        txt = txt.replace(/&star;/g, '☆');

        // "U+0260E", "BLACK TELEPHONE"
        txt = txt.replace(/&#x0*?260E;/g, '☎');
        txt = txt.replace(/&#0*?9742;/g, '☎');
        txt = txt.replace(/&phone;/g, '☎');

        // "U+02640", "FEMALE SIGN"
        txt = txt.replace(/&#x0*?2640;/g, '♀');
        txt = txt.replace(/&#0*?9792;/g, '♀');
        txt = txt.replace(/&female;/g, '♀');

        // "U+02642", "MALE SIGN"
        txt = txt.replace(/&#x0*?2642;/g, '♂');
        txt = txt.replace(/&#0*?9794;/g, '♂');
        txt = txt.replace(/&male;/g, '♂');

        // "U+02660", "BLACK SPADE SUIT"
        txt = txt.replace(/&#x0*?2660;/g, '♠');
        txt = txt.replace(/&#0*?9824;/g, '♠');
        txt = txt.replace(/&spades;/g, '♠');
        txt = txt.replace(/&spadesuit;/g, '♠');

        // "U+02663", "BLACK CLUB SUIT"
        txt = txt.replace(/&#x0*?2663;/g, '♣');
        txt = txt.replace(/&#0*?9827;/g, '♣');
        txt = txt.replace(/&clubs;/g, '♣');
        txt = txt.replace(/&clubsuit;/g, '♣');

        // "U+02665", "BLACK HEART SUIT"
        txt = txt.replace(/&#x0*?2665;/g, '♥');
        txt = txt.replace(/&#0*?9829;/g, '♥');
        txt = txt.replace(/&hearts;/g, '♥');
        txt = txt.replace(/&heartsuit;/g, '♥');

        // "U+02666", "BLACK DIAMOND SUIT"
        txt = txt.replace(/&#x0*?2666;/g, '♦');
        txt = txt.replace(/&#0*?9830;/g, '♦');
        txt = txt.replace(/&diams;/g, '♦');
        txt = txt.replace(/&diamondsuit;/g, '♦');

        // "U+0266A", "EIGHTH NOTE"
        txt = txt.replace(/&#x0*?266A;/g, '♪');
        txt = txt.replace(/&#0*?9834;/g, '♪');
        txt = txt.replace(/&sung;/g, '♪');

        // "U+0266D", "MUSIC FLAT SIGN"
        txt = txt.replace(/&#x0*?266D;/g, '♭');
        txt = txt.replace(/&#0*?9837;/g, '♭');
        txt = txt.replace(/&flat;/g, '♭');

        // "U+0266E", "MUSIC NATURAL SIGN"
        txt = txt.replace(/&#x0*?266E;/g, '♮');
        txt = txt.replace(/&#0*?9838;/g, '♮');
        txt = txt.replace(/&natur;/g, '♮');
        txt = txt.replace(/&natural;/g, '♮');

        // "U+0266F", "MUSIC SHARP SIGN"
        txt = txt.replace(/&#x0*?266F;/g, '♯');
        txt = txt.replace(/&#0*?9839;/g, '♯');
        txt = txt.replace(/&sharp;/g, '♯');

        // "U+02713", "CHECK MARK"
        txt = txt.replace(/&#x0*?2713;/g, '✓');
        txt = txt.replace(/&#0*?10003;/g, '✓');
        txt = txt.replace(/&check;/g, '✓');
        txt = txt.replace(/&checkmark;/g, '✓');

        // "U+02717", "BALLOT X"
        txt = txt.replace(/&#x0*?2717;/g, '✗');
        txt = txt.replace(/&#0*?10007;/g, '✗');
        txt = txt.replace(/&cross;/g, '✗');

        // "U+02720", "MALTESE CROSS"
        txt = txt.replace(/&#x0*?2720;/g, '✠');
        txt = txt.replace(/&#0*?10016;/g, '✠');
        txt = txt.replace(/&malt;/g, '✠');
        txt = txt.replace(/&maltese;/g, '✠');

        // "U+02736", "SIX POINTED BLACK STAR"
        txt = txt.replace(/&#x0*?2736;/g, '✶');
        txt = txt.replace(/&#0*?10038;/g, '✶');
        txt = txt.replace(/&sext;/g, '✶');

        // "U+02758", "LIGHT VERTICAL BAR"
        txt = txt.replace(/&#x0*?2758;/g, '❘');
        txt = txt.replace(/&#0*?10072;/g, '❘');
        txt = txt.replace(/&VerticalSeparator;/g, '❘');

        // "U+02772", "LIGHT LEFT TORTOISE SHELL BRACKET ORNAMENT"
        txt = txt.replace(/&#x0*?2772;/g, '❲');
        txt = txt.replace(/&#0*?10098;/g, '❲');
        txt = txt.replace(/&lbbrk;/g, '❲');

        // "U+02773", "LIGHT RIGHT TORTOISE SHELL BRACKET ORNAMENT"
        txt = txt.replace(/&#x0*?2773;/g, '❳');
        txt = txt.replace(/&#0*?10099;/g, '❳');
        txt = txt.replace(/&rbbrk;/g, '❳');

        // "U+027E6", "MATHEMATICAL LEFT WHITE SQUARE BRACKET"
        txt = txt.replace(/&#x0*?27E6;/g, '⟦');
        txt = txt.replace(/&#0*?10214;/g, '⟦');
        txt = txt.replace(/&lobrk;/g, '⟦');
        txt = txt.replace(/&LeftDoubleBracket;/g, '⟦');

        // "U+027E7", "MATHEMATICAL RIGHT WHITE SQUARE BRACKET"
        txt = txt.replace(/&#x0*?27E7;/g, '⟧');
        txt = txt.replace(/&#0*?10215;/g, '⟧');
        txt = txt.replace(/&robrk;/g, '⟧');
        txt = txt.replace(/&RightDoubleBracket;/g, '⟧');

        // "U+027E8", "MATHEMATICAL LEFT ANGLE BRACKET"
        txt = txt.replace(/&#x0*?27E8;/g, '⟨');
        txt = txt.replace(/&#0*?10216;/g, '⟨');
        txt = txt.replace(/&lang;/g, '⟨');
        txt = txt.replace(/&LeftAngleBracket;/g, '⟨');
        txt = txt.replace(/&langle;/g, '⟨');

        // "U+027E9", "MATHEMATICAL RIGHT ANGLE BRACKET"
        txt = txt.replace(/&#x0*?27E9;/g, '⟩');
        txt = txt.replace(/&#0*?10217;/g, '⟩');
        txt = txt.replace(/&rang;/g, '⟩');
        txt = txt.replace(/&RightAngleBracket;/g, '⟩');
        txt = txt.replace(/&rangle;/g, '⟩');

        // "U+027EA", "MATHEMATICAL LEFT DOUBLE ANGLE BRACKET"
        txt = txt.replace(/&#x0*?27EA;/g, '⟪');
        txt = txt.replace(/&#0*?10218;/g, '⟪');
        txt = txt.replace(/&Lang;/g, '⟪');

        // "U+027EB", "MATHEMATICAL RIGHT DOUBLE ANGLE BRACKET"
        txt = txt.replace(/&#x0*?27EB;/g, '⟫');
        txt = txt.replace(/&#0*?10219;/g, '⟫');
        txt = txt.replace(/&Rang;/g, '⟫');

        // "U+027EC", "MATHEMATICAL LEFT WHITE TORTOISE SHELL BRACKET"
        txt = txt.replace(/&#x0*?27EC;/g, '⟬');
        txt = txt.replace(/&#0*?10220;/g, '⟬');
        txt = txt.replace(/&loang;/g, '⟬');

        // "U+027ED", "MATHEMATICAL RIGHT WHITE TORTOISE SHELL BRACKET"
        txt = txt.replace(/&#x0*?27ED;/g, '⟭');
        txt = txt.replace(/&#0*?10221;/g, '⟭');
        txt = txt.replace(/&roang;/g, '⟭');

        // "U+027F5", "LONG LEFTWARDS ARROW"
        txt = txt.replace(/&#x0*?27F5;/g, '⟵');
        txt = txt.replace(/&#0*?10229;/g, '⟵');
        txt = txt.replace(/&xlarr;/g, '⟵');
        txt = txt.replace(/&longleftarrow;/g, '⟵');
        txt = txt.replace(/&LongLeftArrow;/g, '⟵');

        // "U+027F6", "LONG RIGHTWARDS ARROW"
        txt = txt.replace(/&#x0*?27F6;/g, '⟶');
        txt = txt.replace(/&#0*?10230;/g, '⟶');
        txt = txt.replace(/&xrarr;/g, '⟶');
        txt = txt.replace(/&longrightarrow;/g, '⟶');
        txt = txt.replace(/&LongRightArrow;/g, '⟶');

        // "U+027F7", "LONG LEFT RIGHT ARROW"
        txt = txt.replace(/&#x0*?27F7;/g, '⟷');
        txt = txt.replace(/&#0*?10231;/g, '⟷');
        txt = txt.replace(/&xharr;/g, '⟷');
        txt = txt.replace(/&longleftrightarrow;/g, '⟷');
        txt = txt.replace(/&LongLeftRightArrow;/g, '⟷');

        // "U+027F8", "LONG LEFTWARDS DOUBLE ARROW"
        txt = txt.replace(/&#x0*?27F8;/g, '⟸');
        txt = txt.replace(/&#0*?10232;/g, '⟸');
        txt = txt.replace(/&xlArr;/g, '⟸');
        txt = txt.replace(/&Longleftarrow;/g, '⟸');
        txt = txt.replace(/&DoubleLongLeftArrow;/g, '⟸');

        // "U+027F9", "LONG RIGHTWARDS DOUBLE ARROW"
        txt = txt.replace(/&#x0*?27F9;/g, '⟹');
        txt = txt.replace(/&#0*?10233;/g, '⟹');
        txt = txt.replace(/&xrArr;/g, '⟹');
        txt = txt.replace(/&Longrightarrow;/g, '⟹');
        txt = txt.replace(/&DoubleLongRightArrow;/g, '⟹');

        // "U+027FA", "LONG LEFT RIGHT DOUBLE ARROW"
        txt = txt.replace(/&#x0*?27FA;/g, '⟺');
        txt = txt.replace(/&#0*?10234;/g, '⟺');
        txt = txt.replace(/&xhArr;/g, '⟺');
        txt = txt.replace(/&Longleftrightarrow;/g, '⟺');
        txt = txt.replace(/&DoubleLongLeftRightArrow;/g, '⟺');

        // "U+027FC", "LONG RIGHTWARDS ARROW FROM BAR"
        txt = txt.replace(/&#x0*?27FC;/g, '⟼');
        txt = txt.replace(/&#0*?10236;/g, '⟼');
        txt = txt.replace(/&xmap;/g, '⟼');
        txt = txt.replace(/&longmapsto;/g, '⟼');

        // "U+027FF", "LONG RIGHTWARDS SQUIGGLE ARROW"
        txt = txt.replace(/&#x0*?27FF;/g, '⟿');
        txt = txt.replace(/&#0*?10239;/g, '⟿');
        txt = txt.replace(/&dzigrarr;/g, '⟿');

        // "U+02902", "LEFTWARDS DOUBLE ARROW WITH VERTICAL STROKE"
        txt = txt.replace(/&#x0*?2902;/g, '⤂');
        txt = txt.replace(/&#0*?10498;/g, '⤂');
        txt = txt.replace(/&nvlArr;/g, '⤂');

        // "U+02903", "RIGHTWARDS DOUBLE ARROW WITH VERTICAL STROKE"
        txt = txt.replace(/&#x0*?2903;/g, '⤃');
        txt = txt.replace(/&#0*?10499;/g, '⤃');
        txt = txt.replace(/&nvrArr;/g, '⤃');

        // "U+02904", "LEFT RIGHT DOUBLE ARROW WITH VERTICAL STROKE"
        txt = txt.replace(/&#x0*?2904;/g, '⤄');
        txt = txt.replace(/&#0*?10500;/g, '⤄');
        txt = txt.replace(/&nvHarr;/g, '⤄');

        // "U+02905", "RIGHTWARDS TWO-HEADED ARROW FROM BAR"
        txt = txt.replace(/&#x0*?2905;/g, '⤅');
        txt = txt.replace(/&#0*?10501;/g, '⤅');
        txt = txt.replace(/&Map;/g, '⤅');

        // "U+0290C", "LEFTWARDS DOUBLE DASH ARROW"
        txt = txt.replace(/&#x0*?290C;/g, '⤌');
        txt = txt.replace(/&#0*?10508;/g, '⤌');
        txt = txt.replace(/&lbarr;/g, '⤌');

        // "U+0290D", "RIGHTWARDS DOUBLE DASH ARROW"
        txt = txt.replace(/&#x0*?290D;/g, '⤍');
        txt = txt.replace(/&#0*?10509;/g, '⤍');
        txt = txt.replace(/&rbarr;/g, '⤍');
        txt = txt.replace(/&bkarow;/g, '⤍');

        // "U+0290E", "LEFTWARDS TRIPLE DASH ARROW"
        txt = txt.replace(/&#x0*?290E;/g, '⤎');
        txt = txt.replace(/&#0*?10510;/g, '⤎');
        txt = txt.replace(/&lBarr;/g, '⤎');

        // "U+0290F", "RIGHTWARDS TRIPLE DASH ARROW"
        txt = txt.replace(/&#x0*?290F;/g, '⤏');
        txt = txt.replace(/&#0*?10511;/g, '⤏');
        txt = txt.replace(/&rBarr;/g, '⤏');
        txt = txt.replace(/&dbkarow;/g, '⤏');

        // "U+02910", "RIGHTWARDS TWO-HEADED TRIPLE DASH ARROW"
        txt = txt.replace(/&#x0*?2910;/g, '⤐');
        txt = txt.replace(/&#0*?10512;/g, '⤐');
        txt = txt.replace(/&RBarr;/g, '⤐');
        txt = txt.replace(/&drbkarow;/g, '⤐');

        // "U+02911", "RIGHTWARDS ARROW WITH DOTTED STEM"
        txt = txt.replace(/&#x0*?2911;/g, '⤑');
        txt = txt.replace(/&#0*?10513;/g, '⤑');
        txt = txt.replace(/&DDotrahd;/g, '⤑');

        // "U+02912", "UPWARDS ARROW TO BAR"
        txt = txt.replace(/&#x0*?2912;/g, '⤒');
        txt = txt.replace(/&#0*?10514;/g, '⤒');
        txt = txt.replace(/&UpArrowBar;/g, '⤒');

        // "U+02913", "DOWNWARDS ARROW TO BAR"
        txt = txt.replace(/&#x0*?2913;/g, '⤓');
        txt = txt.replace(/&#0*?10515;/g, '⤓');
        txt = txt.replace(/&DownArrowBar;/g, '⤓');

        // "U+02916", "RIGHTWARDS TWO-HEADED ARROW WITH TAIL"
        txt = txt.replace(/&#x0*?2916;/g, '⤖');
        txt = txt.replace(/&#0*?10518;/g, '⤖');
        txt = txt.replace(/&Rarrtl;/g, '⤖');

        // "U+02919", "LEFTWARDS ARROW-TAIL"
        txt = txt.replace(/&#x0*?2919;/g, '⤙');
        txt = txt.replace(/&#0*?10521;/g, '⤙');
        txt = txt.replace(/&latail;/g, '⤙');

        // "U+0291A", "RIGHTWARDS ARROW-TAIL"
        txt = txt.replace(/&#x0*?291A;/g, '⤚');
        txt = txt.replace(/&#0*?10522;/g, '⤚');
        txt = txt.replace(/&ratail;/g, '⤚');

        // "U+0291B", "LEFTWARDS DOUBLE ARROW-TAIL"
        txt = txt.replace(/&#x0*?291B;/g, '⤛');
        txt = txt.replace(/&#0*?10523;/g, '⤛');
        txt = txt.replace(/&lAtail;/g, '⤛');

        // "U+0291C", "RIGHTWARDS DOUBLE ARROW-TAIL"
        txt = txt.replace(/&#x0*?291C;/g, '⤜');
        txt = txt.replace(/&#0*?10524;/g, '⤜');
        txt = txt.replace(/&rAtail;/g, '⤜');

        // "U+0291D", "LEFTWARDS ARROW TO BLACK DIAMOND"
        txt = txt.replace(/&#x0*?291D;/g, '⤝');
        txt = txt.replace(/&#0*?10525;/g, '⤝');
        txt = txt.replace(/&larrfs;/g, '⤝');

        // "U+0291E", "RIGHTWARDS ARROW TO BLACK DIAMOND"
        txt = txt.replace(/&#x0*?291E;/g, '⤞');
        txt = txt.replace(/&#0*?10526;/g, '⤞');
        txt = txt.replace(/&rarrfs;/g, '⤞');

        // "U+0291F", "LEFTWARDS ARROW FROM BAR TO BLACK DIAMOND"
        txt = txt.replace(/&#x0*?291F;/g, '⤟');
        txt = txt.replace(/&#0*?10527;/g, '⤟');
        txt = txt.replace(/&larrbfs;/g, '⤟');

        // "U+02920", "RIGHTWARDS ARROW FROM BAR TO BLACK DIAMOND"
        txt = txt.replace(/&#x0*?2920;/g, '⤠');
        txt = txt.replace(/&#0*?10528;/g, '⤠');
        txt = txt.replace(/&rarrbfs;/g, '⤠');

        // "U+02923", "NORTH WEST ARROW WITH HOOK"
        txt = txt.replace(/&#x0*?2923;/g, '⤣');
        txt = txt.replace(/&#0*?10531;/g, '⤣');
        txt = txt.replace(/&nwarhk;/g, '⤣');

        // "U+02924", "NORTH EAST ARROW WITH HOOK"
        txt = txt.replace(/&#x0*?2924;/g, '⤤');
        txt = txt.replace(/&#0*?10532;/g, '⤤');
        txt = txt.replace(/&nearhk;/g, '⤤');

        // "U+02925", "SOUTH EAST ARROW WITH HOOK"
        txt = txt.replace(/&#x0*?2925;/g, '⤥');
        txt = txt.replace(/&#0*?10533;/g, '⤥');
        txt = txt.replace(/&searhk;/g, '⤥');
        txt = txt.replace(/&hksearow;/g, '⤥');

        // "U+02926", "SOUTH WEST ARROW WITH HOOK"
        txt = txt.replace(/&#x0*?2926;/g, '⤦');
        txt = txt.replace(/&#0*?10534;/g, '⤦');
        txt = txt.replace(/&swarhk;/g, '⤦');
        txt = txt.replace(/&hkswarow;/g, '⤦');

        // "U+02927", "NORTH WEST ARROW AND NORTH EAST ARROW"
        txt = txt.replace(/&#x0*?2927;/g, '⤧');
        txt = txt.replace(/&#0*?10535;/g, '⤧');
        txt = txt.replace(/&nwnear;/g, '⤧');

        // "U+02928", "NORTH EAST ARROW AND SOUTH EAST ARROW"
        txt = txt.replace(/&#x0*?2928;/g, '⤨');
        txt = txt.replace(/&#0*?10536;/g, '⤨');
        txt = txt.replace(/&nesear;/g, '⤨');
        txt = txt.replace(/&toea;/g, '⤨');

        // "U+02929", "SOUTH EAST ARROW AND SOUTH WEST ARROW"
        txt = txt.replace(/&#x0*?2929;/g, '⤩');
        txt = txt.replace(/&#0*?10537;/g, '⤩');
        txt = txt.replace(/&seswar;/g, '⤩');
        txt = txt.replace(/&tosa;/g, '⤩');

        // "U+0292A", "SOUTH WEST ARROW AND NORTH WEST ARROW"
        txt = txt.replace(/&#x0*?292A;/g, '⤪');
        txt = txt.replace(/&#0*?10538;/g, '⤪');
        txt = txt.replace(/&swnwar;/g, '⤪');

        // "U+02933", "WAVE ARROW POINTING DIRECTLY RIGHT"
        txt = txt.replace(/&#x0*?2933;/g, '⤳');
        txt = txt.replace(/&#0*?10547;/g, '⤳');
        txt = txt.replace(/&rarrc;/g, '⤳');

        // "U+02935", "ARROW POINTING RIGHTWARDS THEN CURVING DOWNWARDS"
        txt = txt.replace(/&#x0*?2935;/g, '⤵');
        txt = txt.replace(/&#0*?10549;/g, '⤵');
        txt = txt.replace(/&cudarrr;/g, '⤵');

        // "U+02936", "ARROW POINTING DOWNWARDS THEN CURVING LEFTWARDS"
        txt = txt.replace(/&#x0*?2936;/g, '⤶');
        txt = txt.replace(/&#0*?10550;/g, '⤶');
        txt = txt.replace(/&ldca;/g, '⤶');

        // "U+02937", "ARROW POINTING DOWNWARDS THEN CURVING RIGHTWARDS"
        txt = txt.replace(/&#x0*?2937;/g, '⤷');
        txt = txt.replace(/&#0*?10551;/g, '⤷');
        txt = txt.replace(/&rdca;/g, '⤷');

        // "U+02938", "RIGHT-SIDE ARC CLOCKWISE ARROW"
        txt = txt.replace(/&#x0*?2938;/g, '⤸');
        txt = txt.replace(/&#0*?10552;/g, '⤸');
        txt = txt.replace(/&cudarrl;/g, '⤸');

        // "U+02939", "LEFT-SIDE ARC ANTICLOCKWISE ARROW"
        txt = txt.replace(/&#x0*?2939;/g, '⤹');
        txt = txt.replace(/&#0*?10553;/g, '⤹');
        txt = txt.replace(/&larrpl;/g, '⤹');

        // "U+0293C", "TOP ARC CLOCKWISE ARROW WITH MINUS"
        txt = txt.replace(/&#x0*?293C;/g, '⤼');
        txt = txt.replace(/&#0*?10556;/g, '⤼');
        txt = txt.replace(/&curarrm;/g, '⤼');

        // "U+0293D", "TOP ARC ANTICLOCKWISE ARROW WITH PLUS"
        txt = txt.replace(/&#x0*?293D;/g, '⤽');
        txt = txt.replace(/&#0*?10557;/g, '⤽');
        txt = txt.replace(/&cularrp;/g, '⤽');

        // "U+02945", "RIGHTWARDS ARROW WITH PLUS BELOW"
        txt = txt.replace(/&#x0*?2945;/g, '⥅');
        txt = txt.replace(/&#0*?10565;/g, '⥅');
        txt = txt.replace(/&rarrpl;/g, '⥅');

        // "U+02948", "LEFT RIGHT ARROW THROUGH SMALL CIRCLE"
        txt = txt.replace(/&#x0*?2948;/g, '⥈');
        txt = txt.replace(/&#0*?10568;/g, '⥈');
        txt = txt.replace(/&harrcir;/g, '⥈');

        // "U+02949", "UPWARDS TWO-HEADED ARROW FROM SMALL CIRCLE"
        txt = txt.replace(/&#x0*?2949;/g, '⥉');
        txt = txt.replace(/&#0*?10569;/g, '⥉');
        txt = txt.replace(/&Uarrocir;/g, '⥉');

        // "U+0294A", "LEFT BARB UP RIGHT BARB DOWN HARPOON"
        txt = txt.replace(/&#x0*?294A;/g, '⥊');
        txt = txt.replace(/&#0*?10570;/g, '⥊');
        txt = txt.replace(/&lurdshar;/g, '⥊');

        // "U+0294B", "LEFT BARB DOWN RIGHT BARB UP HARPOON"
        txt = txt.replace(/&#x0*?294B;/g, '⥋');
        txt = txt.replace(/&#0*?10571;/g, '⥋');
        txt = txt.replace(/&ldrushar;/g, '⥋');

        // "U+0294E", "LEFT BARB UP RIGHT BARB UP HARPOON"
        txt = txt.replace(/&#x0*?294E;/g, '⥎');
        txt = txt.replace(/&#0*?10574;/g, '⥎');
        txt = txt.replace(/&LeftRightVector;/g, '⥎');

        // "U+0294F", "UP BARB RIGHT DOWN BARB RIGHT HARPOON"
        txt = txt.replace(/&#x0*?294F;/g, '⥏');
        txt = txt.replace(/&#0*?10575;/g, '⥏');
        txt = txt.replace(/&RightUpDownVector;/g, '⥏');

        // "U+02950", "LEFT BARB DOWN RIGHT BARB DOWN HARPOON"
        txt = txt.replace(/&#x0*?2950;/g, '⥐');
        txt = txt.replace(/&#0*?10576;/g, '⥐');
        txt = txt.replace(/&DownLeftRightVector;/g, '⥐');

        // "U+02951", "UP BARB LEFT DOWN BARB LEFT HARPOON"
        txt = txt.replace(/&#x0*?2951;/g, '⥑');
        txt = txt.replace(/&#0*?10577;/g, '⥑');
        txt = txt.replace(/&LeftUpDownVector;/g, '⥑');

        // "U+02952", "LEFTWARDS HARPOON WITH BARB UP TO BAR"
        txt = txt.replace(/&#x0*?2952;/g, '⥒');
        txt = txt.replace(/&#0*?10578;/g, '⥒');
        txt = txt.replace(/&LeftVectorBar;/g, '⥒');

        // "U+02953", "RIGHTWARDS HARPOON WITH BARB UP TO BAR"
        txt = txt.replace(/&#x0*?2953;/g, '⥓');
        txt = txt.replace(/&#0*?10579;/g, '⥓');
        txt = txt.replace(/&RightVectorBar;/g, '⥓');

        // "U+02954", "UPWARDS HARPOON WITH BARB RIGHT TO BAR"
        txt = txt.replace(/&#x0*?2954;/g, '⥔');
        txt = txt.replace(/&#0*?10580;/g, '⥔');
        txt = txt.replace(/&RightUpVectorBar;/g, '⥔');

        // "U+02955", "DOWNWARDS HARPOON WITH BARB RIGHT TO BAR"
        txt = txt.replace(/&#x0*?2955;/g, '⥕');
        txt = txt.replace(/&#0*?10581;/g, '⥕');
        txt = txt.replace(/&RightDownVectorBar;/g, '⥕');

        // "U+02956", "LEFTWARDS HARPOON WITH BARB DOWN TO BAR"
        txt = txt.replace(/&#x0*?2956;/g, '⥖');
        txt = txt.replace(/&#0*?10582;/g, '⥖');
        txt = txt.replace(/&DownLeftVectorBar;/g, '⥖');

        // "U+02957", "RIGHTWARDS HARPOON WITH BARB DOWN TO BAR"
        txt = txt.replace(/&#x0*?2957;/g, '⥗');
        txt = txt.replace(/&#0*?10583;/g, '⥗');
        txt = txt.replace(/&DownRightVectorBar;/g, '⥗');

        // "U+02958", "UPWARDS HARPOON WITH BARB LEFT TO BAR"
        txt = txt.replace(/&#x0*?2958;/g, '⥘');
        txt = txt.replace(/&#0*?10584;/g, '⥘');
        txt = txt.replace(/&LeftUpVectorBar;/g, '⥘');

        // "U+02959", "DOWNWARDS HARPOON WITH BARB LEFT TO BAR"
        txt = txt.replace(/&#x0*?2959;/g, '⥙');
        txt = txt.replace(/&#0*?10585;/g, '⥙');
        txt = txt.replace(/&LeftDownVectorBar;/g, '⥙');

        // "U+0295A", "LEFTWARDS HARPOON WITH BARB UP FROM BAR"
        txt = txt.replace(/&#x0*?295A;/g, '⥚');
        txt = txt.replace(/&#0*?10586;/g, '⥚');
        txt = txt.replace(/&LeftTeeVector;/g, '⥚');

        // "U+0295B", "RIGHTWARDS HARPOON WITH BARB UP FROM BAR"
        txt = txt.replace(/&#x0*?295B;/g, '⥛');
        txt = txt.replace(/&#0*?10587;/g, '⥛');
        txt = txt.replace(/&RightTeeVector;/g, '⥛');

        // "U+0295C", "UPWARDS HARPOON WITH BARB RIGHT FROM BAR"
        txt = txt.replace(/&#x0*?295C;/g, '⥜');
        txt = txt.replace(/&#0*?10588;/g, '⥜');
        txt = txt.replace(/&RightUpTeeVector;/g, '⥜');

        // "U+0295D", "DOWNWARDS HARPOON WITH BARB RIGHT FROM BAR"
        txt = txt.replace(/&#x0*?295D;/g, '⥝');
        txt = txt.replace(/&#0*?10589;/g, '⥝');
        txt = txt.replace(/&RightDownTeeVector;/g, '⥝');

        // "U+0295E", "LEFTWARDS HARPOON WITH BARB DOWN FROM BAR"
        txt = txt.replace(/&#x0*?295E;/g, '⥞');
        txt = txt.replace(/&#0*?10590;/g, '⥞');
        txt = txt.replace(/&DownLeftTeeVector;/g, '⥞');

        // "U+0295F", "RIGHTWARDS HARPOON WITH BARB DOWN FROM BAR"
        txt = txt.replace(/&#x0*?295F;/g, '⥟');
        txt = txt.replace(/&#0*?10591;/g, '⥟');
        txt = txt.replace(/&DownRightTeeVector;/g, '⥟');

        // "U+02960", "UPWARDS HARPOON WITH BARB LEFT FROM BAR"
        txt = txt.replace(/&#x0*?2960;/g, '⥠');
        txt = txt.replace(/&#0*?10592;/g, '⥠');
        txt = txt.replace(/&LeftUpTeeVector;/g, '⥠');

        // "U+02961", "DOWNWARDS HARPOON WITH BARB LEFT FROM BAR"
        txt = txt.replace(/&#x0*?2961;/g, '⥡');
        txt = txt.replace(/&#0*?10593;/g, '⥡');
        txt = txt.replace(/&LeftDownTeeVector;/g, '⥡');

        // "U+02962", "LEFTWARDS HARPOON WITH BARB UP ABOVE LEFTWARDS HARPOON WITH BARB DOWN"
        txt = txt.replace(/&#x0*?2962;/g, '⥢');
        txt = txt.replace(/&#0*?10594;/g, '⥢');
        txt = txt.replace(/&lHar;/g, '⥢');

        // "U+02963", "UPWARDS HARPOON WITH BARB LEFT BESIDE UPWARDS HARPOON WITH BARB RIGHT"
        txt = txt.replace(/&#x0*?2963;/g, '⥣');
        txt = txt.replace(/&#0*?10595;/g, '⥣');
        txt = txt.replace(/&uHar;/g, '⥣');

        // "U+02964", "RIGHTWARDS HARPOON WITH BARB UP ABOVE RIGHTWARDS HARPOON WITH BARB DOWN"
        txt = txt.replace(/&#x0*?2964;/g, '⥤');
        txt = txt.replace(/&#0*?10596;/g, '⥤');
        txt = txt.replace(/&rHar;/g, '⥤');

        // "U+02965", "DOWNWARDS HARPOON WITH BARB LEFT BESIDE DOWNWARDS HARPOON WITH BARB RIGHT"
        txt = txt.replace(/&#x0*?2965;/g, '⥥');
        txt = txt.replace(/&#0*?10597;/g, '⥥');
        txt = txt.replace(/&dHar;/g, '⥥');

        // "U+02966", "LEFTWARDS HARPOON WITH BARB UP ABOVE RIGHTWARDS HARPOON WITH BARB UP"
        txt = txt.replace(/&#x0*?2966;/g, '⥦');
        txt = txt.replace(/&#0*?10598;/g, '⥦');
        txt = txt.replace(/&luruhar;/g, '⥦');

        // "U+02967", "LEFTWARDS HARPOON WITH BARB DOWN ABOVE RIGHTWARDS HARPOON WITH BARB DOWN"
        txt = txt.replace(/&#x0*?2967;/g, '⥧');
        txt = txt.replace(/&#0*?10599;/g, '⥧');
        txt = txt.replace(/&ldrdhar;/g, '⥧');

        // "U+02968", "RIGHTWARDS HARPOON WITH BARB UP ABOVE LEFTWARDS HARPOON WITH BARB UP"
        txt = txt.replace(/&#x0*?2968;/g, '⥨');
        txt = txt.replace(/&#0*?10600;/g, '⥨');
        txt = txt.replace(/&ruluhar;/g, '⥨');

        // "U+02969", "RIGHTWARDS HARPOON WITH BARB DOWN ABOVE LEFTWARDS HARPOON WITH BARB DOWN"
        txt = txt.replace(/&#x0*?2969;/g, '⥩');
        txt = txt.replace(/&#0*?10601;/g, '⥩');
        txt = txt.replace(/&rdldhar;/g, '⥩');

        // "U+0296A", "LEFTWARDS HARPOON WITH BARB UP ABOVE LONG DASH"
        txt = txt.replace(/&#x0*?296A;/g, '⥪');
        txt = txt.replace(/&#0*?10602;/g, '⥪');
        txt = txt.replace(/&lharul;/g, '⥪');

        // "U+0296B", "LEFTWARDS HARPOON WITH BARB DOWN BELOW LONG DASH"
        txt = txt.replace(/&#x0*?296B;/g, '⥫');
        txt = txt.replace(/&#0*?10603;/g, '⥫');
        txt = txt.replace(/&llhard;/g, '⥫');

        // "U+0296C", "RIGHTWARDS HARPOON WITH BARB UP ABOVE LONG DASH"
        txt = txt.replace(/&#x0*?296C;/g, '⥬');
        txt = txt.replace(/&#0*?10604;/g, '⥬');
        txt = txt.replace(/&rharul;/g, '⥬');

        // "U+0296D", "RIGHTWARDS HARPOON WITH BARB DOWN BELOW LONG DASH"
        txt = txt.replace(/&#x0*?296D;/g, '⥭');
        txt = txt.replace(/&#0*?10605;/g, '⥭');
        txt = txt.replace(/&lrhard;/g, '⥭');

        // "U+0296E", "UPWARDS HARPOON WITH BARB LEFT BESIDE DOWNWARDS HARPOON WITH BARB RIGHT"
        txt = txt.replace(/&#x0*?296E;/g, '⥮');
        txt = txt.replace(/&#0*?10606;/g, '⥮');
        txt = txt.replace(/&udhar;/g, '⥮');
        txt = txt.replace(/&UpEquilibrium;/g, '⥮');

        // "U+0296F", "DOWNWARDS HARPOON WITH BARB LEFT BESIDE UPWARDS HARPOON WITH BARB RIGHT"
        txt = txt.replace(/&#x0*?296F;/g, '⥯');
        txt = txt.replace(/&#0*?10607;/g, '⥯');
        txt = txt.replace(/&duhar;/g, '⥯');
        txt = txt.replace(/&ReverseUpEquilibrium;/g, '⥯');

        // "U+02970", "RIGHT DOUBLE ARROW WITH ROUNDED HEAD"
        txt = txt.replace(/&#x0*?2970;/g, '⥰');
        txt = txt.replace(/&#0*?10608;/g, '⥰');
        txt = txt.replace(/&RoundImplies;/g, '⥰');

        // "U+02971", "EQUALS SIGN ABOVE RIGHTWARDS ARROW"
        txt = txt.replace(/&#x0*?2971;/g, '⥱');
        txt = txt.replace(/&#0*?10609;/g, '⥱');
        txt = txt.replace(/&erarr;/g, '⥱');

        // "U+02972", "TILDE OPERATOR ABOVE RIGHTWARDS ARROW"
        txt = txt.replace(/&#x0*?2972;/g, '⥲');
        txt = txt.replace(/&#0*?10610;/g, '⥲');
        txt = txt.replace(/&simrarr;/g, '⥲');

        // "U+02973", "LEFTWARDS ARROW ABOVE TILDE OPERATOR"
        txt = txt.replace(/&#x0*?2973;/g, '⥳');
        txt = txt.replace(/&#0*?10611;/g, '⥳');
        txt = txt.replace(/&larrsim;/g, '⥳');

        // "U+02974", "RIGHTWARDS ARROW ABOVE TILDE OPERATOR"
        txt = txt.replace(/&#x0*?2974;/g, '⥴');
        txt = txt.replace(/&#0*?10612;/g, '⥴');
        txt = txt.replace(/&rarrsim;/g, '⥴');

        // "U+02975", "RIGHTWARDS ARROW ABOVE ALMOST EQUAL TO"
        txt = txt.replace(/&#x0*?2975;/g, '⥵');
        txt = txt.replace(/&#0*?10613;/g, '⥵');
        txt = txt.replace(/&rarrap;/g, '⥵');

        // "U+02976", "LESS-THAN ABOVE LEFTWARDS ARROW"
        txt = txt.replace(/&#x0*?2976;/g, '⥶');
        txt = txt.replace(/&#0*?10614;/g, '⥶');
        txt = txt.replace(/&ltlarr;/g, '⥶');

        // "U+02978", "GREATER-THAN ABOVE RIGHTWARDS ARROW"
        txt = txt.replace(/&#x0*?2978;/g, '⥸');
        txt = txt.replace(/&#0*?10616;/g, '⥸');
        txt = txt.replace(/&gtrarr;/g, '⥸');

        // "U+02979", "SUBSET ABOVE RIGHTWARDS ARROW"
        txt = txt.replace(/&#x0*?2979;/g, '⥹');
        txt = txt.replace(/&#0*?10617;/g, '⥹');
        txt = txt.replace(/&subrarr;/g, '⥹');

        // "U+0297B", "SUPERSET ABOVE LEFTWARDS ARROW"
        txt = txt.replace(/&#x0*?297B;/g, '⥻');
        txt = txt.replace(/&#0*?10619;/g, '⥻');
        txt = txt.replace(/&suplarr;/g, '⥻');

        // "U+0297C", "LEFT FISH TAIL"
        txt = txt.replace(/&#x0*?297C;/g, '⥼');
        txt = txt.replace(/&#0*?10620;/g, '⥼');
        txt = txt.replace(/&lfisht;/g, '⥼');

        // "U+0297D", "RIGHT FISH TAIL"
        txt = txt.replace(/&#x0*?297D;/g, '⥽');
        txt = txt.replace(/&#0*?10621;/g, '⥽');
        txt = txt.replace(/&rfisht;/g, '⥽');

        // "U+0297E", "UP FISH TAIL"
        txt = txt.replace(/&#x0*?297E;/g, '⥾');
        txt = txt.replace(/&#0*?10622;/g, '⥾');
        txt = txt.replace(/&ufisht;/g, '⥾');

        // "U+0297F", "DOWN FISH TAIL"
        txt = txt.replace(/&#x0*?297F;/g, '⥿');
        txt = txt.replace(/&#0*?10623;/g, '⥿');
        txt = txt.replace(/&dfisht;/g, '⥿');

        // "U+02985", "LEFT WHITE PARENTHESIS"
        txt = txt.replace(/&#x0*?2985;/g, '⦅');
        txt = txt.replace(/&#0*?10629;/g, '⦅');
        txt = txt.replace(/&lopar;/g, '⦅');

        // "U+02986", "RIGHT WHITE PARENTHESIS"
        txt = txt.replace(/&#x0*?2986;/g, '⦆');
        txt = txt.replace(/&#0*?10630;/g, '⦆');
        txt = txt.replace(/&ropar;/g, '⦆');

        // "U+0298B", "LEFT SQUARE BRACKET WITH UNDERBAR"
        txt = txt.replace(/&#x0*?298B;/g, '⦋');
        txt = txt.replace(/&#0*?10635;/g, '⦋');
        txt = txt.replace(/&lbrke;/g, '⦋');

        // "U+0298C", "RIGHT SQUARE BRACKET WITH UNDERBAR"
        txt = txt.replace(/&#x0*?298C;/g, '⦌');
        txt = txt.replace(/&#0*?10636;/g, '⦌');
        txt = txt.replace(/&rbrke;/g, '⦌');

        // "U+0298D", "LEFT SQUARE BRACKET WITH TICK IN TOP CORNER"
        txt = txt.replace(/&#x0*?298D;/g, '⦍');
        txt = txt.replace(/&#0*?10637;/g, '⦍');
        txt = txt.replace(/&lbrkslu;/g, '⦍');

        // "U+0298E", "RIGHT SQUARE BRACKET WITH TICK IN BOTTOM CORNER"
        txt = txt.replace(/&#x0*?298E;/g, '⦎');
        txt = txt.replace(/&#0*?10638;/g, '⦎');
        txt = txt.replace(/&rbrksld;/g, '⦎');

        // "U+0298F", "LEFT SQUARE BRACKET WITH TICK IN BOTTOM CORNER"
        txt = txt.replace(/&#x0*?298F;/g, '⦏');
        txt = txt.replace(/&#0*?10639;/g, '⦏');
        txt = txt.replace(/&lbrksld;/g, '⦏');

        // "U+02990", "RIGHT SQUARE BRACKET WITH TICK IN TOP CORNER"
        txt = txt.replace(/&#x0*?2990;/g, '⦐');
        txt = txt.replace(/&#0*?10640;/g, '⦐');
        txt = txt.replace(/&rbrkslu;/g, '⦐');

        // "U+02991", "LEFT ANGLE BRACKET WITH DOT"
        txt = txt.replace(/&#x0*?2991;/g, '⦑');
        txt = txt.replace(/&#0*?10641;/g, '⦑');
        txt = txt.replace(/&langd;/g, '⦑');

        // "U+02992", "RIGHT ANGLE BRACKET WITH DOT"
        txt = txt.replace(/&#x0*?2992;/g, '⦒');
        txt = txt.replace(/&#0*?10642;/g, '⦒');
        txt = txt.replace(/&rangd;/g, '⦒');

        // "U+02993", "LEFT ARC LESS-THAN BRACKET"
        txt = txt.replace(/&#x0*?2993;/g, '⦓');
        txt = txt.replace(/&#0*?10643;/g, '⦓');
        txt = txt.replace(/&lparlt;/g, '⦓');

        // "U+02994", "RIGHT ARC GREATER-THAN BRACKET"
        txt = txt.replace(/&#x0*?2994;/g, '⦔');
        txt = txt.replace(/&#0*?10644;/g, '⦔');
        txt = txt.replace(/&rpargt;/g, '⦔');

        // "U+02995", "DOUBLE LEFT ARC GREATER-THAN BRACKET"
        txt = txt.replace(/&#x0*?2995;/g, '⦕');
        txt = txt.replace(/&#0*?10645;/g, '⦕');
        txt = txt.replace(/&gtlPar;/g, '⦕');

        // "U+02996", "DOUBLE RIGHT ARC LESS-THAN BRACKET"
        txt = txt.replace(/&#x0*?2996;/g, '⦖');
        txt = txt.replace(/&#0*?10646;/g, '⦖');
        txt = txt.replace(/&ltrPar;/g, '⦖');

        // "U+0299A", "VERTICAL ZIGZAG LINE"
        txt = txt.replace(/&#x0*?299A;/g, '⦚');
        txt = txt.replace(/&#0*?10650;/g, '⦚');
        txt = txt.replace(/&vzigzag;/g, '⦚');

        // "U+0299C", "RIGHT ANGLE VARIANT WITH SQUARE"
        txt = txt.replace(/&#x0*?299C;/g, '⦜');
        txt = txt.replace(/&#0*?10652;/g, '⦜');
        txt = txt.replace(/&vangrt;/g, '⦜');

        // "U+0299D", "MEASURED RIGHT ANGLE WITH DOT"
        txt = txt.replace(/&#x0*?299D;/g, '⦝');
        txt = txt.replace(/&#0*?10653;/g, '⦝');
        txt = txt.replace(/&angrtvbd;/g, '⦝');

        // "U+029A4", "ANGLE WITH UNDERBAR"
        txt = txt.replace(/&#x0*?29A4;/g, '⦤');
        txt = txt.replace(/&#0*?10660;/g, '⦤');
        txt = txt.replace(/&ange;/g, '⦤');

        // "U+029A5", "REVERSED ANGLE WITH UNDERBAR"
        txt = txt.replace(/&#x0*?29A5;/g, '⦥');
        txt = txt.replace(/&#0*?10661;/g, '⦥');
        txt = txt.replace(/&range;/g, '⦥');

        // "U+029A6", "OBLIQUE ANGLE OPENING UP"
        txt = txt.replace(/&#x0*?29A6;/g, '⦦');
        txt = txt.replace(/&#0*?10662;/g, '⦦');
        txt = txt.replace(/&dwangle;/g, '⦦');

        // "U+029A7", "OBLIQUE ANGLE OPENING DOWN"
        txt = txt.replace(/&#x0*?29A7;/g, '⦧');
        txt = txt.replace(/&#0*?10663;/g, '⦧');
        txt = txt.replace(/&uwangle;/g, '⦧');

        // "U+029A8", "MEASURED ANGLE WITH OPEN ARM ENDING IN ARROW POINTING UP AND RIGHT"
        txt = txt.replace(/&#x0*?29A8;/g, '⦨');
        txt = txt.replace(/&#0*?10664;/g, '⦨');
        txt = txt.replace(/&angmsdaa;/g, '⦨');

        // "U+029A9", "MEASURED ANGLE WITH OPEN ARM ENDING IN ARROW POINTING UP AND LEFT"
        txt = txt.replace(/&#x0*?29A9;/g, '⦩');
        txt = txt.replace(/&#0*?10665;/g, '⦩');
        txt = txt.replace(/&angmsdab;/g, '⦩');

        // "U+029AA", "MEASURED ANGLE WITH OPEN ARM ENDING IN ARROW POINTING DOWN AND RIGHT"
        txt = txt.replace(/&#x0*?29AA;/g, '⦪');
        txt = txt.replace(/&#0*?10666;/g, '⦪');
        txt = txt.replace(/&angmsdac;/g, '⦪');

        // "U+029AB", "MEASURED ANGLE WITH OPEN ARM ENDING IN ARROW POINTING DOWN AND LEFT"
        txt = txt.replace(/&#x0*?29AB;/g, '⦫');
        txt = txt.replace(/&#0*?10667;/g, '⦫');
        txt = txt.replace(/&angmsdad;/g, '⦫');

        // "U+029AC", "MEASURED ANGLE WITH OPEN ARM ENDING IN ARROW POINTING RIGHT AND UP"
        txt = txt.replace(/&#x0*?29AC;/g, '⦬');
        txt = txt.replace(/&#0*?10668;/g, '⦬');
        txt = txt.replace(/&angmsdae;/g, '⦬');

        // "U+029AD", "MEASURED ANGLE WITH OPEN ARM ENDING IN ARROW POINTING LEFT AND UP"
        txt = txt.replace(/&#x0*?29AD;/g, '⦭');
        txt = txt.replace(/&#0*?10669;/g, '⦭');
        txt = txt.replace(/&angmsdaf;/g, '⦭');

        // "U+029AE", "MEASURED ANGLE WITH OPEN ARM ENDING IN ARROW POINTING RIGHT AND DOWN"
        txt = txt.replace(/&#x0*?29AE;/g, '⦮');
        txt = txt.replace(/&#0*?10670;/g, '⦮');
        txt = txt.replace(/&angmsdag;/g, '⦮');

        // "U+029AF", "MEASURED ANGLE WITH OPEN ARM ENDING IN ARROW POINTING LEFT AND DOWN"
        txt = txt.replace(/&#x0*?29AF;/g, '⦯');
        txt = txt.replace(/&#0*?10671;/g, '⦯');
        txt = txt.replace(/&angmsdah;/g, '⦯');

        // "U+029B0", "REVERSED EMPTY SET"
        txt = txt.replace(/&#x0*?29B0;/g, '⦰');
        txt = txt.replace(/&#0*?10672;/g, '⦰');
        txt = txt.replace(/&bemptyv;/g, '⦰');

        // "U+029B1", "EMPTY SET WITH OVERBAR"
        txt = txt.replace(/&#x0*?29B1;/g, '⦱');
        txt = txt.replace(/&#0*?10673;/g, '⦱');
        txt = txt.replace(/&demptyv;/g, '⦱');

        // "U+029B2", "EMPTY SET WITH SMALL CIRCLE ABOVE"
        txt = txt.replace(/&#x0*?29B2;/g, '⦲');
        txt = txt.replace(/&#0*?10674;/g, '⦲');
        txt = txt.replace(/&cemptyv;/g, '⦲');

        // "U+029B3", "EMPTY SET WITH RIGHT ARROW ABOVE"
        txt = txt.replace(/&#x0*?29B3;/g, '⦳');
        txt = txt.replace(/&#0*?10675;/g, '⦳');
        txt = txt.replace(/&raemptyv;/g, '⦳');

        // "U+029B4", "EMPTY SET WITH LEFT ARROW ABOVE"
        txt = txt.replace(/&#x0*?29B4;/g, '⦴');
        txt = txt.replace(/&#0*?10676;/g, '⦴');
        txt = txt.replace(/&laemptyv;/g, '⦴');

        // "U+029B5", "CIRCLE WITH HORIZONTAL BAR"
        txt = txt.replace(/&#x0*?29B5;/g, '⦵');
        txt = txt.replace(/&#0*?10677;/g, '⦵');
        txt = txt.replace(/&ohbar;/g, '⦵');

        // "U+029B6", "CIRCLED VERTICAL BAR"
        txt = txt.replace(/&#x0*?29B6;/g, '⦶');
        txt = txt.replace(/&#0*?10678;/g, '⦶');
        txt = txt.replace(/&omid;/g, '⦶');

        // "U+029B7", "CIRCLED PARALLEL"
        txt = txt.replace(/&#x0*?29B7;/g, '⦷');
        txt = txt.replace(/&#0*?10679;/g, '⦷');
        txt = txt.replace(/&opar;/g, '⦷');

        // "U+029B9", "CIRCLED PERPENDICULAR"
        txt = txt.replace(/&#x0*?29B9;/g, '⦹');
        txt = txt.replace(/&#0*?10681;/g, '⦹');
        txt = txt.replace(/&operp;/g, '⦹');

        // "U+029BB", "CIRCLE WITH SUPERIMPOSED X"
        txt = txt.replace(/&#x0*?29BB;/g, '⦻');
        txt = txt.replace(/&#0*?10683;/g, '⦻');
        txt = txt.replace(/&olcross;/g, '⦻');

        // "U+029BC", "CIRCLED ANTICLOCKWISE-ROTATED DIVISION SIGN"
        txt = txt.replace(/&#x0*?29BC;/g, '⦼');
        txt = txt.replace(/&#0*?10684;/g, '⦼');
        txt = txt.replace(/&odsold;/g, '⦼');

        // "U+029BE", "CIRCLED WHITE BULLET"
        txt = txt.replace(/&#x0*?29BE;/g, '⦾');
        txt = txt.replace(/&#0*?10686;/g, '⦾');
        txt = txt.replace(/&olcir;/g, '⦾');

        // "U+029BF", "CIRCLED BULLET"
        txt = txt.replace(/&#x0*?29BF;/g, '⦿');
        txt = txt.replace(/&#0*?10687;/g, '⦿');
        txt = txt.replace(/&ofcir;/g, '⦿');

        // "U+029C0", "CIRCLED LESS-THAN"
        txt = txt.replace(/&#x0*?29C0;/g, '⧀');
        txt = txt.replace(/&#0*?10688;/g, '⧀');
        txt = txt.replace(/&olt;/g, '⧀');

        // "U+029C1", "CIRCLED GREATER-THAN"
        txt = txt.replace(/&#x0*?29C1;/g, '⧁');
        txt = txt.replace(/&#0*?10689;/g, '⧁');
        txt = txt.replace(/&ogt;/g, '⧁');

        // "U+029C2", "CIRCLE WITH SMALL CIRCLE TO THE RIGHT"
        txt = txt.replace(/&#x0*?29C2;/g, '⧂');
        txt = txt.replace(/&#0*?10690;/g, '⧂');
        txt = txt.replace(/&cirscir;/g, '⧂');

        // "U+029C3", "CIRCLE WITH TWO HORIZONTAL STROKES TO THE RIGHT"
        txt = txt.replace(/&#x0*?29C3;/g, '⧃');
        txt = txt.replace(/&#0*?10691;/g, '⧃');
        txt = txt.replace(/&cirE;/g, '⧃');

        // "U+029C4", "SQUARED RISING DIAGONAL SLASH"
        txt = txt.replace(/&#x0*?29C4;/g, '⧄');
        txt = txt.replace(/&#0*?10692;/g, '⧄');
        txt = txt.replace(/&solb;/g, '⧄');

        // "U+029C5", "SQUARED FALLING DIAGONAL SLASH"
        txt = txt.replace(/&#x0*?29C5;/g, '⧅');
        txt = txt.replace(/&#0*?10693;/g, '⧅');
        txt = txt.replace(/&bsolb;/g, '⧅');

        // "U+029C9", "TWO JOINED SQUARES"
        txt = txt.replace(/&#x0*?29C9;/g, '⧉');
        txt = txt.replace(/&#0*?10697;/g, '⧉');
        txt = txt.replace(/&boxbox;/g, '⧉');

        // "U+029CD", "TRIANGLE WITH SERIFS AT BOTTOM"
        txt = txt.replace(/&#x0*?29CD;/g, '⧍');
        txt = txt.replace(/&#0*?10701;/g, '⧍');
        txt = txt.replace(/&trisb;/g, '⧍');

        // "U+029CE", "RIGHT TRIANGLE ABOVE LEFT TRIANGLE"
        txt = txt.replace(/&#x0*?29CE;/g, '⧎');
        txt = txt.replace(/&#0*?10702;/g, '⧎');
        txt = txt.replace(/&rtriltri;/g, '⧎');

        // "U+029CF", "LEFT TRIANGLE BESIDE VERTICAL BAR"
        txt = txt.replace(/&#x0*?29CF;/g, '⧏');
        txt = txt.replace(/&#0*?10703;/g, '⧏');
        txt = txt.replace(/&LeftTriangleBar;/g, '⧏');

        // "U+029D0", "VERTICAL BAR BESIDE RIGHT TRIANGLE"
        txt = txt.replace(/&#x0*?29D0;/g, '⧐');
        txt = txt.replace(/&#0*?10704;/g, '⧐');
        txt = txt.replace(/&RightTriangleBar;/g, '⧐');

        // "U+029DA", "LEFT DOUBLE WIGGLY FENCE"
        txt = txt.replace(/&#x0*?29DA;/g, '⧚');
        txt = txt.replace(/&#0*?10714;/g, '⧚');
        txt = txt.replace(/&race;/g, '⧚');

        // "U+029DC", "INCOMPLETE INFINITY"
        txt = txt.replace(/&#x0*?29DC;/g, '⧜');
        txt = txt.replace(/&#0*?10716;/g, '⧜');
        txt = txt.replace(/&iinfin;/g, '⧜');

        // "U+029DD", "TIE OVER INFINITY"
        txt = txt.replace(/&#x0*?29DD;/g, '⧝');
        txt = txt.replace(/&#0*?10717;/g, '⧝');
        txt = txt.replace(/&infintie;/g, '⧝');

        // "U+029DE", "INFINITY NEGATED WITH VERTICAL BAR"
        txt = txt.replace(/&#x0*?29DE;/g, '⧞');
        txt = txt.replace(/&#0*?10718;/g, '⧞');
        txt = txt.replace(/&nvinfin;/g, '⧞');

        // "U+029E3", "EQUALS SIGN AND SLANTED PARALLEL"
        txt = txt.replace(/&#x0*?29E3;/g, '⧣');
        txt = txt.replace(/&#0*?10723;/g, '⧣');
        txt = txt.replace(/&eparsl;/g, '⧣');

        // "U+029E4", "EQUALS SIGN AND SLANTED PARALLEL WITH TILDE ABOVE"
        txt = txt.replace(/&#x0*?29E4;/g, '⧤');
        txt = txt.replace(/&#0*?10724;/g, '⧤');
        txt = txt.replace(/&smeparsl;/g, '⧤');

        // "U+029E5", "IDENTICAL TO AND SLANTED PARALLEL"
        txt = txt.replace(/&#x0*?29E5;/g, '⧥');
        txt = txt.replace(/&#0*?10725;/g, '⧥');
        txt = txt.replace(/&eqvparsl;/g, '⧥');

        // "U+029EB", "BLACK LOZENGE"
        txt = txt.replace(/&#x0*?29EB;/g, '⧫');
        txt = txt.replace(/&#0*?10731;/g, '⧫');
        txt = txt.replace(/&lozf;/g, '⧫');
        txt = txt.replace(/&blacklozenge;/g, '⧫');

        // "U+029F4", "RULE-DELAYED"
        txt = txt.replace(/&#x0*?29F4;/g, '⧴');
        txt = txt.replace(/&#0*?10740;/g, '⧴');
        txt = txt.replace(/&RuleDelayed;/g, '⧴');

        // "U+029F6", "SOLIDUS WITH OVERBAR"
        txt = txt.replace(/&#x0*?29F6;/g, '⧶');
        txt = txt.replace(/&#0*?10742;/g, '⧶');
        txt = txt.replace(/&dsol;/g, '⧶');

        // "U+02A00", "N-ARY CIRCLED DOT OPERATOR"
        txt = txt.replace(/&#x0*?2A00;/g, '⨀');
        txt = txt.replace(/&#0*?10752;/g, '⨀');
        txt = txt.replace(/&xodot;/g, '⨀');
        txt = txt.replace(/&bigodot;/g, '⨀');

        // "U+02A01", "N-ARY CIRCLED PLUS OPERATOR"
        txt = txt.replace(/&#x0*?2A01;/g, '⨁');
        txt = txt.replace(/&#0*?10753;/g, '⨁');
        txt = txt.replace(/&xoplus;/g, '⨁');
        txt = txt.replace(/&bigoplus;/g, '⨁');

        // "U+02A02", "N-ARY CIRCLED TIMES OPERATOR"
        txt = txt.replace(/&#x0*?2A02;/g, '⨂');
        txt = txt.replace(/&#0*?10754;/g, '⨂');
        txt = txt.replace(/&xotime;/g, '⨂');
        txt = txt.replace(/&bigotimes;/g, '⨂');

        // "U+02A04", "N-ARY UNION OPERATOR WITH PLUS"
        txt = txt.replace(/&#x0*?2A04;/g, '⨄');
        txt = txt.replace(/&#0*?10756;/g, '⨄');
        txt = txt.replace(/&xuplus;/g, '⨄');
        txt = txt.replace(/&biguplus;/g, '⨄');

        // "U+02A06", "N-ARY SQUARE UNION OPERATOR"
        txt = txt.replace(/&#x0*?2A06;/g, '⨆');
        txt = txt.replace(/&#0*?10758;/g, '⨆');
        txt = txt.replace(/&xsqcup;/g, '⨆');
        txt = txt.replace(/&bigsqcup;/g, '⨆');

        // "U+02A0C", "QUADRUPLE INTEGRAL OPERATOR"
        txt = txt.replace(/&#x0*?2A0C;/g, '⨌');
        txt = txt.replace(/&#0*?10764;/g, '⨌');
        txt = txt.replace(/&qint;/g, '⨌');
        txt = txt.replace(/&iiiint;/g, '⨌');

        // "U+02A0D", "FINITE PART INTEGRAL"
        txt = txt.replace(/&#x0*?2A0D;/g, '⨍');
        txt = txt.replace(/&#0*?10765;/g, '⨍');
        txt = txt.replace(/&fpartint;/g, '⨍');

        // "U+02A10", "CIRCULATION FUNCTION"
        txt = txt.replace(/&#x0*?2A10;/g, '⨐');
        txt = txt.replace(/&#0*?10768;/g, '⨐');
        txt = txt.replace(/&cirfnint;/g, '⨐');

        // "U+02A11", "ANTICLOCKWISE INTEGRATION"
        txt = txt.replace(/&#x0*?2A11;/g, '⨑');
        txt = txt.replace(/&#0*?10769;/g, '⨑');
        txt = txt.replace(/&awint;/g, '⨑');

        // "U+02A12", "LINE INTEGRATION WITH RECTANGULAR PATH AROUND POLE"
        txt = txt.replace(/&#x0*?2A12;/g, '⨒');
        txt = txt.replace(/&#0*?10770;/g, '⨒');
        txt = txt.replace(/&rppolint;/g, '⨒');

        // "U+02A13", "LINE INTEGRATION WITH SEMICIRCULAR PATH AROUND POLE"
        txt = txt.replace(/&#x0*?2A13;/g, '⨓');
        txt = txt.replace(/&#0*?10771;/g, '⨓');
        txt = txt.replace(/&scpolint;/g, '⨓');

        // "U+02A14", "LINE INTEGRATION NOT INCLUDING THE POLE"
        txt = txt.replace(/&#x0*?2A14;/g, '⨔');
        txt = txt.replace(/&#0*?10772;/g, '⨔');
        txt = txt.replace(/&npolint;/g, '⨔');

        // "U+02A15", "INTEGRAL AROUND A POINT OPERATOR"
        txt = txt.replace(/&#x0*?2A15;/g, '⨕');
        txt = txt.replace(/&#0*?10773;/g, '⨕');
        txt = txt.replace(/&pointint;/g, '⨕');

        // "U+02A16", "QUATERNION INTEGRAL OPERATOR"
        txt = txt.replace(/&#x0*?2A16;/g, '⨖');
        txt = txt.replace(/&#0*?10774;/g, '⨖');
        txt = txt.replace(/&quatint;/g, '⨖');

        // "U+02A17", "INTEGRAL WITH LEFTWARDS ARROW WITH HOOK"
        txt = txt.replace(/&#x0*?2A17;/g, '⨗');
        txt = txt.replace(/&#0*?10775;/g, '⨗');
        txt = txt.replace(/&intlarhk;/g, '⨗');

        // "U+02A22", "PLUS SIGN WITH SMALL CIRCLE ABOVE"
        txt = txt.replace(/&#x0*?2A22;/g, '⨢');
        txt = txt.replace(/&#0*?10786;/g, '⨢');
        txt = txt.replace(/&pluscir;/g, '⨢');

        // "U+02A23", "PLUS SIGN WITH CIRCUMFLEX ACCENT ABOVE"
        txt = txt.replace(/&#x0*?2A23;/g, '⨣');
        txt = txt.replace(/&#0*?10787;/g, '⨣');
        txt = txt.replace(/&plusacir;/g, '⨣');

        // "U+02A24", "PLUS SIGN WITH TILDE ABOVE"
        txt = txt.replace(/&#x0*?2A24;/g, '⨤');
        txt = txt.replace(/&#0*?10788;/g, '⨤');
        txt = txt.replace(/&simplus;/g, '⨤');

        // "U+02A25", "PLUS SIGN WITH DOT BELOW"
        txt = txt.replace(/&#x0*?2A25;/g, '⨥');
        txt = txt.replace(/&#0*?10789;/g, '⨥');
        txt = txt.replace(/&plusdu;/g, '⨥');

        // "U+02A26", "PLUS SIGN WITH TILDE BELOW"
        txt = txt.replace(/&#x0*?2A26;/g, '⨦');
        txt = txt.replace(/&#0*?10790;/g, '⨦');
        txt = txt.replace(/&plussim;/g, '⨦');

        // "U+02A27", "PLUS SIGN WITH SUBSCRIPT TWO"
        txt = txt.replace(/&#x0*?2A27;/g, '⨧');
        txt = txt.replace(/&#0*?10791;/g, '⨧');
        txt = txt.replace(/&plustwo;/g, '⨧');

        // "U+02A29", "MINUS SIGN WITH COMMA ABOVE"
        txt = txt.replace(/&#x0*?2A29;/g, '⨩');
        txt = txt.replace(/&#0*?10793;/g, '⨩');
        txt = txt.replace(/&mcomma;/g, '⨩');

        // "U+02A2A", "MINUS SIGN WITH DOT BELOW"
        txt = txt.replace(/&#x0*?2A2A;/g, '⨪');
        txt = txt.replace(/&#0*?10794;/g, '⨪');
        txt = txt.replace(/&minusdu;/g, '⨪');

        // "U+02A2D", "PLUS SIGN IN LEFT HALF CIRCLE"
        txt = txt.replace(/&#x0*?2A2D;/g, '⨭');
        txt = txt.replace(/&#0*?10797;/g, '⨭');
        txt = txt.replace(/&loplus;/g, '⨭');

        // "U+02A2E", "PLUS SIGN IN RIGHT HALF CIRCLE"
        txt = txt.replace(/&#x0*?2A2E;/g, '⨮');
        txt = txt.replace(/&#0*?10798;/g, '⨮');
        txt = txt.replace(/&roplus;/g, '⨮');

        // "U+02A2F", "VECTOR OR CROSS PRODUCT"
        txt = txt.replace(/&#x0*?2A2F;/g, '⨯');
        txt = txt.replace(/&#0*?10799;/g, '⨯');
        txt = txt.replace(/&Cross;/g, '⨯');

        // "U+02A30", "MULTIPLICATION SIGN WITH DOT ABOVE"
        txt = txt.replace(/&#x0*?2A30;/g, '⨰');
        txt = txt.replace(/&#0*?10800;/g, '⨰');
        txt = txt.replace(/&timesd;/g, '⨰');

        // "U+02A31", "MULTIPLICATION SIGN WITH UNDERBAR"
        txt = txt.replace(/&#x0*?2A31;/g, '⨱');
        txt = txt.replace(/&#0*?10801;/g, '⨱');
        txt = txt.replace(/&timesbar;/g, '⨱');

        // "U+02A33", "SMASH PRODUCT"
        txt = txt.replace(/&#x0*?2A33;/g, '⨳');
        txt = txt.replace(/&#0*?10803;/g, '⨳');
        txt = txt.replace(/&smashp;/g, '⨳');

        // "U+02A34", "MULTIPLICATION SIGN IN LEFT HALF CIRCLE"
        txt = txt.replace(/&#x0*?2A34;/g, '⨴');
        txt = txt.replace(/&#0*?10804;/g, '⨴');
        txt = txt.replace(/&lotimes;/g, '⨴');

        // "U+02A35", "MULTIPLICATION SIGN IN RIGHT HALF CIRCLE"
        txt = txt.replace(/&#x0*?2A35;/g, '⨵');
        txt = txt.replace(/&#0*?10805;/g, '⨵');
        txt = txt.replace(/&rotimes;/g, '⨵');

        // "U+02A36", "CIRCLED MULTIPLICATION SIGN WITH CIRCUMFLEX ACCENT"
        txt = txt.replace(/&#x0*?2A36;/g, '⨶');
        txt = txt.replace(/&#0*?10806;/g, '⨶');
        txt = txt.replace(/&otimesas;/g, '⨶');

        // "U+02A37", "MULTIPLICATION SIGN IN DOUBLE CIRCLE"
        txt = txt.replace(/&#x0*?2A37;/g, '⨷');
        txt = txt.replace(/&#0*?10807;/g, '⨷');
        txt = txt.replace(/&Otimes;/g, '⨷');

        // "U+02A38", "CIRCLED DIVISION SIGN"
        txt = txt.replace(/&#x0*?2A38;/g, '⨸');
        txt = txt.replace(/&#0*?10808;/g, '⨸');
        txt = txt.replace(/&odiv;/g, '⨸');

        // "U+02A39", "PLUS SIGN IN TRIANGLE"
        txt = txt.replace(/&#x0*?2A39;/g, '⨹');
        txt = txt.replace(/&#0*?10809;/g, '⨹');
        txt = txt.replace(/&triplus;/g, '⨹');

        // "U+02A3A", "MINUS SIGN IN TRIANGLE"
        txt = txt.replace(/&#x0*?2A3A;/g, '⨺');
        txt = txt.replace(/&#0*?10810;/g, '⨺');
        txt = txt.replace(/&triminus;/g, '⨺');

        // "U+02A3B", "MULTIPLICATION SIGN IN TRIANGLE"
        txt = txt.replace(/&#x0*?2A3B;/g, '⨻');
        txt = txt.replace(/&#0*?10811;/g, '⨻');
        txt = txt.replace(/&tritime;/g, '⨻');

        // "U+02A3C", "INTERIOR PRODUCT"
        txt = txt.replace(/&#x0*?2A3C;/g, '⨼');
        txt = txt.replace(/&#0*?10812;/g, '⨼');
        txt = txt.replace(/&iprod;/g, '⨼');
        txt = txt.replace(/&intprod;/g, '⨼');

        // "U+02A3F", "AMALGAMATION OR COPRODUCT"
        txt = txt.replace(/&#x0*?2A3F;/g, '⨿');
        txt = txt.replace(/&#0*?10815;/g, '⨿');
        txt = txt.replace(/&amalg;/g, '⨿');

        // "U+02A40", "INTERSECTION WITH DOT"
        txt = txt.replace(/&#x0*?2A40;/g, '⩀');
        txt = txt.replace(/&#0*?10816;/g, '⩀');
        txt = txt.replace(/&capdot;/g, '⩀');

        // "U+02A42", "UNION WITH OVERBAR"
        txt = txt.replace(/&#x0*?2A42;/g, '⩂');
        txt = txt.replace(/&#0*?10818;/g, '⩂');
        txt = txt.replace(/&ncup;/g, '⩂');

        // "U+02A43", "INTERSECTION WITH OVERBAR"
        txt = txt.replace(/&#x0*?2A43;/g, '⩃');
        txt = txt.replace(/&#0*?10819;/g, '⩃');
        txt = txt.replace(/&ncap;/g, '⩃');

        // "U+02A44", "INTERSECTION WITH LOGICAL AND"
        txt = txt.replace(/&#x0*?2A44;/g, '⩄');
        txt = txt.replace(/&#0*?10820;/g, '⩄');
        txt = txt.replace(/&capand;/g, '⩄');

        // "U+02A45", "UNION WITH LOGICAL OR"
        txt = txt.replace(/&#x0*?2A45;/g, '⩅');
        txt = txt.replace(/&#0*?10821;/g, '⩅');
        txt = txt.replace(/&cupor;/g, '⩅');

        // "U+02A46", "UNION ABOVE INTERSECTION"
        txt = txt.replace(/&#x0*?2A46;/g, '⩆');
        txt = txt.replace(/&#0*?10822;/g, '⩆');
        txt = txt.replace(/&cupcap;/g, '⩆');

        // "U+02A47", "INTERSECTION ABOVE UNION"
        txt = txt.replace(/&#x0*?2A47;/g, '⩇');
        txt = txt.replace(/&#0*?10823;/g, '⩇');
        txt = txt.replace(/&capcup;/g, '⩇');

        // "U+02A48", "UNION ABOVE BAR ABOVE INTERSECTION"
        txt = txt.replace(/&#x0*?2A48;/g, '⩈');
        txt = txt.replace(/&#0*?10824;/g, '⩈');
        txt = txt.replace(/&cupbrcap;/g, '⩈');

        // "U+02A49", "INTERSECTION ABOVE BAR ABOVE UNION"
        txt = txt.replace(/&#x0*?2A49;/g, '⩉');
        txt = txt.replace(/&#0*?10825;/g, '⩉');
        txt = txt.replace(/&capbrcup;/g, '⩉');

        // "U+02A4A", "UNION BESIDE AND JOINED WITH UNION"
        txt = txt.replace(/&#x0*?2A4A;/g, '⩊');
        txt = txt.replace(/&#0*?10826;/g, '⩊');
        txt = txt.replace(/&cupcup;/g, '⩊');

        // "U+02A4B", "INTERSECTION BESIDE AND JOINED WITH INTERSECTION"
        txt = txt.replace(/&#x0*?2A4B;/g, '⩋');
        txt = txt.replace(/&#0*?10827;/g, '⩋');
        txt = txt.replace(/&capcap;/g, '⩋');

        // "U+02A4C", "CLOSED UNION WITH SERIFS"
        txt = txt.replace(/&#x0*?2A4C;/g, '⩌');
        txt = txt.replace(/&#0*?10828;/g, '⩌');
        txt = txt.replace(/&ccups;/g, '⩌');

        // "U+02A4D", "CLOSED INTERSECTION WITH SERIFS"
        txt = txt.replace(/&#x0*?2A4D;/g, '⩍');
        txt = txt.replace(/&#0*?10829;/g, '⩍');
        txt = txt.replace(/&ccaps;/g, '⩍');

        // "U+02A50", "CLOSED UNION WITH SERIFS AND SMASH PRODUCT"
        txt = txt.replace(/&#x0*?2A50;/g, '⩐');
        txt = txt.replace(/&#0*?10832;/g, '⩐');
        txt = txt.replace(/&ccupssm;/g, '⩐');

        // "U+02A53", "DOUBLE LOGICAL AND"
        txt = txt.replace(/&#x0*?2A53;/g, '⩓');
        txt = txt.replace(/&#0*?10835;/g, '⩓');
        txt = txt.replace(/&And;/g, '⩓');

        // "U+02A54", "DOUBLE LOGICAL OR"
        txt = txt.replace(/&#x0*?2A54;/g, '⩔');
        txt = txt.replace(/&#0*?10836;/g, '⩔');
        txt = txt.replace(/&Or;/g, '⩔');

        // "U+02A55", "TWO INTERSECTING LOGICAL AND"
        txt = txt.replace(/&#x0*?2A55;/g, '⩕');
        txt = txt.replace(/&#0*?10837;/g, '⩕');
        txt = txt.replace(/&andand;/g, '⩕');

        // "U+02A56", "TWO INTERSECTING LOGICAL OR"
        txt = txt.replace(/&#x0*?2A56;/g, '⩖');
        txt = txt.replace(/&#0*?10838;/g, '⩖');
        txt = txt.replace(/&oror;/g, '⩖');

        // "U+02A57", "SLOPING LARGE OR"
        txt = txt.replace(/&#x0*?2A57;/g, '⩗');
        txt = txt.replace(/&#0*?10839;/g, '⩗');
        txt = txt.replace(/&orslope;/g, '⩗');

        // "U+02A58", "SLOPING LARGE AND"
        txt = txt.replace(/&#x0*?2A58;/g, '⩘');
        txt = txt.replace(/&#0*?10840;/g, '⩘');
        txt = txt.replace(/&andslope;/g, '⩘');

        // "U+02A5A", "LOGICAL AND WITH MIDDLE STEM"
        txt = txt.replace(/&#x0*?2A5A;/g, '⩚');
        txt = txt.replace(/&#0*?10842;/g, '⩚');
        txt = txt.replace(/&andv;/g, '⩚');

        // "U+02A5B", "LOGICAL OR WITH MIDDLE STEM"
        txt = txt.replace(/&#x0*?2A5B;/g, '⩛');
        txt = txt.replace(/&#0*?10843;/g, '⩛');
        txt = txt.replace(/&orv;/g, '⩛');

        // "U+02A5C", "LOGICAL AND WITH HORIZONTAL DASH"
        txt = txt.replace(/&#x0*?2A5C;/g, '⩜');
        txt = txt.replace(/&#0*?10844;/g, '⩜');
        txt = txt.replace(/&andd;/g, '⩜');

        // "U+02A5D", "LOGICAL OR WITH HORIZONTAL DASH"
        txt = txt.replace(/&#x0*?2A5D;/g, '⩝');
        txt = txt.replace(/&#0*?10845;/g, '⩝');
        txt = txt.replace(/&ord;/g, '⩝');

        // "U+02A5F", "LOGICAL AND WITH UNDERBAR"
        txt = txt.replace(/&#x0*?2A5F;/g, '⩟');
        txt = txt.replace(/&#0*?10847;/g, '⩟');
        txt = txt.replace(/&wedbar;/g, '⩟');

        // "U+02A66", "EQUALS SIGN WITH DOT BELOW"
        txt = txt.replace(/&#x0*?2A66;/g, '⩦');
        txt = txt.replace(/&#0*?10854;/g, '⩦');
        txt = txt.replace(/&sdote;/g, '⩦');

        // "U+02A6A", "TILDE OPERATOR WITH DOT ABOVE"
        txt = txt.replace(/&#x0*?2A6A;/g, '⩪');
        txt = txt.replace(/&#0*?10858;/g, '⩪');
        txt = txt.replace(/&simdot;/g, '⩪');

        // "U+02A6D", "CONGRUENT WITH DOT ABOVE"
        txt = txt.replace(/&#x0*?2A6D;/g, '⩭');
        txt = txt.replace(/&#0*?10861;/g, '⩭');
        txt = txt.replace(/&congdot;/g, '⩭');

        // "U+02A6E", "EQUALS WITH ASTERISK"
        txt = txt.replace(/&#x0*?2A6E;/g, '⩮');
        txt = txt.replace(/&#0*?10862;/g, '⩮');
        txt = txt.replace(/&easter;/g, '⩮');

        // "U+02A6F", "ALMOST EQUAL TO WITH CIRCUMFLEX ACCENT"
        txt = txt.replace(/&#x0*?2A6F;/g, '⩯');
        txt = txt.replace(/&#0*?10863;/g, '⩯');
        txt = txt.replace(/&apacir;/g, '⩯');

        // "U+02A70", "APPROXIMATELY EQUAL OR EQUAL TO"
        txt = txt.replace(/&#x0*?2A70;/g, '⩰');
        txt = txt.replace(/&#0*?10864;/g, '⩰');
        txt = txt.replace(/&apE;/g, '⩰');

        // "U+02A71", "EQUALS SIGN ABOVE PLUS SIGN"
        txt = txt.replace(/&#x0*?2A71;/g, '⩱');
        txt = txt.replace(/&#0*?10865;/g, '⩱');
        txt = txt.replace(/&eplus;/g, '⩱');

        // "U+02A72", "PLUS SIGN ABOVE EQUALS SIGN"
        txt = txt.replace(/&#x0*?2A72;/g, '⩲');
        txt = txt.replace(/&#0*?10866;/g, '⩲');
        txt = txt.replace(/&pluse;/g, '⩲');

        // "U+02A73", "EQUALS SIGN ABOVE TILDE OPERATOR"
        txt = txt.replace(/&#x0*?2A73;/g, '⩳');
        txt = txt.replace(/&#0*?10867;/g, '⩳');
        txt = txt.replace(/&Esim;/g, '⩳');

        // "U+02A74", "DOUBLE COLON EQUAL"
        txt = txt.replace(/&#x0*?2A74;/g, '⩴');
        txt = txt.replace(/&#0*?10868;/g, '⩴');
        txt = txt.replace(/&Colone;/g, '⩴');

        // "U+02A75", "TWO CONSECUTIVE EQUALS SIGNS"
        txt = txt.replace(/&#x0*?2A75;/g, '⩵');
        txt = txt.replace(/&#0*?10869;/g, '⩵');
        txt = txt.replace(/&Equal;/g, '⩵');

        // "U+02A77", "EQUALS SIGN WITH TWO DOTS ABOVE AND TWO DOTS BELOW"
        txt = txt.replace(/&#x0*?2A77;/g, '⩷');
        txt = txt.replace(/&#0*?10871;/g, '⩷');
        txt = txt.replace(/&eDDot;/g, '⩷');
        txt = txt.replace(/&ddotseq;/g, '⩷');

        // "U+02A78", "EQUIVALENT WITH FOUR DOTS ABOVE"
        txt = txt.replace(/&#x0*?2A78;/g, '⩸');
        txt = txt.replace(/&#0*?10872;/g, '⩸');
        txt = txt.replace(/&equivDD;/g, '⩸');

        // "U+02A79", "LESS-THAN WITH CIRCLE INSIDE"
        txt = txt.replace(/&#x0*?2A79;/g, '⩹');
        txt = txt.replace(/&#0*?10873;/g, '⩹');
        txt = txt.replace(/&ltcir;/g, '⩹');

        // "U+02A7A", "GREATER-THAN WITH CIRCLE INSIDE"
        txt = txt.replace(/&#x0*?2A7A;/g, '⩺');
        txt = txt.replace(/&#0*?10874;/g, '⩺');
        txt = txt.replace(/&gtcir;/g, '⩺');

        // "U+02A7B", "LESS-THAN WITH QUESTION MARK ABOVE"
        txt = txt.replace(/&#x0*?2A7B;/g, '⩻');
        txt = txt.replace(/&#0*?10875;/g, '⩻');
        txt = txt.replace(/&ltquest;/g, '⩻');

        // "U+02A7C", "GREATER-THAN WITH QUESTION MARK ABOVE"
        txt = txt.replace(/&#x0*?2A7C;/g, '⩼');
        txt = txt.replace(/&#0*?10876;/g, '⩼');
        txt = txt.replace(/&gtquest;/g, '⩼');

        // "U+02A7D", "LESS-THAN OR SLANTED EQUAL TO"
        txt = txt.replace(/&#x0*?2A7D;/g, '⩽');
        txt = txt.replace(/&#0*?10877;/g, '⩽');
        txt = txt.replace(/&les;/g, '⩽');
        txt = txt.replace(/&LessSlantEqual;/g, '⩽');
        txt = txt.replace(/&leqslant;/g, '⩽');

        // "U+02A7E", "GREATER-THAN OR SLANTED EQUAL TO"
        txt = txt.replace(/&#x0*?2A7E;/g, '⩾');
        txt = txt.replace(/&#0*?10878;/g, '⩾');
        txt = txt.replace(/&ges;/g, '⩾');
        txt = txt.replace(/&GreaterSlantEqual;/g, '⩾');
        txt = txt.replace(/&geqslant;/g, '⩾');

        // "U+02A7F", "LESS-THAN OR SLANTED EQUAL TO WITH DOT INSIDE"
        txt = txt.replace(/&#x0*?2A7F;/g, '⩿');
        txt = txt.replace(/&#0*?10879;/g, '⩿');
        txt = txt.replace(/&lesdot;/g, '⩿');

        // "U+02A80", "GREATER-THAN OR SLANTED EQUAL TO WITH DOT INSIDE"
        txt = txt.replace(/&#x0*?2A80;/g, '⪀');
        txt = txt.replace(/&#0*?10880;/g, '⪀');
        txt = txt.replace(/&gesdot;/g, '⪀');

        // "U+02A81", "LESS-THAN OR SLANTED EQUAL TO WITH DOT ABOVE"
        txt = txt.replace(/&#x0*?2A81;/g, '⪁');
        txt = txt.replace(/&#0*?10881;/g, '⪁');
        txt = txt.replace(/&lesdoto;/g, '⪁');

        // "U+02A82", "GREATER-THAN OR SLANTED EQUAL TO WITH DOT ABOVE"
        txt = txt.replace(/&#x0*?2A82;/g, '⪂');
        txt = txt.replace(/&#0*?10882;/g, '⪂');
        txt = txt.replace(/&gesdoto;/g, '⪂');

        // "U+02A83", "LESS-THAN OR SLANTED EQUAL TO WITH DOT ABOVE RIGHT"
        txt = txt.replace(/&#x0*?2A83;/g, '⪃');
        txt = txt.replace(/&#0*?10883;/g, '⪃');
        txt = txt.replace(/&lesdotor;/g, '⪃');

        // "U+02A84", "GREATER-THAN OR SLANTED EQUAL TO WITH DOT ABOVE LEFT"
        txt = txt.replace(/&#x0*?2A84;/g, '⪄');
        txt = txt.replace(/&#0*?10884;/g, '⪄');
        txt = txt.replace(/&gesdotol;/g, '⪄');

        // "U+02A85", "LESS-THAN OR APPROXIMATE"
        txt = txt.replace(/&#x0*?2A85;/g, '⪅');
        txt = txt.replace(/&#0*?10885;/g, '⪅');
        txt = txt.replace(/&lap;/g, '⪅');
        txt = txt.replace(/&lessapprox;/g, '⪅');

        // "U+02A86", "GREATER-THAN OR APPROXIMATE"
        txt = txt.replace(/&#x0*?2A86;/g, '⪆');
        txt = txt.replace(/&#0*?10886;/g, '⪆');
        txt = txt.replace(/&gap;/g, '⪆');
        txt = txt.replace(/&gtrapprox;/g, '⪆');

        // "U+02A87", "LESS-THAN AND SINGLE-LINE NOT EQUAL TO"
        txt = txt.replace(/&#x0*?2A87;/g, '⪇');
        txt = txt.replace(/&#0*?10887;/g, '⪇');
        txt = txt.replace(/&lne;/g, '⪇');
        txt = txt.replace(/&lneq;/g, '⪇');

        // "U+02A88", "GREATER-THAN AND SINGLE-LINE NOT EQUAL TO"
        txt = txt.replace(/&#x0*?2A88;/g, '⪈');
        txt = txt.replace(/&#0*?10888;/g, '⪈');
        txt = txt.replace(/&gne;/g, '⪈');
        txt = txt.replace(/&gneq;/g, '⪈');

        // "U+02A89", "LESS-THAN AND NOT APPROXIMATE"
        txt = txt.replace(/&#x0*?2A89;/g, '⪉');
        txt = txt.replace(/&#0*?10889;/g, '⪉');
        txt = txt.replace(/&lnap;/g, '⪉');
        txt = txt.replace(/&lnapprox;/g, '⪉');

        // "U+02A8A", "GREATER-THAN AND NOT APPROXIMATE"
        txt = txt.replace(/&#x0*?2A8A;/g, '⪊');
        txt = txt.replace(/&#0*?10890;/g, '⪊');
        txt = txt.replace(/&gnap;/g, '⪊');
        txt = txt.replace(/&gnapprox;/g, '⪊');

        // "U+02A8B", "LESS-THAN ABOVE DOUBLE-LINE EQUAL ABOVE GREATER-THAN"
        txt = txt.replace(/&#x0*?2A8B;/g, '⪋');
        txt = txt.replace(/&#0*?10891;/g, '⪋');
        txt = txt.replace(/&lEg;/g, '⪋');
        txt = txt.replace(/&lesseqqgtr;/g, '⪋');

        // "U+02A8C", "GREATER-THAN ABOVE DOUBLE-LINE EQUAL ABOVE LESS-THAN"
        txt = txt.replace(/&#x0*?2A8C;/g, '⪌');
        txt = txt.replace(/&#0*?10892;/g, '⪌');
        txt = txt.replace(/&gEl;/g, '⪌');
        txt = txt.replace(/&gtreqqless;/g, '⪌');

        // "U+02A8D", "LESS-THAN ABOVE SIMILAR OR EQUAL"
        txt = txt.replace(/&#x0*?2A8D;/g, '⪍');
        txt = txt.replace(/&#0*?10893;/g, '⪍');
        txt = txt.replace(/&lsime;/g, '⪍');

        // "U+02A8E", "GREATER-THAN ABOVE SIMILAR OR EQUAL"
        txt = txt.replace(/&#x0*?2A8E;/g, '⪎');
        txt = txt.replace(/&#0*?10894;/g, '⪎');
        txt = txt.replace(/&gsime;/g, '⪎');

        // "U+02A8F", "LESS-THAN ABOVE SIMILAR ABOVE GREATER-THAN"
        txt = txt.replace(/&#x0*?2A8F;/g, '⪏');
        txt = txt.replace(/&#0*?10895;/g, '⪏');
        txt = txt.replace(/&lsimg;/g, '⪏');

        // "U+02A90", "GREATER-THAN ABOVE SIMILAR ABOVE LESS-THAN"
        txt = txt.replace(/&#x0*?2A90;/g, '⪐');
        txt = txt.replace(/&#0*?10896;/g, '⪐');
        txt = txt.replace(/&gsiml;/g, '⪐');

        // "U+02A91", "LESS-THAN ABOVE GREATER-THAN ABOVE DOUBLE-LINE EQUAL"
        txt = txt.replace(/&#x0*?2A91;/g, '⪑');
        txt = txt.replace(/&#0*?10897;/g, '⪑');
        txt = txt.replace(/&lgE;/g, '⪑');

        // "U+02A92", "GREATER-THAN ABOVE LESS-THAN ABOVE DOUBLE-LINE EQUAL"
        txt = txt.replace(/&#x0*?2A92;/g, '⪒');
        txt = txt.replace(/&#0*?10898;/g, '⪒');
        txt = txt.replace(/&glE;/g, '⪒');

        // "U+02A93", "LESS-THAN ABOVE SLANTED EQUAL ABOVE GREATER-THAN ABOVE SLANTED EQUAL"
        txt = txt.replace(/&#x0*?2A93;/g, '⪓');
        txt = txt.replace(/&#0*?10899;/g, '⪓');
        txt = txt.replace(/&lesges;/g, '⪓');

        // "U+02A94", "GREATER-THAN ABOVE SLANTED EQUAL ABOVE LESS-THAN ABOVE SLANTED EQUAL"
        txt = txt.replace(/&#x0*?2A94;/g, '⪔');
        txt = txt.replace(/&#0*?10900;/g, '⪔');
        txt = txt.replace(/&gesles;/g, '⪔');

        // "U+02A95", "SLANTED EQUAL TO OR LESS-THAN"
        txt = txt.replace(/&#x0*?2A95;/g, '⪕');
        txt = txt.replace(/&#0*?10901;/g, '⪕');
        txt = txt.replace(/&els;/g, '⪕');
        txt = txt.replace(/&eqslantless;/g, '⪕');

        // "U+02A96", "SLANTED EQUAL TO OR GREATER-THAN"
        txt = txt.replace(/&#x0*?2A96;/g, '⪖');
        txt = txt.replace(/&#0*?10902;/g, '⪖');
        txt = txt.replace(/&egs;/g, '⪖');
        txt = txt.replace(/&eqslantgtr;/g, '⪖');

        // "U+02A97", "SLANTED EQUAL TO OR LESS-THAN WITH DOT INSIDE"
        txt = txt.replace(/&#x0*?2A97;/g, '⪗');
        txt = txt.replace(/&#0*?10903;/g, '⪗');
        txt = txt.replace(/&elsdot;/g, '⪗');

        // "U+02A98", "SLANTED EQUAL TO OR GREATER-THAN WITH DOT INSIDE"
        txt = txt.replace(/&#x0*?2A98;/g, '⪘');
        txt = txt.replace(/&#0*?10904;/g, '⪘');
        txt = txt.replace(/&egsdot;/g, '⪘');

        // "U+02A99", "DOUBLE-LINE EQUAL TO OR LESS-THAN"
        txt = txt.replace(/&#x0*?2A99;/g, '⪙');
        txt = txt.replace(/&#0*?10905;/g, '⪙');
        txt = txt.replace(/&el;/g, '⪙');

        // "U+02A9A", "DOUBLE-LINE EQUAL TO OR GREATER-THAN"
        txt = txt.replace(/&#x0*?2A9A;/g, '⪚');
        txt = txt.replace(/&#0*?10906;/g, '⪚');
        txt = txt.replace(/&eg;/g, '⪚');

        // "U+02A9D", "SIMILAR OR LESS-THAN"
        txt = txt.replace(/&#x0*?2A9D;/g, '⪝');
        txt = txt.replace(/&#0*?10909;/g, '⪝');
        txt = txt.replace(/&siml;/g, '⪝');

        // "U+02A9E", "SIMILAR OR GREATER-THAN"
        txt = txt.replace(/&#x0*?2A9E;/g, '⪞');
        txt = txt.replace(/&#0*?10910;/g, '⪞');
        txt = txt.replace(/&simg;/g, '⪞');

        // "U+02A9F", "SIMILAR ABOVE LESS-THAN ABOVE EQUALS SIGN"
        txt = txt.replace(/&#x0*?2A9F;/g, '⪟');
        txt = txt.replace(/&#0*?10911;/g, '⪟');
        txt = txt.replace(/&simlE;/g, '⪟');

        // "U+02AA0", "SIMILAR ABOVE GREATER-THAN ABOVE EQUALS SIGN"
        txt = txt.replace(/&#x0*?2AA0;/g, '⪠');
        txt = txt.replace(/&#0*?10912;/g, '⪠');
        txt = txt.replace(/&simgE;/g, '⪠');

        // "U+02AA1", "DOUBLE NESTED LESS-THAN"
        txt = txt.replace(/&#x0*?2AA1;/g, '⪡');
        txt = txt.replace(/&#0*?10913;/g, '⪡');
        txt = txt.replace(/&LessLess;/g, '⪡');

        // "U+02AA2", "DOUBLE NESTED GREATER-THAN"
        txt = txt.replace(/&#x0*?2AA2;/g, '⪢');
        txt = txt.replace(/&#0*?10914;/g, '⪢');
        txt = txt.replace(/&GreaterGreater;/g, '⪢');

        // "U+02AA4", "GREATER-THAN OVERLAPPING LESS-THAN"
        txt = txt.replace(/&#x0*?2AA4;/g, '⪤');
        txt = txt.replace(/&#0*?10916;/g, '⪤');
        txt = txt.replace(/&glj;/g, '⪤');

        // "U+02AA5", "GREATER-THAN BESIDE LESS-THAN"
        txt = txt.replace(/&#x0*?2AA5;/g, '⪥');
        txt = txt.replace(/&#0*?10917;/g, '⪥');
        txt = txt.replace(/&gla;/g, '⪥');

        // "U+02AA6", "LESS-THAN CLOSED BY CURVE"
        txt = txt.replace(/&#x0*?2AA6;/g, '⪦');
        txt = txt.replace(/&#0*?10918;/g, '⪦');
        txt = txt.replace(/&ltcc;/g, '⪦');

        // "U+02AA7", "GREATER-THAN CLOSED BY CURVE"
        txt = txt.replace(/&#x0*?2AA7;/g, '⪧');
        txt = txt.replace(/&#0*?10919;/g, '⪧');
        txt = txt.replace(/&gtcc;/g, '⪧');

        // "U+02AA8", "LESS-THAN CLOSED BY CURVE ABOVE SLANTED EQUAL"
        txt = txt.replace(/&#x0*?2AA8;/g, '⪨');
        txt = txt.replace(/&#0*?10920;/g, '⪨');
        txt = txt.replace(/&lescc;/g, '⪨');

        // "U+02AA9", "GREATER-THAN CLOSED BY CURVE ABOVE SLANTED EQUAL"
        txt = txt.replace(/&#x0*?2AA9;/g, '⪩');
        txt = txt.replace(/&#0*?10921;/g, '⪩');
        txt = txt.replace(/&gescc;/g, '⪩');

        // "U+02AAA", "SMALLER THAN"
        txt = txt.replace(/&#x0*?2AAA;/g, '⪪');
        txt = txt.replace(/&#0*?10922;/g, '⪪');
        txt = txt.replace(/&smt;/g, '⪪');

        // "U+02AAB", "LARGER THAN"
        txt = txt.replace(/&#x0*?2AAB;/g, '⪫');
        txt = txt.replace(/&#0*?10923;/g, '⪫');
        txt = txt.replace(/&lat;/g, '⪫');

        // "U+02AAC", "SMALLER THAN OR EQUAL TO"
        txt = txt.replace(/&#x0*?2AAC;/g, '⪬');
        txt = txt.replace(/&#0*?10924;/g, '⪬');
        txt = txt.replace(/&smte;/g, '⪬');

        // "U+02AAD", "LARGER THAN OR EQUAL TO"
        txt = txt.replace(/&#x0*?2AAD;/g, '⪭');
        txt = txt.replace(/&#0*?10925;/g, '⪭');
        txt = txt.replace(/&late;/g, '⪭');

        // "U+02AAE", "EQUALS SIGN WITH BUMPY ABOVE"
        txt = txt.replace(/&#x0*?2AAE;/g, '⪮');
        txt = txt.replace(/&#0*?10926;/g, '⪮');
        txt = txt.replace(/&bumpE;/g, '⪮');

        // "U+02AAF", "PRECEDES ABOVE SINGLE-LINE EQUALS SIGN"
        txt = txt.replace(/&#x0*?2AAF;/g, '⪯');
        txt = txt.replace(/&#0*?10927;/g, '⪯');
        txt = txt.replace(/&pre;/g, '⪯');
        txt = txt.replace(/&preceq;/g, '⪯');
        txt = txt.replace(/&PrecedesEqual;/g, '⪯');

        // "U+02AB0", "SUCCEEDS ABOVE SINGLE-LINE EQUALS SIGN"
        txt = txt.replace(/&#x0*?2AB0;/g, '⪰');
        txt = txt.replace(/&#0*?10928;/g, '⪰');
        txt = txt.replace(/&sce;/g, '⪰');
        txt = txt.replace(/&succeq;/g, '⪰');
        txt = txt.replace(/&SucceedsEqual;/g, '⪰');

        // "U+02AB3", "PRECEDES ABOVE EQUALS SIGN"
        txt = txt.replace(/&#x0*?2AB3;/g, '⪳');
        txt = txt.replace(/&#0*?10931;/g, '⪳');
        txt = txt.replace(/&prE;/g, '⪳');

        // "U+02AB4", "SUCCEEDS ABOVE EQUALS SIGN"
        txt = txt.replace(/&#x0*?2AB4;/g, '⪴');
        txt = txt.replace(/&#0*?10932;/g, '⪴');
        txt = txt.replace(/&scE;/g, '⪴');

        // "U+02AB5", "PRECEDES ABOVE NOT EQUAL TO"
        txt = txt.replace(/&#x0*?2AB5;/g, '⪵');
        txt = txt.replace(/&#0*?10933;/g, '⪵');
        txt = txt.replace(/&prnE;/g, '⪵');
        txt = txt.replace(/&precneqq;/g, '⪵');

        // "U+02AB6", "SUCCEEDS ABOVE NOT EQUAL TO"
        txt = txt.replace(/&#x0*?2AB6;/g, '⪶');
        txt = txt.replace(/&#0*?10934;/g, '⪶');
        txt = txt.replace(/&scnE;/g, '⪶');
        txt = txt.replace(/&succneqq;/g, '⪶');

        // "U+02AB7", "PRECEDES ABOVE ALMOST EQUAL TO"
        txt = txt.replace(/&#x0*?2AB7;/g, '⪷');
        txt = txt.replace(/&#0*?10935;/g, '⪷');
        txt = txt.replace(/&prap;/g, '⪷');
        txt = txt.replace(/&precapprox;/g, '⪷');

        // "U+02AB8", "SUCCEEDS ABOVE ALMOST EQUAL TO"
        txt = txt.replace(/&#x0*?2AB8;/g, '⪸');
        txt = txt.replace(/&#0*?10936;/g, '⪸');
        txt = txt.replace(/&scap;/g, '⪸');
        txt = txt.replace(/&succapprox;/g, '⪸');

        // "U+02AB9", "PRECEDES ABOVE NOT ALMOST EQUAL TO"
        txt = txt.replace(/&#x0*?2AB9;/g, '⪹');
        txt = txt.replace(/&#0*?10937;/g, '⪹');
        txt = txt.replace(/&prnap;/g, '⪹');
        txt = txt.replace(/&precnapprox;/g, '⪹');

        // "U+02ABA", "SUCCEEDS ABOVE NOT ALMOST EQUAL TO"
        txt = txt.replace(/&#x0*?2ABA;/g, '⪺');
        txt = txt.replace(/&#0*?10938;/g, '⪺');
        txt = txt.replace(/&scnap;/g, '⪺');
        txt = txt.replace(/&succnapprox;/g, '⪺');

        // "U+02ABB", "DOUBLE PRECEDES"
        txt = txt.replace(/&#x0*?2ABB;/g, '⪻');
        txt = txt.replace(/&#0*?10939;/g, '⪻');
        txt = txt.replace(/&Pr;/g, '⪻');

        // "U+02ABC", "DOUBLE SUCCEEDS"
        txt = txt.replace(/&#x0*?2ABC;/g, '⪼');
        txt = txt.replace(/&#0*?10940;/g, '⪼');
        txt = txt.replace(/&Sc;/g, '⪼');

        // "U+02ABD", "SUBSET WITH DOT"
        txt = txt.replace(/&#x0*?2ABD;/g, '⪽');
        txt = txt.replace(/&#0*?10941;/g, '⪽');
        txt = txt.replace(/&subdot;/g, '⪽');

        // "U+02ABE", "SUPERSET WITH DOT"
        txt = txt.replace(/&#x0*?2ABE;/g, '⪾');
        txt = txt.replace(/&#0*?10942;/g, '⪾');
        txt = txt.replace(/&supdot;/g, '⪾');

        // "U+02ABF", "SUBSET WITH PLUS SIGN BELOW"
        txt = txt.replace(/&#x0*?2ABF;/g, '⪿');
        txt = txt.replace(/&#0*?10943;/g, '⪿');
        txt = txt.replace(/&subplus;/g, '⪿');

        // "U+02AC0", "SUPERSET WITH PLUS SIGN BELOW"
        txt = txt.replace(/&#x0*?2AC0;/g, '⫀');
        txt = txt.replace(/&#0*?10944;/g, '⫀');
        txt = txt.replace(/&supplus;/g, '⫀');

        // "U+02AC1", "SUBSET WITH MULTIPLICATION SIGN BELOW"
        txt = txt.replace(/&#x0*?2AC1;/g, '⫁');
        txt = txt.replace(/&#0*?10945;/g, '⫁');
        txt = txt.replace(/&submult;/g, '⫁');

        // "U+02AC2", "SUPERSET WITH MULTIPLICATION SIGN BELOW"
        txt = txt.replace(/&#x0*?2AC2;/g, '⫂');
        txt = txt.replace(/&#0*?10946;/g, '⫂');
        txt = txt.replace(/&supmult;/g, '⫂');

        // "U+02AC3", "SUBSET OF OR EQUAL TO WITH DOT ABOVE"
        txt = txt.replace(/&#x0*?2AC3;/g, '⫃');
        txt = txt.replace(/&#0*?10947;/g, '⫃');
        txt = txt.replace(/&subedot;/g, '⫃');

        // "U+02AC4", "SUPERSET OF OR EQUAL TO WITH DOT ABOVE"
        txt = txt.replace(/&#x0*?2AC4;/g, '⫄');
        txt = txt.replace(/&#0*?10948;/g, '⫄');
        txt = txt.replace(/&supedot;/g, '⫄');

        // "U+02AC5", "SUBSET OF ABOVE EQUALS SIGN"
        txt = txt.replace(/&#x0*?2AC5;/g, '⫅');
        txt = txt.replace(/&#0*?10949;/g, '⫅');
        txt = txt.replace(/&subE;/g, '⫅');
        txt = txt.replace(/&subseteqq;/g, '⫅');

        // "U+02AC6", "SUPERSET OF ABOVE EQUALS SIGN"
        txt = txt.replace(/&#x0*?2AC6;/g, '⫆');
        txt = txt.replace(/&#0*?10950;/g, '⫆');
        txt = txt.replace(/&supE;/g, '⫆');
        txt = txt.replace(/&supseteqq;/g, '⫆');

        // "U+02AC7", "SUBSET OF ABOVE TILDE OPERATOR"
        txt = txt.replace(/&#x0*?2AC7;/g, '⫇');
        txt = txt.replace(/&#0*?10951;/g, '⫇');
        txt = txt.replace(/&subsim;/g, '⫇');

        // "U+02AC8", "SUPERSET OF ABOVE TILDE OPERATOR"
        txt = txt.replace(/&#x0*?2AC8;/g, '⫈');
        txt = txt.replace(/&#0*?10952;/g, '⫈');
        txt = txt.replace(/&supsim;/g, '⫈');

        // "U+02ACB", "SUBSET OF ABOVE NOT EQUAL TO"
        txt = txt.replace(/&#x0*?2ACB;/g, '⫋');
        txt = txt.replace(/&#0*?10955;/g, '⫋');
        txt = txt.replace(/&subnE;/g, '⫋');
        txt = txt.replace(/&subsetneqq;/g, '⫋');

        // "U+02ACC", "SUPERSET OF ABOVE NOT EQUAL TO"
        txt = txt.replace(/&#x0*?2ACC;/g, '⫌');
        txt = txt.replace(/&#0*?10956;/g, '⫌');
        txt = txt.replace(/&supnE;/g, '⫌');
        txt = txt.replace(/&supsetneqq;/g, '⫌');

        // "U+02ACF", "CLOSED SUBSET"
        txt = txt.replace(/&#x0*?2ACF;/g, '⫏');
        txt = txt.replace(/&#0*?10959;/g, '⫏');
        txt = txt.replace(/&csub;/g, '⫏');

        // "U+02AD0", "CLOSED SUPERSET"
        txt = txt.replace(/&#x0*?2AD0;/g, '⫐');
        txt = txt.replace(/&#0*?10960;/g, '⫐');
        txt = txt.replace(/&csup;/g, '⫐');

        // "U+02AD1", "CLOSED SUBSET OR EQUAL TO"
        txt = txt.replace(/&#x0*?2AD1;/g, '⫑');
        txt = txt.replace(/&#0*?10961;/g, '⫑');
        txt = txt.replace(/&csube;/g, '⫑');

        // "U+02AD2", "CLOSED SUPERSET OR EQUAL TO"
        txt = txt.replace(/&#x0*?2AD2;/g, '⫒');
        txt = txt.replace(/&#0*?10962;/g, '⫒');
        txt = txt.replace(/&csupe;/g, '⫒');

        // "U+02AD3", "SUBSET ABOVE SUPERSET"
        txt = txt.replace(/&#x0*?2AD3;/g, '⫓');
        txt = txt.replace(/&#0*?10963;/g, '⫓');
        txt = txt.replace(/&subsup;/g, '⫓');

        // "U+02AD4", "SUPERSET ABOVE SUBSET"
        txt = txt.replace(/&#x0*?2AD4;/g, '⫔');
        txt = txt.replace(/&#0*?10964;/g, '⫔');
        txt = txt.replace(/&supsub;/g, '⫔');

        // "U+02AD5", "SUBSET ABOVE SUBSET"
        txt = txt.replace(/&#x0*?2AD5;/g, '⫕');
        txt = txt.replace(/&#0*?10965;/g, '⫕');
        txt = txt.replace(/&subsub;/g, '⫕');

        // "U+02AD6", "SUPERSET ABOVE SUPERSET"
        txt = txt.replace(/&#x0*?2AD6;/g, '⫖');
        txt = txt.replace(/&#0*?10966;/g, '⫖');
        txt = txt.replace(/&supsup;/g, '⫖');

        // "U+02AD7", "SUPERSET BESIDE SUBSET"
        txt = txt.replace(/&#x0*?2AD7;/g, '⫗');
        txt = txt.replace(/&#0*?10967;/g, '⫗');
        txt = txt.replace(/&suphsub;/g, '⫗');

        // "U+02AD8", "SUPERSET BESIDE AND JOINED BY DASH WITH SUBSET"
        txt = txt.replace(/&#x0*?2AD8;/g, '⫘');
        txt = txt.replace(/&#0*?10968;/g, '⫘');
        txt = txt.replace(/&supdsub;/g, '⫘');

        // "U+02AD9", "ELEMENT OF OPENING DOWNWARDS"
        txt = txt.replace(/&#x0*?2AD9;/g, '⫙');
        txt = txt.replace(/&#0*?10969;/g, '⫙');
        txt = txt.replace(/&forkv;/g, '⫙');

        // "U+02ADA", "PITCHFORK WITH TEE TOP"
        txt = txt.replace(/&#x0*?2ADA;/g, '⫚');
        txt = txt.replace(/&#0*?10970;/g, '⫚');
        txt = txt.replace(/&topfork;/g, '⫚');

        // "U+02ADB", "TRANSVERSAL INTERSECTION"
        txt = txt.replace(/&#x0*?2ADB;/g, '⫛');
        txt = txt.replace(/&#0*?10971;/g, '⫛');
        txt = txt.replace(/&mlcp;/g, '⫛');

        // "U+02AE4", "VERTICAL BAR DOUBLE LEFT TURNSTILE"
        txt = txt.replace(/&#x0*?2AE4;/g, '⫤');
        txt = txt.replace(/&#0*?10980;/g, '⫤');
        txt = txt.replace(/&Dashv;/g, '⫤');
        txt = txt.replace(/&DoubleLeftTee;/g, '⫤');

        // "U+02AE6", "LONG DASH FROM LEFT MEMBER OF DOUBLE VERTICAL"
        txt = txt.replace(/&#x0*?2AE6;/g, '⫦');
        txt = txt.replace(/&#0*?10982;/g, '⫦');
        txt = txt.replace(/&Vdashl;/g, '⫦');

        // "U+02AE7", "SHORT DOWN TACK WITH OVERBAR"
        txt = txt.replace(/&#x0*?2AE7;/g, '⫧');
        txt = txt.replace(/&#0*?10983;/g, '⫧');
        txt = txt.replace(/&Barv;/g, '⫧');

        // "U+02AE8", "SHORT UP TACK WITH UNDERBAR"
        txt = txt.replace(/&#x0*?2AE8;/g, '⫨');
        txt = txt.replace(/&#0*?10984;/g, '⫨');
        txt = txt.replace(/&vBar;/g, '⫨');

        // "U+02AE9", "SHORT UP TACK ABOVE SHORT DOWN TACK"
        txt = txt.replace(/&#x0*?2AE9;/g, '⫩');
        txt = txt.replace(/&#0*?10985;/g, '⫩');
        txt = txt.replace(/&vBarv;/g, '⫩');

        // "U+02AEB", "DOUBLE UP TACK"
        txt = txt.replace(/&#x0*?2AEB;/g, '⫫');
        txt = txt.replace(/&#0*?10987;/g, '⫫');
        txt = txt.replace(/&Vbar;/g, '⫫');

        // "U+02AEC", "DOUBLE STROKE NOT SIGN"
        txt = txt.replace(/&#x0*?2AEC;/g, '⫬');
        txt = txt.replace(/&#0*?10988;/g, '⫬');
        txt = txt.replace(/&Not;/g, '⫬');

        // "U+02AED", "REVERSED DOUBLE STROKE NOT SIGN"
        txt = txt.replace(/&#x0*?2AED;/g, '⫭');
        txt = txt.replace(/&#0*?10989;/g, '⫭');
        txt = txt.replace(/&bNot;/g, '⫭');

        // "U+02AEE", "DOES NOT DIVIDE WITH REVERSED NEGATION SLASH"
        txt = txt.replace(/&#x0*?2AEE;/g, '⫮');
        txt = txt.replace(/&#0*?10990;/g, '⫮');
        txt = txt.replace(/&rnmid;/g, '⫮');

        // "U+02AEF", "VERTICAL LINE WITH CIRCLE ABOVE"
        txt = txt.replace(/&#x0*?2AEF;/g, '⫯');
        txt = txt.replace(/&#0*?10991;/g, '⫯');
        txt = txt.replace(/&cirmid;/g, '⫯');

        // "U+02AF0", "VERTICAL LINE WITH CIRCLE BELOW"
        txt = txt.replace(/&#x0*?2AF0;/g, '⫰');
        txt = txt.replace(/&#0*?10992;/g, '⫰');
        txt = txt.replace(/&midcir;/g, '⫰');

        // "U+02AF1", "DOWN TACK WITH CIRCLE BELOW"
        txt = txt.replace(/&#x0*?2AF1;/g, '⫱');
        txt = txt.replace(/&#0*?10993;/g, '⫱');
        txt = txt.replace(/&topcir;/g, '⫱');

        // "U+02AF2", "PARALLEL WITH HORIZONTAL STROKE"
        txt = txt.replace(/&#x0*?2AF2;/g, '⫲');
        txt = txt.replace(/&#0*?10994;/g, '⫲');
        txt = txt.replace(/&nhpar;/g, '⫲');

        // "U+02AF3", "PARALLEL WITH TILDE OPERATOR"
        txt = txt.replace(/&#x0*?2AF3;/g, '⫳');
        txt = txt.replace(/&#0*?10995;/g, '⫳');
        txt = txt.replace(/&parsim;/g, '⫳');

        // "U+02AFD", "DOUBLE SOLIDUS OPERATOR"
        txt = txt.replace(/&#x0*?2AFD;/g, '⫽');
        txt = txt.replace(/&#0*?11005;/g, '⫽');
        txt = txt.replace(/&parsl;/g, '⫽');

        // "U+0FB00", "LATIN SMALL LIGATURE FF"
        txt = txt.replace(/&#x0*?FB00;/g, 'ﬀ');
        txt = txt.replace(/&#0*?64256;/g, 'ﬀ');
        txt = txt.replace(/&fflig;/g, 'ﬀ');

        // "U+0FB01", "LATIN SMALL LIGATURE FI"
        txt = txt.replace(/&#x0*?FB01;/g, 'ﬁ');
        txt = txt.replace(/&#0*?64257;/g, 'ﬁ');
        txt = txt.replace(/&filig;/g, 'ﬁ');

        // "U+0FB02", "LATIN SMALL LIGATURE FL"
        txt = txt.replace(/&#x0*?FB02;/g, 'ﬂ');
        txt = txt.replace(/&#0*?64258;/g, 'ﬂ');
        txt = txt.replace(/&fllig;/g, 'ﬂ');

        // "U+0FB03", "LATIN SMALL LIGATURE FFI"
        txt = txt.replace(/&#x0*?FB03;/g, 'ﬃ');
        txt = txt.replace(/&#0*?64259;/g, 'ﬃ');
        txt = txt.replace(/&ffilig;/g, 'ﬃ');

        // "U+0FB04", "LATIN SMALL LIGATURE FFL"
        txt = txt.replace(/&#x0*?FB04;/g, 'ﬄ');
        txt = txt.replace(/&#0*?64260;/g, 'ﬄ');
        txt = txt.replace(/&ffllig;/g, 'ﬄ');

        // "U+1D49C", "MATHEMATICAL SCRIPT CAPITAL A"
        txt = txt.replace(/&#x0*?1D49C;/g, '𝒜');
        txt = txt.replace(/&#0*?119964;/g, '𝒜');
        txt = txt.replace(/&Ascr;/g, '𝒜');

        // "U+1D49E", "MATHEMATICAL SCRIPT CAPITAL C"
        txt = txt.replace(/&#x0*?1D49E;/g, '𝒞');
        txt = txt.replace(/&#0*?119966;/g, '𝒞');
        txt = txt.replace(/&Cscr;/g, '𝒞');

        // "U+1D49F", "MATHEMATICAL SCRIPT CAPITAL D"
        txt = txt.replace(/&#x0*?1D49F;/g, '𝒟');
        txt = txt.replace(/&#0*?119967;/g, '𝒟');
        txt = txt.replace(/&Dscr;/g, '𝒟');

        // "U+1D4A2", "MATHEMATICAL SCRIPT CAPITAL G"
        txt = txt.replace(/&#x0*?1D4A2;/g, '𝒢');
        txt = txt.replace(/&#0*?119970;/g, '𝒢');
        txt = txt.replace(/&Gscr;/g, '𝒢');

        // "U+1D4A5", "MATHEMATICAL SCRIPT CAPITAL J"
        txt = txt.replace(/&#x0*?1D4A5;/g, '𝒥');
        txt = txt.replace(/&#0*?119973;/g, '𝒥');
        txt = txt.replace(/&Jscr;/g, '𝒥');

        // "U+1D4A6", "MATHEMATICAL SCRIPT CAPITAL K"
        txt = txt.replace(/&#x0*?1D4A6;/g, '𝒦');
        txt = txt.replace(/&#0*?119974;/g, '𝒦');
        txt = txt.replace(/&Kscr;/g, '𝒦');

        // "U+1D4A9", "MATHEMATICAL SCRIPT CAPITAL N"
        txt = txt.replace(/&#x0*?1D4A9;/g, '𝒩');
        txt = txt.replace(/&#0*?119977;/g, '𝒩');
        txt = txt.replace(/&Nscr;/g, '𝒩');

        // "U+1D4AA", "MATHEMATICAL SCRIPT CAPITAL O"
        txt = txt.replace(/&#x0*?1D4AA;/g, '𝒪');
        txt = txt.replace(/&#0*?119978;/g, '𝒪');
        txt = txt.replace(/&Oscr;/g, '𝒪');

        // "U+1D4AB", "MATHEMATICAL SCRIPT CAPITAL P"
        txt = txt.replace(/&#x0*?1D4AB;/g, '𝒫');
        txt = txt.replace(/&#0*?119979;/g, '𝒫');
        txt = txt.replace(/&Pscr;/g, '𝒫');

        // "U+1D4AC", "MATHEMATICAL SCRIPT CAPITAL Q"
        txt = txt.replace(/&#x0*?1D4AC;/g, '𝒬');
        txt = txt.replace(/&#0*?119980;/g, '𝒬');
        txt = txt.replace(/&Qscr;/g, '𝒬');

        // "U+1D4AE", "MATHEMATICAL SCRIPT CAPITAL S"
        txt = txt.replace(/&#x0*?1D4AE;/g, '𝒮');
        txt = txt.replace(/&#0*?119982;/g, '𝒮');
        txt = txt.replace(/&Sscr;/g, '𝒮');

        // "U+1D4AF", "MATHEMATICAL SCRIPT CAPITAL T"
        txt = txt.replace(/&#x0*?1D4AF;/g, '𝒯');
        txt = txt.replace(/&#0*?119983;/g, '𝒯');
        txt = txt.replace(/&Tscr;/g, '𝒯');

        // "U+1D4B0", "MATHEMATICAL SCRIPT CAPITAL U"
        txt = txt.replace(/&#x0*?1D4B0;/g, '𝒰');
        txt = txt.replace(/&#0*?119984;/g, '𝒰');
        txt = txt.replace(/&Uscr;/g, '𝒰');

        // "U+1D4B1", "MATHEMATICAL SCRIPT CAPITAL V"
        txt = txt.replace(/&#x0*?1D4B1;/g, '𝒱');
        txt = txt.replace(/&#0*?119985;/g, '𝒱');
        txt = txt.replace(/&Vscr;/g, '𝒱');

        // "U+1D4B2", "MATHEMATICAL SCRIPT CAPITAL W"
        txt = txt.replace(/&#x0*?1D4B2;/g, '𝒲');
        txt = txt.replace(/&#0*?119986;/g, '𝒲');
        txt = txt.replace(/&Wscr;/g, '𝒲');

        // "U+1D4B3", "MATHEMATICAL SCRIPT CAPITAL X"
        txt = txt.replace(/&#x0*?1D4B3;/g, '𝒳');
        txt = txt.replace(/&#0*?119987;/g, '𝒳');
        txt = txt.replace(/&Xscr;/g, '𝒳');

        // "U+1D4B4", "MATHEMATICAL SCRIPT CAPITAL Y"
        txt = txt.replace(/&#x0*?1D4B4;/g, '𝒴');
        txt = txt.replace(/&#0*?119988;/g, '𝒴');
        txt = txt.replace(/&Yscr;/g, '𝒴');

        // "U+1D4B5", "MATHEMATICAL SCRIPT CAPITAL Z"
        txt = txt.replace(/&#x0*?1D4B5;/g, '𝒵');
        txt = txt.replace(/&#0*?119989;/g, '𝒵');
        txt = txt.replace(/&Zscr;/g, '𝒵');

        // "U+1D4B6", "MATHEMATICAL SCRIPT SMALL A"
        txt = txt.replace(/&#x0*?1D4B6;/g, '𝒶');
        txt = txt.replace(/&#0*?119990;/g, '𝒶');
        txt = txt.replace(/&ascr;/g, '𝒶');

        // "U+1D4B7", "MATHEMATICAL SCRIPT SMALL B"
        txt = txt.replace(/&#x0*?1D4B7;/g, '𝒷');
        txt = txt.replace(/&#0*?119991;/g, '𝒷');
        txt = txt.replace(/&bscr;/g, '𝒷');

        // "U+1D4B8", "MATHEMATICAL SCRIPT SMALL C"
        txt = txt.replace(/&#x0*?1D4B8;/g, '𝒸');
        txt = txt.replace(/&#0*?119992;/g, '𝒸');
        txt = txt.replace(/&cscr;/g, '𝒸');

        // "U+1D4B9", "MATHEMATICAL SCRIPT SMALL D"
        txt = txt.replace(/&#x0*?1D4B9;/g, '𝒹');
        txt = txt.replace(/&#0*?119993;/g, '𝒹');
        txt = txt.replace(/&dscr;/g, '𝒹');

        // "U+1D4BB", "MATHEMATICAL SCRIPT SMALL F"
        txt = txt.replace(/&#x0*?1D4BB;/g, '𝒻');
        txt = txt.replace(/&#0*?119995;/g, '𝒻');
        txt = txt.replace(/&fscr;/g, '𝒻');

        // "U+1D4BD", "MATHEMATICAL SCRIPT SMALL H"
        txt = txt.replace(/&#x0*?1D4BD;/g, '𝒽');
        txt = txt.replace(/&#0*?119997;/g, '𝒽');
        txt = txt.replace(/&hscr;/g, '𝒽');

        // "U+1D4BE", "MATHEMATICAL SCRIPT SMALL I"
        txt = txt.replace(/&#x0*?1D4BE;/g, '𝒾');
        txt = txt.replace(/&#0*?119998;/g, '𝒾');
        txt = txt.replace(/&iscr;/g, '𝒾');

        // "U+1D4BF", "MATHEMATICAL SCRIPT SMALL J"
        txt = txt.replace(/&#x0*?1D4BF;/g, '𝒿');
        txt = txt.replace(/&#0*?119999;/g, '𝒿');
        txt = txt.replace(/&jscr;/g, '𝒿');

        // "U+1D4C0", "MATHEMATICAL SCRIPT SMALL K"
        txt = txt.replace(/&#x0*?1D4C0;/g, '𝓀');
        txt = txt.replace(/&#0*?120000;/g, '𝓀');
        txt = txt.replace(/&kscr;/g, '𝓀');

        // "U+1D4C1", "MATHEMATICAL SCRIPT SMALL L"
        txt = txt.replace(/&#x0*?1D4C1;/g, '𝓁');
        txt = txt.replace(/&#0*?120001;/g, '𝓁');
        txt = txt.replace(/&lscr;/g, '𝓁');

        // "U+1D4C2", "MATHEMATICAL SCRIPT SMALL M"
        txt = txt.replace(/&#x0*?1D4C2;/g, '𝓂');
        txt = txt.replace(/&#0*?120002;/g, '𝓂');
        txt = txt.replace(/&mscr;/g, '𝓂');

        // "U+1D4C3", "MATHEMATICAL SCRIPT SMALL N"
        txt = txt.replace(/&#x0*?1D4C3;/g, '𝓃');
        txt = txt.replace(/&#0*?120003;/g, '𝓃');
        txt = txt.replace(/&nscr;/g, '𝓃');

        // "U+1D4C5", "MATHEMATICAL SCRIPT SMALL P"
        txt = txt.replace(/&#x0*?1D4C5;/g, '𝓅');
        txt = txt.replace(/&#0*?120005;/g, '𝓅');
        txt = txt.replace(/&pscr;/g, '𝓅');

        // "U+1D4C6", "MATHEMATICAL SCRIPT SMALL Q"
        txt = txt.replace(/&#x0*?1D4C6;/g, '𝓆');
        txt = txt.replace(/&#0*?120006;/g, '𝓆');
        txt = txt.replace(/&qscr;/g, '𝓆');

        // "U+1D4C7", "MATHEMATICAL SCRIPT SMALL R"
        txt = txt.replace(/&#x0*?1D4C7;/g, '𝓇');
        txt = txt.replace(/&#0*?120007;/g, '𝓇');
        txt = txt.replace(/&rscr;/g, '𝓇');

        // "U+1D4C8", "MATHEMATICAL SCRIPT SMALL S"
        txt = txt.replace(/&#x0*?1D4C8;/g, '𝓈');
        txt = txt.replace(/&#0*?120008;/g, '𝓈');
        txt = txt.replace(/&sscr;/g, '𝓈');

        // "U+1D4C9", "MATHEMATICAL SCRIPT SMALL T"
        txt = txt.replace(/&#x0*?1D4C9;/g, '𝓉');
        txt = txt.replace(/&#0*?120009;/g, '𝓉');
        txt = txt.replace(/&tscr;/g, '𝓉');

        // "U+1D4CA", "MATHEMATICAL SCRIPT SMALL U"
        txt = txt.replace(/&#x0*?1D4CA;/g, '𝓊');
        txt = txt.replace(/&#0*?120010;/g, '𝓊');
        txt = txt.replace(/&uscr;/g, '𝓊');

        // "U+1D4CB", "MATHEMATICAL SCRIPT SMALL V"
        txt = txt.replace(/&#x0*?1D4CB;/g, '𝓋');
        txt = txt.replace(/&#0*?120011;/g, '𝓋');
        txt = txt.replace(/&vscr;/g, '𝓋');

        // "U+1D4CC", "MATHEMATICAL SCRIPT SMALL W"
        txt = txt.replace(/&#x0*?1D4CC;/g, '𝓌');
        txt = txt.replace(/&#0*?120012;/g, '𝓌');
        txt = txt.replace(/&wscr;/g, '𝓌');

        // "U+1D4CD", "MATHEMATICAL SCRIPT SMALL X"
        txt = txt.replace(/&#x0*?1D4CD;/g, '𝓍');
        txt = txt.replace(/&#0*?120013;/g, '𝓍');
        txt = txt.replace(/&xscr;/g, '𝓍');

        // "U+1D4CE", "MATHEMATICAL SCRIPT SMALL Y"
        txt = txt.replace(/&#x0*?1D4CE;/g, '𝓎');
        txt = txt.replace(/&#0*?120014;/g, '𝓎');
        txt = txt.replace(/&yscr;/g, '𝓎');

        // "U+1D4CF", "MATHEMATICAL SCRIPT SMALL Z"
        txt = txt.replace(/&#x0*?1D4CF;/g, '𝓏');
        txt = txt.replace(/&#0*?120015;/g, '𝓏');
        txt = txt.replace(/&zscr;/g, '𝓏');

        // "U+1D504", "MATHEMATICAL FRAKTUR CAPITAL A"
        txt = txt.replace(/&#x0*?1D504;/g, '𝔄');
        txt = txt.replace(/&#0*?120068;/g, '𝔄');
        txt = txt.replace(/&Afr;/g, '𝔄');

        // "U+1D505", "MATHEMATICAL FRAKTUR CAPITAL B"
        txt = txt.replace(/&#x0*?1D505;/g, '𝔅');
        txt = txt.replace(/&#0*?120069;/g, '𝔅');
        txt = txt.replace(/&Bfr;/g, '𝔅');

        // "U+1D507", "MATHEMATICAL FRAKTUR CAPITAL D"
        txt = txt.replace(/&#x0*?1D507;/g, '𝔇');
        txt = txt.replace(/&#0*?120071;/g, '𝔇');
        txt = txt.replace(/&Dfr;/g, '𝔇');

        // "U+1D508", "MATHEMATICAL FRAKTUR CAPITAL E"
        txt = txt.replace(/&#x0*?1D508;/g, '𝔈');
        txt = txt.replace(/&#0*?120072;/g, '𝔈');
        txt = txt.replace(/&Efr;/g, '𝔈');

        // "U+1D509", "MATHEMATICAL FRAKTUR CAPITAL F"
        txt = txt.replace(/&#x0*?1D509;/g, '𝔉');
        txt = txt.replace(/&#0*?120073;/g, '𝔉');
        txt = txt.replace(/&Ffr;/g, '𝔉');

        // "U+1D50A", "MATHEMATICAL FRAKTUR CAPITAL G"
        txt = txt.replace(/&#x0*?1D50A;/g, '𝔊');
        txt = txt.replace(/&#0*?120074;/g, '𝔊');
        txt = txt.replace(/&Gfr;/g, '𝔊');

        // "U+1D50D", "MATHEMATICAL FRAKTUR CAPITAL J"
        txt = txt.replace(/&#x0*?1D50D;/g, '𝔍');
        txt = txt.replace(/&#0*?120077;/g, '𝔍');
        txt = txt.replace(/&Jfr;/g, '𝔍');

        // "U+1D50E", "MATHEMATICAL FRAKTUR CAPITAL K"
        txt = txt.replace(/&#x0*?1D50E;/g, '𝔎');
        txt = txt.replace(/&#0*?120078;/g, '𝔎');
        txt = txt.replace(/&Kfr;/g, '𝔎');

        // "U+1D50F", "MATHEMATICAL FRAKTUR CAPITAL L"
        txt = txt.replace(/&#x0*?1D50F;/g, '𝔏');
        txt = txt.replace(/&#0*?120079;/g, '𝔏');
        txt = txt.replace(/&Lfr;/g, '𝔏');

        // "U+1D510", "MATHEMATICAL FRAKTUR CAPITAL M"
        txt = txt.replace(/&#x0*?1D510;/g, '𝔐');
        txt = txt.replace(/&#0*?120080;/g, '𝔐');
        txt = txt.replace(/&Mfr;/g, '𝔐');

        // "U+1D511", "MATHEMATICAL FRAKTUR CAPITAL N"
        txt = txt.replace(/&#x0*?1D511;/g, '𝔑');
        txt = txt.replace(/&#0*?120081;/g, '𝔑');
        txt = txt.replace(/&Nfr;/g, '𝔑');

        // "U+1D512", "MATHEMATICAL FRAKTUR CAPITAL O"
        txt = txt.replace(/&#x0*?1D512;/g, '𝔒');
        txt = txt.replace(/&#0*?120082;/g, '𝔒');
        txt = txt.replace(/&Ofr;/g, '𝔒');

        // "U+1D513", "MATHEMATICAL FRAKTUR CAPITAL P"
        txt = txt.replace(/&#x0*?1D513;/g, '𝔓');
        txt = txt.replace(/&#0*?120083;/g, '𝔓');
        txt = txt.replace(/&Pfr;/g, '𝔓');

        // "U+1D514", "MATHEMATICAL FRAKTUR CAPITAL Q"
        txt = txt.replace(/&#x0*?1D514;/g, '𝔔');
        txt = txt.replace(/&#0*?120084;/g, '𝔔');
        txt = txt.replace(/&Qfr;/g, '𝔔');

        // "U+1D516", "MATHEMATICAL FRAKTUR CAPITAL S"
        txt = txt.replace(/&#x0*?1D516;/g, '𝔖');
        txt = txt.replace(/&#0*?120086;/g, '𝔖');
        txt = txt.replace(/&Sfr;/g, '𝔖');

        // "U+1D517", "MATHEMATICAL FRAKTUR CAPITAL T"
        txt = txt.replace(/&#x0*?1D517;/g, '𝔗');
        txt = txt.replace(/&#0*?120087;/g, '𝔗');
        txt = txt.replace(/&Tfr;/g, '𝔗');

        // "U+1D518", "MATHEMATICAL FRAKTUR CAPITAL U"
        txt = txt.replace(/&#x0*?1D518;/g, '𝔘');
        txt = txt.replace(/&#0*?120088;/g, '𝔘');
        txt = txt.replace(/&Ufr;/g, '𝔘');

        // "U+1D519", "MATHEMATICAL FRAKTUR CAPITAL V"
        txt = txt.replace(/&#x0*?1D519;/g, '𝔙');
        txt = txt.replace(/&#0*?120089;/g, '𝔙');
        txt = txt.replace(/&Vfr;/g, '𝔙');

        // "U+1D51A", "MATHEMATICAL FRAKTUR CAPITAL W"
        txt = txt.replace(/&#x0*?1D51A;/g, '𝔚');
        txt = txt.replace(/&#0*?120090;/g, '𝔚');
        txt = txt.replace(/&Wfr;/g, '𝔚');

        // "U+1D51B", "MATHEMATICAL FRAKTUR CAPITAL X"
        txt = txt.replace(/&#x0*?1D51B;/g, '𝔛');
        txt = txt.replace(/&#0*?120091;/g, '𝔛');
        txt = txt.replace(/&Xfr;/g, '𝔛');

        // "U+1D51C", "MATHEMATICAL FRAKTUR CAPITAL Y"
        txt = txt.replace(/&#x0*?1D51C;/g, '𝔜');
        txt = txt.replace(/&#0*?120092;/g, '𝔜');
        txt = txt.replace(/&Yfr;/g, '𝔜');

        // "U+1D51E", "MATHEMATICAL FRAKTUR SMALL A"
        txt = txt.replace(/&#x0*?1D51E;/g, '𝔞');
        txt = txt.replace(/&#0*?120094;/g, '𝔞');
        txt = txt.replace(/&afr;/g, '𝔞');

        // "U+1D51F", "MATHEMATICAL FRAKTUR SMALL B"
        txt = txt.replace(/&#x0*?1D51F;/g, '𝔟');
        txt = txt.replace(/&#0*?120095;/g, '𝔟');
        txt = txt.replace(/&bfr;/g, '𝔟');

        // "U+1D520", "MATHEMATICAL FRAKTUR SMALL C"
        txt = txt.replace(/&#x0*?1D520;/g, '𝔠');
        txt = txt.replace(/&#0*?120096;/g, '𝔠');
        txt = txt.replace(/&cfr;/g, '𝔠');

        // "U+1D521", "MATHEMATICAL FRAKTUR SMALL D"
        txt = txt.replace(/&#x0*?1D521;/g, '𝔡');
        txt = txt.replace(/&#0*?120097;/g, '𝔡');
        txt = txt.replace(/&dfr;/g, '𝔡');

        // "U+1D522", "MATHEMATICAL FRAKTUR SMALL E"
        txt = txt.replace(/&#x0*?1D522;/g, '𝔢');
        txt = txt.replace(/&#0*?120098;/g, '𝔢');
        txt = txt.replace(/&efr;/g, '𝔢');

        // "U+1D523", "MATHEMATICAL FRAKTUR SMALL F"
        txt = txt.replace(/&#x0*?1D523;/g, '𝔣');
        txt = txt.replace(/&#0*?120099;/g, '𝔣');
        txt = txt.replace(/&ffr;/g, '𝔣');

        // "U+1D524", "MATHEMATICAL FRAKTUR SMALL G"
        txt = txt.replace(/&#x0*?1D524;/g, '𝔤');
        txt = txt.replace(/&#0*?120100;/g, '𝔤');
        txt = txt.replace(/&gfr;/g, '𝔤');

        // "U+1D525", "MATHEMATICAL FRAKTUR SMALL H"
        txt = txt.replace(/&#x0*?1D525;/g, '𝔥');
        txt = txt.replace(/&#0*?120101;/g, '𝔥');
        txt = txt.replace(/&hfr;/g, '𝔥');

        // "U+1D526", "MATHEMATICAL FRAKTUR SMALL I"
        txt = txt.replace(/&#x0*?1D526;/g, '𝔦');
        txt = txt.replace(/&#0*?120102;/g, '𝔦');
        txt = txt.replace(/&ifr;/g, '𝔦');

        // "U+1D527", "MATHEMATICAL FRAKTUR SMALL J"
        txt = txt.replace(/&#x0*?1D527;/g, '𝔧');
        txt = txt.replace(/&#0*?120103;/g, '𝔧');
        txt = txt.replace(/&jfr;/g, '𝔧');

        // "U+1D528", "MATHEMATICAL FRAKTUR SMALL K"
        txt = txt.replace(/&#x0*?1D528;/g, '𝔨');
        txt = txt.replace(/&#0*?120104;/g, '𝔨');
        txt = txt.replace(/&kfr;/g, '𝔨');

        // "U+1D529", "MATHEMATICAL FRAKTUR SMALL L"
        txt = txt.replace(/&#x0*?1D529;/g, '𝔩');
        txt = txt.replace(/&#0*?120105;/g, '𝔩');
        txt = txt.replace(/&lfr;/g, '𝔩');

        // "U+1D52A", "MATHEMATICAL FRAKTUR SMALL M"
        txt = txt.replace(/&#x0*?1D52A;/g, '𝔪');
        txt = txt.replace(/&#0*?120106;/g, '𝔪');
        txt = txt.replace(/&mfr;/g, '𝔪');

        // "U+1D52B", "MATHEMATICAL FRAKTUR SMALL N"
        txt = txt.replace(/&#x0*?1D52B;/g, '𝔫');
        txt = txt.replace(/&#0*?120107;/g, '𝔫');
        txt = txt.replace(/&nfr;/g, '𝔫');

        // "U+1D52C", "MATHEMATICAL FRAKTUR SMALL O"
        txt = txt.replace(/&#x0*?1D52C;/g, '𝔬');
        txt = txt.replace(/&#0*?120108;/g, '𝔬');
        txt = txt.replace(/&ofr;/g, '𝔬');

        // "U+1D52D", "MATHEMATICAL FRAKTUR SMALL P"
        txt = txt.replace(/&#x0*?1D52D;/g, '𝔭');
        txt = txt.replace(/&#0*?120109;/g, '𝔭');
        txt = txt.replace(/&pfr;/g, '𝔭');

        // "U+1D52E", "MATHEMATICAL FRAKTUR SMALL Q"
        txt = txt.replace(/&#x0*?1D52E;/g, '𝔮');
        txt = txt.replace(/&#0*?120110;/g, '𝔮');
        txt = txt.replace(/&qfr;/g, '𝔮');

        // "U+1D52F", "MATHEMATICAL FRAKTUR SMALL R"
        txt = txt.replace(/&#x0*?1D52F;/g, '𝔯');
        txt = txt.replace(/&#0*?120111;/g, '𝔯');
        txt = txt.replace(/&rfr;/g, '𝔯');

        // "U+1D530", "MATHEMATICAL FRAKTUR SMALL S"
        txt = txt.replace(/&#x0*?1D530;/g, '𝔰');
        txt = txt.replace(/&#0*?120112;/g, '𝔰');
        txt = txt.replace(/&sfr;/g, '𝔰');

        // "U+1D531", "MATHEMATICAL FRAKTUR SMALL T"
        txt = txt.replace(/&#x0*?1D531;/g, '𝔱');
        txt = txt.replace(/&#0*?120113;/g, '𝔱');
        txt = txt.replace(/&tfr;/g, '𝔱');

        // "U+1D532", "MATHEMATICAL FRAKTUR SMALL U"
        txt = txt.replace(/&#x0*?1D532;/g, '𝔲');
        txt = txt.replace(/&#0*?120114;/g, '𝔲');
        txt = txt.replace(/&ufr;/g, '𝔲');

        // "U+1D533", "MATHEMATICAL FRAKTUR SMALL V"
        txt = txt.replace(/&#x0*?1D533;/g, '𝔳');
        txt = txt.replace(/&#0*?120115;/g, '𝔳');
        txt = txt.replace(/&vfr;/g, '𝔳');

        // "U+1D534", "MATHEMATICAL FRAKTUR SMALL W"
        txt = txt.replace(/&#x0*?1D534;/g, '𝔴');
        txt = txt.replace(/&#0*?120116;/g, '𝔴');
        txt = txt.replace(/&wfr;/g, '𝔴');

        // "U+1D535", "MATHEMATICAL FRAKTUR SMALL X"
        txt = txt.replace(/&#x0*?1D535;/g, '𝔵');
        txt = txt.replace(/&#0*?120117;/g, '𝔵');
        txt = txt.replace(/&xfr;/g, '𝔵');

        // "U+1D536", "MATHEMATICAL FRAKTUR SMALL Y"
        txt = txt.replace(/&#x0*?1D536;/g, '𝔶');
        txt = txt.replace(/&#0*?120118;/g, '𝔶');
        txt = txt.replace(/&yfr;/g, '𝔶');

        // "U+1D537", "MATHEMATICAL FRAKTUR SMALL Z"
        txt = txt.replace(/&#x0*?1D537;/g, '𝔷');
        txt = txt.replace(/&#0*?120119;/g, '𝔷');
        txt = txt.replace(/&zfr;/g, '𝔷');

        // "U+1D538", "MATHEMATICAL DOUBLE-STRUCK CAPITAL A"
        txt = txt.replace(/&#x0*?1D538;/g, '𝔸');
        txt = txt.replace(/&#0*?120120;/g, '𝔸');
        txt = txt.replace(/&Aopf;/g, '𝔸');

        // "U+1D539", "MATHEMATICAL DOUBLE-STRUCK CAPITAL B"
        txt = txt.replace(/&#x0*?1D539;/g, '𝔹');
        txt = txt.replace(/&#0*?120121;/g, '𝔹');
        txt = txt.replace(/&Bopf;/g, '𝔹');

        // "U+1D53B", "MATHEMATICAL DOUBLE-STRUCK CAPITAL D"
        txt = txt.replace(/&#x0*?1D53B;/g, '𝔻');
        txt = txt.replace(/&#0*?120123;/g, '𝔻');
        txt = txt.replace(/&Dopf;/g, '𝔻');

        // "U+1D53C", "MATHEMATICAL DOUBLE-STRUCK CAPITAL E"
        txt = txt.replace(/&#x0*?1D53C;/g, '𝔼');
        txt = txt.replace(/&#0*?120124;/g, '𝔼');
        txt = txt.replace(/&Eopf;/g, '𝔼');

        // "U+1D53D", "MATHEMATICAL DOUBLE-STRUCK CAPITAL F"
        txt = txt.replace(/&#x0*?1D53D;/g, '𝔽');
        txt = txt.replace(/&#0*?120125;/g, '𝔽');
        txt = txt.replace(/&Fopf;/g, '𝔽');

        // "U+1D53E", "MATHEMATICAL DOUBLE-STRUCK CAPITAL G"
        txt = txt.replace(/&#x0*?1D53E;/g, '𝔾');
        txt = txt.replace(/&#0*?120126;/g, '𝔾');
        txt = txt.replace(/&Gopf;/g, '𝔾');

        // "U+1D540", "MATHEMATICAL DOUBLE-STRUCK CAPITAL I"
        txt = txt.replace(/&#x0*?1D540;/g, '𝕀');
        txt = txt.replace(/&#0*?120128;/g, '𝕀');
        txt = txt.replace(/&Iopf;/g, '𝕀');

        // "U+1D541", "MATHEMATICAL DOUBLE-STRUCK CAPITAL J"
        txt = txt.replace(/&#x0*?1D541;/g, '𝕁');
        txt = txt.replace(/&#0*?120129;/g, '𝕁');
        txt = txt.replace(/&Jopf;/g, '𝕁');

        // "U+1D542", "MATHEMATICAL DOUBLE-STRUCK CAPITAL K"
        txt = txt.replace(/&#x0*?1D542;/g, '𝕂');
        txt = txt.replace(/&#0*?120130;/g, '𝕂');
        txt = txt.replace(/&Kopf;/g, '𝕂');

        // "U+1D543", "MATHEMATICAL DOUBLE-STRUCK CAPITAL L"
        txt = txt.replace(/&#x0*?1D543;/g, '𝕃');
        txt = txt.replace(/&#0*?120131;/g, '𝕃');
        txt = txt.replace(/&Lopf;/g, '𝕃');

        // "U+1D544", "MATHEMATICAL DOUBLE-STRUCK CAPITAL M"
        txt = txt.replace(/&#x0*?1D544;/g, '𝕄');
        txt = txt.replace(/&#0*?120132;/g, '𝕄');
        txt = txt.replace(/&Mopf;/g, '𝕄');

        // "U+1D546", "MATHEMATICAL DOUBLE-STRUCK CAPITAL O"
        txt = txt.replace(/&#x0*?1D546;/g, '𝕆');
        txt = txt.replace(/&#0*?120134;/g, '𝕆');
        txt = txt.replace(/&Oopf;/g, '𝕆');

        // "U+1D54A", "MATHEMATICAL DOUBLE-STRUCK CAPITAL S"
        txt = txt.replace(/&#x0*?1D54A;/g, '𝕊');
        txt = txt.replace(/&#0*?120138;/g, '𝕊');
        txt = txt.replace(/&Sopf;/g, '𝕊');

        // "U+1D54B", "MATHEMATICAL DOUBLE-STRUCK CAPITAL T"
        txt = txt.replace(/&#x0*?1D54B;/g, '𝕋');
        txt = txt.replace(/&#0*?120139;/g, '𝕋');
        txt = txt.replace(/&Topf;/g, '𝕋');

        // "U+1D54C", "MATHEMATICAL DOUBLE-STRUCK CAPITAL U"
        txt = txt.replace(/&#x0*?1D54C;/g, '𝕌');
        txt = txt.replace(/&#0*?120140;/g, '𝕌');
        txt = txt.replace(/&Uopf;/g, '𝕌');

        // "U+1D54D", "MATHEMATICAL DOUBLE-STRUCK CAPITAL V"
        txt = txt.replace(/&#x0*?1D54D;/g, '𝕍');
        txt = txt.replace(/&#0*?120141;/g, '𝕍');
        txt = txt.replace(/&Vopf;/g, '𝕍');

        // "U+1D54E", "MATHEMATICAL DOUBLE-STRUCK CAPITAL W"
        txt = txt.replace(/&#x0*?1D54E;/g, '𝕎');
        txt = txt.replace(/&#0*?120142;/g, '𝕎');
        txt = txt.replace(/&Wopf;/g, '𝕎');

        // "U+1D54F", "MATHEMATICAL DOUBLE-STRUCK CAPITAL X"
        txt = txt.replace(/&#x0*?1D54F;/g, '𝕏');
        txt = txt.replace(/&#0*?120143;/g, '𝕏');
        txt = txt.replace(/&Xopf;/g, '𝕏');

        // "U+1D550", "MATHEMATICAL DOUBLE-STRUCK CAPITAL Y"
        txt = txt.replace(/&#x0*?1D550;/g, '𝕐');
        txt = txt.replace(/&#0*?120144;/g, '𝕐');
        txt = txt.replace(/&Yopf;/g, '𝕐');

        // "U+1D552", "MATHEMATICAL DOUBLE-STRUCK SMALL A"
        txt = txt.replace(/&#x0*?1D552;/g, '𝕒');
        txt = txt.replace(/&#0*?120146;/g, '𝕒');
        txt = txt.replace(/&aopf;/g, '𝕒');

        // "U+1D553", "MATHEMATICAL DOUBLE-STRUCK SMALL B"
        txt = txt.replace(/&#x0*?1D553;/g, '𝕓');
        txt = txt.replace(/&#0*?120147;/g, '𝕓');
        txt = txt.replace(/&bopf;/g, '𝕓');

        // "U+1D554", "MATHEMATICAL DOUBLE-STRUCK SMALL C"
        txt = txt.replace(/&#x0*?1D554;/g, '𝕔');
        txt = txt.replace(/&#0*?120148;/g, '𝕔');
        txt = txt.replace(/&copf;/g, '𝕔');

        // "U+1D555", "MATHEMATICAL DOUBLE-STRUCK SMALL D"
        txt = txt.replace(/&#x0*?1D555;/g, '𝕕');
        txt = txt.replace(/&#0*?120149;/g, '𝕕');
        txt = txt.replace(/&dopf;/g, '𝕕');

        // "U+1D556", "MATHEMATICAL DOUBLE-STRUCK SMALL E"
        txt = txt.replace(/&#x0*?1D556;/g, '𝕖');
        txt = txt.replace(/&#0*?120150;/g, '𝕖');
        txt = txt.replace(/&eopf;/g, '𝕖');

        // "U+1D557", "MATHEMATICAL DOUBLE-STRUCK SMALL F"
        txt = txt.replace(/&#x0*?1D557;/g, '𝕗');
        txt = txt.replace(/&#0*?120151;/g, '𝕗');
        txt = txt.replace(/&fopf;/g, '𝕗');

        // "U+1D558", "MATHEMATICAL DOUBLE-STRUCK SMALL G"
        txt = txt.replace(/&#x0*?1D558;/g, '𝕘');
        txt = txt.replace(/&#0*?120152;/g, '𝕘');
        txt = txt.replace(/&gopf;/g, '𝕘');

        // "U+1D559", "MATHEMATICAL DOUBLE-STRUCK SMALL H"
        txt = txt.replace(/&#x0*?1D559;/g, '𝕙');
        txt = txt.replace(/&#0*?120153;/g, '𝕙');
        txt = txt.replace(/&hopf;/g, '𝕙');

        // "U+1D55A", "MATHEMATICAL DOUBLE-STRUCK SMALL I"
        txt = txt.replace(/&#x0*?1D55A;/g, '𝕚');
        txt = txt.replace(/&#0*?120154;/g, '𝕚');
        txt = txt.replace(/&iopf;/g, '𝕚');

        // "U+1D55B", "MATHEMATICAL DOUBLE-STRUCK SMALL J"
        txt = txt.replace(/&#x0*?1D55B;/g, '𝕛');
        txt = txt.replace(/&#0*?120155;/g, '𝕛');
        txt = txt.replace(/&jopf;/g, '𝕛');

        // "U+1D55C", "MATHEMATICAL DOUBLE-STRUCK SMALL K"
        txt = txt.replace(/&#x0*?1D55C;/g, '𝕜');
        txt = txt.replace(/&#0*?120156;/g, '𝕜');
        txt = txt.replace(/&kopf;/g, '𝕜');

        // "U+1D55D", "MATHEMATICAL DOUBLE-STRUCK SMALL L"
        txt = txt.replace(/&#x0*?1D55D;/g, '𝕝');
        txt = txt.replace(/&#0*?120157;/g, '𝕝');
        txt = txt.replace(/&lopf;/g, '𝕝');

        // "U+1D55E", "MATHEMATICAL DOUBLE-STRUCK SMALL M"
        txt = txt.replace(/&#x0*?1D55E;/g, '𝕞');
        txt = txt.replace(/&#0*?120158;/g, '𝕞');
        txt = txt.replace(/&mopf;/g, '𝕞');

        // "U+1D55F", "MATHEMATICAL DOUBLE-STRUCK SMALL N"
        txt = txt.replace(/&#x0*?1D55F;/g, '𝕟');
        txt = txt.replace(/&#0*?120159;/g, '𝕟');
        txt = txt.replace(/&nopf;/g, '𝕟');

        // "U+1D560", "MATHEMATICAL DOUBLE-STRUCK SMALL O"
        txt = txt.replace(/&#x0*?1D560;/g, '𝕠');
        txt = txt.replace(/&#0*?120160;/g, '𝕠');
        txt = txt.replace(/&oopf;/g, '𝕠');

        // "U+1D561", "MATHEMATICAL DOUBLE-STRUCK SMALL P"
        txt = txt.replace(/&#x0*?1D561;/g, '𝕡');
        txt = txt.replace(/&#0*?120161;/g, '𝕡');
        txt = txt.replace(/&popf;/g, '𝕡');

        // "U+1D562", "MATHEMATICAL DOUBLE-STRUCK SMALL Q"
        txt = txt.replace(/&#x0*?1D562;/g, '𝕢');
        txt = txt.replace(/&#0*?120162;/g, '𝕢');
        txt = txt.replace(/&qopf;/g, '𝕢');

        // "U+1D563", "MATHEMATICAL DOUBLE-STRUCK SMALL R"
        txt = txt.replace(/&#x0*?1D563;/g, '𝕣');
        txt = txt.replace(/&#0*?120163;/g, '𝕣');
        txt = txt.replace(/&ropf;/g, '𝕣');

        // "U+1D564", "MATHEMATICAL DOUBLE-STRUCK SMALL S"
        txt = txt.replace(/&#x0*?1D564;/g, '𝕤');
        txt = txt.replace(/&#0*?120164;/g, '𝕤');
        txt = txt.replace(/&sopf;/g, '𝕤');

        // "U+1D565", "MATHEMATICAL DOUBLE-STRUCK SMALL T"
        txt = txt.replace(/&#x0*?1D565;/g, '𝕥');
        txt = txt.replace(/&#0*?120165;/g, '𝕥');
        txt = txt.replace(/&topf;/g, '𝕥');

        // "U+1D566", "MATHEMATICAL DOUBLE-STRUCK SMALL U"
        txt = txt.replace(/&#x0*?1D566;/g, '𝕦');
        txt = txt.replace(/&#0*?120166;/g, '𝕦');
        txt = txt.replace(/&uopf;/g, '𝕦');

        // "U+1D567", "MATHEMATICAL DOUBLE-STRUCK SMALL V"
        txt = txt.replace(/&#x0*?1D567;/g, '𝕧');
        txt = txt.replace(/&#0*?120167;/g, '𝕧');
        txt = txt.replace(/&vopf;/g, '𝕧');

        // "U+1D568", "MATHEMATICAL DOUBLE-STRUCK SMALL W"
        txt = txt.replace(/&#x0*?1D568;/g, '𝕨');
        txt = txt.replace(/&#0*?120168;/g, '𝕨');
        txt = txt.replace(/&wopf;/g, '𝕨');

        // "U+1D569", "MATHEMATICAL DOUBLE-STRUCK SMALL X"
        txt = txt.replace(/&#x0*?1D569;/g, '𝕩');
        txt = txt.replace(/&#0*?120169;/g, '𝕩');
        txt = txt.replace(/&xopf;/g, '𝕩');

        // "U+1D56A", "MATHEMATICAL DOUBLE-STRUCK SMALL Y"
        txt = txt.replace(/&#x0*?1D56A;/g, '𝕪');
        txt = txt.replace(/&#0*?120170;/g, '𝕪');
        txt = txt.replace(/&yopf;/g, '𝕪');

        // "U+1D56B", "MATHEMATICAL DOUBLE-STRUCK SMALL Z"
        txt = txt.replace(/&#x0*?1D56B;/g, '𝕫');
        txt = txt.replace(/&#0*?120171;/g, '𝕫');
        txt = txt.replace(/&zopf;/g, '𝕫');

        return txt;
    }

    /**
     * 入力される文字列内の文字実体参照を文字や記号に置きかえます。
     * @param sources 置きかえられる文字列の配列。
     * @returns 置きかえられた文字列の配列。
     */
    public static convertFromCharacterEntityReferenceAll(sources: string[]): string[] {
        for (let i = 0; i < sources.length; i++) {
            sources[i] = this.convertFromCharacterEntityReference(sources[i]);
        }

        return sources;
    }

    /**
     * 入力される文字列内の文字や記号を文字実体参照に置きかえます。ベーシック版です。
     * @param source 置きかえられる文字列。
     * @returns 置きかえられた文字列。
     */
    public static convertToCharacterEntityReferenceBasic(source: string): string {
        let txt = source;

        // "U+00026", "AMPERSAND"
        txt = txt.replace('&', '&amp;');

        // "U+00022", "QUOTATION MARK"
        txt = txt.replace('"', '&quot;');

        // "U+00027", "APOSTROPHE"
        txt = txt.replace("'", '&apos;');

        // "U+0003C", "LESS-THAN SIGN"
        txt = txt.replace('<', '&lt;');

        // "U+0003E", "GREATER-THAN SIGN"
        txt = txt.replace('>', '&gt;');

        // "U+000A0", "NO-BREAK SPACE"
        txt = txt.replace(' ', '&nbsp;');

        // "U+000A1", "INVERTED EXCLAMATION MARK"
        txt = txt.replace('¡', '&iexcl;');

        // "U+000A2", "CENT SIGN"
        txt = txt.replace('¢', '&cent;');

        // "U+000A3", "POUND SIGN"
        txt = txt.replace('£', '&pound;');

        // "U+000A4", "CURRENCY SIGN"
        txt = txt.replace('¤', '&curren;');

        // "U+000A5", "YEN SIGN"
        txt = txt.replace('¥', '&yen;');

        // "U+000A6", "BROKEN BAR"
        txt = txt.replace('¦', '&brvbar;');

        // "U+000A7", "SECTION SIGN"
        txt = txt.replace('§', '&sect;');

        // "U+000A8", "DIAERESIS"
        txt = txt.replace('¨', '&Dot;');

        // "U+000A9", "COPYRIGHT SIGN"
        txt = txt.replace('©', '&copy;');

        // "U+000AA", "FEMININE ORDINAL INDICATOR"
        txt = txt.replace('ª', '&ordf;');

        // "U+000AB", "LEFT-POINTING DOUBLE ANGLE QUOTATION MARK"
        txt = txt.replace('«', '&laquo;');

        // "U+000AC", "NOT SIGN"
        txt = txt.replace('¬', '&not;');

        // "U+000AD", "SOFT HYPHEN"
        txt = txt.replace('­', '&shy;');

        // "U+000AE", "REGISTERED SIGN"
        txt = txt.replace('®', '&reg;');

        // "U+000AF", "MACRON"
        txt = txt.replace('¯', '&macr;');

        // "U+000B0", "DEGREE SIGN"
        txt = txt.replace('°', '&deg;');

        // "U+000B1", "PLUS-MINUS SIGN"
        txt = txt.replace('±', '&plusmn;');

        // "U+000B2", "SUPERSCRIPT TWO"
        txt = txt.replace('²', '&sup2;');

        // "U+000B3", "SUPERSCRIPT THREE"
        txt = txt.replace('³', '&sup3;');

        // "U+000B4", "ACUTE ACCENT"
        txt = txt.replace('´', '&acute;');

        // "U+000B5", "MICRO SIGN"
        txt = txt.replace('µ', '&micro;');

        // "U+000B6", "PILCROW SIGN"
        txt = txt.replace('¶', '&para;');

        // "U+000B7", "MIDDLE DOT"
        txt = txt.replace('·', '&middot;');

        // "U+000B8", "CEDILLA"
        txt = txt.replace('¸', '&cedil;');

        // "U+000B9", "SUPERSCRIPT ONE"
        txt = txt.replace('¹', '&sup1;');

        // "U+000BA", "MASCULINE ORDINAL INDICATOR"
        txt = txt.replace('º', '&ordm;');

        // "U+000BB", "RIGHT-POINTING DOUBLE ANGLE QUOTATION MARK"
        txt = txt.replace('»', '&raquo;');

        // "U+000BC", "VULGAR FRACTION ONE QUARTER"
        txt = txt.replace('¼', '&frac14;');

        // "U+000BD", "VULGAR FRACTION ONE HALF"
        txt = txt.replace('½', '&frac12;');

        // "U+000BE", "VULGAR FRACTION THREE QUARTERS"
        txt = txt.replace('¾', '&frac34;');

        // "U+000BF", "INVERTED QUESTION MARK"
        txt = txt.replace('¿', '&iquest;');

        // "U+000C0", "LATIN CAPITAL LETTER A WITH GRAVE"
        txt = txt.replace('À', '&Agrave;');

        // "U+000C1", "LATIN CAPITAL LETTER A WITH ACUTE"
        txt = txt.replace('Á', '&Aacute;');

        // "U+000C2", "LATIN CAPITAL LETTER A WITH CIRCUMFLEX"
        txt = txt.replace('Â', '&Acirc;');

        // "U+000C3", "LATIN CAPITAL LETTER A WITH TILDE"
        txt = txt.replace('Ã', '&Atilde;');

        // "U+000C4", "LATIN CAPITAL LETTER A WITH DIAERESIS"
        txt = txt.replace('Ä', '&Auml;');

        // "U+000C5", "LATIN CAPITAL LETTER A WITH RING ABOVE"
        txt = txt.replace('Å', '&Aring;');

        // "U+000C6", "LATIN CAPITAL LETTER AE"
        txt = txt.replace('Æ', '&AElig;');

        // "U+000C7", "LATIN CAPITAL LETTER C WITH CEDILLA"
        txt = txt.replace('Ç', '&Ccedil;');

        // "U+000C8", "LATIN CAPITAL LETTER E WITH GRAVE"
        txt = txt.replace('È', '&Egrave;');

        // "U+000C9", "LATIN CAPITAL LETTER E WITH ACUTE"
        txt = txt.replace('É', '&Eacute;');

        // "U+000CA", "LATIN CAPITAL LETTER E WITH CIRCUMFLEX"
        txt = txt.replace('Ê', '&Ecirc;');

        // "U+000CB", "LATIN CAPITAL LETTER E WITH DIAERESIS"
        txt = txt.replace('Ë', '&Euml;');

        // "U+000CC", "LATIN CAPITAL LETTER I WITH GRAVE"
        txt = txt.replace('Ì', '&Igrave;');

        // "U+000CD", "LATIN CAPITAL LETTER I WITH ACUTE"
        txt = txt.replace('Í', '&Iacute;');

        // "U+000CE", "LATIN CAPITAL LETTER I WITH CIRCUMFLEX"
        txt = txt.replace('Î', '&Icirc;');

        // "U+000CF", "LATIN CAPITAL LETTER I WITH DIAERESIS"
        txt = txt.replace('Ï', '&Iuml;');

        // "U+000D0", "LATIN CAPITAL LETTER ETH"
        txt = txt.replace('Ð', '&ETH;');

        // "U+000D1", "LATIN CAPITAL LETTER N WITH TILDE"
        txt = txt.replace('Ñ', '&Ntilde;');

        // "U+000D2", "LATIN CAPITAL LETTER O WITH GRAVE"
        txt = txt.replace('Ò', '&Ograve;');

        // "U+000D3", "LATIN CAPITAL LETTER O WITH ACUTE"
        txt = txt.replace('Ó', '&Oacute;');

        // "U+000D4", "LATIN CAPITAL LETTER O WITH CIRCUMFLEX"
        txt = txt.replace('Ô', '&Ocirc;');

        // "U+000D5", "LATIN CAPITAL LETTER O WITH TILDE"
        txt = txt.replace('Õ', '&Otilde;');

        // "U+000D6", "LATIN CAPITAL LETTER O WITH DIAERESIS"
        txt = txt.replace('Ö', '&Ouml;');

        // "U+000D7", "MULTIPLICATION SIGN"
        txt = txt.replace('×', '&times;');

        // "U+000D8", "LATIN CAPITAL LETTER O WITH STROKE"
        txt = txt.replace('Ø', '&Oslash;');

        // "U+000D9", "LATIN CAPITAL LETTER U WITH GRAVE"
        txt = txt.replace('Ù', '&Ugrave;');

        // "U+000DA", "LATIN CAPITAL LETTER U WITH ACUTE"
        txt = txt.replace('Ú', '&Uacute;');

        // "U+000DB", "LATIN CAPITAL LETTER U WITH CIRCUMFLEX"
        txt = txt.replace('Û', '&Ucirc;');

        // "U+000DC", "LATIN CAPITAL LETTER U WITH DIAERESIS"
        txt = txt.replace('Ü', '&Uuml;');

        // "U+000DD", "LATIN CAPITAL LETTER Y WITH ACUTE"
        txt = txt.replace('Ý', '&Yacute;');

        // "U+000DE", "LATIN CAPITAL LETTER THORN"
        txt = txt.replace('Þ', '&THORN;');

        // "U+000DF", "LATIN SMALL LETTER SHARP S"
        txt = txt.replace('ß', '&szlig;');

        // "U+000E0", "LATIN SMALL LETTER A WITH GRAVE"
        txt = txt.replace('à', '&agrave;');

        // "U+000E1", "LATIN SMALL LETTER A WITH ACUTE"
        txt = txt.replace('á', '&aacute;');

        // "U+000E2", "LATIN SMALL LETTER A WITH CIRCUMFLEX"
        txt = txt.replace('â', '&acirc;');

        // "U+000E3", "LATIN SMALL LETTER A WITH TILDE"
        txt = txt.replace('ã', '&atilde;');

        // "U+000E4", "LATIN SMALL LETTER A WITH DIAERESIS"
        txt = txt.replace('ä', '&auml;');

        // "U+000E5", "LATIN SMALL LETTER A WITH RING ABOVE"
        txt = txt.replace('å', '&aring;');

        // "U+000E6", "LATIN SMALL LETTER AE"
        txt = txt.replace('æ', '&aelig;');

        // "U+000E7", "LATIN SMALL LETTER C WITH CEDILLA"
        txt = txt.replace('ç', '&ccedil;');

        // "U+000E8", "LATIN SMALL LETTER E WITH GRAVE"
        txt = txt.replace('è', '&egrave;');

        // "U+000E9", "LATIN SMALL LETTER E WITH ACUTE"
        txt = txt.replace('é', '&eacute;');

        // "U+000EA", "LATIN SMALL LETTER E WITH CIRCUMFLEX"
        txt = txt.replace('ê', '&ecirc;');

        // "U+000EB", "LATIN SMALL LETTER E WITH DIAERESIS"
        txt = txt.replace('ë', '&euml;');

        // "U+000EC", "LATIN SMALL LETTER I WITH GRAVE"
        txt = txt.replace('ì', '&igrave;');

        // "U+000ED", "LATIN SMALL LETTER I WITH ACUTE"
        txt = txt.replace('í', '&iacute;');

        // "U+000EE", "LATIN SMALL LETTER I WITH CIRCUMFLEX"
        txt = txt.replace('î', '&icirc;');

        // "U+000EF", "LATIN SMALL LETTER I WITH DIAERESIS"
        txt = txt.replace('ï', '&iuml;');

        // "U+000F0", "LATIN SMALL LETTER ETH"
        txt = txt.replace('ð', '&eth;');

        // "U+000F1", "LATIN SMALL LETTER N WITH TILDE"
        txt = txt.replace('ñ', '&ntilde;');

        // "U+000F2", "LATIN SMALL LETTER O WITH GRAVE"
        txt = txt.replace('ò', '&ograve;');

        // "U+000F3", "LATIN SMALL LETTER O WITH ACUTE"
        txt = txt.replace('ó', '&oacute;');

        // "U+000F4", "LATIN SMALL LETTER O WITH CIRCUMFLEX"
        txt = txt.replace('ô', '&ocirc;');

        // "U+000F5", "LATIN SMALL LETTER O WITH TILDE"
        txt = txt.replace('õ', '&otilde;');

        // "U+000F6", "LATIN SMALL LETTER O WITH DIAERESIS"
        txt = txt.replace('ö', '&ouml;');

        // "U+000F7", "DIVISION SIGN"
        txt = txt.replace('÷', '&divide;');

        // "U+000F8", "LATIN SMALL LETTER O WITH STROKE"
        txt = txt.replace('ø', '&oslash;');

        // "U+000F9", "LATIN SMALL LETTER U WITH GRAVE"
        txt = txt.replace('ù', '&ugrave;');

        // "U+000FA", "LATIN SMALL LETTER U WITH ACUTE"
        txt = txt.replace('ú', '&uacute;');

        // "U+000FB", "LATIN SMALL LETTER U WITH CIRCUMFLEX"
        txt = txt.replace('û', '&ucirc;');

        // "U+000FC", "LATIN SMALL LETTER U WITH DIAERESIS"
        txt = txt.replace('ü', '&uuml;');

        // "U+000FD", "LATIN SMALL LETTER Y WITH ACUTE"
        txt = txt.replace('ý', '&yacute;');

        // "U+000FE", "LATIN SMALL LETTER THORN"
        txt = txt.replace('þ', '&thorn;');

        // "U+000FF", "LATIN SMALL LETTER Y WITH DIAERESIS"
        txt = txt.replace('ÿ', '&yuml;');

        // "U+00152", "LATIN CAPITAL LIGATURE OE"
        txt = txt.replace('Œ', '&OElig;');

        // "U+00153", "LATIN SMALL LIGATURE OE"
        txt = txt.replace('œ', '&oelig;');

        // "U+00160", "LATIN CAPITAL LETTER S WITH CARON"
        txt = txt.replace('Š', '&Scaron;');

        // "U+00161", "LATIN SMALL LETTER S WITH CARON"
        txt = txt.replace('š', '&scaron;');

        // "U+00178", "LATIN CAPITAL LETTER Y WITH DIAERESIS"
        txt = txt.replace('Ÿ', '&Yuml;');

        // "U+00192", "LATIN SMALL LETTER F WITH HOOK"
        txt = txt.replace('ƒ', '&fnof;');

        // "U+002C6", "MODIFIER LETTER CIRCUMFLEX ACCENT"
        txt = txt.replace('ˆ', '&circ;');

        // "U+002DC", "SMALL TILDE"
        txt = txt.replace('˜', '&tilde;');

        // "U+00391", "GREEK CAPITAL LETTER ALPHA"
        txt = txt.replace('Α', '&Alpha;');

        // "U+00392", "GREEK CAPITAL LETTER BETA"
        txt = txt.replace('Β', '&Beta;');

        // "U+00393", "GREEK CAPITAL LETTER GAMMA"
        txt = txt.replace('Γ', '&Gamma;');

        // "U+00394", "GREEK CAPITAL LETTER DELTA"
        txt = txt.replace('Δ', '&Delta;');

        // "U+00395", "GREEK CAPITAL LETTER EPSILON"
        txt = txt.replace('Ε', '&Epsilon;');

        // "U+00396", "GREEK CAPITAL LETTER ZETA"
        txt = txt.replace('Ζ', '&Zeta;');

        // "U+00397", "GREEK CAPITAL LETTER ETA"
        txt = txt.replace('Η', '&Eta;');

        // "U+00398", "GREEK CAPITAL LETTER THETA"
        txt = txt.replace('Θ', '&Theta;');

        // "U+00399", "GREEK CAPITAL LETTER IOTA"
        txt = txt.replace('Ι', '&Iota;');

        // "U+0039A", "GREEK CAPITAL LETTER KAPPA"
        txt = txt.replace('Κ', '&Kappa;');

        // "U+0039B", "GREEK CAPITAL LETTER LAMDA"
        txt = txt.replace('Λ', '&Lambda;');

        // "U+0039C", "GREEK CAPITAL LETTER MU"
        txt = txt.replace('Μ', '&Mu;');

        // "U+0039D", "GREEK CAPITAL LETTER NU"
        txt = txt.replace('Ν', '&Nu;');

        // "U+0039E", "GREEK CAPITAL LETTER XI"
        txt = txt.replace('Ξ', '&Xi;');

        // "U+0039F", "GREEK CAPITAL LETTER OMICRON"
        txt = txt.replace('Ο', '&Omicron;');

        // "U+003A0", "GREEK CAPITAL LETTER PI"
        txt = txt.replace('Π', '&Pi;');

        // "U+003A1", "GREEK CAPITAL LETTER RHO"
        txt = txt.replace('Ρ', '&Rho;');

        // "U+003A3", "GREEK CAPITAL LETTER SIGMA"
        txt = txt.replace('Σ', '&Sigma;');

        // "U+003A4", "GREEK CAPITAL LETTER TAU"
        txt = txt.replace('Τ', '&Tau;');

        // "U+003A5", "GREEK CAPITAL LETTER UPSILON"
        txt = txt.replace('Υ', '&Upsilon;');

        // "U+003A6", "GREEK CAPITAL LETTER PHI"
        txt = txt.replace('Φ', '&Phi;');

        // "U+003A7", "GREEK CAPITAL LETTER CHI"
        txt = txt.replace('Χ', '&Chi;');

        // "U+003A8", "GREEK CAPITAL LETTER PSI"
        txt = txt.replace('Ψ', '&Psi;');

        // "U+003A9", "GREEK CAPITAL LETTER OMEGA"
        txt = txt.replace('Ω', '&Omega;');

        // "U+003B1", "GREEK SMALL LETTER ALPHA"
        txt = txt.replace('α', '&alpha;');

        // "U+003B2", "GREEK SMALL LETTER BETA"
        txt = txt.replace('β', '&beta;');

        // "U+003B3", "GREEK SMALL LETTER GAMMA"
        txt = txt.replace('γ', '&gamma;');

        // "U+003B4", "GREEK SMALL LETTER DELTA"
        txt = txt.replace('δ', '&delta;');

        // "U+003B5", "GREEK SMALL LETTER EPSILON"
        txt = txt.replace('ε', '&epsiv;');

        // "U+003B6", "GREEK SMALL LETTER ZETA"
        txt = txt.replace('ζ', '&zeta;');

        // "U+003B7", "GREEK SMALL LETTER ETA"
        txt = txt.replace('η', '&eta;');

        // "U+003B8", "GREEK SMALL LETTER THETA"
        txt = txt.replace('θ', '&theta;');

        // "U+003B9", "GREEK SMALL LETTER IOTA"
        txt = txt.replace('ι', '&iota;');

        // "U+003BA", "GREEK SMALL LETTER KAPPA"
        txt = txt.replace('κ', '&kappa;');

        // "U+003BB", "GREEK SMALL LETTER LAMDA"
        txt = txt.replace('λ', '&lambda;');

        // "U+003BC", "GREEK SMALL LETTER MU"
        txt = txt.replace('μ', '&mu;');

        // "U+003BD", "GREEK SMALL LETTER NU"
        txt = txt.replace('ν', '&nu;');

        // "U+003BE", "GREEK SMALL LETTER XI"
        txt = txt.replace('ξ', '&xi;');

        // "U+003BF", "GREEK SMALL LETTER OMICRON"
        txt = txt.replace('ο', '&omicron;');

        // "U+003C0", "GREEK SMALL LETTER PI"
        txt = txt.replace('π', '&pi;');

        // "U+003C1", "GREEK SMALL LETTER RHO"
        txt = txt.replace('ρ', '&rho;');

        // "U+003C2", "GREEK SMALL LETTER FINAL SIGMA"
        txt = txt.replace('ς', '&sigmav;');

        // "U+003C3", "GREEK SMALL LETTER SIGMA"
        txt = txt.replace('σ', '&sigma;');

        // "U+003C4", "GREEK SMALL LETTER TAU"
        txt = txt.replace('τ', '&tau;');

        // "U+003C5", "GREEK SMALL LETTER UPSILON"
        txt = txt.replace('υ', '&upsi;');

        // "U+003C6", "GREEK SMALL LETTER PHI"
        txt = txt.replace('φ', '&phi;');

        // "U+003C7", "GREEK SMALL LETTER CHI"
        txt = txt.replace('χ', '&chi;');

        // "U+003C8", "GREEK SMALL LETTER PSI"
        txt = txt.replace('ψ', '&psi;');

        // "U+003C9", "GREEK SMALL LETTER OMEGA"
        txt = txt.replace('ω', '&omega;');

        // "U+003D1", "GREEK THETA SYMBOL"
        txt = txt.replace('ϑ', '&thetav;');

        // "U+003D2", "GREEK UPSILON WITH HOOK SYMBOL"
        txt = txt.replace('ϒ', '&Upsi;');

        // "U+003D6", "GREEK PI SYMBOL"
        txt = txt.replace('ϖ', '&piv;');

        // "U+02002", "EN SPACE"
        txt = txt.replace(' ', '&ensp;');

        // "U+02003", "EM SPACE"
        txt = txt.replace(' ', '&emsp;');

        // "U+02009", "THIN SPACE"
        txt = txt.replace(' ', '&thinsp;');

        // "U+0200C", "ZERO WIDTH NON-JOINER"
        txt = txt.replace('‌', '&zwnj;');

        // "U+0200D", "ZERO WIDTH JOINER"
        txt = txt.replace('‍', '&zwj;');

        // "U+0200E", "LEFT-TO-RIGHT MARK"
        txt = txt.replace('‎', '&lrm;');

        // "U+0200F", "RIGHT-TO-LEFT MARK"
        txt = txt.replace('‏', '&rlm;');

        // "U+02013", "EN DASH"
        txt = txt.replace('–', '&ndash;');

        // "U+02014", "EM DASH"
        txt = txt.replace('—', '&mdash;');

        // "U+02018", "LEFT SINGLE QUOTATION MARK"
        txt = txt.replace('‘', '&lsquo;');

        // "U+02019", "RIGHT SINGLE QUOTATION MARK"
        txt = txt.replace('’', '&rsquo;');

        // "U+0201A", "SINGLE LOW-9 QUOTATION MARK"
        txt = txt.replace('‚', '&lsquor;');

        // "U+0201C", "LEFT DOUBLE QUOTATION MARK"
        txt = txt.replace('“', '&ldquo;');

        // "U+0201D", "RIGHT DOUBLE QUOTATION MARK"
        txt = txt.replace('”', '&rdquo;');

        // "U+0201E", "DOUBLE LOW-9 QUOTATION MARK"
        txt = txt.replace('„', '&ldquor;');

        // "U+02020", "DAGGER"
        txt = txt.replace('†', '&dagger;');

        // "U+02021", "DOUBLE DAGGER"
        txt = txt.replace('‡', '&Dagger;');

        // "U+02022", "BULLET"
        txt = txt.replace('•', '&bull;');

        // "U+02026", "HORIZONTAL ELLIPSIS"
        txt = txt.replace('…', '&hellip;');

        // "U+02030", "PER MILLE SIGN"
        txt = txt.replace('‰', '&permil;');

        // "U+02032", "PRIME"
        txt = txt.replace('′', '&prime;');

        // "U+02033", "DOUBLE PRIME"
        txt = txt.replace('″', '&Prime;');

        // "U+02039", "SINGLE LEFT-POINTING ANGLE QUOTATION MARK"
        txt = txt.replace('‹', '&lsaquo;');

        // "U+0203A", "SINGLE RIGHT-POINTING ANGLE QUOTATION MARK"
        txt = txt.replace('›', '&rsaquo;');

        // "U+0203E", "OVERLINE"
        txt = txt.replace('‾', '&oline;');

        // "U+02044", "FRACTION SLASH"
        txt = txt.replace('⁄', '&frasl;');

        // "U+020AC", "EURO SIGN"
        txt = txt.replace('€', '&euro;');

        // "U+02111", "BLACK-LETTER CAPITAL I"
        txt = txt.replace('ℑ', '&image;');

        // "U+02118", "SCRIPT CAPITAL P"
        txt = txt.replace('℘', '&weierp;');

        // "U+0211C", "BLACK-LETTER CAPITAL R"
        txt = txt.replace('ℜ', '&real;');

        // "U+02122", "TRADE MARK SIGN"
        txt = txt.replace('™', '&trade;');

        // "U+02135", "ALEF SYMBOL"
        txt = txt.replace('ℵ', '&alefsym;');

        // "U+02190", "LEFTWARDS ARROW"
        txt = txt.replace('←', '&larr;');

        // "U+02191", "UPWARDS ARROW"
        txt = txt.replace('↑', '&uarr;');

        // "U+02192", "RIGHTWARDS ARROW"
        txt = txt.replace('→', '&rarr;');

        // "U+02193", "DOWNWARDS ARROW"
        txt = txt.replace('↓', '&darr;');

        // "U+02194", "LEFT RIGHT ARROW"
        txt = txt.replace('↔', '&harr;');

        // "U+021B5", "DOWNWARDS ARROW WITH CORNER LEFTWARDS"
        txt = txt.replace('↵', '&crarr;');

        // "U+021D0", "LEFTWARDS DOUBLE ARROW"
        txt = txt.replace('⇐', '&lArr;');

        // "U+021D1", "UPWARDS DOUBLE ARROW"
        txt = txt.replace('⇑', '&uArr;');

        // "U+021D2", "RIGHTWARDS DOUBLE ARROW"
        txt = txt.replace('⇒', '&rArr;');

        // "U+021D3", "DOWNWARDS DOUBLE ARROW"
        txt = txt.replace('⇓', '&dArr;');

        // "U+021D4", "LEFT RIGHT DOUBLE ARROW"
        txt = txt.replace('⇔', '&hArr;');

        // "U+02200", "FOR ALL"
        txt = txt.replace('∀', '&forall;');

        // "U+02202", "PARTIAL DIFFERENTIAL"
        txt = txt.replace('∂', '&part;');

        // "U+02203", "THERE EXISTS"
        txt = txt.replace('∃', '&exist;');

        // "U+02205", "EMPTY SET"
        txt = txt.replace('∅', '&empty;');

        // "U+02207", "NABLA"
        txt = txt.replace('∇', '&nabla;');

        // "U+02208", "ELEMENT OF"
        txt = txt.replace('∈', '&isin;');

        // "U+02209", "NOT AN ELEMENT OF"
        txt = txt.replace('∉', '&notin;');

        // "U+0220B", "CONTAINS AS MEMBER"
        txt = txt.replace('∋', '&niv;');

        // "U+0220F", "N-ARY PRODUCT"
        txt = txt.replace('∏', '&prod;');

        // "U+02211", "N-ARY SUMMATION"
        txt = txt.replace('∑', '&sum;');

        // "U+02212", "MINUS SIGN"
        txt = txt.replace('−', '&minus;');

        // "U+02217", "ASTERISK OPERATOR"
        txt = txt.replace('∗', '&lowast;');

        // "U+0221A", "SQUARE ROOT"
        txt = txt.replace('√', '&radic;');

        // "U+0221D", "PROPORTIONAL TO"
        txt = txt.replace('∝', '&prop;');

        // "U+0221E", "INFINITY"
        txt = txt.replace('∞', '&infin;');

        // "U+02220", "ANGLE"
        txt = txt.replace('∠', '&ang;');

        // "U+02227", "LOGICAL AND"
        txt = txt.replace('∧', '&and;');

        // "U+02228", "LOGICAL OR"
        txt = txt.replace('∨', '&or;');

        // "U+02229", "INTERSECTION"
        txt = txt.replace('∩', '&cap;');

        // "U+0222A", "UNION"
        txt = txt.replace('∪', '&cup;');

        // "U+0222B", "INTEGRAL"
        txt = txt.replace('∫', '&int;');

        // "U+02234", "THEREFORE"
        txt = txt.replace('∴', '&there4;');

        // "U+0223C", "TILDE OPERATOR"
        txt = txt.replace('∼', '&sim;');

        // "U+02245", "APPROXIMATELY EQUAL TO"
        txt = txt.replace('≅', '&cong;');

        // "U+02248", "ALMOST EQUAL TO"
        txt = txt.replace('≈', '&asymp;');

        // "U+02260", "NOT EQUAL TO"
        txt = txt.replace('≠', '&ne;');

        // "U+02261", "IDENTICAL TO"
        txt = txt.replace('≡', '&equiv;');

        // "U+02264", "LESS-THAN OR EQUAL TO"
        txt = txt.replace('≤', '&le;');

        // "U+02265", "GREATER-THAN OR EQUAL TO"
        txt = txt.replace('≥', '&ge;');

        // "U+02282", "SUBSET OF"
        txt = txt.replace('⊂', '&sub;');

        // "U+02283", "SUPERSET OF"
        txt = txt.replace('⊃', '&sup;');

        // "U+02284", "NOT A SUBSET OF"
        txt = txt.replace('⊄', '&nsub;');

        // "U+02286", "SUBSET OF OR EQUAL TO"
        txt = txt.replace('⊆', '&sube;');

        // "U+02287", "SUPERSET OF OR EQUAL TO"
        txt = txt.replace('⊇', '&supe;');

        // "U+02295", "CIRCLED PLUS"
        txt = txt.replace('⊕', '&oplus;');

        // "U+02297", "CIRCLED TIMES"
        txt = txt.replace('⊗', '&otimes;');

        // "U+022A5", "UP TACK"
        txt = txt.replace('⊥', '&bottom;');

        // "U+022C5", "DOT OPERATOR"
        txt = txt.replace('⋅', '&sdot;');

        // "U+02308", "LEFT CEILING"
        txt = txt.replace('⌈', '&lceil;');

        // "U+02309", "RIGHT CEILING"
        txt = txt.replace('⌉', '&rceil;');

        // "U+0230A", "LEFT FLOOR"
        txt = txt.replace('⌊', '&lfloor;');

        // "U+0230B", "RIGHT FLOOR"
        txt = txt.replace('⌋', '&rfloor;');

        // "U+025CA", "LOZENGE"
        txt = txt.replace('◊', '&loz;');

        // "U+02660", "BLACK SPADE SUIT"
        txt = txt.replace('♠', '&spades;');

        // "U+02663", "BLACK CLUB SUIT"
        txt = txt.replace('♣', '&clubs;');

        // "U+02665", "BLACK HEART SUIT"
        txt = txt.replace('♥', '&hearts;');

        // "U+02666", "BLACK DIAMOND SUIT"
        txt = txt.replace('♦', '&diams;');

        // "U+027E8", "MATHEMATICAL LEFT ANGLE BRACKET"
        txt = txt.replace('⟨', '&lang;');

        // "U+027E9", "MATHEMATICAL RIGHT ANGLE BRACKET"
        txt = txt.replace('⟩', '&rang;');

        return txt;
    }

    /**
     * 入力される文字列内の文字や記号を文字実体参照に置きかえます。ベーシック版です。
     * @param sources 置きかえられる文字列の配列。
     * @returns 置きかえられた文字列の配列。
     */
    public static convertToCharacterEntityReferenceAllBasic(sources: string[]): string[] {
        for (let i = 0; i < sources.length; i++) {
            sources[i] = this.convertToCharacterEntityReferenceBasic(sources[i]);
        }

        return sources;
    }

    /**
     * 入力される文字列内の文字や記号を文字実体参照に置きかえます。
     * @param source 置きかえられる文字列。
     * @param escapeSequenceFlag エスケープシーケンスを置きかえるフラグ。
     * @returns 置きかえられた文字列。
     */
    public static convertToCharacterEntityReference(source: string, escapeSequenceFlag: boolean): string {
        let txt = source;

        // "U+00026", "AMPERSAND"
        // "U+0003B", "SEMICOLON"
        txt = txt.replace('&', '&amp');
        txt = txt.replace(';', '&semi;');
        txt = txt.replace('&amp', '&amp;');

        if (escapeSequenceFlag) {
            // "U+00009", "CHARACTER TABULATION"
            txt = txt.replace('\t', '&Tab;');

            // "U+0000A", "LINE FEED (LF)"
            txt = txt.replace('\n', '&NewLine;');
        }

        // "U+00021", "EXCLAMATION MARK"
        txt = txt.replace('!', '&excl;');

        // "U+00022", "QUOTATION MARK"
        txt = txt.replace('"', '&quot;');

        // "U+00023", "NUMBER SIGN"
        txt = txt.replace('#', '&num;');

        // "U+00024", "DOLLAR SIGN"
        txt = txt.replace('$', '&dollar;');

        // "U+00025", "PERCENT SIGN"
        txt = txt.replace('%', '&percnt;');

        // "U+00027", "APOSTROPHE"
        txt = txt.replace("'", '&apos;');

        // "U+00028", "LEFT PARENTHESIS"
        txt = txt.replace('(', '&lpar;');

        // "U+00029", "RIGHT PARENTHESIS"
        txt = txt.replace(')', '&rpar;');

        // "U+0002A", "ASTERISK"
        txt = txt.replace('*', '&ast;');

        // "U+0002B", "PLUS SIGN"
        txt = txt.replace('+', '&plus;');

        // "U+0002C", "COMMA"
        txt = txt.replace(',', '&comma;');

        // "U+0002E", "FULL STOP"
        txt = txt.replace('.', '&period;');

        // "U+0002F", "SOLIDUS"
        txt = txt.replace('/', '&sol;');

        // "U+0003A", "COLON"
        txt = txt.replace(':', '&colon;');

        // "U+0003C", "LESS-THAN SIGN"
        txt = txt.replace('<', '&lt;');

        // "U+0003D", "EQUALS SIGN"
        txt = txt.replace('=', '&equals;');

        // "U+0003E", "GREATER-THAN SIGN"
        txt = txt.replace('>', '&gt;');

        // "U+0003F", "QUESTION MARK"
        txt = txt.replace('?', '&quest;');

        // "U+00040", "COMMERCIAL AT"
        txt = txt.replace('@', '&commat;');

        // "U+0005B", "LEFT SQUARE BRACKET"
        txt = txt.replace('[', '&lsqb;');

        // "U+0005C", "REVERSE SOLIDUS"
        txt = txt.replace('\\', '&bsol;');

        // "U+0005D", "RIGHT SQUARE BRACKET"
        txt = txt.replace(']', '&rsqb;');

        // "U+0005E", "CIRCUMFLEX ACCENT"
        txt = txt.replace('^', '&Hat;');

        // "U+0005F", "LOW LINE"
        txt = txt.replace('_', '&lowbar;');

        // "U+00060", "GRAVE ACCENT"
        txt = txt.replace('`', '&grave;');

        // "U+0007B", "LEFT CURLY BRACKET"
        txt = txt.replace('{', '&lcub;');

        // "U+0007C", "VERTICAL LINE"
        txt = txt.replace('|', '&verbar;');

        // "U+0007D", "RIGHT CURLY BRACKET"
        txt = txt.replace('}', '&rcub;');

        // "U+000A0", "NO-BREAK SPACE"
        txt = txt.replace(' ', '&nbsp;');

        // "U+000A1", "INVERTED EXCLAMATION MARK"
        txt = txt.replace('¡', '&iexcl;');

        // "U+000A2", "CENT SIGN"
        txt = txt.replace('¢', '&cent;');

        // "U+000A3", "POUND SIGN"
        txt = txt.replace('£', '&pound;');

        // "U+000A4", "CURRENCY SIGN"
        txt = txt.replace('¤', '&curren;');

        // "U+000A5", "YEN SIGN"
        txt = txt.replace('¥', '&yen;');

        // "U+000A6", "BROKEN BAR"
        txt = txt.replace('¦', '&brvbar;');

        // "U+000A7", "SECTION SIGN"
        txt = txt.replace('§', '&sect;');

        // "U+000A8", "DIAERESIS"
        txt = txt.replace('¨', '&Dot;');

        // "U+000A9", "COPYRIGHT SIGN"
        txt = txt.replace('©', '&copy;');

        // "U+000AA", "FEMININE ORDINAL INDICATOR"
        txt = txt.replace('ª', '&ordf;');

        // "U+000AB", "LEFT-POINTING DOUBLE ANGLE QUOTATION MARK"
        txt = txt.replace('«', '&laquo;');

        // "U+000AC", "NOT SIGN"
        txt = txt.replace('¬', '&not;');

        // "U+000AD", "SOFT HYPHEN"
        txt = txt.replace('­', '&shy;');

        // "U+000AE", "REGISTERED SIGN"
        txt = txt.replace('®', '&reg;');

        // "U+000AF", "MACRON"
        txt = txt.replace('¯', '&macr;');

        // "U+000B0", "DEGREE SIGN"
        txt = txt.replace('°', '&deg;');

        // "U+000B1", "PLUS-MINUS SIGN"
        txt = txt.replace('±', '&plusmn;');

        // "U+000B2", "SUPERSCRIPT TWO"
        txt = txt.replace('²', '&sup2;');

        // "U+000B3", "SUPERSCRIPT THREE"
        txt = txt.replace('³', '&sup3;');

        // "U+000B4", "ACUTE ACCENT"
        txt = txt.replace('´', '&acute;');

        // "U+000B5", "MICRO SIGN"
        txt = txt.replace('µ', '&micro;');

        // "U+000B6", "PILCROW SIGN"
        txt = txt.replace('¶', '&para;');

        // "U+000B7", "MIDDLE DOT"
        txt = txt.replace('·', '&middot;');

        // "U+000B8", "CEDILLA"
        txt = txt.replace('¸', '&cedil;');

        // "U+000B9", "SUPERSCRIPT ONE"
        txt = txt.replace('¹', '&sup1;');

        // "U+000BA", "MASCULINE ORDINAL INDICATOR"
        txt = txt.replace('º', '&ordm;');

        // "U+000BB", "RIGHT-POINTING DOUBLE ANGLE QUOTATION MARK"
        txt = txt.replace('»', '&raquo;');

        // "U+000BC", "VULGAR FRACTION ONE QUARTER"
        txt = txt.replace('¼', '&frac14;');

        // "U+000BD", "VULGAR FRACTION ONE HALF"
        txt = txt.replace('½', '&frac12;');

        // "U+000BE", "VULGAR FRACTION THREE QUARTERS"
        txt = txt.replace('¾', '&frac34;');

        // "U+000BF", "INVERTED QUESTION MARK"
        txt = txt.replace('¿', '&iquest;');

        // "U+000C0", "LATIN CAPITAL LETTER A WITH GRAVE"
        txt = txt.replace('À', '&Agrave;');

        // "U+000C1", "LATIN CAPITAL LETTER A WITH ACUTE"
        txt = txt.replace('Á', '&Aacute;');

        // "U+000C2", "LATIN CAPITAL LETTER A WITH CIRCUMFLEX"
        txt = txt.replace('Â', '&Acirc;');

        // "U+000C3", "LATIN CAPITAL LETTER A WITH TILDE"
        txt = txt.replace('Ã', '&Atilde;');

        // "U+000C4", "LATIN CAPITAL LETTER A WITH DIAERESIS"
        txt = txt.replace('Ä', '&Auml;');

        // "U+000C5", "LATIN CAPITAL LETTER A WITH RING ABOVE"
        txt = txt.replace('Å', '&Aring;');

        // "U+000C6", "LATIN CAPITAL LETTER AE"
        txt = txt.replace('Æ', '&AElig;');

        // "U+000C7", "LATIN CAPITAL LETTER C WITH CEDILLA"
        txt = txt.replace('Ç', '&Ccedil;');

        // "U+000C8", "LATIN CAPITAL LETTER E WITH GRAVE"
        txt = txt.replace('È', '&Egrave;');

        // "U+000C9", "LATIN CAPITAL LETTER E WITH ACUTE"
        txt = txt.replace('É', '&Eacute;');

        // "U+000CA", "LATIN CAPITAL LETTER E WITH CIRCUMFLEX"
        txt = txt.replace('Ê', '&Ecirc;');

        // "U+000CB", "LATIN CAPITAL LETTER E WITH DIAERESIS"
        txt = txt.replace('Ë', '&Euml;');

        // "U+000CC", "LATIN CAPITAL LETTER I WITH GRAVE"
        txt = txt.replace('Ì', '&Igrave;');

        // "U+000CD", "LATIN CAPITAL LETTER I WITH ACUTE"
        txt = txt.replace('Í', '&Iacute;');

        // "U+000CE", "LATIN CAPITAL LETTER I WITH CIRCUMFLEX"
        txt = txt.replace('Î', '&Icirc;');

        // "U+000CF", "LATIN CAPITAL LETTER I WITH DIAERESIS"
        txt = txt.replace('Ï', '&Iuml;');

        // "U+000D0", "LATIN CAPITAL LETTER ETH"
        txt = txt.replace('Ð', '&ETH;');

        // "U+000D1", "LATIN CAPITAL LETTER N WITH TILDE"
        txt = txt.replace('Ñ', '&Ntilde;');

        // "U+000D2", "LATIN CAPITAL LETTER O WITH GRAVE"
        txt = txt.replace('Ò', '&Ograve;');

        // "U+000D3", "LATIN CAPITAL LETTER O WITH ACUTE"
        txt = txt.replace('Ó', '&Oacute;');

        // "U+000D4", "LATIN CAPITAL LETTER O WITH CIRCUMFLEX"
        txt = txt.replace('Ô', '&Ocirc;');

        // "U+000D5", "LATIN CAPITAL LETTER O WITH TILDE"
        txt = txt.replace('Õ', '&Otilde;');

        // "U+000D6", "LATIN CAPITAL LETTER O WITH DIAERESIS"
        txt = txt.replace('Ö', '&Ouml;');

        // "U+000D7", "MULTIPLICATION SIGN"
        txt = txt.replace('×', '&times;');

        // "U+000D8", "LATIN CAPITAL LETTER O WITH STROKE"
        txt = txt.replace('Ø', '&Oslash;');

        // "U+000D9", "LATIN CAPITAL LETTER U WITH GRAVE"
        txt = txt.replace('Ù', '&Ugrave;');

        // "U+000DA", "LATIN CAPITAL LETTER U WITH ACUTE"
        txt = txt.replace('Ú', '&Uacute;');

        // "U+000DB", "LATIN CAPITAL LETTER U WITH CIRCUMFLEX"
        txt = txt.replace('Û', '&Ucirc;');

        // "U+000DC", "LATIN CAPITAL LETTER U WITH DIAERESIS"
        txt = txt.replace('Ü', '&Uuml;');

        // "U+000DD", "LATIN CAPITAL LETTER Y WITH ACUTE"
        txt = txt.replace('Ý', '&Yacute;');

        // "U+000DE", "LATIN CAPITAL LETTER THORN"
        txt = txt.replace('Þ', '&THORN;');

        // "U+000DF", "LATIN SMALL LETTER SHARP S"
        txt = txt.replace('ß', '&szlig;');

        // "U+000E0", "LATIN SMALL LETTER A WITH GRAVE"
        txt = txt.replace('à', '&agrave;');

        // "U+000E1", "LATIN SMALL LETTER A WITH ACUTE"
        txt = txt.replace('á', '&aacute;');

        // "U+000E2", "LATIN SMALL LETTER A WITH CIRCUMFLEX"
        txt = txt.replace('â', '&acirc;');

        // "U+000E3", "LATIN SMALL LETTER A WITH TILDE"
        txt = txt.replace('ã', '&atilde;');

        // "U+000E4", "LATIN SMALL LETTER A WITH DIAERESIS"
        txt = txt.replace('ä', '&auml;');

        // "U+000E5", "LATIN SMALL LETTER A WITH RING ABOVE"
        txt = txt.replace('å', '&aring;');

        // "U+000E6", "LATIN SMALL LETTER AE"
        txt = txt.replace('æ', '&aelig;');

        // "U+000E7", "LATIN SMALL LETTER C WITH CEDILLA"
        txt = txt.replace('ç', '&ccedil;');

        // "U+000E8", "LATIN SMALL LETTER E WITH GRAVE"
        txt = txt.replace('è', '&egrave;');

        // "U+000E9", "LATIN SMALL LETTER E WITH ACUTE"
        txt = txt.replace('é', '&eacute;');

        // "U+000EA", "LATIN SMALL LETTER E WITH CIRCUMFLEX"
        txt = txt.replace('ê', '&ecirc;');

        // "U+000EB", "LATIN SMALL LETTER E WITH DIAERESIS"
        txt = txt.replace('ë', '&euml;');

        // "U+000EC", "LATIN SMALL LETTER I WITH GRAVE"
        txt = txt.replace('ì', '&igrave;');

        // "U+000ED", "LATIN SMALL LETTER I WITH ACUTE"
        txt = txt.replace('í', '&iacute;');

        // "U+000EE", "LATIN SMALL LETTER I WITH CIRCUMFLEX"
        txt = txt.replace('î', '&icirc;');

        // "U+000EF", "LATIN SMALL LETTER I WITH DIAERESIS"
        txt = txt.replace('ï', '&iuml;');

        // "U+000F0", "LATIN SMALL LETTER ETH"
        txt = txt.replace('ð', '&eth;');

        // "U+000F1", "LATIN SMALL LETTER N WITH TILDE"
        txt = txt.replace('ñ', '&ntilde;');

        // "U+000F2", "LATIN SMALL LETTER O WITH GRAVE"
        txt = txt.replace('ò', '&ograve;');

        // "U+000F3", "LATIN SMALL LETTER O WITH ACUTE"
        txt = txt.replace('ó', '&oacute;');

        // "U+000F4", "LATIN SMALL LETTER O WITH CIRCUMFLEX"
        txt = txt.replace('ô', '&ocirc;');

        // "U+000F5", "LATIN SMALL LETTER O WITH TILDE"
        txt = txt.replace('õ', '&otilde;');

        // "U+000F6", "LATIN SMALL LETTER O WITH DIAERESIS"
        txt = txt.replace('ö', '&ouml;');

        // "U+000F7", "DIVISION SIGN"
        txt = txt.replace('÷', '&divide;');

        // "U+000F8", "LATIN SMALL LETTER O WITH STROKE"
        txt = txt.replace('ø', '&oslash;');

        // "U+000F9", "LATIN SMALL LETTER U WITH GRAVE"
        txt = txt.replace('ù', '&ugrave;');

        // "U+000FA", "LATIN SMALL LETTER U WITH ACUTE"
        txt = txt.replace('ú', '&uacute;');

        // "U+000FB", "LATIN SMALL LETTER U WITH CIRCUMFLEX"
        txt = txt.replace('û', '&ucirc;');

        // "U+000FC", "LATIN SMALL LETTER U WITH DIAERESIS"
        txt = txt.replace('ü', '&uuml;');

        // "U+000FD", "LATIN SMALL LETTER Y WITH ACUTE"
        txt = txt.replace('ý', '&yacute;');

        // "U+000FE", "LATIN SMALL LETTER THORN"
        txt = txt.replace('þ', '&thorn;');

        // "U+000FF", "LATIN SMALL LETTER Y WITH DIAERESIS"
        txt = txt.replace('ÿ', '&yuml;');

        // "U+00100", "LATIN CAPITAL LETTER A WITH MACRON"
        txt = txt.replace('Ā', '&Amacr;');

        // "U+00101", "LATIN SMALL LETTER A WITH MACRON"
        txt = txt.replace('ā', '&amacr;');

        // "U+00102", "LATIN CAPITAL LETTER A WITH BREVE"
        txt = txt.replace('Ă', '&Abreve;');

        // "U+00103", "LATIN SMALL LETTER A WITH BREVE"
        txt = txt.replace('ă', '&abreve;');

        // "U+00104", "LATIN CAPITAL LETTER A WITH OGONEK"
        txt = txt.replace('Ą', '&Aogon;');

        // "U+00105", "LATIN SMALL LETTER A WITH OGONEK"
        txt = txt.replace('ą', '&aogon;');

        // "U+00106", "LATIN CAPITAL LETTER C WITH ACUTE"
        txt = txt.replace('Ć', '&Cacute;');

        // "U+00107", "LATIN SMALL LETTER C WITH ACUTE"
        txt = txt.replace('ć', '&cacute;');

        // "U+00108", "LATIN CAPITAL LETTER C WITH CIRCUMFLEX"
        txt = txt.replace('Ĉ', '&Ccirc;');

        // "U+00109", "LATIN SMALL LETTER C WITH CIRCUMFLEX"
        txt = txt.replace('ĉ', '&ccirc;');

        // "U+0010A", "LATIN CAPITAL LETTER C WITH DOT ABOVE"
        txt = txt.replace('Ċ', '&Cdot;');

        // "U+0010B", "LATIN SMALL LETTER C WITH DOT ABOVE"
        txt = txt.replace('ċ', '&cdot;');

        // "U+0010C", "LATIN CAPITAL LETTER C WITH CARON"
        txt = txt.replace('Č', '&Ccaron;');

        // "U+0010D", "LATIN SMALL LETTER C WITH CARON"
        txt = txt.replace('č', '&ccaron;');

        // "U+0010E", "LATIN CAPITAL LETTER D WITH CARON"
        txt = txt.replace('Ď', '&Dcaron;');

        // "U+0010F", "LATIN SMALL LETTER D WITH CARON"
        txt = txt.replace('ď', '&dcaron;');

        // "U+00110", "LATIN CAPITAL LETTER D WITH STROKE"
        txt = txt.replace('Đ', '&Dstrok;');

        // "U+00111", "LATIN SMALL LETTER D WITH STROKE"
        txt = txt.replace('đ', '&dstrok;');

        // "U+00112", "LATIN CAPITAL LETTER E WITH MACRON"
        txt = txt.replace('Ē', '&Emacr;');

        // "U+00113", "LATIN SMALL LETTER E WITH MACRON"
        txt = txt.replace('ē', '&emacr;');

        // "U+00116", "LATIN CAPITAL LETTER E WITH DOT ABOVE"
        txt = txt.replace('Ė', '&Edot;');

        // "U+00117", "LATIN SMALL LETTER E WITH DOT ABOVE"
        txt = txt.replace('ė', '&edot;');

        // "U+00118", "LATIN CAPITAL LETTER E WITH OGONEK"
        txt = txt.replace('Ę', '&Eogon;');

        // "U+00119", "LATIN SMALL LETTER E WITH OGONEK"
        txt = txt.replace('ę', '&eogon;');

        // "U+0011A", "LATIN CAPITAL LETTER E WITH CARON"
        txt = txt.replace('Ě', '&Ecaron;');

        // "U+0011B", "LATIN SMALL LETTER E WITH CARON"
        txt = txt.replace('ě', '&ecaron;');

        // "U+0011C", "LATIN CAPITAL LETTER G WITH CIRCUMFLEX"
        txt = txt.replace('Ĝ', '&Gcirc;');

        // "U+0011D", "LATIN SMALL LETTER G WITH CIRCUMFLEX"
        txt = txt.replace('ĝ', '&gcirc;');

        // "U+0011E", "LATIN CAPITAL LETTER G WITH BREVE"
        txt = txt.replace('Ğ', '&Gbreve;');

        // "U+0011F", "LATIN SMALL LETTER G WITH BREVE"
        txt = txt.replace('ğ', '&gbreve;');

        // "U+00120", "LATIN CAPITAL LETTER G WITH DOT ABOVE"
        txt = txt.replace('Ġ', '&Gdot;');

        // "U+00121", "LATIN SMALL LETTER G WITH DOT ABOVE"
        txt = txt.replace('ġ', '&gdot;');

        // "U+00122", "LATIN CAPITAL LETTER G WITH CEDILLA"
        txt = txt.replace('Ģ', '&Gcedil;');

        // "U+00124", "LATIN CAPITAL LETTER H WITH CIRCUMFLEX"
        txt = txt.replace('Ĥ', '&Hcirc;');

        // "U+00125", "LATIN SMALL LETTER H WITH CIRCUMFLEX"
        txt = txt.replace('ĥ', '&hcirc;');

        // "U+00126", "LATIN CAPITAL LETTER H WITH STROKE"
        txt = txt.replace('Ħ', '&Hstrok;');

        // "U+00127", "LATIN SMALL LETTER H WITH STROKE"
        txt = txt.replace('ħ', '&hstrok;');

        // "U+00128", "LATIN CAPITAL LETTER I WITH TILDE"
        txt = txt.replace('Ĩ', '&Itilde;');

        // "U+00129", "LATIN SMALL LETTER I WITH TILDE"
        txt = txt.replace('ĩ', '&itilde;');

        // "U+0012A", "LATIN CAPITAL LETTER I WITH MACRON"
        txt = txt.replace('Ī', '&Imacr;');

        // "U+0012B", "LATIN SMALL LETTER I WITH MACRON"
        txt = txt.replace('ī', '&imacr;');

        // "U+0012E", "LATIN CAPITAL LETTER I WITH OGONEK"
        txt = txt.replace('Į', '&Iogon;');

        // "U+0012F", "LATIN SMALL LETTER I WITH OGONEK"
        txt = txt.replace('į', '&iogon;');

        // "U+00130", "LATIN CAPITAL LETTER I WITH DOT ABOVE"
        txt = txt.replace('İ', '&Idot;');

        // "U+00131", "LATIN SMALL LETTER DOTLESS I"
        txt = txt.replace('ı', '&imath;');

        // "U+00132", "LATIN CAPITAL LIGATURE IJ"
        txt = txt.replace('Ĳ', '&IJlig;');

        // "U+00133", "LATIN SMALL LIGATURE IJ"
        txt = txt.replace('ĳ', '&ijlig;');

        // "U+00134", "LATIN CAPITAL LETTER J WITH CIRCUMFLEX"
        txt = txt.replace('Ĵ', '&Jcirc;');

        // "U+00135", "LATIN SMALL LETTER J WITH CIRCUMFLEX"
        txt = txt.replace('ĵ', '&jcirc;');

        // "U+00136", "LATIN CAPITAL LETTER K WITH CEDILLA"
        txt = txt.replace('Ķ', '&Kcedil;');

        // "U+00137", "LATIN SMALL LETTER K WITH CEDILLA"
        txt = txt.replace('ķ', '&kcedil;');

        // "U+00138", "LATIN SMALL LETTER KRA"
        txt = txt.replace('ĸ', '&kgreen;');

        // "U+00139", "LATIN CAPITAL LETTER L WITH ACUTE"
        txt = txt.replace('Ĺ', '&Lacute;');

        // "U+0013A", "LATIN SMALL LETTER L WITH ACUTE"
        txt = txt.replace('ĺ', '&lacute;');

        // "U+0013B", "LATIN CAPITAL LETTER L WITH CEDILLA"
        txt = txt.replace('Ļ', '&Lcedil;');

        // "U+0013C", "LATIN SMALL LETTER L WITH CEDILLA"
        txt = txt.replace('ļ', '&lcedil;');

        // "U+0013D", "LATIN CAPITAL LETTER L WITH CARON"
        txt = txt.replace('Ľ', '&Lcaron;');

        // "U+0013E", "LATIN SMALL LETTER L WITH CARON"
        txt = txt.replace('ľ', '&lcaron;');

        // "U+0013F", "LATIN CAPITAL LETTER L WITH MIDDLE DOT"
        txt = txt.replace('Ŀ', '&Lmidot;');

        // "U+00140", "LATIN SMALL LETTER L WITH MIDDLE DOT"
        txt = txt.replace('ŀ', '&lmidot;');

        // "U+00141", "LATIN CAPITAL LETTER L WITH STROKE"
        txt = txt.replace('Ł', '&Lstrok;');

        // "U+00142", "LATIN SMALL LETTER L WITH STROKE"
        txt = txt.replace('ł', '&lstrok;');

        // "U+00143", "LATIN CAPITAL LETTER N WITH ACUTE"
        txt = txt.replace('Ń', '&Nacute;');

        // "U+00144", "LATIN SMALL LETTER N WITH ACUTE"
        txt = txt.replace('ń', '&nacute;');

        // "U+00145", "LATIN CAPITAL LETTER N WITH CEDILLA"
        txt = txt.replace('Ņ', '&Ncedil;');

        // "U+00146", "LATIN SMALL LETTER N WITH CEDILLA"
        txt = txt.replace('ņ', '&ncedil;');

        // "U+00147", "LATIN CAPITAL LETTER N WITH CARON"
        txt = txt.replace('Ň', '&Ncaron;');

        // "U+00148", "LATIN SMALL LETTER N WITH CARON"
        txt = txt.replace('ň', '&ncaron;');

        // "U+00149", "LATIN SMALL LETTER N PRECEDED BY APOSTROPHE"
        txt = txt.replace('ŉ', '&napos;');

        // "U+0014A", "LATIN CAPITAL LETTER ENG"
        txt = txt.replace('Ŋ', '&ENG;');

        // "U+0014B", "LATIN SMALL LETTER ENG"
        txt = txt.replace('ŋ', '&eng;');

        // "U+0014C", "LATIN CAPITAL LETTER O WITH MACRON"
        txt = txt.replace('Ō', '&Omacr;');

        // "U+0014D", "LATIN SMALL LETTER O WITH MACRON"
        txt = txt.replace('ō', '&omacr;');

        // "U+00150", "LATIN CAPITAL LETTER O WITH DOUBLE ACUTE"
        txt = txt.replace('Ő', '&Odblac;');

        // "U+00151", "LATIN SMALL LETTER O WITH DOUBLE ACUTE"
        txt = txt.replace('ő', '&odblac;');

        // "U+00152", "LATIN CAPITAL LIGATURE OE"
        txt = txt.replace('Œ', '&OElig;');

        // "U+00153", "LATIN SMALL LIGATURE OE"
        txt = txt.replace('œ', '&oelig;');

        // "U+00154", "LATIN CAPITAL LETTER R WITH ACUTE"
        txt = txt.replace('Ŕ', '&Racute;');

        // "U+00155", "LATIN SMALL LETTER R WITH ACUTE"
        txt = txt.replace('ŕ', '&racute;');

        // "U+00156", "LATIN CAPITAL LETTER R WITH CEDILLA"
        txt = txt.replace('Ŗ', '&Rcedil;');

        // "U+00157", "LATIN SMALL LETTER R WITH CEDILLA"
        txt = txt.replace('ŗ', '&rcedil;');

        // "U+00158", "LATIN CAPITAL LETTER R WITH CARON"
        txt = txt.replace('Ř', '&Rcaron;');

        // "U+00159", "LATIN SMALL LETTER R WITH CARON"
        txt = txt.replace('ř', '&rcaron;');

        // "U+0015A", "LATIN CAPITAL LETTER S WITH ACUTE"
        txt = txt.replace('Ś', '&Sacute;');

        // "U+0015B", "LATIN SMALL LETTER S WITH ACUTE"
        txt = txt.replace('ś', '&sacute;');

        // "U+0015C", "LATIN CAPITAL LETTER S WITH CIRCUMFLEX"
        txt = txt.replace('Ŝ', '&Scirc;');

        // "U+0015D", "LATIN SMALL LETTER S WITH CIRCUMFLEX"
        txt = txt.replace('ŝ', '&scirc;');

        // "U+0015E", "LATIN CAPITAL LETTER S WITH CEDILLA"
        txt = txt.replace('Ş', '&Scedil;');

        // "U+0015F", "LATIN SMALL LETTER S WITH CEDILLA"
        txt = txt.replace('ş', '&scedil;');

        // "U+00160", "LATIN CAPITAL LETTER S WITH CARON"
        txt = txt.replace('Š', '&Scaron;');

        // "U+00161", "LATIN SMALL LETTER S WITH CARON"
        txt = txt.replace('š', '&scaron;');

        // "U+00162", "LATIN CAPITAL LETTER T WITH CEDILLA"
        txt = txt.replace('Ţ', '&Tcedil;');

        // "U+00163", "LATIN SMALL LETTER T WITH CEDILLA"
        txt = txt.replace('ţ', '&tcedil;');

        // "U+00164", "LATIN CAPITAL LETTER T WITH CARON"
        txt = txt.replace('Ť', '&Tcaron;');

        // "U+00165", "LATIN SMALL LETTER T WITH CARON"
        txt = txt.replace('ť', '&tcaron;');

        // "U+00166", "LATIN CAPITAL LETTER T WITH STROKE"
        txt = txt.replace('Ŧ', '&Tstrok;');

        // "U+00167", "LATIN SMALL LETTER T WITH STROKE"
        txt = txt.replace('ŧ', '&tstrok;');

        // "U+00168", "LATIN CAPITAL LETTER U WITH TILDE"
        txt = txt.replace('Ũ', '&Utilde;');

        // "U+00169", "LATIN SMALL LETTER U WITH TILDE"
        txt = txt.replace('ũ', '&utilde;');

        // "U+0016A", "LATIN CAPITAL LETTER U WITH MACRON"
        txt = txt.replace('Ū', '&Umacr;');

        // "U+0016B", "LATIN SMALL LETTER U WITH MACRON"
        txt = txt.replace('ū', '&umacr;');

        // "U+0016C", "LATIN CAPITAL LETTER U WITH BREVE"
        txt = txt.replace('Ŭ', '&Ubreve;');

        // "U+0016D", "LATIN SMALL LETTER U WITH BREVE"
        txt = txt.replace('ŭ', '&ubreve;');

        // "U+0016E", "LATIN CAPITAL LETTER U WITH RING ABOVE"
        txt = txt.replace('Ů', '&Uring;');

        // "U+0016F", "LATIN SMALL LETTER U WITH RING ABOVE"
        txt = txt.replace('ů', '&uring;');

        // "U+00170", "LATIN CAPITAL LETTER U WITH DOUBLE ACUTE"
        txt = txt.replace('Ű', '&Udblac;');

        // "U+00171", "LATIN SMALL LETTER U WITH DOUBLE ACUTE"
        txt = txt.replace('ű', '&udblac;');

        // "U+00172", "LATIN CAPITAL LETTER U WITH OGONEK"
        txt = txt.replace('Ų', '&Uogon;');

        // "U+00173", "LATIN SMALL LETTER U WITH OGONEK"
        txt = txt.replace('ų', '&uogon;');

        // "U+00174", "LATIN CAPITAL LETTER W WITH CIRCUMFLEX"
        txt = txt.replace('Ŵ', '&Wcirc;');

        // "U+00175", "LATIN SMALL LETTER W WITH CIRCUMFLEX"
        txt = txt.replace('ŵ', '&wcirc;');

        // "U+00176", "LATIN CAPITAL LETTER Y WITH CIRCUMFLEX"
        txt = txt.replace('Ŷ', '&Ycirc;');

        // "U+00177", "LATIN SMALL LETTER Y WITH CIRCUMFLEX"
        txt = txt.replace('ŷ', '&ycirc;');

        // "U+00178", "LATIN CAPITAL LETTER Y WITH DIAERESIS"
        txt = txt.replace('Ÿ', '&Yuml;');

        // "U+00179", "LATIN CAPITAL LETTER Z WITH ACUTE"
        txt = txt.replace('Ź', '&Zacute;');

        // "U+0017A", "LATIN SMALL LETTER Z WITH ACUTE"
        txt = txt.replace('ź', '&zacute;');

        // "U+0017B", "LATIN CAPITAL LETTER Z WITH DOT ABOVE"
        txt = txt.replace('Ż', '&Zdot;');

        // "U+0017C", "LATIN SMALL LETTER Z WITH DOT ABOVE"
        txt = txt.replace('ż', '&zdot;');

        // "U+0017D", "LATIN CAPITAL LETTER Z WITH CARON"
        txt = txt.replace('Ž', '&Zcaron;');

        // "U+0017E", "LATIN SMALL LETTER Z WITH CARON"
        txt = txt.replace('ž', '&zcaron;');

        // "U+00192", "LATIN SMALL LETTER F WITH HOOK"
        txt = txt.replace('ƒ', '&fnof;');

        // "U+001B5", "LATIN CAPITAL LETTER Z WITH STROKE"
        txt = txt.replace('Ƶ', '&imped;');

        // "U+001F5", "LATIN SMALL LETTER G WITH ACUTE"
        txt = txt.replace('ǵ', '&gacute;');

        // "U+00237", "LATIN SMALL LETTER DOTLESS J"
        txt = txt.replace('ȷ', '&jmath;');

        // "U+002C6", "MODIFIER LETTER CIRCUMFLEX ACCENT"
        txt = txt.replace('ˆ', '&circ;');

        // "U+002C7", "CARON"
        txt = txt.replace('ˇ', '&caron;');

        // "U+002D8", "BREVE"
        txt = txt.replace('˘', '&breve;');

        // "U+002D9", "DOT ABOVE"
        txt = txt.replace('˙', '&dot;');

        // "U+002DA", "RING ABOVE"
        txt = txt.replace('˚', '&ring;');

        // "U+002DB", "OGONEK"
        txt = txt.replace('˛', '&ogon;');

        // "U+002DC", "SMALL TILDE"
        txt = txt.replace('˜', '&tilde;');

        // "U+002DD", "DOUBLE ACUTE ACCENT"
        txt = txt.replace('˝', '&dblac;');

        // "U+00311", "COMBINING INVERTED BREVE"
        txt = txt.replace('̑', '&DownBreve;');

        // "U+00332", "COMBINING LOW LINE"
        txt = txt.replace('̲', '&UnderBar;');

        // "U+00391", "GREEK CAPITAL LETTER ALPHA"
        txt = txt.replace('Α', '&Alpha;');

        // "U+00392", "GREEK CAPITAL LETTER BETA"
        txt = txt.replace('Β', '&Beta;');

        // "U+00393", "GREEK CAPITAL LETTER GAMMA"
        txt = txt.replace('Γ', '&Gamma;');

        // "U+00394", "GREEK CAPITAL LETTER DELTA"
        txt = txt.replace('Δ', '&Delta;');

        // "U+00395", "GREEK CAPITAL LETTER EPSILON"
        txt = txt.replace('Ε', '&Epsilon;');

        // "U+00396", "GREEK CAPITAL LETTER ZETA"
        txt = txt.replace('Ζ', '&Zeta;');

        // "U+00397", "GREEK CAPITAL LETTER ETA"
        txt = txt.replace('Η', '&Eta;');

        // "U+00398", "GREEK CAPITAL LETTER THETA"
        txt = txt.replace('Θ', '&Theta;');

        // "U+00399", "GREEK CAPITAL LETTER IOTA"
        txt = txt.replace('Ι', '&Iota;');

        // "U+0039A", "GREEK CAPITAL LETTER KAPPA"
        txt = txt.replace('Κ', '&Kappa;');

        // "U+0039B", "GREEK CAPITAL LETTER LAMDA"
        txt = txt.replace('Λ', '&Lambda;');

        // "U+0039C", "GREEK CAPITAL LETTER MU"
        txt = txt.replace('Μ', '&Mu;');

        // "U+0039D", "GREEK CAPITAL LETTER NU"
        txt = txt.replace('Ν', '&Nu;');

        // "U+0039E", "GREEK CAPITAL LETTER XI"
        txt = txt.replace('Ξ', '&Xi;');

        // "U+0039F", "GREEK CAPITAL LETTER OMICRON"
        txt = txt.replace('Ο', '&Omicron;');

        // "U+003A0", "GREEK CAPITAL LETTER PI"
        txt = txt.replace('Π', '&Pi;');

        // "U+003A1", "GREEK CAPITAL LETTER RHO"
        txt = txt.replace('Ρ', '&Rho;');

        // "U+003A3", "GREEK CAPITAL LETTER SIGMA"
        txt = txt.replace('Σ', '&Sigma;');

        // "U+003A4", "GREEK CAPITAL LETTER TAU"
        txt = txt.replace('Τ', '&Tau;');

        // "U+003A5", "GREEK CAPITAL LETTER UPSILON"
        txt = txt.replace('Υ', '&Upsilon;');

        // "U+003A6", "GREEK CAPITAL LETTER PHI"
        txt = txt.replace('Φ', '&Phi;');

        // "U+003A7", "GREEK CAPITAL LETTER CHI"
        txt = txt.replace('Χ', '&Chi;');

        // "U+003A8", "GREEK CAPITAL LETTER PSI"
        txt = txt.replace('Ψ', '&Psi;');

        // "U+003A9", "GREEK CAPITAL LETTER OMEGA"
        txt = txt.replace('Ω', '&Omega;');

        // "U+003B1", "GREEK SMALL LETTER ALPHA"
        txt = txt.replace('α', '&alpha;');

        // "U+003B2", "GREEK SMALL LETTER BETA"
        txt = txt.replace('β', '&beta;');

        // "U+003B3", "GREEK SMALL LETTER GAMMA"
        txt = txt.replace('γ', '&gamma;');

        // "U+003B4", "GREEK SMALL LETTER DELTA"
        txt = txt.replace('δ', '&delta;');

        // "U+003B5", "GREEK SMALL LETTER EPSILON"
        txt = txt.replace('ε', '&epsiv;');

        // "U+003B6", "GREEK SMALL LETTER ZETA"
        txt = txt.replace('ζ', '&zeta;');

        // "U+003B7", "GREEK SMALL LETTER ETA"
        txt = txt.replace('η', '&eta;');

        // "U+003B8", "GREEK SMALL LETTER THETA"
        txt = txt.replace('θ', '&theta;');

        // "U+003B9", "GREEK SMALL LETTER IOTA"
        txt = txt.replace('ι', '&iota;');

        // "U+003BA", "GREEK SMALL LETTER KAPPA"
        txt = txt.replace('κ', '&kappa;');

        // "U+003BB", "GREEK SMALL LETTER LAMDA"
        txt = txt.replace('λ', '&lambda;');

        // "U+003BC", "GREEK SMALL LETTER MU"
        txt = txt.replace('μ', '&mu;');

        // "U+003BD", "GREEK SMALL LETTER NU"
        txt = txt.replace('ν', '&nu;');

        // "U+003BE", "GREEK SMALL LETTER XI"
        txt = txt.replace('ξ', '&xi;');

        // "U+003BF", "GREEK SMALL LETTER OMICRON"
        txt = txt.replace('ο', '&omicron;');

        // "U+003C0", "GREEK SMALL LETTER PI"
        txt = txt.replace('π', '&pi;');

        // "U+003C1", "GREEK SMALL LETTER RHO"
        txt = txt.replace('ρ', '&rho;');

        // "U+003C2", "GREEK SMALL LETTER FINAL SIGMA"
        txt = txt.replace('ς', '&sigmav;');

        // "U+003C3", "GREEK SMALL LETTER SIGMA"
        txt = txt.replace('σ', '&sigma;');

        // "U+003C4", "GREEK SMALL LETTER TAU"
        txt = txt.replace('τ', '&tau;');

        // "U+003C5", "GREEK SMALL LETTER UPSILON"
        txt = txt.replace('υ', '&upsi;');

        // "U+003C6", "GREEK SMALL LETTER PHI"
        txt = txt.replace('φ', '&phi;');

        // "U+003C7", "GREEK SMALL LETTER CHI"
        txt = txt.replace('χ', '&chi;');

        // "U+003C8", "GREEK SMALL LETTER PSI"
        txt = txt.replace('ψ', '&psi;');

        // "U+003C9", "GREEK SMALL LETTER OMEGA"
        txt = txt.replace('ω', '&omega;');

        // "U+003D1", "GREEK THETA SYMBOL"
        txt = txt.replace('ϑ', '&thetav;');

        // "U+003D2", "GREEK UPSILON WITH HOOK SYMBOL"
        txt = txt.replace('ϒ', '&Upsi;');

        // "U+003D5", "GREEK PHI SYMBOL"
        txt = txt.replace('ϕ', '&straightphi;');

        // "U+003D6", "GREEK PI SYMBOL"
        txt = txt.replace('ϖ', '&piv;');

        // "U+003DC", "GREEK LETTER DIGAMMA"
        txt = txt.replace('Ϝ', '&Gammad;');

        // "U+003DD", "GREEK SMALL LETTER DIGAMMA"
        txt = txt.replace('ϝ', '&gammad;');

        // "U+003F0", "GREEK KAPPA SYMBOL"
        txt = txt.replace('ϰ', '&kappav;');

        // "U+003F1", "GREEK RHO SYMBOL"
        txt = txt.replace('ϱ', '&rhov;');

        // "U+003F5", "GREEK LUNATE EPSILON SYMBOL"
        txt = txt.replace('ϵ', '&epsi;');

        // "U+003F6", "GREEK REVERSED LUNATE EPSILON SYMBOL"
        txt = txt.replace('϶', '&bepsi;');

        // "U+00401", "CYRILLIC CAPITAL LETTER IO"
        txt = txt.replace('Ё', '&IOcy;');

        // "U+00402", "CYRILLIC CAPITAL LETTER DJE"
        txt = txt.replace('Ђ', '&DJcy;');

        // "U+00403", "CYRILLIC CAPITAL LETTER GJE"
        txt = txt.replace('Ѓ', '&GJcy;');

        // "U+00404", "CYRILLIC CAPITAL LETTER UKRAINIAN IE"
        txt = txt.replace('Є', '&Jukcy;');

        // "U+00405", "CYRILLIC CAPITAL LETTER DZE"
        txt = txt.replace('Ѕ', '&DScy;');

        // "U+00406", "CYRILLIC CAPITAL LETTER BYELORUSSIAN-UKRAINIAN I"
        txt = txt.replace('І', '&Iukcy;');

        // "U+00407", "CYRILLIC CAPITAL LETTER YI"
        txt = txt.replace('Ї', '&YIcy;');

        // "U+00408", "CYRILLIC CAPITAL LETTER JE"
        txt = txt.replace('Ј', '&Jsercy;');

        // "U+00409", "CYRILLIC CAPITAL LETTER LJE"
        txt = txt.replace('Љ', '&LJcy;');

        // "U+0040A", "CYRILLIC CAPITAL LETTER NJE"
        txt = txt.replace('Њ', '&NJcy;');

        // "U+0040B", "CYRILLIC CAPITAL LETTER TSHE"
        txt = txt.replace('Ћ', '&TSHcy;');

        // "U+0040C", "CYRILLIC CAPITAL LETTER KJE"
        txt = txt.replace('Ќ', '&KJcy;');

        // "U+0040E", "CYRILLIC CAPITAL LETTER SHORT U"
        txt = txt.replace('Ў', '&Ubrcy;');

        // "U+0040F", "CYRILLIC CAPITAL LETTER DZHE"
        txt = txt.replace('Џ', '&DZcy;');

        // "U+00410", "CYRILLIC CAPITAL LETTER A"
        txt = txt.replace('А', '&Acy;');

        // "U+00411", "CYRILLIC CAPITAL LETTER BE"
        txt = txt.replace('Б', '&Bcy;');

        // "U+00412", "CYRILLIC CAPITAL LETTER VE"
        txt = txt.replace('В', '&Vcy;');

        // "U+00413", "CYRILLIC CAPITAL LETTER GHE"
        txt = txt.replace('Г', '&Gcy;');

        // "U+00414", "CYRILLIC CAPITAL LETTER DE"
        txt = txt.replace('Д', '&Dcy;');

        // "U+00415", "CYRILLIC CAPITAL LETTER IE"
        txt = txt.replace('Е', '&IEcy;');

        // "U+00416", "CYRILLIC CAPITAL LETTER ZHE"
        txt = txt.replace('Ж', '&ZHcy;');

        // "U+00417", "CYRILLIC CAPITAL LETTER ZE"
        txt = txt.replace('З', '&Zcy;');

        // "U+00418", "CYRILLIC CAPITAL LETTER I"
        txt = txt.replace('И', '&Icy;');

        // "U+00419", "CYRILLIC CAPITAL LETTER SHORT I"
        txt = txt.replace('Й', '&Jcy;');

        // "U+0041A", "CYRILLIC CAPITAL LETTER KA"
        txt = txt.replace('К', '&Kcy;');

        // "U+0041B", "CYRILLIC CAPITAL LETTER EL"
        txt = txt.replace('Л', '&Lcy;');

        // "U+0041C", "CYRILLIC CAPITAL LETTER EM"
        txt = txt.replace('М', '&Mcy;');

        // "U+0041D", "CYRILLIC CAPITAL LETTER EN"
        txt = txt.replace('Н', '&Ncy;');

        // "U+0041E", "CYRILLIC CAPITAL LETTER O"
        txt = txt.replace('О', '&Ocy;');

        // "U+0041F", "CYRILLIC CAPITAL LETTER PE"
        txt = txt.replace('П', '&Pcy;');

        // "U+00420", "CYRILLIC CAPITAL LETTER ER"
        txt = txt.replace('Р', '&Rcy;');

        // "U+00421", "CYRILLIC CAPITAL LETTER ES"
        txt = txt.replace('С', '&Scy;');

        // "U+00422", "CYRILLIC CAPITAL LETTER TE"
        txt = txt.replace('Т', '&Tcy;');

        // "U+00423", "CYRILLIC CAPITAL LETTER U"
        txt = txt.replace('У', '&Ucy;');

        // "U+00424", "CYRILLIC CAPITAL LETTER EF"
        txt = txt.replace('Ф', '&Fcy;');

        // "U+00425", "CYRILLIC CAPITAL LETTER HA"
        txt = txt.replace('Х', '&KHcy;');

        // "U+00426", "CYRILLIC CAPITAL LETTER TSE"
        txt = txt.replace('Ц', '&TScy;');

        // "U+00427", "CYRILLIC CAPITAL LETTER CHE"
        txt = txt.replace('Ч', '&CHcy;');

        // "U+00428", "CYRILLIC CAPITAL LETTER SHA"
        txt = txt.replace('Ш', '&SHcy;');

        // "U+00429", "CYRILLIC CAPITAL LETTER SHCHA"
        txt = txt.replace('Щ', '&SHCHcy;');

        // "U+0042A", "CYRILLIC CAPITAL LETTER HARD SIGN"
        txt = txt.replace('Ъ', '&HARDcy;');

        // "U+0042B", "CYRILLIC CAPITAL LETTER YERU"
        txt = txt.replace('Ы', '&Ycy;');

        // "U+0042C", "CYRILLIC CAPITAL LETTER SOFT SIGN"
        txt = txt.replace('Ь', '&SOFTcy;');

        // "U+0042D", "CYRILLIC CAPITAL LETTER E"
        txt = txt.replace('Э', '&Ecy;');

        // "U+0042E", "CYRILLIC CAPITAL LETTER YU"
        txt = txt.replace('Ю', '&YUcy;');

        // "U+0042F", "CYRILLIC CAPITAL LETTER YA"
        txt = txt.replace('Я', '&YAcy;');

        // "U+00430", "CYRILLIC SMALL LETTER A"
        txt = txt.replace('а', '&acy;');

        // "U+00431", "CYRILLIC SMALL LETTER BE"
        txt = txt.replace('б', '&bcy;');

        // "U+00432", "CYRILLIC SMALL LETTER VE"
        txt = txt.replace('в', '&vcy;');

        // "U+00433", "CYRILLIC SMALL LETTER GHE"
        txt = txt.replace('г', '&gcy;');

        // "U+00434", "CYRILLIC SMALL LETTER DE"
        txt = txt.replace('д', '&dcy;');

        // "U+00435", "CYRILLIC SMALL LETTER IE"
        txt = txt.replace('е', '&iecy;');

        // "U+00436", "CYRILLIC SMALL LETTER ZHE"
        txt = txt.replace('ж', '&zhcy;');

        // "U+00437", "CYRILLIC SMALL LETTER ZE"
        txt = txt.replace('з', '&zcy;');

        // "U+00438", "CYRILLIC SMALL LETTER I"
        txt = txt.replace('и', '&icy;');

        // "U+00439", "CYRILLIC SMALL LETTER SHORT I"
        txt = txt.replace('й', '&jcy;');

        // "U+0043A", "CYRILLIC SMALL LETTER KA"
        txt = txt.replace('к', '&kcy;');

        // "U+0043B", "CYRILLIC SMALL LETTER EL"
        txt = txt.replace('л', '&lcy;');

        // "U+0043C", "CYRILLIC SMALL LETTER EM"
        txt = txt.replace('м', '&mcy;');

        // "U+0043D", "CYRILLIC SMALL LETTER EN"
        txt = txt.replace('н', '&ncy;');

        // "U+0043E", "CYRILLIC SMALL LETTER O"
        txt = txt.replace('о', '&ocy;');

        // "U+0043F", "CYRILLIC SMALL LETTER PE"
        txt = txt.replace('п', '&pcy;');

        // "U+00440", "CYRILLIC SMALL LETTER ER"
        txt = txt.replace('р', '&rcy;');

        // "U+00441", "CYRILLIC SMALL LETTER ES"
        txt = txt.replace('с', '&scy;');

        // "U+00442", "CYRILLIC SMALL LETTER TE"
        txt = txt.replace('т', '&tcy;');

        // "U+00443", "CYRILLIC SMALL LETTER U"
        txt = txt.replace('у', '&ucy;');

        // "U+00444", "CYRILLIC SMALL LETTER EF"
        txt = txt.replace('ф', '&fcy;');

        // "U+00445", "CYRILLIC SMALL LETTER HA"
        txt = txt.replace('х', '&khcy;');

        // "U+00446", "CYRILLIC SMALL LETTER TSE"
        txt = txt.replace('ц', '&tscy;');

        // "U+00447", "CYRILLIC SMALL LETTER CHE"
        txt = txt.replace('ч', '&chcy;');

        // "U+00448", "CYRILLIC SMALL LETTER SHA"
        txt = txt.replace('ш', '&shcy;');

        // "U+00449", "CYRILLIC SMALL LETTER SHCHA"
        txt = txt.replace('щ', '&shchcy;');

        // "U+0044A", "CYRILLIC SMALL LETTER HARD SIGN"
        txt = txt.replace('ъ', '&hardcy;');

        // "U+0044B", "CYRILLIC SMALL LETTER YERU"
        txt = txt.replace('ы', '&ycy;');

        // "U+0044C", "CYRILLIC SMALL LETTER SOFT SIGN"
        txt = txt.replace('ь', '&softcy;');

        // "U+0044D", "CYRILLIC SMALL LETTER E"
        txt = txt.replace('э', '&ecy;');

        // "U+0044E", "CYRILLIC SMALL LETTER YU"
        txt = txt.replace('ю', '&yucy;');

        // "U+0044F", "CYRILLIC SMALL LETTER YA"
        txt = txt.replace('я', '&yacy;');

        // "U+00451", "CYRILLIC SMALL LETTER IO"
        txt = txt.replace('ё', '&iocy;');

        // "U+00452", "CYRILLIC SMALL LETTER DJE"
        txt = txt.replace('ђ', '&djcy;');

        // "U+00453", "CYRILLIC SMALL LETTER GJE"
        txt = txt.replace('ѓ', '&gjcy;');

        // "U+00454", "CYRILLIC SMALL LETTER UKRAINIAN IE"
        txt = txt.replace('є', '&jukcy;');

        // "U+00455", "CYRILLIC SMALL LETTER DZE"
        txt = txt.replace('ѕ', '&dscy;');

        // "U+00456", "CYRILLIC SMALL LETTER BYELORUSSIAN-UKRAINIAN I"
        txt = txt.replace('і', '&iukcy;');

        // "U+00457", "CYRILLIC SMALL LETTER YI"
        txt = txt.replace('ї', '&yicy;');

        // "U+00458", "CYRILLIC SMALL LETTER JE"
        txt = txt.replace('ј', '&jsercy;');

        // "U+00459", "CYRILLIC SMALL LETTER LJE"
        txt = txt.replace('љ', '&ljcy;');

        // "U+0045A", "CYRILLIC SMALL LETTER NJE"
        txt = txt.replace('њ', '&njcy;');

        // "U+0045B", "CYRILLIC SMALL LETTER TSHE"
        txt = txt.replace('ћ', '&tshcy;');

        // "U+0045C", "CYRILLIC SMALL LETTER KJE"
        txt = txt.replace('ќ', '&kjcy;');

        // "U+0045E", "CYRILLIC SMALL LETTER SHORT U"
        txt = txt.replace('ў', '&ubrcy;');

        // "U+0045F", "CYRILLIC SMALL LETTER DZHE"
        txt = txt.replace('џ', '&dzcy;');

        // "U+02002", "EN SPACE"
        txt = txt.replace(' ', '&ensp;');

        // "U+02003", "EM SPACE"
        txt = txt.replace(' ', '&emsp;');

        // "U+02004", "THREE-PER-EM SPACE"
        txt = txt.replace(' ', '&emsp13;');

        // "U+02005", "FOUR-PER-EM SPACE"
        txt = txt.replace(' ', '&emsp14;');

        // "U+02007", "FIGURE SPACE"
        txt = txt.replace(' ', '&numsp;');

        // "U+02008", "PUNCTUATION SPACE"
        txt = txt.replace(' ', '&puncsp;');

        // "U+02009", "THIN SPACE"
        txt = txt.replace(' ', '&thinsp;');

        // "U+0200A", "HAIR SPACE"
        txt = txt.replace(' ', '&hairsp;');

        // "U+0200B", "ZERO WIDTH SPACE"
        txt = txt.replace('​', '&ZeroWidthSpace;');

        // "U+0200C", "ZERO WIDTH NON-JOINER"
        txt = txt.replace('‌', '&zwnj;');

        // "U+0200D", "ZERO WIDTH JOINER"
        txt = txt.replace('‍', '&zwj;');

        // "U+0200E", "LEFT-TO-RIGHT MARK"
        txt = txt.replace('‎', '&lrm;');

        // "U+0200F", "RIGHT-TO-LEFT MARK"
        txt = txt.replace('‏', '&rlm;');

        // "U+02010", "HYPHEN"
        txt = txt.replace('‐', '&hyphen;');

        // "U+02013", "EN DASH"
        txt = txt.replace('–', '&ndash;');

        // "U+02014", "EM DASH"
        txt = txt.replace('—', '&mdash;');

        // "U+02015", "HORIZONTAL BAR"
        txt = txt.replace('―', '&horbar;');

        // "U+02016", "DOUBLE VERTICAL LINE"
        txt = txt.replace('‖', '&Verbar;');

        // "U+02018", "LEFT SINGLE QUOTATION MARK"
        txt = txt.replace('‘', '&lsquo;');

        // "U+02019", "RIGHT SINGLE QUOTATION MARK"
        txt = txt.replace('’', '&rsquo;');

        // "U+0201A", "SINGLE LOW-9 QUOTATION MARK"
        txt = txt.replace('‚', '&lsquor;');

        // "U+0201C", "LEFT DOUBLE QUOTATION MARK"
        txt = txt.replace('“', '&ldquo;');

        // "U+0201D", "RIGHT DOUBLE QUOTATION MARK"
        txt = txt.replace('”', '&rdquo;');

        // "U+0201E", "DOUBLE LOW-9 QUOTATION MARK"
        txt = txt.replace('„', '&ldquor;');

        // "U+02020", "DAGGER"
        txt = txt.replace('†', '&dagger;');

        // "U+02021", "DOUBLE DAGGER"
        txt = txt.replace('‡', '&Dagger;');

        // "U+02022", "BULLET"
        txt = txt.replace('•', '&bull;');

        // "U+02025", "TWO DOT LEADER"
        txt = txt.replace('‥', '&nldr;');

        // "U+02026", "HORIZONTAL ELLIPSIS"
        txt = txt.replace('…', '&hellip;');

        // "U+02030", "PER MILLE SIGN"
        txt = txt.replace('‰', '&permil;');

        // "U+02031", "PER TEN THOUSAND SIGN"
        txt = txt.replace('‱', '&pertenk;');

        // "U+02032", "PRIME"
        txt = txt.replace('′', '&prime;');

        // "U+02033", "DOUBLE PRIME"
        txt = txt.replace('″', '&Prime;');

        // "U+02034", "TRIPLE PRIME"
        txt = txt.replace('‴', '&tprime;');

        // "U+02035", "REVERSED PRIME"
        txt = txt.replace('‵', '&bprime;');

        // "U+02039", "SINGLE LEFT-POINTING ANGLE QUOTATION MARK"
        txt = txt.replace('‹', '&lsaquo;');

        // "U+0203A", "SINGLE RIGHT-POINTING ANGLE QUOTATION MARK"
        txt = txt.replace('›', '&rsaquo;');

        // "U+0203E", "OVERLINE"
        txt = txt.replace('‾', '&oline;');

        // "U+02041", "CARET INSERTION POINT"
        txt = txt.replace('⁁', '&caret;');

        // "U+02043", "HYPHEN BULLET"
        txt = txt.replace('⁃', '&hybull;');

        // "U+02044", "FRACTION SLASH"
        txt = txt.replace('⁄', '&frasl;');

        // "U+0204F", "REVERSED SEMICOLON"
        txt = txt.replace('⁏', '&bsemi;');

        // "U+02057", "QUADRUPLE PRIME"
        txt = txt.replace('⁗', '&qprime;');

        // "U+0205F", "MEDIUM MATHEMATICAL SPACE"
        txt = txt.replace(' ', '&MediumSpace;');

        // "U+02060", "WORD JOINER"
        txt = txt.replace('⁠', '&NoBreak;');

        // "U+02061", "FUNCTION APPLICATION"
        txt = txt.replace('⁡', '&ApplyFunction;');

        // "U+02062", "INVISIBLE TIMES"
        txt = txt.replace('⁢', '&InvisibleTimes;');

        // "U+02063", "INVISIBLE SEPARATOR"
        txt = txt.replace('⁣', '&InvisibleComma;');

        // "U+020AC", "EURO SIGN"
        txt = txt.replace('€', '&euro;');

        // "U+020DB", "COMBINING THREE DOTS ABOVE"
        txt = txt.replace('⃛', '&tdot;');

        // "U+020DC", "COMBINING FOUR DOTS ABOVE"
        txt = txt.replace('⃜', '&DotDot;');

        // "U+02102", "DOUBLE-STRUCK CAPITAL C"
        txt = txt.replace('ℂ', '&Copf;');

        // "U+02105", "CARE OF"
        txt = txt.replace('℅', '&incare;');

        // "U+0210A", "SCRIPT SMALL G"
        txt = txt.replace('ℊ', '&gscr;');

        // "U+0210B", "SCRIPT CAPITAL H"
        txt = txt.replace('ℋ', '&hamilt;');

        // "U+0210C", "BLACK-LETTER CAPITAL H"
        txt = txt.replace('ℌ', '&Hfr;');

        // "U+0210D", "DOUBLE-STRUCK CAPITAL H"
        txt = txt.replace('ℍ', '&quaternions;');

        // "U+0210E", "PLANCK CONSTANT"
        txt = txt.replace('ℎ', '&planckh;');

        // "U+0210F", "PLANCK CONSTANT OVER TWO PI"
        txt = txt.replace('ℏ', '&planck;');

        // "U+02110", "SCRIPT CAPITAL I"
        txt = txt.replace('ℐ', '&Iscr;');

        // "U+02111", "BLACK-LETTER CAPITAL I"
        txt = txt.replace('ℑ', '&image;');

        // "U+02112", "SCRIPT CAPITAL L"
        txt = txt.replace('ℒ', '&Lscr;');

        // "U+02113", "SCRIPT SMALL L"
        txt = txt.replace('ℓ', '&ell;');

        // "U+02115", "DOUBLE-STRUCK CAPITAL N"
        txt = txt.replace('ℕ', '&Nopf;');

        // "U+02116", "NUMERO SIGN"
        txt = txt.replace('№', '&numero;');

        // "U+02117", "SOUND RECORDING COPYRIGHT"
        txt = txt.replace('℗', '&copysr;');

        // "U+02118", "SCRIPT CAPITAL P"
        txt = txt.replace('℘', '&weierp;');

        // "U+02119", "DOUBLE-STRUCK CAPITAL P"
        txt = txt.replace('ℙ', '&Popf;');

        // "U+0211A", "DOUBLE-STRUCK CAPITAL Q"
        txt = txt.replace('ℚ', '&rationals;');

        // "U+0211B", "SCRIPT CAPITAL R"
        txt = txt.replace('ℛ', '&Rscr;');

        // "U+0211C", "BLACK-LETTER CAPITAL R"
        txt = txt.replace('ℜ', '&real;');

        // "U+0211D", "DOUBLE-STRUCK CAPITAL R"
        txt = txt.replace('ℝ', '&reals;');

        // "U+0211E", "PRESCRIPTION TAKE"
        txt = txt.replace('℞', '&rx;');

        // "U+02122", "TRADE MARK SIGN"
        txt = txt.replace('™', '&trade;');

        // "U+02124", "DOUBLE-STRUCK CAPITAL Z"
        txt = txt.replace('ℤ', '&integers;');

        // "U+02126", "OHM SIGN"
        txt = txt.replace('Ω', '&ohm;');

        // "U+02127", "INVERTED OHM SIGN"
        txt = txt.replace('℧', '&mho;');

        // "U+02128", "BLACK-LETTER CAPITAL Z"
        txt = txt.replace('ℨ', '&Zfr;');

        // "U+02129", "TURNED GREEK SMALL LETTER IOTA"
        txt = txt.replace('℩', '&iiota;');

        // "U+0212B", "ANGSTROM SIGN"
        txt = txt.replace('Å', '&angst;');

        // "U+0212C", "SCRIPT CAPITAL B"
        txt = txt.replace('ℬ', '&bernou;');

        // "U+0212D", "BLACK-LETTER CAPITAL C"
        txt = txt.replace('ℭ', '&Cfr;');

        // "U+0212F", "SCRIPT SMALL E"
        txt = txt.replace('ℯ', '&escr;');

        // "U+02130", "SCRIPT CAPITAL E"
        txt = txt.replace('ℰ', '&Escr;');

        // "U+02131", "SCRIPT CAPITAL F"
        txt = txt.replace('ℱ', '&Fscr;');

        // "U+02133", "SCRIPT CAPITAL M"
        txt = txt.replace('ℳ', '&phmmat;');

        // "U+02134", "SCRIPT SMALL O"
        txt = txt.replace('ℴ', '&order;');

        // "U+02135", "ALEF SYMBOL"
        txt = txt.replace('ℵ', '&alefsym;');

        // "U+02136", "BET SYMBOL"
        txt = txt.replace('ℶ', '&beth;');

        // "U+02137", "GIMEL SYMBOL"
        txt = txt.replace('ℷ', '&gimel;');

        // "U+02138", "DALET SYMBOL"
        txt = txt.replace('ℸ', '&daleth;');

        // "U+02145", "DOUBLE-STRUCK ITALIC CAPITAL D"
        txt = txt.replace('ⅅ', '&CapitalDifferentialD;');

        // "U+02146", "DOUBLE-STRUCK ITALIC SMALL D"
        txt = txt.replace('ⅆ', '&DifferentialD;');

        // "U+02147", "DOUBLE-STRUCK ITALIC SMALL E"
        txt = txt.replace('ⅇ', '&ExponentialE;');

        // "U+02148", "DOUBLE-STRUCK ITALIC SMALL I"
        txt = txt.replace('ⅈ', '&ImaginaryI;');

        // "U+02153", "VULGAR FRACTION ONE THIRD"
        txt = txt.replace('⅓', '&frac13;');

        // "U+02154", "VULGAR FRACTION TWO THIRDS"
        txt = txt.replace('⅔', '&frac23;');

        // "U+02155", "VULGAR FRACTION ONE FIFTH"
        txt = txt.replace('⅕', '&frac15;');

        // "U+02156", "VULGAR FRACTION TWO FIFTHS"
        txt = txt.replace('⅖', '&frac25;');

        // "U+02157", "VULGAR FRACTION THREE FIFTHS"
        txt = txt.replace('⅗', '&frac35;');

        // "U+02158", "VULGAR FRACTION FOUR FIFTHS"
        txt = txt.replace('⅘', '&frac45;');

        // "U+02159", "VULGAR FRACTION ONE SIXTH"
        txt = txt.replace('⅙', '&frac16;');

        // "U+0215A", "VULGAR FRACTION FIVE SIXTHS"
        txt = txt.replace('⅚', '&frac56;');

        // "U+0215B", "VULGAR FRACTION ONE EIGHTH"
        txt = txt.replace('⅛', '&frac18;');

        // "U+0215C", "VULGAR FRACTION THREE EIGHTHS"
        txt = txt.replace('⅜', '&frac38;');

        // "U+0215D", "VULGAR FRACTION FIVE EIGHTHS"
        txt = txt.replace('⅝', '&frac58;');

        // "U+0215E", "VULGAR FRACTION SEVEN EIGHTHS"
        txt = txt.replace('⅞', '&frac78;');

        // "U+02190", "LEFTWARDS ARROW"
        txt = txt.replace('←', '&larr;');

        // "U+02191", "UPWARDS ARROW"
        txt = txt.replace('↑', '&uarr;');

        // "U+02192", "RIGHTWARDS ARROW"
        txt = txt.replace('→', '&rarr;');

        // "U+02193", "DOWNWARDS ARROW"
        txt = txt.replace('↓', '&darr;');

        // "U+02194", "LEFT RIGHT ARROW"
        txt = txt.replace('↔', '&harr;');

        // "U+02195", "UP DOWN ARROW"
        txt = txt.replace('↕', '&varr;');

        // "U+02196", "NORTH WEST ARROW"
        txt = txt.replace('↖', '&nwarr;');

        // "U+02197", "NORTH EAST ARROW"
        txt = txt.replace('↗', '&nearr;');

        // "U+02198", "SOUTH EAST ARROW"
        txt = txt.replace('↘', '&searr;');

        // "U+02199", "SOUTH WEST ARROW"
        txt = txt.replace('↙', '&swarr;');

        // "U+0219A", "LEFTWARDS ARROW WITH STROKE"
        txt = txt.replace('↚', '&nlarr;');

        // "U+0219B", "RIGHTWARDS ARROW WITH STROKE"
        txt = txt.replace('↛', '&nrarr;');

        // "U+0219D", "RIGHTWARDS WAVE ARROW"
        txt = txt.replace('↝', '&rarrw;');

        // "U+0219E", "LEFTWARDS TWO HEADED ARROW"
        txt = txt.replace('↞', '&Larr;');

        // "U+0219F", "UPWARDS TWO HEADED ARROW"
        txt = txt.replace('↟', '&Uarr;');

        // "U+021A0", "RIGHTWARDS TWO HEADED ARROW"
        txt = txt.replace('↠', '&Rarr;');

        // "U+021A1", "DOWNWARDS TWO HEADED ARROW"
        txt = txt.replace('↡', '&Darr;');

        // "U+021A2", "LEFTWARDS ARROW WITH TAIL"
        txt = txt.replace('↢', '&larrtl;');

        // "U+021A3", "RIGHTWARDS ARROW WITH TAIL"
        txt = txt.replace('↣', '&rarrtl;');

        // "U+021A4", "LEFTWARDS ARROW FROM BAR"
        txt = txt.replace('↤', '&LeftTeeArrow;');

        // "U+021A5", "UPWARDS ARROW FROM BAR"
        txt = txt.replace('↥', '&UpTeeArrow;');

        // "U+021A6", "RIGHTWARDS ARROW FROM BAR"
        txt = txt.replace('↦', '&map;');

        // "U+021A7", "DOWNWARDS ARROW FROM BAR"
        txt = txt.replace('↧', '&DownTeeArrow;');

        // "U+021A9", "LEFTWARDS ARROW WITH HOOK"
        txt = txt.replace('↩', '&larrhk;');

        // "U+021AA", "RIGHTWARDS ARROW WITH HOOK"
        txt = txt.replace('↪', '&rarrhk;');

        // "U+021AB", "LEFTWARDS ARROW WITH LOOP"
        txt = txt.replace('↫', '&larrlp;');

        // "U+021AC", "RIGHTWARDS ARROW WITH LOOP"
        txt = txt.replace('↬', '&rarrlp;');

        // "U+021AD", "LEFT RIGHT WAVE ARROW"
        txt = txt.replace('↭', '&harrw;');

        // "U+021AE", "LEFT RIGHT ARROW WITH STROKE"
        txt = txt.replace('↮', '&nharr;');

        // "U+021B0", "UPWARDS ARROW WITH TIP LEFTWARDS"
        txt = txt.replace('↰', '&lsh;');

        // "U+021B1", "UPWARDS ARROW WITH TIP RIGHTWARDS"
        txt = txt.replace('↱', '&rsh;');

        // "U+021B2", "DOWNWARDS ARROW WITH TIP LEFTWARDS"
        txt = txt.replace('↲', '&ldsh;');

        // "U+021B3", "DOWNWARDS ARROW WITH TIP RIGHTWARDS"
        txt = txt.replace('↳', '&rdsh;');

        // "U+021B5", "DOWNWARDS ARROW WITH CORNER LEFTWARDS"
        txt = txt.replace('↵', '&crarr;');

        // "U+021B6", "ANTICLOCKWISE TOP SEMICIRCLE ARROW"
        txt = txt.replace('↶', '&cularr;');

        // "U+021B7", "CLOCKWISE TOP SEMICIRCLE ARROW"
        txt = txt.replace('↷', '&curarr;');

        // "U+021BA", "ANTICLOCKWISE OPEN CIRCLE ARROW"
        txt = txt.replace('↺', '&olarr;');

        // "U+021BB", "CLOCKWISE OPEN CIRCLE ARROW"
        txt = txt.replace('↻', '&orarr;');

        // "U+021BC", "LEFTWARDS HARPOON WITH BARB UPWARDS"
        txt = txt.replace('↼', '&lharu;');

        // "U+021BD", "LEFTWARDS HARPOON WITH BARB DOWNWARDS"
        txt = txt.replace('↽', '&lhard;');

        // "U+021BE", "UPWARDS HARPOON WITH BARB RIGHTWARDS"
        txt = txt.replace('↾', '&uharr;');

        // "U+021BF", "UPWARDS HARPOON WITH BARB LEFTWARDS"
        txt = txt.replace('↿', '&uharl;');

        // "U+021C0", "RIGHTWARDS HARPOON WITH BARB UPWARDS"
        txt = txt.replace('⇀', '&rharu;');

        // "U+021C1", "RIGHTWARDS HARPOON WITH BARB DOWNWARDS"
        txt = txt.replace('⇁', '&rhard;');

        // "U+021C2", "DOWNWARDS HARPOON WITH BARB RIGHTWARDS"
        txt = txt.replace('⇂', '&dharr;');

        // "U+021C3", "DOWNWARDS HARPOON WITH BARB LEFTWARDS"
        txt = txt.replace('⇃', '&dharl;');

        // "U+021C4", "RIGHTWARDS ARROW OVER LEFTWARDS ARROW"
        txt = txt.replace('⇄', '&rlarr;');

        // "U+021C5", "UPWARDS ARROW LEFTWARDS OF DOWNWARDS ARROW"
        txt = txt.replace('⇅', '&udarr;');

        // "U+021C6", "LEFTWARDS ARROW OVER RIGHTWARDS ARROW"
        txt = txt.replace('⇆', '&lrarr;');

        // "U+021C7", "LEFTWARDS PAIRED ARROWS"
        txt = txt.replace('⇇', '&llarr;');

        // "U+021C8", "UPWARDS PAIRED ARROWS"
        txt = txt.replace('⇈', '&uuarr;');

        // "U+021C9", "RIGHTWARDS PAIRED ARROWS"
        txt = txt.replace('⇉', '&rrarr;');

        // "U+021CA", "DOWNWARDS PAIRED ARROWS"
        txt = txt.replace('⇊', '&ddarr;');

        // "U+021CB", "LEFTWARDS HARPOON OVER RIGHTWARDS HARPOON"
        txt = txt.replace('⇋', '&lrhar;');

        // "U+021CC", "RIGHTWARDS HARPOON OVER LEFTWARDS HARPOON"
        txt = txt.replace('⇌', '&rlhar;');

        // "U+021CD", "LEFTWARDS DOUBLE ARROW WITH STROKE"
        txt = txt.replace('⇍', '&nlArr;');

        // "U+021CE", "LEFT RIGHT DOUBLE ARROW WITH STROKE"
        txt = txt.replace('⇎', '&nhArr;');

        // "U+021CF", "RIGHTWARDS DOUBLE ARROW WITH STROKE"
        txt = txt.replace('⇏', '&nrArr;');

        // "U+021D0", "LEFTWARDS DOUBLE ARROW"
        txt = txt.replace('⇐', '&lArr;');

        // "U+021D1", "UPWARDS DOUBLE ARROW"
        txt = txt.replace('⇑', '&uArr;');

        // "U+021D2", "RIGHTWARDS DOUBLE ARROW"
        txt = txt.replace('⇒', '&rArr;');

        // "U+021D3", "DOWNWARDS DOUBLE ARROW"
        txt = txt.replace('⇓', '&dArr;');

        // "U+021D4", "LEFT RIGHT DOUBLE ARROW"
        txt = txt.replace('⇔', '&hArr;');

        // "U+021D5", "UP DOWN DOUBLE ARROW"
        txt = txt.replace('⇕', '&vArr;');

        // "U+021D6", "NORTH WEST DOUBLE ARROW"
        txt = txt.replace('⇖', '&nwArr;');

        // "U+021D7", "NORTH EAST DOUBLE ARROW"
        txt = txt.replace('⇗', '&neArr;');

        // "U+021D8", "SOUTH EAST DOUBLE ARROW"
        txt = txt.replace('⇘', '&seArr;');

        // "U+021D9", "SOUTH WEST DOUBLE ARROW"
        txt = txt.replace('⇙', '&swArr;');

        // "U+021DA", "LEFTWARDS TRIPLE ARROW"
        txt = txt.replace('⇚', '&lAarr;');

        // "U+021DB", "RIGHTWARDS TRIPLE ARROW"
        txt = txt.replace('⇛', '&rAarr;');

        // "U+021DD", "RIGHTWARDS SQUIGGLE ARROW"
        txt = txt.replace('⇝', '&zigrarr;');

        // "U+021E4", "LEFTWARDS ARROW TO BAR"
        txt = txt.replace('⇤', '&larrb;');

        // "U+021E5", "RIGHTWARDS ARROW TO BAR"
        txt = txt.replace('⇥', '&rarrb;');

        // "U+021F5", "DOWNWARDS ARROW LEFTWARDS OF UPWARDS ARROW"
        txt = txt.replace('⇵', '&duarr;');

        // "U+021FD", "LEFTWARDS OPEN-HEADED ARROW"
        txt = txt.replace('⇽', '&loarr;');

        // "U+021FE", "RIGHTWARDS OPEN-HEADED ARROW"
        txt = txt.replace('⇾', '&roarr;');

        // "U+021FF", "LEFT RIGHT OPEN-HEADED ARROW"
        txt = txt.replace('⇿', '&hoarr;');

        // "U+02200", "FOR ALL"
        txt = txt.replace('∀', '&forall;');

        // "U+02201", "COMPLEMENT"
        txt = txt.replace('∁', '&comp;');

        // "U+02202", "PARTIAL DIFFERENTIAL"
        txt = txt.replace('∂', '&part;');

        // "U+02203", "THERE EXISTS"
        txt = txt.replace('∃', '&exist;');

        // "U+02204", "THERE DOES NOT EXIST"
        txt = txt.replace('∄', '&nexist;');

        // "U+02205", "EMPTY SET"
        txt = txt.replace('∅', '&empty;');

        // "U+02207", "NABLA"
        txt = txt.replace('∇', '&nabla;');

        // "U+02208", "ELEMENT OF"
        txt = txt.replace('∈', '&isin;');

        // "U+02209", "NOT AN ELEMENT OF"
        txt = txt.replace('∉', '&notin;');

        // "U+0220B", "CONTAINS AS MEMBER"
        txt = txt.replace('∋', '&niv;');

        // "U+0220C", "DOES NOT CONTAIN AS MEMBER"
        txt = txt.replace('∌', '&notni;');

        // "U+0220F", "N-ARY PRODUCT"
        txt = txt.replace('∏', '&prod;');

        // "U+02210", "N-ARY COPRODUCT"
        txt = txt.replace('∐', '&coprod;');

        // "U+02211", "N-ARY SUMMATION"
        txt = txt.replace('∑', '&sum;');

        // "U+02212", "MINUS SIGN"
        txt = txt.replace('−', '&minus;');

        // "U+02213", "MINUS-OR-PLUS SIGN"
        txt = txt.replace('∓', '&mnplus;');

        // "U+02214", "DOT PLUS"
        txt = txt.replace('∔', '&plusdo;');

        // "U+02216", "SET MINUS"
        txt = txt.replace('∖', '&setmn;');

        // "U+02217", "ASTERISK OPERATOR"
        txt = txt.replace('∗', '&lowast;');

        // "U+02218", "RING OPERATOR"
        txt = txt.replace('∘', '&compfn;');

        // "U+0221A", "SQUARE ROOT"
        txt = txt.replace('√', '&radic;');

        // "U+0221D", "PROPORTIONAL TO"
        txt = txt.replace('∝', '&prop;');

        // "U+0221E", "INFINITY"
        txt = txt.replace('∞', '&infin;');

        // "U+0221F", "RIGHT ANGLE"
        txt = txt.replace('∟', '&angrt;');

        // "U+02220", "ANGLE"
        txt = txt.replace('∠', '&ang;');

        // "U+02221", "MEASURED ANGLE"
        txt = txt.replace('∡', '&angmsd;');

        // "U+02222", "SPHERICAL ANGLE"
        txt = txt.replace('∢', '&angsph;');

        // "U+02223", "DIVIDES"
        txt = txt.replace('∣', '&mid;');

        // "U+02224", "DOES NOT DIVIDE"
        txt = txt.replace('∤', '&nmid;');

        // "U+02225", "PARALLEL TO"
        txt = txt.replace('∥', '&par;');

        // "U+02226", "NOT PARALLEL TO"
        txt = txt.replace('∦', '&npar;');

        // "U+02227", "LOGICAL AND"
        txt = txt.replace('∧', '&and;');

        // "U+02228", "LOGICAL OR"
        txt = txt.replace('∨', '&or;');

        // "U+02229", "INTERSECTION"
        txt = txt.replace('∩', '&cap;');

        // "U+0222A", "UNION"
        txt = txt.replace('∪', '&cup;');

        // "U+0222B", "INTEGRAL"
        txt = txt.replace('∫', '&int;');

        // "U+0222C", "DOUBLE INTEGRAL"
        txt = txt.replace('∬', '&Int;');

        // "U+0222D", "TRIPLE INTEGRAL"
        txt = txt.replace('∭', '&tint;');

        // "U+0222E", "CONTOUR INTEGRAL"
        txt = txt.replace('∮', '&conint;');

        // "U+0222F", "SURFACE INTEGRAL"
        txt = txt.replace('∯', '&Conint;');

        // "U+02230", "VOLUME INTEGRAL"
        txt = txt.replace('∰', '&Cconint;');

        // "U+02231", "CLOCKWISE INTEGRAL"
        txt = txt.replace('∱', '&cwint;');

        // "U+02232", "CLOCKWISE CONTOUR INTEGRAL"
        txt = txt.replace('∲', '&cwconint;');

        // "U+02233", "ANTICLOCKWISE CONTOUR INTEGRAL"
        txt = txt.replace('∳', '&awconint;');

        // "U+02234", "THEREFORE"
        txt = txt.replace('∴', '&there4;');

        // "U+02235", "BECAUSE"
        txt = txt.replace('∵', '&becaus;');

        // "U+02236", "RATIO"
        txt = txt.replace('∶', '&ratio;');

        // "U+02237", "PROPORTION"
        txt = txt.replace('∷', '&Colon;');

        // "U+02238", "DOT MINUS"
        txt = txt.replace('∸', '&minusd;');

        // "U+0223A", "GEOMETRIC PROPORTION"
        txt = txt.replace('∺', '&mDDot;');

        // "U+0223B", "HOMOTHETIC"
        txt = txt.replace('∻', '&homtht;');

        // "U+0223C", "TILDE OPERATOR"
        txt = txt.replace('∼', '&sim;');

        // "U+0223D", "REVERSED TILDE"
        txt = txt.replace('∽', '&bsim;');

        // "U+0223E", "INVERTED LAZY S"
        txt = txt.replace('∾', '&ac;');

        // "U+0223F", "SINE WAVE"
        txt = txt.replace('∿', '&acd;');

        // "U+02240", "WREATH PRODUCT"
        txt = txt.replace('≀', '&wreath;');

        // "U+02241", "NOT TILDE"
        txt = txt.replace('≁', '&nsim;');

        // "U+02242", "MINUS TILDE"
        txt = txt.replace('≂', '&esim;');

        // "U+02243", "ASYMPTOTICALLY EQUAL TO"
        txt = txt.replace('≃', '&sime;');

        // "U+02244", "NOT ASYMPTOTICALLY EQUAL TO"
        txt = txt.replace('≄', '&nsime;');

        // "U+02245", "APPROXIMATELY EQUAL TO"
        txt = txt.replace('≅', '&cong;');

        // "U+02246", "APPROXIMATELY BUT NOT ACTUALLY EQUAL TO"
        txt = txt.replace('≆', '&simne;');

        // "U+02247", "NEITHER APPROXIMATELY NOR ACTUALLY EQUAL TO"
        txt = txt.replace('≇', '&ncong;');

        // "U+02248", "ALMOST EQUAL TO"
        txt = txt.replace('≈', '&asymp;');

        // "U+02249", "NOT ALMOST EQUAL TO"
        txt = txt.replace('≉', '&nap;');

        // "U+0224A", "ALMOST EQUAL OR EQUAL TO"
        txt = txt.replace('≊', '&ape;');

        // "U+0224B", "TRIPLE TILDE"
        txt = txt.replace('≋', '&apid;');

        // "U+0224C", "ALL EQUAL TO"
        txt = txt.replace('≌', '&bcong;');

        // "U+0224D", "EQUIVALENT TO"
        txt = txt.replace('≍', '&asympeq;');

        // "U+0224E", "GEOMETRICALLY EQUIVALENT TO"
        txt = txt.replace('≎', '&bump;');

        // "U+0224F", "DIFFERENCE BETWEEN"
        txt = txt.replace('≏', '&bumpe;');

        // "U+02250", "APPROACHES THE LIMIT"
        txt = txt.replace('≐', '&esdot;');

        // "U+02251", "GEOMETRICALLY EQUAL TO"
        txt = txt.replace('≑', '&eDot;');

        // "U+02252", "APPROXIMATELY EQUAL TO OR THE IMAGE OF"
        txt = txt.replace('≒', '&efDot;');

        // "U+02253", "IMAGE OF OR APPROXIMATELY EQUAL TO"
        txt = txt.replace('≓', '&erDot;');

        // "U+02254", "COLON EQUALS"
        txt = txt.replace('≔', '&colone;');

        // "U+02255", "EQUALS COLON"
        txt = txt.replace('≕', '&ecolon;');

        // "U+02256", "RING IN EQUAL TO"
        txt = txt.replace('≖', '&ecir;');

        // "U+02257", "RING EQUAL TO"
        txt = txt.replace('≗', '&cire;');

        // "U+02259", "ESTIMATES"
        txt = txt.replace('≙', '&wedgeq;');

        // "U+0225A", "EQUIANGULAR TO"
        txt = txt.replace('≚', '&veeeq;');

        // "U+0225C", "DELTA EQUAL TO"
        txt = txt.replace('≜', '&trie;');

        // "U+0225F", "QUESTIONED EQUAL TO"
        txt = txt.replace('≟', '&equest;');

        // "U+02260", "NOT EQUAL TO"
        txt = txt.replace('≠', '&ne;');

        // "U+02261", "IDENTICAL TO"
        txt = txt.replace('≡', '&equiv;');

        // "U+02262", "NOT IDENTICAL TO"
        txt = txt.replace('≢', '&nequiv;');

        // "U+02264", "LESS-THAN OR EQUAL TO"
        txt = txt.replace('≤', '&le;');

        // "U+02265", "GREATER-THAN OR EQUAL TO"
        txt = txt.replace('≥', '&ge;');

        // "U+02266", "LESS-THAN OVER EQUAL TO"
        txt = txt.replace('≦', '&lE;');

        // "U+02267", "GREATER-THAN OVER EQUAL TO"
        txt = txt.replace('≧', '&gE;');

        // "U+02268", "LESS-THAN BUT NOT EQUAL TO"
        txt = txt.replace('≨', '&lnE;');

        // "U+02269", "GREATER-THAN BUT NOT EQUAL TO"
        txt = txt.replace('≩', '&gnE;');

        // "U+0226A", "MUCH LESS-THAN"
        txt = txt.replace('≪', '&Lt;');

        // "U+0226B", "MUCH GREATER-THAN"
        txt = txt.replace('≫', '&Gt;');

        // "U+0226C", "BETWEEN"
        txt = txt.replace('≬', '&twixt;');

        // "U+0226D", "NOT EQUIVALENT TO"
        txt = txt.replace('≭', '&NotCupCap;');

        // "U+0226E", "NOT LESS-THAN"
        txt = txt.replace('≮', '&nlt;');

        // "U+0226F", "NOT GREATER-THAN"
        txt = txt.replace('≯', '&ngt;');

        // "U+02270", "NEITHER LESS-THAN NOR EQUAL TO"
        txt = txt.replace('≰', '&nle;');

        // "U+02271", "NEITHER GREATER-THAN NOR EQUAL TO"
        txt = txt.replace('≱', '&nge;');

        // "U+02272", "LESS-THAN OR EQUIVALENT TO"
        txt = txt.replace('≲', '&lsim;');

        // "U+02273", "GREATER-THAN OR EQUIVALENT TO"
        txt = txt.replace('≳', '&gsim;');

        // "U+02274", "NEITHER LESS-THAN NOR EQUIVALENT TO"
        txt = txt.replace('≴', '&nlsim;');

        // "U+02275", "NEITHER GREATER-THAN NOR EQUIVALENT TO"
        txt = txt.replace('≵', '&ngsim;');

        // "U+02276", "LESS-THAN OR GREATER-THAN"
        txt = txt.replace('≶', '&lg;');

        // "U+02277", "GREATER-THAN OR LESS-THAN"
        txt = txt.replace('≷', '&gl;');

        // "U+02278", "NEITHER LESS-THAN NOR GREATER-THAN"
        txt = txt.replace('≸', '&ntlg;');

        // "U+02279", "NEITHER GREATER-THAN NOR LESS-THAN"
        txt = txt.replace('≹', '&ntgl;');

        // "U+0227A", "PRECEDES"
        txt = txt.replace('≺', '&pr;');

        // "U+0227B", "SUCCEEDS"
        txt = txt.replace('≻', '&sc;');

        // "U+0227C", "PRECEDES OR EQUAL TO"
        txt = txt.replace('≼', '&prcue;');

        // "U+0227D", "SUCCEEDS OR EQUAL TO"
        txt = txt.replace('≽', '&sccue;');

        // "U+0227E", "PRECEDES OR EQUIVALENT TO"
        txt = txt.replace('≾', '&prsim;');

        // "U+0227F", "SUCCEEDS OR EQUIVALENT TO"
        txt = txt.replace('≿', '&scsim;');

        // "U+02280", "DOES NOT PRECEDE"
        txt = txt.replace('⊀', '&npr;');

        // "U+02281", "DOES NOT SUCCEED"
        txt = txt.replace('⊁', '&nsc;');

        // "U+02282", "SUBSET OF"
        txt = txt.replace('⊂', '&sub;');

        // "U+02283", "SUPERSET OF"
        txt = txt.replace('⊃', '&sup;');

        // "U+02284", "NOT A SUBSET OF"
        txt = txt.replace('⊄', '&nsub;');

        // "U+02285", "NOT A SUPERSET OF"
        txt = txt.replace('⊅', '&nsup;');

        // "U+02286", "SUBSET OF OR EQUAL TO"
        txt = txt.replace('⊆', '&sube;');

        // "U+02287", "SUPERSET OF OR EQUAL TO"
        txt = txt.replace('⊇', '&supe;');

        // "U+02288", "NEITHER A SUBSET OF NOR EQUAL TO"
        txt = txt.replace('⊈', '&nsube;');

        // "U+02289", "NEITHER A SUPERSET OF NOR EQUAL TO"
        txt = txt.replace('⊉', '&nsupe;');

        // "U+0228A", "SUBSET OF WITH NOT EQUAL TO"
        txt = txt.replace('⊊', '&subne;');

        // "U+0228B", "SUPERSET OF WITH NOT EQUAL TO"
        txt = txt.replace('⊋', '&supne;');

        // "U+0228D", "MULTISET MULTIPLICATION"
        txt = txt.replace('⊍', '&cupdot;');

        // "U+0228E", "MULTISET UNION"
        txt = txt.replace('⊎', '&uplus;');

        // "U+0228F", "SQUARE IMAGE OF"
        txt = txt.replace('⊏', '&sqsub;');

        // "U+02290", "SQUARE ORIGINAL OF"
        txt = txt.replace('⊐', '&sqsup;');

        // "U+02291", "SQUARE IMAGE OF OR EQUAL TO"
        txt = txt.replace('⊑', '&sqsube;');

        // "U+02292", "SQUARE ORIGINAL OF OR EQUAL TO"
        txt = txt.replace('⊒', '&sqsupe;');

        // "U+02293", "SQUARE CAP"
        txt = txt.replace('⊓', '&sqcap;');

        // "U+02294", "SQUARE CUP"
        txt = txt.replace('⊔', '&sqcup;');

        // "U+02295", "CIRCLED PLUS"
        txt = txt.replace('⊕', '&oplus;');

        // "U+02296", "CIRCLED MINUS"
        txt = txt.replace('⊖', '&ominus;');

        // "U+02297", "CIRCLED TIMES"
        txt = txt.replace('⊗', '&otimes;');

        // "U+02298", "CIRCLED DIVISION SLASH"
        txt = txt.replace('⊘', '&osol;');

        // "U+02299", "CIRCLED DOT OPERATOR"
        txt = txt.replace('⊙', '&odot;');

        // "U+0229A", "CIRCLED RING OPERATOR"
        txt = txt.replace('⊚', '&ocir;');

        // "U+0229B", "CIRCLED ASTERISK OPERATOR"
        txt = txt.replace('⊛', '&oast;');

        // "U+0229D", "CIRCLED DASH"
        txt = txt.replace('⊝', '&odash;');

        // "U+0229E", "SQUARED PLUS"
        txt = txt.replace('⊞', '&plusb;');

        // "U+0229F", "SQUARED MINUS"
        txt = txt.replace('⊟', '&minusb;');

        // "U+022A0", "SQUARED TIMES"
        txt = txt.replace('⊠', '&timesb;');

        // "U+022A1", "SQUARED DOT OPERATOR"
        txt = txt.replace('⊡', '&sdotb;');

        // "U+022A2", "RIGHT TACK"
        txt = txt.replace('⊢', '&vdash;');

        // "U+022A3", "LEFT TACK"
        txt = txt.replace('⊣', '&dashv;');

        // "U+022A4", "DOWN TACK"
        txt = txt.replace('⊤', '&top;');

        // "U+022A5", "UP TACK"
        txt = txt.replace('⊥', '&bottom;');

        // "U+022A7", "MODELS"
        txt = txt.replace('⊧', '&models;');

        // "U+022A8", "TRUE"
        txt = txt.replace('⊨', '&vDash;');

        // "U+022A9", "FORCES"
        txt = txt.replace('⊩', '&Vdash;');

        // "U+022AA", "TRIPLE VERTICAL BAR RIGHT TURNSTILE"
        txt = txt.replace('⊪', '&Vvdash;');

        // "U+022AB", "DOUBLE VERTICAL BAR DOUBLE RIGHT TURNSTILE"
        txt = txt.replace('⊫', '&VDash;');

        // "U+022AC", "DOES NOT PROVE"
        txt = txt.replace('⊬', '&nvdash;');

        // "U+022AD", "NOT TRUE"
        txt = txt.replace('⊭', '&nvDash;');

        // "U+022AE", "DOES NOT FORCE"
        txt = txt.replace('⊮', '&nVdash;');

        // "U+022AF", "NEGATED DOUBLE VERTICAL BAR DOUBLE RIGHT TURNSTILE"
        txt = txt.replace('⊯', '&nVDash;');

        // "U+022B0", "PRECEDES UNDER RELATION"
        txt = txt.replace('⊰', '&prurel;');

        // "U+022B2", "NORMAL SUBGROUP OF"
        txt = txt.replace('⊲', '&vltri;');

        // "U+022B3", "CONTAINS AS NORMAL SUBGROUP"
        txt = txt.replace('⊳', '&vrtri;');

        // "U+022B4", "NORMAL SUBGROUP OF OR EQUAL TO"
        txt = txt.replace('⊴', '&ltrie;');

        // "U+022B5", "CONTAINS AS NORMAL SUBGROUP OR EQUAL TO"
        txt = txt.replace('⊵', '&rtrie;');

        // "U+022B6", "ORIGINAL OF"
        txt = txt.replace('⊶', '&origof;');

        // "U+022B7", "IMAGE OF"
        txt = txt.replace('⊷', '&imof;');

        // "U+022B8", "MULTIMAP"
        txt = txt.replace('⊸', '&mumap;');

        // "U+022B9", "HERMITIAN CONJUGATE MATRIX"
        txt = txt.replace('⊹', '&hercon;');

        // "U+022BA", "INTERCALATE"
        txt = txt.replace('⊺', '&intcal;');

        // "U+022BB", "XOR"
        txt = txt.replace('⊻', '&veebar;');

        // "U+022BD", "NOR"
        txt = txt.replace('⊽', '&barvee;');

        // "U+022BE", "RIGHT ANGLE WITH ARC"
        txt = txt.replace('⊾', '&angrtvb;');

        // "U+022BF", "RIGHT TRIANGLE"
        txt = txt.replace('⊿', '&lrtri;');

        // "U+022C0", "N-ARY LOGICAL AND"
        txt = txt.replace('⋀', '&xwedge;');

        // "U+022C1", "N-ARY LOGICAL OR"
        txt = txt.replace('⋁', '&xvee;');

        // "U+022C2", "N-ARY INTERSECTION"
        txt = txt.replace('⋂', '&xcap;');

        // "U+022C3", "N-ARY UNION"
        txt = txt.replace('⋃', '&xcup;');

        // "U+022C4", "DIAMOND OPERATOR"
        txt = txt.replace('⋄', '&diam;');

        // "U+022C5", "DOT OPERATOR"
        txt = txt.replace('⋅', '&sdot;');

        // "U+022C6", "STAR OPERATOR"
        txt = txt.replace('⋆', '&sstarf;');

        // "U+022C7", "DIVISION TIMES"
        txt = txt.replace('⋇', '&divonx;');

        // "U+022C8", "BOWTIE"
        txt = txt.replace('⋈', '&bowtie;');

        // "U+022C9", "LEFT NORMAL FACTOR SEMIDIRECT PRODUCT"
        txt = txt.replace('⋉', '&ltimes;');

        // "U+022CA", "RIGHT NORMAL FACTOR SEMIDIRECT PRODUCT"
        txt = txt.replace('⋊', '&rtimes;');

        // "U+022CB", "LEFT SEMIDIRECT PRODUCT"
        txt = txt.replace('⋋', '&lthree;');

        // "U+022CC", "RIGHT SEMIDIRECT PRODUCT"
        txt = txt.replace('⋌', '&rthree;');

        // "U+022CD", "REVERSED TILDE EQUALS"
        txt = txt.replace('⋍', '&bsime;');

        // "U+022CE", "CURLY LOGICAL OR"
        txt = txt.replace('⋎', '&cuvee;');

        // "U+022CF", "CURLY LOGICAL AND"
        txt = txt.replace('⋏', '&cuwed;');

        // "U+022D0", "DOUBLE SUBSET"
        txt = txt.replace('⋐', '&Sub;');

        // "U+022D1", "DOUBLE SUPERSET"
        txt = txt.replace('⋑', '&Sup;');

        // "U+022D2", "DOUBLE INTERSECTION"
        txt = txt.replace('⋒', '&Cap;');

        // "U+022D3", "DOUBLE UNION"
        txt = txt.replace('⋓', '&Cup;');

        // "U+022D4", "PITCHFORK"
        txt = txt.replace('⋔', '&fork;');

        // "U+022D5", "EQUAL AND PARALLEL TO"
        txt = txt.replace('⋕', '&epar;');

        // "U+022D6", "LESS-THAN WITH DOT"
        txt = txt.replace('⋖', '&ltdot;');

        // "U+022D7", "GREATER-THAN WITH DOT"
        txt = txt.replace('⋗', '&gtdot;');

        // "U+022D8", "VERY MUCH LESS-THAN"
        txt = txt.replace('⋘', '&Ll;');

        // "U+022D9", "VERY MUCH GREATER-THAN"
        txt = txt.replace('⋙', '&Gg;');

        // "U+022DA", "LESS-THAN EQUAL TO OR GREATER-THAN"
        txt = txt.replace('⋚', '&leg;');

        // "U+022DB", "GREATER-THAN EQUAL TO OR LESS-THAN"
        txt = txt.replace('⋛', '&gel;');

        // "U+022DE", "EQUAL TO OR PRECEDES"
        txt = txt.replace('⋞', '&cuepr;');

        // "U+022DF", "EQUAL TO OR SUCCEEDS"
        txt = txt.replace('⋟', '&cuesc;');

        // "U+022E0", "DOES NOT PRECEDE OR EQUAL"
        txt = txt.replace('⋠', '&nprcue;');

        // "U+022E1", "DOES NOT SUCCEED OR EQUAL"
        txt = txt.replace('⋡', '&nsccue;');

        // "U+022E2", "NOT SQUARE IMAGE OF OR EQUAL TO"
        txt = txt.replace('⋢', '&nsqsube;');

        // "U+022E3", "NOT SQUARE ORIGINAL OF OR EQUAL TO"
        txt = txt.replace('⋣', '&nsqsupe;');

        // "U+022E6", "LESS-THAN BUT NOT EQUIVALENT TO"
        txt = txt.replace('⋦', '&lnsim;');

        // "U+022E7", "GREATER-THAN BUT NOT EQUIVALENT TO"
        txt = txt.replace('⋧', '&gnsim;');

        // "U+022E8", "PRECEDES BUT NOT EQUIVALENT TO"
        txt = txt.replace('⋨', '&prnsim;');

        // "U+022E9", "SUCCEEDS BUT NOT EQUIVALENT TO"
        txt = txt.replace('⋩', '&scnsim;');

        // "U+022EA", "NOT NORMAL SUBGROUP OF"
        txt = txt.replace('⋪', '&nltri;');

        // "U+022EB", "DOES NOT CONTAIN AS NORMAL SUBGROUP"
        txt = txt.replace('⋫', '&nrtri;');

        // "U+022EC", "NOT NORMAL SUBGROUP OF OR EQUAL TO"
        txt = txt.replace('⋬', '&nltrie;');

        // "U+022ED", "DOES NOT CONTAIN AS NORMAL SUBGROUP OR EQUAL"
        txt = txt.replace('⋭', '&nrtrie;');

        // "U+022EE", "VERTICAL ELLIPSIS"
        txt = txt.replace('⋮', '&vellip;');

        // "U+022EF", "MIDLINE HORIZONTAL ELLIPSIS"
        txt = txt.replace('⋯', '&ctdot;');

        // "U+022F0", "UP RIGHT DIAGONAL ELLIPSIS"
        txt = txt.replace('⋰', '&utdot;');

        // "U+022F1", "DOWN RIGHT DIAGONAL ELLIPSIS"
        txt = txt.replace('⋱', '&dtdot;');

        // "U+022F2", "ELEMENT OF WITH LONG HORIZONTAL STROKE"
        txt = txt.replace('⋲', '&disin;');

        // "U+022F3", "ELEMENT OF WITH VERTICAL BAR AT END OF HORIZONTAL STROKE"
        txt = txt.replace('⋳', '&isinsv;');

        // "U+022F4", "SMALL ELEMENT OF WITH VERTICAL BAR AT END OF HORIZONTAL STROKE"
        txt = txt.replace('⋴', '&isins;');

        // "U+022F5", "ELEMENT OF WITH DOT ABOVE"
        txt = txt.replace('⋵', '&isindot;');

        // "U+022F6", "ELEMENT OF WITH OVERBAR"
        txt = txt.replace('⋶', '&notinvc;');

        // "U+022F7", "SMALL ELEMENT OF WITH OVERBAR"
        txt = txt.replace('⋷', '&notinvb;');

        // "U+022F9", "ELEMENT OF WITH TWO HORIZONTAL STROKES"
        txt = txt.replace('⋹', '&isinE;');

        // "U+022FA", "CONTAINS WITH LONG HORIZONTAL STROKE"
        txt = txt.replace('⋺', '&nisd;');

        // "U+022FB", "CONTAINS WITH VERTICAL BAR AT END OF HORIZONTAL STROKE"
        txt = txt.replace('⋻', '&xnis;');

        // "U+022FC", "SMALL CONTAINS WITH VERTICAL BAR AT END OF HORIZONTAL STROKE"
        txt = txt.replace('⋼', '&nis;');

        // "U+022FD", "CONTAINS WITH OVERBAR"
        txt = txt.replace('⋽', '&notnivc;');

        // "U+022FE", "SMALL CONTAINS WITH OVERBAR"
        txt = txt.replace('⋾', '&notnivb;');

        // "U+02305", "PROJECTIVE"
        txt = txt.replace('⌅', '&barwed;');

        // "U+02306", "PERSPECTIVE"
        txt = txt.replace('⌆', '&Barwed;');

        // "U+02308", "LEFT CEILING"
        txt = txt.replace('⌈', '&lceil;');

        // "U+02309", "RIGHT CEILING"
        txt = txt.replace('⌉', '&rceil;');

        // "U+0230A", "LEFT FLOOR"
        txt = txt.replace('⌊', '&lfloor;');

        // "U+0230B", "RIGHT FLOOR"
        txt = txt.replace('⌋', '&rfloor;');

        // "U+0230C", "BOTTOM RIGHT CROP"
        txt = txt.replace('⌌', '&drcrop;');

        // "U+0230D", "BOTTOM LEFT CROP"
        txt = txt.replace('⌍', '&dlcrop;');

        // "U+0230E", "TOP RIGHT CROP"
        txt = txt.replace('⌎', '&urcrop;');

        // "U+0230F", "TOP LEFT CROP"
        txt = txt.replace('⌏', '&ulcrop;');

        // "U+02310", "REVERSED NOT SIGN"
        txt = txt.replace('⌐', '&bnot;');

        // "U+02312", "ARC"
        txt = txt.replace('⌒', '&profline;');

        // "U+02313", "SEGMENT"
        txt = txt.replace('⌓', '&profsurf;');

        // "U+02315", "TELEPHONE RECORDER"
        txt = txt.replace('⌕', '&telrec;');

        // "U+02316", "POSITION INDICATOR"
        txt = txt.replace('⌖', '&target;');

        // "U+0231C", "TOP LEFT CORNER"
        txt = txt.replace('⌜', '&ulcorn;');

        // "U+0231D", "TOP RIGHT CORNER"
        txt = txt.replace('⌝', '&urcorn;');

        // "U+0231E", "BOTTOM LEFT CORNER"
        txt = txt.replace('⌞', '&dlcorn;');

        // "U+0231F", "BOTTOM RIGHT CORNER"
        txt = txt.replace('⌟', '&drcorn;');

        // "U+02322", "FROWN"
        txt = txt.replace('⌢', '&frown;');

        // "U+02323", "SMILE"
        txt = txt.replace('⌣', '&smile;');

        // "U+0232D", "CYLINDRICITY"
        txt = txt.replace('⌭', '&cylcty;');

        // "U+0232E", "ALL AROUND-PROFILE"
        txt = txt.replace('⌮', '&profalar;');

        // "U+02336", "APL FUNCTIONAL SYMBOL I-BEAM"
        txt = txt.replace('⌶', '&topbot;');

        // "U+0233D", "APL FUNCTIONAL SYMBOL CIRCLE STILE"
        txt = txt.replace('⌽', '&ovbar;');

        // "U+0233F", "APL FUNCTIONAL SYMBOL SLASH BAR"
        txt = txt.replace('⌿', '&solbar;');

        // "U+0237C", "RIGHT ANGLE WITH DOWNWARDS ZIGZAG ARROW"
        txt = txt.replace('⍼', '&angzarr;');

        // "U+023B0", "UPPER LEFT OR LOWER RIGHT CURLY BRACKET SECTION"
        txt = txt.replace('⎰', '&lmoust;');

        // "U+023B1", "UPPER RIGHT OR LOWER LEFT CURLY BRACKET SECTION"
        txt = txt.replace('⎱', '&rmoust;');

        // "U+023B4", "TOP SQUARE BRACKET"
        txt = txt.replace('⎴', '&tbrk;');

        // "U+023B5", "BOTTOM SQUARE BRACKET"
        txt = txt.replace('⎵', '&bbrk;');

        // "U+023B6", "BOTTOM SQUARE BRACKET OVER TOP SQUARE BRACKET"
        txt = txt.replace('⎶', '&bbrktbrk;');

        // "U+023DC", "TOP PARENTHESIS"
        txt = txt.replace('⏜', '&OverParenthesis;');

        // "U+023DD", "BOTTOM PARENTHESIS"
        txt = txt.replace('⏝', '&UnderParenthesis;');

        // "U+023DE", "TOP CURLY BRACKET"
        txt = txt.replace('⏞', '&OverBrace;');

        // "U+023DF", "BOTTOM CURLY BRACKET"
        txt = txt.replace('⏟', '&UnderBrace;');

        // "U+023E2", "WHITE TRAPEZIUM"
        txt = txt.replace('⏢', '&trpezium;');

        // "U+023E7", "ELECTRICAL INTERSECTION"
        txt = txt.replace('⏧', '&elinters;');

        // "U+02423", "OPEN BOX"
        txt = txt.replace('␣', '&blank;');

        // "U+024C8", "CIRCLED LATIN CAPITAL LETTER S"
        txt = txt.replace('Ⓢ', '&oS;');

        // "U+02500", "BOX DRAWINGS LIGHT HORIZONTAL"
        txt = txt.replace('─', '&boxh;');

        // "U+02502", "BOX DRAWINGS LIGHT VERTICAL"
        txt = txt.replace('│', '&boxv;');

        // "U+0250C", "BOX DRAWINGS LIGHT DOWN AND RIGHT"
        txt = txt.replace('┌', '&boxdr;');

        // "U+02510", "BOX DRAWINGS LIGHT DOWN AND LEFT"
        txt = txt.replace('┐', '&boxdl;');

        // "U+02514", "BOX DRAWINGS LIGHT UP AND RIGHT"
        txt = txt.replace('└', '&boxur;');

        // "U+02518", "BOX DRAWINGS LIGHT UP AND LEFT"
        txt = txt.replace('┘', '&boxul;');

        // "U+0251C", "BOX DRAWINGS LIGHT VERTICAL AND RIGHT"
        txt = txt.replace('├', '&boxvr;');

        // "U+02524", "BOX DRAWINGS LIGHT VERTICAL AND LEFT"
        txt = txt.replace('┤', '&boxvl;');

        // "U+0252C", "BOX DRAWINGS LIGHT DOWN AND HORIZONTAL"
        txt = txt.replace('┬', '&boxhd;');

        // "U+02534", "BOX DRAWINGS LIGHT UP AND HORIZONTAL"
        txt = txt.replace('┴', '&boxhu;');

        // "U+0253C", "BOX DRAWINGS LIGHT VERTICAL AND HORIZONTAL"
        txt = txt.replace('┼', '&boxvh;');

        // "U+02550", "BOX DRAWINGS DOUBLE HORIZONTAL"
        txt = txt.replace('═', '&boxH;');

        // "U+02551", "BOX DRAWINGS DOUBLE VERTICAL"
        txt = txt.replace('║', '&boxV;');

        // "U+02552", "BOX DRAWINGS DOWN SINGLE AND RIGHT DOUBLE"
        txt = txt.replace('╒', '&boxdR;');

        // "U+02553", "BOX DRAWINGS DOWN DOUBLE AND RIGHT SINGLE"
        txt = txt.replace('╓', '&boxDr;');

        // "U+02554", "BOX DRAWINGS DOUBLE DOWN AND RIGHT"
        txt = txt.replace('╔', '&boxDR;');

        // "U+02555", "BOX DRAWINGS DOWN SINGLE AND LEFT DOUBLE"
        txt = txt.replace('╕', '&boxdL;');

        // "U+02556", "BOX DRAWINGS DOWN DOUBLE AND LEFT SINGLE"
        txt = txt.replace('╖', '&boxDl;');

        // "U+02557", "BOX DRAWINGS DOUBLE DOWN AND LEFT"
        txt = txt.replace('╗', '&boxDL;');

        // "U+02558", "BOX DRAWINGS UP SINGLE AND RIGHT DOUBLE"
        txt = txt.replace('╘', '&boxuR;');

        // "U+02559", "BOX DRAWINGS UP DOUBLE AND RIGHT SINGLE"
        txt = txt.replace('╙', '&boxUr;');

        // "U+0255A", "BOX DRAWINGS DOUBLE UP AND RIGHT"
        txt = txt.replace('╚', '&boxUR;');

        // "U+0255B", "BOX DRAWINGS UP SINGLE AND LEFT DOUBLE"
        txt = txt.replace('╛', '&boxuL;');

        // "U+0255C", "BOX DRAWINGS UP DOUBLE AND LEFT SINGLE"
        txt = txt.replace('╜', '&boxUl;');

        // "U+0255D", "BOX DRAWINGS DOUBLE UP AND LEFT"
        txt = txt.replace('╝', '&boxUL;');

        // "U+0255E", "BOX DRAWINGS VERTICAL SINGLE AND RIGHT DOUBLE"
        txt = txt.replace('╞', '&boxvR;');

        // "U+0255F", "BOX DRAWINGS VERTICAL DOUBLE AND RIGHT SINGLE"
        txt = txt.replace('╟', '&boxVr;');

        // "U+02560", "BOX DRAWINGS DOUBLE VERTICAL AND RIGHT"
        txt = txt.replace('╠', '&boxVR;');

        // "U+02561", "BOX DRAWINGS VERTICAL SINGLE AND LEFT DOUBLE"
        txt = txt.replace('╡', '&boxvL;');

        // "U+02562", "BOX DRAWINGS VERTICAL DOUBLE AND LEFT SINGLE"
        txt = txt.replace('╢', '&boxVl;');

        // "U+02563", "BOX DRAWINGS DOUBLE VERTICAL AND LEFT"
        txt = txt.replace('╣', '&boxVL;');

        // "U+02564", "BOX DRAWINGS DOWN SINGLE AND HORIZONTAL DOUBLE"
        txt = txt.replace('╤', '&boxHd;');

        // "U+02565", "BOX DRAWINGS DOWN DOUBLE AND HORIZONTAL SINGLE"
        txt = txt.replace('╥', '&boxhD;');

        // "U+02566", "BOX DRAWINGS DOUBLE DOWN AND HORIZONTAL"
        txt = txt.replace('╦', '&boxHD;');

        // "U+02567", "BOX DRAWINGS UP SINGLE AND HORIZONTAL DOUBLE"
        txt = txt.replace('╧', '&boxHu;');

        // "U+02568", "BOX DRAWINGS UP DOUBLE AND HORIZONTAL SINGLE"
        txt = txt.replace('╨', '&boxhU;');

        // "U+02569", "BOX DRAWINGS DOUBLE UP AND HORIZONTAL"
        txt = txt.replace('╩', '&boxHU;');

        // "U+0256A", "BOX DRAWINGS VERTICAL SINGLE AND HORIZONTAL DOUBLE"
        txt = txt.replace('╪', '&boxvH;');

        // "U+0256B", "BOX DRAWINGS VERTICAL DOUBLE AND HORIZONTAL SINGLE"
        txt = txt.replace('╫', '&boxVh;');

        // "U+0256C", "BOX DRAWINGS DOUBLE VERTICAL AND HORIZONTAL"
        txt = txt.replace('╬', '&boxVH;');

        // "U+02580", "UPPER HALF BLOCK"
        txt = txt.replace('▀', '&uhblk;');

        // "U+02584", "LOWER HALF BLOCK"
        txt = txt.replace('▄', '&lhblk;');

        // "U+02588", "FULL BLOCK"
        txt = txt.replace('█', '&block;');

        // "U+02591", "LIGHT SHADE"
        txt = txt.replace('░', '&blk14;');

        // "U+02592", "MEDIUM SHADE"
        txt = txt.replace('▒', '&blk12;');

        // "U+02593", "DARK SHADE"
        txt = txt.replace('▓', '&blk34;');

        // "U+025A1", "WHITE SQUARE"
        txt = txt.replace('□', '&squ;');

        // "U+025AA", "BLACK SMALL SQUARE"
        txt = txt.replace('▪', '&squf;');

        // "U+025AB", "WHITE SMALL SQUARE"
        txt = txt.replace('▫', '&EmptyVerySmallSquare;');

        // "U+025AD", "WHITE RECTANGLE"
        txt = txt.replace('▭', '&rect;');

        // "U+025AE", "BLACK VERTICAL RECTANGLE"
        txt = txt.replace('▮', '&marker;');

        // "U+025B1", "WHITE PARALLELOGRAM"
        txt = txt.replace('▱', '&fltns;');

        // "U+025B3", "WHITE UP-POINTING TRIANGLE"
        txt = txt.replace('△', '&xutri;');

        // "U+025B4", "BLACK UP-POINTING SMALL TRIANGLE"
        txt = txt.replace('▴', '&utrif;');

        // "U+025B5", "WHITE UP-POINTING SMALL TRIANGLE"
        txt = txt.replace('▵', '&utri;');

        // "U+025B8", "BLACK RIGHT-POINTING SMALL TRIANGLE"
        txt = txt.replace('▸', '&rtrif;');

        // "U+025B9", "WHITE RIGHT-POINTING SMALL TRIANGLE"
        txt = txt.replace('▹', '&rtri;');

        // "U+025BD", "WHITE DOWN-POINTING TRIANGLE"
        txt = txt.replace('▽', '&xdtri;');

        // "U+025BE", "BLACK DOWN-POINTING SMALL TRIANGLE"
        txt = txt.replace('▾', '&dtrif;');

        // "U+025BF", "WHITE DOWN-POINTING SMALL TRIANGLE"
        txt = txt.replace('▿', '&dtri;');

        // "U+025C2", "BLACK LEFT-POINTING SMALL TRIANGLE"
        txt = txt.replace('◂', '&ltrif;');

        // "U+025C3", "WHITE LEFT-POINTING SMALL TRIANGLE"
        txt = txt.replace('◃', '&ltri;');

        // "U+025CA", "LOZENGE"
        txt = txt.replace('◊', '&loz;');

        // "U+025CB", "WHITE CIRCLE"
        txt = txt.replace('○', '&cir;');

        // "U+025EC", "WHITE UP-POINTING TRIANGLE WITH DOT"
        txt = txt.replace('◬', '&tridot;');

        // "U+025EF", "LARGE CIRCLE"
        txt = txt.replace('◯', '&xcirc;');

        // "U+025F8", "UPPER LEFT TRIANGLE"
        txt = txt.replace('◸', '&ultri;');

        // "U+025F9", "UPPER RIGHT TRIANGLE"
        txt = txt.replace('◹', '&urtri;');

        // "U+025FA", "LOWER LEFT TRIANGLE"
        txt = txt.replace('◺', '&lltri;');

        // "U+025FB", "WHITE MEDIUM SQUARE"
        txt = txt.replace('◻', '&EmptySmallSquare;');

        // "U+025FC", "BLACK MEDIUM SQUARE"
        txt = txt.replace('◼', '&FilledSmallSquare;');

        // "U+02605", "BLACK STAR"
        txt = txt.replace('★', '&starf;');

        // "U+02606", "WHITE STAR"
        txt = txt.replace('☆', '&star;');

        // "U+0260E", "BLACK TELEPHONE"
        txt = txt.replace('☎', '&phone;');

        // "U+02640", "FEMALE SIGN"
        txt = txt.replace('♀', '&female;');

        // "U+02642", "MALE SIGN"
        txt = txt.replace('♂', '&male;');

        // "U+02660", "BLACK SPADE SUIT"
        txt = txt.replace('♠', '&spades;');

        // "U+02663", "BLACK CLUB SUIT"
        txt = txt.replace('♣', '&clubs;');

        // "U+02665", "BLACK HEART SUIT"
        txt = txt.replace('♥', '&hearts;');

        // "U+02666", "BLACK DIAMOND SUIT"
        txt = txt.replace('♦', '&diams;');

        // "U+0266A", "EIGHTH NOTE"
        txt = txt.replace('♪', '&sung;');

        // "U+0266D", "MUSIC FLAT SIGN"
        txt = txt.replace('♭', '&flat;');

        // "U+0266E", "MUSIC NATURAL SIGN"
        txt = txt.replace('♮', '&natur;');

        // "U+0266F", "MUSIC SHARP SIGN"
        txt = txt.replace('♯', '&sharp;');

        // "U+02713", "CHECK MARK"
        txt = txt.replace('✓', '&check;');

        // "U+02717", "BALLOT X"
        txt = txt.replace('✗', '&cross;');

        // "U+02720", "MALTESE CROSS"
        txt = txt.replace('✠', '&malt;');

        // "U+02736", "SIX POINTED BLACK STAR"
        txt = txt.replace('✶', '&sext;');

        // "U+02758", "LIGHT VERTICAL BAR"
        txt = txt.replace('❘', '&VerticalSeparator;');

        // "U+02772", "LIGHT LEFT TORTOISE SHELL BRACKET ORNAMENT"
        txt = txt.replace('❲', '&lbbrk;');

        // "U+02773", "LIGHT RIGHT TORTOISE SHELL BRACKET ORNAMENT"
        txt = txt.replace('❳', '&rbbrk;');

        // "U+027E6", "MATHEMATICAL LEFT WHITE SQUARE BRACKET"
        txt = txt.replace('⟦', '&lobrk;');

        // "U+027E7", "MATHEMATICAL RIGHT WHITE SQUARE BRACKET"
        txt = txt.replace('⟧', '&robrk;');

        // "U+027E8", "MATHEMATICAL LEFT ANGLE BRACKET"
        txt = txt.replace('⟨', '&lang;');

        // "U+027E9", "MATHEMATICAL RIGHT ANGLE BRACKET"
        txt = txt.replace('⟩', '&rang;');

        // "U+027EA", "MATHEMATICAL LEFT DOUBLE ANGLE BRACKET"
        txt = txt.replace('⟪', '&Lang;');

        // "U+027EB", "MATHEMATICAL RIGHT DOUBLE ANGLE BRACKET"
        txt = txt.replace('⟫', '&Rang;');

        // "U+027EC", "MATHEMATICAL LEFT WHITE TORTOISE SHELL BRACKET"
        txt = txt.replace('⟬', '&loang;');

        // "U+027ED", "MATHEMATICAL RIGHT WHITE TORTOISE SHELL BRACKET"
        txt = txt.replace('⟭', '&roang;');

        // "U+027F5", "LONG LEFTWARDS ARROW"
        txt = txt.replace('⟵', '&xlarr;');

        // "U+027F6", "LONG RIGHTWARDS ARROW"
        txt = txt.replace('⟶', '&xrarr;');

        // "U+027F7", "LONG LEFT RIGHT ARROW"
        txt = txt.replace('⟷', '&xharr;');

        // "U+027F8", "LONG LEFTWARDS DOUBLE ARROW"
        txt = txt.replace('⟸', '&xlArr;');

        // "U+027F9", "LONG RIGHTWARDS DOUBLE ARROW"
        txt = txt.replace('⟹', '&xrArr;');

        // "U+027FA", "LONG LEFT RIGHT DOUBLE ARROW"
        txt = txt.replace('⟺', '&xhArr;');

        // "U+027FC", "LONG RIGHTWARDS ARROW FROM BAR"
        txt = txt.replace('⟼', '&xmap;');

        // "U+027FF", "LONG RIGHTWARDS SQUIGGLE ARROW"
        txt = txt.replace('⟿', '&dzigrarr;');

        // "U+02902", "LEFTWARDS DOUBLE ARROW WITH VERTICAL STROKE"
        txt = txt.replace('⤂', '&nvlArr;');

        // "U+02903", "RIGHTWARDS DOUBLE ARROW WITH VERTICAL STROKE"
        txt = txt.replace('⤃', '&nvrArr;');

        // "U+02904", "LEFT RIGHT DOUBLE ARROW WITH VERTICAL STROKE"
        txt = txt.replace('⤄', '&nvHarr;');

        // "U+02905", "RIGHTWARDS TWO-HEADED ARROW FROM BAR"
        txt = txt.replace('⤅', '&Map;');

        // "U+0290C", "LEFTWARDS DOUBLE DASH ARROW"
        txt = txt.replace('⤌', '&lbarr;');

        // "U+0290D", "RIGHTWARDS DOUBLE DASH ARROW"
        txt = txt.replace('⤍', '&rbarr;');

        // "U+0290E", "LEFTWARDS TRIPLE DASH ARROW"
        txt = txt.replace('⤎', '&lBarr;');

        // "U+0290F", "RIGHTWARDS TRIPLE DASH ARROW"
        txt = txt.replace('⤏', '&rBarr;');

        // "U+02910", "RIGHTWARDS TWO-HEADED TRIPLE DASH ARROW"
        txt = txt.replace('⤐', '&RBarr;');

        // "U+02911", "RIGHTWARDS ARROW WITH DOTTED STEM"
        txt = txt.replace('⤑', '&DDotrahd;');

        // "U+02912", "UPWARDS ARROW TO BAR"
        txt = txt.replace('⤒', '&UpArrowBar;');

        // "U+02913", "DOWNWARDS ARROW TO BAR"
        txt = txt.replace('⤓', '&DownArrowBar;');

        // "U+02916", "RIGHTWARDS TWO-HEADED ARROW WITH TAIL"
        txt = txt.replace('⤖', '&Rarrtl;');

        // "U+02919", "LEFTWARDS ARROW-TAIL"
        txt = txt.replace('⤙', '&latail;');

        // "U+0291A", "RIGHTWARDS ARROW-TAIL"
        txt = txt.replace('⤚', '&ratail;');

        // "U+0291B", "LEFTWARDS DOUBLE ARROW-TAIL"
        txt = txt.replace('⤛', '&lAtail;');

        // "U+0291C", "RIGHTWARDS DOUBLE ARROW-TAIL"
        txt = txt.replace('⤜', '&rAtail;');

        // "U+0291D", "LEFTWARDS ARROW TO BLACK DIAMOND"
        txt = txt.replace('⤝', '&larrfs;');

        // "U+0291E", "RIGHTWARDS ARROW TO BLACK DIAMOND"
        txt = txt.replace('⤞', '&rarrfs;');

        // "U+0291F", "LEFTWARDS ARROW FROM BAR TO BLACK DIAMOND"
        txt = txt.replace('⤟', '&larrbfs;');

        // "U+02920", "RIGHTWARDS ARROW FROM BAR TO BLACK DIAMOND"
        txt = txt.replace('⤠', '&rarrbfs;');

        // "U+02923", "NORTH WEST ARROW WITH HOOK"
        txt = txt.replace('⤣', '&nwarhk;');

        // "U+02924", "NORTH EAST ARROW WITH HOOK"
        txt = txt.replace('⤤', '&nearhk;');

        // "U+02925", "SOUTH EAST ARROW WITH HOOK"
        txt = txt.replace('⤥', '&searhk;');

        // "U+02926", "SOUTH WEST ARROW WITH HOOK"
        txt = txt.replace('⤦', '&swarhk;');

        // "U+02927", "NORTH WEST ARROW AND NORTH EAST ARROW"
        txt = txt.replace('⤧', '&nwnear;');

        // "U+02928", "NORTH EAST ARROW AND SOUTH EAST ARROW"
        txt = txt.replace('⤨', '&nesear;');

        // "U+02929", "SOUTH EAST ARROW AND SOUTH WEST ARROW"
        txt = txt.replace('⤩', '&seswar;');

        // "U+0292A", "SOUTH WEST ARROW AND NORTH WEST ARROW"
        txt = txt.replace('⤪', '&swnwar;');

        // "U+02933", "WAVE ARROW POINTING DIRECTLY RIGHT"
        txt = txt.replace('⤳', '&rarrc;');

        // "U+02935", "ARROW POINTING RIGHTWARDS THEN CURVING DOWNWARDS"
        txt = txt.replace('⤵', '&cudarrr;');

        // "U+02936", "ARROW POINTING DOWNWARDS THEN CURVING LEFTWARDS"
        txt = txt.replace('⤶', '&ldca;');

        // "U+02937", "ARROW POINTING DOWNWARDS THEN CURVING RIGHTWARDS"
        txt = txt.replace('⤷', '&rdca;');

        // "U+02938", "RIGHT-SIDE ARC CLOCKWISE ARROW"
        txt = txt.replace('⤸', '&cudarrl;');

        // "U+02939", "LEFT-SIDE ARC ANTICLOCKWISE ARROW"
        txt = txt.replace('⤹', '&larrpl;');

        // "U+0293C", "TOP ARC CLOCKWISE ARROW WITH MINUS"
        txt = txt.replace('⤼', '&curarrm;');

        // "U+0293D", "TOP ARC ANTICLOCKWISE ARROW WITH PLUS"
        txt = txt.replace('⤽', '&cularrp;');

        // "U+02945", "RIGHTWARDS ARROW WITH PLUS BELOW"
        txt = txt.replace('⥅', '&rarrpl;');

        // "U+02948", "LEFT RIGHT ARROW THROUGH SMALL CIRCLE"
        txt = txt.replace('⥈', '&harrcir;');

        // "U+02949", "UPWARDS TWO-HEADED ARROW FROM SMALL CIRCLE"
        txt = txt.replace('⥉', '&Uarrocir;');

        // "U+0294A", "LEFT BARB UP RIGHT BARB DOWN HARPOON"
        txt = txt.replace('⥊', '&lurdshar;');

        // "U+0294B", "LEFT BARB DOWN RIGHT BARB UP HARPOON"
        txt = txt.replace('⥋', '&ldrushar;');

        // "U+0294E", "LEFT BARB UP RIGHT BARB UP HARPOON"
        txt = txt.replace('⥎', '&LeftRightVector;');

        // "U+0294F", "UP BARB RIGHT DOWN BARB RIGHT HARPOON"
        txt = txt.replace('⥏', '&RightUpDownVector;');

        // "U+02950", "LEFT BARB DOWN RIGHT BARB DOWN HARPOON"
        txt = txt.replace('⥐', '&DownLeftRightVector;');

        // "U+02951", "UP BARB LEFT DOWN BARB LEFT HARPOON"
        txt = txt.replace('⥑', '&LeftUpDownVector;');

        // "U+02952", "LEFTWARDS HARPOON WITH BARB UP TO BAR"
        txt = txt.replace('⥒', '&LeftVectorBar;');

        // "U+02953", "RIGHTWARDS HARPOON WITH BARB UP TO BAR"
        txt = txt.replace('⥓', '&RightVectorBar;');

        // "U+02954", "UPWARDS HARPOON WITH BARB RIGHT TO BAR"
        txt = txt.replace('⥔', '&RightUpVectorBar;');

        // "U+02955", "DOWNWARDS HARPOON WITH BARB RIGHT TO BAR"
        txt = txt.replace('⥕', '&RightDownVectorBar;');

        // "U+02956", "LEFTWARDS HARPOON WITH BARB DOWN TO BAR"
        txt = txt.replace('⥖', '&DownLeftVectorBar;');

        // "U+02957", "RIGHTWARDS HARPOON WITH BARB DOWN TO BAR"
        txt = txt.replace('⥗', '&DownRightVectorBar;');

        // "U+02958", "UPWARDS HARPOON WITH BARB LEFT TO BAR"
        txt = txt.replace('⥘', '&LeftUpVectorBar;');

        // "U+02959", "DOWNWARDS HARPOON WITH BARB LEFT TO BAR"
        txt = txt.replace('⥙', '&LeftDownVectorBar;');

        // "U+0295A", "LEFTWARDS HARPOON WITH BARB UP FROM BAR"
        txt = txt.replace('⥚', '&LeftTeeVector;');

        // "U+0295B", "RIGHTWARDS HARPOON WITH BARB UP FROM BAR"
        txt = txt.replace('⥛', '&RightTeeVector;');

        // "U+0295C", "UPWARDS HARPOON WITH BARB RIGHT FROM BAR"
        txt = txt.replace('⥜', '&RightUpTeeVector;');

        // "U+0295D", "DOWNWARDS HARPOON WITH BARB RIGHT FROM BAR"
        txt = txt.replace('⥝', '&RightDownTeeVector;');

        // "U+0295E", "LEFTWARDS HARPOON WITH BARB DOWN FROM BAR"
        txt = txt.replace('⥞', '&DownLeftTeeVector;');

        // "U+0295F", "RIGHTWARDS HARPOON WITH BARB DOWN FROM BAR"
        txt = txt.replace('⥟', '&DownRightTeeVector;');

        // "U+02960", "UPWARDS HARPOON WITH BARB LEFT FROM BAR"
        txt = txt.replace('⥠', '&LeftUpTeeVector;');

        // "U+02961", "DOWNWARDS HARPOON WITH BARB LEFT FROM BAR"
        txt = txt.replace('⥡', '&LeftDownTeeVector;');

        // "U+02962", "LEFTWARDS HARPOON WITH BARB UP ABOVE LEFTWARDS HARPOON WITH BARB DOWN"
        txt = txt.replace('⥢', '&lHar;');

        // "U+02963", "UPWARDS HARPOON WITH BARB LEFT BESIDE UPWARDS HARPOON WITH BARB RIGHT"
        txt = txt.replace('⥣', '&uHar;');

        // "U+02964", "RIGHTWARDS HARPOON WITH BARB UP ABOVE RIGHTWARDS HARPOON WITH BARB DOWN"
        txt = txt.replace('⥤', '&rHar;');

        // "U+02965", "DOWNWARDS HARPOON WITH BARB LEFT BESIDE DOWNWARDS HARPOON WITH BARB RIGHT"
        txt = txt.replace('⥥', '&dHar;');

        // "U+02966", "LEFTWARDS HARPOON WITH BARB UP ABOVE RIGHTWARDS HARPOON WITH BARB UP"
        txt = txt.replace('⥦', '&luruhar;');

        // "U+02967", "LEFTWARDS HARPOON WITH BARB DOWN ABOVE RIGHTWARDS HARPOON WITH BARB DOWN"
        txt = txt.replace('⥧', '&ldrdhar;');

        // "U+02968", "RIGHTWARDS HARPOON WITH BARB UP ABOVE LEFTWARDS HARPOON WITH BARB UP"
        txt = txt.replace('⥨', '&ruluhar;');

        // "U+02969", "RIGHTWARDS HARPOON WITH BARB DOWN ABOVE LEFTWARDS HARPOON WITH BARB DOWN"
        txt = txt.replace('⥩', '&rdldhar;');

        // "U+0296A", "LEFTWARDS HARPOON WITH BARB UP ABOVE LONG DASH"
        txt = txt.replace('⥪', '&lharul;');

        // "U+0296B", "LEFTWARDS HARPOON WITH BARB DOWN BELOW LONG DASH"
        txt = txt.replace('⥫', '&llhard;');

        // "U+0296C", "RIGHTWARDS HARPOON WITH BARB UP ABOVE LONG DASH"
        txt = txt.replace('⥬', '&rharul;');

        // "U+0296D", "RIGHTWARDS HARPOON WITH BARB DOWN BELOW LONG DASH"
        txt = txt.replace('⥭', '&lrhard;');

        // "U+0296E", "UPWARDS HARPOON WITH BARB LEFT BESIDE DOWNWARDS HARPOON WITH BARB RIGHT"
        txt = txt.replace('⥮', '&udhar;');

        // "U+0296F", "DOWNWARDS HARPOON WITH BARB LEFT BESIDE UPWARDS HARPOON WITH BARB RIGHT"
        txt = txt.replace('⥯', '&duhar;');

        // "U+02970", "RIGHT DOUBLE ARROW WITH ROUNDED HEAD"
        txt = txt.replace('⥰', '&RoundImplies;');

        // "U+02971", "EQUALS SIGN ABOVE RIGHTWARDS ARROW"
        txt = txt.replace('⥱', '&erarr;');

        // "U+02972", "TILDE OPERATOR ABOVE RIGHTWARDS ARROW"
        txt = txt.replace('⥲', '&simrarr;');

        // "U+02973", "LEFTWARDS ARROW ABOVE TILDE OPERATOR"
        txt = txt.replace('⥳', '&larrsim;');

        // "U+02974", "RIGHTWARDS ARROW ABOVE TILDE OPERATOR"
        txt = txt.replace('⥴', '&rarrsim;');

        // "U+02975", "RIGHTWARDS ARROW ABOVE ALMOST EQUAL TO"
        txt = txt.replace('⥵', '&rarrap;');

        // "U+02976", "LESS-THAN ABOVE LEFTWARDS ARROW"
        txt = txt.replace('⥶', '&ltlarr;');

        // "U+02978", "GREATER-THAN ABOVE RIGHTWARDS ARROW"
        txt = txt.replace('⥸', '&gtrarr;');

        // "U+02979", "SUBSET ABOVE RIGHTWARDS ARROW"
        txt = txt.replace('⥹', '&subrarr;');

        // "U+0297B", "SUPERSET ABOVE LEFTWARDS ARROW"
        txt = txt.replace('⥻', '&suplarr;');

        // "U+0297C", "LEFT FISH TAIL"
        txt = txt.replace('⥼', '&lfisht;');

        // "U+0297D", "RIGHT FISH TAIL"
        txt = txt.replace('⥽', '&rfisht;');

        // "U+0297E", "UP FISH TAIL"
        txt = txt.replace('⥾', '&ufisht;');

        // "U+0297F", "DOWN FISH TAIL"
        txt = txt.replace('⥿', '&dfisht;');

        // "U+02985", "LEFT WHITE PARENTHESIS"
        txt = txt.replace('⦅', '&lopar;');

        // "U+02986", "RIGHT WHITE PARENTHESIS"
        txt = txt.replace('⦆', '&ropar;');

        // "U+0298B", "LEFT SQUARE BRACKET WITH UNDERBAR"
        txt = txt.replace('⦋', '&lbrke;');

        // "U+0298C", "RIGHT SQUARE BRACKET WITH UNDERBAR"
        txt = txt.replace('⦌', '&rbrke;');

        // "U+0298D", "LEFT SQUARE BRACKET WITH TICK IN TOP CORNER"
        txt = txt.replace('⦍', '&lbrkslu;');

        // "U+0298E", "RIGHT SQUARE BRACKET WITH TICK IN BOTTOM CORNER"
        txt = txt.replace('⦎', '&rbrksld;');

        // "U+0298F", "LEFT SQUARE BRACKET WITH TICK IN BOTTOM CORNER"
        txt = txt.replace('⦏', '&lbrksld;');

        // "U+02990", "RIGHT SQUARE BRACKET WITH TICK IN TOP CORNER"
        txt = txt.replace('⦐', '&rbrkslu;');

        // "U+02991", "LEFT ANGLE BRACKET WITH DOT"
        txt = txt.replace('⦑', '&langd;');

        // "U+02992", "RIGHT ANGLE BRACKET WITH DOT"
        txt = txt.replace('⦒', '&rangd;');

        // "U+02993", "LEFT ARC LESS-THAN BRACKET"
        txt = txt.replace('⦓', '&lparlt;');

        // "U+02994", "RIGHT ARC GREATER-THAN BRACKET"
        txt = txt.replace('⦔', '&rpargt;');

        // "U+02995", "DOUBLE LEFT ARC GREATER-THAN BRACKET"
        txt = txt.replace('⦕', '&gtlPar;');

        // "U+02996", "DOUBLE RIGHT ARC LESS-THAN BRACKET"
        txt = txt.replace('⦖', '&ltrPar;');

        // "U+0299A", "VERTICAL ZIGZAG LINE"
        txt = txt.replace('⦚', '&vzigzag;');

        // "U+0299C", "RIGHT ANGLE VARIANT WITH SQUARE"
        txt = txt.replace('⦜', '&vangrt;');

        // "U+0299D", "MEASURED RIGHT ANGLE WITH DOT"
        txt = txt.replace('⦝', '&angrtvbd;');

        // "U+029A4", "ANGLE WITH UNDERBAR"
        txt = txt.replace('⦤', '&ange;');

        // "U+029A5", "REVERSED ANGLE WITH UNDERBAR"
        txt = txt.replace('⦥', '&range;');

        // "U+029A6", "OBLIQUE ANGLE OPENING UP"
        txt = txt.replace('⦦', '&dwangle;');

        // "U+029A7", "OBLIQUE ANGLE OPENING DOWN"
        txt = txt.replace('⦧', '&uwangle;');

        // "U+029A8", "MEASURED ANGLE WITH OPEN ARM ENDING IN ARROW POINTING UP AND RIGHT"
        txt = txt.replace('⦨', '&angmsdaa;');

        // "U+029A9", "MEASURED ANGLE WITH OPEN ARM ENDING IN ARROW POINTING UP AND LEFT"
        txt = txt.replace('⦩', '&angmsdab;');

        // "U+029AA", "MEASURED ANGLE WITH OPEN ARM ENDING IN ARROW POINTING DOWN AND RIGHT"
        txt = txt.replace('⦪', '&angmsdac;');

        // "U+029AB", "MEASURED ANGLE WITH OPEN ARM ENDING IN ARROW POINTING DOWN AND LEFT"
        txt = txt.replace('⦫', '&angmsdad;');

        // "U+029AC", "MEASURED ANGLE WITH OPEN ARM ENDING IN ARROW POINTING RIGHT AND UP"
        txt = txt.replace('⦬', '&angmsdae;');

        // "U+029AD", "MEASURED ANGLE WITH OPEN ARM ENDING IN ARROW POINTING LEFT AND UP"
        txt = txt.replace('⦭', '&angmsdaf;');

        // "U+029AE", "MEASURED ANGLE WITH OPEN ARM ENDING IN ARROW POINTING RIGHT AND DOWN"
        txt = txt.replace('⦮', '&angmsdag;');

        // "U+029AF", "MEASURED ANGLE WITH OPEN ARM ENDING IN ARROW POINTING LEFT AND DOWN"
        txt = txt.replace('⦯', '&angmsdah;');

        // "U+029B0", "REVERSED EMPTY SET"
        txt = txt.replace('⦰', '&bemptyv;');

        // "U+029B1", "EMPTY SET WITH OVERBAR"
        txt = txt.replace('⦱', '&demptyv;');

        // "U+029B2", "EMPTY SET WITH SMALL CIRCLE ABOVE"
        txt = txt.replace('⦲', '&cemptyv;');

        // "U+029B3", "EMPTY SET WITH RIGHT ARROW ABOVE"
        txt = txt.replace('⦳', '&raemptyv;');

        // "U+029B4", "EMPTY SET WITH LEFT ARROW ABOVE"
        txt = txt.replace('⦴', '&laemptyv;');

        // "U+029B5", "CIRCLE WITH HORIZONTAL BAR"
        txt = txt.replace('⦵', '&ohbar;');

        // "U+029B6", "CIRCLED VERTICAL BAR"
        txt = txt.replace('⦶', '&omid;');

        // "U+029B7", "CIRCLED PARALLEL"
        txt = txt.replace('⦷', '&opar;');

        // "U+029B9", "CIRCLED PERPENDICULAR"
        txt = txt.replace('⦹', '&operp;');

        // "U+029BB", "CIRCLE WITH SUPERIMPOSED X"
        txt = txt.replace('⦻', '&olcross;');

        // "U+029BC", "CIRCLED ANTICLOCKWISE-ROTATED DIVISION SIGN"
        txt = txt.replace('⦼', '&odsold;');

        // "U+029BE", "CIRCLED WHITE BULLET"
        txt = txt.replace('⦾', '&olcir;');

        // "U+029BF", "CIRCLED BULLET"
        txt = txt.replace('⦿', '&ofcir;');

        // "U+029C0", "CIRCLED LESS-THAN"
        txt = txt.replace('⧀', '&olt;');

        // "U+029C1", "CIRCLED GREATER-THAN"
        txt = txt.replace('⧁', '&ogt;');

        // "U+029C2", "CIRCLE WITH SMALL CIRCLE TO THE RIGHT"
        txt = txt.replace('⧂', '&cirscir;');

        // "U+029C3", "CIRCLE WITH TWO HORIZONTAL STROKES TO THE RIGHT"
        txt = txt.replace('⧃', '&cirE;');

        // "U+029C4", "SQUARED RISING DIAGONAL SLASH"
        txt = txt.replace('⧄', '&solb;');

        // "U+029C5", "SQUARED FALLING DIAGONAL SLASH"
        txt = txt.replace('⧅', '&bsolb;');

        // "U+029C9", "TWO JOINED SQUARES"
        txt = txt.replace('⧉', '&boxbox;');

        // "U+029CD", "TRIANGLE WITH SERIFS AT BOTTOM"
        txt = txt.replace('⧍', '&trisb;');

        // "U+029CE", "RIGHT TRIANGLE ABOVE LEFT TRIANGLE"
        txt = txt.replace('⧎', '&rtriltri;');

        // "U+029CF", "LEFT TRIANGLE BESIDE VERTICAL BAR"
        txt = txt.replace('⧏', '&LeftTriangleBar;');

        // "U+029D0", "VERTICAL BAR BESIDE RIGHT TRIANGLE"
        txt = txt.replace('⧐', '&RightTriangleBar;');

        // "U+029DA", "LEFT DOUBLE WIGGLY FENCE"
        txt = txt.replace('⧚', '&race;');

        // "U+029DC", "INCOMPLETE INFINITY"
        txt = txt.replace('⧜', '&iinfin;');

        // "U+029DD", "TIE OVER INFINITY"
        txt = txt.replace('⧝', '&infintie;');

        // "U+029DE", "INFINITY NEGATED WITH VERTICAL BAR"
        txt = txt.replace('⧞', '&nvinfin;');

        // "U+029E3", "EQUALS SIGN AND SLANTED PARALLEL"
        txt = txt.replace('⧣', '&eparsl;');

        // "U+029E4", "EQUALS SIGN AND SLANTED PARALLEL WITH TILDE ABOVE"
        txt = txt.replace('⧤', '&smeparsl;');

        // "U+029E5", "IDENTICAL TO AND SLANTED PARALLEL"
        txt = txt.replace('⧥', '&eqvparsl;');

        // "U+029EB", "BLACK LOZENGE"
        txt = txt.replace('⧫', '&lozf;');

        // "U+029F4", "RULE-DELAYED"
        txt = txt.replace('⧴', '&RuleDelayed;');

        // "U+029F6", "SOLIDUS WITH OVERBAR"
        txt = txt.replace('⧶', '&dsol;');

        // "U+02A00", "N-ARY CIRCLED DOT OPERATOR"
        txt = txt.replace('⨀', '&xodot;');

        // "U+02A01", "N-ARY CIRCLED PLUS OPERATOR"
        txt = txt.replace('⨁', '&xoplus;');

        // "U+02A02", "N-ARY CIRCLED TIMES OPERATOR"
        txt = txt.replace('⨂', '&xotime;');

        // "U+02A04", "N-ARY UNION OPERATOR WITH PLUS"
        txt = txt.replace('⨄', '&xuplus;');

        // "U+02A06", "N-ARY SQUARE UNION OPERATOR"
        txt = txt.replace('⨆', '&xsqcup;');

        // "U+02A0C", "QUADRUPLE INTEGRAL OPERATOR"
        txt = txt.replace('⨌', '&qint;');

        // "U+02A0D", "FINITE PART INTEGRAL"
        txt = txt.replace('⨍', '&fpartint;');

        // "U+02A10", "CIRCULATION FUNCTION"
        txt = txt.replace('⨐', '&cirfnint;');

        // "U+02A11", "ANTICLOCKWISE INTEGRATION"
        txt = txt.replace('⨑', '&awint;');

        // "U+02A12", "LINE INTEGRATION WITH RECTANGULAR PATH AROUND POLE"
        txt = txt.replace('⨒', '&rppolint;');

        // "U+02A13", "LINE INTEGRATION WITH SEMICIRCULAR PATH AROUND POLE"
        txt = txt.replace('⨓', '&scpolint;');

        // "U+02A14", "LINE INTEGRATION NOT INCLUDING THE POLE"
        txt = txt.replace('⨔', '&npolint;');

        // "U+02A15", "INTEGRAL AROUND A POINT OPERATOR"
        txt = txt.replace('⨕', '&pointint;');

        // "U+02A16", "QUATERNION INTEGRAL OPERATOR"
        txt = txt.replace('⨖', '&quatint;');

        // "U+02A17", "INTEGRAL WITH LEFTWARDS ARROW WITH HOOK"
        txt = txt.replace('⨗', '&intlarhk;');

        // "U+02A22", "PLUS SIGN WITH SMALL CIRCLE ABOVE"
        txt = txt.replace('⨢', '&pluscir;');

        // "U+02A23", "PLUS SIGN WITH CIRCUMFLEX ACCENT ABOVE"
        txt = txt.replace('⨣', '&plusacir;');

        // "U+02A24", "PLUS SIGN WITH TILDE ABOVE"
        txt = txt.replace('⨤', '&simplus;');

        // "U+02A25", "PLUS SIGN WITH DOT BELOW"
        txt = txt.replace('⨥', '&plusdu;');

        // "U+02A26", "PLUS SIGN WITH TILDE BELOW"
        txt = txt.replace('⨦', '&plussim;');

        // "U+02A27", "PLUS SIGN WITH SUBSCRIPT TWO"
        txt = txt.replace('⨧', '&plustwo;');

        // "U+02A29", "MINUS SIGN WITH COMMA ABOVE"
        txt = txt.replace('⨩', '&mcomma;');

        // "U+02A2A", "MINUS SIGN WITH DOT BELOW"
        txt = txt.replace('⨪', '&minusdu;');

        // "U+02A2D", "PLUS SIGN IN LEFT HALF CIRCLE"
        txt = txt.replace('⨭', '&loplus;');

        // "U+02A2E", "PLUS SIGN IN RIGHT HALF CIRCLE"
        txt = txt.replace('⨮', '&roplus;');

        // "U+02A2F", "VECTOR OR CROSS PRODUCT"
        txt = txt.replace('⨯', '&Cross;');

        // "U+02A30", "MULTIPLICATION SIGN WITH DOT ABOVE"
        txt = txt.replace('⨰', '&timesd;');

        // "U+02A31", "MULTIPLICATION SIGN WITH UNDERBAR"
        txt = txt.replace('⨱', '&timesbar;');

        // "U+02A33", "SMASH PRODUCT"
        txt = txt.replace('⨳', '&smashp;');

        // "U+02A34", "MULTIPLICATION SIGN IN LEFT HALF CIRCLE"
        txt = txt.replace('⨴', '&lotimes;');

        // "U+02A35", "MULTIPLICATION SIGN IN RIGHT HALF CIRCLE"
        txt = txt.replace('⨵', '&rotimes;');

        // "U+02A36", "CIRCLED MULTIPLICATION SIGN WITH CIRCUMFLEX ACCENT"
        txt = txt.replace('⨶', '&otimesas;');

        // "U+02A37", "MULTIPLICATION SIGN IN DOUBLE CIRCLE"
        txt = txt.replace('⨷', '&Otimes;');

        // "U+02A38", "CIRCLED DIVISION SIGN"
        txt = txt.replace('⨸', '&odiv;');

        // "U+02A39", "PLUS SIGN IN TRIANGLE"
        txt = txt.replace('⨹', '&triplus;');

        // "U+02A3A", "MINUS SIGN IN TRIANGLE"
        txt = txt.replace('⨺', '&triminus;');

        // "U+02A3B", "MULTIPLICATION SIGN IN TRIANGLE"
        txt = txt.replace('⨻', '&tritime;');

        // "U+02A3C", "INTERIOR PRODUCT"
        txt = txt.replace('⨼', '&iprod;');

        // "U+02A3F", "AMALGAMATION OR COPRODUCT"
        txt = txt.replace('⨿', '&amalg;');

        // "U+02A40", "INTERSECTION WITH DOT"
        txt = txt.replace('⩀', '&capdot;');

        // "U+02A42", "UNION WITH OVERBAR"
        txt = txt.replace('⩂', '&ncup;');

        // "U+02A43", "INTERSECTION WITH OVERBAR"
        txt = txt.replace('⩃', '&ncap;');

        // "U+02A44", "INTERSECTION WITH LOGICAL AND"
        txt = txt.replace('⩄', '&capand;');

        // "U+02A45", "UNION WITH LOGICAL OR"
        txt = txt.replace('⩅', '&cupor;');

        // "U+02A46", "UNION ABOVE INTERSECTION"
        txt = txt.replace('⩆', '&cupcap;');

        // "U+02A47", "INTERSECTION ABOVE UNION"
        txt = txt.replace('⩇', '&capcup;');

        // "U+02A48", "UNION ABOVE BAR ABOVE INTERSECTION"
        txt = txt.replace('⩈', '&cupbrcap;');

        // "U+02A49", "INTERSECTION ABOVE BAR ABOVE UNION"
        txt = txt.replace('⩉', '&capbrcup;');

        // "U+02A4A", "UNION BESIDE AND JOINED WITH UNION"
        txt = txt.replace('⩊', '&cupcup;');

        // "U+02A4B", "INTERSECTION BESIDE AND JOINED WITH INTERSECTION"
        txt = txt.replace('⩋', '&capcap;');

        // "U+02A4C", "CLOSED UNION WITH SERIFS"
        txt = txt.replace('⩌', '&ccups;');

        // "U+02A4D", "CLOSED INTERSECTION WITH SERIFS"
        txt = txt.replace('⩍', '&ccaps;');

        // "U+02A50", "CLOSED UNION WITH SERIFS AND SMASH PRODUCT"
        txt = txt.replace('⩐', '&ccupssm;');

        // "U+02A53", "DOUBLE LOGICAL AND"
        txt = txt.replace('⩓', '&And;');

        // "U+02A54", "DOUBLE LOGICAL OR"
        txt = txt.replace('⩔', '&Or;');

        // "U+02A55", "TWO INTERSECTING LOGICAL AND"
        txt = txt.replace('⩕', '&andand;');

        // "U+02A56", "TWO INTERSECTING LOGICAL OR"
        txt = txt.replace('⩖', '&oror;');

        // "U+02A57", "SLOPING LARGE OR"
        txt = txt.replace('⩗', '&orslope;');

        // "U+02A58", "SLOPING LARGE AND"
        txt = txt.replace('⩘', '&andslope;');

        // "U+02A5A", "LOGICAL AND WITH MIDDLE STEM"
        txt = txt.replace('⩚', '&andv;');

        // "U+02A5B", "LOGICAL OR WITH MIDDLE STEM"
        txt = txt.replace('⩛', '&orv;');

        // "U+02A5C", "LOGICAL AND WITH HORIZONTAL DASH"
        txt = txt.replace('⩜', '&andd;');

        // "U+02A5D", "LOGICAL OR WITH HORIZONTAL DASH"
        txt = txt.replace('⩝', '&ord;');

        // "U+02A5F", "LOGICAL AND WITH UNDERBAR"
        txt = txt.replace('⩟', '&wedbar;');

        // "U+02A66", "EQUALS SIGN WITH DOT BELOW"
        txt = txt.replace('⩦', '&sdote;');

        // "U+02A6A", "TILDE OPERATOR WITH DOT ABOVE"
        txt = txt.replace('⩪', '&simdot;');

        // "U+02A6D", "CONGRUENT WITH DOT ABOVE"
        txt = txt.replace('⩭', '&congdot;');

        // "U+02A6E", "EQUALS WITH ASTERISK"
        txt = txt.replace('⩮', '&easter;');

        // "U+02A6F", "ALMOST EQUAL TO WITH CIRCUMFLEX ACCENT"
        txt = txt.replace('⩯', '&apacir;');

        // "U+02A70", "APPROXIMATELY EQUAL OR EQUAL TO"
        txt = txt.replace('⩰', '&apE;');

        // "U+02A71", "EQUALS SIGN ABOVE PLUS SIGN"
        txt = txt.replace('⩱', '&eplus;');

        // "U+02A72", "PLUS SIGN ABOVE EQUALS SIGN"
        txt = txt.replace('⩲', '&pluse;');

        // "U+02A73", "EQUALS SIGN ABOVE TILDE OPERATOR"
        txt = txt.replace('⩳', '&Esim;');

        // "U+02A74", "DOUBLE COLON EQUAL"
        txt = txt.replace('⩴', '&Colone;');

        // "U+02A75", "TWO CONSECUTIVE EQUALS SIGNS"
        txt = txt.replace('⩵', '&Equal;');

        // "U+02A77", "EQUALS SIGN WITH TWO DOTS ABOVE AND TWO DOTS BELOW"
        txt = txt.replace('⩷', '&eDDot;');

        // "U+02A78", "EQUIVALENT WITH FOUR DOTS ABOVE"
        txt = txt.replace('⩸', '&equivDD;');

        // "U+02A79", "LESS-THAN WITH CIRCLE INSIDE"
        txt = txt.replace('⩹', '&ltcir;');

        // "U+02A7A", "GREATER-THAN WITH CIRCLE INSIDE"
        txt = txt.replace('⩺', '&gtcir;');

        // "U+02A7B", "LESS-THAN WITH QUESTION MARK ABOVE"
        txt = txt.replace('⩻', '&ltquest;');

        // "U+02A7C", "GREATER-THAN WITH QUESTION MARK ABOVE"
        txt = txt.replace('⩼', '&gtquest;');

        // "U+02A7D", "LESS-THAN OR SLANTED EQUAL TO"
        txt = txt.replace('⩽', '&les;');

        // "U+02A7E", "GREATER-THAN OR SLANTED EQUAL TO"
        txt = txt.replace('⩾', '&ges;');

        // "U+02A7F", "LESS-THAN OR SLANTED EQUAL TO WITH DOT INSIDE"
        txt = txt.replace('⩿', '&lesdot;');

        // "U+02A80", "GREATER-THAN OR SLANTED EQUAL TO WITH DOT INSIDE"
        txt = txt.replace('⪀', '&gesdot;');

        // "U+02A81", "LESS-THAN OR SLANTED EQUAL TO WITH DOT ABOVE"
        txt = txt.replace('⪁', '&lesdoto;');

        // "U+02A82", "GREATER-THAN OR SLANTED EQUAL TO WITH DOT ABOVE"
        txt = txt.replace('⪂', '&gesdoto;');

        // "U+02A83", "LESS-THAN OR SLANTED EQUAL TO WITH DOT ABOVE RIGHT"
        txt = txt.replace('⪃', '&lesdotor;');

        // "U+02A84", "GREATER-THAN OR SLANTED EQUAL TO WITH DOT ABOVE LEFT"
        txt = txt.replace('⪄', '&gesdotol;');

        // "U+02A85", "LESS-THAN OR APPROXIMATE"
        txt = txt.replace('⪅', '&lap;');

        // "U+02A86", "GREATER-THAN OR APPROXIMATE"
        txt = txt.replace('⪆', '&gap;');

        // "U+02A87", "LESS-THAN AND SINGLE-LINE NOT EQUAL TO"
        txt = txt.replace('⪇', '&lne;');

        // "U+02A88", "GREATER-THAN AND SINGLE-LINE NOT EQUAL TO"
        txt = txt.replace('⪈', '&gne;');

        // "U+02A89", "LESS-THAN AND NOT APPROXIMATE"
        txt = txt.replace('⪉', '&lnap;');

        // "U+02A8A", "GREATER-THAN AND NOT APPROXIMATE"
        txt = txt.replace('⪊', '&gnap;');

        // "U+02A8B", "LESS-THAN ABOVE DOUBLE-LINE EQUAL ABOVE GREATER-THAN"
        txt = txt.replace('⪋', '&lEg;');

        // "U+02A8C", "GREATER-THAN ABOVE DOUBLE-LINE EQUAL ABOVE LESS-THAN"
        txt = txt.replace('⪌', '&gEl;');

        // "U+02A8D", "LESS-THAN ABOVE SIMILAR OR EQUAL"
        txt = txt.replace('⪍', '&lsime;');

        // "U+02A8E", "GREATER-THAN ABOVE SIMILAR OR EQUAL"
        txt = txt.replace('⪎', '&gsime;');

        // "U+02A8F", "LESS-THAN ABOVE SIMILAR ABOVE GREATER-THAN"
        txt = txt.replace('⪏', '&lsimg;');

        // "U+02A90", "GREATER-THAN ABOVE SIMILAR ABOVE LESS-THAN"
        txt = txt.replace('⪐', '&gsiml;');

        // "U+02A91", "LESS-THAN ABOVE GREATER-THAN ABOVE DOUBLE-LINE EQUAL"
        txt = txt.replace('⪑', '&lgE;');

        // "U+02A92", "GREATER-THAN ABOVE LESS-THAN ABOVE DOUBLE-LINE EQUAL"
        txt = txt.replace('⪒', '&glE;');

        // "U+02A93", "LESS-THAN ABOVE SLANTED EQUAL ABOVE GREATER-THAN ABOVE SLANTED EQUAL"
        txt = txt.replace('⪓', '&lesges;');

        // "U+02A94", "GREATER-THAN ABOVE SLANTED EQUAL ABOVE LESS-THAN ABOVE SLANTED EQUAL"
        txt = txt.replace('⪔', '&gesles;');

        // "U+02A95", "SLANTED EQUAL TO OR LESS-THAN"
        txt = txt.replace('⪕', '&els;');

        // "U+02A96", "SLANTED EQUAL TO OR GREATER-THAN"
        txt = txt.replace('⪖', '&egs;');

        // "U+02A97", "SLANTED EQUAL TO OR LESS-THAN WITH DOT INSIDE"
        txt = txt.replace('⪗', '&elsdot;');

        // "U+02A98", "SLANTED EQUAL TO OR GREATER-THAN WITH DOT INSIDE"
        txt = txt.replace('⪘', '&egsdot;');

        // "U+02A99", "DOUBLE-LINE EQUAL TO OR LESS-THAN"
        txt = txt.replace('⪙', '&el;');

        // "U+02A9A", "DOUBLE-LINE EQUAL TO OR GREATER-THAN"
        txt = txt.replace('⪚', '&eg;');

        // "U+02A9D", "SIMILAR OR LESS-THAN"
        txt = txt.replace('⪝', '&siml;');

        // "U+02A9E", "SIMILAR OR GREATER-THAN"
        txt = txt.replace('⪞', '&simg;');

        // "U+02A9F", "SIMILAR ABOVE LESS-THAN ABOVE EQUALS SIGN"
        txt = txt.replace('⪟', '&simlE;');

        // "U+02AA0", "SIMILAR ABOVE GREATER-THAN ABOVE EQUALS SIGN"
        txt = txt.replace('⪠', '&simgE;');

        // "U+02AA1", "DOUBLE NESTED LESS-THAN"
        txt = txt.replace('⪡', '&LessLess;');

        // "U+02AA2", "DOUBLE NESTED GREATER-THAN"
        txt = txt.replace('⪢', '&GreaterGreater;');

        // "U+02AA4", "GREATER-THAN OVERLAPPING LESS-THAN"
        txt = txt.replace('⪤', '&glj;');

        // "U+02AA5", "GREATER-THAN BESIDE LESS-THAN"
        txt = txt.replace('⪥', '&gla;');

        // "U+02AA6", "LESS-THAN CLOSED BY CURVE"
        txt = txt.replace('⪦', '&ltcc;');

        // "U+02AA7", "GREATER-THAN CLOSED BY CURVE"
        txt = txt.replace('⪧', '&gtcc;');

        // "U+02AA8", "LESS-THAN CLOSED BY CURVE ABOVE SLANTED EQUAL"
        txt = txt.replace('⪨', '&lescc;');

        // "U+02AA9", "GREATER-THAN CLOSED BY CURVE ABOVE SLANTED EQUAL"
        txt = txt.replace('⪩', '&gescc;');

        // "U+02AAA", "SMALLER THAN"
        txt = txt.replace('⪪', '&smt;');

        // "U+02AAB", "LARGER THAN"
        txt = txt.replace('⪫', '&lat;');

        // "U+02AAC", "SMALLER THAN OR EQUAL TO"
        txt = txt.replace('⪬', '&smte;');

        // "U+02AAD", "LARGER THAN OR EQUAL TO"
        txt = txt.replace('⪭', '&late;');

        // "U+02AAE", "EQUALS SIGN WITH BUMPY ABOVE"
        txt = txt.replace('⪮', '&bumpE;');

        // "U+02AAF", "PRECEDES ABOVE SINGLE-LINE EQUALS SIGN"
        txt = txt.replace('⪯', '&pre;');

        // "U+02AB0", "SUCCEEDS ABOVE SINGLE-LINE EQUALS SIGN"
        txt = txt.replace('⪰', '&sce;');

        // "U+02AB3", "PRECEDES ABOVE EQUALS SIGN"
        txt = txt.replace('⪳', '&prE;');

        // "U+02AB4", "SUCCEEDS ABOVE EQUALS SIGN"
        txt = txt.replace('⪴', '&scE;');

        // "U+02AB5", "PRECEDES ABOVE NOT EQUAL TO"
        txt = txt.replace('⪵', '&prnE;');

        // "U+02AB6", "SUCCEEDS ABOVE NOT EQUAL TO"
        txt = txt.replace('⪶', '&scnE;');

        // "U+02AB7", "PRECEDES ABOVE ALMOST EQUAL TO"
        txt = txt.replace('⪷', '&prap;');

        // "U+02AB8", "SUCCEEDS ABOVE ALMOST EQUAL TO"
        txt = txt.replace('⪸', '&scap;');

        // "U+02AB9", "PRECEDES ABOVE NOT ALMOST EQUAL TO"
        txt = txt.replace('⪹', '&prnap;');

        // "U+02ABA", "SUCCEEDS ABOVE NOT ALMOST EQUAL TO"
        txt = txt.replace('⪺', '&scnap;');

        // "U+02ABB", "DOUBLE PRECEDES"
        txt = txt.replace('⪻', '&Pr;');

        // "U+02ABC", "DOUBLE SUCCEEDS"
        txt = txt.replace('⪼', '&Sc;');

        // "U+02ABD", "SUBSET WITH DOT"
        txt = txt.replace('⪽', '&subdot;');

        // "U+02ABE", "SUPERSET WITH DOT"
        txt = txt.replace('⪾', '&supdot;');

        // "U+02ABF", "SUBSET WITH PLUS SIGN BELOW"
        txt = txt.replace('⪿', '&subplus;');

        // "U+02AC0", "SUPERSET WITH PLUS SIGN BELOW"
        txt = txt.replace('⫀', '&supplus;');

        // "U+02AC1", "SUBSET WITH MULTIPLICATION SIGN BELOW"
        txt = txt.replace('⫁', '&submult;');

        // "U+02AC2", "SUPERSET WITH MULTIPLICATION SIGN BELOW"
        txt = txt.replace('⫂', '&supmult;');

        // "U+02AC3", "SUBSET OF OR EQUAL TO WITH DOT ABOVE"
        txt = txt.replace('⫃', '&subedot;');

        // "U+02AC4", "SUPERSET OF OR EQUAL TO WITH DOT ABOVE"
        txt = txt.replace('⫄', '&supedot;');

        // "U+02AC5", "SUBSET OF ABOVE EQUALS SIGN"
        txt = txt.replace('⫅', '&subE;');

        // "U+02AC6", "SUPERSET OF ABOVE EQUALS SIGN"
        txt = txt.replace('⫆', '&supE;');

        // "U+02AC7", "SUBSET OF ABOVE TILDE OPERATOR"
        txt = txt.replace('⫇', '&subsim;');

        // "U+02AC8", "SUPERSET OF ABOVE TILDE OPERATOR"
        txt = txt.replace('⫈', '&supsim;');

        // "U+02ACB", "SUBSET OF ABOVE NOT EQUAL TO"
        txt = txt.replace('⫋', '&subnE;');

        // "U+02ACC", "SUPERSET OF ABOVE NOT EQUAL TO"
        txt = txt.replace('⫌', '&supnE;');

        // "U+02ACF", "CLOSED SUBSET"
        txt = txt.replace('⫏', '&csub;');

        // "U+02AD0", "CLOSED SUPERSET"
        txt = txt.replace('⫐', '&csup;');

        // "U+02AD1", "CLOSED SUBSET OR EQUAL TO"
        txt = txt.replace('⫑', '&csube;');

        // "U+02AD2", "CLOSED SUPERSET OR EQUAL TO"
        txt = txt.replace('⫒', '&csupe;');

        // "U+02AD3", "SUBSET ABOVE SUPERSET"
        txt = txt.replace('⫓', '&subsup;');

        // "U+02AD4", "SUPERSET ABOVE SUBSET"
        txt = txt.replace('⫔', '&supsub;');

        // "U+02AD5", "SUBSET ABOVE SUBSET"
        txt = txt.replace('⫕', '&subsub;');

        // "U+02AD6", "SUPERSET ABOVE SUPERSET"
        txt = txt.replace('⫖', '&supsup;');

        // "U+02AD7", "SUPERSET BESIDE SUBSET"
        txt = txt.replace('⫗', '&suphsub;');

        // "U+02AD8", "SUPERSET BESIDE AND JOINED BY DASH WITH SUBSET"
        txt = txt.replace('⫘', '&supdsub;');

        // "U+02AD9", "ELEMENT OF OPENING DOWNWARDS"
        txt = txt.replace('⫙', '&forkv;');

        // "U+02ADA", "PITCHFORK WITH TEE TOP"
        txt = txt.replace('⫚', '&topfork;');

        // "U+02ADB", "TRANSVERSAL INTERSECTION"
        txt = txt.replace('⫛', '&mlcp;');

        // "U+02AE4", "VERTICAL BAR DOUBLE LEFT TURNSTILE"
        txt = txt.replace('⫤', '&Dashv;');

        // "U+02AE6", "LONG DASH FROM LEFT MEMBER OF DOUBLE VERTICAL"
        txt = txt.replace('⫦', '&Vdashl;');

        // "U+02AE7", "SHORT DOWN TACK WITH OVERBAR"
        txt = txt.replace('⫧', '&Barv;');

        // "U+02AE8", "SHORT UP TACK WITH UNDERBAR"
        txt = txt.replace('⫨', '&vBar;');

        // "U+02AE9", "SHORT UP TACK ABOVE SHORT DOWN TACK"
        txt = txt.replace('⫩', '&vBarv;');

        // "U+02AEB", "DOUBLE UP TACK"
        txt = txt.replace('⫫', '&Vbar;');

        // "U+02AEC", "DOUBLE STROKE NOT SIGN"
        txt = txt.replace('⫬', '&Not;');

        // "U+02AED", "REVERSED DOUBLE STROKE NOT SIGN"
        txt = txt.replace('⫭', '&bNot;');

        // "U+02AEE", "DOES NOT DIVIDE WITH REVERSED NEGATION SLASH"
        txt = txt.replace('⫮', '&rnmid;');

        // "U+02AEF", "VERTICAL LINE WITH CIRCLE ABOVE"
        txt = txt.replace('⫯', '&cirmid;');

        // "U+02AF0", "VERTICAL LINE WITH CIRCLE BELOW"
        txt = txt.replace('⫰', '&midcir;');

        // "U+02AF1", "DOWN TACK WITH CIRCLE BELOW"
        txt = txt.replace('⫱', '&topcir;');

        // "U+02AF2", "PARALLEL WITH HORIZONTAL STROKE"
        txt = txt.replace('⫲', '&nhpar;');

        // "U+02AF3", "PARALLEL WITH TILDE OPERATOR"
        txt = txt.replace('⫳', '&parsim;');

        // "U+02AFD", "DOUBLE SOLIDUS OPERATOR"
        txt = txt.replace('⫽', '&parsl;');

        // "U+0FB00", "LATIN SMALL LIGATURE FF"
        txt = txt.replace('ﬀ', '&fflig;');

        // "U+0FB01", "LATIN SMALL LIGATURE FI"
        txt = txt.replace('ﬁ', '&filig;');

        // "U+0FB02", "LATIN SMALL LIGATURE FL"
        txt = txt.replace('ﬂ', '&fllig;');

        // "U+0FB03", "LATIN SMALL LIGATURE FFI"
        txt = txt.replace('ﬃ', '&ffilig;');

        // "U+0FB04", "LATIN SMALL LIGATURE FFL"
        txt = txt.replace('ﬄ', '&ffllig;');

        // "U+1D49C", "MATHEMATICAL SCRIPT CAPITAL A"
        txt = txt.replace('𝒜', '&Ascr;');

        // "U+1D49E", "MATHEMATICAL SCRIPT CAPITAL C"
        txt = txt.replace('𝒞', '&Cscr;');

        // "U+1D49F", "MATHEMATICAL SCRIPT CAPITAL D"
        txt = txt.replace('𝒟', '&Dscr;');

        // "U+1D4A2", "MATHEMATICAL SCRIPT CAPITAL G"
        txt = txt.replace('𝒢', '&Gscr;');

        // "U+1D4A5", "MATHEMATICAL SCRIPT CAPITAL J"
        txt = txt.replace('𝒥', '&Jscr;');

        // "U+1D4A6", "MATHEMATICAL SCRIPT CAPITAL K"
        txt = txt.replace('𝒦', '&Kscr;');

        // "U+1D4A9", "MATHEMATICAL SCRIPT CAPITAL N"
        txt = txt.replace('𝒩', '&Nscr;');

        // "U+1D4AA", "MATHEMATICAL SCRIPT CAPITAL O"
        txt = txt.replace('𝒪', '&Oscr;');

        // "U+1D4AB", "MATHEMATICAL SCRIPT CAPITAL P"
        txt = txt.replace('𝒫', '&Pscr;');

        // "U+1D4AC", "MATHEMATICAL SCRIPT CAPITAL Q"
        txt = txt.replace('𝒬', '&Qscr;');

        // "U+1D4AE", "MATHEMATICAL SCRIPT CAPITAL S"
        txt = txt.replace('𝒮', '&Sscr;');

        // "U+1D4AF", "MATHEMATICAL SCRIPT CAPITAL T"
        txt = txt.replace('𝒯', '&Tscr;');

        // "U+1D4B0", "MATHEMATICAL SCRIPT CAPITAL U"
        txt = txt.replace('𝒰', '&Uscr;');

        // "U+1D4B1", "MATHEMATICAL SCRIPT CAPITAL V"
        txt = txt.replace('𝒱', '&Vscr;');

        // "U+1D4B2", "MATHEMATICAL SCRIPT CAPITAL W"
        txt = txt.replace('𝒲', '&Wscr;');

        // "U+1D4B3", "MATHEMATICAL SCRIPT CAPITAL X"
        txt = txt.replace('𝒳', '&Xscr;');

        // "U+1D4B4", "MATHEMATICAL SCRIPT CAPITAL Y"
        txt = txt.replace('𝒴', '&Yscr;');

        // "U+1D4B5", "MATHEMATICAL SCRIPT CAPITAL Z"
        txt = txt.replace('𝒵', '&Zscr;');

        // "U+1D4B6", "MATHEMATICAL SCRIPT SMALL A"
        txt = txt.replace('𝒶', '&ascr;');

        // "U+1D4B7", "MATHEMATICAL SCRIPT SMALL B"
        txt = txt.replace('𝒷', '&bscr;');

        // "U+1D4B8", "MATHEMATICAL SCRIPT SMALL C"
        txt = txt.replace('𝒸', '&cscr;');

        // "U+1D4B9", "MATHEMATICAL SCRIPT SMALL D"
        txt = txt.replace('𝒹', '&dscr;');

        // "U+1D4BB", "MATHEMATICAL SCRIPT SMALL F"
        txt = txt.replace('𝒻', '&fscr;');

        // "U+1D4BD", "MATHEMATICAL SCRIPT SMALL H"
        txt = txt.replace('𝒽', '&hscr;');

        // "U+1D4BE", "MATHEMATICAL SCRIPT SMALL I"
        txt = txt.replace('𝒾', '&iscr;');

        // "U+1D4BF", "MATHEMATICAL SCRIPT SMALL J"
        txt = txt.replace('𝒿', '&jscr;');

        // "U+1D4C0", "MATHEMATICAL SCRIPT SMALL K"
        txt = txt.replace('𝓀', '&kscr;');

        // "U+1D4C1", "MATHEMATICAL SCRIPT SMALL L"
        txt = txt.replace('𝓁', '&lscr;');

        // "U+1D4C2", "MATHEMATICAL SCRIPT SMALL M"
        txt = txt.replace('𝓂', '&mscr;');

        // "U+1D4C3", "MATHEMATICAL SCRIPT SMALL N"
        txt = txt.replace('𝓃', '&nscr;');

        // "U+1D4C5", "MATHEMATICAL SCRIPT SMALL P"
        txt = txt.replace('𝓅', '&pscr;');

        // "U+1D4C6", "MATHEMATICAL SCRIPT SMALL Q"
        txt = txt.replace('𝓆', '&qscr;');

        // "U+1D4C7", "MATHEMATICAL SCRIPT SMALL R"
        txt = txt.replace('𝓇', '&rscr;');

        // "U+1D4C8", "MATHEMATICAL SCRIPT SMALL S"
        txt = txt.replace('𝓈', '&sscr;');

        // "U+1D4C9", "MATHEMATICAL SCRIPT SMALL T"
        txt = txt.replace('𝓉', '&tscr;');

        // "U+1D4CA", "MATHEMATICAL SCRIPT SMALL U"
        txt = txt.replace('𝓊', '&uscr;');

        // "U+1D4CB", "MATHEMATICAL SCRIPT SMALL V"
        txt = txt.replace('𝓋', '&vscr;');

        // "U+1D4CC", "MATHEMATICAL SCRIPT SMALL W"
        txt = txt.replace('𝓌', '&wscr;');

        // "U+1D4CD", "MATHEMATICAL SCRIPT SMALL X"
        txt = txt.replace('𝓍', '&xscr;');

        // "U+1D4CE", "MATHEMATICAL SCRIPT SMALL Y"
        txt = txt.replace('𝓎', '&yscr;');

        // "U+1D4CF", "MATHEMATICAL SCRIPT SMALL Z"
        txt = txt.replace('𝓏', '&zscr;');

        // "U+1D504", "MATHEMATICAL FRAKTUR CAPITAL A"
        txt = txt.replace('𝔄', '&Afr;');

        // "U+1D505", "MATHEMATICAL FRAKTUR CAPITAL B"
        txt = txt.replace('𝔅', '&Bfr;');

        // "U+1D507", "MATHEMATICAL FRAKTUR CAPITAL D"
        txt = txt.replace('𝔇', '&Dfr;');

        // "U+1D508", "MATHEMATICAL FRAKTUR CAPITAL E"
        txt = txt.replace('𝔈', '&Efr;');

        // "U+1D509", "MATHEMATICAL FRAKTUR CAPITAL F"
        txt = txt.replace('𝔉', '&Ffr;');

        // "U+1D50A", "MATHEMATICAL FRAKTUR CAPITAL G"
        txt = txt.replace('𝔊', '&Gfr;');

        // "U+1D50D", "MATHEMATICAL FRAKTUR CAPITAL J"
        txt = txt.replace('𝔍', '&Jfr;');

        // "U+1D50E", "MATHEMATICAL FRAKTUR CAPITAL K"
        txt = txt.replace('𝔎', '&Kfr;');

        // "U+1D50F", "MATHEMATICAL FRAKTUR CAPITAL L"
        txt = txt.replace('𝔏', '&Lfr;');

        // "U+1D510", "MATHEMATICAL FRAKTUR CAPITAL M"
        txt = txt.replace('𝔐', '&Mfr;');

        // "U+1D511", "MATHEMATICAL FRAKTUR CAPITAL N"
        txt = txt.replace('𝔑', '&Nfr;');

        // "U+1D512", "MATHEMATICAL FRAKTUR CAPITAL O"
        txt = txt.replace('𝔒', '&Ofr;');

        // "U+1D513", "MATHEMATICAL FRAKTUR CAPITAL P"
        txt = txt.replace('𝔓', '&Pfr;');

        // "U+1D514", "MATHEMATICAL FRAKTUR CAPITAL Q"
        txt = txt.replace('𝔔', '&Qfr;');

        // "U+1D516", "MATHEMATICAL FRAKTUR CAPITAL S"
        txt = txt.replace('𝔖', '&Sfr;');

        // "U+1D517", "MATHEMATICAL FRAKTUR CAPITAL T"
        txt = txt.replace('𝔗', '&Tfr;');

        // "U+1D518", "MATHEMATICAL FRAKTUR CAPITAL U"
        txt = txt.replace('𝔘', '&Ufr;');

        // "U+1D519", "MATHEMATICAL FRAKTUR CAPITAL V"
        txt = txt.replace('𝔙', '&Vfr;');

        // "U+1D51A", "MATHEMATICAL FRAKTUR CAPITAL W"
        txt = txt.replace('𝔚', '&Wfr;');

        // "U+1D51B", "MATHEMATICAL FRAKTUR CAPITAL X"
        txt = txt.replace('𝔛', '&Xfr;');

        // "U+1D51C", "MATHEMATICAL FRAKTUR CAPITAL Y"
        txt = txt.replace('𝔜', '&Yfr;');

        // "U+1D51E", "MATHEMATICAL FRAKTUR SMALL A"
        txt = txt.replace('𝔞', '&afr;');

        // "U+1D51F", "MATHEMATICAL FRAKTUR SMALL B"
        txt = txt.replace('𝔟', '&bfr;');

        // "U+1D520", "MATHEMATICAL FRAKTUR SMALL C"
        txt = txt.replace('𝔠', '&cfr;');

        // "U+1D521", "MATHEMATICAL FRAKTUR SMALL D"
        txt = txt.replace('𝔡', '&dfr;');

        // "U+1D522", "MATHEMATICAL FRAKTUR SMALL E"
        txt = txt.replace('𝔢', '&efr;');

        // "U+1D523", "MATHEMATICAL FRAKTUR SMALL F"
        txt = txt.replace('𝔣', '&ffr;');

        // "U+1D524", "MATHEMATICAL FRAKTUR SMALL G"
        txt = txt.replace('𝔤', '&gfr;');

        // "U+1D525", "MATHEMATICAL FRAKTUR SMALL H"
        txt = txt.replace('𝔥', '&hfr;');

        // "U+1D526", "MATHEMATICAL FRAKTUR SMALL I"
        txt = txt.replace('𝔦', '&ifr;');

        // "U+1D527", "MATHEMATICAL FRAKTUR SMALL J"
        txt = txt.replace('𝔧', '&jfr;');

        // "U+1D528", "MATHEMATICAL FRAKTUR SMALL K"
        txt = txt.replace('𝔨', '&kfr;');

        // "U+1D529", "MATHEMATICAL FRAKTUR SMALL L"
        txt = txt.replace('𝔩', '&lfr;');

        // "U+1D52A", "MATHEMATICAL FRAKTUR SMALL M"
        txt = txt.replace('𝔪', '&mfr;');

        // "U+1D52B", "MATHEMATICAL FRAKTUR SMALL N"
        txt = txt.replace('𝔫', '&nfr;');

        // "U+1D52C", "MATHEMATICAL FRAKTUR SMALL O"
        txt = txt.replace('𝔬', '&ofr;');

        // "U+1D52D", "MATHEMATICAL FRAKTUR SMALL P"
        txt = txt.replace('𝔭', '&pfr;');

        // "U+1D52E", "MATHEMATICAL FRAKTUR SMALL Q"
        txt = txt.replace('𝔮', '&qfr;');

        // "U+1D52F", "MATHEMATICAL FRAKTUR SMALL R"
        txt = txt.replace('𝔯', '&rfr;');

        // "U+1D530", "MATHEMATICAL FRAKTUR SMALL S"
        txt = txt.replace('𝔰', '&sfr;');

        // "U+1D531", "MATHEMATICAL FRAKTUR SMALL T"
        txt = txt.replace('𝔱', '&tfr;');

        // "U+1D532", "MATHEMATICAL FRAKTUR SMALL U"
        txt = txt.replace('𝔲', '&ufr;');

        // "U+1D533", "MATHEMATICAL FRAKTUR SMALL V"
        txt = txt.replace('𝔳', '&vfr;');

        // "U+1D534", "MATHEMATICAL FRAKTUR SMALL W"
        txt = txt.replace('𝔴', '&wfr;');

        // "U+1D535", "MATHEMATICAL FRAKTUR SMALL X"
        txt = txt.replace('𝔵', '&xfr;');

        // "U+1D536", "MATHEMATICAL FRAKTUR SMALL Y"
        txt = txt.replace('𝔶', '&yfr;');

        // "U+1D537", "MATHEMATICAL FRAKTUR SMALL Z"
        txt = txt.replace('𝔷', '&zfr;');

        // "U+1D538", "MATHEMATICAL DOUBLE-STRUCK CAPITAL A"
        txt = txt.replace('𝔸', '&Aopf;');

        // "U+1D539", "MATHEMATICAL DOUBLE-STRUCK CAPITAL B"
        txt = txt.replace('𝔹', '&Bopf;');

        // "U+1D53B", "MATHEMATICAL DOUBLE-STRUCK CAPITAL D"
        txt = txt.replace('𝔻', '&Dopf;');

        // "U+1D53C", "MATHEMATICAL DOUBLE-STRUCK CAPITAL E"
        txt = txt.replace('𝔼', '&Eopf;');

        // "U+1D53D", "MATHEMATICAL DOUBLE-STRUCK CAPITAL F"
        txt = txt.replace('𝔽', '&Fopf;');

        // "U+1D53E", "MATHEMATICAL DOUBLE-STRUCK CAPITAL G"
        txt = txt.replace('𝔾', '&Gopf;');

        // "U+1D540", "MATHEMATICAL DOUBLE-STRUCK CAPITAL I"
        txt = txt.replace('𝕀', '&Iopf;');

        // "U+1D541", "MATHEMATICAL DOUBLE-STRUCK CAPITAL J"
        txt = txt.replace('𝕁', '&Jopf;');

        // "U+1D542", "MATHEMATICAL DOUBLE-STRUCK CAPITAL K"
        txt = txt.replace('𝕂', '&Kopf;');

        // "U+1D543", "MATHEMATICAL DOUBLE-STRUCK CAPITAL L"
        txt = txt.replace('𝕃', '&Lopf;');

        // "U+1D544", "MATHEMATICAL DOUBLE-STRUCK CAPITAL M"
        txt = txt.replace('𝕄', '&Mopf;');

        // "U+1D546", "MATHEMATICAL DOUBLE-STRUCK CAPITAL O"
        txt = txt.replace('𝕆', '&Oopf;');

        // "U+1D54A", "MATHEMATICAL DOUBLE-STRUCK CAPITAL S"
        txt = txt.replace('𝕊', '&Sopf;');

        // "U+1D54B", "MATHEMATICAL DOUBLE-STRUCK CAPITAL T"
        txt = txt.replace('𝕋', '&Topf;');

        // "U+1D54C", "MATHEMATICAL DOUBLE-STRUCK CAPITAL U"
        txt = txt.replace('𝕌', '&Uopf;');

        // "U+1D54D", "MATHEMATICAL DOUBLE-STRUCK CAPITAL V"
        txt = txt.replace('𝕍', '&Vopf;');

        // "U+1D54E", "MATHEMATICAL DOUBLE-STRUCK CAPITAL W"
        txt = txt.replace('𝕎', '&Wopf;');

        // "U+1D54F", "MATHEMATICAL DOUBLE-STRUCK CAPITAL X"
        txt = txt.replace('𝕏', '&Xopf;');

        // "U+1D550", "MATHEMATICAL DOUBLE-STRUCK CAPITAL Y"
        txt = txt.replace('𝕐', '&Yopf;');

        // "U+1D552", "MATHEMATICAL DOUBLE-STRUCK SMALL A"
        txt = txt.replace('𝕒', '&aopf;');

        // "U+1D553", "MATHEMATICAL DOUBLE-STRUCK SMALL B"
        txt = txt.replace('𝕓', '&bopf;');

        // "U+1D554", "MATHEMATICAL DOUBLE-STRUCK SMALL C"
        txt = txt.replace('𝕔', '&copf;');

        // "U+1D555", "MATHEMATICAL DOUBLE-STRUCK SMALL D"
        txt = txt.replace('𝕕', '&dopf;');

        // "U+1D556", "MATHEMATICAL DOUBLE-STRUCK SMALL E"
        txt = txt.replace('𝕖', '&eopf;');

        // "U+1D557", "MATHEMATICAL DOUBLE-STRUCK SMALL F"
        txt = txt.replace('𝕗', '&fopf;');

        // "U+1D558", "MATHEMATICAL DOUBLE-STRUCK SMALL G"
        txt = txt.replace('𝕘', '&gopf;');

        // "U+1D559", "MATHEMATICAL DOUBLE-STRUCK SMALL H"
        txt = txt.replace('𝕙', '&hopf;');

        // "U+1D55A", "MATHEMATICAL DOUBLE-STRUCK SMALL I"
        txt = txt.replace('𝕚', '&iopf;');

        // "U+1D55B", "MATHEMATICAL DOUBLE-STRUCK SMALL J"
        txt = txt.replace('𝕛', '&jopf;');

        // "U+1D55C", "MATHEMATICAL DOUBLE-STRUCK SMALL K"
        txt = txt.replace('𝕜', '&kopf;');

        // "U+1D55D", "MATHEMATICAL DOUBLE-STRUCK SMALL L"
        txt = txt.replace('𝕝', '&lopf;');

        // "U+1D55E", "MATHEMATICAL DOUBLE-STRUCK SMALL M"
        txt = txt.replace('𝕞', '&mopf;');

        // "U+1D55F", "MATHEMATICAL DOUBLE-STRUCK SMALL N"
        txt = txt.replace('𝕟', '&nopf;');

        // "U+1D560", "MATHEMATICAL DOUBLE-STRUCK SMALL O"
        txt = txt.replace('𝕠', '&oopf;');

        // "U+1D561", "MATHEMATICAL DOUBLE-STRUCK SMALL P"
        txt = txt.replace('𝕡', '&popf;');

        // "U+1D562", "MATHEMATICAL DOUBLE-STRUCK SMALL Q"
        txt = txt.replace('𝕢', '&qopf;');

        // "U+1D563", "MATHEMATICAL DOUBLE-STRUCK SMALL R"
        txt = txt.replace('𝕣', '&ropf;');

        // "U+1D564", "MATHEMATICAL DOUBLE-STRUCK SMALL S"
        txt = txt.replace('𝕤', '&sopf;');

        // "U+1D565", "MATHEMATICAL DOUBLE-STRUCK SMALL T"
        txt = txt.replace('𝕥', '&topf;');

        // "U+1D566", "MATHEMATICAL DOUBLE-STRUCK SMALL U"
        txt = txt.replace('𝕦', '&uopf;');

        // "U+1D567", "MATHEMATICAL DOUBLE-STRUCK SMALL V"
        txt = txt.replace('𝕧', '&vopf;');

        // "U+1D568", "MATHEMATICAL DOUBLE-STRUCK SMALL W"
        txt = txt.replace('𝕨', '&wopf;');

        // "U+1D569", "MATHEMATICAL DOUBLE-STRUCK SMALL X"
        txt = txt.replace('𝕩', '&xopf;');

        // "U+1D56A", "MATHEMATICAL DOUBLE-STRUCK SMALL Y"
        txt = txt.replace('𝕪', '&yopf;');

        // "U+1D56B", "MATHEMATICAL DOUBLE-STRUCK SMALL Z"
        txt = txt.replace('𝕫', '&zopf;');

        return txt;
    }

    /**
     * 入力される文字列内の文字や記号を文字実体参照に置きかえます。
     * @param sources 置きかえられる文字列の配列。
     * @param escapeSequenceFlag エスケープシーケンスを置きかえるフラグ。
     * @returns 置きかえられた文字列の配列。
     */
    public static convertToCharacterEntityReferenceAll(sources: string[], escapeSequenceFlag: boolean): string[] {
        for (let i = 0; i < sources.length; i++) {
            sources[i] = this.convertToCharacterEntityReference(sources[i], escapeSequenceFlag);
        }

        return sources;
    }
}

export default CharacterEntityReference;
