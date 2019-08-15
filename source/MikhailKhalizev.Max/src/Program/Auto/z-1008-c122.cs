using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("a2962b06-c587-4514-bf42-2be16cf67197")]
        public void Method_1008_c122()
        {
            ii(0x1008_c122, 5); pushd(0x3c);                            /* push 0x3c */
            ii(0x1008_c127, 5); calld(Definitions.sys_check_available_stack_size, 0xd_9c26); /* call 0x10165d52 */
            ii(0x1008_c12c, 1); pushd(ebx);                             /* push ebx */
            ii(0x1008_c12d, 1); pushd(ecx);                             /* push ecx */
            ii(0x1008_c12e, 1); pushd(edx);                             /* push edx */
            ii(0x1008_c12f, 1); pushd(esi);                             /* push esi */
            ii(0x1008_c130, 1); pushd(edi);                             /* push edi */
            ii(0x1008_c131, 1); pushd(ebp);                             /* push ebp */
            ii(0x1008_c132, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1008_c134, 6); sub(esp, 0x20);                         /* sub esp, 0x20 */
            ii(0x1008_c13a, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1008_c13d, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1008_c140, 3); add(eax, 0x1b);                         /* add eax, 0x1b */
            ii(0x1008_c143, 5); calld(0x1007_6574, -0x1_5bd4);          /* call 0x10076574 */
            ii(0x1008_c148, 4); cmp(memb_a32[ds, eax + 0x3d], 0x14);    /* cmp byte [eax+0x3d], 0x14 */
            ii(0x1008_c14c, 6); if(jzd(0x1008_c321, 0x1cf)) goto l_0x1008_c321; /* jz 0x1008c321 */
            ii(0x1008_c152, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1008_c155, 3); add(eax, 0x1b);                         /* add eax, 0x1b */
            ii(0x1008_c158, 5); calld(0x1007_6574, -0x1_5be9);          /* call 0x10076574 */
            ii(0x1008_c15d, 4); test(memb_a32[ds, eax + 0x13], 0x2);    /* test byte [eax+0x13], 0x2 */
            ii(0x1008_c161, 2); if(jnzd(0x1008_c1cf, 0x6c)) goto l_0x1008_c1cf; /* jnz 0x1008c1cf */
            ii(0x1008_c163, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1008_c166, 3); add(eax, 0x13);                         /* add eax, 0x13 */
            ii(0x1008_c169, 5); calld(0x1007_6574, -0x1_5bfa);          /* call 0x10076574 */
            ii(0x1008_c16e, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x1008_c171, 4); mov(dx, memw_a32[ds, edx + 0x1f]);      /* mov dx, [edx+0x1f] */
            ii(0x1008_c175, 4); sub(dx, memw_a32[ds, eax + 0x52]);      /* sub dx, [eax+0x52] */
            ii(0x1008_c179, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1008_c17c, 3); add(eax, 0x1b);                         /* add eax, 0x1b */
            ii(0x1008_c17f, 5); calld(0x1007_6574, -0x1_5c10);          /* call 0x10076574 */
            ii(0x1008_c184, 4); mov(memw_a32[ds, eax + 0x41], dx);      /* mov [eax+0x41], dx */
            ii(0x1008_c188, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1008_c18b, 3); add(eax, 0x1b);                         /* add eax, 0x1b */
            ii(0x1008_c18e, 5); calld(0x1007_6574, -0x1_5c1f);          /* call 0x10076574 */
            ii(0x1008_c193, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1008_c195, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1008_c198, 3); add(eax, 0x1b);                         /* add eax, 0x1b */
            ii(0x1008_c19b, 5); calld(0x1007_6574, -0x1_5c2c);          /* call 0x10076574 */
            ii(0x1008_c1a0, 4); mov(dx, memw_a32[ds, edx + 0x41]);      /* mov dx, [edx+0x41] */
            ii(0x1008_c1a4, 4); cmp(dx, memw_a32[ds, eax + 0x52]);      /* cmp dx, [eax+0x52] */
            ii(0x1008_c1a8, 2); if(jled(0x1008_c1ca, 0x20)) goto l_0x1008_c1ca; /* jle 0x1008c1ca */
            ii(0x1008_c1aa, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1008_c1ad, 3); add(eax, 0x1b);                         /* add eax, 0x1b */
            ii(0x1008_c1b0, 5); calld(0x1007_6574, -0x1_5c41);          /* call 0x10076574 */
            ii(0x1008_c1b5, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1008_c1b7, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1008_c1ba, 3); add(eax, 0x1b);                         /* add eax, 0x1b */
            ii(0x1008_c1bd, 5); calld(0x1007_6574, -0x1_5c4e);          /* call 0x10076574 */
            ii(0x1008_c1c2, 4); mov(dx, memw_a32[ds, edx + 0x52]);      /* mov dx, [edx+0x52] */
            ii(0x1008_c1c6, 4); mov(memw_a32[ds, eax + 0x41], dx);      /* mov [eax+0x41], dx */
        l_0x1008_c1ca:
            ii(0x1008_c1ca, 5); jmpd(0x1008_c2ab, 0xdc); goto l_0x1008_c2ab; /* jmp 0x1008c2ab */
        l_0x1008_c1cf:
            ii(0x1008_c1cf, 3); lea(eax, ebp - 0x10);                   /* lea eax, [ebp-0x10] */
            ii(0x1008_c1d2, 5); calld(0x1007_20b1, -0x1_a126);          /* call 0x100720b1 */
            ii(0x1008_c1d7, 3); lea(eax, ebp - 0x1c);                   /* lea eax, [ebp-0x1c] */
            ii(0x1008_c1da, 5); calld(0x1007_20b1, -0x1_a12e);          /* call 0x100720b1 */
            ii(0x1008_c1df, 3); lea(ebx, ebp - 0x1c);                   /* lea ebx, [ebp-0x1c] */
            ii(0x1008_c1e2, 3); lea(edx, ebp - 0x10);                   /* lea edx, [ebp-0x10] */
            ii(0x1008_c1e5, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1008_c1e8, 3); add(eax, 0x1b);                         /* add eax, 0x1b */
            ii(0x1008_c1eb, 5); calld(0x1007_6574, -0x1_5c7c);          /* call 0x10076574 */
            ii(0x1008_c1f0, 5); calld(0x1007_6204, -0x1_5ff1);          /* call 0x10076204 */
            ii(0x1008_c1f5, 5); calld(0x1014_3616, 0xb_741c);           /* call 0x10143616 */
            ii(0x1008_c1fa, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1008_c1fd, 3); add(eax, 0x13);                         /* add eax, 0x13 */
            ii(0x1008_c200, 5); calld(0x1007_6574, -0x1_5c91);          /* call 0x10076574 */
            ii(0x1008_c205, 5); calld(0x1007_623c, -0x1_5fce);          /* call 0x1007623c */
            ii(0x1008_c20a, 3); mov(eax, memd_a32[ds, eax + 0x17]);     /* mov eax, [eax+0x17] */
            ii(0x1008_c20d, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1008_c210, 2); add(eax, eax);                          /* add eax, eax */
            ii(0x1008_c212, 4); movsx(edx, memw_a32[ss, ebp - 0xe]);    /* movsx edx, word [ebp-0xe] */
            ii(0x1008_c216, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x1008_c218, 2); if(jged(0x1008_c223, 0x9)) goto l_0x1008_c223; /* jge 0x1008c223 */
            ii(0x1008_c21a, 3); mov(eax, memd_a32[ss, ebp - 0xe]);      /* mov eax, [ebp-0xe] */
            ii(0x1008_c21d, 4); cmp(ax, memw_a32[ss, ebp - 0x1a]);      /* cmp ax, [ebp-0x1a] */
            ii(0x1008_c221, 2); if(jnzd(0x1008_c25d, 0x3a)) goto l_0x1008_c25d; /* jnz 0x1008c25d */
        l_0x1008_c223:
            ii(0x1008_c223, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1008_c226, 3); add(eax, 0x13);                         /* add eax, 0x13 */
            ii(0x1008_c229, 5); calld(0x1007_6574, -0x1_5cba);          /* call 0x10076574 */
            ii(0x1008_c22e, 5); calld(0x1007_623c, -0x1_5ff7);          /* call 0x1007623c */
            ii(0x1008_c233, 2); mov(ebx, eax);                          /* mov ebx, eax */
            ii(0x1008_c235, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1008_c238, 3); add(eax, 0x13);                         /* add eax, 0x13 */
            ii(0x1008_c23b, 5); calld(0x1007_6574, -0x1_5ccc);          /* call 0x10076574 */
            ii(0x1008_c240, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1008_c242, 4); mov(ax, memw_a32[ds, ebx + 0x19]);      /* mov ax, [ebx+0x19] */
            ii(0x1008_c246, 4); sub(ax, memw_a32[ds, edx + 0x52]);      /* sub ax, [edx+0x52] */
            ii(0x1008_c24a, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1008_c24c, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1008_c24f, 3); add(eax, 0x1b);                         /* add eax, 0x1b */
            ii(0x1008_c252, 5); calld(0x1007_6574, -0x1_5ce3);          /* call 0x10076574 */
            ii(0x1008_c257, 4); mov(memw_a32[ds, eax + 0x41], dx);      /* mov [eax+0x41], dx */
            ii(0x1008_c25b, 2); jmpd(0x1008_c282, 0x25); goto l_0x1008_c282; /* jmp 0x1008c282 */
        l_0x1008_c25d:
            ii(0x1008_c25d, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1008_c260, 3); add(eax, 0x13);                         /* add eax, 0x13 */
            ii(0x1008_c263, 5); calld(0x1007_6574, -0x1_5cf4);          /* call 0x10076574 */
            ii(0x1008_c268, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x1008_c26b, 4); mov(dx, memw_a32[ds, edx + 0x1f]);      /* mov dx, [edx+0x1f] */
            ii(0x1008_c26f, 4); sub(dx, memw_a32[ds, eax + 0x52]);      /* sub dx, [eax+0x52] */
            ii(0x1008_c273, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1008_c276, 3); add(eax, 0x1b);                         /* add eax, 0x1b */
            ii(0x1008_c279, 5); calld(0x1007_6574, -0x1_5d0a);          /* call 0x10076574 */
            ii(0x1008_c27e, 4); mov(memw_a32[ds, eax + 0x41], dx);      /* mov [eax+0x41], dx */
        l_0x1008_c282:
            ii(0x1008_c282, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1008_c285, 3); add(eax, 0x1b);                         /* add eax, 0x1b */
            ii(0x1008_c288, 5); calld(0x1007_6574, -0x1_5d19);          /* call 0x10076574 */
            ii(0x1008_c28d, 4); mov(ax, memw_a32[ds, eax + 0x41]);      /* mov ax, [eax+0x41] */
            ii(0x1008_c291, 4); cmp(ax, memw_a32[ss, ebp - 0xe]);       /* cmp ax, [ebp-0xe] */
            ii(0x1008_c295, 2); if(jled(0x1008_c2ab, 0x14)) goto l_0x1008_c2ab; /* jle 0x1008c2ab */
            ii(0x1008_c297, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1008_c29a, 3); add(eax, 0x1b);                         /* add eax, 0x1b */
            ii(0x1008_c29d, 5); calld(0x1007_6574, -0x1_5d2e);          /* call 0x10076574 */
            ii(0x1008_c2a2, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1008_c2a4, 3); mov(eax, memd_a32[ss, ebp - 0xe]);      /* mov eax, [ebp-0xe] */
            ii(0x1008_c2a7, 4); mov(memw_a32[ds, edx + 0x41], ax);      /* mov [edx+0x41], ax */
        l_0x1008_c2ab:
            ii(0x1008_c2ab, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1008_c2ae, 3); add(eax, 0x13);                         /* add eax, 0x13 */
            ii(0x1008_c2b1, 5); calld(0x1007_65d0, -0x1_5ce6);          /* call 0x100765d0 */
            ii(0x1008_c2b6, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1008_c2b8, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1008_c2bb, 3); add(eax, 0x1b);                         /* add eax, 0x1b */
            ii(0x1008_c2be, 5); calld(0x1007_6574, -0x1_5d4f);          /* call 0x10076574 */
            ii(0x1008_c2c3, 5); calld(0x1008_a998, -0x1930);            /* call 0x1008a998 */
            ii(0x1008_c2c8, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1008_c2ca, 5); mov(al, memb_a32[ds, 0x101c_37c9]);     /* mov al, [0x101c37c9] */
            ii(0x1008_c2cf, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1008_c2d1, 2); if(jnzd(0x1008_c2e8, 0x15)) goto l_0x1008_c2e8; /* jnz 0x1008c2e8 */
            ii(0x1008_c2d3, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1008_c2d6, 3); mov(eax, memd_a32[ds, eax + 0x7]);      /* mov eax, [eax+0x7] */
            ii(0x1008_c2d9, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1008_c2dc, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1008_c2de, 6); mov(dl, memb_a32[ds, 0x101c_37c8]);     /* mov dl, [0x101c37c8] */
            ii(0x1008_c2e4, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x1008_c2e6, 2); if(jnzd(0x1008_c2f1, 0x9)) goto l_0x1008_c2f1; /* jnz 0x1008c2f1 */
        l_0x1008_c2e8:
            ii(0x1008_c2e8, 7); mov(memd_a32[ss, ebp - 0x20], 0);       /* mov dword [ebp-0x20], 0x0 */
            ii(0x1008_c2ef, 2); jmpd(0x1008_c30a, 0x19); goto l_0x1008_c30a; /* jmp 0x1008c30a */
        l_0x1008_c2f1:
            ii(0x1008_c2f1, 5); mov(ecx, 0x14c);                        /* mov ecx, 0x14c */
            ii(0x1008_c2f6, 5); mov(ebx, StringDefinitions.AiBuildCpp2); /* mov ebx, 0x101a03ec */
            ii(0x1008_c2fb, 5); mov(edx, StringDefinitions.PlaymodeNotEqualTurnBasedTeamturnidEqualTeam); /* mov edx, 0x101a03f9 */
            ii(0x1008_c300, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1008_c302, 5); calld(Definitions.sys_assert, 0xd_9a8b); /* call 0x10165d92 */
            ii(0x1008_c307, 3); mov(memd_a32[ss, ebp - 0x20], eax);     /* mov [ebp-0x20], eax */
        l_0x1008_c30a:
            ii(0x1008_c30a, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x1008_c30c, 5); mov(edx, 0x14);                         /* mov edx, 0x14 */
            ii(0x1008_c311, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1008_c314, 3); add(eax, 0x1b);                         /* add eax, 0x1b */
            ii(0x1008_c317, 5); calld(0x1007_65d0, -0x1_5d4c);          /* call 0x100765d0 */
            ii(0x1008_c31c, 5); calld(0x1016_3053, 0xd_6d32);           /* call 0x10163053 */
        l_0x1008_c321:
            ii(0x1008_c321, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1008_c323, 1); popd(ebp);                              /* pop ebp */
            ii(0x1008_c324, 1); popd(edi);                              /* pop edi */
            ii(0x1008_c325, 1); popd(esi);                              /* pop esi */
            ii(0x1008_c326, 1); popd(edx);                              /* pop edx */
            ii(0x1008_c327, 1); popd(ecx);                              /* pop ecx */
            ii(0x1008_c328, 1); popd(ebx);                              /* pop ebx */
            ii(0x1008_c329, 1); retd(); return;                         /* ret */
        }
    }
}
