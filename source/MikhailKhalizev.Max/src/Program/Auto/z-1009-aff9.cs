using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("c25235d4-2b58-4bc1-bb0c-f7a9d4af2e70")]
        public void Method_1009_aff9()
        {
            ii(0x1009_aff9, 5); pushd(0x2c);                            /* push 0x2c */
            ii(0x1009_affe, 5); calld(Definitions.sys_check_available_stack_size, 0xcad4f); /* call 0x10165d52 */
            ii(0x1009_b003, 1); pushd(ebx);                             /* push ebx */
            ii(0x1009_b004, 1); pushd(ecx);                             /* push ecx */
            ii(0x1009_b005, 1); pushd(esi);                             /* push esi */
            ii(0x1009_b006, 1); pushd(edi);                             /* push edi */
            ii(0x1009_b007, 1); pushd(ebp);                             /* push ebp */
            ii(0x1009_b008, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1009_b00a, 6); sub(esp, 0x14);                         /* sub esp, 0x14 */
            ii(0x1009_b010, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1009_b013, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x1009_b016, 5); mov(ecx, 0x2100);                       /* mov ecx, 0x2100 */
            ii(0x1009_b01b, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x1009_b01d, 4); movsx(edx, memw_a32[ss, ebp - 0x4]);    /* movsx edx, word [ebp-0x4] */
            ii(0x1009_b021, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1009_b024, 5); calld(0x100a_26d1, 0x76a8);             /* call 0x100a26d1 */
            ii(0x1009_b029, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1009_b02c, 3); lea(eax, ebp - 0x8);                    /* lea eax, [ebp-0x8] */
            ii(0x1009_b02f, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1009_b032, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1009_b035, 3); add(eax, 0x13);                         /* add eax, 0x13 */
            ii(0x1009_b038, 5); calld(Definitions.my_ctor_0x101b56fc, -0x123c1); /* call 0x10088c7c */
            ii(0x1009_b03d, 3); sub(eax, 0x13);                         /* sub eax, 0x13 */
            ii(0x1009_b040, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1009_b043, 3); lea(eax, ebp - 0x8);                    /* lea eax, [ebp-0x8] */
            ii(0x1009_b046, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x1009_b049, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1009_b04c, 7); mov(memd_a32[ds, eax + 0x2], 0x101b_41e8); /* mov dword [eax+0x2], 0x101b41e8 */
            ii(0x1009_b053, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1009_b056, 4); mov(memb_a32[ds, eax + 0x1d], 0);       /* mov byte [eax+0x1d], 0x0 */
            ii(0x1009_b05a, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1009_b05d, 3); mov(memd_a32[ss, ebp - 0x14], eax);     /* mov [ebp-0x14], eax */
            ii(0x1009_b060, 3); mov(eax, memd_a32[ss, ebp - 0x14]);     /* mov eax, [ebp-0x14] */
            ii(0x1009_b063, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1009_b065, 1); popd(ebp);                              /* pop ebp */
            ii(0x1009_b066, 1); popd(edi);                              /* pop edi */
            ii(0x1009_b067, 1); popd(esi);                              /* pop esi */
            ii(0x1009_b068, 1); popd(ecx);                              /* pop ecx */
            ii(0x1009_b069, 1); popd(ebx);                              /* pop ebx */
            ii(0x1009_b06a, 1); retd(); return;                         /* ret */
        }
    }
}