using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("fc35c8f4-f562-44cd-8ffc-44a11086b123")]
        public void Method_1008_9aac()
        {
            ii(0x1008_9aac, 1); pushd(ebx);                             /* push ebx */
            ii(0x1008_9aad, 1); pushd(ecx);                             /* push ecx */
            ii(0x1008_9aae, 1); pushd(edx);                             /* push edx */
            ii(0x1008_9aaf, 1); pushd(esi);                             /* push esi */
            ii(0x1008_9ab0, 1); pushd(edi);                             /* push edi */
            ii(0x1008_9ab1, 1); pushd(ebp);                             /* push ebp */
            ii(0x1008_9ab2, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1008_9ab4, 6); sub(esp, 0x4);                          /* sub esp, 0x4 */
            ii(0x1008_9aba, 4); mov(memb_a32[ss, ebp - 0x4], 0x1);      /* mov byte [ebp-0x4], 0x1 */
            ii(0x1008_9abe, 3); mov(al, memb_a32[ss, ebp - 0x4]);       /* mov al, [ebp-0x4] */
            ii(0x1008_9ac1, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1008_9ac3, 1); popd(ebp);                              /* pop ebp */
            ii(0x1008_9ac4, 1); popd(edi);                              /* pop edi */
            ii(0x1008_9ac5, 1); popd(esi);                              /* pop esi */
            ii(0x1008_9ac6, 1); popd(edx);                              /* pop edx */
            ii(0x1008_9ac7, 1); popd(ecx);                              /* pop ecx */
            ii(0x1008_9ac8, 1); popd(ebx);                              /* pop ebx */
            ii(0x1008_9ac9, 1); retd(); return;                         /* ret */
        }
    }
}