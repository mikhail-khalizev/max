using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100b_7ed8-3fa73fcf")]
        public void Method_100b_7ed8()
        {
            ii(0x100b_7ed8, 5); push(0x28);                             /* push 0x28 */
            ii(0x100b_7edd, 5); call(Definitions.sys_check_available_stack_size, 0xa_de70); /* call 0x10165d52 */
            ii(0x100b_7ee2, 1); push(ebx);                              /* push ebx */
            ii(0x100b_7ee3, 1); push(ecx);                              /* push ecx */
            ii(0x100b_7ee4, 1); push(edx);                              /* push edx */
            ii(0x100b_7ee5, 1); push(esi);                              /* push esi */
            ii(0x100b_7ee6, 1); push(edi);                              /* push edi */
            ii(0x100b_7ee7, 1); push(ebp);                              /* push ebp */
            ii(0x100b_7ee8, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100b_7eea, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x100b_7ef0, 3); mov(memd[ss, ebp - 0x4], eax);          /* mov [ebp-0x4], eax */
            ii(0x100b_7ef3, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100b_7ef6, 5); call(Definitions.my_ctor_0x101b_6edc, -0x4_10b7); /* call 0x10076e44 */
            ii(0x100b_7efb, 3); mov(memd[ss, ebp - 0x4], eax);          /* mov [ebp-0x4], eax */
            ii(0x100b_7efe, 3); lea(eax, ebp - 0x4);                    /* lea eax, [ebp-0x4] */
            ii(0x100b_7f01, 3); mov(memd[ss, ebp - 0x8], eax);          /* mov [ebp-0x8], eax */
            ii(0x100b_7f04, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100b_7f07, 3); mov(memd[ss, ebp - 0xc], eax);          /* mov [ebp-0xc], eax */
            ii(0x100b_7f0a, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x100b_7f0d, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100b_7f0f, 1); pop(ebp);                               /* pop ebp */
            ii(0x100b_7f10, 1); pop(edi);                               /* pop edi */
            ii(0x100b_7f11, 1); pop(esi);                               /* pop esi */
            ii(0x100b_7f12, 1); pop(edx);                               /* pop edx */
            ii(0x100b_7f13, 1); pop(ecx);                               /* pop ecx */
            ii(0x100b_7f14, 1); pop(ebx);                               /* pop ebx */
            ii(0x100b_7f15, 1); ret();                                  /* ret */
        }
    }
}
