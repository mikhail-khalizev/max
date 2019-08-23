using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1017_2c3c-3aeb7ca5")]
        public void /* sys */ Method_1017_2c3c()
        {
            ii(0x1017_2c3c, 1); push(edx);                              /* push edx */
            ii(0x1017_2c3d, 6); mov(ah, memb[ds, 0x101b_e1e0]);         /* mov ah, [0x101be1e0] */
            ii(0x1017_2c43, 5); mov(edx, 0xffff_ffff);                  /* mov edx, 0xffffffff */
            ii(0x1017_2c48, 2); test(ah, ah);                           /* test ah, ah */
            ii(0x1017_2c4a, 2); if(jz(0x1017_2c58, 0xc)) goto l_0x1017_2c58; /* jz 0x10172c58 */
            ii(0x1017_2c4c, 6); call_abs(memd[ds, 0x101b_e1f4]);        /* call dword [0x101be1f4] */ /* Вызов '0x1017_30b4'. */
            ii(0x1017_2c52, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1017_2c54, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x1017_2c56, 1); pop(edx);                               /* pop edx */
            ii(0x1017_2c57, 1); ret(); return;                          /* ret */
        l_0x1017_2c58:
            ii(0x1017_2c58, 5); call(/* sys */ 0x1018_d7ae, 0x1_ab51);  /* call 0x1018d7ae */
            ii(0x1017_2c5d, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1017_2c5f, 2); if(jz(0x1017_2c7e, 0x1d)) goto l_0x1017_2c7e; /* jz 0x10172c7e */
            ii(0x1017_2c61, 5); call(/* sys */ 0x1017_9285, 0x661f);    /* call 0x10179285 */
            ii(0x1017_2c66, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1017_2c68, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1017_2c6a, 2); if(jz(0x1017_2c73, 0x7)) goto l_0x1017_2c73; /* jz 0x10172c73 */
            ii(0x1017_2c6c, 5); cmp(eax, 0xe0);                         /* cmp eax, 0xe0 */
            ii(0x1017_2c71, 2); if(jnz(0x1017_2c7e, 0xb)) goto l_0x1017_2c7e; /* jnz 0x10172c7e */
        l_0x1017_2c73:
            ii(0x1017_2c73, 5); call(/* sys */ 0x1017_9285, 0x660d);    /* call 0x10179285 */
            ii(0x1017_2c78, 6); lea(edx, eax + 0x100);                  /* lea edx, [eax+0x100] */
        l_0x1017_2c7e:
            ii(0x1017_2c7e, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x1017_2c80, 1); pop(edx);                               /* pop edx */
            ii(0x1017_2c81, 1); ret();                                  /* ret */
        }
    }
}
