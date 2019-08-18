using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1019_51e7-ffb27685")]
        public void /* sys */ Method_1019_51e7()
        {
            ii(0x1019_51e7, 1); pushd(ebp);                             /* push ebp */
            ii(0x1019_51e8, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1019_51ea, 1); pushd(esi);                             /* push esi */
            ii(0x1019_51eb, 1); pushd(edi);                             /* push edi */
            ii(0x1019_51ec, 1); pushd(ebx);                             /* push ebx */
            ii(0x1019_51ed, 1); pushd(ecx);                             /* push ecx */
            ii(0x1019_51ee, 2); pushd(fs);                              /* push fs */
            ii(0x1019_51f0, 2); pushd(gs);                              /* push gs */
            ii(0x1019_51f2, 1); pushd(es);                              /* push es */
            ii(0x1019_51f3, 1); pushd(ds);                              /* push ds */
            ii(0x1019_51f4, 1); pushd(ds);                              /* push ds */
            ii(0x1019_51f5, 1); popd(es);                               /* pop es */
            ii(0x1019_51f6, 5); mov(edi, 0x101c_1a60);                  /* mov edi, 0x101c1a60 */
            ii(0x1019_51fb, 3); mov(ebx, memd_a32[ss, ebp + 0x8]);      /* mov ebx, [ebp+0x8] */
            ii(0x1019_51fe, 6); lds(esi, ds, 0x101c_1ab0);              /* lds esi, [0x101c1ab0] */
            ii(0x1019_5204, 3); mov(esi, memd_a32[ds, esi + ebx * 4]);  /* mov esi, [esi+ebx*4] */
            ii(0x1019_5207, 3); cmp(esi, -0x1 /* 0xff */);              /* cmp esi, 0xffffffff */
            ii(0x1019_520a, 2); if(jnzd(0x1019_5218, 0xc)) goto l_0x1019_5218; /* jnz 0x10195218 */
            ii(0x1019_520c, 1); nop();                                  /* nop */
            ii(0x1019_520d, 1); nop();                                  /* nop */
            ii(0x1019_520e, 1); nop();                                  /* nop */
            ii(0x1019_520f, 1); nop();                                  /* nop */
            ii(0x1019_5210, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1019_5212, 1); popd(ds);                               /* pop ds */
            ii(0x1019_5213, 2); jmpd(0x1019_5226, 0x11); goto l_0x1019_5226; /* jmp 0x10195226 */
        //    ii(0x1019_5215, 1); nop();                                  /* nop */
        //    ii(0x1019_5216, 1); nop();                                  /* nop */
        //    ii(0x1019_5217, 1); nop();                                  /* nop */
        l_0x1019_5218:
            ii(0x1019_5218, 5); mov(ecx, 0x50);                         /* mov ecx, 0x50 */
            ii(0x1019_521d, 1); cld();                                  /* cld */
            ii(0x1019_521e, 2); repne_a32(() => movsb_a32());           /* repne movsb */
            ii(0x1019_5220, 1); popd(ds);                               /* pop ds */
            ii(0x1019_5221, 5); mov(eax, 0x101c_1a60);                  /* mov eax, 0x101c1a60 */
        l_0x1019_5226:
            ii(0x1019_5226, 1); popd(es);                               /* pop es */
            ii(0x1019_5227, 2); popd(gs);                               /* pop gs */
            ii(0x1019_5229, 2); popd(fs);                               /* pop fs */
            ii(0x1019_522b, 1); popd(ecx);                              /* pop ecx */
            ii(0x1019_522c, 1); popd(ebx);                              /* pop ebx */
            ii(0x1019_522d, 1); popd(edi);                              /* pop edi */
            ii(0x1019_522e, 1); popd(esi);                              /* pop esi */
            ii(0x1019_522f, 1); popd(ebp);                              /* pop ebp */
            ii(0x1019_5230, 1); retd(); return;                         /* ret */
        }
    }
}
