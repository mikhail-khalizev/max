using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("569dfe7f-ee5b-4477-9f7d-0e69a5a34e0b")]
        public void Method_100f_e1cd()
        {
            ii(0x100f_e1cd, 5); pushd(0x104);                           /* push 0x104 */
            ii(0x100f_e1d2, 5); calld(Definitions.sys_check_available_stack_size, 0x6_7b7b); /* call 0x10165d52 */
            ii(0x100f_e1d7, 1); pushd(ebx);                             /* push ebx */
            ii(0x100f_e1d8, 1); pushd(ecx);                             /* push ecx */
            ii(0x100f_e1d9, 1); pushd(edx);                             /* push edx */
            ii(0x100f_e1da, 1); pushd(esi);                             /* push esi */
            ii(0x100f_e1db, 1); pushd(edi);                             /* push edi */
            ii(0x100f_e1dc, 1); pushd(ebp);                             /* push ebp */
            ii(0x100f_e1dd, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100f_e1df, 6); sub(esp, 0xd0);                         /* sub esp, 0xd0 */
            ii(0x100f_e1e5, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x100f_e1e8, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100f_e1ea, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x100f_e1ec, 5); calld(0x100f_b4fd, -0x2cf4);            /* call 0x100fb4fd */
            ii(0x100f_e1f1, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x100f_e1f3, 5); calld(0x100f_a7e8, -0x3a10);            /* call 0x100fa7e8 */
            ii(0x100f_e1f8, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x100f_e1fa, 5); calld(0x100f_47e4, -0x9a1b);            /* call 0x100f47e4 */
            ii(0x100f_e1ff, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x100f_e201, 5); calld(0x100f_487e, -0x9988);            /* call 0x100f487e */
            ii(0x100f_e206, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x100f_e208, 5); calld(0x100f_48cb, -0x9942);            /* call 0x100f48cb */
            ii(0x100f_e20d, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x100f_e20f, 5); calld(0x100f_4965, -0x98af);            /* call 0x100f4965 */
            ii(0x100f_e214, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x100f_e216, 5); calld(0x100f_4831, -0x99ea);            /* call 0x100f4831 */
            ii(0x100f_e21b, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x100f_e21d, 5); calld(0x100f_4ba0, -0x9682);            /* call 0x100f4ba0 */
            ii(0x100f_e222, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x100f_e224, 5); calld(0x100f_4f55, -0x92d4);            /* call 0x100f4f55 */
            ii(0x100f_e229, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x100f_e22b, 5); calld(0x100f_49b2, -0x987e);            /* call 0x100f49b2 */
            ii(0x100f_e230, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x100f_e232, 5); calld(0x100f_49ff, -0x9838);            /* call 0x100f49ff */
            ii(0x100f_e237, 5); calld(0x100f_a835, -0x3a07);            /* call 0x100fa835 */
            ii(0x100f_e23c, 5); mov(ebx, 0x1);                          /* mov ebx, 0x1 */
            ii(0x100f_e241, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100f_e243, 5); mov(eax, 0x6);                          /* mov eax, 0x6 */
            ii(0x100f_e248, 5); calld(0x100f_fca3, 0x1a56);             /* call 0x100ffca3 */
            ii(0x100f_e24d, 5); mov(ebx, 0x1);                          /* mov ebx, 0x1 */
            ii(0x100f_e252, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100f_e254, 5); mov(eax, 0x9);                          /* mov eax, 0x9 */
            ii(0x100f_e259, 5); calld(0x100f_fca3, 0x1a45);             /* call 0x100ffca3 */
            ii(0x100f_e25e, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100f_e260, 5); mov(eax, 0x101c_37bc);                  /* mov eax, 0x101c37bc */
            ii(0x100f_e265, 5); calld(0x1013_ad71, 0x3_cb07);           /* call 0x1013ad71 */
            ii(0x100f_e26a, 2); test(al, al);                           /* test al, al */
            ii(0x100f_e26c, 2); if(jzd(0x100f_e28f, 0x21)) goto l_0x100f_e28f; /* jz 0x100fe28f */
            ii(0x100f_e26e, 5); calld(0x1010_2bf8, 0x4985);             /* call 0x10102bf8 */
            ii(0x100f_e273, 2); xor(ecx, ecx);                          /* xor ecx, ecx */
            ii(0x100f_e275, 2); mov(cl, al);                            /* mov cl, al */
            ii(0x100f_e277, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x100f_e279, 5); mov(eax, 0x101c_37bc);                  /* mov eax, 0x101c37bc */
            ii(0x100f_e27e, 5); calld(0x1007_6600, -0x8_7c83);          /* call 0x10076600 */
            ii(0x100f_e283, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100f_e285, 5); mov(eax, 0x101c_7278);                  /* mov eax, 0x101c7278 */
            ii(0x100f_e28a, 5); calld(0x1013_d5c0, 0x3_f331);           /* call 0x1013d5c0 */
        l_0x100f_e28f:
            ii(0x100f_e28f, 5); mov(ecx, 0x1);                          /* mov ecx, 0x1 */
            ii(0x100f_e294, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x100f_e296, 5); mov(edx, 0x4);                          /* mov edx, 0x4 */
            ii(0x100f_e29b, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x100f_e29d, 5); calld(0x1010_1620, 0x337e);             /* call 0x10101620 */
            ii(0x100f_e2a2, 5); mov(eax, 0x1);                          /* mov eax, 0x1 */
            ii(0x100f_e2a7, 5); calld(0x1010_0efe, 0x2c52);             /* call 0x10100efe */
            ii(0x100f_e2ac, 5); mov(ebx, 0x1);                          /* mov ebx, 0x1 */
            ii(0x100f_e2b1, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100f_e2b3, 4); movsx(eax, memw_a32[ss, ebp - 0x4]);    /* movsx eax, word [ebp-0x4] */
            ii(0x100f_e2b7, 5); calld(0x1007_1d59, -0x8_c563);          /* call 0x10071d59 */
            ii(0x100f_e2bc, 5); mov(eax, 0x23);                         /* mov eax, 0x23 */
            ii(0x100f_e2c1, 5); calld(0x100e_883d, -0x1_5a89);          /* call 0x100e883d */
            ii(0x100f_e2c6, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100f_e2c9, 5); pushd(0x280);                           /* push 0x280 */
            ii(0x100f_e2ce, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100f_e2d1, 3); pushd(memd_a32[ds, eax + 0x16]);        /* push dword [eax+0x16] */
            ii(0x100f_e2d4, 2); pushd(0x70);                            /* push 0x70 */
            ii(0x100f_e2d6, 2); pushd(0x70);                            /* push 0x70 */
            ii(0x100f_e2d8, 2); pushd(0x70);                            /* push 0x70 */
            ii(0x100f_e2da, 6); pushd(memd_a32[ds, 0x101c_70e0]);       /* push dword [0x101c70e0] */
            ii(0x100f_e2e0, 5); calld(/* sys */ 0x1016_abbc, 0x6_c8d7); /* call 0x1016abbc */
            ii(0x100f_e2e5, 3); add(esp, 0x18);                         /* add esp, 0x18 */
            ii(0x100f_e2e8, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x100f_e2eb, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100f_e2ee, 3); mov(eax, memd_a32[ds, eax + 0x12]);     /* mov eax, [eax+0x12] */
            ii(0x100f_e2f1, 5); calld(Definitions.sys_display_draw_1, 0x6_91b2); /* call 0x101674a8 */
            ii(0x100f_e2f6, 4); movsx(eax, memw_a32[ss, ebp - 0x4]);    /* movsx eax, word [ebp-0x4] */
            ii(0x100f_e2fa, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x100f_e2fd, 6); pushd(memd_a32[ds, eax + 0x101b_b444]); /* push dword [eax+0x101bb444] */
            ii(0x100f_e303, 5); mov(eax, StringDefinitions.SBeginTurn); /* mov eax, 0x101a2a30 */
            ii(0x100f_e308, 1); pushd(eax);                             /* push eax */
            ii(0x100f_e309, 6); lea(eax, ebp - 0xd0);                   /* lea eax, [ebp-0xd0] */
            ii(0x100f_e30f, 1); pushd(eax);                             /* push eax */
            ii(0x100f_e310, 5); calld(Definitions.sys_sprintf, 0x6_7bec); /* call 0x10165f01 */
            ii(0x100f_e315, 3); add(esp, 0xc);                          /* add esp, 0xc */
            ii(0x100f_e318, 5); calld(0x100c_aa00, -0x3_391d);          /* call 0x100caa00 */
            ii(0x100f_e31d, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x100f_e322, 1); pushd(eax);                             /* push eax */
            ii(0x100f_e323, 5); mov(ecx, 0x1);                          /* mov ecx, 0x1 */
            ii(0x100f_e328, 5); mov(ebx, 0x1);                          /* mov ebx, 0x1 */
            ii(0x100f_e32d, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100f_e32f, 6); lea(eax, ebp - 0xd0);                   /* lea eax, [ebp-0xd0] */
            ii(0x100f_e335, 5); calld(0x1011_5d23, 0x1_79e9);           /* call 0x10115d23 */
            ii(0x100f_e33a, 3); mov(al, memb_a32[ss, ebp - 0x4]);       /* mov al, [ebp-0x4] */
            ii(0x100f_e33d, 5); mov(memb_a32[ds, 0x101c_37da], al);     /* mov [0x101c37da], al */
            ii(0x100f_e342, 4); movsx(eax, memw_a32[ss, ebp - 0x4]);    /* movsx eax, word [ebp-0x4] */
            ii(0x100f_e346, 5); calld(0x100f_3800, -0xab4b);            /* call 0x100f3800 */
            ii(0x100f_e34b, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100f_e34d, 1); popd(ebp);                              /* pop ebp */
            ii(0x100f_e34e, 1); popd(edi);                              /* pop edi */
            ii(0x100f_e34f, 1); popd(esi);                              /* pop esi */
            ii(0x100f_e350, 1); popd(edx);                              /* pop edx */
            ii(0x100f_e351, 1); popd(ecx);                              /* pop ecx */
            ii(0x100f_e352, 1); popd(ebx);                              /* pop ebx */
            ii(0x100f_e353, 1); retd(); return;                         /* ret */
        }
    }
}
