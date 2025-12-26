using System;
using System.Collections.Generic;
using System.Text;

public class MarkTexRenderer
{
    // Bold mapping
    static readonly Dictionary<char, string> BoldMap = new Dictionary<char, string>()
    {
        ['a'] = "𝐚",
        ['b'] = "𝐛",
        ['c'] = "𝐜",
        ['d'] = "𝐝",
        ['e'] = "𝐞",
        ['f'] = "𝐟",
        ['g'] = "𝐠",
        ['h'] = "𝐡",
        ['i'] = "𝐢",
        ['j'] = "𝐣",
        ['k'] = "𝐤",
        ['l'] = "𝐥",
        ['m'] = "𝐦",
        ['n'] = "𝐧",
        ['o'] = "𝐨",
        ['p'] = "𝐩",
        ['q'] = "𝐪",
        ['r'] = "𝐫",
        ['s'] = "𝐬",
        ['t'] = "𝐭",
        ['u'] = "𝐮",
        ['v'] = "𝐯",
        ['w'] = "𝐰",
        ['x'] = "𝐱",
        ['y'] = "𝐲",
        ['z'] = "𝐳",

        ['A'] = "𝐀",
        ['B'] = "𝐁",
        ['C'] = "𝐂",
        ['D'] = "𝐃",
        ['E'] = "𝐄",
        ['F'] = "𝐅",
        ['G'] = "𝐆",
        ['H'] = "𝐇",
        ['I'] = "𝐈",
        ['J'] = "𝐉",
        ['K'] = "𝐊",
        ['L'] = "𝐋",
        ['M'] = "𝐌",
        ['N'] = "𝐍",
        ['O'] = "𝐎",
        ['P'] = "𝐏",
        ['Q'] = "𝐐",
        ['R'] = "𝐑",
        ['S'] = "𝐒",
        ['T'] = "𝐓",
        ['U'] = "𝐔",
        ['V'] = "𝐕",
        ['W'] = "𝐖",
        ['X'] = "𝐗",
        ['Y'] = "𝐘",
        ['Z'] = "𝐙"
    };

    static readonly Dictionary<char, string> MonoMap = new Dictionary<char, string>()
    {
        ['a'] = "𝚊",
        ['b'] = "𝚋",
        ['c'] = "𝚌",
        ['d'] = "𝚍",
        ['e'] = "𝚎",
        ['f'] = "𝚏",
        ['g'] = "𝚐",
        ['h'] = "𝚑",
        ['i'] = "𝚒",
        ['j'] = "𝚓",
        ['k'] = "𝚔",
        ['l'] = "𝚕",
        ['m'] = "𝚖",
        ['n'] = "𝚗",
        ['o'] = "𝚘",
        ['p'] = "𝚙",
        ['q'] = "𝚚",
        ['r'] = "𝚛",
        ['s'] = "𝚜",
        ['t'] = "𝚝",
        ['u'] = "𝚞",
        ['v'] = "𝚟",
        ['w'] = "𝚠",
        ['x'] = "𝚡",
        ['y'] = "𝚢",
        ['z'] = "𝚣",

        ['A'] = "𝙰",
        ['B'] = "𝙱",
        ['C'] = "𝙲",
        ['D'] = "𝙳",
        ['E'] = "𝙴",
        ['F'] = "𝙵",
        ['G'] = "𝙶",
        ['H'] = "𝙷",
        ['I'] = "𝙸",
        ['J'] = "𝙹",
        ['K'] = "𝙺",
        ['L'] = "𝙻",
        ['M'] = "𝙼",
        ['N'] = "𝙽",
        ['O'] = "𝙾",
        ['P'] = "𝙿",
        ['Q'] = "𝚀",
        ['R'] = "𝚁",
        ['S'] = "𝚂",
        ['T'] = "𝚃",
        ['U'] = "𝚄",
        ['V'] = "𝚅",
        ['W'] = "𝚆",
        ['X'] = "𝚇",
        ['Y'] = "𝚈",
        ['Z'] = "𝚉",

        ['0'] = "𝟶",
        ['1'] = "𝟷",
        ['2'] = "𝟸",
        ['3'] = "𝟹",
        ['4'] = "𝟺",
        ['5'] = "𝟻",
        ['6'] = "𝟼",
        ['7'] = "𝟽",
        ['8'] = "𝟾",
        ['9'] = "𝟿"
    };


