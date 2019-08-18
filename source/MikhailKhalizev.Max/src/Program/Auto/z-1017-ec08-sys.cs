using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1017_ec08-65805b6d")]
        public void /* sys */ Method_1017_ec08()
        {
            ii(0x1017_ec08, 1); pushd(ebx);                             /* push ebx */
            ii(0x1017_ec09, 1); pushd(ecx);                             /* push ecx */
            ii(0x1017_ec0a, 1); pushd(edx);                             /* push edx */
            ii(0x1017_ec0b, 1); pushd(esi);                             /* push esi */
            ii(0x1017_ec0c, 1); pushd(edi);                             /* push edi */
            ii(0x1017_ec0d, 1); pushd(ebp);                             /* push ebp */
            ii(0x1017_ec0e, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1017_ec10, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x1017_ec16, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1017_ec19, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1017_ec1c, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x1017_ec1f, 6); mov(eax, memd_a32[ds, eax + 0x101b_e4f4]); /* mov eax, [eax+0x101be4f4] */
            ii(0x1017_ec25, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1017_ec28, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1017_ec2b, 1); leaved();                               /* leave */
            ii(0x1017_ec2c, 1); popd(edi);                              /* pop edi */
            ii(0x1017_ec2d, 1); popd(esi);                              /* pop esi */
            ii(0x1017_ec2e, 1); popd(edx);                              /* pop edx */
            ii(0x1017_ec2f, 1); popd(ecx);                              /* pop ecx */
            ii(0x1017_ec30, 1); popd(ebx);                              /* pop ebx */
            ii(0x1017_ec31, 1); retd(); return;                         /* ret */
        }
    }
}
