using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1018_1620-6f73bedc")]
        public void /* sys */ Method_1018_1620()
        {
            ii(0x1018_1620, 1);  push(ecx);                            /* push ecx */
            ii(0x1018_1621, 1);  push(esi);                            /* push esi */
            ii(0x1018_1622, 1);  push(edi);                            /* push edi */
            ii(0x1018_1623, 1);  pushd(es);                            /* push es */
            ii(0x1018_1624, 2);  mov(ecx, edx);                        /* mov ecx, edx */
            ii(0x1018_1626, 2);  mov(edi, ebx);                        /* mov edi, ebx */
            ii(0x1018_1628, 2);  mov(edx, eax);                        /* mov edx, eax */
            ii(0x1018_162a, 2);  mov(es, ecx);                         /* mov es, ecx */
            ii(0x1018_162c, 2);  xor(eax, eax);                        /* xor eax, eax */
        l_0x1018_162e:
            ii(0x1018_162e, 2);  mov(esi, edx);                        /* mov esi, edx */
            ii(0x1018_1630, 3);  mov(bl, memb[es, esi]);               /* mov bl, [es:esi] */
            ii(0x1018_1633, 1);  inc(edx);                             /* inc edx */
            ii(0x1018_1634, 2);  test(bl, bl);                         /* test bl, bl */
            ii(0x1018_1636, 2);  if(jz_func(0x1018_163f, 7)) return;   /* jz 0x1018163f */
            ii(0x1018_1638, 2);  cmp(eax, edi);                        /* cmp eax, edi */
            ii(0x1018_163a, 2);  if(jz_func(0x1018_163f, 3)) return;   /* jz 0x1018163f */
            ii(0x1018_163c, 1);  inc(eax);                             /* inc eax */
            ii(0x1018_163d, 2);  jmp(0x1018_162e, -0x11); goto l_0x1018_162e;/* jmp 0x1018162e */
        }
    }
}
