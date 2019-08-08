using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("7fd37849-c4b5-4732-a491-dff80b316b52")]
        public void my_string_clear()
        {
            ii(0x1014_1f15, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x1014_1f1a, 5); calld(Definitions.sys_check_available_stack_size, 0x2_3e33); /* call 0x10165d52 */
            ii(0x1014_1f1f, 1); pushd(ebx);                             /* push ebx */
            ii(0x1014_1f20, 1); pushd(ecx);                             /* push ecx */
            ii(0x1014_1f21, 1); pushd(edx);                             /* push edx */
            ii(0x1014_1f22, 1); pushd(esi);                             /* push esi */
            ii(0x1014_1f23, 1); pushd(edi);                             /* push edi */
            ii(0x1014_1f24, 1); pushd(ebp);                             /* push ebp */
            ii(0x1014_1f25, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1014_1f27, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x1014_1f2d, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1014_1f30, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_1f33, 5); calld(Definitions.my_string_make_single_ref, 0x424); /* call 0x1014235c */
            ii(0x1014_1f38, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_1f3b, 2); mov(eax, memd_a32[ds, eax]);            /* mov eax, [eax] */
            ii(0x1014_1f3d, 5); calld(Definitions.my_strobj_c_str, -0xb_8746); /* call 0x100897fc */
            ii(0x1014_1f42, 3); mov(memb_a32[ds, eax], 0);              /* mov byte [eax], 0x0 */
            ii(0x1014_1f45, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1014_1f47, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_1f4a, 2); mov(eax, memd_a32[ds, eax]);            /* mov eax, [eax] */
            ii(0x1014_1f4c, 5); calld(Definitions.my_strobj_set_len, 0x59b); /* call 0x101424ec */
            ii(0x1014_1f51, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_1f54, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1014_1f57, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_1f5a, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1014_1f5c, 1); popd(ebp);                              /* pop ebp */
            ii(0x1014_1f5d, 1); popd(edi);                              /* pop edi */
            ii(0x1014_1f5e, 1); popd(esi);                              /* pop esi */
            ii(0x1014_1f5f, 1); popd(edx);                              /* pop edx */
            ii(0x1014_1f60, 1); popd(ecx);                              /* pop ecx */
            ii(0x1014_1f61, 1); popd(ebx);                              /* pop ebx */
            ii(0x1014_1f62, 1); retd(); return;                         /* ret */
        }
    }
}
