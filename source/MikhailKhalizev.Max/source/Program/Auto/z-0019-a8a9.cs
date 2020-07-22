using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x19_a8a9-aab42928")]
        public void Method_0019_a8a9()
        {
            ii(0x19_a8a9, 4);  enter(0x10, 0);                         /* enter 0x10, 0x0 */
            ii(0x19_a8ad, 1);  push(si);                               /* push si */
            ii(0x19_a8ae, 3);  les(bx, memw[ss, bp + 6]);              /* les bx, [bp+0x6] */
            ii(0x19_a8b1, 4);  mov(ax, memw[es, bx + 28]);             /* mov ax, [es:bx+0x1c] */
            ii(0x19_a8b5, 4);  mov(dx, memw[es, bx + 30]);             /* mov dx, [es:bx+0x1e] */
            ii(0x19_a8b9, 3);  mov(memw[ss, bp - 16], ax);             /* mov [bp-0x10], ax */
            ii(0x19_a8bc, 3);  mov(memw[ss, bp - 14], dx);             /* mov [bp-0xe], dx */
            ii(0x19_a8bf, 4);  mov(ax, memw[es, bx + 60]);             /* mov ax, [es:bx+0x3c] */
            ii(0x19_a8c3, 4);  mov(dx, memw[es, bx + 62]);             /* mov dx, [es:bx+0x3e] */
            ii(0x19_a8c7, 3);  mov(memw[ss, bp - 12], ax);             /* mov [bp-0xc], ax */
            ii(0x19_a8ca, 3);  mov(memw[ss, bp - 10], dx);             /* mov [bp-0xa], dx */
            ii(0x19_a8cd, 2);  sub(cx, cx);                            /* sub cx, cx */
            ii(0x19_a8cf, 3);  mov(memw[ss, bp - 2], cx);              /* mov [bp-0x2], cx */
            ii(0x19_a8d2, 3);  mov(memw[ss, bp - 4], cx);              /* mov [bp-0x4], cx */
            ii(0x19_a8d5, 3);  cmp(memw[ss, bp + 4], cx);              /* cmp [bp+0x4], cx */
            ii(0x19_a8d8, 2);  if(jz(0x19_a8f5, 0x1b)) goto l_0x19_a8f5;/* jz 0xa8f5 */
            ii(0x19_a8da, 4);  imul(bx, memw[ss, bp + 4], 0x18);       /* imul bx, [bp+0x4], 0x18 */
            ii(0x19_a8de, 2);  mov(es, dx);                            /* mov es, dx */
            ii(0x19_a8e0, 2);  mov(si, ax);                            /* mov si, ax */
            ii(0x19_a8e2, 4);  mov(ax, memw[es, bx + si - 24]);        /* mov ax, [es:bx+si-0x18] */
            ii(0x19_a8e6, 4);  mov(dx, memw[es, bx + si - 22]);        /* mov dx, [es:bx+si-0x16] */
            ii(0x19_a8ea, 3);  add(ax, 0xfff);                         /* add ax, 0xfff */
            ii(0x19_a8ed, 2);  adc(dx, cx);                            /* adc dx, cx */
            ii(0x19_a8ef, 3);  and(ax, 0xf000);                        /* and ax, 0xf000 */
            ii(0x19_a8f2, 3);  jmp(0x19_a98e, 0x99); goto l_0x19_a98e; /* jmp 0xa98e */
        l_0x19_a8f5:
            ii(0x19_a8f5, 3);  les(bx, memw[ss, bp - 16]);             /* les bx, [bp-0x10] */
            ii(0x19_a8f8, 5);  test(memb[es, bx + 16], 0x10);          /* test byte [es:bx+0x10], 0x10 */
            ii(0x19_a8fd, 2);  if(jz(0x19_a950, 0x51)) goto l_0x19_a950;/* jz 0xa950 */
            ii(0x19_a8ff, 2);  jmp(0x19_a92e, 0x2d); goto l_0x19_a92e; /* jmp 0xa92e */
        l_0x19_a901:
            ii(0x19_a901, 3);  imul(bx, ax, 0x18);                     /* imul bx, ax, 0x18 */
            ii(0x19_a904, 3);  add(bx, memw[ss, bp - 12]);             /* add bx, [bp-0xc] */
            ii(0x19_a907, 3);  mov(es, memw[ss, bp - 10]);             /* mov es, [bp-0xa] */
            ii(0x19_a90a, 4);  mov(ax, memw[es, bx + 4]);              /* mov ax, [es:bx+0x4] */
            ii(0x19_a90e, 4);  mov(dx, memw[es, bx + 6]);              /* mov dx, [es:bx+0x6] */
            ii(0x19_a912, 3);  add(ax, memw[es, bx]);                  /* add ax, [es:bx] */
            ii(0x19_a915, 4);  adc(dx, memw[es, bx + 2]);              /* adc dx, [es:bx+0x2] */
            ii(0x19_a919, 3);  cmp(dx, memw[ss, bp - 2]);              /* cmp dx, [bp-0x2] */
            ii(0x19_a91c, 2);  if(jb(0x19_a92b, 0xd)) goto l_0x19_a92b;/* jb 0xa92b */
            ii(0x19_a91e, 2);  if(ja(0x19_a925, 5)) goto l_0x19_a925;  /* ja 0xa925 */
            ii(0x19_a920, 3);  cmp(ax, memw[ss, bp - 4]);              /* cmp ax, [bp-0x4] */
            ii(0x19_a923, 2);  if(jbe(0x19_a92b, 6)) goto l_0x19_a92b; /* jbe 0xa92b */
        l_0x19_a925:
            ii(0x19_a925, 3);  mov(memw[ss, bp - 4], ax);              /* mov [bp-0x4], ax */
            ii(0x19_a928, 3);  mov(memw[ss, bp - 2], dx);              /* mov [bp-0x2], dx */
        l_0x19_a92b:
            ii(0x19_a92b, 3);  inc(memw[ss, bp + 4]);                  /* inc word [bp+0x4] */
        l_0x19_a92e:
            ii(0x19_a92e, 3);  mov(ax, memw[ss, bp + 4]);              /* mov ax, [bp+0x4] */
            ii(0x19_a931, 3);  les(bx, memw[ss, bp - 16]);             /* les bx, [bp-0x10] */
            ii(0x19_a934, 4);  cmp(memw[es, bx + 68], ax);             /* cmp [es:bx+0x44], ax */
            ii(0x19_a938, 2);  if(ja(0x19_a901, -0x39)) goto l_0x19_a901;/* ja 0xa901 */
            ii(0x19_a93a, 3);  les(bx, memw[ss, bp - 12]);             /* les bx, [bp-0xc] */
            ii(0x19_a93d, 4);  mov(ax, memw[es, bx + 4]);              /* mov ax, [es:bx+0x4] */
            ii(0x19_a941, 4);  mov(dx, memw[es, bx + 6]);              /* mov dx, [es:bx+0x6] */
            ii(0x19_a945, 3);  sub(memw[ss, bp - 4], ax);              /* sub [bp-0x4], ax */
            ii(0x19_a948, 3);  sbb(memw[ss, bp - 2], dx);              /* sbb [bp-0x2], dx */
            ii(0x19_a94b, 2);  jmp(0x19_a988, 0x3b); goto l_0x19_a988; /* jmp 0xa988 */
        l_0x19_a94d:
            ii(0x19_a94d, 3);  inc(memw[ss, bp + 4]);                  /* inc word [bp+0x4] */
        l_0x19_a950:
            ii(0x19_a950, 3);  mov(ax, memw[ss, bp + 4]);              /* mov ax, [bp+0x4] */
            ii(0x19_a953, 3);  les(bx, memw[ss, bp - 16]);             /* les bx, [bp-0x10] */
            ii(0x19_a956, 4);  cmp(memw[es, bx + 68], ax);             /* cmp [es:bx+0x44], ax */
            ii(0x19_a95a, 2);  if(jbe(0x19_a988, 0x2c)) goto l_0x19_a988;/* jbe 0xa988 */
            ii(0x19_a95c, 3);  mov(cx, memw[ss, bp - 4]);              /* mov cx, [bp-0x4] */
            ii(0x19_a95f, 3);  mov(dx, memw[ss, bp - 2]);              /* mov dx, [bp-0x2] */
            ii(0x19_a962, 4);  add(cx, 0xfff);                         /* add cx, 0xfff */
            ii(0x19_a966, 3);  adc(dx, 0);                             /* adc dx, 0x0 */
            ii(0x19_a969, 4);  and(cx, 0xf000);                        /* and cx, 0xf000 */
            ii(0x19_a96d, 3);  mov(memw[ss, bp - 4], cx);              /* mov [bp-0x4], cx */
            ii(0x19_a970, 3);  mov(memw[ss, bp - 2], dx);              /* mov [bp-0x2], dx */
            ii(0x19_a973, 3);  imul(bx, ax, 0x18);                     /* imul bx, ax, 0x18 */
            ii(0x19_a976, 3);  les(si, memw[ss, bp - 12]);             /* les si, [bp-0xc] */
            ii(0x19_a979, 3);  mov(ax, memw[es, bx + si]);             /* mov ax, [es:bx+si] */
            ii(0x19_a97c, 4);  mov(dx, memw[es, bx + si + 2]);         /* mov dx, [es:bx+si+0x2] */
            ii(0x19_a980, 3);  add(memw[ss, bp - 4], ax);              /* add [bp-0x4], ax */
            ii(0x19_a983, 3);  adc(memw[ss, bp - 2], dx);              /* adc [bp-0x2], dx */
            ii(0x19_a986, 2);  jmp(0x19_a94d, -0x3b); goto l_0x19_a94d;/* jmp 0xa94d */
        l_0x19_a988:
            ii(0x19_a988, 3);  mov(ax, memw[ss, bp - 4]);              /* mov ax, [bp-0x4] */
            ii(0x19_a98b, 3);  mov(dx, memw[ss, bp - 2]);              /* mov dx, [bp-0x2] */
        l_0x19_a98e:
            ii(0x19_a98e, 1);  pop(si);                                /* pop si */
            ii(0x19_a98f, 1);  leave();                                /* leave */
            ii(0x19_a990, 3);  ret(6);                                 /* ret 0x6 */
        }
    }
}
