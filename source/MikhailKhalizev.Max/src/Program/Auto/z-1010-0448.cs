using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("3914933f-1de1-4191-aa3d-f75e6fd73a86")]
        public void Method_1010_0448()
        {
            ii(0x1010_0448, 5); pushd(0x48);                            /* push 0x48 */
            ii(0x1010_044d, 5); calld(Definitions.sys_check_available_stack_size, 0x65900); /* call 0x10165d52 */
            ii(0x1010_0452, 1); pushd(ebx);                             /* push ebx */
            ii(0x1010_0453, 1); pushd(ecx);                             /* push ecx */
            ii(0x1010_0454, 1); pushd(edx);                             /* push edx */
            ii(0x1010_0455, 1); pushd(esi);                             /* push esi */
            ii(0x1010_0456, 1); pushd(edi);                             /* push edi */
            ii(0x1010_0457, 1); pushd(ebp);                             /* push ebp */
            ii(0x1010_0458, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1010_045a, 6); sub(esp, 0x24);                         /* sub esp, 0x24 */
            ii(0x1010_0460, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1010_0463, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1010_0466, 3); mov(eax, memd_a32[ds, eax + 0x6]);      /* mov eax, [eax+0x6] */
            ii(0x1010_0469, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1010_046c, 5); calld(0x1007_1ff5, -0x8e47c);           /* call 0x10071ff5 */
            ii(0x1010_0471, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1010_0474, 4); movsx(eax, memw_a32[ss, ebp - 0x8]);    /* movsx eax, word [ebp-0x8] */
            ii(0x1010_0478, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1010_047a, 2); if(jzd(0x1010_048f, 0x13)) goto l_0x1010_048f; /* jz 0x1010048f */
            ii(0x1010_047c, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1010_047f, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1010_0481, 3); mov(dl, memb_a32[ds, eax + 0x26]);      /* mov dl, [eax+0x26] */
            ii(0x1010_0484, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1010_0486, 5); mov(al, memb_a32[ds, 0x101c_37da]);     /* mov al, [0x101c37da] */
            ii(0x1010_048b, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x1010_048d, 2); if(jzd(0x1010_0494, 0x5)) goto l_0x1010_0494; /* jz 0x10100494 */
        l_0x1010_048f:
            ii(0x1010_048f, 5); jmpd(0x1010_067a, 0x1e6); goto l_0x1010_067a; /* jmp 0x1010067a */
        l_0x1010_0494:
            ii(0x1010_0494, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1010_0497, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x1010_049a, 7); mov(memd_a32[ss, ebp - 0x14], 0);       /* mov dword [ebp-0x14], 0x0 */
            ii(0x1010_04a1, 7); mov(memd_a32[ss, ebp - 0xc], 0);        /* mov dword [ebp-0xc], 0x0 */
            ii(0x1010_04a8, 3); lea(eax, ebp - 0x20);                   /* lea eax, [ebp-0x20] */
            ii(0x1010_04ab, 5); calld(0x1007_20b1, -0x8e3ff);           /* call 0x100720b1 */
            ii(0x1010_04b0, 5); calld(0x1007_6014, -0x8a4a1);           /* call 0x10076014 */
            ii(0x1010_04b5, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x1010_04b7, 2); mov(bl, al);                            /* mov bl, al */
            ii(0x1010_04b9, 3); lea(edx, ebp - 0x20);                   /* lea edx, [ebp-0x20] */
            ii(0x1010_04bc, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1010_04bf, 5); calld(0x1007_2388, -0x8e13c);           /* call 0x10072388 */
            ii(0x1010_04c4, 3); mov(eax, memd_a32[ss, ebp - 0x18]);     /* mov eax, [ebp-0x18] */
            ii(0x1010_04c7, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x1010_04ca, 4); movsx(eax, memw_a32[ss, ebp - 0x8]);    /* movsx eax, word [ebp-0x8] */
            ii(0x1010_04ce, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1010_04d0, 2); if(jged(0x1010_0503, 0x31)) goto l_0x1010_0503; /* jge 0x10100503 */
            ii(0x1010_04d2, 5); mov(eax, 0x1);                          /* mov eax, 0x1 */
            ii(0x1010_04d7, 1); pushd(eax);                             /* push eax */
            ii(0x1010_04d8, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1010_04db, 2); neg(eax);                               /* neg eax */
            ii(0x1010_04dd, 5); and(eax, 0xffff);                       /* and eax, 0xffff */
            ii(0x1010_04e2, 1); pushd(eax);                             /* push eax */
            ii(0x1010_04e3, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1010_04e6, 2); neg(eax);                               /* neg eax */
            ii(0x1010_04e8, 2); xor(ecx, ecx);                          /* xor ecx, ecx */
            ii(0x1010_04ea, 3); mov(cx, ax);                            /* mov cx, ax */
            ii(0x1010_04ed, 5); mov(ebx, 0x28a);                        /* mov ebx, 0x28a */
            ii(0x1010_04f2, 5); mov(edx, 0xb);                          /* mov edx, 0xb */
            ii(0x1010_04f7, 5); mov(eax, 0x101a_2b49);                  /* mov eax, 0x101a2b49 */ /* "Teams" */
            ii(0x1010_04fc, 5); calld(0x100f_ff95, -0x56c);             /* call 0x100fff95 */
            ii(0x1010_0501, 2); jmpd(0x1010_052a, 0x27); goto l_0x1010_052a; /* jmp 0x1010052a */
        l_0x1010_0503:
            ii(0x1010_0503, 5); mov(eax, 0x1);                          /* mov eax, 0x1 */
            ii(0x1010_0508, 1); pushd(eax);                             /* push eax */
            ii(0x1010_0509, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1010_050b, 4); mov(ax, memw_a32[ss, ebp - 0x8]);       /* mov ax, [ebp-0x8] */
            ii(0x1010_050f, 1); pushd(eax);                             /* push eax */
            ii(0x1010_0510, 2); xor(ecx, ecx);                          /* xor ecx, ecx */
            ii(0x1010_0512, 4); mov(cx, memw_a32[ss, ebp - 0x10]);      /* mov cx, [ebp-0x10] */
            ii(0x1010_0516, 5); mov(ebx, 0x28a);                        /* mov ebx, 0x28a */
            ii(0x1010_051b, 5); mov(edx, 0xb);                          /* mov edx, 0xb */
            ii(0x1010_0520, 5); mov(eax, 0x101a_2b4f);                  /* mov eax, 0x101a2b4f */ /* "Usage" */
            ii(0x1010_0525, 5); calld(0x100f_ff95, -0x595);             /* call 0x100fff95 */
        l_0x1010_052a:
            ii(0x1010_052a, 7); mov(memd_a32[ss, ebp - 0x8], 0);        /* mov dword [ebp-0x8], 0x0 */
            ii(0x1010_0531, 7); mov(memd_a32[ss, ebp - 0x10], 0);       /* mov dword [ebp-0x10], 0x0 */
            ii(0x1010_0538, 5); mov(eax, 0x101c_819c);                  /* mov eax, 0x101c819c */
            ii(0x1010_053d, 5); calld(0x1007_6338, -0x8a20a);           /* call 0x10076338 */
            ii(0x1010_0542, 3); lea(ebx, ebp - 0x24);                   /* lea ebx, [ebp-0x24] */
            ii(0x1010_0545, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1010_0547, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x1010_0549, 5); calld(0x1007_64b8, -0x8a096);           /* call 0x100764b8 */
            ii(0x1010_054e, 2); jmpd(0x1010_0558, 0x8); goto l_0x1010_0558; /* jmp 0x10100558 */
        l_0x1010_0550:
            ii(0x1010_0550, 3); lea(eax, ebp - 0x24);                   /* lea eax, [ebp-0x24] */
            ii(0x1010_0553, 5); calld(0x1007_6bf8, -0x89960);           /* call 0x10076bf8 */
        l_0x1010_0558:
            ii(0x1010_0558, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1010_055a, 3); lea(eax, ebp - 0x24);                   /* lea eax, [ebp-0x24] */
            ii(0x1010_055d, 5); calld(0x1013_ad71, 0x3a80f);            /* call 0x1013ad71 */
            ii(0x1010_0562, 2); test(al, al);                           /* test al, al */
            ii(0x1010_0564, 6); if(jzd(0x1010_05e6, 0x7c)) goto l_0x1010_05e6; /* jz 0x101005e6 */
            ii(0x1010_056a, 3); lea(eax, ebp - 0x24);                   /* lea eax, [ebp-0x24] */
            ii(0x1010_056d, 5); calld(0x1007_63a0, -0x8a1d2);           /* call 0x100763a0 */
            ii(0x1010_0572, 5); calld(0x1007_6204, -0x8a373);           /* call 0x10076204 */
            ii(0x1010_0577, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1010_0579, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1010_057c, 5); calld(0x1007_6204, -0x8a37d);           /* call 0x10076204 */
            ii(0x1010_0581, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x1010_0583, 2); if(jnzd(0x1010_05e1, 0x5c)) goto l_0x1010_05e1; /* jnz 0x101005e1 */
            ii(0x1010_0585, 3); lea(eax, ebp - 0x24);                   /* lea eax, [ebp-0x24] */
            ii(0x1010_0588, 5); calld(0x1007_63a0, -0x8a1ed);           /* call 0x100763a0 */
            ii(0x1010_058d, 3); mov(eax, memd_a32[ds, eax + 0x6]);      /* mov eax, [eax+0x6] */
            ii(0x1010_0590, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1010_0593, 5); calld(0x1007_1ff5, -0x8e5a3);           /* call 0x10071ff5 */
            ii(0x1010_0598, 4); mov(memw_a32[ss, ebp - 0x18], ax);      /* mov [ebp-0x18], ax */
            ii(0x1010_059c, 4); movsx(eax, memw_a32[ss, ebp - 0x18]);   /* movsx eax, word [ebp-0x18] */
            ii(0x1010_05a0, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1010_05a2, 2); if(jged(0x1010_05ac, 0x8)) goto l_0x1010_05ac; /* jge 0x101005ac */
            ii(0x1010_05a4, 3); mov(eax, memd_a32[ss, ebp - 0x18]);     /* mov eax, [ebp-0x18] */
            ii(0x1010_05a7, 3); sub(memd_a32[ss, ebp - 0x8], eax);      /* sub [ebp-0x8], eax */
            ii(0x1010_05aa, 2); jmpd(0x1010_05b2, 0x6); goto l_0x1010_05b2; /* jmp 0x101005b2 */
        l_0x1010_05ac:
            ii(0x1010_05ac, 3); mov(eax, memd_a32[ss, ebp - 0x18]);     /* mov eax, [ebp-0x18] */
            ii(0x1010_05af, 3); add(memd_a32[ss, ebp - 0xc], eax);      /* add [ebp-0xc], eax */
        l_0x1010_05b2:
            ii(0x1010_05b2, 5); calld(0x1007_6014, -0x8a5a3);           /* call 0x10076014 */
            ii(0x1010_05b7, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x1010_05b9, 2); mov(bl, al);                            /* mov bl, al */
            ii(0x1010_05bb, 3); lea(edx, ebp - 0x20);                   /* lea edx, [ebp-0x20] */
            ii(0x1010_05be, 3); lea(eax, ebp - 0x24);                   /* lea eax, [ebp-0x24] */
            ii(0x1010_05c1, 5); calld(0x1007_63d4, -0x8a1f2);           /* call 0x100763d4 */
            ii(0x1010_05c6, 5); calld(0x1007_2388, -0x8e243);           /* call 0x10072388 */
            ii(0x1010_05cb, 4); movsx(eax, memw_a32[ss, ebp - 0x18]);   /* movsx eax, word [ebp-0x18] */
            ii(0x1010_05cf, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1010_05d1, 2); if(jged(0x1010_05db, 0x8)) goto l_0x1010_05db; /* jge 0x101005db */
            ii(0x1010_05d3, 3); mov(eax, memd_a32[ss, ebp - 0x18]);     /* mov eax, [ebp-0x18] */
            ii(0x1010_05d6, 3); sub(memd_a32[ss, ebp - 0x14], eax);     /* sub [ebp-0x14], eax */
            ii(0x1010_05d9, 2); jmpd(0x1010_05e1, 0x6); goto l_0x1010_05e1; /* jmp 0x101005e1 */
        l_0x1010_05db:
            ii(0x1010_05db, 3); mov(eax, memd_a32[ss, ebp - 0x18]);     /* mov eax, [ebp-0x18] */
            ii(0x1010_05de, 3); add(memd_a32[ss, ebp - 0x10], eax);     /* add [ebp-0x10], eax */
        l_0x1010_05e1:
            ii(0x1010_05e1, 5); jmpd(0x1010_0550, -0x96); goto l_0x1010_0550; /* jmp 0x10100550 */
        l_0x1010_05e6:
            ii(0x1010_05e6, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1010_05e9, 3); mov(eax, memd_a32[ds, eax + 0x6]);      /* mov eax, [eax+0x6] */
            ii(0x1010_05ec, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1010_05ef, 5); calld(0x1007_1ff5, -0x8e5ff);           /* call 0x10071ff5 */
            ii(0x1010_05f4, 1); cwde();                                 /* cwde */
            ii(0x1010_05f5, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1010_05f7, 2); if(jled(0x1010_0622, 0x29)) goto l_0x1010_0622; /* jle 0x10100622 */
            ii(0x1010_05f9, 5); mov(eax, 0x1);                          /* mov eax, 0x1 */
            ii(0x1010_05fe, 1); pushd(eax);                             /* push eax */
            ii(0x1010_05ff, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1010_0601, 4); mov(ax, memw_a32[ss, ebp - 0xc]);       /* mov ax, [ebp-0xc] */
            ii(0x1010_0605, 1); pushd(eax);                             /* push eax */
            ii(0x1010_0606, 2); xor(ecx, ecx);                          /* xor ecx, ecx */
            ii(0x1010_0608, 4); mov(cx, memw_a32[ss, ebp - 0x14]);      /* mov cx, [ebp-0x14] */
            ii(0x1010_060c, 5); mov(ebx, 0x28a);                        /* mov ebx, 0x28a */
            ii(0x1010_0611, 5); mov(edx, 0xc);                          /* mov edx, 0xc */
            ii(0x1010_0616, 5); mov(eax, 0x101a_2b55);                  /* mov eax, 0x101a2b55 */ /* "Total" */
            ii(0x1010_061b, 5); calld(0x100f_ff95, -0x68b);             /* call 0x100fff95 */
            ii(0x1010_0620, 2); jmpd(0x1010_0670, 0x4e); goto l_0x1010_0670; /* jmp 0x10100670 */
        l_0x1010_0622:
            ii(0x1010_0622, 5); mov(eax, 0x1);                          /* mov eax, 0x1 */
            ii(0x1010_0627, 1); pushd(eax);                             /* push eax */
            ii(0x1010_0628, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1010_062a, 4); mov(ax, memw_a32[ss, ebp - 0x8]);       /* mov ax, [ebp-0x8] */
            ii(0x1010_062e, 1); pushd(eax);                             /* push eax */
            ii(0x1010_062f, 2); xor(ecx, ecx);                          /* xor ecx, ecx */
            ii(0x1010_0631, 4); mov(cx, memw_a32[ss, ebp - 0x10]);      /* mov cx, [ebp-0x10] */
            ii(0x1010_0635, 5); mov(ebx, 0x28a);                        /* mov ebx, 0x28a */
            ii(0x1010_063a, 5); mov(edx, 0xc);                          /* mov edx, 0xc */
            ii(0x1010_063f, 5); mov(eax, 0x101a_2b5b);                  /* mov eax, 0x101a2b5b */ /* "Total" */
            ii(0x1010_0644, 5); calld(0x100f_ff95, -0x6b4);             /* call 0x100fff95 */
            ii(0x1010_0649, 5); mov(eax, 0x1);                          /* mov eax, 0x1 */
            ii(0x1010_064e, 1); pushd(eax);                             /* push eax */
            ii(0x1010_064f, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1010_0651, 4); mov(ax, memw_a32[ss, ebp - 0xc]);       /* mov ax, [ebp-0xc] */
            ii(0x1010_0655, 1); pushd(eax);                             /* push eax */
            ii(0x1010_0656, 2); xor(ecx, ecx);                          /* xor ecx, ecx */
            ii(0x1010_0658, 4); mov(cx, memw_a32[ss, ebp - 0x14]);      /* mov cx, [ebp-0x14] */
            ii(0x1010_065c, 5); mov(ebx, 0x28a);                        /* mov ebx, 0x28a */
            ii(0x1010_0661, 5); mov(edx, 0xd);                          /* mov edx, 0xd */
            ii(0x1010_0666, 5); mov(eax, 0x101a_2b61);                  /* mov eax, 0x101a2b61 */ /* "Usage" */
            ii(0x1010_066b, 5); calld(0x100f_ff95, -0x6db);             /* call 0x100fff95 */
        l_0x1010_0670:
            ii(0x1010_0670, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1010_0672, 3); lea(eax, ebp - 0x24);                   /* lea eax, [ebp-0x24] */
            ii(0x1010_0675, 5); calld(0x1007_5f6c, -0x8a70e);           /* call 0x10075f6c */
        l_0x1010_067a:
            ii(0x1010_067a, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1010_067c, 1); popd(ebp);                              /* pop ebp */
            ii(0x1010_067d, 1); popd(edi);                              /* pop edi */
            ii(0x1010_067e, 1); popd(esi);                              /* pop esi */
            ii(0x1010_067f, 1); popd(edx);                              /* pop edx */
            ii(0x1010_0680, 1); popd(ecx);                              /* pop ecx */
            ii(0x1010_0681, 1); popd(ebx);                              /* pop ebx */
            ii(0x1010_0682, 1); retd(); return;                         /* ret */
        }
    }
}
