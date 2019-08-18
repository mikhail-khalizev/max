using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("ceb658a6-3fc5-4a1c-9274-6e5dc824a9f3")]
        public void Method_1013_a0af()
        {
            ii(0x1013_a0af, 5); pushd(0x2c);                            /* push 0x2c */
            ii(0x1013_a0b4, 5); calld(Definitions.sys_check_available_stack_size, 0x2_bc99); /* call 0x10165d52 */
            ii(0x1013_a0b9, 1); pushd(ebx);                             /* push ebx */
            ii(0x1013_a0ba, 1); pushd(ecx);                             /* push ecx */
            ii(0x1013_a0bb, 1); pushd(edx);                             /* push edx */
            ii(0x1013_a0bc, 1); pushd(esi);                             /* push esi */
            ii(0x1013_a0bd, 1); pushd(edi);                             /* push edi */
            ii(0x1013_a0be, 1); pushd(ebp);                             /* push ebp */
            ii(0x1013_a0bf, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1013_a0c1, 6); sub(esp, 0x10);                         /* sub esp, 0x10 */
            ii(0x1013_a0c7, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1013_a0ca, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1013_a0cd, 3); add(eax, 0x2);                          /* add eax, 0x2 */
            ii(0x1013_a0d0, 5); calld(0x1007_6d58, -0xc_337d);          /* call 0x10076d58 */
            ii(0x1013_a0d5, 3); sub(eax, 0x2);                          /* sub eax, 0x2 */
            ii(0x1013_a0d8, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1013_a0db, 3); lea(eax, ebp - 0x4);                    /* lea eax, [ebp-0x4] */
            ii(0x1013_a0de, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1013_a0e1, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1013_a0e4, 3); add(eax, 0x6);                          /* add eax, 0x6 */
            ii(0x1013_a0e7, 5); calld(0x1007_6d58, -0xc_3394);          /* call 0x10076d58 */
            ii(0x1013_a0ec, 3); sub(eax, 0x6);                          /* sub eax, 0x6 */
            ii(0x1013_a0ef, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1013_a0f2, 3); lea(eax, ebp - 0x4);                    /* lea eax, [ebp-0x4] */
            ii(0x1013_a0f5, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1013_a0f8, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1013_a0fb, 5); mov(memw_a32[ds, eax], 0);              /* mov word [eax], 0x0 */
            ii(0x1013_a100, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1013_a103, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x1013_a106, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1013_a109, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1013_a10b, 1); popd(ebp);                              /* pop ebp */
            ii(0x1013_a10c, 1); popd(edi);                              /* pop edi */
            ii(0x1013_a10d, 1); popd(esi);                              /* pop esi */
            ii(0x1013_a10e, 1); popd(edx);                              /* pop edx */
            ii(0x1013_a10f, 1); popd(ecx);                              /* pop ecx */
            ii(0x1013_a110, 1); popd(ebx);                              /* pop ebx */
            ii(0x1013_a111, 1); retd(); return;                         /* ret */
        }
    }
}
