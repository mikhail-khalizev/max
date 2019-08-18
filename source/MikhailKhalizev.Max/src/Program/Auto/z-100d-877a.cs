using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("086de0e5-b318-4192-aad5-5ea220398d9a")]
        public void Method_100d_877a()
        {
            ii(0x100d_877a, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x100d_877f, 5); calld(Definitions.sys_check_available_stack_size, 0x8_d5ce); /* call 0x10165d52 */
            ii(0x100d_8784, 1); pushd(ebx);                             /* push ebx */
            ii(0x100d_8785, 1); pushd(ecx);                             /* push ecx */
            ii(0x100d_8786, 1); pushd(edx);                             /* push edx */
            ii(0x100d_8787, 1); pushd(esi);                             /* push esi */
            ii(0x100d_8788, 1); pushd(edi);                             /* push edi */
            ii(0x100d_8789, 1); pushd(ebp);                             /* push ebp */
            ii(0x100d_878a, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100d_878c, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x100d_8792, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x100d_8795, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100d_8798, 3); mov(eax, memd_a32[ds, eax + 0xd]);      /* mov eax, [eax+0xd] */
            ii(0x100d_879b, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100d_879e, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100d_87a0, 2); if(jnzd(0x100d_87af, 0xd)) goto l_0x100d_87af; /* jnz 0x100d87af */
            ii(0x100d_87a2, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100d_87a5, 5); calld(0x100d_8727, -0x83);              /* call 0x100d8727 */
            ii(0x100d_87aa, 5); jmpd(0x100d_88fa, 0x14b); goto l_0x100d_88fa; /* jmp 0x100d88fa */
        l_0x100d_87af:
            ii(0x100d_87af, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100d_87b2, 4); cmp(memb_a32[ds, eax + 0xe], 0x9);      /* cmp byte [eax+0xe], 0x9 */
            ii(0x100d_87b6, 6); if(jnzd(0x100d_885d, 0xa1)) goto l_0x100d_885d; /* jnz 0x100d885d */
            ii(0x100d_87bc, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100d_87bf, 5); calld(0x100d_86f5, -0xcf);              /* call 0x100d86f5 */
            ii(0x100d_87c4, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100d_87c6, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100d_87c9, 2); mov(eax, memd_a32[ds, eax]);            /* mov eax, [eax] */
            ii(0x100d_87cb, 3); cmp(dx, memw_a32[ds, eax]);             /* cmp dx, [eax] */
            ii(0x100d_87ce, 2); if(jgd(0x100d_87de, 0xe)) goto l_0x100d_87de; /* jg 0x100d87de */
            ii(0x100d_87d0, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100d_87d3, 3); mov(eax, memd_a32[ds, eax + 0x15]);     /* mov eax, [eax+0x15] */
            ii(0x100d_87d6, 3); movsx(eax, memw_a32[ds, eax]);          /* movsx eax, word [eax] */
            ii(0x100d_87d9, 3); cmp(eax, 0x1);                          /* cmp eax, 0x1 */
            ii(0x100d_87dc, 2); if(jgd(0x100d_87e0, 0x2)) goto l_0x100d_87e0; /* jg 0x100d87e0 */
        l_0x100d_87de:
            ii(0x100d_87de, 2); jmpd(0x100d_87ff, 0x1f); goto l_0x100d_87ff; /* jmp 0x100d87ff */
        l_0x100d_87e0:
            ii(0x100d_87e0, 5); calld(0x100d_51e4, -0x3601);            /* call 0x100d51e4 */
            ii(0x100d_87e5, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x100d_87e7, 2); mov(bl, al);                            /* mov bl, al */
            ii(0x100d_87e9, 5); calld(0x100d_5204, -0x35ea);            /* call 0x100d5204 */
            ii(0x100d_87ee, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100d_87f0, 2); mov(dl, al);                            /* mov dl, al */
            ii(0x100d_87f2, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100d_87f5, 3); mov(eax, memd_a32[ds, eax + 0xa]);      /* mov eax, [eax+0xa] */
            ii(0x100d_87f8, 5); calld(0x100c_fa7c, -0x8d81);            /* call 0x100cfa7c */
            ii(0x100d_87fd, 2); jmpd(0x100d_8813, 0x14); goto l_0x100d_8813; /* jmp 0x100d8813 */
        l_0x100d_87ff:
            ii(0x100d_87ff, 5); calld(0x100d_51c4, -0x3640);            /* call 0x100d51c4 */
            ii(0x100d_8804, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100d_8806, 2); mov(dl, al);                            /* mov dl, al */
            ii(0x100d_8808, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100d_880b, 3); mov(eax, memd_a32[ds, eax + 0xa]);      /* mov eax, [eax+0xa] */
            ii(0x100d_880e, 5); calld(0x100c_fb06, -0x8d0d);            /* call 0x100cfb06 */
        l_0x100d_8813:
            ii(0x100d_8813, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100d_8816, 3); mov(edx, memd_a32[ds, eax + 0x15]);     /* mov edx, [eax+0x15] */
            ii(0x100d_8819, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100d_881c, 4); mov(ax, memw_a32[ds, eax + 0x11]);      /* mov ax, [eax+0x11] */
            ii(0x100d_8820, 3); cmp(ax, memw_a32[ds, edx]);             /* cmp ax, [edx] */
            ii(0x100d_8823, 2); if(jled(0x100d_8844, 0x1f)) goto l_0x100d_8844; /* jle 0x100d8844 */
            ii(0x100d_8825, 5); calld(0x100d_51e4, -0x3646);            /* call 0x100d51e4 */
            ii(0x100d_882a, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x100d_882c, 2); mov(bl, al);                            /* mov bl, al */
            ii(0x100d_882e, 5); calld(0x100d_5204, -0x362f);            /* call 0x100d5204 */
            ii(0x100d_8833, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100d_8835, 2); mov(dl, al);                            /* mov dl, al */
            ii(0x100d_8837, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100d_883a, 3); mov(eax, memd_a32[ds, eax + 0x6]);      /* mov eax, [eax+0x6] */
            ii(0x100d_883d, 5); calld(0x100c_fa7c, -0x8dc6);            /* call 0x100cfa7c */
            ii(0x100d_8842, 2); jmpd(0x100d_8858, 0x14); goto l_0x100d_8858; /* jmp 0x100d8858 */
        l_0x100d_8844:
            ii(0x100d_8844, 5); calld(0x100d_51c4, -0x3685);            /* call 0x100d51c4 */
            ii(0x100d_8849, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100d_884b, 2); mov(dl, al);                            /* mov dl, al */
            ii(0x100d_884d, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100d_8850, 3); mov(eax, memd_a32[ds, eax + 0x6]);      /* mov eax, [eax+0x6] */
            ii(0x100d_8853, 5); calld(0x100c_fb06, -0x8d52);            /* call 0x100cfb06 */
        l_0x100d_8858:
            ii(0x100d_8858, 5); jmpd(0x100d_88fa, 0x9d); goto l_0x100d_88fa; /* jmp 0x100d88fa */
        l_0x100d_885d:
            ii(0x100d_885d, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100d_8860, 5); calld(0x100d_86f5, -0x170);             /* call 0x100d86f5 */
            ii(0x100d_8865, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100d_8868, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100d_886b, 2); mov(edx, memd_a32[ds, eax]);            /* mov edx, [eax] */
            ii(0x100d_886d, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100d_8870, 3); cmp(ax, memw_a32[ds, edx]);             /* cmp ax, [edx] */
            ii(0x100d_8873, 2); if(jgd(0x100d_8880, 0xb)) goto l_0x100d_8880; /* jg 0x100d8880 */
            ii(0x100d_8875, 4); movsx(eax, memw_a32[ss, ebp - 0x8]);    /* movsx eax, word [ebp-0x8] */
            ii(0x100d_8879, 5); cmp(eax, 0x320);                        /* cmp eax, 0x320 */
            ii(0x100d_887e, 2); if(jld(0x100d_8882, 0x2)) goto l_0x100d_8882; /* jl 0x100d8882 */
        l_0x100d_8880:
            ii(0x100d_8880, 2); jmpd(0x100d_88a1, 0x1f); goto l_0x100d_88a1; /* jmp 0x100d88a1 */
        l_0x100d_8882:
            ii(0x100d_8882, 5); calld(0x100d_51e4, -0x36a3);            /* call 0x100d51e4 */
            ii(0x100d_8887, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x100d_8889, 2); mov(bl, al);                            /* mov bl, al */
            ii(0x100d_888b, 5); calld(0x100d_5204, -0x368c);            /* call 0x100d5204 */
            ii(0x100d_8890, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100d_8892, 2); mov(dl, al);                            /* mov dl, al */
            ii(0x100d_8894, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100d_8897, 3); mov(eax, memd_a32[ds, eax + 0x6]);      /* mov eax, [eax+0x6] */
            ii(0x100d_889a, 5); calld(0x100c_fa7c, -0x8e23);            /* call 0x100cfa7c */
            ii(0x100d_889f, 2); jmpd(0x100d_88b5, 0x14); goto l_0x100d_88b5; /* jmp 0x100d88b5 */
        l_0x100d_88a1:
            ii(0x100d_88a1, 5); calld(0x100d_51c4, -0x36e2);            /* call 0x100d51c4 */
            ii(0x100d_88a6, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100d_88a8, 2); mov(dl, al);                            /* mov dl, al */
            ii(0x100d_88aa, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100d_88ad, 3); mov(eax, memd_a32[ds, eax + 0x6]);      /* mov eax, [eax+0x6] */
            ii(0x100d_88b0, 5); calld(0x100c_fb06, -0x8daf);            /* call 0x100cfb06 */
        l_0x100d_88b5:
            ii(0x100d_88b5, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100d_88b8, 3); mov(edx, memd_a32[ds, eax + 0x15]);     /* mov edx, [eax+0x15] */
            ii(0x100d_88bb, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100d_88be, 4); mov(ax, memw_a32[ds, eax + 0x11]);      /* mov ax, [eax+0x11] */
            ii(0x100d_88c2, 3); cmp(ax, memw_a32[ds, edx]);             /* cmp ax, [edx] */
            ii(0x100d_88c5, 2); if(jged(0x100d_88e6, 0x1f)) goto l_0x100d_88e6; /* jge 0x100d88e6 */
            ii(0x100d_88c7, 5); calld(0x100d_51e4, -0x36e8);            /* call 0x100d51e4 */
            ii(0x100d_88cc, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x100d_88ce, 2); mov(bl, al);                            /* mov bl, al */
            ii(0x100d_88d0, 5); calld(0x100d_5204, -0x36d1);            /* call 0x100d5204 */
            ii(0x100d_88d5, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100d_88d7, 2); mov(dl, al);                            /* mov dl, al */
            ii(0x100d_88d9, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100d_88dc, 3); mov(eax, memd_a32[ds, eax + 0xa]);      /* mov eax, [eax+0xa] */
            ii(0x100d_88df, 5); calld(0x100c_fa7c, -0x8e68);            /* call 0x100cfa7c */
            ii(0x100d_88e4, 2); jmpd(0x100d_88fa, 0x14); goto l_0x100d_88fa; /* jmp 0x100d88fa */
        l_0x100d_88e6:
            ii(0x100d_88e6, 5); calld(0x100d_51c4, -0x3727);            /* call 0x100d51c4 */
            ii(0x100d_88eb, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100d_88ed, 2); mov(dl, al);                            /* mov dl, al */
            ii(0x100d_88ef, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100d_88f2, 3); mov(eax, memd_a32[ds, eax + 0xa]);      /* mov eax, [eax+0xa] */
            ii(0x100d_88f5, 5); calld(0x100c_fb06, -0x8df4);            /* call 0x100cfb06 */
        l_0x100d_88fa:
            ii(0x100d_88fa, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100d_88fc, 1); popd(ebp);                              /* pop ebp */
            ii(0x100d_88fd, 1); popd(edi);                              /* pop edi */
            ii(0x100d_88fe, 1); popd(esi);                              /* pop esi */
            ii(0x100d_88ff, 1); popd(edx);                              /* pop edx */
            ii(0x100d_8900, 1); popd(ecx);                              /* pop ecx */
            ii(0x100d_8901, 1); popd(ebx);                              /* pop ebx */
            ii(0x100d_8902, 1); retd(); return;                         /* ret */
        }
    }
}
