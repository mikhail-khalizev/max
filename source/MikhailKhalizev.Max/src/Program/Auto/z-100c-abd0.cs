using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100c_abd0-a06247a7")]
        public void Method_100c_abd0()
        {
            ii(0x100c_abd0, 5); push(0x24);                             /* push 0x24 */
            ii(0x100c_abd5, 5); call(Definitions.sys_check_available_stack_size, 0x9_b178); /* call 0x10165d52 */
            ii(0x100c_abda, 1); push(ebx);                              /* push ebx */
            ii(0x100c_abdb, 1); push(ecx);                              /* push ecx */
            ii(0x100c_abdc, 1); push(edx);                              /* push edx */
            ii(0x100c_abdd, 1); push(esi);                              /* push esi */
            ii(0x100c_abde, 1); push(edi);                              /* push edi */
            ii(0x100c_abdf, 1); push(ebp);                              /* push ebp */
            ii(0x100c_abe0, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100c_abe2, 6); sub(esp, 8);                            /* sub esp, 0x8 */
            ii(0x100c_abe8, 3); mov(memd[ss, ebp - 4], eax);            /* mov [ebp-0x4], eax */
            ii(0x100c_abeb, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100c_abee, 3); mov(al, memb[ds, eax + 6]);             /* mov al, [eax+0x6] */
            ii(0x100c_abf1, 3); mov(memb[ss, ebp - 8], al);             /* mov [ebp-0x8], al */
            ii(0x100c_abf4, 3); mov(al, memb[ss, ebp - 8]);             /* mov al, [ebp-0x8] */
            ii(0x100c_abf7, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100c_abf9, 1); pop(ebp);                               /* pop ebp */
            ii(0x100c_abfa, 1); pop(edi);                               /* pop edi */
            ii(0x100c_abfb, 1); pop(esi);                               /* pop esi */
            ii(0x100c_abfc, 1); pop(edx);                               /* pop edx */
            ii(0x100c_abfd, 1); pop(ecx);                               /* pop ecx */
            ii(0x100c_abfe, 1); pop(ebx);                               /* pop ebx */
            ii(0x100c_abff, 1); ret();                                  /* ret */
        }
    }
}
