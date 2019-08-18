using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1018_66ac-99b6f4b3")]
        public void /* sys */ Method_1018_66ac()
        {
            ii(0x1018_66ac, 1); pushd(ebx);                             /* push ebx */
            ii(0x1018_66ad, 1); pushd(ecx);                             /* push ecx */
            ii(0x1018_66ae, 1); pushd(edx);                             /* push edx */
            ii(0x1018_66af, 1); pushd(esi);                             /* push esi */
            ii(0x1018_66b0, 7); cmp(memd_a32[ds, 0x101b_e854], 0);      /* cmp dword [0x101be854], 0x0 */
            ii(0x1018_66b7, 6); if(jzd(0x1018_6730, 0x73)) goto l_0x1018_6730; /* jz 0x10186730 */
            ii(0x1018_66bd, 7); cmp(memd_a32[ds, 0x101b_e878], 0);      /* cmp dword [0x101be878], 0x0 */
            ii(0x1018_66c4, 6); if(jzd(0x1018_6730, 0x66)) goto l_0x1018_6730; /* jz 0x10186730 */
            ii(0x1018_66ca, 1); cli();                                  /* cli */
            ii(0x1018_66cb, 6); mov(ecx, memd_a32[ds, 0x101b_e858]);    /* mov ecx, [0x101be858] */
            ii(0x1018_66d1, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x1018_66d3, 2); test(ecx, ecx);                         /* test ecx, ecx */
            ii(0x1018_66d5, 2); if(jled(0x1018_66fd, 0x26)) goto l_0x1018_66fd; /* jle 0x101866fd */
            ii(0x1018_66d7, 2); xor(ecx, ecx);                          /* xor ecx, ecx */
        l_0x1018_66d9:
            ii(0x1018_66d9, 5); mov(eax, memd_a32[ds, 0x101b_e854]);    /* mov eax, [0x101be854] */
            ii(0x1018_66de, 6); mov(edx, memd_a32[ds, 0x101b_e878]);    /* mov edx, [0x101be878] */
            ii(0x1018_66e4, 2); add(eax, ecx);                          /* add eax, ecx */
            ii(0x1018_66e6, 5); calld(/* sys */ 0x1018_67c4, 0xd9);     /* call 0x101867c4 */
            ii(0x1018_66eb, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1018_66ed, 2); if(jzd(0x1018_66fd, 0xe)) goto l_0x1018_66fd; /* jz 0x101866fd */
            ii(0x1018_66ef, 6); mov(esi, memd_a32[ds, 0x101b_e858]);    /* mov esi, [0x101be858] */
            ii(0x1018_66f5, 1); inc(ebx);                               /* inc ebx */
            ii(0x1018_66f6, 3); add(ecx, 0x18);                         /* add ecx, 0x18 */
            ii(0x1018_66f9, 2); cmp(ebx, esi);                          /* cmp ebx, esi */
            ii(0x1018_66fb, 2); if(jld(0x1018_66d9, -0x24)) goto l_0x1018_66d9; /* jl 0x101866d9 */
        l_0x1018_66fd:
            ii(0x1018_66fd, 6); cmp(ebx, memd_a32[ds, 0x101b_e858]);    /* cmp ebx, [0x101be858] */
            ii(0x1018_6703, 2); if(jnzd(0x1018_672e, 0x29)) goto l_0x1018_672e; /* jnz 0x1018672e */
            ii(0x1018_6705, 7); cmp(memd_a32[ds, 0x101b_e854], 0);      /* cmp dword [0x101be854], 0x0 */
            ii(0x1018_670c, 2); if(jzd(0x1018_671c, 0xe)) goto l_0x1018_671c; /* jz 0x1018671c */
            ii(0x1018_670e, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1018_6710, 5); mov(memd_a32[ds, 0x101b_e858], eax);    /* mov [0x101be858], eax */
            ii(0x1018_6715, 5); mov(eax, 0x1);                          /* mov eax, 0x1 */
            ii(0x1018_671a, 2); jmpd(0x1018_671e, 0x2); goto l_0x1018_671e; /* jmp 0x1018671e */
        l_0x1018_671c:
            ii(0x1018_671c, 2); xor(eax, eax);                          /* xor eax, eax */
        l_0x1018_671e:
            ii(0x1018_671e, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1018_6720, 2); if(jzd(0x1018_672e, 0xc)) goto l_0x1018_672e; /* jz 0x1018672e */
            ii(0x1018_6722, 1); sti();                                  /* sti */
            ii(0x1018_6723, 1); cld();                                  /* cld */
            ii(0x1018_6724, 5); mov(eax, 0x1);                          /* mov eax, 0x1 */
            ii(0x1018_6729, 1); popd(esi);                              /* pop esi */
            ii(0x1018_672a, 1); popd(edx);                              /* pop edx */
            ii(0x1018_672b, 1); popd(ecx);                              /* pop ecx */
            ii(0x1018_672c, 1); popd(ebx);                              /* pop ebx */
            ii(0x1018_672d, 1); retd(); return;                         /* ret */
        l_0x1018_672e:
            ii(0x1018_672e, 1); sti();                                  /* sti */
            ii(0x1018_672f, 1); cld();                                  /* cld */
        l_0x1018_6730:
            ii(0x1018_6730, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1018_6732, 1); popd(esi);                              /* pop esi */
            ii(0x1018_6733, 1); popd(edx);                              /* pop edx */
            ii(0x1018_6734, 1); popd(ecx);                              /* pop ecx */
            ii(0x1018_6735, 1); popd(ebx);                              /* pop ebx */
            ii(0x1018_6736, 1); retd(); return;                         /* ret */
        }
    }
}
