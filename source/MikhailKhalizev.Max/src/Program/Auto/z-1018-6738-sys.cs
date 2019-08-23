using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1018_6738-5c87a0fe")]
        public void /* sys */ Method_1018_6738()
        {
            ii(0x1018_6738, 1); pushd(ebx);                             /* push ebx */
            ii(0x1018_6739, 1); pushd(ecx);                             /* push ecx */
            ii(0x1018_673a, 1); pushd(edx);                             /* push edx */
            ii(0x1018_673b, 1); pushd(esi);                             /* push esi */
            ii(0x1018_673c, 6); mov(ecx, memd_a32[ds, 0x101b_e87c]);    /* mov ecx, [0x101be87c] */
            ii(0x1018_6742, 7); cmp(memd_a32[ds, 0x101b_e878], 0);      /* cmp dword [0x101be878], 0x0 */
            ii(0x1018_6749, 2); if(jzd(0x1018_67a5, 0x5a)) goto l_0x1018_67a5; /* jz 0x101867a5 */
            ii(0x1018_674b, 7); cmp(memd_a32[ds, 0x101b_e854], 0);      /* cmp dword [0x101be854], 0x0 */
            ii(0x1018_6752, 2); if(jzd(0x1018_6763, 0xf)) goto l_0x1018_6763; /* jz 0x10186763 */
            ii(0x1018_6754, 2); xor(esi, esi);                          /* xor esi, esi */
            ii(0x1018_6756, 5); mov(eax, 0x1);                          /* mov eax, 0x1 */
            ii(0x1018_675b, 6); mov(memd_a32[ds, 0x101b_e858], esi);    /* mov [0x101be858], esi */
            ii(0x1018_6761, 2); jmpd(0x1018_6765, 0x2); goto l_0x1018_6765; /* jmp 0x10186765 */
        l_0x1018_6763:
            ii(0x1018_6763, 2); xor(eax, eax);                          /* xor eax, eax */
        l_0x1018_6765:
            ii(0x1018_6765, 3); cmp(eax, 0x1);                          /* cmp eax, 0x1 */
            ii(0x1018_6768, 2); if(jnzd(0x1018_67a5, 0x3b)) goto l_0x1018_67a5; /* jnz 0x101867a5 */
            ii(0x1018_676a, 2); xor(ecx, ecx);                          /* xor ecx, ecx */
        l_0x1018_676c:
            ii(0x1018_676c, 3); imul(ebx, ecx, 0x18);                   /* imul ebx, ecx, 0x18 */
            ii(0x1018_676f, 5); mov(eax, memd_a32[ds, 0x101b_e854]);    /* mov eax, [0x101be854] */
            ii(0x1018_6774, 6); mov(edx, memd_a32[ds, 0x101b_e878]);    /* mov edx, [0x101be878] */
            ii(0x1018_677a, 2); add(eax, ebx);                          /* add eax, ebx */
            ii(0x1018_677c, 6); mov(memd_a32[ds, 0x101b_e87c], ecx);    /* mov [0x101be87c], ecx */
            ii(0x1018_6782, 5); calld(/* sys */ 0x1018_68a8, 0x121);    /* call 0x101868a8 */
            ii(0x1018_6787, 6); mov(ecx, memd_a32[ds, 0x101b_e87c]);    /* mov ecx, [0x101be87c] */
            ii(0x1018_678d, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1018_678f, 2); if(jzd(0x1018_679a, 0x9)) goto l_0x1018_679a; /* jz 0x1018679a */
            ii(0x1018_6791, 1); inc(ecx);                               /* inc ecx */
            ii(0x1018_6792, 6); cmp(ecx, 0x1000);                       /* cmp ecx, 0x1000 */
            ii(0x1018_6798, 2); if(jld(0x1018_676c, -0x2e)) goto l_0x1018_676c; /* jl 0x1018676c */
        l_0x1018_679a:
            ii(0x1018_679a, 2); test(ecx, ecx);                         /* test ecx, ecx */
            ii(0x1018_679c, 2); if(jzd(0x1018_67a5, 0x7)) goto l_0x1018_67a5; /* jz 0x101867a5 */
            ii(0x1018_679e, 5); mov(eax, 0x1);                          /* mov eax, 0x1 */
            ii(0x1018_67a3, 2); jmpd(0x1018_67a7, 0x2); goto l_0x1018_67a7; /* jmp 0x101867a7 */
        l_0x1018_67a5:
            ii(0x1018_67a5, 2); xor(eax, eax);                          /* xor eax, eax */
        l_0x1018_67a7:
            ii(0x1018_67a7, 6); mov(memd_a32[ds, 0x101b_e87c], ecx);    /* mov [0x101be87c], ecx */
            ii(0x1018_67ad, 1); popd(esi);                              /* pop esi */
            ii(0x1018_67ae, 1); popd(edx);                              /* pop edx */
            ii(0x1018_67af, 1); popd(ecx);                              /* pop ecx */
            ii(0x1018_67b0, 1); popd(ebx);                              /* pop ebx */
            ii(0x1018_67b1, 1); retd();                                 /* ret */
        }
    }
}
