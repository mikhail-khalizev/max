using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100f_1d28-6aec74a7")]
        public void Method_100f_1d28()
        {
            ii(0x100f_1d28, 5); push(0x28);                             /* push 0x28 */
            ii(0x100f_1d2d, 5); call(Definitions.sys_check_available_stack_size, 0x7_4020); /* call 0x10165d52 */
            ii(0x100f_1d32, 1); push(ebx);                              /* push ebx */
            ii(0x100f_1d33, 1); push(ecx);                              /* push ecx */
            ii(0x100f_1d34, 1); push(edx);                              /* push edx */
            ii(0x100f_1d35, 1); push(esi);                              /* push esi */
            ii(0x100f_1d36, 1); push(edi);                              /* push edi */
            ii(0x100f_1d37, 1); push(ebp);                              /* push ebp */
            ii(0x100f_1d38, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100f_1d3a, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x100f_1d40, 3); mov(memd[ss, ebp - 4], eax);            /* mov [ebp-0x4], eax */
            ii(0x100f_1d43, 4); movsx(eax, memw[ss, ebp - 4]);          /* movsx eax, word [ebp-0x4] */
            ii(0x100f_1d47, 5); call(0x1007_28ea, -0x7_f462);           /* call 0x100728ea */
            ii(0x100f_1d4c, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x100f_1d4f, 4); cmp(memd[ss, ebp - 8], 0);              /* cmp dword [ebp-0x8], 0x0 */
            ii(0x100f_1d53, 2); if(jnz(0x100f_1d6a, 0x15)) goto l_0x100f_1d6a; /* jnz 0x100f1d6a */
            ii(0x100f_1d55, 5); mov(edx, 0x101c_8184);                  /* mov edx, 0x101c8184 */
            ii(0x100f_1d5a, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x100f_1d5c, 5); mov(al, memb[ds, 0x101c_37da]);         /* mov al, [0x101c37da] */
            ii(0x100f_1d61, 1); cwde();                                 /* cwde */
            ii(0x100f_1d62, 5); call(0x1007_2999, -0x7_f3ce);           /* call 0x10072999 */
            ii(0x100f_1d67, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
        l_0x100f_1d6a:
            ii(0x100f_1d6a, 4); cmp(memd[ss, ebp - 8], 0);              /* cmp dword [ebp-0x8], 0x0 */
            ii(0x100f_1d6e, 2); if(jnz(0x100f_1d85, 0x15)) goto l_0x100f_1d85; /* jnz 0x100f1d85 */
            ii(0x100f_1d70, 5); mov(edx, 0x101c_81a8);                  /* mov edx, 0x101c81a8 */
            ii(0x100f_1d75, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x100f_1d77, 5); mov(al, memb[ds, 0x101c_37da]);         /* mov al, [0x101c37da] */
            ii(0x100f_1d7c, 1); cwde();                                 /* cwde */
            ii(0x100f_1d7d, 5); call(0x1007_2999, -0x7_f3e9);           /* call 0x10072999 */
            ii(0x100f_1d82, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
        l_0x100f_1d85:
            ii(0x100f_1d85, 4); cmp(memd[ss, ebp - 8], 0);              /* cmp dword [ebp-0x8], 0x0 */
            ii(0x100f_1d89, 2); if(jnz(0x100f_1da0, 0x15)) goto l_0x100f_1da0; /* jnz 0x100f1da0 */
            ii(0x100f_1d8b, 5); mov(edx, 0x101c_819c);                  /* mov edx, 0x101c819c */
            ii(0x100f_1d90, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x100f_1d92, 5); mov(al, memb[ds, 0x101c_37da]);         /* mov al, [0x101c37da] */
            ii(0x100f_1d97, 1); cwde();                                 /* cwde */
            ii(0x100f_1d98, 5); call(0x1007_2999, -0x7_f404);           /* call 0x10072999 */
            ii(0x100f_1d9d, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
        l_0x100f_1da0:
            ii(0x100f_1da0, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100f_1da3, 3); mov(memd[ss, ebp - 0xc], eax);          /* mov [ebp-0xc], eax */
            ii(0x100f_1da6, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x100f_1da9, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100f_1dab, 1); pop(ebp);                               /* pop ebp */
            ii(0x100f_1dac, 1); pop(edi);                               /* pop edi */
            ii(0x100f_1dad, 1); pop(esi);                               /* pop esi */
            ii(0x100f_1dae, 1); pop(edx);                               /* pop edx */
            ii(0x100f_1daf, 1); pop(ecx);                               /* pop ecx */
            ii(0x100f_1db0, 1); pop(ebx);                               /* pop ebx */
            ii(0x100f_1db1, 1); ret();                                  /* ret */
        }
    }
}
