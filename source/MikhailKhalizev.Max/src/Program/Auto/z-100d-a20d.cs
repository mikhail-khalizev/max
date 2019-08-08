using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0f564dab-8a6b-4eae-85c9-4477d4270eba")]
        public void Method_100d_a20d()
        {
            ii(0x100d_a20d, 5); pushd(0x30);                            /* push 0x30 */
            ii(0x100d_a212, 5); calld(Definitions.sys_check_available_stack_size, 0x8_bb3b); /* call 0x10165d52 */
            ii(0x100d_a217, 1); pushd(ebx);                             /* push ebx */
            ii(0x100d_a218, 1); pushd(ecx);                             /* push ecx */
            ii(0x100d_a219, 1); pushd(esi);                             /* push esi */
            ii(0x100d_a21a, 1); pushd(edi);                             /* push edi */
            ii(0x100d_a21b, 1); pushd(ebp);                             /* push ebp */
            ii(0x100d_a21c, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100d_a21e, 6); sub(esp, 0x18);                         /* sub esp, 0x18 */
            ii(0x100d_a224, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100d_a227, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x100d_a22a, 5); mov(edx, 0x1);                          /* mov edx, 0x1 */
            ii(0x100d_a22f, 4); movsx(eax, memw_a32[ss, ebp - 0x4]);    /* movsx eax, word [ebp-0x4] */
            ii(0x100d_a233, 5); calld(0x1007_1e00, -0x6_8438);          /* call 0x10071e00 */
            ii(0x100d_a238, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x100d_a23b, 4); movsx(eax, memw_a32[ss, ebp - 0x4]);    /* movsx eax, word [ebp-0x4] */
            ii(0x100d_a23f, 5); calld(0x1007_1ec5, -0x6_837f);          /* call 0x10071ec5 */
            ii(0x100d_a244, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x100d_a247, 4); movsx(eax, memw_a32[ss, ebp - 0x4]);    /* movsx eax, word [ebp-0x4] */
            ii(0x100d_a24b, 5); calld(0x1007_1f2e, -0x6_8322);          /* call 0x10071f2e */
            ii(0x100d_a250, 3); mov(memd_a32[ss, ebp - 0x14], eax);     /* mov [ebp-0x14], eax */
            ii(0x100d_a253, 4); movsx(eax, memw_a32[ss, ebp - 0x4]);    /* movsx eax, word [ebp-0x4] */
            ii(0x100d_a257, 5); calld(0x1007_1ff5, -0x6_8267);          /* call 0x10071ff5 */
            ii(0x100d_a25c, 3); mov(memd_a32[ss, ebp - 0x18], eax);     /* mov [ebp-0x18], eax */
            ii(0x100d_a25f, 4); movsx(eax, memw_a32[ss, ebp - 0x14]);   /* movsx eax, word [ebp-0x14] */
            ii(0x100d_a263, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100d_a265, 2); if(jged(0x100d_a26f, 0x8)) goto l_0x100d_a26f; /* jge 0x100da26f */
            ii(0x100d_a267, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100d_a26a, 5); add(memw_a32[ds, eax + 0x53], 0x13);    /* add word [eax+0x53], 0x13 */
        l_0x100d_a26f:
            ii(0x100d_a26f, 4); movsx(eax, memw_a32[ss, ebp - 0x18]);   /* movsx eax, word [ebp-0x18] */
            ii(0x100d_a273, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100d_a275, 2); if(jged(0x100d_a27f, 0x8)) goto l_0x100d_a27f; /* jge 0x100da27f */
            ii(0x100d_a277, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100d_a27a, 5); add(memw_a32[ds, eax + 0x53], 0x13);    /* add word [eax+0x53], 0x13 */
        l_0x100d_a27f:
            ii(0x100d_a27f, 4); movsx(eax, memw_a32[ss, ebp - 0xc]);    /* movsx eax, word [ebp-0xc] */
            ii(0x100d_a283, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100d_a285, 2); if(jgd(0x100d_a28f, 0x8)) goto l_0x100d_a28f; /* jg 0x100da28f */
            ii(0x100d_a287, 4); movsx(eax, memw_a32[ss, ebp - 0x10]);   /* movsx eax, word [ebp-0x10] */
            ii(0x100d_a28b, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100d_a28d, 2); if(jled(0x100d_a291, 0x2)) goto l_0x100d_a291; /* jle 0x100da291 */
        l_0x100d_a28f:
            ii(0x100d_a28f, 2); jmpd(0x100d_a299, 0x8); goto l_0x100d_a299; /* jmp 0x100da299 */
        l_0x100d_a291:
            ii(0x100d_a291, 4); movsx(eax, memw_a32[ss, ebp - 0x14]);   /* movsx eax, word [ebp-0x14] */
            ii(0x100d_a295, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100d_a297, 2); if(jled(0x100d_a29b, 0x2)) goto l_0x100d_a29b; /* jle 0x100da29b */
        l_0x100d_a299:
            ii(0x100d_a299, 2); jmpd(0x100d_a2a3, 0x8); goto l_0x100d_a2a3; /* jmp 0x100da2a3 */
        l_0x100d_a29b:
            ii(0x100d_a29b, 4); movsx(eax, memw_a32[ss, ebp - 0x18]);   /* movsx eax, word [ebp-0x18] */
            ii(0x100d_a29f, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100d_a2a1, 2); if(jled(0x100d_a2ab, 0x8)) goto l_0x100d_a2ab; /* jle 0x100da2ab */
        l_0x100d_a2a3:
            ii(0x100d_a2a3, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100d_a2a6, 5); add(memw_a32[ds, eax + 0x53], 0x13);    /* add word [eax+0x53], 0x13 */
        l_0x100d_a2ab:
            ii(0x100d_a2ab, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100d_a2ad, 1); popd(ebp);                              /* pop ebp */
            ii(0x100d_a2ae, 1); popd(edi);                              /* pop edi */
            ii(0x100d_a2af, 1); popd(esi);                              /* pop esi */
            ii(0x100d_a2b0, 1); popd(ecx);                              /* pop ecx */
            ii(0x100d_a2b1, 1); popd(ebx);                              /* pop ebx */
            ii(0x100d_a2b2, 1); retd(); return;                         /* ret */
        }
    }
}
