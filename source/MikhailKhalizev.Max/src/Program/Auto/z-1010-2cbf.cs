using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1010_2cbf-ccb9c940")]
        public void Method_1010_2cbf()
        {
            ii(0x1010_2cbf, 5); push(0x28);                             /* push 0x28 */
            ii(0x1010_2cc4, 5); call(Definitions.sys_check_available_stack_size, 0x6_3089); /* call 0x10165d52 */
            ii(0x1010_2cc9, 1); push(ebx);                              /* push ebx */
            ii(0x1010_2cca, 1); push(ecx);                              /* push ecx */
            ii(0x1010_2ccb, 1); push(esi);                              /* push esi */
            ii(0x1010_2ccc, 1); push(edi);                              /* push edi */
            ii(0x1010_2ccd, 1); push(ebp);                              /* push ebp */
            ii(0x1010_2cce, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1010_2cd0, 6); sub(esp, 0x10);                         /* sub esp, 0x10 */
            ii(0x1010_2cd6, 3); mov(memd[ss, ebp - 0x8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1010_2cd9, 3); mov(memd[ss, ebp - 0x4], edx);          /* mov [ebp-0x4], edx */
            ii(0x1010_2cdc, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1010_2cdf, 5); call(0x1013_a6f4, 0x3_7a10);            /* call 0x1013a6f4 */
            ii(0x1010_2ce4, 3); lea(edx, ebp - 0xc);                    /* lea edx, [ebp-0xc] */
            ii(0x1010_2ce7, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1010_2cea, 5); call(0x1013_bb7b, 0x3_8e8c);            /* call 0x1013bb7b */
        l_0x1010_2cef:
            ii(0x1010_2cef, 3); dec(memd[ss, ebp - 0xc]);               /* dec dword [ebp-0xc] */
            ii(0x1010_2cf2, 5); cmp(memw[ss, ebp - 0xc], -0x1 /* 0xff */); /* cmp word [ebp-0xc], 0xffff */
            ii(0x1010_2cf7, 6); if(jz(0x1010_2d87, 0x8a)) goto l_0x1010_2d87; /* jz 0x10102d87 */
            ii(0x1010_2cfd, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1010_2d00, 5); call(0x1013_bc8c, 0x3_8f87);            /* call 0x1013bc8c */
            ii(0x1010_2d05, 3); mov(memd[ss, ebp - 0x10], eax);         /* mov [ebp-0x10], eax */
            ii(0x1010_2d08, 3); mov(edx, memd[ss, ebp - 0x10]);         /* mov edx, [ebp-0x10] */
            ii(0x1010_2d0b, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1010_2d0e, 5); call(0x1008_ab1c, -0x7_81f7);           /* call 0x1008ab1c */
            ii(0x1010_2d13, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x1010_2d16, 4); test(memb[ds, eax + 0x13], 0x20);       /* test byte [eax+0x13], 0x20 */
            ii(0x1010_2d1a, 2); if(jz(0x1010_2d2a, 0xe)) goto l_0x1010_2d2a; /* jz 0x10102d2a */
            ii(0x1010_2d1c, 6); mov(edx, memd[ds, 0x101c_70a0]);        /* mov edx, [0x101c70a0] */
            ii(0x1010_2d22, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x1010_2d25, 3); mov(memd[ds, eax + 0x22], edx);         /* mov [eax+0x22], edx */
            ii(0x1010_2d28, 2); jmp(0x1010_2d7b, 0x51); goto l_0x1010_2d7b; /* jmp 0x10102d7b */
        l_0x1010_2d2a:
            ii(0x1010_2d2a, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x1010_2d2d, 4); test(memb[ds, eax + 0x13], 0x10);       /* test byte [eax+0x13], 0x10 */
            ii(0x1010_2d31, 2); if(jz(0x1010_2d41, 0xe)) goto l_0x1010_2d41; /* jz 0x10102d41 */
            ii(0x1010_2d33, 6); mov(edx, memd[ds, 0x101c_70a4]);        /* mov edx, [0x101c70a4] */
            ii(0x1010_2d39, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x1010_2d3c, 3); mov(memd[ds, eax + 0x22], edx);         /* mov [eax+0x22], edx */
            ii(0x1010_2d3f, 2); jmp(0x1010_2d7b, 0x3a); goto l_0x1010_2d7b; /* jmp 0x10102d7b */
        l_0x1010_2d41:
            ii(0x1010_2d41, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x1010_2d44, 4); test(memb[ds, eax + 0x13], 0x8);        /* test byte [eax+0x13], 0x8 */
            ii(0x1010_2d48, 2); if(jz(0x1010_2d58, 0xe)) goto l_0x1010_2d58; /* jz 0x10102d58 */
            ii(0x1010_2d4a, 6); mov(edx, memd[ds, 0x101c_70a8]);        /* mov edx, [0x101c70a8] */
            ii(0x1010_2d50, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x1010_2d53, 3); mov(memd[ds, eax + 0x22], edx);         /* mov [eax+0x22], edx */
            ii(0x1010_2d56, 2); jmp(0x1010_2d7b, 0x23); goto l_0x1010_2d7b; /* jmp 0x10102d7b */
        l_0x1010_2d58:
            ii(0x1010_2d58, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x1010_2d5b, 4); test(memb[ds, eax + 0x13], 0x4);        /* test byte [eax+0x13], 0x4 */
            ii(0x1010_2d5f, 2); if(jz(0x1010_2d6f, 0xe)) goto l_0x1010_2d6f; /* jz 0x10102d6f */
            ii(0x1010_2d61, 6); mov(edx, memd[ds, 0x101c_70ac]);        /* mov edx, [0x101c70ac] */
            ii(0x1010_2d67, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x1010_2d6a, 3); mov(memd[ds, eax + 0x22], edx);         /* mov [eax+0x22], edx */
            ii(0x1010_2d6d, 2); jmp(0x1010_2d7b, 0xc); goto l_0x1010_2d7b; /* jmp 0x10102d7b */
        l_0x1010_2d6f:
            ii(0x1010_2d6f, 6); mov(edx, memd[ds, 0x101c_70b0]);        /* mov edx, [0x101c70b0] */
            ii(0x1010_2d75, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x1010_2d78, 3); mov(memd[ds, eax + 0x22], edx);         /* mov [eax+0x22], edx */
        l_0x1010_2d7b:
            ii(0x1010_2d7b, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x1010_2d7e, 4); mov(memb[ds, eax + 0x2c], 0);           /* mov byte [eax+0x2c], 0x0 */
            ii(0x1010_2d82, 5); jmp(0x1010_2cef, -0x98); goto l_0x1010_2cef; /* jmp 0x10102cef */
        l_0x1010_2d87:
            ii(0x1010_2d87, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1010_2d89, 1); pop(ebp);                               /* pop ebp */
            ii(0x1010_2d8a, 1); pop(edi);                               /* pop edi */
            ii(0x1010_2d8b, 1); pop(esi);                               /* pop esi */
            ii(0x1010_2d8c, 1); pop(ecx);                               /* pop ecx */
            ii(0x1010_2d8d, 1); pop(ebx);                               /* pop ebx */
            ii(0x1010_2d8e, 1); ret();                                  /* ret */
        }
    }
}