    static readonly Dictionary<char, string> ItalicMap = new Dictionary<char, string>()
    {
        // Lowercase (Mathematical Italic)
        ['a'] = "𝑎",
        ['b'] = "𝑏",
        ['c'] = "𝑐",
        ['d'] = "𝑑",
        ['e'] = "𝑒",
        ['f'] = "𝑓",
        ['g'] = "𝑔",
        ['h'] = "ℎ",
        ['i'] = "𝑖",
        ['j'] = "𝑗",
        ['k'] = "𝑘",
        ['l'] = "𝑙",
        ['m'] = "𝑚",
        ['n'] = "𝑛",
        ['o'] = "𝑜",
        ['p'] = "𝑝",
        ['q'] = "𝑞",
        ['r'] = "𝑟",
        ['s'] = "𝑠",
        ['t'] = "𝑡",
        ['u'] = "𝑢",
        ['v'] = "𝑣",
        ['w'] = "𝑤",
        ['x'] = "𝑥",
        ['y'] = "𝑦",
        ['z'] = "𝑧",

        // Uppercase (Mathematical Italic)
        ['A'] = "𝐴",
        ['B'] = "𝐵",
        ['C'] = "𝐶",
        ['D'] = "𝐷",
        ['E'] = "𝐸",
        ['F'] = "𝐹",
        ['G'] = "𝐺",
        ['H'] = "𝐻",
        ['I'] = "𝐼",
        ['J'] = "𝐽",
        ['K'] = "𝐾",
        ['L'] = "𝐿",
        ['M'] = "𝑀",
        ['N'] = "𝑁",
        ['O'] = "𝑂",
        ['P'] = "𝑃",
        ['Q'] = "𝑄",
        ['R'] = "𝑅",
        ['S'] = "𝑆",
        ['T'] = "𝑇",
        ['U'] = "𝑈",
        ['V'] = "𝑉",
        ['W'] = "𝑊",
        ['X'] = "𝑋",
        ['Y'] = "𝑌",
        ['Z'] = "𝑍",
        
        // Numbers
        ['0'] = "𝟎",
        ['1'] = "𝟏",
        ['2'] = "𝟐",
        ['3'] = "𝟑",
        ['4'] = "𝟒",
        ['5'] = "𝟓",
        ['6'] = "𝟔",
        ['7'] = "𝟕",
        ['8'] = "𝟖",
        ['9'] = "𝟗",
    };

    static readonly Dictionary<char, string> SubMap = new()
    {
        // digits
        ['0'] = "₀",
        ['1'] = "₁",
        ['2'] = "₂",
        ['3'] = "₃",
        ['4'] = "₄",
        ['5'] = "₅",
        ['6'] = "₆",
        ['7'] = "₇",
        ['8'] = "₈",
        ['9'] = "₉",

        // letters (supported)
        ['a'] = "ₐ",
        ['e'] = "ₑ",
        ['h'] = "ₕ",
        ['k'] = "ₖ",
        ['l'] = "ₗ",
        ['m'] = "ₘ",
        ['n'] = "ₙ",
        ['o'] = "ₒ",
        ['p'] = "ₚ",
        ['s'] = "ₛ",
        ['t'] = "ₜ",
        ['i'] = "ᵢ",
        ['j'] = "ⱼ",

        // symbols
        ['+'] = "₊",
        ['-'] = "₋",
        ['='] = "₌",
        ['('] = "₍",
        [')'] = "₎"
    };

