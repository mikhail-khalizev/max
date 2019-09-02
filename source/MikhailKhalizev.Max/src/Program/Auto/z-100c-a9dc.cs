using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100c_a9dc-c502b1ca")]
        public void Method_100c_a9dc()
        {
            ii(0x100c_a9dc, 1); push(ebx);                              /* push ebx */
            ii(0x100c_a9dd, 1); push(ecx);                              /* push ecx */
            ii(0x100c_a9de, 1); push(edx);                              /* push edx */
            ii(0x100c_a9df, 1); push(esi);                              /* push esi */
            ii(0x100c_a9e0, 1); push(edi);                              /* push edi */
            ii(0x100c_a9e1, 1); push(ebp);                              /* push ebp */
            ii(0x100c_a9e2, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100c_a9e4, 6); sub(esp, 4);                            /* sub esp, 0x4 */
            ii(0x100c_a9ea, 7); mov(memd[ss, ebp - 4], 5);              /* mov dword [ebp-0x4], 0x5 */
            ii(0x100c_a9f1, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100c_a9f4, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100c_a9f6, 1); pop(ebp);                               /* pop ebp */
            ii(0x100c_a9f7, 1); pop(edi);                               /* pop edi */
            ii(0x100c_a9f8, 1); pop(esi);                               /* pop esi */
            ii(0x100c_a9f9, 1); pop(edx);                               /* pop edx */
            ii(0x100c_a9fa, 1); pop(ecx);                               /* pop ecx */
            ii(0x100c_a9fb, 1); pop(ebx);                               /* pop ebx */
            ii(0x100c_a9fc, 1); ret();                                  /* ret */
        }
    }
}
