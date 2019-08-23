using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1012_8d78-892d722")]
        public void Method_1012_8d78()
        {
            ii(0x1012_8d78, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x1012_8d7d, 5); calld(Definitions.sys_check_available_stack_size, 0x3_cfd0); /* call 0x10165d52 */
            ii(0x1012_8d82, 1); pushd(ebx);                             /* push ebx */
            ii(0x1012_8d83, 1); pushd(ecx);                             /* push ecx */
            ii(0x1012_8d84, 1); pushd(esi);                             /* push esi */
            ii(0x1012_8d85, 1); pushd(edi);                             /* push edi */
            ii(0x1012_8d86, 1); pushd(ebp);                             /* push ebp */
            ii(0x1012_8d87, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1012_8d89, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x1012_8d8f, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1012_8d92, 3); mov(memd_a32[ss, ebp - 0x8], edx);      /* mov [ebp-0x8], edx */
            ii(0x1012_8d95, 5); mov(eax, 0x101c_819c);                  /* mov eax, 0x101c819c */
            ii(0x1012_8d9a, 5); calld(0x1007_6338, -0xb_2a67);          /* call 0x10076338 */
            ii(0x1012_8d9f, 3); lea(ebx, ebp - 0xc);                    /* lea ebx, [ebp-0xc] */
            ii(0x1012_8da2, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1012_8da4, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x1012_8da6, 5); calld(0x1007_64b8, -0xb_28f3);          /* call 0x100764b8 */
        l_0x1012_8dab:
            ii(0x1012_8dab, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1012_8dad, 3); lea(eax, ebp - 0xc);                    /* lea eax, [ebp-0xc] */
            ii(0x1012_8db0, 5); calld(0x1013_ad71, 0x1_1fbc);           /* call 0x1013ad71 */
            ii(0x1012_8db5, 2); test(al, al);                           /* test al, al */
            ii(0x1012_8db7, 6); if(jzd(0x1012_8e31, 0x74)) goto l_0x1012_8e31; /* jz 0x10128e31 */
            ii(0x1012_8dbd, 3); lea(eax, ebp - 0xc);                    /* lea eax, [ebp-0xc] */
            ii(0x1012_8dc0, 5); calld(0x1007_63a0, -0xb_2a25);          /* call 0x100763a0 */
            ii(0x1012_8dc5, 5); calld(0x1007_6204, -0xb_2bc6);          /* call 0x10076204 */
            ii(0x1012_8dca, 3); cmp(eax, memd_a32[ss, ebp - 0x8]);      /* cmp eax, [ebp-0x8] */
            ii(0x1012_8dcd, 2); if(jnzd(0x1012_8dde, 0xf)) goto l_0x1012_8dde; /* jnz 0x10128dde */
            ii(0x1012_8dcf, 3); lea(eax, ebp - 0xc);                    /* lea eax, [ebp-0xc] */
            ii(0x1012_8dd2, 5); calld(0x1007_63a0, -0xb_2a37);          /* call 0x100763a0 */
            ii(0x1012_8dd7, 5); cmp(memw_a32[ds, eax + 0x8], 0x28);     /* cmp word [eax+0x8], 0x28 */
            ii(0x1012_8ddc, 2); if(jzd(0x1012_8de0, 0x2)) goto l_0x1012_8de0; /* jz 0x10128de0 */
        l_0x1012_8dde:
            ii(0x1012_8dde, 2); jmpd(0x1012_8dee, 0xe); goto l_0x1012_8dee; /* jmp 0x10128dee */
        l_0x1012_8de0:
            ii(0x1012_8de0, 3); lea(eax, ebp - 0xc);                    /* lea eax, [ebp-0xc] */
            ii(0x1012_8de3, 5); calld(0x1007_63a0, -0xb_2a48);          /* call 0x100763a0 */
            ii(0x1012_8de8, 4); cmp(memb_a32[ds, eax + 0x3d], 0x8);     /* cmp byte [eax+0x3d], 0x8 */
            ii(0x1012_8dec, 2); if(jnzd(0x1012_8df0, 0x2)) goto l_0x1012_8df0; /* jnz 0x10128df0 */
        l_0x1012_8dee:
            ii(0x1012_8dee, 2); jmpd(0x1012_8dfe, 0xe); goto l_0x1012_8dfe; /* jmp 0x10128dfe */
        l_0x1012_8df0:
            ii(0x1012_8df0, 3); lea(eax, ebp - 0xc);                    /* lea eax, [ebp-0xc] */
            ii(0x1012_8df3, 5); calld(0x1007_63a0, -0xb_2a58);          /* call 0x100763a0 */
            ii(0x1012_8df8, 4); cmp(memb_a32[ds, eax + 0x3d], 0x1a);    /* cmp byte [eax+0x3d], 0x1a */
            ii(0x1012_8dfc, 2); if(jnzd(0x1012_8e00, 0x2)) goto l_0x1012_8e00; /* jnz 0x10128e00 */
        l_0x1012_8dfe:
            ii(0x1012_8dfe, 2); jmpd(0x1012_8e0e, 0xe); goto l_0x1012_8e0e; /* jmp 0x10128e0e */
        l_0x1012_8e00:
            ii(0x1012_8e00, 3); lea(eax, ebp - 0xc);                    /* lea eax, [ebp-0xc] */
            ii(0x1012_8e03, 5); calld(0x1007_63a0, -0xb_2a68);          /* call 0x100763a0 */
            ii(0x1012_8e08, 4); cmp(memb_a32[ds, eax + 0x3d], 0x10);    /* cmp byte [eax+0x3d], 0x10 */
            ii(0x1012_8e0c, 2); if(jnzd(0x1012_8e10, 0x2)) goto l_0x1012_8e10; /* jnz 0x10128e10 */
        l_0x1012_8e0e:
            ii(0x1012_8e0e, 2); jmpd(0x1012_8e24, 0x14); goto l_0x1012_8e24; /* jmp 0x10128e24 */
        l_0x1012_8e10:
            ii(0x1012_8e10, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x1012_8e12, 5); mov(edx, 0x6);                          /* mov edx, 0x6 */
            ii(0x1012_8e17, 3); lea(eax, ebp - 0xc);                    /* lea eax, [ebp-0xc] */
            ii(0x1012_8e1a, 5); calld(0x1007_6408, -0xb_2a17);          /* call 0x10076408 */
            ii(0x1012_8e1f, 5); calld(0x1016_3053, 0x3_a22f);           /* call 0x10163053 */
        l_0x1012_8e24:
            ii(0x1012_8e24, 3); lea(eax, ebp - 0xc);                    /* lea eax, [ebp-0xc] */
            ii(0x1012_8e27, 5); calld(0x1007_6bf8, -0xb_2234);          /* call 0x10076bf8 */
            ii(0x1012_8e2c, 5); jmpd(0x1012_8dab, -0x86); goto l_0x1012_8dab; /* jmp 0x10128dab */
        l_0x1012_8e31:
            ii(0x1012_8e31, 7); mov(memb_a32[ds, 0x101c_5c1c], 0xb);    /* mov byte [0x101c5c1c], 0xb */
            ii(0x1012_8e38, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1012_8e3b, 6); mov(memw_a32[ds, 0x101c_5c1d], ax);     /* mov [0x101c5c1d], ax */
            ii(0x1012_8e41, 5); mov(ebx, 0x101c_5c21);                  /* mov ebx, 0x101c5c21 */
            ii(0x1012_8e46, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1012_8e49, 5); calld(0x100e_0d64, -0x4_80ea);          /* call 0x100e0d64 */
            ii(0x1012_8e4e, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x1012_8e51, 4); movsx(eax, memw_a32[ss, ebp - 0x4]);    /* movsx eax, word [ebp-0x4] */
            ii(0x1012_8e55, 6); imul(eax, eax, 0x247);                  /* imul eax, eax, 0x247 */
            ii(0x1012_8e5b, 6); mov(eax, memd_a32[ds, eax + 0x101c_a562]); /* mov eax, [eax+0x101ca562] */
            ii(0x1012_8e61, 5); calld(0x100d_f561, -0x4_9905);          /* call 0x100df561 */
            ii(0x1012_8e66, 6); mov(memw_a32[ds, 0x101c_5c1f], ax);     /* mov [0x101c5c1f], ax */
            ii(0x1012_8e6c, 5); mov(eax, 0x4);                          /* mov eax, 0x4 */
            ii(0x1012_8e71, 5); calld(0x1012_5be9, -0x328d);            /* call 0x10125be9 */
            ii(0x1012_8e76, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1012_8e78, 3); lea(eax, ebp - 0xc);                    /* lea eax, [ebp-0xc] */
            ii(0x1012_8e7b, 5); calld(0x1007_5f6c, -0xb_2f14);          /* call 0x10075f6c */
            ii(0x1012_8e80, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1012_8e82, 1); popd(ebp);                              /* pop ebp */
            ii(0x1012_8e83, 1); popd(edi);                              /* pop edi */
            ii(0x1012_8e84, 1); popd(esi);                              /* pop esi */
            ii(0x1012_8e85, 1); popd(ecx);                              /* pop ecx */
            ii(0x1012_8e86, 1); popd(ebx);                              /* pop ebx */
            ii(0x1012_8e87, 1); retd();                                 /* ret */
        }
    }
}
