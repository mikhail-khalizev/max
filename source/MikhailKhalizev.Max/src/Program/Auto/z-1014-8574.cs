using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("9a0c4d71-caf7-44e9-b204-db6400ae14ee")]
        public void Method_1014_8574()
        {
            ii(0x1014_8574, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x1014_8579, 5); calld(Definitions.sys_check_available_stack_size, 0x1_d7d4); /* call 0x10165d52 */
            ii(0x1014_857e, 1); pushd(ebx);                             /* push ebx */
            ii(0x1014_857f, 1); pushd(ecx);                             /* push ecx */
            ii(0x1014_8580, 1); pushd(edx);                             /* push edx */
            ii(0x1014_8581, 1); pushd(esi);                             /* push esi */
            ii(0x1014_8582, 1); pushd(edi);                             /* push edi */
            ii(0x1014_8583, 1); pushd(ebp);                             /* push ebp */
            ii(0x1014_8584, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1014_8586, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x1014_858c, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1014_858f, 5); calld(0x1014_82f4, -0x2a0);             /* call 0x101482f4 */
            ii(0x1014_8594, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
        l_0x1014_8597:
            ii(0x1014_8597, 5); calld(0x1014_82f4, -0x2a8);             /* call 0x101482f4 */
            ii(0x1014_859c, 3); sub(eax, memd_a32[ss, ebp - 0x8]);      /* sub eax, [ebp-0x8] */
            ii(0x1014_859f, 3); cmp(eax, memd_a32[ss, ebp - 0x4]);      /* cmp eax, [ebp-0x4] */
            ii(0x1014_85a2, 2); if(jbd(0x1014_8597, -0xd)) goto l_0x1014_8597; /* jb 0x10148597 */
            ii(0x1014_85a4, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1014_85a6, 1); popd(ebp);                              /* pop ebp */
            ii(0x1014_85a7, 1); popd(edi);                              /* pop edi */
            ii(0x1014_85a8, 1); popd(esi);                              /* pop esi */
            ii(0x1014_85a9, 1); popd(edx);                              /* pop edx */
            ii(0x1014_85aa, 1); popd(ecx);                              /* pop ecx */
            ii(0x1014_85ab, 1); popd(ebx);                              /* pop ebx */
            ii(0x1014_85ac, 1); retd(); return;                         /* ret */
        }
    }
}
