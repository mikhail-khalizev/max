using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1010_e477-af98d6a3")]
        public void Method_1010_e477()
        {
            ii(0x1010_e477, 5); push(0x20);                             /* push 0x20 */
            ii(0x1010_e47c, 5); call(Definitions.sys_check_available_stack_size, 0x5_78d1); /* call 0x10165d52 */
            ii(0x1010_e481, 1); push(ebx);                              /* push ebx */
            ii(0x1010_e482, 1); push(ecx);                              /* push ecx */
            ii(0x1010_e483, 1); push(edx);                              /* push edx */
            ii(0x1010_e484, 1); push(esi);                              /* push esi */
            ii(0x1010_e485, 1); push(edi);                              /* push edi */
            ii(0x1010_e486, 1); push(ebp);                              /* push ebp */
            ii(0x1010_e487, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1010_e489, 6); sub(esp, 0x4);                          /* sub esp, 0x4 */
            ii(0x1010_e48f, 3); mov(memd[ss, ebp - 0x4], eax);          /* mov [ebp-0x4], eax */
            ii(0x1010_e492, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1010_e495, 7); mov(memd[ds, eax + 0x8], 0x1);          /* mov dword [eax+0x8], 0x1 */
            ii(0x1010_e49c, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1010_e49e, 1); pop(ebp);                               /* pop ebp */
            ii(0x1010_e49f, 1); pop(edi);                               /* pop edi */
            ii(0x1010_e4a0, 1); pop(esi);                               /* pop esi */
            ii(0x1010_e4a1, 1); pop(edx);                               /* pop edx */
            ii(0x1010_e4a2, 1); pop(ecx);                               /* pop ecx */
            ii(0x1010_e4a3, 1); pop(ebx);                               /* pop ebx */
            ii(0x1010_e4a4, 1); ret();                                  /* ret */
        }
    }
}
