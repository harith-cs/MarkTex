# MarkTex
MarkTex is a lightweight text-processing engine that transforms LaTeX-like markup into rich Unicode mathematical and technical notation. Unlike full LaTeX, it focuses on a **fast, efficient writing experience** for plain-text environments using a semantic subset of LaTeX.

---

## Project Structure

```

MarkTex/                  <- GitHub repository root
└── MarkTexApp/           <- Main application folder
├── App.xaml          <- Application-wide settings
├── MainWindow.xaml   <- Main user interface
├── MarkTexRenderer.cs <- Engine for rendering and processing text/symbols
├── MarkTexApp.csproj <- Visual Studio project file
└── Properties/       <- Project resources and settings
.gitignore                 <- Files/folders ignored by Git
README.md                  <- This file

```

---

## Features

- Render LaTeX-like text into **Unicode mathematical notation**
- Fast, lightweight engine suitable for **plain-text environments**
- Modular architecture with `MarkTexRenderer.cs` for integration
- Built using **C# WPF** for optional GUI support

---

## Getting Started

1. **Clone the repository:**
```bash
git clone https://github.com/harith-cs/MarkTex.git
````

2. **Open the project in Visual Studio**

   * Open `MarkTexApp/MarkTexApp.csproj`.

3. **Build and run the application**

   * Press `F5` or click "Start Debugging".

4. **Use the engine programmatically**

   * Import `MarkTexRenderer.cs` into your own C# project.
   * Call its rendering functions to convert LaTeX-like markup into Unicode text.

---

## Notes

* The main application and source code are inside the `MarkTexApp` folder.
* Temporary files and build outputs are ignored via `.gitignore`.
* Compatible with **Windows 10/11** with .NET Framework installed.

---

## MarkTex Syntax and Features

MarkTex provides a LaTeX-inspired syntax to format text into Unicode symbols, mathematical notation, and styled text. Below is a detailed explanation of its supported syntax and features.


### 1. **Text Styles**

| Command           | Description                                  | Example                       | Output                     |
|------------------|----------------------------------------------|-------------------------------|----------------------------|
| `\title{...}`     | Creates a bold, uppercase title              | `\title{MarkTex}`             | ## 𝐌𝐀𝐑𝐊𝐓𝐄𝐗               |
| `\section{...}`   | Creates a bold, uppercase section header    | `\section{Usage}`             | ### 𝐔𝐒𝐀𝐆𝐄                  |
| `\quote{...}`     | Wraps text in quotation marks and italic    | `\quote{Hello}`               | “𝐻𝑒𝑙𝑙𝑜”                  |
| `\mi{...}`        | Renders text in mathematical italic         | `\mi{x+y}`                    | 𝑥+𝑦             |
| `\mono{...}`      | Renders text in monospaced Unicode font     | `\mono{Code}`                 | 𝙲𝚘𝚍𝚎                     |
| `Bold` (UseBold)  | Converts regular text to bold Unicode(if UseBold is False then regular text wont changed)        | `Hello` with `UseBold=true` | 𝐇𝐞𝐥𝐥𝐨                     |

### 2. **Superscripts and Subscripts**

- **Superscript:** Use `^` after a character or token  
  `x^2` → x²

* **Subscript:** Use `_` after a character or token
  `H_2O` → H₂O

* Can combine:

  `x_1^2` → x₁²

### 3. Supported Symbols Reference

MarkTex supports a wide range of LaTeX-like symbol commands. All symbols are written using a backslash `\` followed by the command name (e.g. `\alpha`, `\sum`).

This section lists **all currently supported symbols**, grouped by category.

### Greek Letters (Lowercase)

| Command | Output | Command | Output |
|--------|--------|--------|--------|
| `\alpha` | α | `\nu` | ν |
| `\beta` | β | `\xi` | ξ |
| `\gamma` | γ | `\omicron` | ο |
| `\delta` | δ | `\pi` | π |
| `\epsilon` | ε | `\rho` | ρ |
| `\zeta` | ζ | `\sigma` | σ |
| `\eta` | η | `\tau` | τ |
| `\theta` | θ | `\upsilon` | υ |
| `\iota` | ι | `\phi` | φ |
| `\kappa` | κ | `\chi` | χ |
| `\lambda` | λ | `\psi` | ψ |
| `\mu` | μ | `\omega` | ω |


### Greek Letters (Uppercase)
| Command | Output | Command | Output |
|--------|--------|--------|--------|
| `\Alpha` | Α | `\Lambda` | Λ |
| `\Beta` | Β | `\Pi` | Π |
| `\Gamma` | Γ | `\Sigma` | Σ |
| `\Delta` | Δ | `\Phi` | Φ |
| `\Theta` | Θ | `\Omega` | Ω |

### Mathematical Operators
| Command | Output | Command | Output |
|--------|--------|--------|--------|
| `\sum` | ∑ | `\pm` | ± |
| `\prod` | ∏ | `\mp` | ∓ |
| `\int` | ∫ | `\equiv` | ≡ |
| `\oint` | ∮ | `\propto` | ∝ |
| `\sqrt` | √ | `\times` | × |
| `\infty` | ∞ | `\div` | ÷ |
| `\approx` | ≈ | `\cdot` | ⋅ |
| `\neq` | ≠ | `\partial` | ∂ |
| `\le` | ≤ | `\nabla` | ∇ |
| `\ge` | ≥ | `\aleph` | ℵ |

### Set Theory Symbols
| Command | Output | Command | Output |
|--------|--------|--------|--------|
| `\in` | ∈ | `\subseteq` | ⊆ |
| `\notin` | ∉ | `\supset` | ⊃ |
| `\forall` | ∀ | `\supseteq` | ⊇ |
| `\exists` | ∃ | `\cup` | ∪ |
| `\neg` | ¬ | `\cap` | ∩ |
| `\emptyset` | ∅ | `\setminus` | ∖ |
| `\subset` | ⊂ | `\bigcup` | ⋃ |
|  |  | `\bigcap` | ⋂ |

### Arrow Symbols
| Command | Output | Command | Output |
|--------|--------|--------|--------|
| `\to` | → | `\Rightarrow` | ⇒ |
| `\left` | ← | `\Leftarrow` | ⇐ |
| `\up` | ↑ | `\Uparrow` | ⇑ |
| `\down` | ↓ | `\Downarrow` | ⇓ |
| `\leftright` | ↔ | `\Leftrightarrow` | ⇔ |
| `\mapsto` | ↦ |  |  |

### Logical & Miscellaneous Symbols
| Command | Output | Command | Output |
|--------|--------|--------|--------|
| `\wedge` | ∧ | `\degree` | ° |
| `\vee` | ∨ | `\prime` | ′ |
| `\oplus` | ⊕ | `\doubleprime` | ″ |
| `\otimes` | ⊗ | `\angle` | ∠ |
| `\perp` | ⊥ | `\therefore` | ∴ |
| `\dots` | … | `\because` | ∵ |
| `\cdots` | ⋯ | `\vdots` | ⋮ |
| `\ddots` | ⋱ |  |  |

### Mathematical Double-Struck Sets
| Command | Output |
|--------|--------|
| `\R` | ℝ |
| `\N` | ℕ |
| `\Z` | ℤ |
| `\Q` | ℚ |
| `\C` | ℂ |

---

### Notes

- Symbol commands are **case-sensitive**.
- All symbols are rendered as **Unicode**, not graphical LaTeX.
- Symbols can be combined with subscripts, superscripts, italics, and bold formatting.

### 4. **Unicode Fonts**
MarkTex supports multiple Unicode styles for text and numbers:

* **Bold:** 𝐀, 𝐁, 𝐂…
* **Italic:** 𝑎, 𝑏, 𝑐…
* **Monospace:** 𝚊, 𝚋, 𝚌…
* **Subscript:** a₁, b₂…
* **Superscript:** a¹, b²…


### 5. **Code Handling**

* Inline code: Use `` `code` `` → monospaced rendering
* Code blocks: Use triple backticks ` ```code``` ` → monospaced block rendering


### 6. **Special Line Formatting**

* Horizontal separator: `---` at the start of a line → a visual separator in plain text.
* Dash replacements:

  * `\---` → em dash (—)
  * `\--`  → en dash (–)


### **Example**
Raw input:
```
Let \mi{X} = {x_1, x_2, ..., x_n} be the input vector, where \mi{X} \in \R ⁿ.

