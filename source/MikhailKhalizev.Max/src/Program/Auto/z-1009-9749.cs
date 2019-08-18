using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1009_9749-720ceabb")]
        public void Method_1009_9749()
        {
            ii(0x1009_9749, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x1009_974e, 5); calld(Definitions.sys_check_available_stack_size, 0xc_c5ff); /* call 0x10165d52 */
            ii(0x1009_9753, 1); pushd(ebx);                             /* push ebx */
            ii(0x1009_9754, 1); pushd(ecx);                             /* push ecx */
            ii(0x1009_9755, 1); pushd(esi);                             /* push esi */
            ii(0x1009_9756, 1); pushd(edi);                             /* push edi */
            ii(0x1009_9757, 1); pushd(ebp);                             /* push ebp */
            ii(0x1009_9758, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1009_975a, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x1009_9760, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1009_9763, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x1009_9766, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1009_9769, 3); mov(eax, memd_a32[ds, eax + 0x15]);     /* mov eax, [eax+0x15] */
            ii(0x1009_976c, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1009_976f, 3); imul(eax, eax, 0x33);                   /* imul eax, eax, 0x33 */
            ii(0x1009_9772, 6); mov(edx, memd_a32[ds, eax + 0x101c_81d7]); /* mov edx, [eax+0x101c81d7] */
            ii(0x1009_9778, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1009_977b, 5); calld(Definitions.sys_strcpy, 0xc_c74f); /* call 0x10165ecf */
            ii(0x1009_9780, 5); mov(edx, StringDefinitions.DefenseAssistant); /* mov edx, 0x101a066b */
            ii(0x1009_9785, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1009_9788, 5); calld(Definitions.sys_strcat, 0xc_c7a4); /* call 0x10165f31 */
            ii(0x1009_978d, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1009_9790, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1009_9793, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1009_9796, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1009_9798, 1); popd(ebp);                              /* pop ebp */
            ii(0x1009_9799, 1); popd(edi);                              /* pop edi */
            ii(0x1009_979a, 1); popd(esi);                              /* pop esi */
            ii(0x1009_979b, 1); popd(ecx);                              /* pop ecx */
            ii(0x1009_979c, 1); popd(ebx);                              /* pop ebx */
            ii(0x1009_979d, 1); retd(); return;                         /* ret */
        }
    }
}