    static readonly Dictionary<char, string> SuperMap = new()
    {
        // Digits
        ['0'] = "⁰",
        ['1'] = "¹",
        ['2'] = "²",
        ['3'] = "³",
        ['4'] = "⁴",
        ['5'] = "⁵",
        ['6'] = "⁶",
        ['7'] = "⁷",
        ['8'] = "⁸",
        ['9'] = "⁹",

        // Letters (supported)
        ['a'] = "ᵃ",
        ['b'] = "ᵇ",
        ['c'] = "ᶜ",
        ['d'] = "ᵈ",
        ['e'] = "ᵉ",
        ['f'] = "ᶠ",
        ['g'] = "ᵍ",
        ['h'] = "ʰ",
        ['i'] = "ⁱ",
        ['j'] = "ʲ",
        ['k'] = "ᵏ",
        ['l'] = "ˡ",
        ['m'] = "ᵐ",
        ['n'] = "ⁿ",
        ['o'] = "ᵒ",
        ['p'] = "ᵖ",
        ['r'] = "ʳ",
        ['s'] = "ˢ",
        ['t'] = "ᵗ",
        ['u'] = "ᵘ",
        ['v'] = "ᵛ",
        ['w'] = "ʷ",
        ['x'] = "ˣ",
        ['y'] = "ʸ",
        ['z'] = "ᶻ",

        // Uppercase letters (some supported)
        ['A'] = "ᴬ",
        ['B'] = "ᴮ",
        ['D'] = "ᴰ",
        ['E'] = "ᴱ",
        ['G'] = "ᴳ",
        ['H'] = "ᴴ",
        ['I'] = "ᴵ",
        ['J'] = "ᴶ",
        ['K'] = "ᴷ",
        ['L'] = "ᴸ",
        ['M'] = "ᴹ",
        ['N'] = "ᴺ",
        ['O'] = "ᴼ",
        ['P'] = "ᴾ",
        ['R'] = "ᴿ",
        ['T'] = "ᵀ",
        ['U'] = "ᵁ",
        ['V'] = "ⱽ",
        ['W'] = "ᵂ",

        // Symbols
        ['+'] = "⁺",
        ['-'] = "⁻",
        ['='] = "⁼",
        ['('] = "⁽",
        [')'] = "⁾"
    };

    static readonly Dictionary<string, string> BoldToNormalMap = new()
    {
        // Uppercase
        ["𝐀"] = "A",
        ["𝐁"] = "B",
        ["𝐂"] = "C",
        ["𝐃"] = "D",
        ["𝐄"] = "E",
        ["𝐅"] = "F",
        ["𝐆"] = "G",
        ["𝐇"] = "H",
        ["𝐈"] = "I",
        ["𝐉"] = "J",
        ["𝐊"] = "K",
        ["𝐋"] = "L",
        ["𝐌"] = "M",
        ["𝐍"] = "N",
        ["𝐎"] = "O",
        ["𝐏"] = "P",
        ["𝐐"] = "Q",
        ["𝐑"] = "R",
        ["𝐒"] = "S",
        ["𝐓"] = "T",
        ["𝐔"] = "U",
        ["𝐕"] = "V",
        ["𝐖"] = "W",
        ["𝐗"] = "X",
        ["𝐘"] = "Y",
        ["𝐙"] = "Z",

        // Lowercase
        ["𝐚"] = "a",
        ["𝐛"] = "b",
        ["𝐜"] = "c",
        ["𝐝"] = "d",
        ["𝐞"] = "e",
        ["𝐟"] = "f",
        ["𝐠"] = "g",
        ["𝐡"] = "h",
        ["𝐢"] = "i",
        ["𝐣"] = "j",
        ["𝐤"] = "k",
        ["𝐥"] = "l",
        ["𝐦"] = "m",
        ["𝐧"] = "n",
        ["𝐨"] = "o",
        ["𝐩"] = "p",
        ["𝐪"] = "q",
        ["𝐫"] = "r",
        ["𝐬"] = "s",
        ["𝐭"] = "t",
        ["𝐮"] = "u",
        ["𝐯"] = "v",
        ["𝐰"] = "w",
        ["𝐱"] = "x",
        ["𝐲"] = "y",
        ["𝐳"] = "z",
    };



