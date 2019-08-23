using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1009_c0a4-14dea9b7")]
        public void Method_1009_c0a4()
        {
            ii(0x1009_c0a4, 5); push(0x24);                             /* push 0x24 */
            ii(0x1009_c0a9, 5); call(Definitions.sys_check_available_stack_size, 0xc_9ca4); /* call 0x10165d52 */
            ii(0x1009_c0ae, 1); push(ebx);                              /* push ebx */
            ii(0x1009_c0af, 1); push(ecx);                              /* push ecx */
            ii(0x1009_c0b0, 1); push(esi);                              /* push esi */
            ii(0x1009_c0b1, 1); push(edi);                              /* push edi */
            ii(0x1009_c0b2, 1); push(ebp);                              /* push ebp */
            ii(0x1009_c0b3, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1009_c0b5, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x1009_c0bb, 3); mov(memd[ss, ebp - 0x8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1009_c0be, 3); mov(memd[ss, ebp - 0x4], edx);          /* mov [ebp-0x4], edx */
            ii(0x1009_c0c1, 5); mov(edx, 0x1);                          /* mov edx, 0x1 */
            ii(0x1009_c0c6, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1009_c0c9, 5); call(Definitions.my_dtor_0x101b_6edc, 0x9_eb77); /* call 0x1013ac45 */
            ii(0x1009_c0ce, 3); mov(memd[ss, ebp - 0x8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1009_c0d1, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1009_c0d4, 3); mov(memd[ss, ebp - 0xc], eax);          /* mov [ebp-0xc], eax */
            ii(0x1009_c0d7, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x1009_c0da, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1009_c0dc, 1); pop(ebp);                               /* pop ebp */
            ii(0x1009_c0dd, 1); pop(edi);                               /* pop edi */
            ii(0x1009_c0de, 1); pop(esi);                               /* pop esi */
            ii(0x1009_c0df, 1); pop(ecx);                               /* pop ecx */
            ii(0x1009_c0e0, 1); pop(ebx);                               /* pop ebx */
            ii(0x1009_c0e1, 1); ret();                                  /* ret */
        }
    }
}
