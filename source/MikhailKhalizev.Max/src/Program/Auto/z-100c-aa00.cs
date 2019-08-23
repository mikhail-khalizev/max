using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100c_aa00-b70b8a0f")]
        public void Method_100c_aa00()
        {
            ii(0x100c_aa00, 1); push(ebx);                              /* push ebx */
            ii(0x100c_aa01, 1); push(ecx);                              /* push ecx */
            ii(0x100c_aa02, 1); push(edx);                              /* push edx */
            ii(0x100c_aa03, 1); push(esi);                              /* push esi */
            ii(0x100c_aa04, 1); push(edi);                              /* push edi */
            ii(0x100c_aa05, 1); push(ebp);                              /* push ebp */
            ii(0x100c_aa06, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100c_aa08, 6); sub(esp, 0x4);                          /* sub esp, 0x4 */
            ii(0x100c_aa0e, 4); mov(memb[ss, ebp - 0x4], 0);            /* mov byte [ebp-0x4], 0x0 */
            ii(0x100c_aa12, 3); mov(al, memb[ss, ebp - 0x4]);           /* mov al, [ebp-0x4] */
            ii(0x100c_aa15, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100c_aa17, 1); pop(ebp);                               /* pop ebp */
            ii(0x100c_aa18, 1); pop(edi);                               /* pop edi */
            ii(0x100c_aa19, 1); pop(esi);                               /* pop esi */
            ii(0x100c_aa1a, 1); pop(edx);                               /* pop edx */
            ii(0x100c_aa1b, 1); pop(ecx);                               /* pop ecx */
            ii(0x100c_aa1c, 1); pop(ebx);                               /* pop ebx */
            ii(0x100c_aa1d, 1); ret();                                  /* ret */
        }
    }
}
