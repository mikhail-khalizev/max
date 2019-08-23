using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1016_4980-c502b1ca")]
        public void Method_1016_4980()
        {
            ii(0x1016_4980, 1); push(ebx);                              /* push ebx */
            ii(0x1016_4981, 1); push(ecx);                              /* push ecx */
            ii(0x1016_4982, 1); push(edx);                              /* push edx */
            ii(0x1016_4983, 1); push(esi);                              /* push esi */
            ii(0x1016_4984, 1); push(edi);                              /* push edi */
            ii(0x1016_4985, 1); push(ebp);                              /* push ebp */
            ii(0x1016_4986, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1016_4988, 6); sub(esp, 0x4);                          /* sub esp, 0x4 */
            ii(0x1016_498e, 7); mov(memd[ss, ebp - 0x4], 0x5);          /* mov dword [ebp-0x4], 0x5 */
            ii(0x1016_4995, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1016_4998, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1016_499a, 1); pop(ebp);                               /* pop ebp */
            ii(0x1016_499b, 1); pop(edi);                               /* pop edi */
            ii(0x1016_499c, 1); pop(esi);                               /* pop esi */
            ii(0x1016_499d, 1); pop(edx);                               /* pop edx */
            ii(0x1016_499e, 1); pop(ecx);                               /* pop ecx */
            ii(0x1016_499f, 1); pop(ebx);                               /* pop ebx */
            ii(0x1016_49a0, 1); ret();                                  /* ret */
        }
    }
}
