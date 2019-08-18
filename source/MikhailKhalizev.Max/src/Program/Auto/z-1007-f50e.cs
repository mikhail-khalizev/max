using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1007_f50e-a3dc1b9a")]
        public void Method_1007_f50e()
        {
            ii(0x1007_f50e, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x1007_f513, 5); calld(Definitions.sys_check_available_stack_size, 0xe_683a); /* call 0x10165d52 */
            ii(0x1007_f518, 1); pushd(ebx);                             /* push ebx */
            ii(0x1007_f519, 1); pushd(ecx);                             /* push ecx */
            ii(0x1007_f51a, 1); pushd(edx);                             /* push edx */
            ii(0x1007_f51b, 1); pushd(esi);                             /* push esi */
            ii(0x1007_f51c, 1); pushd(edi);                             /* push edi */
            ii(0x1007_f51d, 1); pushd(ebp);                             /* push ebp */
            ii(0x1007_f51e, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1007_f520, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x1007_f526, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1007_f529, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1007_f52c, 3); add(eax, 0x18);                         /* add eax, 0x18 */
            ii(0x1007_f52f, 5); calld(0x1013_a794, 0xb_b260);           /* call 0x1013a794 */
            ii(0x1007_f534, 3); lea(edx, eax - 0x6);                    /* lea edx, [eax-0x6] */
            ii(0x1007_f537, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1007_f53a, 3); add(eax, 0x22);                         /* add eax, 0x22 */
            ii(0x1007_f53d, 5); calld(0x1013_a794, 0xb_b252);           /* call 0x1013a794 */
            ii(0x1007_f542, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1007_f544, 3); sub(eax, 0xa);                          /* sub eax, 0xa */
            ii(0x1007_f547, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1007_f54a, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1007_f54d, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1007_f54f, 1); popd(ebp);                              /* pop ebp */
            ii(0x1007_f550, 1); popd(edi);                              /* pop edi */
            ii(0x1007_f551, 1); popd(esi);                              /* pop esi */
            ii(0x1007_f552, 1); popd(edx);                              /* pop edx */
            ii(0x1007_f553, 1); popd(ecx);                              /* pop ecx */
            ii(0x1007_f554, 1); popd(ebx);                              /* pop ebx */
            ii(0x1007_f555, 1); retd(); return;                         /* ret */
        }
    }
}
