using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1014_a0f1-208e1b81")]
        public void Method_1014_a0f1()
        {
            ii(0x1014_a0f1, 5); push(0x2c);                             /* push 0x2c */
            ii(0x1014_a0f6, 5); call(Definitions.sys_check_available_stack_size, 0x1_bc57); /* call 0x10165d52 */
            ii(0x1014_a0fb, 1); push(ebx);                              /* push ebx */
            ii(0x1014_a0fc, 1); push(ecx);                              /* push ecx */
            ii(0x1014_a0fd, 1); push(edx);                              /* push edx */
            ii(0x1014_a0fe, 1); push(esi);                              /* push esi */
            ii(0x1014_a0ff, 1); push(edi);                              /* push edi */
            ii(0x1014_a100, 1); push(ebp);                              /* push ebp */
            ii(0x1014_a101, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1014_a103, 6); sub(esp, 0x10);                         /* sub esp, 0x10 */
            ii(0x1014_a109, 3); mov(memd[ss, ebp - 4], eax);            /* mov [ebp-0x4], eax */
            ii(0x1014_a10c, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1014_a10f, 3); mov(memd[ss, ebp - 0xc], eax);          /* mov [ebp-0xc], eax */
            ii(0x1014_a112, 2); jmp(0x1014_a14a, 0x36); goto l_0x1014_a14a; /* jmp 0x1014a14a */
        l_0x1014_a114:
            ii(0x1014_a114, 4); mov(memb[ss, ebp - 8], 1);              /* mov byte [ebp-0x8], 0x1 */
            ii(0x1014_a118, 5); jmp(0x1014_a1f9, 0xdc); goto l_0x1014_a1f9; /* jmp 0x1014a1f9 */
        l_0x1014_a11d:
            ii(0x1014_a11d, 4); mov(memb[ss, ebp - 8], 2);              /* mov byte [ebp-0x8], 0x2 */
            ii(0x1014_a121, 5); jmp(0x1014_a1f9, 0xd3); goto l_0x1014_a1f9; /* jmp 0x1014a1f9 */
        l_0x1014_a126:
            ii(0x1014_a126, 4); mov(memb[ss, ebp - 8], 3);              /* mov byte [ebp-0x8], 0x3 */
            ii(0x1014_a12a, 5); jmp(0x1014_a1f9, 0xca); goto l_0x1014_a1f9; /* jmp 0x1014a1f9 */
        l_0x1014_a12f:
            ii(0x1014_a12f, 4); mov(memb[ss, ebp - 8], 4);              /* mov byte [ebp-0x8], 0x4 */
            ii(0x1014_a133, 5); jmp(0x1014_a1f9, 0xc1); goto l_0x1014_a1f9; /* jmp 0x1014a1f9 */
        l_0x1014_a138:
            ii(0x1014_a138, 4); mov(memb[ss, ebp - 8], 5);              /* mov byte [ebp-0x8], 0x5 */
            ii(0x1014_a13c, 5); jmp(0x1014_a1f9, 0xb8); goto l_0x1014_a1f9; /* jmp 0x1014a1f9 */
        l_0x1014_a141:
            ii(0x1014_a141, 4); mov(memb[ss, ebp - 8], 6);              /* mov byte [ebp-0x8], 0x6 */
            ii(0x1014_a145, 5); jmp(0x1014_a1f9, 0xaf); goto l_0x1014_a1f9; /* jmp 0x1014a1f9 */
        l_0x1014_a14a:
            ii(0x1014_a14a, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x1014_a14d, 3); mov(memd[ss, ebp - 0x10], eax);         /* mov [ebp-0x10], eax */
            ii(0x1014_a150, 5); cmp(memw[ss, ebp - 0x10], 0x21);        /* cmp word [ebp-0x10], 0x21 */
            ii(0x1014_a155, 6); if(jb(0x1014_a1ab, 0x50)) goto l_0x1014_a1ab; /* jb 0x1014a1ab */
            ii(0x1014_a15b, 5); cmp(memw[ss, ebp - 0x10], 0x21);        /* cmp word [ebp-0x10], 0x21 */
            ii(0x1014_a160, 2); if(jbe(0x1014_a11d, -0x45)) goto l_0x1014_a11d; /* jbe 0x1014a11d */
            ii(0x1014_a162, 5); cmp(memw[ss, ebp - 0x10], 0x55);        /* cmp word [ebp-0x10], 0x55 */
            ii(0x1014_a167, 2); if(jb(0x1014_a189, 0x20)) goto l_0x1014_a189; /* jb 0x1014a189 */
            ii(0x1014_a169, 5); cmp(memw[ss, ebp - 0x10], 0x55);        /* cmp word [ebp-0x10], 0x55 */
            ii(0x1014_a16e, 2); if(jbe(0x1014_a114, -0x5c)) goto l_0x1014_a114; /* jbe 0x1014a114 */
            ii(0x1014_a170, 5); cmp(memw[ss, ebp - 0x10], 0x5a);        /* cmp word [ebp-0x10], 0x5a */
            ii(0x1014_a175, 2); if(jb(0x1014_a187, 0x10)) goto l_0x1014_a187; /* jb 0x1014a187 */
            ii(0x1014_a177, 5); cmp(memw[ss, ebp - 0x10], 0x5a);        /* cmp word [ebp-0x10], 0x5a */
            ii(0x1014_a17c, 2); if(jbe(0x1014_a114, -0x6a)) goto l_0x1014_a114; /* jbe 0x1014a114 */
            ii(0x1014_a17e, 5); cmp(memw[ss, ebp - 0x10], 0x5c);        /* cmp word [ebp-0x10], 0x5c */
            ii(0x1014_a183, 2); if(jz(0x1014_a126, -0x5f)) goto l_0x1014_a126; /* jz 0x1014a126 */
            ii(0x1014_a185, 2); jmp(0x1014_a141, -0x46); goto l_0x1014_a141; /* jmp 0x1014a141 */
        l_0x1014_a187:
            ii(0x1014_a187, 2); jmp(0x1014_a141, -0x48); goto l_0x1014_a141; /* jmp 0x1014a141 */
        l_0x1014_a189:
            ii(0x1014_a189, 5); cmp(memw[ss, ebp - 0x10], 0x27);        /* cmp word [ebp-0x10], 0x27 */
            ii(0x1014_a18e, 2); if(jb(0x1014_a1a9, 0x19)) goto l_0x1014_a1a9; /* jb 0x1014a1a9 */
            ii(0x1014_a190, 5); cmp(memw[ss, ebp - 0x10], 0x27);        /* cmp word [ebp-0x10], 0x27 */
            ii(0x1014_a195, 2); if(jbe(0x1014_a126, -0x71)) goto l_0x1014_a126; /* jbe 0x1014a126 */
            ii(0x1014_a197, 5); cmp(memw[ss, ebp - 0x10], 0x29);        /* cmp word [ebp-0x10], 0x29 */
            ii(0x1014_a19c, 2); if(jb(0x1014_a1a7, 9)) goto l_0x1014_a1a7; /* jb 0x1014a1a7 */
            ii(0x1014_a19e, 5); cmp(memw[ss, ebp - 0x10], 0x2a);        /* cmp word [ebp-0x10], 0x2a */
            ii(0x1014_a1a3, 2); if(jbe(0x1014_a138, -0x6d)) goto l_0x1014_a138; /* jbe 0x1014a138 */
            ii(0x1014_a1a5, 2); jmp(0x1014_a141, -0x66); goto l_0x1014_a141; /* jmp 0x1014a141 */
        l_0x1014_a1a7:
            ii(0x1014_a1a7, 2); jmp(0x1014_a141, -0x68); goto l_0x1014_a141; /* jmp 0x1014a141 */
        l_0x1014_a1a9:
            ii(0x1014_a1a9, 2); jmp(0x1014_a141, -0x6a); goto l_0x1014_a141; /* jmp 0x1014a141 */
        l_0x1014_a1ab:
            ii(0x1014_a1ab, 5); cmp(memw[ss, ebp - 0x10], 0x11);        /* cmp word [ebp-0x10], 0x11 */
            ii(0x1014_a1b0, 2); if(jb(0x1014_a1dd, 0x2b)) goto l_0x1014_a1dd; /* jb 0x1014a1dd */
            ii(0x1014_a1b2, 5); cmp(memw[ss, ebp - 0x10], 0x12);        /* cmp word [ebp-0x10], 0x12 */
            ii(0x1014_a1b7, 6); if(jbe(0x1014_a126, -0x97)) goto l_0x1014_a126; /* jbe 0x1014a126 */
            ii(0x1014_a1bd, 5); cmp(memw[ss, ebp - 0x10], 0x14);        /* cmp word [ebp-0x10], 0x14 */
            ii(0x1014_a1c2, 6); if(jbe(0x1014_a141, -0x87)) goto l_0x1014_a141; /* jbe 0x1014a141 */
            ii(0x1014_a1c8, 5); cmp(memw[ss, ebp - 0x10], 0x15);        /* cmp word [ebp-0x10], 0x15 */
            ii(0x1014_a1cd, 6); if(jz(0x1014_a126, -0xad)) goto l_0x1014_a126; /* jz 0x1014a126 */
            ii(0x1014_a1d3, 5); jmp(0x1014_a141, -0x97); goto l_0x1014_a141; /* jmp 0x1014a141 */
        //  ii(0x1014_a1d8, 5); jmp(0x1014_a141, -0x9c); goto l_0x1014_a141; /* jmp 0x1014a141 */
        l_0x1014_a1dd:
            ii(0x1014_a1dd, 5); cmp(memw[ss, ebp - 0x10], 0xd);         /* cmp word [ebp-0x10], 0xd */
            ii(0x1014_a1e2, 2); if(jb(0x1014_a1f4, 0x10)) goto l_0x1014_a1f4; /* jb 0x1014a1f4 */
            ii(0x1014_a1e4, 5); cmp(memw[ss, ebp - 0x10], 0xe);         /* cmp word [ebp-0x10], 0xe */
            ii(0x1014_a1e9, 6); if(jbe(0x1014_a12f, -0xc0)) goto l_0x1014_a12f; /* jbe 0x1014a12f */
            ii(0x1014_a1ef, 5); jmp(0x1014_a141, -0xb3); goto l_0x1014_a141; /* jmp 0x1014a141 */
        l_0x1014_a1f4:
            ii(0x1014_a1f4, 5); jmp(0x1014_a141, -0xb8); goto l_0x1014_a141; /* jmp 0x1014a141 */
        l_0x1014_a1f9:
            ii(0x1014_a1f9, 3); mov(al, memb[ss, ebp - 8]);             /* mov al, [ebp-0x8] */
            ii(0x1014_a1fc, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1014_a1fe, 1); pop(ebp);                               /* pop ebp */
            ii(0x1014_a1ff, 1); pop(edi);                               /* pop edi */
            ii(0x1014_a200, 1); pop(esi);                               /* pop esi */
            ii(0x1014_a201, 1); pop(edx);                               /* pop edx */
            ii(0x1014_a202, 1); pop(ecx);                               /* pop ecx */
            ii(0x1014_a203, 1); pop(ebx);                               /* pop ebx */
            ii(0x1014_a204, 1); ret();                                  /* ret */
        }
    }
}
