using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1012_336c-51075990")]
        public void Method_1012_336c()
        {
            ii(0x1012_336c, 1); push(ebx);                              /* push ebx */
            ii(0x1012_336d, 1); push(ecx);                              /* push ecx */
            ii(0x1012_336e, 1); push(edx);                              /* push edx */
            ii(0x1012_336f, 1); push(esi);                              /* push esi */
            ii(0x1012_3370, 1); push(edi);                              /* push edi */
            ii(0x1012_3371, 1); push(ebp);                              /* push ebp */
            ii(0x1012_3372, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1012_3374, 6); sub(esp, 0x4);                          /* sub esp, 0x4 */
            ii(0x1012_337a, 3); mov(memd[ss, ebp - 0x4], eax);          /* mov [ebp-0x4], eax */
            ii(0x1012_337d, 5); mov(edx, 0x101c_3678);                  /* mov edx, 0x101c3678 */
            ii(0x1012_3382, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1012_3385, 5); call(0x100d_4d78, -0x4_e612);           /* call 0x100d4d78 */
            ii(0x1012_338a, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1012_338d, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1012_338f, 1); pop(ebp);                               /* pop ebp */
            ii(0x1012_3390, 1); pop(edi);                               /* pop edi */
            ii(0x1012_3391, 1); pop(esi);                               /* pop esi */
            ii(0x1012_3392, 1); pop(edx);                               /* pop edx */
            ii(0x1012_3393, 1); pop(ecx);                               /* pop ecx */
            ii(0x1012_3394, 1); pop(ebx);                               /* pop ebx */
            ii(0x1012_3395, 1); ret();                                  /* ret */
        }
    }
}
