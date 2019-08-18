using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1012_2e0a-65a91600")]
        public void Method_1012_2e0a()
        {
            ii(0x1012_2e0a, 7); cmp(memd_a32[ss, ebp - 0x4], 0x7000);   /* cmp dword [ebp-0x4], 0x7000 */
            ii(0x1012_2e11, 6); if(jld(0x1012_2e93, 0x7c)) goto l_0x1012_2e93; /* jl 0x10122e93 */
            ii(0x1012_2e17, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1012_2e1a, 4); cmp(memb_a32[ds, eax + 0x4b], 0);       /* cmp byte [eax+0x4b], 0x0 */
            ii(0x1012_2e1e, 6); if(jnzd(0x1012_2e8e, 0x6a)) goto l_0x1012_2e8e; /* jnz 0x10122e8e */
            ii(0x1012_2e24, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1012_2e27, 4); mov(memb_a32[ds, eax + 0x4b], 0x1);     /* mov byte [eax+0x4b], 0x1 */
            ii(0x1012_2e2b, 7); add(memd_a32[ss, ebp - 0x4], 0xffff_9000); /* add dword [ebp-0x4], 0xffff9000 */
            ii(0x1012_2e32, 7); cmp(memd_a32[ss, ebp - 0x4], 0x3e8);    /* cmp dword [ebp-0x4], 0x3e8 */
            ii(0x1012_2e39, 2); if(jnzd(0x1012_2e48, 0xd)) goto l_0x1012_2e48; /* jnz 0x10122e48 */
            ii(0x1012_2e3b, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1012_2e3e, 3); mov(eax, memd_a32[ds, eax + 0x36]);     /* mov eax, [eax+0x36] */
            ii(0x1012_2e41, 5); calld(0x100c_fbbe, -0x5_3288);          /* call 0x100cfbbe */
            ii(0x1012_2e46, 2); jmpd(0x1012_2e8e, 0x46); goto l_0x1012_2e8e; /* jmp 0x10122e8e */
        l_0x1012_2e48:
            ii(0x1012_2e48, 4); cmp(memd_a32[ss, ebp - 0x4], 0x3f);     /* cmp dword [ebp-0x4], 0x3f */
            ii(0x1012_2e4c, 2); if(jnzd(0x1012_2e5b, 0xd)) goto l_0x1012_2e5b; /* jnz 0x10122e5b */
            ii(0x1012_2e4e, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1012_2e51, 3); mov(eax, memd_a32[ds, eax + 0x3a]);     /* mov eax, [eax+0x3a] */
            ii(0x1012_2e54, 5); calld(0x100c_fbbe, -0x5_329b);          /* call 0x100cfbbe */
            ii(0x1012_2e59, 2); jmpd(0x1012_2e8e, 0x33); goto l_0x1012_2e8e; /* jmp 0x10122e8e */
        l_0x1012_2e5b:
            ii(0x1012_2e5b, 7); cmp(memd_a32[ss, ebp - 0x4], 0x3e9);    /* cmp dword [ebp-0x4], 0x3e9 */
            ii(0x1012_2e62, 2); if(jnzd(0x1012_2e71, 0xd)) goto l_0x1012_2e71; /* jnz 0x10122e71 */
            ii(0x1012_2e64, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1012_2e67, 3); mov(eax, memd_a32[ds, eax + 0x32]);     /* mov eax, [eax+0x32] */
            ii(0x1012_2e6a, 5); calld(0x100c_fbbe, -0x5_32b1);          /* call 0x100cfbbe */
            ii(0x1012_2e6f, 2); jmpd(0x1012_2e8e, 0x1d); goto l_0x1012_2e8e; /* jmp 0x10122e8e */
        l_0x1012_2e71:
            ii(0x1012_2e71, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1012_2e74, 5); sub(eax, 0x3ea);                        /* sub eax, 0x3ea */
            ii(0x1012_2e79, 3); imul(eax, eax, 0x1c);                   /* imul eax, eax, 0x1c */
            ii(0x1012_2e7c, 6); mov(eax, memd_a32[ds, eax + 0x101b_b068]); /* mov eax, [eax+0x101bb068] */
            ii(0x1012_2e82, 5); calld(0x100c_fbbe, -0x5_32c9);          /* call 0x100cfbbe */
            ii(0x1012_2e87, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1012_2e8a, 4); mov(memb_a32[ds, eax + 0x4b], 0);       /* mov byte [eax+0x4b], 0x0 */
        l_0x1012_2e8e:
            ii(0x1012_2e8e, 5); jmpd(0x1012_315e, 0x2cb); goto l_0x1012_315e; /* jmp 0x1012315e */
        l_0x1012_2e93:
            ii(0x1012_2e93, 7); cmp(memd_a32[ss, ebp - 0x4], 0x3ea);    /* cmp dword [ebp-0x4], 0x3ea */
            ii(0x1012_2e9a, 6); if(jld(0x1012_3147, 0x2a7)) goto l_0x1012_3147; /* jl 0x10123147 */
            ii(0x1012_2ea0, 7); add(memd_a32[ss, ebp - 0x4], 0xffff_fc16); /* add dword [ebp-0x4], 0xfffffc16 */
            ii(0x1012_2ea7, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1012_2eaa, 3); mov(eax, memd_a32[ds, eax + 0x44]);     /* mov eax, [eax+0x44] */
            ii(0x1012_2ead, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1012_2eb0, 3); cmp(eax, memd_a32[ss, ebp - 0x4]);      /* cmp eax, [ebp-0x4] */
            ii(0x1012_2eb3, 6); if(jzd_func(0x1012_31ce, 0x315)) return; /* jz 0x101231ce */
            ii(0x1012_2eb9, 5); mov(edx, 0xd);                          /* mov edx, 0xd */
            ii(0x1012_2ebe, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1012_2ec1, 5); calld(0x1012_2716, -0x7b0);             /* call 0x10122716 */
            ii(0x1012_2ec6, 4); imul(eax, memd_a32[ss, ebp - 0x4], 0x1c); /* imul eax, [ebp-0x4], 0x1c */
            ii(0x1012_2eca, 7); cmp(memb_a32[ds, eax + 0x101b_b05c], 0x5); /* cmp byte [eax+0x101bb05c], 0x5 */
            ii(0x1012_2ed1, 6); if(jnzd(0x1012_2f91, 0xba)) goto l_0x1012_2f91; /* jnz 0x10122f91 */
            ii(0x1012_2ed7, 4); imul(eax, memd_a32[ss, ebp - 0x4], 0x1c); /* imul eax, [ebp-0x4], 0x1c */
            ii(0x1012_2edb, 6); mov(eax, memd_a32[ds, eax + 0x101b_b068]); /* mov eax, [eax+0x101bb068] */
            ii(0x1012_2ee1, 5); calld(0x100c_fbbe, -0x5_3328);          /* call 0x100cfbbe */
            ii(0x1012_2ee6, 4); imul(eax, memd_a32[ss, ebp - 0x4], 0x1c); /* imul eax, [ebp-0x4], 0x1c */
            ii(0x1012_2eea, 6); mov(eax, memd_a32[ds, eax + 0x101b_b068]); /* mov eax, [eax+0x101bb068] */
            ii(0x1012_2ef0, 5); calld(0x100d_5104, -0x4_ddf1);          /* call 0x100d5104 */
            ii(0x1012_2ef5, 5); calld(/* sys */ 0x1016_8de8, 0x4_5eee); /* call 0x10168de8 */
            ii(0x1012_2efa, 3); mov(memd_a32[ss, ebp - 0x58], eax);     /* mov [ebp-0x58], eax */
            ii(0x1012_2efd, 4); imul(edx, memd_a32[ss, ebp - 0x4], 0x1c); /* imul edx, [ebp-0x4], 0x1c */
            ii(0x1012_2f01, 3); mov(eax, memd_a32[ss, ebp - 0x58]);     /* mov eax, [ebp-0x58] */
            ii(0x1012_2f04, 7); mov(memw_a32[ds, edx + 0x101b_b074], ax); /* mov [edx+0x101bb074], ax */
            ii(0x1012_2f0b, 4); imul(eax, memd_a32[ss, ebp - 0x4], 0x1c); /* imul eax, [ebp-0x4], 0x1c */
            ii(0x1012_2f0f, 6); mov(al, memb_a32[ds, eax + 0x101b_b061]); /* mov al, [eax+0x101bb061] */
            ii(0x1012_2f15, 3); mov(memb_a32[ss, ebp - 0x54], al);      /* mov [ebp-0x54], al */
            ii(0x1012_2f18, 4); movsx(edx, memw_a32[ss, ebp - 0x58]);   /* movsx edx, word [ebp-0x58] */
            ii(0x1012_2f1c, 4); movsx(eax, memb_a32[ss, ebp - 0x54]);   /* movsx eax, byte [ebp-0x54] */
            ii(0x1012_2f20, 5); calld(0x100c_aafc, -0x5_8429);          /* call 0x100caafc */
            ii(0x1012_2f25, 4); cmp(memb_a32[ss, ebp - 0x54], 0x39);    /* cmp byte [ebp-0x54], 0x39 */
            ii(0x1012_2f29, 2); if(jnzd(0x1012_2f3c, 0x11)) goto l_0x1012_2f3c; /* jnz 0x10122f3c */
            ii(0x1012_2f2b, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1012_2f2d, 3); mov(dl, memb_a32[ss, ebp - 0x58]);      /* mov dl, [ebp-0x58] */
            ii(0x1012_2f30, 5); mov(eax, 0x101c_7278);                  /* mov eax, 0x101c7278 */
            ii(0x1012_2f35, 5); calld(0x1013_d2c4, 0x1_a38a);           /* call 0x1013d2c4 */
            ii(0x1012_2f3a, 2); jmpd(0x1012_2f8c, 0x50); goto l_0x1012_2f8c; /* jmp 0x10122f8c */
        l_0x1012_2f3c:
            ii(0x1012_2f3c, 4); cmp(memb_a32[ss, ebp - 0x54], 0x3a);    /* cmp byte [ebp-0x54], 0x3a */
            ii(0x1012_2f40, 2); if(jnzd(0x1012_2f53, 0x11)) goto l_0x1012_2f53; /* jnz 0x10122f53 */
            ii(0x1012_2f42, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1012_2f44, 3); mov(dl, memb_a32[ss, ebp - 0x58]);      /* mov dl, [ebp-0x58] */
            ii(0x1012_2f47, 5); mov(eax, 0x101c_7278);                  /* mov eax, 0x101c7278 */
            ii(0x1012_2f4c, 5); calld(0x1013_d323, 0x1_a3d2);           /* call 0x1013d323 */
            ii(0x1012_2f51, 2); jmpd(0x1012_2f8c, 0x39); goto l_0x1012_2f8c; /* jmp 0x10122f8c */
        l_0x1012_2f53:
            ii(0x1012_2f53, 4); cmp(memb_a32[ss, ebp - 0x54], 0x3b);    /* cmp byte [ebp-0x54], 0x3b */
            ii(0x1012_2f57, 2); if(jnzd(0x1012_2f6a, 0x11)) goto l_0x1012_2f6a; /* jnz 0x10122f6a */
            ii(0x1012_2f59, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1012_2f5b, 3); mov(dl, memb_a32[ss, ebp - 0x58]);      /* mov dl, [ebp-0x58] */
            ii(0x1012_2f5e, 5); mov(eax, 0x101c_7278);                  /* mov eax, 0x101c7278 */
            ii(0x1012_2f63, 5); calld(0x1013_d409, 0x1_a4a1);           /* call 0x1013d409 */
            ii(0x1012_2f68, 2); jmpd(0x1012_2f8c, 0x22); goto l_0x1012_2f8c; /* jmp 0x10122f8c */
        l_0x1012_2f6a:
            ii(0x1012_2f6a, 4); cmp(memb_a32[ss, ebp - 0x54], 0x40);    /* cmp byte [ebp-0x54], 0x40 */
            ii(0x1012_2f6e, 2); if(jnzd(0x1012_2f77, 0x7)) goto l_0x1012_2f77; /* jnz 0x10122f77 */
            ii(0x1012_2f70, 5); cmp(memw_a32[ss, ebp - 0x58], 0);       /* cmp word [ebp-0x58], 0x0 */
            ii(0x1012_2f75, 2); if(jnzd(0x1012_2f79, 0x2)) goto l_0x1012_2f79; /* jnz 0x10122f79 */
        l_0x1012_2f77:
            ii(0x1012_2f77, 2); jmpd(0x1012_2f85, 0xc); goto l_0x1012_2f85; /* jmp 0x10122f85 */
        l_0x1012_2f79:
            ii(0x1012_2f79, 5); calld(0x1010_6bb0, -0x1_c3ce);          /* call 0x10106bb0 */
            ii(0x1012_2f7e, 5); cmp(eax, 0xcb_2000);                    /* cmp eax, 0xcb2000 */
            ii(0x1012_2f83, 2); if(jld(0x1012_2f87, 0x2)) goto l_0x1012_2f87; /* jl 0x10122f87 */
        l_0x1012_2f85:
            ii(0x1012_2f85, 2); jmpd(0x1012_2f8c, 0x5); goto l_0x1012_2f8c; /* jmp 0x10122f8c */
        l_0x1012_2f87:
            ii(0x1012_2f87, 5); calld(0x1012_2911, -0x67b);             /* call 0x10122911 */
        l_0x1012_2f8c:
            ii(0x1012_2f8c, 5); jmpd(0x1012_3145, 0x1b4); goto l_0x1012_3145; /* jmp 0x10123145 */
        l_0x1012_2f91:
            ii(0x1012_2f91, 4); imul(eax, memd_a32[ss, ebp - 0x4], 0x1c); /* imul eax, [ebp-0x4], 0x1c */
            ii(0x1012_2f95, 7); cmp(memb_a32[ds, eax + 0x101b_b05c], 0x1); /* cmp byte [eax+0x101bb05c], 0x1 */
            ii(0x1012_2f9c, 2); if(jnzd(0x1012_2fc5, 0x27)) goto l_0x1012_2fc5; /* jnz 0x10122fc5 */
            ii(0x1012_2f9e, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1012_2fa1, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x1012_2fa4, 4); mov(memw_a32[ds, edx + 0x46], ax);      /* mov [edx+0x46], ax */
            ii(0x1012_2fa8, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1012_2fab, 3); mov(edx, memd_a32[ds, eax + 0x44]);     /* mov edx, [eax+0x44] */
            ii(0x1012_2fae, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1012_2fb1, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1012_2fb4, 5); calld(0x1012_25ae, -0xa0b);             /* call 0x101225ae */
            ii(0x1012_2fb9, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1012_2fbc, 4); mov(memb_a32[ds, eax + 0x48], 0x1);     /* mov byte [eax+0x48], 0x1 */
            ii(0x1012_2fc0, 5); jmpd(0x1012_3145, 0x180); goto l_0x1012_3145; /* jmp 0x10123145 */
        l_0x1012_2fc5:
            ii(0x1012_2fc5, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1012_2fc8, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x1012_2fcb, 4); mov(memw_a32[ds, edx + 0x46], ax);      /* mov [edx+0x46], ax */
            ii(0x1012_2fcf, 4); imul(eax, memd_a32[ss, ebp - 0x4], 0x1c); /* imul eax, [ebp-0x4], 0x1c */
            ii(0x1012_2fd3, 6); mov(eax, memd_a32[ds, eax + 0x101b_b068]); /* mov eax, [eax+0x101bb068] */
            ii(0x1012_2fd9, 5); calld(0x100c_fbbe, -0x5_3420);          /* call 0x100cfbbe */
            ii(0x1012_2fde, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x1012_2fe1, 3); add(edx, 0x17);                         /* add edx, 0x17 */
            ii(0x1012_2fe4, 4); imul(eax, memd_a32[ss, ebp - 0x4], 0x1c); /* imul eax, [ebp-0x4], 0x1c */
            ii(0x1012_2fe8, 6); mov(eax, memd_a32[ds, eax + 0x101b_b06c]); /* mov eax, [eax+0x101bb06c] */
            ii(0x1012_2fee, 5); calld(0x100d_7f6c, -0x4_b087);          /* call 0x100d7f6c */
            ii(0x1012_2ff3, 5); mov(eax, 0x3a);                         /* mov eax, 0x3a */
            ii(0x1012_2ff8, 5); calld(Definitions.sys_new, 0x4_2e03);   /* call 0x10165e00 */
            ii(0x1012_2ffd, 3); mov(memd_a32[ss, ebp - 0x5c], eax);     /* mov [ebp-0x5c], eax */
            ii(0x1012_3000, 3); mov(eax, memd_a32[ss, ebp - 0x5c]);     /* mov eax, [ebp-0x5c] */
            ii(0x1012_3003, 3); mov(memd_a32[ss, ebp - 0x60], eax);     /* mov [ebp-0x60], eax */
            ii(0x1012_3006, 4); cmp(memd_a32[ss, ebp - 0x60], 0);       /* cmp dword [ebp-0x60], 0x0 */
            ii(0x1012_300a, 6); if(jzd(0x1012_3091, 0x81)) goto l_0x1012_3091; /* jz 0x10123091 */
            ii(0x1012_3010, 5); mov(eax, 0x5);                          /* mov eax, 0x5 */
            ii(0x1012_3015, 1); pushd(eax);                             /* push eax */
            ii(0x1012_3016, 5); mov(eax, 0xa2);                         /* mov eax, 0xa2 */
            ii(0x1012_301b, 1); pushd(eax);                             /* push eax */
            ii(0x1012_301c, 4); imul(eax, memd_a32[ss, ebp - 0x4], 0x1c); /* imul eax, [ebp-0x4], 0x1c */
            ii(0x1012_3020, 6); mov(eax, memd_a32[ds, eax + 0x101b_b06c]); /* mov eax, [eax+0x101bb06c] */
            ii(0x1012_3026, 5); calld(0x100d_4f24, -0x4_e107);          /* call 0x100d4f24 */
            ii(0x1012_302b, 1); inc(eax);                               /* inc eax */
            ii(0x1012_302c, 1); cwde();                                 /* cwde */
            ii(0x1012_302d, 1); pushd(eax);                             /* push eax */
            ii(0x1012_302e, 4); imul(eax, memd_a32[ss, ebp - 0x4], 0x1c); /* imul eax, [ebp-0x4], 0x1c */
            ii(0x1012_3032, 6); mov(eax, memd_a32[ds, eax + 0x101b_b06c]); /* mov eax, [eax+0x101bb06c] */
            ii(0x1012_3038, 5); calld(0x100d_4f58, -0x4_e0e5);          /* call 0x100d4f58 */
            ii(0x1012_303d, 3); sub(eax, 0x5);                          /* sub eax, 0x5 */
            ii(0x1012_3040, 1); cwde();                                 /* cwde */
            ii(0x1012_3041, 1); pushd(eax);                             /* push eax */
            ii(0x1012_3042, 4); imul(eax, memd_a32[ss, ebp - 0x4], 0x1c); /* imul eax, [ebp-0x4], 0x1c */
            ii(0x1012_3046, 6); mov(eax, memd_a32[ds, eax + 0x101b_b06c]); /* mov eax, [eax+0x101bb06c] */
            ii(0x1012_304c, 5); calld(0x100d_4ebc, -0x4_e195);          /* call 0x100d4ebc */
            ii(0x1012_3051, 1); cwde();                                 /* cwde */
            ii(0x1012_3052, 1); pushd(eax);                             /* push eax */
            ii(0x1012_3053, 4); imul(eax, memd_a32[ss, ebp - 0x4], 0x1c); /* imul eax, [ebp-0x4], 0x1c */
            ii(0x1012_3057, 6); mov(eax, memd_a32[ds, eax + 0x101b_b06c]); /* mov eax, [eax+0x101bb06c] */
            ii(0x1012_305d, 5); calld(0x100d_4ef0, -0x4_e172);          /* call 0x100d4ef0 */
            ii(0x1012_3062, 5); add(eax, 0x5);                          /* add eax, 0x5 */
            ii(0x1012_3067, 1); cwde();                                 /* cwde */
            ii(0x1012_3068, 1); pushd(eax);                             /* push eax */
            ii(0x1012_3069, 5); mov(ecx, 0x1e);                         /* mov ecx, 0x1e */
            ii(0x1012_306e, 4); imul(ebx, memd_a32[ss, ebp - 0x4], 0x1c); /* imul ebx, [ebp-0x4], 0x1c */
            ii(0x1012_3072, 6); mov(ebx, memd_a32[ds, ebx + 0x101b_b070]); /* mov ebx, [ebx+0x101bb070] */
            ii(0x1012_3078, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x1012_307b, 3); add(edx, 0x17);                         /* add edx, 0x17 */
            ii(0x1012_307e, 3); mov(eax, memd_a32[ss, ebp - 0x5c]);     /* mov eax, [ebp-0x5c] */
            ii(0x1012_3081, 5); calld(0x100e_af58, -0x3_812e);          /* call 0x100eaf58 */
            ii(0x1012_3086, 3); mov(memd_a32[ss, ebp - 0x64], eax);     /* mov [ebp-0x64], eax */
            ii(0x1012_3089, 3); mov(eax, memd_a32[ss, ebp - 0x64]);     /* mov eax, [ebp-0x64] */
            ii(0x1012_308c, 3); mov(memd_a32[ss, ebp - 0x68], eax);     /* mov [ebp-0x68], eax */
            ii(0x1012_308f, 2); jmpd(0x1012_3097, 0x6); goto l_0x1012_3097; /* jmp 0x10123097 */
        l_0x1012_3091:
            ii(0x1012_3091, 3); mov(eax, memd_a32[ss, ebp - 0x60]);     /* mov eax, [ebp-0x60] */
            ii(0x1012_3094, 3); mov(memd_a32[ss, ebp - 0x68], eax);     /* mov [ebp-0x68], eax */
        l_0x1012_3097:
            ii(0x1012_3097, 3); mov(eax, memd_a32[ss, ebp - 0x68]);     /* mov eax, [ebp-0x68] */
            ii(0x1012_309a, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x1012_309d, 3); mov(memd_a32[ds, edx + 0x42], eax);     /* mov [edx+0x42], eax */
            ii(0x1012_30a0, 4); imul(eax, memd_a32[ss, ebp - 0x4], 0x1c); /* imul eax, [ebp-0x4], 0x1c */
            ii(0x1012_30a4, 6); mov(al, memb_a32[ds, eax + 0x101b_b05c]); /* mov al, [eax+0x101bb05c] */
            ii(0x1012_30aa, 3); mov(memb_a32[ss, ebp - 0x6c], al);      /* mov [ebp-0x6c], al */
            ii(0x1012_30ad, 2); jmpd(0x1012_30e4, 0x35); goto l_0x1012_30e4; /* jmp 0x101230e4 */
        l_0x1012_30af:
            ii(0x1012_30af, 5); mov(edx, 0x1);                          /* mov edx, 0x1 */
            ii(0x1012_30b4, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1012_30b7, 3); mov(eax, memd_a32[ds, eax + 0x42]);     /* mov eax, [eax+0x42] */
            ii(0x1012_30ba, 5); calld(0x100d_60d4, -0x4_cfeb);          /* call 0x100d60d4 */
            ii(0x1012_30bf, 2); jmpd(0x1012_3106, 0x45); goto l_0x1012_3106; /* jmp 0x10123106 */
        l_0x1012_30c1:
            ii(0x1012_30c1, 5); mov(edx, 0x2);                          /* mov edx, 0x2 */
            ii(0x1012_30c6, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1012_30c9, 3); mov(eax, memd_a32[ds, eax + 0x42]);     /* mov eax, [eax+0x42] */
            ii(0x1012_30cc, 5); calld(0x100d_60d4, -0x4_cffd);          /* call 0x100d60d4 */
            ii(0x1012_30d1, 2); jmpd(0x1012_3106, 0x33); goto l_0x1012_3106; /* jmp 0x10123106 */
        l_0x1012_30d3:
            ii(0x1012_30d3, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1012_30d5, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1012_30d8, 3); mov(eax, memd_a32[ds, eax + 0x42]);     /* mov eax, [eax+0x42] */
            ii(0x1012_30db, 5); calld(0x100d_60d4, -0x4_d00c);          /* call 0x100d60d4 */
            ii(0x1012_30e0, 2); jmpd(0x1012_3106, 0x24); goto l_0x1012_3106; /* jmp 0x10123106 */
        l_0x1012_30e2:
            ii(0x1012_30e2, 2); jmpd(0x1012_3106, 0x22); goto l_0x1012_3106; /* jmp 0x10123106 */
        l_0x1012_30e4:
            ii(0x1012_30e4, 3); mov(al, memb_a32[ss, ebp - 0x6c]);      /* mov al, [ebp-0x6c] */
            ii(0x1012_30e7, 3); mov(memb_a32[ss, ebp - 0x70], al);      /* mov [ebp-0x70], al */
            ii(0x1012_30ea, 4); cmp(memb_a32[ss, ebp - 0x70], 0x3);     /* cmp byte [ebp-0x70], 0x3 */
            ii(0x1012_30ee, 2); if(jbd(0x1012_30fe, 0xe)) goto l_0x1012_30fe; /* jb 0x101230fe */
            ii(0x1012_30f0, 4); cmp(memb_a32[ss, ebp - 0x70], 0x3);     /* cmp byte [ebp-0x70], 0x3 */
            ii(0x1012_30f4, 2); if(jbed(0x1012_30c1, -0x35)) goto l_0x1012_30c1; /* jbe 0x101230c1 */
            ii(0x1012_30f6, 4); cmp(memb_a32[ss, ebp - 0x70], 0x4);     /* cmp byte [ebp-0x70], 0x4 */
            ii(0x1012_30fa, 2); if(jzd(0x1012_30d3, -0x29)) goto l_0x1012_30d3; /* jz 0x101230d3 */
            ii(0x1012_30fc, 2); jmpd(0x1012_30e2, -0x1c); goto l_0x1012_30e2; /* jmp 0x101230e2 */
        l_0x1012_30fe:
            ii(0x1012_30fe, 4); cmp(memb_a32[ss, ebp - 0x70], 0x2);     /* cmp byte [ebp-0x70], 0x2 */
            ii(0x1012_3102, 2); if(jzd(0x1012_30af, -0x55)) goto l_0x1012_30af; /* jz 0x101230af */
            ii(0x1012_3104, 2); jmpd(0x1012_30e2, -0x24); goto l_0x1012_30e2; /* jmp 0x101230e2 */
        l_0x1012_3106:
            ii(0x1012_3106, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1012_3109, 3); mov(eax, memd_a32[ds, eax + 0x42]);     /* mov eax, [eax+0x42] */
            ii(0x1012_310c, 5); calld(0x100e_b180, -0x3_7f91);          /* call 0x100eb180 */
            ii(0x1012_3111, 4); imul(eax, memd_a32[ss, ebp - 0x4], 0x1c); /* imul eax, [ebp-0x4], 0x1c */
            ii(0x1012_3115, 6); mov(edx, memd_a32[ds, eax + 0x101b_b070]); /* mov edx, [eax+0x101bb070] */
            ii(0x1012_311b, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1012_311e, 3); mov(eax, memd_a32[ds, eax + 0x42]);     /* mov eax, [eax+0x42] */
            ii(0x1012_3121, 5); calld(0x100e_b14d, -0x3_7fd9);          /* call 0x100eb14d */
            ii(0x1012_3126, 5); calld(0x100d_6104, -0x4_d027);          /* call 0x100d6104 */
            ii(0x1012_312b, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1012_312d, 2); mov(dl, al);                            /* mov dl, al */
            ii(0x1012_312f, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1012_3132, 3); mov(eax, memd_a32[ds, eax + 0x42]);     /* mov eax, [eax+0x42] */
            ii(0x1012_3135, 5); calld(0x100e_b5e1, -0x3_7b59);          /* call 0x100eb5e1 */
            ii(0x1012_313a, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1012_313d, 3); mov(eax, memd_a32[ds, eax + 0x42]);     /* mov eax, [eax+0x42] */
            ii(0x1012_3140, 5); calld(0x100e_b1b2, -0x3_7f93);          /* call 0x100eb1b2 */
        l_0x1012_3145:
            ii(0x1012_3145, 2); jmpd(0x1012_315e, 0x17); goto l_0x1012_315e; /* jmp 0x1012315e */
        l_0x1012_3147:
            ii(0x1012_3147, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1012_314a, 4); cmp(memd_a32[ds, eax + 0x42], 0);       /* cmp dword [eax+0x42], 0x0 */
            ii(0x1012_314e, 2); if(jzd(0x1012_315e, 0xe)) goto l_0x1012_315e; /* jz 0x1012315e */
            ii(0x1012_3150, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x1012_3153, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1012_3156, 3); mov(eax, memd_a32[ds, eax + 0x42]);     /* mov eax, [eax+0x42] */
            ii(0x1012_3159, 5); calld(0x100e_b283, -0x3_7edb);          /* call 0x100eb283 */
        l_0x1012_315e:
            ii(0x1012_315e, 2); if(jmpd_func(0x1012_31ce, 0x6e)) return; /* jmp 0x101231ce */
        }
    }
}
