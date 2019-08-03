using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("e5e76dbe-8f35-48c8-b4e5-1f9463b2f69f")]
        public void Method_1008_a6d4()
        {
            ii(0x1008_a6d4, 1); pushd(ebx);                             /* push ebx */
            ii(0x1008_a6d5, 1); pushd(ecx);                             /* push ecx */
            ii(0x1008_a6d6, 1); pushd(edx);                             /* push edx */
            ii(0x1008_a6d7, 1); pushd(esi);                             /* push esi */
            ii(0x1008_a6d8, 1); pushd(edi);                             /* push edi */
            ii(0x1008_a6d9, 1); pushd(ebp);                             /* push ebp */
            ii(0x1008_a6da, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1008_a6dc, 6); sub(esp, 0x4);                          /* sub esp, 0x4 */
            ii(0x1008_a6e2, 7); mov(memd_a32[ss, ebp - 0x4], 0xffff_ffff); /* mov dword [ebp-0x4], 0xffffffff */
            ii(0x1008_a6e9, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1008_a6ec, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1008_a6ee, 1); popd(ebp);                              /* pop ebp */
            ii(0x1008_a6ef, 1); popd(edi);                              /* pop edi */
            ii(0x1008_a6f0, 1); popd(esi);                              /* pop esi */
            ii(0x1008_a6f1, 1); popd(edx);                              /* pop edx */
            ii(0x1008_a6f2, 1); popd(ecx);                              /* pop ecx */
            ii(0x1008_a6f3, 1); popd(ebx);                              /* pop ebx */
            ii(0x1008_a6f4, 1); retd(); return;                         /* ret */
        }
    }
}
