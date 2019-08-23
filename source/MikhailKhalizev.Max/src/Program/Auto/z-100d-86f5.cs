using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100d_86f5-a1bfb29a")]
        public void Method_100d_86f5()
        {
            ii(0x100d_86f5, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x100d_86fa, 5); calld(Definitions.sys_check_available_stack_size, 0x8_d653); /* call 0x10165d52 */
            ii(0x100d_86ff, 1); pushd(ebx);                             /* push ebx */
            ii(0x100d_8700, 1); pushd(ecx);                             /* push ecx */
            ii(0x100d_8701, 1); pushd(edx);                             /* push edx */
            ii(0x100d_8702, 1); pushd(esi);                             /* push esi */
            ii(0x100d_8703, 1); pushd(edi);                             /* push edi */
            ii(0x100d_8704, 1); pushd(ebp);                             /* push ebp */
            ii(0x100d_8705, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100d_8707, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x100d_870d, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x100d_8710, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100d_8713, 5); calld(0x100d_85c2, -0x156);             /* call 0x100d85c2 */
            ii(0x100d_8718, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100d_871b, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100d_871e, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100d_8720, 1); popd(ebp);                              /* pop ebp */
            ii(0x100d_8721, 1); popd(edi);                              /* pop edi */
            ii(0x100d_8722, 1); popd(esi);                              /* pop esi */
            ii(0x100d_8723, 1); popd(edx);                              /* pop edx */
            ii(0x100d_8724, 1); popd(ecx);                              /* pop ecx */
            ii(0x100d_8725, 1); popd(ebx);                              /* pop ebx */
            ii(0x100d_8726, 1); retd();                                 /* ret */
        }
    }
}
