using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1016_9814-cbea06a2")]
        public void /* sys */ sys_display_draw_3()
        {
            ii(0x1016_9814, 1); pushd(ebx);                             /* push ebx */
            ii(0x1016_9815, 1); pushd(ecx);                             /* push ecx */
            ii(0x1016_9816, 1); pushd(edx);                             /* push edx */
            ii(0x1016_9817, 3); sub(esp, 0x4);                          /* sub esp, 0x4 */
            ii(0x1016_981a, 7); cmp(memd_a32[ds, 0x101b_ddbc], 0);      /* cmp dword [0x101bddbc], 0x0 */
            ii(0x1016_9821, 2); if(jnzd(0x1016_982a, 0x7)) goto l_0x1016_982a; /* jnz 0x1016982a */
            ii(0x1016_9823, 5); mov(eax, 0xffff_ffff);                  /* mov eax, 0xffffffff */
            ii(0x1016_9828, 2); jmpd(0x1016_9866, 0x3c); goto l_0x1016_9866; /* jmp 0x10169866 */
        l_0x1016_982a:
            ii(0x1016_982a, 2); mov(edx, esp);                          /* mov edx, esp */
            ii(0x1016_982c, 5); calld(/* sys */ 0x1016_7f00, -0x1931);  /* call 0x10167f00 */
            ii(0x1016_9831, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1016_9833, 2); if(jnzd(0x1016_9841, 0xc)) goto l_0x1016_9841; /* jnz 0x10169841 */
            ii(0x1016_9835, 5); mov(eax, 0xffff_ffff);                  /* mov eax, 0xffffffff */
            ii(0x1016_983a, 3); add(esp, 0x4);                          /* add esp, 0x4 */
            ii(0x1016_983d, 1); popd(edx);                              /* pop edx */
            ii(0x1016_983e, 1); popd(ecx);                              /* pop ecx */
            ii(0x1016_983f, 1); popd(ebx);                              /* pop ebx */
            ii(0x1016_9840, 1); retd(); return;                         /* ret */
        l_0x1016_9841:
            ii(0x1016_9841, 3); mov(dl, memb_a32[ds, eax + 0x4]);       /* mov dl, [eax+0x4] */
            ii(0x1016_9844, 3); test(dl, 0x8);                          /* test dl, 0x8 */
            ii(0x1016_9847, 2); if(jzd(0x1016_9864, 0x1b)) goto l_0x1016_9864; /* jz 0x10169864 */
            ii(0x1016_9849, 2); mov(dh, dl);                            /* mov dh, dl */
            ii(0x1016_984b, 3); and(dh, 0xf7);                          /* and dh, 0xf7 */
            ii(0x1016_984e, 2); pushd(0);                               /* push 0x0 */
            ii(0x1016_9850, 3); mov(memb_a32[ds, eax + 0x4], dh);       /* mov [eax+0x4], dh */
            ii(0x1016_9853, 5); mov(ecx, 0x1);                          /* mov ecx, 0x1 */
            ii(0x1016_9858, 3); mov(ebx, memd_a32[ds, eax + 0x48]);     /* mov ebx, [eax+0x48] */
            ii(0x1016_985b, 4); mov(edx, memd_a32[ss, esp + 0x4]);      /* mov edx, [esp+0x4] */
            ii(0x1016_985f, 5); calld(/* sys */ 0x1016_9b90, 0x32c);    /* call 0x10169b90 */
        l_0x1016_9864:
            ii(0x1016_9864, 2); xor(eax, eax);                          /* xor eax, eax */
        l_0x1016_9866:
            ii(0x1016_9866, 3); add(esp, 0x4);                          /* add esp, 0x4 */
            ii(0x1016_9869, 1); popd(edx);                              /* pop edx */
            ii(0x1016_986a, 1); popd(ecx);                              /* pop ecx */
            ii(0x1016_986b, 1); popd(ebx);                              /* pop ebx */
            ii(0x1016_986c, 1); retd();                                 /* ret */
        }
    }
}
