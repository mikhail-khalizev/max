using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100a_af7c-219ed0cf")]
        public void Method_100a_af7c()
        {
            ii(0x100a_af7c, 5); push(0x28);                             /* push 0x28 */
            ii(0x100a_af81, 5); call(Definitions.sys_check_available_stack_size, 0xb_adcc); /* call 0x10165d52 */
            ii(0x100a_af86, 1); push(ebx);                              /* push ebx */
            ii(0x100a_af87, 1); push(ecx);                              /* push ecx */
            ii(0x100a_af88, 1); push(esi);                              /* push esi */
            ii(0x100a_af89, 1); push(edi);                              /* push edi */
            ii(0x100a_af8a, 1); push(ebp);                              /* push ebp */
            ii(0x100a_af8b, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100a_af8d, 6); sub(esp, 0x10);                         /* sub esp, 0x10 */
            ii(0x100a_af93, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x100a_af96, 3); mov(memd[ss, ebp - 4], edx);            /* mov [ebp-0x4], edx */
            ii(0x100a_af99, 3); mov(edx, memd[ss, ebp - 4]);            /* mov edx, [ebp-0x4] */
            ii(0x100a_af9c, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100a_af9f, 5); call(0x1007_6cd0, -0x3_42d4);           /* call 0x10076cd0 */
            ii(0x100a_afa4, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x100a_afa7, 3); lea(eax, memd[ss, ebp - 8]);            /* lea eax, [ebp-0x8] */
            ii(0x100a_afaa, 3); mov(memd[ss, ebp - 0xc], eax);          /* mov [ebp-0xc], eax */
            ii(0x100a_afad, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100a_afb0, 3); mov(memd[ss, ebp - 0x10], eax);         /* mov [ebp-0x10], eax */
            ii(0x100a_afb3, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x100a_afb6, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100a_afb8, 1); pop(ebp);                               /* pop ebp */
            ii(0x100a_afb9, 1); pop(edi);                               /* pop edi */
            ii(0x100a_afba, 1); pop(esi);                               /* pop esi */
            ii(0x100a_afbb, 1); pop(ecx);                               /* pop ecx */
            ii(0x100a_afbc, 1); pop(ebx);                               /* pop ebx */
            ii(0x100a_afbd, 1); ret();                                  /* ret */
        }
    }
}
