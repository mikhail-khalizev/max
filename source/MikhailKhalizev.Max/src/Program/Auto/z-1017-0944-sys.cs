using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("28dcfd01-0ca9-4ec8-9c80-7982e18fe68a")]
        public void /* sys */ Method_1017_0944()
        {
            ii(0x1017_0944, 1); pushd(ebx);                             /* push ebx */
            ii(0x1017_0945, 1); pushd(ecx);                             /* push ecx */
            ii(0x1017_0946, 1); pushd(edx);                             /* push edx */
            ii(0x1017_0947, 1); pushd(esi);                             /* push esi */
            ii(0x1017_0948, 2); mov(esi, eax);                          /* mov esi, eax */
            ii(0x1017_094a, 6); mov(ebx, memd_a32[ds, 0x1020_88b8]);    /* mov ebx, [0x102088b8] */
            ii(0x1017_0950, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1017_0952, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1017_0954, 2); test(ebx, ebx);                         /* test ebx, ebx */
            ii(0x1017_0956, 2); if(jzd(0x1017_096a, 0x12)) goto l_0x1017_096a; /* jz 0x1017096a */
        l_0x1017_0958:
            ii(0x1017_0958, 3); add(eax, 0x4);                          /* add eax, 0x4 */
            ii(0x1017_095b, 1); inc(edx);                               /* inc edx */
            ii(0x1017_095c, 3); cmp(eax, 0x28);                         /* cmp eax, 0x28 */
            ii(0x1017_095f, 2); if(jged(0x1017_096a, 0x9)) goto l_0x1017_096a; /* jge 0x1017096a */
            ii(0x1017_0961, 7); cmp(memd_a32[ds, eax + 0x1020_88b8], 0); /* cmp dword [eax+0x102088b8], 0x0 */
            ii(0x1017_0968, 2); if(jnzd(0x1017_0958, -0x12)) goto l_0x1017_0958; /* jnz 0x10170958 */
        l_0x1017_096a:
            ii(0x1017_096a, 3); cmp(edx, 0xa);                          /* cmp edx, 0xa */
            ii(0x1017_096d, 2); if(jged(0x1017_09a5, 0x36)) goto l_0x1017_09a5; /* jge 0x101709a5 */
            ii(0x1017_096f, 5); mov(eax, 0x1a8);                        /* mov eax, 0x1a8 */
            ii(0x1017_0974, 7); lea(ecx, edx * 4 + 0);                  /* lea ecx, [edx*4] */
            ii(0x1017_097b, 5); calld(/* sys */ 0x1017_1174, 0x7f4);    /* call 0x10171174 */
            ii(0x1017_0980, 6); mov(memd_a32[ds, ecx + 0x1020_88b8], eax); /* mov [ecx+0x102088b8], eax */
            ii(0x1017_0986, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1017_0988, 2); if(jzd(0x1017_09a5, 0x1b)) goto l_0x1017_09a5; /* jz 0x101709a5 */
            ii(0x1017_098a, 5); mov(ebx, 0x1a8);                        /* mov ebx, 0x1a8 */
            ii(0x1017_098f, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1017_0991, 5); calld(Definitions.sys_memset, -0xabb6); /* call 0x10165de0 */
            ii(0x1017_0996, 6); mov(eax, memd_a32[ds, ecx + 0x1020_88b8]); /* mov eax, [ecx+0x102088b8] */
            ii(0x1017_099c, 2); mov(memd_a32[ds, esi], eax);            /* mov [esi], eax */
            ii(0x1017_099e, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1017_09a0, 1); popd(esi);                              /* pop esi */
            ii(0x1017_09a1, 1); popd(edx);                              /* pop edx */
            ii(0x1017_09a2, 1); popd(ecx);                              /* pop ecx */
            ii(0x1017_09a3, 1); popd(ebx);                              /* pop ebx */
            ii(0x1017_09a4, 1); retd(); return;                         /* ret */
        l_0x1017_09a5:
            ii(0x1017_09a5, 5); mov(eax, 0xffff_ffff);                  /* mov eax, 0xffffffff */
            ii(0x1017_09aa, 1); popd(esi);                              /* pop esi */
            ii(0x1017_09ab, 1); popd(edx);                              /* pop edx */
            ii(0x1017_09ac, 1); popd(ecx);                              /* pop ecx */
            ii(0x1017_09ad, 1); popd(ebx);                              /* pop ebx */
            ii(0x1017_09ae, 1); retd(); return;                         /* ret */
        }
    }
}
