using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0xaf9c-294ff348")]
        public void Method_0000_af9c()
        {
            ii(0xaf9c, 2);  mov(bp, sp);                               /* mov bp, sp */
            ii(0xaf9e, 3);  mov(di, memw[ss, bp + 2]);                 /* mov di, [bp+0x2] */
            ii(0xafa1, 4);  mov(ax, memw[cs, 0x208e]);                 /* mov ax, [cs:0x208e] */
            ii(0xafa5, 2);  mov(ds, ax);                               /* mov ds, ax */
            ii(0xafa7, 2);  mov(ss, ax);                               /* mov ss, ax */
            ii(0xafa9, 4);  mov(sp, memw[ds, 0xf50]);                  /* mov sp, [0xf50] */
            ii(0xafad, 1);  push(di);                                  /* push di */
            ii(0xafae, 5);  mov(dx, memw[cs, 0xf6f]);                  /* mov dx, [cs:0xf6f] */
            ii(0xafb3, 5);  mov(cx, memw[cs, 0xf71]);                  /* mov cx, [cs:0xf71] */
            ii(0xafb8, 3);  mov(ax, 0x304);                            /* mov ax, 0x304 */
            ii(0xafbb, 2);  @int(0x31);                                /* int 0x31 */
            ii(0xafbd, 2);  push(edx);                                 /* push edx */
            ii(0xafbf, 3);  xor(edx, edx);                             /* xor edx, edx */
            ii(0xafc2, 3);  mov(si, 0xf8a);                            /* mov si, 0xf8a */
            ii(0xafc5, 2);  mov(bl, 8);                                /* mov bl, 0x8 */
            ii(0xafc7, 3);  mov(ax, 0x201);                            /* mov ax, 0x201 */
        l_0xafca:
            ii(0xafca, 2);  mov(dx, memw[ds, si]);                     /* mov dx, [si] */
            ii(0xafcc, 3);  mov(cx, memw[ds, si + 2]);                 /* mov cx, [si+0x2] */
            ii(0xafcf, 2);  @int(0x31);                                /* int 0x31 */
            ii(0xafd1, 2);  inc(bl);                                   /* inc bl */
            ii(0xafd3, 3);  add(si, 4);                                /* add si, 0x4 */
            ii(0xafd6, 3);  cmp(bl, 0x2e);                             /* cmp bl, 0x2e */
            ii(0xafd9, 2);  if(jbe(0xafca, -0x11)) goto l_0xafca;      /* jbe 0xafca */
            ii(0xafdb, 2);  mov(bl, 0);                                /* mov bl, 0x0 */
        l_0xafdd:
            ii(0xafdd, 3);  mov(ax, 0x200);                            /* mov ax, 0x200 */
            ii(0xafe0, 2);  @int(0x31);                                /* int 0x31 */
            ii(0xafe2, 4);  cmp(cx, memw[ds, 0x9b6]);                  /* cmp cx, [0x9b6] */
            ii(0xafe6, 2);  if(jnz(0xaff5, 0xd)) goto l_0xaff5;        /* jnz 0xaff5 */
            ii(0xafe8, 4);  mov(dx, memw[ds, 0x56]);                   /* mov dx, [0x56] */
            ii(0xafec, 4);  mov(cx, memw[ds, 0x58]);                   /* mov cx, [0x58] */
            ii(0xaff0, 3);  mov(ax, 0x201);                            /* mov ax, 0x201 */
            ii(0xaff3, 2);  @int(0x31);                                /* int 0x31 */
        l_0xaff5:
            ii(0xaff5, 2);  inc(bl);                                   /* inc bl */
            ii(0xaff7, 2);  if(jnz(0xafdd, -0x1c)) goto l_0xafdd;      /* jnz 0xafdd */
            ii(0xaff9, 1);  push(ds);                                  /* push ds */
            ii(0xaffa, 1);  pop(es);                                   /* pop es */
            ii(0xaffb, 3);  mov(di, 0xc0);                             /* mov di, 0xc0 */
            ii(0xaffe, 1);  push(cs);                                  /* push cs */
            ii(0xafff, 3);  call(0xb3d9, 0x3d7);                       /* call 0xb3d9 */
            ii(0xb002, 4);  mov(es, memw[ds, 0xc4c]);                  /* mov es, [0xc4c] */
            ii(0xb006, 2);  xor(di, di);                               /* xor di, di */
            ii(0xb008, 1);  push(cs);                                  /* push cs */
            ii(0xb009, 3);  call(0xb366, 0x35a);                       /* call 0xb366 */
            ii(0xb00c, 2);  pop(edx);                                  /* pop edx */
            ii(0xb00e, 1);  pop(ax);                                   /* pop ax */
            ii(0xb00f, 2);  mov(ah, 0x4c);                             /* mov ah, 0x4c */
            ii(0xb011, 2);  @int(0x21);                                /* int 0x21 */
            ii(0xb013, 3);  cmp(ax, 0xbf02);                           /* cmp ax, 0xbf02 */
            ii(0xb016, 2);  if(jz(0xb02a, 0x12)) goto l_0xb02a;        /* jz 0xb02a */
            ii(0xb018, 3);  cmp(ax, 0xbfdc);                           /* cmp ax, 0xbfdc */
            ii(0xb01b, 2);  if(jz(0xb022, 5)) goto l_0xb022;           /* jz 0xb022 */
            ii(0xb01d, 5);  if(jmp_far_ind(memw[cs, 0x12c4])) return;  /* jmp far word [cs:0x12c4] */
        l_0xb022:
            ii(0xb022, 3);  mov(si, 0x98);                             /* mov si, 0x98 */
            ii(0xb025, 5);  mov(dx, memw[cs, 0]);                      /* mov dx, [cs:0x0] */
        l_0xb02a:
            ii(0xb02a, 1);  iretw();                                   /* iretw */
        }
    }
}
