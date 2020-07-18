using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1019_5231-a792b4d0")]
        public void /* sys */ Method_1019_5231()
        {
            ii(0x1019_5231, 1);  push(ebp);                            /* push ebp */
            ii(0x1019_5232, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1019_5234, 1);  push(esi);                            /* push esi */
            ii(0x1019_5235, 1);  push(edi);                            /* push edi */
            ii(0x1019_5236, 1);  push(ebx);                            /* push ebx */
            ii(0x1019_5237, 1);  push(ecx);                            /* push ecx */
            ii(0x1019_5238, 2);  pushd(fs);                            /* push fs */
            ii(0x1019_523a, 2);  pushd(gs);                            /* push gs */
            ii(0x1019_523c, 1);  pushd(es);                            /* push es */
            ii(0x1019_523d, 6);  les(esi, memd[ds, 0x101c_1ab8]);      /* les esi, [0x101c1ab8] */
            ii(0x1019_5243, 3);  mov(eax, memd[ss, ebp + 8]);          /* mov eax, [ebp+0x8] */
            ii(0x1019_5246, 2);  mov(ebx, eax);                        /* mov ebx, eax */
            ii(0x1019_5248, 2);  shl(eax, 1);                          /* shl eax, 1 */
            ii(0x1019_524a, 3);  shl(ebx, 2);                          /* shl ebx, 0x2 */
            ii(0x1019_524d, 2);  add(ebx, eax);                        /* add ebx, eax */
            ii(0x1019_524f, 3);  mov(eax, memd[ss, ebp + 12]);         /* mov eax, [ebp+0xc] */
            ii(0x1019_5252, 4);  mov(memd[es, esi + ebx], eax);        /* mov [es:esi+ebx], eax */
            ii(0x1019_5256, 6);  mov(memw[es, esi + ebx + 4], ds);     /* mov [es:esi+ebx+0x4], ds */
            ii(0x1019_525c, 1);  popd(es);                             /* pop es */
            ii(0x1019_525d, 2);  popd(gs);                             /* pop gs */
            ii(0x1019_525f, 2);  popd(fs);                             /* pop fs */
            ii(0x1019_5261, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1019_5262, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1019_5263, 1);  pop(edi);                             /* pop edi */
            ii(0x1019_5264, 1);  pop(esi);                             /* pop esi */
            ii(0x1019_5265, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1019_5266, 1);  ret();                                /* ret */
        }
    }
}
