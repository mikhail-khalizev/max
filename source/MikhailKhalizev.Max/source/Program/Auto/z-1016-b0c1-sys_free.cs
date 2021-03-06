using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1016_b0c1-b24887ad")]
        public void /* sys */ sys_free()
        {
            ii(0x1016_b0c1, 1);  push(ebx);                            /* push ebx */
            ii(0x1016_b0c2, 1);  push(ecx);                            /* push ecx */
            ii(0x1016_b0c3, 1);  push(edx);                            /* push edx */
            ii(0x1016_b0c4, 1);  push(esi);                            /* push esi */
            ii(0x1016_b0c5, 1);  push(ebp);                            /* push ebp */
            ii(0x1016_b0c6, 2);  mov(esi, eax);                        /* mov esi, eax */
            ii(0x1016_b0c8, 2);  test(eax, eax);                       /* test eax, eax */
            ii(0x1016_b0ca, 6);  if(jz(0x1016_b13d, 0x6d)) goto l_0x1016_b13d;/* jz 0x1016b13d */
            ii(0x1016_b0d0, 6);  mov(ecx, memd[ds, 0x101c_f968]);      /* mov ecx, [0x101cf968] */
            ii(0x1016_b0d6, 2);  test(ecx, ecx);                       /* test ecx, ecx */
            ii(0x1016_b0d8, 2);  if(jz(0x1016_b0e3, 9)) goto l_0x1016_b0e3;/* jz 0x1016b0e3 */
            ii(0x1016_b0da, 2);  cmp(ecx, eax);                        /* cmp ecx, eax */
            ii(0x1016_b0dc, 2);  if(ja(0x1016_b0e3, 5)) goto l_0x1016_b0e3;/* ja 0x1016b0e3 */
            ii(0x1016_b0de, 3);  cmp(eax, memd[ds, ecx + 8]);          /* cmp eax, [ecx+0x8] */
            ii(0x1016_b0e1, 2);  if(jb(0x1016_b0fd, 0x1a)) goto l_0x1016_b0fd;/* jb 0x1016b0fd */
        l_0x1016_b0e3:
            ii(0x1016_b0e3, 6);  mov(ecx, memd[ds, 0x101b_de0c]);      /* mov ecx, [0x101bde0c] */
            ii(0x1016_b0e9, 2);  jmp(0x1016_b0f6, 0xb); goto l_0x1016_b0f6;/* jmp 0x1016b0f6 */
        l_0x1016_b0eb:
            ii(0x1016_b0eb, 2);  cmp(ecx, esi);                        /* cmp ecx, esi */
            ii(0x1016_b0ed, 2);  if(ja(0x1016_b0f3, 4)) goto l_0x1016_b0f3;/* ja 0x1016b0f3 */
            ii(0x1016_b0ef, 2);  cmp(esi, ebx);                        /* cmp esi, ebx */
            ii(0x1016_b0f1, 2);  if(jb(0x1016_b0fd, 0xa)) goto l_0x1016_b0fd;/* jb 0x1016b0fd */
        l_0x1016_b0f3:
            ii(0x1016_b0f3, 3);  mov(ecx, memd[ds, ecx + 8]);          /* mov ecx, [ecx+0x8] */
        l_0x1016_b0f6:
            ii(0x1016_b0f6, 3);  mov(ebx, memd[ds, ecx + 8]);          /* mov ebx, [ecx+0x8] */
            ii(0x1016_b0f9, 2);  test(ebx, ebx);                       /* test ebx, ebx */
            ii(0x1016_b0fb, 2);  if(jnz(0x1016_b0eb, -0x12)) goto l_0x1016_b0eb;/* jnz 0x1016b0eb */
        l_0x1016_b0fd:
            ii(0x1016_b0fd, 5);  mov(eax, 0x101b_de0c);                /* mov eax, 0x101bde0c */
            ii(0x1016_b102, 2);  mov(edx, ds);                         /* mov edx, ds */
            ii(0x1016_b104, 6);  and(edx, 0xffff);                     /* and edx, 0xffff */
            ii(0x1016_b10a, 2);  mov(ebx, ecx);                        /* mov ebx, ecx */
            ii(0x1016_b10c, 2);  mov(eax, esi);                        /* mov eax, esi */
            ii(0x1016_b10e, 5);  call(/* sys */ 0x1018_6a20, 0x1_b90d);/* call 0x10186a20 */
            ii(0x1016_b113, 6);  mov(ebp, memd[ds, 0x101b_de10]);      /* mov ebp, [0x101bde10] */
            ii(0x1016_b119, 6);  mov(memd[ds, 0x101c_f968], ecx);      /* mov [0x101cf968], ecx */
            ii(0x1016_b11f, 2);  cmp(ecx, ebp);                        /* cmp ecx, ebp */
            ii(0x1016_b121, 2);  if(jae(0x1016_b135, 0x12)) goto l_0x1016_b135;/* jae 0x1016b135 */
            ii(0x1016_b123, 5);  mov(eax, memd[ds, 0x101b_de14]);      /* mov eax, [0x101bde14] */
            ii(0x1016_b128, 3);  mov(edx, memd[ds, ecx + 20]);         /* mov edx, [ecx+0x14] */
            ii(0x1016_b12b, 2);  cmp(edx, eax);                        /* cmp edx, eax */
            ii(0x1016_b12d, 2);  if(jbe(0x1016_b135, 6)) goto l_0x1016_b135;/* jbe 0x1016b135 */
            ii(0x1016_b12f, 6);  mov(memd[ds, 0x101b_de14], edx);      /* mov [0x101bde14], edx */
        l_0x1016_b135:
            ii(0x1016_b135, 2);  xor(ah, ah);                          /* xor ah, ah */
            ii(0x1016_b137, 6);  mov(memb[ds, 0x1020_a2d4], ah);       /* mov [0x1020a2d4], ah */
        l_0x1016_b13d:
            ii(0x1016_b13d, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1016_b13e, 1);  pop(esi);                             /* pop esi */
            ii(0x1016_b13f, 1);  pop(edx);                             /* pop edx */
            ii(0x1016_b140, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1016_b141, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1016_b142, 1);  ret();                                /* ret */
        }
    }
}
