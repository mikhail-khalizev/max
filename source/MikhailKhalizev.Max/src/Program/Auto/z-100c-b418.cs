using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("09287e2c-78f4-4474-a89d-362113bfe24a")]
        public void Method_100c_b418()
        {
            ii(0x100c_b418, 5); pushd(0x28);                            /* push 0x28 */
            ii(0x100c_b41d, 5); calld(Definitions.sys_check_available_stack_size, 0x9_a930); /* call 0x10165d52 */
            ii(0x100c_b422, 1); pushd(ebx);                             /* push ebx */
            ii(0x100c_b423, 1); pushd(ecx);                             /* push ecx */
            ii(0x100c_b424, 1); pushd(esi);                             /* push esi */
            ii(0x100c_b425, 1); pushd(edi);                             /* push edi */
            ii(0x100c_b426, 1); pushd(ebp);                             /* push ebp */
            ii(0x100c_b427, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100c_b429, 6); sub(esp, 0x10);                         /* sub esp, 0x10 */
            ii(0x100c_b42f, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100c_b432, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x100c_b435, 5); mov(ebx, 0x4);                          /* mov ebx, 0x4 */
            ii(0x100c_b43a, 4); movsx(edx, memw_a32[ss, ebp - 0x4]);    /* movsx edx, word [ebp-0x4] */
            ii(0x100c_b43e, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100c_b441, 5); calld(0x1013_af3b, 0x6_faf5);           /* call 0x1013af3b */
            ii(0x100c_b446, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100c_b449, 3); lea(eax, ebp - 0x8);                    /* lea eax, [ebp-0x8] */
            ii(0x100c_b44c, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x100c_b44f, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100c_b452, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x100c_b455, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x100c_b458, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100c_b45a, 1); popd(ebp);                              /* pop ebp */
            ii(0x100c_b45b, 1); popd(edi);                              /* pop edi */
            ii(0x100c_b45c, 1); popd(esi);                              /* pop esi */
            ii(0x100c_b45d, 1); popd(ecx);                              /* pop ecx */
            ii(0x100c_b45e, 1); popd(ebx);                              /* pop ebx */
            ii(0x100c_b45f, 1); retd(); return;                         /* ret */
        }
    }
}
