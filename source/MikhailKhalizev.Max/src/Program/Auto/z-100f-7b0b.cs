using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100f_7b0b-149deff1")]
        public void Method_100f_7b0b()
        {
            ii(0x100f_7b0b, 5); push(0x28);                             /* push 0x28 */
            ii(0x100f_7b10, 5); call(Definitions.sys_check_available_stack_size, 0x6_e23d); /* call 0x10165d52 */
            ii(0x100f_7b15, 1); push(ebx);                              /* push ebx */
            ii(0x100f_7b16, 1); push(ecx);                              /* push ecx */
            ii(0x100f_7b17, 1); push(esi);                              /* push esi */
            ii(0x100f_7b18, 1); push(edi);                              /* push edi */
            ii(0x100f_7b19, 1); push(ebp);                              /* push ebp */
            ii(0x100f_7b1a, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100f_7b1c, 6); sub(esp, 0x10);                         /* sub esp, 0x10 */
            ii(0x100f_7b22, 3); mov(memd[ss, ebp - 0x8], eax);          /* mov [ebp-0x8], eax */
            ii(0x100f_7b25, 3); mov(memd[ss, ebp - 0x4], edx);          /* mov [ebp-0x4], edx */
            ii(0x100f_7b28, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100f_7b2b, 4); test(memb[ds, eax + 0x13], 0x2);        /* test byte [eax+0x13], 0x2 */
            ii(0x100f_7b2f, 2); if(jnz(0x100f_7b3a, 0x9)) goto l_0x100f_7b3a; /* jnz 0x100f7b3a */
            ii(0x100f_7b31, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100f_7b34, 4); test(memb[ds, eax + 0x14], 0x20);       /* test byte [eax+0x14], 0x20 */
            ii(0x100f_7b38, 2); if(jnz(0x100f_7b3c, 0x2)) goto l_0x100f_7b3c; /* jnz 0x100f7b3c */
        l_0x100f_7b3a:
            ii(0x100f_7b3a, 2); jmp(0x100f_7b45, 0x9); goto l_0x100f_7b45; /* jmp 0x100f7b45 */
        l_0x100f_7b3c:
            ii(0x100f_7b3c, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100f_7b3f, 4); cmp(memb[ds, eax + 0x3d], 0x1);         /* cmp byte [eax+0x3d], 0x1 */
            ii(0x100f_7b43, 2); if(jnz(0x100f_7b47, 0x2)) goto l_0x100f_7b47; /* jnz 0x100f7b47 */
        l_0x100f_7b45:
            ii(0x100f_7b45, 2); jmp(0x100f_7b50, 0x9); goto l_0x100f_7b50; /* jmp 0x100f7b50 */
        l_0x100f_7b47:
            ii(0x100f_7b47, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100f_7b4a, 4); cmp(memb[ds, eax + 0x3d], 0x3);         /* cmp byte [eax+0x3d], 0x3 */
            ii(0x100f_7b4e, 2); if(jnz(0x100f_7b52, 0x2)) goto l_0x100f_7b52; /* jnz 0x100f7b52 */
        l_0x100f_7b50:
            ii(0x100f_7b50, 2); jmp(0x100f_7b5b, 0x9); goto l_0x100f_7b5b; /* jmp 0x100f7b5b */
        l_0x100f_7b52:
            ii(0x100f_7b52, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100f_7b55, 4); cmp(memb[ds, eax + 0x3d], 0x9);         /* cmp byte [eax+0x3d], 0x9 */
            ii(0x100f_7b59, 2); if(jnz(0x100f_7b5d, 0x2)) goto l_0x100f_7b5d; /* jnz 0x100f7b5d */
        l_0x100f_7b5b:
            ii(0x100f_7b5b, 2); jmp(0x100f_7b66, 0x9); goto l_0x100f_7b66; /* jmp 0x100f7b66 */
        l_0x100f_7b5d:
            ii(0x100f_7b5d, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100f_7b60, 4); cmp(memb[ds, eax + 0x3e], 0xe);         /* cmp byte [eax+0x3e], 0xe */
            ii(0x100f_7b64, 2); if(jnz(0x100f_7b6f, 0x9)) goto l_0x100f_7b6f; /* jnz 0x100f7b6f */
        l_0x100f_7b66:
            ii(0x100f_7b66, 7); mov(memd[ss, ebp - 0x10], 0);           /* mov dword [ebp-0x10], 0x0 */
            ii(0x100f_7b6d, 2); jmp(0x100f_7bca, 0x5b); goto l_0x100f_7bca; /* jmp 0x100f7bca */
        l_0x100f_7b6f:
            ii(0x100f_7b6f, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100f_7b72, 5); cmp(memw[ds, eax + 0x8], 0x41);         /* cmp word [eax+0x8], 0x41 */
            ii(0x100f_7b77, 2); if(jz(0x100f_7b83, 0xa)) goto l_0x100f_7b83; /* jz 0x100f7b83 */
            ii(0x100f_7b79, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100f_7b7c, 5); cmp(memw[ds, eax + 0x8], 0x48);         /* cmp word [eax+0x8], 0x48 */
            ii(0x100f_7b81, 2); if(jnz(0x100f_7b85, 0x2)) goto l_0x100f_7b85; /* jnz 0x100f7b85 */
        l_0x100f_7b83:
            ii(0x100f_7b83, 2); jmp(0x100f_7b8f, 0xa); goto l_0x100f_7b8f; /* jmp 0x100f7b8f */
        l_0x100f_7b85:
            ii(0x100f_7b85, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100f_7b88, 5); cmp(memw[ds, eax + 0x8], 0x4e);         /* cmp word [eax+0x8], 0x4e */
            ii(0x100f_7b8d, 2); if(jnz(0x100f_7ba2, 0x13)) goto l_0x100f_7ba2; /* jnz 0x100f7ba2 */
        l_0x100f_7b8f:
            ii(0x100f_7b8f, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100f_7b92, 5); cmp(memw[ds, eax + 0x52], 0);           /* cmp word [eax+0x52], 0x0 */
            ii(0x100f_7b97, 2); if(jz(0x100f_7ba2, 0x9)) goto l_0x100f_7ba2; /* jz 0x100f7ba2 */
            ii(0x100f_7b99, 7); mov(memd[ss, ebp - 0x10], 0);           /* mov dword [ebp-0x10], 0x0 */
            ii(0x100f_7ba0, 2); jmp(0x100f_7bca, 0x28); goto l_0x100f_7bca; /* jmp 0x100f7bca */
        l_0x100f_7ba2:
            ii(0x100f_7ba2, 5); mov(ebx, 0x18);                         /* mov ebx, 0x18 */
            ii(0x100f_7ba7, 3); mov(edx, memd[ss, ebp - 0x4]);          /* mov edx, [ebp-0x4] */
            ii(0x100f_7baa, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100f_7bad, 5); call(0x1015_c75a, 0x6_4ba8);            /* call 0x1015c75a */
            ii(0x100f_7bb2, 3); mov(memd[ss, ebp - 0xc], eax);          /* mov [ebp-0xc], eax */
            ii(0x100f_7bb5, 5); mov(edx, 0x1a);                         /* mov edx, 0x1a */
            ii(0x100f_7bba, 4); movsx(eax, memw[ss, ebp - 0xc]);        /* movsx eax, word [ebp-0xc] */
            ii(0x100f_7bbe, 5); call(0x1012_10e7, 0x2_9524);            /* call 0x101210e7 */
            ii(0x100f_7bc3, 7); mov(memd[ss, ebp - 0x10], 0x1);         /* mov dword [ebp-0x10], 0x1 */
        l_0x100f_7bca:
            ii(0x100f_7bca, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x100f_7bcd, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100f_7bcf, 1); pop(ebp);                               /* pop ebp */
            ii(0x100f_7bd0, 1); pop(edi);                               /* pop edi */
            ii(0x100f_7bd1, 1); pop(esi);                               /* pop esi */
            ii(0x100f_7bd2, 1); pop(ecx);                               /* pop ecx */
            ii(0x100f_7bd3, 1); pop(ebx);                               /* pop ebx */
            ii(0x100f_7bd4, 1); ret();                                  /* ret */
        }
    }
}
