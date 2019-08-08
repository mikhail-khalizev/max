using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("c95d2aab-0bb9-4323-a08d-cb869789a223")]
        public void Method_0013_e368()
        {
            ii(0x13_e368, 1); pushw(cx);                                /* push cx */
            ii(0x13_e369, 1); pushw(di);                                /* push di */
            ii(0x13_e36a, 4); test(memb_a16[ds, bx + 0x2], 0x1);        /* test byte [bx+0x2], 0x1 */
            ii(0x13_e36e, 2); if(jzw(0x13_e3d3, 0x63)) goto l_0x13_e3d3; /* jz 0xe3d3 */
            ii(0x13_e370, 3); callw(0x13_e445, 0xd2);                   /* call 0xe445 */
            ii(0x13_e373, 2); mov(di, si);                              /* mov di, si */
            ii(0x13_e375, 2); mov(ax, memw_a16[ds, si]);                /* mov ax, [si] */
            ii(0x13_e377, 2); test(al, 0x1);                            /* test al, 0x1 */
            ii(0x13_e379, 2); if(jzw(0x13_e37e, 0x3)) goto l_0x13_e37e; /* jz 0xe37e */
            ii(0x13_e37b, 2); sub(cx, ax);                              /* sub cx, ax */
            ii(0x13_e37d, 1); dec(cx);                                  /* dec cx */
        l_0x13_e37e:
            ii(0x13_e37e, 1); inc(cx);                                  /* inc cx */
            ii(0x13_e37f, 1); inc(cx);                                  /* inc cx */
            ii(0x13_e380, 3); mov(si, memw_a16[ds, bx + 0x4]);          /* mov si, [bx+0x4] */
            ii(0x13_e383, 2); or(si, si);                               /* or si, si */
            ii(0x13_e385, 2); if(jzw(0x13_e3d3, 0x4c)) goto l_0x13_e3d3; /* jz 0xe3d3 */
            ii(0x13_e387, 2); add(cx, si);                              /* add cx, si */
            ii(0x13_e389, 2); if(jaew(0x13_e394, 0x9)) goto l_0x13_e394; /* jae 0xe394 */
            ii(0x13_e38b, 2); xor(ax, ax);                              /* xor ax, ax */
            ii(0x13_e38d, 3); mov(dx, 0xfff0);                          /* mov dx, 0xfff0 */
            ii(0x13_e390, 2); if(jcxzw(0x13_e3c2, 0x30)) goto l_0x13_e3c2; /* jcxz 0xe3c2 */
            ii(0x13_e392, 2); jmpw(0x13_e3d3, 0x3f); goto l_0x13_e3d3;  /* jmp 0xe3d3 */
        l_0x13_e394:
            ii(0x13_e394, 1); pushw(ss);                                /* push ss */
            ii(0x13_e395, 1); popw(es);                                 /* pop es */
            ii(0x13_e396, 4); mov(ax, memw_a16[es, 0x1da8]);            /* mov ax, [es:0x1da8] */
            ii(0x13_e39a, 3); cmp(ax, 0x2000);                          /* cmp ax, 0x2000 */
            ii(0x13_e39d, 2); if(jzw(0x13_e3b5, 0x16)) goto l_0x13_e3b5; /* jz 0xe3b5 */
            ii(0x13_e39f, 3); mov(dx, 0x8000);                          /* mov dx, 0x8000 */
        l_0x13_e3a2:
            ii(0x13_e3a2, 2); cmp(dx, ax);                              /* cmp dx, ax */
            ii(0x13_e3a4, 2); if(jbw(0x13_e3ac, 0x6)) goto l_0x13_e3ac; /* jb 0xe3ac */
            ii(0x13_e3a6, 2); shr(dx, 0x1);                             /* shr dx, 1 */
            ii(0x13_e3a8, 2); if(jnzw(0x13_e3a2, -0x8)) goto l_0x13_e3a2; /* jnz 0xe3a2 */
            ii(0x13_e3aa, 2); jmpw(0x13_e3ce, 0x22); goto l_0x13_e3ce;  /* jmp 0xe3ce */
        l_0x13_e3ac:
            ii(0x13_e3ac, 3); cmp(dx, 0x8);                             /* cmp dx, 0x8 */
            ii(0x13_e3af, 2); if(jbw(0x13_e3ce, 0x1d)) goto l_0x13_e3ce; /* jb 0xe3ce */
            ii(0x13_e3b1, 2); shl(dx, 0x1);                             /* shl dx, 1 */
            ii(0x13_e3b3, 2); mov(ax, dx);                              /* mov ax, dx */
        l_0x13_e3b5:
            ii(0x13_e3b5, 1); dec(ax);                                  /* dec ax */
            ii(0x13_e3b6, 2); mov(dx, ax);                              /* mov dx, ax */
            ii(0x13_e3b8, 2); add(ax, cx);                              /* add ax, cx */
            ii(0x13_e3ba, 2); if(jaew(0x13_e3be, 0x2)) goto l_0x13_e3be; /* jae 0xe3be */
            ii(0x13_e3bc, 2); xor(ax, ax);                              /* xor ax, ax */
        l_0x13_e3be:
            ii(0x13_e3be, 2); not(dx);                                  /* not dx */
            ii(0x13_e3c0, 2); and(ax, dx);                              /* and ax, dx */
        l_0x13_e3c2:
            ii(0x13_e3c2, 1); pushw(dx);                                /* push dx */
            ii(0x13_e3c3, 3); callw(0x13_e3f4, 0x2e);                   /* call 0xe3f4 */
            ii(0x13_e3c6, 1); popw(dx);                                 /* pop dx */
            ii(0x13_e3c7, 2); if(jaew(0x13_e3d6, 0xd)) goto l_0x13_e3d6; /* jae 0xe3d6 */
            ii(0x13_e3c9, 3); cmp(dx, -0x10 /* 0xf0 */);                /* cmp dx, 0xfff0 */
            ii(0x13_e3cc, 2); if(jzw(0x13_e3d3, 0x5)) goto l_0x13_e3d3; /* jz 0xe3d3 */
        l_0x13_e3ce:
            ii(0x13_e3ce, 3); mov(ax, 0x10);                            /* mov ax, 0x10 */
            ii(0x13_e3d1, 2); jmpw(0x13_e3b5, -0x1e); goto l_0x13_e3b5; /* jmp 0xe3b5 */
        l_0x13_e3d3:
            ii(0x13_e3d3, 1); stc();                                    /* stc */
            ii(0x13_e3d4, 2); jmpw(0x13_e3f1, 0x1b); goto l_0x13_e3f1;  /* jmp 0xe3f1 */
        l_0x13_e3d6:
            ii(0x13_e3d6, 2); mov(dx, ax);                              /* mov dx, ax */
            ii(0x13_e3d8, 3); sub(dx, memw_a16[ds, bx + 0x4]);          /* sub dx, [bx+0x4] */
            ii(0x13_e3db, 3); mov(memw_a16[ds, bx + 0x4], ax);          /* mov [bx+0x4], ax */
            ii(0x13_e3de, 3); mov(memw_a16[ds, bx + 0x8], di);          /* mov [bx+0x8], di */
            ii(0x13_e3e1, 3); mov(si, memw_a16[ds, bx + 0xa]);          /* mov si, [bx+0xa] */
            ii(0x13_e3e4, 1); dec(dx);                                  /* dec dx */
            ii(0x13_e3e5, 2); mov(memw_a16[ds, si], dx);                /* mov [si], dx */
            ii(0x13_e3e7, 1); inc(dx);                                  /* inc dx */
            ii(0x13_e3e8, 2); add(si, dx);                              /* add si, dx */
            ii(0x13_e3ea, 4); mov(memw_a16[ds, si], 0xfffe);            /* mov word [si], 0xfffe */
            ii(0x13_e3ee, 3); mov(memw_a16[ds, bx + 0xa], si);          /* mov [bx+0xa], si */
        l_0x13_e3f1:
            ii(0x13_e3f1, 1); popw(di);                                 /* pop di */
            ii(0x13_e3f2, 1); popw(cx);                                 /* pop cx */
            ii(0x13_e3f3, 1); retw(); return;                           /* ret */
        }
    }
}
