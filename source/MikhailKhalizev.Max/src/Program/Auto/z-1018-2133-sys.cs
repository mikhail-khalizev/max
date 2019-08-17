using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("65c31928-0205-482b-8458-8f2e9cb00268")]
        public void /* sys */ Method_1018_2133()
        {
            ii(0x1018_2133, 7); cmp(memb_a32[ds, 0x101b_e814], 0x1);    /* cmp byte [0x101be814], 0x1 */
            ii(0x1018_213a, 2); if(jzd(0x1018_213d, 0x1)) goto l_0x1018_213d; /* jz 0x1018213d */
            ii(0x1018_213c, 1); retd(); return;                         /* ret */
        l_0x1018_213d:
            ii(0x1018_213d, 1); pushd(ecx);                             /* push ecx */
            ii(0x1018_213e, 1); pushd(ebx);                             /* push ebx */
            ii(0x1018_213f, 1); pushd(edx);                             /* push edx */
            ii(0x1018_2140, 5); mov(al, memb_a32[ds, 0x101b_e58e]);     /* mov al, [0x101be58e] */
            ii(0x1018_2145, 7); cmp(memb_a32[ds, 0x101b_e590], 0);      /* cmp byte [0x101be590], 0x0 */
            ii(0x1018_214c, 2); if(jzd(0x1018_2155, 0x7)) goto l_0x1018_2155; /* jz 0x10182155 */
            ii(0x1018_214e, 5); calld(/* sys */ 0x1018_21e8, 0x95);     /* call 0x101821e8 */
            ii(0x1018_2153, 2); jmpd(0x1018_21a2, 0x4d); goto l_0x1018_21a2; /* jmp 0x101821a2 */
        l_0x1018_2155:
            ii(0x1018_2155, 2); cmp(al, 0x9);                           /* cmp al, 0x9 */
            ii(0x1018_2157, 2); if(jnzd(0x1018_216e, 0x15)) goto l_0x1018_216e; /* jnz 0x1018216e */
            ii(0x1018_2159, 5); mov(eax, 0xe02);                        /* mov eax, 0xe02 */
            ii(0x1018_215e, 5); mov(ebx, 0);                            /* mov ebx, 0x0 */
            ii(0x1018_2163, 6); mov(ecx, memd_a32[ds, 0x101b_de8c]);    /* mov ecx, [0x101bde8c] */
            ii(0x1018_2169, 3); calld_abs(memd_a32[ds, ecx + 0x30]);    /* call dword [ecx+0x30] */
            ii(0x1018_216c, 2); jmpd(0x1018_21a2, 0x34); goto l_0x1018_21a2; /* jmp 0x101821a2 */
        l_0x1018_216e:
            ii(0x1018_216e, 2); cmp(al, 0);                             /* cmp al, 0x0 */
            ii(0x1018_2170, 2); if(jnzd(0x1018_217e, 0xc)) goto l_0x1018_217e; /* jnz 0x1018217e */
            ii(0x1018_2172, 6); mov(ax, memw_a32[ds, 0x101b_e812]);     /* mov ax, [0x101be812] */
            ii(0x1018_2178, 2); mov(ah, 0xf3);                          /* mov ah, 0xf3 */
            ii(0x1018_217a, 2); @int(0x21);                             /* int 0x21 */
            ii(0x1018_217c, 2); jmpd(0x1018_21a2, 0x24); goto l_0x1018_21a2; /* jmp 0x101821a2 */
        l_0x1018_217e:
            ii(0x1018_217e, 2); cmp(al, 0x1);                           /* cmp al, 0x1 */
            ii(0x1018_2180, 2); if(jnzd(0x1018_2192, 0x10)) goto l_0x1018_2192; /* jnz 0x10182192 */
            ii(0x1018_2182, 7); mov(dx, memw_a32[ds, 0x101b_de90]);     /* mov dx, [0x101bde90] */
            ii(0x1018_2189, 2); sub(eax, eax);                          /* sub eax, eax */
            ii(0x1018_218b, 5); calld(/* sys */ 0x1019_9b5e, 0x1_79ce); /* call 0x10199b5e */
            ii(0x1018_2190, 2); jmpd(0x1018_21a2, 0x10); goto l_0x1018_21a2; /* jmp 0x101821a2 */
        l_0x1018_2192:
            ii(0x1018_2192, 2); sub(edx, edx);                          /* sub edx, edx */
            ii(0x1018_2194, 5); calld(/* sys */ 0x1019_9b5e, 0x1_79c5); /* call 0x10199b5e */
            ii(0x1018_2199, 2); cmp(al, 0x1);                           /* cmp al, 0x1 */
            ii(0x1018_219b, 2); if(jzd(0x1018_21a2, 0x5)) goto l_0x1018_21a2; /* jz 0x101821a2 */
            ii(0x1018_219d, 5); calld(/* sys */ 0x1018_21ad, 0xb);      /* call 0x101821ad */
        l_0x1018_21a2:
            ii(0x1018_21a2, 7); mov(memb_a32[ds, 0x101b_e814], 0);      /* mov byte [0x101be814], 0x0 */
            ii(0x1018_21a9, 1); popd(edx);                              /* pop edx */
            ii(0x1018_21aa, 1); popd(ebx);                              /* pop ebx */
            ii(0x1018_21ab, 1); popd(ecx);                              /* pop ecx */
            ii(0x1018_21ac, 1); retd(); return;                         /* ret */
        }
    }
}
