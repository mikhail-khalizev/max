using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1019_3e66-a20ca603")]
        public void /* sys */ Method_1019_3e66()
        {
            ii(0x1019_3e66, 1); pushd(ebx);                             /* push ebx */
            ii(0x1019_3e67, 1); pushd(edx);                             /* push edx */
            ii(0x1019_3e68, 1); pushd(esi);                             /* push esi */
            ii(0x1019_3e69, 1); pushd(edi);                             /* push edi */
            ii(0x1019_3e6a, 3); mov(ecx, memd_a32[ss, ebp + 0x14]);     /* mov ecx, [ebp+0x14] */
            ii(0x1019_3e6d, 5); mov(eax, 0);                            /* mov eax, 0x0 */
            ii(0x1019_3e72, 2); jmpd(0x1019_3e7a, 0x6); goto l_0x1019_3e7a; /* jmp 0x10193e7a */
        l_0x1019_3e74:
            ii(0x1019_3e74, 3); mov(dx, memw_a32[ds, ebx]);             /* mov dx, [ebx] */
            ii(0x1019_3e77, 3); add(ebx, 0x2);                          /* add ebx, 0x2 */
        l_0x1019_3e7a:
            ii(0x1019_3e7a, 3); add(dx, dx);                            /* add dx, dx */
            ii(0x1019_3e7d, 2); if(jzd(0x1019_3e74, -0xb)) goto l_0x1019_3e74; /* jz 0x10193e74 */
            ii(0x1019_3e7f, 2); if(jbd(0x1019_3e9b, 0x1a)) goto l_0x1019_3e9b; /* jb 0x10193e9b */
            ii(0x1019_3e81, 3); add(esi, 0x10);                         /* add esi, 0x10 */
            ii(0x1019_3e84, 3); add(edi, 0x10);                         /* add edi, 0x10 */
            ii(0x1019_3e87, 2); if(loopd_a32(0x1019_3e7a, -0xf)) goto l_0x1019_3e7a; /* loop 0x10193e7a */
            ii(0x1019_3e89, 5); if(jmpd_func(0x1019_3f62, 0xd4)) return; /* jmp 0x10193f62 */
        l_0x1019_3e8e:
            ii(0x1019_3e8e, 3); mov(dx, memw_a32[ds, ebx]);             /* mov dx, [ebx] */
            ii(0x1019_3e91, 3); add(ebx, 0x2);                          /* add ebx, 0x2 */
        l_0x1019_3e94:
            ii(0x1019_3e94, 3); add(dx, dx);                            /* add dx, dx */
            ii(0x1019_3e97, 2); if(jad(0x1019_3eaa, 0x11)) goto l_0x1019_3eaa; /* ja 0x10193eaa */
            ii(0x1019_3e99, 2); if(jzd(0x1019_3e8e, -0xd)) goto l_0x1019_3e8e; /* jz 0x10193e8e */
        l_0x1019_3e9b:
            ii(0x1019_3e9b, 3); add(eax, 0x4);                          /* add eax, 0x4 */
            ii(0x1019_3e9e, 2); if(loopd_a32(0x1019_3e94, -0xc)) goto l_0x1019_3e94; /* loop 0x10193e94 */
            ii(0x1019_3ea0, 5); calld(/* sys */ 0x1019_3ec1, 0x1c);     /* call 0x10193ec1 */
            ii(0x1019_3ea5, 5); if(jmpd_func(0x1019_3f62, 0xb8)) return; /* jmp 0x10193f62 */
        l_0x1019_3eaa:
            ii(0x1019_3eaa, 5); calld(/* sys */ 0x1019_3ec1, 0x12);     /* call 0x10193ec1 */
            ii(0x1019_3eaf, 3); add(esi, 0x10);                         /* add esi, 0x10 */
            ii(0x1019_3eb2, 3); add(edi, 0x10);                         /* add edi, 0x10 */
            ii(0x1019_3eb5, 5); mov(eax, 0);                            /* mov eax, 0x0 */
            ii(0x1019_3eba, 2); if(loopd_a32(0x1019_3e7a, -0x42)) goto l_0x1019_3e7a; /* loop 0x10193e7a */
            ii(0x1019_3ebc, 5); if(jmpd_func(0x1019_3f62, 0xa1)) return; /* jmp 0x10193f62 */
        }
    }
}
