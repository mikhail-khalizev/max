using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1010_4790-710fb19d")]
        public void Method_1010_4790()
        {
            ii(0x1010_4790, 5); push(0x24);                             /* push 0x24 */
            ii(0x1010_4795, 5); call(Definitions.sys_check_available_stack_size, 0x6_15b8); /* call 0x10165d52 */
            ii(0x1010_479a, 1); push(ebx);                              /* push ebx */
            ii(0x1010_479b, 1); push(ecx);                              /* push ecx */
            ii(0x1010_479c, 1); push(edx);                              /* push edx */
            ii(0x1010_479d, 1); push(esi);                              /* push esi */
            ii(0x1010_479e, 1); push(edi);                              /* push edi */
            ii(0x1010_479f, 1); push(ebp);                              /* push ebp */
            ii(0x1010_47a0, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1010_47a2, 6); sub(esp, 8);                            /* sub esp, 0x8 */
            ii(0x1010_47a8, 3); mov(memd[ss, ebp - 4], eax);            /* mov [ebp-0x4], eax */
            ii(0x1010_47ab, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1010_47ae, 4); mov(ax, memw[ds, eax + 16]);            /* mov ax, [eax+0x10] */
            ii(0x1010_47b2, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x1010_47b5, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1010_47b8, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1010_47ba, 1); pop(ebp);                               /* pop ebp */
            ii(0x1010_47bb, 1); pop(edi);                               /* pop edi */
            ii(0x1010_47bc, 1); pop(esi);                               /* pop esi */
            ii(0x1010_47bd, 1); pop(edx);                               /* pop edx */
            ii(0x1010_47be, 1); pop(ecx);                               /* pop ecx */
            ii(0x1010_47bf, 1); pop(ebx);                               /* pop ebx */
            ii(0x1010_47c0, 1); ret();                                  /* ret */
        }
    }
}
