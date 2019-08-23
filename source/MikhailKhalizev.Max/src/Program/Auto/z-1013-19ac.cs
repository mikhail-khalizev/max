using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1013_19ac-951fc28f")]
        public void Method_1013_19ac()
        {
            ii(0x1013_19ac, 1); pushd(ebx);                             /* push ebx */
            ii(0x1013_19ad, 1); pushd(ecx);                             /* push ecx */
            ii(0x1013_19ae, 1); pushd(edx);                             /* push edx */
            ii(0x1013_19af, 1); pushd(esi);                             /* push esi */
            ii(0x1013_19b0, 1); pushd(edi);                             /* push edi */
            ii(0x1013_19b1, 1); pushd(ebp);                             /* push ebp */
            ii(0x1013_19b2, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1013_19b4, 6); sub(esp, 0x4);                          /* sub esp, 0x4 */
            ii(0x1013_19ba, 7); mov(memd_a32[ss, ebp - 0x4], 0x7fff);   /* mov dword [ebp-0x4], 0x7fff */
            ii(0x1013_19c1, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1013_19c4, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1013_19c6, 1); popd(ebp);                              /* pop ebp */
            ii(0x1013_19c7, 1); popd(edi);                              /* pop edi */
            ii(0x1013_19c8, 1); popd(esi);                              /* pop esi */
            ii(0x1013_19c9, 1); popd(edx);                              /* pop edx */
            ii(0x1013_19ca, 1); popd(ecx);                              /* pop ecx */
            ii(0x1013_19cb, 1); popd(ebx);                              /* pop ebx */
            ii(0x1013_19cc, 1); retd();                                 /* ret */
        }
    }
}
