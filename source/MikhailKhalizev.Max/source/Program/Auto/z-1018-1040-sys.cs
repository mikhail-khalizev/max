using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1018_1040-4fd1d66a")]
        public void /* sys */ Method_1018_1040()
        {
            ii(0x1018_1040, 2);  or(ecx, ecx);                         /* or ecx, ecx */
            ii(0x1018_1042, 2);  if(jz(0x1018_1070, 0x2c)) goto l_0x1018_1070;/* jz 0x10181070 */
            ii(0x1018_1044, 2);  cmp(memb[ds, eax], dl);               /* cmp [eax], dl */
        l_0x1018_1046:
            ii(0x1018_1046, 2);  test(al, 3);                          /* test al, 0x3 */
            ii(0x1018_1048, 2);  if(jz(0x1018_1053, 9)) goto l_0x1018_1053;/* jz 0x10181053 */
            ii(0x1018_104a, 2);  mov(memb[ds, eax], dl);               /* mov [eax], dl */
            ii(0x1018_104c, 1);  inc(eax);                             /* inc eax */
            ii(0x1018_104d, 3);  ror(edx, 8);                          /* ror edx, 0x8 */
            ii(0x1018_1050, 1);  dec(ecx);                             /* dec ecx */
            ii(0x1018_1051, 2);  if(jnz(0x1018_1046, -0xd)) goto l_0x1018_1046;/* jnz 0x10181046 */
        l_0x1018_1053:
            ii(0x1018_1053, 1);  push(ecx);                            /* push ecx */
            ii(0x1018_1054, 3);  shr(ecx, 2);                          /* shr ecx, 0x2 */
            ii(0x1018_1057, 5);  call(/* sys */ 0x1018_1077, 0x1b);    /* call 0x10181077 */
            ii(0x1018_105c, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1018_105d, 3);  and(ecx, 3);                          /* and ecx, 0x3 */
            ii(0x1018_1060, 2);  if(jz(0x1018_1070, 0xe)) goto l_0x1018_1070;/* jz 0x10181070 */
            ii(0x1018_1062, 2);  mov(memb[ds, eax], dl);               /* mov [eax], dl */
            ii(0x1018_1064, 1);  dec(ecx);                             /* dec ecx */
            ii(0x1018_1065, 2);  if(jz(0x1018_1070, 9)) goto l_0x1018_1070;/* jz 0x10181070 */
            ii(0x1018_1067, 3);  mov(memb[ds, eax + 1], dh);           /* mov [eax+0x1], dh */
            ii(0x1018_106a, 1);  dec(ecx);                             /* dec ecx */
            ii(0x1018_106b, 2);  if(jz(0x1018_1070, 3)) goto l_0x1018_1070;/* jz 0x10181070 */
            ii(0x1018_106d, 3);  mov(memb[ds, eax + 2], dl);           /* mov [eax+0x2], dl */
        l_0x1018_1070:
            ii(0x1018_1070, 1);  ret();                                /* ret */
        }
    }
}
