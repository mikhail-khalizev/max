using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("d4387ee8-825b-47ed-8171-23d2a326bbfc")]
        public void Method_100d_533c()
        {
            ii(0x100d_533c, 1); pushd(ebx);                             /* push ebx */
            ii(0x100d_533d, 1); pushd(ecx);                             /* push ecx */
            ii(0x100d_533e, 1); pushd(edx);                             /* push edx */
            ii(0x100d_533f, 1); pushd(esi);                             /* push esi */
            ii(0x100d_5340, 1); pushd(edi);                             /* push edi */
            ii(0x100d_5341, 1); pushd(ebp);                             /* push ebp */
            ii(0x100d_5342, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100d_5344, 6); sub(esp, 0x4);                          /* sub esp, 0x4 */
            ii(0x100d_534a, 7); mov(memd_a32[ss, ebp - 0x4], 0xffff_ffff); /* mov dword [ebp-0x4], 0xffffffff */
            ii(0x100d_5351, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100d_5354, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100d_5356, 1); popd(ebp);                              /* pop ebp */
            ii(0x100d_5357, 1); popd(edi);                              /* pop edi */
            ii(0x100d_5358, 1); popd(esi);                              /* pop esi */
            ii(0x100d_5359, 1); popd(edx);                              /* pop edx */
            ii(0x100d_535a, 1); popd(ecx);                              /* pop ecx */
            ii(0x100d_535b, 1); popd(ebx);                              /* pop ebx */
            ii(0x100d_535c, 1); retd(); return;                         /* ret */
        }
    }
}
