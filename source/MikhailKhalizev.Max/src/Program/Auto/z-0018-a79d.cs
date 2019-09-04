using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x18_a79d-a06f2759")]
        public void Method_0018_a79d()
        {
            ii(0x18_a79d, 3);  cmp(ah, 0xc);                           /* cmp ah, 0xc */
            ii(0x18_a7a0, 2);  if(jbe_func(0x18_a7de, 0x3c)) return;   /* jbe 0xa7de */
            ii(0x18_a7a2, 3);  cmp(ah, 0x59);                          /* cmp ah, 0x59 */
            ii(0x18_a7a5, 2);  if(jz_func(0x18_a7de, 0x37)) return;    /* jz 0xa7de */
            ii(0x18_a7a7, 3);  cmp(ah, -1 /* 0xff */);                 /* cmp ah, 0xff */
            ii(0x18_a7aa, 2);  if(jz_func(0x18_a7de, 0x32)) return;    /* jz 0xa7de */
            ii(0x18_a7ac, 6);  cmp(memb[es, 0x1182], 0);               /* cmp byte [es:0x1182], 0x0 */
            ii(0x18_a7b2, 2);  if(jnz_func(0x18_a7de, 0x2a)) return;   /* jnz 0xa7de */
            ii(0x18_a7b4, 2);  mov(di, cx);                            /* mov di, cx */
            ii(0x18_a7b6, 4);  add(di, 0x180);                         /* add di, 0x180 */
            ii(0x18_a7ba, 2);  xor(cx, cx);                            /* xor cx, cx */
            ii(0x18_a7bc, 2);  if(jmp_func(0x18_a7de, 0x20)) return;   /* jmp 0xa7de */
        }
    }
}
