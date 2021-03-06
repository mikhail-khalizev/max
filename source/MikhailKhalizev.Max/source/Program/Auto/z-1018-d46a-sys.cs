using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1018_d46a-f5dc8405")]
        public void /* sys */ Method_1018_d46a()
        {
            ii(0x1018_d46a, 1);  push(ebx);                            /* push ebx */
            ii(0x1018_d46b, 1);  push(ecx);                            /* push ecx */
            ii(0x1018_d46c, 1);  push(edx);                            /* push edx */
            ii(0x1018_d46d, 2);  mov(ecx, eax);                        /* mov ecx, eax */
            ii(0x1018_d46f, 6);  mov(edx, memd[ds, 0x1020_b70c]);      /* mov edx, [0x1020b70c] */
            ii(0x1018_d475, 2);  xor(ebx, ebx);                        /* xor ebx, ebx */
            ii(0x1018_d477, 2);  jmp(0x1018_d48f, 0x16); goto l_0x1018_d48f;/* jmp 0x1018d48f */
        l_0x1018_d479:
            ii(0x1018_d479, 3);  mov(eax, memd[ds, edx + 4]);          /* mov eax, [edx+0x4] */
            ii(0x1018_d47c, 3);  test(memd[ds, eax + 12], ecx);        /* test [eax+0xc], ecx */
            ii(0x1018_d47f, 2);  if(jz(0x1018_d48d, 0xc)) goto l_0x1018_d48d;/* jz 0x1018d48d */
            ii(0x1018_d481, 1);  inc(ebx);                             /* inc ebx */
            ii(0x1018_d482, 4);  test(memb[ds, eax + 13], 0x10);       /* test byte [eax+0xd], 0x10 */
            ii(0x1018_d486, 2);  if(jz(0x1018_d48d, 5)) goto l_0x1018_d48d;/* jz 0x1018d48d */
            ii(0x1018_d488, 5);  call(/* sys */ 0x1018_d5d9, 0x14c);   /* call 0x1018d5d9 */
        l_0x1018_d48d:
            ii(0x1018_d48d, 2);  mov(edx, memd[ds, edx]);              /* mov edx, [edx] */
        l_0x1018_d48f:
            ii(0x1018_d48f, 2);  test(edx, edx);                       /* test edx, edx */
            ii(0x1018_d491, 2);  if(jnz(0x1018_d479, -0x1a)) goto l_0x1018_d479;/* jnz 0x1018d479 */
            ii(0x1018_d493, 2);  mov(eax, ebx);                        /* mov eax, ebx */
            ii(0x1018_d495, 1);  pop(edx);                             /* pop edx */
            ii(0x1018_d496, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1018_d497, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1018_d498, 1);  ret();                                /* ret */
        }
    }
}
