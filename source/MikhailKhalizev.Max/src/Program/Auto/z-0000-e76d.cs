using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0xe76d-a06f2759")]
        public void Method_0000_e76d()
        {
            ii(0xe76d, 3);    cmp(ah, 0xc);                             /* cmp ah, 0xc */
            ii(0xe770, 2);    if(jbew_func(0xe7ae, 0x3c)) return;       /* jbe 0xe7ae */
            ii(0xe772, 3);    cmp(ah, 0x59);                            /* cmp ah, 0x59 */
            ii(0xe775, 2);    if(jzw_func(0xe7ae, 0x37)) return;        /* jz 0xe7ae */
            ii(0xe777, 3);    cmp(ah, -0x1 /* 0xff */);                 /* cmp ah, 0xff */
            ii(0xe77a, 2);    if(jzw_func(0xe7ae, 0x32)) return;        /* jz 0xe7ae */
            ii(0xe77c, 6);    cmp(memb_a16[es, 0x1182], 0);             /* cmp byte [es:0x1182], 0x0 */
            ii(0xe782, 2);    if(jnzw_func(0xe7ae, 0x2a)) return;       /* jnz 0xe7ae */
            ii(0xe784, 2);    mov(di, cx);                              /* mov di, cx */
            ii(0xe786, 4);    add(di, 0x180);                           /* add di, 0x180 */
            ii(0xe78a, 2);    xor(cx, cx);                              /* xor cx, cx */
            ii(0xe78c, 2);    if(jmpw_func(0xe7ae, 0x20)) return;       /* jmp 0xe7ae */
        }
    }
}
