using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1007_9840-86bc3a46")]
        public void Method_1007_9840()
        {
            ii(0x1007_9840, 5); push(0x24);                             /* push 0x24 */
            ii(0x1007_9845, 5); call(Definitions.sys_check_available_stack_size, 0xe_c508); /* call 0x10165d52 */
            ii(0x1007_984a, 1); push(ebx);                              /* push ebx */
            ii(0x1007_984b, 1); push(ecx);                              /* push ecx */
            ii(0x1007_984c, 1); push(esi);                              /* push esi */
            ii(0x1007_984d, 1); push(edi);                              /* push edi */
            ii(0x1007_984e, 1); push(ebp);                              /* push ebp */
            ii(0x1007_984f, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1007_9851, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x1007_9857, 3); mov(memd[ss, ebp - 0x8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1007_985a, 3); mov(memd[ss, ebp - 0x4], edx);          /* mov [ebp-0x4], edx */
            ii(0x1007_985d, 5); mov(edx, StringDefinitions.MaintainAnAttackReserve); /* mov edx, 0x101a0120 */
            ii(0x1007_9862, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1007_9865, 5); call(Definitions.sys_strcpy, 0xe_c665); /* call 0x10165ecf */
            ii(0x1007_986a, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1007_986d, 3); mov(memd[ss, ebp - 0xc], eax);          /* mov [ebp-0xc], eax */
            ii(0x1007_9870, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x1007_9873, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1007_9875, 1); pop(ebp);                               /* pop ebp */
            ii(0x1007_9876, 1); pop(edi);                               /* pop edi */
            ii(0x1007_9877, 1); pop(esi);                               /* pop esi */
            ii(0x1007_9878, 1); pop(ecx);                               /* pop ecx */
            ii(0x1007_9879, 1); pop(ebx);                               /* pop ebx */
            ii(0x1007_987a, 1); ret();                                  /* ret */
        }
    }
}
