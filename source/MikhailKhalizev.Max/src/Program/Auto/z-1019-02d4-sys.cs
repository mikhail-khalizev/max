using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1019_02d4-5313be1a")]
        public void /* sys */ Method_1019_02d4()
        {
            ii(0x1019_02d4, 1); push(ebp);                              /* push ebp */
            ii(0x1019_02d5, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1019_02d7, 3); add(esp, -0x14 /* 0xec */);             /* add esp, 0xffffffec */
            ii(0x1019_02da, 1); push(esi);                              /* push esi */
            ii(0x1019_02db, 1); push(edi);                              /* push edi */
            ii(0x1019_02dc, 1); push(ebx);                              /* push ebx */
            ii(0x1019_02dd, 3); mov(ax, ds);                            /* mov ax, ds */
            ii(0x1019_02e0, 3); mov(es, ax);                            /* mov es, ax */
            ii(0x1019_02e3, 5); mov(eax, memd[ds, 0x1020_9cd8]);        /* mov eax, [0x10209cd8] */
            ii(0x1019_02e8, 6); sub(eax, memd[ds, 0x1020_9cc8]);        /* sub eax, [0x10209cc8] */
            ii(0x1019_02ee, 3); mov(memd[ss, ebp - 0xc], eax);          /* mov [ebp-0xc], eax */
            ii(0x1019_02f1, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x1019_02f3, 6); mov(bl, memb[ds, 0x1020_9dd2]);         /* mov bl, [0x10209dd2] */
            ii(0x1019_02f9, 3); mov(eax, memd[ss, ebp + 0x10]);         /* mov eax, [ebp+0x10] */
            ii(0x1019_02fc, 3); shl(eax, 0x3);                          /* shl eax, 0x3 */
            ii(0x1019_02ff, 5); mov(memd[ds, 0x1020_9ce0], eax);        /* mov [0x10209ce0], eax */
            ii(0x1019_0304, 3); mov(eax, memd[ss, ebp + 0x18]);         /* mov eax, [ebp+0x18] */
            ii(0x1019_0307, 3); shl(eax, 0x3);                          /* shl eax, 0x3 */
            ii(0x1019_030a, 5); mov(memd[ds, 0x1020_9cdc], eax);        /* mov [0x10209cdc], eax */
            ii(0x1019_030f, 3); mov(eax, memd[ss, ebp + 0x14]);         /* mov eax, [ebp+0x14] */
            ii(0x1019_0312, 3); shl(eax, 0x3);                          /* shl eax, 0x3 */
            ii(0x1019_0315, 2); mul(ebx);                               /* mul ebx */
            ii(0x1019_0317, 5); mov(memd[ds, 0x1020_9ce4], eax);        /* mov [0x10209ce4], eax */
            ii(0x1019_031c, 3); mov(eax, memd[ss, ebp + 0x1c]);         /* mov eax, [ebp+0x1c] */
            ii(0x1019_031f, 3); shl(eax, 0x3);                          /* shl eax, 0x3 */
            ii(0x1019_0322, 2); mul(ebx);                               /* mul ebx */
            ii(0x1019_0324, 5); mov(memd[ds, 0x1020_9cd4], eax);        /* mov [0x10209cd4], eax */
            ii(0x1019_0329, 5); mov(eax, memd[ds, 0x1020_9cc4]);        /* mov eax, [0x10209cc4] */
            ii(0x1019_032e, 6); sub(eax, memd[ds, 0x1020_9cdc]);        /* sub eax, [0x10209cdc] */
            ii(0x1019_0334, 3); mov(memd[ss, ebp - 0x8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1019_0337, 5); mov(eax, memd[ds, 0x1020_9cc8]);        /* mov eax, [0x10209cc8] */
            ii(0x1019_033c, 3); mov(memd[ss, ebp - 0x4], eax);          /* mov [ebp-0x4], eax */
            ii(0x1019_033f, 4); cmp(memd[ss, ebp + 0x10], 0);           /* cmp dword [ebp+0x10], 0x0 */
            ii(0x1019_0343, 2); if(jnz(0x1019_034b, 0x6)) goto l_0x1019_034b; /* jnz 0x1019034b */
            ii(0x1019_0345, 4); cmp(memd[ss, ebp + 0x14], 0);           /* cmp dword [ebp+0x14], 0x0 */
            ii(0x1019_0349, 2); if(jz(0x1019_035f, 0x14)) goto l_0x1019_035f; /* jz 0x1019035f */
        l_0x1019_034b:
            ii(0x1019_034b, 5); mov(eax, memd[ds, 0x1020_9ce4]);        /* mov eax, [0x10209ce4] */
            ii(0x1019_0350, 6); mul(memd[ds, 0x1020_9cd0]);             /* mul dword [0x10209cd0] */
            ii(0x1019_0356, 6); add(eax, memd[ds, 0x1020_9ce0]);        /* add eax, [0x10209ce0] */
            ii(0x1019_035c, 3); add(memd[ss, ebp - 0x4], eax);          /* add [ebp-0x4], eax */
        l_0x1019_035f:
            ii(0x1019_035f, 5); mov(eax, memd[ds, 0x1020_9cd0]);        /* mov eax, [0x10209cd0] */
            ii(0x1019_0364, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x1019_0367, 6); sub(eax, memd[ds, 0x1020_9cdc]);        /* sub eax, [0x10209cdc] */
            ii(0x1019_036d, 3); mov(memd[ss, ebp - 0x8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1019_0370, 6); shr(memd[ds, 0x1020_9cd4], 0x1);        /* shr dword [0x10209cd4], 1 */
            ii(0x1019_0376, 5); mov(eax, memd[ds, 0x1020_9cd0]);        /* mov eax, [0x10209cd0] */
            ii(0x1019_037b, 4); lea(eax, memd[ds, eax + eax * 2 - 0x8]); /* lea eax, [eax+eax*2-0x8] */
            ii(0x1019_037f, 3); mov(memd[ss, ebp - 0x10], eax);         /* mov [ebp-0x10], eax */
            ii(0x1019_0382, 3); mov(esi, memd[ss, ebp + 0xc]);          /* mov esi, [ebp+0xc] */
            ii(0x1019_0385, 3); mov(edi, memd[ss, ebp - 0x4]);          /* mov edi, [ebp-0x4] */
        l_0x1019_0388:
            ii(0x1019_0388, 3); mov(eax, memd[ss, ebp + 0x18]);         /* mov eax, [ebp+0x18] */
            ii(0x1019_038b, 2); shr(eax, 0x1);                          /* shr eax, 1 */
            ii(0x1019_038d, 3); mov(memd[ss, ebp - 0x14], eax);         /* mov [ebp-0x14], eax */
            ii(0x1019_0390, 3); dec(memd[ss, ebp - 0x14]);              /* dec dword [ebp-0x14] */
            ii(0x1019_0393, 2); if(js(0x1019_03bb, 0x26)) goto l_0x1019_03bb; /* js 0x101903bb */
            ii(0x1019_0395, 3); mov(ebx, memd[ss, ebp + 0x8]);          /* mov ebx, [ebp+0x8] */
            ii(0x1019_0398, 2); mov(al, memb[ds, ebx]);                 /* mov al, [ebx] */
            ii(0x1019_039a, 1); inc(ebx);                               /* inc ebx */
            ii(0x1019_039b, 3); mov(memd[ss, ebp + 0x8], ebx);          /* mov [ebp+0x8], ebx */
            ii(0x1019_039e, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x1019_03a0, 2); mov(bl, al);                            /* mov bl, al */
            ii(0x1019_03a2, 3); shr(bl, 0x4);                           /* shr bl, 0x4 */
            ii(0x1019_03a5, 3); and(eax, 0xf);                          /* and eax, 0xf */
            ii(0x1019_03a8, 5); push(/* sys */ 0x1019_0390);            /* push 0x10190390 */
            ii(0x1019_03ad, 7); push(memd[ds, ebx * 4 + 0x101b_f950]);  /* push dword [ebx*4+0x101bf950] */
            ii(0x1019_03b4, 7); if(jmp_abs(memd[ds, eax * 4 + 0x101b_f950])) return; /* jmp dword [eax*4+0x101bf950] */
        l_0x1019_03bb:
            ii(0x1019_03bb, 3); add(edi, memd[ss, ebp - 0x8]);          /* add edi, [ebp-0x8] */
            ii(0x1019_03be, 3); dec(memd[ss, ebp + 0x1c]);              /* dec dword [ebp+0x1c] */
            ii(0x1019_03c1, 2); if(jnz(0x1019_0388, -0x3b)) goto l_0x1019_0388; /* jnz 0x10190388 */
            ii(0x1019_03c3, 1); pop(ebx);                               /* pop ebx */
            ii(0x1019_03c4, 1); pop(edi);                               /* pop edi */
            ii(0x1019_03c5, 1); pop(esi);                               /* pop esi */
            ii(0x1019_03c6, 1); leave();                                /* leave */
            ii(0x1019_03c7, 1); ret();                                  /* ret */
        }
    }
}
