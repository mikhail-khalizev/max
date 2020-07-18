using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x19_ba47-55a9ddb7")]
        public void Method_0019_ba47()
        {
            ii(0x19_ba47, 4);  enter(0x16, 0);                         /* enter 0x16, 0x0 */
            ii(0x19_ba4b, 1);  push(si);                               /* push si */
            ii(0x19_ba4c, 1);  push(ds);                               /* push ds */
            ii(0x19_ba4d, 3);  mov(ax, 0xa8);                          /* mov ax, 0xa8 */
            ii(0x19_ba50, 2);  mov(ds, ax);                            /* mov ds, ax */
            ii(0x19_ba52, 4);  mov(memb[ss, bp - 12], 0);              /* mov byte [bp-0xc], 0x0 */
            ii(0x19_ba56, 2);  sub(ax, ax);                            /* sub ax, ax */
            ii(0x19_ba58, 3);  mov(memw[ss, bp - 14], ax);             /* mov [bp-0xe], ax */
            ii(0x19_ba5b, 3);  mov(memw[ss, bp - 16], ax);             /* mov [bp-0x10], ax */
            ii(0x19_ba5e, 3);  mov(ax, memw[ss, bp + 14]);             /* mov ax, [bp+0xe] */
            ii(0x19_ba61, 2);  jmp(0x19_bae0, 0x7d); goto l_0x19_bae0; /* jmp 0xbae0 */
        l_0x19_ba63:
            ii(0x19_ba63, 3);  mov(ax, memw[ss, bp + 16]);             /* mov ax, [bp+0x10] */
            ii(0x19_ba66, 3);  mov(memw[ss, bp - 10], ax);             /* mov [bp-0xa], ax */
            ii(0x19_ba69, 5);  mov(memw[ss, bp - 8], 0);               /* mov word [bp-0x8], 0x0 */
        l_0x19_ba6e:
            ii(0x19_ba6e, 5);  mov(memw[ss, bp - 2], 2);               /* mov word [bp-0x2], 0x2 */
            ii(0x19_ba73, 3);  jmp(0x19_baff, 0x89); goto l_0x19_baff; /* jmp 0xbaff */
        l_0x19_ba76:
            ii(0x19_ba76, 3);  mov(ax, memw[ss, bp + 18]);             /* mov ax, [bp+0x12] */
            ii(0x19_ba79, 3);  mov(dx, memw[ss, bp + 20]);             /* mov dx, [bp+0x14] */
            ii(0x19_ba7c, 3);  mov(memw[ss, bp - 10], ax);             /* mov [bp-0xa], ax */
            ii(0x19_ba7f, 3);  mov(memw[ss, bp - 8], dx);              /* mov [bp-0x8], dx */
            ii(0x19_ba82, 2);  jmp(0x19_ba6e, -0x16); goto l_0x19_ba6e;/* jmp 0xba6e */
        l_0x19_ba84:
            ii(0x19_ba84, 3);  mov(ax, memw[ss, bp + 18]);             /* mov ax, [bp+0x12] */
            ii(0x19_ba87, 3);  mov(dx, memw[ss, bp + 20]);             /* mov dx, [bp+0x14] */
            ii(0x19_ba8a, 3);  mov(memw[ss, bp - 10], ax);             /* mov [bp-0xa], ax */
            ii(0x19_ba8d, 3);  mov(memw[ss, bp - 8], dx);              /* mov [bp-0x8], dx */
            ii(0x19_ba90, 4);  cmp(memw[ss, bp + 14], 7);              /* cmp word [bp+0xe], 0x7 */
            ii(0x19_ba94, 2);  if(jnz(0x19_ba9b, 5)) goto l_0x19_ba9b; /* jnz 0xba9b */
            ii(0x19_ba96, 3);  mov(ax, 4);                             /* mov ax, 0x4 */
            ii(0x19_ba99, 2);  jmp(0x19_ba9e, 3); goto l_0x19_ba9e;    /* jmp 0xba9e */
        l_0x19_ba9b:
            ii(0x19_ba9b, 3);  mov(ax, 1);                             /* mov ax, 0x1 */
        l_0x19_ba9e:
            ii(0x19_ba9e, 3);  mov(memw[ss, bp - 2], ax);              /* mov [bp-0x2], ax */
            ii(0x19_baa1, 2);  jmp(0x19_baff, 0x5c); goto l_0x19_baff; /* jmp 0xbaff */
        l_0x19_baa3:
            ii(0x19_baa3, 3);  mov(ax, memw[ss, bp + 18]);             /* mov ax, [bp+0x12] */
            ii(0x19_baa6, 3);  mov(dx, memw[ss, bp + 20]);             /* mov dx, [bp+0x14] */
            ii(0x19_baa9, 3);  mov(memw[ss, bp - 10], ax);             /* mov [bp-0xa], ax */
            ii(0x19_baac, 3);  mov(memw[ss, bp - 8], dx);              /* mov [bp-0x8], dx */
            ii(0x19_baaf, 3);  mov(ax, memw[ss, bp + 16]);             /* mov ax, [bp+0x10] */
            ii(0x19_bab2, 3);  mov(memw[ss, bp - 16], ax);             /* mov [bp-0x10], ax */
            ii(0x19_bab5, 5);  mov(memw[ss, bp - 14], 0);              /* mov word [bp-0xe], 0x0 */
            ii(0x19_baba, 5);  mov(memw[ss, bp - 2], 6);               /* mov word [bp-0x2], 0x6 */
            ii(0x19_babf, 2);  jmp(0x19_baff, 0x3e); goto l_0x19_baff; /* jmp 0xbaff */
        l_0x19_bac1:
            ii(0x19_bac1, 3);  mov(ax, memw[ss, bp + 16]);             /* mov ax, [bp+0x10] */
            ii(0x19_bac4, 3);  mov(cx, memw[ss, bp + 18]);             /* mov cx, [bp+0x12] */
            ii(0x19_bac7, 3);  mov(memw[ss, bp - 10], cx);             /* mov [bp-0xa], cx */
            ii(0x19_baca, 3);  mov(memw[ss, bp - 8], ax);              /* mov [bp-0x8], ax */
        l_0x19_bacd:
            ii(0x19_bacd, 5);  mov(memw[ss, bp - 2], 4);               /* mov word [bp-0x2], 0x4 */
            ii(0x19_bad2, 2);  jmp(0x19_baff, 0x2b); goto l_0x19_baff; /* jmp 0xbaff */
        l_0x19_bad4:
            ii(0x19_bad4, 3);  inc(memb[ss, bp - 12]);                 /* inc byte [bp-0xc] */
            ii(0x19_bad7, 2);  jmp(0x19_bacd, -0xc); goto l_0x19_bacd; /* jmp 0xbacd */
        l_0x19_bad9:
            ii(0x19_bad9, 5);  mov(memw[ss, bp - 2], 0);               /* mov word [bp-0x2], 0x0 */
            ii(0x19_bade, 2);  jmp(0x19_baff, 0x1f); goto l_0x19_baff; /* jmp 0xbaff */
        l_0x19_bae0:
            ii(0x19_bae0, 3);  cmp(ax, 8);                             /* cmp ax, 0x8 */
            ii(0x19_bae3, 2);  if(ja(0x19_bad9, -0xc)) goto l_0x19_bad9;/* ja 0xbad9 */
            ii(0x19_bae5, 2);  shl(ax, 1);                             /* shl ax, 1 */
            ii(0x19_bae7, 1);  xchg(bx, ax);                           /* xchg bx, ax */
            ii(0x19_bae8, 5);  /* jmp word [cs:bx+0x66cd] */
            switch (jmp_abs_switch(memw[cs, bx + 0x66cd]))
            {
                case 0x19_ba63:
                    goto l_0x19_ba63;
                case 0x19_ba76:
                    goto l_0x19_ba76;
                case 0x19_ba84:
                    goto l_0x19_ba84;
                case 0x19_baa3:
                    goto l_0x19_baa3;
                case 0x19_bac1:
                    goto l_0x19_bac1;
                case 0x19_bad4:
                    goto l_0x19_bad4;
                case 0x19_bad9:
                    goto l_0x19_bad9;
                default:
                    throw new NotImplementedException();
            }
        //  ii(0x19_baed, 18);  Недостижимый код.
        l_0x19_baff:
            ii(0x19_baff, 3);  mov(ax, memw[ss, bp - 10]);             /* mov ax, [bp-0xa] */
            ii(0x19_bb02, 3);  mov(dx, memw[ss, bp - 8]);              /* mov dx, [bp-0x8] */
            ii(0x19_bb05, 3);  mov(memw[ds, 0x2134], ax);              /* mov [0x2134], ax */
            ii(0x19_bb08, 4);  mov(memw[ds, 0x2136], dx);              /* mov [0x2136], dx */
            ii(0x19_bb0c, 3);  mov(ax, memw[ss, bp - 16]);             /* mov ax, [bp-0x10] */
            ii(0x19_bb0f, 3);  mov(dx, memw[ss, bp - 14]);             /* mov dx, [bp-0xe] */
            ii(0x19_bb12, 3);  mov(memw[ds, 0x2138], ax);              /* mov [0x2138], ax */
            ii(0x19_bb15, 4);  mov(memw[ds, 0x213a], dx);              /* mov [0x213a], dx */
            ii(0x19_bb19, 3);  jmp(0x19_bba3, 0x87); goto l_0x19_bba3; /* jmp 0xbba3 */
        l_0x19_bb1c:
            ii(0x19_bb1c, 3);  mov(bx, memw[ss, bp + 22]);             /* mov bx, [bp+0x16] */
            ii(0x19_bb1f, 2);  shl(bx, 1);                             /* shl bx, 1 */
            ii(0x19_bb21, 3);  les(si, memw[ss, bp + 24]);             /* les si, [bp+0x18] */
            ii(0x19_bb24, 3);  mov(ax, memw[es, bx + si]);             /* mov ax, [es:bx+si] */
            ii(0x19_bb27, 3);  mov(memw[ss, bp - 20], ax);             /* mov [bp-0x14], ax */
            ii(0x19_bb2a, 3);  mov(memw[ss, bp - 18], ax);             /* mov [bp-0x12], ax */
            ii(0x19_bb2d, 4);  cmp(memb[ss, bp - 12], 0);              /* cmp byte [bp-0xc], 0x0 */
            ii(0x19_bb31, 2);  if(jz(0x19_bb54, 0x21)) goto l_0x19_bb54;/* jz 0xbb54 */
            ii(0x19_bb33, 1);  cwd();                                  /* cwd */
            ii(0x19_bb34, 3);  mov(cx, memw[ss, bp + 18]);             /* mov cx, [bp+0x12] */
            ii(0x19_bb37, 3);  mov(bx, memw[ss, bp + 20]);             /* mov bx, [bp+0x14] */
            ii(0x19_bb3a, 2);  sub(cx, ax);                            /* sub cx, ax */
            ii(0x19_bb3c, 2);  sbb(bx, dx);                            /* sbb bx, dx */
            ii(0x19_bb3e, 3);  mov(ax, memw[ss, bp - 2]);              /* mov ax, [bp-0x2] */
            ii(0x19_bb41, 1);  cwd();                                  /* cwd */
            ii(0x19_bb42, 2);  sub(cx, ax);                            /* sub cx, ax */
            ii(0x19_bb44, 2);  sbb(bx, dx);                            /* sbb bx, dx */
            ii(0x19_bb46, 3);  sub(cx, memw[ss, bp + 10]);             /* sub cx, [bp+0xa] */
            ii(0x19_bb49, 3);  sbb(bx, memw[ss, bp + 12]);             /* sbb bx, [bp+0xc] */
            ii(0x19_bb4c, 4);  mov(memw[ds, 0x2134], cx);              /* mov [0x2134], cx */
            ii(0x19_bb50, 4);  mov(memw[ds, 0x2136], bx);              /* mov [0x2136], bx */
        l_0x19_bb54:
            ii(0x19_bb54, 3);  push(memw[ss, bp - 2]);                 /* push word [bp-0x2] */
            ii(0x19_bb57, 3);  mov(ax, 0x2134);                        /* mov ax, 0x2134 */
            ii(0x19_bb5a, 3);  mov(memw[ss, bp - 6], ax);              /* mov [bp-0x6], ax */
            ii(0x19_bb5d, 3);  mov(memw[ss, bp - 4], ds);              /* mov [bp-0x4], ds */
            ii(0x19_bb60, 1);  push(ds);                               /* push ds */
            ii(0x19_bb61, 1);  push(ax);                               /* push ax */
            ii(0x19_bb62, 3);  push(memw[ss, bp - 20]);                /* push word [bp-0x14] */
            ii(0x19_bb65, 3);  push(memw[ss, bp + 8]);                 /* push word [bp+0x8] */
            ii(0x19_bb68, 3);  push(memw[ss, bp + 6]);                 /* push word [bp+0x6] */
            ii(0x19_bb6b, 1);  push(cs);                               /* push cs */
            ii(0x19_bb6c, 3);  call(0x19_ba46, -0x129);                /* call 0xba46 */
            ii(0x19_bb6f, 3);  add(sp, 0xc);                           /* add sp, 0xc */
            ii(0x19_bb72, 2);  jmp(0x19_bb7a, 6); goto l_0x19_bb7a;    /* jmp 0xbb7a */
        l_0x19_bb74:
            ii(0x19_bb74, 3);  inc(memw[ss, bp - 18]);                 /* inc word [bp-0x12] */
            ii(0x19_bb77, 3);  inc(memw[ss, bp - 6]);                  /* inc word [bp-0x6] */
        l_0x19_bb7a:
            ii(0x19_bb7a, 3);  mov(ax, memw[ss, bp - 20]);             /* mov ax, [bp-0x14] */
            ii(0x19_bb7d, 3);  add(ax, memw[ss, bp - 2]);              /* add ax, [bp-0x2] */
            ii(0x19_bb80, 3);  cmp(ax, memw[ss, bp - 18]);             /* cmp ax, [bp-0x12] */
            ii(0x19_bb83, 2);  if(jle(0x19_bba3, 0x1e)) goto l_0x19_bba3;/* jle 0xbba3 */
            ii(0x19_bb85, 5);  cmp(memw[ss, bp - 18], 0x1000);         /* cmp word [bp-0x12], 0x1000 */
            ii(0x19_bb8a, 2);  if(jge(0x19_bba3, 0x17)) goto l_0x19_bba3;/* jge 0xbba3 */
            ii(0x19_bb8c, 4);  cmp(memw[ss, bp - 18], 0);              /* cmp word [bp-0x12], 0x0 */
            ii(0x19_bb90, 2);  if(jl(0x19_bb74, -0x1e)) goto l_0x19_bb74;/* jl 0xbb74 */
            ii(0x19_bb92, 3);  les(bx, memw[ss, bp - 6]);              /* les bx, [bp-0x6] */
            ii(0x19_bb95, 3);  mov(al, memb[es, bx]);                  /* mov al, [es:bx] */
            ii(0x19_bb98, 3);  les(bx, memw[ss, bp + 6]);              /* les bx, [bp+0x6] */
            ii(0x19_bb9b, 3);  mov(si, memw[ss, bp - 18]);             /* mov si, [bp-0x12] */
            ii(0x19_bb9e, 3);  mov(memb[es, bx + si], al);             /* mov [es:bx+si], al */
            ii(0x19_bba1, 2);  jmp(0x19_bb74, -0x2f); goto l_0x19_bb74;/* jmp 0xbb74 */
        l_0x19_bba3:
            ii(0x19_bba3, 3);  mov(ax, memw[ss, bp + 22]);             /* mov ax, [bp+0x16] */
            ii(0x19_bba6, 3);  dec(memw[ss, bp + 22]);                 /* dec word [bp+0x16] */
            ii(0x19_bba9, 2);  or(ax, ax);                             /* or ax, ax */
            ii(0x19_bbab, 2);  if(jz(0x19_bbb0, 3)) goto l_0x19_bbb0;  /* jz 0xbbb0 */
            ii(0x19_bbad, 3);  jmp(0x19_bb1c, -0x94); goto l_0x19_bb1c;/* jmp 0xbb1c */
        l_0x19_bbb0:
            ii(0x19_bbb0, 1);  pop(ds);                                /* pop ds */
            ii(0x19_bbb1, 1);  pop(si);                                /* pop si */
            ii(0x19_bbb2, 1);  leave();                                /* leave */
            ii(0x19_bbb3, 1);  retf();                                 /* retf */
        }
    }
}
