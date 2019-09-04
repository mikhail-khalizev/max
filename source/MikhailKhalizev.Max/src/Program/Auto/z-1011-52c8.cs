using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1011_52c8-8c3c615b")]
        public void Method_1011_52c8()
        {
            ii(0x1011_52c8, 1); push(ebx);                              /* push ebx */
            ii(0x1011_52c9, 1); push(ecx);                              /* push ecx */
            ii(0x1011_52ca, 1); push(edx);                              /* push edx */
            ii(0x1011_52cb, 1); push(esi);                              /* push esi */
            ii(0x1011_52cc, 1); push(edi);                              /* push edi */
            ii(0x1011_52cd, 1); push(ebp);                              /* push ebp */
            ii(0x1011_52ce, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1011_52d0, 6); sub(esp, 4);                            /* sub esp, 0x4 */
            ii(0x1011_52d6, 3); mov(memd[ss, ebp - 4], eax);            /* mov [ebp-0x4], eax */
            ii(0x1011_52d9, 5); mov(edx, 0x101c_4e54);                  /* mov edx, 0x101c4e54 */
            ii(0x1011_52de, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1011_52e1, 5); call(0x100d_4d78, -0x4_056e);           /* call 0x100d4d78 */
            ii(0x1011_52e6, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1011_52e9, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1011_52eb, 1); pop(ebp);                               /* pop ebp */
            ii(0x1011_52ec, 1); pop(edi);                               /* pop edi */
            ii(0x1011_52ed, 1); pop(esi);                               /* pop esi */
            ii(0x1011_52ee, 1); pop(edx);                               /* pop edx */
            ii(0x1011_52ef, 1); pop(ecx);                               /* pop ecx */
            ii(0x1011_52f0, 1); pop(ebx);                               /* pop ebx */
            ii(0x1011_52f1, 1); ret();                                  /* ret */
        }
    }
}
