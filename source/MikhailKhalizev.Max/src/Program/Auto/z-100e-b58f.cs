using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("8d1b09b3-5f37-4201-88ac-fbe9dab24a72")]
        public void Method_100e_b58f()
        {
            ii(0x100e_b58f, 5); pushd(0x20);                            /* push 0x20 */
            ii(0x100e_b594, 5); calld(Definitions.sys_check_available_stack_size, 0x7a7b9); /* call 0x10165d52 */
            ii(0x100e_b599, 1); pushd(ebx);                             /* push ebx */
            ii(0x100e_b59a, 1); pushd(ecx);                             /* push ecx */
            ii(0x100e_b59b, 1); pushd(edx);                             /* push edx */
            ii(0x100e_b59c, 1); pushd(esi);                             /* push esi */
            ii(0x100e_b59d, 1); pushd(edi);                             /* push edi */
            ii(0x100e_b59e, 1); pushd(ebp);                             /* push ebp */
            ii(0x100e_b59f, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100e_b5a1, 6); sub(esp, 0x4);                          /* sub esp, 0x4 */
            ii(0x100e_b5a7, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x100e_b5aa, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100e_b5ad, 6); mov(memw_a32[ds, eax + 0x2c], 0);       /* mov word [eax+0x2c], 0x0 */
            ii(0x100e_b5b3, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x100e_b5b6, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100e_b5b9, 3); mov(eax, memd_a32[ds, eax + 0x1b]);     /* mov eax, [eax+0x1b] */
            ii(0x100e_b5bc, 5); calld(0x100d_7f6c, -0x13655);           /* call 0x100d7f6c */
            ii(0x100e_b5c1, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100e_b5c4, 3); mov(eax, memd_a32[ds, eax + 0x23]);     /* mov eax, [eax+0x23] */
            ii(0x100e_b5c7, 3); mov(memb_a32[ds, eax], 0);              /* mov byte [eax], 0x0 */
            ii(0x100e_b5ca, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x100e_b5cd, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100e_b5d0, 3); mov(eax, memd_a32[ds, eax + 0x12]);     /* mov eax, [eax+0x12] */
            ii(0x100e_b5d3, 5); calld(Definitions.sys_display_draw_1, 0x7bed0); /* call 0x101674a8 */
            ii(0x100e_b5d8, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100e_b5da, 1); popd(ebp);                              /* pop ebp */
            ii(0x100e_b5db, 1); popd(edi);                              /* pop edi */
            ii(0x100e_b5dc, 1); popd(esi);                              /* pop esi */
            ii(0x100e_b5dd, 1); popd(edx);                              /* pop edx */
            ii(0x100e_b5de, 1); popd(ecx);                              /* pop ecx */
            ii(0x100e_b5df, 1); popd(ebx);                              /* pop ebx */
            ii(0x100e_b5e0, 1); retd(); return;                         /* ret */
        }
    }
}
