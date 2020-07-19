using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1018_1644-6ef8f1c7")]
        public void /* sys */ Method_1018_1644()
        {
            ii(0x1018_1644, 1);  push(ecx);                            /* push ecx */
            ii(0x1018_1645, 1);  push(esi);                            /* push esi */
            ii(0x1018_1646, 1);  push(edi);                            /* push edi */
            ii(0x1018_1647, 1);  pushd(es);                            /* push es */
            ii(0x1018_1648, 2);  mov(ecx, eax);                        /* mov ecx, eax */
            ii(0x1018_164a, 2);  mov(esi, ebx);                        /* mov esi, ebx */
            ii(0x1018_164c, 2);  mov(ebx, ecx);                        /* mov ebx, ecx */
            ii(0x1018_164e, 2);  mov(es, edx);                         /* mov es, edx */
            ii(0x1018_1650, 2);  xor(eax, eax);                        /* xor eax, eax */
        l_0x1018_1652:
            ii(0x1018_1652, 2);  mov(ecx, ebx);                        /* mov ecx, ebx */
            ii(0x1018_1654, 4);  mov(di, memw[es, ecx]);               /* mov di, [es:ecx] */
            ii(0x1018_1658, 3);  add(ebx, 2);                          /* add ebx, 0x2 */
            ii(0x1018_165b, 3);  test(di, di);                         /* test di, di */
            ii(0x1018_165e, 2);  if(jz_func(0x1018_163f, -0x21)) return;/* jz 0x1018163f */
            ii(0x1018_1660, 2);  cmp(eax, esi);                        /* cmp eax, esi */
            ii(0x1018_1662, 2);  if(jz_func(0x1018_163f, -0x25)) return;/* jz 0x1018163f */
            ii(0x1018_1664, 1);  inc(eax);                             /* inc eax */
            ii(0x1018_1665, 2);  jmp(0x1018_1652, -0x15); goto l_0x1018_1652;/* jmp 0x10181652 */
        }
    }
}
