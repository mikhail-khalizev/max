using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1007_5eec-a45f02f4")]
        public void Method_1007_5eec()
        {
            ii(0x1007_5eec, 5); push(0x24);                             /* push 0x24 */
            ii(0x1007_5ef1, 5); call(Definitions.sys_check_available_stack_size, 0xe_fe5c); /* call 0x10165d52 */
            ii(0x1007_5ef6, 1); push(ebx);                              /* push ebx */
            ii(0x1007_5ef7, 1); push(ecx);                              /* push ecx */
            ii(0x1007_5ef8, 1); push(esi);                              /* push esi */
            ii(0x1007_5ef9, 1); push(edi);                              /* push edi */
            ii(0x1007_5efa, 1); push(ebp);                              /* push ebp */
            ii(0x1007_5efb, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1007_5efd, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x1007_5f03, 3); mov(memd[ss, ebp - 0x8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1007_5f06, 3); mov(memd[ss, ebp - 0x4], edx);          /* mov [ebp-0x4], edx */
            ii(0x1007_5f09, 5); mov(edx, 0x1);                          /* mov edx, 0x1 */
            ii(0x1007_5f0e, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1007_5f11, 5); call(Definitions.my_dtor_0x101b_6edc, 0xc_4d2f); /* call 0x1013ac45 */
            ii(0x1007_5f16, 3); mov(memd[ss, ebp - 0x8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1007_5f19, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1007_5f1c, 3); mov(memd[ss, ebp - 0xc], eax);          /* mov [ebp-0xc], eax */
            ii(0x1007_5f1f, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x1007_5f22, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1007_5f24, 1); pop(ebp);                               /* pop ebp */
            ii(0x1007_5f25, 1); pop(edi);                               /* pop edi */
            ii(0x1007_5f26, 1); pop(esi);                               /* pop esi */
            ii(0x1007_5f27, 1); pop(ecx);                               /* pop ecx */
            ii(0x1007_5f28, 1); pop(ebx);                               /* pop ebx */
            ii(0x1007_5f29, 1); ret();                                  /* ret */
        }
    }
}
