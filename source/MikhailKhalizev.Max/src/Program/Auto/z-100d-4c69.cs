using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100d_4c69-79a07fdb")]
        public void Method_100d_4c69()
        {
            ii(0x100d_4c69, 5); push(0x38);                             /* push 0x38 */
            ii(0x100d_4c6e, 5); call(Definitions.sys_check_available_stack_size, 0x9_10df); /* call 0x10165d52 */
            ii(0x100d_4c73, 1); push(ecx);                              /* push ecx */
            ii(0x100d_4c74, 1); push(esi);                              /* push esi */
            ii(0x100d_4c75, 1); push(edi);                              /* push edi */
            ii(0x100d_4c76, 1); push(ebp);                              /* push ebp */
            ii(0x100d_4c77, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100d_4c79, 6); sub(esp, 0x24);                         /* sub esp, 0x24 */
            ii(0x100d_4c7f, 3); mov(memd[ss, ebp - 0xc], eax);          /* mov [ebp-0xc], eax */
            ii(0x100d_4c82, 3); mov(memd[ss, ebp - 0x8], edx);          /* mov [ebp-0x8], edx */
            ii(0x100d_4c85, 3); mov(memd[ss, ebp - 0x4], ebx);          /* mov [ebp-0x4], ebx */
            ii(0x100d_4c88, 4); movsx(eax, memw[ss, ebp - 0x8]);        /* movsx eax, word [ebp-0x8] */
            ii(0x100d_4c8c, 3); cmp(eax, 0x1);                          /* cmp eax, 0x1 */
            ii(0x100d_4c8f, 2); if(jg(0x100d_4c9d, 0xc)) goto l_0x100d_4c9d; /* jg 0x100d4c9d */
            ii(0x100d_4c91, 7); mov(memd[ss, ebp - 0x10], 0x1);         /* mov dword [ebp-0x10], 0x1 */
            ii(0x100d_4c98, 5); jmp(0x100d_4d6d, 0xd0); goto l_0x100d_4d6d; /* jmp 0x100d4d6d */
        l_0x100d_4c9d:
            ii(0x100d_4c9d, 4); movsx(eax, memw[ss, ebp - 0x8]);        /* movsx eax, word [ebp-0x8] */
            ii(0x100d_4ca1, 3); cmp(eax, 0x2);                          /* cmp eax, 0x2 */
            ii(0x100d_4ca4, 2); if(jg(0x100d_4caf, 0x9)) goto l_0x100d_4caf; /* jg 0x100d4caf */
            ii(0x100d_4ca6, 7); mov(memd[ss, ebp - 0x14], 0x2);         /* mov dword [ebp-0x14], 0x2 */
            ii(0x100d_4cad, 2); jmp(0x100d_4cb6, 0x7); goto l_0x100d_4cb6; /* jmp 0x100d4cb6 */
        l_0x100d_4caf:
            ii(0x100d_4caf, 7); mov(memd[ss, ebp - 0x14], 0x4);         /* mov dword [ebp-0x14], 0x4 */
        l_0x100d_4cb6:
            ii(0x100d_4cb6, 4); movsx(eax, memw[ss, ebp - 0xc]);        /* movsx eax, word [ebp-0xc] */
            ii(0x100d_4cba, 3); imul(eax, eax, 0x33);                   /* imul eax, eax, 0x33 */
            ii(0x100d_4cbd, 7); test(memb[ds, eax + 0x101c_81c1], 0x1); /* test byte [eax+0x101c81c1], 0x1 */
            ii(0x100d_4cc4, 6); if(jz(0x100d_4d67, 0x9d)) goto l_0x100d_4d67; /* jz 0x100d4d67 */
            ii(0x100d_4cca, 4); movsx(edx, memw[ss, ebp - 0x14]);       /* movsx edx, word [ebp-0x14] */
            ii(0x100d_4cce, 4); movsx(eax, memw[ss, ebp - 0xc]);        /* movsx eax, word [ebp-0xc] */
            ii(0x100d_4cd2, 5); call(0x1007_1e00, -0x6_2ed7);           /* call 0x10071e00 */
            ii(0x100d_4cd7, 3); mov(memd[ss, ebp - 0x18], eax);         /* mov [ebp-0x18], eax */
        l_0x100d_4cda:
            ii(0x100d_4cda, 4); movsx(eax, memw[ss, ebp - 0x14]);       /* movsx eax, word [ebp-0x14] */
            ii(0x100d_4cde, 3); cmp(eax, 0x1);                          /* cmp eax, 0x1 */
            ii(0x100d_4ce1, 6); if(jle(0x100d_4d67, 0x80)) goto l_0x100d_4d67; /* jle 0x100d4d67 */
            ii(0x100d_4ce7, 4); movsx(edx, memw[ss, ebp - 0x14]);       /* movsx edx, word [ebp-0x14] */
            ii(0x100d_4ceb, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x100d_4ced, 3); sar(edx, 0x1f);                         /* sar edx, 0x1f */
            ii(0x100d_4cf0, 2); sub(eax, edx);                          /* sub eax, edx */
            ii(0x100d_4cf2, 2); sar(eax, 0x1);                          /* sar eax, 1 */
            ii(0x100d_4cf4, 3); mov(memd[ss, ebp - 0x1c], eax);         /* mov [ebp-0x1c], eax */
            ii(0x100d_4cf7, 4); movsx(edx, memw[ss, ebp - 0x1c]);       /* movsx edx, word [ebp-0x1c] */
            ii(0x100d_4cfb, 4); movsx(eax, memw[ss, ebp - 0xc]);        /* movsx eax, word [ebp-0xc] */
            ii(0x100d_4cff, 5); call(0x1007_1e00, -0x6_2f04);           /* call 0x10071e00 */
            ii(0x100d_4d04, 3); mov(memd[ss, ebp - 0x20], eax);         /* mov [ebp-0x20], eax */
            ii(0x100d_4d07, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100d_4d09, 4); movsx(eax, memw[ss, ebp - 0x8]);        /* movsx eax, word [ebp-0x8] */
            ii(0x100d_4d0d, 4); movsx(ebx, memw[ss, ebp - 0x14]);       /* movsx ebx, word [ebp-0x14] */
            ii(0x100d_4d11, 2); sub(eax, ebx);                          /* sub eax, ebx */
            ii(0x100d_4d13, 5); call(0x1007_6e7c, -0x5_de9c);           /* call 0x10076e7c */
            ii(0x100d_4d18, 4); movsx(edx, memw[ss, ebp - 0x1c]);       /* movsx edx, word [ebp-0x1c] */
            ii(0x100d_4d1c, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x100d_4d1e, 4); movsx(ebx, memw[ss, ebp - 0x1c]);       /* movsx ebx, word [ebp-0x1c] */
            ii(0x100d_4d22, 1); dec(edx);                               /* dec edx */
            ii(0x100d_4d23, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x100d_4d25, 3); sar(edx, 0x1f);                         /* sar edx, 0x1f */
            ii(0x100d_4d28, 2); idiv(ebx);                              /* idiv ebx */
            ii(0x100d_4d2a, 3); mov(memd[ss, ebp - 0x24], eax);         /* mov [ebp-0x24], eax */
            ii(0x100d_4d2d, 4); movsx(edx, memw[ss, ebp - 0x24]);       /* movsx edx, word [ebp-0x24] */
            ii(0x100d_4d31, 4); movsx(eax, memw[ss, ebp - 0x20]);       /* movsx eax, word [ebp-0x20] */
            ii(0x100d_4d35, 3); imul(eax, edx);                         /* imul eax, edx */
            ii(0x100d_4d38, 4); movsx(edx, memw[ss, ebp - 0x18]);       /* movsx edx, word [ebp-0x18] */
            ii(0x100d_4d3c, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x100d_4d3e, 4); movsx(edx, memw[ss, ebp - 0x4]);        /* movsx edx, word [ebp-0x4] */
            ii(0x100d_4d42, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x100d_4d44, 2); if(jl(0x100d_4d4e, 0x8)) goto l_0x100d_4d4e; /* jl 0x100d4d4e */
            ii(0x100d_4d46, 3); mov(eax, memd[ss, ebp - 0x14]);         /* mov eax, [ebp-0x14] */
            ii(0x100d_4d49, 3); mov(memd[ss, ebp - 0x10], eax);         /* mov [ebp-0x10], eax */
            ii(0x100d_4d4c, 2); jmp(0x100d_4d6d, 0x1f); goto l_0x100d_4d6d; /* jmp 0x100d4d6d */
        l_0x100d_4d4e:
            ii(0x100d_4d4e, 3); mov(eax, memd[ss, ebp - 0x14]);         /* mov eax, [ebp-0x14] */
            ii(0x100d_4d51, 2); cwd();                                  /* cwd */
            ii(0x100d_4d53, 3); sub(ax, dx);                            /* sub ax, dx */
            ii(0x100d_4d56, 3); sar(ax, 0x1);                           /* sar ax, 1 */
            ii(0x100d_4d59, 3); mov(memd[ss, ebp - 0x14], eax);         /* mov [ebp-0x14], eax */
            ii(0x100d_4d5c, 3); mov(eax, memd[ss, ebp - 0x20]);         /* mov eax, [ebp-0x20] */
            ii(0x100d_4d5f, 3); mov(memd[ss, ebp - 0x18], eax);         /* mov [ebp-0x18], eax */
            ii(0x100d_4d62, 5); jmp(0x100d_4cda, -0x8d); goto l_0x100d_4cda; /* jmp 0x100d4cda */
        l_0x100d_4d67:
            ii(0x100d_4d67, 3); mov(eax, memd[ss, ebp - 0x14]);         /* mov eax, [ebp-0x14] */
            ii(0x100d_4d6a, 3); mov(memd[ss, ebp - 0x10], eax);         /* mov [ebp-0x10], eax */
        l_0x100d_4d6d:
            ii(0x100d_4d6d, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x100d_4d70, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100d_4d72, 1); pop(ebp);                               /* pop ebp */
            ii(0x100d_4d73, 1); pop(edi);                               /* pop edi */
            ii(0x100d_4d74, 1); pop(esi);                               /* pop esi */
            ii(0x100d_4d75, 1); pop(ecx);                               /* pop ecx */
            ii(0x100d_4d76, 1); ret();                                  /* ret */
        }
    }
}