    static string ToMono(string input)
    {
        var sb = new StringBuilder(input.Length);
        foreach (char c in input)
        {
            if (MonoMap.TryGetValue(c, out string? mono))
                sb.Append(mono);
            else
                sb.Append(c);
        }
        return sb.ToString();
    }



    static string ToBold(string input)
    {
        var sb = new StringBuilder(input.Length);
        foreach (char c in input)
        {
            if (BoldMap.TryGetValue(c, out string? bold))
                sb.Append(bold);
            else
                sb.Append(c);
        }
        return sb.ToString();
    }

    static string ToItalic(string input)
    {
        var sb = new StringBuilder(input.Length);
        foreach (char c in input)
        {
            if (ItalicMap.TryGetValue(c, out string? italic))
                sb.Append(italic);
            else
                sb.Append(c);
        }
        return sb.ToString();
    }

    static string NormalizeToken(string token)
    {
        var sb = new StringBuilder();

        for (int i = 0; i < token.Length;)
        {
            string current = char.IsSurrogate(token[i])
                ? token.Substring(i, 2)
                : token.Substring(i, 1);

            if (BoldToNormalMap.TryGetValue(current, out string? normal))
                sb.Append(normal);
            else
                sb.Append(current);

            i += current.Length;
        }

        return sb.ToString();
    }


    static Dictionary<string, string> symbolMap = new Dictionary<string, string>()
    {
        // Greek letters
        { "alpha", "α" },
        { "beta", "β" },
        { "gamma", "γ" },
        { "delta", "δ" },
        { "epsilon", "ε" },
        { "zeta", "ζ" },
        { "eta", "η" },
        { "theta", "θ" },
        { "iota", "ι" },
        { "kappa", "κ" },
        { "lambda", "λ" },
        { "mu", "μ" },
        { "nu", "ν" },
        { "xi", "ξ" },
        { "omicron", "ο" },
        { "pi", "π" },
        { "rho", "ρ" },
        { "sigma", "σ" },
        { "tau", "τ" },
        { "upsilon", "υ" },
        { "phi", "φ" },
        { "chi", "χ" },
        { "psi", "ψ" },
        { "omega", "ω" },

        // Capital Greek
        { "Alpha", "Α" },
        { "Beta", "Β" },
        { "Gamma", "Γ" },
        { "Delta", "Δ" },
        { "Theta", "Θ" },
        { "Lambda", "Λ" },
        { "Pi", "Π" },
        { "Sigma", "Σ" },
        { "Phi", "Φ" },
        { "Omega", "Ω" },
    
        // Math operators
        { "sum", "∑" },
        { "prod", "∏" },
        { "int", "∫" },
        { "oint", "∮" },
        { "sqrt", "√" },
        { "infty", "∞" },
        { "approx", "≈" },
        { "neq", "≠" },
        { "le", "≤" },
        { "ge", "≥" },
        { "times", "×" },
        { "div", "÷" },
        { "cdot", "⋅" },
        { "pm", "±" },
        { "mp", "∓" },
        { "equiv", "≡" },
        { "propto", "∝" },
        { "subset", "⊂" },
        { "subseteq", "⊆" },
        { "supset", "⊃" },
        { "supseteq", "⊇" },
        { "in", "∈" },
        { "notin", "∉" },
        { "forall", "∀" },
        { "exists", "∃" },
        { "neg", "¬" },
        { "wedge", "∧" },
        { "vee", "∨" },
        { "oplus", "⊕" },
        { "otimes", "⊗" },
        { "perp", "⊥" },
        { "partial", "∂" },
        { "nabla", "∇" },
        { "aleph", "ℵ" },
    
        // Arrows
        { "to", "→" },
        { "left", "←" },
        { "up", "↑" },
        { "down", "↓" },
        { "leftright", "↔" },
        { "Rightarrow", "⇒" },
        { "Leftarrow", "⇐" },
        { "Uparrow", "⇑" },
        { "Downarrow", "⇓" },
        { "Leftrightarrow", "⇔" },
        { "mapsto", "↦" },

        // Set theory
        { "emptyset", "∅" },
        { "cup", "∪" },
        { "cap", "∩" },
        { "setminus", "∖" },
        { "bigcup", "⋃" },
        { "bigcap", "⋂" },

        // Miscellaneous
        { "degree", "°" },
        { "prime", "′" },
        { "doubleprime", "″" },
        { "angle", "∠" },
        { "therefore", "∴" },
        { "because", "∵" },
        { "dots", "…" },
        { "cdots", "⋯" },
        { "vdots", "⋮" },
        { "ddots", "⋱" },

        // Mathematical Double-Struck
        { "R", "ℝ" },
        { "N", "ℕ" },
        { "Z", "ℤ" },
        { "Q", "ℚ" },
        { "C", "ℂ" },
    };


