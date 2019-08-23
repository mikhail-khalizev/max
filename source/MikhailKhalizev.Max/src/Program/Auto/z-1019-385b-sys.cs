using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1019_385b-ec85784")]
        public void /* sys */ Method_1019_385b()
        {
            ii(0x1019_385b, 1); push(ebp);                              /* push ebp */
            ii(0x1019_385c, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1019_385e, 3); add(esp, -0x2c /* 0xd4 */);             /* add esp, 0xffffffd4 */
            ii(0x1019_3861, 1); push(esi);                              /* push esi */
            ii(0x1019_3862, 1); push(edi);                              /* push edi */
            ii(0x1019_3863, 1); push(ebx);                              /* push ebx */
            ii(0x1019_3864, 3); mov(ax, ds);                            /* mov ax, ds */
            ii(0x1019_3867, 3); mov(es, ax);                            /* mov es, ax */
            ii(0x1019_386a, 3); mov(eax, memd[ss, ebp + 0x14]);         /* mov eax, [ebp+0x14] */
            ii(0x1019_386d, 3); shl(eax, 0x3);                          /* shl eax, 0x3 */
            ii(0x1019_3870, 3); mov(memd[ss, ebp - 0x4], eax);          /* mov [ebp-0x4], eax */
            ii(0x1019_3873, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x1019_3875, 6); mov(bl, memb[ds, 0x1020_9dd2]);         /* mov bl, [0x10209dd2] */
            ii(0x1019_387b, 5); mov(eax, memd[ds, 0x1020_9cd0]);        /* mov eax, [0x10209cd0] */
            ii(0x1019_3880, 2); mul(ebx);                               /* mul ebx */
            ii(0x1019_3882, 3); mov(memd[ss, ebp - 0x8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1019_3885, 3); imul(eax, eax, 0x7);                    /* imul eax, eax, 0x7 */
            ii(0x1019_3888, 3); mov(memd[ss, ebp - 0x10], eax);         /* mov [ebp-0x10], eax */
            ii(0x1019_388b, 3); add(eax, memd[ss, ebp - 0x8]);          /* add eax, [ebp-0x8] */
            ii(0x1019_388e, 3); sub(eax, memd[ss, ebp - 0x4]);          /* sub eax, [ebp-0x4] */
            ii(0x1019_3891, 3); mov(memd[ss, ebp - 0x18], eax);         /* mov [ebp-0x18], eax */
            ii(0x1019_3894, 5); mov(eax, memd[ds, Definitions.video_bytes_per_line]); /* mov eax, [0x10209c98] */
            ii(0x1019_3899, 2); mul(ebx);                               /* mul ebx */
            ii(0x1019_389b, 3); mov(memd[ss, ebp - 0xc], eax);          /* mov [ebp-0xc], eax */
            ii(0x1019_389e, 3); imul(eax, eax, 0x7);                    /* imul eax, eax, 0x7 */
            ii(0x1019_38a1, 3); mov(memd[ss, ebp - 0x14], eax);         /* mov [ebp-0x14], eax */
            ii(0x1019_38a4, 1); dec(eax);                               /* dec eax */
            ii(0x1019_38a5, 3); mov(memd[ss, ebp - 0x1c], eax);         /* mov [ebp-0x1c], eax */
            ii(0x1019_38a8, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x1019_38ab, 3); sub(eax, memd[ss, ebp - 0x4]);          /* sub eax, [ebp-0x4] */
            ii(0x1019_38ae, 1); inc(eax);                               /* inc eax */
            ii(0x1019_38af, 3); mov(memd[ss, ebp - 0x20], eax);         /* mov [ebp-0x20], eax */
            ii(0x1019_38b2, 3); mov(eax, memd[ss, ebp - 0x1c]);         /* mov eax, [ebp-0x1c] */
            ii(0x1019_38b5, 3); add(eax, memd[ss, ebp - 0x4]);          /* add eax, [ebp-0x4] */
            ii(0x1019_38b8, 3); mov(memd[ss, ebp - 0x24], eax);         /* mov [ebp-0x24], eax */
            ii(0x1019_38bb, 4); cmp(memd[ss, ebp + 0x8], 0);            /* cmp dword [ebp+0x8], 0x0 */
            ii(0x1019_38bf, 2); if(jz(0x1019_38c9, 0x8)) goto l_0x1019_38c9; /* jz 0x101938c9 */
            ii(0x1019_38c1, 6); mov(esi, memd[ds, 0x1020_9cd8]);        /* mov esi, [0x10209cd8] */
            ii(0x1019_38c7, 2); jmp(0x1019_38cf, 0x6); goto l_0x1019_38cf; /* jmp 0x101938cf */
        l_0x1019_38c9:
            ii(0x1019_38c9, 6); mov(esi, memd[ds, 0x1020_9cc8]);        /* mov esi, [0x10209cc8] */
        l_0x1019_38cf:
            ii(0x1019_38cf, 3); mov(eax, memd[ss, ebp + 0x10]);         /* mov eax, [ebp+0x10] */
            ii(0x1019_38d2, 3); shl(eax, 0x3);                          /* shl eax, 0x3 */
            ii(0x1019_38d5, 6); mul(memd[ds, 0x1020_9cd0]);             /* mul dword [0x10209cd0] */
            ii(0x1019_38db, 2); add(esi, eax);                          /* add esi, eax */
            ii(0x1019_38dd, 3); mov(eax, memd[ss, ebp + 0xc]);          /* mov eax, [ebp+0xc] */
            ii(0x1019_38e0, 3); shl(eax, 0x3);                          /* shl eax, 0x3 */
            ii(0x1019_38e3, 2); add(esi, eax);                          /* add esi, eax */
            ii(0x1019_38e5, 4); and(memd[ss, ebp + 0x20], -0x4 /* 0xfc */); /* and dword [ebp+0x20], 0xfffffffc */
            ii(0x1019_38e9, 3); mov(ebx, memd[ss, ebp + 0x1c]);         /* mov ebx, [ebp+0x1c] */
            ii(0x1019_38ec, 4); mov(dx, 0);                             /* mov dx, 0x0 */
            ii(0x1019_38f0, 6); mov(cl, memb[ds, 0x1020_9dd2]);         /* mov cl, [0x10209dd2] */
        }
    }
}
