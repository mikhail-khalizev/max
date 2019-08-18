using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("bb3f6a09-ea8b-4b71-9273-b5729f34e613")]
        public void Method_100d_52a8()
        {
            ii(0x100d_52a8, 1); pushd(ebx);                             /* push ebx */
            ii(0x100d_52a9, 1); pushd(ecx);                             /* push ecx */
            ii(0x100d_52aa, 1); pushd(edx);                             /* push edx */
            ii(0x100d_52ab, 1); pushd(esi);                             /* push esi */
            ii(0x100d_52ac, 1); pushd(edi);                             /* push edi */
            ii(0x100d_52ad, 1); pushd(ebp);                             /* push ebp */
            ii(0x100d_52ae, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100d_52b0, 6); sub(esp, 0x4);                          /* sub esp, 0x4 */
            ii(0x100d_52b6, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x100d_52b9, 5); mov(edx, 0x101c_3678);                  /* mov edx, 0x101c3678 */
            ii(0x100d_52be, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100d_52c1, 5); calld(0x100d_4d78, -0x54e);             /* call 0x100d4d78 */
            ii(0x100d_52c6, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100d_52c9, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100d_52cb, 1); popd(ebp);                              /* pop ebp */
            ii(0x100d_52cc, 1); popd(edi);                              /* pop edi */
            ii(0x100d_52cd, 1); popd(esi);                              /* pop esi */
            ii(0x100d_52ce, 1); popd(edx);                              /* pop edx */
            ii(0x100d_52cf, 1); popd(ecx);                              /* pop ecx */
            ii(0x100d_52d0, 1); popd(ebx);                              /* pop ebx */
            ii(0x100d_52d1, 1); retd(); return;                         /* ret */
        }
    }
}
