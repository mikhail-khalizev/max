using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100f_73f7-eb3fbd01")]
        public void Method_100f_73f7()
        {
            ii(0x100f_73f7, 5); push(0x28);                             /* push 0x28 */
            ii(0x100f_73fc, 5); call(Definitions.sys_check_available_stack_size, 0x6_e951); /* call 0x10165d52 */
            ii(0x100f_7401, 1); push(ebx);                              /* push ebx */
            ii(0x100f_7402, 1); push(ecx);                              /* push ecx */
            ii(0x100f_7403, 1); push(edx);                              /* push edx */
            ii(0x100f_7404, 1); push(esi);                              /* push esi */
            ii(0x100f_7405, 1); push(edi);                              /* push edi */
            ii(0x100f_7406, 1); push(ebp);                              /* push ebp */
            ii(0x100f_7407, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100f_7409, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x100f_740f, 3); mov(memd[ss, ebp - 4], eax);            /* mov [ebp-0x4], eax */
            ii(0x100f_7412, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100f_7415, 4); test(memb[ds, eax + 0x12], 0x40);       /* test byte [eax+0x12], 0x40 */
            ii(0x100f_7419, 2); if(jz(0x100f_743c, 0x21)) goto l_0x100f_743c; /* jz 0x100f743c */
            ii(0x100f_741b, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100f_741e, 4); test(memb[ds, eax + 0x14], 1);          /* test byte [eax+0x14], 0x1 */
            ii(0x100f_7422, 2); if(jnz(0x100f_742d, 9)) goto l_0x100f_742d; /* jnz 0x100f742d */
            ii(0x100f_7424, 7); mov(memd[ss, ebp - 0xc], 1);            /* mov dword [ebp-0xc], 0x1 */
            ii(0x100f_742b, 2); jmp(0x100f_7434, 7); goto l_0x100f_7434; /* jmp 0x100f7434 */
        l_0x100f_742d:
            ii(0x100f_742d, 7); mov(memd[ss, ebp - 0xc], 0);            /* mov dword [ebp-0xc], 0x0 */
        l_0x100f_7434:
            ii(0x100f_7434, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x100f_7437, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x100f_743a, 2); jmp(0x100f_7443, 7); goto l_0x100f_7443; /* jmp 0x100f7443 */
        l_0x100f_743c:
            ii(0x100f_743c, 7); mov(memd[ss, ebp - 8], 1);              /* mov dword [ebp-0x8], 0x1 */
        l_0x100f_7443:
            ii(0x100f_7443, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100f_7446, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100f_7448, 1); pop(ebp);                               /* pop ebp */
            ii(0x100f_7449, 1); pop(edi);                               /* pop edi */
            ii(0x100f_744a, 1); pop(esi);                               /* pop esi */
            ii(0x100f_744b, 1); pop(edx);                               /* pop edx */
            ii(0x100f_744c, 1); pop(ecx);                               /* pop ecx */
            ii(0x100f_744d, 1); pop(ebx);                               /* pop ebx */
            ii(0x100f_744e, 1); ret();                                  /* ret */
        }
    }
}
