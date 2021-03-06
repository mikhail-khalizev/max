using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x17_c48e-183aea19")]
        public void Method_0017_c48e()
        {
            ii(0x17_c48e, 4);  enter(0xc, 0);                          /* enter 0xc, 0x0 */
            ii(0x17_c492, 1);  push(ds);                               /* push ds */
            ii(0x17_c493, 3);  mov(ax, 0x3e68);                        /* mov ax, 0x3e68 */
            ii(0x17_c496, 2);  mov(ds, ax);                            /* mov ds, ax */
            ii(0x17_c498, 3);  mov(ax, memw[ss, bp + 10]);             /* mov ax, [bp+0xa] */
            ii(0x17_c49b, 3);  mov(dx, memw[ss, bp + 12]);             /* mov dx, [bp+0xc] */
            ii(0x17_c49e, 2);  mov(al, ah);                            /* mov al, ah */
            ii(0x17_c4a0, 2);  mov(ah, dl);                            /* mov ah, dl */
            ii(0x17_c4a2, 2);  mov(dl, dh);                            /* mov dl, dh */
            ii(0x17_c4a4, 2);  sub(dh, dh);                            /* sub dh, dh */
            ii(0x17_c4a6, 2);  shr(dx, 1);                             /* shr dx, 1 */
            ii(0x17_c4a8, 2);  rcr(ax, 1);                             /* rcr ax, 1 */
            ii(0x17_c4aa, 2);  shr(dx, 1);                             /* shr dx, 1 */
            ii(0x17_c4ac, 2);  rcr(ax, 1);                             /* rcr ax, 1 */
            ii(0x17_c4ae, 2);  shr(dx, 1);                             /* shr dx, 1 */
            ii(0x17_c4b0, 2);  rcr(ax, 1);                             /* rcr ax, 1 */
            ii(0x17_c4b2, 2);  shr(dx, 1);                             /* shr dx, 1 */
            ii(0x17_c4b4, 2);  rcr(ax, 1);                             /* rcr ax, 1 */
            ii(0x17_c4b6, 3);  sub(ax, 0);                             /* sub ax, 0x0 */
            ii(0x17_c4b9, 3);  sbb(dx, 1);                             /* sbb dx, 0x1 */
            ii(0x17_c4bc, 3);  mov(memw[ss, bp - 4], ax);              /* mov [bp-0x4], ax */
            ii(0x17_c4bf, 3);  mov(memw[ss, bp - 2], dx);              /* mov [bp-0x2], dx */
            ii(0x17_c4c2, 2);  sub(ax, ax);                            /* sub ax, ax */
            ii(0x17_c4c4, 3);  mov(memw[ss, bp - 6], ax);              /* mov [bp-0x6], ax */
            ii(0x17_c4c7, 3);  mov(memw[ss, bp - 8], ax);              /* mov [bp-0x8], ax */
            ii(0x17_c4ca, 2);  jmp(0x17_c4dc, 0x10); goto l_0x17_c4dc; /* jmp 0xc4dc */
        l_0x17_c4cc:
            ii(0x17_c4cc, 4);  add(memw[ss, bp - 8], 1);               /* add word [bp-0x8], 0x1 */
            ii(0x17_c4d0, 4);  adc(memw[ss, bp - 6], 0);               /* adc word [bp-0x6], 0x0 */
            ii(0x17_c4d4, 4);  add(memw[ss, bp - 4], 1);               /* add word [bp-0x4], 0x1 */
            ii(0x17_c4d8, 4);  adc(memw[ss, bp - 2], 0);               /* adc word [bp-0x2], 0x0 */
        l_0x17_c4dc:
            ii(0x17_c4dc, 3);  mov(ax, memw[ss, bp + 14]);             /* mov ax, [bp+0xe] */
            ii(0x17_c4df, 3);  mov(dx, memw[ss, bp + 16]);             /* mov dx, [bp+0x10] */
            ii(0x17_c4e2, 3);  cmp(memw[ss, bp - 6], dx);              /* cmp [bp-0x6], dx */
            ii(0x17_c4e5, 2);  if(ja(0x17_c55c, 0x75)) goto l_0x17_c55c;/* ja 0xc55c */
            ii(0x17_c4e7, 2);  if(jb(0x17_c4ee, 5)) goto l_0x17_c4ee;  /* jb 0xc4ee */
            ii(0x17_c4e9, 3);  cmp(memw[ss, bp - 8], ax);              /* cmp [bp-0x8], ax */
            ii(0x17_c4ec, 2);  if(jae(0x17_c55c, 0x6e)) goto l_0x17_c55c;/* jae 0xc55c */
        l_0x17_c4ee:
            ii(0x17_c4ee, 3);  push(memw[ss, bp + 6]);                 /* push word [bp+0x6] */
            ii(0x17_c4f1, 3);  push(memw[ss, bp - 2]);                 /* push word [bp-0x2] */
            ii(0x17_c4f4, 3);  push(memw[ss, bp - 4]);                 /* push word [bp-0x4] */
            ii(0x17_c4f7, 4);  push(memw[ds, 0x4ff6]);                 /* push word [0x4ff6] */
            ii(0x17_c4fb, 4);  push(memw[ds, 0x4ff4]);                 /* push word [0x4ff4] */
            ii(0x17_c4ff, 3);  call(0x17_91e3, -0x331f);               /* call 0x91e3 */
            ii(0x17_c502, 3);  add(sp, 0xa);                           /* add sp, 0xa */
            ii(0x17_c505, 3);  push(memw[ss, bp + 8]);                 /* push word [bp+0x8] */
            ii(0x17_c508, 3);  push(memw[ss, bp - 2]);                 /* push word [bp-0x2] */
            ii(0x17_c50b, 3);  push(memw[ss, bp - 4]);                 /* push word [bp-0x4] */
            ii(0x17_c50e, 4);  push(memw[ds, 0x1fa6]);                 /* push word [0x1fa6] */
            ii(0x17_c512, 4);  push(memw[ds, 0x1fa4]);                 /* push word [0x1fa4] */
            ii(0x17_c516, 3);  call(0x17_91e3, -0x3336);               /* call 0x91e3 */
            ii(0x17_c519, 3);  add(sp, 0xa);                           /* add sp, 0xa */
            ii(0x17_c51c, 4);  and(memb[ss, bp - 12], -2 /* 0xfe */);  /* and byte [bp-0xc], 0xfe */
            ii(0x17_c520, 3);  mov(ax, memw[ss, bp - 12]);             /* mov ax, [bp-0xc] */
            ii(0x17_c523, 3);  and(ah, 0xf);                           /* and ah, 0xf */
            ii(0x17_c526, 2);  sub(dx, dx);                            /* sub dx, dx */
            ii(0x17_c528, 3);  mov(memw[ss, bp - 12], ax);             /* mov [bp-0xc], ax */
            ii(0x17_c52b, 3);  mov(memw[ss, bp - 10], dx);             /* mov [bp-0xa], dx */
            ii(0x17_c52e, 3);  mov(ch, memb[ss, bp + 18]);             /* mov ch, [bp+0x12] */
            ii(0x17_c531, 2);  shl(ch, 1);                             /* shl ch, 1 */
            ii(0x17_c533, 2);  xor(ah, ch);                            /* xor ah, ch */
            ii(0x17_c535, 3);  and(ax, 0xe00);                         /* and ax, 0xe00 */
            ii(0x17_c538, 3);  xor(memw[ss, bp - 12], ax);             /* xor [bp-0xc], ax */
            ii(0x17_c53b, 3);  xor(memw[ss, bp - 10], dx);             /* xor [bp-0xa], dx */
            ii(0x17_c53e, 3);  push(memw[ss, bp - 10]);                /* push word [bp-0xa] */
            ii(0x17_c541, 3);  push(memw[ss, bp - 12]);                /* push word [bp-0xc] */
            ii(0x17_c544, 3);  push(memw[ss, bp - 2]);                 /* push word [bp-0x2] */
            ii(0x17_c547, 3);  push(memw[ss, bp - 4]);                 /* push word [bp-0x4] */
            ii(0x17_c54a, 4);  push(memw[ds, 0x4f8e]);                 /* push word [0x4f8e] */
            ii(0x17_c54e, 4);  push(memw[ds, 0x4f8c]);                 /* push word [0x4f8c] */
            ii(0x17_c552, 3);  call(0x17_9235, -0x3320);               /* call 0x9235 */
            ii(0x17_c555, 3);  add(sp, 0xc);                           /* add sp, 0xc */
            ii(0x17_c558, 3);  jmp(0x17_c4cc, -0x8f); goto l_0x17_c4cc;/* jmp 0xc4cc */
        //  ii(0x17_c55b, 1);  Недостижимый код.
        l_0x17_c55c:
            ii(0x17_c55c, 1);  pop(ds);                                /* pop ds */
            ii(0x17_c55d, 1);  leave();                                /* leave */
            ii(0x17_c55e, 1);  retf();                                 /* retf */
        }
    }
}
