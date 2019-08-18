using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1015_3c48-a187af4c")]
        public void Method_1015_3c48()
        {
            ii(0x1015_3c48, 5); pushd(0x2c);                            /* push 0x2c */
            ii(0x1015_3c4d, 5); calld(Definitions.sys_check_available_stack_size, 0x1_2100); /* call 0x10165d52 */
            ii(0x1015_3c52, 1); pushd(ebx);                             /* push ebx */
            ii(0x1015_3c53, 1); pushd(ecx);                             /* push ecx */
            ii(0x1015_3c54, 1); pushd(edx);                             /* push edx */
            ii(0x1015_3c55, 1); pushd(esi);                             /* push esi */
            ii(0x1015_3c56, 1); pushd(edi);                             /* push edi */
            ii(0x1015_3c57, 1); pushd(ebp);                             /* push ebp */
            ii(0x1015_3c58, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1015_3c5a, 6); sub(esp, 0x10);                         /* sub esp, 0x10 */
            ii(0x1015_3c60, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1015_3c63, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_3c66, 5); cmp(memw_a32[ds, eax + 0x8], 0x38);     /* cmp word [eax+0x8], 0x38 */
            ii(0x1015_3c6b, 2); if(jzd(0x1015_3c77, 0xa)) goto l_0x1015_3c77; /* jz 0x10153c77 */
            ii(0x1015_3c6d, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_3c70, 5); cmp(memw_a32[ds, eax + 0x8], 0x4a);     /* cmp word [eax+0x8], 0x4a */
            ii(0x1015_3c75, 2); if(jnzd(0x1015_3c8f, 0x18)) goto l_0x1015_3c8f; /* jnz 0x10153c8f */
        l_0x1015_3c77:
            ii(0x1015_3c77, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_3c7a, 3); add(eax, 0x6c);                         /* add eax, 0x6c */
            ii(0x1015_3c7d, 5); calld(0x1007_6730, -0xd_d552);          /* call 0x10076730 */
            ii(0x1015_3c82, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x1015_3c85, 4); mov(dx, memw_a32[ds, edx + 0x52]);      /* mov dx, [edx+0x52] */
            ii(0x1015_3c89, 4); cmp(dx, memw_a32[ds, eax + 0x19]);      /* cmp dx, [eax+0x19] */
            ii(0x1015_3c8d, 2); if(jld(0x1015_3c94, 0x5)) goto l_0x1015_3c94; /* jl 0x10153c94 */
        l_0x1015_3c8f:
            ii(0x1015_3c8f, 5); jmpd(0x1015_3d90, 0xfc); goto l_0x1015_3d90; /* jmp 0x10153d90 */
        l_0x1015_3c94:
            ii(0x1015_3c94, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_3c97, 5); cmp(memw_a32[ds, eax + 0x8], 0x4a);     /* cmp word [eax+0x8], 0x4a */
            ii(0x1015_3c9c, 2); if(jnzd(0x1015_3ca7, 0x9)) goto l_0x1015_3ca7; /* jnz 0x10153ca7 */
            ii(0x1015_3c9e, 7); mov(memd_a32[ss, ebp - 0x10], 0x2a);    /* mov dword [ebp-0x10], 0x2a */
            ii(0x1015_3ca5, 2); jmpd(0x1015_3cae, 0x7); goto l_0x1015_3cae; /* jmp 0x10153cae */
        l_0x1015_3ca7:
            ii(0x1015_3ca7, 7); mov(memd_a32[ss, ebp - 0x10], 0x29);    /* mov dword [ebp-0x10], 0x29 */
        l_0x1015_3cae:
            ii(0x1015_3cae, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1015_3cb1, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1015_3cb4, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_3cb7, 3); mov(ebx, memd_a32[ds, eax + 0x1a]);     /* mov ebx, [eax+0x1a] */
            ii(0x1015_3cba, 3); sar(ebx, 0x10);                         /* sar ebx, 0x10 */
            ii(0x1015_3cbd, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_3cc0, 3); mov(edx, memd_a32[ds, eax + 0x18]);     /* mov edx, [eax+0x18] */
            ii(0x1015_3cc3, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1015_3cc6, 5); mov(eax, 0x101c_39b8);                  /* mov eax, 0x101c39b8 */
            ii(0x1015_3ccb, 5); calld(0x1010_3541, -0x5_078f);          /* call 0x10103541 */
            ii(0x1015_3cd0, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1015_3cd2, 3); lea(eax, ebp - 0xc);                    /* lea eax, [ebp-0xc] */
            ii(0x1015_3cd5, 5); calld(0x1007_64b8, -0xd_d822);          /* call 0x100764b8 */
        l_0x1015_3cda:
            ii(0x1015_3cda, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1015_3cdc, 3); lea(eax, ebp - 0xc);                    /* lea eax, [ebp-0xc] */
            ii(0x1015_3cdf, 5); calld(0x1013_ad71, -0x1_8f73);          /* call 0x1013ad71 */
            ii(0x1015_3ce4, 2); test(al, al);                           /* test al, al */
            ii(0x1015_3ce6, 2); if(jzd(0x1015_3cfa, 0x12)) goto l_0x1015_3cfa; /* jz 0x10153cfa */
            ii(0x1015_3ce8, 3); lea(eax, ebp - 0xc);                    /* lea eax, [ebp-0xc] */
            ii(0x1015_3ceb, 5); calld(0x1007_63a0, -0xd_d950);          /* call 0x100763a0 */
            ii(0x1015_3cf0, 4); mov(ax, memw_a32[ds, eax + 0x8]);       /* mov ax, [eax+0x8] */
            ii(0x1015_3cf4, 4); cmp(ax, memw_a32[ss, ebp - 0x8]);       /* cmp ax, [ebp-0x8] */
            ii(0x1015_3cf8, 2); if(jnzd(0x1015_3cfc, 0x2)) goto l_0x1015_3cfc; /* jnz 0x10153cfc */
        l_0x1015_3cfa:
            ii(0x1015_3cfa, 2); jmpd(0x1015_3d06, 0xa); goto l_0x1015_3d06; /* jmp 0x10153d06 */
        l_0x1015_3cfc:
            ii(0x1015_3cfc, 3); lea(eax, ebp - 0xc);                    /* lea eax, [ebp-0xc] */
            ii(0x1015_3cff, 5); calld(0x1007_6bf8, -0xd_d10c);          /* call 0x10076bf8 */
            ii(0x1015_3d04, 2); jmpd(0x1015_3cda, -0x2c); goto l_0x1015_3cda; /* jmp 0x10153cda */
        l_0x1015_3d06:
            ii(0x1015_3d06, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1015_3d08, 3); lea(eax, ebp - 0xc);                    /* lea eax, [ebp-0xc] */
            ii(0x1015_3d0b, 5); calld(0x1013_ad11, -0x1_8fff);          /* call 0x1013ad11 */
            ii(0x1015_3d10, 2); test(al, al);                           /* test al, al */
            ii(0x1015_3d12, 2); if(jzd(0x1015_3d20, 0xc)) goto l_0x1015_3d20; /* jz 0x10153d20 */
            ii(0x1015_3d14, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1015_3d16, 3); lea(eax, ebp - 0xc);                    /* lea eax, [ebp-0xc] */
            ii(0x1015_3d19, 5); calld(0x1007_5f6c, -0xd_ddb2);          /* call 0x10075f6c */
            ii(0x1015_3d1e, 2); jmpd(0x1015_3d90, 0x70); goto l_0x1015_3d90; /* jmp 0x10153d90 */
        l_0x1015_3d20:
            ii(0x1015_3d20, 3); lea(eax, ebp - 0xc);                    /* lea eax, [ebp-0xc] */
            ii(0x1015_3d23, 5); calld(0x1007_63d4, -0xd_d954);          /* call 0x100763d4 */
            ii(0x1015_3d28, 5); calld(0x1015_f2cc, 0xb59f);             /* call 0x1015f2cc */
            ii(0x1015_3d2d, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_3d30, 4); inc(memw_a32[ds, eax + 0x52]);          /* inc word [eax+0x52] */
            ii(0x1015_3d34, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_3d37, 3); add(eax, 0x6c);                         /* add eax, 0x6c */
            ii(0x1015_3d3a, 5); calld(0x1007_6730, -0xd_d60f);          /* call 0x10076730 */
            ii(0x1015_3d3f, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x1015_3d42, 4); mov(dx, memw_a32[ds, edx + 0x52]);      /* mov dx, [edx+0x52] */
            ii(0x1015_3d46, 4); cmp(dx, memw_a32[ds, eax + 0x19]);      /* cmp dx, [eax+0x19] */
            ii(0x1015_3d4a, 2); if(jnzd(0x1015_3d56, 0xa)) goto l_0x1015_3d56; /* jnz 0x10153d56 */
            ii(0x1015_3d4c, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_3d4f, 7); mov(memb_a32[ds, eax + 0xa6], 0);       /* mov byte [eax+0xa6], 0x0 */
        l_0x1015_3d56:
            ii(0x1015_3d56, 5); mov(edx, 0x101c_37bc);                  /* mov edx, 0x101c37bc */
            ii(0x1015_3d5b, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_3d5e, 5); calld(0x1007_6d98, -0xd_cfcb);          /* call 0x10076d98 */
            ii(0x1015_3d63, 2); test(al, al);                           /* test al, al */
            ii(0x1015_3d65, 2); if(jzd(0x1015_3d86, 0x1f)) goto l_0x1015_3d86; /* jz 0x10153d86 */
            ii(0x1015_3d67, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_3d6a, 5); calld(0x1010_094d, -0x5_3422);          /* call 0x1010094d */
            ii(0x1015_3d6f, 5); mov(ecx, 0x1);                          /* mov ecx, 0x1 */
            ii(0x1015_3d74, 5); mov(ebx, 0x10);                         /* mov ebx, 0x10 */
            ii(0x1015_3d79, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x1015_3d7c, 5); mov(eax, 0x101c_7278);                  /* mov eax, 0x101c7278 */
            ii(0x1015_3d81, 5); calld(0x1013_d5c0, -0x1_67c6);          /* call 0x1013d5c0 */
        l_0x1015_3d86:
            ii(0x1015_3d86, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1015_3d88, 3); lea(eax, ebp - 0xc);                    /* lea eax, [ebp-0xc] */
            ii(0x1015_3d8b, 5); calld(0x1007_5f6c, -0xd_de24);          /* call 0x10075f6c */
        l_0x1015_3d90:
            ii(0x1015_3d90, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1015_3d92, 1); popd(ebp);                              /* pop ebp */
            ii(0x1015_3d93, 1); popd(edi);                              /* pop edi */
            ii(0x1015_3d94, 1); popd(esi);                              /* pop esi */
            ii(0x1015_3d95, 1); popd(edx);                              /* pop edx */
            ii(0x1015_3d96, 1); popd(ecx);                              /* pop ecx */
            ii(0x1015_3d97, 1); popd(ebx);                              /* pop ebx */
            ii(0x1015_3d98, 1); retd(); return;                         /* ret */
        }
    }
}
