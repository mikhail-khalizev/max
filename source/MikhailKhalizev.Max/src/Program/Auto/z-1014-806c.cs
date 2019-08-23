using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1014_806c-cf3c2e3d")]
        public void Method_1014_806c()
        {
            ii(0x1014_806c, 5); push(0x28);                             /* push 0x28 */
            ii(0x1014_8071, 5); call(Definitions.sys_check_available_stack_size, 0x1_dcdc); /* call 0x10165d52 */
            ii(0x1014_8076, 1); push(ebx);                              /* push ebx */
            ii(0x1014_8077, 1); push(ecx);                              /* push ecx */
            ii(0x1014_8078, 1); push(edx);                              /* push edx */
            ii(0x1014_8079, 1); push(esi);                              /* push esi */
            ii(0x1014_807a, 1); push(edi);                              /* push edi */
            ii(0x1014_807b, 1); push(ebp);                              /* push ebp */
            ii(0x1014_807c, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1014_807e, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x1014_8084, 3); mov(memd[ss, ebp - 0x4], eax);          /* mov [ebp-0x4], eax */
            ii(0x1014_8087, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1014_808a, 5); call(Definitions.my_ctor_0x101b_6edc, -0xd_124b); /* call 0x10076e44 */
            ii(0x1014_808f, 3); mov(memd[ss, ebp - 0x4], eax);          /* mov [ebp-0x4], eax */
            ii(0x1014_8092, 3); lea(eax, ebp - 0x4);                    /* lea eax, [ebp-0x4] */
            ii(0x1014_8095, 3); mov(memd[ss, ebp - 0x8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1014_8098, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1014_809b, 3); mov(memd[ss, ebp - 0xc], eax);          /* mov [ebp-0xc], eax */
            ii(0x1014_809e, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x1014_80a1, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1014_80a3, 1); pop(ebp);                               /* pop ebp */
            ii(0x1014_80a4, 1); pop(edi);                               /* pop edi */
            ii(0x1014_80a5, 1); pop(esi);                               /* pop esi */
            ii(0x1014_80a6, 1); pop(edx);                               /* pop edx */
            ii(0x1014_80a7, 1); pop(ecx);                               /* pop ecx */
            ii(0x1014_80a8, 1); pop(ebx);                               /* pop ebx */
            ii(0x1014_80a9, 1); ret();                                  /* ret */
        }
    }
}
