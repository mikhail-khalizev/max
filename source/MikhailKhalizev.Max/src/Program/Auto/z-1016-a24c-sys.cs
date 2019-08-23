using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1016_a24c-7c5809ad")]
        public void /* sys */ Method_1016_a24c()
        {
            ii(0x1016_a24c, 1); push(ebx);                              /* push ebx */
            ii(0x1016_a24d, 1); push(edx);                              /* push edx */
            ii(0x1016_a24e, 3); sub(esp, 0x4);                          /* sub esp, 0x4 */
            ii(0x1016_a251, 2); mov(ebx, eax);                          /* mov ebx, eax */
            ii(0x1016_a253, 2); mov(edx, esp);                          /* mov edx, esp */
            ii(0x1016_a255, 5); call(/* sys */ 0x1016_a2cc, 0x72);      /* call 0x1016a2cc */
            ii(0x1016_a25a, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1016_a25c, 2); if(jz(0x1016_a2c4, 0x66)) goto l_0x1016_a2c4; /* jz 0x1016a2c4 */
            ii(0x1016_a25e, 3); mov(eax, memd[ss, esp]);                /* mov eax, [esp] */
            ii(0x1016_a261, 3); mov(eax, memd[ds, eax + 0xc]);          /* mov eax, [eax+0xc] */
            ii(0x1016_a264, 5); mov(memd[ds, 0x101b_ddec], eax);        /* mov [0x101bddec], eax */
            ii(0x1016_a269, 3); mov(eax, memd[ss, esp]);                /* mov eax, [esp] */
            ii(0x1016_a26c, 3); mov(eax, memd[ds, eax + 0x10]);         /* mov eax, [eax+0x10] */
            ii(0x1016_a26f, 5); mov(memd[ds, 0x101b_ddf0], eax);        /* mov [0x101bddf0], eax */
            ii(0x1016_a274, 3); mov(eax, memd[ss, esp]);                /* mov eax, [esp] */
            ii(0x1016_a277, 3); mov(eax, memd[ds, eax + 0x14]);         /* mov eax, [eax+0x14] */
            ii(0x1016_a27a, 5); mov(memd[ds, 0x101b_ddf4], eax);        /* mov [0x101bddf4], eax */
            ii(0x1016_a27f, 3); mov(eax, memd[ss, esp]);                /* mov eax, [esp] */
            ii(0x1016_a282, 3); mov(eax, memd[ds, eax + 0x18]);         /* mov eax, [eax+0x18] */
            ii(0x1016_a285, 5); mov(memd[ds, 0x101b_ddf8], eax);        /* mov [0x101bddf8], eax */
            ii(0x1016_a28a, 3); mov(eax, memd[ss, esp]);                /* mov eax, [esp] */
            ii(0x1016_a28d, 3); mov(eax, memd[ds, eax + 0x1c]);         /* mov eax, [eax+0x1c] */
            ii(0x1016_a290, 5); mov(memd[ds, 0x101b_ddfc], eax);        /* mov [0x101bddfc], eax */
            ii(0x1016_a295, 3); mov(eax, memd[ss, esp]);                /* mov eax, [esp] */
            ii(0x1016_a298, 3); mov(eax, memd[ds, eax + 0x20]);         /* mov eax, [eax+0x20] */
            ii(0x1016_a29b, 5); mov(memd[ds, 0x101b_de00], eax);        /* mov [0x101bde00], eax */
            ii(0x1016_a2a0, 3); mov(eax, memd[ss, esp]);                /* mov eax, [esp] */
            ii(0x1016_a2a3, 3); mov(eax, memd[ds, eax + 0x24]);         /* mov eax, [eax+0x24] */
            ii(0x1016_a2a6, 5); mov(memd[ds, 0x101b_de04], eax);        /* mov [0x101bde04], eax */
            ii(0x1016_a2ab, 3); mov(eax, memd[ss, esp]);                /* mov eax, [esp] */
            ii(0x1016_a2ae, 3); mov(eax, memd[ds, eax + 0x28]);         /* mov eax, [eax+0x28] */
            ii(0x1016_a2b1, 3); mov(edx, memd[ss, esp]);                /* mov edx, [esp] */
            ii(0x1016_a2b4, 5); mov(memd[ds, 0x101b_de08], eax);        /* mov [0x101bde08], eax */
            ii(0x1016_a2b9, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x1016_a2bb, 6); mov(memd[ds, 0x101b_dde4], ebx);        /* mov [0x101bdde4], ebx */
            ii(0x1016_a2c1, 3); call_abs(memd[ds, edx + 0x8]);          /* call dword [edx+0x8] */
        l_0x1016_a2c4:
            ii(0x1016_a2c4, 3); add(esp, 0x4);                          /* add esp, 0x4 */
            ii(0x1016_a2c7, 1); pop(edx);                               /* pop edx */
            ii(0x1016_a2c8, 1); pop(ebx);                               /* pop ebx */
            ii(0x1016_a2c9, 1); ret();                                  /* ret */
        }
    }
}
