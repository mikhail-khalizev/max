using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100c_ac68-44b9eb0e")]
        public void Method_100c_ac68()
        {
            ii(0x100c_ac68, 1); push(ebx);                              /* push ebx */
            ii(0x100c_ac69, 1); push(ecx);                              /* push ecx */
            ii(0x100c_ac6a, 1); push(edx);                              /* push edx */
            ii(0x100c_ac6b, 1); push(esi);                              /* push esi */
            ii(0x100c_ac6c, 1); push(edi);                              /* push edi */
            ii(0x100c_ac6d, 1); push(ebp);                              /* push ebp */
            ii(0x100c_ac6e, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100c_ac70, 6); sub(esp, 0x4);                          /* sub esp, 0x4 */
            ii(0x100c_ac76, 4); mov(memb[ss, ebp - 0x4], 0x1);          /* mov byte [ebp-0x4], 0x1 */
            ii(0x100c_ac7a, 3); mov(al, memb[ss, ebp - 0x4]);           /* mov al, [ebp-0x4] */
            ii(0x100c_ac7d, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100c_ac7f, 1); pop(ebp);                               /* pop ebp */
            ii(0x100c_ac80, 1); pop(edi);                               /* pop edi */
            ii(0x100c_ac81, 1); pop(esi);                               /* pop esi */
            ii(0x100c_ac82, 1); pop(edx);                               /* pop edx */
            ii(0x100c_ac83, 1); pop(ecx);                               /* pop ecx */
            ii(0x100c_ac84, 1); pop(ebx);                               /* pop ebx */
            ii(0x100c_ac85, 1); ret();                                  /* ret */
        }
    }
}
