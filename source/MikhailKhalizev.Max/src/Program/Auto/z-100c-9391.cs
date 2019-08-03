using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("45aaee01-61a3-4dd6-98ad-fc98378130c6")]
        public void Method_100c_9391()
        {
            ii(0x100c_9391, 5); pushd(0x50);                            /* push 0x50 */
            ii(0x100c_9396, 5); calld(Definitions.sys_check_available_stack_size, 0x9c9b7); /* call 0x10165d52 */
            ii(0x100c_939b, 1); pushd(ecx);                             /* push ecx */
            ii(0x100c_939c, 1); pushd(esi);                             /* push esi */
            ii(0x100c_939d, 1); pushd(edi);                             /* push edi */
            ii(0x100c_939e, 1); pushd(ebp);                             /* push ebp */
            ii(0x100c_939f, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100c_93a1, 6); sub(esp, 0x3c);                         /* sub esp, 0x3c */
            ii(0x100c_93a7, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x100c_93aa, 3); mov(memd_a32[ss, ebp - 0x8], edx);      /* mov [ebp-0x8], edx */
            ii(0x100c_93ad, 3); mov(memd_a32[ss, ebp - 0x4], ebx);      /* mov [ebp-0x4], ebx */
            ii(0x100c_93b0, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x100c_93b3, 3); lea(eax, ebp - 0x30);                   /* lea eax, [ebp-0x30] */
            ii(0x100c_93b6, 5); calld(0x1007_5e64, -0x53557);           /* call 0x10075e64 */
            ii(0x100c_93bb, 4); mov(memb_a32[ss, ebp - 0x10], 0x1);     /* mov byte [ebp-0x10], 0x1 */
            ii(0x100c_93bf, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100c_93c2, 3); movsx(edx, memw_a32[ds, eax]);          /* movsx edx, word [eax] */
            ii(0x100c_93c5, 3); shl(edx, 0x2);                          /* shl edx, 0x2 */
            ii(0x100c_93c8, 3); add(edx, memd_a32[ss, ebp - 0x8]);      /* add edx, [ebp-0x8] */
            ii(0x100c_93cb, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100c_93ce, 2); mov(eax, memd_a32[ds, eax]);            /* mov eax, [eax] */
            ii(0x100c_93d0, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100c_93d3, 2); add(eax, eax);                          /* add eax, eax */
            ii(0x100c_93d5, 2); mov(edx, memd_a32[ds, edx]);            /* mov edx, [edx] */
            ii(0x100c_93d7, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x100c_93d9, 3); movsx(eax, memw_a32[ds, eax]);          /* movsx eax, word [eax] */
            ii(0x100c_93dc, 3); test(ah, 0x80);                         /* test ah, 0x80 */
            ii(0x100c_93df, 6); if(jzd(0x100c_95bd, 0x1d8)) goto l_0x100c_95bd; /* jz 0x100c95bd */
            ii(0x100c_93e5, 7); mov(memd_a32[ss, ebp - 0x20], 0);       /* mov dword [ebp-0x20], 0x0 */
            ii(0x100c_93ec, 2); jmpd(0x100c_93f4, 0x6); goto l_0x100c_93f4; /* jmp 0x100c93f4 */
        l_0x100c_93ee:
            ii(0x100c_93ee, 3); mov(eax, memd_a32[ss, ebp - 0x20]);     /* mov eax, [ebp-0x20] */
            ii(0x100c_93f1, 3); inc(memd_a32[ss, ebp - 0x20]);          /* inc dword [ebp-0x20] */
        l_0x100c_93f4:
            ii(0x100c_93f4, 4); movsx(eax, memw_a32[ss, ebp - 0x20]);   /* movsx eax, word [ebp-0x20] */
            ii(0x100c_93f8, 3); cmp(eax, 0x4);                          /* cmp eax, 0x4 */
            ii(0x100c_93fb, 2); if(jged(0x100c_9417, 0x1a)) goto l_0x100c_9417; /* jge 0x100c9417 */
            ii(0x100c_93fd, 4); movsx(eax, memw_a32[ss, ebp - 0x20]);   /* movsx eax, word [ebp-0x20] */
            ii(0x100c_9401, 6); imul(eax, eax, 0x247);                  /* imul eax, eax, 0x247 */
            ii(0x100c_9407, 6); mov(al, memb_a32[ds, eax + 0x101c_a490]); /* mov al, [eax+0x101ca490] */
            ii(0x100c_940d, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x100c_9412, 3); cmp(eax, 0x2);                          /* cmp eax, 0x2 */
            ii(0x100c_9415, 2); if(jnzd(0x100c_93ee, -0x29)) goto l_0x100c_93ee; /* jnz 0x100c93ee */
        l_0x100c_9417:
            ii(0x100c_9417, 4); movsx(eax, memw_a32[ss, ebp - 0x20]);   /* movsx eax, word [ebp-0x20] */
            ii(0x100c_941b, 3); cmp(eax, 0x4);                          /* cmp eax, 0x4 */
            ii(0x100c_941e, 6); if(jzd(0x100c_95bd, 0x199)) goto l_0x100c_95bd; /* jz 0x100c95bd */
            ii(0x100c_9424, 5); mov(eax, 0x17);                         /* mov eax, 0x17 */
            ii(0x100c_9429, 5); calld(Definitions.sys_new, 0x9c9d2);    /* call 0x10165e00 */
            ii(0x100c_942e, 3); mov(memd_a32[ss, ebp - 0x24], eax);     /* mov [ebp-0x24], eax */
            ii(0x100c_9431, 3); mov(eax, memd_a32[ss, ebp - 0x24]);     /* mov eax, [ebp-0x24] */
            ii(0x100c_9434, 3); mov(memd_a32[ss, ebp - 0x28], eax);     /* mov [ebp-0x28], eax */
            ii(0x100c_9437, 4); cmp(memd_a32[ss, ebp - 0x28], 0);       /* cmp dword [ebp-0x28], 0x0 */
            ii(0x100c_943b, 2); if(jzd(0x100c_9454, 0x17)) goto l_0x100c_9454; /* jz 0x100c9454 */
            ii(0x100c_943d, 4); movsx(edx, memw_a32[ss, ebp - 0x20]);   /* movsx edx, word [ebp-0x20] */
            ii(0x100c_9441, 3); mov(eax, memd_a32[ss, ebp - 0x24]);     /* mov eax, [ebp-0x24] */
            ii(0x100c_9444, 5); calld(0x100c_9677, 0x22e);              /* call 0x100c9677 */
            ii(0x100c_9449, 3); mov(memd_a32[ss, ebp - 0x2c], eax);     /* mov [ebp-0x2c], eax */
            ii(0x100c_944c, 3); mov(eax, memd_a32[ss, ebp - 0x2c]);     /* mov eax, [ebp-0x2c] */
            ii(0x100c_944f, 3); mov(memd_a32[ss, ebp - 0x34], eax);     /* mov [ebp-0x34], eax */
            ii(0x100c_9452, 2); jmpd(0x100c_945a, 0x6); goto l_0x100c_945a; /* jmp 0x100c945a */
        l_0x100c_9454:
            ii(0x100c_9454, 3); mov(eax, memd_a32[ss, ebp - 0x28]);     /* mov eax, [ebp-0x28] */
            ii(0x100c_9457, 3); mov(memd_a32[ss, ebp - 0x34], eax);     /* mov [ebp-0x34], eax */
        l_0x100c_945a:
            ii(0x100c_945a, 3); mov(edx, memd_a32[ss, ebp - 0x34]);     /* mov edx, [ebp-0x34] */
            ii(0x100c_945d, 5); mov(eax, 0x101c_3180);                  /* mov eax, 0x101c3180 */
            ii(0x100c_9462, 5); calld(0x100a_4d50, -0x24717);           /* call 0x100a4d50 */
            ii(0x100c_9467, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100c_946a, 3); movsx(edx, memw_a32[ds, eax]);          /* movsx edx, word [eax] */
            ii(0x100c_946d, 3); shl(edx, 0x2);                          /* shl edx, 0x2 */
            ii(0x100c_9470, 3); add(edx, memd_a32[ss, ebp - 0x8]);      /* add edx, [ebp-0x8] */
            ii(0x100c_9473, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100c_9476, 2); mov(eax, memd_a32[ds, eax]);            /* mov eax, [eax] */
            ii(0x100c_9478, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100c_947b, 2); add(eax, eax);                          /* add eax, eax */
            ii(0x100c_947d, 2); mov(edx, memd_a32[ds, edx]);            /* mov edx, [edx] */
            ii(0x100c_947f, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x100c_9481, 5); mov(memw_a32[ds, eax], 0x7fff);         /* mov word [eax], 0x7fff */
            ii(0x100c_9486, 7); mov(memd_a32[ss, ebp - 0x14], 0x1);     /* mov dword [ebp-0x14], 0x1 */
            ii(0x100c_948d, 2); jmpd(0x100c_9495, 0x6); goto l_0x100c_9495; /* jmp 0x100c9495 */
        l_0x100c_948f:
            ii(0x100c_948f, 3); mov(eax, memd_a32[ss, ebp - 0x14]);     /* mov eax, [ebp-0x14] */
            ii(0x100c_9492, 3); inc(memd_a32[ss, ebp - 0x14]);          /* inc dword [ebp-0x14] */
        l_0x100c_9495:
            ii(0x100c_9495, 4); cmp(memb_a32[ss, ebp - 0x10], 0);       /* cmp byte [ebp-0x10], 0x0 */
            ii(0x100c_9499, 6); if(jzd(0x100c_95bd, 0x11e)) goto l_0x100c_95bd; /* jz 0x100c95bd */
            ii(0x100c_949f, 3); mov(eax, memd_a32[ss, ebp - 0x30]);     /* mov eax, [ebp-0x30] */
            ii(0x100c_94a2, 4); dec(memw_a32[ss, ebp - 0x30]);          /* dec word [ebp-0x30] */
            ii(0x100c_94a6, 3); mov(eax, memd_a32[ss, ebp - 0x2e]);     /* mov eax, [ebp-0x2e] */
            ii(0x100c_94a9, 4); inc(memw_a32[ss, ebp - 0x2e]);          /* inc word [ebp-0x2e] */
            ii(0x100c_94ad, 4); mov(memb_a32[ss, ebp - 0x10], 0);       /* mov byte [ebp-0x10], 0x0 */
            ii(0x100c_94b1, 7); mov(memd_a32[ss, ebp - 0x18], 0);       /* mov dword [ebp-0x18], 0x0 */
            ii(0x100c_94b8, 2); jmpd(0x100c_94be, 0x4); goto l_0x100c_94be; /* jmp 0x100c94be */
        l_0x100c_94ba:
            ii(0x100c_94ba, 4); add(memd_a32[ss, ebp - 0x18], 0x2);     /* add dword [ebp-0x18], 0x2 */
        l_0x100c_94be:
            ii(0x100c_94be, 4); movsx(eax, memw_a32[ss, ebp - 0x18]);   /* movsx eax, word [ebp-0x18] */
            ii(0x100c_94c2, 3); cmp(eax, 0x8);                          /* cmp eax, 0x8 */
            ii(0x100c_94c5, 6); if(jged(0x100c_95b8, 0xed)) goto l_0x100c_95b8; /* jge 0x100c95b8 */
            ii(0x100c_94cb, 3); mov(eax, memd_a32[ss, ebp - 0x14]);     /* mov eax, [ebp-0x14] */
            ii(0x100c_94ce, 2); add(eax, eax);                          /* add eax, eax */
            ii(0x100c_94d0, 3); mov(memd_a32[ss, ebp - 0x20], eax);     /* mov [ebp-0x20], eax */
        l_0x100c_94d3:
            ii(0x100c_94d3, 3); dec(memd_a32[ss, ebp - 0x20]);          /* dec dword [ebp-0x20] */
            ii(0x100c_94d6, 5); cmp(memw_a32[ss, ebp - 0x20], -0x1 /* 0xff */); /* cmp word [ebp-0x20], 0xffff */
            ii(0x100c_94db, 6); if(jzd(0x100c_95b3, 0xd2)) goto l_0x100c_95b3; /* jz 0x100c95b3 */
            ii(0x100c_94e1, 4); movsx(eax, memw_a32[ss, ebp - 0x18]);   /* movsx eax, word [ebp-0x18] */
            ii(0x100c_94e5, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x100c_94e8, 5); mov(edx, 0x101c_5348);                  /* mov edx, 0x101c5348 */
            ii(0x100c_94ed, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x100c_94ef, 3); lea(eax, ebp - 0x30);                   /* lea eax, [ebp-0x30] */
            ii(0x100c_94f2, 5); calld(0x1008_b1a4, -0x3e353);           /* call 0x1008b1a4 */
            ii(0x100c_94f7, 4); movsx(eax, memw_a32[ss, ebp - 0x30]);   /* movsx eax, word [ebp-0x30] */
            ii(0x100c_94fb, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100c_94fd, 2); if(jld(0x100c_950b, 0xc)) goto l_0x100c_950b; /* jl 0x100c950b */
            ii(0x100c_94ff, 3); mov(eax, memd_a32[ss, ebp - 0x30]);     /* mov eax, [ebp-0x30] */
            ii(0x100c_9502, 7); cmp(ax, memw_a32[ds, 0x101c_8172]);     /* cmp ax, [0x101c8172] */
            ii(0x100c_9509, 2); if(jld(0x100c_950d, 0x2)) goto l_0x100c_950d; /* jl 0x100c950d */
        l_0x100c_950b:
            ii(0x100c_950b, 2); jmpd(0x100c_9515, 0x8); goto l_0x100c_9515; /* jmp 0x100c9515 */
        l_0x100c_950d:
            ii(0x100c_950d, 4); movsx(eax, memw_a32[ss, ebp - 0x2e]);   /* movsx eax, word [ebp-0x2e] */
            ii(0x100c_9511, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100c_9513, 2); if(jged(0x100c_9517, 0x2)) goto l_0x100c_9517; /* jge 0x100c9517 */
        l_0x100c_9515:
            ii(0x100c_9515, 2); jmpd(0x100c_9523, 0xc); goto l_0x100c_9523; /* jmp 0x100c9523 */
        l_0x100c_9517:
            ii(0x100c_9517, 3); mov(eax, memd_a32[ss, ebp - 0x2e]);     /* mov eax, [ebp-0x2e] */
            ii(0x100c_951a, 7); cmp(ax, memw_a32[ds, 0x101c_8174]);     /* cmp ax, [0x101c8174] */
            ii(0x100c_9521, 2); if(jld(0x100c_9528, 0x5)) goto l_0x100c_9528; /* jl 0x100c9528 */
        l_0x100c_9523:
            ii(0x100c_9523, 5); jmpd(0x100c_95ae, 0x86); goto l_0x100c_95ae; /* jmp 0x100c95ae */
        l_0x100c_9528:
            ii(0x100c_9528, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x100c_952b, 3); lea(eax, ebp - 0x38);                   /* lea eax, [ebp-0x38] */
            ii(0x100c_952e, 5); calld(0x1007_5e64, -0x536cf);           /* call 0x10075e64 */
            ii(0x100c_9533, 2); mov(ebx, eax);                          /* mov ebx, eax */
            ii(0x100c_9535, 3); lea(edx, ebp - 0x30);                   /* lea edx, [ebp-0x30] */
            ii(0x100c_9538, 3); lea(eax, ebp - 0x3c);                   /* lea eax, [ebp-0x3c] */
            ii(0x100c_953b, 5); calld(0x1007_5e64, -0x536dc);           /* call 0x10075e64 */
            ii(0x100c_9540, 2); mov(edx, ebx);                          /* mov edx, ebx */
            ii(0x100c_9542, 5); calld(0x1007_0c51, -0x588f6);           /* call 0x10070c51 */
            ii(0x100c_9547, 3); mov(memd_a32[ss, ebp - 0x1c], eax);     /* mov [ebp-0x1c], eax */
            ii(0x100c_954a, 4); movsx(eax, memw_a32[ss, ebp - 0x30]);   /* movsx eax, word [ebp-0x30] */
            ii(0x100c_954e, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x100c_9551, 3); add(eax, memd_a32[ss, ebp - 0x8]);      /* add eax, [ebp-0x8] */
            ii(0x100c_9554, 4); movsx(edx, memw_a32[ss, ebp - 0x2e]);   /* movsx edx, word [ebp-0x2e] */
            ii(0x100c_9558, 2); add(edx, edx);                          /* add edx, edx */
            ii(0x100c_955a, 2); mov(eax, memd_a32[ds, eax]);            /* mov eax, [eax] */
            ii(0x100c_955c, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x100c_955e, 3); movsx(eax, memw_a32[ds, eax]);          /* movsx eax, word [eax] */
            ii(0x100c_9561, 5); and(eax, 0x7fff);                       /* and eax, 0x7fff */
            ii(0x100c_9566, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100c_9568, 4); movsx(eax, memw_a32[ss, ebp - 0x1c]);   /* movsx eax, word [ebp-0x1c] */
            ii(0x100c_956c, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x100c_956e, 2); if(jnzd(0x100c_95ae, 0x3e)) goto l_0x100c_95ae; /* jnz 0x100c95ae */
            ii(0x100c_9570, 4); movsx(eax, memw_a32[ss, ebp - 0x30]);   /* movsx eax, word [ebp-0x30] */
            ii(0x100c_9574, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x100c_9577, 3); add(eax, memd_a32[ss, ebp - 0x8]);      /* add eax, [ebp-0x8] */
            ii(0x100c_957a, 4); movsx(edx, memw_a32[ss, ebp - 0x2e]);   /* movsx edx, word [ebp-0x2e] */
            ii(0x100c_957e, 2); add(edx, edx);                          /* add edx, edx */
            ii(0x100c_9580, 2); mov(eax, memd_a32[ds, eax]);            /* mov eax, [eax] */
            ii(0x100c_9582, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x100c_9584, 3); mov(bx, memw_a32[ds, eax]);             /* mov bx, [eax] */
            ii(0x100c_9587, 6); and(ebx, 0x8000);                       /* and ebx, 0x8000 */
            ii(0x100c_958d, 6); or(ebx, 0x7fff);                        /* or ebx, 0x7fff */
            ii(0x100c_9593, 4); movsx(eax, memw_a32[ss, ebp - 0x30]);   /* movsx eax, word [ebp-0x30] */
            ii(0x100c_9597, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x100c_959a, 3); add(eax, memd_a32[ss, ebp - 0x8]);      /* add eax, [ebp-0x8] */
            ii(0x100c_959d, 4); movsx(edx, memw_a32[ss, ebp - 0x2e]);   /* movsx edx, word [ebp-0x2e] */
            ii(0x100c_95a1, 2); add(edx, edx);                          /* add edx, edx */
            ii(0x100c_95a3, 2); mov(eax, memd_a32[ds, eax]);            /* mov eax, [eax] */
            ii(0x100c_95a5, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x100c_95a7, 3); mov(memw_a32[ds, eax], bx);             /* mov [eax], bx */
            ii(0x100c_95aa, 4); mov(memb_a32[ss, ebp - 0x10], 0x1);     /* mov byte [ebp-0x10], 0x1 */
        l_0x100c_95ae:
            ii(0x100c_95ae, 5); jmpd(0x100c_94d3, -0xe0); goto l_0x100c_94d3; /* jmp 0x100c94d3 */
        l_0x100c_95b3:
            ii(0x100c_95b3, 5); jmpd(0x100c_94ba, -0xfe); goto l_0x100c_94ba; /* jmp 0x100c94ba */
        l_0x100c_95b8:
            ii(0x100c_95b8, 5); jmpd(0x100c_948f, -0x12e); goto l_0x100c_948f; /* jmp 0x100c948f */
        l_0x100c_95bd:
            ii(0x100c_95bd, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100c_95bf, 1); popd(ebp);                              /* pop ebp */
            ii(0x100c_95c0, 1); popd(edi);                              /* pop edi */
            ii(0x100c_95c1, 1); popd(esi);                              /* pop esi */
            ii(0x100c_95c2, 1); popd(ecx);                              /* pop ecx */
            ii(0x100c_95c3, 1); retd(); return;                         /* ret */
        }
    }
}