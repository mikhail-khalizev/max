using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1019_b3fb-e0909181")]
        public void /* sys */ Method_1019_b3fb()
        {
            ii(0x1019_b3fb, 5); mov(ebx, 0x1);                          /* mov ebx, 0x1 */
            ii(0x1019_b400, 5); mov(edx, 0x101c_1ccb);                  /* mov edx, 0x101c1ccb */
            ii(0x1019_b405, 5); mov(eax, memd[ds, 0x101c_1ca0]);        /* mov eax, [0x101c1ca0] */
            ii(0x1019_b40a, 6); mov(memd[ds, 0x101c_1ca8], ebx);        /* mov [0x101c1ca8], ebx */
            ii(0x1019_b410, 5); sub(eax, 0xe10);                        /* sub eax, 0xe10 */
            ii(0x1019_b415, 2); mov(ebx, esp);                          /* mov ebx, esp */
            ii(0x1019_b417, 3); mov(memd[ss, esp], eax);                /* mov [esp], eax */
            ii(0x1019_b41a, 2); mov(eax, ecx);                          /* mov eax, ecx */
            ii(0x1019_b41c, 5); call(/* sys */ 0x1019_b1ce, -0x253);    /* call 0x1019b1ce */
            ii(0x1019_b421, 3); mov(ecx, memd[ss, esp]);                /* mov ecx, [esp] */
            ii(0x1019_b424, 6); mov(ebx, memd[ds, 0x101c_1ca0]);        /* mov ebx, [0x101c1ca0] */
            ii(0x1019_b42a, 2); sub(ebx, ecx);                          /* sub ebx, ecx */
            ii(0x1019_b42c, 6); mov(memd[ds, 0x101c_1ca4], ebx);        /* mov [0x101c1ca4], ebx */
            ii(0x1019_b432, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x1019_b434, 2); mov(bl, memb[ds, eax]);                 /* mov bl, [eax] */
            ii(0x1019_b436, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1019_b438, 3); cmp(ebx, 0x2c);                         /* cmp ebx, 0x2c */
            ii(0x1019_b43b, 2); if(jnz(0x1019_b44a, 0xd)) goto l_0x1019_b44a; /* jnz 0x1019b44a */
            ii(0x1019_b43d, 5); mov(edx, 0x101c_1c58);                  /* mov edx, 0x101c1c58 */
            ii(0x1019_b442, 1); inc(eax);                               /* inc eax */
            ii(0x1019_b443, 5); call(/* sys */ 0x1019_b2f7, -0x151);    /* call 0x1019b2f7 */
            ii(0x1019_b448, 2); mov(edx, eax);                          /* mov edx, eax */
        l_0x1019_b44a:
            ii(0x1019_b44a, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1019_b44c, 2); mov(al, memb[ds, edx]);                 /* mov al, [edx] */
            ii(0x1019_b44e, 3); cmp(eax, 0x2c);                         /* cmp eax, 0x2c */
            ii(0x1019_b451, 2); if(jnz_func(0x1019_b4bf, 0x6c)) return; /* jnz 0x1019b4bf */
            ii(0x1019_b453, 3); lea(eax, memd[ds, edx + 0x1]);          /* lea eax, [edx+0x1] */
            ii(0x1019_b456, 5); mov(edx, 0x101c_1c7c);                  /* mov edx, 0x101c1c7c */
            ii(0x1019_b45b, 5); call(/* sys */ 0x1019_b2f7, -0x169);    /* call 0x1019b2f7 */
            ii(0x1019_b460, 5); mov(eax, memd[ds, 0x101c_1ca4]);        /* mov eax, [0x101c1ca4] */
            ii(0x1019_b465, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1019_b467, 5); mov(ebx, 0xe10);                        /* mov ebx, 0xe10 */
            ii(0x1019_b46c, 3); sar(edx, 0x1f);                         /* sar edx, 0x1f */
            ii(0x1019_b46f, 2); idiv(ebx);                              /* idiv ebx */
            ii(0x1019_b471, 6); mov(esi, memd[ds, 0x101c_1c84]);        /* mov esi, [0x101c1c84] */
            ii(0x1019_b477, 2); sub(esi, eax);                          /* sub esi, eax */
            ii(0x1019_b479, 5); mov(eax, memd[ds, 0x101c_1ca4]);        /* mov eax, [0x101c1ca4] */
            ii(0x1019_b47e, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1019_b480, 5); mov(ebx, 0x3c);                         /* mov ebx, 0x3c */
            ii(0x1019_b485, 3); sar(edx, 0x1f);                         /* sar edx, 0x1f */
            ii(0x1019_b488, 2); idiv(ebx);                              /* idiv ebx */
            ii(0x1019_b48a, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1019_b48c, 3); sar(edx, 0x1f);                         /* sar edx, 0x1f */
            ii(0x1019_b48f, 2); idiv(ebx);                              /* idiv ebx */
            ii(0x1019_b491, 6); mov(edi, memd[ds, 0x101c_1c80]);        /* mov edi, [0x101c1c80] */
            ii(0x1019_b497, 5); mov(eax, memd[ds, 0x101c_1ca4]);        /* mov eax, [0x101c1ca4] */
            ii(0x1019_b49c, 2); sub(edi, edx);                          /* sub edi, edx */
            ii(0x1019_b49e, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1019_b4a0, 3); sar(edx, 0x1f);                         /* sar edx, 0x1f */
            ii(0x1019_b4a3, 2); idiv(ebx);                              /* idiv ebx */
            ii(0x1019_b4a5, 6); mov(ebp, memd[ds, 0x101c_1c7c]);        /* mov ebp, [0x101c1c7c] */
            ii(0x1019_b4ab, 6); mov(memd[ds, 0x101c_1c84], esi);        /* mov [0x101c1c84], esi */
            ii(0x1019_b4b1, 2); sub(ebp, edx);                          /* sub ebp, edx */
            ii(0x1019_b4b3, 6); mov(memd[ds, 0x101c_1c80], edi);        /* mov [0x101c1c80], edi */
            ii(0x1019_b4b9, 6); mov(memd[ds, 0x101c_1c7c], ebp);        /* mov [0x101c1c7c], ebp */
        }
    }
}
