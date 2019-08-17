using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("b53c9df9-7654-4b90-9a0c-2ae3558aa91b")]
        public void /* sys */ Method_1018_e840()
        {
            ii(0x1018_e840, 1); pushd(ebp);                             /* push ebp */
            ii(0x1018_e841, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1018_e843, 3); add(esp, -0x14 /* 0xec */);             /* add esp, 0xffffffec */
            ii(0x1018_e846, 1); pushd(esi);                             /* push esi */
            ii(0x1018_e847, 1); pushd(edi);                             /* push edi */
            ii(0x1018_e848, 1); pushd(ebx);                             /* push ebx */
            ii(0x1018_e849, 3); mov(ax, ds);                            /* mov ax, ds */
            ii(0x1018_e84c, 3); mov(es, ax);                            /* mov es, ax */
            ii(0x1018_e84f, 5); mov(eax, memd_a32[ds, 0x1020_9cd8]);    /* mov eax, [0x10209cd8] */
            ii(0x1018_e854, 6); sub(eax, memd_a32[ds, 0x1020_9cc8]);    /* sub eax, [0x10209cc8] */
            ii(0x1018_e85a, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1018_e85d, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x1018_e85f, 6); mov(bl, memb_a32[ds, 0x1020_9dd2]);     /* mov bl, [0x10209dd2] */
            ii(0x1018_e865, 3); mov(eax, memd_a32[ss, ebp + 0x10]);     /* mov eax, [ebp+0x10] */
            ii(0x1018_e868, 3); shl(eax, 0x3);                          /* shl eax, 0x3 */
            ii(0x1018_e86b, 5); mov(memd_a32[ds, 0x1020_9ce0], eax);    /* mov [0x10209ce0], eax */
            ii(0x1018_e870, 3); mov(eax, memd_a32[ss, ebp + 0x18]);     /* mov eax, [ebp+0x18] */
            ii(0x1018_e873, 3); shl(eax, 0x3);                          /* shl eax, 0x3 */
            ii(0x1018_e876, 5); mov(memd_a32[ds, 0x1020_9cdc], eax);    /* mov [0x10209cdc], eax */
            ii(0x1018_e87b, 3); mov(eax, memd_a32[ss, ebp + 0x14]);     /* mov eax, [ebp+0x14] */
            ii(0x1018_e87e, 3); shl(eax, 0x3);                          /* shl eax, 0x3 */
            ii(0x1018_e881, 2); mul(ebx);                               /* mul ebx */
            ii(0x1018_e883, 5); mov(memd_a32[ds, 0x1020_9ce4], eax);    /* mov [0x10209ce4], eax */
            ii(0x1018_e888, 3); mov(eax, memd_a32[ss, ebp + 0x1c]);     /* mov eax, [ebp+0x1c] */
            ii(0x1018_e88b, 3); shl(eax, 0x3);                          /* shl eax, 0x3 */
            ii(0x1018_e88e, 2); mul(ebx);                               /* mul ebx */
            ii(0x1018_e890, 5); mov(memd_a32[ds, 0x1020_9cd4], eax);    /* mov [0x10209cd4], eax */
            ii(0x1018_e895, 5); mov(eax, memd_a32[ds, 0x1020_9cc4]);    /* mov eax, [0x10209cc4] */
            ii(0x1018_e89a, 6); sub(eax, memd_a32[ds, 0x1020_9cdc]);    /* sub eax, [0x10209cdc] */
            ii(0x1018_e8a0, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1018_e8a3, 5); mov(eax, memd_a32[ds, 0x1020_9cc8]);    /* mov eax, [0x10209cc8] */
            ii(0x1018_e8a8, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1018_e8ab, 4); cmp(memd_a32[ss, ebp + 0x10], 0);       /* cmp dword [ebp+0x10], 0x0 */
            ii(0x1018_e8af, 2); if(jnzd(0x1018_e8b7, 0x6)) goto l_0x1018_e8b7; /* jnz 0x1018e8b7 */
            ii(0x1018_e8b1, 4); cmp(memd_a32[ss, ebp + 0x14], 0);       /* cmp dword [ebp+0x14], 0x0 */
            ii(0x1018_e8b5, 2); if(jzd(0x1018_e8cb, 0x14)) goto l_0x1018_e8cb; /* jz 0x1018e8cb */
        l_0x1018_e8b7:
            ii(0x1018_e8b7, 5); mov(eax, memd_a32[ds, 0x1020_9ce4]);    /* mov eax, [0x10209ce4] */
            ii(0x1018_e8bc, 6); mul(memd_a32[ds, 0x1020_9cd0]);         /* mul dword [0x10209cd0] */
            ii(0x1018_e8c2, 6); add(eax, memd_a32[ds, 0x1020_9ce0]);    /* add eax, [0x10209ce0] */
            ii(0x1018_e8c8, 3); add(memd_a32[ss, ebp - 0x4], eax);      /* add [ebp-0x4], eax */
        l_0x1018_e8cb:
            ii(0x1018_e8cb, 5); mov(eax, memd_a32[ds, 0x1020_9cec]);    /* mov eax, [0x10209cec] */
            ii(0x1018_e8d0, 3); sub(eax, 0x8);                          /* sub eax, 0x8 */
            ii(0x1018_e8d3, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x1018_e8d6, 3); mov(esi, memd_a32[ss, ebp + 0xc]);      /* mov esi, [ebp+0xc] */
            ii(0x1018_e8d9, 3); mov(edi, memd_a32[ss, ebp - 0x4]);      /* mov edi, [ebp-0x4] */
        }
    }
}
