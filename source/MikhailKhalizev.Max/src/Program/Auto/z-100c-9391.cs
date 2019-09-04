using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100c_9391-d4cbc146")]
        public void Method_100c_9391()
        {
            ii(0x100c_9391, 5); push(0x50);                             /* push 0x50 */
            ii(0x100c_9396, 5); call(Definitions.sys_check_available_stack_size, 0x9_c9b7); /* call 0x10165d52 */
            ii(0x100c_939b, 1); push(ecx);                              /* push ecx */
            ii(0x100c_939c, 1); push(esi);                              /* push esi */
            ii(0x100c_939d, 1); push(edi);                              /* push edi */
            ii(0x100c_939e, 1); push(ebp);                              /* push ebp */
            ii(0x100c_939f, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100c_93a1, 6); sub(esp, 0x3c);                         /* sub esp, 0x3c */
            ii(0x100c_93a7, 3); mov(memd[ss, ebp - 12], eax);           /* mov [ebp-0xc], eax */
            ii(0x100c_93aa, 3); mov(memd[ss, ebp - 8], edx);            /* mov [ebp-0x8], edx */
            ii(0x100c_93ad, 3); mov(memd[ss, ebp - 4], ebx);            /* mov [ebp-0x4], ebx */
            ii(0x100c_93b0, 3); mov(edx, memd[ss, ebp - 4]);            /* mov edx, [ebp-0x4] */
            ii(0x100c_93b3, 3); lea(eax, memd[ss, ebp - 48]);           /* lea eax, [ebp-0x30] */
            ii(0x100c_93b6, 5); call(0x1007_5e64, -0x5_3557);           /* call 0x10075e64 */
            ii(0x100c_93bb, 4); mov(memb[ss, ebp - 16], 1);             /* mov byte [ebp-0x10], 0x1 */
            ii(0x100c_93bf, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100c_93c2, 3); movsx(edx, memw[ds, eax]);              /* movsx edx, word [eax] */
            ii(0x100c_93c5, 3); shl(edx, 2);                            /* shl edx, 0x2 */
            ii(0x100c_93c8, 3); add(edx, memd[ss, ebp - 8]);            /* add edx, [ebp-0x8] */
            ii(0x100c_93cb, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100c_93ce, 2); mov(eax, memd[ds, eax]);                /* mov eax, [eax] */
            ii(0x100c_93d0, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100c_93d3, 2); add(eax, eax);                          /* add eax, eax */
            ii(0x100c_93d5, 2); mov(edx, memd[ds, edx]);                /* mov edx, [edx] */
            ii(0x100c_93d7, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x100c_93d9, 3); movsx(eax, memw[ds, eax]);              /* movsx eax, word [eax] */
            ii(0x100c_93dc, 3); test(ah, 0x80);                         /* test ah, 0x80 */
            ii(0x100c_93df, 6); if(jz(0x100c_95bd, 0x1d8)) goto l_0x100c_95bd; /* jz 0x100c95bd */
            ii(0x100c_93e5, 7); mov(memd[ss, ebp - 32], 0);             /* mov dword [ebp-0x20], 0x0 */
            ii(0x100c_93ec, 2); jmp(0x100c_93f4, 6); goto l_0x100c_93f4; /* jmp 0x100c93f4 */
        l_0x100c_93ee:
            ii(0x100c_93ee, 3); mov(eax, memd[ss, ebp - 32]);           /* mov eax, [ebp-0x20] */
            ii(0x100c_93f1, 3); inc(memd[ss, ebp - 32]);                /* inc dword [ebp-0x20] */
        l_0x100c_93f4:
            ii(0x100c_93f4, 4); movsx(eax, memw[ss, ebp - 32]);         /* movsx eax, word [ebp-0x20] */
            ii(0x100c_93f8, 3); cmp(eax, 4);                            /* cmp eax, 0x4 */
            ii(0x100c_93fb, 2); if(jge(0x100c_9417, 0x1a)) goto l_0x100c_9417; /* jge 0x100c9417 */
            ii(0x100c_93fd, 4); movsx(eax, memw[ss, ebp - 32]);         /* movsx eax, word [ebp-0x20] */
            ii(0x100c_9401, 6); imul(eax, eax, 0x247);                  /* imul eax, eax, 0x247 */
            ii(0x100c_9407, 6); mov(al, memb[ds, eax + 0x101c_a490]);   /* mov al, [eax+0x101ca490] */
            ii(0x100c_940d, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x100c_9412, 3); cmp(eax, 2);                            /* cmp eax, 0x2 */
            ii(0x100c_9415, 2); if(jnz(0x100c_93ee, -0x29)) goto l_0x100c_93ee; /* jnz 0x100c93ee */
        l_0x100c_9417:
            ii(0x100c_9417, 4); movsx(eax, memw[ss, ebp - 32]);         /* movsx eax, word [ebp-0x20] */
            ii(0x100c_941b, 3); cmp(eax, 4);                            /* cmp eax, 0x4 */
            ii(0x100c_941e, 6); if(jz(0x100c_95bd, 0x199)) goto l_0x100c_95bd; /* jz 0x100c95bd */
            ii(0x100c_9424, 5); mov(eax, 0x17);                         /* mov eax, 0x17 */
            ii(0x100c_9429, 5); call(Definitions.sys_new, 0x9_c9d2);    /* call 0x10165e00 */
            ii(0x100c_942e, 3); mov(memd[ss, ebp - 36], eax);           /* mov [ebp-0x24], eax */
            ii(0x100c_9431, 3); mov(eax, memd[ss, ebp - 36]);           /* mov eax, [ebp-0x24] */
            ii(0x100c_9434, 3); mov(memd[ss, ebp - 40], eax);           /* mov [ebp-0x28], eax */
            ii(0x100c_9437, 4); cmp(memd[ss, ebp - 40], 0);             /* cmp dword [ebp-0x28], 0x0 */
            ii(0x100c_943b, 2); if(jz(0x100c_9454, 0x17)) goto l_0x100c_9454; /* jz 0x100c9454 */
            ii(0x100c_943d, 4); movsx(edx, memw[ss, ebp - 32]);         /* movsx edx, word [ebp-0x20] */
            ii(0x100c_9441, 3); mov(eax, memd[ss, ebp - 36]);           /* mov eax, [ebp-0x24] */
            ii(0x100c_9444, 5); call(0x100c_9677, 0x22e);               /* call 0x100c9677 */
            ii(0x100c_9449, 3); mov(memd[ss, ebp - 44], eax);           /* mov [ebp-0x2c], eax */
            ii(0x100c_944c, 3); mov(eax, memd[ss, ebp - 44]);           /* mov eax, [ebp-0x2c] */
            ii(0x100c_944f, 3); mov(memd[ss, ebp - 52], eax);           /* mov [ebp-0x34], eax */
            ii(0x100c_9452, 2); jmp(0x100c_945a, 6); goto l_0x100c_945a; /* jmp 0x100c945a */
        l_0x100c_9454:
            ii(0x100c_9454, 3); mov(eax, memd[ss, ebp - 40]);           /* mov eax, [ebp-0x28] */
            ii(0x100c_9457, 3); mov(memd[ss, ebp - 52], eax);           /* mov [ebp-0x34], eax */
        l_0x100c_945a:
            ii(0x100c_945a, 3); mov(edx, memd[ss, ebp - 52]);           /* mov edx, [ebp-0x34] */
            ii(0x100c_945d, 5); mov(eax, 0x101c_3180);                  /* mov eax, 0x101c3180 */
            ii(0x100c_9462, 5); call(0x100a_4d50, -0x2_4717);           /* call 0x100a4d50 */
            ii(0x100c_9467, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100c_946a, 3); movsx(edx, memw[ds, eax]);              /* movsx edx, word [eax] */
            ii(0x100c_946d, 3); shl(edx, 2);                            /* shl edx, 0x2 */
            ii(0x100c_9470, 3); add(edx, memd[ss, ebp - 8]);            /* add edx, [ebp-0x8] */
            ii(0x100c_9473, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100c_9476, 2); mov(eax, memd[ds, eax]);                /* mov eax, [eax] */
            ii(0x100c_9478, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100c_947b, 2); add(eax, eax);                          /* add eax, eax */
            ii(0x100c_947d, 2); mov(edx, memd[ds, edx]);                /* mov edx, [edx] */
            ii(0x100c_947f, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x100c_9481, 5); mov(memw[ds, eax], 0x7fff);             /* mov word [eax], 0x7fff */
            ii(0x100c_9486, 7); mov(memd[ss, ebp - 20], 1);             /* mov dword [ebp-0x14], 0x1 */
            ii(0x100c_948d, 2); jmp(0x100c_9495, 6); goto l_0x100c_9495; /* jmp 0x100c9495 */
        l_0x100c_948f:
            ii(0x100c_948f, 3); mov(eax, memd[ss, ebp - 20]);           /* mov eax, [ebp-0x14] */
            ii(0x100c_9492, 3); inc(memd[ss, ebp - 20]);                /* inc dword [ebp-0x14] */
        l_0x100c_9495:
            ii(0x100c_9495, 4); cmp(memb[ss, ebp - 16], 0);             /* cmp byte [ebp-0x10], 0x0 */
            ii(0x100c_9499, 6); if(jz(0x100c_95bd, 0x11e)) goto l_0x100c_95bd; /* jz 0x100c95bd */
            ii(0x100c_949f, 3); mov(eax, memd[ss, ebp - 48]);           /* mov eax, [ebp-0x30] */
            ii(0x100c_94a2, 4); dec(memw[ss, ebp - 48]);                /* dec word [ebp-0x30] */
            ii(0x100c_94a6, 3); mov(eax, memd[ss, ebp - 46]);           /* mov eax, [ebp-0x2e] */
            ii(0x100c_94a9, 4); inc(memw[ss, ebp - 46]);                /* inc word [ebp-0x2e] */
            ii(0x100c_94ad, 4); mov(memb[ss, ebp - 16], 0);             /* mov byte [ebp-0x10], 0x0 */
            ii(0x100c_94b1, 7); mov(memd[ss, ebp - 24], 0);             /* mov dword [ebp-0x18], 0x0 */
            ii(0x100c_94b8, 2); jmp(0x100c_94be, 4); goto l_0x100c_94be; /* jmp 0x100c94be */
        l_0x100c_94ba:
            ii(0x100c_94ba, 4); add(memd[ss, ebp - 24], 2);             /* add dword [ebp-0x18], 0x2 */
        l_0x100c_94be:
            ii(0x100c_94be, 4); movsx(eax, memw[ss, ebp - 24]);         /* movsx eax, word [ebp-0x18] */
            ii(0x100c_94c2, 3); cmp(eax, 8);                            /* cmp eax, 0x8 */
            ii(0x100c_94c5, 6); if(jge(0x100c_95b8, 0xed)) goto l_0x100c_95b8; /* jge 0x100c95b8 */
            ii(0x100c_94cb, 3); mov(eax, memd[ss, ebp - 20]);           /* mov eax, [ebp-0x14] */
            ii(0x100c_94ce, 2); add(eax, eax);                          /* add eax, eax */
            ii(0x100c_94d0, 3); mov(memd[ss, ebp - 32], eax);           /* mov [ebp-0x20], eax */
        l_0x100c_94d3:
            ii(0x100c_94d3, 3); dec(memd[ss, ebp - 32]);                /* dec dword [ebp-0x20] */
            ii(0x100c_94d6, 5); cmp(memw[ss, ebp - 32], -1 /* 0xff */); /* cmp word [ebp-0x20], 0xffff */
            ii(0x100c_94db, 6); if(jz(0x100c_95b3, 0xd2)) goto l_0x100c_95b3; /* jz 0x100c95b3 */
            ii(0x100c_94e1, 4); movsx(eax, memw[ss, ebp - 24]);         /* movsx eax, word [ebp-0x18] */
            ii(0x100c_94e5, 3); shl(eax, 2);                            /* shl eax, 0x2 */
            ii(0x100c_94e8, 5); mov(edx, 0x101c_5348);                  /* mov edx, 0x101c5348 */
            ii(0x100c_94ed, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x100c_94ef, 3); lea(eax, memd[ss, ebp - 48]);           /* lea eax, [ebp-0x30] */
            ii(0x100c_94f2, 5); call(0x1008_b1a4, -0x3_e353);           /* call 0x1008b1a4 */
            ii(0x100c_94f7, 4); movsx(eax, memw[ss, ebp - 48]);         /* movsx eax, word [ebp-0x30] */
            ii(0x100c_94fb, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100c_94fd, 2); if(jl(0x100c_950b, 0xc)) goto l_0x100c_950b; /* jl 0x100c950b */
            ii(0x100c_94ff, 3); mov(eax, memd[ss, ebp - 48]);           /* mov eax, [ebp-0x30] */
            ii(0x100c_9502, 7); cmp(ax, memw[ds, 0x101c_8172]);         /* cmp ax, [0x101c8172] */
            ii(0x100c_9509, 2); if(jl(0x100c_950d, 2)) goto l_0x100c_950d; /* jl 0x100c950d */
        l_0x100c_950b:
            ii(0x100c_950b, 2); jmp(0x100c_9515, 8); goto l_0x100c_9515; /* jmp 0x100c9515 */
        l_0x100c_950d:
            ii(0x100c_950d, 4); movsx(eax, memw[ss, ebp - 46]);         /* movsx eax, word [ebp-0x2e] */
            ii(0x100c_9511, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100c_9513, 2); if(jge(0x100c_9517, 2)) goto l_0x100c_9517; /* jge 0x100c9517 */
        l_0x100c_9515:
            ii(0x100c_9515, 2); jmp(0x100c_9523, 0xc); goto l_0x100c_9523; /* jmp 0x100c9523 */
        l_0x100c_9517:
            ii(0x100c_9517, 3); mov(eax, memd[ss, ebp - 46]);           /* mov eax, [ebp-0x2e] */
            ii(0x100c_951a, 7); cmp(ax, memw[ds, 0x101c_8174]);         /* cmp ax, [0x101c8174] */
            ii(0x100c_9521, 2); if(jl(0x100c_9528, 5)) goto l_0x100c_9528; /* jl 0x100c9528 */
        l_0x100c_9523:
            ii(0x100c_9523, 5); jmp(0x100c_95ae, 0x86); goto l_0x100c_95ae; /* jmp 0x100c95ae */
        l_0x100c_9528:
            ii(0x100c_9528, 3); mov(edx, memd[ss, ebp - 4]);            /* mov edx, [ebp-0x4] */
            ii(0x100c_952b, 3); lea(eax, memd[ss, ebp - 56]);           /* lea eax, [ebp-0x38] */
            ii(0x100c_952e, 5); call(0x1007_5e64, -0x5_36cf);           /* call 0x10075e64 */
            ii(0x100c_9533, 2); mov(ebx, eax);                          /* mov ebx, eax */
            ii(0x100c_9535, 3); lea(edx, memd[ss, ebp - 48]);           /* lea edx, [ebp-0x30] */
            ii(0x100c_9538, 3); lea(eax, memd[ss, ebp - 60]);           /* lea eax, [ebp-0x3c] */
            ii(0x100c_953b, 5); call(0x1007_5e64, -0x5_36dc);           /* call 0x10075e64 */
            ii(0x100c_9540, 2); mov(edx, ebx);                          /* mov edx, ebx */
            ii(0x100c_9542, 5); call(0x1007_0c51, -0x5_88f6);           /* call 0x10070c51 */
            ii(0x100c_9547, 3); mov(memd[ss, ebp - 28], eax);           /* mov [ebp-0x1c], eax */
            ii(0x100c_954a, 4); movsx(eax, memw[ss, ebp - 48]);         /* movsx eax, word [ebp-0x30] */
            ii(0x100c_954e, 3); shl(eax, 2);                            /* shl eax, 0x2 */
            ii(0x100c_9551, 3); add(eax, memd[ss, ebp - 8]);            /* add eax, [ebp-0x8] */
            ii(0x100c_9554, 4); movsx(edx, memw[ss, ebp - 46]);         /* movsx edx, word [ebp-0x2e] */
            ii(0x100c_9558, 2); add(edx, edx);                          /* add edx, edx */
            ii(0x100c_955a, 2); mov(eax, memd[ds, eax]);                /* mov eax, [eax] */
            ii(0x100c_955c, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x100c_955e, 3); movsx(eax, memw[ds, eax]);              /* movsx eax, word [eax] */
            ii(0x100c_9561, 5); and(eax, 0x7fff);                       /* and eax, 0x7fff */
            ii(0x100c_9566, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100c_9568, 4); movsx(eax, memw[ss, ebp - 28]);         /* movsx eax, word [ebp-0x1c] */
            ii(0x100c_956c, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x100c_956e, 2); if(jnz(0x100c_95ae, 0x3e)) goto l_0x100c_95ae; /* jnz 0x100c95ae */
            ii(0x100c_9570, 4); movsx(eax, memw[ss, ebp - 48]);         /* movsx eax, word [ebp-0x30] */
            ii(0x100c_9574, 3); shl(eax, 2);                            /* shl eax, 0x2 */
            ii(0x100c_9577, 3); add(eax, memd[ss, ebp - 8]);            /* add eax, [ebp-0x8] */
            ii(0x100c_957a, 4); movsx(edx, memw[ss, ebp - 46]);         /* movsx edx, word [ebp-0x2e] */
            ii(0x100c_957e, 2); add(edx, edx);                          /* add edx, edx */
            ii(0x100c_9580, 2); mov(eax, memd[ds, eax]);                /* mov eax, [eax] */
            ii(0x100c_9582, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x100c_9584, 3); mov(bx, memw[ds, eax]);                 /* mov bx, [eax] */
            ii(0x100c_9587, 6); and(ebx, 0x8000);                       /* and ebx, 0x8000 */
            ii(0x100c_958d, 6); or(ebx, 0x7fff);                        /* or ebx, 0x7fff */
            ii(0x100c_9593, 4); movsx(eax, memw[ss, ebp - 48]);         /* movsx eax, word [ebp-0x30] */
            ii(0x100c_9597, 3); shl(eax, 2);                            /* shl eax, 0x2 */
            ii(0x100c_959a, 3); add(eax, memd[ss, ebp - 8]);            /* add eax, [ebp-0x8] */
            ii(0x100c_959d, 4); movsx(edx, memw[ss, ebp - 46]);         /* movsx edx, word [ebp-0x2e] */
            ii(0x100c_95a1, 2); add(edx, edx);                          /* add edx, edx */
            ii(0x100c_95a3, 2); mov(eax, memd[ds, eax]);                /* mov eax, [eax] */
            ii(0x100c_95a5, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x100c_95a7, 3); mov(memw[ds, eax], bx);                 /* mov [eax], bx */
            ii(0x100c_95aa, 4); mov(memb[ss, ebp - 16], 1);             /* mov byte [ebp-0x10], 0x1 */
        l_0x100c_95ae:
            ii(0x100c_95ae, 5); jmp(0x100c_94d3, -0xe0); goto l_0x100c_94d3; /* jmp 0x100c94d3 */
        l_0x100c_95b3:
            ii(0x100c_95b3, 5); jmp(0x100c_94ba, -0xfe); goto l_0x100c_94ba; /* jmp 0x100c94ba */
        l_0x100c_95b8:
            ii(0x100c_95b8, 5); jmp(0x100c_948f, -0x12e); goto l_0x100c_948f; /* jmp 0x100c948f */
        l_0x100c_95bd:
            ii(0x100c_95bd, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100c_95bf, 1); pop(ebp);                               /* pop ebp */
            ii(0x100c_95c0, 1); pop(edi);                               /* pop edi */
            ii(0x100c_95c1, 1); pop(esi);                               /* pop esi */
            ii(0x100c_95c2, 1); pop(ecx);                               /* pop ecx */
            ii(0x100c_95c3, 1); ret();                                  /* ret */
        }
    }
}
