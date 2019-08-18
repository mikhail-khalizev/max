using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("2a4ea6ec-e39b-4075-affc-cb1434e21c0b")]
        public void Method_0019_7e4a()
        {
            ii(0x19_7e4a, 4); enterw(0xa, 0);                           /* enter 0xa, 0x0 */
            ii(0x19_7e4e, 1); pushw(di);                                /* push di */
            ii(0x19_7e4f, 1); pushw(si);                                /* push si */
            ii(0x19_7e50, 5); mov(memw_a16[ss, bp - 0x4], 0x332d);      /* mov word [bp-0x4], 0x332d */
            ii(0x19_7e55, 5); mov(memw_a16[ss, bp - 0x2], 0x88);        /* mov word [bp-0x2], 0x88 */
            ii(0x19_7e5a, 3); mov(ax, memw_a16[ss, bp - 0x4]);          /* mov ax, [bp-0x4] */
            ii(0x19_7e5d, 3); mov(memw_a16[ss, bp - 0xa], ax);          /* mov [bp-0xa], ax */
            ii(0x19_7e60, 5); mov(memw_a16[ss, bp - 0x8], 0);           /* mov word [bp-0x8], 0x0 */
            ii(0x19_7e65, 3); mov(ax, memw_a16[ss, bp - 0x2]);          /* mov ax, [bp-0x2] */
            ii(0x19_7e68, 3); mov(memw_a16[ss, bp - 0x6], ax);          /* mov [bp-0x6], ax */
            ii(0x19_7e6b, 3); mov(si, 0);                               /* mov si, 0x0 */
            ii(0x19_7e6e, 3); jmpw(0x19_7e72, 0x1); goto l_0x19_7e72;   /* jmp 0x7e72 */
        l_0x19_7e71:
            ii(0x19_7e71, 1); inc(si);                                  /* inc si */
        l_0x19_7e72:
            ii(0x19_7e72, 3); cmp(si, 0xe);                             /* cmp si, 0xe */
            ii(0x19_7e75, 2); if(jlew(0x19_7e7a, 0x3)) goto l_0x19_7e7a; /* jle 0x7e7a */
            ii(0x19_7e77, 3); jmpw(0x19_7e96, 0x1c); goto l_0x19_7e96;  /* jmp 0x7e96 */
        l_0x19_7e7a:
            ii(0x19_7e7a, 3); cmp(si, 0x2);                             /* cmp si, 0x2 */
            ii(0x19_7e7d, 2); if(jzw(0x19_7e82, 0x3)) goto l_0x19_7e82; /* jz 0x7e82 */
            ii(0x19_7e7f, 3); jmpw(0x19_7e85, 0x3); goto l_0x19_7e85;   /* jmp 0x7e85 */
        l_0x19_7e82:
            ii(0x19_7e82, 3); jmpw(0x19_7e71, -0x14); goto l_0x19_7e71; /* jmp 0x7e71 */
        l_0x19_7e85:
            ii(0x19_7e85, 3); lea(ax, bp - 0xa);                        /* lea ax, [bp-0xa] */
            ii(0x19_7e88, 1); pushw(ss);                                /* push ss */
            ii(0x19_7e89, 1); pushw(ax);                                /* push ax */
            ii(0x19_7e8a, 1); pushw(si);                                /* push si */
            ii(0x19_7e8b, 5); callw_far_abs(0x80, 0xb53);               /* call word 0x80:0xb53 */
            ii(0x19_7e90, 3); add(sp, 0x6);                             /* add sp, 0x6 */
            ii(0x19_7e93, 3); jmpw(0x19_7e71, -0x25); goto l_0x19_7e71; /* jmp 0x7e71 */
        l_0x19_7e96:
            ii(0x19_7e96, 3); mov(si, 0);                               /* mov si, 0x0 */
            ii(0x19_7e99, 3); jmpw(0x19_7e9d, 0x1); goto l_0x19_7e9d;   /* jmp 0x7e9d */
        l_0x19_7e9c:
            ii(0x19_7e9c, 1); inc(si);                                  /* inc si */
        l_0x19_7e9d:
            ii(0x19_7e9d, 3); cmp(si, 0x3);                             /* cmp si, 0x3 */
            ii(0x19_7ea0, 2); if(jlw(0x19_7ea5, 0x3)) goto l_0x19_7ea5; /* jl 0x7ea5 */
            ii(0x19_7ea2, 3); jmpw(0x19_7ebc, 0x17); goto l_0x19_7ebc;  /* jmp 0x7ebc */
        l_0x19_7ea5:
            ii(0x19_7ea5, 3); lea(ax, bp - 0xa);                        /* lea ax, [bp-0xa] */
            ii(0x19_7ea8, 1); pushw(ss);                                /* push ss */
            ii(0x19_7ea9, 1); pushw(ax);                                /* push ax */
            ii(0x19_7eaa, 4); mov(al, memb_a16[ds, si + 0x1668]);       /* mov al, [si+0x1668] */
            ii(0x19_7eae, 2); sub(ah, ah);                              /* sub ah, ah */
            ii(0x19_7eb0, 1); pushw(ax);                                /* push ax */
            ii(0x19_7eb1, 5); callw_far_abs(0x80, 0xb38);               /* call word 0x80:0xb38 */
            ii(0x19_7eb6, 3); add(sp, 0x6);                             /* add sp, 0x6 */
            ii(0x19_7eb9, 3); jmpw(0x19_7e9c, -0x20); goto l_0x19_7e9c; /* jmp 0x7e9c */
        l_0x19_7ebc:
            ii(0x19_7ebc, 3); pushw(0x88);                              /* push 0x88 */
            ii(0x19_7ebf, 3); pushw(0x2aaf);                            /* push 0x2aaf */
            ii(0x19_7ec2, 3); pushw(0x88);                              /* push 0x88 */
            ii(0x19_7ec5, 3); pushw(0x3508);                            /* push 0x3508 */
            ii(0x19_7ec8, 3); callw(0x19_fbdb, 0x7d10);                 /* call 0xfbdb */
            ii(0x19_7ecb, 1); popw(si);                                 /* pop si */
            ii(0x19_7ecc, 1); popw(di);                                 /* pop di */
            ii(0x19_7ecd, 1); leavew();                                 /* leave */
            ii(0x19_7ece, 1); retfw(); return;                          /* retf */
        }
    }
}
