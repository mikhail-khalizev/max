using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("bf10a451-71ab-4434-9c4f-a8831fc43358")]
        public void Method_1012_a310()
        {
            ii(0x1012_a310, 5); pushd(0x408);                           /* push 0x408 */
            ii(0x1012_a315, 5); calld(Definitions.sys_check_available_stack_size, 0x3ba38); /* call 0x10165d52 */
            ii(0x1012_a31a, 1); pushd(ebx);                             /* push ebx */
            ii(0x1012_a31b, 1); pushd(ecx);                             /* push ecx */
            ii(0x1012_a31c, 1); pushd(esi);                             /* push esi */
            ii(0x1012_a31d, 1); pushd(edi);                             /* push edi */
            ii(0x1012_a31e, 1); pushd(ebp);                             /* push ebp */
            ii(0x1012_a31f, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1012_a321, 6); sub(esp, 0x3dc);                        /* sub esp, 0x3dc */
            ii(0x1012_a327, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1012_a32a, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x1012_a32d, 3); lea(edi, ebp - 0x1c);                   /* lea edi, [ebp-0x1c] */
            ii(0x1012_a330, 5); mov(esi, 0x101b_b47c);                  /* mov esi, 0x101bb47c */
            ii(0x1012_a335, 1); movsd_a32();                            /* movsd */
            ii(0x1012_a336, 1); movsd_a32();                            /* movsd */
            ii(0x1012_a337, 1); movsd_a32();                            /* movsd */
            ii(0x1012_a338, 1); movsd_a32();                            /* movsd */
            ii(0x1012_a339, 4); mov(memb_a32[ss, ebp - 0xc], 0);        /* mov byte [ebp-0xc], 0x0 */
            ii(0x1012_a33d, 5); mov(eax, StringDefinitions.OutOfSyncLocalHost); /* mov eax, 0x101a83e4 */
            ii(0x1012_a342, 1); pushd(eax);                             /* push eax */
            ii(0x1012_a343, 6); lea(eax, ebp - 0x33c);                  /* lea eax, [ebp-0x33c] */
            ii(0x1012_a349, 1); pushd(eax);                             /* push eax */
            ii(0x1012_a34a, 5); calld(Definitions.sys_sprintf, 0x3bbb2); /* call 0x10165f01 */
            ii(0x1012_a34f, 3); add(esp, 0x8);                          /* add esp, 0x8 */
            ii(0x1012_a352, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1012_a355, 4); mov(dx, memw_a32[ds, eax + 0x15]);      /* mov dx, [eax+0x15] */
            ii(0x1012_a359, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1012_a35c, 4); cmp(dx, memw_a32[ds, eax + 0x8]);       /* cmp dx, [eax+0x8] */
            ii(0x1012_a360, 2); if(jnzd(0x1012_a37a, 0x18)) goto l_0x1012_a37a; /* jnz 0x1012a37a */
            ii(0x1012_a362, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1012_a365, 3); mov(edx, memd_a32[ds, eax + 0x15]);     /* mov edx, [eax+0x15] */
            ii(0x1012_a368, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1012_a36b, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1012_a36e, 3); mov(al, memb_a32[ds, eax + 0x27]);      /* mov al, [eax+0x27] */
            ii(0x1012_a371, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1012_a376, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x1012_a378, 2); if(jzd(0x1012_a3d4, 0x5a)) goto l_0x1012_a3d4; /* jz 0x1012a3d4 */
        l_0x1012_a37a:
            ii(0x1012_a37a, 6); lea(ebx, ebp - 0x364);                  /* lea ebx, [ebp-0x364] */
            ii(0x1012_a380, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1012_a383, 3); mov(edx, memd_a32[ds, eax + 0x15]);     /* mov edx, [eax+0x15] */
            ii(0x1012_a386, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1012_a389, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1012_a38c, 3); mov(eax, memd_a32[ds, eax + 0x13]);     /* mov eax, [eax+0x13] */
            ii(0x1012_a38f, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1012_a392, 5); calld(0x1012_a108, -0x28f);             /* call 0x1012a108 */
            ii(0x1012_a397, 1); pushd(eax);                             /* push eax */
            ii(0x1012_a398, 6); lea(edx, ebp - 0x38c);                  /* lea edx, [ebp-0x38c] */
            ii(0x1012_a39e, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1012_a3a1, 5); calld(0x1012_a15b, -0x24b);             /* call 0x1012a15b */
            ii(0x1012_a3a6, 1); pushd(eax);                             /* push eax */
            ii(0x1012_a3a7, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1012_a3aa, 3); mov(al, memb_a32[ds, eax + 0x26]);      /* mov al, [eax+0x26] */
            ii(0x1012_a3ad, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1012_a3b2, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x1012_a3b5, 4); pushd(memd_a32[ds, eax + ebp - 0x1c]);  /* push dword [eax+ebp-0x1c] */
            ii(0x1012_a3b9, 5); mov(eax, StringDefinitions.STeamSS);    /* mov eax, 0x101a8400 */
            ii(0x1012_a3be, 1); pushd(eax);                             /* push eax */
            ii(0x1012_a3bf, 6); lea(eax, ebp - 0x3dc);                  /* lea eax, [ebp-0x3dc] */
            ii(0x1012_a3c5, 1); pushd(eax);                             /* push eax */
            ii(0x1012_a3c6, 5); calld(Definitions.sys_sprintf, 0x3bb36); /* call 0x10165f01 */
            ii(0x1012_a3cb, 3); add(esp, 0x14);                         /* add esp, 0x14 */
            ii(0x1012_a3ce, 4); mov(memb_a32[ss, ebp - 0xc], 0x1);      /* mov byte [ebp-0xc], 0x1 */
            ii(0x1012_a3d2, 2); jmpd(0x1012_a40a, 0x36); goto l_0x1012_a40a; /* jmp 0x1012a40a */
        l_0x1012_a3d4:
            ii(0x1012_a3d4, 6); lea(edx, ebp - 0x38c);                  /* lea edx, [ebp-0x38c] */
            ii(0x1012_a3da, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1012_a3dd, 5); calld(0x1012_a15b, -0x287);             /* call 0x1012a15b */
            ii(0x1012_a3e2, 1); pushd(eax);                             /* push eax */
            ii(0x1012_a3e3, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1012_a3e6, 3); mov(al, memb_a32[ds, eax + 0x26]);      /* mov al, [eax+0x26] */
            ii(0x1012_a3e9, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1012_a3ee, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x1012_a3f1, 4); pushd(memd_a32[ds, eax + ebp - 0x1c]);  /* push dword [eax+ebp-0x1c] */
            ii(0x1012_a3f5, 5); mov(eax, StringDefinitions.STeamS);     /* mov eax, 0x101a841a */
            ii(0x1012_a3fa, 1); pushd(eax);                             /* push eax */
            ii(0x1012_a3fb, 6); lea(eax, ebp - 0x3dc);                  /* lea eax, [ebp-0x3dc] */
            ii(0x1012_a401, 1); pushd(eax);                             /* push eax */
            ii(0x1012_a402, 5); calld(Definitions.sys_sprintf, 0x3bafa); /* call 0x10165f01 */
            ii(0x1012_a407, 3); add(esp, 0x10);                         /* add esp, 0x10 */
        l_0x1012_a40a:
            ii(0x1012_a40a, 6); lea(edx, ebp - 0x3dc);                  /* lea edx, [ebp-0x3dc] */
            ii(0x1012_a410, 6); lea(eax, ebp - 0x33c);                  /* lea eax, [ebp-0x33c] */
            ii(0x1012_a416, 5); calld(Definitions.sys_strcat, 0x3bb16); /* call 0x10165f31 */
            ii(0x1012_a41b, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1012_a41e, 3); mov(eax, memd_a32[ds, eax + 0x3a]);     /* mov eax, [eax+0x3a] */
            ii(0x1012_a421, 3); sar(eax, 0x18);                         /* sar eax, 0x18 */
            ii(0x1012_a424, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1012_a426, 2); if(jld(0x1012_a431, 0x9)) goto l_0x1012_a431; /* jl 0x1012a431 */
            ii(0x1012_a428, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1012_a42b, 4); cmp(memb_a32[ds, eax + 0x3d], 0x20);    /* cmp byte [eax+0x3d], 0x20 */
            ii(0x1012_a42f, 2); if(jld(0x1012_a433, 0x2)) goto l_0x1012_a433; /* jl 0x1012a433 */
        l_0x1012_a431:
            ii(0x1012_a431, 2); jmpd(0x1012_a43d, 0xa); goto l_0x1012_a43d; /* jmp 0x1012a43d */
        l_0x1012_a433:
            ii(0x1012_a433, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1012_a436, 3); movsx(eax, memb_a32[ds, eax]);          /* movsx eax, byte [eax] */
            ii(0x1012_a439, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1012_a43b, 2); if(jged(0x1012_a43f, 0x2)) goto l_0x1012_a43f; /* jge 0x1012a43f */
        l_0x1012_a43d:
            ii(0x1012_a43d, 2); jmpd(0x1012_a447, 0x8); goto l_0x1012_a447; /* jmp 0x1012a447 */
        l_0x1012_a43f:
            ii(0x1012_a43f, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1012_a442, 3); cmp(memb_a32[ds, eax], 0x20);           /* cmp byte [eax], 0x20 */
            ii(0x1012_a445, 2); if(jld(0x1012_a471, 0x2a)) goto l_0x1012_a471; /* jl 0x1012a471 */
        l_0x1012_a447:
            ii(0x1012_a447, 5); mov(ecx, StringDefinitions.UnitordersII); /* mov ecx, 0x101a8429 */
            ii(0x1012_a44c, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1012_a44f, 4); movsx(ax, memb_a32[ds, eax]);           /* movsx ax, byte [eax] */
            ii(0x1012_a453, 3); movsx(ebx, ax);                         /* movsx ebx, ax */
            ii(0x1012_a456, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1012_a459, 5); movsx(ax, memb_a32[ds, eax + 0x3d]);    /* movsx ax, byte [eax+0x3d] */
            ii(0x1012_a45e, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x1012_a461, 6); lea(eax, ebp - 0x33c);                  /* lea eax, [ebp-0x33c] */
            ii(0x1012_a467, 5); calld(0x1012_a2ae, -0x1be);             /* call 0x1012a2ae */
            ii(0x1012_a46c, 3); or(memb_a32[ss, ebp - 0xc], al);        /* or [ebp-0xc], al */
            ii(0x1012_a46f, 2); jmpd(0x1012_a4c9, 0x58); goto l_0x1012_a4c9; /* jmp 0x1012a4c9 */
        l_0x1012_a471:
            ii(0x1012_a471, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1012_a474, 3); mov(dl, memb_a32[ds, eax + 0x3d]);      /* mov dl, [eax+0x3d] */
            ii(0x1012_a477, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1012_a47a, 2); cmp(dl, memb_a32[ds, eax]);             /* cmp dl, [eax] */
            ii(0x1012_a47c, 2); if(jzd(0x1012_a4c9, 0x4b)) goto l_0x1012_a4c9; /* jz 0x1012a4c9 */
            ii(0x1012_a47e, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1012_a481, 3); movsx(eax, memb_a32[ds, eax]);          /* movsx eax, byte [eax] */
            ii(0x1012_a484, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x1012_a487, 6); pushd(memd_a32[ds, eax + 0x101b_8978]); /* push dword [eax+0x101b8978] */
            ii(0x1012_a48d, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1012_a490, 3); mov(eax, memd_a32[ds, eax + 0x3a]);     /* mov eax, [eax+0x3a] */
            ii(0x1012_a493, 3); sar(eax, 0x18);                         /* sar eax, 0x18 */
            ii(0x1012_a496, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x1012_a499, 6); pushd(memd_a32[ds, eax + 0x101b_8978]); /* push dword [eax+0x101b8978] */
            ii(0x1012_a49f, 5); mov(eax, StringDefinitions.UnitordersSS); /* mov eax, 0x101a8442 */
            ii(0x1012_a4a4, 1); pushd(eax);                             /* push eax */
            ii(0x1012_a4a5, 6); lea(eax, ebp - 0x3dc);                  /* lea eax, [ebp-0x3dc] */
            ii(0x1012_a4ab, 1); pushd(eax);                             /* push eax */
            ii(0x1012_a4ac, 5); calld(Definitions.sys_sprintf, 0x3ba50); /* call 0x10165f01 */
            ii(0x1012_a4b1, 3); add(esp, 0x10);                         /* add esp, 0x10 */
            ii(0x1012_a4b4, 6); lea(edx, ebp - 0x3dc);                  /* lea edx, [ebp-0x3dc] */
            ii(0x1012_a4ba, 6); lea(eax, ebp - 0x33c);                  /* lea eax, [ebp-0x33c] */
            ii(0x1012_a4c0, 5); calld(Definitions.sys_strcat, 0x3ba6c); /* call 0x10165f31 */
            ii(0x1012_a4c5, 4); mov(memb_a32[ss, ebp - 0xc], 0x1);      /* mov byte [ebp-0xc], 0x1 */
        l_0x1012_a4c9:
            ii(0x1012_a4c9, 5); mov(ecx, StringDefinitions.UnitstateII); /* mov ecx, 0x101a845b */
            ii(0x1012_a4ce, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1012_a4d1, 5); movsx(ax, memb_a32[ds, eax + 0x1]);     /* movsx ax, byte [eax+0x1] */
            ii(0x1012_a4d6, 3); movsx(ebx, ax);                         /* movsx ebx, ax */
            ii(0x1012_a4d9, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1012_a4dc, 5); movsx(ax, memb_a32[ds, eax + 0x3e]);    /* movsx ax, byte [eax+0x3e] */
            ii(0x1012_a4e1, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x1012_a4e4, 6); lea(eax, ebp - 0x33c);                  /* lea eax, [ebp-0x33c] */
            ii(0x1012_a4ea, 5); calld(0x1012_a2ae, -0x241);             /* call 0x1012a2ae */
            ii(0x1012_a4ef, 3); or(memb_a32[ss, ebp - 0xc], al);        /* or [ebp-0xc], al */
            ii(0x1012_a4f2, 5); mov(ecx, StringDefinitions.MapXII);     /* mov ecx, 0x101a8474 */
            ii(0x1012_a4f7, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1012_a4fa, 3); mov(ebx, memd_a32[ds, eax + 0x17]);     /* mov ebx, [eax+0x17] */
            ii(0x1012_a4fd, 3); sar(ebx, 0x10);                         /* sar ebx, 0x10 */
            ii(0x1012_a500, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1012_a503, 3); mov(edx, memd_a32[ds, eax + 0x18]);     /* mov edx, [eax+0x18] */
            ii(0x1012_a506, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1012_a509, 6); lea(eax, ebp - 0x33c);                  /* lea eax, [ebp-0x33c] */
            ii(0x1012_a50f, 5); calld(0x1012_a2ae, -0x266);             /* call 0x1012a2ae */
            ii(0x1012_a514, 3); or(memb_a32[ss, ebp - 0xc], al);        /* or [ebp-0xc], al */
            ii(0x1012_a517, 5); mov(ecx, StringDefinitions.MapYII);     /* mov ecx, 0x101a848d */
            ii(0x1012_a51c, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1012_a51f, 3); mov(ebx, memd_a32[ds, eax + 0x19]);     /* mov ebx, [eax+0x19] */
            ii(0x1012_a522, 3); sar(ebx, 0x10);                         /* sar ebx, 0x10 */
            ii(0x1012_a525, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1012_a528, 3); mov(edx, memd_a32[ds, eax + 0x1a]);     /* mov edx, [eax+0x1a] */
            ii(0x1012_a52b, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1012_a52e, 6); lea(eax, ebp - 0x33c);                  /* lea eax, [ebp-0x33c] */
            ii(0x1012_a534, 5); calld(0x1012_a2ae, -0x28b);             /* call 0x1012a2ae */
            ii(0x1012_a539, 3); or(memb_a32[ss, ebp - 0xc], al);        /* or [ebp-0xc], al */
            ii(0x1012_a53c, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1012_a53f, 4); cmp(memb_a32[ds, eax + 0x3d], 0x4);     /* cmp byte [eax+0x3d], 0x4 */
            ii(0x1012_a543, 2); if(jnzd(0x1012_a593, 0x4e)) goto l_0x1012_a593; /* jnz 0x1012a593 */
            ii(0x1012_a545, 5); mov(ecx, StringDefinitions.BuildTurnsII); /* mov ecx, 0x101a84a6 */
            ii(0x1012_a54a, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1012_a54d, 3); mov(ebx, memd_a32[ds, eax + 0xf]);      /* mov ebx, [eax+0xf] */
            ii(0x1012_a550, 3); sar(ebx, 0x10);                         /* sar ebx, 0x10 */
            ii(0x1012_a553, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1012_a556, 3); mov(al, memb_a32[ds, eax + 0x45]);      /* mov al, [eax+0x45] */
            ii(0x1012_a559, 2); xor(ah, ah);                            /* xor ah, ah */
            ii(0x1012_a55b, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x1012_a55e, 6); lea(eax, ebp - 0x33c);                  /* lea eax, [ebp-0x33c] */
            ii(0x1012_a564, 5); calld(0x1012_a2ae, -0x2bb);             /* call 0x1012a2ae */
            ii(0x1012_a569, 3); or(memb_a32[ss, ebp - 0xc], al);        /* or [ebp-0xc], al */
            ii(0x1012_a56c, 5); mov(ecx, StringDefinitions.BuildRateII); /* mov ecx, 0x101a84bf */
            ii(0x1012_a571, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1012_a574, 3); mov(ebx, memd_a32[ds, eax + 0x11]);     /* mov ebx, [eax+0x11] */
            ii(0x1012_a577, 3); sar(ebx, 0x10);                         /* sar ebx, 0x10 */
            ii(0x1012_a57a, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1012_a57d, 5); calld(0x1009_c9a0, -0x8dbe2);           /* call 0x1009c9a0 */
            ii(0x1012_a582, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x1012_a585, 6); lea(eax, ebp - 0x33c);                  /* lea eax, [ebp-0x33c] */
            ii(0x1012_a58b, 5); calld(0x1012_a2ae, -0x2e2);             /* call 0x1012a2ae */
            ii(0x1012_a590, 3); or(memb_a32[ss, ebp - 0xc], al);        /* or [ebp-0xc], al */
        l_0x1012_a593:
            ii(0x1012_a593, 5); mov(ecx, StringDefinitions.PriorordersII); /* mov ecx, 0x101a84d8 */
            ii(0x1012_a598, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1012_a59b, 5); movsx(ax, memb_a32[ds, eax + 0x2]);     /* movsx ax, byte [eax+0x2] */
            ii(0x1012_a5a0, 3); movsx(ebx, ax);                         /* movsx ebx, ax */
            ii(0x1012_a5a3, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1012_a5a6, 5); movsx(ax, memb_a32[ds, eax + 0x3f]);    /* movsx ax, byte [eax+0x3f] */
            ii(0x1012_a5ab, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x1012_a5ae, 6); lea(eax, ebp - 0x33c);                  /* lea eax, [ebp-0x33c] */
            ii(0x1012_a5b4, 5); calld(0x1012_a2ae, -0x30b);             /* call 0x1012a2ae */
            ii(0x1012_a5b9, 3); or(memb_a32[ss, ebp - 0xc], al);        /* or [ebp-0xc], al */
            ii(0x1012_a5bc, 5); mov(ecx, StringDefinitions.ParentUnitSS); /* mov ecx, 0x101a84f1 */
            ii(0x1012_a5c1, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1012_a5c4, 3); mov(ebx, memd_a32[ds, eax + 0x3]);      /* mov ebx, [eax+0x3] */
            ii(0x1012_a5c7, 3); sar(ebx, 0x10);                         /* sar ebx, 0x10 */
            ii(0x1012_a5ca, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1012_a5cd, 5); calld(0x1007_611c, -0xb44b6);           /* call 0x1007611c */
            ii(0x1012_a5d2, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1012_a5d4, 6); lea(eax, ebp - 0x33c);                  /* lea eax, [ebp-0x33c] */
            ii(0x1012_a5da, 5); calld(0x1012_a1ba, -0x425);             /* call 0x1012a1ba */
            ii(0x1012_a5df, 3); or(memb_a32[ss, ebp - 0xc], al);        /* or [ebp-0xc], al */
            ii(0x1012_a5e2, 5); mov(ecx, StringDefinitions.TargetgridxII); /* mov ecx, 0x101a850a */
            ii(0x1012_a5e7, 3); mov(ebx, memd_a32[ss, ebp - 0x4]);      /* mov ebx, [ebp-0x4] */
            ii(0x1012_a5ea, 3); mov(ebx, memd_a32[ds, ebx + 0x5]);      /* mov ebx, [ebx+0x5] */
            ii(0x1012_a5ed, 3); sar(ebx, 0x10);                         /* sar ebx, 0x10 */
            ii(0x1012_a5f0, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x1012_a5f3, 3); mov(edx, memd_a32[ds, edx + 0x3f]);     /* mov edx, [edx+0x3f] */
            ii(0x1012_a5f6, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1012_a5f9, 6); lea(eax, ebp - 0x33c);                  /* lea eax, [ebp-0x33c] */
            ii(0x1012_a5ff, 5); calld(0x1012_a2ae, -0x356);             /* call 0x1012a2ae */
            ii(0x1012_a604, 3); or(memb_a32[ss, ebp - 0xc], al);        /* or [ebp-0xc], al */
            ii(0x1012_a607, 5); mov(ecx, StringDefinitions.TargetgridyII); /* mov ecx, 0x101a8523 */
            ii(0x1012_a60c, 3); mov(ebx, memd_a32[ss, ebp - 0x4]);      /* mov ebx, [ebp-0x4] */
            ii(0x1012_a60f, 3); mov(ebx, memd_a32[ds, ebx + 0x7]);      /* mov ebx, [ebx+0x7] */
            ii(0x1012_a612, 3); sar(ebx, 0x10);                         /* sar ebx, 0x10 */
            ii(0x1012_a615, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x1012_a618, 3); mov(edx, memd_a32[ds, edx + 0x41]);     /* mov edx, [edx+0x41] */
            ii(0x1012_a61b, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1012_a61e, 6); lea(eax, ebp - 0x33c);                  /* lea eax, [ebp-0x33c] */
            ii(0x1012_a624, 5); calld(0x1012_a2ae, -0x37b);             /* call 0x1012a2ae */
            ii(0x1012_a629, 3); or(memb_a32[ss, ebp - 0xc], al);        /* or [ebp-0xc], al */
            ii(0x1012_a62c, 5); mov(ecx, StringDefinitions.ProductionTotII); /* mov ecx, 0x101a853c */
            ii(0x1012_a631, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x1012_a634, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1012_a636, 3); mov(al, memb_a32[ds, edx + 0xd]);       /* mov al, [edx+0xd] */
            ii(0x1012_a639, 3); movsx(ebx, ax);                         /* movsx ebx, ax */
            ii(0x1012_a63c, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x1012_a63f, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1012_a641, 3); mov(al, memb_a32[ds, edx + 0x46]);      /* mov al, [edx+0x46] */
            ii(0x1012_a644, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x1012_a647, 6); lea(eax, ebp - 0x33c);                  /* lea eax, [ebp-0x33c] */
            ii(0x1012_a64d, 5); calld(0x1012_a2ae, -0x3a4);             /* call 0x1012a2ae */
            ii(0x1012_a652, 3); or(memb_a32[ss, ebp - 0xc], al);        /* or [ebp-0xc], al */
            ii(0x1012_a655, 5); mov(ecx, StringDefinitions.MaterialAllocII); /* mov ecx, 0x101a8555 */
            ii(0x1012_a65a, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x1012_a65d, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1012_a65f, 3); mov(al, memb_a32[ds, edx + 0xe]);       /* mov al, [edx+0xe] */
            ii(0x1012_a662, 3); movsx(ebx, ax);                         /* movsx ebx, ax */
            ii(0x1012_a665, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x1012_a668, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1012_a66a, 3); mov(al, memb_a32[ds, edx + 0x47]);      /* mov al, [edx+0x47] */
            ii(0x1012_a66d, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x1012_a670, 6); lea(eax, ebp - 0x33c);                  /* lea eax, [ebp-0x33c] */
            ii(0x1012_a676, 5); calld(0x1012_a2ae, -0x3cd);             /* call 0x1012a2ae */
            ii(0x1012_a67b, 3); or(memb_a32[ss, ebp - 0xc], al);        /* or [ebp-0xc], al */
            ii(0x1012_a67e, 5); mov(ecx, StringDefinitions.FuelAllocII); /* mov ecx, 0x101a856e */
            ii(0x1012_a683, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1012_a686, 3); mov(al, memb_a32[ds, eax + 0xf]);       /* mov al, [eax+0xf] */
            ii(0x1012_a689, 2); xor(ah, ah);                            /* xor ah, ah */
            ii(0x1012_a68b, 3); movsx(ebx, ax);                         /* movsx ebx, ax */
            ii(0x1012_a68e, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1012_a691, 3); mov(al, memb_a32[ds, eax + 0x48]);      /* mov al, [eax+0x48] */
            ii(0x1012_a694, 2); xor(ah, ah);                            /* xor ah, ah */
            ii(0x1012_a696, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x1012_a699, 6); lea(eax, ebp - 0x33c);                  /* lea eax, [ebp-0x33c] */
            ii(0x1012_a69f, 5); calld(0x1012_a2ae, -0x3f6);             /* call 0x1012a2ae */
            ii(0x1012_a6a4, 3); or(memb_a32[ss, ebp - 0xc], al);        /* or [ebp-0xc], al */
            ii(0x1012_a6a7, 5); mov(ecx, StringDefinitions.GoldAllocII); /* mov ecx, 0x101a8587 */
            ii(0x1012_a6ac, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1012_a6af, 3); mov(al, memb_a32[ds, eax + 0x10]);      /* mov al, [eax+0x10] */
            ii(0x1012_a6b2, 2); xor(ah, ah);                            /* xor ah, ah */
            ii(0x1012_a6b4, 3); movsx(ebx, ax);                         /* movsx ebx, ax */
            ii(0x1012_a6b7, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1012_a6ba, 3); mov(al, memb_a32[ds, eax + 0x49]);      /* mov al, [eax+0x49] */
            ii(0x1012_a6bd, 2); xor(ah, ah);                            /* xor ah, ah */
            ii(0x1012_a6bf, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x1012_a6c2, 6); lea(eax, ebp - 0x33c);                  /* lea eax, [ebp-0x33c] */
            ii(0x1012_a6c8, 5); calld(0x1012_a2ae, -0x41f);             /* call 0x1012a2ae */
            ii(0x1012_a6cd, 3); or(memb_a32[ss, ebp - 0xc], al);        /* or [ebp-0xc], al */
            ii(0x1012_a6d0, 5); mov(ecx, StringDefinitions.HitsII);     /* mov ecx, 0x101a85a0 */
            ii(0x1012_a6d5, 3); mov(ebx, memd_a32[ss, ebp - 0x4]);      /* mov ebx, [ebp-0x4] */
            ii(0x1012_a6d8, 3); mov(ebx, memd_a32[ds, ebx + 0x1d]);     /* mov ebx, [ebx+0x1d] */
            ii(0x1012_a6db, 3); sar(ebx, 0x10);                         /* sar ebx, 0x10 */
            ii(0x1012_a6de, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x1012_a6e1, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1012_a6e3, 3); mov(al, memb_a32[ds, edx + 0x4d]);      /* mov al, [edx+0x4d] */
            ii(0x1012_a6e6, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x1012_a6e9, 6); lea(eax, ebp - 0x33c);                  /* lea eax, [ebp-0x33c] */
            ii(0x1012_a6ef, 5); calld(0x1012_a2ae, -0x446);             /* call 0x1012a2ae */
            ii(0x1012_a6f4, 3); or(memb_a32[ss, ebp - 0xc], al);        /* or [ebp-0xc], al */
            ii(0x1012_a6f7, 5); mov(ecx, StringDefinitions.SpeedII);    /* mov ecx, 0x101a85b9 */
            ii(0x1012_a6fc, 3); mov(ebx, memd_a32[ss, ebp - 0x4]);      /* mov ebx, [ebp-0x4] */
            ii(0x1012_a6ff, 3); mov(ebx, memd_a32[ds, ebx + 0x1f]);     /* mov ebx, [ebx+0x1f] */
            ii(0x1012_a702, 3); sar(ebx, 0x10);                         /* sar ebx, 0x10 */
            ii(0x1012_a705, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x1012_a708, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1012_a70a, 3); mov(al, memb_a32[ds, edx + 0x4e]);      /* mov al, [edx+0x4e] */
            ii(0x1012_a70d, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x1012_a710, 6); lea(eax, ebp - 0x33c);                  /* lea eax, [ebp-0x33c] */
            ii(0x1012_a716, 5); calld(0x1012_a2ae, -0x46d);             /* call 0x1012a2ae */
            ii(0x1012_a71b, 3); or(memb_a32[ss, ebp - 0xc], al);        /* or [ebp-0xc], al */
            ii(0x1012_a71e, 5); mov(ecx, StringDefinitions.RoundsII);   /* mov ecx, 0x101a85d2 */
            ii(0x1012_a723, 3); mov(ebx, memd_a32[ss, ebp - 0x4]);      /* mov ebx, [ebp-0x4] */
            ii(0x1012_a726, 3); mov(ebx, memd_a32[ds, ebx + 0x21]);     /* mov ebx, [ebx+0x21] */
            ii(0x1012_a729, 3); sar(ebx, 0x10);                         /* sar ebx, 0x10 */
            ii(0x1012_a72c, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x1012_a72f, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1012_a731, 3); mov(al, memb_a32[ds, edx + 0x50]);      /* mov al, [edx+0x50] */
            ii(0x1012_a734, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x1012_a737, 6); lea(eax, ebp - 0x33c);                  /* lea eax, [ebp-0x33c] */
            ii(0x1012_a73d, 5); calld(0x1012_a2ae, -0x494);             /* call 0x1012a2ae */
            ii(0x1012_a742, 3); or(memb_a32[ss, ebp - 0xc], al);        /* or [ebp-0xc], al */
            ii(0x1012_a745, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1012_a748, 3); mov(eax, memd_a32[ds, eax + 0x6]);      /* mov eax, [eax+0x6] */
            ii(0x1012_a74b, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1012_a74e, 3); imul(eax, eax, 0x33);                   /* imul eax, eax, 0x33 */
            ii(0x1012_a751, 7); cmp(memb_a32[ds, eax + 0x101c_81d5], 0); /* cmp byte [eax+0x101c81d5], 0x0 */
            ii(0x1012_a758, 2); if(jzd(0x1012_a77f, 0x25)) goto l_0x1012_a77f; /* jz 0x1012a77f */
            ii(0x1012_a75a, 5); mov(ecx, StringDefinitions.StorageII);  /* mov ecx, 0x101a85eb */
            ii(0x1012_a75f, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1012_a762, 3); mov(ebx, memd_a32[ds, eax + 0x23]);     /* mov ebx, [eax+0x23] */
            ii(0x1012_a765, 3); sar(ebx, 0x10);                         /* sar ebx, 0x10 */
            ii(0x1012_a768, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1012_a76b, 3); mov(edx, memd_a32[ds, eax + 0x50]);     /* mov edx, [eax+0x50] */
            ii(0x1012_a76e, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1012_a771, 6); lea(eax, ebp - 0x33c);                  /* lea eax, [ebp-0x33c] */
            ii(0x1012_a777, 5); calld(0x1012_a2ae, -0x4ce);             /* call 0x1012a2ae */
            ii(0x1012_a77c, 3); or(memb_a32[ss, ebp - 0xc], al);        /* or [ebp-0xc], al */
        l_0x1012_a77f:
            ii(0x1012_a77f, 5); mov(ecx, StringDefinitions.AmmoII);     /* mov ecx, 0x101a8604 */
            ii(0x1012_a784, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1012_a787, 3); mov(ebx, memd_a32[ds, eax + 0x25]);     /* mov ebx, [eax+0x25] */
            ii(0x1012_a78a, 3); sar(ebx, 0x10);                         /* sar ebx, 0x10 */
            ii(0x1012_a78d, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1012_a790, 3); mov(al, memb_a32[ds, eax + 0x54]);      /* mov al, [eax+0x54] */
            ii(0x1012_a793, 2); xor(ah, ah);                            /* xor ah, ah */
            ii(0x1012_a795, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x1012_a798, 6); lea(eax, ebp - 0x33c);                  /* lea eax, [ebp-0x33c] */
            ii(0x1012_a79e, 5); calld(0x1012_a2ae, -0x4f5);             /* call 0x1012a2ae */
            ii(0x1012_a7a3, 3); or(memb_a32[ss, ebp - 0xc], al);        /* or [ebp-0xc], al */
            ii(0x1012_a7a6, 5); mov(ecx, StringDefinitions.TeamIdII);   /* mov ecx, 0x101a861d */
            ii(0x1012_a7ab, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1012_a7ae, 3); mov(ebx, memd_a32[ds, eax + 0x1b]);     /* mov ebx, [eax+0x1b] */
            ii(0x1012_a7b1, 3); sar(ebx, 0x10);                         /* sar ebx, 0x10 */
            ii(0x1012_a7b4, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1012_a7b7, 3); mov(al, memb_a32[ds, eax + 0x26]);      /* mov al, [eax+0x26] */
            ii(0x1012_a7ba, 2); xor(ah, ah);                            /* xor ah, ah */
            ii(0x1012_a7bc, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x1012_a7bf, 6); lea(eax, ebp - 0x33c);                  /* lea eax, [ebp-0x33c] */
            ii(0x1012_a7c5, 5); calld(0x1012_a2ae, -0x51c);             /* call 0x1012a2ae */
            ii(0x1012_a7ca, 3); or(memb_a32[ss, ebp - 0xc], al);        /* or [ebp-0xc], al */
            ii(0x1012_a7cd, 4); cmp(memb_a32[ss, ebp - 0xc], 0);        /* cmp byte [ebp-0xc], 0x0 */
            ii(0x1012_a7d1, 2); if(jzd(0x1012_a7fa, 0x27)) goto l_0x1012_a7fa; /* jz 0x1012a7fa */
            ii(0x1012_a7d3, 5); calld(0x100c_aa00, -0x5fdd8);           /* call 0x100caa00 */
            ii(0x1012_a7d8, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1012_a7dd, 1); pushd(eax);                             /* push eax */
            ii(0x1012_a7de, 5); calld(0x100c_aa20, -0x5fdc3);           /* call 0x100caa20 */
            ii(0x1012_a7e3, 2); mov(ecx, eax);                          /* mov ecx, eax */
            ii(0x1012_a7e5, 5); mov(ebx, 0x1);                          /* mov ebx, 0x1 */
            ii(0x1012_a7ea, 5); mov(edx, 0x2);                          /* mov edx, 0x2 */
            ii(0x1012_a7ef, 6); lea(eax, ebp - 0x33c);                  /* lea eax, [ebp-0x33c] */
            ii(0x1012_a7f5, 5); calld(0x1011_5d23, -0x14ad7);           /* call 0x10115d23 */
        l_0x1012_a7fa:
            ii(0x1012_a7fa, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1012_a7fc, 1); popd(ebp);                              /* pop ebp */
            ii(0x1012_a7fd, 1); popd(edi);                              /* pop edi */
            ii(0x1012_a7fe, 1); popd(esi);                              /* pop esi */
            ii(0x1012_a7ff, 1); popd(ecx);                              /* pop ecx */
            ii(0x1012_a800, 1); popd(ebx);                              /* pop ebx */
            ii(0x1012_a801, 1); retd(); return;                         /* ret */
        }
    }
}
