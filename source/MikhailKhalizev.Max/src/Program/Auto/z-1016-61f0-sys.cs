using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1016_61f0-8b7704ef")]
        public void /* sys */ Method_1016_61f0()
        {
            ii(0x1016_61f0, 1); pushd(ecx);                             /* push ecx */
            ii(0x1016_61f1, 1); pushd(esi);                             /* push esi */
            ii(0x1016_61f2, 1); pushd(edi);                             /* push edi */
            ii(0x1016_61f3, 1); pushd(ebp);                             /* push ebp */
            ii(0x1016_61f4, 3); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x1016_61f7, 3); mov(memd_a32[ss, esp], eax);            /* mov [esp], eax */
            ii(0x1016_61fa, 2); mov(esi, edx);                          /* mov esi, edx */
            ii(0x1016_61fc, 4); mov(memd_a32[ss, esp + 0x4], ebx);      /* mov [esp+0x4], ebx */
            ii(0x1016_6200, 7); cmp(memd_a32[ds, 0x101b_ddbc], 0);      /* cmp dword [0x101bddbc], 0x0 */
            ii(0x1016_6207, 2); if(jzd(0x1016_6213, 0xa)) goto l_0x1016_6213; /* jz 0x10166213 */
            ii(0x1016_6209, 5); mov(eax, 0x4);                          /* mov eax, 0x4 */
            ii(0x1016_620e, 5); jmpd(0x1016_64f4, 0x2e1); goto l_0x1016_64f4; /* jmp 0x101664f4 */
        l_0x1016_6213:
            ii(0x1016_6213, 5); mov(ecx, 0x32);                         /* mov ecx, 0x32 */
            ii(0x1016_6218, 5); mov(edx, 0xffff_ffff);                  /* mov edx, 0xffffffff */
            ii(0x1016_621d, 5); mov(eax, 0x101c_b134);                  /* mov eax, 0x101cb134 */
            ii(0x1016_6222, 5); calld(/* sys */ 0x1018_1077, 0x1_ae50); /* call 0x10181077 */
            ii(0x1016_6227, 5); calld(/* sys */ 0x1016_e350, 0x8124);   /* call 0x1016e350 */
            ii(0x1016_622c, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1016_622e, 2); if(jnzd(0x1016_624e, 0x1e)) goto l_0x1016_624e; /* jnz 0x1016624e */
            ii(0x1016_6230, 5); mov(ebx, StringDefinitions.Empty2);     /* mov ebx, 0x101b2dcc */
            ii(0x1016_6235, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1016_6237, 5); calld(/* sys */ 0x1016_e290, 0x8054);   /* call 0x1016e290 */
            ii(0x1016_623c, 3); cmp(eax, -0x1 /* 0xff */);              /* cmp eax, 0xffffffff */
            ii(0x1016_623f, 2); if(jnzd(0x1016_624e, 0xd)) goto l_0x1016_624e; /* jnz 0x1016624e */
            ii(0x1016_6241, 5); mov(eax, 0x7);                          /* mov eax, 0x7 */
            ii(0x1016_6246, 3); add(esp, 0x8);                          /* add esp, 0x8 */
            ii(0x1016_6249, 1); popd(ebp);                              /* pop ebp */
            ii(0x1016_624a, 1); popd(edi);                              /* pop edi */
            ii(0x1016_624b, 1); popd(esi);                              /* pop esi */
            ii(0x1016_624c, 1); popd(ecx);                              /* pop ecx */
            ii(0x1016_624d, 1); retd(); return;                         /* ret */
        l_0x1016_624e:
            ii(0x1016_624e, 5); calld(/* sys */ 0x1016_9ecc, 0x3c79);   /* call 0x10169ecc */
            ii(0x1016_6253, 3); cmp(eax, -0x1 /* 0xff */);              /* cmp eax, 0xffffffff */
            ii(0x1016_6256, 2); if(jnzd(0x1016_6265, 0xd)) goto l_0x1016_6265; /* jnz 0x10166265 */
            ii(0x1016_6258, 5); mov(eax, 0x3);                          /* mov eax, 0x3 */
            ii(0x1016_625d, 3); add(esp, 0x8);                          /* add esp, 0x8 */
            ii(0x1016_6260, 1); popd(ebp);                              /* pop ebp */
            ii(0x1016_6261, 1); popd(edi);                              /* pop edi */
            ii(0x1016_6262, 1); popd(esi);                              /* pop esi */
            ii(0x1016_6263, 1); popd(ecx);                              /* pop ecx */
            ii(0x1016_6264, 1); retd(); return;                         /* ret */
        l_0x1016_6265:
            ii(0x1016_6265, 5); calld(/* sys */ 0x1017_1858, 0xb5ee);   /* call 0x10171858 */
            ii(0x1016_626a, 3); mov(eax, memd_a32[ss, esp]);            /* mov eax, [esp] */
            ii(0x1016_626d, 6); mov(memd_a32[ds, 0x101c_b2d4], esi);    /* mov [0x101cb2d4], esi */
            ii(0x1016_6273, 5); mov(memd_a32[ds, 0x101c_b2cc], eax);    /* mov [0x101cb2cc], eax */
            ii(0x1016_6278, 3); calld_abs(memd_a32[ss, esp]);           /* call dword [esp] */
            ii(0x1016_627b, 3); cmp(eax, -0x1 /* 0xff */);              /* cmp eax, 0xffffffff */
            ii(0x1016_627e, 2); if(jnzd(0x1016_628d, 0xd)) goto l_0x1016_628d; /* jnz 0x1016628d */
            ii(0x1016_6280, 5); mov(eax, 0x1);                          /* mov eax, 0x1 */
            ii(0x1016_6285, 3); add(esp, 0x8);                          /* add esp, 0x8 */
            ii(0x1016_6288, 1); popd(ebp);                              /* pop ebp */
            ii(0x1016_6289, 1); popd(edi);                              /* pop edi */
            ii(0x1016_628a, 1); popd(esi);                              /* pop esi */
            ii(0x1016_628b, 1); popd(ecx);                              /* pop ecx */
            ii(0x1016_628c, 1); retd(); return;                         /* ret */
        l_0x1016_628d:
            ii(0x1016_628d, 5); test(memb_a32[ss, esp + 0x4], 0x1);     /* test byte [esp+0x4], 0x1 */
            ii(0x1016_6292, 2); if(jzd(0x1016_62e5, 0x51)) goto l_0x1016_62e5; /* jz 0x101662e5 */
            ii(0x1016_6294, 6); mov(esi, memd_a32[ds, 0x1020_88ec]);    /* mov esi, [0x102088ec] */
            ii(0x1016_629a, 6); mov(ebx, memd_a32[ds, 0x1020_88e4]);    /* mov ebx, [0x102088e4] */
            ii(0x1016_62a0, 5); mov(eax, memd_a32[ds, 0x1020_88e8]);    /* mov eax, [0x102088e8] */
            ii(0x1016_62a5, 6); mov(ecx, memd_a32[ds, 0x1020_88e0]);    /* mov ecx, [0x102088e0] */
            ii(0x1016_62ab, 2); sub(esi, ebx);                          /* sub esi, ebx */
            ii(0x1016_62ad, 2); sub(eax, ecx);                          /* sub eax, ecx */
            ii(0x1016_62af, 1); inc(esi);                               /* inc esi */
            ii(0x1016_62b0, 1); inc(eax);                               /* inc eax */
            ii(0x1016_62b1, 3); imul(eax, esi);                         /* imul eax, esi */
            ii(0x1016_62b4, 5); calld(Definitions.sys_malloc_internal, 0x1_c037); /* call 0x101822f0 */
            ii(0x1016_62b9, 5); mov(memd_a32[ds, 0x101b_ddd8], eax);    /* mov [0x101bddd8], eax */
            ii(0x1016_62be, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1016_62c0, 2); if(jnzd(0x1016_62e5, 0x23)) goto l_0x1016_62e5; /* jnz 0x101662e5 */
            ii(0x1016_62c2, 7); cmp(memd_a32[ds, 0x101c_b2d4], 0);      /* cmp dword [0x101cb2d4], 0x0 */
            ii(0x1016_62c9, 2); if(jzd(0x1016_62d3, 0x8)) goto l_0x1016_62d3; /* jz 0x101662d3 */
            ii(0x1016_62cb, 6); calld_abs(memd_a32[ds, 0x101c_b2d4]);   /* call dword [0x101cb2d4] */
            ii(0x1016_62d1, 2); jmpd(0x1016_62d8, 0x5); goto l_0x1016_62d8; /* jmp 0x101662d8 */
        l_0x1016_62d3:
            ii(0x1016_62d3, 5); calld(/* sys */ 0x1017_1880, 0xb5a8);   /* call 0x10171880 */
        l_0x1016_62d8:
            ii(0x1016_62d8, 5); mov(eax, 0x2);                          /* mov eax, 0x2 */
            ii(0x1016_62dd, 3); add(esp, 0x8);                          /* add esp, 0x8 */
            ii(0x1016_62e0, 1); popd(ebp);                              /* pop ebp */
            ii(0x1016_62e1, 1); popd(edi);                              /* pop edi */
            ii(0x1016_62e2, 1); popd(esi);                              /* pop esi */
            ii(0x1016_62e3, 1); popd(ecx);                              /* pop ecx */
            ii(0x1016_62e4, 1); retd(); return;                         /* ret */
        l_0x1016_62e5:
            ii(0x1016_62e5, 5); mov(ebx, /* sys */ 0x1016_8690);        /* mov ebx, 0x10168690 */
            ii(0x1016_62ea, 5); mov(edx, /* sys */ 0x1016_8698);        /* mov edx, 0x10168698 */
            ii(0x1016_62ef, 2); xor(esi, esi);                          /* xor esi, esi */
            ii(0x1016_62f1, 5); mov(eax, /* sys */ 0x1016_8624);        /* mov eax, 0x10168624 */
            ii(0x1016_62f6, 6); mov(memd_a32[ds, 0x101c_b2c4], esi);    /* mov [0x101cb2c4], esi */
            ii(0x1016_62fc, 6); mov(memd_a32[ds, 0x101c_b2d0], esi);    /* mov [0x101cb2d0], esi */
            ii(0x1016_6302, 5); calld(/* sys */ 0x1016_ca48, 0x6741);   /* call 0x1016ca48 */
            ii(0x1016_6307, 5); mov(ebx, Definitions.sys_free_internal); /* mov ebx, 0x10182454 */
            ii(0x1016_630c, 5); mov(edx, /* sys */ 0x1018_2374);        /* mov edx, 0x10182374 */
            ii(0x1016_6311, 5); mov(eax, Definitions.sys_malloc_internal); /* mov eax, 0x101822f0 */
            ii(0x1016_6316, 5); calld(/* sys */ 0x1016_d668, 0x734d);   /* call 0x1016d668 */
            ii(0x1016_631b, 5); calld(/* sys */ 0x1016_e1e8, 0x7ec8);   /* call 0x1016e1e8 */
            ii(0x1016_6320, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1016_6322, 2); if(jnzd(0x1016_638e, 0x6a)) goto l_0x1016_638e; /* jnz 0x1016638e */
            ii(0x1016_6324, 5); mov(eax, 0x300);                        /* mov eax, 0x300 */
            ii(0x1016_6329, 5); calld(Definitions.sys_malloc_internal, 0x1_bfc2); /* call 0x101822f0 */
            ii(0x1016_632e, 2); mov(esi, eax);                          /* mov esi, eax */
            ii(0x1016_6330, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1016_6332, 2); if(jnzd(0x1016_6368, 0x34)) goto l_0x1016_6368; /* jnz 0x10166368 */
            ii(0x1016_6334, 7); cmp(memd_a32[ds, 0x101c_b2d4], 0);      /* cmp dword [0x101cb2d4], 0x0 */
            ii(0x1016_633b, 2); if(jzd(0x1016_6345, 0x8)) goto l_0x1016_6345; /* jz 0x10166345 */
            ii(0x1016_633d, 6); calld_abs(memd_a32[ds, 0x101c_b2d4]);   /* call dword [0x101cb2d4] */
            ii(0x1016_6343, 2); jmpd(0x1016_634a, 0x5); goto l_0x1016_634a; /* jmp 0x1016634a */
        l_0x1016_6345:
            ii(0x1016_6345, 5); calld(/* sys */ 0x1017_1880, 0xb536);   /* call 0x10171880 */
        l_0x1016_634a:
            ii(0x1016_634a, 6); mov(ebx, memd_a32[ds, 0x101b_ddd8]);    /* mov ebx, [0x101bddd8] */
            ii(0x1016_6350, 2); test(ebx, ebx);                         /* test ebx, ebx */
            ii(0x1016_6352, 2); if(jzd(0x1016_635b, 0x7)) goto l_0x1016_635b; /* jz 0x1016635b */
            ii(0x1016_6354, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x1016_6356, 5); calld(Definitions.sys_free_internal, 0x1_c0f9); /* call 0x10182454 */
        l_0x1016_635b:
            ii(0x1016_635b, 5); mov(eax, 0x2);                          /* mov eax, 0x2 */
            ii(0x1016_6360, 3); add(esp, 0x8);                          /* add esp, 0x8 */
            ii(0x1016_6363, 1); popd(ebp);                              /* pop ebp */
            ii(0x1016_6364, 1); popd(edi);                              /* pop edi */
            ii(0x1016_6365, 1); popd(esi);                              /* pop esi */
            ii(0x1016_6366, 1); popd(ecx);                              /* pop ecx */
            ii(0x1016_6367, 1); retd(); return;                         /* ret */
        l_0x1016_6368:
            ii(0x1016_6368, 2); pushd(0);                               /* push 0x0 */
            ii(0x1016_636a, 5); mov(ecx, 0x300);                        /* mov ecx, 0x300 */
            ii(0x1016_636f, 5); mov(ebx, 0x1);                          /* mov ebx, 0x1 */
            ii(0x1016_6374, 2); mov(edx, ecx);                          /* mov edx, ecx */
            ii(0x1016_6376, 5); calld(/* sys */ 0x1016_ad78, 0x49fd);   /* call 0x1016ad78 */
            ii(0x1016_637b, 2); mov(edx, esi);                          /* mov edx, esi */
            ii(0x1016_637d, 5); calld(/* sys */ 0x1016_cc1c, 0x689a);   /* call 0x1016cc1c */
            ii(0x1016_6382, 5); calld(/* sys */ 0x1016_d744, 0x73bd);   /* call 0x1016d744 */
            ii(0x1016_6387, 2); mov(eax, esi);                          /* mov eax, esi */
            ii(0x1016_6389, 5); calld(Definitions.sys_free_internal, 0x1_c0c6); /* call 0x10182454 */
        l_0x1016_638e:
            ii(0x1016_638e, 4); mov(dl, memb_a32[ss, esp + 0x5]);       /* mov dl, [esp+0x5] */
            ii(0x1016_6392, 5); calld(/* sys */ 0x1018_2630, 0x1_c299); /* call 0x10182630 */
            ii(0x1016_6397, 3); test(dl, 0x2);                          /* test dl, 0x2 */
            ii(0x1016_639a, 2); if(jzd(0x1016_63a0, 0x4)) goto l_0x1016_63a0; /* jz 0x101663a0 */
            ii(0x1016_639c, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1016_639e, 2); jmpd(0x1016_63a5, 0x5); goto l_0x1016_63a5; /* jmp 0x101663a5 */
        l_0x1016_63a0:
            ii(0x1016_63a0, 5); mov(eax, 0x1);                          /* mov eax, 0x1 */
        l_0x1016_63a5:
            ii(0x1016_63a5, 5); calld(/* sys */ 0x1016_b15c, 0x4db2);   /* call 0x1016b15c */
            ii(0x1016_63aa, 5); calld(/* sys */ 0x1018_588c, 0x1_f4dd); /* call 0x1018588c */
            ii(0x1016_63af, 5); mov(eax, 0x44);                         /* mov eax, 0x44 */
            ii(0x1016_63b4, 5); calld(Definitions.sys_malloc_internal, 0x1_bf37); /* call 0x101822f0 */
            ii(0x1016_63b9, 5); mov(memd_a32[ds, 0x101c_b1fc], eax);    /* mov [0x101cb1fc], eax */
            ii(0x1016_63be, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1016_63c0, 2); if(jnzd(0x1016_63f3, 0x31)) goto l_0x1016_63f3; /* jnz 0x101663f3 */
            ii(0x1016_63c2, 7); cmp(memd_a32[ds, 0x101c_b2d4], 0);      /* cmp dword [0x101cb2d4], 0x0 */
            ii(0x1016_63c9, 2); if(jzd(0x1016_63d3, 0x8)) goto l_0x1016_63d3; /* jz 0x101663d3 */
            ii(0x1016_63cb, 6); calld_abs(memd_a32[ds, 0x101c_b2d4]);   /* call dword [0x101cb2d4] */
            ii(0x1016_63d1, 2); jmpd(0x1016_63d8, 0x5); goto l_0x1016_63d8; /* jmp 0x101663d8 */
        l_0x1016_63d3:
            ii(0x1016_63d3, 5); calld(/* sys */ 0x1017_1880, 0xb4a8);   /* call 0x10171880 */
        l_0x1016_63d8:
            ii(0x1016_63d8, 5); mov(eax, memd_a32[ds, 0x101b_ddd8]);    /* mov eax, [0x101bddd8] */
            ii(0x1016_63dd, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1016_63df, 2); if(jzd(0x1016_63e6, 0x5)) goto l_0x1016_63e6; /* jz 0x101663e6 */
            ii(0x1016_63e1, 5); calld(Definitions.sys_free_internal, 0x1_c06e); /* call 0x10182454 */
        l_0x1016_63e6:
            ii(0x1016_63e6, 5); mov(eax, 0x2);                          /* mov eax, 0x2 */
            ii(0x1016_63eb, 3); add(esp, 0x8);                          /* add esp, 0x8 */
            ii(0x1016_63ee, 1); popd(ebp);                              /* pop ebp */
            ii(0x1016_63ef, 1); popd(edi);                              /* pop edi */
            ii(0x1016_63f0, 1); popd(esi);                              /* pop esi */
            ii(0x1016_63f1, 1); popd(ecx);                              /* pop ecx */
            ii(0x1016_63f2, 1); retd(); return;                         /* ret */
        l_0x1016_63f3:
            ii(0x1016_63f3, 7); mov(memd_a32[ds, eax + 0x2c], 0);       /* mov dword [eax+0x2c], 0x0 */
            ii(0x1016_63fa, 6); mov(memd_a32[ds, eax], 0);              /* mov dword [eax], 0x0 */
            ii(0x1016_6400, 7); mov(memd_a32[ds, eax + 0x4], 0);        /* mov dword [eax+0x4], 0x0 */
            ii(0x1016_6407, 7); mov(memd_a32[ds, eax + 0x30], 0);       /* mov dword [eax+0x30], 0x0 */
            ii(0x1016_640e, 5); mov(edi, 0x1);                          /* mov edi, 0x1 */
            ii(0x1016_6413, 7); mov(memd_a32[ds, eax + 0x34], 0);       /* mov dword [eax+0x34], 0x0 */
            ii(0x1016_641a, 5); mov(ecx, 0x5294);                       /* mov ecx, 0x5294 */
            ii(0x1016_641f, 7); mov(memd_a32[ds, eax + 0x38], 0);       /* mov dword [eax+0x38], 0x0 */
            ii(0x1016_6426, 6); mov(esi, memd_a32[ds, 0x1020_88e0]);    /* mov esi, [0x102088e0] */
            ii(0x1016_642c, 7); mov(memd_a32[ds, eax + 0x3c], 0);       /* mov dword [eax+0x3c], 0x0 */
            ii(0x1016_6433, 6); mov(ebp, memd_a32[ds, 0x1020_88e0]);    /* mov ebp, [0x102088e0] */
            ii(0x1016_6439, 7); mov(memd_a32[ds, eax + 0x24], 0);       /* mov dword [eax+0x24], 0x0 */
            ii(0x1016_6440, 6); mov(edx, memd_a32[ds, 0x1020_88e4]);    /* mov edx, [0x102088e4] */
            ii(0x1016_6446, 7); mov(memd_a32[ds, eax + 0x28], 0);       /* mov dword [eax+0x28], 0x0 */
            ii(0x1016_644d, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x1016_644f, 3); mov(memd_a32[ds, eax + 0x8], esi);      /* mov [eax+0x8], esi */
            ii(0x1016_6452, 6); mov(esi, memd_a32[ds, 0x1020_88e4]);    /* mov esi, [0x102088e4] */
            ii(0x1016_6458, 6); mov(memd_a32[ds, 0x101c_b2e0], ebx);    /* mov [0x101cb2e0], ebx */
            ii(0x1016_645e, 3); mov(memd_a32[ds, eax + 0xc], esi);      /* mov [eax+0xc], esi */
            ii(0x1016_6461, 6); mov(esi, memd_a32[ds, 0x1020_88e8]);    /* mov esi, [0x102088e8] */
            ii(0x1016_6467, 6); mov(memd_a32[ds, 0x101c_b2c8], ebx);    /* mov [0x101cb2c8], ebx */
            ii(0x1016_646d, 3); mov(memd_a32[ds, eax + 0x10], esi);     /* mov [eax+0x10], esi */
            ii(0x1016_6470, 6); mov(esi, memd_a32[ds, 0x1020_88ec]);    /* mov esi, [0x102088ec] */
            ii(0x1016_6476, 6); mov(memd_a32[ds, 0x101c_b2d8], edi);    /* mov [0x101cb2d8], edi */
            ii(0x1016_647c, 3); mov(memd_a32[ds, eax + 0x14], esi);     /* mov [eax+0x14], esi */
            ii(0x1016_647f, 6); mov(esi, memd_a32[ds, 0x1020_88e8]);    /* mov esi, [0x102088e8] */
            ii(0x1016_6485, 6); mov(memd_a32[ds, 0x101b_ddbc], edi);    /* mov [0x101bddbc], edi */
            ii(0x1016_648b, 2); sub(esi, ebp);                          /* sub esi, ebp */
            ii(0x1016_648d, 6); mov(memd_a32[ds, 0x101b_ddcc], ecx);    /* mov [0x101bddcc], ecx */
            ii(0x1016_6493, 1); inc(esi);                               /* inc esi */
            ii(0x1016_6494, 5); mov(edi, 0x7c00);                       /* mov edi, 0x7c00 */
            ii(0x1016_6499, 3); mov(memd_a32[ds, eax + 0x18], esi);     /* mov [eax+0x18], esi */
            ii(0x1016_649c, 6); mov(esi, memd_a32[ds, 0x1020_88ec]);    /* mov esi, [0x102088ec] */
            ii(0x1016_64a2, 6); mov(memd_a32[ds, 0x101b_ddd4], edi);    /* mov [0x101bddd4], edi */
            ii(0x1016_64a8, 2); sub(esi, edx);                          /* sub esi, edx */
            ii(0x1016_64aa, 5); mov(edx, 0x3def);                       /* mov edx, 0x3def */
            ii(0x1016_64af, 1); inc(esi);                               /* inc esi */
            ii(0x1016_64b0, 6); mov(memd_a32[ds, 0x101b_ddc4], edx);    /* mov [0x101bddc4], edx */
            ii(0x1016_64b6, 3); mov(memd_a32[ds, eax + 0x1c], esi);     /* mov [eax+0x1c], esi */
            ii(0x1016_64b9, 4); mov(eax, memd_a32[ss, esp + 0x4]);      /* mov eax, [esp+0x4] */
            ii(0x1016_64bd, 5); mov(esi, 0x7feb);                       /* mov esi, 0x7feb */
            ii(0x1016_64c2, 6); mov(memd_a32[ds, 0x101c_b134], ebx);    /* mov [0x101cb134], ebx */
            ii(0x1016_64c8, 5); mov(ebx, 0x2108);                       /* mov ebx, 0x2108 */
            ii(0x1016_64cd, 5); mov(memd_a32[ds, 0x101c_b2dc], eax);    /* mov [0x101cb2dc], eax */
            ii(0x1016_64d2, 5); mov(eax, 0x294a);                       /* mov eax, 0x294a */
            ii(0x1016_64d7, 6); mov(memd_a32[ds, 0x101b_ddd0], esi);    /* mov [0x101bddd0], esi */
            ii(0x1016_64dd, 5); mov(memd_a32[ds, 0x101b_ddc0], eax);    /* mov [0x101bddc0], eax */
            ii(0x1016_64e2, 5); mov(eax, /* sys */ 0x1016_66b0);        /* mov eax, 0x101666b0 */
            ii(0x1016_64e7, 6); mov(memd_a32[ds, 0x101b_ddc8], ebx);    /* mov [0x101bddc8], ebx */
            ii(0x1016_64ed, 5); calld(/* sys */ 0x1016_c6c8, 0x61d6);   /* call 0x1016c6c8 */
            ii(0x1016_64f2, 2); xor(eax, eax);                          /* xor eax, eax */
        l_0x1016_64f4:
            ii(0x1016_64f4, 3); add(esp, 0x8);                          /* add esp, 0x8 */
            ii(0x1016_64f7, 1); popd(ebp);                              /* pop ebp */
            ii(0x1016_64f8, 1); popd(edi);                              /* pop edi */
            ii(0x1016_64f9, 1); popd(esi);                              /* pop esi */
            ii(0x1016_64fa, 1); popd(ecx);                              /* pop ecx */
            ii(0x1016_64fb, 1); retd(); return;                         /* ret */
        }
    }
}
