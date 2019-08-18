using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1012_b658-7a24420")]
        public void Method_1012_b658()
        {
            ii(0x1012_b658, 5); pushd(0x38);                            /* push 0x38 */
            ii(0x1012_b65d, 5); calld(Definitions.sys_check_available_stack_size, 0x3_a6f0); /* call 0x10165d52 */
            ii(0x1012_b662, 1); pushd(esi);                             /* push esi */
            ii(0x1012_b663, 1); pushd(edi);                             /* push edi */
            ii(0x1012_b664, 1); pushd(ebp);                             /* push ebp */
            ii(0x1012_b665, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1012_b667, 6); sub(esp, 0x1c);                         /* sub esp, 0x1c */
            ii(0x1012_b66d, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x1012_b670, 3); mov(memd_a32[ss, ebp - 0x8], edx);      /* mov [ebp-0x8], edx */
            ii(0x1012_b673, 3); mov(memd_a32[ss, ebp - 0x4], ebx);      /* mov [ebp-0x4], ebx */
            ii(0x1012_b676, 3); mov(memd_a32[ss, ebp - 0xc], ecx);      /* mov [ebp-0xc], ecx */
            ii(0x1012_b679, 4); movsx(eax, memw_a32[ss, ebp - 0x8]);    /* movsx eax, word [ebp-0x8] */
            ii(0x1012_b67d, 1); pushd(eax);                             /* push eax */
            ii(0x1012_b67e, 5); mov(eax, StringDefinitions.I3);         /* mov eax, 0x101a86d4 */
            ii(0x1012_b683, 1); pushd(eax);                             /* push eax */
            ii(0x1012_b684, 3); lea(eax, ebp - 0x1c);                   /* lea eax, [ebp-0x1c] */
            ii(0x1012_b687, 1); pushd(eax);                             /* push eax */
            ii(0x1012_b688, 5); calld(Definitions.sys_sprintf, 0x3_a874); /* call 0x10165f01 */
            ii(0x1012_b68d, 3); add(esp, 0xc);                          /* add esp, 0xc */
            ii(0x1012_b690, 3); mov(eax, memd_a32[ss, ebp + 0x10]);     /* mov eax, [ebp+0x10] */
            ii(0x1012_b693, 1); pushd(eax);                             /* push eax */
            ii(0x1012_b694, 4); movsx(ecx, memw_a32[ss, ebp - 0xc]);    /* movsx ecx, word [ebp-0xc] */
            ii(0x1012_b698, 4); movsx(ebx, memw_a32[ss, ebp - 0x4]);    /* movsx ebx, word [ebp-0x4] */
            ii(0x1012_b69c, 3); lea(edx, ebp - 0x1c);                   /* lea edx, [ebp-0x1c] */
            ii(0x1012_b69f, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1012_b6a2, 5); calld(0x1012_b5fc, -0xab);              /* call 0x1012b5fc */
            ii(0x1012_b6a7, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1012_b6a9, 1); popd(ebp);                              /* pop ebp */
            ii(0x1012_b6aa, 1); popd(edi);                              /* pop edi */
            ii(0x1012_b6ab, 1); popd(esi);                              /* pop esi */
            ii(0x1012_b6ac, 3); retd(0x4); return;                      /* ret 0x4 */
        }
    }
}
