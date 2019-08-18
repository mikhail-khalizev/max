using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("b031e483-a0d8-4923-a684-dc5df66c9548")]
        public void /* sys */ Method_1017_b570()
        {
            ii(0x1017_b570, 1); pushd(ebp);                             /* push ebp */
            ii(0x1017_b571, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1017_b573, 1); pushd(edi);                             /* push edi */
            ii(0x1017_b574, 3); mov(eax, memd_a32[ss, ebp + 0x8]);      /* mov eax, [ebp+0x8] */
            ii(0x1017_b577, 4); cmp(ax, 0xfffb);                        /* cmp ax, 0xfffb */
            ii(0x1017_b57b, 2); if(jbd(0x1017_b5a4, 0x27)) goto l_0x1017_b5a4; /* jb 0x1017b5a4 */
            ii(0x1017_b57d, 6); if(jbed(0x1017_b6bb, 0x138)) goto l_0x1017_b6bb; /* jbe 0x1017b6bb */
            ii(0x1017_b583, 4); cmp(ax, 0xfffd);                        /* cmp ax, 0xfffd */
            ii(0x1017_b587, 6); if(jbd(0x1017_b662, 0xd5)) goto l_0x1017_b662; /* jb 0x1017b662 */
            ii(0x1017_b58d, 6); if(jbed(0x1017_b609, 0x76)) goto l_0x1017_b609; /* jbe 0x1017b609 */
            ii(0x1017_b593, 4); cmp(ax, 0xfffe);                        /* cmp ax, 0xfffe */
            ii(0x1017_b597, 2); if(jbed(0x1017_b5eb, 0x52)) goto l_0x1017_b5eb; /* jbe 0x1017b5eb */
            ii(0x1017_b599, 4); cmp(ax, 0xffff);                        /* cmp ax, 0xffff */
            ii(0x1017_b59d, 2); if(jzd(0x1017_b5ca, 0x2b)) goto l_0x1017_b5ca; /* jz 0x1017b5ca */
            ii(0x1017_b59f, 5); jmpd(0x1017_b790, 0x1ec); goto l_0x1017_b790; /* jmp 0x1017b790 */
        l_0x1017_b5a4:
            ii(0x1017_b5a4, 4); cmp(ax, 0x10d);                         /* cmp ax, 0x10d */
            ii(0x1017_b5a8, 2); if(jbd(0x1017_b5bf, 0x15)) goto l_0x1017_b5bf; /* jb 0x1017b5bf */
            ii(0x1017_b5aa, 6); if(jbed(0x1017_b76d, 0x1bd)) goto l_0x1017_b76d; /* jbe 0x1017b76d */
            ii(0x1017_b5b0, 4); cmp(ax, 0xfffa);                        /* cmp ax, 0xfffa */
            ii(0x1017_b5b4, 6); if(jzd(0x1017_b714, 0x15a)) goto l_0x1017_b714; /* jz 0x1017b714 */
            ii(0x1017_b5ba, 5); jmpd(0x1017_b790, 0x1d1); goto l_0x1017_b790; /* jmp 0x1017b790 */
        l_0x1017_b5bf:
            ii(0x1017_b5bf, 4); cmp(ax, 0x13);                          /* cmp ax, 0x13 */
            ii(0x1017_b5c3, 2); if(jzd(0x1017_b5e4, 0x1f)) goto l_0x1017_b5e4; /* jz 0x1017b5e4 */
            ii(0x1017_b5c5, 5); jmpd(0x1017_b790, 0x1c6); goto l_0x1017_b790; /* jmp 0x1017b790 */
        l_0x1017_b5ca:
            ii(0x1017_b5ca, 5); mov(edx, 0x1);                          /* mov edx, 0x1 */
            ii(0x1017_b5cf, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x1017_b5d1, 6); mov(memd_a32[ds, 0x101b_e448], edx);    /* mov [0x101be448], edx */
            ii(0x1017_b5d7, 6); mov(memd_a32[ds, 0x101b_e44c], ebx);    /* mov [0x101be44c], ebx */
            ii(0x1017_b5dd, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x1017_b5df, 5); jmpd(0x1017_b796, 0x1b2); goto l_0x1017_b796; /* jmp 0x1017b796 */
        l_0x1017_b5e4:
            ii(0x1017_b5e4, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1017_b5e6, 5); calld(/* sys */ 0x1017_ac90, -0x95b);   /* call 0x1017ac90 */
        l_0x1017_b5eb:
            ii(0x1017_b5eb, 5); mov(eax, 0x140);                        /* mov eax, 0x140 */
            ii(0x1017_b5f0, 5); mov(edx, 0xc8);                         /* mov edx, 0xc8 */
            ii(0x1017_b5f5, 2); mov(ebx, eax);                          /* mov ebx, eax */
            ii(0x1017_b5f7, 2); mov(ecx, edx);                          /* mov ecx, edx */
            ii(0x1017_b5f9, 5); calld(/* sys */ 0x1017_a590, -0x106e);  /* call 0x1017a590 */
            ii(0x1017_b5fe, 5); mov(eax, 0x1);                          /* mov eax, 0x1 */
            ii(0x1017_b603, 3); lea(esp, ebp - 0x4);                    /* lea esp, [ebp-0x4] */
            ii(0x1017_b606, 1); popd(edi);                              /* pop edi */
            ii(0x1017_b607, 1); popd(ebp);                              /* pop ebp */
            ii(0x1017_b608, 1); retd(); return;                         /* ret */
        l_0x1017_b609:
            ii(0x1017_b609, 2); pushd(0x1);                             /* push 0x1 */
            ii(0x1017_b60b, 2); pushd(0);                               /* push 0x0 */
            ii(0x1017_b60d, 5); pushd(0x15e);                           /* push 0x15e */
            ii(0x1017_b612, 5); pushd(0x140);                           /* push 0x140 */
            ii(0x1017_b617, 5); pushd(0x17c);                           /* push 0x17c */
            ii(0x1017_b61c, 2); pushd(0x4d);                            /* push 0x4d */
            ii(0x1017_b61e, 2); pushd(0);                               /* push 0x0 */
            ii(0x1017_b620, 2); pushd(0x64);                            /* push 0x64 */
            ii(0x1017_b622, 5); pushd(0xf8);                            /* push 0xf8 */
            ii(0x1017_b627, 5); pushd(0x108);                           /* push 0x108 */
            ii(0x1017_b62c, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1017_b62e, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1017_b630, 5); pushd(0xf8);                            /* push 0xf8 */
            ii(0x1017_b635, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x1017_b637, 2); xor(ecx, ecx);                          /* xor ecx, ecx */
            ii(0x1017_b639, 5); calld(/* sys */ 0x1017_b0d0, -0x56e);   /* call 0x1017b0d0 */
            ii(0x1017_b63e, 5); mov(eax, 0xf8);                         /* mov eax, 0xf8 */
            ii(0x1017_b643, 5); mov(edx, 0x108);                        /* mov edx, 0x108 */
            ii(0x1017_b648, 5); mov(ebx, 0x140);                        /* mov ebx, 0x140 */
            ii(0x1017_b64d, 5); mov(ecx, 0x15e);                        /* mov ecx, 0x15e */
            ii(0x1017_b652, 5); calld(/* sys */ 0x1017_a590, -0x10c7);  /* call 0x1017a590 */
            ii(0x1017_b657, 5); mov(eax, 0x1);                          /* mov eax, 0x1 */
            ii(0x1017_b65c, 3); lea(esp, ebp - 0x4);                    /* lea esp, [ebp-0x4] */
            ii(0x1017_b65f, 1); popd(edi);                              /* pop edi */
            ii(0x1017_b660, 1); popd(ebp);                              /* pop ebp */
            ii(0x1017_b661, 1); retd(); return;                         /* ret */
        l_0x1017_b662:
            ii(0x1017_b662, 2); pushd(0x1);                             /* push 0x1 */
            ii(0x1017_b664, 2); pushd(0);                               /* push 0x0 */
            ii(0x1017_b666, 5); pushd(0x1e0);                           /* push 0x1e0 */
            ii(0x1017_b66b, 5); pushd(0x168);                           /* push 0x168 */
            ii(0x1017_b670, 5); pushd(0x190);                           /* push 0x190 */
            ii(0x1017_b675, 2); pushd(0x4d);                            /* push 0x4d */
            ii(0x1017_b677, 2); pushd(0);                               /* push 0x0 */
            ii(0x1017_b679, 2); pushd(0);                               /* push 0x0 */
            ii(0x1017_b67b, 5); pushd(0xe0);                            /* push 0xe0 */
            ii(0x1017_b680, 5); pushd(0x120);                           /* push 0x120 */
            ii(0x1017_b685, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1017_b687, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1017_b689, 5); pushd(0xe0);                            /* push 0xe0 */
            ii(0x1017_b68e, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x1017_b690, 2); xor(ecx, ecx);                          /* xor ecx, ecx */
            ii(0x1017_b692, 5); calld(/* sys */ 0x1017_b0d0, -0x5c7);   /* call 0x1017b0d0 */
            ii(0x1017_b697, 5); mov(eax, 0xe0);                         /* mov eax, 0xe0 */
            ii(0x1017_b69c, 5); mov(edx, 0x120);                        /* mov edx, 0x120 */
            ii(0x1017_b6a1, 5); mov(ebx, 0x168);                        /* mov ebx, 0x168 */
            ii(0x1017_b6a6, 5); mov(ecx, 0x1e0);                        /* mov ecx, 0x1e0 */
            ii(0x1017_b6ab, 5); calld(/* sys */ 0x1017_a590, -0x1120);  /* call 0x1017a590 */
            ii(0x1017_b6b0, 5); mov(eax, 0x1);                          /* mov eax, 0x1 */
            ii(0x1017_b6b5, 3); lea(esp, ebp - 0x4);                    /* lea esp, [ebp-0x4] */
            ii(0x1017_b6b8, 1); popd(edi);                              /* pop edi */
            ii(0x1017_b6b9, 1); popd(ebp);                              /* pop ebp */
            ii(0x1017_b6ba, 1); retd(); return;                         /* ret */
        l_0x1017_b6bb:
            ii(0x1017_b6bb, 2); pushd(0x1);                             /* push 0x1 */
            ii(0x1017_b6bd, 2); pushd(0);                               /* push 0x0 */
            ii(0x1017_b6bf, 5); pushd(0xf0);                            /* push 0xf0 */
            ii(0x1017_b6c4, 5); pushd(0x140);                           /* push 0x140 */
            ii(0x1017_b6c9, 5); pushd(0x1e0);                           /* push 0x1e0 */
            ii(0x1017_b6ce, 2); pushd(0x52);                            /* push 0x52 */
            ii(0x1017_b6d0, 2); pushd(0);                               /* push 0x0 */
            ii(0x1017_b6d2, 2); pushd(0x64);                            /* push 0x64 */
            ii(0x1017_b6d4, 5); pushd(0x120);                           /* push 0x120 */
            ii(0x1017_b6d9, 5); pushd(0x1c0);                           /* push 0x1c0 */
            ii(0x1017_b6de, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1017_b6e0, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1017_b6e2, 5); pushd(0x120);                           /* push 0x120 */
            ii(0x1017_b6e7, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x1017_b6e9, 2); xor(ecx, ecx);                          /* xor ecx, ecx */
            ii(0x1017_b6eb, 5); calld(/* sys */ 0x1017_b0d0, -0x620);   /* call 0x1017b0d0 */
            ii(0x1017_b6f0, 5); mov(eax, 0x120);                        /* mov eax, 0x120 */
            ii(0x1017_b6f5, 5); mov(edx, 0xe0);                         /* mov edx, 0xe0 */
            ii(0x1017_b6fa, 5); mov(ebx, 0x140);                        /* mov ebx, 0x140 */
            ii(0x1017_b6ff, 5); mov(ecx, 0xf0);                         /* mov ecx, 0xf0 */
            ii(0x1017_b704, 5); calld(/* sys */ 0x1017_a590, -0x1179);  /* call 0x1017a590 */
            ii(0x1017_b709, 5); mov(eax, 0x1);                          /* mov eax, 0x1 */
            ii(0x1017_b70e, 3); lea(esp, ebp - 0x4);                    /* lea esp, [ebp-0x4] */
            ii(0x1017_b711, 1); popd(edi);                              /* pop edi */
            ii(0x1017_b712, 1); popd(ebp);                              /* pop ebp */
            ii(0x1017_b713, 1); retd(); return;                         /* ret */
        l_0x1017_b714:
            ii(0x1017_b714, 5); mov(eax, 0x101);                        /* mov eax, 0x101 */
            ii(0x1017_b719, 5); calld(/* sys */ 0x1017_b2b0, -0x46e);   /* call 0x1017b2b0 */
            ii(0x1017_b71e, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1017_b720, 2); if(jzd(0x1017_b796, 0x74)) goto l_0x1017_b796; /* jz 0x1017b796 */
            ii(0x1017_b722, 2); pushd(0x1);                             /* push 0x1 */
            ii(0x1017_b724, 2); pushd(0);                               /* push 0x0 */
            ii(0x1017_b726, 5); pushd(0x1e0);                           /* push 0x1e0 */
            ii(0x1017_b72b, 5); mov(ecx, 0x140);                        /* mov ecx, 0x140 */
            ii(0x1017_b730, 1); pushd(ecx);                             /* push ecx */
            ii(0x1017_b731, 5); pushd(0x1e0);                           /* push 0x1e0 */
            ii(0x1017_b736, 2); pushd(0x52);                            /* push 0x52 */
            ii(0x1017_b738, 2); pushd(0);                               /* push 0x0 */
            ii(0x1017_b73a, 2); pushd(0x64);                            /* push 0x64 */
            ii(0x1017_b73c, 6); mov(edi, memd_a32[ds, Definitions.video_bytes_per_line]); /* mov edi, [0x10209c98] */
            ii(0x1017_b742, 1); pushd(edi);                             /* push edi */
            ii(0x1017_b743, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1017_b745, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1017_b747, 5); pushd(0x1e0);                           /* push 0x1e0 */
            ii(0x1017_b74c, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x1017_b74e, 6); mov(memd_a32[ds, 0x1020_9cb4], ecx);    /* mov [0x10209cb4], ecx */
            ii(0x1017_b754, 1); pushd(ecx);                             /* push ecx */
            ii(0x1017_b755, 6); mov(memd_a32[ds, 0x1020_9cb8], ecx);    /* mov [0x10209cb8], ecx */
            ii(0x1017_b75b, 2); xor(ecx, ecx);                          /* xor ecx, ecx */
            ii(0x1017_b75d, 5); calld(/* sys */ 0x1017_b0d0, -0x692);   /* call 0x1017b0d0 */
            ii(0x1017_b762, 5); mov(eax, 0x1);                          /* mov eax, 0x1 */
            ii(0x1017_b767, 3); lea(esp, ebp - 0x4);                    /* lea esp, [ebp-0x4] */
            ii(0x1017_b76a, 1); popd(edi);                              /* pop edi */
            ii(0x1017_b76b, 1); popd(ebp);                              /* pop ebp */
            ii(0x1017_b76c, 1); retd(); return;                         /* ret */
        l_0x1017_b76d:
            ii(0x1017_b76d, 1); cwde();                                 /* cwde */
            ii(0x1017_b76e, 5); calld(/* sys */ 0x1017_b2b0, -0x4c3);   /* call 0x1017b2b0 */
            ii(0x1017_b773, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1017_b775, 2); if(jnzd(0x1017_b785, 0xe)) goto l_0x1017_b785; /* jnz 0x1017b785 */
            ii(0x1017_b777, 5); mov(eax, 0x110);                        /* mov eax, 0x110 */
            ii(0x1017_b77c, 5); calld(/* sys */ 0x1017_b2b0, -0x4d1);   /* call 0x1017b2b0 */
            ii(0x1017_b781, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1017_b783, 2); if(jzd(0x1017_b796, 0x11)) goto l_0x1017_b796; /* jz 0x1017b796 */
        l_0x1017_b785:
            ii(0x1017_b785, 5); mov(eax, 0x1);                          /* mov eax, 0x1 */
            ii(0x1017_b78a, 3); lea(esp, ebp - 0x4);                    /* lea esp, [ebp-0x4] */
            ii(0x1017_b78d, 1); popd(edi);                              /* pop edi */
            ii(0x1017_b78e, 1); popd(ebp);                              /* pop ebp */
            ii(0x1017_b78f, 1); retd(); return;                         /* ret */
        l_0x1017_b790:
            ii(0x1017_b790, 1); cwde();                                 /* cwde */
            ii(0x1017_b791, 5); calld(/* sys */ 0x1017_b2b0, -0x4e6);   /* call 0x1017b2b0 */
        l_0x1017_b796:
            ii(0x1017_b796, 3); lea(esp, ebp - 0x4);                    /* lea esp, [ebp-0x4] */
            ii(0x1017_b799, 1); popd(edi);                              /* pop edi */
            ii(0x1017_b79a, 1); popd(ebp);                              /* pop ebp */
            ii(0x1017_b79b, 1); retd(); return;                         /* ret */
        }
    }
}
