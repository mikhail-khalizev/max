using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1010_68d0-3f7df933")]
        public void Method_1010_68d0()
        {
            ii(0x1010_68d0, 5); push(0x24);                             /* push 0x24 */
            ii(0x1010_68d5, 5); call(Definitions.sys_check_available_stack_size, 0x5_f478); /* call 0x10165d52 */
            ii(0x1010_68da, 1); push(ebx);                              /* push ebx */
            ii(0x1010_68db, 1); push(ecx);                              /* push ecx */
            ii(0x1010_68dc, 1); push(edx);                              /* push edx */
            ii(0x1010_68dd, 1); push(esi);                              /* push esi */
            ii(0x1010_68de, 1); push(edi);                              /* push edi */
            ii(0x1010_68df, 1); push(ebp);                              /* push ebp */
            ii(0x1010_68e0, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1010_68e2, 6); sub(esp, 8);                            /* sub esp, 0x8 */
            ii(0x1010_68e8, 3); mov(memd[ss, ebp - 4], eax);            /* mov [ebp-0x4], eax */
            ii(0x1010_68eb, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1010_68ee, 10); mov(memd[ds, eax + 132], 0);           /* mov dword [eax+0x84], 0x0 */
            ii(0x1010_68f8, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1010_68fb, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x1010_68fe, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1010_6901, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1010_6903, 1); pop(ebp);                               /* pop ebp */
            ii(0x1010_6904, 1); pop(edi);                               /* pop edi */
            ii(0x1010_6905, 1); pop(esi);                               /* pop esi */
            ii(0x1010_6906, 1); pop(edx);                               /* pop edx */
            ii(0x1010_6907, 1); pop(ecx);                               /* pop ecx */
            ii(0x1010_6908, 1); pop(ebx);                               /* pop ebx */
            ii(0x1010_6909, 1); ret();                                  /* ret */
        }
    }
}
