using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1019_1444-88695b7b")]
        public void /* sys */ Method_1019_1444()
        {
            ii(0x1019_1444, 1); push(ebp);                              /* push ebp */
            ii(0x1019_1445, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1019_1447, 3); add(esp, -0x18 /* 0xe8 */);             /* add esp, 0xffffffe8 */
            ii(0x1019_144a, 1); push(esi);                              /* push esi */
            ii(0x1019_144b, 1); push(edi);                              /* push edi */
            ii(0x1019_144c, 1); push(ebx);                              /* push ebx */
            ii(0x1019_144d, 3); mov(ax, ds);                            /* mov ax, ds */
            ii(0x1019_1450, 3); mov(es, ax);                            /* mov es, ax */
            ii(0x1019_1453, 5); mov(eax, memd[ds, 0x1020_9cd8]);        /* mov eax, [0x10209cd8] */
            ii(0x1019_1458, 6); sub(eax, memd[ds, 0x1020_9cc8]);        /* sub eax, [0x10209cc8] */
            ii(0x1019_145e, 3); mov(memd[ss, ebp - 0xc], eax);          /* mov [ebp-0xc], eax */
            ii(0x1019_1461, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x1019_1463, 6); mov(bl, memb[ds, 0x1020_9dd2]);         /* mov bl, [0x10209dd2] */
            ii(0x1019_1469, 3); mov(eax, memd[ss, ebp + 0x10]);         /* mov eax, [ebp+0x10] */
            ii(0x1019_146c, 3); shl(eax, 4);                            /* shl eax, 0x4 */
            ii(0x1019_146f, 5); mov(memd[ds, 0x1020_9ce0], eax);        /* mov [0x10209ce0], eax */
            ii(0x1019_1474, 3); mov(eax, memd[ss, ebp + 0x18]);         /* mov eax, [ebp+0x18] */
            ii(0x1019_1477, 3); shl(eax, 4);                            /* shl eax, 0x4 */
            ii(0x1019_147a, 5); mov(memd[ds, 0x1020_9cdc], eax);        /* mov [0x10209cdc], eax */
            ii(0x1019_147f, 3); mov(eax, memd[ss, ebp + 0x14]);         /* mov eax, [ebp+0x14] */
            ii(0x1019_1482, 3); shl(eax, 3);                            /* shl eax, 0x3 */
            ii(0x1019_1485, 2); mul(ebx);                               /* mul ebx */
            ii(0x1019_1487, 5); mov(memd[ds, 0x1020_9ce4], eax);        /* mov [0x10209ce4], eax */
            ii(0x1019_148c, 3); mov(eax, memd[ss, ebp + 0x1c]);         /* mov eax, [ebp+0x1c] */
            ii(0x1019_148f, 3); shl(eax, 3);                            /* shl eax, 0x3 */
            ii(0x1019_1492, 2); mul(ebx);                               /* mul ebx */
            ii(0x1019_1494, 5); mov(memd[ds, 0x1020_9cd4], eax);        /* mov [0x10209cd4], eax */
            ii(0x1019_1499, 5); mov(eax, memd[ds, 0x1020_9cc4]);        /* mov eax, [0x10209cc4] */
            ii(0x1019_149e, 6); sub(eax, memd[ds, 0x1020_9cdc]);        /* sub eax, [0x10209cdc] */
            ii(0x1019_14a4, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x1019_14a7, 5); mov(eax, memd[ds, 0x1020_9cc8]);        /* mov eax, [0x10209cc8] */
            ii(0x1019_14ac, 3); mov(memd[ss, ebp - 4], eax);            /* mov [ebp-0x4], eax */
            ii(0x1019_14af, 4); cmp(memd[ss, ebp + 0x10], 0);           /* cmp dword [ebp+0x10], 0x0 */
            ii(0x1019_14b3, 2); if(jnz(0x1019_14bb, 6)) goto l_0x1019_14bb; /* jnz 0x101914bb */
            ii(0x1019_14b5, 4); cmp(memd[ss, ebp + 0x14], 0);           /* cmp dword [ebp+0x14], 0x0 */
            ii(0x1019_14b9, 2); if(jz(0x1019_14cf, 0x14)) goto l_0x1019_14cf; /* jz 0x101914cf */
        l_0x1019_14bb:
            ii(0x1019_14bb, 5); mov(eax, memd[ds, 0x1020_9ce4]);        /* mov eax, [0x10209ce4] */
            ii(0x1019_14c0, 6); mul(memd[ds, 0x1020_9cd0]);             /* mul dword [0x10209cd0] */
            ii(0x1019_14c6, 6); add(eax, memd[ds, 0x1020_9ce0]);        /* add eax, [0x10209ce0] */
            ii(0x1019_14cc, 3); add(memd[ss, ebp - 4], eax);            /* add [ebp-0x4], eax */
        l_0x1019_14cf:
            ii(0x1019_14cf, 5); mov(eax, memd[ds, 0x1020_9cec]);        /* mov eax, [0x10209cec] */
            ii(0x1019_14d4, 3); sub(eax, 0x10);                         /* sub eax, 0x10 */
            ii(0x1019_14d7, 3); mov(memd[ss, ebp - 0x10], eax);         /* mov [ebp-0x10], eax */
            ii(0x1019_14da, 3); mov(esi, memd[ss, ebp + 0xc]);          /* mov esi, [ebp+0xc] */
            ii(0x1019_14dd, 3); mov(edi, memd[ss, ebp - 4]);            /* mov edi, [ebp-0x4] */
            ii(0x1019_14e0, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1019_14e2, 3); mov(ax, memw[ds, esi]);                 /* mov ax, [esi] */
            ii(0x1019_14e5, 2); add(eax, esi);                          /* add eax, esi */
            ii(0x1019_14e7, 3); mov(memd[ss, ebp - 0x18], eax);         /* mov [ebp-0x18], eax */
            ii(0x1019_14ea, 3); add(esi, 2);                            /* add esi, 0x2 */
        l_0x1019_14ed:
            ii(0x1019_14ed, 3); mov(eax, memd[ss, ebp + 0x18]);         /* mov eax, [ebp+0x18] */
            ii(0x1019_14f0, 2); shr(eax, 1);                            /* shr eax, 1 */
            ii(0x1019_14f2, 3); mov(memd[ss, ebp - 0x14], eax);         /* mov [ebp-0x14], eax */
            ii(0x1019_14f5, 3); mov(eax, eax);                          /* mov eax, eax */
            ii(0x1019_14f8, 3); dec(memd[ss, ebp - 0x14]);              /* dec dword [ebp-0x14] */
            ii(0x1019_14fb, 2); if(js(0x1019_1523, 0x26)) goto l_0x1019_1523; /* js 0x10191523 */
            ii(0x1019_14fd, 3); mov(ebx, memd[ss, ebp + 8]);            /* mov ebx, [ebp+0x8] */
            ii(0x1019_1500, 2); mov(al, memb[ds, ebx]);                 /* mov al, [ebx] */
            ii(0x1019_1502, 1); inc(ebx);                               /* inc ebx */
            ii(0x1019_1503, 3); mov(memd[ss, ebp + 8], ebx);            /* mov [ebp+0x8], ebx */
            ii(0x1019_1506, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x1019_1508, 2); mov(bl, al);                            /* mov bl, al */
            ii(0x1019_150a, 3); shr(bl, 4);                             /* shr bl, 0x4 */
            ii(0x1019_150d, 3); and(eax, 0xf);                          /* and eax, 0xf */
            ii(0x1019_1510, 5); push(/* sys */ 0x1019_14f8);            /* push 0x101914f8 */
            ii(0x1019_1515, 7); push(memd[ds, ebx * 4 + 0x101c_01d0]);  /* push dword [ebx*4+0x101c01d0] */
            ii(0x1019_151c, 7); if(jmp_abs(memd[ds, eax * 4 + 0x101c_01d0])) return; /* jmp dword [eax*4+0x101c01d0] */
        l_0x1019_1523:
            ii(0x1019_1523, 3); add(edi, memd[ss, ebp - 8]);            /* add edi, [ebp-0x8] */
            ii(0x1019_1526, 3); dec(memd[ss, ebp + 0x1c]);              /* dec dword [ebp+0x1c] */
            ii(0x1019_1529, 2); if(jnz(0x1019_14ed, -0x3e)) goto l_0x1019_14ed; /* jnz 0x101914ed */
            ii(0x1019_152b, 1); pop(ebx);                               /* pop ebx */
            ii(0x1019_152c, 1); pop(edi);                               /* pop edi */
            ii(0x1019_152d, 1); pop(esi);                               /* pop esi */
            ii(0x1019_152e, 1); leave();                                /* leave */
            ii(0x1019_152f, 1); ret();                                  /* ret */
        }
    }
}
