using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("6cba9642-5a1a-44c9-b54b-3e2ff6ef6322")]
        public void Method_1009_ec0e()
        {
            ii(0x1009_ec0e, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x1009_ec13, 5); calld(Definitions.sys_check_available_stack_size, 0xc_713a); /* call 0x10165d52 */
            ii(0x1009_ec18, 1); pushd(ebx);                             /* push ebx */
            ii(0x1009_ec19, 1); pushd(ecx);                             /* push ecx */
            ii(0x1009_ec1a, 1); pushd(esi);                             /* push esi */
            ii(0x1009_ec1b, 1); pushd(edi);                             /* push edi */
            ii(0x1009_ec1c, 1); pushd(ebp);                             /* push ebp */
            ii(0x1009_ec1d, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1009_ec1f, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x1009_ec25, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1009_ec28, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x1009_ec2b, 5); mov(edx, StringDefinitions.ExploreMap); /* mov edx, 0x101a079e */
            ii(0x1009_ec30, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1009_ec33, 5); calld(Definitions.sys_strcpy, 0xc_7297); /* call 0x10165ecf */
            ii(0x1009_ec38, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1009_ec3b, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1009_ec3e, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1009_ec41, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1009_ec43, 1); popd(ebp);                              /* pop ebp */
            ii(0x1009_ec44, 1); popd(edi);                              /* pop edi */
            ii(0x1009_ec45, 1); popd(esi);                              /* pop esi */
            ii(0x1009_ec46, 1); popd(ecx);                              /* pop ecx */
            ii(0x1009_ec47, 1); popd(ebx);                              /* pop ebx */
            ii(0x1009_ec48, 1); retd(); return;                         /* ret */
        }
    }
}