using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1010_d407-4247f8d4")]
        public void Method_1010_d407()
        {
            ii(0x1010_d407, 5); push(0x64);                             /* push 0x64 */
            ii(0x1010_d40c, 5); call(Definitions.sys_check_available_stack_size, 0x5_8941); /* call 0x10165d52 */
            ii(0x1010_d411, 1); push(ebx);                              /* push ebx */
            ii(0x1010_d412, 1); push(ecx);                              /* push ecx */
            ii(0x1010_d413, 1); push(esi);                              /* push esi */
            ii(0x1010_d414, 1); push(edi);                              /* push edi */
            ii(0x1010_d415, 1); push(ebp);                              /* push ebp */
            ii(0x1010_d416, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1010_d418, 6); sub(esp, 0x3c);                         /* sub esp, 0x3c */
            ii(0x1010_d41e, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x1010_d421, 3); mov(memb[ss, ebp - 4], dl);             /* mov [ebp-0x4], dl */
            ii(0x1010_d424, 4); movsx(eax, memb[ss, ebp - 4]);          /* movsx eax, byte [ebp-0x4] */
            ii(0x1010_d428, 3); imul(edx, eax, 0x18);                   /* imul edx, eax, 0x18 */
            ii(0x1010_d42b, 5); mov(eax, 0x101b_9830);                  /* mov eax, 0x101b9830 */
            ii(0x1010_d430, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1010_d432, 3); mov(memd[ss, ebp - 12], eax);           /* mov [ebp-0xc], eax */
            ii(0x1010_d435, 5); mov(eax, 1);                            /* mov eax, 0x1 */
            ii(0x1010_d43a, 5); call(/* sys */ 0x1016_a24c, 0x5_ce0d);  /* call 0x1016a24c */
            ii(0x1010_d43f, 3); mov(eax, memd[ss, ebp - 12]);           /* mov eax, [ebp-0xc] */
            ii(0x1010_d442, 5); cmp(memw[ds, eax + 8], -1 /* 0xff */);  /* cmp word [eax+0x8], 0xffff */
            ii(0x1010_d447, 6); if(jnz(0x1010_d4c4, 0x77)) goto l_0x1010_d4c4; /* jnz 0x1010d4c4 */
            ii(0x1010_d44d, 5); mov(eax, 0x38);                         /* mov eax, 0x38 */
            ii(0x1010_d452, 5); call(Definitions.sys_new, 0x5_89a9);    /* call 0x10165e00 */
            ii(0x1010_d457, 3); mov(memd[ss, ebp - 16], eax);           /* mov [ebp-0x10], eax */
            ii(0x1010_d45a, 3); mov(eax, memd[ss, ebp - 16]);           /* mov eax, [ebp-0x10] */
            ii(0x1010_d45d, 3); mov(memd[ss, ebp - 20], eax);           /* mov [ebp-0x14], eax */
            ii(0x1010_d460, 4); cmp(memd[ss, ebp - 20], 0);             /* cmp dword [ebp-0x14], 0x0 */
            ii(0x1010_d464, 2); if(jz(0x1010_d4a7, 0x41)) goto l_0x1010_d4a7; /* jz 0x1010d4a7 */
            ii(0x1010_d466, 3); mov(eax, memd[ss, ebp - 12]);           /* mov eax, [ebp-0xc] */
            ii(0x1010_d469, 4); mov(ax, memw[ds, eax + 6]);             /* mov ax, [eax+0x6] */
            ii(0x1010_d46d, 3); mov(edx, memd[ss, ebp - 12]);           /* mov edx, [ebp-0xc] */
            ii(0x1010_d470, 4); sub(ax, memw[ds, edx + 2]);             /* sub ax, [edx+0x2] */
            ii(0x1010_d474, 1); cwde();                                 /* cwde */
            ii(0x1010_d475, 1); push(eax);                              /* push eax */
            ii(0x1010_d476, 3); mov(eax, memd[ss, ebp - 12]);           /* mov eax, [ebp-0xc] */
            ii(0x1010_d479, 4); mov(ax, memw[ds, eax + 4]);             /* mov ax, [eax+0x4] */
            ii(0x1010_d47d, 3); mov(edx, memd[ss, ebp - 12]);           /* mov edx, [ebp-0xc] */
            ii(0x1010_d480, 3); sub(ax, memw[ds, edx]);                 /* sub ax, [edx] */
            ii(0x1010_d483, 3); movsx(ecx, ax);                         /* movsx ecx, ax */
            ii(0x1010_d486, 3); mov(eax, memd[ss, ebp - 12]);           /* mov eax, [ebp-0xc] */
            ii(0x1010_d489, 2); mov(ebx, memd[ds, eax]);                /* mov ebx, [eax] */
            ii(0x1010_d48b, 3); sar(ebx, 0x10);                         /* sar ebx, 0x10 */
            ii(0x1010_d48e, 3); mov(eax, memd[ss, ebp - 12]);           /* mov eax, [ebp-0xc] */
            ii(0x1010_d491, 3); movsx(edx, memw[ds, eax]);              /* movsx edx, word [eax] */
            ii(0x1010_d494, 3); mov(eax, memd[ss, ebp - 16]);           /* mov eax, [ebp-0x10] */
            ii(0x1010_d497, 5); call(0x100c_e39d, -0x3_f0ff);           /* call 0x100ce39d */
            ii(0x1010_d49c, 3); mov(memd[ss, ebp - 24], eax);           /* mov [ebp-0x18], eax */
            ii(0x1010_d49f, 3); mov(eax, memd[ss, ebp - 24]);           /* mov eax, [ebp-0x18] */
            ii(0x1010_d4a2, 3); mov(memd[ss, ebp - 28], eax);           /* mov [ebp-0x1c], eax */
            ii(0x1010_d4a5, 2); jmp(0x1010_d4ad, 6); goto l_0x1010_d4ad; /* jmp 0x1010d4ad */
        l_0x1010_d4a7:
            ii(0x1010_d4a7, 3); mov(eax, memd[ss, ebp - 20]);           /* mov eax, [ebp-0x14] */
            ii(0x1010_d4aa, 3); mov(memd[ss, ebp - 28], eax);           /* mov [ebp-0x1c], eax */
        l_0x1010_d4ad:
            ii(0x1010_d4ad, 4); movsx(eax, memb[ss, ebp - 4]);          /* movsx eax, byte [ebp-0x4] */
            ii(0x1010_d4b1, 3); shl(eax, 2);                            /* shl eax, 0x2 */
            ii(0x1010_d4b4, 3); mov(edx, memd[ss, ebp - 8]);            /* mov edx, [ebp-0x8] */
            ii(0x1010_d4b7, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x1010_d4b9, 3); mov(eax, memd[ss, ebp - 28]);           /* mov eax, [ebp-0x1c] */
            ii(0x1010_d4bc, 3); mov(memd[ds, edx + 32], eax);           /* mov [edx+0x20], eax */
            ii(0x1010_d4bf, 5); jmp(0x1010_d57e, 0xba); goto l_0x1010_d57e; /* jmp 0x1010d57e */
        l_0x1010_d4c4:
            ii(0x1010_d4c4, 5); mov(eax, 0x38);                         /* mov eax, 0x38 */
            ii(0x1010_d4c9, 5); call(Definitions.sys_new, 0x5_8932);    /* call 0x10165e00 */
            ii(0x1010_d4ce, 3); mov(memd[ss, ebp - 32], eax);           /* mov [ebp-0x20], eax */
            ii(0x1010_d4d1, 3); mov(eax, memd[ss, ebp - 32]);           /* mov eax, [ebp-0x20] */
            ii(0x1010_d4d4, 3); mov(memd[ss, ebp - 36], eax);           /* mov [ebp-0x24], eax */
            ii(0x1010_d4d7, 4); cmp(memd[ss, ebp - 36], 0);             /* cmp dword [ebp-0x24], 0x0 */
            ii(0x1010_d4db, 2); if(jz(0x1010_d513, 0x36)) goto l_0x1010_d513; /* jz 0x1010d513 */
            ii(0x1010_d4dd, 3); mov(eax, memd[ss, ebp - 12]);           /* mov eax, [ebp-0xc] */
            ii(0x1010_d4e0, 2); mov(eax, memd[ds, eax]);                /* mov eax, [eax] */
            ii(0x1010_d4e2, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1010_d4e5, 1); push(eax);                              /* push eax */
            ii(0x1010_d4e6, 3); mov(eax, memd[ss, ebp - 12]);           /* mov eax, [ebp-0xc] */
            ii(0x1010_d4e9, 3); movsx(ecx, memw[ds, eax]);              /* movsx ecx, word [eax] */
            ii(0x1010_d4ec, 3); mov(eax, memd[ss, ebp - 12]);           /* mov eax, [ebp-0xc] */
            ii(0x1010_d4ef, 4); mov(ax, memw[ds, eax + 8]);             /* mov ax, [eax+0x8] */
            ii(0x1010_d4f3, 1); inc(eax);                               /* inc eax */
            ii(0x1010_d4f4, 3); movsx(ebx, ax);                         /* movsx ebx, ax */
            ii(0x1010_d4f7, 3); mov(eax, memd[ss, ebp - 12]);           /* mov eax, [ebp-0xc] */
            ii(0x1010_d4fa, 3); mov(edx, memd[ds, eax + 6]);            /* mov edx, [eax+0x6] */
            ii(0x1010_d4fd, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1010_d500, 3); mov(eax, memd[ss, ebp - 32]);           /* mov eax, [ebp-0x20] */
            ii(0x1010_d503, 5); call(Definitions.my_ctor_c17, -0x3_f0f9); /* call 0x100ce40f */
            ii(0x1010_d508, 3); mov(memd[ss, ebp - 40], eax);           /* mov [ebp-0x28], eax */
            ii(0x1010_d50b, 3); mov(eax, memd[ss, ebp - 40]);           /* mov eax, [ebp-0x28] */
            ii(0x1010_d50e, 3); mov(memd[ss, ebp - 44], eax);           /* mov [ebp-0x2c], eax */
            ii(0x1010_d511, 2); jmp(0x1010_d519, 6); goto l_0x1010_d519; /* jmp 0x1010d519 */
        l_0x1010_d513:
            ii(0x1010_d513, 3); mov(eax, memd[ss, ebp - 36]);           /* mov eax, [ebp-0x24] */
            ii(0x1010_d516, 3); mov(memd[ss, ebp - 44], eax);           /* mov [ebp-0x2c], eax */
        l_0x1010_d519:
            ii(0x1010_d519, 4); movsx(edx, memb[ss, ebp - 4]);          /* movsx edx, byte [ebp-0x4] */
            ii(0x1010_d51d, 3); shl(edx, 2);                            /* shl edx, 0x2 */
            ii(0x1010_d520, 3); add(edx, memd[ss, ebp - 8]);            /* add edx, [ebp-0x8] */
            ii(0x1010_d523, 3); mov(eax, memd[ss, ebp - 44]);           /* mov eax, [ebp-0x2c] */
            ii(0x1010_d526, 3); mov(memd[ds, edx + 32], eax);           /* mov [edx+0x20], eax */
            ii(0x1010_d529, 3); mov(eax, memd[ss, ebp - 12]);           /* mov eax, [ebp-0xc] */
            ii(0x1010_d52c, 4); cmp(memd[ds, eax + 10], 0);             /* cmp dword [eax+0xa], 0x0 */
            ii(0x1010_d530, 2); if(jz(0x1010_d57e, 0x4c)) goto l_0x1010_d57e; /* jz 0x1010d57e */
            ii(0x1010_d532, 3); lea(eax, memd[ss, ebp - 48]);           /* lea eax, [ebp-0x30] */
            ii(0x1010_d535, 5); call(0x100d_5224, -0x3_8316);           /* call 0x100d5224 */
            ii(0x1010_d53a, 1); push(eax);                              /* push eax */
            ii(0x1010_d53b, 3); lea(eax, memd[ss, ebp - 52]);           /* lea eax, [ebp-0x34] */
            ii(0x1010_d53e, 5); call(0x100d_5250, -0x3_82f3);           /* call 0x100d5250 */
            ii(0x1010_d543, 1); push(eax);                              /* push eax */
            ii(0x1010_d544, 3); lea(eax, memd[ss, ebp - 56]);           /* lea eax, [ebp-0x38] */
            ii(0x1010_d547, 5); call(0x100d_527c, -0x3_82d0);           /* call 0x100d527c */
            ii(0x1010_d54c, 1); push(eax);                              /* push eax */
            ii(0x1010_d54d, 3); lea(eax, memd[ss, ebp - 60]);           /* lea eax, [ebp-0x3c] */
            ii(0x1010_d550, 5); call(0x100d_52a8, -0x3_82ad);           /* call 0x100d52a8 */
            ii(0x1010_d555, 1); push(eax);                              /* push eax */
            ii(0x1010_d556, 5); call(0x100d_52d4, -0x3_8287);           /* call 0x100d52d4 */
            ii(0x1010_d55b, 3); movsx(ecx, ax);                         /* movsx ecx, ax */
            ii(0x1010_d55e, 5); call(0x100d_52f8, -0x3_826b);           /* call 0x100d52f8 */
            ii(0x1010_d563, 3); movsx(ebx, ax);                         /* movsx ebx, ax */
            ii(0x1010_d566, 3); mov(eax, memd[ss, ebp - 12]);           /* mov eax, [ebp-0xc] */
            ii(0x1010_d569, 3); mov(edx, memd[ds, eax + 10]);           /* mov edx, [eax+0xa] */
            ii(0x1010_d56c, 4); movsx(eax, memb[ss, ebp - 4]);          /* movsx eax, byte [ebp-0x4] */
            ii(0x1010_d570, 3); shl(eax, 2);                            /* shl eax, 0x2 */
            ii(0x1010_d573, 3); add(eax, memd[ss, ebp - 8]);            /* add eax, [ebp-0x8] */
            ii(0x1010_d576, 3); mov(eax, memd[ds, eax + 32]);           /* mov eax, [eax+0x20] */
            ii(0x1010_d579, 5); call(0x100c_ef64, -0x3_e61a);           /* call 0x100cef64 */
        l_0x1010_d57e:
            ii(0x1010_d57e, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1010_d580, 4); movsx(eax, memb[ss, ebp - 4]);          /* movsx eax, byte [ebp-0x4] */
            ii(0x1010_d584, 3); shl(eax, 2);                            /* shl eax, 0x2 */
            ii(0x1010_d587, 3); add(eax, memd[ss, ebp - 8]);            /* add eax, [ebp-0x8] */
            ii(0x1010_d58a, 3); mov(eax, memd[ds, eax + 32]);           /* mov eax, [eax+0x20] */
            ii(0x1010_d58d, 5); call(0x100d_5194, -0x3_83fe);           /* call 0x100d5194 */
            ii(0x1010_d592, 4); movsx(edx, memb[ss, ebp - 4]);          /* movsx edx, byte [ebp-0x4] */
            ii(0x1010_d596, 6); add(edx, 0x3e8);                        /* add edx, 0x3e8 */
            ii(0x1010_d59c, 4); movsx(eax, memb[ss, ebp - 4]);          /* movsx eax, byte [ebp-0x4] */
            ii(0x1010_d5a0, 3); shl(eax, 2);                            /* shl eax, 0x2 */
            ii(0x1010_d5a3, 3); add(eax, memd[ss, ebp - 8]);            /* add eax, [ebp-0x8] */
            ii(0x1010_d5a6, 3); mov(eax, memd[ds, eax + 32]);           /* mov eax, [eax+0x20] */
            ii(0x1010_d5a9, 5); call(0x100d_5134, -0x3_847a);           /* call 0x100d5134 */
            ii(0x1010_d5ae, 4); movsx(eax, memb[ss, ebp - 4]);          /* movsx eax, byte [ebp-0x4] */
            ii(0x1010_d5b2, 6); lea(edx, memd[ds, eax + 28672]);        /* lea edx, [eax+0x7000] */
            ii(0x1010_d5b8, 4); movsx(eax, memb[ss, ebp - 4]);          /* movsx eax, byte [ebp-0x4] */
            ii(0x1010_d5bc, 3); shl(eax, 2);                            /* shl eax, 0x2 */
            ii(0x1010_d5bf, 3); add(eax, memd[ss, ebp - 8]);            /* add eax, [ebp-0x8] */
            ii(0x1010_d5c2, 3); mov(eax, memd[ds, eax + 32]);           /* mov eax, [eax+0x20] */
            ii(0x1010_d5c5, 5); call(0x100d_5164, -0x3_8466);           /* call 0x100d5164 */
            ii(0x1010_d5ca, 3); mov(edx, memd[ss, ebp - 12]);           /* mov edx, [ebp-0xc] */
            ii(0x1010_d5cd, 3); mov(edx, memd[ds, edx + 20]);           /* mov edx, [edx+0x14] */
            ii(0x1010_d5d0, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1010_d5d3, 4); movsx(eax, memb[ss, ebp - 4]);          /* movsx eax, byte [ebp-0x4] */
            ii(0x1010_d5d7, 3); shl(eax, 2);                            /* shl eax, 0x2 */
            ii(0x1010_d5da, 3); add(eax, memd[ss, ebp - 8]);            /* add eax, [ebp-0x8] */
            ii(0x1010_d5dd, 3); mov(eax, memd[ds, eax + 32]);           /* mov eax, [eax+0x20] */
            ii(0x1010_d5e0, 5); call(0x100d_50d4, -0x3_8511);           /* call 0x100d50d4 */
            ii(0x1010_d5e5, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1010_d5e8, 2); mov(eax, memd[ds, eax]);                /* mov eax, [eax] */
            ii(0x1010_d5ea, 3); mov(edx, memd[ds, eax + 18]);           /* mov edx, [eax+0x12] */
            ii(0x1010_d5ed, 4); movsx(eax, memb[ss, ebp - 4]);          /* movsx eax, byte [ebp-0x4] */
            ii(0x1010_d5f1, 3); shl(eax, 2);                            /* shl eax, 0x2 */
            ii(0x1010_d5f4, 3); add(eax, memd[ss, ebp - 8]);            /* add eax, [ebp-0x8] */
            ii(0x1010_d5f7, 3); mov(eax, memd[ds, eax + 32]);           /* mov eax, [eax+0x20] */
            ii(0x1010_d5fa, 5); call(0x100c_f85c, -0x3_dda3);           /* call 0x100cf85c */
            ii(0x1010_d5ff, 4); movsx(edx, memb[ss, ebp - 4]);          /* movsx edx, byte [ebp-0x4] */
            ii(0x1010_d603, 4); movsx(eax, memb[ss, ebp - 4]);          /* movsx eax, byte [ebp-0x4] */
            ii(0x1010_d607, 3); imul(eax, eax, 0xc);                    /* imul eax, eax, 0xc */
            ii(0x1010_d60a, 3); add(eax, memd[ss, ebp - 8]);            /* add eax, [ebp-0x8] */
            ii(0x1010_d60d, 6); add(edx, 0x3e8);                        /* add edx, 0x3e8 */
            ii(0x1010_d613, 3); mov(memd[ds, eax + 80], edx);           /* mov [eax+0x50], edx */
            ii(0x1010_d616, 4); movsx(eax, memb[ss, ebp - 4]);          /* movsx eax, byte [ebp-0x4] */
            ii(0x1010_d61a, 3); imul(eax, eax, 0xc);                    /* imul eax, eax, 0xc */
            ii(0x1010_d61d, 3); add(eax, memd[ss, ebp - 8]);            /* add eax, [ebp-0x8] */
            ii(0x1010_d620, 3); mov(edx, memd[ss, ebp - 12]);           /* mov edx, [ebp-0xc] */
            ii(0x1010_d623, 3); mov(edx, memd[ds, edx + 14]);           /* mov edx, [edx+0xe] */
            ii(0x1010_d626, 3); mov(memd[ds, eax + 84], edx);           /* mov [eax+0x54], edx */
            ii(0x1010_d629, 4); movsx(eax, memb[ss, ebp - 4]);          /* movsx eax, byte [ebp-0x4] */
            ii(0x1010_d62d, 3); imul(eax, eax, 0xc);                    /* imul eax, eax, 0xc */
            ii(0x1010_d630, 3); add(eax, memd[ss, ebp - 8]);            /* add eax, [ebp-0x8] */
            ii(0x1010_d633, 3); mov(edx, memd[ss, ebp - 12]);           /* mov edx, [ebp-0xc] */
            ii(0x1010_d636, 3); mov(edx, memd[ds, edx + 18]);           /* mov edx, [edx+0x12] */
            ii(0x1010_d639, 3); mov(memd[ds, eax + 88], edx);           /* mov [eax+0x58], edx */
            ii(0x1010_d63c, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1010_d63e, 1); pop(ebp);                               /* pop ebp */
            ii(0x1010_d63f, 1); pop(edi);                               /* pop edi */
            ii(0x1010_d640, 1); pop(esi);                               /* pop esi */
            ii(0x1010_d641, 1); pop(ecx);                               /* pop ecx */
            ii(0x1010_d642, 1); pop(ebx);                               /* pop ebx */
            ii(0x1010_d643, 1); ret();                                  /* ret */
        }
    }
}