For \mi{a} single neuron \mi{j} in a layer, the pre-activation value is defined as:  
z_j = \sum(w_ij \cdot x_i ) + b_j

The activation of neuron \mi{j} is: 
a_j = \sigma(z_j)

Where:
w_ij \in \R is the weight connecting input \mi{i} to neuron \mi{j}
b_j \in \R is the bias term
\sigma(x) = 1/ (1 + e^-x )

For a full layer \mi{l}:
z^(l) = W^(l) a^(l-1) + b^(l)
a^(l) = \sigma(z^(l) )

The network output is:
ŷ = a^(L)

Training objective:
\forall (x, y) \in D, minimize:
\mi{L} = \sum (y - ŷ)^2

Weight update rule:\mi{
W^(l) \left W^(l) - \eta \partial \mi{L}/\partial W^(l)
}

Implementation sketch:
`z = W @ a + b`
```
Output:

𝐋𝐞𝐭 𝑋 = {𝑥₁, 𝑥₂, ..., 𝑥ₙ} 𝐛𝐞 𝐭𝐡𝐞 𝐢𝐧𝐩𝐮𝐭 𝐯𝐞𝐜𝐭𝐨𝐫, 𝐰𝐡𝐞𝐫𝐞 𝑋 ∈ ℝ ⁿ.

𝐅𝐨𝐫 𝑎 𝐬𝐢𝐧𝐠𝐥𝐞 𝐧𝐞𝐮𝐫𝐨𝐧 𝑗 𝐢𝐧 𝐚 𝐥𝐚𝐲𝐞𝐫, 𝐭𝐡𝐞 𝐩𝐫𝐞-𝐚𝐜𝐭𝐢𝐯𝐚𝐭𝐢𝐨𝐧 𝐯𝐚𝐥𝐮𝐞 𝐢𝐬 𝐝𝐞𝐟𝐢𝐧𝐞𝐝 𝐚𝐬:  
𝑧ⱼ = ∑(𝑤ᵢⱼ ⋅ 𝑥ᵢ ) + 𝑏ⱼ

𝐓𝐡𝐞 𝐚𝐜𝐭𝐢𝐯𝐚𝐭𝐢𝐨𝐧 𝐨𝐟 𝐧𝐞𝐮𝐫𝐨𝐧 𝑗 𝐢𝐬: 
𝑎ⱼ = σ(𝑧ⱼ₎

𝑊ℎ𝑒𝑟𝑒:
𝑤ᵢⱼ ∈ ℝ 𝐢𝐬 𝐭𝐡𝐞 𝐰𝐞𝐢𝐠𝐡𝐭 𝐜𝐨𝐧𝐧𝐞𝐜𝐭𝐢𝐧𝐠 𝐢𝐧𝐩𝐮𝐭 𝑖 𝐭𝐨 𝐧𝐞𝐮𝐫𝐨𝐧 𝑗
𝑏ⱼ ∈ ℝ 𝐢𝐬 𝐭𝐡𝐞 𝐛𝐢𝐚𝐬 𝐭𝐞𝐫𝐦
σ(𝐱) = 1/ (1 + 𝑒⁻ˣ )

𝐅𝐨𝐫 𝐚 𝐟𝐮𝐥𝐥 𝐥𝐚𝐲𝐞𝐫 𝑙:
𝑧⁽ˡ⁾ = 𝑊⁽ˡ⁾ 𝑎⁽ˡ⁻¹⁾ + 𝑏⁽ˡ⁾
𝑎⁽ˡ⁾ = σ(𝑧⁽ˡ⁾ )

𝐓𝐡𝐞 𝐧𝐞𝐭𝐰𝐨𝐫𝐤 𝐨𝐮𝐭𝐩𝐮𝐭 𝐢𝐬:
ŷ = 𝑎⁽ᴸ⁾

𝐓𝐫𝐚𝐢𝐧𝐢𝐧𝐠 𝐨𝐛𝐣𝐞𝐜𝐭𝐢𝐯𝐞:
∀ (𝐱, 𝐲) ∈ 𝐃, 𝐦𝐢𝐧𝐢𝐦𝐢𝐳𝐞:
𝐿 = ∑ (𝐲 - ŷ)²

𝐖𝐞𝐢𝐠𝐡𝐭 𝐮𝐩𝐝𝐚𝐭𝐞 𝐫𝐮𝐥𝐞:
𝑊⁽ˡ⁾ ← 𝑊⁽ˡ⁾ - η ∂ 𝐿/∂ 𝑊⁽ˡ⁾


𝐈𝐦𝐩𝐥𝐞𝐦𝐞𝐧𝐭𝐚𝐭𝐢𝐨𝐧 𝐬𝐤𝐞𝐭𝐜𝐡:
`𝚣 = 𝚆 @ 𝚊 + 𝚋`

---

## Known Issues / Limitations
While MarkTex provides fast and lightweight LaTeX-like rendering, there are some **current limitations** that users should be aware of:

### 1. Subscript/Superscript After Commands

* **Issue:** Subscripts `_` and superscripts `^` **cannot be applied immediately after a command** (e.g., `\alpha_1` may not render correctly if the parser misinterprets boundaries).
* **Example:**

  ```text
  z_j = \sum(w_ij \cdot x_j) + b_j
  ```

  **Incorrect Output:**
  ∑(𝑤ᵢⱼ ⋅ 𝑥ᵢ₎ + 𝑏ⱼ
  *(The `j)` gets merged with the subscript, causing rendering errors)*

### 2. Sub/Superscript Boundary Detection

* **Issue:** The engine sometimes **fails to accurately determine the start and end of sub/superscripts**, especially around parentheses or symbols.
* **Effect:** Adjacent symbols or characters may be **incorrectly merged** into the sub/superscript.

### 3. Nested Commands

* **Issue:** Using nested commands within sub/superscripts may not always render as expected.
* **Example:**

  ```text
  x^{\alpha+\beta}
  ```

  *May not fully render the sum inside the superscript correctly in all cases.*

### 4. Limited Parsing Context

* **Note:** MarkTex is designed for **fast plain-text rendering**, not for full LaTeX-level parsing. Complex expressions may need **manual adjustments** or simpler formatting to ensure correct output.

---

## Contributing

* Fork the project and submit pull requests to improve the engine.
* Issues and suggestions are welcome.

---

## License

This project is open-source and available under the MIT License.
