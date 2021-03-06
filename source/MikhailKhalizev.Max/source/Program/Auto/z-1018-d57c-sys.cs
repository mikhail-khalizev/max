using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1018_d57c-6b0187e9")]
        public void /* sys */ Method_1018_d57c()
        {
            ii(0x1018_d57c, 1);  push(ebx);                            /* push ebx */
            ii(0x1018_d57d, 1);  push(ecx);                            /* push ecx */
            ii(0x1018_d57e, 1);  push(edx);                            /* push edx */
            ii(0x1018_d57f, 2);  mov(ebx, eax);                        /* mov ebx, eax */
            ii(0x1018_d581, 5);  mov(edx, 0x1020_b70c);                /* mov edx, 0x1020b70c */
        l_0x1018_d586:
            ii(0x1018_d586, 2);  mov(eax, memd[ds, edx]);              /* mov eax, [edx] */
            ii(0x1018_d588, 2);  test(eax, eax);                       /* test eax, eax */
            ii(0x1018_d58a, 2);  if(jz(0x1018_d5b1, 0x25)) goto l_0x1018_d5b1;/* jz 0x1018d5b1 */
            ii(0x1018_d58c, 3);  mov(ecx, memd[ds, eax + 4]);          /* mov ecx, [eax+0x4] */
            ii(0x1018_d58f, 2);  cmp(ebx, ecx);                        /* cmp ebx, ecx */
            ii(0x1018_d591, 2);  if(jz(0x1018_d597, 4)) goto l_0x1018_d597;/* jz 0x1018d597 */
            ii(0x1018_d593, 2);  mov(edx, eax);                        /* mov edx, eax */
            ii(0x1018_d595, 2);  jmp(0x1018_d586, -0x11); goto l_0x1018_d586;/* jmp 0x1018d586 */
        l_0x1018_d597:
            ii(0x1018_d597, 3);  mov(cl, memb[ds, ecx + 12]);          /* mov cl, [ecx+0xc] */
            ii(0x1018_d59a, 3);  or(cl, 3);                            /* or cl, 0x3 */
            ii(0x1018_d59d, 3);  mov(memb[ds, ebx + 12], cl);          /* mov [ebx+0xc], cl */
            ii(0x1018_d5a0, 2);  mov(ebx, memd[ds, eax]);              /* mov ebx, [eax] */
            ii(0x1018_d5a2, 2);  mov(memd[ds, edx], ebx);              /* mov [edx], ebx */
            ii(0x1018_d5a4, 6);  mov(edx, memd[ds, 0x1020_a1f4]);      /* mov edx, [0x1020a1f4] */
            ii(0x1018_d5aa, 5);  mov(memd[ds, 0x1020_a1f4], eax);      /* mov [0x1020a1f4], eax */
            ii(0x1018_d5af, 2);  mov(memd[ds, eax], edx);              /* mov [eax], edx */
        l_0x1018_d5b1:
            ii(0x1018_d5b1, 1);  pop(edx);                             /* pop edx */
            ii(0x1018_d5b2, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1018_d5b3, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1018_d5b4, 1);  ret();                                /* ret */
        }
    }
}
