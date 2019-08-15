using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("1c5be2d6-46e9-446e-91cf-b384b753e176")]
        public void Method_1011_da86()
        {
            ii(0x1011_da86, 5); pushd(0x28);                            /* push 0x28 */
            ii(0x1011_da8b, 5); calld(Definitions.sys_check_available_stack_size, 0x4_82c2); /* call 0x10165d52 */
            ii(0x1011_da90, 1); pushd(ecx);                             /* push ecx */
            ii(0x1011_da91, 1); pushd(esi);                             /* push esi */
            ii(0x1011_da92, 1); pushd(edi);                             /* push edi */
            ii(0x1011_da93, 1); pushd(ebp);                             /* push ebp */
            ii(0x1011_da94, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1011_da96, 6); sub(esp, 0x14);                         /* sub esp, 0x14 */
            ii(0x1011_da9c, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1011_da9f, 3); mov(memd_a32[ss, ebp - 0x8], edx);      /* mov [ebp-0x8], edx */
            ii(0x1011_daa2, 3); mov(memd_a32[ss, ebp - 0x4], ebx);      /* mov [ebp-0x4], ebx */
            ii(0x1011_daa5, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1011_daa8, 3); movsx(edx, memw_a32[ds, eax]);          /* movsx edx, word [eax] */
            ii(0x1011_daab, 3); shl(edx, 0x2);                          /* shl edx, 0x2 */
            ii(0x1011_daae, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1011_dab1, 3); mov(eax, memd_a32[ds, eax + 0x27]);     /* mov eax, [eax+0x27] */
            ii(0x1011_dab4, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x1011_dab6, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1011_dab9, 2); mov(eax, memd_a32[ds, eax]);            /* mov eax, [eax] */
            ii(0x1011_dabb, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1011_dabe, 2); mov(edx, memd_a32[ds, edx]);            /* mov edx, [edx] */
            ii(0x1011_dac0, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x1011_dac2, 3); mov(memd_a32[ss, ebp - 0x10], edx);     /* mov [ebp-0x10], edx */
        l_0x1011_dac5:
            ii(0x1011_dac5, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1011_dac8, 4); mov(ax, memw_a32[ds, eax + 0x2]);       /* mov ax, [eax+0x2] */
            ii(0x1011_dacc, 4); cmp(ax, memw_a32[ss, ebp - 0x4]);       /* cmp ax, [ebp-0x4] */
            ii(0x1011_dad0, 2); if(jged(0x1011_dada, 0x8)) goto l_0x1011_dada; /* jge 0x1011dada */
            ii(0x1011_dad2, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1011_dad5, 3); test(memb_a32[ds, eax], 0x1f);          /* test byte [eax], 0x1f */
            ii(0x1011_dad8, 2); if(jnzd(0x1011_dadc, 0x2)) goto l_0x1011_dadc; /* jnz 0x1011dadc */
        l_0x1011_dada:
            ii(0x1011_dada, 2); jmpd(0x1011_dae4, 0x8); goto l_0x1011_dae4; /* jmp 0x1011dae4 */
        l_0x1011_dadc:
            ii(0x1011_dadc, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1011_dadf, 3); test(memb_a32[ds, eax], 0x20);          /* test byte [eax], 0x20 */
            ii(0x1011_dae2, 2); if(jzd(0x1011_dae6, 0x2)) goto l_0x1011_dae6; /* jz 0x1011dae6 */
        l_0x1011_dae4:
            ii(0x1011_dae4, 2); jmpd(0x1011_daf5, 0xf); goto l_0x1011_daf5; /* jmp 0x1011daf5 */
        l_0x1011_dae6:
            ii(0x1011_dae6, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1011_dae9, 3); inc(memd_a32[ss, ebp - 0x10]);          /* inc dword [ebp-0x10] */
            ii(0x1011_daec, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1011_daef, 4); inc(memw_a32[ds, eax + 0x2]);           /* inc word [eax+0x2] */
            ii(0x1011_daf3, 2); jmpd(0x1011_dac5, -0x30); goto l_0x1011_dac5; /* jmp 0x1011dac5 */
        l_0x1011_daf5:
            ii(0x1011_daf5, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1011_daf8, 4); mov(ax, memw_a32[ds, eax + 0x2]);       /* mov ax, [eax+0x2] */
            ii(0x1011_dafc, 3); mov(memd_a32[ss, ebp - 0x14], eax);     /* mov [ebp-0x14], eax */
            ii(0x1011_daff, 3); mov(eax, memd_a32[ss, ebp - 0x14]);     /* mov eax, [ebp-0x14] */
            ii(0x1011_db02, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1011_db04, 1); popd(ebp);                              /* pop ebp */
            ii(0x1011_db05, 1); popd(edi);                              /* pop edi */
            ii(0x1011_db06, 1); popd(esi);                              /* pop esi */
            ii(0x1011_db07, 1); popd(ecx);                              /* pop ecx */
            ii(0x1011_db08, 1); retd(); return;                         /* ret */
        }
    }
}
