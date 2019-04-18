ConsoleApp11
====

## Overview

Bit Tetris http://nabetani.sakura.ne.jp/hena/ord2/

## 問題

ブロックが落ちたあとのテトリスフィールドから、横一列揃っている列を削除する。

フィールドの幅は可変。高さは8。

入力は「 ff-2f-23-f3-77-7f-3b 」のような形式。ハイフン区切りで二桁ずつの16進数となっている。 
LSB(つまり、2進数の1の位)が下、MSB(つまり、2進数の大きな桁)が上のブロックを意味する。 
したがって、この入力は下図のようなフィールドを意味する。

<table class='tet'>
      <tr>
        <td class='block'>■</td>
        <td class='space'>&nbsp;</td>
        <td class='space'>&nbsp;</td>
        <td class='block'>■</td>
        <td class='space'>&nbsp;</td>
        <td class='space'>&nbsp;</td>
        <td class='space'>&nbsp;</td>
      </tr>
      <tr>
        <td class='block'>■</td>
        <td class='space'>&nbsp;</td>
        <td class='space'>&nbsp;</td>
        <td class='block'>■</td>
        <td class='block'>■</td>
        <td class='block'>■</td>
        <td class='space'>&nbsp;</td>
      </tr>
      <tr>
        <td class='block'>■</td>
        <td class='block'>■</td>
        <td class='block'>■</td>
        <td class='block'>■</td>
        <td class='block'>■</td>
        <td class='block'>■</td>
        <td class='block'>■</td>
      </tr>
      <tr>
        <td class='block'>■</td>
        <td class='space'>&nbsp;</td>
        <td class='space'>&nbsp;</td>
        <td class='block'>■</td>
        <td class='block'>■</td>
        <td class='block'>■</td>
        <td class='block'>■</td>
      </tr>
      <tr>
        <td class='block'>■</td>
        <td class='block'>■</td>
        <td class='space'>&nbsp;</td>
        <td class='space'>&nbsp;</td>
        <td class='space'>&nbsp;</td>
        <td class='block'>■</td>
        <td class='block'>■</td>
      </tr>
      <tr>
        <td class='block'>■</td>
        <td class='block'>■</td>
        <td class='space'>&nbsp;</td>
        <td class='space'>&nbsp;</td>
        <td class='block'>■</td>
        <td class='block'>■</td>
        <td class='space'>&nbsp;</td>
      </tr>
      <tr>
        <td class='block'>■</td>
        <td class='block'>■</td>
        <td class='block'>■</td>
        <td class='block'>■</td>
        <td class='block'>■</td>
        <td class='block'>■</td>
        <td class='block'>■</td>
      </tr>
      <tr>
        <td class='block'>■</td>
        <td class='block'>■</td>
        <td class='block'>■</td>
        <td class='block'>■</td>
        <td class='block'>■</td>
        <td class='block'>■</td>
        <td class='block'>■</td>
      </tr>
      <tr>
        <td class='value'>
          <code>ff</code>
        </td>
        <td class='value'>
          <code>2f</code>
        </td>
        <td class='value'>
          <code>23</code>
        </td>
        <td class='value'>
          <code>f3</code>
        </td>
        <td class='value'>
          <code>77</code>
        </td>
        <td class='value'>
          <code>7f</code>
        </td>
        <td class='value'>
          <code>3b</code>
        </td>
      </tr>
    </table>

見ての通り、下から数えて 1段目、2段目、6段目 が1列揃っているので、これを消す。 消した結果は下図のようになる：

<table class='tet'>
      <tr>
        <td class='space'>&nbsp;</td>
        <td class='space'>&nbsp;</td>
        <td class='space'>&nbsp;</td>
        <td class='space'>&nbsp;</td>
        <td class='space'>&nbsp;</td>
        <td class='space'>&nbsp;</td>
        <td class='space'>&nbsp;</td>
      </tr>
      <tr>
        <td class='space'>&nbsp;</td>
        <td class='space'>&nbsp;</td>
        <td class='space'>&nbsp;</td>
        <td class='space'>&nbsp;</td>
        <td class='space'>&nbsp;</td>
        <td class='space'>&nbsp;</td>
        <td class='space'>&nbsp;</td>
      </tr>
      <tr>
        <td class='space'>&nbsp;</td>
        <td class='space'>&nbsp;</td>
        <td class='space'>&nbsp;</td>
        <td class='space'>&nbsp;</td>
        <td class='space'>&nbsp;</td>
        <td class='space'>&nbsp;</td>
        <td class='space'>&nbsp;</td>
      </tr>
      <tr>
        <td class='block'>■</td>
        <td class='space'>&nbsp;</td>
        <td class='space'>&nbsp;</td>
        <td class='block'>■</td>
        <td class='space'>&nbsp;</td>
        <td class='space'>&nbsp;</td>
        <td class='space'>&nbsp;</td>
      </tr>
      <tr>
        <td class='block'>■</td>
        <td class='space'>&nbsp;</td>
        <td class='space'>&nbsp;</td>
        <td class='block'>■</td>
        <td class='block'>■</td>
        <td class='block'>■</td>
        <td class='space'>&nbsp;</td>
      </tr>
      <tr>
        <td class='block'>■</td>
        <td class='space'>&nbsp;</td>
        <td class='space'>&nbsp;</td>
        <td class='block'>■</td>
        <td class='block'>■</td>
        <td class='block'>■</td>
        <td class='block'>■</td>
      </tr>
      <tr>
        <td class='block'>■</td>
        <td class='block'>■</td>
        <td class='space'>&nbsp;</td>
        <td class='space'>&nbsp;</td>
        <td class='space'>&nbsp;</td>
        <td class='block'>■</td>
        <td class='block'>■</td>
      </tr>
      <tr>
        <td class='block'>■</td>
        <td class='block'>■</td>
        <td class='space'>&nbsp;</td>
        <td class='space'>&nbsp;</td>
        <td class='block'>■</td>
        <td class='block'>■</td>
        <td class='space'>&nbsp;</td>
      </tr>
      <tr>
        <td class='value'>
          <code>1f</code>
        </td>
        <td class='value'>
          <code>03</code>
        </td>
        <td class='value'>
          <code>00</code>
        </td>
        <td class='value'>
          <code>1c</code>
        </td>
        <td class='value'>
          <code>0d</code>
        </td>
        <td class='value'>
          <code>0f</code>
        </td>
        <td class='value'>
          <code>06</code>
        </td>
      </tr>
    </table>

というわけで、出力すべきは 1f-03-00-1c-0d-0f-06 という文字列となる。

## Requirement

.NET Framework 4.5.2

## Licence

[MIT](https://github.com/twinbird827/ConsoleApp11/blob/master/LICENSE)

## Author

[twinbird827](https://github.com/twinbird827)