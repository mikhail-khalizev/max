using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("815d263b-b124-4360-8e24-8e68df089e50")]
        public void /* sys */ Method_1018_e96c()
        {
            ii(0x1018_e96c, 3); mov(ax, memw_a32[ds, esi]);             /* mov ax, [esi] */
            ii(0x1018_e96f, 3); add(esi, 0x2);                          /* add esi, 0x2 */
            ii(0x1018_e972, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x1018_e974, 2); mov(bl, ah);                            /* mov bl, ah */
            ii(0x1018_e976, 3); shl(eax, 0x18);                         /* shl eax, 0x18 */
            ii(0x1018_e979, 3); sar(eax, 0x18);                         /* sar eax, 0x18 */
            ii(0x1018_e97c, 7); add(eax, memd_a32[ds, ebx * 4 + 0x101b_e8d0]); /* add eax, [ebx*4+0x101be8d0] */
            ii(0x1018_e983, 3); add(eax, memd_a32[ss, ebp - 0xc]);      /* add eax, [ebp-0xc] */
            ii(0x1018_e986, 2); jmpd(0x1018_e9b0, 0x28); goto l_0x1018_e9b0; /* jmp 0x1018e9b0 */
        //    ii(0x1018_e988, 3); add(esp, 0x4);                          /* add esp, 0x4 */
        //    ii(0x1018_e98b, 3); add(ebx, 0x2);                          /* add ebx, 0x2 */
        //    ii(0x1018_e98e, 2); mov(eax, eax);                          /* mov eax, eax */
        l_0x1018_e990:
            ii(0x1018_e990, 3); add(edi, 0x10);                         /* add edi, 0x10 */
            ii(0x1018_e993, 1); dec(ebx);                               /* dec ebx */
            ii(0x1018_e994, 2); if(jzd(0x1018_e9ac, 0x16)) goto l_0x1018_e9ac; /* jz 0x1018e9ac */
            ii(0x1018_e996, 3); dec(memd_a32[ss, ebp - 0x14]);          /* dec dword [ebp-0x14] */
            ii(0x1018_e999, 2); if(jnsd(0x1018_e990, -0xb)) goto l_0x1018_e990; /* jns 0x1018e990 */
            ii(0x1018_e99b, 3); add(edi, memd_a32[ss, ebp - 0x8]);      /* add edi, [ebp-0x8] */
            ii(0x1018_e99e, 3); dec(memd_a32[ss, ebp + 0x1c]);          /* dec dword [ebp+0x1c] */
            ii(0x1018_e9a1, 3); mov(eax, memd_a32[ss, ebp + 0x18]);     /* mov eax, [ebp+0x18] */
            ii(0x1018_e9a4, 2); shr(eax, 0x1);                          /* shr eax, 1 */
            ii(0x1018_e9a6, 1); dec(eax);                               /* dec eax */
            ii(0x1018_e9a7, 3); mov(memd_a32[ss, ebp - 0x14], eax);     /* mov [ebp-0x14], eax */
            ii(0x1018_e9aa, 2); jmpd(0x1018_e990, -0x1c); goto l_0x1018_e990; /* jmp 0x1018e990 */
        l_0x1018_e9ac:
            ii(0x1018_e9ac, 1); retd(); return;                         /* ret */
        //  ii(0x1018_e9ad, 3); Недостижимый (и не декодированный) код.
        l_0x1018_e9b0:
            ii(0x1018_e9b0, 2); mov(ebx, esi);                          /* mov ebx, esi */
            ii(0x1018_e9b2, 3); lea(esi, eax + edi);                    /* lea esi, [eax+edi] */
            ii(0x1018_e9b5, 6); mov(edx, memd_a32[ds, 0x1020_9cd0]);    /* mov edx, [0x10209cd0] */
            ii(0x1018_e9bb, 2); mov(eax, memd_a32[ds, esi]);            /* mov eax, [esi] */
            ii(0x1018_e9bd, 2); mov(memd_a32[ds, edi], eax);            /* mov [edi], eax */
            ii(0x1018_e9bf, 3); mov(eax, memd_a32[ds, esi + 0x4]);      /* mov eax, [esi+0x4] */
            ii(0x1018_e9c2, 3); mov(memd_a32[ds, edi + 0x4], eax);      /* mov [edi+0x4], eax */
            ii(0x1018_e9c5, 2); add(esi, edx);                          /* add esi, edx */
            ii(0x1018_e9c7, 2); add(edi, edx);                          /* add edi, edx */
            ii(0x1018_e9c9, 2); mov(eax, memd_a32[ds, esi]);            /* mov eax, [esi] */
            ii(0x1018_e9cb, 2); mov(memd_a32[ds, edi], eax);            /* mov [edi], eax */
            ii(0x1018_e9cd, 3); mov(eax, memd_a32[ds, esi + 0x4]);      /* mov eax, [esi+0x4] */
            ii(0x1018_e9d0, 3); mov(memd_a32[ds, edi + 0x4], eax);      /* mov [edi+0x4], eax */
            ii(0x1018_e9d3, 2); add(esi, edx);                          /* add esi, edx */
            ii(0x1018_e9d5, 2); add(edi, edx);                          /* add edi, edx */
            ii(0x1018_e9d7, 2); mov(eax, memd_a32[ds, esi]);            /* mov eax, [esi] */
            ii(0x1018_e9d9, 2); mov(memd_a32[ds, edi], eax);            /* mov [edi], eax */
            ii(0x1018_e9db, 3); mov(eax, memd_a32[ds, esi + 0x4]);      /* mov eax, [esi+0x4] */
            ii(0x1018_e9de, 3); mov(memd_a32[ds, edi + 0x4], eax);      /* mov [edi+0x4], eax */
            ii(0x1018_e9e1, 2); add(esi, edx);                          /* add esi, edx */
            ii(0x1018_e9e3, 2); add(edi, edx);                          /* add edi, edx */
            ii(0x1018_e9e5, 2); mov(eax, memd_a32[ds, esi]);            /* mov eax, [esi] */
            ii(0x1018_e9e7, 2); mov(memd_a32[ds, edi], eax);            /* mov [edi], eax */
            ii(0x1018_e9e9, 3); mov(eax, memd_a32[ds, esi + 0x4]);      /* mov eax, [esi+0x4] */
            ii(0x1018_e9ec, 3); mov(memd_a32[ds, edi + 0x4], eax);      /* mov [edi+0x4], eax */
            ii(0x1018_e9ef, 2); add(esi, edx);                          /* add esi, edx */
            ii(0x1018_e9f1, 2); add(edi, edx);                          /* add edi, edx */
            ii(0x1018_e9f3, 2); mov(eax, memd_a32[ds, esi]);            /* mov eax, [esi] */
            ii(0x1018_e9f5, 2); mov(memd_a32[ds, edi], eax);            /* mov [edi], eax */
            ii(0x1018_e9f7, 3); mov(eax, memd_a32[ds, esi + 0x4]);      /* mov eax, [esi+0x4] */
            ii(0x1018_e9fa, 3); mov(memd_a32[ds, edi + 0x4], eax);      /* mov [edi+0x4], eax */
            ii(0x1018_e9fd, 2); add(esi, edx);                          /* add esi, edx */
            ii(0x1018_e9ff, 2); add(edi, edx);                          /* add edi, edx */
            ii(0x1018_ea01, 2); mov(eax, memd_a32[ds, esi]);            /* mov eax, [esi] */
            ii(0x1018_ea03, 2); mov(memd_a32[ds, edi], eax);            /* mov [edi], eax */
            ii(0x1018_ea05, 3); mov(eax, memd_a32[ds, esi + 0x4]);      /* mov eax, [esi+0x4] */
            ii(0x1018_ea08, 3); mov(memd_a32[ds, edi + 0x4], eax);      /* mov [edi+0x4], eax */
            ii(0x1018_ea0b, 2); add(esi, edx);                          /* add esi, edx */
            ii(0x1018_ea0d, 2); add(edi, edx);                          /* add edi, edx */
            ii(0x1018_ea0f, 2); mov(eax, memd_a32[ds, esi]);            /* mov eax, [esi] */
            ii(0x1018_ea11, 2); mov(memd_a32[ds, edi], eax);            /* mov [edi], eax */
            ii(0x1018_ea13, 3); mov(eax, memd_a32[ds, esi + 0x4]);      /* mov eax, [esi+0x4] */
            ii(0x1018_ea16, 3); mov(memd_a32[ds, edi + 0x4], eax);      /* mov [edi+0x4], eax */
            ii(0x1018_ea19, 2); add(esi, edx);                          /* add esi, edx */
            ii(0x1018_ea1b, 2); add(edi, edx);                          /* add edi, edx */
            ii(0x1018_ea1d, 2); mov(eax, memd_a32[ds, esi]);            /* mov eax, [esi] */
            ii(0x1018_ea1f, 2); mov(memd_a32[ds, edi], eax);            /* mov [edi], eax */
            ii(0x1018_ea21, 3); mov(eax, memd_a32[ds, esi + 0x4]);      /* mov eax, [esi+0x4] */
            ii(0x1018_ea24, 3); mov(memd_a32[ds, edi + 0x4], eax);      /* mov [edi+0x4], eax */
            ii(0x1018_ea27, 3); sub(edi, memd_a32[ss, ebp - 0x10]);     /* sub edi, [ebp-0x10] */
            ii(0x1018_ea2a, 2); mov(esi, ebx);                          /* mov esi, ebx */
            ii(0x1018_ea2c, 1); retd(); return;                         /* ret */
        }
    }
}
