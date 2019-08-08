using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0b4e1173-e43d-4502-a45e-8a5aa2e93774")]
        public void Method_1007_4955()
        {
            ii(0x1007_4955, 5); pushd(0x28);                            /* push 0x28 */
            ii(0x1007_495a, 5); calld(Definitions.sys_check_available_stack_size, 0xf_13f3); /* call 0x10165d52 */
            ii(0x1007_495f, 1); pushd(esi);                             /* push esi */
            ii(0x1007_4960, 1); pushd(edi);                             /* push edi */
            ii(0x1007_4961, 1); pushd(ebp);                             /* push ebp */
            ii(0x1007_4962, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1007_4964, 6); sub(esp, 0x18);                         /* sub esp, 0x18 */
            ii(0x1007_496a, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1007_496d, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x1007_4970, 3); mov(memd_a32[ss, ebp - 0x10], ebx);     /* mov [ebp-0x10], ebx */
            ii(0x1007_4973, 3); mov(memd_a32[ss, ebp - 0xc], ecx);      /* mov [ebp-0xc], ecx */
            ii(0x1007_4976, 5); cmp(memw_a32[ss, ebp - 0x8], 0x47);     /* cmp word [ebp-0x8], 0x47 */
            ii(0x1007_497b, 2); if(jzd(0x1007_4984, 0x7)) goto l_0x1007_4984; /* jz 0x10074984 */
            ii(0x1007_497d, 5); cmp(memw_a32[ss, ebp - 0x8], 0x45);     /* cmp word [ebp-0x8], 0x45 */
            ii(0x1007_4982, 2); if(jnzd(0x1007_49b8, 0x34)) goto l_0x1007_49b8; /* jnz 0x100749b8 */
        l_0x1007_4984:
            ii(0x1007_4984, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1007_4987, 2); mov(edx, memd_a32[ds, eax]);            /* mov edx, [eax] */
            ii(0x1007_4989, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1007_498c, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1007_498f, 3); movsx(eax, memw_a32[ds, eax]);          /* movsx eax, word [eax] */
            ii(0x1007_4992, 5); calld(0x1007_3cfd, -0xc9a);             /* call 0x10073cfd */
            ii(0x1007_4997, 3); mov(memd_a32[ss, ebp - 0x18], eax);     /* mov [ebp-0x18], eax */
            ii(0x1007_499a, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1007_499c, 4); mov(ax, memw_a32[ss, ebp - 0x18]);      /* mov ax, [ebp-0x18] */
            ii(0x1007_49a0, 3); cmp(eax, 0x2);                          /* cmp eax, 0x2 */
            ii(0x1007_49a3, 2); if(jzd(0x1007_49b0, 0xb)) goto l_0x1007_49b0; /* jz 0x100749b0 */
            ii(0x1007_49a5, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1007_49a7, 4); mov(ax, memw_a32[ss, ebp - 0x18]);      /* mov ax, [ebp-0x18] */
            ii(0x1007_49ab, 3); cmp(eax, 0x4);                          /* cmp eax, 0x4 */
            ii(0x1007_49ae, 2); if(jnzd(0x1007_49b2, 0x2)) goto l_0x1007_49b2; /* jnz 0x100749b2 */
        l_0x1007_49b0:
            ii(0x1007_49b0, 2); jmpd(0x1007_49b8, 0x6); goto l_0x1007_49b8; /* jmp 0x100749b8 */
        l_0x1007_49b2:
            ii(0x1007_49b2, 4); mov(memb_a32[ss, ebp - 0x14], 0);       /* mov byte [ebp-0x14], 0x0 */
            ii(0x1007_49b6, 2); jmpd(0x1007_49cb, 0x13); goto l_0x1007_49cb; /* jmp 0x100749cb */
        l_0x1007_49b8:
            ii(0x1007_49b8, 3); mov(ebx, memd_a32[ss, ebp - 0x10]);     /* mov ebx, [ebp-0x10] */
            ii(0x1007_49bb, 4); movsx(edx, memw_a32[ss, ebp - 0x4]);    /* movsx edx, word [ebp-0x4] */
            ii(0x1007_49bf, 4); movsx(eax, memw_a32[ss, ebp - 0x8]);    /* movsx eax, word [ebp-0x8] */
            ii(0x1007_49c3, 5); calld(0x1007_486b, -0x15d);             /* call 0x1007486b */
            ii(0x1007_49c8, 3); mov(memb_a32[ss, ebp - 0x14], al);      /* mov [ebp-0x14], al */
        l_0x1007_49cb:
            ii(0x1007_49cb, 3); mov(al, memb_a32[ss, ebp - 0x14]);      /* mov al, [ebp-0x14] */
            ii(0x1007_49ce, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1007_49d0, 1); popd(ebp);                              /* pop ebp */
            ii(0x1007_49d1, 1); popd(edi);                              /* pop edi */
            ii(0x1007_49d2, 1); popd(esi);                              /* pop esi */
            ii(0x1007_49d3, 1); retd(); return;                         /* ret */
        }
    }
}
