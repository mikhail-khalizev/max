using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1_2040-223a15c2")]
        public void Method_0001_2040()
        {
            ii(0x1_2040, 6);  movzx(ebx, memw_a32[ss, ebp + 0x14]);     /* movzx ebx, word [ebp+0x14] */
            ii(0x1_2046, 3);  mov(ax, 0x8);                             /* mov ax, 0x8 */
            ii(0x1_2049, 2);  mov(ds, ax);                              /* mov ds, ax */
            ii(0x1_204b, 4);  cmp(bx, memw[ds, 0x8]);                   /* cmp bx, [0x8] */
            ii(0x1_204f, 2);  if(jae_func(0x1_2032, -0x1f)) return;     /* jae 0x2032 */
            ii(0x1_2051, 3);  and(bx, -0x8 /* 0xf8 */);                 /* and bx, 0xfff8 */
            ii(0x1_2054, 2);  if(jz_func(0x1_2032, -0x24)) return;      /* jz 0x2032 */
            ii(0x1_2056, 2);  xor(cx, cx);                              /* xor cx, cx */
            ii(0x1_2058, 3);  mov(cl, memb[ds, bx + 0x5]);              /* mov cl, [bx+0x5] */
            ii(0x1_205b, 3);  test(cl, 0x80);                           /* test cl, 0x80 */
            ii(0x1_205e, 2);  if(jz(0x1_2075, 0x15)) goto l_0x1_2075;   /* jz 0x2075 */
            ii(0x1_2060, 1);  push(es);                                 /* push es */
            ii(0x1_2061, 2);  push(0x50);                               /* push 0x50 */
            ii(0x1_2063, 1);  pop(es);                                  /* pop es */
            ii(0x1_2064, 1);  push(si);                                 /* push si */
            ii(0x1_2065, 2);  mov(si, bx);                              /* mov si, bx */
            ii(0x1_2067, 3);  shr(si, 0x3);                             /* shr si, 0x3 */
            ii(0x1_206a, 3);  mov(al, memb[es, si]);                    /* mov al, [es:si] */
            ii(0x1_206d, 1);  pop(si);                                  /* pop si */
            ii(0x1_206e, 1);  pop(es);                                  /* pop es */
            ii(0x1_206f, 2);  and(al, 0xf0);                            /* and al, 0xf0 */
            ii(0x1_2071, 2);  cmp(al, -0x10 /* 0xf0 */);                /* cmp al, 0xf0 */
            ii(0x1_2073, 2);  if(jz(0x1_2077, 0x2)) goto l_0x1_2077;    /* jz 0x2077 */
        l_0x1_2075:
            ii(0x1_2075, 1);  clc();                                    /* clc */
            ii(0x1_2076, 1);  ret(); return;                            /* ret */
        l_0x1_2077:
            ii(0x1_2077, 1);  stc();                                    /* stc */
            ii(0x1_2078, 1);  ret();                                    /* ret */
        }
    }
}
