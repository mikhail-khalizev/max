using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x18_e160-359081be")]
        public void Method_0018_e160()
        {
            ii(0x18_e160, 3); call(0x18_e070, -0xf3);                   /* call 0xe070 */
            ii(0x18_e163, 2); if(jb_func(0x18_e14d, -0x18)) return;     /* jb 0xe14d */
            ii(0x18_e165, 2); if(jcxz_func(0x18_e14d, -0x1a)) return;   /* jcxz 0xe14d */
            ii(0x18_e167, 4); cmp(bx, 0x80);                            /* cmp bx, 0x80 */
            ii(0x18_e16b, 2); if(jb_func(0x18_e14d, -0x20)) return;     /* jb 0xe14d */
            ii(0x18_e16d, 2); xor(ax, ax);                              /* xor ax, ax */
            ii(0x18_e16f, 3); mov(memb[ds, bx + 5], al);                /* mov [bx+0x5], al */
            ii(0x18_e172, 2); push(0x50);                               /* push 0x50 */
            ii(0x18_e174, 1); pop(ds);                                  /* pop ds */
            ii(0x18_e175, 3); shr(bx, 3);                               /* shr bx, 0x3 */
            ii(0x18_e178, 2); mov(memb[ds, bx], al);                    /* mov [bx], al */
            ii(0x18_e17a, 4); mov(cx, memw_a32[ss, ebp]);               /* mov cx, [ebp] */
            ii(0x18_e17e, 3); shr(cx, 3);                               /* shr cx, 0x3 */
            ii(0x18_e181, 2); xor(cx, bx);                              /* xor cx, bx */
            ii(0x18_e183, 4); if(jnz(0x18_e18b, 4)) goto l_0x18_e18b;   /* jnz 0xe18b */
            ii(0x18_e187, 4); mov(memw_a32[ss, ebp], cx);               /* mov [ebp], cx */
        l_0x18_e18b:
            ii(0x18_e18b, 4); mov(cx, memw_a32[ss, ebp + 2]);           /* mov cx, [ebp+0x2] */
            ii(0x18_e18f, 3); shr(cx, 3);                               /* shr cx, 0x3 */
            ii(0x18_e192, 2); xor(cx, bx);                              /* xor cx, bx */
            ii(0x18_e194, 4); if(jnz(0x18_e19c, 4)) goto l_0x18_e19c;   /* jnz 0xe19c */
            ii(0x18_e198, 4); mov(memw_a32[ss, ebp + 2], cx);           /* mov [ebp+0x2], cx */
        l_0x18_e19c:
            ii(0x18_e19c, 2); mov(cx, fs);                              /* mov cx, fs */
            ii(0x18_e19e, 3); shr(cx, 3);                               /* shr cx, 0x3 */
            ii(0x18_e1a1, 2); xor(cx, bx);                              /* xor cx, bx */
            ii(0x18_e1a3, 4); if(jnz(0x18_e1a9, 2)) goto l_0x18_e1a9;   /* jnz 0xe1a9 */
            ii(0x18_e1a7, 2); mov(fs, cx);                              /* mov fs, cx */
        l_0x18_e1a9:
            ii(0x18_e1a9, 2); mov(cx, gs);                              /* mov cx, gs */
            ii(0x18_e1ab, 3); shr(cx, 3);                               /* shr cx, 0x3 */
            ii(0x18_e1ae, 2); xor(cx, bx);                              /* xor cx, bx */
            ii(0x18_e1b0, 4); if(jnz(0x18_e1b6, 2)) goto l_0x18_e1b6;   /* jnz 0xe1b6 */
            ii(0x18_e1b4, 2); mov(gs, cx);                              /* mov gs, cx */
        l_0x18_e1b6:
            ii(0x18_e1b6, 3); if(jmp_func(0x18_e067, -0x152)) return;   /* jmp 0xe067 */
        }
    }
}
