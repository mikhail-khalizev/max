using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1010_c513-1ef8b93a")]
        public void Method_1010_c513()
        {
            ii(0x1010_c513, 5); pushd(0x58);                            /* push 0x58 */
            ii(0x1010_c518, 5); calld(Definitions.sys_check_available_stack_size, 0x5_9835); /* call 0x10165d52 */
            ii(0x1010_c51d, 1); pushd(ebx);                             /* push ebx */
            ii(0x1010_c51e, 1); pushd(ecx);                             /* push ecx */
            ii(0x1010_c51f, 1); pushd(esi);                             /* push esi */
            ii(0x1010_c520, 1); pushd(edi);                             /* push edi */
            ii(0x1010_c521, 1); pushd(ebp);                             /* push ebp */
            ii(0x1010_c522, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1010_c524, 6); sub(esp, 0x1c);                         /* sub esp, 0x1c */
            ii(0x1010_c52a, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1010_c52d, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x1010_c530, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1010_c533, 3); mov(eax, memd_a32[ds, eax + 0x6]);      /* mov eax, [eax+0x6] */
            ii(0x1010_c536, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1010_c539, 5); calld(Definitions.my_get_res_data_by_id, 0x2_7a9a); /* call 0x10133fd8 */
            ii(0x1010_c53e, 3); mov(memd_a32[ss, ebp - 0x14], eax);     /* mov [ebp-0x14], eax */
            ii(0x1010_c541, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1010_c544, 3); mov(eax, memd_a32[ds, eax + 0x8]);      /* mov eax, [eax+0x8] */
            ii(0x1010_c547, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1010_c54a, 5); calld(Definitions.my_get_res_data_by_id, 0x2_7a89); /* call 0x10133fd8 */
            ii(0x1010_c54f, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x1010_c552, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1010_c555, 5); cmp(memw_a32[ds, eax + 0xc], -0x1 /* 0xff */); /* cmp word [eax+0xc], 0xffff */
            ii(0x1010_c55a, 2); if(jnzd(0x1010_c56f, 0x13)) goto l_0x1010_c56f; /* jnz 0x1010c56f */
            ii(0x1010_c55c, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1010_c55f, 3); mov(eax, memd_a32[ds, eax + 0xa]);      /* mov eax, [eax+0xa] */
            ii(0x1010_c562, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1010_c565, 5); calld(Definitions.my_get_res_data_by_id, 0x2_7a6e); /* call 0x10133fd8 */
            ii(0x1010_c56a, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1010_c56d, 2); jmpd(0x1010_c576, 0x7); goto l_0x1010_c576; /* jmp 0x1010c576 */
        l_0x1010_c56f:
            ii(0x1010_c56f, 7); mov(memd_a32[ss, ebp - 0xc], 0);        /* mov dword [ebp-0xc], 0x0 */
        l_0x1010_c576:
            ii(0x1010_c576, 4); cmp(memd_a32[ss, ebp - 0x4], 0);        /* cmp dword [ebp-0x4], 0x0 */
            ii(0x1010_c57a, 2); if(jzd(0x1010_c598, 0x1c)) goto l_0x1010_c598; /* jz 0x1010c598 */
            ii(0x1010_c57c, 3); mov(eax, memd_a32[ss, ebp - 0x14]);     /* mov eax, [ebp-0x14] */
            ii(0x1010_c57f, 4); mov(dx, memw_a32[ds, eax + 0x4]);       /* mov dx, [eax+0x4] */
            ii(0x1010_c583, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1010_c586, 4); mov(memw_a32[ds, eax + 0x4], dx);       /* mov [eax+0x4], dx */
            ii(0x1010_c58a, 3); mov(eax, memd_a32[ss, ebp - 0x14]);     /* mov eax, [ebp-0x14] */
            ii(0x1010_c58d, 4); mov(dx, memw_a32[ds, eax + 0x6]);       /* mov dx, [eax+0x6] */
            ii(0x1010_c591, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1010_c594, 4); mov(memw_a32[ds, eax + 0x6], dx);       /* mov [eax+0x6], dx */
        l_0x1010_c598:
            ii(0x1010_c598, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1010_c59b, 3); pushd(memd_a32[ds, eax + 0x16]);        /* push dword [eax+0x16] */
            ii(0x1010_c59e, 4); cmp(memd_a32[ss, ebp - 0xc], 0);        /* cmp dword [ebp-0xc], 0x0 */
            ii(0x1010_c5a2, 2); if(jzd(0x1010_c5af, 0xb)) goto l_0x1010_c5af; /* jz 0x1010c5af */
            ii(0x1010_c5a4, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1010_c5a7, 3); add(eax, 0x8);                          /* add eax, 0x8 */
            ii(0x1010_c5aa, 3); mov(memd_a32[ss, ebp - 0x1c], eax);     /* mov [ebp-0x1c], eax */
            ii(0x1010_c5ad, 2); jmpd(0x1010_c5b6, 0x7); goto l_0x1010_c5b6; /* jmp 0x1010c5b6 */
        l_0x1010_c5af:
            ii(0x1010_c5af, 7); mov(memd_a32[ss, ebp - 0x1c], 0);       /* mov dword [ebp-0x1c], 0x0 */
        l_0x1010_c5b6:
            ii(0x1010_c5b6, 3); pushd(memd_a32[ss, ebp - 0x1c]);        /* push dword [ebp-0x1c] */
            ii(0x1010_c5b9, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1010_c5bc, 3); add(eax, 0x8);                          /* add eax, 0x8 */
            ii(0x1010_c5bf, 1); pushd(eax);                             /* push eax */
            ii(0x1010_c5c0, 3); mov(eax, memd_a32[ss, ebp - 0x14]);     /* mov eax, [ebp-0x14] */
            ii(0x1010_c5c3, 3); add(eax, 0x8);                          /* add eax, 0x8 */
            ii(0x1010_c5c6, 1); pushd(eax);                             /* push eax */
            ii(0x1010_c5c7, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1010_c5ca, 3); mov(eax, memd_a32[ds, eax + 0x12]);     /* mov eax, [eax+0x12] */
            ii(0x1010_c5cd, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1010_c5d0, 1); pushd(eax);                             /* push eax */
            ii(0x1010_c5d1, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1010_c5d4, 3); mov(eax, memd_a32[ds, eax + 0x10]);     /* mov eax, [eax+0x10] */
            ii(0x1010_c5d7, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1010_c5da, 1); pushd(eax);                             /* push eax */
            ii(0x1010_c5db, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1010_c5de, 3); mov(eax, memd_a32[ds, eax + 0xe]);      /* mov eax, [eax+0xe] */
            ii(0x1010_c5e1, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1010_c5e4, 1); pushd(eax);                             /* push eax */
            ii(0x1010_c5e5, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1010_c5e8, 3); mov(eax, memd_a32[ds, eax + 0xc]);      /* mov eax, [eax+0xc] */
            ii(0x1010_c5eb, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1010_c5ee, 1); pushd(eax);                             /* push eax */
            ii(0x1010_c5ef, 3); mov(eax, memd_a32[ss, ebp - 0x14]);     /* mov eax, [ebp-0x14] */
            ii(0x1010_c5f2, 2); mov(eax, memd_a32[ds, eax]);            /* mov eax, [eax] */
            ii(0x1010_c5f4, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1010_c5f7, 1); pushd(eax);                             /* push eax */
            ii(0x1010_c5f8, 3); mov(eax, memd_a32[ss, ebp - 0x14]);     /* mov eax, [ebp-0x14] */
            ii(0x1010_c5fb, 3); movsx(ecx, memw_a32[ds, eax]);          /* movsx ecx, word [eax] */
            ii(0x1010_c5fe, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1010_c601, 3); mov(ebx, memd_a32[ds, eax + 0x4]);      /* mov ebx, [eax+0x4] */
            ii(0x1010_c604, 3); sar(ebx, 0x10);                         /* sar ebx, 0x10 */
            ii(0x1010_c607, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1010_c60a, 3); mov(edx, memd_a32[ds, eax + 0x2]);      /* mov edx, [eax+0x2] */
            ii(0x1010_c60d, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1010_c610, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1010_c613, 2); mov(eax, memd_a32[ds, eax]);            /* mov eax, [eax] */
            ii(0x1010_c615, 5); calld(/* sys */ 0x1016_86b0, 0x5_c096); /* call 0x101686b0 */
            ii(0x1010_c61a, 3); mov(memd_a32[ss, ebp - 0x18], eax);     /* mov [ebp-0x18], eax */
            ii(0x1010_c61d, 3); mov(eax, memd_a32[ss, ebp - 0x18]);     /* mov eax, [ebp-0x18] */
            ii(0x1010_c620, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1010_c622, 1); popd(ebp);                              /* pop ebp */
            ii(0x1010_c623, 1); popd(edi);                              /* pop edi */
            ii(0x1010_c624, 1); popd(esi);                              /* pop esi */
            ii(0x1010_c625, 1); popd(ecx);                              /* pop ecx */
            ii(0x1010_c626, 1); popd(ebx);                              /* pop ebx */
            ii(0x1010_c627, 1); retd();                                 /* ret */
        }
    }
}
