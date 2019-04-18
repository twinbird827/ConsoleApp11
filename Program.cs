using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    class Program
    {
        static void Main(string[] args)
        {
            Test("ff-2f-23-f3-77-7f-3b");
            Test("01");
            Test("00");
            Test("7a-4e");
            Test("56-b6");
            Test("12-12-12");
            Test("de-ff-7b");
            Test("95-be-d0");
            Test("7c-b0-bb");
            Test("7a-b6-31-6a");
            Test("32-0e-23-82");
            Test("ff-7f-bf-df-ef");
            Test("75-df-dc-6e-42");
            Test("62-51-ef-c7-f8");
            Test("0c-47-8e-dd-5d-17");
            Test("aa-58-5b-6d-9f-1f");
            Test("ff-55-d5-75-5d-57");
            Test("fe-fd-fb-f7-ef-df-bf");
            Test("fd-fb-f7-ef-df-bf-7f");
            Test("d9-15-b5-d7-1b-9f-de");
            Test("38-15-fd-50-10-96-ba");
            Test("fe-fd-fb-f7-ef-df-bf-7f");

            Console.ReadLine();
        }

        static void Test(string target)
        {
            Console.WriteLine($"{target.PadRight(25)}:{Proc(target)}");
        }

        // ﾒｲﾝ処理
        static string Proc(string target)
        {
            // '-' 区切りの配列にして各文字を2進数にする
            var src = target
                .Split('-')
                .Select(s => Hex2Bin(s))
                .ToArray();
            // 変換後
            var dst = src
                .Select(s => s.Where((c, i) => !src.All(tmp => tmp[i] == '1'))) // 全配列のindex値が'1'ではないﾃﾞｰﾀのみにする
                .Select(s => string.Join("", s))                                // 文字列に戻す
                .Select(s => s.PadLeft(8, '0'))                                 // 左ｾﾞﾛ埋め
                .Select(s => Bin2Hex(s));                                       // 16進数に戻す
            // '-' で配列を結合して返却
            return string.Join("-", dst);
        }

        // 16進数→2進数変換
        static string Hex2Bin(string target)
        {
            var tmp = target
                .Select(c => Convert.ToInt16(c.ToString(), 16)) // 16進→数値変換
                .Select(i => Convert.ToString(i, 2))            // 数値→2進変換
                .Select(s => s.PadLeft(4, '0'));                // 4文字になるよう'0'で文字埋め
            return string.Join("", tmp);
        }

        // 2進数→16進数変換
        static string Bin2Hex(string target)
        {
            var tmp = Enumerable.Range(0, target.Length / 4)
                .Select(i => target.Substring(i * 4, 4))    // 4文字区切りに分ける
                .Select(s => Convert.ToInt32(s, 2))         // 2進数→数値変換
                .Select(i => Convert.ToString(i, 16));      // 数値→16進数変換
            return string.Join("", tmp);
        }

    }
}
