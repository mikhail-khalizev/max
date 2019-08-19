using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1018_e95c-70526aec")]
        public void /* sys */ Method_1018_e95c()
        {
            ii(0x1018_e95c, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1018_e95e, 2); mov(al, memb_a32[ds, esi]);             /* mov al, [esi] */
            ii(0x1018_e960, 1); inc(esi);                               /* inc esi */
            ii(0x1018_e961, 8); mov(ax, memw_a32[ds, eax * 2 + 0x101b_ecd0]); /* mov ax, [eax*2+0x101becd0] */
            ii(0x1018_e969, 2); jmpd(0x1018_e972, 0x7); goto l_0x1018_e972; /* jmp 0x1018e972 */
        //  ii(0x1018_e96b, 7); Недостижимый код.
        l_0x1018_e972:
            ii(0x1018_e972, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x1018_e974, 2); mov(bl, ah);                            /* mov bl, ah */
            ii(0x1018_e976, 3); shl(eax, 0x18);                         /* shl eax, 0x18 */
            ii(0x1018_e979, 3); sar(eax, 0x18);                         /* sar eax, 0x18 */
            ii(0x1018_e97c, 7); add(eax, memd_a32[ds, ebx * 4 + 0x101b_e8d0]); /* add eax, [ebx*4+0x101be8d0] */
            ii(0x1018_e983, 3); add(eax, memd_a32[ss, ebp - 0xc]);      /* add eax, [ebp-0xc] */
            ii(0x1018_e986, 2); jmpd(0x1018_e9b0, 0x28); goto l_0x1018_e9b0; /* jmp 0x1018e9b0 */
        //  ii(0x1018_e988, 40); Недостижимый код.
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
