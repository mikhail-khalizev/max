using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("ab90ab90-2903-41ea-9e41-2b5ab8d684fe")]
        public void Method_100e_86e8()
        {
            ii(0x100e_86e8, 1); pushd(ebx);                             /* push ebx */
            ii(0x100e_86e9, 1); pushd(ecx);                             /* push ecx */
            ii(0x100e_86ea, 1); pushd(edx);                             /* push edx */
            ii(0x100e_86eb, 1); pushd(esi);                             /* push esi */
            ii(0x100e_86ec, 1); pushd(edi);                             /* push edi */
            ii(0x100e_86ed, 1); pushd(ebp);                             /* push ebp */
            ii(0x100e_86ee, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100e_86f0, 6); sub(esp, 0x4);                          /* sub esp, 0x4 */
            ii(0x100e_86f6, 7); mov(memd_a32[ss, ebp - 0x4], 0xa);      /* mov dword [ebp-0x4], 0xa */
            ii(0x100e_86fd, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100e_8700, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100e_8702, 1); popd(ebp);                              /* pop ebp */
            ii(0x100e_8703, 1); popd(edi);                              /* pop edi */
            ii(0x100e_8704, 1); popd(esi);                              /* pop esi */
            ii(0x100e_8705, 1); popd(edx);                              /* pop edx */
            ii(0x100e_8706, 1); popd(ecx);                              /* pop ecx */
            ii(0x100e_8707, 1); popd(ebx);                              /* pop ebx */
            ii(0x100e_8708, 1); retd(); return;                         /* ret */
        }
    }
}
