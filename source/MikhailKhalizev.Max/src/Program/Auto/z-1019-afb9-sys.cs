using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1019_afb9-535b2c86")]
        public void /* sys */ Method_1019_afb9()
        {
            ii(0x1019_afb9, 1); push(esi);                              /* push esi */
            ii(0x1019_afba, 1); push(edi);                              /* push edi */
            ii(0x1019_afbb, 1); push(ebp);                              /* push ebp */
            ii(0x1019_afbc, 2); mov(edi, eax);                          /* mov edi, eax */
            ii(0x1019_afbe, 2); mov(esi, edx);                          /* mov esi, edx */
            ii(0x1019_afc0, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x1019_afc2, 6); cmp(edx, 0xa8c0);                       /* cmp edx, 0xa8c0 */
            ii(0x1019_afc8, 2); if(jae(0x1019_afe6, 0x1c)) goto l_0x1019_afe6; /* jae 0x1019afe6 */
            ii(0x1019_afca, 2); test(ebx, ebx);                         /* test ebx, ebx */
            ii(0x1019_afcc, 2); if(jle(0x1019_afe6, 0x18)) goto l_0x1019_afe6; /* jle 0x1019afe6 */
            ii(0x1019_afce, 6); lea(esi, memd[ds, edx + 0x1_5180]);     /* lea esi, [edx+0x15180] */
            ii(0x1019_afd4, 2); sub(esi, ebx);                          /* sub esi, ebx */
            ii(0x1019_afd6, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1019_afd8, 5); mov(ebx, 0x1_5180);                     /* mov ebx, 0x15180 */
            ii(0x1019_afdd, 2); mov(eax, esi);                          /* mov eax, esi */
            ii(0x1019_afdf, 2); div(ebx);                               /* div ebx */
            ii(0x1019_afe1, 2); add(edi, eax);                          /* add edi, eax */
            ii(0x1019_afe3, 1); dec(edi);                               /* dec edi */
            ii(0x1019_afe4, 2); jmp(0x1019_aff5, 0xf); goto l_0x1019_aff5; /* jmp 0x1019aff5 */
        l_0x1019_afe6:
            ii(0x1019_afe6, 5); mov(ebx, 0x1_5180);                     /* mov ebx, 0x15180 */
            ii(0x1019_afeb, 2); sub(esi, eax);                          /* sub esi, eax */
            ii(0x1019_afed, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1019_afef, 2); mov(eax, esi);                          /* mov eax, esi */
            ii(0x1019_aff1, 2); div(ebx);                               /* div ebx */
            ii(0x1019_aff3, 2); add(edi, eax);                          /* add edi, eax */
        l_0x1019_aff5:
            ii(0x1019_aff5, 5); mov(ebx, 0x1_5180);                     /* mov ebx, 0x15180 */
            ii(0x1019_affa, 2); mov(eax, esi);                          /* mov eax, esi */
            ii(0x1019_affc, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1019_affe, 2); div(ebx);                               /* div ebx */
            ii(0x1019_b000, 2); mov(ebx, edx);                          /* mov ebx, edx */
            ii(0x1019_b002, 5); mov(esi, 0xe10);                        /* mov esi, 0xe10 */
            ii(0x1019_b007, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x1019_b009, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1019_b00b, 2); div(esi);                               /* div esi */
            ii(0x1019_b00d, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1019_b00f, 3); mov(memd[ds, ecx + 0x8], eax);          /* mov [ecx+0x8], eax */
            ii(0x1019_b012, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x1019_b014, 2); div(esi);                               /* div esi */
            ii(0x1019_b016, 2); mov(ebx, edx);                          /* mov ebx, edx */
            ii(0x1019_b018, 5); mov(esi, 0x3c);                         /* mov esi, 0x3c */
            ii(0x1019_b01d, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x1019_b01f, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1019_b021, 2); div(esi);                               /* div esi */
            ii(0x1019_b023, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1019_b025, 3); mov(memd[ds, ecx + 0x4], eax);          /* mov [ecx+0x4], eax */
            ii(0x1019_b028, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x1019_b02a, 2); div(esi);                               /* div esi */
            ii(0x1019_b02c, 5); mov(ebx, 0x16e);                        /* mov ebx, 0x16e */
            ii(0x1019_b031, 2); mov(eax, edi);                          /* mov eax, edi */
            ii(0x1019_b033, 2); mov(memd[ds, ecx], edx);                /* mov [ecx], edx */
            ii(0x1019_b035, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1019_b037, 2); div(ebx);                               /* div ebx */
            ii(0x1019_b039, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1019_b03b, 3); shl(eax, 0x3);                          /* shl eax, 0x3 */
            ii(0x1019_b03e, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1019_b040, 3); shl(eax, 0x3);                          /* shl eax, 0x3 */
            ii(0x1019_b043, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1019_b045, 2); mov(ebx, eax);                          /* mov ebx, eax */
            ii(0x1019_b047, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x1019_b04a, 2); add(eax, ebx);                          /* add eax, ebx */
            ii(0x1019_b04c, 2); mov(ebx, edi);                          /* mov ebx, edi */
            ii(0x1019_b04e, 2); sub(ebx, eax);                          /* sub ebx, eax */
            ii(0x1019_b050, 2); test(edx, edx);                         /* test edx, edx */
            ii(0x1019_b052, 2); if(jbe(0x1019_b05c, 0x8)) goto l_0x1019_b05c; /* jbe 0x1019b05c */
            ii(0x1019_b054, 3); lea(eax, memd[ds, edx - 0x1]);          /* lea eax, [edx-0x1] */
            ii(0x1019_b057, 3); shr(eax, 0x2);                          /* shr eax, 0x2 */
            ii(0x1019_b05a, 2); sub(ebx, eax);                          /* sub ebx, eax */
        l_0x1019_b05c:
            ii(0x1019_b05c, 6); lea(eax, memd[ds, edx + 0x76c]);        /* lea eax, [edx+0x76c] */
            ii(0x1019_b062, 5); call(/* sys */ 0x1019_ab72, -0x4f5);    /* call 0x1019ab72 */
            ii(0x1019_b067, 5); add(eax, 0x16d);                        /* add eax, 0x16d */
        l_0x1019_b06c:
            ii(0x1019_b06c, 2); cmp(ebx, eax);                          /* cmp ebx, eax */
            ii(0x1019_b06e, 2); if(jb(0x1019_b075, 0x5)) goto l_0x1019_b075; /* jb 0x1019b075 */
            ii(0x1019_b070, 1); inc(edx);                               /* inc edx */
            ii(0x1019_b071, 2); sub(ebx, eax);                          /* sub ebx, eax */
            ii(0x1019_b073, 2); jmp(0x1019_b06c, -0x9); goto l_0x1019_b06c; /* jmp 0x1019b06c */
        l_0x1019_b075:
            ii(0x1019_b075, 5); mov(esi, 0x101b_76cc);                  /* mov esi, 0x101b76cc */
            ii(0x1019_b07a, 3); mov(memd[ds, ecx + 0x14], edx);         /* mov [ecx+0x14], edx */
            ii(0x1019_b07d, 6); lea(eax, memd[ds, edx + 0x76c]);        /* lea eax, [edx+0x76c] */
            ii(0x1019_b083, 3); mov(memd[ds, ecx + 0x1c], ebx);         /* mov [ecx+0x1c], ebx */
            ii(0x1019_b086, 5); call(/* sys */ 0x1019_ab72, -0x519);    /* call 0x1019ab72 */
            ii(0x1019_b08b, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1019_b08d, 2); if(jz(0x1019_b094, 0x5)) goto l_0x1019_b094; /* jz 0x1019b094 */
            ii(0x1019_b08f, 5); mov(esi, 0x101b_76e6);                  /* mov esi, 0x101b76e6 */
        l_0x1019_b094:
            ii(0x1019_b094, 5); mov(ebp, 0x1f);                         /* mov ebp, 0x1f */
            ii(0x1019_b099, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x1019_b09b, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1019_b09d, 2); div(ebp);                               /* div ebp */
            ii(0x1019_b09f, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1019_b0a1, 3); mov(edx, memd[ds, esi + edx * 2]);      /* mov edx, [esi+edx*2] */
            ii(0x1019_b0a4, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1019_b0a7, 2); cmp(ebx, edx);                          /* cmp ebx, edx */
            ii(0x1019_b0a9, 2); if(jb(0x1019_b0ac, 0x1)) goto l_0x1019_b0ac; /* jb 0x1019b0ac */
            ii(0x1019_b0ab, 1); inc(eax);                               /* inc eax */
        l_0x1019_b0ac:
            ii(0x1019_b0ac, 3); mov(memd[ds, ecx + 0x10], eax);         /* mov [ecx+0x10], eax */
            ii(0x1019_b0af, 4); movsx(eax, memw[ds, esi + eax * 2]);    /* movsx eax, word [esi+eax*2] */
            ii(0x1019_b0b3, 2); sub(ebx, eax);                          /* sub ebx, eax */
            ii(0x1019_b0b5, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1019_b0b7, 1); inc(ebx);                               /* inc ebx */
            ii(0x1019_b0b8, 3); lea(eax, memd[ds, edi + 0x1]);          /* lea eax, [edi+0x1] */
            ii(0x1019_b0bb, 3); mov(memd[ds, ecx + 0xc], ebx);          /* mov [ecx+0xc], ebx */
            ii(0x1019_b0be, 5); mov(ebx, 0x7);                          /* mov ebx, 0x7 */
            ii(0x1019_b0c3, 2); div(ebx);                               /* div ebx */
            ii(0x1019_b0c5, 2); mov(eax, ecx);                          /* mov eax, ecx */
            ii(0x1019_b0c7, 3); mov(memd[ds, ecx + 0x18], edx);         /* mov [ecx+0x18], edx */
            ii(0x1019_b0ca, 1); pop(ebp);                               /* pop ebp */
            ii(0x1019_b0cb, 1); pop(edi);                               /* pop edi */
            ii(0x1019_b0cc, 1); pop(esi);                               /* pop esi */
            ii(0x1019_b0cd, 1); ret();                                  /* ret */
        }
    }
}
