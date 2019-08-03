using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("fa47ecf2-b45f-4050-b3cb-89eb03c17841")]
        public void Method_1013_679b()
        {
            ii(0x1013_679b, 5); pushd(0x7c);                            /* push 0x7c */
            ii(0x1013_67a0, 5); calld(Definitions.sys_check_available_stack_size, 0x2f5ad); /* call 0x10165d52 */
            ii(0x1013_67a5, 1); pushd(ebx);                             /* push ebx */
            ii(0x1013_67a6, 1); pushd(ecx);                             /* push ecx */
            ii(0x1013_67a7, 1); pushd(esi);                             /* push esi */
            ii(0x1013_67a8, 1); pushd(edi);                             /* push edi */
            ii(0x1013_67a9, 1); pushd(ebp);                             /* push ebp */
            ii(0x1013_67aa, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1013_67ac, 6); sub(esp, 0x4c);                         /* sub esp, 0x4c */
            ii(0x1013_67b2, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1013_67b5, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x1013_67b8, 5); mov(ebx, 0x26);                         /* mov ebx, 0x26 */
            ii(0x1013_67bd, 5); mov(edx, 0x6e5);                        /* mov edx, 0x6e5 */
            ii(0x1013_67c2, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1013_67c5, 5); calld(0x100d_68a3, -0x5ff27);           /* call 0x100d68a3 */
            ii(0x1013_67ca, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1013_67cd, 3); lea(eax, ebp - 0x8);                    /* lea eax, [ebp-0x8] */
            ii(0x1013_67d0, 3); mov(memd_a32[ss, ebp - 0x28], eax);     /* mov [ebp-0x28], eax */
            ii(0x1013_67d3, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1013_67d6, 7); mov(memd_a32[ds, eax + 0x13], 0x101b_6e7c); /* mov dword [eax+0x13], 0x101b6e7c */
            ii(0x1013_67dd, 5); mov(eax, 0x5);                          /* mov eax, 0x5 */
            ii(0x1013_67e2, 5); calld(/* sys */ 0x1016_a24c, 0x33a65);  /* call 0x1016a24c */
            ii(0x1013_67e7, 5); calld(0x100d_6124, -0x606c8);           /* call 0x100d6124 */
            ii(0x1013_67ec, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1013_67ee, 2); mov(dl, al);                            /* mov dl, al */
            ii(0x1013_67f0, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1013_67f3, 5); calld(0x100d_6adf, -0x5fd19);           /* call 0x100d6adf */
            ii(0x1013_67f8, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x1013_67fb, 3); add(edx, 0x17);                         /* add edx, 0x17 */
            ii(0x1013_67fe, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1013_6801, 5); calld(0x100d_6a11, -0x5fdf5);           /* call 0x100d6a11 */
            ii(0x1013_6806, 5); mov(edx, 0x101c_3678);                  /* mov edx, 0x101c3678 */
            ii(0x1013_680b, 3); lea(eax, ebp - 0xc);                    /* lea eax, [ebp-0xc] */
            ii(0x1013_680e, 5); calld(0x100d_4d78, -0x61a9b);           /* call 0x100d4d78 */
            ii(0x1013_6813, 1); pushd(eax);                             /* push eax */
            ii(0x1013_6814, 5); mov(eax, 0x1);                          /* mov eax, 0x1 */
            ii(0x1013_6819, 1); pushd(eax);                             /* push eax */
            ii(0x1013_681a, 5); mov(eax, 0x1);                          /* mov eax, 0x1 */
            ii(0x1013_681f, 1); pushd(eax);                             /* push eax */
            ii(0x1013_6820, 5); mov(eax, 0x1e);                         /* mov eax, 0x1e */
            ii(0x1013_6825, 1); pushd(eax);                             /* push eax */
            ii(0x1013_6826, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1013_6829, 3); mov(eax, memd_a32[ds, eax + 0x25]);     /* mov eax, [eax+0x25] */
            ii(0x1013_682c, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1013_682f, 1); pushd(eax);                             /* push eax */
            ii(0x1013_6830, 5); mov(ecx, 0x8c);                         /* mov ecx, 0x8c */
            ii(0x1013_6835, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x1013_6837, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x1013_683a, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1013_683d, 3); add(eax, 0x17);                         /* add eax, 0x17 */
            ii(0x1013_6840, 5); calld(0x100e_ab9d, -0x4bca8);           /* call 0x100eab9d */
            ii(0x1013_6845, 5); mov(eax, 0x2f);                         /* mov eax, 0x2f */
            ii(0x1013_684a, 5); calld(Definitions.sys_new, 0x2f5b1);    /* call 0x10165e00 */
            ii(0x1013_684f, 3); mov(memd_a32[ss, ebp - 0x1c], eax);     /* mov [ebp-0x1c], eax */
            ii(0x1013_6852, 3); mov(eax, memd_a32[ss, ebp - 0x1c]);     /* mov eax, [ebp-0x1c] */
            ii(0x1013_6855, 3); mov(memd_a32[ss, ebp - 0x20], eax);     /* mov [ebp-0x20], eax */
            ii(0x1013_6858, 4); cmp(memd_a32[ss, ebp - 0x20], 0);       /* cmp dword [ebp-0x20], 0x0 */
            ii(0x1013_685c, 2); if(jzd(0x1013_68ba, 0x5c)) goto l_0x1013_68ba; /* jz 0x101368ba */
            ii(0x1013_685e, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1013_6860, 1); pushd(eax);                             /* push eax */
            ii(0x1013_6861, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1013_6863, 1); pushd(eax);                             /* push eax */
            ii(0x1013_6864, 2); pushd(0);                               /* push 0x0 */
            ii(0x1013_6866, 2); pushd(0);                               /* push 0x0 */
            ii(0x1013_6868, 2); pushd(0);                               /* push 0x0 */
            ii(0x1013_686a, 5); mov(eax, 0x21e);                        /* mov eax, 0x21e */
            ii(0x1013_686f, 1); pushd(eax);                             /* push eax */
            ii(0x1013_6870, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1013_6872, 1); pushd(eax);                             /* push eax */
            ii(0x1013_6873, 2); xor(ecx, ecx);                          /* xor ecx, ecx */
            ii(0x1013_6875, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x1013_6877, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1013_6879, 3); lea(eax, ebp - 0x38);                   /* lea eax, [ebp-0x38] */
            ii(0x1013_687c, 5); calld(0x1008_b148, -0xab739);           /* call 0x1008b148 */
            ii(0x1013_6881, 2); mov(esi, eax);                          /* mov esi, eax */
            ii(0x1013_6883, 5); mov(eax, 0xc0);                         /* mov eax, 0xc0 */
            ii(0x1013_6888, 1); pushd(eax);                             /* push eax */
            ii(0x1013_6889, 5); mov(ecx, 0xab);                         /* mov ecx, 0xab */
            ii(0x1013_688e, 5); mov(ebx, 0xaf);                         /* mov ebx, 0xaf */
            ii(0x1013_6893, 5); mov(edx, 0xe);                          /* mov edx, 0xe */
            ii(0x1013_6898, 3); lea(eax, ebp - 0x48);                   /* lea eax, [ebp-0x48] */
            ii(0x1013_689b, 5); calld(0x1008_b148, -0xab758);           /* call 0x1008b148 */
            ii(0x1013_68a0, 2); mov(ebx, eax);                          /* mov ebx, eax */
            ii(0x1013_68a2, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x1013_68a5, 3); mov(eax, memd_a32[ss, ebp - 0x1c]);     /* mov eax, [ebp-0x1c] */
            ii(0x1013_68a8, 2); mov(ecx, esi);                          /* mov ecx, esi */
            ii(0x1013_68aa, 5); calld(0x100d_7706, -0x5f1a9);           /* call 0x100d7706 */
            ii(0x1013_68af, 3); mov(memd_a32[ss, ebp - 0x24], eax);     /* mov [ebp-0x24], eax */
            ii(0x1013_68b2, 3); mov(eax, memd_a32[ss, ebp - 0x24]);     /* mov eax, [ebp-0x24] */
            ii(0x1013_68b5, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x1013_68b8, 2); jmpd(0x1013_68c0, 0x6); goto l_0x1013_68c0; /* jmp 0x101368c0 */
        l_0x1013_68ba:
            ii(0x1013_68ba, 3); mov(eax, memd_a32[ss, ebp - 0x20]);     /* mov eax, [ebp-0x20] */
            ii(0x1013_68bd, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
        l_0x1013_68c0:
            ii(0x1013_68c0, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1013_68c3, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x1013_68c6, 3); mov(memd_a32[ds, edx + 0x31], eax);     /* mov [edx+0x31], eax */
            ii(0x1013_68c9, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1013_68cc, 3); mov(eax, memd_a32[ds, eax + 0x31]);     /* mov eax, [eax+0x31] */
            ii(0x1013_68cf, 3); mov(memd_a32[ss, ebp - 0x18], eax);     /* mov [ebp-0x18], eax */
            ii(0x1013_68d2, 3); mov(eax, memd_a32[ss, ebp - 0x18]);     /* mov eax, [ebp-0x18] */
            ii(0x1013_68d5, 3); mov(edx, memd_a32[ds, eax + 0x27]);     /* mov edx, [eax+0x27] */
            ii(0x1013_68d8, 3); mov(eax, memd_a32[ss, ebp - 0x18]);     /* mov eax, [ebp-0x18] */
            ii(0x1013_68db, 3); calld_abs(memd_a32[ds, edx + 0x4]);     /* call dword [edx+0x4] */
            ii(0x1013_68de, 5); mov(edx, 0x64);                         /* mov edx, 0x64 */
            ii(0x1013_68e3, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1013_68e6, 3); mov(eax, memd_a32[ds, eax + 0x31]);     /* mov eax, [eax+0x31] */
            ii(0x1013_68e9, 5); calld(0x100d_6f8b, -0x5f963);           /* call 0x100d6f8b */
            ii(0x1013_68ee, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1013_68f0, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1013_68f3, 3); mov(eax, memd_a32[ds, eax + 0x31]);     /* mov eax, [eax+0x31] */
            ii(0x1013_68f6, 5); calld(0x100d_6f2d, -0x5f9ce);           /* call 0x100d6f2d */
            ii(0x1013_68fb, 5); mov(edx, 0x224);                        /* mov edx, 0x224 */
            ii(0x1013_6900, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1013_6903, 3); mov(eax, memd_a32[ds, eax + 0x31]);     /* mov eax, [eax+0x31] */
            ii(0x1013_6906, 5); calld(0x100e_0adc, -0x55e2f);           /* call 0x100e0adc */
            ii(0x1013_690b, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1013_690e, 3); mov(eax, memd_a32[ds, eax + 0x31]);     /* mov eax, [eax+0x31] */
            ii(0x1013_6911, 3); mov(memd_a32[ss, ebp - 0x14], eax);     /* mov [ebp-0x14], eax */
            ii(0x1013_6914, 3); mov(eax, memd_a32[ss, ebp - 0x14]);     /* mov eax, [ebp-0x14] */
            ii(0x1013_6917, 3); mov(edx, memd_a32[ds, eax + 0x27]);     /* mov edx, [eax+0x27] */
            ii(0x1013_691a, 3); mov(eax, memd_a32[ss, ebp - 0x14]);     /* mov eax, [ebp-0x14] */
            ii(0x1013_691d, 3); calld_abs(memd_a32[ds, edx + 0x8]);     /* call dword [edx+0x8] */
            ii(0x1013_6920, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x1013_6923, 3); add(edx, 0x17);                         /* add edx, 0x17 */
            ii(0x1013_6926, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1013_6929, 3); mov(eax, memd_a32[ds, eax + 0x29]);     /* mov eax, [eax+0x29] */
            ii(0x1013_692c, 5); calld(Definitions.sys_display_draw_1, 0x30b77); /* call 0x101674a8 */
            ii(0x1013_6931, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1013_6934, 3); mov(memd_a32[ss, ebp - 0x4c], eax);     /* mov [ebp-0x4c], eax */
            ii(0x1013_6937, 3); mov(eax, memd_a32[ss, ebp - 0x4c]);     /* mov eax, [ebp-0x4c] */
            ii(0x1013_693a, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1013_693c, 1); popd(ebp);                              /* pop ebp */
            ii(0x1013_693d, 1); popd(edi);                              /* pop edi */
            ii(0x1013_693e, 1); popd(esi);                              /* pop esi */
            ii(0x1013_693f, 1); popd(ecx);                              /* pop ecx */
            ii(0x1013_6940, 1); popd(ebx);                              /* pop ebx */
            ii(0x1013_6941, 1); retd(); return;                         /* ret */
        }
    }
}