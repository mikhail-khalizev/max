using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1017_2cb8-3c56c609")]
        public void /* sys */ Method_1017_2cb8()
        {
            ii(0x1017_2cb8, 1); pushd(edx);                             /* push edx */
            ii(0x1017_2cb9, 6); mov(edx, memd_a32[ds, 0x1020_9540]);    /* mov edx, [0x10209540] */
            ii(0x1017_2cbf, 5); mov(memd_a32[ds, 0x1020_9540], eax);    /* mov [0x10209540], eax */
            ii(0x1017_2cc4, 3); cmp(eax, 0x4);                          /* cmp eax, 0x4 */
            ii(0x1017_2cc7, 2); if(jad(0x1017_2d26, 0x5d)) goto l_0x1017_2d26; /* ja 0x10172d26 */
            ii(0x1017_2cc9, 8); 
            switch (jmpd_abs_switch(memd_a32[cs, eax * 4 + /* sys */ 0x1017_2ca4]))
            {
                case 0x1017_2cd1:
                    goto l_0x1017_2cd1;
                case 0x1017_2ce2:
                    goto l_0x1017_2ce2;
                case 0x1017_2cf3:
                    goto l_0x1017_2cf3;
                case 0x1017_2d04:
                    goto l_0x1017_2d04;
                case 0x1017_2d15:
                    goto l_0x1017_2d15;
                default:
                    throw new NotImplementedException();
            } /* jmp dword [cs:eax*4+0x10172ca4] */
        l_0x1017_2cd1:
            ii(0x1017_2cd1, 10); mov(memd_a32[ds, 0x101b_e1f4], /* sys */ 0x1017_30b4); /* mov dword [0x101be1f4], 0x101730b4 */
            ii(0x1017_2cdb, 5); calld(/* sys */ 0x1017_49cc, 0x1cec);   /* call 0x101749cc */
            ii(0x1017_2ce0, 1); popd(edx);                              /* pop edx */
            ii(0x1017_2ce1, 1); retd(); return;                         /* ret */
        l_0x1017_2ce2:
            ii(0x1017_2ce2, 10); mov(memd_a32[ds, 0x101b_e1f4], /* sys */ 0x1017_335c); /* mov dword [0x101be1f4], 0x1017335c */
            ii(0x1017_2cec, 5); calld(/* sys */ 0x1017_7004, 0x4313);   /* call 0x10177004 */
            ii(0x1017_2cf1, 1); popd(edx);                              /* pop edx */
            ii(0x1017_2cf2, 1); retd(); return;                         /* ret */
        l_0x1017_2cf3:
            ii(0x1017_2cf3, 10); mov(memd_a32[ds, 0x101b_e1f4], /* sys */ 0x1017_3720); /* mov dword [0x101be1f4], 0x10173720 */
            ii(0x1017_2cfd, 5); calld(/* sys */ 0x1017_7770, 0x4a6e);   /* call 0x10177770 */
            ii(0x1017_2d02, 1); popd(edx);                              /* pop edx */
            ii(0x1017_2d03, 1); retd(); return;                         /* ret */
        l_0x1017_2d04:
            ii(0x1017_2d04, 10); mov(memd_a32[ds, 0x101b_e1f4], /* sys */ 0x1017_3c24); /* mov dword [0x101be1f4], 0x10173c24 */
            ii(0x1017_2d0e, 5); calld(/* sys */ 0x1017_80fc, 0x53e9);   /* call 0x101780fc */
            ii(0x1017_2d13, 1); popd(edx);                              /* pop edx */
            ii(0x1017_2d14, 1); retd(); return;                         /* ret */
        l_0x1017_2d15:
            ii(0x1017_2d15, 10); mov(memd_a32[ds, 0x101b_e1f4], /* sys */ 0x1017_3ecc); /* mov dword [0x101be1f4], 0x10173ecc */
            ii(0x1017_2d1f, 5); calld(/* sys */ 0x1017_8738, 0x5a14);   /* call 0x10178738 */
            ii(0x1017_2d24, 1); popd(edx);                              /* pop edx */
            ii(0x1017_2d25, 1); retd(); return;                         /* ret */
        l_0x1017_2d26:
            ii(0x1017_2d26, 6); mov(memd_a32[ds, 0x1020_9540], edx);    /* mov [0x10209540], edx */
            ii(0x1017_2d2c, 1); popd(edx);                              /* pop edx */
            ii(0x1017_2d2d, 1); retd(); return;                         /* ret */
        }
    }
}
