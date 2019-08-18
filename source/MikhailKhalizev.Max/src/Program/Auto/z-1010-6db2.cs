using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1010_6db2-62e4e6a9")]
        public void Method_1010_6db2()
        {
            ii(0x1010_6db2, 5); pushd(0x28);                            /* push 0x28 */
            ii(0x1010_6db7, 5); calld(Definitions.sys_check_available_stack_size, 0x5_ef96); /* call 0x10165d52 */
            ii(0x1010_6dbc, 1); pushd(ebx);                             /* push ebx */
            ii(0x1010_6dbd, 1); pushd(ecx);                             /* push ecx */
            ii(0x1010_6dbe, 1); pushd(edx);                             /* push edx */
            ii(0x1010_6dbf, 1); pushd(esi);                             /* push esi */
            ii(0x1010_6dc0, 1); pushd(edi);                             /* push edi */
            ii(0x1010_6dc1, 1); pushd(ebp);                             /* push ebp */
            ii(0x1010_6dc2, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1010_6dc4, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x1010_6dca, 5); calld(0x100e_8923, -0x1_e4ac);          /* call 0x100e8923 */
            ii(0x1010_6dcf, 2); test(al, al);                           /* test al, al */
            ii(0x1010_6dd1, 2); if(jzd(0x1010_6ddd, 0xa)) goto l_0x1010_6ddd; /* jz 0x10106ddd */
            ii(0x1010_6dd3, 5); mov(eax, 0x5);                          /* mov eax, 0x5 */
            ii(0x1010_6dd8, 5); calld(0x100e_f3a0, -0x1_7a3d);          /* call 0x100ef3a0 */
        l_0x1010_6ddd:
            ii(0x1010_6ddd, 5); calld(0x1013_4b5f, 0x2_dd7d);           /* call 0x10134b5f */
            ii(0x1010_6de2, 3); mov(memb_a32[ss, ebp - 0x4], al);       /* mov [ebp-0x4], al */
            ii(0x1010_6de5, 4); movsx(eax, memb_a32[ss, ebp - 0x4]);    /* movsx eax, byte [ebp-0x4] */
            ii(0x1010_6de9, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1010_6deb, 2); if(jzd(0x1010_6df6, 0x9)) goto l_0x1010_6df6; /* jz 0x10106df6 */
            ii(0x1010_6ded, 4); movsx(eax, memb_a32[ss, ebp - 0x4]);    /* movsx eax, byte [ebp-0x4] */
            ii(0x1010_6df1, 5); calld(0x100e_f3a0, -0x1_7a56);          /* call 0x100ef3a0 */
        l_0x1010_6df6:
            ii(0x1010_6df6, 5); mov(eax, 0x101c_39c8);                  /* mov eax, 0x101c39c8 */
            ii(0x1010_6dfb, 5); calld(0x1010_5db3, -0x104d);            /* call 0x10105db3 */
            ii(0x1010_6e00, 5); mov(eax, 0x101c_3c4c);                  /* mov eax, 0x101c3c4c */
            ii(0x1010_6e05, 5); calld(0x1010_656c, -0x89e);             /* call 0x1010656c */
            ii(0x1010_6e0a, 5); calld(0x1010_6bb0, -0x25f);             /* call 0x10106bb0 */
            ii(0x1010_6e0f, 5); cmp(eax, 0xcb_2000);                    /* cmp eax, 0xcb2000 */
            ii(0x1010_6e14, 2); if(jged(0x1010_6e1c, 0x6)) goto l_0x1010_6e1c; /* jge 0x10106e1c */
            ii(0x1010_6e16, 4); mov(memb_a32[ss, ebp - 0x8], 0x1);      /* mov byte [ebp-0x8], 0x1 */
            ii(0x1010_6e1a, 2); jmpd(0x1010_6e20, 0x4); goto l_0x1010_6e20; /* jmp 0x10106e20 */
        l_0x1010_6e1c:
            ii(0x1010_6e1c, 4); mov(memb_a32[ss, ebp - 0x8], 0);        /* mov byte [ebp-0x8], 0x0 */
        l_0x1010_6e20:
            ii(0x1010_6e20, 3); mov(al, memb_a32[ss, ebp - 0x8]);       /* mov al, [ebp-0x8] */
            ii(0x1010_6e23, 5); mov(memb_a32[ds, 0x101c_814a], al);     /* mov [0x101c814a], al */
            ii(0x1010_6e28, 7); cmp(memb_a32[ds, 0x101c_814a], 0);      /* cmp byte [0x101c814a], 0x0 */
            ii(0x1010_6e2f, 2); if(jnzd(0x1010_6e3a, 0x9)) goto l_0x1010_6e3a; /* jnz 0x10106e3a */
            ii(0x1010_6e31, 7); mov(memd_a32[ss, ebp - 0xc], 0x1);      /* mov dword [ebp-0xc], 0x1 */
            ii(0x1010_6e38, 2); jmpd(0x1010_6e41, 0x7); goto l_0x1010_6e41; /* jmp 0x10106e41 */
        l_0x1010_6e3a:
            ii(0x1010_6e3a, 7); mov(memd_a32[ss, ebp - 0xc], 0);        /* mov dword [ebp-0xc], 0x0 */
        l_0x1010_6e41:
            ii(0x1010_6e41, 3); mov(edx, memd_a32[ss, ebp - 0xc]);      /* mov edx, [ebp-0xc] */
            ii(0x1010_6e44, 5); mov(eax, 0x40);                         /* mov eax, 0x40 */
            ii(0x1010_6e49, 5); calld(0x100c_aafc, -0x3_c352);          /* call 0x100caafc */
            ii(0x1010_6e4e, 5); calld(0x1014_847b, 0x4_1628);           /* call 0x1014847b */
            ii(0x1010_6e53, 5); mov(eax, 0x101c_7278);                  /* mov eax, 0x101c7278 */
            ii(0x1010_6e58, 5); calld(0x1013_caa4, 0x3_5c47);           /* call 0x1013caa4 */
            ii(0x1010_6e5d, 5); calld(0x1014_837e, 0x4_151c);           /* call 0x1014837e */
            ii(0x1010_6e62, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1010_6e64, 5); mov(eax, 0xffff_ffff);                  /* mov eax, 0xffffffff */
            ii(0x1010_6e69, 5); calld(/* sys */ 0x1016_b59c, 0x6_472e); /* call 0x1016b59c */
            ii(0x1010_6e6e, 5); mov(edx, 0x100f_1ab9);                  /* mov edx, 0x100f1ab9 */
            ii(0x1010_6e73, 5); mov(eax, 0x12e);                        /* mov eax, 0x12e */
            ii(0x1010_6e78, 5); calld(/* sys */ 0x1016_b7a0, 0x6_4923); /* call 0x1016b7a0 */
            ii(0x1010_6e7d, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1010_6e7f, 1); popd(ebp);                              /* pop ebp */
            ii(0x1010_6e80, 1); popd(edi);                              /* pop edi */
            ii(0x1010_6e81, 1); popd(esi);                              /* pop esi */
            ii(0x1010_6e82, 1); popd(edx);                              /* pop edx */
            ii(0x1010_6e83, 1); popd(ecx);                              /* pop ecx */
            ii(0x1010_6e84, 1); popd(ebx);                              /* pop ebx */
            ii(0x1010_6e85, 1); retd(); return;                         /* ret */
        }
    }
}
