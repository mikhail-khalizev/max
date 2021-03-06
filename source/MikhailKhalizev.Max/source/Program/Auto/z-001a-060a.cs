using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1a_060a-e8bbd731")]
        public void Method_001a_060a()
        {
            ii(0x1a_060a, 4);  enter(0x10, 0);                         /* enter 0x10, 0x0 */
            ii(0x1a_060e, 4);  mov(es, memw[ds, 0x3fe4]);              /* mov es, [0x3fe4] */
            ii(0x1a_0612, 4);  mov(ax, memw[es, 0x3b78]);              /* mov ax, [es:0x3b78] */
            ii(0x1a_0616, 2);  sub(bx, bx);                            /* sub bx, bx */
            ii(0x1a_0618, 2);  mov(es, ax);                            /* mov es, ax */
            ii(0x1a_061a, 3);  mov(memw[ss, bp - 12], bx);             /* mov [bp-0xc], bx */
            ii(0x1a_061d, 3);  mov(memw[ss, bp - 10], es);             /* mov [bp-0xa], es */
            ii(0x1a_0620, 5);  test(memb[es, bx + 71], 0x80);          /* test byte [es:bx+0x47], 0x80 */
            ii(0x1a_0625, 2);  if(jnz(0x1a_0638, 0x11)) goto l_0x1a_0638;/* jnz 0x638 */
            ii(0x1a_0627, 3);  les(bx, memw[ss, bp + 4]);              /* les bx, [bp+0x4] */
            ii(0x1a_062a, 4);  mov(memb[es, bx], 0x2e);                /* mov byte [es:bx], 0x2e */
            ii(0x1a_062e, 5);  mov(memb[es, bx + 1], 0);               /* mov byte [es:bx+0x1], 0x0 */
            ii(0x1a_0633, 2);  sub(ax, ax);                            /* sub ax, ax */
            ii(0x1a_0635, 3);  jmp(0x1a_06c1, 0x89); goto l_0x1a_06c1; /* jmp 0x6c1 */
        l_0x1a_0638:
            ii(0x1a_0638, 3);  mov(ax, 0xbfde);                        /* mov ax, 0xbfde */
            ii(0x1a_063b, 3);  mov(bx, 9);                             /* mov bx, 0x9 */
            ii(0x1a_063e, 2);  @int(0x15);                             /* int 0x15 */
            ii(0x1a_0640, 3);  mov(memw[ss, bp - 4], dx);              /* mov [bp-0x4], dx */
            ii(0x1a_0643, 3);  mov(memw[ss, bp - 2], cx);              /* mov [bp-0x2], cx */
            ii(0x1a_0646, 3);  mov(ax, memw[ss, bp - 2]);              /* mov ax, [bp-0x2] */
            ii(0x1a_0649, 3);  or(ax, memw[ss, bp - 4]);               /* or ax, [bp-0x4] */
            ii(0x1a_064c, 2);  if(jz(0x1a_06c1, 0x73)) goto l_0x1a_06c1;/* jz 0x6c1 */
            ii(0x1a_064e, 3);  push(0x100);                            /* push 0x100 */
            ii(0x1a_0651, 3);  push(memw[ss, bp - 2]);                 /* push word [bp-0x2] */
            ii(0x1a_0654, 3);  push(memw[ss, bp - 4]);                 /* push word [bp-0x4] */
            ii(0x1a_0657, 5);  call_far_abs(0x80, 0x56e0);             /* call word 0x80:0x56e0 */
            ii(0x1a_065c, 3);  add(sp, 6);                             /* add sp, 0x6 */
            ii(0x1a_065f, 3);  mov(memw[ss, bp - 4], ax);              /* mov [bp-0x4], ax */
            ii(0x1a_0662, 3);  mov(memw[ss, bp - 2], dx);              /* mov [bp-0x2], dx */
            ii(0x1a_0665, 2);  or(dx, ax);                             /* or dx, ax */
            ii(0x1a_0667, 2);  if(jz(0x1a_06c1, 0x58)) goto l_0x1a_06c1;/* jz 0x6c1 */
            ii(0x1a_0669, 3);  push(memw[ss, bp + 6]);                 /* push word [bp+0x6] */
            ii(0x1a_066c, 3);  push(memw[ss, bp + 4]);                 /* push word [bp+0x4] */
            ii(0x1a_066f, 3);  push(memw[ss, bp - 2]);                 /* push word [bp-0x2] */
            ii(0x1a_0672, 1);  push(ax);                               /* push ax */
            ii(0x1a_0673, 3);  call(0x19_ff6c, -0x70a);                /* call 0xff6c */
            ii(0x1a_0676, 3);  push(memw[ss, bp - 2]);                 /* push word [bp-0x2] */
            ii(0x1a_0679, 3);  push(memw[ss, bp - 4]);                 /* push word [bp-0x4] */
            ii(0x1a_067c, 5);  call_far_abs(0x80, 0x4f60);             /* call word 0x80:0x4f60 */
            ii(0x1a_0681, 1);  pop(bx);                                /* pop bx */
            ii(0x1a_0682, 1);  pop(bx);                                /* pop bx */
            ii(0x1a_0683, 3);  push(memw[ss, bp + 6]);                 /* push word [bp+0x6] */
            ii(0x1a_0686, 3);  push(memw[ss, bp + 4]);                 /* push word [bp+0x4] */
            ii(0x1a_0689, 3);  call(0x19_ff2f, -0x75d);                /* call 0xff2f */
            ii(0x1a_068c, 3);  add(ax, memw[ss, bp + 4]);              /* add ax, [bp+0x4] */
            ii(0x1a_068f, 3);  mov(dx, memw[ss, bp + 6]);              /* mov dx, [bp+0x6] */
            ii(0x1a_0692, 3);  mov(memw[ss, bp - 4], ax);              /* mov [bp-0x4], ax */
            ii(0x1a_0695, 3);  mov(memw[ss, bp - 2], dx);              /* mov [bp-0x2], dx */
            ii(0x1a_0698, 2);  jmp(0x1a_06b3, 0x19); goto l_0x1a_06b3; /* jmp 0x6b3 */
        l_0x1a_069a:
            ii(0x1a_069a, 3);  les(bx, memw[ss, bp - 4]);              /* les bx, [bp-0x4] */
            ii(0x1a_069d, 4);  cmp(memb[es, bx], 0x5c);                /* cmp byte [es:bx], 0x5c */
            ii(0x1a_06a1, 2);  if(jz(0x1a_06c1, 0x1e)) goto l_0x1a_06c1;/* jz 0x6c1 */
            ii(0x1a_06a3, 4);  cmp(memb[es, bx], 0x2f);                /* cmp byte [es:bx], 0x2f */
            ii(0x1a_06a7, 2);  if(jz(0x1a_06c1, 0x18)) goto l_0x1a_06c1;/* jz 0x6c1 */
            ii(0x1a_06a9, 4);  cmp(memb[es, bx], 0x3a);                /* cmp byte [es:bx], 0x3a */
            ii(0x1a_06ad, 2);  if(jz(0x1a_06c1, 0x12)) goto l_0x1a_06c1;/* jz 0x6c1 */
            ii(0x1a_06af, 4);  mov(memb[es, bx], 0);                   /* mov byte [es:bx], 0x0 */
        l_0x1a_06b3:
            ii(0x1a_06b3, 3);  mov(ax, memw[ss, bp - 4]);              /* mov ax, [bp-0x4] */
            ii(0x1a_06b6, 3);  mov(dx, memw[ss, bp - 2]);              /* mov dx, [bp-0x2] */
            ii(0x1a_06b9, 3);  dec(memw[ss, bp - 4]);                  /* dec word [bp-0x4] */
            ii(0x1a_06bc, 3);  cmp(memw[ss, bp + 4], ax);              /* cmp [bp+0x4], ax */
            ii(0x1a_06bf, 2);  if(jb(0x1a_069a, -0x27)) goto l_0x1a_069a;/* jb 0x69a */
        l_0x1a_06c1:
            ii(0x1a_06c1, 1);  leave();                                /* leave */
            ii(0x1a_06c2, 3);  ret(4);                                 /* ret 0x4 */
        }
    }
}
