using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("5ef94f2a-7189-40be-b674-fcab45fa766b")]
        public void /* sys */ Method_1016_60a8()
        {
            ii(0x1016_60a8, 1); pushd(ebx);                             /* push ebx */
            ii(0x1016_60a9, 1); pushd(edx);                             /* push edx */
            ii(0x1016_60aa, 3); sub(esp, 0x10);                         /* sub esp, 0x10 */
            ii(0x1016_60ad, 5); mov(ebx, 0x1020_a1f8);                  /* mov ebx, 0x1020a1f8 */
        l_0x1016_60b2:
            ii(0x1016_60b2, 6); mov(edx, memd_a32[ds, 0x101b_e7bc]);    /* mov edx, [0x101be7bc] */
            ii(0x1016_60b8, 2); test(edx, edx);                         /* test edx, edx */
            ii(0x1016_60ba, 2); if(jzd(0x1016_60c3, 0x7)) goto l_0x1016_60c3; /* jz 0x101660c3 */
            ii(0x1016_60bc, 2); mov(eax, memd_a32[ds, edx]);            /* mov eax, [edx] */
            ii(0x1016_60be, 5); mov(memd_a32[ds, 0x101b_e7bc], eax);    /* mov [0x101be7bc], eax */
        l_0x1016_60c3:
            ii(0x1016_60c3, 2); if(jzd(0x1016_60fe, 0x39)) goto l_0x1016_60fe; /* jz 0x101660fe */
            ii(0x1016_60c5, 2); mov(eax, memd_a32[ds, ebx]);            /* mov eax, [ebx] */
            ii(0x1016_60c7, 3); mov(memd_a32[ss, esp], eax);            /* mov [esp], eax */
            ii(0x1016_60ca, 2); mov(eax, esp);                          /* mov eax, esp */
            ii(0x1016_60cc, 2); mov(memd_a32[ds, ebx], eax);            /* mov [ebx], eax */
            ii(0x1016_60ce, 3); mov(eax, memd_a32[ds, edx + 0x4]);      /* mov eax, [edx+0x4] */
            ii(0x1016_60d1, 4); mov(memd_a32[ss, esp + 0x4], eax);      /* mov [esp+0x4], eax */
            ii(0x1016_60d5, 3); mov(eax, memd_a32[ds, edx + 0x8]);      /* mov eax, [edx+0x8] */
            ii(0x1016_60d8, 4); mov(memd_a32[ss, esp + 0x8], eax);      /* mov [esp+0x8], eax */
            ii(0x1016_60dc, 3); mov(eax, memd_a32[ds, edx + 0x4]);      /* mov eax, [edx+0x4] */
            ii(0x1016_60df, 3); cmp(memd_a32[ds, eax], 0x4);            /* cmp dword [eax], 0x4 */
            ii(0x1016_60e2, 2); if(jnzd(0x1016_60eb, 0x7)) goto l_0x1016_60eb; /* jnz 0x101660eb */
            ii(0x1016_60e4, 3); mov(eax, memd_a32[ds, edx + 0xc]);      /* mov eax, [edx+0xc] */
            ii(0x1016_60e7, 4); mov(memd_a32[ss, esp + 0xc], eax);      /* mov [esp+0xc], eax */
        l_0x1016_60eb:
            ii(0x1016_60eb, 5); calld(/* sys */ 0x1018_1ef2, 0x1_be02); /* call 0x10181ef2 */
            ii(0x1016_60f0, 6); mov(memd_a32[ds, edx], 0);              /* mov dword [edx], 0x0 */
            ii(0x1016_60f6, 2); mov(eax, memd_a32[ds, ebx]);            /* mov eax, [ebx] */
            ii(0x1016_60f8, 2); mov(eax, memd_a32[ds, eax]);            /* mov eax, [eax] */
            ii(0x1016_60fa, 2); mov(memd_a32[ds, ebx], eax);            /* mov [ebx], eax */
            ii(0x1016_60fc, 2); jmpd(0x1016_60b2, -0x4c); goto l_0x1016_60b2; /* jmp 0x101660b2 */
        l_0x1016_60fe:
            ii(0x1016_60fe, 3); add(esp, 0x10);                         /* add esp, 0x10 */
            ii(0x1016_6101, 1); popd(edx);                              /* pop edx */
            ii(0x1016_6102, 1); popd(ebx);                              /* pop ebx */
            ii(0x1016_6103, 1); retd(); return;                         /* ret */
        }
    }
}
