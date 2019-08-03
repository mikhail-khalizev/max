using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("a197ea3b-35c7-402d-abfb-a7165b8e633c")]
        public void Method_100e_047c()
        {
            ii(0x100e_047c, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x100e_0481, 5); calld(Definitions.sys_check_available_stack_size, 0x858cc); /* call 0x10165d52 */
            ii(0x100e_0486, 1); pushd(ebx);                             /* push ebx */
            ii(0x100e_0487, 1); pushd(ecx);                             /* push ecx */
            ii(0x100e_0488, 1); pushd(edx);                             /* push edx */
            ii(0x100e_0489, 1); pushd(esi);                             /* push esi */
            ii(0x100e_048a, 1); pushd(edi);                             /* push edi */
            ii(0x100e_048b, 1); pushd(ebp);                             /* push ebp */
            ii(0x100e_048c, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100e_048e, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x100e_0494, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x100e_0497, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100e_049a, 5); calld(0x1007_6c30, -0x6986f);           /* call 0x10076c30 */
            ii(0x100e_049f, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100e_04a2, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100e_04a5, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100e_04a7, 1); popd(ebp);                              /* pop ebp */
            ii(0x100e_04a8, 1); popd(edi);                              /* pop edi */
            ii(0x100e_04a9, 1); popd(esi);                              /* pop esi */
            ii(0x100e_04aa, 1); popd(edx);                              /* pop edx */
            ii(0x100e_04ab, 1); popd(ecx);                              /* pop ecx */
            ii(0x100e_04ac, 1); popd(ebx);                              /* pop ebx */
            ii(0x100e_04ad, 1); retd(); return;                         /* ret */
        }
    }
}