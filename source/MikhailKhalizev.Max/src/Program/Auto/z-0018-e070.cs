using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x18_e070-223a15c2")]
        public void Method_0018_e070()
        {
            ii(0x18_e070, 6); movzx(ebx, memw_a32[ss, ebp + 0x14]);     /* movzx ebx, word [ebp+0x14] */
            ii(0x18_e076, 3); mov(ax, 0x8);                             /* mov ax, 0x8 */
            ii(0x18_e079, 2); mov(ds, ax);                              /* mov ds, ax */
            ii(0x18_e07b, 4); cmp(bx, memw_a16[ds, 0x8]);               /* cmp bx, [0x8] */
            ii(0x18_e07f, 2); if(jaew_func(0x18_e062, -0x1f)) return;   /* jae 0xe062 */
            ii(0x18_e081, 3); and(bx, -0x8 /* 0xf8 */);                 /* and bx, 0xfff8 */
            ii(0x18_e084, 2); if(jzw_func(0x18_e062, -0x24)) return;    /* jz 0xe062 */
            ii(0x18_e086, 2); xor(cx, cx);                              /* xor cx, cx */
            ii(0x18_e088, 3); mov(cl, memb_a16[ds, bx + 0x5]);          /* mov cl, [bx+0x5] */
            ii(0x18_e08b, 3); test(cl, 0x80);                           /* test cl, 0x80 */
            ii(0x18_e08e, 2); if(jzw(0x18_e0a5, 0x15)) goto l_0x18_e0a5; /* jz 0xe0a5 */
            ii(0x18_e090, 1); pushw(es);                                /* push es */
            ii(0x18_e091, 2); pushw(0x50);                              /* push 0x50 */
            ii(0x18_e093, 1); popw(es);                                 /* pop es */
            ii(0x18_e094, 1); pushw(si);                                /* push si */
            ii(0x18_e095, 2); mov(si, bx);                              /* mov si, bx */
            ii(0x18_e097, 3); shr(si, 0x3);                             /* shr si, 0x3 */
            ii(0x18_e09a, 3); mov(al, memb_a16[es, si]);                /* mov al, [es:si] */
            ii(0x18_e09d, 1); popw(si);                                 /* pop si */
            ii(0x18_e09e, 1); popw(es);                                 /* pop es */
            ii(0x18_e09f, 2); and(al, 0xf0);                            /* and al, 0xf0 */
            ii(0x18_e0a1, 2); cmp(al, -0x10 /* 0xf0 */);                /* cmp al, 0xf0 */
            ii(0x18_e0a3, 2); if(jzw(0x18_e0a7, 0x2)) goto l_0x18_e0a7; /* jz 0xe0a7 */
        l_0x18_e0a5:
            ii(0x18_e0a5, 1); clc();                                    /* clc */
            ii(0x18_e0a6, 1); retw(); return;                           /* ret */
        l_0x18_e0a7:
            ii(0x18_e0a7, 1); stc();                                    /* stc */
            ii(0x18_e0a8, 1); retw(); return;                           /* ret */
        }
    }
}