    static bool TryReadBraced(string input, int startIndex, out string content, out int endIndex)
    {
        content = "";
        endIndex = startIndex;

        if (startIndex >= input.Length || input[startIndex] != '{')
            return false;

        int depth = 0;
        int i = startIndex;

        while (i < input.Length)
        {
            if (input[i] == '{')
            {
                depth++;
                if (depth == 1) { i++; continue; }
            }
            else if (input[i] == '}')
            {
                depth--;
                if (depth == 0)
                {
                    endIndex = i;
                    return true;
                }
            }

            if (depth >= 1)
                content += input[i];

            i++;
        }

        return false;
    }

    private static string ToMathScript(char c, bool isSuper)
    {
        if (isSuper && SuperMap.ContainsKey(c))
            return SuperMap[c];

        if (!isSuper && SubMap.ContainsKey(c))
            return SubMap[c];

        return c.ToString();
    }


    static string PopLastToken(StringBuilder sb)
    {
        if (sb.Length == 0) return "";

        int end = sb.Length - 1;
        int start = end;

        while (start >= 0 && sb[start] != ' ')
            start--;

        start++; 

        int length = end - start + 1;
        string token = sb.ToString(start, length);

        sb.Remove(start, length); 

        return token;
    }

    public static string Convert(string input, bool UseBold)
    {
        var sb = new StringBuilder();
        bool inCodeBlock = false;
        bool inInlineCode = false;
        bool startOfLine = true;

        for (int i = 0; i < input.Length; i++)
        {
            // Detect start of line
            if (input[i] == '\n')
            {
                sb.Append('\n');
                startOfLine = true;
                continue;
            }


            // Detect code block ``` ... ```
            if (!inInlineCode && i + 2 < input.Length && input[i] == '`' &&
                input[i + 1] == '`' && input[i + 2] == '`')
            {
                inCodeBlock = !inCodeBlock;
                sb.Append("```");
                i += 2;
                continue;
            }

            // Detect inline code: `...`
            if (!inCodeBlock && input[i] == '`')
            {
                inInlineCode = !inInlineCode;
                sb.Append('`');
                continue;
            }

            if (inCodeBlock || inInlineCode)
            {
                sb.Append(ToMono(input[i].ToString()));
                continue;
            }


            // Detect symbol: \something
            if (input[i] == '\\')
            {
                int j = i + 1;
                while (j < input.Length && char.IsLetter(input[j]))
                    j++;

                string token = input.Substring(i + 1, j - (i + 1));

                if (symbolMap.TryGetValue(token, out string? val))
                {
                    sb.Append(val);
                    i = j - 1;
                    continue;
                }
            }

            // Detect \title{...}
            if (input[i] == '\\' && input.Substring(i).StartsWith("\\title"))
            {
                int braceStart = i + 6; // after \title
                if (TryReadBraced(input, braceStart, out string content, out int endBrace))
                {
                    sb.Append("## " + ToBold(content.ToUpper()));
                    i = endBrace;
                    continue;
                }
            }

            // Detect \section{...}
            if (input[i] == '\\' && input.Substring(i).StartsWith("\\section"))
            {
                int braceStart = i + 8; // after \section
                if (TryReadBraced(input, braceStart, out string content, out int endBrace))
                {
                    sb.Append("### " + ToBold(content.ToUpper()));
                    i = endBrace;
                    continue;
                }
            }
            // Detect \quote{...}
            if (input[i] == '\\' && input.Substring(i).StartsWith("\\quote"))
            {
                int braceStart = i + 6; // after \quote
                if (TryReadBraced(input, braceStart, out string content, out int endBrace))
                {
                    string inner = Convert(content, false);
                    sb.Append("“");
                    sb.Append(ToItalic(inner));
                    sb.Append("”");
                    i = endBrace;
                    continue;
                }
            }

            // Detect \mi{...}  (math italic)
            if (input[i] == '\\' && input.Substring(i).StartsWith("\\mi"))
            {
                int braceStart = i + 3; // after \mi
                if (TryReadBraced(input, braceStart, out string content, out int endBrace))
                {
                    string inner = Convert(content, false);
                    sb.Append(ToItalic(inner));
                    i = endBrace;
                    continue;
                }
            }

            // Detect \mono{...}
            if (input[i] == '\\' && input.Substring(i).StartsWith("\\mono"))
            {
                int braceStart = i + 5; // after \mono
                if (TryReadBraced(input, braceStart, out string content, out int endBrace))
                {
                    string inner = Convert(content, false);
                    sb.Append(ToMono(inner));
                    i = endBrace;
                    continue;
                }
            }

            // Dash replacements
            if (input[i] == '\\')
            {
                // em dash first (---)
                if (i + 3 < input.Length && input.Substring(i, 4) == "\\---")
                {
                    sb.Append("—"); // em dash
                    i += 3;
                    continue;
                }

                // en dash second (--)
                if (i + 2 < input.Length && input.Substring(i, 3) == "\\--")
                {
                    sb.Append("–"); // en dash
                    i += 2;
                    continue;
                }
            }


            // Horizontal separator: --- at start of line
            if (startOfLine && i + 2 < input.Length && input.Substring(i, 3) == "---")
            {
                sb.Append("~~**                                                            **~~");
                i += 2;
                continue;
            }

            // Handle subscript / superscript            
            if (i + 1 < input.Length && (input[i + 1] == '_' || input[i + 1] == '^'))
            {
                sb.Append(input[i]);                
                string lastToken = PopLastToken(sb);                
                string normalized = NormalizeToken(lastToken);
                
                sb.Append(ToItalic(normalized));

                // Handle sub/super
                int j = i + 1;
                while (j < input.Length)
                {
                    if (input[j] == '_')
                    {
                        j++;
                        while (j < input.Length && SubMap.ContainsKey(input[j]))
                        {
                            sb.Append(ToMathScript(input[j], false));
                            j++;
                        }
                    }
                    else if (input[j] == '^')
                    {
                        j++;
                        while (j < input.Length && SuperMap.ContainsKey(input[j]))
                        {
                            sb.Append(ToMathScript(input[j], true));
                            j++;
                        }
                    }
                    else break;
                }

                i = j - 1;
                continue;
            }

            if (UseBold)
            {
                // Normal text to bold
                sb.Append(ToBold(input[i].ToString()));
            }
            else
            {
                // Do nothing
                sb.Append(input[i].ToString());
            }
        }

        return sb.ToString();
    }
}