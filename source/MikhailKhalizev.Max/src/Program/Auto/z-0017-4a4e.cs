using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x17_4a4e-efb06b58")]
        public void Method_0017_4a4e()
        {
            ii(0x17_4a4e, 4); enterw(0x2, 0);                           /* enter 0x2, 0x0 */
            ii(0x17_4a52, 1); pushw(si);                                /* push si */
            ii(0x17_4a53, 1); pushw(ds);                                /* push ds */
            ii(0x17_4a54, 3); mov(ax, 0x3e68);                          /* mov ax, 0x3e68 */
            ii(0x17_4a57, 2); mov(ds, ax);                              /* mov ds, ax */
            ii(0x17_4a59, 3); mov(si, memw_a16[ss, bp + 0x6]);          /* mov si, [bp+0x6] */
            ii(0x17_4a5c, 1); pushw(si);                                /* push si */
            ii(0x17_4a5d, 1); nop();                                    /* nop */
            ii(0x17_4a5e, 1); pushw(cs);                                /* push cs */
            ii(0x17_4a5f, 3); callw(0x16_db16, -0x6f4c);                /* call 0xdb16 */
            ii(0x17_4a62, 3); add(sp, 0x2);                             /* add sp, 0x2 */
            ii(0x17_4a65, 3); mov(memw_a16[ss, bp - 0x2], ax);          /* mov [bp-0x2], ax */
            ii(0x17_4a68, 2); or(ax, ax);                               /* or ax, ax */
            ii(0x17_4a6a, 2); if(jzw(0x17_4a74, 0x8)) goto l_0x17_4a74; /* jz 0x4a74 */
            ii(0x17_4a6c, 2); mov(bx, ax);                              /* mov bx, ax */
            ii(0x17_4a6e, 4); cmp(memb_a16[ds, bx + si - 0x1], 0x5c);   /* cmp byte [bx+si-0x1], 0x5c */
            ii(0x17_4a72, 2); if(jzw(0x17_4a80, 0xc)) goto l_0x17_4a80; /* jz 0x4a80 */
        l_0x17_4a74:
            ii(0x17_4a74, 3); pushw(0xda);                              /* push 0xda */
            ii(0x17_4a77, 1); pushw(si);                                /* push si */
            ii(0x17_4a78, 1); nop();                                    /* nop */
            ii(0x17_4a79, 1); pushw(cs);                                /* push cs */
            ii(0x17_4a7a, 3); callw(0x16_dad6, -0x6fa7);                /* call 0xdad6 */
            ii(0x17_4a7d, 3); add(sp, 0x4);                             /* add sp, 0x4 */
        l_0x17_4a80:
            ii(0x17_4a80, 5); cmp(memb_a16[ds, 0x39], 0);               /* cmp byte [0x39], 0x0 */
            ii(0x17_4a85, 2); if(jzw(0x17_4aa0, 0x19)) goto l_0x17_4aa0; /* jz 0x4aa0 */
            ii(0x17_4a87, 1); pushw(ds);                                /* push ds */
            ii(0x17_4a88, 1); pushw(si);                                /* push si */
            ii(0x17_4a89, 1); nop();                                    /* nop */
            ii(0x17_4a8a, 1); pushw(cs);                                /* push cs */
            ii(0x17_4a8b, 3); callw(0x17_90f0, 0x4662);                 /* call 0x90f0 */
            ii(0x17_4a8e, 3); add(sp, 0x4);                             /* add sp, 0x4 */
            ii(0x17_4a91, 2); or(ax, ax);                               /* or ax, ax */
            ii(0x17_4a93, 2); if(jzw(0x17_4a9e, 0x9)) goto l_0x17_4a9e; /* jz 0x4a9e */
            ii(0x17_4a95, 3); mov(memb_a16[ds, si], 0);                 /* mov byte [si], 0x0 */
            ii(0x17_4a98, 2); sub(ax, ax);                              /* sub ax, ax */
            ii(0x17_4a9a, 1); popw(ds);                                 /* pop ds */
            ii(0x17_4a9b, 1); popw(si);                                 /* pop si */
            ii(0x17_4a9c, 1); leavew();                                 /* leave */
            ii(0x17_4a9d, 1); retfw(); return;                          /* retf */
        l_0x17_4a9e:
            ii(0x17_4a9e, 2); jmpw(0x17_4aac, 0xc); goto l_0x17_4aac;   /* jmp 0x4aac */
        l_0x17_4aa0:
            ii(0x17_4aa0, 3); pushw(0xdc);                              /* push 0xdc */
            ii(0x17_4aa3, 1); pushw(si);                                /* push si */
            ii(0x17_4aa4, 1); nop();                                    /* nop */
            ii(0x17_4aa5, 1); pushw(cs);                                /* push cs */
            ii(0x17_4aa6, 3); callw(0x16_dad6, -0x6fd3);                /* call 0xdad6 */
            ii(0x17_4aa9, 3); add(sp, 0x4);                             /* add sp, 0x4 */
        l_0x17_4aac:
            ii(0x17_4aac, 3); pushw(0xe4);                              /* push 0xe4 */
            ii(0x17_4aaf, 1); pushw(si);                                /* push si */
            ii(0x17_4ab0, 1); nop();                                    /* nop */
            ii(0x17_4ab1, 1); pushw(cs);                                /* push cs */
            ii(0x17_4ab2, 3); callw(0x16_dad6, -0x6fdf);                /* call 0xdad6 */
            ii(0x17_4ab5, 3); add(sp, 0x4);                             /* add sp, 0x4 */
            ii(0x17_4ab8, 3); mov(ax, 0x1);                             /* mov ax, 0x1 */
            ii(0x17_4abb, 1); popw(ds);                                 /* pop ds */
            ii(0x17_4abc, 1); popw(si);                                 /* pop si */
            ii(0x17_4abd, 1); leavew();                                 /* leave */
            ii(0x17_4abe, 1); retfw();                                  /* retf */
        }
    }
}
