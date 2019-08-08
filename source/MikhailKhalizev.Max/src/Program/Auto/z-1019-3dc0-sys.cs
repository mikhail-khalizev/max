using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("329ada15-7b2e-4d39-8183-5cf55661d79d")]
        public void /* sys */ Method_1019_3dc0()
        {
            ii(0x1019_3dc0, 3); mov(ecx, memd_a32[ss, ebp + 0x14]);     /* mov ecx, [ebp+0x14] */
            ii(0x1019_3dc3, 5); mov(eax, 0);                            /* mov eax, 0x0 */
            ii(0x1019_3dc8, 2); jmpd(0x1019_3dd0, 0x6); goto l_0x1019_3dd0; /* jmp 0x10193dd0 */
        l_0x1019_3dca:
            ii(0x1019_3dca, 3); mov(dx, memw_a32[ds, ebx]);             /* mov dx, [ebx] */
            ii(0x1019_3dcd, 3); add(ebx, 0x2);                          /* add ebx, 0x2 */
        l_0x1019_3dd0:
            ii(0x1019_3dd0, 3); add(dx, dx);                            /* add dx, dx */
            ii(0x1019_3dd3, 2); if(jzd(0x1019_3dca, -0xb)) goto l_0x1019_3dca; /* jz 0x10193dca */
            ii(0x1019_3dd5, 2); if(jbd(0x1019_3dee, 0x17)) goto l_0x1019_3dee; /* jb 0x10193dee */
            ii(0x1019_3dd7, 3); add(esi, 0x10);                         /* add esi, 0x10 */
            ii(0x1019_3dda, 3); add(edi, 0x10);                         /* add edi, 0x10 */
            ii(0x1019_3ddd, 2); if(loopd_a32(0x1019_3dd0, -0xf)) goto l_0x1019_3dd0; /* loop 0x10193dd0 */
            ii(0x1019_3ddf, 2); if(jmpd_func(0x1019_3da0, -0x41)) return; /* jmp 0x10193da0 */
        l_0x1019_3de1:
            ii(0x1019_3de1, 3); mov(dx, memw_a32[ds, ebx]);             /* mov dx, [ebx] */
            ii(0x1019_3de4, 3); add(ebx, 0x2);                          /* add ebx, 0x2 */
        l_0x1019_3de7:
            ii(0x1019_3de7, 3); add(dx, dx);                            /* add dx, dx */
            ii(0x1019_3dea, 2); if(jad(0x1019_3dfa, 0xe)) goto l_0x1019_3dfa; /* ja 0x10193dfa */
            ii(0x1019_3dec, 2); if(jzd(0x1019_3de1, -0xd)) goto l_0x1019_3de1; /* jz 0x10193de1 */
        l_0x1019_3dee:
            ii(0x1019_3dee, 3); add(eax, 0x4);                          /* add eax, 0x4 */
            ii(0x1019_3df1, 2); if(loopd_a32(0x1019_3de7, -0xc)) goto l_0x1019_3de7; /* loop 0x10193de7 */
            ii(0x1019_3df3, 5); calld(/* sys */ 0x1019_3e0e, 0x16);     /* call 0x10193e0e */
            ii(0x1019_3df8, 2); if(jmpd_func(0x1019_3da0, -0x5a)) return; /* jmp 0x10193da0 */
        l_0x1019_3dfa:
            ii(0x1019_3dfa, 5); calld(/* sys */ 0x1019_3e0e, 0xf);      /* call 0x10193e0e */
            ii(0x1019_3dff, 3); add(esi, 0x10);                         /* add esi, 0x10 */
            ii(0x1019_3e02, 3); add(edi, 0x10);                         /* add edi, 0x10 */
            ii(0x1019_3e05, 5); mov(eax, 0);                            /* mov eax, 0x0 */
            ii(0x1019_3e0a, 2); if(loopd_a32(0x1019_3dd0, -0x3c)) goto l_0x1019_3dd0; /* loop 0x10193dd0 */
            ii(0x1019_3e0c, 2); if(jmpd_func(0x1019_3da0, -0x6e)) return; /* jmp 0x10193da0 */
        }
    }
}
