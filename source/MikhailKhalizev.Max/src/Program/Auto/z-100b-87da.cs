using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("d0787888-237d-4c4e-8ed7-1fb24a607649")]
        public void Method_100b_87da()
        {
            ii(0x100b_87da, 5); pushd(0x28);                            /* push 0x28 */
            ii(0x100b_87df, 5); calld(Definitions.sys_check_available_stack_size, 0xa_d56e); /* call 0x10165d52 */
            ii(0x100b_87e4, 1); pushd(ebx);                             /* push ebx */
            ii(0x100b_87e5, 1); pushd(ecx);                             /* push ecx */
            ii(0x100b_87e6, 1); pushd(esi);                             /* push esi */
            ii(0x100b_87e7, 1); pushd(edi);                             /* push edi */
            ii(0x100b_87e8, 1); pushd(ebp);                             /* push ebp */
            ii(0x100b_87e9, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100b_87eb, 6); sub(esp, 0x10);                         /* sub esp, 0x10 */
            ii(0x100b_87f1, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100b_87f4, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x100b_87f7, 7); mov(memd_a32[ss, ebp - 0xc], 0);        /* mov dword [ebp-0xc], 0x0 */
            ii(0x100b_87fe, 2); jmpd(0x100b_8806, 0x6); goto l_0x100b_8806; /* jmp 0x100b8806 */
        l_0x100b_8800:
            ii(0x100b_8800, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100b_8803, 3); inc(memd_a32[ss, ebp - 0xc]);           /* inc dword [ebp-0xc] */
        l_0x100b_8806:
            ii(0x100b_8806, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100b_8809, 5); calld(0x1008_a4a0, -0x2_e36e);          /* call 0x1008a4a0 */
            ii(0x100b_880e, 4); cmp(ax, memw_a32[ss, ebp - 0xc]);       /* cmp ax, [ebp-0xc] */
            ii(0x100b_8812, 2); if(jled(0x100b_8840, 0x2c)) goto l_0x100b_8840; /* jle 0x100b8840 */
            ii(0x100b_8814, 4); movsx(edx, memw_a32[ss, ebp - 0xc]);    /* movsx edx, word [ebp-0xc] */
            ii(0x100b_8818, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100b_881b, 5); calld(0x1008_a3dc, -0x2_e444);          /* call 0x1008a3dc */
            ii(0x100b_8820, 3); mov(ax, memw_a32[ds, eax]);             /* mov ax, [eax] */
            ii(0x100b_8823, 4); cmp(ax, memw_a32[ss, ebp - 0x4]);       /* cmp ax, [ebp-0x4] */
            ii(0x100b_8827, 2); if(jnzd(0x100b_883e, 0x15)) goto l_0x100b_883e; /* jnz 0x100b883e */
            ii(0x100b_8829, 4); movsx(edx, memw_a32[ss, ebp - 0xc]);    /* movsx edx, word [ebp-0xc] */
            ii(0x100b_882d, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100b_8830, 5); calld(0x1008_a3dc, -0x2_e459);          /* call 0x1008a3dc */
            ii(0x100b_8835, 4); mov(ax, memw_a32[ds, eax + 0x2]);       /* mov ax, [eax+0x2] */
            ii(0x100b_8839, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x100b_883c, 2); jmpd(0x100b_8847, 0x9); goto l_0x100b_8847; /* jmp 0x100b8847 */
        l_0x100b_883e:
            ii(0x100b_883e, 2); jmpd(0x100b_8800, -0x40); goto l_0x100b_8800; /* jmp 0x100b8800 */
        l_0x100b_8840:
            ii(0x100b_8840, 7); mov(memd_a32[ss, ebp - 0x10], 0);       /* mov dword [ebp-0x10], 0x0 */
        l_0x100b_8847:
            ii(0x100b_8847, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x100b_884a, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100b_884c, 1); popd(ebp);                              /* pop ebp */
            ii(0x100b_884d, 1); popd(edi);                              /* pop edi */
            ii(0x100b_884e, 1); popd(esi);                              /* pop esi */
            ii(0x100b_884f, 1); popd(ecx);                              /* pop ecx */
            ii(0x100b_8850, 1); popd(ebx);                              /* pop ebx */
            ii(0x100b_8851, 1); retd(); return;                         /* ret */
        }
    }
}
