using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1013_38fc-117c2e5a")]
        public void Method_1013_38fc()
        {
            ii(0x1013_38fc, 5); push(0x24);                             /* push 0x24 */
            ii(0x1013_3901, 5); call(Definitions.sys_check_available_stack_size, 0x3_244c); /* call 0x10165d52 */
            ii(0x1013_3906, 1); push(ebx);                              /* push ebx */
            ii(0x1013_3907, 1); push(ecx);                              /* push ecx */
            ii(0x1013_3908, 1); push(edx);                              /* push edx */
            ii(0x1013_3909, 1); push(esi);                              /* push esi */
            ii(0x1013_390a, 1); push(edi);                              /* push edi */
            ii(0x1013_390b, 1); push(ebp);                              /* push ebp */
            ii(0x1013_390c, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1013_390e, 6); sub(esp, 8);                            /* sub esp, 0x8 */
            ii(0x1013_3914, 3); mov(memd[ss, ebp - 4], eax);            /* mov [ebp-0x4], eax */
            ii(0x1013_3917, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1013_391a, 4); mov(ax, memw[ds, eax + 0x17]);          /* mov ax, [eax+0x17] */
            ii(0x1013_391e, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x1013_3921, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1013_3924, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1013_3926, 1); pop(ebp);                               /* pop ebp */
            ii(0x1013_3927, 1); pop(edi);                               /* pop edi */
            ii(0x1013_3928, 1); pop(esi);                               /* pop esi */
            ii(0x1013_3929, 1); pop(edx);                               /* pop edx */
            ii(0x1013_392a, 1); pop(ecx);                               /* pop ecx */
            ii(0x1013_392b, 1); pop(ebx);                               /* pop ebx */
            ii(0x1013_392c, 1); ret();                                  /* ret */
        }
    }
}
