using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("817b0805-5d69-4cc4-a7e6-9969d316ad22")]
        public void Method_100d_e7d6()
        {
            ii(0x100d_e7d6, 5); pushd(0x2c);                            /* push 0x2c */
            ii(0x100d_e7db, 5); calld(Definitions.sys_check_available_stack_size, 0x87572); /* call 0x10165d52 */
            ii(0x100d_e7e0, 1); pushd(ebx);                             /* push ebx */
            ii(0x100d_e7e1, 1); pushd(ecx);                             /* push ecx */
            ii(0x100d_e7e2, 1); pushd(esi);                             /* push esi */
            ii(0x100d_e7e3, 1); pushd(edi);                             /* push edi */
            ii(0x100d_e7e4, 1); pushd(ebp);                             /* push ebp */
            ii(0x100d_e7e5, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100d_e7e7, 6); sub(esp, 0x14);                         /* sub esp, 0x14 */
            ii(0x100d_e7ed, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100d_e7f0, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x100d_e7f3, 4); movsx(eax, memw_a32[ss, ebp - 0x4]);    /* movsx eax, word [ebp-0x4] */
            ii(0x100d_e7f7, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100d_e7f9, 2); if(jnzd(0x100d_e810, 0x15)) goto l_0x100d_e810; /* jnz 0x100de810 */
            ii(0x100d_e7fb, 5); mov(edx, 0x8);                          /* mov edx, 0x8 */
            ii(0x100d_e800, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100d_e803, 6); mov(eax, memd_a32[ds, eax + 0x3df]);    /* mov eax, [eax+0x3df] */
            ii(0x100d_e809, 5); calld(0x100d_77b9, -0x7055);            /* call 0x100d77b9 */
            ii(0x100d_e80e, 2); jmpd(0x100d_e83e, 0x2e); goto l_0x100d_e83e; /* jmp 0x100de83e */
        l_0x100d_e810:
            ii(0x100d_e810, 4); movsx(eax, memw_a32[ss, ebp - 0x4]);    /* movsx eax, word [ebp-0x4] */
            ii(0x100d_e814, 3); cmp(eax, 0x1);                          /* cmp eax, 0x1 */
            ii(0x100d_e817, 2); if(jnzd(0x100d_e82e, 0x15)) goto l_0x100d_e82e; /* jnz 0x100de82e */
            ii(0x100d_e819, 5); mov(edx, 0x4);                          /* mov edx, 0x4 */
            ii(0x100d_e81e, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100d_e821, 6); mov(eax, memd_a32[ds, eax + 0x3df]);    /* mov eax, [eax+0x3df] */
            ii(0x100d_e827, 5); calld(0x100d_77b9, -0x7073);            /* call 0x100d77b9 */
            ii(0x100d_e82c, 2); jmpd(0x100d_e83e, 0x10); goto l_0x100d_e83e; /* jmp 0x100de83e */
        l_0x100d_e82e:
            ii(0x100d_e82e, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100d_e830, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100d_e833, 6); mov(eax, memd_a32[ds, eax + 0x3df]);    /* mov eax, [eax+0x3df] */
            ii(0x100d_e839, 5); calld(0x100d_77b9, -0x7085);            /* call 0x100d77b9 */
        l_0x100d_e83e:
            ii(0x100d_e83e, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100d_e841, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x100d_e844, 7); cmp(ax, memw_a32[ds, edx + 0x3e3]);     /* cmp ax, [edx+0x3e3] */
            ii(0x100d_e84b, 2); if(jged(0x100d_e866, 0x19)) goto l_0x100d_e866; /* jge 0x100de866 */
            ii(0x100d_e84d, 5); calld(0x100d_51c4, -0x968e);            /* call 0x100d51c4 */
            ii(0x100d_e852, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100d_e854, 2); mov(dl, al);                            /* mov dl, al */
            ii(0x100d_e856, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100d_e859, 6); mov(eax, memd_a32[ds, eax + 0x3d7]);    /* mov eax, [eax+0x3d7] */
            ii(0x100d_e85f, 5); calld(0x100c_fb06, -0xed5e);            /* call 0x100cfb06 */
            ii(0x100d_e864, 2); jmpd(0x100d_e886, 0x20); goto l_0x100d_e886; /* jmp 0x100de886 */
        l_0x100d_e866:
            ii(0x100d_e866, 5); calld(0x100d_51e4, -0x9687);            /* call 0x100d51e4 */
            ii(0x100d_e86b, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x100d_e86d, 2); mov(bl, al);                            /* mov bl, al */
            ii(0x100d_e86f, 5); calld(0x100d_5204, -0x9670);            /* call 0x100d5204 */
            ii(0x100d_e874, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100d_e876, 2); mov(dl, al);                            /* mov dl, al */
            ii(0x100d_e878, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100d_e87b, 6); mov(eax, memd_a32[ds, eax + 0x3d7]);    /* mov eax, [eax+0x3d7] */
            ii(0x100d_e881, 5); calld(0x100c_fa7c, -0xee0a);            /* call 0x100cfa7c */
        l_0x100d_e886:
            ii(0x100d_e886, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100d_e889, 6); mov(eax, memd_a32[ds, eax + 0x3bb]);    /* mov eax, [eax+0x3bb] */
            ii(0x100d_e88f, 5); calld(0x100d_0149, -0xe74b);            /* call 0x100d0149 */
            ii(0x100d_e894, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x100d_e897, 5); cmp(memw_a32[ss, ebp - 0x10], 0x40);    /* cmp word [ebp-0x10], 0x40 */
            ii(0x100d_e89c, 2); if(jnzd(0x100d_e8a7, 0x9)) goto l_0x100d_e8a7; /* jnz 0x100de8a7 */
            ii(0x100d_e89e, 7); mov(memd_a32[ss, ebp - 0xc], 0x222);    /* mov dword [ebp-0xc], 0x222 */
            ii(0x100d_e8a5, 2); jmpd(0x100d_e8be, 0x17); goto l_0x100d_e8be; /* jmp 0x100de8be */
        l_0x100d_e8a7:
            ii(0x100d_e8a7, 5); cmp(memw_a32[ss, ebp - 0x10], 0x3c);    /* cmp word [ebp-0x10], 0x3c */
            ii(0x100d_e8ac, 2); if(jnzd(0x100d_e8b7, 0x9)) goto l_0x100d_e8b7; /* jnz 0x100de8b7 */
            ii(0x100d_e8ae, 7); mov(memd_a32[ss, ebp - 0xc], 0x223);    /* mov dword [ebp-0xc], 0x223 */
            ii(0x100d_e8b5, 2); jmpd(0x100d_e8be, 0x7); goto l_0x100d_e8be; /* jmp 0x100de8be */
        l_0x100d_e8b7:
            ii(0x100d_e8b7, 7); mov(memd_a32[ss, ebp - 0xc], 0x221);    /* mov dword [ebp-0xc], 0x221 */
        l_0x100d_e8be:
            ii(0x100d_e8be, 5); cmp(memw_a32[ss, ebp - 0x10], 0x3c);    /* cmp word [ebp-0x10], 0x3c */
            ii(0x100d_e8c3, 2); if(jnzd(0x100d_e8d7, 0x12)) goto l_0x100d_e8d7; /* jnz 0x100de8d7 */
            ii(0x100d_e8c5, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100d_e8c7, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100d_e8ca, 6); mov(eax, memd_a32[ds, eax + 0x3df]);    /* mov eax, [eax+0x3df] */
            ii(0x100d_e8d0, 5); calld(0x100d_6f8b, -0x794a);            /* call 0x100d6f8b */
            ii(0x100d_e8d5, 2); jmpd(0x100d_e911, 0x3a); goto l_0x100d_e911; /* jmp 0x100de911 */
        l_0x100d_e8d7:
            ii(0x100d_e8d7, 4); movsx(eax, memw_a32[ss, ebp - 0x10]);   /* movsx eax, word [ebp-0x10] */
            ii(0x100d_e8db, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x100d_e8de, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x100d_e8e1, 6); add(edx, 0x1cf);                        /* add edx, 0x1cf */
            ii(0x100d_e8e7, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x100d_e8e9, 5); calld(0x1007_6730, -0x681be);           /* call 0x10076730 */
            ii(0x100d_e8ee, 3); mov(edx, memd_a32[ds, eax + 0x17]);     /* mov edx, [eax+0x17] */
            ii(0x100d_e8f1, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x100d_e8f4, 5); mov(ebx, 0x5);                          /* mov ebx, 0x5 */
            ii(0x100d_e8f9, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x100d_e8fb, 3); sar(edx, 0x1f);                         /* sar edx, 0x1f */
            ii(0x100d_e8fe, 2); idiv(ebx);                              /* idiv ebx */
            ii(0x100d_e900, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x100d_e903, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100d_e906, 6); mov(eax, memd_a32[ds, eax + 0x3df]);    /* mov eax, [eax+0x3df] */
            ii(0x100d_e90c, 5); calld(0x100d_6f8b, -0x7986);            /* call 0x100d6f8b */
        l_0x100d_e911:
            ii(0x100d_e911, 4); movsx(edx, memw_a32[ss, ebp - 0xc]);    /* movsx edx, word [ebp-0xc] */
            ii(0x100d_e915, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100d_e918, 6); mov(eax, memd_a32[ds, eax + 0x3df]);    /* mov eax, [eax+0x3df] */
            ii(0x100d_e91e, 5); calld(0x100e_0adc, 0x21b9);             /* call 0x100e0adc */
            ii(0x100d_e923, 4); movsx(edx, memw_a32[ss, ebp - 0x4]);    /* movsx edx, word [ebp-0x4] */
            ii(0x100d_e927, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100d_e92a, 5); add(eax, 0x3b7);                        /* add eax, 0x3b7 */
            ii(0x100d_e92f, 5); calld(0x100e_08bc, 0x1f88);             /* call 0x100e08bc */
            ii(0x100d_e934, 3); movsx(edx, memw_a32[ds, eax]);          /* movsx edx, word [eax] */
            ii(0x100d_e937, 5); mov(ebx, 0x5);                          /* mov ebx, 0x5 */
            ii(0x100d_e93c, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x100d_e93e, 3); sar(edx, 0x1f);                         /* sar edx, 0x1f */
            ii(0x100d_e941, 2); idiv(ebx);                              /* idiv ebx */
            ii(0x100d_e943, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x100d_e946, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100d_e949, 6); mov(eax, memd_a32[ds, eax + 0x3df]);    /* mov eax, [eax+0x3df] */
            ii(0x100d_e94f, 5); calld(0x100d_6f2d, -0x7a27);            /* call 0x100d6f2d */
            ii(0x100d_e954, 4); movsx(edx, memw_a32[ss, ebp - 0x10]);   /* movsx edx, word [ebp-0x10] */
            ii(0x100d_e958, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100d_e95b, 5); calld(0x100d_a88b, -0x40d5);            /* call 0x100da88b */
            ii(0x100d_e960, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100d_e963, 3); mov(memd_a32[ss, ebp - 0x14], eax);     /* mov [ebp-0x14], eax */
            ii(0x100d_e966, 3); mov(eax, memd_a32[ss, ebp - 0x14]);     /* mov eax, [ebp-0x14] */
            ii(0x100d_e969, 3); mov(ebx, memd_a32[ds, eax + 0x13]);     /* mov ebx, [eax+0x13] */
            ii(0x100d_e96c, 4); movsx(edx, memw_a32[ss, ebp - 0x10]);   /* movsx edx, word [ebp-0x10] */
            ii(0x100d_e970, 3); mov(eax, memd_a32[ss, ebp - 0x14]);     /* mov eax, [ebp-0x14] */
            ii(0x100d_e973, 3); calld_abs(memd_a32[ds, ebx + 0x18]);    /* call dword [ebx+0x18] */
            ii(0x100d_e976, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100d_e978, 1); popd(ebp);                              /* pop ebp */
            ii(0x100d_e979, 1); popd(edi);                              /* pop edi */
            ii(0x100d_e97a, 1); popd(esi);                              /* pop esi */
            ii(0x100d_e97b, 1); popd(ecx);                              /* pop ecx */
            ii(0x100d_e97c, 1); popd(ebx);                              /* pop ebx */
            ii(0x100d_e97d, 1); retd(); return;                         /* ret */
        }
    }
}
