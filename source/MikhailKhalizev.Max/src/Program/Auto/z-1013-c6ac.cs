using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1013_c6ac-951fc28f")]
        public void Method_1013_c6ac()
        {
            ii(0x1013_c6ac, 1); pushd(ebx);                             /* push ebx */
            ii(0x1013_c6ad, 1); pushd(ecx);                             /* push ecx */
            ii(0x1013_c6ae, 1); pushd(edx);                             /* push edx */
            ii(0x1013_c6af, 1); pushd(esi);                             /* push esi */
            ii(0x1013_c6b0, 1); pushd(edi);                             /* push edi */
            ii(0x1013_c6b1, 1); pushd(ebp);                             /* push ebp */
            ii(0x1013_c6b2, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1013_c6b4, 6); sub(esp, 0x4);                          /* sub esp, 0x4 */
            ii(0x1013_c6ba, 7); mov(memd_a32[ss, ebp - 0x4], 0x7fff);   /* mov dword [ebp-0x4], 0x7fff */
            ii(0x1013_c6c1, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1013_c6c4, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1013_c6c6, 1); popd(ebp);                              /* pop ebp */
            ii(0x1013_c6c7, 1); popd(edi);                              /* pop edi */
            ii(0x1013_c6c8, 1); popd(esi);                              /* pop esi */
            ii(0x1013_c6c9, 1); popd(edx);                              /* pop edx */
            ii(0x1013_c6ca, 1); popd(ecx);                              /* pop ecx */
            ii(0x1013_c6cb, 1); popd(ebx);                              /* pop ebx */
            ii(0x1013_c6cc, 1); retd();                                 /* ret */
        }
    }
}
