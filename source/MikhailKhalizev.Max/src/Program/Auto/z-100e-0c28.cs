using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100e_0c28-fb7c5d90")]
        public void Method_100e_0c28()
        {
            ii(0x100e_0c28, 1); push(ebx);                              /* push ebx */
            ii(0x100e_0c29, 1); push(ecx);                              /* push ecx */
            ii(0x100e_0c2a, 1); push(edx);                              /* push edx */
            ii(0x100e_0c2b, 1); push(esi);                              /* push esi */
            ii(0x100e_0c2c, 1); push(edi);                              /* push edi */
            ii(0x100e_0c2d, 1); push(ebp);                              /* push ebp */
            ii(0x100e_0c2e, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100e_0c30, 6); sub(esp, 4);                            /* sub esp, 0x4 */
            ii(0x100e_0c36, 3); mov(memd[ss, ebp - 4], eax);            /* mov [ebp-0x4], eax */
            ii(0x100e_0c39, 5); mov(edx, 0x101c_3678);                  /* mov edx, 0x101c3678 */
            ii(0x100e_0c3e, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100e_0c41, 5); call(0x100d_4d78, -0xbece);             /* call 0x100d4d78 */
            ii(0x100e_0c46, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100e_0c49, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100e_0c4b, 1); pop(ebp);                               /* pop ebp */
            ii(0x100e_0c4c, 1); pop(edi);                               /* pop edi */
            ii(0x100e_0c4d, 1); pop(esi);                               /* pop esi */
            ii(0x100e_0c4e, 1); pop(edx);                               /* pop edx */
            ii(0x100e_0c4f, 1); pop(ecx);                               /* pop ecx */
            ii(0x100e_0c50, 1); pop(ebx);                               /* pop ebx */
            ii(0x100e_0c51, 1); ret();                                  /* ret */
        }
    }
}
