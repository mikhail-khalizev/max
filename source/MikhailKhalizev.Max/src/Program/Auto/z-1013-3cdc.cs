using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("14405c6e-2600-48e3-96f3-82b145690cb5")]
        public void Method_1013_3cdc()
        {
            ii(0x1013_3cdc, 5); pushd(0xb0);                            /* push 0xb0 */
            ii(0x1013_3ce1, 5); calld(Definitions.sys_check_available_stack_size, 0x3206c); /* call 0x10165d52 */
            ii(0x1013_3ce6, 1); pushd(ebx);                             /* push ebx */
            ii(0x1013_3ce7, 1); pushd(ecx);                             /* push ecx */
            ii(0x1013_3ce8, 1); pushd(edx);                             /* push edx */
            ii(0x1013_3ce9, 1); pushd(esi);                             /* push esi */
            ii(0x1013_3cea, 1); pushd(edi);                             /* push edi */
            ii(0x1013_3ceb, 1); pushd(ebp);                             /* push ebp */
            ii(0x1013_3cec, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1013_3cee, 6); sub(esp, 0x94);                         /* sub esp, 0x94 */
            ii(0x1013_3cf4, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1013_3cf7, 5); mov(eax, 0x761);                        /* mov eax, 0x761 */
            ii(0x1013_3cfc, 5); calld(Definitions.my_get_res_data_by_id_malloc, 0x4ea); /* call 0x101341eb */
            ii(0x1013_3d01, 3); mov(memd_a32[ss, ebp - 0x14], eax);     /* mov [ebp-0x14], eax */
            ii(0x1013_3d04, 4); cmp(memd_a32[ss, ebp - 0x14], 0);       /* cmp dword [ebp-0x14], 0x0 */
            ii(0x1013_3d08, 6); if(jzd(0x1013_3fcf, 0x2c1)) goto l_0x1013_3fcf; /* jz 0x10133fcf */
            ii(0x1013_3d0e, 5); mov(eax, 0x761);                        /* mov eax, 0x761 */
            ii(0x1013_3d13, 5); calld(0x1013_433e, 0x626);              /* call 0x1013433e */
            ii(0x1013_3d18, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x1013_3d1b, 3); mov(eax, memd_a32[ss, ebp - 0x14]);     /* mov eax, [ebp-0x14] */
            ii(0x1013_3d1e, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1013_3d21, 7); mov(memd_a32[ss, ebp - 0x8], 0);        /* mov dword [ebp-0x8], 0x0 */
        l_0x1013_3d28:
            ii(0x1013_3d28, 4); cmp(memd_a32[ss, ebp - 0x8], 0x5d);     /* cmp dword [ebp-0x8], 0x5d */
            ii(0x1013_3d2c, 6); if(jged(0x1013_3fc7, 0x295)) goto l_0x1013_3fc7; /* jge 0x10133fc7 */
            ii(0x1013_3d32, 7); mov(memd_a32[ss, ebp - 0x18], 0);       /* mov dword [ebp-0x18], 0x0 */
        l_0x1013_3d39:
            ii(0x1013_3d39, 3); mov(edx, memd_a32[ss, ebp - 0xc]);      /* mov edx, [ebp-0xc] */
            ii(0x1013_3d3c, 3); inc(memd_a32[ss, ebp - 0xc]);           /* inc dword [ebp-0xc] */
            ii(0x1013_3d3f, 4); movsx(eax, memw_a32[ss, ebp - 0x18]);   /* movsx eax, word [ebp-0x18] */
            ii(0x1013_3d43, 2); mov(dl, memb_a32[ds, edx]);             /* mov dl, [edx] */
            ii(0x1013_3d45, 4); mov(memb_a32[ds, eax + ebp - 0x7c], dl); /* mov [eax+ebp-0x7c], dl */
            ii(0x1013_3d49, 4); movsx(eax, memw_a32[ss, ebp - 0x18]);   /* movsx eax, word [ebp-0x18] */
            ii(0x1013_3d4d, 4); mov(al, memb_a32[ds, eax + ebp - 0x7c]); /* mov al, [eax+ebp-0x7c] */
            ii(0x1013_3d51, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1013_3d56, 3); cmp(eax, 0xd);                          /* cmp eax, 0xd */
            ii(0x1013_3d59, 2); if(jnzd(0x1013_3d61, 0x6)) goto l_0x1013_3d61; /* jnz 0x10133d61 */
            ii(0x1013_3d5b, 3); mov(eax, memd_a32[ss, ebp - 0x18]);     /* mov eax, [ebp-0x18] */
            ii(0x1013_3d5e, 3); dec(memd_a32[ss, ebp - 0x18]);          /* dec dword [ebp-0x18] */
        l_0x1013_3d61:
            ii(0x1013_3d61, 4); add(memd_a32[ss, ebp - 0x10], -0x1 /* 0xff */); /* add dword [ebp-0x10], 0xffffffff */
            ii(0x1013_3d65, 4); cmp(memd_a32[ss, ebp - 0x10], 0);       /* cmp dword [ebp-0x10], 0x0 */
            ii(0x1013_3d69, 2); if(jzd(0x1013_3d80, 0x15)) goto l_0x1013_3d80; /* jz 0x10133d80 */
            ii(0x1013_3d6b, 3); mov(eax, memd_a32[ss, ebp - 0x18]);     /* mov eax, [ebp-0x18] */
            ii(0x1013_3d6e, 3); inc(memd_a32[ss, ebp - 0x18]);          /* inc dword [ebp-0x18] */
            ii(0x1013_3d71, 1); cwde();                                 /* cwde */
            ii(0x1013_3d72, 4); mov(al, memb_a32[ds, eax + ebp - 0x7c]); /* mov al, [eax+ebp-0x7c] */
            ii(0x1013_3d76, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1013_3d7b, 3); cmp(eax, 0xa);                          /* cmp eax, 0xa */
            ii(0x1013_3d7e, 2); if(jnzd(0x1013_3d82, 0x2)) goto l_0x1013_3d82; /* jnz 0x10133d82 */
        l_0x1013_3d80:
            ii(0x1013_3d80, 2); jmpd(0x1013_3d84, 0x2); goto l_0x1013_3d84; /* jmp 0x10133d84 */
        l_0x1013_3d82:
            ii(0x1013_3d82, 2); jmpd(0x1013_3d39, -0x4b); goto l_0x1013_3d39; /* jmp 0x10133d39 */
        l_0x1013_3d84:
            ii(0x1013_3d84, 4); movsx(eax, memw_a32[ss, ebp - 0x18]);   /* movsx eax, word [ebp-0x18] */
            ii(0x1013_3d88, 5); mov(memb_a32[ds, eax + ebp - 0x7c], 0); /* mov byte [eax+ebp-0x7c], 0x0 */
            ii(0x1013_3d8d, 4); cmp(memb_a32[ss, ebp - 0x7c], 0x3b);    /* cmp byte [ebp-0x7c], 0x3b */
            ii(0x1013_3d91, 2); if(jzd(0x1013_3d9d, 0xa)) goto l_0x1013_3d9d; /* jz 0x10133d9d */
            ii(0x1013_3d93, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1013_3d95, 3); mov(al, memb_a32[ss, ebp - 0x7c]);      /* mov al, [ebp-0x7c] */
            ii(0x1013_3d98, 3); cmp(eax, 0xa);                          /* cmp eax, 0xa */
            ii(0x1013_3d9b, 2); if(jnzd(0x1013_3da2, 0x5)) goto l_0x1013_3da2; /* jnz 0x10133da2 */
        l_0x1013_3d9d:
            ii(0x1013_3d9d, 5); jmpd(0x1013_3fc2, 0x220); goto l_0x1013_3fc2; /* jmp 0x10133fc2 */
        l_0x1013_3da2:
            ii(0x1013_3da2, 5); mov(eax, 0x24);                         /* mov eax, 0x24 */
            ii(0x1013_3da7, 5); calld(Definitions.sys_new, 0x32054);    /* call 0x10165e00 */
            ii(0x1013_3dac, 3); mov(memd_a32[ss, ebp - 0x80], eax);     /* mov [ebp-0x80], eax */
            ii(0x1013_3daf, 3); mov(eax, memd_a32[ss, ebp - 0x80]);     /* mov eax, [ebp-0x80] */
            ii(0x1013_3db2, 6); mov(memd_a32[ss, ebp - 0x84], eax);     /* mov [ebp-0x84], eax */
            ii(0x1013_3db8, 7); cmp(memd_a32[ss, ebp - 0x84], 0);       /* cmp dword [ebp-0x84], 0x0 */
            ii(0x1013_3dbf, 2); if(jzd(0x1013_3ddd, 0x1c)) goto l_0x1013_3ddd; /* jz 0x10133ddd */
            ii(0x1013_3dc1, 3); mov(eax, memd_a32[ss, ebp - 0x80]);     /* mov eax, [ebp-0x80] */
            ii(0x1013_3dc4, 5); calld(0x1016_3505, 0x2f73c);            /* call 0x10163505 */
            ii(0x1013_3dc9, 6); mov(memd_a32[ss, ebp - 0x88], eax);     /* mov [ebp-0x88], eax */
            ii(0x1013_3dcf, 6); mov(eax, memd_a32[ss, ebp - 0x88]);     /* mov eax, [ebp-0x88] */
            ii(0x1013_3dd5, 6); mov(memd_a32[ss, ebp - 0x8c], eax);     /* mov [ebp-0x8c], eax */
            ii(0x1013_3ddb, 2); jmpd(0x1013_3de9, 0xc); goto l_0x1013_3de9; /* jmp 0x10133de9 */
        l_0x1013_3ddd:
            ii(0x1013_3ddd, 6); mov(eax, memd_a32[ss, ebp - 0x84]);     /* mov eax, [ebp-0x84] */
            ii(0x1013_3de3, 6); mov(memd_a32[ss, ebp - 0x8c], eax);     /* mov [ebp-0x8c], eax */
        l_0x1013_3de9:
            ii(0x1013_3de9, 6); mov(edx, memd_a32[ss, ebp - 0x8c]);     /* mov edx, [ebp-0x8c] */
            ii(0x1013_3def, 6); lea(eax, ebp - 0x90);                   /* lea eax, [ebp-0x90] */
            ii(0x1013_3df5, 5); calld(0x1007_6800, -0xbd5fa);           /* call 0x10076800 */
            ii(0x1013_3dfa, 10); mov(memd_a32[ss, ebp - 0x94], 0);      /* mov dword [ebp-0x94], 0x0 */
            ii(0x1013_3e04, 6); lea(edx, ebp - 0x94);                   /* lea edx, [ebp-0x94] */
            ii(0x1013_3e0a, 3); lea(eax, ebp - 0x7c);                   /* lea eax, [ebp-0x7c] */
            ii(0x1013_3e0d, 5); calld(0x1013_3c5b, -0x1b7);             /* call 0x10133c5b */
            ii(0x1013_3e12, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1013_3e14, 6); lea(eax, ebp - 0x90);                   /* lea eax, [ebp-0x90] */
            ii(0x1013_3e1a, 5); calld(0x1007_6730, -0xbd6ef);           /* call 0x10076730 */
            ii(0x1013_3e1f, 4); mov(memw_a32[ds, eax + 0x8], dx);       /* mov [eax+0x8], dx */
            ii(0x1013_3e23, 6); lea(edx, ebp - 0x94);                   /* lea edx, [ebp-0x94] */
            ii(0x1013_3e29, 3); lea(eax, ebp - 0x7c);                   /* lea eax, [ebp-0x7c] */
            ii(0x1013_3e2c, 5); calld(0x1013_3c5b, -0x1d6);             /* call 0x10133c5b */
            ii(0x1013_3e31, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1013_3e33, 6); lea(eax, ebp - 0x90);                   /* lea eax, [ebp-0x90] */
            ii(0x1013_3e39, 5); calld(0x1007_6730, -0xbd70e);           /* call 0x10076730 */
            ii(0x1013_3e3e, 4); mov(memw_a32[ds, eax + 0xa], dx);       /* mov [eax+0xa], dx */
            ii(0x1013_3e42, 6); lea(edx, ebp - 0x94);                   /* lea edx, [ebp-0x94] */
            ii(0x1013_3e48, 3); lea(eax, ebp - 0x7c);                   /* lea eax, [ebp-0x7c] */
            ii(0x1013_3e4b, 5); calld(0x1013_3c5b, -0x1f5);             /* call 0x10133c5b */
            ii(0x1013_3e50, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1013_3e52, 6); lea(eax, ebp - 0x90);                   /* lea eax, [ebp-0x90] */
            ii(0x1013_3e58, 5); calld(0x1007_6730, -0xbd72d);           /* call 0x10076730 */
            ii(0x1013_3e5d, 4); mov(memw_a32[ds, eax + 0xc], dx);       /* mov [eax+0xc], dx */
            ii(0x1013_3e61, 6); lea(edx, ebp - 0x94);                   /* lea edx, [ebp-0x94] */
            ii(0x1013_3e67, 3); lea(eax, ebp - 0x7c);                   /* lea eax, [ebp-0x7c] */
            ii(0x1013_3e6a, 5); calld(0x1013_3c5b, -0x214);             /* call 0x10133c5b */
            ii(0x1013_3e6f, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1013_3e71, 6); lea(eax, ebp - 0x90);                   /* lea eax, [ebp-0x90] */
            ii(0x1013_3e77, 5); calld(0x1007_6730, -0xbd74c);           /* call 0x10076730 */
            ii(0x1013_3e7c, 4); mov(memw_a32[ds, eax + 0xe], dx);       /* mov [eax+0xe], dx */
            ii(0x1013_3e80, 6); lea(edx, ebp - 0x94);                   /* lea edx, [ebp-0x94] */
            ii(0x1013_3e86, 3); lea(eax, ebp - 0x7c);                   /* lea eax, [ebp-0x7c] */
            ii(0x1013_3e89, 5); calld(0x1013_3c5b, -0x233);             /* call 0x10133c5b */
            ii(0x1013_3e8e, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1013_3e90, 6); lea(eax, ebp - 0x90);                   /* lea eax, [ebp-0x90] */
            ii(0x1013_3e96, 5); calld(0x1007_6730, -0xbd76b);           /* call 0x10076730 */
            ii(0x1013_3e9b, 3); mov(memb_a32[ds, eax + 0x16], dl);      /* mov [eax+0x16], dl */
            ii(0x1013_3e9e, 6); lea(edx, ebp - 0x94);                   /* lea edx, [ebp-0x94] */
            ii(0x1013_3ea4, 3); lea(eax, ebp - 0x7c);                   /* lea eax, [ebp-0x7c] */
            ii(0x1013_3ea7, 5); calld(0x1013_3c5b, -0x251);             /* call 0x10133c5b */
            ii(0x1013_3eac, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1013_3eae, 6); lea(eax, ebp - 0x90);                   /* lea eax, [ebp-0x90] */
            ii(0x1013_3eb4, 5); calld(0x1007_6730, -0xbd789);           /* call 0x10076730 */
            ii(0x1013_3eb9, 4); mov(memw_a32[ds, eax + 0x10], dx);      /* mov [eax+0x10], dx */
            ii(0x1013_3ebd, 6); lea(edx, ebp - 0x94);                   /* lea edx, [ebp-0x94] */
            ii(0x1013_3ec3, 3); lea(eax, ebp - 0x7c);                   /* lea eax, [ebp-0x7c] */
            ii(0x1013_3ec6, 5); calld(0x1013_3c5b, -0x270);             /* call 0x10133c5b */
            ii(0x1013_3ecb, 6); lea(edx, ebp - 0x94);                   /* lea edx, [ebp-0x94] */
            ii(0x1013_3ed1, 3); lea(eax, ebp - 0x7c);                   /* lea eax, [ebp-0x7c] */
            ii(0x1013_3ed4, 5); calld(0x1013_3c5b, -0x27e);             /* call 0x10133c5b */
            ii(0x1013_3ed9, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1013_3edb, 6); lea(eax, ebp - 0x90);                   /* lea eax, [ebp-0x90] */
            ii(0x1013_3ee1, 5); calld(0x1007_6730, -0xbd7b6);           /* call 0x10076730 */
            ii(0x1013_3ee6, 4); mov(memw_a32[ds, eax + 0x12], dx);      /* mov [eax+0x12], dx */
            ii(0x1013_3eea, 6); lea(edx, ebp - 0x94);                   /* lea edx, [ebp-0x94] */
            ii(0x1013_3ef0, 3); lea(eax, ebp - 0x7c);                   /* lea eax, [ebp-0x7c] */
            ii(0x1013_3ef3, 5); calld(0x1013_3c5b, -0x29d);             /* call 0x10133c5b */
            ii(0x1013_3ef8, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1013_3efa, 6); lea(eax, ebp - 0x90);                   /* lea eax, [ebp-0x90] */
            ii(0x1013_3f00, 5); calld(0x1007_6730, -0xbd7d5);           /* call 0x10076730 */
            ii(0x1013_3f05, 4); mov(memw_a32[ds, eax + 0x14], dx);      /* mov [eax+0x14], dx */
            ii(0x1013_3f09, 6); lea(edx, ebp - 0x94);                   /* lea edx, [ebp-0x94] */
            ii(0x1013_3f0f, 3); lea(eax, ebp - 0x7c);                   /* lea eax, [ebp-0x7c] */
            ii(0x1013_3f12, 5); calld(0x1013_3c5b, -0x2bc);             /* call 0x10133c5b */
            ii(0x1013_3f17, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1013_3f19, 6); lea(eax, ebp - 0x90);                   /* lea eax, [ebp-0x90] */
            ii(0x1013_3f1f, 5); calld(0x1007_6730, -0xbd7f4);           /* call 0x10076730 */
            ii(0x1013_3f24, 4); mov(memw_a32[ds, eax + 0x17], dx);      /* mov [eax+0x17], dx */
            ii(0x1013_3f28, 6); lea(edx, ebp - 0x94);                   /* lea edx, [ebp-0x94] */
            ii(0x1013_3f2e, 3); lea(eax, ebp - 0x7c);                   /* lea eax, [ebp-0x7c] */
            ii(0x1013_3f31, 5); calld(0x1013_3c5b, -0x2db);             /* call 0x10133c5b */
            ii(0x1013_3f36, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1013_3f38, 6); lea(eax, ebp - 0x90);                   /* lea eax, [ebp-0x90] */
            ii(0x1013_3f3e, 5); calld(0x1007_6730, -0xbd813);           /* call 0x10076730 */
            ii(0x1013_3f43, 4); mov(memw_a32[ds, eax + 0x19], dx);      /* mov [eax+0x19], dx */
            ii(0x1013_3f47, 6); lea(edx, ebp - 0x94);                   /* lea edx, [ebp-0x94] */
            ii(0x1013_3f4d, 3); lea(eax, ebp - 0x7c);                   /* lea eax, [ebp-0x7c] */
            ii(0x1013_3f50, 5); calld(0x1013_3c5b, -0x2fa);             /* call 0x10133c5b */
            ii(0x1013_3f55, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1013_3f57, 6); lea(eax, ebp - 0x90);                   /* lea eax, [ebp-0x90] */
            ii(0x1013_3f5d, 5); calld(0x1007_6730, -0xbd832);           /* call 0x10076730 */
            ii(0x1013_3f62, 4); mov(memw_a32[ds, eax + 0x1b], dx);      /* mov [eax+0x1b], dx */
            ii(0x1013_3f66, 6); lea(edx, ebp - 0x94);                   /* lea edx, [ebp-0x94] */
            ii(0x1013_3f6c, 3); lea(eax, ebp - 0x7c);                   /* lea eax, [ebp-0x7c] */
            ii(0x1013_3f6f, 5); calld(0x1013_3c5b, -0x319);             /* call 0x10133c5b */
            ii(0x1013_3f74, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1013_3f76, 6); lea(eax, ebp - 0x90);                   /* lea eax, [ebp-0x90] */
            ii(0x1013_3f7c, 5); calld(0x1007_6730, -0xbd851);           /* call 0x10076730 */
            ii(0x1013_3f81, 4); mov(memw_a32[ds, eax + 0x1d], dx);      /* mov [eax+0x1d], dx */
            ii(0x1013_3f85, 6); lea(eax, ebp - 0x90);                   /* lea eax, [ebp-0x90] */
            ii(0x1013_3f8b, 5); calld(0x1007_6730, -0xbd860);           /* call 0x10076730 */
            ii(0x1013_3f90, 6); mov(memw_a32[ds, eax + 0x1f], 0);       /* mov word [eax+0x1f], 0x0 */
            ii(0x1013_3f96, 6); lea(eax, ebp - 0x90);                   /* lea eax, [ebp-0x90] */
            ii(0x1013_3f9c, 5); calld(0x1007_678c, -0xbd815);           /* call 0x1007678c */
            ii(0x1013_3fa1, 2); mov(ebx, eax);                          /* mov ebx, eax */
            ii(0x1013_3fa3, 4); movsx(edx, memw_a32[ss, ebp - 0x8]);    /* movsx edx, word [ebp-0x8] */
            ii(0x1013_3fa7, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1013_3faa, 5); calld(0x1013_6564, 0x25b5);             /* call 0x10136564 */
            ii(0x1013_3faf, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1013_3fb2, 3); inc(memd_a32[ss, ebp - 0x8]);           /* inc dword [ebp-0x8] */
            ii(0x1013_3fb5, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1013_3fb7, 6); lea(eax, ebp - 0x90);                   /* lea eax, [ebp-0x90] */
            ii(0x1013_3fbd, 5); calld(0x1007_5eec, -0xbe0d6);           /* call 0x10075eec */
        l_0x1013_3fc2:
            ii(0x1013_3fc2, 5); jmpd(0x1013_3d28, -0x29f); goto l_0x1013_3d28; /* jmp 0x10133d28 */
        l_0x1013_3fc7:
            ii(0x1013_3fc7, 3); mov(eax, memd_a32[ss, ebp - 0x14]);     /* mov eax, [ebp-0x14] */
            ii(0x1013_3fca, 5); calld(Definitions.sys_delete, 0x31f95); /* call 0x10165f64 */
        l_0x1013_3fcf:
            ii(0x1013_3fcf, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1013_3fd1, 1); popd(ebp);                              /* pop ebp */
            ii(0x1013_3fd2, 1); popd(edi);                              /* pop edi */
            ii(0x1013_3fd3, 1); popd(esi);                              /* pop esi */
            ii(0x1013_3fd4, 1); popd(edx);                              /* pop edx */
            ii(0x1013_3fd5, 1); popd(ecx);                              /* pop ecx */
            ii(0x1013_3fd6, 1); popd(ebx);                              /* pop ebx */
            ii(0x1013_3fd7, 1); retd(); return;                         /* ret */
        }
    }
}
