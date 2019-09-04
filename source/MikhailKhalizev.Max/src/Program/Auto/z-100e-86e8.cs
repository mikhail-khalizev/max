using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100e_86e8-26cc5da5")]
        public void Method_100e_86e8()
        {
            ii(0x100e_86e8, 1); push(ebx);                              /* push ebx */
            ii(0x100e_86e9, 1); push(ecx);                              /* push ecx */
            ii(0x100e_86ea, 1); push(edx);                              /* push edx */
            ii(0x100e_86eb, 1); push(esi);                              /* push esi */
            ii(0x100e_86ec, 1); push(edi);                              /* push edi */
            ii(0x100e_86ed, 1); push(ebp);                              /* push ebp */
            ii(0x100e_86ee, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100e_86f0, 6); sub(esp, 4);                            /* sub esp, 0x4 */
            ii(0x100e_86f6, 7); mov(memd[ss, ebp - 4], 0xa);            /* mov dword [ebp-0x4], 0xa */
            ii(0x100e_86fd, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100e_8700, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100e_8702, 1); pop(ebp);                               /* pop ebp */
            ii(0x100e_8703, 1); pop(edi);                               /* pop edi */
            ii(0x100e_8704, 1); pop(esi);                               /* pop esi */
            ii(0x100e_8705, 1); pop(edx);                               /* pop edx */
            ii(0x100e_8706, 1); pop(ecx);                               /* pop ecx */
            ii(0x100e_8707, 1); pop(ebx);                               /* pop ebx */
            ii(0x100e_8708, 1); ret();                                  /* ret */
        }
    }
}
