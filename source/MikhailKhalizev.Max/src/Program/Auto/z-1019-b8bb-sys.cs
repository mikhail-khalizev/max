using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1019_b8bb-dcb4f3c3")]
        public void /* sys */ Method_1019_b8bb()
        {
            ii(0x1019_b8bb, 1); push(esi);                              /* push esi */
            ii(0x1019_b8bc, 2); mov(esi, ebx);                          /* mov esi, ebx */
            ii(0x1019_b8be, 2); test(ecx, ecx);                         /* test ecx, ecx */
            ii(0x1019_b8c0, 2); if(jnz(0x1019_b8d0, 0xe)) goto l_0x1019_b8d0; /* jnz 0x1019b8d0 */
            ii(0x1019_b8c2, 2); test(ebx, ebx);                         /* test ebx, ebx */
            ii(0x1019_b8c4, 2); if(jg(0x1019_b8d0, 0xa)) goto l_0x1019_b8d0; /* jg 0x1019b8d0 */
            ii(0x1019_b8c6, 3); mov(memb[ds, eax], 0x30);               /* mov byte [eax], 0x30 */
            ii(0x1019_b8c9, 1); inc(eax);                               /* inc eax */
            ii(0x1019_b8ca, 3); mov(memb[ds, eax], 0x2e);               /* mov byte [eax], 0x2e */
            ii(0x1019_b8cd, 1); inc(eax);                               /* inc eax */
            ii(0x1019_b8ce, 1); pop(esi);                               /* pop esi */
            ii(0x1019_b8cf, 1); ret(); return;                          /* ret */
        l_0x1019_b8d0:
            ii(0x1019_b8d0, 2); test(esi, esi);                         /* test esi, esi */
            ii(0x1019_b8d2, 2); if(jle(0x1019_b8e1, 0xd)) goto l_0x1019_b8e1; /* jle 0x1019b8e1 */
            ii(0x1019_b8d4, 2); mov(bl, memb[ds, edx]);                 /* mov bl, [edx] */
            ii(0x1019_b8d6, 2); test(bl, bl);                           /* test bl, bl */
            ii(0x1019_b8d8, 2); if(jz(0x1019_b8e1, 7)) goto l_0x1019_b8e1; /* jz 0x1019b8e1 */
            ii(0x1019_b8da, 1); inc(edx);                               /* inc edx */
            ii(0x1019_b8db, 1); dec(esi);                               /* dec esi */
            ii(0x1019_b8dc, 2); mov(memb[ds, eax], bl);                 /* mov [eax], bl */
            ii(0x1019_b8de, 1); inc(eax);                               /* inc eax */
            ii(0x1019_b8df, 2); jmp(0x1019_b8d0, -0x11); goto l_0x1019_b8d0; /* jmp 0x1019b8d0 */
        l_0x1019_b8e1:
            ii(0x1019_b8e1, 2); test(esi, esi);                         /* test esi, esi */
            ii(0x1019_b8e3, 2); if(jle(0x1019_b8ee, 9)) goto l_0x1019_b8ee; /* jle 0x1019b8ee */
        l_0x1019_b8e5:
            ii(0x1019_b8e5, 1); dec(esi);                               /* dec esi */
            ii(0x1019_b8e6, 3); mov(memb[ds, eax], 0x30);               /* mov byte [eax], 0x30 */
            ii(0x1019_b8e9, 1); inc(eax);                               /* inc eax */
            ii(0x1019_b8ea, 2); test(esi, esi);                         /* test esi, esi */
            ii(0x1019_b8ec, 2); if(jg(0x1019_b8e5, -9)) goto l_0x1019_b8e5; /* jg 0x1019b8e5 */
        l_0x1019_b8ee:
            ii(0x1019_b8ee, 3); mov(memb[ds, eax], 0x2e);               /* mov byte [eax], 0x2e */
            ii(0x1019_b8f1, 1); inc(eax);                               /* inc eax */
            ii(0x1019_b8f2, 2); test(ecx, ecx);                         /* test ecx, ecx */
            ii(0x1019_b8f4, 2); if(jle(0x1019_b902, 0xc)) goto l_0x1019_b902; /* jle 0x1019b902 */
        l_0x1019_b8f6:
            ii(0x1019_b8f6, 2); test(esi, esi);                         /* test esi, esi */
            ii(0x1019_b8f8, 2); if(jz(0x1019_b902, 8)) goto l_0x1019_b902; /* jz 0x1019b902 */
            ii(0x1019_b8fa, 1); inc(esi);                               /* inc esi */
            ii(0x1019_b8fb, 3); mov(memb[ds, eax], 0x30);               /* mov byte [eax], 0x30 */
            ii(0x1019_b8fe, 1); inc(eax);                               /* inc eax */
            ii(0x1019_b8ff, 1); dec(ecx);                               /* dec ecx */
            ii(0x1019_b900, 2); if(jnz(0x1019_b8f6, -0xc)) goto l_0x1019_b8f6; /* jnz 0x1019b8f6 */
        l_0x1019_b902:
            ii(0x1019_b902, 2); test(ecx, ecx);                         /* test ecx, ecx */
            ii(0x1019_b904, 2); if(jle_func(0x1019_b8b9, -0x4d)) return; /* jle 0x1019b8b9 */
        l_0x1019_b906:
            ii(0x1019_b906, 2); mov(bh, memb[ds, edx]);                 /* mov bh, [edx] */
            ii(0x1019_b908, 2); test(bh, bh);                           /* test bh, bh */
            ii(0x1019_b90a, 2); if(jz(0x1019_b913, 7)) goto l_0x1019_b913; /* jz 0x1019b913 */
            ii(0x1019_b90c, 1); inc(edx);                               /* inc edx */
            ii(0x1019_b90d, 2); mov(memb[ds, eax], bh);                 /* mov [eax], bh */
            ii(0x1019_b90f, 1); inc(eax);                               /* inc eax */
            ii(0x1019_b910, 1); dec(ecx);                               /* dec ecx */
            ii(0x1019_b911, 2); if(jnz(0x1019_b906, -0xd)) goto l_0x1019_b906; /* jnz 0x1019b906 */
        l_0x1019_b913:
            ii(0x1019_b913, 2); test(ecx, ecx);                         /* test ecx, ecx */
            ii(0x1019_b915, 2); if(jz_func(0x1019_b8b9, -0x5e)) return; /* jz 0x1019b8b9 */
            ii(0x1019_b917, 1); dec(ecx);                               /* dec ecx */
            ii(0x1019_b918, 3); mov(memb[ds, eax], 0x30);               /* mov byte [eax], 0x30 */
            ii(0x1019_b91b, 1); inc(eax);                               /* inc eax */
            ii(0x1019_b91c, 2); jmp(0x1019_b913, -0xb); goto l_0x1019_b913; /* jmp 0x1019b913 */
        }
    }
}
