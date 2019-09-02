using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100c_aef4-b70b8a0f")]
        public void Method_100c_aef4()
        {
            ii(0x100c_aef4, 1); push(ebx);                              /* push ebx */
            ii(0x100c_aef5, 1); push(ecx);                              /* push ecx */
            ii(0x100c_aef6, 1); push(edx);                              /* push edx */
            ii(0x100c_aef7, 1); push(esi);                              /* push esi */
            ii(0x100c_aef8, 1); push(edi);                              /* push edi */
            ii(0x100c_aef9, 1); push(ebp);                              /* push ebp */
            ii(0x100c_aefa, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100c_aefc, 6); sub(esp, 4);                            /* sub esp, 0x4 */
            ii(0x100c_af02, 4); mov(memb[ss, ebp - 4], 0);              /* mov byte [ebp-0x4], 0x0 */
            ii(0x100c_af06, 3); mov(al, memb[ss, ebp - 4]);             /* mov al, [ebp-0x4] */
            ii(0x100c_af09, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100c_af0b, 1); pop(ebp);                               /* pop ebp */
            ii(0x100c_af0c, 1); pop(edi);                               /* pop edi */
            ii(0x100c_af0d, 1); pop(esi);                               /* pop esi */
            ii(0x100c_af0e, 1); pop(edx);                               /* pop edx */
            ii(0x100c_af0f, 1); pop(ecx);                               /* pop ecx */
            ii(0x100c_af10, 1); pop(ebx);                               /* pop ebx */
            ii(0x100c_af11, 1); ret();                                  /* ret */
        }
    }
}
