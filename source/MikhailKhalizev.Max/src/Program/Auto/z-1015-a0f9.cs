using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1015_a0f9-7a03aabf")]
        public void Method_1015_a0f9()
        {
            ii(0x1015_a0f9, 5); pushd(0x28);                            /* push 0x28 */
            ii(0x1015_a0fe, 5); calld(Definitions.sys_check_available_stack_size, 0xbc4f); /* call 0x10165d52 */
            ii(0x1015_a103, 1); pushd(ecx);                             /* push ecx */
            ii(0x1015_a104, 1); pushd(esi);                             /* push esi */
            ii(0x1015_a105, 1); pushd(edi);                             /* push edi */
            ii(0x1015_a106, 1); pushd(ebp);                             /* push ebp */
            ii(0x1015_a107, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1015_a109, 6); sub(esp, 0x10);                         /* sub esp, 0x10 */
            ii(0x1015_a10f, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1015_a112, 3); mov(memd_a32[ss, ebp - 0xc], edx);      /* mov [ebp-0xc], edx */
            ii(0x1015_a115, 3); mov(memd_a32[ss, ebp - 0x8], ebx);      /* mov [ebp-0x8], ebx */
            ii(0x1015_a118, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1015_a11b, 3); inc(memw_a32[ds, eax]);                 /* inc word [eax] */
            ii(0x1015_a11e, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1015_a121, 3); dec(memw_a32[ds, eax]);                 /* dec word [eax] */
            ii(0x1015_a124, 5); mov(eax, 0x2);                          /* mov eax, 0x2 */
            ii(0x1015_a129, 1); pushd(eax);                             /* push eax */
            ii(0x1015_a12a, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1015_a12d, 3); movsx(ecx, memw_a32[ds, eax]);          /* movsx ecx, word [eax] */
            ii(0x1015_a130, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1015_a133, 3); movsx(ebx, memw_a32[ds, eax]);          /* movsx ebx, word [eax] */
            ii(0x1015_a136, 4); movsx(edx, memw_a32[ss, ebp - 0x4]);    /* movsx edx, word [ebp-0x4] */
            ii(0x1015_a13a, 5); mov(eax, 0x2);                          /* mov eax, 0x2 */
            ii(0x1015_a13f, 5); calld(0x1007_02b9, -0xe_9e8b);          /* call 0x100702b9 */
            ii(0x1015_a144, 3); test(ax, ax);                           /* test ax, ax */
            ii(0x1015_a147, 2); if(jzd(0x1015_a152, 0x9)) goto l_0x1015_a152; /* jz 0x1015a152 */
            ii(0x1015_a149, 4); mov(memb_a32[ss, ebp - 0x10], 0x1);     /* mov byte [ebp-0x10], 0x1 */
            ii(0x1015_a14d, 5); jmpd(0x1015_a2d0, 0x17e); goto l_0x1015_a2d0; /* jmp 0x1015a2d0 */
        l_0x1015_a152:
            ii(0x1015_a152, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1015_a155, 4); add(memw_a32[ds, eax], 0x3);            /* add word [eax], 0x3 */
            ii(0x1015_a159, 5); mov(eax, 0x2);                          /* mov eax, 0x2 */
            ii(0x1015_a15e, 1); pushd(eax);                             /* push eax */
            ii(0x1015_a15f, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1015_a162, 3); movsx(ecx, memw_a32[ds, eax]);          /* movsx ecx, word [eax] */
            ii(0x1015_a165, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1015_a168, 3); movsx(ebx, memw_a32[ds, eax]);          /* movsx ebx, word [eax] */
            ii(0x1015_a16b, 4); movsx(edx, memw_a32[ss, ebp - 0x4]);    /* movsx edx, word [ebp-0x4] */
            ii(0x1015_a16f, 5); mov(eax, 0x2);                          /* mov eax, 0x2 */
            ii(0x1015_a174, 5); calld(0x1007_02b9, -0xe_9ec0);          /* call 0x100702b9 */
            ii(0x1015_a179, 3); test(ax, ax);                           /* test ax, ax */
            ii(0x1015_a17c, 2); if(jzd(0x1015_a187, 0x9)) goto l_0x1015_a187; /* jz 0x1015a187 */
            ii(0x1015_a17e, 4); mov(memb_a32[ss, ebp - 0x10], 0x1);     /* mov byte [ebp-0x10], 0x1 */
            ii(0x1015_a182, 5); jmpd(0x1015_a2d0, 0x149); goto l_0x1015_a2d0; /* jmp 0x1015a2d0 */
        l_0x1015_a187:
            ii(0x1015_a187, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1015_a18a, 3); dec(memw_a32[ds, eax]);                 /* dec word [eax] */
            ii(0x1015_a18d, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1015_a190, 4); sub(memw_a32[ds, eax], 0x3);            /* sub word [eax], 0x3 */
            ii(0x1015_a194, 5); mov(eax, 0x2);                          /* mov eax, 0x2 */
            ii(0x1015_a199, 1); pushd(eax);                             /* push eax */
            ii(0x1015_a19a, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1015_a19d, 3); movsx(ecx, memw_a32[ds, eax]);          /* movsx ecx, word [eax] */
            ii(0x1015_a1a0, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1015_a1a3, 3); movsx(ebx, memw_a32[ds, eax]);          /* movsx ebx, word [eax] */
            ii(0x1015_a1a6, 4); movsx(edx, memw_a32[ss, ebp - 0x4]);    /* movsx edx, word [ebp-0x4] */
            ii(0x1015_a1aa, 5); mov(eax, 0x2);                          /* mov eax, 0x2 */
            ii(0x1015_a1af, 5); calld(0x1007_02b9, -0xe_9efb);          /* call 0x100702b9 */
            ii(0x1015_a1b4, 3); test(ax, ax);                           /* test ax, ax */
            ii(0x1015_a1b7, 2); if(jzd(0x1015_a1c2, 0x9)) goto l_0x1015_a1c2; /* jz 0x1015a1c2 */
            ii(0x1015_a1b9, 4); mov(memb_a32[ss, ebp - 0x10], 0x1);     /* mov byte [ebp-0x10], 0x1 */
            ii(0x1015_a1bd, 5); jmpd(0x1015_a2d0, 0x10e); goto l_0x1015_a2d0; /* jmp 0x1015a2d0 */
        l_0x1015_a1c2:
            ii(0x1015_a1c2, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1015_a1c5, 4); add(memw_a32[ds, eax], 0x3);            /* add word [eax], 0x3 */
            ii(0x1015_a1c9, 5); mov(eax, 0x2);                          /* mov eax, 0x2 */
            ii(0x1015_a1ce, 1); pushd(eax);                             /* push eax */
            ii(0x1015_a1cf, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1015_a1d2, 3); movsx(ecx, memw_a32[ds, eax]);          /* movsx ecx, word [eax] */
            ii(0x1015_a1d5, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1015_a1d8, 3); movsx(ebx, memw_a32[ds, eax]);          /* movsx ebx, word [eax] */
            ii(0x1015_a1db, 4); movsx(edx, memw_a32[ss, ebp - 0x4]);    /* movsx edx, word [ebp-0x4] */
            ii(0x1015_a1df, 5); mov(eax, 0x2);                          /* mov eax, 0x2 */
            ii(0x1015_a1e4, 5); calld(0x1007_02b9, -0xe_9f30);          /* call 0x100702b9 */
            ii(0x1015_a1e9, 3); test(ax, ax);                           /* test ax, ax */
            ii(0x1015_a1ec, 2); if(jzd(0x1015_a1f7, 0x9)) goto l_0x1015_a1f7; /* jz 0x1015a1f7 */
            ii(0x1015_a1ee, 4); mov(memb_a32[ss, ebp - 0x10], 0x1);     /* mov byte [ebp-0x10], 0x1 */
            ii(0x1015_a1f2, 5); jmpd(0x1015_a2d0, 0xd9); goto l_0x1015_a2d0; /* jmp 0x1015a2d0 */
        l_0x1015_a1f7:
            ii(0x1015_a1f7, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1015_a1fa, 4); sub(memw_a32[ds, eax], 0x2);            /* sub word [eax], 0x2 */
            ii(0x1015_a1fe, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1015_a201, 3); dec(memw_a32[ds, eax]);                 /* dec word [eax] */
            ii(0x1015_a204, 5); mov(eax, 0x2);                          /* mov eax, 0x2 */
            ii(0x1015_a209, 1); pushd(eax);                             /* push eax */
            ii(0x1015_a20a, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1015_a20d, 3); movsx(ecx, memw_a32[ds, eax]);          /* movsx ecx, word [eax] */
            ii(0x1015_a210, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1015_a213, 3); movsx(ebx, memw_a32[ds, eax]);          /* movsx ebx, word [eax] */
            ii(0x1015_a216, 4); movsx(edx, memw_a32[ss, ebp - 0x4]);    /* movsx edx, word [ebp-0x4] */
            ii(0x1015_a21a, 5); mov(eax, 0x2);                          /* mov eax, 0x2 */
            ii(0x1015_a21f, 5); calld(0x1007_02b9, -0xe_9f6b);          /* call 0x100702b9 */
            ii(0x1015_a224, 3); test(ax, ax);                           /* test ax, ax */
            ii(0x1015_a227, 2); if(jzd(0x1015_a232, 0x9)) goto l_0x1015_a232; /* jz 0x1015a232 */
            ii(0x1015_a229, 4); mov(memb_a32[ss, ebp - 0x10], 0x1);     /* mov byte [ebp-0x10], 0x1 */
            ii(0x1015_a22d, 5); jmpd(0x1015_a2d0, 0x9e); goto l_0x1015_a2d0; /* jmp 0x1015a2d0 */
        l_0x1015_a232:
            ii(0x1015_a232, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1015_a235, 3); inc(memw_a32[ds, eax]);                 /* inc word [eax] */
            ii(0x1015_a238, 5); mov(eax, 0x2);                          /* mov eax, 0x2 */
            ii(0x1015_a23d, 1); pushd(eax);                             /* push eax */
            ii(0x1015_a23e, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1015_a241, 3); movsx(ecx, memw_a32[ds, eax]);          /* movsx ecx, word [eax] */
            ii(0x1015_a244, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1015_a247, 3); movsx(ebx, memw_a32[ds, eax]);          /* movsx ebx, word [eax] */
            ii(0x1015_a24a, 4); movsx(edx, memw_a32[ss, ebp - 0x4]);    /* movsx edx, word [ebp-0x4] */
            ii(0x1015_a24e, 5); mov(eax, 0x2);                          /* mov eax, 0x2 */
            ii(0x1015_a253, 5); calld(0x1007_02b9, -0xe_9f9f);          /* call 0x100702b9 */
            ii(0x1015_a258, 3); test(ax, ax);                           /* test ax, ax */
            ii(0x1015_a25b, 2); if(jzd(0x1015_a263, 0x6)) goto l_0x1015_a263; /* jz 0x1015a263 */
            ii(0x1015_a25d, 4); mov(memb_a32[ss, ebp - 0x10], 0x1);     /* mov byte [ebp-0x10], 0x1 */
            ii(0x1015_a261, 2); jmpd(0x1015_a2d0, 0x6d); goto l_0x1015_a2d0; /* jmp 0x1015a2d0 */
        l_0x1015_a263:
            ii(0x1015_a263, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1015_a266, 3); dec(memw_a32[ds, eax]);                 /* dec word [eax] */
            ii(0x1015_a269, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1015_a26c, 4); add(memw_a32[ds, eax], 0x3);            /* add word [eax], 0x3 */
            ii(0x1015_a270, 5); mov(eax, 0x2);                          /* mov eax, 0x2 */
            ii(0x1015_a275, 1); pushd(eax);                             /* push eax */
            ii(0x1015_a276, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1015_a279, 3); movsx(ecx, memw_a32[ds, eax]);          /* movsx ecx, word [eax] */
            ii(0x1015_a27c, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1015_a27f, 3); movsx(ebx, memw_a32[ds, eax]);          /* movsx ebx, word [eax] */
            ii(0x1015_a282, 4); movsx(edx, memw_a32[ss, ebp - 0x4]);    /* movsx edx, word [ebp-0x4] */
            ii(0x1015_a286, 5); mov(eax, 0x2);                          /* mov eax, 0x2 */
            ii(0x1015_a28b, 5); calld(0x1007_02b9, -0xe_9fd7);          /* call 0x100702b9 */
            ii(0x1015_a290, 3); test(ax, ax);                           /* test ax, ax */
            ii(0x1015_a293, 2); if(jzd(0x1015_a29b, 0x6)) goto l_0x1015_a29b; /* jz 0x1015a29b */
            ii(0x1015_a295, 4); mov(memb_a32[ss, ebp - 0x10], 0x1);     /* mov byte [ebp-0x10], 0x1 */
            ii(0x1015_a299, 2); jmpd(0x1015_a2d0, 0x35); goto l_0x1015_a2d0; /* jmp 0x1015a2d0 */
        l_0x1015_a29b:
            ii(0x1015_a29b, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1015_a29e, 3); inc(memw_a32[ds, eax]);                 /* inc word [eax] */
            ii(0x1015_a2a1, 5); mov(eax, 0x2);                          /* mov eax, 0x2 */
            ii(0x1015_a2a6, 1); pushd(eax);                             /* push eax */
            ii(0x1015_a2a7, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1015_a2aa, 3); movsx(ecx, memw_a32[ds, eax]);          /* movsx ecx, word [eax] */
            ii(0x1015_a2ad, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1015_a2b0, 3); movsx(ebx, memw_a32[ds, eax]);          /* movsx ebx, word [eax] */
            ii(0x1015_a2b3, 4); movsx(edx, memw_a32[ss, ebp - 0x4]);    /* movsx edx, word [ebp-0x4] */
            ii(0x1015_a2b7, 5); mov(eax, 0x2);                          /* mov eax, 0x2 */
            ii(0x1015_a2bc, 5); calld(0x1007_02b9, -0xe_a008);          /* call 0x100702b9 */
            ii(0x1015_a2c1, 3); test(ax, ax);                           /* test ax, ax */
            ii(0x1015_a2c4, 2); if(jzd(0x1015_a2cc, 0x6)) goto l_0x1015_a2cc; /* jz 0x1015a2cc */
            ii(0x1015_a2c6, 4); mov(memb_a32[ss, ebp - 0x10], 0x1);     /* mov byte [ebp-0x10], 0x1 */
            ii(0x1015_a2ca, 2); jmpd(0x1015_a2d0, 0x4); goto l_0x1015_a2d0; /* jmp 0x1015a2d0 */
        l_0x1015_a2cc:
            ii(0x1015_a2cc, 4); mov(memb_a32[ss, ebp - 0x10], 0);       /* mov byte [ebp-0x10], 0x0 */
        l_0x1015_a2d0:
            ii(0x1015_a2d0, 3); mov(al, memb_a32[ss, ebp - 0x10]);      /* mov al, [ebp-0x10] */
            ii(0x1015_a2d3, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1015_a2d5, 1); popd(ebp);                              /* pop ebp */
            ii(0x1015_a2d6, 1); popd(edi);                              /* pop edi */
            ii(0x1015_a2d7, 1); popd(esi);                              /* pop esi */
            ii(0x1015_a2d8, 1); popd(ecx);                              /* pop ecx */
            ii(0x1015_a2d9, 1); retd();                                 /* ret */
        }
    }
}
