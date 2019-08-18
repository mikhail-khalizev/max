using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1019_5726-a4a6e0db")]
        public void /* sys */ Method_1019_5726()
        {
            ii(0x1019_5726, 1); pushd(ebx);                             /* push ebx */
            ii(0x1019_5727, 1); pushd(ecx);                             /* push ecx */
            ii(0x1019_5728, 1); pushd(edx);                             /* push edx */
            ii(0x1019_5729, 1); pushd(esi);                             /* push esi */
            ii(0x1019_572a, 1); pushd(edi);                             /* push edi */
            ii(0x1019_572b, 1); pushd(ebp);                             /* push ebp */
            ii(0x1019_572c, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1019_572e, 6); sub(esp, 0x10);                         /* sub esp, 0x10 */
            ii(0x1019_5734, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1019_5737, 4); cmp(memd_a32[ss, ebp - 0x8], 0x5);      /* cmp dword [ebp-0x8], 0x5 */
            ii(0x1019_573b, 2); if(jbed(0x1019_5749, 0xc)) goto l_0x1019_5749; /* jbe 0x10195749 */
            ii(0x1019_573d, 7); mov(memd_a32[ss, ebp - 0x4], 0xa);      /* mov dword [ebp-0x4], 0xa */
            ii(0x1019_5744, 5); jmpd(0x1019_57c4, 0x7b); goto l_0x1019_57c4; /* jmp 0x101957c4 */
        l_0x1019_5749:
            ii(0x1019_5749, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1019_574c, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x1019_574f, 7); cmp(memd_a32[ds, eax + 0x101c_02b0], 0); /* cmp dword [eax+0x101c02b0], 0x0 */
            ii(0x1019_5756, 2); if(jnzd(0x1019_5761, 0x9)) goto l_0x1019_5761; /* jnz 0x10195761 */
            ii(0x1019_5758, 7); mov(memd_a32[ss, ebp - 0x4], 0xa);      /* mov dword [ebp-0x4], 0xa */
            ii(0x1019_575f, 2); jmpd(0x1019_57c4, 0x63); goto l_0x1019_57c4; /* jmp 0x101957c4 */
        l_0x1019_5761:
            ii(0x1019_5761, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1019_5764, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x1019_5767, 10); mov(memd_a32[ds, eax + 0x101c_02b0], 0); /* mov dword [eax+0x101c02b0], 0x0 */
            ii(0x1019_5771, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1019_5774, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x1019_5777, 6); pushd(memd_a32[ds, eax + 0x101c_0288]); /* push dword [eax+0x101c0288] */
            ii(0x1019_577d, 4); imul(eax, memd_a32[ss, ebp - 0x8], 0x6); /* imul eax, [ebp-0x8], 0x6 */
            ii(0x1019_5781, 7); movzx(edx, memw_a32[ds, eax + 0x101c_0214]); /* movzx edx, word [eax+0x101c0214] */
            ii(0x1019_5788, 1); pushd(edx);                             /* push edx */
            ii(0x1019_5789, 6); pushd(memd_a32[ds, eax + 0x101c_0210]); /* push dword [eax+0x101c0210] */
            ii(0x1019_578f, 5); calld(/* sys */ 0x1019_4d46, -0xa4e);   /* call 0x10194d46 */
            ii(0x1019_5794, 3); add(esp, 0xc);                          /* add esp, 0xc */
            ii(0x1019_5797, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1019_579a, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x1019_579d, 6); pushd(memd_a32[ds, eax + 0x101c_0288]); /* push dword [eax+0x101c0288] */
            ii(0x1019_57a3, 4); imul(eax, memd_a32[ss, ebp - 0x8], 0x6); /* imul eax, [ebp-0x8], 0x6 */
            ii(0x1019_57a7, 7); movzx(edx, memw_a32[ds, eax + 0x101c_0232]); /* movzx edx, word [eax+0x101c0232] */
            ii(0x1019_57ae, 1); pushd(edx);                             /* push edx */
            ii(0x1019_57af, 6); pushd(memd_a32[ds, eax + 0x101c_022e]); /* push dword [eax+0x101c022e] */
            ii(0x1019_57b5, 5); calld(/* sys */ 0x1019_4d46, -0xa74);   /* call 0x10194d46 */
            ii(0x1019_57ba, 3); add(esp, 0xc);                          /* add esp, 0xc */
            ii(0x1019_57bd, 7); mov(memd_a32[ss, ebp - 0x4], 0);        /* mov dword [ebp-0x4], 0x0 */
        l_0x1019_57c4:
            ii(0x1019_57c4, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1019_57c7, 1); leaved();                               /* leave */
            ii(0x1019_57c8, 1); popd(edi);                              /* pop edi */
            ii(0x1019_57c9, 1); popd(esi);                              /* pop esi */
            ii(0x1019_57ca, 1); popd(edx);                              /* pop edx */
            ii(0x1019_57cb, 1); popd(ecx);                              /* pop ecx */
            ii(0x1019_57cc, 1); popd(ebx);                              /* pop ebx */
            ii(0x1019_57cd, 1); retd(); return;                         /* ret */
        }
    }
}
