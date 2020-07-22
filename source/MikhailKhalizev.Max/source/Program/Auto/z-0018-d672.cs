using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x18_d672-2f65ab06")]
        public void Method_0018_d672()
        {
            ii(0x18_d672, 4);  enter(0x14, 0);                         /* enter 0x14, 0x0 */
            ii(0x18_d676, 5);  cmp(memb[ds, 0x2e], 0);                 /* cmp byte [0x2e], 0x0 */
            ii(0x18_d67b, 2);  if(jz(0x18_d6b8, 0x3b)) goto l_0x18_d6b8;/* jz 0xd6b8 */
            ii(0x18_d67d, 5);  cmp(memb[ds, 0xa16], 0);                /* cmp byte [0xa16], 0x0 */
            ii(0x18_d682, 2);  if(jnz(0x18_d6b8, 0x34)) goto l_0x18_d6b8;/* jnz 0xd6b8 */
            ii(0x18_d684, 3);  mov(ax, memw[ds, 0x9c]);                /* mov ax, [0x9c] */
            ii(0x18_d687, 4);  mov(dx, memw[ds, 0x9e]);                /* mov dx, [0x9e] */
            ii(0x18_d68b, 3);  mov(memw[ss, bp - 4], ax);              /* mov [bp-0x4], ax */
            ii(0x18_d68e, 3);  mov(memw[ss, bp - 2], dx);              /* mov [bp-0x2], dx */
            ii(0x18_d691, 5);  cmp(memb[ds, 0x2e], 0xb);               /* cmp byte [0x2e], 0xb */
            ii(0x18_d696, 2);  if(jnz(0x18_d6a1, 9)) goto l_0x18_d6a1; /* jnz 0xd6a1 */
        l_0x18_d698:
            ii(0x18_d698, 3);  mov(ax, memw[ds, 0xaa8]);               /* mov ax, [0xaa8] */
            ii(0x18_d69b, 4);  mov(dx, memw[ds, 0xaaa]);               /* mov dx, [0xaaa] */
            ii(0x18_d69f, 1);  leave();                                /* leave */
            ii(0x18_d6a0, 1);  ret(); return;                          /* ret */
        l_0x18_d6a1:
            ii(0x18_d6a1, 3);  mov(ax, memw[ss, bp - 4]);              /* mov ax, [bp-0x4] */
            ii(0x18_d6a4, 3);  mov(dx, memw[ss, bp - 2]);              /* mov dx, [bp-0x2] */
            ii(0x18_d6a7, 4);  sub(ax, memw[ds, 0x98]);                /* sub ax, [0x98] */
            ii(0x18_d6ab, 4);  sbb(dx, memw[ds, 0x9a]);                /* sbb dx, [0x9a] */
            ii(0x18_d6af, 1);  push(dx);                               /* push dx */
            ii(0x18_d6b0, 1);  push(ax);                               /* push ax */
            ii(0x18_d6b1, 3);  call(0x18_dbd7, 0x523);                 /* call 0xdbd7 */
            ii(0x18_d6b4, 1);  pop(bx);                                /* pop bx */
            ii(0x18_d6b5, 1);  pop(bx);                                /* pop bx */
            ii(0x18_d6b6, 1);  leave();                                /* leave */
            ii(0x18_d6b7, 1);  ret(); return;                          /* ret */
        l_0x18_d6b8:
            ii(0x18_d6b8, 5);  mov(memw[ss, bp - 20], 3);              /* mov word [bp-0x14], 0x3 */
        l_0x18_d6bd:
            ii(0x18_d6bd, 3);  mov(ax, memw[ss, bp + 4]);              /* mov ax, [bp+0x4] */
            ii(0x18_d6c0, 3);  mov(dx, memw[ss, bp + 6]);              /* mov dx, [bp+0x6] */
            ii(0x18_d6c3, 4);  sub(ax, memw[ds, 0xaa8]);               /* sub ax, [0xaa8] */
            ii(0x18_d6c7, 4);  sbb(dx, memw[ds, 0xaaa]);               /* sbb dx, [0xaaa] */
            ii(0x18_d6cb, 3);  add(ax, 0xfff);                         /* add ax, 0xfff */
            ii(0x18_d6ce, 3);  adc(dx, 0);                             /* adc dx, 0x0 */
            ii(0x18_d6d1, 3);  and(ax, 0xf000);                        /* and ax, 0xf000 */
            ii(0x18_d6d4, 3);  mov(memw[ss, bp - 12], ax);             /* mov [bp-0xc], ax */
            ii(0x18_d6d7, 3);  mov(memw[ss, bp - 10], dx);             /* mov [bp-0xa], dx */
            ii(0x18_d6da, 5);  mov(memw[ss, bp - 14], 3);              /* mov word [bp-0xe], 0x3 */
        l_0x18_d6df:
            ii(0x18_d6df, 4);  call_abs(memw[ds, 0xaa4]);              /* call word [0xaa4] */
            ii(0x18_d6e3, 3);  mov(memw[ss, bp - 8], ax);              /* mov [bp-0x8], ax */
            ii(0x18_d6e6, 3);  mov(memw[ss, bp - 6], dx);              /* mov [bp-0x6], dx */
            ii(0x18_d6e9, 3);  cmp(dx, memw[ss, bp - 10]);             /* cmp dx, [bp-0xa] */
            ii(0x18_d6ec, 2);  if(jg(0x18_d701, 0x13)) goto l_0x18_d701;/* jg 0xd701 */
            ii(0x18_d6ee, 2);  if(jl(0x18_d6f5, 5)) goto l_0x18_d6f5;  /* jl 0xd6f5 */
            ii(0x18_d6f0, 3);  cmp(ax, memw[ss, bp - 12]);             /* cmp ax, [bp-0xc] */
            ii(0x18_d6f3, 2);  if(jae(0x18_d701, 0xc)) goto l_0x18_d701;/* jae 0xd701 */
        l_0x18_d6f5:
            ii(0x18_d6f5, 4);  cmp(memw[ss, bp + 8], 0);               /* cmp word [bp+0x8], 0x0 */
            ii(0x18_d6f9, 2);  if(jnz(0x18_d698, -0x63)) goto l_0x18_d698;/* jnz 0xd698 */
            ii(0x18_d6fb, 3);  mov(memw[ss, bp - 12], ax);             /* mov [bp-0xc], ax */
            ii(0x18_d6fe, 3);  mov(memw[ss, bp - 10], dx);             /* mov [bp-0xa], dx */
        l_0x18_d701:
            ii(0x18_d701, 4);  cmp(memw[ss, bp - 10], 0);              /* cmp word [bp-0xa], 0x0 */
            ii(0x18_d705, 2);  if(jg(0x18_d70f, 8)) goto l_0x18_d70f;  /* jg 0xd70f */
            ii(0x18_d707, 2);  if(jl(0x18_d698, -0x71)) goto l_0x18_d698;/* jl 0xd698 */
            ii(0x18_d709, 4);  cmp(memw[ss, bp - 12], 0);              /* cmp word [bp-0xc], 0x0 */
            ii(0x18_d70d, 2);  if(jz(0x18_d698, -0x77)) goto l_0x18_d698;/* jz 0xd698 */
        l_0x18_d70f:
            ii(0x18_d70f, 3);  push(memw[ss, bp - 10]);                /* push word [bp-0xa] */
            ii(0x18_d712, 3);  push(memw[ss, bp - 12]);                /* push word [bp-0xc] */
            ii(0x18_d715, 4);  call_abs(memw[ds, 0xaa6]);              /* call word [0xaa6] */
            ii(0x18_d719, 1);  pop(bx);                                /* pop bx */
            ii(0x18_d71a, 1);  pop(bx);                                /* pop bx */
            ii(0x18_d71b, 3);  mov(memw[ss, bp - 4], ax);              /* mov [bp-0x4], ax */
            ii(0x18_d71e, 3);  mov(memw[ss, bp - 2], dx);              /* mov [bp-0x2], dx */
            ii(0x18_d721, 2);  or(dx, ax);                             /* or dx, ax */
            ii(0x18_d723, 2);  if(jnz(0x18_d73b, 0x16)) goto l_0x18_d73b;/* jnz 0xd73b */
            ii(0x18_d725, 4);  cmp(memw[ss, bp + 8], 0);               /* cmp word [bp+0x8], 0x0 */
            ii(0x18_d729, 2);  if(jz(0x18_d733, 8)) goto l_0x18_d733;  /* jz 0xd733 */
            ii(0x18_d72b, 3);  dec(memw[ss, bp - 14]);                 /* dec word [bp-0xe] */
            ii(0x18_d72e, 2);  if(jns(0x18_d733, 3)) goto l_0x18_d733; /* jns 0xd733 */
            ii(0x18_d730, 3);  jmp(0x18_d698, -0x9b); goto l_0x18_d698;/* jmp 0xd698 */
        l_0x18_d733:
            ii(0x18_d733, 3);  sar(memw[ss, bp - 10], 1);              /* sar word [bp-0xa], 1 */
            ii(0x18_d736, 3);  rcr(memw[ss, bp - 12], 1);              /* rcr word [bp-0xc], 1 */
            ii(0x18_d739, 2);  jmp(0x18_d6df, -0x5c); goto l_0x18_d6df;/* jmp 0xd6df */
        l_0x18_d73b:
            ii(0x18_d73b, 3);  push(memw[ss, bp - 2]);                 /* push word [bp-0x2] */
            ii(0x18_d73e, 1);  push(ax);                               /* push ax */
            ii(0x18_d73f, 3);  call(0x18_dbbc, 0x47a);                 /* call 0xdbbc */
            ii(0x18_d742, 1);  pop(bx);                                /* pop bx */
            ii(0x18_d743, 1);  pop(bx);                                /* pop bx */
            ii(0x18_d744, 3);  mov(memw[ss, bp - 18], ax);             /* mov [bp-0x12], ax */
            ii(0x18_d747, 3);  mov(memw[ss, bp - 16], dx);             /* mov [bp-0x10], dx */
            ii(0x18_d74a, 1);  cli();                                  /* cli */
            ii(0x18_d74b, 3);  mov(ax, memw[ss, bp - 18]);             /* mov ax, [bp-0x12] */
            ii(0x18_d74e, 3);  mov(dx, memw[ss, bp - 16]);             /* mov dx, [bp-0x10] */
            ii(0x18_d751, 4);  cmp(memw[ds, 0x9a], dx);                /* cmp [0x9a], dx */
            ii(0x18_d755, 2);  if(ja(0x18_d768, 0x11)) goto l_0x18_d768;/* ja 0xd768 */
            ii(0x18_d757, 2);  if(jb(0x18_d75f, 6)) goto l_0x18_d75f;  /* jb 0xd75f */
            ii(0x18_d759, 4);  cmp(memw[ds, 0x98], ax);                /* cmp [0x98], ax */
            ii(0x18_d75d, 2);  if(ja(0x18_d768, 9)) goto l_0x18_d768;  /* ja 0xd768 */
        l_0x18_d75f:
            ii(0x18_d75f, 3);  mov(ax, memw[ds, 0x9a]);                /* mov ax, [0x9a] */
            ii(0x18_d762, 4);  or(ax, memw[ds, 0x98]);                 /* or ax, [0x98] */
            ii(0x18_d766, 2);  if(jnz(0x18_d7b4, 0x4c)) goto l_0x18_d7b4;/* jnz 0xd7b4 */
        l_0x18_d768:
            ii(0x18_d768, 3);  mov(ax, memw[ds, 0x98]);                /* mov ax, [0x98] */
            ii(0x18_d76b, 4);  mov(dx, memw[ds, 0x9a]);                /* mov dx, [0x9a] */
            ii(0x18_d76f, 3);  mov(memw[ss, bp - 8], ax);              /* mov [bp-0x8], ax */
            ii(0x18_d772, 3);  mov(memw[ss, bp - 6], dx);              /* mov [bp-0x6], dx */
            ii(0x18_d775, 3);  mov(ax, memw[ss, bp - 18]);             /* mov ax, [bp-0x12] */
            ii(0x18_d778, 3);  mov(dx, memw[ss, bp - 16]);             /* mov dx, [bp-0x10] */
            ii(0x18_d77b, 3);  mov(memw[ds, 0x98], ax);                /* mov [0x98], ax */
            ii(0x18_d77e, 4);  mov(memw[ds, 0x9a], dx);                /* mov [0x9a], dx */
            ii(0x18_d782, 3);  push(memw[ss, bp - 6]);                 /* push word [bp-0x6] */
            ii(0x18_d785, 3);  push(memw[ss, bp - 8]);                 /* push word [bp-0x8] */
            ii(0x18_d788, 2);  push(0);                                /* push 0x0 */
            ii(0x18_d78a, 1);  push(dx);                               /* push dx */
            ii(0x18_d78b, 1);  push(ax);                               /* push ax */
            ii(0x18_d78c, 3);  call(0x18_db67, 0x3d8);                 /* call 0xdb67 */
            ii(0x18_d78f, 3);  add(sp, 0xa);                           /* add sp, 0xa */
            ii(0x18_d792, 2);  push(0);                                /* push 0x0 */
            ii(0x18_d794, 2);  push(0);                                /* push 0x0 */
            ii(0x18_d796, 2);  push(4);                                /* push 0x4 */
            ii(0x18_d798, 3);  push(memw[ss, bp - 16]);                /* push word [bp-0x10] */
            ii(0x18_d79b, 3);  push(memw[ss, bp - 18]);                /* push word [bp-0x12] */
            ii(0x18_d79e, 3);  call(0x18_db67, 0x3c6);                 /* call 0xdb67 */
            ii(0x18_d7a1, 3);  add(sp, 0xa);                           /* add sp, 0xa */
            ii(0x18_d7a4, 4);  add(memw[ss, bp - 18], 1);              /* add word [bp-0x12], 0x1 */
            ii(0x18_d7a8, 4);  adc(memw[ss, bp - 16], 0);              /* adc word [bp-0x10], 0x0 */
            ii(0x18_d7ac, 4);  sub(memw[ss, bp - 12], 0x10);           /* sub word [bp-0xc], 0x10 */
            ii(0x18_d7b0, 4);  sbb(memw[ss, bp - 10], 0);              /* sbb word [bp-0xa], 0x0 */
        l_0x18_d7b4:
            ii(0x18_d7b4, 3);  push(memw[ss, bp - 10]);                /* push word [bp-0xa] */
            ii(0x18_d7b7, 3);  push(memw[ss, bp - 12]);                /* push word [bp-0xc] */
            ii(0x18_d7ba, 3);  call(0x18_dbbc, 0x3ff);                 /* call 0xdbbc */
            ii(0x18_d7bd, 1);  pop(bx);                                /* pop bx */
            ii(0x18_d7be, 1);  pop(bx);                                /* pop bx */
            ii(0x18_d7bf, 3);  add(ax, memw[ss, bp - 18]);             /* add ax, [bp-0x12] */
            ii(0x18_d7c2, 3);  adc(dx, memw[ss, bp - 16]);             /* adc dx, [bp-0x10] */
            ii(0x18_d7c5, 3);  mov(memw[ss, bp - 4], ax);              /* mov [bp-0x4], ax */
            ii(0x18_d7c8, 3);  mov(memw[ss, bp - 2], dx);              /* mov [bp-0x2], dx */
            ii(0x18_d7cb, 4);  cmp(memw[ds, 0x9e], dx);                /* cmp [0x9e], dx */
            ii(0x18_d7cf, 2);  if(ja(0x18_d7e0, 0xf)) goto l_0x18_d7e0;/* ja 0xd7e0 */
            ii(0x18_d7d1, 2);  if(jb(0x18_d7d9, 6)) goto l_0x18_d7d9;  /* jb 0xd7d9 */
            ii(0x18_d7d3, 4);  cmp(memw[ds, 0x9c], ax);                /* cmp [0x9c], ax */
            ii(0x18_d7d7, 2);  if(jae(0x18_d7e0, 7)) goto l_0x18_d7e0; /* jae 0xd7e0 */
        l_0x18_d7d9:
            ii(0x18_d7d9, 3);  mov(memw[ds, 0x9c], ax);                /* mov [0x9c], ax */
            ii(0x18_d7dc, 4);  mov(memw[ds, 0x9e], dx);                /* mov [0x9e], dx */
        l_0x18_d7e0:
            ii(0x18_d7e0, 3);  push(memw[ss, bp - 10]);                /* push word [bp-0xa] */
            ii(0x18_d7e3, 3);  push(memw[ss, bp - 12]);                /* push word [bp-0xc] */
            ii(0x18_d7e6, 3);  call(0x18_dbbc, 0x3d3);                 /* call 0xdbbc */
            ii(0x18_d7e9, 1);  pop(bx);                                /* pop bx */
            ii(0x18_d7ea, 1);  pop(bx);                                /* pop bx */
            ii(0x18_d7eb, 1);  push(dx);                               /* push dx */
            ii(0x18_d7ec, 1);  push(ax);                               /* push ax */
            ii(0x18_d7ed, 3);  push(memw[ss, bp - 16]);                /* push word [bp-0x10] */
            ii(0x18_d7f0, 3);  push(memw[ss, bp - 18]);                /* push word [bp-0x12] */
            ii(0x18_d7f3, 3);  call(0x18_c010, -0x17e6);               /* call 0xc010 */
            ii(0x18_d7f6, 3);  add(sp, 8);                             /* add sp, 0x8 */
            ii(0x18_d7f9, 5);  cmp(memb[ds, 0x2e], 0);                 /* cmp byte [0x2e], 0x0 */
            ii(0x18_d7fe, 2);  if(jnz(0x18_d811, 0x11)) goto l_0x18_d811;/* jnz 0xd811 */
            ii(0x18_d800, 4);  push(memw[ds, 0x1204]);                 /* push word [0x1204] */
            ii(0x18_d804, 4);  push(memw[ds, 0x1202]);                 /* push word [0x1202] */
            ii(0x18_d808, 3);  push(memw[ss, bp - 16]);                /* push word [bp-0x10] */
            ii(0x18_d80b, 3);  push(memw[ss, bp - 18]);                /* push word [bp-0x12] */
            ii(0x18_d80e, 3);  call(0x18_c436, -0x13db);               /* call 0xc436 */
        l_0x18_d811:
            ii(0x18_d811, 5);  cmp(memb[ds, 0x2e], 0xb);               /* cmp byte [0x2e], 0xb */
            ii(0x18_d816, 2);  if(jz(0x18_d826, 0xe)) goto l_0x18_d826;/* jz 0xd826 */
            ii(0x18_d818, 3);  mov(ax, memw[ss, bp - 12]);             /* mov ax, [bp-0xc] */
            ii(0x18_d81b, 3);  mov(dx, memw[ss, bp - 10]);             /* mov dx, [bp-0xa] */
            ii(0x18_d81e, 4);  add(memw[ds, 0xaa8], ax);               /* add [0xaa8], ax */
            ii(0x18_d822, 4);  adc(memw[ds, 0xaaa], dx);               /* adc [0xaaa], dx */
        l_0x18_d826:
            ii(0x18_d826, 3);  dec(memw[ss, bp - 20]);                 /* dec word [bp-0x14] */
            ii(0x18_d829, 4);  cmp(memw[ss, bp - 20], 0);              /* cmp word [bp-0x14], 0x0 */
            ii(0x18_d82d, 2);  if(jg(0x18_d832, 3)) goto l_0x18_d832;  /* jg 0xd832 */
            ii(0x18_d82f, 3);  jmp(0x18_d698, -0x19a); goto l_0x18_d698;/* jmp 0xd698 */
        l_0x18_d832:
            ii(0x18_d832, 3);  jmp(0x18_d6bd, -0x178); goto l_0x18_d6bd;/* jmp 0xd6bd */
        }
    }
}
