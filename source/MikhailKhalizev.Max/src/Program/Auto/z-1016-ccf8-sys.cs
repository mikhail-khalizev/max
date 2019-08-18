using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("173974f5-5174-482c-81fa-d0aca05f348d")]
        public void /* sys */ Method_1016_ccf8()
        {
            ii(0x1016_ccf8, 1); pushd(esi);                             /* push esi */
            ii(0x1016_ccf9, 3); sub(esp, 0x4);                          /* sub esp, 0x4 */
            ii(0x1016_ccfc, 3); mov(memd_a32[ss, esp], eax);            /* mov [esp], eax */
            ii(0x1016_ccff, 2); mov(ah, dl);                            /* mov ah, dl */
            ii(0x1016_cd01, 3); mov(esi, memd_a32[ss, esp]);            /* mov esi, [esp] */
            ii(0x1016_cd04, 7); lea(edx, esi * 4 + 0);                  /* lea edx, [esi*4] */
            ii(0x1016_cd0b, 2); sub(edx, esi);                          /* sub edx, esi */
            ii(0x1016_cd0d, 6); mov(memb_a32[ds, edx + 0x101c_fce0], ah); /* mov [edx+0x101cfce0], ah */
            ii(0x1016_cd13, 6); mov(memb_a32[ds, edx + 0x101c_fce1], bl); /* mov [edx+0x101cfce1], bl */
            ii(0x1016_cd19, 6); mov(memb_a32[ds, edx + 0x101c_fce2], cl); /* mov [edx+0x101cfce2], cl */
            ii(0x1016_cd1f, 2); mov(al, ah);                            /* mov al, ah */
            ii(0x1016_cd21, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1016_cd26, 6); mov(ah, memb_a32[ds, eax + 0x101c_ffe0]); /* mov ah, [eax+0x101cffe0] */
            ii(0x1016_cd2c, 6); and(ebx, 0xff);                         /* and ebx, 0xff */
            ii(0x1016_cd32, 6); mov(bl, memb_a32[ds, ebx + 0x101c_ffe0]); /* mov bl, [ebx+0x101cffe0] */
            ii(0x1016_cd38, 6); and(ecx, 0xff);                         /* and ecx, 0xff */
            ii(0x1016_cd3e, 3); mov(al, memb_a32[ss, esp]);             /* mov al, [esp] */
            ii(0x1016_cd41, 5); mov(edx, 0x3c8);                        /* mov edx, 0x3c8 */
            ii(0x1016_cd46, 6); mov(cl, memb_a32[ds, ecx + 0x101c_ffe0]); /* mov cl, [ecx+0x101cffe0] */
            ii(0x1016_cd4c, 1); outb(dx, al);                           /* out dx, al */
            ii(0x1016_cd4d, 5); mov(edx, 0x3c9);                        /* mov edx, 0x3c9 */
            ii(0x1016_cd52, 2); mov(al, ah);                            /* mov al, ah */
            ii(0x1016_cd54, 1); outb(dx, al);                           /* out dx, al */
            ii(0x1016_cd55, 2); mov(al, bl);                            /* mov al, bl */
            ii(0x1016_cd57, 1); outb(dx, al);                           /* out dx, al */
            ii(0x1016_cd58, 2); mov(al, cl);                            /* mov al, cl */
            ii(0x1016_cd5a, 1); outb(dx, al);                           /* out dx, al */
            ii(0x1016_cd5b, 3); add(esp, 0x4);                          /* add esp, 0x4 */
            ii(0x1016_cd5e, 1); popd(esi);                              /* pop esi */
            ii(0x1016_cd5f, 1); retd(); return;                         /* ret */
        }
    }
}
