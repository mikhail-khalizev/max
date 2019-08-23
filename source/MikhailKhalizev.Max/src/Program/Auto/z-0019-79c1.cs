using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x19_79c1-7783b140")]
        public void Method_0019_79c1()
        {
            ii(0x19_79c1, 4); enterw(0x34, 0);                          /* enter 0x34, 0x0 */
            ii(0x19_79c5, 1); pushw(di);                                /* push di */
            ii(0x19_79c6, 1); pushw(si);                                /* push si */
            ii(0x19_79c7, 2); sub(ax, ax);                              /* sub ax, ax */
            ii(0x19_79c9, 3); mov(memw_a16[ss, bp - 0x2e], ax);         /* mov [bp-0x2e], ax */
            ii(0x19_79cc, 3); mov(memw_a16[ss, bp - 0x30], ax);         /* mov [bp-0x30], ax */
            ii(0x19_79cf, 5); mov(memw_a16[ss, bp - 0x2c], 0);          /* mov word [bp-0x2c], 0x0 */
            ii(0x19_79d4, 4); mov(es, memw_a16[ds, 0x3f94]);            /* mov es, [0x3f94] */
            ii(0x19_79d8, 4); mov(ax, memw_a16[es, 0x3b84]);            /* mov ax, [es:0x3b84] */
            ii(0x19_79dc, 5); mov(memw_a16[ss, bp - 0x4], 0);           /* mov word [bp-0x4], 0x0 */
            ii(0x19_79e1, 3); mov(memw_a16[ss, bp - 0x2], ax);          /* mov [bp-0x2], ax */
            ii(0x19_79e4, 5); mov(memw_a16[ss, bp - 0xe], 0x1);         /* mov word [bp-0xe], 0x1 */
            ii(0x19_79e9, 3); mov(ax, memw_a16[ss, bp + 0x8]);          /* mov ax, [bp+0x8] */
            ii(0x19_79ec, 1); inc(ax);                                  /* inc ax */
            ii(0x19_79ed, 3); mov(memw_a16[ss, bp - 0x6], ax);          /* mov [bp-0x6], ax */
            ii(0x19_79f0, 2); xor(ax, ax);                              /* xor ax, ax */
            ii(0x19_79f2, 3); mov(cx, memw_a16[ss, bp - 0x6]);          /* mov cx, [bp-0x6] */
            ii(0x19_79f5, 2); @int(0x31);                               /* int 0x31 */
            ii(0x19_79f7, 2); if(jbw(0x19_79fc, 0x3)) goto l_0x19_79fc; /* jb 0x79fc */
            ii(0x19_79f9, 3); mov(memw_a16[ss, bp - 0x2c], ax);         /* mov [bp-0x2c], ax */
        l_0x19_79fc:
            ii(0x19_79fc, 4); cmp(memw_a16[ss, bp - 0x2c], 0);          /* cmp word [bp-0x2c], 0x0 */
            ii(0x19_7a00, 2); if(jzw(0x19_7a05, 0x3)) goto l_0x19_7a05; /* jz 0x7a05 */
            ii(0x19_7a02, 3); jmpw(0x19_7a0b, 0x6); goto l_0x19_7a0b;   /* jmp 0x7a0b */
        l_0x19_7a05:
            ii(0x19_7a05, 3); mov(ax, 0);                               /* mov ax, 0x0 */
            ii(0x19_7a08, 3); jmpw(0x19_7b34, 0x129); goto l_0x19_7b34; /* jmp 0x7b34 */
        l_0x19_7a0b:
            ii(0x19_7a0b, 3); mov(ax, 0x3);                             /* mov ax, 0x3 */
            ii(0x19_7a0e, 2); @int(0x31);                               /* int 0x31 */
            ii(0x19_7a10, 3); mov(memw_a16[ss, bp - 0x32], ax);         /* mov [bp-0x32], ax */
            ii(0x19_7a13, 4); cmp(memw_a16[ss, bp + 0x8], 0);           /* cmp word [bp+0x8], 0x0 */
            ii(0x19_7a17, 2); if(jbew(0x19_7a1c, 0x3)) goto l_0x19_7a1c; /* jbe 0x7a1c */
            ii(0x19_7a19, 3); jmpw(0x19_7a30, 0x14); goto l_0x19_7a30;  /* jmp 0x7a30 */
        l_0x19_7a1c:
            ii(0x19_7a1c, 5); cmp(memw_a16[ss, bp + 0x6], 0x1000);      /* cmp word [bp+0x6], 0x1000 */
            ii(0x19_7a21, 2); if(jbw(0x19_7a26, 0x3)) goto l_0x19_7a26; /* jb 0x7a26 */
            ii(0x19_7a23, 3); jmpw(0x19_7a30, 0xa); goto l_0x19_7a30;   /* jmp 0x7a30 */
        l_0x19_7a26:
            ii(0x19_7a26, 5); mov(memw_a16[ss, bp + 0x6], 0x1000);      /* mov word [bp+0x6], 0x1000 */
            ii(0x19_7a2b, 5); mov(memw_a16[ss, bp + 0x8], 0);           /* mov word [bp+0x8], 0x0 */
        l_0x19_7a30:
            ii(0x19_7a30, 5); cmp(memb_a16[ds, 0x1271], 0x6);           /* cmp byte [0x1271], 0x6 */
            ii(0x19_7a35, 2); if(jzw(0x19_7a3a, 0x3)) goto l_0x19_7a3a; /* jz 0x7a3a */
            ii(0x19_7a37, 3); jmpw(0x19_7a60, 0x26); goto l_0x19_7a60;  /* jmp 0x7a60 */
        l_0x19_7a3a:
            ii(0x19_7a3a, 4); or(memw_a16[ss, bp - 0xe], 0x4);          /* or word [bp-0xe], 0x4 */
            ii(0x19_7a3e, 1); pushw(di);                                /* push di */
            ii(0x19_7a3f, 1); pushw(si);                                /* push si */
            ii(0x19_7a40, 3); mov(ax, 0x501);                           /* mov ax, 0x501 */
            ii(0x19_7a43, 3); mov(bx, memw_a16[ss, bp + 0x8]);          /* mov bx, [bp+0x8] */
            ii(0x19_7a46, 3); mov(cx, memw_a16[ss, bp + 0x6]);          /* mov cx, [bp+0x6] */
            ii(0x19_7a49, 3); add(cx, -0x1 /* 0xff */);                 /* add cx, 0xffff */
            ii(0x19_7a4c, 3); adc(bx, 0);                               /* adc bx, 0x0 */
            ii(0x19_7a4f, 2); xor(cx, cx);                              /* xor cx, cx */
            ii(0x19_7a51, 2); @int(0x31);                               /* int 0x31 */
            ii(0x19_7a53, 1); popw(si);                                 /* pop si */
            ii(0x19_7a54, 1); popw(di);                                 /* pop di */
            ii(0x19_7a55, 2); if(jbw(0x19_7a5d, 0x6)) goto l_0x19_7a5d; /* jb 0x7a5d */
            ii(0x19_7a57, 3); mov(memw_a16[ss, bp - 0x2e], bx);         /* mov [bp-0x2e], bx */
            ii(0x19_7a5a, 3); mov(memw_a16[ss, bp - 0x30], cx);         /* mov [bp-0x30], cx */
        l_0x19_7a5d:
            ii(0x19_7a5d, 3); jmpw(0x19_7aa3, 0x43); goto l_0x19_7aa3;  /* jmp 0x7aa3 */
        l_0x19_7a60:
            ii(0x19_7a60, 5); cmp(memb_a16[ds, 0x1271], 0x7);           /* cmp byte [0x1271], 0x7 */
            ii(0x19_7a65, 2); if(jzw(0x19_7a6a, 0x3)) goto l_0x19_7a6a; /* jz 0x7a6a */
            ii(0x19_7a67, 3); jmpw(0x19_7aa3, 0x39); goto l_0x19_7aa3;  /* jmp 0x7aa3 */
        l_0x19_7a6a:
            ii(0x19_7a6a, 5); mov(memw_a16[ss, bp - 0x16], 0);          /* mov word [bp-0x16], 0x0 */
            ii(0x19_7a6f, 2); sub(ax, ax);                              /* sub ax, ax */
            ii(0x19_7a71, 3); mov(memw_a16[ss, bp - 0x18], ax);         /* mov [bp-0x18], ax */
            ii(0x19_7a74, 3); mov(memw_a16[ss, bp - 0x1a], ax);         /* mov [bp-0x1a], ax */
            ii(0x19_7a77, 2); sub(ax, ax);                              /* sub ax, ax */
            ii(0x19_7a79, 3); mov(memw_a16[ss, bp - 0x1c], ax);         /* mov [bp-0x1c], ax */
            ii(0x19_7a7c, 3); mov(memw_a16[ss, bp - 0x1e], ax);         /* mov [bp-0x1e], ax */
            ii(0x19_7a7f, 3); mov(ax, memw_a16[ss, bp + 0x6]);          /* mov ax, [bp+0x6] */
            ii(0x19_7a82, 3); mov(dx, memw_a16[ss, bp + 0x8]);          /* mov dx, [bp+0x8] */
            ii(0x19_7a85, 3); mov(memw_a16[ss, bp - 0x2a], ax);         /* mov [bp-0x2a], ax */
            ii(0x19_7a88, 3); mov(memw_a16[ss, bp - 0x28], dx);         /* mov [bp-0x28], dx */
            ii(0x19_7a8b, 3); mov(ax, 0xd00);                           /* mov ax, 0xd00 */
            ii(0x19_7a8e, 1); pushw(di);                                /* push di */
            ii(0x19_7a8f, 3); lea(di, bp - 0x2a);                       /* lea di, [bp-0x2a] */
            ii(0x19_7a92, 1); pushw(ss);                                /* push ss */
            ii(0x19_7a93, 1); popw(es);                                 /* pop es */
            ii(0x19_7a94, 2); @int(0x31);                               /* int 0x31 */
            ii(0x19_7a96, 1); popw(di);                                 /* pop di */
            ii(0x19_7a97, 3); mov(ax, memw_a16[ss, bp - 0x1e]);         /* mov ax, [bp-0x1e] */
            ii(0x19_7a9a, 3); mov(dx, memw_a16[ss, bp - 0x1c]);         /* mov dx, [bp-0x1c] */
            ii(0x19_7a9d, 3); mov(memw_a16[ss, bp - 0x30], ax);         /* mov [bp-0x30], ax */
            ii(0x19_7aa0, 3); mov(memw_a16[ss, bp - 0x2e], dx);         /* mov [bp-0x2e], dx */
        l_0x19_7aa3:
            ii(0x19_7aa3, 3); mov(ax, memw_a16[ss, bp - 0x2e]);         /* mov ax, [bp-0x2e] */
            ii(0x19_7aa6, 3); or(ax, memw_a16[ss, bp - 0x30]);          /* or ax, [bp-0x30] */
            ii(0x19_7aa9, 2); if(jzw(0x19_7aae, 0x3)) goto l_0x19_7aae; /* jz 0x7aae */
            ii(0x19_7aab, 3); jmpw(0x19_7ace, 0x20); goto l_0x19_7ace;  /* jmp 0x7ace */
        l_0x19_7aae:
            ii(0x19_7aae, 3); mov(ax, 0x1);                             /* mov ax, 0x1 */
            ii(0x19_7ab1, 3); mov(bx, memw_a16[ss, bp - 0x2c]);         /* mov bx, [bp-0x2c] */
            ii(0x19_7ab4, 2); @int(0x31);                               /* int 0x31 */
            ii(0x19_7ab6, 3); mov(ax, memw_a16[ss, bp - 0x32]);         /* mov ax, [bp-0x32] */
            ii(0x19_7ab9, 3); add(memw_a16[ss, bp - 0x2c], ax);         /* add [bp-0x2c], ax */
            ii(0x19_7abc, 3); dec(memw_a16[ss, bp - 0x6]);              /* dec word [bp-0x6] */
            ii(0x19_7abf, 4); cmp(memw_a16[ss, bp - 0x6], 0);           /* cmp word [bp-0x6], 0x0 */
            ii(0x19_7ac3, 2); if(jzw(0x19_7ac8, 0x3)) goto l_0x19_7ac8; /* jz 0x7ac8 */
            ii(0x19_7ac5, 3); jmpw(0x19_7aae, -0x1a); goto l_0x19_7aae; /* jmp 0x7aae */
        l_0x19_7ac8:
            ii(0x19_7ac8, 3); mov(ax, 0);                               /* mov ax, 0x0 */
            ii(0x19_7acb, 3); jmpw(0x19_7b34, 0x66); goto l_0x19_7b34;  /* jmp 0x7b34 */
        l_0x19_7ace:
            ii(0x19_7ace, 3); mov(ax, memw_a16[ss, bp - 0x2c]);         /* mov ax, [bp-0x2c] */
            ii(0x19_7ad1, 3); mov(memw_a16[ss, bp - 0x8], ax);          /* mov [bp-0x8], ax */
            ii(0x19_7ad4, 3); jmpw(0x19_7add, 0x6); goto l_0x19_7add;   /* jmp 0x7add */
        l_0x19_7ad7:
            ii(0x19_7ad7, 3); mov(ax, memw_a16[ss, bp - 0x32]);         /* mov ax, [bp-0x32] */
            ii(0x19_7ada, 3); add(memw_a16[ss, bp - 0x8], ax);          /* add [bp-0x8], ax */
        l_0x19_7add:
            ii(0x19_7add, 3); mov(ax, memw_a16[ss, bp - 0x6]);          /* mov ax, [bp-0x6] */
            ii(0x19_7ae0, 3); dec(memw_a16[ss, bp - 0x6]);              /* dec word [bp-0x6] */
            ii(0x19_7ae3, 3); cmp(ax, 0);                               /* cmp ax, 0x0 */
            ii(0x19_7ae6, 2); if(jnzw(0x19_7aeb, 0x3)) goto l_0x19_7aeb; /* jnz 0x7aeb */
            ii(0x19_7ae8, 3); jmpw(0x19_7b2e, 0x43); goto l_0x19_7b2e;  /* jmp 0x7b2e */
        l_0x19_7aeb:
            ii(0x19_7aeb, 3); mov(ax, 0x7);                             /* mov ax, 0x7 */
            ii(0x19_7aee, 3); mov(bx, memw_a16[ss, bp - 0x8]);          /* mov bx, [bp-0x8] */
            ii(0x19_7af1, 3); mov(cx, memw_a16[ss, bp - 0x2e]);         /* mov cx, [bp-0x2e] */
            ii(0x19_7af4, 3); mov(dx, memw_a16[ss, bp - 0x30]);         /* mov dx, [bp-0x30] */
            ii(0x19_7af7, 2); @int(0x31);                               /* int 0x31 */
            ii(0x19_7af9, 2); mov(al, 0x8);                             /* mov al, 0x8 */
            ii(0x19_7afb, 2); xor(cx, cx);                              /* xor cx, cx */
            ii(0x19_7afd, 3); mov(dx, memw_a16[ss, bp + 0x6]);          /* mov dx, [bp+0x6] */
            ii(0x19_7b00, 1); dec(dx);                                  /* dec dx */
            ii(0x19_7b01, 2); @int(0x31);                               /* int 0x31 */
            ii(0x19_7b03, 4); add(memw_a16[ss, bp - 0x30], 0);          /* add word [bp-0x30], 0x0 */
            ii(0x19_7b07, 4); adc(memw_a16[ss, bp - 0x2e], 0x1);        /* adc word [bp-0x2e], 0x1 */
            ii(0x19_7b0b, 4); sub(memw_a16[ss, bp + 0x6], 0);           /* sub word [bp+0x6], 0x0 */
            ii(0x19_7b0f, 4); sbb(memw_a16[ss, bp + 0x8], 0x1);         /* sbb word [bp+0x8], 0x1 */
            ii(0x19_7b13, 4); cmp(memw_a16[ss, bp - 0x6], 0x1);         /* cmp word [bp-0x6], 0x1 */
            ii(0x19_7b17, 1); cmc();                                    /* cmc */
            ii(0x19_7b18, 2); sbb(al, al);                              /* sbb al, al */
            ii(0x19_7b1a, 2); and(al, 0x2);                             /* and al, 0x2 */
            ii(0x19_7b1c, 3); or(al, memb_a16[ss, bp - 0xe]);           /* or al, [bp-0xe] */
            ii(0x19_7b1f, 3); mov(bx, memw_a16[ss, bp - 0x8]);          /* mov bx, [bp-0x8] */
            ii(0x19_7b22, 3); shr(bx, 0x3);                             /* shr bx, 0x3 */
            ii(0x19_7b25, 3); les(si, ss, bp - 0x4);                    /* les si, [bp-0x4] */
            ii(0x19_7b28, 3); mov(memb_a16[es, bx + si], al);           /* mov [es:bx+si], al */
            ii(0x19_7b2b, 3); jmpw(0x19_7ad7, -0x57); goto l_0x19_7ad7; /* jmp 0x7ad7 */
        l_0x19_7b2e:
            ii(0x19_7b2e, 3); mov(ax, memw_a16[ss, bp - 0x2c]);         /* mov ax, [bp-0x2c] */
            ii(0x19_7b31, 3); jmpw(0x19_7b34, 0); goto l_0x19_7b34;     /* jmp 0x7b34 */
        l_0x19_7b34:
            ii(0x19_7b34, 1); popw(si);                                 /* pop si */
            ii(0x19_7b35, 1); popw(di);                                 /* pop di */
            ii(0x19_7b36, 1); leavew();                                 /* leave */
            ii(0x19_7b37, 1); retfw();                                  /* retf */
        }
    }
}
