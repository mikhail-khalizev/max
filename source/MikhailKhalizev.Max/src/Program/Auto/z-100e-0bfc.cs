using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100e_0bfc-8c853063")]
        public void Method_100e_0bfc()
        {
            ii(0x100e_0bfc, 1); push(ebx);                              /* push ebx */
            ii(0x100e_0bfd, 1); push(ecx);                              /* push ecx */
            ii(0x100e_0bfe, 1); push(edx);                              /* push edx */
            ii(0x100e_0bff, 1); push(esi);                              /* push esi */
            ii(0x100e_0c00, 1); push(edi);                              /* push edi */
            ii(0x100e_0c01, 1); push(ebp);                              /* push ebp */
            ii(0x100e_0c02, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100e_0c04, 6); sub(esp, 0x4);                          /* sub esp, 0x4 */
            ii(0x100e_0c0a, 3); mov(memd[ss, ebp - 0x4], eax);          /* mov [ebp-0x4], eax */
            ii(0x100e_0c0d, 5); mov(edx, 0x101c_35a4);                  /* mov edx, 0x101c35a4 */
            ii(0x100e_0c12, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100e_0c15, 5); call(0x100d_4d78, -0xbea2);             /* call 0x100d4d78 */
            ii(0x100e_0c1a, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100e_0c1d, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100e_0c1f, 1); pop(ebp);                               /* pop ebp */
            ii(0x100e_0c20, 1); pop(edi);                               /* pop edi */
            ii(0x100e_0c21, 1); pop(esi);                               /* pop esi */
            ii(0x100e_0c22, 1); pop(edx);                               /* pop edx */
            ii(0x100e_0c23, 1); pop(ecx);                               /* pop ecx */
            ii(0x100e_0c24, 1); pop(ebx);                               /* pop ebx */
            ii(0x100e_0c25, 1); ret();                                  /* ret */
        }
    }
}
