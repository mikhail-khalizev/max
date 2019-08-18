using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1019_3cae-f8ac2224")]
        public void /* sys */ Method_1019_3cae()
        {
            ii(0x1019_3cae, 1); pushd(ebp);                             /* push ebp */
            ii(0x1019_3caf, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1019_3cb1, 3); add(esp, -0x2c /* 0xd4 */);             /* add esp, 0xffffffd4 */
            ii(0x1019_3cb4, 1); pushd(esi);                             /* push esi */
            ii(0x1019_3cb5, 1); pushd(edi);                             /* push edi */
            ii(0x1019_3cb6, 1); pushd(ebx);                             /* push ebx */
            ii(0x1019_3cb7, 3); mov(ax, ds);                            /* mov ax, ds */
            ii(0x1019_3cba, 3); mov(es, ax);                            /* mov es, ax */
            ii(0x1019_3cbd, 3); mov(eax, memd_a32[ss, ebp + 0x14]);     /* mov eax, [ebp+0x14] */
            ii(0x1019_3cc0, 3); shl(eax, 0x4);                          /* shl eax, 0x4 */
            ii(0x1019_3cc3, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1019_3cc6, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x1019_3cc8, 6); mov(bl, memb_a32[ds, 0x1020_9dd2]);     /* mov bl, [0x10209dd2] */
            ii(0x1019_3cce, 5); mov(eax, memd_a32[ds, 0x1020_9cd0]);    /* mov eax, [0x10209cd0] */
            ii(0x1019_3cd3, 2); mul(ebx);                               /* mul ebx */
            ii(0x1019_3cd5, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1019_3cd8, 3); imul(eax, eax, 0x7);                    /* imul eax, eax, 0x7 */
            ii(0x1019_3cdb, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x1019_3cde, 3); add(eax, memd_a32[ss, ebp - 0x8]);      /* add eax, [ebp-0x8] */
            ii(0x1019_3ce1, 3); sub(eax, memd_a32[ss, ebp - 0x4]);      /* sub eax, [ebp-0x4] */
            ii(0x1019_3ce4, 3); mov(memd_a32[ss, ebp - 0x18], eax);     /* mov [ebp-0x18], eax */
            ii(0x1019_3ce7, 5); mov(eax, memd_a32[ds, Definitions.video_bytes_per_line]); /* mov eax, [0x10209c98] */
            ii(0x1019_3cec, 2); mul(ebx);                               /* mul ebx */
            ii(0x1019_3cee, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1019_3cf1, 3); imul(eax, eax, 0x7);                    /* imul eax, eax, 0x7 */
            ii(0x1019_3cf4, 3); mov(memd_a32[ss, ebp - 0x14], eax);     /* mov [ebp-0x14], eax */
            ii(0x1019_3cf7, 1); dec(eax);                               /* dec eax */
            ii(0x1019_3cf8, 3); mov(memd_a32[ss, ebp - 0x1c], eax);     /* mov [ebp-0x1c], eax */
            ii(0x1019_3cfb, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1019_3cfe, 3); sub(eax, memd_a32[ss, ebp - 0x4]);      /* sub eax, [ebp-0x4] */
            ii(0x1019_3d01, 1); inc(eax);                               /* inc eax */
            ii(0x1019_3d02, 3); mov(memd_a32[ss, ebp - 0x20], eax);     /* mov [ebp-0x20], eax */
            ii(0x1019_3d05, 3); mov(eax, memd_a32[ss, ebp - 0x1c]);     /* mov eax, [ebp-0x1c] */
            ii(0x1019_3d08, 3); add(eax, memd_a32[ss, ebp - 0x4]);      /* add eax, [ebp-0x4] */
            ii(0x1019_3d0b, 3); mov(memd_a32[ss, ebp - 0x24], eax);     /* mov [ebp-0x24], eax */
            ii(0x1019_3d0e, 4); cmp(memd_a32[ss, ebp + 0x8], 0);        /* cmp dword [ebp+0x8], 0x0 */
            ii(0x1019_3d12, 2); if(jzd(0x1019_3d1c, 0x8)) goto l_0x1019_3d1c; /* jz 0x10193d1c */
            ii(0x1019_3d14, 6); mov(esi, memd_a32[ds, 0x1020_9cd8]);    /* mov esi, [0x10209cd8] */
            ii(0x1019_3d1a, 2); jmpd(0x1019_3d22, 0x6); goto l_0x1019_3d22; /* jmp 0x10193d22 */
        l_0x1019_3d1c:
            ii(0x1019_3d1c, 6); mov(esi, memd_a32[ds, 0x1020_9cc8]);    /* mov esi, [0x10209cc8] */
        l_0x1019_3d22:
            ii(0x1019_3d22, 3); mov(eax, memd_a32[ss, ebp + 0x10]);     /* mov eax, [ebp+0x10] */
            ii(0x1019_3d25, 3); shl(eax, 0x3);                          /* shl eax, 0x3 */
            ii(0x1019_3d28, 6); mul(memd_a32[ds, 0x1020_9cd0]);         /* mul dword [0x10209cd0] */
            ii(0x1019_3d2e, 2); add(esi, eax);                          /* add esi, eax */
            ii(0x1019_3d30, 3); mov(eax, memd_a32[ss, ebp + 0xc]);      /* mov eax, [ebp+0xc] */
            ii(0x1019_3d33, 3); shl(eax, 0x4);                          /* shl eax, 0x4 */
            ii(0x1019_3d36, 2); add(esi, eax);                          /* add esi, eax */
            ii(0x1019_3d38, 4); and(memd_a32[ss, ebp + 0x20], -0x4 /* 0xfc */); /* and dword [ebp+0x20], 0xfffffffc */
            ii(0x1019_3d3c, 3); mov(ebx, memd_a32[ss, ebp + 0x1c]);     /* mov ebx, [ebp+0x1c] */
            ii(0x1019_3d3f, 4); mov(dx, 0);                             /* mov dx, 0x0 */
            ii(0x1019_3d43, 6); mov(cl, memb_a32[ds, 0x1020_9dd2]);     /* mov cl, [0x10209dd2] */
        }
    }
}
