using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100b_aaec-ab06fc18")]
        public void Method_100b_aaec()
        {
            ii(0x100b_aaec, 5); push(0x28);                             /* push 0x28 */
            ii(0x100b_aaf1, 5); call(Definitions.sys_check_available_stack_size, 0xa_b25c); /* call 0x10165d52 */
            ii(0x100b_aaf6, 1); push(ebx);                              /* push ebx */
            ii(0x100b_aaf7, 1); push(ecx);                              /* push ecx */
            ii(0x100b_aaf8, 1); push(esi);                              /* push esi */
            ii(0x100b_aaf9, 1); push(edi);                              /* push edi */
            ii(0x100b_aafa, 1); push(ebp);                              /* push ebp */
            ii(0x100b_aafb, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100b_aafd, 6); sub(esp, 0x10);                         /* sub esp, 0x10 */
            ii(0x100b_ab03, 3); mov(memd[ss, ebp - 0x8], eax);          /* mov [ebp-0x8], eax */
            ii(0x100b_ab06, 3); mov(memd[ss, ebp - 0x4], edx);          /* mov [ebp-0x4], edx */
            ii(0x100b_ab09, 5); mov(ebx, 0x101c_819c);                  /* mov ebx, 0x101c819c */
            ii(0x100b_ab0e, 4); movsx(edx, memw[ss, ebp - 0x4]);        /* movsx edx, word [ebp-0x4] */
            ii(0x100b_ab12, 3); lea(eax, ebp - 0xc);                    /* lea eax, [ebp-0xc] */
            ii(0x100b_ab15, 5); call(0x100b_a9e8, -0x132);              /* call 0x100ba9e8 */
            ii(0x100b_ab1a, 4); movsx(eax, memw[ss, ebp - 0xc]);        /* movsx eax, word [ebp-0xc] */
            ii(0x100b_ab1e, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100b_ab20, 2); if(jnz(0x100b_ab2a, 0x8)) goto l_0x100b_ab2a; /* jnz 0x100bab2a */
            ii(0x100b_ab22, 4); movsx(eax, memw[ss, ebp - 0xa]);        /* movsx eax, word [ebp-0xa] */
            ii(0x100b_ab26, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100b_ab28, 2); if(jz(0x100b_ab2c, 0x2)) goto l_0x100b_ab2c; /* jz 0x100bab2c */
        l_0x100b_ab2a:
            ii(0x100b_ab2a, 2); jmp(0x100b_ab47, 0x1b); goto l_0x100b_ab47; /* jmp 0x100bab47 */
        l_0x100b_ab2c:
            ii(0x100b_ab2c, 5); mov(ebx, 0x101c_8184);                  /* mov ebx, 0x101c8184 */
            ii(0x100b_ab31, 4); movsx(edx, memw[ss, ebp - 0x4]);        /* movsx edx, word [ebp-0x4] */
            ii(0x100b_ab35, 3); lea(eax, ebp - 0x10);                   /* lea eax, [ebp-0x10] */
            ii(0x100b_ab38, 5); call(0x100b_a9e8, -0x155);              /* call 0x100ba9e8 */
            ii(0x100b_ab3d, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100b_ab3f, 3); lea(eax, ebp - 0xc);                    /* lea eax, [ebp-0xc] */
            ii(0x100b_ab42, 5); call(0x1008_8b44, -0x3_2003);           /* call 0x10088b44 */
        l_0x100b_ab47:
            ii(0x100b_ab47, 3); lea(edx, ebp - 0xc);                    /* lea edx, [ebp-0xc] */
            ii(0x100b_ab4a, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100b_ab4d, 5); call(0x1007_5e64, -0x4_4cee);           /* call 0x10075e64 */
            ii(0x100b_ab52, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100b_ab55, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100b_ab57, 1); pop(ebp);                               /* pop ebp */
            ii(0x100b_ab58, 1); pop(edi);                               /* pop edi */
            ii(0x100b_ab59, 1); pop(esi);                               /* pop esi */
            ii(0x100b_ab5a, 1); pop(ecx);                               /* pop ecx */
            ii(0x100b_ab5b, 1); pop(ebx);                               /* pop ebx */
            ii(0x100b_ab5c, 1); ret();                                  /* ret */
        }
    }
}
