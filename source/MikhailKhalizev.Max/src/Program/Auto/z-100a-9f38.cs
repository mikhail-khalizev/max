using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100a_9f38-943df1f5")]
        public void Method_100a_9f38()
        {
            ii(0x100a_9f38, 5); push(0x24);                             /* push 0x24 */
            ii(0x100a_9f3d, 5); call(Definitions.sys_check_available_stack_size, 0xb_be10); /* call 0x10165d52 */
            ii(0x100a_9f42, 1); push(ebx);                              /* push ebx */
            ii(0x100a_9f43, 1); push(ecx);                              /* push ecx */
            ii(0x100a_9f44, 1); push(esi);                              /* push esi */
            ii(0x100a_9f45, 1); push(edi);                              /* push edi */
            ii(0x100a_9f46, 1); push(ebp);                              /* push ebp */
            ii(0x100a_9f47, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100a_9f49, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x100a_9f4f, 3); mov(memd[ss, ebp - 0x8], eax);          /* mov [ebp-0x8], eax */
            ii(0x100a_9f52, 3); mov(memd[ss, ebp - 0x4], edx);          /* mov [ebp-0x4], edx */
            ii(0x100a_9f55, 5); mov(edx, 0x1);                          /* mov edx, 0x1 */
            ii(0x100a_9f5a, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100a_9f5d, 5); call(Definitions.my_dtor_0x101b_6edc, 0x9_0ce3); /* call 0x1013ac45 */
            ii(0x100a_9f62, 3); mov(memd[ss, ebp - 0x8], eax);          /* mov [ebp-0x8], eax */
            ii(0x100a_9f65, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100a_9f68, 3); mov(memd[ss, ebp - 0xc], eax);          /* mov [ebp-0xc], eax */
            ii(0x100a_9f6b, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x100a_9f6e, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100a_9f70, 1); pop(ebp);                               /* pop ebp */
            ii(0x100a_9f71, 1); pop(edi);                               /* pop edi */
            ii(0x100a_9f72, 1); pop(esi);                               /* pop esi */
            ii(0x100a_9f73, 1); pop(ecx);                               /* pop ecx */
            ii(0x100a_9f74, 1); pop(ebx);                               /* pop ebx */
            ii(0x100a_9f75, 1); ret();                                  /* ret */
        }
    }
}
